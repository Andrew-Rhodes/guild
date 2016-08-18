using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expressions_and_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();

            // Comment out any of the methods that you do not want to execute
            prog.Literals();
            prog.OrderOfOperations();
            prog.Bitwise();
            prog.Assignment();
            prog.Conditional();

            Console.ReadLine();
        }

        public void Literals()
        {
            Console.WriteLine("***** Literals");

            // will print different types of literals in the C# language
            Console.WriteLine("Integer: {0}", 123); // integer value
            Console.WriteLine("Boolean: {0}", true); // boolean value
            Console.WriteLine("Double: {0}", 3.14); // double value
            Console.WriteLine("Float: {0}", 3.14F); // float value
            Console.WriteLine("Character: {0}", 'a'); // character value
            Console.WriteLine("String: {0}", "HI!"); // string value

            Console.WriteLine();
        }

        public void OrderOfOperations()
        {
            Console.WriteLine("***** Order of Operations");

            // this shows the order of operations
            // in the case of 2 + 3 * 5, 3 * 5 is performed first
            // that result is then added to 2
            Console.WriteLine("2 + 3 * 5 = {0}", 2 + 3 * 5);
            Console.WriteLine();

            // using the increment and decrement operators. 
            // this example also shows the order of operations
            int i = 0;
            Console.WriteLine("i = {0}", i);
            Console.WriteLine("i++ = {0}", i++);
            Console.WriteLine("i = {0}", i);
            Console.WriteLine("i++ = {0}", i++);
            Console.WriteLine("i = {0}", i);
            Console.WriteLine("--i = {0}", --i);
            Console.WriteLine("i = {0}", i);

            Console.WriteLine();
        }

        public void Bitwise()
        {
            Console.WriteLine("***** Bitwise");

            // demonstrate a bitwise AND operator
            // additional code used to display the bit string of a number
            int x = 3, y = 123;
            Console.WriteLine("3 & 123 = {0}", x & y);
            Console.WriteLine();
            Console.WriteLine("x (bits) = {0}", Convert.ToString(x, 2).PadLeft(8, '0'));
            Console.WriteLine("y (bits) = {0}", Convert.ToString(y, 2).PadLeft(8, '0'));
            Console.WriteLine("x & y (bits) = {0}", Convert.ToString(x & y, 2).PadLeft(8, '0'));

            Console.WriteLine();
        }

        public void Assignment()
        {
            Console.WriteLine("***** Assignment");

            // examples of using the assignment operator with another operation.
            int x = 3;
            Console.WriteLine("x = {0}", x);
            Console.WriteLine("x *= 2 -> x = {0}", x *= 2);
            Console.WriteLine("x += 2 + 3 -> x = {0}", x += 2 + 3);
            Console.WriteLine("x %= 3 -> x = {0}", x %= 3);

            Console.WriteLine();
        }

        public void Conditional()
        {
            Console.WriteLine("***** Conditional");

            // instead of an if statement, a new way to do a conditional assignment
            int x = 3, y = 2;
            string Message = ((x < y) && (x > 0)) ? "X is smaller" : "X is bigger";

            Console.WriteLine("x = 3, y = 2 -> {0}", Message);

            Console.WriteLine();
        }
    }
}
