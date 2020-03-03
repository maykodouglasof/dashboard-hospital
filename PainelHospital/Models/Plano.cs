using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PainelHospital.Models
{
    public class Plano : Entity
    {
        public string Nome { get; set; }
        public string Sigla { get; set; }
    }
}