using OrderManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrmCore;

namespace Payment
{
    public class CardPaymentState : IPaymentState
    {
        IEPay paymentSystem;

        public void Pay(Order order)
        {
            var cardNumber = Console.ReadLine();
            var cvv = Console.ReadLine();
            DateTime expirationDate;
            DateTime.TryParse(Console.ReadLine(), out expirationDate);
            paymentSystem.Pay(order.Amount, cardNumber, cvv, expirationDate);
        }
    }
}
