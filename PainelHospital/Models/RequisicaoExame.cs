using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PainelHospital.Models
{
    public class RequisicaoExame : Entity
    {
        public DateTime DataRequisicao { get; set; }
        public int Situacao { get; set; }
        public DateTime DataAgendamento { get; set; }
    }
}