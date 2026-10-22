using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace BTMOB;

[DesignerGenerated]
public class passchanger : basestyle
{
	[CompilerGenerated]
	private sealed class VB_0024StateMachine_116_Requestworker_DoWork : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncVoidMethodBuilder _0024Builder;

		internal object _0024VB_0024Local_sender;

		internal DoWorkEventArgs _0024VB_0024Local_e;

		internal passchanger _0024VB_0024Me;

		internal _Closure_0024__116_002D0 _0024VB_0024ResumableLocal__0024VB_0024Closure__00240;

		internal object _0024VB_0024ResumableLocal_data_00241;

		internal VB_0024AnonymousType_0<object, object, object, object> _0024VB_0024ResumableLocal_params_00242;

		internal string _0024VB_0024ResumableLocal_response_00243;

		internal _Closure_0024__116_002D1 _0024VB_0024ResumableLocal__0024VB_0024Closure__00244;

		internal TaskAwaiter<(bool, object)> _0024A0;

		internal _Closure_0024__116_002D0 _0024U1;

		[CompilerGenerated]
		internal void MoveNext()
		{
			int num = _0024State;
			try
			{
				switch (num)
				{
				default:
					try
					{
						TaskAwaiter<(bool, object)> awaiter;
						switch (num)
						{
						case -3:
							num = (_0024State = -1);
							return;
						default:
							_0024VB_0024ResumableLocal__0024VB_0024Closure__00240 = new _Closure_0024__116_002D0();
							_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Me = _0024VB_0024Me;
							_0024VB_0024ResumableLocal_data_00241 = RuntimeHelpers.GetObjectValue(_0024VB_0024Local_e.Argument);
							_0024VB_0024ResumableLocal_params_00242 = new VB_0024AnonymousType_0<object, object, object, object>(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(_0024VB_0024ResumableLocal_data_00241, null, "opass", new object[0], null, null, null)), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(_0024VB_0024ResumableLocal_data_00241, null, "npass", new object[0], null, null, null)), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(_0024VB_0024ResumableLocal_data_00241, null, "npassconf", new object[0], null, null, null)), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(_0024VB_0024ResumableLocal_data_00241, null, "scode", new object[0], null, null, null)));
							_0024U1 = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240;
							awaiter = MyServer.ChangePassword(_0024VB_0024ResumableLocal_params_00242, _0024VB_0024Me.srvinfo.MainhttpClient, _0024VB_0024Me.srvinfo.Address).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (_0024State = 0);
								_0024A0 = awaiter;
								ref AsyncVoidMethodBuilder reference = ref _0024Builder;
								VB_0024StateMachine_116_Requestworker_DoWork stateMachine = this;
								reference.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
								return;
							}
							break;
						case 0:
							num = (_0024State = -1);
							awaiter = _0024A0;
							_0024A0 = default(TaskAwaiter<(bool, object)>);
							break;
						}
						_Closure_0024__116_002D0 closure_0024__116_002D = _0024U1;
						(bool, object) result = awaiter.GetResult();
						awaiter = default(TaskAwaiter<(bool, object)>);
						closure_0024__116_002D._0024VB_0024Local_result = result;
						_0024U1 = null;
						if (_0024VB_0024Me.IsDisposed || !_0024VB_0024Me.IsHandleCreated)
						{
							break;
						}
						_0024VB_0024Me.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
						{
							_0024VB_0024Me.downbtn.Enabled = true;
							_0024VB_0024Me.loadingstate.Enabled = false;
							_0024VB_0024Me.loadingstate.Visible = false;
						}));
						if (_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_result.Item1)
						{
							_0024VB_0024ResumableLocal_response_00243 = Conversions.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_result.Item2, null, "Replace", new object[2] { "\\", "" }, null, null, null), null, "Trim", new object[1] { "\"" }, null, null, null)));
							_0024VB_0024Me.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
							{
								BTAlerter.Success(Conversions.ToString(_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_result.Item2));
								_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Me.DialogResult = DialogResult.OK;
								_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Me.Close();
							}));
						}
						else
						{
							_0024VB_0024Me.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
							{
								BTAlerter.erroes(Conversions.ToString(_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_result.Item2));
							}));
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						_0024VB_0024ResumableLocal__0024VB_0024Closure__00244 = new _Closure_0024__116_002D1();
						Exception _0024VB_0024Local_ex = ex;
						_0024VB_0024ResumableLocal__0024VB_0024Closure__00244._0024VB_0024Local_ex = _0024VB_0024Local_ex;
						_0024VB_0024Me.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
						{
							BTAlerter.erroes(_0024VB_0024ResumableLocal__0024VB_0024Closure__00244._0024VB_0024Local_ex.Message);
						}));
						ProjectData.ClearProjectError();
					}
					break;
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception exception = ex2;
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

	[CompilerGenerated]
	internal sealed class _Closure_0024__116_002D0
	{
		public (bool, object) _0024VB_0024Local_result;

		public passchanger _0024VB_0024Me;

		[SpecialName]
		internal void _Lambda_0024__1()
		{
			BTAlerter.Success(Conversions.ToString(_0024VB_0024Local_result.Item2));
			_0024VB_0024Me.DialogResult = DialogResult.OK;
			_0024VB_0024Me.Close();
		}

		[SpecialName]
		internal void _Lambda_0024__2()
		{
			BTAlerter.erroes(Conversions.ToString(_0024VB_0024Local_result.Item2));
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__116_002D1
	{
		public Exception _0024VB_0024Local_ex;

		[SpecialName]
		internal void _Lambda_0024__3()
		{
			BTAlerter.erroes(_0024VB_0024Local_ex.Message);
		}
	}

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dellall")]
	private DrakeUIButtonIcon _dellall;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("downbtn")]
	private DrakeUIButtonIcon _downbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Requestworker")]
	private BackgroundWorker _Requestworker;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Scode6")]
	private DrakeUITextBox _Scode6;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Scode1")]
	private DrakeUITextBox _Scode1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Scode2")]
	private DrakeUITextBox _Scode2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Scode3")]
	private DrakeUITextBox _Scode3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Scode4")]
	private DrakeUITextBox _Scode4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Scode5")]
	private DrakeUITextBox _Scode5;

	private ServersInfo srvinfo;

	[field: AccessedThroughProperty("Panel5")]
	internal virtual Panel Panel5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon dellall
	{
		[CompilerGenerated]
		get
		{
			return _dellall;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = dellall_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _dellall;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_dellall = value;
			drakeUIButtonIcon = _dellall;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DrakeWidth_W2")]
	internal new virtual DrakeWidth_W DrakeWidth_W2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon downbtn
	{
		[CompilerGenerated]
		get
		{
			return _downbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = downbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _downbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_downbtn = value;
			drakeUIButtonIcon = _downbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel24")]
	internal virtual Panel Panel24
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("labelname")]
	internal virtual DrakeUISymbolLabel labelname
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txt_oldpass")]
	internal virtual DrakeUITextBox txt_oldpass
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

	[field: AccessedThroughProperty("lblpass")]
	internal virtual DrakeUISymbolLabel lblpass
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txt_confNpass")]
	internal virtual DrakeUITextBox txt_confNpass
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel44")]
	internal virtual Panel Panel44
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ctrtext")]
	internal virtual DrakeUISymbolLabel ctrtext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txt_Npass")]
	internal virtual DrakeUITextBox txt_Npass
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("passquality")]
	internal virtual Label passquality
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel8")]
	internal virtual Panel Panel8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("loadingstate")]
	internal virtual DrakeUILoadingBar loadingstate
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual BackgroundWorker Requestworker
	{
		[CompilerGenerated]
		get
		{
			return _Requestworker;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DoWorkEventHandler value2 = Requestworker_DoWork;
			BackgroundWorker backgroundWorker = _Requestworker;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= value2;
			}
			_Requestworker = value;
			backgroundWorker = _Requestworker;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork += value2;
			}
		}
	}

	[field: AccessedThroughProperty("TableLayoutPanel1")]
	internal virtual TableLayoutPanel TableLayoutPanel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUITextBox Scode6
	{
		[CompilerGenerated]
		get
		{
			return _Scode6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Scode_TextChanged;
			DrakeUITextBox drakeUITextBox = _Scode6;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged -= value2;
			}
			_Scode6 = value;
			drakeUITextBox = _Scode6;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged += value2;
			}
		}
	}

	internal virtual DrakeUITextBox Scode1
	{
		[CompilerGenerated]
		get
		{
			return _Scode1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Scode_TextChanged;
			DrakeUITextBox drakeUITextBox = _Scode1;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged -= value2;
			}
			_Scode1 = value;
			drakeUITextBox = _Scode1;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged += value2;
			}
		}
	}

	internal virtual DrakeUITextBox Scode2
	{
		[CompilerGenerated]
		get
		{
			return _Scode2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Scode_TextChanged;
			DrakeUITextBox drakeUITextBox = _Scode2;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged -= value2;
			}
			_Scode2 = value;
			drakeUITextBox = _Scode2;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged += value2;
			}
		}
	}

	internal virtual DrakeUITextBox Scode3
	{
		[CompilerGenerated]
		get
		{
			return _Scode3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Scode_TextChanged;
			DrakeUITextBox drakeUITextBox = _Scode3;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged -= value2;
			}
			_Scode3 = value;
			drakeUITextBox = _Scode3;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUITextBox Scode4
	{
		[CompilerGenerated]
		get
		{
			return _Scode4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Scode_TextChanged;
			DrakeUITextBox drakeUITextBox = _Scode4;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged -= value2;
			}
			_Scode4 = value;
			drakeUITextBox = _Scode4;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged += value2;
			}
		}
	}

	internal virtual DrakeUITextBox Scode5
	{
		[CompilerGenerated]
		get
		{
			return _Scode5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Scode_TextChanged;
			DrakeUITextBox drakeUITextBox = _Scode5;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged -= value2;
			}
			_Scode5 = value;
			drakeUITextBox = _Scode5;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged += value2;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
	[System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		throw new System.AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public passchanger(ServersInfo srvf)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void translateme()
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void dellall_Click(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void downbtn_Click(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(VB_0024StateMachine_116_Requestworker_DoWork))]
	[DebuggerStepThrough]
	private void Requestworker_DoWork(object sender, DoWorkEventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Scode_TextChanged(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void passchanger_Load(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void passchanger_FormClosing(object sender, FormClosingEventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}
}
