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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYeniEkle_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            studentForm.Show();
            studentForm.FormClosing+=studentForm_FormClosing;
        }

        private void studentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StudentForm studentForm = (StudentForm)sender;
            string firstName = studentForm.FirstName;
            string lastName = studentForm.LastName;
            lstKayıt.Items.Add(firstName + " " + lastName);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstKayıt.SelectedIndex >= 0)
            {
                StudentDeleteForm studentDeleteForm = new StudentDeleteForm();
                studentDeleteForm.FullName = (string)lstKayıt.SelectedItem;
                studentDeleteForm.Show();
                studentDeleteForm.FormClosing+=studentDeleteForm_FormClosing;
            }
            else
            {
                MessageBox.Show("Silmek için bir satır seçin");
            }
        }

        void studentDeleteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StudentDeleteForm studentDeleteForm = (StudentDeleteForm)sender;
            if (studentDeleteForm.IsConfirmed)
            {
                lstKayıt.Items.Remove(studentDeleteForm.FullName);
            }
        }

        private void btnSilDialog_Click(object sender, EventArgs e)
        {
            StudentDeleteForm studentDeleteForm = new StudentDeleteForm();
            studentDeleteForm.FullName = (string)lstKayıt.SelectedItem;
            DialogResult result = studentDeleteForm.ShowDialog();
            if (result == DialogResult.Yes && lstKayıt.SelectedIndex > -1)
            {
                lstKayıt.Items.RemoveAt(lstKayıt.SelectedIndex);
            }
        }
    }
}
