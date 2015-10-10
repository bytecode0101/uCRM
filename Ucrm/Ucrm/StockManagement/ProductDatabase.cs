using System.Collections.Generic;

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

        /// <summary>
        /// Add a product object, to the product list
        /// </summary>
        /// <param name="productobj"> - the object added @ productlist</param>
        public void AddProduct(Product productobj)
        {
            listaProduse.Add(productobj);
        }

        public void RemoveProduct(Product productobj)
        {
            listaProduse.Remove(productobj);
        }

        public Product SearchProd(Product productobj,string srcname)
        {
            foreach (var item in listaProduse)
            {
                if(item.Name == srcname)
                {
                    productobj = item;
                }
 
            }
            return productobj;
        }
    }
}
