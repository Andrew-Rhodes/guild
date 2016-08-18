using System;

namespace ValueVsReferenceTypes
{
    class Program
    {
        static void Main()
        {
            DemonstrateValueType();
            DemonstrateReferenceType();

            Console.ReadLine();
        }

        #region "Value Types"
        static void DemonstrateValueType()
        {
            int x = 5;
            Console.WriteLine("The value of x is: {0}", x);

            ManipulateInt(x);

            Console.WriteLine("The value of x after the method: {0}", x);
            Console.WriteLine("");
        }

        /// <summary>
        /// Because this is a value type, a copy of the data is created in its own memory location
        /// changes in this method do not effect the data item in the caller
        /// </summary>
        static void ManipulateInt(int x)
        {
            x = 10;
            Console.WriteLine("The value of x in the method: {0}", x);
        }
        #endregion

        #region "ReferenceTypes"
        static void DemonstrateReferenceType()
        {
            Person myPerson = new Person(); // must use the new keyword to instantiate our type
            myPerson.Name = "Billy Joe-Bob-Roy";
            Console.WriteLine("The person's name starts as: {0}", myPerson.Name);

            ManipulatePerson(myPerson);
            Console.WriteLine("The person's name now is: {0}", myPerson.Name);
        }

        /// <summary>
        /// Because this is a reference type, only the pointer to the memory location is passed
        /// Thus any manipulation of the data effects the caller, because they point to the same memory location
        /// 
        /// Think of it this way: If you had very large classes and .NET always made a copy of the whole object anytime you passed it around, 
        /// you would run out of memory pretty quickly.  Passing memory pointers around is very efficient.
        /// </summary>
        static void ManipulatePerson(Person myPerson)
        {
            myPerson.Name = "Jane Doe";
        }
        #endregion
    }
}
