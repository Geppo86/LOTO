using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LOTO.Models
{
    public class Site
    {
        public int ID { get; set; }

        [Display(Name = "Site Name")]
        public string SiteName { get; set; }

    }
}