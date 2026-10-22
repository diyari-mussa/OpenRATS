using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using Newtonsoft.Json;

namespace BTMOB;

[DesignerGenerated]
public class AndroidViewer : Form
{
	[ComVisible(true)]
	public class mybridge
	{
		[CompilerGenerated]
		internal sealed class _Closure_0024__2_002D0
		{
			public string[] _0024VB_0024Local_lines;

			public mybridge _0024VB_0024Me;

			public _Closure_0024__2_002D0(_Closure_0024__2_002D0 arg0)
			{
				if (arg0 != null)
				{
					_0024VB_0024Local_lines = arg0._0024VB_0024Local_lines;
				}
			}

			[SpecialName]
			internal void _Lambda_0024__0()
			{
				_0024VB_0024Me.mainform.logtext.Text = "";
				string[] array = _0024VB_0024Local_lines;
				foreach (string text in array)
				{
					if (!string.IsNullOrWhiteSpace(text))
					{
						_0024VB_0024Me.mainform.logtext.AppendText(text + Environment.NewLine);
					}
				}
				_0024VB_0024Me.mainform.logtext.AppendText(Environment.NewLine);
			}
		}

		public AndroidViewer mainform;

		public mybridge(AndroidViewer minme)
		{
			mainform = minme;
		}

