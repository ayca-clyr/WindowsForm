using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleForms
{
    public partial class StudentAddForm : Form
    {
        public string _firstName = "";   // Alt çizgi bize değişkenin global olduğunu gösterir.
        public string _lastName = string.Empty;
        public StudentAddForm()
        {
            InitializeComponent();
        }

        private void btnSaveStudent_Click(object sender, EventArgs e)
        {
            if (txtBxFirstName.Text != "" &&  txtBxLastName.Text != "" ) { 

           _firstName = txtBxFirstName.Text;
           _lastName = txtBxLastName.Text;

           this.Close();   // Kaydet butonundan sonra bu ekranı kapatmaya yarıyor.
            }
            else
            {
                MessageBox.Show("Lütfen Boş Bırakmayınız!");
            }

     
        }
    }
}
