using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoBanca.Models
{
    public class ProdutoVendas
    {
        public int ProdutoID { get; private set; }
        public int VendasID { get; private set; }
        public Produto Produto { get; private set; }
        public Vendas Venda { get; private set; }
    }
}