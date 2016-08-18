using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups
{
    public class Array
    {
        public bool FirstLast6(int[] numbers)
        {
            foreach (var i in numbers)
            {
                if ((numbers[0] == 6) || (numbers[numbers.Length - 1] == 6))
                {
                    return true;
                }
            }
            return false;
        }

        public bool SameFirstLast(int[] numbers)
        {
            foreach (var i in numbers)
            {
                if (numbers[0] == numbers[numbers.Length - 1])
                {
                    return true;
                }
            }
            return false;
        }

        public int[] MakePi(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                
            }
        }
    }
}
