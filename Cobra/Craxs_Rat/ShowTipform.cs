using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Craxs_Rat.My.Resources;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat;

[DesignerGenerated]
public class ShowTipform : Form
{
	private IContainer components;

	public string tipid;

	public Bitmap tippic;

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
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

	[field: AccessedThroughProperty("checkdontshow")]
	internal virtual DrakeUICheckBox checkdontshow
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		this.Panel1 = new System.Windows.Forms.Panel();
		this.checkdontshow = new DrakeUI.Framework.DrakeUICheckBox();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		this.Panel1.SuspendLayout();
		base.SuspendLayout();
		this.PictureBox1.BackColor = System.Drawing.Color.Black;
		this.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.PictureBox1.Image = Craxs_Rat.My.Resources.Resources.Tip_screenctrol;
		this.PictureBox1.Location = new System.Drawing.Point(0, 0);
		this.PictureBox1.Name = "PictureBox1";
		this.PictureBox1.Size = new System.Drawing.Size(635, 473);
		this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.PictureBox1.TabIndex = 0;
		this.PictureBox1.TabStop = false;
		this.Panel1.BackColor = System.Drawing.Color.Black;
		this.Panel1.Controls.Add(this.checkdontshow);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel1.Location = new System.Drawing.Point(0, 440);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(635, 33);
		this.Panel1.TabIndex = 1;
		this.checkdontshow.CheckBoxColor = System.Drawing.Color.FromArgb(30, 136, 229);
		this.checkdontshow.Cursor = System.Windows.Forms.Cursors.Hand;
		this.checkdontshow.Dock = System.Windows.Forms.DockStyle.Fill;
		this.checkdontshow.Font = new System.Drawing.Font("Calibri", 9f);
		this.checkdontshow.ForeColor = System.Drawing.Color.Lime;
		this.checkdontshow.Location = new System.Drawing.Point(0, 0);
		this.checkdontshow.Name = "checkdontshow";
		this.checkdontshow.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.checkdontshow.Size = new System.Drawing.Size(635, 33);
		this.checkdontshow.Style = DrakeUI.Framework.UIStyle.Custom;
		this.checkdontshow.StyleCustomMode = true;
		this.checkdontshow.TabIndex = 0;
		this.checkdontshow.Text = "Don't Show Again";
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(635, 473);
		base.Controls.Add(this.Panel1);
		base.Controls.Add(this.PictureBox1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
		base.Name = "ShowTipform";
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		this.Text = "Tips";
		base.TopMost = true;
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		this.Panel1.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	public ShowTipform(string id, Bitmap pic)
	{
		base.FormClosing += ShowTipform_FormClosing;
		base.Load += ShowTipform_Load;
		tipid = "";
		InitializeComponent();
		tipid = id;
		tippic = pic;
	}

	private void ShowTipform_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (checkdontshow.Checked)
		{
			RegistryHandler.SET_Tip("no", tipid);
		}
	}

	private void ShowTipform_Load(object sender, EventArgs e)
	{
		PictureBox1.Image = tippic;
	}
}
