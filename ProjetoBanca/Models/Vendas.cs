﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoBanca.Models
{
    public class Vendas
    {
        public int ID { get; set; }
        public IList<ProdutoVendas> Produtos{ get; private set; }        
        public double PrecoTotal{ get; set; }
        public int Quantidade{ get; set; }
        public DateTime Data { get; set; }

        public Vendas()
        {
            this.Produtos = new List<ProdutoVendas>();
        }
    }
}