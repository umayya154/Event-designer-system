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
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            localhost.Service1 ser = new localhost.Service1();
            bool ispass, isuser;
            ser.Chngpass(textBox1.Text, textBox2.Text, cmbquestion.Text, txtanswer.Text, textBox3.Text, out isuser, out ispass);
            if (isuser && ispass)
            {
                MessageBox.Show("Your Password has changed");
            }
            else
            {
                MessageBox.Show("Wronge information");
            }
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fmmain t = new fmmain();
            this.Hide();
            t.Show();
        }
    }
}
