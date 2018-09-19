using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2
{
    class Driver
    {
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private DLicensType _dLicensType;

        public DLicensType DLicensType
        {
            get { return _dLicensType; }
            set { _dLicensType = value; }

        }

        private VehicleType _vehicleType;

        public VehicleType VehicleType
        {
            get { return _vehicleType; }
            set { _vehicleType = value; }
        }



    }
}
