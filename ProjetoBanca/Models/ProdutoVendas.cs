using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoBanca.Models
{
    public class ProdutoVendas
    {
        public int ID { get; set; }
        [Required]
        public int ProdutoID { get; set; }
        [Required]
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