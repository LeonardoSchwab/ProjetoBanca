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
    public class VendaController : Controller
    {
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
            if (ModelState.IsValid)
            {
                var vendasDAO = new VendasDAO();
                venda.Data = DateTime.Now;
                vendasDAO.Adicionar(venda);
                return RedirectToAction("Index");
            }
            else
            {
                var produtosDAO = new ProdutoDAO();
                var produtos = produtosDAO.Lista();
                ViewBag.Produto = produtos;
                
                return View("Venda");
            }
        }
        public ActionResult AdicionaProdutoVenda(int idProduto)
        {
            if (ModelState.IsValid)
            {
                var produtoVendasDAO = new ProdutoVendasDAO();
                var ultimaVendaId = produtoVendasDAO.IdUltimaVenda();
                var pv = new ProdutoVendas(idProduto, ultimaVendaId);
                produtoVendasDAO.Adicionar(pv);
                return RedirectToAction("Index");
            }
            else
            {
                var produtosDAO = new ProdutoDAO();
                var produtos = produtosDAO.Lista();
                ViewBag.Produto = produtos;

                return View("Venda");
            }
        }
        public ActionResult Remove(int id)
        {            
            var vendasDAO = new VendasDAO();
            var venda = vendasDAO.Buscar(id);
            vendasDAO.Remover(venda);
            return RedirectToAction("Index");
        }
    }
}