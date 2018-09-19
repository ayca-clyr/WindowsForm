using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance
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
            person.FirstName = "Ayça";
            person.LastName = "Calayır";
            person.DateOfBirth =DateTime.Parse("15.10.1992");
            Traniee traniee = new Traniee();
            traniee.TraneeNumber = "23";
            traniee.FirstName = "Hyuga";

            traniee.FirstName = person.FirstName;
            traniee.LastName = person.LastName;
            traniee.DateOfBirth = person.DateOfBirth;

        }
    }
}
