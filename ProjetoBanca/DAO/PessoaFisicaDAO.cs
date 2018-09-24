using ProjetoBanca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoBanca.DAO
{
    public class PessoaFisicaDAO
    {
        public void Adicionar(PessoaFisica pessoaFisica)
        {
            using (var context = new ProjetoContext())
            {
                context.PessoaFisica.Add(pessoaFisica);
                context.SaveChanges();
            }
        }

        public void Remover(PessoaFisica pessoaFisica)
        {
            using (var context = new ProjetoContext())
            {
                context.PessoaFisica.Remove(pessoaFisica);
                context.SaveChanges();
            }
        }

        public void Atualizar(PessoaFisica pessoaFisica)
        {
            using (var context = new ProjetoContext())
            {
                context.PessoaFisica.Update(pessoaFisica);
                context.SaveChanges();
            }
        }
        public IList<PessoaFisica> Lista()
        {
            using (var context = new ProjetoContext())
            {
                return context.PessoaFisica.ToList();
            }
        }
        public PessoaFisica Buscar(int id)
        {
            using (var context = new ProjetoContext())
            {
                return context.PessoaFisica.Find(id);
            }
        }
    }
}