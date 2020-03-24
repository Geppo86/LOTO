using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LOTO.Models
{
    public class LockpointConfirmationXRef
    {
        [Key]
        public LockoutPoint LPID { get; set; } //Foreign Key
        
        public ConfirmationPoint CPID { get; set; } //Foreign Key


    }
}
