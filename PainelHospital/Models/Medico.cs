using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PainelHospital.Models
{
    public class Medico : Entity
    {
        public string Nome { get; set; }
        public string Crm { get; set; }
        public string Tel { get; set; }
        public int Atendimentos { get; set; }
    }
}