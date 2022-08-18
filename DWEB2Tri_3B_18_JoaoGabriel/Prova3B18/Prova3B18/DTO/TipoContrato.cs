using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace DTO
{
      public class TipoContrato
    {
        private int idTipoContrato;
        private string descricao;

        public int IdTipoContrato { get => idTipoContrato; set => idTipoContrato = value; }
        public string Descricao { get => descricao; set => descricao = value; }
    }
}