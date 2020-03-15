using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LOTO.Models
{
    public class MachineZone
    {
        public int MZID { get; set; }

        public Machine MID { get; set; } //Foreign Key
        
        [Display(Name = "Machine Zone")]
        public string MachineZone { get; set; }

        [Display(Name = "Zone Map File")]
        public string ZoneMapFile { get; set; }

        [Display(Name = "Machine Zone Description")]
        public string MachineZoneDescription { get; set; }

        /*We need this entry for the same color 
        //on the grid in case we have to machine zone linked */
        //public string LinkedMachineZone { get; set; }
        ///*Final Document to make and pass in a link*/
        //[Display(Name = "Document")]
        //public string Document { get; set; }
    }
}
