using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Microsoft.VisualBasic.CompilerServices;

namespace BTMOB;

[StandardModule]
internal sealed class KeyGenerator
{
	public static byte[] LoadedSignPrivateKey = null;

	public static byte[] LoadedSignPublicKey = null;

	public static byte[] LoadedExchangePrivateKey = null;

	public static byte[] LoadedExchangePublicKey = null;

	public static byte[] CurrentSharedSecret = null;

	public static void EnsureKeyPaths()
	{
		string dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), BTConst.myname);
		Directory.CreateDirectory(dir);
		if (string.IsNullOrEmpty(BTConst.Sign_Private_Key_Path))
			BTConst.Sign_Private_Key_Path = Path.Combine(dir, "private_sign.key");
		if (string.IsNullOrEmpty(BTConst.Sign_Public_Key_Path))
			BTConst.Sign_Public_Key_Path = Path.Combine(dir, "public_sign.key");
		if (string.IsNullOrEmpty(BTConst.Exchange_Private_Key_Path))
			BTConst.Exchange_Private_Key_Path = Path.Combine(dir, "private_exchange.key");
		if (string.IsNullOrEmpty(BTConst.Exchange_Public_Key_Path))
			BTConst.Exchange_Public_Key_Path = Path.Combine(dir, "public_exchange.key");
	}

	public static void GenerateAndSaveKeys(string password)
	{
		EnsureKeyPaths();
		SecureRandom random = new SecureRandom();
		Ed25519KeyPairGenerator signGen = new Ed25519KeyPairGenerator();
		signGen.Init(new Ed25519KeyGenerationParameters(random));
		AsymmetricCipherKeyPair sign = signGen.GenerateKeyPair();
		X25519KeyPairGenerator exchGen = new X25519KeyPairGenerator();
		exchGen.Init(new X25519KeyGenerationParameters(random));
		AsymmetricCipherKeyPair exch = exchGen.GenerateKeyPair();

		LoadedSignPrivateKey = ((Ed25519PrivateKeyParameters)sign.Private).GetEncoded();
		LoadedSignPublicKey = ((Ed25519PublicKeyParameters)sign.Public).GetEncoded();
		LoadedExchangePrivateKey = ((X25519PrivateKeyParameters)exch.Private).GetEncoded();
		LoadedExchangePublicKey = ((X25519PublicKeyParameters)exch.Public).GetEncoded();

		File.WriteAllBytes(BTConst.Sign_Private_Key_Path, EncryptPrivateKey(LoadedSignPrivateKey, password));
		File.WriteAllBytes(BTConst.Exchange_Private_Key_Path, EncryptPrivateKey(LoadedExchangePrivateKey, password));
		File.WriteAllBytes(BTConst.Sign_Public_Key_Path, LoadedSignPublicKey);
		File.WriteAllBytes(BTConst.Exchange_Public_Key_Path, LoadedExchangePublicKey);
	}

	public static bool UnlockSecureProfile(string password)
	{
		try
		{
			EnsureKeyPaths();
			byte[] signPriv = DecryptPrivateKey(File.ReadAllBytes(BTConst.Sign_Private_Key_Path), password);
			byte[] exchPriv = DecryptPrivateKey(File.ReadAllBytes(BTConst.Exchange_Private_Key_Path), password);
			byte[] signPub = File.ReadAllBytes(BTConst.Sign_Public_Key_Path);
			byte[] exchPub = File.ReadAllBytes(BTConst.Exchange_Public_Key_Path);
			if (signPriv.Length != 32 || exchPriv.Length != 32 || signPub.Length != 32 || exchPub.Length != 32)
				return false;
			LoadedSignPrivateKey = signPriv;
			LoadedExchangePrivateKey = exchPriv;
			LoadedSignPublicKey = signPub;
			LoadedExchangePublicKey = exchPub;
			return true;
		}
		catch
		{
			return false;
		}
	}

	public static void ResetSecureProfile()
	{
		EnsureKeyPaths();
		DeleteKey(BTConst.Sign_Private_Key_Path);
		DeleteKey(BTConst.Sign_Public_Key_Path);
		DeleteKey(BTConst.Exchange_Private_Key_Path);
		DeleteKey(BTConst.Exchange_Public_Key_Path);
		LoadedSignPrivateKey = null;
		LoadedSignPublicKey = null;
		LoadedExchangePrivateKey = null;
		LoadedExchangePublicKey = null;
		CurrentSharedSecret = null;
	}

	private static void DeleteKey(string path)
	{
		if (!string.IsNullOrEmpty(path) && File.Exists(path))
			File.Delete(path);
	}

	private static byte[] EncryptPrivateKey(byte[] data, string password)
	{
		byte[] body = new byte[4 + data.Length];
		Encoding.ASCII.GetBytes("KEY1").CopyTo(body, 0);
		Buffer.BlockCopy(data, 0, body, 4, data.Length);
		return Seal("BTK1", body, password);
	}

	private static byte[] DecryptPrivateKey(byte[] data, string password)
	{
		byte[] body = Open("BTK1", data, password);
		if (body.Length < 36 || body[0] != (byte)'K' || body[1] != (byte)'E' || body[2] != (byte)'Y' || body[3] != (byte)'1')
			throw new CryptographicException("key");
		byte[] key = new byte[body.Length - 4];
		Buffer.BlockCopy(body, 4, key, 0, key.Length);
		return key;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string EncryptAndSign(string plainText, byte[] sharedSecret)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool VerifyClientHello(string challenge, string signatureBase64, string publicKeyBase64)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	public static byte[] EncryptBackupFile(byte[] data, string password)
	{
		return Seal("BTB1", data, password);
	}

	public static byte[] DecryptBackupFile(byte[] data, string password)
	{
		return Open("BTB1", data, password);
	}

	static byte[] Seal(string magic, byte[] plain, string password)
	{
		byte[] salt = new byte[16];
		byte[] iv = new byte[16];
		using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
		{
			rng.GetBytes(salt);
			rng.GetBytes(iv);
		}
		byte[] key = new Rfc2898DeriveBytes(password, salt, 10000).GetBytes(32);
		byte[] cipher;
		using (Aes aes = Aes.Create())
		{
			aes.Key = key;
			aes.IV = iv;
			aes.Mode = CipherMode.CBC;
			aes.Padding = PaddingMode.PKCS7;
			using (ICryptoTransform enc = aes.CreateEncryptor())
				cipher = enc.TransformFinalBlock(plain, 0, plain.Length);
		}
		byte[] packed = new byte[4 + salt.Length + iv.Length + cipher.Length];
		Encoding.ASCII.GetBytes(magic).CopyTo(packed, 0);
		Buffer.BlockCopy(salt, 0, packed, 4, salt.Length);
		Buffer.BlockCopy(iv, 0, packed, 20, iv.Length);
		Buffer.BlockCopy(cipher, 0, packed, 36, cipher.Length);
		return packed;
	}

	static byte[] Open(string magic, byte[] packed, string password)
	{
		if (packed == null || packed.Length < 37 || Encoding.ASCII.GetString(packed, 0, 4) != magic)
			throw new CryptographicException("header");
		byte[] salt = new byte[16];
		byte[] iv = new byte[16];
		Buffer.BlockCopy(packed, 4, salt, 0, 16);
		Buffer.BlockCopy(packed, 20, iv, 0, 16);
		byte[] key = new Rfc2898DeriveBytes(password, salt, 10000).GetBytes(32);
		using (Aes aes = Aes.Create())
		{
			aes.Key = key;
			aes.IV = iv;
			aes.Mode = CipherMode.CBC;
			aes.Padding = PaddingMode.PKCS7;
			using (ICryptoTransform dec = aes.CreateDecryptor())
				return dec.TransformFinalBlock(packed, 36, packed.Length - 36);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool VerifyClientSecureMessage(string encryptedBase64, string sigBase64, string clientPublicKeyBase64)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string DecryptClientMessage(string encryptedBase64, byte[] sharedSecret)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}
}
