using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoBanca.Models
{
    public class TipoUsuario
    {
        public int ID{ get; private set; }
        public string Nome { get; private set; }
        public IList<PessoaFisica> Usuarios{ get; private set; }

        public TipoUsuario()
        {
            this.Usuarios = new List<PessoaFisica>();
        }
    }
}