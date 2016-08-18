using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlooringProgram.BLL;
using FlooringProject.Data;
using FlooringProject.Models;

namespace FlooringProgram.UI.WorkFlow
{
    public class RemoveOrderWorkFlow
    {

        public void Execute()
        {
            DisplayOrderWorkFlow displayOrder = new DisplayOrderWorkFlow();
            string dateToSearch = displayOrder.GetOrderDate();
            displayOrder.OrderInformationSearch(dateToSearch);
            int deleteThisOrderNumber = GetOrderNumberToDelete();

            OrderOperations pullOrderOperations = new OrderOperations(OrderRepositoryFactory.CreateOrderRepository());
            var order = pullOrderOperations.PullingOrder(deleteThisOrderNumber);

            OrderOperations remove = new OrderOperations(OrderRepositoryFactory.CreateOrderRepository());

            bool isValid = false;
            string confirm = "";
            while (!isValid)
            {
                DisplayRemoveOrder(order);

                Console.WriteLine();
                Console.WriteLine("Are you sure?");
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


                if (confirm == "Y")
                {
                    var test = remove.RemoveOrder(deleteThisOrderNumber);

                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("The odrer with the number of {0}, has been removed", test);
                    Console.WriteLine("Press ENTER to Continue.");
                    Console.ReadLine();
                }
            }
        }

        public int GetOrderNumberToDelete()
        {
            Console.WriteLine();
            Console.WriteLine("Enter the Order # of the Order you wish to delete.");
            string stringChoice = Console.ReadLine();

            int choice = 0;
            if (!int.TryParse(stringChoice, out choice))
            {
                Console.WriteLine();
                Console.WriteLine("Enter a valid number");
                Console.WriteLine("Press ENTER to continue.");
                Console.ReadLine();
            }

            return choice;
        }

        public void DisplayRemoveOrder(Order newOrder)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("***************************************");
            Console.WriteLine("************ORDER TO REMOVE************");
            Console.WriteLine("***************************************");

            Console.Write("Order Number:".PadRight(25));
            Console.WriteLine("{0} ", newOrder.OrderNumber);

            Console.Write("Date:".PadRight(25));
            Console.WriteLine("{0}", newOrder.DateTime);

            Console.Write("Customer Name:".PadRight(25));
            Console.WriteLine("{0}", newOrder.CustomerName);

            Console.Write("State Name:".PadRight(25));
            Console.WriteLine("{0}", newOrder.State);

            Console.Write("Product Type:".PadRight(25));
            Console.WriteLine("{0}", newOrder.ProductType);

            Console.Write("Area:".PadRight(25));
            Console.WriteLine("{0}", newOrder.Area);
        }
    }
}
