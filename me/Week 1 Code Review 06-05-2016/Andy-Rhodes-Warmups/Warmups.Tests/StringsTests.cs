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
        [TestCase("Yo", "Alice", "YoAliceAliceYo")]
        [TestCase("What", "Up", "WhatUpUpWhat")]
        public void TestAbba(string a, string b, string expected)
        {
            Strings obj = new Strings();
            string testValue = obj.Abba(a, b);

            Assert.AreEqual(expected, testValue);
        }

        [TestCase("Hello", "hi", "hiHellohi")]
        [TestCase("hi", "Hello", "hiHellohi")]
        [TestCase("aaa", "b", "baaab")]
        public void TestLongInMiddle(string a, string b, string expected)
        {
            Strings obj = new Strings();
            string testValue = obj.LongInMiddle(a, b);

            Assert.AreEqual(expected, testValue);
        }
    }
}