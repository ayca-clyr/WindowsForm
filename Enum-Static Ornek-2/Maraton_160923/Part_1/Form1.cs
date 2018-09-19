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
    public partial class Form1 : Form
    {
        Student student;
        EducationHistory education;
        WorkHistory work;
        Trainer trainer;
        List<Student> listStudent = new List<Student>();
        List<WorkHistory> listIs = new List<WorkHistory>();
        List<Trainer> listTrainer = new List<Trainer>();
        List<EducationHistory> listEgitim = new List<EducationHistory>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Student sınıfı için kontrol
            //            student = new Student();
            //            student.FirstName = "Ayça";
            //            student.LastName = "Calayır";


            //            education = new EducationHistory();
            //            education.SchoolName = "Gelişim";
            //            education.SchoolEndDate = DateTime.Parse("08/01/1994");
            //            education.SchoolBranch = SchoolBranch.Numerical;
            //            student.Education.Add(education);



            //            education = new EducationHistory();
            //            education.SchoolName = "Aydın";
            //            education.SchoolEndDate = DateTime.Parse("08/01/2000");
            //            education.SchoolBranch = SchoolBranch.Verbal;
            //            student.Education.Add(education);


            //            education = new EducationHistory();
            //            education.SchoolName = "Yıldız Teknik";
            //            education.SchoolEndDate = DateTime.Parse("08/01/1996");
            //            education.SchoolBranch = SchoolBranch.Numerical;
            //            student.Education.Add(education);

            //            MessageBox.Show("Son Okuduğu Okul : "+student.LastSchool().ToString());


            #endregion
            #region Trainer sınıfı için kontrol

            //            trainer = new Trainer();
            //            trainer.FirstName = "Fidan";
            //            trainer.LastName = "Kartal";


            //            work = new WorkHistory();
            //            work.WorkEndDate = DateTime.Parse("08/06/2013");
            //            work.WorkName = "Chrome Adam";
            //            trainer.Work.Add(work);

            //            work = new WorkHistory();
            //            work.WorkName = "Google";
            //            work.WorkEndDate = DateTime.Parse("20/08/2011");
            //            trainer.Work.Add(work);

            //            work = new WorkHistory();
            //            work.WorkName = "Bilge Adam";
            //            work.WorkEndDate = null;
            //            trainer.Work.Add(work);

            //            MessageBox.Show("Şuan'da çalışmakta olduğu İş : " +trainer.Professional().ToString());

            #endregion
        }

       

        private void öğrenciEkleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm(listStudent,listIs,listEgitim);
            studentForm.MdiParent = this;
            studentForm.Show();
        }

        private void eğitmenEkleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TrainerForm trainerForm = new TrainerForm(listTrainer,listIs,listEgitim);
            trainerForm.MdiParent = this;
            trainerForm.Show();
        }

        private void öğrenciListesiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StudentList studentList = new StudentList(listStudent,listIs,listEgitim);
            studentList.MdiParent = this;
            studentList.Show();
        }

        private void eğitmenListesiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TrainerList trainerList = new TrainerList(listTrainer,listIs,listEgitim);
            trainerList.MdiParent = this;
            trainerList.Show();
        }
    }
}
