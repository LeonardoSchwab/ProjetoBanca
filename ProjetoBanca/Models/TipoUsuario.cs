using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoBanca.Models
{
    public class TipoUsuario
    {
        public int ID{ get; set; }
        [Required]
        public string Nome { get; set; }
        public IList<PessoaFisica> Usuarios{ get; private set; }

        public TipoUsuario()
        {
            this.Usuarios = new List<PessoaFisica>();
        }
    }
}