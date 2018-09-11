using ProjetoBanca.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoBanca.Controllers
{
    public class VendaController : Controller
    {
        // GET: Venda
        public ActionResult Index()
        {
            var vendasDAO = new VendasDAO();
            var vendas = vendasDAO.Lista();
            ViewBag.Venda = vendas;
            return View();
        }
    }
}