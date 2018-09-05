using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoBanca.Models
{
    public class Produto
    {
        public int ID{ get; private set; }
        public string Nome{ get; private set; }
        public double Preco { get; private set; }
        public string Unidade{ get; private set; }
        public int Quantidade { get; private set; }
    }
}