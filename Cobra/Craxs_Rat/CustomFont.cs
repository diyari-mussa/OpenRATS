using System.Drawing;
using System.Drawing.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat;

[StandardModule]
internal sealed class CustomFont
{
	private static PrivateFontCollection privateFonts = null;

	public static Font LoadFont(string name, float size, FontStyle style)
	{
		privateFonts = new PrivateFontCollection();
		privateFonts.AddFontFile(reso.res_Path + "\\Fonts\\" + name);
		return new Font(privateFonts.Families[0], size, style);
	}
}
