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
        private DateTime dateofevent;

        public DateTime Dateofevent
        {
            get { return dateofevent; }
            set { dateofevent = value; }
        }
        private int days;

        public int Days
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
        private int usercode;

        public int Usercode
        {
            get { return usercode; }
            set { usercode = value; }
        }
        private int eventcode;

        public int Eventcode
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
        private int payment;

        public int Payment
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