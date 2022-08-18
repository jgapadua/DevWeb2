using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace ProjetoCaixaEletronico.DTO
{
    public class Conta
    {
        /// <summary>

        ///  Estrutura: Atributos, Encapsulamento e Metodos
        ///  Os nomes doa tributos devem ser identicos ao banco de dados e a sequencia do encapsulamente deve estar na mesma ordem do banco
        /// </summary>        

        private int idTb_conta, nr_conta, cd_status, Tb_Banco_idBanco, Tb_Cliente_idTb_Cliente;
        private string nr_senha;
        private double vl_saldo;

        public int IdTb_conta { get => idTb_conta; set => idTb_conta = value; }
        public string Nr_senha { get => nr_senha; set => nr_senha = value; }
        public int Nr_conta { get => nr_conta; set => nr_conta = value; }
        public double Vl_saldo { get => vl_saldo; set => vl_saldo = value; }
        public int Cd_status { get => cd_status; set => cd_status = value; }
        public int Tb_Banco_idBanco1 { get => Tb_Banco_idBanco; set => Tb_Banco_idBanco = value; }
        public int Tb_Cliente_idTb_Cliente1 { get => Tb_Cliente_idTb_Cliente; set => Tb_Cliente_idTb_Cliente = value; }  
    }
}
