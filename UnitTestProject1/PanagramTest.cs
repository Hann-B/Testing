using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication4;

namespace UnitTestProject1
{
    [TestClass]
    public class PanagramTest
    {
        [TestMethod]
        public void BasicTest()
        {
            //Arrange
            var panagram = new Panagram();//using WebApplication4;
            //Act
            var result = panagram.PanagramTest("Hello World!");
            //Assert
            Assert.AreEqual("not pangram", result);
        }

        [TestMethod]
        public void AlphabetTest()
        {
            var panagram = new Panagram();
            var result = panagram.PanagramTest("abcdefghijklmnopqrstuvwxyz");
            Assert.AreEqual("pangram", result);
        }

        [TestMethod]
        public void TrueTest()
        {
            var panagram = new Panagram();
            var result = panagram.PanagramTest("The quick brown fox jumps over the lazy dog");
            Assert.AreEqual("pangram", result);
        }

        [TestMethod]
        public void TestingOneTwo()
        {
            var panagram = new Panagram();
            var result = panagram.PanagramTest("Not today satan, not today");
            Assert.AreEqual("not pangram", result);
        }

        [TestMethod]
        public void TestingTesting()
        {
            var panagram = new Panagram();
            var result = panagram.PanagramTest("How much you wanna Bet!$5!");
            Assert.AreEqual("not pangram", result);
        }
    }
}
