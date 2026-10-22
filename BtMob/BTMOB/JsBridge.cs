using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

namespace BTMOB;

[ComVisible(true)]
public class JsBridge
{
	public Form1 mainform;

	public JsBridge(Form1 minme)
	{
		mainform = minme;
	}

	[DispId(1)]
	public void toolbarclick(string idbtn, string mobid = "")
	{
		Thread thread = new Thread([SpecialName] () =>
		{
			mainform.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				switch (idbtn)
				{
				case "profile":
					mainform.ToolStripMenuItem2_Click(null, null);
					break;
				case "files":
					mainform.ToolStripMenuItem3_Click(null, null);
					break;
				case "Screen":
					mainform.ToolStripMenuItem4_Click(null, null);
					break;
				case "Camera":
					mainform.ToolStripMenuItem5_Click(null, null);
					break;
				case "Mic":
					mainform.ToolStripMenuItem1_Click(null, null);
					break;
				case "SMS":
					mainform.ToolStripMenuItem7_Click(null, null);
					break;
				case "Contacts":
					mainform.ToolStripMenuItem8_Click(null, null);
					break;
				case "Apps":
					mainform.ToolStripMenuItem9_Click(null, null);
					break;
				case "Keylogger":
					mainform.ToolStripMenuItem14_Click(null, null);
					break;
				case "Location":
					mainform.ToolStrip_location_Click(null, null);
					break;
				case "Browser":
					mainform.ToolStripMenuItem11_Click(null, null);
					break;
				case "Screenreader":
					mainform.ScreenReaderToolStripMenuItem_Click(null, null);
					break;
				case "Clipboard":
					mainform.ToolStripMenuItem20_Click(null, null);
					break;
				case "Lockscreen":
					mainform.ToolStripMenuItem21_Click(null, null);
					break;
				case "Chat":
					mainform.ToolStripMenuItem19_Click(null, null);
					break;
				case "goto_short":
					mainform.JumpToClient(mobid);
					break;
				case "block_short":
					mainform.Blockclient_Click(null, null, mobid);
					break;
				case "notes_short":
					mainform.openNotes_Click(null, null, mobid);
					break;
				case "rename_short":
					mainform.RenamClient_Click(null, null, mobid);
					break;
				case "toast_short":
					mainform.ShowToast_Click(null, null, mobid);
					break;
				case "vibrate_short":
					mainform.SendVibrate_Click(null, null, mobid);
					break;
				case "olink_short":
					mainform.Openlink_Click(null, null, mobid);
					break;
				}
			}));
		});
		thread.IsBackground = true;
		thread.Start();
	}
}
