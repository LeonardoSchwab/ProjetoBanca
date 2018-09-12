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
        public int CategoriaID { get; private set; }
        public Categoria Categoria { get; private set; }
        public int PromocaoID { get; private set; }
        public Promocao Promocao{ get; private set; }
        public int FornecedorID { get; private set; }
        public PessoaJuridica Fornecedor { get; private set; }
        public IList<ProdutoVendas> Vendas { get; private set; }

        public Produto()
        {
            this.Vendas = new List<ProdutoVendas>();
        }
    }
}