using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucrm
{
    class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Role UserRole { get; set; }


       
        public User()
        {
        if (Id == null || Name == null)
            {
                throw new ArgumentNullException();
            }


        }
       
    }
}
