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
    
    public partial class Hospital
    {
        public Hospital()
        {
            this.Clinics = new HashSet<Clinic>();
        }
    
        public int HospitalID { get; set; }
        public string HospitalName { get; set; }
        public int TownID { get; set; }
    
        public virtual Town Town { get; set; }
        public virtual ICollection<Clinic> Clinics { get; set; }
    }
}
