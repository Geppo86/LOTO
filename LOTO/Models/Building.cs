using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LOTO.Models
{
    public class Building
    {
        public int BID { get; set; }

        [Display(Name = "Building Name/Number")]
        public string NameBuilding { get; set; }
        
        [Display(Name = "Map")]
        public string Map { get; set; }
        
       // public int Task { get; set; }
    }
}
