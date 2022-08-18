using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTO
{
    public class Pergunta
    {
        private int idPergunta, membro_idMembro, votoPergunta, visualizacoesPergunta;
        private string tituloPergunta, descricaoPergunta;
        private DateTime dataPergunta;

        public int IdPergunta { get => idPergunta; set => idPergunta = value; }
        public int Membro_idMembro { get => membro_idMembro; set => membro_idMembro = value; }
        public string TituloPergunta { get => tituloPergunta; set => tituloPergunta = value; }
        public string DescricaoPergunta { get => descricaoPergunta; set => descricaoPergunta = value; }
        public int VotoPergunta { get => votoPergunta; set => votoPergunta = value; }
        public int VisualizacoesPergunta { get => visualizacoesPergunta; set => visualizacoesPergunta = value; }
        public DateTime DataPergunta { get => dataPergunta; set => dataPergunta = value; }



    }
}