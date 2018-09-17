using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoBanca.Models
{
    public abstract class Pessoa
    {
        public int ID{ get; private set; }
        public string Nome{ get; set; }      
        public string Bairro{ get; set; }
        public string Rua { get; set; }
        public int NumeroLogradouro { get; set; }
        public string Complemento{ get; set; }
    }
}