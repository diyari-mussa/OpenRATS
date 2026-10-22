using Microsoft.VisualBasic.CompilerServices;

namespace BTMOB;

[StandardModule]
internal sealed class AlertType
{
	public enum AlertIconType
	{
		Sucess,
		Information,
		Warning,
		Error,
		Custom
	}

	public enum AlertAction
	{
		Start,
		Wait,
		Close
	}
}
