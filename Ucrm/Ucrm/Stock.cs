using System.Collections.Generic;
using System;

namespace Ucrm
{
    ///This is the stock of our products. 
    ///This will keep all of our products with the corresponding quantity
    ///
    class Stock
    {
        /// <summary>
        /// We use a dictionary in order to store the products associated with the corresponding quantity
        /// </summary>
        private Dictionary<Guid, int> productStock;
      
        ///constructor
        public Stock() 
        {
            productStock = new Dictionary<Guid, int>();
        }

        public Dictionary<Guid, int> ProductStock
        {
            get
            {
                return productStock;
            }

            set
            {
                productStock = value;
            }
        }

        /// <summary>
        /// This will add a new Product to our sstock
        /// </summary>
        /// <param name="p"></param>
        /// <param name="quantity"></param>
        private void AddNewProduct (Guid p,int quantity)
        {
            productStock.Add(p, quantity);
        }
        /// <summary>
        /// This will add a new quantity to a specific product
        /// </summary>
        /// <param name="p"></param>
        /// <param name="quantity"></param>
        private void AddQuantity(Guid p, int quantity)
        {
            ///if the stock does not contain the product yet, then we shoud just add it
            /// if the sotck contains the product then we will add the wuatity to the existing quantity
            if (!productStock.ContainsKey(p))
            {
                AddNewProduct(p, quantity);
            }
            else
            {
                productStock[p]+=quantity;
            }
                

                
        }

    }
}
