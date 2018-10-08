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
                var pessoa = context.PessoaJuridica.Find(pessoaJuridica.ID);
                pessoa.Nome = pessoaJuridica.Nome;
                pessoa.NumeroLogradouro = pessoaJuridica.NumeroLogradouro;
                pessoa.Rua = pessoaJuridica.Rua;
                pessoa.Bairro = pessoaJuridica.Bairro;
                pessoa.Complemento = pessoaJuridica.Complemento;
                pessoa.CNPJ = pessoaJuridica.CNPJ;
                pessoa.Preco = pessoaJuridica.Preco;                

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
        public PessoaJuridica Buscar(int id)
        {
            using (var context = new ProjetoContext())
            {
                return context.PessoaJuridica.Find(id);
            }
        }
    }
}