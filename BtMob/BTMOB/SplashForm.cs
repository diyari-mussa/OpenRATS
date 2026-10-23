using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using BTMOB.My.Resources;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;

namespace BTMOB;

[DesignerGenerated]
public class SplashForm : Form
{
	[ComVisible(true)]
	public class viewpeidge
	{
		public SplashForm splashinstance;

		public viewpeidge(SplashForm minme)
		{
			splashinstance = minme;
		}

		[DispId(1)]
		public object joinTelegram()
		{
			Thread thread = new Thread([SpecialName] () =>
			{
				splashinstance.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					try
					{
						Process.Start(BTConst.GetTeleUrl());
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ProjectData.ClearProjectError();
					}
				}));
			});
			thread.IsBackground = true;
			thread.Start();
			return "null";
		}

		[DispId(2)]
		public object enterclick()
		{
			Thread thread = new Thread([SpecialName] () =>
			{
				splashinstance.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					try
					{
						splashinstance.Close();
						splashinstance.mainform.FadeInTimer.Start();
						splashinstance.mainform.BringToFront();
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ProjectData.ClearProjectError();
					}
				}));
			});
			thread.IsBackground = true;
			thread.Start();
			return "null";
		}

		[DispId(3)]
		public object setlanguage(string lng)
		{
			Thread thread = new Thread([SpecialName] () =>
			{
				splashinstance.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					if (Operators.CompareString(lng, "zh", TextCompare: false) == 0)
					{
						lng = "cn";
					}
					BTRegistry.AddOrUpdateValue("LANG", lng.ToUpper());
					BTConst.UpdateLanguage(lng.ToUpper());
					MyMsg.Show(BTConst.lngchngstr, BTConst.restartmsgstr, MyMsg.msgtype.Confirm, use_no: false);
					splashinstance.mainform.RestartAppWithDelay();
				}));
			});
			thread.IsBackground = true;
			thread.Start();
			return "null";
		}

		[DispId(4)]
		public object unlockprofile(string pass)
		{
			Thread thread = new Thread([SpecialName] () =>
			{
				splashinstance.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					try
					{
						if (KeyGenerator.UnlockSecureProfile(pass))
						{
							splashinstance.splashview.ExecuteScriptAsync("unlockSuccess()");
						}
						else
						{
							splashinstance.splashview.ExecuteScriptAsync("unlockFailed()");
						}
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						splashinstance.splashview.ExecuteScriptAsync("unlockFailed()");
						ProjectData.ClearProjectError();
					}
				}));
			});
			thread.IsBackground = true;
			thread.Start();
			return "null";
		}

		[DispId(5)]
		public object resetprofile()
		{
			Thread thread = new Thread([SpecialName] () =>
			{
				splashinstance.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					try
					{
						if (MyMsg.Show("Reset your secure files", "Are you sure you want to delete private key file ?", MyMsg.msgtype.Confirm, use_no: true) == DialogResult.OK)
						{
							KeyGenerator.ResetSecureProfile();
							splashinstance.mainform.RestartAppWithDelay();
						}
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}));
			});
			thread.IsBackground = true;
			thread.Start();
			return "null";
		}
	}

	[CompilerGenerated]
	private sealed class VB_0024StateMachine_37_SplashForm_Load : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncVoidMethodBuilder _0024Builder;

		internal object _0024VB_0024Local_sender;

		internal EventArgs _0024VB_0024Local_e;

		internal SplashForm _0024VB_0024Me;

		internal viewpeidge _0024VB_0024ResumableLocal_thebridge_00240;

		internal string _0024VB_0024ResumableLocal_currentlang_00241;

		internal byte[] _0024VB_0024ResumableLocal_htmlBytes_00242;

		internal string _0024VB_0024ResumableLocal_html_00243;

		internal TaskAwaiter _0024A0;

		[CompilerGenerated]
		internal void MoveNext()
		{
			int num = _0024State;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					_0024VB_0024Me.FormBorderStyle = FormBorderStyle.None;
					_0024VB_0024Me.StartPosition = FormStartPosition.CenterScreen;
					_0024VB_0024Me.ShowInTaskbar = false;
					_0024VB_0024Me.TopMost = true;
					awaiter = _0024VB_0024Me.splashview.EnsureCoreWebView2Async().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_0024State = 0);
						_0024A0 = awaiter;
						ref AsyncVoidMethodBuilder reference = ref _0024Builder;
						VB_0024StateMachine_37_SplashForm_Load stateMachine = this;
						reference.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
						return;
					}
				}
				else
				{
					num = (_0024State = -1);
					awaiter = _0024A0;
					_0024A0 = default(TaskAwaiter);
				}
				awaiter.GetResult();
				awaiter = default(TaskAwaiter);
				WebViewinit.ApplyAsync(_0024VB_0024Me.splashview, _0024VB_0024Me);
				_0024VB_0024ResumableLocal_thebridge_00240 = new viewpeidge(_0024VB_0024Me);
				_0024VB_0024ResumableLocal_currentlang_00241 = codes.locallanguage();
				_0024VB_0024ResumableLocal_htmlBytes_00242 = Resources.splasher;
				_0024VB_0024ResumableLocal_html_00243 = Encoding.UTF8.GetString(_0024VB_0024ResumableLocal_htmlBytes_00242);
				_0024VB_0024ResumableLocal_html_00243 = _0024VB_0024ResumableLocal_html_00243.Replace("[LNG]", _0024VB_0024ResumableLocal_currentlang_00241);
				_0024VB_0024Me.splashview.NavigateToString(_0024VB_0024ResumableLocal_html_00243);
				_0024VB_0024Me.splashview.CoreWebView2.AddHostObjectToScript("splashhost", _0024VB_0024ResumableLocal_thebridge_00240);
				_0024VB_0024Me.splashview.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
				_0024VB_0024Me.splashview.CoreWebView2.Settings.AreDevToolsEnabled = false;
				_0024VB_0024Me.splashview.CoreWebView2.NavigationCompleted += _0024VB_0024Me.navcomplete;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception exception = ex;
				_0024VB_0024Me.weready = true;
				_0024State = -2;
				_0024Builder.SetException(exception);
				ProjectData.ClearProjectError();
				return;
			}
			num = (_0024State = -2);
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
	[AccessedThroughProperty("closbtn")]
	private DrakeUIButtonIcon _closbtn;

	private bool loadcomplete;

	private Form1 mainform;

	public bool weready;

	[field: AccessedThroughProperty("splashview")]
	internal virtual WebView2 splashview
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("rightpanel")]
	internal virtual Panel rightpanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("botompanel")]
	internal virtual Panel botompanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("toppanel")]
	internal virtual Panel toppanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("leftpanel")]
	internal virtual Panel leftpanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon closbtn
	{
		[CompilerGenerated]
		get
		{
			return _closbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = closbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _closbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_closbtn = value;
			drakeUIButtonIcon = _closbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
			components.Dispose();
		base.Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		splashview = new WebView2();
		closbtn = new DrakeUIButtonIcon();
		toppanel = new Panel();
		botompanel = new Panel();
		leftpanel = new Panel();
		rightpanel = new Panel();
		Panel1 = new Panel();
		((ISupportInitialize)splashview).BeginInit();
		toppanel.SuspendLayout();
		SuspendLayout();
		splashview.Dock = DockStyle.Fill;
		splashview.Name = EXGuarder._401B0861;
		closbtn.Dock = DockStyle.Right;
		closbtn.Text = EXGuarder._3D660C3A;
		closbtn.Size = new Size(36, 28);
		closbtn.Name = EXGuarder._151D360E;
		toppanel.Dock = DockStyle.Top;
		toppanel.Height = 28;
		toppanel.BackColor = Color.FromArgb(6, 10, 15);
		toppanel.Name = EXGuarder._37136B1E;
		toppanel.Controls.Add(closbtn);
		botompanel.Dock = DockStyle.Bottom;
		botompanel.Height = 2;
		botompanel.BackColor = Color.FromArgb(14, 22, 33);
		botompanel.Name = EXGuarder._4A421C4E;
		leftpanel.Dock = DockStyle.Left;
		leftpanel.Width = 2;
		leftpanel.BackColor = Color.FromArgb(14, 22, 33);
		leftpanel.Name = EXGuarder._2B144633;
		rightpanel.Dock = DockStyle.Right;
		rightpanel.Width = 2;
		rightpanel.BackColor = Color.FromArgb(14, 22, 33);
		rightpanel.Name = EXGuarder._48524372;
		Panel1.Dock = DockStyle.Fill;
		Panel1.Name = EXGuarder._292C4410;
		Panel1.Controls.Add(splashview);
		ClientSize = new Size(720, 480);
		BackColor = Color.FromArgb(6, 10, 15);
		Controls.Add(Panel1);
		Controls.Add(toppanel);
		Controls.Add(botompanel);
		Controls.Add(leftpanel);
		Controls.Add(rightpanel);
		Name = EXGuarder._5729204F;
		Text = BTConst.myname;
		toppanel.ResumeLayout(false);
		((ISupportInitialize)splashview).EndInit();
		ResumeLayout(false);
	}

	public SplashForm(Form1 parent)
	{
		InitializeComponent();
		mainform = parent;
		Load += SplashForm_Load;
		FormClosing += SplashForm_FormClosing;
	}

	public void UpdateStatus(string message)
	{
		if (splashview == null || splashview.CoreWebView2 == null || message == null)
			return;
		string safe = message.Replace("\\", "\\\\").Replace("'", "\\'");
		splashview.ExecuteScriptAsync(string.Format(EXGuarder._0B071829, safe));
	}

	public void ShowContinueButton()
	{
		if (splashview != null && splashview.CoreWebView2 != null)
			splashview.ExecuteScriptAsync(EXGuarder._6C4E570E);
	}

	[AsyncStateMachine(typeof(VB_0024StateMachine_37_SplashForm_Load))]
	[DebuggerStepThrough]
	private void SplashForm_Load(object sender, EventArgs e)
	{
		VB_0024StateMachine_37_SplashForm_Load stateMachine = new VB_0024StateMachine_37_SplashForm_Load();
		stateMachine._0024VB_0024Me = this;
		stateMachine._0024VB_0024Local_sender = sender;
		stateMachine._0024VB_0024Local_e = e;
		stateMachine._0024State = -1;
		stateMachine._0024Builder = AsyncVoidMethodBuilder.Create();
		stateMachine._0024Builder.Start(ref stateMachine);
	}

	private void navcomplete(object sender, CoreWebView2NavigationCompletedEventArgs e)
	{
		try
		{
			if (e.IsSuccess && splashview.CoreWebView2 != null)
				splashview.ExecuteScriptAsync(EXGuarder._54613E13);
		}
		catch
		{
		}
		weready = true;
	}

	private void ExecuteAction()
	{
	}

	private void vertext_MouseDown(object sender, MouseEventArgs e)
	{
	}

	private void SplashForm_FormClosing(object sender, FormClosingEventArgs e)
	{
		weready = true;
	}

	private void closbtn_Click(object sender, EventArgs e)
	{
		weready = true;
		Close();
	}
}
