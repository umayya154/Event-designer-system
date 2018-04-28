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
            localhost.Service1 ser = new localhost.Service1();
            string name = txtname.Text;
            string passwd = txtpassword.Text;
            string email = txtemail.Text;
            string cont = txtcontact.Text;
            string ques = cmbquestion.Text;
            string ans = txtanswer.Text;
            string area = txtarea.Text;
            string acname = txtaccountname.Text;
            string acno = txtaccountno.Text;
            Random r = new Random();
            int code = r.Next(200, 999);
            txtcode.Text = (code).ToString();
            txtdate.Text = DateTime.Now.ToLongDateString();
            ser.AddUser(name, passwd, email, cont, area, ques, ans, acname, acno, code, txtdate.Text);
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
    }
}
