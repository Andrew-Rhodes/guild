using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSVPResponses.Models;

namespace RSVPResponses.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            DaysOfTheWeek value = DaysOfTheWeek.Friday | DaysOfTheWeek.Monday;

            Console.WriteLine(value);

            Console.ReadLine();
        }
    }
}
