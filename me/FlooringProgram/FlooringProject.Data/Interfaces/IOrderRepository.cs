using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlooringProject.Models;

namespace FlooringProject.Data.Interfaces
{
    public interface IOrderRepository
    {
        List<Order> GetAllOrdersByDate(string orderDate);

        Order CreateOrder(Order order);

        int GetNextOrderNumber();

        List<Order> DeleteOrder(int orderNumber);

        Order PullOrder(int orderNumber);

        Order UpdateOrder(Order order, int orderNumber);
    }
}
