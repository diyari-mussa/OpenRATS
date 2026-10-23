# 32-bit PowerShell script: create a full minidump of the x86 Btmob process.
param([int]$TargetPid, [string]$OutFile)
Add-Type @'
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

public class MiniDumper
{
	[DllImport("dbghelp.dll", SetLastError = true)]
	static extern bool MiniDumpWriteDump(IntPtr hProcess, uint processId, SafeHandle hFile, uint dumpType, IntPtr expParam, IntPtr userStreamParam, IntPtr callbackParam);

	public static void Dump(int pid, string outFile)
	{
		Process proc = Process.GetProcessById(pid);
		FileStream fs = new FileStream(outFile, FileMode.Create, FileAccess.ReadWrite, FileShare.None);
		try
		{
			bool ok = MiniDumpWriteDump(proc.Handle, (uint)pid, fs.SafeFileHandle, 0x2, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero);
			if (!ok) throw new Exception("MiniDumpWriteDump failed: " + Marshal.GetLastWin32Error());
		}
		finally
		{
			fs.Dispose();
			proc.Dispose();
		}
	}
}
'@
[MiniDumper]::Dump($TargetPid, $OutFile)
Write-Output "dump created: $OutFile"
