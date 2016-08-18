using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithCollections.Collections
{
    public class NonGenerics
    {
        public static void ShowArrayList()
        {
            Console.WriteLine("<= Show ArrayList");

            ArrayList arrayList = new ArrayList();

            arrayList.Add("Hello");
            arrayList.Add(17);

            Person p = new Person();
            p.FirstName = "Victor";
            p.LastName = "Pudelski";

            arrayList.Add(p);

            foreach (object o in arrayList)
            {
                Console.WriteLine(o);
            }
        }

        public static void ShowHashTable()
        {
            Console.WriteLine("<= Show HashTable");

            Hashtable map = new Hashtable();

            map.Add(1, "hello");
            map.Add("world", 2);
            map.Add(true, 123.456);

            Person bart = new Person();
            bart.FirstName = "Bart";
            bart.LastName = "Simpson";

            map.Add(bart.LastName, bart);

            foreach (var key in map.Keys)
            {
                Console.WriteLine($"{key} = {map[key]}");
            }
        }

        public static void ShowStack()
        {
            Console.WriteLine("<= Show Stack");

            Stack myStack = new Stack();

            myStack.Push("hello");
            myStack.Push(123);

            Person kyrie = new Person();
            kyrie.FirstName = "Kyrie";
            kyrie.LastName = "Irving";

            myStack.Push(kyrie);

            int count = myStack.Count;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(myStack.Pop());
            }
        }

        public static void ShowQueue()
        {
            Console.WriteLine("<= Show Queue");

            Queue myQueue = new Queue();

            myQueue.Enqueue("hello");
            myQueue.Enqueue(123);

            Person kyrie = new Person();
            kyrie.FirstName = "Kyrie";
            kyrie.LastName = "Irving";

            myQueue.Enqueue(kyrie);

            int count = myQueue.Count;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(myQueue.Dequeue());
            }
        }
    }
}
