using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucrm
{
    class Cart
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Dictionary <Product, int>  Items { get; set; }

        public Cart( Guid _UserId)
        {
            this.Id = Guid.NewGuid();
            this.UserId = _UserId;
            this.Items = new Dictionary<Product, int> { };
        }

    }
}
