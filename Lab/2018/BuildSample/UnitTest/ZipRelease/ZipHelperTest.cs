﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static UnitTest.TestHelper;

namespace UnitTest.ZipRelease
{
    [TestClass]
    public class ZipHelperTest
    {
        [TestMethod]
        public void GetMSBuildPath_1()
        {
            var actual = ZipHelper.GetMSBuildPath();
            var expected = @"C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\MSBuild\15.0\Bin\MSBuild.exe";
            Assert.IsTrue(string.Equals(expected, actual, StringComparison.InvariantCultureIgnoreCase));
        }

        [TestMethod]
        public void GetMSBuildPathFromNetFW_1()
        {
            var actual = ZipHelper.GetMSBuildPathFromNetFW();
            var expected = @"C:\Windows\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe";
            Assert.IsTrue(string.Equals(expected, actual, StringComparison.InvariantCultureIgnoreCase));
        }

        [TestMethod]
        public void CreateZipFileForAssembly_1()
        {
            ZipHelper.CreateZipFileForAssembly(@"..\..\..\ZipReleaseConsole");
            Assert.Inconclusive("See the file.");
        }

        [TestMethod]
        public void GetAssemblyFileVersion_1()
        {
            var Test = CreateAssertion<string, string>(ZipHelper.GetAssemblyFileVersion);

            Test(
                @"..\..\Properties\AssemblyInfo.cs",
                "2.2.3");
        }

        [TestMethod]
        public void CreateZipFile_1()
        {
            ZipHelper.CreateZipFile(@"..\Release", @"..\zip", "CreateZipFile_1.zip");
            Assert.Inconclusive("See the file.");
        }

        [TestMethod]
        public void CreateZipFile_2()
        {
            ZipHelper.CreateZipFile(@"..\Release", ".", "CreateZipFile_2.zip");
            Assert.Inconclusive("See the file.");
        }

        [TestMethod]
        public void CreateZipFile_3()
        {
            ZipHelper.CreateZipFile(".", @"..\", "CreateZipFile_3.zip");
            Assert.Inconclusive("See the file.");
        }
    }
}
