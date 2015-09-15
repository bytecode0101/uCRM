using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ucrm
{
    /// <summary>
    /// Assignes a role to each user - controls access rights (Client/Seller)
    /// Sellers will login using a name that contains "0000" at the beginning. 
    /// </summary>
    class Role
    {
        private string Desc;
        private string Title; 

        public string desc { get; set; }
        public string title { get; set; }

        
        public Role()
        {

        }

        User FirstUser = new User();

        public void AssignRole()
        {
            if (FirstUser.name.Contains("0000")) {
                // 
            } 
        }
    }
    
}
