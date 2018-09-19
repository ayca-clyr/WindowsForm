using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2
{
    class Vehicle
    {

        public string Make {get; set;}
        public string Model { get; set; }

        private bool _status;

        public bool Status
        {
            get { return _status; }
            set { _status = value; }
        }

        private int _speed;

        private Driver _driver;  // Araca binen sürücünün özelliklerini tutacak.
        public int Spped
        {
            get { return _speed; }
          
        }

       

        private DateTime _dateOfBirth;

        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }
      

        public int Age
        {
            get{ return DateTime.Now.Year - _dateOfBirth.Year; }
        }


        private DLicensType _dLicensType;

        public DLicensType DlicensType
        {
            get { return _dLicensType; }
            
        }


        private VehicleType _vehicleType;

        public VehicleType VehicleType
        {
            get { return _vehicleType; }
          
        }


        public bool VehicleGet(Driver driver)
        {
            if ((driver.DLicensType == DLicensType.B1 && driver.VehicleType == VehicleType.car) || (driver.DLicensType == DLicensType.A && driver.VehicleType == VehicleType.motorcycle) || (driver.DLicensType == DLicensType.E && driver.VehicleType == VehicleType.truck))
            {
                _driver = driver;
                return true;
            }else
            return false;
        }
        public void VehicleOf()
        {
            if (!_status)
            {
                _driver = null;
            }
        }
        public bool Start()
        {
           if( _speed == 0 && _driver != null){
               _status = true;
            return true;
        }
           return false;
        }
        public bool Stop()
        {
            if (_speed == 0)
            {
                _status = false;
                return true;
            }
            else
                return false;
        }
        public void Faster()
        {
            while(_speed < 200 && _speed > 0)
            {
                _speed = _speed + 10;
            }
        }
        public void Slow()
        {
            while (_speed < 200 && _speed > 0)
            {
                _speed = _speed - 10;
            }
        }

      
    }
}
