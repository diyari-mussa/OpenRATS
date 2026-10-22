using System;
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
public class ttsform : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("okbtn")]
	private DrakeUIButtonIcon _okbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("nobtn")]
	private DrakeUIButtonIcon _nobtn;

	[field: AccessedThroughProperty("Panel4")]
	internal virtual Panel Panel4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("msgtitle")]
	internal virtual DrakeUILabel msgtitle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("msgimg")]
	internal virtual PictureBox msgimg
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel2")]
	internal virtual Panel Panel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeWidth_W1")]
	internal virtual DrakeWidth_W DrakeWidth_W1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeWidth_W3")]
	internal virtual DrakeWidth_W DrakeWidth_W3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("inputtext")]
	internal virtual DrakeUITextBox inputtext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("langtext")]
	internal virtual DrakeUIComboBox langtext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("labeltext")]
	internal virtual DrakeUILabel labeltext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("toppanel")]
	internal virtual Panel toppanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel3")]
	internal virtual Panel Panel3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel5")]
	internal virtual Panel Panel5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon okbtn
	{
		[CompilerGenerated]
		get
		{
			return _okbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = okbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _okbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_okbtn = value;
			drakeUIButtonIcon = _okbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon nobtn
	{
		[CompilerGenerated]
		get
		{
			return _nobtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = nobtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _nobtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_nobtn = value;
			drakeUIButtonIcon = _nobtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	public ttsform()
	{
		base.Load += ttsform_Load;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTMOB.ttsform));
		this.Panel4 = new System.Windows.Forms.Panel();
		this.msgtitle = new DrakeUI.Framework.DrakeUILabel();
		this.msgimg = new System.Windows.Forms.PictureBox();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.nobtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.langtext = new DrakeUI.Framework.DrakeUIComboBox();
		this.DrakeWidth_W1 = new DrakeUI.Framework.DrakeWidth_W();
		this.DrakeWidth_W3 = new DrakeUI.Framework.DrakeWidth_W();
		this.okbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.inputtext = new DrakeUI.Framework.DrakeUITextBox();
		this.labeltext = new DrakeUI.Framework.DrakeUILabel();
		this.toppanel = new System.Windows.Forms.Panel();
		this.Panel1 = new System.Windows.Forms.Panel();
		this.Panel3 = new System.Windows.Forms.Panel();
		this.Panel5 = new System.Windows.Forms.Panel();
		this.Panel4.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.msgimg).BeginInit();
		this.Panel2.SuspendLayout();
		base.SuspendLayout();
		this.Panel4.Controls.Add(this.msgtitle);
		this.Panel4.Controls.Add(this.msgimg);
		this.Panel4.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel4.Location = new System.Drawing.Point(2, 3);
		this.Panel4.Name = EXGuarder._670A1F72;
		this.Panel4.Size = new System.Drawing.Size(624, 42);
		this.Panel4.TabIndex = 20;
		this.msgtitle.Dock = System.Windows.Forms.DockStyle.Top;
		this.msgtitle.Font = new System.Drawing.Font(EXGuarder._0C150A26, 12f, System.Drawing.FontStyle.Bold);
		this.msgtitle.ForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.msgtitle.Location = new System.Drawing.Point(63, 0);
		this.msgtitle.Name = EXGuarder._1F4B2D27;
		this.msgtitle.Padding = new System.Windows.Forms.Padding(5);
		this.msgtitle.Size = new System.Drawing.Size(561, 42);
		this.msgtitle.Style = DrakeUI.Framework.UIStyle.Custom;
		this.msgtitle.TabIndex = 2;
		this.msgtitle.Text = EXGuarder._476D3524;
		this.msgtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.msgimg.Dock = System.Windows.Forms.DockStyle.Left;
		this.msgimg.Image = BTMOB.My.Resources.Resources.speech;
		this.msgimg.Location = new System.Drawing.Point(0, 0);
		this.msgimg.Name = EXGuarder._0D003532;
		this.msgimg.Size = new System.Drawing.Size(63, 42);
		this.msgimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.msgimg.TabIndex = 31;
		this.msgimg.TabStop = false;
		this.Panel2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel2.Controls.Add(this.nobtn);
		this.Panel2.Controls.Add(this.langtext);
		this.Panel2.Controls.Add(this.DrakeWidth_W1);
		this.Panel2.Controls.Add(this.DrakeWidth_W3);
		this.Panel2.Controls.Add(this.okbtn);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel2.Location = new System.Drawing.Point(2, 239);
		this.Panel2.Name = EXGuarder._4F2F0307;
		this.Panel2.Padding = new System.Windows.Forms.Padding(10);
		this.Panel2.Size = new System.Drawing.Size(624, 54);
		this.Panel2.TabIndex = 30;
		this.nobtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.nobtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.nobtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.nobtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.nobtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.nobtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.nobtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.nobtn.Font = new System.Drawing.Font(EXGuarder._0C150A26, 9f);
		this.nobtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.nobtn.ForeDisableColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.nobtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.nobtn.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.nobtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.nobtn.Location = new System.Drawing.Point(375, 10);
		this.nobtn.Margin = new System.Windows.Forms.Padding(5);
		this.nobtn.Name = EXGuarder._38752E50;
		this.nobtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.nobtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.nobtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.nobtn.RectPressColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.nobtn.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.nobtn.Size = new System.Drawing.Size(100, 34);
		this.nobtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.nobtn.Symbol = 61453;
		this.nobtn.TabIndex = 34;
		this.nobtn.Text = EXGuarder._6A4B2153;
		this.langtext.Dock = System.Windows.Forms.DockStyle.Left;
		this.langtext.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.langtext.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.langtext.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.langtext.Font = new System.Drawing.Font(EXGuarder._0C150A26, 10f);
		this.langtext.ForeColor = System.Drawing.Color.White;
		this.langtext.Items.AddRange(new object[7]
		{
			EXGuarder._6A071B69,
			EXGuarder._35430D26,
			EXGuarder._24381037,
			EXGuarder._192C5E16,
			EXGuarder._18151C4C,
			EXGuarder._5864101B,
			EXGuarder._63091C12
		});
		this.langtext.Location = new System.Drawing.Point(10, 10);
		this.langtext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.langtext.MinimumSize = new System.Drawing.Size(63, 0);
		this.langtext.Name = EXGuarder._5F1B4E77;
		this.langtext.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
		this.langtext.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.langtext.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.langtext.Size = new System.Drawing.Size(152, 27);
		this.langtext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.langtext.TabIndex = 32;
		this.langtext.Text = EXGuarder._6A071B69;
		this.langtext.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
		this.langtext.Watermark = EXGuarder._775D163D;
		this.DrakeWidth_W1.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W1.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeWidth_W1.Location = new System.Drawing.Point(475, 10);
		this.DrakeWidth_W1.Name = EXGuarder._621F2436;
		this.DrakeWidth_W1.Size = new System.Drawing.Size(28, 34);
		this.DrakeWidth_W1.TabIndex = 5;
		this.DrakeWidth_W3.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W3.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeWidth_W3.Location = new System.Drawing.Point(503, 10);
		this.DrakeWidth_W3.Name = EXGuarder._583B5669;
		this.DrakeWidth_W3.Size = new System.Drawing.Size(11, 34);
		this.DrakeWidth_W3.TabIndex = 6;
		this.okbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.okbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.okbtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.okbtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.okbtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.okbtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.okbtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.okbtn.Font = new System.Drawing.Font(EXGuarder._0C150A26, 9f);
		this.okbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.okbtn.ForeDisableColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.okbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.okbtn.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.okbtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.okbtn.Location = new System.Drawing.Point(514, 10);
		this.okbtn.Margin = new System.Windows.Forms.Padding(5);
		this.okbtn.Name = EXGuarder._050D430C;
		this.okbtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.okbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.okbtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.okbtn.RectPressColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.okbtn.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.okbtn.Size = new System.Drawing.Size(100, 34);
		this.okbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.okbtn.TabIndex = 33;
		this.okbtn.Text = EXGuarder._6F4E4353;
		this.inputtext.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.inputtext.Dock = System.Windows.Forms.DockStyle.Fill;
		this.inputtext.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.inputtext.Font = new System.Drawing.Font(EXGuarder._0C150A26, 9f);
		this.inputtext.ForeColor = System.Drawing.Color.White;
		this.inputtext.Location = new System.Drawing.Point(2, 87);
		this.inputtext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.inputtext.Maximum = 2147483647.0;
		this.inputtext.Minimum = -2147483648.0;
		this.inputtext.Multiline = true;
		this.inputtext.Name = EXGuarder._61274312;
		this.inputtext.Padding = new System.Windows.Forms.Padding(5);
		this.inputtext.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.inputtext.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.inputtext.Size = new System.Drawing.Size(624, 152);
		this.inputtext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.inputtext.StyleCustomMode = true;
		this.inputtext.TabIndex = 31;
		this.inputtext.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.inputtext.Watermark = EXGuarder._62694B14;
		this.labeltext.Dock = System.Windows.Forms.DockStyle.Top;
		this.labeltext.Font = new System.Drawing.Font(EXGuarder._0C150A26, 8.5f, System.Drawing.FontStyle.Bold);
		this.labeltext.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.labeltext.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
		this.labeltext.Location = new System.Drawing.Point(2, 45);
		this.labeltext.Name = EXGuarder._58476943;
		this.labeltext.Padding = new System.Windows.Forms.Padding(5);
		this.labeltext.Size = new System.Drawing.Size(624, 42);
		this.labeltext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.labeltext.TabIndex = 33;
		this.labeltext.Text = EXGuarder._424B642C;
		this.labeltext.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
		this.toppanel.BackColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
		this.toppanel.Location = new System.Drawing.Point(2, 0);
		this.toppanel.Name = EXGuarder._76042E2F;
		this.toppanel.Size = new System.Drawing.Size(624, 3);
		this.toppanel.TabIndex = 32;
		this.Panel1.BackColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel1.Location = new System.Drawing.Point(2, 293);
		this.Panel1.Name = EXGuarder._395E2214;
		this.Panel1.Size = new System.Drawing.Size(626, 2);
		this.Panel1.TabIndex = 34;
		this.Panel3.BackColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.Panel3.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel3.Location = new System.Drawing.Point(0, 0);
		this.Panel3.Name = EXGuarder._49237826;
		this.Panel3.Size = new System.Drawing.Size(2, 295);
		this.Panel3.TabIndex = 33;
		this.Panel5.BackColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.Panel5.Dock = System.Windows.Forms.DockStyle.Right;
		this.Panel5.Location = new System.Drawing.Point(626, 0);
		this.Panel5.Name = EXGuarder._59683B0C;
		this.Panel5.Size = new System.Drawing.Size(2, 293);
		this.Panel5.TabIndex = 34;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		base.ClientSize = new System.Drawing.Size(628, 295);
		base.ControlBox = false;
		base.Controls.Add(this.inputtext);
		base.Controls.Add(this.labeltext);
		base.Controls.Add(this.Panel2);
		base.Controls.Add(this.Panel4);
		base.Controls.Add(this.toppanel);
		base.Controls.Add(this.Panel5);
		base.Controls.Add(this.Panel1);
		base.Controls.Add(this.Panel3);
		this.ForeColor = System.Drawing.Color.White;
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject(EXGuarder._6937731B);
		base.Name = EXGuarder._680B7755;
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = EXGuarder._680B7755;
		base.TopMost = true;
		this.Panel4.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.msgimg).EndInit();
		this.Panel2.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	private void translateme()
	{
		object value = BTRegistry.GetValue(EXGuarder._02675D04, EXGuarder._2153573E);
		if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._3B41485C, TextCompare: false))
		{
			msgtitle.Text = EXGuarder._564F0D4F;
			labeltext.Text = EXGuarder._032B7203;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._712D6055, TextCompare: false))
		{
			msgtitle.Text = EXGuarder._3105500A;
			labeltext.Text = EXGuarder._6F2A5012;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._650F102B, TextCompare: false))
		{
			msgtitle.Text = EXGuarder._3A3C5B07;
			labeltext.Text = EXGuarder._5C523F22;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._2F6B373B, TextCompare: false))
		{
			msgtitle.Text = EXGuarder._54072A19;
			labeltext.Text = EXGuarder._073E7203;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._4876142A, TextCompare: false))
		{
			msgtitle.Text = EXGuarder._31564E4C;
			labeltext.Text = EXGuarder._6B400521;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._01255874, TextCompare: false))
		{
			msgtitle.Text = EXGuarder._6F454A6F;
			labeltext.Text = EXGuarder._2719510C;
		}
	}

	private void okbtn_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.OK;
		Close();
	}

	private void nobtn_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.No;
		Close();
	}

	private void ttsform_Load(object sender, EventArgs e)
	{
		translateme();
	}
}
