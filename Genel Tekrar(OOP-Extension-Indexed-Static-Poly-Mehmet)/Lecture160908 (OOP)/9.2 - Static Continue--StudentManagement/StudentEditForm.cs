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

namespace _9._2___Static_Continue__StudentManagement
{
    public partial class StudentEditForm : Form
    {
        public StudentEditForm()
        {
            InitializeComponent();
        }

        private void StudentEditForm_Load(object sender, EventArgs e)
        {
            // Böyle tek tek de ekleyebilirsin
            //cmbGender.Items.Add(Gender.Female);

             //cmbGender.DataSource = Enum.GetValues(typeof(Gender));

            // Bu şekilde olmasının sebebi Name i sonda gözükmesinin sebebi name instance aldığında gösterilsin dedik staticler biz instance almadan kendi instance aldığı için name i sonradan görüyoruz. Bu yüzden Gender.Name gelmez;
            //Gender.Male.Name;


            // Bu şekilde yapmamamız lazım 2 tane özelliğimiz var 3. olmaması lazım; bu yüzden constructor private yaparsak erişemeyiz.
            //Gender asd = new Gender();
            //Static yapılmasının sebebi bir sınıftan bir tane instance alınsın diyedir.
                         
            /*İnstance alındı ama Gender için instance alındı Male için instance alınmadı alındığı yeri görmek için Gender sınıfının static ctor una bak*/ 
            //instance alındığı için Name geldi
          // Gender male = Gender.Male.Name;
            //male.Name de gelir çünkü instance alındı

            //1. Yöntem
             //Gender male = Gender.Male;
             //Gender female = Gender.Female;

             //cmbGender.Items.Add(male);
             //cmbGender.Items.Add(female);

            //2. Yöntem
            // Böyle de yapılabilir
            // cmbGender.Items.Add(Gender.Male);
            // cmbGender.Items.Add(Gender.Female);


            //Override yapmadan bunu yapsak da olurdu
            //cmbGender.DisplayMember = "Name";

            //3. Yöntem 
            // dizi yaptık onu gönderdik
            cmbGender.DataSource = Gender.AllValues;
            cmbGender.SelectedIndex = -1; // DataSource yapınca ilk eleman seçili geliyor ilk elemanın seçili gelmememesi için -1 yaptık
            // veya
            // cmbGender.SelectedItem = null;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            // FullTrim i Vtoolkit i yazıp using e ekledik ve referenceslarda ekledik
            student.FirstName = txtFirstName.Text.FullTrim();
            student.LastName = txtLastName.Text;
            student.Gender = (Gender) cmbGender.SelectedItem;
            student.StudentNumber = int.Parse(txtStudentNumber.Text);

            DummyData.StudentData.Add(student);

            foreach (Form childForm in this.MdiParent.MdiChildren)
            {
                if (childForm is StudentListForm)
                {
                    StudentListForm listForm = ((StudentListForm)childForm);
                    listForm.RefreshData();
                }
            }

            Clear();
        }

        private void Clear()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
                else if (item is MaskedTextBox)
                {
                    item.Text = string.Empty;
                }
                else if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedItem = null;
                }
            }

            MessageBox.Show(Controls[0].GetType().ToString());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
