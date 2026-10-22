using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;

namespace BTMOB;

[StandardModule]
internal sealed class useraccount
{
	[CompilerGenerated]
	private sealed class VB_0024StateMachine_1_SendPostRequestAsync : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncTaskMethodBuilder<string> _0024Builder;

		internal HttpClient _0024VB_0024Local_httpClient;

		internal Dictionary<string, string> _0024VB_0024Local_payload;

		internal string _0024VB_0024Local_serverip;

		internal string _0024VB_0024Local_filePath;

		internal UploadApp _0024VB_0024Local_uploadform;

		internal _Closure_0024__1_002D0 _0024VB_0024ResumableLocal__0024VB_0024Closure__00240;

		internal MultipartFormDataContent _0024VB_0024ResumableLocal_multiPartContent_00241;

		internal Dictionary<string, string>.Enumerator _0024S2;

		internal KeyValuePair<string, string> _0024VB_0024ResumableLocal_kvp_00243;

		internal FileStream _0024VB_0024ResumableLocal_fileStream_00244;

		internal StreamContent _0024VB_0024ResumableLocal_fileContent_00245;

		internal Progress<int> _0024VB_0024ResumableLocal_progress_00246;

		internal HttpContent _0024VB_0024ResumableLocal_requestContent_00247;

		internal object[] _0024S8;

		internal bool[] _0024S9;

		internal object _0024S10;

		internal object _0024VB_0024ResumableLocal_response_002411;

		internal object _0024VB_0024ResumableLocal_responseText_002412;

		internal Exception _0024VB_0024ResumableLocal_ex_002413;

		internal object _0024A0;

		[CompilerGenerated]
		internal void MoveNext()
		{
			int num = _0024State;
			string result;
			try
			{
				if (num != -3 && (uint)num > 1u)
				{
					_0024VB_0024ResumableLocal__0024VB_0024Closure__00240 = new _Closure_0024__1_002D0(_0024VB_0024ResumableLocal__0024VB_0024Closure__00240);
					_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_uploadform = _0024VB_0024Local_uploadform;
				}
				try
				{
					object obj5;
					object obj2;
					ICriticalNotifyCompletion awaiter3;
					object obj;
					switch (num)
					{
					case -3:
						num = (_0024State = -1);
						return;
					default:
					{
						_0024VB_0024ResumableLocal_multiPartContent_00241 = new MultipartFormDataContent();
						try
						{
							_0024S2 = _0024VB_0024Local_payload.GetEnumerator();
							while (_0024S2.MoveNext())
							{
								_0024VB_0024ResumableLocal_kvp_00243 = _0024S2.Current;
								_0024VB_0024ResumableLocal_multiPartContent_00241.Add(new StringContent(_0024VB_0024ResumableLocal_kvp_00243.Value), _0024VB_0024ResumableLocal_kvp_00243.Key);
							}
						}
						finally
						{
							if (num < 0)
							{
								((IDisposable)_0024S2/*cast due to .constrained prefix*/).Dispose();
							}
						}
						_0024VB_0024ResumableLocal_fileStream_00244 = new FileStream(_0024VB_0024Local_filePath, FileMode.Open, FileAccess.Read);
						_0024VB_0024ResumableLocal_fileContent_00245 = new StreamContent(_0024VB_0024ResumableLocal_fileStream_00244);
						_0024VB_0024ResumableLocal_fileContent_00245.Headers.ContentType = new MediaTypeHeaderValue("application/zip");
						_0024VB_0024ResumableLocal_multiPartContent_00241.Add(_0024VB_0024ResumableLocal_fileContent_00245, "file", Path.GetFileName(_0024VB_0024Local_filePath));
						_0024VB_0024ResumableLocal_progress_00246 = new Progress<int>([SpecialName] (int p) =>
						{
							if (_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_uploadform != null)
							{
								_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_uploadform.UpdateProgress(p);
							}
						});
						_0024VB_0024ResumableLocal_requestContent_00247 = new filestreamer(_0024VB_0024ResumableLocal_multiPartContent_00241, 16384, _0024VB_0024ResumableLocal_progress_00246);
						HttpClient instance = _0024VB_0024Local_httpClient;
						object[] obj3 = new object[2]
						{
							BTConst.getApiUrl(BTConst.api_useraccount, _0024VB_0024Local_serverip),
							_0024VB_0024ResumableLocal_requestContent_00247
						};
						object[] arguments = obj3;
						_0024S8 = obj3;
						bool[] obj4 = new bool[2] { false, true };
						bool[] copyBack = obj4;
						_0024S9 = obj4;
						_0024S10 = NewLateBinding.LateGet(instance, null, "PostAsync", arguments, null, null, copyBack);
						if (_0024S9[1])
						{
							_0024VB_0024ResumableLocal_requestContent_00247 = (HttpContent)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(_0024S8[1]), typeof(HttpContent));
						}
						obj2 = NewLateBinding.LateGet(_0024S10, null, "GetAwaiter", new object[0], null, null, null);
						if (Conversions.ToBoolean(NewLateBinding.LateGet(obj2, null, "IsCompleted", new object[0], null, null, null)))
						{
							goto IL_041c;
						}
						num = (_0024State = 0);
						_0024A0 = obj2;
						ICriticalNotifyCompletion awaiter = obj2 as ICriticalNotifyCompletion;
						if (awaiter != null)
						{
							ref AsyncTaskMethodBuilder<string> reference = ref _0024Builder;
							VB_0024StateMachine_1_SendPostRequestAsync stateMachine = this;
							reference.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
						}
						else
						{
							INotifyCompletion awaiter2 = (INotifyCompletion)obj2;
							ref AsyncTaskMethodBuilder<string> reference2 = ref _0024Builder;
							VB_0024StateMachine_1_SendPostRequestAsync stateMachine = this;
							reference2.AwaitOnCompleted(ref awaiter2, ref stateMachine);
						}
						return;
					}
					case 0:
						num = (_0024State = -1);
						obj2 = _0024A0;
						_0024A0 = null;
						goto IL_041c;
					case 1:
						{
							num = (_0024State = -1);
							obj = _0024A0;
							_0024A0 = null;
							break;
						}
						IL_041c:
						obj5 = NewLateBinding.LateGet(obj2, null, "GetResult", new object[0], null, null, null);
						obj2 = null;
						_0024VB_0024ResumableLocal_response_002411 = RuntimeHelpers.GetObjectValue(obj5);
						obj = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(_0024VB_0024ResumableLocal_response_002411, null, "Content", new object[0], null, null, null), null, "ReadAsStringAsync", new object[0], null, null, null), null, "GetAwaiter", new object[0], null, null, null);
						if (Conversions.ToBoolean(NewLateBinding.LateGet(obj, null, "IsCompleted", new object[0], null, null, null)))
						{
							break;
						}
						num = (_0024State = 1);
						_0024A0 = obj;
						awaiter3 = obj as ICriticalNotifyCompletion;
						if (awaiter3 != null)
						{
							ref AsyncTaskMethodBuilder<string> reference3 = ref _0024Builder;
							VB_0024StateMachine_1_SendPostRequestAsync stateMachine = this;
							reference3.AwaitUnsafeOnCompleted(ref awaiter3, ref stateMachine);
						}
						else
						{
							INotifyCompletion awaiter4 = (INotifyCompletion)obj;
							ref AsyncTaskMethodBuilder<string> reference4 = ref _0024Builder;
							VB_0024StateMachine_1_SendPostRequestAsync stateMachine = this;
							reference4.AwaitOnCompleted(ref awaiter4, ref stateMachine);
						}
						return;
					}
					object obj6 = NewLateBinding.LateGet(obj, null, "GetResult", new object[0], null, null, null);
					obj = null;
					_0024VB_0024ResumableLocal_responseText_002412 = RuntimeHelpers.GetObjectValue(obj6);
					result = Conversions.ToString(RuntimeHelpers.GetObjectValue(_0024VB_0024ResumableLocal_responseText_002412));
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					_0024VB_0024ResumableLocal_ex_002413 = ex2;
					result = $"Error: {_0024VB_0024ResumableLocal_ex_002413.Message}";
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
			num = (_0024State = -2);
			_0024Builder.SetResult(result);
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
	private sealed class VB_0024StateMachine_5_AddApp : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncTaskMethodBuilder<string> _0024Builder;

