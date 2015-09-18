using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucrm
{
    /// <summary>
    /// This class will repreent the customer with all the actions that he can perform
    /// </summary>
    class Customer
    {
        /// <summary>
        /// A user has a user assoctiated
        /// </summary>
        private User customerUser;
        /// <summary>
        /// each user has one unique cart
        /// </summary>
        private Cart customerCart;
        /// <summary>
        /// Each user has an A
        /// </summary>
        private Address customerAdress;

        internal User CustomerUser
        {
            get
            {
                return customerUser;
            }

            set
            {
                customerUser = value;
            }
        }

        public Cart CustomerCart
        {
            get
            {
                return customerCart;
            }

            set
            {
                customerCart = value;
            }
        }
    }
}
