using StockManagement;
using System.Collections.Generic;

namespace Ucrm.ItemManagement
{
    public abstract class AbstractSearchEngine
    {        
        public AbstractSearchEngine NextSearchengine { get; set; }

        /// <summary>
        /// Searches the list of products by the provided text
        /// </summary>
        /// <param name="strKey">the text that search engine will it use for rereiveing products</param>
        /// <returns></returns>
        public abstract void Search(string strKey, List<Product> lstProducts, List<SearchResult> finalResult);

        public SearchResult SearchResult { get; set; }

    }
}