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
        [AutorizacaoFilter]
        // GET: Venda
        public ActionResult Index()
        {
            var vendasDAO = new VendasDAO();
            var vendas = vendasDAO.Lista();
            ViewBag.Venda = vendas;
            return View();
        }
        public ActionResult Venda()
        {
            return View();
        }
        public ActionResult Adiciona(Vendas venda, double precoTotal)
        {
            venda.PrecoTotal = precoTotal;
            var vendasDAO = new VendasDAO();
            return RedirectToAction("Index");
        }
    }
}