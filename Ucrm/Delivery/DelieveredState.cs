using System;
using StockManagement;

namespace Delivery
{
    public class DelieveredState : AbstractDeliveryState
    {

        protected ProductToBeDelivered product_on_the_way;

        protected AbstractDeliveryState NextState;

        
        public DelieveredState(Product product)
        {
            productToDeliver.product = product;
        }

        public override void Continue()
        {
            NextState = new DelieveredState(product_on_the_way.product);
            Console.WriteLine("Product has been delivered to client");
            product_on_the_way.ContinueToNextState(NextState);
        }
    }
    }
