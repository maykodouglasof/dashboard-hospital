using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PainelHospital.Models
{
    public class Endereco : Entity
    {
        public string Cidade { get; set; }
        public string Logradouro { get; set; } 
        public string Cep { get; set; }
        public int EstadoId { get; set; }

        public virtual Estado Estado { get; set; }

        public virtual Paciente Paciente { get; set; }
        public virtual Medico Medico { get; set; }

    }
}