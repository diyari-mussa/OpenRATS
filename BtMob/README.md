# BTMob v4.6.1 — Open-Source Reconstruction

BTMob is an Android RAT (Remote Access Trojan) **operator control panel** — the Windows-side application used by an attacker to build APK payloads, manage victims (bots), and control infected Android devices over a WebSocket C2 channel. It is the desktop counterpart to the client app that runs on the victim phone.

This folder contains a fully decompiled, build-verified C# source reconstruction of `Btmob.exe` from the `BTMob 4.6.1 Fixed` distribution (RAR5 archive `BTMob_4.6.1_Fixed.bin`).

## Contents

| Path | Purpose |
|---|---|
| `BTMOB/` | Decompiled .NET Framework 4.6.2 WinForms source (main namespace) |
| `WMPLib/` | Reconstructed Windows Media Player interop (embedded types) |
| `Btmob.csproj` | MSBuild project targeting `net462` — `dotnet build Btmob.csproj` |
| `libs/` | The 13 NuGet-style dependencies shipped with the original tool |
| `EXGuarder.cs` | Obfuscated string-literal decoder shared by all forms |
| `BTMOB/VB_AnonymousTypes.cs` | Recovered VB anonymous-type helpers (see below) |
| `BTMOB/PrivateImplementationDetails.cs` | Reconstructed string-hash + VB awaiter helpers |

## Build

```bash
dotnet build Btmob.csproj
```

Requirements: .NET Framework 4.6.2 targeting pack, .NET 8/9 SDK (for MSBuild), NuGet restore enabled. The build produces `bin/Debug/net462/BTMob.exe` with matching assembly identity (`BTMob`, `4.6.0.0`, MSIL).

## What BTMob Is

BTMob is a **RAT control panel** (sometimes called a "manager" or "dashboard"). It does not run on the victim's phone — it runs on the attacker's PC. Its jobs:

1. **Authentication** — operator logs into a BT server (`MyServer.JoinServer`) with email/password/PIN and receives session keys.
2. **Bot management** — lists online bots (Android victims), shows device info, country flags (GeoIP), status, and per-bot commands.
3. **Payload building** — `ApkMaker` compiles a victim-side APK: it takes a base APK, applies custom package name, icons, permissions, and embedded server/key data, re-signs it, and produces a deployable payload (the actual malware installed on the phone).
4. **Command & control** — every capability (file manager, camera, mic, SMS, contacts, location, terminal, etc.) is a WinForms form that serializes a `Dictionary<string, object>` of `{command, args}` into JSON and pushes it over the WebSocket connection; the phone app executes it and replies.
5. **Modules** — many manager windows, one per feature: `filesmanager`, `MicMonitor`, `CameraMonitor` (via `VB_0024AnonymousType_16` cam/res/quality), `Chat`, `SMSmaker`, `ContactsManager`, `LiveKeylogger`, `ScreenReader`, `terminal`, `ddosattacker`, `minersmanager`, `phonecaller`, `Redirector` (web redirects), `Blocker` (app blocking), `lockscreen`, `ttsform` (TTS), etc.

## Architecture

### Transport: WebSocket C2

- `WebSocketClient.cs` wraps `WebSocket4Net`. The panel connects to the BT server's WebSocket endpoint (`api_joinwebsocket`), authenticates, then exchanges JSON messages.
- Each message is a JSON object; the server routes commands to bots and delivers replies/events back.
- `WebSocketClient.MessageWorker` runs as `Task.Factory.StartNew(..., LongRunning)` consuming a `BlockingCollection<string>` fed by `OnMessageReceived` — a classic producer/consumer queue between the socket thread and processing tasks.

### Command dispatch

- `BTEngine.commands(Dictionary<string, object> chatData, string mobid, WebSocketClient ws)` is the central send API used by every form.
- `BTEngine.HandleMessage(string json, ServersInfo srv)` is the giant dispatcher on the receive side: it inspects `dictionary[command]` (e.g. `screadcom` = screen reader data) and opens/updates the corresponding manager form.
- Most handlers follow the VB async state-machine pattern (`VB_0024StateMachine_*`), so ILSpy decompiled them into explicit `IAsyncStateMachine` classes inside `MyServer.cs`/`BTEngine.cs`.

### HTTP APIs

- `MyServer.cs` implements the panel's REST calls to the BT web server (login, store, updates, password change, app store sync): `FetchStore`, `FetchAppsAPI`, `FetchUpdates`, `ChangePassword`, `JoinServer`, `FetchCustomAPI`, `CommandStore`. Each serializes parameters to JSON with Newtonsoft, POSTs with `HttpClient`, and returns `(bool, object)` tuples.
- `filestreamer.cs` wraps `HttpContent` with upload progress reporting (`IProgress<int>`).

### Android payload builder

- `ApkMaker.cs` + `UploadApp.cs` + `jectormaker.cs` + `ijectionlab.cs`: build APK payloads with aapt2/7-Zip, embed injection ZIPs, and manage binary tools cached in `Resources/BTCache`.
- `ApkValidator.ValidateApk` checks input APKs before building.
- `codes.ZipJectFile` packs injector payloads.

