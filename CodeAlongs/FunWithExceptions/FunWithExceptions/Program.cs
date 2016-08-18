using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //CauseException();
            //HandleException();
            //HandleSpecificException();
            //FinallyExample();
            //CallStackExample();
            ThrowCustomException();

            Console.ReadLine();
        }

        static void CauseException()
        {
            int x = 17;
            int y = 0;

            Console.WriteLine(x/y);
        }

        static void HandleException()
        {
            try
            {
                CauseException();
            }
            catch
            {
                Console.WriteLine("You did something bad, but I am going to keep running!");
            }

            Console.WriteLine("I'm still here!!!");
        }

        static void HandleSpecificException()
        {
            try
            {
                int[] ints = new int[] {5, 4};
                ints[2] = 20;

                ints[1] = 21;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Your index is out of range...");
            }
            catch
            {
                Console.WriteLine("AN EXCEPTION OCCURRED!");
            }
        }

        static void FinallyExample()
        {
            try
            {
                int x = 3;
                int y = 7;

                Console.WriteLine(x/y);
            }
            catch (DivideByZeroException dex)
            {
                Console.WriteLine("You CANNOT divide by 0");
            }
            finally
            {
                Console.WriteLine("Finally, I get to execute!");
            }
        }

        static void CallStackExample()
        {
            try
            {
                Method1();
            }
            catch (DivideByZeroException dex)
            {
                Console.WriteLine("Catch clause in CallStackExample for DivideByZero");
            }
            finally
            {
                Console.WriteLine("Finally clause in CallStackExample");
            }

            Console.WriteLine("Still Running!");
        }

        static void Method1()
        {
            try
            {
                Method2();
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Catch clause in Method1 for NullReferenceException");
            }
            finally
            {
                Console.WriteLine("Finally clause in Method1");
            }
            Console.WriteLine("Method1!");
        }

        static void Method2()
        {
            try
            {
                CauseException();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Catch clause in Method2 for IndexOutOfRangeException");
            }
            finally
            {
                Console.WriteLine("Finally clause in Method2");
            }
            Console.WriteLine("Method2!");
        }

        static void ThrowCustomException()
        {
            try
            {
                throw new MySpecificException("NOT A CHANCE!");
            }
            catch (MySpecificException mex)
            {
                Console.WriteLine(mex.Message);
                Console.WriteLine(mex.StackTrace);
                Console.WriteLine(mex.HelpLink);
            }
        }
    }
}
