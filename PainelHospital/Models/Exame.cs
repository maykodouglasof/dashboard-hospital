using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PainelHospital.Models
{
    public class Exame : Entity
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public float Valor { get; set; }
    }
}