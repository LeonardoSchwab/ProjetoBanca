using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoBanca.Models
{
    public class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }
        public char Sexo { get; set; }
        public string DataNascimento { get; set; }
        public int TipoID { get; set; }
        public TipoUsuario Tipo { get; private set; }
        public int Pontos { get; set; }
    }
}