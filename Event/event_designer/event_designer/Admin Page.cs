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
    public partial class Admin_Page : Form
    {
        public Admin_Page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            localhost.Service1 service = new localhost.Service1();
            BindingSource source = new BindingSource();
            service.SearchAllUser();
            source.DataSource = service.SearchAllUser();
            dataGridView1.DataSource = source;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            localhost.Service1 service = new localhost.Service1();
            BindingSource b = new BindingSource();
            b.DataSource = service.SearchAll();
            dataGridView1.DataSource = b;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            localhost.Service1 service = new localhost.Service1();
            BindingSource b = new BindingSource();
            b.DataSource = service.SearchCancel();
            dataGridView1.DataSource = b;
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fmmain f = new fmmain();
            this.Hide();
            f.Show();
        }

        private void Admin_Page_Load(object sender, EventArgs e)
        {

        }

        private void btnevent_Click(object sender, EventArgs e)
        {
            localhost.Service1 ser = new localhost.Service1();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            localhost.Service1 ser = new localhost.Service1();
           // ser.DeleteUser(txtname.Text, txtcode.Text);
            BindingSource source = new BindingSource();
            ser.SearchAllUser();
            source.DataSource = ser.SearchAllUser();
            dataGridView1.DataSource = source;
        }
    }
}
