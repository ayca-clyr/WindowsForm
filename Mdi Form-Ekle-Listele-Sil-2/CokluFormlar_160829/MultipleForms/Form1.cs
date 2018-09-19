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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            StudentAddForm studentAddForm = new StudentAddForm();
            studentAddForm.Show();

            studentAddForm.FormClosing += studentAddForm_FormClosing;
        }

        void studentAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StudentAddForm studentForm = (StudentAddForm)sender;
            /* Tek kaynaktan kod gelmesini sağlar. StudentsAddForm'dan btnSaveStudent_Click'den gelenlerin tüm değerlerini sender'e atadık.
            */
            // StudentAddForm studentForm = new StudentAddForm();
            string firstName = studentForm._firstName;
            string lastName = studentForm._lastName;

            lstBxStudent.Items.Add(firstName + " " + lastName);
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            StudentDeleteForm studentDeleteForm = new StudentDeleteForm();

            // studentDeleteForm._fullName = lstBxStudent.SelectedItem.ToString();  
            studentDeleteForm._fullName = (string)lstBxStudent.SelectedItem;
            // Show aşağıda yazmamızın sebebi atama yapmadan gösterilmemesi gerekiyor.
            studentDeleteForm.Show();
            studentDeleteForm.FormClosing += studentDeleteForm_FormClosing;
        }

        void studentDeleteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StudentDeleteForm studentDeleteForm = (StudentDeleteForm)sender;

            if (studentDeleteForm.IsConfirmed)
            {
                lstBxStudent.Items.Remove(studentDeleteForm._fullName);
            }
        }

        private void btnDeteleteDialog_Click(object sender, EventArgs e)
        {
            StudentDeleteForm studentDeleteDialog = new StudentDeleteForm();

            studentDeleteDialog._fullName = (string)lstBxStudent.SelectedItem;

            DialogResult result = studentDeleteDialog.ShowDialog();

            if (result == DialogResult.Yes && lstBxStudent.SelectedIndex > -1)
            {
                lstBxStudent.Items.Remove(lstBxStudent.SelectedItem);
            }

        }
    }
}
