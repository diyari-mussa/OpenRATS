using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BTMOB;

public class BTtabcontrol : TabControl
{
	private struct NMHDR
	{
		public int HWND;

		public int idFrom;

		public int code;

		public new string ToString()
		{
			return $"Hwnd: {HWND}, ControlID: {idFrom}, Code: {code}";
		}
	}

	private IContainer components;

	private const int TCN_FIRST = -550;

	private const int TCN_SELCHANGING = -552;

	private const int WM_USER = 1024;

	private const int WM_NOTIFY = 78;

	private const int WM_REFLECT = 8192;

	private Color m_Backcolor;

	[Browsable(true)]
	[Description("The background color used to display text and graphics in a control.")]
	public override Color BackColor
	{
		get
		{
			if (m_Backcolor.Equals(Color.Empty))
			{
				if (base.Parent == null)
				{
					return Control.DefaultBackColor;
				}
				return base.Parent.BackColor;
			}
			return m_Backcolor;
		}
		set
		{
			if (!m_Backcolor.Equals(value))
			{
				m_Backcolor = value;
				Invalidate();
				base.OnBackColorChanged(EventArgs.Empty);
			}
		}
	}

	[Description("Occurs as a tab is being changed.")]
	public event SelectedTabPageChangeEventHandler SelectedIndexChanging;

	public BTtabcontrol()
	{
		m_Backcolor = Color.Empty;
		InitializeComponent();
		SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, value: true);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	[System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.components = new System.ComponentModel.Container();
	}

	public bool ShouldSerializeBackColor()
	{
		return !m_Backcolor.Equals(Color.Empty);
	}

	public override void ResetBackColor()
	{
		m_Backcolor = Color.Empty;
		Invalidate();
	}

	protected override void OnParentBackColorChanged(EventArgs e)
	{
		base.OnParentBackColorChanged(e);
		Invalidate();
	}

	protected override void OnSelectedIndexChanged(EventArgs e)
	{
		base.OnSelectedIndexChanged(e);
		Invalidate();
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		base.OnPaint(e);
		e.Graphics.Clear(BackColor);
		Rectangle clientRectangle = base.ClientRectangle;
		if (base.TabCount <= 0)
		{
			return;
		}
		clientRectangle = base.SelectedTab.Bounds;
		StringFormat stringFormat = new StringFormat();
		stringFormat.Alignment = StringAlignment.Center;
		stringFormat.LineAlignment = StringAlignment.Center;
		Font font = new Font(Font.FontFamily, 24f, FontStyle.Regular, GraphicsUnit.Pixel);
		ControlPaint.DrawStringDisabled(e.Graphics, EXGuarder._5428563A, font, BackColor, clientRectangle, stringFormat);
		font.Dispose();
		clientRectangle.Inflate(3, 3);
		TabPage tabPage = base.TabPages[base.SelectedIndex];
		SolidBrush solidBrush = new SolidBrush(tabPage.BackColor);
		e.Graphics.FillRectangle(solidBrush, clientRectangle);
		ControlPaint.DrawBorder(e.Graphics, clientRectangle, solidBrush.Color, ButtonBorderStyle.Outset);
		checked
		{
			int num = base.TabCount - 1;
			for (int i = 0; i <= num; i++)
			{
				tabPage = base.TabPages[i];
				clientRectangle = GetTabRect(i);
				ButtonBorderStyle style = ButtonBorderStyle.Outset;
				if (i == base.SelectedIndex)
				{
					style = ButtonBorderStyle.Inset;
				}
				solidBrush.Color = tabPage.BackColor;
				e.Graphics.FillRectangle(solidBrush, clientRectangle);
				ControlPaint.DrawBorder(e.Graphics, clientRectangle, solidBrush.Color, style);
				solidBrush.Color = tabPage.ForeColor;
				if ((base.Alignment == TabAlignment.Left) | (base.Alignment == TabAlignment.Right))
				{
					float angle = 90f;
					if (base.Alignment == TabAlignment.Left)
					{
						angle = 270f;
					}
					PointF pointF = new PointF(clientRectangle.Left + unchecked(clientRectangle.Width / 2), clientRectangle.Top + unchecked(clientRectangle.Height / 2));
					e.Graphics.TranslateTransform(pointF.X, pointF.Y);
					e.Graphics.RotateTransform(angle);
					clientRectangle = new Rectangle(-unchecked(clientRectangle.Height / 2), -unchecked(clientRectangle.Width / 2), clientRectangle.Height, clientRectangle.Width);
				}
				if (tabPage.Enabled)
				{
					e.Graphics.DrawString(tabPage.Text, Font, solidBrush, clientRectangle, stringFormat);
				}
				else
				{
					ControlPaint.DrawStringDisabled(e.Graphics, tabPage.Text, Font, tabPage.BackColor, clientRectangle, stringFormat);
				}
				e.Graphics.ResetTransform();
			}
			solidBrush.Dispose();
		}
	}

	protected override void WndProc(ref Message m)
	{
		if (m.Msg == 8270 && ((NMHDR)Marshal.PtrToStructure(m.LParam, typeof(NMHDR))).code == -552)
		{
			TabPage tabPage = TestTab(PointToClient(Cursor.Position));
			if (tabPage != null)
			{
				TabPageChangeEventArgs e = new TabPageChangeEventArgs(base.SelectedTab, tabPage);
				SelectedIndexChanging?.Invoke(this, e);
				if (e.Cancel || !tabPage.Enabled)
				{
					m.Result = new IntPtr(1);
					return;
				}
			}
		}
		base.WndProc(ref m);
	}

	private TabPage TestTab(Point pt)
	{
		checked
		{
			int num = base.TabCount - 1;
			for (int i = 0; i <= num; i++)
			{
				if (GetTabRect(i).Contains(pt.X, pt.Y))
				{
					return base.TabPages[i];
				}
			}
			return null;
		}
	}
}
