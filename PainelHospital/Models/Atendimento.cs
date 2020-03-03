using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PainelHospital.Models
{
    public class Atendimento
    {
        public DateTime horaInicio { get; set; } 
        public DateTime horaFim { get; set; }
        public Boolean atendePlano { get; set; }
        public Boolean atendeDia { get; set; }
    }
}