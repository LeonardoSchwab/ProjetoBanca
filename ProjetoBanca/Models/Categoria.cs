using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoBanca.Models
{
    public class Categoria
    {
        public int ID{ get; set; }
        public string Nome { get; set; }
        public IList<Produto> Produtos { get; private set; }
    }
}