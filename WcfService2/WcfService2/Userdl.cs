using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService2
{
    public class Userdl
    {
        public static List<User> users = new List<User>();
        User Searchuser(string Username);
        void AddUser(Userdl u);
        void DeleteUser(String username);
        void DeleteUser(int usercode);
        List<User> SearchAllUser();
    }
}