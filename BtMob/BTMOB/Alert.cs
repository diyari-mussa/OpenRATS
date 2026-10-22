using System;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace BTMOB;

public class Alert
{
	private static readonly int IntervalDefault = 2000;

	private static void ShowAsync(Action action)
	{
		Form form = Application.OpenForms.Cast<Form>().FirstOrDefault();
		if (form != null)
		{
			form.BeginInvoke((MethodInvoker)([SpecialName] () =>
			{
				action();
			}));
		}
		else
		{
			action();
		}
	}

	internal static void ShowInternal(Action action)
	{
		Form form = Application.OpenForms.Cast<Form>().FirstOrDefault();
		if (form != null)
		{
			form.BeginInvoke((MethodInvoker)([SpecialName] () =>
			{
				action();
			}));
		}
		else
		{
			action();
		}
	}

	public static void ShowSucess(string message)
	{
		ShowSucess(message, IntervalDefault);
	}

	public static void ShowSucess(string message, int interval)
	{
		ShowAsync([SpecialName] () =>
		{
			frmAlert frmAlert2 = new frmAlert();
			frmAlert2.ShowAlert(message, AlertType.AlertIconType.Sucess, interval);
		});
	}

	public static void ShowInformation(string message)
	{
		ShowInformation(message, IntervalDefault);
	}

	public static void ShowInformation(string message, int interval)
	{
		ShowAsync([SpecialName] () =>
		{
			frmAlert frmAlert2 = new frmAlert();
			frmAlert2.ShowAlert(message, AlertType.AlertIconType.Information, interval);
		});
	}

	public static void ShowWarning(string message)
	{
		ShowWarning(message, IntervalDefault);
	}

	public static void ShowWarning(string message, int interval)
	{
		ShowAsync([SpecialName] () =>
		{
			frmAlert frmAlert2 = new frmAlert();
			frmAlert2.ShowAlert(message, AlertType.AlertIconType.Warning, interval);
		});
	}

	public static void ShowError(string message)
	{
		ShowError(message, IntervalDefault);
	}

	public static void ShowError(string message, int interval)
	{
		ShowAsync([SpecialName] () =>
		{
			frmAlert frmAlert2 = new frmAlert();
			frmAlert2.ShowAlert(message, AlertType.AlertIconType.Error, interval);
		});
	}

	public static void ShowCustom(string message, Image image = null, Color color = default(Color))
	{
		ShowCustom(message, IntervalDefault, image, color);
	}

	public static void ShowCustom(string message, int interval, Image image = null, Color color = default(Color))
	{
		ShowAsync([SpecialName] () =>
		{
			frmAlert frmAlert2 = new frmAlert();
			frmAlert2.ShowAlert(message, AlertType.AlertIconType.Custom, interval, image, (color == default(Color)) ? Color.FromArgb(83, 92, 104) : color);
		});
	}
}
