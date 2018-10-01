using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoBanca.Models
{
    public class Categoria
    {
        public int ID{ get; set; }
        [Required(ErrorMessage = "Categoria precisa ser digitada!")]
        public string Nome { get; set; }
        public IList<Produto> Produtos { get; private set; }
    }
}