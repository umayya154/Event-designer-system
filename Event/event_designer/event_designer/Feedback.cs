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
    public partial class Feedback : Form
    {
        public Feedback()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fmmain f = new fmmain();
            this.Hide();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isname, isuser;
            localhost.Service1 ser = new localhost.Service1();
            ser.Search(textBox1.Text, textBox3.Text, out isname , out isuser);
            BindingSource b=new BindingSource();
            //dataGridView1.Rows[row].SetValues = textBox1.Text + "   " + textBox3.Text + DateTime.Now.ToLongDateString();
            b.DataSource = ser.SearchAll();
            dataGridView1.DataSource = b;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
          //  dataGridView1.Columns[0].Visible = false;
            //dataGridView1.Columns[0].Visible = false;
        }
      
        private void Feedback_Load(object sender, EventArgs e)
        {/*
            localhost.Service1 service = new localhost.Service1();
            BindingSource source = new BindingSource();
            source.DataSource = service.SearchAll();
            dataGridView1.DataSource = source;
            */
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
