using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Ucrm
{
    public class InTranzit : DeliveryState
    {
        protected Product product;
        DeliveryState NextState;

        //Constructor
        public InTranzit(Product product)
        {
            product_to_deliver = product;
        }

        public override void Continue()
        {
            NextState = new Delievered(product);
            Console.WriteLine("Product is currently in tranzit");
            product.ContinueToNextState(NextState);
        }
    }
}