using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresInCSharp
{

    public class ArrayStackDriver
    {

        /**
         * @param args the command line arguments
         */
        public static void main(String[] args)
        {
            Stack st = new LinkedListStack();
            String a = "a";
            String b = "b";
            String c = "c";
            String d = "d";

            Console.WriteLine("Pushing " + a);
            st.push(a);
            Console.WriteLine("Pushing " + b);
            st.push(b);
            Console.WriteLine("Pushing " + c);
            st.push(c);
            Console.WriteLine("Pushing " + d);
            st.push(d);

            Console.WriteLine("Popping...");
            Console.WriteLine((String)st.pop());
            Console.WriteLine("Popping...");
            Console.WriteLine((String)st.pop());
            Console.WriteLine("Popping...");
            Console.WriteLine((String)st.pop());
            Console.WriteLine("Popping...");
            Console.WriteLine((String)st.pop());
            Console.WriteLine("Popping...");
            Console.WriteLine((String)st.pop());

            foreach (Object o in st)
            {
                Console.WriteLine((String)o);
            }

            Console.WriteLine("Press Enter to return to the Main Menu");
            Console.ReadLine();

        }

    }
}
