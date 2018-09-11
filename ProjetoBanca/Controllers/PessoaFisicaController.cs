using ProjetoBanca.DAO;
using ProjetoBanca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoBanca.Controllers
{
    public class PessoaFisicaController : Controller
    {
        // GET: PessoaFisica
        public ActionResult Index()
        {
            var pessoaFisicaDAO = new PessoaFisicaDAO();
            var pessoas = pessoaFisicaDAO.Lista();
            ViewBag.PessoaFisica = pessoas;
            return View();
        }
        public ActionResult Form()
        {
            var tipoDAO = new TipoUsuarioDAO();
            var tipos = tipoDAO.Lista();
            ViewBag.TipoUsuario = tipos;
            return View();
        }
        public ActionResult Adiciona(PessoaFisica pessoa)
        {
            var pessoaFisicaDAO = new PessoaFisicaDAO();
            pessoaFisicaDAO.Adicionar(pessoa);
            return RedirectToAction("Index");
        }
    }
}