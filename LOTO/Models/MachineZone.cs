using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LOTO.Models
{
    public class MachineZone
    {
        public int Id { get; set; }
        
        [Display(Name = "Machine Zone")]
        public string Zone { get; set; }

        [Display(Name = "Zone Map File")]
        public string ZoneMapFile { get; set; }

        [Display(Name = "Hatching File")]
        public string HatchingFile { get; set; }
    }
}
