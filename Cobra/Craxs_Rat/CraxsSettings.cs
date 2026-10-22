using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Craxs_Rat.My;
using Craxs_Rat.My.Resources;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat;

[DesignerGenerated]
public class CraxsSettings : Form
{
	private IContainer components;

	[AccessedThroughProperty("resetbtn")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DrakeUIButtonIcon _resetbtn;

	[AccessedThroughProperty("savebtn")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DrakeUIButtonIcon _savebtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("selectedsoundcombo")]
	private ComboBox _selectedsoundcombo;

	[CompilerGenerated]
	[AccessedThroughProperty("resolutioncombo")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ComboBox _resolutioncombo;

	[AccessedThroughProperty("Label17")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Label _Label17;

	[AccessedThroughProperty("checkupdatbtn")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DrakeUIButtonIcon _checkupdatbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PictureBox3")]
	private PictureBox _PictureBox3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PictureBox6")]
	private PictureBox _PictureBox6;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PictureBox5")]
	private PictureBox _PictureBox5;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUISymbolLabel1")]
	private DrakeUISymbolLabel _DrakeUISymbolLabel1;

	[AccessedThroughProperty("exitbtn")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DrakeUIButtonIcon _exitbtn;

	private string[] sizearry;

	private bool progma;

	private bool first;

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
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

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
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

	[field: AccessedThroughProperty("FMQ")]
	internal virtual ComboBox FMQ
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon resetbtn
	{
		[CompilerGenerated]
		get
		{
			return _resetbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIAvatar2_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _resetbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_resetbtn = value;
			drakeUIButtonIcon = _resetbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon savebtn
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
			EventHandler value2 = DrakeUIAvatar1_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _savebtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_savebtn = value;
			drakeUIButtonIcon = _savebtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual Panel Panel2
	{
		[CompilerGenerated]
		get
		{
			return _Panel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Panel2_MouseDown;
			Panel panel = _Panel2;
			if (panel != null)
			{
				panel.MouseDown -= value2;
			}
			_Panel2 = value;
			panel = _Panel2;
			if (panel != null)
			{
				panel.MouseDown += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LiveSQ")]
	internal virtual ComboBox LiveSQ
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label12")]
	internal virtual Label Label12
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

	[field: AccessedThroughProperty("LSFPS")]
	internal virtual ComboBox LSFPS
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label14")]
	internal virtual Label Label14
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label15")]
	internal virtual Label Label15
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lngtext")]
	internal virtual ComboBox lngtext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("recordfps")]
	internal virtual Label recordfps
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label13")]
	internal virtual Label Label13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox selectedsoundcombo
	{
		[CompilerGenerated]
		get
		{
			return _selectedsoundcombo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Selectedsoundcombo_SelectedIndexChanged;
			ComboBox comboBox = _selectedsoundcombo;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_selectedsoundcombo = value;
			comboBox = _selectedsoundcombo;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label16")]
	internal virtual Label Label16
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Checksaveit")]
	internal virtual DrakeUIOSSwitch Checksaveit
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckFMI")]
	internal virtual DrakeUIOSSwitch CheckFMI
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Generaltext")]
	internal virtual DrakeUITitleLine Generaltext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Checkupdate")]
	internal virtual DrakeUIOSSwitch Checkupdate
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckHidecoonstart")]
	internal virtual DrakeUIOSSwitch CheckHidecoonstart
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Checklogit")]
	internal virtual DrakeUIOSSwitch Checklogit
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckNotifiDis")]
	internal virtual DrakeUIOSSwitch CheckNotifiDis
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual DrakeUITitleLine Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("gpanel")]
	internal virtual Panel gpanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckNotifi")]
	internal virtual DrakeUIOSSwitch CheckNotifi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Checkplysound")]
	internal virtual DrakeUIOSSwitch Checkplysound
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("label10")]
	internal virtual DrakeUITitleLine label10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("apanel")]
	internal virtual Panel apanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("fpanel")]
	internal virtual Panel fpanel
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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox resolutioncombo
	{
		[CompilerGenerated]
		get
		{
			return _resolutioncombo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Resolutioncombo_MouseClick;
			ComboBox comboBox = _resolutioncombo;
			if (comboBox != null)
			{
				comboBox.MouseClick -= value2;
			}
			_resolutioncombo = value;
			comboBox = _resolutioncombo;
			if (comboBox != null)
			{
				comboBox.MouseClick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("label11")]
	internal virtual DrakeUITitleLine label11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeUITitleLine1")]
	internal virtual DrakeUITitleLine DrakeUITitleLine1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox2")]
	internal virtual PictureBox PictureBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label Label17
	{
		[CompilerGenerated]
		get
		{
			return _Label17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Label17_Click;
			Label label = _Label17;
			if (label != null)
			{
				label.Click -= value2;
			}
			_Label17 = value;
			label = _Label17;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel5")]
	internal virtual Panel Panel5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label18")]
	internal virtual Label Label18
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel6")]
	internal virtual Panel Panel6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeUITitleLine2")]
	internal virtual DrakeUITitleLine DrakeUITitleLine2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("LogBrowser")]
	internal virtual WebBrowser LogBrowser
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon checkupdatbtn
	{
		[CompilerGenerated]
		get
		{
			return _checkupdatbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Checkupdatbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _checkupdatbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_checkupdatbtn = value;
			drakeUIButtonIcon = _checkupdatbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel7")]
	internal virtual Panel Panel7
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
			EventHandler value2 = PictureBox3_Click;
			PictureBox pictureBox = _PictureBox3;
			if (pictureBox != null)
			{
				pictureBox.Click -= value2;
			}
			_PictureBox3 = value;
			pictureBox = _PictureBox3;
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
			EventHandler value2 = PictureBox6_Click;
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
			EventHandler value2 = PictureBox5_Click;
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

	internal virtual Panel Panel1
	{
		[CompilerGenerated]
		get
		{
			return _Panel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Panel1_MouseDown;
			Panel panel = _Panel1;
			if (panel != null)
			{
				panel.MouseDown -= value2;
			}
			_Panel1 = value;
			panel = _Panel1;
			if (panel != null)
			{
				panel.MouseDown += value2;
			}
		}
	}

	internal virtual DrakeUISymbolLabel DrakeUISymbolLabel1
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUISymbolLabel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = DrakeUISymbolLabel1_MouseDown;
			DrakeUISymbolLabel drakeUISymbolLabel = _DrakeUISymbolLabel1;
			if (drakeUISymbolLabel != null)
			{
				drakeUISymbolLabel.MouseDown -= value2;
			}
			_DrakeUISymbolLabel1 = value;
			drakeUISymbolLabel = _DrakeUISymbolLabel1;
			if (drakeUISymbolLabel != null)
			{
				drakeUISymbolLabel.MouseDown += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon exitbtn
	{
		[CompilerGenerated]
		get
		{
			return _exitbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon2_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _exitbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_exitbtn = value;
			drakeUIButtonIcon = _exitbtn;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Craxs_Rat.CraxsSettings));
		this.Label4 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.Label7 = new System.Windows.Forms.Label();
		this.Label8 = new System.Windows.Forms.Label();
		this.FMQ = new System.Windows.Forms.ComboBox();
		this.Panel3 = new System.Windows.Forms.Panel();
		this.Panel7 = new System.Windows.Forms.Panel();
		this.checkupdatbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.Panel5 = new System.Windows.Forms.Panel();
		this.Label17 = new System.Windows.Forms.Label();
		this.PictureBox2 = new System.Windows.Forms.PictureBox();
		this.Label18 = new System.Windows.Forms.Label();
		this.DrakeUITitleLine1 = new DrakeUI.Framework.DrakeUITitleLine();
		this.Panel6 = new System.Windows.Forms.Panel();
		this.LogBrowser = new System.Windows.Forms.WebBrowser();
		this.DrakeUITitleLine2 = new DrakeUI.Framework.DrakeUITitleLine();
		this.Panel4 = new System.Windows.Forms.Panel();
		this.Label2 = new System.Windows.Forms.Label();
		this.resolutioncombo = new System.Windows.Forms.ComboBox();
		this.recordfps = new System.Windows.Forms.Label();
		this.Label12 = new System.Windows.Forms.Label();
		this.LiveSQ = new System.Windows.Forms.ComboBox();
		this.LSFPS = new System.Windows.Forms.ComboBox();
		this.label11 = new DrakeUI.Framework.DrakeUITitleLine();
		this.fpanel = new System.Windows.Forms.Panel();
		this.Checksaveit = new DrakeUI.Framework.DrakeUIOSSwitch();
		this.CheckFMI = new DrakeUI.Framework.DrakeUIOSSwitch();
		this.label10 = new DrakeUI.Framework.DrakeUITitleLine();
		this.apanel = new System.Windows.Forms.Panel();
		this.Label9 = new System.Windows.Forms.Label();
		this.Checkplysound = new DrakeUI.Framework.DrakeUIOSSwitch();
		this.CheckNotifi = new DrakeUI.Framework.DrakeUIOSSwitch();
		this.Label14 = new System.Windows.Forms.Label();
		this.CheckNotifiDis = new DrakeUI.Framework.DrakeUIOSSwitch();
		this.selectedsoundcombo = new System.Windows.Forms.ComboBox();
		this.Label13 = new System.Windows.Forms.Label();
		this.Label1 = new DrakeUI.Framework.DrakeUITitleLine();
		this.gpanel = new System.Windows.Forms.Panel();
		this.Label16 = new System.Windows.Forms.Label();
		this.Checklogit = new DrakeUI.Framework.DrakeUIOSSwitch();
		this.CheckHidecoonstart = new DrakeUI.Framework.DrakeUIOSSwitch();
		this.Label3 = new System.Windows.Forms.Label();
		this.lngtext = new System.Windows.Forms.ComboBox();
		this.Checkupdate = new DrakeUI.Framework.DrakeUIOSSwitch();
		this.Label15 = new System.Windows.Forms.Label();
		this.Generaltext = new DrakeUI.Framework.DrakeUITitleLine();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.exitbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.PictureBox3 = new System.Windows.Forms.PictureBox();
		this.resetbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.PictureBox6 = new System.Windows.Forms.PictureBox();
		this.savebtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.PictureBox5 = new System.Windows.Forms.PictureBox();
		this.Panel1 = new System.Windows.Forms.Panel();
		this.DrakeUISymbolLabel1 = new DrakeUI.Framework.DrakeUISymbolLabel();
		this.Panel3.SuspendLayout();
		this.Panel7.SuspendLayout();
		this.Panel5.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox2).BeginInit();
		this.Panel6.SuspendLayout();
		this.Panel4.SuspendLayout();
		this.fpanel.SuspendLayout();
		this.apanel.SuspendLayout();
		this.gpanel.SuspendLayout();
		this.Panel2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox6).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox5).BeginInit();
		this.Panel1.SuspendLayout();
		base.SuspendLayout();
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.ForeColor = System.Drawing.Color.White;
		this.Label4.Location = new System.Drawing.Point(192, 52);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(160, 19);
		this.Label4.TabIndex = 23;
		this.Label4.Text = "New Client Connected";
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.ForeColor = System.Drawing.Color.White;
		this.Label5.Location = new System.Drawing.Point(192, 51);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(115, 19);
		this.Label5.TabIndex = 25;
		this.Label5.Text = "Auto Save Data";
		this.Label6.AutoSize = true;
		this.Label6.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label6.ForeColor = System.Drawing.Color.White;
		this.Label6.Location = new System.Drawing.Point(193, 68);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(142, 19);
		this.Label6.TabIndex = 27;
		this.Label6.Text = "Log All Connections";
		this.Label7.AutoSize = true;
		this.Label7.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label7.ForeColor = System.Drawing.Color.White;
		this.Label7.Location = new System.Drawing.Point(193, 28);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(173, 19);
		this.Label7.TabIndex = 28;
		this.Label7.Text = "Small FileManager icons";
		this.Label8.AutoSize = true;
		this.Label8.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label8.ForeColor = System.Drawing.Color.White;
		this.Label8.Location = new System.Drawing.Point(192, 76);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(140, 19);
		this.Label8.TabIndex = 30;
		this.Label8.Text = "image view Quality";
		this.FMQ.BackColor = System.Drawing.Color.Black;
		this.FMQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.FMQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.FMQ.Font = new System.Drawing.Font("Calibri", 9f, System.Drawing.FontStyle.Bold);
		this.FMQ.ForeColor = System.Drawing.Color.Red;
		this.FMQ.Items.AddRange(new object[9] { "10", "20", "30", "40", "50", "60", "70", "80", "90" });
		this.FMQ.Location = new System.Drawing.Point(49, 74);
		this.FMQ.Name = "FMQ";
		this.FMQ.Size = new System.Drawing.Size(85, 22);
		this.FMQ.TabIndex = 31;
		this.Panel3.AutoScroll = true;
		this.Panel3.Controls.Add(this.Panel7);
		this.Panel3.Controls.Add(this.Panel5);
		this.Panel3.Controls.Add(this.DrakeUITitleLine1);
		this.Panel3.Controls.Add(this.Panel6);
		this.Panel3.Controls.Add(this.DrakeUITitleLine2);
		this.Panel3.Controls.Add(this.Panel4);
		this.Panel3.Controls.Add(this.label11);
		this.Panel3.Controls.Add(this.fpanel);
		this.Panel3.Controls.Add(this.label10);
		this.Panel3.Controls.Add(this.apanel);
		this.Panel3.Controls.Add(this.Label1);
		this.Panel3.Controls.Add(this.gpanel);
		this.Panel3.Controls.Add(this.Generaltext);
		this.Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel3.Location = new System.Drawing.Point(0, 24);
		this.Panel3.Margin = new System.Windows.Forms.Padding(2);
		this.Panel3.Name = "Panel3";
		this.Panel3.Size = new System.Drawing.Size(668, 444);
		this.Panel3.TabIndex = 41;
		this.Panel7.Controls.Add(this.checkupdatbtn);
		this.Panel7.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel7.Location = new System.Drawing.Point(0, 1063);
		this.Panel7.Margin = new System.Windows.Forms.Padding(2);
		this.Panel7.Name = "Panel7";
		this.Panel7.Size = new System.Drawing.Size(651, 32);
		this.Panel7.TabIndex = 75;
		this.checkupdatbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.checkupdatbtn.Dock = System.Windows.Forms.DockStyle.Fill;
		this.checkupdatbtn.FillColor = System.Drawing.Color.Black;
		this.checkupdatbtn.FillDisableColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.checkupdatbtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.checkupdatbtn.ForeColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.checkupdatbtn.Location = new System.Drawing.Point(0, 0);
		this.checkupdatbtn.Margin = new System.Windows.Forms.Padding(2);
		this.checkupdatbtn.Name = "checkupdatbtn";
		this.checkupdatbtn.Radius = 25;
		this.checkupdatbtn.RectColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.checkupdatbtn.RectDisableColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.checkupdatbtn.Size = new System.Drawing.Size(651, 32);
		this.checkupdatbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.checkupdatbtn.Symbol = 61473;
		this.checkupdatbtn.TabIndex = 69;
		this.checkupdatbtn.Text = "Check Update";
		this.Panel5.Controls.Add(this.Label17);
		this.Panel5.Controls.Add(this.PictureBox2);
		this.Panel5.Controls.Add(this.Label18);
		this.Panel5.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel5.Location = new System.Drawing.Point(0, 927);
		this.Panel5.Margin = new System.Windows.Forms.Padding(2);
		this.Panel5.Name = "Panel5";
		this.Panel5.Size = new System.Drawing.Size(651, 136);
		this.Panel5.TabIndex = 42;
		this.Label17.BackColor = System.Drawing.Color.Black;
		this.Label17.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Label17.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold);
		this.Label17.ForeColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.Label17.Location = new System.Drawing.Point(120, 0);
		this.Label17.Name = "Label17";
		this.Label17.Size = new System.Drawing.Size(531, 102);
		this.Label17.TabIndex = 68;
		this.Label17.Text = "CraxsRat V7.1 Cracked.\r\nAdvanced Android Remote Control Software.";
		this.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
		this.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
		this.PictureBox2.Image = Craxs_Rat.My.Resources.Resources.LOGO;
		this.PictureBox2.Location = new System.Drawing.Point(0, 0);
		this.PictureBox2.Name = "PictureBox2";
		this.PictureBox2.Size = new System.Drawing.Size(120, 102);
		this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.PictureBox2.TabIndex = 67;
		this.PictureBox2.TabStop = false;
		this.Label18.BackColor = System.Drawing.Color.Black;
		this.Label18.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Label18.Font = new System.Drawing.Font("Calibri", 10f);
		this.Label18.ForeColor = System.Drawing.SystemColors.WindowFrame;
		this.Label18.Location = new System.Drawing.Point(0, 102);
		this.Label18.Name = "Label18";
		this.Label18.Size = new System.Drawing.Size(651, 34);
		this.Label18.TabIndex = 69;
		this.Label18.Text = "❝ One Rat To Rule Them All ❞";
		this.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.DrakeUITitleLine1.Dock = System.Windows.Forms.DockStyle.Top;
		this.DrakeUITitleLine1.FillColor = System.Drawing.Color.Black;
		this.DrakeUITitleLine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f);
		this.DrakeUITitleLine1.ForeColor = System.Drawing.Color.Red;
		this.DrakeUITitleLine1.LineColor = System.Drawing.Color.Red;
		this.DrakeUITitleLine1.Location = new System.Drawing.Point(0, 886);
		this.DrakeUITitleLine1.Margin = new System.Windows.Forms.Padding(2);
		this.DrakeUITitleLine1.MinimumSize = new System.Drawing.Size(2, 2);
		this.DrakeUITitleLine1.Name = "DrakeUITitleLine1";
		this.DrakeUITitleLine1.Size = new System.Drawing.Size(651, 41);
		this.DrakeUITitleLine1.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUITitleLine1.TabIndex = 66;
		this.DrakeUITitleLine1.Text = "About";
		this.DrakeUITitleLine1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Panel6.Controls.Add(this.LogBrowser);
		this.Panel6.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel6.Location = new System.Drawing.Point(0, 708);
		this.Panel6.Margin = new System.Windows.Forms.Padding(2);
		this.Panel6.Name = "Panel6";
		this.Panel6.Size = new System.Drawing.Size(651, 178);
		this.Panel6.TabIndex = 68;
		this.LogBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
		this.LogBrowser.Location = new System.Drawing.Point(0, 0);
		this.LogBrowser.Margin = new System.Windows.Forms.Padding(2);
		this.LogBrowser.MinimumSize = new System.Drawing.Size(15, 15);
		this.LogBrowser.Name = "LogBrowser";
		this.LogBrowser.Size = new System.Drawing.Size(651, 178);
		this.LogBrowser.TabIndex = 1;
		this.DrakeUITitleLine2.Dock = System.Windows.Forms.DockStyle.Top;
		this.DrakeUITitleLine2.FillColor = System.Drawing.Color.Black;
		this.DrakeUITitleLine2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f);
		this.DrakeUITitleLine2.ForeColor = System.Drawing.Color.Red;
		this.DrakeUITitleLine2.LineColor = System.Drawing.Color.Red;
		this.DrakeUITitleLine2.Location = new System.Drawing.Point(0, 667);
		this.DrakeUITitleLine2.Margin = new System.Windows.Forms.Padding(2);
		this.DrakeUITitleLine2.MinimumSize = new System.Drawing.Size(2, 2);
		this.DrakeUITitleLine2.Name = "DrakeUITitleLine2";
		this.DrakeUITitleLine2.Size = new System.Drawing.Size(651, 41);
		this.DrakeUITitleLine2.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUITitleLine2.TabIndex = 67;
		this.DrakeUITitleLine2.Text = "Updates";
		this.DrakeUITitleLine2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Panel4.Controls.Add(this.Label2);
		this.Panel4.Controls.Add(this.resolutioncombo);
		this.Panel4.Controls.Add(this.recordfps);
		this.Panel4.Controls.Add(this.Label12);
		this.Panel4.Controls.Add(this.LiveSQ);
		this.Panel4.Controls.Add(this.LSFPS);
		this.Panel4.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel4.Location = new System.Drawing.Point(0, 552);
		this.Panel4.Margin = new System.Windows.Forms.Padding(2);
		this.Panel4.Name = "Panel4";
		this.Panel4.Size = new System.Drawing.Size(651, 115);
		this.Panel4.TabIndex = 65;
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.ForeColor = System.Drawing.Color.White;
		this.Label2.Location = new System.Drawing.Point(192, 76);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(81, 19);
		this.Label2.TabIndex = 45;
		this.Label2.Text = "Resolution";
		this.resolutioncombo.BackColor = System.Drawing.Color.Black;
		this.resolutioncombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.resolutioncombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.resolutioncombo.Font = new System.Drawing.Font("Calibri", 9f, System.Drawing.FontStyle.Bold);
		this.resolutioncombo.ForeColor = System.Drawing.Color.Red;
		this.resolutioncombo.Items.AddRange(new object[1] { "300x400" });
		this.resolutioncombo.Location = new System.Drawing.Point(49, 75);
		this.resolutioncombo.Name = "resolutioncombo";
		this.resolutioncombo.Size = new System.Drawing.Size(85, 22);
		this.resolutioncombo.TabIndex = 46;
		this.recordfps.AutoSize = true;
		this.recordfps.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.recordfps.ForeColor = System.Drawing.Color.White;
		this.recordfps.Location = new System.Drawing.Point(192, 26);
		this.recordfps.Name = "recordfps";
		this.recordfps.Size = new System.Drawing.Size(85, 19);
		this.recordfps.TabIndex = 43;
		this.recordfps.Text = "Record FPS";
		this.Label12.AutoSize = true;
		this.Label12.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label12.ForeColor = System.Drawing.Color.White;
		this.Label12.Location = new System.Drawing.Point(192, 51);
		this.Label12.Name = "Label12";
		this.Label12.Size = new System.Drawing.Size(104, 19);
		this.Label12.TabIndex = 41;
		this.Label12.Text = "Image Quality";
		this.LiveSQ.BackColor = System.Drawing.Color.Black;
		this.LiveSQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.LiveSQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.LiveSQ.Font = new System.Drawing.Font("Calibri", 9f, System.Drawing.FontStyle.Bold);
		this.LiveSQ.ForeColor = System.Drawing.Color.Red;
		this.LiveSQ.Items.AddRange(new object[10] { "10", "20", "30", "40", "50", "60", "70", "80", "90", "100" });
		this.LiveSQ.Location = new System.Drawing.Point(49, 50);
		this.LiveSQ.Name = "LiveSQ";
		this.LiveSQ.Size = new System.Drawing.Size(85, 22);
		this.LiveSQ.TabIndex = 42;
		this.LSFPS.BackColor = System.Drawing.Color.Black;
		this.LSFPS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.LSFPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.LSFPS.Font = new System.Drawing.Font("Calibri", 9f, System.Drawing.FontStyle.Bold);
		this.LSFPS.ForeColor = System.Drawing.Color.Red;
		this.LSFPS.Items.AddRange(new object[6] { "10", "20", "30", "40", "50", "60" });
		this.LSFPS.Location = new System.Drawing.Point(49, 24);
		this.LSFPS.Name = "LSFPS";
		this.LSFPS.Size = new System.Drawing.Size(85, 22);
		this.LSFPS.TabIndex = 44;
		this.label11.Dock = System.Windows.Forms.DockStyle.Top;
		this.label11.FillColor = System.Drawing.Color.Black;
		this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f);
		this.label11.ForeColor = System.Drawing.Color.Red;
		this.label11.LineColor = System.Drawing.Color.Red;
		this.label11.Location = new System.Drawing.Point(0, 511);
		this.label11.Margin = new System.Windows.Forms.Padding(2);
		this.label11.MinimumSize = new System.Drawing.Size(2, 2);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(651, 41);
		this.label11.Style = DrakeUI.Framework.UIStyle.Custom;
		this.label11.TabIndex = 64;
		this.label11.Text = "Live Screen";
		this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.fpanel.Controls.Add(this.FMQ);
		this.fpanel.Controls.Add(this.Label8);
		this.fpanel.Controls.Add(this.Checksaveit);
		this.fpanel.Controls.Add(this.Label7);
		this.fpanel.Controls.Add(this.CheckFMI);
		this.fpanel.Controls.Add(this.Label5);
		this.fpanel.Dock = System.Windows.Forms.DockStyle.Top;
		this.fpanel.Location = new System.Drawing.Point(0, 394);
		this.fpanel.Margin = new System.Windows.Forms.Padding(2);
		this.fpanel.Name = "fpanel";
		this.fpanel.Size = new System.Drawing.Size(651, 117);
		this.fpanel.TabIndex = 63;
		this.Checksaveit.ActiveColor = System.Drawing.Color.FromArgb(30, 136, 229);
		this.Checksaveit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f);
		this.Checksaveit.Location = new System.Drawing.Point(63, 50);
		this.Checksaveit.Margin = new System.Windows.Forms.Padding(2);
		this.Checksaveit.Name = "Checksaveit";
		this.Checksaveit.Size = new System.Drawing.Size(49, 19);
		this.Checksaveit.TabIndex = 0;
		this.Checksaveit.Text = "DrakeUIOSSwitch1";
		this.CheckFMI.ActiveColor = System.Drawing.Color.FromArgb(30, 136, 229);
		this.CheckFMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f);
		this.CheckFMI.Location = new System.Drawing.Point(63, 27);
		this.CheckFMI.Margin = new System.Windows.Forms.Padding(2);
		this.CheckFMI.Name = "CheckFMI";
		this.CheckFMI.Size = new System.Drawing.Size(49, 19);
		this.CheckFMI.TabIndex = 45;
		this.CheckFMI.Text = "DrakeUIOSSwitch1";
		this.label10.Dock = System.Windows.Forms.DockStyle.Top;
		this.label10.FillColor = System.Drawing.Color.Black;
		this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f);
		this.label10.ForeColor = System.Drawing.Color.Red;
		this.label10.LineColor = System.Drawing.Color.Red;
		this.label10.Location = new System.Drawing.Point(0, 353);
		this.label10.Margin = new System.Windows.Forms.Padding(2);
		this.label10.MinimumSize = new System.Drawing.Size(2, 2);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(651, 41);
		this.label10.Style = DrakeUI.Framework.UIStyle.Custom;
		this.label10.TabIndex = 62;
		this.label10.Text = "File Manager";
		this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.apanel.Controls.Add(this.Label9);
		this.apanel.Controls.Add(this.Checkplysound);
		this.apanel.Controls.Add(this.Label4);
		this.apanel.Controls.Add(this.CheckNotifi);
		this.apanel.Controls.Add(this.Label14);
		this.apanel.Controls.Add(this.CheckNotifiDis);
		this.apanel.Controls.Add(this.selectedsoundcombo);
		this.apanel.Controls.Add(this.Label13);
		this.apanel.Dock = System.Windows.Forms.DockStyle.Top;
		this.apanel.Location = new System.Drawing.Point(0, 216);
		this.apanel.Margin = new System.Windows.Forms.Padding(2);
		this.apanel.Name = "apanel";
		this.apanel.Size = new System.Drawing.Size(651, 137);
		this.apanel.TabIndex = 61;
		this.Label9.AutoSize = true;
		this.Label9.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label9.ForeColor = System.Drawing.Color.White;
		this.Label9.Location = new System.Drawing.Point(193, 28);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(127, 19);
		this.Label9.TabIndex = 36;
		this.Label9.Text = "Client Disconnect";
		this.Checkplysound.ActiveColor = System.Drawing.Color.FromArgb(30, 136, 229);
		this.Checkplysound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f);
		this.Checkplysound.Location = new System.Drawing.Point(63, 74);
		this.Checkplysound.Margin = new System.Windows.Forms.Padding(2);
		this.Checkplysound.Name = "Checkplysound";
		this.Checkplysound.Size = new System.Drawing.Size(49, 19);
		this.Checkplysound.TabIndex = 60;
		this.CheckNotifi.ActiveColor = System.Drawing.Color.FromArgb(30, 136, 229);
		this.CheckNotifi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f);
		this.CheckNotifi.Location = new System.Drawing.Point(63, 51);
		this.CheckNotifi.Margin = new System.Windows.Forms.Padding(2);
		this.CheckNotifi.Name = "CheckNotifi";
		this.CheckNotifi.Size = new System.Drawing.Size(49, 19);
		this.CheckNotifi.TabIndex = 59;
		this.Label14.AutoSize = true;
		this.Label14.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label14.ForeColor = System.Drawing.Color.White;
		this.Label14.Location = new System.Drawing.Point(193, 75);
		this.Label14.Name = "Label14";
		this.Label14.Size = new System.Drawing.Size(86, 19);
		this.Label14.TabIndex = 44;
		this.Label14.Text = "Play Sound";
		this.CheckNotifiDis.ActiveColor = System.Drawing.Color.FromArgb(30, 136, 229);
		this.CheckNotifiDis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f);
		this.CheckNotifiDis.Location = new System.Drawing.Point(63, 28);
		this.CheckNotifiDis.Margin = new System.Windows.Forms.Padding(2);
		this.CheckNotifiDis.Name = "CheckNotifiDis";
		this.CheckNotifiDis.Size = new System.Drawing.Size(49, 19);
		this.CheckNotifiDis.TabIndex = 58;
		this.selectedsoundcombo.BackColor = System.Drawing.Color.Black;
		this.selectedsoundcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.selectedsoundcombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.selectedsoundcombo.Font = new System.Drawing.Font("Calibri", 9f, System.Drawing.FontStyle.Bold);
		this.selectedsoundcombo.ForeColor = System.Drawing.Color.Red;
		this.selectedsoundcombo.Location = new System.Drawing.Point(49, 98);
		this.selectedsoundcombo.Name = "selectedsoundcombo";
		this.selectedsoundcombo.Size = new System.Drawing.Size(85, 22);
		this.selectedsoundcombo.TabIndex = 48;
		this.Label13.AutoSize = true;
		this.Label13.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label13.ForeColor = System.Drawing.Color.White;
		this.Label13.Location = new System.Drawing.Point(192, 100);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(53, 19);
		this.Label13.TabIndex = 49;
		this.Label13.Text = "Sound";
		this.Label1.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label1.FillColor = System.Drawing.Color.Black;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f);
		this.Label1.ForeColor = System.Drawing.Color.Red;
		this.Label1.LineColor = System.Drawing.Color.Red;
		this.Label1.Location = new System.Drawing.Point(0, 175);
		this.Label1.Margin = new System.Windows.Forms.Padding(2);
		this.Label1.MinimumSize = new System.Drawing.Size(2, 2);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(651, 41);
		this.Label1.Style = DrakeUI.Framework.UIStyle.Custom;
		this.Label1.TabIndex = 57;
		this.Label1.Text = "Alerts";
		this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.gpanel.Controls.Add(this.Label16);
		this.gpanel.Controls.Add(this.Checklogit);
		this.gpanel.Controls.Add(this.Label6);
		this.gpanel.Controls.Add(this.CheckHidecoonstart);
		this.gpanel.Controls.Add(this.Label3);
		this.gpanel.Controls.Add(this.lngtext);
		this.gpanel.Controls.Add(this.Checkupdate);
		this.gpanel.Controls.Add(this.Label15);
		this.gpanel.Dock = System.Windows.Forms.DockStyle.Top;
		this.gpanel.Location = new System.Drawing.Point(0, 41);
		this.gpanel.Margin = new System.Windows.Forms.Padding(2);
		this.gpanel.Name = "gpanel";
		this.gpanel.Size = new System.Drawing.Size(651, 134);
		this.gpanel.TabIndex = 56;
		this.Label16.AutoSize = true;
		this.Label16.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label16.ForeColor = System.Drawing.Color.White;
		this.Label16.Location = new System.Drawing.Point(193, 22);
		this.Label16.Name = "Label16";
		this.Label16.Size = new System.Drawing.Size(161, 19);
		this.Label16.TabIndex = 51;
		this.Label16.Text = "Check Update on start";
		this.Checklogit.ActiveColor = System.Drawing.Color.FromArgb(30, 136, 229);
		this.Checklogit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f);
		this.Checklogit.Location = new System.Drawing.Point(63, 68);
		this.Checklogit.Margin = new System.Windows.Forms.Padding(2);
		this.Checklogit.Name = "Checklogit";
		this.Checklogit.Size = new System.Drawing.Size(49, 19);
		this.Checklogit.TabIndex = 55;
		this.CheckHidecoonstart.ActiveColor = System.Drawing.Color.FromArgb(30, 136, 229);
		this.CheckHidecoonstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f);
		this.CheckHidecoonstart.Location = new System.Drawing.Point(63, 44);
		this.CheckHidecoonstart.Margin = new System.Windows.Forms.Padding(2);
		this.CheckHidecoonstart.Name = "CheckHidecoonstart";
		this.CheckHidecoonstart.Size = new System.Drawing.Size(49, 19);
		this.CheckHidecoonstart.TabIndex = 54;
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.ForeColor = System.Drawing.Color.White;
		this.Label3.Location = new System.Drawing.Point(193, 45);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(184, 19);
		this.Label3.TabIndex = 40;
		this.Label3.Text = "hide connections window";
		this.lngtext.BackColor = System.Drawing.Color.Black;
		this.lngtext.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.lngtext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.lngtext.Font = new System.Drawing.Font("Calibri", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.lngtext.ForeColor = System.Drawing.Color.Red;
		this.lngtext.Items.AddRange(new object[3] { "EN-English", "AR-العربية", "CN-中国人" });
		this.lngtext.Location = new System.Drawing.Point(49, 92);
		this.lngtext.Name = "lngtext";
		this.lngtext.Size = new System.Drawing.Size(85, 22);
		this.lngtext.TabIndex = 46;
		this.Checkupdate.ActiveColor = System.Drawing.Color.FromArgb(30, 136, 229);
		this.Checkupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f);
		this.Checkupdate.Location = new System.Drawing.Point(63, 21);
		this.Checkupdate.Margin = new System.Windows.Forms.Padding(2);
		this.Checkupdate.Name = "Checkupdate";
		this.Checkupdate.Size = new System.Drawing.Size(49, 19);
		this.Checkupdate.TabIndex = 52;
		this.Label15.AutoSize = true;
		this.Label15.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label15.ForeColor = System.Drawing.Color.White;
		this.Label15.Location = new System.Drawing.Point(193, 93);
		this.Label15.Name = "Label15";
		this.Label15.Size = new System.Drawing.Size(74, 19);
		this.Label15.TabIndex = 47;
		this.Label15.Text = "Language";
		this.Generaltext.Dock = System.Windows.Forms.DockStyle.Top;
		this.Generaltext.FillColor = System.Drawing.Color.Black;
		this.Generaltext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f);
		this.Generaltext.ForeColor = System.Drawing.Color.Red;
		this.Generaltext.LineColor = System.Drawing.Color.Red;
		this.Generaltext.Location = new System.Drawing.Point(0, 0);
		this.Generaltext.Margin = new System.Windows.Forms.Padding(2);
		this.Generaltext.MinimumSize = new System.Drawing.Size(2, 2);
		this.Generaltext.Name = "Generaltext";
		this.Generaltext.Size = new System.Drawing.Size(651, 41);
		this.Generaltext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.Generaltext.TabIndex = 53;
		this.Generaltext.Text = "General";
		this.Generaltext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Panel2.Controls.Add(this.exitbtn);
		this.Panel2.Controls.Add(this.PictureBox3);
		this.Panel2.Controls.Add(this.resetbtn);
		this.Panel2.Controls.Add(this.PictureBox6);
		this.Panel2.Controls.Add(this.savebtn);
		this.Panel2.Controls.Add(this.PictureBox5);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel2.Location = new System.Drawing.Point(0, 468);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new System.Drawing.Size(668, 23);
		this.Panel2.TabIndex = 40;
		this.exitbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.exitbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.exitbtn.FillColor = System.Drawing.Color.Black;
		this.exitbtn.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.exitbtn.FillPressColor = System.Drawing.Color.White;
		this.exitbtn.FillSelectedColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.exitbtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.exitbtn.ForeColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.exitbtn.Location = new System.Drawing.Point(281, 0);
		this.exitbtn.Name = "exitbtn";
		this.exitbtn.Radius = 25;
		this.exitbtn.RectColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.exitbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.exitbtn.RectHoverColor = System.Drawing.Color.White;
		this.exitbtn.RectPressColor = System.Drawing.Color.White;
		this.exitbtn.RectSelectedColor = System.Drawing.Color.White;
		this.exitbtn.Size = new System.Drawing.Size(129, 23);
		this.exitbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.exitbtn.Symbol = 61453;
		this.exitbtn.TabIndex = 72;
		this.exitbtn.Text = "Exit";
		this.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.PictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
		this.PictureBox3.Image = (System.Drawing.Image)resources.GetObject("PictureBox3.Image");
		this.PictureBox3.Location = new System.Drawing.Point(68, 0);
		this.PictureBox3.Margin = new System.Windows.Forms.Padding(2);
		this.PictureBox3.Name = "PictureBox3";
		this.PictureBox3.Size = new System.Drawing.Size(38, 23);
		this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.PictureBox3.TabIndex = 69;
		this.PictureBox3.TabStop = false;
		this.resetbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.resetbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.resetbtn.FillColor = System.Drawing.Color.Black;
		this.resetbtn.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.resetbtn.FillPressColor = System.Drawing.Color.White;
		this.resetbtn.FillSelectedColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.resetbtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.resetbtn.ForeColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.resetbtn.Location = new System.Drawing.Point(410, 0);
		this.resetbtn.Name = "resetbtn";
		this.resetbtn.Radius = 25;
		this.resetbtn.RectColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.resetbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.resetbtn.RectHoverColor = System.Drawing.Color.White;
		this.resetbtn.RectPressColor = System.Drawing.Color.White;
		this.resetbtn.RectSelectedColor = System.Drawing.Color.White;
		this.resetbtn.Size = new System.Drawing.Size(129, 23);
		this.resetbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.resetbtn.Symbol = 61473;
		this.resetbtn.TabIndex = 38;
		this.resetbtn.Text = "Reset";
		this.PictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
		this.PictureBox6.Dock = System.Windows.Forms.DockStyle.Left;
		this.PictureBox6.Image = (System.Drawing.Image)resources.GetObject("PictureBox6.Image");
		this.PictureBox6.Location = new System.Drawing.Point(40, 0);
		this.PictureBox6.Margin = new System.Windows.Forms.Padding(2);
		this.PictureBox6.Name = "PictureBox6";
		this.PictureBox6.Size = new System.Drawing.Size(28, 23);
		this.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.PictureBox6.TabIndex = 71;
		this.PictureBox6.TabStop = false;
		this.savebtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.savebtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.savebtn.FillColor = System.Drawing.Color.Black;
		this.savebtn.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.savebtn.FillPressColor = System.Drawing.Color.White;
		this.savebtn.FillSelectedColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.savebtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.savebtn.ForeColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.savebtn.Location = new System.Drawing.Point(539, 0);
		this.savebtn.Name = "savebtn";
		this.savebtn.Radius = 25;
		this.savebtn.RectColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.savebtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.savebtn.RectHoverColor = System.Drawing.Color.White;
		this.savebtn.RectPressColor = System.Drawing.Color.White;
		this.savebtn.RectSelectedColor = System.Drawing.Color.White;
		this.savebtn.Size = new System.Drawing.Size(129, 23);
		this.savebtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.savebtn.TabIndex = 37;
		this.savebtn.Text = "SaveSettings";
		this.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
		this.PictureBox5.Dock = System.Windows.Forms.DockStyle.Left;
		this.PictureBox5.Image = (System.Drawing.Image)resources.GetObject("PictureBox5.Image");
		this.PictureBox5.Location = new System.Drawing.Point(0, 0);
		this.PictureBox5.Margin = new System.Windows.Forms.Padding(2);
		this.PictureBox5.Name = "PictureBox5";
		this.PictureBox5.Size = new System.Drawing.Size(40, 23);
		this.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.PictureBox5.TabIndex = 70;
		this.PictureBox5.TabStop = false;
		this.Panel1.Controls.Add(this.DrakeUISymbolLabel1);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel1.Location = new System.Drawing.Point(0, 0);
		this.Panel1.Margin = new System.Windows.Forms.Padding(2);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(668, 24);
		this.Panel1.TabIndex = 56;
		this.DrakeUISymbolLabel1.BackColor = System.Drawing.Color.FromArgb(10, 10, 10);
		this.DrakeUISymbolLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DrakeUISymbolLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f);
		this.DrakeUISymbolLabel1.ForeColor = System.Drawing.Color.White;
		this.DrakeUISymbolLabel1.Location = new System.Drawing.Point(0, 0);
		this.DrakeUISymbolLabel1.Margin = new System.Windows.Forms.Padding(2);
		this.DrakeUISymbolLabel1.Name = "DrakeUISymbolLabel1";
		this.DrakeUISymbolLabel1.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
		this.DrakeUISymbolLabel1.Size = new System.Drawing.Size(668, 24);
		this.DrakeUISymbolLabel1.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUISymbolLabel1.Symbol = 61573;
		this.DrakeUISymbolLabel1.SymbolColor = System.Drawing.Color.Red;
		this.DrakeUISymbolLabel1.SymbolSize = 40;
		this.DrakeUISymbolLabel1.TabIndex = 50;
		this.DrakeUISymbolLabel1.Text = "CraxsRat Settings";
		this.DrakeUISymbolLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.Black;
		base.ClientSize = new System.Drawing.Size(668, 491);
		base.Controls.Add(this.Panel3);
		base.Controls.Add(this.Panel2);
		base.Controls.Add(this.Panel1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "CraxsSettings";
		this.Text = "CraxsRat Settings";
		this.Panel3.ResumeLayout(false);
		this.Panel7.ResumeLayout(false);
		this.Panel5.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.PictureBox2).EndInit();
		this.Panel6.ResumeLayout(false);
		this.Panel4.ResumeLayout(false);
		this.Panel4.PerformLayout();
		this.fpanel.ResumeLayout(false);
		this.fpanel.PerformLayout();
		this.apanel.ResumeLayout(false);
		this.apanel.PerformLayout();
		this.gpanel.ResumeLayout(false);
		this.gpanel.PerformLayout();
		this.Panel2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.PictureBox3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox6).EndInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox5).EndInit();
		this.Panel1.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	public CraxsSettings()
	{
		base.Load += CypherSettings_Load;
		sizearry = new string[19]
		{
			"original", "1024x768", "1024x600", "960x640", "960x600", "960x540", "864x480", "854x480", "800x600", "800x480",
			"768x576", "640x480", "640x360", "480x320", "432x240", "450x300", "400x240", "320x240", "280x280"
		};
		progma = false;
		first = true;
		InitializeComponent();
	}

	private void CypherSettings_Load(object sender, EventArgs e)
	{
		Label17.Text = "CraxsRat V7.1 Cracked.\r\nAdvanced Android Remote Control Software.";
		Translateme();
		string[] array = sizearry;
		foreach (string item in array)
		{
			resolutioncombo.Items.Add(item);
		}
		resolutioncombo.Text = MySettingsProperty.Settings.resolution;
		GetValues();
		try
		{
			string text = "";
			if (Operators.CompareString(text, "", TextCompare: false) != 0)
			{
				LogBrowser.DocumentText = text;
			}
			else
			{
				LogBrowser.Visible = false;
			}
		}
		catch (Exception)
		{
			LogBrowser.Visible = false;
		}
	}

	private void Translateme()
	{
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "AR", TextCompare: false) == 0)
			{
				Label1.Text = Codes.Translate(Label1.Text, "en", "ar");
				recordfps.Text = "سرعة الإيطار";
				savebtn.Text = "حفظ";
				resetbtn.Text = "إعادة ضبط";
				checkupdatbtn.Text = "تفقد التحديث";
				exitbtn.Text = "اغلاق";
				Generaltext.Text = Codes.Translate(Generaltext.Text, "en", "ar");
				Label3.Text = Codes.Translate(Label3.Text, "en", "ar");
				Label4.Text = Codes.Translate(Label4.Text, "en", "ar");
				Label5.Text = Codes.Translate(Label5.Text, "en", "ar");
				Label6.Text = Codes.Translate(Label6.Text, "en", "ar");
				Label7.Text = Codes.Translate(Label7.Text, "en", "ar");
				Label8.Text = Codes.Translate(Label8.Text, "en", "ar");
				Label9.Text = Codes.Translate(Label9.Text, "en", "ar");
				label10.Text = Codes.Translate(label10.Text, "en", "ar");
				label11.Text = Codes.Translate(label11.Text, "en", "ar");
				Label12.Text = Codes.Translate(Label12.Text, "en", "ar");
				Label13.Text = Codes.Translate(Label13.Text, "en", "ar");
				Label14.Text = Codes.Translate(Label14.Text, "en", "ar");
				Label15.Text = Codes.Translate(Label15.Text, "en", "ar");
				Label16.Text = Codes.Translate(Label16.Text, "en", "ar");
			}
		}
		else
		{
			Label1.Text = Codes.Translate(Label1.Text, "en", "zh");
			Generaltext.Text = Codes.Translate(Generaltext.Text, "en", "zh");
			Label3.Text = Codes.Translate(Label3.Text, "en", "zh");
			Label4.Text = Codes.Translate(Label4.Text, "en", "zh");
			Label5.Text = Codes.Translate(Label5.Text, "en", "zh");
			Label6.Text = Codes.Translate(Label6.Text, "en", "zh");
			Label7.Text = Codes.Translate(Label7.Text, "en", "zh");
			Label8.Text = Codes.Translate(Label8.Text, "en", "zh");
			Label9.Text = Codes.Translate(Label9.Text, "en", "zh");
			label10.Text = Codes.Translate(label10.Text, "en", "zh");
			label11.Text = Codes.Translate(label11.Text, "en", "zh");
			Label12.Text = Codes.Translate(Label12.Text, "en", "zh");
			Label13.Text = Codes.Translate(Label13.Text, "en", "zh");
			Label14.Text = Codes.Translate(Label14.Text, "en", "zh");
			Label15.Text = Codes.Translate(Label15.Text, "en", "zh");
			Label16.Text = Codes.Translate(Label16.Text, "en", "zh");
			exitbtn.Text = "关闭";
			resetbtn.Text = "重置";
			recordfps.Text = "帧速度";
			checkupdatbtn.Text = "检查更新";
		}
	}

	public void GetValues()
	{
		try
		{
			if (Operators.CompareString(MySettingsProperty.Settings.hidecoonstart, "Yes", TextCompare: false) == 0)
			{
				CheckHidecoonstart.Active = true;
			}
			else
			{
				CheckHidecoonstart.Active = false;
			}
			if (Operators.CompareString(MySettingsProperty.Settings.show_alert, "Yes", TextCompare: false) == 0)
			{
				CheckNotifi.Active = true;
			}
			else
			{
				CheckNotifi.Active = false;
			}
			if (Operators.CompareString(MySettingsProperty.Settings.ShowAlertDis, "Yes", TextCompare: false) == 0)
			{
				CheckNotifiDis.Active = true;
			}
			else
			{
				CheckNotifiDis.Active = false;
			}
			if (Operators.CompareString(MySettingsProperty.Settings.LOG, "Yes", TextCompare: false) == 0)
			{
				Checklogit.Active = true;
			}
			else
			{
				Checklogit.Active = false;
			}
			if (Operators.CompareString(MySettingsProperty.Settings.Saving_data, "Yes", TextCompare: false) == 0)
			{
				Checksaveit.Active = true;
			}
			else
			{
				Checksaveit.Active = false;
			}
			if (Operators.CompareString(MySettingsProperty.Settings.FM_IC_Size, "Small", TextCompare: false) == 0)
			{
				CheckFMI.Active = true;
			}
			else
			{
				CheckFMI.Active = false;
			}
			FMQ.Text = Conversions.ToString(MySettingsProperty.Settings.ImageQualty);
			LiveSQ.Text = Conversions.ToString(LiveSQ.Items[LiveSQ.Items.IndexOf(MySettingsProperty.Settings.live_sc_qulty)]);
			LSFPS.Text = Conversions.ToString(LSFPS.Items[LSFPS.Items.IndexOf(MySettingsProperty.Settings.live_fps_rec)]);
			Checkplysound.Active = MySettingsProperty.Settings.NOTI_SOUND;
			string[] files = Directory.GetFiles(reso.res_Path + "\\Audio");
			foreach (string path in files)
			{
				try
				{
					string item = Path.GetFileName(path).Split('.')[0];
					selectedsoundcombo.Items.Add(item);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			if (RegistryHandler.GET_SoundID() == null)
			{
				RegistryHandler.SET_SoundID("5");
			}
			progma = true;
			selectedsoundcombo.Text = RegistryHandler.GET_SoundID();
			if (Operators.CompareString(MySettingsProperty.Settings.checkupdatestart, "Yes", TextCompare: false) == 0)
			{
				Checkupdate.Active = true;
			}
			else
			{
				Checkupdate.Active = false;
			}
			switch (RegistryHandler.Get_Language())
			{
			case "CN":
				lngtext.Text = "CN-中国人";
				break;
			case "AR":
				lngtext.Text = "AR-العربية";
				break;
			case "EN":
				lngtext.Text = "EN-English";
				break;
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
	}

	private void Button1_Click(object sender, EventArgs e)
	{
	}

	private void DrakeUIAvatar2_Click(object sender, EventArgs e)
	{
		MySettingsProperty.Settings.performance = "Normal";
		MySettingsProperty.Settings.show_alert = "Yes";
		MySettingsProperty.Settings.ShowAlertDis = "Yes";
		MySettingsProperty.Settings.hidecoonstart = "Yes";
		MySettingsProperty.Settings.LOG = "Yes";
		MySettingsProperty.Settings.Saving_data = "Yes";
		MySettingsProperty.Settings.FM_IC_Size = "Small";
		MySettingsProperty.Settings.ImageQualty = Conversions.ToInteger("20");
		GetValues();
	}

	private void DrakeUIAvatar1_Click(object sender, EventArgs e)
	{
		if (CheckNotifi.Active)
		{
			MySettingsProperty.Settings.show_alert = "Yes";
		}
		else
		{
			MySettingsProperty.Settings.show_alert = "No";
		}
		if (CheckNotifiDis.Active)
		{
			MySettingsProperty.Settings.ShowAlertDis = "Yes";
		}
		else
		{
			MySettingsProperty.Settings.ShowAlertDis = "No";
		}
		if (Checklogit.Active)
		{
			MySettingsProperty.Settings.LOG = "Yes";
		}
		else
		{
			MySettingsProperty.Settings.LOG = "No";
		}
		if (Checksaveit.Active)
		{
			MySettingsProperty.Settings.Saving_data = "Yes";
		}
		else
		{
			MySettingsProperty.Settings.Saving_data = "No";
		}
		if (CheckFMI.Active)
		{
			MySettingsProperty.Settings.FM_IC_Size = "Small";
		}
		else
		{
			MySettingsProperty.Settings.FM_IC_Size = "Large";
		}
		MySettingsProperty.Settings.ImageQualty = Conversions.ToInteger(FMQ.Text);
		if (CheckHidecoonstart.Active)
		{
			MySettingsProperty.Settings.hidecoonstart = "Yes";
		}
		else
		{
			MySettingsProperty.Settings.hidecoonstart = "No";
		}
		MySettingsProperty.Settings.live_sc_qulty = LiveSQ.Text;
		MySettingsProperty.Settings.live_fps_rec = LSFPS.Text;
		if (Checkupdate.Active)
		{
			MySettingsProperty.Settings.checkupdatestart = "Yes";
		}
		else
		{
			MySettingsProperty.Settings.checkupdatestart = "No";
		}
		MySettingsProperty.Settings.NOTI_SOUND = Checkplysound.Active;
		MySettingsProperty.Settings.resolution = resolutioncombo.Text;
		string language = lngtext.Text.Split('-')[0];
		RegistryHandler.Set_Language(language);
		MySettingsProperty.Settings.Save();
		RegistryHandler.SET_SoundID(selectedsoundcombo.Text);
		CraxsAlert.ShowSucess("Saved Changes will be made after restarting the program");
		Close();
	}

	private void DrakeUIButton1_Click(object sender, EventArgs e)
	{
	}

	private void Copydev_Click(object sender, EventArgs e)
	{
		RegistryHandler.Set_Language("AR");
	}

	private void DrakeUIButton2_Click(object sender, EventArgs e)
	{
		RegistryHandler.Set_Language("CN");
	}

	private void Selectedsoundcombo_SelectedIndexChanged(object sender, EventArgs e)
	{
		try
		{
			if (progma)
			{
				progma = false;
				return;
			}
			string text = reso.res_Path + "\\Audio\\[id].wav";
			if (!File.Exists(text.Replace("[id]", selectedsoundcombo.Text)))
			{
				return;
			}
			Notif_Sound.aMedia = new SoundPlayer();
			Notif_Sound.aMedia.SoundLocation = Notif_Sound.getsoundpath();
			Notif_Sound.aMedia.Load();
			RegistryHandler.SET_SoundID(selectedsoundcombo.Text);
			while (!Notif_Sound.aMedia.IsLoadCompleted)
			{
				Thread.Sleep(100);
			}
			try
			{
				Notif_Sound.aMedia.Play();
			}
			catch (InvalidOperationException projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void Resolutioncombo_MouseClick(object sender, MouseEventArgs e)
	{
		if (first)
		{
			first = false;
			Codes.MyMsgBox("Alert", "This option can effect the FPS for screen monitor.\r\nMore Resolution = slow connection", useno: false, Resources.information48px);
		}
	}

	private void Checkupdatbtn_Click(object sender, EventArgs e)
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

	private void PictureBox5_Click(object sender, EventArgs e)
	{
		try
		{
			Process.Start("facebook.com");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void PictureBox6_Click(object sender, EventArgs e)
	{
		try
		{
			Process.Start("twitter.com");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void PictureBox3_Click(object sender, EventArgs e)
	{
		try
		{
			Process.Start("telegram.com");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void DrakeUISymbolLabel1_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			Codes.ReleaseCapture();
			Codes.SendMessage(base.Handle, 161, 2, 0);
		}
	}

	private void Panel1_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			Codes.ReleaseCapture();
			Codes.SendMessage(base.Handle, 161, 2, 0);
		}
	}

	private void Panel2_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			Codes.ReleaseCapture();
			Codes.SendMessage(base.Handle, 161, 2, 0);
		}
	}

	private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void Label17_Click(object sender, EventArgs e)
	{
	}
}
