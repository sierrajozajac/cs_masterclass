using System;
using System.Collections.Generic;
using System.Text;

namespace C_Masterclass_Proj
{
    public class User
    {
        private string userName;
        private string password;
        private bool isAdminBool;

        public User(string name, string pass, bool admin)
        {
            userName = name;
            password = pass;
            isAdminBool = admin;
        }

        public bool isEqual(User other)
        {
            bool userNameEqual = userName.Equals(other.getUserName());
            bool passwordEqual = password.Equals(other.getPassword());
            bool isAdminEqual = isAdminBool && other.isAdmin();
            bool ret = userNameEqual && passwordEqual && isAdminEqual;
            return ret;
        }

        public string getUserName()
        {
            return userName;
        }

        public string getPassword()
        {
            return password;
        }

        public bool isAdmin()
        {
            return isAdminBool;
        }
    }
}
