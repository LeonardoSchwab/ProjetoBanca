using ProjetoBanca.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoBanca.Models
{
    public class Login
    {
        public int ID { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Senha { get; set; }
        [Required]
        public int PessoaFisicaID { get; set; }
        public PessoaFisica PessoaFisica { get; set; }

        public Login()
        {
            //GetPessoa();
        }

        public void GetPessoa()
        {
            var pessoaDAO = new PessoaFisicaDAO();
            var pessoas = pessoaDAO.Lista();

            this.PessoaFisica = (from p in pessoas
                         where p.ID == this.PessoaFisicaID
                         select p).First();
        }
    }
}