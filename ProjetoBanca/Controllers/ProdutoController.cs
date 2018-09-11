using ProjetoBanca.DAO;
using ProjetoBanca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoBanca.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Index()
        {
            ProdutoDAO dao = new ProdutoDAO();
            var produtos = dao.Lista();
            ViewBag.Produto = produtos;
            return View();
        }

        public ActionResult Form()
        {
            var categoriaDAO = new CategoriaDAO();
            var categorias = categoriaDAO.Lista();
            ViewBag.Categoria = categorias;
            return View();            
        }

        public ActionResult Adiciona(Produto produto)
        {
            var dao = new ProdutoDAO();
            dao.Adicionar(produto);
            return RedirectToAction("Index");
        }
    }
}