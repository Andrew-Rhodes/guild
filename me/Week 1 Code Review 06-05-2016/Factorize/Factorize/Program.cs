using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Factorize
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number to factor? ");
            string numberToFactor = Console.ReadLine();

            int factoring = int.Parse(numberToFactor);

            Console.WriteLine("The number to factor is " + numberToFactor + "\n");

            int totalNum = 0;
            int addFactorNumbers = 0;

            for (int i = 1; i <= factoring - 1; i++)
            {
                if (factoring % i == 0)
                {
                    Console.WriteLine(i + " is a factor");
                    totalNum++;
                    addFactorNumbers += i;
                }
            }

            Console.WriteLine("the total number of factors is " + totalNum + "\n");
            Console.WriteLine("The sum of all the factors numbers is " + addFactorNumbers + "\n");

            if (addFactorNumbers == factoring)
            {
                Console.WriteLine("Since " + factoring +
                                  " is equal to the sum of its factors that makes it a perfect number!" + "\n");
            }

            Console.WriteLine(totalNum == 1 ? factoring + " is a prime number" : factoring + " is not a prime number");

            Console.ReadLine();
            
        }
    }
}
