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
    public partial class Adminlogin : Form
    {
        public Adminlogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {/*
            localhost.Service1 server = new localhost.Service1();
            bool is_validuser;
            bool is_validPassword;
            bool is_validcode;
            server.is_validAdmin(txtadm.Text, txtdp.Text, txtdc.Text, out is_validPassword, out is_validuser, out is_validcode);
            if (is_validuser && is_validPassword && is_validcode)
            {
                MessageBox.Show("valid user");

            }
            else
            {
                MessageBox.Show("Invalid user");
            }
            txtadm.Text = "";
            txtdc.Text = "";
            string name = txtadm.Text;
            string password = txtdp.Text;
            string securitycode = txtdc.Text;*/
            Admin_Page a = new Admin_Page();
            this.Hide();
            a.Show();

           /* MessageBox.Show("Valid");
            string name = txtadm.Text;
            string password = txtdp.Text;
            string securitycode = txtdc.Text;

            MessageBox.Show("Valid");*/
        }

        private void Adminlogin_Load(object sender, EventArgs e)
        {

        }
    }
}
