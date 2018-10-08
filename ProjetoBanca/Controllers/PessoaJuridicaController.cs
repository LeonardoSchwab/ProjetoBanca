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
    [PermissaoFunc]
    [AutorizacaoFilterColab]
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
            ViewBag.Pessoa = new PessoaJuridica();
            return View();
        }
        public ActionResult Adiciona(PessoaJuridica pessoa)
        {
            if (ModelState.IsValid)
            {
                var pessoaJuridicaDAO = new PessoaJuridicaDAO();
                pessoaJuridicaDAO.Adicionar(pessoa);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Pessoa = pessoa;
                return View("Form");
            }
        }

        public ActionResult Remove(int id)
        {
            var pessoaJuridicaDAO = new PessoaJuridicaDAO();
            var pessoa = pessoaJuridicaDAO.Buscar(id);
            pessoaJuridicaDAO.Remover(pessoa);
            return RedirectToAction("Index");
        }

        public ActionResult Edita(int id)
        {
            var pjDAO = new PessoaJuridicaDAO();
            var pessoa = pjDAO.Buscar(id);
            ViewBag.Pessoa = pessoa;
            return View();
        }

        public ActionResult Editar(PessoaJuridica pessoa)
        {
            var pjDAO = new PessoaJuridicaDAO();
            pjDAO.Atualizar(pessoa);

            var pessoas = pjDAO.Lista();
            ViewBag.Pessoa = pessoas;
            return RedirectToAction("Index");
        }
    }
}