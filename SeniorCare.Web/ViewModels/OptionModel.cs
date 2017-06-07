using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SeniorCare.Web.Models
{
    public class OptionModel
    {
        public int ID { get; set; }

        [Display(Name = "Option Name")]
        public string Name { get; set; }

        public int FacilityOptionTypeID { get; set; }
    }
}