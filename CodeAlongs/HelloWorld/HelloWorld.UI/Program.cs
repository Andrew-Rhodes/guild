using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            // write hello world to the screen
            Console.WriteLine("Hello World!");

            // demonstrate fully qualified names
            System.Console.WriteLine("HI!");

            // get the user's name
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            // make the application wait for me to hit enter to finish
            Console.ReadLine();
        }
    }
}
