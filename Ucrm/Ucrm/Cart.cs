using System;
using System.Collections.Generic;

namespace Ucrm
{
    /// <summary>
    /// Cart class to generate Carts
    /// </summary>
    class Cart
    {
        


        public Guid Id { get; set; } //Cart ID
        public Guid UserId { get; set; } // ID of theuser who created the cart
        public Dictionary <Guid, int>  Items { get; set; } // List of Products and number of each Product

        public Cart( Guid _UserId)
        {
            this.Id = Guid.NewGuid();
            this.UserId = _UserId;
            this.Items = new Dictionary<Guid, int> { };
        }

        /// <summary>
        /// Deletes an item from the cart.
        /// </summary>
        /// <param name="productId">The Id of the product that will be removed from the cart</param>
        public void RemoveItemFromCart(Guid productId)
        {
            if (Items.ContainsKey(productId))
            {
                Items.Remove(productId);
            }
        }

        public void AddProduct(Product product, int quantity)
        {
            if (Items.ContainsKey(product.Id))
            {
                Items[product.Id] += quantity;
            }
            else
            {
                Items.Add(product.Id, quantity);
            }
        }
    }
}
