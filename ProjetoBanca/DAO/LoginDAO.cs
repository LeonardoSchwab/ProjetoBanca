using ProjetoBanca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoBanca.DAO
{
    public class LoginDAO
    {
        public void Adicionar(Login login)
        {
            using (var context = new ProjetoContext())
            {
                context.Login.Add(login);
                context.SaveChanges();
            }
        }

        public void Remover(Login login)
        {
            using (var context = new ProjetoContext())
            {
                context.Login.Remove(login);
                context.SaveChanges();
            }
        }
        public void Atualizar(Login login)
        {
            using (var context = new ProjetoContext())
            {
                context.Login.Update(login);
                context.SaveChanges();
            }
        }
        public IList<Login> Lista()
        {
            using (var context = new ProjetoContext())
            {
                return context.Login.ToList();
            }
        }
        public Login Buscar(int id)
        {
            using (var context = new ProjetoContext())
            {
                return context.Login.Find(id);
            }
        }
    }
}