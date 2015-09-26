using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockManagement
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".


    /// <summary>
    /// ProductDatabase class allows to add/remove/search products from out stock
    /// </summary>
    public class ProductDataBase
    {
        List<Product> listaProduse = new List<Product>();

        public void AddProduct(Product productobj)
        {
            listaProduse.Add(productobj);
        }

        public void RemoveProduct(string pname)
        {

        }

        public void SearchProd(Product src_param)
        {

        }
    }
}
