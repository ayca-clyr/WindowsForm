using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class StudentListForm : Form
    {
        public StudentListForm()
        {
            InitializeComponent();
        }

        private void StudentListForm_Load(object sender, EventArgs e)
        {
            


            gridStudents.DataSource = DummyData.StudentData;  // Gridi çağırdık.
           
            
            // Dışardan seti kapattığımız için değiştiremeyiz. Ama Add, Remove gibi metotlar çalışır. Bunun için ArrayList kullanabiliriz. Çünkü ArrayList'de Add, Remove metotları yok.
            // DummyData.StudentData.Add(new Student());

          //  DummyData.StudentData[0] = null;  // StudentData'nın set'i kapalı. Ama indis değerine eleman atıp, onu değiştirebiliriz.

        }

        internal void RefreshData()
        {
            gridStudents.DataSource = null;
            gridStudents.DataSource = DummyData.StudentData;
        }
    }
}
