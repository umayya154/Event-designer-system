using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService2
{
    public class Event
    {
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        private string dateofevent;

        public string Dateofevent
        {
            get { return dateofevent; }
            set { dateofevent = value; }
        }
        private string days;

        public string Days
        {
            get { return days; }
            set { days = value; }
        }
        private string eventstatus;

        public string Eventstatus
        {
            get { return eventstatus; }
            set { eventstatus = value; }
        }
        private string usercode;

        public string Usercode
        {
            get { return usercode; }
            set { usercode = value; }
        }
        private string eventcode;

        public string Eventcode
        {
            get { return eventcode; }
            set { eventcode = value; }
        }
        private string location;

        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        private string guestquantity;

        public string Guestquantity
        {
            get { return guestquantity; }
            set { guestquantity = value; }
        }
        private string cancelreason;

        public string Cancelreason
        {
            get { return cancelreason; }
            set { cancelreason = value; }
        }
        private string payment;

        public string Payment
        {
            get { return payment; }
            set { payment = value; }
        }
        private string feedback;

        public string Feedback
        {
            get { return feedback; }
            set { feedback = value; }
        }
    
    }
}