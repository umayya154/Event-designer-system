using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;

namespace WcfService2
{
    public class Admin
    {
        private string securitycode = "admin123";

        public string Securitycode
        {
            get { return securitycode; }
            set { securitycode = value; }
        }
        private string password = "12345";

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private string name = "Admin";

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public bool is_validAdmin(string aname, string apassword, string acode)

        {
            bool found = false;
            if((Name == aname)&&(Password == apassword)&&(securitycode == acode)){
                found = true;
            }
                return found;
            }
        }

    }
