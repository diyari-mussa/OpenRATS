using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace BTMOB;

public class ServersInfo : IEquatable<ServersInfo>
{
	[CompilerGenerated]
	private sealed class VB_0024StateMachine_85_StopServer : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncVoidMethodBuilder _0024Builder;

		internal ServersInfo _0024VB_0024Me;

		internal string _0024VB_0024ResumableLocal_nxtkey_00240;

		internal string _0024VB_0024ResumableLocal_minadf_00241;

		internal string _0024VB_0024ResumableLocal_datajoin_00242;

		internal Exception _0024VB_0024ResumableLocal_ex_00243;

		internal TaskAwaiter<string> _0024A0;

		[CompilerGenerated]
		internal void MoveNext()
		{
			int num = _0024State;
			try
			{
				TaskAwaiter<string> awaiter;
				if (num != 0)
				{
					_0024VB_0024Me.WSClient.ShouldReconnect = false;
					_0024VB_0024Me.WSClient.OutServer();
					_0024VB_0024Me.IsOnline = false;
					_0024VB_0024Me.Sstate = "offline";
					_0024VB_0024ResumableLocal_nxtkey_00240 = ServersMgr.GetServerNextKey(_0024VB_0024Me.Address);
					_0024VB_0024ResumableLocal_minadf_00241 = ServersMgr.GetServerIDF(_0024VB_0024Me.Address);
					Thread.Sleep(10);
					awaiter = MyServer.JoinServer(new VB_0024AnonymousType_7<string, string, string, string, string>("out", "1", "0", _0024VB_0024ResumableLocal_minadf_00241, _0024VB_0024ResumableLocal_nxtkey_00240), _0024VB_0024Me.MainhttpClient, _0024VB_0024Me.Address).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_0024State = 0);
						_0024A0 = awaiter;
						ref AsyncVoidMethodBuilder reference = ref _0024Builder;
						VB_0024StateMachine_85_StopServer stateMachine = this;
						reference.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
						return;
					}
				}
				else
				{
					num = (_0024State = -1);
					awaiter = _0024A0;
					_0024A0 = default(TaskAwaiter<string>);
				}
				string result = awaiter.GetResult();
				awaiter = default(TaskAwaiter<string>);
				_0024VB_0024ResumableLocal_datajoin_00242 = result;
				try
				{
					_0024VB_0024Me.WSClient.Disconnect("End Main", _0024VB_0024Me.Address);
					if (_0024VB_0024Me.connectionThread != null && _0024VB_0024Me.connectionThread.IsAlive)
					{
						_0024VB_0024Me.connectionThread.Abort();
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					_0024VB_0024ResumableLocal_ex_00243 = ex2;
					ProjectData.ClearProjectError();
				}
				if (_0024VB_0024Me.MainhttpClient != null)
				{
					_0024VB_0024Me.MainhttpClient.Dispose();
					_0024VB_0024Me.MainhttpClient = null;
				}
				if (_0024VB_0024Me.DownloadHttpClient != null)
				{
					_0024VB_0024Me.DownloadHttpClient.Dispose();
					_0024VB_0024Me.DownloadHttpClient = null;
				}
				_0024VB_0024Me.WSClient = null;
				_0024VB_0024Me.connectionThread = null;
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

	public HttpClient DownloadHttpClient;

	public HttpClient MainhttpClient;

	private CookieContainer cookieContainer;

	public Thread connectionThread;

	public readonly object lockworker;

	public string Sname { get; set; }

	public string Sstate { get; set; }

	public string SCkey { get; set; }

	public string Sid { get; set; }

	public string BTClientID { get; set; }

	public string Scolor { get; set; }

	public string Address { get; set; }

	public bool IsOnline { get; set; }

	public string PingMs { get; set; }

	public int TotalClients { get; set; }

	public string SflagBase { get; set; }

	public long BytesSent { get; set; }

	public long BytesReceived { get; set; }

	public WebSocketClient WSClient { get; set; }

	public string u_email { get; set; }

	public string share_link { get; set; }

	public string u_uid { get; set; }

	public string u_subtype { get; set; }

	public string u_exp { get; set; }

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ServersInfo(string address, string ServerId, string Servername, string serverkey, string colorstr)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Equals(ServersInfo other)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	bool IEquatable<ServersInfo>.Equals(ServersInfo other)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Equals
		return this.Equals(other);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool Equals(object obj)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetHashCode()
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(VB_0024StateMachine_85_StopServer))]
	[DebuggerStepThrough]
	public void StopServer()
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}
}
