using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat;

[DesignerGenerated]
public class Color_Box0 : Form
{
	private IContainer components;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("C_Box2")]
	[CompilerGenerated]
	private PictureBox _C_Box2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BTN_OK")]
	private Button _BTN_OK;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("C_Box0")]
	private PictureBox _C_Box0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ti")]
	private Timer _ti;

	[AccessedThroughProperty("CK1")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private CheckBox _CK1;

	[AccessedThroughProperty("BoxTitle")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private PictureBox _BoxTitle;

	private bool BoxTitlePaintEventArgsWait;

	public bool Programmatically;

	public Color default_color;

	public Color _new_color;

	private Bitmap Bmp;

	private Graphics G;

	private const int VK_LBUTTON = 1;

	private Point p1;

	private bool s_mouse1;

	private Point p0;

	private bool s_mouse0;

	private string TEXT_COLOR;

	[field: AccessedThroughProperty("C_Box3")]
	internal virtual PictureBox C_Box3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual PictureBox C_Box2
	{
		[CompilerGenerated]
		get
		{
			return _C_Box2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			PaintEventHandler value2 = C_Box2_Paint;
			MouseEventHandler value3 = C_Box2_MouseDown;
			MouseEventHandler value4 = C_Box2_MouseMove;
			MouseEventHandler value5 = C_Box2_MouseUp;
			EventHandler value6 = C_Box2_Click;
			PictureBox pictureBox = _C_Box2;
			if (pictureBox != null)
			{
				pictureBox.Paint -= value2;
				pictureBox.MouseDown -= value3;
				pictureBox.MouseMove -= value4;
				pictureBox.MouseUp -= value5;
				pictureBox.Click -= value6;
			}
			_C_Box2 = value;
			pictureBox = _C_Box2;
			if (pictureBox != null)
			{
				pictureBox.Paint += value2;
				pictureBox.MouseDown += value3;
				pictureBox.MouseMove += value4;
				pictureBox.MouseUp += value5;
				pictureBox.Click += value6;
			}
		}
	}

	internal virtual Button BTN_OK
	{
		[CompilerGenerated]
		get
		{
			return _BTN_OK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = BTN_OK_Click;
			Button button = _BTN_OK;
			if (button != null)
			{
				button.Click -= value2;
			}
			_BTN_OK = value;
			button = _BTN_OK;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual PictureBox C_Box0
	{
		[CompilerGenerated]
		get
		{
			return _C_Box0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			PaintEventHandler value2 = C_Box0_Paint;
			MouseEventHandler value3 = C_Box0_MouseDown;
			MouseEventHandler value4 = C_Box0_MouseMove;
			MouseEventHandler value5 = C_Box0_MouseUp;
			EventHandler value6 = C_Box0_Click;
			PictureBox pictureBox = _C_Box0;
			if (pictureBox != null)
			{
				pictureBox.Paint -= value2;
				pictureBox.MouseDown -= value3;
				pictureBox.MouseMove -= value4;
				pictureBox.MouseUp -= value5;
				pictureBox.Click -= value6;
			}
			_C_Box0 = value;
			pictureBox = _C_Box0;
			if (pictureBox != null)
			{
				pictureBox.Paint += value2;
				pictureBox.MouseDown += value3;
				pictureBox.MouseMove += value4;
				pictureBox.MouseUp += value5;
				pictureBox.Click += value6;
			}
		}
	}

	internal virtual Timer ti
	{
		[CompilerGenerated]
		get
		{
			return _ti;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ti_Tick;
			Timer timer = _ti;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_ti = value;
			timer = _ti;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	internal virtual CheckBox CK1
	{
		[CompilerGenerated]
		get
		{
			return _CK1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = CK1_MouseDown;
			MouseEventHandler value3 = CK1_MouseUp;
			CheckBox checkBox = _CK1;
			if (checkBox != null)
			{
				checkBox.MouseDown -= value2;
				checkBox.MouseUp -= value3;
			}
			_CK1 = value;
			checkBox = _CK1;
			if (checkBox != null)
			{
				checkBox.MouseDown += value2;
				checkBox.MouseUp += value3;
			}
		}
	}

	internal virtual PictureBox BoxTitle
	{
		[CompilerGenerated]
		get
		{
			return _BoxTitle;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = BoxTitle_Resize;
			PaintEventHandler value3 = BoxTitle_Paint;
			EventHandler value4 = BoxTitle_Click;
			PictureBox pictureBox = _BoxTitle;
			if (pictureBox != null)
			{
				pictureBox.Resize -= value2;
				pictureBox.Paint -= value3;
				pictureBox.Click -= value4;
			}
			_BoxTitle = value;
			pictureBox = _BoxTitle;
			if (pictureBox != null)
			{
				pictureBox.Resize += value2;
				pictureBox.Paint += value3;
				pictureBox.Click += value4;
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
		this.C_Box3 = new System.Windows.Forms.PictureBox();
		this.C_Box2 = new System.Windows.Forms.PictureBox();
		this.BTN_OK = new System.Windows.Forms.Button();
		this.C_Box0 = new System.Windows.Forms.PictureBox();
		this.ti = new System.Windows.Forms.Timer(this.components);
		this.CK1 = new System.Windows.Forms.CheckBox();
		this.BoxTitle = new System.Windows.Forms.PictureBox();
		((System.ComponentModel.ISupportInitialize)this.C_Box3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.C_Box2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.C_Box0).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.BoxTitle).BeginInit();
		base.SuspendLayout();
		this.C_Box3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.C_Box3.Location = new System.Drawing.Point(98, 117);
		this.C_Box3.Name = "C_Box3";
		this.C_Box3.Size = new System.Drawing.Size(50, 48);
		this.C_Box3.TabIndex = 7;
		this.C_Box3.TabStop = false;
		this.C_Box2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.C_Box2.Location = new System.Drawing.Point(3, 117);
		this.C_Box2.Name = "C_Box2";
		this.C_Box2.Size = new System.Drawing.Size(93, 19);
		this.C_Box2.TabIndex = 6;
		this.C_Box2.TabStop = false;
		this.BTN_OK.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.BTN_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BTN_OK.ForeColor = System.Drawing.Color.Black;
		this.BTN_OK.Location = new System.Drawing.Point(3, 142);
		this.BTN_OK.Name = "BTN_OK";
		this.BTN_OK.Size = new System.Drawing.Size(93, 23);
		this.BTN_OK.TabIndex = 5;
		this.BTN_OK.Text = "OK";
		this.BTN_OK.UseVisualStyleBackColor = false;
		this.C_Box0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.C_Box0.Location = new System.Drawing.Point(3, 3);
		this.C_Box0.Name = "C_Box0";
		this.C_Box0.Size = new System.Drawing.Size(145, 86);
		this.C_Box0.TabIndex = 4;
		this.C_Box0.TabStop = false;
		this.CK1.AutoSize = true;
		this.CK1.Location = new System.Drawing.Point(3, 94);
		this.CK1.Name = "CK1";
		this.CK1.Size = new System.Drawing.Size(93, 17);
		this.CK1.TabIndex = 8;
		this.CK1.Tag = "";
		this.CK1.Text = "Color Dropper";
		this.CK1.UseVisualStyleBackColor = true;
		this.BoxTitle.BackColor = System.Drawing.Color.Black;
		this.BoxTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.BoxTitle.ErrorImage = null;
		this.BoxTitle.InitialImage = null;
		this.BoxTitle.Location = new System.Drawing.Point(0, 169);
		this.BoxTitle.Name = "BoxTitle";
		this.BoxTitle.Size = new System.Drawing.Size(151, 18);
		this.BoxTitle.TabIndex = 9;
		this.BoxTitle.TabStop = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(151, 187);
		base.Controls.Add(this.BoxTitle);
		base.Controls.Add(this.CK1);
		base.Controls.Add(this.C_Box3);
		base.Controls.Add(this.C_Box2);
		base.Controls.Add(this.BTN_OK);
		base.Controls.Add(this.C_Box0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "Color_Box0";
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Color Box";
		((System.ComponentModel.ISupportInitialize)this.C_Box3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.C_Box2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.C_Box0).EndInit();
		((System.ComponentModel.ISupportInitialize)this.BoxTitle).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void SpyStyle()
	{
		BoxTitle.BackColor = SpySettings.DefaultColor_Background;
		BackColor = SpySettings.DefaultColor_Background;
		foreach (Button item in base.Controls.OfType<Button>())
		{
			item.BackColor = SpySettings.DefaultColor_Foreground;
			item.ForeColor = SpySettings.DefaultColor_Background;
		}
		foreach (CheckBox item2 in base.Controls.OfType<CheckBox>())
		{
			item2.BackColor = SpySettings.DefaultColor_Background;
			item2.ForeColor = SpySettings.DefaultColor_Foreground;
		}
	}

	public Color_Box0()
	{
		base.Load += Color_Box0_Load;
		base.Activated += Color_Box0_Activated;
		base.Deactivate += Color_Box0_Deactivate;
		BoxTitlePaintEventArgsWait = false;
		Programmatically = false;
		default_color = Color.Yellow;
		_new_color = Color.Yellow;
		p1 = new Point(0, 0);
		s_mouse1 = false;
		p0 = default(Point);
		s_mouse0 = false;
		TEXT_COLOR = "null";
		InitializeComponent();
		Font = reso.f;
	}

	private void Color_Box0_Load(object sender, EventArgs e)
	{
		SpyStyle();
		BTN_OK.Font = reso.f;
		base.TopMost = true;
		Programmatically = true;
		Bmp = new Bitmap(1, 1);
		G = Graphics.FromImage(Bmp);
		if (clrSAVE.po1 == default(Point))
		{
			p0 = new Point(1, 1);
		}
		else
		{
			p0 = clrSAVE.po1;
		}
		object[] e2 = new object[2] { p0.X, p0.Y };
		_Update0(e2, C_Box2);
		C_Box2.Invalidate();
		if (clrSAVE.po2 == default(Point))
		{
			p1 = new Point(1, 1);
		}
		else
		{
			p1 = clrSAVE.po2;
		}
		object[] e3 = new object[2] { p1.X, p1.Y };
		_Update1(e3, C_Box0);
		C_Box0.Invalidate();
		Programmatically = false;
		BoxTitlePaintEventArgsWait = true;
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetKeyState(long nVirtKey);

	private void C_Box0_Paint(object sender, PaintEventArgs e)
	{
		Graphics graphics = e.Graphics;
		Graphics graphics2 = graphics;
		Rectangle rect = new Rectangle(0, 0, C_Box0.Width, C_Box0.Height);
		using (LinearGradientBrush brush = new LinearGradientBrush(rect, Color.White, default_color, LinearGradientMode.Horizontal))
		{
			graphics2.FillRectangle(brush, rect);
		}
		Rectangle rect2 = new Rectangle(0, 0, C_Box0.Width, C_Box0.Height);
		checked
		{
			using (LinearGradientBrush brush2 = new LinearGradientBrush(rect2, Color.Transparent, Color.Black, LinearGradientMode.Vertical))
			{
				graphics2.FillRectangle(brush2, rect2);
				int num = C_Box0.Height - 7;
				graphics2.DrawLine(new Pen(Color.Black, 5f), 0, num, C_Box0.Width, num);
			}
			graphics2 = null;
			if (!(p1 == default(Point)))
			{
				e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
				Rectangle rect3 = ((!s_mouse1) ? new Rectangle(p1.X - 5, p1.Y - 5, 10, 10) : new Rectangle(p1.X - 7, p1.Y - 7, 14, 14));
				Pen pen = new Pen(Color.Black, 1f);
				if ((int)Math.Round((double)C_Box0.Height / 2.0) < p1.Y)
				{
					pen = new Pen(Color.White, 1f);
				}
				e.Graphics.DrawEllipse(pen, rect3);
				Bitmap bitmap = new Bitmap(C_Box0.ClientSize.Width, C_Box0.Height);
				C_Box0.DrawToBitmap(bitmap, C_Box0.ClientRectangle);
				if ((bitmap.Width > p1.X) & (bitmap.Height > p1.Y))
				{
					Color pixel = bitmap.GetPixel(p1.X, p1.Y);
					bitmap.Dispose();
					_new_color = pixel;
				}
			}
			C_Box3.BackColor = _new_color;
			Title(new object[3]
			{
				C_Box3.BackColor.R,
				C_Box3.BackColor.G,
				C_Box3.BackColor.B
			});
			C_Box3.Refresh();
		}
	}

	private void C_Box0_MouseDown(object sender, MouseEventArgs e)
	{
		s_mouse1 = true;
		object[] e2 = new object[2] { e.X, e.Y };
		_Update1(e2, C_Box0);
	}

	private void _Update1(object[] e, Control c)
	{
		if ((s_mouse1 | Programmatically) && Conversions.ToBoolean(Operators.AndObject(checked(Operators.AndObject(Operators.AndObject(Operators.NotObject(Operators.CompareObjectGreater(e[0], c.Width - 7, TextCompare: false)), Operators.NotObject(Operators.CompareObjectLess(e[0], 1, TextCompare: false))), Operators.NotObject(Operators.CompareObjectGreater(e[1], c.Height - 7, TextCompare: false)))), Operators.NotObject(Operators.CompareObjectLess(e[1], 1, TextCompare: false)))))
		{
			p1.X = Conversions.ToInteger(e[0]);
			p1.Y = Conversions.ToInteger(e[1]);
			clrSAVE.po2 = new Point(p1.X, p1.Y);
			Bitmap bitmap = new Bitmap(c.ClientSize.Width, c.Height);
			c.DrawToBitmap(bitmap, c.ClientRectangle);
			if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreater(bitmap.Width, e[0], TextCompare: false), Operators.CompareObjectGreater(bitmap.Height, e[1], TextCompare: false))))
			{
				Color pixel = bitmap.GetPixel(Conversions.ToInteger(e[0]), Conversions.ToInteger(e[1]));
				bitmap.Dispose();
				_new_color = pixel;
				c.Refresh();
			}
			c.Invalidate();
		}
	}

	private void C_Box0_MouseMove(object sender, MouseEventArgs e)
	{
		if (s_mouse1)
		{
			if (Operators.ConditionalCompareObjectEqual(C_Box0.Tag, null, TextCompare: false))
			{
				Cursor.Clip = C_Box0.RectangleToScreen(checked(new Rectangle(1, 1, C_Box0.Width - 7, C_Box0.Height - 7)));
				C_Box0.Tag = true;
			}
			object[] e2 = new object[2] { e.X, e.Y };
			_Update1(e2, C_Box0);
		}
	}

	private void C_Box0_MouseUp(object sender, MouseEventArgs e)
	{
		s_mouse1 = false;
		Cursor.Clip = default(Rectangle);
		C_Box0.Tag = null;
		C_Box0.Invalidate();
	}

	private void C_Box2_Paint(object sender, PaintEventArgs e)
	{
		using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(new Rectangle(new Point(0, 0), C_Box2.ClientSize), Color.Red, Color.Blue, 0f))
		{
			linearGradientBrush.InterpolationColors = new ColorBlend
			{
				Positions = new float[7] { 0f, 0.1f, 0.284f, 0.5f, 0.668f, 0.9f, 1f },
				Colors = new Color[7]
				{
					Color.Purple,
					Color.SkyBlue,
					Color.Yellow,
					Color.SkyBlue,
					Color.Cyan,
					Color.Blue,
					Color.LightBlue
				}
			};
			e.Graphics.FillRectangle(linearGradientBrush, C_Box2.ClientRectangle);
		}
		if (!(p0 == default(Point)))
		{
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			Rectangle rect = checked(new Rectangle(p0.X - 3, -1, 5, C_Box2.Height - 3));
			Pen pen = new Pen(Color.Black, 1f);
			e.Graphics.DrawRectangle(pen, rect);
		}
	}

	private void C_Box2_MouseDown(object sender, MouseEventArgs e)
	{
		s_mouse0 = true;
		object[] e2 = new object[2] { e.X, e.Y };
		_Update0(e2, C_Box2);
	}

	private void _Update0(object[] e, Control c)
	{
		if ((s_mouse0 | Programmatically) && Conversions.ToBoolean(Operators.AndObject(checked(Operators.AndObject(Operators.AndObject(Operators.NotObject(Operators.CompareObjectGreater(e[0], c.Width - 7, TextCompare: false)), Operators.NotObject(Operators.CompareObjectLess(e[0], 1, TextCompare: false))), Operators.NotObject(Operators.CompareObjectGreater(e[1], c.Height - 7, TextCompare: false)))), Operators.NotObject(Operators.CompareObjectLess(e[1], 1, TextCompare: false)))))
		{
			p0.X = Conversions.ToInteger(e[0]);
			p0.Y = Conversions.ToInteger(e[1]);
			clrSAVE.po1 = new Point(p0.X, p0.Y);
			Bitmap bitmap = new Bitmap(c.ClientSize.Width, c.Height);
			c.DrawToBitmap(bitmap, c.ClientRectangle);
			if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreater(bitmap.Width, e[0], TextCompare: false), Operators.CompareObjectGreater(bitmap.Height, e[1], TextCompare: false))))
			{
				Color pixel = bitmap.GetPixel(Conversions.ToInteger(e[0]), Conversions.ToInteger(e[1]));
				bitmap.Dispose();
				default_color = pixel;
				C_Box0.Invalidate();
			}
			c.Invalidate();
		}
	}

	private void C_Box2_MouseMove(object sender, MouseEventArgs e)
	{
		if (s_mouse0)
		{
			if (Operators.ConditionalCompareObjectEqual(C_Box2.Tag, null, TextCompare: false))
			{
				Cursor.Clip = C_Box2.RectangleToScreen(checked(new Rectangle(1, 1, C_Box2.Width - 7, C_Box2.Height - 7)));
				C_Box2.Tag = true;
			}
			object[] e2 = new object[2] { e.X, e.Y };
			_Update0(e2, C_Box2);
		}
	}

	private void C_Box2_MouseUp(object sender, MouseEventArgs e)
	{
		s_mouse0 = false;
		Cursor.Clip = default(Rectangle);
		C_Box2.Tag = null;
	}

	private void ti_Tick(object sender, EventArgs e)
	{
		try
		{
			G.CopyFromScreen(new Point((Size)Cursor.Position), Point.Empty, Bmp.Size);
			C_Box3.BackColor = Color.FromArgb(Bmp.GetPixel(0, 0).R, Bmp.GetPixel(0, 0).G, Bmp.GetPixel(0, 0).B);
			Title(new object[3]
			{
				C_Box3.BackColor.R,
				C_Box3.BackColor.G,
				C_Box3.BackColor.B
			});
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Title(object[] obj)
	{
		TEXT_COLOR = $"RGB:({RuntimeHelpers.GetObjectValue(obj[0])},{RuntimeHelpers.GetObjectValue(obj[1])},{RuntimeHelpers.GetObjectValue(obj[2])})";
		BoxTitle.Refresh();
	}

	private void CK1_MouseDown(object sender, MouseEventArgs e)
	{
		ti.Enabled = true;
		CK1.Checked = true;
	}

	private void CK1_MouseUp(object sender, MouseEventArgs e)
	{
		ti.Enabled = false;
		CK1.Checked = false;
	}

	private void BTN_OK_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.OK;
	}

	private void Color_Box0_Activated(object sender, EventArgs e)
	{
		BoxTitle.Invalidate();
	}

	private void Color_Box0_Deactivate(object sender, EventArgs e)
	{
		BoxTitle.Invalidate();
	}

	private void BoxTitle_Resize(object sender, EventArgs e)
	{
		BoxTitle.Invalidate();
	}

	private void C_Box0_Click(object sender, EventArgs e)
	{
	}

	private void BoxTitle_Paint(object sender, PaintEventArgs e)
	{
		checked
		{
			if (BoxTitlePaintEventArgsWait)
			{
				string tEXT_COLOR = TEXT_COLOR;
				Color defaultColor_Foreground = SpySettings.DefaultColor_Foreground;
				e.Graphics.DrawLine(new Pen(Color.FromArgb(50, defaultColor_Foreground.R, defaultColor_Foreground.G, defaultColor_Foreground.B)), 0, 1, BoxTitle.Width, 1);
				Brush brush = new SolidBrush(SpySettings.DefaultColor_Foreground);
				Brush brush2 = new SolidBrush(Color.FromArgb(170, BoxTitle.BackColor.R, BoxTitle.BackColor.G, BoxTitle.BackColor.B));
				Size size = TextRenderer.MeasureText(tEXT_COLOR, reso.f);
				Rectangle rect = new Rectangle(0, 2, BoxTitle.Width, size.Height + 5);
				e.Graphics.FillRectangle(new Pen(brush2).Brush, rect);
				e.Graphics.DrawString(tEXT_COLOR, reso.f, brush, 0f, 2f);
				Size size2 = TextRenderer.MeasureText("S", reso.f);
				if (BoxTitle.Height != size2.Height + 3)
				{
					BoxTitle.Height = size2.Height + 3;
				}
			}
		}
	}

	private void BoxTitle_Click(object sender, EventArgs e)
	{
	}

	private void C_Box2_Click(object sender, EventArgs e)
	{
	}
}
