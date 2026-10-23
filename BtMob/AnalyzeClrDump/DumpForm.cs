using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.Diagnostics.Runtime;

static class DumpForm
{
	static ClrHeap Heap;

	public static int Run(string[] args)
	{
		string dump = args.Length > 1
			? args[1]
			: @"D:\MSI E Drive\Programming Projects\Other Projects\REA\OpenRATS\_Analysis\BtMob\patched-il\btmob-jit.dmp";
		string typeName = args.Length > 2 ? args[2] : "BTMOB.Securekey";
		string outPath = args.Length > 3
			? args[3]
			: @"D:\MSI E Drive\Programming Projects\Other Projects\REA\OpenRATS\_Analysis\BtMob\patched-il\jit-il\securekey-controls.txt";

		using DataTarget dt = DataTarget.LoadDump(dump);
		using ClrRuntime rt = dt.ClrVersions[0].CreateRuntime();
		Heap = rt.Heap;
		if (!Heap.CanWalkHeap)
		{
			Console.WriteLine("cannot walk heap");
			return 2;
		}

		var sb = new StringBuilder();
		int found = 0;
		foreach (ClrObject obj in Heap.EnumerateObjects())
		{
			if (obj.IsNull || obj.Type == null || obj.Type.Name != typeName) continue;
			found++;
			sb.AppendLine($"FORM {typeName} @ 0x{obj.Address:X}");
			WriteControl(obj, sb, "this");
			foreach (ClrInstanceField f in obj.Type.Fields)
			{
				if (f.IsPrimitive)
				{
					sb.AppendLine($"FIELD {f.Name}={ReadPrim(f, obj.Address)}");
					continue;
				}
				if (f.Type?.IsString == true || f.ElementType == ClrElementType.String)
				{
					sb.AppendLine($"FIELD {f.Name}=\"{f.ReadString(obj.Address, false)}\"");
					continue;
				}
				ClrObject child;
				try { child = f.ReadObject(obj.Address, false); }
				catch { continue; }
				if (child.IsNull || child.Type == null) continue;
				string tn = child.Type.Name;
				bool isCtrl = tn.Contains("Windows.Forms") || tn.Contains("DrakeUI") || tn.StartsWith("BTMOB.");
				if (!isCtrl) continue;
				if (tn.Contains("EventHandler") || tn.Contains("NativeWindow") || tn.Contains("PropertyStore"))
					continue;
				WriteControl(child, sb, f.Name);
			}
		}
		File.WriteAllText(outPath, sb.ToString());
		Console.WriteLine($"found {found} {typeName} -> {outPath}");
		Console.WriteLine(sb.ToString());
		return 0;
	}

	static void WriteControl(ClrObject obj, StringBuilder sb, string name)
	{
		var vals = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
		foreach (ClrInstanceField f in obj.Type.Fields)
		{
			try
			{
				if (f.Name is "x" or "y" or "width" or "height" or "clientWidth" or "clientHeight"
					or "visible" or "enabled" or "tabIndex" or "text" or "checkAlign"
					or "keyrestored")
				{
					if (f.IsPrimitive) vals[f.Name] = Convert.ToString(ReadPrim(f, obj.Address));
					else if (f.Type?.IsString == true || f.ElementType == ClrElementType.String)
						vals[f.Name] = f.ReadString(obj.Address, false) ?? "";
				}
			}
			catch { }
		}
		// WinForms often stores Text in propertyStore; also try window caption
		string text = vals.GetValueOrDefault("text", "");
		sb.AppendLine($"CTRL {name} type={obj.Type.Name} x={Get(vals,"x")} y={Get(vals,"y")} w={Get(vals,"width")} h={Get(vals,"height")} vis={Get(vals,"visible")} en={Get(vals,"enabled")} tab={Get(vals,"tabIndex")} text={text}");
	}

	static string Get(Dictionary<string, string> d, string k) => d.TryGetValue(k, out string v) ? v : "";

	static object ReadPrim(ClrInstanceField f, ulong addr)
	{
		try
		{
			return f.ElementType switch
			{
				ClrElementType.Boolean => f.Read<bool>(addr, false),
				ClrElementType.Int8 => f.Read<sbyte>(addr, false),
				ClrElementType.UInt8 => f.Read<byte>(addr, false),
				ClrElementType.Int16 => f.Read<short>(addr, false),
				ClrElementType.UInt16 => f.Read<ushort>(addr, false),
				ClrElementType.Int32 => f.Read<int>(addr, false),
				ClrElementType.UInt32 => f.Read<uint>(addr, false),
				ClrElementType.Int64 => f.Read<long>(addr, false),
				ClrElementType.UInt64 => f.Read<ulong>(addr, false),
				ClrElementType.Float => f.Read<float>(addr, false),
				ClrElementType.Double => f.Read<double>(addr, false),
				ClrElementType.Char => f.Read<char>(addr, false),
				_ => "?",
			};
		}
		catch { return "?"; }
	}
}
