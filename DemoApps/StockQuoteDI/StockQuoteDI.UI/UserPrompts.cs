using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockQuoteDI.UI
{
    public class UserPrompts
    {
        public static string PromptForType()
        {
            Console.WriteLine("Select Provider - (G)oogle, (Y)ahoo, (T)est or (Q)uit");
            Console.Write("provider: ");
            return Console.ReadLine();
        }

        public static string PromptForSymbols()
        {
            Console.WriteLine("Enter company symbols separated by a space");
            Console.Write("symbols: ");
            return Console.ReadLine();
        }
    }
}
