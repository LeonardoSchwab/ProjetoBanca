using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoBanca.Models
{
    public class Categoria
    {
        public int ID{ get; private set; }
        public string Nome { get; private set; }
        public IList<Produto> Produtos { get; private set; }
    }
}