using System;
using System.Collections.Generic;
using Ucrm.Payment;

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
       
        public Delivery Delivery { get; set; }
        public DateTime DeliveryTime { get; set; }
        Dictionary<Guid, int> _Items;

        public Order(Guid _UserId, Cart cart) : base(_UserId)
        {
            
            Delivery = 0;
            Status = 0;
            SetTime = DateTime.Now;
            Items = _Items;
        }


        public Order(Guid _UserId, Cart cart, ConcretePayment _PayMethod) : base(_UserId)
        {
           
            Delivery = 0;
            Status = 0;
            SetTime = DateTime.Now;
            Items = _Items;
        }

        public Order(Guid _UserId, Cart cart, ConcretePayment _PayMethod, Delivery _Delivery) : base(_UserId)
        {
           
            Delivery = _Delivery;
            Status = 0;
            SetTime = DateTime.Now;
            Items = _Items;
        }

        public Order(Guid _UserId, Cart cart, Delivery _Delivery) : base(_UserId)
        {
            
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
