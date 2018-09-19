using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPMembers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Student student = new Student();
            student.FirstName = "Ahmet";  // Bu value dediğimiz kısımdır.İlk değeri Mehmet'ti ama sonradan değeri Ahmet oldu.

           
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
 
            Student ogrenci = new Student();
            // SET   Dışardan gelen değeri atadık.
            ogrenci.LastName = txtBxIlkHali.Text;
            // GET  Son halinide gösterdik.
            lblSonHali.Text = ogrenci.LastName;

           

        }
    }
}
