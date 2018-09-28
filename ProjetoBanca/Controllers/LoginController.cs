using ProjetoBanca.DAO;
using ProjetoBanca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoBanca.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Autentica(string cpf, string dataNascimento)
        {
            var pessoaFisicaDAO = new PessoaFisicaDAO();
            var usuario = pessoaFisicaDAO.Buscar(cpf, dataNascimento);
            if(usuario != null)
            {
                Session["usuarioLogado"] = usuario;
                return RedirectToAction("Index", "Produto");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        public ActionResult LoginColaborador()
        {
            return View();
        }

        public ActionResult Logar(Login login)
        {
            if(!AcessoUsuario.Usuario.AutenticarUsuario(login.Email, login.Senha))
            {
                ViewBag.mensagemErro = "O email do usuario ou a senha informada estão incorretos!";
                return View("LoginColaborador");
            }

            return RedirectToAction("Venda", "Venda");
        }

        public ActionResult Exemplo()
        {
            return View();
        }
    }
}