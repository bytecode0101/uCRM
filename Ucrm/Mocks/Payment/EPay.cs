using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mocks.Payment
{
    class EPay
    {
        public void Pay(double amount, string cardNumber, string cvv, DateTime expirationDate)
        {
            Console.WriteLine("Payment made with Epay {0} {1} {2} {3}", amount, cardNumber, cvv, expirationDate.Date);
        }
    }
}
