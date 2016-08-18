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
    public class EditOrderWorkFlow
    {
        public void Execute()
        {
            DisplayOrderWorkFlow displayOrder = new DisplayOrderWorkFlow();
            string dateToSearch = displayOrder.GetOrderDate();
            displayOrder.OrderInformationSearch(dateToSearch);

            int editThisOrderNumber = GetOrderNumberToEdit();

            OrderOperations pullOrder = new OrderOperations(OrderRepositoryFactory.CreateOrderRepository());
            var orderToEdit = pullOrder.PullingOrder(editThisOrderNumber);

            DisplayOrderToEdit(orderToEdit);
        }

        public int GetOrderNumberToEdit()
        {
            Console.WriteLine();
            Console.WriteLine("Enter the Order # of the Order you wish to edit");
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

        public void DisplayOrderToEdit(Order order)
        {
            string areaToEdit = "";
            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("***************************************");
                Console.WriteLine("**************EDIT ORDER***************");
                Console.WriteLine("***************************************");

                Console.Write("Order Number:".PadRight(25));
                Console.WriteLine("{0} ", order.OrderNumber);

                Console.Write("Date:".PadRight(25));
                Console.WriteLine("{0}", order.DateTime);

                Console.WriteLine();

                Console.Write("1.) Customer Name:".PadRight(25));
                Console.WriteLine("{0}", order.CustomerName);

                Console.Write("2.) State Name:".PadRight(25));
                Console.WriteLine("{0}", order.State);

                Console.Write("3.) Product Type:".PadRight(25));
                Console.WriteLine("{0}", order.ProductType);

                Console.Write("4.) Area:".PadRight(25));
                Console.WriteLine("{0}", order.Area);

                Console.WriteLine();

                Console.WriteLine("5.) Update Order");
                Console.WriteLine("6.) Quit");

                Console.WriteLine();
                Console.Write("Select an area to to edit: ");
                areaToEdit = Console.ReadLine();

                if (areaToEdit != "6")
                {
                    EditSwitch(areaToEdit, order);
                }
            } while (areaToEdit != "6" && areaToEdit != "5");
        }

        public void EditSwitch(string areaToEdit, Order order)
        {
            AddWorkFlow editAddWorkFlow = new AddWorkFlow();

            switch (areaToEdit)
            {
                case "1":
                    string updatedName = editAddWorkFlow.GetNameForOrder();
                    order.CustomerName = updatedName;

                    break;
                case "2":
                    string updatedState = editAddWorkFlow.GetStateForOrder();
                    order.State = updatedState;
                    break;
                case "3":
                    string updatedProductType = editAddWorkFlow.GetProductTypeForOrder();
                    order.ProductType = updatedProductType;
                    break;
                case "4":
                    decimal updatedArea = editAddWorkFlow.GetAreaForOrder();
                    order.Area = updatedArea;
                    break;
                case "5":
                    OrderOperations updateOrder = new OrderOperations(OrderRepositoryFactory.CreateOrderRepository());
                    updateOrder.UpdateOrder(order, order.OrderNumber);

                    Console.Clear();
                    Console.WriteLine("The order with the order number of {0} has been updated", order.OrderNumber);
                    Console.WriteLine("Press ENTER to continue.");
                    Console.ReadLine();

                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("{0} is not a valid choice.", areaToEdit);
                    Console.WriteLine("Press ENTER to continue.");
                    Console.ReadLine();
                    break;

            }
        }
    }
}
