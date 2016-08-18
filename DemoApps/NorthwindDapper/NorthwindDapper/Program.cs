using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindDapper.Data;
using NorthwindDapper.Models;

namespace NorthwindDapper
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAllEmployees();

            //InsertRegion();

            ComplexObject();

            Console.ReadLine();
        }

        static void GetAllEmployees()
        {
            NorthwindRepository repo = new NorthwindRepository();

            List<Employee> employees = repo.GetAllEmployees();

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} reports to {employee.ReportsTo} - {employee.ManagerName}");
                Console.WriteLine($"{employee.Title} - {employee.BirthDate} - {employee.EmployeeId}");
                Console.WriteLine();
            }
        }

        static void InsertRegion()
        {
            var repo = new NorthwindRepository();
            int regionId = repo.InsertRegion("OHIO");

            Console.WriteLine($"Your new region has id = {regionId}");
        }

        static void ComplexObject()
        {
            var repo = new NorthwindRepository();
            List<Customer> customers = repo.GetAllCustomers();

            foreach (var customer in customers)
            {
                Console.WriteLine($"{customer.CustomerId} {customer.CustomerName}");

                foreach (var order in customer.Orders)
                {
                    Console.WriteLine($"{order.OrderId} {order.OrderDate}");
                }

                Console.WriteLine();
            }

        }
    }
}
