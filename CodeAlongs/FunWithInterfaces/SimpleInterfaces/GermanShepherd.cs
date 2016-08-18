using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaces
{
    public class GermanShepherd : IDog
    {
        public string Name { get; set; }

        public void Bark()
        {
            Console.WriteLine("WOOF!");
        }

        public string GoForAWalk()
        {
            return "going for a long walk";
        }
    }
}