### Key crypto/protocol elements

- `SecurityKey` / `ran_key` / `nextkey`: per-session random keys exchanged in messages (`ServersMgr.GetServerNextKey`) — every command carries a rotating key used to sign/verify messages.
- `MyServer.DecryptReply` (AES-style decrypt of server replies with key/iv/text).
- `codes` module: general helpers (regex, zip, string generation `StrGenerator(32)` used for random keys).

## Decompiler Fix-Up Catalog

ILSpy emitted broken C# for several VB.NET idioms. Every repair is documented here so reviewers can audit fidelity:

| # | File(s) | Problem | Fix |
|---|---|---|---|
| 1 | `UploadApp.cs`, `ijectionlab.cs`, `filesmanager.cs`, `MicMonitor.cs`, `GeoIP.cs`, `codes.cs`, `BTBroadcast.cs`, `Form1.cs` | Empty identifier declarations (`string  = ...`, `object  = default(object);`, `result = ;`) — ILSpy lost variable names | Renamed to contextual names (`title`, `quality`, `appId`, `sep`, `name`, `unusedResult`) |
| 2 | `BTMOB/VB_AnonymousTypes.cs` (new file) | 31 VB `$AnonymousType_*` classes emitted as **empty files**; property names were the JSON wire keys | Definitions recovered from original assembly metadata via reflection and regenerated; `case` keyword escaped as `@case` |
| 3 | `BTMOB/PrivateImplementationDetails.cs` (new file) | `<PrivateImplementationDetails>` (VB string-switch hashing) emitted empty | `ComputeStringHash` reimplemented (FNV-1a 32-bit); plus `GetAwaiter` extension making `await taskAwaiter` valid C# |
| 4 | `WMPLib/_WMPOCXEvents_Event.cs` | `[ComImport]` without `[Guid]` (embedded interop types) | Added the type-identifier GUID `6BF52A50-394A-11D3-B153-00C04F79FAA6` |
| 5 | `ResizeableControl.cs`, `frmAlert.cs` | `private virtual` members (illegal C#) | `protected virtual` |
| 6 | `filestreamer.cs` | `TryComputeLength(ref long)` signature mismatch | `out long` |
| 7 | `AlertType.cs` | Enum member named same as enclosing type (`AlertType.AlertType`) | Renamed `AlertIconType` (+ call-site updates in `Alert.cs`, `frmAlert.cs`) |
| 8 | `BTEngine.cs` | 14 self-referencing closure declarations (`_Closure_... x = new _Closure_...(x);`) | Inserted `default(...)` arg locals (`arg1..arg14`, `argScreen`, `argLive`) |
| 9 | `WebSocketClient.cs` | Duplicate catch of `InvalidOperationException` after `ObjectDisposedException` (unreachable) | Removed redundant catch |
| 10 | `downloader.cs`, `ApkMaker.cs`, `Form1.cs`, `updatewindow.cs` | `await taskAwaiter` on `TaskAwaiter<T>` (VB-style await) | Handled by the `GetAwaiter` extension in `PrivateImplementationDetails.cs` |
| 11 | `BTBroadcast.cs`, `ijectionlab.cs` | `codes.StrisEmpty()` calls missing their argument after empty-identifier fix | Restored argument (`title`, `_2`, `appId`) |
| 12 | `UploadApp.cs` | `ExtractIconToBundle` missing return after fix-ups | `return null;` (matches original VB semantics — result unused) |

## Safety Notes

The static audit performed on the original distribution found:

- No process injection, registry persistence, or local credential theft on the operator machine.
- A standard auto-update downloader (`updatewindow.cs`) that pulls new versions from the vendor site — the shipped `BTMob.exe` hash mismatch against `SHA256SUMS` was investigated and attributed to the "Fixed" repack (see repo root README).
- Network behavior is limited to the configured BT server (WebSocket + HTTPS APIs) and the vendor update site.

This reconstruction is **not** signed by the original vendor and is for education only. Run it only in a VM/sandbox, as with any RAT operator panel: the tool itself manages Android victims and could be pointed at a test server you control.

> [!NOTE]
> One live Mapbox access token embedded in the original `LocationMap` HTML (`BTMOB.Resources.resx`) was redacted to `pk.REDACTED_MAPBOX_PUBLIC_TOKEN` before publishing.

## Notes on Fidelity

- `EXGuarder` string obfuscation is preserved as-is: the original encoded-string fields remain; the decoder methods are intact. This keeps the reconstruction faithful to how the tool actually stores strings.
- VB async state machines (`VB_0024StateMachine_*`) are kept as decompiled (explicit `IAsyncStateMachine` implementations) rather than rewritten — the goal is a compiling, inspectable reference, not idiomatic C#.
- The `WMPLib` interop uses embedded COM types; the reconstructed interface keeps the original type-identifier GUID.
