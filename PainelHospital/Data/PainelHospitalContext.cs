using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PainelHospital.Models;

namespace PainelHospital.Models
{
    public class PainelHospitalContext : DbContext
    {
        public PainelHospitalContext (DbContextOptions<PainelHospitalContext> options)
            : base(options)
        {
        }

        public DbSet<PainelHospital.Models.Paciente> Paciente { get; set; }

        public DbSet<PainelHospital.Models.Endereco> Endereco { get; set; }

        public DbSet<PainelHospital.Models.Estado> Estado { get; set; }

        public DbSet<PainelHospital.Models.Atendimento> Atendimento { get; set; }

        public DbSet<PainelHospital.Models.Consulta> Consulta { get; set; }

        public DbSet<PainelHospital.Models.Plano> Plano { get; set; }

        public DbSet<PainelHospital.Models.Medico> Medico { get; set; }

        public DbSet<PainelHospital.Models.Exame> Exame { get; set; }
    }
}
