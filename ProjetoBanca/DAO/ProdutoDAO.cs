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
                context.Produto.Update(produto);
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
    }
}