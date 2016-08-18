using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockQuoteDI.Models;

namespace StockQuoteDI.Data.StockRepositories
{
    public static class StockRepositoryFactory
    {
        public static IStockRepository CreateStockRepository(string Type)
        {
            switch (Type.ToUpper())
            {
                case "G":
                    return new GoogleStockRepository();
                case "Y":
                    return new YahooStockRepository();
                case "T":
                    return new TestStockRepository();
                default:
                    throw new NotSupportedException(String.Format("{0} not supported!", Type));
            }
        }
    }
}
