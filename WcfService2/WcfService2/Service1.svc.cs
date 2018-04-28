using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public bool isvalid(string uname, string password)
        {
            Userdl u = new Userdl();
            bool found = u.isvalid(uname, password);
            return found;
        }
        public void AddUser(string uname, string upassword, string uemail, string ucontact, string uarea, string uques, string uans, string uacname, string uacno, int ucode, string udata)
        {
            Userdl u = new Userdl();
            u.AddUser(uname, upassword, uemail, ucontact, uarea, uques, uans, uacname, uacno, ucode, udata);
        }
        //public void Resetassword(string pass) { }
        // public void AddEvent(Event e) { }
        //public void Conform(bool var) { }
        //public void CancelEvent() { }
        //public Event Search(int eventcode);
        //public  void DeleteUser(string username) { }
        // public  void DeleteUser(int usercode) { }
        //public List<User> SearchAllUser(){}
        //public User Searchuser(string Username){}
        //public void DellImg(int code) { }
        //public void AddImg(Image img) { }
 
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
