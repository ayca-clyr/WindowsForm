using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part2_Hocanın_Çözdüğü
{
    public partial class Form1 : Form
    {
        Vehicle _currentVehicle;
        Driver _currentDriver;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //cBxLicenseType.Items.Add(LicenseType.A);
            //cBxLicenseType.Items.Add(LicenseType.B);
            //cBxLicenseType.Items.Add(LicenseType.C);

            cBxLicenseType.DataSource = Enum.GetValues(typeof(LicenseType));
            cBxVehicleType.DataSource = Enum.GetValues(typeof(VehicleType));


        }

        private void btnSaveDriver_Click(object sender, EventArgs e)
        {
            Driver driver = new Driver();
            driver.FirstName = txtBxFirstName.Text;
            driver.LastName = txtBxLastName.Text;
            driver.License = (LicenseType)cBxLicenseType.SelectedItem;

            lstBxDrivers.Items.Add(driver);
            cBxDrivers.Items.Add(driver);
        }

        private void btnSaveVehicle_Click(object sender, EventArgs e)
        {
            VehicleType vehicleType = (VehicleType)cBxVehicleType.SelectedItem;
            Vehicle vehicle = new Vehicle(vehicleType);
            vehicle.Make = txtBxMake.Text;
            vehicle.Model = txtBxModel.Text;

            lstBxVehicle.Items.Add(vehicle);
            cBxVehicles.Items.Add(vehicle);
        }

        private void btnGetIn_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = (Vehicle)cBxVehicles.SelectedItem;
            Driver driver = (Driver)cBxDrivers.SelectedItem;

            vehicle.GetIn(driver);

            if (vehicle.Driver == driver)
            {
                lblDriver.Text = vehicle.Driver.ToString();
                lblVehicleStatus.Text = vehicle.Status.ToString();
                lblVehicleSpeed.Text = vehicle.Speed.ToString();

                _currentDriver = driver;
                _currentVehicle = vehicle;
            }

        }

        private void btnGetOff_Click(object sender, EventArgs e)
        {
            _currentVehicle.GetOff();

            if (_currentVehicle.Driver == null)
            {

                lblDriver.Text = string.Empty;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _currentVehicle.Start();

            lblVehicleStatus.Text = _currentVehicle.Status.ToString();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _currentVehicle.Stop();

            lblVehicleStatus.Text = _currentVehicle.Status.ToString();
        }

        private void btnAccelerate_Click(object sender, EventArgs e)
        {
            _currentVehicle.Accelerate();

            lblVehicleSpeed.Text = _currentVehicle.Speed.ToString();
        }

        private void btnBrake_Click(object sender, EventArgs e)
        {
            _currentVehicle.Brake();

            lblVehicleSpeed.Text = _currentVehicle.Speed.ToString();
        }
    }
}
