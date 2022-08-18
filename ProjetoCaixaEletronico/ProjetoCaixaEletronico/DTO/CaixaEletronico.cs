using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace ProjetoCaixaEletronico.DTO
{
    public class CaixaEletronico
    {
        /// <summary>

        ///  Estrutura: Atributos, Encapsulamento e Metodos
        ///  Os nomes doa tributos devem ser identicos ao banco de dados e a sequencia do encapsulamente deve estar na mesma ordem do banco
        /// </summary>        

        private int idtb_CaixaEletronico, Tb_Banco_idBanco;
        private double qt_disponivel;

        public int Idtb_CaixaEletronico { get => idtb_CaixaEletronico; set => idtb_CaixaEletronico = value; }
        public double Qt_disponivel { get => qt_disponivel; set => qt_disponivel = value; }
        public int Tb_Banco_idBanco1 { get => Tb_Banco_idBanco; set => Tb_Banco_idBanco = value; }
        
    }
}
