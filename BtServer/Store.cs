// Store.cs — the built-APK store the panel's ApkMaker/BTApps windows read.
//
// Evidence (panel reconstruction):
//   ApkMaker.loadstorework posts {"subcom":"load","ran_key":..,"chk":..}
//   to yarsap_36921.php (api_fetchstore) and expects {"Success":"<AES blob>"}
//   where the blob decrypts to a JSON array of rows with fields:
//     app_id, app_name, app_size, app_date, app_folder, app_version,
//     app_ico, appstate
//   app_ico is a URL path appended to http://<server>/yaarsa/ (BTApps.cs
//   builds srv.Address + "/yaarsa/" + app_ico).
//
// This server stores built APKs under wwwroot/yaarsa/user/storage/<appid>/
// so the same URL convention works over plain static files.

using System.Collections.Generic;

namespace BtServer;

public class StoreEntry
{
    public string AppId { get; set; }
    public string AppName { get; set; } = "";
    public string AppSize { get; set; } = "";
    public string AppDate { get; set; } = "";
    public string AppFolder { get; set; } = "";
    public string AppVersion { get; set; } = "";
    public string AppIco { get; set; } = "";
    public string AppState { get; set; } = "built";

    // not part of the wire rows — server-side bookkeeping
    public string ApkFileName { get; set; } = "";
    public string BuiltBy { get; set; } = "";
}

public class Store
{
    private readonly object _lock = new();
    private readonly string _storePath;

    public Store(string baseDir)
    {
        _storePath = Path.Combine(baseDir, "store.json");
        if (!File.Exists(_storePath))
            File.WriteAllText(_storePath, "[]");
    }

    public List<StoreEntry> List()
    {
        lock (_lock)
        {
            return System.Text.Json.JsonSerializer.Deserialize<List<StoreEntry>>(File.ReadAllText(_storePath)) ?? new();
        }
    }

    public void Add(StoreEntry e)
    {
        lock (_lock)
        {
            var all = List();
            var old = all.FirstOrDefault(x => x.AppId == e.AppId);
            if (old != null) all.Remove(old);
            all.Add(e);
            File.WriteAllText(_storePath, System.Text.Json.JsonSerializer.Serialize(all, new System.Text.Json.JsonSerializerOptions { WriteIndented = true }));
        }
    }

    public bool Remove(string appId)
    {
        lock (_lock)
        {
            var all = List();
            var e = all.FirstOrDefault(x => x.AppId == appId);
            if (e == null) return false;
            all.Remove(e);
            File.WriteAllText(_storePath, System.Text.Json.JsonSerializer.Serialize(all));
            return true;
        }
    }
}
