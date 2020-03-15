using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LOTO.Models
{
    public class Machine
    {
        public int MID { get; set; }

        [Display(Name = "Machine Serial Number")]
        public string MachineSerialName { get; set; }

        [Display(Name = "Machine OEM Name")]
        public string MachineOemName { get; set; }

        [Display(Name = "Machine Common Name")] //Added "Name" after "Common" to prevent confusion.
        public string MachineName { get; set; }

        [Display(Name = "Building")]
        public Building BID { get; set; } //Foreign Key

        [Display(Name = "Machine Picture File")]
        public string MachinePictureFile { get; set; }

        [Display(Name =" Machine Name Plate")]  
        public string MachineNamePlate { get; set; }

        [Display(Name = "Customer Defined Area")]
        public string CustomerDefinedArea { get; set; }

        //[Display(Name = "Notes")]
        //public string Notes { get; set; }

        /*Machine map on a file to pload*/
        //[Display(Name = "Machine Map")]
        //public string MachineMap { get; set; }

    }

}
