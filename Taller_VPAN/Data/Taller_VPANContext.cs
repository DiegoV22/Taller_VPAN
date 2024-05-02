using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Taller_VPAN.Models;

namespace Taller_VPAN.Data
{
    public class Taller_VPANContext : DbContext
    {
        public Taller_VPANContext (DbContextOptions<Taller_VPANContext> options)
            : base(options)
        {
        }

        public DbSet<Taller_VPAN.Models.Propietario> Propietario { get; set; } = default!;
        public DbSet<Taller_VPAN.Models.Auto> Auto { get; set; } = default!;
        public DbSet<Taller_VPAN.Models.Motor> Motor { get; set; } = default!;
    }
}
