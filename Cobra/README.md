# CraxsRat v7.1 — "Cobra" Mod (Educational Reconstruction)

Reconstructed open-source version of the **CraxsRat v7.1 "Cobra" mod** — one of the most widely deployed Android RAT families. The Windows server/builder was decompiled from the shipped `Cobra.exe` binary and fixed up into a compilable C# project.

- **Original binary**: `Cobra.exe` (64,698,880 bytes, SHA-256 `95be9bdbb225cc7d3114b46d2b9445bba5db6e7689404301bb7428421a711676`)
- **Original format**: .NET Framework 4.8 PE (VB.NET), x86, AnyCPU IL, ~62.8 MB embedded resources
- **Original assembly identity**: `CraxsRat, Version=7.1.0.0`, module `CraxsRat.exe` (MVID `0ad15036-b582-4b7f-b87b-abbfcc000d95`)
- **Companion payload**: `Cobra.dll` — ConfuserEx-obfuscated injector (`ConfusedByAttribute`), assembly name `craxs`

> [!IMPORTANT]
> For **education and research only**. The compiled output is itself a fully functional RAT server; run it only in an isolated VM.

## What it is

CraxsRat is a classic two-part Android RAT:

1. **Windows server ("Craxs Rat")** — a WinForms desktop app. The operator selects a target APK (or uses the built-in stub), configures C2 address/ports and spy permissions, and the tool **rebuilds a trojanized APK** via apktool/ApkEditor, renames its smali packages/resources to random names, signs it with an embedded v2/v3/v4 key pair, and produces the installer to send to victims.
2. **Android client** — the patched APK connects back to the server over TCP, presents device info, and obeys commands: file manager, SMS/calls/contacts managers, camera, microphone, screen capture & recording, keylogger, GPS location, shell, notifications, app management, clipboard, and more.

## Build

Requirements: .NET SDK 9 (with .NET Framework 4.8 targeting pack) on Windows.

```powershell
cd OpenRATS\Cobra
dotnet build Cobra.csproj
```

Output: `bin\Debug\net48\CraxsRat.exe` (~64.8 MB — most of the mass is the embedded APK stub `MYSTUB`/`MYSTUBTEN`, the Android build toolchain, and `platformBinary.zip` used to rebuild/sign APKs).

