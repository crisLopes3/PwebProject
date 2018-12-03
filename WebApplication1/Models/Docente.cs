using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Models
{
    public class Docente : Utilizador
    {
        public IList<Proposta> Propostas { get; set; }
        public Comissao Comissao { get; set; }
    }
}