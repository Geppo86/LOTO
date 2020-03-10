using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LOTO.Models
{
    public class ConfirmationPoint
    {
        public int CPID { get; set; }

        public string ConfirmationDeviceName {get;set;}

        public string ConfirmationTagNumber { get; set; }

        public string ConfirmationDeviceSafeStatus { get; set; }

        public string ConfirmationDevicePicture { get; set; }

        public string ConfirmationDeviceType { get; set; }

        public string LocationDescription { get; set; }
    }
}
