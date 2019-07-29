using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YouTubeDL_UI;

namespace CommandsTests
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void BuildStringTest()
        {
            List<string> strings = new List<string> {"This", "is", "a", "String Builder", "test", "."};

            string str = StringHandler.BuildString(strings);

            Console.WriteLine(str);
        }
    }
}
