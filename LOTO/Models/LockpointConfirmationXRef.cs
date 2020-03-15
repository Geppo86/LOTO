using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LOTO.Models
{
    public class LockpointConfirmationXRef
    {
        public LockoutPoint LPID { get; set; } //Foreign Key
        
        public ConfirmationPoint CPID { get; set; } //Foreign Key


    }
}
