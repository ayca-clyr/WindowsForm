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
    
    public partial class StudentList : Form
    {
        List<EducationHistory> listEgitim = new List<EducationHistory>(); 
       List<WorkHistory> listIs = new List<WorkHistory>();
        List<Student> listStudent = new List<Student>();
        

        public StudentList(List<Student> gelenOgrenci,List<WorkHistory> isGecmisi, List<EducationHistory> egitimGecmisi)
        {
            InitializeComponent();
            listStudent = gelenOgrenci;
            listIs = isGecmisi;
            listEgitim = egitimGecmisi;
        }

        private void StudentList_Load(object sender, EventArgs e)
        {
            lstBxStudentList.DataSource = listStudent.ToString();
            
          
            
          
        }

        private void lstBxStudentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
