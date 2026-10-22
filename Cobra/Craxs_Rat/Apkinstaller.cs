using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat;

[DesignerGenerated]
public class Apkinstaller : Form
{
	private IContainer components;

	[CompilerGenerated]
	[AccessedThroughProperty("LinkLabel1")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private LinkLabel _LinkLabel1;

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
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

	internal virtual LinkLabel LinkLabel1
	{
		[CompilerGenerated]
		get
		{
			return _LinkLabel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			LinkLabelLinkClickedEventHandler value2 = LinkLabel1_LinkClicked;
			LinkLabel linkLabel = _LinkLabel1;
			if (linkLabel != null)
			{
				linkLabel.LinkClicked -= value2;
			}
			_LinkLabel1 = value;
			linkLabel = _LinkLabel1;
			if (linkLabel != null)
			{
				linkLabel.LinkClicked += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DrakeUIButtonIcon1")]
	internal virtual DrakeUIButtonIcon DrakeUIButtonIcon1
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

	public Apkinstaller()
	{
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
		this.Panel1 = new System.Windows.Forms.Panel();
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.LinkLabel1 = new System.Windows.Forms.LinkLabel();
		this.DrakeUIButtonIcon1 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.Label1 = new System.Windows.Forms.Label();
		this.Panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		this.Panel2.SuspendLayout();
		base.SuspendLayout();
		this.Panel1.Controls.Add(this.PictureBox1);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel1.Location = new System.Drawing.Point(0, 0);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(819, 617);
		this.Panel1.TabIndex = 0;
		this.PictureBox1.Location = new System.Drawing.Point(114, 41);
		this.PictureBox1.Name = "PictureBox1";
		this.PictureBox1.Size = new System.Drawing.Size(601, 512);
		this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.PictureBox1.TabIndex = 0;
		this.PictureBox1.TabStop = false;
		this.Panel2.Controls.Add(this.LinkLabel1);
		this.Panel2.Controls.Add(this.DrakeUIButtonIcon1);
		this.Panel2.Controls.Add(this.Label1);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel2.Location = new System.Drawing.Point(0, 574);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new System.Drawing.Size(819, 43);
		this.Panel2.TabIndex = 1;
		this.LinkLabel1.Dock = System.Windows.Forms.DockStyle.Left;
		this.LinkLabel1.Font = new System.Drawing.Font("Calibri", 9f);
		this.LinkLabel1.Location = new System.Drawing.Point(281, 0);
		this.LinkLabel1.Name = "LinkLabel1";
		this.LinkLabel1.Size = new System.Drawing.Size(73, 43);
		this.LinkLabel1.TabIndex = 3;
		this.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.DrakeUIButtonIcon1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon1.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeUIButtonIcon1.FillColor = System.Drawing.Color.FromArgb(30, 136, 229);
		this.DrakeUIButtonIcon1.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButtonIcon1.Location = new System.Drawing.Point(700, 0);
		this.DrakeUIButtonIcon1.Name = "DrakeUIButtonIcon1";
		this.DrakeUIButtonIcon1.RectColor = System.Drawing.Color.FromArgb(30, 136, 229);
		this.DrakeUIButtonIcon1.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon1.Size = new System.Drawing.Size(119, 43);
		this.DrakeUIButtonIcon1.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon1.Symbol = 61537;
		this.DrakeUIButtonIcon1.TabIndex = 2;
		this.DrakeUIButtonIcon1.Text = "Next";
		this.Label1.Dock = System.Windows.Forms.DockStyle.Left;
		this.Label1.Font = new System.Drawing.Font("Calibri", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.ForeColor = System.Drawing.Color.White;
		this.Label1.Location = new System.Drawing.Point(0, 0);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(281, 43);
		this.Label1.TabIndex = 1;
		this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.Black;
		base.ClientSize = new System.Drawing.Size(819, 617);
		base.Controls.Add(this.Panel2);
		base.Controls.Add(this.Panel1);
		base.Name = "Apkinstaller";
		this.Text = "Apkinstaller";
		this.Panel1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		this.Panel2.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
	}
}
