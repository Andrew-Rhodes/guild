using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var temperatures = new Temperature[]
            {
                new Temperature() {Fahrenheit = 71},
                new Temperature() {Fahrenheit = 120},
                new Temperature() {Fahrenheit = 75},
                new Temperature() {Fahrenheit = 60}
            };

            Array.Sort(temperatures);

            foreach (var temp in temperatures)
            {
                Console.WriteLine($"{temp.Fahrenheit} {temp.Celsius}");
            }

            Console.ReadLine();
        }
    }
}
