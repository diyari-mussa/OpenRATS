using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat;

[DesignerGenerated]
public class DialogPloice : Form
{
	private IContainer components;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("OK_Button")]
	[CompilerGenerated]
	private Button _OK_Button;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Cancel_Button")]
	private Button _Cancel_Button;

	[AccessedThroughProperty("Button1")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Button _Button1;

	[AccessedThroughProperty("Button2")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Button _Button2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	private string ARTEXT;

	private string ENTEXT;

	private bool IsArab;

	private DateTime StartNow;

	[field: AccessedThroughProperty("TableLayoutPanel1")]
	internal virtual TableLayoutPanel TableLayoutPanel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button OK_Button
	{
		[CompilerGenerated]
		get
		{
			return _OK_Button;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = OK_Button_Click;
			Button button = _OK_Button;
			if (button != null)
			{
				button.Click -= value2;
			}
			_OK_Button = value;
			button = _OK_Button;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Cancel_Button
	{
		[CompilerGenerated]
		get
		{
			return _Cancel_Button;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Cancel_Button_Click;
			Button button = _Cancel_Button;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Cancel_Button = value;
			button = _Cancel_Button;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("MainText")]
	internal virtual TextBox MainText
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button1
	{
		[CompilerGenerated]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button1_Click;
			Button button = _Button1;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button1 = value;
			button = _Button1;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button2
	{
		[CompilerGenerated]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button2_Click;
			Button button = _Button2;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button2 = value;
			button = _Button2;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Acccheck")]
	internal virtual CheckBox Acccheck
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer Timer1
	{
		[CompilerGenerated]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Timer1_Tick;
			Timer timer = _Timer1;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_Timer1 = value;
			timer = _Timer1;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	public DialogPloice()
	{
		base.Load += DialogPloice_Load;
		ARTEXT = "انا قرأت ما موجود اعلاه , وموافق على الشروط";
		ENTEXT = "I read all text above, And Accepted All";
		IsArab = false;
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
		this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
		this.OK_Button = new System.Windows.Forms.Button();
		this.Cancel_Button = new System.Windows.Forms.Button();
		this.MainText = new System.Windows.Forms.TextBox();
		this.Button1 = new System.Windows.Forms.Button();
		this.Button2 = new System.Windows.Forms.Button();
		this.Acccheck = new System.Windows.Forms.CheckBox();
		this.Timer1 = new System.Windows.Forms.Timer(this.components);
		this.TableLayoutPanel1.SuspendLayout();
		base.SuspendLayout();
		this.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.TableLayoutPanel1.ColumnCount = 2;
		this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
		this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
		this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
		this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
		this.TableLayoutPanel1.Location = new System.Drawing.Point(218, 297);
		this.TableLayoutPanel1.Name = "TableLayoutPanel1";
		this.TableLayoutPanel1.RowCount = 1;
		this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50f));
		this.TableLayoutPanel1.Size = new System.Drawing.Size(205, 37);
		this.TableLayoutPanel1.TabIndex = 0;
		this.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.OK_Button.Location = new System.Drawing.Point(17, 7);
		this.OK_Button.Name = "OK_Button";
		this.OK_Button.Size = new System.Drawing.Size(67, 23);
		this.OK_Button.TabIndex = 0;
		this.OK_Button.Text = "OK";
		this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		this.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Cancel_Button.Location = new System.Drawing.Point(120, 7);
		this.Cancel_Button.Name = "Cancel_Button";
		this.Cancel_Button.Size = new System.Drawing.Size(67, 23);
		this.Cancel_Button.TabIndex = 1;
		this.Cancel_Button.Text = "Cancel";
		this.MainText.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.MainText.Location = new System.Drawing.Point(12, 40);
		this.MainText.Multiline = true;
		this.MainText.Name = "MainText";
		this.MainText.Size = new System.Drawing.Size(411, 228);
		this.MainText.TabIndex = 1;
		this.Button1.Location = new System.Drawing.Point(12, 2);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(205, 32);
		this.Button1.TabIndex = 2;
		this.Button1.Text = "English";
		this.Button1.UseVisualStyleBackColor = true;
		this.Button2.Location = new System.Drawing.Point(218, 2);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(205, 32);
		this.Button2.TabIndex = 3;
		this.Button2.Text = "العربية";
		this.Button2.UseVisualStyleBackColor = true;
		this.Acccheck.AutoSize = true;
		this.Acccheck.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Acccheck.Location = new System.Drawing.Point(12, 274);
		this.Acccheck.Name = "Acccheck";
		this.Acccheck.Size = new System.Drawing.Size(246, 17);
		this.Acccheck.TabIndex = 4;
		this.Acccheck.Text = "I read all text above, And Accepted All";
		this.Acccheck.UseVisualStyleBackColor = true;
		this.Timer1.Interval = 1000;
		base.AcceptButton = this.OK_Button;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.CancelButton = this.Cancel_Button;
		base.ClientSize = new System.Drawing.Size(435, 336);
		base.Controls.Add(this.Acccheck);
		base.Controls.Add(this.Button2);
		base.Controls.Add(this.Button1);
		base.Controls.Add(this.MainText);
		base.Controls.Add(this.TableLayoutPanel1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DialogPloice";
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = " Privacy Policy & Terms of Service";
		base.TopMost = true;
		this.TableLayoutPanel1.ResumeLayout(false);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void OK_Button_Click(object sender, EventArgs e)
	{
		if (!Acccheck.Checked)
		{
			if (IsArab)
			{
				Interaction.MsgBox("قم بالموافقة على الشروط اولا!");
			}
			else
			{
				Interaction.MsgBox("Accepte Privacy Policy First!");
			}
		}
		else
		{
			base.DialogResult = DialogResult.OK;
			Close();
		}
	}

	private void Cancel_Button_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.Cancel;
		Close();
	}

	private void DialogPloice_Load(object sender, EventArgs e)
	{
		StartNow = DateAndTime.Now.AddSeconds(15.0);
		Timer1.Start();
		OK_Button.Enabled = false;
		Cancel_Button.Enabled = false;
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		IsArab = true;
		MainText.Text = "";
		Acccheck.Text = ARTEXT;
		OK_Button.Text = "موافق";
		Cancel_Button.Text = "كلا";
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		IsArab = false;
		MainText.Text = "";
		Acccheck.Text = ENTEXT;
		OK_Button.Text = "OK";
		Cancel_Button.Text = "Cancel";
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		if (DateTime.Compare(StartNow, DateAndTime.Now) < 0)
		{
			OK_Button.Enabled = true;
			Cancel_Button.Enabled = true;
			Text = " Privacy Policy & Terms of Service";
			Timer1.Stop();
		}
		else
		{
			Text = " Privacy Policy & Terms of Service - " + checked(StartNow.Second - DateAndTime.Now.Second);
		}
	}
}
