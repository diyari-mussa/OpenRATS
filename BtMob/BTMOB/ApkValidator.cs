using System;
using System.Runtime.CompilerServices;

namespace BTMOB;

public class ApkValidator
{
	public class ApkValidationResult
	{
		public bool IsValid { get; set; }

		public string Message { get; set; }
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ApkValidator()
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ApkValidationResult ValidateApk(string filePath)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}
}
