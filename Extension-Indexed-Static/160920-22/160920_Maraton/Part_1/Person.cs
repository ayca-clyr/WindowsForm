using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    class Person
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

        private string _fullName;

        private string FullName
        {
            get { return _fullName; }
        }

        private DateTime _dateOfBirth;

        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }



        private int Age
        {
            get { return DateTime.Now.Year - _dateOfBirth.Year; }

        }

        public Gender gender { get; set; }
        public Jop jop { get; set; }
        private Status _status;

        public Status Status
        {
            get { return _status; }

        }


        public bool Walk()
        {
            if (_status != Status.Sleeping)
            {
                _status = Status.Walking;
                return true;
            }else
            {
                return false;
            
            }
        }
        public bool Run()
        {

            if (_status != Status.Sleeping)
            {
                _status = Status.Runnig;
                return true;
            }
            else
            {
                return false;

            }
        }

        public bool Sleep()
        {
           
                _status = Status.Sleeping;
                return true;
             
        }
        public bool WakeUp()
        {

            
                _status = Status.Idle;
                return true;
            
        }

       
        public Person()
        {
           
        }

        public Person(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
           

        }
        public Person(string firtName, string lastName, DateTime dateOfBirth)
        {
            _firstName = firtName;
            _lastName = lastName;
            _dateOfBirth = dateOfBirth;
           
        }
    }
}
