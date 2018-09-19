using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2__OOPMembers
{
    class Student
    {
        // simple Property
        // field'ı kapsüle ettik dışarıdan fielda değer atıyoruz ama dışardan ulaşamıyoruz.
        private DateTime _dateOfBirth;
        public DateTime DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }
            set
            {
                _dateOfBirth = value;
            }

        }

        private string _firstName = "Mehmet";

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }


        //Full Property

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = FixValue(value); }

        }


        private string FixValue(string value)
        {
            string trimmedValue = value.Trim();

            string fixedValue = "";

            for (int i = 0; i < trimmedValue.Length; i++)
            {
                if (i==0)
                {
                    fixedValue += char.ToUpper(trimmedValue[i]);
                }
                else
                {
                    fixedValue += char.ToLower(trimmedValue[i]);
                }
            }

            return fixedValue;

        }


    }
}
