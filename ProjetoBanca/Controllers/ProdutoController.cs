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
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Index()
        {            
            var produtoDAO = new ProdutoDAO();
            var produtos = produtoDAO.Lista();
            ViewBag.Produto = produtos;
            return View();
        }

        public ActionResult Form()
        {
            var categoriaDAO = new CategoriaDAO();
            var categorias = categoriaDAO.Lista();
            ViewBag.Categoria = categorias;

            var fornecedorDAO = new PessoaJuridicaDAO();
            var fornecedores = fornecedorDAO.Lista();
            ViewBag.Fornecedor = fornecedores;

            var promocaoDAO = new PromocaoDAO();
            var promocoes = promocaoDAO.Lista();
            ViewBag.Promocao = promocoes;

            ViewBag.Produto = new Produto();
            return View();            
        }

        public ActionResult Adiciona(Produto produto)
        {
            if(produto.Estoque < produto.Quantidade)
            {
                ModelState.AddModelError("EstoqueQuantidadeInvalido", "Estoque deve ser maior/igual a quantidade!");
            }
            if (ModelState.IsValid)
            {
                var produtoDAO = new ProdutoDAO();
                produtoDAO.Adicionar(produto);
                return RedirectToAction("Index");
            }
            else
            {
                var categoriaDAO = new CategoriaDAO();
                var categorias = categoriaDAO.Lista();
                ViewBag.Categoria = categorias;

                var fornecedorDAO = new PessoaJuridicaDAO();
                var fornecedores = fornecedorDAO.Lista();
                ViewBag.Fornecedor = fornecedores;

                var promocaoDAO = new PromocaoDAO();
                var promocoes = promocaoDAO.Lista();
                ViewBag.Promocao = promocoes;

                ViewBag.Produto = produto;
                return View("Form");
            }
        }

        public ActionResult Remove(int id)
        {
            var produtoDAO = new ProdutoDAO();
            var produto = produtoDAO.Buscar(id);
            produtoDAO.Remover(produto);
            return RedirectToAction("Index");
        }

        public ActionResult VerificaEstoque(Vendas venda, List<int> produtosID, List<int> quantidades)
        {
            var produtoDAO = new ProdutoDAO();
            var listaProdutos = produtoDAO.GetProdutos(produtosID);
            for (var i = 0; i < listaProdutos.Count; i++)
            {
                if(listaProdutos[i].Estoque >= quantidades[i])
                {                    
                    return RedirectToAction("Adiciona", "Venda", venda);
                }                
            }
            return RedirectToAction("Venda", "Venda");
        }

        public ActionResult BaixaEstoque(int id, int quantidade)
        {
            var produtoDAO = new ProdutoDAO();
            var produto = produtoDAO.Buscar(id);
            produto.Estoque -= quantidade;
            produtoDAO.Atualizar(produto);
            return RedirectToAction("Index", "Venda");
        }
    }
}