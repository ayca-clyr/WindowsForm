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
    
    public partial class Clinic
    {
        public Clinic()
        {
            this.Doctors = new HashSet<Doctor>();
            this.Hospitals = new HashSet<Hospital>();
        }
    
        public int ClinicID { get; set; }
        public string ClinicBranch { get; set; }
        public int TimeRange { get; set; }
        public System.DateTime StartTime { get; set; }
        public System.DateTime EndTime { get; set; }
    
        public virtual ICollection<Doctor> Doctors { get; set; }
        public virtual ICollection<Hospital> Hospitals { get; set; }
    }
}
