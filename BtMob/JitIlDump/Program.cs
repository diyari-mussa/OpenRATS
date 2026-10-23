// Debug-launch original BTMob and steal IL from 32-bit clrjit!compileMethod
// (EXGuarder feeds real IL to the JIT while metadata stays stubbed).
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using System.Text;
using System.Text.Json;
using System.Threading;

class Program
{
	const uint DEBUG_ONLY_THIS_PROCESS = 0x00000002;
	const uint CREATE_UNICODE_ENVIRONMENT = 0x00000400;
	const uint DBG_CONTINUE = 0x00010002;
	const uint DBG_EXCEPTION_NOT_HANDLED = 0x80010001;
	const uint STATUS_BREAKPOINT = 0x80000003;
	const uint STATUS_SINGLE_STEP = 0x80000004;
	const uint THREAD_ALL_ACCESS = 0x1F03FF;
	const uint CONTEXT_AMD64_CONTROL_INTEGER = 0x00100003;
	const int CREATE_PROCESS_DEBUG_EVENT = 3;
	const int CREATE_THREAD_DEBUG_EVENT = 2;
	const int EXIT_PROCESS_DEBUG_EVENT = 5;
	const int LOAD_DLL_DEBUG_EVENT = 6;
	const int EXCEPTION_DEBUG_EVENT = 1;

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	static extern bool CreateProcess(string lpApplicationName, string lpCommandLine, IntPtr a, IntPtr b, bool inherit, uint flags, IntPtr env, string dir, ref STARTUPINFO si, out PROCESS_INFORMATION pi);

	[DllImport("kernel32.dll", SetLastError = true)]
	static extern bool WaitForDebugEvent(IntPtr lpDebugEvent, uint dwMilliseconds);

	[DllImport("kernel32.dll", SetLastError = true)]
	static extern bool ContinueDebugEvent(uint pid, uint tid, uint status);

