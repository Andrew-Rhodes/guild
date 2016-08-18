using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKata.tests
{
    [TestFixture]
    class calculatorTests
    {
        [Test]
        public void Step1_NoParameters()
        {
            Calculator calc = new Calculator();
            int result = calc.Add("");

            Assert.AreEqual(0, result);
        }

        [TestCase("", 0)]
        [TestCase("1", 1)]
        [TestCase("17", 17)]
        public void Step1_OneParameter(string numbers, int expected)
        {
            Calculator calc = new Calculator();
            int result = calc.Add(numbers);

            Assert.AreEqual(expected, result);
        }

        [TestCase("1,2", 3)]
        [TestCase("1,2,3,4", 10)]
        public void Step1_TwoParameters(string numbers, int expected)
        {
            Calculator calc = new Calculator();
            int result = calc.Add(numbers);

            Assert.AreEqual(expected, result);
        }

        [TestCase("1, 2, 3, 4", 10)]
        [TestCase("1, 2, 3, 4, 5, 6", 21)]
        public void Step2(string numbers, int expected)
        {
            Calculator calc = new Calculator();
            int result = calc.Add(numbers);

            Assert.AreEqual(expected, result);
        }

        [TestCase("1\n2,3", 6)]
        [TestCase("1,2,3\n4,5,6", 21)]
        public void Step3(string numbers, int expected)
        {
            Calculator calc = new Calculator();
            int result = calc.Add(numbers);

            Assert.AreEqual(expected, result);
        }


        [TestCase("//;\n1;2", 3)]
        [TestCase("//|\n1|2|3", 6)]
        public void Step4(string numbers, int expected)
        {
            Calculator calc = new Calculator();
            int result = calc.Add(numbers);

            Assert.AreEqual(expected, result);
        }
    }
}
