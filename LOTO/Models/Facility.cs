using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LOTO.Models
{
    public class Facility
    {
        public int ID { get; set; }

        [Display(Name = "Facility Name")]
        public string FacilityName { get; set; }

        [Display(Name = "Location")]
        public string FacilityLocation { get; set; }
    }
}
