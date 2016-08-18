using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWCCorpADO.Data;
using SWCCorpADO.Models;

namespace SWCCorpADO
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new SWCCorpDapperRepository();
            var employees = repo.GetAllEmployees();

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} - {((DateTime)employee.HireDate).ToShortDateString()}");
            }

            Employee newEmployee = new Employee()
            {
                EmpId = 13,
                FirstName = "Victor",
                LastName = "Pudelski",
                HireDate = DateTime.Parse("06/08/1999")
            };

            repo.AddEmployee(newEmployee);
            Console.WriteLine("Check the table for the new result");

            Console.ReadLine();
        }
    }
}
