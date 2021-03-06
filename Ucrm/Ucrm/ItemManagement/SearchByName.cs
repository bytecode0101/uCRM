﻿using StockManagement;
using System.Collections.Generic;


namespace Ucrm.ItemManagement
{
    public class SearchByName : AbstractSearchEngine
    {
        public override void Search(string strKey, List<Product> lstProducts, List<SearchResult> finalResult)
        {
            if (finalResult == null)
            {
                finalResult = new List<SearchResult>();
            }

            //List<SearchResult> finalResult = new List<SearchResult>();
            SearchResult = new SearchResult();
            SearchResult.Description = "Cautarea dupa Titlu(name)";

            foreach (Product item in lstProducts)
            {
                if (item.Name.Contains(strKey))
                {
                    SearchResult.listProducts.Add(item);
                }
            }

            finalResult.Add(this.SearchResult);

            if (NextSearchengine != null)
            {
                NextSearchengine.Search(strKey, lstProducts, finalResult);
            }

        }
    }
}