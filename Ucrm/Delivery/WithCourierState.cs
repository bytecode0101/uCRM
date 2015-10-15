using System;
using StockManagement;

namespace Delivery
{
    public class WithCourierState : AbstractDeliveryState
    {
        protected ProductToBeDelivered product_on_the_way;
        AbstractDeliveryState NextState;

        //Constructor
        public WithCourierState(Product product)
        {
            productToDeliver.product = product;
        }

        public override void Continue()
        {
            NextState = new InTranzitState(product_on_the_way.product);
            Console.WriteLine("Product is now in custody of courier");
            product_on_the_way.ContinueToNextState(NextState);
        }
    }
}