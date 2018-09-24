﻿using ProjetoBanca.DAO;
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

            return View();            
        }

        public ActionResult Adiciona(Produto produto)
        {
            var produtoDAO = new ProdutoDAO();
            produtoDAO.Adicionar(produto);
            return RedirectToAction("Index");
        }

        public ActionResult Remove(int id)
        {
            var produtoDAO = new ProdutoDAO();
            var produto = produtoDAO.Buscar(id);
            produtoDAO.Remover(produto);
            return RedirectToAction("Index");
        }
    }
}