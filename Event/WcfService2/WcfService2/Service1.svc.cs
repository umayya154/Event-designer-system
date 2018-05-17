using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Drawing;

namespace WcfService2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public bool is_validAdmin(string aname, string apassword,string acode)
        {
           Admin u = new Admin();
            bool found = u.is_validAdmin(aname, apassword, acode);
            return found;
        }
        public bool isvalid(string uname, string password)
        {
            Userdl u = new Userdl();
            bool found = u.isvalid(uname, password);
            return found;
        }
        public void AddUser(string uname, string upassword, string uemail, string ucontact, string uarea, string uques, string uans, string uacname, string uacno, string ucode, string udata)
        {
            Userdl u = new Userdl();
            u.AddUser(uname, upassword, uemail, ucontact, uarea, uques, uans, uacname, uacno, ucode, udata);
        }
        public List<Event> SearchAll()
        {
            Eventdl ed = new Eventdl();
            return ed.SearchAll();
        }
      
        //public void Resetassword(string pass) { }
        public void AddEvent(string name, string dateofevent, string days, string usercode, string eventcode, string location, string guestquantity, string Payment)
         {
             Eventdl e = new Eventdl();
            e.AddEvent(name, dateofevent, days, usercode, eventcode, location, guestquantity, Payment);
         }
        //public void Conform(bool var) { }
        public bool CancelEvent(string uname, string ucode, string udate, string ereason)
        {
            Eventdl ed = new Eventdl();
            return ed.CancelEvent(uname, ucode, udate, ereason);
        }
        public bool Search(string uname, string fdback)
        {
            Eventdl ed = new Eventdl();
            return ed.Search(uname, fdback);
        }
        public  void DeleteUser(string username, string usercode) 
        {
            Userdl ud = new Userdl();
            foreach (User u in Userdl.users.ToArray())
            {
                if ((u.Username == username) && (u.Usercode == usercode))
                {
                    ud.DeleteUser(u);
                }
            }
        }
        // public  void DeleteUser(int usercode) { }
        public List<User> SearchAllUser(){
            Userdl se = new Userdl();
            return se.SearchAllUser();
        }
        public bool Chngpass(string uname, string uemail, string que, string ans, string passwd)
        {
            foreach (User u in Userdl.users)
            {
                if ((u.Username == uname) && (u.Email == uemail) && (u.SecretQs1 == que) && (u.Answer == ans))
                {
                    u.Password = passwd;
                    return true;
                }
            }
            return false;
        }
        //public User Searchuser(string Username){}
        //public void DellImg(int code) { }
        public void AddImg(string cata, string code,Image img) 
        {
            Gallerydl g = new Gallerydl();
           
            g.AddImg(cata, code, img);
        }
        public List<Event> SearchCancel()
        {
            Eventdl ed = new Eventdl();
            return ed.SearchCancel();
        }
 
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        
    }
}
