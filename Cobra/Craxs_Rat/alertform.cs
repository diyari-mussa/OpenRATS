using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Craxs_Rat.My.Resources;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat;

[DesignerGenerated]
public class alertform : Form
{
	[CompilerGenerated]
	private sealed class VB_0024StateMachine_39_FadeIn : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncVoidMethodBuilder _0024Builder;

		internal Form _0024VB_0024Local_o;

		internal int _0024VB_0024Local_interval;

		internal alertform _0024VB_0024Me;

		internal Form _0024S0;

		internal Exception _0024VB_0024ResumableLocal_ex_00241;

		internal TaskAwaiter _0024A0;

		[CompilerGenerated]
		internal void MoveNext()
		{
			int num = _0024State;
			try
			{
				if ((uint)num > 1u)
				{
				}
				try
				{
					if (num != 0)
					{
						if (num != 1)
						{
							goto IL_0040;
						}
						num = -1;
						_0024State = -1;
						return;
					}
					num = -1;
					_0024State = -1;
					TaskAwaiter awaiter = _0024A0;
					_0024A0 = default(TaskAwaiter);
					goto IL_0072;
					IL_0040:
					if (_0024VB_0024Local_o.Opacity < 1.0)
					{
						awaiter = Task.Delay(_0024VB_0024Local_interval).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_0024State = 0;
							_0024A0 = awaiter;
							ref AsyncVoidMethodBuilder reference = ref _0024Builder;
							VB_0024StateMachine_39_FadeIn stateMachine = this;
							reference.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
							return;
						}
						goto IL_0072;
					}
					_0024VB_0024Local_o.Opacity = 1.0;
					_0024VB_0024Me.Showtime = DateTime.Now.AddSeconds(5.0);
					_0024VB_0024Me.closetimer.Start();
					goto end_IL_000b;
					IL_0072:
					awaiter.GetResult();
					awaiter = default(TaskAwaiter);
					(_0024S0 = _0024VB_0024Local_o).Opacity = _0024S0.Opacity + 0.05;
					goto IL_0040;
					end_IL_000b:;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					_0024VB_0024ResumableLocal_ex_00241 = ex2;
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception exception = ex3;
				_0024State = -2;
				_0024Builder.SetException(exception);
				ProjectData.ClearProjectError();
				return;
			}
			num = -2;
			_0024State = -2;
			_0024Builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerNonUserCode]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("pictureBox2")]
	private PictureBox _pictureBox2;

	private Label msglabel;

	private const uint SWP_SHOWWINDOW = 64u;

	[AccessedThroughProperty("closetimer")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Timer _closetimer;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("lidlamb")]
	private DrakeUIButtonIcon _lidlamb;

	public string TheMessage;

	public int oldY;

	public Rectangle workingArea;

	public DateTime Showtime;

	private const int SW_SHOWNOACTIVATE = 4;

	public const int HWND_TOPMOST = -1;

	private const uint SWP_NOACTIVATE = 16u;

	private int counter;

	private int hold;

	private PictureBox pictureBox2
	{
		[CompilerGenerated]
		get
		{
			return _pictureBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = PictureBox2_Click;
			PictureBox pictureBox = _pictureBox2;
			if (pictureBox != null)
			{
				pictureBox.Click -= value2;
			}
			_pictureBox2 = value;
			pictureBox = _pictureBox2;
			if (pictureBox != null)
			{
				pictureBox.Click += value2;
			}
		}
	}

	protected override bool ShowWithoutActivation => true;

	[field: AccessedThroughProperty("alertimage")]
	public virtual PictureBox alertimage
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer closetimer
	{
		[CompilerGenerated]
		get
		{
			return _closetimer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Closetimer_Tick;
			Timer timer = _closetimer;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_closetimer = value;
			timer = _closetimer;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("backpanel")]
	internal virtual DrakeUITitlePanel backpanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon lidlamb
	{
		[CompilerGenerated]
		get
		{
			return _lidlamb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Lidlamb_MouseDown;
			MouseEventHandler value3 = Lidlamb_MouseUp;
			DrakeUIButtonIcon drakeUIButtonIcon = _lidlamb;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.MouseDown -= value2;
				drakeUIButtonIcon.MouseUp -= value3;
			}
			_lidlamb = value;
			drakeUIButtonIcon = _lidlamb;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.MouseDown += value2;
				drakeUIButtonIcon.MouseUp += value3;
			}
		}
	}

	[DllImport("user32.dll", SetLastError = true)]
	private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy, uint uFlags);

	protected override void OnLoad(EventArgs e)
	{
		base.OnLoad(e);
		SetWindowPos(base.Handle, new IntPtr(-1), base.Left, base.Top, base.Width, base.Height, 80u);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		this.components = new System.ComponentModel.Container();
		this.alertimage = new System.Windows.Forms.PictureBox();
		this.pictureBox2 = new System.Windows.Forms.PictureBox();
		this.msglabel = new System.Windows.Forms.Label();
		this.closetimer = new System.Windows.Forms.Timer(this.components);
		this.backpanel = new DrakeUI.Framework.DrakeUITitlePanel();
		this.lidlamb = new DrakeUI.Framework.DrakeUIButtonIcon();
		((System.ComponentModel.ISupportInitialize)this.alertimage).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
		this.backpanel.SuspendLayout();
		base.SuspendLayout();
		this.alertimage.BackColor = System.Drawing.Color.Transparent;
		this.alertimage.Dock = System.Windows.Forms.DockStyle.Left;
		this.alertimage.Image = Craxs_Rat.My.Resources.Resources.sucess48px;
		this.alertimage.Location = new System.Drawing.Point(22, 0);
		this.alertimage.Margin = new System.Windows.Forms.Padding(4);
		this.alertimage.Name = "alertimage";
		this.alertimage.Size = new System.Drawing.Size(59, 76);
		this.alertimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
		this.alertimage.TabIndex = 0;
		this.alertimage.TabStop = false;
		this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
		this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
		this.pictureBox2.Image = Craxs_Rat.My.Resources.Resources.close48px;
		this.pictureBox2.Location = new System.Drawing.Point(388, 0);
		this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
		this.pictureBox2.Name = "pictureBox2";
		this.pictureBox2.Size = new System.Drawing.Size(27, 76);
		this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox2.TabIndex = 1;
		this.pictureBox2.TabStop = false;
		this.msglabel.BackColor = System.Drawing.Color.Transparent;
		this.msglabel.Dock = System.Windows.Forms.DockStyle.Fill;
		this.msglabel.Font = new System.Drawing.Font("Calibri", 11f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.msglabel.ForeColor = System.Drawing.Color.BlanchedAlmond;
		this.msglabel.Location = new System.Drawing.Point(81, 0);
		this.msglabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.msglabel.Name = "msglabel";
		this.msglabel.Size = new System.Drawing.Size(307, 76);
		this.msglabel.TabIndex = 2;
		this.msglabel.Text = "this is test msg";
		this.msglabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.closetimer.Interval = 40;
		this.backpanel.BackColor = System.Drawing.Color.Transparent;
		this.backpanel.Controls.Add(this.msglabel);
		this.backpanel.Controls.Add(this.pictureBox2);
		this.backpanel.Controls.Add(this.alertimage);
		this.backpanel.Controls.Add(this.lidlamb);
		this.backpanel.Dock = System.Windows.Forms.DockStyle.Fill;
		this.backpanel.FillColor = System.Drawing.Color.Black;
		this.backpanel.Font = new System.Drawing.Font("Calibri", 12f);
		this.backpanel.ForeColor = System.Drawing.Color.White;
		this.backpanel.Location = new System.Drawing.Point(0, 0);
		this.backpanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.backpanel.Name = "backpanel";
		this.backpanel.RectColor = System.Drawing.Color.FromArgb(245, 17, 5);
		this.backpanel.Size = new System.Drawing.Size(415, 76);
		this.backpanel.Style = DrakeUI.Framework.UIStyle.Custom;
		this.backpanel.TabIndex = 3;
		this.backpanel.Text = null;
		this.backpanel.TitleColor = System.Drawing.Color.Black;
		this.backpanel.TitleHeight = 0;
		this.backpanel.TitleInterval = 0;
		this.lidlamb.Cursor = System.Windows.Forms.Cursors.Hand;
		this.lidlamb.Dock = System.Windows.Forms.DockStyle.Left;
		this.lidlamb.FillColor = System.Drawing.Color.Transparent;
		this.lidlamb.Font = new System.Drawing.Font("Calibri", 12f);
		this.lidlamb.ForeColor = System.Drawing.Color.Lime;
		this.lidlamb.Location = new System.Drawing.Point(0, 0);
		this.lidlamb.Name = "lidlamb";
		this.lidlamb.RectColor = System.Drawing.Color.Transparent;
		this.lidlamb.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.lidlamb.Size = new System.Drawing.Size(22, 76);
		this.lidlamb.Style = DrakeUI.Framework.UIStyle.Custom;
		this.lidlamb.StyleCustomMode = true;
		this.lidlamb.Symbol = 61713;
		this.lidlamb.TabIndex = 3;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.Black;
		base.CausesValidation = false;
		base.ClientSize = new System.Drawing.Size(415, 76);
		base.ControlBox = false;
		base.Controls.Add(this.backpanel);
		this.DoubleBuffered = true;
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(4);
		base.Name = "alertform";
		base.Opacity = 0.0;
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		this.Text = "AlertForm";
		((System.ComponentModel.ISupportInitialize)this.alertimage).EndInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
		this.backpanel.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	[DllImport("user32.dll")]
	private static extern bool SetWindowPos(int hWnd, int hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

	[DllImport("user32.dll")]
	private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	public static void ShowInactiveTopmost(Form frm)
	{
		ShowWindow(frm.Handle, 4);
		SetWindowPos(frm.Handle.ToInt32(), -1, frm.Left, frm.Top, frm.Width, frm.Height, 16u);
	}

	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(VB_0024StateMachine_39_FadeIn))]
	private void FadeIn(Form o, int interval = 45)
	{
		VB_0024StateMachine_39_FadeIn stateMachine = new VB_0024StateMachine_39_FadeIn();
		stateMachine._0024VB_0024Me = this;
		stateMachine._0024VB_0024Local_o = o;
		stateMachine._0024VB_0024Local_interval = interval;
		stateMachine._0024State = -1;
		stateMachine._0024Builder = AsyncVoidMethodBuilder.Create();
		stateMachine._0024Builder.Start(ref stateMachine);
	}

	public alertform(string msg)
	{
		base.Load += AlertForm_Load;
		components = null;
		counter = 1;
		hold = 50;
		InitializeComponent();
		TheMessage = msg;
	}

	private void AlertForm_Load(object sender, EventArgs e)
	{
		base.Opacity = 0.0;
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "AR", TextCompare: false) == 0)
			{
				TheMessage = Codes.Translate(TheMessage, "en", "ar");
			}
		}
		else
		{
			TheMessage = Codes.Translate(TheMessage, "en", "zh");
		}
		msglabel.Text = TheMessage;
		workingArea = Screen.GetWorkingArea(this);
		checked
		{
			oldY = workingArea.Bottom - base.Size.Height - 10;
			int num = 1;
			do
			{
				try
				{
					string name = "Craxs_Alert_" + Conversions.ToString(num);
					alertform alertform2 = (alertform)Application.OpenForms[name];
					if (alertform2 == null)
					{
						base.Name = name;
						break;
					}
					oldY = workingArea.Bottom - base.Size.Height - 10 - base.Height * num;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				num++;
			}
			while (num <= 99);
			base.Location = new Point(workingArea.Right - base.Size.Width, oldY);
			ShowInactiveTopmost(this);
			FadeIn(this);
		}
	}

	private void Closetimer_Tick(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				if (DateTime.Compare(Showtime, DateTime.Now) < 0)
				{
					base.Opacity = 0.0;
					closetimer.Stop();
					closetimer.Dispose();
					Close();
				}
				else if (hold == 0)
				{
					base.Name = "ended";
					workingArea = Screen.GetWorkingArea(this);
					base.Location = new Point(workingArea.Right - base.Size.Width, oldY - counter);
					counter++;
					base.Opacity -= 0.05;
				}
				else
				{
					hold--;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void PictureBox2_Click(object sender, EventArgs e)
	{
		closetimer.Stop();
		closetimer.Dispose();
		Close();
	}

	private void Lidlamb_MouseDown(object sender, MouseEventArgs e)
	{
		closetimer.Stop();
		closetimer.Dispose();
		Close();
	}

	private void Lidlamb_MouseUp(object sender, MouseEventArgs e)
	{
		closetimer.Start();
	}
}
