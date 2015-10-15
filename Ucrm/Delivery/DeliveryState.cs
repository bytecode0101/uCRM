using StockManagement;

namespace Delivery
{/// <summary>
/// Abstract class 
/// </summary>
    public abstract class AbstractDeliveryState
    {

        protected ProductToBeDelivered productToDeliver;
        protected AbstractDeliveryState NextState {get; set;}
        public abstract void Continue();

    }
}