using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace BTMOB;

[StandardModule]
internal sealed class Nativz
{
	private struct SHFILEINFO
	{
		public IntPtr hIcon;

		public int iIcon;

		public int dwAttributes;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string szDisplayName;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
		public string szTypeName;
	}

	public enum IconSize
	{
		SHGFI_LARGEICON,
		SHGFI_SMALLICON
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct SHFILEINFOW
	{
		public IntPtr hIcon;

		public int iIcon;

		public int dwAttributes;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string szDisplayName;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
		public string szTypeName;
	}

	private const int WM_VSCROLL = 277;

	private const int SB_PAGEBOTTOM = 7;

	public const int WM_NCLBUTTONDOWN = 161;

	public const int HT_CAPTION = 2;

	private const int MAX_PATH = 260;

	private const int SHGFI_ICON = 256;

	private const int SHGFI_USEFILEATTRIBUTES = 16;

	private const int FILE_ATTRIBUTE_NORMAL = 128;

	private const int SHGFI_LARGEICON = 0;

	private const int SHGFI_SMALLICON = 1;

	private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);

	private const uint SWP_NOSIZE = 1u;

	private const uint SWP_NOMOVE = 2u;

	public const uint TOPMOST_FLAGS = 3u;

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);

	internal static void ScrollToBottom(RichTextBox richTextBox)
	{
		SendMessage(richTextBox.Handle, 277, (IntPtr)7, IntPtr.Zero);
		richTextBox.SelectionStart = richTextBox.Text.Length;
	}

	[DllImport("user32.dll")]
	public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

	[DllImport("user32.dll")]
	public static extern bool ReleaseCapture();

	[DllImport("shell32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr SHGetFileInfo(string pszPath, int dwFileAttributes, ref SHFILEINFO psfi, int cbFileInfo, int uFlags);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern bool DestroyIcon(IntPtr hIcon);

	public static Bitmap GetFileIcon(string fileExt)
	{
		SHFILEINFO psfi = default(SHFILEINFO);
		int uFlags = 272;
		SHGetFileInfo(fileExt, 128, ref psfi, Marshal.SizeOf(psfi), uFlags);
		if (psfi.hIcon == IntPtr.Zero)
		{
			return new Bitmap(1, 1);
		}
		Bitmap result;
		using (Icon icon = Icon.FromHandle(psfi.hIcon))
		{
			result = (Bitmap)icon.ToBitmap().Clone();
		}
		DestroyIcon(psfi.hIcon);
		return result;
	}

	[DllImport("shell32.dll")]
	private static extern int SHGetFileInfoW([In][MarshalAs(UnmanagedType.LPTStr)] string pszPath, int dwFileAttributes, ref SHFILEINFOW psfi, int cbFileInfo, int uFlags);

	public static Bitmap GetIcon(string PathName, bool LargeIco)
	{
		SHFILEINFOW psfi = default(SHFILEINFOW);
		int uFlags = (LargeIco ? 256 : 257);
		IntPtr intPtr = (IntPtr)SHGetFileInfoW(PathName, 0, ref psfi, Marshal.SizeOf(psfi), uFlags);
		if (psfi.hIcon == IntPtr.Zero)
		{
			return new Bitmap(1, 1);
		}
		Bitmap result;
		using (Icon icon = Icon.FromHandle(psfi.hIcon))
		{
			result = (Bitmap)icon.ToBitmap().Clone();
		}
		DestroyIcon(psfi.hIcon);
		return result;
	}

	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern int GetScrollPos(IntPtr hWnd, Orientation nBar);
}
