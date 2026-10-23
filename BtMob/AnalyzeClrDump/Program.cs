// Walk a BTMob minidump taken after EXGuarder.Startup: dump decrypted
// EXGuarder string fields and JIT'd methods.
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.Diagnostics.Runtime;

class Program
{
	internal static ClrRuntime Rt;

	static int Main(string[] args)
	{
		string dump = args.Length > 0
			? args[0]
			: @"D:\MSI E Drive\Programming Projects\Other Projects\REA\OpenRATS\_Analysis\BtMob\patched-il\btmob-live.dmp";
		string outDir = args.Length > 1
			? args[1]
			: @"D:\MSI E Drive\Programming Projects\Other Projects\REA\OpenRATS\_Analysis\BtMob\patched-il";
		if (args.Length > 0 && args[0] == "fill")
			return FillExguarder(
				args.Length > 1 ? args[1] : @"D:\MSI E Drive\Programming Projects\Other Projects\REA\OpenRATS\_Analysis\BtMob\patched-il\exguarder-strings-filled.txt",
				args.Length > 2 ? args[2] : @"D:\MSI E Drive\Programming Projects\Other Projects\REA\OpenRATS\BtMob\EXGuarder.cs");
		if (args.Length > 0 && args[0] == "mapjit")
			return MapJit.Run(args);
		if (args.Length > 0 && args[0] == "dumpform")
			return DumpForm.Run(args);

		if (!File.Exists(dump))
		{
			Console.WriteLine("dump missing: " + dump);
			return 1;
		}

		using DataTarget dt = DataTarget.LoadDump(dump);
		Console.WriteLine($"modules in dump: {dt.EnumerateModules().Count()}");
		foreach (ClrInfo info in dt.ClrVersions)
			Console.WriteLine($"CLR: {info.Flavor} {info.Version}");

		if (dt.ClrVersions.Length == 0)
		{
			Console.WriteLine("no CLR in dump");
			return 2;
		}

		using ClrRuntime rt = dt.ClrVersions[0].CreateRuntime();
		Rt = rt;
		Console.WriteLine($"appdomains: {rt.AppDomains.Length}  threads: {rt.Threads.Length}");
		foreach (ClrModule mod in rt.EnumerateModules())
			Console.WriteLine($"  mod {mod.Name} size=0x{mod.Size:X} addr=0x{mod.Address:X}");

		ClrAppDomain ad = rt.AppDomains.FirstOrDefault();
		var strings = new List<string>();
		int methodNotes = 0;
		using var sw = new StreamWriter(Path.Combine(outDir, "exguarder-strings.txt"));
		using var mw = new StreamWriter(Path.Combine(outDir, "method-jit.txt"));

		foreach (ClrModule mod in rt.EnumerateModules())
		{
			string n = Path.GetFileName(mod.Name ?? "");
			if (!n.Equals("BTMob.exe", StringComparison.OrdinalIgnoreCase) &&
			    !n.Equals("Btmob.exe", StringComparison.OrdinalIgnoreCase))
				continue;

			Console.WriteLine($"scanning {mod.Name}");
			ClrType exg = null;
			try { exg = mod.GetTypeByName("EXGuarder"); } catch { }
			if (exg == null)
			{
				foreach (ClrType t in EnumerateTypes(mod))
				{
					if (t?.Name == "EXGuarder") { exg = t; break; }
				}
			}
			if (exg != null)
			{
				Console.WriteLine($"EXGuarder static fields: {exg.StaticFields.Length}");
				foreach (ClrStaticField f in exg.StaticFields)
				{
					string val = ReadStaticString(f, ad);
					if (!string.IsNullOrEmpty(val))
					{
						strings.Add($"{f.Name}={val}");
						sw.WriteLine($"{f.Name}\t{val.Replace("\r", "\\r").Replace("\n", "\\n")}");
					}
					else
						sw.WriteLine($"{f.Name}\t<null-or-unreadable>");
				}
			}
			else
				Console.WriteLine("EXGuarder type not found");

			string nativeDir = Path.Combine(outDir, "native");
			Directory.CreateDirectory(nativeDir);
			foreach (var (typeName, m) in EnumerateMethods(mod))
			{
				if (m == null) continue;
				methodNotes++;
				if (m.NativeCode == 0) continue;
				mw.WriteLine($"{typeName}.{m.Name}  native=0x{m.NativeCode:X}  type={m.CompilationType}  token=0x{m.MetadataToken:X8}");
				bool interesting =
					(m.Name is "Main" or "Startup" or "OnCreateMainForm" or "MyApplication_Startup" or ".ctor" or ".cctor")
					&& (typeName.EndsWith("MyApplication") || typeName.EndsWith("EXGuarder") || typeName.Contains("Module")
						|| typeName.EndsWith("Securekey") || typeName.EndsWith("loader"));
				if (!interesting) continue;
				byte[] buf = new byte[2048];
				int nread = dt.DataReader.Read(m.NativeCode, buf);
				if (nread > 0)
				{
					string safeType = string.Concat(typeName.Select(c => char.IsLetterOrDigit(c) ? c : '_'));
					string safeName = string.Concat(m.Name.Select(c => char.IsLetterOrDigit(c) ? c : '_'));
					string fn = Path.Combine(nativeDir, $"{safeType}_{safeName}_{m.MetadataToken:X8}.bin");
					File.WriteAllBytes(fn, buf.AsSpan(0, nread).ToArray());
					Console.WriteLine($"dumped {nread} native bytes {typeName}.{m.Name}");
				}
			}
		}

		sw.Flush();
		Console.WriteLine($"wrote {strings.Count} non-empty EXGuarder strings");
		Console.WriteLine($"scanned {methodNotes} methods");
		File.WriteAllLines(Path.Combine(outDir, "exguarder-strings-filled.txt"), strings);
		return 0;
	}

