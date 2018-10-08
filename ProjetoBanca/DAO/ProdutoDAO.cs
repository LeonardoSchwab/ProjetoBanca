using ProjetoBanca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoBanca.DAO
{
    public class ProdutoDAO
    {
        public void Adicionar(Produto produto)
        {
            using (var context = new ProjetoContext())
            {
                context.Produto.Add(produto);
                context.SaveChanges();
            }
        }

        public void Remover(Produto produto)
        {
            using (var context = new ProjetoContext())
            {
                context.Produto.Remove(produto);
                context.SaveChanges();
            }
        }
        public void Atualizar(Produto produto)
        {
            using (var context = new ProjetoContext())
            {
                var prod = context.Produto.Find(produto.ID);
                prod.Nome = produto.Nome;
                prod.Pontos = produto.Pontos;
                prod.Preco = produto.Preco;
                prod.Quantidade = produto.Quantidade;
                prod.Unidade = produto.Unidade;
                prod.CategoriaID = prod.CategoriaID;
                prod.FornecedorID = prod.FornecedorID;
                prod.Estoque = prod.Estoque;
                
                context.SaveChanges();
            }
        }
        public IList<Produto> Lista()
        {
            using (var context = new ProjetoContext())
            {
                return context.Produto.ToList();
            }
        }
        public Produto Buscar(int id)
        {
            using (var context = new ProjetoContext())
            {
                return context.Produto.Find(id);
            }
        }
        public IList<Produto> GetProdutos(IList<int> produtosID)
        {
            var produtos = new List<Produto>();
            var listaProdutos = Lista();
            foreach(var p in produtosID)
            {
                var produto = (from lp in listaProdutos
                               where lp.ID == p
                               select lp).FirstOrDefault();

                produtos.Add(produto);
            }
            return produtos;
        }
    }
}