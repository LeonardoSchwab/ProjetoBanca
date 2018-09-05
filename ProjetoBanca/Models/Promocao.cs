using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoBanca.Models
{
    public class Promocao
    {
        public int ID{ get; private set; }
        public string Descricao{ get; private set; }
        public double Desconto{ get; private set; }
        public IList<Produto> Produtos{ get; set; }
    }
}