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

        [Display(Name = "Machine Serial Number")]
        public string MachineSerialName { get; set; }

        [Display(Name = "Machine OEM Name")]
        public string MachineOemName { get; set; }

        [Display(Name = "Machine Common Name")] //Added "Name" after "Common" to prevent confusion.
        public string MachineName { get; set; }

        [Display(Name = "Site")]              // Do lines 22-26 need to be here? Couldn't we reference them using data from Site/Building classes since all classes defined thus far are public?
        public string Site { get; set; }

        [Display(Name = "Building")]
        public string Building { get; set; }

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
