using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresInCSharp
{

    /**
     *
     * @author apprentice
     */
    public class GenArrayStackDriver
    {

        public static void main(String[] args)
        {
            //        GenStack<String> st = new GenArrayStack<>();
            GenStack<String> st = new GenLinkedListStack<string>();
            st.push("Joe");
            st.push("Steve");
            st.push("Sally");

            Console.WriteLine(st.pop());
            Console.WriteLine(st.pop());
            Console.WriteLine(st.pop());

            Console.WriteLine("Press Enter to return to the Main Menu");

            Console.ReadLine();
        }

    }
}
