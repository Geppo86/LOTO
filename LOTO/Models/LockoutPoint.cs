using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LOTO.Models
{
    public class LockoutPoint
    {
        public int LPID { get; set; }
        public int LockoutTagNumber { get; set; }

        public string LocationDescription { get; set; }

        public string EnergyType { get; set; }

        public string EnergyMagnitude { get; set; }

        public string Device { get; set; }

        public string MethodToIsolate { get; set; }

        public string MethodToVerify { get; set; }

        public string ConfirmationDeviceNumber1 { get; set; }
        public string ConfirmationDeviceNumber2 { get; set; }

        public string ConfirmationDeviceNumber3 { get; set; }

        public string LockoutPointPicture { get; set; }


    }
}
