using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using FlooringProgram.BLL;
using FlooringProject.Data;
using FlooringProject.Models;

namespace FlooringProgram.UI.WorkFlow
{
    public class AddWorkFlow
    {
        public void Execute()
        {
            //bool correctData = false;
            //do
            //{
            string name = GetNameForOrder();
            string state = GetStateForOrder();
            string productType = GetProductTypeForOrder();
            decimal area = GetAreaForOrder();


            ProductOperations po = new ProductOperations();
            OrderOperations addOrderOperations = new OrderOperations(OrderRepositoryFactory.CreateOrderRepository());
            StateOperations so = new StateOperations();
            State stateInformation = new State();
            Product ProductInfornmation = po.GetProductByName(productType);
            stateInformation = so.GetStateByName(state);


            decimal MaterialCost = area*ProductInfornmation.MaterialCostPerSqFoot;
            decimal LaborCost = area*ProductInfornmation.LaborCostPerSqFoot;
            decimal TaxTotal = (LaborCost + MaterialCost)*(stateInformation.TaxRate/100);
            decimal OrderTotal = MaterialCost + LaborCost + TaxTotal;


            Order newOrder = new Order()
            {
                //    OrderNumber = newOrderNumber,
                CustomerName = name,
                DateTime = DateTime.Now.ToShortDateString(),
                State = state,
                TaxRate = stateInformation.TaxRate,
                ProductType = ProductInfornmation.ProductType,
                Area = area,
                MaterialCostPerSqFt = ProductInfornmation.MaterialCostPerSqFoot,
                LaborCostPerSqFt = ProductInfornmation.LaborCostPerSqFoot,
                TotalMaterialCost = MaterialCost,
                TotalLaborCost = LaborCost,
                TotalTaxCost = TaxTotal,
                TotalOrderCost = OrderTotal
            };

            bool isValid = false;
            string confirm = "";
            while (!isValid)
            {
                DisplayNewOrder(MaterialCost, LaborCost, TaxTotal, OrderTotal, newOrder);

                Console.WriteLine();
                Console.WriteLine("Is all the information correct?");
                Console.WriteLine("Enter (Y) or (N)");

                confirm = Console.ReadLine().ToUpper();

                if (string.IsNullOrEmpty(confirm))
                {
                    isValid = false;
                    Console.WriteLine("Please enter (Y) or (N)");
                    Console.WriteLine("Press ENTER to continue");
                    Console.ReadLine();
                }
                else if ((confirm != "N") && (confirm != "Y"))
                {
                    isValid = false;
                    Console.WriteLine("{0} is not a \"Y\" or \"N\"", confirm);
                    Console.WriteLine("Press ENTER to continue");
                    Console.ReadLine();
                }
                else
                {
                    isValid = true;
                }

            }


            if (confirm == "Y")
            {
                var test = addOrderOperations.CreateNewOrder(newOrder);
                if (test.IsValid)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("your order was added");
                    Console.WriteLine();
                    Console.WriteLine("The order number is {0}", newOrder.OrderNumber);
                    Console.WriteLine("The date of the order is {0}", newOrder.DateTime);
                    Console.WriteLine();
                    Console.WriteLine("Press ENTER to Continue.");
                    Console.ReadLine();
                }
            }
        }

        public string GetNameForOrder()
        {
            bool validName = false;
            string name = "";
            do
            {
                Console.Clear();
                Console.Write("Please enter a name for the order: ");

                name = Console.ReadLine();

                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine();
                    Console.WriteLine("A name must be entered to begin the order.");
                    Console.WriteLine("Press ENTER to continue.");
                    Console.ReadLine();
                }
                else if (!name.All(char.IsLetter))
                {
                    Console.WriteLine();
                    Console.WriteLine("Only letters are allowed in the NAME.");
                    Console.WriteLine("Press ENTER to continue.");
                    Console.ReadLine();
                }
                else
                {
                    validName = true;
                }

            } while (validName != true);

