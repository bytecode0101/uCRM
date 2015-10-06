using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ucrm
{
    public class RegisteredOrder : DeliveryState
    {
        protected Product product;

        //Constructor
        public RegisteredOrder(Product product)
        {
            product_to_deliver = product;
        }


        public override void Continue()
        {
            NextState = new WithCourier(product);
            Console.WriteLine("Product order is now registered");
            product.ContinueToNextState(NextState);
        }

        
    }
}