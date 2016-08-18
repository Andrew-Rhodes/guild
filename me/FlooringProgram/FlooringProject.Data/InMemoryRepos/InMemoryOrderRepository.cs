using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using FlooringProject.Data.Interfaces;
using FlooringProject.Models;

namespace FlooringProject.Data
{
    public class InMemoryOrderRepository : IOrderRepository
    {
        public static List<Order> OrderList { get; private set; }

        static InMemoryOrderRepository()
        {
            OrderList = new List<Order>();

            OrderList.Add(

                new Order()
                {
                    OrderNumber = 1,
                    DateTime = "1/1/2016",
                    CustomerName = "Mark Tremonti",
                    State = "Ohio",
                    Area = 1.00m,
                    ProductType = "Carpet",
                });

            OrderList.Add(

                new Order()
                {
                    OrderNumber = 2,
                    DateTime = "1/1/2016",
                    CustomerName = "ozzy",
                    State = "Michigan",
                    Area = 10.00m,
                    ProductType = "Carpet",
                });
        }

        public List<Order> GetAllOrdersByDate(string orderDate)
        {
            List<Order> listOfOrders = new List<Order>();

            foreach (var order in OrderList)
            {
                if (order.DateTime == orderDate)
                {
                    listOfOrders.Add(order);
                }
            }

            return listOfOrders;
        }

        public Order CreateOrder(Order order)
        {
            order.OrderNumber = GetNextOrderNumber();
            OrderList.Add(order);

            return order;
        }

        public int GetNextOrderNumber()
        {
            int orderNumber = 0;

            if (OrderList.Count != 0)
            {
                orderNumber = OrderList.Count;
            }

            orderNumber = orderNumber + 1;

            bool numberCheck = false;
            do
            {
                foreach (var i in OrderList)
                {
                    if (i.OrderNumber == orderNumber)
                    {
                        orderNumber = orderNumber + 1;
                        numberCheck = false;
                    }
                    else
                    {
                        numberCheck = true;
                    }
                }
            } while (numberCheck != true);

            return orderNumber;
        }

        //do i need to return the list?
        public List<Order> DeleteOrder(int orderNumber)
        {

            for (int i = 0; i < OrderList.Count; i++)
            {
                if (OrderList[i].OrderNumber == orderNumber)
                {
                    OrderList.Remove(OrderList[i]);
                    //creates a Null exception
                    //OrderList[i] = null;
                }
            }

            return OrderList;

            //List<Order> listOfOrders = new List<Order>();

            //foreach (var order in OrderList)
            //{
            //    if (order.OrderNumber != orderNumber)
            //    {
            //        OrderList.Remove(order);
            //    }
            //}
        }

        public Order PullOrder(int orderNumber)
        {

            Order editOrder = new Order();

            for (int i = 0; i < OrderList.Count; i++)
            {
                if (OrderList[i].OrderNumber == orderNumber)
                {
                    editOrder = OrderList[i];
                }
            }
            return editOrder;
        }

        public Order UpdateOrder(Order order, int orderNumber)
        {
            for (int i = 0; i < OrderList.Count; i++)
            {
                if (OrderList[i].OrderNumber == orderNumber)
                {
                    OrderList.Remove(OrderList[i]);
                }
            }

            OrderList.Add(order);

            return order;
        }
    }
}


