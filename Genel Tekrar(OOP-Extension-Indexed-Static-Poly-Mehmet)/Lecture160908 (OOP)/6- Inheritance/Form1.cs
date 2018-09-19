using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6__Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Person person = new Person();

            person.FirstName = "Tsubasa";
            person.LastName = "Ozora";

            Trainee trainee = new Trainee();
            trainee.TraineeNumber = "G129010005";
            trainee.FirstName = "Mehmet";
            trainee.LastName = "Avcı";

            trainee.FirstName = person.FirstName;

        }
    }
}
