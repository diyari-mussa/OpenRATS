using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace BTMOB;

public class ResizeableControl
{
	[Flags]
	public enum EdgeEnum
	{
		None = 0,
		Right = 1,
		Left = 2,
		Top = 4,
		Bottom = 8,
		TopLeft = 6,
		TopRight = 5,
		BottomLeft = 0xA,
		BottomRight = 9
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("mControl")]
	private Control _mControl;

	private bool mMouseDown;

	private EdgeEnum mEdge;

	private const int mWidth = 6;

	private Point mStartPoint;

	protected virtual Control mControl
	{
		[CompilerGenerated]
		get
		{
			return _mControl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = mControl_MouseDown;
			MouseEventHandler value3 = mControl_MouseUp;
			MouseEventHandler value4 = mControl_MouseMove;
			PaintEventHandler value5 = mControl_Paint;
			EventHandler value6 = mControl_MouseLeave;
			Control control = _mControl;
			if (control != null)
			{
				control.MouseDown -= value2;
				control.MouseUp -= value3;
				control.MouseMove -= value4;
				control.Paint -= value5;
				control.MouseLeave -= value6;
			}
			_mControl = value;
			control = _mControl;
			if (control != null)
			{
				control.MouseDown += value2;
				control.MouseUp += value3;
				control.MouseMove += value4;
				control.Paint += value5;
				control.MouseLeave += value6;
			}
		}
	}

	public EdgeEnum AllowedEdge { get; set; }

	public ResizeableControl(Control ctrl)
	{
		mMouseDown = false;
		mEdge = EdgeEnum.None;
		AllowedEdge = EdgeEnum.None;
		mControl = ctrl;
	}

	private void mControl_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left && mEdge != EdgeEnum.None)
		{
			mMouseDown = true;
			mStartPoint = e.Location;
		}
	}

	private void mControl_MouseUp(object sender, MouseEventArgs e)
	{
		mMouseDown = false;
	}

	private void mControl_MouseMove(object sender, MouseEventArgs e)
	{
		Control control = mControl;
		if (mMouseDown)
		{
			ResizeControl(e);
		}
		else
		{
			UpdateEdgeAndCursor(e);
		}
	}

	private void UpdateEdgeAndCursor(MouseEventArgs e)
	{
		Control control = mControl;
		EdgeEnum edgeEnum = EdgeEnum.None;
		bool flag = e.X <= 6;
		bool flag2;
		bool flag3;
		bool flag4;
		checked
		{
			flag2 = e.X >= control.Width - 6;
			flag3 = e.Y <= 6;
			flag4 = e.Y >= control.Height - 6;
		}
		if (flag3 && flag && AllowedEdge.HasFlag(EdgeEnum.TopLeft))
		{
			edgeEnum = EdgeEnum.TopLeft;
			control.Cursor = Cursors.SizeNWSE;
		}
		else if (flag3 && flag2 && AllowedEdge.HasFlag(EdgeEnum.TopRight))
		{
			edgeEnum = EdgeEnum.TopRight;
			control.Cursor = Cursors.SizeNESW;
		}
		else if (flag4 && flag && AllowedEdge.HasFlag(EdgeEnum.BottomLeft))
		{
			edgeEnum = EdgeEnum.BottomLeft;
			control.Cursor = Cursors.SizeNESW;
		}
		else if (flag4 && flag2 && AllowedEdge.HasFlag(EdgeEnum.BottomRight))
		{
			edgeEnum = EdgeEnum.BottomRight;
			control.Cursor = Cursors.SizeNWSE;
		}
		else if (flag && AllowedEdge.HasFlag(EdgeEnum.Left))
		{
			edgeEnum = EdgeEnum.Left;
			control.Cursor = Cursors.SizeWE;
		}
		else if (flag2 && AllowedEdge.HasFlag(EdgeEnum.Right))
		{
			edgeEnum = EdgeEnum.Right;
			control.Cursor = Cursors.SizeWE;
		}
		else if (flag3 && AllowedEdge.HasFlag(EdgeEnum.Top))
		{
			edgeEnum = EdgeEnum.Top;
			control.Cursor = Cursors.SizeNS;
		}
		else if (flag4 && AllowedEdge.HasFlag(EdgeEnum.Bottom))
		{
			edgeEnum = EdgeEnum.Bottom;
			control.Cursor = Cursors.SizeNS;
		}
		else
		{
			control.Cursor = Cursors.Default;
		}
		mEdge = edgeEnum;
		control.Invalidate();
	}

	private void ResizeControl(MouseEventArgs e)
	{
		Control control = mControl;
		int num = control.Left;
		int num2 = control.Top;
		int num3 = control.Width;
		int num4 = control.Height;
		checked
		{
			int num5 = e.X - mStartPoint.X;
			int num6 = e.Y - mStartPoint.Y;
			if (mEdge.HasFlag(EdgeEnum.Right))
			{
				num3 += num5;
			}
			if (mEdge.HasFlag(EdgeEnum.Left))
			{
				num += num5;
				num3 -= num5;
			}
			if (mEdge.HasFlag(EdgeEnum.Bottom))
			{
				num4 += num6;
			}
			if (mEdge.HasFlag(EdgeEnum.Top))
			{
				num2 += num6;
				num4 -= num6;
			}
			if (num3 < 50)
			{
				num3 = 50;
			}
			if (num4 < 50)
			{
				num4 = 50;
			}
			control.SetBounds(num, num2, num3, num4);
		}
	}

	private void mControl_Paint(object sender, PaintEventArgs e)
	{
		checked
		{
			if (mEdge != EdgeEnum.None)
			{
				Control control = mControl;
				Graphics graphics = e.Graphics;
				Brush royalBlue = Brushes.RoyalBlue;
				switch (mEdge)
				{
				case EdgeEnum.Top:
					graphics.FillRectangle(royalBlue, 0, 0, control.Width, 6);
					break;
				case EdgeEnum.Bottom:
					graphics.FillRectangle(royalBlue, 0, control.Height - 6, control.Width, 6);
					break;
				case EdgeEnum.Left:
					graphics.FillRectangle(royalBlue, 0, 0, 6, control.Height);
					break;
				case EdgeEnum.Right:
					graphics.FillRectangle(royalBlue, control.Width - 6, 0, 6, control.Height);
					break;
				}
			}
		}
	}

	private void mControl_MouseLeave(object sender, EventArgs e)
	{
		mEdge = EdgeEnum.None;
		mControl.Cursor = Cursors.Default;
		mControl.Invalidate();
	}
}
