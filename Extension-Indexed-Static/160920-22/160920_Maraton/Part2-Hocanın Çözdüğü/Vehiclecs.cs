using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2_Hocanın_Çözdüğü
{
    class Vehicle
    {
        public Vehicle(VehicleType type)  // Parameteresiz ctor olmamalı. MUTLAKA dediği satır için yapıyoruz Arkada Parantez içine birşey yazmamız için bunu yaptık. Yoksa hata veriyor
        {
            _type = type;
            //_status = VehicleStatus.Stopped;   Farketmez yazsanda yazmasanda
        }
        public string Make { get; set; }
        public string Model { get; set; }

        private VehicleType _type;
        public VehicleType Type
        {
            get { return _type; }
        }

        private VehicleStatus _status;

        public VehicleStatus Status
        {
            get { return _status; }
        }

        private int _speed;
        public int Speed
        {
            get { return _speed; }
        }

        private Driver _driver;
        public Driver Driver
        {
            get { return _driver; }
        }


        public void GetIn(Driver driver)
        {
            if (Driver == null)
            {
                if ((driver.License == LicenseType.A && Type == VehicleType.Motocycle) || (driver.License == LicenseType.B && Type == VehicleType.Car) || (driver.License == LicenseType.C && Type == VehicleType.Truck))
                {
                    _driver = driver;
                }
            }

        }

        public void GetOff()
        {
            if (Status == VehicleStatus.Stopped)
            {
                _driver = null;
            }
        }
        public void Start()
        {
            if (Driver != null)
                _status = VehicleStatus.Started;
        }
        public void Stop()
        {
            if (Speed == 0)
                _status = VehicleStatus.Stopped;
        }
        public void Accelerate()
        {
            if (Status == VehicleStatus.Started)
            {
                if (_speed < 200)
                {
                    _speed += 10;
                }
            }
        }
        public void Brake()
        {
            if (_speed > 0)
                _speed -= 10;
        }

         public override string ToString()
        {
            return string.Format("{0}, {1} / {2}", Make, Model, Type);
        }


    }
}
