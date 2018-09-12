using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoBanca.Models
{
    public class Vendas
    {
        public int ID { get; private set; }
        public IList<ProdutoVendas> Produtos{ get; private set; }
        public double PrecoUnitario{ get; private set; }
        public double PrecoTotal{ get; private set; }
        public int Quantidade{ get; private set; }

        public Vendas()
        {
            this.Produtos = new List<ProdutoVendas>();
        }
    }
}