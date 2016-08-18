using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    public class MiniVan : Car
    {
        // default constructor calling the Car(int)
        public MiniVan() : base(60)
        {
            // to illustrate which is called first base or child
            MaxSpeed = 65; // base first, this second thus maxspeed will be 65
        }

        // constructor calling Car(int, int)
        public MiniVan(int max, int min) : base(max, min) { }

        // constructor not specifying a base constructor
        // hence, calls Car()
        public MiniVan(int max) { }
    }
}
