using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTMOB.My.Resources;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BTMOB;

[DesignerGenerated]
public class downloader : basestyle
{
	[CompilerGenerated]
	internal sealed class _Closure_0024__35_002D0
	{
		public long _0024VB_0024Local_totalRead;

		public long? _0024VB_0024Local_contentLength;

		public downloader _0024VB_0024Me;

		public VB_0024AnonymousDelegate_0 _0024I1;

		public _Closure_0024__35_002D0(_Closure_0024__35_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_totalRead = arg0._0024VB_0024Local_totalRead;
				_0024VB_0024Local_contentLength = arg0._0024VB_0024Local_contentLength;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__1()
		{
			int num = checked((int)Math.Round((double)(_0024VB_0024Local_totalRead * 100) / (double)_0024VB_0024Local_contentLength.Value));
			_0024VB_0024Me.downprogress.Value = num;
			_0024VB_0024Me.countlabel.Text = $"{num}%";
			_0024VB_0024Me.sizelabel.Text = $"{codes.BytesToText(_0024VB_0024Local_totalRead)} / {codes.BytesToText(_0024VB_0024Local_contentLength.Value)}";
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__37_002D0
	{
		public long _0024VB_0024Local_totalRead;

		public long? _0024VB_0024Local_contentLength;

		public downloader _0024VB_0024Me;

		public VB_0024AnonymousDelegate_0 _0024I1;

		public _Closure_0024__37_002D0(_Closure_0024__37_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_totalRead = arg0._0024VB_0024Local_totalRead;
				_0024VB_0024Local_contentLength = arg0._0024VB_0024Local_contentLength;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__1()
		{
			int num = checked((int)Math.Round((double)(_0024VB_0024Local_totalRead * 100) / (double)_0024VB_0024Local_contentLength.Value));
			_0024VB_0024Me.downprogress.Value = num;
			_0024VB_0024Me.countlabel.Text = $"{num}%";
			_0024VB_0024Me.sizelabel.Text = $"{codes.BytesToText(_0024VB_0024Local_totalRead)} / {codes.BytesToText(_0024VB_0024Local_contentLength.Value)}";
		}
	}

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("WorkerCustomapp")]
	private BackgroundWorker _WorkerCustomapp;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("WorkerStoreapp")]
	private BackgroundWorker _WorkerStoreapp;

	public bool istore;

	public string apppkg;

	public string nextkey;

	public HttpClient DownloadhttpClient;

	public string serverip;

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("downprogress")]
	internal virtual DrakeUITrackBar downprogress
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual BackgroundWorker WorkerCustomapp
	{
		[CompilerGenerated]
		get
		{
			return _WorkerCustomapp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DoWorkEventHandler value2 = Workerdownload_DoWork;
			BackgroundWorker backgroundWorker = _WorkerCustomapp;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= value2;
			}
			_WorkerCustomapp = value;
			backgroundWorker = _WorkerCustomapp;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork += value2;
			}
		}
	}

	internal virtual BackgroundWorker WorkerStoreapp
	{
		[CompilerGenerated]
		get
		{
			return _WorkerStoreapp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DoWorkEventHandler value2 = WorkerStoreapp_DoWork;
			BackgroundWorker backgroundWorker = _WorkerStoreapp;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= value2;
			}
			_WorkerStoreapp = value;
			backgroundWorker = _WorkerStoreapp;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork += value2;
			}
		}
	}

	[field: AccessedThroughProperty("countlabel")]
	internal virtual Label countlabel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("sizelabel")]
	internal virtual Label sizelabel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public downloader()
	{
		base.Load += downloader_Load;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTMOB.downloader));
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		this.downprogress = new DrakeUI.Framework.DrakeUITrackBar();
		this.WorkerCustomapp = new System.ComponentModel.BackgroundWorker();
		this.WorkerStoreapp = new System.ComponentModel.BackgroundWorker();
		this.countlabel = new System.Windows.Forms.Label();
		this.sizelabel = new System.Windows.Forms.Label();
		((System.ComponentModel.ISupportInitialize)this.myscr).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.myico).BeginInit();
		this.tobpanelsti.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		base.SuspendLayout();
		this.myscr.Visible = false;
		this.pinbtn.Location = new System.Drawing.Point(497, 5);
		this.minibtn.Location = new System.Drawing.Point(539, 5);
		this.closbtn.Location = new System.Drawing.Point(581, 5);
		this.myico.Visible = false;
		this.mytitle.Location = new System.Drawing.Point(5, 4);
		this.mytitle.Size = new System.Drawing.Size(613, 18);
		this.tobpanelsti.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.tobpanelsti.Size = new System.Drawing.Size(623, 26);
		this.PictureBox1.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
		this.PictureBox1.Image = BTMOB.My.Resources.Resources.uploading;
		this.PictureBox1.Location = new System.Drawing.Point(536, 64);
		this.PictureBox1.Name = EXGuarder._502F0730;
		this.PictureBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.PictureBox1.Size = new System.Drawing.Size(89, 51);
		this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.PictureBox1.TabIndex = 41;
		this.PictureBox1.TabStop = false;
		this.downprogress.DisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.downprogress.Dock = System.Windows.Forms.DockStyle.Fill;
		this.downprogress.Enabled = false;
		this.downprogress.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.downprogress.Font = new System.Drawing.Font(EXGuarder._4234552C, 12f);
		this.downprogress.ForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.downprogress.Location = new System.Drawing.Point(162, 64);
		this.downprogress.Name = EXGuarder._014B3131;
		this.downprogress.RectColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.downprogress.Size = new System.Drawing.Size(304, 51);
		this.downprogress.Style = DrakeUI.Framework.UIStyle.Custom;
		this.downprogress.TabIndex = 44;
		this.downprogress.Value = 12;
		this.countlabel.Dock = System.Windows.Forms.DockStyle.Right;
		this.countlabel.Font = new System.Drawing.Font(EXGuarder._4234552C, 8f);
		this.countlabel.Location = new System.Drawing.Point(466, 64);
		this.countlabel.Name = EXGuarder._2F275A1F;
		this.countlabel.Size = new System.Drawing.Size(70, 51);
		this.countlabel.TabIndex = 45;
		this.countlabel.Text = EXGuarder._0A496D55;
		this.countlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.sizelabel.Dock = System.Windows.Forms.DockStyle.Left;
		this.sizelabel.Font = new System.Drawing.Font(EXGuarder._4234552C, 9f);
		this.sizelabel.Location = new System.Drawing.Point(2, 64);
		this.sizelabel.Name = EXGuarder._652C2000;
		this.sizelabel.Size = new System.Drawing.Size(160, 51);
		this.sizelabel.TabIndex = 46;
		this.sizelabel.Text = EXGuarder._0A496D55;
		this.sizelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 18f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		base.ClientSize = new System.Drawing.Size(627, 117);
		base.Controls.Add(this.downprogress);
		base.Controls.Add(this.sizelabel);
		base.Controls.Add(this.countlabel);
		base.Controls.Add(this.PictureBox1);
		base.Icon = (System.Drawing.Icon)resources.GetObject(EXGuarder._2153286A);
		this.MinimumSize = new System.Drawing.Size(595, 115);
		base.Name = EXGuarder._13002909;
		this.Text = EXGuarder._13002909;
		base.Controls.SetChildIndex(this.tobpanelsti, 0);
		base.Controls.SetChildIndex(this.PictureBox1, 0);
		base.Controls.SetChildIndex(this.countlabel, 0);
		base.Controls.SetChildIndex(this.sizelabel, 0);
		base.Controls.SetChildIndex(this.downprogress, 0);
		((System.ComponentModel.ISupportInitialize)this.myscr).EndInit();
		((System.ComponentModel.ISupportInitialize)this.myico).EndInit();
		this.tobpanelsti.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		base.ResumeLayout(false);
	}

	private void downloader_Load(object sender, EventArgs e)
	{
		base.StartPosition = FormStartPosition.Manual;
		Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
		base.Location = new Point(checked(workingArea.Right - base.Width), workingArea.Top);
		if (istore)
		{
			WorkerStoreapp.RunWorkerAsync();
		}
		else
		{
			WorkerCustomapp.RunWorkerAsync();
		}
		pinbtn.PerformClick();
	}

	private async void Workerdownload_DoWork(object sender, DoWorkEventArgs e)
	{
		try
		{
			string ran_key = codes.StrGenerator(32);
			VB_0024AnonymousType_1<string, string, string, string> vB_0024AnonymousType_ = new VB_0024AnonymousType_1<string, string, string, string>("download", ran_key, apppkg, nextkey);
			TaskAwaiter<(bool, object)> taskAwaiter = FetchCustom(vB_0024AnonymousType_, DownloadhttpClient, Conversions.ToString(RuntimeHelpers.GetObjectValue(BTConst.getApiUrl(BTConst.api_usercustomapps, serverip)))).GetAwaiter();
			if (!taskAwaiter.IsCompleted)
			{
				await taskAwaiter;
				TaskAwaiter<(bool, object)> taskAwaiter2 = default(TaskAwaiter<(bool, object)>);
				taskAwaiter = taskAwaiter2;
			}
			(bool, object) result = taskAwaiter.GetResult();
			(bool, object) tuple = result;
			if (tuple.Item1)
			{
				if (tuple.Item2 is byte[])
				{
					string text = MyRes.Apps_Path + "\\" + apppkg + ".apk";
					if (!File.Exists(text))
					{
						File.Create(text).Dispose();
					}
					File.WriteAllBytes(text, (byte[])tuple.Item2);
					Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
					{
						BTAlerter.Success("Download completed");
					}));
					string arguments = "/select," + text;
					Process.Start("explorer.exe", arguments);
				}
				else
				{
					Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
					{
						BTAlerter.erroes("Response: " + tuple.Item2.ToString());
					}));
				}
			}
			else
			{
				Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					BTAlerter.erroes("Error: " + tuple.Item2.ToString());
				}));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private async Task<(bool, object)> FetchCustom(object @params, HttpClient client, string urlapi)
	{
		checked
		{
			try
			{
				string content = JsonConvert.SerializeObject(RuntimeHelpers.GetObjectValue(@params));
				StringContent content2 = new StringContent(content, Encoding.UTF8, "application/json");
				HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, urlapi)
				{
					Content = content2
				};
				using HttpResponseMessage httpResponseMessage = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
				if (httpResponseMessage.IsSuccessStatusCode)
				{
					string mediaType = httpResponseMessage.Content.Headers.ContentType.MediaType;
					if (Operators.CompareString(mediaType, "application/json", TextCompare: false) == 0)
					{
						string text = await httpResponseMessage.Content.ReadAsStringAsync();
						JObject jObject = JObject.Parse(text);
						if (jObject["Success"] != null)
						{
							return (true, jObject["Success"].ToString());
						}
						if (jObject["Req"] != null)
						{
							return (true, jObject["Req"].ToString());
						}
						if (jObject["Fail"] != null)
						{
							return (false, "Fail: " + jObject["Fail"].ToString());
						}
						return (false, "Unknown response format: " + text);
					}
					_Closure_0024__35_002D0 arg = default(_Closure_0024__35_002D0);
					_Closure_0024__35_002D0 CS_0024_003C_003E8__locals13 = new _Closure_0024__35_002D0(arg);
					CS_0024_003C_003E8__locals13._0024VB_0024Me = this;
					CS_0024_003C_003E8__locals13._0024VB_0024Local_contentLength = httpResponseMessage.Content.Headers.ContentLength;
					if (!CS_0024_003C_003E8__locals13._0024VB_0024Local_contentLength.HasValue)
					{
						return (false, "Content length not provided.");
					}
					Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
					{
						downprogress.Minimum = 0;
						downprogress.Maximum = 100;
						downprogress.Value = 0;
					}));
					CS_0024_003C_003E8__locals13._0024VB_0024Local_totalRead = 0L;
					int num = 65536;
					byte[] array = new byte[num - 1 + 1];
					List<byte[]> list = new List<byte[]>();
					using (Stream stream = await httpResponseMessage.Content.ReadAsStreamAsync())
					{
						int num2;
						do
						{
							num2 = await stream.ReadAsync(array, 0, num);
							if (num2 <= 0)
							{
								continue;
							}
							byte[] array2 = new byte[num2 - 1 + 1];
							Buffer.BlockCopy(array, 0, array2, 0, num2);
							list.Add(array2);
							CS_0024_003C_003E8__locals13._0024VB_0024Local_totalRead += num2;
							if (CS_0024_003C_003E8__locals13._0024VB_0024Local_contentLength.HasValue)
							{
								Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
								{
									int num3 = (int)Math.Round((double)(CS_0024_003C_003E8__locals13._0024VB_0024Local_totalRead * 100) / (double)CS_0024_003C_003E8__locals13._0024VB_0024Local_contentLength.Value);
									CS_0024_003C_003E8__locals13._0024VB_0024Me.downprogress.Value = num3;
									CS_0024_003C_003E8__locals13._0024VB_0024Me.countlabel.Text = $"{num3}%";
									CS_0024_003C_003E8__locals13._0024VB_0024Me.sizelabel.Text = $"{codes.BytesToText(CS_0024_003C_003E8__locals13._0024VB_0024Local_totalRead)} / {codes.BytesToText(CS_0024_003C_003E8__locals13._0024VB_0024Local_contentLength.Value)}";
								}));
							}
						}
						while (num2 > 0);
					}
					byte[] item = list.SelectMany([SpecialName] (byte[] chunk) => chunk).ToArray();
					return (true, item);
				}
				return (false, "HTTP error: " + httpResponseMessage.StatusCode);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Exception ex3 = ex2;
				(bool, object) result = (false, "Error: " + ex3.Message);
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	private void WorkerStoreapp_DoWork(object sender, DoWorkEventArgs e)
	{
		try
		{
			Task.Run([SpecialName] async () =>
			{
				string ran_key = codes.StrGenerator(32);
				VB_0024AnonymousType_1<string, string, string, string> vB_0024AnonymousType_ = new VB_0024AnonymousType_1<string, string, string, string>("download", ran_key, apppkg, nextkey);
				TaskAwaiter<(bool, object)> taskAwaiter = FetchStore(vB_0024AnonymousType_, DownloadhttpClient, Conversions.ToString(RuntimeHelpers.GetObjectValue(BTConst.getApiUrl(BTConst.api_userstoreapps, serverip)))).GetAwaiter();
				if (!taskAwaiter.IsCompleted)
				{
					await taskAwaiter;
					TaskAwaiter<(bool, object)> taskAwaiter2 = default(TaskAwaiter<(bool, object)>);
					taskAwaiter = taskAwaiter2;
				}
				(bool, object) result = taskAwaiter.GetResult();
				(bool, object) tuple = result;
				if (tuple.Item1)
				{
					if (tuple.Item2 is byte[])
					{
						string text = MyRes.Apps_Path + "\\" + apppkg + ".apk";
						if (!File.Exists(text))
						{
							File.Create(text).Dispose();
						}
						File.WriteAllBytes(text, (byte[])tuple.Item2);
						Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
						{
							BTAlerter.Success("Download completed");
						}));
						string arguments = "/select," + text;
						Process.Start("explorer.exe", arguments);
					}
					else
					{
						Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
						{
							BTAlerter.erroes("Response: " + tuple.Item2.ToString());
						}));
					}
				}
				else
				{
					Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
					{
						BTAlerter.erroes("Error: " + tuple.Item2.ToString());
					}));
				}
			}).ConfigureAwait(continueOnCapturedContext: false);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private async Task<(bool, object)> FetchStore(object @params, HttpClient client, string urlapi)
	{
		checked
		{
			try
			{
				string content = JsonConvert.SerializeObject(RuntimeHelpers.GetObjectValue(@params));
				StringContent content2 = new StringContent(content, Encoding.UTF8, "application/json");
				HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, urlapi)
				{
					Content = content2
				};
				using HttpResponseMessage httpResponseMessage = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
				if (httpResponseMessage.IsSuccessStatusCode)
				{
					string mediaType = httpResponseMessage.Content.Headers.ContentType.MediaType;
					if (Operators.CompareString(mediaType, "application/json", TextCompare: false) == 0)
					{
						string text = await httpResponseMessage.Content.ReadAsStringAsync();
						JObject jObject = JObject.Parse(text);
						if (jObject["Success"] != null)
						{
							return (true, jObject["Success"].ToString());
						}
						if (jObject["Req"] != null)
						{
							return (true, jObject["Req"].ToString());
						}
						if (jObject["Fail"] != null)
						{
							return (false, "Fail: " + jObject["Fail"].ToString());
						}
						return (false, "Unknown response format: " + text);
					}
					_Closure_0024__37_002D0 arg = default(_Closure_0024__37_002D0);
					_Closure_0024__37_002D0 CS_0024_003C_003E8__locals13 = new _Closure_0024__37_002D0(arg);
					CS_0024_003C_003E8__locals13._0024VB_0024Me = this;
					CS_0024_003C_003E8__locals13._0024VB_0024Local_contentLength = httpResponseMessage.Content.Headers.ContentLength;
					if (!CS_0024_003C_003E8__locals13._0024VB_0024Local_contentLength.HasValue)
					{
						return (false, "Content length not provided.");
					}
					Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
					{
						downprogress.Minimum = 0;
						downprogress.Maximum = 100;
						downprogress.Value = 0;
					}));
					CS_0024_003C_003E8__locals13._0024VB_0024Local_totalRead = 0L;
					int num = 65536;
					byte[] array = new byte[num - 1 + 1];
					List<byte[]> list = new List<byte[]>();
					using (Stream stream = await httpResponseMessage.Content.ReadAsStreamAsync())
					{
						int num2;
						do
						{
							num2 = await stream.ReadAsync(array, 0, num);
							if (num2 <= 0)
							{
								continue;
							}
							byte[] array2 = new byte[num2 - 1 + 1];
							Buffer.BlockCopy(array, 0, array2, 0, num2);
							list.Add(array2);
							CS_0024_003C_003E8__locals13._0024VB_0024Local_totalRead += num2;
							if (CS_0024_003C_003E8__locals13._0024VB_0024Local_contentLength.HasValue)
							{
								Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
								{
									int num3 = (int)Math.Round((double)(CS_0024_003C_003E8__locals13._0024VB_0024Local_totalRead * 100) / (double)CS_0024_003C_003E8__locals13._0024VB_0024Local_contentLength.Value);
									CS_0024_003C_003E8__locals13._0024VB_0024Me.downprogress.Value = num3;
									CS_0024_003C_003E8__locals13._0024VB_0024Me.countlabel.Text = $"{num3}%";
									CS_0024_003C_003E8__locals13._0024VB_0024Me.sizelabel.Text = $"{codes.BytesToText(CS_0024_003C_003E8__locals13._0024VB_0024Local_totalRead)} / {codes.BytesToText(CS_0024_003C_003E8__locals13._0024VB_0024Local_contentLength.Value)}";
								}));
							}
						}
						while (num2 > 0);
					}
					byte[] item = list.SelectMany([SpecialName] (byte[] chunk) => chunk).ToArray();
					return (true, item);
				}
				return (false, "HTTP error: " + httpResponseMessage.StatusCode);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Exception ex3 = ex2;
				(bool, object) result = (false, "Error: " + ex3.Message);
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}
}
