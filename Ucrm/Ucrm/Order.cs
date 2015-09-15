using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucrm
{
    class Order : Cart
    {
        /// <summary>
        /// 
        /// </summary>


        public DateTime SetTime { get; set; }
        public DateTime ConfirmedTime { get; set; }
        public OrderStatus Status { get; set; }
        public Payment PayMethod { get; set; }
        public Delivery Delivery { get; set; }
        public DateTime DeliveryTime { get; set; }

        public Order (Guid _UserId) : base (_UserId)
        {
            

        }

        public void AddProduct (Guid ProductId)
        {


        }
    }

}
