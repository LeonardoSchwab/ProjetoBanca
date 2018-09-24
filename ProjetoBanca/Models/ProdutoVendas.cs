using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoBanca.Models
{
    public class ProdutoVendas
    {
        public int ID { get; set; }
        public int ProdutoID { get; set; }
        public int VendaID { get; set; }
        public Produto Produto { get; private set; }
        public Vendas Venda { get; private set; }

        public ProdutoVendas(int produtoID, int VendaID)
        {
            this.ProdutoID = produtoID;
            this.VendaID = VendaID;
        }
    }
}