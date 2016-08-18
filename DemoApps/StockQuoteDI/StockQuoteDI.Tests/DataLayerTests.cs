using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using StockQuoteDI.Data.StockRepositories;
using StockQuoteDI.Models;

namespace StockQuoteDI.Tests
{
    [TestFixture]
    public class DataLayerTests
    {
        [TestCase("G", "GOOG MSFT SHW", 3)]
        [TestCase("Y", "AAPL ORCL", 2)]
        public void TestRepository(string Type, string Symbols, int Count)
        {
            IStockRepository repo = StockRepositoryFactory.CreateStockRepository(Type);
            List<StockQuote> quotes = repo.GetStockInformation(Symbols);

            Assert.AreEqual(Count, quotes.Count);

            foreach (var quote in quotes)
            {
                Console.WriteLine("{0} {1} - {2}", quote.Symbol, quote.CompanyName, quote.StockPrice);
            }
        }
    }
}
