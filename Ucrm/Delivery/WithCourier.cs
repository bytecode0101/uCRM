using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Ucrm
{
    public class WithCourier : DeliveryState
    {
        protected Product product;
        DeliveryState NextState;

        //Constructor
        public WithCourier(Product product)
        {
            product_to_deliver = product;
        }

        public override void Continue()
        {
            NextState = new InTranzit(product);
            Console.WriteLine("Product is now in custody of courier");
            product.ContinueToNextState(NextState);
        }
    }
}