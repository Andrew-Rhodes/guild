using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace Warmups.Tests
{
    [TestFixture]
    public class CondTests
    {
        #region AreWeInTrouble

        [TestCase(true, true, true)]
        [TestCase(false, false, true)]
        [TestCase(true, false, false)]
        public void TestAreWeInTrouble(bool a, bool b, bool expected)
        {
            Cond obj = new Cond();
            bool testValue = obj.AreWeInTrouble(a, b);

            Assert.AreEqual(expected, testValue);
        }

        #endregion

        #region canSleepIn

        [TestCase(false, false, true)]
        [TestCase(true, false, false)]
        [TestCase(false, true, true)]

        public void testCanSleepIn(bool isWeekday, bool isVacation, bool expected)
        {
            Cond obj = new Cond();
            bool testcase = obj.CanSleepIn(isWeekday, isVacation);

            Assert.AreEqual(expected, testcase);
        }


        #endregion

        #region SumDouble

        [TestCase(1, 2, 3)]
        [TestCase(3, 2, 5)]
        [TestCase(2, 2, 8)]
        [TestCase(4, 4, 16)]
        [TestCase(9, 8, 17)]

        public void testSumDouble(int a, int b, int expected)
        {
            Cond obj = new Cond();
            int testcase = obj.SumDouble(a, b);

            Assert.AreEqual(expected, testcase);
        }

        #endregion

        #region Diff21

        [TestCase(23, 4)]
        [TestCase(10, 11)]
        [TestCase(21, 0)]

        public void testDiff21(int n, int expected)
        {
            Cond obj = new Cond();
            int testcase = obj.Diff21(n);
            
            Assert.AreEqual(expected, testcase);
        }
        #endregion

        #region ParrotTrouble

        [TestCase(true, 6, true)]
        [TestCase(true, 7, false)]
        [TestCase(false, 6, false)]

        public void testParrotTrouble(bool isTalking, int hour, bool expected)
        {
            Cond obj = new Cond();
            bool testcase = obj.ParrotTrouble(isTalking, hour);

            Assert.AreEqual(expected, testcase);
        }
        #endregion

        #region Makes10

        [TestCase(9, 10, true)]
        [TestCase(9, 9, false)]
        [TestCase(1, 9, true)]
        [TestCase(5, 5, true)]
        [TestCase(10, 9, true)]
        [TestCase(11, 9, false)]


        public void testMakes10(int a, int b, bool expected)
        {
            Cond obj = new Cond();
            bool testcase = obj.Makes10(a, b);

            Assert.AreEqual(expected, testcase);
        }
        #endregion

        #region NearHundred

        [TestCase(103, true)]
        [TestCase(90, true)]
        [TestCase(89, false)]
        [TestCase(199, true)]

        public void testNearHundred(int n, bool expected)
        {
            Cond obj = new Cond();
            bool testcase = obj.NearHundred(n);

            Assert.AreEqual(testcase, expected);
        }
#endregion

    }
}


