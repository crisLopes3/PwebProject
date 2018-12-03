using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication1.Models;

namespace WebApplication1.Models
{
    public class Proposta
    {
        public int Id { get; set; }

        [Required]
        public string Descricao { get; set; }

        [Required]
        public string LocalEstagio { get; set; }

        public TipoProposta? TipoProposta { get; set; }

        [Required]
        public Ramo? Ramo { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataInicio { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataFim { get; set; }

        [DataType(DataType.MultilineText)]
        public string Objetivos { get; set; }


        public IList<Aluno> Alunos { get; set; }
        public IList<Docente> Docentes { get; set; }
        public IList<Empresa> Empresas { get; set; }
        public Comissao Comissao { get; set; }
    }
}