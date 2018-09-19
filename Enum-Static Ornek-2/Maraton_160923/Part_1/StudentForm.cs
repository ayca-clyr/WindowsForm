using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_1
{
    public partial class StudentForm : Form
    {
        public StudentForm(List<Student> gelenOgreni, List<WorkHistory> isGecmisi,List<EducationHistory> egitimGecmisi)
        {
            InitializeComponent();
            listStudent = gelenOgreni;
            listIs = isGecmisi;
            listEgitim = egitimGecmisi;
        }

        List<Student> listStudent = new List<Student>();
        List<WorkHistory> listIs = new List<WorkHistory>();
        List<EducationHistory> listEgitim = new List<EducationHistory>();

        private void btnStudensSave_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.FirstName = txtBxStudentFirstName.Text;
            student.LastName = txtBxStudentLastName.Text;
            student.Gender = (Gender)cBxStudentGender.SelectedItem;
            student.DateOfBirth = dTPStudentDateOfBirth.Value;           
            listStudent.Add(student);

            WorkHistory work = new WorkHistory();
            work.WorkName = txtBxStudentWorkName.Text;            
            work.WorkEndDate = dTPStudentWorkEndDate.Value;
            listIs.Add(work);

            EducationHistory edution = new EducationHistory();
            edution.SchoolName = txtBxStudentSchoolName.Text;
            edution.SchoolBranch =(SchoolBranch)cBxStudentSchoolBranch.SelectedItem;           
            edution.SchoolEndDate = dTPStudentWorkEndDate.Value;
            listEgitim.Add(edution);
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            cBxStudentGender.DataSource = Enum.GetValues(typeof(Gender));
            cBxStudentSchoolBranch.DataSource = Enum.GetValues(typeof(SchoolBranch));
            
        }

        private void lstBxÖğrenciOkulBilgileri_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
