using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStrings.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicStringFunctionality();
            StringConcat();
            EscapeChars();
            VerbatimStrings();
            StringsAreImmutable();
            StringBuilderExample();
            StringEquality();
            Console.ReadLine();
        }

        static void BasicStringFunctionality()
        {
            Console.WriteLine("=> Basic String Functionality");

            string firstName = "Victor";
            Console.WriteLine("Value of firstname is {0}", firstName);
            Console.WriteLine("My first name is {0} characters", firstName.Length);
            Console.WriteLine("Hey look, uppercase: {0}", firstName.ToUpper());
            Console.WriteLine("Hey look, lowercase: {0}", firstName.ToLower());
            Console.WriteLine("Value of firstname is {0}", firstName);

            Console.WriteLine("Does first name contain a v? {0}", firstName.ToLower().Contains("v"));

            //DAY 2 Add-ON
            Console.WriteLine("replaced part of the string; {0}", firstName.Replace("ctor", "ncent"));
        }

        static void StringConcat()
        {
            Console.WriteLine("=> String Concat");

            string s1 = "Hello ";
            string s2 = "World!";
            string s3 = string.Concat(s1, s2);

            Console.WriteLine(s3);
        }

        static void EscapeChars()
        {
            Console.WriteLine("=> Escape Chars");

            Console.WriteLine("Model\tColor\tSpeed");
            Console.WriteLine("JOhn\nJeannine");
        }

        static void VerbatimStrings()
        {
            Console.WriteLine("=> Verbatim Strings");

            Console.WriteLine(@"C:\_repos\");

            string longString = @"This is a very
                    very
                                very
            long string";
            Console.WriteLine(longString);
            Console.WriteLine(longString.Length);
        }

        static void StringsAreImmutable()
        {
            Console.WriteLine("=> Strings are immutable");

            string firstname = "Victor";

            string uppercase = firstname.ToUpper();

            firstname = firstname.ToLower();

            Console.WriteLine("{0} in upper case is {1}", firstname, uppercase);
        }

        static void StringBuilderExample()
        {
            Console.WriteLine("=> String Builder Example");

            StringBuilder sb = new StringBuilder("***** Fantastic Games *****");
            sb.Append("\n");
            sb.AppendLine("Magic The Gathering");
            sb.AppendLine("Munchkin");
            sb.AppendLine("Settlers");

            Console.WriteLine(sb.ToString());

            sb.Replace("Settlers", "Pandemic");

            Console.WriteLine(sb.ToString());
            Console.WriteLine(sb.Length);
        }

        static void StringEquality()
        {
            Console.WriteLine("=> String Equality");

            string s1 = "Hello!";
            string s2 = "Yo!";

            Console.WriteLine("s1 = {0}", s1);
            Console.WriteLine("s2 = {0}", s2);
            Console.WriteLine();

            Console.WriteLine("s1 == s2: {0}", s1 == s2);
            Console.WriteLine("s1 == Hello!: {0}", s1 == "Hello!");
            Console.WriteLine("s1 == HELLO!: {0}", s1 == "HELLO!");
            Console.WriteLine("s1 == HELLO!: {0}", s1.Equals("HELLO!"));
            Console.WriteLine("Yo! == s2: {0}", "Yo!".Equals(s2));

        }
    }
}
