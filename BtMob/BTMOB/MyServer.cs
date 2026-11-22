using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BTMOB;

[StandardModule]
internal sealed class MyServer
{
	[CompilerGenerated]
	private sealed class VB_0024StateMachine_0_startlogin : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncTaskMethodBuilder<(bool, string)> _0024Builder;

		internal string _0024VB_0024Local_uemail;

		internal string _0024VB_0024Local_upass;

		internal string _0024VB_0024Local_pinkey;

		internal string _0024VB_0024Local_rankey;

		internal HttpClient _0024VB_0024Local_client;

		internal string _0024VB_0024Local_Serverip;

		internal string _0024VB_0024ResumableLocal_hardwareid_00240;

		internal VB_0024AnonymousType_6<string, string, string, string, string, string> _0024VB_0024ResumableLocal_data_00241;

		internal string _0024VB_0024ResumableLocal_jsonData_00242;

		internal StringContent _0024VB_0024ResumableLocal_content_00243;

		internal object[] _0024S4;

		internal bool[] _0024S5;

		internal object _0024S6;

		internal HttpResponseMessage _0024VB_0024ResumableLocal_response_00247;

		internal string _0024VB_0024ResumableLocal_responseString_00248;

		internal JObject _0024VB_0024ResumableLocal_result_00249;

		internal string _0024VB_0024ResumableLocal_datastr_002410;

		internal Exception _0024VB_0024ResumableLocal_ex_002411;

		internal object _0024A0;

		internal TaskAwaiter<string> _0024A1;

