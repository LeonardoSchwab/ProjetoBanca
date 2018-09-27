using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoBanca.Models
{
    public class PessoaJuridica : Pessoa
    {
        [Required]
        public string CNPJ{ get; set; }
        public IList<Produto> Produtos { get; private set; }
        [Required]
        public int Preco { get; set; }

        public PessoaJuridica()
        {
            this.Produtos = new List<Produto>();
        }
    }
}