using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SeniorCare.Web.Models
{
    public class FacilityModel
    {
        public int ID { get; set; }

        [Display(Name = "Facility Name")]
        public string Name { get; set; }

        [Display(Name = "License #")]
        public string LicenseNumber { get; set; }

        [Display(Name = "Information")]
        public string Description { get; set; }

        [Display(Name = "Address")]
        public string AddressLine1 { get; set; }

        [Display(Name = "Address 2")]
        public string AddressLine2 { get; set; }

        [Display(Name = "City")]
        public string AddressCity { get; set; }

        [Display(Name = "State")]
        public string AddressState { get; set; }

        [Display(Name = "Zip")]
        public string AddressZip { get; set; }

        public byte[] Image { get; set; }
    }
}
