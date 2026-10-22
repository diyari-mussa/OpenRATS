using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace BTMOB.My;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class MyComputer : Computer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerHidden]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public MyComputer()
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}
}
