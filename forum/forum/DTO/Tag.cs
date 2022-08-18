using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTO
{
    public class Tag
    {
        private int idTag;
        private string tituloPergunta;

        public int IdTag { get => idTag; set => idTag = value; }
        public string TituloPergunta { get => tituloPergunta; set => tituloPergunta = value; }

    }
}