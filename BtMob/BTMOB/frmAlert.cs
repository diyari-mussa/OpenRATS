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

namespace BTMOB;

[DesignerGenerated]
public class frmAlert : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("lblMessage")]
	private Label _lblMessage;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ptbLogo")]
	private PictureBox _ptbLogo;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("timer")]
	private Timer _timer;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnExit")]
	private DrakeUIButtonIcon _btnExit;

	private const int SW_SHOWNOACTIVATE = 4;

	private const int HWND_TOPMOST = -1;

	private const int HWND_NOTOPMOST = -2;

	private const uint SWP_NOACTIVATE = 16u;

	private AlertType.AlertAction _action;

	private int _interval;

	private int positionX;

	private int positionY;

	private int targetY;

	private int slideSpeed;

	private static List<frmAlert> ActiveAlerts = new List<frmAlert>();

	private static Queue<frmAlert> PendingAlerts = new Queue<frmAlert>();

	private const int MaxVisibleAlerts = 8;

	private static bool[] Slots = new bool[8];

	private int fadeSpeed;

	private bool iamout;

	protected virtual Label lblMessage
	{
		[CompilerGenerated]
		get
		{
			return _lblMessage;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = lblMessage_Click;
			Label label = _lblMessage;
			if (label != null)
			{
				label.Click -= value2;
			}
			_lblMessage = value;
			label = _lblMessage;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	protected virtual PictureBox ptbLogo
	{
		[CompilerGenerated]
		get
		{
			return _ptbLogo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ptbLogo_Click;
			PictureBox pictureBox = _ptbLogo;
			if (pictureBox != null)
			{
				pictureBox.Click -= value2;
			}
			_ptbLogo = value;
			pictureBox = _ptbLogo;
			if (pictureBox != null)
			{
				pictureBox.Click += value2;
			}
		}
	}

	protected virtual Timer timer
	{
		[CompilerGenerated]
		get
		{
			return _timer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = timer_Tick;
			Timer timer = _timer;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_timer = value;
			timer = _timer;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("toppanel")]
	protected virtual Panel toppanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("panel2")]
	protected virtual Panel panel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("panel3")]
	protected virtual Panel panel3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("panel4")]
	protected virtual Panel panel4
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

	internal virtual DrakeUIButtonIcon btnExit
	{
		[CompilerGenerated]
		get
		{
			return _btnExit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnExit_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _btnExit;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_btnExit = value;
			drakeUIButtonIcon = _btnExit;
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

	public int AlertIndex { get; set; }

	protected override bool ShowWithoutActivation => true;

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = base.CreateParams;
			createParams.ExStyle |= 134217856;
			return createParams;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTMOB.frmAlert));
		this.lblMessage = new System.Windows.Forms.Label();
		this.ptbLogo = new System.Windows.Forms.PictureBox();
		this.timer = new System.Windows.Forms.Timer(this.components);
		this.toppanel = new System.Windows.Forms.Panel();
		this.panel2 = new System.Windows.Forms.Panel();
		this.panel3 = new System.Windows.Forms.Panel();
		this.panel4 = new System.Windows.Forms.Panel();
		this.Panel5 = new System.Windows.Forms.Panel();
		this.btnExit = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.Panel7 = new System.Windows.Forms.Panel();
		((System.ComponentModel.ISupportInitialize)this.ptbLogo).BeginInit();
		this.panel4.SuspendLayout();
		this.Panel5.SuspendLayout();
		this.Panel7.SuspendLayout();
		base.SuspendLayout();
		this.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill;
		this.lblMessage.Font = new System.Drawing.Font(EXGuarder._1B051F37, 8f, System.Drawing.FontStyle.Bold);
		this.lblMessage.ForeColor = System.Drawing.Color.White;
		this.lblMessage.Location = new System.Drawing.Point(6, 6);
		this.lblMessage.Name = EXGuarder._51456100;
		this.lblMessage.Size = new System.Drawing.Size(321, 51);
		this.lblMessage.TabIndex = 8;
		this.lblMessage.Text = EXGuarder._2A753A3F;
		this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.ptbLogo.Dock = System.Windows.Forms.DockStyle.Left;
		this.ptbLogo.Image = BTMOB.My.Resources.Resources.error_img;
		this.ptbLogo.Location = new System.Drawing.Point(0, 0);
		this.ptbLogo.Name = EXGuarder._4F191722;
		this.ptbLogo.Size = new System.Drawing.Size(39, 23);
		this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.ptbLogo.TabIndex = 7;
		this.ptbLogo.TabStop = false;
		this.timer.Interval = 15;
		this.toppanel.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.toppanel.Dock = System.Windows.Forms.DockStyle.Left;
		this.toppanel.Location = new System.Drawing.Point(0, 23);
		this.toppanel.Name = EXGuarder._114E190C;
		this.toppanel.Size = new System.Drawing.Size(2, 63);
		this.toppanel.TabIndex = 9;
		this.panel2.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
		this.panel2.Location = new System.Drawing.Point(0, 0);
		this.panel2.Name = EXGuarder._5614026F;
		this.panel2.Size = new System.Drawing.Size(291, 3);
		this.panel2.TabIndex = 4;
		this.panel3.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
		this.panel3.Location = new System.Drawing.Point(329, 23);
		this.panel3.Name = EXGuarder._0A113723;
		this.panel3.Size = new System.Drawing.Size(2, 63);
		this.panel3.TabIndex = 11;
		this.panel4.Controls.Add(this.panel2);
		this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.panel4.Location = new System.Drawing.Point(0, 86);
		this.panel4.Name = EXGuarder._616F3D70;
		this.panel4.Size = new System.Drawing.Size(331, 3);
		this.panel4.TabIndex = 12;
		this.Panel5.Controls.Add(this.lblMessage);
		this.Panel5.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel5.Location = new System.Drawing.Point(2, 23);
		this.Panel5.Name = EXGuarder._1B5C5865;
		this.Panel5.Padding = new System.Windows.Forms.Padding(6, 6, 0, 6);
		this.Panel5.Size = new System.Drawing.Size(327, 63);
		this.Panel5.TabIndex = 13;
		this.btnExit.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
		this.btnExit.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.btnExit.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.btnExit.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.btnExit.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.btnExit.Font = new System.Drawing.Font(EXGuarder._1B051F37, 12f, System.Drawing.FontStyle.Bold);
		this.btnExit.ForeColor = System.Drawing.Color.FromArgb(109, 109, 103);
		this.btnExit.ForeHoverColor = System.Drawing.Color.Red;
		this.btnExit.Location = new System.Drawing.Point(321, 0);
		this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.btnExit.Name = EXGuarder._121C3C67;
		this.btnExit.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.btnExit.RectColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.btnExit.RectDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.btnExit.RectHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.btnExit.RectPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.btnExit.RectSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.btnExit.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.btnExit.Size = new System.Drawing.Size(10, 23);
		this.btnExit.Style = DrakeUI.Framework.UIStyle.Custom;
		this.btnExit.Symbol = 61713;
		this.btnExit.SymbolSize = 0;
		this.btnExit.TabIndex = 3;
		this.btnExit.Text = EXGuarder._38755447;
		this.Panel7.Controls.Add(this.ptbLogo);
		this.Panel7.Controls.Add(this.btnExit);
		this.Panel7.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel7.Location = new System.Drawing.Point(0, 0);
		this.Panel7.Name = EXGuarder._2A2C2B50;
		this.Panel7.Size = new System.Drawing.Size(331, 23);
		this.Panel7.TabIndex = 10;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		base.ClientSize = new System.Drawing.Size(331, 89);
		base.Controls.Add(this.Panel5);
		base.Controls.Add(this.toppanel);
		base.Controls.Add(this.panel3);
		base.Controls.Add(this.panel4);
		base.Controls.Add(this.Panel7);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject(EXGuarder._3574225A);
		base.Name = EXGuarder._75626D1A;
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		this.Text = EXGuarder._75626D1A;
		((System.ComponentModel.ISupportInitialize)this.ptbLogo).EndInit();
		this.panel4.ResumeLayout(false);
		this.Panel5.ResumeLayout(false);
		this.Panel7.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	[DllImport("user32.dll")]
	private static extern bool SetWindowPos(int hWnd, int hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

	[DllImport("user32.dll")]
	private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	private static void ShowInactiveTopmost(Form frm)
	{
		ShowWindow(frm.Handle, 4);
		SetWindowPos(frm.Handle.ToInt32(), -1, frm.Left, frm.Top, frm.Width, frm.Height, 16u);
	}

	public frmAlert()
	{
		base.Load += frmAlert_Load;
		slideSpeed = 5;
		fadeSpeed = 14;
		iamout = false;
		InitializeComponent();
	}

	private void timer_Tick(object sender, EventArgs e)
	{
		if (base.Bounds.Contains(Cursor.Position))
		{
			return;
		}
		switch (_action)
		{
		case AlertType.AlertAction.Start:
			if (base.Opacity < 1.0)
			{
				base.Opacity += 0.08;
				break;
			}
			base.Opacity = 1.0;
			_action = AlertType.AlertAction.Wait;
			timer.Interval = 18;
			panel2.Width = panel4.Width;
			break;
		case AlertType.AlertAction.Wait:
			if (panel2.Width > 0)
			{
				checked
				{
					panel2.Width -= 2;
				}
				if (panel2.Width <= panel4.Width / 2)
				{
					base.Opacity -= 0.02;
					if (base.Opacity < 0.0)
					{
						base.Opacity = 0.0;
					}
				}
			}
			else
			{
				FreeSlot();
				Close();
			}
			break;
		case AlertType.AlertAction.Close:
			if (base.Opacity > 0.0)
			{
				timer.Interval = 80;
				base.Opacity -= 0.02;
			}
			else
			{
				FreeSlot();
				Close();
			}
			break;
		}
	}

	private void FreeSlot()
	{
		ActiveAlerts.Remove(this);
		Slots[AlertIndex] = false;
		if (PendingAlerts.Count > 0)
		{
			frmAlert frmAlert2 = PendingAlerts.Dequeue();
			ActiveAlerts.Add(frmAlert2);
			int num = Array.FindIndex(Slots, [SpecialName] (bool s) => !s);
			if (num != -1)
			{
				frmAlert2.AlertIndex = num;
				Slots[num] = true;
				frmAlert2.SetPosition();
				frmAlert2._action = AlertType.AlertAction.Start;
				frmAlert2.timer.Interval = 20;
				frmAlert2.timer.Start();
				ShowInactiveTopmost(frmAlert2);
			}
		}
	}

	internal void ShowAlert(string message, AlertType.AlertIconType alertType, int interval, Image image = null, Color color = default(Color))
	{
		base.Opacity = 0.0;
		base.StartPosition = FormStartPosition.Manual;
		lblMessage.Text = message;
		_interval = interval;
		SetupAlertAppearance(alertType, image, color);
		int num = Array.FindIndex(Slots, [SpecialName] (bool s) => !s);
		if (num == -1)
		{
			PendingAlerts.Enqueue(this);
			return;
		}
		panel2.Width = panel4.Width;
		AlertIndex = num;
		Slots[num] = true;
		ActiveAlerts.Add(this);
		SetPosition();
		ShowInactiveTopmost(this);
		_action = AlertType.AlertAction.Start;
		timer.Interval = 20;
		timer.Start();
	}

	private void SetPosition()
	{
		int num = 10;
		int num2 = 10;
		Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
		checked
		{
			int num3 = workingArea.Right - base.Width - num;
			int num4 = workingArea.Top + num + AlertIndex * (base.Height + num2);
			base.Location = new Point(num3, num4);
		}
	}

	private void SetupAlertAppearance(AlertType.AlertIconType type, Image image, Color color)
	{
		panel2.BackColor = Color.FromArgb(2, 176, 117);
		switch (type)
		{
		case AlertType.AlertIconType.Sucess:
			ptbLogo.Image = Resources.ok;
			break;
		case AlertType.AlertIconType.Information:
			ptbLogo.Image = Resources.information;
			break;
		case AlertType.AlertIconType.Warning:
			ptbLogo.Image = Resources.warning;
			break;
		case AlertType.AlertIconType.Error:
			ptbLogo.Image = Resources.error_img;
			break;
		case AlertType.AlertIconType.Custom:
			ptbLogo.Image = ((image != null) ? image : Resources.information);
			break;
		}
	}

	private void frmAlert_Load(object sender, EventArgs e)
	{
		ShowInactiveTopmost(this);
		timer.Interval = 3000;
		timer.Start();
	}

	private void btnExit_Click(object sender, EventArgs e)
	{
		_action = AlertType.AlertAction.Close;
		base.Opacity = 0.0;
		timer.Stop();
		Close();
	}

	private void lblMessage_Click(object sender, EventArgs e)
	{
		_action = AlertType.AlertAction.Close;
		base.Opacity = 0.0;
		timer.Stop();
		Close();
	}

	private void ptbLogo_Click(object sender, EventArgs e)
	{
		_action = AlertType.AlertAction.Close;
		base.Opacity = 0.0;
		timer.Stop();
		Close();
	}
}
