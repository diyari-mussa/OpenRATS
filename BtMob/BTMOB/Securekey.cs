using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace BTMOB;

[DesignerGenerated]
public class Securekey : basestyle
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("savbtn")]
	private DrakeUIButtonIcon _savbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("backupbtn")]
	private DrakeUIButtonIcon _backupbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cancelbtn")]
	private DrakeUIButtonIcon _cancelbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkunderstand")]
	private DrakeUICheckBox _checkunderstand;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("confpass")]
	private DrakeUITextBox _confpass;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("passtxt")]
	private DrakeUITextBox _passtxt;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("restorebtn")]
	private DrakeUIButtonIcon _restorebtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("langtext")]
	private DrakeUIComboBox _langtext;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("downbtn")]
	private DrakeUIButtonIcon _downbtn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dellall")]
	private DrakeUIButtonIcon _dellall;

	private bool keyrestored;

	private bool profileSaved;

	[field: AccessedThroughProperty("TableLayoutPanel1")]
	internal virtual TableLayoutPanel TableLayoutPanel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon savbtn
	{
		[CompilerGenerated]
		get
		{
			return _savbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = savbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _savbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_savbtn = value;
			drakeUIButtonIcon = _savbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon backupbtn
	{
		[CompilerGenerated]
		get
		{
			return _backupbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = backupbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _backupbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_backupbtn = value;
			drakeUIButtonIcon = _backupbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon cancelbtn
	{
		[CompilerGenerated]
		get
		{
			return _cancelbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = checkbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _cancelbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_cancelbtn = value;
			drakeUIButtonIcon = _cancelbtn;
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

	internal virtual DrakeUICheckBox checkunderstand
	{
		[CompilerGenerated]
		get
		{
			return _checkunderstand;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DrakeUICheckBox.OnValueChanged value2 = checkunderstand_ValueChanged;
			DrakeUICheckBox drakeUICheckBox = _checkunderstand;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.ValueChanged -= value2;
			}
			_checkunderstand = value;
			drakeUICheckBox = _checkunderstand;
			if (drakeUICheckBox != null)
			{
				drakeUICheckBox.ValueChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DrakeUIGroupBox1")]
	internal virtual DrakeUIGroupBox DrakeUIGroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lbltip3")]
	internal virtual DrakeUISymbolLabel lbltip3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lbltip2")]
	internal virtual DrakeUISymbolLabel lbltip2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lbltip1")]
	internal virtual DrakeUISymbolLabel lbltip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel44")]
	internal virtual Panel Panel44
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ctrtext")]
	internal virtual DrakeUISymbolLabel ctrtext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUITextBox confpass
	{
		[CompilerGenerated]
		get
		{
			return _confpass;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = confpass_TextChanged;
			DrakeUITextBox drakeUITextBox = _confpass;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged -= value2;
			}
			_confpass = value;
			drakeUITextBox = _confpass;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel3")]
	internal virtual Panel Panel3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblpass")]
	internal virtual DrakeUISymbolLabel lblpass
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUITextBox passtxt
	{
		[CompilerGenerated]
		get
		{
			return _passtxt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = passtxt_TextChanged;
			DrakeUITextBox drakeUITextBox = _passtxt;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged -= value2;
			}
			_passtxt = value;
			drakeUITextBox = _passtxt;
			if (drakeUITextBox != null)
			{
				drakeUITextBox.TextChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel4")]
	internal virtual Panel Panel4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label15")]
	internal virtual Label Label15
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblstatus")]
	internal virtual Label lblstatus
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("passquality")]
	internal virtual Label passquality
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon restorebtn
	{
		[CompilerGenerated]
		get
		{
			return _restorebtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = restorebtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _restorebtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_restorebtn = value;
			drakeUIButtonIcon = _restorebtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("paneltwo")]
	internal virtual Panel paneltwo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("paneltop")]
	internal virtual Panel paneltop
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIComboBox langtext
	{
		[CompilerGenerated]
		get
		{
			return _langtext;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = langtext_SelectedIndexChanged;
			DrakeUIComboBox drakeUIComboBox = _langtext;
			if (drakeUIComboBox != null)
			{
				drakeUIComboBox.SelectedIndexChanged -= value2;
			}
			_langtext = value;
			drakeUIComboBox = _langtext;
			if (drakeUIComboBox != null)
			{
				drakeUIComboBox.SelectedIndexChanged += value2;
			}
		}
	}

	internal virtual DrakeUIButtonIcon downbtn
	{
		[CompilerGenerated]
		get
		{
			return _downbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = downbtn_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _downbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_downbtn = value;
			drakeUIButtonIcon = _downbtn;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel5")]
	internal virtual Panel Panel5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel6")]
	internal virtual Panel Panel6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label16")]
	internal virtual Label Label16
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel7")]
	internal virtual Panel Panel7
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

	[field: AccessedThroughProperty("TableLayoutPanel2")]
	internal virtual TableLayoutPanel TableLayoutPanel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("panetltitle1")]
	internal virtual DrakeUITitlePanel panetltitle1
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

	[field: AccessedThroughProperty("paneltitle2")]
	internal virtual DrakeUITitlePanel paneltitle2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("termtext")]
	internal virtual RichTextBox termtext
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel8")]
	internal virtual Panel Panel8
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

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox2")]
	internal virtual PictureBox PictureBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DrakeUIButtonIcon dellall
	{
		[CompilerGenerated]
		get
		{
			return _dellall;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = dellall_Click;
			DrakeUIButtonIcon drakeUIButtonIcon = _dellall;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click -= value2;
			}
			_dellall = value;
			drakeUIButtonIcon = _dellall;
			if (drakeUIButtonIcon != null)
			{
				drakeUIButtonIcon.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DrakeWidth_W2")]
	internal new virtual DrakeWidth_W DrakeWidth_W2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lbltip4")]
	internal virtual DrakeUISymbolLabel lbltip4
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

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
			components.Dispose();
		base.Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		TableLayoutPanel1 = new TableLayoutPanel();
		savbtn = new DrakeUIButtonIcon();
		backupbtn = new DrakeUIButtonIcon();
		cancelbtn = new DrakeUIButtonIcon();
		Panel2 = new Panel();
		checkunderstand = new DrakeUICheckBox();
		DrakeUIGroupBox1 = new DrakeUIGroupBox();
		lbltip1 = new DrakeUISymbolLabel();
		lbltip2 = new DrakeUISymbolLabel();
		lbltip3 = new DrakeUISymbolLabel();
		lbltip4 = new DrakeUISymbolLabel();
		Panel44 = new Panel();
		ctrtext = new DrakeUISymbolLabel();
		confpass = new DrakeUITextBox();
		Panel3 = new Panel();
		lblpass = new DrakeUISymbolLabel();
		passtxt = new DrakeUITextBox();
		Panel4 = new Panel();
		restorebtn = new DrakeUIButtonIcon();
		Label15 = new Label();
		lblstatus = new Label();
		passquality = new Label();
		paneltwo = new Panel();
		paneltop = new Panel();
		PictureBox1 = new PictureBox();
		langtext = new DrakeUIComboBox();
		downbtn = new DrakeUIButtonIcon();
		Panel5 = new Panel();
		Panel6 = new Panel();
		Label16 = new Label();
		Panel7 = new Panel();
		Label2 = new Label();
		TableLayoutPanel2 = new TableLayoutPanel();
		panetltitle1 = new DrakeUITitlePanel();
		Label3 = new Label();
		paneltitle2 = new DrakeUITitlePanel();
		termtext = new RichTextBox();
		Panel8 = new Panel();
		Label1 = new Label();
		Label5 = new Label();
		PictureBox2 = new PictureBox();
		dellall = new DrakeUIButtonIcon();
		DrakeWidth_W2 = new DrakeWidth_W();
		DrakeWidth_W3 = new DrakeWidth_W();
		Label4 = new Label();
		((ISupportInitialize)PictureBox1).BeginInit();
		((ISupportInitialize)PictureBox2).BeginInit();
		SuspendLayout();
		paneltwo.SuspendLayout();
		paneltop.SuspendLayout();
		TableLayoutPanel1.SuspendLayout();
		Panel2.SuspendLayout();
		DrakeUIGroupBox1.SuspendLayout();
		Panel44.SuspendLayout();
		Panel3.SuspendLayout();
		Panel4.SuspendLayout();
		Panel5.SuspendLayout();
		Panel6.SuspendLayout();
		Panel7.SuspendLayout();
		Panel8.SuspendLayout();
		TableLayoutPanel2.SuspendLayout();
		panetltitle1.SuspendLayout();
		paneltitle2.SuspendLayout();

		passtxt.Location = new Point(253, 7);
		passtxt.Size = new Size(298, 22);
		passtxt.TabIndex = 19;
		passtxt.PasswordChar = '*';
		lblpass.Location = new Point(8, 7);
		lblpass.Size = new Size(245, 22);
		lblpass.Text = "Password";
		Panel3.Location = new Point(6, 128);
		Panel3.Size = new Size(559, 36);
		Panel3.Controls.Add(lblpass);
		Panel3.Controls.Add(passtxt);

		confpass.Location = new Point(253, 7);
		confpass.Size = new Size(298, 22);
		confpass.TabIndex = 19;
		confpass.PasswordChar = '*';
		ctrtext.Location = new Point(8, 7);
		ctrtext.Size = new Size(245, 22);
		ctrtext.Text = "Confirm Password";
		Panel44.Location = new Point(6, 164);
		Panel44.Size = new Size(559, 36);
		Panel44.Controls.Add(ctrtext);
		Panel44.Controls.Add(confpass);

		restorebtn.Location = new Point(253, 6);
		restorebtn.Size = new Size(299, 23);
		restorebtn.Text = "import backed up key";
		restorebtn.TabIndex = 27;
		Panel4.Location = new Point(6, 221);
		Panel4.Size = new Size(559, 36);
		Panel4.Controls.Add(restorebtn);

		lbltip1.Location = new Point(13, 31);
		lbltip1.Size = new Size(546, 32);
		lbltip1.Text = "This password cannot be recovered if lost.";
		lbltip2.Location = new Point(13, 63);
		lbltip2.Size = new Size(546, 32);
		lbltip2.Text = "A backup allows moving your secure keys to another computer";
		lbltip3.Location = new Point(13, 95);
		lbltip3.Size = new Size(546, 32);
		lbltip3.Text = "Use at least 10 characters.";
		lbltip4.Location = new Point(13, 127);
		lbltip4.Size = new Size(546, 32);
		lbltip4.Text = "First click save then click Backup to complete setup";
		DrakeUIGroupBox1.Location = new Point(6, 257);
		DrakeUIGroupBox1.Size = new Size(559, 177);
		DrakeUIGroupBox1.Text = "Security Tips";
		DrakeUIGroupBox1.Controls.Add(lbltip1);
		DrakeUIGroupBox1.Controls.Add(lbltip2);
		DrakeUIGroupBox1.Controls.Add(lbltip3);
		DrakeUIGroupBox1.Controls.Add(lbltip4);

		checkunderstand.Location = new Point(4, 3);
		checkunderstand.Size = new Size(551, 20);
		checkunderstand.Text = "I understand that this password cannot be recovered.";
		Panel2.Location = new Point(6, 434);
		Panel2.Size = new Size(559, 26);
		Panel2.Controls.Add(checkunderstand);

		cancelbtn.Text = "Cancel";
		cancelbtn.Dock = DockStyle.Fill;
		backupbtn.Text = "Backup";
		backupbtn.Dock = DockStyle.Fill;
		savbtn.Text = "Save";
		savbtn.Dock = DockStyle.Fill;
		TableLayoutPanel1.ColumnCount = 3;
		TableLayoutPanel1.RowCount = 1;
		TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33f));
		TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33f));
		TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34f));
		TableLayoutPanel1.Controls.Add(cancelbtn, 0, 0);
		TableLayoutPanel1.Controls.Add(backupbtn, 1, 0);
		TableLayoutPanel1.Controls.Add(savbtn, 2, 0);
		TableLayoutPanel1.Location = new Point(6, 460);
		TableLayoutPanel1.Size = new Size(559, 45);

		Label15.Location = new Point(6, 102);
		Label15.Size = new Size(559, 26);
		Label15.Text = "You will need this password every time the application starts.";
		passquality.Location = new Point(6, 200);
		passquality.Size = new Size(559, 21);
		lblstatus.Location = new Point(2, 571);
		lblstatus.Size = new Size(571, 20);

		paneltwo.Location = new Point(2, 61);
		paneltwo.Size = new Size(571, 510);
		paneltwo.Controls.Add(Label15);
		paneltwo.Controls.Add(Panel3);
		paneltwo.Controls.Add(Panel44);
		paneltwo.Controls.Add(passquality);
		paneltwo.Controls.Add(Panel4);
		paneltwo.Controls.Add(DrakeUIGroupBox1);
		paneltwo.Controls.Add(Panel2);
		paneltwo.Controls.Add(TableLayoutPanel1);
		paneltwo.Visible = false;

		Label5.Location = new Point(106, 4);
		Label5.Size = new Size(449, 43);
		Label5.Text = "Welcome to BTMOB";
		Label5.Font = new Font("Segoe UI", 14f, FontStyle.Bold);
		Label1.Location = new Point(106, 47);
		Label1.Size = new Size(449, 29);
		Label1.Text = "Super, Secure, Advanced, Android remote tool";
		PictureBox2.Location = new Point(4, 4);
		PictureBox2.Size = new Size(102, 79);
		PictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
		Panel8.Location = new Point(6, 5);
		Panel8.Size = new Size(559, 87);
		Panel8.Controls.Add(PictureBox2);
		Panel8.Controls.Add(Label5);
		Panel8.Controls.Add(Label1);

		langtext.Location = new Point(13, 12);
		langtext.Size = new Size(162, 23);
		langtext.Items.AddRange(new object[] { "English" });
		langtext.Text = "English";
		dellall.Location = new Point(290, 12);
		dellall.Size = new Size(122, 27);
		dellall.Text = "Exit";
		downbtn.Location = new Point(424, 12);
		downbtn.Size = new Size(122, 27);
		downbtn.Text = "Continue";
		Panel5.Location = new Point(6, 454);
		Panel5.Size = new Size(559, 51);
		Panel5.Controls.Add(langtext);
		Panel5.Controls.Add(dellall);
		Panel5.Controls.Add(downbtn);

		Label3.Dock = DockStyle.Fill;
		Label3.Text = "BTMOB supports signed and encrypted communication using session-based cryptographic keys. Your password is used locally to unlock your encrypted private keys and is never transmitted to any server.";
		panetltitle1.Location = new Point(4, 4);
		panetltitle1.Size = new Size(551, 106);
		panetltitle1.Text = "Secure Connection";
		panetltitle1.Controls.Add(Label3);
		termtext.Location = new Point(13, 35);
		termtext.Size = new Size(525, 193);
		termtext.ReadOnly = true;
		termtext.Text = "Protect your connection with a strong password.";
		paneltitle2.Location = new Point(4, 118);
		paneltitle2.Size = new Size(551, 240);
		paneltitle2.Text = "Terms of Service";
		paneltitle2.Controls.Add(termtext);
		TableLayoutPanel2.ColumnCount = 1;
		TableLayoutPanel2.RowCount = 2;
		TableLayoutPanel2.Dock = DockStyle.Fill;
		TableLayoutPanel2.Controls.Add(panetltitle1, 0, 0);
		TableLayoutPanel2.Controls.Add(paneltitle2, 0, 1);
		Panel7.Location = new Point(6, 92);
		Panel7.Size = new Size(559, 362);
		Panel7.Controls.Add(TableLayoutPanel2);

		paneltop.Location = new Point(2, 61);
		paneltop.Size = new Size(571, 510);
		paneltop.Controls.Add(Panel8);
		paneltop.Controls.Add(Panel7);
		paneltop.Controls.Add(Panel5);

		ClientSize = new Size(575, 593);
		Controls.Add(paneltwo);
		Controls.Add(paneltop);
		Controls.Add(lblstatus);
		Name = "Securekey";
		Text = "Securekey";

		TableLayoutPanel1.ResumeLayout(false);
		Panel2.ResumeLayout(false);
		DrakeUIGroupBox1.ResumeLayout(false);
		Panel44.ResumeLayout(false);
		Panel3.ResumeLayout(false);
		Panel4.ResumeLayout(false);
		Panel5.ResumeLayout(false);
		Panel6.ResumeLayout(false);
		Panel7.ResumeLayout(false);
		Panel8.ResumeLayout(false);
		TableLayoutPanel2.ResumeLayout(false);
		panetltitle1.ResumeLayout(false);
		paneltitle2.ResumeLayout(false);
		paneltwo.ResumeLayout(false);
		paneltop.ResumeLayout(false);
		((ISupportInitialize)PictureBox1).EndInit();
		((ISupportInitialize)PictureBox2).EndInit();
		ResumeLayout(false);
	}

	public Securekey()
	{
		Load += Securekey_Load;
		InitializeComponent();
	}

	private void translateme()
	{
	}

	private void Securekey_Load(object sender, EventArgs e)
	{
		paneltop.Visible = true;
		paneltwo.Visible = false;
		translateme();
	}

	private void passtxt_TextChanged(object sender, EventArgs e)
	{
		ValidatePassword();
	}

	private void confpass_TextChanged(object sender, EventArgs e)
	{
		ValidatePassword();
	}

	private void checkunderstand_ValueChanged(object sender, bool value)
	{
	}

	private void ValidatePassword()
	{
		string pass = passtxt.Text ?? "";
		string confirm = confpass.Text ?? "";
		passquality.Text = GetPasswordStrength(pass);
		if (pass.Length == 0 && confirm.Length == 0)
			return;
		if (confirm.Length > 0 && !string.Equals(pass, confirm, StringComparison.Ordinal))
		{
			lblstatus.Text = EXGuarder._160C3E3D;
			lblstatus.ForeColor = Color.OrangeRed;
			return;
		}
		if (confirm.Length > 0)
		{
			lblstatus.Text = EXGuarder._1D1A2970;
			lblstatus.ForeColor = Color.FromArgb(2, 176, 117);
		}
	}

	private string GetPasswordStrength(string pass)
	{
		if (string.IsNullOrEmpty(pass))
			return "";
		int score = 0;
		if (pass.Length >= 10)
			score++;
		if (pass.Any(char.IsUpper))
			score++;
		if (pass.Any(char.IsDigit))
			score++;
		if (pass.Any(c => !char.IsLetterOrDigit(c)))
			score++;
		string word = score <= 1 ? EXGuarder._4F144F76 : score <= 3 ? EXGuarder._68656E06 : EXGuarder._1C2C3757;
		return EXGuarder._12381A79 + word;
	}

	private bool PasswordReady(out string error)
	{
		string pass = passtxt.Text ?? "";
		string confirm = confpass.Text ?? "";
		if (pass.Length == 0)
		{
			error = EXGuarder._54480577;
			return false;
		}
		if (pass.Length < 10)
		{
			error = EXGuarder._31175C30;
			return false;
		}
		if (!string.Equals(pass, confirm, StringComparison.Ordinal))
		{
			error = EXGuarder._160C3E3D;
			return false;
		}
		if (checkunderstand == null || !checkunderstand.Checked)
		{
			error = EXGuarder._39137458;
			return false;
		}
		error = null;
		return true;
	}

	private void Status(string text, bool ok)
	{
		lblstatus.Text = text;
		lblstatus.ForeColor = ok ? Color.FromArgb(2, 176, 117) : Color.OrangeRed;
	}

	private void checkbtn_Click(object sender, EventArgs e)
	{
		string msg = string.Format(EXGuarder._53114D60, BTConst.myname);
		if (MyMsg.Show(EXGuarder._5B3B172A, msg, MyMsg.msgtype.warning, use_no: true) == DialogResult.OK)
			Close();
	}

	private object Cancelsetup()
	{
		Close();
		return null;
	}

	private object allok()
	{
		DialogResult = DialogResult.OK;
		Close();
		return null;
	}

	private void savbtn_Click(object sender, EventArgs e)
	{
		if (!PasswordReady(out string error))
		{
			Status(error, false);
			MyMsg.Show(BTConst.myname, error, MyMsg.msgtype.warning, use_no: false);
			return;
		}
		try
		{
			KeyGenerator.GenerateAndSaveKeys(passtxt.Text);
			profileSaved = true;
			mytitle.Text = EXGuarder._28706B76;
			Status(EXGuarder._210C6637, true);
			MyMsg.Show(BTConst.myname, EXGuarder._210C6637 + " " + EXGuarder._5660531C, MyMsg.msgtype.Confirm, use_no: false);
		}
		catch (Exception ex)
		{
			Status(EXGuarder._27001C29, false);
			MyMsg.Show(BTConst.myname, EXGuarder._27001C29 + Environment.NewLine + ex.Message, MyMsg.msgtype.errors, use_no: false);
		}
	}

	private void backupbtn_Click(object sender, EventArgs e)
	{
		if (!profileSaved && !PasswordReady(out _))
		{
			Status(EXGuarder._54480577, false);
			MyMsg.Show(BTConst.myname, EXGuarder._54480577, MyMsg.msgtype.warning, use_no: false);
			return;
		}
		if (!profileSaved)
		{
			savbtn_Click(sender, e);
			if (!profileSaved)
				return;
		}
		using (SaveFileDialog dlg = new SaveFileDialog())
		{
			dlg.Filter = EXGuarder._4E1C613F;
			dlg.FileName = DateTime.Now.ToString(EXGuarder._22056D2F) + EXGuarder._14394224 + EXGuarder._693E0A49;
			dlg.Title = string.Format(EXGuarder._2F726B38, BTConst.myname);
			if (dlg.ShowDialog(this) != DialogResult.OK)
				return;
			try
			{
				byte[] zip = BuildKeyZip();
				File.WriteAllBytes(dlg.FileName, KeyGenerator.EncryptBackupFile(zip, passtxt.Text));
				Status(EXGuarder._403F265F, true);
				MyMsg.Show(BTConst.myname, EXGuarder._403F265F, MyMsg.msgtype.Confirm, use_no: false);
				allok();
			}
			catch (Exception ex)
			{
				Status(EXGuarder._27001C29, false);
				MyMsg.Show(BTConst.myname, ex.Message, MyMsg.msgtype.errors, use_no: false);
			}
		}
	}

	private byte[] BuildKeyZip()
	{
		KeyGenerator.EnsureKeyPaths();
		using (MemoryStream ms = new MemoryStream())
		{
			using (ZipArchive zip = new ZipArchive(ms, ZipArchiveMode.Create, leaveOpen: true))
			{
				AddFile(zip, BTConst.Sign_Private_Key_Path);
				AddFile(zip, BTConst.Sign_Public_Key_Path);
				AddFile(zip, BTConst.Exchange_Private_Key_Path);
				AddFile(zip, BTConst.Exchange_Public_Key_Path);
				ZipArchiveEntry note = zip.CreateEntry(EXGuarder._406F5E3E);
				using (Stream s = note.Open())
				{
					byte[] text = Encoding.UTF8.GetBytes(EXGuarder._30282B2B + Environment.NewLine + EXGuarder._63393B13);
					s.Write(text, 0, text.Length);
				}
			}
			return ms.ToArray();
		}
	}

	private static void AddFile(ZipArchive zip, string path)
	{
		ZipArchiveEntry entry = zip.CreateEntry(Path.GetFileName(path));
		using (Stream s = entry.Open())
		{
			byte[] data = File.ReadAllBytes(path);
			s.Write(data, 0, data.Length);
		}
	}

	private void restorebtn_Click(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(passtxt.Text))
		{
			Status(EXGuarder._54480577, false);
			MyMsg.Show(BTConst.myname, EXGuarder._54480577, MyMsg.msgtype.warning, use_no: false);
			return;
		}
		using (OpenFileDialog dlg = new OpenFileDialog())
		{
			dlg.Filter = EXGuarder._4E1C613F;
			dlg.Title = EXGuarder._55221F49;
			if (dlg.ShowDialog(this) != DialogResult.OK)
				return;
			try
			{
				byte[] zipBytes = KeyGenerator.DecryptBackupFile(File.ReadAllBytes(dlg.FileName), passtxt.Text);
				KeyGenerator.EnsureKeyPaths();
				using (MemoryStream ms = new MemoryStream(zipBytes))
				using (ZipArchive zip = new ZipArchive(ms, ZipArchiveMode.Read))
				{
					foreach (ZipArchiveEntry entry in zip.Entries)
					{
						if (string.IsNullOrEmpty(entry.Name) || entry.Name.EndsWith(".txt", StringComparison.OrdinalIgnoreCase))
							continue;
						string dest = Path.Combine(Path.GetDirectoryName(BTConst.Sign_Private_Key_Path), entry.Name);
						using (Stream s = entry.Open())
						using (FileStream fs = File.Create(dest))
							s.CopyTo(fs);
					}
				}
				if (!KeyGenerator.UnlockSecureProfile(passtxt.Text))
				{
					Status(EXGuarder._280B5423, false);
					MyMsg.Show(BTConst.myname, EXGuarder._280B5423, MyMsg.msgtype.errors, use_no: false);
					return;
				}
				keyrestored = true;
				profileSaved = true;
				Status(EXGuarder._16735C05, true);
				MyMsg.Show(BTConst.myname, EXGuarder._16735C05, MyMsg.msgtype.Confirm, use_no: false);
				allok();
			}
			catch
			{
				Status(EXGuarder._280B5423, false);
				MyMsg.Show(BTConst.myname, EXGuarder._280B5423, MyMsg.msgtype.errors, use_no: false);
			}
		}
	}

	private void langtext_SelectedIndexChanged(object sender, EventArgs e)
	{
		translateme();
	}

	private void downbtn_Click(object sender, EventArgs e)
	{
		hidetop();
	}

	private void hidetop()
	{
		paneltop.Visible = false;
		paneltwo.Visible = true;
		paneltwo.BringToFront();
		mytitle.Text = EXGuarder._06471D52;
	}

	private void dellall_Click(object sender, EventArgs e)
	{
		Close();
	}
}
