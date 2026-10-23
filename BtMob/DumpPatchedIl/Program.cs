// Launch original x86 BTMob as a child (so we have PROCESS_VM_READ without
// elevation), wait for EXGuarder.Startup to patch stubs, then dump every
// MethodDef whose in-memory IL or RVA differs from disk.
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Threading;

class Program
{
	const uint LIST_MODULES_ALL = 0x03;
	const uint PROCESS_QUERY_INFORMATION = 0x0400;
	const uint PROCESS_VM_READ = 0x0010;
	const uint PROCESS_ALL_ACCESS = 0x001F0FFF;
	const uint MiniDumpWithFullMemory = 0x00000002;
	const uint DEBUG_ONLY_THIS_PROCESS = 0x00000002;
	const uint CREATE_UNICODE_ENVIRONMENT = 0x00000400;
	const uint DBG_CONTINUE = 0x00010002;

	[DllImport("kernel32.dll", SetLastError = true)]
	static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, out int lpNumberOfBytesRead);

	[DllImport("kernel32.dll", SetLastError = true)]
	static extern IntPtr OpenProcess(uint dwDesiredAccess, bool bInheritHandle, int dwProcessId);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	static extern bool CreateProcess(string lpApplicationName, string lpCommandLine, IntPtr lpProcessAttributes, IntPtr lpThreadAttributes, bool bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, ref STARTUPINFO lpStartupInfo, out PROCESS_INFORMATION lpProcessInformation);

	[DllImport("kernel32.dll", SetLastError = true)]
	static extern bool WaitForDebugEvent(ref DEBUG_EVENT lpDebugEvent, uint dwMilliseconds);

	[DllImport("kernel32.dll", SetLastError = true)]
	static extern bool ContinueDebugEvent(uint dwProcessId, uint dwThreadId, uint dwContinueStatus);

	[DllImport("kernel32.dll", SetLastError = true)]
	static extern bool DebugActiveProcessStop(int dwProcessId);

	[DllImport("kernel32.dll", SetLastError = true)]
	static extern bool CloseHandle(IntPtr hObject);

	[DllImport("psapi.dll", SetLastError = true)]
	static extern bool EnumProcessModulesEx(IntPtr hProcess, IntPtr[] lphModule, int cb, out int lpcbNeeded, uint dwFilterFlag);

	[DllImport("psapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	static extern uint GetModuleFileNameEx(IntPtr hProcess, IntPtr hModule, StringBuilder lpFilename, int nSize);

	[DllImport("dbghelp.dll", SetLastError = true)]
	static extern bool MiniDumpWriteDump(IntPtr hProcess, uint processId, SafeHandle hFile, uint dumpType, IntPtr expParam, IntPtr userStreamParam, IntPtr callbackParam);

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	struct STARTUPINFO
	{
		public int cb;
		public string lpReserved;
		public string lpDesktop;
		public string lpTitle;
		public int dwX, dwY, dwXSize, dwYSize, dwXCountChars, dwYCountChars, dwFillAttribute, dwFlags;
		public short wShowWindow, cbReserved2;
		public IntPtr lpReserved2, hStdInput, hStdOutput, hStdError;
	}

	[StructLayout(LayoutKind.Sequential)]
	struct PROCESS_INFORMATION
	{
		public IntPtr hProcess;
		public IntPtr hThread;
		public int dwProcessId;
		public int dwThreadId;
	}

	[StructLayout(LayoutKind.Sequential)]
	struct DEBUG_EVENT
	{
		public uint dwDebugEventCode;
		public uint dwProcessId;
		public uint dwThreadId;
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 160)]
		public byte[] extra;
	}

	static readonly byte[] StubIl = new byte[] { 0x72, 0x01, 0x00, 0x00, 0x70, 0x73, 0x9B, 0x43, 0x00, 0x0A, 0x7A };

	static int Main(string[] args)
	{
		string exePath = args.Length > 0
			? args[0]
			: @"D:\MSI E Drive\Programming Projects\Other Projects\REA\OpenRATS\_Analysis\BtMob\SafeLab\BTMob 4.6.1 Fixed\BTMob.exe";
		string outDir = args.Length > 1
			? args[1]
			: @"D:\MSI E Drive\Programming Projects\Other Projects\REA\OpenRATS\_Analysis\BtMob\patched-il";
		Directory.CreateDirectory(outDir);

		byte[] disk = LoadExeBytes(exePath);
		if (disk == null || disk.Length < 64)
		{
			Console.WriteLine("could not read exe bytes: " + exePath);
			return 1;
		}
		var diskMethods = ReadDiskMethods(disk);
		Console.WriteLine($"disk methods with bodies: {diskMethods.Count}");
		int stubCount = diskMethods.Count(m => m.IsStub);
		Console.WriteLine($"disk stub methods (AV throw): {stubCount}");

		Environment.SetEnvironmentVariable("__COMPAT_LAYER", "RunAsInvoker");
		var created = new ManualResetEvent(false);
		var stopPump = new ManualResetEvent(false);
		PROCESS_INFORMATION pi = default;
		int createErr = 0;
		var dbgThread = new Thread(() =>
		{
			var si = new STARTUPINFO { cb = Marshal.SizeOf<STARTUPINFO>() };
			bool ok = CreateProcess(
				exePath,
				"\"" + exePath + "\"",
				IntPtr.Zero, IntPtr.Zero, false,
				DEBUG_ONLY_THIS_PROCESS | CREATE_UNICODE_ENVIRONMENT,
				IntPtr.Zero,
				Path.GetDirectoryName(exePath),
				ref si, out pi);
			if (!ok)
			{
				createErr = Marshal.GetLastWin32Error();
				created.Set();
				return;
			}
			created.Set();
			PumpDebugEvents(stopPump, pi.dwProcessId);
		}) { IsBackground = true };
		dbgThread.Start();
		if (!created.WaitOne(15000))
		{
			Console.WriteLine("CreateProcess thread timed out");
			return 1;
		}
		if (pi.dwProcessId == 0)
		{
			Console.WriteLine($"CreateProcess(DEBUG) failed win32={createErr}");
			return 1;
		}
		Console.WriteLine($"debug-launched pid {pi.dwProcessId}");

		Process child = Process.GetProcessById(pi.dwProcessId);
		WaitForWindow(child, 20000);
		Thread.Sleep(2500);
		child.Refresh();
		if (child.HasExited)
		{
			Console.WriteLine("child exited before dump");
			return 2;
		}
		Console.WriteLine($"window='{child.MainWindowTitle}' hwnd=0x{child.MainWindowHandle.ToInt64():X}");

		IntPtr hProcess = pi.hProcess;
		IntPtr moduleBase = FindModuleBase(hProcess, Path.GetFileName(exePath));
		if (moduleBase == IntPtr.Zero)
		{
			Console.WriteLine("could not find BTMob.exe module in process");
			try { child.Kill(true); } catch { }
			return 3;
		}
		Console.WriteLine($"module base: 0x{moduleBase.ToInt64():X}");

		string dumpPath = Path.Combine(outDir, "btmob-live.dmp");
		try
		{
			using FileStream fs = new FileStream(dumpPath, FileMode.Create, FileAccess.ReadWrite, FileShare.Read);
			bool ok = MiniDumpWriteDump(hProcess, (uint)child.Id, fs.SafeFileHandle, MiniDumpWithFullMemory, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero);
			int err = Marshal.GetLastWin32Error();
			Console.WriteLine(ok
				? $"minidump: {dumpPath} ({fs.Length} bytes)"
				: $"minidump failed win32={err}");
		}
		catch (Exception ex)
		{
			Console.WriteLine("minidump exception: " + ex.Message);
		}

		var results = new List<object>();
		int patched = 0, unchanged = 0, unread = 0, rvaChanged = 0;
		foreach (DiskMethod m in diskMethods)
		{
			if (m.Rva == 0) continue;
			byte[] memIl = ReadIl(hProcess, moduleBase, m.Rva, Math.Max(m.Il.Length + 16, 64));
			if (memIl == null)
			{
				unread++;
				continue;
			}
			bool same = memIl.Take(m.Il.Length).SequenceEqual(m.Il);
			if (same)
			{
				unchanged++;
				continue;
			}
			patched++;
			int memSize = DecodeIlSize(memIl);
			byte[] body = memIl.Take(Math.Min(memSize > 0 ? memSize : m.Il.Length + 32, memIl.Length)).ToArray();
			results.Add(new
			{
				type = m.Type,
				name = m.Name,
				token = $"0x{m.Token:X8}",
				diskRva = $"0x{m.Rva:X}",
				diskIl = Convert.ToHexString(m.Il),
				memIl = Convert.ToHexString(body),
				diskLen = m.Il.Length,
				memLen = body.Length,
				wasStub = m.IsStub,
			});
			if (m.IsStub)
				rvaChanged++; // count stub-that-changed
		}

		string jsonPath = Path.Combine(outDir, "patched-methods.json");
		File.WriteAllText(jsonPath, JsonSerializer.Serialize(new
		{
			pid = child.Id,
			moduleBase = $"0x{moduleBase.ToInt64():X}",
			window = child.MainWindowTitle,
			patched,
			unchanged,
			unread,
			stubPatched = results.Count(o => true),
			methods = results,
		}, new JsonSerializerOptions { WriteIndented = true }));
		Console.WriteLine($"patched={patched} unchanged={unchanged} unread={unread}");
		Console.WriteLine($"wrote {jsonPath}");

		// Also dump first 64 bytes at the shared stub RVA 0x2084 for a sanity check.
		byte[] probe = new byte[32];
		int nread;
		ReadProcessMemory(hProcess, moduleBase + 0x2084, probe, probe.Length, out nread);
		Console.WriteLine($"mem @RVA 0x2084 ({nread} bytes): {Convert.ToHexString(probe)}");
		int fileOff = RvaToFileOffset(disk, 0x2084);
		if (fileOff >= 0)
			Console.WriteLine($"disk@RVA 0x2084: {Convert.ToHexString(disk, fileOff, 16)}");

		TryKill(child);
		return patched > 0 ? 0 : 4;
	}

	static void TryKill(Process p)
	{
		try { if (!p.HasExited) p.Kill(true); } catch { }
	}

	static void WaitForWindow(Process child, int timeoutMs)
	{
		int steps = Math.Max(1, timeoutMs / 500);
		for (int i = 0; i < steps; i++)
		{
			Thread.Sleep(500);
			try { child.Refresh(); } catch { return; }
			if (child.HasExited)
			{
				Console.WriteLine($"child exited with {child.ExitCode} after {i * 500}ms");
				return;
			}
			if (!string.IsNullOrEmpty(child.MainWindowTitle) || child.MainWindowHandle != IntPtr.Zero)
			{
				Console.WriteLine($"window after {i * 500}ms: '{child.MainWindowTitle}' hwnd=0x{child.MainWindowHandle.ToInt64():X}");
				return;
			}
		}
		Console.WriteLine("no window within timeout");
	}

	static void PumpDebugEvents(WaitHandle stop, int pid)
	{
		var ev = new DEBUG_EVENT { extra = new byte[160] };
		while (!stop.WaitOne(0))
		{
			if (!WaitForDebugEvent(ref ev, 200))
				continue;
			if (ev.dwDebugEventCode == 5) // EXIT_PROCESS_DEBUG_EVENT
			{
				ContinueDebugEvent(ev.dwProcessId, ev.dwThreadId, DBG_CONTINUE);
				break;
			}
			ContinueDebugEvent(ev.dwProcessId, ev.dwThreadId, DBG_CONTINUE);
		}
		try { DebugActiveProcessStop(pid); } catch { }
	}

	static IntPtr FindModuleBase(IntPtr hProcess, string fileName)
	{
		int needed;
		EnumProcessModulesEx(hProcess, Array.Empty<IntPtr>(), 0, out needed, LIST_MODULES_ALL);
		if (needed <= 0)
		{
			int err = Marshal.GetLastWin32Error();
			Console.WriteLine($"EnumProcessModulesEx size failed win32={err}");
			return IntPtr.Zero;
		}
		var mods = new IntPtr[needed / IntPtr.Size];
		if (!EnumProcessModulesEx(hProcess, mods, needed, out needed, LIST_MODULES_ALL))
		{
			Console.WriteLine($"EnumProcessModulesEx failed win32={Marshal.GetLastWin32Error()}");
			return IntPtr.Zero;
		}
		var sb = new StringBuilder(1024);
		foreach (IntPtr m in mods)
		{
			if (m == IntPtr.Zero) continue;
			sb.Clear();
			GetModuleFileNameEx(hProcess, m, sb, sb.Capacity);
			string path = sb.ToString();
			if (path.EndsWith(fileName, StringComparison.OrdinalIgnoreCase) ||
			    Path.GetFileName(path).Equals(fileName, StringComparison.OrdinalIgnoreCase))
				return m;
		}
		Console.WriteLine("modules seen:");
		foreach (IntPtr m in mods.Take(12))
		{
			if (m == IntPtr.Zero) continue;
			sb.Clear();
			GetModuleFileNameEx(hProcess, m, sb, sb.Capacity);
			Console.WriteLine($"  0x{m.ToInt64():X} {sb}");
		}
		return IntPtr.Zero;
	}

	static byte[] ReadIl(IntPtr hProcess, IntPtr moduleBase, int rva, int want)
	{
		var buf = new byte[want];
		int n;
		if (!ReadProcessMemory(hProcess, moduleBase + rva, buf, buf.Length, out n) || n < 4)
			return null;
		if (n < buf.Length) Array.Resize(ref buf, n);
		return buf;
	}

	static int DecodeIlSize(byte[] il)
	{
		if (il == null || il.Length == 0) return 0;
		byte flags = il[0];
		if ((flags & 3) == 2) // tiny
			return (flags >> 2) + 1;
		if ((flags & 3) == 3 && il.Length >= 12) // fat
		{
			int codeSize = BitConverter.ToInt32(il, 4);
			int header = 12;
			int more = (flags & 0x08) != 0 ? 0 : 0; // EH sections follow; header.Size in high nibble of flags word
			int headerSize = (BitConverter.ToUInt16(il, 0) >> 12) * 4;
			if (headerSize <= 0) headerSize = 12;
			return headerSize + codeSize;
		}
		return il.Length;
	}

	class DiskMethod
	{
		public string Type;
		public string Name;
		public int Token;
		public int Rva;
		public byte[] Il;
		public bool IsStub;
	}

	static byte[] LoadExeBytes(string path)
	{
		try
		{
			return File.ReadAllBytes(path);
		}
		catch (Exception ex)
		{
			Console.WriteLine("File.ReadAllBytes failed: " + ex.Message);
		}
		string rar = @"D:\MSI E Drive\Programming Projects\Other Projects\REA\OpenRATS\_Analysis\BtMob\BTMob_4.6.1_Fixed.bin";
		string seven = @"D:\MSI E Drive\Programming Projects\Other Projects\REA\For Reversing\cratest\Mods\Cobra\Cobra\res\Lib\7z.exe";
		if (!File.Exists(rar) || !File.Exists(seven))
			return null;
		Console.WriteLine("extracting BTMob.exe from evidence RAR via 7z -so");
		var psi = new ProcessStartInfo(seven)
		{
			Arguments = "e -so \"" + rar + "\" \"BTMob 4.6.1 Fixed\\Btmob.exe\"",
			UseShellExecute = false,
			RedirectStandardOutput = true,
			RedirectStandardError = true,
			CreateNoWindow = true,
		};
		using Process p = Process.Start(psi);
		using MemoryStream ms = new MemoryStream();
		p.StandardOutput.BaseStream.CopyTo(ms);
		p.WaitForExit(60000);
		Console.WriteLine($"7z exit={p.ExitCode} extracted={ms.Length}");
		if (ms.Length < 1000000) return null;
		byte[] bytes = ms.ToArray();
		try
		{
			Directory.CreateDirectory(Path.GetDirectoryName(path));
			File.WriteAllBytes(path, bytes);
			Console.WriteLine("wrote " + path);
		}
		catch (Exception ex)
		{
			Console.WriteLine("rewrite exe failed (Defender?): " + ex.Message);
		}
		return bytes;
	}

	static List<DiskMethod> ReadDiskMethods(byte[] peBytes)
	{
		var list = new List<DiskMethod>();
		using var ms = new MemoryStream(peBytes, writable: false);
		using PEReader pe = new PEReader(ms);
		MetadataReader md = pe.GetMetadataReader();
		foreach (TypeDefinitionHandle th in md.TypeDefinitions)
		{
			TypeDefinition t = md.GetTypeDefinition(th);
			string tn = md.GetString(t.Name);
			string ns = md.GetString(t.Namespace);
			string full = string.IsNullOrEmpty(ns) ? tn : ns + "." + tn;
			foreach (MethodDefinitionHandle mh in t.GetMethods())
			{
				MethodDefinition m = md.GetMethodDefinition(mh);
				int rva = m.RelativeVirtualAddress;
				if (rva == 0) continue;
				MethodBodyBlock body;
				try { body = pe.GetMethodBody(rva); }
				catch { continue; }
				byte[] il = body.GetILBytes();
				if (il == null) continue;
				bool stub = il.Length == 11 && il.AsSpan().SequenceEqual(StubIl);
				list.Add(new DiskMethod
				{
					Type = full,
					Name = md.GetString(m.Name),
					Token = MetadataTokens.GetToken(mh),
					Rva = rva,
					Il = il,
					IsStub = stub,
				});
			}
		}
		return list;
	}

	static int RvaToFileOffset(byte[] pe, int rva)
	{
		int peOff = BitConverter.ToInt32(pe, 0x3C);
		int coff = peOff + 4;
		int sections = BitConverter.ToInt16(pe, coff + 2);
		int optSize = BitConverter.ToInt16(pe, coff + 16);
		int secOff = coff + 20 + optSize;
		for (int i = 0; i < sections; i++)
		{
			int o = secOff + i * 40;
			int va = BitConverter.ToInt32(pe, o + 12);
			int vsz = BitConverter.ToInt32(pe, o + 8);
			int raw = BitConverter.ToInt32(pe, o + 20);
			int rsz = BitConverter.ToInt32(pe, o + 16);
			if (rva >= va && rva < va + Math.Max(vsz, rsz))
				return raw + (rva - va);
		}
		return -1;
	}
}
