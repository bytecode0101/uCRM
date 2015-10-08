using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockManagement
{
    /// <summary>
    /// Enumeration representing the status of a product
    /// </summary>
    public enum ProdStatus
    {
        OutOfStock,
        InStock,
        OrderFromSupplier,
        LimitedAmount
    }
}
