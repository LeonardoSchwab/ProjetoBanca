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
            ViewBag.Tipo = new TipoUsuario();
            return View();
        }
        public ActionResult Adiciona(TipoUsuario tipo)
        {
            if (ModelState.IsValid)
            {
                var tipoDAO = new TipoUsuarioDAO();
                tipoDAO.Adicionar(tipo);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Tipo = tipo;
                return View("Form");
            }
        }

        public ActionResult Remove(int id)
        {
            var tipoDAO = new TipoUsuarioDAO();
            var tipo = tipoDAO.Buscar(id);
            tipoDAO.Remover(tipo);
            return RedirectToAction("Index");
        }
    }
}