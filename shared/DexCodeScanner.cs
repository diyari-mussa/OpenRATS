// DexCodeScanner — enumerate every const-string / const-string/jumbo operand in a
// DEX's code items, so string_ids rotations can be remapped in the bytecode too.
// Walks class_defs -> class_data_item -> encoded_method.code_off and then decodes
// the instruction stream with a proper format-length table.
//
// Split out of DexStringPatcher to keep that file readable; both are shared by
// BtServer and BtMob.
//
// NOTE: string indices also appear in a few rarer places that this scanner
// covers only partially (annotation elements, debug info). Those are stable for
// the literals patched here, so a rotation only needs the const-string operands
// plus the type/proto/field/method/class tables (see DexStringPatcher).

using System;
using System.Collections.Generic;

namespace OpenRats;

internal static class DexCodeScanner
{
	/// <summary>
	/// Invoke <paramref name="visit"/> for every string index operand of a
	/// const-string (0x1A) or const-string/jumbo (0x1B) instruction.
	/// </summary>
	public static void ForEachConstString(byte[] dex, Action<string> visit)
	{
		foreach (int codeOff in EnumerateCodeItems(dex))
			ScanInsns(dex, codeOff, visit);
	}

	/// <summary>Collect every code_item offset reachable from class_defs.</summary>
	private static IEnumerable<int> EnumerateCodeItems(byte[] dex)
	{
		var seen = new HashSet<int>();
		uint mapOff = ReadU32(dex, 52);
		if (mapOff == 0 || mapOff + 4 > dex.Length) yield break;
		uint mapSize = ReadU32(dex, mapOff);

		for (uint e = 0; e < mapSize; e++)
		{
			uint p = mapOff + 4 + e * 12;
			if (p + 12 > dex.Length) break;
			if (ReadU16(dex, p) != 0x0006) continue;      // class_def_item
			uint count = ReadU32(dex, p + 4), off = ReadU32(dex, p + 8);

			for (uint i = 0; i < count; i++)
			{
				uint cd = off + i * 32;
				if (cd + 32 > dex.Length) break;
				uint classDataOff = ReadU32(dex, cd + 24);
				if (classDataOff == 0 || classDataOff >= dex.Length) continue;

				foreach (int codeOff in MethodsInClassData(dex, (int)classDataOff))
					if (codeOff != 0 && seen.Add(codeOff)) yield return codeOff;
			}
		}
	}

	/// <summary>Decode class_data_item and yield each method's code_off.</summary>
	private static IEnumerable<int> MethodsInClassData(byte[] dex, int at)
	{
		int p = at;
		int staticFields = (int)ReadUleb(dex, ref p);
		int instanceFields = (int)ReadUleb(dex, ref p);
		int directMethods = (int)ReadUleb(dex, ref p);
		int virtualMethods = (int)ReadUleb(dex, ref p);

		for (int i = 0; i < staticFields + instanceFields; i++)
		{
			ReadUleb(dex, ref p);   // field_idx_diff
			ReadUleb(dex, ref p);   // access_flags
		}
		for (int i = 0; i < directMethods + virtualMethods; i++)
		{
			ReadUleb(dex, ref p);                     // method_idx_diff
			ReadUleb(dex, ref p);                     // access_flags
			uint codeOff = ReadUleb(dex, ref p);
			yield return (int)codeOff;
		}
	}

	/// <summary>Walk one instruction stream and report const-string operands.</summary>
	private static void ScanInsns(byte[] dex, int codeOff, Action<string> visit)
	{
		if (codeOff + 16 > dex.Length) return;
		uint insnsSize = ReadU32(dex, (uint)codeOff + 12);
		int insns = codeOff + 16;
		if (insnsSize == 0 || insns + (long)insnsSize * 2 > dex.Length) return;

		int k = 0;
		while (k < insnsSize)
		{
			int unitOff = insns + k * 2;
			int op = dex[unitOff];
			int len = InstructionLength(op);

			if (op == 0x1A && k + 1 < insnsSize)
			{
				int index = ReadU16(dex, (uint)(unitOff + 2));
				visit(new[] { unitOff + 2, index }.Length == 2 ? (unitOff + 2) + ":" + index : null);
			}
			else if (op == 0x1B && k + 2 < insnsSize)
			{
				int index = ReadU16(dex, (uint)(unitOff + 2)) | (ReadU16(dex, (uint)(unitOff + 4)) << 16);
				visit((unitOff + 2) + ":" + index);
			}

			k += Math.Max(1, len);
		}
	}

	/// <summary>Number of 16-bit code units for each opcode (Dalvik spec).</summary>
	private static int InstructionLength(int op)
	{
		if (op <= 0x09) return op == 0x02 || op == 0x05 || op == 0x08 ? 2 : (op == 0x03 || op == 0x06 || op == 0x09 ? 3 : 1);
		if (op <= 0x1B) return op switch
		{
			0x13 or 0x15 or 0x16 or 0x19 or 0x1A or 0x1C => 2,
			0x14 or 0x17 or 0x1B => 3,
			0x18 => 5,
			_ => 1
		};
		if (op <= 0x25) return op switch
		{
			0x1F or 0x20 or 0x22 or 0x23 => 2,
			0x24 or 0x25 or 0x26 => 3,
			_ => 1
		};
		if (op <= 0x2C) return op == 0x28 ? 1 : (op == 0x2B || op == 0x2C ? 3 : 2);
		if (op <= 0x31) return 2;                        // cmp-*
		if (op <= 0x43) return 2;                        // if-* / if-*z
		if (op <= 0x51) return 2;                        // aget/aput
		if (op <= 0x5F) return 2;                        // iget/iput
		if (op <= 0x6D) return 2;                        // sget/sput
		if (op <= 0x72) return 3;                        // invoke-*
		if (op == 0x73) return 1;                        // unused
		if (op <= 0x78) return 3;                        // invoke-*/range
		if (op <= 0x7A) return 1;                        // unused
		if (op <= 0x8F) return 1;                        // unop
		if (op <= 0xAF) return 1;                        // binop
		if (op <= 0xCF) return 1;                        // binop/2addr
		if (op <= 0xD7) return 2;                        // binop/lit16
		if (op <= 0xE2) return 2;                        // binop/lit8
		if (op <= 0xF9) return 1;                        // unused
		if (op <= 0xFB) return 4;                        // invoke-polymorphic
		if (op <= 0xFD) return 3;                        // invoke-custom
		return 2;                                        // const-method-handle/type
	}

	private static uint ReadUleb(byte[] b, ref int p)
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

	private static ushort ReadU16(byte[] b, uint off)
	{
		int o = (int)off;
		return (ushort)(b[o] | (b[o + 1] << 8));
	}

	private static uint ReadU32(byte[] b, uint off)
	{
		int o = (int)off;
		return (uint)(b[o] | (b[o + 1] << 8) | (b[o + 2] << 16) | (b[o + 3] << 24));
	}
}
