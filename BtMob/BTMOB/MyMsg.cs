using System.Drawing;
using System.Windows.Forms;
using BTMOB.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace BTMOB;

[StandardModule]
internal sealed class MyMsg
{
	public enum msgtype
	{
		Confirm,
		errors,
		warning
	}

	public static DialogResult Show(string title, string msg, msgtype typ, bool use_no, bool showskip = false, string skipwaht = "")
	{
		MyMsgBox myMsgBox = new MyMsgBox();
		switch (typ)
		{
		case msgtype.warning:
			myMsgBox.msgtitle.ForeColor = Color.Orange;
			myMsgBox.okbtn.ForeColor = Color.Orange;
			myMsgBox.okbtn.RectColor = Color.Orange;
			myMsgBox.msgimg.Image = Resources.warning_img;
			break;
		case msgtype.errors:
			myMsgBox.okbtn.ForeColor = Color.Red;
			myMsgBox.okbtn.RectColor = Color.Red;
			myMsgBox.msgimg.Image = Resources.error_img;
			break;
		default:
			myMsgBox.okbtn.RectColor = Color.FromArgb(2, 176, 117);
			myMsgBox.okbtn.ForeColor = Color.FromArgb(2, 176, 117);
			myMsgBox.msgimg.Image = Resources.ok;
			break;
		}
		myMsgBox.msgtitle.Text = title;
		myMsgBox.msgbody.Text = msg;
		myMsgBox.nobtn.Visible = use_no;
		myMsgBox.checkskip.Visible = showskip;
		DialogResult result = myMsgBox.ShowDialog();
		if (showskip && myMsgBox.checkskip.Checked && !codes.StrisEmpty(skipwaht))
		{
			BTRegistry.WriteBool(skipwaht, value: true);
		}
		return result;
	}
}
