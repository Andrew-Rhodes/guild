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
            [TestCase(true, true, true)]
            [TestCase(false, false, true)]
            [TestCase(true, false, false)]
            public void TestAreWeInTrouble(bool a, bool b, bool expected)
            {
            Cond obj = new Cond();
                bool testValue = obj.AreWeInTrouble(a, b);

                Assert.AreEqual(expected, testValue);
            }
        }
    }


