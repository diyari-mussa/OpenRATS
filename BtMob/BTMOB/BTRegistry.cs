using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace BTMOB;

[StandardModule]
internal sealed class BTRegistry
{
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	public struct Regz
	{
		public const string Language = "LANG";

		public const string hwidassist = "hd";

		public const string notify_sund = "notys";
	}

	[StructLayout(LayoutKind.Sequential, Size = 1)]
	public struct BTSettings
	{
		public const string Use_notify = "Notifications";

		public const string Use_sound = "Sounds";

		public const string Notify_mobs = "MobNotify";

		public const string Notify_bar = "BarNotify";

		public const string Notify_downloads = "downnotify";

		public const string Notify_disconnect = "discnotufy";

		public const string Notify_newcli = "newclinotify";

		public const string UserAgent = "uagent";

		public const string Defconfig = "Defconf";

		public const string fileviewstyle = "fileview";

		public const string autothumbs = "autothumbs";

		public const string autosave = "auotsave";

		public const string hideEfiles = "emptyfiles";

		public const string hideEfolder = "emptyfolder";

		public const string scrqulty = "screenquality";

		public const string qulityscr = "Scrquality";

		public const string typstyle = "scrtyping";

		public const string Havatar = "HAV";

		public const string Hflag = "HAF";

		public const string Hscreen = "HAS";

		public const string Hname = "HAN";

		public const string Haddress = "HAD";

		public const string Handroid = "HADN";

		public const string Htracking = "HTR";

		public const string HfirstSeen = "HFS";

		public const string Hversion = "HVE";

		public const string Hwifi = "HWI";

		public const string Hbattery = "HBA";

		public const string HactiveNow = "HAC";

		public const string Hinjection = "HIN";

		public const string Hping = "HPG";

		public const string SkpBlockwrnng = "SkipBlkW";

		public const string SkpDeleapp = "SkipDelapp";

		public const string Skpextcheck = "Skipextbt";

		public const string Preform = "Preform";
	}

	public class RegistryBackupItem
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private object _Value;

		public string Path { get; set; }

		public string Name { get; set; }

		public object Value
		{
			[CompilerGenerated]
			get
			{
				return _Value;
			}
			[CompilerGenerated]
			set
			{
				_Value = RuntimeHelpers.GetObjectValue(value);
			}
		}

		public RegistryValueKind Kind { get; set; }
	}

	private const string RegistryPath = "Software\\BTMOB";

	private const string RegistryPath_settings = "Software\\BTMOB\\Settings";

	private const string RegistryPath_settings_fav = "Software\\BTMOB\\Favorites";

	public static void AddOrUpdateValue(string valueName, object value)
	{
		using (RegistryKey key = Registry.CurrentUser.CreateSubKey(RegistryPath))
			key.SetValue(valueName, value ?? "");
	}

	public static object GetValue(string valueName, object defaultValue)
	{
		try
		{
			using (RegistryKey key = Registry.CurrentUser.OpenSubKey(RegistryPath))
			{
				if (key == null)
					return defaultValue;
				return key.GetValue(valueName, defaultValue) ?? defaultValue;
			}
		}
		catch
		{
			return defaultValue;
		}
	}

	public static void RemoveValue(string valueName)
	{
		using (RegistryKey key = Registry.CurrentUser.OpenSubKey(RegistryPath, writable: true))
			key?.DeleteValue(valueName, throwOnMissingValue: false);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RemoveSubKeyTree()
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	public static void WriteBool(string keyName, bool value)
	{
		using (RegistryKey key = Registry.CurrentUser.CreateSubKey(RegistryPath_settings))
			key.SetValue(keyName, value ? 1 : 0, RegistryValueKind.DWord);
	}

	public static bool ReadBool(string keyName, bool defaultValue = false)
	{
		try
		{
			using (RegistryKey key = Registry.CurrentUser.OpenSubKey(RegistryPath_settings))
			{
				object value = key?.GetValue(keyName);
				if (value == null)
					return defaultValue;
				if (value is int n)
					return n != 0;
				bool parsed;
				return bool.TryParse(Convert.ToString(value), out parsed) ? parsed : defaultValue;
			}
		}
		catch
		{
			return defaultValue;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AddFavorite(string keyName, bool value)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CheckFavorite(string keyName, bool defaultValue = false)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string ExportSettings()
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ExportKey(string keyPath, List<RegistryBackupItem> items)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ImportSettings(string json)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}
}
