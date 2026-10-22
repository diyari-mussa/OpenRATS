using System.Media;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat;

[StandardModule]
internal sealed class Notif_Sound
{
	public static bool multi = false;

	public static SoundPlayer aMedia;

	public static MultiSounds Snds = new MultiSounds();

	private static string path_File = reso.res_Path + "\\Audio\\[id].wav";

	public static int id = 0;

	public static string getsoundpath()
	{
		string text = RegistryHandler.GET_SoundID();
		if (text == null)
		{
			text = "5";
		}
		return path_File.Replace("[id]", text);
	}
}
