using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManager;

namespace Payment
{
    public class RambursPaymentState : IPaymentState
    {
        public void Pay()
        {
            
        }

        public void Pay(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
