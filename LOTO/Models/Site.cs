using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LOTO.Models
{
    public class Site
    {
        public int SID { get; set; }

        [Display(Name = "Site Name")]
        public string SiteName { get; set; }

        [Display(Name = "Site Address")]
        public string SiteAddress { get; set; }

    }
}