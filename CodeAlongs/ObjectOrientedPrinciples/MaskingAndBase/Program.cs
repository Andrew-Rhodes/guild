using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MaskingAndBase
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a derived class and call print
            DerivedClass d = new DerivedClass();
            d.PrintField1();

            Console.WriteLine();

            // print the message from the derived class
            Console.WriteLine(d.Field1);

            // print the message from the base class
            Console.WriteLine(((BaseClass)d).Field1);

            Console.ReadLine();
        }
    }
}
