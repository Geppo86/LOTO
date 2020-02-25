using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LOTO.Models;

namespace LOTO.Data
{
    public class LOTOContext : DbContext
    {
        public LOTOContext (DbContextOptions<LOTOContext> options)
            : base(options)
        {
        }

        public DbSet<LOTO.Models.Machine> Machine { get; set; }
    }
}
