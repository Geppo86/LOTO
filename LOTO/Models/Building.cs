using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LOTO.Models
{
    public class Building
    {
        public int ID { get; set; }

        [Display(Name = "Name/Number")]
        public string NameBuilding { get; set; }
        [Display(Name = "Map")]
        public string Map { get; set; }
        [Display(Name = "Coordinates")]
        public string Coordinates { get; set; }

        public int Task { get; set; }
    }
}
