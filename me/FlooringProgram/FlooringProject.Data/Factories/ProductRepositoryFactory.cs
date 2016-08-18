using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlooringProject.Data.FileRepos;
using FlooringProject.Data.Interfaces;

namespace FlooringProject.Data.Factories
{
    public class ProductRepositoryFactory
    {
        public static IProducts CreateProductRepository()
        {
            string mode = ConfigurationManager.AppSettings["Mode"].ToString();

            IProducts repo;
            switch (mode.ToUpper())
            {
                case "TEST":
                    repo = new InMemoryProductRepository();
                    break;

                case "PROD":
                    repo = new FileProductRepository();
                    break;
                default:
                    throw new Exception("No such repository, check your settings");
            }
            return repo;
        }
    }
}