            return name;
        }

        public string GetStateForOrder()
        {
            bool validState = false;
            string state = "";
            do
            {
                bool emptyString = true;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Please enter the State for the order: ");
                    Console.Write("Ohio - Indiana - Pennsylvania - Michigan: ");

                    state = Console.ReadLine();

                    if (state == "")
                    {
                        Console.WriteLine();
                        Console.WriteLine("A State must be entered.");
                        Console.WriteLine("Press ENTER to continue.");
                        Console.ReadLine();
                        emptyString = true;
                    }
                    else
                    {
                        emptyString = false;
                    }
                } while (emptyString == true);

                string start = state.Substring(0, 1).ToUpper();
                string end = state.Substring(1).ToLower();

                state = start + end;


                if ((state != "Ohio") && (state != "Indiana") && (state != "Pennsylvania") && (state != "Michigan"))
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter a state that is in our network");
                    Console.WriteLine("Ohio - Indiana - Pennsylvania - Michigan");
                    Console.WriteLine("Press ENTER to continue.");
                    Console.ReadLine();
                }
                else
                {
                    validState = true;
                }
            } while (validState == false);

            return state;
        }

        public string GetProductTypeForOrder()
        {
            bool validProduct = false;
            string product = "";
            do
            {
                bool emptyString = true;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Please enter what kind of floor you would like.");
                    Console.Write("Wood - Tile - Laminate - Carpet: ");

                    product = Console.ReadLine();

                    if (product == "")
                    {
                        Console.WriteLine();
                        Console.WriteLine("A flooring type must be entered.");
                        Console.WriteLine("Press ENTER to continue.");
                        Console.ReadLine();
                        emptyString = true;
                    }
                    else
                    {
                        emptyString = false;
                    }
                } while (emptyString == true);

                string start = product.Substring(0, 1).ToUpper();
                string end = product.Substring(1).ToLower();

                product = start + end;


                if ((product != "Tile") && (product != "Wood") && (product != "Laminate") && (product != "Carpet"))
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter a flooring that we install");
                    Console.WriteLine("Wood - Tile - Laminate - Carpet");
                    Console.WriteLine("Press ENTER to continue.");
                    Console.ReadLine();
                }
                else
                {
                    validProduct = true;
                }

            } while (validProduct == false);

            return product;
        }

        public decimal GetAreaForOrder()
        {
            bool validArea = false;
            decimal area = 0;
            do
            {
                Console.Clear();
                Console.Write("Please enter the total square footage of the area to cover: ");

                string areaString = Console.ReadLine();

                if (areaString == "")
                {
                    Console.WriteLine();
                    Console.WriteLine("A square footage must be entered to continue.");
                    Console.WriteLine("Press ENTER to continue.");
                    Console.ReadLine();
                }
                else if (!decimal.TryParse(areaString, out area))
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter a valid square footage ammount");
                    Console.WriteLine("Press ENTER to continue.");
                    Console.ReadLine();
                }
                else
                {
                    validArea = true;
                }

            } while (validArea == false);

            return area;
        }

        public void DisplayNewOrder(decimal totalMaterialCost, decimal totalLaborCost, decimal taxTotal,
            decimal totalCost, Order newOrder)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("***************************************");
            Console.WriteLine("****Not Committed Order Information****");
            Console.WriteLine("***************************************");

            Console.Write("Order Number:".PadRight(25));
            Console.WriteLine("{0} ", newOrder.OrderNumber);

            Console.Write("Date:".PadRight(25));
            Console.WriteLine("{0}", newOrder.DateTime);

            Console.Write("Customer Name:".PadRight(25));
            Console.WriteLine("{0}", newOrder.CustomerName);

            Console.Write("State Name:".PadRight(25));
            Console.WriteLine("{0}", newOrder.State);

            Console.Write("Tax Rate:".PadRight(25));
            Console.WriteLine("{0:p}", (newOrder.TaxRate/100));

            Console.Write("Product Type:".PadRight(25));
            Console.WriteLine("{0}", newOrder.ProductType);

            Console.Write("Material Cost Per SQ:".PadRight(25));
            Console.WriteLine("{0:c}", newOrder.MaterialCostPerSqFt);

            Console.Write("Labor Cost Per SQ:".PadRight(25));
            Console.WriteLine("{0:C}", newOrder.LaborCostPerSqFt);

            Console.Write("Area:".PadRight(25));
            Console.WriteLine("{0}", newOrder.Area);

            Console.Write("Total Material Cost:".PadRight(25));
            Console.WriteLine("{0:c}", newOrder.TotalMaterialCost);

            Console.Write("Total Labor Cost:".PadRight(25));
            Console.WriteLine("{0:c}", newOrder.TotalLaborCost);

            Console.Write("Total Tax Cost:".PadRight(25));
            Console.WriteLine("{0:c}", newOrder.TotalTaxCost);

            Console.Write("Total:".PadRight(25));
            Console.WriteLine("{0:c}", newOrder.TotalOrderCost);
        }
    }
}

