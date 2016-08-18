using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using FlooringProject.Models;

namespace FlooringProject.Data.Interfaces
{
    public interface IProducts
    {
        Product GetProduct(string name);
       // List<Product> GetAll();
    }
}
