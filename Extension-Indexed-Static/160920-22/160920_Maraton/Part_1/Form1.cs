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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Temizle()
        {
            txtBxFirstName.Text = null;
            txtBxLastName.Text = null;
            dtpDateOfbirth.Value = DateTime.Now;


        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.FirstName = txtBxFirstName.Text;
            person.LastName = txtBxLastName.Text;
            person.DateOfBirth = dtpDateOfbirth.Value;

            lblDetails.Text = string.Format("Adı: {0}\nSoyadı: {1}\nDoğum Tarihi: {2}", person.FirstName, person.LastName, person.DateOfBirth.ToShortDateString());



            Temizle();
        }

        Person p = new Person();


        private void btnSleep_Click_1(object sender, EventArgs e)
        {


            p.Sleep();
            
                txtBxDurum.Text = "Uyuyor";
            
            
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
           
            if (p.Run() == true)
            {
                txtBxDurum.Text = "Koşabilir";
            }
            else
            {
                txtBxDurum.Text = "Koşamaz";
            }
        }

        private void btnWalk_Click(object sender, EventArgs e)
        {
          
            if (p.Walk() == true)
            {
                txtBxDurum.Text = "Yürüyebilir";
            }
            else
            {
                txtBxDurum.Text = "Yürüyemez";
            }
        }

        private void btnWakeUp_Click(object sender, EventArgs e)
        {
            p.WakeUp();
                txtBxDurum.Text = "Uyanık";
        
            
        }
    }
}
