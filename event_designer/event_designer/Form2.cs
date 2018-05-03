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
    public partial class fmlogin : Form
    {
        public fmlogin()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fmregistration f = new fmregistration();
            this.Hide();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            localhost.Service1 server = new localhost.Service1();
            bool isvaliduser;
            bool isvalidPassword;
            server.isvalid(textBox1.Text, textBox2.Text, out isvalidPassword, out isvaliduser);
            if (isvaliduser && isvalidPassword)
            {
                MessageBox.Show("valid user");

            }
            else
            {
                MessageBox.Show("Invalid user");
            }
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void linkmain_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fmmain fm = new fmmain();
            this.Hide();
            fm.Show();
        }
    }
}
