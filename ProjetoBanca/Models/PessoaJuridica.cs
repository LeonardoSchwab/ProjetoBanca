using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoBanca.Models
{
    public class PessoaJuridica : Pessoa
    {
        public string CNPJ{ get; private set; }
        public IList<Produto> Produtos { get; private set; }
        public int Preco { get; private set; }

        public PessoaJuridica()
        {
            this.Produtos = new List<Produto>();
        }
    }
}