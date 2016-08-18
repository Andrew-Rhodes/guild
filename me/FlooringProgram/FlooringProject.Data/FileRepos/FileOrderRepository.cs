using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlooringProject.Data.Interfaces;
using FlooringProject.Models;

namespace FlooringProject.Data
{
    public class FileRepository : IOrderRepository
    {
        private const string FILENAME = @"DataFiles\orders.txt";

        public static List<Order> OrderList { get; private set; }

        static FileRepository()
        {
            using (StreamReader sr = File.OpenText(FILENAME))
            {
                OrderList = new List<Order>();

                string inputLine = "";
                string[] inputParts;
                while ((inputLine = sr.ReadLine()) != null)
                {
                    inputParts = inputLine.Split('|');
                    var thisOrder = new Order()
                    {
                        OrderNumber = int.Parse(inputParts[0]),
                        DateTime = inputParts[1],
                        CustomerName = inputParts[2],
                        State = inputParts[3],
                        Area = decimal.Parse(inputParts[4]),
                        ProductType = inputParts[5]
                    };

                    OrderList.Add(thisOrder);
                }
            }
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

        //public List<Order> GetAllOrdersByDate(string orderDate)
        //{
        //    throw new NotImplementedException();
        //}

        public Order CreateOrder(Order order)
        {
            //string orderDate = order.DateTime;
            //DateTime dt = new DateTime();
            //var date = DateTime.Parse(orderDate, out dts);


            string fileDate = DateTime.Now.ToString("_MMddyyy");

            order.OrderNumber = GetNextOrderNumber();
            OrderList.Add(order);

          //  using (StreamWriter sw = new StreamWriter(fileDate))
            using (StreamWriter sw = new StreamWriter(FILENAME))
            {
                foreach (var a in OrderList)
                {
                    sw.WriteLine($"{a.OrderNumber}|{a.DateTime}|{a.CustomerName}|{a.State}|{a.Area}|{a.ProductType}");
                }
            }

            return order;
        }

        public int GetNextOrderNumber()
        {
            int orderNumber = 1;

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

        public List<Order> DeleteOrder(int orderNumber)
        {
            for (int i = 0; i < OrderList.Count; i++)
            {
                if (OrderList[i].OrderNumber == orderNumber)
                {
                    OrderList.Remove(OrderList[i]);
                }
            }

            using (StreamWriter sw = new StreamWriter(FILENAME, false))
            {
                foreach (var a in OrderList)
                {
                    sw.WriteLine($"{a.OrderNumber}|{a.DateTime}|{a.CustomerName}|{a.State}|{a.Area}|{a.ProductType}");
                }
            }

            return OrderList;
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

            using (StreamWriter sw = new StreamWriter(FILENAME, false))
            {
                foreach (var a in OrderList)
                {
                    sw.WriteLine($"{a.OrderNumber}|{a.DateTime}|{a.CustomerName}|{a.State}|{a.Area}|{a.ProductType}");
                }
            }

            return order;
        }
    }
}
