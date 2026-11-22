// ApkZipWriter — a minimal, alignment-correct ZIP writer for APK payloads.
//
// WHY THIS EXISTS
// ---------------
// Rebuilding the payload with System.IO.Compression.ZipArchive silently deflates
// every entry. That breaks installation on Android R+ (targetSdk >= 30):
//
//   Failure [-124: Failed parse during installPackageLI: Targeting R+ (version
//   30 and above) requires the resources.arsc of installed APKs to be stored
//   uncompressed and aligned on a 4-byte boundary]
//
// The vendor template stores 220 of its 877 entries (all of res/, resources.arsc
// and 9 assets) and leaves resources.arsc 4-byte aligned. This writer preserves
// the source entry's compression method and can pad a local header with the
// standard 0xD935 alignment extra field so data lands on a 4-byte boundary.
//
// Shared verbatim by BtServer (net8.0) and BtMob (net462) — see the linked
// <Compile Include="..\shared\ApkZipWriter.cs" /> items in both csproj files.

using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace OpenRats;

/// <summary>One entry to write. <see cref="Data"/> is always the uncompressed bytes.</summary>
public sealed class ApkZipEntry
{
	public string Name;
	public byte[] Data;

	/// <summary>True to write with method 0 (STORED) instead of deflate.</summary>
	public bool Store;

	/// <summary>True to pad the local header so the data starts on a 4-byte boundary.</summary>
	public bool Align;

	/// <summary>DOS time/date and external attributes carried over from the source APK.</summary>
	public ushort DosTime;
	public ushort DosDate;
	public int ExternalAttributes;

	public ApkZipEntry() { }

	public ApkZipEntry(string name, byte[] data, bool store, bool align)
	{
		Name = name;
		Data = data;
		Store = store;
		Align = align;
	}
}

public static class ApkZipWriter
{
	private const uint LocalHeaderSig = 0x04034b50;
	private const uint CentralHeaderSig = 0x02014b50;
	private const uint EocdSig = 0x06054b50;

	/// <summary>Extra-field id zipalign uses for 4-byte alignment padding.</summary>
	private const ushort AlignExtraId = 0xD935;

