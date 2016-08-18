using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlooringProject.Models
{
    public class Product
    {
        public string ProductType { get; set; }
        public decimal MaterialCostPerSqFoot { get; set; }
        public decimal LaborCostPerSqFoot { get; set; }
    }
}
