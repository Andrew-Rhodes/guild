using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups
{
    public class Loops
    {
        public string StringTimes(string str, int n)
        {
            string str1 = str;
            for (int i = 1; i < n; i++)
            {
                str1 += str;
            }
            return str1;
        }

        public string FrontTimes(string str, int n)
        {
            string front = str.Substring(0, 3);
            string newString = "";

            for (int i = 1; i <= n; i++)
            {
                newString += front;
            }
            return newString;
        }

        public int CountXX(string str)
        {
            int xxCount = 0;

            for (int i = 0; i < str.Length - 1; i++)
            {
                if ((str[i] == 'x') && (str[i + 1] == 'x'))
                {
                    xxCount++;
                }
            }
            return xxCount;
        }

        public bool DoubleX(string str)
        {
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == 'x')
                {
                    if (str[i + 1] == 'x')
                        return true;
                    break;
                }
            }
            return false;
        }

        public string EveryOther(string str)
        {
            string s1 = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (i%2 == 0)
                {
                    s1 += str[i];
                }
            }
            return s1;
        }

        public string StringSplosion(string str)
        {
            int through = 0;
            string s1 = "";
            for (int i = 0; i <= str.Length; i++)
            {
                string toAdd = str.Substring(0, through);

                s1 += toAdd;
                through++;
            }
            return s1;
        }

        public int CountLast2(string str)
        {
            string last2 = str.Substring(str.Length - 2);
            int count = 0;

            for (int i = 0; i < str.Length - 2; i++)
            {
                if (str.Substring(i, 2) == last2)
                {
                    count++;
                }
            }
            return count;
        }

        public int Count9(int[] numbers)
        {
            int nineCount = 0;

            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                if (numbers[i] == 9)
                {
                    nineCount++;
                }

            }
            return nineCount;
        }
    }
}
