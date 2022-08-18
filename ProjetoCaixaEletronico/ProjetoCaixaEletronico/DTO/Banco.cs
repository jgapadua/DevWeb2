using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace ProjetoCaixaEletronico.DTO
{
    public class Banco
    {
        /// <summary>
       
        ///  Estrutura: Atributos, Encapsulamento e Metodos
        ///  Os nomes doa tributos devem ser identicos ao banco de dados e a sequencia do encapsulamente deve estar na mesma ordem do banco
        /// </summary>        

        private int idBanco;
        private string nr_banco, nmBanco;

        public int IdBanco { get => idBanco; set => idBanco = value; }
        public string Nr_banco { get => nr_banco; set => nr_banco = value; }
        public string NmBanco { get => nmBanco; set => nmBanco = value; }
    }
}
