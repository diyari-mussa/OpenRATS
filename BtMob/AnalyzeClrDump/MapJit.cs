using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using dnlib.IO;
using Microsoft.Diagnostics.Runtime;

static class MapJit
{
	class Capture
	{
		public ulong Ftn { get; set; }
		public int Size { get; set; }
		public int MaxStack { get; set; }
		public int EhCount { get; set; }
		public string Hex { get; set; }
	}

	class Mapped
	{
		public ulong Ftn { get; set; }
		public int Token { get; set; }
		public string Type { get; set; }
		public string Name { get; set; }
		public string FullSig { get; set; }
		public int Size { get; set; }
		public int MaxStack { get; set; }
		public int EhCount { get; set; }
		public string Hex { get; set; }
	}

	public static int Run(string[] args)
	{
		string dump = args.Length > 1
			? args[1]
			: @"D:\MSI E Drive\Programming Projects\Other Projects\REA\OpenRATS\_Analysis\BtMob\patched-il\btmob-jit.dmp";
		string capturesPath = args.Length > 2
			? args[2]
			: @"D:\MSI E Drive\Programming Projects\Other Projects\REA\OpenRATS\_Analysis\BtMob\patched-il\jit-il\captures.json";
		string exe = args.Length > 3
			? args[3]
			: @"D:\MSI E Drive\Programming Projects\Other Projects\REA\OpenRATS\_Analysis\BtMob\SafeLab\BTMob 4.6.1 Fixed\Btmob.exe";
		string outDir = Path.GetDirectoryName(capturesPath);
		string recDir = Path.Combine(outDir, "recovered");
		Directory.CreateDirectory(recDir);

		var captures = new List<Capture>();
		try
		{
			captures = JsonSerializer.Deserialize<List<Capture>>(File.ReadAllText(capturesPath),
				new JsonSerializerOptions { IncludeFields = true }) ?? new List<Capture>();
		}
		catch { }
		string binDir = Path.GetDirectoryName(capturesPath);
		foreach (string bin in Directory.GetFiles(binDir, "ftn_*.bin"))
		{
			string hex = Path.GetFileNameWithoutExtension(bin).Substring(4);
			if (!ulong.TryParse(hex, System.Globalization.NumberStyles.HexNumber, null, out ulong ftn) || ftn == 0)
				continue;
			byte[] il = File.ReadAllBytes(bin);
			captures.Add(new Capture { Ftn = ftn, Size = il.Length, Hex = Convert.ToHexString(il) });
		}
		captures = captures.Where(c => c != null && c.Ftn != 0 && !string.IsNullOrEmpty(c.Hex))
			.GroupBy(c => c.Ftn)
			.Select(g => g.OrderByDescending(x => x.Size).First())
			.ToList();
		var byFtn = captures.ToDictionary(c => c.Ftn, c => c);
		Console.WriteLine($"captures={captures.Count}");

		using DataTarget dt = DataTarget.LoadDump(dump);
		using ClrRuntime rt = dt.ClrVersions[0].CreateRuntime();
		Program.Rt = rt;

		var mapped = new List<Mapped>();
		int hits = 0, misses = 0;
		foreach (ClrModule mod in rt.EnumerateModules())
		{
			string n = Path.GetFileName(mod.Name ?? "");
			if (!n.Equals("BTMob.exe", StringComparison.OrdinalIgnoreCase) &&
			    !n.Equals("Btmob.exe", StringComparison.OrdinalIgnoreCase))
				continue;
			foreach (var (typeName, m) in Program.EnumerateMethods(mod))
			{
				if (m == null || m.MethodDesc == 0) continue;
				if (!byFtn.TryGetValue(m.MethodDesc, out Capture cap)) continue;
				hits++;
				mapped.Add(new Mapped
				{
					Ftn = cap.Ftn,
					Token = (int)m.MetadataToken,
					Type = typeName,
					Name = m.Name,
					FullSig = m.Signature,
					Size = cap.Size,
					MaxStack = cap.MaxStack,
					EhCount = cap.EhCount,
					Hex = cap.Hex,
				});
			}
		}
		misses = captures.Count - hits;
		Console.WriteLine($"mapped {hits} BTMob methods, unmatched captures={misses}");

		string mapPath = Path.Combine(outDir, "mapped.json");
		File.WriteAllText(mapPath, JsonSerializer.Serialize(mapped, new JsonSerializerOptions { WriteIndented = true }));

		ModuleDefMD pe = ModuleDefMD.Load(exe);
		var interesting = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
		{
			"Securekey", "MyApplication", "ApkMaker", "Form1", "loader", "EXGuarder", "<Module>"
		};
		int disasm = 0;
		foreach (Mapped m in mapped.OrderBy(x => x.Type).ThenBy(x => x.Name))
		{
			bool keep = interesting.Any(t => (m.Type ?? "").EndsWith(t, StringComparison.OrdinalIgnoreCase))
				|| m.Name is "Main" or "Startup" or "OnCreateMainForm" or "InitializeComponent" or "Securekey";
			if (!keep) continue;
			string text = Disassemble(pe, m);
			string safeType = Sanitize(m.Type);
			string safeName = Sanitize(m.Name);
			File.WriteAllText(Path.Combine(recDir, $"{safeType}_{safeName}_{m.Token:X8}.il.txt"), text);
			disasm++;
		}
		Console.WriteLine($"wrote {disasm} recovered IL listings -> {recDir}");
		foreach (Mapped m in mapped.Where(x =>
			(x.Type ?? "").Contains("Securekey") || (x.Type ?? "").Contains("MyApplication") || (x.Type ?? "").Contains("ApkMaker")))
			Console.WriteLine($"  0x{m.Token:X8} {m.Type}.{m.Name} size={m.Size} eh={m.EhCount}");
		return 0;
	}

	static string Disassemble(ModuleDefMD pe, Mapped m)
	{
		var sb = new StringBuilder();
		sb.AppendLine($"// {m.Type}::{m.Name}");
		sb.AppendLine($"// token=0x{m.Token:X8} size={m.Size} maxstack={m.MaxStack} eh={m.EhCount}");
		sb.AppendLine($"// sig={m.FullSig}");
		byte[] il = Convert.FromHexString(m.Hex ?? "");
		try
		{
			var method = pe.ResolveToken((uint)m.Token) as MethodDef;
			if (method == null)
			{
				sb.AppendLine("// unresolved token");
				sb.AppendLine(BitConverter.ToString(il));
				return sb.ToString();
			}
			var codeReader = ByteArrayDataReaderFactory.CreateReader(il);
			var body = MethodBodyReader.CreateCilBody(pe, codeReader, null, method.Parameters, new GenericParamContext(method));
			foreach (var instr in body.Instructions)
				sb.AppendLine(instr.ToString());
		}
		catch (Exception ex)
		{
			sb.AppendLine("// disasm failed: " + ex.Message);
			sb.AppendLine(BitConverter.ToString(il));
		}
		return sb.ToString();
	}

	static string Sanitize(string s)
	{
		if (string.IsNullOrEmpty(s)) return "_";
		return string.Concat(s.Select(c => char.IsLetterOrDigit(c) ? c : '_'));
	}
}
