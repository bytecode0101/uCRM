using StockManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ucrm
{
    public abstract class SearchEngine
    {
        List<Product> product_list;
        
        public abstract List<Product> Search(string S);

    }
}