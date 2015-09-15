using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucrm
{
    class Address
    {
        /// <summary>
        /// Holds address details of users
        /// </summary>
        public string City { get; set; }
        public string Country { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Extra { get; set; }
        public string Phone { get; set; }

        public Address()
        {

        }

        User SomeUser = new User();
        public void SetId()
        {
        }

                
    }
}
