﻿/* by Isabelle isabelle.minel@catolicasc.org.br */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Avaliacao.Models
{
    public class TipoDeAssociacao
    {
       
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Periodo { get; set; }
        public int Mensalidade { get; set; }

    }
}