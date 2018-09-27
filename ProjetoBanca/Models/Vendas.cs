using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoBanca.Models
{
    public class Vendas
    {
        public int ID { get; set; }
        public IList<ProdutoVendas> Produtos{ get; private set; }    
        [Required]
        public double PrecoTotal{ get; set; }
        [Required]
        public int Quantidade{ get; set; }
        [Required]
        public DateTime Data { get; set; }

        public Vendas()
        {
            this.Produtos = new List<ProdutoVendas>();
        }
    }
}