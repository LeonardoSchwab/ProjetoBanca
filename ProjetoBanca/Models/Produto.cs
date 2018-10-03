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
        [Required(ErrorMessage = "Nome precisa ser digitado!")]
        public string Nome{ get; set; }
        [Required(ErrorMessage = "Preço precisa ser digitado!")]
        public double Preco { get; set; }
        [Required(ErrorMessage = "Unidade precisa ser digitada!")]
        public string Unidade{ get; set; }
        [Required(ErrorMessage = "Quantidade precisa ser digitada!")]
        public int Quantidade { get; set; }
        [Required(ErrorMessage = "Estoque precisa ser digitado!")]
        public int Estoque { get; set; }
        public int CategoriaID { get; set; }
        public Categoria Categoria { get; private set; }
        //public int PromocaoID { get; set; }
        public Promocao Promocao{ get; private set; }
        public int FornecedorID { get; set; }
        public PessoaJuridica Fornecedor { get; private set; }
        public IList<ProdutoVendas> Vendas { get; private set; }
        
        public Produto()
        {
            this.Vendas = new List<ProdutoVendas>();
        }
    }
}