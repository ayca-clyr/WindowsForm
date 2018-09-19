using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20_OOP_Encapsulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Ogrenci o = new Ogrenci();
            try
            {
                o.TCKN = "123123123";
                o.Soyadi = "Yask";

                MessageBox.Show(o.Soyadi);
                o.Adi = textBox1.Text;
                o.DogumTarihi = dateTimePicker1.Value;
                //o.Adi = "Alper";Direk değer atabilirim. Bu durum encapsulation'dur.
                MessageBox.Show(o.Adi);
                MessageBox.Show(o.Yas.ToString());
                //o.Yas = 23;İçinde değer tutmadığı yani Set özelliği olmadığı için hata verir. Read only yani sadece değeri okuyarak işlem yapar.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