		[DispId(1)]
		public void printinfo(object json)
		{
			_Closure_0024__2_002D0 arg = default(_Closure_0024__2_002D0);
			_Closure_0024__2_002D0 CS_0024_003C_003E8__locals6 = new _Closure_0024__2_002D0(arg);
			CS_0024_003C_003E8__locals6._0024VB_0024Me = this;
			Dictionary<string, string> dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(Conversions.ToString(json));
			string text = dictionary["info"];
			CS_0024_003C_003E8__locals6._0024VB_0024Local_lines = text.Split(' ');
			mainform.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				CS_0024_003C_003E8__locals6._0024VB_0024Me.mainform.logtext.Text = "";
				string[] array = CS_0024_003C_003E8__locals6._0024VB_0024Local_lines;
				foreach (string text2 in array)
				{
					if (!string.IsNullOrWhiteSpace(text2))
					{
						CS_0024_003C_003E8__locals6._0024VB_0024Me.mainform.logtext.AppendText(text2 + Environment.NewLine);
					}
				}
				CS_0024_003C_003E8__locals6._0024VB_0024Me.mainform.logtext.AppendText(Environment.NewLine);
			}));
		}
	}

	private class VisualNode
	{
		public XmlNode XmlNode { get; set; }

		public int X { get; set; }

		public int Y { get; set; }

		public int Width { get; set; }

		public int Height { get; set; }

		public int Area => checked(Width * Height);
	}

	[CompilerGenerated]
	private sealed class VB_0024StateMachine_101_FetchAndRenderViewAsync : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncTaskMethodBuilder _0024Builder;

		internal AndroidViewer _0024VB_0024Me;

		internal string _0024VB_0024ResumableLocal_displayText_00240;

		internal string _0024VB_0024ResumableLocal_serial_00241;

		internal string _0024VB_0024ResumableLocal_dumpResult_00242;

		internal string _0024VB_0024ResumableLocal_pullResult_00243;

		internal string _0024VB_0024ResumableLocal_htmlFile_00244;

		[CompilerGenerated]
		internal void MoveNext()
		{
			int num = _0024State;
			try
			{
				if (_0024VB_0024Me.Combophones.SelectedItem == null)
				{
					BTAlerter.Warnings("No device selected.");
				}
				else
				{
					_0024VB_0024ResumableLocal_displayText_00240 = _0024VB_0024Me.Combophones.SelectedItem.ToString();
					_0024VB_0024ResumableLocal_serial_00241 = _0024VB_0024Me.deviceMap[_0024VB_0024ResumableLocal_displayText_00240];
					_0024VB_0024ResumableLocal_dumpResult_00242 = _0024VB_0024Me.RunCommand(MyRes.adb_Path, $"-s {_0024VB_0024ResumableLocal_serial_00241} shell uiautomator dump");
					Debuger.Log_d("Dump Result: ", _0024VB_0024ResumableLocal_dumpResult_00242);
					_0024VB_0024ResumableLocal_pullResult_00243 = _0024VB_0024Me.RunCommand(MyRes.adb_Path, $"-s {_0024VB_0024ResumableLocal_serial_00241} pull /storage/emulated/0/window_dump.xml dump.xml");
					Debuger.Log_d("Pull Result: ", _0024VB_0024ResumableLocal_pullResult_00243);
					if (File.Exists("dump.xml"))
					{
						_0024VB_0024ResumableLocal_htmlFile_00244 = "view.html";
						_0024VB_0024Me.GenerateHtmlFromDump("dump.xml", _0024VB_0024ResumableLocal_htmlFile_00244);
						_0024VB_0024Me.WebView21.CoreWebView2.Navigate(new Uri(Path.Combine(Application.StartupPath, _0024VB_0024ResumableLocal_htmlFile_00244)).AbsoluteUri);
						BTAlerter.Success("UI view updated successfully.");
					}
					else
					{
						BTAlerter.erroes("Error: Failed to retrieve UI dump.");
					}
				}
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
	private sealed class VB_0024StateMachine_104_srchbtn_Click : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncVoidMethodBuilder _0024Builder;

		internal object _0024VB_0024Local_sender;

		internal EventArgs _0024VB_0024Local_e;

		internal AndroidViewer _0024VB_0024Me;

		internal TaskAwaiter _0024A0;

		[CompilerGenerated]
		internal void MoveNext()
		{
			int num = _0024State;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = _0024VB_0024Me.FetchAndRenderViewAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_0024State = 0);
						_0024A0 = awaiter;
						ref AsyncVoidMethodBuilder reference = ref _0024Builder;
						VB_0024StateMachine_104_srchbtn_Click stateMachine = this;
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
	private sealed class VB_0024StateMachine_99_AndroidViewer_Load : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncVoidMethodBuilder _0024Builder;

		internal object _0024VB_0024Local_sender;

		internal EventArgs _0024VB_0024Local_e;

		internal AndroidViewer _0024VB_0024Me;

		internal TaskAwaiter _0024A0;

		[CompilerGenerated]
		internal void MoveNext()
		{
			int num = _0024State;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = _0024VB_0024Me.WebView21.EnsureCoreWebView2Async().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_0024State = 0);
						_0024A0 = awaiter;
						ref AsyncVoidMethodBuilder reference = ref _0024Builder;
						VB_0024StateMachine_99_AndroidViewer_Load stateMachine = this;
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
				_0024VB_0024Me.WebView21.NavigationCompleted += _0024VB_0024Me.WebView_NavigationCompleted;
				_0024VB_0024Me.loadphones();
				_0024VB_0024Me.logtext.AutoWordSelection = false;
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

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("WebView21")]
	private WebView2 _WebView21;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("mytitle")]
	private Label _mytitle;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("myico")]
	private PictureBox _myico;

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
	[AccessedThroughProperty("srchbtn")]
	private DrakeUIButtonIcon _srchbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("clearbtn")]
	private DrakeUIButtonIcon _clearbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("copybtn")]
	private DrakeUIButtonIcon _copybtn;

	private int minX;

	private int minY;

	private int maxX;

	private int maxY;

	private Dictionary<string, string> deviceMap;

	private bool keepmeto;

	internal virtual WebView2 WebView21
	{
		[CompilerGenerated]
		get
		{
			return _WebView21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = WebView21_Click;
			WebView2 webView = _WebView21;
			if (webView != null)
			{
				webView.Click -= value2;
			}
			_WebView21 = value;
			webView = _WebView21;
			if (webView != null)
			{
				webView.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("logtext")]
	internal virtual RichTextBox logtext
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

	[field: AccessedThroughProperty("Combophones")]
	internal virtual DrakeUIComboBox Combophones
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

	public virtual Label mytitle
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
			MouseEventHandler value2 = mytitle_MouseDown;
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

	public virtual PictureBox myico
	{
		[CompilerGenerated]
		get
		{
			return _myico;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = mytitle_MouseDown;
			PictureBox pictureBox = _myico;
			if (pictureBox != null)
			{
				pictureBox.MouseDown -= value2;
			}
			_myico = value;
			pictureBox = _myico;
			if (pictureBox != null)
			{
				pictureBox.MouseDown += value2;
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
			EventHandler value2 = closbtn_Click_1;
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

	[field: AccessedThroughProperty("DrakeWidth_W7")]
	internal virtual DrakeWidth_W DrakeWidth_W7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("DrakeWidth_W8")]
	internal virtual DrakeWidth_W DrakeWidth_W8
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

	[field: AccessedThroughProperty("DrakeUIToolTip1")]
	internal virtual DrakeUIToolTip DrakeUIToolTip1
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

	internal virtual DrakeUIButtonIcon clearbtn
	{
		[CompilerGenerated]
		get
		{
			return _clearbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon1_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _clearbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_clearbtn = value;
			drakeUIButtonIcon = _clearbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon copybtn
	{
		[CompilerGenerated]
		get
		{
			return _copybtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon2_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _copybtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_copybtn = value;
			drakeUIButtonIcon = _copybtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AndroidViewer()
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
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
	private void FindMinimumBounds(XmlNode xmlNode)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GenerateHtmlFromDump(string xmlPath, string htmlPath)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FindBounds(XmlNode xmlNode)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string EscapeJs(string value)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CollectVisualNodes(XmlNode xmlNode, List<VisualNode> list)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ProcessNode(XmlNode xmlNode, StringBuilder html)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string RunCommand(string command, string arguments)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WebView_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(VB_0024StateMachine_99_AndroidViewer_Load))]
	[DebuggerStepThrough]
	private void AndroidViewer_Load(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void loadphones()
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(VB_0024StateMachine_101_FetchAndRenderViewAsync))]
	[DebuggerStepThrough]
	private Task FetchAndRenderViewAsync()
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void mytitle_MouseDown(object sender, MouseEventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WebView21_Click(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(VB_0024StateMachine_104_srchbtn_Click))]
	[DebuggerStepThrough]
	private void srchbtn_Click(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void closbtn_Click_1(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pinbtn_Click(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}
}
