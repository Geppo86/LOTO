using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LOTO.Models
{
    public class Task
    {
        [Key]
        public int TID { get; set; }

        [Display(Name = "Task Name")]
        public string TaskName { get; set; }

        public Procedure PID { get; set; } //Foreign Key


        public MachineZone MZID { get; set; } //Foreign Key
        
        
        
    }
    
}
