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
    public class ArrayQueueDriver
    {

        public static void main(String[] args) {
        Queue q = new LinkedListQueue();
        q.enqueue("a");
        q.enqueue("b");
        q.enqueue("c");

        Console.WriteLine(q.dequeue());

        q.enqueue("d");

        Console.WriteLine(q.dequeue());

        q.enqueue("e");

        Console.WriteLine(q.dequeue());
        q.enqueue("f");

        Console.WriteLine(q.dequeue());
        q.enqueue("g");

        Console.WriteLine(q.dequeue());
        q.enqueue("h");

        Console.WriteLine(q.dequeue());
        q.enqueue("i");

        Console.WriteLine("Press Enter to return to the Main Menu");

        Console.ReadLine();

    }
    }
}