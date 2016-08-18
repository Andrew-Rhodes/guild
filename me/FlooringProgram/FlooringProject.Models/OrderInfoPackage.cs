using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace FlooringProject.Models
{
    public class OrderInfoPackage
    {
        public List<Order> OrderInformation { get; set; }
        public bool IsValid { get; set; }
        public Product Product { get; set; }
    }
}
