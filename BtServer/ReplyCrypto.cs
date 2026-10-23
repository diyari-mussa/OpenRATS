// ReplyCrypto.cs — the AES scheme the panel uses for server replies.
//
// Evidence (panel reconstruction):
//   loader.cs / ApkMaker.cs / BTApps.cs / Form1.cs all call
//     MyServer.DecryptReply(ran_key, "BT-MOB!B6twG9+&U", response)
//   where response is the "Success" field the server returned for a request
//   that carried {"ran_key": <32-char random>, ...}.
//
// The original DecryptReply body was lost to EXGuarder stubbing (see
// _Analysis/BtMob/patched-il/patched-methods.json, MyServer.DecryptReply
// wasStub), but its contract is fully constrained by the callers:
//   - key material: the request's ran_key
//   - IV: the literal "BT-MOB!B6twG9+&U" (16 bytes)
//   - input: base64 ciphertext
//   - output: plaintext JSON string
// AES-128-CBC with PKCS7 is the only standard construction that fits all
// observed usage (32-char alphanumeric key truncated to 16 bytes, 16-byte
// literal IV, base64 payload) and matches the payload-side settings scheme
// (AES-128-CBC/PKCS7) used elsewhere in this family.

using System.Security.Cryptography;
using System.Text;

namespace BtServer;

public static class ReplyCrypto
{
    public const string IvLiteral = "BT-MOB!B6twG9+&U";

    /// <summary>Encrypt a server reply payload for a request that carried ran_key.</summary>
    public static string EncryptReply(string ranKey, string plaintext)
    {
        byte[] key = KeyBytes(ranKey);
        using var aes = Aes.Create();
        aes.Mode = CipherMode.CBC;
        aes.Padding = PaddingMode.PKCS7;
        aes.Key = key;
        aes.IV = Encoding.UTF8.GetBytes(IvLiteral);
        using ICryptoTransform enc = aes.CreateEncryptor();
        byte[] plain = Encoding.UTF8.GetBytes(plaintext ?? "");
        byte[] cipher = enc.TransformFinalBlock(plain, 0, plain.Length);
        return Convert.ToBase64String(cipher);
    }

    /// <summary>Decrypt (used by tests and the CLI to verify round-trips).</summary>
    public static string DecryptReply(string ranKey, string base64Cipher)
    {
        byte[] key = KeyBytes(ranKey);
        using var aes = Aes.Create();
        aes.Mode = CipherMode.CBC;
        aes.Padding = PaddingMode.PKCS7;
        aes.Key = key;
        aes.IV = Encoding.UTF8.GetBytes(IvLiteral);
        using ICryptoTransform dec = aes.CreateDecryptor();
        byte[] cipher = Convert.FromBase64String(base64Cipher);
        byte[] plain = dec.TransformFinalBlock(cipher, 0, cipher.Length);
        return Encoding.UTF8.GetString(plain);
    }

    private static byte[] KeyBytes(string ranKey)
    {
        // AES-128: first 16 bytes of the random key
        byte[] raw = Encoding.UTF8.GetBytes(ranKey ?? "");
        byte[] key = new byte[16];
        int n = Math.Min(16, raw.Length);
        Array.Copy(raw, key, n);
        return key;
    }
}