	static IEnumerable<ClrType> EnumerateTypes(ClrModule mod)
	{
		IEnumerable<(ulong MethodTable, int Token)> map;
		try { map = mod.EnumerateTypeDefToMethodTableMap(); }
		catch { yield break; }
		foreach (var (mt, _) in map)
		{
			ClrType t = null;
			try { t = Rt.GetTypeByMethodTable(mt); } catch { }
			if (t != null) yield return t;
		}
	}

	internal static IEnumerable<(string typeName, ClrMethod method)> EnumerateMethods(ClrModule mod)
	{
		foreach (ClrType t in EnumerateTypes(mod))
		{
			if (t.Methods.IsDefaultOrEmpty) continue;
			foreach (ClrMethod m in t.Methods)
				yield return (t.Name, m);
		}
	}

	static int FillExguarder(string filledPath, string csPath)
	{
		var map = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
		foreach (string line in File.ReadAllLines(filledPath))
		{
			int eq = line.IndexOf('=');
			if (eq <= 0) continue;
			string id = line.Substring(0, eq).TrimStart('_');
			string val = line.Substring(eq + 1);
			map[id] = val;
		}
		Console.WriteLine($"loaded {map.Count} decrypted strings");
		string[] lines = File.ReadAllLines(csPath);
		int filled = 0, missing = 0;
		for (int i = 0; i < lines.Length; i++)
		{
			string line = lines[i];
			const string prefix = "\tpublic static string _";
			if (!line.StartsWith(prefix) || !line.EndsWith(";")) continue;
			string rest = line.Substring(prefix.Length);
			int semi = rest.IndexOf(';');
			string id = rest.Substring(0, semi);
			int assign = id.IndexOf(' ');
			if (assign >= 0) continue; // already has initializer or extra tokens
			if (id.Contains("=")) continue;
			if (!map.TryGetValue(id, out string val))
			{
				val = "";
				missing++;
			}
			lines[i] = prefix + id + " = " + ToCSharpLiteral(val) + ";";
			filled++;
		}
		File.WriteAllLines(csPath, lines);
		Console.WriteLine($"filled {filled} fields, missing {missing}, wrote {csPath}");
		return 0;
	}

	static string ToCSharpLiteral(string s)
	{
		var sb = new StringBuilder(s.Length + 8);
		sb.Append('"');
		foreach (char c in s)
		{
			switch (c)
			{
				case '\\': sb.Append("\\\\"); break;
				case '"': sb.Append("\\\""); break;
				case '\n': sb.Append("\\n"); break;
				case '\r': sb.Append("\\r"); break;
				case '\t': sb.Append("\\t"); break;
				case '\0': sb.Append("\\0"); break;
				default:
					if (c < 32 || c == 127)
						sb.Append("\\u").Append(((int)c).ToString("x4"));
					else
						sb.Append(c);
					break;
			}
		}
		sb.Append('"');
		return sb.ToString();
	}

	static string ReadStaticString(ClrStaticField f, ClrAppDomain ad)
	{
		try
		{
			if (f.ElementType == ClrElementType.String)
			{
				try { return f.ReadString(ad); } catch { }
			}
			ClrObject obj = default;
			try { obj = f.ReadObject(ad); } catch { return null; }
			if (obj.IsNull) return null;
			try { return obj.AsString(); } catch { }
		}
		catch { }
		return null;
	}
}
