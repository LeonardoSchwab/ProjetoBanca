using ProjetoBanca.DAO;
using ProjetoBanca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace ProjetoBanca.AcessoUsuario
{
    public class Usuario
    {
        public static bool AutenticarUsuario(string email, string senha)
        {            
            var loginDAO = new LoginDAO();
            var login = loginDAO.Lista();

            var consulta = (from l in login
                           where l.Email == email &&
                           l.Senha == senha
                           select l).SingleOrDefault();
            if (consulta == null)
            {
                return false;
            }

            return true;
        }

        public static Login GetUsuarioLogado()
        {
            string _login = HttpContext.Current.User.Identity.Name;

            if (_login == "")
            {
                return null;
            }
            else
            {
                var loginDAO = new LoginDAO();
                var login = loginDAO.Lista();

                var loginUsuario = (from l in login
                                where l.Email == _login
                                select l).SingleOrDefault();

                return loginUsuario;
            }
        }

        public static void Deslogar()
        {
            FormsAuthentication.SignOut();
        }
    }
}