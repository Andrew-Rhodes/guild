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
            //return $"{a}{b}{b}{a}";
            return string.Format("{0}{1}{1}{0}", a, b);
        }
    }
}
