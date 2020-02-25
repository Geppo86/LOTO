using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LOTO.Models
{
    public class Machine
    {
        public int ID { get; set; }

        [Display(Name = "Machine OEM Name")]
        public string MachineOemName { get; set; }

        [Display(Name = "Machine Common")]
        public string MachineName { get; set; }

        [Display(Name = "Site")]
        public string Site { get; set; }

        [Display(Name = "Building")]
        public string Building { get; set; }

        [Display(Name = "Notes")]
        public string Notes { get; set; }

        [Display(Name = "Machine Map")]
        public string MachineMap { get; set; }

        public MachineZone Zone { get; set; }
    }

    public class MachineZone
    {
        public int Id { get; set;}
        public string Zone { get; set; }

        public string ZoneMapFile { get; set; }

        public string HatchingFile { get; set; }
    }
}
