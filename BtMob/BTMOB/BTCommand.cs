using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace BTMOB;

[StandardModule]
internal sealed class BTCommand
{
	public static string SPL_SOCKET = EXGuarder._67570669;

	public static string SPL_DATA = EXGuarder._154A6463;

	public static string SPL_LINE = EXGuarder._7546526E;

	public static string SPL_ARRAY = EXGuarder._202E1444;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string FormatCommand(string command, object data)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<Dictionary<string, object>> ParsefilesData(string input)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}
}
