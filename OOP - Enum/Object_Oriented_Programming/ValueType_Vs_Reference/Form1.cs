using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValueType_Vs_Reference
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Struct değer tiplidir.
        // Class reference tiplidir.

        StudentClass studentByClass;
        // StudentStruct studentByClass;
        
        private void btnCreateObjectByClass_Click(object sender, EventArgs e)
        {
            studentByClass = new StudentClass();
            studentByClass.FirstName = "Ayça";
            studentByClass.LastName = "Calayır";
            studentByClass.DateOfBirth = DateTime.Parse("15.10.1992");
            studentByClass.StudentNumber = 23;
            lblStudentObjectOfClass.Text = string.Format("FirstName: {0}\nLastName: {1}\nDateOfBirth: {2}\nStudentNumber: {3}", studentByClass.FirstName, studentByClass.LastName, studentByClass.DateOfBirth.ToShortDateString(), studentByClass.StudentNumber); // Stringe cast ediyor. En doğru yol.


            //studentByClass = new StudentStruct();
            //studentByClass.FirstName = "Ayça";
            //studentByClass.LastName = "Calayır";
            //studentByClass.DateOfBirth = DateTime.Parse("15.10.1992");
            //studentByClass.StudentNumber = 23;
            //lblStudentObjectOfClass.Text = string.Format("FirstName: {0}\nLastName: {1}\nDateOfBirth: {2}\nStudentNumber: {3}", studentByClass.FirstName, studentByClass.LastName, studentByClass.DateOfBirth.ToShortDateString(), studentByClass.StudentNumber); // Stringe cast ediyor. En doğru yol.
        }
      
        private void btnCopyObjectOfClass_Click(object sender, EventArgs e)
        {

            // Class'da son haline baktığımızda değerlerin en son attığımız değerler olduğunu gördük.

            StudentClass copiedStudent = studentByClass;
            copiedStudent.FirstName = "Tsubasa";
            copiedStudent.LastName = "Ozora";
            copiedStudent.DateOfBirth = DateTime.Parse("5.5.1985");
            copiedStudent.StudentNumber = 10;

            lblFinal.Text = string.Format("FirstName: {0}\nLastName: {1}\nDateOfBirth: {2}\nStudentNumber: {3}", studentByClass.FirstName, studentByClass.LastName, studentByClass.DateOfBirth.ToShortDateString(), studentByClass.StudentNumber);

            lblStudentObjectOfClassAfterCopy.Text = string.Format("FirstName: {0}\nLastName: {1}\nDateOfBirth: {2}\nStudentNumber: {3}", copiedStudent.FirstName, copiedStudent.LastName, copiedStudent.DateOfBirth.ToShortDateString(), copiedStudent.StudentNumber);



            // Struct'da son haline baktığımızda değerler değişmiş mi ona baktık.
            // Struct'da sadece copyasını değiştirdik.
            
            //StudentStruct copiedStudent = studentByClass;
            //copiedStudent.FirstName = "Tsubasa";
            //copiedStudent.LastName = "Ozora";
            //copiedStudent.DateOfBirth = DateTime.Parse("5.5.1985");
            //copiedStudent.StudentNumber = 10;

            //lblFinal.Text = string.Format("FirstName: {0}\nLastName: {1}\nDateOfBirth: {2}\nStudentNumber: {3}", studentByClass.FirstName, studentByClass.LastName, studentByClass.DateOfBirth.ToShortDateString(), studentByClass.StudentNumber);

            //lblStudentObjectOfClassAfterCopy.Text = string.Format("FirstName: {0}\nLastName: {1}\nDateOfBirth: {2}\nStudentNumber: {3}", copiedStudent.FirstName, copiedStudent.LastName, copiedStudent.DateOfBirth.ToShortDateString(), copiedStudent.StudentNumber);

           

        }
    }
}
