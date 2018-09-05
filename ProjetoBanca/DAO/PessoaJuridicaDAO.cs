using ProjetoBanca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoBanca.DAO
{
    public class PessoaJuridicaDAO
    {
        public void Adicionar(PessoaJuridica pessoaJuridica)
        {
            using (var context = new ProjetoContext())
            {
                context.PessoaJuridica.Add(pessoaJuridica);
                context.SaveChanges();
            }
        }

        public void Remover(PessoaJuridica pessoaJuridica)
        {
            using (var context = new ProjetoContext())
            {
                context.PessoaJuridica.Remove(pessoaJuridica);
                context.SaveChanges();
            }
        }
        public void Atualizar(PessoaJuridica pessoaJuridica)
        {
            using (var context = new ProjetoContext())
            {
                context.PessoaJuridica.Update(pessoaJuridica);
                context.SaveChanges();
            }
        }
        public IList<PessoaJuridica> Lista()
        {
            using (var context = new ProjetoContext())
            {
                return context.PessoaJuridica.ToList();
            }
        }
    }
}