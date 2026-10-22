using System.Windows.Forms;

namespace BTMOB;

public class MyListView : ListView
{
	public MyListView()
	{
		SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
	}
}
