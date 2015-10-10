using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ucrm
{
    /// <summary>
    /// Assignes a role to each user - controls access rights (Client/Seller)
    /// Sellers will login using a name that contains "Seller" + code that they receive when registering a new account. 
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
        /// <summary>
        /// Assigns a role for the user : client or seller
        /// </summary>
        public void AssignRole()
        {
            if (FirstUser.login_user.User_in_account == true)
            {
                if (FirstUser.name.Contains("seller") || FirstUser.name.Contains("Seller"))
                {

                    this.Desc = "This is a seller account";
                    this.Title = "Seller";
                }
                else
                {
                    this.Desc = "This is a client account";
                    this.Title = "Client";
                }
            }
            else
            {
                FirstUser.login_user.Login();
            }
        }
    }
}



