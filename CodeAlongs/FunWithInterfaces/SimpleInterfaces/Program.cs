using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            GermanShepherd bigDog = new GermanShepherd();
            Console.WriteLine(bigDog.GoForAWalk());
            bigDog.Bark();

            bigDog.Name = "Gambit";
            Console.WriteLine(bigDog.Name);

            Console.WriteLine();

            Chihuahua smallDog = new Chihuahua("Taco Bell");
            Console.WriteLine(smallDog.GoForAWalk());
            smallDog.Bark();

            //smallDog.Name = "Gambit"; cannot set publically, the set is private
            Console.WriteLine(smallDog.Name);

            List<IDog> dogs = new List<IDog>();
            dogs.Add(bigDog);
            dogs.Add(smallDog);

            Console.ReadLine();
        }
    }
}
