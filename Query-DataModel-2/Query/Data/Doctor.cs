//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Query.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Doctor
    {
        public Doctor()
        {
            this.Appointments = new HashSet<Appointment>();
        }
    
        public int DoctorID { get; set; }
        public string DoctorFirstName { get; set; }
        public string DoctorLastName { get; set; }
        public int TittleID { get; set; }
        public int ClinicID { get; set; }
        public bool Deleted { get; set; }
    
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual Clinic Clinic { get; set; }
        public virtual Tittle Tittle { get; set; }
    }
}
