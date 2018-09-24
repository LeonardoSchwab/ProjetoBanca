using ProjetoBanca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoBanca.DAO
{
    public class ProdutoVendasDAO
    {
        public void Adicionar(ProdutoVendas pv)
        {
            using (var context = new ProjetoContext())
            {
                context.ProdutoVendas.Add(pv);
                context.SaveChanges();
            }
        }

        public void Remover(ProdutoVendas pv)
        {
            using (var context = new ProjetoContext())
            {
                context.ProdutoVendas.Remove(pv);
                context.SaveChanges();
            }
        }
        public void Atualizar(ProdutoVendas pv)
        {
            using (var context = new ProjetoContext())
            {
                context.ProdutoVendas.Update(pv);
                context.SaveChanges();
            }
        }
        public IList<ProdutoVendas> Lista()
        {
            using (var context = new ProjetoContext())
            {
                return context.ProdutoVendas.ToList();
            }
        }
        public ProdutoVendas Buscar(int id)
        {
            using (var context = new ProjetoContext())
            {
                return context.ProdutoVendas.Find(id);
            }
        }
        public int IdUltimaVenda()
        {
            var vendasDAO = new VendasDAO();
            var vendas = vendasDAO.Lista();
            return vendas.Last().ID;
        }
    }
}