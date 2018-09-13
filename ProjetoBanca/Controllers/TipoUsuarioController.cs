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
    public class TipoUsuarioController : Controller
    {
        // GET: TipoUsuario
        public ActionResult Index()
        {
            var tipoDAO = new TipoUsuarioDAO();
            var tipos = tipoDAO.Lista();
            ViewBag.Tipo = tipos;
            return View();
        }
        public ActionResult Form()
        {
            return View();
        }
        public ActionResult Adiciona(TipoUsuario tipo)
        {
            var tipoDAO = new TipoUsuarioDAO();
            tipoDAO.Adicionar(tipo);
            return RedirectToAction("Index");
        }
    }
}