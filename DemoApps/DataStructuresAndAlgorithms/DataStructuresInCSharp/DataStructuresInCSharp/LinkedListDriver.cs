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
    public class LinkedListDriver
    {
        public static void main(String[] args) {
        LinkedList ll = new LinkedList();
        Console.WriteLine(ll.size());
        String one = "one";
        String two = "two";
        String three = "three";
        String four = "four";
        String five = "five";

        ll.prepend(one);

        Console.WriteLine(ll.size());
        Console.WriteLine(ll.get(0));

        ll.remove(0);

        Console.WriteLine(ll.size());

        ll.prepend(one);
        ll.prepend(two);
        ll.append(three);

        Console.WriteLine(ll.size());
        OutputLinkedList(ll);

        ll.remove(1);
        OutputLinkedList(ll);

        ll.append(four);
        ll.append(five);
        OutputLinkedList(ll);

        ll.remove(3);
        OutputLinkedList(ll);

        ll.remove(2);
        OutputLinkedList(ll);

        ll.insert(0, five);
        OutputLinkedList(ll);

        ll.insert(2, four);
        OutputLinkedList(ll);

        IEnumerator iter = ll.GetEnumerator();
        while(iter.MoveNext()) {
            Console.WriteLine(iter.ToString());
        }
        Console.WriteLine("Press Enter to return to the Main Menu");

        Console.ReadLine();
    }

        private static void OutputLinkedList(LinkedList ll)
        {
            Console.WriteLine("++++++++++++++++++++++++++++");
            foreach (Object o in ll)
            {
                Console.WriteLine(o);
            }
        }

    }

}