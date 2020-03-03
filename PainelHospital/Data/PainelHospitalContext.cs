using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PainelHospital.Models
{
    public class PainelHospitalContext : DbContext
    {
        public PainelHospitalContext (DbContextOptions<PainelHospitalContext> options)
            : base(options)
        {
        }

        public DbSet<PainelHospital.Models.Paciente> Paciente { get; set; }
    }
}
