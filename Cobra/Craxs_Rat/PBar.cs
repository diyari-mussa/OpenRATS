using System.Windows.Forms;

namespace Craxs_Rat;

public class PBar : ProgressBar
{
	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = base.CreateParams;
			createParams.Style |= 4;
			return createParams;
		}
	}
}
