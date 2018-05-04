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
        }
        //void Conform(bool var);
        //void CancelEvent();
        //Event Search(int eventcode);
        

    }
}