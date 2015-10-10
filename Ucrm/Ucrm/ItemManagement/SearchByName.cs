using StockManagement;
using System.Collections.Generic;


namespace Ucrm

{
    public class SearchByName : AbstractSearchEngine
    {
        List<SearchResult> results;
        List<Product> products;
        Product product;
        

       
        public override List<SearchResult> Search(string S, List<Product> results, List<SearchResult> finalresult)
        {
            if (S == product.Name)
            {
                
                results.Add(product);
            }

            if (product.Name.Contains(S))
            {
                results.Add(product);
            }

            if (this.results == null)
            {
                this.results = new List<SearchResult>();
            }
            if (NextSearchEngine != null)
            {
                NextSearchEngine.Search(S, products, finalresult);
            }
            

            return finalresult;


        }
    }
}