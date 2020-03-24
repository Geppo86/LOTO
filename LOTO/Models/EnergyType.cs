using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LOTO.Models
{
    public class EnergyType
    {
        [Key]
        public int ETID { get; set; }

        public string EnergyTypeName { get; set; }

        public string BackgroundColor { get; set; }

        
    }
}