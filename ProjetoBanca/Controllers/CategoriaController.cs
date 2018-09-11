using ProjetoBanca.DAO;
using ProjetoBanca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoBanca.Controllers
{
    public class CategoriaController : Controller
    {
        // GET: Categoria
        public ActionResult Index()
        {
            var categoriaDAO = new CategoriaDAO();
            var categorias = categoriaDAO.Lista();
            ViewBag.Categoria = categorias;
            return View();
        }
        public ActionResult Form()
        {
            return View();
        }
        public ActionResult Adiciona(Categoria categoria)
        {
            var categoriaDAO = new CategoriaDAO();
            categoriaDAO.Adicionar(categoria);
            return RedirectToAction("Index");
        }
    }
}