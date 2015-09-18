using System;
using System.Collections.Generic;

namespace Ucrm
{
    /// <summary>
    /// Order class extends cart class. OrderButton transforms a Cart in an Order
    /// </summary>
    public class Order : Cart
    {
        public DateTime SetTime { get; set; }
        public DateTime ConfirmedTime { get; set; }
        public OrderStatus Status { get; set; }
        public Payment PayMethod { get; set; }
        public Delivery Delivery { get; set; }
        public DateTime DeliveryTime { get; set; }

        public Order(Guid _UserId, Dictionary<Guid, int> _Items) : base(_UserId)
        {
            PayMethod = 0;
            Delivery = 0;
            Status = 0;
            SetTime = DateTime.Now;
            Items = _Items;
        }

        public Order(Guid _UserId, Dictionary<Guid, int> _Items, Payment _PayMethod) : base(_UserId)
        {
            PayMethod = _PayMethod;
            Delivery = 0;
            Status = 0;
            SetTime = DateTime.Now;
            Items = _Items;
        }

        public Order(Guid _UserId, Dictionary<Guid, int> _Items, Payment _PayMethod, Delivery _Delivery) : base(_UserId)
        {
            PayMethod = _PayMethod;
            Delivery = _Delivery;
            Status = 0;
            SetTime = DateTime.Now;
            Items = _Items;
        }

        public Order(Guid _UserId, Dictionary<Guid, int> _Items, Delivery _Delivery) : base(_UserId)
        {
            PayMethod = 0;
            Delivery = _Delivery;
            Status = 0;
            SetTime = DateTime.Now;
            Items = _Items;
        }

        public void AddProduct(Guid ProductId)
        {


        }

        public void Confirm()
        {
            Status = (OrderStatus)1;
            ConfirmedTime = DateTime.Now;
        }

        public void SetDeliveryTime(DateTime _DeliveryTime)
        {
            DeliveryTime = _DeliveryTime;
        }

    }

}
