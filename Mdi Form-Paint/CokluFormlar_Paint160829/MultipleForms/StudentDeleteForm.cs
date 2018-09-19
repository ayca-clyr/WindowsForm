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
    public partial class StudentDeleteForm : Form
    {
        public StudentDeleteForm()
        {
            InitializeComponent();
        }
        public string _fullName = "";
        public bool IsConfirmed = false;

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;  //Eğer Onayla tuşuna basılırsa direk YES demiş oluyoruz.
            IsConfirmed = true;   // Bayrak yöntemi. İçerdeki sonucu dışarı taşıyoruz.
            this.Close();
        }

        private void StudentDeleteForm_Load(object sender, EventArgs e)
        {
            
            lblWarning.Text = _fullName + " isimli Kayıt Silinecek. Emin Misini?";
        }

    }
}
