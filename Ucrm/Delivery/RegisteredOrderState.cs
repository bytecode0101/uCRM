using System;
using StockManagement;

namespace Delivery
{
    public class RegisteredOrderState : AbstractDeliveryState
    {

        //Constructor
        public RegisteredOrderState(Product product)
        {
            productToDeliver.product = product;
        }


        public override void Continue()
        {
            NextState = new WithCourierState(productToDeliver.product);
            Console.WriteLine("Product order is now registered");
            productToDeliver.ContinueToNextState(NextState);
        }
    }
}