using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService2
{
    public class Eventdl
    {
        public static List<Event> users = new List<Event>();
         List<Event> SearchAll ();
        void AddEvent(Event e);
        void Conform(bool var);
        void CancelEvent();
        Event Search(int eventcode);
        

    }
}