		internal HttpClient _0024VB_0024Local_httpClient;

		internal string _0024VB_0024Local_serverip;

		internal string _0024VB_0024Local_filePath;

		internal UploadApp _0024VB_0024Local_uploadform;

		internal Dictionary<string, string> _0024S0;

		internal Dictionary<string, string> _0024VB_0024ResumableLocal_payload_00241;

		internal TaskAwaiter<string> _0024A0;

		[CompilerGenerated]
		internal void MoveNext()
		{
			int num = _0024State;
			string result2;
			try
			{
				TaskAwaiter<string> awaiter;
				if (num != 0)
				{
					_0024S0 = new Dictionary<string, string>();
					_0024S0.Add("type", "app");
					_0024VB_0024ResumableLocal_payload_00241 = _0024S0;
					awaiter = SendPostRequestAsync(_0024VB_0024Local_httpClient, _0024VB_0024ResumableLocal_payload_00241, _0024VB_0024Local_serverip, _0024VB_0024Local_filePath, _0024VB_0024Local_uploadform).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_0024State = 0);
						_0024A0 = awaiter;
						ref AsyncTaskMethodBuilder<string> reference = ref _0024Builder;
						VB_0024StateMachine_5_AddApp stateMachine = this;
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
				result2 = result;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception exception = ex;
				_0024State = -2;
				_0024Builder.SetException(exception);
				ProjectData.ClearProjectError();
				return;
			}
			num = (_0024State = -2);
			_0024Builder.SetResult(result2);
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
	internal sealed class _Closure_0024__1_002D0
	{
		public UploadApp _0024VB_0024Local_uploadform;

		public _Closure_0024__1_002D0(_Closure_0024__1_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_uploadform = arg0._0024VB_0024Local_uploadform;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__0(int p)
		{
			if (_0024VB_0024Local_uploadform != null)
			{
				_0024VB_0024Local_uploadform.UpdateProgress(p);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string SendPostRequest(HttpClient httpClient, Dictionary<string, string> payload, string serverip, string filePath = null)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(VB_0024StateMachine_1_SendPostRequestAsync))]
	[DebuggerStepThrough]
	public static Task<string> SendPostRequestAsync(HttpClient httpClient, Dictionary<string, string> payload, string serverip, string filePath, UploadApp uploadform)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string RemoveIcon(HttpClient httpClient, string iconName, string serverip)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string ListIcons(HttpClient httpClient, string serverip)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string AddIcon(HttpClient httpClient, string serverip, string filePath)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(VB_0024StateMachine_5_AddApp))]
	[DebuggerStepThrough]
	public static Task<string> AddApp(HttpClient httpClient, string serverip, string filePath, UploadApp uploadform)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string ListKeys(HttpClient httpClient, string serverip)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string DeleteKey(HttpClient httpClient, string keyId, string serverip)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}
}
