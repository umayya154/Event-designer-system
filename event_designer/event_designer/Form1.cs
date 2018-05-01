using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace event_designer
{
    public partial class fmregistration : Form
    {
        public fmregistration()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            localhost.Service1 service = new localhost.Service1();
            string name = txtname.Text;
            string cont = txtcontact.Text;
            string email = txtemail.Text;
            string passwd = txtpassword.Text;
            string area = txtarea.Text;
            string acno = txtaccountno.Text;
            string acname = txtaccountname.Text;
            string ques = cmbquestion.Text;
            string ans = txtanswer.Text;
           
            Random r = new Random();
            int code = r.Next(200, 999);
            txtcode.Text = (code).ToString();
            txtdate.Text = DateTime.Now.ToLongDateString();
            //void AddUser(string uname, string upassword, string uemail, string ucontact, string uarea, string uques, string uans, string uacname, string uacno, int ucode, string udata)
           service.AddUser(name, passwd, email, cont, area, ques, ans, acname, acno, txtcode.Text, txtdate.Text);
            txtpassword.Text = "";
            MessageBox.Show("user has been registred");
            txtcode.Text = "";
        }

        private void linklogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fmlogin fm = new fmlogin();
            this.Hide();
            fm.Show();
        }

        private void linkmainpg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fmmain m = new fmmain();
            this.Hide();
            m.Show();
        }

        private void fmregistration_Load(object sender, EventArgs e)
        {

        }

        private void txtcode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
