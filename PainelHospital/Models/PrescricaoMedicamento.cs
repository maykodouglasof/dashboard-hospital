using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PainelHospital.Models
{
    public class PrescricaoMedicamento : Entity
    {
        public string formaUso { get; set; }
        public string Medicamento { get; set; }
    }
}