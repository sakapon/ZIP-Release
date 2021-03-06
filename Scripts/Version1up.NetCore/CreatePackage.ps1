﻿$source = @"
using System;
using System.IO;
using System.Text;

public static class Program
{
    public static int Main(string[] args)
    {
        var format = File.ReadAllText("CSharp-Format.ps1.txt", Encoding.UTF8);
        var cs_script = File.ReadAllText(@"..\..\Lab\2018\BuildSample.NetCore\Version1upConsole\Program.cs", Encoding.UTF8);
        var ps_script = string.Format(format, cs_script);
        File.WriteAllText("KTools.Version1up.NetCore.ps1", ps_script, Encoding.UTF8);

        return 0;
    }
}
"@

Add-Type -TypeDefinition $source -Language CSharp
[Program]::Main($Args)

..\..\Tools\NuGet.CommandLine.4.4.1\NuGet.exe pack Package.nuspec

ni ..\..\Published -type directory -Force
move *.nupkg ..\..\Published -Force
explorer ..\..\Published
