﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LOTO.Models
{
    public class Procedure
    {
        [Key]
        public int PID { get; set; }
        public string LotoOrApm { get; set; }

        public string Note { get; set; }

        public string DateLastAudit { get; set; }

        public User UID { get; set; } // Foreign Key
        //Used to get last name of person who performed the most recent audit.

        [Display(Name = "Procedure Name")]
        public string ProcedureName { get; set; }


    }
     
   
}