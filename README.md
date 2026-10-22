# OpenRATS — Educational RAT Source Archive

An open-source archive of Remote Access Trojan (RAT) source code, reconstructed from shipped binaries for **education and research**.

## Purpose

This repository exists to teach how real-world RATs are written:

- **How they connect** — TCP-based command-and-control (C2) channels
- **How they hide** — obfuscation, packing, and anti-analysis tricks
- **How they spread** — builders that patch legitimate apps into trojanized installers
- **How they steal** — file managers, keyloggers, screen capture, SMS/call access

Every tool here was reverse-engineered from a real shipped binary using [REA](https://github.com/morluto/rea) and reconstructed into **compilable source code**, so students can read, build, and study it. Each RAT lives in its own folder with its own README.

> [!IMPORTANT]
> This project is for **education and research only**. Do not use these tools to harm anyone or any system. Compile and run only in isolated VMs.

## Current tools

| Tool | Family | Language | Folder |
|------|--------|----------|--------|
| CraxsRat v7.1 (Cobra mod) | Android RAT (Windows server) | VB.NET → C# | [`Cobra/`](Cobra/) |

## Repository layout

- `Cobra/` — full decompiled & fixed-up C# source of the CraxsRat "Cobra" mod server, builds with `dotnet build`
- `Cobra/libs/` — third-party dependencies the original shipped with (UI, charts, audio, GeoIP, JSON)
- `Cobra/res/` — runtime resources (extract from the original package): fonts, flags, icons, APK-patching toolchain

## Method

Each tool is reconstructed the same way:

1. **Static analysis** with REA (`inspect_managed_artifact`, PDB string extraction) to identify the artifact, its original project layout, and its features
2. **Decompilation** with ILSpy (`ilspycmd -p`) into a compilable `.csproj` project
3. **Fix-ups** for VB.NET → C# decompiler artifacts so the project builds cleanly
4. **Documentation** of the C2 protocol, builder pipeline, and notable tricks

## Legal

These are reconstructions of third-party binaries kept for interoperability, education, and security research. All rights to the original works belong to their authors.
