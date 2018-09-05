using ProjetoBanca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoBanca.DAO
{
    public class VendasDAO
    {
        public void Adicionar(Vendas vendas)
        {
            using (var context = new ProjetoContext())
            {
                context.Vendas.Add(vendas);
                context.SaveChanges();
            }
        }

        public void Remover(Vendas vendas)
        {
            using (var context = new ProjetoContext())
            {
                context.Vendas.Remove(vendas);
                context.SaveChanges();
            }
        }
        public void Atualizar(Vendas venda)
        {
            using (var context = new ProjetoContext())
            {
                context.Vendas.Update(venda);
                context.SaveChanges();
            }
        }
        public IList<Vendas> Lista()
        {
            using (var context = new ProjetoContext())
            {
                return context.Vendas.ToList();
            }
        }
    }
}