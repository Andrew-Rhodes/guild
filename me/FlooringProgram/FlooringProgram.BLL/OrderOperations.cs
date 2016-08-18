using FlooringProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using FlooringProject.Data;
using FlooringProject.Data.Factories;
using FlooringProject.Data.Interfaces;

namespace FlooringProgram.BLL
{
    public class OrderOperations
    {
        private readonly IOrderRepository _orderRepository;

        public OrderOperations(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public OrderInfoPackage GetOrder(string orderDate)
        {
            var orderInfo = new OrderInfoPackage();

            var order = _orderRepository.GetAllOrdersByDate(orderDate);

            if (order == null || order.Count() == 0)
            {
                orderInfo.IsValid = false;
            }
            else
            {
                orderInfo.IsValid = true;
                orderInfo.OrderInformation = order;
            }
            return orderInfo;
        }

        //public OrderInfoPackage CreateNewOrder(string name, string state, string productType, decimal area)
        //{
        //    var repo = OrderRepositoryFactory.CreateOrderRepository();

        //    var orderInfo = new OrderInfoPackage();

        //    StateOperations getStateInfo = new StateOperations();
        //    var stateInfotmation = getStateInfo.GetStateByName(state);

        //    ProductOperations getProductInfo = new ProductOperations();
        //    var productInformation = getProductInfo.GetProductByName(productType);

        //    decimal MaterialCost = area*productInformation.MaterialCostPerSqFoot;
        //    decimal LaborCost = area*productInformation.LaborCostPerSqFoot;
        //    decimal TaxTotal = (LaborCost + MaterialCost)*(stateInfotmation.TaxRate/100);
        //    decimal OrderTotal = MaterialCost + LaborCost + TaxTotal;

        //    int newOrderNumber = repo.GetNextOrderNumber();

        //    Order newOrder = new Order()
        //    {
        //        OrderNumber = newOrderNumber,
        //        CustomerName = name,
        //        DateTime = DateTime.Today.ToShortDateString(),
        //        State = state,
        //        TaxRate = stateInfotmation.TaxRate,
        //        ProductType = productInformation.ProductType,
        //        Area = area,
        //        MaterialCostPerSqFt = productInformation.MaterialCostPerSqFoot,
        //        LaborCostPerSqFt = productInformation.LaborCostPerSqFoot,
        //        TotalMaterialCost = MaterialCost,
        //        TotalLaborCost = LaborCost,
        //        TotalTaxCost = TaxTotal,
        //        TotalOrderCost = OrderTotal
        //    };
        //    //--------------------------------Try this later-------------------------------------
        //    //Console.WriteLine();
        //    //foreach (PropertyDescriptor i in TypeDescriptor.GetProperties(newOrder))
        //    //{
        //    //    string title = i.Name;
        //    //    object value = i.GetValue(newOrder);

        //    //    Console.WriteLine("{0} {1}", title.PadRight(25), value);
        //    //}
        //    //Console.ReadLine();

        //    bool goodInformationToAdd = false;
        //    do
        //    {
        //        Console.Clear();
        //        Console.WriteLine();
        //        Console.WriteLine("***************************************");
        //        Console.WriteLine("****Not Committed Order Information****");
        //        Console.WriteLine("***************************************");

        //        Console.Write("Order Number:".PadRight(25));
        //        Console.WriteLine("{0} ", newOrder.OrderNumber);

        //        Console.Write("Date:".PadRight(25));
        //        Console.WriteLine("{0}", newOrder.DateTime);

        //        Console.Write("Customer Name:".PadRight(25));
        //        Console.WriteLine("{0}", newOrder.CustomerName);

        //        Console.Write("State Name:".PadRight(25));
        //        Console.WriteLine("{0}", newOrder.State);

        //        Console.Write("Tax Rate:".PadRight(25));
        //        Console.WriteLine("{0:p}", (newOrder.TaxRate/100));

        //        Console.Write("Product Type:".PadRight(25));
        //        Console.WriteLine("{0}", newOrder.ProductType);

        //        Console.Write("Material Cost Per SQ:".PadRight(25));
        //        Console.WriteLine("{0:c}", newOrder.MaterialCostPerSqFt);

        //        Console.Write("Labor Cost Per SQ:".PadRight(25));
        //        Console.WriteLine("{0:C}", newOrder.LaborCostPerSqFt);

        //        Console.Write("Area:".PadRight(25));
        //        Console.WriteLine("{0}", newOrder.Area);

        //        Console.Write("Total Material Cost:".PadRight(25));
        //        Console.WriteLine("{0:c}", newOrder.TotalMaterialCost);

        //        Console.Write("Total Labor Cost:".PadRight(25));
        //        Console.WriteLine("{0:c}", newOrder.TotalLaborCost);

        //        Console.Write("Total Tax Cost:".PadRight(25));
        //        Console.WriteLine("{0:c}", newOrder.TotalTaxCost);

        //        Console.Write("Total:".PadRight(25));
        //        Console.WriteLine("{0:c}", newOrder.TotalOrderCost);

        //        Console.WriteLine();
        //        Console.WriteLine("Is all the information correct?");
        //        Console.WriteLine("Enter (Y) or (N)");

        //        string continueAnswer = Console.ReadLine().ToUpper();


        //        if (continueAnswer == "N")
        //        {
        //            orderInfo.IsValid = false;
        //            return orderInfo;
        //        }



        //        if ((continueAnswer != "N") && (continueAnswer != "Y"))
        //        {
        //            Console.WriteLine("Invalid Choice...ENTER to continue");
        //            Console.ReadLine();
        //        }
        //        else if (continueAnswer == "Y")
        //        {
        //            goodInformationToAdd = true;
        //        }
        //    } while (goodInformationToAdd != true);



        //    List<Order> AddingOrder = new List<Order>();
        //    AddingOrder.Add(newOrder);

        //    var addOrder = repo.CreateOrder(newOrder);

        //    if (addOrder != null)
        //    {
        //        orderInfo.IsValid = true;
        //    }
        //    else
        //    {
        //        orderInfo.IsValid = false;
        //    }

        //    return orderInfo;
        //}

        public OrderInfoPackage CreateNewOrder(Order newOrder)
        {
            var repo = OrderRepositoryFactory.CreateOrderRepository();
            var orderInfo = new OrderInfoPackage();
            var test = repo.CreateOrder(newOrder);

            if (test != null)
            {
                orderInfo.IsValid = true;
            }
            else
            {
                orderInfo.IsValid = false;
            }

            return orderInfo;
        }

        public int RemoveOrder(int orderNumber)
        {
            var repo = OrderRepositoryFactory.CreateOrderRepository();
            var orderInfo = new OrderInfoPackage();

            var test = repo.DeleteOrder(orderNumber);

            orderInfo.OrderInformation = test;

            return orderNumber;
        }

        public Order PullingOrder(int orderNumber)
        {
            var repo = OrderRepositoryFactory.CreateOrderRepository();
            var pulledOrder = repo.PullOrder(orderNumber);

            return pulledOrder;
        }

        public void UpdateOrder(Order order, int orderNumber)
        {
            var repo = OrderRepositoryFactory.CreateOrderRepository();
            repo.UpdateOrder(order, orderNumber);
        }
    }
}
