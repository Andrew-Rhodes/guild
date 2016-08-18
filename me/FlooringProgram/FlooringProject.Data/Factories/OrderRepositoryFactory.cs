using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlooringProject.Data.Interfaces;

namespace FlooringProject.Data
{
    public class OrderRepositoryFactory
    {
        public static IOrderRepository CreateOrderRepository()
        {
            string mode = ConfigurationManager.AppSettings["Mode"].ToString();

            IOrderRepository repo;
            switch (mode.ToUpper())
            {
                case "TEST":
                    repo = new InMemoryOrderRepository();
                    break;

                case "PROD":
                    repo = new FileRepository();
                    break;
                default:
                    throw new Exception("No such repository, check your settings");
            }
            return repo;
        }
    }
}
