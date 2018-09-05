using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoBanca.Models
{
    public class PessoaFisica : Pessoa
    {
        public string CPF { get; private set; }
        public char Sexo { get; private set; }
        public string DataNascimento { get; private set; }
        public TipoUsuario Tipo { get; private set; }
        public int Pontos { get; private set; }
    }
}