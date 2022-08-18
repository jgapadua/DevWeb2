using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace ProjetoCaixaEletronico.DTO
{
    public class Cliente
    {
        /// <summary>

        ///  Estrutura: Atributos, Encapsulamento e Metodos
        ///  Os nomes doa tributos devem ser identicos ao banco de dados e a sequencia do encapsulamente deve estar na mesma ordem do banco
        /// </summary>        

        private int idTb_Cliente;
        private string nm_cliente, nr_cpf, nr_rg;

        public int IdTb_Cliente { get => idTb_Cliente; set => idTb_Cliente = value; }
        public string Nm_cliente { get => nm_cliente; set => nm_cliente = value; }
        public string Nr_cpf { get => nr_cpf; set => nr_cpf = value; }
        public string Nr_rg { get => nr_rg; set => nr_rg = value; }
    }
}
