using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bookonline.DTO
{
    public class Editora
    {

        private int idEditora;
        private string nome, endereco, UF;

        public int IdEditora { get => idEditora; set => idEditora = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string UF1 { get => UF; set => UF = value; }
    }
}