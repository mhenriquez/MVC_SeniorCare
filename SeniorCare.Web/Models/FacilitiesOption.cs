//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SeniorCare.Web.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FacilitiesOption
    {
        public int ID { get; set; }
        public int FacilityID { get; set; }
        public int FacilityOptionID { get; set; }
    
        public virtual Facility Facility { get; set; }
        public virtual FacilityOption FacilityOption { get; set; }
    }
}
