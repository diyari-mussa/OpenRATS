// C2Check — print the C2 / settings / tag literal values found in a built APK's
// classes.dex, decoded, so we can confirm the patch actually landed and what the
// payload will use to reach the relay.
using System;
using System.IO;
using System.Text;

internal static class Program
{
	private static int Main(string[] args)
	{
		string apk = args[0];
		byte[] d = ExtractDex(apk);
		uint size = ReadU32(d, 56), off = ReadU32(d, 60);
		Console.WriteLine($"string count={size}");

		for (uint i = 0; i < size; i++)
		{
			string v = Str(d, ReadU32(d, off + i * 4));
			if (v == null) continue;
			bool interesting = v.StartsWith("aXph", StringComparison.Ordinal)
				|| v.StartsWith("oltsfhxzoffaynqemztews", StringComparison.Ordinal)
				|| v.StartsWith("icx8uKXk", StringComparison.Ordinal)
				|| v.StartsWith("b3Bl", StringComparison.Ordinal)
				|| v.Contains("10.0.2.2", StringComparison.Ordinal)
				|| v.Contains("openrats", StringComparison.Ordinal);
			if (!interesting) continue;

			Console.WriteLine($"#{i}: '{v}'");
			if (v.StartsWith("aXph", StringComparison.Ordinal) || v.StartsWith("b3Bl", StringComparison.Ordinal))
				Console.WriteLine($"     decoded: '{Decode(v)}'");
		}
		return 0;
	}

	private static string Decode(string b64)
	{
		string s = b64.TrimEnd('|', ' ').Trim();
		s = s.PadRight((s.Length + 3) / 4 * 4, '=');
		try { return Encoding.UTF8.GetString(Convert.FromBase64String(s)); }
		catch (Exception e) { return "<" + e.Message + ">"; }
	}

	private static string Str(byte[] d, uint off)
	{
		int at = (int)off;
		if (at >= d.Length) return null;
		int p = at, shift = 0;
		while (p < d.Length) { byte c = d[p++]; if ((c & 0x80) == 0) break; shift += 7; if (shift > 28) break; }
		int end = p;
		while (end < d.Length && d[end] != 0) end++;
		return Encoding.UTF8.GetString(d, p, end - p);
	}

	private static byte[] ExtractDex(string apk)
	{
		using var zip = System.IO.Compression.ZipFile.OpenRead(apk);
		foreach (var e in zip.Entries)
			if (e.FullName == "classes.dex")
			{
				using var ms = new MemoryStream();
				e.Open().CopyTo(ms);
				return ms.ToArray();
			}
		throw new InvalidOperationException("no classes.dex");
	}

	private static uint ReadU32(byte[] b, uint o) => (uint)(b[o] | (b[o + 1] << 8) | (b[o + 2] << 16) | (b[o + 3] << 24));
}
