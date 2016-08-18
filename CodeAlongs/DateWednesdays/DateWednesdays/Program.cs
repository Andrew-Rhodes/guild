using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateWednesdays
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();

            // prompt for the date
            string dateString = prog.DisplayPrompt("Please enter the date you wish to start with: ");
            DateTime startDate = DateTime.Parse(dateString);

            // prompt for the number of Wednesdays
            string numWedString = prog.DisplayPrompt("How many Wednesdays do you want? ");
            int numWed = int.Parse(numWedString);

            // loop until we are sure we have the first wendesday to print
            startDate = prog.GetNextWednesday(startDate);

            // loop for numWednesday and print
            for (int i = 0; i < numWed; i++)
            {
                Console.WriteLine(startDate.ToShortDateString());
                Console.WriteLine(startDate.ToLongDateString());
                Console.WriteLine();

                startDate = startDate.AddDays(7);
            }

            Console.ReadLine();
        }

        public string DisplayPrompt(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        public DateTime GetNextWednesday(DateTime date)
        {
            while (date.DayOfWeek != DayOfWeek.Wednesday)
            {
                date = date.AddDays(1);
            }

            return date;
        }
    }
}
