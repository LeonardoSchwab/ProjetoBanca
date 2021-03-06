﻿using Microsoft.EntityFrameworkCore;
using ProjetoBanca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoBanca.DAO
{
    public class ProjetoContext : DbContext
    {
        public DbSet<Categoria> Categoria{ get; private set; }
        public DbSet<PessoaFisica> PessoaFisica{ get; private set; }
        public DbSet<PessoaJuridica> PessoaJuridica{ get; private set; }
        public DbSet<Produto> Produto{ get; private set; }
        public DbSet<Promocao> Promocao{ get; private set; }
        public DbSet<Vendas> Vendas{ get; private set; }
        public DbSet<TipoUsuario> TipoUsuario{ get; private set; }
        public DbSet<ProdutoVendas> ProdutoVendas { get; private set; }
        public DbSet<Login> Login { get; private set; }
                
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ProjetoDB;Trusted_Connection=true;");
        }
    }
}