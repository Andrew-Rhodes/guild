using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups.Tests
{
    [TestFixture]
    public class StringsTests
    {
        [TestCase("Bob", "Hello Bob!")]
        [TestCase("Alice", "Hello Alice!")]
        [TestCase("X", "Hello X!")]
        public void TestSayHello(string name, string expected)
        {
            Strings obj = new Strings();
            string testValue = obj.SayHi(name);

            Assert.AreEqual(expected, testValue);
        }

        [TestCase("Hi", "Bye", "HiByeByeHi")]
        public void TestAbba(string a, string b, string expected)
        {
            Strings obj = new Strings();
            string testValue = obj.Abba(a, b);

            Assert.AreEqual(expected, testValue);
        }
    }
}
