using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsDemo
{
    enum Bits
    {
        first = 1,
        second = 2,
        third = 4,
        fourth = 8,
        fifth = 16,
        sixth = 32,
        seventh = 17
    };

    class Program55
    {
        static void Main(string[] args)
        {
            // cast each of the Bits enums on the right to their integer value
            // add those integers together
            // cast the resulting integer back to a Bits enum
            Bits myvar = (Bits)((int)Bits.first + (int)Bits.fifth);

            Console.WriteLine(myvar);
            Console.ReadLine();
        }
    }
}
