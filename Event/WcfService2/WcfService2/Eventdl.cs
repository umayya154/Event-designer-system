using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService2
{
    public class Eventdl
    {
        public static List<Event> users = new List<Event>();
         //List<Event> SearchAll ();
        void AddEvent(string name, string dateofevent,string days, string usercode,string eventcode,string location,string guestquantity,string Payment){
            Event e = new Event();
            e.Dateofevent = dateofevent;
            e.Days = days;
            e.Usercode = usercode;
            e.Eventcode = eventcode;
            e.Location = location;
            e.Guestquantity = guestquantity;
            e.Payment = Payment;
            users.Add(e);
        }
        //void Conform(bool var);
        public bool CancelEvent(string uname, string ucode, string udate, string ereason)
        {
            foreach (Event e in Eventdl.users)
            {
                if ((e.Username == uname) && (e.Usercode == ucode))
                {
                    e.Eventstatus = "Cancel";
                    e.Cancelreason = udate + " " + ereason;
                    return true;
                }
            }
            return false;
        }
        //Event Search(int eventcode);
        

    }
}