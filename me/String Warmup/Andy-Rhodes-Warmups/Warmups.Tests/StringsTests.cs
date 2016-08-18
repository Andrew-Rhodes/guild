using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Warmups.Tests
{
    [TestFixture]
    public class StringsTests
    {

        #region SayHello

        [TestCase("Bob", "Hello Bob!")]
        [TestCase("Alice", "Hello Alice!")]
        [TestCase("X", "Hello X!")]
        public void TestSayHello(string name, string expected)
        {
            Strings obj = new Strings();
            string testValue = obj.SayHi(name);

            Assert.AreEqual(expected, testValue);
        }

        #endregion

        #region Abba

        [TestCase("Hi", "Bye", "HiByeByeHi")]
        [TestCase("Yo", "Alice", "YoAliceAliceYo")]
        [TestCase("What", "Up", "WhatUpUpWhat")]
        public void TestAbba(string a, string b, string expected)
        {
            Strings obj = new Strings();
            string testValue = obj.Abba(a, b);

            Assert.AreEqual(expected, testValue);
        }

        #endregion

        #region MakeTags

        [TestCase("i", "Yay", "<i>Yay</i>")]
        [TestCase("i", "Hello", "<i>Hello</i>")]
        [TestCase("cite", "Yay", "<cite>Yay</cite>")]
        public void TestMakeTags(string a, string b, string expected)
        {
            Strings obj = new Strings();
            string testvalue = obj.MakeTags(a, b);

            Assert.AreEqual(expected, testvalue);
        }

        #endregion

        #region InsertWord

        [TestCase("<<>>", "Yay", "<<Yay>>")]
        [TestCase("<<>>", "WooHoo", "<<WooHoo>>")]
        [TestCase("[[]]", "word", "[[word]]")]
        public void TestInsertWord(string container, string word, string expected)

        {
            Strings obj = new Strings();
            string testvalue = obj.InsertWord(container, word);

            Assert.AreEqual(expected, testvalue);
        }






        #endregion

        #region MultipleEndings

        [TestCase("Hello", "lololo")]
        [TestCase("ab", "ababab")]
        [TestCase("Hi", "HiHiHi")]
        public void testMultipleEndings(string str, string expected)
        {
            Strings obj = new Strings();
            string TestValue = obj.MultipleEndings(str);

            Assert.AreEqual(expected, TestValue);
        }

        #endregion

        #region FirstHalf

        [TestCase("WooHoo", "Woo")]
        [TestCase("HelloThere", "Hello")]
        [TestCase("abcdef", "abc")]
        public void testFirstHalf(string str, string expected)
        {
            Strings obj = new Strings();
            string TestValue = obj.FirstHalf(str);

            Assert.AreEqual(expected, TestValue);
        }

        #endregion

        #region TrimOne

        [TestCase("Hello", "ell")]
        [TestCase("java", "av")]
        [TestCase("coding", "odin")]
        public void testTrimOne(string str, string expected)
        {
            Strings obj = new Strings();
            string TestValue = obj.TrimOne(str);

            Assert.AreEqual(expected, TestValue);
        }

        #endregion

        #region LongInMiddle

        [TestCase("Hello", "hi", "hiHellohi")]
        [TestCase("hi", "Hello", "hiHellohi")]
        [TestCase("aaa", "b", "baaab")]
        public void TestLongInMiddle(string a, string b, string expected)
        {
            Strings obj = new Strings();
            string testValue = obj.LongInMiddle(a, b);

            Assert.AreEqual(expected, testValue);
        }

        #endregion

        #region RotateLeft2

        [TestCase("Hello", "lloHe")]
        [TestCase("Java", "vaJa")]
        [TestCase("Hi", "Hi")]
        [TestCase("Polyphia", "lyphiaPo")]
        public void TestRotateleft2(string str, string expected)
        {
            Strings obj = new Strings();
            string testcase = obj.Rotateleft2(str);

            Assert.AreEqual(expected, testcase);
        }

        #endregion

        #region RotateRight2

        [TestCase("Hello", "loHel")]
        [TestCase("Java", "vaJa")]
        [TestCase("Hi", "Hi")]
        [TestCase("Polyphia", "iaPolyph")]

        public void testRotateRight2(string str, string expected)
        {
            Strings obj = new Strings();
            string testcase = obj.RotateRight2(str);

            Assert.AreEqual(expected, testcase);
        }

        #endregion

        #region TakeOne

        [TestCase("hello", true, "h")]
        [TestCase("hello", false, "o")]
        [TestCase("oh", true, "o")]
        public void testTakeOne(string str, bool fromFront, string expected)
        {
            Strings obj = new Strings();
            string testcase = obj.TakeOne(str, fromFront);

            Assert.AreEqual(expected, testcase);
        }
        #endregion

        #region MiddleTwo

        [TestCase("string", "ri")]
        [TestCase("code", "od")]
        [TestCase("Practice", "ct")]
        [TestCase("Bridge", "id")]

        public void testMiddleTwo(string str, string expected)
        {
            Strings sweet = new Strings();
            string testcase = sweet.MiddleTwo(str);

            Assert.AreEqual(expected, testcase);
        }
        #endregion

        #region EndsWithLy

        [TestCase("oddly", true)]
        [TestCase("y", false)]
        [TestCase("oddy", false)]
        [TestCase("ly", true)]

        public void testEndsWithLy(string str, bool expected)
        {
            Strings obj = new Strings();
            bool testcase = obj.EndsWithLy(str);

            Assert.AreEqual(expected, testcase);
        }

        #endregion

        #region FrontAndBack

        [TestCase("Hello", 2, "Helo")]
        [TestCase("Chocolate", 3, "Choate")]
        [TestCase("Chocolate", 1, "Ce")]
        [TestCase("Polyphia" , 3, "Polhia")]

        public void testFrontAndBack(string str, int n, string expected)
        {
            Strings obj = new Strings();
            string testcase = obj.FrontAndBack(str, n);

            Assert.AreEqual(expected, testcase);
        }


        #endregion

        #region TakeTwoFromPosition

        [TestCase("java", 0, "ja")]
        [TestCase("java", 2, "va")]
        [TestCase("java", 3, "ja")]
        [TestCase("Sabbath", 4, "at")]

        public void testTakeTwoFromPosition(string str, int n, string expected)
        {
            Strings obj = new Strings();
            string testcase = obj.TakeTwoFromPosition(str, n);

            Assert.AreEqual(expected, testcase);
        }

        #endregion

        #region HasBad

        [TestCase("badxx", true)]
        [TestCase("xbadxx", true)]
        [TestCase("xxbadxx", false)]
        [TestCase(" ", false)]
        [TestCase("", false)]

        public void testHasBad(string str, bool expected)
        {
            Strings obj = new Strings();
            bool testcsae = obj.HasBad(str);

            Assert.AreEqual(expected, testcsae);
        }

        #endregion

        #region AtFirst

        [TestCase("Hello", "He")]
        [TestCase("he", "he")]
        [TestCase("h", "h@")]
        [TestCase("", "@@")]
        [TestCase(" ", " @")]

        public void testAtFirst(string str, string expected)
        {
            Strings obj = new Strings();
            string testcase = obj.AtFirst(str);

            Assert.AreEqual(expected, testcase);
        }
        #endregion

        #region LastChars

        [TestCase("last", "chars", "ls")]
        [TestCase("yo", "mama", "ya")]
        [TestCase("hi", "", "h@")]
        [TestCase("", "hi", "@i")]

        public void testLastChars(string str, string str2, string expected)
        {
            Strings obj = new Strings();
            string testcase = obj.LastChars(str, str2);

            Assert.AreEqual(expected, testcase);
        }


        #endregion

        #region ConKat

        [TestCase("abc", "cat", "abcat")]
        [TestCase("dog", "cat", "dogcat")]
        [TestCase("abc", "", "abc")]


        public void testConKat(string a, string b, string expected)
        {
            Strings obj = new Strings();
            string testcase = obj.ConCat(a, b);

            Assert.AreEqual(expected, testcase);

        }

#endregion
    }
}