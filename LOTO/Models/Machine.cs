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

        /*Machine map on a file to pload*/
        [Display(Name = "Machine Map")]
        public string MachineMap { get; set; }

        ///*Machine Plate on a file to upload*/
        //[Display(Name =" Machine Plate")]
        //public string Plate { get; set; }

        //public MachineZone Zone { get; set; }
    }

}
