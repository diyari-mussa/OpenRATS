using System;
using System.Drawing;
using Craxs_Rat.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat;

[StandardModule]
internal sealed class CraxsAlert
{
	public static void ShowCustome(string msg, Bitmap img, Color backcolor, Color rondcolor)
	{
		try
		{
			alertform alertform2 = new alertform(msg);
			alertform2.alertimage.Image = img;
			alertform2.backpanel.FillColor = backcolor;
			alertform2.lidlamb.ForeColor = rondcolor;
			alertform2.backpanel.RectColor = rondcolor;
			alertform2.Show();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void ShowSucess(string msg)
	{
		alertform alertform2 = new alertform(msg);
		alertform2.alertimage.Image = Resources.sucess48px;
		alertform2.backpanel.FillColor = Color.Black;
		alertform2.lidlamb.ForeColor = Color.Lime;
		alertform2.backpanel.RectColor = Color.Lime;
		alertform2.Show();
	}

	public static void ShowWarning(string msg)
	{
		alertform obj = new alertform(msg);
		obj.alertimage.Image = Resources.warning48px;
		obj.backpanel.FillColor = Color.Black;
		obj.lidlamb.ForeColor = Color.SkyBlue;
		obj.Show();
	}

	public static void Showinformation(string msg)
	{
		alertform obj = new alertform(msg);
		obj.alertimage.Image = Resources.information48px;
		obj.backpanel.FillColor = Color.Black;
		obj.lidlamb.ForeColor = Color.SkyBlue;
		obj.Show();
	}

	public static void ShowError(string msg)
	{
		alertform obj = new alertform(msg);
		obj.alertimage.Image = Resources.error48px;
		obj.backpanel.FillColor = Color.Black;
		obj.lidlamb.ForeColor = Color.SkyBlue;
		obj.Show();
	}
}
