using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Web.WebView2.WinForms;

namespace BTMOB;

[StandardModule]
internal sealed class WebViewinit
{
	public static void ApplyAsync(WebView2 wv, Form frm)
	{
		if (wv == null || wv.CoreWebView2 == null)
			return;
		try
		{
			wv.CoreWebView2.Settings.IsStatusBarEnabled = false;
			wv.CoreWebView2.Settings.AreBrowserAcceleratorKeysEnabled = false;
		}
		catch
		{
		}
	}

	private static void HandleKeys(KeyEventArgs e)
	{
		if (e == null)
			return;
		if (e.KeyCode == Keys.F5 || e.KeyCode == Keys.F12)
			e.Handled = true;
	}
}
