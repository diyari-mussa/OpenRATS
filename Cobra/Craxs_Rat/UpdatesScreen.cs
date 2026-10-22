using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Craxs_Rat.My.Resources;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat;

[DesignerGenerated]
public class UpdatesScreen : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("skipbtn")]
	private DrakeUIButtonIcon _skipbtn;

	[AccessedThroughProperty("updatbtn")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DrakeUIButtonIcon _updatbtn;

	[field: AccessedThroughProperty("updatepanel")]
	internal virtual Panel updatepanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("logupdate")]
	internal virtual TextBox logupdate
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon skipbtn
	{
		[CompilerGenerated]
		get
		{
			return _skipbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Skipbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _skipbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_skipbtn = value;
			drakeUIButtonIcon = _skipbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon updatbtn
	{
		[CompilerGenerated]
		get
		{
			return _updatbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Updatbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _updatbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_updatbtn = value;
			drakeUIButtonIcon = _updatbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel2")]
	internal virtual Panel Panel2
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
		this.updatepanel = new System.Windows.Forms.Panel();
		this.logupdate = new System.Windows.Forms.TextBox();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.Label1 = new System.Windows.Forms.Label();
		this.Panel1 = new System.Windows.Forms.Panel();
		this.skipbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.updatbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.updatepanel.SuspendLayout();
		this.Panel2.SuspendLayout();
		this.Panel1.SuspendLayout();
		base.SuspendLayout();
		this.updatepanel.Controls.Add(this.logupdate);
		this.updatepanel.Controls.Add(this.Panel2);
		this.updatepanel.Controls.Add(this.Panel1);
		this.updatepanel.Dock = System.Windows.Forms.DockStyle.Fill;
		this.updatepanel.Location = new System.Drawing.Point(0, 0);
		this.updatepanel.Name = "updatepanel";
		this.updatepanel.Size = new System.Drawing.Size(709, 669);
		this.updatepanel.TabIndex = 29;
		this.logupdate.BackColor = System.Drawing.Color.Black;
		this.logupdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.logupdate.Dock = System.Windows.Forms.DockStyle.Fill;
		this.logupdate.ForeColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.logupdate.Location = new System.Drawing.Point(0, 55);
		this.logupdate.Multiline = true;
		this.logupdate.Name = "logupdate";
		this.logupdate.ReadOnly = true;
		this.logupdate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
		this.logupdate.Size = new System.Drawing.Size(709, 554);
		this.logupdate.TabIndex = 47;
		this.logupdate.WordWrap = false;
		this.Panel2.BackColor = System.Drawing.Color.Black;
		this.Panel2.Controls.Add(this.Label1);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel2.Font = new System.Drawing.Font("Calibri", 15f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Panel2.Location = new System.Drawing.Point(0, 0);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new System.Drawing.Size(709, 55);
		this.Panel2.TabIndex = 49;
		this.Label1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Label1.ForeColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.Label1.Location = new System.Drawing.Point(0, 0);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(709, 55);
		this.Label1.TabIndex = 0;
		this.Label1.Text = "Craxs Rat Update";
		this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Panel1.BackColor = System.Drawing.Color.Black;
		this.Panel1.Controls.Add(this.skipbtn);
		this.Panel1.Controls.Add(this.updatbtn);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel1.Location = new System.Drawing.Point(0, 609);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(709, 60);
		this.Panel1.TabIndex = 48;
		this.skipbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.skipbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.skipbtn.FillColor = System.Drawing.Color.Black;
		this.skipbtn.FillDisableColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.skipbtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.skipbtn.ForeColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.skipbtn.Location = new System.Drawing.Point(489, 0);
		this.skipbtn.Name = "skipbtn";
		this.skipbtn.RectColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.skipbtn.RectDisableColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.skipbtn.Size = new System.Drawing.Size(110, 60);
		this.skipbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.skipbtn.Symbol = 61714;
		this.skipbtn.TabIndex = 45;
		this.skipbtn.Text = "Skip";
		this.updatbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.updatbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.updatbtn.FillColor = System.Drawing.Color.Black;
		this.updatbtn.FillDisableColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.updatbtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.updatbtn.ForeColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.updatbtn.Location = new System.Drawing.Point(599, 0);
		this.updatbtn.Name = "updatbtn";
		this.updatbtn.RectColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.updatbtn.RectDisableColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.updatbtn.Size = new System.Drawing.Size(110, 60);
		this.updatbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.updatbtn.TabIndex = 46;
		this.updatbtn.Text = "Start";
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(709, 669);
		base.ControlBox = false;
		base.Controls.Add(this.updatepanel);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
		base.Name = "UpdatesScreen";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "UpdatesScreen";
		base.TopMost = true;
		this.updatepanel.ResumeLayout(false);
		this.updatepanel.PerformLayout();
		this.Panel2.ResumeLayout(false);
		this.Panel1.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	public UpdatesScreen()
	{
		InitializeComponent();
		CraxsStyle();
	}

	public void CraxsStyle()
	{
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "CN", TextCompare: false) == 0)
			{
				skipbtn.Text = "跳过";
				updatbtn.Text = "开始";
			}
		}
		else
		{
			updatbtn.Text = "بدء";
			skipbtn.Text = "لاحقا";
		}
	}

	private void Updatbtn_Click(object sender, EventArgs e)
	{
		try
		{
			string text = Codes.CheckForUpdates2();
			if (text == null)
			{
				return;
			}
			if (Operators.CompareString(text, "Error", TextCompare: false) != 0)
			{
				try
				{
					if (!text.StartsWith("New:"))
					{
						Close();
					}
					else
					{
						string left = Codes.Encrypt(Codes.hashmd5(Application.ExecutablePath), "87q3vb48ghq3w4asd");
						string[] array = text.Replace("New:", "").Split(':');
						string right = array[0];
						string text2 = array[1];
						string text3 = Codes.ReadConfig("Ping");
						string text4 = Codes.ReadConfig("Link_UPDATE");
						if (Operators.CompareString(left, right, TextCompare: false) == 0)
						{
							Codes.MyMsgBox("Up to date", "Congrats  Craxs Rat is updated.", useno: false, Resources.sucess48px);
						}
						else if (Operators.CompareString(Codes.AES_Decrypt(left, "87q3vb48ghq3w4asd"), Codes.hashmd5(Application.ExecutablePath), TextCompare: false) == 0)
						{
							if (Directory.Exists(Path.GetTempPath() + "CP"))
							{
								Directory.Delete(Path.GetTempPath() + "CP", recursive: true);
							}
							if (File.Exists(Path.GetTempPath() + "CP\\up.zip"))
							{
								File.Delete(Path.GetTempPath() + "CP\\up.zip");
							}
							Directory.CreateDirectory(Path.GetTempPath() + "CP");
							File.WriteAllBytes(Path.GetTempPath() + "CP\\up.zip", Resources.up);
							try
							{
								Codes.File_zip_Decompress(Path.GetTempPath() + "CP\\up.zip", Path.GetTempPath() + "CP");
							}
							catch (Exception projectError)
							{
								ProjectData.SetProjectError(projectError);
								ProjectData.ClearProjectError();
							}
							string left2 = Codes.WhatNewupdate2();
							if (Operators.CompareString(left2, "ERROR", TextCompare: false) == 0)
							{
								left2 = "General Fix and improvment";
							}
							string text5 = Codes.Encrypt(text2, "3ExbQ7wkzRDfp5f7OMqX5Wr6d0Q") + "|";
							string text6 = Codes.Encrypt(text4, "8efb22c2ce7c3610f7792") + "|";
							string text7 = Codes.Encrypt(left2, "YHscdQVEUFJuoYTUJ") + "|";
							string text8 = Codes.Encrypt(Codes.AES_Decrypt(left, "87q3vb48ghq3w4asd"), "CFVBGNDHYWGQERGRB") + "|";
							string text9 = Codes.Encrypt(right, "sdvgerAESFrgaERGVs") + "|";
							string text10 = Codes.Encrypt(AppDomain.CurrentDomain.BaseDirectory, "kvaiehriwrgvSDRGvserg") + "|";
							string text11 = Codes.Encrypt(text3, "iugaeurNQWESVD") + "|";
							string text12 = Application.StartupPath + "\\" + Codes.AES_Decrypt("8mq82Mp958SsUo4WB4nn6Q==", "Project") + "|";
							string text13 = Codes.Encrypt("VSDara4q3w4qw3ebQWVWEW4q34", "EARGeardvAERGvd") + "|";
							string text14 = text5 + text6 + text7 + text8 + text9 + text10 + text11 + text12 + text13;
							File.WriteAllText(Path.GetTempPath() + "CP\\config.ini", Codes.Encrypt(text14, "3ExbQ7wkzRDfp5f7OMqX5Wr6d0Q"));
							Process process = new Process();
							process.StartInfo.FileName = Path.GetTempPath() + "CP\\CraxsUpdates.exe";
							process.StartInfo.WorkingDirectory = Path.GetTempPath() + "CP";
							try
							{
								process.Start();
							}
							catch (Exception projectError2)
							{
								ProjectData.SetProjectError(projectError2);
								Codes.MyMsgBox("Can't lunch updates", "please try again later.", useno: false, Resources.error48px);
								ProjectData.ClearProjectError();
								return;
							}
							Process currentProcess = Process.GetCurrentProcess();
							currentProcess.Kill();
						}
						else
						{
							Codes.MyMsgBox("License error", "your license is uncorrect  please try again later.", useno: false, Resources.error48px);
						}
					}
					return;
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					Codes.MyMsgBox("Connection error 2", "please try again later.", useno: false, Resources.error48px);
					ProjectData.ClearProjectError();
					return;
				}
			}
			Codes.MyMsgBox("Connection error 1", "please try again later.", useno: false, Resources.error48px);
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
	}

	private void Skipbtn_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.No;
		Close();
	}
}
