using System;
using System.Drawing;
using Microsoft.VisualBasic.CompilerServices;

namespace BTMOB;

[StandardModule]
public sealed class IPtoFlag
{
	public static Image getflag(string ipc)
	{
		try
		{
			int num = 0;
			int num2 = 0;
			string text = BTEngine.GeoIP0.LookupCountryCode(ipc.Trim()).ToUpper();
			num = Array.IndexOf(BTEngine.GeoIP0.CountryCode, text);
			num2 = BTEngine.MainForm.Flags_images.Images.IndexOfKey(text);
			int num3 = num;
			if (num3 == -1)
			{
				num = 0;
				num2 = -1;
			}
			else if (num3 == BTEngine.GeoIP0.CountryName.Length)
			{
				num = checked(num - 1);
				num2 = -1;
			}
			else if (num3 > BTEngine.GeoIP0.CountryName.Length)
			{
				num = 0;
				num2 = -1;
			}
			if (num2 == -1)
			{
				num2 = BTEngine.MainForm.Flags_images.Images.IndexOfKey(EXGuarder._5A66552F.ToUpper());
			}
			return BTEngine.MainForm.Flags_images.Images[num2];
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		return BTEngine.MainForm.Flags_images.Images[BTEngine.MainForm.Flags_images.Images.IndexOfKey(EXGuarder._5A66552F.ToUpper())];
	}

	public static string GetCountryName(string ipc)
	{
		string _0F = EXGuarder._0F502634;
		try
		{
			_0F = BTEngine.GeoIP0.LookupCountryName(ipc.Trim());
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			_0F = EXGuarder._025B5504;
			ProjectData.ClearProjectError();
		}
		return _0F;
	}
}
