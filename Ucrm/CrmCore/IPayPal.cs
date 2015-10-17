using System;

namespace CrmCore
{
    public interface IPayPal
    {
        bool Authenticate(string clientId, string password);
        bool Pay(double amount, Guid orderId, string userName, string password);
    }
}