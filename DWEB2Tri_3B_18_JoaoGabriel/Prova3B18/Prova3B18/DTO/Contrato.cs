using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace DTO
{
    public class Contrato
    {
        private int idContrato, idCliente, idTipoContrato, numeroVaga;
        private double valor;
        private DateTime dataInicio;

        public int IdContrato { get => idContrato; set => idContrato = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int IdTipoContrato { get => idTipoContrato; set => idTipoContrato = value; }     
        public double Valor { get => valor; set => valor = value; }
        public DateTime DataInicio { get => dataInicio; set => dataInicio = value; }
        public int NumeroVaga { get => numeroVaga; set => numeroVaga = value; }
    }
}