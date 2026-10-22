using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Craxs_Rat.My.Resources;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat;

[DesignerGenerated]
public class comptableform : Form
{
	private IContainer components;

	[AccessedThroughProperty("loginbtn")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DrakeUIButtonIcon _loginbtn;

	private string armsg;

	private string cnmsg;

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

	internal virtual DrakeUIButtonIcon loginbtn
	{
		[CompilerGenerated]
		get
		{
			return _loginbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Loginbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _loginbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_loginbtn = value;
			drakeUIButtonIcon = _loginbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
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

	public comptableform()
	{
		base.Load += Comptableform_Load;
		armsg = "اكتشف Craxsrat نظام تشغيل Windows غير متوافق ، إذا واجهت مشكلة في تسجيل الدخول ، فحاول الانتقال إلى Windows 10";
		cnmsg = "Craxsrat检测到不兼容的Windows操作系统，如果您遇到登录问题，请尝试转移到Windows 10";
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
		this.Panel1 = new System.Windows.Forms.Panel();
		this.loginbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.Panel1.SuspendLayout();
		this.Panel2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		base.SuspendLayout();
		this.Panel1.Controls.Add(this.loginbtn);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel1.Location = new System.Drawing.Point(0, 372);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(800, 78);
		this.Panel1.TabIndex = 0;
		this.loginbtn.BackColor = System.Drawing.Color.Transparent;
		this.loginbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.loginbtn.FillColor = System.Drawing.Color.Transparent;
		this.loginbtn.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.loginbtn.FillPressColor = System.Drawing.Color.Black;
		this.loginbtn.FillSelectedColor = System.Drawing.Color.FromArgb(254, 0, 0);
		this.loginbtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.loginbtn.ForeColor = System.Drawing.Color.FromArgb(254, 0, 0);
		this.loginbtn.ForePressColor = System.Drawing.Color.FromArgb(254, 0, 0);
		this.loginbtn.Location = new System.Drawing.Point(322, 23);
		this.loginbtn.Margin = new System.Windows.Forms.Padding(4);
		this.loginbtn.Name = "loginbtn";
		this.loginbtn.Radius = 10;
		this.loginbtn.RectColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.loginbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.loginbtn.RectHoverColor = System.Drawing.Color.White;
		this.loginbtn.RectPressColor = System.Drawing.Color.White;
		this.loginbtn.RectSelectedColor = System.Drawing.Color.White;
		this.loginbtn.Size = new System.Drawing.Size(156, 32);
		this.loginbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.loginbtn.SymbolSize = 0;
		this.loginbtn.TabIndex = 29;
		this.loginbtn.Text = "OK";
		this.Panel2.Controls.Add(this.PictureBox1);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel2.Location = new System.Drawing.Point(0, 0);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new System.Drawing.Size(800, 100);
		this.Panel2.TabIndex = 1;
		this.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.PictureBox1.Image = Craxs_Rat.My.Resources.Resources.lie;
		this.PictureBox1.Location = new System.Drawing.Point(0, 0);
		this.PictureBox1.Name = "PictureBox1";
		this.PictureBox1.Size = new System.Drawing.Size(800, 100);
		this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.PictureBox1.TabIndex = 0;
		this.PictureBox1.TabStop = false;
		this.Label1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Label1.Font = new System.Drawing.Font("Calibri", 14f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.ForeColor = System.Drawing.Color.Red;
		this.Label1.Location = new System.Drawing.Point(0, 100);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(800, 272);
		this.Label1.TabIndex = 2;
		this.Label1.Text = "Craxsrat detected incompatible Windows OS , if you face login problem , try move to windows 10";
		this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.Black;
		base.ClientSize = new System.Drawing.Size(800, 450);
		base.ControlBox = false;
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.Panel2);
		base.Controls.Add(this.Panel1);
		this.ForeColor = System.Drawing.Color.White;
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "comptableform";
		base.ShowIcon = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "comptableform";
		base.TopMost = true;
		this.Panel1.ResumeLayout(false);
		this.Panel2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		base.ResumeLayout(false);
	}

	private void Loginbtn_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void Comptableform_Load(object sender, EventArgs e)
	{
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "CN", TextCompare: false) == 0)
			{
				Label1.Text = cnmsg;
			}
		}
		else
		{
			Label1.Text = armsg;
		}
	}
}
