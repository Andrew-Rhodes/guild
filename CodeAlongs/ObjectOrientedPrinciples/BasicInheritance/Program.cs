using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // default constructor on MiniVan
            MiniVan myVan = new MiniVan();
            Console.WriteLine($"max speed is {myVan.MaxSpeed}");

            // constructor on MiniVan(int, int)
            MiniVan myVan2 = new MiniVan(75, 0);
            Console.WriteLine($"max speed is {myVan2.MaxSpeed}");

            // constructor on MiniVan(int)
            MiniVan myVan3 = new MiniVan(90);
            Console.WriteLine($"max speed is {myVan3.MaxSpeed}");

            Console.ReadLine();
        }
    }
}
