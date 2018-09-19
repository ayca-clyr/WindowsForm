using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
  public  class Student : Person
    {

      public override string ToString()
      {
          return FirstName + " " + LastName;
      }
        public EducationHistory LastSchool()
        {
           
            EducationHistory lastSchool = null;
                for (int i = 0; i < Education.Count; i++)
                {
                    for (int j = 0; j < Education.Count; j++)
                    {
                        if (Education[i].SchoolBranch == SchoolBranch.Numerical && Education[i].SchoolEndDate.Value > Education[j].SchoolEndDate.Value )
                        {
                            lastSchool = Education[j];
                            Education[j] = Education[i];
                            Education[i] = lastSchool;
                            
                       }
                    }
                }

                return lastSchool;
            }



    }
    
}
