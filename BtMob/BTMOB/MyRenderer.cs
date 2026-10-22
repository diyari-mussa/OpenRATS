using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BTMOB;

public class MyRenderer : ToolStripProfessionalRenderer
{
	protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
	{
	}

	protected override void OnRenderImageMargin(ToolStripRenderEventArgs e)
	{
		e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(14, 22, 33)), e.AffectedBounds);
	}

	protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
	{
	}

	protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
	{
		e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(14, 22, 33)), e.ToolStrip.ClientRectangle);
	}

	protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
	{
		Rectangle rect = new Rectangle(Point.Empty, e.Item.Size);
		if (e.Item.Selected)
		{
			e.Graphics.FillRectangle(new SolidBrush(Color.DarkSlateGray), rect);
		}
		else
		{
			e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(14, 22, 33)), rect);
		}
	}

	protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
	{
		if (e.Item.Selected)
		{
			e.TextColor = Color.FromArgb(38, 216, 167);
		}
		else
		{
			e.TextColor = Color.White;
		}
		base.OnRenderItemText(e);
	}

	protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
	{
		Color color = ((!e.Item.Selected) ? Color.White : Color.FromArgb(38, 216, 167));
		checked
		{
			using SolidBrush brush = new SolidBrush(color);
			int num = e.ArrowRectangle.Top + unchecked(e.ArrowRectangle.Height / 2);
			Point[] points = new Point[3]
			{
				new Point(e.ArrowRectangle.Left, num - 4),
				new Point(e.ArrowRectangle.Left, num + 4),
				new Point(e.ArrowRectangle.Right, num)
			};
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			e.Graphics.FillPolygon(brush, points);
		}
	}
}
