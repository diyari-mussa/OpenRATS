using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat.My;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class MyApplication : WindowsFormsApplicationBase
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	[STAThread]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DebuggerHidden]
	internal static void Main(string[] args)
	{
		try
		{
			Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
		}
		finally
		{
		}
		MyProject.Application.Run(args);
	}

	public string ExceptionToString(Exception ex)
	{
		string text = "-------------------------------------------------------------------";
		string text2 = "ERROR:\r\n" + text + "\r\n";
		string text3 = "";
		string text4 = "";
		string text5 = "";
		string text6 = "";
		string text7 = "";
		try
		{
			text3 = ex.Message + "\r\n" + text + "\r\n";
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			text4 = ex.StackTrace + "\r\n" + text + "\r\n";
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			text5 = ex.InnerException.Message + "\r\n" + text + "\r\n";
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			text6 = ex.InnerException.StackTrace + "\r\n" + text + "\r\n";
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			string text8 = "";
			int count = ex.Data.Keys.Count;
			for (int i = 0; i <= count; i = checked(i + 1))
			{
				try
				{
					text8 = Conversions.ToString(Operators.ConcatenateObject(text8, Operators.ConcatenateObject(ex.Data[RuntimeHelpers.GetObjectValue(ex.Data.Keys.Cast<object>().ElementAtOrDefault(i))], "\r\n")));
				}
				catch (Exception projectError5)
				{
					ProjectData.SetProjectError(projectError5);
					ProjectData.ClearProjectError();
				}
			}
			text7 = text8 + "\r\n" + text + "\r\n";
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		return text2 + text3 + text4 + text5 + text6 + text7;
	}

	private void MyApplication_Startup(object sender, StartupEventArgs e)
	{
		try
		{
			if (Directory.Exists(Path.GetTempPath() + "CP"))
			{
				Directory.Delete(Path.GetTempPath() + "CP", recursive: true);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Directory.Exists(Path.GetTempPath() + "UPATER"))
			{
				Directory.Delete(Path.GetTempPath() + "UPATER", recursive: true);
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (File.Exists(Path.GetTempPath() + "UPATER.zip"))
			{
				File.Delete(Path.GetTempPath() + "UPATER.zip");
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}

	private void MyApplication_UnhandledException(object sender, Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs e)
	{
		if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory.ToString() + "Errorlogs.txt"))
		{
			File.Create(AppDomain.CurrentDomain.BaseDirectory.ToString() + "Errorlogs.txt").Dispose();
		}
		string text = "";
		try
		{
			text = e.Exception.Message;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		string text2 = "";
		try
		{
			text2 = e.Exception.Source;
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		string text3 = "";
		try
		{
			text3 = e.Exception.TargetSite.Name;
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		string text4 = "";
		try
		{
			text4 = e.Exception.InnerException.Message;
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		string text5 = "";
		try
		{
			text5 = e.Exception.StackTrace;
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		string text6 = "";
		try
		{
			text6 = ExceptionToString(e.Exception);
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory.ToString() + "Errorlogs.txt", "\r\n" + text + "\r\n                                            \r\n" + text2 + "\r\n                                              \r\n" + DateTime.Now.ToString() + "\r\n                                               \r\n" + text3 + "\r\n                                               \r\n" + text5 + "\r\n                                               \r\n\r\n                                               \r\n" + text6 + "\r\n                                               \r\n" + text4 + "\r\n----------------End--------------");
		Interaction.MsgBox("Unhandled Exception \r\n Try Send Error logs to Developer at t.me/EvLFDEV :\r\n" + AppDomain.CurrentDomain.BaseDirectory.ToString() + "Errorlogs.txt");
		e.ExitApplication = true;
	}

	[DebuggerStepThrough]
	public MyApplication()
		: base(AuthenticationMode.Windows)
	{
		base.Startup += MyApplication_Startup;
		base.UnhandledException += MyApplication_UnhandledException;
		base.IsSingleInstance = false;
		base.EnableVisualStyles = true;
		base.SaveMySettingsOnExit = true;
		base.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
	}

	[DebuggerStepThrough]
	protected override void OnCreateMainForm()
	{
		base.MainForm = MyProject.Forms.CraxsRatMain;
	}
}
