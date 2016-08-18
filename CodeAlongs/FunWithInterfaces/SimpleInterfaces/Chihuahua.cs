using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaces
{
    public class Chihuahua : IDog
    {
        public string Name { get; private set; }

        public Chihuahua(string name)
        {
            Name = name;
        }

        public void Bark()
        {
            Console.WriteLine("yip!");
        }

        public string GoForAWalk()
        {
            return "going for a short walk";
        }
    }
}
