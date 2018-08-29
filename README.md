# Build Release
A set of tools to build a .NET project.

[![license](https://img.shields.io/github/license/sakapon/Build-Release.svg)](https://github.com/sakapon/Build-Release/blob/master/LICENSE)

The following tools are contained:
- [Version 1up](#version-1up)
  - For the .NET Framework project format and the .NET Core project format
- [Zip Release](#zip-release)
  - For the .NET Framework project format and the .NET Core project format
- [NuGet Packup](#nuget-packup)
  - For the .NET Core project format

There are options to use the tools:
- Add the PowerShell script files to a .NET project by NuGet
- Download [the PowerShell script files](https://github.com/sakapon/Build-Release/tree/master/Downloads) and extract them to any folder
- Add the PowerShell scripts above to `External Tools` in Visual Studio (recommended)

See [Usage](#usage) for details.

## Version 1up
The PowerShell script to increment the assembly version in AssemblyInfo.

[![NuGet](https://img.shields.io/nuget/v/KTools.Version1up.svg)](https://www.nuget.org/packages/KTools.Version1up/)
[![NuGet](https://img.shields.io/nuget/dt/KTools.Version1up.svg)](https://www.nuget.org/packages/KTools.Version1up/)  
[NuGet Gallery | KTools.Version1up](https://www.nuget.org/packages/KTools.Version1up/)

### Specification
- Increment the assembly version on AssemblyInfo.cs
  - build number (`z` of `x.y.z`)

## Zip Release
The PowerShell script to build the project and create a ZIP file.

[![NuGet](https://img.shields.io/nuget/v/KTools.ZipRelease.svg)](https://www.nuget.org/packages/KTools.ZipRelease/)
[![NuGet](https://img.shields.io/nuget/dt/KTools.ZipRelease.svg)](https://www.nuget.org/packages/KTools.ZipRelease/)  
[NuGet Gallery | KTools.ZipRelease](https://www.nuget.org/packages/KTools.ZipRelease/)

### Specification
- Increment the assembly version (call the [**Version 1up**](#version-1up))
- Build a release by MSBuild
- Create a ZIP file from the build result

## NuGet Packup
The PowerShell script to create a NuGet package for the project.

## Usage
There are options to use the tools:
- Add the PowerShell script files to a .NET project by NuGet
  - Execute the scripts on the project folder
- Download the latest version of [the PowerShell script files](https://github.com/sakapon/Build-Release/tree/master/Downloads) and extract them to any folder
  - Execute the scripts on the project folder
- Add the PowerShell scripts above to `External Tools` in Visual Studio (recommended)
  - Execute the menu on the project

You can customize the PowerShell script to meet your needs.

### How to Add the Scripts to `External Tools` in Visual Studio
Choose the menu `Tools > External Tools`, and add a new content with the following information:
- Title: any
- Command: `powershell.exe`
- Arguments: `-ExecutionPolicy Unrestricted "C:\scripts_folder\KTools.xxx.ps1"`
- Initial directory: `$(ProjectDir)` or `$(SolutionDir)`
- Use Output window: `On`

![ExternalTools](docs/images/ExternalTools.png)

## Release Notes
- **v2.0.10** For .NET Core.
- **v1.2.6** Find the path to .ps1 files, regardless of the current directory.
- **v1.2.5** Find the path to MSBuild.exe.
- **v1.2.4** Rename .ps1 files.
- **v1.1.3** The first release.

## References
- [.NET Regular Expressions](https://msdn.microsoft.com/library/hs600312.aspx)
- [.nuspec File Reference for NuGet](https://docs.microsoft.com/en-us/nuget/schema/nuspec)
- [NuGet Package Version Reference](https://docs.microsoft.com/en-us/nuget/reference/package-versioning)
- [Manage external tools](https://docs.microsoft.com/en-us/visualstudio/ide/managing-external-tools)
- [.NET ビルド小技集 (4)](https://sakapon.wordpress.com/2015/10/23/dotnet-build-4/) (my blog)
- [ビルドして ZIP にする PowerShell スクリプト](https://sakapon.wordpress.com/2018/02/06/zip-release/) (my blog)
- [ビルド用のスクリプトを Visual Studio の外部ツールに登録する](https://sakapon.wordpress.com/2018/08/20/external-tools-build/) (my blog)
