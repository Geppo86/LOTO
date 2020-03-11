using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LOTO.Models
{
    public class ProcedureLockoutPointXRef
    {
        public int ProcedureID { get; set; }

        public int LockoutPoints { get; set; }

        public int StepNumber { get; set; }

    }


}


