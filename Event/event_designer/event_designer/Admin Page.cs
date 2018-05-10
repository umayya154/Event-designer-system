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
    }
}
