using StockManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucrm.ItemManagement
{
    public class SearchByCategory : AbstractSearchEngine
    {
        public override void Search(string strKey, List<Product> lstProducts, List<SearchResult> finalResult)
        {
            if (finalResult == null)
            {
                finalResult = new List<SearchResult>();
            }

            //List<SearchResult> finalResult = new List<SearchResult>();
            SearchResult = new SearchResult();
            SearchResult.Description = "Cautarea dupa Categorie";

            foreach (Product item in lstProducts)
            {
                if (item.Category.Contains(strKey))
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
