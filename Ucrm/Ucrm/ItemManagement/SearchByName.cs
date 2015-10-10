using StockManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ucrm
{
    public class SearchByName : SearchEngine
    {
        List<Product> product_list;
        Product product;

        /// <summary>
        /// Ioana - 
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
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