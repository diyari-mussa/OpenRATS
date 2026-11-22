// WsProbe — drives the panel's exact WebSocket4Net call shape against a BT relay
// so we can tell a panel bug from a server bug. Mirrors
// BtMob/BTMOB/WebSocketClient.InitializeWebSocket() verbatim:
//     new WebSocket(url, subProtocol, null, null, userAgent, origin)
using System;
using System.Threading;
using WebSocket4Net;

internal static class Program
{
	private static int Main(string[] args)
	{
		string url = args.Length > 0 ? args[0] : "ws://127.0.0.1:8080";
		string subProtocol = args.Length > 1 && args[1] != "-" ? args[1] : "";
		string userAgent = args.Length > 2 && args[2] != "-" ? args[2] : "";
		string origin = args.Length > 3 && args[3] != "-" ? args[3] : "";

		Console.WriteLine("URL        : " + url);
		Console.WriteLine("subProtocol: '" + subProtocol + "'");
		Console.WriteLine("userAgent  : '" + userAgent + "'");
		Console.WriteLine("origin     : '" + origin + "'");

		WebSocket ws;
		try
		{
			ws = new WebSocket(url, subProtocol, null, null, userAgent, origin);
		}
		catch (Exception ex)
		{
			Console.WriteLine("CTOR THREW: " + ex.GetType().Name + ": " + ex.Message);
			return 10;
		}

		bool opened = false;
		string err = null;
		string lastMsg = null;
		ws.Opened += (s, e) => { opened = true; Console.WriteLine("EVENT Opened"); };
		ws.Closed += (s, e) => Console.WriteLine("EVENT Closed");
		ws.Error += (s, e) => { err = e.Exception == null ? "(no exception)" : e.Exception.Message; Console.WriteLine("EVENT Error: " + err); };
		ws.MessageReceived += (s, e) => { lastMsg = e.Message; Console.WriteLine("EVENT Message: " + e.Message); };

		try
		{
			ws.Open();
		}
		catch (Exception ex)
		{
			Console.WriteLine("OPEN THREW: " + ex.GetType().Name + ": " + ex.Message);
			return 11;
		}

		for (int i = 0; i < 60 && !opened; i++) Thread.Sleep(100);
		Console.WriteLine("OPENED     : " + opened);
		Console.WriteLine("STATE      : " + ws.State);
		if (!opened)
		{
			Console.WriteLine("ERROR      : " + (err ?? "(none reported)"));
			return 2;
		}

		// Panel sends this on open (WebSocketClient.joinserver / VB_0024AnonymousType_8).
		string join = "{\"itype\":\"slr_panel\",\"subc\":\"join\",\"idf\":\"PROBE" + Guid.NewGuid().ToString("N").Substring(0, 8) + "\"}";
		ws.Send(join);
		Console.WriteLine("SENT join  : " + join);
		Thread.Sleep(800);

		// And this is what the relay should push back for another panel joining.
		Console.WriteLine("LAST MSG   : " + (lastMsg ?? "(none)"));
		Console.WriteLine("FINAL STATE: " + ws.State);
		ws.Close();
		Thread.Sleep(200);
		return 0;
	}
}
