using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class PerguntaBLL
    {
        private readonly DALProjeto dao;
        public PerguntaBLL()
        {
            dao = new DALProjeto("localhost", "stackoverflow", "root", "");
        }
        public DataTable ListarTodosPerguntas()
        {
            try
            {
                return dao.SelectAll("pergunta");
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void CadastrarDadosPerguntas(Pergunta pergunta)
        {
            try
            {
                pergunta.VotoPergunta = 0;
                pergunta.VisualizacoesPergunta = 0;
                pergunta.DataPergunta = DateTime.Now;
                dao.Insert("pergunta", pergunta);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void AlterarDadosPerguntas(Pergunta pergunta)
        {
            try
            {
                dao.Update("pergunta", pergunta, 0);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void ExcluirPerguntas(Pergunta pergunta)
        {
            try
            {
                dao.Delete("pergunta", pergunta, 0);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}