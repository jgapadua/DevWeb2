using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bookonline.DTO
{
    public class Livro
    {
        private int idLivro, TBL_Editora_idEditora, numPaginas;
        private Autor autor = new Autor();
        private Editora editora = new Editora();
        private string titulo;
        private double valor;
        private DateTime dataCadastro;


        public int IdLivro { get => idLivro; set => idLivro = value; }
        public  Autor Autor { get => autor; set => autor = value; }
        public Editora Editora { get => editora; set => editora = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public DateTime DataCadastro { get => dataCadastro; set => dataCadastro = value; }
        public int NumPaginas { get => numPaginas; set => numPaginas = value; }
        public double Valor { get => valor; set => valor = value; }
    }
}