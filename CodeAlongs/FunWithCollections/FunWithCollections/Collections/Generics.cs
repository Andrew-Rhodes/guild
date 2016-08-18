using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithCollections.Collections
{
    public class Generics
    {
        public void ShowStack()
        {
            Console.WriteLine("<= Generic Show Stack");

            Stack<Person> people = new Stack<Person>();

            people.Push(new Person() { FirstName = "Homer", LastName = "Simpson" });
            people.Push(new Person() { FirstName = "Bart", LastName = "Simpson" });
            people.Push(new Person() { FirstName = "Lisa", LastName = "Simpson" });

            int count = people.Count;
            Person simpson;
            for (int i = 0; i < count; i++)
            {
                simpson = people.Pop();

                Console.WriteLine($"{simpson.FirstName} {simpson.LastName}");
            }
        }

        public void ShowQueue()
        {
            Console.WriteLine("<= Generic Show Queue");

            Queue<Person> people = new Queue<Person>();

            people.Enqueue(new Person() { FirstName = "Homer", LastName = "Simpson" });
            people.Enqueue(new Person() { FirstName = "Bart", LastName = "Simpson" });
            people.Enqueue(new Person() { FirstName = "Lisa", LastName = "Simpson" });

            int count = people.Count;
            Person simpson;
            for (int i = 0; i < count; i++)
            {
                simpson = people.Dequeue();

                Console.WriteLine($"{simpson.FirstName} {simpson.LastName}");
            }
        }

        public void SimpleList()
        {
            Console.WriteLine("<= Simple List");

            List<int> numbers = new List<int>();

            // 1
            numbers.Add(1);
            // 1, 5, 4, 3, 2
            numbers.AddRange(new int[] {5,4,3,2});
            // 1, 5, 100, 4, 3, 2
            numbers.Insert(2, 100);

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            // 1, 5, 100, 3, 2
            numbers.Remove(4);
            // 100, 3, 2
            numbers.RemoveRange(0, 2);
            // 3, 2
            numbers.RemoveAt(0);

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

        }

        public void PersonDictionary()
        {
            Console.WriteLine("<= Person Dictionary");

            Dictionary<string, Person> people = new Dictionary<string, Person>();

            Person kyrie = new Person() { FirstName = "kyrie", LastName = "irving" };
            Person bart = new Person() { FirstName = "bart", LastName = "simpson" };
            Person jason = new Person() { FirstName = "jason", LastName = "Kipnis" };

            people.Add(kyrie.LastName, kyrie);
            people.Add(bart.LastName, bart);
            people.Add(jason.LastName, jason);

            foreach (var person in people)
            {
                Console.WriteLine($"{person.Value.FirstName} {person.Key}");
            }

            Console.WriteLine($"{people["Kipnis"].FirstName}");
        }
    }
}
