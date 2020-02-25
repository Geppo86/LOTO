using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LOTO.Models
{
    public class Machine
    {
        public int ID { get; set; }

        public string MachineName { get; set; }

        public string Site { get; set; }

        public string Building { get; set; }

        public string Notes { get; set; }
        public string MachineMap { get; set; }
    }
}
