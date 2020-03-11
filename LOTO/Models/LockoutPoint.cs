using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LOTO.Models
{
    public class LockoutPoint
    {
        public int ID { get; set; }
        public string LockoutTagNumber { get; set; }

        public string LocationDescription { get; set; }

        public int EnergyTypeID { get; set; }

        public string EnergyMagnitude { get; set; }

        public string Device { get; set; }

        public string MethodToIsolate { get; set; }

        public string MethodToVerify { get; set; }

        public int ConfirmationDeviceID { get; set; }
       
        public string LockoutPointPicture { get; set; }


    }
}
