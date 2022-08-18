using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTO
{
    public class Respostas
    {
        private int idResposta, membro_idMembro, pergunta_idPergunta;
        private string resposta;
        private DateTime dataResposta;

        public int IdResposta { get => idResposta; set => idResposta = value; }
        public int Membro_idMembro { get => membro_idMembro; set => membro_idMembro = value; }
        public int Pergunta_idPergunta { get => pergunta_idPergunta; set => pergunta_idPergunta = value; }
        public string Resposta { get => resposta; set => resposta = value; }
        public DateTime DataResposta { get => dataResposta; set => dataResposta = value; }
    }
}