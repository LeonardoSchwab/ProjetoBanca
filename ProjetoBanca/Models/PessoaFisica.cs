using ProjetoBanca.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoBanca.Models
{
    public class PessoaFisica : Pessoa
    {
        [Required]
        public string CPF { get; set; }
        [Required]
        public char Sexo { get; set; }
        [Required]
        public string DataNascimento { get; set; }
        [Required]
        public int TipoID { get; set; }
        public TipoUsuario Tipo { get; private set; }
        public int Pontos { get; set; }
        //public int LoginID { get; set; }
        public Login Login { get; set; }

        public PessoaFisica()
        {
            //GetTipo();
        }

        public void GetTipo()
        {
            var tipoDAO = new TipoUsuarioDAO();
            var tipos = tipoDAO.Lista();

            this.Tipo = (from t in tipos
                                 where t.ID == this.TipoID
                                 select t).First();
        }
    }
}