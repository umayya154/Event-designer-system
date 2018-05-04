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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void txtdayofevent_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            localhost.Service1 service = new localhost.Service1();
            string name = txtname2.Text;
            string dateofevent = txtbateofevent.Text;
            string days = txtdayofevent.Text;

            string usercode = txtcode2.Text;
            string eventcode = txtcode3.Text;
            string location = txtloct.Text;
            string guestquantity = txtgq.Text;
            string Payment = txtpaym.Text;
            MessageBox.Show("Event has been booked");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtname2.Text = "";
            txtbateofevent.Text = "";
            txtdayofevent.Text = "";
            comboBox1.Text = "";

            txtcode2.Text = "";
            txtcode3.Text = "";
            txtloct.Text = "";
            txtgq.Text = "";
            txtpaym.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form5 b = new Form5();
            this.Hide();
            b.Show();
        }
    }
}
