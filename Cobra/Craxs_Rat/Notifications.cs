using System;
using System.Drawing;
using Craxs_Rat.My;

namespace Craxs_Rat;

public sealed class Notifications
{
	public Bitmap FLAG;

	public string TEXT;

	public int sizeHeight;

	public DateTime start;

	public bool startTime;

	public Notifications()
	{
		sizeHeight = MyProject.Forms.Report.Height;
	}
}
