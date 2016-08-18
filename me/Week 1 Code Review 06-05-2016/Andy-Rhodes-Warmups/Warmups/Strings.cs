using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups
{
    public class Strings
    {
        public string SayHi(string name)
        {
            return $"Hello {name}!";
        }

        public string Abba(string a, string b)
        {
            return (a + b + b + a);
        }

        public string LongInMiddle(string a, string b)
        {
            return (a.Length < b.Length) ? (a + b + a) : (b + a + b);
        }
    }
}



   