		[CompilerGenerated]
		internal void MoveNext()
		{
			int num = _0024State;
			(bool, string) result;
			try
			{
				switch (num)
				{
				default:
					{
						try
						{
							object obj4;
							object obj;
							switch (num)
							{
							case -3:
								num = (_0024State = -1);
								return;
							default:
							{
								_0024VB_0024ResumableLocal_hardwareid_00240 = Conversions.ToString(RuntimeHelpers.GetObjectValue(Operators.AddObject(codes.GetHWID(), BTRegistry.GetValue("hd", ""))));
								_0024VB_0024ResumableLocal_data_00241 = new VB_0024AnonymousType_6<string, string, string, string, string, string>("BT-MOB", _0024VB_0024Local_uemail, _0024VB_0024Local_upass, _0024VB_0024Local_pinkey, _0024VB_0024ResumableLocal_hardwareid_00240, _0024VB_0024Local_rankey);
								_0024VB_0024ResumableLocal_jsonData_00242 = JsonConvert.SerializeObject(_0024VB_0024ResumableLocal_data_00241);
								_0024VB_0024ResumableLocal_content_00243 = new StringContent(_0024VB_0024ResumableLocal_jsonData_00242, Encoding.UTF8, "application/json");
								HttpClient instance = _0024VB_0024Local_client;
								object[] obj2 = new object[2]
								{
									BTConst.getApiUrl(BTConst.api_login, _0024VB_0024Local_Serverip),
									_0024VB_0024ResumableLocal_content_00243
								};
								object[] arguments = obj2;
								_0024S4 = obj2;
								bool[] obj3 = new bool[2] { false, true };
								bool[] copyBack = obj3;
								_0024S5 = obj3;
								_0024S6 = NewLateBinding.LateGet(instance, null, "PostAsync", arguments, null, null, copyBack);
								if (_0024S5[1])
								{
									_0024VB_0024ResumableLocal_content_00243 = (StringContent)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(_0024S4[1]), typeof(StringContent));
								}
								obj = NewLateBinding.LateGet(_0024S6, null, "GetAwaiter", new object[0], null, null, null);
								if (Conversions.ToBoolean(NewLateBinding.LateGet(obj, null, "IsCompleted", new object[0], null, null, null)))
								{
									goto IL_031a;
								}
								num = (_0024State = 0);
								_0024A0 = obj;
								ICriticalNotifyCompletion awaiter = obj as ICriticalNotifyCompletion;
								if (awaiter != null)
								{
									ref AsyncTaskMethodBuilder<(bool, string)> reference = ref _0024Builder;
									VB_0024StateMachine_0_startlogin stateMachine = this;
									reference.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
								}
								else
								{
									INotifyCompletion awaiter2 = (INotifyCompletion)obj;
									ref AsyncTaskMethodBuilder<(bool, string)> reference2 = ref _0024Builder;
									VB_0024StateMachine_0_startlogin stateMachine = this;
									reference2.AwaitOnCompleted(ref awaiter2, ref stateMachine);
								}
								return;
							}
							case 0:
								num = (_0024State = -1);
								obj = _0024A0;
								_0024A0 = null;
								goto IL_031a;
							case -4:
							case 1:
								break;
								IL_031a:
								obj4 = NewLateBinding.LateGet(obj, null, "GetResult", new object[0], null, null, null);
								obj = null;
								_0024VB_0024ResumableLocal_response_00247 = (HttpResponseMessage)obj4;
								break;
							}
							try
							{
								string result2;
								TaskAwaiter<string> awaiter3;
								switch (num)
								{
								case -4:
									num = (_0024State = -1);
									return;
								default:
									if (_0024VB_0024ResumableLocal_response_00247.IsSuccessStatusCode)
									{
										awaiter3 = _0024VB_0024ResumableLocal_response_00247.Content.ReadAsStringAsync().GetAwaiter();
										if (!awaiter3.IsCompleted)
										{
											num = (_0024State = 1);
											_0024A1 = awaiter3;
											ref AsyncTaskMethodBuilder<(bool, string)> reference3 = ref _0024Builder;
											VB_0024StateMachine_0_startlogin stateMachine = this;
											reference3.AwaitUnsafeOnCompleted(ref awaiter3, ref stateMachine);
											return;
										}
										goto IL_0454;
									}
									result = (false, "error: " + _0024VB_0024ResumableLocal_response_00247.StatusCode);
									break;
								case 1:
									{
										num = (_0024State = -1);
										awaiter3 = _0024A1;
										_0024A1 = default(TaskAwaiter<string>);
										goto IL_0454;
									}
									IL_0454:
									result2 = awaiter3.GetResult();
									awaiter3 = default(TaskAwaiter<string>);
									_0024VB_0024ResumableLocal_responseString_00248 = result2;
									_0024VB_0024ResumableLocal_result_00249 = JObject.Parse(_0024VB_0024ResumableLocal_responseString_00248);
									if (_0024VB_0024ResumableLocal_result_00249["Success"] != null)
									{
										_0024VB_0024ResumableLocal_datastr_002410 = _0024VB_0024ResumableLocal_result_00249["Success"].ToString().Trim('"');
										Debuger.Log_d("AuthenticateJector", _0024VB_0024ResumableLocal_result_00249["Success"].ToString());
										result = (true, _0024VB_0024ResumableLocal_datastr_002410);
										break;
									}
									if (_0024VB_0024ResumableLocal_result_00249["Fail"] != null)
									{
										result = (false, "failed: " + _0024VB_0024ResumableLocal_result_00249["Fail"].ToString());
										break;
									}
									goto IL_063b;
								}
							}
							finally
							{
								if (num < 0 && _0024VB_0024ResumableLocal_response_00247 != null)
								{
									((IDisposable)_0024VB_0024ResumableLocal_response_00247).Dispose();
								}
							}
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							_0024VB_0024ResumableLocal_ex_002411 = ex2;
							result = (false, "Error: can't connect to server");
							ProjectData.ClearProjectError();
						}
						break;
					}
					IL_063b:
					result = (false, "Unexpected error.");
					break;
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
	private sealed class VB_0024StateMachine_1_FetchStore : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncTaskMethodBuilder<(bool, object)> _0024Builder;

		internal object _0024VB_0024Local_params;

		internal HttpClient _0024VB_0024Local_client;

		internal string _0024VB_0024Local_serverip;

		internal string _0024VB_0024ResumableLocal_jsonData_00240;

		internal StringContent _0024VB_0024ResumableLocal_content_00241;

		internal object[] _0024S2;

		internal bool[] _0024S3;

		internal object _0024S4;

		internal HttpResponseMessage _0024VB_0024ResumableLocal_response_00245;

		internal string _0024VB_0024ResumableLocal_responseString_00246;

		internal JObject _0024VB_0024ResumableLocal_result_00247;

		internal byte[] _0024VB_0024ResumableLocal_rawBytes_00248;

		internal Exception _0024VB_0024ResumableLocal_ex_00249;

		internal object _0024A0;

		internal TaskAwaiter<string> _0024A1;

		internal TaskAwaiter<byte[]> _0024A2;

		[CompilerGenerated]
		internal void MoveNext()
		{
			int num = _0024State;
			(bool, object) result;
			try
			{
				switch (num)
				{
				default:
					try
					{
						object obj4;
						object obj;
						switch (num)
						{
						case -3:
							num = (_0024State = -1);
							return;
						default:
						{
							_0024VB_0024ResumableLocal_jsonData_00240 = JsonConvert.SerializeObject(RuntimeHelpers.GetObjectValue(_0024VB_0024Local_params));
							_0024VB_0024ResumableLocal_content_00241 = new StringContent(_0024VB_0024ResumableLocal_jsonData_00240, Encoding.UTF8, "application/json");
							HttpClient instance = _0024VB_0024Local_client;
							object[] obj2 = new object[2]
							{
								BTConst.getApiUrl(BTConst.api_fetchstore, _0024VB_0024Local_serverip),
								_0024VB_0024ResumableLocal_content_00241
							};
							object[] arguments = obj2;
							_0024S2 = obj2;
							bool[] obj3 = new bool[2] { false, true };
							bool[] copyBack = obj3;
							_0024S3 = obj3;
							_0024S4 = NewLateBinding.LateGet(instance, null, "PostAsync", arguments, null, null, copyBack);
							if (_0024S3[1])
							{
								_0024VB_0024ResumableLocal_content_00241 = (StringContent)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(_0024S2[1]), typeof(StringContent));
							}
							obj = NewLateBinding.LateGet(_0024S4, null, "GetAwaiter", new object[0], null, null, null);
							if (Conversions.ToBoolean(NewLateBinding.LateGet(obj, null, "IsCompleted", new object[0], null, null, null)))
							{
								goto IL_02b7;
							}
							num = (_0024State = 0);
							_0024A0 = obj;
							ICriticalNotifyCompletion awaiter = obj as ICriticalNotifyCompletion;
							if (awaiter != null)
							{
								ref AsyncTaskMethodBuilder<(bool, object)> reference = ref _0024Builder;
								VB_0024StateMachine_1_FetchStore stateMachine = this;
								reference.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
							}
							else
							{
								INotifyCompletion awaiter2 = (INotifyCompletion)obj;
								ref AsyncTaskMethodBuilder<(bool, object)> reference2 = ref _0024Builder;
								VB_0024StateMachine_1_FetchStore stateMachine = this;
								reference2.AwaitOnCompleted(ref awaiter2, ref stateMachine);
							}
							return;
						}
						case 0:
							num = (_0024State = -1);
							obj = _0024A0;
							_0024A0 = null;
							goto IL_02b7;
						case -4:
						case 1:
						case 2:
							break;
							IL_02b7:
							obj4 = NewLateBinding.LateGet(obj, null, "GetResult", new object[0], null, null, null);
							obj = null;
							_0024VB_0024ResumableLocal_response_00245 = (HttpResponseMessage)obj4;
							break;
						}
						try
						{
							TaskAwaiter<string> awaiter3;
							TaskAwaiter<byte[]> awaiter4;
							if (num != -4)
							{
								if (num != 1)
								{
									if (num != 2)
									{
										if (_0024VB_0024ResumableLocal_response_00245.IsSuccessStatusCode)
										{
											awaiter3 = _0024VB_0024ResumableLocal_response_00245.Content.ReadAsStringAsync().GetAwaiter();
											if (!awaiter3.IsCompleted)
											{
												num = (_0024State = 1);
												_0024A1 = awaiter3;
												ref AsyncTaskMethodBuilder<(bool, object)> reference3 = ref _0024Builder;
												VB_0024StateMachine_1_FetchStore stateMachine = this;
												reference3.AwaitUnsafeOnCompleted(ref awaiter3, ref stateMachine);
												return;
											}
											goto IL_0409;
										}
										result = (false, "HTTP error: " + _0024VB_0024ResumableLocal_response_00245.StatusCode);
										break;
									}
									num = (_0024State = -1);
									awaiter4 = _0024A2;
									_0024A2 = default(TaskAwaiter<byte[]>);
									goto IL_0642;
								}
								num = (_0024State = -1);
								awaiter3 = _0024A1;
								_0024A1 = default(TaskAwaiter<string>);
								goto IL_0409;
							}
							num = (_0024State = -1);
							return;
							IL_0409:
							string result2 = awaiter3.GetResult();
							awaiter3 = default(TaskAwaiter<string>);
							_0024VB_0024ResumableLocal_responseString_00246 = result2;
							if (Operators.CompareString(_0024VB_0024ResumableLocal_response_00245.Content.Headers.ContentType.MediaType, "application/json", TextCompare: false) == 0)
							{
								_0024VB_0024ResumableLocal_result_00247 = JObject.Parse(_0024VB_0024ResumableLocal_responseString_00246);
								result = ((_0024VB_0024ResumableLocal_result_00247["Success"] != null) ? (true, _0024VB_0024ResumableLocal_result_00247["Success"].ToString()) : ((_0024VB_0024ResumableLocal_result_00247["Req"] != null) ? (true, (object)_0024VB_0024ResumableLocal_result_00247["Req"].ToString()) : (((bool, object))((_0024VB_0024ResumableLocal_result_00247["Fail"] == null) ? (false, "Unknown response format: " + _0024VB_0024ResumableLocal_responseString_00246) : (false, "Fail: " + _0024VB_0024ResumableLocal_result_00247["Fail"].ToString())))));
								break;
							}
							awaiter4 = _0024VB_0024ResumableLocal_response_00245.Content.ReadAsByteArrayAsync().GetAwaiter();
							if (!awaiter4.IsCompleted)
							{
								num = (_0024State = 2);
								_0024A2 = awaiter4;
								ref AsyncTaskMethodBuilder<(bool, object)> reference4 = ref _0024Builder;
								VB_0024StateMachine_1_FetchStore stateMachine = this;
								reference4.AwaitUnsafeOnCompleted(ref awaiter4, ref stateMachine);
								return;
							}
							goto IL_0642;
							IL_0642:
							byte[] result3 = awaiter4.GetResult();
							awaiter4 = default(TaskAwaiter<byte[]>);
							_0024VB_0024ResumableLocal_rawBytes_00248 = result3;
							result = (true, _0024VB_0024ResumableLocal_rawBytes_00248);
						}
						finally
						{
							if (num < 0 && _0024VB_0024ResumableLocal_response_00245 != null)
							{
								((IDisposable)_0024VB_0024ResumableLocal_response_00245).Dispose();
							}
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						_0024VB_0024ResumableLocal_ex_00249 = ex2;
						result = (false, "Error: " + _0024VB_0024ResumableLocal_ex_00249.Message);
						ProjectData.ClearProjectError();
					}
					break;
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
	private sealed class VB_0024StateMachine_2_FetchAppsAPI : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncTaskMethodBuilder<(bool, object)> _0024Builder;

		internal object _0024VB_0024Local_params;

		internal HttpClient _0024VB_0024Local_client;

		internal string _0024VB_0024Local_serverip;

		internal string _0024VB_0024ResumableLocal_jsonData_00240;

		internal StringContent _0024VB_0024ResumableLocal_content_00241;

		internal object[] _0024S2;

		internal bool[] _0024S3;

		internal object _0024S4;

		internal HttpResponseMessage _0024VB_0024ResumableLocal_response_00245;

		internal string _0024VB_0024ResumableLocal_responseString_00246;

		internal JObject _0024VB_0024ResumableLocal_result_00247;

		internal Exception _0024VB_0024ResumableLocal_ex_00248;

		internal object _0024A0;

		internal TaskAwaiter<string> _0024A1;

		[CompilerGenerated]
		internal void MoveNext()
		{
			int num = _0024State;
			(bool, object) result;
			try
			{
				switch (num)
				{
				default:
					try
					{
						object obj4;
						object obj;
						switch (num)
						{
						case -3:
							num = (_0024State = -1);
							return;
						default:
						{
							_0024VB_0024ResumableLocal_jsonData_00240 = JsonConvert.SerializeObject(RuntimeHelpers.GetObjectValue(_0024VB_0024Local_params));
							_0024VB_0024ResumableLocal_content_00241 = new StringContent(_0024VB_0024ResumableLocal_jsonData_00240, Encoding.UTF8, "application/json");
							HttpClient instance = _0024VB_0024Local_client;
							object[] obj2 = new object[2]
							{
								BTConst.getApiUrl(BTConst.api_userstoreapps, _0024VB_0024Local_serverip),
								_0024VB_0024ResumableLocal_content_00241
							};
							object[] arguments = obj2;
							_0024S2 = obj2;
							bool[] obj3 = new bool[2] { false, true };
							bool[] copyBack = obj3;
							_0024S3 = obj3;
							_0024S4 = NewLateBinding.LateGet(instance, null, "PostAsync", arguments, null, null, copyBack);
							if (_0024S3[1])
							{
								_0024VB_0024ResumableLocal_content_00241 = (StringContent)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(_0024S2[1]), typeof(StringContent));
							}
							obj = NewLateBinding.LateGet(_0024S4, null, "GetAwaiter", new object[0], null, null, null);
							if (Conversions.ToBoolean(NewLateBinding.LateGet(obj, null, "IsCompleted", new object[0], null, null, null)))
							{
								goto IL_02b3;
							}
							num = (_0024State = 0);
							_0024A0 = obj;
							ICriticalNotifyCompletion awaiter = obj as ICriticalNotifyCompletion;
							if (awaiter != null)
							{
								ref AsyncTaskMethodBuilder<(bool, object)> reference = ref _0024Builder;
								VB_0024StateMachine_2_FetchAppsAPI stateMachine = this;
								reference.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
							}
							else
							{
								INotifyCompletion awaiter2 = (INotifyCompletion)obj;
								ref AsyncTaskMethodBuilder<(bool, object)> reference2 = ref _0024Builder;
								VB_0024StateMachine_2_FetchAppsAPI stateMachine = this;
								reference2.AwaitOnCompleted(ref awaiter2, ref stateMachine);
							}
							return;
						}
						case 0:
							num = (_0024State = -1);
							obj = _0024A0;
							_0024A0 = null;
							goto IL_02b3;
						case -4:
						case 1:
							break;
							IL_02b3:
							obj4 = NewLateBinding.LateGet(obj, null, "GetResult", new object[0], null, null, null);
							obj = null;
							_0024VB_0024ResumableLocal_response_00245 = (HttpResponseMessage)obj4;
							break;
						}
						try
						{
							string result2;
							TaskAwaiter<string> awaiter3;
							switch (num)
							{
							case -4:
								num = (_0024State = -1);
								return;
							default:
								if (_0024VB_0024ResumableLocal_response_00245.IsSuccessStatusCode)
								{
									awaiter3 = _0024VB_0024ResumableLocal_response_00245.Content.ReadAsStringAsync().GetAwaiter();
									if (!awaiter3.IsCompleted)
									{
										num = (_0024State = 1);
										_0024A1 = awaiter3;
										ref AsyncTaskMethodBuilder<(bool, object)> reference3 = ref _0024Builder;
										VB_0024StateMachine_2_FetchAppsAPI stateMachine = this;
										reference3.AwaitUnsafeOnCompleted(ref awaiter3, ref stateMachine);
										return;
									}
									goto IL_03ed;
								}
								result = (false, "HTTP error: " + _0024VB_0024ResumableLocal_response_00245.StatusCode);
								break;
							case 1:
								{
									num = (_0024State = -1);
									awaiter3 = _0024A1;
									_0024A1 = default(TaskAwaiter<string>);
									goto IL_03ed;
								}
								IL_03ed:
								result2 = awaiter3.GetResult();
								awaiter3 = default(TaskAwaiter<string>);
								_0024VB_0024ResumableLocal_responseString_00246 = result2;
								if (Operators.CompareString(_0024VB_0024ResumableLocal_response_00245.Content.Headers.ContentType.MediaType, "application/json", TextCompare: false) == 0)
								{
									_0024VB_0024ResumableLocal_result_00247 = JObject.Parse(_0024VB_0024ResumableLocal_responseString_00246);
									result = ((_0024VB_0024ResumableLocal_result_00247["Success"] == null) ? ((_0024VB_0024ResumableLocal_result_00247["Req"] == null) ? (((bool, object))((_0024VB_0024ResumableLocal_result_00247["Fail"] == null) ? (false, "Unknown response format: " + _0024VB_0024ResumableLocal_responseString_00246) : (false, "Fail: " + _0024VB_0024ResumableLocal_result_00247["Fail"].ToString()))) : (true, (object)_0024VB_0024ResumableLocal_result_00247["Req"].ToString())) : (true, _0024VB_0024ResumableLocal_result_00247["Success"].ToString()));
								}
								else
								{
									result = (false, "Unknown response 2: ");
								}
								break;
							}
						}
						finally
						{
							if (num < 0 && _0024VB_0024ResumableLocal_response_00245 != null)
							{
								((IDisposable)_0024VB_0024ResumableLocal_response_00245).Dispose();
							}
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						_0024VB_0024ResumableLocal_ex_00248 = ex2;
						result = (false, "Error: " + _0024VB_0024ResumableLocal_ex_00248.Message);
						ProjectData.ClearProjectError();
					}
					break;
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
	private sealed class VB_0024StateMachine_3_FetchUpdates : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncTaskMethodBuilder<(bool, object)> _0024Builder;

		internal object _0024VB_0024Local_params;

		internal HttpClient _0024VB_0024Local_client;

		internal string _0024VB_0024Local_serverip;

		internal string _0024VB_0024ResumableLocal_jsonData_00240;

		internal StringContent _0024VB_0024ResumableLocal_content_00241;

		internal object[] _0024S2;

		internal bool[] _0024S3;

		internal object _0024S4;

		internal HttpResponseMessage _0024VB_0024ResumableLocal_response_00245;

		internal string _0024VB_0024ResumableLocal_responseString_00246;

		internal JObject _0024VB_0024ResumableLocal_result_00247;

		internal Exception _0024VB_0024ResumableLocal_ex_00248;

		internal object _0024A0;

		internal TaskAwaiter<string> _0024A1;

		[CompilerGenerated]
		internal void MoveNext()
		{
			int num = _0024State;
			(bool, object) result;
			try
			{
				switch (num)
				{
				default:
					try
					{
						object obj4;
						object obj;
						switch (num)
						{
						case -3:
							num = (_0024State = -1);
							return;
						default:
						{
							_0024VB_0024ResumableLocal_jsonData_00240 = JsonConvert.SerializeObject(RuntimeHelpers.GetObjectValue(_0024VB_0024Local_params));
							_0024VB_0024ResumableLocal_content_00241 = new StringContent(_0024VB_0024ResumableLocal_jsonData_00240, Encoding.UTF8, "application/json");
							HttpClient instance = _0024VB_0024Local_client;
							object[] obj2 = new object[2]
							{
								BTConst.getApiUrl(BTConst.api_updates, _0024VB_0024Local_serverip),
								_0024VB_0024ResumableLocal_content_00241
							};
							object[] arguments = obj2;
							_0024S2 = obj2;
							bool[] obj3 = new bool[2] { false, true };
							bool[] copyBack = obj3;
							_0024S3 = obj3;
							_0024S4 = NewLateBinding.LateGet(instance, null, "PostAsync", arguments, null, null, copyBack);
							if (_0024S3[1])
							{
								_0024VB_0024ResumableLocal_content_00241 = (StringContent)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(_0024S2[1]), typeof(StringContent));
							}
							obj = NewLateBinding.LateGet(_0024S4, null, "GetAwaiter", new object[0], null, null, null);
							if (Conversions.ToBoolean(NewLateBinding.LateGet(obj, null, "IsCompleted", new object[0], null, null, null)))
							{
								goto IL_02b3;
							}
							num = (_0024State = 0);
							_0024A0 = obj;
							ICriticalNotifyCompletion awaiter = obj as ICriticalNotifyCompletion;
							if (awaiter != null)
							{
								ref AsyncTaskMethodBuilder<(bool, object)> reference = ref _0024Builder;
								VB_0024StateMachine_3_FetchUpdates stateMachine = this;
								reference.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
							}
							else
							{
								INotifyCompletion awaiter2 = (INotifyCompletion)obj;
								ref AsyncTaskMethodBuilder<(bool, object)> reference2 = ref _0024Builder;
								VB_0024StateMachine_3_FetchUpdates stateMachine = this;
								reference2.AwaitOnCompleted(ref awaiter2, ref stateMachine);
							}
							return;
						}
						case 0:
							num = (_0024State = -1);
							obj = _0024A0;
							_0024A0 = null;
							goto IL_02b3;
						case -4:
						case 1:
							break;
							IL_02b3:
							obj4 = NewLateBinding.LateGet(obj, null, "GetResult", new object[0], null, null, null);
							obj = null;
							_0024VB_0024ResumableLocal_response_00245 = (HttpResponseMessage)obj4;
							break;
						}
						try
						{
							string result2;
							TaskAwaiter<string> awaiter3;
							switch (num)
							{
							case -4:
								num = (_0024State = -1);
								return;
							default:
								if (_0024VB_0024ResumableLocal_response_00245.IsSuccessStatusCode)
								{
									awaiter3 = _0024VB_0024ResumableLocal_response_00245.Content.ReadAsStringAsync().GetAwaiter();
									if (!awaiter3.IsCompleted)
									{
										num = (_0024State = 1);
										_0024A1 = awaiter3;
										ref AsyncTaskMethodBuilder<(bool, object)> reference3 = ref _0024Builder;
										VB_0024StateMachine_3_FetchUpdates stateMachine = this;
										reference3.AwaitUnsafeOnCompleted(ref awaiter3, ref stateMachine);
										return;
									}
									goto IL_03ed;
								}
								result = (false, "HTTP error: " + _0024VB_0024ResumableLocal_response_00245.StatusCode);
								break;
							case 1:
								{
									num = (_0024State = -1);
									awaiter3 = _0024A1;
									_0024A1 = default(TaskAwaiter<string>);
									goto IL_03ed;
								}
								IL_03ed:
								result2 = awaiter3.GetResult();
								awaiter3 = default(TaskAwaiter<string>);
								_0024VB_0024ResumableLocal_responseString_00246 = result2;
								if (Operators.CompareString(_0024VB_0024ResumableLocal_response_00245.Content.Headers.ContentType.MediaType, "application/json", TextCompare: false) == 0)
								{
									_0024VB_0024ResumableLocal_result_00247 = JObject.Parse(_0024VB_0024ResumableLocal_responseString_00246);
									result = ((_0024VB_0024ResumableLocal_result_00247["Success"] == null) ? ((_0024VB_0024ResumableLocal_result_00247["Req"] == null) ? (((bool, object))((_0024VB_0024ResumableLocal_result_00247["Fail"] == null) ? (false, "Unknown response format: " + _0024VB_0024ResumableLocal_responseString_00246) : (false, "Fail: " + _0024VB_0024ResumableLocal_result_00247["Fail"].ToString()))) : (true, (object)_0024VB_0024ResumableLocal_result_00247["Req"].ToString())) : (true, _0024VB_0024ResumableLocal_result_00247["Success"].ToString()));
								}
								else
								{
									result = (false, "Unknown response 2: ");
								}
								break;
							}
						}
						finally
						{
							if (num < 0 && _0024VB_0024ResumableLocal_response_00245 != null)
							{
								((IDisposable)_0024VB_0024ResumableLocal_response_00245).Dispose();
							}
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						_0024VB_0024ResumableLocal_ex_00248 = ex2;
						result = (false, "Error: " + _0024VB_0024ResumableLocal_ex_00248.Message);
						ProjectData.ClearProjectError();
					}
					break;
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
	private sealed class VB_0024StateMachine_4_ChangePassword : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncTaskMethodBuilder<(bool, object)> _0024Builder;

		internal object _0024VB_0024Local_params;

		internal HttpClient _0024VB_0024Local_client;

		internal string _0024VB_0024Local_serverip;

		internal string _0024VB_0024ResumableLocal_jsonData_00240;

		internal StringContent _0024VB_0024ResumableLocal_content_00241;

		internal object[] _0024S2;

		internal bool[] _0024S3;

		internal object _0024S4;

		internal HttpResponseMessage _0024VB_0024ResumableLocal_response_00245;

		internal string _0024VB_0024ResumableLocal_responseString_00246;

		internal JObject _0024VB_0024ResumableLocal_result_00247;

		internal Exception _0024VB_0024ResumableLocal_ex_00248;

		internal object _0024A0;

		internal TaskAwaiter<string> _0024A1;

		[CompilerGenerated]
		internal void MoveNext()
		{
			int num = _0024State;
			(bool, object) result;
			try
			{
				switch (num)
				{
				default:
					try
					{
						object obj4;
						object obj;
						switch (num)
						{
						case -3:
							num = (_0024State = -1);
							return;
						default:
						{
							_0024VB_0024ResumableLocal_jsonData_00240 = JsonConvert.SerializeObject(RuntimeHelpers.GetObjectValue(_0024VB_0024Local_params));
							_0024VB_0024ResumableLocal_content_00241 = new StringContent(_0024VB_0024ResumableLocal_jsonData_00240, Encoding.UTF8, "application/json");
							HttpClient instance = _0024VB_0024Local_client;
							object[] obj2 = new object[2]
							{
								BTConst.getApiUrl(BTConst.api_changepassword, _0024VB_0024Local_serverip),
								_0024VB_0024ResumableLocal_content_00241
							};
							object[] arguments = obj2;
							_0024S2 = obj2;
							bool[] obj3 = new bool[2] { false, true };
							bool[] copyBack = obj3;
							_0024S3 = obj3;
							_0024S4 = NewLateBinding.LateGet(instance, null, "PostAsync", arguments, null, null, copyBack);
							if (_0024S3[1])
							{
								_0024VB_0024ResumableLocal_content_00241 = (StringContent)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(_0024S2[1]), typeof(StringContent));
							}
							obj = NewLateBinding.LateGet(_0024S4, null, "GetAwaiter", new object[0], null, null, null);
							if (Conversions.ToBoolean(NewLateBinding.LateGet(obj, null, "IsCompleted", new object[0], null, null, null)))
							{
								goto IL_02b3;
							}
							num = (_0024State = 0);
							_0024A0 = obj;
							ICriticalNotifyCompletion awaiter = obj as ICriticalNotifyCompletion;
							if (awaiter != null)
							{
								ref AsyncTaskMethodBuilder<(bool, object)> reference = ref _0024Builder;
								VB_0024StateMachine_4_ChangePassword stateMachine = this;
								reference.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
							}
							else
							{
								INotifyCompletion awaiter2 = (INotifyCompletion)obj;
								ref AsyncTaskMethodBuilder<(bool, object)> reference2 = ref _0024Builder;
								VB_0024StateMachine_4_ChangePassword stateMachine = this;
								reference2.AwaitOnCompleted(ref awaiter2, ref stateMachine);
							}
							return;
						}
						case 0:
							num = (_0024State = -1);
							obj = _0024A0;
							_0024A0 = null;
							goto IL_02b3;
						case -4:
						case 1:
							break;
							IL_02b3:
							obj4 = NewLateBinding.LateGet(obj, null, "GetResult", new object[0], null, null, null);
							obj = null;
							_0024VB_0024ResumableLocal_response_00245 = (HttpResponseMessage)obj4;
							break;
						}
						try
						{
							string result2;
							TaskAwaiter<string> awaiter3;
							switch (num)
							{
							case -4:
								num = (_0024State = -1);
								return;
							default:
								if (_0024VB_0024ResumableLocal_response_00245.IsSuccessStatusCode)
								{
									awaiter3 = _0024VB_0024ResumableLocal_response_00245.Content.ReadAsStringAsync().GetAwaiter();
									if (!awaiter3.IsCompleted)
									{
										num = (_0024State = 1);
										_0024A1 = awaiter3;
										ref AsyncTaskMethodBuilder<(bool, object)> reference3 = ref _0024Builder;
										VB_0024StateMachine_4_ChangePassword stateMachine = this;
										reference3.AwaitUnsafeOnCompleted(ref awaiter3, ref stateMachine);
										return;
									}
									goto IL_03ed;
								}
								result = (false, "HTTP error: " + _0024VB_0024ResumableLocal_response_00245.StatusCode);
								break;
							case 1:
								{
									num = (_0024State = -1);
									awaiter3 = _0024A1;
									_0024A1 = default(TaskAwaiter<string>);
									goto IL_03ed;
								}
								IL_03ed:
								result2 = awaiter3.GetResult();
								awaiter3 = default(TaskAwaiter<string>);
								_0024VB_0024ResumableLocal_responseString_00246 = result2;
								if (Operators.CompareString(_0024VB_0024ResumableLocal_response_00245.Content.Headers.ContentType.MediaType, "application/json", TextCompare: false) == 0)
								{
									_0024VB_0024ResumableLocal_result_00247 = JObject.Parse(_0024VB_0024ResumableLocal_responseString_00246);
									result = ((_0024VB_0024ResumableLocal_result_00247["Success"] == null) ? ((_0024VB_0024ResumableLocal_result_00247["Fail"] == null) ? (false, (object)("Unknown response format: " + _0024VB_0024ResumableLocal_responseString_00246)) : (false, (object)_0024VB_0024ResumableLocal_result_00247["Fail"].ToString())) : (true, _0024VB_0024ResumableLocal_result_00247["Success"].ToString()));
								}
								else
								{
									result = (false, "Invalid content type.");
								}
								break;
							}
						}
						finally
						{
							if (num < 0 && _0024VB_0024ResumableLocal_response_00245 != null)
							{
								((IDisposable)_0024VB_0024ResumableLocal_response_00245).Dispose();
							}
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						_0024VB_0024ResumableLocal_ex_00248 = ex2;
						result = (false, "Error: " + _0024VB_0024ResumableLocal_ex_00248.Message);
						ProjectData.ClearProjectError();
					}
					break;
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
	private sealed class VB_0024StateMachine_5_FetchCustomAPI : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncTaskMethodBuilder<(bool, object)> _0024Builder;

		internal object _0024VB_0024Local_params;

		internal HttpClient _0024VB_0024Local_client;

		internal string _0024VB_0024Local_serverip;

		internal string _0024VB_0024ResumableLocal_jsonData_00240;

		internal StringContent _0024VB_0024ResumableLocal_content_00241;

		internal object[] _0024S2;

		internal bool[] _0024S3;

		internal object _0024S4;

		internal HttpResponseMessage _0024VB_0024ResumableLocal_response_00245;

		internal string _0024VB_0024ResumableLocal_contentType_00246;

		internal string _0024VB_0024ResumableLocal_responseString_00247;

		internal JObject _0024VB_0024ResumableLocal_result_00248;

		internal Exception _0024VB_0024ResumableLocal_ex_00249;

		internal object _0024A0;

		internal TaskAwaiter<string> _0024A1;

		[CompilerGenerated]
		internal void MoveNext()
		{
			int num = _0024State;
			(bool, object) result;
			try
			{
				switch (num)
				{
				default:
					try
					{
						object obj4;
						object obj;
						switch (num)
						{
						case -3:
							num = (_0024State = -1);
							return;
						default:
						{
							_0024VB_0024ResumableLocal_jsonData_00240 = JsonConvert.SerializeObject(RuntimeHelpers.GetObjectValue(_0024VB_0024Local_params));
							_0024VB_0024ResumableLocal_content_00241 = new StringContent(_0024VB_0024ResumableLocal_jsonData_00240, Encoding.UTF8, "application/json");
							HttpClient instance = _0024VB_0024Local_client;
							object[] obj2 = new object[2]
							{
								BTConst.getApiUrl(BTConst.api_usercustomapps, _0024VB_0024Local_serverip),
								_0024VB_0024ResumableLocal_content_00241
							};
							object[] arguments = obj2;
							_0024S2 = obj2;
							bool[] obj3 = new bool[2] { false, true };
							bool[] copyBack = obj3;
							_0024S3 = obj3;
							_0024S4 = NewLateBinding.LateGet(instance, null, "PostAsync", arguments, null, null, copyBack);
							if (_0024S3[1])
							{
								_0024VB_0024ResumableLocal_content_00241 = (StringContent)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(_0024S2[1]), typeof(StringContent));
							}
							obj = NewLateBinding.LateGet(_0024S4, null, "GetAwaiter", new object[0], null, null, null);
							if (Conversions.ToBoolean(NewLateBinding.LateGet(obj, null, "IsCompleted", new object[0], null, null, null)))
							{
								goto IL_02b3;
							}
							num = (_0024State = 0);
							_0024A0 = obj;
							ICriticalNotifyCompletion awaiter = obj as ICriticalNotifyCompletion;
							if (awaiter != null)
							{
								ref AsyncTaskMethodBuilder<(bool, object)> reference = ref _0024Builder;
								VB_0024StateMachine_5_FetchCustomAPI stateMachine = this;
								reference.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
							}
							else
							{
								INotifyCompletion awaiter2 = (INotifyCompletion)obj;
								ref AsyncTaskMethodBuilder<(bool, object)> reference2 = ref _0024Builder;
								VB_0024StateMachine_5_FetchCustomAPI stateMachine = this;
								reference2.AwaitOnCompleted(ref awaiter2, ref stateMachine);
							}
							return;
						}
						case 0:
							num = (_0024State = -1);
							obj = _0024A0;
							_0024A0 = null;
							goto IL_02b3;
						case -4:
						case 1:
							break;
							IL_02b3:
							obj4 = NewLateBinding.LateGet(obj, null, "GetResult", new object[0], null, null, null);
							obj = null;
							_0024VB_0024ResumableLocal_response_00245 = (HttpResponseMessage)obj4;
							break;
						}
						try
						{
							string result2;
							TaskAwaiter<string> awaiter3;
							switch (num)
							{
							case -4:
								num = (_0024State = -1);
								return;
							default:
								if (_0024VB_0024ResumableLocal_response_00245.IsSuccessStatusCode)
								{
									_0024VB_0024ResumableLocal_contentType_00246 = _0024VB_0024ResumableLocal_response_00245.Content.Headers.ContentType.MediaType;
									if (Operators.CompareString(_0024VB_0024ResumableLocal_contentType_00246, "application/json", TextCompare: false) == 0)
									{
										awaiter3 = _0024VB_0024ResumableLocal_response_00245.Content.ReadAsStringAsync().GetAwaiter();
										if (!awaiter3.IsCompleted)
										{
											num = (_0024State = 1);
											_0024A1 = awaiter3;
											ref AsyncTaskMethodBuilder<(bool, object)> reference3 = ref _0024Builder;
											VB_0024StateMachine_5_FetchCustomAPI stateMachine = this;
											reference3.AwaitUnsafeOnCompleted(ref awaiter3, ref stateMachine);
											return;
										}
										goto IL_043f;
									}
									result = (false, "Unknown response 1: ");
									break;
								}
								result = (false, "HTTP error: " + _0024VB_0024ResumableLocal_response_00245.StatusCode);
								break;
							case 1:
								{
									num = (_0024State = -1);
									awaiter3 = _0024A1;
									_0024A1 = default(TaskAwaiter<string>);
									goto IL_043f;
								}
								IL_043f:
								result2 = awaiter3.GetResult();
								awaiter3 = default(TaskAwaiter<string>);
								_0024VB_0024ResumableLocal_responseString_00247 = result2;
								_0024VB_0024ResumableLocal_result_00248 = JObject.Parse(_0024VB_0024ResumableLocal_responseString_00247);
								result = ((_0024VB_0024ResumableLocal_result_00248["Success"] == null) ? ((_0024VB_0024ResumableLocal_result_00248["Req"] == null) ? (((bool, object))((_0024VB_0024ResumableLocal_result_00248["Fail"] == null) ? (false, "Unknown response format: " + _0024VB_0024ResumableLocal_responseString_00247) : (false, "Fail: " + _0024VB_0024ResumableLocal_result_00248["Fail"].ToString()))) : (true, (object)_0024VB_0024ResumableLocal_result_00248["Req"].ToString())) : (true, _0024VB_0024ResumableLocal_result_00248["Success"].ToString()));
								break;
							}
						}
						finally
						{
							if (num < 0 && _0024VB_0024ResumableLocal_response_00245 != null)
							{
								((IDisposable)_0024VB_0024ResumableLocal_response_00245).Dispose();
							}
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						_0024VB_0024ResumableLocal_ex_00249 = ex2;
						result = (false, "Error: " + _0024VB_0024ResumableLocal_ex_00249.Message);
						ProjectData.ClearProjectError();
					}
					break;
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
	private sealed class VB_0024StateMachine_6_JoinServer : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncTaskMethodBuilder<string> _0024Builder;

		internal object _0024VB_0024Local_params;

		internal HttpClient _0024VB_0024Local_client;

		internal string _0024VB_0024Local_serverip;

		internal int _0024VB_0024Local_timeoutMilliseconds;

		internal CancellationTokenSource _0024VB_0024ResumableLocal_cts_00240;

		internal string _0024VB_0024ResumableLocal_json_00241;

		internal StringContent _0024VB_0024ResumableLocal_content_00242;

		internal object[] _0024S3;

		internal bool[] _0024S4;

		internal object _0024S5;

		internal HttpResponseMessage _0024VB_0024ResumableLocal_response_00246;

		internal string _0024VB_0024ResumableLocal_result_00247;

		internal TaskCanceledException _0024VB_0024ResumableLocal_ex_00248;

		internal Exception _0024VB_0024ResumableLocal_ex_00249;

		internal object _0024A0;

		internal TaskAwaiter<string> _0024A1;

		[CompilerGenerated]
		internal void MoveNext()
		{
			int num = _0024State;
			string result2;
			try
			{
				switch (num)
				{
				default:
					try
					{
						if (num != -3 && (uint)num > 1u)
						{
							_0024VB_0024ResumableLocal_cts_00240 = new CancellationTokenSource(_0024VB_0024Local_timeoutMilliseconds);
						}
						try
						{
							object obj4;
							object obj;
							TaskAwaiter<string> awaiter;
							switch (num)
							{
							case -3:
								num = (_0024State = -1);
								return;
							default:
							{
								_0024VB_0024ResumableLocal_json_00241 = JsonConvert.SerializeObject(RuntimeHelpers.GetObjectValue(_0024VB_0024Local_params));
								_0024VB_0024ResumableLocal_content_00242 = new StringContent(_0024VB_0024ResumableLocal_json_00241, Encoding.UTF8, "application/json");
								HttpClient instance = _0024VB_0024Local_client;
								object[] obj2 = new object[3]
								{
									BTConst.getApiUrl(BTConst.api_joinwebsocket, _0024VB_0024Local_serverip),
									_0024VB_0024ResumableLocal_content_00242,
									_0024VB_0024ResumableLocal_cts_00240.Token
								};
								object[] arguments = obj2;
								_0024S3 = obj2;
								bool[] obj3 = new bool[3] { false, true, false };
								bool[] copyBack = obj3;
								_0024S4 = obj3;
								_0024S5 = NewLateBinding.LateGet(instance, null, "PostAsync", arguments, null, null, copyBack);
								if (_0024S4[1])
								{
									_0024VB_0024ResumableLocal_content_00242 = (StringContent)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(_0024S3[1]), typeof(StringContent));
								}
								obj = NewLateBinding.LateGet(_0024S5, null, "GetAwaiter", new object[0], null, null, null);
								if (Conversions.ToBoolean(NewLateBinding.LateGet(obj, null, "IsCompleted", new object[0], null, null, null)))
								{
									goto IL_0306;
								}
								num = (_0024State = 0);
								_0024A0 = obj;
								ICriticalNotifyCompletion awaiter2 = obj as ICriticalNotifyCompletion;
								if (awaiter2 != null)
								{
									ref AsyncTaskMethodBuilder<string> reference = ref _0024Builder;
									VB_0024StateMachine_6_JoinServer stateMachine = this;
									reference.AwaitUnsafeOnCompleted(ref awaiter2, ref stateMachine);
								}
								else
								{
									INotifyCompletion awaiter3 = (INotifyCompletion)obj;
									ref AsyncTaskMethodBuilder<string> reference2 = ref _0024Builder;
									VB_0024StateMachine_6_JoinServer stateMachine = this;
									reference2.AwaitOnCompleted(ref awaiter3, ref stateMachine);
								}
								return;
							}
							case 0:
								num = (_0024State = -1);
								obj = _0024A0;
								_0024A0 = null;
								goto IL_0306;
							case 1:
								{
									num = (_0024State = -1);
									awaiter = _0024A1;
									_0024A1 = default(TaskAwaiter<string>);
									break;
								}
								IL_0306:
								obj4 = NewLateBinding.LateGet(obj, null, "GetResult", new object[0], null, null, null);
								obj = null;
								_0024VB_0024ResumableLocal_response_00246 = (HttpResponseMessage)obj4;
								if (!_0024VB_0024ResumableLocal_response_00246.IsSuccessStatusCode)
								{
									throw new Exception("Request failed");
								}
								awaiter = _0024VB_0024ResumableLocal_response_00246.Content.ReadAsStringAsync().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num = (_0024State = 1);
									_0024A1 = awaiter;
									ref AsyncTaskMethodBuilder<string> reference3 = ref _0024Builder;
									VB_0024StateMachine_6_JoinServer stateMachine = this;
									reference3.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
									return;
								}
								break;
							}
							string result = awaiter.GetResult();
							awaiter = default(TaskAwaiter<string>);
							_0024VB_0024ResumableLocal_result_00247 = result;
							result2 = _0024VB_0024ResumableLocal_result_00247;
						}
						finally
						{
							if (num < 0 && _0024VB_0024ResumableLocal_cts_00240 != null)
							{
								((IDisposable)_0024VB_0024ResumableLocal_cts_00240).Dispose();
							}
						}
					}
					catch (TaskCanceledException ex)
					{
						ProjectData.SetProjectError(ex);
						TaskCanceledException ex2 = ex;
						_0024VB_0024ResumableLocal_ex_00248 = ex2;
						result2 = "{\"Fail\":\"request timeout x89\"}";
						ProjectData.ClearProjectError();
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						_0024VB_0024ResumableLocal_ex_00249 = ex4;
						result2 = "{\"Fail\":\"unknown error x88\"}";
						ProjectData.ClearProjectError();
					}
					break;
				}
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception exception = ex5;
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
	private sealed class VB_0024StateMachine_8_CommandStore : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncTaskMethodBuilder<(bool, object)> _0024Builder;

		internal Dictionary<string, string> _0024VB_0024Local_params;

		internal HttpClient _0024VB_0024Local_client;

		internal string _0024VB_0024Local_serverip;

		internal Dictionary<string, string> _0024VB_0024ResumableLocal_encodedParams_00240;

		internal Dictionary<string, string>.KeyCollection.Enumerator _0024S1;

		internal string _0024VB_0024ResumableLocal_key_00242;

		internal string _0024VB_0024ResumableLocal_jsonString_00243;

		internal StringContent _0024VB_0024ResumableLocal_content_00244;

		internal object[] _0024S5;

		internal bool[] _0024S6;

		internal object _0024S7;

		internal HttpResponseMessage _0024VB_0024ResumableLocal_response_00248;

		internal string _0024VB_0024ResumableLocal_responseString_00249;

		internal JObject _0024VB_0024ResumableLocal_result_002410;

		internal Exception _0024VB_0024ResumableLocal_ex_002411;

		internal object _0024A0;

		internal TaskAwaiter<string> _0024A1;

		[CompilerGenerated]
		internal void MoveNext()
		{
			int num = _0024State;
			(bool, object) result;
			try
			{
				switch (num)
				{
				default:
					try
					{
						object obj4;
						object obj;
						switch (num)
						{
						case -3:
							num = (_0024State = -1);
							return;
						default:
						{
							_0024VB_0024ResumableLocal_encodedParams_00240 = new Dictionary<string, string>();
							try
							{
								_0024S1 = _0024VB_0024Local_params.Keys.GetEnumerator();
								while (_0024S1.MoveNext())
								{
									_0024VB_0024ResumableLocal_key_00242 = _0024S1.Current;
									_0024VB_0024ResumableLocal_encodedParams_00240[_0024VB_0024ResumableLocal_key_00242] = Uri.EscapeDataString(_0024VB_0024Local_params[_0024VB_0024ResumableLocal_key_00242]);
								}
							}
							finally
							{
								if (num < 0)
								{
									((IDisposable)_0024S1/*cast due to .constrained prefix*/).Dispose();
								}
							}
							_0024VB_0024ResumableLocal_jsonString_00243 = JsonConvert.SerializeObject(_0024VB_0024ResumableLocal_encodedParams_00240);
							_0024VB_0024ResumableLocal_content_00244 = new StringContent(_0024VB_0024ResumableLocal_jsonString_00243, Encoding.UTF8, "application/json");
							HttpClient instance = _0024VB_0024Local_client;
							object[] obj2 = new object[2]
							{
								BTConst.getApiUrl(BTConst.api_fetchstore, _0024VB_0024Local_serverip),
								_0024VB_0024ResumableLocal_content_00244
							};
							object[] arguments = obj2;
							_0024S5 = obj2;
							bool[] obj3 = new bool[2] { false, true };
							bool[] copyBack = obj3;
							_0024S6 = obj3;
							_0024S7 = NewLateBinding.LateGet(instance, null, "PostAsync", arguments, null, null, copyBack);
							if (_0024S6[1])
							{
								_0024VB_0024ResumableLocal_content_00244 = (StringContent)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(_0024S5[1]), typeof(StringContent));
							}
							obj = NewLateBinding.LateGet(_0024S7, null, "GetAwaiter", new object[0], null, null, null);
							if (Conversions.ToBoolean(NewLateBinding.LateGet(obj, null, "IsCompleted", new object[0], null, null, null)))
							{
								goto IL_0372;
							}
							num = (_0024State = 0);
							_0024A0 = obj;
							ICriticalNotifyCompletion awaiter = obj as ICriticalNotifyCompletion;
							if (awaiter != null)
							{
								ref AsyncTaskMethodBuilder<(bool, object)> reference = ref _0024Builder;
								VB_0024StateMachine_8_CommandStore stateMachine = this;
								reference.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
							}
							else
							{
								INotifyCompletion awaiter2 = (INotifyCompletion)obj;
								ref AsyncTaskMethodBuilder<(bool, object)> reference2 = ref _0024Builder;
								VB_0024StateMachine_8_CommandStore stateMachine = this;
								reference2.AwaitOnCompleted(ref awaiter2, ref stateMachine);
							}
							return;
						}
						case 0:
							num = (_0024State = -1);
							obj = _0024A0;
							_0024A0 = null;
							goto IL_0372;
						case -4:
						case 1:
							break;
							IL_0372:
							obj4 = NewLateBinding.LateGet(obj, null, "GetResult", new object[0], null, null, null);
							obj = null;
							_0024VB_0024ResumableLocal_response_00248 = (HttpResponseMessage)obj4;
							break;
						}
						try
						{
							string result2;
							TaskAwaiter<string> awaiter3;
							switch (num)
							{
							case -4:
								num = (_0024State = -1);
								return;
							default:
								if (_0024VB_0024ResumableLocal_response_00248.IsSuccessStatusCode)
								{
									awaiter3 = _0024VB_0024ResumableLocal_response_00248.Content.ReadAsStringAsync().GetAwaiter();
									if (!awaiter3.IsCompleted)
									{
										num = (_0024State = 1);
										_0024A1 = awaiter3;
										ref AsyncTaskMethodBuilder<(bool, object)> reference3 = ref _0024Builder;
										VB_0024StateMachine_8_CommandStore stateMachine = this;
										reference3.AwaitUnsafeOnCompleted(ref awaiter3, ref stateMachine);
										return;
									}
									goto IL_04ac;
								}
								result = (false, "HTTP error: " + _0024VB_0024ResumableLocal_response_00248.StatusCode);
								break;
							case 1:
								{
									num = (_0024State = -1);
									awaiter3 = _0024A1;
									_0024A1 = default(TaskAwaiter<string>);
									goto IL_04ac;
								}
								IL_04ac:
								result2 = awaiter3.GetResult();
								awaiter3 = default(TaskAwaiter<string>);
								_0024VB_0024ResumableLocal_responseString_00249 = result2;
								if (Operators.CompareString(_0024VB_0024ResumableLocal_response_00248.Content.Headers.ContentType.MediaType, "application/json", TextCompare: false) == 0)
								{
									_0024VB_0024ResumableLocal_result_002410 = JObject.Parse(_0024VB_0024ResumableLocal_responseString_00249);
									result = ((_0024VB_0024ResumableLocal_result_002410["Success"] == null) ? ((_0024VB_0024ResumableLocal_result_002410["Req"] == null) ? (((bool, object))((_0024VB_0024ResumableLocal_result_002410["Fail"] == null) ? (false, "Unknown response format: " + _0024VB_0024ResumableLocal_responseString_00249) : (false, "Fail: " + _0024VB_0024ResumableLocal_result_002410["Fail"].ToString()))) : (true, (object)_0024VB_0024ResumableLocal_result_002410["Req"].ToString())) : (true, _0024VB_0024ResumableLocal_result_002410["Success"].ToString()));
								}
								else
								{
									result = (false, "Unexpected reply: " + _0024VB_0024ResumableLocal_responseString_00249);
								}
								break;
							}
						}
						finally
						{
							if (num < 0 && _0024VB_0024ResumableLocal_response_00248 != null)
							{
								((IDisposable)_0024VB_0024ResumableLocal_response_00248).Dispose();
							}
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						_0024VB_0024ResumableLocal_ex_002411 = ex2;
						Console.WriteLine(_0024VB_0024ResumableLocal_ex_002411.Message);
						result = (false, "Error: " + _0024VB_0024ResumableLocal_ex_002411.Message);
						ProjectData.ClearProjectError();
					}
					break;
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(VB_0024StateMachine_0_startlogin))]
	[DebuggerStepThrough]
	public static async Task<(bool, string)> startlogin(string uemail, string upass, string pinkey, string rankey, HttpClient client, string Serverip)
	{
		try
		{
			string hardwareId = Conversions.ToString(Operators.AddObject(codes.GetHWID(), BTRegistry.GetValue("hd", "")));
			var body = new VB_0024AnonymousType_6<string, string, string, string, string, string>("BT-MOB", uemail, upass, pinkey, hardwareId, rankey);
			using (StringContent content = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json"))
			using (HttpResponseMessage response = await client.PostAsync(Conversions.ToString(BTConst.getApiUrl(BTConst.api_login, Serverip)), content))
			{
				if (!response.IsSuccessStatusCode)
					return (false, "error: " + response.StatusCode);
				JObject result = JObject.Parse(await response.Content.ReadAsStringAsync());
				if (result["Success"] != null)
					return (true, result["Success"].ToString().Trim('"'));
				if (result["Fail"] != null)
					return (false, "failed: " + result["Fail"]);
				return (false, "Unexpected error.");
			}
		}
		catch (Exception)
		{
			return (false, "Error: can't connect to server");
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(VB_0024StateMachine_1_FetchStore))]
	[DebuggerStepThrough]
	public static Task<(bool, object)> FetchStore(object @params, HttpClient client, string serverip)
	{
		return PostJson(BTConst.api_fetchstore, @params, client, serverip, allowBytes: true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(VB_0024StateMachine_2_FetchAppsAPI))]
	[DebuggerStepThrough]
	public static Task<(bool, object)> FetchAppsAPI(object @params, HttpClient client, string serverip)
	{
		return PostJson(BTConst.api_userstoreapps, @params, client, serverip, allowBytes: false);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(VB_0024StateMachine_3_FetchUpdates))]
	[DebuggerStepThrough]
	public static Task<(bool, object)> FetchUpdates(object @params, HttpClient client, string serverip)
	{
		return PostJson(BTConst.api_updates, @params, client, serverip, allowBytes: false);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(VB_0024StateMachine_4_ChangePassword))]
	[DebuggerStepThrough]
	public static Task<(bool, object)> ChangePassword(object @params, HttpClient client, string serverip)
	{
		return PostJson(BTConst.api_changepassword, @params, client, serverip, allowBytes: false);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(VB_0024StateMachine_5_FetchCustomAPI))]
	[DebuggerStepThrough]
	public static Task<(bool, object)> FetchCustomAPI(object @params, HttpClient client, string serverip)
	{
		return PostJson(BTConst.api_usercustomapps, @params, client, serverip, allowBytes: false);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(VB_0024StateMachine_6_JoinServer))]
	[DebuggerStepThrough]
	public static async Task<string> JoinServer(object @params, HttpClient client, string serverip, int timeoutMilliseconds = 10000)
	{
		try
		{
			using (CancellationTokenSource cts = new CancellationTokenSource(timeoutMilliseconds))
			using (StringContent content = new StringContent(JsonConvert.SerializeObject(@params), Encoding.UTF8, "application/json"))
			using (HttpResponseMessage response = await client.PostAsync(Conversions.ToString(BTConst.getApiUrl(BTConst.api_joinwebsocket, serverip)), content, cts.Token))
			{
				if (!response.IsSuccessStatusCode)
					throw new Exception("Request failed");
				return await response.Content.ReadAsStringAsync();
			}
		}
		catch (TaskCanceledException)
		{
			return "{\"Fail\":\"request timeout x89\"}";
		}
		catch (Exception)
		{
			return "{\"Fail\":\"unknown error x88\"}";
		}
	}

	public static string DecryptReply(string prm_key, string prm_iv, string prm_text_to_decrypt)
	{
		byte[] keyRaw = Encoding.UTF8.GetBytes(prm_key ?? "");
		byte[] key = new byte[16];
		Buffer.BlockCopy(keyRaw, 0, key, 0, Math.Min(16, keyRaw.Length));
		byte[] iv = new byte[16];
		byte[] ivRaw = Encoding.UTF8.GetBytes(prm_iv ?? "");
		Buffer.BlockCopy(ivRaw, 0, iv, 0, Math.Min(16, ivRaw.Length));
		string cipherText = (prm_text_to_decrypt ?? "").Trim().Trim('"');
		using (Aes aes = Aes.Create())
		{
			aes.Mode = CipherMode.CBC;
			aes.Padding = PaddingMode.PKCS7;
			aes.Key = key;
			aes.IV = iv;
			byte[] cipher = Convert.FromBase64String(cipherText);
			using (ICryptoTransform dec = aes.CreateDecryptor())
				return Encoding.UTF8.GetString(dec.TransformFinalBlock(cipher, 0, cipher.Length));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(VB_0024StateMachine_8_CommandStore))]
	[DebuggerStepThrough]
	public static Task<(bool, object)> CommandStore(Dictionary<string, string> @params, HttpClient client, string serverip)
	{
		Dictionary<string, string> encoded = new Dictionary<string, string>();
		foreach (string key in @params.Keys)
			encoded[key] = Uri.EscapeDataString(@params[key] ?? "");
		return PostJson(BTConst.api_fetchstore, encoded, client, serverip, allowBytes: false);
	}

	private static async Task<(bool, object)> PostJson(string api, object body, HttpClient client, string serverip, bool allowBytes)
	{
		try
		{
			using (StringContent content = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json"))
			using (HttpResponseMessage response = await client.PostAsync(Conversions.ToString(BTConst.getApiUrl(api, serverip)), content))
			{
				if (!response.IsSuccessStatusCode)
					return (false, "HTTP error: " + response.StatusCode);
				string media = response.Content.Headers.ContentType?.MediaType;
				if (Operators.CompareString(media, "application/json", TextCompare: false) == 0)
				{
					string text = await response.Content.ReadAsStringAsync();
					JObject result = JObject.Parse(text);
					if (result["Success"] != null)
						return (true, result["Success"].ToString());
					if (result["Req"] != null)
						return (true, result["Req"].ToString());
					if (result["Fail"] != null)
						return (false, "Fail: " + result["Fail"]);
					return (false, "Unknown response format: " + text);
				}
				if (allowBytes)
					return (true, await response.Content.ReadAsByteArrayAsync());
				return (false, "Unknown response 2: ");
			}
		}
		catch (Exception ex)
		{
			return (false, "Error: " + ex.Message);
		}
	}
}
