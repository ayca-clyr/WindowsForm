using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7__Abstraction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Car car;
        Truck truck;
        private void Form1_Load(object sender, EventArgs e)
        {
            Car car = new Car();
            car.Make = "Mercedes";
            car.Model = "A180";
            car.Engine = 1800;
            car.Color = Color.Blue;
            car.Start();
            car.Stop();

            Truck truck = new Truck();
            truck.Make = "MAN";
            truck.Model = "AS2000";
            truck.Engine = 8000;
            truck.Color = Color.Red;
            truck.LoadCapacity = 20000;
            truck.Start();
            truck.Stop();

            // bundan instance almamalıyız. Abstract olmalı soyut olmalı nesne üretilememeli
            // Bu sadece genel bi class
            //Vehicle vehicle = new Vehicle();
            //vehicle.Make = "Yamaha";
            //vehicle.Model = "MT25";
            //vehicle.Engine = 250;
            //vehicle.Color = Color.Blue;


        }

        private void btnCreateCar_Click(object sender, EventArgs e)
        {
            car = new Car();
            car.Make = "BMW";
            car.Model = "320i";
            car.Engine = 2000;
            car.Color = Color.Green;

            lblCarDetails.Text = string.Format("Marka: {0}\nModel: {1}\nMotor: {2}\nRenk: {3}\nismi: {4}",
                car.Make,
                car.Model,
                car.Engine,
                car.Color,
                car.ToString());

           // Car car2 = car;
            Vehicle vehicleCar = car;
            Vehicle vehicleTruck = truck;
            // böyle yazınca ismi değişir etkilenir.
            //vehicleCar.Make = "BMW";
            //string make = car.Make;

            vehicleTruck.Make = "Magirus";
            string make = truck.Make;
            //loadCapacity e ulaşabilmek için
            //((Truck)vehicleTruck).LoadCapacity; yazmalıyız. dene bi bunu
            //vehicleTruck.loadCapacity e ulaşamayız

            List<Vehicle> vehicleList = new List<Vehicle>();
            vehicleList.Add(car);
            vehicleList.Add(truck);

            for (int i = 0; i < vehicleList.Count; i++)
            {
                vehicleList[i].Horn();

                // Buna gerek kalmıyor

                //if (vehicleList[i] is Truck)
                //{
                //    MessageBox.Show("Doooott");
                //}
                //else if (vehicleList[i] is Car)
                //{
                //    MessageBox.Show("Düüt");
                //}

            }

        }

        private void btnCarStart_Click(object sender, EventArgs e)
        {

            try
            {
                lblCarSound.Text = car.Start();
            }
            catch (Exception)
            {

                MessageBox.Show("Araba Oluşturulmadı");
            }


        }

        private void btnCreateTruck_Click(object sender, EventArgs e)
        {
            truck = new Truck();
            truck.Make = "MAN";
            truck.Model = "As";
            truck.Engine = 10000;
            truck.Color = Color.Green;
            truck.LoadCapacity = 20000;

            lblTruckDetails.Text = string.Format("Marka: {0}\nModel: {1}\nMotor: {2}\nRenk: {3}\nKapasite: {4}\nİsmi: {5}",
                truck.Make,
                truck.Model,
                truck.Engine,
                truck.Color,
                truck.LoadCapacity,
                truck.ToString());
        }

        private void btnTruckStart_Click(object sender, EventArgs e)
        {
            try
            {
                lblSoundTruck.Text = truck.Start();
            }
            catch (Exception)
            {

                MessageBox.Show("Kamyon Oluşturulmadı");
            }
        }

        private void btnCarHorn_Click(object sender, EventArgs e)
        {
           
            try
            {
                lblCarHorn.Text = car.Horn();
            }
            catch (Exception)
            {

                MessageBox.Show("Araba Oluşturulmadı");
            }
        }

        private void btnTruckHorn_Click(object sender, EventArgs e)
        {
            try
            {
                lblTruckHorn.Text = truck.Horn();
            }
            catch (Exception)
            {

                MessageBox.Show("Kamyon Oluşturulmadı");
            }
            
        }

    }
}
