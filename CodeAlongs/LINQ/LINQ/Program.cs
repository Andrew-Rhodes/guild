using System;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;

namespace LINQ
{
    class Program
    {
        /* Practice your LINQ!
         * You can use the methods in Data Loader to load products, customers, and some sample numbers
         * 
         * NumbersA, NumbersB, and NumbersC contain some ints
         * 
         * The product data is flat, with just product information
         * 
         * The customer data is hierarchical as customers have zero to many orders
         */
        static void Main()
        {
            //PrintOutOfStock();
            //InStockMoreThan3();
            //First3OrdersInWash();
            //ReturnAfterFirstTwoInWash();
            ReturnAllBeforeGreaterThan6();


            Console.ReadLine();
        }

        //1. Find all products that are out of stock.
        private static void PrintOutOfStock()
        {
            var products = DataLoader.LoadProducts();

            //var results = products.Where(p => p.UnitsInStock == 0);
            var results = from p in products
                where p.UnitsInStock == 0
                select p;

            foreach (var product in results)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        //2. Find all products that are in stock and cost more than 3.00 per unit.
        private static void InStockMoreThan3()
        {
            var products = DataLoader.LoadProducts();

            //var results = products.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3);
            var results = from p in products
                where p.UnitsInStock > 0 && p.UnitPrice > 3
                select p;

            foreach (var product in results)
            {
                Console.WriteLine("{0} has {1} in stock with unit price {2}", product.ProductName,
                    product.UnitsInStock, product.UnitPrice);
            }
        }

        //12. Get only the first 3 orders from customers in Washington.
        private static void First3OrdersInWash()
        {
            var customers = DataLoader.LoadCustomers();

            // QUERY SYNTAX
            //var results = (from c in customers
            //    from o in c.Orders
            //    where c.Region == "WA"
            //    select new {c.CompanyName, o.OrderID, o.OrderDate}).Take(3);

            // METHOD SYNTAX
            var results = customers.SelectMany(cust => cust.Orders, (cust, order) => new {cust, order})
                .Where(wa => wa.cust.Region == "WA")
                .Select(order => new {order.cust.CompanyName, order.order.OrderID, order.order.OrderDate})
                .Take(3);

            foreach (var result in results)
            {
                Console.WriteLine($"{result.OrderDate} {result.OrderID} for {result.CompanyName}");
            }
        }

        //14. Get all except the first two orders from customers in Washington.
        private static void ReturnAfterFirstTwoInWash()
        {
            Console.WriteLine();
            var customers = DataLoader.LoadCustomers();

            // QUERY SYNTAX
            //var results = (from c in customers
            //    from o in c.Orders
            //    where c.Region == "WA"
            //    select new {c.CompanyName, o.OrderID, o.OrderDate}).Skip(2);

            // METHOD SYNTAX
            var results = customers.SelectMany(cust => cust.Orders, (cust, order) => new { cust, order })
                .Where(wa => wa.cust.Region == "WA")
                .Select(order => new { order.cust.CompanyName, order.order.OrderID, order.order.OrderDate })
                .Skip(2);

            foreach (var result in results)
            {
                Console.WriteLine($"{result.OrderDate} {result.OrderID} for {result.CompanyName}");
            }
        }

        //15. Get all the elements in NumbersC from the beginning until an element is greater or equal to 6.
        private static void ReturnAllBeforeGreaterThan6()
        {
            var numbersC = DataLoader.NumbersC;

            var results = numbersC.TakeWhile(n => n < 6);

            // This would just iterate the collection an extra time.
            // still returns the entire numbersC collection
            //var results = (from n in numbersC
            //               select n).TakeWhile(n => n < 6);

            foreach (var i in results)
            {
                Console.WriteLine(i);
            }
        }
    }
}
