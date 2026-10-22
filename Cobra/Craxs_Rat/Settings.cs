using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Craxs_Rat.My;
using Craxs_Rat.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat;

[DesignerGenerated]
public class Settings : Form
{
	private IContainer components;

	[AccessedThroughProperty("DGV0")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DataGridView _DGV0;

	[AccessedThroughProperty("DGV1")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DataGridView _DGV1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("SV")]
	private Button _SV;

	[AccessedThroughProperty("DL")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button _DL;

	[AccessedThroughProperty("DGV2")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DataGridView _DGV2;

	[CompilerGenerated]
	[AccessedThroughProperty("DGV3")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DataGridView _DGV3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGV4")]
	private DataGridView _DGV4;

	[AccessedThroughProperty("DGV5")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DataGridView _DGV5;

	[AccessedThroughProperty("TOpacity")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Timer _TOpacity;

	[AccessedThroughProperty("DGV6")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DataGridView _DGV6;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGV7")]
	private DataGridView _DGV7;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGV8")]
	private DataGridView _DGV8;

	[AccessedThroughProperty("DGV9")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DataGridView _DGV9;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DefaultToolStripMenuItem")]
	private ToolStripMenuItem _DefaultToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("clr_1")]
	private ToolStripMenuItem _clr_1;

	[AccessedThroughProperty("clr_2")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ToolStripMenuItem _clr_2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Clr3ToolStripMenuItem")]
	private ToolStripMenuItem _Clr3ToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Clr4ToolStripMenuItem")]
	private ToolStripMenuItem _Clr4ToolStripMenuItem;

	[AccessedThroughProperty("Clr5ToolStripMenuItem")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ToolStripMenuItem _Clr5ToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Clr6ToolStripMenuItem")]
	private ToolStripMenuItem _Clr6ToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Clr7ToolStripMenuItem")]
	private ToolStripMenuItem _Clr7ToolStripMenuItem;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Clr8ToolStripMenuItem")]
	[CompilerGenerated]
	private ToolStripMenuItem _Clr8ToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Clr9ToolStripMenuItem")]
	private ToolStripMenuItem _Clr9ToolStripMenuItem;

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
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

	internal virtual DataGridView DGV0
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
			DataGridViewCellEventHandler value2 = DGV0_CellEnter;
			DataGridView dataGridView = _DGV0;
			if (dataGridView != null)
			{
				dataGridView.CellEnter -= value2;
			}
			_DGV0 = value;
			dataGridView = _DGV0;
			if (dataGridView != null)
			{
				dataGridView.CellEnter += value2;
			}
		}
	}

	internal virtual DataGridView DGV1
	{
		[CompilerGenerated]
		get
		{
			return _DGV1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DataGridViewCellEventHandler value2 = DGV1_CellEnter;
			DataGridViewCellEventHandler value3 = DGV1_CellContentClick;
			DataGridView dataGridView = _DGV1;
			if (dataGridView != null)
			{
				dataGridView.CellEnter -= value2;
				dataGridView.CellContentClick -= value3;
			}
			_DGV1 = value;
			dataGridView = _DGV1;
			if (dataGridView != null)
			{
				dataGridView.CellEnter += value2;
				dataGridView.CellContentClick += value3;
			}
		}
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button SV
	{
		[CompilerGenerated]
		get
		{
			return _SV;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = SV_Click;
			Button button = _SV;
			if (button != null)
			{
				button.Click -= value2;
			}
			_SV = value;
			button = _SV;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button DL
	{
		[CompilerGenerated]
		get
		{
			return _DL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DL_Click;
			Button button = _DL;
			if (button != null)
			{
				button.Click -= value2;
			}
			_DL = value;
			button = _DL;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel2")]
	internal virtual Panel Panel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DataGridView DGV2
	{
		[CompilerGenerated]
		get
		{
			return _DGV2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DataGridViewCellEventHandler value2 = DGV2_CellEnter;
			DataGridView dataGridView = _DGV2;
			if (dataGridView != null)
			{
				dataGridView.CellEnter -= value2;
			}
			_DGV2 = value;
			dataGridView = _DGV2;
			if (dataGridView != null)
			{
				dataGridView.CellEnter += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DataGridView DGV3
	{
		[CompilerGenerated]
		get
		{
			return _DGV3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DataGridViewCellEventHandler value2 = DGV3_CellEnter;
			DataGridView dataGridView = _DGV3;
			if (dataGridView != null)
			{
				dataGridView.CellEnter -= value2;
			}
			_DGV3 = value;
			dataGridView = _DGV3;
			if (dataGridView != null)
			{
				dataGridView.CellEnter += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DataGridView DGV4
	{
		[CompilerGenerated]
		get
		{
			return _DGV4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DataGridViewCellEventHandler value2 = DGV4_CellEnter;
			DataGridView dataGridView = _DGV4;
			if (dataGridView != null)
			{
				dataGridView.CellEnter -= value2;
			}
			_DGV4 = value;
			dataGridView = _DGV4;
			if (dataGridView != null)
			{
				dataGridView.CellEnter += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DataGridView DGV5
	{
		[CompilerGenerated]
		get
		{
			return _DGV5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DataGridViewCellEventHandler value2 = DGV5_CellEnter;
			DataGridViewCellEventHandler value3 = DGV5_CellContentClick;
			DataGridView dataGridView = _DGV5;
			if (dataGridView != null)
			{
				dataGridView.CellEnter -= value2;
				dataGridView.CellContentClick -= value3;
			}
			_DGV5 = value;
			dataGridView = _DGV5;
			if (dataGridView != null)
			{
				dataGridView.CellEnter += value2;
				dataGridView.CellContentClick += value3;
			}
		}
	}

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	internal virtual DataGridView DGV6
	{
		[CompilerGenerated]
		get
		{
			return _DGV6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DataGridViewCellEventHandler value2 = DGV6_CellEnter;
			DataGridView dataGridView = _DGV6;
			if (dataGridView != null)
			{
				dataGridView.CellEnter -= value2;
			}
			_DGV6 = value;
			dataGridView = _DGV6;
			if (dataGridView != null)
			{
				dataGridView.CellEnter += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DataGridView DGV7
	{
		[CompilerGenerated]
		get
		{
			return _DGV7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DataGridViewCellEventHandler value2 = DGV7_CellEnter;
			DataGridView dataGridView = _DGV7;
			if (dataGridView != null)
			{
				dataGridView.CellEnter -= value2;
			}
			_DGV7 = value;
			dataGridView = _DGV7;
			if (dataGridView != null)
			{
				dataGridView.CellEnter += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DataGridView DGV8
	{
		[CompilerGenerated]
		get
		{
			return _DGV8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DataGridViewCellEventHandler value2 = DGV8_CellEnter;
			DataGridView dataGridView = _DGV8;
			if (dataGridView != null)
			{
				dataGridView.CellEnter -= value2;
			}
			_DGV8 = value;
			dataGridView = _DGV8;
			if (dataGridView != null)
			{
				dataGridView.CellEnter += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DataGridView DGV9
	{
		[CompilerGenerated]
		get
		{
			return _DGV9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DataGridViewCellEventHandler value2 = DGV9_CellEnter;
			DataGridView dataGridView = _DGV9;
			if (dataGridView != null)
			{
				dataGridView.CellEnter -= value2;
			}
			_DGV9 = value;
			dataGridView = _DGV9;
			if (dataGridView != null)
			{
				dataGridView.CellEnter += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label10")]
	internal virtual Label Label10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn9")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewComboBoxColumn8")]
	internal virtual DataGridViewComboBoxColumn DataGridViewComboBoxColumn8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn8")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewComboBoxColumn7")]
	internal virtual DataGridViewComboBoxColumn DataGridViewComboBoxColumn7
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

	[field: AccessedThroughProperty("DataGridViewComboBoxColumn6")]
	internal virtual DataGridViewComboBoxColumn DataGridViewComboBoxColumn6
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

	[field: AccessedThroughProperty("DataGridViewComboBoxColumn5")]
	internal virtual DataGridViewComboBoxColumn DataGridViewComboBoxColumn5
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

	[field: AccessedThroughProperty("Column3")]
	internal virtual DataGridViewImageColumn Column3
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

	[field: AccessedThroughProperty("DataGridViewComboBoxColumn4")]
	internal virtual DataGridViewComboBoxColumn DataGridViewComboBoxColumn4
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

	[field: AccessedThroughProperty("DataGridViewComboBoxColumn3")]
	internal virtual DataGridViewComboBoxColumn DataGridViewComboBoxColumn3
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

	[field: AccessedThroughProperty("DataGridViewComboBoxColumn2")]
	internal virtual DataGridViewComboBoxColumn DataGridViewComboBoxColumn2
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

	[field: AccessedThroughProperty("DataGridViewComboBoxColumn1")]
	internal virtual DataGridViewComboBoxColumn DataGridViewComboBoxColumn1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column1")]
	internal virtual DataGridViewTextBoxColumn Column1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column2")]
	internal virtual DataGridViewComboBoxColumn Column2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ctxPacket")]
	internal virtual ContextMenuStrip ctxPacket
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem DefaultToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _DefaultToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DefaultToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _DefaultToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_DefaultToolStripMenuItem = value;
			toolStripMenuItem = _DefaultToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem clr_1
	{
		[CompilerGenerated]
		get
		{
			return _clr_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = clr_1ToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _clr_1;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_clr_1 = value;
			toolStripMenuItem = _clr_1;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem clr_2
	{
		[CompilerGenerated]
		get
		{
			return _clr_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = clr_2ToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _clr_2;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_clr_2 = value;
			toolStripMenuItem = _clr_2;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem Clr3ToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _Clr3ToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Clr3ToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _Clr3ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_Clr3ToolStripMenuItem = value;
			toolStripMenuItem = _Clr3ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem Clr4ToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _Clr4ToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Clr4ToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _Clr4ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_Clr4ToolStripMenuItem = value;
			toolStripMenuItem = _Clr4ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem Clr5ToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _Clr5ToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Clr5ToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _Clr5ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_Clr5ToolStripMenuItem = value;
			toolStripMenuItem = _Clr5ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem Clr6ToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _Clr6ToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Clr6ToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _Clr6ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_Clr6ToolStripMenuItem = value;
			toolStripMenuItem = _Clr6ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem Clr7ToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _Clr7ToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Clr7ToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _Clr7ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_Clr7ToolStripMenuItem = value;
			toolStripMenuItem = _Clr7ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem Clr8ToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _Clr8ToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Clr8ToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _Clr8ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_Clr8ToolStripMenuItem = value;
			toolStripMenuItem = _Clr8ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem Clr9ToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _Clr9ToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Clr9ToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _Clr9ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_Clr9ToolStripMenuItem = value;
			toolStripMenuItem = _Clr9ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Craxs_Rat.Settings));
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
		this.Panel1 = new System.Windows.Forms.Panel();
		this.DGV9 = new System.Windows.Forms.DataGridView();
		this.DataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewComboBoxColumn8 = new System.Windows.Forms.DataGridViewComboBoxColumn();
		this.Label10 = new System.Windows.Forms.Label();
		this.DGV8 = new System.Windows.Forms.DataGridView();
		this.DataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewComboBoxColumn7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
		this.Label9 = new System.Windows.Forms.Label();
		this.DGV7 = new System.Windows.Forms.DataGridView();
		this.DataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewComboBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
		this.Label8 = new System.Windows.Forms.Label();
		this.DGV6 = new System.Windows.Forms.DataGridView();
		this.DataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewComboBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
		this.Label7 = new System.Windows.Forms.Label();
		this.DGV5 = new System.Windows.Forms.DataGridView();
		this.DataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
		this.Label6 = new System.Windows.Forms.Label();
		this.DGV4 = new System.Windows.Forms.DataGridView();
		this.DataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewComboBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
		this.Label5 = new System.Windows.Forms.Label();
		this.DGV3 = new System.Windows.Forms.DataGridView();
		this.DataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewComboBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
		this.Label4 = new System.Windows.Forms.Label();
		this.DGV2 = new System.Windows.Forms.DataGridView();
		this.DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewComboBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
		this.Label3 = new System.Windows.Forms.Label();
		this.DGV1 = new System.Windows.Forms.DataGridView();
		this.DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
		this.Label2 = new System.Windows.Forms.Label();
		this.DGV0 = new System.Windows.Forms.DataGridView();
		this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
		this.Label1 = new System.Windows.Forms.Label();
		this.SV = new System.Windows.Forms.Button();
		this.DL = new System.Windows.Forms.Button();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.TOpacity = new System.Windows.Forms.Timer(this.components);
		this.ctxPacket = new System.Windows.Forms.ContextMenuStrip(this.components);
		this.DefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.clr_1 = new System.Windows.Forms.ToolStripMenuItem();
		this.clr_2 = new System.Windows.Forms.ToolStripMenuItem();
		this.Clr3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.Clr4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.Clr5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.Clr6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.Clr7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.Clr8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.Clr9ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.Panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.DGV9).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.DGV8).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.DGV7).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.DGV6).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.DGV5).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.DGV4).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.DGV3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.DGV2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.DGV1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.DGV0).BeginInit();
		this.Panel2.SuspendLayout();
		this.ctxPacket.SuspendLayout();
		base.SuspendLayout();
		this.Panel1.AutoScroll = true;
		this.Panel1.BackColor = System.Drawing.Color.DimGray;
		this.Panel1.Controls.Add(this.DGV9);
		this.Panel1.Controls.Add(this.Label10);
		this.Panel1.Controls.Add(this.DGV8);
		this.Panel1.Controls.Add(this.Label9);
		this.Panel1.Controls.Add(this.DGV7);
		this.Panel1.Controls.Add(this.Label8);
		this.Panel1.Controls.Add(this.DGV6);
		this.Panel1.Controls.Add(this.Label7);
		this.Panel1.Controls.Add(this.DGV5);
		this.Panel1.Controls.Add(this.Label6);
		this.Panel1.Controls.Add(this.DGV4);
		this.Panel1.Controls.Add(this.Label5);
		this.Panel1.Controls.Add(this.DGV3);
		this.Panel1.Controls.Add(this.Label4);
		this.Panel1.Controls.Add(this.DGV2);
		this.Panel1.Controls.Add(this.Label3);
		this.Panel1.Controls.Add(this.DGV1);
		this.Panel1.Controls.Add(this.Label2);
		this.Panel1.Controls.Add(this.DGV0);
		this.Panel1.Controls.Add(this.Label1);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel1.Location = new System.Drawing.Point(0, 0);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(369, 354);
		this.Panel1.TabIndex = 1;
		this.DGV9.AllowUserToAddRows = false;
		this.DGV9.AllowUserToDeleteRows = false;
		this.DGV9.AllowUserToResizeColumns = false;
		this.DGV9.AllowUserToResizeRows = false;
		this.DGV9.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.DGV9.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DGV9.BackgroundColor = System.Drawing.Color.Black;
		this.DGV9.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.DGV9.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
		this.DGV9.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGV9.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		this.DGV9.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		this.DGV9.ColumnHeadersVisible = false;
		this.DGV9.Columns.AddRange(this.DataGridViewTextBoxColumn9, this.DataGridViewComboBoxColumn8);
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(51, 153, 255);
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.DGV9.DefaultCellStyle = dataGridViewCellStyle2;
		this.DGV9.Dock = System.Windows.Forms.DockStyle.Top;
		this.DGV9.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
		this.DGV9.EnableHeadersVisualStyles = false;
		this.DGV9.GridColor = System.Drawing.Color.FromArgb(42, 42, 42);
		this.DGV9.Location = new System.Drawing.Point(0, 956);
		this.DGV9.Name = "DGV9";
		this.DGV9.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		this.DGV9.RowHeadersVisible = false;
		this.DGV9.ScrollBars = System.Windows.Forms.ScrollBars.None;
		this.DGV9.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGV9.Size = new System.Drawing.Size(352, 75);
		this.DGV9.TabIndex = 22;
		this.DataGridViewTextBoxColumn9.HeaderText = "Property";
		this.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9";
		this.DataGridViewTextBoxColumn9.ReadOnly = true;
		this.DataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.DataGridViewComboBoxColumn8.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
		this.DataGridViewComboBoxColumn8.DisplayStyleForCurrentCellOnly = true;
		this.DataGridViewComboBoxColumn8.FlatStyle = System.Windows.Forms.FlatStyle.System;
		this.DataGridViewComboBoxColumn8.HeaderText = "value";
		this.DataGridViewComboBoxColumn8.Name = "DataGridViewComboBoxColumn8";
		this.DataGridViewComboBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		this.Label10.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
		this.Label10.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label10.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label10.Location = new System.Drawing.Point(0, 932);
		this.Label10.Name = "Label10";
		this.Label10.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
		this.Label10.Size = new System.Drawing.Size(352, 24);
		this.Label10.TabIndex = 21;
		this.Label10.Text = "File Manager";
		this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.DGV8.AllowUserToAddRows = false;
		this.DGV8.AllowUserToDeleteRows = false;
		this.DGV8.AllowUserToResizeColumns = false;
		this.DGV8.AllowUserToResizeRows = false;
		this.DGV8.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.DGV8.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DGV8.BackgroundColor = System.Drawing.Color.Black;
		this.DGV8.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.DGV8.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
		this.DGV8.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGV8.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
		this.DGV8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		this.DGV8.ColumnHeadersVisible = false;
		this.DGV8.Columns.AddRange(this.DataGridViewTextBoxColumn8, this.DataGridViewComboBoxColumn7);
		dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(51, 153, 255);
		dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
		dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.DGV8.DefaultCellStyle = dataGridViewCellStyle4;
		this.DGV8.Dock = System.Windows.Forms.DockStyle.Top;
		this.DGV8.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
		this.DGV8.EnableHeadersVisualStyles = false;
		this.DGV8.GridColor = System.Drawing.Color.FromArgb(42, 42, 42);
		this.DGV8.Location = new System.Drawing.Point(0, 857);
		this.DGV8.Name = "DGV8";
		this.DGV8.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		this.DGV8.RowHeadersVisible = false;
		this.DGV8.ScrollBars = System.Windows.Forms.ScrollBars.None;
		this.DGV8.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGV8.Size = new System.Drawing.Size(352, 75);
		this.DGV8.TabIndex = 20;
		this.DataGridViewTextBoxColumn8.HeaderText = "Property";
		this.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8";
		this.DataGridViewTextBoxColumn8.ReadOnly = true;
		this.DataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.DataGridViewComboBoxColumn7.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
		this.DataGridViewComboBoxColumn7.DisplayStyleForCurrentCellOnly = true;
		this.DataGridViewComboBoxColumn7.FlatStyle = System.Windows.Forms.FlatStyle.System;
		this.DataGridViewComboBoxColumn7.HeaderText = "value";
		this.DataGridViewComboBoxColumn7.Name = "DataGridViewComboBoxColumn7";
		this.DataGridViewComboBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		this.Label9.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
		this.Label9.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label9.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label9.Location = new System.Drawing.Point(0, 833);
		this.Label9.Name = "Label9";
		this.Label9.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
		this.Label9.Size = new System.Drawing.Size(352, 24);
		this.Label9.TabIndex = 19;
		this.Label9.Text = "Activity status";
		this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.DGV7.AllowUserToAddRows = false;
		this.DGV7.AllowUserToDeleteRows = false;
		this.DGV7.AllowUserToResizeColumns = false;
		this.DGV7.AllowUserToResizeRows = false;
		this.DGV7.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.DGV7.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DGV7.BackgroundColor = System.Drawing.Color.Black;
		this.DGV7.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.DGV7.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
		this.DGV7.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle5.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGV7.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
		this.DGV7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		this.DGV7.ColumnHeadersVisible = false;
		this.DGV7.Columns.AddRange(this.DataGridViewTextBoxColumn7, this.DataGridViewComboBoxColumn6);
		dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(51, 153, 255);
		dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
		dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.DGV7.DefaultCellStyle = dataGridViewCellStyle6;
		this.DGV7.Dock = System.Windows.Forms.DockStyle.Top;
		this.DGV7.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
		this.DGV7.EnableHeadersVisualStyles = false;
		this.DGV7.GridColor = System.Drawing.Color.FromArgb(42, 42, 42);
		this.DGV7.Location = new System.Drawing.Point(0, 758);
		this.DGV7.Name = "DGV7";
		this.DGV7.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		this.DGV7.RowHeadersVisible = false;
		this.DGV7.ScrollBars = System.Windows.Forms.ScrollBars.None;
		this.DGV7.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGV7.Size = new System.Drawing.Size(352, 75);
		this.DGV7.TabIndex = 18;
		this.DataGridViewTextBoxColumn7.HeaderText = "Property";
		this.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7";
		this.DataGridViewTextBoxColumn7.ReadOnly = true;
		this.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.DataGridViewComboBoxColumn6.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
		this.DataGridViewComboBoxColumn6.DisplayStyleForCurrentCellOnly = true;
		this.DataGridViewComboBoxColumn6.FlatStyle = System.Windows.Forms.FlatStyle.System;
		this.DataGridViewComboBoxColumn6.HeaderText = "value";
		this.DataGridViewComboBoxColumn6.Name = "DataGridViewComboBoxColumn6";
		this.DataGridViewComboBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		this.Label8.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
		this.Label8.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label8.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label8.Location = new System.Drawing.Point(0, 734);
		this.Label8.Name = "Label8";
		this.Label8.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
		this.Label8.Size = new System.Drawing.Size(352, 24);
		this.Label8.TabIndex = 17;
		this.Label8.Text = "Flags";
		this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.DGV6.AllowUserToAddRows = false;
		this.DGV6.AllowUserToDeleteRows = false;
		this.DGV6.AllowUserToResizeColumns = false;
		this.DGV6.AllowUserToResizeRows = false;
		this.DGV6.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.DGV6.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DGV6.BackgroundColor = System.Drawing.Color.Black;
		this.DGV6.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.DGV6.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
		this.DGV6.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle7.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGV6.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
		this.DGV6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		this.DGV6.ColumnHeadersVisible = false;
		this.DGV6.Columns.AddRange(this.DataGridViewTextBoxColumn6, this.DataGridViewComboBoxColumn5);
		dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle8.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(51, 153, 255);
		dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
		dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.DGV6.DefaultCellStyle = dataGridViewCellStyle8;
		this.DGV6.Dock = System.Windows.Forms.DockStyle.Top;
		this.DGV6.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
		this.DGV6.EnableHeadersVisualStyles = false;
		this.DGV6.GridColor = System.Drawing.Color.FromArgb(42, 42, 42);
		this.DGV6.Location = new System.Drawing.Point(0, 659);
		this.DGV6.Name = "DGV6";
		this.DGV6.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		this.DGV6.RowHeadersVisible = false;
		this.DGV6.ScrollBars = System.Windows.Forms.ScrollBars.None;
		this.DGV6.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGV6.Size = new System.Drawing.Size(352, 75);
		this.DGV6.TabIndex = 16;
		this.DataGridViewTextBoxColumn6.HeaderText = "Property";
		this.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6";
		this.DataGridViewTextBoxColumn6.ReadOnly = true;
		this.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.DataGridViewComboBoxColumn5.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
		this.DataGridViewComboBoxColumn5.DisplayStyleForCurrentCellOnly = true;
		this.DataGridViewComboBoxColumn5.FlatStyle = System.Windows.Forms.FlatStyle.System;
		this.DataGridViewComboBoxColumn5.HeaderText = "value";
		this.DataGridViewComboBoxColumn5.Name = "DataGridViewComboBoxColumn5";
		this.DataGridViewComboBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		this.Label7.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
		this.Label7.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label7.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label7.Location = new System.Drawing.Point(0, 635);
		this.Label7.Name = "Label7";
		this.Label7.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
		this.Label7.Size = new System.Drawing.Size(352, 24);
		this.Label7.TabIndex = 15;
		this.Label7.Text = "Font";
		this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.DGV5.AllowUserToAddRows = false;
		this.DGV5.AllowUserToDeleteRows = false;
		this.DGV5.AllowUserToResizeColumns = false;
		this.DGV5.AllowUserToResizeRows = false;
		this.DGV5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.DGV5.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DGV5.BackgroundColor = System.Drawing.Color.Black;
		this.DGV5.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.DGV5.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
		this.DGV5.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle9.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle9.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGV5.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
		this.DGV5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		this.DGV5.ColumnHeadersVisible = false;
		this.DGV5.Columns.AddRange(this.DataGridViewTextBoxColumn5, this.Column3);
		dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle10.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle10.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle10.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(51, 153, 255);
		dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
		dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.DGV5.DefaultCellStyle = dataGridViewCellStyle10;
		this.DGV5.Dock = System.Windows.Forms.DockStyle.Top;
		this.DGV5.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
		this.DGV5.EnableHeadersVisualStyles = false;
		this.DGV5.GridColor = System.Drawing.Color.FromArgb(42, 42, 42);
		this.DGV5.Location = new System.Drawing.Point(0, 560);
		this.DGV5.Name = "DGV5";
		this.DGV5.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		this.DGV5.RowHeadersVisible = false;
		this.DGV5.ScrollBars = System.Windows.Forms.ScrollBars.None;
		this.DGV5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGV5.Size = new System.Drawing.Size(352, 75);
		this.DGV5.TabIndex = 14;
		this.DataGridViewTextBoxColumn5.FillWeight = 178.6802f;
		this.DataGridViewTextBoxColumn5.HeaderText = "Property";
		this.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
		this.DataGridViewTextBoxColumn5.ReadOnly = true;
		this.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
		dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle11.NullValue = System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(resources.GetObject("DataGridViewCellStyle10.NullValue"));
		this.Column3.DefaultCellStyle = dataGridViewCellStyle11;
		this.Column3.FillWeight = 21f;
		this.Column3.HeaderText = "value";
		this.Column3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
		this.Column3.Name = "Column3";
		this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
		this.Column3.Width = 5;
		this.Label6.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
		this.Label6.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label6.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label6.Location = new System.Drawing.Point(0, 536);
		this.Label6.Name = "Label6";
		this.Label6.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
		this.Label6.Size = new System.Drawing.Size(352, 24);
		this.Label6.TabIndex = 13;
		this.Label6.Text = "Colors";
		this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.DGV4.AllowUserToAddRows = false;
		this.DGV4.AllowUserToDeleteRows = false;
		this.DGV4.AllowUserToResizeColumns = false;
		this.DGV4.AllowUserToResizeRows = false;
		this.DGV4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.DGV4.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DGV4.BackgroundColor = System.Drawing.Color.Black;
		this.DGV4.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.DGV4.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
		this.DGV4.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle12.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle12.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle12.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGV4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
		this.DGV4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		this.DGV4.ColumnHeadersVisible = false;
		this.DGV4.Columns.AddRange(this.DataGridViewTextBoxColumn4, this.DataGridViewComboBoxColumn4);
		dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle13.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle13.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle13.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(51, 153, 255);
		dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
		dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.DGV4.DefaultCellStyle = dataGridViewCellStyle13;
		this.DGV4.Dock = System.Windows.Forms.DockStyle.Top;
		this.DGV4.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
		this.DGV4.EnableHeadersVisualStyles = false;
		this.DGV4.GridColor = System.Drawing.Color.FromArgb(42, 42, 42);
		this.DGV4.Location = new System.Drawing.Point(0, 461);
		this.DGV4.Name = "DGV4";
		this.DGV4.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		this.DGV4.RowHeadersVisible = false;
		this.DGV4.ScrollBars = System.Windows.Forms.ScrollBars.None;
		this.DGV4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGV4.Size = new System.Drawing.Size(352, 75);
		this.DGV4.TabIndex = 12;
		this.DataGridViewTextBoxColumn4.HeaderText = "Property";
		this.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
		this.DataGridViewTextBoxColumn4.ReadOnly = true;
		this.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.DataGridViewComboBoxColumn4.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
		this.DataGridViewComboBoxColumn4.DisplayStyleForCurrentCellOnly = true;
		this.DataGridViewComboBoxColumn4.FlatStyle = System.Windows.Forms.FlatStyle.System;
		this.DataGridViewComboBoxColumn4.HeaderText = "value";
		this.DataGridViewComboBoxColumn4.Name = "DataGridViewComboBoxColumn4";
		this.DataGridViewComboBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		this.Label5.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
		this.Label5.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label5.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label5.Location = new System.Drawing.Point(0, 437);
		this.Label5.Name = "Label5";
		this.Label5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
		this.Label5.Size = new System.Drawing.Size(352, 24);
		this.Label5.TabIndex = 11;
		this.Label5.Text = "Saving data";
		this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.DGV3.AllowUserToAddRows = false;
		this.DGV3.AllowUserToDeleteRows = false;
		this.DGV3.AllowUserToResizeColumns = false;
		this.DGV3.AllowUserToResizeRows = false;
		this.DGV3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.DGV3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DGV3.BackgroundColor = System.Drawing.Color.Black;
		this.DGV3.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.DGV3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
		this.DGV3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle14.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle14.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle14.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGV3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
		this.DGV3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		this.DGV3.ColumnHeadersVisible = false;
		this.DGV3.Columns.AddRange(this.DataGridViewTextBoxColumn3, this.DataGridViewComboBoxColumn3);
		dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle15.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle15.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle15.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(51, 153, 255);
		dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
		dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.DGV3.DefaultCellStyle = dataGridViewCellStyle15;
		this.DGV3.Dock = System.Windows.Forms.DockStyle.Top;
		this.DGV3.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
		this.DGV3.EnableHeadersVisualStyles = false;
		this.DGV3.GridColor = System.Drawing.Color.FromArgb(42, 42, 42);
		this.DGV3.Location = new System.Drawing.Point(0, 362);
		this.DGV3.Name = "DGV3";
		this.DGV3.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		this.DGV3.RowHeadersVisible = false;
		this.DGV3.ScrollBars = System.Windows.Forms.ScrollBars.None;
		this.DGV3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGV3.Size = new System.Drawing.Size(352, 75);
		this.DGV3.TabIndex = 10;
		this.DataGridViewTextBoxColumn3.HeaderText = "Property";
		this.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
		this.DataGridViewTextBoxColumn3.ReadOnly = true;
		this.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.DataGridViewComboBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
		this.DataGridViewComboBoxColumn3.DisplayStyleForCurrentCellOnly = true;
		this.DataGridViewComboBoxColumn3.FlatStyle = System.Windows.Forms.FlatStyle.System;
		this.DataGridViewComboBoxColumn3.HeaderText = "value";
		this.DataGridViewComboBoxColumn3.Name = "DataGridViewComboBoxColumn3";
		this.DataGridViewComboBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		this.Label4.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
		this.Label4.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label4.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label4.Location = new System.Drawing.Point(0, 338);
		this.Label4.Name = "Label4";
		this.Label4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
		this.Label4.Size = new System.Drawing.Size(352, 24);
		this.Label4.TabIndex = 9;
		this.Label4.Text = "Location Manager";
		this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.DGV2.AllowUserToAddRows = false;
		this.DGV2.AllowUserToDeleteRows = false;
		this.DGV2.AllowUserToResizeColumns = false;
		this.DGV2.AllowUserToResizeRows = false;
		this.DGV2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.DGV2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DGV2.BackgroundColor = System.Drawing.Color.Black;
		this.DGV2.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.DGV2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
		this.DGV2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle16.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle16.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle16.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGV2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
		this.DGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		this.DGV2.ColumnHeadersVisible = false;
		this.DGV2.Columns.AddRange(this.DataGridViewTextBoxColumn2, this.DataGridViewComboBoxColumn2);
		dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle17.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle17.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle17.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(51, 153, 255);
		dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
		dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.DGV2.DefaultCellStyle = dataGridViewCellStyle17;
		this.DGV2.Dock = System.Windows.Forms.DockStyle.Top;
		this.DGV2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
		this.DGV2.EnableHeadersVisualStyles = false;
		this.DGV2.GridColor = System.Drawing.Color.FromArgb(42, 42, 42);
		this.DGV2.Location = new System.Drawing.Point(0, 263);
		this.DGV2.Name = "DGV2";
		this.DGV2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		this.DGV2.RowHeadersVisible = false;
		this.DGV2.ScrollBars = System.Windows.Forms.ScrollBars.None;
		this.DGV2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGV2.Size = new System.Drawing.Size(352, 75);
		this.DGV2.TabIndex = 8;
		this.DataGridViewTextBoxColumn2.HeaderText = "Property";
		this.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
		this.DataGridViewTextBoxColumn2.ReadOnly = true;
		this.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.DataGridViewComboBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
		this.DataGridViewComboBoxColumn2.DisplayStyleForCurrentCellOnly = true;
		this.DataGridViewComboBoxColumn2.FlatStyle = System.Windows.Forms.FlatStyle.System;
		this.DataGridViewComboBoxColumn2.HeaderText = "value";
		this.DataGridViewComboBoxColumn2.Name = "DataGridViewComboBoxColumn2";
		this.DataGridViewComboBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		this.Label3.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
		this.Label3.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label3.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label3.Location = new System.Drawing.Point(0, 239);
		this.Label3.Name = "Label3";
		this.Label3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
		this.Label3.Size = new System.Drawing.Size(352, 24);
		this.Label3.TabIndex = 7;
		this.Label3.Text = "Camera Manager";
		this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.DGV1.AllowUserToAddRows = false;
		this.DGV1.AllowUserToDeleteRows = false;
		this.DGV1.AllowUserToResizeColumns = false;
		this.DGV1.AllowUserToResizeRows = false;
		this.DGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.DGV1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DGV1.BackgroundColor = System.Drawing.Color.Black;
		this.DGV1.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.DGV1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
		this.DGV1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle18.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle18.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
		dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGV1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
		this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		this.DGV1.ColumnHeadersVisible = false;
		this.DGV1.Columns.AddRange(this.DataGridViewTextBoxColumn1, this.DataGridViewComboBoxColumn1);
		dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle19.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle19.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle19.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(51, 153, 255);
		dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
		dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.DGV1.DefaultCellStyle = dataGridViewCellStyle19;
		this.DGV1.Dock = System.Windows.Forms.DockStyle.Top;
		this.DGV1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
		this.DGV1.EnableHeadersVisualStyles = false;
		this.DGV1.GridColor = System.Drawing.Color.FromArgb(42, 42, 42);
		this.DGV1.Location = new System.Drawing.Point(0, 164);
		this.DGV1.Name = "DGV1";
		this.DGV1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		this.DGV1.RowHeadersVisible = false;
		this.DGV1.ScrollBars = System.Windows.Forms.ScrollBars.None;
		this.DGV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGV1.Size = new System.Drawing.Size(352, 75);
		this.DGV1.TabIndex = 6;
		this.DataGridViewTextBoxColumn1.HeaderText = "Property";
		this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
		this.DataGridViewTextBoxColumn1.ReadOnly = true;
		this.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.DataGridViewComboBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
		this.DataGridViewComboBoxColumn1.DisplayStyleForCurrentCellOnly = true;
		this.DataGridViewComboBoxColumn1.FlatStyle = System.Windows.Forms.FlatStyle.System;
		this.DataGridViewComboBoxColumn1.HeaderText = "value";
		this.DataGridViewComboBoxColumn1.Name = "DataGridViewComboBoxColumn1";
		this.DataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		this.Label2.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
		this.Label2.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label2.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label2.Location = new System.Drawing.Point(0, 140);
		this.Label2.Name = "Label2";
		this.Label2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
		this.Label2.Size = new System.Drawing.Size(352, 24);
		this.Label2.TabIndex = 5;
		this.Label2.Text = "Alert";
		this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.DGV0.AllowUserToAddRows = false;
		this.DGV0.AllowUserToDeleteRows = false;
		this.DGV0.AllowUserToResizeColumns = false;
		this.DGV0.AllowUserToResizeRows = false;
		this.DGV0.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.DGV0.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DGV0.BackgroundColor = System.Drawing.Color.Black;
		this.DGV0.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.DGV0.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
		this.DGV0.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle20.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle20.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle20.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DGV0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
		this.DGV0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.DGV0.ColumnHeadersVisible = false;
		this.DGV0.Columns.AddRange(this.Column1, this.Column2);
		dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle21.BackColor = System.Drawing.Color.Black;
		dataGridViewCellStyle21.Font = new System.Drawing.Font("Calibri", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle21.ForeColor = System.Drawing.Color.SkyBlue;
		dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(51, 153, 255);
		dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
		dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.DGV0.DefaultCellStyle = dataGridViewCellStyle21;
		this.DGV0.Dock = System.Windows.Forms.DockStyle.Top;
		this.DGV0.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
		this.DGV0.EnableHeadersVisualStyles = false;
		this.DGV0.GridColor = System.Drawing.Color.FromArgb(42, 42, 42);
		this.DGV0.Location = new System.Drawing.Point(0, 24);
		this.DGV0.Name = "DGV0";
		this.DGV0.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		this.DGV0.RowHeadersVisible = false;
		this.DGV0.ScrollBars = System.Windows.Forms.ScrollBars.None;
		this.DGV0.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGV0.Size = new System.Drawing.Size(352, 116);
		this.DGV0.TabIndex = 4;
		this.Column1.HeaderText = "Property";
		this.Column1.Name = "Column1";
		this.Column1.ReadOnly = true;
		this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.Column2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
		this.Column2.DisplayStyleForCurrentCellOnly = true;
		this.Column2.FlatStyle = System.Windows.Forms.FlatStyle.System;
		this.Column2.HeaderText = "value";
		this.Column2.Name = "Column2";
		this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		this.Label1.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
		this.Label1.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label1.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label1.Location = new System.Drawing.Point(0, 0);
		this.Label1.Name = "Label1";
		this.Label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
		this.Label1.Size = new System.Drawing.Size(352, 24);
		this.Label1.TabIndex = 0;
		this.Label1.Text = "Socket";
		this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.SV.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.SV.BackColor = System.Drawing.Color.FromArgb(190, 190, 190);
		this.SV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.SV.ForeColor = System.Drawing.Color.Black;
		this.SV.Location = new System.Drawing.Point(285, 8);
		this.SV.Name = "SV";
		this.SV.Size = new System.Drawing.Size(81, 23);
		this.SV.TabIndex = 14;
		this.SV.Text = "Save";
		this.SV.UseVisualStyleBackColor = false;
		this.DL.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.DL.BackColor = System.Drawing.Color.FromArgb(190, 190, 190);
		this.DL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.DL.ForeColor = System.Drawing.Color.Black;
		this.DL.Location = new System.Drawing.Point(198, 8);
		this.DL.Name = "DL";
		this.DL.Size = new System.Drawing.Size(81, 23);
		this.DL.TabIndex = 15;
		this.DL.Text = "Reset";
		this.DL.UseVisualStyleBackColor = false;
		this.Panel2.BackColor = System.Drawing.Color.Black;
		this.Panel2.Controls.Add(this.SV);
		this.Panel2.Controls.Add(this.DL);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel2.Location = new System.Drawing.Point(0, 354);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new System.Drawing.Size(369, 34);
		this.Panel2.TabIndex = 16;
		this.TOpacity.Interval = 1;
		this.ctxPacket.Items.AddRange(new System.Windows.Forms.ToolStripItem[10] { this.DefaultToolStripMenuItem, this.clr_1, this.clr_2, this.Clr3ToolStripMenuItem, this.Clr4ToolStripMenuItem, this.Clr5ToolStripMenuItem, this.Clr6ToolStripMenuItem, this.Clr7ToolStripMenuItem, this.Clr8ToolStripMenuItem, this.Clr9ToolStripMenuItem });
		this.ctxPacket.Name = "ctxPacket";
		this.ctxPacket.ShowImageMargin = false;
		this.ctxPacket.Size = new System.Drawing.Size(144, 224);
		this.DefaultToolStripMenuItem.Name = "DefaultToolStripMenuItem";
		this.DefaultToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
		this.DefaultToolStripMenuItem.Text = "Dove Gray";
		this.clr_1.Name = "clr_1";
		this.clr_1.Size = new System.Drawing.Size(143, 22);
		this.clr_1.Text = "Curious Blue";
		this.clr_2.Name = "clr_2";
		this.clr_2.Size = new System.Drawing.Size(143, 22);
		this.clr_2.Text = "Keppel";
		this.Clr3ToolStripMenuItem.Name = "Clr3ToolStripMenuItem";
		this.Clr3ToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
		this.Clr3ToolStripMenuItem.Text = "Pickled Bluewood";
		this.Clr4ToolStripMenuItem.Name = "Clr4ToolStripMenuItem";
		this.Clr4ToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
		this.Clr4ToolStripMenuItem.Text = "Cerise";
		this.Clr5ToolStripMenuItem.Name = "Clr5ToolStripMenuItem";
		this.Clr5ToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
		this.Clr5ToolStripMenuItem.Text = "Mine Shaft";
		this.Clr6ToolStripMenuItem.Name = "Clr6ToolStripMenuItem";
		this.Clr6ToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
		this.Clr6ToolStripMenuItem.Text = "Lochmara";
		this.Clr7ToolStripMenuItem.Name = "Clr7ToolStripMenuItem";
		this.Clr7ToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
		this.Clr7ToolStripMenuItem.Text = "Steel Gray";
		this.Clr8ToolStripMenuItem.Name = "Clr8ToolStripMenuItem";
		this.Clr8ToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
		this.Clr8ToolStripMenuItem.Text = "Scorpion";
		this.Clr9ToolStripMenuItem.Name = "Clr9ToolStripMenuItem";
		this.Clr9ToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
		this.Clr9ToolStripMenuItem.Text = "Rob Roy";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(369, 388);
		base.Controls.Add(this.Panel1);
		base.Controls.Add(this.Panel2);
		base.Name = "Settings";
		base.Opacity = 0.0;
		this.Text = "Settings";
		this.Panel1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.DGV9).EndInit();
		((System.ComponentModel.ISupportInitialize)this.DGV8).EndInit();
		((System.ComponentModel.ISupportInitialize)this.DGV7).EndInit();
		((System.ComponentModel.ISupportInitialize)this.DGV6).EndInit();
		((System.ComponentModel.ISupportInitialize)this.DGV5).EndInit();
		((System.ComponentModel.ISupportInitialize)this.DGV4).EndInit();
		((System.ComponentModel.ISupportInitialize)this.DGV3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.DGV2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.DGV1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.DGV0).EndInit();
		this.Panel2.ResumeLayout(false);
		this.ctxPacket.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	public Settings()
	{
		base.Load += Settings_Load;
		InitializeComponent();
		Font = reso.f;
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

	private void SpyStyle()
	{
		foreach (DataGridView item in Panel1.Controls.OfType<DataGridView>())
		{
			item.BackgroundColor = SpySettings.DefaultColor_Background;
			item.BackColor = SpySettings.DefaultColor_Background;
			item.ColumnHeadersDefaultCellStyle.BackColor = SpySettings.DefaultColor_Background;
			item.DefaultCellStyle.BackColor = SpySettings.DefaultColor_Background;
			item.DefaultCellStyle.SelectionForeColor = SpySettings.DefaultColor_Background;
			item.DefaultCellStyle.ForeColor = SpySettings.DefaultColor_Foreground;
			item.DefaultCellStyle.SelectionBackColor = SpySettings.DefaultColor_Foreground;
			item.ColumnHeadersDefaultCellStyle.ForeColor = SpySettings.DefaultColor_Foreground;
			item.CellBorderStyle = DataGridViewCellBorderStyle.Single;
			item.GridColor = SpySettings.DefaultColor_Foreground;
			item.BorderStyle = BorderStyle.None;
			item.ColumnHeadersVisible = false;
			item.EnableHeadersVisualStyles = false;
			item.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			item.RowHeadersVisible = false;
			item.SelectionMode = DataGridViewSelectionMode.CellSelect;
			item.MultiSelect = false;
		}
		foreach (Label item2 in Panel1.Controls.OfType<Label>())
		{
			item2.BackColor = SpySettings.DefaultColor_Background;
			item2.ForeColor = SpySettings.DefaultColor_ColorTitles;
		}
		foreach (Button item3 in Panel2.Controls.OfType<Button>())
		{
			item3.BackColor = SpySettings.DefaultColor_Foreground;
			item3.ForeColor = SpySettings.DefaultColor_Background;
		}
		foreach (Panel item4 in base.Controls.OfType<Panel>())
		{
			item4.BackColor = SpySettings.DefaultColor_Background;
			item4.ForeColor = SpySettings.DefaultColor_Foreground;
		}
	}

	private void grreSize()
	{
		checked
		{
			foreach (DataGridView item in Panel1.Controls.OfType<DataGridView>())
			{
				int num = item.Rows.Count * item.Rows[0].Height;
				item.Height = num + 5;
			}
		}
	}

	private void Settings_Load(object sender, EventArgs e)
	{
		base.Icon = Resources.max;
		SpyStyle();
		R();
		grreSize();
		DGV5.ContextMenuStrip = ctxPacket;
		TOpacity.Interval = SpySettings.T_Interval;
		TOpacity.Enabled = true;
	}

	private void R()
	{
		List<string> list = new List<string>();
		int index = DGV0.Rows.Add("Performance", null);
		DataGridViewComboBoxCell dataGridViewComboBoxCell = (DataGridViewComboBoxCell)DGV0.Rows[index].Cells[1];
		list.Add("High");
		list.Add("Normal");
		list.Add("Low");
		dataGridViewComboBoxCell.DataSource = list;
		dataGridViewComboBoxCell.Value = list[list.IndexOf(MySettingsProperty.Settings.performance)];
		list = new List<string>();
		index = DGV0.Rows.Add("Encoding", null);
		DataGridViewComboBoxCell dataGridViewComboBoxCell2 = (DataGridViewComboBoxCell)DGV0.Rows[index].Cells[1];
		list.Add("Default");
		list.Add("UTF8");
		list.Add("UTF32");
		list.Add("ASCII");
		dataGridViewComboBoxCell2.DataSource = list;
		dataGridViewComboBoxCell2.Value = list[list.IndexOf(MySettingsProperty.Settings.encoding8)];
		list = new List<string>();
		index = DGV0.Rows.Add("Disconnected", null);
		DataGridViewComboBoxCell dataGridViewComboBoxCell3 = (DataGridViewComboBoxCell)DGV0.Rows[index].Cells[1];
		list.Add("Close windows");
		list.Add("Just tell me");
		dataGridViewComboBoxCell3.DataSource = list;
		dataGridViewComboBoxCell3.Value = list[list.IndexOf(MySettingsProperty.Settings.disconnected)];
		list = new List<string>();
		index = DGV0.Rows.Add("Removing Duplicates", null);
		DataGridViewComboBoxCell dataGridViewComboBoxCell4 = (DataGridViewComboBoxCell)DGV0.Rows[index].Cells[1];
		list.Add("Yes");
		list.Add("No");
		dataGridViewComboBoxCell4.DataSource = list;
		dataGridViewComboBoxCell4.Value = list[list.IndexOf(MySettingsProperty.Settings.Removing_Duplicates)];
		list = new List<string>();
		index = DGV1.Rows.Add("Show Alert", null);
		DataGridViewComboBoxCell dataGridViewComboBoxCell5 = (DataGridViewComboBoxCell)DGV1.Rows[index].Cells[1];
		list.Add("Yes");
		list.Add("No");
		dataGridViewComboBoxCell5.DataSource = list;
		dataGridViewComboBoxCell5.Value = list[list.IndexOf(MySettingsProperty.Settings.show_alert)];
		list = new List<string>();
		index = DGV1.Rows.Add("Location", null);
		DataGridViewComboBoxCell dataGridViewComboBoxCell6 = (DataGridViewComboBoxCell)DGV1.Rows[index].Cells[1];
		list.Add("Right");
		list.Add("Left");
		dataGridViewComboBoxCell6.DataSource = list;
		dataGridViewComboBoxCell6.Value = list[list.IndexOf(MySettingsProperty.Settings.location)];
		list = new List<string>();
		index = DGV1.Rows.Add("Play Sound", null);
		DataGridViewComboBoxCell dataGridViewComboBoxCell7 = (DataGridViewComboBoxCell)DGV1.Rows[index].Cells[1];
		list.Add("Yes");
		list.Add("No");
		dataGridViewComboBoxCell7.DataSource = list;
		dataGridViewComboBoxCell7.Value = list[list.IndexOf(MySettingsProperty.Settings.NOTI_SOUND ? "Yes" : "No")];
		list = new List<string>();
		index = DGV1.Rows.Add("Multi-Sounds", null);
		DataGridViewComboBoxCell dataGridViewComboBoxCell8 = (DataGridViewComboBoxCell)DGV1.Rows[index].Cells[1];
		list.Add("Yes");
		list.Add("No");
		dataGridViewComboBoxCell8.DataSource = list;
		dataGridViewComboBoxCell8.Value = list[list.IndexOf(MySettingsProperty.Settings._multi_sounds)];
		list = new List<string>();
		index = DGV1.Rows.Add("Round", null);
		DataGridViewComboBoxCell dataGridViewComboBoxCell9 = (DataGridViewComboBoxCell)DGV1.Rows[index].Cells[1];
		list.Add("Yes");
		list.Add("No");
		dataGridViewComboBoxCell9.DataSource = list;
		dataGridViewComboBoxCell9.Value = list[list.IndexOf(MySettingsProperty.Settings.Round)];
		list = new List<string>();
		index = DGV2.Rows.Add("Auto focus", null);
		DataGridViewComboBoxCell dataGridViewComboBoxCell10 = (DataGridViewComboBoxCell)DGV2.Rows[index].Cells[1];
		list.Add("Yes");
		list.Add("No");
		dataGridViewComboBoxCell10.DataSource = list;
		dataGridViewComboBoxCell10.Value = list[list.IndexOf(MySettingsProperty.Settings.Auto_focus)];
		list = new List<string>();
		index = DGV2.Rows.Add("Effects", null);
		DataGridViewComboBoxCell dataGridViewComboBoxCell11 = (DataGridViewComboBoxCell)DGV2.Rows[index].Cells[1];
		list.Add("Normal");
		list.Add("Gray");
		list.Add("Raw-01");
		list.Add("Raw-02");
		dataGridViewComboBoxCell11.DataSource = list;
		dataGridViewComboBoxCell11.Value = list[list.IndexOf(MySettingsProperty.Settings.Effects_CAM)];
		list = new List<string>();
		index = DGV2.Rows.Add("Quality", null);
		DataGridViewComboBoxCell dataGridViewComboBoxCell12 = (DataGridViewComboBoxCell)DGV2.Rows[index].Cells[1];
		list.Add("Auto");
		list.Add("high quality");
		dataGridViewComboBoxCell12.DataSource = list;
		dataGridViewComboBoxCell12.Value = list[list.IndexOf(MySettingsProperty.Settings.CAMQuality)];
		list = new List<string>();
		index = DGV3.Rows.Add("Style", null);
		DataGridViewComboBoxCell dataGridViewComboBoxCell13 = (DataGridViewComboBoxCell)DGV3.Rows[index].Cells[1];
		list.Add("Navigation_Preview_Day");
		list.Add("Dark");
		list.Add("Basic_Template");
		list.Add("Streets");
		list.Add("Le_Shine");
		list.Add("Ice_Cream");
		list.Add("Navigation_Preview_Night");
		list.Add("Moonlight");
		list.Add("Decimal");
		dataGridViewComboBoxCell13.DataSource = list;
		dataGridViewComboBoxCell13.Value = list[list.IndexOf(MySettingsProperty.Settings.Style_Maps)];
		list = new List<string>();
		index = DGV4.Rows.Add("Auto save", null);
		DataGridViewComboBoxCell dataGridViewComboBoxCell14 = (DataGridViewComboBoxCell)DGV4.Rows[index].Cells[1];
		list.Add("Yes");
		list.Add("No");
		dataGridViewComboBoxCell14.DataSource = list;
		dataGridViewComboBoxCell14.Value = list[list.IndexOf(MySettingsProperty.Settings.Saving_data)];
		Bitmap bitmap = new Bitmap(21, 17);
		Graphics graphics = Graphics.FromImage(bitmap);
		Color defaultColorForeground = MySettingsProperty.Settings.DefaultColorForeground;
		graphics.Clear(defaultColorForeground);
		Pen pen = new Pen(ControlPaint.Light(MySettingsProperty.Settings.DefaultColorForeground), 1f);
		checked
		{
			graphics.DrawRectangle(pen, 0, 0, bitmap.Width - 1, bitmap.Height - 1);
			index = DGV5.Rows.Add("Foreground", bitmap);
			DGV5.Rows[index].Tag = defaultColorForeground;
			graphics.Dispose();
			bitmap = new Bitmap(21, 17);
			graphics = Graphics.FromImage(bitmap);
			defaultColorForeground = MySettingsProperty.Settings.DefaultColorBackground;
			graphics.Clear(defaultColorForeground);
			pen = new Pen(ControlPaint.Light(MySettingsProperty.Settings.DefaultColorBackground), 1f);
			graphics.DrawRectangle(pen, 0, 0, bitmap.Width - 1, bitmap.Height - 1);
			index = DGV5.Rows.Add("Background", bitmap);
			DGV5.Rows[index].Tag = defaultColorForeground;
			graphics.Dispose();
			bitmap = new Bitmap(21, 17);
			graphics = Graphics.FromImage(bitmap);
			defaultColorForeground = MySettingsProperty.Settings.DefaultColor_ColorTitles;
			graphics.Clear(defaultColorForeground);
			pen = new Pen(ControlPaint.Light(MySettingsProperty.Settings.DefaultColor_ColorTitles), 1f);
			graphics.DrawRectangle(pen, 0, 0, bitmap.Width - 1, bitmap.Height - 1);
			index = DGV5.Rows.Add("Titles", bitmap);
			DGV5.Rows[index].Tag = defaultColorForeground;
			graphics.Dispose();
			bitmap = new Bitmap(21, 17);
			graphics = Graphics.FromImage(bitmap);
			defaultColorForeground = MySettingsProperty.Settings.DefaultColor_NewColorFiles;
			graphics.Clear(defaultColorForeground);
			pen = new Pen(ControlPaint.Light(MySettingsProperty.Settings.DefaultColor_NewColorFiles), 1f);
			graphics.DrawRectangle(pen, 0, 0, bitmap.Width - 1, bitmap.Height - 1);
			index = DGV5.Rows.Add("New Files", bitmap);
			DGV5.Rows[index].Tag = defaultColorForeground;
			graphics.Dispose();
			list = new List<string>();
			index = DGV6.Rows.Add("Size", null);
			DataGridViewComboBoxCell dataGridViewComboBoxCell15 = (DataGridViewComboBoxCell)DGV6.Rows[index].Cells[1];
			list.Add("8");
			list.Add("9");
			list.Add("10");
			list.Add("11");
			list.Add("12");
			dataGridViewComboBoxCell15.DataSource = list;
			dataGridViewComboBoxCell15.Value = list[list.IndexOf(Conversions.ToString(MySettingsProperty.Settings.FontSize))];
			list = new List<string>();
			index = DGV6.Rows.Add("Style", null);
			DataGridViewComboBoxCell dataGridViewComboBoxCell16 = (DataGridViewComboBoxCell)DGV6.Rows[index].Cells[1];
			list.Add("Bold");
			list.Add("Regular");
			dataGridViewComboBoxCell16.DataSource = list;
			dataGridViewComboBoxCell16.Value = list[list.IndexOf(MySettingsProperty.Settings.FontStyle)];
			list = new List<string>();
			index = DGV7.Rows.Add("Visible", null);
			DataGridViewComboBoxCell dataGridViewComboBoxCell17 = (DataGridViewComboBoxCell)DGV7.Rows[index].Cells[1];
			list.Add("Yes");
			list.Add("No");
			dataGridViewComboBoxCell17.DataSource = list;
			dataGridViewComboBoxCell17.Value = list[list.IndexOf(MySettingsProperty.Settings.Flags_Visible)];
			list = new List<string>();
			index = DGV7.Rows.Add("Size", null);
			DataGridViewComboBoxCell dataGridViewComboBoxCell18 = (DataGridViewComboBoxCell)DGV7.Rows[index].Cells[1];
			list.Add("16px");
			list.Add("24px");
			list.Add("32px");
			dataGridViewComboBoxCell18.DataSource = list;
			dataGridViewComboBoxCell18.Value = list[list.IndexOf(MySettingsProperty.Settings.Flags_Size)];
			list = new List<string>();
			index = DGV8.Rows.Add("Visible", null);
			DataGridViewComboBoxCell dataGridViewComboBoxCell19 = (DataGridViewComboBoxCell)DGV8.Rows[index].Cells[1];
			list.Add("Yes");
			list.Add("No");
			dataGridViewComboBoxCell19.DataSource = list;
			dataGridViewComboBoxCell19.Value = list[list.IndexOf(MySettingsProperty.Settings.SStatus_Visible)];
			list = new List<string>();
			index = DGV9.Rows.Add("Icon files size", null);
			DataGridViewComboBoxCell dataGridViewComboBoxCell20 = (DataGridViewComboBoxCell)DGV9.Rows[index].Cells[1];
			list.Add("Small");
			list.Add("Large");
			dataGridViewComboBoxCell20.DataSource = list;
			dataGridViewComboBoxCell20.Value = list[list.IndexOf(MySettingsProperty.Settings.FM_IC_Size)];
			DGV0.ClearSelection();
			DGV1.ClearSelection();
			DGV2.ClearSelection();
			DGV3.ClearSelection();
			DGV4.ClearSelection();
			DGV5.ClearSelection();
			DGV6.ClearSelection();
			DGV7.ClearSelection();
			DGV8.ClearSelection();
			DGV9.ClearSelection();
		}
	}

	private void SV_Click(object sender, EventArgs e)
	{
		int num = 0;
		checked
		{
			foreach (object item in (IEnumerable)DGV0.Rows)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(item);
				switch (num)
				{
				case 0:
					MySettingsProperty.Settings.performance = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Cells", new object[1] { 1 }, null, null, null), null, "Value", new object[0], null, null, null));
					break;
				case 1:
					MySettingsProperty.Settings.encoding8 = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Cells", new object[1] { 1 }, null, null, null), null, "Value", new object[0], null, null, null));
					break;
				case 2:
					MySettingsProperty.Settings.disconnected = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Cells", new object[1] { 1 }, null, null, null), null, "Value", new object[0], null, null, null));
					break;
				case 3:
					MySettingsProperty.Settings.Removing_Duplicates = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Cells", new object[1] { 1 }, null, null, null), null, "Value", new object[0], null, null, null));
					break;
				}
				num++;
			}
			num = 0;
			foreach (object item2 in (IEnumerable)DGV1.Rows)
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(item2);
				switch (num)
				{
				case 0:
					MySettingsProperty.Settings.show_alert = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue2, null, "Cells", new object[1] { 1 }, null, null, null), null, "Value", new object[0], null, null, null));
					break;
				case 1:
					MySettingsProperty.Settings.location = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue2, null, "Cells", new object[1] { 1 }, null, null, null), null, "Value", new object[0], null, null, null));
					break;
				case 2:
					MySettingsProperty.Settings.NOTI_SOUND = (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue2, null, "Cells", new object[1] { 1 }, null, null, null), null, "Value", new object[0], null, null, null), "Yes", TextCompare: false) ? true : false);
					break;
				case 3:
					MySettingsProperty.Settings._multi_sounds = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue2, null, "Cells", new object[1] { 1 }, null, null, null), null, "Value", new object[0], null, null, null));
					break;
				case 4:
					MySettingsProperty.Settings.Round = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue2, null, "Cells", new object[1] { 1 }, null, null, null), null, "Value", new object[0], null, null, null));
					break;
				}
				num++;
			}
			num = 0;
			foreach (object item3 in (IEnumerable)DGV2.Rows)
			{
				object objectValue3 = RuntimeHelpers.GetObjectValue(item3);
				switch (num)
				{
				case 0:
					MySettingsProperty.Settings.Auto_focus = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Cells", new object[1] { 1 }, null, null, null), null, "Value", new object[0], null, null, null));
					break;
				case 1:
					MySettingsProperty.Settings.Effects_CAM = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Cells", new object[1] { 1 }, null, null, null), null, "Value", new object[0], null, null, null));
					break;
				case 2:
					MySettingsProperty.Settings.CAMQuality = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Cells", new object[1] { 1 }, null, null, null), null, "Value", new object[0], null, null, null));
					break;
				}
				num++;
			}
			num = 0;
			foreach (object item4 in (IEnumerable)DGV3.Rows)
			{
				object objectValue4 = RuntimeHelpers.GetObjectValue(item4);
				if (num == 0)
				{
					MySettingsProperty.Settings.Style_Maps = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue4, null, "Cells", new object[1] { 1 }, null, null, null), null, "Value", new object[0], null, null, null));
				}
				num++;
			}
			num = 0;
			foreach (object item5 in (IEnumerable)DGV4.Rows)
			{
				object objectValue5 = RuntimeHelpers.GetObjectValue(item5);
				if (num == 0)
				{
					MySettingsProperty.Settings.Saving_data = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue5, null, "Cells", new object[1] { 1 }, null, null, null), null, "Value", new object[0], null, null, null));
				}
				num++;
			}
			num = 0;
			foreach (object item6 in (IEnumerable)DGV5.Rows)
			{
				object objectValue6 = RuntimeHelpers.GetObjectValue(item6);
				switch (num)
				{
				case 0:
					MySettingsProperty.Settings.DefaultColorForeground = (Color)NewLateBinding.LateGet(objectValue6, null, "Tag", new object[0], null, null, null);
					break;
				case 1:
					MySettingsProperty.Settings.DefaultColorBackground = (Color)NewLateBinding.LateGet(objectValue6, null, "Tag", new object[0], null, null, null);
					break;
				case 2:
					MySettingsProperty.Settings.DefaultColor_ColorTitles = (Color)NewLateBinding.LateGet(objectValue6, null, "Tag", new object[0], null, null, null);
					break;
				case 3:
					MySettingsProperty.Settings.DefaultColor_NewColorFiles = (Color)NewLateBinding.LateGet(objectValue6, null, "Tag", new object[0], null, null, null);
					break;
				}
				num++;
			}
			num = 0;
			foreach (object item7 in (IEnumerable)DGV6.Rows)
			{
				object objectValue7 = RuntimeHelpers.GetObjectValue(item7);
				switch (num)
				{
				case 1:
					MySettingsProperty.Settings.FontStyle = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue7, null, "Cells", new object[1] { 1 }, null, null, null), null, "Value", new object[0], null, null, null));
					break;
				case 0:
					MySettingsProperty.Settings.FontSize = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue7, null, "Cells", new object[1] { 1 }, null, null, null), null, "Value", new object[0], null, null, null));
					break;
				}
				num++;
			}
			num = 0;
			foreach (object item8 in (IEnumerable)DGV7.Rows)
			{
				object objectValue8 = RuntimeHelpers.GetObjectValue(item8);
				switch (num)
				{
				case 1:
					MySettingsProperty.Settings.Flags_Size = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue8, null, "Cells", new object[1] { 1 }, null, null, null), null, "Value", new object[0], null, null, null));
					break;
				case 0:
					MySettingsProperty.Settings.Flags_Visible = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue8, null, "Cells", new object[1] { 1 }, null, null, null), null, "Value", new object[0], null, null, null));
					break;
				}
				num++;
			}
			num = 0;
			foreach (object item9 in (IEnumerable)DGV8.Rows)
			{
				object objectValue9 = RuntimeHelpers.GetObjectValue(item9);
				if (num == 0)
				{
					MySettingsProperty.Settings.SStatus_Visible = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue9, null, "Cells", new object[1] { 1 }, null, null, null), null, "Value", new object[0], null, null, null));
				}
				num++;
			}
			num = 0;
			foreach (object item10 in (IEnumerable)DGV9.Rows)
			{
				object objectValue10 = RuntimeHelpers.GetObjectValue(item10);
				if (num == 0)
				{
					MySettingsProperty.Settings.FM_IC_Size = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue10, null, "Cells", new object[1] { 1 }, null, null, null), null, "Value", new object[0], null, null, null));
				}
				num++;
			}
			MySettingsProperty.Settings.Save();
			Interaction.MsgBox("Saved Changes will be made after restarting the program", MsgBoxStyle.Information, reso.nameRAT);
			Close();
		}
	}

	private void DL_Click(object sender, EventArgs e)
	{
		MySettingsProperty.Settings.Reset();
		DGV0.Rows.Clear();
		DGV1.Rows.Clear();
		DGV2.Rows.Clear();
		DGV3.Rows.Clear();
		DGV4.Rows.Clear();
		DGV5.Rows.Clear();
		DGV6.Rows.Clear();
		DGV7.Rows.Clear();
		DGV8.Rows.Clear();
		DGV9.Rows.Clear();
		R();
	}

	private void ClearSEL(DataGridView DG0)
	{
		foreach (DataGridView item in Panel1.Controls.OfType<DataGridView>())
		{
			if (Operators.CompareString(item.Name, DG0.Name, TextCompare: false) != 0 && item.Rows.Count > 0)
			{
				item.CurrentCell = item.Rows[0].Cells[0];
				item.ClearSelection();
			}
		}
	}

	private void DGV0_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		ClearSEL(DGV0);
	}

	private void DGV1_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		ClearSEL(DGV1);
	}

	private void DGV2_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		ClearSEL(DGV2);
	}

	private void DGV3_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		ClearSEL(DGV3);
	}

	private void DGV4_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		ClearSEL(DGV4);
	}

	private void DGV5_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		ClearSEL(DGV5);
	}

	private void DGV6_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		ClearSEL(DGV6);
	}

	private void DGV7_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		ClearSEL(DGV7);
	}

	private void DGV8_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		ClearSEL(DGV8);
	}

	private void DGV9_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		ClearSEL(DGV9);
	}

	private void DGV5_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		checked
		{
			if (((e.RowIndex == 0) | (e.RowIndex == 1) | (e.RowIndex == 2) | (e.RowIndex == 3)) && e.ColumnIndex == 1)
			{
				Color_Box0 color_Box = new Color_Box0();
				if (color_Box.ShowDialog() == DialogResult.OK)
				{
					Bitmap bitmap = new Bitmap(21, 17);
					Graphics graphics = Graphics.FromImage(bitmap);
					Color backColor = color_Box.C_Box3.BackColor;
					graphics.Clear(backColor);
					Pen pen = new Pen(ControlPaint.Light(backColor), 1f);
					graphics.DrawRectangle(pen, 0, 0, bitmap.Width - 1, bitmap.Height - 1);
					DGV5.Rows[e.RowIndex].Tag = backColor;
					DGV5.Rows[e.RowIndex].Cells[1].Value = bitmap;
					graphics.Dispose();
				}
				color_Box.Close();
			}
		}
	}

	private void CrateColor(Color[] packet)
	{
		int num = 0;
		checked
		{
			foreach (object item in (IEnumerable)DGV5.Rows)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(item);
				DataGridViewRow dataGridViewRow = (DataGridViewRow)objectValue;
				Bitmap bitmap = new Bitmap(21, 17);
				Graphics graphics = Graphics.FromImage(bitmap);
				Color color = packet[num];
				graphics.Clear(color);
				Pen pen = new Pen(ControlPaint.Light(color), 1f);
				graphics.DrawRectangle(pen, 0, 0, bitmap.Width - 1, bitmap.Height - 1);
				dataGridViewRow.Tag = color;
				dataGridViewRow.Cells[1].Value = bitmap;
				graphics.Dispose();
				num++;
			}
		}
	}

	private void DGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void DefaultToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Color[] packet = new Color[4]
		{
			Color.FromArgb(106, 106, 106),
			Color.FromArgb(206, 206, 206),
			Color.FromArgb(70, 130, 180),
			Color.FromArgb(95, 158, 160)
		};
		CrateColor(packet);
	}

	private void clr_1ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Color[] packet = new Color[4]
		{
			Color.FromArgb(45, 156, 202),
			Color.FromArgb(37, 39, 77),
			Color.FromArgb(169, 171, 184),
			Color.FromArgb(159, 64, 103)
		};
		CrateColor(packet);
	}

	private void clr_2ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Color[] packet = new Color[4]
		{
			Color.FromArgb(55, 176, 169),
			Color.FromArgb(222, 242, 241),
			Color.FromArgb(43, 122, 119),
			Color.FromArgb(23, 36, 42)
		};
		CrateColor(packet);
	}

	private void Clr3ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Color[] packet = new Color[4]
		{
			Color.FromArgb(47, 68, 85),
			Color.FromArgb(220, 220, 220),
			Color.FromArgb(84, 102, 116),
			Color.FromArgb(218, 123, 147)
		};
		CrateColor(packet);
	}

	private void Clr4ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Color[] packet = new Color[4]
		{
			Color.FromArgb(217, 63, 135),
			Color.FromArgb(42, 27, 60),
			Color.FromArgb(130, 101, 167),
			Color.FromArgb(68, 49, 141)
		};
		CrateColor(packet);
	}

	private void Clr5ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Color[] packet = new Color[4]
		{
			Color.FromArgb(61, 61, 61),
			Color.FromArgb(222, 222, 222),
			Color.FromArgb(4, 94, 175),
			Color.FromArgb(30, 175, 4)
		};
		CrateColor(packet);
	}

	private void Clr6ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Color[] packet = new Color[4]
		{
			Color.FromArgb(0, 122, 204),
			Color.FromArgb(37, 37, 38),
			Color.FromArgb(241, 241, 241),
			Color.FromArgb(87, 116, 48)
		};
		CrateColor(packet);
	}

	private void Clr7ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Color[] packet = new Color[4]
		{
			Color.FromArgb(45, 40, 62),
			Color.FromArgb(208, 215, 225),
			Color.FromArgb(129, 43, 178),
			Color.FromArgb(158, 165, 172)
		};
		CrateColor(packet);
	}

	private void Clr8ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Color[] packet = new Color[4]
		{
			Color.FromArgb(94, 94, 94),
			Color.FromArgb(40, 40, 40),
			Color.FromArgb(198, 198, 198),
			Color.FromArgb(12, 159, 26)
		};
		CrateColor(packet);
	}

	private void Clr9ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Color[] packet = new Color[4]
		{
			Color.FromArgb(232, 191, 106),
			Color.FromArgb(43, 43, 43),
			Color.FromArgb(169, 183, 198),
			Color.FromArgb(75, 119, 81)
		};
		CrateColor(packet);
	}
}
