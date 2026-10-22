using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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
public class Clientsupdater : basestyle
{
	[ComVisible(true)]
	public class mybridge
	{
		public Clientsupdater mainform;

		public mybridge(Clientsupdater minme)
		{
			mainform = minme;
		}

		[DispId(1)]
		public object toolbarclick(string clientid, string thestate)
		{
			return mainform.requestupdate(clientid, thestate);
		}
	}

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("combotags")]
	private DrakeUIComboBox _combotags;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("randver")]
	private DrakeUIButtonIcon _randver;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("refbtn")]
	private DrakeUIButtonIcon _refbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("upbtnall")]
	private DrakeUIButtonIcon _upbtnall;

	public List<BTClient> listclients;

	[field: AccessedThroughProperty("WebView21")]
	internal virtual WebView2 WebView21
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

	[field: AccessedThroughProperty("linktext")]
	internal virtual DrakeUITextBox linktext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIComboBox combotags
	{
		[CompilerGenerated]
		get
		{
			return _combotags;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = combotags_Click;
			DrakeUIComboBox drakeUIComboBox = _combotags;
			if (drakeUIComboBox != null)
			{
				drakeUIComboBox.Click -= value2;
			}
			_combotags = value;
			drakeUIComboBox = _combotags;
			if (drakeUIComboBox != null)
			{
				drakeUIComboBox.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon randver
	{
		[CompilerGenerated]
		get
		{
			return _randver;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = randver_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _randver;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_randver = value;
			drakeUIButtonIcon = _randver;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DrakeWidth_W13")]
	internal virtual DrakeWidth_W DrakeWidth_W13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DrakeWidth_W2")]
	internal new virtual DrakeWidth_W DrakeWidth_W2
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

	internal virtual DrakeUIButtonIcon refbtn
	{
		[CompilerGenerated]
		get
		{
			return _refbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon1_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _refbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_refbtn = value;
			drakeUIButtonIcon = _refbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon upbtnall
	{
		[CompilerGenerated]
		get
		{
			return _upbtnall;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon2_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _upbtnall;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_upbtnall = value;
			drakeUIButtonIcon = _upbtnall;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	public Clientsupdater()
	{
		base.Load += Clientsupdater_Load;
		listclients = new List<BTClient>();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTMOB.Clientsupdater));
		this.WebView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.linktext = new DrakeUI.Framework.DrakeUITextBox();
		this.refbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeWidth_W13 = new DrakeUI.Framework.DrakeWidth_W();
		this.combotags = new DrakeUI.Framework.DrakeUIComboBox();
		this.randver = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeWidth_W3 = new DrakeUI.Framework.DrakeWidth_W();
		this.upbtnall = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeWidth_W2 = new DrakeUI.Framework.DrakeWidth_W();
		((System.ComponentModel.ISupportInitialize)this.myscr).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.myico).BeginInit();
		this.tobpanelsti.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.WebView21).BeginInit();
		this.Panel2.SuspendLayout();
		base.SuspendLayout();
		this.myscr.Location = new System.Drawing.Point(63, 5);
		this.pinbtn.Location = new System.Drawing.Point(1145, 5);
		this.minibtn.Location = new System.Drawing.Point(1187, 5);
		this.closbtn.Location = new System.Drawing.Point(1229, 5);
		this.myico.Image = BTMOB.My.Resources.Resources.sync_1x_1_0s_417px_417px_removebg_preview;
		this.myico.Size = new System.Drawing.Size(48, 25);
		this.mytitle.Location = new System.Drawing.Point(5, 4);
		this.mytitle.Size = new System.Drawing.Size(1261, 18);
		this.tobpanelsti.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.tobpanelsti.Size = new System.Drawing.Size(1271, 26);
		this.WebView21.AllowExternalDrop = true;
		this.WebView21.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.WebView21.CreationProperties = null;
		this.WebView21.DefaultBackgroundColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.WebView21.Dock = System.Windows.Forms.DockStyle.Fill;
		this.WebView21.Location = new System.Drawing.Point(2, 109);
		this.WebView21.Name = EXGuarder._23651132;
		this.WebView21.Size = new System.Drawing.Size(1271, 508);
		this.WebView21.TabIndex = 40;
		this.WebView21.ZoomFactor = 1.0;
		this.Panel2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel2.Controls.Add(this.linktext);
		this.Panel2.Controls.Add(this.refbtn);
		this.Panel2.Controls.Add(this.DrakeWidth_W13);
		this.Panel2.Controls.Add(this.combotags);
		this.Panel2.Controls.Add(this.randver);
		this.Panel2.Controls.Add(this.DrakeWidth_W3);
		this.Panel2.Controls.Add(this.upbtnall);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel2.Location = new System.Drawing.Point(2, 64);
		this.Panel2.Name = EXGuarder._0D5C4E33;
		this.Panel2.Padding = new System.Windows.Forms.Padding(9);
		this.Panel2.Size = new System.Drawing.Size(1271, 45);
		this.Panel2.TabIndex = 41;
		this.Panel2.Controls.SetChildIndex(this.upbtnall, 0);
		this.Panel2.Controls.SetChildIndex(this.DrakeWidth_W3, 0);
		this.Panel2.Controls.SetChildIndex(this.randver, 0);
		this.Panel2.Controls.SetChildIndex(this.combotags, 0);
		this.Panel2.Controls.SetChildIndex(this.DrakeWidth_W13, 0);
		this.Panel2.Controls.SetChildIndex(this.refbtn, 0);
		this.Panel2.Controls.SetChildIndex(this.linktext, 0);
		this.linktext.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.linktext.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.linktext.Dock = System.Windows.Forms.DockStyle.Fill;
		this.linktext.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.linktext.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.linktext.Font = new System.Drawing.Font(EXGuarder._435F6B75, 9f);
		this.linktext.ForeColor = System.Drawing.Color.White;
		this.linktext.Location = new System.Drawing.Point(337, 9);
		this.linktext.Margin = new System.Windows.Forms.Padding(4);
		this.linktext.Maximum = 2147483647.0;
		this.linktext.Minimum = -2147483648.0;
		this.linktext.Name = EXGuarder._415A1A10;
		this.linktext.Padding = new System.Windows.Forms.Padding(4);
		this.linktext.Radius = 15;
		this.linktext.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.linktext.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.linktext.Size = new System.Drawing.Size(689, 25);
		this.linktext.Style = DrakeUI.Framework.UIStyle.Custom;
		this.linktext.TabIndex = 50;
		this.linktext.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
		this.linktext.Watermark = EXGuarder._44152A66;
		this.refbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.refbtn.Dock = System.Windows.Forms.DockStyle.Left;
		this.refbtn.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.refbtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.refbtn.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.refbtn.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.refbtn.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.refbtn.Font = new System.Drawing.Font(EXGuarder._435F6B75, 9f);
		this.refbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.refbtn.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.refbtn.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.refbtn.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.refbtn.Location = new System.Drawing.Point(179, 9);
		this.refbtn.Name = EXGuarder._4C183236;
		this.refbtn.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.refbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.refbtn.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.refbtn.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.refbtn.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.refbtn.Size = new System.Drawing.Size(148, 27);
		this.refbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.refbtn.Symbol = 61473;
		this.refbtn.TabIndex = 63;
		this.refbtn.Text = EXGuarder._20034769;
		this.DrakeWidth_W13.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W13.Dock = System.Windows.Forms.DockStyle.Right;
		this.DrakeWidth_W13.Location = new System.Drawing.Point(1026, 9);
		this.DrakeWidth_W13.Name = EXGuarder._12372635;
		this.DrakeWidth_W13.Size = new System.Drawing.Size(22, 27);
		this.DrakeWidth_W13.TabIndex = 58;
		this.combotags.Dock = System.Windows.Forms.DockStyle.Right;
		this.combotags.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.combotags.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.combotags.Font = new System.Drawing.Font(EXGuarder._435F6B75, 9f);
		this.combotags.ForeColor = System.Drawing.Color.White;
		this.combotags.Location = new System.Drawing.Point(1048, 9);
		this.combotags.Margin = new System.Windows.Forms.Padding(4);
		this.combotags.MinimumSize = new System.Drawing.Size(56, 0);
		this.combotags.Name = EXGuarder._5B0E6903;
		this.combotags.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
		this.combotags.Radius = 15;
		this.combotags.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.combotags.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.combotags.Size = new System.Drawing.Size(174, 25);
		this.combotags.Style = DrakeUI.Framework.UIStyle.Custom;
		this.combotags.StyleCustomMode = true;
		this.combotags.TabIndex = 51;
		this.combotags.Text = EXGuarder._65045A39;
		this.combotags.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
		this.combotags.Watermark = EXGuarder._320F0F2A;
		this.randver.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.randver.Cursor = System.Windows.Forms.Cursors.Hand;
		this.randver.Dock = System.Windows.Forms.DockStyle.Right;
		this.randver.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.randver.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.randver.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.randver.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.randver.Font = new System.Drawing.Font(EXGuarder._435F6B75, 9f);
		this.randver.ForeHoverColor = System.Drawing.Color.Gray;
		this.randver.Location = new System.Drawing.Point(1222, 9);
		this.randver.Name = EXGuarder._05513076;
		this.randver.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.randver.RectColor = System.Drawing.Color.Gray;
		this.randver.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.randver.RectHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.randver.RectPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.randver.RectSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.randver.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.randver.Size = new System.Drawing.Size(40, 27);
		this.randver.Style = DrakeUI.Framework.UIStyle.Custom;
		this.randver.Symbol = 61529;
		this.randver.SymbolSize = 25;
		this.randver.TabIndex = 33;
		this.DrakeWidth_W3.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W3.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeWidth_W3.Location = new System.Drawing.Point(157, 9);
		this.DrakeWidth_W3.Name = EXGuarder._48523424;
		this.DrakeWidth_W3.Size = new System.Drawing.Size(22, 27);
		this.DrakeWidth_W3.TabIndex = 61;
		this.upbtnall.Cursor = System.Windows.Forms.Cursors.Hand;
		this.upbtnall.Dock = System.Windows.Forms.DockStyle.Left;
		this.upbtnall.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.upbtnall.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.upbtnall.FillHoverColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.upbtnall.FillPressColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.upbtnall.FillSelectedColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.upbtnall.Font = new System.Drawing.Font(EXGuarder._435F6B75, 9f);
		this.upbtnall.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.upbtnall.ForeHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.upbtnall.ForePressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.upbtnall.ForeSelectedColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.upbtnall.Location = new System.Drawing.Point(9, 9);
		this.upbtnall.Name = EXGuarder._41353A60;
		this.upbtnall.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.upbtnall.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.upbtnall.RectHoverColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.upbtnall.RectPressColor = System.Drawing.Color.FromArgb(2, 176, 117);
		this.upbtnall.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.upbtnall.Size = new System.Drawing.Size(148, 27);
		this.upbtnall.Style = DrakeUI.Framework.UIStyle.Custom;
		this.upbtnall.Symbol = 61473;
		this.upbtnall.TabIndex = 64;
		this.upbtnall.Text = EXGuarder._400B3C75;
		this.DrakeWidth_W2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.DrakeWidth_W2.Dock = System.Windows.Forms.DockStyle.Left;
		this.DrakeWidth_W2.Location = new System.Drawing.Point(327, 9);
		this.DrakeWidth_W2.Name = EXGuarder._2F67291B;
		this.DrakeWidth_W2.Size = new System.Drawing.Size(22, 27);
		this.DrakeWidth_W2.TabIndex = 60;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 18f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(1275, 619);
		base.Controls.Add(this.WebView21);
		base.Controls.Add(this.Panel2);
		base.Icon = (System.Drawing.Icon)resources.GetObject(EXGuarder._1D2B0B3B);
		base.Name = EXGuarder._6726530C;
		this.Text = EXGuarder._6726530C;
		base.Controls.SetChildIndex(this.tobpanelsti, 0);
		base.Controls.SetChildIndex(this.Panel2, 0);
		base.Controls.SetChildIndex(this.WebView21, 0);
		((System.ComponentModel.ISupportInitialize)this.myscr).EndInit();
		((System.ComponentModel.ISupportInitialize)this.myico).EndInit();
		this.tobpanelsti.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.WebView21).EndInit();
		this.Panel2.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	private void translateme()
	{
		object value = BTRegistry.GetValue(EXGuarder._591B052F, EXGuarder._4F487057);
		if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._652B6A10, TextCompare: false))
		{
			upbtnall.Text = EXGuarder._11201915;
			refbtn.Text = EXGuarder._0B6E1938;
			linktext.Watermark = EXGuarder._4B4A3D32;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._79115505, TextCompare: false))
		{
			upbtnall.Text = EXGuarder._79536945;
			refbtn.Text = EXGuarder._2675633B;
			linktext.Watermark = EXGuarder._15282B2B;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._200C7749, TextCompare: false))
		{
			upbtnall.Text = EXGuarder._2A762573;
			refbtn.Text = EXGuarder._65350F3B;
			linktext.Watermark = EXGuarder._38285228;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._6E70195A, TextCompare: false))
		{
			upbtnall.Text = EXGuarder._3C1B4C09;
			refbtn.Text = EXGuarder._3B784255;
			linktext.Watermark = EXGuarder._1747182D;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._18630D5B, TextCompare: false))
		{
			upbtnall.Text = EXGuarder._5C321B1D;
			refbtn.Text = EXGuarder._1374532B;
			linktext.Watermark = EXGuarder._0C0D6A16;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._24700C16, TextCompare: false))
		{
			upbtnall.Text = EXGuarder._33691F64;
			refbtn.Text = EXGuarder._4D1F2633;
			linktext.Watermark = EXGuarder._23352226;
		}
	}

	private async void Clientsupdater_Load(object sender, EventArgs e)
	{
		await WebView21.EnsureCoreWebView2Async();
		WebView21.NavigationCompleted += WebView_NavigationCompleted;
		WebView21.NavigateToString(Resources.clientupdater.Replace("[LNG]", codes.locallanguage()));
		mybridge rawObject = new mybridge(this);
		WebView21.CoreWebView2.AddHostObjectToScript("mybridge", rawObject);
		WebView21.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
		WebView21.CoreWebView2.Settings.AreDevToolsEnabled = false;
		TagsManager tagsManager = new TagsManager();
		foreach (string tag in tagsManager.GetTags())
		{
			combotags.Items.Add(tag);
		}
		translateme();
		mytitle.Text = BTConst.upmanagstr;
	}

	private void WebView_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
	{
		loadall();
	}

	private async void loadall()
	{
		foreach (BTClient listclient in listclients)
		{
			try
			{
				string text = "not";
				string text2 = listclient.Tag;
				if (Operators.CompareString(BTConst.lastapkversion, listclient.version, TextCompare: false) == 0)
				{
					text = "updated";
				}
				if (listclient.UpdateRequested)
				{
					text = "requested";
					text2 = text2 + ">>" + listclient.UpdateTag;
				}
				string javaScript = $"addClient(`{codes.BitmapToBase64(listclient.wallpaper)}`,`{listclient.address}`,`{listclient.name}`,`{listclient.version}`,`{text}`,`{listclient.mobid}`,`{text2}`);";
				await WebView21.CoreWebView2.ExecuteScriptAsync(javaScript);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Exception ex3 = ex2;
				Interaction.MsgBox("JS error: " + ex3.Message);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void randver_Click(object sender, EventArgs e)
	{
		MyMsg.Show(BTConst.upmanagstr, BTConst.upmanagrtpstr, MyMsg.msgtype.Confirm, use_no: false, showskip: false, EXGuarder._2B223253);
	}

	public string requestupdate(string mobid, string thestate)
	{
		string _74753D = linktext.Text;
		string _74753D2 = combotags.Text;
		if (Operators.CompareString(thestate, EXGuarder._5C414A61, TextCompare: false) == 0)
		{
			if (codes.StrisEmpty(_74753D))
			{
				BTAlerter.infos(BTConst.nodownlinkstr);
				return EXGuarder._680C344A;
			}
			if ((Operators.CompareString(_74753D2, BTConst.slcttagstr, TextCompare: false) == 0) | codes.StrisEmpty(_74753D2))
			{
				BTAlerter.infos(BTConst.notagslctstr);
				return EXGuarder._680C344A;
			}
		}
		else
		{
			_74753D = EXGuarder._74753D06;
			_74753D2 = EXGuarder._74753D06;
		}
		ServersInfo serverins = default(ServersInfo);
		foreach (BTClient listclient in listclients)
		{
			if (Operators.CompareString(listclient.mobid, mobid, TextCompare: false) == 0)
			{
				serverins = listclient.Serverins;
				break;
			}
		}
		if (serverins != null)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add(EXGuarder._1C6E5347, EXGuarder._4E1E3B33);
			dictionary.Add(EXGuarder._250A123D, thestate);
			dictionary.Add(EXGuarder._77367325, _74753D);
			dictionary.Add(EXGuarder._472A3B52, _74753D2);
			Dictionary<string, object> chatData = dictionary;
			BTEngine.commands(chatData, mobid, serverins.WSClient);
		}
		return EXGuarder._734A620E;
	}

	private async void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		try
		{
			await WebView21.CoreWebView2.ExecuteScriptAsync("clearClientTable();");
			Thread thread = new Thread([SpecialName] async () =>
			{
				Dictionary<string, object> chatData = new Dictionary<string, object> { 
				{
					"msg",
					BTConst.startpng
				} };
				foreach (BTClient listclient in listclients)
				{
					BTEngine.commands(chatData, listclient.mobid, listclient.Serverins.WSClient);
					Thread.Sleep(1);
				}
				Thread.Sleep(1000);
				Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
				{
					loadall();
				}));
			});
			thread.IsBackground = true;
			thread.Start();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private async void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
		string str = linktext.Text;
		string text = combotags.Text;
		if (codes.StrisEmpty(str))
		{
			BTAlerter.infos(BTConst.nodownlinkstr);
		}
		else if ((Operators.CompareString(text, BTConst.slcttagstr, TextCompare: false) == 0) | codes.StrisEmpty(text))
		{
			BTAlerter.infos(BTConst.notagslctstr);
		}
		else
		{
			await WebView21.CoreWebView2.ExecuteScriptAsync("updateall();");
		}
	}

	private void combotags_Click(object sender, EventArgs e)
	{
		if (combotags.Items.Count != 0 || MyMsg.Show(BTConst.emptytagsstr, BTConst.notagsstr, MyMsg.msgtype.Confirm, use_no: true, showskip: false, EXGuarder._3403660A) == DialogResult.None)
		{
			return;
		}
		string _3403660A = EXGuarder._3403660A;
		myinputs myinputs2 = new myinputs();
		myinputs2.msgtitle.Text = BTConst.titltagstr;
		myinputs2.inputtext.Text = EXGuarder._3403660A;
		myinputs2.inputtext.Watermark = BTConst.exmptagstr;
		if (myinputs2.ShowDialog() != DialogResult.OK)
		{
			return;
		}
		_3403660A = myinputs2.inputtext.Text;
		if (codes.StrisEmpty(_3403660A))
		{
			return;
		}
		TagsManager tagsManager = new TagsManager();
		tagsManager.AddTag(_3403660A);
		foreach (string tag in tagsManager.GetTags())
		{
			combotags.Items.Add(tag);
		}
	}
}
