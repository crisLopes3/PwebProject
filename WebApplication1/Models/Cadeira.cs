using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Cadeira
    {

        public int Id { get; set; }

        public TipoDisciplina TipoDisciplina { get; set; }
        public int? Nota { get; set; }

        public ICollection<Aluno> Alunos { get; set; }
    }
}