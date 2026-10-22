using System.Runtime.InteropServices;

namespace BTMOB;

[ClassInterface(ClassInterfaceType.AutoDual)]
[ComVisible(true)]
public class Jsterminal
{
	public terminal mainform;

	public Jsterminal(terminal m)
	{
		mainform = m;
	}

	public string ExecuteCommand(string cmd)
	{
		mainform.commandterminal(cmd);
		string result = default(string);
		return result;
	}
}
