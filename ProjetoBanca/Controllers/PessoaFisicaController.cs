using ProjetoBanca.DAO;
using ProjetoBanca.Filtros;
using ProjetoBanca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoBanca.Controllers
{
    //[AutorizacaoFilter]
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
            ViewBag.PessoaFisica = new PessoaFisica();
            return View();
        }
        public ActionResult Adiciona(PessoaFisica pessoa)
        {
            if (ModelState.IsValid) { 
                var pessoaFisicaDAO = new PessoaFisicaDAO();
                pessoaFisicaDAO.Adicionar(pessoa);
                return RedirectToAction("Index");
            }
            else
            {
                var tipoDAO = new TipoUsuarioDAO();
                var tipos = tipoDAO.Lista();
                ViewBag.TipoUsuario = tipos;

                ViewBag.PessoaFisica = pessoa;
                return View("Form");
            }
        }

        public ActionResult Remove(int id)
        {
            var pessoaFisicaDAO = new PessoaFisicaDAO();
            var pessoa = pessoaFisicaDAO.Buscar(id);
            pessoaFisicaDAO.Remover(pessoa);
            return RedirectToAction("Index");
        }
    }
}