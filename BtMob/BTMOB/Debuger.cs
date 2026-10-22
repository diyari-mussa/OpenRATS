using System;
using System.IO;
using Microsoft.VisualBasic.CompilerServices;

namespace BTMOB;

[StandardModule]
internal sealed class Debuger
{
	private static readonly string errorLogPath = EXGuarder._150A5F07;

	private static void EnsureDirectories()
	{
		if (!Directory.Exists(errorLogPath))
		{
			Directory.CreateDirectory(errorLogPath);
		}
	}

	public static void Log_d(string from, string msg)
	{
	}

	public static void Log_e(string from, string msg)
	{
		try
		{
			EnsureDirectories();
			string text = string.Format(EXGuarder._75272C50, DateTime.Now, BTConst.myname, from, msg);
			Console.WriteLine(text);
			string path = Path.Combine(errorLogPath, EXGuarder._735D6465);
			File.AppendAllText(path, string.Format(EXGuarder._1E151B2A, text, Environment.NewLine + Environment.NewLine));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Console.WriteLine(string.Format(EXGuarder._232D2014, ex2.Message, EXGuarder._0C4A3107, DateTime.Now, BTConst.myname, from, msg));
			ProjectData.ClearProjectError();
		}
	}
}
