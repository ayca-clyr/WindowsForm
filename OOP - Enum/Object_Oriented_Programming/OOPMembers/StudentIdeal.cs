using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMembers
{
    public class StudentIdeal
    {
        private string _firstName ;

        // Property (get; set;) aslında özelleştirilmiş bir methoddur.
        public string FirstName {
            get { return _firstName; }
            set { _firstName = value; }         
        }

        // Eğer bunları yazarsak dışardan tek tek çağırarak işlem yapabilir.
        public void SetFirstName(string value)
        {
            _firstName = value;

        }
        public string GetFirstName()
        {
            return _firstName;
        }

        // ReadOnly
        private DateTime _dateOfBirth;
        public int Age
        {
            get{
                return DateTime.Today.Year - _dateOfBirth.Year;
            }
        }
    }
}
