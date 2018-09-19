using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tez2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        Form1 frm1 = new Form1();
        Form5 frm5 = new Form5();
     

        private void button1_Click(object sender, EventArgs e)
        {
            if (rBtn1.Checked == true)
            {
                frm1.Show();
                this.Hide();
            }else if(rBtn2.Checked == true)
            {
                frm5.Show();
                this.Hide();
            }
        }
    }
}
