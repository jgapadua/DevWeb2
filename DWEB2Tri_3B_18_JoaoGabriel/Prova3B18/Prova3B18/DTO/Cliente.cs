using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace DTO
{
     public class Cliente
    {
        private int idCliente;
        private string nome, endereco,telefone, placaVeiculo;

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string PlacaVeiculo { get => placaVeiculo; set => placaVeiculo = value; }
    }
}