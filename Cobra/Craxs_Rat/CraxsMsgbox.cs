using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Craxs_Rat.My.Resources;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat;

[DesignerGenerated]
public class CraxsMsgbox : Form
{
	public class NativeStructs
	{
		public struct MARGINS
		{
			public int leftWidth;

			public int rightWidth;

			public int topHeight;

			public int bottomHeight;
		}
	}

	public class NativeMethods
	{
		[DllImport("dwmapi")]
		public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref NativeStructs.MARGINS pMarInset);

		[DllImport("dwmapi")]
		internal static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

		[DllImport("dwmapi.dll")]
		public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
	}

	public class NativeConstants
	{
		public const int CS_DROPSHADOW = 131072;

		public const int WM_NCPAINT = 133;
	}

	private struct FormBoundsColors
	{
		public Color TopLeftColor;

		public Color TopRightColor;

		public Color BottomLeftColor;

		public Color BottomRightColor;
	}

	private IContainer components;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("nobtn")]
	[CompilerGenerated]
	private DrakeUIButtonIcon _nobtn;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("okbtn")]
	[CompilerGenerated]
	private DrakeUIButtonIcon _okbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("Timer1")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Timer _Timer1;

	private bool aeroEnabled;

	private int borderRadius;

	private int borderSize;

	private Color borderColor;

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon nobtn
	{
		[CompilerGenerated]
		get
		{
			return _nobtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon1_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _nobtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_nobtn = value;
			drakeUIButtonIcon = _nobtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon okbtn
	{
		[CompilerGenerated]
		get
		{
			return _okbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon2_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _okbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_okbtn = value;
			drakeUIButtonIcon = _okbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("msgtext")]
	internal virtual Label msgtext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("titletext")]
	internal virtual DrakeUITitlePanel titletext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
			PaintEventHandler value2 = Panel2_Paint;
			Panel panel = _Panel2;
			if (panel != null)
			{
				panel.Paint -= value2;
			}
			_Panel2 = value;
			panel = _Panel2;
			if (panel != null)
			{
				panel.Paint += value2;
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

	[field: AccessedThroughProperty("picbox")]
	internal virtual PictureBox picbox
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	protected override CreateParams CreateParams
	{
		get
		{
			CheckAeroEnabled();
			CreateParams createParams = base.CreateParams;
			if (!aeroEnabled)
			{
				createParams.ClassStyle |= 131072;
				return createParams;
			}
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
		this.Panel1 = new System.Windows.Forms.Panel();
		this.okbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.nobtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.msgtext = new System.Windows.Forms.Label();
		this.titletext = new DrakeUI.Framework.DrakeUITitlePanel();
		this.picbox = new System.Windows.Forms.PictureBox();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.Timer1 = new System.Windows.Forms.Timer(this.components);
		this.Panel1.SuspendLayout();
		this.titletext.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.picbox).BeginInit();
		this.Panel2.SuspendLayout();
		base.SuspendLayout();
		this.Panel1.Controls.Add(this.okbtn);
		this.Panel1.Controls.Add(this.nobtn);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel1.Location = new System.Drawing.Point(0, 230);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(688, 39);
		this.Panel1.TabIndex = 0;
		this.okbtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.okbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.okbtn.FillColor = System.Drawing.Color.Black;
		this.okbtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.okbtn.ForeColor = System.Drawing.Color.Lime;
		this.okbtn.Location = new System.Drawing.Point(589, 3);
		this.okbtn.Name = "okbtn";
		this.okbtn.RectColor = System.Drawing.Color.SkyBlue;
		this.okbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.okbtn.Size = new System.Drawing.Size(87, 28);
		this.okbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.okbtn.TabIndex = 1;
		this.okbtn.Text = "OK";
		this.nobtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.nobtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.nobtn.FillColor = System.Drawing.Color.Black;
		this.nobtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.nobtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.nobtn.Location = new System.Drawing.Point(487, 3);
		this.nobtn.Name = "nobtn";
		this.nobtn.RectColor = System.Drawing.Color.SkyBlue;
		this.nobtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.nobtn.Size = new System.Drawing.Size(87, 28);
		this.nobtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.nobtn.Symbol = 61453;
		this.nobtn.TabIndex = 0;
		this.nobtn.Text = "NO";
		this.msgtext.Dock = System.Windows.Forms.DockStyle.Fill;
		this.msgtext.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.msgtext.Location = new System.Drawing.Point(61, 35);
		this.msgtext.Name = "msgtext";
		this.msgtext.Size = new System.Drawing.Size(627, 195);
		this.msgtext.TabIndex = 2;
		this.msgtext.Text = "you are the only responsible for using this program\r\nOnly install in phone you have permissions to";
		this.msgtext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.titletext.Controls.Add(this.msgtext);
		this.titletext.Controls.Add(this.picbox);
		this.titletext.Dock = System.Windows.Forms.DockStyle.Fill;
		this.titletext.FillColor = System.Drawing.Color.FromArgb(225, 245, 254);
		this.titletext.Font = new System.Drawing.Font("Calibri", 12f);
		this.titletext.ForeColor = System.Drawing.Color.White;
		this.titletext.Location = new System.Drawing.Point(0, 0);
		this.titletext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.titletext.Name = "titletext";
		this.titletext.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
		this.titletext.RectColor = System.Drawing.Color.SkyBlue;
		this.titletext.Size = new System.Drawing.Size(688, 230);
		this.titletext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.titletext.TabIndex = 3;
		this.titletext.Text = "title";
		this.titletext.TitleColor = System.Drawing.Color.SkyBlue;
		this.picbox.BackColor = System.Drawing.Color.Black;
		this.picbox.Dock = System.Windows.Forms.DockStyle.Left;
		this.picbox.Image = Craxs_Rat.My.Resources.Resources.warning48px;
		this.picbox.Location = new System.Drawing.Point(0, 35);
		this.picbox.Name = "picbox";
		this.picbox.Size = new System.Drawing.Size(61, 195);
		this.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.picbox.TabIndex = 3;
		this.picbox.TabStop = false;
		this.Panel2.Controls.Add(this.titletext);
		this.Panel2.Controls.Add(this.Panel1);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel2.Location = new System.Drawing.Point(0, 0);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new System.Drawing.Size(688, 269);
		this.Panel2.TabIndex = 3;
		this.Timer1.Interval = 500;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.Black;
		base.ClientSize = new System.Drawing.Size(688, 269);
		base.ControlBox = false;
		base.Controls.Add(this.Panel2);
		this.ForeColor = System.Drawing.Color.White;
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "CraxsMsgbox";
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "CraxsMsgbox";
		base.TopMost = true;
		this.Panel1.ResumeLayout(false);
		this.titletext.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.picbox).EndInit();
		this.Panel2.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	protected override void WndProc(ref Message m)
	{
		int msg = m.Msg;
		if (msg == 133)
		{
			int attrValue = 2;
			if (aeroEnabled)
			{
				NativeMethods.DwmSetWindowAttribute(base.Handle, 2, ref attrValue, 4);
				NativeStructs.MARGINS pMarInset = new NativeStructs.MARGINS
				{
					bottomHeight = 1,
					leftWidth = 1,
					rightWidth = 1,
					topHeight = 1
				};
				NativeMethods.DwmExtendFrameIntoClientArea(base.Handle, ref pMarInset);
			}
		}
		base.WndProc(ref m);
	}

	private void CheckAeroEnabled()
	{
		if (Environment.OSVersion.Version.Major >= 6)
		{
			int pfEnabled = 0;
			NativeMethods.DwmIsCompositionEnabled(ref pfEnabled);
			aeroEnabled = pfEnabled == 1;
		}
		else
		{
			aeroEnabled = false;
		}
	}

	public CraxsMsgbox(string t, string m, bool no, Bitmap ico)
	{
		base.Load += CraxsMsgbox_Load;
		base.Paint += CraxsMsgbox_Paint;
		aeroEnabled = true;
		borderRadius = 30;
		borderSize = 3;
		borderColor = Color.Transparent;
		InitializeComponent();
		titletext.Text = t;
		msgtext.Text = m;
		if (!no)
		{
			nobtn.Visible = false;
		}
		picbox.Image = ico;
	}

	private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.Yes;
		Timer1.Stop();
		Close();
	}

	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.Cancel;
		Timer1.Stop();
		Close();
	}

	private void CraxsMsgbox_Load(object sender, EventArgs e)
	{
		CenterToScreen();
		Timer1.Start();
	}

	private void FormRegionAndBorder(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
	{
		if (base.WindowState == FormWindowState.Minimized)
		{
			return;
		}
		using GraphicsPath path = GetRoundedPath(form.ClientRectangle, radius);
		using Pen pen = new Pen(borderColor, borderSize);
		using Matrix matrix = new Matrix();
		graph.SmoothingMode = SmoothingMode.AntiAlias;
		form.Region = new System.Drawing.Region(path);
		if (borderSize >= 1f)
		{
			Rectangle clientRectangle = form.ClientRectangle;
			float scaleX = 1f - (borderSize + 1f) / (float)clientRectangle.Width;
			float scaleY = 1f - (borderSize + 1f) / (float)clientRectangle.Height;
			matrix.Scale(scaleX, scaleY);
			matrix.Translate(borderSize / 1.6f, borderSize / 1.6f);
			graph.Transform = matrix;
			graph.DrawPath(pen, path);
		}
	}

	private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
	{
		GraphicsPath graphicsPath = new GraphicsPath();
		float num = radius * 2f;
		graphicsPath.StartFigure();
		graphicsPath.AddArc(rect.X, rect.Y, num, num, 180f, 90f);
		graphicsPath.AddArc((float)rect.Right - num, rect.Y, num, num, 270f, 90f);
		graphicsPath.AddArc((float)rect.Right - num, (float)rect.Bottom - num, num, num, 0f, 90f);
		graphicsPath.AddArc(rect.X, (float)rect.Bottom - num, num, num, 90f, 90f);
		graphicsPath.CloseFigure();
		return graphicsPath;
	}

	private void ControlRegionAndBorder(Control control, float radius, Graphics graph, Color borderColor)
	{
		using GraphicsPath path = GetRoundedPath(control.ClientRectangle, radius);
		using Pen pen = new Pen(borderColor, 1f);
		graph.SmoothingMode = SmoothingMode.AntiAlias;
		control.Region = new System.Drawing.Region(path);
		graph.DrawPath(pen, path);
	}

	private void DrawPath(Rectangle rectForm, Graphics graphics, Color color)
	{
		using GraphicsPath path = GetRoundedPath(rectForm, borderRadius);
		using Pen pen = new Pen(color, 3f);
		graphics.DrawPath(pen, path);
	}

	private FormBoundsColors GetFormBoundsColors()
	{
		FormBoundsColors result = default(FormBoundsColors);
		using (Bitmap bitmap = new Bitmap(1, 1))
		{
			using Graphics graphics = Graphics.FromImage(bitmap);
			Rectangle rectangle = new Rectangle(0, 0, 1, 1);
			rectangle.X = checked(base.Bounds.X - 1);
			rectangle.Y = base.Bounds.Y;
			graphics.CopyFromScreen(rectangle.Location, Point.Empty, rectangle.Size);
			result.TopLeftColor = bitmap.GetPixel(0, 0);
			rectangle.X = base.Bounds.Right;
			rectangle.Y = base.Bounds.Y;
			graphics.CopyFromScreen(rectangle.Location, Point.Empty, rectangle.Size);
			result.TopRightColor = bitmap.GetPixel(0, 0);
			rectangle.X = base.Bounds.X;
			rectangle.Y = base.Bounds.Bottom;
			graphics.CopyFromScreen(rectangle.Location, Point.Empty, rectangle.Size);
			result.BottomLeftColor = bitmap.GetPixel(0, 0);
			rectangle.X = base.Bounds.Right;
			rectangle.Y = base.Bounds.Bottom;
			graphics.CopyFromScreen(rectangle.Location, Point.Empty, rectangle.Size);
			result.BottomRightColor = bitmap.GetPixel(0, 0);
		}
		return result;
	}

	private void CraxsMsgbox_Paint(object sender, PaintEventArgs e)
	{
		e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
		Rectangle clientRectangle = base.ClientRectangle;
		checked
		{
			int num = (int)Math.Round((double)clientRectangle.Width / 2.0);
			int num2 = (int)Math.Round((double)clientRectangle.Height / 2.0);
			FormBoundsColors formBoundsColors = GetFormBoundsColors();
			DrawPath(clientRectangle, e.Graphics, formBoundsColors.TopLeftColor);
			Rectangle rectForm = new Rectangle(clientRectangle.Right - num, clientRectangle.Y, num, num2);
			DrawPath(rectForm, e.Graphics, formBoundsColors.TopRightColor);
			Rectangle rectForm2 = new Rectangle(clientRectangle.X, clientRectangle.Bottom - num2, num, num2);
			DrawPath(rectForm2, e.Graphics, formBoundsColors.BottomLeftColor);
			Rectangle rectForm3 = new Rectangle(clientRectangle.Right - num, clientRectangle.Bottom - num2, num, num2);
			DrawPath(rectForm3, e.Graphics, formBoundsColors.BottomRightColor);
			FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
		}
	}

	private void Panel2_Paint(object sender, PaintEventArgs e)
	{
		ControlRegionAndBorder(Panel2, (float)borderRadius - (float)borderSize / 2f, e.Graphics, borderColor);
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		base.TopMost = true;
		BringToFront();
	}
}
