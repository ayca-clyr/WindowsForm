using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_2
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        Vehicle vehicle = new Vehicle();
        Driver driver = new Driver();
        private void btnDetails_Click(object sender, EventArgs e)
        {
            
            lblDetails.Text = string.Format("Adı : {0}\nSoyadı : {1}\nDoğum Tarihi : {2}\nAraç Tipi : {3}\nSürücü Belgesi Tipi :{4}", txtBxFirstName.Text, txtBxLastName.Text,dTPDateOfBirth.Value.ToShortDateString(),cBxDLicensType.SelectedItem,cBxVehicleType.SelectedItem);
            driver.FirstName = txtBxFirstName.Text;
            driver.LastName = txtBxLastName.Text;
            driver.DLicensType = (DLicensType)cBxDLicensType.SelectedItem;
            driver.VehicleType = (VehicleType)cBxVehicleType.SelectedItem;
            

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            vehicle.Start();
            MessageBox.Show("Arabaya Çalıştı.");
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            vehicle.Stop();
            MessageBox.Show("Araç Durdu.");
        }

        private void btnFaster_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cBxVehicleType.DataSource =Enum.GetValues(typeof(VehicleType));
            cBxDLicensType.DataSource = Enum.GetValues(typeof(DLicensType));
            
        }

        private void btnVehicleGet_Click(object sender, EventArgs e)
        {
            vehicle.VehicleGet(driver);
            if (vehicle.VehicleGet(driver) == true)
            {
                MessageBox.Show("Sürücü Araca Bindi");
            }
            else
            {
                MessageBox.Show("Sürücü Aracab Binmeye Uygun Değildir!");
            }
        }

        private void btnVehicleOf_Click(object sender, EventArgs e)
        {
            if (vehicle.Status != true)
            {
                MessageBox.Show("Sürücü Araçtan İndi");
            }
            else
            {
                MessageBox.Show("Sürücü Araçtan İnmedi");
            }
        }
    }
}
