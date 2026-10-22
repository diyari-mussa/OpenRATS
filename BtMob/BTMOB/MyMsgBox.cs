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
public class MyMsgBox : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("toppanel")]
	private Panel _toppanel;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("msgtitle")]
	private DrakeUILabel _msgtitle;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeWidth_W1")]
	private DrakeWidth_W _DrakeWidth_W1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("msgimg")]
	private PictureBox _msgimg;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Panel3")]
	private Panel _Panel3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("msgbody")]
	private DrakeUILabel _msgbody;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("okbtn")]
	private DrakeUIButtonIcon _okbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("nobtn")]
	private DrakeUIButtonIcon _nobtn;

	internal virtual Panel toppanel
	{
		[CompilerGenerated]
		get
		{
			return _toppanel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = msgbody_MouseDown;
			Panel panel = _toppanel;
			if (panel != null)
			{
				panel.MouseDown -= value2;
			}
			_toppanel = value;
			panel = _toppanel;
			if (panel != null)
			{
				panel.MouseDown += value2;
			}
		}
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
			MouseEventHandler value2 = msgbody_MouseDown;
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
			MouseEventHandler value2 = msgbody_MouseDown;
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

	internal virtual DrakeWidth_W DrakeWidth_W1
	{
		[CompilerGenerated]
		get
		{
			return _DrakeWidth_W1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = msgbody_MouseDown;
			DrakeWidth_W drakeWidth_W = _DrakeWidth_W1;
			if (drakeWidth_W != null)
			{
				drakeWidth_W.MouseDown -= value2;
			}
			_DrakeWidth_W1 = value;
			drakeWidth_W = _DrakeWidth_W1;
			if (drakeWidth_W != null)
			{
				drakeWidth_W.MouseDown += value2;
			}
		}
	}

	internal virtual PictureBox msgimg
	{
		[CompilerGenerated]
		get
		{
			return _msgimg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = msgbody_MouseDown;
			PictureBox pictureBox = _msgimg;
			if (pictureBox != null)
			{
				pictureBox.MouseDown -= value2;
			}
			_msgimg = value;
			pictureBox = _msgimg;
			if (pictureBox != null)
			{
				pictureBox.MouseDown += value2;
			}
		}
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
			MouseEventHandler value2 = msgbody_MouseDown;
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

	internal virtual DrakeUILabel msgbody
	{
		[CompilerGenerated]
		get
		{
			return _msgbody;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = msgbody_MouseDown;
			DrakeUILabel drakeUILabel = _msgbody;
			if (drakeUILabel != null)
			{
				drakeUILabel.MouseDown -= value2;
			}
			_msgbody = value;
			drakeUILabel = _msgbody;
			if (drakeUILabel != null)
			{
				drakeUILabel.MouseDown += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel4")]
	internal virtual Panel Panel4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("botompanel")]
	internal virtual Panel botompanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("leftpanel")]
	internal virtual Panel leftpanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("rightpanel")]
	internal virtual Panel rightpanel
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

	[field: AccessedThroughProperty("checkskip")]
	internal virtual DrakeUICheckBox checkskip
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTMOB.MyMsgBox));
		this.toppanel = new System.Windows.Forms.Panel();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.checkskip = new DrakeUI.Framework.DrakeUICheckBox();
		this.nobtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeWidth_W1 = new DrakeUI.Framework.DrakeWidth_W();
		this.okbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.msgtitle = new DrakeUI.Framework.DrakeUILabel();
		this.Panel3 = new System.Windows.Forms.Panel();
		this.msgbody = new DrakeUI.Framework.DrakeUILabel();
		this.msgimg = new System.Windows.Forms.PictureBox();
		this.Panel4 = new System.Windows.Forms.Panel();
		this.botompanel = new System.Windows.Forms.Panel();
		this.leftpanel = new System.Windows.Forms.Panel();
		this.rightpanel = new System.Windows.Forms.Panel();
		this.DrakeWidth_W2 = new DrakeUI.Framework.DrakeWidth_W();
		this.Panel2.SuspendLayout();
		this.Panel3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.msgimg).BeginInit();
		this.Panel4.SuspendLayout();
		base.SuspendLayout();
		this.toppanel.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
		this.toppanel.Location = new System.Drawing.Point(2, 0);
		this.toppanel.Name = EXGuarder._4932376C;
		this.toppanel.Size = new System.Drawing.Size(804, 2);
		this.toppanel.TabIndex = 0;
		this.Panel2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel2.Controls.Add(this.checkskip);
		this.Panel2.Controls.Add(this.nobtn);
		this.Panel2.Controls.Add(this.DrakeWidth_W1);
		this.Panel2.Controls.Add(this.okbtn);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel2.Location = new System.Drawing.Point(2, 162);
		this.Panel2.Name = EXGuarder._431F1726;
		this.Panel2.Padding = new System.Windows.Forms.Padding(10);
		this.Panel2.Size = new System.Drawing.Size(802, 59);
		this.Panel2.TabIndex = 1;
		this.checkskip.CheckBoxColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.checkskip.Cursor = System.Windows.Forms.Cursors.Hand;
		this.checkskip.Dock = System.Windows.Forms.DockStyle.Fill;
		this.checkskip.Font = new System.Drawing.Font(EXGuarder._3C182B30, 9f);
		this.checkskip.ForeColor = System.Drawing.Color.White;
		this.checkskip.ImageInterval = 15;
		this.checkskip.Location = new System.Drawing.Point(10, 10);
		this.checkskip.Name = EXGuarder._13165610;
		this.checkskip.Padding = new System.Windows.Forms.Padding(46, 0, 0, 0);
		this.checkskip.Radius = 15;
		this.checkskip.Size = new System.Drawing.Size(536, 39);
		this.checkskip.Style = DrakeUI.Framework.UIStyle.Custom;
		this.checkskip.TabIndex = 46;
		this.checkskip.Text = EXGuarder._2C731E76;
		this.checkskip.Visible = false;
		this.nobtn.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.nobtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.nobtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.nobtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.nobtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.nobtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.nobtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.nobtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.nobtn.Font = new System.Drawing.Font(EXGuarder._3C182B30, 10f);
		this.nobtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.nobtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.nobtn.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.nobtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.nobtn.Location = new System.Drawing.Point(546, 10);
		this.nobtn.Name = EXGuarder._1374495E;
		this.nobtn.Radius = 15;
		this.nobtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.nobtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.nobtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.nobtn.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.nobtn.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.nobtn.Size = new System.Drawing.Size(109, 39);
		this.nobtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.nobtn.Symbol = 61453;
		this.nobtn.SymbolSize = 20;
		this.nobtn.TabIndex = 45;
		this.nobtn.Text = EXGuarder._35060101;
		this.DrakeWidth_W1.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W1.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeWidth_W1.Location = new System.Drawing.Point(655, 10);
		this.DrakeWidth_W1.Name = EXGuarder._084E7405;
		this.DrakeWidth_W1.Size = new System.Drawing.Size(28, 39);
		this.DrakeWidth_W1.TabIndex = 5;
		this.okbtn.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.okbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.okbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.okbtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.okbtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.okbtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.okbtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.okbtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.okbtn.Font = new System.Drawing.Font(EXGuarder._3C182B30, 10f);
		this.okbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.okbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.okbtn.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.okbtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.okbtn.Location = new System.Drawing.Point(683, 10);
		this.okbtn.Name = EXGuarder._4E742247;
		this.okbtn.Radius = 15;
		this.okbtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.okbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.okbtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.okbtn.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.okbtn.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.okbtn.Size = new System.Drawing.Size(109, 39);
		this.okbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.okbtn.SymbolSize = 20;
		this.okbtn.TabIndex = 44;
		this.okbtn.Text = EXGuarder._682A1A67;
		this.msgtitle.Dock = System.Windows.Forms.DockStyle.Fill;
		this.msgtitle.Font = new System.Drawing.Font(EXGuarder._3C182B30, 11f, System.Drawing.FontStyle.Bold);
		this.msgtitle.ForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.msgtitle.Location = new System.Drawing.Point(34, 5);
		this.msgtitle.Name = EXGuarder._0D131912;
		this.msgtitle.Padding = new System.Windows.Forms.Padding(5);
		this.msgtitle.Size = new System.Drawing.Size(763, 36);
		this.msgtitle.TabIndex = 2;
		this.msgtitle.Text = EXGuarder._22236C06;
		this.msgtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Panel3.Controls.Add(this.msgbody);
		this.Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel3.Location = new System.Drawing.Point(36, 48);
		this.Panel3.Name = EXGuarder._18584927;
		this.Panel3.Padding = new System.Windows.Forms.Padding(10);
		this.Panel3.Size = new System.Drawing.Size(768, 114);
		this.Panel3.TabIndex = 4;
		this.msgbody.Dock = System.Windows.Forms.DockStyle.Fill;
		this.msgbody.Font = new System.Drawing.Font(EXGuarder._3C182B30, 10f, System.Drawing.FontStyle.Bold);
		this.msgbody.ForeColor = System.Drawing.Color.White;
		this.msgbody.Location = new System.Drawing.Point(10, 10);
		this.msgbody.Name = EXGuarder._7160245D;
		this.msgbody.Size = new System.Drawing.Size(748, 94);
		this.msgbody.TabIndex = 3;
		this.msgbody.Text = EXGuarder._5727593E;
		this.msgbody.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.msgimg.Dock = System.Windows.Forms.DockStyle.Left;
		this.msgimg.Image = (System.Drawing.Image)resources.GetObject(EXGuarder._1F740036);
		this.msgimg.Location = new System.Drawing.Point(5, 5);
		this.msgimg.Name = EXGuarder._2325063B;
		this.msgimg.Size = new System.Drawing.Size(29, 36);
		this.msgimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.msgimg.TabIndex = 3;
		this.msgimg.TabStop = false;
		this.Panel4.Controls.Add(this.msgtitle);
		this.Panel4.Controls.Add(this.msgimg);
		this.Panel4.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel4.Location = new System.Drawing.Point(2, 2);
		this.Panel4.Name = EXGuarder._171B1D6B;
		this.Panel4.Padding = new System.Windows.Forms.Padding(5);
		this.Panel4.Size = new System.Drawing.Size(802, 46);
		this.Panel4.TabIndex = 4;
		this.botompanel.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.botompanel.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.botompanel.Location = new System.Drawing.Point(2, 221);
		this.botompanel.Name = EXGuarder._470F4A38;
		this.botompanel.Size = new System.Drawing.Size(804, 2);
		this.botompanel.TabIndex = 1;
		this.leftpanel.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.leftpanel.Dock = System.Windows.Forms.DockStyle.Left;
		this.leftpanel.Location = new System.Drawing.Point(0, 0);
		this.leftpanel.Name = EXGuarder._35011D00;
		this.leftpanel.Size = new System.Drawing.Size(2, 223);
		this.leftpanel.TabIndex = 1;
		this.rightpanel.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.rightpanel.Dock = System.Windows.Forms.DockStyle.Right;
		this.rightpanel.Location = new System.Drawing.Point(804, 2);
		this.rightpanel.Name = EXGuarder._322F6230;
		this.rightpanel.Size = new System.Drawing.Size(2, 219);
		this.rightpanel.TabIndex = 2;
		this.DrakeWidth_W2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W2.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeWidth_W2.Location = new System.Drawing.Point(2, 48);
		this.DrakeWidth_W2.Name = EXGuarder._012F633B;
		this.DrakeWidth_W2.Size = new System.Drawing.Size(34, 114);
		this.DrakeWidth_W2.TabIndex = 6;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		base.ClientSize = new System.Drawing.Size(806, 223);
		base.ControlBox = false;
		base.Controls.Add(this.Panel3);
		base.Controls.Add(this.DrakeWidth_W2);
		base.Controls.Add(this.Panel4);
		base.Controls.Add(this.Panel2);
		base.Controls.Add(this.rightpanel);
		base.Controls.Add(this.botompanel);
		base.Controls.Add(this.toppanel);
		base.Controls.Add(this.leftpanel);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject(EXGuarder._554B603C);
		base.Name = EXGuarder._080D015C;
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = EXGuarder._5D593365;
		base.TopMost = true;
		this.Panel2.ResumeLayout(false);
		this.Panel3.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.msgimg).EndInit();
		this.Panel4.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	public MyMsgBox()
	{
		InitializeComponent();
		okbtn.Text = BTConst.okstr;
		nobtn.Text = BTConst.nostr;
		checkskip.Text = BTConst.dntshowstr;
	}

	private void okbtn_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.OK;
		Close();
	}

	private void nobtn_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.No;
		Close();
	}

	private void msgbody_MouseDown(object sender, MouseEventArgs e)
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
}
