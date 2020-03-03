using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PainelHospital.Models
{
    public class Estado : Entity
    {
        public string Sigla { get; set; }
        public string Nome { get; set; }

        public virtual IList<Endereco> Endereco { get; set; }
    }
}