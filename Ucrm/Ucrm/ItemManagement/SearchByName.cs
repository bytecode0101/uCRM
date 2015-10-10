using StockManagement;
using System.Collections.Generic;

namespace Ucrm
{
    public class SearchByName : AbstractSearchEngine
    {
        List<Product> product_list;
        Product product;

       
        public override List<Product> Search(string S)
        {
            if (S == product.Name)
            {
                product_list.Add(product);
            }

            if (product.Name.Contains(S))
            {
                product_list.Add(product);
            }
            return product_list;

        }
    }
}