using System;

namespace CrmCore
{
    public interface IEPay
    {
        void Pay(double amount, string cardNumber, string cvv, DateTime expirationDate);
    }
}