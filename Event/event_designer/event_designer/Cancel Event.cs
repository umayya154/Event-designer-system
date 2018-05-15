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
    public partial class Cancel_Event : Form
    {
        public Cancel_Event()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            bool isuname = true   , isucode =  true;
            localhost.Service1 ser = new localhost.Service1();
            //CancelEvent(string uname, string ucode, string udate, string ereason)
            // MessageBox.Show("conformed or not", MessageBoxButtons.OKCancel);
            DialogResult res = MessageBox.Show("Conformed...?", MessageBoxButtons.OKCancel.ToString());
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                ser.CancelEvent(txtuname.Text, txtucode.Text, txtedate.Text, txtereason.Text, out isuname, out isucode);
               // ser.Search(txtuname, txtucode, out isuname, out isucode);
                if (isucode && isuname)
                {
                    
                    MessageBox.Show(" Event is canceled");
                }
                else
                {
                    MessageBox.Show(" Your information is not right");
                }
            }
            else
            {
                MessageBox.Show("Event donot cencel");
            }

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 f = new Form4();//
            this.Hide();
            f.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            fmmain f = new fmmain();
            this.Hide();
            f.Show();
   
        }
    }
}
