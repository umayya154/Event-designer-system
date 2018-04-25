using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService2
{
    public class Userdl
    {
        public static List<User> users = new List<User>();
        //public User Searchuser(string Username);
       public void AddUser(string uname, string upassword, string uemail, string ucontact, string uarea, string uques, string uans, string uacname, string uacno, int ucode, string udata)
        {
            User u = new User();
            u.Username = uname;
            u.Password = upassword;
            u.Email = uemail;
            u.ContactNo = ucontact;
            u.Area = uarea;
            u.SecretQs1 = uques;
            u.Answer = uans;
            u.Accountname = uacname;
            u.Accountno = uacno;
            u.Usercode = ucode;
            u.Date = udata;
            users.Add(u);
        }
        //public void DeleteUser(String username);
        //public void DeleteUser(int usercode);
        //public List<User> SearchAllUser();
    }
}