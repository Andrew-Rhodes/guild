using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWCCorpADO.Models;

namespace SWCCorpADO.Data
{
    public class SWCCorpADORepository
    {
        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();

            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["SWCCorp"].ConnectionString))
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"SELECT e.EmpID, e.FirstName, e.LastName, e.HireDate
                                    FROM Employee e";

                cn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        employees.Add(MapReaderToEmployee(dr));
                    }
                }
            }

            return employees;
        }

        private Employee MapReaderToEmployee(SqlDataReader dr)
        {
            Employee employee = new Employee();

            employee.EmpId = (int) dr["EmpId"];
            employee.FirstName = dr["FirstName"].ToString();
            employee.LastName = dr["LastName"].ToString();

            if (dr["HireDate"] != DBNull.Value)
            {
                employee.HireDate = DateTime.Parse(dr["HireDate"].ToString());
            }

            return employee;
        }
    }
}
