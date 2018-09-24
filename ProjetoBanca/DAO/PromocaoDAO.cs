using ProjetoBanca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoBanca.DAO
{
    public class PromocaoDAO
    {
        public void Adicionar(Promocao promocao)
        {
            using (var context = new ProjetoContext())
            {
                context.Promocao.Add(promocao);
                context.SaveChanges();
            }
        }

        public void Remover(Promocao promocao)
        {
            using (var context = new ProjetoContext())
            {
                context.Promocao.Remove(promocao);
                context.SaveChanges();
            }
        }
        public void Atualizar(Promocao promocao)
        {
            using (var context = new ProjetoContext())
            {
                context.Promocao.Update(promocao);
                context.SaveChanges();
            }
        }
        public IList<Promocao> Lista()
        {
            using (var context = new ProjetoContext())
            {
                return context.Promocao.ToList();
            }
        }
        public Promocao Buscar(int id)
        {
            using (var context = new ProjetoContext())
            {
                return context.Promocao.Find(id);
            }
        }
    }
}