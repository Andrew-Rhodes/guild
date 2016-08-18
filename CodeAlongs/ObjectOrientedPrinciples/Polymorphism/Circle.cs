using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Circle : Shape
    {
        // property only available to the Circle
        public decimal Radius { get; set; }

        // override the Draw method on Shape
        public override string Draw()
        {
            return "Drawing a Circle";
        }
    }
}
