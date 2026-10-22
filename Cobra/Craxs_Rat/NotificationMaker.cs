using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Craxs_Rat.sockets;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat;

[DesignerGenerated]
public class NotificationMaker : Form
{
	private IContainer components;

	[AccessedThroughProperty("DrakeUIAvatar1")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DrakeUIAvatar _DrakeUIAvatar1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Label35")]
	private Label _Label35;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("typecomp")]
	private DrakeUIComboBox _typecomp;

	public List<Client> listclients;

	public List<Client> SelectedList;

	public string type;

	public string Openthis;

	internal virtual DrakeUIAvatar DrakeUIAvatar1
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIAvatar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIAvatar1_Click;
			DrakeUIAvatar drakeUIAvatar = _DrakeUIAvatar1;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click -= value2;
			}
			_DrakeUIAvatar1 = value;
			drakeUIAvatar = _DrakeUIAvatar1;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DrakeUIToolTip1")]
	internal virtual DrakeUIToolTip DrakeUIToolTip1
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

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeUIAvatar2")]
	internal virtual DrakeUIAvatar DrakeUIAvatar2
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

	[field: AccessedThroughProperty("DGVC")]
	internal virtual DataGridView DGVC
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("seleccli")]
	internal virtual DataGridViewCheckBoxColumn seleccli
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cliico")]
	internal virtual DataGridViewImageColumn cliico
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cliename")]
	internal virtual DataGridViewTextBoxColumn cliename
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SplitContainer1")]
	internal virtual SplitContainer SplitContainer1
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

	internal virtual Label Label35
	{
		[CompilerGenerated]
		get
		{
			return _Label35;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Label35_Click;
			Label label = _Label35;
			if (label != null)
			{
				label.Click -= value2;
			}
			_Label35 = value;
			label = _Label35;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("toopentext")]
	internal virtual DrakeUITextBox toopentext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TAlabel")]
	internal virtual Label TAlabel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIComboBox typecomp
	{
		[CompilerGenerated]
		get
		{
			return _typecomp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Actonscompo_SelectedIndexChanged;
			DrakeUIComboBox drakeUIComboBox = _typecomp;
			if (drakeUIComboBox != null)
			{
				drakeUIComboBox.SelectedIndexChanged -= value2;
			}
			_typecomp = value;
			drakeUIComboBox = _typecomp;
			if (drakeUIComboBox != null)
			{
				drakeUIComboBox.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("titletext")]
	internal virtual DrakeUITextBox titletext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("checkusrcraxs")]
	internal virtual DrakeUICheckBox checkusrcraxs
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
		this.components = new System.ComponentModel.Container();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
		this.DrakeUIAvatar1 = new DrakeUI.Framework.DrakeUIAvatar();
		this.msgtext = new DrakeUI.Framework.DrakeUITextBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.DrakeUIToolTip1 = new DrakeUI.Framework.DrakeUIToolTip(this.components);
		this.DrakeUIAvatar2 = new DrakeUI.Framework.DrakeUIAvatar();
		this.titletext = new DrakeUI.Framework.DrakeUITextBox();
		this.Label4 = new System.Windows.Forms.Label();
		this.DGVC = new System.Windows.Forms.DataGridView();
		this.seleccli = new System.Windows.Forms.DataGridViewCheckBoxColumn();
		this.cliico = new System.Windows.Forms.DataGridViewImageColumn();
		this.cliename = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
		this.checkusrcraxs = new DrakeUI.Framework.DrakeUICheckBox();
		this.toopentext = new DrakeUI.Framework.DrakeUITextBox();
		this.TAlabel = new System.Windows.Forms.Label();
		this.typecomp = new DrakeUI.Framework.DrakeUIComboBox();
		this.Label35 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		((System.ComponentModel.ISupportInitialize)this.DGVC).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.SplitContainer1).BeginInit();
		this.SplitContainer1.Panel1.SuspendLayout();
		this.SplitContainer1.Panel2.SuspendLayout();
		this.SplitContainer1.SuspendLayout();
		base.SuspendLayout();
		this.DrakeUIAvatar1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.DrakeUIAvatar1.AvatarSize = 30;
		this.DrakeUIAvatar1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIAvatar1.FillColor = System.Drawing.Color.Black;
		this.DrakeUIAvatar1.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIAvatar1.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIAvatar1.Location = new System.Drawing.Point(223, 540);
		this.DrakeUIAvatar1.Name = "DrakeUIAvatar1";
		this.DrakeUIAvatar1.Size = new System.Drawing.Size(60, 60);
		this.DrakeUIAvatar1.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIAvatar1.Symbol = 61912;
		this.DrakeUIAvatar1.SymbolSize = 30;
		this.DrakeUIAvatar1.TabIndex = 2;
		this.DrakeUIAvatar1.Text = "DrakeUIAvatar1";
		this.DrakeUIToolTip1.SetToolTip(this.DrakeUIAvatar1, "Save");
		this.msgtext.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.msgtext.FillColor = System.Drawing.Color.Black;
		this.msgtext.Font = new System.Drawing.Font("Calibri", 12f);
		this.msgtext.ForeColor = System.Drawing.Color.SkyBlue;
		this.msgtext.Location = new System.Drawing.Point(44, 230);
		this.msgtext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.msgtext.Maximum = 2147483647.0;
		this.msgtext.Minimum = -2147483648.0;
		this.msgtext.Name = "msgtext";
		this.msgtext.Padding = new System.Windows.Forms.Padding(5);
		this.msgtext.RectColor = System.Drawing.Color.SkyBlue;
		this.msgtext.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.msgtext.Size = new System.Drawing.Size(220, 32);
		this.msgtext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.msgtext.StyleCustomMode = true;
		this.msgtext.TabIndex = 0;
		this.msgtext.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.msgtext.Watermark = "New Message";
		this.Label2.AutoSize = true;
		this.Label2.BackColor = System.Drawing.Color.Transparent;
		this.Label2.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold);
		this.Label2.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label2.Location = new System.Drawing.Point(40, 309);
		this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(72, 24);
		this.Label2.TabIndex = 20;
		this.Label2.Text = "Actions";
		this.Label1.AutoSize = true;
		this.Label1.BackColor = System.Drawing.Color.Transparent;
		this.Label1.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold);
		this.Label1.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label1.Location = new System.Drawing.Point(40, 201);
		this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(129, 24);
		this.Label1.TabIndex = 21;
		this.Label1.Text = "Message body";
		this.DrakeUIToolTip1.BackColor = System.Drawing.Color.FromArgb(54, 54, 54);
		this.DrakeUIToolTip1.ForeColor = System.Drawing.Color.FromArgb(239, 239, 239);
		this.DrakeUIToolTip1.OwnerDraw = true;
		this.DrakeUIAvatar2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.DrakeUIAvatar2.AvatarSize = 30;
		this.DrakeUIAvatar2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIAvatar2.FillColor = System.Drawing.Color.Black;
		this.DrakeUIAvatar2.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIAvatar2.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIAvatar2.Location = new System.Drawing.Point(12, 540);
		this.DrakeUIAvatar2.Name = "DrakeUIAvatar2";
		this.DrakeUIAvatar2.Size = new System.Drawing.Size(60, 60);
		this.DrakeUIAvatar2.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIAvatar2.Symbol = 61453;
		this.DrakeUIAvatar2.SymbolSize = 30;
		this.DrakeUIAvatar2.TabIndex = 22;
		this.DrakeUIAvatar2.Text = "DrakeUIAvatar2";
		this.DrakeUIToolTip1.SetToolTip(this.DrakeUIAvatar2, "Cancel");
		this.titletext.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.titletext.FillColor = System.Drawing.Color.Black;
		this.titletext.Font = new System.Drawing.Font("Calibri", 12f);
		this.titletext.ForeColor = System.Drawing.Color.SkyBlue;
		this.titletext.Location = new System.Drawing.Point(44, 109);
		this.titletext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.titletext.Maximum = 2147483647.0;
		this.titletext.Minimum = -2147483648.0;
		this.titletext.Name = "titletext";
		this.titletext.Padding = new System.Windows.Forms.Padding(5);
		this.titletext.RectColor = System.Drawing.Color.SkyBlue;
		this.titletext.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.titletext.Size = new System.Drawing.Size(220, 32);
		this.titletext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.titletext.StyleCustomMode = true;
		this.titletext.TabIndex = 26;
		this.titletext.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.titletext.Watermark = "Whatsapp";
		this.Label4.AutoSize = true;
		this.Label4.BackColor = System.Drawing.Color.Transparent;
		this.Label4.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold);
		this.Label4.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label4.Location = new System.Drawing.Point(40, 80);
		this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(47, 24);
		this.Label4.TabIndex = 27;
		this.Label4.Text = "Title";
		this.DGVC.AllowUserToAddRows = false;
		this.DGVC.AllowUserToDeleteRows = false;
		this.DGVC.AllowUserToResizeColumns = false;
		this.DGVC.AllowUserToResizeRows = false;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.Color.Black;
		this.DGVC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.DGVC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.DGVC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DGVC.BackgroundColor = System.Drawing.Color.Black;
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 7.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGVC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
		this.DGVC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.DGVC.ColumnHeadersVisible = false;
		this.DGVC.Columns.AddRange(this.seleccli, this.cliico, this.cliename);
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 7.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
		dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.DGVC.DefaultCellStyle = dataGridViewCellStyle3;
		this.DGVC.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DGVC.GridColor = System.Drawing.Color.Black;
		this.DGVC.Location = new System.Drawing.Point(0, 0);
		this.DGVC.Name = "DGVC";
		this.DGVC.ReadOnly = true;
		dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 7.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
		dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGVC.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
		this.DGVC.RowHeadersVisible = false;
		dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle5.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
		this.DGVC.RowsDefaultCellStyle = dataGridViewCellStyle5;
		this.DGVC.RowTemplate.Height = 24;
		this.DGVC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGVC.Size = new System.Drawing.Size(708, 612);
		this.DGVC.TabIndex = 28;
		this.seleccli.FillWeight = 67.85324f;
		this.seleccli.HeaderText = "selectme";
		this.seleccli.Name = "seleccli";
		this.seleccli.ReadOnly = true;
		this.cliico.FillWeight = 98.98477f;
		this.cliico.HeaderText = "icon";
		this.cliico.Name = "cliico";
		this.cliico.ReadOnly = true;
		this.cliename.FillWeight = 133.162f;
		this.cliename.HeaderText = "Name";
		this.cliename.Name = "cliename";
		this.cliename.ReadOnly = true;
		this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.SplitContainer1.Location = new System.Drawing.Point(0, 0);
		this.SplitContainer1.Name = "SplitContainer1";
		this.SplitContainer1.Panel1.BackColor = System.Drawing.Color.Black;
		this.SplitContainer1.Panel1.Controls.Add(this.checkusrcraxs);
		this.SplitContainer1.Panel1.Controls.Add(this.toopentext);
		this.SplitContainer1.Panel1.Controls.Add(this.TAlabel);
		this.SplitContainer1.Panel1.Controls.Add(this.typecomp);
		this.SplitContainer1.Panel1.Controls.Add(this.Label35);
		this.SplitContainer1.Panel1.Controls.Add(this.Label3);
		this.SplitContainer1.Panel1.Controls.Add(this.titletext);
		this.SplitContainer1.Panel1.Controls.Add(this.DrakeUIAvatar2);
		this.SplitContainer1.Panel1.Controls.Add(this.DrakeUIAvatar1);
		this.SplitContainer1.Panel1.Controls.Add(this.Label4);
		this.SplitContainer1.Panel1.Controls.Add(this.msgtext);
		this.SplitContainer1.Panel1.Controls.Add(this.Label2);
		this.SplitContainer1.Panel1.Controls.Add(this.Label1);
		this.SplitContainer1.Panel2.Controls.Add(this.DGVC);
		this.SplitContainer1.Size = new System.Drawing.Size(1017, 612);
		this.SplitContainer1.SplitterDistance = 305;
		this.SplitContainer1.TabIndex = 30;
		this.checkusrcraxs.CheckBoxColor = System.Drawing.Color.SkyBlue;
		this.checkusrcraxs.Cursor = System.Windows.Forms.Cursors.Hand;
		this.checkusrcraxs.Enabled = false;
		this.checkusrcraxs.Font = new System.Drawing.Font("Calibri", 12f);
		this.checkusrcraxs.ForeColor = System.Drawing.Color.SkyBlue;
		this.checkusrcraxs.Location = new System.Drawing.Point(44, 497);
		this.checkusrcraxs.Name = "checkusrcraxs";
		this.checkusrcraxs.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.checkusrcraxs.Size = new System.Drawing.Size(220, 29);
		this.checkusrcraxs.Style = DrakeUI.Framework.UIStyle.Custom;
		this.checkusrcraxs.TabIndex = 87;
		this.checkusrcraxs.Text = "use Cobra browser";
		this.checkusrcraxs.Visible = false;
		this.toopentext.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.toopentext.Enabled = false;
		this.toopentext.FillColor = System.Drawing.Color.Black;
		this.toopentext.Font = new System.Drawing.Font("Calibri", 12f);
		this.toopentext.ForeColor = System.Drawing.Color.SkyBlue;
		this.toopentext.Location = new System.Drawing.Point(44, 457);
		this.toopentext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.toopentext.Maximum = 2147483647.0;
		this.toopentext.Minimum = -2147483648.0;
		this.toopentext.Name = "toopentext";
		this.toopentext.Padding = new System.Windows.Forms.Padding(5);
		this.toopentext.RectColor = System.Drawing.Color.SkyBlue;
		this.toopentext.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.toopentext.Size = new System.Drawing.Size(220, 32);
		this.toopentext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.toopentext.StyleCustomMode = true;
		this.toopentext.TabIndex = 72;
		this.toopentext.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.toopentext.Visible = false;
		this.toopentext.Watermark = "";
		this.TAlabel.AutoSize = true;
		this.TAlabel.BackColor = System.Drawing.Color.Transparent;
		this.TAlabel.Enabled = false;
		this.TAlabel.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold);
		this.TAlabel.ForeColor = System.Drawing.Color.SkyBlue;
		this.TAlabel.Location = new System.Drawing.Point(40, 428);
		this.TAlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.TAlabel.Name = "TAlabel";
		this.TAlabel.Size = new System.Drawing.Size(87, 24);
		this.TAlabel.TabIndex = 73;
		this.TAlabel.Text = "link or ID";
		this.TAlabel.Visible = false;
		this.typecomp.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.typecomp.FillColor = System.Drawing.Color.Black;
		this.typecomp.Font = new System.Drawing.Font("Calibri", 11f);
		this.typecomp.ForeColor = System.Drawing.Color.SkyBlue;
		this.typecomp.Items.AddRange(new object[3] { "Nothing", "Open Apk", "Open Link" });
		this.typecomp.Location = new System.Drawing.Point(44, 342);
		this.typecomp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.typecomp.MinimumSize = new System.Drawing.Size(63, 0);
		this.typecomp.Name = "typecomp";
		this.typecomp.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
		this.typecomp.RectColor = System.Drawing.Color.SkyBlue;
		this.typecomp.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.typecomp.Size = new System.Drawing.Size(220, 30);
		this.typecomp.Style = DrakeUI.Framework.UIStyle.Custom;
		this.typecomp.TabIndex = 71;
		this.typecomp.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
		this.Label35.AutoSize = true;
		this.Label35.BackColor = System.Drawing.Color.Transparent;
		this.Label35.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Label35.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label35.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label35.Location = new System.Drawing.Point(272, 342);
		this.Label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label35.Name = "Label35";
		this.Label35.Size = new System.Drawing.Size(19, 24);
		this.Label35.TabIndex = 70;
		this.Label35.Text = "?";
		this.Label3.BackColor = System.Drawing.Color.Transparent;
		this.Label3.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label3.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold);
		this.Label3.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label3.Location = new System.Drawing.Point(0, 0);
		this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(305, 64);
		this.Label3.TabIndex = 28;
		this.Label3.Text = "Create a notification";
		this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 15f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(1017, 612);
		base.Controls.Add(this.SplitContainer1);
		this.Font = new System.Drawing.Font("Calibri", 7.8f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
		base.Name = "NotificationMaker";
		base.ShowIcon = false;
		this.Text = "Notification Maker";
		base.TopMost = true;
		((System.ComponentModel.ISupportInitialize)this.DGVC).EndInit();
		this.SplitContainer1.Panel1.ResumeLayout(false);
		this.SplitContainer1.Panel1.PerformLayout();
		this.SplitContainer1.Panel2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.SplitContainer1).EndInit();
		this.SplitContainer1.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	public NotificationMaker(List<Client> L)
	{
		base.Load += NotificationMaker_Load;
		listclients = new List<Client>();
		SelectedList = new List<Client>();
		type = "0";
		Openthis = "null";
		InitializeComponent();
		listclients = L;
	}

	private void translateme()
	{
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "CN", TextCompare: false) == 0)
			{
				Label1.Text = Codes.Translate(Label1.Text, "en", "zh");
				Label2.Text = Codes.Translate(Label2.Text, "en", "zh");
				Label3.Text = Codes.Translate(Label3.Text, "en", "zh");
				Label4.Text = Codes.Translate(Label4.Text, "en", "zh");
				checkusrcraxs.Text = "使用craxs浏览器";
			}
		}
		else
		{
			Label1.Text = Codes.Translate(Label1.Text, "en", "ar");
			Label2.Text = Codes.Translate(Label2.Text, "en", "ar");
			Label3.Text = Codes.Translate(Label3.Text, "en", "ar");
			Label4.Text = Codes.Translate(Label4.Text, "en", "ar");
			checkusrcraxs.Text = "استخدم متصفح craxs";
		}
	}

	private void NotificationMaker_Load(object sender, EventArgs e)
	{
		if (listclients.Count > 0)
		{
			foreach (Client listclient in listclients)
			{
				int index = DGVC.Rows.Add(true, listclient.Wallpaper, listclient.ClientName);
				DGVC.Rows[index].Tag = listclient;
			}
		}
		typecomp.Text = "Nothing";
	}

	private void Label35_Click(object sender, EventArgs e)
	{
		Interaction.MsgBox("what happen after user click the notification ?");
	}

	private void Actonscompo_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (Operators.CompareString(typecomp.Text, "Nothing", TextCompare: false) == 0)
		{
			TAlabel.Enabled = false;
			TAlabel.Visible = false;
			toopentext.Enabled = false;
			toopentext.Visible = false;
			toopentext.Text = "";
			TAlabel.Text = "";
			checkusrcraxs.Checked = false;
			checkusrcraxs.Enabled = false;
			checkusrcraxs.Visible = false;
		}
		else if (Operators.CompareString(typecomp.Text, "Open Apk", TextCompare: false) == 0)
		{
			TAlabel.Enabled = true;
			TAlabel.Visible = true;
			toopentext.Enabled = true;
			toopentext.Visible = true;
			toopentext.Text = "";
			toopentext.Watermark = "com.whatsapp";
			TAlabel.Text = "App ID";
			checkusrcraxs.Checked = false;
			checkusrcraxs.Enabled = false;
			checkusrcraxs.Visible = false;
		}
		else if (Operators.CompareString(typecomp.Text, "Open Link", TextCompare: false) == 0)
		{
			TAlabel.Enabled = true;
			TAlabel.Visible = true;
			toopentext.Enabled = true;
			toopentext.Visible = true;
			toopentext.Text = "";
			toopentext.Watermark = "www.whatsapp.com";
			TAlabel.Text = "Website Link";
			checkusrcraxs.Checked = true;
			checkusrcraxs.Enabled = true;
			checkusrcraxs.Visible = true;
		}
	}

	private void DrakeUIAvatar1_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(typecomp.Text, "Nothing", TextCompare: false) == 0)
		{
			type = "0";
			Openthis = "null";
		}
		else if (Operators.CompareString(typecomp.Text, "Open Apk", TextCompare: false) == 0)
		{
			if (!Codes.IsValidPackageName(toopentext.Text))
			{
				CraxsAlert.ShowWarning("Invalid APK package name");
				return;
			}
			type = "1";
			Openthis = toopentext.Text;
		}
		else if (Operators.CompareString(typecomp.Text, "Open Link", TextCompare: false) == 0)
		{
			type = "2";
			Openthis = toopentext.Text;
		}
		if (DGVC.Rows.Count > 0)
		{
			foreach (DataGridViewRow item in (IEnumerable)DGVC.Rows)
			{
				try
				{
					SelectedList.Add((Client)item.Tag);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
		base.DialogResult = DialogResult.OK;
		Close();
	}
}
