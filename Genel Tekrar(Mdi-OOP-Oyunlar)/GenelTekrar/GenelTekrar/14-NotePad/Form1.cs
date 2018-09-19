using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_NotePad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader okuyucu = new StreamReader("Metin.txt");
                rtxtBx.Text = okuyucu.ReadLine();
                okuyucu.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(string.Format("Bir hata oluştu. Detay: {0}",ex.Message));
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            StreamWriter yazici = new StreamWriter("Metin.txt", false);
            yazici.WriteLine(rtxtBx.Text);
            MessageBox.Show("Yazdığın yazıyı kaydettim");

            yazici.Close();
            rtxtBx.Clear();
        }
    }
}
