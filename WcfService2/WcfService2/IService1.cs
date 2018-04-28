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
        /* [OperationContract]
        void Resetassword();
        [OperationContract]
        void AddEvent(Event e);
        [OperationContract]
        void Conform(bool var);
        [OperationContract]
        void CancelEvent();
        [OperationContract]
        Event Search(int eventcode);*/
        [OperationContract]
        void AddUser(string uname, string upassword, string uemail, string ucontact, string uarea, string uques, string uans, string uacname, string uacno, int ucode, string udata);
        [OperationContract]
        bool isvalid(string uname, string password);
       /*[OperationContract]
        void DeleteUser(string username);
        [OperationContract]
        void DeleteUser(int usercode);
        [OperationContract]
        List<User> SearchAllUser();
        [OperationContract]
        User Searchuser(string Username);
       [OperationContract]
        void DellImg(int code);
        [OperationContract]
        void AddImg(Image img);
        */
        
    }
}
