using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;

namespace WcfService2
{
    public class Admin
    {
        private string securitycode;

        public string Securitycode
        {
            get { return securitycode; }
            set { securitycode = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
       

    }
}