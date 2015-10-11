
using StockManagement;
using System.Collections.Generic;

namespace Ucrm.ItemManagement
{
    public class SearchResult
    {
        public SearchResult()
        {
            this.listProducts = new List<Product>();
        }
        public string Description { get; set; }
        public List<Product> listProducts { get; set; }

    }
}