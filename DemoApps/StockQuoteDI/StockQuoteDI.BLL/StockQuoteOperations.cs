using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockQuoteDI.Models;
using StockQuoteDI.Data.StockRepositories;

namespace StockQuoteDI.BLL
{
    public class StockQuoteOperations
    {
        private IStockRepository _repo;

        public StockQuoteOperations(string Type)
        {
            _repo = StockRepositoryFactory.CreateStockRepository(Type);
        }

        public List<StockQuote> RetrieveQuotes(string Symbols)
        {
            return _repo.GetStockInformation(Symbols);
        }
    }
}
