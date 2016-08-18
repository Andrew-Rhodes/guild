using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlooringProgram.BLL;
using FlooringProject.Data;
using FlooringProject.Models;
using NUnit.Framework;
using FlooringProject.Data.Interfaces;

namespace FlooringProject.Tests
{
    [TestFixture]
    public class TestUI
    {
        [Test]
        [TestCase("1/01/2016", 2)]
        [TestCase("1/02/2016", null)]
        public void testgetallorders(string choice, int expected)
        {
            InMemoryOrderRepository test = new InMemoryOrderRepository();
            var result = test.GetAllOrdersByDate(choice);

            Assert.AreEqual(result.Count, expected);
        }




        //[Test]

        //[TestCase(List<> , 3)]
        //public void testcreateORder(Order order, int expected)
        //{

        //    InMemoryOrderRepository test = new InMemoryOrderRepository();
        //    var result = test.CreateOrder(order);

        //    Assert.AreEqual();
        //}

        //[Test]

        //[TestCase(typeof(newOrder), 1)]
        //public void Testaddorder(Order order, int expected)
        //{
        //    InMemoryOrderRepository test = new InMemoryOrderRepository();
        //    var result = test.CreateOrder(order);

        //    Assert.AreEqual(result, expected);
        //}
        [Test]
        [TestCase(1, 3)]
        [TestCase(2, 4)]
        public void testNextOrderNumeber(int testNumber, int expected)
        {
            InMemoryOrderRepository obj = new InMemoryOrderRepository();

            var result = obj.GetNextOrderNumber();

            Assert.AreEqual(result, expected);

        }




        [Test]

        [TestCase(1, 3)]
        public void testnextordernumber(int order, int expected)
        {
            InMemoryOrderRepository test = new InMemoryOrderRepository();
            var result = test.GetNextOrderNumber();

            Assert.AreEqual(result, expected);
        }



        [Test]

        [TestCase(1, 1)]
        public void Testdeleteorder(int order, int expected)
        {
            InMemoryOrderRepository test = new InMemoryOrderRepository();
            var result = test.DeleteOrder(order);

            Assert.AreEqual(result.Count, expected);
        }
    }
}
