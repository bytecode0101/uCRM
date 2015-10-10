using StockManagement;
using System.Collections.Generic;

namespace Ucrm
{
    public abstract class AbstractSearchEngine
    {
        List<Product> product_list;
        
        public abstract List<Product> Search(string S);

    }
}