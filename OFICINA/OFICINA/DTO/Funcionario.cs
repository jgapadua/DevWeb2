using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OFICINA.DTO
{
    public class Funcionario
    {
        private int id;
        private string nome, telefone, cpf,endereco, numero, complemento, bairro, cep, cidade, uf;
        private DateTime data_nascimento;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public DateTime Data_nascimento { get => data_nascimento; set => data_nascimento = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Uf { get => uf; set => uf = value; }
    
    }
}