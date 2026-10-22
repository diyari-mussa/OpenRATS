using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTMOB.My.Resources;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BTMOB;

[DesignerGenerated]
public class updatewindow : basestyle
{
	[CompilerGenerated]
	internal sealed class _Closure_0024__41_002D0
	{
		public long _0024VB_0024Local_totalRead;

		public long? _0024VB_0024Local_contentLength;

		public updatewindow _0024VB_0024Me;

		public VB_0024AnonymousDelegate_0 _0024I1;

		public _Closure_0024__41_002D0(_Closure_0024__41_002D0 arg0)
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
	[AccessedThroughProperty("updateworker")]
	private BackgroundWorker _updateworker;

	[field: AccessedThroughProperty("Panel2")]
	internal virtual Panel Panel2
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

	[field: AccessedThroughProperty("countlabel")]
	internal virtual Label countlabel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("loglabel")]
	internal virtual RichTextBox loglabel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual BackgroundWorker updateworker
	{
		[CompilerGenerated]
		get
		{
			return _updateworker;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DoWorkEventHandler value2 = updateworker_DoWork;
			BackgroundWorker backgroundWorker = _updateworker;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= value2;
			}
			_updateworker = value;
			backgroundWorker = _updateworker;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork += value2;
			}
		}
	}

	[field: AccessedThroughProperty("sizelabel")]
	internal virtual Label sizelabel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel3")]
	internal virtual Panel Panel3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public ServersInfo serverinfo { get; set; }

	public updatewindow()
	{
		base.Load += updatewindow_Load;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTMOB.updatewindow));
		this.Panel2 = new System.Windows.Forms.Panel();
		this.downprogress = new DrakeUI.Framework.DrakeUITrackBar();
		this.sizelabel = new System.Windows.Forms.Label();
		this.countlabel = new System.Windows.Forms.Label();
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		this.loglabel = new System.Windows.Forms.RichTextBox();
		this.updateworker = new System.ComponentModel.BackgroundWorker();
		this.Panel3 = new System.Windows.Forms.Panel();
		((System.ComponentModel.ISupportInitialize)this.myscr).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.myico).BeginInit();
		this.tobpanelsti.SuspendLayout();
		this.Panel2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		this.Panel3.SuspendLayout();
		base.SuspendLayout();
		this.myscr.Location = new System.Drawing.Point(63, 5);
		this.pinbtn.Location = new System.Drawing.Point(563, 5);
		this.minibtn.Location = new System.Drawing.Point(605, 5);
		this.closbtn.Location = new System.Drawing.Point(647, 5);
		this.myico.Image = (System.Drawing.Image)resources.GetObject(EXGuarder._0E285616);
		this.myico.Size = new System.Drawing.Size(48, 25);
		this.mytitle.Location = new System.Drawing.Point(5, 4);
		this.mytitle.Size = new System.Drawing.Size(679, 18);
		this.mytitle.Text = EXGuarder._0F531779;
		this.mytitle.Visible = false;
		this.tobpanelsti.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.tobpanelsti.Size = new System.Drawing.Size(689, 26);
		this.Panel2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel2.Controls.Add(this.downprogress);
		this.Panel2.Controls.Add(this.sizelabel);
		this.Panel2.Controls.Add(this.countlabel);
		this.Panel2.Controls.Add(this.PictureBox1);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel2.Location = new System.Drawing.Point(2, 64);
		this.Panel2.Name = EXGuarder._484B7325;
		this.Panel2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
		this.Panel2.Size = new System.Drawing.Size(689, 69);
		this.Panel2.TabIndex = 40;
		this.downprogress.DisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.downprogress.Dock = System.Windows.Forms.DockStyle.Fill;
		this.downprogress.Enabled = false;
		this.downprogress.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.downprogress.Font = new System.Drawing.Font(EXGuarder._3F583138, 12f);
		this.downprogress.ForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.downprogress.Location = new System.Drawing.Point(173, 4);
		this.downprogress.Name = EXGuarder._09074071;
		this.downprogress.RectColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.downprogress.Size = new System.Drawing.Size(380, 61);
		this.downprogress.Style = DrakeUI.Framework.UIStyle.Custom;
		this.downprogress.TabIndex = 47;
		this.sizelabel.Dock = System.Windows.Forms.DockStyle.Left;
		this.sizelabel.Font = new System.Drawing.Font(EXGuarder._3F583138, 9f);
		this.sizelabel.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.sizelabel.Location = new System.Drawing.Point(4, 4);
		this.sizelabel.Name = EXGuarder._711A1175;
		this.sizelabel.Size = new System.Drawing.Size(169, 61);
		this.sizelabel.TabIndex = 49;
		this.sizelabel.Text = EXGuarder._0B191559;
		this.sizelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.countlabel.Dock = System.Windows.Forms.DockStyle.Right;
		this.countlabel.Font = new System.Drawing.Font(EXGuarder._3F583138, 8.5f);
		this.countlabel.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.countlabel.Location = new System.Drawing.Point(553, 4);
		this.countlabel.Name = EXGuarder._59442712;
		this.countlabel.Size = new System.Drawing.Size(70, 61);
		this.countlabel.TabIndex = 48;
		this.countlabel.Text = EXGuarder._0B191559;
		this.countlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.PictureBox1.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
		this.PictureBox1.Image = BTMOB.My.Resources.Resources.logoup;
		this.PictureBox1.Location = new System.Drawing.Point(623, 4);
		this.PictureBox1.Name = EXGuarder._093F1669;
		this.PictureBox1.Size = new System.Drawing.Size(62, 61);
		this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.PictureBox1.TabIndex = 46;
		this.PictureBox1.TabStop = false;
		this.loglabel.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.loglabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.loglabel.Dock = System.Windows.Forms.DockStyle.Fill;
		this.loglabel.Font = new System.Drawing.Font(EXGuarder._3F583138, 9.5f);
		this.loglabel.ForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.loglabel.Location = new System.Drawing.Point(8, 7);
		this.loglabel.Name = EXGuarder._5E191348;
		this.loglabel.ReadOnly = true;
		this.loglabel.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
		this.loglabel.Size = new System.Drawing.Size(673, 241);
		this.loglabel.TabIndex = 41;
		this.loglabel.Text = EXGuarder._676E4272;
		this.Panel3.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel3.Controls.Add(this.loglabel);
		this.Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel3.Location = new System.Drawing.Point(2, 133);
		this.Panel3.Name = EXGuarder._1177610B;
		this.Panel3.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
		this.Panel3.Size = new System.Drawing.Size(689, 255);
		this.Panel3.TabIndex = 42;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 18f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(693, 390);
		base.Controls.Add(this.Panel3);
		base.Controls.Add(this.Panel2);
		base.Icon = (System.Drawing.Icon)resources.GetObject(EXGuarder._3F474A1F);
		base.Name = EXGuarder._213A645C;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = EXGuarder._705F3554;
		base.TopMost = true;
		base.Controls.SetChildIndex(this.tobpanelsti, 0);
		base.Controls.SetChildIndex(this.Panel2, 0);
		base.Controls.SetChildIndex(this.Panel3, 0);
		((System.ComponentModel.ISupportInitialize)this.myscr).EndInit();
		((System.ComponentModel.ISupportInitialize)this.myico).EndInit();
		this.tobpanelsti.ResumeLayout(false);
		this.Panel2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		this.Panel3.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	private async void updateworker_DoWork(object sender, DoWorkEventArgs e)
	{
		try
		{
			Thread.Sleep(1000);
			string serverNextKey = ServersMgr.GetServerNextKey(serverinfo.Address);
			logtext("Connecting");
			string ran_key = codes.StrGenerator(32);
			VB_0024AnonymousType_2<string, string, string> vB_0024AnonymousType_ = new VB_0024AnonymousType_2<string, string, string>("download", ran_key, serverNextKey);
			(bool, object) tuple = await FetchUpdate(vB_0024AnonymousType_, serverinfo.DownloadHttpClient, Conversions.ToString(RuntimeHelpers.GetObjectValue(BTConst.getApiUrl(BTConst.api_updates, serverinfo.Address))));
			if (tuple.Item1)
			{
				if (tuple.Item2 is byte[])
				{
					Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
					{
						BTAlerter.Success("Download completed");
					}));
					logtext("Extracting Data");
					byte[] bytes = (byte[])tuple.Item2;
					string text = Path.Combine(Path.GetTempPath(), "bt_update.zip");
					string text2 = Path.Combine(Path.GetTempPath(), "bt_update");
					File.WriteAllBytes(text, bytes);
					if (Directory.Exists(text2))
					{
						Directory.Delete(text2, recursive: true);
					}
					Directory.CreateDirectory(text2);
					ZipFile.ExtractToDirectory(text, text2);
					string text3 = Path.Combine(Path.GetTempPath(), "update_script.bat");
					string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
					string contents = $"\r\n            @echo off\r\n            title {BTConst.myname} Update\r\n            echo.  \r\n            echo.\r\n            echo ================ {BTConst.myname} Update ================\r\n            echo.\r\n            echo [INFO] starting update...\r\n            timeout /t 5 /nobreak >nul\r\n            echo [INFO] Copying updated files...\r\n            xcopy \"{text2}\\*\" \"{baseDirectory}\" /E /H /C /Y\r\n            timeout /t 3 /nobreak >nul\r\n            echo [INFO] Launching the application...\r\n            start \"\" \"{baseDirectory}{Path.GetFileName(Application.ExecutablePath)}\"\r\n            timeout /t 2 /nobreak >nul\r\n            exit\r\n             ";
					File.WriteAllText(text3, contents);
					ProcessStartInfo startInfo = new ProcessStartInfo
					{
						FileName = text3,
						CreateNoWindow = false,
						UseShellExecute = true
					};
					logtext("Update complete");
					int num = 4;
					do
					{
						Thread.Sleep(1000);
						logtext($"{BTConst.myname} will restart after {num} Seconds.");
						num = checked(num + -1);
					}
					while (num >= 1);
					Thread.Sleep(1000);
					Process.Start(startInfo);
					Environment.Exit(0);
				}
				else
				{
					logtext(tuple.Item2.ToString());
				}
			}
			else
			{
				logtext(tuple.Item2.ToString());
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private async Task<(bool, object)> FetchUpdate(object @params, HttpClient client, string urlapi)
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
					_Closure_0024__41_002D0 arg = default(_Closure_0024__41_002D0);
					_Closure_0024__41_002D0 CS_0024_003C_003E8__locals13 = new _Closure_0024__41_002D0(arg);
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
					logtext("Downloading");
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

	private void updatewindow_Load(object sender, EventArgs e)
	{
		logtext(EXGuarder._570F2B64);
		updateworker.RunWorkerAsync();
	}

	private void logtext(string str)
	{
		if (base.InvokeRequired)
		{
			Invoke((Action)([SpecialName] () =>
			{
				logtext(str);
			}));
		}
		else
		{
			loglabel.AppendText(string.Format(EXGuarder._330C2C1F, str, EXGuarder._67480F72));
		}
	}
}
