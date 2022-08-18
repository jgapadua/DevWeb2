using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OFICINA.DTO
{
    public class Modelo
    {
        private int id, id_marca;
        private string nome;

        public int Id { get => id; set => id = value; }
        public int Id_marca { get => id_marca; set => id_marca = value; }
        public string Nome { get => nome; set => nome = value; }
    }
}