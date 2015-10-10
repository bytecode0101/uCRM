using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucrm
{
    /// <summary>
    /// Pay class handles the payment from the customer
    /// </summary>
    public class Pay
    {
        /// <summary>
        /// CheckPaymentMethod cecks for the payment method used by the customer
        /// </summary>
        public void CheckPaymentMethod()
        {
            //if "cash" follow cash procedure
            //if "banca" follow bank procedure
            //if "op" follow op procedure
        }

        /// <summary>
        /// CheckPaymentStatus checks if we have revieved the money
        /// </summary>
        /// <returns>"true" - we have revieved the money / "false" - we havent recieved the money</returns>
        public bool CheckPaymentStatus()
        {
            //check if the payment was recieved
            return true;
        }

        /// <summary>
        /// RegisterPayment registers the payment into @ out accountant
        /// </summary>
        public void RegisterPayment()
        {
            //register payment
        }


    }
}
