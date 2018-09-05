using ProjetoBanca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoBanca.DAO
{
    public class CategoriaDAO
    {
        public void Adicionar(Categoria categoria)
        {
            using(var context = new ProjetoContext())
            {
                context.Categoria.Add(categoria);
                context.SaveChanges();
            }
        }

        public void Remover(Categoria categoria)
        {
            using(var context = new ProjetoContext())
            {
                context.Categoria.Remove(categoria);
                context.SaveChanges();
            }
        }
        public void Atualizar(Categoria categoria)
        {
            using(var context = new ProjetoContext())
            {                
                context.Categoria.Update(categoria);
                context.SaveChanges();
            }
        }
        public IList<Categoria> Lista()
        {
            using(var context = new ProjetoContext())
            {
                return context.Categoria.ToList();
            }
        }

    }
}