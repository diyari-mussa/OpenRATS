using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Web.WebView2.WinForms;

namespace BTMOB;

[StandardModule]
internal sealed class WebViewinit
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ApplyAsync(WebView2 wv, Form frm)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void HandleKeys(KeyEventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}
}
