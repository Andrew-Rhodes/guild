using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups
{
    public class Cond
    {
        public bool AreWeInTrouble(bool aSmile, bool bSmile)
        {
            return aSmile == bSmile ? true : false;
        }

        public bool CanSleepIn(bool isWeekday, bool isVacation)
        {
            if ((isWeekday == false) || (isVacation == true))
            {
                return true;
            }
            return false;
        }

        public int SumDouble(int a, int b)
        {
            if (a == b)
                return (a + b) *2;
            else
            {
                return a + b;
            }
        }

        public int Diff21(int n)
        {
            int testNum = n - 21;

            if (testNum > 0)
            {
                return testNum*2;
            }

            return Math.Abs(n - 21);


        }

        public bool ParrotTrouble(bool isTalking, int hour)
        {
            if ((isTalking == true) && (hour < 7 || hour > 20))
            {
                return true;
            }

            return false;
        }

        public bool Makes10(int a, int b)
        {
            return ((a + b == 10) || (a == 10) || (b == 10));


        }

        public bool NearHundred(int n)
        {
            if ((n <= 110) && (n >= 90))
            {
                return true;
            } 
            else if ((n <= 210) && (n >= 190))
            {
                return true;
            }
                return false;
        }
    }
}
