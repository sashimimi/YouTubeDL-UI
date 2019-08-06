using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YouTubeDL_UI;

namespace CommandsTests
{
    [TestClass]
    public class DownloadUITest
    {
        [TestMethod]
        public void CheckDependenciesSucceedTest()
        {
            string testpath = AppDomain.CurrentDomain.BaseDirectory.ToString();
            List<string> testDependencies = new List<string>() { "\\ffmpeg.exe", "\\youtube-dl.exe" };

            DownloadUI testlogic = new DownloadUI();
            testlogic.CheckDependencies(testpath, testDependencies);
        }

        [TestMethod]
        public void CheckDependenciesThrowsExceptionTest()
        {
            string testpath = AppDomain.CurrentDomain.BaseDirectory.ToString();
            List<string> testDependencies = new List<string>() { "\\ffmpeg.exe", "\\youtube-dl.exe", "\\randomfile.txt"};

            DownloadUI testlogic = new DownloadUI();
            Assert.ThrowsException<System.IO.FileNotFoundException>(() => testlogic.CheckDependencies(testpath, testDependencies));
        }

        [TestMethod]
        public void CheckIfEmptyTrueTest()
        {
            string str = "";

            DownloadUI testlogic = new DownloadUI();
            Assert.IsTrue(testlogic.CheckIfEmpty(str));
        }

        [TestMethod]
        public void CheckIfEmptyFalseTest()
        {
            string str = "test";

            DownloadUI testlogic = new DownloadUI();
            Assert.IsFalse(testlogic.CheckIfEmpty(str));
        }

        [TestMethod]
        public void DownloadTest()
        {
            string testURL = "https://www.youtube.com/watch?v=J---aiyznGQ";

            DownloadUI testlogic = new DownloadUI();
            testlogic.Download(testURL);
        }
    }
}
