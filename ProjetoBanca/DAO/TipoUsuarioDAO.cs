using ProjetoBanca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoBanca.DAO
{
    public class TipoUsuarioDAO
    {
        public void Adicionar(TipoUsuario tipo)
        {
            using (var context = new ProjetoContext())
            {
                context.TipoUsuario.Add(tipo);
                context.SaveChanges();
            }
        }

        public void Remover(TipoUsuario tipo)
        {
            using (var context = new ProjetoContext())
            {
                context.TipoUsuario.Remove(tipo);
                context.SaveChanges();
            }
        }
        public void Atualizar(TipoUsuario tipo)
        {
            using (var context = new ProjetoContext())
            {
                context.TipoUsuario.Update(tipo);
                context.SaveChanges();
            }
        }
        public IList<TipoUsuario> Lista()
        {
            using (var context = new ProjetoContext())
            {
                return context.TipoUsuario.ToList();
            }
        }
    }
}