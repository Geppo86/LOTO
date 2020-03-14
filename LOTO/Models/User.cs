using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LOTO.Models
{
    public class User
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DOB { get; set; }

        public string EmployeeID { get; set; }

        public string Role { get; set; }
    }

}
