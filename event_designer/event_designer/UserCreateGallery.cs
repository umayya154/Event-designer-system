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
    public partial class UserCreateGallery : Form
    {
        public UserCreateGallery()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserGallery_Load(object sender, EventArgs e)
        {

        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            localhost.Service1 service = new localhost.Service1();
            string cata = comboBox1.Text;
            string code = txtcode.Text;
            Image img = pictureBox1.Image;
            //service.AddImg(cata, code, img);
            comboBox1.Text = "";
            pictureBox1.Image = event_designer.Properties.Resources.images;
            MessageBox.Show("saved");
            UserControl1 ctl = new UserControl1(comboBox1.Text, txtcode.Text, pictureBox1.Image);
            flowLayoutPanel1.Controls.Add(ctl);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pictureBox1.Image = Image.FromStream(openFileDialog1.OpenFile());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
