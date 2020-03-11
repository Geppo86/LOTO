using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LOTO.Models
{
    public class Task
    {
        public MachineZone Zone { get; set; } // Is this meant to be a foriegn key? It doesn't seem to match the color format that I saw before. 
        public int ID { get; set; }
        [Display(Name="Task Name")]
        public string TaskName { get; set; }
        //public Procedure Procedure { get; set; } // Commented out as Procedure Class was "removed" below. Didin't seem relevant anymore.
    }
     
    //public class Procedure
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public string step { get; set; }

    //    public LockoutPoint Lockoutpoint { get; set; }
    }
}
