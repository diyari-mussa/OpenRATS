using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat;

[DesignerGenerated]
public class AddNumber : Form
{
	private IContainer components;

	[AccessedThroughProperty("Panel1")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Panel _Panel1;

	[CompilerGenerated]
	[AccessedThroughProperty("TOpacity")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Timer _TOpacity;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon3")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon3;

	private List<Rectangle> RectInputText0;

	internal virtual Panel Panel1
	{
		[CompilerGenerated]
		get
		{
			return _Panel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			PaintEventHandler value2 = Panel1_Paint;
			Panel panel = _Panel1;
			if (panel != null)
			{
				panel.Paint -= value2;
			}
			_Panel1 = value;
			panel = _Panel1;
			if (panel != null)
			{
				panel.Paint += value2;
			}
		}
	}

	[field: AccessedThroughProperty("InputText1")]
	internal virtual TextBox InputText1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("L1")]
	internal virtual Label L1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("InputText0")]
	internal virtual TextBox InputText0
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("L0")]
	internal virtual Label L0
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer TOpacity
	{
		[CompilerGenerated]
		get
		{
			return _TOpacity;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = TOpacity_Tick;
			Timer timer = _TOpacity;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_TOpacity = value;
			timer = _TOpacity;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon DrakeUIButtonIcon3
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIButtonIcon3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon3_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _DrakeUIButtonIcon3;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_DrakeUIButtonIcon3 = value;
			drakeUIButtonIcon = _DrakeUIButtonIcon3;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
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
		this.Panel1 = new System.Windows.Forms.Panel();
		this.DrakeUIButtonIcon3 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.InputText1 = new System.Windows.Forms.TextBox();
		this.L1 = new System.Windows.Forms.Label();
		this.InputText0 = new System.Windows.Forms.TextBox();
		this.L0 = new System.Windows.Forms.Label();
		this.TOpacity = new System.Windows.Forms.Timer(this.components);
		this.Panel1.SuspendLayout();
		base.SuspendLayout();
		this.Panel1.BackColor = System.Drawing.Color.Black;
		this.Panel1.Controls.Add(this.DrakeUIButtonIcon3);
		this.Panel1.Controls.Add(this.InputText1);
		this.Panel1.Controls.Add(this.L1);
		this.Panel1.Controls.Add(this.InputText0);
		this.Panel1.Controls.Add(this.L0);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel1.ForeColor = System.Drawing.Color.FromArgb(190, 190, 190);
		this.Panel1.Location = new System.Drawing.Point(0, 0);
		this.Panel1.Margin = new System.Windows.Forms.Padding(4);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(599, 241);
		this.Panel1.TabIndex = 1;
		this.DrakeUIButtonIcon3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon3.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon3.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.DrakeUIButtonIcon3.FillPressColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon3.FillSelectedColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon3.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButtonIcon3.ForeColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon3.ForePressColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon3.Location = new System.Drawing.Point(20, 194);
		this.DrakeUIButtonIcon3.Margin = new System.Windows.Forms.Padding(4);
		this.DrakeUIButtonIcon3.Name = "DrakeUIButtonIcon3";
		this.DrakeUIButtonIcon3.Radius = 25;
		this.DrakeUIButtonIcon3.RectColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon3.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon3.RectHoverColor = System.Drawing.Color.White;
		this.DrakeUIButtonIcon3.RectPressColor = System.Drawing.Color.White;
		this.DrakeUIButtonIcon3.RectSelectedColor = System.Drawing.Color.White;
		this.DrakeUIButtonIcon3.Size = new System.Drawing.Size(555, 32);
		this.DrakeUIButtonIcon3.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon3.Symbol = 61543;
		this.DrakeUIButtonIcon3.TabIndex = 19;
		this.DrakeUIButtonIcon3.Text = "Add New Number";
		this.InputText1.BackColor = System.Drawing.Color.White;
		this.InputText1.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.InputText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.InputText1.ForeColor = System.Drawing.Color.FromArgb(190, 190, 190);
		this.InputText1.Location = new System.Drawing.Point(16, 150);
		this.InputText1.Margin = new System.Windows.Forms.Padding(4);
		this.InputText1.Name = "InputText1";
		this.InputText1.Size = new System.Drawing.Size(559, 23);
		this.InputText1.TabIndex = 5;
		this.L1.AutoSize = true;
		this.L1.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.L1.ForeColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.L1.Location = new System.Drawing.Point(16, 110);
		this.L1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.L1.Name = "L1";
		this.L1.Size = new System.Drawing.Size(185, 24);
		this.L1.TabIndex = 4;
		this.L1.Text = "New contact number";
		this.InputText0.BackColor = System.Drawing.Color.White;
		this.InputText0.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.InputText0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.InputText0.ForeColor = System.Drawing.Color.FromArgb(190, 190, 190);
		this.InputText0.Location = new System.Drawing.Point(16, 69);
		this.InputText0.Margin = new System.Windows.Forms.Padding(4);
		this.InputText0.Name = "InputText0";
		this.InputText0.Size = new System.Drawing.Size(559, 23);
		this.InputText0.TabIndex = 2;
		this.L0.AutoSize = true;
		this.L0.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.L0.ForeColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.L0.Location = new System.Drawing.Point(16, 28);
		this.L0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.L0.Name = "L0";
		this.L0.Size = new System.Drawing.Size(166, 24);
		this.L0.TabIndex = 1;
		this.L0.Text = "New contact name";
		this.TOpacity.Interval = 1;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(599, 241);
		base.Controls.Add(this.Panel1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Margin = new System.Windows.Forms.Padding(4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "AddNumber";
		base.Opacity = 0.0;
		base.ShowIcon = false;
		this.Text = "Add Number";
		base.TopMost = true;
		this.Panel1.ResumeLayout(false);
		this.Panel1.PerformLayout();
		base.ResumeLayout(false);
	}

	private void b_ok_Click(object sender, EventArgs e)
	{
	}

	public AddNumber()
	{
		base.Load += AddNumber_Load;
		RectInputText0 = new List<Rectangle>();
		InitializeComponent();
		Font = reso.f;
	}

	private void TOpacity_Tick(object sender, EventArgs e)
	{
		if (base.Opacity != 1.0)
		{
			base.Opacity += 0.1;
		}
		else
		{
			TOpacity.Enabled = false;
		}
	}

	private void AddNumber_Load(object sender, EventArgs e)
	{
		base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\12.ico");
		TOpacity.Interval = SpySettings.T_Interval;
		TOpacity.Enabled = true;
	}

	private void Panel1_Paint(object sender, PaintEventArgs e)
	{
		e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
		Color defaultColor_Foreground = SpySettings.DefaultColor_Foreground;
		if (RectInputText0.Count <= 0)
		{
			return;
		}
		foreach (Rectangle item in RectInputText0)
		{
			if (item.Width > 0)
			{
				e.Graphics.FillRectangle(new SolidBrush(defaultColor_Foreground), item);
			}
		}
	}

	private void DrakeUIButtonIcon3_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.OK;
	}
}
