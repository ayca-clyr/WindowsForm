using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KartDagitim
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (((string.IsNullOrWhiteSpace(txtOyuncu1.Text)) || (string.IsNullOrWhiteSpace(txtOyuncu2.Text)) || (string.IsNullOrWhiteSpace(txtOyuncu3.Text)) || string.IsNullOrWhiteSpace(txtOyuncu4.Text)))
            {
                MessageBox.Show("Boş Alan Bırakılamaz");
            }
            else {
                Form1 frm = new Form1();
                frm.koltuk1 = txtOyuncu1.Text;
                frm.koltuk2 = txtOyuncu2.Text;
                frm.koltuk3 = txtOyuncu3.Text;
                frm.koltuk4 = txtOyuncu4.Text;
                frm.Show();
                this.Hide();
            }
        }

        private void txtOyuncu1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOyuncu2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOyuncu4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOyuncu3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
