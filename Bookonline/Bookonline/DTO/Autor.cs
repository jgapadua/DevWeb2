using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bookonline.DTO
{
    public class Autor
    {
        private int idAutor, idade;
        private string nome;

        public int IdAutor { get => idAutor; set => idAutor = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
    }
}