using System;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;

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
            #region 

            //PrintOutOfStock();
            //Console.WriteLine();

            //InStockMoreThan3();
            //Console.WriteLine();

            //FindCustomersInWashington();
            //Console.WriteLine();

            //Skip2();
            //Console.WriteLine();

            //First3FromWA();
            //Console.WriteLine();

            //NewSequenceWithNameOfProducts();
            //Console.WriteLine();

            //SequenceOfHigherthan25();
            //Console.WriteLine();

            //ProductNamesToUpper();
            //Console.WriteLine();

            //prodNameCategoryUnitPrice();
            //Console.WriteLine();

            //Skip3InNumbersA();
            //Console.WriteLine();



            //NumberArrayRetuen();
            //Console.WriteLine();




            //NumbersDivBy3InNumC();
            //Console.WriteLine();



            //AlphaName();
            //Console.WriteLine();

            #endregion

            //7
            //*****************************
         //   EvenNumberUnits();
            //Console.WriteLine();


            //11
            //*****************************
           // FirstThreeNumbersA();
            //Console.WriteLine();


            //19
            //*****************************
            UnitsInStockDecending();
            Console.WriteLine();



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

        //3. Find all customers in Washington, print their name then their orders. (Region == "WA")
        private static void FindCustomersInWashington()
        {
            var customer = DataLoader.LoadCustomers();

            var results = from c in customer
                where c.Region == "WA"
                select c;




            Console.WriteLine("There are {0}", customer.Count);

        }

        //4. Create a new sequence with just the names of the products.
        private static void NewSequenceWithNameOfProducts()
        {
            var products = DataLoader.LoadProducts();


            var results = from p in products
                orderby p.ProductName
                select p;

            foreach (var p in results)
            {
                Console.WriteLine(p.ProductName);
            }
        }

        //5. Create a new sequence of products and unit prices where the unit prices are increased by 25%.
        private static void SequenceOfHigherthan25()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products
                where p.UnitPrice >= 25
                select new {p.ProductName, p.UnitPrice};

            foreach (var p in results)
            {
                Console.WriteLine($"{p.ProductName} has increased by {p.UnitPrice}");
            }
        }

        //6. Create a new sequence of just product names in all upper case.
        private static void ProductNamesToUpper()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products

                select p.ProductName.ToUpper();

            foreach (var prod in results)
            {
                Console.WriteLine(prod);
            }


        }


        //**************************
        //7. Create a new sequence with products with even numbers of units in stock.
        public static void EvenNumberUnits()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products
                where p.UnitsInStock%2 == 0
                select p;

            foreach (var result in results)
            {
                Console.WriteLine($"{result.ProductName} has {result.UnitsInStock}");
            }




        }

        //8. Create a new sequence of products with ProductName, Category, and rename UnitPrice to Price.
        public static void prodNameCategoryUnitPrice()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products

                select new {p.ProductName, p.Category, p.UnitPrice};

            foreach (var p in results)
            {
                Console.WriteLine($"{p.ProductName} is in the category {p.Category} and costs {p.UnitPrice}");
            }
        }

        //9. Make a query that returns all pairs of numbers from both arrays such that the number from numbersB is less than the number from numbersC.
        private static void PairsFromBandC()
        {
            //var b = DataLoader.NumbersB;

            //var c = DataLoader.NumbersC;


            //var result = 

        }

        //10. Select CustomerID, OrderID, and Total where the order total is less than 500.00.
        private static void TotalOver500()
        {
            //var customers = DataLoader.LoadCustomers();

            //var result = from c in  customers
            //             where c.Orders.Sum(order => 500
            //             )
        }



        //*********************
        //11. Write a query to take only the first 3 elements from NumbersA.
        private static void FirstThreeNumbersA()
        {
            var numbersA = DataLoader.NumbersA;

            var result = numbersA.Take(3);

            foreach (var i in result)
            {
                Console.WriteLine(i);
            }


        }

        //  12. Get only the first 3 orders from customers in Washington.
        private static void First3FromWA()
        {
            var customer = DataLoader.LoadCustomers();
            //wuetry
            //var results = (from c in customer
            //    from o in c.Orders
            //    where c.Region == "WA"
            //    select new {c.CompanyName, o.OrderID, o.OrderDate}).Take(3);


            //method syntax
            var results = customer.SelectMany(cust => cust.Orders, (cust, order) => new {cust, order})
                .Where(wa => wa.cust.Region == "WA")
                .Select(order => new {order.cust.CompanyName, order.order.OrderID, order.order.OrderDate})
                .Take(3);

            foreach (var result in results)
            {
                Console.WriteLine($"{result.OrderDate} {result.OrderID} for {result.CompanyName}");
            }

        }

        //13. Skip the first 3 elements of NumbersA.
        private static void Skip3InNumbersA()
        {
            var num = DataLoader.NumbersA;

            var results = from n in num.Skip(3) select n;

            foreach (var i in results)
            {
                Console.WriteLine(i);
            }

        }

        //14. Get all except the first two orders from customers in Washington.
        public static void Skip2()
        {
            var customer = DataLoader.LoadCustomers();
            //wuetry
            //var results = (from c in customer
            //    from o in c.Orders
            //    where c.Region == "WA"
            //    select new {c.CompanyName, o.OrderID, o.OrderDate}).Take(3);


            //method syntax
            var results = customer.SelectMany(cust => cust.Orders, (cust, order) => new {cust, order})
                .Where(wa => wa.cust.Region == "WA")
                .Select(order => new {order.cust.CompanyName, order.order.OrderID, order.order.OrderDate})
                .Skip(2);

            foreach (var result in results)
            {
                Console.WriteLine($"{result.OrderDate} {result.OrderID} for {result.CompanyName}");
            }

        }

        //15. Get all the elements in NumbersC from the beginning until an element is greater or equal to 6.
        private static void AllBeforeGreaterThan6()
        {
            var numbersC = DataLoader.NumbersC;

            var results = numbersC.TakeWhile(n => n < 6);

            foreach (var i in results)
            {
                Console.WriteLine(i);
            }


        }

        //16. Return elements starting from the beginning of NumbersC until a number is hit that is less than its position in the array.
        private static void NumberArrayRetuen()
        {
            //var num = DataLoader.NumbersC;

            //var result = from i in num
            //             where num
            //    select i;

            //foreach (var i in result)
            //{
            //    Console.WriteLine(i);
            //}

        }
     
        //17. Return elements from NumbersC starting from the first element divisible by 3.
        private static void NumbersDivBy3InNumC()
        {
            var num = DataLoader.NumbersC;

            var result = from i in num
                where i%3 == 0
                select i;

            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
        }

        //18. Order products alphabetically by name.
        private static void AlphaName()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products
                orderby (p.ProductName)
                select p.ProductName;


            foreach (var p in results)
            {
                Console.WriteLine(p);
            }
        }








        //***********************************************
        //19. Order products by UnitsInStock descending.
        private static void UnitsInStockDecending()
        {
            var products = DataLoader.LoadProducts();

            var results = products.OrderByDescending(p => p.UnitsInStock);

            foreach (var product in results)
            {
                Console.WriteLine($"{product.UnitsInStock} are left in {product.ProductName}");
            }
        }


        //20. Sort the list of products, first by category, and then by unit price, from highest to lowest.
            private static void ListOfProductsCatPriceHigh2Low()
            {
            //    var products = DataLoader.LoadProducts();


            //var results = from p in products(p => p.ca)
                      
                          
            }
        


    }
}



