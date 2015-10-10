using StockManagement;
using System.Collections.Generic;

namespace Ucrm
{
    public abstract class AbstractSearchEngine
    {
        List<Product> product_list;
        List<SearchResult> results;
        
        public abstract List<SearchResult> Search(string S, List<Product> results, List<SearchResult> finalResult);
        public AbstractSearchEngine NextSearchEngine;
        public SearchResult search_result;

    }
}