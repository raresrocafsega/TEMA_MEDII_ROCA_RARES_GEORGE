using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TEMA_MEDII_ROCA_RARES_GEORGE.Models;

namespace TEMA_MEDII_ROCA_RARES_GEORGE.Data
{
    public class TEMA_MEDII_ROCA_RARES_GEORGEContext : DbContext
    {
        public TEMA_MEDII_ROCA_RARES_GEORGEContext (DbContextOptions<TEMA_MEDII_ROCA_RARES_GEORGEContext> options)
            : base(options)
        {
        }

        public DbSet<TEMA_MEDII_ROCA_RARES_GEORGE.Models.Service> Service { get; set; } = default!;

        public DbSet<TEMA_MEDII_ROCA_RARES_GEORGE.Models.ServiceType> ServiceType { get; set; }

        public DbSet<TEMA_MEDII_ROCA_RARES_GEORGE.Models.ServiceDetail> ServiceDetail { get; set; }
    }
}
