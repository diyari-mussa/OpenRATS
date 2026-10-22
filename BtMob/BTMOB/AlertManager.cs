using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace BTMOB;

public sealed class AlertManager
{
	private static readonly ConcurrentQueue<Action> queue = new ConcurrentQueue<Action>();

	private static int activeCount = 0;

	private const int MAX_VISIBLE = 6;

	private AlertManager()
	{
	}

	public static void Enqueue(Action showAction)
	{
		queue.Enqueue(showAction);
		TryShowNext();
	}

	private static void TryShowNext()
	{
		if (activeCount >= 6)
		{
			return;
		}
		Action result = null;
		if (!queue.TryDequeue(out result))
		{
			return;
		}
		checked
		{
			activeCount++;
			frmAlert frmAlert2 = null;
			frmAlert2 = new frmAlert();
			frmAlert2.FormClosed += [SpecialName] (object sender, FormClosedEventArgs e) =>
			{
				activeCount--;
				TryShowNext();
			};
			Form form = Application.OpenForms.Cast<Form>().FirstOrDefault();
			if (form != null)
			{
				form.BeginInvoke((MethodInvoker)([SpecialName] () =>
				{
					result();
				}));
			}
			else
			{
				result();
			}
		}
	}
}
