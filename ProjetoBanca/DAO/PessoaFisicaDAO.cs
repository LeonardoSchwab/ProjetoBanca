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
                var pessoa = context.PessoaFisica.Find(pessoaFisica.ID);
                pessoa.Nome = pessoaFisica.Nome;
                pessoa.NumeroLogradouro = pessoaFisica.NumeroLogradouro;
                pessoa.Pontos = pessoaFisica.Pontos;
                pessoa.Rua = pessoaFisica.Rua;
                pessoa.Sexo = pessoaFisica.Sexo;
                pessoa.TipoID = pessoaFisica.TipoID;
                pessoa.Bairro = pessoaFisica.Bairro;
                pessoa.Complemento = pessoaFisica.Complemento;
                pessoa.CPF = pessoaFisica.CPF;
                pessoa.DataNascimento = pessoaFisica.DataNascimento;                

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

        public PessoaFisica Buscar(string cpf, string dataNascimento)
        {
            using (var context = new ProjetoContext())
            {
                var pessoas = this.Lista();
                var pessoa = (from p in pessoas
                          where p.CPF == cpf &&
                          p.DataNascimento == dataNascimento
                          select p).First();

                return pessoa;
            }
        }
    }
}