	[DllImport("kernel32.dll", SetLastError = true)]
	static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr addr, byte[] buf, int size, out int read);

	[DllImport("kernel32.dll", SetLastError = true)]
	static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr addr, byte[] buf, int size, out int written);

	[DllImport("kernel32.dll", SetLastError = true)]
	static extern bool FlushInstructionCache(IntPtr hProcess, IntPtr addr, UIntPtr size);

	[DllImport("kernel32.dll", SetLastError = true)]
	static extern bool GetThreadContext(IntPtr hThread, IntPtr lpContext);

	[DllImport("kernel32.dll", SetLastError = true)]
	static extern bool SetThreadContext(IntPtr hThread, IntPtr lpContext);

	[DllImport("kernel32.dll", SetLastError = true)]
	static extern IntPtr OpenThread(uint access, bool inherit, uint tid);

	[DllImport("kernel32.dll", SetLastError = true)]
	static extern bool CloseHandle(IntPtr h);

	[DllImport("kernel32.dll", SetLastError = true)]
	static extern bool DebugActiveProcessStop(int pid);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	static extern uint GetFinalPathNameByHandle(IntPtr hFile, StringBuilder buf, int cap, uint flags);

	[DllImport("kernel32.dll", SetLastError = true)]
	static extern bool IsWow64Process(IntPtr hProcess, out bool wow64);

	[DllImport("dbghelp.dll", SetLastError = true)]
	static extern bool MiniDumpWriteDump(IntPtr hProcess, uint pid, SafeHandle hFile, uint dumpType, IntPtr exp, IntPtr user, IntPtr cb);

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	struct STARTUPINFO
	{
		public int cb;
		public string lpReserved, lpDesktop, lpTitle;
		public int dwX, dwY, dwXSize, dwYSize, dwXCountChars, dwYCountChars, dwFillAttribute, dwFlags;
		public short wShowWindow, cbReserved2;
		public IntPtr lpReserved2, hStdInput, hStdOutput, hStdError;
	}

	[StructLayout(LayoutKind.Sequential)]
	struct PROCESS_INFORMATION
	{
		public IntPtr hProcess, hThread;
		public int dwProcessId, dwThreadId;
	}

	sealed class NativeCtx : IDisposable
	{
		public readonly IntPtr Raw;
		readonly IntPtr _alloc;
		public NativeCtx()
		{
			_alloc = Marshal.AllocHGlobal(1232 + 16);
			long a = (_alloc.ToInt64() + 15) & ~15L;
			Raw = new IntPtr(a);
			for (int i = 0; i < 1232; i++) Marshal.WriteByte(Raw, i, 0);
			Marshal.WriteInt32(Raw, 48, (int)CONTEXT_AMD64_CONTROL_INTEGER);
		}
		public uint EFlags { get => (uint)Marshal.ReadInt32(Raw, 68); set => Marshal.WriteInt32(Raw, 68, (int)value); }
		public ulong Rax { get => (ulong)Marshal.ReadInt64(Raw, 120); }
		public ulong R8 { get => (ulong)Marshal.ReadInt64(Raw, 184); }
		public ulong Rsp { get => (ulong)Marshal.ReadInt64(Raw, 152); }
		public ulong Rip { get => (ulong)Marshal.ReadInt64(Raw, 248); set => Marshal.WriteInt64(Raw, 248, (long)value); }
		public void Dispose() => Marshal.FreeHGlobal(_alloc);
	}

	class Capture
	{
		public ulong Ftn;
		public int Size;
		public int MaxStack;
		public int EhCount;
		public string Hex;
	}

	static IntPtr _proc;
	static readonly Dictionary<uint, IntPtr> _threads = new();
	static readonly List<Capture> _captures = new();
	static readonly HashSet<ulong> _seenFtn = new();
	static IntPtr _getJit, _compileMethod, _getJitRet;
	static byte _getJitOrig, _compileOrig, _getJitRetOrig;
	static bool _armedCompile, _needReplantCompile, _gotJit;
	static string _outDir;

	static int Main(string[] args)
	{
		string exe = args.Length > 0
			? args[0]
			: @"D:\MSI E Drive\Programming Projects\Other Projects\REA\OpenRATS\_Analysis\BtMob\SafeLab\BTMob 4.6.1 Fixed\BTMob.exe";
		_outDir = args.Length > 1
			? args[1]
			: @"D:\MSI E Drive\Programming Projects\Other Projects\REA\OpenRATS\_Analysis\BtMob\patched-il\jit-il";
		Directory.CreateDirectory(_outDir);

		Environment.SetEnvironmentVariable("__COMPAT_LAYER", "RunAsInvoker");
		var si = new STARTUPINFO { cb = Marshal.SizeOf<STARTUPINFO>() };
		if (!CreateProcess(exe, "\"" + exe + "\"", IntPtr.Zero, IntPtr.Zero, false,
			DEBUG_ONLY_THIS_PROCESS | CREATE_UNICODE_ENVIRONMENT, IntPtr.Zero,
			Path.GetDirectoryName(exe), ref si, out var pi))
		{
			Console.WriteLine("CreateProcess failed " + Marshal.GetLastWin32Error());
			return 1;
		}
		_proc = pi.hProcess;
		_threads[(uint)pi.dwThreadId] = pi.hThread;
		IsWow64Process(_proc, out bool wow);
		Console.WriteLine($"pid={pi.dwProcessId} wow64={wow} (AnyCPU 64-bit JIT expected)");

		IntPtr ev = Marshal.AllocHGlobal(256);
		var sw = Stopwatch.StartNew();
		bool windowed = false;
		const int maxMs = 25000;
		try
		{
			while (sw.ElapsedMilliseconds < maxMs)
			{
				if (WaitForDebugEvent(ev, 200))
				{
					uint code = (uint)Marshal.ReadInt32(ev, 0);
					uint pid = (uint)Marshal.ReadInt32(ev, 4);
					uint tid = (uint)Marshal.ReadInt32(ev, 8);
					uint cont = DBG_CONTINUE;
					try
					{
						HandleEvent(ev, code, tid, ref cont);
					}
					catch (Exception ex)
					{
						Console.WriteLine("handler: " + ex.Message);
					}
					ContinueDebugEvent(pid, tid, cont);
					if (code == EXIT_PROCESS_DEBUG_EVENT)
						break;
				}
				if (!windowed)
				{
					try
					{
						var p = Process.GetProcessById(pi.dwProcessId);
						p.Refresh();
						if (!string.IsNullOrEmpty(p.MainWindowTitle))
						{
							windowed = true;
							Console.WriteLine($"window '{p.MainWindowTitle}' at {sw.ElapsedMilliseconds}ms; capturing 5s more");
							// extend a bit after UI appears
						}
					}
					catch { }
				}
				else if (sw.ElapsedMilliseconds > 16000)
					break;
			}

			string dmp = Path.Combine(Path.GetDirectoryName(_outDir), "btmob-jit.dmp");
			try
			{
				using var fs = new FileStream(dmp, FileMode.Create, FileAccess.Write);
				bool dumped = MiniDumpWriteDump(_proc, (uint)pi.dwProcessId, fs.SafeFileHandle, 0x00000002, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero);
				Console.WriteLine(dumped ? $"minidump {dmp} ({fs.Length} bytes)" : "MiniDumpWriteDump fail " + Marshal.GetLastWin32Error());
			}
			catch (Exception ex) { Console.WriteLine("dump: " + ex.Message); }
		}
		finally
		{
			try { DebugActiveProcessStop(pi.dwProcessId); } catch { }
			try { Process.GetProcessById(pi.dwProcessId).Kill(true); } catch { }
			Marshal.FreeHGlobal(ev);
		}

		string json = Path.Combine(_outDir, "captures.json");
		File.WriteAllText(json, JsonSerializer.Serialize(_captures, new JsonSerializerOptions { WriteIndented = true, IncludeFields = true }));
		Console.WriteLine($"captured {_captures.Count} compileMethod IL bodies -> {json}");
		int big = _captures.Count(c => c.Size > 11);
		Console.WriteLine($"bodies larger than stub: {big}");
		return 0;
	}

	static void HandleEvent(IntPtr ev, uint code, uint tid, ref uint cont)
	{
		const int union = 16; // x64 DEBUG_EVENT union offset
		if (code == CREATE_THREAD_DEBUG_EVENT)
		{
			_threads[tid] = Marshal.ReadIntPtr(ev, union + 0);
			return;
		}
		if (code == CREATE_PROCESS_DEBUG_EVENT)
		{
			_threads[tid] = Marshal.ReadIntPtr(ev, union + IntPtr.Size * 2);
			return;
		}
		if (code == LOAD_DLL_DEBUG_EVENT)
		{
			IntPtr hFile = Marshal.ReadIntPtr(ev, union + 0);
			IntPtr baseAddr = Marshal.ReadIntPtr(ev, union + IntPtr.Size);
			string path = PathFromHandle(hFile);
			if (path.EndsWith("clrjit.dll", StringComparison.OrdinalIgnoreCase) ||
			    path.EndsWith("mscorjit.dll", StringComparison.OrdinalIgnoreCase))
			{
				Console.WriteLine($"loaded {path} @ 0x{baseAddr.ToInt64():X}");
				uint rva = FindExportRva(path, "getJit");
				if (rva == 0)
				{
					Console.WriteLine("getJit export not found");
					return;
				}
				_getJit = new IntPtr(baseAddr.ToInt64() + rva);
				_getJitOrig = ReadByte(_getJit);
				WriteByte(_getJit, 0xCC);
				Console.WriteLine($"BP getJit=0x{_getJit.ToInt64():X} orig=0x{_getJitOrig:X2}");
			}
			return;
		}
		if (code != EXCEPTION_DEBUG_EVENT)
			return;

		uint excCode = (uint)Marshal.ReadInt32(ev, union + 0);
		IntPtr excAddr = Marshal.ReadIntPtr(ev, union + 8 + IntPtr.Size); // code, flags, rec*, addr
		// EXCEPTION_RECORD x64: ExceptionCode+0, Flags+4, pad, ExceptionRecord+8, ExceptionAddress+16
		excAddr = Marshal.ReadIntPtr(ev, union + 16);

		if (excCode == STATUS_SINGLE_STEP)
		{
			if (_needReplantCompile && _compileMethod != IntPtr.Zero)
			{
				WriteByte(_compileMethod, 0xCC);
				_needReplantCompile = false;
			}
			return;
		}
		if (excCode != STATUS_BREAKPOINT)
		{
			cont = DBG_EXCEPTION_NOT_HANDLED;
			return;
		}

		IntPtr hThread = GetThread(tid);
		if (hThread == IntPtr.Zero)
		{
			cont = DBG_EXCEPTION_NOT_HANDLED;
			return;
		}
		using var ctx = new NativeCtx();
		if (!GetThreadContext(hThread, ctx.Raw))
		{
			// debug-event handles are sometimes not enough; reopen
			var opened = OpenThread(THREAD_ALL_ACCESS, false, tid);
			bool ok = opened != IntPtr.Zero && GetThreadContext(opened, ctx.Raw);
			if (opened != IntPtr.Zero) { _threads[tid] = opened; hThread = opened; }
			if (!ok)
			{
				Console.WriteLine("GetThreadContext fail " + Marshal.GetLastWin32Error() + " tid=" + tid);
				cont = DBG_EXCEPTION_NOT_HANDLED;
				return;
			}
		}

		ulong rip = ctx.Rip;
		ulong hit = MatchBp(rip, _getJit, _getJitRet, _compileMethod);
		if (hit == 0)
		{
			cont = DBG_EXCEPTION_NOT_HANDLED;
			return;
		}

		if (_getJit != IntPtr.Zero && hit == (ulong)_getJit.ToInt64())
		{
			WriteByte(_getJit, _getJitOrig);
			ctx.Rip = hit;
			ulong ret = ReadU64(new IntPtr((long)ctx.Rsp));
			_getJitRet = new IntPtr((long)ret);
			_getJitRetOrig = ReadByte(_getJitRet);
			WriteByte(_getJitRet, 0xCC);
			SetThreadContext(hThread, ctx.Raw);
			Console.WriteLine($"getJit hit, ret BP @ 0x{ret:X}");
			return;
		}

		if (_getJitRet != IntPtr.Zero && hit == (ulong)_getJitRet.ToInt64())
		{
			WriteByte(_getJitRet, _getJitRetOrig);
			ctx.Rip = hit;
			ulong jit = ctx.Rax;
			ulong vtbl = ReadU64(new IntPtr((long)jit));
			ulong compile = ReadU64(new IntPtr((long)vtbl));
			_compileMethod = new IntPtr((long)compile);
			_compileOrig = ReadByte(_compileMethod);
			WriteByte(_compileMethod, 0xCC);
			_armedCompile = true;
			_gotJit = true;
			SetThreadContext(hThread, ctx.Raw);
			Console.WriteLine($"ICorJitCompiler=0x{jit:X} compileMethod=0x{compile:X}");
			return;
		}

		if (_armedCompile && _compileMethod != IntPtr.Zero && hit == (ulong)_compileMethod.ToInt64())
		{
			WriteByte(_compileMethod, _compileOrig);
			ctx.Rip = hit;
			try { StealIl(ctx); }
			catch (Exception ex) { Console.WriteLine("steal: " + ex.Message); }
			ctx.EFlags |= 0x100;
			_needReplantCompile = true;
			SetThreadContext(hThread, ctx.Raw);
			return;
		}
	}

	static ulong MatchBp(ulong rip, params IntPtr[] addrs)
	{
		foreach (var a in addrs)
		{
			if (a == IntPtr.Zero) continue;
			ulong v = (ulong)a.ToInt64();
			if (rip == v || rip == v + 1) return v;
		}
		return 0;
	}

	static void StealIl(NativeCtx ctx)
	{
		// x64: rcx=this, rdx=ICorJitInfo*, r8=CORINFO_METHOD_INFO*
		ulong info = ctx.R8;
		if (info == 0) return;
		ulong ftn = ReadU64(new IntPtr((long)info + 0));
		ulong ilPtr = ReadU64(new IntPtr((long)info + 16));
		uint ilSize = ReadU32(new IntPtr((long)info + 24));
		int maxStack = (int)ReadU32(new IntPtr((long)info + 28));
		int ehCount = (int)ReadU32(new IntPtr((long)info + 32));
		if (ilPtr == 0 || ilSize == 0 || ilSize > 2_000_000) return;
		if (!_seenFtn.Add(ftn)) return;
		byte[] il = ReadBytes(new IntPtr((long)ilPtr), (int)ilSize);
		if (il == null) return;
		_captures.Add(new Capture { Ftn = ftn, Size = (int)ilSize, MaxStack = maxStack, EhCount = ehCount, Hex = Convert.ToHexString(il) });
		if (_captures.Count <= 8 || ilSize > 200)
			Console.WriteLine($"  IL ftn=0x{ftn:X} size={ilSize}");
		File.WriteAllBytes(Path.Combine(_outDir, $"ftn_{ftn:X16}.bin"), il);
	}

	static IntPtr GetThread(uint tid)
	{
		if (_threads.TryGetValue(tid, out IntPtr h) && h != IntPtr.Zero)
			return h;
		h = OpenThread(THREAD_ALL_ACCESS, false, tid);
		if (h != IntPtr.Zero) _threads[tid] = h;
		return h;
	}

	static string PathFromHandle(IntPtr hFile)
	{
		if (hFile == IntPtr.Zero) return "";
		var sb = new StringBuilder(1024);
		uint n = GetFinalPathNameByHandle(hFile, sb, sb.Capacity, 0);
		string p = n > 0 ? sb.ToString() : "";
		if (p.StartsWith(@"\\?\")) p = p.Substring(4);
		return p;
	}

	static byte ReadByte(IntPtr addr)
	{
		byte[] b = new byte[1];
		ReadProcessMemory(_proc, addr, b, 1, out _);
		return b[0];
	}

	static void WriteByte(IntPtr addr, byte v)
	{
		WriteProcessMemory(_proc, addr, new[] { v }, 1, out _);
		FlushInstructionCache(_proc, addr, (UIntPtr)1);
	}

	static uint ReadU32(IntPtr addr)
	{
		byte[] b = new byte[4];
		ReadProcessMemory(_proc, addr, b, 4, out int n);
		return n == 4 ? BitConverter.ToUInt32(b, 0) : 0;
	}

	static ulong ReadU64(IntPtr addr)
	{
		byte[] b = new byte[8];
		ReadProcessMemory(_proc, addr, b, 8, out int n);
		return n == 8 ? BitConverter.ToUInt64(b, 0) : 0;
	}

	static byte[] ReadBytes(IntPtr addr, int len)
	{
		byte[] b = new byte[len];
		if (!ReadProcessMemory(_proc, addr, b, len, out int n) || n != len)
			return null;
		return b;
	}

	static uint FindExportRva(string pePath, string name)
	{
		byte[] pe = File.ReadAllBytes(pePath);
		int peOff = BitConverter.ToInt32(pe, 0x3C);
		int magic = BitConverter.ToUInt16(pe, peOff + 24);
		int opt = peOff + 24;
		int dirOff = magic == 0x20B ? opt + 112 : opt + 96; // 64 vs 32 optional
		int expRva = BitConverter.ToInt32(pe, dirOff);
		if (expRva == 0) return 0;
		int expOff = RvaToOff(pe, peOff, expRva);
		int names = BitConverter.ToInt32(pe, expOff + 24);
		int namesRva = BitConverter.ToInt32(pe, expOff + 32);
		int ordsRva = BitConverter.ToInt32(pe, expOff + 36);
		int funcsRva = BitConverter.ToInt32(pe, expOff + 28);
		int namesOff = RvaToOff(pe, peOff, namesRva);
		int ordsOff = RvaToOff(pe, peOff, ordsRva);
		int funcsOff = RvaToOff(pe, peOff, funcsRva);
		for (int i = 0; i < names; i++)
		{
			int nrva = BitConverter.ToInt32(pe, namesOff + i * 4);
			int noff = RvaToOff(pe, peOff, nrva);
			string n = ReadAsciiZ(pe, noff);
			if (!n.Equals(name, StringComparison.Ordinal)) continue;
			ushort ord = BitConverter.ToUInt16(pe, ordsOff + i * 2);
			return (uint)BitConverter.ToInt32(pe, funcsOff + ord * 4);
		}
		return 0;
	}

	static int RvaToOff(byte[] pe, int peOff, int rva)
	{
		int sections = BitConverter.ToInt16(pe, peOff + 6);
		int optSize = BitConverter.ToInt16(pe, peOff + 20);
		int sec = peOff + 24 + optSize;
		for (int i = 0; i < sections; i++)
		{
			int o = sec + i * 40;
			int va = BitConverter.ToInt32(pe, o + 12);
			int vsz = BitConverter.ToInt32(pe, o + 8);
			int raw = BitConverter.ToInt32(pe, o + 20);
			int rsz = BitConverter.ToInt32(pe, o + 16);
			if (rva >= va && rva < va + Math.Max(vsz, rsz))
				return raw + (rva - va);
		}
		return rva;
	}

	static string ReadAsciiZ(byte[] pe, int off)
	{
		int e = off;
		while (e < pe.Length && pe[e] != 0) e++;
		return Encoding.ASCII.GetString(pe, off, e - off);
	}
}
