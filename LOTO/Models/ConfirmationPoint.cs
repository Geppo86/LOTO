using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LOTO.Models
{
    public class ConfirmationPoint
    {
        [Key]
        public int CPID { get; set; }

        public string ConfirmationTagNumber { get; set; }

        public string ConfirmationDeviceType { get; set; }

        public string ConfirmationDeviceSafeStatus { get; set; }

        public string ConfirmationDevicePicture { get; set; }

        public string LocationDescription { get; set; }

        public string ConfirmationDeviceName {get;set;}

        
    }
}
