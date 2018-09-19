using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_160928
{
    public partial class FormToplama : Form
    {
        public FormToplama()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int input1 = int.Parse(textBox1.Text);
            int input2 = int.Parse(textBox2.Text);
            int result = input1 + input2;
            textBox3.Text = result.ToString();
        }
    }
}
