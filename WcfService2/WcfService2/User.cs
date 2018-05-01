using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService2
{
    public class User
    {
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        private string SecretQs;

        public string SecretQs1
        {
            get { return SecretQs; }
            set { SecretQs = value; }
        }
        private string answer;

        public string Answer
        {
            get { return answer; }
            set { answer = value; }
        }
        private string contactNo;

        public string ContactNo
        {
            get { return contactNo; }
            set { contactNo = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string area;

        public string Area
        {
            get { return area; }
            set { area = value; }
        }
        private string  date;

        public string  Date
        {
            get { return date; }
            set { date = value; }
        }
        private string usercode;

        public string Usercode
        {
            get { return usercode; }
            set { usercode = value; }
        }
        private string accountno;

        public string Accountno
        {
            get { return accountno; }
            set { accountno = value; }
        }
        private string accountname;

        public string Accountname
        {
            get { return accountname; }
            set { accountname = value; }
        }
        //void Resetassword(string pass);

    }
}