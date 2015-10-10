using System.Collections.Generic;
using System;
using System.ComponentModel;

namespace Ucrm.ItemManagement
{
    ///This is the stock of our products. 
    ///This will keep all of our products with the corresponding quantity
    ///
    class Stock : INotifyPropertyChanged
    {
        /// <summary>
        /// We use a dictionary in order to store the products associated with the corresponding quantity
        /// </summary>
        private Dictionary<Guid, int> productStock;

        private List<Product> products;
        public AbstractSearchEngine SearchEngine { get; set; }

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

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// This will add a new Product to our sstock
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="quantity"></param>
        public void AddNewProduct(Guid productId, int quantity)
        {
            productStock.Add(productId, quantity);
        }

        /// <summary>
        /// This will add a new quantity to a specific product
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="quantity"></param>
        public void AddQuantity(Guid productId, int quantity)
        {
            ///if the stock does not contain the product yet, then we shoud just add it
            /// if the sotck contains the product then we will add the wuatity to the existing quantity
            if (!productStock.ContainsKey(productId))
            {
                AddNewProduct(productId, quantity);
            }
            else
            {
                productStock[productId] += quantity;
            }
        }

        /// <summary>
        /// This will remove quantity from the stock
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="quantity"></param>
        public void RemoveQuantity(Guid productId, int quantity)
        {
            ///if the stock  contains the product yet, then we will remove the quantity
            /// if the stock contains less products than you would like to remove, then we should throw an error
            if (productStock.ContainsKey(productId))
            {
                if (productStock[productId] >= quantity)
                {
                    productStock[productId] -= quantity;
                    if (productStock[productId] == 0)
                    {
                        if (PropertyChanged != null)
                        {
                            PropertyChanged.Invoke(this, new PropertyChangedEventArgs("ProductStock"));
                        }
                    }
                }
                else
                {
                    throw new InsufficientStockException();
                }
            }
        }

        /// <summary>
        /// Searches the stock for products that have the specified tag(s)
        /// </summary>
        /// <returns></returns>
        public Dictionary<Guid, int> Search()
        {
            Dictionary<Guid, int> res = new Dictionary<Guid, int>();
            object tag;
            foreach (var product in products)
            {
                
            }
            return res;
        }

      

    }
}
