using System;
using System.Drawing;
using Craxs_Rat.sockets;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat;

[StandardModule]
public sealed class GetFlagThisIp
{
	public static Image ThisIp(string ipc)
	{
		string text = Data.GeoIP0.LookupCountryCode(ipc.Trim()).ToUpper();
		int num = Array.IndexOf(Data.GeoIP0.CountryCode, text);
		int num2 = Data.imageFlags.Images.IndexOfKey(text);
		int num3 = num;
		if (num3 == -1)
		{
			num = 0;
			num2 = -1;
		}
		else if (num3 == Data.GeoIP0.CountryName.Length)
		{
			num = checked(num - 1);
			num2 = -1;
		}
		else if (num3 > Data.GeoIP0.CountryName.Length)
		{
			num = 0;
			num2 = -1;
		}
		Image result;
		try
		{
			if (num2 == -1)
			{
				num2 = Data.imageFlags.Images.IndexOfKey("-1".ToUpper());
			}
			result = Data.imageFlags.Images[num2];
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			result = Data.imageFlags.Images[0];
			ProjectData.ClearProjectError();
		}
		return result;
	}
}
