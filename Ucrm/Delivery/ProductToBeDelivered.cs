using StockManagement;

namespace Delivery
{
    public class ProductToBeDelivered
    {
        public Product product;
        public AbstractDeliveryState product_state { get; set; }

        internal void ContinueToNextState(AbstractDeliveryState NextState)
        {
            product_state = NextState;
            product_state.Continue();
        }

        public void Start()
        {
            product_state.Continue();
        }
    }
}
