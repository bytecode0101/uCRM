using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager
{
    public class Manager
    {
        private List<Order> orders;

        public List<Order> Orders 
        {
            get
            {
                return orders;
            }

            set
            {
                orders = value;
            }
        }

        public List<Order> ListOrders()
        {
            return Orders;
        }

        //public Order GetOrderById(Guid orderId)
        //{
        //    var result = Orders.Where(w=>w.OrderId.Equals(orderId))
        //    //return 
        //}

    }

    //public class Clas1 : System.IEquatable<Clas1>
    //{
    //    int x;
    //    int y;
    //    public bool Equals(Clas1 other)
    //    {
    //        //return this.GetHashCode().Equals(other.GetHashCode());
    //        return this.x == other.y && this.y = other.y;
    //    }
    //}
}
