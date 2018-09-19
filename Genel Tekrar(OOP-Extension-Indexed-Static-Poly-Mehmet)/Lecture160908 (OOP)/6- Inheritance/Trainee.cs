using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6__Inheritance
{
    class Trainee : Person
    {
        private string _traineeNumber;

        public string TraineeNumber
        {
            get
            {
                return _traineeNumber;
            }
            set
            {
                _traineeNumber = value;
            }
        }

    }
}
