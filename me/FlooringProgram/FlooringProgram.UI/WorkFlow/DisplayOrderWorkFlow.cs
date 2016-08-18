using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using FlooringProgram.BLL;
using FlooringProject.Data;
using FlooringProject.Models;

namespace FlooringProgram.UI.WorkFlow
{
    public class DisplayOrderWorkFlow
    {
        private List<Order> _currentOrderList;

        public void Execute()
        {
            string dateToSearch = GetOrderDate();
            OrderInformationSearch(dateToSearch);
            Console.WriteLine();
            Console.WriteLine("Press ENTER to return to main Menu.");
            Console.ReadLine();
        }

        public string GetOrderDate()
        {
            bool validDate = false;
            string orderDate = "";
            do
            {
                Console.Clear();
                Console.WriteLine("Enter the date the order was placed.");
                Console.Write("EX: mm/dd/yyyy : ");
                orderDate = Console.ReadLine();


                DateTime dt;

                if (!DateTime.TryParse(orderDate, out dt))
                {
                    Console.WriteLine();
                    Console.WriteLine("That was not a valid date...");
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();
                    validDate = false;
                }
                else
                {
                    validDate = true;
                }

            } while (validDate == false);


            if (orderDate.StartsWith("0"))
            {
                orderDate = orderDate.Substring(1);
            }


            if (orderDate.Substring(2, 1) == "0")
            {
                string start = orderDate.Substring(0, 2);
                string end = orderDate.Substring(3);

                orderDate = start + end;
            }

            return orderDate;
        }


        public void OrderInformationSearch(string dateToSearch)
        {
            OrderOperations orderOps = new OrderOperations(OrderRepositoryFactory.CreateOrderRepository());

            var returnedOrder = orderOps.GetOrder(dateToSearch);

            if (returnedOrder.IsValid)
            {
                _currentOrderList = returnedOrder.OrderInformation;

                DisplayOrderInformation();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("No order with that date.");
                Console.WriteLine("Returning to the Main Menu.");
            }
        }


        public void DisplayOrderInformation()
        {
            for (int i = 0; i < _currentOrderList.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine("           Order Information");
                Console.WriteLine("---------------------------------------");
                Console.Write("Order Number:".PadRight(25));
                Console.WriteLine("{0} ", _currentOrderList[i].OrderNumber);

                Console.Write("Date:".PadRight(25));
                Console.WriteLine("{0}", _currentOrderList[i].DateTime);

                Console.Write("Customer Name:".PadRight(25));
                Console.WriteLine("{0}", _currentOrderList[i].CustomerName);

                StateOperations state = new StateOperations();
                var states = state.GetStateByName(_currentOrderList[i].State);

                if (states != null)
                {
                    Console.Write("State Name:".PadRight(25));
                    Console.WriteLine("{0}", states.StateName);

                    Console.Write("State Abbreviation:".PadRight(25));
                    Console.WriteLine("{0}", states.StateAbbreviation);

                    Console.Write("Tax Rate:".PadRight(25));
                    Console.WriteLine("{0:p}", (states.TaxRate/100));
                }

                //Console.Write("State Name:".PadRight(25));
                //Console.WriteLine("{0}", _currentOrderList[i].State);

                //Console.Write("Tax Rate:".PadRight(25));
                //Console.WriteLine("{0:p}", (_currentOrderList[i].TaxRate / 100));

                ProductOperations product = new ProductOperations();
                var products = product.GetProductByName(_currentOrderList[i].ProductType);

                if (product != null)
                {
                    Console.Write("Product Type:".PadRight(25));
                    Console.WriteLine("{0}", products.ProductType);

                    Console.Write("Material Cost Per SQ:".PadRight(25));
                    Console.WriteLine("{0:c}", products.MaterialCostPerSqFoot);

                    Console.Write("Labor Cost Per SQ:".PadRight(25));
                    Console.WriteLine("{0:C}", products.LaborCostPerSqFoot);
                }

                //Console.Write("Product Type:".PadRight(25));
                //Console.WriteLine("{0}", _currentOrderList[i].ProductType);

                //Console.Write("Material Cost Per SQ:".PadRight(25));
                //Console.WriteLine("{0:c}", _currentOrderList[i].MaterialCostPerSqFt);

                //Console.Write("Labor Cost Per SQ:".PadRight(25));
                //Console.WriteLine("{0:C}", _currentOrderList[i].LaborCostPerSqFt);

                Console.Write("Area:".PadRight(25));
                Console.WriteLine("{0}", _currentOrderList[i].Area);

                decimal totalMaterialCost = _currentOrderList[i].Area*products.MaterialCostPerSqFoot;
                decimal toatlLaborCost = _currentOrderList[i].Area*products.LaborCostPerSqFoot;
                decimal totalTaxCost = ((states.TaxRate/100)*(totalMaterialCost + toatlLaborCost));
                decimal totalOrderCost = totalTaxCost + toatlLaborCost + totalMaterialCost;


                Console.Write("Total Material Cost:".PadRight(25));
                Console.WriteLine("{0:c}", totalMaterialCost);

                Console.Write("Total Labor Cost:".PadRight(25));
                Console.WriteLine("{0:c}", toatlLaborCost);

                Console.Write("Total Tax Cost:".PadRight(25));
                Console.WriteLine("{0:c}", totalTaxCost);

                Console.Write("Total:".PadRight(25));
                Console.WriteLine("{0:c}", totalOrderCost);
            }
        }
    }
}
