using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LOTO.Models
{
    public class Task
    {
        public int ID { get; set; }

        [Display(Name = "Task Name")]
        public string TaskName { get; set; }

        public Procedure ProcedureId { get; set; }


        public MachineZone Zone { get; set; } 
        
        
        
    }
    
}
