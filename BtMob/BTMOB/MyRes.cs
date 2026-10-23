using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace BTMOB;

[StandardModule]
internal sealed class MyRes
{
	public static readonly string Resources_Path = Application.StartupPath + EXGuarder._37572816;

	public static readonly string Flags_Path = Application.StartupPath + EXGuarder._62534F4D;

	public static readonly string Fonts_Path = Application.StartupPath + EXGuarder._7433524B;

	public static readonly string NotesDirectory = Application.StartupPath + EXGuarder._4D141B2E;

	public static readonly string USERS_Path = Application.StartupPath + EXGuarder._011A7133;

	public static readonly string TAGS_path = Application.StartupPath + EXGuarder._1A1C5C39;

	public static readonly string USERS_cache_Path = Application.StartupPath + EXGuarder._42734A13;

	public static readonly string injections_Zip = Application.StartupPath + EXGuarder._2114270B;

	public static readonly string injections_Path = Application.StartupPath + EXGuarder._124A230F;

	public static readonly string BTCache_path = Application.StartupPath + EXGuarder._06353160;

	public static readonly string BTKeys_path = Application.StartupPath + EXGuarder._744B6D68;

	public static readonly string Sounds_Path = Application.StartupPath + EXGuarder._140A2D0A;

	public static readonly string Apps_Path = Application.StartupPath + EXGuarder._5039052E;

	public static readonly string GEOIP_Path = Application.StartupPath + EXGuarder._1F157325;

	public static readonly string GEOIP_Citys_Path = Application.StartupPath + EXGuarder._463A1361;

	public static readonly string SupportedImages = EXGuarder._5D1F4C73;

	public static readonly string SupportedVideo = EXGuarder._2E0B493B;

	public static readonly string tools_Path = Application.StartupPath + EXGuarder._280E1510;

	public static readonly string appt_Path = Application.StartupPath + EXGuarder._522B3721;

	public static readonly string adb_Path = Application.StartupPath + EXGuarder._6C63363D;

	public static readonly string adb_lib1 = Application.StartupPath + EXGuarder._682D3B14;

	public static readonly string adb_libusb = Application.StartupPath + EXGuarder._23003B58;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Bitmap GetScreen(string C)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Bitmap GetBattery(string Changestate)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	public static Bitmap GetWallpaper(string imgBase64, int xx, int yy)
	{
		string imagebase = EXGuarder._551B1F35;
		if ((Operators.CompareString(imgBase64, EXGuarder._3E11682C, TextCompare: false) != 0) | (Operators.CompareString(imgBase64, EXGuarder._08685B23, TextCompare: false) == 0))
		{
			imagebase = imgBase64;
		}
		return FormatImg(imagebase, xx, yy);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Bitmap FormatImg(string imagebase64, int xx, int yy)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Image CropImageToCircle(Image inputImage, Size size)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Image ApplyRoundedCorners(Image inputImage, int cornerRadius)
	{
		if (inputImage == null)
			return null;
		Bitmap bitmap = new Bitmap(inputImage.Width, inputImage.Height);
		using (Graphics graphics = Graphics.FromImage(bitmap))
		using (GraphicsPath path = GetRoundedRectPath(new Rectangle(0, 0, bitmap.Width, bitmap.Height), cornerRadius))
		{
			graphics.SmoothingMode = SmoothingMode.AntiAlias;
			graphics.SetClip(path);
			graphics.DrawImage(inputImage, 0, 0, bitmap.Width, bitmap.Height);
		}
		return bitmap;
	}

	private static GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
	{
		GraphicsPath path = new GraphicsPath();
		int diameter = Math.Max(0, radius) * 2;
		if (diameter <= 0 || diameter > rect.Width || diameter > rect.Height)
		{
			path.AddRectangle(rect);
			return path;
		}
		path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
		path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
		path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
		path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
		path.CloseFigure();
		return path;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Bitmap NetworkType(string value)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string CreateCilentfolder(BTClient ClassClient)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool ISupportedImages(string t)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool ISupportedVideo(string t)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsIconCached(string app_id)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Bitmap GetCachedIcon(string app_id)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void CacheIcon(string app_id, Bitmap icon)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}
}
