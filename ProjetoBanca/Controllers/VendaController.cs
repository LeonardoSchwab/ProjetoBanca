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
    public class VendaController : Controller
    {
        //[AutorizacaoFilter]
        // GET: Venda
        public ActionResult Index()
        {
            var vendasDAO = new VendasDAO();
            var vendas = vendasDAO.Lista();
            ViewBag.Venda = vendas;

            var produtosDAO = new ProdutoDAO();
            var produtos = produtosDAO.Lista();
            ViewBag.Produto = produtos;

            return View();
        }
        public ActionResult Venda()
        {
            var produtosDAO = new ProdutoDAO();
            var produtos = produtosDAO.Lista();
            ViewBag.Produto = produtos;
            return View();
        }
        public ActionResult Adiciona(Vendas venda)
        {
            var vendasDAO = new VendasDAO();
            vendasDAO.Adicionar(venda);
            return RedirectToAction("Index");
        }
        public ActionResult Remove(Vendas venda)
        {            
            var vendasDAO = new VendasDAO();
            vendasDAO.Remover(venda);
            return RedirectToAction("Index");
        }
    }
}