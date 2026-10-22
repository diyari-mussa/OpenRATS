using System;
using System.Windows.Forms;

namespace BTMOB;

public class TabPageChangeEventArgs : EventArgs
{
	private TabPage _Selected;

	private TabPage _PreSelected;

	public bool Cancel;

	public TabPage CurrentTab => _Selected;

	public TabPage NextTab => _PreSelected;

	public TabPageChangeEventArgs(TabPage CurrentTab, TabPage NextTab)
	{
		Cancel = false;
		_Selected = CurrentTab;
		_PreSelected = NextTab;
	}
}
