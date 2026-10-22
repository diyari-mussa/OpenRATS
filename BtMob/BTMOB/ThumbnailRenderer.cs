using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using BrightIdeasSoftware;

namespace BTMOB;

public class ThumbnailRenderer : BaseRenderer
{
	private static readonly StringFormat _stringFormat = new StringFormat(StringFormatFlags.NoWrap)
	{
		Alignment = StringAlignment.Center,
		LineAlignment = StringAlignment.Near,
		Trimming = StringTrimming.EllipsisCharacter
	};

	private static readonly Dictionary<Image, Image> _thumbCache = new Dictionary<Image, Image>();

	private static readonly Dictionary<Size, GraphicsPath> _pathCache = new Dictionary<Size, GraphicsPath>();

	private static SolidBrush _backBrush = null;

	private static Pen _borderPen = null;

	public Size ThumbSize { get; set; }

	public int CornerRadius { get; set; }

	public Color TileBackColor { get; set; }

	public Color TileSelectedBorderColor { get; set; }

	public ThumbnailRenderer()
	{
		ThumbSize = new Size(65, 65);
		CornerRadius = 8;
		TileBackColor = Color.FromArgb(14, 22, 33);
		TileSelectedBorderColor = Color.FromArgb(2, 176, 117);
	}

	public override bool OptionalRender(Graphics g, Rectangle bounds)
	{
		if (base.ListView == null || base.ListView.View != View.LargeIcon)
		{
			return false;
		}
		if (!(base.RowObject is filesmanager.FileRow fileRow))
		{
			return false;
		}
		if (base.ListView.Items.Count > 200)
		{
			g.SmoothingMode = SmoothingMode.None;
			g.InterpolationMode = InterpolationMode.Low;
		}
		else
		{
			g.SmoothingMode = SmoothingMode.AntiAlias;
			g.InterpolationMode = InterpolationMode.HighQualityBicubic;
		}
		if (_backBrush == null || _backBrush.Color != TileBackColor)
		{
			_backBrush = new SolidBrush(TileBackColor);
		}
		if (_borderPen == null || _borderPen.Color != TileSelectedBorderColor)
		{
			_borderPen = new Pen(TileSelectedBorderColor, 1.5f);
		}
		Rectangle rect = Rectangle.Inflate(bounds, -4, -4);
		using (GraphicsPath path = GetRoundedRect(rect))
		{
			g.FillPath(_backBrush, path);
			if (base.IsItemSelected)
			{
				g.DrawPath(_borderPen, path);
			}
		}
		int num = 6;
		checked
		{
			int num2 = Math.Min(ThumbSize.Width, rect.Width - num * 2);
			int height = Math.Min(ThumbSize.Height, rect.Height - num * 2 - 20);
			Rectangle rect2 = new Rectangle(rect.X + unchecked(checked(rect.Width - num2) / 2), rect.Y + num, num2, height);
			Rectangle rectangle = new Rectangle(rect.X + num, rect2.Bottom + 2, rect.Width - num * 2, rect.Bottom - (rect2.Bottom + 2 + num));
			Image thumbnail = GetThumbnail(fileRow.Icon);
			if (thumbnail != null)
			{
				g.DrawImage(thumbnail, rect2);
			}
			string text = (string.IsNullOrEmpty(fileRow.Name) ? GetText() : fileRow.Name);
			Color foreColor = ((base.TextBrush is SolidBrush) ? ((SolidBrush)base.TextBrush).Color : Color.White);
			TextRenderer.DrawText(g, text, base.Font, rectangle, foreColor, TextFormatFlags.EndEllipsis | TextFormatFlags.HorizontalCenter);
			return true;
		}
	}

	private Image GetThumbnail(Image img)
	{
		if (img == null)
		{
			return null;
		}
		if (!_thumbCache.ContainsKey(img))
		{
			Bitmap bitmap = new Bitmap(ThumbSize.Width, ThumbSize.Height);
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.InterpolationMode = InterpolationMode.Low;
				graphics.SmoothingMode = SmoothingMode.None;
				float num = Math.Min((float)bitmap.Width / (float)img.Width, (float)bitmap.Height / (float)img.Height);
				int num2;
				int num3;
				checked
				{
					num2 = (int)Math.Round((float)img.Width * num);
					num3 = (int)Math.Round((float)img.Height * num);
				}
				Rectangle rect = new Rectangle(checked(bitmap.Width - num2) / 2, checked(bitmap.Height - num3) / 2, num2, num3);
				graphics.DrawImage(img, rect);
			}
			_thumbCache[img] = bitmap;
		}
		return _thumbCache[img];
	}

	private GraphicsPath GetRoundedRect(Rectangle rect)
	{
		Size size = rect.Size;
		if (!_pathCache.ContainsKey(size))
		{
			_pathCache[size] = CreateRoundedRect(new Rectangle(Point.Empty, size), CornerRadius);
		}
		GraphicsPath graphicsPath = _pathCache[size];
		GraphicsPath graphicsPath2 = (GraphicsPath)graphicsPath.Clone();
		using (Matrix matrix = new Matrix())
		{
			matrix.Translate(rect.X, rect.Y);
			graphicsPath2.Transform(matrix);
		}
		return graphicsPath2;
	}

	private GraphicsPath CreateRoundedRect(Rectangle rect, int radius)
	{
		GraphicsPath graphicsPath = new GraphicsPath();
		checked
		{
			int num = radius * 2;
			Rectangle rect2 = new Rectangle(rect.Location, new Size(num, num));
			graphicsPath.AddArc(rect2, 180f, 90f);
			rect2.X = rect.Right - num;
			graphicsPath.AddArc(rect2, 270f, 90f);
			rect2.Y = rect.Bottom - num;
			graphicsPath.AddArc(rect2, 0f, 90f);
			rect2.X = rect.Left;
			graphicsPath.AddArc(rect2, 90f, 90f);
			graphicsPath.CloseFigure();
			return graphicsPath;
		}
	}
}
