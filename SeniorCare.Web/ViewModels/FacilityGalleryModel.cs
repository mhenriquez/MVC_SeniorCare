using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeniorCare.Web.Models
{
    public class FacilityGalleryModel
    {
        public int ID { get; set; }

        public int OrderID { get; set; }

        public byte[] Image { get; set; }

        public int FacilityID { get; set; }
    }
}