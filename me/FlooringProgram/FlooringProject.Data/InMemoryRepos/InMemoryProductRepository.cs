using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using FlooringProject.Data.Interfaces;
using FlooringProject.Models;

namespace FlooringProject.Data
{
    public class InMemoryProductRepository : IProducts
    {
        public List<Product> ProductList = new List<Product>();


        public InMemoryProductRepository()
        {
            ProductList.Add(new Product()
            {
                ProductType = "Carpet",
                LaborCostPerSqFoot = 2.10m,
                MaterialCostPerSqFoot = 2.25m
            });

            ProductList.Add(new Product()
            {
                ProductType = "Laminate",
                LaborCostPerSqFoot = 2.10m,
                MaterialCostPerSqFoot = 1.75m
            });

            ProductList.Add(new Product()
            {
                ProductType = "Tile",
                LaborCostPerSqFoot = 4.15m,
                MaterialCostPerSqFoot = 3.50m
            });

            ProductList.Add(new Product()
            {
                ProductType = "Wood",
                LaborCostPerSqFoot = 4.75m,
                MaterialCostPerSqFoot = 5.15m
            });
        }

        public Product GetProduct(string name)
        {
            var product = new Product();

            var result = from i in ProductList
                where i.ProductType == name
                select i;

            foreach (var product1 in result)
            {
                product.ProductType = product1.ProductType;
                product.LaborCostPerSqFoot = product1.LaborCostPerSqFoot;
                product.MaterialCostPerSqFoot = product1.MaterialCostPerSqFoot;
            }


            return product;
        }

    //    public List<Product> GetAll()
    //    {
    //        throw new NotImplementedException();
    //    }
    }
}

