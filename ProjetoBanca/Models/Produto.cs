using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoBanca.Models
{
    public class Produto
    {
        public int ID{ get; set; }
        public string Nome{ get; set; }
        public double Preco { get; set; }
        public string Unidade{ get; set; }
        public int Quantidade { get; set; }
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