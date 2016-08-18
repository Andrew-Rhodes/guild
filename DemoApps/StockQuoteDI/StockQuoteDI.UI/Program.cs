using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockQuoteDI.UI.Workflows;

namespace StockQuoteDI.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            // creates UI Workflow class and executes
            StockQuoteWorkflow wf = new StockQuoteWorkflow();
            wf.Execute();

            Console.ReadLine();
        }
    }
}
