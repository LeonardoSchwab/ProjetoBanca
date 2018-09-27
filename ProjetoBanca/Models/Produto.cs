using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoBanca.Models
{
    public class Produto
    {
        public int ID{ get; set; }
        [Required]
        public string Nome{ get; set; }
        [Required]
        public double Preco { get; set; }
        [Required]
        public string Unidade{ get; set; }
        [Required]
        public int Quantidade { get; set; }
        [Required]
        public int CategoriaID { get; set; }
        public Categoria Categoria { get; private set; }
        //public int PromocaoID { get; set; }
        public Promocao Promocao{ get; private set; }
        [Required]
        public int FornecedorID { get; set; }
        public PessoaJuridica Fornecedor { get; private set; }
        public IList<ProdutoVendas> Vendas { get; private set; }

        public Produto()
        {
            this.Vendas = new List<ProdutoVendas>();
        }
    }
}