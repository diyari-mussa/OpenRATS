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
public class basestyle : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeWidth_W7")]
	private DrakeWidth_W _DrakeWidth_W7;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeWidth_W8")]
	private DrakeWidth_W _DrakeWidth_W8;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("myscr")]
	private PictureBox _myscr;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("pinbtn")]
	private DrakeUIButtonIcon _pinbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("minibtn")]
	private DrakeUIButtonIcon _minibtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("closbtn")]
	private DrakeUIButtonIcon _closbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("myico")]
	private PictureBox _myico;

	private int Mx;

	private int Sw;

	private bool movX;

	private int Myyy;

	private int Sh;

	private bool movY;

	private bool keepmeto;

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
			MouseEventHandler value2 = Panel1_MouseDown;
			Panel panel = _Panel1;
			if (panel != null)
			{
				panel.MouseDown -= value2;
			}
			_Panel1 = value;
			panel = _Panel1;
			if (panel != null)
			{
				panel.MouseDown += value2;
			}
		}
	}

	internal virtual DrakeWidth_W DrakeWidth_W7
	{
		[CompilerGenerated]
		get
		{
			return _DrakeWidth_W7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = DrakeWidth_W7_MouseDown;
			MouseEventHandler value3 = DrakeWidth_W7_MouseMove;
			MouseEventHandler value4 = DrakeWidth_W7_MouseUp;
			DrakeWidth_W drakeWidth_W = _DrakeWidth_W7;
			if (drakeWidth_W != null)
			{
				drakeWidth_W.MouseDown -= value2;
				drakeWidth_W.MouseMove -= value3;
				drakeWidth_W.MouseUp -= value4;
			}
			_DrakeWidth_W7 = value;
			drakeWidth_W = _DrakeWidth_W7;
			if (drakeWidth_W != null)
			{
				drakeWidth_W.MouseDown += value2;
				drakeWidth_W.MouseMove += value3;
				drakeWidth_W.MouseUp += value4;
			}
		}
	}

	[field: AccessedThroughProperty("DrakeWidth_W6")]
	internal virtual DrakeWidth_W DrakeWidth_W6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeWidth_W DrakeWidth_W8
	{
		[CompilerGenerated]
		get
		{
			return _DrakeWidth_W8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = DrakeWidth_W8_MouseDown;
			MouseEventHandler value3 = DrakeWidth_W8_MouseMove;
			MouseEventHandler value4 = DrakeWidth_W8_MouseUp;
			DrakeWidth_W drakeWidth_W = _DrakeWidth_W8;
			if (drakeWidth_W != null)
			{
				drakeWidth_W.MouseDown -= value2;
				drakeWidth_W.MouseMove -= value3;
				drakeWidth_W.MouseUp -= value4;
			}
			_DrakeWidth_W8 = value;
			drakeWidth_W = _DrakeWidth_W8;
			if (drakeWidth_W != null)
			{
				drakeWidth_W.MouseDown += value2;
				drakeWidth_W.MouseMove += value3;
				drakeWidth_W.MouseUp += value4;
			}
		}
	}

	[field: AccessedThroughProperty("DrakeWidth_W5")]
	internal virtual DrakeWidth_W DrakeWidth_W5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeWidth_W1")]
	internal virtual DrakeWidth_W DrakeWidth_W1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public virtual PictureBox myscr
	{
		[CompilerGenerated]
		get
		{
			return _myscr;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Panel1_MouseDown;
			PictureBox pictureBox = _myscr;
			if (pictureBox != null)
			{
				pictureBox.MouseDown -= value2;
			}
			_myscr = value;
			pictureBox = _myscr;
			if (pictureBox != null)
			{
				pictureBox.MouseDown += value2;
			}
		}
	}

	public virtual DrakeUIButtonIcon pinbtn
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
			EventHandler value2 = pinme;
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

	public virtual DrakeUIButtonIcon minibtn
	{
		[CompilerGenerated]
		get
		{
			return _minibtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon6_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _minibtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_minibtn = value;
			drakeUIButtonIcon = _minibtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	public virtual DrakeUIButtonIcon closbtn
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
			EventHandler value2 = DrakeUIButtonIcon2_Click;
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
			MouseEventHandler value2 = Panel1_MouseDown;
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

	[field: AccessedThroughProperty("mytitle")]
	public virtual Label mytitle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("spl1")]
	internal virtual DrakeWidth_W spl1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("spl2")]
	internal virtual DrakeWidth_W spl2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("spl144")]
	internal virtual DrakeWidth_W spl144
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tobpanelsti")]
	public virtual Panel tobpanelsti
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

	[field: AccessedThroughProperty("baseloader")]
	internal virtual DrakeUILoadingBar baseloader
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public basestyle()
	{
		base.FormClosing += basestyle_FormClosing;
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
		this.Panel1 = new System.Windows.Forms.Panel();
		this.pinbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.spl1 = new DrakeUI.Framework.DrakeWidth_W();
		this.minibtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.spl2 = new DrakeUI.Framework.DrakeWidth_W();
		this.myscr = new System.Windows.Forms.PictureBox();
		this.spl144 = new DrakeUI.Framework.DrakeWidth_W();
		this.myico = new System.Windows.Forms.PictureBox();
		this.closbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeWidth_W7 = new DrakeUI.Framework.DrakeWidth_W();
		this.DrakeWidth_W6 = new DrakeUI.Framework.DrakeWidth_W();
		this.DrakeWidth_W8 = new DrakeUI.Framework.DrakeWidth_W();
		this.DrakeWidth_W5 = new DrakeUI.Framework.DrakeWidth_W();
		this.DrakeWidth_W1 = new DrakeUI.Framework.DrakeWidth_W();
		this.mytitle = new System.Windows.Forms.Label();
		this.tobpanelsti = new System.Windows.Forms.Panel();
		this.DrakeWidth_W2 = new DrakeUI.Framework.DrakeWidth_W();
		this.baseloader = new DrakeUI.Framework.DrakeUILoadingBar();
		this.Panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.myscr).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.myico).BeginInit();
		this.tobpanelsti.SuspendLayout();
		base.SuspendLayout();
		this.Panel1.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel1.Controls.Add(this.baseloader);
		this.Panel1.Controls.Add(this.DrakeWidth_W2);
		this.Panel1.Controls.Add(this.pinbtn);
		this.Panel1.Controls.Add(this.spl1);
		this.Panel1.Controls.Add(this.minibtn);
		this.Panel1.Controls.Add(this.spl2);
		this.Panel1.Controls.Add(this.myscr);
		this.Panel1.Controls.Add(this.spl144);
		this.Panel1.Controls.Add(this.myico);
		this.Panel1.Controls.Add(this.closbtn);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel1.Location = new System.Drawing.Point(2, 2);
		this.Panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.Panel1.Name = EXGuarder._6C342B5C;
		this.Panel1.Padding = new System.Windows.Forms.Padding(5);
		this.Panel1.Size = new System.Drawing.Size(758, 35);
		this.Panel1.TabIndex = 33;
		this.pinbtn.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.pinbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.pinbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.pinbtn.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.pinbtn.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.pinbtn.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.pinbtn.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.pinbtn.Font = new System.Drawing.Font(EXGuarder._23450376, 12f);
		this.pinbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.pinbtn.ForeDisableColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.pinbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.pinbtn.Location = new System.Drawing.Point(632, 5);
		this.pinbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.pinbtn.Name = EXGuarder._36446244;
		this.pinbtn.Radius = 15;
		this.pinbtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.pinbtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.pinbtn.RectDisableColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.pinbtn.RectHoverColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.pinbtn.RectPressColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.pinbtn.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.pinbtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.pinbtn.Size = new System.Drawing.Size(37, 25);
		this.pinbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.pinbtn.Symbol = 57474;
		this.pinbtn.SymbolSize = 19;
		this.pinbtn.TabIndex = 8;
		this.spl1.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.spl1.Dock = System.Windows.Forms.DockStyle.Right;
		this.spl1.Location = new System.Drawing.Point(669, 5);
		this.spl1.Name = EXGuarder._47422126;
		this.spl1.Size = new System.Drawing.Size(5, 25);
		this.spl1.TabIndex = 37;
		this.minibtn.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.minibtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.minibtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.minibtn.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.minibtn.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.minibtn.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.minibtn.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.minibtn.Font = new System.Drawing.Font(EXGuarder._23450376, 12f);
		this.minibtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.minibtn.ForeDisableColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.minibtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.minibtn.Location = new System.Drawing.Point(674, 5);
		this.minibtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.minibtn.Name = EXGuarder._6A6E1F09;
		this.minibtn.Radius = 15;
		this.minibtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.minibtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.minibtn.RectDisableColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.minibtn.RectHoverColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.minibtn.RectPressColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.minibtn.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.minibtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.minibtn.Size = new System.Drawing.Size(37, 25);
		this.minibtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.minibtn.Symbol = 62161;
		this.minibtn.SymbolSize = 19;
		this.minibtn.TabIndex = 7;
		this.spl2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.spl2.Dock = System.Windows.Forms.DockStyle.Right;
		this.spl2.Location = new System.Drawing.Point(711, 5);
		this.spl2.Name = EXGuarder._57694520;
		this.spl2.Size = new System.Drawing.Size(5, 25);
		this.spl2.TabIndex = 36;
		this.myscr.Dock = System.Windows.Forms.DockStyle.Left;
		this.myscr.Location = new System.Drawing.Point(53, 5);
		this.myscr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.myscr.Name = EXGuarder._22000835;
		this.myscr.Size = new System.Drawing.Size(39, 25);
		this.myscr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.myscr.TabIndex = 6;
		this.myscr.TabStop = false;
		this.spl144.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.spl144.Dock = System.Windows.Forms.DockStyle.Left;
		this.spl144.Location = new System.Drawing.Point(43, 5);
		this.spl144.Name = EXGuarder._1E277072;
		this.spl144.Size = new System.Drawing.Size(10, 25);
		this.spl144.TabIndex = 38;
		this.myico.Dock = System.Windows.Forms.DockStyle.Left;
		this.myico.Location = new System.Drawing.Point(5, 5);
		this.myico.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.myico.Name = EXGuarder._41692555;
		this.myico.Size = new System.Drawing.Size(38, 25);
		this.myico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.myico.TabIndex = 5;
		this.myico.TabStop = false;
		this.closbtn.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.closbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.closbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.closbtn.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.closbtn.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.closbtn.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.closbtn.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.closbtn.Font = new System.Drawing.Font(EXGuarder._23450376, 12f);
		this.closbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.closbtn.ForeDisableColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.closbtn.ForeHoverColor = System.Drawing.Color.Red;
		this.closbtn.Location = new System.Drawing.Point(716, 5);
		this.closbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.closbtn.Name = EXGuarder._274F496A;
		this.closbtn.Radius = 15;
		this.closbtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.closbtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.closbtn.RectDisableColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.closbtn.RectHoverColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.closbtn.RectPressColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.closbtn.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.closbtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.closbtn.Size = new System.Drawing.Size(37, 25);
		this.closbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.closbtn.Symbol = 61453;
		this.closbtn.SymbolSize = 19;
		this.closbtn.TabIndex = 4;
		this.DrakeWidth_W7.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.DrakeWidth_W7.Cursor = System.Windows.Forms.Cursors.SizeWE;
		this.DrakeWidth_W7.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeWidth_W7.Location = new System.Drawing.Point(760, 0);
		this.DrakeWidth_W7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.DrakeWidth_W7.Name = EXGuarder._51333A17;
		this.DrakeWidth_W7.Size = new System.Drawing.Size(2, 574);
		this.DrakeWidth_W7.TabIndex = 34;
		this.DrakeWidth_W6.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.DrakeWidth_W6.Dock = System.Windows.Forms.DockStyle.Top;
		this.DrakeWidth_W6.Location = new System.Drawing.Point(0, 0);
		this.DrakeWidth_W6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.DrakeWidth_W6.Name = EXGuarder._556A7572;
		this.DrakeWidth_W6.Size = new System.Drawing.Size(760, 2);
		this.DrakeWidth_W6.TabIndex = 35;
		this.DrakeWidth_W8.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.DrakeWidth_W8.Cursor = System.Windows.Forms.Cursors.SizeNS;
		this.DrakeWidth_W8.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.DrakeWidth_W8.Location = new System.Drawing.Point(0, 572);
		this.DrakeWidth_W8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.DrakeWidth_W8.Name = EXGuarder._5960744C;
		this.DrakeWidth_W8.Size = new System.Drawing.Size(760, 2);
		this.DrakeWidth_W8.TabIndex = 36;
		this.DrakeWidth_W5.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.DrakeWidth_W5.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeWidth_W5.Location = new System.Drawing.Point(0, 2);
		this.DrakeWidth_W5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.DrakeWidth_W5.Name = EXGuarder._27281A0A;
		this.DrakeWidth_W5.Size = new System.Drawing.Size(2, 570);
		this.DrakeWidth_W5.TabIndex = 37;
		this.DrakeWidth_W1.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W1.Dock = System.Windows.Forms.DockStyle.Top;
		this.DrakeWidth_W1.Location = new System.Drawing.Point(2, 37);
		this.DrakeWidth_W1.Name = EXGuarder._1A6E126C;
		this.DrakeWidth_W1.Size = new System.Drawing.Size(758, 1);
		this.DrakeWidth_W1.TabIndex = 38;
		this.mytitle.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.mytitle.Dock = System.Windows.Forms.DockStyle.Fill;
		this.mytitle.Font = new System.Drawing.Font(EXGuarder._23450376, 8.5f);
		this.mytitle.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.mytitle.Location = new System.Drawing.Point(5, 5);
		this.mytitle.Name = EXGuarder._27103F5F;
		this.mytitle.Size = new System.Drawing.Size(748, 19);
		this.mytitle.TabIndex = 4;
		this.mytitle.Text = EXGuarder._475D420E;
		this.mytitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.tobpanelsti.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.tobpanelsti.Controls.Add(this.mytitle);
		this.tobpanelsti.Dock = System.Windows.Forms.DockStyle.Top;
		this.tobpanelsti.Font = new System.Drawing.Font(EXGuarder._23450376, 8f);
		this.tobpanelsti.Location = new System.Drawing.Point(2, 38);
		this.tobpanelsti.Name = EXGuarder._0D574B57;
		this.tobpanelsti.Padding = new System.Windows.Forms.Padding(5);
		this.tobpanelsti.Size = new System.Drawing.Size(758, 29);
		this.tobpanelsti.TabIndex = 39;
		this.DrakeWidth_W2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W2.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeWidth_W2.Location = new System.Drawing.Point(92, 5);
		this.DrakeWidth_W2.Name = EXGuarder._7061206F;
		this.DrakeWidth_W2.Size = new System.Drawing.Size(10, 25);
		this.DrakeWidth_W2.TabIndex = 39;
		this.baseloader.Dock = System.Windows.Forms.DockStyle.Left;
		this.baseloader.Enabled = false;
		this.baseloader.Font = new System.Drawing.Font(EXGuarder._23450376, 12f);
		this.baseloader.ForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.baseloader.Location = new System.Drawing.Point(102, 5);
		this.baseloader.Name = EXGuarder._6B64210D;
		this.baseloader.Size = new System.Drawing.Size(45, 25);
		this.baseloader.Style = DrakeUI.Framework.UIStyle.Custom;
		this.baseloader.TabIndex = 62;
		this.baseloader.Text = EXGuarder._3E0C2440;
		this.baseloader.Visible = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 18f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		base.ClientSize = new System.Drawing.Size(762, 574);
		base.ControlBox = false;
		base.Controls.Add(this.tobpanelsti);
		base.Controls.Add(this.DrakeWidth_W1);
		base.Controls.Add(this.Panel1);
		base.Controls.Add(this.DrakeWidth_W5);
		base.Controls.Add(this.DrakeWidth_W8);
		base.Controls.Add(this.DrakeWidth_W6);
		base.Controls.Add(this.DrakeWidth_W7);
		this.DoubleBuffered = true;
		this.Font = new System.Drawing.Font(EXGuarder._23450376, 9f);
		this.ForeColor = System.Drawing.Color.White;
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = EXGuarder._4164261E;
		this.Text = EXGuarder._4164261E;
		this.Panel1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.myscr).EndInit();
		((System.ComponentModel.ISupportInitialize)this.myico).EndInit();
		this.tobpanelsti.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	private void Panel1_MouseDown(object sender, MouseEventArgs e)
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

	private void DrakeWidth_W7_MouseDown(object sender, MouseEventArgs e)
	{
		movX = true;
		Mx = Control.MousePosition.X;
		Sw = base.Width;
	}

	private void DrakeWidth_W7_MouseMove(object sender, MouseEventArgs e)
	{
		if (movX)
		{
			base.Width = checked(Control.MousePosition.X - Mx + Sw);
		}
	}

	private void DrakeWidth_W7_MouseUp(object sender, MouseEventArgs e)
	{
		movX = false;
	}

	private void DrakeWidth_W8_MouseDown(object sender, MouseEventArgs e)
	{
		movY = true;
		Myyy = Control.MousePosition.Y;
		Sh = base.Height;
	}

	private void DrakeWidth_W8_MouseMove(object sender, MouseEventArgs e)
	{
		if (movY)
		{
			base.Height = checked(Control.MousePosition.Y - Myyy + Sh);
		}
	}

	private void DrakeWidth_W8_MouseUp(object sender, MouseEventArgs e)
	{
		movY = false;
	}

	private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void DrakeUIButtonIcon6_Click(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	internal void pinme(object sender, EventArgs e)
	{
		if (keepmeto)
		{
			pinbtn.ForeColor = Color.DeepSkyBlue;
			Nativz.SetWindowPos(hWndInsertAfter: new IntPtr(-1), hWnd: base.Handle, X: 0, Y: 0, cx: 0, cy: 0, uFlags: 3u);
			keepmeto = false;
		}
		else
		{
			pinbtn.ForeColor = Color.FromArgb(145, 163, 182);
			Nativz.SetWindowPos(hWndInsertAfter: new IntPtr(-2), hWnd: base.Handle, X: 0, Y: 0, cx: 0, cy: 0, uFlags: 3u);
			keepmeto = true;
		}
	}

	private void basestyle_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (myscr.Image != null)
		{
			myscr.Image = null;
		}
		if (myico.Image != null)
		{
			myico.Image = null;
		}
		baseloader.Enabled = false;
		baseloader.Dispose();
	}
}
