using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Municipios.DTO
{
    public class Municipio
    {
        private int Id, Codigo;
        private string Nome, Uf;

        public int Id1 { get => Id; set => Id = value; }
        public int Codigo1 { get => Codigo; set => Codigo = value; }
        public string Nome1 { get => Nome; set => Nome = value; }
        public string Uf1 { get => Uf; set => Uf = value; }
    }
}