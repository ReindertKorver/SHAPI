using System;
using System.Collections.Generic;
using System.Text;

namespace SHAPI_ClassLibrary.Models
{
    class User
    {
        public string UniqueID { get; set; }
        public string UserName { get; set; }
        private string password { get; set; }
        public string Password
        {
            get
            {
                //hashing should be done here
                return password;
            }
            set { password = value; }
        }
        public string HashedPassword { get; set; }
        public Role role { get; set; }
    }
}
