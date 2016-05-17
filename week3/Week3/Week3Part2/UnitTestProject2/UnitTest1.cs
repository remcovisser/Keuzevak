using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        private string _directory = @"C:\Users\remcovisser\test.txt";
        [TestMethod]
        public void File_Found_On_Harddisk()
        {
            LoadFile loadFile = new LoadFile(_directory);
            loadFile.FoundFile().Should().BeTrue();
        }
    }
}
