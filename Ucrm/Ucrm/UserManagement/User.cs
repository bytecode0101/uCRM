using System;

namespace Ucrm
{
    /// <summary>
    /// Holds identification details of all Users(Clients+Sellers) with their assigned roles
    /// </summary>
    class User
    {
        private Guid Id;
        private string Name; 
        private Role UserRole { get; set; }
        private string Password;

        public Guid id { get; set; }
        public string name { get; set; }
        public Role userRole { get; set; }
        public string password { get; set; }

        public Login_user login_user;

        public User()
        {

        }
                

        }
    }
       
    

