using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManager;

namespace Payment
{
   public interface IPaymentState
    {
        void Pay(Order order);
    }


}
