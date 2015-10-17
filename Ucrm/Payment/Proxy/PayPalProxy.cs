using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrmCore;

namespace Payment.Proxy
{
    class PayPalProxy : IPayPal
    {
        private string userName;
        private string password;
        private double amount;
        private Guid transactionId;
        private Guid clientId;
        private DateTime transactionDateTime;
        private IPayPal paypalSystem;

        /// <summary>
        /// Authentification of the client system(uCRM)
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Authenticate(string clientId, string password)
        {
            return paypalSystem.Authenticate(clientId,password);
        }

        public bool Pay(double amount, Guid orderId, string userName, string password)
        {
            return paypalSystem.Pay(amount, orderId, userName, password);
        }
    }
}
