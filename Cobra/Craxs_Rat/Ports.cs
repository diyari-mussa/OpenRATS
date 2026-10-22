using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Craxs_Rat.My;
using Craxs_Rat.My.Resources;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat;

[DesignerGenerated]
public class Ports : Form
{
	public delegate void addLogback(object[] objs);

	public delegate void opebbtndele(object[] objs);

	[CompilerGenerated]
	private sealed class VB_0024StateMachine_174_FadeIn : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncVoidMethodBuilder _0024Builder;

		internal Form _0024VB_0024Local_o;

		internal int _0024VB_0024Local_interval;

		internal Ports _0024VB_0024Me;

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
				if (_0024VB_0024Local_o.Opacity < 1.0)
				{
					awaiter = Task.Delay(_0024VB_0024Local_interval).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_0024State = 0;
						_0024A0 = awaiter;
						ref AsyncVoidMethodBuilder reference = ref _0024Builder;
						VB_0024StateMachine_174_FadeIn stateMachine = this;
						reference.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
						return;
					}
					goto IL_0042;
				}
				_0024VB_0024Local_o.Opacity = 1.0;
				_0024VB_0024Me.Timer1.Start();
				_0024VB_0024Me.loginbtn.Select();
				_0024VB_0024Me.loginbtn.Enabled = true;
				_0024VB_0024Me.regbtn.Select();
				_0024VB_0024Me.regbtn.Enabled = true;
				_0024VB_0024Me.CHIDbtn.Select();
				_0024VB_0024Me.CHIDbtn.Enabled = true;
				goto end_IL_0007;
				IL_0042:
				awaiter.GetResult();
				awaiter = default(TaskAwaiter);
				(_0024S0 = _0024VB_0024Local_o).Opacity = _0024S0.Opacity + 0.05;
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

	private IContainer components;

	[AccessedThroughProperty("pnl1")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Panel _pnl1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("policylink")]
	private DrakeUILinkLabel _policylink;

	[AccessedThroughProperty("Timer1")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Timer _Timer1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("statuslabel")]
	private Label _statuslabel;

	[CompilerGenerated]
	[AccessedThroughProperty("qutelabel")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Label _qutelabel;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("welclabel")]
	private Label _welclabel;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("exitbtn")]
	private DrakeUIButtonIcon _exitbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUILinkLabel1")]
	private DrakeUILinkLabel _DrakeUILinkLabel1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PictureBox1")]
	[CompilerGenerated]
	private PictureBox _PictureBox1;

	[CompilerGenerated]
	[AccessedThroughProperty("loginworker")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private BackgroundWorker _loginworker;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("regworker")]
	private BackgroundWorker _regworker;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("loginbtn")]
	private DrakeUIButtonIcon _loginbtn;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("regbtn")]
	private DrakeUIButtonIcon _regbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CHIDbtn")]
	private DrakeUIButtonIcon _CHIDbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("changeIDWorker")]
	private BackgroundWorker _changeIDWorker;

	private Random r;

	public string Ping_Json;

	public string Check_Json;

	public string Checkv2_Json;

	public string Session;

	public string IDC_Json;

	public string Secritkey;

	private string holder;

	private int index;

	public bool Finish;

	public bool S;

	internal virtual Panel pnl1
	{
		[CompilerGenerated]
		get
		{
			return _pnl1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			PaintEventHandler value2 = pnl1_Paint;
			MouseEventHandler value3 = Pnl1_MouseDown;
			Panel panel = _pnl1;
			if (panel != null)
			{
				panel.Paint -= value2;
				panel.MouseDown -= value3;
			}
			_pnl1 = value;
			panel = _pnl1;
			if (panel != null)
			{
				panel.Paint += value2;
				panel.MouseDown += value3;
			}
		}
	}

	[field: AccessedThroughProperty("notpass")]
	internal virtual NotifyIcon notpass
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual PictureBox PictureBox2
	{
		[CompilerGenerated]
		get
		{
			return _PictureBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = PictureBox2_MouseDown;
			PictureBox pictureBox = _PictureBox2;
			if (pictureBox != null)
			{
				pictureBox.MouseDown -= value2;
			}
			_PictureBox2 = value;
			pictureBox = _PictureBox2;
			if (pictureBox != null)
			{
				pictureBox.MouseDown += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeUIToolTip1")]
	internal virtual DrakeUIToolTip DrakeUIToolTip1
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

	internal virtual DrakeUILinkLabel policylink
	{
		[CompilerGenerated]
		get
		{
			return _policylink;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUILinkLabel1_Click;
			DrakeUILinkLabel drakeUILinkLabel = _policylink;
			if (drakeUILinkLabel != null)
			{
				drakeUILinkLabel.Click -= value2;
			}
			_policylink = value;
			drakeUILinkLabel = _policylink;
			if (drakeUILinkLabel != null)
			{
				drakeUILinkLabel.Click += value2;
			}
		}
	}

	internal virtual Timer Timer1
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
			Timer timer = _Timer1;
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

	internal virtual Label statuslabel
	{
		[CompilerGenerated]
		get
		{
			return _statuslabel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Statuslabel_Click;
			Label label = _statuslabel;
			if (label != null)
			{
				label.Click -= value2;
			}
			_statuslabel = value;
			label = _statuslabel;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	internal virtual Label qutelabel
	{
		[CompilerGenerated]
		get
		{
			return _qutelabel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Label1_MouseDown;
			Label label = _qutelabel;
			if (label != null)
			{
				label.MouseDown -= value2;
			}
			_qutelabel = value;
			label = _qutelabel;
			if (label != null)
			{
				label.MouseDown += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label13")]
	internal virtual Label Label13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label welclabel
	{
		[CompilerGenerated]
		get
		{
			return _welclabel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = welclabel_Click;
			Label label = _welclabel;
			if (label != null)
			{
				label.Click -= value2;
			}
			_welclabel = value;
			label = _welclabel;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("pnl0")]
	internal virtual Panel pnl0
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
			EventHandler value2 = DrakeUIButtonIcon1_Click_1;
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

	internal virtual DrakeUILinkLabel DrakeUILinkLabel1
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUILinkLabel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUILinkLabel1_Click_2;
			DrakeUILinkLabel drakeUILinkLabel = _DrakeUILinkLabel1;
			if (drakeUILinkLabel != null)
			{
				drakeUILinkLabel.Click -= value2;
			}
			_DrakeUILinkLabel1 = value;
			drakeUILinkLabel = _DrakeUILinkLabel1;
			if (drakeUILinkLabel != null)
			{
				drakeUILinkLabel.Click += value2;
			}
		}
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
			MouseEventHandler value2 = PictureBox1_MouseDown_1;
			EventHandler value3 = PictureBox1_Click;
			PictureBox pictureBox = _PictureBox1;
			if (pictureBox != null)
			{
				pictureBox.MouseDown -= value2;
				pictureBox.Click -= value3;
			}
			_PictureBox1 = value;
			pictureBox = _PictureBox1;
			if (pictureBox != null)
			{
				pictureBox.MouseDown += value2;
				pictureBox.Click += value3;
			}
		}
	}

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual BackgroundWorker loginworker
	{
		[CompilerGenerated]
		get
		{
			return _loginworker;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			RunWorkerCompletedEventHandler value2 = loginworker_RunWorkerCompleted;
			DoWorkEventHandler value3 = Loginworker_DoWork;
			BackgroundWorker backgroundWorker = _loginworker;
			if (backgroundWorker != null)
			{
				backgroundWorker.RunWorkerCompleted -= value2;
				backgroundWorker.DoWork -= value3;
			}
			_loginworker = value;
			backgroundWorker = _loginworker;
			if (backgroundWorker != null)
			{
				backgroundWorker.RunWorkerCompleted += value2;
				backgroundWorker.DoWork += value3;
			}
		}
	}

	internal virtual BackgroundWorker regworker
	{
		[CompilerGenerated]
		get
		{
			return _regworker;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			RunWorkerCompletedEventHandler value2 = regworker_RunWorkerCompleted;
			DoWorkEventHandler value3 = Regworker_DoWork;
			BackgroundWorker backgroundWorker = _regworker;
			if (backgroundWorker != null)
			{
				backgroundWorker.RunWorkerCompleted -= value2;
				backgroundWorker.DoWork -= value3;
			}
			_regworker = value;
			backgroundWorker = _regworker;
			if (backgroundWorker != null)
			{
				backgroundWorker.RunWorkerCompleted += value2;
				backgroundWorker.DoWork += value3;
			}
		}
	}

	[field: AccessedThroughProperty("DrakeUITabControl1")]
	internal virtual DrakeUITabControl DrakeUITabControl1
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

	[field: AccessedThroughProperty("TabPage1")]
	internal virtual TabPage TabPage1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("loadingimage")]
	internal virtual DrakeUILoadingBar loadingimage
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("savekey")]
	internal virtual DrakeUICheckBox savekey
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon loginbtn
	{
		[CompilerGenerated]
		get
		{
			return _loginbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = b_ok_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _loginbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_loginbtn = value;
			drakeUIButtonIcon = _loginbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("usrkeytext")]
	internal virtual DrakeUITextBox usrkeytext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("usremailtext")]
	internal virtual DrakeUITextBox usremailtext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("loginlabel")]
	internal virtual Label loginlabel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeUILoadingBar1")]
	internal virtual DrakeUILoadingBar DrakeUILoadingBar1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon regbtn
	{
		[CompilerGenerated]
		get
		{
			return _regbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = b_reg_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _regbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_regbtn = value;
			drakeUIButtonIcon = _regbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("usrkeyreg")]
	internal virtual DrakeUITextBox usrkeyreg
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("usremailtextreg")]
	internal virtual DrakeUITextBox usremailtextreg
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

	[field: AccessedThroughProperty("keyText")]
	internal virtual DrakeUITextBox keyText
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

	internal virtual DrakeUIButtonIcon CHIDbtn
	{
		[CompilerGenerated]
		get
		{
			return _CHIDbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CHIDbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _CHIDbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_CHIDbtn = value;
			drakeUIButtonIcon = _CHIDbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("CHIDpassword")]
	internal virtual DrakeUITextBox CHIDpassword
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CHIDaccount")]
	internal virtual DrakeUITextBox CHIDaccount
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

	[field: AccessedThroughProperty("loadingimageR")]
	internal virtual DrakeUILoadingBar loadingimageR
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CHIDimg")]
	internal virtual DrakeUILoadingBar CHIDimg
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual BackgroundWorker changeIDWorker
	{
		[CompilerGenerated]
		get
		{
			return _changeIDWorker;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			RunWorkerCompletedEventHandler value2 = changeIDWorker_RunWorkerCompleted;
			DoWorkEventHandler value3 = changeIDWorker_DoWork;
			BackgroundWorker backgroundWorker = _changeIDWorker;
			if (backgroundWorker != null)
			{
				backgroundWorker.RunWorkerCompleted -= value2;
				backgroundWorker.DoWork -= value3;
			}
			_changeIDWorker = value;
			backgroundWorker = _changeIDWorker;
			if (backgroundWorker != null)
			{
				backgroundWorker.RunWorkerCompleted += value2;
				backgroundWorker.DoWork += value3;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Craxs_Rat.Ports));
		this.pnl1 = new System.Windows.Forms.Panel();
		this.exitbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		this.Panel1 = new System.Windows.Forms.Panel();
		this.DrakeUITabControl1 = new DrakeUI.Framework.DrakeUITabControl();
		this.TabPage2 = new System.Windows.Forms.TabPage();
		this.loadingimage = new DrakeUI.Framework.DrakeUILoadingBar();
		this.savekey = new DrakeUI.Framework.DrakeUICheckBox();
		this.loginbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.usrkeytext = new DrakeUI.Framework.DrakeUITextBox();
		this.usremailtext = new DrakeUI.Framework.DrakeUITextBox();
		this.loginlabel = new System.Windows.Forms.Label();
		this.TabPage1 = new System.Windows.Forms.TabPage();
		this.loadingimageR = new DrakeUI.Framework.DrakeUILoadingBar();
		this.keyText = new DrakeUI.Framework.DrakeUITextBox();
		this.DrakeUILoadingBar1 = new DrakeUI.Framework.DrakeUILoadingBar();
		this.regbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.usrkeyreg = new DrakeUI.Framework.DrakeUITextBox();
		this.usremailtextreg = new DrakeUI.Framework.DrakeUITextBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.TabPage3 = new System.Windows.Forms.TabPage();
		this.CHIDimg = new DrakeUI.Framework.DrakeUILoadingBar();
		this.CHIDbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.CHIDpassword = new DrakeUI.Framework.DrakeUITextBox();
		this.CHIDaccount = new DrakeUI.Framework.DrakeUITextBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.qutelabel = new System.Windows.Forms.Label();
		this.welclabel = new System.Windows.Forms.Label();
		this.PictureBox2 = new System.Windows.Forms.PictureBox();
		this.DrakeUILinkLabel1 = new DrakeUI.Framework.DrakeUILinkLabel();
		this.policylink = new DrakeUI.Framework.DrakeUILinkLabel();
		this.Label13 = new System.Windows.Forms.Label();
		this.statuslabel = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.notpass = new System.Windows.Forms.NotifyIcon(this.components);
		this.DrakeUIToolTip1 = new DrakeUI.Framework.DrakeUIToolTip(this.components);
		this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
		this.Timer1 = new System.Windows.Forms.Timer(this.components);
		this.pnl0 = new System.Windows.Forms.Panel();
		this.loginworker = new System.ComponentModel.BackgroundWorker();
		this.regworker = new System.ComponentModel.BackgroundWorker();
		this.changeIDWorker = new System.ComponentModel.BackgroundWorker();
		this.pnl1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		this.Panel1.SuspendLayout();
		this.DrakeUITabControl1.SuspendLayout();
		this.TabPage2.SuspendLayout();
		this.TabPage1.SuspendLayout();
		this.TabPage3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox2).BeginInit();
		this.pnl0.SuspendLayout();
		base.SuspendLayout();
		this.pnl1.BackColor = System.Drawing.Color.Black;
		this.pnl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.pnl1.Controls.Add(this.exitbtn);
		this.pnl1.Controls.Add(this.PictureBox1);
		this.pnl1.Controls.Add(this.Panel1);
		this.pnl1.Controls.Add(this.Label13);
		this.pnl1.Controls.Add(this.statuslabel);
		this.pnl1.Controls.Add(this.Label3);
		this.pnl1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.pnl1.ForeColor = System.Drawing.Color.SkyBlue;
		this.pnl1.Location = new System.Drawing.Point(0, 0);
		this.pnl1.Name = "pnl1";
		this.pnl1.Size = new System.Drawing.Size(991, 484);
		this.pnl1.TabIndex = 5;
		this.exitbtn.BackColor = System.Drawing.Color.Black;
		this.exitbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.exitbtn.FillColor = System.Drawing.Color.Transparent;
		this.exitbtn.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.exitbtn.FillPressColor = System.Drawing.Color.Black;
		this.exitbtn.FillSelectedColor = System.Drawing.Color.FromArgb(254, 0, 0);
		this.exitbtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.exitbtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.exitbtn.ForePressColor = System.Drawing.Color.FromArgb(254, 0, 0);
		this.exitbtn.Location = new System.Drawing.Point(952, 10);
		this.exitbtn.Name = "exitbtn";
		this.exitbtn.Radius = 10;
		this.exitbtn.RectColor = System.Drawing.Color.SkyBlue;
		this.exitbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.exitbtn.RectHoverColor = System.Drawing.Color.SkyBlue;
		this.exitbtn.RectPressColor = System.Drawing.Color.SkyBlue;
		this.exitbtn.RectSelectedColor = System.Drawing.Color.SkyBlue;
		this.exitbtn.Size = new System.Drawing.Size(28, 24);
		this.exitbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.exitbtn.Symbol = 61453;
		this.exitbtn.SymbolSize = 25;
		this.exitbtn.TabIndex = 48;
		this.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.PictureBox1.Image = (System.Drawing.Image)resources.GetObject("PictureBox1.Image");
		this.PictureBox1.Location = new System.Drawing.Point(320, 0);
		this.PictureBox1.Margin = new System.Windows.Forms.Padding(2);
		this.PictureBox1.Name = "PictureBox1";
		this.PictureBox1.Size = new System.Drawing.Size(671, 476);
		this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.PictureBox1.TabIndex = 51;
		this.PictureBox1.TabStop = false;
		this.Panel1.BackColor = System.Drawing.Color.Black;
		this.Panel1.Controls.Add(this.DrakeUITabControl1);
		this.Panel1.Controls.Add(this.qutelabel);
		this.Panel1.Controls.Add(this.welclabel);
		this.Panel1.Controls.Add(this.PictureBox2);
		this.Panel1.Controls.Add(this.DrakeUILinkLabel1);
		this.Panel1.Controls.Add(this.policylink);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel1.Location = new System.Drawing.Point(0, 0);
		this.Panel1.Margin = new System.Windows.Forms.Padding(2);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(320, 476);
		this.Panel1.TabIndex = 50;
		this.DrakeUITabControl1.Controls.Add(this.TabPage2);
		this.DrakeUITabControl1.Controls.Add(this.TabPage1);
		this.DrakeUITabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
		this.DrakeUITabControl1.FillColor = System.Drawing.Color.SkyBlue;
		this.DrakeUITabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f);
		this.DrakeUITabControl1.ItemSize = new System.Drawing.Size(98, 40);
		this.DrakeUITabControl1.Location = new System.Drawing.Point(6, 122);
		this.DrakeUITabControl1.MenuStyle = DrakeUI.Framework.UIMenuStyle.Custom;
		this.DrakeUITabControl1.Name = "DrakeUITabControl1";
		this.DrakeUITabControl1.SelectedIndex = 0;
		this.DrakeUITabControl1.Size = new System.Drawing.Size(309, 243);
		this.DrakeUITabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
		this.DrakeUITabControl1.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUITabControl1.TabBackColor = System.Drawing.Color.Black;
		this.DrakeUITabControl1.TabIndex = 53;
		this.DrakeUITabControl1.TabSelectedColor = System.Drawing.Color.Black;
		this.DrakeUITabControl1.TabSelectedForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUITabControl1.TabSelectedHighColor = System.Drawing.Color.SkyBlue;
		this.DrakeUITabControl1.TabUnSelectedForeColor = System.Drawing.Color.SkyBlue;
		this.TabPage2.BackColor = System.Drawing.Color.Black;
		this.TabPage2.Controls.Add(this.loadingimage);
		this.TabPage2.Controls.Add(this.loginbtn);
		this.TabPage2.Controls.Add(this.usrkeytext);
		this.TabPage2.Controls.Add(this.usremailtext);
		this.TabPage2.Controls.Add(this.loginlabel);
		this.TabPage2.Location = new System.Drawing.Point(0, 40);
		this.TabPage2.Name = "TabPage2";
		this.TabPage2.Size = new System.Drawing.Size(309, 203);
		this.TabPage2.TabIndex = 1;
		this.TabPage2.Text = "Login";
		this.loadingimage.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.loadingimage.BackColor = System.Drawing.Color.Black;
		this.loadingimage.Font = new System.Drawing.Font("Calibri", 12f);
		this.loadingimage.ForeColor = System.Drawing.Color.SkyBlue;
		this.loadingimage.Location = new System.Drawing.Point(221, 167);
		this.loadingimage.Name = "loadingimage";
		this.loadingimage.Size = new System.Drawing.Size(23, 24);
		this.loadingimage.Style = DrakeUI.Framework.UIStyle.Custom;
		this.loadingimage.StyleCustomMode = true;
		this.loadingimage.TabIndex = 62;
		this.loadingimage.Text = "DrakeUILoadingBar1";
		this.loadingimage.Visible = false;
		this.savekey.BackColor = System.Drawing.Color.Black;
		this.savekey.CheckBoxColor = System.Drawing.Color.SkyBlue;
		this.savekey.Checked = true;
		this.savekey.Cursor = System.Windows.Forms.Cursors.Hand;
		this.savekey.Font = new System.Drawing.Font("Calibri", 12f);
		this.savekey.ForeColor = System.Drawing.Color.SkyBlue;
		this.savekey.Location = new System.Drawing.Point(4, 129);
		this.savekey.Name = "savekey";
		this.savekey.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.savekey.Size = new System.Drawing.Size(303, 22);
		this.savekey.Style = DrakeUI.Framework.UIStyle.Custom;
		this.savekey.TabIndex = 61;
		this.savekey.Text = "Remember me";
		this.loginbtn.BackColor = System.Drawing.Color.Black;
		this.loginbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.loginbtn.Enabled = false;
		this.loginbtn.FillColor = System.Drawing.Color.Transparent;
		this.loginbtn.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.loginbtn.FillPressColor = System.Drawing.Color.Black;
		this.loginbtn.FillSelectedColor = System.Drawing.Color.FromArgb(254, 0, 0);
		this.loginbtn.Font = new System.Drawing.Font("Calibri", 10.5f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.loginbtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.loginbtn.ForePressColor = System.Drawing.Color.SkyBlue;
		this.loginbtn.Location = new System.Drawing.Point(98, 167);
		this.loginbtn.Name = "loginbtn";
		this.loginbtn.Radius = 10;
		this.loginbtn.RectColor = System.Drawing.Color.SkyBlue;
		this.loginbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.loginbtn.RectHoverColor = System.Drawing.Color.SkyBlue;
		this.loginbtn.RectPressColor = System.Drawing.Color.SkyBlue;
		this.loginbtn.RectSelectedColor = System.Drawing.Color.SkyBlue;
		this.loginbtn.Size = new System.Drawing.Size(117, 24);
		this.loginbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.loginbtn.SymbolSize = 0;
		this.loginbtn.TabIndex = 60;
		this.loginbtn.Text = "...";
		this.usrkeytext.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.usrkeytext.FillColor = System.Drawing.Color.Black;
		this.usrkeytext.Font = new System.Drawing.Font("Calibri", 12f);
		this.usrkeytext.ForeColor = System.Drawing.Color.SkyBlue;
		this.usrkeytext.Location = new System.Drawing.Point(4, 95);
		this.usrkeytext.Margin = new System.Windows.Forms.Padding(4);
		this.usrkeytext.Maximum = 2147483647.0;
		this.usrkeytext.Minimum = -2147483648.0;
		this.usrkeytext.Name = "usrkeytext";
		this.usrkeytext.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.usrkeytext.PasswordChar = '•';
		this.usrkeytext.Radius = 10;
		this.usrkeytext.RectColor = System.Drawing.Color.SkyBlue;
		this.usrkeytext.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.usrkeytext.Size = new System.Drawing.Size(303, 27);
		this.usrkeytext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.usrkeytext.TabIndex = 59;
		this.usrkeytext.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.usrkeytext.Watermark = "";
		this.usremailtext.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.usremailtext.FillColor = System.Drawing.Color.Black;
		this.usremailtext.Font = new System.Drawing.Font("Calibri", 12f);
		this.usremailtext.ForeColor = System.Drawing.Color.SkyBlue;
		this.usremailtext.Location = new System.Drawing.Point(4, 60);
		this.usremailtext.Margin = new System.Windows.Forms.Padding(4);
		this.usremailtext.Maximum = 2147483647.0;
		this.usremailtext.Minimum = -2147483648.0;
		this.usremailtext.Name = "usremailtext";
		this.usremailtext.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.usremailtext.Radius = 10;
		this.usremailtext.RectColor = System.Drawing.Color.SkyBlue;
		this.usremailtext.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.usremailtext.Size = new System.Drawing.Size(303, 27);
		this.usremailtext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.usremailtext.StyleCustomMode = true;
		this.usremailtext.TabIndex = 58;
		this.usremailtext.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.usremailtext.Watermark = "";
		this.loginlabel.BackColor = System.Drawing.Color.Black;
		this.loginlabel.Dock = System.Windows.Forms.DockStyle.Top;
		this.loginlabel.Font = new System.Drawing.Font("Calibri", 14f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.loginlabel.ForeColor = System.Drawing.Color.SkyBlue;
		this.loginlabel.Location = new System.Drawing.Point(0, 0);
		this.loginlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
		this.loginlabel.Name = "loginlabel";
		this.loginlabel.Size = new System.Drawing.Size(309, 56);
		this.loginlabel.TabIndex = 57;
		this.loginlabel.Text = "Please Enter Email or Password";
		this.loginlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.TabPage1.BackColor = System.Drawing.Color.Black;
		this.TabPage1.Controls.Add(this.loadingimageR);
		this.TabPage1.Controls.Add(this.DrakeUILoadingBar1);
		this.TabPage1.Controls.Add(this.Label1);
		this.TabPage1.Location = new System.Drawing.Point(0, 40);
		this.TabPage1.Name = "TabPage1";
		this.TabPage1.Size = new System.Drawing.Size(309, 203);
		this.TabPage1.TabIndex = 2;
		this.TabPage1.Text = "Register";
		this.loadingimageR.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.loadingimageR.BackColor = System.Drawing.Color.Black;
		this.loadingimageR.Font = new System.Drawing.Font("Calibri", 12f);
		this.loadingimageR.ForeColor = System.Drawing.Color.SkyBlue;
		this.loadingimageR.Location = new System.Drawing.Point(362, 167);
		this.loadingimageR.Name = "loadingimageR";
		this.loadingimageR.Size = new System.Drawing.Size(23, 24);
		this.loadingimageR.Style = DrakeUI.Framework.UIStyle.Custom;
		this.loadingimageR.StyleCustomMode = true;
		this.loadingimageR.TabIndex = 70;
		this.loadingimageR.Text = "DrakeUILoadingBar1";
		this.loadingimageR.Visible = false;
		this.keyText.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.keyText.FillColor = System.Drawing.Color.Black;
		this.keyText.Font = new System.Drawing.Font("Calibri", 12f);
		this.keyText.ForeColor = System.Drawing.Color.SkyBlue;
		this.keyText.Location = new System.Drawing.Point(4, 130);
		this.keyText.Margin = new System.Windows.Forms.Padding(4);
		this.keyText.Maximum = 2147483647.0;
		this.keyText.Minimum = -2147483648.0;
		this.keyText.Name = "keyText";
		this.keyText.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.keyText.Radius = 10;
		this.keyText.RectColor = System.Drawing.Color.SkyBlue;
		this.keyText.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.keyText.Size = new System.Drawing.Size(303, 27);
		this.keyText.Style = DrakeUI.Framework.UIStyle.Custom;
		this.keyText.StyleCustomMode = true;
		this.keyText.TabIndex = 68;
		this.keyText.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.keyText.Watermark = "Key";
		this.DrakeUILoadingBar1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.DrakeUILoadingBar1.BackColor = System.Drawing.Color.Black;
		this.DrakeUILoadingBar1.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUILoadingBar1.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUILoadingBar1.Location = new System.Drawing.Point(1066, 157);
		this.DrakeUILoadingBar1.Name = "DrakeUILoadingBar1";
		this.DrakeUILoadingBar1.Size = new System.Drawing.Size(23, 24);
		this.DrakeUILoadingBar1.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUILoadingBar1.StyleCustomMode = true;
		this.DrakeUILoadingBar1.TabIndex = 67;
		this.DrakeUILoadingBar1.Text = "DrakeUILoadingBar1";
		this.DrakeUILoadingBar1.Visible = false;
		this.regbtn.BackColor = System.Drawing.Color.Black;
		this.regbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.regbtn.Enabled = false;
		this.regbtn.FillColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.regbtn.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.regbtn.FillPressColor = System.Drawing.Color.Black;
		this.regbtn.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.regbtn.Font = new System.Drawing.Font("Calibri", 10.5f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.regbtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.regbtn.ForePressColor = System.Drawing.Color.SkyBlue;
		this.regbtn.Location = new System.Drawing.Point(98, 167);
		this.regbtn.Name = "regbtn";
		this.regbtn.Radius = 10;
		this.regbtn.RectColor = System.Drawing.Color.SkyBlue;
		this.regbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.regbtn.RectHoverColor = System.Drawing.Color.SkyBlue;
		this.regbtn.RectPressColor = System.Drawing.Color.SkyBlue;
		this.regbtn.RectSelectedColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.regbtn.Size = new System.Drawing.Size(117, 24);
		this.regbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.regbtn.SymbolSize = 0;
		this.regbtn.TabIndex = 66;
		this.regbtn.Text = "...";
		this.usrkeyreg.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.usrkeyreg.FillColor = System.Drawing.Color.Black;
		this.usrkeyreg.Font = new System.Drawing.Font("Calibri", 12f);
		this.usrkeyreg.ForeColor = System.Drawing.Color.SkyBlue;
		this.usrkeyreg.Location = new System.Drawing.Point(4, 95);
		this.usrkeyreg.Margin = new System.Windows.Forms.Padding(4);
		this.usrkeyreg.Maximum = 2147483647.0;
		this.usrkeyreg.Minimum = -2147483648.0;
		this.usrkeyreg.Name = "usrkeyreg";
		this.usrkeyreg.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.usrkeyreg.PasswordChar = '•';
		this.usrkeyreg.Radius = 10;
		this.usrkeyreg.RectColor = System.Drawing.Color.SkyBlue;
		this.usrkeyreg.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.usrkeyreg.Size = new System.Drawing.Size(303, 27);
		this.usrkeyreg.Style = DrakeUI.Framework.UIStyle.Custom;
		this.usrkeyreg.TabIndex = 65;
		this.usrkeyreg.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.usrkeyreg.Watermark = "Password";
		this.usremailtextreg.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.usremailtextreg.FillColor = System.Drawing.Color.Black;
		this.usremailtextreg.Font = new System.Drawing.Font("Calibri", 12f);
		this.usremailtextreg.ForeColor = System.Drawing.Color.SkyBlue;
		this.usremailtextreg.Location = new System.Drawing.Point(4, 60);
		this.usremailtextreg.Margin = new System.Windows.Forms.Padding(4);
		this.usremailtextreg.Maximum = 2147483647.0;
		this.usremailtextreg.Minimum = -2147483648.0;
		this.usremailtextreg.Name = "usremailtextreg";
		this.usremailtextreg.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.usremailtextreg.Radius = 10;
		this.usremailtextreg.RectColor = System.Drawing.Color.SkyBlue;
		this.usremailtextreg.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.usremailtextreg.Size = new System.Drawing.Size(303, 27);
		this.usremailtextreg.Style = DrakeUI.Framework.UIStyle.Custom;
		this.usremailtextreg.StyleCustomMode = true;
		this.usremailtextreg.TabIndex = 64;
		this.usremailtextreg.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.usremailtextreg.Watermark = "Account";
		this.Label1.BackColor = System.Drawing.Color.Black;
		this.Label1.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label1.Font = new System.Drawing.Font("Calibri", 14f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label1.Location = new System.Drawing.Point(0, 0);
		this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(309, 56);
		this.Label1.TabIndex = 63;
		this.Label1.Text = "Contact t.me/CobraRat\r\nFor Buy Licence";
		this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.TabPage3.BackColor = System.Drawing.Color.Black;
		this.TabPage3.Location = new System.Drawing.Point(0, 40);
		this.TabPage3.Name = "TabPage3";
		this.TabPage3.Size = new System.Drawing.Size(309, 203);
		this.TabPage3.TabIndex = 3;
		this.TabPage3.Text = "Change HID";
		this.CHIDimg.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.CHIDimg.BackColor = System.Drawing.Color.Black;
		this.CHIDimg.Font = new System.Drawing.Font("Calibri", 12f);
		this.CHIDimg.ForeColor = System.Drawing.Color.SkyBlue;
		this.CHIDimg.Location = new System.Drawing.Point(362, 167);
		this.CHIDimg.Name = "CHIDimg";
		this.CHIDimg.Size = new System.Drawing.Size(23, 24);
		this.CHIDimg.Style = DrakeUI.Framework.UIStyle.Custom;
		this.CHIDimg.StyleCustomMode = true;
		this.CHIDimg.TabIndex = 75;
		this.CHIDimg.Text = "DrakeUILoadingBar1";
		this.CHIDimg.Visible = false;
		this.CHIDbtn.BackColor = System.Drawing.Color.Black;
		this.CHIDbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.CHIDbtn.Enabled = false;
		this.CHIDbtn.FillColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.CHIDbtn.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.CHIDbtn.FillPressColor = System.Drawing.Color.Black;
		this.CHIDbtn.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.CHIDbtn.Font = new System.Drawing.Font("Calibri", 10.5f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.CHIDbtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.CHIDbtn.ForePressColor = System.Drawing.Color.SkyBlue;
		this.CHIDbtn.Location = new System.Drawing.Point(98, 167);
		this.CHIDbtn.Name = "CHIDbtn";
		this.CHIDbtn.Radius = 10;
		this.CHIDbtn.RectColor = System.Drawing.Color.Black;
		this.CHIDbtn.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.CHIDbtn.RectHoverColor = System.Drawing.Color.SkyBlue;
		this.CHIDbtn.RectPressColor = System.Drawing.Color.SkyBlue;
		this.CHIDbtn.RectSelectedColor = System.Drawing.Color.SkyBlue;
		this.CHIDbtn.Size = new System.Drawing.Size(117, 24);
		this.CHIDbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.CHIDbtn.SymbolSize = 0;
		this.CHIDbtn.TabIndex = 73;
		this.CHIDbtn.Text = "...";
		this.CHIDpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.CHIDpassword.FillColor = System.Drawing.Color.Black;
		this.CHIDpassword.Font = new System.Drawing.Font("Calibri", 12f);
		this.CHIDpassword.ForeColor = System.Drawing.Color.SkyBlue;
		this.CHIDpassword.Location = new System.Drawing.Point(4, 95);
		this.CHIDpassword.Margin = new System.Windows.Forms.Padding(4);
		this.CHIDpassword.Maximum = 2147483647.0;
		this.CHIDpassword.Minimum = -2147483648.0;
		this.CHIDpassword.Name = "CHIDpassword";
		this.CHIDpassword.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.CHIDpassword.PasswordChar = '•';
		this.CHIDpassword.Radius = 10;
		this.CHIDpassword.RectColor = System.Drawing.Color.SkyBlue;
		this.CHIDpassword.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.CHIDpassword.Size = new System.Drawing.Size(303, 27);
		this.CHIDpassword.Style = DrakeUI.Framework.UIStyle.Custom;
		this.CHIDpassword.TabIndex = 72;
		this.CHIDpassword.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.CHIDpassword.Watermark = "Password";
		this.CHIDaccount.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.CHIDaccount.FillColor = System.Drawing.Color.Black;
		this.CHIDaccount.Font = new System.Drawing.Font("Calibri", 12f);
		this.CHIDaccount.ForeColor = System.Drawing.Color.SkyBlue;
		this.CHIDaccount.Location = new System.Drawing.Point(4, 60);
		this.CHIDaccount.Margin = new System.Windows.Forms.Padding(4);
		this.CHIDaccount.Maximum = 2147483647.0;
		this.CHIDaccount.Minimum = -2147483648.0;
		this.CHIDaccount.Name = "CHIDaccount";
		this.CHIDaccount.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.CHIDaccount.Radius = 10;
		this.CHIDaccount.RectColor = System.Drawing.Color.SkyBlue;
		this.CHIDaccount.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.CHIDaccount.Size = new System.Drawing.Size(303, 27);
		this.CHIDaccount.Style = DrakeUI.Framework.UIStyle.Custom;
		this.CHIDaccount.StyleCustomMode = true;
		this.CHIDaccount.TabIndex = 71;
		this.CHIDaccount.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.CHIDaccount.Watermark = "Account";
		this.Label2.BackColor = System.Drawing.Color.Black;
		this.Label2.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label2.Font = new System.Drawing.Font("Calibri", 14f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label2.Location = new System.Drawing.Point(0, 0);
		this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(309, 56);
		this.Label2.TabIndex = 70;
		this.Label2.Text = "Change Hardware ID";
		this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.qutelabel.BackColor = System.Drawing.Color.Black;
		this.qutelabel.Dock = System.Windows.Forms.DockStyle.Top;
		this.qutelabel.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.qutelabel.ForeColor = System.Drawing.Color.SkyBlue;
		this.qutelabel.Location = new System.Drawing.Point(0, 84);
		this.qutelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
		this.qutelabel.Name = "qutelabel";
		this.qutelabel.Size = new System.Drawing.Size(320, 35);
		this.qutelabel.TabIndex = 47;
		this.qutelabel.Text = " Telegram t.me/CobraRat ";
		this.qutelabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
		this.welclabel.BackColor = System.Drawing.Color.Black;
		this.welclabel.Dock = System.Windows.Forms.DockStyle.Top;
		this.welclabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.welclabel.ForeColor = System.Drawing.Color.SkyBlue;
		this.welclabel.Location = new System.Drawing.Point(0, 40);
		this.welclabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
		this.welclabel.Name = "welclabel";
		this.welclabel.Size = new System.Drawing.Size(320, 44);
		this.welclabel.TabIndex = 3;
		this.welclabel.Text = "Cobra RAT";
		this.welclabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.PictureBox2.BackColor = System.Drawing.Color.Black;
		this.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
		this.PictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
		this.PictureBox2.Location = new System.Drawing.Point(0, 0);
		this.PictureBox2.Name = "PictureBox2";
		this.PictureBox2.Size = new System.Drawing.Size(320, 40);
		this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.PictureBox2.TabIndex = 30;
		this.PictureBox2.TabStop = false;
		this.policylink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.policylink.VisitedLinkColor = System.Drawing.Color.SkyBlue;
		this.Label13.BackColor = System.Drawing.Color.Black;
		this.Label13.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label13.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label13.Location = new System.Drawing.Point(67, 173);
		this.Label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(423, 35);
		this.Label13.TabIndex = 2;
		this.Label13.Text = "Copyright © 2024";
		this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.statuslabel.BackColor = System.Drawing.Color.Black;
		this.statuslabel.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.statuslabel.Enabled = false;
		this.statuslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.statuslabel.ForeColor = System.Drawing.Color.SkyBlue;
		this.statuslabel.Location = new System.Drawing.Point(0, 476);
		this.statuslabel.Name = "statuslabel";
		this.statuslabel.Size = new System.Drawing.Size(991, 8);
		this.statuslabel.TabIndex = 42;
		this.statuslabel.Text = "Cobra Rat";
		this.statuslabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.statuslabel.Visible = false;
		this.Label3.AutoSize = true;
		this.Label3.BackColor = System.Drawing.Color.Black;
		this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label3.Location = new System.Drawing.Point(3, 467);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(75, 15);
		this.Label3.TabIndex = 31;
		this.Label3.Text = "Cobra Rat";
		this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.Label3.Visible = false;
		this.notpass.Text = "NotifyIcon1";
		this.notpass.Visible = true;
		this.DrakeUIToolTip1.BackColor = System.Drawing.Color.Black;
		this.DrakeUIToolTip1.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIToolTip1.OwnerDraw = true;
		this.ToolTip1.BackColor = System.Drawing.Color.Black;
		this.ToolTip1.ForeColor = System.Drawing.Color.SkyBlue;
		this.pnl0.BackColor = System.Drawing.Color.Black;
		this.pnl0.Controls.Add(this.pnl1);
		this.pnl0.Dock = System.Windows.Forms.DockStyle.Fill;
		this.pnl0.ForeColor = System.Drawing.Color.SkyBlue;
		this.pnl0.Location = new System.Drawing.Point(0, 0);
		this.pnl0.Name = "pnl0";
		this.pnl0.Size = new System.Drawing.Size(991, 484);
		this.pnl0.TabIndex = 0;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.SystemColors.Control;
		base.ClientSize = new System.Drawing.Size(991, 484);
		base.Controls.Add(this.pnl0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "Ports";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Ports";
		this.pnl1.ResumeLayout(false);
		this.pnl1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		this.Panel1.ResumeLayout(false);
		this.DrakeUITabControl1.ResumeLayout(false);
		this.TabPage2.ResumeLayout(false);
		this.TabPage1.ResumeLayout(false);
		this.TabPage3.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.PictureBox2).EndInit();
		this.pnl0.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	public Ports()
	{
		base.Load += CraxsRatkfvuiorkenfudpajrsnCraxsRatswsxcddgto;
		base.FormClosing += Ports_FormClosing;
		r = null;
		Ping_Json = "Ping";
		Check_Json = "Check";
		Checkv2_Json = "Checkv2";
		Session = "Session";
		IDC_Json = "IDC";
		Secritkey = "YS5pW5qXMuYnTPNbpkhLx5mYY4vwQn9x";
		holder = "...";
		index = 0;
		Finish = false;
		S = false;
		InitializeComponent();
		Font = reso.f;
	}

	public void CraxsStyle()
	{
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "CN", TextCompare: false) == 0)
			{
				policylink.Text = "我同意服务条款";
				savekey.Text = "记住账户";
				usrkeytext.Watermark = "登录密钥";
				usremailtext.Watermark = "电子邮件";
				qutelabel.Text = "登录到您的帐户";
				welclabel.Text = "欢迎来到 Cobra Rat";
				exitbtn.Text = Codes.Translate(exitbtn.Text, "en", "zh");
				DrakeUITabControl1.TabPages[0].Text = "登录";
				DrakeUITabControl1.TabPages[1].Text = "注册";
				DrakeUITabControl1.TabPages[2].Text = "改绑";
				loginlabel.Text = "账户登录";
				Label1.Text = "账户注册";
				Label2.Text = "账户改绑";
			}
		}
		else
		{
			policylink.Text = "أوافق على شروط الخدمة";
			savekey.Text = "تذكرني";
			usrkeytext.Watermark = "مفتاح الدخول";
			usremailtext.Watermark = "البريد";
			qutelabel.Text = "تسجيل الدخول إلى حسابك";
			welclabel.Text = "مرحب\u064bا بك في Cobra Rat";
			exitbtn.Text = Codes.Translate(exitbtn.Text, "en", "ar");
		}
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatswsxcddgto(object sender, EventArgs e)
	{
		base.Opacity = 0.0;
		base.Icon = Resources.max;
		if (RegistryHandler.Get_ID_ASSIST() == null)
		{
			RegistryHandler.Set_ID_ASSIST(SecurityKey.GenRandom(15));
		}
		try
		{
			string oSFullName = MyProject.Computer.Info.OSFullName;
			if (!oSFullName.Contains("Windows 10") && RegistryHandler.getworning() == null)
			{
				comptableform comptableform2 = new comptableform();
				comptableform2.ShowDialog();
				RegistryHandler.setworning("done");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		CraxsStyle();
		usrkeytext.Text = Codes.getuserkey();
		usremailtext.Text = RegistryHandler.Get_EMAIL();
		loginbtn.Focus();
		statuslabel.Text = "";
		FadeIn(this, 40);
		DrakeUITabControl1.ItemSize = new Size(checked((int)Conversion.Int((double)DrakeUITabControl1.Size.Width / 3.0 - 5.0)), DrakeUITabControl1.ItemSize.Height);
	}

	[AsyncStateMachine(typeof(VB_0024StateMachine_174_FadeIn))]
	[DebuggerStepThrough]
	private void FadeIn(Form o, int interval = 80)
	{
		VB_0024StateMachine_174_FadeIn stateMachine = new VB_0024StateMachine_174_FadeIn();
		stateMachine._0024VB_0024Me = this;
		stateMachine._0024VB_0024Local_o = o;
		stateMachine._0024VB_0024Local_interval = interval;
		stateMachine._0024State = -1;
		stateMachine._0024Builder = AsyncVoidMethodBuilder.Create();
		stateMachine._0024Builder.Start(ref stateMachine);
	}

	[DllImport("Kernel32.dll")]
	public static extern IntPtr GetCurrentThread();

	public void Done(object[] objs)
	{
		if (statuslabel.InvokeRequired)
		{
			addLogback method = Done;
			statuslabel.Invoke(method, new object[1] { objs });
			return;
		}
		string text = Conversions.ToString(objs[0]);
		if (text.StartsWith("war:"))
		{
			CraxsAlert.ShowWarning(text.Replace("war:", ""));
		}
		else
		{
			statuslabel.Text = text;
		}
	}

	public void opebbtn(object[] objs)
	{
		if (loginbtn.InvokeRequired)
		{
			opebbtndele method = opebbtn;
			loginbtn.Invoke(method, new object[1] { objs });
			return;
		}
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "CN", TextCompare: false) != 0)
			{
				loginbtn.Text = Codes.AES_Decrypt("Jyew2tI1udg4ZJM+uI+ywA==", "Accept");
			}
			else
			{
				loginbtn.Text = "登录";
			}
		}
		else
		{
			loginbtn.Text = "دخول";
		}
		if (regbtn.InvokeRequired)
		{
			opebbtndele method2 = opebbtn;
			regbtn.Invoke(method2, new object[1] { objs });
			return;
		}
		string language2 = RegistryHandler.Get_Language();
		if (Operators.CompareString(language2, "AR", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language2, "CN", TextCompare: false) != 0)
			{
				regbtn.Text = Codes.AES_Decrypt("gEOGS/k9YZ32Eshi4O/yRA==", "Accept");
			}
			else
			{
				regbtn.Text = "注册";
			}
		}
		else
		{
			regbtn.Text = "يسجل";
		}
		if (CHIDbtn.InvokeRequired)
		{
			opebbtndele method3 = opebbtn;
			CHIDbtn.Invoke(method3, new object[1] { objs });
			return;
		}
		string language3 = RegistryHandler.Get_Language();
		if (Operators.CompareString(language3, "AR", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language3, "CN", TextCompare: false) != 0)
			{
				CHIDbtn.Text = Codes.AES_Decrypt("NVaV3uRo7qptIhYJwMmW+g==", "Accept");
			}
			else
			{
				CHIDbtn.Text = "更改";
			}
		}
		else
		{
			CHIDbtn.Text = "يتغير";
		}
	}

	public object RandomString()
	{
		if (r == null)
		{
			r = new Random();
		}
		string text = "abcdefghijklmnopqrstuvwxyz";
		StringBuilder stringBuilder = new StringBuilder();
		int num = 32;
		for (int i = 1; i <= num; i = checked(i + 1))
		{
			int startIndex = r.Next(0, text.Length);
			stringBuilder.Append(text.Substring(startIndex, 1));
		}
		return stringBuilder.ToString();
	}

	public string DecryptRJ256(string prm_key, string prm_iv, string prm_text_to_decrypt)
	{
		byte[] bytes = Encoding.ASCII.GetBytes(prm_key);
		byte[] bytes2 = Encoding.ASCII.GetBytes(prm_iv);
		byte[] array2;
		using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
		{
			rijndaelManaged.Padding = PaddingMode.PKCS7;
			rijndaelManaged.Mode = CipherMode.CBC;
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			ICryptoTransform transform = rijndaelManaged.CreateDecryptor(bytes, bytes2);
			byte[] array = Convert.FromBase64String(prm_text_to_decrypt);
			array2 = new byte[checked(array.Length - 1 + 1)];
			MemoryStream stream = new MemoryStream(array);
			CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Read);
			cryptoStream.Read(array2, 0, array2.Length);
		}
		return Encoding.ASCII.GetString(array2);
	}

	public string EncryptRJ256(string prm_key, string prm_iv, string prm_text_to_encrypt)
	{
		byte[] bytes = Encoding.ASCII.GetBytes(prm_key);
		byte[] bytes2 = Encoding.ASCII.GetBytes(prm_iv);
		byte[] inArray;
		using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
		{
			rijndaelManaged.Padding = PaddingMode.PKCS7;
			rijndaelManaged.Mode = CipherMode.CBC;
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			ICryptoTransform transform = rijndaelManaged.CreateEncryptor(bytes, bytes2);
			byte[] bytes3 = Encoding.ASCII.GetBytes(prm_text_to_encrypt);
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			cryptoStream.Write(bytes3, 0, bytes3.Length);
			cryptoStream.FlushFinalBlock();
			inArray = memoryStream.ToArray();
		}
		return Convert.ToBase64String(inArray);
	}

	public string KeepOnlyEnglishLetters(string input)
	{
		string pattern = "[^a-zA-Z]";
		return Regex.Replace(input, pattern, "");
	}

	private void pnl1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.No;
		Close();
	}

	private void Addpo_Click(object sender, EventArgs e)
	{
	}

	private void Rempo_Click(object sender, EventArgs e)
	{
	}

	private void DrakeUILinkLabel1_Click(object sender, EventArgs e)
	{
		MyProject.Forms.Dialog2.ShowDialog();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
	}

	private void Pnl1_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			Codes.ReleaseCapture();
			Codes.SendMessage(base.Handle, 161, 2, 0);
		}
	}

	private void PictureBox3_Click(object sender, EventArgs e)
	{
	}

	private void PictureBox3_Click_1(object sender, EventArgs e)
	{
		try
		{
			Process.Start("https://www.t.me/darKnet_JoKer");
		}
		catch (Exception)
		{
		}
	}

	private void Ports_FormClosing(object sender, FormClosingEventArgs e)
	{
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		checked
		{
			if (statuslabel.Text.Length < holder.Length)
			{
				if (!S)
				{
					S = true;
					MyProject.Forms.CraxsRatMain.StartWorkercheck();
				}
				statuslabel.Text += holder.Replace("...", "");
				index++;
			}
			else if (Finish)
			{
				Timer1.Stop();
				base.DialogResult = DialogResult.OK;
				loadingimage.Enabled = false;
				MyProject.Forms.CraxsRatMain.Timer1.Enabled = true;
				Close();
			}
			else
			{
				statuslabel.Text = statuslabel.Text.Replace("...", "");
				index -= 3;
			}
		}
	}

	private void Statuslabel_Click(object sender, EventArgs e)
	{
	}

	private void Label1_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			Codes.ReleaseCapture();
			Codes.SendMessage(base.Handle, 161, 2, 0);
		}
	}

	private void PictureBox2_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			Codes.ReleaseCapture();
			Codes.SendMessage(base.Handle, 161, 2, 0);
		}
	}

	private void Panel3_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			Codes.ReleaseCapture();
			Codes.SendMessage(base.Handle, 161, 2, 0);
		}
	}

	private void Porttext_KeyPress(object sender, KeyPressEventArgs e)
	{
	}

	private void Porttext_TextChanged(object sender, EventArgs e)
	{
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			Codes.ReleaseCapture();
			Codes.SendMessage(base.Handle, 161, 2, 0);
		}
	}

	private void DrakeUIButtonIcon1_Click_1(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.No;
		Close();
	}

	private void DrakeUILinkLabel1_Click_2(object sender, EventArgs e)
	{
		Process.Start("http://t.me/DarKnet_JoKer");
	}

	private void Usrkeytext_MouseEnter(object sender, EventArgs e)
	{
		usrkeytext.PasswordChar = '\0';
	}

	private void Usrkeytext_MouseLeave(object sender, EventArgs e)
	{
		usrkeytext.PasswordChar = '•';
	}

	private void PictureBox1_MouseDown_1(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			Codes.ReleaseCapture();
			Codes.SendMessage(base.Handle, 161, 2, 0);
		}
	}

	private void DrakeUILinkLabel2_Click(object sender, EventArgs e)
	{
	}

	private void welclabel_Click(object sender, EventArgs e)
	{
	}

	private void DrakeUIButtonIcon1_Click_2(object sender, EventArgs e)
	{
	}

	private void b_ok_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.OK;
		if (loginworker.IsBusy)
		{
			CraxsAlert.Showinformation(Codes.AES_Decrypt("dpiLCWTWSlH1sTNfqjsrIg==", "back"));
			return;
		}
		loadingimage.Visible = true;
		loginbtn.Enabled = false;
		loginworker.RunWorkerAsync();
	}

	private void b_reg_Click(object sender, EventArgs e)
	{
		if (regworker.IsBusy)
		{
			CraxsAlert.Showinformation(Codes.AES_Decrypt("dpiLCWTWSlH1sTNfqjsrIg==", "back"));
			return;
		}
		loadingimageR.Visible = true;
		regbtn.Enabled = false;
		regworker.RunWorkerAsync();
	}

	private void CHIDbtn_Click(object sender, EventArgs e)
	{
		if (changeIDWorker.IsBusy)
		{
			CraxsAlert.Showinformation(Codes.AES_Decrypt("dpiLCWTWSlH1sTNfqjsrIg==", "back"));
			return;
		}
		CHIDimg.Visible = true;
		CHIDbtn.Enabled = false;
		changeIDWorker.RunWorkerAsync();
	}

	private void changeIDWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		CHIDimg.Visible = false;
		CHIDbtn.Enabled = true;
		CHIDaccount.Text = "";
		CHIDpassword.Text = "";
	}

	private void regworker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		loadingimageR.Visible = false;
		regbtn.Enabled = true;
		usremailtextreg.Text = "";
		usrkeyreg.Text = "";
		keyText.Text = "";
	}

	private void loginworker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		loadingimage.Visible = false;
		loginbtn.Enabled = true;
	}

	private void Regworker_DoWork(object sender, DoWorkEventArgs e)
	{
		try
		{
			if (Operators.CompareString(regbtn.Text, "...", TextCompare: false) == 0)
			{
				Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					CraxsAlert.Showinformation("Please Wait..");
				}));
				return;
			}
			if (string.IsNullOrEmpty(usremailtextreg.Text))
			{
				Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					Codes.MyMsgBox("Empty Account", "Please Enter Account!", useno: false, Resources.LOGO);
				}));
				return;
			}
			if (string.IsNullOrEmpty(usrkeyreg.Text) | string.IsNullOrWhiteSpace(usrkeyreg.Text))
			{
				Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					Codes.MyMsgBox("Empty Password", "Enter User Password!", useno: false, Resources.LOGO);
				}));
				return;
			}
			if (string.IsNullOrEmpty(keyText.Text))
			{
				Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					Codes.MyMsgBox("Empty Key", "Please Enter Key!", useno: false, Resources.LOGO);
				}));
				return;
			}
			if (!Regex.IsMatch(usremailtextreg.Text, "^[a-z0-9A-Z]+$"))
			{
				Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					Codes.MyMsgBox("Wrong Account", "Only letters and numbers can be used!", useno: false, Resources.LOGO);
				}));
				return;
			}
			if (!Regex.IsMatch(usrkeyreg.Text, "^[a-z0-9A-Z]+$"))
			{
				Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					Codes.MyMsgBox("Wrong Password", "Only letters and numbers can be used!", useno: false, Resources.LOGO);
				}));
				return;
			}
			if (!Regex.IsMatch(keyText.Text, "^[a-z0-9A-Z]+$"))
			{
				Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					Codes.MyMsgBox("Wrong Key", "Only letters and numbers can be used!", useno: false, Resources.LOGO);
				}));
				return;
			}
			string msg = Codes.ApiReg(usremailtextreg.Text, usrkeyreg.Text, keyText.Text);
			Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				Codes.MyMsgBox("Tip", msg, useno: false, Resources.LOGO);
			}));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Exception ex3 = ex2;
			Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				Codes.MyMsgBox("Error x7", ex3.Message, useno: false, Resources.error48px);
			}));
			Environment.Exit(0);
			ProjectData.ClearProjectError();
		}
	}

	private void changeIDWorker_DoWork(object sender, DoWorkEventArgs e)
	{
		try
		{
			if (Operators.CompareString(CHIDbtn.Text, "...", TextCompare: false) == 0)
			{
				Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					CraxsAlert.Showinformation("Please Wait..");
				}));
				return;
			}
			if (string.IsNullOrEmpty(CHIDaccount.Text))
			{
				Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					Codes.MyMsgBox("Empty Account", "Please Enter Account!", useno: false, Resources.LOGO);
				}));
				return;
			}
			if (string.IsNullOrEmpty(CHIDpassword.Text) | string.IsNullOrWhiteSpace(CHIDpassword.Text))
			{
				Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					Codes.MyMsgBox("Empty Password", "Enter User Password!", useno: false, Resources.LOGO);
				}));
				return;
			}
			if (!Regex.IsMatch(CHIDaccount.Text, "^[a-z0-9A-Z]+$"))
			{
				Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					Codes.MyMsgBox("Wrong Account", "Only letters and numbers can be used!", useno: false, Resources.LOGO);
				}));
				return;
			}
			if (!Regex.IsMatch(CHIDpassword.Text, "^[a-z0-9A-Z]+$"))
			{
				Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					Codes.MyMsgBox("Wrong Password", "Only letters and numbers can be used!", useno: false, Resources.LOGO);
				}));
				return;
			}
			string msg = Codes.ApiChangeID(CHIDaccount.Text, CHIDpassword.Text);
			Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				Codes.MyMsgBox("Tip", msg, useno: false, Resources.LOGO);
			}));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Exception ex3 = ex2;
			Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				Codes.MyMsgBox("Error x7", ex3.Message, useno: false, Resources.error48px);
			}));
			Environment.Exit(0);
			ProjectData.ClearProjectError();
		}
	}

	private void Loginworker_DoWork(object sender, DoWorkEventArgs e)
	{
		try
		{
			if (Operators.CompareString(loginbtn.Text, "...", TextCompare: false) == 0)
			{
				Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					CraxsAlert.Showinformation("Please Wait..");
				}));
				return;
			}
			if (string.IsNullOrEmpty(usremailtext.Text))
			{
				Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					Codes.MyMsgBox("Empty Account", "Please Enter Account!", useno: false, Resources.LOGO);
				}));
				return;
			}
			if (string.IsNullOrEmpty(usrkeytext.Text) | string.IsNullOrWhiteSpace(usrkeytext.Text))
			{
				Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					Codes.MyMsgBox("Empty Account", "Enter User Password!", useno: false, Resources.LOGO);
				}));
				return;
			}
			if (!Regex.IsMatch(usremailtext.Text, "^[a-z0-9A-Z]+$"))
			{
				Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					Codes.MyMsgBox("Wrong Account", "Only letters and numbers can be used!", useno: false, Resources.LOGO);
				}));
				return;
			}
			if (!Regex.IsMatch(usrkeytext.Text, "^[a-z0-9A-Z]+$"))
			{
				Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					Codes.MyMsgBox("Wrong Password", "Only letters and numbers can be used!", useno: false, Resources.LOGO);
				}));
				return;
			}
			string text = Codes.Apilogin(usremailtext.Text, usrkeytext.Text);
			if (Operators.CompareString(text, "", TextCompare: false) != 0)
			{
				Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					Codes.MyMsgBox("Tip", text, useno: false, Resources.LOGO);
				}));
				return;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Exception ex3 = ex2;
			Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				Codes.MyMsgBox("Error x7", ex3.Message, useno: false, Resources.error48px);
			}));
			Environment.Exit(0);
			ProjectData.ClearProjectError();
		}
		try
		{
			Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				if (savekey.Checked)
				{
					Codes.GetKeyFromReg(usrkeytext.Text);
					RegistryHandler.Set_EMAIL(usremailtext.Text);
				}
				else
				{
					Codes.GetKeyFromReg("");
					RegistryHandler.Set_EMAIL("");
				}
				try
				{
					string text2 = Codes.CheckForUpdates2();
					if (text2 != null)
					{
						if (Operators.CompareString(text2, "Error", TextCompare: false) != 0)
						{
							string[] array = text2.Split('|');
							if (Operators.CompareString(array[0], "7.0", TextCompare: false) != 0)
							{
								Process.Start(array[1]);
								Environment.Exit(0);
							}
						}
						else
						{
							Environment.Exit(0);
						}
					}
					else
					{
						Environment.Exit(0);
					}
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					Environment.Exit(0);
					ProjectData.ClearProjectError();
				}
				Finish = true;
			}));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void PictureBox1_Click(object sender, EventArgs e)
	{
	}
}
