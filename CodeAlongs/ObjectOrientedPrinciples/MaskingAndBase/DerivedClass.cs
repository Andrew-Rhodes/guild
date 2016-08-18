using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskingAndBase
{
    public class DerivedClass : BaseClass
    {
        // masking the base field
        public new string Field1 = "Derived class Field1";

        public void PrintField1()
        {
            // write the derived field
            Console.WriteLine(Field1);

            // write the base field
            Console.WriteLine(base.Field1);
        }
    }
}
