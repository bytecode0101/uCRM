using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucrm.ItemManagement
{
    public class Product
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public string Category { get; set; }
        public int NumberOfUnits { get; set; }
        public float SallerPrice { get; set; }

        public List<Tag> Tags { get; set; }
    }
}
