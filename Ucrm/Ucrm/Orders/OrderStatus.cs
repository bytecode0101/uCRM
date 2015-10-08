using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucrm
{
    public enum OrderStatus
    {
        NotConfirmed= 0,
        Confirmed = 1,
        Payed = 2,
        Canceled = 3,
        InTransit = 4,
        Delivered = 5
    }
}
