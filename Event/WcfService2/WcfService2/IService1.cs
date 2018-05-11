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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        /* [OperationContract]
       void Resetassword();
       [OperationContract]
       void AddEvent(Event e);
       [OperationContract]
       void Conform(bool var);
       
       [OperationContract]
       Event Search(int eventcode);*/
       // [OperationContract]
        //bool is_validAdmin(string aname, string apassword, string acode);
        [OperationContract]
        bool CancelEvent(string uname, string ucode, string udate, string ereason);
        [OperationContract]
        void AddUser(string uname, string upassword, string uemail, string ucontact, string uarea, string uques, string uans, string uacname, string uacno, string ucode, string udata);
        [OperationContract]
        bool isvalid(string uname, string password);
        /*[OperationContract]
         void DeleteUser(string username);
         [OperationContract]
         void DeleteUser(int usercode);
         
         [OperationContract]
         User Searchuser(string Username);
        [OperationContract]
         void DellImg(int code);*/
       // [OperationContract]
        //List<User> SearchAllUser();
         [OperationContract]
         void AddImg(string cata , string code, Image img);
        [OperationContract]
         List<Event> SearchAll();
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
       
        
    }
}
