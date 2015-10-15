using System;
using StockManagement;

namespace Delivery
{
    public class InTranzitState : AbstractDeliveryState
    {
        protected ProductToBeDelivered product_on_the_way;
        protected AbstractDeliveryState nextState;

        //Constructor
        public InTranzitState(Product product)
        {
            productToDeliver.product = product;
        }

        public override void Continue()
        {
            NextState = new DelieveredState(product_on_the_way.product);
            Console.WriteLine("Product is currently in tranzit");
            product_on_the_way.ContinueToNextState(NextState);
        }
    }
}