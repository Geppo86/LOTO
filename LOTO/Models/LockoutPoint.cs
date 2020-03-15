using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LOTO.Models
{
    public class LockoutPoint
    {
        public int LPID { get; set; }
        public string LockoutTagNumber { get; set; }

        public string LocationDescription { get; set; }

        public EnergyType ETID { get; set; } //Foreign Key

        public string EnergyMagnitude { get; set; }

        public string Device { get; set; }

        public string LockoutPointPicture { get; set; }

        public string MethodToIsolate { get; set; }

        public string MethodToVerify { get; set; }

        public ConfirmationPoint CPID { get; set; } //Foreign Key
       
        


    }
}
