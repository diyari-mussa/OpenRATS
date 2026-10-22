using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTMOB.My.Resources;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json.Linq;

namespace BTMOB;

[DesignerGenerated]
public class BTApps : basestyle
{
	[CompilerGenerated]
	private sealed class VB_0024StateMachine_127_deleteapp : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncVoidMethodBuilder _0024Builder;

		internal BTApps _0024VB_0024Me;

		internal string _0024VB_0024ResumableLocal_apppkg_00240;

		internal ServersInfo _0024VB_0024ResumableLocal_tserver_00241;

		internal bool _0024VB_0024ResumableLocal_istore_00242;

		internal int _0024S3;

		internal string _0024VB_0024ResumableLocal_Randomkey_00244;

		internal string _0024VB_0024ResumableLocal_nxtkey_00245;

		internal VB_0024AnonymousType_1<string, string, string, string> _0024VB_0024ResumableLocal_params_00246;

		internal (bool, object) _0024VB_0024ResumableLocal_result_00247;

		internal TaskAwaiter<(bool, object)> _0024A0;

		[CompilerGenerated]
		internal void MoveNext()
		{
			int num = _0024State;
			try
			{
				TaskAwaiter<(bool, object)> awaiter;
				if (num == 0)
				{
					num = (_0024State = -1);
					awaiter = _0024A0;
					_0024A0 = default(TaskAwaiter<(bool, object)>);
					goto IL_042f;
				}
				TaskAwaiter<(bool, object)> awaiter2;
				if (num == 1)
				{
					num = (_0024State = -1);
					awaiter2 = _0024A0;
					_0024A0 = default(TaskAwaiter<(bool, object)>);
					goto IL_0513;
				}
				_0024VB_0024ResumableLocal_apppkg_00240 = null;
				_0024VB_0024ResumableLocal_tserver_00241 = null;
				_0024VB_0024ResumableLocal_istore_00242 = false;
				_0024S3 = _0024VB_0024Me.tabsapps.SelectedTab.TabIndex;
				switch (_0024S3)
				{
				case 0:
					goto IL_00ab;
				case 1:
					goto IL_01bb;
				}
				goto end_IL_000d;
				IL_0513:
				(bool, object) result = awaiter2.GetResult();
				awaiter2 = default(TaskAwaiter<(bool, object)>);
				_0024VB_0024ResumableLocal_result_00247 = result;
				goto IL_0538;
				IL_0538:
				if (_0024VB_0024ResumableLocal_result_00247.Item1)
				{
					BTAlerter.Success(Conversions.ToString(RuntimeHelpers.GetObjectValue(_0024VB_0024ResumableLocal_result_00247.Item2)));
					if (_0024VB_0024ResumableLocal_istore_00242)
					{
						_0024VB_0024Me.DGVSTORE.Rows.Remove(_0024VB_0024Me.DGVSTORE.SelectedRows[0]);
					}
					else
					{
						_0024VB_0024Me.DGVCUSTOM.Rows.Remove(_0024VB_0024Me.DGVCUSTOM.SelectedRows[0]);
					}
				}
				else
				{
					BTAlerter.erroes(Conversions.ToString(RuntimeHelpers.GetObjectValue(_0024VB_0024ResumableLocal_result_00247.Item2)));
				}
				goto end_IL_000d;
				IL_01bb:
				if (_0024VB_0024Me.DGVCUSTOM.Rows.Count <= 0)
				{
					BTAlerter.infos("No Apps found , try create new");
				}
				else
				{
					if (_0024VB_0024Me.DGVCUSTOM.SelectedRows.Count > 0)
					{
						_0024VB_0024ResumableLocal_apppkg_00240 = Conversions.ToString(RuntimeHelpers.GetObjectValue(_0024VB_0024Me.DGVCUSTOM.SelectedRows[0].Cells[2].Value));
						_0024VB_0024ResumableLocal_tserver_00241 = (ServersInfo)_0024VB_0024Me.DGVCUSTOM.SelectedRows[0].Tag;
						_0024VB_0024ResumableLocal_istore_00242 = false;
						goto IL_02d1;
					}
					BTAlerter.infos("Select app to download");
				}
				goto end_IL_000d;
				IL_042f:
				result = awaiter.GetResult();
				awaiter = default(TaskAwaiter<(bool, object)>);
				_0024VB_0024ResumableLocal_result_00247 = result;
				goto IL_0538;
				IL_00ab:
				if (_0024VB_0024Me.DGVSTORE.Rows.Count <= 0)
				{
					BTAlerter.infos("No Apps found , try create new");
				}
				else
				{
					if (_0024VB_0024Me.DGVSTORE.SelectedRows.Count > 0)
					{
						_0024VB_0024ResumableLocal_apppkg_00240 = Conversions.ToString(RuntimeHelpers.GetObjectValue(_0024VB_0024Me.DGVSTORE.SelectedRows[0].Cells[2].Value));
						_0024VB_0024ResumableLocal_tserver_00241 = (ServersInfo)_0024VB_0024Me.DGVSTORE.SelectedRows[0].Tag;
						_0024VB_0024ResumableLocal_istore_00242 = true;
						goto IL_02d1;
					}
					BTAlerter.infos("Select app to download");
				}
				goto end_IL_000d;
				IL_02d1:
				if (_0024VB_0024ResumableLocal_apppkg_00240 != null && _0024VB_0024ResumableLocal_tserver_00241 != null)
				{
					_0024VB_0024ResumableLocal_Randomkey_00244 = codes.StrGenerator(32);
					_0024VB_0024ResumableLocal_nxtkey_00245 = ServersMgr.GetServerNextKey(_0024VB_0024ResumableLocal_tserver_00241.Address);
					_0024VB_0024ResumableLocal_params_00246 = new VB_0024AnonymousType_1<string, string, string, string>("delete", _0024VB_0024ResumableLocal_Randomkey_00244, _0024VB_0024ResumableLocal_apppkg_00240, _0024VB_0024ResumableLocal_nxtkey_00245);
					if (_0024VB_0024ResumableLocal_istore_00242)
					{
						awaiter = MyServer.FetchAppsAPI(_0024VB_0024ResumableLocal_params_00246, _0024VB_0024ResumableLocal_tserver_00241.MainhttpClient, _0024VB_0024ResumableLocal_tserver_00241.Address).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_0024State = 0);
							_0024A0 = awaiter;
							ref AsyncVoidMethodBuilder reference = ref _0024Builder;
							VB_0024StateMachine_127_deleteapp stateMachine = this;
							reference.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
							return;
						}
						goto IL_042f;
					}
					awaiter2 = MyServer.FetchCustomAPI(_0024VB_0024ResumableLocal_params_00246, _0024VB_0024ResumableLocal_tserver_00241.MainhttpClient, _0024VB_0024ResumableLocal_tserver_00241.Address).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = (_0024State = 1);
						_0024A0 = awaiter2;
						ref AsyncVoidMethodBuilder reference2 = ref _0024Builder;
						VB_0024StateMachine_127_deleteapp stateMachine = this;
						reference2.AwaitUnsafeOnCompleted(ref awaiter2, ref stateMachine);
						return;
					}
					goto IL_0513;
				}
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
	private sealed class VB_0024StateMachine_128_fetchworker_DoWork : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncVoidMethodBuilder _0024Builder;

		internal object _0024VB_0024Local_sender;

		internal DoWorkEventArgs _0024VB_0024Local_e;

		internal BTApps _0024VB_0024Me;

		internal _Closure_0024__128_002D3 _0024VB_0024ResumableLocal__0024VB_0024Closure__00240;

		internal string _0024VB_0024ResumableLocal_Randomkey_00241;

		internal List<ServersInfo>.Enumerator _0024S2;

		internal _Closure_0024__128_002D2 _0024VB_0024ResumableLocal__0024VB_0024Closure__00243;

		internal _Closure_0024__128_002D4 _0024VB_0024ResumableLocal__0024VB_0024Closure__00244;

		internal string _0024VB_0024ResumableLocal_nxtkey_00245;

		internal VB_0024AnonymousType_2<string, string, string> _0024VB_0024ResumableLocal_params_00246;

		internal string _0024VB_0024ResumableLocal_response_00247;

		internal string _0024VB_0024ResumableLocal_datajson_00248;

		internal JArray _0024VB_0024ResumableLocal_jsonArray_00249;

		internal IEnumerator<JToken> _0024S10;

		internal JObject _0024VB_0024ResumableLocal_row_002411;

		internal _Closure_0024__128_002D1 _0024VB_0024ResumableLocal__0024VB_0024Closure__002412;

		internal string _0024VB_0024ResumableLocal_app_folder_002413;

		internal string _0024VB_0024ResumableLocal_app_ico_path_002414;

		internal DataGridViewRow _0024VB_0024ResumableLocal_existingRow_002415;

		internal _Closure_0024__128_002D0 _0024VB_0024ResumableLocal__0024VB_0024Closure__002416;

		internal Bitmap _0024VB_0024ResumableLocal_downloaded_002417;

		internal Exception _0024VB_0024ResumableLocal_ex_002418;

		internal Exception _0024VB_0024ResumableLocal_ex_002419;

		internal TaskAwaiter<(bool, object)> _0024A0;

		internal _Closure_0024__128_002D4 _0024U1;

		internal TaskAwaiter _0024A1;

		[CompilerGenerated]
		internal void MoveNext()
		{
			int num = _0024State;
			try
			{
				TaskAwaiter awaiter;
				switch (num)
				{
				default:
					_0024VB_0024ResumableLocal__0024VB_0024Closure__00240 = new _Closure_0024__128_002D3(_0024VB_0024ResumableLocal__0024VB_0024Closure__00240);
					_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Me = _0024VB_0024Me;
					_0024VB_0024ResumableLocal_Randomkey_00241 = codes.StrGenerator(32);
					_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_curntTabname = _0024VB_0024Me.tabsapps.TabPages[0].Text;
					_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_existingAppIds = new Dictionary<string, DataGridViewRow>();
					goto IL_0c43;
				case -3:
				case 0:
					try
					{
						switch (num)
						{
						default:
							try
							{
								TaskAwaiter<(bool, object)> awaiter2;
								if (num != -3)
								{
									if (num != 0)
									{
										_0024S2 = _0024VB_0024Me.allservers.GetEnumerator();
										goto IL_0b0b;
									}
									num = (_0024State = -1);
									awaiter2 = _0024A0;
									_0024A0 = default(TaskAwaiter<(bool, object)>);
									goto IL_02fd;
								}
								num = (_0024State = -1);
								return;
								IL_0b0b:
								if (_0024S2.MoveNext())
								{
									_0024VB_0024ResumableLocal__0024VB_0024Closure__00243 = new _Closure_0024__128_002D2(_0024VB_0024ResumableLocal__0024VB_0024Closure__00243);
									_0024VB_0024ResumableLocal__0024VB_0024Closure__00243._0024VB_0024NonLocal__0024VB_0024Closure_2 = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240;
									_0024VB_0024ResumableLocal__0024VB_0024Closure__00243._0024VB_0024Local_srv = _0024S2.Current;
									_0024VB_0024ResumableLocal__0024VB_0024Closure__00244 = new _Closure_0024__128_002D4(_0024VB_0024ResumableLocal__0024VB_0024Closure__00244);
									_0024VB_0024ResumableLocal__0024VB_0024Closure__00244._0024VB_0024NonLocal__0024VB_0024Closure_3 = _0024VB_0024ResumableLocal__0024VB_0024Closure__00243;
									_0024VB_0024ResumableLocal_nxtkey_00245 = ServersMgr.GetServerNextKey(_0024VB_0024ResumableLocal__0024VB_0024Closure__00244._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_srv.Address);
									_0024VB_0024ResumableLocal_params_00246 = new VB_0024AnonymousType_2<string, string, string>("load", _0024VB_0024ResumableLocal_Randomkey_00241, _0024VB_0024ResumableLocal_nxtkey_00245);
									_0024U1 = _0024VB_0024ResumableLocal__0024VB_0024Closure__00244;
									awaiter2 = MyServer.FetchAppsAPI(_0024VB_0024ResumableLocal_params_00246, _0024VB_0024ResumableLocal__0024VB_0024Closure__00244._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_srv.MainhttpClient, _0024VB_0024ResumableLocal__0024VB_0024Closure__00244._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_srv.Address).GetAwaiter();
									if (!awaiter2.IsCompleted)
									{
										num = (_0024State = 0);
										_0024A0 = awaiter2;
										ref AsyncVoidMethodBuilder reference = ref _0024Builder;
										VB_0024StateMachine_128_fetchworker_DoWork stateMachine = this;
										reference.AwaitUnsafeOnCompleted(ref awaiter2, ref stateMachine);
										return;
									}
									goto IL_02fd;
								}
								goto end_IL_00f2;
								IL_02fd:
								_Closure_0024__128_002D4 closure_0024__128_002D = _0024U1;
								(bool, object) result = awaiter2.GetResult();
								awaiter2 = default(TaskAwaiter<(bool, object)>);
								closure_0024__128_002D._0024VB_0024Local_result = result;
								_0024U1 = null;
								if (_0024VB_0024ResumableLocal__0024VB_0024Closure__00244._0024VB_0024Local_result.Item1)
								{
									_0024VB_0024ResumableLocal_response_00247 = Conversions.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(_0024VB_0024ResumableLocal__0024VB_0024Closure__00244._0024VB_0024Local_result.Item2, null, "Replace", new object[2] { "\\", "" }, null, null, null), null, "Trim", new object[1] { "\"" }, null, null, null)));
									_0024VB_0024ResumableLocal_datajson_00248 = null;
									try
									{
										_0024VB_0024ResumableLocal_datajson_00248 = MyServer.DecryptReply(_0024VB_0024ResumableLocal_Randomkey_00241, "BT-MOB!B6twG9+&U", _0024VB_0024ResumableLocal_response_00247);
									}
									catch (Exception projectError)
									{
										ProjectData.SetProjectError(projectError);
										_0024VB_0024ResumableLocal_datajson_00248 = null;
										ProjectData.ClearProjectError();
									}
									if (!codes.StrisEmpty(_0024VB_0024ResumableLocal_datajson_00248) && _0024VB_0024ResumableLocal_datajson_00248.StartsWith("[") && _0024VB_0024ResumableLocal_datajson_00248.EndsWith("]"))
									{
										_0024VB_0024ResumableLocal_jsonArray_00249 = JArray.Parse(_0024VB_0024ResumableLocal_datajson_00248);
										try
										{
											_0024S10 = _0024VB_0024ResumableLocal_jsonArray_00249.GetEnumerator();
											while (_0024S10.MoveNext())
											{
												_0024VB_0024ResumableLocal_row_002411 = (JObject)_0024S10.Current;
												_0024VB_0024ResumableLocal__0024VB_0024Closure__002412 = new _Closure_0024__128_002D1(_0024VB_0024ResumableLocal__0024VB_0024Closure__002412);
												_0024VB_0024ResumableLocal__0024VB_0024Closure__002412._0024VB_0024NonLocal__0024VB_0024Closure_4 = _0024VB_0024ResumableLocal__0024VB_0024Closure__00244;
												_0024VB_0024ResumableLocal__0024VB_0024Closure__002412._0024VB_0024Local_app_id = _0024VB_0024ResumableLocal_row_002411["app_id"].ToString();
												_0024VB_0024ResumableLocal__0024VB_0024Closure__002412._0024VB_0024Local_app_name = _0024VB_0024ResumableLocal_row_002411["app_name"]?.ToString() ?? "";
												_0024VB_0024ResumableLocal__0024VB_0024Closure__002412._0024VB_0024Local_app_size = _0024VB_0024ResumableLocal_row_002411["app_size"]?.ToString() ?? "";
												_0024VB_0024ResumableLocal__0024VB_0024Closure__002412._0024VB_0024Local_app_date = _0024VB_0024ResumableLocal_row_002411["app_date"]?.ToString() ?? "";
												_0024VB_0024ResumableLocal_app_folder_002413 = _0024VB_0024ResumableLocal_row_002411["app_folder"]?.ToString() ?? "";
												_0024VB_0024ResumableLocal_app_ico_path_002414 = _0024VB_0024ResumableLocal_row_002411["app_ico"]?.ToString() ?? "";
												_0024VB_0024ResumableLocal__0024VB_0024Closure__002412._0024VB_0024Local_build_state = _0024VB_0024ResumableLocal_row_002411["build_state"]?.ToString() ?? "";
												_0024VB_0024ResumableLocal__0024VB_0024Closure__002412._0024VB_0024Local_app_ver = _0024VB_0024ResumableLocal_row_002411["app_ver"]?.ToString() ?? "";
												_0024VB_0024ResumableLocal__0024VB_0024Closure__002412._0024VB_0024Local_appKey = $"{_0024VB_0024ResumableLocal__0024VB_0024Closure__002412._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_srv.Address}:{_0024VB_0024ResumableLocal__0024VB_0024Closure__002412._0024VB_0024Local_app_id}";
												if (_0024VB_0024ResumableLocal__0024VB_0024Closure__002412._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_existingAppIds.ContainsKey(_0024VB_0024ResumableLocal__0024VB_0024Closure__002412._0024VB_0024Local_appKey))
												{
													_0024VB_0024ResumableLocal_existingRow_002415 = _0024VB_0024ResumableLocal__0024VB_0024Closure__002412._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_existingAppIds[_0024VB_0024ResumableLocal__0024VB_0024Closure__002412._0024VB_0024Local_appKey];
													if (Operators.CompareString(_0024VB_0024ResumableLocal_existingRow_002415.Cells["stateclumapp"].Value.ToString(), _0024VB_0024ResumableLocal__0024VB_0024Closure__002412._0024VB_0024Local_build_state, TextCompare: false) != 0)
													{
														_0024VB_0024ResumableLocal_existingRow_002415.Cells["stateclumapp"].Value = _0024VB_0024ResumableLocal__0024VB_0024Closure__002412._0024VB_0024Local_build_state;
														_0024VB_0024Me.DGVSTORE.Refresh();
													}
													continue;
												}
												try
												{
													_0024VB_0024ResumableLocal__0024VB_0024Closure__002416 = new _Closure_0024__128_002D0(_0024VB_0024ResumableLocal__0024VB_0024Closure__002416);
													_0024VB_0024ResumableLocal__0024VB_0024Closure__002416._0024VB_0024NonLocal__0024VB_0024Closure_5 = _0024VB_0024ResumableLocal__0024VB_0024Closure__002412;
													_0024VB_0024ResumableLocal__0024VB_0024Closure__002416._0024VB_0024Local_appicon = null;
													if (MyRes.IsIconCached(_0024VB_0024ResumableLocal__0024VB_0024Closure__002416._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024Local_app_id))
													{
														_0024VB_0024ResumableLocal__0024VB_0024Closure__002416._0024VB_0024Local_appicon = (Bitmap)codes.ResizeImage(MyRes.GetCachedIcon(_0024VB_0024ResumableLocal__0024VB_0024Closure__002416._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024Local_app_id), new Size(32, 32));
													}
													else
													{
														_0024VB_0024ResumableLocal_downloaded_002417 = codes.GetImageFromUrl(_0024VB_0024ResumableLocal__0024VB_0024Closure__002416._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_srv.Address + "/yaarsa/" + _0024VB_0024ResumableLocal_app_ico_path_002414);
														if (_0024VB_0024ResumableLocal_downloaded_002417 != null)
														{
															_0024VB_0024ResumableLocal__0024VB_0024Closure__002416._0024VB_0024Local_appicon = (Bitmap)codes.ResizeImage(_0024VB_0024ResumableLocal_downloaded_002417, new Size(32, 32));
															MyRes.CacheIcon(_0024VB_0024ResumableLocal__0024VB_0024Closure__002416._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024Local_app_id, _0024VB_0024ResumableLocal__0024VB_0024Closure__002416._0024VB_0024Local_appicon);
														}
														else
														{
															_0024VB_0024ResumableLocal__0024VB_0024Closure__002416._0024VB_0024Local_appicon = (Bitmap)codes.ResizeImage(Resources.androidhead, new Size(32, 32));
														}
													}
													_0024VB_0024Me.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
													{
														int index = _0024VB_0024ResumableLocal__0024VB_0024Closure__002416._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.DGVSTORE.Rows.Add(_0024VB_0024ResumableLocal__0024VB_0024Closure__002416._0024VB_0024Local_appicon, _0024VB_0024ResumableLocal__0024VB_0024Closure__002416._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024Local_app_name, _0024VB_0024ResumableLocal__0024VB_0024Closure__002416._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024Local_app_id, _0024VB_0024ResumableLocal__0024VB_0024Closure__002416._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024Local_app_date, _0024VB_0024ResumableLocal__0024VB_0024Closure__002416._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024Local_app_size, _0024VB_0024ResumableLocal__0024VB_0024Closure__002416._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024Local_build_state, _0024VB_0024ResumableLocal__0024VB_0024Closure__002416._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024Local_app_ver, _0024VB_0024ResumableLocal__0024VB_0024Closure__002416._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_srv.Address);
														DataGridViewRow dataGridViewRow = _0024VB_0024ResumableLocal__0024VB_0024Closure__002416._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.DGVSTORE.Rows[index];
														dataGridViewRow.Tag = _0024VB_0024ResumableLocal__0024VB_0024Closure__002416._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_srv;
														_0024VB_0024ResumableLocal__0024VB_0024Closure__002416._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_existingAppIds[_0024VB_0024ResumableLocal__0024VB_0024Closure__002416._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024Local_appKey] = dataGridViewRow;
														_0024VB_0024ResumableLocal__0024VB_0024Closure__002416._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.dellall.Enabled = true;
														_0024VB_0024ResumableLocal__0024VB_0024Closure__002416._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.storestate.Text = "Store Apps: " + _0024VB_0024ResumableLocal__0024VB_0024Closure__002416._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.DGVSTORE.Rows.Count;
														_0024VB_0024ResumableLocal__0024VB_0024Closure__002416._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.tabsapps.TabPages[0].Text = $"{_0024VB_0024ResumableLocal__0024VB_0024Closure__002416._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.DGVSTORE.Rows.Count} {_0024VB_0024ResumableLocal__0024VB_0024Closure__002416._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_curntTabname}";
													}));
												}
												catch (Exception ex)
												{
													ProjectData.SetProjectError(ex);
													Exception ex2 = ex;
													_0024VB_0024ResumableLocal_ex_002418 = ex2;
													ProjectData.ClearProjectError();
												}
											}
										}
										finally
										{
											if (num < 0 && _0024S10 != null)
											{
												_0024S10.Dispose();
											}
										}
									}
									else
									{
										_0024VB_0024Me.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
										{
											_0024VB_0024ResumableLocal__0024VB_0024Closure__00244._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.storestate.Text = BTConst.smthngwrongstr;
											_0024VB_0024ResumableLocal__0024VB_0024Closure__00244._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.tabsapps.TabPages[0].Text = $"{_0024VB_0024ResumableLocal__0024VB_0024Closure__00244._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.DGVSTORE.Rows.Count} {_0024VB_0024ResumableLocal__0024VB_0024Closure__00244._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_curntTabname}";
										}));
									}
								}
								else
								{
									_0024VB_0024Me.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
									{
										BTAlerter.erroes(Conversions.ToString(_0024VB_0024ResumableLocal__0024VB_0024Closure__00244._0024VB_0024Local_result.Item2));
										_0024VB_0024ResumableLocal__0024VB_0024Closure__00244._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.tabsapps.TabPages[0].Text = $"{_0024VB_0024ResumableLocal__0024VB_0024Closure__00244._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.DGVSTORE.Rows.Count} {_0024VB_0024ResumableLocal__0024VB_0024Closure__00244._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_curntTabname}";
									}));
								}
								goto IL_0b0b;
								end_IL_00f2:;
							}
							finally
							{
								if (num < 0)
								{
									((IDisposable)_0024S2/*cast due to .constrained prefix*/).Dispose();
								}
							}
							break;
						}
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						_0024VB_0024ResumableLocal_ex_002419 = ex4;
						Debuger.Log_e("fetchworker", codes.EXtoString(_0024VB_0024ResumableLocal_ex_002419));
						ProjectData.ClearProjectError();
					}
					awaiter = Task.Delay(10000).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_0024State = 1);
						_0024A1 = awaiter;
						ref AsyncVoidMethodBuilder reference2 = ref _0024Builder;
						VB_0024StateMachine_128_fetchworker_DoWork stateMachine = this;
						reference2.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
						return;
					}
					goto IL_0c2e;
				case 1:
					{
						num = (_0024State = -1);
						awaiter = _0024A1;
						_0024A1 = default(TaskAwaiter);
						goto IL_0c2e;
					}
					IL_0c43:
					if (!_0024VB_0024Me.IamAlive)
					{
						break;
					}
					goto case -3;
					IL_0c2e:
					awaiter.GetResult();
					awaiter = default(TaskAwaiter);
					goto IL_0c43;
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
	private sealed class VB_0024StateMachine_130_FetchCustomwrkr_DoWork : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncVoidMethodBuilder _0024Builder;

		internal object _0024VB_0024Local_sender;

		internal DoWorkEventArgs _0024VB_0024Local_e;

		internal BTApps _0024VB_0024Me;

		internal _Closure_0024__130_002D3 _0024VB_0024ResumableLocal__0024VB_0024Closure__00240;

		internal string _0024VB_0024ResumableLocal_Randomkey_00241;

		internal List<ServersInfo>.Enumerator _0024S2;

		internal _Closure_0024__130_002D2 _0024VB_0024ResumableLocal__0024VB_0024Closure__00243;

		internal _Closure_0024__130_002D4 _0024VB_0024ResumableLocal__0024VB_0024Closure__00244;

		internal string _0024VB_0024ResumableLocal_nxtkey_00245;

		internal VB_0024AnonymousType_2<string, string, string> _0024VB_0024ResumableLocal_params_00246;

		internal string _0024VB_0024ResumableLocal_response_00247;

		internal string _0024VB_0024ResumableLocal_datajson_00248;

		internal JArray _0024VB_0024ResumableLocal_jsonArray_00249;

		internal IEnumerator<JToken> _0024S10;

		internal JObject _0024VB_0024ResumableLocal_row_002411;

		internal _Closure_0024__130_002D1 _0024VB_0024ResumableLocal__0024VB_0024Closure__002412;

		internal string _0024VB_0024ResumableLocal_app_ico_path_002413;

		internal DataGridViewRow _0024VB_0024ResumableLocal_existingRow_002414;

		internal _Closure_0024__130_002D0 _0024VB_0024ResumableLocal__0024VB_0024Closure__002415;

		internal string _0024VB_0024ResumableLocal_fullUrl_002416;

		internal Bitmap _0024VB_0024ResumableLocal_downloaded_002417;

		internal Exception _0024VB_0024ResumableLocal_ex_002418;

		internal Exception _0024VB_0024ResumableLocal_ex_002419;

		internal TaskAwaiter<(bool, object)> _0024A0;

		internal _Closure_0024__130_002D4 _0024U1;

		internal TaskAwaiter _0024A1;

		[CompilerGenerated]
		internal void MoveNext()
		{
			int num = _0024State;
			try
			{
				TaskAwaiter awaiter;
				switch (num)
				{
				default:
					_0024VB_0024ResumableLocal__0024VB_0024Closure__00240 = new _Closure_0024__130_002D3(_0024VB_0024ResumableLocal__0024VB_0024Closure__00240);
					_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Me = _0024VB_0024Me;
					_0024VB_0024ResumableLocal_Randomkey_00241 = codes.StrGenerator(32);
					_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_curntTabname = _0024VB_0024Me.tabsapps.TabPages[1].Text;
					_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_existingAppIds = new Dictionary<string, DataGridViewRow>();
					goto IL_0beb;
				case -3:
				case 0:
					try
					{
						switch (num)
						{
						default:
							try
							{
								TaskAwaiter<(bool, object)> awaiter2;
								if (num != -3)
								{
									if (num != 0)
									{
										_0024S2 = _0024VB_0024Me.allservers.GetEnumerator();
										goto IL_0ab3;
									}
									num = (_0024State = -1);
									awaiter2 = _0024A0;
									_0024A0 = default(TaskAwaiter<(bool, object)>);
									goto IL_02fd;
								}
								num = (_0024State = -1);
								return;
								IL_0ab3:
								if (_0024S2.MoveNext())
								{
									_0024VB_0024ResumableLocal__0024VB_0024Closure__00243 = new _Closure_0024__130_002D2(_0024VB_0024ResumableLocal__0024VB_0024Closure__00243);
									_0024VB_0024ResumableLocal__0024VB_0024Closure__00243._0024VB_0024NonLocal__0024VB_0024Closure_2 = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240;
									_0024VB_0024ResumableLocal__0024VB_0024Closure__00243._0024VB_0024Local_srv = _0024S2.Current;
									_0024VB_0024ResumableLocal__0024VB_0024Closure__00244 = new _Closure_0024__130_002D4(_0024VB_0024ResumableLocal__0024VB_0024Closure__00244);
									_0024VB_0024ResumableLocal__0024VB_0024Closure__00244._0024VB_0024NonLocal__0024VB_0024Closure_3 = _0024VB_0024ResumableLocal__0024VB_0024Closure__00243;
									_0024VB_0024ResumableLocal_nxtkey_00245 = ServersMgr.GetServerNextKey(_0024VB_0024ResumableLocal__0024VB_0024Closure__00244._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_srv.Address);
									_0024VB_0024ResumableLocal_params_00246 = new VB_0024AnonymousType_2<string, string, string>("load", _0024VB_0024ResumableLocal_Randomkey_00241, _0024VB_0024ResumableLocal_nxtkey_00245);
									_0024U1 = _0024VB_0024ResumableLocal__0024VB_0024Closure__00244;
									awaiter2 = MyServer.FetchCustomAPI(_0024VB_0024ResumableLocal_params_00246, _0024VB_0024ResumableLocal__0024VB_0024Closure__00244._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_srv.MainhttpClient, _0024VB_0024ResumableLocal__0024VB_0024Closure__00244._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_srv.Address).GetAwaiter();
									if (!awaiter2.IsCompleted)
									{
										num = (_0024State = 0);
										_0024A0 = awaiter2;
										ref AsyncVoidMethodBuilder reference = ref _0024Builder;
										VB_0024StateMachine_130_FetchCustomwrkr_DoWork stateMachine = this;
										reference.AwaitUnsafeOnCompleted(ref awaiter2, ref stateMachine);
										return;
									}
									goto IL_02fd;
								}
								goto end_IL_00f2;
								IL_02fd:
								_Closure_0024__130_002D4 closure_0024__130_002D = _0024U1;
								(bool, object) result = awaiter2.GetResult();
								awaiter2 = default(TaskAwaiter<(bool, object)>);
								closure_0024__130_002D._0024VB_0024Local_result = result;
								_0024U1 = null;
								if (_0024VB_0024ResumableLocal__0024VB_0024Closure__00244._0024VB_0024Local_result.Item1)
								{
									_0024VB_0024ResumableLocal_response_00247 = Conversions.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(_0024VB_0024ResumableLocal__0024VB_0024Closure__00244._0024VB_0024Local_result.Item2, null, "Replace", new object[2] { "\\", "" }, null, null, null), null, "Trim", new object[1] { "\"" }, null, null, null)));
									_0024VB_0024ResumableLocal_datajson_00248 = null;
									try
									{
										_0024VB_0024ResumableLocal_datajson_00248 = MyServer.DecryptReply(_0024VB_0024ResumableLocal_Randomkey_00241, "BT-MOB!B6twG9+&U", _0024VB_0024ResumableLocal_response_00247);
									}
									catch (Exception projectError)
									{
										ProjectData.SetProjectError(projectError);
										_0024VB_0024ResumableLocal_datajson_00248 = null;
										ProjectData.ClearProjectError();
									}
									if (!codes.StrisEmpty(_0024VB_0024ResumableLocal_datajson_00248) && _0024VB_0024ResumableLocal_datajson_00248.StartsWith("[") && _0024VB_0024ResumableLocal_datajson_00248.EndsWith("]"))
									{
										_0024VB_0024ResumableLocal_jsonArray_00249 = JArray.Parse(_0024VB_0024ResumableLocal_datajson_00248);
										try
										{
											_0024S10 = _0024VB_0024ResumableLocal_jsonArray_00249.GetEnumerator();
											while (_0024S10.MoveNext())
											{
												_0024VB_0024ResumableLocal_row_002411 = (JObject)_0024S10.Current;
												_0024VB_0024ResumableLocal__0024VB_0024Closure__002412 = new _Closure_0024__130_002D1(_0024VB_0024ResumableLocal__0024VB_0024Closure__002412);
												_0024VB_0024ResumableLocal__0024VB_0024Closure__002412._0024VB_0024NonLocal__0024VB_0024Closure_4 = _0024VB_0024ResumableLocal__0024VB_0024Closure__00244;
												_0024VB_0024ResumableLocal__0024VB_0024Closure__002412._0024VB_0024Local_app_id = _0024VB_0024ResumableLocal_row_002411["app_package"].ToString();
												_0024VB_0024ResumableLocal__0024VB_0024Closure__002412._0024VB_0024Local_app_name = _0024VB_0024ResumableLocal_row_002411["appname"]?.ToString() ?? "";
												_0024VB_0024ResumableLocal_app_ico_path_002413 = _0024VB_0024ResumableLocal_row_002411["app_ico"]?.ToString() ?? "";
												_0024VB_0024ResumableLocal__0024VB_0024Closure__002412._0024VB_0024Local_app_date = _0024VB_0024ResumableLocal_row_002411["build_date"]?.ToString() ?? "";
												_0024VB_0024ResumableLocal__0024VB_0024Closure__002412._0024VB_0024Local_build_state = _0024VB_0024ResumableLocal_row_002411["build_state"]?.ToString() ?? "";
												_0024VB_0024ResumableLocal__0024VB_0024Closure__002412._0024VB_0024Local_app_ver = _0024VB_0024ResumableLocal_row_002411["app_ver"]?.ToString() ?? "";
												_0024VB_0024ResumableLocal__0024VB_0024Closure__002412._0024VB_0024Local_appKey = $"{_0024VB_0024ResumableLocal__0024VB_0024Closure__002412._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_srv.Address}:{_0024VB_0024ResumableLocal__0024VB_0024Closure__002412._0024VB_0024Local_app_id}";
												if (_0024VB_0024ResumableLocal__0024VB_0024Closure__002412._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_existingAppIds.ContainsKey(_0024VB_0024ResumableLocal__0024VB_0024Closure__002412._0024VB_0024Local_appKey))
												{
													_0024VB_0024ResumableLocal_existingRow_002414 = _0024VB_0024ResumableLocal__0024VB_0024Closure__002412._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_existingAppIds[_0024VB_0024ResumableLocal__0024VB_0024Closure__002412._0024VB_0024Local_appKey];
													if (Operators.CompareString(_0024VB_0024ResumableLocal_existingRow_002414.Cells["DataGridViewTextBoxColumn5"].Value.ToString(), _0024VB_0024ResumableLocal__0024VB_0024Closure__002412._0024VB_0024Local_build_state, TextCompare: false) != 0)
													{
														_0024VB_0024ResumableLocal_existingRow_002414.Cells["DataGridViewTextBoxColumn5"].Value = _0024VB_0024ResumableLocal__0024VB_0024Closure__002412._0024VB_0024Local_build_state;
														_0024VB_0024Me.DGVCUSTOM.Refresh();
													}
													continue;
												}
												try
												{
													_0024VB_0024ResumableLocal__0024VB_0024Closure__002415 = new _Closure_0024__130_002D0(_0024VB_0024ResumableLocal__0024VB_0024Closure__002415);
													_0024VB_0024ResumableLocal__0024VB_0024Closure__002415._0024VB_0024NonLocal__0024VB_0024Closure_5 = _0024VB_0024ResumableLocal__0024VB_0024Closure__002412;
													_0024VB_0024ResumableLocal__0024VB_0024Closure__002415._0024VB_0024Local_appicon = null;
													if (MyRes.IsIconCached(_0024VB_0024ResumableLocal__0024VB_0024Closure__002415._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024Local_app_id))
													{
														_0024VB_0024ResumableLocal__0024VB_0024Closure__002415._0024VB_0024Local_appicon = (Bitmap)codes.ResizeImage(MyRes.GetCachedIcon(_0024VB_0024ResumableLocal__0024VB_0024Closure__002415._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024Local_app_id), new Size(32, 32));
													}
													else
													{
														_0024VB_0024ResumableLocal_fullUrl_002416 = Conversions.ToString(RuntimeHelpers.GetObjectValue(BTConst.getApiUrl(BTConst.rootdir_storage + _0024VB_0024ResumableLocal_app_ico_path_002413, _0024VB_0024ResumableLocal__0024VB_0024Closure__002415._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_srv.Address)));
														_0024VB_0024ResumableLocal_downloaded_002417 = codes.GetImageFromUrl(_0024VB_0024ResumableLocal_fullUrl_002416);
														if (_0024VB_0024ResumableLocal_downloaded_002417 != null)
														{
															_0024VB_0024ResumableLocal__0024VB_0024Closure__002415._0024VB_0024Local_appicon = (Bitmap)codes.ResizeImage(_0024VB_0024ResumableLocal_downloaded_002417, new Size(32, 32));
															MyRes.CacheIcon(_0024VB_0024ResumableLocal__0024VB_0024Closure__002415._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024Local_app_id, _0024VB_0024ResumableLocal__0024VB_0024Closure__002415._0024VB_0024Local_appicon);
														}
														else
														{
															_0024VB_0024ResumableLocal__0024VB_0024Closure__002415._0024VB_0024Local_appicon = (Bitmap)codes.ResizeImage(Resources.androidhead, new Size(32, 32));
														}
													}
													_0024VB_0024Me.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
													{
														int index = _0024VB_0024ResumableLocal__0024VB_0024Closure__002415._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.DGVCUSTOM.Rows.Add(_0024VB_0024ResumableLocal__0024VB_0024Closure__002415._0024VB_0024Local_appicon, _0024VB_0024ResumableLocal__0024VB_0024Closure__002415._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024Local_app_name, _0024VB_0024ResumableLocal__0024VB_0024Closure__002415._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024Local_app_id, _0024VB_0024ResumableLocal__0024VB_0024Closure__002415._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024Local_app_date, _0024VB_0024ResumableLocal__0024VB_0024Closure__002415._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024Local_build_state, _0024VB_0024ResumableLocal__0024VB_0024Closure__002415._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024Local_app_ver, _0024VB_0024ResumableLocal__0024VB_0024Closure__002415._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_srv.Address);
														DataGridViewRow dataGridViewRow = _0024VB_0024ResumableLocal__0024VB_0024Closure__002415._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.DGVCUSTOM.Rows[index];
														dataGridViewRow.Tag = _0024VB_0024ResumableLocal__0024VB_0024Closure__002415._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_srv;
														_0024VB_0024ResumableLocal__0024VB_0024Closure__002415._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_existingAppIds[_0024VB_0024ResumableLocal__0024VB_0024Closure__002415._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024Local_appKey] = dataGridViewRow;
														_0024VB_0024ResumableLocal__0024VB_0024Closure__002415._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.dellall.Enabled = true;
														_0024VB_0024ResumableLocal__0024VB_0024Closure__002415._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.customstate.Text = "Custom Apps: " + _0024VB_0024ResumableLocal__0024VB_0024Closure__002415._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.DGVCUSTOM.Rows.Count;
														_0024VB_0024ResumableLocal__0024VB_0024Closure__002415._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.tabsapps.TabPages[1].Text = $"{_0024VB_0024ResumableLocal__0024VB_0024Closure__002415._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.DGVCUSTOM.Rows.Count} {_0024VB_0024ResumableLocal__0024VB_0024Closure__002415._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_curntTabname}";
													}));
												}
												catch (Exception ex)
												{
													ProjectData.SetProjectError(ex);
													Exception ex2 = ex;
													_0024VB_0024ResumableLocal_ex_002418 = ex2;
													ProjectData.ClearProjectError();
												}
											}
										}
										finally
										{
											if (num < 0 && _0024S10 != null)
											{
												_0024S10.Dispose();
											}
										}
									}
									else
									{
										_0024VB_0024Me.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
										{
											_0024VB_0024ResumableLocal__0024VB_0024Closure__00244._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.customstate.Text = BTConst.smthngwrongstr;
											_0024VB_0024ResumableLocal__0024VB_0024Closure__00244._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.tabsapps.TabPages[1].Text = $"{_0024VB_0024ResumableLocal__0024VB_0024Closure__00244._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.DGVCUSTOM.Rows.Count} {_0024VB_0024ResumableLocal__0024VB_0024Closure__00244._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_curntTabname}";
										}));
									}
								}
								else
								{
									_0024VB_0024Me.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
									{
										BTAlerter.erroes(Conversions.ToString(_0024VB_0024ResumableLocal__0024VB_0024Closure__00244._0024VB_0024Local_result.Item2));
										_0024VB_0024ResumableLocal__0024VB_0024Closure__00244._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.tabsapps.TabPages[1].Text = $"{_0024VB_0024ResumableLocal__0024VB_0024Closure__00244._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.DGVCUSTOM.Rows.Count} {_0024VB_0024ResumableLocal__0024VB_0024Closure__00244._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_curntTabname}";
									}));
								}
								goto IL_0ab3;
								end_IL_00f2:;
							}
							finally
							{
								if (num < 0)
								{
									((IDisposable)_0024S2/*cast due to .constrained prefix*/).Dispose();
								}
							}
							break;
						}
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						_0024VB_0024ResumableLocal_ex_002419 = ex4;
						Debuger.Log_e("FetchCustomwrkr", codes.EXtoString(_0024VB_0024ResumableLocal_ex_002419));
						ProjectData.ClearProjectError();
					}
					awaiter = Task.Delay(10000).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_0024State = 1);
						_0024A1 = awaiter;
						ref AsyncVoidMethodBuilder reference2 = ref _0024Builder;
						VB_0024StateMachine_130_FetchCustomwrkr_DoWork stateMachine = this;
						reference2.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
						return;
					}
					goto IL_0bd6;
				case 1:
					{
						num = (_0024State = -1);
						awaiter = _0024A1;
						_0024A1 = default(TaskAwaiter);
						goto IL_0bd6;
					}
					IL_0beb:
					if (!_0024VB_0024Me.IamAlive)
					{
						break;
					}
					goto case -3;
					IL_0bd6:
					awaiter.GetResult();
					awaiter = default(TaskAwaiter);
					goto IL_0beb;
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
	internal sealed class _Closure_0024__128_002D0
	{
		public Bitmap _0024VB_0024Local_appicon;

		public _Closure_0024__128_002D1 _0024VB_0024NonLocal__0024VB_0024Closure_5;

		public _Closure_0024__128_002D0(_Closure_0024__128_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_appicon = arg0._0024VB_0024Local_appicon;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__0()
		{
			int index = _0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.DGVSTORE.Rows.Add(_0024VB_0024Local_appicon, _0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024Local_app_name, _0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024Local_app_id, _0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024Local_app_date, _0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024Local_app_size, _0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024Local_build_state, _0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024Local_app_ver, _0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_srv.Address);
			DataGridViewRow dataGridViewRow = _0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.DGVSTORE.Rows[index];
			dataGridViewRow.Tag = _0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_srv;
			_0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_existingAppIds[_0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024Local_appKey] = dataGridViewRow;
			_0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.dellall.Enabled = true;
			_0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.storestate.Text = "Store Apps: " + _0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.DGVSTORE.Rows.Count;
			_0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.tabsapps.TabPages[0].Text = $"{_0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.DGVSTORE.Rows.Count} {_0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_curntTabname}";
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__128_002D1
	{
		public string _0024VB_0024Local_app_name;

		public string _0024VB_0024Local_app_id;

		public string _0024VB_0024Local_app_date;

		public string _0024VB_0024Local_app_size;

		public string _0024VB_0024Local_build_state;

		public string _0024VB_0024Local_app_ver;

		public string _0024VB_0024Local_appKey;

		public _Closure_0024__128_002D4 _0024VB_0024NonLocal__0024VB_0024Closure_4;

		public _Closure_0024__128_002D1(_Closure_0024__128_002D1 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_app_name = arg0._0024VB_0024Local_app_name;
				_0024VB_0024Local_app_id = arg0._0024VB_0024Local_app_id;
				_0024VB_0024Local_app_date = arg0._0024VB_0024Local_app_date;
				_0024VB_0024Local_app_size = arg0._0024VB_0024Local_app_size;
				_0024VB_0024Local_build_state = arg0._0024VB_0024Local_build_state;
				_0024VB_0024Local_app_ver = arg0._0024VB_0024Local_app_ver;
				_0024VB_0024Local_appKey = arg0._0024VB_0024Local_appKey;
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__128_002D2
	{
		public ServersInfo _0024VB_0024Local_srv;

		public _Closure_0024__128_002D3 _0024VB_0024NonLocal__0024VB_0024Closure_2;

		public _Closure_0024__128_002D2(_Closure_0024__128_002D2 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_srv = arg0._0024VB_0024Local_srv;
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__128_002D3
	{
		public Dictionary<string, DataGridViewRow> _0024VB_0024Local_existingAppIds;

		public string _0024VB_0024Local_curntTabname;

		public BTApps _0024VB_0024Me;

		public VB_0024AnonymousDelegate_0 _0024I1;

		public _Closure_0024__128_002D3(_Closure_0024__128_002D3 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_existingAppIds = arg0._0024VB_0024Local_existingAppIds;
				_0024VB_0024Local_curntTabname = arg0._0024VB_0024Local_curntTabname;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__1()
		{
			_0024VB_0024Me.storestate.Text = BTConst.smthngwrongstr;
			_0024VB_0024Me.tabsapps.TabPages[0].Text = $"{_0024VB_0024Me.DGVSTORE.Rows.Count} {_0024VB_0024Local_curntTabname}";
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__128_002D4
	{
		public (bool, object) _0024VB_0024Local_result;

		public _Closure_0024__128_002D2 _0024VB_0024NonLocal__0024VB_0024Closure_3;

		public _Closure_0024__128_002D4(_Closure_0024__128_002D4 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_result = arg0._0024VB_0024Local_result;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__2()
		{
			BTAlerter.erroes(Conversions.ToString(_0024VB_0024Local_result.Item2));
			_0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.tabsapps.TabPages[0].Text = $"{_0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.DGVSTORE.Rows.Count} {_0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_curntTabname}";
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__130_002D0
	{
		public Bitmap _0024VB_0024Local_appicon;

		public _Closure_0024__130_002D1 _0024VB_0024NonLocal__0024VB_0024Closure_5;

		public _Closure_0024__130_002D0(_Closure_0024__130_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_appicon = arg0._0024VB_0024Local_appicon;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__0()
		{
			int index = _0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.DGVCUSTOM.Rows.Add(_0024VB_0024Local_appicon, _0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024Local_app_name, _0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024Local_app_id, _0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024Local_app_date, _0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024Local_build_state, _0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024Local_app_ver, _0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_srv.Address);
			DataGridViewRow dataGridViewRow = _0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.DGVCUSTOM.Rows[index];
			dataGridViewRow.Tag = _0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_srv;
			_0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_existingAppIds[_0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024Local_appKey] = dataGridViewRow;
			_0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.dellall.Enabled = true;
			_0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.customstate.Text = "Custom Apps: " + _0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.DGVCUSTOM.Rows.Count;
			_0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.tabsapps.TabPages[1].Text = $"{_0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.DGVCUSTOM.Rows.Count} {_0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_curntTabname}";
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__130_002D1
	{
		public string _0024VB_0024Local_app_name;

		public string _0024VB_0024Local_app_id;

		public string _0024VB_0024Local_app_date;

		public string _0024VB_0024Local_build_state;

		public string _0024VB_0024Local_app_ver;

		public string _0024VB_0024Local_appKey;

		public _Closure_0024__130_002D4 _0024VB_0024NonLocal__0024VB_0024Closure_4;

		public _Closure_0024__130_002D1(_Closure_0024__130_002D1 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_app_name = arg0._0024VB_0024Local_app_name;
				_0024VB_0024Local_app_id = arg0._0024VB_0024Local_app_id;
				_0024VB_0024Local_app_date = arg0._0024VB_0024Local_app_date;
				_0024VB_0024Local_build_state = arg0._0024VB_0024Local_build_state;
				_0024VB_0024Local_app_ver = arg0._0024VB_0024Local_app_ver;
				_0024VB_0024Local_appKey = arg0._0024VB_0024Local_appKey;
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__130_002D2
	{
		public ServersInfo _0024VB_0024Local_srv;

		public _Closure_0024__130_002D3 _0024VB_0024NonLocal__0024VB_0024Closure_2;

		public _Closure_0024__130_002D2(_Closure_0024__130_002D2 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_srv = arg0._0024VB_0024Local_srv;
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__130_002D3
	{
		public Dictionary<string, DataGridViewRow> _0024VB_0024Local_existingAppIds;

		public string _0024VB_0024Local_curntTabname;

		public BTApps _0024VB_0024Me;

		public VB_0024AnonymousDelegate_0 _0024I1;

		public _Closure_0024__130_002D3(_Closure_0024__130_002D3 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_existingAppIds = arg0._0024VB_0024Local_existingAppIds;
				_0024VB_0024Local_curntTabname = arg0._0024VB_0024Local_curntTabname;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__1()
		{
			_0024VB_0024Me.customstate.Text = BTConst.smthngwrongstr;
			_0024VB_0024Me.tabsapps.TabPages[1].Text = $"{_0024VB_0024Me.DGVCUSTOM.Rows.Count} {_0024VB_0024Local_curntTabname}";
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__130_002D4
	{
		public (bool, object) _0024VB_0024Local_result;

		public _Closure_0024__130_002D2 _0024VB_0024NonLocal__0024VB_0024Closure_3;

		public _Closure_0024__130_002D4(_Closure_0024__130_002D4 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_result = arg0._0024VB_0024Local_result;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__2()
		{
			BTAlerter.erroes(Conversions.ToString(_0024VB_0024Local_result.Item2));
			_0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.tabsapps.TabPages[1].Text = $"{_0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.DGVCUSTOM.Rows.Count} {_0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_curntTabname}";
		}
	}

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGVSTORE")]
	private DataGridView _DGVSTORE;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("FetchStoreWrkr")]
	private BackgroundWorker _FetchStoreWrkr;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("FetchCustomwrkr")]
	private BackgroundWorker _FetchCustomwrkr;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("downbtn")]
	private DrakeUIButtonIcon _downbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dellall")]
	private DrakeUIButtonIcon _dellall;

	private List<ServersInfo> allservers;

	private bool IamAlive;

	[field: AccessedThroughProperty("Panel6")]
	internal virtual Panel Panel6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public virtual DataGridView DGVSTORE
	{
		[CompilerGenerated]
		get
		{
			return _DGVSTORE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DataGridViewCellPaintingEventHandler value2 = DataGridView2_CellPainting;
			DataGridView dataGridView = _DGVSTORE;
			if (dataGridView != null)
			{
				dataGridView.CellPainting -= value2;
			}
			_DGVSTORE = value;
			dataGridView = _DGVSTORE;
			if (dataGridView != null)
			{
				dataGridView.CellPainting += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel26")]
	internal virtual Panel Panel26
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("storestate")]
	internal virtual Label storestate
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual BackgroundWorker FetchStoreWrkr
	{
		[CompilerGenerated]
		get
		{
			return _FetchStoreWrkr;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DoWorkEventHandler value2 = fetchworker_DoWork;
			BackgroundWorker backgroundWorker = _FetchStoreWrkr;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= value2;
			}
			_FetchStoreWrkr = value;
			backgroundWorker = _FetchStoreWrkr;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork += value2;
			}
		}
	}

	[field: AccessedThroughProperty("tabsapps")]
	internal virtual DrakeUITabControl tabsapps
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage1")]
	internal virtual TabPage TabPage1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage2")]
	internal virtual TabPage TabPage2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual BackgroundWorker FetchCustomwrkr
	{
		[CompilerGenerated]
		get
		{
			return _FetchCustomwrkr;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DoWorkEventHandler value2 = FetchCustomwrkr_DoWork;
			BackgroundWorker backgroundWorker = _FetchCustomwrkr;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= value2;
			}
			_FetchCustomwrkr = value;
			backgroundWorker = _FetchCustomwrkr;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DGVCUSTOM")]
	public virtual DataGridView DGVCUSTOM
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

	[field: AccessedThroughProperty("customstate")]
	internal virtual Label customstate
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
			EventHandler value2 = refpasses_Click;
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

	[field: AccessedThroughProperty("appico")]
	internal virtual DataGridViewImageColumn appico
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("numnamclm")]
	internal virtual DataGridViewTextBoxColumn numnamclm
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("numculm")]
	internal virtual DataGridViewTextBoxColumn numculm
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("acctclum")]
	internal virtual DataGridViewTextBoxColumn acctclum
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("appsizclum")]
	internal virtual DataGridViewTextBoxColumn appsizclum
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("stateclumapp")]
	internal virtual DataGridViewTextBoxColumn stateclumapp
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("avrclomn")]
	internal virtual DataGridViewTextBoxColumn avrclomn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("srvrnam")]
	internal virtual DataGridViewTextBoxColumn srvrnam
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewImageColumn1")]
	internal virtual DataGridViewImageColumn DataGridViewImageColumn1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn1")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn2")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn3")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn5")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("apvrclum")]
	internal virtual DataGridViewTextBoxColumn apvrclum
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("srvernam")]
	internal virtual DataGridViewTextBoxColumn srvernam
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
	private void translateme()
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BTApps(List<ServersInfo> allser)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DataGridView2_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BTApps_Load(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void refpasses_Click(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void dellall_Click(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(VB_0024StateMachine_127_deleteapp))]
	[DebuggerStepThrough]
	private void deleteapp()
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(VB_0024StateMachine_128_fetchworker_DoWork))]
	[DebuggerStepThrough]
	private void fetchworker_DoWork(object sender, DoWorkEventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BTApps_FormClosing(object sender, FormClosingEventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(VB_0024StateMachine_130_FetchCustomwrkr_DoWork))]
	[DebuggerStepThrough]
	private void FetchCustomwrkr_DoWork(object sender, DoWorkEventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}
}
