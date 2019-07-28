using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YouTubeDL_UI;

namespace CommandsTests
{
    [TestClass]
    public class CommandsTest
    {
        [TestMethod]
        public void OpenCommandPromptTest()
        {
            string app = "cmd.exe";
            string command = "/C help"; // a test command

            CommandProcessor.OpenCommandPrompt(app, command);
        }
    }
}
