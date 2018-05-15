using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService2
{
    public class Eventdl
    {
        public static List<Event> users = new List<Event>();
        public static List<Event> cancel = new List<Event>();
        public List<Event> SearchAll()
        {
            return Eventdl.users;
        }
        public List<Event> SearchCancel()
        {
            return Eventdl.cancel;
        }
       public void AddEvent(string name, string dateofevent,string days, string usercode,string eventcode,string location,string guestquantity,string Payment)
        {
            Event e = new Event();
            e.Location = location;
            e.Guestquantity = guestquantity;
            e.Payment = Payment;
            e.Eventstatus = "Pending";
          
            e.Days = days;
            e.Dateofevent = dateofevent;
            e.Acode= usercode;
            e.Eventcode = eventcode;
            e.Aname = name;
            users.Add(e);
        }
        //void Conform(bool var);
        public bool CancelEvent(string uname, string ucode, string udate, string ereason)
        {
            foreach (Event e in Eventdl.users)
            {
                if ((e.Aname == uname) && (e.Acode == ucode))
                {
                    e.Eventstatus = "Cancel";
                    e.Cancelreason = udate + " " + ereason;
                    cancel.Add(e);
                    return true;
                }
            }
            return false;
        }
        public bool Search(string uname, string ucode)
        {
            foreach (Event e in Eventdl.users)
            {
                if ((e.Aname == uname) && (e.Acode == ucode))
                {
                   return true;
                }
            }
            return false;
        }
        

    }
}