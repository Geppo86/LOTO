using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LOTO.Models
{
    public class ProcedureLockoutPointXRef
    {
        public Procedure PID { get; set; } // Foreign Key

        public LockoutPoint LPID { get; set; } //Foreign Key

        public int StepNumber { get; set; } /*Step number is the order in which 
                                              points are assigned to, 
                                              or locked out in a Procedure. 
                                              We added visual because the 
                                              difficulty in understanding 
                                              was that the step is displayed 
                                              in the website next to lockout point 
                                              information.*/

    }


}


