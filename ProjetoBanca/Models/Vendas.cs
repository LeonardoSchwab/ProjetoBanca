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
        [Required(ErrorMessage = "Preço precisa ser calculado. Insira um produto!")]
        public double PrecoTotal{ get; set; }
        [Required(ErrorMessage = "Quantidade precisa ser calculada. Insira um produto!")]
        public int Quantidade{ get; set; }
        [Required]
        public DateTime Data { get; set; }
        public int ColaboradorID { get; set; }
        public PessoaFisica Colaborador { get; set; }

        public Vendas()
        {
            this.Produtos = new List<ProdutoVendas>();
        }
    }
}