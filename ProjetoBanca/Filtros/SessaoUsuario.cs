using ProjetoBanca.DAO;
using ProjetoBanca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoBanca.Filtros
{
    public static class SessaoUsuario
    {
        public static Login LoginUsuario()
        {
            return (Login)HttpContext.Current.Session["colabLogado"];
        }

        public static PessoaFisica UsuarioLogado()
        {
            var pessoaDAO = new PessoaFisicaDAO();
            var pessoas = pessoaDAO.Lista();
            var loginUsuario = LoginUsuario();

            var usuario = (from p in pessoas
                          where p.ID == loginUsuario.PessoaFisicaID
                          select p).First();

            return usuario;
        }
    }
}