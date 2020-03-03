using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PainelHospital.Models
{
    public class Paciente : Entity
    {
        public String Nome { get; set; } 
        public int Sexo { get; set; }
        public DateTime Nascimento { get; set; }
        public int EnderecoId { get; set; }
        public virtual Endereco Endereco { get; set; }
        public virtual Consulta Consulta { get; set; }
      

    }
}