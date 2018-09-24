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
    public class PromocaoController : Controller
    {
        // GET: Promocao
        public ActionResult Index()
        {
            var promocaoDAO = new PromocaoDAO();
            var promocoes = promocaoDAO.Lista();
            ViewBag.Promocao = promocoes;
            return View();
        }

        public ActionResult Form()
        {
            var produtoDAO = new ProdutoDAO();
            var produtos = produtoDAO.Lista();
            ViewBag.Produto = produtos;
            return View();
        }

        public ActionResult Adiciona(Promocao promocao)
        {
            var promocaoDAO = new PromocaoDAO();
            promocaoDAO.Adicionar(promocao);
            return RedirectToAction("Index");
        }

        public ActionResult Remove(int id)
        {
            var promocaoDAO = new PromocaoDAO();
            var promocao = promocaoDAO.Buscar(id);
            promocaoDAO.Remover(promocao);
            return RedirectToAction("Index");
        }
    }
}