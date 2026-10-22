using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat;

[DesignerGenerated]
public class smsMaker : Form
{
	private IContainer components;

	[AccessedThroughProperty("phonetext")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DrakeUITextBox _phonetext;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon1")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon1;

	[CompilerGenerated]
	[AccessedThroughProperty("DrakeUIButtonIcon2")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DrakeUIButtonIcon _DrakeUIButtonIcon2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("remnum")]
	private DrakeUIAvatar _remnum;

	[AccessedThroughProperty("addnum")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DrakeUIAvatar _addnum;

	[AccessedThroughProperty("selectlist")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DrakeUIAvatar _selectlist;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkall")]
	[CompilerGenerated]
	private DrakeUICheckBox _checkall;

	internal virtual DrakeUITextBox phonetext
	{
		[CompilerGenerated]
		get
		{
			return _phonetext;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyPressEventHandler value2 = Phonetext_KeyPress;
			DrakeUITextBox drakeUITextBox = _phonetext;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.KeyPress -= value2;
			}
			_phonetext = value;
			drakeUITextBox = _phonetext;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.KeyPress += value2;
			}
		}
	}

	[field: AccessedThroughProperty("msgtext")]
	internal virtual DrakeUITextBox msgtext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon DrakeUIButtonIcon1
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIButtonIcon1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon1_click;
			DrakeUIButtonIcon drakeUIButtonIcon = _DrakeUIButtonIcon1;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_DrakeUIButtonIcon1 = value;
			drakeUIButtonIcon = _DrakeUIButtonIcon1;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon DrakeUIButtonIcon2
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIButtonIcon2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon2_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _DrakeUIButtonIcon2;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_DrakeUIButtonIcon2 = value;
			drakeUIButtonIcon = _DrakeUIButtonIcon2;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label34")]
	internal virtual Label Label34
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("numslist")]
	internal virtual DrakeUIListBox numslist
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIAvatar remnum
	{
		[CompilerGenerated]
		get
		{
			return _remnum;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Remnum_Click;
			DrakeUIAvatar drakeUIAvatar = _remnum;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click -= value2;
			}
			_remnum = value;
			drakeUIAvatar = _remnum;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click += value2;
			}
		}
	}

	internal virtual DrakeUIAvatar addnum
	{
		[CompilerGenerated]
		get
		{
			return _addnum;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Addnum_Click;
			DrakeUIAvatar drakeUIAvatar = _addnum;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click -= value2;
			}
			_addnum = value;
			drakeUIAvatar = _addnum;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click += value2;
			}
		}
	}

	internal virtual DrakeUIAvatar selectlist
	{
		[CompilerGenerated]
		get
		{
			return _selectlist;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Selectlist_Click;
			DrakeUIAvatar drakeUIAvatar = _selectlist;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click -= value2;
			}
			_selectlist = value;
			drakeUIAvatar = _selectlist;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeUIToolTip1")]
	internal virtual DrakeUIToolTip DrakeUIToolTip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUICheckBox checkall
	{
		[CompilerGenerated]
		get
		{
			return _checkall;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Checkall_MouseClick;
			DrakeUICheckBox drakeUICheckBox = _checkall;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.MouseClick -= value2;
			}
			_checkall = value;
			drakeUICheckBox = _checkall;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.MouseClick += value2;
			}
		}
	}

	public smsMaker()
	{
		base.Load += CraxsRatkfvuiorkenfudpajrsnCraxsRatszxcdsatyud;
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.components = new System.ComponentModel.Container();
		this.phonetext = new DrakeUI.Framework.DrakeUITextBox();
		this.msgtext = new DrakeUI.Framework.DrakeUITextBox();
		this.DrakeUIButtonIcon1 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeUIButtonIcon2 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.Label1 = new System.Windows.Forms.Label();
		this.Label34 = new System.Windows.Forms.Label();
		this.numslist = new DrakeUI.Framework.DrakeUIListBox();
		this.remnum = new DrakeUI.Framework.DrakeUIAvatar();
		this.addnum = new DrakeUI.Framework.DrakeUIAvatar();
		this.selectlist = new DrakeUI.Framework.DrakeUIAvatar();
		this.Label2 = new System.Windows.Forms.Label();
		this.DrakeUIToolTip1 = new DrakeUI.Framework.DrakeUIToolTip(this.components);
		this.checkall = new DrakeUI.Framework.DrakeUICheckBox();
		base.SuspendLayout();
		this.phonetext.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.phonetext.FillColor = System.Drawing.Color.White;
		this.phonetext.Font = new System.Drawing.Font("Calibri", 12f);
		this.phonetext.Location = new System.Drawing.Point(101, 428);
		this.phonetext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.phonetext.Maximum = 2147483647.0;
		this.phonetext.Minimum = -2147483648.0;
		this.phonetext.Name = "phonetext";
		this.phonetext.Padding = new System.Windows.Forms.Padding(5);
		this.phonetext.RectColor = System.Drawing.Color.FromArgb(56, 142, 60);
		this.phonetext.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.phonetext.Size = new System.Drawing.Size(227, 30);
		this.phonetext.Style = DrakeUI.Framework.UIStyle.Green;
		this.phonetext.TabIndex = 0;
		this.phonetext.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
		this.phonetext.Watermark = "Phone Number";
		this.msgtext.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.msgtext.FillColor = System.Drawing.Color.White;
		this.msgtext.Font = new System.Drawing.Font("Calibri", 12f);
		this.msgtext.Location = new System.Drawing.Point(407, 39);
		this.msgtext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.msgtext.Maximum = 2147483647.0;
		this.msgtext.MaxLength = 160;
		this.msgtext.Minimum = -2147483648.0;
		this.msgtext.Multiline = true;
		this.msgtext.Name = "msgtext";
		this.msgtext.Padding = new System.Windows.Forms.Padding(5);
		this.msgtext.RectColor = System.Drawing.Color.FromArgb(230, 80, 80);
		this.msgtext.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.msgtext.Size = new System.Drawing.Size(366, 362);
		this.msgtext.Style = DrakeUI.Framework.UIStyle.Red;
		this.msgtext.StyleCustomMode = true;
		this.msgtext.TabIndex = 1;
		this.msgtext.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
		this.DrakeUIToolTip1.SetToolTip(this.msgtext, "Max limit 160");
		this.msgtext.Watermark = "";
		this.DrakeUIButtonIcon1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon1.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon1.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButtonIcon1.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon1.Location = new System.Drawing.Point(638, 503);
		this.DrakeUIButtonIcon1.Name = "DrakeUIButtonIcon1";
		this.DrakeUIButtonIcon1.RectColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon1.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon1.Size = new System.Drawing.Size(136, 35);
		this.DrakeUIButtonIcon1.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon1.Symbol = 61768;
		this.DrakeUIButtonIcon1.TabIndex = 2;
		this.DrakeUIButtonIcon1.Text = "Send";
		this.DrakeUIButtonIcon2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon2.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon2.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButtonIcon2.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon2.Location = new System.Drawing.Point(487, 503);
		this.DrakeUIButtonIcon2.Name = "DrakeUIButtonIcon2";
		this.DrakeUIButtonIcon2.RectColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon2.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon2.Size = new System.Drawing.Size(137, 35);
		this.DrakeUIButtonIcon2.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon2.Symbol = 61453;
		this.DrakeUIButtonIcon2.TabIndex = 3;
		this.DrakeUIButtonIcon2.Text = "Cancel";
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Calibri", 12f);
		this.Label1.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label1.Location = new System.Drawing.Point(116, 9);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(163, 25);
		this.Label1.TabIndex = 4;
		this.Label1.Text = "Phones Numbers";
		this.Label34.AutoSize = true;
		this.Label34.BackColor = System.Drawing.Color.Transparent;
		this.Label34.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label34.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label34.Location = new System.Drawing.Point(584, 429);
		this.Label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label34.Name = "Label34";
		this.Label34.Size = new System.Drawing.Size(115, 24);
		this.Label34.TabIndex = 66;
		this.Label34.Text = "All contacts";
		this.numslist.FillColor = System.Drawing.Color.FromArgb(225, 245, 254);
		this.numslist.Font = new System.Drawing.Font("Calibri", 12f);
		this.numslist.ItemSelectBackColor = System.Drawing.Color.FromArgb(30, 136, 229);
		this.numslist.ItemSelectForeColor = System.Drawing.Color.FromArgb(225, 245, 254);
		this.numslist.Location = new System.Drawing.Point(18, 39);
		this.numslist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.numslist.Name = "numslist";
		this.numslist.Padding = new System.Windows.Forms.Padding(2);
		this.numslist.RectColor = System.Drawing.Color.FromArgb(30, 136, 229);
		this.numslist.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.numslist.Size = new System.Drawing.Size(366, 362);
		this.numslist.Style = DrakeUI.Framework.UIStyle.Custom;
		this.numslist.StyleCustomMode = true;
		this.numslist.TabIndex = 67;
		this.numslist.Text = "DrakeUIListBox1";
		this.remnum.AvatarSize = 30;
		this.remnum.Cursor = System.Windows.Forms.Cursors.Hand;
		this.remnum.FillColor = System.Drawing.Color.Black;
		this.remnum.Font = new System.Drawing.Font("Calibri", 12f);
		this.remnum.ForeColor = System.Drawing.Color.SkyBlue;
		this.remnum.Location = new System.Drawing.Point(15, 429);
		this.remnum.Margin = new System.Windows.Forms.Padding(4);
		this.remnum.Name = "remnum";
		this.remnum.Size = new System.Drawing.Size(35, 30);
		this.remnum.Style = DrakeUI.Framework.UIStyle.Custom;
		this.remnum.Symbol = 61526;
		this.remnum.SymbolSize = 30;
		this.remnum.TabIndex = 69;
		this.remnum.Text = "DrakeUIAvatar2";
		this.DrakeUIToolTip1.SetToolTip(this.remnum, "Remove numer from list");
		this.addnum.AvatarSize = 30;
		this.addnum.Cursor = System.Windows.Forms.Cursors.Hand;
		this.addnum.FillColor = System.Drawing.Color.Black;
		this.addnum.Font = new System.Drawing.Font("Calibri", 12f);
		this.addnum.ForeColor = System.Drawing.Color.SkyBlue;
		this.addnum.Location = new System.Drawing.Point(58, 429);
		this.addnum.Margin = new System.Windows.Forms.Padding(4);
		this.addnum.Name = "addnum";
		this.addnum.Size = new System.Drawing.Size(35, 30);
		this.addnum.Style = DrakeUI.Framework.UIStyle.Custom;
		this.addnum.Symbol = 61525;
		this.addnum.SymbolSize = 30;
		this.addnum.TabIndex = 68;
		this.addnum.Text = "DrakeUIAvatar1";
		this.DrakeUIToolTip1.SetToolTip(this.addnum, "add number to list");
		this.selectlist.AvatarSize = 30;
		this.selectlist.Cursor = System.Windows.Forms.Cursors.Hand;
		this.selectlist.FillColor = System.Drawing.Color.Black;
		this.selectlist.Font = new System.Drawing.Font("Calibri", 12f);
		this.selectlist.ForeColor = System.Drawing.Color.SkyBlue;
		this.selectlist.Location = new System.Drawing.Point(347, 428);
		this.selectlist.Margin = new System.Windows.Forms.Padding(4);
		this.selectlist.Name = "selectlist";
		this.selectlist.Size = new System.Drawing.Size(35, 30);
		this.selectlist.Style = DrakeUI.Framework.UIStyle.Custom;
		this.selectlist.Symbol = 61462;
		this.selectlist.SymbolSize = 30;
		this.selectlist.TabIndex = 70;
		this.selectlist.Text = "DrakeUIAvatar1";
		this.DrakeUIToolTip1.SetToolTip(this.selectlist, "get numbers from text file");
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Calibri", 12f);
		this.Label2.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label2.Location = new System.Drawing.Point(531, 9);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(129, 25);
		this.Label2.TabIndex = 71;
		this.Label2.Text = "Message text";
		this.DrakeUIToolTip1.BackColor = System.Drawing.Color.Black;
		this.DrakeUIToolTip1.ForeColor = System.Drawing.Color.FromArgb(239, 239, 239);
		this.DrakeUIToolTip1.OwnerDraw = true;
		this.DrakeUIToolTip1.RectColor = System.Drawing.Color.SkyBlue;
		this.checkall.CheckBoxColor = System.Drawing.Color.SkyBlue;
		this.checkall.Cursor = System.Windows.Forms.Cursors.Hand;
		this.checkall.Font = new System.Drawing.Font("Calibri", 12f);
		this.checkall.Location = new System.Drawing.Point(535, 424);
		this.checkall.Name = "checkall";
		this.checkall.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.checkall.Size = new System.Drawing.Size(42, 29);
		this.checkall.Style = DrakeUI.Framework.UIStyle.Custom;
		this.checkall.StyleCustomMode = true;
		this.checkall.TabIndex = 72;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.Black;
		base.ClientSize = new System.Drawing.Size(786, 550);
		base.ControlBox = false;
		base.Controls.Add(this.checkall);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.selectlist);
		base.Controls.Add(this.remnum);
		base.Controls.Add(this.addnum);
		base.Controls.Add(this.numslist);
		base.Controls.Add(this.Label34);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.DrakeUIButtonIcon2);
		base.Controls.Add(this.DrakeUIButtonIcon1);
		base.Controls.Add(this.msgtext);
		base.Controls.Add(this.phonetext);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
		base.Name = "smsMaker";
		base.ShowIcon = false;
		this.Text = "Create SMS";
		base.TopMost = true;
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.Cancel;
		Close();
	}

	private void DrakeUIButtonIcon1_click(object sender, EventArgs e)
	{
		if (!checkall.Checked && numslist.Items.Count == 0)
		{
			Interaction.MsgBox("Add Phone Number to list First");
			return;
		}
		base.DialogResult = DialogResult.OK;
		Close();
	}

	private void Phonetext_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (Strings.Asc(e.KeyChar) != 8 && ((Strings.Asc(e.KeyChar) < 48) | (Strings.Asc(e.KeyChar) > 57)))
		{
			e.Handled = true;
		}
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatszxcdsatyud(object sender, EventArgs e)
	{
	}

	private void Checkall_Load(object sender, EventArgs e)
	{
	}

	private void Addnum_Click(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(phonetext.Text) | string.IsNullOrWhiteSpace(phonetext.Text))
		{
			Interaction.MsgBox("Enter Phone Number First");
		}
		else
		{
			numslist.Items.Add(phonetext.Text);
		}
	}

	private void Remnum_Click(object sender, EventArgs e)
	{
		if (numslist.Items.Count == 0)
		{
			Interaction.MsgBox("Add Phone Number to list First");
		}
		else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(numslist.SelectedItem, null, "Count", new object[0], null, null, null), 0, TextCompare: false))
		{
			Interaction.MsgBox("select number from list to remove");
		}
		else
		{
			object CounterResult = default(object);
			object LoopForResult = default(object);
			if (!ObjectFlowControl.ForLoopControl.ForLoopInitObj(CounterResult, 0, Operators.SubtractObject(NewLateBinding.LateGet(numslist.SelectedItem, null, "Count", new object[0], null, null, null), 1), 1, ref LoopForResult, ref CounterResult))
			{
				return;
			}
			do
			{
				try
				{
					numslist.Items.Remove(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(numslist.SelectedItem, new object[1] { CounterResult }, null)));
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			while (ObjectFlowControl.ForLoopControl.ForNextCheckObj(CounterResult, LoopForResult, ref CounterResult));
		}
	}

	private void Selectlist_Click(object sender, EventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.InitialDirectory = "C:\\";
		openFileDialog.Title = "Open a Text File";
		openFileDialog.Filter = "Text Files|*.txt";
		if (openFileDialog.ShowDialog() != DialogResult.OK)
		{
			return;
		}
		checked
		{
			try
			{
				string fileName = openFileDialog.FileName;
				if (string.IsNullOrEmpty(fileName) || string.IsNullOrWhiteSpace(fileName))
				{
					return;
				}
				string[] array = File.ReadAllLines(fileName);
				if (array.Length <= 0)
				{
					return;
				}
				int num = array.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					string text = array[i].Replace(" ", "");
					if (Versioned.IsNumeric(text))
					{
						numslist.Items.Add(text);
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Checkall_MouseClick(object sender, MouseEventArgs e)
	{
		if (checkall.Checked)
		{
			phonetext.Text = "";
			phonetext.Enabled = false;
			numslist.Items.Clear();
			numslist.Enabled = false;
			selectlist.Enabled = false;
			addnum.Enabled = false;
			remnum.Enabled = false;
		}
		else
		{
			phonetext.Text = "";
			phonetext.Enabled = true;
			numslist.Enabled = true;
			selectlist.Enabled = true;
			addnum.Enabled = true;
			remnum.Enabled = false;
		}
	}
}
