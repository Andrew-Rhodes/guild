using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Warmups.Tests
{
    [TestFixture]
    public class ArrayTests
    {
        #region FirstLast6
        [TestCase(new int[] {1, 2, 6}, true)]
        [TestCase(new int[] { 6, 1, 2, 3}, true)]
        [TestCase(new int[] { 13, 6, 1, 2, 3 }, false)]
        [TestCase(new int[] { 6, 6, 6, 2, 7, 9 }, true)]
        [TestCase(new int[] { 87, 6, 1, 2, 99 }, false)]
        [TestCase(new int[] { 13, 6, 1, 2, 6, 8, 6, 6 }, true)]


        public void testFirstLAst6(int[] numbers, bool expected)
        {
            Array obj = new Array();
            bool testcase = obj.FirstLast6(numbers);

            Assert.AreEqual(expected, testcase);
        }
        #endregion

        #region SameFirstLast
        [TestCase(new int[] { 1, 2, 3}, false)]
        [TestCase(new int[] { 1, 2, 3, 1 }, true)]
        [TestCase(new int[] { 1, 2, 1 }, true)]
        [TestCase(new int[] { 1, 2, 1, 2, 1 }, true)]

        public void testSameFirstLast(int[] numbers, bool expected)
        {
            Array obj = new Array();
            bool testcase = obj.SameFirstLast(numbers);

            Assert.AreEqual(expected, testcase);
        }
        #endregion

        #region MakePi

        [TestCase(new int[] {3, 1, 4}, 3)]

        public void testMakePi(int n, int[] expected)
        {
            Array obj = new Array();
            int[] testcase = obj.MakePi(n);

            Assert.AreEqual(expected, testcase);
        }
#endregion

    }
}