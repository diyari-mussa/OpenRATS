using System;
using System.Drawing;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace BTMOB;

public class BTClient
{
	public Bitmap screen;

	public Bitmap wallpaper;

	public Bitmap flag;

	public Bitmap wifi;

	public Bitmap battery;

	public string name;

	public string android;

	public DataGridViewRow row;

	public string address;

	public string mobid;

	public string Tag;

	public string version;

	public string tracking;

	public string installdate;

	public string pingms;

	public string country;

	public string sim;

	public string MobName;

	public string activewindow;

	public string userfolder;

	public string screenstate;

	public string keyloggs;

	public string visitedapps;

	public string activies;

	public string notifications;

	public string visitedlinks;

	public string BlockedSMS;

	public string BlockedCalls;

	public string Foundedjects;

	public string SecoundIDF;

	public string jects_count;

	public string angle;

	public string lights;

	public string charging;

	public Thread sockth;

	public HttpClient httpClient;

	public bool isDeviceAdmin;

	public bool isFavorite;

	public bool isConnected;

	public bool UpdateRequested;

	public string UpdateTag;

	public WebSocketClient Websockclient;

	public DateTime LastPingUtc;

	public int PingTimeoutSeconds;

	public bool Exiting;

	private bool Firstload;

	public ServersInfo Serverins { get; set; }

	public string WifiType { get; set; }

	public bool VerifiedSecure { get; set; }

	public bool IsSecured { get; set; }

	public bool EncryptState { get; set; }

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BTClient(string cli_name, Bitmap cli_screen, Bitmap cli_wallpaper, Bitmap cli_flag, Bitmap cli_wifi, Bitmap cli_battery, string cli_android, string cli_address, string cli_mobid, string cli_version, string cli_installdate, string cli_tracking, string cli_country, string cli_sim, string cli_ping, string cli_keylogs, string cli_vapps, string cli_activz, string cli_notifys, string cli_vLinks, string cli_chrg, string cli_mobname, string cli_tag)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object CreateSocket(BTClient ClassClient)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void IamOnline()
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void iamout()
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string ReadOptions()
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateOption(string key, string value)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void sendoptions()
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}
}
