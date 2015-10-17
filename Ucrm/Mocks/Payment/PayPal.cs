using CrmCore;
using Payment.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mocks.Payment
{
    class PayPal : IPayPal
    {
        public bool Authenticate(string clientId, string password)
        {
            Console.WriteLine("Client Authentication with: {0},{1}, ", clientId, password);
            return true;
        }

        public bool Pay(double amount, Guid orderId, string userName, string password)
        {
            Console.WriteLine("Payment made with PayPal,{0},{1}, {2}, {3}", amount, orderId, userName, password);
            return true;
        }
    }
}
