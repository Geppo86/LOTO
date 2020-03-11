using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LOTO.Models
{
    public class Procedure
    {
        public string LOTOorAPM { get; set; }

        public string Note { get; set; }

        public string DateLastAudit { get; set; }

        public string NameLastAudit { get; set; }

        public string ProcedureID { get; set; }

        [Display(Name = "Procedure Name")]
        public string ProcedureName { get; set; }


    }
     
   
}