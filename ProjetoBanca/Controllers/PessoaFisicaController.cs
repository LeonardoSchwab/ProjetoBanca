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
    [PermissaoFunc]
    [AutorizacaoFilterColab]
    public class PessoaFisicaController : Controller
    {
        // GET: PessoaFisica
        public ActionResult Index()
        {
            var pessoaFisicaDAO = new PessoaFisicaDAO();
            var pessoas = pessoaFisicaDAO.Lista();
            ViewBag.PessoaFisica = pessoas;
            return View();
        }
        public ActionResult Form()
        {
            var tipoDAO = new TipoUsuarioDAO();
            var tipos = tipoDAO.Lista();
            ViewBag.TipoUsuario = tipos;
            ViewBag.Pessoa = new PessoaFisica();
            return View();
        }
        public ActionResult Adiciona(PessoaFisica pessoa, string email)
        {            
            if (ModelState.IsValid) { 
                var pessoaFisicaDAO = new PessoaFisicaDAO();
                pessoaFisicaDAO.Adicionar(pessoa);
                pessoa.GetTipo();
                //if (!pessoa.Tipo.Equals("Cliente"))
                //{
                    var loginDAO = new LoginDAO();
                    var login = new Login();
                    login.Email = email;
                    login.PessoaFisicaID = pessoa.ID;
                    login.Senha = pessoa.CPF;
                    loginDAO.Adicionar(login);
                //}
                return RedirectToAction("Index");
            }
            else
            {
                var tipoDAO = new TipoUsuarioDAO();
                var tipos = tipoDAO.Lista();
                ViewBag.TipoUsuario = tipos;

                ViewBag.PessoaFisica = pessoa;
                //ViewBag.Login = login;
                return View("Form");
            }
        }

        public ActionResult Remove(int id)
        {
            var pessoaFisicaDAO = new PessoaFisicaDAO();
            var pessoa = pessoaFisicaDAO.Buscar(id);
            pessoaFisicaDAO.Remover(pessoa);
            return RedirectToAction("Index");
        }

        public ActionResult Edita(int id)
        {
            var pfDAO = new PessoaFisicaDAO();
            var pessoa = pfDAO.Buscar(id);
            ViewBag.Pessoa = pessoa;

            var tipoDAO = new TipoUsuarioDAO();
            var tipos = tipoDAO.Lista();
            ViewBag.TipoUsuario = tipos;

            return View();
        }

        public ActionResult Editar(PessoaFisica pessoa)
        {
            var pfDAO = new PessoaFisicaDAO();
            pfDAO.Atualizar(pessoa);

            var pessoas = pfDAO.Lista();
            ViewBag.Pessoa = pessoas;
            return RedirectToAction("Index");
        }
    }
}