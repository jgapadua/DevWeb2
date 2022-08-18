using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTO
{
    public class PerguntaHastag
    {
        private int pergunta_idPergunta, tag_idTag;

        public int Pergunta_idPergunta { get => pergunta_idPergunta; set => pergunta_idPergunta = value; }
        public int Tag_idTag { get => tag_idTag; set => tag_idTag = value; }

    }
}