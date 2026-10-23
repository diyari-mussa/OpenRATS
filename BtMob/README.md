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
- `LocalApkBuilder.cs` (**OpenRATS addition**) — fully offline payload builder; see below.

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

## Local Payload Builder (OpenRATS)

The original panel required the vendor's remote builder: `ApkMaker` POSTed the build parameters to the vendor web API (`MyServer.CommandStore` → `api_fetchstore`), and the vendor server patched a template APK and returned the payload. The OpenRATS reconstruction replaces this with a fully **offline builder** — `BTMOB/LocalApkBuilder.cs` — so payloads can be generated with zero network access.

### How the payload config works (reverse-engineered from `test.apk`)

The Android payload reads three literals from the `classes.dex` string table. `LocalApkBuilder` patches them in place (padding shorter replacements with NULs, so DEX offsets stay valid), then recomputes the DEX header SHA-1 signature and adler32 checksum:

| Literal (DEX string ID) | DEX offset | Plaintext / encoding |
|---|---|---|
| `yearly.quicksilver.master.nmzgrbqkgkgldgzyfb.vluguosseqy` (C2 config) | `1274503` | `base64(connkey + "[<s>]" + host1 + "<" + host2 + ... + "[<s>]T") + "\|"` |
| `yearly.quicksilver.master.nmzgrbqkgkgldgzyfb.uqikqxtclgzaomlr` (feature flags) | `1427555` | AES-128-CBC (PKCS7) of `"0\|0[*]1\|1[*]..."`; key = PBKDF2-HMAC-SHA1(password=`4814780584699673`, salt=`2894356330652558`, 65536 iters), IV = `2230209522049090`; stored Base64 |
| `yearly.quicksilver.master.r0.k` tag (client tag) | `1469130` | `"oltsfhxzoffaynqemztews" + tag` |

The `allconf` feature-flag string is 20 pairs `x|y` joined by `[*]`; each pair maps to a payload capability (SMS, camera, mic, keylogger, etc. — see `ApkMaker` checkboxes).

### Parameters (same keys the vendor builder used)

`conkey` (connection key), `uhost` (C2 host list, `<`-separated), `Ctag` (client tag), `allconf` (feature flags), `appname`, `appversion`, `appid` (package name), `build` (output name), `ksign` (optional custom signing subject: `use|alias|password|cn|ou|o|l|s|c`).

### Signing

The built APK is signed with a fresh 2048-bit RSA identity (or the `ksign` subject) using:

- **v1 (JAR signing)** — `META-INF/MANIFEST.MF`, `KEY.SF` (SHA-256 digests, `X-Android-APK-Signed: 2` anti-stripping, `SHA-256-Digest-Manifest-Main-Attributes`) and PKCS#7/CMS `KEY.RSA` via BouncyCastle 2.x.
- **v2 (APK Signing Block)** — inserted immediately before the ZIP central directory with ID `0x7109871a`, algorithm `0x0103` (RSASSA-PKCS1-v1_5 with SHA2-256), and the CHUNKED_SHA256 content digest (`0x5a`-prefixed flat chunk list; chunk digests `SHA256(0xa5 ‖ uint32le(len) ‖ data)`, global chunk index across the contents/CD/EOCD sections). The v2 signer block geometry is byte-exact with the vendor's `test.apk` (verified: `signersLP → signerLP → sdLP → digests/certs/attrs → signatures → publicKey`).

Verified with `apksigner verify --verbose --min-sdk-version 19 --max-sdk-version 36`:

```
Verifies
Verified using v1 scheme (JAR signing): true
Verified using v2 scheme (APK Signature Scheme v2): true
Number of signers: 1
```

### Usage

- **GUI**: open the ApkMaker form, fill the fields, and press Build — the panel now calls `LocalApkBuilder.Build` locally instead of the vendor API. The payload lands in `BuiltApks/` next to `template.apk`.
- **CLI**: `dotnet build TestLocalBuilder\TestLocalBuilder.csproj` then run `TestLocalBuilder\bin\Debug\net462\TestLocalBuilder.exe` — builds `BuiltApks\test_test_insect.kingdom.brother.apk` from `BTMOB/template.apk` with the same parameters the vendor baked into the sample.

`template.apk` (the original `test.apk`, de-Googled of nothing — it *is* the vendor payload with its literals intact) ships as `BTMOB/template.apk` and is the patch source for all builds.

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
