using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockQuoteDI.BLL;
using StockQuoteDI.Models;

namespace StockQuoteDI.UI.Workflows
{
     public class StockQuoteWorkflow
    {
        public void Execute()
        {
            //prompt for repo type
            string type = UserPrompts.PromptForType();

            //access the BLL
            StockQuoteOperations ops = new StockQuoteOperations(type);

            //prompt for which companies do we want stock quotes?
            string symbols = UserPrompts.PromptForSymbols();

            //retrieve quotes
            List<StockQuote> quotes = ops.RetrieveQuotes(symbols);

            //display the quotes
            DisplayQuotes(quotes);
        }

        private void DisplayQuotes(List<StockQuote> Quotes)
        {
            Console.Clear();
            Console.WriteLine("Stock Data");
            Console.WriteLine("----------------------------------------");
            foreach (var stock in Quotes)
            {
                Console.WriteLine("{0} {1} - {2}", stock.Symbol, stock.CompanyName, stock.StockPrice);
            }
        }
    }
}
