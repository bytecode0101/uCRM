
using StockManagement;
using System.Collections.Generic;

namespace Ucrm
{
    public class SearchResult
    {
        string Description { get; set; }

        List<Product> products
        {
            get; set;
        }
        public SearchResult Results;
        
    }
}