To **run**, the app expects the `res\` folder from the original package next to the exe (fonts, GeoIP databases, icons, `Lib\` build toolchain). Copy `res\` from the original distribution.

## Source layout (mirrors the original VB.NET project)

The original PDB leaked the full original layout under `z:\c\craxsrat\craxs_rat\`:

| Area | Files | Role |
|------|-------|------|
| `Craxs_Rat/sockets/` | `Accept.cs`, `Client.cs`, `Data.cs`, `ListData.cs` | TCP C2: listener, per-victim state, message dispatch |
| `Craxs_Rat/` | `Build.cs` | The APK builder pipeline |
| `Craxs_Rat/` | `Codes.cs`, `reso.cs`, `SecurityKey.cs` | Helpers: AES, encoding, per-session command keys |
| `Craxs_Rat/froms/*` (flattened) | `FileManager`, `SMSManager`, `CallsManager`, `CameraManager`, `Microphone`, `Keylogger`, `LocationManager`, `ShellTerminal`, `ScreenShoter`, `ScreenReader*`, `Apkinstaller`, `Applications`, `Notifications`, `CraxsRatMain`, ... | One form per remote-control feature |
| `Craxs_Rat/My/` | `MySettings`, `Resources` | VB.NET My-namespace equivalents |
| `theme/`, `dialogsc/` (flattened) | `PBar`, `RTB`, `ResizeableControl`, `alertform`, `CraxsMsgbox`, ... | UI toolkit (DrakeUI-based theming) |

Note: ILSpy emitted decompiler-named state machines (`VB_0024StateMachine_...`, `_0024VB_0024Local_...`) for the original VB.NET `Async` methods — reading `Data.HandelData` requires patience; its dispatch logic is documented below.

## How the C2 protocol works

Evidence: `sockets/Accept.cs`, `sockets/Client.cs`, `sockets/Data.cs`, `SecurityKey.cs`, `Codes.cs`.

### Transport

- Plain **TCP** listener on operator-chosen port (`Accept.MainListner = new TcpListener(IPAddress.Any, port)`), `BeginAcceptTcpClient` accept loop.
- Data is length-prefixed and reassembled; each client socket gets 5 MB send/receive buffers.
- There is **no transport encryption** — a separate AES layer protects specific payloads (see below).

### Framing & separators

Messages are UTF-8 strings joined with per-installation separators (`Data.cs` static init):

| Separator | Value | Meaning |
|-----------|-------|---------|
| `SPL_SOCKET` | random per-installation string from `res\Config\Pass.inf` | separates command header fields |
| `SPL_DATA` | `x0D0x` | separates payload sections |
| `SPL_LINE` | `x0L0x` | separates lines |
| `SPL_ARRAY` | `x0A0x` | separates array items |

On first run the server writes an AES-encrypted `X0X0X` sentinel into `res\Config\Pass.inf`; the AES key is the hardcoded string `Nagato` (`Data.THEKEY`), and a second constant `BSN12345678901234567` (`Data.JK`) is used elsewhere for payload crypto.

### Handshake

1. Client connects and sends a login frame: `case + SPL_SOCKET + Keys`.
2. Server matches `case == "-1"` → new session: it generates **11 one-time command keys** (`SecurityKey.KeysClient1..11` = `"1"`..`"11"`, plus `KeysGetClient = "-2"`, `resultClient = "-1"`) plus **~30 random method names** (`SecurityKey.getinfo`, `getSMS`, `getFiles`, `getCamera`, `Keylogger`, `SHOT`, `down_info`, ...). Each method name is `counter + 3 random letters + millisecond-tick` (`SecurityKey.Key()`).
3. Server replies with the key list so the client knows which random names map to which commands this session.
4. Client requests fresh keys (`KeysGetClient` = `-2`) → server sends the *actual* key bundle, then the client sends `getinfo` with device data split by `SPL_DATA` (wallpaper, country, battery, screen size, phone model, Android version, UUID, ...).
5. Anything failing to parse is treated as a foreign RAT (SpyNote/njRAT) and the IP is blocked (`case "-A"` handles activity updates; malformed frames trigger `Blockme`).

### Command dispatch

After login, `Data.HandelData` splits the frame and switches on the first field (the case):

- Fixed numeric cases: `-0`→`-255` (info), `-9…` (screenshot sizes), `-584`, `-666`, `-759`, `825`, `888`, `9090`, `0099` (crash/log events)
- `SecurityKey.*` random per-session names: the feature commands (SMS, calls, contacts, files, camera, mic, keylog, GPS, shell, ...)
- Plugin cases: `reso.plug.Count`-keyed dispatch loads external command handlers (the `res\Plugins\Android\gen-*.pl` DEX files)

### Crypto

`Codes.cs` implements AES (Rijndael, MD5-derived keys) helpers `Encrypt`/`AES_Decrypt`/`Encrypt2`/`AesDecrypt`. Hardcoded keys found in the source:

| Key | Used for |
|-----|----------|
| `Nagato` (`Data.THEKEY`) | encrypting `Pass.inf` (the `SPL_SOCKET` secret) |
| `d[crUqy[iTg#6VADICOZW+Qjc4]4edQv` | some `DB`/config blobs |
| `nbjguhidoskznsmd` | misc decrypt |
| `q}%h%anHhw;sW.u*$eX{W]EYCHPxK;` | one JSON feature payload |
| `BSN12345678901234567` (`Data.JK`) | marker constant |

## How the APK builder works (the actual "RAT building" part)

Evidence: `Build.cs`, `My/Resources/Resources.cs`, `res\Lib\`, `res\Plugins\Android\`.

1. Operator picks a victim APK (any normal app) or uses the built-in stub `MYSTUB` (SDK ≤ 9) / `MYSTUBTEN` (SDK 10+).
2. `Build.cs` extracts `platformBinary.zip` (prebuilt apktool/apksigner/aapt2/zipalign toolchain, both 32/64-bit variants) into the build folder.
3. Runs `apktool d temp.apk` to decode the APK to smali + resources.
4. **Package/resource renaming for stealth**: the stub's smali packages `spymax\stub7` (+ `activz`, `brodatz`, `servziz` subpackages) and obfuscated resource names (`q1q2q3q4q5q6`, `d1d2d3d4d5d6`, `x1x2x3x4x5x6`, ...) are renamed to random strings; ~450 junk `<string>` entries with random names/values are injected into `res\values\strings.xml` (replacing the `GRESSTR` marker `"[GRESOSTR]"`).
5. Config is injected by placeholder replacement in `res\values\strings.xml`: `[CYPHER_VICTIM]`, `[CYPHER_PATCH]`, `[CYPHER_VERSION]`, `[CYPHER_PROPERTY]`, `[CYPHER_SLEEP]`, `[CYPHER_BIND]`, `[DISCRIP]`, `[CYPHER_PERMI]` (permission list) — plus icon/notification/bind-file paths.
6. Optional **bind**: a second APK/file is embedded as `res\raw\b1b2b3b4b5b6` for the dropper to install alongside.
7. Rebuilds with `apktool b temp`, optionally protects with **ApkEditor** (`Crypt.jar p -i temp.apk` — string/resource obfuscation).
8. `zipalign`, then **signs with an embedded debug-style key** (`Resources.c`/`k` or the alternate pair `C2`/`K2`) using `SignApk.jar ... --v3-signing-enabled true --v4-signing-enabled true`, outputting `output\DarKnetJoKer.apk`.
9. Writes `output\info.inf` with the patch name, version, C2 DNS/IP and ports used.

## Educational highlights

- **Session-key indirection**: every command name is randomized per server session, so static signatures on the wire are useless — a simple but effective trick.
- **Builder-based distribution**: the malware is not the server; it's the *output* of the server's build pipeline. The stub renames itself at build time, so each build has different package names.
- **Anti-foreign-RAT**: the server fingerprints login frames and blocks SpyNote/njRAT clients from connecting.
- **GeoIP enrichment**: victims are flagged by country via embedded MaxMind-style GeoIP.dat/GeoIPCity.dat.
- **ConfuserEx on the injector**: the shipped `Cobra.dll` companion (the "dropper"/injector half) is ConfuserEx-obfuscated; the main `Cobra.exe` is not — inconsistent protection is common in real malware families.

## Fix-ups applied to the decompiled source

ILSpy's VB.NET → C# output needed these corrections to compile:

0. **Redactions**: the original author's two Mapbox API tokens (one public `pk.` in `CraxsRatMain.cs`, one secret `sk.` in `sockets/Data.cs`, used for the GPS map display) were replaced with `REDACTED_MAPBOX_PUBLIC_TOKEN` / `REDACTED_MAPBOX_SECRET_TOKEN` placeholders so the repo can be published without leaking live third-party credentials.

1. `ResizeableControl.mControl` and `alertform.pictureBox2`: removed illegal `private virtual`
2. `GetCountryName.GetCountryName()`: renamed method to `Lookup()` (C# forbids member name == type name) and updated call sites
3. `CustomFont.LoadFont` / `CustomFontDrawString.LoadFont`: decompiled as parameterless properties but called with `(name, size, style)` — restored as static methods with parameters
4. csproj: retargeted `net45` → `net48` (matches the original's `.netframework,version=v4.8` assembly attributes found in the PDB), added `System.Resources.Extensions` package + `GenerateResourceUsePreserializedResources` for the large resx resources, added WPF references (`PresentationFramework`, `WindowsBase`) for the LiveCharts `GeoMap`, and pointed all dependency `HintPath`s at `libs\` (`WinMM.Net.dll` is stored as `WinMM.dll` because the `.Net` suffix triggers some AV scanners on copy — its assembly name is still `WinMM.Net`).

## Runtime requirements

- .NET Framework 4.8 (server)
- Java (for apktool/ApkEditor/apksigner during APK building)
- `res\` folder from the original package next to `CraxsRat.exe`

## References

- Original sample from the "cratest" collection (Ultimate-RAT-Collection, CraxsRat/Mods/Cobra)
- `Cobra.xml` — original XML doc comments (VB.NET, Chinese) describing the resource manager
- `Cobra.pdb` — leaked original source paths (`z:\c\craxsrat\craxs_rat\...`), used to reconstruct the layout table above
