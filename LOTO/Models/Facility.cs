using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LOTO.Models
{
    public class Facility
    {
        [Key]
        public int FID { get; set; }

        public Site SID { get; set; }

        [Display(Name = "Facility Name")]
        public string FacilityName { get; set; }

        

    }
}
