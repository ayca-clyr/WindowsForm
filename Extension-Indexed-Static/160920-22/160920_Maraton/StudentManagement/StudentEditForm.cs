using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VToolkit;

namespace StudentManagement
{
    public partial class StudentEditForm : Form
    {
        public StudentEditForm()
        {
            InitializeComponent();
        }

        private void StudentEditForm_Load(object sender, EventArgs e)
        {

            // Gender hem static hem instance davranıyor.
            // Gender.Female  Gender'în static kısmı.     Gender.Female.Name Gender'ın instance kısmı.
            //cBxGender.DataSource = Enum.GetValues(typeof(Gender));

            //cBxGender.Items.Add(Gender.Female);
            //cBxGender.Items.Add(Gender.Male);

            //Gender male = new Gender();
            //male.Name = "Erkek";
            //Gender female = new Gender();
            //female.Name ="Kadın";

            //cBxGender.Items.Add(male);
            //cBxGender.Items.Add(female);

            //cBxGender.DisplayMember = "Name";

            //Gender male = Gender.Male;
            //Gender female = Gender.Female;

            //cBxGender.Items.Add(Gender.Male);
            //cBxGender.Items.Add(Gender.Female);

            cBxGender.DataSource = Gender.AllValues;

            // İlk Eleman seçili gelmesin. 
            // cBxGender.SelectedItem = null;
            cBxGender.SelectedIndex = -1;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.FirstName = txtBxFirstName.Text.FullTrim();
            student.LastName = txtBxLastName.Text;
            student.Gender = (Gender)cBxGender.SelectedItem;
            student.StudentNumber = int.Parse(mTxtStudentNumber.Text);

            DummyData.StudentData.Add(student);

            foreach (Form childForm in this.MdiParent.MdiChildren)
            {
                if (childForm is StudentListForm)
                {
                    StudentListForm listForm = (StudentListForm)childForm;
                    listForm.RefreshData();
                }
            }
            Temizle();
        }
        private void Temizle()
        {
            txtBxFirstName.Text = null;
            txtBxLastName.Text = null;
            mTxtStudentNumber.Text = null;
            cBxGender.SelectedItem = null;
        }
        private void btnCansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
