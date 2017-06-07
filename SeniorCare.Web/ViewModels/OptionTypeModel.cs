using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SeniorCare.Web.Models
{
    public class OptionTypeModel
    {
        public int ID { get; set; }

        [Display(Name = "Type Name")]
        public string Type { get; set; }
    }
}