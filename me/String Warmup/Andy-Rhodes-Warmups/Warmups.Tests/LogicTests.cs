using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Warmups.Tests
{
    [TestFixture]
    public class LogicTests
    {
        #region GreatParty
        [TestCase(30, false, false)]
        [TestCase(50, false, true)]
        [TestCase(70, true, true)]
        [TestCase(20, true, false)]
        [TestCase(90, false, false)]

        public void testGreatParty(int cigars, bool isWeekend, bool expected)
        {
            Logic obj = new Logic();
            bool testcase = obj.GreatParty(cigars, isWeekend);

            Assert.AreEqual(expected, testcase);
        }
        #endregion

        #region CanHazTable

        [TestCase(5, 10, 2)]
        [TestCase(5, 2, 0)]
        [TestCase(5, 5, 1)]

        public void testCanHazTable(int yourStyle, int dataStyle, int expected)
        {
            Logic obj = new Logic();
            int testcase = obj.CanHazTable(yourStyle, dataStyle);

            Assert.AreEqual(expected, testcase);
        }


        #endregion

        #region PlayOutside

        [TestCase(70, false, true)]
        [TestCase(90, false, false)]
        [TestCase(95, true, true)]

        public void testPlayOutside(int temp, bool isSummer, bool expected)
        {
            Logic obj = new Logic();
            bool testcase = obj.PlayOutside(temp, isSummer);

            Assert.AreEqual(expected, testcase);
        }


        #endregion

        #region caughtSpeeding

        [TestCase(60, false, 0)]
        [TestCase(65, false, 1)]
        [TestCase(65, true, 0)]
        [TestCase(90, false, 2)]

        public void testCaughtSpeeding(int speed, bool isBirthday, int expected)
        {
            Logic obj = new Logic();
            int testcase = obj.CaughtSpeeding(speed, isBirthday);

            Assert.AreEqual(expected, testcase);
        }



        #endregion
    }
}
