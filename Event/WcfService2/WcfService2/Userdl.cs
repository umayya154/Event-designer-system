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
        public bool isvalid(string uname, string password)
        {
            bool isFound = false;
            foreach (User u in Userdl.users)
            {
                if ((u.Username == uname) && (u.Password == password))
                {
                    isFound = true;
                }
            
            }
            return isFound;
        }
     
       public void AddUser(string uname, string upassword, string uemail, string ucontact, string uarea, string uques, string uans, string uacname, string uacno, string ucode, string udata)
        {
            User u = new User();
           
           
            u.Area = uarea;
            u.SecretQs1 = uques;
            u.Answer = uans;
            u.Accountname = uacname;
            u.Accountno = uacno;
            u.Email = uemail;
            u.ContactNo = ucontact;
            u.Password = upassword;
            u.Username = uname;
            u.Usercode = ucode;
            u.Date = udata;
            users.Add(u);
        }
       public void DeleteUser(User u)
       {

         //  foreach(User u in Userdl.users)
          // {
            //   if ((u.Username == username) && (u.Usercode == usercode))
            //   {
                   users.Remove(u);
             //  }
        //   }
       }
        //public void DeleteUser(int usercode);
       public List<User> SearchAllUser()
       {
           return Userdl.users;
       }
    }
}