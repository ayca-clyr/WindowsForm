using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstraction
{
    // C#
    // Türetilmiş (miras alan sınıf ) : derived
    // Türetilen (miras veren) : base
    //Java
    // Türetilmiş (miras alan sınıf) : derived
    // Türetilen (miras veren ) : super

    // Boxing object'e atamaktır.
    // Unboxing object'ten döndürmek.
    // Vehicle'den car yada truck'a dönüştürürken cast yapmamız lazım.
    // Car yada truck'dan vehicle döndürürken cast etmemize gerek yok.
    public partial class Form1 : Form
    {
        Car car;
        Truck truck;
        public Form1()
        {
            InitializeComponent();
        }

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

            /* Abstract (Soyutlama) olunca instance alamıyoruz.
            Vehicle vehicle = new Vehicle();  // Belli değil neye ait olduğu.
            vehicle.Make = "Yamaha";  // Motor     // Pagani(Araba)
            vehicle.Model = "MT25";   // Motor     // Zonda(Araba)
            vehicle.Engine = 250;
            vehicle.Color = Color.Blue;
            */
        }

        private void btnCreateCar_Click(object sender, EventArgs e)
        {
            car = new Car();
            car.Make = "BMW";
            car.Model = "320i";
            car.Engine = 2000;
            car.Color = Color.Green;

            lblCarDetails.Text = string.Format("Marka:{0}\nModel: {1}\nMotor: {2}\nRenk: {3}\nİsmi: {4}", car.Make, car.Model, car.Engine, car.Color, car.ToString());

        }

        private void btnStartCar_Click(object sender, EventArgs e)
        {
            lblCarSound.Text = car.Start();
        }

        private void btnCreateTruct_Click(object sender, EventArgs e)
        {
            truck = new Truck();
            truck.Make = "BMC";
            truck.Model = "Fatih";
            truck.Engine = 10000;
            truck.Color = Color.Red;
            truck.LoadCapacity = 15000;

            lblTructDetails.Text = string.Format("Marka: {0}\nModel: {1}\nMotor: {2}\nRenk: {3}\nKapasite {4}\nİsmi: {5}", truck.Make, truck.Model, truck.Engine, truck.Color, truck.LoadCapacity, truck.ToString());

            //int number = 10;
            //object numberAsObject = number;
            //int numberUnboxed = (int)numberAsObject;

            //object name = "Tsubasa";
            //string name2 = (string)name;

            //Button btn = new Button();
            //TextBox txt = new TextBox();

            //Control btnControl = btn;
            //Control txtControl = txt;

            //Controls.Add(btnControl);
            //Controls.Add(txtControl);

            //if (Controls[0] is TextBox)
            //{
            //}

            Vehicle vehicleCar = car;
            Vehicle vehicleTruck = truck;
            vehicleTruck.Make = "Magirus";  // Çıktı bu olur.

            List<Vehicle> vehicleList = new List<Vehicle>();
            vehicleList.Add(car);
            vehicleList.Add(truck);

            for (int i = 0; i < vehicleList.Count; i++)  // i. Eleman car ise car'ın kornası, truck ise truck'ın kornası çalacak.
            {
                vehicleList[i].Horn();
                // Aşağıdakileri yazmak yerine üsttekini yazmak yetti.Buda polymorphism'dir.
                //if (vehicleList[i] is Truck)
                //{
                //    MessageBox.Show("Dattirdattrii");
                //}
                //else if (vehicleList[i] is Car)
                //{
                //    MessageBox.Show("Düüüüt");
                //}
            }


            // Aşağıdakiler tek tek yazmaktansa üsttekini yazarız.
            //List<Car> carList = new List<Car>();
            //carList.Add(car);

            //List<Truck> truckList = new List<Truck>();
            //truckList.Add(truck);





            //Truck truck2 = (Truck)vehicleTruck;
            //Car car1 = (Car)vehicleCar;

            //string make = truck.Make;

            //vehicleCar.Make = "BMW";
            //string make2 = vehicleCar.Make;

            //object objectCar = vehicleCar;

            //Car car3 = new Car();
            //car3.Make = truck.Make;

            //DateTime date = DateTime.Now;
            //object dateAs = date;
            //string dateAsString = (string)dateAs;
            // date.  // Çok Özellike geliyor.
            // dateAs. // Az özellik geliyor.

            //Car c = new Car();
            //c =(Car)vehicleCar;
           
            
        }

        private void btnStartTruct_Click(object sender, EventArgs e)
        {
            lblTructSound.Text = truck.Start();
        }

        private void btnCarHorn_Click(object sender, EventArgs e)
        {
            lblCarHorn.Text = car.Horn();
        }

        private void btnTructHorn_Click(object sender, EventArgs e)
        {
            lblTructHorn.Text = truck.Horn();
        }
    }
}
