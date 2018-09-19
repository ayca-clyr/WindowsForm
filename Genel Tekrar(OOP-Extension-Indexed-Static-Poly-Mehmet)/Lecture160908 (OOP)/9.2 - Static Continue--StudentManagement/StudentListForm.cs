using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9._2___Static_Continue__StudentManagement
{
    public partial class StudentListForm : Form
    {
        public StudentListForm()
        {
            InitializeComponent();
        }

        private void gridStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StudentListForm_Load(object sender, EventArgs e)
        {
            // Alınabilir list static değil
           // DummyData.StudentData = new List<Student>();

            // Yapılamaz DummyData statictir
           // DummyData.StudentData = new DummyData();

            gridStudents.DataSource = DummyData.StudentData;
        }

        internal void RefreshData()
        {
            gridStudents.DataSource = null;
            gridStudents.DataSource = DummyData.StudentData;
        }
    }
}
