

# ConfuserEx 插件集成版

本软件基于 ConfuserEx 增加以下保护插件：

插件库1：https://github.com/RivaTesu/ConfuserEx-Additions/

> Anti DnSpy, based on NETGuard
>
> Anti Virtual Machine, edited from the old source of PerplexDotNet
>
> Hide Calls Protection, edited from InvalidMetadataProtection of the Noisette-Obfuscator
>
> MD5Sum, based on stackoverflow posts
>
> New Renamer, edited from the old source of SunshineNET
>
> Header Protection, from my repository Anti-Memory-Dumping
>
> Mutate Constants, from my old protector
>
> New Control Flow, modified version of IntControlFlow from GabTeix
>
> Reduce Metadata Optimization, from my old protector
>
> The rest are editions of the original protections



插件库2：https://github.com/koaie/ConfuserEx-Additions-v2

> ##### - AntiDe4dot:
>
> - Prevents usage of De4Dot.
>
> ##### - AntiDebug_v2:
>
> - This protection prevents the assembly from being debugged or profiled.
>
> ##### - AntiWatermark:
>
> - Removes the ProtectedBy watermark to prevent Protector detection.
>
> ##### - Constant:
>
> - This protection encodes and compresses constants in the code.
>
> ##### - Constant_v2:
>
> - This protection mangles the code in the methods so that decompilers cannot decompile the methods
>
> ##### - EreaseHeader:
>
> - This protection flood the module.cctor.
>
> ##### - OpCodeProt:
>
> - Protects OpCodes such as Ldlfd.
>
> ##### - FakeObfuscator:
>
> - Confuses obfuscators like de4dot by adding types typical to other obfuscators.
>
> ##### - IntergrityChecker:
>
> - This protection hashs the module to preventing file modifications.
>
> ##### - JIT Antitamper:
>
> - This protection ensures the integrity of application.
>
> ##### - LocaltoField:
>
> - This protection marks the module with a attribute that discourage ILDasm from disassembling it.



---

==以下为原 README.md 内容==


========

# ConfuserEx

[![Build status][img_build]][build]
[![Test status][img_test]][test]
[![CodeFactor][img_codefactor]][codefactor]
[![Gitter Chat][img_gitter]][gitter]
[![MIT License][img_license]][license]

ConfuserEx is a open-source protector for .NET applications.
It is the successor of [Confuser][confuser] project.

## Features

* Supports .NET Framework 2.0/3.0/3.5/4.0/4.5/4.6/4.7
* Symbol renaming (Support WPF/BAML)
* Protection against debuggers/profilers
* Protection against memory dumping
* Protection against tampering (method encryption)
* Control flow obfuscation
* Constant/resources encryption
* Reference hiding proxies
* Disable decompilers
* Embedding dependency
* Compressing output
* Extensible plugin API
* Many more are coming!

# Usage

```Batchfile
Confuser.CLI.exe <path to project file>
```

The project file is a ConfuserEx Project (`*.crproj`).
The format of project file can be found in [docs\ProjectFormat.md][project_format]

# Bug Report

See the [Issues Report][issues] section of website.

# License

Licensed under the MIT license. See [LICENSE.md][license] for details.

# Credits

**[0xd4d]** for his awesome work and extensive knowledge!

[0xd4d]: https://github.com/0xd4d
[build]: https://ci.appveyor.com/project/mkaring/confuserex/branch/master
[codefactor]: https://www.codefactor.io/repository/github/mkaring/confuserex/overview/master
[confuser]: http://confuser.codeplex.com
[issues]: https://github.com/mkaring/ConfuserEx/issue
[gitter]: https://gitter.im/ConfuserEx/community
[license]: LICENSE.md
[project_format]: docs/ProjectFormat.md
[test]: https://ci.appveyor.com/project/mkaring/confuserex/branch/master/tests

[img_build]: https://img.shields.io/appveyor/ci/mkaring/ConfuserEx/master.svg?style=flat
[img_codefactor]: https://www.codefactor.io/repository/github/mkaring/confuserex/badge/master
[img_gitter]: https://img.shields.io/gitter/room/mkaring/ConfuserEx.svg?style=flat
[img_license]: https://img.shields.io/github/license/mkaring/ConfuserEx.svg?style=flat
[img_test]: https://img.shields.io/appveyor/tests/mkaring/ConfuserEx/master.svg?style=flat&compact_message
