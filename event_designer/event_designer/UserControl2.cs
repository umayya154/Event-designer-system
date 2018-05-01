using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace event_designer
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }
        public UserControl2(string cata, string code, Image img)
        {
            InitializeComponent();
            pictureBox1.Image = img;
            textBox1.Text = code;
            textBox2.Text = cata;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
