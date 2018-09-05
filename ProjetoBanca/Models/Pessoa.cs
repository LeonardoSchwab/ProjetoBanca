using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoBanca.Models
{
    public abstract class Pessoa
    {
        public int ID{ get; private set; }
        public string Nome{ get; private set; }      
        public string Bairro{ get; private set; }
        public string Rua { get; private set; }
        public int NumeroLogradouro { get; private set; }
        public string Complemento{ get; private set; }
    }
}