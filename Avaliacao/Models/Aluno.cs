using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Avaliacao.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public Faixa Faixa { get; set; }
        public TipoDeAssociacao TipoDeAssociacao { get; set; }
    }
}