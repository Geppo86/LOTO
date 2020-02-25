using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LOTO.Models
{
    public class Task
    {
        public MachineZone Zone { get; set; }
        public int ID { get; set; }
        public string TaskName { get; set; }
        public Procedure Procedure { get; set; }
    }

    public class Procedure
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string step { get; set; }

        public LockoutPoint Lockoutpoint { get; set; }
    }
}
