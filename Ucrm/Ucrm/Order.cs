using System;

namespace Ucrm
{
    /// <summary>
    /// Order class extends cart class. OrderButton transforms a Cart in an Order
    /// </summary>
    class Order : Cart
    {
        public DateTime SetTime { get; set; }
        public DateTime ConfirmedTime { get; set; }
        public OrderStatus Status { get; set; }
        public Payment PayMethod { get; set; }
        public Delivery Delivery { get; set; }
        public DateTime DeliveryTime { get; set; }

        public Order(Guid _UserId) : base(_UserId)
        {


        }

        public void AddProduct(Guid ProductId)
        {


        }
    }

}
