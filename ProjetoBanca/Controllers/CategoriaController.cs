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
    [AutorizacaoFilterColab]
    public class CategoriaController : Controller
    {
        // GET: Categoria
        public ActionResult Index()
        {
            var categoriaDAO = new CategoriaDAO();
            var categorias = categoriaDAO.Lista();
            ViewBag.Categoria = categorias;
            ViewBag.Colaborador = (Login)Session["colabLogado"];
            return View();
        }
        public ActionResult Form()
        {
            ViewBag.Categoria = new Categoria();
            return View();
        }        
        public ActionResult Adiciona(Categoria categoria)
        {
            if (ModelState.IsValid) { 
                var categoriaDAO = new CategoriaDAO();
                categoriaDAO.Adicionar(categoria);
                //return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Categoria = categoria;
                
            }
            return View("Form");
        }
        public ActionResult Remove(int id)
        {
            var categoriaDAO = new CategoriaDAO();
            var categoria = categoriaDAO.Buscar(id);
            categoriaDAO.Remover(categoria);
            return RedirectToAction("Index");
        }

        public ActionResult Edita(int id)
        {
            var categoriaDAO = new CategoriaDAO();
            var categoria = categoriaDAO.Buscar(id);
            ViewBag.Categoria = categoria;
            return View();
        }

        public ActionResult Editar(int id, Categoria categoria)
        {
            var categoriaDAO = new CategoriaDAO();
            categoria.ID = id;
            categoriaDAO.Atualizar(categoria);

            var categorias = categoriaDAO.Lista();
            ViewBag.Categoria = categorias;
            return View("Index");
        }
    }
}