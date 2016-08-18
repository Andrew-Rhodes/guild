using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlooringProject.Data.Interfaces;
using FlooringProject.Models;

namespace FlooringProject.Data.FileRepos
{
    class FileProductRepository : IProducts
    {
        private const string FILENAME = @"DataFiles\Products.txt";

        public static List<Product> ProductList = new List<Product>();

        static FileProductRepository()
        {
            using (StreamReader sr = File.OpenText(FILENAME))
            {
                ProductList = new List<Product>();

                string inputLine = "";
                string[] inputParts;

                for (var i = 0; i < 1; i++)
                {
                    sr.ReadLine();
                    while ((inputLine = sr.ReadLine()) != null)
                    {
                        inputParts = inputLine.Split(',');
                        var thisProduct = new Product()
                        {
                            ProductType = inputParts[0],
                            MaterialCostPerSqFoot = decimal.Parse(inputParts[1]),
                            LaborCostPerSqFoot = decimal.Parse(inputParts[2])
                        };

                        ProductList.Add(thisProduct);
                    }
                }
            }
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
    }
}