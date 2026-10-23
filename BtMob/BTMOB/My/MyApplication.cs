using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace BTMOB.My;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class MyApplication : WindowsFormsApplicationBase
{
	private readonly string ExceptionLogPath = Path.Combine(Application.StartupPath, "startup-error.log");

	[STAThread]
	[DebuggerHidden]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static void Main(string[] Args)
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		new MyApplication().Run(Args);
	}

	private void MyApplication_UnhandledException(object sender, Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs e)
	{
		try
		{
			e.ExitApplication = false;
			Exception ex = e.Exception as Exception ?? new Exception(e.Exception?.ToString());
			File.AppendAllText(ExceptionLogPath, DateTime.Now + Environment.NewLine + ex + Environment.NewLine);
		}
		catch
		{
		}
	}

	private void MyApplication_Startup(object sender, StartupEventArgs e)
	{
	}

	[DebuggerStepThrough]
	public MyApplication()
	{
		IsSingleInstance = true;
		EnableVisualStyles = true;
		SaveMySettingsOnExit = false;
		ShutdownStyle = ShutdownMode.AfterMainFormCloses;
		UnhandledException += MyApplication_UnhandledException;
		Startup += MyApplication_Startup;
	}

	[DebuggerStepThrough]
	protected override void OnCreateMainForm()
	{
		LinkOriginalResources();
		CopyWebViewRuntime();
		// Original boot: Form1 shows Securekey as a dialog until the profile exists,
		// then continues into the splash screen.
		MainForm = new global::BTMOB.Form1();
	}

	static void CopyWebViewRuntime()
	{
		string dest = Path.Combine(Application.StartupPath, "runtimes");
		if (File.Exists(Path.Combine(dest, "win-x64", "native", "WebView2Loader.dll")))
			return;
		string source = @"D:\MSI E Drive\Programming Projects\Other Projects\REA\OpenRATS\_Analysis\BtMob\SafeLab\BTMob 4.6.1 Fixed\runtimes";
		if (!Directory.Exists(source))
			return;
		foreach (string file in Directory.GetFiles(source, "*", SearchOption.AllDirectories))
		{
			string rel = file.Substring(source.Length).TrimStart('\\');
			string target = Path.Combine(dest, rel);
			Directory.CreateDirectory(Path.GetDirectoryName(target));
			File.Copy(file, target, overwrite: true);
		}
	}

	static void LinkOriginalResources()
	{
		string dest = Path.Combine(Application.StartupPath, "Resources");
		if (Directory.Exists(dest))
			return;
		string source = @"D:\MSI E Drive\Programming Projects\Other Projects\REA\OpenRATS\_Analysis\BtMob\SafeLab\BTMob 4.6.1 Fixed\Resources";
		if (!Directory.Exists(source))
			return;
		Process.Start(new ProcessStartInfo
		{
			FileName = "cmd.exe",
			Arguments = "/c mklink /J \"" + dest + "\" \"" + source + "\"",
			CreateNoWindow = true,
			UseShellExecute = false,
		})?.WaitForExit();
	}
}
