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
    public class PessoaJuridicaController : Controller
    {
        // GET: PessoaJuridica
        public ActionResult Index()
        {
            var pessoaJuridicaDAO = new PessoaJuridicaDAO();
            var pessoas = pessoaJuridicaDAO.Lista();
            ViewBag.PessoaJuridica = pessoas;
            return View();
        }
        public ActionResult Form()
        {
            return View();
        }
        public ActionResult Adiciona(PessoaJuridica pessoa)
        {
            var pessoaJuridicaDAO = new PessoaJuridicaDAO();
            pessoaJuridicaDAO.Adicionar(pessoa);
            return RedirectToAction("Index");
        }
    }
}