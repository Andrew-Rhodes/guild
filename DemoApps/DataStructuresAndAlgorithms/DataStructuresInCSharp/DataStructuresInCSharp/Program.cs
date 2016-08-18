using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string selection = "";
            while (selection != "Q")
            {
                Console.WriteLine("Data Structures Fun!");
                Console.WriteLine("++++++++++++++++++++++");
                Console.WriteLine("1. Generic Array Stack Driver");
                Console.WriteLine("2. Linked List Driver");
                Console.WriteLine("3. Array Queue Driver");
                Console.WriteLine("4. Array Stack Driver");
                Console.WriteLine("Enter your selection or Q to Quit: ");
                selection = Console.ReadLine();

                switch (selection[0])
                {
                    case '1':
                        GenArrayStackDriver.main(args);
                        break;
                    case '2':
                        LinkedListDriver.main(args);
                        break;
                    case '3':
                        ArrayQueueDriver.main(args);
                        break;
                    case '4':
                        ArrayStackDriver.main(args);
                        break;
                    case 'Q':
                    case 'q':
                        return;
                        break;
                    default:
                        Console.WriteLine("That was an invalid selection. Press Enter to Return to the Main Menu");
                        Console.ReadLine();
                        break;
                }
                Console.Clear();

            }

        }
    }
}
