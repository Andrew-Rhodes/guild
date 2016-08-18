using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using NorthwindDapper.Models;

namespace NorthwindDapper.Data
{
    public class NorthwindRepository
    {
        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();

            using (var cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString))
            {
                // ADO.NET
                //using (var cmd = cn.CreateCommand())    // doing the command off the connection sets the property for us
                //{
                //    cmd.CommandText = @"SELECT emp.EmployeeID, emp.LastName, emp.FirstName, 
	               //                         emp.Title, emp.BirthDate, emp.ReportsTo, 
	               //                         mgr.LastName as ManagerName 
                //                        FROM Employees emp
	               //                         LEFT JOIN Employees mgr
		              //                          ON emp.ReportsTo = mgr.EmployeeID";

                //    cn.Open();

                //    using (var dr = cmd.ExecuteReader())
                //    {
                //        while (dr.Read())
                //        {
                //            employees.Add(PopulateEmployeeFromReader(dr));
                //        }
                //    }
                //}

                // DAPPER
                employees = cn.Query<Employee>(@"SELECT emp.EmployeeID, emp.LastName, emp.FirstName, 
	                                        emp.Title, emp.BirthDate, emp.ReportsTo, 
	                                        mgr.LastName as ManagerName 
                                       FROM Employees emp
	                                        LEFT JOIN Employees mgr
		                                        ON emp.ReportsTo = mgr.EmployeeID").ToList();
            }

            return employees;
        }

        private Employee PopulateEmployeeFromReader(SqlDataReader dr)
        {
            Employee employee = new Employee();

            employee.EmployeeId = (int) dr["EmployeeID"];
            employee.LastName = dr["LastName"].ToString();
            employee.FirstName = dr["FirstName"].ToString();
            employee.Title = dr["Title"].ToString();
            employee.BirthDate = DateTime.Parse(dr["BirthDate"].ToString());

            if (dr["ReportsTo"] != DBNull.Value)
            {
                employee.ReportsTo = (int) dr["ReportsTo"];
                employee.ManagerName = dr["ManagerName"].ToString();
            }

            return employee;
        }

        public int InsertRegion(string description)
        {
            int regionId = 0;

            using (var cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("RegionDescription", description);

                parameters.Add("RegionId", DbType.Int32, direction: ParameterDirection.Output);

                cn.Execute("RegionInsert", parameters, commandType: CommandType.StoredProcedure);

                regionId = parameters.Get<int>("RegionId");
            }

            return regionId;
        }

        public List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();


            using (SqlConnection cn = new SqlConnection(
                ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString))
            {
                // DAPPER
                // we call the Dapper Query method and provide the object
                // and voila, it's mapped. 
                string sql = @"SELECT c.CustomerID, c.CompanyName, o.OrderID, o.OrderDate
                                                FROM Customers c
                                                    INNER JOIN Orders o
                                                        ON c.CustomerID = o.CustomerID";



                var lookup = new Dictionary<string, Customer>();
                cn.Query<Customer, Order, Customer>(sql, (c, o) =>
                {
                    Customer customer;
                    if (!lookup.TryGetValue(c.CustomerId, out customer))
                    {
                        lookup.Add(c.CustomerId, customer = c);
                    }
                    if (customer.Orders == null)
                        customer.Orders = new List<Order>();
                    customer.Orders.Add(o); /* Add orders to customers */
                    return customer;
                }, splitOn: "OrderId").AsQueryable();
                customers = lookup.Values.ToList();
            }

            return customers;
        }

    }
}
