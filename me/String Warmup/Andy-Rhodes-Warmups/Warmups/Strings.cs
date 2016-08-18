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

        public string MakeTags(string tag, string content)
        {
            return "<" + tag + ">" + content + "</" + tag + ">";
        }

        public string InsertWord(string container, string word)
        {
            string start = container.Substring(0, 2);
            string end = container.Substring(2);

            return start + word + end;
        }

        public string MultipleEndings(string str)
        {
            string ending = str.Substring(str.Length - 2, 2);

            return ending + ending + ending;
        }

        public string FirstHalf(string str)
        {
            string first = str.Substring(0, str.Length/2);
            return first;
        }

        public string TrimOne(string str)
        {
            string middle = str.Substring(1, str.Length - 2);
            return middle;
        }

        public string LongInMiddle(string a, string b)
        {
            return (a.Length < b.Length) ? (a + b + a) : (b + a + b);
        }

        public string Rotateleft2(string str)
        {
            string firstWordHalf = str.Substring(0, 2);
            string restOfWord = str.Substring(2);

            return restOfWord + firstWordHalf;
        }

        public string RotateRight2(string str)
        {
            string last2 = str.Substring(str.Length - 2);
            string rest = str.Substring(0, str.Length - 2);

            return last2 + rest;
        }

        public string TakeOne(string str, bool fromFront)
        {
            if (fromFront = true)
            {
                return str.Substring(0, 1);
            }
            else
            {
                return str.Substring(str.Length - 1);
            }
        }

        public string MiddleTwo(string str)
        {
            int start = str.Length/2;

            string left = str.Substring(start - 1, 1);
            string right = str.Substring(start, 1);

            return left + right;
        }

        public bool EndsWithLy(string str)
        {

            if (str.Length < 2)
            {
                return false;
            }

            string checkEnd = str.Substring(str.Length - 2);

            if (checkEnd == "ly")
            {
                return true;
            }

            return false;
        }

        public string FrontAndBack(string str, int n)
        {
            string front = str.Substring(0, n);
            string back = str.Substring(str.Length - n);

            return $"{front}{back}";
        }

        public string TakeTwoFromPosition(string str, int n)
        {
            if (str.Length - n < 2)
            {
                return str.Substring(0, 2);
            }
            else
            {
            string s = str.Substring(n, 2);

            return s;
            }
        }

        public bool HasBad(string str)
        {
            if (str == ("") || str ==(" "))
            {
                return false;
            }

            for (int i = 0; i <= 1; i++)
            {
                string badTest = str.Substring(i, 3);

                if (badTest == "bad")
                {
                    return true;
                }
            }
            return false;
        }

        public string AtFirst(string str)
        {
            if (str.Length == 1)
            {
                 string addA = str + "@";
                 return addA;
            }

            if (str.Length == 0)
            {
                string addAs = str + "@@";
                return addAs;
            }
            
            string firstTwo = str.Substring(0, 2);

            return firstTwo;


        }

        public string LastChars(string str, string str2)
        {
                if (str.Length == 0)
                {
                    str = str + "@@";
                }

                if (str2.Length == 0)
                {
                    str2 = str2 + "@@";
                }



            string s1 = str.Substring(0, 1);

            string s2 = str2.Substring(str2.Length - 1, 1);

            return s1 + s2;
        }

        public string ConCat(string a, string b)
        {
            if (b == "")
            {
                b = "";
            }
            else if (a.Substring(a.Length - 1) == b.Substring(0, 1))
            {
                b = b.Substring(1);
            }
            return $"{a}{b}";
        }
    }
}



   
