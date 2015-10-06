using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Ucrm
{
    public class Delievered : DeliveryState
    {

        protected Product product;
        
        DeliveryState NextState;

        //Constructor
        public Delievered(Product product)
        {
            product_to_deliver = product;
        }

        public override void Continue()
        {
            NextState = new Delievered(product);
            Console.WriteLine("Product has been delivered to client");
            product.ContinueToNextState(NextState);
        }
    }
    }
