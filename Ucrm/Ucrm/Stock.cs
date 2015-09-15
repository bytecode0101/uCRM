using System.Collections.Generic;
using System;

namespace Ucrm
{
    ///This is the stock of our products. 
    ///This will keep all of our products with the corresponding quantity
    ///
    class Stock
    {
        Dictionary<Guid, int> stock;
        ///constructor
        public Stock() 
        {
            stock = new Dictionary<Guid, int>();
        }
        /// <summary>
        /// This will add a new Product to our sstock
        /// </summary>
        /// <param name="p"></param>
        /// <param name="quantity"></param>
        private void AddNewProduct (Guid p,int quantity)
        {
            stock.Add(p, quantity);
        }
        /// <summary>
        /// This will add a new quantity to a specific product
        /// </summary>
        /// <param name="p"></param>
        /// <param name="quantity"></param>
        private void AddQuantity(Guid p, int quantity)
        {
            if (!stock.ContainsKey(p))
            {
                AddNewProduct(p, quantity);
            }
            else
            {
                stock[p]+=quantity;
            }
                

                
        }

    }
}
