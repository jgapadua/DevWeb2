using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class PerguntaHastagBLL
    {
        private readonly DALProjeto dao;
        public PerguntaHastagBLL()
        {
            dao = new DALProjeto("localhost", "stackoverflow", "root", "");
        }
        public DataTable ListarTodosPerguntasHastag()
        {
            try
            {
                return dao.SelectAll("perguntahastag");
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void CadastrarDadosPerguntasHastag(PerguntaHastag perguntahastag)
        {
            try
            {
                dao.Insert("perguntahastag", perguntahastag);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void AlterarDadosPerguntasHastag(PerguntaHastag perguntahastag)
        {
            try
            {
                dao.Update("perguntahastag", perguntahastag, 0);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void ExcluirPerguntasHastag(PerguntaHastag perguntahastag)
        {
            try
            {
                dao.Delete("perguntahastag", perguntahastag, 0);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}