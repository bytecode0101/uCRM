using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucrm
{
    public class Login_user : ILogin
    {
        bool user_in_account = false;

        public bool User_in_account { get; set; }

        User user = new User();

        public void Login()
        {
            while (User_in_account == false)
            {

                string login_name = user.name ?? "";
                string login_password = user.password ?? "";

                if (login_name == "" || login_password == "")
                {
                    throw new ArgumentNullException("Please do not leave login or password empty");
                }
                
                User_in_account = true;
                
            }
        }
    }
}
    


