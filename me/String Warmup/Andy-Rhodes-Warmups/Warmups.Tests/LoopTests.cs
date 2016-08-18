using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Warmups.Tests
{
    [TestFixture]
    public class LoopsTests
    {
        #region StringTimes

        [TestCase("Hi", 2, "HiHi")]
        [TestCase("Hi", 3, "HiHiHi")]
        [TestCase("Hi", 1, "Hi")]
        public void TestStringTimes(string str, int n, string expected)
        {
            Loops obj = new Loops();
            string testValue = obj.StringTimes(str, n);

            Assert.AreEqual(expected, testValue);
        }

        #endregion

        #region FrontTimes

        [TestCase("Chocolate", 2, "ChoCho")]
        [TestCase("Chocolate", 3, "ChoChoCho")]
        [TestCase("Abc", 3, "AbcAbcAbc")]
        public void testFrontTimes(string str, int n, string expected)
        {
            Loops obj = new Loops();
            string testcase = obj.FrontTimes(str, n);

            Assert.AreEqual(expected, testcase);
        }

        #endregion

        #region CountXX
        [TestCase("abcxx", 1)]
        [TestCase("xxx", 2)]
        [TestCase("xxxx", 3)]
        public void testCountxx(string str, int expected)
        {
            Loops obj = new Loops();
            int testCase = obj.CountXX(str);

            Assert.AreEqual(expected, testCase);
        }
        #endregion

        #region DoubleX

        [TestCase("axxbb", true)]
        [TestCase("axaxxax", false)]
        [TestCase("xxxxx", true)]
        [TestCase("aabbbccxx", true)]
        [TestCase("aasdgha", false)]
        public void testDoubleX(string str, bool expected)
        {
            Loops obj = new Loops();
            bool testCase = obj.DoubleX(str);

            Assert.AreEqual(expected, testCase);
        }

        #endregion

        #region EveryOther

        [TestCase("Hello", "Hlo")]
        [TestCase("Hi", "H")]
        [TestCase("Heeololeo", "Hello")]
        [TestCase("Amanda", "Aad")]
        public void testEveryOther(string str, string expected)
        {
            Loops obj = new Loops();
            string testcase = obj.EveryOther(str);

            Assert.AreEqual(expected, testcase);
        }
        #endregion

        #region StringSplosion

        [TestCase("Code", "CCoCodCode")]
        [TestCase("abc", "aababc")]
        [TestCase("ab", "aab")]
        [TestCase("Expidite" , "EExExpExpiExpidExpidiExpiditExpidite")]
        public void testStringSplosion(string str, string expected)
        {
            Loops obj = new Loops();
            string testcase = obj.StringSplosion(str);

            Assert.AreEqual(expected, testcase);
        }
        #endregion

        #region CountLast2

        [TestCase("hixxhi", 1)]
        [TestCase("xaxxaxaxx", 1)]
        [TestCase("axxxaaxx", 2)]
        [TestCase("ledelefolehele", 3)]
        [TestCase("asdgrhbv", 0)]
        public void testCountLast2(string str, int expected)
        {
            Loops obj = new Loops();
            int testcase = obj.CountLast2(str);

            Assert.AreEqual(expected, testcase);
        }
        #endregion

        #region CountLast2

        [TestCase(new int[] {1, 2, 9}, 1)]
        [TestCase(new int[] { 1, 9, 9 }, 2)]
        [TestCase(new int[] { 1, 9, 9, 3, 9 }, 3)]

        public void testCount9(int[] numbers, int expected)
        {
            Loops obj = new Loops();
            int testcase = obj.Count9(numbers);

            Assert.AreEqual(expected, testcase);
        }
        #endregion
    }
}