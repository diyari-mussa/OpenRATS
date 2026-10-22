using System;
using System.Runtime.CompilerServices;
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void GenerateAndSaveKeys(string password)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool UnlockSecureProfile(string password)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ResetSecureProfile()
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void DeleteKey(string path)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static byte[] EncryptPrivateKey(byte[] data, string password)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static byte[] DecryptPrivateKey(byte[] data, string password)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] EncryptBackupFile(byte[] data, string password)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] DecryptBackupFile(byte[] data, string password)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
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
