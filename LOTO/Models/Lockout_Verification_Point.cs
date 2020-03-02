using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LOTO.Models
{
    public class Lockout_Verification_Point
    {
        public int ID { get; set; }

        public int LockOutTagNumber { get; set; }

        public string EnergyType { get; set; }
        public int EnergyMagnitude { get; set; }

        public string Device { get; set; }

        public string MethodToIsolate { get; set; }

        public string MethodToVerify { get; set; }

        public string ConfirmationDevice1 { get; set; }

        public string ConfirmationDevice2 { get; set; }
        public string ConfirmationDevice3 { get; set; }

        public string LockOutPointPicture { get; set; }


    }
}
