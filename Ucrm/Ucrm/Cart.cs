using System;
using System.Collections.Generic;

namespace Ucrm
{
    class Cart
    {
        /// <summary>
        /// Cart class to generate Carts
        /// </summary>

        public Guid ProdId { get; set; }
        public Guid Id { get; set; } //Cart ID
        public Guid UserId { get; set; } // ID of theuser who created the cart
        public Dictionary<Guid, int> Items { get; set; } // List of Products and number of each Product

        public Cart(Guid _UserId)
        {
            this.Id = Guid.NewGuid();
            this.UserId = _UserId;
            this.Items = new Dictionary<Guid, int> { };
        }

        /// <summary>
        /// The RemoveItemFromCart method deletes an item from cart at a certain position.
        /// </summary>
        /// <param name="prodlist">prodlist is a Dictionary parameter that allows us to delete a Dictionary entry</param>
        public void RemoveItemFromCart(Guid productId)
        {
            if (Items.ContainsKey(productId))
            {
                Items.Remove(productId);
            }
        }
    }
}
