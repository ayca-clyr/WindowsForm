using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1__OOP_INTRO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Student.Book studentBook = new Student.Book();

            Student student = new Student();

            student.FirstName = "Mehmet";
            student.LastName = "Avcı";

            StudentDataManager dataManager = new StudentDataManager();
            dataManager.Deletestudent(student);




        }
    }
}
