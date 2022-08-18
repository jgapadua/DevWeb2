using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OFICINA.DTO
{
    public class Cliente
    {
        private int id;
        private string nome, telefone, cpf;
        private DateTime data_nascimento;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public DateTime Data_nascimento { get => data_nascimento; set => data_nascimento = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Cpf { get => cpf; set => cpf = value; }
      
    }
}