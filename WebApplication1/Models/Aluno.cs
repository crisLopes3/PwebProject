using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Models
{
    [Table("Alunos")]
    public class Aluno : Utilizador
    {
        [Required]
        public Ramo? Ramo { get; set; }
        

        public ICollection<Cadeira> CadeirasPorFazer { get; set; }
        public ICollection<Proposta> Propostas { get; set; }
    }
}