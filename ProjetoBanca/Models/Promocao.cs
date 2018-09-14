using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoBanca.Models
{
    public class Promocao
    {
        public int ID{ get; private set; }
        public string Descricao{ get; set; }
        public double Desconto{ get; set; }
        public IList<Produto> Produtos{ get; set; }

        public Promocao()
        {
            this.Produtos = new List<Produto>();
        }
    }
}