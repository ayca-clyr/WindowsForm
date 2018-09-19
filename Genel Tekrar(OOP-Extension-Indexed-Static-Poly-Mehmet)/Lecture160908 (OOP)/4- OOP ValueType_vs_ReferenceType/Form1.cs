using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4__OOP_ValueType_vs_ReferenceType
{
    public partial class Form1 : Form
    {
        StudentClass studentByClass;
        StudentStruct studentByStruct;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateObjectByClass_Click(object sender, EventArgs e)
        {
            studentByClass = new StudentClass();

            studentByClass.FirstName = "Misaki";
            studentByClass.LastName = "Taro";
            studentByClass.DateOfBirth = DateTime.Parse("1.1.1980");
            studentByClass.StudentNumber = 8;

            lblStudentObjectOfClassCreate.Text = string.Format("FirstName: {0}\nLastName: {1}\nDateOfBirth: {2}\nStudentNumber: {3}", studentByClass.FirstName, studentByClass.LastName, studentByClass.DateOfBirth, studentByClass.StudentNumber);
        }

        private void btnCopyObjectOfClass_Click(object sender, EventArgs e)
        {
            StudentClass copiedStudent = studentByClass;
            copiedStudent.FirstName = "Tsubasa";
            copiedStudent.LastName = "Ozora";
            copiedStudent.DateOfBirth = DateTime.Parse("5.5.1985");
            copiedStudent.StudentNumber = 10;

            lblFinalClass.Text = string.Format("FirstName: {0}\nLastName: {1}\nDateOfBirth: {2}\nStudentNumber: {3}", studentByClass.FirstName, studentByClass.LastName, studentByClass.DateOfBirth, studentByClass.StudentNumber);

            lblStudentObjectOfClassAfterCopy.Text = string.Format("FirstName: {0}\nLastName: {1}\nDateOfBirth: {2}\nStudentNumber: {3}", copiedStudent.FirstName, copiedStudent.LastName, copiedStudent.DateOfBirth, copiedStudent.StudentNumber);

        }

        private void btnCreateObjectByStruct_Click(object sender, EventArgs e)
        {
            studentByStruct = new StudentStruct();

            studentByStruct.FirstName = "Misaki";
            studentByStruct.LastName = "Taro";
            studentByStruct.DateOfBirth = DateTime.Parse("1.1.1980");
            studentByStruct.StudentNumber = 8;

            lblStudentObjectOfStruct.Text = string.Format("FirstName: {0}\nLastName: {1}\nDateOfBirth: {2}\nStudentNumber: {3}", studentByStruct.FirstName, studentByStruct.LastName, studentByStruct.DateOfBirth, studentByStruct.StudentNumber);
        }

        private void btnCopyObjectByStruct_Click(object sender, EventArgs e)
        {
            StudentStruct copiedStudent = studentByStruct;
            copiedStudent.FirstName = "Tsubasa";
            copiedStudent.LastName = "Ozora";
            copiedStudent.DateOfBirth = DateTime.Parse("5.5.1985");
            copiedStudent.StudentNumber = 10;

            lblStudentObjectOfStructAfterCopy.Text = string.Format("FirstName: {0}\nLastName: {1}\nDateOfBirth: {2}\nStudentNumber: {3}", copiedStudent.FirstName, copiedStudent.LastName, copiedStudent.DateOfBirth, copiedStudent.StudentNumber);



            lblFinalStruct.Text = string.Format("FirstName: {0}\nLastName: {1}\nDateOfBirth: {2}\nStudentNumber: {3}", studentByStruct.FirstName, studentByStruct.LastName, studentByStruct.DateOfBirth, studentByStruct.StudentNumber);


        }
    }
}
