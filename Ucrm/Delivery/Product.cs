using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery;

namespace Ucrm
{
    public class Product
    {
        public Product()
        {
        }

        public string Name { get; set; }
        public Guid Id { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public string Category { get; set; }
        public int NumberOfUnits { get; set; }
        public float SallerPrice { get; set; }

        public DeliveryState product_state { get; set; }

        internal void ContinueToNextState(DeliveryState NextState)
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
