﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Models
{
    public class Empresa : Utilizador
    {
        public ICollection<Proposta> Propostas { get; set; }
    }
}