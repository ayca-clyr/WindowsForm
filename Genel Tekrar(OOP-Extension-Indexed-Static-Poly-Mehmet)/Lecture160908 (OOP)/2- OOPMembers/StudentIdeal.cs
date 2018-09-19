using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2__OOPMembers
{
    class StudentIdeal
    {

        private string _firstName;

        public string FirstName
        {
            //Burayla
            get { return _firstName; }
            set { _firstName = value; }
        }

        //property özelleştirilmiş methodtur

        //Burası aynıdır.
        public void SetFirstName(string value)
        {
            _firstName = value;
        }

        public string GetFirstName()
        {
            return _firstName;
        }

        /************************************************/
        private DateTime _dateOfBirth;

        // ReadOnly
        public int Age
        {
            get
            {
                return DateTime.Today.Year - _dateOfBirth.Year;
            }
        }

    }
}
