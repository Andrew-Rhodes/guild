using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups
{
    public class Logic
    {
        public bool GreatParty(int cigars, bool isWeekend)
        {
            if (((cigars > 40) && (cigars < 60)) || ((isWeekend == true) && (cigars > 40)))
            {
                return true;
            }
            return false;
        }

        public int CanHazTable(int yourStyle, int dateStyle)
        {
            if ((yourStyle >= 8) || dateStyle >= 8)
            {
                return 2;
            }

            if ((yourStyle <= 2) || dateStyle <= 2)
            {
                return 0;
            }

            return 1;
        }

        public bool PlayOutside(int temp, bool isSummer)
        {
            if ((isSummer == true) && ((temp > 60) && (temp < 100)))
            {
                return true;
            }

            if ((isSummer == false) && ((temp > 60) && (temp < 90)))
            {
                return true;
            }

            return false;
        }

        public int CaughtSpeeding(int speed, bool isBirthday)
        {
            if (isBirthday)
                speed = speed - 5;


            if (speed <= 60)
            {
                return 0;
            }
            else if ((speed >= 61) && (speed <= 80))
            {
                return 1;
            }
            else if (speed >= 81)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }
    }
}
