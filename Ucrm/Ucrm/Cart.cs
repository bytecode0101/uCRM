﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucrm
{
    class Cart
    {
        /// <summary>
        /// 
        /// </summary>


        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Dictionary <Product, int>  Items { get; set; }

        public Cart( Guid _UserId)
        {
            this.Id = Guid.NewGuid();
            this.UserId = _UserId;
            this.Items = new Dictionary<Product, int> { };
        }

       /// <summary>
       /// The RemoveItemFromCart method deletes an item from cart at a certain position.
       /// </summary>
       /// <param name="prodlist">prodlist is a Dictionary parameter that allows us to delete a Dictionary entry</param>
        public void RemoveItemFromCart(Dictionary<Product, int> prodlist)
        {
            prodlist.Remove(new Product());
            //remove product from cart based on its id/name/its placement in the product List
        }
    }
}
