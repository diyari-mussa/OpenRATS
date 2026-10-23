// Robust .resources parser: enumerate ALL entries with sizes, tolerate junk,
// and save every byte[] > 64KB (potential EXGuarder method-body store).
using System;
using System.Buffers.Binary;
using System.IO;
using System.Linq;
using System.Text;

class Program
{
	static void Main(string[] args)
	{
		string exePath = args[0];
		string outDir = args.Length > 1 ? args[1] : ".";
		System.Reflection.Assembly asm = System.Reflection.Assembly.LoadFrom(exePath);
		using Stream s = asm.GetManifestResourceStream("BTMOB.Resources.resources");
		using MemoryStream ms = new MemoryStream();
		s.CopyTo(ms);
		byte[] data = ms.ToArray();
		Console.WriteLine($"blob size: {data.Length}");

		int p = 4;
		int readerVer = BinaryPrimitives.ReadInt32LittleEndian(data.AsSpan(p)); p += 4;
		int len1 = BinaryPrimitives.ReadInt32LittleEndian(data.AsSpan(p)); p += 4;
		p += len1;
		int headerVer = BinaryPrimitives.ReadInt32LittleEndian(data.AsSpan(p)); p += 4;
		if (headerVer == 1) { p += 4; }
		int len2 = Read7BitInt(data, ref p);
		p += len2;
		int numTypes = Read7BitInt(data, ref p);
		Console.WriteLine($"numTypes={numTypes}");
		for (int i = 0; i < numTypes; i++)
		{
			int tn = Read7BitInt(data, ref p);
			p += tn; // skip type name bytes; no decode to avoid crash
		}
		Console.WriteLine($"after types, p=0x{p:X}");
		int numInts = BinaryPrimitives.ReadInt32LittleEndian(data.AsSpan(p)); p += 4;
		int numStrings = BinaryPrimitives.ReadInt32LittleEndian(data.AsSpan(p)); p += 4;
		Console.WriteLine($"numInts={numInts} numStrings={numStrings}");
		if (numInts is < 0 or > 10000 || numStrings is < 0 or > 100000)
		{
			Console.WriteLine("implausible counts — misaligned; dumping context bytes:");
			Console.WriteLine(BitConverter.ToString(data, p - 16, 32));
			return;
		}
		for (int i = 0; i < numInts; i++) { BinaryPrimitives.ReadInt32LittleEndian(data.AsSpan(p)); p += 4; }
		string[] names = new string[numStrings];
		for (int i = 0; i < numStrings; i++)
		{
			int l = Read7BitInt(data, ref p);
			try { names[i] = Encoding.Unicode.GetString(data, p, l * 2); } catch { names[i] = $"<bad{i}>"; }
			p += l * 2;
		}
		Console.WriteLine("first 12 names: " + string.Join(" | ", names.Take(12)));
		p = (p + 7) & ~7;
		int bigCount = 0;
		for (int i = 0; i < numStrings; i++)
		{
			BinaryPrimitives.ReadInt32LittleEndian(data.AsSpan(p)); p += 4;
			int off = BinaryPrimitives.ReadInt32LittleEndian(data.AsSpan(p)); p += 4;
			if (off < 0 || off >= data.Length) { Console.WriteLine($"  [{i}] bad offset {off}"); break; }
			int q = off;
			int nameLen2 = Read7BitInt(data, ref q);
			string name;
			try { name = Encoding.Unicode.GetString(data, q, nameLen2 * 2); } catch { name = $"<badname{i}>"; }
			q += nameLen2 * 2;
			int typeInfo = Read7BitInt(data, ref q);
			int typeIndex = typeInfo >> 3;
			string sizeInfo = "";
			if (typeIndex == 0x20)
			{
				int blen = Read7BitInt(data, ref q);
				sizeInfo = $"byte[{blen}]";
				if (blen > 65536)
				{
					bigCount++;
					string fn = new string(name.Where(c => !Path.GetInvalidFileNameChars().Contains(c)).ToArray()) + ".bin";
					File.WriteAllBytes(Path.Combine(outDir, fn), data.AsSpan(q, blen).ToArray());
					Console.WriteLine($"  [{i}] '{name}' {sizeInfo} -> saved {fn}");
				}
			}
			else if (typeIndex >= 0x40)
			{
				int blen = Read7BitInt(data, ref q);
				sizeInfo = $"userdata[{blen}]";
				if (blen > 65536)
				{
					bigCount++;
					string fn = new string(name.Where(c => !Path.GetInvalidFileNameChars().Contains(c)).ToArray()) + ".bin";
					File.WriteAllBytes(Path.Combine(outDir, fn), data.AsSpan(q, blen).ToArray());
					Console.WriteLine($"  [{i}] '{name}' {sizeInfo} -> saved {fn}");
				}
			}
			else if (i < 12)
			{
				Console.WriteLine($"  [{i}] '{name}' typeIdx=0x{typeIndex:X} {sizeInfo}");
			}
		}
		Console.WriteLine($"done; big blobs saved: {bigCount}");
	}

	static int Read7BitInt(byte[] d, ref int p)
	{
		int v = 0, shift = 0;
		while (true)
		{
			byte b = d[p++];
			v |= (b & 0x7F) << shift;
			if ((b & 0x80) == 0) return v;
			shift += 7;
		}
	}
}
