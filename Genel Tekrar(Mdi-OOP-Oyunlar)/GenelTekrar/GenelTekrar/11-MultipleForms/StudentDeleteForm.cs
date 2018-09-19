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
    public partial class StudentDeleteForm : Form
    {
        public StudentDeleteForm()
        {
            InitializeComponent();
        }
        public string FullName;
        public bool IsConfirmed = false;

        private void StudentDeleteForm_Load(object sender, EventArgs e)
        {
            lblİsimGöster.Text = FullName + " isimli kaydı silmek istediğinizden emin misiniz?";
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            IsConfirmed = true;
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }
    }
}
