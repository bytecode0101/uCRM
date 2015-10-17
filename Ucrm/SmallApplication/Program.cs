using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManager;
using Payment;

namespace SmallApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            IPaymentState paypalPaymentState = new PayPalPaymentState();
            IPaymentState cardPaymentState = new CardPaymentState();
            IPaymentState rambursPaymenState = new RambursPaymentState();

            Order order = new Order();
            order.Amount = 100.0;

            paypalPaymentState.Pay(order);
        }
    }
}
