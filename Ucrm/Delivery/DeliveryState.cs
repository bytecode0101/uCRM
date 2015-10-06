using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Ucrm
{
    public abstract class DeliveryState
    {

        protected Product product_to_deliver;
        protected DeliveryState NextState {get; set;}
        public abstract void Continue();

    }
}