	/// <summary>
	/// Write <paramref name="entries"/> to <paramref name="path"/> in the order given.
	/// Entries flagged <see cref="ApkZipEntry.Store"/> are stored; the rest are deflated
	/// (falling back to stored when deflate does not help).
	/// </summary>
	public static void Write(string path, IList<ApkZipEntry> entries)
	{
		Directory.CreateDirectory(Path.GetDirectoryName(Path.GetFullPath(path)));

		using var fs = new FileStream(path, FileMode.Create, FileAccess.Write);
		using var w = new BinaryWriter(fs);

		var offsets = new long[entries.Count];
		var methods = new ushort[entries.Count];
		var crcs = new uint[entries.Count];
		var compressed = new byte[entries.Count][];
		var extraLens = new int[entries.Count];

		for (int i = 0; i < entries.Count; i++)
		{
			ApkZipEntry e = entries[i];
			byte[] data = e.Data ?? Array.Empty<byte>();
			byte[] nameBytes = System.Text.Encoding.UTF8.GetBytes(e.Name);

			bool store = e.Store;
			byte[] payload = data;
			if (!store)
			{
				byte[] deflated = Deflate(data);
				if (deflated.Length < data.Length) payload = deflated;
				else store = true; // deflate made it bigger
			}

			methods[i] = (ushort)(store ? 0 : 8);
			crcs[i] = Crc32(data);
			compressed[i] = payload;

			// Align only when asked, and only for stored entries (alignment of a
			// deflated stream is irrelevant to Android's checks).
			int extraLen = 0;
			if (e.Align && store)
			{
				int baseOffset = (int)fs.Position + 30 + nameBytes.Length;
				int misalign = baseOffset % 4;
				int needed = misalign == 0 ? 0 : 4 - misalign;
				extraLen = needed == 0 ? 0 : needed + 4;
			}
			extraLens[i] = extraLen;
			offsets[i] = fs.Position;

			w.Write(LocalHeaderSig);
			w.Write((ushort)20);                        // version needed
			w.Write((ushort)0);                         // flags
			w.Write(methods[i]);
			w.Write(e.DosTime);
			w.Write(e.DosDate);
			w.Write(crcs[i]);
			w.Write((uint)payload.Length);              // compressed size
			w.Write((uint)data.Length);                 // uncompressed size
			w.Write((ushort)nameBytes.Length);
			w.Write((ushort)extraLen);
			w.Write(nameBytes);
			if (extraLen > 0)
			{
				w.Write(AlignExtraId);
				w.Write((ushort)(extraLen - 4));        // field data length
				for (int k = 0; k < extraLen - 4; k++) w.Write((byte)0);
			}
			w.Write(payload);
		}

		long cdOffset = fs.Position;
		for (int i = 0; i < entries.Count; i++)
		{
			ApkZipEntry e = entries[i];
			byte[] nameBytes = System.Text.Encoding.UTF8.GetBytes(e.Name);
			w.Write(CentralHeaderSig);
			w.Write((ushort)20);                        // version made by
			w.Write((ushort)20);                        // version needed
			w.Write((ushort)0);                         // flags
			w.Write(methods[i]);
			w.Write(e.DosTime);
			w.Write(e.DosDate);
			w.Write(crcs[i]);
			w.Write((uint)compressed[i].Length);
			w.Write((uint)(e.Data?.Length ?? 0));
			w.Write((ushort)nameBytes.Length);
			w.Write((ushort)extraLens[i]);
			w.Write((ushort)0);                         // comment length
			w.Write((ushort)0);                         // disk number start
			w.Write((ushort)0);                         // internal attrs
			w.Write(e.ExternalAttributes);
			w.Write((uint)offsets[i]);
			w.Write(nameBytes);
			if (extraLens[i] > 0)
			{
				w.Write(AlignExtraId);
				w.Write((ushort)(extraLens[i] - 4));
				for (int k = 0; k < extraLens[i] - 4; k++) w.Write((byte)0);
			}
		}
		long cdSize = fs.Position - cdOffset;

		w.Write(EocdSig);
		w.Write((ushort)0);
		w.Write((ushort)0);
		w.Write((ushort)entries.Count);
		w.Write((ushort)entries.Count);
		w.Write((uint)cdSize);
		w.Write((uint)cdOffset);
		w.Write((ushort)0);
		w.Flush();
	}

	private static byte[] Deflate(byte[] data)
	{
		using var ms = new MemoryStream();
		using (var ds = new DeflateStream(ms, CompressionLevel.Optimal, leaveOpen: true))
			ds.Write(data, 0, data.Length);
		return ms.ToArray();
	}

	private static readonly uint[] CrcTable = BuildCrcTable();

	private static uint[] BuildCrcTable()
	{
		var table = new uint[256];
		for (uint i = 0; i < 256; i++)
		{
			uint c = i;
			for (int k = 0; k < 8; k++)
				c = (c & 1) != 0 ? 0xEDB88320u ^ (c >> 1) : c >> 1;
			table[i] = c;
		}
		return table;
	}

	public static uint Crc32(byte[] data)
	{
		uint c = 0xFFFFFFFF;
		foreach (byte b in data) c = CrcTable[(c ^ b) & 0xFF] ^ (c >> 8);
		return c ^ 0xFFFFFFFF;
	}

	/// <summary>DOS timestamp from a DateTime, for carrying source entry times.</summary>
	public static void ToDosTime(DateTime when, out ushort dosTime, out ushort dosDate)
	{
		if (when.Year < 1980) when = new DateTime(1980, 1, 1);
		dosTime = (ushort)((when.Hour << 11) | (when.Minute << 5) | (when.Second / 2));
		dosDate = (ushort)(((when.Year - 1980) << 9) | (when.Month << 5) | when.Day);
	}
}
