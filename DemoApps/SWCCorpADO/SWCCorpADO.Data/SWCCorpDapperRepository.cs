using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using SWCCorpADO.Models;

namespace SWCCorpADO.Data
{
    public class SWCCorpDapperRepository
    {
        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();

            using (
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["SWCCorp"].ConnectionString)
                )
            {
                employees = cn.Query<Employee>(@"SELECT e.EmpID, e.FirstName, e.LastName, e.HireDate
                                    FROM Employee e").ToList();
            }

            return employees;
        }

        public void AddEmployee(Employee employee)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["SWCCorp"].ConnectionString))
            {
                cn.Execute(@"INSERT Employee(EmpId, FirstName, LastName, HireDate) 
                                VALUES (@EmpId, @FirstName, @LastName, @HireDate)", employee);
            }
        }
    }
}
