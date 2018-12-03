using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Models
{
    [Table("Comissao")]
    public class Comissao
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        public IList<Docente> Docentes { get; set; }
        public IList<Proposta> Propostas { get; set; }
    }
}