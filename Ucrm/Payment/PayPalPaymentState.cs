using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrmCore;
using OrderManager;

namespace Payment
{
    public class PayPalPaymentState : IPaymentState
    {
        IPayPal paypal;

        public void Pay(Order order)
        {
            
           if( paypal.Authenticate("uCrm", "pw"))
            {
                var userName = Console.ReadLine();
                var password = Console.ReadLine();

                paypal.Pay(order.Amount, order.OrderId, userName, password);
            }
                
        }
    }
}
