using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucrm
{
    public class Product
    {
        string Name { get; set; }
        Guid ID { get; set; }
        string Description { get; set; }
        float Price { get; set; }
        string Category { get; set; }
        int NumberOfUnits { get; set; }
        float SallerPrice { get; set; }
    }
}
