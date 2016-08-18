using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlooringProject.Data.Factories;
using FlooringProject.Data.Interfaces;
using FlooringProject.Models;

namespace FlooringProgram.BLL
{
    public class ProductOperations
    {
        public Product GetProductByName(string name)
        {
            IProducts repo = ProductRepositoryFactory.CreateProductRepository();

            return repo.GetProduct(name);
        }
    }
}
