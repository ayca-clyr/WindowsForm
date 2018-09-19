using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_MultipleForms
{
    public partial class StudentForm : Form
    {
        public string FirstName = string.Empty;
        public string LastName = "";
        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtBxAd.Text.Length > 0 && txtBxSoyad.Text.Length > 0)
            {
                FirstName = txtBxAd.Text;
                LastName = txtBxSoyad.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Boş alan bırakılamaz.");
            }
        }
    }
}
